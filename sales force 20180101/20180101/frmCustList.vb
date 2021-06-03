Option Strict Off
Option Explicit On
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Windows.Forms.Form


Friend Class frmCustList
    Inherits System.Windows.Forms.Form
    Dim lOkToPrt As Boolean
    Private dataadapter As New OleDb.OleDbDataAdapter
    Dim commandbuilder As OleDb.OleDbCommandBuilder = New OleDb.OleDbCommandBuilder(dataadapter)
    Dim strCommand As String

    ''' <summary>
    ''' This procedure will filter the customer list to display customer records where the status-code field is set to "P" when the 
    ''' chkViewActiveOnly is check; when unchecked all customers are displayed
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub chkViewActiveOnly_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkViewActiveOnly.CheckStateChanged
        If chkViewActiveOnly.CheckState = System.Windows.Forms.CheckState.Checked Then
            Me.bndCustomers.Filter = "[Slsmn-code] = " & Chr(39) & cSalesmanCode & Chr(39) & " AND ([Status-code] = " & Chr(39) & "P" & Chr(39) & " OR [Status-code] = " & Chr(39) & "p" & Chr(39) & ")"
            ViewActiveCustomers = True
        Else
            Me.bndCustomers.Filter = "[Slsmn-code] = " & Chr(39) & cSalesmanCode & Chr(39)

            ViewActiveCustomers = False
        End If
        Me.bndCustomers.Sort = "Name"
        lblCustomerCount.Text = CStr(Me.bndCustomers.Count)
    End Sub

    ''' <summary>
    ''' This procedure will show the customer information screen and display the data for the seleted customer
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmdCustomer_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCustomer.Click
        cCustNumber = Me.bndCustomers.Current("cust-no")
        fromLocation = "CustList"
        Me.Hide()
        If chkViewActiveOnly.Checked = False Then
            frmCustInfo.chkViewActiveCust.Checked = False
        End If
        frmCustInfo.ShowDialog()
        Me.Show()
    End Sub

    ''' <summary>
    ''' This procedure closes the form
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmdExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExit.Click
        'cmdSelectAll_Click(Nothing, Nothing)
        Me.Close()
    End Sub

    ''' <summary>
    ''' This procedure will deselect the "Print" checkbox for each customer
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks>Clearing the print checkbox for the customer tells the system to not include that customer when printing a list
    ''' of customers</remarks>

    Private Sub cmdClearAll_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClearAll.Click
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim com As New OleDb.OleDbCommand("UPDATE Customer SET [PrtSelect] = No", con)
        Dim connectionString As String = MySettings.Default("SaleForcConnectionString")

        con.Open()
        com.ExecuteNonQuery()
        con.Close()

        strCommand = CustomerTableAdapter.Adapter.SelectCommand.CommandText
        Me.dataadapter = New OleDb.OleDbDataAdapter(strCommand, connectionString)
        Dim commandbuilder As New OleDb.OleDbCommandBuilder(Me.dataadapter)
        Dim table As New DataTable()
        table.Locale = System.Globalization.CultureInfo.InvariantCulture
        Me.dataadapter.Fill(table)
        Me.bndCustomers.DataSource = table
        Me.dtgCustList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

        lOkToPrt = False
        cmdPrint.Enabled = False
        cmdPrtPreview.Enabled = False
    End Sub

    ''' <summary>
    ''' This procedure will find a customer using the name field in the customer table using the characters entered by the user in the 
    ''' inputbox
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmdFindCust_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFindCust.Click
        Dim strFind As String
        Dim strSql As String

        strFind = InputBox("Customer Name:" & vbCrLf & vbCrLf & "(You can type in the first few characters to find the closest match)", "Find Customer")
        If Me.chkViewActiveOnly.Checked Then
            strSql = "name like '" & strFind & "%' and ([status-code] = 'P' or [status-code] = 'p') and [slsmn-code] = '" & cSalesmanCode & "'"
        Else
            strSql = "name like '" & strFind & "%'"
        End If
        Dim dr() As DataRow = Me.SaleForcDataSet.Customer.Select(strSql, "Name")
        If dr.GetUpperBound(0) >= 0 Then
            Me.bndCustomers.Position = bndCustomers.Find("Name", dr(0)("Name").ToString)
        Else
            MsgBox("Customer can not be found!", MsgBoxStyle.Critical, "Find Customer")
        End If
    End Sub

    ''' <summary>
    ''' This procedure will print a list of customers.  The 'prtselect' field of the customer record must be set to true in order for that
    ''' record to be included on the report
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        Dim Report As New CustomerListReport
        Dim crxDatabaseField As DatabaseFieldDefinition = Nothing
        Dim mySortField As SortField
        Dim tbl As CrystalDecisions.CrystalReports.Engine.Table
        Dim crTableLogonInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Dim crConnectionLogonInfo As New CrystalDecisions.Shared.ConnectionInfo

        If Not lOkToPrt Then
            Call MsgBox("Nothing Selected to Print", MsgBoxStyle.Critical, "Print Customer List")
            Exit Sub
        End If

        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Report.Load(System.AppDomain.CurrentDomain.BaseDirectory & "\CustomerListReport.rpt")

            For Each tbl In Report.Database.Tables
                crTableLogonInfo = tbl.LogOnInfo
                tbl.LogOnInfo.ConnectionInfo.ServerName = dbName
                tbl.LogOnInfo.ConnectionInfo.DatabaseName = dbName
                tbl.ApplyLogOnInfo(crTableLogonInfo)
                tbl.Location = dbName
            Next

            Select Case nListIndex
                Case 0      'CustName
                    crxDatabaseField = Report.Database.Tables("Customer").Fields("Name")
                Case 1      'City
                    crxDatabaseField = Report.Database.Tables("Customer").Fields("City")
                Case 2      'State
                    crxDatabaseField = Report.Database.Tables("Customer").Fields("St")
            End Select

            mySortField = Report.DataDefinition.SortFields(0)
            mySortField.Field = crxDatabaseField

            If ViewActiveCustomers Then
                Report.RecordSelectionFormula = "{customer.slsmn-code} = '" & cSalesmanCode & "' and {customer.prtselect} = true and ({customer.status-code} = 'P' or {customer.status-code} = 'p')"
            Else
                Report.RecordSelectionFormula = "{customer.slsmn-code} = '" & cSalesmanCode & "' and {customer.prtselect} = true"
            End If

            Report.SetDatabaseLogon("Admin", "")

            Report.PrintOptions.PrinterName = PrintDialog1.PrinterSettings.PrinterName
            Report.PrintToPrinter(PrintDialog1.PrinterSettings.Copies, PrintDialog1.PrinterSettings.Collate, PrintDialog1.PrinterSettings.FromPage, PrintDialog1.PrinterSettings.ToPage)
        End If
    End Sub

    ''' <summary>
    ''' This procedure will load the frmPreviewCustList form to allow the user to preview a customer list report
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmdPrtPreview_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrtPreview.Click
        frmPreviewCustList.ShowDialog()
    End Sub

    ''' <summary>
    ''' This procedure will set the 'prtselect' field in the customer table for all customer records
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmdSelectAll_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSelectAll.Click
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim com As New OleDb.OleDbCommand("UPDATE DISTINCTROW Customer SET [PrtSelect] = Yes", con)
        Dim connectionString As String = MySettings.Default("SaleForcConnectionString")

        con.Open()
        com.ExecuteNonQuery()
        con.Close()

        strCommand = CustomerTableAdapter.Adapter.SelectCommand.CommandText
        Me.dataadapter = New OleDb.OleDbDataAdapter(strCommand, connectionString)
        Dim commandbuilder As New OleDb.OleDbCommandBuilder(Me.dataadapter)
        Dim table As New DataTable()
        table.Locale = System.Globalization.CultureInfo.InvariantCulture
        Me.dataadapter.Fill(table)
        Me.bndCustomers.DataSource = table
        Me.dtgCustList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

        lOkToPrt = True
        cmdPrint.Enabled = True
        cmdPrtPreview.Enabled = True
    End Sub

    ''' <summary>
    ''' This procedures fires when the form is loaded.  It sets the sort  order of the customer list.
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub frmCustList_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        lOkToPrt = True
        dtgCustList.Focus()
        Select Case nListIndex
            Case 0
                SortByName.Checked = True
            Case 1
                SortByCity.Checked = True
            Case 2
                SortByState.Checked = True
        End Select
        Frame2.Refresh()
    End Sub

    ''' <summary>
    ''' This procedure fires when the form is loaded.  It loads the data from the customer table into the grid.
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub frmCustList_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Me.CustomerTableAdapter.Fill(Me.SaleForcDataSet.Customer)
        Dim ViewCurrentRepCustOnly As Boolean

        ViewCurrentRepCustOnly = CBool(GetProgramDefaults("ViewCurrentRepCustOnly"))

        If chkViewActiveOnly.CheckState = System.Windows.Forms.CheckState.Checked Then
            Me.bndCustomers.Filter = "[Slsmn-code] = " & Chr(39) & cSalesmanCode & Chr(39) & " AND [Status-code] = " & Chr(39) & "P" & Chr(39)
            Me.bndCustomers.Sort = "Name"
        Else
            Me.bndCustomers.Filter = "[Slsmn-code] = " & Chr(39) & cSalesmanCode & Chr(39)
            Me.bndCustomers.Sort = "Name"
        End If
        lblCustomerCount.Text = CStr(Me.bndCustomers.Count)
    End Sub


    'Private Sub dtgCustList_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSDataGridLib.DDataGridEvents_KeyPressEvent)
    '    If eventArgs.keyAscii <> System.Windows.Forms.Keys.Space Then Exit Sub
    '    If dtgCustList.Columns(0).Value = False Then
    '        dtgCustList.Columns(0).Value = True
    '        lOkToPrt = True
    '        cmdPrint.Enabled = True
    '    Else
    '        dtgCustList.Columns(0).Value = False
    '    End If

    '    If Not adoCustList.Recordset.EOF Then
    '        System.Windows.Forms.SendKeys.SendWait("{down}")
    '    Else
    '        System.Windows.Forms.SendKeys.SendWait("{up}")
    '    End If
    'End Sub	

    ''' <summary>
    ''' This procedure moves the datagrid cursor to the current customer record
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub dtgCustList_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgCustList.CurrentCellDirtyStateChanged
        bndCustomers.ResetItem(bndCustomers.Position)
    End Sub

    ''' <summary>
    ''' This procedure changes the sort order of the customer list to sort by Customer Name
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub SortByName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SortByName.CheckedChanged
        nListIndex = 0
        If chkViewActiveOnly.CheckState = System.Windows.Forms.CheckState.Checked Then
            Me.bndCustomers.Filter = "[Slsmn-code] = " & Chr(39) & cSalesmanCode & Chr(39) & " AND [Status-code] = " & Chr(39) & "P" & Chr(39)
            Me.bndCustomers.Sort = "Name"
        Else
            Me.bndCustomers.Filter = "[Slsmn-code] = " & Chr(39) & cSalesmanCode & Chr(39)
            Me.bndCustomers.Sort = "Name"
        End If
    End Sub

    ''' <summary>
    ''' This procedure changes the sort order of the customer list to sort by the Customer's city
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub SortByCity_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SortByCity.CheckedChanged
        nListIndex = 1
        If chkViewActiveOnly.CheckState = System.Windows.Forms.CheckState.Checked Then
            Me.bndCustomers.Filter = "[Slsmn-code] = " & Chr(39) & cSalesmanCode & Chr(39) & " AND [Status-code] = " & Chr(39) & "P" & Chr(39)
            Me.bndCustomers.Sort = "City"
        Else
            Me.bndCustomers.Filter = "[Slsmn-code] = " & Chr(39) & cSalesmanCode & Chr(39)
            Me.bndCustomers.Sort = "City"
        End If
    End Sub

    ''' <summary>
    ''' This procedure changes the sort order of the customer list to sort by the Customer's State
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub SortByState_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SortByState.CheckedChanged
        nListIndex = 2
        If chkViewActiveOnly.CheckState = System.Windows.Forms.CheckState.Checked Then
            Me.bndCustomers.Filter = "[Slsmn-code] = " & Chr(39) & cSalesmanCode & Chr(39) & " AND [Status-code] = " & Chr(39) & "P" & Chr(39)
            Me.bndCustomers.Sort = "St"
        Else
            Me.bndCustomers.Filter = "[Slsmn-code] = " & Chr(39) & cSalesmanCode & Chr(39)
            Me.bndCustomers.Sort = "St"
        End If
    End Sub
End Class