Option Strict Off
Option Explicit On
Friend Class frmAbout
    Inherits System.Windows.Forms.Form

    ''' <summary>
    ''' Sets the support email address label caption to the value of what is in the 'salesman' table 'supportemailaddr' field
    ''' Sets the database path label caption to the value 
    ''' </summary>
    ''' <param name="eventSender">The name of the object that is calling the procedure</param>
    ''' <param name="eventArgs">Arguments passed to this procedure</param>
    ''' <remarks></remarks>
	
	Private Sub frmAbout_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim daSalesman As New SaleForcDataSetTableAdapters.SalesmanTableAdapter
        Dim dtSalesman As SaleForcDataSet.SalesmanDataTable

        con.Open()
        dtSalesman = daSalesman.GetData
        con.Close()
        Label6.Text = My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor '& "." & App.Revision
        Label6.Text = "Version " & My.Application.Info.Version.ToString & " (" & System.IO.File.GetLastWriteTime(System.Reflection.Assembly.GetExecutingAssembly().Location).ToShortDateString() & "@" & System.IO.File.GetLastWriteTime(System.Reflection.Assembly.GetExecutingAssembly().Location).ToShortTimeString() & ")"
        Label12.Text = dtSalesman.Rows(0)("supportemailaddr").ToString
        Label3.Text = CurDir()
        lblDBLocation.Text = "Database Path:" & vbCrLf & dbName
    End Sub

    ''' <summary>
    ''' This procedure opens up the application's database if the user is a Windows administrator user
    ''' </summary>
    ''' <param name="sender">The name of the object that is calling the procedure</param>
    ''' <param name="e">Arguments passed to this procedure</param>
    ''' <remarks></remarks>

    Private Sub lblDBLocation_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblDBLocation.LinkClicked
        If My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) Then
            'ShellExecute(0, "OPEN", dbName, "", dbPath, 1)
            Dim proc As New Process()
            proc.StartInfo.FileName = dbName
            proc.StartInfo.UseShellExecute = True
            proc.Start()
        Else
            MsgBox("You must be an administrator to open the database!", MsgBoxStyle.Exclamation, "Open Database")
        End If
    End Sub
End Class