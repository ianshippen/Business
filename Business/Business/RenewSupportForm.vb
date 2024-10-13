Public Class RenewSupportForm
    Private Sub okButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okButton.Click
        If invoiceTextBox.Text = "" Then
            MsgBox("Please provide an Invoice Reference")
        Else
            DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub
End Class