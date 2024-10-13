Public Class ResellersForm

    Private Sub ResllersForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myList As List(Of ResellerDataClass) = GetResellers()

        resellersDataGridView.Rows.Clear()

        For i = 0 To myList.Count - 1
            With myList(i)
                resellersDataGridView.Rows.Add(.id, .name)
            End With
        Next

        Label1.Text = myList.Count & " Resellers"
    End Sub

    Public Function GetResellers() As List(Of ResellerDataClass)
        Dim myList As New List(Of ResellerDataClass)
        Dim myTable As New DataTable
        Dim mySql As New SQLStatementClass

        mySql.SetPrimaryTable("Resellers")
        mySql.AddSelectString("id", "")
        mySql.AddSelectString("name", "")
        mySql.AddOrderByString("name")

        If FillTableFromCommand(Form1.CONNECTION_STRING, mySql.GetSQLStatement, myTable) Then
            If myTable.Rows.Count > 0 Then
                For i = 0 To myTable.Rows.Count - 1
                    With myTable.Rows(i)
                        Dim x As New ResellerDataClass(.Item(0), .Item(1))

                        myList.Add(x)
                    End With
                Next
            End If
        End If

        Return myList
    End Function
End Class