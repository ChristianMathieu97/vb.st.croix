Public Class frmPreviewWksht

    ''' <summary>
    ''' This procedure sets up the data for the 'Worksheet' report and loads the Crystal Report in the Crystal Reports report viewer 
    ''' control
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub frmPreviewWksht_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim report1 As New WkstAndMemoReport
        Dim result As MsgBoxResult
        Dim tbl As CrystalDecisions.CrystalReports.Engine.Table
        Dim crtablelogoninfo As CrystalDecisions.Shared.TableLogOnInfo

        report1.DataSourceConnections.Item(0).SetConnection("", "" & dbName & "", False)
        report1.DataSourceConnections.Item(0).SetLogon("Admin", "")
        report1.Load(System.AppDomain.CurrentDomain.BaseDirectory & "\WkstAndMemoReport.rpt")

        For Each tbl In report1.Database.Tables
            crtablelogoninfo = tbl.LogOnInfo
            tbl.LogOnInfo.ConnectionInfo.ServerName = dbName
            tbl.LogOnInfo.ConnectionInfo.DatabaseName = dbName
            tbl.ApplyLogOnInfo(crtablelogoninfo)
            tbl.Location = dbName
        Next

        If CheckForWSMemos() = True Then
            result = MsgBox("There are memos on this worksheet.  Do you want to include them on this print job?", vbYesNo, "Print Memos")
            If result = MsgBoxResult.No Then
                report1.SetParameterValue("ShowMemo", False)
            Else
                report1.ReportDefinition.Sections(3).SectionFormat.EnableSuppress = False
                report1.Subreports(0).DataSourceConnections.Item(0).SetConnection("", "" & dbName & "", False)
                report1.Subreports(0).DataSourceConnections.Item(0).SetLogon("Admin", "")
                For Each tbl In report1.Subreports(0).Database.Tables
                    crtablelogoninfo = tbl.LogOnInfo
                    tbl.LogOnInfo.ConnectionInfo.ServerName = dbName
                    tbl.LogOnInfo.ConnectionInfo.DatabaseName = dbName
                    tbl.ApplyLogOnInfo(crtablelogoninfo)
                    tbl.Location = dbName
                Next
                report1.SetParameterValue("ShowMemo", True)
            End If
        Else
            report1.SetParameterValue("ShowMemo", False)
        End If

        report1.RecordSelectionFormula = "{ws_ord_head.worksheet-id} = " & Chr(39) & cCustWsNum & Chr(39)
        CrystalReportViewer1.ReportSource = report1
        CrystalReportViewer1.Refresh()
    End Sub

    ''' <summary>
    ''' This procedure will determine if there are any memos on the worksheet that is being printed
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Private Function CheckForWSMemos() As Boolean
        Dim SQLResult As Boolean
        Dim dbConnection As OleDb.OleDbConnection = New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim SQL As New OleDb.OleDbCommand

        dbConnection.Open()
        SQL.Connection = dbConnection
        SQL.CommandText = "SELECT COUNT (*) AS [RecordCount] FROM wsmemo WHERE [worksheet-id] = '" & frmWorksheet.lblWsNo.Text & "'"
        SQLResult = Convert.ToBoolean(SQL.ExecuteScalar)
        If SQLResult = True Then
            CheckForWSMemos = True
        Else
            CheckForWSMemos = False
        End If
        dbConnection.Close()
    End Function
End Class