Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmPreviewCustList
    Dim Report As New CustomerListReport
    Dim crxDatabaseField As CrystalDecisions.CrystalReports.Engine.DatabaseFieldDefinition
    Dim mySortField As SortField
    Dim tbl As CrystalDecisions.CrystalReports.Engine.Table

    ''' <summary>
    ''' This procedure sets up the data for the 'Customer List' report and loads the Crystal Report in the Crystal Reports report viewer 
    ''' control
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub frmPreviewCustList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionLogonInfo As New ConnectionInfo

        Report.Load(System.AppDomain.CurrentDomain.BaseDirectory & "\CustomerListReport.rpt")
        Report.DataSourceConnections.Item(0).SetConnection("", "" & dbName & "", False)
        Report.DataSourceConnections.Item(0).SetLogon("Admin", "")

        For Each tbl In Report.Database.Tables
            crtableLogoninfo = tbl.LogOnInfo
            tbl.LogOnInfo.ConnectionInfo.ServerName = dbName
            tbl.LogOnInfo.ConnectionInfo.DatabaseName = dbName
            tbl.ApplyLogOnInfo(crtableLogoninfo)
            tbl.Location = dbName
        Next

        Select Case nListIndex
            Case 0      'CustName
                crxDatabaseField = Report.Database.Tables(0).Fields("Name")
            Case 1      'City
                crxDatabaseField = Report.Database.Tables(0).Fields("City")
            Case 2      'State
                crxDatabaseField = Report.Database.Tables(0).Fields("St")
        End Select

        mySortField = Report.DataDefinition.SortFields(0)

        mySortField.Field = crxDatabaseField

        If ViewActiveCustomers Then
            Report.RecordSelectionFormula = "{customer.slsmn-code} = '" & cSalesmanCode & "' and {customer.prtselect} = true and ({customer.status-code} = 'P' or {customer.status-code} = 'p')"
        Else
            Report.RecordSelectionFormula = "{customer.slsmn-code} = '" & cSalesmanCode & "' and {customer.prtselect} = true"
        End If

        Report.SetDatabaseLogon("Admin", "")

        CrystalReportViewer1.ReportSource = Report
        CrystalReportViewer1.RefreshReport()
    End Sub
End Class