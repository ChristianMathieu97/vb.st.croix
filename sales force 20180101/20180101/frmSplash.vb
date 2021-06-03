Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.PowerPacks

Friend Class frmSplash
	Inherits System.Windows.Forms.Form

    ''' <summary>
    ''' This procedure displays program version information on the form and also makes a call to populate global variable that hold the 
    ''' database path and name
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub frmSplash_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Label1.Text = "version " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor
        Label1.Text = "Version " & My.Application.Info.Version.ToString
        Label1.Refresh()
        Call GetDB()
    End Sub
	
End Class