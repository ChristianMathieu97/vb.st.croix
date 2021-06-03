Imports System.Data.OleDb
Imports System.Collections.Generic

Public Class frmInventory
    Inherits System.Windows.Forms.Form
    Dim tmpItemText As String
    Dim lnotfound As Boolean
    Dim counter As Short
    Dim tmpFormLoaded As Boolean

    ''' <summary>
    ''' This procedure runs a search in the item file for the criteria entered on the form
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmdSearch_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSearch.Click
        If optSearchByNumber.Checked = True Then
            findItemsbyNumber()
        ElseIf optSearchByName.Checked = True Then
            findItemsbyName()
        End If
    End Sub

    ''' <summary>
    ''' This event fires when the form is loaded.  If the boolean variable 'CameFromWorksheetForm' is set to true an automatic search
    ''' will start with the 'CurrWorksheetItem' item.
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub frmInventory_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        txtStyle.Focus()
        If CameFromWorksheetForm = True Then
            txtStyle.Text = CurrWorksheetItem
            txtStyle_KeyPress(txtStyle, New System.Windows.Forms.KeyPressEventArgs(Chr((System.Windows.Forms.Keys.Return))))
        End If
    End Sub

    ''' <summary>
    ''' This event will automatically load when the form is displayed.  It initializes the controls used in the search.
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub frmInventory_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        AddHandler Me.dgvInventory.MouseWheel, AddressOf dgvInventory_MouseWheel
        counter = 1
        Me.lblSearchResultsCnt.Text = "0"
        dtpBeginShip.Value = "01/01/1951"
        dtpEndShip.Value = DateAdd(Microsoft.VisualBasic.DateInterval.Year, 2, Today)
        FillProdGroupComboBox()
        FillSizeComboBox()
        FillColorComboBox()
        GetSearchOption()
        Call optQtyToSell_CheckedChanged(optQtyToSell, New System.EventArgs())
        Call optSearchByNumber_CheckedChanged(optSearchByNumber, New System.EventArgs())
        Timer1.Enabled = False
        tmpFormLoaded = True
        txtStyle.Focus()
    End Sub

    ''' <summary>
    ''' This procedure initializes the type of search by getting the value from the 'InventorySearch' field in the 'Defaults' field
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub GetSearchOption()
        Dim strSearchBy As String

        strSearchBy = GetProgramDefaults("InventorySearch")
        If strSearchBy = "ByNumber" Then
            Me.optSearchByNumber.Checked = True
        Else
            Me.optSearchByName.Checked = True
        End If
    End Sub

    ''' <summary>
    ''' This procedure will update the 'InventorySearch' field of the 'Defaults' table 
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub WriteSearchOption()
        Dim conn As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim com As OleDb.OleDbCommand
        conn.Open()

        If optSearchByNumber.Checked = True Then
            com = New OleDb.OleDbCommand("UPDATE [Defaults] SET [InventorySearch] = 'ByNumber'", conn)
        Else
            com = New OleDb.OleDbCommand("UPDATE [Defaults] SET [InventorySearch] = 'ByName'", conn)
        End If

        com.ExecuteNonQuery()
        com.Dispose()
        conn.Close()
    End Sub

    ''' <summary>
    ''' This procedure will format and populate the 'Product Group' combo box 
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub FillProdGroupComboBox()
        Dim con As New OleDbConnection
        Dim da As OleDbDataAdapter
        Dim dt As New DataTable
        Dim sql As String
        Dim tmpRow As DataRow

        con.ConnectionString = MySettings.Default("SaleForcConnectionString")
        con.Open()
        sql = "SELECT ProdGroup,Description FROM ProdGroup"
        da = New OleDbDataAdapter(sql, con)
        da.Fill(dt)
        con.Close()

        cmbProdGroups.Items.Clear()
        cmbProdGroups.ColumnNum = 2
        cmbProdGroups.ColumnWidth = "40;100"
        cmbProdGroups.DropDownWidth = 300
        cmbProdGroups.GridLineColor = Color.Gray
        cmbProdGroups.GridLineHorizontal = True
        cmbProdGroups.GridLineVertical = True
        cmbProdGroups.DropDownForeColor = Color.Red
        cmbProdGroups.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        cmbProdGroups.Items.Add(New MTGCComboBoxItem("All", "All Product Groups"))

        For Each tmpRow In dt.Rows
            cmbProdGroups.Items.Add(New MTGCComboBoxItem(tmprow("ProdGroup"), tmprow("Description")))
        Next
        cmbProdGroups.SelectedIndex = 0
        cmbProdGroups.Text = "All"
    End Sub

    ''' <summary>
    ''' This procedure will format and populate the 'Size' combo box 
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub FillSizeComboBox()
        Dim con As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        Dim sql As String
        Dim tmpRow As DataRow

        con.ConnectionString = MySettings.Default("SaleForcConnectionString")
        con.Open()
        sql = "SELECT DISTINCT [setcode], [setting] FROM [attrib] WHERE [attrib].[attrib] = 'SIZE' ORDER BY [setcode] asc"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(dt)
        con.Close()

        cmbSize.Items.Clear()
        cmbSize.ColumnNum = 2
        cmbSize.ColumnWidth = "25;100"
        cmbSize.DropDownWidth = 200
        cmbSize.GridLineColor = Color.Gray
        cmbSize.GridLineHorizontal = True
        cmbSize.GridLineVertical = True
        cmbSize.DropDownForeColor = Color.Red
        cmbSize.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem

        For Each tmpRow In dt.Rows
            cmbSize.Items.Add(New MTGCComboBoxItem(tmpRow("setcode"), tmpRow("setting")))
        Next
    End Sub

    ''' <summary>
    ''' This procedure will format and populate the 'Color' combo box 
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub FillColorComboBox()
        Dim con As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        Dim sql As String
        Dim tmpRow As DataRow

        con.ConnectionString = MySettings.Default("SaleForcConnectionString")
        con.Open()
        sql = "SELECT DISTINCT [setcode], [setting] FROM [attrib] WHERE [attrib].[attrib] = 'COLOR' ORDER BY [setcode] asc"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(dt)
        con.Close()

        cmbColor.Items.Clear()
        cmbColor.ColumnNum = 2
        cmbColor.ColumnWidth = "40;100"
        cmbColor.DropDownWidth = 200
        cmbColor.GridLineColor = Color.Gray
        cmbColor.GridLineHorizontal = True
        cmbColor.GridLineVertical = True
        cmbColor.DropDownForeColor = Color.Red
        cmbColor.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem

        For Each tmpRow In dt.Rows
            cmbColor.Items.Add(New MTGCComboBoxItem(tmpRow("setcode"), tmpRow("setting")))
        Next
    End Sub

    ''' <summary>
    ''' This procedure resets some variables and clears the form when the form closes
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub frmInventory_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        tmpItemText = ""
        tmpFormLoaded = False
        CameFromInventoryForm = False
        cmdClear_Click(cmdClear, eventArgs)
    End Sub

    ''' <summary>
    ''' This procedure will perform a search with the criteria entered into the form 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub chkAllItems_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkAllItems.CheckStateChanged
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        If optSearchByNumber.Checked = True Then
            findItemsbyNumber()
        ElseIf optSearchByName.Checked = True Then
            findItemsbyName()
        End If
        Call LoadColorsSizes(ListBox1.Text)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    ''' <summary>
    ''' This procedures creates the row and column headings for the inventory datagrid for the item that is selected in the listbox
    ''' </summary>
    ''' <param name="StyleNo"></param>
    ''' <remarks></remarks>

    Private Sub LoadColorsSizes(ByRef StyleNo As String)
        '    On Error GoTo ErrorRoutine
        Dim con As New OleDb.OleDbConnection
        Dim daItem As OleDb.OleDbDataAdapter
        Dim dtItem As New DataTable
        Dim daProdGroupAttributes As OleDb.OleDbDataAdapter
        Dim dtProdGroupAttributes As New DataTable
        Dim daColor As OleDb.OleDbDataAdapter
        Dim dtColor As New DataTable
        Dim daSize As OleDb.OleDbDataAdapter
        Dim dtSize As New DataTable

        Dim sql As String = Nothing
        Dim i As Short
        Dim tmpColor As String = Nothing
        Dim tmpSize As String = Nothing
        Dim tmpSizeCount As Integer
        Dim prodgroup1 As String = Nothing
        Dim prodgroup2 As String = Nothing
        Dim tmpProdGroup As String = Nothing
        Dim prodgroup1_pos As String = Nothing
        Dim prodgroup2_pos As String = Nothing
        Dim attrCount As Short
        Dim arrProdGroup() As String = Nothing
        Dim arrProdGroupPos() As Short
        ReDim arrProdGroup(3)
        ReDim arrProdGroupPos(3)
        Dim dtSizeCodes As New DataTable
        dtSizeCodes.Columns.Add("Code")
        dtSizeCodes.Columns.Add("Desc")
        Dim drSizeCodes As DataRow
       
        If Len(Trim(StyleNo)) = 0 Then Exit Sub

        con.ConnectionString = MySettings.Default("SaleForcConnectionString")
        con.Open()

        sql = "SELECT [item], [description1], [prodgroup], [qtypotential], [qty-on-hand], [qtytosell], [attrib2], [attrib3], [begin-ship-date],[end-ship-date] FROM [item] WHERE [item] LIKE '" & StyleNo & "%' ORDER BY [item] ASC"
        daItem = New OleDb.OleDbDataAdapter(sql, con)
        daItem.Fill(dtItem)

        If dtItem.Rows.Count = 0 Then
            MsgBox("Style Not Found", MsgBoxStyle.Information, "Matrix Inventory")
            lnotfound = True
            Exit Sub
        End If

        lnotfound = False

        dgvInventory.Rows.Clear()
        dgvInventory.Columns.Clear()

        dgvInventory.RowHeadersVisible = False
        dgvInventory.ColumnHeadersVisible = False

        'Format columns
        '--------------

        dgvInventory.Columns.Add("Col1", "1")
        dgvInventory.Columns.Add("Col2", "2")
        dgvInventory.Columns(0).Frozen = True
        dgvInventory.Columns(0).ReadOnly = True
        dgvInventory.Columns(0).DefaultCellStyle.BackColor = Color.LightGray
        dgvInventory.Columns(1).Frozen = True
        dgvInventory.Columns(1).ReadOnly = True
        dgvInventory.Columns(1).DefaultCellStyle.BackColor = Color.LightGray
        dgvInventory.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvInventory.Columns(0).Width = 70
        dgvInventory.Columns(1).Width = 120

        'Format rows
        '-----------

        dgvInventory.Rows.Add(3)
        dgvInventory.Rows(0).Frozen = True
        dgvInventory.Rows(0).ReadOnly = True
        dgvInventory.Rows(0).DefaultCellStyle.BackColor = Color.LightGray
        dgvInventory.Rows(1).Frozen = True
        dgvInventory.Rows(1).Frozen = True
        dgvInventory.Rows(1).DefaultCellStyle.BackColor = Color.LightGray

        tmpItemText = ListBox1.Text
        lblItemDescription1.Text = dtItem.Rows(0)("description1").ToString
        dgvInventory.Visible = True

        ' -------------------------------------------------------------------------
        ' Find the attributes for this style (i.e. color & size) and find out their
        ' starting position and length in the item no.
        ' -------------------------------------------------------------------------

        sql = "SELECT [attrdesc], [attrposition], [productgroup] FROM [Product Group Attributes]"
        daProdGroupAttributes = New OleDb.OleDbDataAdapter(sql, con)
        daProdGroupAttributes.Fill(dtProdGroupAttributes)

        For i = 0 To dtProdGroupAttributes.Rows.Count - 1
            If dtProdGroupAttributes.Rows(i)("ProductGroup") = dtItem.Rows(0)("ProdGroup") Then
                arrProdGroup(attrCount) = dtProdGroupAttributes.Rows(i)("AttrDesc")
                arrProdGroupPos(attrCount) = dtProdGroupAttributes.Rows(i)("AttrPosition")
                attrCount = attrCount + 1
                If attrCount = 3 Then Exit For
            End If
        Next

        If attrCount = 3 Then
            For i = 0 To 2
                If arrProdGroupPos(i) <> 1 Then
                    If Len(Trim(prodgroup1)) = 0 Then
                        prodgroup1 = arrProdGroup(i)
                        prodgroup1_pos = CStr(arrProdGroupPos(i))
                    Else
                        prodgroup2 = arrProdGroup(i)
                        prodgroup2_pos = CStr(arrProdGroupPos(i))
                    End If
                End If
            Next
            If prodgroup2_pos < prodgroup1_pos Then
                tmpProdGroup = prodgroup1
                prodgroup1 = prodgroup2
                prodgroup2 = tmpProdGroup
            End If
        End If

        sql = "SELECT [attrposition], [attrlen] FROM [Product Group Attributes] WHERE [productgroup] = '" & dtItem.Rows(0)("prodgroup") & "' AND [attrdesc] = '" & prodgroup1 & "'"
        daColor = New OleDb.OleDbDataAdapter(sql, con)
        daColor.Fill(dtColor)

        sql = "SELECT [attrposition], [attrlen] FROM [Product Group Attributes] WHERE [productgroup] = '" & dtItem.Rows(0)("prodgroup") & "' AND [attrdesc] = '" & prodgroup2 & "'"
        daSize = New OleDb.OleDbDataAdapter(sql, con)
        daSize.Fill(dtSize)

        If dtColor.Rows.Count > 0 And dtSize.Rows.Count > 0 Then

            ' ------------------------------------------------
            ' pull out the color and size from the item number
            ' ------------------------------------------------

            tmpColor = Mid(dtItem.Rows(0)("Item"), dtColor.Rows(0)("attrPosition"), dtColor.Rows(0)("attrLen"))
            tmpSize = Mid(dtItem.Rows(0)("Item"), dtSize.Rows(0)("attrPosition"), dtSize.Rows(0)("attrLen"))

            For i = 0 To dtItem.Rows.Count - 1
                If UCase(Mid(dtItem.Rows(i)("Item"), 1, Len(ListBox1.Text))) = UCase(StyleNo) Then
                    If (chkAllItems.CheckState = System.Windows.Forms.CheckState.Checked) Or ((dtItem.Rows(i)("qtypotential") <> 0 Or dtItem.Rows(i)("qtytosell") <> 0 Or dtItem.Rows(i)("qty-on-hand") <> 0) And chkAllItems.CheckState = System.Windows.Forms.CheckState.Unchecked) Then

                        ' -------------------------------------
                        ' Add color number and description rows
                        ' -------------------------------------

                        If Mid(dtItem.Rows(i)("Item"), dtColor.Rows(0)("attrPosition"), dtColor.Rows(0)("attrLen")) <> tmpColor Then
                            tmpColor = Mid(dtItem.Rows(i)("Item"), dtColor.Rows(0)("attrPosition"), dtColor.Rows(0)("attrLen"))
                            dgvInventory.Item(0, Me.dgvInventory.Rows.Count - 1).Value = tmpColor
                            dgvInventory.Item(1, Me.dgvInventory.Rows.Count - 1).Value = dtItem.Rows(i)("attrib2")
                            dgvInventory.Rows.Add()
                        End If

                        ' -------------------------------------------
                        ' Create array for size code and descriptions
                        ' -------------------------------------------

                        If Mid(dtItem.Rows(i)("Item"), dtSize.Rows(0)("attrPosition"), dtSize.Rows(0)("attrLen")) <> tmpSize Then
                            tmpSize = Mid(dtItem.Rows(i)("Item"), dtSize.Rows(0)("attrPosition"), dtSize.Rows(0)("attrLen"))
                            If tmpSize <> "" Then


                                Dim foundrow As DataRow() = dtSizeCodes.Select("Code = '" & Mid(dtItem.Rows(i)("Item"), dtSize.Rows(0)("attrPosition"), dtSize.Rows(0)("attrLen")) & "'")
                                If foundrow.Length = 0 Then
                                    drSizeCodes = dtSizeCodes.NewRow
                                    drSizeCodes("Code") = Mid(dtItem.Rows(i)("Item"), dtSize.Rows(0)("attrPosition"), dtSize.Rows(0)("attrLen"))
                                    drSizeCodes("Desc") = dtItem.Rows(i)("attrib3")
                                    dtSizeCodes.Rows.Add(drSizeCodes)
                                End If
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

            dtSizeCodes.DefaultView.Sort = "Code ASC"

            For Each drv As DataRowView In dtSizeCodes.DefaultView
                tmpSizeCount = tmpSizeCount + 1
                dgvInventory.Columns.Add("Col" & Str(tmpSizeCount), "")
                dgvInventory.Columns("Col" & Str(tmpSizeCount)).Width = 70
                dgvInventory.Item(tmpSizeCount + 1, 0).Value = drv("Code")
                dgvInventory.Item(tmpSizeCount + 1, 1).Value = drv("Desc")
            Next
        End If

        'Load quantities
        '---------------

        If optQtyToSell.Checked Then
            optQtyToSell_CheckedChanged(optQtyToSell, New System.EventArgs())
        ElseIf optQtyPotential.Checked Then
            optQtyPotential_CheckedChanged(optQtyPotential, New System.EventArgs())
        ElseIf optQtyOnHand.Checked Then
            optQtyOnHand_CheckedChanged(optQtyOnHand, New System.EventArgs())
        End If

        'Display Color and Size count totals
        '-----------------------------------

        If dgvInventory.Item(1, 2).Value > "" Then
            Me.lblStyleColorCnt.Text = CStr(Me.dgvInventory.Rows.Count - 3)
            Me.lblStyleSizesCnt.Text = CStr(Me.dgvInventory.Columns.Count - 2)
        Else
            Me.lblStyleColorCnt.Text = "0"
            Me.lblStyleSizesCnt.Text = "0"
        End If
        con.Close()
    End Sub

    ''' <summary>
    ''' This procedure loads the quantities for the item selected in the inventory datagrid
    ''' </summary>
    ''' <param name="StyleNo"></param>
    ''' <remarks></remarks>

    Private Sub LoadQuantities(ByRef StyleNo As String)
        Dim con As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        Dim sql As String
        Dim color As Short
        Dim size_Renamed As Short
        Dim tmpColor As String
        Dim tmpSize As String

        con.ConnectionString = MySettings.Default("SaleForcConnectionString")
        con.Open()

        sql = "SELECT [qtypotential],[qty-on-hand],[qtytosell],[attrib1],[attrib2],[attrib3] FROM item WHERE [attrib1] = '" & ListBox1.Text & "'"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(dt)

        ' if not attributed items, then look for unattributed items
        If dt.Rows.Count = 0 Then
            sql = "SELECT [qtypotential],[qty-on-hand],[qtytosell],[attrib1],[attrib2],[attrib3] FROM item WHERE [item] LIKE " & Chr(39) & ListBox1.Text & "%" & Chr(39) & " AND [attrib1] = '' AND [attrib2] = '' AND [attrib3] = ''"
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(dt)
        End If


        If dt.Rows.Count > 0 Then
            For color = 1 To dgvInventory.Rows.Count - 1
                tmpColor = dgvInventory.Item(1, color).Value
                If tmpColor = Nothing And dt.Rows(0)("attrib1") = "" Then 'nonattributed items
                    dgvInventory.Visible = False
                    If optQtyPotential.Checked Then
                        MsgBox(optQtyPotential.Text & ": " & dt.Rows(0)("qtypotential"), MsgBoxStyle.Information, Me.ListBox1.Text)
                    End If
                    If optQtyOnHand.Checked Then
                        MsgBox(optQtyOnHand.Text & ": " & dt.Rows(0)("qty-on-hand"), MsgBoxStyle.Information, Me.ListBox1.Text)
                    End If
                    If optQtyToSell.Checked Then
                        MsgBox(optQtyToSell.Text & ": " & dt.Rows(0)("qtytosell"), MsgBoxStyle.Information, Me.ListBox1.Text)
                    End If
                    Exit Sub
                End If
                For size_Renamed = 2 To dgvInventory.Columns.Count - 1
                    tmpSize = dgvInventory.Item(size_Renamed, 1).Value
                    Dim foundrow As DataRow() = dt.Select("[Attrib2] = '" & tmpColor & "' and [Attrib3] = '" & tmpSize & "'")
                    If foundrow.Length > 0 Then
                        If optQtyPotential.Checked = True Then
                            If foundrow(0)("qtypotential") <> 0 Then
                                dgvInventory.Item(size_Renamed, color).Value = foundrow(0)("qtypotential")
                            ElseIf foundrow(0)("qtypotential") = 0 Then
                                dgvInventory.Item(size_Renamed, color).Value = ""
                            End If
                        ElseIf optQtyOnHand.Checked = True Then
                            If foundrow(0)("qty-on-hand") <> 0 Then
                                dgvInventory.Item(size_Renamed, color).Value = foundrow(0)("qty-on-hand")
                            ElseIf foundrow(0)("qty-on-hand") = 0 Then
                                dgvInventory.Item(size_Renamed, color).Value = ""
                            End If
                        ElseIf optQtyToSell.Checked = True Then
                            If foundrow(0)("qtytosell") <> 0 Then
                                dgvInventory.Item(size_Renamed, color).Value = foundrow(0)("qtytosell")
                            ElseIf foundrow(0)("qtytosell") = 0 Then
                                dgvInventory.Item(size_Renamed, color).Value = ""
                            End If
                        End If
                    End If
                Next
            Next
            dgvInventory.Visible = True
        Else
            dgvInventory.Visible = False
            Me.lblStyleColorCnt.Text = "0"
            Me.lblStyleSizesCnt.Text = "0"
        End If
        con.Close()
    End Sub

    ''' <summary>
    ''' This procedure will make a call to 'LoadQuantities' to display the 'on-hand' quantities
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub optQtyOnHand_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optQtyOnHand.CheckedChanged
        If tmpFormLoaded And eventSender.Checked Then
            Call LoadQuantities(ListBox1.Text)
            optQtyOnHand.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            optQtyOnHand.Font = New Font(optQtyOnHand.Font, FontStyle.Bold)
            optQtyPotential.ForeColor = System.Drawing.ColorTranslator.FromOle(&H80000012)
            optQtyPotential.Text = "Quantity Potential"
            optQtyPotential.Font = New Font(optQtyPotential.Font, FontStyle.Regular)
            optQtyToSell.ForeColor = System.Drawing.ColorTranslator.FromOle(&H80000012)
            optQtyToSell.Text = "Quantity To Sell"
            optQtyToSell.Font = New Font(optQtyToSell.Font, FontStyle.Regular)
        End If
    End Sub

    ''' <summary>
    ''' This procedure will make a call to 'LoadQuantities' to display the 'potential' quantities
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub optQtyPotential_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optQtyPotential.CheckedChanged
        If tmpFormLoaded And eventSender.Checked Then
            Call LoadQuantities(ListBox1.Text)
            optQtyPotential.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            optQtyPotential.Font = New Font(optQtyPotential.Font, FontStyle.Bold)
            optQtyOnHand.ForeColor = System.Drawing.ColorTranslator.FromOle(&H80000012)
            optQtyOnHand.Text = "Quantity On Hand"
            optQtyOnHand.Font = New Font(optQtyOnHand.Font, FontStyle.Regular)
            optQtyToSell.ForeColor = System.Drawing.ColorTranslator.FromOle(&H80000012)
            optQtyToSell.Text = "Quantity To Sell"
            optQtyToSell.Font = New Font(optQtyToSell.Font, FontStyle.Regular)
        End If
    End Sub

    ''' <summary>
    ''' This procedure will make a call to 'LoadQuantities' to display the 'to sell' quantities
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub optQtyToSell_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optQtyToSell.CheckedChanged
        If tmpFormLoaded And eventSender.Checked Then
            Call LoadQuantities(ListBox1.Text)
            optQtyToSell.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            optQtyToSell.Font = New Font(optQtyToSell.Font, FontStyle.Bold)
            optQtyOnHand.ForeColor = System.Drawing.ColorTranslator.FromOle(&H80000012)
            optQtyOnHand.Text = "Quantity On Hand"
            optQtyOnHand.Font = New Font(optQtyOnHand.Font, FontStyle.Regular)
            optQtyPotential.ForeColor = System.Drawing.ColorTranslator.FromOle(&H80000012)
            optQtyPotential.Text = "Quantity Potential"
            optQtyPotential.Font = New Font(optQtyPotential.Font, FontStyle.Regular)
        End If
    End Sub

    ''' <summary>
    ''' This procedure will search the item file with the criteria entered on the form looking at substrings of the item-no to see if they 
    ''' match the text entered in style, color and size text boxes.
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub findItemsbyNumber()
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        Dim mySQL As String

        con.Open()

        Timer1.Enabled = False
        cmdSearch.Font = New Font(cmdSearch.Font, FontStyle.Regular)

        'mySQL = "SELECT DISTINCT [Attrib1] FROM [item] WHERE LEN(Attrib1) = 4 AND "
        mySQL = "SELECT DISTINCT [Attrib1] FROM [item] WHERE "

        If Len(txtStyle.Text) > 0 Then
            mySQL = mySQL & "Attrib1 LIKE " & Chr(39) & txtStyle.Text & "%" & Chr(39) & " AND "
        End If

        If Len(cmbColor.Text) > 0 Then
            mySQL = mySQL & "mid$(item,5,4) LIKE " & Chr(39) & cmbColor.Text & "%" & Chr(39) & " AND "
        End If

        If Len(cmbSize.Text) > 0 Then
            mySQL = mySQL & "mid$(item,9,2) LIKE " & Chr(39) & cmbSize.Text & "%" & Chr(39) & " AND "
        End If

        If Len(txtDescription.Text) > 0 Then
            mySQL = mySQL & "description1 LIKE '%" & txtDescription.Text & "%' AND "
        End If

        If chkAllItems.CheckState = System.Windows.Forms.CheckState.Unchecked Then
            mySQL = mySQL & "[canbeordered] = true and ([qtypotential] <> 0 or [qtytosell] <> 0 or [qty-on-hand] <> 0) AND "
        End If

        If cmbProdGroups.Text <> "All" Then
            mySQL = mySQL & "[prodgroup] = " & Chr(39) & cmbProdGroups.Text & Chr(39) & " and ([begin-ship-date] >= #" & dtpBeginShip.Value & "# and [end-ship-date] <= #" & dtpEndShip.Value & "#)"
        Else
            mySQL = mySQL & "([begin-ship-date] >= #" & dtpBeginShip.Value & "# and [end-ship-date] <= #" & dtpEndShip.Value & "#)"
        End If

        da = New OleDb.OleDbDataAdapter(mySQL, con)
        da.Fill(dt)

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        ListBox1.DataSource = dt
        ListBox1.DisplayMember = "Attrib1"
        ListBox1.Refresh()

        If Me.ListBox1.Items.Count > 0 Then
            Me.dgvInventory.Visible = True
            Me.lblSearchResultsCnt.Text = CStr(ListBox1.Items.Count)
        Else
            ' search for non-attributed items
            mySQL = "SELECT DISTINCT [item] FROM [item] WHERE [item] LIKE " & Chr(39) & txtStyle.Text & "%" & Chr(39) & " AND [attrib1] = '' AND [attrib2] = '' AND [attrib3] = '' AND "

            If Len(txtDescription.Text) > 0 Then
                mySQL = mySQL & "description1 like '%" & txtDescription.Text & "%' AND "
            End If

            If chkAllItems.CheckState = System.Windows.Forms.CheckState.Unchecked Then
                mySQL = mySQL & "[canbeordered] = true and [qtypotential] <> 0 and [qtytosell] <> 0 and [qty-on-hand] <> 0 AND "
            End If

            If cmbProdGroups.Text <> "All" Then
                mySQL = mySQL & "[prodGroup] = " & Chr(39) & cmbProdGroups.Text & Chr(39) & " and ([begin-ship-date] >= #" & dtpBeginShip.Value & "# and [end-ship-date] <= #" & dtpEndShip.Value & "#)"
            Else
                mySQL = mySQL & "([begin-ship-date] >= #" & dtpBeginShip.Value & "# and [end-ship-date] <= #" & dtpEndShip.Value & "#)"
            End If

            da = New OleDb.OleDbDataAdapter(mySQL, con)
            da.Fill(dt)

            ListBox1.DataSource = dt
            ListBox1.DisplayMember = "Item"
            ListBox1.Refresh()
        End If

        If ListBox1.Items.Count = 0 Then
            MsgBox("Item not found", MsgBoxStyle.Critical, "Inventory")
            Me.txtStyle.Text = ""
            Me.txtDescription.Text = ""
            dgvInventory.Visible = False
            Me.lblSearchResultsCnt.Text = "0"
            Me.lblStyleColorCnt.Text = "0"
            Me.lblStyleSizesCnt.Text = "0"
            lblItemDescription1.Text = ""
            Me.lblPrice.Text = ""
            Me.lblProductGroup.Text = ""
            Me.lblStyle.Text = ""
        Else
            ListBox1_Click(Nothing, Nothing)
        End If
        con.Close()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    ''' <summary>
    ''' This procedure will search the item file with the criteria entered on the form looking to see if the style text box matches attrib1
    ''' of the item record, color text box matches attrib2 of the item record and size text box matches attrib3 of the item record
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub findItemsbyName()
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        Dim mySQL As String

        con.Open()

        Timer1.Enabled = False
        cmdSearch.Font = New Font(cmdSearch.Font, FontStyle.Regular)

        'mySQL = "SELECT DISTINCT [attrib1] from Item WHERE len(attrib1) = 4 AND "
        mySQL = "SELECT DISTINCT [Attrib1] FROM [item] WHERE "

        If Len(txtStyle.Text) > 0 Then
            mySQL = mySQL & "attrib1 LIKE " & Chr(39) & txtStyle.Text & "%" & Chr(39) & " AND "
        End If

        If Len(cmbColor.Text) > 0 Then
            mySQL = mySQL & "attrib2 LIKE '%" & cmbColor.Text & "%'" & " AND "
        End If

        If Len(cmbSize.Text) > 0 Then
            mySQL = mySQL & "attrib3 LIKE '%" & cmbSize.Text & "%'" & " AND "
        End If

        If Len(txtDescription.Text) > 0 Then
            mySQL = mySQL & "description1 like '%" & txtDescription.Text & "%' AND "
        End If

        If chkAllItems.CheckState = System.Windows.Forms.CheckState.Unchecked Then
            mySQL = mySQL & "[canbeordered] = true and [qtypotential] <> 0 and [qtytosell] <> 0 and [qty-on-hand] <> 0 AND"
        End If

        If cmbProdGroups.Text <> "All" Then
            mySQL = mySQL & "[prodGroup] = " & Chr(39) & cmbProdGroups.Text & Chr(39) & " and ([begin-ship-date] >= #" & dtpBeginShip.Value & "# and [end-ship-date] <= #" & dtpEndShip.Value & "#)"
        Else
            mySQL = mySQL & "([begin-ship-date] >= #" & dtpBeginShip.Value & "# and [end-ship-date] <= #" & dtpEndShip.Value & "#)"
        End If

        da = New OleDb.OleDbDataAdapter(mySQL, con)
        da.Fill(dt)

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        ListBox1.DataSource = dt
        ListBox1.DisplayMember = "Attrib1"
        ListBox1.Refresh()

        If ListBox1.Items.Count > 0 Then
            Me.dgvInventory.Visible = True
            Me.lblSearchResultsCnt.Text = CStr(ListBox1.Items.Count)
        Else
            ' search for non-attributed items
            mySQL = "SELECT DISTINCT [item] FROM [item] WHERE [item] LIKE " & Chr(39) & txtStyle.Text & "%" & Chr(39) & " AND [attrib1] = '' AND [attrib2] = '' AND [attrib3] = '' AND "

            If Len(txtDescription.Text) > 0 Then
                mySQL = mySQL & "description1 like '%" & txtDescription.Text & "%' AND "
            End If

            If chkAllItems.CheckState = System.Windows.Forms.CheckState.Unchecked Then
                mySQL = mySQL & "[canbeordered] = true and [qtypotential] <> 0 and [qtytosell] <> 0 and [qty-on-hand] <> 0 AND "
            End If

            If cmbProdGroups.Text <> "All" Then
                mySQL = mySQL & "[prodGroup] = " & Chr(39) & cmbProdGroups.Text & Chr(39) & " and ([begin-ship-date] >= #" & dtpBeginShip.Value & "# and [end-ship-date] <= #" & dtpEndShip.Value & "#)"
            Else
                mySQL = mySQL & "([begin-ship-date] >= #" & dtpBeginShip.Value & "# and [end-ship-date] <= #" & dtpEndShip.Value & "#)"
            End If

            da = New OleDb.OleDbDataAdapter(mySQL, con)
            da.Fill(dt)

            ListBox1.DataSource = dt
            ListBox1.DisplayMember = "Item"
            ListBox1.Refresh()

        End If

        If ListBox1.Items.Count = 0 Then

            MsgBox("Item not found", MsgBoxStyle.Critical, "Inventory")
            Me.txtStyle.Text = ""
            Me.txtDescription.Text = ""
            dgvInventory.Visible = False
            Me.lblSearchResultsCnt.Text = "0"
            Me.lblStyleColorCnt.Text = "0"
            Me.lblStyleSizesCnt.Text = "0"
            lblItemDescription1.Text = ""
            Me.lblPrice.Text = ""
            Me.lblProductGroup.Text = ""
            Me.lblStyle.Text = ""
        Else
            ListBox1_Click(Nothing, Nothing)
        End If
        con.Close()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    ''' <summary>
    ''' This procedure makes a call to write out the default search option to the 'Defaults' table.
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub optSearchByName_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optSearchByName.CheckedChanged
        If eventSender.Checked Then
            Timer1.Enabled = True
            WriteSearchOption()
        End If
    End Sub

    ''' <summary>
    ''' This procedure makes a call to write out the default search option to the 'Defaults' table.
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub optSearchByNumber_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optSearchByNumber.CheckedChanged
        If tmpFormLoaded And eventSender.Checked Then
            Timer1.Enabled = True
            WriteSearchOption()
        End If
    End Sub

    ''' <summary>
    ''' This procedure alternates the font from bold to regular on the Search button.  This is to get the user's attention that the 
    ''' search criteria has changed and they need to click on the Search button to refresh the results
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
        If counter = 1 Then
            counter = 2
            cmdSearch.Font = New Font(cmdSearch.Font, FontStyle.Bold)
        ElseIf counter = 2 Then
            counter = 1
            cmdSearch.Font = New Font(cmdSearch.Font, FontStyle.Regular)
        End If
    End Sub

    ''' <summary>
    ''' This procedure will clear the informational data in the upper right corner of the screen if all the search-related boxes are empty
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub txtDescription_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDescription.TextChanged
        Timer1.Enabled = True
        If Len(Trim(txtStyle.Text)) = 0 And Len(Trim(cmbColor.Text)) = 0 And Len(Trim(cmbSize.Text)) = 0 And Len(Trim(txtDescription.Text)) = 0 Then
            dgvInventory.Visible = False
            Me.lblSearchResultsCnt.Text = "0"
            Me.lblStyleColorCnt.Text = "0"
            Me.lblStyleSizesCnt.Text = "0"
            lblItemDescription1.Text = ""
            lblStyle.Text = ""
        End If
    End Sub

    ''' <summary>
    ''' This procedure makes a call to search for an item based on the criteria set on the form
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub txtDescription_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDescription.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            If optSearchByNumber.Checked = True Then
                findItemsbyNumber()
            ElseIf optSearchByName.Checked = True Then
                findItemsbyName()
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    ''' <summary>
    ''' This procedure will clear the informational data in the upper right corner of the screen if all the search-related boxes are empty
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub txtStyle_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtStyle.TextChanged
        Timer1.Enabled = True
        If Len(Trim(txtStyle.Text)) = 0 And Len(Trim(cmbColor.Text)) = 0 And Len(Trim(cmbSize.Text)) = 0 And Len(Trim(txtDescription.Text)) = 0 Then
            dgvInventory.Visible = False
            Me.lblSearchResultsCnt.Text = "0"
            Me.lblStyleColorCnt.Text = "0"
            Me.lblStyleSizesCnt.Text = "0"
            lblItemDescription1.Text = ""
            lblStyle.Text = ""
        End If
    End Sub

    ''' <summary>
    ''' This procedure makes a call to search for an item based on the criteria set on the form
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub txtStyle_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtStyle.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            If optSearchByNumber.Checked = True Then
                findItemsbyNumber()
            Else
                findItemsbyName()
            End If
            dgvInventory.Focus()
            If dgvInventory.ColumnCount <> 0 Then
                dgvInventory.CurrentCell = Me.dgvInventory(0, 0)
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    ''' <summary>
    ''' When the user clicks on the listbox, this procedure will search the item file for the item that was selected and display 
    ''' information related to the item in the upper right corner of the window.  It will then make a call to 'LoadColorsSizes' to 
    ''' create the row and column labels in the inventory datagrid. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub ListBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.Click
        Dim con As New OleDb.OleDbConnection
        Dim daItem As OleDb.OleDbDataAdapter
        Dim dtItem As New DataTable
        Dim daProdGroup As OleDb.OleDbDataAdapter
        Dim dtProdGroup As New DataTable
        Dim sql As String

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        lblStyle.Text = ListBox1.Text

        con.ConnectionString = MySettings.Default("SaleForcConnectionString")
        con.Open()

        sql = "SELECT [description1], [price1], [prodgroup] FROM [item] WHERE [attrib1] = '" & lblStyle.Text & "'"
        daItem = New OleDb.OleDbDataAdapter(sql, con)
        daItem.Fill(dtItem)

        If dtItem.Rows.Count = 0 Then
            ' if no attributed items, then try to find non-attributed items
            sql = "SELECT [description1], [price1], [prodgroup] FROM [item] WHERE [item] LIKE " & Chr(39) & lblStyle.Text & "%" & Chr(39) & " AND [attrib1] = '' AND [attrib2] = '' AND [attrib3] = ''"
            daItem = New OleDb.OleDbDataAdapter(sql, con)
            daItem.Fill(dtItem)
        End If

        sql = "SELECT [description] FROM [prodgroup] WHERE [prodgroup] = '" & dtItem.Rows(0)("prodgroup") & "'"
        daProdGroup = New OleDb.OleDbDataAdapter(sql, con)
        daProdGroup.Fill(dtProdGroup)

        con.Close()

        If dtItem.Rows.Count > 0 Then
            lblItemDescription1.Text = dtItem.Rows(0)("description1").ToString
            lblPrice.Text = Convert.ToDecimal(dtItem.Rows(0)("price1")).ToString("C")
            lblProductGroup.Text = dtItem.Rows(0)("prodgroup").ToString
        End If
        If dtProdGroup.Rows.Count > 0 Then
            lblprodgroupdesc.Text = dtProdGroup.Rows(0)("Description")
        Else
            lblprodgroupdesc.Text = ""
        End If

        Call LoadColorsSizes(Trim(lblStyle.Text))

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub frmInventory_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        Me.Cursor = Cursors.Default
    End Sub

    ''' <summary>
    ''' This procedure will clear the informational data in the upper right corner of the screen if all the search-related boxes are empty
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub cmbColor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbColor.Click
        Timer1.Enabled = True
        If Len(Trim(txtStyle.Text)) = 0 And Len(Trim(cmbColor.Text)) = 0 And Len(Trim(cmbSize.Text)) = 0 And Len(Trim(txtDescription.Text)) = 0 Then
            Timer1.Enabled = False
            ListBox1.Refresh()
            dgvInventory.Visible = False
            Me.lblSearchResultsCnt.Text = "0"
            Me.lblStyleColorCnt.Text = "0"
            Me.lblStyleSizesCnt.Text = "0"
            lblItemDescription1.Text = ""
            lblStyle.Text = ""
            Me.lblPrice.Text = ""
            Me.lblProductGroup.Text = ""
            Me.lblprodgroupdesc.Text = ""
        End If
        'If Not IsDBNull(cmbColor.get_Column(cmbColor.get_BoundColumn(), 0)) Then
        '    Me.cmbColor.Text = cmbColor.get_Column(cmbColor.get_BoundColumn(), 0)
        'End If
    End Sub

    ''' <summary>
    ''' This procedure makes a call to search for an item based on the criteria set on the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub cmbColor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbColor.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            If optSearchByNumber.Checked = True Then
                findItemsbyNumber()
            Else
                findItemsbyName()
            End If
        End If
    End Sub

    ''' <summary>
    ''' This procedure makes a call to search for an item based on the criteria set on the form
    ''' </summary>
    ''' <param name="Sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub cmbSize_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbSize.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            If optSearchByNumber.Checked = True Then
                findItemsbyNumber()
            Else
                findItemsbyName()
            End If
        End If
    End Sub

    ''' <summary>
    ''' This procedure will clear the informational data in the upper right corner of the screen if all the search-related boxes are empty
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub cmbSize_TextUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSize.TextUpdate
        Timer1.Enabled = True
        If Len(Trim(txtStyle.Text)) = 0 And Len(Trim(cmbColor.Text)) = 0 And Len(Trim(cmbSize.Text)) = 0 And Len(Trim(txtDescription.Text)) = 0 Then
            Timer1.Enabled = False
            ListBox1.Refresh()
            dgvInventory.Visible = False
            Me.lblSearchResultsCnt.Text = "0"
            Me.lblStyleColorCnt.Text = "0"
            Me.lblStyleSizesCnt.Text = "0"
            lblItemDescription1.Text = ""
            lblStyle.Text = ""
            Me.lblPrice.Text = ""
            Me.lblProductGroup.Text = ""
            Me.lblprodgroupdesc.Text = ""
        End If

        'If Not IsDBNull(cmbSize.get_Column(cmbSize.get_BoundColumn(), 0)) Then
        '    Me.cmbSize.Text = cmbSize.get_Column(cmbSize.get_BoundColumn(), 0)
        'End If
    End Sub

    Private Sub cmbProdGroups_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbProdGroups.GotFocus
        Timer1.Enabled = True
    End Sub

    ''' <summary>
    ''' This procedure will clear the screen and the 'search boxes' so that a new search can be conducted
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub cmdClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        Timer1.Enabled = False
        cmdSearch.Font = New Font(cmdSearch.Font, FontStyle.Regular)
        Me.txtStyle.Text = ""
        cmbColor.SelectedIndex = -1
        cmbSize.SelectedIndex = -1
        cmbProdGroups.SelectedIndex = 0
        cmbColor.Text = ""
        cmbSize.Text = ""
        Me.txtDescription.Text = ""
        dgvInventory.Visible = False
        dgvInventory.Rows.Clear()
        dgvInventory.Columns.Clear()
        Me.lblStyle.Text = ""
        Me.lblSearchResultsCnt.Text = "0"
        Me.lblStyleColorCnt.Text = "0"
        Me.lblStyleSizesCnt.Text = "0"
        lblItemDescription1.Text = ""
        Me.lblPrice.Text = ""
        Me.lblProductGroup.Text = ""
        Me.lblprodgroupdesc.Text = ""
        Me.ListBox1.DataSource = Nothing
        Me.txtStyle.Focus()
    End Sub

    ''' <summary>
    ''' This procedure will enable the timer so that the 'Search' button will alternate bold and regualar text to alert the user that
    ''' the search criteria has changed and that the search button needs to be clicked to updated the search results
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub dtpBeginShip_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpBeginShip.ValueChanged
        Timer1.Enabled = True
    End Sub

    ''' <summary>
    ''' This procedure will enable the timer so that the 'Search' button will alternate bold and regualar text to alert the user that
    ''' the search criteria has changed and that the search button needs to be clicked to updated the search results
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub dtpEndShip_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpEndShip.ValueChanged
        Timer1.Enabled = True
    End Sub

    ''' <summary>
    ''' When a user moves over a cell, this procedure will update the status bar at the bottom of the screen with information related to 
    ''' the item whose quantities are shown in that cell
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub dgvInventory_CellMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvInventory.CellMouseMove
        Dim tmpColor As String
        Dim tmpSize As String
        Dim tmpItemText As String
        Dim dtItem As SaleForcDataSet.ItemDataTable
        Dim daItem As New SaleForcDataSetTableAdapters.ItemTableAdapter
        Dim dtItemRow As SaleForcDataSet.ItemRow

        With dgvInventory
            tmpColor = .Item(0, e.RowIndex).Value
            tmpSize = .Item(e.ColumnIndex, 0).Value
            If Trim(tmpColor) > "" Then
                tmpItemText = String.Concat(ListBox1.Text, tmpColor, tmpSize)
                dtItem = daItem.GetDataByItem(tmpItemText)
                If dtItem.Rows.Count = 0 Then
                    Me.Cursor = Cursors.Default
                    Me.dgvInventory.Rows(e.RowIndex).Cells(e.ColumnIndex).ToolTipText = "Not Found"
                    Me.lblItem.Text = "Item Not Found"
                    Me.lblShipDates.Text = ""
                    Me.lblCanBeOrdered.Text = ""
                    Me.lblLastUpdate.Text = ""
                    CurrInventoryItem = ""
                Else
                    dtItemRow = dtItem.Rows(0)
                    Me.Cursor = Cursors.Hand
                    Me.dgvInventory.Rows(e.RowIndex).Cells(e.ColumnIndex).ToolTipText = tmpItemText & vbCrLf & "Ships: " & CStr(dtItemRow("Begin-ship-date")) & " - " & CStr(dtItemRow("End-ship-date")) & vbCrLf & "Can Be Ordered: " & Format(dtItemRow("CanBeOrdered"), "Yes/No") & vbCrLf & "Last Updated: " & dtItemRow("LastUpdated")
                    Me.lblItem.Text = "Item: " & tmpItemText
                    'Me.lblShipDates.Text = "Ships: " & CStr(dtItemRow("Begin-ship-date")) & " - " & CStr(dtItemRow("End-ship-date"))
                    Me.lblCanBeOrdered.Text = "Can Be Ordered: " & Format(dtItemRow("CanBeOrdered"), "Yes/No")
                    Me.lblLastUpdate.Text = "Last Updated:" & dtItemRow("LastUpdated")
                    CurrInventoryItem = tmpItemText
                End If
            End If
        End With
    End Sub

    ''' <summary>
    ''' When a user click on a cell in the inventory datagrid, this procedure will open the 'Customer Item' report which shows what 
    ''' customers order that item
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub dgvInventory_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvInventory.Click
        If CurrInventoryItem > "" Then
            CameFromInventoryForm = True
            frmCustItemRpt.Show()
        End If
    End Sub

    Private Sub dgvInventory_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvInventory.MouseWheel
        Me.dgvInventory.Select()
    End Sub
End Class