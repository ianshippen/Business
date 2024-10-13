Public Class NewInstallationForm

    Private Sub NewInstallationForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myResellers As List(Of ResellerDataClass) = ResellersForm.GetResellers()
        Dim myCustomers As List(Of CustomerDataClass) = CustomersForm.GetCustomers()

        resellerComboBox.Items.Clear()
        customerComboBox.Items.Clear()

        For Each reseller As ResellerDataClass In myResellers
            resellerComboBox.Items.Add(reseller.name)
        Next

        For Each customer As CustomerDataClass In myCustomers
            customerComboBox.Items.Add(customer.name)
        Next

        invoiceTextBox.Clear()
        descriptionTextBox.Clear()
        installationDateTextBox.Clear()
        paymentDateTextBox.Clear()
        annualSupportTextBox.Clear()
        supportExpiresTextBox.Clear()
        trainingDateTextBox.Clear()
        invoiceDateTextBox.Clear()
        notesTextBox.Clear()
        priceTextBox.Text = "0.00"
        inSupportComboBox.SelectedItem = "Yes"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If NewCustomerForm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim s As New CompositeSQLClass

            s.AddCommand("declare @myMaxId int")
            s.AddCommand("set @myMaxId = (select MAX(Id) from Customers)")
            s.AddCommand("insert into Customers values(@myMaxId + 1, " & WrapInSingleQuotes(NewCustomerForm.customerNameTextBox.Text) & ", 1)")

            If ExecuteNonQuery(Form1.CONNECTION_STRING, s.GenerateCompositeCommand) Then
                Dim myCustomers As List(Of CustomerDataClass) = CustomersForm.GetCustomers()

                MsgBox("New customer added to database")
                resellerComboBox.SelectedItem = NewCustomerForm.resellerComboBox.SelectedItem

                customerComboBox.Items.Clear()

                For Each customer As CustomerDataClass In myCustomers
                    customerComboBox.Items.Add(customer.name)
                Next

                customerComboBox.SelectedItem = NewCustomerForm.customerNameTextBox.Text
            Else
                MsgBox("Error in adding new customer to database")
            End If
        End If
    End Sub

    
    Private Sub okButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okButton.Click
        Dim mySql As New SQLStatementClass
        Dim myResellers As List(Of ResellerDataClass) = ResellersForm.GetResellers()
        Dim myCustomers As List(Of CustomerDataClass) = CustomersForm.GetCustomers()
        Dim myResellerId As Integer = -1
        Dim myCustomerId As Integer = -1
        Dim s As New CompositeSQLClass

        For Each reseller As ResellerDataClass In myResellers
            If reseller.name = resellerComboBox.SelectedItem Then
                myResellerId = reseller.id
                Exit For
            End If
        Next

        For Each customer As CustomerDataClass In myCustomers
            If customer.name = customerComboBox.SelectedItem Then
                myCustomerId = customer.id
                Exit For
            End If
        Next

        s.AddCommand("declare @myMaxId int")
        s.AddCommand("set @myMaxId = (select MAX(Id) from Installations)")

        mySql.SetInsertIntoTable("installations")
        mySql.AddValue("@myMaxId + 1")
        mySql.AddValue(myResellerId)
        mySql.AddValue(myCustomerId)
        mySql.AddValue(NullWrap(invoiceTextBox.Text))
        mySql.AddValue(NullWrap(descriptionTextBox.Text))
        mySql.AddValue(NullWrap(installationDateTextBox.Text))
        mySql.AddValue(NullWrap(paymentDateTextBox.Text))
        mySql.AddValue(NullWrap(annualSupportTextBox.Text))
        mySql.AddValue(NullWrap(supportExpiresTextBox.Text))
        mySql.AddValue(NullWrap(trainingDateTextBox.Text))
        mySql.AddValue(NullWrap(invoiceDateTextBox.Text))
        mySql.AddValue(NullWrap(notesTextBox.Text))
        mySql.AddValue(NullWrap(priceTextBox.Text))
        mySql.AddValue(NullWrap(inSupportComboBox.SelectedItem))

        s.AddCommand(mySql.GetSQLStatement)
        If ExecuteNonQuery(Form1.CONNECTION_STRING, s.GenerateCompositeCommand) Then
            MsgBox("New installation added to the database")
        Else
            MsgBox("Error in adding new installation to the database")
        End If

        DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Public Function NullWrap(ByRef p As Object) As String
        Dim result As String = "NULL"

        If Not p Is DBNull.Value Then
            If Not p Is Nothing Then
                Dim myString As String = p

                If myString <> "" Then result = WrapInSingleQuotes(myString)
            End If
        End If

        Return result
    End Function
End Class