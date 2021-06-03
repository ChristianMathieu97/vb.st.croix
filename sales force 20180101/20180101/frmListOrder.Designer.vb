<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmListOrder
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
    Public WithEvents cmdFindOrder As System.Windows.Forms.Button
    Public WithEvents Frame4 As System.Windows.Forms.GroupBox
    Public WithEvents cmbSeasonCodes As System.Windows.Forms.ComboBox
    Public WithEvents cmbOrderCodes As System.Windows.Forms.ComboBox
    Public WithEvents optPartiallyShippedOrders As System.Windows.Forms.RadioButton
    Public WithEvents optShippedOrders As System.Windows.Forms.RadioButton
    Public WithEvents optOpenOrders As System.Windows.Forms.RadioButton
    Public WithEvents optAllOrders As System.Windows.Forms.RadioButton
    Public WithEvents lblSeasonCodes As System.Windows.Forms.Label
    Public WithEvents lblOrderCodes As System.Windows.Forms.Label
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents Text1 As System.Windows.Forms.TextBox
    Public WithEvents cmdCustomer As System.Windows.Forms.Button
    Public WithEvents cmdViewOrd As System.Windows.Forms.Button
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents cmdExit As System.Windows.Forms.Button
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents optDisplay As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame4 = New System.Windows.Forms.GroupBox
        Me.cmdFindOrder = New System.Windows.Forms.Button
        Me.Frame3 = New System.Windows.Forms.GroupBox
        Me.cmbSeasonCodes = New System.Windows.Forms.ComboBox
        Me.cmbOrderCodes = New System.Windows.Forms.ComboBox
        Me.optPartiallyShippedOrders = New System.Windows.Forms.RadioButton
        Me.optShippedOrders = New System.Windows.Forms.RadioButton
        Me.optOpenOrders = New System.Windows.Forms.RadioButton
        Me.optAllOrders = New System.Windows.Forms.RadioButton
        Me.lblSeasonCodes = New System.Windows.Forms.Label
        Me.lblOrderCodes = New System.Windows.Forms.Label
        Me.SeasonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaleForcDataSet = New KC01.SaleForcDataSet
        Me.OrderTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me.Text1 = New System.Windows.Forms.TextBox
        Me.cmdCustomer = New System.Windows.Forms.Button
        Me.cmdViewOrd = New System.Windows.Forms.Button
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.cmdExit = New System.Windows.Forms.Button
        Me.optDisplay = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.OrderTypeTableAdapter = New KC01.SaleForcDataSetTableAdapters.OrderTypeTableAdapter
        Me.SeasonTableAdapter = New KC01.SaleForcDataSetTableAdapters.SeasonTableAdapter
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderTableAdapter = New KC01.SaleForcDataSetTableAdapters.OrderTableAdapter
        Me.dtgOrders = New System.Windows.Forms.DataGridView
        Me.OrdernoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OrderdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CompletedateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QtyshippedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QtyopenorderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OpenValueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WorksheetIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InvoicenoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LastUpDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CustpoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QtyorigordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ShipnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CustnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChargecustDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RequestdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CanceldateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OrdercodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TermcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SlsmncodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CommcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CommrateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ShipNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ShipAddress1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ShipAddress2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ShipAddress3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ShipCityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ShipStateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ShipZipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ShipCountryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ViaCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PpsnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PpsdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InvoicedateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CreditrejectDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.QtyonppsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AllocqtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AllocvalueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HoldarcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HoldshipcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AddchargesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NetvalueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ShipcompleteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ShipcontactDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ShipTelephoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TagmemoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ShipruleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OrdcompleteDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.SpecialorderDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.SeasonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.lblCustomerNumber = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblCustomerName = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblSortTypeOrder = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblOrderCount = New System.Windows.Forms.ToolStripStatusLabel
        Me.Frame4.SuspendLayout()
        Me.Frame3.SuspendLayout()
        CType(Me.SeasonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleForcDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        CType(Me.optDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame4
        '
        Me.Frame4.BackColor = System.Drawing.SystemColors.Control
        Me.Frame4.Controls.Add(Me.cmdFindOrder)
        Me.Frame4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame4.ForeColor = System.Drawing.Color.Blue
        Me.Frame4.Location = New System.Drawing.Point(104, 0)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame4.Size = New System.Drawing.Size(97, 65)
        Me.Frame4.TabIndex = 10
        Me.Frame4.TabStop = False
        '
        'cmdFindOrder
        '
        Me.cmdFindOrder.BackColor = System.Drawing.SystemColors.Control
        Me.cmdFindOrder.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFindOrder.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFindOrder.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdFindOrder.Location = New System.Drawing.Point(8, 24)
        Me.cmdFindOrder.Name = "cmdFindOrder"
        Me.cmdFindOrder.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdFindOrder.Size = New System.Drawing.Size(81, 25)
        Me.cmdFindOrder.TabIndex = 11
        Me.cmdFindOrder.Text = "Find Order"
        Me.cmdFindOrder.UseVisualStyleBackColor = False
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.cmbSeasonCodes)
        Me.Frame3.Controls.Add(Me.cmbOrderCodes)
        Me.Frame3.Controls.Add(Me.optPartiallyShippedOrders)
        Me.Frame3.Controls.Add(Me.optShippedOrders)
        Me.Frame3.Controls.Add(Me.optOpenOrders)
        Me.Frame3.Controls.Add(Me.optAllOrders)
        Me.Frame3.Controls.Add(Me.lblSeasonCodes)
        Me.Frame3.Controls.Add(Me.lblOrderCodes)
        Me.Frame3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.Color.Blue
        Me.Frame3.Location = New System.Drawing.Point(200, 0)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(377, 65)
        Me.Frame3.TabIndex = 4
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "ORDER DISPLAY OPTIONS "
        '
        'cmbSeasonCodes
        '
        Me.cmbSeasonCodes.BackColor = System.Drawing.SystemColors.Window
        Me.cmbSeasonCodes.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbSeasonCodes.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSeasonCodes.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSeasonCodes.Location = New System.Drawing.Point(312, 37)
        Me.cmbSeasonCodes.Name = "cmbSeasonCodes"
        Me.cmbSeasonCodes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbSeasonCodes.Size = New System.Drawing.Size(57, 22)
        Me.cmbSeasonCodes.TabIndex = 15
        '
        'cmbOrderCodes
        '
        Me.cmbOrderCodes.BackColor = System.Drawing.SystemColors.Window
        Me.cmbOrderCodes.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbOrderCodes.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOrderCodes.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbOrderCodes.Location = New System.Drawing.Point(88, 37)
        Me.cmbOrderCodes.Name = "cmbOrderCodes"
        Me.cmbOrderCodes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbOrderCodes.Size = New System.Drawing.Size(121, 22)
        Me.cmbOrderCodes.TabIndex = 13
        '
        'optPartiallyShippedOrders
        '
        Me.optPartiallyShippedOrders.BackColor = System.Drawing.SystemColors.Control
        Me.optPartiallyShippedOrders.Cursor = System.Windows.Forms.Cursors.Default
        Me.optPartiallyShippedOrders.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optPartiallyShippedOrders.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optDisplay.SetIndex(Me.optPartiallyShippedOrders, CType(3, Short))
        Me.optPartiallyShippedOrders.Location = New System.Drawing.Point(248, 16)
        Me.optPartiallyShippedOrders.Name = "optPartiallyShippedOrders"
        Me.optPartiallyShippedOrders.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optPartiallyShippedOrders.Size = New System.Drawing.Size(121, 17)
        Me.optPartiallyShippedOrders.TabIndex = 8
        Me.optPartiallyShippedOrders.Text = "Partially shipped"
        Me.optPartiallyShippedOrders.UseVisualStyleBackColor = False
        '
        'optShippedOrders
        '
        Me.optShippedOrders.BackColor = System.Drawing.SystemColors.Control
        Me.optShippedOrders.Cursor = System.Windows.Forms.Cursors.Default
        Me.optShippedOrders.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optShippedOrders.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optDisplay.SetIndex(Me.optShippedOrders, CType(2, Short))
        Me.optShippedOrders.Location = New System.Drawing.Point(160, 16)
        Me.optShippedOrders.Name = "optShippedOrders"
        Me.optShippedOrders.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optShippedOrders.Size = New System.Drawing.Size(73, 17)
        Me.optShippedOrders.TabIndex = 7
        Me.optShippedOrders.Text = "Shipped"
        Me.optShippedOrders.UseVisualStyleBackColor = False
        '
        'optOpenOrders
        '
        Me.optOpenOrders.BackColor = System.Drawing.SystemColors.Control
        Me.optOpenOrders.Cursor = System.Windows.Forms.Cursors.Default
        Me.optOpenOrders.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optOpenOrders.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optDisplay.SetIndex(Me.optOpenOrders, CType(1, Short))
        Me.optOpenOrders.Location = New System.Drawing.Point(96, 16)
        Me.optOpenOrders.Name = "optOpenOrders"
        Me.optOpenOrders.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optOpenOrders.Size = New System.Drawing.Size(57, 17)
        Me.optOpenOrders.TabIndex = 6
        Me.optOpenOrders.Text = "Open"
        Me.optOpenOrders.UseVisualStyleBackColor = False
        '
        'optAllOrders
        '
        Me.optAllOrders.BackColor = System.Drawing.SystemColors.Control
        Me.optAllOrders.Checked = True
        Me.optAllOrders.Cursor = System.Windows.Forms.Cursors.Default
        Me.optAllOrders.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAllOrders.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optDisplay.SetIndex(Me.optAllOrders, CType(0, Short))
        Me.optAllOrders.Location = New System.Drawing.Point(8, 16)
        Me.optAllOrders.Name = "optAllOrders"
        Me.optAllOrders.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optAllOrders.Size = New System.Drawing.Size(81, 17)
        Me.optAllOrders.TabIndex = 5
        Me.optAllOrders.TabStop = True
        Me.optAllOrders.Text = "&All Orders"
        Me.optAllOrders.UseVisualStyleBackColor = False
        '
        'lblSeasonCodes
        '
        Me.lblSeasonCodes.BackColor = System.Drawing.SystemColors.Control
        Me.lblSeasonCodes.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSeasonCodes.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeasonCodes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSeasonCodes.Location = New System.Drawing.Point(216, 43)
        Me.lblSeasonCodes.Name = "lblSeasonCodes"
        Me.lblSeasonCodes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSeasonCodes.Size = New System.Drawing.Size(89, 17)
        Me.lblSeasonCodes.TabIndex = 16
        Me.lblSeasonCodes.Text = "Season Codes:"
        '
        'lblOrderCodes
        '
        Me.lblOrderCodes.BackColor = System.Drawing.SystemColors.Control
        Me.lblOrderCodes.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblOrderCodes.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderCodes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblOrderCodes.Location = New System.Drawing.Point(8, 43)
        Me.lblOrderCodes.Name = "lblOrderCodes"
        Me.lblOrderCodes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOrderCodes.Size = New System.Drawing.Size(81, 17)
        Me.lblOrderCodes.TabIndex = 14
        Me.lblOrderCodes.Text = "Order Codes:"
        '
        'SeasonBindingSource
        '
        Me.SeasonBindingSource.DataMember = "Season"
        Me.SeasonBindingSource.DataSource = Me.SaleForcDataSet
        '
        'SaleForcDataSet
        '
        Me.SaleForcDataSet.DataSetName = "SaleForcDataSet"
        Me.SaleForcDataSet.EnforceConstraints = False
        Me.SaleForcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderTypeBindingSource
        '
        Me.OrderTypeBindingSource.DataMember = "OrderType"
        Me.OrderTypeBindingSource.DataSource = Me.SaleForcDataSet
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.Text1)
        Me.Frame2.Controls.Add(Me.cmdCustomer)
        Me.Frame2.Controls.Add(Me.cmdViewOrd)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.Color.Blue
        Me.Frame2.Location = New System.Drawing.Point(576, 0)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(209, 65)
        Me.Frame2.TabIndex = 2
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "GO TO"
        '
        'Text1
        '
        Me.Text1.AcceptsReturn = True
        Me.Text1.BackColor = System.Drawing.SystemColors.Window
        Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1.Location = New System.Drawing.Point(16, 43)
        Me.Text1.MaxLength = 0
        Me.Text1.Name = "Text1"
        Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1.Size = New System.Drawing.Size(73, 20)
        Me.Text1.TabIndex = 17
        Me.Text1.Text = "Text1"
        Me.Text1.Visible = False
        '
        'cmdCustomer
        '
        Me.cmdCustomer.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCustomer.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCustomer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCustomer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCustomer.Location = New System.Drawing.Point(104, 16)
        Me.cmdCustomer.Name = "cmdCustomer"
        Me.cmdCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCustomer.Size = New System.Drawing.Size(89, 25)
        Me.cmdCustomer.TabIndex = 9
        Me.cmdCustomer.Text = "&Customer"
        Me.cmdCustomer.UseVisualStyleBackColor = False
        '
        'cmdViewOrd
        '
        Me.cmdViewOrd.BackColor = System.Drawing.SystemColors.Control
        Me.cmdViewOrd.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdViewOrd.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdViewOrd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdViewOrd.Location = New System.Drawing.Point(8, 16)
        Me.cmdViewOrd.Name = "cmdViewOrd"
        Me.cmdViewOrd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdViewOrd.Size = New System.Drawing.Size(89, 25)
        Me.cmdViewOrd.TabIndex = 3
        Me.cmdViewOrd.Text = "&Order"
        Me.cmdViewOrd.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.cmdExit)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(0, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(105, 65)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdExit.Location = New System.Drawing.Point(8, 24)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExit.Size = New System.Drawing.Size(81, 25)
        Me.cmdExit.TabIndex = 1
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'optDisplay
        '
        '
        'OrderTypeTableAdapter
        '
        Me.OrderTypeTableAdapter.ClearBeforeFill = True
        '
        'SeasonTableAdapter
        '
        Me.SeasonTableAdapter.ClearBeforeFill = True
        '
        'OrderBindingSource
        '
        Me.OrderBindingSource.DataMember = "Order"
        Me.OrderBindingSource.DataSource = Me.SaleForcDataSet
        '
        'OrderTableAdapter
        '
        Me.OrderTableAdapter.ClearBeforeFill = True
        '
        'dtgOrders
        '
        Me.dtgOrders.AutoGenerateColumns = False
        Me.dtgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgOrders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrdernoDataGridViewTextBoxColumn, Me.OrderdateDataGridViewTextBoxColumn, Me.CompletedateDataGridViewTextBoxColumn, Me.QtyshippedDataGridViewTextBoxColumn, Me.QtyopenorderDataGridViewTextBoxColumn, Me.OpenValueDataGridViewTextBoxColumn, Me.WorksheetIDDataGridViewTextBoxColumn, Me.InvoicenoDataGridViewTextBoxColumn, Me.LastUpDateDataGridViewTextBoxColumn, Me.CustpoDataGridViewTextBoxColumn, Me.QtyorigordDataGridViewTextBoxColumn, Me.ShipnoDataGridViewTextBoxColumn, Me.CustnoDataGridViewTextBoxColumn, Me.ChargecustDataGridViewTextBoxColumn, Me.DepartmentDataGridViewTextBoxColumn, Me.RequestdateDataGridViewTextBoxColumn, Me.CanceldateDataGridViewTextBoxColumn, Me.OrdercodeDataGridViewTextBoxColumn, Me.TermcodeDataGridViewTextBoxColumn, Me.SlsmncodeDataGridViewTextBoxColumn, Me.CommcodeDataGridViewTextBoxColumn, Me.CommrateDataGridViewTextBoxColumn, Me.ShipNameDataGridViewTextBoxColumn, Me.ShipAddress1DataGridViewTextBoxColumn, Me.ShipAddress2DataGridViewTextBoxColumn, Me.ShipAddress3DataGridViewTextBoxColumn, Me.ShipCityDataGridViewTextBoxColumn, Me.ShipStateDataGridViewTextBoxColumn, Me.ShipZipDataGridViewTextBoxColumn, Me.ShipCountryDataGridViewTextBoxColumn, Me.ViaCodeDataGridViewTextBoxColumn, Me.PpsnoDataGridViewTextBoxColumn, Me.PpsdateDataGridViewTextBoxColumn, Me.InvoicedateDataGridViewTextBoxColumn, Me.CreditrejectDataGridViewCheckBoxColumn, Me.QtyonppsDataGridViewTextBoxColumn, Me.AllocqtyDataGridViewTextBoxColumn, Me.AllocvalueDataGridViewTextBoxColumn, Me.HoldarcodeDataGridViewTextBoxColumn, Me.HoldshipcodeDataGridViewTextBoxColumn, Me.AddchargesDataGridViewTextBoxColumn, Me.NetvalueDataGridViewTextBoxColumn, Me.ShipcompleteDataGridViewTextBoxColumn, Me.ShipcontactDataGridViewTextBoxColumn, Me.ShipTelephoneDataGridViewTextBoxColumn, Me.TagmemoDataGridViewTextBoxColumn, Me.ShipruleDataGridViewTextBoxColumn, Me.OrdcompleteDataGridViewCheckBoxColumn, Me.SpecialorderDataGridViewCheckBoxColumn, Me.SeasonDataGridViewTextBoxColumn})
        Me.dtgOrders.DataSource = Me.OrderBindingSource
        Me.dtgOrders.Location = New System.Drawing.Point(0, 65)
        Me.dtgOrders.MultiSelect = False
        Me.dtgOrders.Name = "dtgOrders"
        Me.dtgOrders.RowHeadersVisible = False
        Me.dtgOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgOrders.Size = New System.Drawing.Size(785, 456)
        Me.dtgOrders.TabIndex = 22
        '
        'OrdernoDataGridViewTextBoxColumn
        '
        Me.OrdernoDataGridViewTextBoxColumn.DataPropertyName = "Order-no"
        Me.OrdernoDataGridViewTextBoxColumn.HeaderText = "Order-no"
        Me.OrdernoDataGridViewTextBoxColumn.Name = "OrdernoDataGridViewTextBoxColumn"
        Me.OrdernoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OrderdateDataGridViewTextBoxColumn
        '
        Me.OrderdateDataGridViewTextBoxColumn.DataPropertyName = "Order-date"
        Me.OrderdateDataGridViewTextBoxColumn.HeaderText = "Order-date"
        Me.OrderdateDataGridViewTextBoxColumn.Name = "OrderdateDataGridViewTextBoxColumn"
        '
        'CompletedateDataGridViewTextBoxColumn
        '
        Me.CompletedateDataGridViewTextBoxColumn.DataPropertyName = "Complete-date"
        Me.CompletedateDataGridViewTextBoxColumn.HeaderText = "Complete-date"
        Me.CompletedateDataGridViewTextBoxColumn.Name = "CompletedateDataGridViewTextBoxColumn"
        '
        'QtyshippedDataGridViewTextBoxColumn
        '
        Me.QtyshippedDataGridViewTextBoxColumn.DataPropertyName = "Qty-shipped"
        Me.QtyshippedDataGridViewTextBoxColumn.HeaderText = "Qty-shipped"
        Me.QtyshippedDataGridViewTextBoxColumn.Name = "QtyshippedDataGridViewTextBoxColumn"
        '
        'QtyopenorderDataGridViewTextBoxColumn
        '
        Me.QtyopenorderDataGridViewTextBoxColumn.DataPropertyName = "Qty-open-order"
        Me.QtyopenorderDataGridViewTextBoxColumn.HeaderText = "Qty-open-order"
        Me.QtyopenorderDataGridViewTextBoxColumn.Name = "QtyopenorderDataGridViewTextBoxColumn"
        '
        'OpenValueDataGridViewTextBoxColumn
        '
        Me.OpenValueDataGridViewTextBoxColumn.DataPropertyName = "OpenValue"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.OpenValueDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.OpenValueDataGridViewTextBoxColumn.HeaderText = "OpenValue"
        Me.OpenValueDataGridViewTextBoxColumn.Name = "OpenValueDataGridViewTextBoxColumn"
        '
        'WorksheetIDDataGridViewTextBoxColumn
        '
        Me.WorksheetIDDataGridViewTextBoxColumn.DataPropertyName = "WorksheetID"
        Me.WorksheetIDDataGridViewTextBoxColumn.HeaderText = "WorksheetID"
        Me.WorksheetIDDataGridViewTextBoxColumn.Name = "WorksheetIDDataGridViewTextBoxColumn"
        '
        'InvoicenoDataGridViewTextBoxColumn
        '
        Me.InvoicenoDataGridViewTextBoxColumn.DataPropertyName = "Invoice-no"
        Me.InvoicenoDataGridViewTextBoxColumn.HeaderText = "Invoice-no"
        Me.InvoicenoDataGridViewTextBoxColumn.Name = "InvoicenoDataGridViewTextBoxColumn"
        '
        'LastUpDateDataGridViewTextBoxColumn
        '
        Me.LastUpDateDataGridViewTextBoxColumn.DataPropertyName = "LastUpDate"
        Me.LastUpDateDataGridViewTextBoxColumn.HeaderText = "LastUpDate"
        Me.LastUpDateDataGridViewTextBoxColumn.Name = "LastUpDateDataGridViewTextBoxColumn"
        '
        'CustpoDataGridViewTextBoxColumn
        '
        Me.CustpoDataGridViewTextBoxColumn.DataPropertyName = "Cust-po"
        Me.CustpoDataGridViewTextBoxColumn.HeaderText = "Cust-po"
        Me.CustpoDataGridViewTextBoxColumn.Name = "CustpoDataGridViewTextBoxColumn"
        '
        'QtyorigordDataGridViewTextBoxColumn
        '
        Me.QtyorigordDataGridViewTextBoxColumn.DataPropertyName = "Qty-orig-ord"
        Me.QtyorigordDataGridViewTextBoxColumn.HeaderText = "Qty-orig-ord"
        Me.QtyorigordDataGridViewTextBoxColumn.Name = "QtyorigordDataGridViewTextBoxColumn"
        '
        'ShipnoDataGridViewTextBoxColumn
        '
        Me.ShipnoDataGridViewTextBoxColumn.DataPropertyName = "Ship-no"
        Me.ShipnoDataGridViewTextBoxColumn.HeaderText = "Ship-no"
        Me.ShipnoDataGridViewTextBoxColumn.Name = "ShipnoDataGridViewTextBoxColumn"
        '
        'CustnoDataGridViewTextBoxColumn
        '
        Me.CustnoDataGridViewTextBoxColumn.DataPropertyName = "Cust-no"
        Me.CustnoDataGridViewTextBoxColumn.HeaderText = "Cust-no"
        Me.CustnoDataGridViewTextBoxColumn.Name = "CustnoDataGridViewTextBoxColumn"
        '
        'ChargecustDataGridViewTextBoxColumn
        '
        Me.ChargecustDataGridViewTextBoxColumn.DataPropertyName = "Charge-cust"
        Me.ChargecustDataGridViewTextBoxColumn.HeaderText = "Charge-cust"
        Me.ChargecustDataGridViewTextBoxColumn.Name = "ChargecustDataGridViewTextBoxColumn"
        '
        'DepartmentDataGridViewTextBoxColumn
        '
        Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
        '
        'RequestdateDataGridViewTextBoxColumn
        '
        Me.RequestdateDataGridViewTextBoxColumn.DataPropertyName = "Request-date"
        Me.RequestdateDataGridViewTextBoxColumn.HeaderText = "Request-date"
        Me.RequestdateDataGridViewTextBoxColumn.Name = "RequestdateDataGridViewTextBoxColumn"
        '
        'CanceldateDataGridViewTextBoxColumn
        '
        Me.CanceldateDataGridViewTextBoxColumn.DataPropertyName = "Cancel-date"
        Me.CanceldateDataGridViewTextBoxColumn.HeaderText = "Cancel-date"
        Me.CanceldateDataGridViewTextBoxColumn.Name = "CanceldateDataGridViewTextBoxColumn"
        '
        'OrdercodeDataGridViewTextBoxColumn
        '
        Me.OrdercodeDataGridViewTextBoxColumn.DataPropertyName = "Order-code"
        Me.OrdercodeDataGridViewTextBoxColumn.HeaderText = "Order-code"
        Me.OrdercodeDataGridViewTextBoxColumn.Name = "OrdercodeDataGridViewTextBoxColumn"
        '
        'TermcodeDataGridViewTextBoxColumn
        '
        Me.TermcodeDataGridViewTextBoxColumn.DataPropertyName = "Term-code"
        Me.TermcodeDataGridViewTextBoxColumn.HeaderText = "Term-code"
        Me.TermcodeDataGridViewTextBoxColumn.Name = "TermcodeDataGridViewTextBoxColumn"
        '
        'SlsmncodeDataGridViewTextBoxColumn
        '
        Me.SlsmncodeDataGridViewTextBoxColumn.DataPropertyName = "Slsmn-code"
        Me.SlsmncodeDataGridViewTextBoxColumn.HeaderText = "Slsmn-code"
        Me.SlsmncodeDataGridViewTextBoxColumn.Name = "SlsmncodeDataGridViewTextBoxColumn"
        '
        'CommcodeDataGridViewTextBoxColumn
        '
        Me.CommcodeDataGridViewTextBoxColumn.DataPropertyName = "Comm-code"
        Me.CommcodeDataGridViewTextBoxColumn.HeaderText = "Comm-code"
        Me.CommcodeDataGridViewTextBoxColumn.Name = "CommcodeDataGridViewTextBoxColumn"
        '
        'CommrateDataGridViewTextBoxColumn
        '
        Me.CommrateDataGridViewTextBoxColumn.DataPropertyName = "Comm-rate"
        Me.CommrateDataGridViewTextBoxColumn.HeaderText = "Comm-rate"
        Me.CommrateDataGridViewTextBoxColumn.Name = "CommrateDataGridViewTextBoxColumn"
        '
        'ShipNameDataGridViewTextBoxColumn
        '
        Me.ShipNameDataGridViewTextBoxColumn.DataPropertyName = "ShipName"
        Me.ShipNameDataGridViewTextBoxColumn.HeaderText = "ShipName"
        Me.ShipNameDataGridViewTextBoxColumn.Name = "ShipNameDataGridViewTextBoxColumn"
        '
        'ShipAddress1DataGridViewTextBoxColumn
        '
        Me.ShipAddress1DataGridViewTextBoxColumn.DataPropertyName = "ShipAddress1"
        Me.ShipAddress1DataGridViewTextBoxColumn.HeaderText = "ShipAddress1"
        Me.ShipAddress1DataGridViewTextBoxColumn.Name = "ShipAddress1DataGridViewTextBoxColumn"
        '
        'ShipAddress2DataGridViewTextBoxColumn
        '
        Me.ShipAddress2DataGridViewTextBoxColumn.DataPropertyName = "ShipAddress2"
        Me.ShipAddress2DataGridViewTextBoxColumn.HeaderText = "ShipAddress2"
        Me.ShipAddress2DataGridViewTextBoxColumn.Name = "ShipAddress2DataGridViewTextBoxColumn"
        '
        'ShipAddress3DataGridViewTextBoxColumn
        '
        Me.ShipAddress3DataGridViewTextBoxColumn.DataPropertyName = "ShipAddress3"
        Me.ShipAddress3DataGridViewTextBoxColumn.HeaderText = "ShipAddress3"
        Me.ShipAddress3DataGridViewTextBoxColumn.Name = "ShipAddress3DataGridViewTextBoxColumn"
        '
        'ShipCityDataGridViewTextBoxColumn
        '
        Me.ShipCityDataGridViewTextBoxColumn.DataPropertyName = "ShipCity"
        Me.ShipCityDataGridViewTextBoxColumn.HeaderText = "ShipCity"
        Me.ShipCityDataGridViewTextBoxColumn.Name = "ShipCityDataGridViewTextBoxColumn"
        '
        'ShipStateDataGridViewTextBoxColumn
        '
        Me.ShipStateDataGridViewTextBoxColumn.DataPropertyName = "ShipState"
        Me.ShipStateDataGridViewTextBoxColumn.HeaderText = "ShipState"
        Me.ShipStateDataGridViewTextBoxColumn.Name = "ShipStateDataGridViewTextBoxColumn"
        '
        'ShipZipDataGridViewTextBoxColumn
        '
        Me.ShipZipDataGridViewTextBoxColumn.DataPropertyName = "ShipZip"
        Me.ShipZipDataGridViewTextBoxColumn.HeaderText = "ShipZip"
        Me.ShipZipDataGridViewTextBoxColumn.Name = "ShipZipDataGridViewTextBoxColumn"
        '
        'ShipCountryDataGridViewTextBoxColumn
        '
        Me.ShipCountryDataGridViewTextBoxColumn.DataPropertyName = "ShipCountry"
        Me.ShipCountryDataGridViewTextBoxColumn.HeaderText = "ShipCountry"
        Me.ShipCountryDataGridViewTextBoxColumn.Name = "ShipCountryDataGridViewTextBoxColumn"
        '
        'ViaCodeDataGridViewTextBoxColumn
        '
        Me.ViaCodeDataGridViewTextBoxColumn.DataPropertyName = "ViaCode"
        Me.ViaCodeDataGridViewTextBoxColumn.HeaderText = "ViaCode"
        Me.ViaCodeDataGridViewTextBoxColumn.Name = "ViaCodeDataGridViewTextBoxColumn"
        '
        'PpsnoDataGridViewTextBoxColumn
        '
        Me.PpsnoDataGridViewTextBoxColumn.DataPropertyName = "Pps-no"
        Me.PpsnoDataGridViewTextBoxColumn.HeaderText = "Pps-no"
        Me.PpsnoDataGridViewTextBoxColumn.Name = "PpsnoDataGridViewTextBoxColumn"
        '
        'PpsdateDataGridViewTextBoxColumn
        '
        Me.PpsdateDataGridViewTextBoxColumn.DataPropertyName = "Pps-date"
        Me.PpsdateDataGridViewTextBoxColumn.HeaderText = "Pps-date"
        Me.PpsdateDataGridViewTextBoxColumn.Name = "PpsdateDataGridViewTextBoxColumn"
        '
        'InvoicedateDataGridViewTextBoxColumn
        '
        Me.InvoicedateDataGridViewTextBoxColumn.DataPropertyName = "Invoice-date"
        Me.InvoicedateDataGridViewTextBoxColumn.HeaderText = "Invoice-date"
        Me.InvoicedateDataGridViewTextBoxColumn.Name = "InvoicedateDataGridViewTextBoxColumn"
        '
        'CreditrejectDataGridViewCheckBoxColumn
        '
        Me.CreditrejectDataGridViewCheckBoxColumn.DataPropertyName = "Credit-reject"
        Me.CreditrejectDataGridViewCheckBoxColumn.HeaderText = "Credit-reject"
        Me.CreditrejectDataGridViewCheckBoxColumn.Name = "CreditrejectDataGridViewCheckBoxColumn"
        '
        'QtyonppsDataGridViewTextBoxColumn
        '
        Me.QtyonppsDataGridViewTextBoxColumn.DataPropertyName = "Qty-on-pps"
        Me.QtyonppsDataGridViewTextBoxColumn.HeaderText = "Qty-on-pps"
        Me.QtyonppsDataGridViewTextBoxColumn.Name = "QtyonppsDataGridViewTextBoxColumn"
        '
        'AllocqtyDataGridViewTextBoxColumn
        '
        Me.AllocqtyDataGridViewTextBoxColumn.DataPropertyName = "Alloc-qty"
        Me.AllocqtyDataGridViewTextBoxColumn.HeaderText = "Alloc-qty"
        Me.AllocqtyDataGridViewTextBoxColumn.Name = "AllocqtyDataGridViewTextBoxColumn"
        '
        'AllocvalueDataGridViewTextBoxColumn
        '
        Me.AllocvalueDataGridViewTextBoxColumn.DataPropertyName = "Alloc-value"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.AllocvalueDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.AllocvalueDataGridViewTextBoxColumn.HeaderText = "Alloc-value"
        Me.AllocvalueDataGridViewTextBoxColumn.Name = "AllocvalueDataGridViewTextBoxColumn"
        '
        'HoldarcodeDataGridViewTextBoxColumn
        '
        Me.HoldarcodeDataGridViewTextBoxColumn.DataPropertyName = "Hold-ar-code"
        Me.HoldarcodeDataGridViewTextBoxColumn.HeaderText = "Hold-ar-code"
        Me.HoldarcodeDataGridViewTextBoxColumn.Name = "HoldarcodeDataGridViewTextBoxColumn"
        '
        'HoldshipcodeDataGridViewTextBoxColumn
        '
        Me.HoldshipcodeDataGridViewTextBoxColumn.DataPropertyName = "Hold-ship-code"
        Me.HoldshipcodeDataGridViewTextBoxColumn.HeaderText = "Hold-ship-code"
        Me.HoldshipcodeDataGridViewTextBoxColumn.Name = "HoldshipcodeDataGridViewTextBoxColumn"
        '
        'AddchargesDataGridViewTextBoxColumn
        '
        Me.AddchargesDataGridViewTextBoxColumn.DataPropertyName = "Add-charges"
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.AddchargesDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.AddchargesDataGridViewTextBoxColumn.HeaderText = "Add-charges"
        Me.AddchargesDataGridViewTextBoxColumn.Name = "AddchargesDataGridViewTextBoxColumn"
        '
        'NetvalueDataGridViewTextBoxColumn
        '
        Me.NetvalueDataGridViewTextBoxColumn.DataPropertyName = "Net-value"
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.NetvalueDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.NetvalueDataGridViewTextBoxColumn.HeaderText = "Net-value"
        Me.NetvalueDataGridViewTextBoxColumn.Name = "NetvalueDataGridViewTextBoxColumn"
        '
        'ShipcompleteDataGridViewTextBoxColumn
        '
        Me.ShipcompleteDataGridViewTextBoxColumn.DataPropertyName = "Ship-complete"
        Me.ShipcompleteDataGridViewTextBoxColumn.HeaderText = "Ship-complete"
        Me.ShipcompleteDataGridViewTextBoxColumn.Name = "ShipcompleteDataGridViewTextBoxColumn"
        '
        'ShipcontactDataGridViewTextBoxColumn
        '
        Me.ShipcontactDataGridViewTextBoxColumn.DataPropertyName = "Ship-contact"
        Me.ShipcontactDataGridViewTextBoxColumn.HeaderText = "Ship-contact"
        Me.ShipcontactDataGridViewTextBoxColumn.Name = "ShipcontactDataGridViewTextBoxColumn"
        '
        'ShipTelephoneDataGridViewTextBoxColumn
        '
        Me.ShipTelephoneDataGridViewTextBoxColumn.DataPropertyName = "Ship-Telephone"
        Me.ShipTelephoneDataGridViewTextBoxColumn.HeaderText = "Ship-Telephone"
        Me.ShipTelephoneDataGridViewTextBoxColumn.Name = "ShipTelephoneDataGridViewTextBoxColumn"
        '
        'TagmemoDataGridViewTextBoxColumn
        '
        Me.TagmemoDataGridViewTextBoxColumn.DataPropertyName = "tag-memo"
        Me.TagmemoDataGridViewTextBoxColumn.HeaderText = "tag-memo"
        Me.TagmemoDataGridViewTextBoxColumn.Name = "TagmemoDataGridViewTextBoxColumn"
        '
        'ShipruleDataGridViewTextBoxColumn
        '
        Me.ShipruleDataGridViewTextBoxColumn.DataPropertyName = "Ship-rule"
        Me.ShipruleDataGridViewTextBoxColumn.HeaderText = "Ship-rule"
        Me.ShipruleDataGridViewTextBoxColumn.Name = "ShipruleDataGridViewTextBoxColumn"
        '
        'OrdcompleteDataGridViewCheckBoxColumn
        '
        Me.OrdcompleteDataGridViewCheckBoxColumn.DataPropertyName = "Ord-complete"
        Me.OrdcompleteDataGridViewCheckBoxColumn.HeaderText = "Ord-complete"
        Me.OrdcompleteDataGridViewCheckBoxColumn.Name = "OrdcompleteDataGridViewCheckBoxColumn"
        '
        'SpecialorderDataGridViewCheckBoxColumn
        '
        Me.SpecialorderDataGridViewCheckBoxColumn.DataPropertyName = "Special-order"
        Me.SpecialorderDataGridViewCheckBoxColumn.HeaderText = "Special-order"
        Me.SpecialorderDataGridViewCheckBoxColumn.Name = "SpecialorderDataGridViewCheckBoxColumn"
        '
        'SeasonDataGridViewTextBoxColumn
        '
        Me.SeasonDataGridViewTextBoxColumn.DataPropertyName = "Season"
        Me.SeasonDataGridViewTextBoxColumn.HeaderText = "Season"
        Me.SeasonDataGridViewTextBoxColumn.Name = "SeasonDataGridViewTextBoxColumn"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblCustomerNumber, Me.lblCustomerName, Me.lblSortTypeOrder, Me.lblOrderCount})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 524)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(797, 24)
        Me.StatusStrip1.TabIndex = 23
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblCustomerNumber
        '
        Me.lblCustomerNumber.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.lblCustomerNumber.Name = "lblCustomerNumber"
        Me.lblCustomerNumber.Size = New System.Drawing.Size(110, 19)
        Me.lblCustomerNumber.Text = "Customer Number"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(98, 19)
        Me.lblCustomerName.Text = "Customer Name"
        '
        'lblSortTypeOrder
        '
        Me.lblSortTypeOrder.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.lblSortTypeOrder.Name = "lblSortTypeOrder"
        Me.lblSortTypeOrder.Size = New System.Drawing.Size(117, 19)
        Me.lblSortTypeOrder.Text = "Sort Type and Order"
        '
        'lblOrderCount
        '
        Me.lblOrderCount.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.lblOrderCount.Name = "lblOrderCount"
        Me.lblOrderCount.Size = New System.Drawing.Size(77, 19)
        Me.lblOrderCount.Text = "Order Count"
        '
        'frmListOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(797, 548)
        Me.ControlBox = False
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.dtgOrders)
        Me.Controls.Add(Me.Frame4)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(5, 41)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListOrder"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LIST: Orders"
        Me.Frame4.ResumeLayout(False)
        Me.Frame3.ResumeLayout(False)
        CType(Me.SeasonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleForcDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        CType(Me.optDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
#Region "Upgrade Support"
    Friend WithEvents SaleForcDataSet As KC01.SaleForcDataSet
    Friend WithEvents OrderTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderTypeTableAdapter As KC01.SaleForcDataSetTableAdapters.OrderTypeTableAdapter
    Friend WithEvents SeasonBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SeasonTableAdapter As KC01.SaleForcDataSetTableAdapters.SeasonTableAdapter
    Friend WithEvents OrderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderTableAdapter As KC01.SaleForcDataSetTableAdapters.OrderTableAdapter
    Friend WithEvents dtgOrders As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblCustomerNumber As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblCustomerName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblSortTypeOrder As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblOrderCount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents OrdernoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompletedateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyshippedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyopenorderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OpenValueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WorksheetIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvoicenoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastUpDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustpoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyorigordDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShipnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChargecustDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RequestdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CanceldateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrdercodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TermcodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SlsmncodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommcodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommrateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShipNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShipAddress1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShipAddress2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShipAddress3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShipCityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShipStateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShipZipDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShipCountryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ViaCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PpsnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PpsdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvoicedateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreditrejectDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents QtyonppsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AllocqtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AllocvalueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HoldarcodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HoldshipcodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddchargesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NetvalueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShipcompleteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShipcontactDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShipTelephoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TagmemoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShipruleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrdcompleteDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SpecialorderDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SeasonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
#End Region
End Class