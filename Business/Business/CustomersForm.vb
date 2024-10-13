Public Class CustomersForm
    Private Sub CustomersForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myList As List(Of CustomerDataClass) = GetInstalledCustomers()

        customersDataGridView.Rows.Clear()

        For i = 0 To myList.Count - 1
            With myList(i)
                customersDataGridView.Rows.Add(.id, .name, .resellerName, .active)
            End With
        Next

        Label1.Text = myList.Count & " Customers"
    End Sub

    Public Function GetCustomers() As List(Of CustomerDataClass)
        Dim myList As New List(Of CustomerDataClass)
        Dim myTable As New DataTable
        Dim mySql As New SQLStatementClass

        mySql.SetPrimaryTable("Customers")
        mySql.AddSelectString("id", "")
        mySql.AddSelectString("name", "")
        mySql.AddSelectString("active", "")
        mySql.AddOrderByString("name")

        If FillTableFromCommand(Form1.CONNECTION_STRING, mySql.GetSQLStatement, myTable) Then
            If myTable.Rows.Count > 0 Then
                For i = 0 To myTable.Rows.Count - 1
                    With myTable.Rows(i)
                        Dim myActive As Boolean = False : If CInt(.Item(2)) = 1 Then myActive = True

                        Dim x As New CustomerDataClass(.Item(0), .Item(1), "", myActive)

                        myList.Add(x)
                    End With
                Next
            End If
        End If

        Return myList
    End Function

    Public Function GetInstalledCustomers() As List(Of CustomerDataClass)
        Dim myList As New List(Of CustomerDataClass)
        Dim myTable As New DataTable
        Dim mySql As New SQLStatementClass

        mySql.SetPrimaryTable("Installations")
        mySql.AddJoin(SQLStatementClass.JoinType.LEFT_JOIN, "Resellers", "resellerId", "id")
        mySql.AddJoin(SQLStatementClass.JoinType.LEFT_JOIN, "Customers", "customerId", "id")
        mySql.AddSelectString("distinct customerId", "")
        mySql.AddSelectString("Customers.name", "")
        mySql.AddSelectString("Resellers.name", "")
        mySql.AddSelectString("Customers.active", "")
        mySql.AddOrderByString("Customers.name")

        If FillTableFromCommand(Form1.CONNECTION_STRING, mySql.GetSQLStatement, myTable) Then
            If myTable.Rows.Count > 0 Then
                For i = 0 To myTable.Rows.Count - 1
                    With myTable.Rows(i)
                        Dim myResellerName As String = ""
                        Dim myActive As Boolean = False : If CInt(.Item(3)) = 1 Then myActive = True

                        If Not .Item(2) Is DBNull.Value Then myResellerName = .Item(2)

                        Dim x As New CustomerDataClass(.Item(0), .Item(1), myResellerName, myActive)

                        myList.Add(x)
                    End With
                Next
            End If
        End If

        Return myList
    End Function
End Class