<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSalesPerson
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
	Private ADOBind_adoSalesmanInfo As VB6.MBindingCollection
    Public WithEvents lblTerms As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents lblShipViaDesc As System.Windows.Forms.Label
	Public WithEvents lblShipVia As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents lblOrdCdDesc As System.Windows.Forms.Label
	Public WithEvents lblSeasonDesc As System.Windows.Forms.Label
	Public WithEvents Label16 As System.Windows.Forms.Label
	Public WithEvents Label15 As System.Windows.Forms.Label
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents delComplDate As System.Windows.Forms.Label
	Public WithEvents lblDelvByDate As System.Windows.Forms.Label
	Public WithEvents lblOrderCode As System.Windows.Forms.Label
	Public WithEvents lblSeason As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents cmdChgWSDefaults As System.Windows.Forms.Button
	Public WithEvents cmdExit As System.Windows.Forms.Button
	Public WithEvents Frame4 As System.Windows.Forms.GroupBox
	Public WithEvents Label34 As System.Windows.Forms.Label
	Public WithEvents Label33 As System.Windows.Forms.Label
	Public WithEvents Label32 As System.Windows.Forms.Label
	Public WithEvents Label31 As System.Windows.Forms.Label
	Public WithEvents Label30 As System.Windows.Forms.Label
	Public WithEvents Label29 As System.Windows.Forms.Label
	Public WithEvents Label28 As System.Windows.Forms.Label
	Public WithEvents Label27 As System.Windows.Forms.Label
	Public WithEvents lblLastUpdte As System.Windows.Forms.Label
	Public WithEvents lblToCancelDate As System.Windows.Forms.Label
	Public WithEvents lblFromCancelDate As System.Windows.Forms.Label
	Public WithEvents LbllToComplDate As System.Windows.Forms.Label
	Public WithEvents LblFromComplDate As System.Windows.Forms.Label
	Public WithEvents lblToReqDate As System.Windows.Forms.Label
	Public WithEvents lblFromReqDate As System.Windows.Forms.Label
	Public WithEvents lblExpNo As System.Windows.Forms.Label
	Public WithEvents lblWsNo As System.Windows.Forms.Label
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents lblZipCode As System.Windows.Forms.Label
	Public WithEvents lblState As System.Windows.Forms.Label
	Public WithEvents lblCity As System.Windows.Forms.Label
	Public WithEvents lblAddr3 As System.Windows.Forms.Label
	Public WithEvents lblAddr2 As System.Windows.Forms.Label
	Public WithEvents lblAddr1 As System.Windows.Forms.Label
	Public WithEvents lblName As System.Windows.Forms.Label
	Public WithEvents lblSlsmnCode As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me.lblTerms = New System.Windows.Forms.Label
        Me.bndSalesman = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaleForcDataSet = New KC01.SaleForcDataSet
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblShipViaDesc = New System.Windows.Forms.Label
        Me.lblShipVia = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblOrdCdDesc = New System.Windows.Forms.Label
        Me.lblSeasonDesc = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.delComplDate = New System.Windows.Forms.Label
        Me.lblDelvByDate = New System.Windows.Forms.Label
        Me.lblOrderCode = New System.Windows.Forms.Label
        Me.lblSeason = New System.Windows.Forms.Label
        Me.Frame4 = New System.Windows.Forms.GroupBox
        Me.cmdChgWSDefaults = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.Frame3 = New System.Windows.Forms.GroupBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.lblLastUpdte = New System.Windows.Forms.Label
        Me.lblToCancelDate = New System.Windows.Forms.Label
        Me.lblFromCancelDate = New System.Windows.Forms.Label
        Me.LbllToComplDate = New System.Windows.Forms.Label
        Me.LblFromComplDate = New System.Windows.Forms.Label
        Me.lblToReqDate = New System.Windows.Forms.Label
        Me.lblFromReqDate = New System.Windows.Forms.Label
        Me.lblExpNo = New System.Windows.Forms.Label
        Me.lblWsNo = New System.Windows.Forms.Label
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.lblZipCode = New System.Windows.Forms.Label
        Me.lblState = New System.Windows.Forms.Label
        Me.lblCity = New System.Windows.Forms.Label
        Me.lblAddr3 = New System.Windows.Forms.Label
        Me.lblAddr2 = New System.Windows.Forms.Label
        Me.lblAddr1 = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.lblSlsmnCode = New System.Windows.Forms.Label
        Me.SalesmanTableAdapter = New KC01.SaleForcDataSetTableAdapters.SalesmanTableAdapter
        Me.Frame2.SuspendLayout()
        CType(Me.bndSalesman, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleForcDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame4.SuspendLayout()
        Me.Frame3.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.lblTerms)
        Me.Frame2.Controls.Add(Me.Label2)
        Me.Frame2.Controls.Add(Me.lblShipViaDesc)
        Me.Frame2.Controls.Add(Me.lblShipVia)
        Me.Frame2.Controls.Add(Me.Label1)
        Me.Frame2.Controls.Add(Me.lblOrdCdDesc)
        Me.Frame2.Controls.Add(Me.lblSeasonDesc)
        Me.Frame2.Controls.Add(Me.Label16)
        Me.Frame2.Controls.Add(Me.Label15)
        Me.Frame2.Controls.Add(Me.Label14)
        Me.Frame2.Controls.Add(Me.Label13)
        Me.Frame2.Controls.Add(Me.delComplDate)
        Me.Frame2.Controls.Add(Me.lblDelvByDate)
        Me.Frame2.Controls.Add(Me.lblOrderCode)
        Me.Frame2.Controls.Add(Me.lblSeason)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.Color.Blue
        Me.Frame2.Location = New System.Drawing.Point(0, 336)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(641, 129)
        Me.Frame2.TabIndex = 9
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "WORKSHEET DEFAULTS"
        '
        'lblTerms
        '
        Me.lblTerms.BackColor = System.Drawing.SystemColors.Control
        Me.lblTerms.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTerms.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndSalesman, "TermCode", True))
        Me.lblTerms.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTerms.ForeColor = System.Drawing.Color.Blue
        Me.lblTerms.Location = New System.Drawing.Point(208, 88)
        Me.lblTerms.Name = "lblTerms"
        Me.lblTerms.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTerms.Size = New System.Drawing.Size(185, 17)
        Me.lblTerms.TabIndex = 45
        '
        'bndSalesman
        '
        Me.bndSalesman.AllowNew = True
        Me.bndSalesman.DataMember = "Salesman"
        Me.bndSalesman.DataSource = Me.SaleForcDataSet
        '
        'SaleForcDataSet
        '
        Me.SaleForcDataSet.DataSetName = "SaleForcDataSet"
        Me.SaleForcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(40, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Terms:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblShipViaDesc
        '
        Me.lblShipViaDesc.BackColor = System.Drawing.SystemColors.Control
        Me.lblShipViaDesc.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShipViaDesc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShipViaDesc.ForeColor = System.Drawing.Color.Blue
        Me.lblShipViaDesc.Location = New System.Drawing.Point(208, 64)
        Me.lblShipViaDesc.Name = "lblShipViaDesc"
        Me.lblShipViaDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblShipViaDesc.Size = New System.Drawing.Size(185, 17)
        Me.lblShipViaDesc.TabIndex = 43
        '
        'lblShipVia
        '
        Me.lblShipVia.BackColor = System.Drawing.SystemColors.Control
        Me.lblShipVia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShipVia.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShipVia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndSalesman, "ViaCode", True))
        Me.lblShipVia.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShipVia.ForeColor = System.Drawing.Color.Blue
        Me.lblShipVia.Location = New System.Drawing.Point(120, 64)
        Me.lblShipVia.Name = "lblShipVia"
        Me.lblShipVia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblShipVia.Size = New System.Drawing.Size(73, 17)
        Me.lblShipVia.TabIndex = 42
        Me.lblShipVia.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(40, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Ship Via:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblOrdCdDesc
        '
        Me.lblOrdCdDesc.BackColor = System.Drawing.SystemColors.Control
        Me.lblOrdCdDesc.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblOrdCdDesc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrdCdDesc.ForeColor = System.Drawing.Color.Blue
        Me.lblOrdCdDesc.Location = New System.Drawing.Point(208, 40)
        Me.lblOrdCdDesc.Name = "lblOrdCdDesc"
        Me.lblOrdCdDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOrdCdDesc.Size = New System.Drawing.Size(185, 17)
        Me.lblOrdCdDesc.TabIndex = 40
        '
        'lblSeasonDesc
        '
        Me.lblSeasonDesc.BackColor = System.Drawing.SystemColors.Control
        Me.lblSeasonDesc.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSeasonDesc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeasonDesc.ForeColor = System.Drawing.Color.Blue
        Me.lblSeasonDesc.Location = New System.Drawing.Point(208, 16)
        Me.lblSeasonDesc.Name = "lblSeasonDesc"
        Me.lblSeasonDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSeasonDesc.Size = New System.Drawing.Size(185, 17)
        Me.lblSeasonDesc.TabIndex = 39
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(432, 40)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(97, 17)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "Complete date:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(424, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(105, 17)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Deliver order by:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(40, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(73, 17)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Order code:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(56, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(57, 17)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Season:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'delComplDate
        '
        Me.delComplDate.BackColor = System.Drawing.SystemColors.Control
        Me.delComplDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.delComplDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.delComplDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndSalesman, "cancel-date", True))
        Me.delComplDate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delComplDate.ForeColor = System.Drawing.Color.Blue
        Me.delComplDate.Location = New System.Drawing.Point(536, 40)
        Me.delComplDate.Name = "delComplDate"
        Me.delComplDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.delComplDate.Size = New System.Drawing.Size(73, 17)
        Me.delComplDate.TabIndex = 13
        Me.delComplDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDelvByDate
        '
        Me.lblDelvByDate.BackColor = System.Drawing.SystemColors.Control
        Me.lblDelvByDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDelvByDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDelvByDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndSalesman, "request-date", True))
        Me.lblDelvByDate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDelvByDate.ForeColor = System.Drawing.Color.Blue
        Me.lblDelvByDate.Location = New System.Drawing.Point(536, 16)
        Me.lblDelvByDate.Name = "lblDelvByDate"
        Me.lblDelvByDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDelvByDate.Size = New System.Drawing.Size(73, 17)
        Me.lblDelvByDate.TabIndex = 12
        Me.lblDelvByDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblOrderCode
        '
        Me.lblOrderCode.BackColor = System.Drawing.SystemColors.Control
        Me.lblOrderCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOrderCode.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblOrderCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndSalesman, "order-code", True))
        Me.lblOrderCode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderCode.ForeColor = System.Drawing.Color.Blue
        Me.lblOrderCode.Location = New System.Drawing.Point(120, 40)
        Me.lblOrderCode.Name = "lblOrderCode"
        Me.lblOrderCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOrderCode.Size = New System.Drawing.Size(73, 17)
        Me.lblOrderCode.TabIndex = 11
        Me.lblOrderCode.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSeason
        '
        Me.lblSeason.BackColor = System.Drawing.SystemColors.Control
        Me.lblSeason.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSeason.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSeason.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndSalesman, "season", True))
        Me.lblSeason.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeason.ForeColor = System.Drawing.Color.Blue
        Me.lblSeason.Location = New System.Drawing.Point(120, 16)
        Me.lblSeason.Name = "lblSeason"
        Me.lblSeason.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSeason.Size = New System.Drawing.Size(73, 17)
        Me.lblSeason.TabIndex = 10
        Me.lblSeason.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frame4
        '
        Me.Frame4.BackColor = System.Drawing.SystemColors.Control
        Me.Frame4.Controls.Add(Me.cmdChgWSDefaults)
        Me.Frame4.Controls.Add(Me.cmdExit)
        Me.Frame4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame4.Location = New System.Drawing.Point(0, 0)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame4.Size = New System.Drawing.Size(641, 49)
        Me.Frame4.TabIndex = 36
        Me.Frame4.TabStop = False
        '
        'cmdChgWSDefaults
        '
        Me.cmdChgWSDefaults.BackColor = System.Drawing.SystemColors.Control
        Me.cmdChgWSDefaults.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdChgWSDefaults.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdChgWSDefaults.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdChgWSDefaults.Location = New System.Drawing.Point(80, 16)
        Me.cmdChgWSDefaults.Name = "cmdChgWSDefaults"
        Me.cmdChgWSDefaults.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdChgWSDefaults.Size = New System.Drawing.Size(177, 25)
        Me.cmdChgWSDefaults.TabIndex = 38
        Me.cmdChgWSDefaults.Text = "&Change Worksheet Defaults"
        Me.cmdChgWSDefaults.UseVisualStyleBackColor = False
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdExit.Location = New System.Drawing.Point(8, 16)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExit.Size = New System.Drawing.Size(65, 25)
        Me.cmdExit.TabIndex = 37
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.Label34)
        Me.Frame3.Controls.Add(Me.Label33)
        Me.Frame3.Controls.Add(Me.Label32)
        Me.Frame3.Controls.Add(Me.Label31)
        Me.Frame3.Controls.Add(Me.Label30)
        Me.Frame3.Controls.Add(Me.Label29)
        Me.Frame3.Controls.Add(Me.Label28)
        Me.Frame3.Controls.Add(Me.Label27)
        Me.Frame3.Controls.Add(Me.lblLastUpdte)
        Me.Frame3.Controls.Add(Me.lblToCancelDate)
        Me.Frame3.Controls.Add(Me.lblFromCancelDate)
        Me.Frame3.Controls.Add(Me.LbllToComplDate)
        Me.Frame3.Controls.Add(Me.LblFromComplDate)
        Me.Frame3.Controls.Add(Me.lblToReqDate)
        Me.Frame3.Controls.Add(Me.lblFromReqDate)
        Me.Frame3.Controls.Add(Me.lblExpNo)
        Me.Frame3.Controls.Add(Me.lblWsNo)
        Me.Frame3.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.Color.Blue
        Me.Frame3.Location = New System.Drawing.Point(344, 64)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(273, 249)
        Me.Frame3.TabIndex = 18
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "PROGRAM REFERENCE DATA"
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.SystemColors.Control
        Me.Label34.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label34.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Red
        Me.Label34.Location = New System.Drawing.Point(24, 176)
        Me.Label34.Name = "Label34"
        Me.Label34.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label34.Size = New System.Drawing.Size(57, 17)
        Me.Label34.TabIndex = 35
        Me.Label34.Text = "Cancel"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.SystemColors.Control
        Me.Label33.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label33.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Red
        Me.Label33.Location = New System.Drawing.Point(19, 152)
        Me.Label33.Name = "Label33"
        Me.Label33.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label33.Size = New System.Drawing.Size(62, 17)
        Me.Label33.TabIndex = 34
        Me.Label33.Text = "Complete"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.SystemColors.Control
        Me.Label32.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Red
        Me.Label32.Location = New System.Drawing.Point(24, 128)
        Me.Label32.Name = "Label32"
        Me.Label32.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label32.Size = New System.Drawing.Size(57, 17)
        Me.Label32.TabIndex = 33
        Me.Label32.Text = "Request"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.SystemColors.Control
        Me.Label31.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Red
        Me.Label31.Location = New System.Drawing.Point(184, 104)
        Me.Label31.Name = "Label31"
        Me.Label31.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label31.Size = New System.Drawing.Size(57, 17)
        Me.Label31.TabIndex = 32
        Me.Label31.Text = "To"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.SystemColors.Control
        Me.Label30.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label30.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Red
        Me.Label30.Location = New System.Drawing.Point(96, 104)
        Me.Label30.Name = "Label30"
        Me.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label30.Size = New System.Drawing.Size(57, 17)
        Me.Label30.TabIndex = 31
        Me.Label30.Text = "From"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.SystemColors.Control
        Me.Label29.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Red
        Me.Label29.Location = New System.Drawing.Point(24, 224)
        Me.Label29.Name = "Label29"
        Me.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label29.Size = New System.Drawing.Size(105, 17)
        Me.Label29.TabIndex = 30
        Me.Label29.Text = "Last updated:"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.SystemColors.Control
        Me.Label28.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Red
        Me.Label28.Location = New System.Drawing.Point(24, 48)
        Me.Label28.Name = "Label28"
        Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label28.Size = New System.Drawing.Size(113, 17)
        Me.Label28.TabIndex = 29
        Me.Label28.Text = "Export number:"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.SystemColors.Control
        Me.Label27.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label27.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Red
        Me.Label27.Location = New System.Drawing.Point(16, 24)
        Me.Label27.Name = "Label27"
        Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label27.Size = New System.Drawing.Size(121, 17)
        Me.Label27.TabIndex = 28
        Me.Label27.Text = "Worksheet number:"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblLastUpdte
        '
        Me.lblLastUpdte.BackColor = System.Drawing.SystemColors.Control
        Me.lblLastUpdte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLastUpdte.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLastUpdte.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndSalesman, "LastUpdated", True))
        Me.lblLastUpdte.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastUpdte.ForeColor = System.Drawing.Color.Blue
        Me.lblLastUpdte.Location = New System.Drawing.Point(144, 224)
        Me.lblLastUpdte.Name = "lblLastUpdte"
        Me.lblLastUpdte.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLastUpdte.Size = New System.Drawing.Size(81, 17)
        Me.lblLastUpdte.TabIndex = 27
        Me.lblLastUpdte.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblToCancelDate
        '
        Me.lblToCancelDate.BackColor = System.Drawing.SystemColors.Control
        Me.lblToCancelDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblToCancelDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblToCancelDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndSalesman, "To-cancel-date", True))
        Me.lblToCancelDate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToCancelDate.ForeColor = System.Drawing.Color.Blue
        Me.lblToCancelDate.Location = New System.Drawing.Point(176, 176)
        Me.lblToCancelDate.Name = "lblToCancelDate"
        Me.lblToCancelDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblToCancelDate.Size = New System.Drawing.Size(81, 17)
        Me.lblToCancelDate.TabIndex = 26
        Me.lblToCancelDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblFromCancelDate
        '
        Me.lblFromCancelDate.BackColor = System.Drawing.SystemColors.Control
        Me.lblFromCancelDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFromCancelDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFromCancelDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndSalesman, "From-cancel-date", True))
        Me.lblFromCancelDate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFromCancelDate.ForeColor = System.Drawing.Color.Blue
        Me.lblFromCancelDate.Location = New System.Drawing.Point(88, 176)
        Me.lblFromCancelDate.Name = "lblFromCancelDate"
        Me.lblFromCancelDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFromCancelDate.Size = New System.Drawing.Size(81, 17)
        Me.lblFromCancelDate.TabIndex = 25
        Me.lblFromCancelDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LbllToComplDate
        '
        Me.LbllToComplDate.BackColor = System.Drawing.SystemColors.Control
        Me.LbllToComplDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LbllToComplDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.LbllToComplDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndSalesman, "To-complete-date", True))
        Me.LbllToComplDate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbllToComplDate.ForeColor = System.Drawing.Color.Blue
        Me.LbllToComplDate.Location = New System.Drawing.Point(176, 152)
        Me.LbllToComplDate.Name = "LbllToComplDate"
        Me.LbllToComplDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LbllToComplDate.Size = New System.Drawing.Size(81, 17)
        Me.LbllToComplDate.TabIndex = 24
        Me.LbllToComplDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblFromComplDate
        '
        Me.LblFromComplDate.BackColor = System.Drawing.SystemColors.Control
        Me.LblFromComplDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblFromComplDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblFromComplDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndSalesman, "From-complete-date", True))
        Me.LblFromComplDate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFromComplDate.ForeColor = System.Drawing.Color.Blue
        Me.LblFromComplDate.Location = New System.Drawing.Point(88, 152)
        Me.LblFromComplDate.Name = "LblFromComplDate"
        Me.LblFromComplDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblFromComplDate.Size = New System.Drawing.Size(81, 17)
        Me.LblFromComplDate.TabIndex = 23
        Me.LblFromComplDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblToReqDate
        '
        Me.lblToReqDate.BackColor = System.Drawing.SystemColors.Control
        Me.lblToReqDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblToReqDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblToReqDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndSalesman, "To-request-date", True))
        Me.lblToReqDate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToReqDate.ForeColor = System.Drawing.Color.Blue
        Me.lblToReqDate.Location = New System.Drawing.Point(176, 128)
        Me.lblToReqDate.Name = "lblToReqDate"
        Me.lblToReqDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblToReqDate.Size = New System.Drawing.Size(81, 17)
        Me.lblToReqDate.TabIndex = 22
        Me.lblToReqDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblFromReqDate
        '
        Me.lblFromReqDate.BackColor = System.Drawing.SystemColors.Control
        Me.lblFromReqDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFromReqDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFromReqDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndSalesman, "From-request-date", True))
        Me.lblFromReqDate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFromReqDate.ForeColor = System.Drawing.Color.Blue
        Me.lblFromReqDate.Location = New System.Drawing.Point(88, 128)
        Me.lblFromReqDate.Name = "lblFromReqDate"
        Me.lblFromReqDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFromReqDate.Size = New System.Drawing.Size(81, 17)
        Me.lblFromReqDate.TabIndex = 21
        Me.lblFromReqDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblExpNo
        '
        Me.lblExpNo.BackColor = System.Drawing.SystemColors.Control
        Me.lblExpNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblExpNo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblExpNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndSalesman, "ExportNo", True))
        Me.lblExpNo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpNo.ForeColor = System.Drawing.Color.Blue
        Me.lblExpNo.Location = New System.Drawing.Point(144, 48)
        Me.lblExpNo.Name = "lblExpNo"
        Me.lblExpNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblExpNo.Size = New System.Drawing.Size(81, 17)
        Me.lblExpNo.TabIndex = 20
        Me.lblExpNo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblWsNo
        '
        Me.lblWsNo.BackColor = System.Drawing.SystemColors.Control
        Me.lblWsNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWsNo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblWsNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndSalesman, "WorksheetNo", True))
        Me.lblWsNo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWsNo.ForeColor = System.Drawing.Color.Blue
        Me.lblWsNo.Location = New System.Drawing.Point(144, 24)
        Me.lblWsNo.Name = "lblWsNo"
        Me.lblWsNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblWsNo.Size = New System.Drawing.Size(81, 17)
        Me.lblWsNo.TabIndex = 19
        Me.lblWsNo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.lblZipCode)
        Me.Frame1.Controls.Add(Me.lblState)
        Me.Frame1.Controls.Add(Me.lblCity)
        Me.Frame1.Controls.Add(Me.lblAddr3)
        Me.Frame1.Controls.Add(Me.lblAddr2)
        Me.Frame1.Controls.Add(Me.lblAddr1)
        Me.Frame1.Controls.Add(Me.lblName)
        Me.Frame1.Controls.Add(Me.lblSlsmnCode)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.Color.Blue
        Me.Frame1.Location = New System.Drawing.Point(16, 96)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(273, 161)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "PERSONAL DATA"
        '
        'lblZipCode
        '
        Me.lblZipCode.BackColor = System.Drawing.SystemColors.Control
        Me.lblZipCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblZipCode.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblZipCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndSalesman, "zip-code", True))
        Me.lblZipCode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZipCode.ForeColor = System.Drawing.Color.Blue
        Me.lblZipCode.Location = New System.Drawing.Point(184, 136)
        Me.lblZipCode.Name = "lblZipCode"
        Me.lblZipCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblZipCode.Size = New System.Drawing.Size(81, 17)
        Me.lblZipCode.TabIndex = 8
        '
        'lblState
        '
        Me.lblState.BackColor = System.Drawing.SystemColors.Control
        Me.lblState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblState.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblState.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndSalesman, "st", True))
        Me.lblState.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.ForeColor = System.Drawing.Color.Blue
        Me.lblState.Location = New System.Drawing.Point(152, 136)
        Me.lblState.Name = "lblState"
        Me.lblState.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblState.Size = New System.Drawing.Size(25, 17)
        Me.lblState.TabIndex = 7
        '
        'lblCity
        '
        Me.lblCity.BackColor = System.Drawing.SystemColors.Control
        Me.lblCity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCity.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndSalesman, "city", True))
        Me.lblCity.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.ForeColor = System.Drawing.Color.Blue
        Me.lblCity.Location = New System.Drawing.Point(8, 136)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCity.Size = New System.Drawing.Size(137, 17)
        Me.lblCity.TabIndex = 6
        '
        'lblAddr3
        '
        Me.lblAddr3.BackColor = System.Drawing.SystemColors.Control
        Me.lblAddr3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAddr3.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAddr3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndSalesman, "address3", True))
        Me.lblAddr3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddr3.ForeColor = System.Drawing.Color.Blue
        Me.lblAddr3.Location = New System.Drawing.Point(8, 112)
        Me.lblAddr3.Name = "lblAddr3"
        Me.lblAddr3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAddr3.Size = New System.Drawing.Size(257, 17)
        Me.lblAddr3.TabIndex = 5
        '
        'lblAddr2
        '
        Me.lblAddr2.BackColor = System.Drawing.SystemColors.Control
        Me.lblAddr2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAddr2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAddr2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndSalesman, "address2", True))
        Me.lblAddr2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddr2.ForeColor = System.Drawing.Color.Blue
        Me.lblAddr2.Location = New System.Drawing.Point(8, 88)
        Me.lblAddr2.Name = "lblAddr2"
        Me.lblAddr2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAddr2.Size = New System.Drawing.Size(257, 17)
        Me.lblAddr2.TabIndex = 4
        '
        'lblAddr1
        '
        Me.lblAddr1.BackColor = System.Drawing.SystemColors.Control
        Me.lblAddr1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAddr1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAddr1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndSalesman, "address1", True))
        Me.lblAddr1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddr1.ForeColor = System.Drawing.Color.Blue
        Me.lblAddr1.Location = New System.Drawing.Point(8, 64)
        Me.lblAddr1.Name = "lblAddr1"
        Me.lblAddr1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAddr1.Size = New System.Drawing.Size(257, 17)
        Me.lblAddr1.TabIndex = 3
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.SystemColors.Control
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblName.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndSalesman, "name", True))
        Me.lblName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Blue
        Me.lblName.Location = New System.Drawing.Point(8, 40)
        Me.lblName.Name = "lblName"
        Me.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblName.Size = New System.Drawing.Size(257, 17)
        Me.lblName.TabIndex = 2
        '
        'lblSlsmnCode
        '
        Me.lblSlsmnCode.BackColor = System.Drawing.SystemColors.Control
        Me.lblSlsmnCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSlsmnCode.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSlsmnCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndSalesman, "SlsmnCode", True))
        Me.lblSlsmnCode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSlsmnCode.ForeColor = System.Drawing.Color.Blue
        Me.lblSlsmnCode.Location = New System.Drawing.Point(224, 16)
        Me.lblSlsmnCode.Name = "lblSlsmnCode"
        Me.lblSlsmnCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSlsmnCode.Size = New System.Drawing.Size(41, 17)
        Me.lblSlsmnCode.TabIndex = 1
        Me.lblSlsmnCode.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SalesmanTableAdapter
        '
        Me.SalesmanTableAdapter.ClearBeforeFill = True
        '
        'frmSalesPerson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(638, 467)
        Me.ControlBox = False
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame4)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(3, 31)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSalesPerson"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Person Record"
        Me.Frame2.ResumeLayout(False)
        CType(Me.bndSalesman, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleForcDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame4.ResumeLayout(False)
        Me.Frame3.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region
#Region "Upgrade Support"
    Friend WithEvents bndSalesman As System.Windows.Forms.BindingSource
    Friend WithEvents SaleForcDataSet As KC01.SaleForcDataSet
    Friend WithEvents SalesmanTableAdapter As KC01.SaleForcDataSetTableAdapters.SalesmanTableAdapter
#End Region
End Class