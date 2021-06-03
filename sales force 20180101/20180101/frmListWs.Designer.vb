<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmListWs
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
    'Private ADOBind_adoWsList As VB6.MBindingCollection
    Public WithEvents cmdFindWS As System.Windows.Forms.Button
	Public WithEvents Frame5 As System.Windows.Forms.GroupBox
    Public WithEvents cmdExit As System.Windows.Forms.Button
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cmdViewOrder As System.Windows.Forms.Button
    Public WithEvents cmdViewCustomer As System.Windows.Forms.Button
    Public WithEvents cmdViewWs As System.Windows.Forms.Button
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents chkNoOrderWs As System.Windows.Forms.CheckBox
    Public WithEvents optAllWorksheets As System.Windows.Forms.RadioButton
    Public WithEvents optWkstNotTransmitted As System.Windows.Forms.RadioButton
    Public WithEvents optWkstTransmittedWaiting As System.Windows.Forms.RadioButton
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents optDisplay As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame5 = New System.Windows.Forms.GroupBox
        Me.cmdFindWS = New System.Windows.Forms.Button
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.cmdExit = New System.Windows.Forms.Button
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me.cmdViewOrder = New System.Windows.Forms.Button
        Me.cmdViewCustomer = New System.Windows.Forms.Button
        Me.cmdViewWs = New System.Windows.Forms.Button
        Me.Frame3 = New System.Windows.Forms.GroupBox
        Me.chkNoOrderWs = New System.Windows.Forms.CheckBox
        Me.optAllWorksheets = New System.Windows.Forms.RadioButton
        Me.optWkstNotTransmitted = New System.Windows.Forms.RadioButton
        Me.optWkstTransmittedWaiting = New System.Windows.Forms.RadioButton
        Me.optDisplay = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.dtgWorksheets = New System.Windows.Forms.DataGridView
        Me.WorksheetidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AllowmanualmaintDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ReadyToXmitDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.XmittedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.WscreatedateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TransmittalstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.XmittedDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ValidationstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ValidationdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OrdernoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OrderdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CustpoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ErrorlevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SeasonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WsordheadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaleForcDataSet = New KC01.SaleForcDataSet
        Me.Ws_ord_headTableAdapter = New KC01.SaleForcDataSetTableAdapters.ws_ord_headTableAdapter
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.CustomerNumber = New System.Windows.Forms.ToolStripStatusLabel
        Me.CustomerName = New System.Windows.Forms.ToolStripStatusLabel
        Me.WorksheetCount = New System.Windows.Forms.ToolStripStatusLabel
        Me.SortStatus = New System.Windows.Forms.ToolStripStatusLabel
        Me.Frame5.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.Frame3.SuspendLayout()
        CType(Me.optDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgWorksheets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WsordheadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleForcDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame5
        '
        Me.Frame5.BackColor = System.Drawing.SystemColors.Control
        Me.Frame5.Controls.Add(Me.cmdFindWS)
        Me.Frame5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame5.Location = New System.Drawing.Point(64, 0)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame5.Size = New System.Drawing.Size(81, 57)
        Me.Frame5.TabIndex = 16
        Me.Frame5.TabStop = False
        '
        'cmdFindWS
        '
        Me.cmdFindWS.BackColor = System.Drawing.SystemColors.Control
        Me.cmdFindWS.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFindWS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFindWS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdFindWS.Location = New System.Drawing.Point(8, 16)
        Me.cmdFindWS.Name = "cmdFindWS"
        Me.cmdFindWS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdFindWS.Size = New System.Drawing.Size(65, 33)
        Me.cmdFindWS.TabIndex = 17
        Me.cmdFindWS.Text = "Find WS"
        Me.cmdFindWS.UseVisualStyleBackColor = False
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
        Me.Frame1.Size = New System.Drawing.Size(65, 57)
        Me.Frame1.TabIndex = 6
        Me.Frame1.TabStop = False
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
        Me.cmdExit.Size = New System.Drawing.Size(49, 33)
        Me.cmdExit.TabIndex = 7
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.cmdViewOrder)
        Me.Frame2.Controls.Add(Me.cmdViewCustomer)
        Me.Frame2.Controls.Add(Me.cmdViewWs)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.Color.Blue
        Me.Frame2.Location = New System.Drawing.Point(552, 0)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(233, 57)
        Me.Frame2.TabIndex = 4
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "GO TO"
        '
        'cmdViewOrder
        '
        Me.cmdViewOrder.BackColor = System.Drawing.SystemColors.Control
        Me.cmdViewOrder.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdViewOrder.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdViewOrder.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdViewOrder.Location = New System.Drawing.Point(173, 16)
        Me.cmdViewOrder.Name = "cmdViewOrder"
        Me.cmdViewOrder.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdViewOrder.Size = New System.Drawing.Size(57, 25)
        Me.cmdViewOrder.TabIndex = 15
        Me.cmdViewOrder.Text = "&Order"
        Me.cmdViewOrder.UseVisualStyleBackColor = False
        '
        'cmdViewCustomer
        '
        Me.cmdViewCustomer.BackColor = System.Drawing.SystemColors.Control
        Me.cmdViewCustomer.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdViewCustomer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdViewCustomer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdViewCustomer.Location = New System.Drawing.Point(96, 16)
        Me.cmdViewCustomer.Name = "cmdViewCustomer"
        Me.cmdViewCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdViewCustomer.Size = New System.Drawing.Size(73, 25)
        Me.cmdViewCustomer.TabIndex = 12
        Me.cmdViewCustomer.Text = "&Customer"
        Me.cmdViewCustomer.UseVisualStyleBackColor = False
        '
        'cmdViewWs
        '
        Me.cmdViewWs.BackColor = System.Drawing.SystemColors.Control
        Me.cmdViewWs.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdViewWs.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdViewWs.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdViewWs.Location = New System.Drawing.Point(3, 16)
        Me.cmdViewWs.Name = "cmdViewWs"
        Me.cmdViewWs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdViewWs.Size = New System.Drawing.Size(82, 25)
        Me.cmdViewWs.TabIndex = 5
        Me.cmdViewWs.Text = "&Worksheet"
        Me.cmdViewWs.UseVisualStyleBackColor = False
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.chkNoOrderWs)
        Me.Frame3.Controls.Add(Me.optAllWorksheets)
        Me.Frame3.Controls.Add(Me.optWkstNotTransmitted)
        Me.Frame3.Controls.Add(Me.optWkstTransmittedWaiting)
        Me.Frame3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.Color.Blue
        Me.Frame3.Location = New System.Drawing.Point(144, 0)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(414, 57)
        Me.Frame3.TabIndex = 0
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "DISPLAY OPTIONS "
        '
        'chkNoOrderWs
        '
        Me.chkNoOrderWs.BackColor = System.Drawing.SystemColors.Control
        Me.chkNoOrderWs.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkNoOrderWs.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNoOrderWs.ForeColor = System.Drawing.Color.Blue
        Me.chkNoOrderWs.Location = New System.Drawing.Point(32, 35)
        Me.chkNoOrderWs.Name = "chkNoOrderWs"
        Me.chkNoOrderWs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkNoOrderWs.Size = New System.Drawing.Size(273, 20)
        Me.chkNoOrderWs.TabIndex = 8
        Me.chkNoOrderWs.Text = "Don't show Worksheets that are orders"
        Me.chkNoOrderWs.UseVisualStyleBackColor = False
        '
        'optAllWorksheets
        '
        Me.optAllWorksheets.BackColor = System.Drawing.SystemColors.Control
        Me.optAllWorksheets.Checked = True
        Me.optAllWorksheets.Cursor = System.Windows.Forms.Cursors.Default
        Me.optAllWorksheets.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAllWorksheets.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optDisplay.SetIndex(Me.optAllWorksheets, CType(0, Short))
        Me.optAllWorksheets.Location = New System.Drawing.Point(32, 16)
        Me.optAllWorksheets.Name = "optAllWorksheets"
        Me.optAllWorksheets.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optAllWorksheets.Size = New System.Drawing.Size(113, 17)
        Me.optAllWorksheets.TabIndex = 3
        Me.optAllWorksheets.TabStop = True
        Me.optAllWorksheets.Text = "&All Worksheets"
        Me.optAllWorksheets.UseVisualStyleBackColor = False
        '
        'optWkstNotTransmitted
        '
        Me.optWkstNotTransmitted.BackColor = System.Drawing.SystemColors.Control
        Me.optWkstNotTransmitted.Cursor = System.Windows.Forms.Cursors.Default
        Me.optWkstNotTransmitted.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optWkstNotTransmitted.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optDisplay.SetIndex(Me.optWkstNotTransmitted, CType(1, Short))
        Me.optWkstNotTransmitted.Location = New System.Drawing.Point(152, 16)
        Me.optWkstNotTransmitted.Name = "optWkstNotTransmitted"
        Me.optWkstNotTransmitted.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optWkstNotTransmitted.Size = New System.Drawing.Size(113, 17)
        Me.optWkstNotTransmitted.TabIndex = 2
        Me.optWkstNotTransmitted.Text = "Not transmitted"
        Me.optWkstNotTransmitted.UseVisualStyleBackColor = False
        '
        'optWkstTransmittedWaiting
        '
        Me.optWkstTransmittedWaiting.BackColor = System.Drawing.SystemColors.Control
        Me.optWkstTransmittedWaiting.Cursor = System.Windows.Forms.Cursors.Default
        Me.optWkstTransmittedWaiting.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optWkstTransmittedWaiting.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optDisplay.SetIndex(Me.optWkstTransmittedWaiting, CType(2, Short))
        Me.optWkstTransmittedWaiting.Location = New System.Drawing.Point(264, 16)
        Me.optWkstTransmittedWaiting.Name = "optWkstTransmittedWaiting"
        Me.optWkstTransmittedWaiting.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optWkstTransmittedWaiting.Size = New System.Drawing.Size(145, 17)
        Me.optWkstTransmittedWaiting.TabIndex = 1
        Me.optWkstTransmittedWaiting.Text = "Transmitted - Waiting"
        Me.optWkstTransmittedWaiting.UseVisualStyleBackColor = False
        '
        'dtgWorksheets
        '
        Me.dtgWorksheets.AllowUserToAddRows = False
        Me.dtgWorksheets.AllowUserToDeleteRows = False
        Me.dtgWorksheets.AutoGenerateColumns = False
        Me.dtgWorksheets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgWorksheets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgWorksheets.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WorksheetidDataGridViewTextBoxColumn, Me.AllowmanualmaintDataGridViewCheckBoxColumn, Me.ReadyToXmitDataGridViewCheckBoxColumn, Me.XmittedDataGridViewCheckBoxColumn, Me.WscreatedateDataGridViewTextBoxColumn, Me.TransmittalstatusDataGridViewTextBoxColumn, Me.XmittedDateDataGridViewTextBoxColumn, Me.ValidationstatusDataGridViewTextBoxColumn, Me.ValidationdateDataGridViewTextBoxColumn, Me.OrdernoDataGridViewTextBoxColumn, Me.OrderdateDataGridViewTextBoxColumn, Me.CustpoDataGridViewTextBoxColumn, Me.ErrorlevelDataGridViewTextBoxColumn, Me.SeasonDataGridViewTextBoxColumn})
        Me.dtgWorksheets.DataSource = Me.WsordheadBindingSource
        Me.dtgWorksheets.Location = New System.Drawing.Point(0, 61)
        Me.dtgWorksheets.MultiSelect = False
        Me.dtgWorksheets.Name = "dtgWorksheets"
        Me.dtgWorksheets.ReadOnly = True
        Me.dtgWorksheets.RowHeadersVisible = False
        Me.dtgWorksheets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgWorksheets.Size = New System.Drawing.Size(785, 461)
        Me.dtgWorksheets.TabIndex = 17
        '
        'WorksheetidDataGridViewTextBoxColumn
        '
        Me.WorksheetidDataGridViewTextBoxColumn.DataPropertyName = "worksheet-id"
        Me.WorksheetidDataGridViewTextBoxColumn.HeaderText = "Worksheet No."
        Me.WorksheetidDataGridViewTextBoxColumn.Name = "WorksheetidDataGridViewTextBoxColumn"
        Me.WorksheetidDataGridViewTextBoxColumn.ReadOnly = True
        Me.WorksheetidDataGridViewTextBoxColumn.Width = 95
        '
        'AllowmanualmaintDataGridViewCheckBoxColumn
        '
        Me.AllowmanualmaintDataGridViewCheckBoxColumn.DataPropertyName = "allow-manual-maint"
        Me.AllowmanualmaintDataGridViewCheckBoxColumn.HeaderText = "Can Edit"
        Me.AllowmanualmaintDataGridViewCheckBoxColumn.Name = "AllowmanualmaintDataGridViewCheckBoxColumn"
        Me.AllowmanualmaintDataGridViewCheckBoxColumn.ReadOnly = True
        Me.AllowmanualmaintDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AllowmanualmaintDataGridViewCheckBoxColumn.Width = 32
        '
        'ReadyToXmitDataGridViewCheckBoxColumn
        '
        Me.ReadyToXmitDataGridViewCheckBoxColumn.DataPropertyName = "ReadyToXmit"
        Me.ReadyToXmitDataGridViewCheckBoxColumn.HeaderText = "ReadyToXmit"
        Me.ReadyToXmitDataGridViewCheckBoxColumn.Name = "ReadyToXmitDataGridViewCheckBoxColumn"
        Me.ReadyToXmitDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ReadyToXmitDataGridViewCheckBoxColumn.Width = 75
        '
        'XmittedDataGridViewCheckBoxColumn
        '
        Me.XmittedDataGridViewCheckBoxColumn.DataPropertyName = "Xmitted"
        Me.XmittedDataGridViewCheckBoxColumn.HeaderText = "Exported"
        Me.XmittedDataGridViewCheckBoxColumn.Name = "XmittedDataGridViewCheckBoxColumn"
        Me.XmittedDataGridViewCheckBoxColumn.ReadOnly = True
        Me.XmittedDataGridViewCheckBoxColumn.Width = 56
        '
        'WscreatedateDataGridViewTextBoxColumn
        '
        Me.WscreatedateDataGridViewTextBoxColumn.DataPropertyName = "ws-create-date"
        Me.WscreatedateDataGridViewTextBoxColumn.HeaderText = "Date Created"
        Me.WscreatedateDataGridViewTextBoxColumn.Name = "WscreatedateDataGridViewTextBoxColumn"
        Me.WscreatedateDataGridViewTextBoxColumn.ReadOnly = True
        Me.WscreatedateDataGridViewTextBoxColumn.Width = 88
        '
        'TransmittalstatusDataGridViewTextBoxColumn
        '
        Me.TransmittalstatusDataGridViewTextBoxColumn.DataPropertyName = "transmittal-status"
        Me.TransmittalstatusDataGridViewTextBoxColumn.HeaderText = "Xmit Status"
        Me.TransmittalstatusDataGridViewTextBoxColumn.Name = "TransmittalstatusDataGridViewTextBoxColumn"
        Me.TransmittalstatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.TransmittalstatusDataGridViewTextBoxColumn.Width = 79
        '
        'XmittedDateDataGridViewTextBoxColumn
        '
        Me.XmittedDateDataGridViewTextBoxColumn.DataPropertyName = "XmittedDate"
        Me.XmittedDateDataGridViewTextBoxColumn.HeaderText = "XmittedDate"
        Me.XmittedDateDataGridViewTextBoxColumn.Name = "XmittedDateDataGridViewTextBoxColumn"
        Me.XmittedDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.XmittedDateDataGridViewTextBoxColumn.Width = 89
        '
        'ValidationstatusDataGridViewTextBoxColumn
        '
        Me.ValidationstatusDataGridViewTextBoxColumn.DataPropertyName = "validation-status"
        Me.ValidationstatusDataGridViewTextBoxColumn.HeaderText = "Validation Status"
        Me.ValidationstatusDataGridViewTextBoxColumn.Name = "ValidationstatusDataGridViewTextBoxColumn"
        Me.ValidationstatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.ValidationstatusDataGridViewTextBoxColumn.Width = 103
        '
        'ValidationdateDataGridViewTextBoxColumn
        '
        Me.ValidationdateDataGridViewTextBoxColumn.DataPropertyName = "validation-date"
        Me.ValidationdateDataGridViewTextBoxColumn.HeaderText = "Validation Date"
        Me.ValidationdateDataGridViewTextBoxColumn.Name = "ValidationdateDataGridViewTextBoxColumn"
        Me.ValidationdateDataGridViewTextBoxColumn.ReadOnly = True
        Me.ValidationdateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ValidationdateDataGridViewTextBoxColumn.Width = 95
        '
        'OrdernoDataGridViewTextBoxColumn
        '
        Me.OrdernoDataGridViewTextBoxColumn.DataPropertyName = "order-no"
        Me.OrdernoDataGridViewTextBoxColumn.HeaderText = "Order No."
        Me.OrdernoDataGridViewTextBoxColumn.Name = "OrdernoDataGridViewTextBoxColumn"
        Me.OrdernoDataGridViewTextBoxColumn.ReadOnly = True
        Me.OrdernoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.OrdernoDataGridViewTextBoxColumn.Width = 73
        '
        'OrderdateDataGridViewTextBoxColumn
        '
        Me.OrderdateDataGridViewTextBoxColumn.DataPropertyName = "order-date"
        Me.OrderdateDataGridViewTextBoxColumn.HeaderText = "Order Date"
        Me.OrderdateDataGridViewTextBoxColumn.Name = "OrderdateDataGridViewTextBoxColumn"
        Me.OrderdateDataGridViewTextBoxColumn.ReadOnly = True
        Me.OrderdateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.OrderdateDataGridViewTextBoxColumn.Width = 79
        '
        'CustpoDataGridViewTextBoxColumn
        '
        Me.CustpoDataGridViewTextBoxColumn.DataPropertyName = "cust-po"
        Me.CustpoDataGridViewTextBoxColumn.HeaderText = "Customer PO #"
        Me.CustpoDataGridViewTextBoxColumn.Name = "CustpoDataGridViewTextBoxColumn"
        Me.CustpoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustpoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CustpoDataGridViewTextBoxColumn.Width = 88
        '
        'ErrorlevelDataGridViewTextBoxColumn
        '
        Me.ErrorlevelDataGridViewTextBoxColumn.DataPropertyName = "error-level"
        Me.ErrorlevelDataGridViewTextBoxColumn.HeaderText = "Error Level"
        Me.ErrorlevelDataGridViewTextBoxColumn.Name = "ErrorlevelDataGridViewTextBoxColumn"
        Me.ErrorlevelDataGridViewTextBoxColumn.ReadOnly = True
        Me.ErrorlevelDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ErrorlevelDataGridViewTextBoxColumn.Width = 79
        '
        'SeasonDataGridViewTextBoxColumn
        '
        Me.SeasonDataGridViewTextBoxColumn.DataPropertyName = "season"
        Me.SeasonDataGridViewTextBoxColumn.HeaderText = "Season"
        Me.SeasonDataGridViewTextBoxColumn.Name = "SeasonDataGridViewTextBoxColumn"
        Me.SeasonDataGridViewTextBoxColumn.ReadOnly = True
        Me.SeasonDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SeasonDataGridViewTextBoxColumn.Width = 69
        '
        'WsordheadBindingSource
        '
        Me.WsordheadBindingSource.AllowNew = False
        Me.WsordheadBindingSource.DataMember = "ws-ord-head"
        Me.WsordheadBindingSource.DataSource = Me.SaleForcDataSet
        '
        'SaleForcDataSet
        '
        Me.SaleForcDataSet.DataSetName = "SaleForcDataSet"
        Me.SaleForcDataSet.EnforceConstraints = False
        Me.SaleForcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Ws_ord_headTableAdapter
        '
        Me.Ws_ord_headTableAdapter.ClearBeforeFill = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AutoSize = False
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerNumber, Me.CustomerName, Me.WorksheetCount, Me.SortStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 528)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(797, 20)
        Me.StatusStrip1.TabIndex = 18
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'CustomerNumber
        '
        Me.CustomerNumber.BackColor = System.Drawing.SystemColors.Control
        Me.CustomerNumber.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.CustomerNumber.Name = "CustomerNumber"
        Me.CustomerNumber.Size = New System.Drawing.Size(110, 15)
        Me.CustomerNumber.Text = "Customer Number"
        '
        'CustomerName
        '
        Me.CustomerName.BackColor = System.Drawing.SystemColors.Control
        Me.CustomerName.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.Size = New System.Drawing.Size(95, 15)
        Me.CustomerName.Text = "CustomerName"
        '
        'WorksheetCount
        '
        Me.WorksheetCount.BackColor = System.Drawing.SystemColors.Control
        Me.WorksheetCount.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.WorksheetCount.Name = "WorksheetCount"
        Me.WorksheetCount.Size = New System.Drawing.Size(103, 15)
        Me.WorksheetCount.Text = "Worksheet Count"
        '
        'SortStatus
        '
        Me.SortStatus.BackColor = System.Drawing.SystemColors.Control
        Me.SortStatus.Name = "SortStatus"
        Me.SortStatus.Size = New System.Drawing.Size(96, 15)
        Me.SortStatus.Text = "Sort By Asc/Desc"
        '
        'frmListWs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(797, 548)
        Me.ControlBox = False
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.dtgWorksheets)
        Me.Controls.Add(Me.Frame5)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame3)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(4, 45)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListWs"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LIST: Worksheets"
        Me.Frame5.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.Frame3.ResumeLayout(False)
        CType(Me.optDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgWorksheets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WsordheadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleForcDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
#End Region
#Region "Upgrade Support"
    Friend WithEvents dtgWorksheets As System.Windows.Forms.DataGridView
    Friend WithEvents SaleForcDataSet As KC01.SaleForcDataSet
    Friend WithEvents WsordheadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ws_ord_headTableAdapter As KC01.SaleForcDataSetTableAdapters.ws_ord_headTableAdapter
    Friend WithEvents WorksheetidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AllowmanualmaintDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ReadyToXmitDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents XmittedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents WscreatedateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransmittalstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents XmittedDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValidationstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValidationdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrdernoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustpoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErrorlevelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeasonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents CustomerNumber As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents CustomerName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents WorksheetCount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SortStatus As System.Windows.Forms.ToolStripStatusLabel
#End Region
End Class