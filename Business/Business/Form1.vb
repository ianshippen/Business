Public Class Form1
    Public Const CONNECTION_STRING As String = "Provider=SQLOLEDB;Data Source=.\SQLEXPRESS;Initial Catalog=Business;Integrated Security=SSPI"

    Private Sub ResellersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResellersToolStripMenuItem.Click
        ResellersForm.ShowDialog()
    End Sub

    Private Sub CustomersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomersToolStripMenuItem.Click
        CustomersForm.ShowDialog()
    End Sub

    Private Sub InstallationsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InstallationsToolStripMenuItem.Click
        InstallationsForm.ShowDialog()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitLogutilConfig()
    End Sub
End Class
