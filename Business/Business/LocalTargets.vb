Module LocalTargets
    Public Function GetCollationFixSetting() As Boolean
        Return False
    End Function

    Public Function CheckForNull(ByRef p As Object)
        Dim result As String = ""

        If Not p Is DBNull.Value Then result = p

        Return result
    End Function

    Public Function MoneyFormat(ByVal p As Integer) As String
        Dim result As String = p

        If result.Length > 3 Then result = result.Substring(0, result.Length - 3) & "," & result.Substring(result.Length - 3)

        Return result
    End Function

    Public Function Pad(ByRef p As String) As String
        Dim result As String = p

        If p.Length = 1 Then result = "0" & p

        Return result
    End Function
End Module
