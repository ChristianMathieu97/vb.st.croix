Option Strict Off
Option Explicit On
Friend Class frmErrMsgList
	Inherits System.Windows.Forms.Form
    Dim cWsNum As String

    Private Sub chkDisplayAll_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkDisplayAll.CheckStateChanged
        findMaintWsErr()
    End Sub

    ''' <summary>
    ''' This procedure shows the customer information screen and displays the data for the selected customer
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
	
	Private Sub cmdCustomer_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCustomer.Click
		cCustNumber = lblCustNo.Text
		If Trim(cCustNumber) <> "" Then
			fromLocation = "ErrList"
            Me.Hide()
            frmCustInfo.ShowDialog()
            Me.Show()
		End If
    End Sub

    ''' <summary>
    ''' This procedure closes the form
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
	
	Private Sub cmdExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExit.Click
		Me.Close()
    End Sub

    ''' <summary>
    ''' This procedure prints a report of worksheet error messages
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
	
	Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        Dim report As New WkstErrReport
        Dim crtablelogoninfo As CrystalDecisions.Shared.TableLogOnInfo

        report.Load(System.AppDomain.CurrentDomain.BaseDirectory & "\WkstErrReport.rpt")
        report.DataSourceConnections.Item(0).SetConnection("", "" & dbName & "", False)
        report.DataSourceConnections.Item(0).SetLogon("Admin", "")

        Dim tbl As CrystalDecisions.CrystalReports.Engine.Table
        For Each tbl In report.Database.Tables
            crtablelogoninfo = tbl.LogOnInfo
            tbl.LogOnInfo.ConnectionInfo.ServerName = dbName
            tbl.LogOnInfo.ConnectionInfo.DatabaseName = dbName
            tbl.ApplyLogOnInfo(crtablelogoninfo)
            tbl.Location = dbName
        Next
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            cToPrint = cCustWsNum
            If chkPrtMaintOnly.Checked = True Then
                report.RecordSelectionFormula = "{ws_ord_head.allow-manual-maint} = true"
            Else
                report.RecordSelectionFormula = ""
            End If
            report.SetDatabaseLogon("Admin", "")
            report.PrintOptions.PrinterName = PrintDialog1.PrinterSettings.PrinterName
            report.PrintToPrinter(PrintDialog1.PrinterSettings.Copies, PrintDialog1.PrinterSettings.Collate, PrintDialog1.PrinterSettings.FromPage, PrintDialog1.PrinterSettings.ToPage)
        End If
    End Sub

    ''' <summary>
    ''' This procedure shows the frmPreviewWKstErr form which is a print preview of the error message list 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
	
    Private Sub cmdPrintPreview_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrintPreview.Click
        frmPreviewWkstErr.ShowDialog()
    End Sub

    ''' <summary>
    ''' This procedure will show the worksheet form and display the data from the selected ws-ord-head record
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
	
	Private Sub cmdWorksheet_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdWorksheet.Click
        cCustWsNum = dtgWSErrMsg.Item(0, dtgWSErrMsg.CurrentCell.RowIndex).Value
		fromLocation = "ErrList"
		Me.Hide()
		frmWorksheet.ShowDialog()
    End Sub

    ''' <summary>
    ''' This procedure fires when the form is loaded and makes a couple of calls to purge the worksheet error message file and also
    ''' load the grid with worksheet error message records
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

	Private Sub frmErrMsgList_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        PurgeErrorMsgFile()
        findMaintWsErr()
        intShowMaintErr = 0
        dtgWSErrMsg.CurrentCell = dtgWSErrMsg(1, 0)
        dtgWSErrMsg.CurrentCell.Selected = True
    End Sub

    ''' <summary>
    ''' This procedure loads the data into the worksheet error message grid
    ''' </summary>
    ''' <remarks></remarks>
	
    Private Sub findMaintWsErr()
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        Dim mysql As String

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        mysql = "Select [WsErrorMsg].[worksheet-id], [WsErrorMsg].[Error-level], [WsErrorMsg].[Message], Format([WsErrorMsg].[CanMaintain]," & Chr(34) & "Yes/No" & Chr(34) & ") as CanMaintain"
        mysql = mysql & " from [WsErrorMsg] "

        If chkDisplayAll.CheckState = 0 Then
            mysql = mysql & " WHERE [WsErrorMsg].[CanMaintain] = True "
        End If
        mysql = mysql & "order by [WsErrorMsg].[worksheet-id] desc"

        con.Open()
        da = New OleDb.OleDbDataAdapter(mysql, con)
        da.Fill(dt)
        con.Close()

        dtgWSErrMsg.DataSource = dt
        FormatErrMsgGrid()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    ''' <summary>
    ''' This procedure formats the grid
    ''' </summary>
    ''' <remarks></remarks>
	
	Private Sub FormatErrMsgGrid()
        dtgWSErrMsg.Columns(0).Width = 80
        dtgWSErrMsg.Columns(1).Width = 60
        dtgWSErrMsg.Columns(2).Width = 240
        dtgWSErrMsg.Columns(3).Width = 70
    End Sub

    ''' <summary>
    ''' This procedure updates the status messages at the bottom of the screen to show the current customer name and number
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub dtgWSErrMsg_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgWSErrMsg.CurrentCellChanged
        If Not dtgWSErrMsg.CurrentCell Is Nothing Then
            If Not dtgWSErrMsg.CurrentCell.Value Is System.DBNull.Value Then
                cWsNum = dtgWSErrMsg.Item(0, dtgWSErrMsg.CurrentCell.RowIndex).Value
                If Trim(cWsNum) <> "" Then
                    lblCustNo.Text = findWsCustNo(cWsNum)
                    lblCustName.Text = findWsCustName((lblCustNo.Text))
                End If
            End If
        End If
    End Sub
End Class