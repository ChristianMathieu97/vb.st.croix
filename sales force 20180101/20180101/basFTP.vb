Imports System.Net
Imports System.IO

''' <summary>
''' This code was borrowed from the internet and modified for Knitcraft
''' </summary>
''' <remarks></remarks>

Module basFTP

    Public Class FtpSession
        Public ftpUser As String
        Public ftpPwd As String
        Dim fwr As FtpWebRequest

        ''' <summary>
        ''' This procedure gets a listing of files from a directory on the FTP server
        ''' </summary>
        ''' <param name="DirectoryUri"></param> the path to the directory (a.k.a folder)
        ''' <returns></returns> listing of files from a directory on the FTP server
        ''' <remarks></remarks>

        Function RetrieveFtpDirectory(ByVal DirectoryUri As String) As String()
            Dim sOut As String() = Nothing

            fwr = FtpWebRequest.Create(DirectoryUri)
            fwr.Credentials = New NetworkCredential(ftpUser, ftpPwd)
            fwr.Method = WebRequestMethods.Ftp.ListDirectory
            fwr.KeepAlive = False
            Try
                Dim frs As FtpWebResponse
                frs = fwr.GetResponse

            Dim sr As New StreamReader(fwr.GetResponse().GetResponseStream())
            sOut = Split(sr.ReadToEnd, vbCrLf)

            'Dim str As String = sr.ReadLine()
            'While Not str Is Nothing
            '    Console.WriteLine(str)
            '    str = sr.ReadLine()
            'End While

                sr.Close()
                sr = Nothing
            Catch e As Exception
                Console.WriteLine(e.Message)
            End Try
            Return sOut
        End Function

        ''' <summary>
        ''' This procedure downloads a file from the FTP server
        ''' </summary>
        ''' <param name="ftpFileUri"></param> the location and name of the file being downloaded
        ''' <param name="destFilePath"></param> the destination of the file that is being downloaded
        ''' <remarks></remarks>

        Sub RetrieveFtpFile(ByVal ftpFileUri As String, ByVal destFilePath As String)
            fwr = FtpWebRequest.Create(ftpFileUri)
            fwr.UseBinary = True
            fwr.Credentials = New NetworkCredential(ftpUser, ftpPwd)
            fwr.Method = WebRequestMethods.Ftp.DownloadFile
            fwr.KeepAlive = False
            Dim localFile As New FileStream(destFilePath, FileMode.CreateNew)

            Dim sr As Stream = fwr.GetResponse().GetResponseStream()
            Dim buffer(1024) As Byte
            Dim bytesRead As Integer = sr.Read(buffer, 0, 1024)
            While bytesRead <> 0
                localFile.Write(buffer, 0, bytesRead)
                bytesRead = sr.Read(buffer, 0, 1024)
            End While
            localFile.Flush()
            localFile.Close()
            sr.Close()
        End Sub

        ''' <summary>
        ''' This procedure deletes the file after downloading it
        ''' </summary>
        ''' <param name="sourceFilePath"></param> the file path of the file being deleted
        ''' <returns></returns> True if the file is deleted successfully
        ''' <remarks></remarks> 

        Public Function DeleteFtpFile(ByVal sourceFilePath As String)
            fwr = FtpWebRequest.Create(sourceFilePath)
            fwr.Method = WebRequestMethods.Ftp.DeleteFile
            fwr.Credentials = New NetworkCredential(ftpUser, ftpPwd)
            fwr.KeepAlive = False
            Dim response As FtpWebResponse = fwr.GetResponse()
            response.Close()
            Return True
        End Function

    End Class

End Module
