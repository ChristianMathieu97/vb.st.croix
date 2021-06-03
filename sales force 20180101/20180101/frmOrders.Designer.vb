<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmOrders
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents txtWSID As System.Windows.Forms.TextBox
	Public WithEvents btnExit As System.Windows.Forms.Button
	Public WithEvents txtOrder As System.Windows.Forms.TextBox
	Public WithEvents lblShipName As System.Windows.Forms.Label
	Public WithEvents Label23 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents Text1 As System.Windows.Forms.TextBox
	Public WithEvents txtAllocVal As System.Windows.Forms.TextBox
	Public WithEvents txtOpenValue As System.Windows.Forms.TextBox
	Public WithEvents txtAllocQty As System.Windows.Forms.TextBox
	Public WithEvents txtOpenOrdQty As System.Windows.Forms.TextBox
	Public WithEvents txtShippedQty As System.Windows.Forms.TextBox
	Public WithEvents txtPpsNo As System.Windows.Forms.TextBox
	Public WithEvents txtPpsQty As System.Windows.Forms.TextBox
	Public WithEvents txtOrderDate As System.Windows.Forms.TextBox
	Public WithEvents txtRequestedDate As System.Windows.Forms.TextBox
	Public WithEvents txtCancelDate As System.Windows.Forms.TextBox
	Public WithEvents txtPpsDate As System.Windows.Forms.TextBox
	Public WithEvents txtCompleteDate As System.Windows.Forms.TextBox
	Public WithEvents txtInvoiceDate As System.Windows.Forms.TextBox
	Public WithEvents txtInvoiceNo As System.Windows.Forms.TextBox
	Public WithEvents txtOrderNo As System.Windows.Forms.TextBox
	Public WithEvents txtOrdQty As System.Windows.Forms.TextBox
	Public WithEvents Label33 As System.Windows.Forms.Label
	Public WithEvents Label27 As System.Windows.Forms.Label
	Public WithEvents Label26 As System.Windows.Forms.Label
	Public WithEvents Label25 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label15 As System.Windows.Forms.Label
	Public WithEvents Label16 As System.Windows.Forms.Label
	Public WithEvents Frame5 As System.Windows.Forms.GroupBox
	Public WithEvents chkOrderComplete As System.Windows.Forms.CheckBox
	Public WithEvents chkSpecialOrder As System.Windows.Forms.CheckBox
	Public WithEvents txtSeason As System.Windows.Forms.TextBox
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents Frame6 As System.Windows.Forms.GroupBox
	Public WithEvents SalesmanCode As System.Windows.Forms.TextBox
	Public WithEvents Text18 As System.Windows.Forms.TextBox
	Public WithEvents txtCommisionCode As System.Windows.Forms.TextBox
	Public WithEvents Label18 As System.Windows.Forms.Label
	Public WithEvents Label19 As System.Windows.Forms.Label
	Public WithEvents Label20 As System.Windows.Forms.Label
	Public WithEvents Frame4 As System.Windows.Forms.GroupBox
	Public WithEvents txtChargeTo As System.Windows.Forms.TextBox
	Public WithEvents txtHoldARCode As System.Windows.Forms.TextBox
	Public WithEvents txtTermsCd As System.Windows.Forms.TextBox
	Public WithEvents txtCreditReject As System.Windows.Forms.TextBox
	Public WithEvents txtHoldShipCode As System.Windows.Forms.TextBox
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label17 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents _SSTab1_TabPage0 As System.Windows.Forms.TabPage
	Public WithEvents txtShipName As System.Windows.Forms.TextBox
	Public WithEvents txtShipAddr1 As System.Windows.Forms.TextBox
	Public WithEvents txtShipAddr2 As System.Windows.Forms.TextBox
	Public WithEvents txtShipAddr3 As System.Windows.Forms.TextBox
	Public WithEvents txtShipCity As System.Windows.Forms.TextBox
	Public WithEvents txtShipState As System.Windows.Forms.TextBox
	Public WithEvents txtShipZip As System.Windows.Forms.TextBox
	Public WithEvents txtShipCountry As System.Windows.Forms.TextBox
	Public WithEvents Frame8 As System.Windows.Forms.GroupBox
	Public WithEvents txtShipPhoneNo As System.Windows.Forms.TextBox
	Public WithEvents txtShipContact As System.Windows.Forms.TextBox
	Public WithEvents Label30 As System.Windows.Forms.Label
	Public WithEvents Label29 As System.Windows.Forms.Label
	Public WithEvents Label24 As System.Windows.Forms.Label
	Public WithEvents Frame7 As System.Windows.Forms.GroupBox
	Public WithEvents txtDept As System.Windows.Forms.TextBox
	Public WithEvents txtShipToNo As System.Windows.Forms.TextBox
	Public WithEvents txtCustNo As System.Windows.Forms.TextBox
	Public WithEvents lblPONo As System.Windows.Forms.Label
	Public WithEvents lblLastUpDate As System.Windows.Forms.Label
	Public WithEvents lblShipViaCd As System.Windows.Forms.Label
	Public WithEvents Label32 As System.Windows.Forms.Label
	Public WithEvents Label31 As System.Windows.Forms.Label
	Public WithEvents Label28 As System.Windows.Forms.Label
	Public WithEvents Label22 As System.Windows.Forms.Label
	Public WithEvents Label21 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents _SSTab1_TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents _SSTab1_TabPage2 As System.Windows.Forms.TabPage
	Public WithEvents SSTab1 As System.Windows.Forms.TabControl
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me.txtWSID = New System.Windows.Forms.TextBox
        Me.bndOrder = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaleForcDataSet = New KC01.SaleForcDataSet
        Me.btnExit = New System.Windows.Forms.Button
        Me.txtOrder = New System.Windows.Forms.TextBox
        Me.lblShipName = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SSTab1 = New System.Windows.Forms.TabControl
        Me._SSTab1_TabPage0 = New System.Windows.Forms.TabPage
        Me.Frame5 = New System.Windows.Forms.GroupBox
        Me.Text1 = New System.Windows.Forms.TextBox
        Me.txtAllocVal = New System.Windows.Forms.TextBox
        Me.txtOpenValue = New System.Windows.Forms.TextBox
        Me.txtAllocQty = New System.Windows.Forms.TextBox
        Me.txtOpenOrdQty = New System.Windows.Forms.TextBox
        Me.txtShippedQty = New System.Windows.Forms.TextBox
        Me.txtPpsNo = New System.Windows.Forms.TextBox
        Me.txtPpsQty = New System.Windows.Forms.TextBox
        Me.txtOrderDate = New System.Windows.Forms.TextBox
        Me.txtRequestedDate = New System.Windows.Forms.TextBox
        Me.txtCancelDate = New System.Windows.Forms.TextBox
        Me.txtPpsDate = New System.Windows.Forms.TextBox
        Me.txtCompleteDate = New System.Windows.Forms.TextBox
        Me.txtInvoiceDate = New System.Windows.Forms.TextBox
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox
        Me.txtOrderNo = New System.Windows.Forms.TextBox
        Me.txtOrdQty = New System.Windows.Forms.TextBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Frame6 = New System.Windows.Forms.GroupBox
        Me.chkOrderComplete = New System.Windows.Forms.CheckBox
        Me.chkSpecialOrder = New System.Windows.Forms.CheckBox
        Me.txtSeason = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Frame4 = New System.Windows.Forms.GroupBox
        Me.SalesmanCode = New System.Windows.Forms.TextBox
        Me.Text18 = New System.Windows.Forms.TextBox
        Me.txtCommisionCode = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.txtChargeTo = New System.Windows.Forms.TextBox
        Me.txtHoldARCode = New System.Windows.Forms.TextBox
        Me.txtTermsCd = New System.Windows.Forms.TextBox
        Me.txtCreditReject = New System.Windows.Forms.TextBox
        Me.txtHoldShipCode = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me._SSTab1_TabPage1 = New System.Windows.Forms.TabPage
        Me.Frame8 = New System.Windows.Forms.GroupBox
        Me.txtShipName = New System.Windows.Forms.TextBox
        Me.txtShipAddr1 = New System.Windows.Forms.TextBox
        Me.txtShipAddr2 = New System.Windows.Forms.TextBox
        Me.txtShipAddr3 = New System.Windows.Forms.TextBox
        Me.txtShipCity = New System.Windows.Forms.TextBox
        Me.txtShipState = New System.Windows.Forms.TextBox
        Me.txtShipZip = New System.Windows.Forms.TextBox
        Me.txtShipCountry = New System.Windows.Forms.TextBox
        Me.Frame7 = New System.Windows.Forms.GroupBox
        Me.txtShipPhoneNo = New System.Windows.Forms.TextBox
        Me.txtShipContact = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtDept = New System.Windows.Forms.TextBox
        Me.txtShipToNo = New System.Windows.Forms.TextBox
        Me.txtCustNo = New System.Windows.Forms.TextBox
        Me.lblPONo = New System.Windows.Forms.Label
        Me.lblLastUpDate = New System.Windows.Forms.Label
        Me.lblShipViaCd = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me._SSTab1_TabPage2 = New System.Windows.Forms.TabPage
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.OrdernoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LinenoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ItemnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ItemDesc1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ItemDesc2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GrosspriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QtyorigordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QtyshippedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QtyopenordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QtyallocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QtyonppsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RequestdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CommcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CommrateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ShipNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ShipAddr1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ShipAddr2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ShipAddr3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ShipCityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ShipStateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ShipZipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ShipCountryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LastppsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LastinvnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OrdercodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CustShipCdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ExtPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TagmemoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CompletedateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CutbackqtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CutbackstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CutbackdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OrderdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LastUpdatedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bndOrderLine = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderTableAdapter = New KC01.SaleForcDataSetTableAdapters.OrderTableAdapter
        Me.Order_lineTableAdapter = New KC01.SaleForcDataSetTableAdapters.Order_lineTableAdapter
        Me.Frame2.SuspendLayout()
        CType(Me.bndOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleForcDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SSTab1.SuspendLayout()
        Me._SSTab1_TabPage0.SuspendLayout()
        Me.Frame5.SuspendLayout()
        Me.Frame6.SuspendLayout()
        Me.Frame4.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me._SSTab1_TabPage1.SuspendLayout()
        Me.Frame8.SuspendLayout()
        Me.Frame7.SuspendLayout()
        Me._SSTab1_TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndOrderLine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.txtWSID)
        Me.Frame2.Controls.Add(Me.btnExit)
        Me.Frame2.Controls.Add(Me.txtOrder)
        Me.Frame2.Controls.Add(Me.lblShipName)
        Me.Frame2.Controls.Add(Me.Label23)
        Me.Frame2.Controls.Add(Me.Label1)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.Color.Blue
        Me.Frame2.Location = New System.Drawing.Point(0, 0)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(777, 81)
        Me.Frame2.TabIndex = 0
        Me.Frame2.TabStop = False
        '
        'txtWSID
        '
        Me.txtWSID.AcceptsReturn = True
        Me.txtWSID.BackColor = System.Drawing.SystemColors.Window
        Me.txtWSID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWSID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "WorksheetID", True))
        Me.txtWSID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWSID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtWSID.Location = New System.Drawing.Point(640, 16)
        Me.txtWSID.MaxLength = 0
        Me.txtWSID.Name = "txtWSID"
        Me.txtWSID.ReadOnly = True
        Me.txtWSID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWSID.Size = New System.Drawing.Size(121, 20)
        Me.txtWSID.TabIndex = 38
        Me.txtWSID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bndOrder
        '
        Me.bndOrder.DataMember = "Order"
        Me.bndOrder.DataSource = Me.SaleForcDataSet
        '
        'SaleForcDataSet
        '
        Me.SaleForcDataSet.DataSetName = "SaleForcDataSet"
        Me.SaleForcDataSet.EnforceConstraints = False
        Me.SaleForcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(8, 48)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExit.Size = New System.Drawing.Size(65, 25)
        Me.btnExit.TabIndex = 37
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtOrder
        '
        Me.txtOrder.AcceptsReturn = True
        Me.txtOrder.BackColor = System.Drawing.SystemColors.Window
        Me.txtOrder.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOrder.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "Order-no", True))
        Me.txtOrder.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrder.ForeColor = System.Drawing.Color.Red
        Me.txtOrder.Location = New System.Drawing.Point(311, 18)
        Me.txtOrder.MaxLength = 0
        Me.txtOrder.Name = "txtOrder"
        Me.txtOrder.ReadOnly = True
        Me.txtOrder.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOrder.Size = New System.Drawing.Size(97, 20)
        Me.txtOrder.TabIndex = 1
        '
        'lblShipName
        '
        Me.lblShipName.BackColor = System.Drawing.SystemColors.Control
        Me.lblShipName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShipName.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShipName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "ShipName", True))
        Me.lblShipName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShipName.ForeColor = System.Drawing.Color.Blue
        Me.lblShipName.Location = New System.Drawing.Point(9, 18)
        Me.lblShipName.Name = "lblShipName"
        Me.lblShipName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblShipName.Size = New System.Drawing.Size(201, 17)
        Me.lblShipName.TabIndex = 55
        Me.lblShipName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblShipName.UseMnemonic = False
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.SystemColors.Control
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(537, 18)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(97, 17)
        Me.Label23.TabIndex = 39
        Me.Label23.Text = "Worksheet ID:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(216, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Order number:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'SSTab1
        '
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage0)
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage1)
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage2)
        Me.SSTab1.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.bndOrder, "Cust-no", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.SSTab1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SSTab1.ItemSize = New System.Drawing.Size(42, 18)
        Me.SSTab1.Location = New System.Drawing.Point(8, 88)
        Me.SSTab1.Name = "SSTab1"
        Me.SSTab1.SelectedIndex = 0
        Me.SSTab1.Size = New System.Drawing.Size(761, 465)
        Me.SSTab1.TabIndex = 3
        '
        '_SSTab1_TabPage0
        '
        Me._SSTab1_TabPage0.BackColor = System.Drawing.SystemColors.Control
        Me._SSTab1_TabPage0.Controls.Add(Me.Frame5)
        Me._SSTab1_TabPage0.Controls.Add(Me.Frame6)
        Me._SSTab1_TabPage0.Controls.Add(Me.Frame4)
        Me._SSTab1_TabPage0.Controls.Add(Me.Frame1)
        Me._SSTab1_TabPage0.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage0.Name = "_SSTab1_TabPage0"
        Me._SSTab1_TabPage0.Size = New System.Drawing.Size(753, 439)
        Me._SSTab1_TabPage0.TabIndex = 0
        Me._SSTab1_TabPage0.Text = "Summary"
        '
        'Frame5
        '
        Me.Frame5.BackColor = System.Drawing.SystemColors.Control
        Me.Frame5.Controls.Add(Me.Text1)
        Me.Frame5.Controls.Add(Me.txtAllocVal)
        Me.Frame5.Controls.Add(Me.txtOpenValue)
        Me.Frame5.Controls.Add(Me.txtAllocQty)
        Me.Frame5.Controls.Add(Me.txtOpenOrdQty)
        Me.Frame5.Controls.Add(Me.txtShippedQty)
        Me.Frame5.Controls.Add(Me.txtPpsNo)
        Me.Frame5.Controls.Add(Me.txtPpsQty)
        Me.Frame5.Controls.Add(Me.txtOrderDate)
        Me.Frame5.Controls.Add(Me.txtRequestedDate)
        Me.Frame5.Controls.Add(Me.txtCancelDate)
        Me.Frame5.Controls.Add(Me.txtPpsDate)
        Me.Frame5.Controls.Add(Me.txtCompleteDate)
        Me.Frame5.Controls.Add(Me.txtInvoiceDate)
        Me.Frame5.Controls.Add(Me.txtInvoiceNo)
        Me.Frame5.Controls.Add(Me.txtOrderNo)
        Me.Frame5.Controls.Add(Me.txtOrdQty)
        Me.Frame5.Controls.Add(Me.Label33)
        Me.Frame5.Controls.Add(Me.Label27)
        Me.Frame5.Controls.Add(Me.Label26)
        Me.Frame5.Controls.Add(Me.Label25)
        Me.Frame5.Controls.Add(Me.Label2)
        Me.Frame5.Controls.Add(Me.Label6)
        Me.Frame5.Controls.Add(Me.Label7)
        Me.Frame5.Controls.Add(Me.Label13)
        Me.Frame5.Controls.Add(Me.Label14)
        Me.Frame5.Controls.Add(Me.Label3)
        Me.Frame5.Controls.Add(Me.Label4)
        Me.Frame5.Controls.Add(Me.Label15)
        Me.Frame5.Controls.Add(Me.Label16)
        Me.Frame5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame5.Location = New System.Drawing.Point(24, 13)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame5.Size = New System.Drawing.Size(553, 249)
        Me.Frame5.TabIndex = 4
        Me.Frame5.TabStop = False
        '
        'Text1
        '
        Me.Text1.AcceptsReturn = True
        Me.Text1.BackColor = System.Drawing.SystemColors.Window
        Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "Net-value", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.Text1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1.Location = New System.Drawing.Point(440, 24)
        Me.Text1.MaxLength = 0
        Me.Text1.Name = "Text1"
        Me.Text1.ReadOnly = True
        Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1.Size = New System.Drawing.Size(97, 20)
        Me.Text1.TabIndex = 65
        '
        'txtAllocVal
        '
        Me.txtAllocVal.AcceptsReturn = True
        Me.txtAllocVal.BackColor = System.Drawing.SystemColors.Window
        Me.txtAllocVal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAllocVal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "Alloc-value", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtAllocVal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAllocVal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAllocVal.Location = New System.Drawing.Point(440, 168)
        Me.txtAllocVal.MaxLength = 0
        Me.txtAllocVal.Name = "txtAllocVal"
        Me.txtAllocVal.ReadOnly = True
        Me.txtAllocVal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAllocVal.Size = New System.Drawing.Size(97, 20)
        Me.txtAllocVal.TabIndex = 64
        '
        'txtOpenValue
        '
        Me.txtOpenValue.AcceptsReturn = True
        Me.txtOpenValue.BackColor = System.Drawing.SystemColors.Window
        Me.txtOpenValue.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOpenValue.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "OpenValue", True))
        Me.txtOpenValue.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOpenValue.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOpenValue.Location = New System.Drawing.Point(440, 216)
        Me.txtOpenValue.MaxLength = 0
        Me.txtOpenValue.Name = "txtOpenValue"
        Me.txtOpenValue.ReadOnly = True
        Me.txtOpenValue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOpenValue.Size = New System.Drawing.Size(97, 20)
        Me.txtOpenValue.TabIndex = 63
        '
        'txtAllocQty
        '
        Me.txtAllocQty.AcceptsReturn = True
        Me.txtAllocQty.BackColor = System.Drawing.SystemColors.Window
        Me.txtAllocQty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAllocQty.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "Alloc-qty", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtAllocQty.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAllocQty.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAllocQty.Location = New System.Drawing.Point(328, 168)
        Me.txtAllocQty.MaxLength = 0
        Me.txtAllocQty.Name = "txtAllocQty"
        Me.txtAllocQty.ReadOnly = True
        Me.txtAllocQty.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAllocQty.Size = New System.Drawing.Size(97, 20)
        Me.txtAllocQty.TabIndex = 35
        '
        'txtOpenOrdQty
        '
        Me.txtOpenOrdQty.AcceptsReturn = True
        Me.txtOpenOrdQty.BackColor = System.Drawing.SystemColors.Window
        Me.txtOpenOrdQty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOpenOrdQty.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "Qty-open-order", True))
        Me.txtOpenOrdQty.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOpenOrdQty.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOpenOrdQty.Location = New System.Drawing.Point(328, 216)
        Me.txtOpenOrdQty.MaxLength = 0
        Me.txtOpenOrdQty.Name = "txtOpenOrdQty"
        Me.txtOpenOrdQty.ReadOnly = True
        Me.txtOpenOrdQty.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOpenOrdQty.Size = New System.Drawing.Size(97, 20)
        Me.txtOpenOrdQty.TabIndex = 33
        '
        'txtShippedQty
        '
        Me.txtShippedQty.AcceptsReturn = True
        Me.txtShippedQty.BackColor = System.Drawing.SystemColors.Window
        Me.txtShippedQty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShippedQty.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "Qty-shipped", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtShippedQty.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShippedQty.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtShippedQty.Location = New System.Drawing.Point(328, 192)
        Me.txtShippedQty.MaxLength = 0
        Me.txtShippedQty.Name = "txtShippedQty"
        Me.txtShippedQty.ReadOnly = True
        Me.txtShippedQty.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtShippedQty.Size = New System.Drawing.Size(97, 20)
        Me.txtShippedQty.TabIndex = 32
        '
        'txtPpsNo
        '
        Me.txtPpsNo.AcceptsReturn = True
        Me.txtPpsNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtPpsNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPpsNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "Pps-no", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtPpsNo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPpsNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPpsNo.Location = New System.Drawing.Point(208, 48)
        Me.txtPpsNo.MaxLength = 0
        Me.txtPpsNo.Name = "txtPpsNo"
        Me.txtPpsNo.ReadOnly = True
        Me.txtPpsNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPpsNo.Size = New System.Drawing.Size(97, 20)
        Me.txtPpsNo.TabIndex = 24
        '
        'txtPpsQty
        '
        Me.txtPpsQty.AcceptsReturn = True
        Me.txtPpsQty.BackColor = System.Drawing.SystemColors.Window
        Me.txtPpsQty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPpsQty.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "Qty-on-pps", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtPpsQty.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPpsQty.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPpsQty.Location = New System.Drawing.Point(328, 48)
        Me.txtPpsQty.MaxLength = 0
        Me.txtPpsQty.Name = "txtPpsQty"
        Me.txtPpsQty.ReadOnly = True
        Me.txtPpsQty.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPpsQty.Size = New System.Drawing.Size(97, 20)
        Me.txtPpsQty.TabIndex = 23
        '
        'txtOrderDate
        '
        Me.txtOrderDate.AcceptsReturn = True
        Me.txtOrderDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtOrderDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOrderDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "Order-date", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtOrderDate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrderDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOrderDate.Location = New System.Drawing.Point(88, 24)
        Me.txtOrderDate.MaxLength = 0
        Me.txtOrderDate.Name = "txtOrderDate"
        Me.txtOrderDate.ReadOnly = True
        Me.txtOrderDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOrderDate.Size = New System.Drawing.Size(97, 20)
        Me.txtOrderDate.TabIndex = 13
        '
        'txtRequestedDate
        '
        Me.txtRequestedDate.AcceptsReturn = True
        Me.txtRequestedDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtRequestedDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRequestedDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "Request-date", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtRequestedDate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRequestedDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRequestedDate.Location = New System.Drawing.Point(88, 96)
        Me.txtRequestedDate.MaxLength = 0
        Me.txtRequestedDate.Name = "txtRequestedDate"
        Me.txtRequestedDate.ReadOnly = True
        Me.txtRequestedDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRequestedDate.Size = New System.Drawing.Size(97, 20)
        Me.txtRequestedDate.TabIndex = 12
        '
        'txtCancelDate
        '
        Me.txtCancelDate.AcceptsReturn = True
        Me.txtCancelDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtCancelDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCancelDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "Cancel-date", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtCancelDate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCancelDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCancelDate.Location = New System.Drawing.Point(88, 144)
        Me.txtCancelDate.MaxLength = 0
        Me.txtCancelDate.Name = "txtCancelDate"
        Me.txtCancelDate.ReadOnly = True
        Me.txtCancelDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCancelDate.Size = New System.Drawing.Size(97, 20)
        Me.txtCancelDate.TabIndex = 11
        '
        'txtPpsDate
        '
        Me.txtPpsDate.AcceptsReturn = True
        Me.txtPpsDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtPpsDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPpsDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "Pps-date", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtPpsDate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPpsDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPpsDate.Location = New System.Drawing.Point(88, 48)
        Me.txtPpsDate.MaxLength = 0
        Me.txtPpsDate.Name = "txtPpsDate"
        Me.txtPpsDate.ReadOnly = True
        Me.txtPpsDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPpsDate.Size = New System.Drawing.Size(97, 20)
        Me.txtPpsDate.TabIndex = 10
        '
        'txtCompleteDate
        '
        Me.txtCompleteDate.AcceptsReturn = True
        Me.txtCompleteDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtCompleteDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCompleteDate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompleteDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCompleteDate.Location = New System.Drawing.Point(88, 120)
        Me.txtCompleteDate.MaxLength = 0
        Me.txtCompleteDate.Name = "txtCompleteDate"
        Me.txtCompleteDate.ReadOnly = True
        Me.txtCompleteDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCompleteDate.Size = New System.Drawing.Size(97, 20)
        Me.txtCompleteDate.TabIndex = 9
        '
        'txtInvoiceDate
        '
        Me.txtInvoiceDate.AcceptsReturn = True
        Me.txtInvoiceDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtInvoiceDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInvoiceDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "Invoice-date", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtInvoiceDate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtInvoiceDate.Location = New System.Drawing.Point(88, 72)
        Me.txtInvoiceDate.MaxLength = 0
        Me.txtInvoiceDate.Name = "txtInvoiceDate"
        Me.txtInvoiceDate.ReadOnly = True
        Me.txtInvoiceDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtInvoiceDate.Size = New System.Drawing.Size(97, 20)
        Me.txtInvoiceDate.TabIndex = 8
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.AcceptsReturn = True
        Me.txtInvoiceNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtInvoiceNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInvoiceNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "Invoice-no", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtInvoiceNo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtInvoiceNo.Location = New System.Drawing.Point(208, 72)
        Me.txtInvoiceNo.MaxLength = 0
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.ReadOnly = True
        Me.txtInvoiceNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtInvoiceNo.Size = New System.Drawing.Size(97, 20)
        Me.txtInvoiceNo.TabIndex = 7
        '
        'txtOrderNo
        '
        Me.txtOrderNo.AcceptsReturn = True
        Me.txtOrderNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtOrderNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOrderNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "Order-no", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtOrderNo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrderNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOrderNo.Location = New System.Drawing.Point(208, 24)
        Me.txtOrderNo.MaxLength = 0
        Me.txtOrderNo.Name = "txtOrderNo"
        Me.txtOrderNo.ReadOnly = True
        Me.txtOrderNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOrderNo.Size = New System.Drawing.Size(97, 20)
        Me.txtOrderNo.TabIndex = 6
        '
        'txtOrdQty
        '
        Me.txtOrdQty.AcceptsReturn = True
        Me.txtOrdQty.BackColor = System.Drawing.SystemColors.Window
        Me.txtOrdQty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOrdQty.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "Qty-orig-ord", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtOrdQty.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrdQty.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOrdQty.Location = New System.Drawing.Point(328, 24)
        Me.txtOrdQty.MaxLength = 0
        Me.txtOrdQty.Name = "txtOrdQty"
        Me.txtOrdQty.ReadOnly = True
        Me.txtOrdQty.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOrdQty.Size = New System.Drawing.Size(97, 20)
        Me.txtOrdQty.TabIndex = 5
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.SystemColors.Control
        Me.Label33.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label33.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label33.Location = New System.Drawing.Point(464, 8)
        Me.Label33.Name = "Label33"
        Me.Label33.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label33.Size = New System.Drawing.Size(57, 17)
        Me.Label33.TabIndex = 62
        Me.Label33.Text = "Value"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.SystemColors.Control
        Me.Label27.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label27.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label27.Location = New System.Drawing.Point(8, 176)
        Me.Label27.Name = "Label27"
        Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label27.Size = New System.Drawing.Size(73, 17)
        Me.Label27.TabIndex = 36
        Me.Label27.Text = "Allocated:"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.SystemColors.Control
        Me.Label26.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(8, 224)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(73, 17)
        Me.Label26.TabIndex = 34
        Me.Label26.Text = "Open order:"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.SystemColors.Control
        Me.Label25.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(24, 200)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label25.Size = New System.Drawing.Size(57, 17)
        Me.Label25.TabIndex = 31
        Me.Label25.Text = "Shipped:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(24, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Order:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(11, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(70, 24)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Requested:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(24, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(57, 17)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Cancel:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(24, 56)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(57, 17)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Pick slip:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(11, 131)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(70, 14)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Complete:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(24, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Invoice:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(208, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(97, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Ref. Number"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(112, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(33, 17)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Date"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(344, 8)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(57, 17)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Quantity"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Frame6
        '
        Me.Frame6.BackColor = System.Drawing.SystemColors.Control
        Me.Frame6.Controls.Add(Me.chkOrderComplete)
        Me.Frame6.Controls.Add(Me.chkSpecialOrder)
        Me.Frame6.Controls.Add(Me.txtSeason)
        Me.Frame6.Controls.Add(Me.Label12)
        Me.Frame6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame6.Location = New System.Drawing.Point(534, 279)
        Me.Frame6.Name = "Frame6"
        Me.Frame6.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame6.Size = New System.Drawing.Size(215, 97)
        Me.Frame6.TabIndex = 66
        Me.Frame6.TabStop = False
        '
        'chkOrderComplete
        '
        Me.chkOrderComplete.BackColor = System.Drawing.SystemColors.Control
        Me.chkOrderComplete.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkOrderComplete.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkOrderComplete.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bndOrder, "Ord-complete", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.chkOrderComplete.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOrderComplete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkOrderComplete.Location = New System.Drawing.Point(8, 64)
        Me.chkOrderComplete.Name = "chkOrderComplete"
        Me.chkOrderComplete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkOrderComplete.Size = New System.Drawing.Size(116, 25)
        Me.chkOrderComplete.TabIndex = 69
        Me.chkOrderComplete.TabStop = False
        Me.chkOrderComplete.Text = "Order complete"
        Me.chkOrderComplete.UseVisualStyleBackColor = False
        '
        'chkSpecialOrder
        '
        Me.chkSpecialOrder.BackColor = System.Drawing.SystemColors.Control
        Me.chkSpecialOrder.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSpecialOrder.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSpecialOrder.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bndOrder, "Special-order", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.chkSpecialOrder.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSpecialOrder.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSpecialOrder.Location = New System.Drawing.Point(8, 40)
        Me.chkSpecialOrder.Name = "chkSpecialOrder"
        Me.chkSpecialOrder.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSpecialOrder.Size = New System.Drawing.Size(116, 25)
        Me.chkSpecialOrder.TabIndex = 68
        Me.chkSpecialOrder.TabStop = False
        Me.chkSpecialOrder.Text = "  Special order"
        Me.chkSpecialOrder.UseVisualStyleBackColor = False
        '
        'txtSeason
        '
        Me.txtSeason.AcceptsReturn = True
        Me.txtSeason.BackColor = System.Drawing.SystemColors.Window
        Me.txtSeason.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSeason.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "Season", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtSeason.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeason.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSeason.Location = New System.Drawing.Point(96, 16)
        Me.txtSeason.MaxLength = 0
        Me.txtSeason.Name = "txtSeason"
        Me.txtSeason.ReadOnly = True
        Me.txtSeason.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSeason.Size = New System.Drawing.Size(105, 20)
        Me.txtSeason.TabIndex = 67
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(40, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(49, 17)
        Me.Label12.TabIndex = 70
        Me.Label12.Text = "Season:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Frame4
        '
        Me.Frame4.BackColor = System.Drawing.SystemColors.Control
        Me.Frame4.Controls.Add(Me.SalesmanCode)
        Me.Frame4.Controls.Add(Me.Text18)
        Me.Frame4.Controls.Add(Me.txtCommisionCode)
        Me.Frame4.Controls.Add(Me.Label18)
        Me.Frame4.Controls.Add(Me.Label19)
        Me.Frame4.Controls.Add(Me.Label20)
        Me.Frame4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame4.ForeColor = System.Drawing.Color.Blue
        Me.Frame4.Location = New System.Drawing.Point(279, 279)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame4.Size = New System.Drawing.Size(249, 97)
        Me.Frame4.TabIndex = 71
        Me.Frame4.TabStop = False
        Me.Frame4.Text = " Salesman "
        '
        'SalesmanCode
        '
        Me.SalesmanCode.AcceptsReturn = True
        Me.SalesmanCode.BackColor = System.Drawing.SystemColors.Window
        Me.SalesmanCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SalesmanCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "Slsmn-code", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.SalesmanCode.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesmanCode.ForeColor = System.Drawing.SystemColors.WindowText
        Me.SalesmanCode.Location = New System.Drawing.Point(136, 16)
        Me.SalesmanCode.MaxLength = 0
        Me.SalesmanCode.Name = "SalesmanCode"
        Me.SalesmanCode.ReadOnly = True
        Me.SalesmanCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SalesmanCode.Size = New System.Drawing.Size(97, 20)
        Me.SalesmanCode.TabIndex = 74
        '
        'Text18
        '
        Me.Text18.AcceptsReturn = True
        Me.Text18.BackColor = System.Drawing.SystemColors.Window
        Me.Text18.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text18.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "Comm-rate", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.Text18.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text18.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text18.Location = New System.Drawing.Point(136, 64)
        Me.Text18.MaxLength = 0
        Me.Text18.Name = "Text18"
        Me.Text18.ReadOnly = True
        Me.Text18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text18.Size = New System.Drawing.Size(97, 20)
        Me.Text18.TabIndex = 73
        '
        'txtCommisionCode
        '
        Me.txtCommisionCode.AcceptsReturn = True
        Me.txtCommisionCode.BackColor = System.Drawing.SystemColors.Window
        Me.txtCommisionCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCommisionCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "Comm-code", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtCommisionCode.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCommisionCode.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCommisionCode.Location = New System.Drawing.Point(136, 40)
        Me.txtCommisionCode.MaxLength = 0
        Me.txtCommisionCode.Name = "txtCommisionCode"
        Me.txtCommisionCode.ReadOnly = True
        Me.txtCommisionCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCommisionCode.Size = New System.Drawing.Size(97, 20)
        Me.txtCommisionCode.TabIndex = 72
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(40, 24)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(89, 17)
        Me.Label18.TabIndex = 77
        Me.Label18.Text = "Code:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.Control
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(16, 72)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(113, 17)
        Me.Label19.TabIndex = 76
        Me.Label19.Text = "Commission rate:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(24, 48)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(105, 17)
        Me.Label20.TabIndex = 75
        Me.Label20.Text = "Commission code:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.txtChargeTo)
        Me.Frame1.Controls.Add(Me.txtHoldARCode)
        Me.Frame1.Controls.Add(Me.txtTermsCd)
        Me.Frame1.Controls.Add(Me.txtCreditReject)
        Me.Frame1.Controls.Add(Me.txtHoldShipCode)
        Me.Frame1.Controls.Add(Me.Label8)
        Me.Frame1.Controls.Add(Me.Label9)
        Me.Frame1.Controls.Add(Me.Label10)
        Me.Frame1.Controls.Add(Me.Label11)
        Me.Frame1.Controls.Add(Me.Label17)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.Color.Blue
        Me.Frame1.Location = New System.Drawing.Point(24, 277)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(249, 139)
        Me.Frame1.TabIndex = 78
        Me.Frame1.TabStop = False
        Me.Frame1.Text = " Credit "
        '
        'txtChargeTo
        '
        Me.txtChargeTo.AcceptsReturn = True
        Me.txtChargeTo.BackColor = System.Drawing.SystemColors.Window
        Me.txtChargeTo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtChargeTo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "Charge-cust", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtChargeTo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChargeTo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtChargeTo.Location = New System.Drawing.Point(136, 16)
        Me.txtChargeTo.MaxLength = 0
        Me.txtChargeTo.Name = "txtChargeTo"
        Me.txtChargeTo.ReadOnly = True
        Me.txtChargeTo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtChargeTo.Size = New System.Drawing.Size(97, 20)
        Me.txtChargeTo.TabIndex = 83
        '
        'txtHoldARCode
        '
        Me.txtHoldARCode.AcceptsReturn = True
        Me.txtHoldARCode.BackColor = System.Drawing.SystemColors.Window
        Me.txtHoldARCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHoldARCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "Hold-ar-code", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtHoldARCode.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoldARCode.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHoldARCode.Location = New System.Drawing.Point(136, 40)
        Me.txtHoldARCode.MaxLength = 0
        Me.txtHoldARCode.Name = "txtHoldARCode"
        Me.txtHoldARCode.ReadOnly = True
        Me.txtHoldARCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHoldARCode.Size = New System.Drawing.Size(97, 20)
        Me.txtHoldARCode.TabIndex = 82
        '
        'txtTermsCd
        '
        Me.txtTermsCd.AcceptsReturn = True
        Me.txtTermsCd.BackColor = System.Drawing.SystemColors.Window
        Me.txtTermsCd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTermsCd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "Term-code", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtTermsCd.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTermsCd.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTermsCd.Location = New System.Drawing.Point(136, 64)
        Me.txtTermsCd.MaxLength = 0
        Me.txtTermsCd.Name = "txtTermsCd"
        Me.txtTermsCd.ReadOnly = True
        Me.txtTermsCd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTermsCd.Size = New System.Drawing.Size(97, 20)
        Me.txtTermsCd.TabIndex = 81
        '
        'txtCreditReject
        '
        Me.txtCreditReject.AcceptsReturn = True
        Me.txtCreditReject.BackColor = System.Drawing.SystemColors.Window
        Me.txtCreditReject.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCreditReject.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "Credit-reject", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtCreditReject.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreditReject.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCreditReject.Location = New System.Drawing.Point(136, 88)
        Me.txtCreditReject.MaxLength = 0
        Me.txtCreditReject.Name = "txtCreditReject"
        Me.txtCreditReject.ReadOnly = True
        Me.txtCreditReject.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCreditReject.Size = New System.Drawing.Size(97, 20)
        Me.txtCreditReject.TabIndex = 80
        '
        'txtHoldShipCode
        '
        Me.txtHoldShipCode.AcceptsReturn = True
        Me.txtHoldShipCode.BackColor = System.Drawing.SystemColors.Window
        Me.txtHoldShipCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHoldShipCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "Hold-ship-code", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtHoldShipCode.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoldShipCode.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHoldShipCode.Location = New System.Drawing.Point(136, 112)
        Me.txtHoldShipCode.MaxLength = 0
        Me.txtHoldShipCode.Name = "txtHoldShipCode"
        Me.txtHoldShipCode.ReadOnly = True
        Me.txtHoldShipCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHoldShipCode.Size = New System.Drawing.Size(97, 20)
        Me.txtHoldShipCode.TabIndex = 79
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(40, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(89, 17)
        Me.Label8.TabIndex = 88
        Me.Label8.Text = "Charge to:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(32, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(97, 17)
        Me.Label9.TabIndex = 87
        Me.Label9.Text = "Hold A/R code:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(40, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(89, 17)
        Me.Label10.TabIndex = 86
        Me.Label10.Text = "Terms code:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(48, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(81, 17)
        Me.Label11.TabIndex = 85
        Me.Label11.Text = "Credit reject:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(8, 120)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(121, 17)
        Me.Label17.TabIndex = 84
        Me.Label17.Text = "Hold shipment code:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_SSTab1_TabPage1
        '
        Me._SSTab1_TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me._SSTab1_TabPage1.Controls.Add(Me.Frame8)
        Me._SSTab1_TabPage1.Controls.Add(Me.Frame7)
        Me._SSTab1_TabPage1.Controls.Add(Me.txtDept)
        Me._SSTab1_TabPage1.Controls.Add(Me.txtShipToNo)
        Me._SSTab1_TabPage1.Controls.Add(Me.txtCustNo)
        Me._SSTab1_TabPage1.Controls.Add(Me.lblPONo)
        Me._SSTab1_TabPage1.Controls.Add(Me.lblLastUpDate)
        Me._SSTab1_TabPage1.Controls.Add(Me.lblShipViaCd)
        Me._SSTab1_TabPage1.Controls.Add(Me.Label32)
        Me._SSTab1_TabPage1.Controls.Add(Me.Label31)
        Me._SSTab1_TabPage1.Controls.Add(Me.Label28)
        Me._SSTab1_TabPage1.Controls.Add(Me.Label22)
        Me._SSTab1_TabPage1.Controls.Add(Me.Label21)
        Me._SSTab1_TabPage1.Controls.Add(Me.Label5)
        Me._SSTab1_TabPage1.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage1.Name = "_SSTab1_TabPage1"
        Me._SSTab1_TabPage1.Size = New System.Drawing.Size(753, 439)
        Me._SSTab1_TabPage1.TabIndex = 1
        Me._SSTab1_TabPage1.Text = "Customer"
        '
        'Frame8
        '
        Me.Frame8.BackColor = System.Drawing.SystemColors.Control
        Me.Frame8.Controls.Add(Me.txtShipName)
        Me.Frame8.Controls.Add(Me.txtShipAddr1)
        Me.Frame8.Controls.Add(Me.txtShipAddr2)
        Me.Frame8.Controls.Add(Me.txtShipAddr3)
        Me.Frame8.Controls.Add(Me.txtShipCity)
        Me.Frame8.Controls.Add(Me.txtShipState)
        Me.Frame8.Controls.Add(Me.txtShipZip)
        Me.Frame8.Controls.Add(Me.txtShipCountry)
        Me.Frame8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame8.ForeColor = System.Drawing.Color.Blue
        Me.Frame8.Location = New System.Drawing.Point(8, 112)
        Me.Frame8.Name = "Frame8"
        Me.Frame8.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame8.Size = New System.Drawing.Size(281, 169)
        Me.Frame8.TabIndex = 45
        Me.Frame8.TabStop = False
        Me.Frame8.Text = " Address "
        '
        'txtShipName
        '
        Me.txtShipName.AcceptsReturn = True
        Me.txtShipName.BackColor = System.Drawing.SystemColors.Window
        Me.txtShipName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShipName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "ShipName", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtShipName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShipName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtShipName.Location = New System.Drawing.Point(8, 24)
        Me.txtShipName.MaxLength = 0
        Me.txtShipName.Name = "txtShipName"
        Me.txtShipName.ReadOnly = True
        Me.txtShipName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtShipName.Size = New System.Drawing.Size(265, 20)
        Me.txtShipName.TabIndex = 53
        Me.txtShipName.TabStop = False
        '
        'txtShipAddr1
        '
        Me.txtShipAddr1.AcceptsReturn = True
        Me.txtShipAddr1.BackColor = System.Drawing.SystemColors.Window
        Me.txtShipAddr1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShipAddr1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "ShipAddress1", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtShipAddr1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShipAddr1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtShipAddr1.Location = New System.Drawing.Point(8, 48)
        Me.txtShipAddr1.MaxLength = 0
        Me.txtShipAddr1.Name = "txtShipAddr1"
        Me.txtShipAddr1.ReadOnly = True
        Me.txtShipAddr1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtShipAddr1.Size = New System.Drawing.Size(265, 20)
        Me.txtShipAddr1.TabIndex = 52
        Me.txtShipAddr1.TabStop = False
        '
        'txtShipAddr2
        '
        Me.txtShipAddr2.AcceptsReturn = True
        Me.txtShipAddr2.BackColor = System.Drawing.SystemColors.Window
        Me.txtShipAddr2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShipAddr2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "ShipAddress2", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtShipAddr2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShipAddr2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtShipAddr2.Location = New System.Drawing.Point(8, 72)
        Me.txtShipAddr2.MaxLength = 0
        Me.txtShipAddr2.Name = "txtShipAddr2"
        Me.txtShipAddr2.ReadOnly = True
        Me.txtShipAddr2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtShipAddr2.Size = New System.Drawing.Size(265, 20)
        Me.txtShipAddr2.TabIndex = 51
        Me.txtShipAddr2.TabStop = False
        '
        'txtShipAddr3
        '
        Me.txtShipAddr3.AcceptsReturn = True
        Me.txtShipAddr3.BackColor = System.Drawing.SystemColors.Window
        Me.txtShipAddr3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShipAddr3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "ShipAddress3", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtShipAddr3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShipAddr3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtShipAddr3.Location = New System.Drawing.Point(8, 96)
        Me.txtShipAddr3.MaxLength = 0
        Me.txtShipAddr3.Name = "txtShipAddr3"
        Me.txtShipAddr3.ReadOnly = True
        Me.txtShipAddr3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtShipAddr3.Size = New System.Drawing.Size(265, 20)
        Me.txtShipAddr3.TabIndex = 50
        Me.txtShipAddr3.TabStop = False
        '
        'txtShipCity
        '
        Me.txtShipCity.AcceptsReturn = True
        Me.txtShipCity.BackColor = System.Drawing.SystemColors.Window
        Me.txtShipCity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShipCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "ShipCity", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtShipCity.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShipCity.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtShipCity.Location = New System.Drawing.Point(8, 120)
        Me.txtShipCity.MaxLength = 0
        Me.txtShipCity.Name = "txtShipCity"
        Me.txtShipCity.ReadOnly = True
        Me.txtShipCity.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtShipCity.Size = New System.Drawing.Size(121, 20)
        Me.txtShipCity.TabIndex = 49
        Me.txtShipCity.TabStop = False
        '
        'txtShipState
        '
        Me.txtShipState.AcceptsReturn = True
        Me.txtShipState.BackColor = System.Drawing.SystemColors.Window
        Me.txtShipState.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShipState.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "ShipState", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtShipState.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShipState.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtShipState.Location = New System.Drawing.Point(136, 120)
        Me.txtShipState.MaxLength = 0
        Me.txtShipState.Name = "txtShipState"
        Me.txtShipState.ReadOnly = True
        Me.txtShipState.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtShipState.Size = New System.Drawing.Size(33, 20)
        Me.txtShipState.TabIndex = 48
        Me.txtShipState.TabStop = False
        '
        'txtShipZip
        '
        Me.txtShipZip.AcceptsReturn = True
        Me.txtShipZip.BackColor = System.Drawing.SystemColors.Window
        Me.txtShipZip.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShipZip.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "ShipZip", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtShipZip.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShipZip.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtShipZip.Location = New System.Drawing.Point(176, 120)
        Me.txtShipZip.MaxLength = 0
        Me.txtShipZip.Name = "txtShipZip"
        Me.txtShipZip.ReadOnly = True
        Me.txtShipZip.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtShipZip.Size = New System.Drawing.Size(97, 20)
        Me.txtShipZip.TabIndex = 47
        Me.txtShipZip.TabStop = False
        '
        'txtShipCountry
        '
        Me.txtShipCountry.AcceptsReturn = True
        Me.txtShipCountry.BackColor = System.Drawing.SystemColors.Window
        Me.txtShipCountry.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShipCountry.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "ShipCountry", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtShipCountry.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShipCountry.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtShipCountry.Location = New System.Drawing.Point(152, 144)
        Me.txtShipCountry.MaxLength = 0
        Me.txtShipCountry.Name = "txtShipCountry"
        Me.txtShipCountry.ReadOnly = True
        Me.txtShipCountry.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtShipCountry.Size = New System.Drawing.Size(121, 20)
        Me.txtShipCountry.TabIndex = 46
        Me.txtShipCountry.TabStop = False
        '
        'Frame7
        '
        Me.Frame7.BackColor = System.Drawing.SystemColors.Control
        Me.Frame7.Controls.Add(Me.txtShipPhoneNo)
        Me.Frame7.Controls.Add(Me.txtShipContact)
        Me.Frame7.Controls.Add(Me.Label30)
        Me.Frame7.Controls.Add(Me.Label29)
        Me.Frame7.Controls.Add(Me.Label24)
        Me.Frame7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame7.ForeColor = System.Drawing.Color.Blue
        Me.Frame7.Location = New System.Drawing.Point(8, 288)
        Me.Frame7.Name = "Frame7"
        Me.Frame7.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame7.Size = New System.Drawing.Size(281, 81)
        Me.Frame7.TabIndex = 40
        Me.Frame7.TabStop = False
        Me.Frame7.Text = " Contact information "
        '
        'txtShipPhoneNo
        '
        Me.txtShipPhoneNo.AcceptsReturn = True
        Me.txtShipPhoneNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtShipPhoneNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShipPhoneNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "Ship-Telephone", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtShipPhoneNo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShipPhoneNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtShipPhoneNo.Location = New System.Drawing.Point(88, 21)
        Me.txtShipPhoneNo.MaxLength = 0
        Me.txtShipPhoneNo.Name = "txtShipPhoneNo"
        Me.txtShipPhoneNo.ReadOnly = True
        Me.txtShipPhoneNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtShipPhoneNo.Size = New System.Drawing.Size(169, 20)
        Me.txtShipPhoneNo.TabIndex = 42
        Me.txtShipPhoneNo.TabStop = False
        '
        'txtShipContact
        '
        Me.txtShipContact.AcceptsReturn = True
        Me.txtShipContact.BackColor = System.Drawing.SystemColors.Window
        Me.txtShipContact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShipContact.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "Ship-contact", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtShipContact.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShipContact.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtShipContact.Location = New System.Drawing.Point(88, 45)
        Me.txtShipContact.MaxLength = 0
        Me.txtShipContact.Name = "txtShipContact"
        Me.txtShipContact.ReadOnly = True
        Me.txtShipContact.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtShipContact.Size = New System.Drawing.Size(169, 20)
        Me.txtShipContact.TabIndex = 41
        Me.txtShipContact.TabStop = False
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.SystemColors.Control
        Me.Label30.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label30.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label30.Location = New System.Drawing.Point(24, 48)
        Me.Label30.Name = "Label30"
        Me.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label30.Size = New System.Drawing.Size(57, 17)
        Me.Label30.TabIndex = 54
        Me.Label30.Text = "Contact:"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.SystemColors.Control
        Me.Label29.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label29.Location = New System.Drawing.Point(8, 24)
        Me.Label29.Name = "Label29"
        Me.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label29.Size = New System.Drawing.Size(73, 17)
        Me.Label29.TabIndex = 44
        Me.Label29.Text = "Telephone:"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.SystemColors.Control
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(8, 96)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(65, 17)
        Me.Label24.TabIndex = 43
        Me.Label24.Text = "Contact:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtDept
        '
        Me.txtDept.AcceptsReturn = True
        Me.txtDept.BackColor = System.Drawing.SystemColors.Window
        Me.txtDept.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDept.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "Department", True))
        Me.txtDept.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDept.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDept.Location = New System.Drawing.Point(316, 60)
        Me.txtDept.MaxLength = 0
        Me.txtDept.Name = "txtDept"
        Me.txtDept.ReadOnly = True
        Me.txtDept.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDept.Size = New System.Drawing.Size(97, 20)
        Me.txtDept.TabIndex = 29
        '
        'txtShipToNo
        '
        Me.txtShipToNo.AcceptsReturn = True
        Me.txtShipToNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtShipToNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShipToNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "Ship-no", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtShipToNo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShipToNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtShipToNo.Location = New System.Drawing.Point(108, 60)
        Me.txtShipToNo.MaxLength = 0
        Me.txtShipToNo.Name = "txtShipToNo"
        Me.txtShipToNo.ReadOnly = True
        Me.txtShipToNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtShipToNo.Size = New System.Drawing.Size(97, 20)
        Me.txtShipToNo.TabIndex = 27
        '
        'txtCustNo
        '
        Me.txtCustNo.AcceptsReturn = True
        Me.txtCustNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtCustNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCustNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "Cust-no", True))
        Me.txtCustNo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCustNo.Location = New System.Drawing.Point(108, 36)
        Me.txtCustNo.MaxLength = 0
        Me.txtCustNo.Name = "txtCustNo"
        Me.txtCustNo.ReadOnly = True
        Me.txtCustNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCustNo.Size = New System.Drawing.Size(97, 20)
        Me.txtCustNo.TabIndex = 25
        '
        'lblPONo
        '
        Me.lblPONo.BackColor = System.Drawing.Color.White
        Me.lblPONo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPONo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPONo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "Cust-po", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.lblPONo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPONo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPONo.Location = New System.Drawing.Point(640, 64)
        Me.lblPONo.Name = "lblPONo"
        Me.lblPONo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPONo.Size = New System.Drawing.Size(97, 17)
        Me.lblPONo.TabIndex = 61
        '
        'lblLastUpDate
        '
        Me.lblLastUpDate.BackColor = System.Drawing.Color.White
        Me.lblLastUpDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLastUpDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLastUpDate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastUpDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLastUpDate.Location = New System.Drawing.Point(656, 432)
        Me.lblLastUpDate.Name = "lblLastUpDate"
        Me.lblLastUpDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLastUpDate.Size = New System.Drawing.Size(97, 17)
        Me.lblLastUpDate.TabIndex = 60
        '
        'lblShipViaCd
        '
        Me.lblShipViaCd.BackColor = System.Drawing.Color.White
        Me.lblShipViaCd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShipViaCd.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShipViaCd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndOrder, "ViaCode", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.lblShipViaCd.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShipViaCd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblShipViaCd.Location = New System.Drawing.Point(640, 40)
        Me.lblShipViaCd.Name = "lblShipViaCd"
        Me.lblShipViaCd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblShipViaCd.Size = New System.Drawing.Size(97, 17)
        Me.lblShipViaCd.TabIndex = 59
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.SystemColors.Control
        Me.Label32.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label32.Location = New System.Drawing.Point(544, 40)
        Me.Label32.Name = "Label32"
        Me.Label32.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label32.Size = New System.Drawing.Size(89, 17)
        Me.Label32.TabIndex = 58
        Me.Label32.Text = "Ship Via code:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.SystemColors.Control
        Me.Label31.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label31.Location = New System.Drawing.Point(568, 432)
        Me.Label31.Name = "Label31"
        Me.Label31.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label31.Size = New System.Drawing.Size(81, 17)
        Me.Label31.TabIndex = 57
        Me.Label31.Text = "Last Update:"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.SystemColors.Control
        Me.Label28.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.Location = New System.Drawing.Point(560, 64)
        Me.Label28.Name = "Label28"
        Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label28.Size = New System.Drawing.Size(73, 17)
        Me.Label28.TabIndex = 56
        Me.Label28.Text = "PO number:"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.Control
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(236, 68)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(73, 17)
        Me.Label22.TabIndex = 30
        Me.Label22.Text = "Department:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(44, 68)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(57, 17)
        Me.Label21.TabIndex = 28
        Me.Label21.Text = "Ship to:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(35, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(75, 17)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Customer:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_SSTab1_TabPage2
        '
        Me._SSTab1_TabPage2.AutoScroll = True
        Me._SSTab1_TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me._SSTab1_TabPage2.Controls.Add(Me.DataGridView1)
        Me._SSTab1_TabPage2.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage2.Name = "_SSTab1_TabPage2"
        Me._SSTab1_TabPage2.Size = New System.Drawing.Size(753, 439)
        Me._SSTab1_TabPage2.TabIndex = 2
        Me._SSTab1_TabPage2.Text = "Items Ordered"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrdernoDataGridViewTextBoxColumn, Me.LinenoDataGridViewTextBoxColumn, Me.ItemnoDataGridViewTextBoxColumn, Me.ItemDesc1DataGridViewTextBoxColumn, Me.ItemDesc2DataGridViewTextBoxColumn, Me.GrosspriceDataGridViewTextBoxColumn, Me.QtyorigordDataGridViewTextBoxColumn, Me.QtyshippedDataGridViewTextBoxColumn, Me.QtyopenordDataGridViewTextBoxColumn, Me.QtyallocDataGridViewTextBoxColumn, Me.QtyonppsDataGridViewTextBoxColumn, Me.RequestdateDataGridViewTextBoxColumn, Me.CommcodeDataGridViewTextBoxColumn, Me.CommrateDataGridViewTextBoxColumn, Me.ShipNameDataGridViewTextBoxColumn, Me.ShipAddr1DataGridViewTextBoxColumn, Me.ShipAddr2DataGridViewTextBoxColumn, Me.ShipAddr3DataGridViewTextBoxColumn, Me.ShipCityDataGridViewTextBoxColumn, Me.ShipStateDataGridViewTextBoxColumn, Me.ShipZipDataGridViewTextBoxColumn, Me.ShipCountryDataGridViewTextBoxColumn, Me.LastppsDataGridViewTextBoxColumn, Me.LastinvnoDataGridViewTextBoxColumn, Me.OrdercodeDataGridViewTextBoxColumn, Me.CustShipCdDataGridViewTextBoxColumn, Me.ExtPriceDataGridViewTextBoxColumn, Me.TagmemoDataGridViewTextBoxColumn, Me.CompletedateDataGridViewTextBoxColumn, Me.CutbackqtyDataGridViewTextBoxColumn, Me.CutbackstatusDataGridViewTextBoxColumn, Me.CutbackdateDataGridViewTextBoxColumn, Me.OrderdateDataGridViewTextBoxColumn, Me.LastUpdatedDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.bndOrderLine
        Me.DataGridView1.Location = New System.Drawing.Point(10, 17)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(738, 411)
        Me.DataGridView1.TabIndex = 0
        '
        'OrdernoDataGridViewTextBoxColumn
        '
        Me.OrdernoDataGridViewTextBoxColumn.DataPropertyName = "Order-no"
        Me.OrdernoDataGridViewTextBoxColumn.HeaderText = "Order-no"
        Me.OrdernoDataGridViewTextBoxColumn.Name = "OrdernoDataGridViewTextBoxColumn"
        Me.OrdernoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LinenoDataGridViewTextBoxColumn
        '
        Me.LinenoDataGridViewTextBoxColumn.DataPropertyName = "Line-no"
        Me.LinenoDataGridViewTextBoxColumn.HeaderText = "Line-no"
        Me.LinenoDataGridViewTextBoxColumn.Name = "LinenoDataGridViewTextBoxColumn"
        Me.LinenoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemnoDataGridViewTextBoxColumn
        '
        Me.ItemnoDataGridViewTextBoxColumn.DataPropertyName = "Item-no"
        Me.ItemnoDataGridViewTextBoxColumn.HeaderText = "Item-no"
        Me.ItemnoDataGridViewTextBoxColumn.Name = "ItemnoDataGridViewTextBoxColumn"
        Me.ItemnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemDesc1DataGridViewTextBoxColumn
        '
        Me.ItemDesc1DataGridViewTextBoxColumn.DataPropertyName = "ItemDesc1"
        Me.ItemDesc1DataGridViewTextBoxColumn.HeaderText = "ItemDesc1"
        Me.ItemDesc1DataGridViewTextBoxColumn.Name = "ItemDesc1DataGridViewTextBoxColumn"
        Me.ItemDesc1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemDesc2DataGridViewTextBoxColumn
        '
        Me.ItemDesc2DataGridViewTextBoxColumn.DataPropertyName = "ItemDesc2"
        Me.ItemDesc2DataGridViewTextBoxColumn.HeaderText = "ItemDesc2"
        Me.ItemDesc2DataGridViewTextBoxColumn.Name = "ItemDesc2DataGridViewTextBoxColumn"
        Me.ItemDesc2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'GrosspriceDataGridViewTextBoxColumn
        '
        Me.GrosspriceDataGridViewTextBoxColumn.DataPropertyName = "Gross-price"
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.GrosspriceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.GrosspriceDataGridViewTextBoxColumn.HeaderText = "Gross-price"
        Me.GrosspriceDataGridViewTextBoxColumn.Name = "GrosspriceDataGridViewTextBoxColumn"
        Me.GrosspriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QtyorigordDataGridViewTextBoxColumn
        '
        Me.QtyorigordDataGridViewTextBoxColumn.DataPropertyName = "Qty-orig-ord"
        Me.QtyorigordDataGridViewTextBoxColumn.HeaderText = "Qty-orig-ord"
        Me.QtyorigordDataGridViewTextBoxColumn.Name = "QtyorigordDataGridViewTextBoxColumn"
        Me.QtyorigordDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QtyshippedDataGridViewTextBoxColumn
        '
        Me.QtyshippedDataGridViewTextBoxColumn.DataPropertyName = "Qty-shipped"
        Me.QtyshippedDataGridViewTextBoxColumn.HeaderText = "Qty-shipped"
        Me.QtyshippedDataGridViewTextBoxColumn.Name = "QtyshippedDataGridViewTextBoxColumn"
        Me.QtyshippedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QtyopenordDataGridViewTextBoxColumn
        '
        Me.QtyopenordDataGridViewTextBoxColumn.DataPropertyName = "Qty-open-ord"
        Me.QtyopenordDataGridViewTextBoxColumn.HeaderText = "Qty-open-ord"
        Me.QtyopenordDataGridViewTextBoxColumn.Name = "QtyopenordDataGridViewTextBoxColumn"
        Me.QtyopenordDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QtyallocDataGridViewTextBoxColumn
        '
        Me.QtyallocDataGridViewTextBoxColumn.DataPropertyName = "Qty-alloc"
        Me.QtyallocDataGridViewTextBoxColumn.HeaderText = "Qty-alloc"
        Me.QtyallocDataGridViewTextBoxColumn.Name = "QtyallocDataGridViewTextBoxColumn"
        Me.QtyallocDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QtyonppsDataGridViewTextBoxColumn
        '
        Me.QtyonppsDataGridViewTextBoxColumn.DataPropertyName = "Qty-on-pps"
        Me.QtyonppsDataGridViewTextBoxColumn.HeaderText = "Qty-on-pps"
        Me.QtyonppsDataGridViewTextBoxColumn.Name = "QtyonppsDataGridViewTextBoxColumn"
        Me.QtyonppsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RequestdateDataGridViewTextBoxColumn
        '
        Me.RequestdateDataGridViewTextBoxColumn.DataPropertyName = "Requestdate"
        Me.RequestdateDataGridViewTextBoxColumn.HeaderText = "Requestdate"
        Me.RequestdateDataGridViewTextBoxColumn.Name = "RequestdateDataGridViewTextBoxColumn"
        Me.RequestdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CommcodeDataGridViewTextBoxColumn
        '
        Me.CommcodeDataGridViewTextBoxColumn.DataPropertyName = "Comm-code"
        Me.CommcodeDataGridViewTextBoxColumn.HeaderText = "Comm-code"
        Me.CommcodeDataGridViewTextBoxColumn.Name = "CommcodeDataGridViewTextBoxColumn"
        Me.CommcodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CommrateDataGridViewTextBoxColumn
        '
        Me.CommrateDataGridViewTextBoxColumn.DataPropertyName = "Comm-rate"
        Me.CommrateDataGridViewTextBoxColumn.HeaderText = "Comm-rate"
        Me.CommrateDataGridViewTextBoxColumn.Name = "CommrateDataGridViewTextBoxColumn"
        Me.CommrateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ShipNameDataGridViewTextBoxColumn
        '
        Me.ShipNameDataGridViewTextBoxColumn.DataPropertyName = "ShipName"
        Me.ShipNameDataGridViewTextBoxColumn.HeaderText = "ShipName"
        Me.ShipNameDataGridViewTextBoxColumn.Name = "ShipNameDataGridViewTextBoxColumn"
        Me.ShipNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ShipAddr1DataGridViewTextBoxColumn
        '
        Me.ShipAddr1DataGridViewTextBoxColumn.DataPropertyName = "ShipAddr1"
        Me.ShipAddr1DataGridViewTextBoxColumn.HeaderText = "ShipAddr1"
        Me.ShipAddr1DataGridViewTextBoxColumn.Name = "ShipAddr1DataGridViewTextBoxColumn"
        Me.ShipAddr1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'ShipAddr2DataGridViewTextBoxColumn
        '
        Me.ShipAddr2DataGridViewTextBoxColumn.DataPropertyName = "ShipAddr2"
        Me.ShipAddr2DataGridViewTextBoxColumn.HeaderText = "ShipAddr2"
        Me.ShipAddr2DataGridViewTextBoxColumn.Name = "ShipAddr2DataGridViewTextBoxColumn"
        Me.ShipAddr2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'ShipAddr3DataGridViewTextBoxColumn
        '
        Me.ShipAddr3DataGridViewTextBoxColumn.DataPropertyName = "ShipAddr3"
        Me.ShipAddr3DataGridViewTextBoxColumn.HeaderText = "ShipAddr3"
        Me.ShipAddr3DataGridViewTextBoxColumn.Name = "ShipAddr3DataGridViewTextBoxColumn"
        Me.ShipAddr3DataGridViewTextBoxColumn.ReadOnly = True
        '
        'ShipCityDataGridViewTextBoxColumn
        '
        Me.ShipCityDataGridViewTextBoxColumn.DataPropertyName = "ShipCity"
        Me.ShipCityDataGridViewTextBoxColumn.HeaderText = "ShipCity"
        Me.ShipCityDataGridViewTextBoxColumn.Name = "ShipCityDataGridViewTextBoxColumn"
        Me.ShipCityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ShipStateDataGridViewTextBoxColumn
        '
        Me.ShipStateDataGridViewTextBoxColumn.DataPropertyName = "ShipState"
        Me.ShipStateDataGridViewTextBoxColumn.HeaderText = "ShipState"
        Me.ShipStateDataGridViewTextBoxColumn.Name = "ShipStateDataGridViewTextBoxColumn"
        Me.ShipStateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ShipZipDataGridViewTextBoxColumn
        '
        Me.ShipZipDataGridViewTextBoxColumn.DataPropertyName = "ShipZip"
        Me.ShipZipDataGridViewTextBoxColumn.HeaderText = "ShipZip"
        Me.ShipZipDataGridViewTextBoxColumn.Name = "ShipZipDataGridViewTextBoxColumn"
        Me.ShipZipDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ShipCountryDataGridViewTextBoxColumn
        '
        Me.ShipCountryDataGridViewTextBoxColumn.DataPropertyName = "ShipCountry"
        Me.ShipCountryDataGridViewTextBoxColumn.HeaderText = "ShipCountry"
        Me.ShipCountryDataGridViewTextBoxColumn.Name = "ShipCountryDataGridViewTextBoxColumn"
        Me.ShipCountryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastppsDataGridViewTextBoxColumn
        '
        Me.LastppsDataGridViewTextBoxColumn.DataPropertyName = "Last-pps"
        Me.LastppsDataGridViewTextBoxColumn.HeaderText = "Last-pps"
        Me.LastppsDataGridViewTextBoxColumn.Name = "LastppsDataGridViewTextBoxColumn"
        Me.LastppsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastinvnoDataGridViewTextBoxColumn
        '
        Me.LastinvnoDataGridViewTextBoxColumn.DataPropertyName = "Last-inv-no"
        Me.LastinvnoDataGridViewTextBoxColumn.HeaderText = "Last-inv-no"
        Me.LastinvnoDataGridViewTextBoxColumn.Name = "LastinvnoDataGridViewTextBoxColumn"
        Me.LastinvnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OrdercodeDataGridViewTextBoxColumn
        '
        Me.OrdercodeDataGridViewTextBoxColumn.DataPropertyName = "Order-code"
        Me.OrdercodeDataGridViewTextBoxColumn.HeaderText = "Order-code"
        Me.OrdercodeDataGridViewTextBoxColumn.Name = "OrdercodeDataGridViewTextBoxColumn"
        Me.OrdercodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustShipCdDataGridViewTextBoxColumn
        '
        Me.CustShipCdDataGridViewTextBoxColumn.DataPropertyName = "CustShipCd"
        Me.CustShipCdDataGridViewTextBoxColumn.HeaderText = "CustShipCd"
        Me.CustShipCdDataGridViewTextBoxColumn.Name = "CustShipCdDataGridViewTextBoxColumn"
        Me.CustShipCdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ExtPriceDataGridViewTextBoxColumn
        '
        Me.ExtPriceDataGridViewTextBoxColumn.DataPropertyName = "Ext-Price"
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.ExtPriceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.ExtPriceDataGridViewTextBoxColumn.HeaderText = "Ext-Price"
        Me.ExtPriceDataGridViewTextBoxColumn.Name = "ExtPriceDataGridViewTextBoxColumn"
        Me.ExtPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TagmemoDataGridViewTextBoxColumn
        '
        Me.TagmemoDataGridViewTextBoxColumn.DataPropertyName = "Tag-memo"
        Me.TagmemoDataGridViewTextBoxColumn.HeaderText = "Tag-memo"
        Me.TagmemoDataGridViewTextBoxColumn.Name = "TagmemoDataGridViewTextBoxColumn"
        Me.TagmemoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CompletedateDataGridViewTextBoxColumn
        '
        Me.CompletedateDataGridViewTextBoxColumn.DataPropertyName = "Complete-date"
        Me.CompletedateDataGridViewTextBoxColumn.HeaderText = "Complete-date"
        Me.CompletedateDataGridViewTextBoxColumn.Name = "CompletedateDataGridViewTextBoxColumn"
        Me.CompletedateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CutbackqtyDataGridViewTextBoxColumn
        '
        Me.CutbackqtyDataGridViewTextBoxColumn.DataPropertyName = "Cut-back-qty"
        Me.CutbackqtyDataGridViewTextBoxColumn.HeaderText = "Cut-back-qty"
        Me.CutbackqtyDataGridViewTextBoxColumn.Name = "CutbackqtyDataGridViewTextBoxColumn"
        Me.CutbackqtyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CutbackstatusDataGridViewTextBoxColumn
        '
        Me.CutbackstatusDataGridViewTextBoxColumn.DataPropertyName = "Cut-back-status"
        Me.CutbackstatusDataGridViewTextBoxColumn.HeaderText = "Cut-back-status"
        Me.CutbackstatusDataGridViewTextBoxColumn.Name = "CutbackstatusDataGridViewTextBoxColumn"
        Me.CutbackstatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CutbackdateDataGridViewTextBoxColumn
        '
        Me.CutbackdateDataGridViewTextBoxColumn.DataPropertyName = "Cut-back-date"
        Me.CutbackdateDataGridViewTextBoxColumn.HeaderText = "Cut-back-date"
        Me.CutbackdateDataGridViewTextBoxColumn.Name = "CutbackdateDataGridViewTextBoxColumn"
        Me.CutbackdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OrderdateDataGridViewTextBoxColumn
        '
        Me.OrderdateDataGridViewTextBoxColumn.DataPropertyName = "Order-date"
        Me.OrderdateDataGridViewTextBoxColumn.HeaderText = "Order-date"
        Me.OrderdateDataGridViewTextBoxColumn.Name = "OrderdateDataGridViewTextBoxColumn"
        Me.OrderdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastUpdatedDataGridViewTextBoxColumn
        '
        Me.LastUpdatedDataGridViewTextBoxColumn.DataPropertyName = "LastUpdated"
        Me.LastUpdatedDataGridViewTextBoxColumn.HeaderText = "LastUpdated"
        Me.LastUpdatedDataGridViewTextBoxColumn.Name = "LastUpdatedDataGridViewTextBoxColumn"
        Me.LastUpdatedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'bndOrderLine
        '
        Me.bndOrderLine.DataMember = "Order-line"
        Me.bndOrderLine.DataSource = Me.SaleForcDataSet
        '
        'OrderTableAdapter
        '
        Me.OrderTableAdapter.ClearBeforeFill = True
        '
        'Order_lineTableAdapter
        '
        Me.Order_lineTableAdapter.ClearBeforeFill = True
        '
        'frmOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(787, 538)
        Me.ControlBox = False
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.SSTab1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 25)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOrders"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orders"
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        CType(Me.bndOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleForcDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SSTab1.ResumeLayout(False)
        Me._SSTab1_TabPage0.ResumeLayout(False)
        Me.Frame5.ResumeLayout(False)
        Me.Frame5.PerformLayout()
        Me.Frame6.ResumeLayout(False)
        Me.Frame6.PerformLayout()
        Me.Frame4.ResumeLayout(False)
        Me.Frame4.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me._SSTab1_TabPage1.ResumeLayout(False)
        Me._SSTab1_TabPage1.PerformLayout()
        Me.Frame8.ResumeLayout(False)
        Me.Frame8.PerformLayout()
        Me.Frame7.ResumeLayout(False)
        Me.Frame7.PerformLayout()
        Me._SSTab1_TabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndOrderLine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
#Region "Upgrade Support"
    Friend WithEvents bndOrder As System.Windows.Forms.BindingSource
    Friend WithEvents SaleForcDataSet As KC01.SaleForcDataSet
    Friend WithEvents OrderTableAdapter As KC01.SaleForcDataSetTableAdapters.OrderTableAdapter
    Friend WithEvents bndOrderLine As System.Windows.Forms.BindingSource
    Friend WithEvents Order_lineTableAdapter As KC01.SaleForcDataSetTableAdapters.Order_lineTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents OrdernoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LinenoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemDesc1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemDesc2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GrosspriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyorigordDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyshippedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyopenordDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyallocDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyonppsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RequestdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommcodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommrateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShipNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShipAddr1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShipAddr2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShipAddr3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShipCityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShipStateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShipZipDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShipCountryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastppsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastinvnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrdercodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustShipCdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExtPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TagmemoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompletedateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CutbackqtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CutbackstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CutbackdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastUpdatedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
#End Region
End Class