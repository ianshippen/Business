Public Class NewCustomerForm
    Private Sub NewCustomerForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myResellers As List(Of ResellerDataClass) = ResellersForm.GetResellers()

        resellerComboBox.Items.Clear()
        customerNameTextBox.Clear()

        For Each reseller As ResellerDataClass In myResellers
            resellerComboBox.Items.Add(reseller.name)
        Next

        If resellerComboBox.Items.Count > 0 Then resellerComboBox.SelectedIndex = 0
    End Sub

    Private Sub okButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okButton.Click
        If customerNameTextBox.Text <> "" Then
            Dim myCustomers As List(Of CustomerDataClass) = CustomersForm.GetCustomers()
            Dim alreadyThere As Boolean = False

            For Each customer As CustomerDataClass In myCustomers
                If StrComp(customer.name, customerNameTextBox.Text, CompareMethod.Text) = 0 Then
                    alreadyThere = True
                    Exit For
                End If
            Next

            If alreadyThere Then
                MsgBox("Customer name " & WrapInQuotes(customerNameTextBox.Text & " is already in the database"))
            Else
                DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub
End Class