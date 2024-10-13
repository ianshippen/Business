Public Class InstallationsForm
    Dim annualSupport As Integer = 0
    Dim loaded As Boolean = False
    Dim yDelta As Integer = 0

    Private Sub InstallationsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UpdateInstallationsForm()
    End Sub

    Private Sub UpdateInstallationsForm()
        Dim myTable As New DataTable
        Dim mySql As New SQLStatementClass
        Dim redAmount As Integer = 0
        Dim amberAmount As Integer = 0

        loaded = False
        yDelta = Me.Height - installationsDataGridView.Height
        resellerComboBox.Items.Clear()
        resellerComboBox.Items.Add("All ..")
        supportExpiredComboBox.SelectedItem = 0

        mySql.SetPrimaryTable("Installations")
        mySql.AddJoin(SQLStatementClass.JoinType.LEFT_JOIN, "Resellers", "resellerId", "id")
        mySql.AddJoin(SQLStatementClass.JoinType.LEFT_JOIN, "Customers", "customerId", "id")

        mySql.AddSelectString("a.id", "")
        mySql.AddSelectString("Resellers.name", "")
        mySql.AddSelectString("Customers.name", "")
        mySql.AddSelectString("A.invoice", "")
        mySql.AddSelectString("description", "")
        mySql.AddSelectString("installationDate", "")
        mySql.AddSelectString("paymentDate", "")
        mySql.AddSelectString("case when resellerId = 1 then 120 else annualSupport end", "")
        mySql.AddSelectString("left(convert(varchar, case when resellerId = 1 then DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE())+1,0)) else supportExpires end, 120), 10)", "")
        mySql.AddSelectString("price", "")
        mySql.AddSelectString("notes", "")
        mySql.AddSelectString("datediff(d, supportExpires, getdate())", "")
        mySql.AddSelectString("active", "")
        mySql.AddSelectString("inSupport", "")

        mySql.AddOrderByString("customers.name")
        mySql.AddOrderByString("description")

        installationsDataGridView.Rows.Clear()

        If FillTableFromCommand(Form1.CONNECTION_STRING, mySql.GetSQLStatement, myTable) Then
            If myTable.Rows.Count > 0 Then
                For i = 0 To myTable.Rows.Count - 1
                    With myTable.Rows(i)
                        Dim myActive As Boolean = True
                        Dim myInSupport As Boolean = False

                        If .Item(12) IsNot DBNull.Value Then
                            If .Item(12) = 0 Then myActive = False
                        End If

                        If .Item(13) = "Yes" Then myInSupport = True

                        Dim rowIndex = installationsDataGridView.Rows.Add(.Item(0), .Item(1), .Item(2), CheckForNull(.Item(3)), CheckForNull(.Item(4)), CheckForNull(.Item(5)), CheckForNull(.Item(6)), CheckForNull(.Item(7)), CheckForNull(.Item(8)), .Item(9), .Item(10), myActive, myInSupport)

                        installationsDataGridView.Rows(rowIndex).HeaderCell.Value = CStr(rowIndex + 1)

                        If myInSupport Then
                            ' Valid support data ?
                            If .Item(7) IsNot DBNull.Value Then
                                If .Item(1) <> "Elite Telecom" Then
                                    annualSupport += CInt(.Item(7))
                                End If
                            End If

                            ' Valid support delta ? This is a +ve number for every day the support has expired, and <= 0 if not expired
                            If Not .Item(11) Is DBNull.Value Then
                                ' Has it expired ?
                                'If .Item(11) > 0 Then
                                ' Is there a pending invoice for this support contract ?
                                Select Case UpdateSupportColour(rowIndex, .Item(11))
                                    Case Color.Red
                                        If myActive Then redAmount += CInt(.Item(7))

                                    Case Color.Orange
                                        amberAmount += CInt(.Item(7))
                                End Select

                                'End If
                            End If
                        Else
                            SetSupportColour(rowIndex, Color.Gray)
                        End If

                        If Not resellerComboBox.Items.Contains(.Item(1)) Then resellerComboBox.Items.Add(.Item(1))
                    End With
                Next
            End If

            DisplayStatus(myTable.Rows.Count)
        End If

        resellerComboBox.SelectedItem = "All .."
        supportExpiredComboBox.SelectedItem = "All .."
        activeComboBox.SelectedItem = "Active"
        Label2.Text = "Expired support (red) = £" & redAmount
        Label3.Text = "Invoiced support (amber) = £" & amberAmount
        loaded = True
    End Sub

    Private Sub DisplayStatus(ByVal p_rowCount As Integer)
        Label1.Text = p_rowCount & " installations, Elite annual support = £14,400, remaining annual support = £" & MoneyFormat(annualSupport)
    End Sub

    Private Function UpdateSupportColour(ByVal p_rowIndex As Integer, ByVal p_delta As Integer) As Color
        Dim myTable As New DataTable
        Dim mySql As New SQLStatementClass
        Dim myInstallationId As Integer = CInt(installationsDataGridView.Rows(p_rowIndex).Cells(0).Value)
        Dim myColour As Color = Color.Red

        ' White means support is paid
        ' Red means support expired
        ' Orange means support expired but has been invoiced
        ' Green means invoice has been sent but not expired from current support period yet
        ' Grey means not in support anymore (not ticked)

        ' Get the record with the most recent expiry date for this installation
        mySql.Clear()
        mySql.SetPrimaryTable("Support")
        mySql.AddSelectString("top 1 paid", "")
        mySql.AddSelectString("datediff(d, expires, GetDate())", "daysExpired")
        mySql.AddSelectString("datediff(year, GetDate(), expires)", "yearsCredit")
        mySql.AddCondition("installationId = " & myInstallationId)
        mySql.AddOrderByString("expires desc")

        If FillTableFromCommand(Form1.CONNECTION_STRING, mySql.GetSQLStatement, myTable) Then
            If myTable.Rows.Count = 1 Then
                With myTable.Rows(0)
                    Dim mostRecentWasPaid As Boolean = True

                    If .Item("paid") Is DBNull.Value Then mostRecentWasPaid = False

                    If .Item("daysExpired") <= 0 Then
                        Dim myPaidTable As New DataTable

                        mySql.AddCondition("paid IS NOT NULL")

                        If FillTableFromCommand(Form1.CONNECTION_STRING, mySql.GetSQLStatement, myPaidTable) Then
                            ' Is latest paid entry valid ?
                            If myPaidTable.Rows.Count = 1 Then
                                With myPaidTable.Rows(0)
                                    If .Item("daysExpired") > 0 Then
                                        myColour = Color.Orange
                                    Else
                                        ' Any future unpaid entries ?
                                        If mostRecentWasPaid Then
                                            myColour = Color.White
                                        Else
                                            myColour = Color.Green
                                        End If
                                    End If
                                End With
                            Else
                                ' No
                                myColour = Color.Orange
                            End If
                        End If
                    End If
                End With
            Else
                ' Check if no expiry for no pending support invoice
                If p_delta <= 0 Then myColour = Color.White
            End If
        End If

        ' Default colour for the row is red - expired with no invoice submitted
        installationsDataGridView.Rows(p_rowIndex).DefaultCellStyle.BackColor = myColour

        Return myColour
    End Function

    Private Sub SetSupportColour(ByVal p_rowIndex As Integer, ByVal p_colour As Color)
        installationsDataGridView.Rows(p_rowIndex).DefaultCellStyle.BackColor = p_colour
    End Sub

    Private Sub resellerComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resellerComboBox.SelectedIndexChanged
        SelectedResellerChanged(True)
    End Sub

    Private Sub SelectedResellerChanged(ByVal p_turnOn As Boolean)
        If loaded Then
            Dim x As String = resellerComboBox.SelectedItem
            Dim visibleRowCount As Integer = 0

            If x IsNot Nothing Then
                If x.Contains("..") Then
                    ' Enable all rows
                    For i = 0 To installationsDataGridView.Rows.Count - 1
                        With installationsDataGridView.Rows(i)
                            If p_turnOn Then
                                .Visible = True
                                visibleRowCount += 1
                            End If
                        End With
                    Next
                Else
                    For i = 0 To installationsDataGridView.Rows.Count - 1
                        With installationsDataGridView.Rows(i)
                            If .Cells(1).Value = x Then
                                If p_turnOn Then
                                    .Visible = True
                                    visibleRowCount += 1
                                End If
                            Else
                                .Visible = False
                            End If
                        End With
                    Next
                End If

                If p_turnOn Then
                    SelectedSupportExpiredChanged(False)
                    SelectedActiveChanged(False)
                End If
            End If

            UpdateRowHeaders()
            DisplayStatus(visibleRowCount)
        End If
    End Sub

    Private Sub UpdateRowHeaders()
        With installationsDataGridView
            Dim myCount As Integer = 1

            For i = 0 To .Rows.Count - 1
                If .Rows(i).Visible Then
                    .Rows(i).HeaderCell.Value = CStr(myCount)
                    myCount += 1
                End If
            Next
        End With
    End Sub

    Private Sub supportExpiredComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles supportExpiredComboBox.SelectedIndexChanged
        SelectedSupportExpiredChanged(True)
    End Sub

    Private Sub SelectedSupportExpiredChanged(ByVal p_turnOn As Boolean)
        Dim x As String = supportExpiredComboBox.SelectedItem

        If x IsNot Nothing Then
            If x.Contains("..") Then
                For i = 0 To installationsDataGridView.Rows.Count - 1
                    With installationsDataGridView.Rows(i)
                        If p_turnOn Then .Visible = True
                    End With
                Next
            Else
                For i = 0 To installationsDataGridView.Rows.Count - 1
                    With installationsDataGridView.Rows(i)
                        Dim myFlag As Boolean = False

                        If .DefaultCellStyle.BackColor = Color.Red Or .DefaultCellStyle.BackColor = Color.Orange Then myFlag = True

                        If x.Contains("Non-") Then myFlag = Not myFlag

                        If myFlag Then
                            If p_turnOn Then .Visible = True
                        Else
                            .Visible = False
                        End If
                    End With
                Next
            End If

            If p_turnOn Then
                SelectedResellerChanged(False)
                SelectedActiveChanged(False)
            End If
        End If
    End Sub

    Private Sub activeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles activeComboBox.SelectedIndexChanged
        SelectedActiveChanged(True)
    End Sub

    Private Sub SelectedActiveChanged(ByVal p_turnOn As Boolean)
        Dim x As String = activeComboBox.SelectedItem

        If x IsNot Nothing Then
            If x.Contains("..") Then
                For i = 0 To installationsDataGridView.Rows.Count - 1
                    With installationsDataGridView.Rows(i)
                        If p_turnOn Then .Visible = True
                    End With
                Next
            Else
                For i = 0 To installationsDataGridView.Rows.Count - 1
                    With installationsDataGridView.Rows(i)
                        Dim myFlag As Boolean = installationsDataGridView.Rows(i).Cells(11).Value

                        If x.Contains("Non-") Then myFlag = Not myFlag

                        If myFlag Then
                            If p_turnOn Then .Visible = True
                        Else
                            .Visible = False
                        End If
                    End With
                Next
            End If

            If p_turnOn Then
                SelectedSupportExpiredChanged(False)
                SelectedResellerChanged(False)
            End If
        End If
    End Sub

    Private Sub installationsDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles installationsDataGridView.CellDoubleClick
        If e.ColumnIndex = 7 Or e.ColumnIndex = 8 Then
            ' Is there already an unpaid support contract for this installation ?
            Dim myTable As New DataTable
            Dim x As New SQLStatementClass
            Dim myInvoiceRef As String = ""
            Dim myNow As String = Now.Year & "-" & Pad(Now.Month) & "-" & Pad(Now.Day)
            Dim myTimeStamp As String = myNow
            Dim alreadyInDatabase As Boolean = False
            Dim myInstallationId As Integer = installationsDataGridView.Rows(e.RowIndex).Cells(0).Value
            Dim myExpires As String = ""
            Dim myLastInvoice As String = ""

            With RenewSupportForm
                x.SetPrimaryTable("Support")
                x.AddSelectString("*", "")
                x.AddCondition("installationId = " & myInstallationId)
                x.AddOrderByString("expires desc")

                .paidOnDateTextBox.Clear()

                If FillTableFromCommand(Form1.CONNECTION_STRING, x.GetSQLStatement, myTable) Then
                    If myTable.Rows.Count > 0 Then
                        With myTable.Rows(0)
                            If .Item("paid") Is DBNull.Value Then
                                ' Yes. Populate the data into the form below
                                myInvoiceRef = .Item("invoice")
                                myTimeStamp = .Item("timestamp")
                                myExpires = .Item("expires")
                                alreadyInDatabase = True
                            Else
                                myLastInvoice = .Item("invoice")
                            End If
                        End With
                    End If
                End If

                Dim expires As String = installationsDataGridView.Rows(e.RowIndex).Cells(8).Value
                Dim from As String = expires
                Dim fromYear, fromMonth, fromDay, daysInMonth As Integer

                expires = CStr(CInt(expires.Substring(0, 4)) + 1) & expires.Substring(4)
                fromYear = CInt(from.Substring(0, 4))
                fromMonth = CInt(from.Substring(5, 2))
                fromDay = CInt(from.Substring(8, 2))
                daysInMonth = 31

                Select Case fromMonth
                    Case 4, 6, 9, 11
                        daysInMonth = 30

                    Case 2
                        If fromYear Mod 4 = 0 Then
                            daysInMonth = 29
                        Else
                            daysInMonth = 28
                        End If
                End Select

                fromDay += 1

                If fromDay > daysInMonth Then
                    fromDay = 1
                    fromMonth += 1

                    If fromMonth = 13 Then
                        fromMonth = 1
                        fromYear += 1
                    End If
                End If

                [from] = fromYear & "-" & Pad(fromMonth) & "-" & Pad(fromDay)

                .TextBox1.Text = installationsDataGridView.Rows(e.RowIndex).Cells(0).Value
                .TextBox2.Text = installationsDataGridView.Rows(e.RowIndex).Cells(4).Value
                .TextBox3.Text = installationsDataGridView.Rows(e.RowIndex).Cells(2).Value
                .TextBox4.Text = installationsDataGridView.Rows(e.RowIndex).Cells(1).Value
                .TextBox5.Text = [from]
                .TextBox6.Text = expires
                .TextBox7.Text = installationsDataGridView.Rows(e.RowIndex).Cells(7).Value
                .invoiceTextBox.Text = myInvoiceRef

                .invoiceDateTextBox.Text = myTimeStamp
                .TextBox11.Text = myLastInvoice

                .TextBox5.ReadOnly = alreadyInDatabase
                .TextBox6.ReadOnly = alreadyInDatabase
                .TextBox7.ReadOnly = alreadyInDatabase
                .invoiceTextBox.ReadOnly = alreadyInDatabase
                .invoiceDateTextBox.ReadOnly = alreadyInDatabase
                .paidOnDateTextBox.Enabled = alreadyInDatabase

                If alreadyInDatabase Then .paidOnDateTextBox.Text = myNow

                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    x.Clear()

                    If alreadyInDatabase Then
                        ' Update existing record
                        x.SetUpdateTable("Support")
                        x.AddSet("paid", WrapInSingleQuotes(.paidOnDateTextBox.Text))
                        x.AddCondition("installationId = " & myInstallationId)
                        x.AddCondition("paid is NULL")

                        If ExecuteNonQuery(Form1.CONNECTION_STRING, x.GetSQLStatement) Then
                            UpdateSupportColour(e.RowIndex, -1)
                            installationsDataGridView.Rows(e.RowIndex).Cells(8).Value = myExpires
                            x.Clear()
                            x.SetUpdateTable("Installations")
                            x.AddSet("supportExpires", WrapInSingleQuotes(myExpires))
                            x.AddCondition("id = " & myInstallationId)
                        Else
                            MsgBox("Problem updating database")
                        End If
                    Else
                        x.SetInsertIntoTable("Support")

                        x.AddValue(.TextBox1.Text)
                        x.AddValue(WrapInSingleQuotes(.invoiceDateTextBox.Text))
                        x.AddValue(WrapInSingleQuotes(.invoiceTextBox.Text))
                        x.AddValue(WrapInSingleQuotes(expires))
                        x.AddValue("NULL")
                    End If

                    If ExecuteNonQuery(Form1.CONNECTION_STRING, x.GetSQLStatement) Then
                        UpdateSupportColour(e.RowIndex, -1)
                        MsgBox("Database updated OK")
                    Else
                        MsgBox("Problem updating database")
                    End If
                End If
            End With
        End If
    End Sub

    Private Sub AddInstallationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddInstallationToolStripMenuItem.Click
        NewInstallationForm.ShowDialog()
    End Sub

    Private Sub installationsDataGridView_CellLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles installationsDataGridView.CellLeave
        Dim myId As Integer = -1
        Dim dbColumn As String = ""

        installationsDataGridView.CommitEdit(DataGridViewDataErrorContexts.CurrentCellChange)

        With installationsDataGridView.Rows(e.RowIndex)
            myId = .Cells(0).Value

            ' Don't try and update change to Active Customer from this view
            If e.ColumnIndex >= 3 And e.ColumnIndex <> 11 Then
                Dim mySql As New SQLStatementClass
                Dim myValue As String = NewInstallationForm.NullWrap(.Cells(e.ColumnIndex).Value)

                If e.ColumnIndex = 12 Then
                    If .Cells(e.ColumnIndex).Value.ToString.ToLower = "true" Then
                        myValue = "'Yes'"
                    Else
                        myValue = "'No'"
                    End If
                End If

                dbColumn = installationsDataGridView.Columns(e.ColumnIndex).HeaderCell.Value.ToString.Replace(" ", "")
                mySql.SetUpdateTable("Installations")
                mySql.AddSet(dbColumn, myValue)
                mySql.AddCondition("Id = " & myId)

                If Not ExecuteNonQuery(Form1.CONNECTION_STRING, mySql.GetSQLStatement) Then
                    MsgBox("Error in updating database")
                End If
            End If
        End With
    End Sub

    Private Sub InstallationsForm_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If loaded Then
            installationsDataGridView.Height = Me.Height - yDelta
        End If
    End Sub
End Class