Option Strict Off
Option Explicit On
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Runtime.InteropServices
Imports System.Management

Friend Class frmCustInfo
    Inherits System.Windows.Forms.Form

    Dim dvCustomers As DataView
    Dim SearchIndex As String ' Holds the index name
    Dim SearchString As String ' Holds the search for name
    Dim cFlagCustStatus As String 'Customer status flag
    Dim cFlagShipStatus As String 'Customer shipping status flag
    Dim flagAddNewCust As Boolean
    Dim flagEditNewCust As Boolean
    Dim flagCmdFinished As Boolean ' exit enter new customer or edit new customer
    Dim lFlagNewLoad As Boolean ' use as a new load indicator
    Dim cTmpCustID As String
    Dim cTmpCustName As String
    Dim current_tab As Short
    Dim dbgrid1sorttype As Boolean
    Dim dbgrid2sorttype As Boolean
    Dim tmpSSeason1yrago As String ' used for history graph on asr tab
    Dim tmpOSeason2yrsago As String ' used for history graph on asr tab
    Dim tmpOSeason3yrsago As String ' used for history graph on asr tab
    Dim formloaded As Boolean
    Dim dataadapter As New OleDb.OleDbDataAdapter
    Dim commandbuilder As OleDb.OleDbCommandBuilder = New OleDb.OleDbCommandBuilder(dataadapter)
    Dim lastcellvalue As String

    ''' <summary>
    ''' This procedure will exit the customer information screen and open up another screen depending on the value of the 'fromLocation'
    ''' variable.
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub btnExitCustInfo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnExitCustInfo.Click
        If fromLocation = "CustList" Then
            fromLocation = vbNullString
            Me.Close()
            frmCustList.Show()
        ElseIf fromLocation = "ErrList" Then
            fromLocation = vbNullString
            Me.Close()
            frmErrMsgList.Show()
        ElseIf fromLocation = "OrdList" Then
            fromLocation = vbNullString
            Me.Close()
        ElseIf fromLocation = "WsList" Then
            fromLocation = vbNullString
            Me.Close()
            frmListWs.Show()
        ElseIf fromLocation = "XmitNoVal" Then
            fromLocation = vbNullString
            Me.Close()
            frmXmitButNoVal.ShowDialog()
        ElseIf fromLocation = "XmitNotOrder" Then
            fromLocation = vbNullString
            Me.Close()
            frmXmitButNotOnOrder.ShowDialog()
        Else
            Me.Close()
        End If
        If WebBrowser2.Visible = True Then WebBrowser2.Visible = False
    End Sub

    ''' <summary>
    ''' This procedure will attemp to find a customer number based on user input
    ''' </summary>
    ''' <remarks>The users attempts to find a customer based on customer number or name.  If the procedure finds a customer then
    ''' it will enable the First,Last,Next,Previous buttons to allow for customer navigation</remarks>

    Private Sub FindCustomer()
        If Len(txtCustID.Text) > 0 Or Len(cmbAutoCompleteCustName.Text) > 0 Then
            cTmpCustID = txtCustID.Text
            cTmpCustName = cmbAutoCompleteCustName.Text

            If Len(Trim(txtCustID.Text)) > 0 Then
                SearchIndex = "CustNumber"
                SearchString = txtCustID.Text
            ElseIf Len(Trim(cmbAutoCompleteCustName.Text)) > 0 Then
                SearchIndex = "CustName"
                SearchString = cmbAutoCompleteCustName.Text
            Else
                'txtCustID.Text = cTmpCustID
                'cmbAutoCompleteCustName.Text = cTmpCustName
                Exit Sub
            End If

            FindCust(SearchIndex, SearchString)
            btnExitCustInfo.Enabled = True

            If bndCustomer.Count > 0 Then
                cmdCustomerUpdate.Enabled = True
                cmdCustShipUpdate.Enabled = True
                cmdFirst.Enabled = True
                cmdPrevious.Enabled = True
                cmdNext.Enabled = True
                cmdLast.Enabled = True
                cmdNewCust.Enabled = True

                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                dblShipNoList.Focus()
                If Len(Trim(dblShipNoList.Text)) = 0 Then
                    System.Windows.Forms.SendKeys.SendWait("{down}")
                End If
                btnExitCustInfo.Focus()
                txtCustID.Enabled = True
            End If
        End If
    End Sub

    ''' <summary>
    ''' This procedure will find a customer in the customer table and fill the associated fields on the customer information screen
    ''' </summary>
    ''' <param name="cNdx">This tells the procedure to find a customer based on either number or name</param>
    ''' <param name="cSrchStrg">This is the string to search for in the customer table</param>
    ''' <returns>A boolean indicating that the procedure found a customer (true) or didn't find a customer (false) </returns>
    ''' <remarks></remarks>

    Private Function FindCust(ByRef cNdx As String, ByVal cSrchStrg As String) As Boolean
        Dim foundrow As Integer
        Dim foundrow1 As Integer

        Me.CustomerTableAdapter.Fill(Me.SaleForcDataSet.Customer)
        Me.CustomerSHTableAdapter.Fill(Me.SaleForcDataSet.CustomerSH)
        If cNdx = "CustName" Then
            foundrow = Me.bndCustomer.Find("name", cSrchStrg)
            foundrow1 = Me.bndCustomerShip.Find("name", cSrchStrg)
        ElseIf cNdx = "CustNumber" Then
            If cNewCustNo > "" Then
                foundrow = Me.bndCustomer.Find("cust-no", cSrchStrg)
                foundrow1 = Me.bndCustomerShip.Find("cust-no", cSrchStrg)
                'GetCustomerData(CustomerTableAdapter.Adapter.SelectCommand.CommandText)
                'GetCustomerShData(CustomerSHTableAdapter.Adapter.SelectCommand.CommandText)
            End If
            foundrow = Me.bndCustomer.Find("cust-no", cSrchStrg)
            foundrow1 = Me.bndCustomerShip.Find("cust-no", cSrchStrg)
        End If
        If foundrow <> -1 Then
            bndCustomer.Position = foundrow 'moves the record cursor to the record found in the table and will fill the bound controls on the screen
            bndCustomerShip.Position = foundrow1
            cmbAutoCompleteCustName.ResetText()
            FindCust = True
            UpdateCustShipInfo()
        Else
            Me.SaleForcDataSet.Customer.Clear()
            Me.SaleForcDataSet.CustomerSH.Clear()
            MsgBox("Customer not found or is inactive", MsgBoxStyle.Exclamation, "Find Customer")
            FillCustomerComboBox()
            If optFindByCustName.Checked = True Then
                Me.cmbAutoCompleteCustName.Focus()
            Else
                Me.txtCustID.Focus()
            End If
        End If
    End Function

    ''' <summary>
    ''' This procedure will change the record filter on the Worksheets table 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks>If the chkNoOrderWs checkbox is checked, this procedure filters the worksheets grid and will not show worksheets that are orders
    ''' else if unchecked it removes the filter</remarks>

    Private Sub chkNoOrderWs_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkNoOrderWs.CheckStateChanged
        If chkNoOrderWs.Checked Then
            Me.bndWorksheets.Filter = "[order-no] = 0 "
        Else
            Me.bndWorksheets.Filter = ""
        End If
    End Sub

    ''' <summary>
    ''' This procedure will change the record filter on the Customer table
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks>If the chkViewActiveCust checkbox is check, this procedure filters the customers table and will only show customers
    ''' whose status is set to 'P' (permanent).  If unchecked, all customers will be accessible to view</remarks>

    Private Sub chkViewActiveCust_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkViewActiveCust.CheckStateChanged
        If chkViewActiveCust.CheckState = System.Windows.Forms.CheckState.Checked Then
            Me.bndCustomer.Filter = "[status-code] = '" & "P" & "'"
            If Me.optFindByCustName.Checked = True Then
                Me.bndCustomer.Sort = "Name"
            ElseIf optFindByCustNumber.Checked = True Then
                Me.bndCustomer.Sort = "Cust-no"
            End If
        ElseIf chkViewActiveCust.CheckState = System.Windows.Forms.CheckState.Unchecked Then
            Me.bndCustomer.Filter = "[status-code] Is Not Null"
            If optFindByCustName.Checked = True Then
                Me.bndCustomer.Sort = "Name"
            ElseIf optFindByCustNumber.Checked = True Then
                Me.bndCustomer.Sort = "Cust-no"
            End If
        End If
        If formloaded Then
            clrCustFields()
            clrShipFields()
            FindCustomer()
            FillCustomerComboBox()
        End If
    End Sub

    ''' <summary>
    ''' This procedure will change which 'ASR' screen is visible on the 'ASR' tab and loads the appropriate data.
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmbASRView_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbASRView.SelectedIndexChanged
        Dim cn As New OleDb.OleDbConnection
        Dim da2 As OleDb.OleDbDataAdapter
        Dim dasalesman As New SaleForcDataSetTableAdapters.SalesmanTableAdapter
        Dim dtSalesman As SaleForcDataSet.SalesmanDataTable
        Dim dtSeason As New DataTable
        Dim tmpSSeason1yearago As String

        dtSalesman = dasalesman.GetData

        optSpring.Visible = False
        optFall.Visible = False
        cmdPrintGraphs.Visible = False

        If Me.lblName.Text > "" Then
            Select Case cmbASRView.Text
                Case "ASR Report"
                    pnlASR.BringToFront()
                    Call CreateASRGrid(dgvASR)
                    Call LoadASRGrid()
                Case "Notes"
                    pnlNotes.BringToFront()

                    Me.NotesCommentsTableAdapter.FillByCustnoSeason(Me.SaleForcDataSet.NotesComments, bndCustomer.Current("cust-no"), dtSalesman.Rows(0)("season"))
                    'Me.dtpNotesFollowup.Value = Now.ToShortDateString
                    Me.dtpNotesFollowup.Refresh()
                    Call CreateASRGrid(dgvNotes)
                    Call LoadNotesGrid(dgvNotes)
                Case "Pass"
                    pnlPass.BringToFront()
                    Call CreateASRGrid(dgvPass)
                    Call LoadNotesGrid(dgvPass)
                Case "History"
                    pnlHistory.BringToFront()
                    Call CreateASRGrid(dgvHistory)
                    LoadHistoryGrid()
                Case "History Graph"
                    pnlHistoryGraphs.BringToFront()
                    cn.ConnectionString = MySettings.Default("SaleForcConnectionString")
                    cn.Open()
                    da2 = New OleDb.OleDbDataAdapter("SELECT [seasontype] FROM Season WHERE [season] = '" & dtSalesman.Rows(0)("season") & "'", cn)
                    da2.Fill(dtSeason)

                    optSpring.Checked = False
                    optFall.Checked = False
                    optSpring.Visible = True
                    optFall.Visible = True
                    cmdPrintGraphs.Visible = True
                    If dtSeason.Rows.Count = 0 Then
                        MessageBox.Show("Season '" & dtSalesman.Rows(0)("season") & "' doesn't exist - contact Sales Support!", "Season doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                    tmpSSeason1yearago = GetSeason(dtSalesman.Rows(0)("season"), 1, dtSeason.Rows(0)("seasontype"))
                    ' this will call the CreateHistoryGraphs routine
                    If dtSeason.Rows(0)("seasontype") = "S" Then
                        optSpring.Checked = True
                    Else
                        optFall.Checked = True
                    End If
                    cn.Close()
            End Select
        End If
    End Sub

    ''' <summary>
    ''' This procedure will load a customer's webpage (if the customer has a webpage)
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmbCustomerWebsites_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbCustomerWebsites.SelectedIndexChanged
        WebBrowser1.Visible = True
        WebBrowser1.Navigate("http://" & cmbCustomerWebsites.Text)
    End Sub

    ''' <summary>
    ''' This procedure will display the Customer Update screen
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks>The procedure opens the Customer Update screen to allow the user to make changes to the Customer's information</remarks>

    Private Sub cmdCustomerUpdate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCustomerUpdate.Click
        cCustNumber = txtCustNo.Text
        frmCustomerUpdate.Show()
        frmCustomerUpdate.Show()
    End Sub

    ''' <summary>
    ''' This procedure will open the Customer Ship To Update screen
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks>The procedure opens the Customer SHip To Update screen to allow the user to make changes to the Customer's Ship To information</remarks>

    Private Sub cmdCustShipUpdate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCustShipUpdate.Click
        frmCustShipUpdate.Show()
    End Sub

    ''' <summary>
    ''' This procedure will delete an appointment item in the user's Microsoft Office Outlook calendar
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks>When the user clicks on the cmdDeleteAppoinment button, this procedure will search for the first appointment item in 
    ''' Microsoft Office Outlook that match the item clicked on and delete it from Outlook</remarks>

    Private Sub cmdDeleteAppointment_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDeleteAppointment.Click
        Dim OutlookApp As Microsoft.Office.Interop.Outlook.Application
        Dim OutlookNameSpace As Microsoft.Office.Interop.Outlook.NameSpace
        OutlookApp = New Microsoft.Office.Interop.Outlook.Application
        OutlookNameSpace = OutlookApp.GetNamespace("MAPI")
        Dim calendaritem As Microsoft.Office.Interop.Outlook.AppointmentItem
        Dim calendar As Microsoft.Office.Interop.Outlook.MAPIFolder

        calendar = OutlookNameSpace.GetDefaultFolder(Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderCalendar)
        Dim i As Integer
        If dgvCustomerAppointments.Rows.Count = 0 Then
            MsgBox("There are no appointments for this Customer!", MsgBoxStyle.Critical, "Delete Customer Appointment")
            Exit Sub
        End If

        i = dgvCustomerAppointments.CurrentRow.Index
        For Each calendaritem In calendar.Items
            If calendaritem.BillingInformation = bndCustomer.Current("cust-no") And (calendaritem.Start = dgvCustomerAppointments.Item(2, i).Value) And (calendaritem.End = dgvCustomerAppointments.Item(3, i).Value) And (calendaritem.Subject = dgvCustomerAppointments.Item(0, i).Value) Then
                calendaritem.Delete()
                Exit For
            End If
        Next

        'Do While OutlookApp.Inspectors.Count > 0
        '    'just hang out until the appointment window is closed.
        '    Me.SendToBack()
        'Loop

        Dim dt As New DataTable
        Dim dr As DataRow
        dt.Columns.Add("Subject", Type.GetType("System.String"))
        dt.Columns.Add("Location", Type.GetType("System.String"))
        dt.Columns.Add("Start", Type.GetType("System.DateTime"))
        dt.Columns.Add("End", Type.GetType("System.DateTime"))
        For Each calendaritem In calendar.Items
            If calendaritem.BillingInformation = bndCustomer.Current("cust-no") Then
                dr = dt.NewRow
                dr("Subject") = calendaritem.Subject
                dr("Location") = calendaritem.Location
                dr("Start") = calendaritem.Start
                dr("End") = calendaritem.End
                dt.Rows.Add(dr)
            End If
        Next
        If dt.Rows.Count = 0 Then
            dgvCustomerAppointments.Visible = False
            lblNoAppts.Visible = True
            lblNoAppts.Text = "No appointments scheduled for " & bndCustomer.Current("Name")
        Else
            dgvCustomerAppointments.DataSource = dt
            lblNoAppts.Visible = False
            dt.DefaultView.Sort = "Start ASC"
            dgvCustomerAppointments.Visible = True
            dgvCustomerAppointments.AutoResizeColumn(0, DataGridViewAutoSizeColumnMode.AllCells)
            dgvCustomerAppointments.AutoResizeColumn(1, DataGridViewAutoSizeColumnMode.AllCells)
            dgvCustomerAppointments.AutoResizeColumn(2, DataGridViewAutoSizeColumnMode.AllCells)
            dgvCustomerAppointments.AutoResizeColumn(3, DataGridViewAutoSizeColumnMode.AllCells)
        End If
        OutlookNameSpace.Logoff()
        'OutlookApp.Quit()
        System.Threading.Thread.Sleep(100)
        Me.BringToFront()
    End Sub

    ''' <summary>
    ''' This procedure creates an Excel spreadsheet for emailing 'ASR' information
    ''' </summary>
    ''' <param name="tmpDataGrid"></param>
    ''' <remarks>When the user wants to print or email 'ASR' information this procedure creates a spreadsheet with the 'ASR' row and
    ''' column header information </remarks>

    Private Sub CreateASRSpreadsheet(ByRef tmpDataGrid As DataGridView)
        Dim i As Short
        ' Procedure to kill a process by username
        'Dim query As SelectQuery = New SelectQuery("Win32_Process")
        'Dim mgmtSearcher As ManagementObjectSearcher = New ManagementObjectSearcher(query)

        'For Each p As ManagementObject In mgmtSearcher.Get()
        '    Dim s(10) As String
        '    p.InvokeMethod("GetOwner", DirectCast(s, Object()))
        ''    Debug.Print("Name: " & p("Name").ToString() & Environment.NewLine & _
        ''        "Parent Process ID: " & p("ParentProcessId").ToString() & Environment.NewLine & _
        ''        "Process ID: " & p("ProcessId").ToString() & Environment.NewLine & _
        ''        "Handle: " & p("Handle").ToString() & Environment.NewLine & _
        ''        "CS Name: " & p("CSName").ToString() & Environment.NewLine & _
        ''        "Session ID: " & p("SessionId").ToString() & Environment.NewLine & _
        ''        "User: " & s(1) & "\" & s(0))
        '    If p("Name").ToString() = "EXCEL.EXE" AndAlso s(0).ToString() = Environment.GetEnvironmentVariable("username") Then
        '        For Each prop As PropertyData In p.Properties
        '            Console.WriteLine("{0} - {1}", prop.Name, prop.Value)
        '        Next
        '        p.InvokeMethod("Terminate", Nothing)
        '    End If

        'Next

        Dim xl As New Microsoft.Office.Interop.Excel.Application
        Dim xlwbooks As Microsoft.Office.Interop.Excel.Workbooks
        Dim xlwbook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlsheet As Microsoft.Office.Interop.Excel.Worksheet

        Dim tmpProdType As String
        Dim strCol4Head As String
        Dim strCol6Head As String
        Dim tmpOppSeasonType As String
        Dim tmpSSeason1yrago As String
        Dim tmpOSeason1yrago As String
        Dim tmpOSeason2yrsago As String

        Dim cn As New OleDb.OleDbConnection
        Dim daProdType As OleDb.OleDbDataAdapter
        Dim daSalesman As OleDb.OleDbDataAdapter
        Dim daSeason As OleDb.OleDbDataAdapter

        Dim dtProdType As New DataTable
        Dim dtSalesman As New DataTable
        Dim dtSeason As New DataTable

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        cn.ConnectionString = MySettings.Default("SaleForcConnectionString")
        cn.Open()

        ''delete old ASR temp file

        Select Case xl.Version
            Case "15.0", "14.0", "13.0", "12.0"
                If Dir(GetProgramDefaults("TempFilePath") & "ASR.xlsx") > "" Then Kill(GetProgramDefaults("TempFilePath") & "ASR.xlsx")
            Case "11.0"
                If Dir(GetProgramDefaults("TempFilePath") & "ASR.xls") > "" Then Kill(GetProgramDefaults("TempFilePath") & "ASR.xls")
        End Select

        xlwbooks = xl.Workbooks
        xlwbook = xlwbooks.Add
        xlsheet = xlwbook.ActiveSheet


        ' Get current season
        daSalesman = New OleDb.OleDbDataAdapter("SELECT [season] FROM [salesman]", cn)
        daSalesman.Fill(dtSalesman)

        ' Get Prod Types with projections for the current customer and season
        daProdType = New OleDb.OleDbDataAdapter("SELECT DISTINCTROW ProdType.Description, ProdType.ProdType FROM ProdType LEFT JOIN [Cust-seas-proj] ON ProdType.ProdType = [Cust-seas-proj].prodtype " & "WHERE (((ProdType.[disp-seq])>0)) OR ((([Cust-seas-proj].[cust-no])=" & Chr(39) & Me.txtCustNo.Text & Chr(39) & ") AND (([Cust-seas-proj].season)='" & dtSalesman.Rows(0)("season") & "')) ORDER BY ProdType.[disp-seq];", cn)
        daProdType.Fill(dtProdType)

        ' Get season type for current season
        daSeason = New OleDb.OleDbDataAdapter("SELECT [seasontype] FROM Season WHERE [season].[season] = '" & dtSalesman.Rows(0)("season") & "'", cn)
        daSeason.Fill(dtSeason)

        tmpOppSeasonType = GetProgramDefaults(dtSeason.Rows(0)("seasontype"))

        tmpSSeason1yrago = GetSeason(dtSalesman.Rows(0)("season"), 1, dtSeason.Rows(0)("seasontype"))
        tmpOSeason1yrago = GetSeason(dtSalesman.Rows(0)("season"), 1, tmpOppSeasonType)
        tmpOSeason2yrsago = GetSeason(dtSalesman.Rows(0)("season"), 2, tmpOppSeasonType)

        xlsheet.Cells.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium

        ' Setup column labels

        If tmpDataGrid.Name = "dgvASR" Then
            'For i = 0 To dgvASR.RowCount - 2
            '    For j = 0 To dgvASR.ColumnCount - 1
            '        For k As Integer = 1 To dgvASR.Columns.Count
            '            xlsheet.Cells(1, k) = dgvASR.Columns(k - 1).HeaderText
            '            xlsheet.Cells(i + 2, j + 1) = dgvASR(j, i).Value
            '        Next
            '    Next
            'Next
            strCol4Head = UCase(dtSalesman.Rows(0)("season")) & " Actual - " & vbLf & UCase(dtSalesman.Rows(0)("season")) & " Goals"
            strCol6Head = UCase(dtSalesman.Rows(0)("season")) & " Actual - " & vbLf & UCase(tmpSSeason1yrago) & " Actual"
            xlsheet.Cells(1, 3).value = UCase(dtSalesman.Rows(0)("season").ToString) & " Goals"
            xlsheet.Cells(1, 4).value = UCase(dtSalesman.Rows(0)("season").ToString) & " Actual"
            xlsheet.Cells(1, 5).value = Trim(strCol4Head)
            xlsheet.Cells(1, 6).value = UCase(tmpSSeason1yrago) & " Actual"
            xlsheet.Cells(1, 7).value = Trim(strCol6Head)
            xlsheet.Cells(1, 8).value = "Comments"
            xlsheet.Rows(1).RowHeight = 70
            xlsheet.PageSetup.PrintArea = "$B$1:$H$" & dtProdType.Rows.Count
        ElseIf tmpDataGrid.Name = "dgvNotes" Then
            xlsheet.Cells.Columns("B").WrapText = True
            xlsheet.Cells.Columns("D").WrapText = True
            xlsheet.Cells.Columns("B").ColumnWidth = 20
            xlsheet.Cells.Columns("C").ColumnWidth = 10
            xlsheet.Cells.Columns("D").ColumnWidth = 60
            xlsheet.Cells(1, 3) = UCase(dtSalesman.Rows(0)("season")) & " Goals"
            xlsheet.Cells(1, 4) = "Styles Notes Taken On"
            xlsheet.PageSetup.PrintArea = "$B$1:$D$" & dtProdType.Rows.Count
        ElseIf tmpDataGrid.Name = "dgvPass" Then
            xlsheet.Cells.Columns("D").WrapText = True
            xlsheet.Cells.Columns("B").ColumnWidth = 20
            xlsheet.Cells.Columns("C").ColumnWidth = 10
            xlsheet.Cells.Columns("D").ColumnWidth = 60
            xlsheet.Cells(1, 3).value = UCase(dtSalesman.Rows(0)("season").ToString) & " Goals"
            xlsheet.Cells(1, 4).value = "Comments"
            xlsheet.PageSetup.PrintArea = "$B$1:$D$" & dtProdType.Rows.Count
        ElseIf tmpDataGrid.Name = "dgvHistory" Then
            xlsheet.Cells.Columns("B").ColumnWidth = 20
            xlsheet.Cells(1, 3).value = UCase(dtSalesman.Rows(0)("season").ToString) & " Goals"
            xlsheet.Cells(1, 4).value = UCase(dtSalesman.Rows(0)("season").ToString) & " Actual"
            xlsheet.Cells(1, 5).value = UCase(tmpSSeason1yrago) & " Actual"
            xlsheet.Cells(1, 6).value = UCase(tmpOSeason1yrago) & " Actual"
            xlsheet.Cells(1, 7).value = UCase(tmpOSeason2yrsago) & " Actual"
            xlsheet.Cells.Columns("B:G").AutoFit()
            xlsheet.PageSetup.PrintArea = "$B$1:$G$" & dtProdType.Rows.Count
        End If

        ' Setup row labels

        For i = 0 To dtProdType.Rows.Count - 1
            xlsheet.Cells(i + 2, 1) = dtProdType.Rows(i)("ProdType")
            tmpProdType = Proper(dtProdType.Rows(i)("Description"))
            xlsheet.Cells(i + 2, 2) = tmpProdType
        Next

        ' Color the row and column label cells

        If tmpDataGrid.Name = "dgvASR" Then
            xlsheet.Range("a1", "h1").Interior.ColorIndex = 15
        ElseIf tmpDataGrid.Name = "dgvNotes" Or tmpDataGrid.Name = "dgvPass" Then
            xlsheet.Range("a1", "d1").Interior.ColorIndex = 15
        ElseIf tmpDataGrid.Name = "dgvHistory" Then
            xlsheet.Range("a1", "g1").Interior.ColorIndex = 15
        End If

        xlsheet.Range("a1", "a" & CStr(dtProdType.Rows.Count + 1)).Interior.ColorIndex = 15
        xlsheet.Range("b2", "b" & CStr(dtProdType.Rows.Count + 1)).Interior.ColorIndex = 15


        cn.Close()
        cn.Dispose()

        Select Case xl.Version
            Case "15.0", "14.0", "13.0", "12.0"
                xl.ActiveWorkbook.Close(True, GetProgramDefaults("TempFilePath") & "ASR.xlsx")
            Case "11.0"
                xl.ActiveWorkbook.Close(True, GetProgramDefaults("TempFilePath") & "ASR.xls")
        End Select
        xl.Quit()

        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlsheet)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlwbook)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlwbooks)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(xl)
        xlsheet = Nothing
        xlwbook = Nothing
        xlwbooks = Nothing
        xl = Nothing
        Me.Cursor = System.Windows.Forms.Cursors.Default

        Call LoadASRSpreadsheetData(tmpDataGrid)
    End Sub

    ''' <summary>
    ''' This procedure will email 'ASR' information and print history
    ''' </summary>
    ''' <param name="tmpFlexGrid"></param>
    ''' <remarks>This procedures gets the data for the 'ASR' based on the header information.  For example, the program will find the data
    ''' for product type 'St Croix' and 'Spring 2012' and put it into the appropriate cell in the spreadsheet</remarks>

    Private Sub LoadASRSpreadsheetData(ByRef tmpFlexGrid As DataGridView)
        Dim cn As New OleDb.OleDbConnection
        Dim daCustStatus As OleDb.OleDbDataAdapter
        Dim daGoalsUnits As OleDb.OleDbDataAdapter
        Dim daSalesman As OleDb.OleDbDataAdapter
        Dim daSeason As OleDb.OleDbDataAdapter
        Dim daSeasonGoals As OleDb.OleDbDataAdapter
        Dim daProdType As OleDb.OleDbDataAdapter
        Dim dtCustStatus As New DataTable
        Dim dtGoalsUnits As New DataTable
        Dim dtSalesman As New DataTable
        Dim dtSeason As New DataTable
        Dim dtSeasonGoals As New DataTable
        Dim dtProdType As New DataTable
        Dim daNotesComments As OleDb.OleDbDataAdapter
        Dim dtNotesComments As New DataTable
        Dim i As Short
        Dim xl As New Microsoft.Office.Interop.Excel.Application
        Dim xlwbook As Microsoft.Office.Interop.Excel.Workbook = xl.Workbooks.Add
        Dim xlsheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim tmpOppSeasonType As String
        Dim tmpSSeason1yrago As String
        Dim tmpOSeason1yrago As String
        Dim tmpOSeason2yrsago As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        cn.ConnectionString = MySettings.Default("SaleForcConnectionString")
        cn.Open()
        Select Case xl.Version
            Case "15.0", "14.0", "13.0", "12.0"
                xl.DisplayAlerts = False
                xlwbook.SaveAs(GetProgramDefaults("TempFilePath") & "ASR.xlsx")
                xlwbook = xl.Workbooks.Open(GetProgramDefaults("TempFilePath") & "ASR.xlsx")
            Case "11.0"
                xlwbook = xl.Workbooks.Open(GetProgramDefaults("TempFilePath") & "ASR.xls")
        End Select
        xlsheet = xlwbook.Sheets("Sheet1")
        xlsheet.Activate()

        daSalesman = New OleDb.OleDbDataAdapter("SELECT [season] FROM [salesman]", cn)
        daSalesman.Fill(dtSalesman)

        daSeason = New OleDb.OleDbDataAdapter("SELECT [seasontype] FROM Season WHERE [season].[season] = '" & dtSalesman.Rows(0)("season") & "'", cn)
        daSeason.Fill(dtSeason)

        tmpOppSeasonType = GetProgramDefaults(dtSeason.Rows(0)("seasontype"))

        tmpSSeason1yrago = GetSeason(dtSalesman.Rows(0)("season"), 1, dtSeason.Rows(0)("seasontype"))
        tmpOSeason1yrago = GetSeason(dtSalesman.Rows(0)("season"), 1, tmpOppSeasonType)
        tmpOSeason2yrsago = GetSeason(dtSalesman.Rows(0)("season"), 2, tmpOppSeasonType)

        daProdType = New OleDb.OleDbDataAdapter("SELECT [prodtype], [description] FROM [prodtype]", cn)
        daProdType.Fill(dtProdType)

        daSeasonGoals = New OleDb.OleDbDataAdapter("SELECT DISTINCTROW ProdType.Description, ProdType.ProdType FROM ProdType LEFT JOIN [Cust-seas-proj] ON ProdType.ProdType = [Cust-seas-proj].prodtype " & "WHERE (((ProdType.[disp-seq])>0)) OR ((([Cust-seas-proj].[cust-no])='" & Me.txtCustNo.Text & "') AND (([Cust-seas-proj].season)='" & dtSalesman.Rows(0)("season") & "')) ORDER BY ProdType.[disp-seq];", cn)
        daSeasonGoals.Fill(dtSeasonGoals)

        If dtSeasonGoals.Rows.Count = 0 Then
            tmpFlexGrid.Visible = False
            Exit Sub
        End If

        ' Load Current season goal units for ASR, History, Notes, and Pass

        daGoalsUnits = New OleDb.OleDbDataAdapter("SELECT Sum([Cust-seas-proj].units) AS SumOfunits, [Cust-seas-proj].prodtype " & "From [Cust-seas-proj] WHERE [Cust-seas-proj].[cust-no]='" & Me.txtCustNo.Text & "' AND [Cust-seas-proj].season='" & dtSalesman.Rows(0)("season") & "' AND [Cust-seas-proj].units > 0 GROUP BY [Cust-seas-proj].prodtype;", cn)
        daGoalsUnits.Fill(dtGoalsUnits)

        'For i = 0 To dtSeasonGoals.Rows.Count - 1

        '    Dim foundProdTypeRows As DataRow() = dtProdType.Select("[prodtype] = '" & xlsheet.Cells(i + 2, 1).value & "'")

        '    Dim foundGoalsUnitsRows As DataRow() = dtGoalsUnits.Select("ProdType = '" & foundProdTypeRows(0)("prodtype") & "'")

        '    If foundGoalsUnitsRows.Length > 0 Then
        '        xlsheet.Cells(i + 2, 3).value = foundGoalsUnitsRows(0)("sumofunits")
        '    Else
        '        xlsheet.Cells(i + 2, 3).value = 0
        '    End If
        'Next

        If tmpFlexGrid.Name = "dgvASR" Or tmpFlexGrid.Name = "dgvHistory" Then

            dtGoalsUnits.Clear()
            daGoalsUnits = New OleDb.OleDbDataAdapter("SELECT prodtype, Sum(units) AS TotUnits " & "From (select prodtype, units from (SELECT Sum([order-line].[Qty-open-ord]+[order-line].[qty-shipped]+[cut-back-qty]) AS units, ProdGroup.ProdType " & "FROM (Item INNER JOIN ([Order] INNER JOIN [Order-line] ON Order.[Order-no] = [Order-line].[Order-no]) ON Item.Item = [Order-line].[Item-no]) INNER JOIN ProdGroup ON Item.ProdGroup = ProdGroup.ProdGroup " & "WHERE (((Order.[Cust-no])='" & Me.txtCustNo.Text & "') AND ((Order.Season)='" & dtSalesman.Rows(0)("season") & "')) " & "GROUP BY ProdGroup.ProdType) Union All select prodtype, units from " & "(SELECT Sum([ws-ord-line].[qty-orig-ord]) AS units, ProdGroup.ProdType " & "FROM [ws-ord-head] INNER JOIN ((Item INNER JOIN [ws-ord-line] ON Item.Item = [ws-ord-line].[item-no]) INNER JOIN ProdGroup ON Item.ProdGroup = ProdGroup.ProdGroup) ON [ws-ord-head].[worksheet-id] = [ws-ord-line].[worksheet-id] " & "WHERE ((([ws-ord-head].[validation-status]) <>'" & "CANCEL" & "' And ([ws-ord-head].[validation-status])<> '" & "ORDER" & "') AND (([ws-ord-head].[cust-no])='" & Me.txtCustNo.Text & "') AND (([ws-ord-head].season)='" & dtSalesman.Rows(0)("season") & "'))" & "GROUP BY ProdGroup.ProdType)) GROUP BY prodtype;", cn)
            daGoalsUnits.Fill(dtGoalsUnits)

            For i = 0 To dtSeasonGoals.Rows.Count - 1

                Dim foundProdTypeRows As DataRow() = dtProdType.Select("[prodtype] = '" & xlsheet.Cells(i + 2, 1).value & "'")

                Dim foundGoalsUnitsRows As DataRow() = dtGoalsUnits.Select("ProdType = '" & foundProdTypeRows(0)("prodtype") & "'")

                If foundGoalsUnitsRows.Length > 0 Then
                    xlsheet.Cells(i + 2, 4).value = foundGoalsUnitsRows(0)("totunits")
                Else
                    xlsheet.Cells(i + 2, 4).value = 0
                End If
            Next
        End If

        ' Load increase/decrease of current season actual vs. current season goal for ASR

        If tmpFlexGrid.Name = "dgvASR" Then
            For i = 0 To dtSeasonGoals.Rows.Count - 1
                xlsheet.Cells(i + 2, 5) = xlsheet.Cells(i + 2, 4).value - xlsheet.Cells(i + 2, 3).value
            Next
        End If

        ' Load previous same season's units for ASR & History
        ' ---------------------------------------------------

        If tmpFlexGrid.Name = "dgvASR" Or tmpFlexGrid.Name = "dgvHistory" Then

            dtGoalsUnits.Clear()
            daGoalsUnits = New OleDb.OleDbDataAdapter("SELECT prodtype, Sum(units) AS TotUnits " & "From (select prodtype, units from (SELECT Sum([order-line].[Qty-open-ord]+[order-line].[qty-shipped]+[cut-back-qty]) AS units, ProdGroup.ProdType " & "FROM (Item INNER JOIN ([Order] INNER JOIN [Order-line] ON Order.[Order-no] = [Order-line].[Order-no]) ON Item.Item = [Order-line].[Item-no]) INNER JOIN ProdGroup ON Item.ProdGroup = ProdGroup.ProdGroup " & "WHERE (((Order.[Cust-no])='" & Me.txtCustNo.Text & "') AND ((Order.Season)='" & tmpSSeason1yrago & "')) " & "GROUP BY ProdGroup.ProdType) Union All select prodtype, units from " & "(SELECT Sum([ws-ord-line].[qty-orig-ord]) AS units, ProdGroup.ProdType " & "FROM [ws-ord-head] INNER JOIN ((Item INNER JOIN [ws-ord-line] ON Item.Item = [ws-ord-line].[item-no]) INNER JOIN ProdGroup ON Item.ProdGroup = ProdGroup.ProdGroup) ON [ws-ord-head].[worksheet-id] = [ws-ord-line].[worksheet-id] " & "WHERE ((([ws-ord-head].[validation-status])<>'" & "CANCEL" & "' And ([ws-ord-head].[validation-status])<>'" & "ORDER" & "') AND (([ws-ord-head].[cust-no])='" & Me.txtCustNo.Text & "') AND (([ws-ord-head].season)='" & tmpSSeason1yrago & "'))" & "GROUP BY ProdGroup.ProdType)) GROUP BY prodtype;", cn)
            daGoalsUnits.Fill(dtGoalsUnits)

            For i = 0 To dtSeasonGoals.Rows.Count - 1

                Dim foundProdTypeRows As DataRow() = dtProdType.Select("[prodtype] = '" & xlsheet.Cells(i + 2, 1).value & "'")

                Dim foundGoalsUnitsRows As DataRow() = dtGoalsUnits.Select("ProdType = '" & foundProdTypeRows(0)("prodtype") & "'")

                If foundGoalsUnitsRows.Length > 0 Then
                    If tmpFlexGrid.Name = "dgvASR" Then
                        xlsheet.Cells(i + 2, 6).value = foundGoalsUnitsRows(0)("totunits")
                    ElseIf tmpFlexGrid.Name = "dgvHistory" Then
                        xlsheet.Cells(i + 2, 5).value = foundGoalsUnitsRows(0)("totunits")
                    End If
                Else
                    If tmpFlexGrid.Name = "dgvASR" Then
                        xlsheet.Cells(i + 2, 6).value = 0
                    ElseIf tmpFlexGrid.Name = "dgvHistory" Then
                        xlsheet.Cells(i + 2, 5).value = 0
                    End If
                End If
            Next
        End If


        ' load 1 year ago, opposite season units
        ' --------------------------------------

        If tmpFlexGrid.Name = "dgvHistory" Then

            dtGoalsUnits.Clear()
            daGoalsUnits = New OleDb.OleDbDataAdapter("SELECT prodtype, Sum(units) AS TotUnits " & "From (select prodtype, units from (SELECT Sum([order-line].[Qty-open-ord]+[order-line].[qty-shipped]+[cut-back-qty]) AS units, ProdGroup.ProdType " & "FROM (Item INNER JOIN ([Order] INNER JOIN [Order-line] ON Order.[Order-no] = [Order-line].[Order-no]) ON Item.Item = [Order-line].[Item-no]) INNER JOIN ProdGroup ON Item.ProdGroup = ProdGroup.ProdGroup " & "WHERE (((Order.[Cust-no])='" & Me.txtCustNo.Text & "') AND ((Order.Season)='" & tmpOSeason1yrago & "')) " & "GROUP BY ProdGroup.ProdType) Union All select prodtype, units from " & "(SELECT Sum([ws-ord-line].[qty-orig-ord]) AS units, ProdGroup.ProdType " & "FROM [ws-ord-head] INNER JOIN ((Item INNER JOIN [ws-ord-line] ON Item.Item = [ws-ord-line].[item-no]) INNER JOIN ProdGroup ON Item.ProdGroup = ProdGroup.ProdGroup) ON [ws-ord-head].[worksheet-id] = [ws-ord-line].[worksheet-id] " & "WHERE ((([ws-ord-head].[validation-status])<>'" & "CANCEL" & "' And ([ws-ord-head].[validation-status])<>'" & "ORDER" & "') AND (([ws-ord-head].[cust-no])='" & Me.txtCustNo.Text & "') AND (([ws-ord-head].season)='" & tmpOSeason1yrago & "'))" & "GROUP BY ProdGroup.ProdType)) GROUP BY prodtype;", cn)
            daGoalsUnits.Fill(dtGoalsUnits)

            For i = 0 To dtSeasonGoals.Rows.Count - 1

                Dim foundProdTypeRows As DataRow() = dtProdType.Select("[prodtype] = '" & xlsheet.Cells(i + 2, 1).value & "'")

                Dim foundGoalsUnitsRows As DataRow() = dtGoalsUnits.Select("ProdType = '" & foundProdTypeRows(0)("prodtype") & "'")

                If foundGoalsUnitsRows.Length > 0 Then
                    xlsheet.Cells(i + 2, 6) = foundGoalsUnitsRows(0)("totunits")
                Else
                    xlsheet.Cells(i + 2, 6) = 0
                End If
            Next
        End If

        ' load 2 years ago, opposite season units
        ' ---------------------------------------

        If tmpFlexGrid.Name = "dgvHistory" Then

            dtGoalsUnits.Clear()
            daGoalsUnits = New OleDb.OleDbDataAdapter("SELECT prodtype, Sum(units) AS TotUnits " & "From (select prodtype, units from (SELECT Sum([order-line].[Qty-open-ord]+[order-line].[qty-shipped]+[cut-back-qty]) AS units, ProdGroup.ProdType " & "FROM (Item INNER JOIN ([Order] INNER JOIN [Order-line] ON Order.[Order-no] = [Order-line].[Order-no]) ON Item.Item = [Order-line].[Item-no]) INNER JOIN ProdGroup ON Item.ProdGroup = ProdGroup.ProdGroup " & "WHERE (((Order.[Cust-no])=" & Chr(39) & Me.txtCustNo.Text & Chr(39) & ") AND ((Order.Season)=" & Chr(39) & tmpOSeason2yrsago & Chr(39) & ")) " & "GROUP BY ProdGroup.ProdType) Union All select prodtype, units from " & "(SELECT Sum([ws-ord-line].[qty-orig-ord]) AS units, ProdGroup.ProdType " & "FROM [ws-ord-head] INNER JOIN ((Item INNER JOIN [ws-ord-line] ON Item.Item = [ws-ord-line].[item-no]) INNER JOIN ProdGroup ON Item.ProdGroup = ProdGroup.ProdGroup) ON [ws-ord-head].[worksheet-id] = [ws-ord-line].[worksheet-id] " & "WHERE ((([ws-ord-head].[validation-status])<>'CANCEL' And ([ws-ord-head].[validation-status])<>'ORDER') AND (([ws-ord-head].[cust-no])=" & Chr(39) & Me.txtCustNo.Text & Chr(39) & ") AND (([ws-ord-head].season)=" & Chr(39) & tmpOSeason2yrsago & Chr(39) & "))" & "GROUP BY ProdGroup.ProdType)) GROUP BY prodtype;", cn)
            daGoalsUnits.Fill(dtGoalsUnits)

            For i = 0 To dtSeasonGoals.Rows.Count - 1

                Dim foundProdTypeRows As DataRow() = dtProdType.Select("[prodtype] = '" & xlsheet.Cells(i + 2, 1).value & "'")

                Dim foundGoalsUnitsRows As DataRow() = dtGoalsUnits.Select("ProdType = '" & foundProdTypeRows(0)("prodtype") & "'")

                If foundGoalsUnitsRows.Length > 0 Then
                    xlsheet.Cells(i + 2, 7) = foundGoalsUnitsRows(0)("totunits")
                Else
                    xlsheet.Cells(i + 2, 7) = 0
                End If
            Next
        End If

        ' Load inc/dec of current season actual vs. last season actual
        ' ------------------------------------------------------------

        If tmpFlexGrid.Name = "dgvASR" Then
            For i = 0 To dtSeasonGoals.Rows.Count - 1
                xlsheet.Cells(i + 2, 7) = xlsheet.Cells(i + 2, 4).value - xlsheet.Cells(i + 2, 6).value
            Next
        End If

        ' Load Comments
        ' -------------

        If tmpFlexGrid.Name = "dgvASR" Then
            For i = 0 To dtSeasonGoals.Rows.Count - 1

                Dim foundProdTypeRows As DataRow() = dtProdType.Select("[prodtype] = '" & xlsheet.Cells(i + 2, 1).value & "'")

                dtCustStatus.Clear()
                daCustStatus = New OleDb.OleDbDataAdapter("SELECT [statuscomments] FROM [customerstatus] WHERE [cust-no] = '" & Me.txtCustNo.Text & "' AND [season] = '" & dtSalesman.Rows(0)("season") & "' AND [prodtype] = '" & foundProdTypeRows(0)("prodtype") & "' AND OrderCode Is Null AND [stcode] = 'ordr'", cn)
                daCustStatus.Fill(dtCustStatus)

                If dtCustStatus.Rows.Count > 0 Then
                    xlsheet.Cells(i + 2, 8).value = dtCustStatus.Rows(0)("statuscomments")
                Else
                    xlsheet.Cells(i + 2, 8).value = ""
                End If
            Next
        End If

        If tmpFlexGrid.Name = "dgvNotes" Then
            For i = 0 To dtSeasonGoals.Rows.Count - 1
                
                Dim foundProdTypeRows As DataRow() = dtProdType.Select("[prodtype] = '" & xlsheet.Cells(i + 2, 1).value & "'")

                dtCustStatus.Clear()
                daCustStatus = New OleDb.OleDbDataAdapter("SELECT [statuscomments] FROM [customerstatus] WHERE [cust-no] = '" & Me.txtCustNo.Text & "' AND [season] = '" & dtSalesman.Rows(0)("season") & "' AND [prodtype] = '" & foundProdTypeRows(0)("prodtype") & "' AND [stcode] = 'note'", cn)
                daCustStatus.Fill(dtCustStatus)

                If dtCustStatus.Rows.Count > 0 Then
                    xlsheet.Cells(i + 2, 4).value = dtCustStatus.Rows(0)("statuscomments")
                Else
                    xlsheet.Cells(i + 2, 4).value = ""
                End If
            Next
        End If

        If tmpFlexGrid.Name = "dgvPass" Then
            For i = 0 To dtSeasonGoals.Rows.Count - 1

                Dim foundProdTypeRows As DataRow() = dtProdType.Select("[prodtype] = '" & xlsheet.Cells(i + 2, 1).value & "'")

                dtCustStatus.Clear()
                daCustStatus = New OleDb.OleDbDataAdapter("SELECT [statuscomments] FROM [customerstatus] WHERE [cust-no] = '" & Me.txtCustNo.Text & "' AND [season] = '" & dtSalesman.Rows(0)("season") & "' AND [prodtype] = '" & foundProdTypeRows(0)("prodtype") & "' AND OrderCode Is Null AND [stcode] = 'pass'", cn)
                daCustStatus.Fill(dtCustStatus)

                If dtCustStatus.Rows.Count > 0 Then
                    xlsheet.Cells(i + 2, 4).value = dtCustStatus.Rows(0)("statuscomments")
                Else
                    xlsheet.Cells(i + 2, 4).value = ""
                End If
            Next
        End If

        If tmpFlexGrid.Name = "dgvNotes" Then

            daNotesComments = New OleDb.OleDbDataAdapter("SELECT [followupdate], [notescomments] FROM [notescomments] WHERE [cust-no] = '" & Me.txtCustNo.Text & "' AND [season] = '" & dtSalesman.Rows(0)("season") & "'", cn)
            daNotesComments.Fill(dtNotesComments)

            If dtNotesComments.Rows.Count > 0 Then
                xlsheet.Cells(dtSeasonGoals.Rows.Count + 2, 2).value = "Follow-up Date: " & dtNotesComments.Rows(0)("followupdate")

                If Not IsDBNull(dtNotesComments.Rows(0)("notescomments")) Then
                    xlsheet.Cells(dtSeasonGoals.Rows.Count + 4, 2).value = "General Comments: " & dtNotesComments.Rows(0)("notescomments")
                Else
                    xlsheet.Cells(dtSeasonGoals.Rows.Count + 4, 2).value = "General Comments: NONE"
                End If
            Else
                xlsheet.Cells(dtSeasonGoals.Rows.Count + 4, 2).value = "General Comments: NONE"
            End If
        End If

        If tmpFlexGrid.Name = "dgvASR" Then
            xlsheet.Range("A1:A100").Columns.EntireColumn.AutoFit()
            xlsheet.Range("B1:H1").Columns.EntireColumn.AutoFit()
            'xlsheet.Cells.Columns("A:H").AutoFit()
        ElseIf tmpFlexGrid.Name = "dgvNotes" Or tmpFlexGrid.Name = "dgvPass" Then
            xlsheet.Cells.Columns("B:B").ColumnWidth = 50
        ElseIf tmpFlexGrid.Name = "dgvHistory" Then
            xlsheet.Cells.Columns("B:G").AutoFit()
        End If

        xlsheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape

        If tmpFlexGrid.Name <> "dgvHistory" Then
            With xlsheet.MailEnvelope.Item
                .To = GetProgramDefaults("SalesDeptEmail")
                If tmpFlexGrid.Name = "dgvASR" Then
                    .subject = cSalesSeason & " ASR - " & Me.lblName.Text & " (" & Me.txtCustNo.Text & ")"
                ElseIf tmpFlexGrid.Name = "dgvNotes" Then
                    .subject = cSalesSeason & " Notes - " & Me.lblName.Text & " (" & Me.txtCustNo.Text & ")"
                ElseIf tmpFlexGrid.Name = "dgvPass" Then
                    .subject = cSalesSeason & " Pass - " & Me.lblName.Text & " (" & Me.txtCustNo.Text & ")"
                End If
                .Send()
            End With
        End If

        If tmpFlexGrid.Name = "dgvHistory" Then
            PrintDialog1.ShowDialog()
            xlsheet.PrintOutEx(1, 1, 1, False, PrintDialog1.PrinterSettings.PrinterName, False, False, False, False)
        End If

        xl.ActiveWorkbook.Save()
        xl.ActiveWorkbook.Close()
        xl.Quit()
        System.Runtime.InteropServices.Marshal.FinalReleaseComObject(xl)
        xlsheet = Nothing
        xlwbook = Nothing
        xl = Nothing
        cn.Close()
        cn.Dispose()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    ''' <summary>
    ''' This procedure puts general 'Notes' comments/text into the 'NotesComments' table
    ''' </summary>
    ''' <remarks>Notes comments are used in Account Status Reports (ASR) when the Customer plans to order product later.  The Sales Rep 
    ''' will write notes to use for a later visit and hopefully a later order.</remarks>

    Private Sub WriteNotesGeneralComments()
        Dim cn As New OleDb.OleDbConnection
        Dim daSalesman As OleDb.OleDbDataAdapter
        Dim dtSalesman As New DataTable
        Dim daNotesComments As OleDb.OleDbDataAdapter
        Dim dtNotesComments As New DataTable

        cn.ConnectionString = MySettings.Default("SaleForcConnectionString")
        cn.Open()

        If Len(Trim(Me.txtNoteGenComments.Text)) > 0 Then
            daSalesman = New OleDb.OleDbDataAdapter("SELECT [season] FROM [salesman]", cn)
            daSalesman.Fill(dtSalesman)
            daNotesComments = New OleDb.OleDbDataAdapter("SELECT [followupdate], [notescomments] FROM [notescomments]  WHERE [cust-no] = '" & Me.txtCustNo.Text & "' AND [season] = '" & dtSalesman.Rows(0)("season") & "'", cn)
            daNotesComments.Fill(dtNotesComments)

            If dtNotesComments.Rows.Count = 0 Then
                Dim conn As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
                Dim com As New OleDb.OleDbCommand("INSERT INTO NotesComments ([cust-no],[season],[notescomments],[followupdate]) VALUES ('" & bndCustomer.Current("cust-no") & "', '" & dtSalesman.Rows(0)("season") & "', " & Chr(34) & txtNoteGenComments.Text & Chr(34) & ", '" & Me.dtpNotesFollowup.Value & "')", conn)
                conn.Open()
                com.ExecuteNonQuery()
                conn.Close()
            Else
                Dim conn As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
                Dim com As New OleDb.OleDbCommand("UPDATE [notescomments] SET [notescomments] = " & Chr(34) & txtNoteGenComments.Text & Chr(34) & ", [followupdate] = '" & dtpNotesFollowup.Value & "' WHERE [cust-no] = '" & bndCustomer.Current("cust-no") & "' and [season]  = '" & dtSalesman.Rows(0)("season") & "'", conn)
                conn.Open()
                com.ExecuteNonQuery()
                conn.Close()
            End If
        End If
        cn.Close()
        cn.Dispose()
    End Sub

    '	Private Sub cmdPrintGraphs_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrintGraphs.Click
    '		Dim Printer As New Printer
    '		On Error GoTo CancelSub
    '		Dim PictureChart As System.Drawing.Image
    '		Dim tmpX As Short
    '		Dim tmpY As Short
    '		Dim numY As Short
    '		Dim PrintPage As Short
    '		Dim def_printer As String
    '		Dim pr As Printer
    '		Dim w As New IWshRuntimeLibrary.WshNetwork
    '		Dim i As Short
    '		Dim j As Short

    '		def_printer = Printer.DeviceName
    '		'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
    '		CommonDialog1.CancelError = True
    '		CommonDialog1Print.ShowDialog()
    '		' set default printer back

    '		PrintPage = 1
    '		Printer.Font = VB6.FontChangeSize(Printer.Font, 12)
    '		Printer.Print(Me.lblName.Text & " (" & Me.txtCustNo.Text & ") History Graph - Page " & PrintPage)

    '		For i = 0 To MSChart1.UBound
    '			MSChart1(i).EditCopy()
    '			'UPGRADE_ISSUE: Constant vbCFBitmap was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
    '			PictureChart = My.Computer.Clipboard.GetImage()
    '			If i Mod 2 = 0 Then
    '				j = j + 1
    '				tmpX = 300
    '				tmpY = ((j - 1) * 5000) + 500
    '			Else
    '				numY = numY + 1
    '				tmpX = 5300
    '			End If
    '			Printer.PaintPicture(PictureChart, tmpX, tmpY, 4500, 4500)
    '			If numY = 3 Then
    '				PrintPage = PrintPage + 1
    '				Printer.NewPage()
    '				Printer.Print(Me.lblName.Text & " (" & Me.txtCustNo.Text & ") History Graph - Page " & PrintPage)
    '				numY = 0
    '				j = 0
    '			End If
    '			System.Windows.Forms.Application.DoEvents()
    '		Next 
    '		Printer.EndDoc()
    '		w.SetDefaultPrinter((def_printer))
    '		Exit Sub
    'CancelSub: 
    '	End Sub

    ''' <summary>
    ''' This procedure will get a new customer number when the user clicks to add a new customer
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks>This procedure will clear the New Customer screen and display a new customer number</remarks>

    Private Sub cmdNewCust_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNewCust.Click
        If Len(Trim(NewCustNo)) = 0 Then Exit Sub
        tabCustInfo.SelectedIndex = 0
        flagAddNewCust = True
        setFormViewStatus((3))
        clrNewCustForm()
        lblTempCustNo.Text = NewCustNo()
        lblTempShipNo.Text = lblTempCustNo.Text
        txtCustID.Visible = False
        Me.KeyPreview = True
        lblCustomerName.ResetText()
        mebName.Focus()
    End Sub

    ''' <summary>
    ''' This procedure will load the new customer screen and allow the user to edit the information
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmdNewCustEdit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNewCustEdit.Click
        flagEditNewCust = True
        If Len(Trim(dblShipNoList.Text)) = 0 Then
            dblShipNoList.Focus()
            If Len(Trim(dblShipNoList.Text)) = 0 Then
                System.Windows.Forms.SendKeys.SendWait("{down}")
            End If
        End If

        setFormViewStatus((3))
        clrNewCustForm()
        loadNewCustEditScrn()
        Me.KeyPreview = True
        mebName.Focus()
    End Sub

    ''' <summary>
    ''' This procedure will get a new worksheet number and load the new worksheet form
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks>When the user clicks to create a new worksheet, this procedure will get a new worksheet number, display a warning if the
    ''' user does not select the default shipping address, and display the new worksheet form</remarks>

    Private Sub cmdNewWs_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNewWs.Click
        Dim cAns, cStyle As Short
        Dim cTitle, cMsg As String
        Dim bolShowWkstSummary As Boolean

        If Len(Trim(NewWorkSheetNo)) = 0 Then Exit Sub
        lNewWorksheet = True ' This is a new worksheet
        If Len(Trim(dblShipNoList.Text)) = 0 Then
            dblShipNoList.Focus() ' Make sure that the cust ship is highlighted
            If Len(Trim(dblShipNoList.Text)) = 0 Then
                System.Windows.Forms.SendKeys.SendWait("{down}")
            End If
        End If

        If txtSelectedShip.Text <> lblDefaultShip.Text Then
            cMsg = "You have selected a shipping destination" & vbCrLf
            cMsg = cMsg & "different then the default shipping" & vbCrLf
            cMsg = cMsg & "destination." & vbCrLf
            cMsg = cMsg & "" & vbCrLf
            cMsg = cMsg & "Do you want to continue?"
            cStyle = MsgBoxStyle.Question + MsgBoxStyle.YesNo
            cTitle = "SELECTED CUSTOMER SHIPPING DESTINATION"
            cAns = MsgBox(cMsg, cStyle, cTitle)
            If cAns = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        bolShowWkstSummary = CBool(GetProgramDefaults("ShowWkstAndOrderSummary"))

        If bolShowWkstSummary = CBool("true") Then
            frmPreviousWkstOrder.ShowDialog()
        End If

        fromLocation = "Cust"
        lNewWorksheet = True ' This is a new worksheet

        cCustWsNum = NewWorkSheetNo()

        cCustNumber = Me.txtCustNo.Text
        cCustNameW = Me.lblName.Text
        If Len(Trim(dblShipNoList.Text)) = 0 Then
            cShipNumber = cCustCustSh
        Else
            cShipNumber = dblShipNoList.Text
        End If
        If Trim(lblShipViaCd.Text) <> "" Then
            cWsShipViaCd = lblShipViaCd.Text
        ElseIf Trim(lblCustShipVia.Text) <> "" Then
            cWsShipViaCd = lblCustShipVia.Text
        Else
            cWsShipViaCd = vbNullString
        End If

        cShipNameW = lblShipName.Text

        lCustToWs = True

        Me.Hide()
        frmWorksheet.ShowDialog(me)
    End Sub

    ''' <summary>
    ''' This procedure will reset the transmit status on a selected worksheet
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks>When the user selects a worksheet to re-transmit, this procedure will reset fields so that it appears as though the 
    ''' worksheet has never been transmitted to Knitcraft.  This is most often done when a worksheet did not transmit properly</remarks>

    Private Sub cmdRetransmit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRetransmit.Click
        Dim answer As Short
        answer = MsgBox("Are you sure you want to retransmit worksheet: " & bndWorksheets.Current("worksheet-id") & "?", MsgBoxStyle.YesNo, "Retransmit Worksheet")
        If answer = 6 Then
            Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
            Dim com As New OleDb.OleDbCommand("UPDATE [ws-ord-head] SET readytoxmit = True, xmitted = False, xmitteddate = null, xmittedtime = null WHERE [worksheet-id] = '" & bndWorksheets.Current("worksheet-id") & "'", con)
            con.Open()
            com.ExecuteNonQuery()
            con.Close()
            logFileAdd(3, "Reset: " & Me.bndWorksheets.Current("worksheet-id"))
            Dim strcommand As String
            strcommand = Mid(Ws_ord_headTableAdapter.Adapter.SelectCommand.CommandText, 1, Len(Ws_ord_headTableAdapter.Adapter.SelectCommand.CommandText) - 2) & "'" & bndCustomer.Current("cust-no") & "'" & ")"
            GetWorksheetData(strcommand)
            MsgBox("Worksheet is set to transmit!", MsgBoxStyle.OkOnly)
        Else
            MsgBox("Worksheet was not reset to transmit", MsgBoxStyle.OkOnly)
        End If
    End Sub

    ''' <summary>
    ''' This procedure displays the worksheet form and the data associated with the selected worksheet number
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmdViewEditWs_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdViewEditWs.Click
        If Me.bndWorksheets.Count > 0 Then
            cCustWsNum = Me.bndWorksheets.Current("worksheet-id")
            If Trim(cCustWsNum) <> "" Then
                fromLocation = "Cust"
                cCustNumber = txtCustID.Text
                lNewWorksheet = False
                frmWorksheet.ShowDialog()
            End If
        Else
            MsgBox("No worksheets to view/edit!", MsgBoxStyle.Critical, "View Worksheet")

        End If
    End Sub

    ''' <summary>
    ''' This procedure displays the order form and the data associated with the selected order number
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmdViewOrder_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdViewOrder.Click
        If Me.bndOrders.Count > 0 Then
            cCustOrdNum = Me.bndOrders.Current("order-no")
            If Trim(cCustOrdNum) <> "" Then
                fromLocation = "Cust"
                cCustNumber = txtCustID.Text
                frmOrders.ShowDialog()
            End If
        Else
            MsgBox("No orders to view!", MsgBoxStyle.Critical, "View Order")
        End If
    End Sub

    ''' <summary>
    ''' This procedure will print the selected worksheet 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        If Me.bndWorksheets.Count > 0 Then
            fromLocation = "Cust"
            cCustWsNum = Me.bndWorksheets.Current("worksheet-id")
            Call frmWorksheet.btnPrint_Click(Nothing, New System.EventArgs())
        Else
            MsgBox("No worksheets to print!", MsgBoxStyle.Critical, "Print Worksheet")
        End If
    End Sub

    ''' <summary>
    '''  This button will take you back to whatever document you were previously viewing
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmdWebBack_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdWebBack.Click
        On Error GoTo ErrorRoutine
        WebBrowser1.GoBack()
ErrorRoutine:
        Exit Sub
    End Sub

    ''' <summary>
    ''' This button will take you forward to the next document if you have previously browsed multiple documents and had then backed-up to the page you are currently viewing.
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmdWebForward_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdWebForward.Click
        On Error GoTo ErrorRoutine
        WebBrowser1.GoForward()
ErrorRoutine:
        Exit Sub
    End Sub

    ''' <summary>
    ''' This procedure will open the current webpage in the default internet browser
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmdWebOpenBrowser_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdWebOpenBrowser.Click
        Dim browser As New Process()
        browser.StartInfo.FileName = Me.WebBrowser1.Url.ToString
        browser.StartInfo.UseShellExecute = True
        browser.Start()
    End Sub

    ''' <summary>
    ''' This procedure will reload the current webpage
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmdWebRefresh_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdWebRefresh.Click
        If Len(Me.cmbCustomerWebsites.Text) > 0 Then
            WebBrowser1.Refresh()
        End If
    End Sub

    ''' <summary>
    ''' This procedure will stop loading the current webpage (assuming it has not already loaded)
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmdWebStop_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdWebStop.Click
        WebBrowser1.Stop()
        Me.ProgressBar1.Visible = False
        Me.picLoadingWeb.Visible = False
        lblWebsiteLoading.Text = vbNullString
        Label66.Text = "Done"
        ProgressBar1.Visible = False 'This makes the progress bar disappear after the page is loaded.
    End Sub

    ''' <summary>
    ''' This procedure will open the select appointment item in Microsoft Office Outlook
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmdOpenAppointment_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOpenAppointment.Click
        Dim OutlookApp As Microsoft.Office.Interop.Outlook.Application
        Dim OutlookNameSpace As Microsoft.Office.Interop.Outlook.NameSpace
        Dim calendaritem As Microsoft.Office.Interop.Outlook.AppointmentItem
        Dim calendar As Microsoft.Office.Interop.Outlook.MAPIFolder
        Dim dt As New DataTable
        Dim dr As DataRow

        'Add fields to the datatable

        OutlookApp = New Microsoft.Office.Interop.Outlook.Application
        OutlookNameSpace = OutlookApp.GetNamespace("MAPI")
        dt.Columns.Add("Subject", Type.GetType("System.String"))
        dt.Columns.Add("Location", Type.GetType("System.String"))
        dt.Columns.Add("Start", Type.GetType("System.DateTime"))
        dt.Columns.Add("End", Type.GetType("System.DateTime"))

        ' get the users's calendar

        calendar = OutlookNameSpace.GetDefaultFolder(Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderCalendar)
        Dim i As Integer

        If dgvCustomerAppointments.Rows.Count = 0 Then
            MsgBox("This customer does not have any appointments to open!", MsgBoxStyle.Critical, "Open Customer Appointment")
            Exit Sub
        End If
        i = dgvCustomerAppointments.CurrentRow.Index

        'Find the appointement in the user's calendar and display the appointment; 

        For Each calendaritem In calendar.Items
            If calendaritem.BillingInformation = bndCustomer.Current("cust-no") And (calendaritem.Start = dgvCustomerAppointments.Item(2, i).Value) And (calendaritem.End = dgvCustomerAppointments.Item(3, i).Value) And (calendaritem.Subject = dgvCustomerAppointments.Item(0, i).Value) Then
                Me.Hide()
                calendaritem.Display(True)
                Me.Show()
                Exit For
            End If
        Next

        'OutlookApp.ActiveWindow.activate()

        Do While OutlookApp.Inspectors.Count > 0
            'just hang out until the appointment window is closed.
            Me.SendToBack()
        Loop

        ' Startup outlook again.  Starting w/ Outlook 2007 SP2 - the app closes when user closes the last visible Outlook window, so sleep to allow it time to close properly
        System.Threading.Thread.Sleep(100)

        OutlookApp = New Microsoft.Office.Interop.Outlook.Application
        OutlookNameSpace = OutlookApp.GetNamespace("MAPI")
        calendar = OutlookNameSpace.GetDefaultFolder(Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderCalendar)

        'Reload data in the datatable in case the user modified the data

        For Each calendaritem In calendar.Items
            If calendaritem.BillingInformation = bndCustomer.Current("cust-no") Then
                dr = dt.NewRow
                dr("Subject") = calendaritem.Subject
                dr("Location") = calendaritem.Location
                dr("Start") = calendaritem.Start
                dr("End") = calendaritem.End
                dt.Rows.Add(dr)
            End If
        Next
        dt.DefaultView.Sort = "Start ASC"

        'Bring the updated data into the grid

        dgvCustomerAppointments.DataSource = dt
        OutlookNameSpace.Logoff()
        'OutlookApp.Quit()
        Me.BringToFront()
    End Sub

    ''' <summary>
    ''' This procedure will create a new Microsoft Office Outlook calendar item and display it allowing the user to create an appointment
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmdNewAppointment_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNewAppointment.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        'Try
        Dim OutlookApp As Microsoft.Office.Interop.Outlook.Application
        Dim OutlookNameSpace As Microsoft.Office.Interop.Outlook.NameSpace
        Dim newAppointment As Microsoft.Office.Interop.Outlook.AppointmentItem
        Dim spLinks As Microsoft.Office.Interop.Outlook.Links
        Dim splink As Microsoft.Office.Interop.Outlook.Link
        Dim spContacts As Microsoft.Office.Interop.Outlook.Items
        Dim spContact As Microsoft.Office.Interop.Outlook.ContactItem
        Dim objFolder As Microsoft.Office.Interop.Outlook.MAPIFolder
        Dim colFolders As Microsoft.Office.Interop.Outlook.Folders
        Dim folder As Microsoft.Office.Interop.Outlook.MAPIFolder

        If bndCustomer.Current Is Nothing Then
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        OutlookApp = New Microsoft.Office.Interop.Outlook.Application
        OutlookNameSpace = OutlookApp.GetNamespace("MAPI")
        newAppointment = OutlookApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olAppointmentItem)
        objFolder = OutlookNameSpace.GetDefaultFolder(Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderContacts)
        colFolders = objFolder.Folders

        If colFolders.Count > 0 Then
            For Each folder In colFolders
                If folder.Name = "Customers" Then
                    objFolder = colFolders("Customers")
                    spContacts = objFolder.Items
                    Exit For
                End If
            Next folder
        End If

        spContact = objFolder.Items.Find("[CustomerID] = " & Chr(39) & Me.bndCustomer.Current("cust-no") & Chr(39))

        With newAppointment
            .Subject = Me.bndCustomer.Current("cust-no") & " - " & Me.bndCustomer.Current("name")
            .Location = Me.bndCustomer.Current("address2") & ", " & Me.bndCustomer.Current("city") & ", " & Me.bndCustomer.Current("st") & " " & Me.bndCustomer.Current("zip-code") & " (Tel: " & Me.bndCustomer.Current("telephone") & ")"
            '.body = "Contact: " & adoCustInfo.Recordset("contact") & vbCrLf & "Telephone: " & adoCustInfo.Recordset("telephone")
            .BillingInformation = Me.bndCustomer.Current("cust-no") 'used to filter appointments
            .ReminderMinutesBeforeStart = 1440
            .Duration = 120
            .Categories = "Knitcraft Customer Appointment"
            'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
            If Not TypeName(spContact) = "Nothing" Then
                spLinks = .Links
                splink = spLinks.Add(spContact)
            End If
            Me.Hide()
            .Display(True)
            'If IsProcessRunning("Outlook.exe") Then OutlookApp.ActiveWindow.activate()
        End With

        Do While OutlookApp.Inspectors.Count > 0
            'just hang out until the appointment window is closed.
        Loop
        Me.Show()

        'System.Threading.Thread.Sleep(100) 'sleep to give Outlook some time to close properly
        FindCustAppointments()
        Me.BringToFront()
        Me.Cursor = System.Windows.Forms.Cursors.Default
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    ''' <summary>
    ''' This procedure will find the customer ship to record for the current customer and display the data in the appropriate controls
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub UpdateCustShipInfo()
        Dim fldname As String

        ' ---- check the Record-Status and set up the appropriate buttons
        cFlagCustStatus = UCase(Me.bndCustomer.Current("status-code"))
        Select Case cFlagCustStatus
            Case "N"
                cmdNewCustEdit.Visible = True ' data has not been transmitted. Still can edit

            Case "X" ' data has been transmitted and is now locked
                cmdNewCustEdit.Visible = False

            Case Else
                cmdNewCustEdit.Visible = False
        End Select

        setCmdNewWsStatus()

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        fldname = Me.txtCustNo.Text

        dblShipNoList.DataSource = Me.bndCustomerShip
        dblShipNoList.DisplayMember = "cust-sh"

        Me.CustomerSHTableAdapter.FillByCustNo(Me.SaleForcDataSet.CustomerSH, bndCustomer.Current("cust-no"))
        If Me.SaleForcDataSet.CustomerSH.Rows.Count = 0 Then
            lblNoShipToInfo.Visible = True
            lblNoShipToInfo.Text = "No Ship To information for " & bndCustomer.Current("name")
            'MsgBox("No Ship To information for " & bndCustomer.Current("name") & " (customer number: " & bndCustomer.Current("cust-no") & ")", MsgBoxStyle.Critical, "Customer Information")
            clrShipFields()
            'Exit Sub
        Else
            lblNoShipToInfo.Visible = False
        End If
        If fldname <> "" Then
            If isCustInShipFile(fldname) Then
                cFlagShipStatus = UCase(Me.bndCustomerShip.Current("status-code"))
                dblShipNoList.Refresh()
                lblDblCnt.Text = CStr(dblShipNoList.Items.Count)
                setCmdNewWsStatus()
                txtSelectedShip_TextChanged(txtSelectedShip, New System.EventArgs())
            Else
                clrShipFields()
            End If

            If IsDBNull(Me.lblShipViaCd) Then
                lblShipViaDesc.Text = vbNullString
                lblCustShipViaDesc.Text = vbNullString
            Else
                lblShipViaDesc.Text = findShipViaDesc(Me.lblShipViaCd.Text)
                lblCustShipViaDesc.Text = findShipViaDesc(Me.lblShipViaCd.Text)
            End If

        End If

        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        con.Open()
        Dim daShipVia As New SaleForcDataSetTableAdapters.ShipViaCodeTableAdapter
        Dim dtShipVia As New SaleForcDataSet.ShipViaCodeDataTable

        dtShipVia = daShipVia.GetDataByViaCode(bndCustomer.Current("via-code"))
        If dtShipVia.Rows.Count > 0 Then lblCustShipViaDesc.Text = dtShipVia.Rows(0)("viadesc")
        If bndCustomerShip.Count <> 0 Then
            dtShipVia = daShipVia.GetDataByViaCode(bndCustomerShip.Current("via-code"))
            If dtShipVia.Count > 0 Then lblShipViaDesc.Text = dtShipVia.Rows(0)("viadesc")
        End If
        con.Close()

        FindCustOrders()
        FindCustWorksheets()
        FindCustMemos()
        FindCustWebsites()
        FindCustAppointments()
        If WebBrowser2.Visible Then
            btnMap_Click(Nothing, Nothing)
        End If
        If tabCustInfo.SelectedIndex = 7 Then
            Call Timer1_Tick(Timer1, New System.EventArgs())
            Call cmbASRView_SelectedIndexChanged(cmbASRView, New System.EventArgs())
        End If
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    ''' <summary>
    ''' This procedure finds calendar items in Microsoft Office Outlook for customer and loads the appointment information into a datagrid
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub FindCustAppointments()
        Dim OutlookApp As Microsoft.Office.Interop.Outlook.Application
        Dim OutlookNameSpace As Microsoft.Office.Interop.Outlook.NameSpace
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim calendar As Microsoft.Office.Interop.Outlook.MAPIFolder
        Dim calendaritem As Microsoft.Office.Interop.Outlook.AppointmentItem
        OutlookApp = New Microsoft.Office.Interop.Outlook.Application
        OutlookNameSpace = OutlookApp.GetNamespace("MAPI")

        'Format DataGridView 

        dgvCustomerAppointments.DefaultCellStyle.Font = New Font("Tahoma", 8)
        dgvCustomerAppointments.RowHeadersVisible = False

        ' Add fields to the datatable

        dt.Columns.Add("Subject", Type.GetType("System.String"))
        dt.Columns.Add("Location", Type.GetType("System.String"))
        dt.Columns.Add("Start", Type.GetType("System.DateTime"))
        dt.Columns.Add("End", Type.GetType("System.DateTime"))

        ' Get Outloook Appointments and write appointment to the datatable

        calendar = OutlookNameSpace.GetDefaultFolder(Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderCalendar)

        For Each calendaritem In calendar.Items
            If calendaritem.BillingInformation = bndCustomer.Current("cust-no") Then
                dr = dt.NewRow
                dr("Subject") = calendaritem.Subject
                dr("Location") = calendaritem.Location
                dr("Start") = calendaritem.Start
                dr("End") = calendaritem.End
                dt.Rows.Add(dr)
            End If
        Next
        If dt.Rows.Count = 0 Then
            dgvCustomerAppointments.Visible = False
            lblNoAppts.Visible = True
            lblNoAppts.Text = "No appointments scheduled for " & bndCustomer.Current("Name")
        Else
            dgvCustomerAppointments.DataSource = dt
            lblNoAppts.Visible = False
            dt.DefaultView.Sort = "Start ASC"
            dgvCustomerAppointments.Visible = True
            dgvCustomerAppointments.Show()
            dgvCustomerAppointments.BringToFront()
        End If
        OutlookNameSpace.Logoff()
        'OutlookApp.Quit()
        Me.BringToFront()
    End Sub

    ''' <summary>
    ''' This procedure finds order records for the current customer and displays the data in the order grid
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub FindCustOrders()
        Dim strCommand As String
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        SaleForcDataSet.Order.Clear()
        dgvOrders.DataSource = Nothing
        Me.OrderTableAdapter.FillByCustNo(Me.SaleForcDataSet.Order, txtCustNo.Text)
        Me.bndOrders.Sort = "[order-date] DESC"
        dgvOrders.DataSource = bndOrders
        strCommand = Mid(OrderTableAdapter.Adapter.SelectCommand.CommandText, 1, Len(OrderTableAdapter.Adapter.SelectCommand.CommandText) - 2) & "'" & bndCustomer.Current("cust-no") & "'"
        GetOrderData(strCommand)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    ''' <summary>
    ''' This procedure finds ws-ord-head records for the current customer and displays the data in the worksheet grid
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub FindCustWorksheets()
        Dim strCommand As String
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        SaleForcDataSet._ws_ord_head.Clear()
        dgvWorksheets.DataSource = Nothing
        Me.Ws_ord_headTableAdapter.FillByCustNo(Me.SaleForcDataSet._ws_ord_head, txtCustNo.Text)
        Me.bndWorksheets.Sort = "[ws-create-date] DESC"
        dgvWorksheets.DataSource = bndWorksheets
        strCommand = Mid(Ws_ord_headTableAdapter.Adapter.SelectCommand.CommandText, 1, Len(Ws_ord_headTableAdapter.Adapter.SelectCommand.CommandText) - 2) & "'" & bndCustomer.Current("cust-no") & "'" & ")"
        GetWorksheetData(strCommand)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    ''' <summary>
    ''' This procedure is fired when the form is activated and will filter customer data based on the status (permanent, inactive, new) 
    ''' of the customer. If the 'fromLocation' variable is populated, the procedure will load data for the customer that is displayed
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub frmCustInfo_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        Dim x As Boolean
        If fromLocation <> "CustList" Then
            If optFindByCustNumber.Checked = True Then
                If chkViewActiveCust.CheckState = System.Windows.Forms.CheckState.Checked Then
                    Me.bndCustomer.Filter = "[Status-code] = '" & "P" & "'"
                    Me.bndCustomer.Sort = "[Cust-no]"
                ElseIf chkViewActiveCust.CheckState = System.Windows.Forms.CheckState.Unchecked Then
                    Me.bndCustomer.Filter = "[status-code] Is Not Null"
                    Me.bndCustomer.Sort = "Cust-no"
                End If
            ElseIf optFindByCustName.Checked = True Then
                If chkViewActiveCust.CheckState = System.Windows.Forms.CheckState.Checked Then
                    Me.bndCustomer.Filter = "[Status-code] = '" & "P" & "'"
                    Me.bndCustomer.Sort = "Name"
                ElseIf chkViewActiveCust.CheckState = System.Windows.Forms.CheckState.Unchecked Then
                    Me.bndCustomer.Filter = "[status-code] Is Not Null"
                    Me.bndCustomer.Sort = "Name"
                End If
            End If
        End If

        'Refresh the worksheet datagridview
        If bndCustomer.Count > 0 Then
            GetWorksheetData(Mid(Ws_ord_headTableAdapter.Adapter.SelectCommand.CommandText, 1, Len(Ws_ord_headTableAdapter.Adapter.SelectCommand.CommandText) - 2) & "'" & bndCustomer.Current("cust-no") & "'" & ")")
        End If

        If lCustToWs Then Exit Sub
        If fromLocation <> "" Then
            If Trim(cCustNumber) <> "" Then
                x = FindCust("CustNumber", cCustNumber)
            End If
        End If
        cCustNumber = vbNullString
        If Len(Trim(txtCustNo.Text)) = 0 Then
            tabCustInfo.SelectedIndex = 0
        Else
            tabCustInfo.SelectedIndex = current_tab
        End If

        If Len(Trim(dblShipNoList.Text)) = 0 Then
            System.Windows.Forms.SendKeys.SendWait("{down}")
        End If
        If Len(Trim(cmbAutoCompleteCustName.Text)) = 0 Then
            cmbAutoCompleteCustName.Focus()
        End If
        cmdNewWs.Enabled = False
        cmbAutoCompleteCustName.ResetText()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    ''' <summary>
    ''' This procedure populates the current_tab variable which is used to remember which tab is currently displayed and will be displayed
    ''' again when the program comes back to this form.
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub frmCustInfo_Deactivate(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Deactivate
        current_tab = tabCustInfo.SelectedIndex
    End Sub

    ''' <summary>
    ''' This procedures fires when the form is closing.  It resets the data source for the grids so that the grids are empty when the 
    ''' program comes back to this form.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub frmCustInfo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        dgvASR.DataSource = Nothing
        dgvASR.Rows.Clear()
        dgvASR.Columns.Clear()
        dgvCustomerAppointments.DataSource = Nothing
        dgvCustomerMemos.DataSource = Nothing
        dgvHistory.DataSource = Nothing
        dgvNotes.DataSource = Nothing
        dgvWorksheets.DataSource = Nothing
        dgvOrders.DataSource = Nothing
        dgvPass.DataSource = Nothing
        Me.pnlHistoryGraphs.Visible = False

        cmdFirst.Enabled = False
        cmdPrevious.Enabled = False
        cmdNext.Enabled = False
        cmdLast.Enabled = False
        Me.lblName.Text = vbNullString
        chkViewActiveCust.Checked = True
        lblCustShipViaDesc.Text = Nothing
        lblShipViaDesc.Text = Nothing
        lblDblCnt.Text = Nothing
    End Sub

    ''' <summary>
    ''' This procedure will simulate a user pressing the tab key to move between fields when pressing the return key. 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub frmCustInfo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
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
    ''' This procedure is called when the form loads.  It will load customer data if the 'fromLocation' and cCustNumber variables are
    '''  not blank.  It also loads the customer combo box so the user can choose which customer to display.
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub frmCustInfo_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SaleForcDataSet.NotesComments' table. You can move, or remove it, as needed.
        Me.NotesCommentsTableAdapter.Fill(Me.SaleForcDataSet.NotesComments)
        flagAddNewCust = False
        flagEditNewCust = False
        flagCmdFinished = False
        lFlagNewLoad = True
        If Len(Trim(fromLocation)) > 0 Then
            FindCust("CustNumber", cCustNumber)
            fromLocation = ""
        Else
            Me.SaleForcDataSet.Customer.Clear()
            Me.SaleForcDataSet.CustomerSH.Clear()
            FillCustomerComboBox()

            setFormViewStatus((1))
            chkNoOrderWs.CheckState = System.Windows.Forms.CheckState.Unchecked

            If optFindByCustName.Checked = True Then
                Me.cmbAutoCompleteCustName.Focus()
            ElseIf optFindByCustNumber.Checked = True Then
                Me.txtCustID.Focus()
            End If
            formloaded = True
        End If
    End Sub

    ''' <summary>
    ''' This procedure will fire when the user has changes the Selected Ship To 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks>If the selected ship to is the default the text will be red otherwise the text will be blue.</remarks>

    Private Sub txtSelectedShip_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSelectedShip.TextChanged
        If txtSelectedShip.Text = lblDefaultShip.Text Then
            txtSelectedShip.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFF)
        Else
            txtSelectedShip.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFF0000)
        End If
    End Sub

    ''' <summary>
    ''' This procedure will set the focus to the Customer text box if the user leaves the Customer text box without typing in a name.
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub mebName_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        If flagCmdFinished Then Exit Sub
        If Len(Trim(mebName.Text)) = 0 Then
            mebName.Focus()
        End If
    End Sub

    ''' <summary>
    ''' This procedure updates the Customer Status table when the user leaves a cell in the 'ASR' grid
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>This procedure allows the user to create records in the Customer Status table.  This is part of the process of 
    ''' creating the customer's ASR (Account Status Report)</remarks>

    Private Sub dgvASR_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvASR.CellEndEdit
        Dim sql As String
        Dim daSalesman As New SaleForcDataSetTableAdapters.SalesmanTableAdapter
        Dim daProdType As New SaleForcDataSetTableAdapters.ProdTypeTableAdapter
        Dim daCustStatus As New SaleForcDataSetTableAdapters.CustomerStatusTableAdapter

        Dim dtSalesman As SaleForcDataSet.SalesmanDataTable
        Dim dtProdType As SaleForcDataSet.ProdTypeDataTable
        Dim dtCustStatus As SaleForcDataSet.CustomerStatusDataTable

        If e Is Nothing Then Exit Sub

        If lastcellvalue = "" And e.ColumnIndex = 7 And dgvASR(e.ColumnIndex, e.RowIndex).Value = "" Then
            Exit Sub
        ElseIf (e.ColumnIndex = 7 And (dgvASR(e.ColumnIndex, e.RowIndex).EditedFormattedValue > "" Or dgvASR(e.ColumnIndex, e.RowIndex).Value > "")) Or (e.ColumnIndex = 7 And lastcellvalue > "") Then
            'If dgvASR(e.ColumnIndex, e.RowIndex).Value = dgvASR(e.ColumnIndex, e.RowIndex).EditedFormattedValue Then Exit Sub
            SaleForcDataSet.EnforceConstraints = False
            dtSalesman = daSalesman.GetData()
            dtProdType = daProdType.GetData()
            dtCustStatus = daCustStatus.GetData()
            SaleForcDataSet.EnforceConstraints = True

            Dim foundprodtype As DataRow() = dtProdType.Select("[prodtype] = '" & dgvASR.Rows.Item(dgvASR.CurrentCell.RowIndex).Cells(0).Value & "'")
            Dim foundcuststatus As DataRow() = dtCustStatus.Select("[cust-no] = '" & Me.txtCustNo.Text & "' AND [season] = '" & dtSalesman.Rows(0)("season") & "' AND [prodtype] = '" & foundprodtype(0)("prodtype") & "' AND [ordercode] Is Null AND [stcode] = 'ordr'")

            If foundcuststatus.Length = 0 Then
                sql = "INSERT INTO CustomerStatus ([cust-no],[season],[prodtype],[statuscomments],[stcode]) VALUES ('" & Me.txtCustNo.Text & "', '" & dtSalesman.Rows(0)("season") & "', '" & foundprodtype(0)("prodtype") & "', " & Chr(34) & dgvASR.Item(e.ColumnIndex, e.RowIndex).EditedFormattedValue & Chr(34) & ", 'ordr')"
                Dim conn As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
                Dim com As New OleDb.OleDbCommand(sql, conn)
                conn.Open()
                com.ExecuteNonQuery()
                conn.Close()
            Else
                sql = "UPDATE [customerstatus] SET [statuscomments] = " & Chr(34) & dgvASR(e.ColumnIndex, e.RowIndex).EditedFormattedValue & Chr(34) & " WHERE [cust-no] = '" & bndCustomer.Current("cust-no") & "' and [season]  = '" & dtSalesman.Rows(0)("season") & "' and [prodtype] = '" & foundprodtype(0)("prodtype") & "' and [stcode] = 'ordr'"
                Dim conn As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
                Dim com As New OleDb.OleDbCommand(sql, conn)
                conn.Open()
                com.ExecuteNonQuery()
                conn.Close()
            End If
        End If
    End Sub

    ''' <summary>
    ''' This procedures gets called when leaving a cell in the 'ASR' grid and sets a variable 'lastcellvalue' to the value of that cell
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub dtgASR_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvASR.CellLeave
        If dgvASR.CurrentCell.ColumnIndex = 7 Then
            lastcellvalue = dgvASR.CurrentCell.Value
        End If
    End Sub

    ''' <summary>
    ''' This procedure will display data for the Spring season in the 'ASR' history graphs
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub optSpring_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optSpring.CheckedChanged
        If eventSender.Checked Then
            Dim cn As New OleDb.OleDbConnection
            Dim daSalesman As OleDb.OleDbDataAdapter
            Dim daSeason As OleDb.OleDbDataAdapter
            Dim dtSalesman As New DataTable
            Dim dtSeason As New DataTable

            cn.ConnectionString = MySettings.Default("SaleForcConnectionString")
            cn.Open()

            Dim tmpOppSeasonType As String
            Dim tmpSeason As String

            daSalesman = New OleDb.OleDbDataAdapter("SELECT [season] FROM [salesman]", cn)
            daSalesman.Fill(dtSalesman)

            daSeason = New OleDb.OleDbDataAdapter("SELECT [season], [seasontype] FROM [season] WHERE [season] = '" & dtSalesman.Rows(0)("season") & "'", cn)
            daSeason.Fill(dtSeason)

            If dtSeason.Rows(0)("seasontype") = "F" Then
                tmpOppSeasonType = GetProgramDefaults(dtSeason.Rows(0)("seasontype"))
                tmpSeason = GetSeason(dtSalesman.Rows(0)("season"), 1, tmpOppSeasonType)
            Else
                tmpSeason = dtSalesman.Rows(0)("season")
            End If

            CreateHistoryGraphs((tmpSeason))
            cn.Close()
            cn.Dispose()
        End If
    End Sub

    ''' <summary>
    ''' This procedure will display data for the Fall season in the 'ASR' history graphs
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub optFall_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optFall.CheckedChanged
        If eventSender.Checked Then
            Dim cn As New OleDb.OleDbConnection
            Dim daSalesman As OleDb.OleDbDataAdapter
            Dim daSeason As OleDb.OleDbDataAdapter
            Dim dtSalesman As New DataTable
            Dim dtSeason As New DataTable

            cn.ConnectionString = MySettings.Default("SaleForcConnectionString")
            cn.Open()

            Dim tmpOppSeasonType As String
            Dim tmpSeason As String

            daSalesman = New OleDb.OleDbDataAdapter("SELECT [season] FROM [salesman]", cn)
            daSalesman.Fill(dtSalesman)

            daSeason = New OleDb.OleDbDataAdapter("SELECT [season], [seasontype] FROM [season] WHERE [season] = '" & dtSalesman.Rows(0)("season") & "'", cn)
            daSeason.Fill(dtSeason)

            If dtSeason.Rows(0)("seasontype") = "S" Then
                tmpOppSeasonType = GetProgramDefaults(dtSeason.Rows(0)("seasontype"))
                tmpSeason = GetSeason(dtSalesman.Rows(0)("season"), 1, tmpOppSeasonType)
            Else
                tmpSeason = dtSalesman.Rows(0)("season")
            End If

            CreateHistoryGraphs((tmpSeason))
            cn.Close()
            cn.Dispose()
        End If

    End Sub

    ''' <summary>
    ''' This procedures fires when a user selects a tab and hides/shows components in response to the user's selection
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub tabCustInfo_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tabCustInfo.SelectedIndexChanged
        Static PreviousTab As Short = tabCustInfo.SelectedIndex()
        '    If Not cFlagCustStatus = "N" Then Exit Sub
        If PreviousTab = 5 Then
            Me.cmdNext.Visible = True
            Me.cmdPrevious.Visible = True
            Me.cmdFirst.Visible = True
            Me.cmdLast.Visible = True
        End If
        If tabCustInfo.SelectedIndex = 0 Then
            cmdNewCustEdit.Visible = True
        Else
            cmdNewCustEdit.Visible = False
        End If
        If tabCustInfo.SelectedIndex = 7 Then
            If cmbASRView.SelectedIndex = 0 Then
                cmbASRView_SelectedIndexChanged(cmbASRView, New System.EventArgs())
            Else
                cmbASRView.SelectedIndex = 0
            End If
        Else
            optSpring.Visible = False
            optFall.Visible = False
            cmdPrintGraphs.Visible = False
        End If
        PreviousTab = tabCustInfo.SelectedIndex()
    End Sub

    ''' <summary>
    ''' Timer1 is currently disabled.  However, when it is enabled, this procedure will fire when Timer1's time interval has elapsed.  
    ''' It looks to see if Outlook is open and brings the Outlook window to the front of the display.
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
        Dim myprocess As Process

        For Each myprocess In Process.GetProcesses
            If InStr(myprocess.ProcessName, "Outlook", Microsoft.VisualBasic.CompareMethod.Text) Then
                If myprocess.MainWindowTitle > "" Then
                    AppActivate(myprocess.Id)
                    Exit For
                End If
            End If
        Next
    End Sub

    ''' <summary>
    ''' This procedures sets different views of components based on the value of the 'StatNo' parameter
    ''' </summary>
    ''' <param name="StatNo"></param>
    ''' <remarks></remarks>

    Private Sub setFormViewStatus(ByRef StatNo As Short)
        Select Case StatNo
            Case 1 '(form start, existing or transmitted customers)
                fraNewCust.Visible = False
                fraFileCust.Visible = True
                fraSortOrder.Visible = True
                cmbAutoCompleteCustName.Visible = True
                txtCustID.Visible = True
                optFindByCustNumber.Visible = True
                optFindByCustName.Visible = True
                cmdFirst.Visible = True
                cmdPrevious.Visible = True
                cmdNext.Visible = True
                cmdLast.Visible = True
                btnMap.Visible = True
                btnGo.Visible = True
                btnExitCustInfo.Visible = True
                setCmdNewWsStatus()
                cmdNewCust.Visible = True
                cmdNewCustEdit.Visible = False

                tabCustInfo.TabPages.Item(0).Enabled = True
                tabCustInfo.TabPages.Item(1).Enabled = True
                tabCustInfo.TabPages.Item(2).Enabled = True
                tabCustInfo.TabPages.Item(3).Enabled = True
                tabCustInfo.TabPages.Item(4).Enabled = True

            Case 2 ' A saved new customer before transmitting (enable editing)
                fraNewCust.Visible = False
                fraFileCust.Visible = True

                btnExitCustInfo.Visible = True
                cmdNewWs.Visible = True
                cmdNewCust.Visible = True
                cmdNewCustEdit.Visible = True
                cmbAutoCompleteCustName.Visible = True
                txtCustID.Visible = True
                optFindByCustNumber.Visible = True
                optFindByCustName.Visible = True
                cmdFirst.Visible = True
                cmdPrevious.Visible = True
                cmdNext.Visible = True
                cmdLast.Visible = True
                btnMap.Visible = True

                tabCustInfo.TabPages.Item(1).Enabled = True
                tabCustInfo.TabPages.Item(2).Enabled = True
                tabCustInfo.TabPages.Item(3).Enabled = False
                tabCustInfo.TabPages.Item(4).Enabled = False

            Case 3 ' New customer Add or Edit
                fraNewCust.Visible = True
                fraFileCust.Visible = False

                btnExitCustInfo.Visible = False
                cmdNewWs.Visible = False
                cmdNewCust.Visible = False
                cmdNewCustEdit.Visible = False
                cmbAutoCompleteCustName.Visible = False
                txtCustID.Visible = False
                optFindByCustNumber.Visible = False
                optFindByCustName.Visible = False
                cmdFirst.Visible = False
                cmdPrevious.Visible = False
                cmdNext.Visible = False
                cmdLast.Visible = False
                btnGo.Visible = False
                btnMap.Visible = False

                tabCustInfo.TabPages.Item(1).Enabled = False
                tabCustInfo.TabPages.Item(2).Enabled = False
                tabCustInfo.TabPages.Item(3).Enabled = False
                tabCustInfo.TabPages.Item(4).Enabled = False
        End Select
    End Sub

    ''' <summary>
    ''' This procedure will change the view of the display based on the status of the customer
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub setFvStatusNewRec()
        Select Case UCase(Me.bndCustomer.Current("status-code"))
            Case "N"
                setFormViewStatus(2)
            Case "X"
                setFormViewStatus(1)
            Case Else
                setFormViewStatus(1)
        End Select
    End Sub

    ''' <summary>
    ''' This procedure clears the display fields for the components that display Customer data
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub clrCustFields()
        txtCustNo.Text = vbNullString
        lblName.Text = vbNullString
        lblAddr1.Text = vbNullString
        lblAddr2.Text = vbNullString
        lblAddr3.Text = vbNullString
        lblCity.Text = vbNullString
        lblState.Text = vbNullString
        lblZipCode.Text = vbNullString
        lblCountry.Text = vbNullString
        lblCustEmail.Text = vbNullString
        lblCustShipVia.Text = vbNullString
        lblCustShipViaDesc.Text = vbNullString
        lblPhoneNo.Text = vbNullString
        lblFaxNo.Text = vbNullString
        lblContact.Text = vbNullString
        lblCustContactEmail.Text = vbNullString
        txtCustStatusCd.Text = vbNullString
        lblCustomerName.Text = vbNullString
    End Sub

    ''' <summary>
    ''' This procedure clears the display fields for the components that display the Customer Ship To data
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub clrShipFields()
        lblDblCnt.Text = vbNullString
        lblDefaultShip.Text = vbNullString
        txtSelectedShip.Text = vbNullString
        lblShipName.Text = vbNullString
        lblShipAddr1.Text = vbNullString
        lblShipAddr2.Text = vbNullString
        lblShipAddr3.Text = vbNullString
        lblShipCity.Text = vbNullString
        lblShipSt.Text = vbNullString
        lblShipZipcode.Text = vbNullString
        lblShipPhone.Text = vbNullString
        lblShipFax.Text = vbNullString
        lblShipContact.Text = vbNullString
        '    lblShipCustNo.Caption = vbNullString
        '    lblShipNo.Caption = vbNullString
        lblShipCountry.Text = vbNullString
        lblCustSHEmail.Text = vbNullString
        lblShipViaCd.Text = vbNullString
        lblShipViaDesc.Text = vbNullString
        lblCustSHContactEmail.Text = vbNullString
        txtShipStatusCd.Text = vbNullString
        Me.dblShipNoList.DataSource = Nothing
        cmbCustomerWebsites.ResetText()
        cmbCustomerWebsites.Items.Clear()
        Me.WebBrowser1.Navigate("about:blank")
    End Sub

    ''' <summary>
    ''' This procedure clears the fields for the components that display the Customer and Customer Ship To data
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub clrNewCustForm()
        Dim cMask As String
        lblTempCustNo.Text = vbNullString
        lblTempShipNo.Text = vbNullString

        cMask = mebName.Mask
        mebName.Mask = vbNullString
        mebName.Text = vbNullString
        mebName.Mask = cMask
        cMask = mebAddr1.Mask
        mebAddr1.Mask = vbNullString
        mebAddr1.Text = vbNullString
        mebAddr1.Mask = cMask
        cMask = mebAddr2.Mask
        mebAddr2.Mask = vbNullString
        mebAddr2.Text = vbNullString
        mebAddr2.Mask = cMask
        cMask = mebAddr3.Mask
        mebAddr3.Mask = vbNullString
        mebAddr3.Text = vbNullString
        mebAddr3.Mask = cMask
        cMask = mebCity.Mask
        mebCity.Mask = vbNullString
        mebCity.Text = vbNullString
        mebCity.Mask = cMask
        cMask = mebState.Mask
        mebState.Mask = vbNullString
        mebState.Text = vbNullString
        mebState.Mask = cMask
        cMask = mebZipCode.Mask
        mebZipCode.Mask = vbNullString
        mebZipCode.Text = vbNullString
        mebZipCode.Mask = cMask
        cMask = mebPhoneNo.Mask
        mebPhoneNo.Mask = vbNullString
        mebPhoneNo.Text = vbNullString
        mebPhoneNo.Mask = cMask
        cMask = mebFaxNo.Mask
        mebFaxNo.Mask = vbNullString
        mebFaxNo.Text = vbNullString
        mebFaxNo.Mask = cMask
        cMask = mebContact.Mask
        mebContact.Mask = vbNullString
        mebContact.Text = vbNullString
        mebContact.Mask = cMask
        cMask = mebCustEmail.Mask
        mebCustEmail.Mask = vbNullString
        mebCustEmail.Text = vbNullString
        mebCustEmail.Mask = cMask
        cMask = mebCustContactEmail.Mask
        mebCustContactEmail.Mask = vbNullString
        mebCustContactEmail.Text = vbNullString
        mebCustContactEmail.Mask = cMask

        cMask = mebShipName.Mask
        mebShipName.Mask = vbNullString
        mebShipName.Text = vbNullString
        mebShipName.Mask = cMask
        cMask = mebShipAddr1.Mask
        mebShipAddr1.Mask = vbNullString
        mebShipAddr1.Text = vbNullString
        mebShipAddr1.Mask = cMask
        cMask = mebShipAddr2.Mask
        mebShipAddr2.Mask = vbNullString
        mebShipAddr2.Text = vbNullString
        mebShipAddr2.Mask = cMask
        cMask = mebShipAddr3.Mask
        mebShipAddr3.Mask = vbNullString
        mebShipAddr3.Text = vbNullString
        mebShipAddr3.Mask = cMask
        cMask = mebShipCity.Mask
        mebShipCity.Mask = vbNullString
        mebShipCity.Text = vbNullString
        mebShipCity.Mask = cMask
        cMask = mebShipSt.Mask
        mebShipSt.Mask = vbNullString
        mebShipSt.Text = vbNullString
        mebShipSt.Mask = cMask
        cMask = mebShipZipCode.Mask
        mebShipZipCode.Mask = vbNullString
        mebShipZipCode.Text = vbNullString
        mebShipZipCode.Mask = cMask
        cMask = mebShipPhone.Mask
        mebShipPhone.Mask = vbNullString
        mebShipPhone.Text = vbNullString
        mebShipPhone.Mask = cMask
        cMask = mebShipFax.Mask
        mebShipFax.Mask = vbNullString
        mebShipFax.Text = vbNullString
        mebShipFax.Mask = cMask
        cMask = mebShipContact.Mask
        mebShipContact.Mask = vbNullString
        mebShipContact.Text = vbNullString
        mebShipContact.Mask = cMask
        cMask = mebWebsite.Mask
        mebWebsite.Mask = vbNullString
        mebWebsite.Text = vbNullString
        mebWebsite.Mask = cMask
        cMask = mebCustShEmail.Mask
        mebCustShEmail.Mask = vbNullString
        mebCustShEmail.Text = vbNullString
        mebCustShEmail.Mask = cMask
        cMask = mebCustShContactEmail.Mask
        mebCustShContactEmail.Mask = vbNullString
        mebCustShContactEmail.Text = vbNullString
        mebCustShContactEmail.Mask = cMask

    End Sub

    ''' <summary>
    ''' This procedures updates variables that are used when saving Customer information
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub saveNewCust()
        'getSlsmnInitData() ' should not make this call
        cCustNo = lblTempCustNo.Text
        cCustName = mebName.Text
        cCustAddr1 = mebAddr1.Text
        cCustAddr2 = mebAddr2.Text
        cCustAddr3 = mebAddr3.Text
        cCustCity = mebCity.Text
        cCustSt = mebState.Text
        cCustZip = mebZipCode.Text
        cCustCountry = vbNullString
        cCustEmail = mebCustEmail.Text
        cCustContactEmail = mebCustContactEmail.Text
        cCustShipViaCd = cViaCode
        If mebPhoneNo.Text = "___-___-____" Then
            cCustPhoneNo = vbNullString
        Else
            cCustPhoneNo = mebPhoneNo.Text
        End If
        If mebFaxNo.Text = "___-___-____" Then
            cCustFaxNo = vbNullString
        Else
            cCustFaxNo = mebFaxNo.Text
        End If
        cCustContact = mebContact.Text
        cCustStatusCd = "N"
        cCustCustSh = lblTempCustNo.Text
        cCustTypeCd = vbNullString
        cCustTermCd = cTermCode
        cCustCreditRating = vbNullString
        cCustHoldArCode = vbNullString
        nCustArBalance = 0
        lCustDelq = False
        nCustAvgDaysPay = 0
        cCustLastPayDate = vbNullString
        nCustLastPayAmt = 0
        nCustOpenOrdTot = 0
        cCustLastOrdDate = vbNullString
        cCustChargeCust = vbNullString
        cCustMailCust = vbNullString
        cCustStatsCust = vbNullString
        cCustAddDate = vbNullString
        cCustLastChgDate = vbNullString
        cCustSlsmnRating = vbNullString
        cCustSlsmnCd = vbNullString
        If flagAddNewCust Then saveNewCustData()
        If flagEditNewCust Then SaveEditedCustData()
    End Sub

    ''' <summary>
    ''' This procedures updates variables that are used when saving Customer Ship To information
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub SaveNewCustShip()
        'getSlsmnInitData()
        If Len(Trim(lblTempShipNo.Text)) = 0 Then
            cShipNo = lblTempCustNo.Text
        Else
            cShipNo = lblTempShipNo.Text
        End If
        If Len(Trim(mebShipName.Text)) = 0 Then
            cShipName = mebName.Text
        Else
            cShipName = mebShipName.Text
        End If

        cShipAddr1 = mebShipAddr1.Text
        cShipAddr2 = mebShipAddr2.Text
        cShipAddr3 = mebShipAddr3.Text
        cShipCity = mebShipCity.Text
        cShipSt = mebShipSt.Text
        cShipZip = mebShipZipCode.Text
        cShipCountry = ""
        cShipWebsite = mebWebsite.Text
        cShipEmail = mebCustShEmail.Text
        cShipContactEmail = mebCustShContactEmail.Text
        cShipShipViaCd = cViaCode
        If mebShipPhone.Text = "___-___-____" Then
            cShipPhoneNo = ""
        Else
            cShipPhoneNo = mebShipPhone.Text
        End If
        If mebShipFax.Text = "___-___-____" Then
            cShipFaxNo = ""
        Else
            cShipFaxNo = mebShipFax.Text
        End If
        cShipContact = mebShipContact.Text
        cShipStatusCd = "N"
        cShipTypeCd = ""
        cShipTermCd = cTermCode
        cHoldShipCd = ""
        If flagAddNewCust Then saveNewShipData()
        If flagEditNewCust Then SaveEditedCustShipData()
    End Sub

    ''' <summary>
    ''' This procedures creates a record in the Customer table and writes the data from the form to the record
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub saveNewCustData()
        Dim con As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        Dim sql As String
        Dim daNewCust As New SaleForcDataSetTableAdapters.CustomerTableAdapter
        Dim newCustRow As SaleForcDataSet.CustomerRow

        con.ConnectionString = MySettings.Default("SaleForcConnectionString")
        con.Open()

        sql = "SELECT * FROM Customer WHERE [cust-no] = '" & cCustNo & "'"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(dt)
        con.Close()

        If dt.Rows.Count = 0 Then
            newCustRow = SaleForcDataSet.Customer.NewCustomerRow
            newCustRow._Cust_no = cCustNo
        Else
            MsgBox("Customer cannot be created, customer number " & cCustNo & " already exists!", MsgBoxStyle.Critical, "Add new customer")
            Exit Sub
        End If
        newCustRow.Name = cCustName
        newCustRow.Address1 = cCustAddr1
        newCustRow.Address2 = cCustAddr2
        newCustRow.Address3 = cCustAddr3
        newCustRow.City = cCustCity
        newCustRow.St = cCustSt
        newCustRow._Zip_code = cCustZip
        newCustRow._Via_code = cCustShipViaCd
        newCustRow.Country = cCustCountry
        newCustRow.Telephone = cCustPhoneNo
        newCustRow._Fax_num = cCustFaxNo
        newCustRow.Contact = cCustContact
        newCustRow._Status_code = cCustStatusCd
        newCustRow._Slsmn_code = cCustSlsmnCd
        newCustRow._Type_code = cCustTypeCd
        newCustRow._Term_code = cCustTermCd
        newCustRow._Cred_rating = cCustCreditRating
        newCustRow._Charge_cust = cCustChargeCust
        newCustRow._Mail_cust = cCustMailCust
        newCustRow._Status_code = cCustStatusCd
        newCustRow._Sort_name = ""
        newCustRow._Cust_sh = cCustCustSh
        newCustRow.Email = cCustEmail
        newCustRow._Contact_email = cCustContactEmail
        If IsDate(cCustAddDate) Then
            newCustRow._cust_addate = cCustAddDate
        End If
        newCustRow._Hold_ar_code = ""
        newCustRow.Delq = False
        newCustRow._Slsmn_rating = ""
        newCustRow.ArBalance = 0
        newCustRow.LastPayAmt = 0
        newCustRow.AvgDaysPay = 0
        newCustRow.OpenOrdTot = 0
        newCustRow.LabelNo = ""

        If IsDate(cCustLastUpdte) Then
            newCustRow.LastUpdated = cCustLastUpdte
        Else
            newCustRow.LastUpdated = Today
        End If
        SaleForcDataSet.Customer.Rows.Add(newCustRow)
        daNewCust.Update(Me.SaleForcDataSet)
        SaleForcDataSet.Customer.AcceptChanges()
    End Sub

    ''' <summary>
    ''' This procedures modifies a record in the Customer table and writes the data from the form to the record
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub SaveEditedCustData()
        Dim daCustomer As New SaleForcDataSetTableAdapters.CustomerTableAdapter
        Dim custTable As SaleForcDataSet.CustomerDataTable
        Dim custRow As SaleForcDataSet.CustomerRow

        custTable = daCustomer.GetData()
        custRow = custTable.FindBy_Cust_noName(cCustNo, cCustName)
        custRow.BeginEdit()
        custRow._Cust_no = cCustNo
        custRow.Name = cCustName
        custRow.Address1 = cCustAddr1
        custRow.Address2 = cCustAddr2
        custRow.Address3 = cCustAddr3
        custRow.City = cCustCity
        custRow.St = cCustSt
        custRow._Zip_code = cCustZip
        custRow._Via_code = cCustShipViaCd
        custRow.Country = cCustCountry
        custRow.Telephone = cCustPhoneNo
        custRow._Fax_num = cCustFaxNo
        custRow.Contact = cCustContact
        custRow._Status_code = cCustStatusCd
        custRow._Slsmn_code = cCustSlsmnCd
        custRow._Type_code = cCustTypeCd
        custRow._Term_code = cCustTermCd
        custRow._Cred_rating = cCustCreditRating
        custRow._Charge_cust = cCustChargeCust
        custRow._Mail_cust = cCustMailCust
        custRow._Status_code = cCustStatusCd
        custRow._Sort_name = ""
        custRow._Cust_sh = cCustCustSh
        custRow.Email = cCustEmail
        custRow._Contact_email = cCustContactEmail

        If IsDate(cCustAddDate) Then
            custRow._cust_addate = cCustAddDate
        End If
        custRow._Hold_ar_code = ""
        custRow.Delq = False
        custRow._Slsmn_rating = ""
        custRow.ArBalance = 0
        custRow.LastPayAmt = 0
        custRow.AvgDaysPay = 0
        custRow.OpenOrdTot = 0
        custRow.LabelNo = ""

        If IsDate(cCustLastUpdte) Then
            custRow.LastUpdated = cCustLastUpdte
        Else
            custRow.LastUpdated = Today
        End If
        custRow.EndEdit()
        daCustomer.Update(custRow)
    End Sub

    ''' <summary>
    ''' This procedures creates a record in the Customer Ship To table and writes the data from the form to the record 
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub saveNewShipData()
        Dim con As New OleDb.OleDbConnection
        Dim da As New OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        Dim sql As String
        Dim daNewCustomerSh As New SaleForcDataSetTableAdapters.CustomerSHTableAdapter
        Dim newCustomerShRow As SaleForcDataSet.CustomerSHRow = Nothing

        con.ConnectionString = MySettings.Default("SaleForcConnectionString")
        con.Open()
        sql = "SELECT * FROM CustomerSh WHERE [cust-no] = '" & cCustNo & "' AND [cust-sh] = '" & cShipNo & "'"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(dt)
        con.Close()

        If dt.Rows.Count = 0 Then
            newCustomerShRow = SaleForcDataSet.CustomerSH.NewCustomerSHRow
            newCustomerShRow._Cust_no = cCustNo
            newCustomerShRow._Cust_sh = cShipNo
        End If

        newCustomerShRow.Name = cShipName
        newCustomerShRow.Address1 = cShipAddr1
        newCustomerShRow.Address2 = cShipAddr2
        newCustomerShRow.Address3 = cShipAddr3
        newCustomerShRow.City = cShipCity
        newCustomerShRow.St = cShipSt
        newCustomerShRow._Zip_code = cShipZip
        newCustomerShRow._Via_code = cShipShipViaCd
        newCustomerShRow.Country = cShipCountry
        newCustomerShRow.Telephone = cShipPhoneNo
        newCustomerShRow.Contact = cShipContact
        newCustomerShRow._Status_code = cShipStatusCd
        newCustomerShRow._Type_code = cShipTypeCd
        newCustomerShRow._Term_code = cShipTermCd
        newCustomerShRow.Complete = lShipComplete
        newCustomerShRow.ShipActive = lShipActive
        newCustomerShRow.HoldShipCode = cHoldShipCd
        newCustomerShRow._Fax_num = cShipFaxNo
        newCustomerShRow.Website = cShipWebsite
        newCustomerShRow.email = cShipEmail
        newCustomerShRow._Contact_email = cShipContactEmail

        If IsDate(cShipLastUpdate) Then
            newCustomerShRow.LastUpDate = cShipLastUpdate
        Else
            newCustomerShRow.LastUpDate = Today
        End If
        SaleForcDataSet.CustomerSH.Rows.Add(newCustomerShRow)
        daNewCustomerSh.Update(Me.SaleForcDataSet)
        SaleForcDataSet.CustomerSH.AcceptChanges()
    End Sub

    ''' <summary>
    ''' This procedures modifies a record in the Customer Ship To table and writes the data from the form to the record
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub SaveEditedCustShipData()
        Dim daCustShip As New SaleForcDataSetTableAdapters.CustomerSHTableAdapter
        Dim custshipTable As SaleForcDataSet.CustomerSHDataTable
        Dim custshipRow As SaleForcDataSet.CustomerSHRow

        custshipTable = daCustShip.GetData()
        custshipRow = custshipTable.FindBy_Cust_no_Cust_sh(cCustNo, cShipNo)
        custshipRow.BeginEdit()
        custshipRow._Cust_no = cCustNo
        custshipRow._Cust_sh = cShipNo
        custshipRow.Name = cShipName
        custshipRow.Address1 = cShipAddr1
        custshipRow.Address2 = cShipAddr2
        custshipRow.Address3 = cShipAddr3
        custshipRow.City = cShipCity
        custshipRow.St = cShipSt
        custshipRow._Zip_code = cShipZip
        custshipRow._Via_code = cShipShipViaCd
        custshipRow.Country = cShipCountry
        custshipRow.Telephone = cShipPhoneNo
        custshipRow.Contact = cShipContact
        custshipRow._Status_code = cShipStatusCd
        custshipRow._Type_code = cShipTypeCd
        custshipRow._Term_code = cShipTermCd
        custshipRow.Complete = lShipComplete
        custshipRow.ShipActive = lShipActive
        custshipRow.HoldShipCode = cHoldShipCd
        custshipRow._Fax_num = cShipFaxNo
        custshipRow.Website = cShipWebsite
        custshipRow.email = cShipEmail
        custshipRow._Contact_email = cShipContactEmail
        If IsDate(cShipLastUpdate) Then
            custshipRow.LastUpDate = cShipLastUpdate
        Else
            custshipRow.LastUpDate = Today
        End If
        custshipRow.EndEdit()
        daCustShip.Update(custshipRow)
    End Sub

    ''' <summary>
    ''' This procedure is no longer in use
    ''' </summary>
    ''' <param name="CustType"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Private Function msgCreateNewWs(ByRef CustType As String) As Boolean
        Dim msg As String
        Dim msgStyle As Short
        Dim msgTitle As String
        Dim msgResponse As Short

        msg = "You are about to create a NEW worksheet for:" & vbCrLf & vbCrLf

        Select Case CustType
            Case "EC" ' File customer ----------------------------
                msg = msg & "Customer ..: " & txtCustNo.Text & "    " & lblName.Text & vbCrLf
                msg = msg & "Shipping to: " & dblShipNoList.Text & "    " & lblShipName.Text & vbCrLf & vbCrLf

            Case "NC" ' New Customer (from fresh entry of data) -------
                msg = msg & "Customer ..: " & lblTempCustNo.Text & " " & mebName.Text & vbCrLf
                msg = msg & "Shipping to: " & lblTempShipNo.Text & " " & mebShipName.Text & vbCrLf & vbCrLf
        End Select

        msg = msg & "Is this correct?"
        msgStyle = MsgBoxStyle.Question + MsgBoxStyle.YesNo
        msgTitle = "CREATE NEW WORKSHEET"
        msgResponse = MsgBox(msg, msgStyle, msgTitle)
        If msgResponse = MsgBoxResult.Yes Then
            msgCreateNewWs = True
        Else
            msgCreateNewWs = False
        End If
    End Function

    ''' <summary>
    ''' This procedure will load current customer data for modification by the user
    ''' </summary>
    ''' <remarks>When the user clicks on the 'edit' button, this procedures loads the data so that it can be modified as necessary</remarks>

    Private Sub loadNewCustEditScrn()
        lblTempCustNo.Text = txtCustNo.Text
        lblTempShipNo.Text = dblShipNoList.Text
        '    lblTCustShipViaDesc = lblCustShipViaDesc
        '    lblTShipViaDesc = lblShipViaDesc

        If IsDBNull(lblName.Text) Then
            mebName.Text = vbNullString
        Else
            mebName.SelectedText = lblName.Text
        End If

        If IsDBNull(lblAddr1.Text) Or Len(Trim(lblAddr1.Text)) = 0 Then
            mebAddr1.SelectedText = vbNullString
        Else
            mebAddr1.SelectedText = lblAddr1.Text
        End If

        If IsDBNull(lblAddr2.Text) Or Len(Trim(lblAddr2.Text)) = 0 Then
            mebAddr2.SelectedText = vbNullString
        Else
            mebAddr2.SelectedText = lblAddr2.Text
        End If

        If IsDBNull(lblAddr3.Text) Or Len(Trim(lblAddr3.Text)) = 0 Then
            mebAddr3.SelectedText = vbNullString
        Else
            mebAddr3.SelectedText = lblAddr3.Text
        End If

        If IsDBNull(lblCity.Text) Then
            mebCity.Text = vbNullString
        Else
            mebCity.SelectedText = lblCity.Text
        End If

        If IsDBNull(lblState.Text) Then
            mebState.Text = vbNullString
        Else
            mebState.SelectedText = lblState.Text
        End If

        If IsDBNull(lblZipCode.Text) Then
            mebZipCode.Text = vbNullString
        Else
            mebZipCode.SelectedText = lblZipCode.Text
        End If

        If IsDBNull(lblPhoneNo.Text) Then
            mebPhoneNo.Text = vbNullString
        Else
            If Trim(lblPhoneNo.Text) = vbNullString Then
                mebPhoneNo.SelectedText = lblPhoneNo.Text
            Else
                mebPhoneNo.Text = lblPhoneNo.Text
            End If
        End If

        If IsDBNull(lblFaxNo.Text) Then
            mebFaxNo.Text = vbNullString
        Else
            If Len(Trim(lblFaxNo.Text)) = 0 Then
                mebFaxNo.SelectedText = lblFaxNo.Text
            Else
                mebFaxNo.Text = lblFaxNo.Text
            End If
        End If

        If IsDBNull(lblContact.Text) Then
            mebContact.Text = vbNullString
        Else
            mebContact.SelectedText = lblContact.Text
        End If

        If IsDBNull(lblCustEmail.Text) Then
            mebCustEmail.Text = vbNullString
        Else
            mebCustEmail.SelectedText = lblCustEmail.Text
        End If

        If IsDBNull(lblCustContactEmail.Text) Then
            mebCustContactEmail.Text = vbNullString
        Else
            mebCustContactEmail.SelectedText = lblCustContactEmail.Text
        End If


        If IsDBNull(lblShipName.Text) Then
            mebShipName.Text = vbNullString
        Else
            mebShipName.SelectedText = lblShipName.Text
        End If

        If IsDBNull(lblShipAddr1.Text) Then
            mebShipAddr1.Text = vbNullString
        Else
            mebShipAddr1.SelectedText = lblShipAddr1.Text
        End If

        If IsDBNull(lblShipAddr2.Text) Then
            mebShipAddr2.Text = vbNullString
        Else
            mebShipAddr2.SelectedText = lblShipAddr2.Text
        End If

        If IsDBNull(lblShipAddr3.Text) Then
            mebShipAddr3.Text = vbNullString
        Else
            mebShipAddr3.SelectedText = lblShipAddr3.Text
        End If

        If IsDBNull(lblShipCity.Text) Then
            mebShipCity.Text = vbNullString
        Else
            mebShipCity.SelectedText = lblShipCity.Text
        End If

        If IsDBNull(lblShipSt.Text) Then
            mebShipSt.Text = vbNullString
        Else
            mebShipSt.SelectedText = lblShipSt.Text
        End If

        If IsDBNull(lblShipZipcode.Text) Then
            mebShipZipCode.Text = vbNullString
        Else
            mebShipZipCode.SelectedText = lblShipZipcode.Text
        End If

        If IsDBNull(lblShipPhone.Text) Then
            mebShipPhone.Text = vbNullString
        Else
            If Trim(lblShipPhone.Text) = vbNullString Then
                mebShipPhone.SelectedText = lblShipPhone.Text
            Else
                mebShipPhone.Text = lblShipPhone.Text
            End If
        End If

        If IsDBNull(lblShipFax.Text) Then
            mebShipFax.Text = vbNullString
        Else
            If Trim(lblShipFax.Text) = vbNullString Then
                mebShipFax.SelectedText = lblShipFax.Text
            Else
                mebShipFax.Text = lblShipFax.Text
            End If
        End If

        If IsDBNull(lblShipContact.Text) Then
            mebShipContact.Text = vbNullString
        Else
            mebShipContact.SelectedText = lblShipContact.Text
        End If

        If IsDBNull(lblCustSHEmail.Text) Then
            mebCustShEmail.Text = vbNullString
        Else
            mebCustShEmail.SelectedText = lblCustSHEmail.Text
        End If

        If IsDBNull(lblCustSHContactEmail.Text) Then
            mebCustShContactEmail.Text = vbNullString
        Else
            mebCustShContactEmail.SelectedText = lblCustSHContactEmail.Text
        End If

        If IsDBNull(lblCustSHWebsite.Text) Then
            '        mebCustShwebsite.Text = vbNullString
        Else
            mebWebsite.SelectedText = lblCustSHWebsite.Text
        End If
    End Sub

    ''' <summary>
    ''' This procedure finds records in the Customer Memo table and displays them in the Customer Memo datagrid
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub FindCustMemos()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Me.CustomerMemoTableAdapter.FillByCustNo(Me.SaleForcDataSet.CustomerMemo, txtCustNo.Text)
        Me.dgvCustomerMemos.DataSource = bndCustMemos
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    ''' <summary>
    ''' This procedure finds website information for the current customer and adds it to a combo box for the user to select a 
    ''' webpage to navigate to.
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub FindCustWebsites()
        Dim i As Integer
        Dim cn As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable

        If bndCustomerShip.Count = 0 Then Exit Sub

        If Me.cmbCustomerWebsites.Items.Count > 0 Then
            For i = 0 To (Me.cmbCustomerWebsites.Items.Count - 1)
                Me.cmbCustomerWebsites.Items.RemoveAt(0)
            Next
        End If

        Me.WebBrowser1.Navigate("about:blank")
        Me.cmbCustomerWebsites.ResetText()

        cn.Open()
        da = New OleDb.OleDbDataAdapter("SELECT [website] FROM [customersh] WHERE [cust-no] = '" & bndCustomerShip.Current("cust-no") & "'", cn)
        da.Fill(dt)

        For i = 0 To dt.Rows.Count - 1
            If Not IsDBNull(dt.Rows(i)("website")) Then
                If Len(Trim(dt.Rows(i)("website"))) > 0 Then
                    Me.cmbCustomerWebsites.Items.Add(dt.Rows(i)("website").ToString)
                End If
            End If
        Next

        If Me.cmbCustomerWebsites.Items.Count = 0 Then
            Me.lblNoWebsite.Text = Me.lblName.Text & " does not have a website registered at Knitcraft!"
        End If
        cn.Close()
    End Sub

    ''' <summary>
    ''' This procedures will enable or disable the "New Worksheet" button based on the status of the current customer or the number of
    ''' ship to addresses
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub setCmdNewWsStatus()
        'find the record associated with the selected ship to
        Dim itemfound As Integer = bndCustomerShip.Find("cust-sh", dblShipNoList.Text)
        If itemfound = -1 Then Exit Sub
        'move the record cursor to the found record
        bndCustomerShip.Position = itemfound

        cFlagShipStatus = UCase$(bndCustomerShip.Current("status-code"))
        If cFlagCustStatus = "I" Or cFlagShipStatus = "I" Then
            cmdNewWs.Visible = False
        Else
            cmdNewWs.Visible = True
            If bndCustomerShip.Count > 1 Then
                cmdNewWs.Enabled = False
            Else
                cmdNewWs.Enabled = True
            End If
        End If

    End Sub

    ''' <summary>
    ''' This procedure displays a progress bar.  The progress bar shows the loading progress of the customer's website
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub WebBrowser1_ProgressChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.WebBrowserProgressChangedEventArgs) Handles WebBrowser1.ProgressChanged
        Dim Progress As Integer = eventArgs.CurrentProgress
        Dim ProgressMax As Integer = eventArgs.MaximumProgress
        On Error Resume Next
        If Progress = -1 Then ProgressBar1.Value = 100
        Me.picLoadingWeb.Visible = False
        lblWebsiteLoading.Text = vbNullString
        Label66.Text = "Done"
        ProgressBar1.Visible = False
        If Progress > 0 And Progress < 1000000 And ProgressMax > 0 Then
            Me.picLoadingWeb.Visible = True
            ProgressBar1.Visible = True
            ProgressBar1.Value = Progress * 100 / ProgressMax
            Label66.Text = Int(Progress * 100 / ProgressMax) & "%"
            lblWebsiteLoading.Text = "Loading website for " & Me.bndCustomer.Current("name")
        End If
    End Sub

    ''' <summary>
    ''' This procedure is not in use
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Private Function IsPopupWindow() As Boolean
        On Error Resume Next
        If WebBrowser1.Document.DomDocument.activeElement.tagName = "BODY" Or WebBrowser1.Document.DomDocument.activeElement.tagName = "IFRAME" Then
            IsPopupWindow = True
        Else
            IsPopupWindow = False
        End If
    End Function

    ''' <summary>
    ''' This procedure creates and formats the labels for the ASR grid
    ''' </summary>
    ''' <param name="tmpDataGrid"></param>
    ''' <remarks></remarks>

    Private Sub CreateASRGrid(ByRef tmpDataGrid As DataGridView)
        Dim cn As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim daSalesman As OleDb.OleDbDataAdapter
        Dim daProdType As OleDb.OleDbDataAdapter
        Dim daSeason As OleDb.OleDbDataAdapter
        Dim dtSalesman As New DataTable
        Dim dtProdType As New DataTable
        Dim dtSeason As New DataTable
        Dim tmpProdType As String
        Dim i As Short
        Dim tmpOppSeasonType As String
        Dim tmpSSeason1yrago As String
        Dim tmpOSeason1yrago As String
        Dim tmpOSeason2yrsago As String

        cn.Open()

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        ' Get current season
        daSalesman = New OleDb.OleDbDataAdapter("SELECT [season] from [salesman]", cn)
        daSalesman.Fill(dtSalesman)

        ' Get Prod Types with projections for the current customer and season
        daProdType = New OleDb.OleDbDataAdapter("SELECT DISTINCTROW ProdType.Description, ProdType.ProdType FROM ProdType LEFT JOIN [Cust-seas-proj] ON ProdType.ProdType = [Cust-seas-proj].prodtype " & "WHERE (((ProdType.[disp-seq])>0)) OR ((([Cust-seas-proj].[cust-no])='" & Me.txtCustNo.Text & "') AND (([Cust-seas-proj].season)='" & dtSalesman.Rows(0)("season") & "')) ORDER BY ProdType.[disp-seq];", cn)
        daProdType.Fill(dtProdType)

        ' Get season type for current season
        daSeason = New OleDb.OleDbDataAdapter("SELECT [season], [seasontype] FROM [season] WHERE [season] = '" & dtSalesman.Rows(0)("season") & "'", cn)
        daSeason.Fill(dtSeason)

        If dtSeason.Rows.Count = 0 Then
            MessageBox.Show("Season '" & dtSalesman.Rows(0)("season") & "' doesn't exist - contact Sales Support!", "Season doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        tmpOppSeasonType = GetProgramDefaults(dtSeason.Rows(0)("seasontype"))
        tmpSSeason1yrago = GetSeason(dtSalesman.Rows(0)("season"), 1, dtSeason.Rows(0)("seasontype"))
        tmpOSeason1yrago = GetSeason(dtSalesman.Rows(0)("season"), 1, tmpOppSeasonType)
        tmpOSeason2yrsago = GetSeason(dtSalesman.Rows(0)("season"), 2, tmpOppSeasonType)

        If dtProdType.Rows.Count > 0 Then
            tmpDataGrid.RowCount = 1
        End If
        tmpDataGrid.RowCount = dtProdType.Rows.Count + 1
        tmpDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

        ' Setup column labels

        tmpDataGrid.Columns(0).Visible = False

        If tmpDataGrid.Name = "dgvASR" Then
            tmpDataGrid.ColumnCount = 8
            tmpDataGrid.Rows.Item(0).Cells(2).Value = UCase(dtSalesman.Rows(0)("season")) & " Goals"
            tmpDataGrid.Rows.Item(0).Cells(3).Value = UCase(dtSalesman.Rows(0)("season")) & " Actual"
            tmpDataGrid.Rows.Item(0).Cells(4).Value = UCase(dtSalesman.Rows(0)("season")) & " Actual - " & UCase(dtSalesman.Rows(0)("season")) & " Goals"
            tmpDataGrid.Rows.Item(0).Cells(5).Value = UCase(tmpSSeason1yrago) & " Actual"
            tmpDataGrid.Rows.Item(0).Cells(6).Value = UCase(dtSalesman.Rows(0)("season")) & " Actual - " & UCase(tmpSSeason1yrago) & " Actual"
            tmpDataGrid.Rows.Item(0).Cells(7).Value = "Comments"
            tmpDataGrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            tmpDataGrid.Columns(1).ReadOnly = True
            tmpDataGrid.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            tmpDataGrid.Columns(2).ReadOnly = True
            tmpDataGrid.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            tmpDataGrid.Columns(3).ReadOnly = True
            tmpDataGrid.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            tmpDataGrid.Columns(4).ReadOnly = True
            tmpDataGrid.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            tmpDataGrid.Columns(5).ReadOnly = True
            tmpDataGrid.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            tmpDataGrid.Columns(6).ReadOnly = True
            tmpDataGrid.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            tmpDataGrid.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            tmpDataGrid.Columns(7).Width = 200

        ElseIf tmpDataGrid.Name = "dgvNotes" Then
            tmpDataGrid.ColumnCount = 4
            tmpDataGrid.Rows.Item(0).Cells(2).Value = UCase(dtSalesman.Rows(0)("season")) & " Goals"
            tmpDataGrid.Rows.Item(0).Cells(3).Value = "Styles Notes Taken On"
            tmpDataGrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            tmpDataGrid.Columns(1).ReadOnly = True
            tmpDataGrid.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            tmpDataGrid.Columns(2).ReadOnly = True
            tmpDataGrid.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        ElseIf tmpDataGrid.Name = "dgvPass" Then
            tmpDataGrid.ColumnCount = 4
            tmpDataGrid.Rows.Item(0).Cells(2).Value = UCase(dtSalesman.Rows(0)("season")) & " Goals"
            tmpDataGrid.Rows.Item(0).Cells(3).Value = "Comments (required)"
            tmpDataGrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            tmpDataGrid.Columns(1).ReadOnly = True
            tmpDataGrid.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            tmpDataGrid.Columns(2).ReadOnly = True
            tmpDataGrid.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        ElseIf tmpDataGrid.Name = "dgvHistory" Then
            tmpDataGrid.ColumnCount = 7
            tmpDataGrid.Rows.Item(0).Cells(2).Value = UCase(dtSalesman.Rows(0)("season")) & " Goals"
            tmpDataGrid.Rows.Item(0).Cells(3).Value = UCase(dtSalesman.Rows(0)("season")) & " Actual"
            tmpDataGrid.Rows.Item(0).Cells(4).Value = UCase(tmpSSeason1yrago) & " Actual"
            tmpDataGrid.Rows.Item(0).Cells(5).Value = UCase(tmpOSeason1yrago) & " Actual"
            tmpDataGrid.Rows.Item(0).Cells(6).Value = UCase(tmpOSeason2yrsago) & " Actual"
            tmpDataGrid.ReadOnly = True
            tmpDataGrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            tmpDataGrid.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            tmpDataGrid.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            tmpDataGrid.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            tmpDataGrid.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            tmpDataGrid.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End If

        ' Setup row labels

        For i = 0 To dtProdType.Rows.Count - 1
            tmpProdType = Proper(dtProdType.Rows(i)("Description"))
            tmpDataGrid.Rows.Item(i + 1).Cells(1).Value = tmpProdType
            tmpDataGrid.Rows.Item(i + 1).Cells(0).Value = dtProdType.Rows(i)("prodtype")
        Next

        cn.Close()
        cn.Dispose()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    ''' <summary>
    ''' This procedures loads the data for the ASR grid based on the row and column labels
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub LoadASRGrid()
        Dim cn As New OleDb.OleDbConnection
        Dim daCustStatus As OleDb.OleDbDataAdapter
        Dim daProdType As OleDb.OleDbDataAdapter
        Dim daSalesman As OleDb.OleDbDataAdapter
        Dim daCustSeasProj As OleDb.OleDbDataAdapter
        Dim daSeasonType As OleDb.OleDbDataAdapter

        Dim dtCustStatus As New DataTable
        Dim dtProdType As New DataTable
        Dim dtSalesman As New DataTable
        Dim dtCustSeasProj As New DataTable
        Dim dtseason As New DataTable

        cn.ConnectionString = MySettings.Default("SaleForcConnectionString")
        cn.Open()

        Dim i As Short

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        If dgvASR.RowCount > 1 Then

            daProdType = New OleDb.OleDbDataAdapter("SELECT [description], [prodtype] FROM [prodtype]", cn)
            daProdType.Fill(dtProdType)

            daSalesman = New OleDb.OleDbDataAdapter("SELECT [season] FROM [salesman]", cn)
            daSalesman.Fill(dtSalesman)

            daSeasonType = New OleDb.OleDbDataAdapter("SELECT [seasontype] FROM season WHERE [season] = '" & dtSalesman.Rows(0)("season") & "'", cn)
            daSeasonType.Fill(dtseason)

            'Get current season goals
            '------------------------

            daCustSeasProj = New OleDb.OleDbDataAdapter("SELECT units, prodtype FROM [Cust-seas-proj] WHERE [Cust-seas-proj].[cust-no]='" & Me.txtCustNo.Text & "' AND [Cust-seas-proj].season='" & dtSalesman.Rows(0)("season") & "'", cn)
            daCustSeasProj.Fill(dtCustSeasProj)

            For i = 1 To dgvASR.RowCount - 1

                Dim foundprodtype As DataRow() = dtProdType.Select("[prodtype] = '" & dgvASR.Item(0, i).Value & "'")
                Dim foundcustseas As DataRow() = dtCustSeasProj.Select("[prodtype] = '" & foundprodtype(0)("prodtype") & "'")

                If foundcustseas.Length > 0 Then
                    dgvASR.Rows.Item(i).Cells(2).Value = foundcustseas(0)("units")
                Else
                    dgvASR.Rows.Item(i).Cells(2).Value = 0
                End If
            Next

            'Get Current season units
            '------------------------

            ' get units from order-line and ws-ord-line

            dtCustSeasProj.Clear()
            daCustSeasProj = New OleDb.OleDbDataAdapter("SELECT prodtype, Sum(units) AS TotUnits From (select prodtype, units from (SELECT Sum([order-line].[Qty-open-ord]+[order-line].[qty-shipped]+[cut-back-qty]) AS units, ProdGroup.ProdType FROM (Item INNER JOIN ([Order] INNER JOIN [Order-line] ON Order.[Order-no] = [Order-line].[Order-no]) ON Item.Item = [Order-line].[Item-no]) INNER JOIN ProdGroup ON Item.ProdGroup = ProdGroup.ProdGroup WHERE (((Order.[Cust-no])='" & Me.txtCustNo.Text & "') AND ((Order.Season)='" & dtSalesman.Rows(0)("season") & "')) GROUP BY ProdGroup.ProdType) Union All select prodtype, units from (SELECT Sum([ws-ord-line].[qty-orig-ord]) AS units, ProdGroup.ProdType FROM [ws-ord-head] INNER JOIN ((Item INNER JOIN [ws-ord-line] ON Item.Item = [ws-ord-line].[item-no]) INNER JOIN ProdGroup ON Item.ProdGroup = ProdGroup.ProdGroup) ON [ws-ord-head].[worksheet-id] = [ws-ord-line].[worksheet-id] WHERE ((([ws-ord-head].[validation-status])<>'" & "CANCEL" & "' And ([ws-ord-head].[validation-status])<>'" & "ORDER" & "') AND (([ws-ord-head].[cust-no])='" & Me.txtCustNo.Text & "') AND (([ws-ord-head].season)='" & dtSalesman.Rows(0)("season") & "')) GROUP BY ProdGroup.ProdType)) GROUP BY prodtype;", cn)
            daCustSeasProj.Fill(dtCustSeasProj)

            For i = 1 To dgvASR.RowCount - 1

                Dim foundprodtype As DataRow() = dtProdType.Select("[prodtype] = '" & dgvASR.Item(0, i).Value & "'")
                Dim foundcustseas As DataRow() = dtCustSeasProj.Select("prodtype= '" & foundprodtype(0)("prodtype") & "'")

                If foundcustseas.Length > 0 Then
                    dgvASR.Rows.Item(i).Cells(3).Value = foundcustseas(0)("totunits")
                Else
                    dgvASR.Rows.Item(i).Cells(3).Value = 0
                End If
            Next

            'Get difference of current season goal - current season units
            '------------------------------------------------------------
            For i = 1 To dgvASR.RowCount - 1
                dgvASR.Rows.Item(i).Cells(4).Value = CShort(dgvASR.Item(3, i).Value) - CShort(dgvASR.Item(2, i).Value)
            Next

            'Get last year same season units
            '-------------------------------
            dtCustSeasProj.Clear()
            daCustSeasProj = New OleDb.OleDbDataAdapter("SELECT Sum([order-line].[Qty-open-ord]+[order-line].[qty-shipped]+[cut-back-qty]) AS units, ProdGroup.ProdType " & "FROM (Item INNER JOIN ([Order] INNER JOIN [Order-line] ON Order.[Order-no] = [Order-line].[Order-no]) ON Item.Item = [Order-line].[Item-no]) INNER JOIN ProdGroup ON Item.ProdGroup = ProdGroup.ProdGroup " & "WHERE (((Order.[Cust-no])='" & Me.txtCustNo.Text & "') AND ((Order.Season)='" & GetSeason(dtSalesman.Rows(0)("season"), 1, dtseason.Rows(0)("seasontype")) & "')) GROUP BY ProdGroup.ProdType;", cn)
            daCustSeasProj.Fill(dtCustSeasProj)

            For i = 1 To dgvASR.RowCount - 1

                Dim foundprodtype As DataRow() = dtProdType.Select("[prodtype] = '" & dgvASR.Item(0, i).Value & "'")
                Dim foundcustseas As DataRow() = dtCustSeasProj.Select("prodtype= '" & foundprodtype(0)("prodtype") & "'")

                If foundcustseas.Length > 0 Then
                    dgvASR.Rows.Item(i).Cells(5).Value = foundcustseas(0)("units")
                Else
                    dgvASR.Rows.Item(i).Cells(5).Value = 0
                End If
            Next

            'Get difference of last year same season units - current season units
            '--------------------------------------------------------------------
            For i = 1 To dgvASR.RowCount - 1
                dgvASR.Rows.Item(i).Cells(6).Value = CShort(dgvASR.Item(3, i).Value - CShort(dgvASR.Item(5, i).Value))
            Next

            'load status comments
            '--------------------
            For i = 1 To dgvASR.RowCount - 1

                Dim foundprodtype As DataRow() = dtProdType.Select("[prodtype] = '" & dgvASR.Item(0, i).Value & "'")

                dtCustStatus.Clear()
                daCustStatus = New OleDb.OleDbDataAdapter("SELECT [statuscomments] FROM [customerstatus] WHERE [cust-no] = '" & Me.txtCustNo.Text & "' AND [season] = '" & dtSalesman.Rows(0)("season") & "' AND [prodtype] = '" & foundprodtype(0)("prodtype") & "' AND [ordercode] Is Null AND [stcode] = 'ordr'", cn)
                daCustStatus.Fill(dtCustStatus)

                If dtCustStatus.Rows.Count > 0 Then
                    dgvASR.Rows.Item(i).Cells(7).Value = dtCustStatus.Rows(0)("statuscomments")
                Else
                    dgvASR.Rows.Item(i).Cells(7).Value = vbNullString
                End If
            Next

            cn.Close()
            cn.Dispose()
        End If

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    ''' <summary>
    ''' This procedure loads historic customer data into the History grid for the current customer
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub LoadHistoryGrid()
        Dim cn As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim daProdType As OleDb.OleDbDataAdapter
        Dim daSalesman As OleDb.OleDbDataAdapter
        Dim daCustSeasProj As OleDb.OleDbDataAdapter
        Dim daSeason As OleDb.OleDbDataAdapter
        Dim dtProdType As New DataTable
        Dim dvProdType As New DataView
        Dim dtSalesman As New DataTable
        Dim dtCustSeasProj As New DataTable
        Dim dvCustSeasProj As New DataView
        Dim dtSeason As New DataTable
        Dim i As Short
        Dim tmpOppSeasonType As String
        Dim tmpSSeason1yrago As String
        Dim tmpOSeason1yrago As String
        Dim tmpOSeason2yrsago As String

        cn.Open()

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        If dgvHistory.Rows.Count > 1 Then
            daProdType = New OleDb.OleDbDataAdapter("SELECT [description], [prodtype] FROM [prodtype]", cn)
            daProdType.Fill(dtProdType)
            dvProdType = New DataView(dtProdType)

            daSalesman = New OleDb.OleDbDataAdapter("SELECT [season] FROM [salesman]", cn)
            daSalesman.Fill(dtSalesman)

            daSeason = New OleDb.OleDbDataAdapter("SELECT [seasontype] FROM Season WHERE [season] = '" & dtSalesman.Rows(0)("season") & "'", cn)
            daSeason.Fill(dtSeason)

            tmpOppSeasonType = GetProgramDefaults(dtSeason.Rows(0)("seasontype"))

            tmpSSeason1yrago = GetSeason(dtSalesman.Rows(0)("season"), 1, dtSeason.Rows(0)("seasontype"))
            tmpOSeason1yrago = GetSeason(dtSalesman.Rows(0)("season"), 1, tmpOppSeasonType)
            tmpOSeason2yrsago = GetSeason(dtSalesman.Rows(0)("season"), 2, tmpOppSeasonType)

            'Get current season goals
            '------------------------

            dtCustSeasProj.Clear()
            daCustSeasProj = New OleDb.OleDbDataAdapter("SELECT Sum([Cust-seas-proj].units) AS SumOfunits, [Cust-seas-proj].prodtype " & "From [Cust-seas-proj] WHERE ((([Cust-seas-proj].[cust-no])='" & Me.txtCustNo.Text & "') AND (([Cust-seas-proj].season)='" & dtSalesman.Rows(0)("season") & "')) GROUP BY [Cust-seas-proj].prodtype;", cn)
            daCustSeasProj.Fill(dtCustSeasProj)
            dvCustSeasProj = New DataView(dtCustSeasProj)

            For i = 1 To dgvHistory.RowCount - 1

                dvProdType.RowFilter = ("[prodtype] = '" & dgvHistory.Rows.Item(i).Cells(0).Value & "'")
                dvCustSeasProj.RowFilter = ("ProdType = '" & dvProdType.Item(0)("prodtype") & "'")

                If dvCustSeasProj.Count > 0 Then
                    dgvHistory.Rows.Item(i).Cells(2).Value = dvCustSeasProj.Item(0)("sumofunits")
                Else
                    dgvHistory.Rows.Item(i).Cells(2).Value = 0
                End If
            Next

            'Get current season units
            '------------------------

            dtCustSeasProj.Clear()
            daCustSeasProj = New OleDb.OleDbDataAdapter("SELECT prodtype, Sum(units) AS TotUnits " & "From (select prodtype, units from (SELECT Sum([order-line].[Qty-open-ord]+[order-line].[qty-shipped]+[cut-back-qty]) AS units, ProdGroup.ProdType " & "FROM (Item INNER JOIN ([Order] INNER JOIN [Order-line] ON Order.[Order-no] = [Order-line].[Order-no]) ON Item.Item = [Order-line].[Item-no]) INNER JOIN ProdGroup ON Item.ProdGroup = ProdGroup.ProdGroup " & "WHERE (((Order.[Cust-no])='" & Me.txtCustNo.Text & "') AND ((Order.Season)='" & dtSalesman.Rows(0)("season") & "')) " & "GROUP BY ProdGroup.ProdType) Union All select prodtype, units from " & "(SELECT Sum([ws-ord-line].[qty-orig-ord]) AS units, ProdGroup.ProdType " & "FROM [ws-ord-head] INNER JOIN ((Item INNER JOIN [ws-ord-line] ON Item.Item = [ws-ord-line].[item-no]) INNER JOIN ProdGroup ON Item.ProdGroup = ProdGroup.ProdGroup) ON [ws-ord-head].[worksheet-id] = [ws-ord-line].[worksheet-id] " & "WHERE ((([ws-ord-head].[validation-status])<>'" & "CANCEL" & "' And ([ws-ord-head].[validation-status])<>'" & "ORDER" & "') AND (([ws-ord-head].[cust-no])='" & Me.txtCustNo.Text & "') AND (([ws-ord-head].season)='" & dtSalesman.Rows(0)("season") & "'))" & "GROUP BY ProdGroup.ProdType)) GROUP BY prodtype;", cn)
            daCustSeasProj.Fill(dtCustSeasProj)
            dvCustSeasProj = New DataView(dtCustSeasProj)

            For i = 1 To dgvHistory.RowCount - 1

                dvProdType.RowFilter = ("[prodtype] = '" & dgvHistory.Rows.Item(i).Cells(0).Value & "'")
                dvCustSeasProj.RowFilter = ("ProdType = '" & dvProdType.Item(0)("prodtype") & "'")

                If dvCustSeasProj.Count > 0 Then
                    dgvHistory.Rows.Item(i).Cells(3).Value = dvCustSeasProj.Item(0)("totunits")
                Else
                    dgvHistory.Rows.Item(i).Cells(3).Value = 0
                End If
            Next

            'Load last year same season units
            '--------------------------------

            dtCustSeasProj.Clear()
            daCustSeasProj = New OleDb.OleDbDataAdapter("SELECT prodtype, Sum(units) AS TotUnits " & "From (select prodtype, units from (SELECT Sum([order-line].[Qty-open-ord]+[order-line].[qty-shipped]+[cut-back-qty]) AS units, ProdGroup.ProdType " & "FROM (Item INNER JOIN ([Order] INNER JOIN [Order-line] ON Order.[Order-no] = [Order-line].[Order-no]) ON Item.Item = [Order-line].[Item-no]) INNER JOIN ProdGroup ON Item.ProdGroup = ProdGroup.ProdGroup " & "WHERE (((Order.[Cust-no])='" & Me.txtCustNo.Text & "') AND ((Order.Season)='" & tmpSSeason1yrago & "')) " & "GROUP BY ProdGroup.ProdType) Union All select prodtype, units from " & "(SELECT Sum([ws-ord-line].[qty-orig-ord]) AS units, ProdGroup.ProdType " & "FROM [ws-ord-head] INNER JOIN ((Item INNER JOIN [ws-ord-line] ON Item.Item = [ws-ord-line].[item-no]) INNER JOIN ProdGroup ON Item.ProdGroup = ProdGroup.ProdGroup) ON [ws-ord-head].[worksheet-id] = [ws-ord-line].[worksheet-id] " & "WHERE ((([ws-ord-head].[validation-status])<>'" & "CANCEL" & "' And ([ws-ord-head].[validation-status])<>'" & "ORDER" & "') AND (([ws-ord-head].[cust-no])='" & Me.txtCustNo.Text & "') AND (([ws-ord-head].season)='" & tmpSSeason1yrago & "'))" & "GROUP BY ProdGroup.ProdType)) GROUP BY prodtype;", cn)
            daCustSeasProj.Fill(dtCustSeasProj)
            dvCustSeasProj = New DataView(dtCustSeasProj)

            For i = 1 To dgvHistory.RowCount - 1

                dvProdType.RowFilter = ("[prodtype] = '" & dgvHistory.Rows.Item(i).Cells(0).Value & "'")
                dvCustSeasProj.RowFilter = ("ProdType = '" & dvProdType.Item(0)("prodtype") & "'")

                If dvCustSeasProj.Count > 0 Then
                    dgvHistory.Rows.Item(i).Cells(4).Value = dvCustSeasProj.Item(0)("totunits")
                Else
                    dgvHistory.Rows.Item(i).Cells(4).Value = 0
                End If
            Next

            ' Load opposite season, one year ago units (column 4)
            ' ---------------------------------------------------

            dtCustSeasProj.Clear()
            daCustSeasProj = New OleDb.OleDbDataAdapter("SELECT prodtype, Sum(units) AS TotUnits " & "From (select prodtype, units from (SELECT Sum([order-line].[Qty-open-ord]+[order-line].[qty-shipped]+[cut-back-qty]) AS units, ProdGroup.ProdType " & "FROM (Item INNER JOIN ([Order] INNER JOIN [Order-line] ON Order.[Order-no] = [Order-line].[Order-no]) ON Item.Item = [Order-line].[Item-no]) INNER JOIN ProdGroup ON Item.ProdGroup = ProdGroup.ProdGroup " & "WHERE (((Order.[Cust-no])='" & Me.txtCustNo.Text & "') AND ((Order.Season)='" & tmpOSeason1yrago & "')) " & "GROUP BY ProdGroup.ProdType) Union All select prodtype, units from " & "(SELECT Sum([ws-ord-line].[qty-orig-ord]) AS units, ProdGroup.ProdType " & "FROM [ws-ord-head] INNER JOIN ((Item INNER JOIN [ws-ord-line] ON Item.Item = [ws-ord-line].[item-no]) INNER JOIN ProdGroup ON Item.ProdGroup = ProdGroup.ProdGroup) ON [ws-ord-head].[worksheet-id] = [ws-ord-line].[worksheet-id] " & "WHERE ((([ws-ord-head].[validation-status])<>'" & "CANCEL" & "' And ([ws-ord-head].[validation-status])<>'" & "ORDER" & "') AND (([ws-ord-head].[cust-no])='" & Me.txtCustNo.Text & "') AND (([ws-ord-head].season)='" & tmpOSeason1yrago & "'))" & "GROUP BY ProdGroup.ProdType)) GROUP BY prodtype;", cn)
            daCustSeasProj.Fill(dtCustSeasProj)
            dvCustSeasProj = New DataView(dtCustSeasProj)

            For i = 1 To dgvHistory.RowCount - 1

                dvProdType.RowFilter = ("[prodtype] = '" & dgvHistory.Rows.Item(i).Cells(0).Value & "'")
                dvCustSeasProj.RowFilter = ("ProdType = '" & dvProdType.Item(0)("prodtype") & "'")

                If dvCustSeasProj.Count > 0 Then
                    dgvHistory.Rows.Item(i).Cells(5).Value = dvCustSeasProj.Item(0)("totunits")
                Else
                    dgvHistory.Rows.Item(i).Cells(5).Value = 0
                End If
            Next

            ' Load opposite season, two years ago units (column 5)
            ' ----------------------------------------------------

            dtCustSeasProj.Clear()
            daCustSeasProj = New OleDb.OleDbDataAdapter("SELECT prodtype, Sum(units) AS TotUnits " & "From (select prodtype, units from (SELECT Sum([order-line].[Qty-open-ord]+[order-line].[qty-shipped]+[cut-back-qty]) AS units, ProdGroup.ProdType " & "FROM (Item INNER JOIN ([Order] INNER JOIN [Order-line] ON Order.[Order-no] = [Order-line].[Order-no]) ON Item.Item = [Order-line].[Item-no]) INNER JOIN ProdGroup ON Item.ProdGroup = ProdGroup.ProdGroup " & "WHERE (((Order.[Cust-no])='" & Me.txtCustNo.Text & "') AND ((Order.Season)='" & tmpOSeason2yrsago & "')) " & "GROUP BY ProdGroup.ProdType) Union All select prodtype, units from " & "(SELECT Sum([ws-ord-line].[qty-orig-ord]) AS units, ProdGroup.ProdType " & "FROM [ws-ord-head] INNER JOIN ((Item INNER JOIN [ws-ord-line] ON Item.Item = [ws-ord-line].[item-no]) INNER JOIN ProdGroup ON Item.ProdGroup = ProdGroup.ProdGroup) ON [ws-ord-head].[worksheet-id] = [ws-ord-line].[worksheet-id] " & "WHERE ((([ws-ord-head].[validation-status])<>'" & "CANCEL" & "' And ([ws-ord-head].[validation-status])<>'" & "ORDER" & "') AND (([ws-ord-head].[cust-no])='" & Me.txtCustNo.Text & "') AND (([ws-ord-head].season)='" & tmpOSeason2yrsago & "'))" & "GROUP BY ProdGroup.ProdType)) GROUP BY prodtype;", cn)
            daCustSeasProj.Fill(dtCustSeasProj)
            dvCustSeasProj = New DataView(dtCustSeasProj)

            For i = 1 To dgvHistory.RowCount - 1

                dvProdType.RowFilter = ("[prodtype] = '" & dgvHistory.Rows.Item(i).Cells(0).Value & "'")
                dvCustSeasProj.RowFilter = ("ProdType = '" & dvProdType.Item(0)("prodtype") & "'")

                If dvCustSeasProj.Count > 0 Then
                    dgvHistory.Rows.Item(i).Cells(6).Value = dvCustSeasProj.Item(0)("totunits")
                Else
                    dgvHistory.Rows.Item(i).Cells(6).Value = 0
                End If
            Next
        End If
        cn.Close()
        cn.Dispose()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    ''' <summary>
    ''' This procedure returns a season code that is created based on the parameters sent to it
    ''' </summary>
    ''' <param name="strCurrentSeason">The current season code</param>
    ''' <param name="intYearsAgo">How many years to go back</param>
    ''' <param name="strSeasonTypeTarget">The type of season (F=Fall,S=Spring,etc)</param>
    ''' <returns>A season code</returns>
    ''' <remarks>This procedure is used when building the labels for the ASR grids</remarks>

    Private Function GetSeason(ByRef strCurrentSeason As String, ByRef intYearsAgo As Short, ByRef strSeasonTypeTarget As String) As String
        Dim strCurrentYear As String = Nothing
        Dim intTargetYear As Short
        Dim i As Short

        ' find the number part of the current season; i.e 12 = 2012

        For i = 1 To Len(strCurrentSeason)
            If Asc(Mid(strCurrentSeason, i, 1)) >= 48 And Asc(Mid(strCurrentSeason, i, 1)) <= 57 Then
                strCurrentYear = strCurrentYear & Mid(strCurrentSeason, i, 1)
            End If
        Next

        If Len(Trim(strCurrentYear)) > 2 Then
            MsgBox("Contact IT, function:  GetSeason not able to work with " & strCurrentSeason & " Season", MsgBoxStyle.Critical, "Function: GetSeason")
        End If

        'set intTargetYear by subtracting number of years to go back

        ' get target year
        ' ---------------
        intTargetYear = CShort(strCurrentYear) - intYearsAgo

        ' get target season
        GetSeason = strSeasonTypeTarget & intTargetYear.ToString("G")

    End Function

    ''' <summary>
    ''' This procedure loads data from the NotesComments table into the ASR datagrid
    ''' </summary>
    ''' <param name="tmpDataGrid"></param>
    ''' <remarks></remarks>

    Private Sub LoadNotesGrid(ByRef tmpDataGrid As DataGridView)
        Dim cn As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        'Dim daCustStatus As OleDb.OleDbDataAdapter
        Dim daProdType As OleDb.OleDbDataAdapter
        Dim daSalesman As OleDb.OleDbDataAdapter
        Dim daCustSeasProj As OleDb.OleDbDataAdapter
        Dim daCustStatus2 As OleDb.OleDbDataAdapter
        Dim daNotesComments As New OleDb.OleDbDataAdapter

        Dim dtCustStatus As New DataTable
        Dim dtProdType As New DataTable
        Dim dtSalesman As New DataTable
        Dim dtCustSeasProj As New DataTable
        Dim dtCustStatus2 As New DataTable
        Dim dtNotesComments As New DataTable
        Dim strSelect As String = Nothing

        'If dgvNotes.CurrentCell Is Nothing Then Exit Sub

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim i As Short

        If tmpDataGrid.RowCount > 1 Then

            cn.Open()

            daProdType = New OleDb.OleDbDataAdapter("SELECT [prodtype], [description] FROM [prodtype]", cn)
            daProdType.Fill(dtProdType)

            daSalesman = New OleDb.OleDbDataAdapter("SELECT [season] FROM [salesman]", cn)
            daSalesman.Fill(dtSalesman)

            If tmpDataGrid.Name = "dgvNotes" Then
                daNotesComments = New OleDb.OleDbDataAdapter("SELECT [followupdate], [notescomments] FROM [notescomments]  WHERE [cust-no] = '" & Me.txtCustNo.Text & "' AND [season] = '" & dtSalesman.Rows(0)("season") & "'", cn)
                daNotesComments.Fill(dtNotesComments)

                If dtNotesComments.Rows.Count > 0 Then
                    Me.dtpNotesFollowup.Value = dtNotesComments.Rows(0)("followupdate")

                    If Not IsDBNull(dtNotesComments.Rows(0)("notescomments")) Then
                        Me.txtNoteGenComments.Text = dtNotesComments.Rows(0)("notescomments").ToString
                    Else
                        Me.txtNoteGenComments.Text = vbNullString
                    End If
                Else
                    Me.dtpNotesFollowup.Value = Now.ToShortDateString
                End If
            End If

            For i = 1 To tmpDataGrid.RowCount - 1

                ' Get product type

                Dim foundprodtype As DataRow() = dtProdType.Select("[prodtype] = '" & tmpDataGrid.Item(0, i).Value & "'")

                If dtProdType.Rows.Count > 0 Then
                    If tmpDataGrid.Name = "dgvNotes" Then
                        strSelect = "SELECT * FROM CustomerStatus WHERE [cust-no] = '" & Me.txtCustNo.Text & "' AND [season] = '" & dtSalesman.Rows(0)("season") & "' AND [prodtype] = '" & foundprodtype(0)("prodtype") & "' and [stcode] = 'note'"
                    ElseIf tmpDataGrid.Name = "dgvPass" Then
                        strSelect = "SELECT * FROM CustomerStatus WHERE [cust-no] = '" & Me.txtCustNo.Text & "' AND [season] = '" & dtSalesman.Rows(0)("season") & "' AND [prodtype] = '" & foundprodtype(0)("prodtype") & "' and [stcode] = 'pass'"
                    End If

                    dtCustStatus2.Clear()
                    daCustStatus2 = New OleDb.OleDbDataAdapter(strSelect, cn)
                    daCustStatus2.Fill(dtCustStatus2)
                End If

                ' Load Current season goal units (column 2)
                ' -----------------------------------------

                If dtProdType.Rows.Count > 0 Then
                    dtCustSeasProj.Clear()
                    daCustSeasProj = New OleDb.OleDbDataAdapter("SELECT [Cust-seas-proj].units From [Cust-seas-proj] GROUP BY [Cust-seas-proj].[cust-no], [Cust-seas-proj].season, [Cust-seas-proj].prodtype, [Cust-seas-proj].units HAVING [Cust-seas-proj].[cust-no]='" & txtCustNo.Text & "' AND [Cust-seas-proj].season='" & dtSalesman.Rows(0)("season") & "' AND [Cust-seas-proj].prodtype= '" & foundprodtype(0)("prodtype") & "';", cn)
                    daCustSeasProj.Fill(dtCustSeasProj)

                    If dtCustSeasProj.Rows.Count > 0 Then
                        tmpDataGrid.Rows.Item(i).Cells(2).Value = dtCustSeasProj.Rows(0)("units")
                    Else
                        tmpDataGrid.Rows.Item(i).Cells(2).Value = 0
                    End If

                    If dtCustStatus2.Rows.Count > 0 Then
                        tmpDataGrid.Rows.Item(i).Cells(3).Value = dtCustStatus2.Rows(0)("statuscomments")
                    Else
                        tmpDataGrid.Rows.Item(i).Cells(3).Value = vbNullString
                    End If
                End If
            Next
            cn.Close()
            cn.Dispose()
        End If

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    ''' <summary>
    ''' This procedure creates the graphs that show historical sales for the current customer on the ASR tab
    ''' </summary>
    ''' <param name="tmpFirstHistorySeason"></param>
    ''' <remarks></remarks>

    Private Sub CreateHistoryGraphs(ByRef tmpFirstHistorySeason As String)
        Dim con As New OleDb.OleDbConnection

        Dim daCustSeasProj As OleDb.OleDbDataAdapter
        Dim dtCustSeasProj As New DataTable

        Dim daProdType As OleDb.OleDbDataAdapter
        Dim dtProdType As New DataTable

        Dim daSalesman As OleDb.OleDbDataAdapter
        Dim dtSalesman As New DataTable

        Dim daUnits As OleDb.OleDbDataAdapter
        Dim dtUnits As New DataTable

        Dim sql As String = Nothing
        Dim i As Short
        Dim j As Short
        Dim tmpSeasonType As String = Nothing
        Dim tmp2yearsago As String = Nothing
        Dim tmp3yearsago As String = Nothing
        Dim tmp4yearsago As String = Nothing
        Dim tmp5yearsago As String = Nothing
        Dim arrSeason(5) As String
        Dim strprodtypelist As String = Nothing

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        pnlHistoryGraphs.Visible = True

        If Me.pnlHistoryGraphs.Controls.Count > 0 Then
            For i = 0 To Me.pnlHistoryGraphs.Controls.Count
                If Me.pnlHistoryGraphs.Controls(i).Name = "ChartHistory" Then
                    Me.pnlHistoryGraphs.Controls.RemoveAt(i)
                    Exit For
                End If
            Next
        End If

        Dim chartHistory As New Chart
        chartHistory.Parent = Me.pnlHistoryGraphs
        chartHistory.Name = "ChartHistory"
        con.ConnectionString = MySettings.Default("SaleForcConnectionString")
        con.Open()

        'Chart Title Properties

        chartHistory.Titles.Add("Sales History")
        chartHistory.Titles(0).Text = Me.lblName.Text ' Customer Name
        chartHistory.Titles(0).Font = New Font("Times New Roman", 30, FontStyle.Bold)
        chartHistory.Titles(0).Docking = Docking.Top
        'chartHistory.Titles(0).BackImage = System.AppDomain.CurrentDomain.BaseDirectory & "\CollectionsBlk-ken4.jpg"
        'chartHistory.Titles(0).BackImageWrapMode = ChartImageWrapMode.Unscaled

        chartHistory.TextAntiAliasingQuality = TextAntiAliasingQuality.High

        'Chart Location & Size Properties

        chartHistory.Top = 10
        chartHistory.Height = 1150
        chartHistory.Width = 850

        'Get Chart Data

        sql = "SELECT [season] FROM [salesman]"
        daSalesman = New OleDb.OleDbDataAdapter(sql, con)
        daSalesman.Fill(dtSalesman)

        sql = "SELECT DISTINCTROW ProdType.Description, ProdType.ProdType " & "FROM ProdType LEFT JOIN [Cust-seas-proj] ON ProdType.ProdType = [Cust-seas-proj].prodtype " & "WHERE (((ProdType.[disp-seq])>0)) OR ((([Cust-seas-proj].[cust-no])='" & Me.txtCustNo.Text & "') AND (([Cust-seas-proj].season)='" & dtSalesman.Rows(0)("season") & "')) ORDER BY ProdType.[disp-seq];"
        daCustSeasProj = New OleDb.OleDbDataAdapter(sql, con)
        daCustSeasProj.Fill(dtCustSeasProj)

        sql = "SELECT [prodtype], [description] FROM [prodtype]"
        daProdType = New OleDb.OleDbDataAdapter(sql, con)
        daProdType.Fill(dtProdType)

        'Get Product Types

        If dtCustSeasProj.Rows.Count > 0 Then
            For i = 0 To dtCustSeasProj.Rows.Count - 1
                strprodtypelist = strprodtypelist & "[ProdGroup].[ProdType] = '" & dtCustSeasProj.Rows(i)("prodtype") & "' or "
            Next
            strprodtypelist = Mid(strprodtypelist, 1, Len(strprodtypelist) - 4)
        Else
            chartHistory.Visible = False
            Exit Sub
        End If

        If dtCustSeasProj.Rows.Count = 0 Then
            Exit Sub
        End If

        'Get Season Type

        If optFall.Checked = True Then
            tmpSeasonType = "F"
        Else
            tmpSeasonType = "S"
        End If

        tmp5yearsago = GetSeason(tmpFirstHistorySeason, 4, tmpSeasonType)
        arrSeason(0) = tmp5yearsago
        tmp4yearsago = GetSeason(tmpFirstHistorySeason, 3, tmpSeasonType)
        arrSeason(1) = tmp4yearsago
        tmp3yearsago = GetSeason(tmpFirstHistorySeason, 2, tmpSeasonType)
        arrSeason(2) = tmp3yearsago
        tmp2yearsago = GetSeason(tmpFirstHistorySeason, 1, tmpSeasonType)
        arrSeason(3) = tmp2yearsago
        arrSeason(4) = tmpFirstHistorySeason

        ' Create Chartareas (individual charts)
        For i = 0 To dtCustSeasProj.Rows.Count - 1
            Dim tmpChartArea As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
            tmpChartArea.Name = "ChartArea" & Str(i)
            tmpChartArea.Area3DStyle.Enable3D = True
            tmpChartArea.Position.Auto = True 'New ElementPosition(xpos, ypos, 30, 15) ' changes the position of the chart within the chart area
            tmpChartArea.InnerPlotPosition.Auto = True 'New ElementPosition(10, 10, 100, 100) 'changes the size and shape of the chart within the chart area
            chartHistory.ChartAreas.Add(tmpChartArea)
        Next

        sql = "SELECT Sum([order-line].[Qty-open-ord]+[order-line].[qty-shipped]+[cut-back-qty]) AS units, Order.Season, ProdGroup.ProdType " & "FROM (Item INNER JOIN ([Order] INNER JOIN [Order-line] ON Order.[Order-no] = [Order-line].[Order-no]) ON Item.Item = [Order-line].[Item-no]) INNER JOIN ProdGroup ON Item.ProdGroup = ProdGroup.ProdGroup " & "WHERE (Order.[Cust-no]=" & Chr(39) & Me.txtCustNo.Text & Chr(39) & ") AND (" & strprodtypelist & ") AND (Order.Season=" & Chr(39) & tmpFirstHistorySeason & Chr(39) & " Or Order.Season=" & Chr(39) & tmp2yearsago & Chr(39) & " Or Order.Season=" & Chr(39) & tmp3yearsago & Chr(39) & " Or Order.Season=" & Chr(39) & tmp4yearsago & Chr(39) & " Or Order.Season=" & Chr(39) & tmp5yearsago & Chr(39) & ") " & "GROUP BY Order.Season, ProdGroup.ProdType;"
        daUnits = New OleDb.OleDbDataAdapter(sql, con)
        daUnits.Fill(dtUnits)

        con.Close()

        'Get Data for each Product Type (chartarea)

        For i = 0 To dtCustSeasProj.Rows.Count - 1

            'Product Type Descriptions
            chartHistory.Titles.Add(Proper(dtCustSeasProj.Rows(i)("description")))
            chartHistory.Titles(i + 1).DockedToChartArea = "ChartArea" & Str(i)
            chartHistory.Titles(i + 1).Font = New Font("Times New Roman", 14, FontStyle.Bold)
            chartHistory.Titles(i + 1).DockingOffset = -4


            Dim series1 As Series = chartHistory.Series.Add(dtCustSeasProj.Rows(i)("description"))
            chartHistory.Series(dtCustSeasProj.Rows(i)("description")).ChartArea = "ChartArea" & Str(i)
            series1.ChartType = SeriesChartType.Bar
            series1.IsValueShownAsLabel = True
            series1.Font = New Font("Times New Roman", 10, FontStyle.Regular)

            For j = 0 To UBound(arrSeason) - 1

                dtProdType.Select("[prodtype] = '" & dtCustSeasProj.Rows(i)("prodtype") & "'")
                Dim foundrow As DataRow() = dtUnits.Select("[prodtype] = '" & dtCustSeasProj.Rows(i)("prodtype") & "' and [season] = '" & arrSeason(j) & "'")

                If foundrow.Length > 0 Then
                    series1.Points.Add(foundrow(0)("units"))
                Else
                    series1.Points.Add(0)
                End If
                series1.Points(j).AxisLabel = UCase(arrSeason(j)) 'F10,F11,F12, etc

            Next
        Next
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    ''' <summary>
    ''' This procedure populates the 'cFlagSHipStatus' variable which shows the Customer Ship To status information (Permanent,Inactive, etc).
    ''' It will also call setCmdNewWSStatus which enables or disables the 'New Worksheet' button.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub dblShipNoList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dblShipNoList.Click
        'If bndCustomerShip.Current("status-code") = "I" Then
        '    cmdNewWs.Visible = False
        'Else
        '    cmdNewWs.Visible = True
        '    cmdNewWs.Enabled = True
        'End If
        cFlagShipStatus = bndCustomerShip.Current("status-code")
        setCmdNewWsStatus()
    End Sub

    ''' <summary>
    ''' This procedure enables or disables the 'New Worksheet' button based on the status os the customer status (Permanent,Inactive,etc)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub dblShipNoList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dblShipNoList.DoubleClick
        'If bndCustomerShip.Current("status-code") = "I" Then
        '    cmdNewWs.Enabled = False
        'Else
        '    cmdNewWs.Enabled = True
        'End If
        If cFlagCustStatus = "I" Or cFlagShipStatus = "I" Then Exit Sub
        cmdNewWs.Visible = True
        cmdNewWs.Enabled = True
        'setCmdNewWsStatus()
    End Sub

    ''' <summary>
    ''' This procedure calls EmailWorksheets.  EmailWorksheets will create an email item in Microsoft Office Outlook and attach the 
    ''' Crystal Reports worksheet report to the email.  The default email address is the customer's email address
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub cmdEmailWorksheet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEmailWorksheet.Click
        If bndWorksheets.Count > 0 Then
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Dim i As Integer
            i = dgvWorksheets.CurrentRow.Index
            Call EmailWorksheets(dgvWorksheets.Item(0, i).Value, bndCustomer.Current("email").ToString)
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Else
            MsgBox("No workshsheets to email!", MsgBoxStyle.Critical, "Email Worksheet")
        End If
    End Sub

    ''' <summary>
    ''' This procedure will print the history graphs on the ASR screen to the default printer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub cmdPrintGraphs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintGraphs.Click
        Dim chartHistory As Chart
        Dim tmpWidth As Integer
        chartHistory = pnlHistoryGraphs.Controls("ChartHistory")
        tmpWidth = chartHistory.Width
        chartHistory.Width = 1700
        chartHistory.Printing.PrintDocument.DefaultPageSettings.Landscape = True
        chartHistory.Printing.Print(True)
        chartHistory.Width = tmpWidth
    End Sub

    ''' <summary>
    ''' This procedure fills a combo box that displays the names of customers.
    ''' </summary>
    ''' <remarks>This is the combo box that displays the names of customers.  Users select a customer name to view data for that
    ''' customer </remarks>

    Private Sub FillCustomerComboBox()
        Dim con As New OleDb.OleDbConnection
        Dim da As New OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        Dim sql As String = Nothing

        con.ConnectionString = MySettings.Default("SaleForcConnectionString")
        con.Open()

        If chkViewActiveCust.CheckState = System.Windows.Forms.CheckState.Checked Then
            If Me.optFindByCustName.Checked = True Then
                sql = "SELECT [name],[cust-no] FROM customer WHERE [status-code] = 'P' ORDER BY [name]"
            ElseIf optFindByCustNumber.Checked = True Then
                sql = "SELECT [name],[cust-no] FROM customer WHERE [status-code] = 'P' ORDER BY [cust-no]"
            End If
        ElseIf chkViewActiveCust.CheckState = System.Windows.Forms.CheckState.Unchecked Then
            If optFindByCustName.Checked = True Then
                sql = "SELECT [name],[cust-no] FROM customer WHERE [status-code] Is Not Null ORDER BY [name]"
            ElseIf optFindByCustNumber.Checked = True Then
                sql = "SELECT [name],[cust-no] FROM customer WHERE [status-code] Is Not Null ORDER BY [cust-no]"
            End If
        End If

        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(dt)
        con.Close()

        With cmbAutoCompleteCustName

            .DataSource = dt
            .DisplayMember = "name"
            .ValueMember = "cust-no"
            .AutoCompleteSource = AutoCompleteSource.ListItems
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .DropDownStyle = ComboBoxStyle.DropDown
            .ResetText()
        End With

    End Sub

    ''' <summary>
    ''' This procedure will hide the customer combo box when the user wants to look for a customer by customer id instead of customer name
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub optOrderBy_0_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles optFindByCustNumber.CheckedChanged
        Dim cTmpCustNo As String
        cmbAutoCompleteCustName.Visible = False
        txtCustID.Visible = True
        txtCustID.Focus()
        cTmpCustNo = txtCustID.Text
    End Sub

    ''' <summary>
    ''' This procedure will hide the customer id text box when the user wants to look for a customer by customer name using the combo box
    ''' instead of searching by customer id
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub optOrderBy_1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles optFindByCustName.CheckedChanged
        Dim cTmpCustName As String
        txtCustID.Visible = False
        cmbAutoCompleteCustName.Visible = True
        cmbAutoCompleteCustName.Focus()
        cTmpCustName = cmbAutoCompleteCustName.Text
    End Sub

    ''' <summary>
    ''' This procedure is used to make a call to FindCustomer to search for a customer by customer id; It also clears the text in the
    ''' customer id text box.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub txtCustID_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCustID.KeyUp
        If e.KeyValue = System.Windows.Forms.Keys.Return Then
            FindCustomer()
            txtCustID.ResetText()
        End If
    End Sub

    ''' <summary>
    ''' This procedure navigates to the next customer record and disables the button if it finds the last customer record
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click
        Me.bndCustomer.MoveNext()
        Me.Invalidate()
        UpdateCustShipInfo()
        setFvStatusNewRec()
        If bndCustomer.Position = bndCustomer.Count - 1 Then
            cmdNext.Enabled = False
            cmdLast.Enabled = False
        End If
        cmdFirst.Enabled = True
        cmdPrevious.Enabled = True
    End Sub

    ''' <summary>
    ''' This procedure navigates to the previous customer record and disables the button if it finds the first customer record
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub cmdPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrevious.Click
        bndCustomer.MovePrevious()
        Me.Invalidate()
        UpdateCustShipInfo()
        setFvStatusNewRec()
        cmdNext.Enabled = True
        If bndCustomer.Position = 0 Then
            cmdPrevious.Enabled = False
            cmdFirst.Enabled = False
        End If
        cmdNext.Enabled = True
        cmdLast.Enabled = True
    End Sub

    ''' <summary>
    ''' This procedure navigates to the first customer record
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub cmdFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFirst.Click
        Me.bndCustomer.MoveFirst()
        UpdateCustShipInfo()
        setFvStatusNewRec()
        cmdNext.Enabled = True
        cmdLast.Enabled = True
        cmdPrevious.Enabled = False
        cmdFirst.Enabled = False

    End Sub

    ''' <summary>
    ''' This procedure navigates to the last customer record
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub cmdLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLast.Click
        Me.bndCustomer.MoveLast()
        UpdateCustShipInfo()
        setFvStatusNewRec()
        cmdNext.Enabled = False
        cmdLast.Enabled = False
        cmdPrevious.Enabled = True
        cmdFirst.Enabled = True
    End Sub

    ''' <summary>
    ''' This procedure saves the data for a new customer unless the user aborts saving.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>This procedure saves new customer data when creating a new customer or when modifying a new customer that hasn't yet been
    ''' transmitted to the FTP server</remarks>

    Private Sub cmdNewCustFinished_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNewCustFinished.Click
        Dim ans As Short
        Dim x As Boolean
        flagCmdFinished = True

        ' ---- Check to see if the new customer name field contains a name.
        If Len(Trim(mebName.Text)) = 0 Then
            If flagAddNewCust Then
                ans = MsgBox("Abort adding new customer?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ADD NEW CUSTOMER")
            Else
                ans = MsgBox("Abort editing new customer?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "EDIT NEW CUSTOMER")
            End If
            If ans = MsgBoxResult.Yes Then
                flagEditNewCust = False
                flagAddNewCust = False
                clrNewCustForm()
                setFormViewStatus((1))
                txtCustID.Visible = True
                Me.KeyPreview = False
                Exit Sub
            Else
                mebName.Focus()
                Exit Sub
            End If
        End If

        If mebAddr1.Text = "" Or mebCity.Text = "" Or mebState.Text = "" Or mebZipCode.Text = "" Or _
           mebShipName.Text = "" Or mebShipAddr1.Text = "" Or mebShipCity.Text = "" Or mebShipSt.Text = "" Or mebShipZipCode.Text = "" Then
            ans = MsgBox("All main customer and shipping address fields with an asterisk must be filled in.  Do you want to retry or cancel adding new customer information?", MsgBoxStyle.RetryCancel, "New Customer")
            If ans = MsgBoxResult.Cancel Then
                flagEditNewCust = False
                flagAddNewCust = False
                clrNewCustForm()
                setFormViewStatus((1))
                txtCustID.Visible = True
                Me.KeyPreview = False
            Else
                Exit Sub
            End If
        End If

        If flagAddNewCust Then
            ans = MsgBox("Save this customer information", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "SAVE NEW CUSTOMER")
            If ans = MsgBoxResult.Yes Then
                If Len(Trim(mebName.Text)) = 0 Then
                    MsgBox("Cannot save a customer without a name")
                Else
                    saveNewCust()
                    SaveNewCustShip()
                    chkViewActiveCust.CheckState = System.Windows.Forms.CheckState.Unchecked
                    'chkViewActiveCust_CheckStateChanged(chkViewActiveCust, New System.EventArgs())
                    x = FindCust("CustNumber", cCustNo)
                    cNewCustNo = ""
                End If
                flagAddNewCust = False
                clrNewCustForm()
                setFormViewStatus((1))
                FindCustomer()
                txtCustID.Visible = True
            ElseIf ans = MsgBoxResult.Cancel Then
                mebName.Focus()
                Exit Sub
            Else
                flagAddNewCust = False
                clrNewCustForm()
                setFormViewStatus((1))
                txtCustID.Visible = True
            End If
        End If

            If flagEditNewCust Then

                ans = MsgBox("Save this customer information", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "SAVE CHANGED NEW CUSTOMER INFO")

                If ans = MsgBoxResult.Yes Then
                    If Len(Trim(mebName.Text)) = 0 Then
                        MsgBox("Cannot save a customer without a name")
                    Else
                        saveNewCust()
                        SaveNewCustShip()
                        chkViewActiveCust.CheckState = System.Windows.Forms.CheckState.Unchecked
                        chkViewActiveCust_CheckStateChanged(chkViewActiveCust, New System.EventArgs())
                        x = FindCust("CustNumber", cCustNo)
                    End If

                    clrNewCustForm()
                    setFormViewStatus((1))
                    txtCustID.Visible = True
                    flagEditNewCust = False
                    cmdNewCustEdit.Visible = True

                ElseIf ans = MsgBoxResult.Cancel Then

                    mebName.Focus()
                    Exit Sub

                Else
                    clrNewCustForm()
                    setFormViewStatus((1))
                    txtCustID.Visible = True
                    flagEditNewCust = False
                    cmdNewCustEdit.Visible = True
                End If
            End If
            Me.KeyPreview = False
    End Sub

    ''' <summary>
    ''' This procedure is called when data from the database table has changed but isn't yet reflected in the display of the screen.
    ''' </summary>
    ''' <param name="selectCommand"></param>
    ''' <remarks>This procedure refreshes the display in the control after data has changed</remarks>

    Private Sub GetCustomerData(ByVal selectCommand As String)
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
        Me.bndCustomer.DataSource = table
    End Sub

    ''' <summary>
    ''' This procedure is called when data from the database table has changed but isn't yet reflected in the display of the screen.
    ''' </summary>
    ''' <param name="selectCommand"></param>
    ''' <remarks>This procedure refreshes the display in the control after data has changed</remarks>

    Private Sub GetCustomerShData(ByVal selectCommand As String)

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
        Me.bndCustomer.DataSource = table
    End Sub

    ''' <summary>
    ''' This procedure is called when data from the database table has changed but isn't yet reflected in the display of the screen.
    ''' </summary>
    ''' <param name="selectCommand"></param>
    ''' <remarks>This procedure refreshes the display in the control after data has changed</remarks>

    Private Sub GetWorksheetData(ByVal selectCommand As String)

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
        Me.bndWorksheets.DataSource = table
    End Sub

    ''' <summary>
    ''' This procedure is called when data from the database table has changed but isn't yet reflected in the display of the screen.
    ''' </summary>
    ''' <param name="selectCommand"></param>
    ''' <remarks>This procedure refreshes the display in the control after data has changed</remarks>

    Private Sub GetOrderData(ByVal selectCommand As String)

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
        Me.bndOrders.DataSource = table
    End Sub

    ''' <summary>
    ''' This procedures attempts to find a customer based on the text that the user has entered prior to pressing the "Enter" key
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub cmbAutoCompleteCustName_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbAutoCompleteCustName.KeyUp
        If e.KeyValue = System.Windows.Forms.Keys.Return Then
            FindCustomer()
            cmbAutoCompleteCustName.ResetText()
        End If
    End Sub

    ''' <summary>
    ''' This procedure resets the customer combo box's text and sets the focus to the same
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>This procedure ensures that the customer combo box is ready for user input each time the application comes back to 
    ''' this form</remarks>

    Private Sub frmCustInfo_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.cmbAutoCompleteCustName.ResetText()
        Me.cmbAutoCompleteCustName.Focus()
    End Sub

    ''' <summary>
    ''' This procedure will open up the worksheet form when the user double clicks a record in the worksheet datagrid
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvWorksheets.CellDoubleClick
        cmdViewEditWs_Click(dgvWorksheets, Nothing)
    End Sub

    ''' <summary>
    ''' This procedure finds a customer when the user selects a customer name from the customer combo box
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub cmbautoCompleteCustName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAutoCompleteCustName.SelectedIndexChanged
        If formloaded And Me.lblName.Text > "" Then
            FindCustomer()
            cmbAutoCompleteCustName.ResetText()
        End If
    End Sub

    ''' <summary>
    ''' This procedure displays a new email window and puts the current customer's email address in the to: box
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub lblCustEmail_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblCustEmail.LinkClicked
        ShellExecute(Me.Handle.ToInt32, "open", "mailto:" & lblCustEmail.Text, "", "", SW_SHOWNORMAL)
    End Sub

    ''' <summary>
    ''' This procedure will load the website that is currently displayed on the customer ship to information screen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub lblCustSHWebsite_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblCustSHWebsite.LinkClicked
        ShellExecute(Me.Handle.ToInt32, "open", lblCustSHWebsite.Text, "", "", SW_SHOWNORMAL)
    End Sub

    ''' <summary>
    ''' This procedure displays a new email window and puts the current customer ship to email address in the to: box
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub lblCustSHEmail_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblCustSHEmail.LinkClicked
        ShellExecute(Me.Handle.ToInt32, "open", "mailto:" & lblCustSHEmail.Text, "", "", SW_SHOWNORMAL)
    End Sub

    ''' <summary>
    ''' This procedure displays a new email window and puts the current customer contact email address in the to: box
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub lblCustContactEmail_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblCustContactEmail.LinkClicked
        ShellExecute(Me.Handle.ToInt32, "open", "mailto:" & lblCustContactEmail.Text, "", "", SW_SHOWNORMAL)
    End Sub

    ''' <summary>
    ''' This procedure displays a new email window and puts the current customer ship to contact email address in the to: box
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub lblCustSHContactEmail_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblCustSHContactEmail.LinkClicked
        ShellExecute(Me.Handle.ToInt32, "open", "mailto:" & lblCustSHContactEmail.Text, "", "", SW_SHOWNORMAL)
    End Sub

    ''' <summary>
    ''' This procedure will email the ASR (Excel spreadsheet in the body of the email) to the address that comes from the 'SalesDeptEmail'
    ''' field in the "Defaults" table
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub cmdEmailASR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdEmailASR.Click
        Dim i As Short
        Dim answer As Short
        Dim foundcomments As Boolean

        'dtgASR_CellLeave(dgvASR, Nothing)
        For i = 0 To dgvASR.RowCount - 1
            If Len(dgvASR.Rows.Item(i).Cells(7).Value) > 0 Then
                foundcomments = True
                Exit For
            End If
        Next
        If foundcomments = False Then
            answer = MsgBox("Are you sure you want to send without comments for all product types?", MsgBoxStyle.YesNo, "ASR")
            If answer = MsgBoxResult.No Then
                Exit Sub
            End If
        End If
        cmdEmailASR.Enabled = False
        'Call CreateASRSpreadsheet(dgvASR)
        Call CreateASRSpreadsheetfromGrid(dgvASR)
        MsgBox("ASR comments were sent!", MsgBoxStyle.Information, "Send ASR comments")
        cmdEmailASR.Enabled = True
    End Sub

    ''' <summary>
    ''' This procedure will email the ASR Notes information (Excel spreadsheet in the body of the email) to the address that comes from the 
    ''' 'SalesDeptEmail' field in the "Defaults" table
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub cmdEmailNotes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdEmailNotes.Click
        Dim tmpAnswer As Short
        If dtpNotesFollowup.Value < CDate(Format(Now, "Short Date")) Then
            MsgBox("Follow-up Date must be today's date or later!", MsgBoxStyle.Critical, "Notes")
            Exit Sub
        End If
        If dtpNotesFollowup.Value.ToShortDateString = Now.ToShortDateString Then
            tmpAnswer = MsgBox("Are you sure that the follow-up date will be today?", MsgBoxStyle.YesNo, "Notes")
            If tmpAnswer = MsgBoxResult.No Then
                MsgBox("Send cancelled.", MsgBoxStyle.Information, "Notes")
                Exit Sub
            End If
        End If
        cmdEmailNotes.Enabled = False
        'Call CreateASRSpreadsheet(dgvNotes)
        Call CreateASRSpreadsheetfromGrid(dgvNotes)
        MsgBox("Notes comments were sent!", MsgBoxStyle.Information, "Send Notes comments")
        cmdEmailNotes.Enabled = True
    End Sub

    ''' <summary>
    ''' This procedure will email the ASR Pass information (Excel spreadsheet in the body of the email) to the address that comes from the 
    ''' 'SalesDeptEmail' field in the "Defaults" table
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub cmdEmailPass_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdEmailPass.Click
        Dim i As Short

        Call dgvPass_CellEndEdit(dgvPass, Nothing)
        For i = 1 To dgvPass.RowCount - 1
            If (Len(Trim(dgvPass.Item(3, i).Value)) = 0) And (CShort(dgvPass.Item(2, i).Value) > 0) Then
                MsgBox("Comments are required for each product type that has a goal before you can send!", MsgBoxStyle.Critical, "Pass")
                Exit Sub
            End If
        Next
        cmdEmailPass.Enabled = False
        'Call CreateASRSpreadsheet(dgvPass)
        Call CreateASRSpreadsheetfromGrid(dgvPass)
        MsgBox("Pass comments were sent!", MsgBoxStyle.Information, "Send Pass Comments")
        cmdEmailPass.Enabled = True
    End Sub

    ''' <summary>
    ''' This procedure prints the history datagrid (Excel spreadsheet) for the current customer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub cmdPrintHistory_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdPrintHistory.Click
        Call CreateASRSpreadsheet(dgvHistory)
    End Sub

    ''' <summary>
    ''' This procedure will update (create/modify) the record in the NotesComments table when the user changes the date time picker value
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub dtpNotesFollowup_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpNotesFollowup.ValueChanged
        Dim cn As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim daSalesman As OleDb.OleDbDataAdapter
        Dim dtSalesman As New DataTable
        Dim daNotesComments As OleDb.OleDbDataAdapter
        Dim dtNotesComments As New DataTable

        ' Check if we have a row in the table already.  If not create one, if so update followupdate

        cn.Open()
        daSalesman = New OleDb.OleDbDataAdapter("SELECT [season] FROM [salesman]", cn)
        daSalesman.Fill(dtSalesman)
        daNotesComments = New OleDb.OleDbDataAdapter("SELECT [followupdate], [notescomments] FROM [notescomments]  WHERE [cust-no] = '" & Me.txtCustNo.Text & "' AND [season] = '" & dtSalesman.Rows(0)("season") & "'", cn)
        daNotesComments.Fill(dtNotesComments)

        cn.Close()

        If dtNotesComments.Rows.Count = 0 Then
            Dim conn As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
            Dim com As New OleDb.OleDbCommand("INSERT INTO NotesComments ([cust-no],[season],[notescomments],[followupdate]) VALUES ('" & bndCustomer.Current("cust-no") & "', '" & dtSalesman.Rows(0)("season") & "', " & Chr(34) & txtNoteGenComments.Text & Chr(34) & ", '" & Me.dtpNotesFollowup.Value & "')", conn)
            conn.Open()
            com.ExecuteNonQuery()
            conn.Close()
        Else
            Dim conn As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
            Dim com As New OleDb.OleDbCommand("UPDATE [notescomments] SET [followupdate] = '" & dtpNotesFollowup.Value & "' WHERE [cust-no] = '" & bndCustomer.Current("cust-no") & "' and [season]  = '" & dtSalesman.Rows(0)("season") & "'", conn)
            conn.Open()
            com.ExecuteNonQuery()
            conn.Close()
        End If
        cn.Close()
        cn.Dispose()
    End Sub

    ''' <summary>
    ''' This procedure will update the CustomerStatus table 'notes' records when the user leaves a cell in the ASR Notes grid
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub dgvNotes_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvNotes.CellEndEdit
        Dim cn As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim daSalesman As OleDb.OleDbDataAdapter
        Dim daProdType As OleDb.OleDbDataAdapter
        Dim daCustStatus As New SaleForcDataSetTableAdapters.CustomerStatusTableAdapter
        Dim daCustStatus2 As OleDb.OleDbDataAdapter
        Dim dtSalesman As New DataTable
        Dim dtProdType As New DataTable
        Dim dtCustStatus As New DataTable

        cn.Open()

        If dgvNotes.CurrentCell Is Nothing Or dgvNotes.CurrentCell.RowIndex = 0 Then Exit Sub

        If dgvNotes.CurrentCell.ColumnIndex = 3 And CStr(dgvNotes.Item(3, dgvNotes.CurrentCell.RowIndex).EditedFormattedValue) = "" And CStr(dgvNotes.Item(3, dgvNotes.CurrentCell.RowIndex).Value) = "" Then
            Exit Sub
        ElseIf dgvNotes.CurrentCell.ColumnIndex = 3 And (CStr(dgvNotes.Item(3, dgvNotes.CurrentCell.RowIndex).EditedFormattedValue) > "" Or CStr(dgvNotes.Item(3, dgvNotes.CurrentCell.RowIndex).Value) > "") Then

            daSalesman = New OleDb.OleDbDataAdapter("SELECT [season] FROM [salesman]", cn)
            daSalesman.Fill(dtSalesman)

            daProdType = New OleDb.OleDbDataAdapter("SELECT [prodtype] FROM [prodtype] WHERE [prodtype] = '" & dgvNotes.Rows.Item(dgvNotes.CurrentCell.RowIndex).Cells(0).Value & "'", cn)
            daProdType.Fill(dtProdType)

            daCustStatus2 = New OleDb.OleDbDataAdapter("SELECT * FROM [customerstatus] WHERE [cust-no] = '" & bndCustomer.Current("cust-no") & "' AND [season] = '" & dtSalesman.Rows(0)("season") & "' AND [prodtype] = '" & dtProdType.Rows(0)("prodtype") & "' AND [ordercode] Is Null AND [stcode] = 'note'", cn)
            daCustStatus2.Fill(dtCustStatus)

            If dtCustStatus.Rows.Count = 0 Then
                Dim conn As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
                Dim com As New OleDb.OleDbCommand("INSERT INTO CustomerStatus ([cust-no],[season],[prodtype],[stcode],[statuscomments]) VALUES ('" & bndCustomer.Current("cust-no") & "', '" & dtSalesman.Rows(0)("season") & "', '" & dtProdType.Rows(0)("prodtype") & "', 'note', " & Chr(34) & dgvNotes.Item(3, dgvNotes.CurrentCell.RowIndex).EditedFormattedValue & Chr(34) & ")", conn)
                conn.Open()
                com.ExecuteNonQuery()
                conn.Close()
            Else
                Dim conn As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
                Dim com As New OleDb.OleDbCommand("UPDATE [customerstatus] SET statuscomments = " & Chr(34) & dgvNotes.Item(3, dgvNotes.CurrentCell.RowIndex).EditedFormattedValue & Chr(34) & " WHERE [cust-no] = '" & bndCustomer.Current("cust-no") & "' and [season]  = '" & dtSalesman.Rows(0)("season") & "' and [prodtype] = '" & dtProdType.Rows(0)("prodtype") & "' and [stcode] = 'note'", conn)
                conn.Open()
                com.ExecuteNonQuery()
                conn.Close()
            End If
        End If
        cn.Close()
        cn.Dispose()
    End Sub

    ''' <summary>
    ''' This procedure makes a call to update the general comments of the Notes ASR in the CustomerStatus table when the Notes grid 
    ''' loses focus
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub dtgNotes_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvNotes.Leave
        WriteNotesGeneralComments()
    End Sub

    ''' <summary>
    ''' This procedure will update the CustomerStatus table 'pass' records when the user leaves a cell in the ASR Pass grid
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub dgvPass_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPass.CellEndEdit
        Dim cn As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim daSalesman As OleDb.OleDbDataAdapter
        Dim daProdType As OleDb.OleDbDataAdapter
        Dim daCustStatus As New SaleForcDataSetTableAdapters.CustomerStatusTableAdapter
        Dim daCustStatus2 As OleDb.OleDbDataAdapter
        Dim dtSalesman As New DataTable
        Dim dtProdType As New DataTable
        Dim dtCustSeasProj As New DataTable
        Dim dtCustStatus As New DataTable

        If dgvPass.CurrentCell Is Nothing Then Exit Sub
        If dgvPass.CurrentCell.RowIndex = 0 Then Exit Sub

        cn.Open()

        If dgvPass.CurrentCell.ColumnIndex = 3 And dgvPass.Item(3, dgvPass.CurrentCell.RowIndex).EditedFormattedValue = "" And dgvPass.Item(3, dgvPass.CurrentCell.RowIndex).Value = "" Then
            Exit Sub
        ElseIf dgvPass.CurrentCell.ColumnIndex = 3 And (dgvPass.Item(3, dgvPass.CurrentCell.RowIndex).EditedFormattedValue > "" Or dgvPass.Item(3, dgvPass.CurrentCell.RowIndex).Value > "") Then

            daSalesman = New OleDb.OleDbDataAdapter("SELECT [season] FROM Salesman", cn)
            daSalesman.Fill(dtSalesman)

            daProdType = New OleDb.OleDbDataAdapter("SELECT [prodtype] FROM ProdType WHERE prodtype = '" & dgvPass.Item(0, dgvPass.CurrentCell.RowIndex).Value & "'", cn)
            daProdType.Fill(dtProdType)

            daCustStatus2 = New OleDb.OleDbDataAdapter("SELECT * from [customerstatus] WHERE [cust-no] = '" & bndCustomer.Current("cust-no") & "' AND [season] = '" & dtSalesman.Rows(0)("season") & "' AND [prodtype] = '" & dtProdType.Rows(0)("prodtype") & "' AND [ordercode] Is Null AND [stcode] = 'pass'", cn)
            daCustStatus2.Fill(dtCustStatus)

            If dtCustStatus.Rows.Count = 0 Then
                Dim conn As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
                Dim com As New OleDb.OleDbCommand("INSERT INTO CustomerStatus ([cust-no],[season],[prodtype],[statuscomments],[stcode]) VALUES ('" & bndCustomer.Current("cust-no") & "', '" & dtSalesman.Rows(0)("season") & "', '" & dtProdType.Rows(0)("prodtype") & "', " & Chr(34) & dgvPass.Item(3, e.RowIndex).EditedFormattedValue & Chr(34) & ", 'pass')", conn)
                conn.Open()
                com.ExecuteNonQuery()
                conn.Close()
            Else
                Dim conn As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
                Dim com As New OleDb.OleDbCommand("UPDATE [customerstatus] SET statuscomments = " & Chr(34) & dgvPass.Item(3, dgvPass.CurrentCell.RowIndex).EditedFormattedValue & Chr(34) & " WHERE [cust-no] = '" & bndCustomer.Current("cust-no") & "' and [season]  = '" & dtSalesman.Rows(0)("season") & "' and [prodtype] = '" & dtProdType.Rows(0)("prodtype") & "' and [stcode] = 'pass'", conn)
                conn.Open()
                com.ExecuteNonQuery()
                conn.Close()
            End If
        End If
        cn.Close()
        cn.Dispose()
    End Sub

    ''' <summary>
    ''' This procedure makes a call to update the general comments of the Notes ASR in the CustomerStatus table when the General Comments
    ''' text box loses focus
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub txtNoteGenComments_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoteGenComments.Leave
        WriteNotesGeneralComments()
    End Sub

    ''' <summary>
    ''' I have no clue what this procedure does - it doesn't make any sense to me.  Probably doesn't work or get to the 'then' part
    ''' but I don't want to modify it because I haven't seen any errors come from it
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub txtNotesComments_Enter1(ByVal sender As Object, ByVal e As System.EventArgs)
         If dgvNotes.RowCount > 0 Then
            If dgvNotes.CurrentCell.ColumnIndex >= dgvNotes.ColumnCount Then dgvNotes.CurrentCell = dgvNotes.Rows(1).Cells(1)
        End If
    End Sub

    ''' <summary>
    ''' This procedure will see if the customer has a record in the customer ship to table
    ''' </summary>
    ''' <param name="cCusNum">The customer number</param>
    ''' <returns>A boolean indicating the the customer has a ship to record (true) or does not have a ship to record (false)</returns>
    ''' <remarks></remarks>

    Public Function isCustInShipFile(ByRef cCusNum As String) As Boolean
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim daCustSh As New SaleForcDataSetTableAdapters.CustomerSHTableAdapter
        Dim dtCustSh As SaleForcDataSet.CustomerSHDataTable
        Dim drCustSh() As SaleForcDataSet.CustomerSHRow

        con.Open()
        dtCustSh = daCustSh.GetData

        If Trim(cCusNum) = "" Then
            isCustInShipFile = False
            Exit Function 'If there are no values, get out of here
        End If

        drCustSh = dtCustSh.Select("[cust-no] = '" & cCusNum & "'")
        If drCustSh.Length = 0 Then
            isCustInShipFile = False
        Else
            isCustInShipFile = True
        End If

        con.Close()
    End Function

    ''' <summary>
    ''' This procedure makes a call to FindCustomer to locate a record in the customer table and then clears the text in the customer 
    ''' combo box
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        If formloaded Then
            FindCustomer()
            cmbAutoCompleteCustName.ResetText()
        End If
    End Sub

    ''' <summary>
    ''' This procedure will open the order form and display the data for the selected order
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub dgvOrders_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvOrders.CellDoubleClick
        Me.cmdViewOrder_Click(cmdViewOrder, New System.EventArgs)
    End Sub

    ''' <summary>
    ''' This procedure will enable the Retransmit button if the worksheet's transmitted status is set to True
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub dgvWorksheets_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvWorksheets.CellEnter
        If bndWorksheets.Current("xmitted") = True Then
            cmdRetransmit.Enabled = True
        Else
            cmdRetransmit.Enabled = False
        End If
    End Sub

    'Private Function CheckForWSMemos() As Boolean
    '    Dim SQLResult As Boolean
    '    Dim dbConnection As OleDb.OleDbConnection = New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
    '    Dim SQL As New OleDb.OleDbCommand
    '    Dim i As Integer

    '    dbConnection.Open()
    '    SQL.Connection = dbConnection
    '    i = dgvWorksheets.CurrentRow.Index
    '    SQL.CommandText = "SELECT COUNT (*) AS [RecordCount] FROM wsmemo WHERE [worksheet-id] = '" & dgvWorksheets.Item(0, i).Value & "'"
    '    SQLResult = Convert.ToBoolean(SQL.ExecuteScalar)
    '    If SQLResult = True Then
    '        CheckForWSMemos = True
    '    Else
    '        CheckForWSMemos = False
    '    End If
    'End Function

    ''' <summary>
    ''' This procedure will display a webbrowser that loads a Google map for the current customer
    ''' </summary>
    ''' <param name="StreetString"></param>
    ''' <param name="CityString"></param>
    ''' <param name="StateString"></param>
    ''' <param name="ZipString"></param>
    ''' <remarks></remarks>

    Private Sub MapIt(ByRef StreetString As String, ByRef CityString As String, ByRef StateString As String, ByRef ZipString As String)

        'Try
        Dim street As String = String.Empty
        Dim city As String = String.Empty
        Dim state As String = String.Empty
        Dim zip As String = String.Empty

        Dim queryAddress As New System.Text.StringBuilder()
        queryAddress.Append("http://maps.google.com/maps?q=")

        ' build street part of query string
        If StreetString <> String.Empty Then
            street = StreetString.Replace(" ", "+")
            queryAddress.Append(street + "," & "+")
        End If

        ' build city part of query string
        If CityString <> String.Empty Then
            city = CityString.Replace(" ", "+")
            queryAddress.Append(city + "," & "+")
        End If

        ' build state part of query string
        If StateString <> String.Empty Then
            state = StateString.Replace(" ", "+")
            queryAddress.Append(state + "," & "+")
        End If

        ' build zip code part of query string
        If ZipString <> String.Empty Then
            zip = ZipString.ToString()
            queryAddress.Append(zip)
        End If

        queryAddress.Append("&output=embed")

        ' pass the url with the query string to web browser control
        WebBrowser2.BringToFront()
        WebBrowser2.Visible = True
        WebBrowser2.Width = 785
        WebBrowser2.Height = 434
        btnCloseMap.Visible = True
        btnCloseMap.BringToFront()
        btnPrintMap.Visible = True
        btnPrintMap.BringToFront()
        Try
            WebBrowser2.Navigate(New Uri(queryAddress.ToString))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message.ToString(), "Unable to Retrieve Map")
        'End Try
    End Sub

    ''' <summary>
    ''' This procedure makes a call to the MapIt procedure to display a map that shows the current customer's location 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub btnMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMap.Click
        Dim street As String
        If bndCustomer.Current Is Nothing Then
            MsgBox("No customer selected!", MsgBoxStyle.Exclamation, "Map Customer Address")
        Else
            street = bndCustomer.Current("address1") & " " & bndCustomer.Current("address2") & " " & bndCustomer.Current("address3")
            Call MapIt(street, bndCustomer.Current("city"), bndCustomer.Current("st"), bndCustomer.Current("zip-code"))
        End If
    End Sub

    ''' <summary>
    ''' This procedure closes the webbrowser that displays a map for the current customer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseMap.Click
        WebBrowser2.Visible = False
        btnCloseMap.Visible = False
        btnPrintMap.Visible = False
    End Sub

    ''' <summary>
    ''' This procedure will print a map with the current customer's location
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub btnPrintMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintMap.Click
        WebBrowser2.Print()
    End Sub

    ''' <summary>
    ''' If this checkbox is checked, the program will copy the customer information to the customer ship-to side of the screen when 
    ''' creating a new customer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCopyCust2CustSh.CheckedChanged
        If chkCopyCust2CustSh.Checked Then
            mebShipName.Text = mebName.Text
            mebShipAddr1.Text = mebAddr1.Text
            mebShipAddr2.Text = mebAddr2.Text
            mebShipAddr3.Text = mebAddr3.Text
            mebShipCity.Text = mebCity.Text
            mebShipSt.Text = mebState.Text
            mebShipZipCode.Text = mebZipCode.Text
            mebCustShEmail.Text = mebCustEmail.Text
            mebShipPhone.Text = mebPhoneNo.Text
            mebShipFax.Text = mebFaxNo.Text
            mebShipContact.Text = mebContact.Text
            mebCustShContactEmail.Text = mebCustContactEmail.Text
        Else
            mebShipName.Text = ""
            mebShipAddr1.Text = ""
            mebShipAddr2.Text = ""
            mebShipAddr3.Text = ""
            mebShipCity.Text = ""
            mebShipSt.Text = ""
            mebShipZipCode.Text = ""
            mebCustShEmail.Text = ""
            mebShipPhone.Text = ""
            mebShipFax.Text = ""
            mebShipContact.Text = ""
            mebCustShContactEmail.Text = ""
        End If
    End Sub

    ''' <summary>
    ''' This procedure copies the fax number from the customer to the customer ship to side of the screen when creating a new customer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub mebFaxNo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mebFaxNo.KeyUp
        If chkCopyCust2CustSh.Checked Then
            mebShipFax.Text = mebFaxNo.Text
        End If
    End Sub

    ''' <summary>
    ''' This procedure copies the customer contact email address from the customer to the customer ship to side of the screen when 
    ''' creating a new customer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub mebCustContactEmail_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mebCustContactEmail.KeyUp
        If chkCopyCust2CustSh.Checked Then
            mebCustShContactEmail.Text = mebCustContactEmail.Text
        End If
    End Sub

    ''' <summary>
    ''' This procedure copies the contact name from the customer to the customer ship to side of the screen when creating a new customer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub mebContact_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mebContact.KeyUp
        If chkCopyCust2CustSh.Checked Then
            mebShipContact.Text = mebContact.Text
        End If
    End Sub

    ''' <summary>
    ''' This procedure copies the customer zip code from the customer to the customer ship to side of the screen when creating a
    ''' new customer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub mebZipCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mebZipCode.KeyUp
        If chkCopyCust2CustSh.Checked Then
            mebShipZipCode.Text = mebZipCode.Text
        End If
    End Sub

    ''' <summary>
    ''' This procedure copies the state from the customer to the customer ship to side of the screen when creating a new customer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub mebState_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mebState.KeyUp
        If chkCopyCust2CustSh.Checked Then
            mebShipSt.Text = mebState.Text
        End If
    End Sub

    ''' <summary>
    ''' This procedure copies the city from the customer to the customer ship to side of the screen when creating a new customer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub mebCity_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mebCity.KeyUp
        If chkCopyCust2CustSh.Checked Then
            mebShipCity.Text = mebCity.Text
        End If
    End Sub

    ''' <summary>
    ''' This procedure copies Address3 from the customer to the customer ship to side of the screen when creating a new customer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub mebAddr3_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mebAddr3.KeyUp
        If chkCopyCust2CustSh.Checked Then
            mebShipAddr3.Text = mebAddr3.Text
        End If
    End Sub

    ''' <summary>
    ''' This procedure copies Address2 from the customer to the customer ship to side of the screen when creating a new customer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub mebAddr2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mebAddr2.KeyUp
        If chkCopyCust2CustSh.Checked Then
            mebShipAddr2.Text = mebAddr2.Text
        End If
    End Sub

    ''' <summary>
    ''' This procedure copies Address1 from the customer to the customer ship to side of the screen when creating a new customer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub mebAddr1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mebAddr1.KeyUp
        If chkCopyCust2CustSh.Checked Then
            mebShipAddr1.Text = mebAddr1.Text
        End If
    End Sub

    ''' <summary>
    ''' This procedure copies the customer name from the customer to the customer ship to side of the screen when creating a new customer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub mebName_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mebName.KeyUp
        If chkCopyCust2CustSh.Checked Then
            mebShipName.Text = mebName.Text
        End If
    End Sub

    ''' <summary>
    ''' This procedure copies the customer email address from the customer to the customer ship to side of the screen when creating a 
    ''' new customer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub mebCustEmail_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mebCustEmail.KeyUp
        If chkCopyCust2CustSh.Checked Then
            mebCustShEmail.Text = mebCustEmail.Text
        End If
    End Sub

    ''' <summary>
    ''' This procedure copies the customer phone number from the customer to the customer ship to side of the screen when creating a 
    ''' new customer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub mebPhoneNo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mebPhoneNo.KeyUp
        If chkCopyCust2CustSh.Checked Then
            mebShipPhone.Text = mebPhoneNo.Text
        End If
    End Sub
    Private Sub CreateASRSpreadsheetfromGrid(ByRef tmpDataGrid As DataGridView)
        Dim i As Integer = Nothing
        Dim j As Integer = Nothing
        Dim cFilenam As String = Nothing
        Dim xl As New Microsoft.Office.Interop.Excel.Application
        Dim xlwbooks As Microsoft.Office.Interop.Excel.Workbooks
        Dim xlwbook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlsheet As Microsoft.Office.Interop.Excel.Worksheet

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        ''delete old ASR temp file
        If tmpDataGrid.Name = "dgvASR" Then
            cFilenam = GetProgramDefaults("TempFilePath") & "ASR" & Me.txtCustNo.Text
        ElseIf tmpDataGrid.Name = "dgvNotes" Then
            cFilenam = GetProgramDefaults("TempFilePath") & "ASR" & Me.txtCustNo.Text & "Notes"
        ElseIf tmpDataGrid.Name = "dgvPass" Then
            cFilenam = GetProgramDefaults("TempFilePath") & "ASR" & Me.txtCustNo.Text & "Pass"
        ElseIf tmpDataGrid.Name = "dgvHistory" Then
            cFilenam = GetProgramDefaults("TempFilePath") & "ASR" & Me.txtCustNo.Text & "History"
        End If

        Select Case xl.Version
            Case "15.0", "14.0", "13.0", "12.0"
                cFilenam = cFilenam & ".xlsx"               
            Case "11.0"
                cFilenam = cFilenam & ".xls"
        End Select

        If Dir(cFilenam) > "" Then Kill(cFilenam)

        xlwbooks = xl.Workbooks
        xlwbook = xlwbooks.Add
        xlsheet = xlwbook.ActiveSheet


        xlsheet.Cells(2, 1) = "Season:"
        xlsheet.Cells(2, 2) = cSalesSeason
        xlsheet.Cells(3, 1) = "Rep: "
        xlsheet.Cells(3, 2) = cSalesmanName
        xlsheet.Cells(4, 1) = "Customer: "
        xlsheet.Cells(4, 2) = Me.lblName.Text & " (" & Me.txtCustNo.Text & ")"
        If tmpDataGrid.Name = "dgvASR" Then
            xlsheet.Cells(1, 2) = "Account Status Report"
            For i = 0 To dgvASR.RowCount - 2
                For j = 0 To dgvASR.ColumnCount - 1
                    For k As Integer = 3 To dgvASR.Columns.Count
                        xlsheet.Cells(4, k) = dgvASR.Columns(k - 1).HeaderText
                        'xlsheet.Cells(i + 6, j + 1) = dgvASR(j, i).Value
                    Next
                    xlsheet.Cells(i + 5, j + 1) = dgvASR(j, i).Value
                Next
            Next
            xlsheet.UsedRange.Columns.EntireColumn.AutoFit()
            xlsheet.Range("B1:H1").Columns.EntireColumn.AutoFit()
            'xlsheet.Range("A6:G6").Rows.WrapText = True
            'xlsheet.Cells.Columns("C:G").ColumnWidth = 10
            'xlsheet.Cells.Columns("E:E").ColumnWidth = 19
            'xlsheet.Cells.Columns("G:G").ColumnWidth = 19
            'xlsheet.Cells.Columns("H:H").ColumnWidth = 30
            'xlsheet.UsedRange.Rows.WrapText = True
            xlsheet.UsedRange.Font.Size = 10
            xlsheet.Cells.Columns("C:G").HorizontalAlignment = -4108
            xlsheet.Cells.Columns("A:G").AutoFit()
            xlsheet.Range("H:H").Columns.ColumnWidth = 40
            xlsheet.Range("H:H").Columns.WrapText = True
            xlsheet.Range("c5", "h5").Interior.ColorIndex = 15
        End If
        If tmpDataGrid.Name = "dgvNotes" Then
            xlsheet.Cells(1, 2) = "Notes"
            For i = 0 To dgvNotes.RowCount - 2
                For j = 0 To dgvNotes.ColumnCount - 1
                    For k As Integer = 3 To dgvNotes.Columns.Count
                        xlsheet.Cells(4, k) = dgvNotes.Columns(k - 1).HeaderText
                    Next
                    xlsheet.Cells(i + 5, j + 1) = dgvNotes(j, i).Value
                Next
            Next
            'xlsheet.Cells.Columns("B:B").ColumnWidth = 50
            xlsheet.Range("c5", "d5").Interior.ColorIndex = 15
            xlsheet.Cells.Columns("C:C").HorizontalAlignment = -4108
            xlsheet.Cells.Columns("A:D").Autofit()
            xlsheet.Range("D:D").Columns.ColumnWidth = 40
            xlsheet.Range("D:D").Columns.WrapText = True
        End If
        If tmpDataGrid.Name = "dgvPass" Then
            xlsheet.Cells(1, 2) = "Passed"
            For i = 0 To dgvPass.RowCount - 2
                For j = 0 To dgvPass.ColumnCount - 1
                    For k As Integer = 3 To dgvPass.Columns.Count
                        xlsheet.Cells(4, k) = dgvPass.Columns(k - 1).HeaderText
                    Next
                    xlsheet.Cells(i + 5, j + 1) = dgvPass(j, i).Value
                Next
            Next
            'xlsheet.Cells.Columns("B:B").ColumnWidth = 50
            xlsheet.Range("c5", "d5").Interior.ColorIndex = 15
            xlsheet.Cells.Columns("C:C").HorizontalAlignment = -4108
            xlsheet.Cells.Columns("A:C").AutoFit()
            xlsheet.Range("D:D").Columns.ColumnWidth = 40
            xlsheet.Range("D:D").Columns.WrapText = True
        End If
        If tmpDataGrid.Name = "dgvHistory" Then
            xlsheet.Cells(1, 2) = "History"
            For i = 0 To dgvHistory.RowCount - 2
                For j = 0 To dgvHistory.ColumnCount - 1
                    For k As Integer = 3 To dgvHistory.Columns.Count
                        xlsheet.Cells(4, k) = dgvHistory.Columns(k - 1).HeaderText
                        xlsheet.Cells(i + 5, j + 1) = dgvHistory(j, i).Value
                    Next
                Next
            Next
            'xlsheet.Cells.Columns("B:G").AutoFit()
            xlsheet.Range("c5", "d5").Interior.ColorIndex = 15
            xlsheet.UsedRange.AutoFit()
            xlsheet.Range("D:D").Columns.ColumnWidth = 40
            xlsheet.Range("D:D").Columns.WrapText = True
        End If

        xlsheet.Range("b1", "b1").Interior.ColorIndex = 28
        xlsheet.Range("a2", "a4").Interior.ColorIndex = 15
        xlsheet.Range("a6", "a" & CStr(dgvASR.RowCount + 4)).Interior.ColorIndex = 15
        xlsheet.Range("b6", "b" & CStr(dgvASR.RowCount + 4)).Interior.ColorIndex = 15

        xlsheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape
        xlsheet.PageSetup.PrintGridlines = True
        xlsheet.UsedRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous
        xlsheet.Range("c1:H4").Borders.LineStyle = Excel.XlLineStyle.xlLineStyleNone
        xlsheet.Range("b1:b1").HorizontalAlignment = -4108

        xl.DisplayAlerts = True

        If tmpDataGrid.Name <> "dgvHistory" Then
            With xlsheet.MailEnvelope.Item
                xlsheet.MailEnvelope.Item.To = GetProgramDefaults("SalesDeptEmail")
                If tmpDataGrid.Name = "dgvASR" Then
                    xlsheet.MailEnvelope.Item.subject = cSalesSeason & " ASR - " & Me.lblName.Text & " (" & Me.txtCustNo.Text & ")"
                ElseIf tmpDataGrid.Name = "dgvNotes" Then
                    xlsheet.MailEnvelope.Item.subject = cSalesSeason & " Notes - " & Me.lblName.Text & " (" & Me.txtCustNo.Text & ")"
                ElseIf tmpDataGrid.Name = "dgvPass" Then
                    xlsheet.MailEnvelope.Item.subject = cSalesSeason & " Pass - " & Me.lblName.Text & " (" & Me.txtCustNo.Text & ")"
                End If
                xlsheet.MailEnvelope.Item.Send()
            End With
        End If


        If tmpDataGrid.Name = "dgvHistory" Then
            PrintDialog1.ShowDialog()
            xlsheet.PrintOutEx(1, 1, 1, False, PrintDialog1.PrinterSettings.PrinterName, False, False, False, False)
        End If

        xl.DisplayAlerts = False
        xlwbook.SaveAs(cFilenam)
        'If tmpDataGrid.Name = "dgvASR" Then
        '    xlwbook.SaveAs(GetProgramDefaults("TempFilePath") & "ASR" & Me.txtCustNo.Text & ".xlsx")
        'ElseIf tmpDataGrid.Name = "dgvNotes" Then
        '    xlwbook.SaveAs(GetProgramDefaults("TempFilePath") & "Notes" & Me.txtCustNo.Text & ".xlsx")
        'ElseIf tmpDataGrid.Name = "dgvPass" Then
        '    xlwbook.SaveAs(GetProgramDefaults("TempFilePath") & "Pass" & Me.txtCustNo.Text & ".xlsx")
        'End If
        xl.ActiveWorkbook.Save()
        xl.ActiveWorkbook.Close()
        xl.Quit()
        System.Runtime.InteropServices.Marshal.FinalReleaseComObject(xl)
        xlsheet = Nothing
        xlwbook = Nothing
        xl = Nothing


    End Sub
End Class