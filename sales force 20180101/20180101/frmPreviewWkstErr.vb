Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmPreviewWkstErr
    Dim Report As New WkstErrReport
    Dim tbl As CrystalDecisions.CrystalReports.Engine.Table

    ''' <summary>
    ''' This procedure sets up the data for the 'Worksheet Error' report and loads the Crystal Report in the Crystal Reports report viewer 
    ''' control
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub frmPreviewWkstErr_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo

        Report.Load(System.AppDomain.CurrentDomain.BaseDirectory & "\WkstErrReport.rpt")
        Report.DataSourceConnections.Item(0).SetConnection("", "" & dbName & "", False)
        Report.DataSourceConnections.Item(0).SetLogon("Admin", "")

        For Each tbl In Report.Database.Tables
            crtableLogoninfo = tbl.LogOnInfo
            tbl.LogOnInfo.ConnectionInfo.ServerName = dbName
            tbl.LogOnInfo.ConnectionInfo.DatabaseName = dbName
            tbl.ApplyLogOnInfo(crtableLogoninfo)
            tbl.Location = dbName
        Next

        If frmErrMsgList.chkPrtMaintOnly.Checked = True Then
            Report.RecordSelectionFormula = "{ws_ord_head.allow-manual-maint} = true"
        Else
            Report.RecordSelectionFormula = ""
        End If
        CrystalReportViewer1.ReportSource = Report
        CrystalReportViewer1.RefreshReport()
    End Sub
End Class