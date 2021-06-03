Imports VB = Microsoft.VisualBasic

Friend Class frmWorksheet
	Inherits System.Windows.Forms.Form
	
	'---- Parameters for Add New ----------------------
	Dim cWsID As String
	Dim cItemNo As String ' Entered by user
	Dim nQtyOrdered As Short ' Entered by user
	Dim nPrice As Decimal ' Value retrieved from ITEM file
	Dim nTotQty As Integer ' Calculated by program
	Dim nTotExtend As Decimal ' Calculated by program
	
	Dim lReadyForOrder As Boolean ' Set and used by program
	Dim cDescription As String ' Value retrieved from ITEM file
	Dim cStyle As String ' Value retrieved from ITEM file
	Dim cColor As String ' Value retrieved from ITEM file
	Dim cSize As String ' Value retrieved from ITEM file
	Dim dBeginShipDate As Date ' Value retrieved from ITEM file
	Dim dEndShipDate As Date ' Value retrieved from ITEM file
	Dim lCanBeOrdered As Boolean ' Value retrieved from ITEM file
	Dim lIsDateInRange As Boolean ' Set by program based on date on WSHead and begin and end shipdates
	Dim lSaveFlag As Boolean ' Set to true when worksheet is ready for saving
	Dim lFlagValidCust As Boolean '
	Dim cShipToNo As String ' Stores customer shipping ID number
	Dim nEntryOrder As Short ' Used by program for setting up display order.
	
	'---- Parameters for EditView ---------------------
	Dim lFlagEditWs As Boolean
	Dim cCustViaCd As String
	
	' The following are used to move data in and out of the temp editing file
	'
	Dim cWsNo As String
	Dim cItmNo As String
	Dim nQtyOrd As Integer
	Dim nExtnd As Decimal
	Dim lDel As Boolean ' Delete flag for deleted items
	
	Dim cWorkShtNo As String ' Used to load temporary table.
    Dim flagHeadChgsMade As Boolean
	
    ' ---- Parameters for matrix item entry ----------------
	Dim tmpItemText As String
	Dim color As String
    Dim tmpSize As String
    Dim intStyleQty As Short
    Dim curStyleExtPrice As Decimal
    Dim tmpQty As Short
    Dim tmpExtPrice As Decimal
    Dim lnotfound As Boolean
    Dim formLoaded As Boolean
    Private dataadapter As New OleDb.OleDbDataAdapter
    Dim commandbuilder As OleDb.OleDbCommandBuilder = New OleDb.OleDbCommandBuilder(dataadapter)
    Dim lastkey As Keys
    Dim tmpAttributed As Boolean
    Dim cmdText As String

    ''' <summary>
    ''' This procedure will tab to the next field when the "enter/return' key is pressed
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub chkOrderComplete_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles chkOrderComplete.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            System.Windows.Forms.SendKeys.SendWait("{TAB}")
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    ''' <summary>
    ''' This procedure will display the Order Code Select screen so that the user can select an order code for the worksheet
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmdOrderCode_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOrderCode.Click
        frmOrdCodeSelect.ShowDialog()
        If cOrdTypeDesc = "" Or cOrdTypeCode = "" Then Exit Sub
        lblOrdTypeDesc.Text = cOrdTypeDesc
        txtOrderCd.Text = cOrdTypeCode
    End Sub

    ''' <summary>
    ''' This procedure will provide a print preview of the worksheet 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmdPrintPreview_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrintPreview.Click
        frmPreviewWksht.ShowDialog()
    End Sub

    ''' <summary>
    ''' This procedure will display the Season Code Select screen so that the user can select a season code for the worksheet
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmdSeason_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSeason.Click
        frmSeasonSelect.ShowDialog()
        If cSeasonDesc = "" Or cSeasonCd = "" Then Exit Sub
        lblSeasonDesc.Text = cSeasonDesc
        txtSeason.Text = cSeasonCd
    End Sub

    ''' <summary>
    ''' This procedure will display the Ship Via Code Select screen so that the user can select a ship via code for the worksheet
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmdShipVia_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdShipVia.Click
        frmShipViaSelect.ShowDialog()
        If cShipViaDesc = "" Or cShipViaCd = "" Then Exit Sub
        lblShipViaDesc.Text = cShipViaDesc
        txtShipVia.Text = cShipViaCd
    End Sub

    ''' <summary>
    ''' This procedure performs the following:
    '''  1)  Fills a text box with (if any) error messages for this worksheet
    '''  2)  Fills bottom grid with items that have been ordered on this worksheet
    '''  3)  Sets the default sort and view for the grid that displays items ordered 
    '''  4)  Checks to see if this is a new or existing worksheet and sets/fills the appropriate controls/variables
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub frmWorksheet_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Me.WSErrorMsgTableAdapter.FillByWorksheetId(Me.SaleForcDataSet.WSErrorMsg, cCustWsNum)
        Me.WSItemTempTableAdapter.FillByWorksheetId(Me.SaleForcDataSet.WSItemTemp, cCustWsNum)

        KeyPreview = True
        ' ---- These items remain the same for all worksheet modes ---------
        fraTable.Visible = False ' Hide the frame with item grid
        fraStatusMemos.Visible = True ' show the Status and memo frame

        optViewBy(0).Checked = True
        optSortBy(1).Checked = True
        lblWsNo.Text = cCustWsNum
        setFrameSettings()

        '---- If this is a new worksheet then set the right defaults
        If lNewWorksheet Then
            fraWSInfo.Visible = False
            clrNotUsedMemos((cCustWsNum))
            NewWsInit()
            lblSlsmnCd.Text = cSalesmanCode
            lFlagEditWs = False
            btnEditWS.Enabled = True
            btnEditWS_Click(btnEditWS, New System.EventArgs()) ' Create a new worksheet
        Else ' If not a new worksheet then
            loadExistWsData()
        End If
        formLoaded = True
    End Sub

    ''' <summary>
    ''' This procedure checks to see if this is a new worksheet and sets focus to the appropriate control
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub frmWorksheet_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        If lNewWorksheet Then
            txtPO.Focus()
        Else
            btnItems.Focus()
        End If
    End Sub

    ''' <summary>
    ''' This procedure is no longer used
    ''' </summary>
    ''' <param name="cItem"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Private Function isDupItemNo(ByRef cItem As String) As Boolean
        Dim con As New OleDb.OleDbConnection
        Dim dt As New DataTable
        Dim da As OleDb.OleDbDataAdapter
        Dim sql As String

        isDupItemNo = False ' Item not found

        con.ConnectionString = MySettings.Default("SaleForcConnectionString")
        con.Open()
        sql = "SELECT [itemno] FROM WSItemTemp WHERE [item-no] = '" & cItem & "'"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(dt)
        con.Close()

        If dt.Rows.Count = 0 Then
            Exit Function
        Else
            isDupItemNo = True
            Exit Function
        End If

    End Function

    ''' <summary>
    ''' This procedure makes calls to add an item that has been ordered to the ws-item-temp table
    ''' </summary>
    ''' <param name="cItemNum"></param>
    ''' <remarks></remarks>

    Private Sub AddItemsToTable(ByRef cItemNum As String)
        SetItem2Var(cItemNum) 'Assign the item fields to memory variables
        AddWsItemTempLine() 'Add it to the database
        lSaveFlag = True
    End Sub

    ''' <summary>
    ''' This procedure populates variables from data in the item table. It also makes sure that the variables to not contain null values
    ''' </summary>
    ''' <param name="cItemNum"></param>
    ''' <remarks></remarks>

    Private Sub SetItem2Var(ByRef cItemNum As String)
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        Dim sql As String

        con.Open()
        sql = "SELECT [item], [price1], [description1], [attrib1], [attrib2], [attrib3], [begin-ship-date], [end-ship-date], [canbeordered] FROM item WHERE [item] = '" & cItemNum & "'"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(dt)
        If dt.Rows.Count = 0 Then Exit Sub

        cItemNo = dt.Rows(0)("item")

        If IsDBNull(dt.Rows(0)("Price1")) Then
            nPrice = 0
        Else
            nPrice = dt.Rows(0)("Price1")
        End If


        If IsDBNull(dt.Rows(0)("Description1")) Then
            cDescription = ""
        Else
            cDescription = dt.Rows(0)("Description1")
        End If


        If IsDBNull(dt.Rows(0)("attrib1")) Then
            cStyle = ""
        Else
            cStyle = dt.Rows(0)("attrib1")
        End If


        If IsDBNull(dt.Rows(0)("attrib2")) Then
            cColor = ""
        Else
            cColor = dt.Rows(0)("attrib2")
        End If


        If IsDBNull(dt.Rows(0)("attrib3")) Then
            cSize = ""
        Else
            cSize = dt.Rows(0)("attrib3")
        End If

        If IsDBNull(dt.Rows(0)("Begin-Ship-Date")) Then
            dBeginShipDate = CDate("")
        Else
            dBeginShipDate = dt.Rows(0)("Begin-Ship-Date")
        End If

        If IsDBNull(dt.Rows(0)("End-Ship-Date")) Then
            dEndShipDate = CDate("")
        Else
            dEndShipDate = dt.Rows(0)("End-Ship-Date")
        End If
        If dt.Rows(0)("CanBeOrdered") = True Then
            lCanBeOrdered = True
            lReadyForOrder = True
        Else
            lCanBeOrdered = False
            lReadyForOrder = False
        End If
        If dtpDelvBy.Value < dBeginShipDate Or dtpDelvBy.Value > dEndShipDate Then
            lIsDateInRange = False
        Else
            lIsDateInRange = True
        End If
        con.Close()
    End Sub

    ''' <summary>
    ''' This procedure creates a new record in the ws-item-temp file for an item that was ordered by the sales rep
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub AddWsItemTempLine()
        Dim con As New OleDb.OleDbConnection
        Dim dtLARGESTENTRY As New DataTable
        Dim daLARGESTENTRY As OleDb.OleDbDataAdapter
        Dim daWSITEMTEMP As New SaleForcDataSetTableAdapters.WSItemTempTableAdapter
        Dim newWsItemTempRow As SaleForcDataSet.WSItemTempRow

        newWsItemTempRow = SaleForcDataSet.WSItemTemp.NewWSItemTempRow

        Dim i As Integer
        Dim sql As String
        Dim tmpLargestEntryOrder As Short

        con.ConnectionString = MySettings.Default("SaleForcConnectionString")
        con.Open()

        sql = "SELECT [entryorder] FROM WSItemTemp"
        daLARGESTENTRY = New OleDb.OleDbDataAdapter(sql, con)
        daLARGESTENTRY.Fill(dtLARGESTENTRY)

        con.Close()

        If dtLARGESTENTRY.Rows.Count <> 0 Then
            For i = 0 To dtLARGESTENTRY.Rows.Count - 1
                If dtLARGESTENTRY.Rows(i)("entryorder") > tmpLargestEntryOrder Then
                    tmpLargestEntryOrder = dtLARGESTENTRY.Rows(i)("entryorder")
                End If
            Next
        End If

        cWsID = lblWsNo.Text

        newWsItemTempRow.WorksheetID = cWsID
        newWsItemTempRow.ItemNo = cItemNo
        newWsItemTempRow.QtyOrdered = nQtyOrdered
        newWsItemTempRow.Price = nPrice
        newWsItemTempRow.Extended = nQtyOrdered * nPrice
        newWsItemTempRow.ReadyForOrder = lReadyForOrder
        newWsItemTempRow.Description = cDescription
        newWsItemTempRow.Style = cStyle
        newWsItemTempRow.Color = cColor
        newWsItemTempRow.Size = cSize
        newWsItemTempRow.BeginShipDate = dBeginShipDate
        newWsItemTempRow.EndShipDate = dEndShipDate
        newWsItemTempRow.CanBeOrdered = lCanBeOrdered
        newWsItemTempRow.IsDate_in_range = lIsDateInRange
        newWsItemTempRow.EntryOrder = tmpLargestEntryOrder + 1
        newWsItemTempRow.Deleted = False
        SaleForcDataSet.WSItemTemp.Rows.Add(newWsItemTempRow)
        daWSITEMTEMP.Update(Me.SaleForcDataSet)
        Me.SaleForcDataSet.WSItemTemp.AcceptChanges()
    End Sub

    ''' <summary>
    ''' This procedure fires when the form is closing, clears out any items in the ws-item-temp table and sets some variables for use 
    ''' on this form and throughout the application
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub frmWorksheet_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ClrWSItemTemp()
        txtWSMemo.Text = ""
        Dim Cancel As Boolean = eventArgs.Cancel
        Dim UnloadMode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
        eventArgs.Cancel = Cancel
        CameFromWorksheetForm = False
        formLoaded = False
    End Sub

    ''' <summary>
    ''' This procedure simulates the user pressing tab when the user has pressed the 'enter/return' key
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub mebDept_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles mebDept.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            System.Windows.Forms.SendKeys.SendWait("{TAB}")
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    ''' <summary>
    ''' This procedure will hide the two datagrids and their related controls for ordering items when the user clicks the return button
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmdReturn_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdReturn.Click
        fraItemMatrix.Visible = False
        dgvColorSize.Enabled = False
        fraStatusMemos.Visible = True
        Me.lblQtyOnHand.Text = 0
        Me.lblQtyPotential.Text = 0
        Me.lblQtyToSell.Text = 0
    End Sub

    ''' <summary>
    ''' This procedure will change the view on the ws-item-temp datagrid
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub optViewBy_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optViewBy.CheckedChanged
        If formLoaded Then
            If eventSender.Checked Then
                Dim Index As Short = optViewBy.GetIndex(eventSender)
                Select Case Index
                    Case 0
                        If optSortBy(0).Checked = True Then
                            WSItemTempBindingSource.Sort = "[EntryOrder] ASC"
                        Else
                            WSItemTempBindingSource.Sort = "[ItemNo] ASC"
                        End If
                    Case 1
                        If optSortBy(0).Checked = True Then
                            WSItemTempBindingSource.Sort = "[EntryOrder] DESC"
                        Else
                            WSItemTempBindingSource.Sort = "[ItemNo] DESC"
                        End If
                End Select
            End If
        End If
    End Sub

    ''' <summary>
    ''' This procedure will change the sort on the ws-item-temp datagrid
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub optSortBy_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optSortBy.CheckedChanged

        If eventSender.Checked Then
            Dim Index As Short = optSortBy.GetIndex(eventSender)
            Select Case Index
                Case 0
                    If optViewBy(0).Checked = True Then
                        WSItemTempBindingSource.Sort = "[EntryOrder] ASC"
                    Else
                        WSItemTempBindingSource.Sort = "[ItemNo] ASC"
                    End If
                Case 1
                    If optViewBy(0).Checked = True Then
                        WSItemTempBindingSource.Sort = "[EntryOrder] DESC"
                    Else
                        WSItemTempBindingSource.Sort = "[ItemNo] DESC"
                    End If
            End Select
        End If

    End Sub

    ''' <summary>
    ''' This procedure sets the 'PreviousTab' variable so that when coming back to this form, the last tab displayed will be displayed again
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub tabMemosErrMsg_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tabMemosErrMsg.SelectedIndexChanged
        Static PreviousTab As Short = tabMemosErrMsg.SelectedIndex()
        PreviousTab = tabMemosErrMsg.SelectedIndex()
    End Sub

    ''' <summary>
    ''' This procedure simulates the user pressing tab when the user has pressed the 'enter/return' key
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub txtPO_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtPO.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            System.Windows.Forms.SendKeys.SendWait("{TAB}")
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    ''' <summary>
    ''' This procedure will make a call to print the Worksheet (and memos on the worksheets if applicable)
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Public Sub btnPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnPrint.Click
        Call PrintWSandMemos()
    End Sub

    ''' <summary>
    ''' This procedure will check to see if there are memos on the worksheet
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Private Function CheckForWSMemos() As Boolean
        Dim con As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        Dim sql As String

        con.ConnectionString = MySettings.Default("SaleForcConnectionString")
        con.Open()

        sql = "SELECT [worksheet-id] FROM [wsmemo] WHERE [worksheet-id] = '" & cCustWsNum & "' AND [linenumber] = 1"

        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(dt)
        con.Close()

        If dt.Rows.Count <> 0 Then
            CheckForWSMemos = True
        Else
            CheckForWSMemos = False
        End If

    End Function

    ''' <summary>
    ''' This procedure prints worksheets using a Crystal Reports report and will also include memos on the worksheet (if applicable)
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub PrintWSandMemos()
        Dim cSelectCriteria As String
        Dim report As New WkstAndMemoReport
        Dim crConnectionLogonInfo As New CrystalDecisions.Shared.ConnectionInfo
        Dim crtablelogoninfo As New CrystalDecisions.Shared.TableLogOnInfo
        Dim result As MsgBoxResult
        Dim tbl As CrystalDecisions.CrystalReports.Engine.Table

        report.Load(System.AppDomain.CurrentDomain.BaseDirectory & "\WkstAndMemoReport.rpt")
        report.DataSourceConnections.Item(0).SetConnection("", "" & dbName & "", False)
        report.DataSourceConnections.Item(0).SetLogon("Admin", "")

        For Each tbl In report.Database.Tables
            crtablelogoninfo = tbl.LogOnInfo
            tbl.LogOnInfo.ConnectionInfo.ServerName = dbName
            tbl.LogOnInfo.ConnectionInfo.DatabaseName = dbName
            tbl.ApplyLogOnInfo(crtablelogoninfo)
            tbl.Location = dbName
        Next

        If CheckForWSMemos() = True Then
            result = MsgBox("There are memos on this worksheet.  Do you want to include them on this print job?", vbYesNo, "Print Memos")
            If result = MsgBoxResult.No Then
                report.SetParameterValue("ShowMemo", False)
            Else
                report.Subreports(0).DataSourceConnections.Item(0).SetConnection("", "" & dbName & "", False)
                report.Subreports(0).DataSourceConnections.Item(0).SetLogon("Admin", "")
                For Each tbl In report.Subreports(0).Database.Tables
                    crtablelogoninfo = tbl.LogOnInfo
                    tbl.LogOnInfo.ConnectionInfo.ServerName = dbName
                    tbl.LogOnInfo.ConnectionInfo.DatabaseName = dbName
                    tbl.ApplyLogOnInfo(crtablelogoninfo)
                    tbl.Location = dbName
                Next
                report.SetParameterValue("ShowMemo", True)
            End If
        Else
            report.SetParameterValue("ShowMemo", False)
        End If

        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            cToPrint = cCustWsNum
            cSelectCriteria = "{ws_ord_head.worksheet-id} = " & Chr(34) & cToPrint & Chr(34)
            report.RecordSelectionFormula = cSelectCriteria
            report.PrintOptions.PrinterName = PrintDialog1.PrinterSettings.PrinterName
            If PrintDialog1.PrinterSettings.PrintRange = Printing.PrintRange.AllPages Then
                report.PrintToPrinter(PrintDialog1.PrinterSettings.Copies, PrintDialog1.PrinterSettings.Collate, PrintDialog1.PrinterSettings.MinimumPage + 1, PrintDialog1.PrinterSettings.MaximumPage)
            Else
                report.PrintToPrinter(PrintDialog1.PrinterSettings.Copies, PrintDialog1.PrinterSettings.Collate, PrintDialog1.PrinterSettings.FromPage, PrintDialog1.PrinterSettings.ToPage)
            End If
        End If
    End Sub

    ''' <summary>
    ''' This procedure will mark the worksheet as 'Cancelled'.  This means the user no longer wants this worksheet to be converted to an 
    ''' order.  
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub chkCancel_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkCancel.CheckStateChanged
        flagHeadChgsMade = True
        If chkCancel.CheckState = 1 Then
            lblValStatus.Text = "CANCEL"
            chkReadyToXmit.CheckState = System.Windows.Forms.CheckState.Checked
        Else
            lblValStatus.Text = "NO VAL"
            chkReadyToXmit.CheckState = System.Windows.Forms.CheckState.Unchecked
        End If
        lblValDate.Text = CStr(Today)
    End Sub

    ''' <summary>
    ''' This procedure marks the worksheet as "Ready To Transmit".  This means that the program will mark it to be prepared for transmit
    ''' to Knitcraft.
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub chkReadyToXmit_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkReadyToXmit.CheckStateChanged
        flagHeadChgsMade = True
        If chkReadyToXmit.CheckState = 1 Then
            lblXmitStatus.Text = "XMIT"
        Else
            lblXmitStatus.Text = "OPEN"
        End If
        lblXmitDate.Text = CStr(Today)
    End Sub

    ''' <summary>
    ''' This button performs two functions:  To allow the user to edit a worksheet and also to save the data once the worksheet has been 
    ''' modified.  This procedure performs the following:
    '''  1)  Checks to see if the worksheet has changes and will save the changes if the user chooses to do so
    '''  2)  Clears the ws-item-temp table if the user decides not to save changes
    '''  3)  Loads existing worksheet data in the appropriate controls if it is an existing worksheet
    '''  4)  Sets flags so that the program knows if it is in 'edit mode' or 'view mode'
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub btnEditWS_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnEditWS.Click ' This is for worksheet editing
        Dim nAction As Short
        Dim msg As String

        If lFlagEditWs = False Then
            lFlagEditWs = True
            flagHeadChgsMade = False
            flagItemChgsMade = False

            setEditWsStatus(lFlagEditWs)

        ElseIf flagHeadChgsMade = True Or flagItemChgsMade = True Then  ' Leaving edit mode
            If lNewWorksheet And Not flagItemChgsMade Then
                msg = "This worksheet can not be saved" & vbCrLf & "No items have been added"
                nAction = MsgBox(msg, MsgBoxStyle.OkCancel, "END NEW WORKSHEET")
                Select Case nAction
                    Case MsgBoxResult.Ok
                        lFlagEditWs = False
                        flagItemChgsMade = False
                        flagHeadChgsMade = False
                        setEditWsStatus(lFlagEditWs)
                        clrNotUsedMemos((cCustWsNum))
                        btnExit_Click(btnExit, New System.EventArgs())
                    Case MsgBoxResult.Cancel
                        btnItems.Focus()
                        Exit Sub
                End Select
            Else
                nAction = MsgBox("Do you want to save your changes?", MsgBoxStyle.Critical + MsgBoxStyle.YesNoCancel, "END WORKSHEET EDIT")
                Select Case nAction
                    Case MsgBoxResult.Yes
                        If flagItemChgsMade Or flagHeadChgsMade Then

                            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                            SaveEditChanges()

                            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                            MsgBox("Worksheet was saved", , "SAVE WORKSHEET")
                        End If

                    Case MsgBoxResult.No
                        ClrWSItemTemp()
                        Dim strCommand As String
                        strCommand = Mid(WSItemTempTableAdapter.Adapter.SelectCommand.CommandText, 1, Len(WSItemTempTableAdapter.Adapter.SelectCommand.CommandText) - 1) & "'" & cCustWsNum & "'"
                        GetData(strCommand)
                        loadExistWsData()

                    Case MsgBoxResult.Cancel
                        Exit Sub

                End Select

                lFlagEditWs = False
                flagItemChgsMade = False
                flagHeadChgsMade = False
                setEditWsStatus(lFlagEditWs)
            End If
        Else
            lFlagEditWs = False
            flagItemChgsMade = False
            flagHeadChgsMade = False

            setEditWsStatus(lFlagEditWs)
            If lNewWorksheet And flagHeadChgsMade = False And flagItemChgsMade = False Then
                btnExit_Click(btnExit, New System.EventArgs())
            End If
        End If
    End Sub

    ''' <summary>
    ''' This procedure sets flags to indicate to the program that it is in 'edit mode' or 'view mode'.  It also enables/disables controls
    ''' based on what mode the worksheet is in.
    ''' </summary>
    ''' <param name="lEdFlag"></param>
    ''' <remarks></remarks>

    Private Sub setEditWsStatus(ByRef lEdFlag As Boolean) ' Enable/disable edit status
        If lEdFlag = True Then ' Edit the worksheet
            fraStatus.Enabled = True

            'fraCustOrdInfo.Enabled = True
            mebDept.ReadOnly = False
            txtPO.ReadOnly = False
            dtpDelvBy.Enabled = True
            dtpCancelBy.Enabled = True
            cmdClearStyleQty.Enabled = True
            chkOrderComplete.Tag = "enable"
            'fraWSCtl.Enabled = False
            fraDisplayCodes.Enabled = True

            txtWSMemo.Enabled = True
            btnEditWS.Text = "End edit"
            btnExit.Enabled = False
            btnPrint.Enabled = False
            cmdPrintPreview.Enabled = False
            cmdEmailWorksheet.Enabled = False
            dgvColorSize.ReadOnly = False
            'Me.Text = "NEW Order Worksheet - EDIT Mode - " & Trim(lblWsNo.Text)
            chkCancel.Enabled = True
            chkReadyToXmit.Enabled = True
            optViewBy(0).Checked = True
            optSortBy(1).Checked = True

        Else ' End worksheet editing
            fraStatus.Enabled = False

            'fraCustOrdInfo.Enabled = False
            mebDept.ReadOnly = True
            txtPO.ReadOnly = True
            dtpDelvBy.Enabled = False
            dtpCancelBy.Enabled = False
            chkOrderComplete.Tag = "disable"
            cmdClearStyleQty.Enabled = False
            fraDisplayCodes.Enabled = False

            'fraWSCtl.Enabled = True

            txtWSMemo.Enabled = False
            btnEditWS.Text = "&Edit"
            btnExit.Enabled = True
            btnPrint.Enabled = True
            cmdPrintPreview.Enabled = True
            cmdEmailWorksheet.Enabled = True
            dgvColorSize.ReadOnly = True
            'Me.Text = "NEW Order Worksheet - VIEW Mode - " & Trim(lblWsNo.Text)
            chkCancel.Enabled = False
            chkReadyToXmit.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' This procedure will close the form.  It the way the user got to this form was not from the main menu on the main screen, but from
    ''' another form, this procedure will re-open that form.
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub btnExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnExit.Click
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        If fromLocation = "Cust" Then
            ClrWSItemTemp()
            lCustToWs = False
            Me.Close()
            frmCustInfo.Show()
            frmCustInfo.BringToFront()
        ElseIf fromLocation = "ErrList" Then
            Me.Close()
            frmErrMsgList.Show()
        ElseIf fromLocation = "WsList" Then
            Me.Close()
            frmListWs.Show()
        ElseIf fromLocation = "XmitNoVal" Then
            Me.Close()
            frmXmitButNoVal.Show()
        Else
            Me.Close()
        End If
        fromLocation = ""
    End Sub

    ''' <summary>
    ''' This procedure hides most portions of the 'header' screen and will display the screen that is used to order items.
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub btnItems_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnItems.Click
        If dgvColorSize.ReadOnly Then
            MsgBox("You are in view mode and cannot edit this worksheet!", MsgBoxStyle.Exclamation, "View Mode")
            cmdClearStyleQty.Enabled = False
        Else
            cmdClearStyleQty.Enabled = True
        End If
        cWorksheetID = lblWsNo.Text
        fraItemMatrix.Visible = True
        fraItemMatrix.BringToFront()
        fraStatusMemos.Visible = False
        fraTable.Visible = True
        cmdNextStyle_Click(cmdNextStyle, New System.EventArgs())
        txtStyle.Focus()
        optViewBy(0).Checked = True
        optSortBy(1).Checked = True
    End Sub

    ''' <summary>
    ''' This procedure is no longer used
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub ItemEditSetting()
        fraStatusMemos.Visible = False
        fraTable.Visible = True
    End Sub

    ''' <summary>
    ''' This procedure makes calls to load existing data from the ws-ord-head, wsmemo, and ws-ord-line tables into the worksheet form for 
    ''' viewing/editing
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub loadExistWsData()
        Dim con As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        Dim sql As String

        Dim nXtendTot As Decimal
        Dim nQtyOrdTot As Integer

        If lNewWorksheet Then
            ClrWSItemTemp()
            flagItemChgsMade = False
            Exit Sub
        End If
        dgvColorSize.ReadOnly = True

        dtpCancelBy.MinDate = "01/01/1951"
        dtpCancelBy.MaxDate = "12/31/2050"
        dtpDelvBy.MinDate = "01/01/1951"
        dtpDelvBy.MaxDate = "12/31/2050"

        If fromLocation = "Cust" Or fromLocation = "ErrList" Then
            cWorkShtNo = cCustWsNum
        Else
            cWorkShtNo = lblWsNo.Text
        End If
        flagItemChgsMade = False
        nXtendTot = 0
        nQtyOrdTot = 0

        con.ConnectionString = MySettings.Default("SaleForcConnectionString")
        con.Open()
        sql = "SELECT * FROM [ws-ord-head] WHERE [worksheet-id] = '" & cWorkShtNo & "'"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(dt)
        con.Close()

        If dt.Rows.Count = 0 Then
            MsgBox("Not finding things", , "Hey There")
        Else
            If dt.Rows(0)("allow-manual-maint") = False Then
                btnEditWS.Enabled = False
                lFlagNoEdit = True
            Else
                btnEditWS.Enabled = True
                lFlagNoEdit = False
            End If
            UpdateWsHdFields()
        End If

        LoadWsItemEditTbl() 'Load the display/edit table with the item data

        If WSErrorMsgBindingSource.Count > 0 Then
            lblErrMsg.Text = WSErrorMsgBindingSource.Current("message").ToString
        Else
            lblErrMsg.Text = ""
        End If
        LoadWorksheetMemos()
    End Sub

    ''' <summary>
    ''' This procedure loads the data from the ws-ord-head table into the form's controls
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub UpdateWsHdFields()
        Dim cCustNum As String
        Dim cShipNum As String
        Dim txtSlsmnCode As String
        Dim chkIsOrderReady As Boolean
        Dim con As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        Dim sql As String

        con.ConnectionString = MySettings.Default("SaleForcConnectionString")
        con.Open()
        sql = "SELECT * FROM [ws-ord-head] WHERE [worksheet-id] = '" & cWorkShtNo & "'"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(dt)
        con.Close()

        If IsDBNull(dt.Rows(0)("allow-manual-maint")) Then
            chkMaintAllowed.CheckState = System.Windows.Forms.CheckState.Unchecked
        ElseIf dt.Rows(0)("allow-manual-maint") = True Then
            chkMaintAllowed.CheckState = System.Windows.Forms.CheckState.Checked
        Else
            chkMaintAllowed.CheckState = System.Windows.Forms.CheckState.Unchecked
        End If

        If IsDBNull(dt.Rows(0)("via-code")) Or Trim(dt.Rows(0)("via-code")) = "" Then
            txtShipVia.Text = ""
            lblShipViaDesc.Text = ""
        Else
            txtShipVia.Text = dt.Rows(0)("via-code").ToString
            lblShipViaDesc.Text = findShipViaDesc((txtShipVia.Text))
        End If

        If IsDBNull(dt.Rows(0)("cust-no")) Or Trim(dt.Rows(0)("cust-no")) = "" Then
            lblCustomer.Text = ""
            lblShipTo.Text = ""
            If IsDBNull(dt.Rows(0)("name")) Or Trim(dt.Rows(0)("name")) = "" Then
                lblCustomer.Text = ""
            Else
                lblCustomer.Text = dt.Rows(0)("name").ToString
            End If
        Else
            cCustNum = dt.Rows(0)("cust-no")
            If Len(Trim(cCustNum)) > 0 Then
                GetCustDataF(cCustNum)
                LoadCustData()
                optCustIs(1).Checked = True
            End If
            If VB.Left(UCase(cCustNum), 2) = "ZZ" Then
                optCustIs(0).Checked = True
            Else
                optCustIs(1).Checked = True
            End If
            If IsDBNull(dt.Rows(0)("ship-no")) Or Trim(dt.Rows(0)("ship-no")) = "" Then
                lblShipTo.Text = ""
            Else
                cShipNum = dt.Rows(0)("ship-no")
                If Len(Trim(cShipNum)) > 0 Then
                    GetShipDataF(cCustNum, cShipNum)
                    LoadShipData()
                End If
            End If
        End If

        If IsDBNull(dt.Rows(0)("request-date")) Then
            dtpDelvBy.Value = ""
        Else
            dtpDelvBy.Value = dt.Rows(0)("request-date")
        End If

        If IsDBNull(dt.Rows(0)("Cancel-Date")) Then
            dtpCancelBy.Value = ""
        Else
            dtpCancelBy.Value = dt.Rows(0)("Cancel-Date")
        End If

        If IsDBNull(dt.Rows(0)("Season")) Then
            txtSeason.Text = ""
            lblSeasonDesc.Text = ""
        Else
            txtSeason.Text = dt.Rows(0)("Season").ToString
            lblSeasonDesc.Text = findSeasonDesc(txtSeason.Text)
        End If

        If IsDBNull(dt.Rows(0)("order-code")) Then
            txtOrderCd.Text = ""
            lblOrdTypeDesc.Text = ""
        Else
            txtOrderCd.Text = dt.Rows(0)("order-code").ToString
            lblOrdTypeDesc.Text = findOrdTypeDesc(txtOrderCd.Text)
        End If

        If IsDBNull(dt.Rows(0)("ord-compl")) Then
            chkOrderComplete.CheckState = System.Windows.Forms.CheckState.Unchecked
        ElseIf dt.Rows(0)("ord-compl") = True Then
            chkOrderComplete.CheckState = System.Windows.Forms.CheckState.Checked
        Else
            chkOrderComplete.CheckState = System.Windows.Forms.CheckState.Unchecked
        End If

        If IsDBNull(dt.Rows(0)("department")) Then
            mebDept.Text = ""
        Else
            mebDept.Text = dt.Rows(0)("department")
        End If

        If IsDBNull(dt.Rows(0)("cust-po")) Then
            txtPO.Text = ""
        Else
            txtPO.Text = dt.Rows(0)("cust-po").ToString
        End If

        If IsDBNull(dt.Rows(0)("order-no")) Then
            lblOrderNo.Text = ""
        Else
            lblOrderNo.Text = dt.Rows(0)("order-no").ToString
        End If

        If IsDBNull(dt.Rows(0)("order-date")) Then
            lblOrderDate.Text = ""
        Else
            lblOrderDate.Text = dt.Rows(0)("order-date").ToString
        End If

        If IsDBNull(dt.Rows(0)("transmittal-status")) Then
            lblXmitStatus.Text = ""
        Else
            lblXmitStatus.Text = dt.Rows(0)("transmittal-status").ToString
        End If

        If IsDBNull(dt.Rows(0)("transmittal-date")) Then
            lblXmitDate.Text = ""
        Else
            lblXmitDate.Text = dt.Rows(0)("transmittal-date").ToString
        End If

        If IsDBNull(dt.Rows(0)("validation-status")) Then
            lblValStatus.Text = ""
        Else
            lblValStatus.Text = dt.Rows(0)("validation-status").ToString
        End If

        If IsDBNull(dt.Rows(0)("validation-date")) Then
            lblValDate.Text = ""
        Else
            lblValDate.Text = dt.Rows(0)("validation-date").ToString
        End If

        If IsDBNull(dt.Rows(0)("error-level")) Then
            lblErrorLevel.Text = ""
        Else
            lblErrorLevel.Text = dt.Rows(0)("error-level").ToString
        End If

        If IsDBNull(dt.Rows(0)("LastUpDated")) Then
            lblLastUpDte.Text = ""
        Else
            lblLastUpDte.Text = dt.Rows(0)("LastUpDated").ToString
        End If

        If IsDBNull(dt.Rows(0)("ws-create-date")) Then
            lblDateCreated.Text = ""
        Else
            lblDateCreated.Text = dt.Rows(0)("ws-create-date").ToString
        End If

        If IsDBNull(dt.Rows(0)("ReadyToXmit")) Then
            chkReadyToXmit.CheckState = System.Windows.Forms.CheckState.Unchecked
        ElseIf dt.Rows(0)("ReadyToXmit") = True Then
            chkReadyToXmit.CheckState = System.Windows.Forms.CheckState.Checked
        Else
            chkReadyToXmit.CheckState = System.Windows.Forms.CheckState.Unchecked
        End If

        If IsDBNull(dt.Rows(0)("CancelWS")) Then
            chkCancel.CheckState = System.Windows.Forms.CheckState.Unchecked
        Else
            If dt.Rows(0)("CancelWS") = True Then
                chkCancel.CheckState = System.Windows.Forms.CheckState.Checked
            Else
                chkCancel.CheckState = System.Windows.Forms.CheckState.Unchecked
            End If
        End If

        If IsDBNull(dt.Rows(0)("SlsmnCode")) Then
            txtSlsmnCode = ""
        Else
            txtSlsmnCode = dt.Rows(0)("SlsmnCode").ToString
        End If
        lblSlsmnCd.Text = txtSlsmnCode
        If IsDBNull(dt.Rows(0)("Xmitted")) Then
            chkXmitted.CheckState = System.Windows.Forms.CheckState.Unchecked
        Else
            If dt.Rows(0)("Xmitted") = True Then
                chkXmitted.CheckState = System.Windows.Forms.CheckState.Checked
            Else
                chkXmitted.CheckState = System.Windows.Forms.CheckState.Unchecked
            End If
        End If

        If IsDBNull(dt.Rows(0)("XmittedDate")) Then
            lblXmittedDate.Text = ""
        Else
            lblXmittedDate.Text = dt.Rows(0)("XmittedDate").ToString
        End If

        If IsDBNull(dt.Rows(0)("XmittedTime")) Then
            lblXmittedTime.Text = ""
        Else
            lblXmittedTime.Text = dt.Rows(0)("XmittedTime").ToString
        End If

        If IsDBNull(dt.Rows(0)("IsOrderReady")) Then
            chkIsOrderReady = 0
        Else
            chkIsOrderReady = dt.Rows(0)("IsOrderReady").ToString
        End If
    End Sub

    ''' <summary>
    ''' This procedure makes calls to save data from the worksheet header, worksheet lines and worksheet memos that has been modified
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub SaveEditChanges()
        cWsNo = lblWsNo.Text
        SaveWorkSheetHead()
        SaveWorkSheetLines()
        SaveWorkSheetMemos()
        lblWsNo.Text = cWsNo
        If lNewWorksheet Then
            lNewWorksheet = False
            If cNewWsNo = "C" Then
                SetNewWsNo()
            End If
            cWorkShtNo = lblWsNo.Text
        End If
    End Sub

    ''' <summary>
    ''' This procedure will tab to the next field when the "enter/return' key is pressed
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub dtpCancelBy_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpCancelBy.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            System.Windows.Forms.SendKeys.SendWait("{TAB}")
        End If
    End Sub

    ''' <summary>
    ''' This procedure will tab to the next field when the "enter/return' key is pressed
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub dtpDelvBy_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpDelvBy.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            System.Windows.Forms.SendKeys.SendWait("{TAB}")
        End If
    End Sub

    ''' <summary>
    ''' This procedure sets a flag to identify that changes have been made to the data so that the user can choose to save it
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub mebDept_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mebDept.TextChanged
        flagHeadChgsMade = True
    End Sub

    ''' <summary>
    ''' This procedure sets a flag to identify that changes have been made to the data so that the user can choose to save it
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub txtOrderCd_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtOrderCd.TextChanged
        flagHeadChgsMade = True
    End Sub

    ''' <summary>
    ''' This procedure sets a flag to identify that changes have been made to the data so that the user can choose to save it
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub txtPO_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPO.TextChanged
        flagHeadChgsMade = True
    End Sub

    ''' <summary>
    ''' This procedure sets a flag to identify that changes have been made to the data so that the user can choose to save it
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub txtSeason_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSeason.TextChanged
        flagHeadChgsMade = True
    End Sub

    ''' <summary>
    ''' This procedure sets a flag to identify that changes have been made to the data so that the user can choose to save it
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub txtShipVia_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShipVia.TextChanged
        flagHeadChgsMade = True
    End Sub

    ''' <summary>
    ''' This procedure populates the name and number label controls on the customer side of the screen with the current customer info
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub LoadCustData()
        lblCustNo.Text = cCustNo
        lblCustomer.Text = cCustName
    End Sub

    ''' <summary>
    ''' This procedure populates the name and number label controls on the customer ship toside of the screen with the current customer 
    ''' ship to info
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub LoadShipData()
        lblCustShipNo.Text = cShipNo
        lblShipTo.Text = cShipName
    End Sub

    ''' <summary>
    ''' This procedure limits the 'department' text to 8 characters
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub mebDept_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mebDept.Leave
        If Len(Trim(mebDept.Text)) > 8 Then
            mebDept.Text = VB.Left(mebDept.Text, 8)
        End If
    End Sub

    ''' <summary>
    ''' This procedure limits the 'Purchase Order' text to 14 characters
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub txtPO_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPO.Leave
        If Len(Trim(txtPO.Text)) > 14 Then
            txtPO.Text = VB.Left(txtPO.Text, 14)
        End If
    End Sub

    ''' <summary>
    ''' This procedure loads the worksheet memos into the memo text box on the form (if any memos exist for this worksheet)
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub LoadWorksheetMemos()
        Dim con As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        Dim sql As String
        Dim i As Integer

        con.ConnectionString = MySettings.Default("SaleForcConnectionString")
        con.Open()
        sql = "SELECT [comment] FROM WSMemo WHERE [worksheet-id] = '" & cWorkShtNo & "'"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(dt)
        txtWSMemo.Text = ""
        For i = 0 To dt.Rows.Count - 1
            If Len(dt.Rows(i)("Comment")) > 0 Then
                If Mid(dt.Rows(i)("Comment"), Len(dt.Rows(i)("Comment")), 1) <> " " Then
                    txtWSMemo.Text = txtWSMemo.Text & dt.Rows(i)("Comment").ToString + " "
                Else
                    txtWSMemo.Text = txtWSMemo.Text & dt.Rows(i)("Comment").ToString
                End If
            End If
        Next
        con.Close()
    End Sub

    ''' <summary>
    ''' This procedure loads items that have been ordered into the datagrid at the bottom of the screen
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub LoadWsItemEditTbl()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        ClrWSItemTemp()
        PutItemsInTemp()
        WSItemTempBindingSource.DataSource = SaleForcDataSet.WSItemTemp
        dgvTempItems.DataSource = WSItemTempBindingSource
        GetData(Replace(WSItemTempTableAdapter.Adapter.SelectCommand.CommandText, "?", "'" & cCustWsNum & "'"))
        dgvTempItems.Refresh()
        WSItemTempBindingSource.Sort = "[EntryOrder]"
        ReCalcTotals()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    ''' <summary>
    ''' This procedure moves items from the ws-ord-line table into the WsItemTemp table
    ''' </summary>
    ''' <remarks></remarks>

    Sub PutItemsInTemp()
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim com As New OleDb.OleDbCommand("INSERT INTO WsItemTemp ([WorksheetId], [ItemNo], [QtyOrdered], [Price], [Extended], [ReadyForOrder], [Description], [Style], [Color], [Size], [CanBeOrdered], [IsDate in range], [EntryOrder]) SELECT [worksheet-id], [item-no], [qty-orig-ord], [price], ([qty-orig-ord]*[price]) AS ExtendedPrice, [ReadyForOrder], [Description], [Style], [Color], [Size], [CanBeOrdered], [IsDateInRange], [EntryOrder] FROM [ws-ord-line] WHERE [worksheet-id] = '" & cWorkShtNo & "'", con)
        con.Open()
        com.ExecuteNonQuery()
        con.Close()
    End Sub

    ''' <summary>
    ''' This procedure saves the data from the worksheet header into the ws-ord-head table for new or existing worksheets
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub SaveWorkSheetHead()
        Dim wsordheadRow As SaleForcDataSet._ws_ord_headRow

        wsordheadRow = SaleForcDataSet._ws_ord_head.FindBy_worksheet_id(cWsNo)

        Dim con As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        Dim sql As String

        Dim newWsOrdHeadRow As SaleForcDataSet._ws_ord_headRow
        Dim daWsOrdHead As New SaleForcDataSetTableAdapters.ws_ord_headTableAdapter
        Dim wsTable As SaleForcDataSet._ws_ord_headDataTable
        Dim wsrow As SaleForcDataSet._ws_ord_headRow

        newWsOrdHeadRow = SaleForcDataSet._ws_ord_head.New_ws_ord_headRow
        con.ConnectionString = MySettings.Default("SaleForcConnectionString")
        con.Open()
        sql = "SELECT * FROM [ws-ord-head]"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(dt)
        con.Close()

        If chkCancel.CheckState = 0 Then 'Don't need to check if canceled
            chkValidData()
        End If

        Dim foundrows As DataRow() = dt.Select("[worksheet-id] = '" & cWsNo & "'")

        If foundrows.Length = 0 Then

            newWsOrdHeadRow._worksheet_id = cWsNo

            If chkMaintAllowed.CheckState = 1 Then
                newWsOrdHeadRow._allow_manual_maint = True
            Else
                newWsOrdHeadRow._allow_manual_maint = False
            End If
            newWsOrdHeadRow._ws_create_date = lblDateCreated.Text
            newWsOrdHeadRow._cust_no = lblCustNo.Text
            newWsOrdHeadRow._ship_no = lblCustShipNo.Text

            If VB.Left(Trim(lblCustNo.Text), 2) = "ZZ" Then
                newWsOrdHeadRow.name = lblCustomer.Text
                newWsOrdHeadRow.IsNewCustomer = True
            Else
                newWsOrdHeadRow.name = ""
                newWsOrdHeadRow.IsNewCustomer = False
            End If
            newWsOrdHeadRow._error_level = ""
            newWsOrdHeadRow.SlsmnCode = cSalesmanCode
            newWsOrdHeadRow._transmittal_status = "OPEN"
            newWsOrdHeadRow._transmittal_date = Today
            newWsOrdHeadRow._validation_status = "NO VAL"
            newWsOrdHeadRow._validation_date = Today

            newWsOrdHeadRow._request_date = dtpDelvBy.Value
            newWsOrdHeadRow._cancel_date = dtpCancelBy.Value
            newWsOrdHeadRow.season = txtSeason.Text
            newWsOrdHeadRow._order_code = txtOrderCd.Text
            newWsOrdHeadRow._cust_po = txtPO.Text
            newWsOrdHeadRow.department = mebDept.Text
            newWsOrdHeadRow._via_code = txtShipVia.Text

            If chkReadyToXmit.CheckState = CheckState.Checked Then
                newWsOrdHeadRow.ReadyToXmit = True
            ElseIf chkReadyToXmit.CheckState = CheckState.Unchecked Then
                newWsOrdHeadRow.ReadyToXmit = False
            End If
            If chkCancel.CheckState = 1 Then
                newWsOrdHeadRow.CancelWS = True
            ElseIf chkCancel.CheckState = 0 Then
                newWsOrdHeadRow.CancelWS = False
            End If
            If chkOrderComplete.CheckState Then
                newWsOrdHeadRow._ord_compl = True
            Else
                newWsOrdHeadRow._ord_compl = False
            End If
            newWsOrdHeadRow.Xmitted = False
            newWsOrdHeadRow.IsOrderReady = lReadyForOrder
            newWsOrdHeadRow._last_update_date = Today
            newWsOrdHeadRow.LastUpdated = Today
            SaleForcDataSet._ws_ord_head.Rows.Add(newWsOrdHeadRow)
            daWsOrdHead.Update(Me.SaleForcDataSet)
            SaleForcDataSet._ws_ord_head.AcceptChanges()
        Else
            wsTable = daWsOrdHead.GetData()
            wsrow = wsTable.FindBy_worksheet_id(cWsNo)
            wsrow.BeginEdit()
            wsrow._request_date = dtpDelvBy.Value
            wsrow._cancel_date = dtpCancelBy.Value
            wsrow.season = txtSeason.Text
            wsrow._order_code = txtOrderCd.Text
            wsrow._cust_po = txtPO.Text
            wsrow.department = mebDept.Text
            wsrow._via_code = txtShipVia.Text

            If chkReadyToXmit.CheckState = CheckState.Checked Then
                wsrow.ReadyToXmit = True
            ElseIf chkReadyToXmit.CheckState = 0 Then
                wsrow.ReadyToXmit = False
            End If
            If chkCancel.CheckState = 1 Then
                wsrow.CancelWS = True
            ElseIf chkCancel.CheckState = 0 Then
                wsrow.CancelWS = False
            End If
            If chkOrderComplete.CheckState Then
                wsrow._ord_compl = True
            Else
                wsrow._ord_compl = False
            End If
            wsrow.Xmitted = False
            wsrow.IsOrderReady = lReadyForOrder
            wsrow._last_update_date = Today
            wsrow.LastUpdated = Today
            wsrow.EndEdit()
            daWsOrdHead.Update(wsTable)
        End If
    End Sub

    ''' <summary>
    ''' This procedure puts the worksheet line changes into variables to ensure that no null values exist, and then saves them into the
    ''' ws-ord-line table
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub SaveWorkSheetLines()
        Dim con As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        Dim sql As String
        Dim i As Integer

        con.ConnectionString = MySettings.Default("SaleForcConnectionString")
        con.Open()
        sql = "SELECT * FROM WsItemTemp"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(dt)
        con.Close()

        If dt.Rows.Count = 0 Then Exit Sub

        For i = 0 To dt.Rows.Count - 1
            If IsDBNull(dt.Rows(i)("WorksheetID")) Or Trim(dt.Rows(i)("WorksheetID")) = "" Or IsDBNull(dt.Rows(i)("ItemNo")) Or Trim(dt.Rows(i)("ItemNo")) = "" Then

            Else
                '              cWsNo = MyTable("WorksheetID")
                cItmNo = dt.Rows(i)("ItemNo")
                lDel = dt.Rows(i)("Deleted")

                If IsDBNull(dt.Rows(i)("QtyOrdered")) Or dt.Rows(i)("QtyOrdered") = 0 Then
                    nQtyOrd = 0
                    lDel = True
                Else
                    nQtyOrd = dt.Rows(i)("QtyOrdered")
                End If

                If IsDBNull(dt.Rows(i)("Price")) Then
                    nPrice = 0
                    nExtnd = 0
                Else
                    nPrice = dt.Rows(i)("Price")
                    nExtnd = nPrice * nQtyOrd
                End If

                If IsDBNull(dt.Rows(i)("ReadyForOrder")) Then
                    lReadyForOrder = False
                Else
                    lReadyForOrder = dt.Rows(i)("ReadyForOrder")
                End If


                If IsDBNull(dt.Rows(i)("Description")) Then
                    cDescription = ""
                Else
                    cDescription = dt.Rows(i)("Description")
                End If

                If IsDBNull(dt.Rows(i)("Style")) Then
                    cStyle = ""
                    lReadyForOrder = False
                Else
                    cStyle = dt.Rows(i)("Style")
                End If

                If IsDBNull(dt.Rows(i)("Color")) Then
                    cColor = ""
                Else
                    cColor = dt.Rows(i)("Color")
                End If

                If IsDBNull(dt.Rows(i)("Size")) Then
                    cSize = ""
                Else
                    cSize = dt.Rows(i)("Size")
                End If
                nEntryOrder = dt.Rows(i)("EntryOrder")
                UpdateWsLine()
            End If
        Next
        'ClrWSItemTemp()
    End Sub

    ''' <summary>
    ''' This procedure saves the data from the worksheet memo text box into records in the WsMemo table
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub SaveWorkSheetMemos()
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim com As New OleDb.OleDbCommand("DELETE * FROM WsMemo WHERE [worksheet-id] = '" & cWsNo & "'", con)
        Dim daNewWSMemo As New SaleForcDataSetTableAdapters.WSMemoTableAdapter

        Dim i As Short
        Dim tmpcomment As String
        Dim tmpCommentLines As Short
        Dim tmpCommentLinesMod As Short

        con.Open()

        ' delete all ws memos for this worksheet
        com.ExecuteNonQuery()

        ' write out whatever is in the textbox

        tmpCommentLines = Int(Len(Me.txtWSMemo.Text) / 30) ' Int function gets only number to the left of the decimal
        tmpCommentLinesMod = Len(Me.txtWSMemo.Text) Mod 30
        If tmpCommentLinesMod > 0 Then ' if len of the text is not evenly divisible by 30 add a line
            tmpCommentLines = tmpCommentLines + 1
        End If

        For i = 1 To tmpCommentLines
            If i < tmpCommentLines Then
                tmpcomment = Mid(Me.txtWSMemo.Text, ((i - 1) * 30) + 1, 30)
            Else
                tmpcomment = Mid(Me.txtWSMemo.Text, ((i - 1) * 30) + 1)
            End If
            com.CommandText = "INSERT INTO WsMemo ([Worksheet-Id], [LineNumber], [Comment], [LastUpdated]) VALUES ('" & cWsNo & "'," & i & "," & Chr(34) & tmpcomment & Chr(34) & "," & Today & ")"
            com.ExecuteNonQuery()
        Next
        con.Close()
    End Sub

    ''' <summary>
    ''' This procedure saves the data into the ws-ord-line file from the temporary WsItemTemp table
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub UpdateWsLine()
        Dim con As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        Dim sql As String
        Dim com As New OleDb.OleDbCommand

        con.ConnectionString = MySettings.Default("SaleForcConnectionString")
        con.Open()
        sql = "SELECT * FROM [ws-ord-line] WHERE [worksheet-id] = '" & cWsNo & "' AND [item-no] = '" & cItmNo & "'"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(dt)

        'newWsOrdLineRow = Me.SaleForcDataSet._ws_ord_line.New_ws_ord_lineRow
        If dt.Rows.Count = 0 Then
            If Not lDel Then

                com = New OleDb.OleDbCommand("INSERT INTO [ws-ord-line] ([worksheet-id], [item-no], [qty-orig-ord], [price], [canbeordered], " & _
                                  "[lastupdated], [orderlineno], [extended], [description], [style], [color], [size], [isdateinrange], " & _
                                  "[readyfororder], [entryorder]) VALUES('" & cWsNo & "', '" & cItmNo & "', " & nQtyOrd & "," & nPrice & "," & _
                                  lCanBeOrdered & ",#" & Today & "#, 0, " & nExtnd & ",'" & cDescription & "','" & cStyle & "','" & cColor & "','" & _
                                  cSize & "'," & lIsDateInRange & "," & lReadyForOrder & "," & nEntryOrder & ")", con)
                com.ExecuteNonQuery()
                com.Dispose()
            End If
        Else
            If lDel = True Then
                com = New OleDb.OleDbCommand("DELETE FROM [ws-ord-line] WHERE [worksheet-id] = '" & cWsNo & "' AND [item-no] = '" & cItmNo & "'", con)
                com.ExecuteNonQuery()
                com.Dispose()
            Else
                com = New OleDb.OleDbCommand("UPDATE [ws-ord-line] SET [qty-orig-ord] = " & nQtyOrd & " WHERE [worksheet-id] = '" & cWsNo & "' and [item-no] = '" & cItmNo & "'", con)
                com.ExecuteNonQuery()
                com.Dispose()
            End If
        End If
        con.Close()
    End Sub

    ''' <summary>
    ''' This procedure initializes and populates the controls when creating a new worksheet
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub NewWsInit()
        ' ---- Clear data from temporary database ------------------
        ClrWSItemTemp()
        ' ---- Retrive the initial values for a new worksheet ------
        getSlsmnInitData()
        txtSeason.Text = cSalesSeason
        lblSeasonDesc.Text = findSeasonDesc(cSalesSeason)

        dtpDelvBy.Value = CDate(dDeliverDate)
        dtpCancelBy.MinDate = dtpDelvBy.Value
        dtpCancelBy.Value = CDate(dCancelDate)
        dtpDelvBy.MinDate = System.DateTime.Today
        dtpDelvBy.MaxDate = dtpCancelBy.Value

        txtOrderCd.Text = cOrderCode
        lblOrdTypeDesc.Text = findOrdTypeDesc(cOrderCode)
        chkOrderComplete.CheckState = System.Windows.Forms.CheckState.Unchecked
        chkReadyToXmit.CheckState = System.Windows.Forms.CheckState.Unchecked
        chkReadyToXmit.Enabled = False
        chkCancel.CheckState = System.Windows.Forms.CheckState.Unchecked
        chkCancel.Enabled = False
        chkMaintAllowed.CheckState = System.Windows.Forms.CheckState.Checked
        chkMaintAllowed.Enabled = False
        mebDept.Text = ""
        txtPO.Text = ""

        lblDateCreated.Text = CStr(Today)
        chkXmitted.CheckState = System.Windows.Forms.CheckState.Unchecked

        lblCustNo.Text = cCustNumber
        lblCustomer.Text = cCustNameW

        lblCustShipNo.Text = cShipNumber
        lblShipTo.Text = cShipNameW
        txtShipVia.Text = cWsShipViaCd
        If txtShipVia.Text <> "" Then
            lblShipViaDesc.Text = findShipViaDesc((txtShipVia.Text))
        End If

        If VB.Left(UCase(cCustNumber), 2) = "ZZ" Then
            optCustIs(0).Checked = True
        Else
            optCustIs(1).Checked = True

        End If
        ' ---- Set flags (boolean operators)-----------------------
        lSaveFlag = False
    End Sub

    ''' <summary>
    ''' This procedure calculates totals for items ordered on the worksheet and displays the totals on the item entry screen
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub ReCalcTotals() ' Recalculates the worksheet totals
        Dim con As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        Dim sql As String

        con.ConnectionString = MySettings.Default("SaleForcConnectionString")
        con.Open()
        sql = "SELECT Sum(WSItemTemp.QtyOrdered) AS SumOfQtyOrdered, Sum(([Price]*[qtyordered])) AS ExtendedPrice FROM WSItemTemp;"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(dt)
        con.Close()
        If Not IsDBNull(dt.Rows(0)("ExtendedPrice")) Then
            lblTotExtended.Text = Convert.ToDecimal(dt.Rows(0)("ExtendedPrice")).ToString("c")
        Else
            lblTotExtended.Text = "$0.00"
        End If
        If Not IsDBNull(dt.Rows(0)("SumOfQtyOrdered")) Then
            lblTotQty.Text = dt.Rows(0)("SumOfQtyOrdered").ToString
        Else
            lblTotQty.Text = "0"
        End If
    End Sub

    ''' <summary>
    ''' This procedures set various frame and button settings for different configurations
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub setFrameSettings()
        fraStatus.Enabled = False
        mebDept.ReadOnly = True
        txtPO.ReadOnly = True
        dtpDelvBy.Enabled = False
        dtpCancelBy.Enabled = False
        chkOrderComplete.Tag = "disable"
        fraDisplayCodes.Enabled = False

        chkCancel.Enabled = False
        chkReadyToXmit.Enabled = False
    End Sub

    ''' <summary>
    ''' This procedures checks the worksheet data to make sure all required information is there and that it is not missing and is valid.
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub chkValidData()
        Me.Enabled = False
        chkForSeason()
        chkForOrderCd()
        chkForShipViaCd()
    End Sub

    ''' <summary>
    ''' This procedures checks to make sure that their is a season code on the worksheet
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub chkForSeason()
tryAgainSeason:
        If Trim(txtSeason.Text) = "" Then

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            frmSeasonSelect.ShowDialog()

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            If flagSeasonSelected = False Then
                GoTo tryAgainSeason
            Else
                lblSeasonDesc.Text = cSeasonDesc
                txtSeason.Text = cSeasonCd
            End If
        End If
    End Sub

    ''' <summary>
    ''' This procedures checks to make sure that their is an order code on the worksheet
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub chkForOrderCd()
tryAgainOrderCd:
        If Trim(txtOrderCd.Text) = "" Then

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            frmOrdCodeSelect.ShowDialog()

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            If flagOrdTypeSelected = False Then
                GoTo tryAgainOrderCd
            Else
                lblOrdTypeDesc.Text = cOrdTypeDesc
                txtOrderCd.Text = cOrdTypeCode
            End If
        End If
    End Sub

    ''' <summary>
    ''' This procedures checks to make sure that their is a ship via code on the worksheet
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub chkForShipViaCd()
tryAgainShipVia:
        If Trim(txtShipVia.Text) = "" Then

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            frmShipViaSelect.ShowDialog()

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            If flagShipViaSelected = False Then
                GoTo tryAgainShipVia
            Else
                txtShipVia.Text = cShipViaCd
            End If
        End If
        Me.Enabled = True
    End Sub

    ''' <summary>
    ''' This procedure highlights any text when the user enters the field so that it can be overwritten if the user chooses to do so
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub mebDept_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mebDept.Enter
        lblHelpMsg.Text = HelpMsgWs(1)
        If Len(Trim(mebDept.Text)) > 0 And mebDept.Text <> "________" Then
            mebDept.SelectionStart = 0
            mebDept.SelectionLength = Len(Trim(mebDept.Text))
        End If
    End Sub

    ''' <summary>
    ''' This procedure highlights any text when the user enters the field so that it can be overwritten if the user chooses to do so
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub txtPO_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPO.Enter
        lblHelpMsg.Text = HelpMsgWs(2)
        If Len(Trim(txtPO.Text)) > 0 And txtPO.Text <> "________" Then
            txtPO.SelectionStart = 0
            txtPO.SelectionLength = Len(Trim(txtPO.Text))
        End If
    End Sub

    ''' <summary>
    ''' This procedure populates the help text in the help text box when the user enters the control
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub chkOrderComplete_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkOrderComplete.Enter
        lblHelpMsg.Text = HelpMsgWs(3)
    End Sub

    ''' <summary>
    ''' This procedure populates the help text in the help text box when the user enters the control
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub dtpDelvBy_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dtpDelvBy.Enter
        lblHelpMsg.Text = HelpMsgWs(4)
    End Sub

    ''' <summary>
    ''' This procedure populates the help text in the help text box when the user enters the control
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub dtpCancelBy_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dtpCancelBy.Enter
        lblHelpMsg.Text = HelpMsgWs(5)
    End Sub

    ''' <summary>
    ''' This procedure populates the help text in the help text box when the user enters the control
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmdSeason_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSeason.Enter
        lblHelpMsg.Text = HelpMsgWs(6)
    End Sub

    ''' <summary>
    ''' This procedure populates the help text in the help text box when the user enters the control
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmdOrderCode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOrderCode.Enter
        lblHelpMsg.Text = HelpMsgWs(7)
    End Sub

    ''' <summary>
    ''' This procedure populates the help text in the help text box when the user enters the control
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmdShipVia_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdShipVia.Enter
        lblHelpMsg.Text = HelpMsgWs(8)
    End Sub

    ''' <summary>
    ''' This procedure populates the help text in the help text box when the user enters the control
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub chkReadyToXmit_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        lblHelpMsg.Text = HelpMsgWs(10)
    End Sub

    ''' <summary>
    ''' This procedure populates the help text in the help text box when the user enters the control
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub chkCancel_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        lblHelpMsg.Text = HelpMsgWs(9)
    End Sub

    ''' <summary>
    ''' This procedure populates the help text in the help text box when the user enters the control
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub btnExit_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnExit.Enter
        lblHelpMsg.Text = HelpMsgWs(21)
    End Sub

    ''' <summary>
    ''' This procedure populates the help text in the help text box when the user enters the control
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub btnPrint_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnPrint.Enter
        lblHelpMsg.Text = HelpMsgWs(22)
    End Sub

    ''' <summary>
    ''' This procedure populates the help text in the help text box when the user enters the control
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub btnItems_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnItems.Enter
        lblHelpMsg.Text = HelpMsgWs(23)
    End Sub

    ''' <summary>
    ''' This procedure populates the help text in the help text box when the user enters the control
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub btnEditWs_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnEditWS.Enter
        lblHelpMsg.Text = HelpMsgWs(24)
    End Sub

    ''' <summary>
    ''' This procedure is called to make sure to clear any memos if the user chooses to not save the worksheet
    ''' </summary>
    ''' <param name="cWsNum"></param>
    ''' <remarks></remarks>

    Private Sub clrNotUsedMemos(ByRef cWsNum As String)
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim com As New OleDb.OleDbCommand("Delete * from WSMemo WHERE [Worksheet-ID] = '" & cWsNum & "'", con)
        con.Open()
        com.ExecuteNonQuery()
        con.Close()
    End Sub

    ''' <summary>
    ''' This procedure will update the 'deleted' field to yes for any items from the worksheet if the user chooses to delete this style
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmdClearStyleQty_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClearStyleQty.Click
        Dim row As Short
        Dim column As Short
        Dim ans As Short

        If Len(Trim(txtStyle.Text)) = 0 Then
            MsgBox("No style quantities to delete", MsgBoxStyle.Information, "Delete style quantities")
            Exit Sub
        End If

        ans = MsgBox("Are you sure you want to delete all quantities for this style?", MsgBoxStyle.YesNo, "Delete Style " & Trim(txtStyle.Text) & " quantities")
        If ans = MsgBoxResult.No Then Exit Sub

        dgvColorSize.Enabled = False

        For row = 2 To dgvColorSize.Rows.Count - 1
            For column = 2 To dgvColorSize.Columns.Count - 1
                If Len(dgvColorSize.Item(column, row).Value) > 0 Then
                    dgvColorSize.Item(column, row).Value = ""
                End If
            Next
        Next

        DeleteTmpItems(txtStyle.Text)
        cmdNextStyle_Click(cmdNextStyle, New System.EventArgs())
        lblShipDates.Text = "This item ships between" & Space(17) & "and"
        lblItemPrice.Text = "Item Price: $0.00"
        Exit Sub
    End Sub

    ''' <summary>
    ''' This procedure will mark the 'deleted' field to yes for any items in the worksheet that the user wants to delete
    ''' </summary>
    ''' <param name="tmpItem"></param>
    ''' <remarks></remarks>

    Private Sub DeleteTmpItems(ByVal tmpItem As String)
        Dim i As Integer
        Dim conn As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim daWSItemTemp As OleDb.OleDbDataAdapter
        Dim dtWSItemTemp As New DataTable

        conn.Open()
        daWSItemTemp = New OleDb.OleDbDataAdapter("SELECT [itemno] FROM WsItemTemp WHERE [itemno] LIKE '" & tmpItem & "%'", conn)
        daWSItemTemp.Fill(dtWSItemTemp)

        For i = 0 To dtWSItemTemp.Rows.Count - 1
            Dim com As New OleDb.OleDbCommand("UPDATE [wsitemtemp] SET qtyordered = 0, extended = 0, price = 0, deleted = true, readyfororder = false WHERE [itemno] = '" & dtWSItemTemp.Rows(i)("itemno") & "'", conn)
            com.ExecuteNonQuery()
        Next

        conn.Close()
        UpdateStyleTotals()
        ReCalcTotals()
        GetData(Mid(WSItemTempTableAdapter.Adapter.SelectCommand.CommandText, 1, Len(WSItemTempTableAdapter.Adapter.SelectCommand.CommandText) - 1) & "'" & cCustWsNum & "'")
    End Sub

    ''' <summary>
    ''' When the user enters test into the 'Style' textbox, this procedure will make a call to create the row and column labels for the 
    ''' datagrid that is used to put in quantities of items they want to order.  If this is a style that they already ordered on this 
    ''' worksheet, this procedure makes a call to load the quantity amounts for those items.
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub txtStyle_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtStyle.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        '    On Error GoTo ErrorRoutine
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        con.Open()

        If KeyAscii = System.Windows.Forms.Keys.Return Then

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            dgvColorSize.Enabled = False
            lblTotStyleQty.Text = "0"
            lblExtStylePrice.Text = Convert.ToDecimal(0).ToString("c")
            'da = New OleDb.OleDbDataAdapter("SELECT [attrib2], [attrib3] FROM item WHERE [attrib1] = '" & Trim(txtStyle.Text) & "' and [attrib2] > '' and [attrib3] > '' and [canbeordered] = True", con)
            da = New OleDb.OleDbDataAdapter("SELECT [item], [description1], [attrib2], [attrib3], [prodgroup], [canbeordered] FROM item WHERE [item] LIKE '" & txtStyle.Text & "%'", con)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Call LoadColorsSizes((txtStyle.Text))
                If lnotfound = False Then
                    dgvColorSize.Enabled = True
                    LoadQuantities()
                    If dgvColorSize.Columns.Count > 2 And dgvColorSize.Rows.Count > 2 Then
                        dgvColorSize.CurrentCell = dgvColorSize(2, 2)
                        dgvColorSize.Focus()
                    End If
                    'dgvColorSize_CellEnter(dgvColorSize, eventArgs)
                End If

            Else
                MsgBox("No colors and sizes available for this style.", MsgBoxStyle.Exclamation, "Item Entry")
                txtStyle.ResetText()
                txtStyle.Focus()
            End If
            eventArgs.KeyChar = Chr(KeyAscii)
            If KeyAscii = 0 Then
                eventArgs.Handled = True
            End If
        End If
        con.Close()
    End Sub

    ''' <summary>
    ''' This is the procedure that creates the row and column labels for the datagrid where the user enters quantities of items they 
    ''' wish to order
    ''' </summary>
    ''' <param name="itemNo"></param>
    ''' <remarks></remarks>

    Private Sub LoadColorsSizes(ByRef itemNo As String)
        ' On Error GoTo ErrorRoutine
        Dim con As New OleDb.OleDbConnection

        Dim daItem As OleDb.OleDbDataAdapter
        Dim daColor As OleDb.OleDbDataAdapter
        Dim daSize As OleDb.OleDbDataAdapter
        Dim daProdGroupAttr As OleDb.OleDbDataAdapter

        Dim dtItem As New DataTable
        Dim dtColor As New DataTable
        Dim dtSize As New DataTable
        Dim dtProdGroupAttr As New DataTable

        Dim sql As String = Nothing
        Dim i As Short
        Dim colNumber As Short
        Dim tmpColor As String = Nothing
        Dim tmpSize As String = Nothing
        Dim tmpProdGroup As String = Nothing
        Dim prodgroup1 As String = Nothing
        Dim prodgroup2 As String = Nothing
        Dim attrCount As Short
        Dim prodgroup1_pos As Short
        Dim prodgroup2_pos As Short
        Dim arrProdGroup() As String = Nothing
        Dim arrProdGroupPos() As Short
        ReDim arrProdGroup(3)
        ReDim arrProdGroupPos(3)
        Dim sizeArray() As String = Nothing
        ReDim sizeArray(1)
        Dim sizeDescArray() As String = Nothing
        ReDim sizeDescArray(1)
        Dim ans As MsgBoxResult
        Dim tmpQtyOrdered As String = Nothing

        con.ConnectionString = MySettings.Default("SaleForcConnectionString")
        con.Open()
        sql = "SELECT [item], [description1], [attrib2], [attrib3], [prodgroup], [canbeordered] FROM item WHERE [item] = '" & itemNo & "'"
        daItem = New OleDb.OleDbDataAdapter(sql, con)
        daItem.Fill(dtItem)

        If dtItem.Rows.Count = 0 Then
            MsgBox("Item Not Found", MsgBoxStyle.Information, "Matrix Entry")
            lnotfound = True
            txtStyle.Text = tmpItemText
            txtStyle.SelectionStart = 0
            txtStyle.SelectionLength = Len(Trim(txtStyle.Text))
            Exit Sub
        Else
            sql = "SELECT [item], [description1], [attrib2], [attrib3], [prodgroup], [canbeordered] FROM item WHERE [item] LIKE '" & itemNo & "%'"
            daItem = New OleDb.OleDbDataAdapter(sql, con)
            daItem.Fill(dtItem)
            lnotfound = False
        End If

        tmpItemText = txtStyle.Text
        lblItemDescription.Text = dtItem.Rows(0)("description1").ToString

        ' This section of the procedure formats the datagrid

        dgvColorSize.Visible = True
        dgvColorSize.Rows.Clear()
        dgvColorSize.Columns.Clear()

        dgvColorSize.RowHeadersVisible = False
        dgvColorSize.ColumnHeadersVisible = False

        dgvColorSize.Columns.Add("Col1", "1")
        dgvColorSize.Columns.Add("Col2", "2")
        dgvColorSize.Columns(0).Frozen = True
        dgvColorSize.Columns(0).ReadOnly = True
        dgvColorSize.Columns(0).DefaultCellStyle.BackColor = Drawing.Color.LightGray
        dgvColorSize.Columns(1).Frozen = True
        dgvColorSize.Columns(1).ReadOnly = True
        dgvColorSize.Columns(1).DefaultCellStyle.BackColor = Drawing.Color.LightGray
        dgvColorSize.Columns(0).Width = 70

        dgvColorSize.Rows.Add(2)
        dgvColorSize.Rows(0).Frozen = True
        dgvColorSize.Rows(0).ReadOnly = True
        dgvColorSize.Rows(0).DefaultCellStyle.BackColor = Drawing.Color.LightGray
        dgvColorSize.Rows(1).Frozen = True
        dgvColorSize.Rows(1).ReadOnly = True
        dgvColorSize.Rows(1).DefaultCellStyle.BackColor = Drawing.Color.LightGray

        'This part of the procedure counts the number of attributes for the style entered

        sql = "SELECT * FROM [Product Group Attributes]"
        daProdGroupAttr = New OleDb.OleDbDataAdapter(sql, con)
        daProdGroupAttr.Fill(dtProdGroupAttr)

        For i = 0 To dtProdGroupAttr.Rows.Count - 1
            If Trim(dtProdGroupAttr.Rows(i)("ProductGroup")) = Trim(dtItem.Rows(0)("ProdGroup")) Then
                attrCount = attrCount + 1
                If attrCount > 3 Then
                    Exit For
                End If
                arrProdGroup(attrCount) = dtProdGroupAttr.Rows(i)("AttrDesc")
                arrProdGroupPos(attrCount) = dtProdGroupAttr.Rows(i)("AttrPosition")
            End If
        Next

        'This part of the procedure sets the position and attribute description  variables (i.e. 'color' and 'size') for each of the 
        'attributes.  These variables are used later in the procedure to get attribute position and length from the Product Group
        'Attributes table

        If attrCount = 3 Then
            For i = 1 To 3
                If arrProdGroupPos(i) <> 1 Then 'if this is not the 'style' attribute
                    If Len(Trim(prodgroup1)) = 0 Then
                        prodgroup1 = arrProdGroup(i)    'color
                        prodgroup1_pos = arrProdGroupPos(i) 'color position
                    Else
                        prodgroup2 = arrProdGroup(i) 'size
                        prodgroup2_pos = arrProdGroupPos(i) 'size position
                    End If
                End If
            Next
            If prodgroup2_pos < prodgroup1_pos Then
                tmpProdGroup = prodgroup1
                prodgroup1 = prodgroup2
                prodgroup2 = tmpProdGroup
            End If
        End If

        ' This part of the procedure checks to see if the item is attributed and if not then provides a message on how to view/delete
        ' the non attributed item.

        tmpAttributed = True
        If attrCount = 0 And dtItem.Rows(0)("canbeordered") = True Then
            Dim daWSTempItem As OleDb.OleDbDataAdapter
            Dim dtWSTempItem As New DataTable
            sql = "SELECT [qtyordered],[itemno],[price],[extended],[readyfororder],[deleted] FROM WSItemTemp WHERE [itemno] = '" & Trim(txtStyle.Text) & "'"
            daWSTempItem = New OleDb.OleDbDataAdapter(sql, con)
            daWSTempItem.Fill(dtWSTempItem)
            If dgvColorSize.ReadOnly = True And dtWSTempItem.Rows.Count > 0 Then
                MsgBox("Review grid below for " & Trim(txtStyle.Text))
                cmdNextStyle_Click(Nothing, Nothing)
                Exit Sub
            End If
            If dtWSTempItem.Rows.Count <> 0 Then
                If dtWSTempItem.Rows(0)("deleted") = False Then
                    ans = MsgBox("Do you want to delete this style/item?", MsgBoxStyle.YesNo, "Delete Item")
                    If ans = MsgBoxResult.Yes Then
                        DeleteTmpItems(txtStyle.Text)
                        cmdNextStyle_Click(cmdNextStyle, New System.EventArgs())
                        Exit Sub
                    End If
                    tmpQtyOrdered = dtWSTempItem.Rows(0)("qtyordered").ToString
                End If
            End If
            dgvColorSize.Columns.Add("Cols0", "")
            dgvColorSize.Rows.Add()
            dgvColorSize.CurrentCell = dgvColorSize(2, 2)
            dgvColorSize.CurrentCell.Value = InputBox("Please enter the quantity you wish to order in the space below:", "Non Attributed Item", tmpQtyOrdered)
            tmpAttributed = False
            Call dgvColorSize_CellEndEdit(Nothing, Nothing)
            cmdNextStyle_Click(cmdNextStyle, New System.EventArgs())
        End If

        'These two tables store information about the position and length of attributes for this style

        sql = "SELECT * FROM [Product Group Attributes] WHERE productgroup = '" & dtItem.Rows(0)("prodgroup") & "' and attrdesc = '" & prodgroup1 & "'"
        daColor = New OleDb.OleDbDataAdapter(sql, con)
        daColor.Fill(dtColor)

        sql = "SELECT * FROM [Product Group Attributes] WHERE productgroup = '" & dtItem.Rows(0)("prodgroup") & "' and attrdesc = '" & prodgroup2 & "'"
        daSize = New OleDb.OleDbDataAdapter(sql, con)
        daSize.Fill(dtSize)

        con.Close()

        If dtColor.Rows.Count <> 0 And dtSize.Rows.Count <> 0 Then

            tmpColor = Mid(dtItem.Rows(0)("Item"), dtColor.Rows(0)("attrPosition"), dtColor.Rows(0)("attrLen"))
            tmpSize = Mid(dtItem.Rows(0)("Item"), dtSize.Rows(0)("attrPosition"), dtSize.Rows(0)("attrLen"))

            For i = 0 To dtItem.Rows.Count - 1
                If UCase(Mid(dtItem.Rows(i)("Item"), 1, Len(Trim(txtStyle.Text)))) = UCase(itemNo) Then
                    If dtItem.Rows(i)("canbeordered") Then

                        ' -------------------------------------
                        ' Add color number and description rows
                        ' -------------------------------------

                        If Mid(dtItem.Rows(i)("Item"), dtColor.Rows(0)("attrPosition"), dtColor.Rows(0)("attrLen")) <> tmpColor Then
                            dgvColorSize.Rows.Add()
                            tmpColor = Mid(dtItem.Rows(i)("Item"), dtColor.Rows(0)("attrPosition"), dtColor.Rows(0)("attrLen"))
                            dgvColorSize.Item(0, dgvColorSize.Rows.Count - 1).Value = tmpColor
                            dgvColorSize.Item(1, dgvColorSize.Rows.Count - 1).Value = dtItem.Rows(i)("attrib2")
                        End If

                        ' -------------------------------------------
                        ' Create array for size code and descriptions
                        ' -------------------------------------------

                        If Mid(dtItem.Rows(i)("Item"), dtSize.Rows(0)("attrPosition"), dtSize.Rows(0)("attrLen")) <> tmpSize Then
                            tmpSize = Mid(dtItem.Rows(i)("Item"), dtSize.Rows(0)("attrPosition"), dtSize.Rows(0)("attrLen"))
                            If tmpSize <> "" Then
                                If Int(CDbl(tmpSize)) > UBound(sizeArray) Then
                                    ReDim Preserve sizeArray(Int(CDbl(tmpSize)))
                                    ReDim Preserve sizeDescArray(Int(CDbl(tmpSize)))
                                End If
                                sizeArray(CShort(Mid(dtItem.Rows(i)("Item"), dtSize.Rows(0)("attrPosition"), dtSize.Rows(0)("attrLen")))) = Mid(dtItem.Rows(i)("Item"), dtSize.Rows(0)("attrPosition"), dtSize.Rows(0)("attrLen"))
                                sizeDescArray(CShort(Mid(dtItem.Rows(i)("Item"), dtSize.Rows(0)("attrPosition"), dtSize.Rows(0)("attrLen")))) = dtItem.Rows(i)("attrib3")
                            End If
                        End If
                    End If
                Else
                    Exit For
                End If
            Next

            ' ---------------------------------------------------------------
            ' Create columns and add size code and description to each column
            ' ---------------------------------------------------------------
            colNumber = 1
            For i = 1 To UBound(sizeArray)
                If sizeArray(i) <> "" Then
                    colNumber = colNumber + 1
                    dgvColorSize.Columns.Add("Cols" & Str(colNumber), "")
                    dgvColorSize.Columns("Cols" & Str(colNumber)).Width = 70
                    dgvColorSize.Item(colNumber, 0).Value = sizeArray(i)
                    dgvColorSize.Item(colNumber, 1).Value = sizeDescArray(i)
                End If
            Next
        End If
    End Sub

    ''' <summary>
    ''' This procedure updates the price and quantity totals for the current style
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub UpdateStyleTotals()
        Dim con As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        Dim sql As String
        Dim i As Integer

        intStyleQty = 0
        curStyleExtPrice = 0

        con.ConnectionString = MySettings.Default("SaleForcConnectionString")
        con.Open()
        sql = "SELECT [itemno], [qtyordered], [extended] FROM WSItemTemp"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(dt)
        con.Close()

        If dt.Rows.Count <> 0 Then
            For i = 0 To dt.Rows.Count - 1
                If Mid(dt.Rows(i)("itemno"), 1, Len(Trim(txtStyle.Text))) = Trim(txtStyle.Text) And Len(Trim(txtStyle.Text)) <> 0 Then
                    intStyleQty = intStyleQty + dt.Rows(i)("qtyordered")
                    curStyleExtPrice = curStyleExtPrice + dt.Rows(i)("extended")
                End If
            Next
        End If
        lblTotStyleQty.Text = CStr(intStyleQty)
        lblExtStylePrice.Text = Convert.ToDecimal(curStyleExtPrice).ToString("c")
        lblTotStyleQty.Refresh()
        lblExtStylePrice.Refresh()
    End Sub

    ''' <summary>
    ''' This procedure is a check to see if there is an order for the same item, for the same season, the same order code, and for 
    ''' the same customer.  If so, it provides a warning message.
    ''' </summary>
    ''' <param name="AscKeyPressed"></param>
    ''' <remarks></remarks>

    Private Sub CheckPrevOrder(ByRef AscKeyPressed As Short)
        Dim con As New OleDb.OleDbConnection
        Dim daOrder As OleDb.OleDbDataAdapter
        Dim dtOrder As New DataTable
        Dim daWsOrdHead As OleDb.OleDbDataAdapter
        Dim dtWsOrdHead As New DataTable
        Dim sql As String

        lblItemPrevOrder.Text = ""

        If (AscKeyPressed >= System.Windows.Forms.Keys.D0 And AscKeyPressed <= System.Windows.Forms.Keys.D9) Or (AscKeyPressed >= System.Windows.Forms.Keys.NumPad0 And AscKeyPressed <= System.Windows.Forms.Keys.NumPad9) Then
            con.ConnectionString = MySettings.Default("SaleForcConnectionString")
            con.Open()
            sql = "SELECT Order.[Cust-no], Order.[Order-no], Order.Season, [Order-line].[Item-no] " & "FROM [Order] INNER JOIN [Order-line] ON Order.[Order-no] = [Order-line].[Order-no] " & "WHERE Order.[Cust-no] = " & Chr(39) & lblCustNo.Text & Chr(39) & " AND Order.[ship-no] = " & Chr(39) & lblCustShipNo.Text & Chr(39) & " AND Order.[Order-code] = " & Chr(39) & Me.txtOrderCd.Text & Chr(39) & " AND [Order-line].[Item-no] = " & Chr(39) & Trim(txtStyle.Text) & color & tmpSize & Chr(39) & " AND [order-line].[qty-orig-ord] <> ([order-line].[qty-shipped] + [order-line].[cut-back-qty])"
            daOrder = New OleDb.OleDbDataAdapter(sql, con)
            daOrder.Fill(dtOrder)

            sql = "SELECT [ws-ord-head].[cust-no], [ws-ord-head].[worksheet-id], [ws-ord-head].[season], [ws-ord-line].[item-no] " & "FROM [ws-ord-head] INNER JOIN [ws-ord-line] ON [ws-ord-head].[worksheet-id] = [ws-ord-line].[worksheet-id] " & "WHERE [ws-ord-head].[cust-no] = " & Chr(39) & lblCustNo.Text & Chr(39) & " AND [ws-ord-head].[ship-no] = " & Chr(39) & lblCustShipNo.Text & Chr(39) & " AND [ws-ord-head].[order-code] = " & Chr(39) & Me.txtOrderCd.Text & Chr(39) & " AND [ws-ord-line].[item-no] = " & Chr(39) & Trim(txtStyle.Text) & color & tmpSize & Chr(39) & " AND [ws-ord-head].[validation-status] <> 'CANCEL'"
            daWsOrdHead = New OleDb.OleDbDataAdapter(sql, con)
            daWsOrdHead.Fill(dtWsOrdHead)

            con.Close()

            If dtOrder.Rows.Count <> 0 Then
                imgPrevOrdered.Visible = True
                lblItemPrevOrder.Text = "WARNING: You have already ordered " & Trim(txtStyle.Text) & color & tmpSize & " for Customer: " & Me.lblCustomer.Text & " (ShipTo:" & lblCustShipNo.Text & ") with order code " & Me.txtOrderCd.Text & "!"
                lblItemPrevOrder.Visible = True
            End If

            If dtWsOrdHead.Rows.Count <> 0 Then
                If dtWsOrdHead.Rows(0)("worksheet-id") <> Me.lblWsNo.Text Then
                    imgPrevOrdered.Visible = True
                    If dtOrder.Rows.Count <> 0 Then
                        lblItemPrevOrder.Text = lblItemPrevOrder.Text & "  WARNING: " & lblCustomer.Text & " (ShipTo: " & lblCustShipNo.Text & ") has a worksheet with " & Trim(txtStyle.Text) & color & tmpSize & " with order code " & Me.txtOrderCd.Text & "!"
                    Else
                        lblItemPrevOrder.Text = "WARNING: " & lblCustomer.Text & " (ShipTo: " & lblCustShipNo.Text & ") has a worksheet with " & Trim(txtStyle.Text) & color & tmpSize & " with order code " & Me.txtOrderCd.Text & "!"
                    End If
                    lblItemPrevOrder.Visible = True
                End If
            End If
        End If
    End Sub

    ''' <summary>
    ''' This procedure loads the quantities for items already ordered for this style into the upper datagrid
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub LoadQuantities()
        Dim con As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        Dim sql As String

        Dim row As Short
        Dim column As Short
        Dim tmpColor As String
        Dim tmpSize As String

        intStyleQty = 0
        curStyleExtPrice = 0

        con.ConnectionString = MySettings.Default("SaleForcConnectionString")
        con.Open()
        sql = "SELECT * FROM WsItemTemp"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(dt)
        con.Close()
        If dt.Rows.Count = 0 Then Exit Sub
        For row = 2 To dgvColorSize.Rows.Count - 1

            tmpColor = dgvColorSize.Item(0, row).Value
            For column = 2 To dgvColorSize.Columns.Count - 1
                tmpSize = dgvColorSize.Item(column, 0).Value
                Dim foundrow As DataRow() = dt.Select("[itemno] = '" & Trim(txtStyle.Text) & tmpColor & tmpSize & "'")
                If foundrow.Length > 0 Then
                    dgvColorSize.Item(column, row).Value = foundrow(0)("qtyordered")
                    intStyleQty = intStyleQty + foundrow(0)("qtyordered")
                    curStyleExtPrice = curStyleExtPrice + foundrow(0)("extended")
                End If
            Next
        Next
        lblTotStyleQty.Text = CStr(intStyleQty)
        lblExtStylePrice.Text = Convert.ToDecimal(curStyleExtPrice).ToString("c")
    End Sub

    ''' <summary>
    ''' This procedure resets controls when the user clicks on this button to show a new style
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmdNextStyle_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNextStyle.Click
        '    On Error GoTo ErrorRoutine
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        dgvColorSize.Rows.Clear()
        dgvColorSize.Columns.Clear()
        dgvColorSize.Enabled = False
        lblItemDescription.Text = ""
        lblItemDescription.Refresh()
        txtStyle.Text = ""
        txtStyle.Refresh()
        txtStyle.Focus()
        lblShipDates.Text = "This item ships between               and"
        lblItemPrice.Text = "Item Price: $0.00"
        UpdateStyleTotals()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    ''' <summary>
    ''' This procedure checks to make sure that the user does not press the 'enter/return' key while in the memos text box
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub txtWSMemo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtWSMemo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        flagHeadChgsMade = True
        If KeyAscii = Asc(vbCrLf) Then
            MsgBox("Enter key not allowed in memos", MsgBoxStyle.Information, "WS Memos")
            KeyAscii = 0
        End If
        If KeyAscii = Asc(Chr(34)) Then
            MsgBox("Quotation Mark not allowed in memos", MsgBoxStyle.Information, "WS Memos")
            KeyAscii = 0
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    ''' <summary>
    ''' This procedure refreshes the temp-items data grid and is called when items have been added or modified
    ''' </summary>
    ''' <param name="selectCommand"></param>
    ''' <remarks></remarks>

    Private Sub GetData(ByVal selectCommand As String)
        Try
            ' Specify a connection string. Replace the given value with a 
            ' valid connection string for a Northwind SQL Server sample
            ' database accessible to your system.
            Dim connectionString As String = MySettings.Default("SaleForcConnectionString")

            ' Create a new data adapter based on the specified query.
            Me.dataadapter = New OleDb.OleDbDataAdapter(selectCommand, connectionString)

            ' Create a command builder to generate SQL update, insert, and
            ' delete commands based on selectCommand. These are used to
            ' update the database.
            Dim commandbuilder As New OleDb.OleDbCommandBuilder(Me.dataadapter)

            ' Populate a new data table and bind it to the BindingSource.
            Dim table As New DataTable()
            table.Locale = System.Globalization.CultureInfo.InvariantCulture
            Me.dataadapter.Fill(table)
            Me.WSItemTempBindingSource.DataSource = table

            ' Resize the DataGridView columns to fit the newly loaded content.
            Me.dgvTempItems.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        Catch ex As OleDb.OleDbException
            MessageBox.Show("To run this example, replace the value of the " + _
                "connectionString variable with a connection string that is " + _
                "valid for your system.")
        End Try
    End Sub

    ''' <summary>
    ''' This procedure adds items to the 'items ordered grid' below when leaving a cell in the upper datagrid.  It performs a number of 
    ''' checks to make sure the user is ordering the correct item and quantity.  It then makes a call to update Style totals and Worksheet
    ''' totals.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub dgvColorSize_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvColorSize.CellEndEdit
        '    On Error GoTo ErrorRoutine
        Dim con As New OleDb.OleDbConnection
        Dim daItem As OleDb.OleDbDataAdapter
        Dim dtItem As New DataTable
        Dim daWSTempItem As OleDb.OleDbDataAdapter
        Dim dtWSTempItem As New DataTable
        Dim sql As String
        Dim i As Short
        Dim ans As String

        Me.lblItemPrevOrder.Visible = False
        Me.imgPrevOrdered.Visible = False

        If (dgvColorSize.CurrentCell.ColumnIndex = 0 Or dgvColorSize.CurrentCell.ColumnIndex = 1 Or dgvColorSize.CurrentCell.RowIndex = 0 Or dgvColorSize.CurrentCell.RowIndex = 1) Then
            Exit Sub
        End If

        If (Len(Trim(dgvColorSize.CurrentCell.Value)) > 0) Then
            For i = 1 To Len(Trim(dgvColorSize.CurrentCell.Value))
                If Asc(Mid(dgvColorSize.CurrentCell.Value, i, 1)) < 48 Or Asc(Mid(dgvColorSize.CurrentCell.Value, i, 1)) > 57 Then
                    dgvColorSize.Item(e.ColumnIndex, e.RowIndex).Value = ""
                    Exit Sub
                End If
            Next
            If CInt(dgvColorSize.CurrentCell.Value) > 999 Then
                ans = InputBox("Are your sure you want to order a quantity of " & CInt(dgvColorSize.CurrentCell.Value) & " for this item?" & vbCrLf & "If you do, type 'yes' in the space below.", "Add Items", "no")
                If ans = "no" Or ans = "" Then
                    dgvColorSize.CurrentCell.Value = ""
                    Exit Sub
                End If
            ElseIf CInt(dgvColorSize.CurrentCell.Value) <= 0 Then
                MsgBox("Item quantity must be greater than 0!", MsgBoxStyle.Critical, "Worksheet Items")
                dgvColorSize.CurrentCell.Value = ""
                Exit Sub
            End If
        End If

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        lblShipDates.Text = "This item ships between          and"
        lblItemPrice.Text = "Item Price: $0.00"

        con.ConnectionString = MySettings.Default("SaleForcConnectionString")
        con.Open()

        sql = "SELECT [deleted], [qtyordered], [price], [extended], [readyfororder] FROM WSItemTemp WHERE [itemno] = '" & Trim(txtStyle.Text) & color & tmpSize & "'"
        daWSTempItem = New OleDb.OleDbDataAdapter(sql, con)
        daWSTempItem.Fill(dtWSTempItem)

        sql = "SELECT [price1] FROM item WHERE [item] = '" & Trim(txtStyle.Text) & color & tmpSize & "'"
        daItem = New OleDb.OleDbDataAdapter(sql, con)
        daItem.Fill(dtItem)

        con.Close()

        If Len(Trim(dgvColorSize.CurrentCell.Value)) > 0 Then
            If tmpAttributed Then
                color = dgvColorSize.Item(0, e.RowIndex).Value
                tmpSize = dgvColorSize.Item(e.ColumnIndex, 0).Value
            End If

            Dim cb As New OleDb.OleDbCommandBuilder(daWSTempItem)

            If dtWSTempItem.Rows.Count <> 0 Then
                If dtWSTempItem.Rows(0)("deleted") = True Then
                    sql = "UPDATE [wsitemtemp] SET qtyordered = " & Trim(dgvColorSize.CurrentCell.Value) & ", extended = " & Trim(dgvColorSize.CurrentCell.Value) * dtItem.Rows(0)("price1") & ", price = " & dtItem.Rows(0)("price1") & ", deleted = false, readyfororder = true" & " WHERE [itemno] = '" & Trim(txtStyle.Text) & color & tmpSize & "'"
                ElseIf tmpQty <> CShort(dgvColorSize.CurrentCell.Value) Then
                    sql = "UPDATE [wsitemtemp] SET qtyordered = " & Trim(dgvColorSize.CurrentCell.Value) & ", extended = " & Trim(dgvColorSize.CurrentCell.Value) * dtWSTempItem.Rows(0)("price") & " WHERE [itemno] = '" & Trim(txtStyle.Text) & color & tmpSize & "'"
                End If
                Dim conn As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
                Dim com As New OleDb.OleDbCommand(sql, conn)
                conn.Open()
                com.ExecuteNonQuery()
                conn.Close()
            ElseIf dtWSTempItem.Rows.Count = 0 Then
                flagItemChgsMade = True
                nQtyOrdered = CShort(Trim(dgvColorSize.CurrentCell.Value))
                AddItemsToTable((Trim(txtStyle.Text) & color & tmpSize))
            End If
        Else
            If dtWSTempItem.Rows.Count <> 0 Then
                DeleteTmpItems(txtStyle.Text & color & tmpSize)
            End If
        End If
        UpdateStyleTotals()
        ReCalcTotals()

        Me.dgvTempItems.DataSource = Me.WSItemTempBindingSource
        Dim strCommand As String
        strCommand = Mid(WSItemTempTableAdapter.Adapter.SelectCommand.CommandText, 1, Len(WSItemTempTableAdapter.Adapter.SelectCommand.CommandText) - 1) & "'" & cCustWsNum & "'"
        GetData(strCommand)
        flagItemChgsMade = True
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    ''' <summary>
    ''' This procedure is used to mark the location of the current cell.  It changes the color of the row and column labels to more easily
    ''' identify what the user is ordering.  It also updates various control text to give item information to the user such as shipping
    ''' dates and quantities available.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub dgvColorSize_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvColorSize.CellEnter
        Dim con As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        Dim sql As String

        If (dgvColorSize.CurrentCell.ColumnIndex = 0 Or dgvColorSize.CurrentCell.ColumnIndex = 1 Or dgvColorSize.CurrentCell.RowIndex = 0 Or dgvColorSize.CurrentCell.RowIndex = 1) Then
            Exit Sub
        End If

        If e.ColumnIndex <> 0 And e.RowIndex <> 0 And e.ColumnIndex <> 1 And e.RowIndex <> 1 Then
            dgvColorSize.Item(e.ColumnIndex, 0).Style.BackColor = Drawing.Color.DodgerBlue
            dgvColorSize.Item(e.ColumnIndex, 1).Style.BackColor = Drawing.Color.DodgerBlue
            dgvColorSize.Item(0, e.RowIndex).Style.BackColor = Drawing.Color.DodgerBlue
            dgvColorSize.Item(1, e.RowIndex).Style.BackColor = Drawing.Color.DodgerBlue

            dgvColorSize.Item(e.ColumnIndex, 0).Style.ForeColor = Drawing.Color.White
            dgvColorSize.Item(e.ColumnIndex, 1).Style.ForeColor = Drawing.Color.White
            dgvColorSize.Item(0, e.RowIndex).Style.ForeColor = Drawing.Color.White
            dgvColorSize.Item(1, e.RowIndex).Style.ForeColor = Drawing.Color.White
        Else
            dgvColorSize.Item(e.ColumnIndex, 0).Style.BackColor = Drawing.Color.LightGray
            dgvColorSize.Item(e.ColumnIndex, 1).Style.BackColor = Drawing.Color.LightGray
            dgvColorSize.Item(0, e.RowIndex).Style.BackColor = Drawing.Color.LightGray
            dgvColorSize.Item(1, e.RowIndex).Style.BackColor = Drawing.Color.LightGray
            dgvColorSize.Item(e.ColumnIndex, 0).Style.ForeColor = Drawing.Color.Black
            dgvColorSize.Item(e.ColumnIndex, 1).Style.ForeColor = Drawing.Color.Black
            dgvColorSize.Item(0, e.RowIndex).Style.ForeColor = Drawing.Color.Black
            dgvColorSize.Item(1, e.RowIndex).Style.ForeColor = Drawing.Color.Black
        End If

        tmpQty = 0
        tmpSize = dgvColorSize.Item(e.ColumnIndex, 0).Value
        color = dgvColorSize.Item(0, e.RowIndex).Value
        If dgvColorSize.Text > "" Then
            Call CheckPrevOrder(Asc(CStr(CShort(dgvColorSize.Text))))
        End If

        con.ConnectionString = MySettings.Default("SaleForcConnectionString")
        con.Open()
        sql = "SELECT [Begin-ship-date], [End-ship-date], [Price1], [QtyPotential], [QtyToSell], [Qty-on-hand], CanBeOrdered FROM [item] WHERE item  = '" & Trim(txtStyle.Text) & color & tmpSize & "'"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(dt)

        If dt.Rows.Count <> 0 Then
            If dt.Rows(0)("canbeordered") = False Then
                lblShipDates.Text = "This item can not be ordered"
                lblItemPrice.Text = "Item Price: $0.00"
                lblQtyPotential.Text = ""
                lblQtyToSell.Text = ""
                lblQtyOnHand.Text = ""
                dgvColorSize.CurrentCell.Style.BackColor = Drawing.Color.LightGray
                dgvColorSize.RowsDefaultCellStyle.SelectionBackColor = Drawing.Color.LightGray
                dgvColorSize.CurrentCell.ReadOnly = True
            Else
                lblShipDates.Text = "This item ships between " & CStr(dt.Rows(0)("begin-ship-date").ToString) & " and " & CStr(dt.Rows(0)("end-ship-date").ToString)
                lblItemPrice.Text = "Item Price: " & Convert.ToDecimal(dt.Rows(0)("price1")).ToString("c")
                lblQtyPotential.Text = "Qty Potential: " & dt.Rows(0)("qtypotential").ToString
                lblQtyToSell.Text = "Qty To Sell: " & dt.Rows(0)("qtytosell").ToString
                lblQtyOnHand.Text = "Qty On Hand: " & dt.Rows(0)("qty-on-hand").ToString
                dgvColorSize.CurrentCell.Style.BackColor = Drawing.Color.White
                dgvColorSize.RowsDefaultCellStyle.SelectionBackColor = Drawing.Color.DodgerBlue
                dgvColorSize.CurrentCell.ReadOnly = False
            End If
        Else
            lblShipDates.Text = "This item was not found in the database"
            lblItemPrice.Text = "Item Price: $0.00"
            lblQtyPotential.Text = "Qty Potential: 0"
            lblQtyToSell.Text = "Qty To Sell: 0"
            lblQtyOnHand.Text = "Qty On Hand: 0"
            dgvColorSize.CurrentCell.Style.BackColor = Drawing.Color.LightGray
            dgvColorSize.CurrentCell.ReadOnly = True
        End If

        If Len(Trim(dgvColorSize.CurrentCell.Value)) > 0 And e.ColumnIndex <> 0 And e.ColumnIndex <> 1 And e.RowIndex <> 0 And e.RowIndex <> 1 Then
            tmpQty = CShort(Trim(dgvColorSize.CurrentCell.Value))
            tmpExtPrice = CDec(Trim(lblExtStylePrice.Text))
        End If

        If WSItemTempBindingSource.Count Then
            WSItemTempBindingSource.Position = WSItemTempBindingSource.Find("itemno", Trim(txtStyle.Text) & color & tmpSize)
        End If
        con.Close()
    End Sub

    ''' <summary>
    ''' This procedure is used to put the column and row colors back to the original color after the user leaves a cell
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub dgvcolorsize_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvColorSize.CellLeave
        If e.ColumnIndex <> 0 And e.ColumnIndex <> 1 And e.RowIndex <> 0 And e.RowIndex <> 1 Then
            dgvColorSize.Item(e.ColumnIndex, 0).Style.BackColor = Drawing.Color.LightGray
            dgvColorSize.Item(e.ColumnIndex, 1).Style.BackColor = Drawing.Color.LightGray
            dgvColorSize.Item(0, e.RowIndex).Style.BackColor = Drawing.Color.LightGray
            dgvColorSize.Item(1, e.RowIndex).Style.BackColor = Drawing.Color.LightGray
            dgvColorSize.Item(e.ColumnIndex, 0).Style.ForeColor = Drawing.Color.Black
            dgvColorSize.Item(e.ColumnIndex, 1).Style.ForeColor = Drawing.Color.Black
            dgvColorSize.Item(0, e.RowIndex).Style.ForeColor = Drawing.Color.Black
            dgvColorSize.Item(1, e.RowIndex).Style.ForeColor = Drawing.Color.Black
        End If
    End Sub

    ''' <summary>
    ''' This procedure verifies that the user is selecting a valid 'cancel by' date on the worksheet header
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub dtpCancelBy_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpCancelBy.ValueChanged
        If formLoaded Then
            If dtpCancelBy.Value < dtpDelvBy.Value Then
                Call MsgBox("Cancel By date must be greater than Start Shipping on Date " & dtpDelvBy.Value, MsgBoxStyle.Exclamation, "Cancel By Date")
                dtpCancelBy.Value = System.DateTime.FromOADate(Today.ToOADate + 1)
                dtpCancelBy.Focus()
            End If
            dtpDelvBy.MaxDate = dtpCancelBy.Value
            flagHeadChgsMade = True
        End If
    End Sub

    ''' <summary>
    ''' This procedure verifies that the user is selecting a valid 'deliver by' date on the worksheet header
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub dtpDelvBy_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpDelvBy.ValueChanged
        If formLoaded Then
            If dtpDelvBy.Value > dtpCancelBy.Value Then
                Call MsgBox("Start Shipping On date can not be greater than Cancel By date " & dtpCancelBy.Value.ToString, MsgBoxStyle.Exclamation, "Start Shipping on Date")
                dtpDelvBy.Value = dtpCancelBy.Value
                dtpDelvBy.Focus()
            End If
            dtpCancelBy.MinDate = dtpDelvBy.Value

            flagHeadChgsMade = True
        End If
    End Sub

    ''' <summary>
    ''' This procedure makes a call to email the worksheet
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub cmdEmailWorksheet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEmailWorksheet.Click
        Dim emailaddr As String = ""
        Dim daCustomer As New SaleForcDataSetTableAdapters.CustomerTableAdapter
        Dim dtCustomer As New SaleForcDataSet.CustomerDataTable
        Dim drCustomer As SaleForcDataSet.CustomerRow
        dtCustomer = daCustomer.GetDataByCustNo(cCustNo)
        drCustomer = dtCustomer.Rows(0)
        If IsDBNull(drCustomer.Email.ToString) Or drCustomer.Email.ToString = "" Or InStr(drCustomer.Email.ToString, "@") = 0 Then
            emailaddr = cSalesmanEmail
        Else
            emailaddr = drCustomer.Email.ToString
        End If
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Call EmailWorksheets(cWorkShtNo, emailaddr)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    'Private Sub dgvColorSize_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvColorSize.CurrentCellChanged

    '    Select Case lastkey
    '        Case Keys.Up
    '            If dgvColorSize.CurrentCell.RowIndex > 1 Then
    '                dgvColorSize.CurrentCell = dgvColorSize(dgvColorSize.CurrentCell.ColumnIndex, dgvColorSize.CurrentCell.RowIndex - 1)
    '            Else
    '                dgvColorSize.CurrentCell = dgvColorSize(dgvColorSize.CurrentCell.ColumnIndex, dgvColorSize.Rows.Count - 1)
    '            End If
    '        Case Keys.Down
    '            If dgvColorSize.CurrentCell.RowIndex + 1 < dgvColorSize.Rows.Count Then
    '                dgvColorSize.CurrentCell = dgvColorSize(dgvColorSize.CurrentCell.ColumnIndex, dgvColorSize.CurrentCell.RowIndex + 1)
    '            Else
    '                dgvColorSize.CurrentCell = dgvColorSize(dgvColorSize.CurrentCell.ColumnIndex, 2)
    '            End If
    '        Case Keys.Left
    '            If dgvColorSize.CurrentCell.ColumnIndex > 2 Then
    '                dgvColorSize.CurrentCell = dgvColorSize(dgvColorSize.CurrentCell.ColumnIndex - 1, dgvColorSize.CurrentCell.RowIndex)
    '            ElseIf dgvColorSize.CurrentCell.ColumnIndex = 2 And dgvColorSize.CurrentCell.RowIndex = 2 Then
    '                dgvColorSize.CurrentCell = dgvColorSize(dgvColorSize.CurrentCell.ColumnIndex - 1, dgvColorSize.CurrentCell.RowIndex)
    '            Else
    '                dgvColorSize.CurrentCell = dgvColorSize(dgvColorSize.Columns.Count - 1, dgvColorSize.CurrentCell.RowIndex - 1)
    '            End If
    '        Case Keys.Right
    '            If dgvColorSize.CurrentCell.ColumnIndex + 1 < dgvColorSize.Columns.Count Then
    '                dgvColorSize.CurrentCell = dgvColorSize(dgvColorSize.CurrentCell.ColumnIndex + 1, dgvColorSize.CurrentCell.RowIndex)
    '            ElseIf dgvColorSize.CurrentCell.ColumnIndex = dgvColorSize.Columns.Count - 1 And dgvColorSize.CurrentCell.RowIndex = dgvColorSize.Rows.Count - 1 Then
    '                dgvColorSize.CurrentCell = dgvColorSize(2, 2)
    '            Else
    '                If dgvColorSize.CurrentCell.RowIndex < dgvColorSize.Rows.Count - 1 Then
    '                    dgvColorSize.CurrentCell = dgvColorSize(2, dgvColorSize.CurrentCell.RowIndex + 1)
    '                End If
    '            End If
    '        Case Keys.Return
    '            If dgvColorSize.CurrentCell.ColumnIndex + 1 < dgvColorSize.Columns.Count Then
    '                dgvColorSize.CurrentCell = dgvColorSize(dgvColorSize.CurrentCell.ColumnIndex + 1, dgvColorSize.CurrentCell.RowIndex)
    '            Else
    '                If dgvColorSize.CurrentCell.RowIndex < dgvColorSize.Rows.Count - 1 Then
    '                    dgvColorSize.CurrentCell = dgvColorSize(2, dgvColorSize.CurrentCell.RowIndex + 1)
    '                Else
    '                    dgvcolorsize_CellLeave(Nothing, Nothing)
    '                    dgvColorSize_CellEnter(Nothing, Nothing)
    '                    If dgvColorSize.CurrentCell.RowIndex + 1 = dgvColorSize.Rows.Count And dgvColorSize.CurrentCell.ColumnIndex + 1 = dgvColorSize.Columns.Count Then
    '                        dgvColorSize.CurrentCell = dgvColorSize(2, 2)
    '                    End If
    '                End If
    '            End If
    '        Case Keys.Tab
    '            If dgvColorSize.CurrentCell.ColumnIndex + 1 < dgvColorSize.Columns.Count Then
    '                dgvColorSize.CurrentCell = dgvColorSize(dgvColorSize.CurrentCell.ColumnIndex + 1, dgvColorSize.CurrentCell.RowIndex)
    '            Else
    '                If dgvColorSize.CurrentCell.RowIndex < dgvColorSize.Rows.Count - 1 Then
    '                    dgvColorSize.CurrentCell = dgvColorSize(1, dgvColorSize.CurrentCell.RowIndex + 1)
    '                End If
    '            End If
    '    End Select
    'End Sub

    'Private Sub dgvColorSize_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvColorSize.KeyDown
    '    lastkey = e.KeyCode
    'End Sub

    'Private Sub dgvColorSize_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvColorSize.KeyUp
    '    lastkey = e.KeyCode
    'End Sub

    ''' <summary>
    ''' This procedure is currently not being used. However, it is to prevent a user from checking a checkbox.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub SuppressClicks(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOrderComplete.CheckedChanged

        Static Blocked As Boolean = True

        If DirectCast(sender, System.Windows.Forms.CheckBox).Tag = "disable" Then
            Blocked = Not Blocked
            If Not Blocked Then sender.checked = Not sender.checked
        End If

    End Sub

    'Private Sub chkReadyToXmit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkReadyToXmit.CheckedChanged
    '    flagHeadChgsMade = True
    'End Sub

    'Private Sub chkCancel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCancel.CheckedChanged
    '    flagHeadChgsMade = True
    'End Sub

    'Private Sub dgvColorSize_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvColorSize.EditingControlShowing
    '    RemoveHandler DirectCast(e.Control, TextBox).KeyDown, AddressOf CellKeyDown
    '    If (dgvColorSize.CurrentCell.ColumnIndex >= 2) AndAlso TypeOf e.Control Is TextBox Then
    '        AddHandler DirectCast(e.Control, TextBox).KeyDown, AddressOf CellKeyDown
    '    End If
    'End Sub

    'Private Sub CellKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    'If e.KeyCode = Keys.Enter Then dgvColorSize.CurrentCell = dgvColorSize(dgvColorSize.CurrentCell.RowIndex, dgvColorSize.CurrentCell.ColumnIndex + 1)
    '    Debug.Print(e.KeyCode)
    'End Sub

    ''' <summary>
    ''' This procedure will display the data for the item selected in the inventory screen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub dgvColorSize_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvColorSize.CellMouseDoubleClick
        If Len(Trim(txtStyle.Text)) > 0 Then
            CameFromWorksheetForm = True
            CurrWorksheetItem = txtStyle.Text
            frmInventory.Show()
        Else
            MsgBox("No style available to view inventory for.  Please enter a valid style.", MsgBoxStyle.Exclamation, "View Inventory")
            Exit Sub
        End If
    End Sub

    ''' <summary>
    ''' This procedure will clear the 'item ordering' screen by simulating a click of the 'Next Style' button if the user deletes the 
    ''' text out of the 'style' box.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub txtStyle_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStyle.KeyUp
        If Len(Trim(txtStyle.Text)) = 0 Then
            cmdNextStyle_Click(Nothing, Nothing)
        End If
    End Sub
End Class