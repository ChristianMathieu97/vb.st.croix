Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmListOrder
	Inherits System.Windows.Forms.Form
	Dim cOrdNum As String
	Dim tmpCustNum As String
	Dim wherestmt As String
	Dim ascend As Boolean
	Dim sortcol As Short
	Dim formactivate As Boolean
    Dim formload As Boolean
    Private dataadapter As New OleDb.OleDbDataAdapter
    Dim commandbuilder As OleDb.OleDbCommandBuilder = New OleDb.OleDbCommandBuilder(dataadapter)

    ''' <summary>
    ''' This procedure makes a call to load orders data and show the customer information on the status bar for the currently selected 
    ''' customer
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmbOrderCodes_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbOrderCodes.SelectedIndexChanged
        If Not formload And Not formactivate Then
            LoadOrders()
            tmpOrderCodeIndex = cmbOrderCodes.SelectedIndex
            DisplaySelectedCust()
        End If
    End Sub

    ''' <summary>
    ''' This procedure makes a call to load orders data and show the customer information on the status bar for the currently selected 
    ''' customer
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
	
    Private Sub cmbSeasonCodes_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbSeasonCodes.SelectedIndexChanged
        If Not formload And Not formactivate Then
            LoadOrders()
            tmpSeasonCodeIndex = cmbSeasonCodes.SelectedIndex
            DisplaySelectedCust()
        End If
    End Sub

    ''' <summary>
    ''' When the user clicks on this button, this procedure will load the customer information screen and display the data for the 
    ''' customer that is selected in the datagrid.
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
	
	Private Sub cmdCustomer_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCustomer.Click
        cCustNumber = tmpCustNum
        If Trim(cCustNumber) <> "" Then
            fromLocation = "OrdList"
            Me.Visible = False
            frmCustInfo.Visible = False
            frmCustInfo.ShowDialog()
            Me.Visible = True
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
    ''' When the user clicks this button, this procedure will open the 'frmOrders' screen and display the data for the order selected 
    ''' in the datagrid
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
	
    Private Sub cmdViewOrd_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdViewOrd.Click
        cCustOrdNum = cOrdNum
        If Trim(cCustOrdNum) <> "" Then
            fromLocation = "OrdList"
            Me.Visible = False
            frmOrders.ShowDialog()
            Me.Visible = True
        End If
    End Sub

    ''' <summary>
    ''' This event fires when the form is opened.  It loads the datagrid with order information and also loads the order code and 
    ''' season combo boxes
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub frmListOrder_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        dtgOrders.Sort(dtgOrders.Columns(1), System.ComponentModel.ListSortDirection.Descending)
        formload = True
        Me.OrderTableAdapter.Fill(Me.SaleForcDataSet.Order)
        LoadOrderCodesCombo()
        LoadSeasonCodesCombo()
        formload = False
        dtgOrders.CurrentCell = dtgOrders(1, 0)
    End Sub

    ''' <summary>
    ''' This event fires when the form is displayed.  It sets the cursor position of the row within the datagrid and sets the text in
    ''' the order and season code combo boxes
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub frmListOrder_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        formactivate = True
        LoadOrders()
        If tmpOrderListRow <> 0 Then
            Me.OrderBindingSource.Position = tmpOrderListRowPos
            cmbOrderCodes.SelectedIndex = tmpOrderCodeIndex
            cmbSeasonCodes.SelectedIndex = tmpSeasonCodeIndex
        End If
        formactivate = False
    End Sub

    ''' <summary>
    ''' This procedure will load the order records into the datagrid
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub LoadOrders()
        Me.OrderBindingSource.Filter = BuildWhereStmt()
    End Sub

    ''' <summary>
    ''' This procedure builds the data that will be displayed in the datagrid
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Private Function BuildWhereStmt() As String
        Dim con As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        Dim sql As String

        If optAllOrders.Checked = True Then
            wherestmt = "[order-no] > 0"
        ElseIf optOpenOrders.Checked Then
            wherestmt = "[qty-open-order] > 0"
        ElseIf optShippedOrders.Checked Then
            wherestmt = "[qty-shipped] > 0"
        ElseIf optPartiallyShippedOrders.Checked = True Then
            wherestmt = "[qty-shipped] > 0 AND [qty-open-order] > 0"
        End If

        con.ConnectionString = MySettings.Default("SaleForcConnectionString")
        con.Open()

        If cmbOrderCodes.Text <> "All" And cmbOrderCodes.Text <> "" Then
            sql = "SELECT ordercode FROM ordertype WHERE [description] = '" & cmbOrderCodes.Text & "'"
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(dt)
            con.Close()

            If dt.Rows.Count > 0 Then
                wherestmt = wherestmt & " and [order-code] = '" & dt.Rows(0)("ordercode") & "'"
            End If
        End If

        If cmbSeasonCodes.Text <> "All" And cmbSeasonCodes.Text <> "" Then
            wherestmt = wherestmt & " and season = '" & cmbSeasonCodes.Text & "'"
        End If
        BuildWhereStmt = wherestmt
        con.Close()
    End Function

    ''' <summary>
    ''' This procedure loads order codes into a combo box
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub LoadOrderCodesCombo()
        Dim con As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        Dim sql As String
        Dim i As Integer

        cmbOrderCodes.Items.Clear()
        con.ConnectionString = MySettings.Default("SaleForcConnectionString")
        con.Open()
        sql = "SELECT * FROM OrderType WHERE ForLaptop = True"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(dt)
        con.Close()

        cmbOrderCodes.Items.Add("All")
        For i = 0 To dt.Rows.Count - 1
            cmbOrderCodes.Items.Add(dt.Rows(i)("description"))
        Next
        cmbOrderCodes.SelectedIndex = 0
    End Sub

    ''' <summary>
    ''' This procedure loads season codes into a combo box
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub LoadSeasonCodesCombo()
        Dim con As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        Dim sql As String
        Dim i As Integer

        cmbSeasonCodes.Items.Clear()
        con.ConnectionString = MySettings.Default("SaleForcConnectionString")
        con.Open()
        sql = "SELECT * FROM Season WHERE ForLaptop = True"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(dt)
        con.Close()

        cmbSeasonCodes.Items.Add("All")
        For i = 0 To dt.Rows.Count - 1
            cmbSeasonCodes.Items.Add(dt.Rows(i)("season"))
        Next
        cmbSeasonCodes.SelectedIndex = 0
    End Sub

    ''' <summary>
    ''' This procedure sets the 'tmpOrderListRowPos' variable which is used to remember the row position when coming back to this form
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub frmListOrder_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        tmpOrderListRowPos = OrderBindingSource.Position
    End Sub

    ''' <summary>
    ''' When the user clicks a display option, this procedure will load order records into the datagrid
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub optDisplay_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optDisplay.CheckedChanged
        If Not formload And Not formactivate Then
            LoadOrders()
        End If
    End Sub

    ''' <summary>
    ''' This procedure finds a customer number when an order number is passed in
    ''' </summary>
    ''' <param name="OrdNum"></param>
    ''' <returns>A customer number</returns>
    ''' <remarks></remarks>

    Private Function findOrdCustNo(ByRef OrdNum As String) As String
        Dim con As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        Dim sql As String

        con.ConnectionString = MySettings.Default("SaleForcConnectionString")
        con.Open()

        sql = "SELECT [cust-no] FROM [order] WHERE [order-no] = " & OrdNum
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(dt)
        con.Close()

        If dt.Rows.Count < 1 Then
            findOrdCustNo = "No Customer Number"
        Else
            findOrdCustNo = dt.Rows(0)("cust-no")
        End If
    End Function

    ''' <summary>
    ''' This procedure finds a customer name when the customer number is passed in
    ''' </summary>
    ''' <param name="CustNum"></param>
    ''' <returns>A customer name</returns>
    ''' <remarks></remarks>

    Private Function findOrdCustName(ByRef CustNum As String) As String
        Dim con As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        Dim sql As String

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        con.ConnectionString = MySettings.Default("SaleForcConnectionString")
        con.Open()

        sql = "SELECT [name] FROM [customer] WHERE [cust-no] = '" & CustNum & "'"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(dt)
        con.Close()

        If dt.Rows.Count < 1 Then
            findOrdCustName = "No Customer Name"
        Else
            findOrdCustName = dt.Rows(0)("name")
        End If

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Function

    ''' <summary>
    ''' When the user clicks a display option, this procedure will load order records into the datagrid
    ''' </summary>
    ''' <param name="Sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub optAllOrders_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAllOrders.CheckedChanged
        If Not formload And Not formactivate Then
            LoadOrders()
        End If
    End Sub

    ''' <summary>
    ''' When the user clicks a display option, this procedure will load order records into the datagrid
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub optOpenOrders_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optOpenOrders.CheckedChanged
        LoadOrders()
    End Sub

    ''' <summary>
    '''  When the user clicks a display option, this procedure will load order records into the datagrid
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub optShippedOrders_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optShippedOrders.CheckedChanged
        LoadOrders()
    End Sub

    ''' <summary>
    '''  When the user clicks a display option, this procedure will load order records into the datagrid
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub optPartiallyShippedOrders_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optPartiallyShippedOrders.CheckedChanged
        LoadOrders()
    End Sub

    ''' <summary>
    ''' This procedure searches for an order using input from the user
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub cmdFindOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFindOrder.Click
        Dim dv As DataView = New DataView(Me.SaleForcDataSet.Order)
        dv.RowFilter = "[order-no] = " & InputBox("Order Number:", "Find Order Number")
        If dv.Count > 0 Then
            Me.OrderBindingSource.Position = Me.OrderBindingSource.Find("order-no", dv(0).Row("order-no"))
        Else
            MsgBox("Order can not be found!", MsgBoxStyle.Critical, "Find Order")
        End If
    End Sub

    Private Sub dtgOrders_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgOrders.CellEnter
        DisplaySelectedCust()
    End Sub

    ''' <summary>
    ''' This procedure display order information in the status bar at the bottom of the window
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub DisplaySelectedCust()
        If OrderBindingSource.Count <> 0 Then
            If dtgOrders.SortOrder = 0 Then
                lblSortTypeOrder.Text = "Sorted by '" & dtgOrders.SortedColumn.HeaderText & "' Ascending"
            Else
                lblSortTypeOrder.Text = "Sorted by '" & dtgOrders.SortedColumn.HeaderText & "' Descending"
            End If
            Dim i As Integer
            i = dtgOrders.CurrentRow.Index
            tmpCustNum = findOrdCustNo(dtgOrders.Item(0, i).Value)
            cOrdNum = dtgOrders.Item(0, i).Value
            lblCustomerNumber.Text = "Customer Number: " & tmpCustNum
            lblCustomerName.Text = "Customer Name: " & findOrdCustName(tmpCustNum)
            lblOrderCount.Text = Me.OrderBindingSource.Count & " Order(s)"
        Else
            lblCustomerName.Text = ""
            lblCustomerNumber.Text = ""
            lblOrderCount.Text = ""
            lblSortTypeOrder.Text = ""
        End If
    End Sub
End Class