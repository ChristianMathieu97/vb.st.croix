<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventory))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.lblprodgroupdesc = New System.Windows.Forms.Label
        Me.lblStyleSizesCnt = New System.Windows.Forms.Label
        Me.dtpEndShip = New System.Windows.Forms.DateTimePicker
        Me.dtpBeginShip = New System.Windows.Forms.DateTimePicker
        Me.label8 = New System.Windows.Forms.Label
        Me.lblSearchResultsCnt = New System.Windows.Forms.Label
        Me.lblStylesFound = New System.Windows.Forms.Label
        Me.Frame6 = New System.Windows.Forms.GroupBox
        Me.optQtyPotential = New System.Windows.Forms.RadioButton
        Me.optQtyOnHand = New System.Windows.Forms.RadioButton
        Me.optQtyToSell = New System.Windows.Forms.RadioButton
        Me.Frame4 = New System.Windows.Forms.GroupBox
        Me.lblItemDescription1 = New System.Windows.Forms.Label
        Me.lblStyleColorCnt = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblStyle = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblPrice = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblProductGroup = New System.Windows.Forms.Label
        Me.chkAllItems = New System.Windows.Forms.CheckBox
        Me.optSearchByName = New System.Windows.Forms.RadioButton
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.cmdClear = New System.Windows.Forms.Button
        Me.optSearchByNumber = New System.Windows.Forms.RadioButton
        Me.cmdSearch = New System.Windows.Forms.Button
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.Frame8 = New System.Windows.Forms.GroupBox
        Me.txtStyle = New System.Windows.Forms.TextBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label13 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Frame7 = New System.Windows.Forms.GroupBox
        Me.cmbSize = New MTGCComboBox
        Me.cmbColor = New MTGCComboBox
        Me.cmbProdGroups = New MTGCComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgvInventory = New System.Windows.Forms.DataGridView
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.lblItem = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblShipDates = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblCanBeOrdered = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblLastUpdate = New System.Windows.Forms.ToolStripStatusLabel
        Me.Label9 = New System.Windows.Forms.Label
        Me.Frame6.SuspendLayout()
        Me.Frame4.SuspendLayout()
        Me.Frame8.SuspendLayout()
        Me.Frame7.SuspendLayout()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblprodgroupdesc
        '
        Me.lblprodgroupdesc.BackColor = System.Drawing.SystemColors.Control
        Me.lblprodgroupdesc.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblprodgroupdesc.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprodgroupdesc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblprodgroupdesc.Location = New System.Drawing.Point(139, 48)
        Me.lblprodgroupdesc.Name = "lblprodgroupdesc"
        Me.lblprodgroupdesc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblprodgroupdesc.Size = New System.Drawing.Size(157, 17)
        Me.lblprodgroupdesc.TabIndex = 45
        '
        'lblStyleSizesCnt
        '
        Me.lblStyleSizesCnt.BackColor = System.Drawing.SystemColors.Control
        Me.lblStyleSizesCnt.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblStyleSizesCnt.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStyleSizesCnt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStyleSizesCnt.Location = New System.Drawing.Point(221, 30)
        Me.lblStyleSizesCnt.Name = "lblStyleSizesCnt"
        Me.lblStyleSizesCnt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblStyleSizesCnt.Size = New System.Drawing.Size(56, 19)
        Me.lblStyleSizesCnt.TabIndex = 38
        Me.lblStyleSizesCnt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpEndShip
        '
        Me.dtpEndShip.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndShip.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEndShip.Location = New System.Drawing.Point(251, 46)
        Me.dtpEndShip.Name = "dtpEndShip"
        Me.dtpEndShip.Size = New System.Drawing.Size(96, 20)
        Me.dtpEndShip.TabIndex = 51
        Me.dtpEndShip.Value = New Date(2011, 10, 5, 0, 0, 0, 0)
        '
        'dtpBeginShip
        '
        Me.dtpBeginShip.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBeginShip.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBeginShip.Location = New System.Drawing.Point(251, 21)
        Me.dtpBeginShip.Name = "dtpBeginShip"
        Me.dtpBeginShip.Size = New System.Drawing.Size(96, 20)
        Me.dtpBeginShip.TabIndex = 50
        Me.dtpBeginShip.Value = New Date(1951, 1, 1, 0, 0, 0, 0)
        '
        'label8
        '
        Me.label8.BackColor = System.Drawing.SystemColors.Control
        Me.label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.label8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.label8.Location = New System.Drawing.Point(184, 32)
        Me.label8.Name = "label8"
        Me.label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label8.Size = New System.Drawing.Size(42, 17)
        Me.label8.TabIndex = 37
        Me.label8.Text = "Sizes:"
        '
        'lblSearchResultsCnt
        '
        Me.lblSearchResultsCnt.BackColor = System.Drawing.SystemColors.Control
        Me.lblSearchResultsCnt.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSearchResultsCnt.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchResultsCnt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSearchResultsCnt.Location = New System.Drawing.Point(48, 139)
        Me.lblSearchResultsCnt.Name = "lblSearchResultsCnt"
        Me.lblSearchResultsCnt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSearchResultsCnt.Size = New System.Drawing.Size(33, 14)
        Me.lblSearchResultsCnt.TabIndex = 44
        '
        'lblStylesFound
        '
        Me.lblStylesFound.BackColor = System.Drawing.SystemColors.Control
        Me.lblStylesFound.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblStylesFound.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStylesFound.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStylesFound.Location = New System.Drawing.Point(8, 139)
        Me.lblStylesFound.Name = "lblStylesFound"
        Me.lblStylesFound.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblStylesFound.Size = New System.Drawing.Size(44, 15)
        Me.lblStylesFound.TabIndex = 43
        Me.lblStylesFound.Text = "Styles:"
        '
        'Frame6
        '
        Me.Frame6.BackColor = System.Drawing.SystemColors.Control
        Me.Frame6.Controls.Add(Me.optQtyPotential)
        Me.Frame6.Controls.Add(Me.optQtyOnHand)
        Me.Frame6.Controls.Add(Me.optQtyToSell)
        Me.Frame6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame6.Location = New System.Drawing.Point(476, 81)
        Me.Frame6.Name = "Frame6"
        Me.Frame6.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame6.Size = New System.Drawing.Size(153, 92)
        Me.Frame6.TabIndex = 44
        Me.Frame6.TabStop = False
        Me.Frame6.Text = "Quantity to Show"
        '
        'optQtyPotential
        '
        Me.optQtyPotential.BackColor = System.Drawing.SystemColors.Control
        Me.optQtyPotential.Cursor = System.Windows.Forms.Cursors.Default
        Me.optQtyPotential.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optQtyPotential.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optQtyPotential.Location = New System.Drawing.Point(8, 16)
        Me.optQtyPotential.Name = "optQtyPotential"
        Me.optQtyPotential.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optQtyPotential.Size = New System.Drawing.Size(129, 17)
        Me.optQtyPotential.TabIndex = 22
        Me.optQtyPotential.TabStop = True
        Me.optQtyPotential.Text = "Quantity Potential"
        Me.ToolTip1.SetToolTip(Me.optQtyPotential, "Quantity on Hand minus Quantity on Customer Orders plus Quantity on Purchase Orde" & _
                "rs plus Quantity On Work Orders")
        Me.optQtyPotential.UseVisualStyleBackColor = False
        '
        'optQtyOnHand
        '
        Me.optQtyOnHand.BackColor = System.Drawing.SystemColors.Control
        Me.optQtyOnHand.Cursor = System.Windows.Forms.Cursors.Default
        Me.optQtyOnHand.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optQtyOnHand.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optQtyOnHand.Location = New System.Drawing.Point(8, 40)
        Me.optQtyOnHand.Name = "optQtyOnHand"
        Me.optQtyOnHand.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optQtyOnHand.Size = New System.Drawing.Size(137, 17)
        Me.optQtyOnHand.TabIndex = 21
        Me.optQtyOnHand.TabStop = True
        Me.optQtyOnHand.Text = "Quantity On Hand"
        Me.ToolTip1.SetToolTip(Me.optQtyOnHand, "Quantity on the shelf")
        Me.optQtyOnHand.UseVisualStyleBackColor = False
        '
        'optQtyToSell
        '
        Me.optQtyToSell.BackColor = System.Drawing.SystemColors.Control
        Me.optQtyToSell.Checked = True
        Me.optQtyToSell.Cursor = System.Windows.Forms.Cursors.Default
        Me.optQtyToSell.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optQtyToSell.ForeColor = System.Drawing.Color.Red
        Me.optQtyToSell.Location = New System.Drawing.Point(8, 64)
        Me.optQtyToSell.Name = "optQtyToSell"
        Me.optQtyToSell.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optQtyToSell.Size = New System.Drawing.Size(121, 17)
        Me.optQtyToSell.TabIndex = 20
        Me.optQtyToSell.TabStop = True
        Me.optQtyToSell.Text = "Quantity To Sell"
        Me.ToolTip1.SetToolTip(Me.optQtyToSell, "Quantity On Hand minus Quantity on Customer Orders")
        Me.optQtyToSell.UseVisualStyleBackColor = False
        '
        'Frame4
        '
        Me.Frame4.BackColor = System.Drawing.SystemColors.Control
        Me.Frame4.Controls.Add(Me.lblprodgroupdesc)
        Me.Frame4.Controls.Add(Me.lblItemDescription1)
        Me.Frame4.Controls.Add(Me.lblStyleSizesCnt)
        Me.Frame4.Controls.Add(Me.label8)
        Me.Frame4.Controls.Add(Me.lblStyleColorCnt)
        Me.Frame4.Controls.Add(Me.Label7)
        Me.Frame4.Controls.Add(Me.Label10)
        Me.Frame4.Controls.Add(Me.lblStyle)
        Me.Frame4.Controls.Add(Me.Label3)
        Me.Frame4.Controls.Add(Me.lblPrice)
        Me.Frame4.Controls.Add(Me.Label11)
        Me.Frame4.Controls.Add(Me.lblProductGroup)
        Me.Frame4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame4.Location = New System.Drawing.Point(476, 11)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame4.Size = New System.Drawing.Size(299, 69)
        Me.Frame4.TabIndex = 43
        Me.Frame4.TabStop = False
        Me.Frame4.Text = "Style Information"
        '
        'lblItemDescription1
        '
        Me.lblItemDescription1.BackColor = System.Drawing.SystemColors.Control
        Me.lblItemDescription1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblItemDescription1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemDescription1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblItemDescription1.Location = New System.Drawing.Point(115, 13)
        Me.lblItemDescription1.Name = "lblItemDescription1"
        Me.lblItemDescription1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblItemDescription1.Size = New System.Drawing.Size(181, 20)
        Me.lblItemDescription1.TabIndex = 39
        Me.lblItemDescription1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.lblItemDescription1, "This is the item description")
        '
        'lblStyleColorCnt
        '
        Me.lblStyleColorCnt.BackColor = System.Drawing.SystemColors.Control
        Me.lblStyleColorCnt.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblStyleColorCnt.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStyleColorCnt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStyleColorCnt.Location = New System.Drawing.Point(136, 29)
        Me.lblStyleColorCnt.Name = "lblStyleColorCnt"
        Me.lblStyleColorCnt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblStyleColorCnt.Size = New System.Drawing.Size(49, 20)
        Me.lblStyleColorCnt.TabIndex = 36
        Me.lblStyleColorCnt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(96, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(41, 17)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Colors:"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(8, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(34, 17)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Style:"
        '
        'lblStyle
        '
        Me.lblStyle.BackColor = System.Drawing.SystemColors.Control
        Me.lblStyle.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblStyle.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStyle.Location = New System.Drawing.Point(40, 16)
        Me.lblStyle.Name = "lblStyle"
        Me.lblStyle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblStyle.Size = New System.Drawing.Size(65, 17)
        Me.lblStyle.TabIndex = 33
        Me.lblStyle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(34, 16)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Price:"
        '
        'lblPrice
        '
        Me.lblPrice.BackColor = System.Drawing.SystemColors.Control
        Me.lblPrice.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPrice.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPrice.Location = New System.Drawing.Point(40, 32)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPrice.Size = New System.Drawing.Size(59, 17)
        Me.lblPrice.TabIndex = 31
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(8, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(82, 17)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Product Group:"
        '
        'lblProductGroup
        '
        Me.lblProductGroup.BackColor = System.Drawing.SystemColors.Control
        Me.lblProductGroup.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblProductGroup.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductGroup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblProductGroup.Location = New System.Drawing.Point(88, 48)
        Me.lblProductGroup.Name = "lblProductGroup"
        Me.lblProductGroup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblProductGroup.Size = New System.Drawing.Size(33, 17)
        Me.lblProductGroup.TabIndex = 29
        '
        'chkAllItems
        '
        Me.chkAllItems.BackColor = System.Drawing.SystemColors.Control
        Me.chkAllItems.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAllItems.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAllItems.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAllItems.Location = New System.Drawing.Point(222, 97)
        Me.chkAllItems.Name = "chkAllItems"
        Me.chkAllItems.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAllItems.Size = New System.Drawing.Size(126, 32)
        Me.chkAllItems.TabIndex = 6
        Me.chkAllItems.Text = "Show zero-quantity colors/sizes"
        Me.chkAllItems.UseVisualStyleBackColor = False
        '
        'optSearchByName
        '
        Me.optSearchByName.BackColor = System.Drawing.SystemColors.Control
        Me.optSearchByName.Cursor = System.Windows.Forms.Cursors.Default
        Me.optSearchByName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSearchByName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optSearchByName.Location = New System.Drawing.Point(84, 139)
        Me.optSearchByName.Name = "optSearchByName"
        Me.optSearchByName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optSearchByName.Size = New System.Drawing.Size(57, 17)
        Me.optSearchByName.TabIndex = 3
        Me.optSearchByName.TabStop = True
        Me.optSearchByName.Text = "Name"
        Me.optSearchByName.UseVisualStyleBackColor = False
        '
        'txtDescription
        '
        Me.txtDescription.AcceptsReturn = True
        Me.txtDescription.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescription.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDescription.Location = New System.Drawing.Point(78, 96)
        Me.txtDescription.MaxLength = 0
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDescription.Size = New System.Drawing.Size(113, 20)
        Me.txtDescription.TabIndex = 1
        '
        'cmdClear
        '
        Me.cmdClear.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClear.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClear.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClear.Location = New System.Drawing.Point(292, 132)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClear.Size = New System.Drawing.Size(65, 24)
        Me.cmdClear.TabIndex = 8
        Me.cmdClear.Text = "&Clear"
        Me.cmdClear.UseVisualStyleBackColor = False
        '
        'optSearchByNumber
        '
        Me.optSearchByNumber.BackColor = System.Drawing.SystemColors.Control
        Me.optSearchByNumber.Checked = True
        Me.optSearchByNumber.Cursor = System.Windows.Forms.Cursors.Default
        Me.optSearchByNumber.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSearchByNumber.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optSearchByNumber.Location = New System.Drawing.Point(84, 122)
        Me.optSearchByNumber.Name = "optSearchByNumber"
        Me.optSearchByNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optSearchByNumber.Size = New System.Drawing.Size(71, 17)
        Me.optSearchByNumber.TabIndex = 2
        Me.optSearchByNumber.TabStop = True
        Me.optSearchByNumber.Text = "Number"
        Me.optSearchByNumber.UseVisualStyleBackColor = False
        '
        'cmdSearch
        '
        Me.cmdSearch.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSearch.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSearch.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSearch.Location = New System.Drawing.Point(220, 132)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSearch.Size = New System.Drawing.Size(65, 24)
        Me.cmdSearch.TabIndex = 7
        Me.cmdSearch.Text = "&Search"
        Me.cmdSearch.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 14
        Me.ListBox1.Location = New System.Drawing.Point(11, 17)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(70, 116)
        Me.ListBox1.TabIndex = 47
        '
        'Frame8
        '
        Me.Frame8.BackColor = System.Drawing.SystemColors.Control
        Me.Frame8.Controls.Add(Me.ListBox1)
        Me.Frame8.Controls.Add(Me.lblSearchResultsCnt)
        Me.Frame8.Controls.Add(Me.lblStylesFound)
        Me.Frame8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame8.Location = New System.Drawing.Point(381, 12)
        Me.Frame8.Name = "Frame8"
        Me.Frame8.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame8.Size = New System.Drawing.Size(89, 161)
        Me.Frame8.TabIndex = 46
        Me.Frame8.TabStop = False
        Me.Frame8.Text = "Results"
        '
        'txtStyle
        '
        Me.txtStyle.AcceptsReturn = True
        Me.txtStyle.BackColor = System.Drawing.SystemColors.Window
        Me.txtStyle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStyle.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtStyle.Location = New System.Drawing.Point(77, 19)
        Me.txtStyle.MaxLength = 0
        Me.txtStyle.Name = "txtStyle"
        Me.txtStyle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStyle.Size = New System.Drawing.Size(113, 20)
        Me.txtStyle.TabIndex = 0
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ShowAlways = True
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(194, 70)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(44, 29)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Product Group:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(187, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(58, 48)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "Ships Between:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(12, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(65, 32)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Search By:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(13, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(65, 17)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Size:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(12, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(65, 17)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Color:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(12, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Description:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Frame7
        '
        Me.Frame7.BackColor = System.Drawing.SystemColors.Control
        Me.Frame7.Controls.Add(Me.cmbSize)
        Me.Frame7.Controls.Add(Me.cmbColor)
        Me.Frame7.Controls.Add(Me.cmbProdGroups)
        Me.Frame7.Controls.Add(Me.dtpEndShip)
        Me.Frame7.Controls.Add(Me.dtpBeginShip)
        Me.Frame7.Controls.Add(Me.chkAllItems)
        Me.Frame7.Controls.Add(Me.optSearchByName)
        Me.Frame7.Controls.Add(Me.optSearchByNumber)
        Me.Frame7.Controls.Add(Me.cmdSearch)
        Me.Frame7.Controls.Add(Me.cmdClear)
        Me.Frame7.Controls.Add(Me.txtDescription)
        Me.Frame7.Controls.Add(Me.txtStyle)
        Me.Frame7.Controls.Add(Me.Label13)
        Me.Frame7.Controls.Add(Me.Label15)
        Me.Frame7.Controls.Add(Me.Label2)
        Me.Frame7.Controls.Add(Me.Label6)
        Me.Frame7.Controls.Add(Me.Label5)
        Me.Frame7.Controls.Add(Me.Label4)
        Me.Frame7.Controls.Add(Me.Label1)
        Me.Frame7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame7.Location = New System.Drawing.Point(12, 12)
        Me.Frame7.Name = "Frame7"
        Me.Frame7.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame7.Size = New System.Drawing.Size(363, 161)
        Me.Frame7.TabIndex = 45
        Me.Frame7.TabStop = False
        Me.Frame7.Text = "Search Criteria"
        '
        'cmbSize
        '
        Me.cmbSize.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cmbSize.ArrowColor = System.Drawing.Color.Black
        Me.cmbSize.BindedControl = CType(resources.GetObject("cmbSize.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.cmbSize.BorderStyle = MTGCComboBox.TipiBordi.FlatXP
        Me.cmbSize.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbSize.ColumnNum = 1
        Me.cmbSize.ColumnWidth = "121"
        Me.cmbSize.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cmbSize.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.cmbSize.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.cmbSize.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.cmbSize.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.cmbSize.DisplayMember = "Text"
        Me.cmbSize.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSize.DropDownArrowBackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.cmbSize.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cmbSize.DropDownForeColor = System.Drawing.Color.Black
        Me.cmbSize.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.cmbSize.DropDownWidth = 141
        Me.cmbSize.GridLineColor = System.Drawing.Color.LightGray
        Me.cmbSize.GridLineHorizontal = False
        Me.cmbSize.GridLineVertical = False
        Me.cmbSize.HighlightBorderColor = System.Drawing.Color.Blue
        Me.cmbSize.HighlightBorderOnMouseEvents = True
        Me.cmbSize.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cmbSize.Location = New System.Drawing.Point(78, 69)
        Me.cmbSize.ManagingFastMouseMoving = True
        Me.cmbSize.ManagingFastMouseMovingInterval = 30
        Me.cmbSize.Name = "cmbSize"
        Me.cmbSize.NormalBorderColor = System.Drawing.Color.Black
        Me.cmbSize.SelectedItem = Nothing
        Me.cmbSize.SelectedValue = Nothing
        Me.cmbSize.Size = New System.Drawing.Size(113, 21)
        Me.cmbSize.TabIndex = 56
        '
        'cmbColor
        '
        Me.cmbColor.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cmbColor.ArrowColor = System.Drawing.Color.Black
        Me.cmbColor.BindedControl = CType(resources.GetObject("cmbColor.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.cmbColor.BorderStyle = MTGCComboBox.TipiBordi.FlatXP
        Me.cmbColor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbColor.ColumnNum = 1
        Me.cmbColor.ColumnWidth = "121"
        Me.cmbColor.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cmbColor.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.cmbColor.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.cmbColor.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.cmbColor.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.cmbColor.DisplayMember = "Text"
        Me.cmbColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbColor.DropDownArrowBackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.cmbColor.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cmbColor.DropDownForeColor = System.Drawing.Color.Black
        Me.cmbColor.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.cmbColor.DropDownWidth = 141
        Me.cmbColor.GridLineColor = System.Drawing.Color.LightGray
        Me.cmbColor.GridLineHorizontal = False
        Me.cmbColor.GridLineVertical = False
        Me.cmbColor.HighlightBorderColor = System.Drawing.Color.Blue
        Me.cmbColor.HighlightBorderOnMouseEvents = True
        Me.cmbColor.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cmbColor.Location = New System.Drawing.Point(78, 45)
        Me.cmbColor.ManagingFastMouseMoving = True
        Me.cmbColor.ManagingFastMouseMovingInterval = 30
        Me.cmbColor.Name = "cmbColor"
        Me.cmbColor.NormalBorderColor = System.Drawing.Color.Black
        Me.cmbColor.SelectedItem = Nothing
        Me.cmbColor.SelectedValue = Nothing
        Me.cmbColor.Size = New System.Drawing.Size(113, 21)
        Me.cmbColor.TabIndex = 55
        '
        'cmbProdGroups
        '
        Me.cmbProdGroups.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cmbProdGroups.ArrowColor = System.Drawing.Color.Black
        Me.cmbProdGroups.BindedControl = CType(resources.GetObject("cmbProdGroups.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.cmbProdGroups.BorderStyle = MTGCComboBox.TipiBordi.FlatXP
        Me.cmbProdGroups.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbProdGroups.ColumnNum = 1
        Me.cmbProdGroups.ColumnWidth = "121"
        Me.cmbProdGroups.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cmbProdGroups.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.cmbProdGroups.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.cmbProdGroups.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.cmbProdGroups.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.cmbProdGroups.DisplayMember = "Text"
        Me.cmbProdGroups.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbProdGroups.DropDownArrowBackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.cmbProdGroups.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cmbProdGroups.DropDownForeColor = System.Drawing.Color.Black
        Me.cmbProdGroups.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.cmbProdGroups.DropDownWidth = 141
        Me.cmbProdGroups.GridLineColor = System.Drawing.Color.LightGray
        Me.cmbProdGroups.GridLineHorizontal = False
        Me.cmbProdGroups.GridLineVertical = False
        Me.cmbProdGroups.HighlightBorderColor = System.Drawing.Color.Blue
        Me.cmbProdGroups.HighlightBorderOnMouseEvents = True
        Me.cmbProdGroups.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cmbProdGroups.Location = New System.Drawing.Point(251, 71)
        Me.cmbProdGroups.ManagingFastMouseMoving = True
        Me.cmbProdGroups.ManagingFastMouseMovingInterval = 30
        Me.cmbProdGroups.Name = "cmbProdGroups"
        Me.cmbProdGroups.NormalBorderColor = System.Drawing.Color.Black
        Me.cmbProdGroups.SelectedItem = Nothing
        Me.cmbProdGroups.SelectedValue = Nothing
        Me.cmbProdGroups.Size = New System.Drawing.Size(96, 21)
        Me.cmbProdGroups.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Style:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvInventory
        '
        Me.dgvInventory.AllowUserToAddRows = False
        Me.dgvInventory.AllowUserToDeleteRows = False
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInventory.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvInventory.GridColor = System.Drawing.SystemColors.Control
        Me.dgvInventory.Location = New System.Drawing.Point(9, 174)
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.ReadOnly = True
        Me.dgvInventory.RowHeadersVisible = False
        Me.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvInventory.Size = New System.Drawing.Size(766, 345)
        Me.dgvInventory.TabIndex = 47
        Me.dgvInventory.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblItem, Me.lblShipDates, Me.lblCanBeOrdered, Me.lblLastUpdate})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 514)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(787, 24)
        Me.StatusStrip1.TabIndex = 48
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblItem
        '
        Me.lblItem.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(35, 19)
        Me.lblItem.Text = "Item"
        '
        'lblShipDates
        '
        Me.lblShipDates.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.lblShipDates.Name = "lblShipDates"
        Me.lblShipDates.Size = New System.Drawing.Size(66, 19)
        Me.lblShipDates.Text = "Ship Dates"
        '
        'lblCanBeOrdered
        '
        Me.lblCanBeOrdered.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.lblCanBeOrdered.Name = "lblCanBeOrdered"
        Me.lblCanBeOrdered.Size = New System.Drawing.Size(92, 19)
        Me.lblCanBeOrdered.Text = "Can be ordered"
        '
        'lblLastUpdate
        '
        Me.lblLastUpdate.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.lblLastUpdate.Name = "lblLastUpdate"
        Me.lblLastUpdate.Size = New System.Drawing.Size(73, 19)
        Me.lblLastUpdate.Text = "Last Update"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(637, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(138, 77)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "TIP:  Click on a cell in the grid below to find out which customers ordered that " & _
            "item!"
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 538)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.dgvInventory)
        Me.Controls.Add(Me.Frame6)
        Me.Controls.Add(Me.Frame4)
        Me.Controls.Add(Me.Frame8)
        Me.Controls.Add(Me.Frame7)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInventory"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory"
        Me.Frame6.ResumeLayout(False)
        Me.Frame4.ResumeLayout(False)
        Me.Frame8.ResumeLayout(False)
        Me.Frame7.ResumeLayout(False)
        Me.Frame7.PerformLayout()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents lblprodgroupdesc As System.Windows.Forms.Label
    Public WithEvents lblStyleSizesCnt As System.Windows.Forms.Label
    Friend WithEvents dtpEndShip As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpBeginShip As System.Windows.Forms.DateTimePicker
    Public WithEvents label8 As System.Windows.Forms.Label
    Public WithEvents lblSearchResultsCnt As System.Windows.Forms.Label
    Public WithEvents lblStylesFound As System.Windows.Forms.Label
    Public WithEvents Frame6 As System.Windows.Forms.GroupBox
    Public WithEvents optQtyPotential As System.Windows.Forms.RadioButton
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents optQtyOnHand As System.Windows.Forms.RadioButton
    Public WithEvents optQtyToSell As System.Windows.Forms.RadioButton
    Public WithEvents Frame4 As System.Windows.Forms.GroupBox
    Public WithEvents lblItemDescription1 As System.Windows.Forms.Label
    Public WithEvents lblStyleColorCnt As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents lblStyle As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents lblPrice As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents lblProductGroup As System.Windows.Forms.Label
    Public WithEvents chkAllItems As System.Windows.Forms.CheckBox
    Public WithEvents optSearchByName As System.Windows.Forms.RadioButton
    Public WithEvents txtDescription As System.Windows.Forms.TextBox
    Public WithEvents cmdClear As System.Windows.Forms.Button
    Public WithEvents optSearchByNumber As System.Windows.Forms.RadioButton
    Public WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Public WithEvents Frame8 As System.Windows.Forms.GroupBox
    Public WithEvents txtStyle As System.Windows.Forms.TextBox
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents Timer1 As System.Windows.Forms.Timer
    Public WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Frame7 As System.Windows.Forms.GroupBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvInventory As System.Windows.Forms.DataGridView
    Friend WithEvents cmbProdGroups As MTGCComboBox
    Friend WithEvents cmbSize As MTGCComboBox
    Friend WithEvents cmbColor As MTGCComboBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblItem As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblShipDates As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblCanBeOrdered As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblLastUpdate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
