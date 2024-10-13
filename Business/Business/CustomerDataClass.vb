Public Class CustomerDataClass
    Public id As Integer
    Public name As String
    Public resellerName As String
    Public active As Boolean

    Public Sub New(ByVal p_id As Integer, ByVal p_name As String, ByVal p_resellerName As String, ByVal p_active As Boolean)
        id = p_id
        name = p_name
        resellerName = p_resellerName
        active = p_active
    End Sub
End Class
