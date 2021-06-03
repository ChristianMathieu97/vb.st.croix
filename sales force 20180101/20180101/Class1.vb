Public Class MySettingsChanger

    ''' <summary>
    ''' This procedure sets the connection string at run-time
    ''' </summary>
    ''' <param name="cnnString">The connection string</param>
    ''' <remarks></remarks>

    Public Shared Sub SetConnectionString(ByVal cnnString As String)
        My.Settings.RunTimeConnectionString = cnnString
    End Sub

End Class
