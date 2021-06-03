Option Strict Off
Option Explicit On
Friend Class frmListWs
	Inherits System.Windows.Forms.Form
    Dim cWsNum As String
    Dim strFilter As String
    Dim formloaded As Boolean

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
    ''' This procedure asks for user input and searches for a ws-ord-head record using the text from user input
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
	
	Private Sub cmdFindWS_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFindWS.Click
        Dim dv As DataView = New DataView(Me.SaleForcDataSet._ws_ord_head)
        dv.RowFilter = "[worksheet-id] LIKE '" & InputBox("Worksheet Number", "Find Worksheet Number") & "*'"
        If dv.Count > 0 Then
            Me.WsordheadBindingSource.Position = Me.WsordheadBindingSource.Find("worksheet-id", dv(0).Row("worksheet-id"))
        Else
            MsgBox("Worksheet can not be found!", MsgBoxStyle.Critical, "Find Worksheet")
        End If
    End Sub

    ''' <summary>
    ''' This procedure will search for an order record based on the selected ws-ord-head record.  If it finds the order record, it will
    ''' open the 'Orders' form and display the data for that order number
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
	
	Private Sub cmdViewOrder_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdViewOrder.Click
        Dim i As Integer
        Dim daOrder As New SaleForcDataSetTableAdapters.OrderTableAdapter
        Dim dtOrder As SaleForcDataSet.OrderDataTable
        Dim drOrder As SaleForcDataSet.OrderRow = Nothing
        i = dtgWorksheets.CurrentRow.Index
        dtOrder = daOrder.GetData
        If Not IsDBNull(Me.WsordheadBindingSource.Current("order-no")) Then
            drOrder = dtOrder.FindBy_Order_no(WsordheadBindingSource.Current("order-no"))
        End If

        If drOrder Is Nothing Then
            MessageBox.Show("Order does not exist or it may have been purged.  Please contact Sales Support for more information.", "View Order", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        cCustOrdNum = dtgWorksheets.Item(9, i).Value
        If Trim(cCustOrdNum) <> "0" Then
            fromLocation = "WsList"
            Me.Visible = False
            frmOrders.ShowDialog()
            Me.Visible = True
        End If
    End Sub

    ''' <summary>
    ''' This procedure will open the 'Worksheet' form and display data for the selected worksheet
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
	
	Private Sub cmdViewWs_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdViewWs.Click
        Dim i As Integer
        i = dtgWorksheets.CurrentRow.Index
        cCustWsNum = dtgWorksheets.Item(0, i).Value
		If Trim(cCustWsNum) <> "" Then
			fromLocation = "WsList"
            Me.Visible = False
            frmWorksheet.ShowDialog()
            Me.Visible = True
		End If
	End Sub

    ''' <summary>
    ''' This procedue will open the 'Customer Information' form and display data for the selected customer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub cmdViewCustomer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdViewCustomer.Click
        cCustNumber = Me.WsordheadBindingSource.Current("cust-no")
        If Trim(cCustNumber) <> "" And Me.CustomerName.Text <> "No Customer Name" Then
            fromLocation = "WsList"
            Me.Visible = False
            frmCustInfo.ShowDialog()
            Me.Visible = True
        End If
    End Sub

    ''' <summary>
    ''' This procedure display information in the status bar at the bottom of the screen for the customer that belongs to the seleted 
    ''' worksheet
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub displaySelectedCust()
        Dim i As Integer
        If Not dtgWorksheets.CurrentRow Is Nothing Then
            i = dtgWorksheets.CurrentRow.Index
            cWsNum = dtgWorksheets.Item(0, i).Value
            Me.CustomerNumber.Text = "Customer Number: " & findWsCustNo(cWsNum)
            Me.CustomerName.Text = "Customer Name: " & findWsCustName(findWsCustNo(cWsNum))
            Me.WorksheetCount.Text = WsordheadBindingSource.Count & " Worksheet(s)"
            If dtgWorksheets.SortOrder = 0 Then
                SortStatus.Text = "Sorted by '" & dtgWorksheets.SortedColumn.HeaderText & "' Ascending"
            Else
                SortStatus.Text = "Sorted by '" & dtgWorksheets.SortedColumn.HeaderText & "' Descending"
            End If
        Else
            Me.CustomerNumber.Text = ""
            Me.CustomerName.Text = ""
            Me.WorksheetCount.Text = ""
            Me.SortStatus.Text = ""
        End If
    End Sub

    ''' <summary>
    ''' This procedure fires when the form is loaded and fills the datagrid with ws-ord-head records
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub frmListWs_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Ws_ord_headTableAdapter.FillWSList(Me.SaleForcDataSet._ws_ord_head)
    End Sub

    ''' <summary>
    ''' This procedure fires when the form is loaded and fills and sorts the datagrid and displays information on the worksheet on the 
    ''' status bar located at the bottom of the screen.
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
	
    Private Sub frmListWs_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        dtgWorksheets.Sort(dtgWorksheets.Columns(4), System.ComponentModel.ListSortDirection.Descending)
        formloaded = True
        Me.Ws_ord_headTableAdapter.FillWSList(Me.SaleForcDataSet._ws_ord_head)
        displaySelectedCust()
        formloaded = False
    End Sub

    ''' <summary>
    ''' This function finds a customer number from the worksheet number
    ''' </summary>
    ''' <param name="WsNum">The worksheet number</param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Private Function findWsCustNo(ByRef WsNum As String) As String
        Dim con As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        Dim sql As String

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        con.ConnectionString = MySettings.Default("SaleForcConnectionString")
        con.Open()
        sql = "SELECT [cust-no], [allow-manual-maint] FROM [ws-ord-head] WHERE [worksheet-id] = '" & WsNum & "'"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(dt)
        con.Close()

        If dt.Rows.Count < 1 Then
            findWsCustNo = "No Worksheet"
        Else
            findWsCustNo = dt.Rows(0)("cust-no").ToString
            lCanMaintain = dt.Rows(0)("allow-manual-maint")
        End If
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Function

    ''' <summary>
    ''' This procedure searches for the customer table using 'CustNum' and returns the customer name
    ''' </summary>
    ''' <param name="CustNum"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Private Function findWsCustName(ByRef CustNum As String) As String
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
            findWsCustName = "No Customer Name"
        Else
            findWsCustName = dt.Rows(0)("name")
        End If
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Function

    ''' <summary>
    ''' This procedure will enable or disable the 'View Order' and 'View Worksheet' buttons
    ''' </summary>
    ''' <param name="nNdx"></param>
    ''' <remarks></remarks>
	
	Private Sub setCmdBtn(ByRef nNdx As Short)
		Select Case nNdx
			Case 0
				cmdViewOrder.Enabled = False
				cmdViewWs.Enabled = False
				
			Case 1
				cmdViewOrder.Enabled = True
				cmdViewWs.Enabled = True
		End Select
    End Sub

    ''' <summary>
    ''' This procedure will call 'SetupFilter' to clear the filter and display all worksheets and show information on the status bar for 
    ''' the selected worksheet
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub optAllWorksheets_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAllWorksheets.CheckedChanged
        If formloaded Then
            Me.Cursor = Cursors.WaitCursor
            Me.WsordheadBindingSource.Filter = SetupFilter()
            Me.WsordheadBindingSource.Sort = "[ws-create-date] desc"
            Me.Cursor = Cursors.Default
            displaySelectedCust()
        End If
    End Sub

    ''' <summary>
    ''' This procedure will call 'SetupFilter' and display worksheets not transmitted to Knitcraft and show information on the status 
    ''' bar for the selected worksheet
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub optWkstNotTransmitted_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optWkstNotTransmitted.CheckedChanged
        Me.Cursor = Cursors.WaitCursor
        Me.WsordheadBindingSource.Filter = SetupFilter()
        Me.WsordheadBindingSource.Sort = "[ws-create-date] desc"
        Me.Cursor = Cursors.Default
        displaySelectedCust()
    End Sub

    ''' <summary>
    ''' This procedure will call 'SetupFilter' and display worksheets transmitted to Knitcraft but not yet returned to the salesrep
    ''' and also shows information on the status bar for the selected worksheet
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub optWkstTransmittedWaiting_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optWkstTransmittedWaiting.CheckedChanged
        Me.Cursor = Cursors.WaitCursor
        Me.WsordheadBindingSource.Filter = SetupFilter()
        Me.WsordheadBindingSource.Sort = "[ws-create-date] desc"
        Me.Cursor = Cursors.Default
        displaySelectedCust()
    End Sub

    ''' <summary>
    ''' This procedure will filter worksheets and only display worksheets that have not been converted into an order
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub chkNoOrderWs_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNoOrderWs.CheckedChanged
        Me.Cursor = Cursors.WaitCursor
        Me.WsordheadBindingSource.Filter = SetupFilter()
        Me.WsordheadBindingSource.Sort = "[ws-create-date] desc"
        Me.Cursor = Cursors.Default
    End Sub

    ''' <summary>
    ''' This procedure is used for filter that data that appears in the datagrid
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Private Function SetupFilter() As String
        If optAllWorksheets.Checked Then
            strFilter = ""
        ElseIf optWkstNotTransmitted.Checked Then
            strFilter = "ReadyToXmit = true AND Xmitted = false"
        ElseIf optWkstTransmittedWaiting.Checked Then
            strFilter = "ReadyToXmit = true AND Xmitted = True"
        End If

        If chkNoOrderWs.Checked Then
            If strFilter > "" Then
                strFilter = strFilter & " AND [order-no] = 0"
            Else
                strFilter = "[order-no] = 0"
            End If
        End If
        SetupFilter = strFilter
    End Function

    ''' <summary>
    ''' This procedure will show information in the status bar for the selected worksheet and will also enable/disable the 'View Order'
    ''' button when an order is available/unavailable
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub dtgWorksheets_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgWorksheets.CellEnter
        displaySelectedCust()
        If WsordheadBindingSource.Current("validation-status") = "ORDER" Then
            cmdViewOrder.Enabled = True
        Else
            cmdViewOrder.Enabled = False
        End If
    End Sub
End Class