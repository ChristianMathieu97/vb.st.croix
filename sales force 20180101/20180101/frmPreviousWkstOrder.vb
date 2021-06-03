Option Strict Off
Option Explicit On
Friend Class frmPreviousWkstOrder
	Inherits System.Windows.Forms.Form
	Dim mNode As System.Windows.Forms.TreeNode
	Dim refreshscreen As Boolean
	
	Private Sub cmdRefresh_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRefresh.Click
		refreshscreen = True
		frmPreviousWkstOrder_Load(Me, New System.EventArgs())
    End Sub

    ''' <summary>
    ''' This procedure looks for worksheets and customer for the current customer and displays them in a Windows Explorer type tree.  It is
    ''' suppossed to let the user know what product types have been ordered for a particular season
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
	
	Private Sub frmPreviousWkstOrder_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim con As New OleDb.OleDbConnection
        Dim daWkst As OleDb.OleDbDataAdapter
        Dim dtWkst As New DataTable
        Dim daOrder As OleDb.OleDbDataAdapter
        Dim dtOrder As New DataTable
        Dim daOrderLine As OleDb.OleDbDataAdapter
        Dim dtOrderLine As New DataTable
        Dim daProdGroup As OleDb.OleDbDataAdapter
        Dim dtProdGroup As New DataTable
        Dim daWkstLine As OleDb.OleDbDataAdapter
        Dim dtWkstLine As New DataTable

        Dim sql As String = Nothing
        Dim orderno As String = Nothing
        Dim wkst As String = Nothing
        Dim tmpProdGroup As String = Nothing
        Dim tmpProdGroupQty As Short
        Dim tmpProdGroupDesc As String = Nothing
        Dim tmpTotExtendPrice As Decimal
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        con.ConnectionString = MySettings.Default("SaleForcConnectionString")
        con.Open()
        
        Me.Text = frmCustInfo.lblName.Text & " - Recent Worksheets and Orders"
		
		If Not refreshscreen Then
            dtpWksts.Value = Today.AddDays(-180)
            dtpOrders.Value = Today.AddDays(-180)
		End If
		
		treWkstOrder.Nodes.Clear()
		
		' ----------------------------
		' Get worksheet header records
		' ----------------------------
		
        sql = "SELECT * From [ws-ord-head] WHERE ((([ws-ord-head].[ws-create-date])>#" & CStr(dtpWksts.Value) & "#) AND (([ws-ord-head].[cust-no])=" & Chr(39) & Trim(frmCustInfo.txtCustNo.Text) & Chr(39) & ") AND (([ws-ord-head].[validation-status])<>'ORDER' And ([ws-ord-head].[validation-status])<>'CANCEL')) " & "ORDER BY [ws-ord-head].[ws-create-date] DESC"
        daWkst = New OleDb.OleDbDataAdapter(sql, con)
        daWkst.Fill(dtWkst)
		
		' -----------------
		' Get order records
		' -----------------
		
		If optViewOpen.Checked = True Then
            sql = "SELECT Customer.[Cust-no], Order.[Order-no], Order.[Qty-open-order], Order.[Order-date], Order.[Qty-shipped], Order.Season, Order.[Order-code] " & "FROM [Order] INNER JOIN Customer ON Order.[Cust-no] = Customer.[Cust-no] " & "Where (((Customer.[Cust-no]) = " & Chr(39) & frmCustInfo.txtCustNo.Text & Chr(39) & ") And ((Order.[Qty-open-order]) <> 0) And ((Order.[Order-date]) > #" & CStr(dtpOrders.Value) & "#))" & "ORDER BY Order.[Order-date] DESC;"
		ElseIf optViewAll.Checked = True Then 
            sql = "SELECT Customer.[Cust-no], Order.[Order-no], Order.[Qty-open-order], Order.[Order-date], Order.[Qty-shipped], Order.Season, Order.[Order-code] " & "FROM [Order] INNER JOIN Customer ON Order.[Cust-no] = Customer.[Cust-no] " & "Where (((Customer.[Cust-no]) = " & Chr(39) & frmCustInfo.txtCustNo.Text & Chr(39) & ") And ((Order.[Order-date]) > #" & CStr(dtpOrders.Value) & "#))" & "ORDER BY Order.[Order-date] DESC;"
		End If
        daOrder = New OleDb.OleDbDataAdapter(sql, con)
        daOrder.Fill(dtOrder)

        '---------------------
        ' Get Prod Group table
        '---------------------

        sql = "SELECT * FROM ProdGroup"
        daProdGroup = New OleDb.OleDbDataAdapter(sql, con)
        daProdGroup.Fill(dtProdGroup)

        '---------------
        'Add parent node
        '---------------

		treWkstOrder.Nodes.Add("wksts&orders", "Worksheets and Orders")
        treWkstOrder.Nodes.Find("wksts&orders", True)(0).Nodes.Add("worksheets", "Worksheets")
		
		' -----------------------------------------------------
		' Add Worksheet and product group summaries to the tree
		' -----------------------------------------------------
		
        For i = 0 To dtWkst.Rows.Count - 1
            wkst = Trim(dtWkst.Rows(i)("worksheet-id"))
            mNode = treWkstOrder.Nodes.Find("worksheets", True)(0).Nodes.Add(wkst, "Worksheet: " & wkst & "  Created: " & Trim(dtWkst.Rows(i)("ws-create-date")) & "  Season: " & Trim(dtWkst.Rows(i)("season")) & "  Order Code: " & Trim(dtWkst.Rows(i)("order-code")))
            sql = "SELECT [ws-ord-line].[worksheet-id], ProdGroup.ProdGroup, ProdGroup.Description, [ws-ord-line].[qty-orig-ord], [ws-ord-line].[price]" & " FROM [ws-ord-line] LEFT JOIN (Item LEFT JOIN ProdGroup ON Item.ProdGroup = ProdGroup.ProdGroup) ON [ws-ord-line].[Item-no] = Item.Item" & " WHERE ((([ws-ord-line].[worksheet-id]) = " & Chr(39) & wkst & Chr(39) & ")) ORDER BY Item.ProdGroup"
            daWkstLine = New OleDb.OleDbDataAdapter(sql, con)
            daWkstLine.Fill(dtWkstLine)
            If dtWkstLine.Rows.Count <> 0 Then

                tmpProdGroup = dtWkstLine.Rows(0)("prodgroup")
                tmpProdGroupQty = 0
                tmpTotExtendPrice = 0
                Dim foundprodgrouprow As DataRow() = dtProdGroup.Select("prodgroup = '" & Trim(tmpProdGroup) & "'")

                If foundprodgrouprow.Length > 0 Then
                    tmpProdGroupDesc = foundprodgrouprow(0)("description")
                End If

                For j = 0 To dtWkstLine.Rows.Count - 1
                    If dtWkstLine.Rows(j)("prodgroup") = tmpProdGroup Then
                        tmpProdGroupQty = tmpProdGroupQty + dtWkstLine.Rows(j)("qty-orig-ord")
                        tmpTotExtendPrice = tmpTotExtendPrice + (dtWkstLine.Rows(j)("qty-orig-ord") * dtWkstLine.Rows(j)("price"))
                    Else
                        mNode = treWkstOrder.Nodes.Find(wkst, True)(0).Nodes.Add(tmpProdGroup & Trim(dtWkstLine.Rows(j)("worksheet-id")), tmpProdGroupDesc & " (Qty: " & CStr(tmpProdGroupQty) & " Extended Price: " & Convert.ToDecimal(tmpTotExtendPrice).ToString("c") & ")")
                        tmpTotExtendPrice = 0
                        tmpProdGroup = dtWkstLine.Rows(j)("prodgroup")
                        tmpProdGroupQty = dtWkstLine.Rows(j)("qty-orig-ord")
                        tmpTotExtendPrice = tmpTotExtendPrice + (dtWkstLine.Rows(j)("qty-orig-ord") * dtWkstLine.Rows(j)("price"))
                        foundprodgrouprow = dtProdGroup.Select("[ProdGroup] = '" & Trim(tmpProdGroup) & "'")

                        If foundprodgrouprow.Length > 0 Then
                            tmpProdGroupDesc = foundprodgrouprow(0)("description")
                        Else
                            tmpProdGroupDesc = "Product Group Description Not Found"
                        End If
                    End If
                Next
                mNode = treWkstOrder.Nodes.Find(Trim(wkst), True)(0).Nodes.Add(tmpProdGroup & Trim(wkst), tmpProdGroupDesc & " (Qty: " & CStr(tmpProdGroupQty) & " Extended Price: " & Convert.ToDecimal(tmpTotExtendPrice).ToString("c") & ")")

            End If
            'treWkstOrder.Nodes(trim$(orderno)).Expanded = True
            dtWkstLine.Clear()
        Next
		
		' --------------------------------------------------
		' Add Orders and product group summaries to the tree
		' --------------------------------------------------
		
        treWkstOrder.Nodes.Find("wksts&orders", True)(0).Nodes.Add("orders", "Orders")
		
        For k = 0 To dtOrder.Rows.Count - 1
            orderno = CStr(dtOrder.Rows(k)("order-no")) & "a"
            mNode = treWkstOrder.Nodes.Find("orders", True)(0).Nodes.Add(Trim(orderno), "Order: " & Trim(CStr(dtOrder.Rows(k)("order-no"))) & "  Order Date: " & Trim(CStr(dtOrder.Rows(k)("order-date"))) & "  Season: " & Trim(dtOrder.Rows(k)("season")) & "  Order Code: " & Trim(dtOrder.Rows(k)("order-code")))

            sql = "SELECT [Order-line].[Order-no], [Order-line].[ext-price], ProdGroup.ProdGroup, ProdGroup.Description, [Order-line].[Qty-orig-ord] FROM [Order-line] LEFT JOIN (Item LEFT JOIN ProdGroup ON Item.ProdGroup = ProdGroup.ProdGroup) ON [Order-line].[Item-no] = Item.Item" & " WHERE ((([Order-line].[Order-no])=" & CStr(dtOrder.Rows(k)("order-no")) & ")) ORDER BY Item.ProdGroup;"
            daOrderLine = New OleDb.OleDbDataAdapter(sql, con)
            daOrderLine.Fill(dtOrderLine)

            If dtOrderLine.Rows.Count <> 0 Then
                If IsDBNull(dtOrderLine.Rows(0)("prodgroup")) Then
                    tmpProdGroup = "UNK"
                Else
                    tmpProdGroup = dtOrderLine.Rows(0)("prodgroup")
                End If
            End If
            tmpProdGroupQty = 0
            tmpTotExtendPrice = 0
            Dim foundprodgrouprow As DataRow() = dtProdGroup.Select("prodgroup = '" & Trim(tmpProdGroup) & "'")

            If foundprodgrouprow.Length > 0 Then
                tmpProdGroupDesc = foundprodgrouprow(0)("description")
            Else
                tmpProdGroupDesc = "Unknown"
            End If

            For i = 0 To dtOrderLine.Rows.Count - 1
                If dtOrderLine.Rows(i).IsNull("prodgroup") Then
                    tmpProdGroupQty = tmpProdGroupQty + dtOrderLine.Rows(i)("qty-orig-ord")
                    tmpTotExtendPrice = tmpTotExtendPrice + dtOrderLine.Rows(i)("ext-price")
                ElseIf dtOrderLine.Rows(i)("prodgroup") = tmpProdGroup Then
                    tmpProdGroupQty = tmpProdGroupQty + dtOrderLine.Rows(i)("qty-orig-ord")
                    tmpTotExtendPrice = tmpTotExtendPrice + dtOrderLine.Rows(i)("ext-price")
                Else
                    mNode = treWkstOrder.Nodes.Find(Trim(orderno), True)(0).Nodes.Add(tmpProdGroup & Trim(orderno), tmpProdGroupDesc & " (Qty: " & CStr(tmpProdGroupQty) & " Extended Price: " & Convert.ToDecimal(tmpTotExtendPrice).ToString("c") & ")")

                    tmpProdGroup = dtOrderLine.Rows(i)("prodgroup")
                    tmpProdGroupQty = dtOrderLine.Rows(i)("qty-orig-ord")
                    tmpTotExtendPrice = dtOrderLine.Rows(i)("ext-price")

                    If foundprodgrouprow.Length > 0 Then
                        tmpProdGroupDesc = foundprodgrouprow(0)("description")
                    Else
                        tmpProdGroupDesc = "Unknown"
                    End If

                    foundprodgrouprow = dtProdGroup.Select("[ProdGroup] = '" & Trim(tmpProdGroup) & "'")
                    If foundprodgrouprow.Length > 0 Then
                        tmpProdGroupDesc = foundprodgrouprow(0)("description")
                    Else
                        tmpProdGroupDesc = "Unknown"
                    End If

                End If
            Next

            If tmpProdGroup > "" Then
                mNode = treWkstOrder.Nodes.Find(Trim(orderno), True)(0).Nodes.Add(tmpProdGroup & Trim(orderno), tmpProdGroupDesc & " (Qty: " & CStr(tmpProdGroupQty) & " Extended Price: " & Convert.ToDecimal(tmpTotExtendPrice).ToString("c") & ")")
            End If
            dtOrderLine.Clear()
        Next

        ' -----------------------------------------
        ' Expand the tree and make top node visible
        ' -----------------------------------------

        treWkstOrder.Nodes.Item("wksts&orders").Expand()
        treWkstOrder.Nodes.Item(0).Nodes("worksheets").Expand()
        treWkstOrder.Nodes.Item(0).Nodes("orders").Expand()
        treWkstOrder.Nodes.Item(0).EnsureVisible()
        treWkstOrder.SelectedNode = treWkstOrder.Nodes(0).FirstNode

        Me.Cursor = System.Windows.Forms.Cursors.Default
        con.Close()
    End Sub
	
	Private Sub frmPreviousWkstOrder_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		refreshscreen = False
	End Sub
End Class