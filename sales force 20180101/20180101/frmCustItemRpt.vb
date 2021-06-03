Option Strict Off
Option Explicit On

''' <summary>
''' This form will display a report that shows which customers ordered a particular item.  
''' </summary>
''' <remarks></remarks>

Friend Class frmCustItemRpt
	Inherits System.Windows.Forms.Form
    Dim dtCustItem As DataTable = New DataTable("CustItem")
	Dim mNode As System.Windows.Forms.TreeNode
    Dim counter As Short
    Private mblnFormActivated As Boolean

    ''' <summary>
    ''' This procedure clears the controls of any user entered data that is used when creating a search for an item
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
	
	Private Sub cmdClear_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClear.Click
		Me.txtItem.Text = ""
		Me.txtItem.Focus()
        Me.txtItem.Refresh()
        Me.treCustItem.Nodes.Clear()
        Me.txtItemDescription.ResetText()
        Me.dgv.DataSource = ""
        Me.lblOpen.Text = "0"
        Me.lblOrigOrd.Text = "0"
        Me.lblShipped.Text = "0"
    End Sub

    ''' <summary>
    ''' This procedure will perform a search in the order line table for customers that ordered the item in the txtItem text box
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks>When the user presses the "enter" key while in the txtItem text box, this procedure will search the order line table
    ''' for orders that include the item in the txtItem text box</remarks>

    Private Sub txtItem_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtItem.KeyPress
        Dim KeyAscii As Short = Asc(EventArgs.KeyChar)
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim daItem As OleDb.OleDbDataAdapter
        Dim dtItem As New DataTable

        If KeyAscii = System.Windows.Forms.Keys.Return Then
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Panel1.Visible = True
            Me.Refresh()
            Me.lblOpen.Text = "0"
            Me.lblOrigOrd.Text = "0"
            Me.lblShipped.Text = "0"

            If dtCustItem.Columns.Count > 0 Then
                dtCustItem.Rows.Clear()
            End If

            con.Open()
            daItem = New OleDb.OleDbDataAdapter("SELECT item, description1 FROM item WHERE item = '" & Trim(txtItem.Text) & "'", con)
            daItem.Fill(dtItem)
            con.Close()

            If dtItem.Rows.Count = 0 Then
                txtItemDescription.Text = ""
                MsgBox("Item: " & txtItem.Text & " is not a valid item", MsgBoxStyle.Critical)
            Else
                txtItemDescription.Text = dtItem.Rows(0)("description1").ToString
            End If
            cmdRefresh.Visible = False
            dgv.DataSource = ""
            treCustItem.Nodes.Clear()
            If dtItem.Rows.Count <> 0 Then FindOrderLines()
            If dtCustItem.Rows.Count <> 0 Then
                BuildNodes()
            Else
                treCustItem.Nodes.Add("No Orders Found")
                treCustItem.Nodes.Add("For Item " & Trim(txtItem.Text))
                'txtItem.Text = ""
            End If

            txtItem.SelectionStart = 0
            txtItem.SelectionLength = Len(txtItem.Text)
            Panel1.Visible = False
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        Timer1.Enabled = False
    End Sub

    ''' <summary>
    ''' This procedure will make the refresh button visible when the user selects an option in the "View By" combo box
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmbViewBy_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbViewBy.SelectedIndexChanged
        If mblnFormActivated Then
            Timer1.Enabled = True
            cmdRefresh.Visible = True
        End If
    End Sub

    ''' <summary>
    ''' This procedure will make the refresh button visible when the user selects an option in the "View By" combo box
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmbViewBy_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cmbViewBy.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return And mblnFormActivated Then
            Timer1.Enabled = True
            cmdRefresh.Visible = True
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    ''' <summary>
    ''' This procedures is fired when this form is loaded.  It will automatically search for the 'CurrInventoryItem' item when coming from
    ''' another form and the boolean'CameFromInventoryForm' variable is set to true
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub frmCustItemRpt_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If mblnFormActivated Then Exit Sub
        txtItem.Focus()
        If CameFromInventoryForm = True Then
            txtItem.Text = CurrInventoryItem
            txtItem_KeyPress(txtItem, New System.Windows.Forms.KeyPressEventArgs(Chr((System.Windows.Forms.Keys.Return))))
        End If
        mblnFormActivated = True
    End Sub

    ''' <summary>
    ''' This procedure will clear the form when the form closes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub frmCustItemRpt_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        cmdClear_Click(Nothing, Nothing)
        mblnFormActivated = False
    End Sub

    ''' <summary>
    ''' This procedure clears the form and sets up the "View By" combo box and the datetimepicker controls
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub frmCustItemRpt_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        cmdClear_Click(Nothing, Nothing)
        Timer1.Enabled = False
        cmbViewBy.Items.Add("Customer")
        cmbViewBy.Items.Add("Order Date")
        cmbViewBy.Items.Add("Quantity")
        cmbViewBy.Text = cmbViewBy.Items(0)

        dtpFromOrderDate.Value = Today.AddDays(-365)
        dtpToOrderDate.Value = Today
        counter = 1
    End Sub

    ''' <summary>
    ''' This procedures looks for records in the order line file where the record matches the criteria on the form
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub FindOrderLines()
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim cmd As New OleDb.OleDbCommand("SELECT Customer.Name, [Order-line].[Order-no], [Order-line].[Item-no], Order.[Order-date], [Order-line].[Qty-orig-ord], [Order-line].[Qty-open-ord], [Order-line].[Qty-shipped] FROM Customer " & _
                                          "INNER JOIN ([Order] INNER JOIN [Order-line] ON Order.[Order-no] = [Order-line].[Order-no]) ON Customer.[Cust-no] = Order.[Cust-no] " & _
                                          "WHERE ((([Order-line].[Item-no]) Like '%" & Me.txtItem.Text & "%') AND ((Order.[Order-date])>=#" & Me.dtpFromOrderDate.Value & "# And (Order.[Order-date])<=#" & Me.dtpToOrderDate.Value & "#));", con)
        Dim myDA As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmd)
        myDA.Fill(dtCustItem)
        con.Close()
    End Sub

    ''' <summary>
    ''' This procedure calls other procedures to build the "tree" on the left side of the screen
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub BuildNodes()
        treCustItem.Nodes.Clear()
        dgv.DataSource = ""

        If cmbViewBy.Text = "Customer" Then
            BuildCustomerNodes()
        ElseIf cmbViewBy.Text = "Order Date" Then
            BuildOrderDateNodes()
        ElseIf cmbViewBy.Text = "Quantity" Then
            BuildQuantityNodes()
        End If
        treCustItem.Nodes.Item(0).Expand()
    End Sub

    ''' <summary>
    ''' This procedure will build a Windows Explorer style tree with the names of customers that have order the item being searched
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub BuildCustomerNodes()
        Dim tmpCust As String = Nothing
        Dim tmpordernum As Integer
        Dim i As Integer
        Dim j As Integer
        Dim dvCustItem As DataView

        dvCustItem = dtCustItem.AsDataView

        If optAscending.Checked = True Then
            dvCustItem.Sort = "Name ASC, [Order-no] ASC"
        ElseIf optDescending.Checked = True Then
            dvCustItem.Sort = "Name DESC, [Order-no] ASC"
        End If

        treCustItem.Nodes.Add("Customers")
        treCustItem.Nodes(0).Tag = "all"
        For Each custitemrow As DataRow In dvCustItem.ToTable.Rows
            If Trim(custitemrow("name")) <> tmpCust Then
                treCustItem.Nodes(0).Nodes.Add(custitemrow("name"))
                treCustItem.Nodes(0).Nodes(i).Tag = "customer"
                tmpCust = Trim(custitemrow("name"))
                tmpordernum = 0
                j = 0
                i = i + 1
            End If
            If custitemrow("order-no") <> tmpordernum Then
                treCustItem.Nodes(0).Nodes(i - 1).Nodes.Add(custitemrow("order-no"))
                treCustItem.Nodes(0).Nodes(i - 1).Nodes(j).Tag = "order"
                tmpordernum = custitemrow("order-no")
                j = j + 1
            End If
        Next
    End Sub

    ''' <summary>
    ''' This procedure will build a Windows Explorer style tree with the dates of orders for customers that have order the item 
    ''' being searched
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub BuildOrderDateNodes()
        Dim tmpOrderDate As String = Nothing
        Dim tmpordernum As Integer
        Dim i As Integer
        Dim j As Integer
        Dim dvCustItem As DataView

        dvCustItem = dtCustItem.AsDataView

        If optAscending.Checked = True Then
            dvCustItem.Sort = "[Order-Date] ASC, [Order-No] ASC"
        ElseIf optDescending.Checked = True Then
            dvCustItem.Sort = "[Order-Date] DESC, [Order-No] ASC"
        End If

        treCustItem.Nodes.Add("Order Dates")
        treCustItem.Nodes(0).Tag = "all"

        For Each custitemrow As DataRow In dvCustItem.ToTable.Rows
            If custitemrow("Order-date") <> tmpOrderDate Then
                treCustItem.Nodes(0).Nodes.Add(custitemrow("order-date"))
                treCustItem.Nodes(0).Nodes(i).Tag = "orderdate"
                tmpOrderDate = custitemrow("Order-date")
                tmpordernum = 0
                j = 0
                i = i + 1
            End If
            If custitemrow("order-no") <> tmpordernum Then
                treCustItem.Nodes(0).Nodes(i - 1).Nodes.Add(custitemrow("order-no"))
                treCustItem.Nodes(0).Nodes(i - 1).Nodes(j).Tag = "order"
                tmpordernum = custitemrow("order-no")
                j = j + 1
            End If
        Next
    End Sub

    ''' <summary>
    ''' This procedure will build a Windows Explorer style tree with the quantities of items on an order where a customer has
    ''' ordered the item being searched
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub BuildQuantityNodes()
        Dim tmpOrderQty As Integer
        Dim tmpordernum As Integer
        Dim i As Integer
        Dim j As Integer
        Dim dvCustItem As DataView

        dvCustItem = dtCustItem.AsDataView

        If optAscending.Checked = True Then
            dvCustItem.Sort = "[Qty-Orig-Ord] ASC, [Order-no] ASC"
        ElseIf optDescending.Checked = True Then
            dvCustItem.Sort = "[Qty-Orig-Ord] DESC, [Order-no] ASC"
        End If

        treCustItem.Nodes.Add("Order Quantities")
        treCustItem.Nodes(0).Tag = "all"

        For Each custitemrow As DataRow In dvCustItem.ToTable.Rows
            If custitemrow("qty-orig-ord") <> 0 Then
                If custitemrow("qty-orig-ord") <> tmpOrderQty Then
                    treCustItem.Nodes(0).Nodes.Add(custitemrow("qty-orig-ord"))
                    treCustItem.Nodes(0).Nodes(i).Tag = "orderqty"
                    tmpOrderQty = custitemrow("qty-orig-ord")
                    tmpordernum = 0
                    j = 0
                    i = i + 1
                End If
                If custitemrow("order-no") <> tmpordernum Then
                    treCustItem.Nodes(0).Nodes(i - 1).Nodes.Add(custitemrow("order-no"))
                    treCustItem.Nodes(0).Nodes(i - 1).Nodes(j).Tag = "order"
                    tmpordernum = custitemrow("order-no")
                    j = j + 1
                End If
            End If
        Next
    End Sub

    ''' <summary>
    ''' This procedure will make the refresh button visible when checked
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub optAscending_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optAscending.CheckedChanged
        If eventSender.Checked And mblnFormActivated Then
            cmdRefresh.Visible = True
            Timer1.Enabled = True
        End If
    End Sub

    ''' <summary>
    ''' This procedure will make the refresh button visible when checked
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub optDescending_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optDescending.CheckedChanged
        If eventSender.Checked And mblnFormActivated Then
            cmdRefresh.Visible = True
            Timer1.Enabled = True
        End If
    End Sub

    ''' <summary>
    ''' This procedure will make the "Refresh" button blink to make the user aware that the item search criteria has been modified.  This
    ''' is an indication that the "Refresh" button needs to be clicked.
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
        If cmdRefresh.Visible = True Then
            If counter = 1 Then
                counter = 2
                cmdRefresh.Font = New System.Drawing.Font(cmdRefresh.Font, FontStyle.Bold)
            ElseIf counter = 2 Then
                counter = 1
                cmdRefresh.Font = New System.Drawing.Font(cmdRefresh.Font, FontStyle.Regular)
            End If
        End If
    End Sub

    ''' <summary>
    ''' When the user clicks to collapse a node on the tree, the highlighted item changes.  Therefore the data for the selected item has 
    ''' to be displayed.
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub treCustItem_AfterCollapse(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.TreeViewEventArgs) Handles treCustItem.AfterCollapse
        Dim Node As System.Windows.Forms.TreeNode = eventArgs.Node
        Call treCustItem_NodeClick(treCustItem, New System.Windows.Forms.TreeNodeMouseClickEventArgs(Node, System.Windows.Forms.MouseButtons.None, 0, 0, 0))
    End Sub

    ''' <summary>
    ''' When a user clicks on a node in the tree, this procedure will update the binding source for the datagrid and will display 
    ''' the associated data for that node
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub treCustItem_NodeClick(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles treCustItem.NodeMouseClick
        Dim Node As System.Windows.Forms.TreeNode = eventArgs.Node
        Dim QtyOrigOrdTotal, QtyShipTotal, QtyOpenTotal As Short
        Dim i As Integer

        QtyShipTotal = 0
        QtyOrigOrdTotal = 0
        QtyOpenTotal = 0

        bs1.DataSource = dtCustItem
        treCustItem.SelectedNode = eventArgs.Node

        dgv.DataSource = ""
        If dtCustItem.Rows.Count = 0 Then
            Exit Sub
        End If

        Select Case Node.Tag
            Case "all"
                bs1.Filter = ("name > ''")
            Case "customer"
                bs1.Filter = ("name = '" & treCustItem.SelectedNode.Text.Replace("'", "''") & "'")
            Case "orderdate"
                bs1.Filter = ("[order-date] = #" & treCustItem.SelectedNode.Text & "#")
            Case "orderqty"
                bs1.Filter = ("[qty-orig-ord] = " & treCustItem.SelectedNode.Text)
            Case "order"
                bs1.Filter = ("[order-no] = " & treCustItem.SelectedNode.Text)
        End Select

        dgv.DataSource = bs1

        dgv.Columns(0).HeaderText = "Customer"
        dgv.Columns(1).HeaderText = "Order No"
        dgv.Columns(2).HeaderText = "Item No"
        dgv.Columns(3).HeaderText = "Order Date"
        dgv.Columns(4).HeaderText = "Ordered"
        dgv.Columns(5).HeaderText = "Open"
        dgv.Columns(6).HeaderText = "Shipped"

        For i = 0 To dgv.Columns.Count - 1
            dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Bold)
            dgv.DefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Bold)
        Next

        dtCustItem.DefaultView.Sort = "name"

        Timer1.Enabled = False
        cmdRefresh.Visible = False

        QtyOrigOrdTotal = 0
        For i = 0 To dgv.Rows.Count - 1
            QtyOrigOrdTotal = QtyOrigOrdTotal + Convert.ToDouble(dgv.Rows(i).Cells("qty-orig-ord").Value)
        Next i

        QtyOpenTotal = 0
        For i = 0 To dgv.Rows.Count - 1
            QtyOpenTotal = QtyOpenTotal + Convert.ToDouble(dgv.Rows(i).Cells("qty-open-ord").Value)
        Next i

        QtyShipTotal = 0
        For i = 0 To dgv.Rows.Count - 1
            QtyShipTotal = QtyShipTotal + Convert.ToDouble(dgv.Rows(i).Cells("qty-shipped").Value)
        Next i

        'QtyOrigOrdTotal = dtCustItem.Compute("Sum([qty-orig-ord])", True)
        'QtyOpenTotal = dtCustItem.Compute("Sum([qty-open-ord])", True)
        'QtyShipTotal = dtCustItem.Compute("Sum([qty-shipped])", True)

        lblOpen.Text = QtyOpenTotal.ToString
        lblOrigOrd.Text = QtyOrigOrdTotal.ToString
        lblShipped.Text = QtyShipTotal.ToString
    End Sub

    ''' <summary>
    '''  This procedure will make the refresh button visible when changed
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub dtpToOrderDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpToOrderDate.ValueChanged
        If mblnFormActivated Then
            Timer1.Enabled = True
            cmdRefresh.Visible = True
        End If
        If dtpToOrderDate.Value < dtpFromOrderDate.Value Then
            MsgBox("This date can not be before the From date", MsgBoxStyle.Critical)
            dtpToOrderDate.Value = Today
        End If
    End Sub

    ''' <summary>
    '''  This procedure will make the refresh button visible when changed
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub dtpFromOrderDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFromOrderDate.ValueChanged
        If mblnFormActivated Then
            Timer1.Enabled = True
            cmdRefresh.Visible = True
        End If
        If dtpFromOrderDate.Value > dtpToOrderDate.Value Then
            MsgBox("This date can not be after the To date", MsgBoxStyle.Critical)
            dtpFromOrderDate.Value = Today.AddDays(-365)
        End If
    End Sub

    ''' <summary>
    ''' This procedure will update the search results when clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        cmdRefresh.Visible = False
        Timer1.Enabled = False
        txtItem_KeyPress(txtItem, New System.Windows.Forms.KeyPressEventArgs(Chr((System.Windows.Forms.Keys.Return))))
    End Sub
End Class