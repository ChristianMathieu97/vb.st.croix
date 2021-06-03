<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmWsToXmitList
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
	Private ADOBind_adoWsToXmit As VB6.MBindingCollection
    Public WithEvents cmdCreateXmitFile As System.Windows.Forms.Button
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents cmdTransfer As System.Windows.Forms.Button
    Public WithEvents lstFilesToTransfer As System.Windows.Forms.ListBox
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents cmdExit As System.Windows.Forms.Button
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame3 = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.WorksheetidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AllowmanualmaintDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.WscreatedateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LastupdatedateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CustnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ShipnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RequestdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CompletedateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CanceldateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SeasonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OrdercodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CustpoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ViacodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OrdcomplDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.OrdernoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OrderdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TransmittalstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TransmittaldateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ValidationstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ValidationdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ErrorlevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LastUpdatedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReadyToXmitDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.CancelWSDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.SlsmnCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.XmittedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.XmittedDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.XmittedTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IsOrderReadyDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.IsNewCustomerDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.WsordheadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaleForcDataSet = New KC01.SaleForcDataSet
        Me.cmdCreateXmitFile = New System.Windows.Forms.Button
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me.cmdTransfer = New System.Windows.Forms.Button
        Me.lstFilesToTransfer = New System.Windows.Forms.ListBox
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.cmdExit = New System.Windows.Forms.Button
        Me.Ws_ord_headTableAdapter = New KC01.SaleForcDataSetTableAdapters.ws_ord_headTableAdapter
        Me.Frame3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WsordheadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleForcDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.DataGridView1)
        Me.Frame3.Controls.Add(Me.cmdCreateXmitFile)
        Me.Frame3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.Color.Blue
        Me.Frame3.Location = New System.Drawing.Point(0, 48)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(449, 278)
        Me.Frame3.TabIndex = 3
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "WORKSHEETS: Ready for Transmit Processing "
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WorksheetidDataGridViewTextBoxColumn, Me.AllowmanualmaintDataGridViewCheckBoxColumn, Me.WscreatedateDataGridViewTextBoxColumn, Me.LastupdatedateDataGridViewTextBoxColumn, Me.CustnoDataGridViewTextBoxColumn, Me.ShipnoDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.RequestdateDataGridViewTextBoxColumn, Me.CompletedateDataGridViewTextBoxColumn, Me.CanceldateDataGridViewTextBoxColumn, Me.SeasonDataGridViewTextBoxColumn, Me.OrdercodeDataGridViewTextBoxColumn, Me.CustpoDataGridViewTextBoxColumn, Me.DepartmentDataGridViewTextBoxColumn, Me.ViacodeDataGridViewTextBoxColumn, Me.OrdcomplDataGridViewCheckBoxColumn, Me.OrdernoDataGridViewTextBoxColumn, Me.OrderdateDataGridViewTextBoxColumn, Me.TransmittalstatusDataGridViewTextBoxColumn, Me.TransmittaldateDataGridViewTextBoxColumn, Me.ValidationstatusDataGridViewTextBoxColumn, Me.ValidationdateDataGridViewTextBoxColumn, Me.ErrorlevelDataGridViewTextBoxColumn, Me.LastUpdatedDataGridViewTextBoxColumn, Me.ReadyToXmitDataGridViewCheckBoxColumn, Me.CancelWSDataGridViewCheckBoxColumn, Me.SlsmnCodeDataGridViewTextBoxColumn, Me.XmittedDataGridViewCheckBoxColumn, Me.XmittedDateDataGridViewTextBoxColumn, Me.XmittedTimeDataGridViewTextBoxColumn, Me.IsOrderReadyDataGridViewCheckBoxColumn, Me.IsNewCustomerDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.WsordheadBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 47)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(438, 211)
        Me.DataGridView1.TabIndex = 9
        '
        'WorksheetidDataGridViewTextBoxColumn
        '
        Me.WorksheetidDataGridViewTextBoxColumn.DataPropertyName = "worksheet-id"
        Me.WorksheetidDataGridViewTextBoxColumn.HeaderText = "worksheet-id"
        Me.WorksheetidDataGridViewTextBoxColumn.Name = "WorksheetidDataGridViewTextBoxColumn"
        Me.WorksheetidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AllowmanualmaintDataGridViewCheckBoxColumn
        '
        Me.AllowmanualmaintDataGridViewCheckBoxColumn.DataPropertyName = "allow-manual-maint"
        Me.AllowmanualmaintDataGridViewCheckBoxColumn.HeaderText = "allow-manual-maint"
        Me.AllowmanualmaintDataGridViewCheckBoxColumn.Name = "AllowmanualmaintDataGridViewCheckBoxColumn"
        Me.AllowmanualmaintDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'WscreatedateDataGridViewTextBoxColumn
        '
        Me.WscreatedateDataGridViewTextBoxColumn.DataPropertyName = "ws-create-date"
        Me.WscreatedateDataGridViewTextBoxColumn.HeaderText = "ws-create-date"
        Me.WscreatedateDataGridViewTextBoxColumn.Name = "WscreatedateDataGridViewTextBoxColumn"
        Me.WscreatedateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastupdatedateDataGridViewTextBoxColumn
        '
        Me.LastupdatedateDataGridViewTextBoxColumn.DataPropertyName = "last-update-date"
        Me.LastupdatedateDataGridViewTextBoxColumn.HeaderText = "last-update-date"
        Me.LastupdatedateDataGridViewTextBoxColumn.Name = "LastupdatedateDataGridViewTextBoxColumn"
        Me.LastupdatedateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustnoDataGridViewTextBoxColumn
        '
        Me.CustnoDataGridViewTextBoxColumn.DataPropertyName = "cust-no"
        Me.CustnoDataGridViewTextBoxColumn.HeaderText = "cust-no"
        Me.CustnoDataGridViewTextBoxColumn.Name = "CustnoDataGridViewTextBoxColumn"
        Me.CustnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ShipnoDataGridViewTextBoxColumn
        '
        Me.ShipnoDataGridViewTextBoxColumn.DataPropertyName = "ship-no"
        Me.ShipnoDataGridViewTextBoxColumn.HeaderText = "ship-no"
        Me.ShipnoDataGridViewTextBoxColumn.Name = "ShipnoDataGridViewTextBoxColumn"
        Me.ShipnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RequestdateDataGridViewTextBoxColumn
        '
        Me.RequestdateDataGridViewTextBoxColumn.DataPropertyName = "request-date"
        Me.RequestdateDataGridViewTextBoxColumn.HeaderText = "request-date"
        Me.RequestdateDataGridViewTextBoxColumn.Name = "RequestdateDataGridViewTextBoxColumn"
        Me.RequestdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CompletedateDataGridViewTextBoxColumn
        '
        Me.CompletedateDataGridViewTextBoxColumn.DataPropertyName = "complete-date"
        Me.CompletedateDataGridViewTextBoxColumn.HeaderText = "complete-date"
        Me.CompletedateDataGridViewTextBoxColumn.Name = "CompletedateDataGridViewTextBoxColumn"
        Me.CompletedateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CanceldateDataGridViewTextBoxColumn
        '
        Me.CanceldateDataGridViewTextBoxColumn.DataPropertyName = "cancel-date"
        Me.CanceldateDataGridViewTextBoxColumn.HeaderText = "cancel-date"
        Me.CanceldateDataGridViewTextBoxColumn.Name = "CanceldateDataGridViewTextBoxColumn"
        Me.CanceldateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SeasonDataGridViewTextBoxColumn
        '
        Me.SeasonDataGridViewTextBoxColumn.DataPropertyName = "season"
        Me.SeasonDataGridViewTextBoxColumn.HeaderText = "season"
        Me.SeasonDataGridViewTextBoxColumn.Name = "SeasonDataGridViewTextBoxColumn"
        Me.SeasonDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OrdercodeDataGridViewTextBoxColumn
        '
        Me.OrdercodeDataGridViewTextBoxColumn.DataPropertyName = "order-code"
        Me.OrdercodeDataGridViewTextBoxColumn.HeaderText = "order-code"
        Me.OrdercodeDataGridViewTextBoxColumn.Name = "OrdercodeDataGridViewTextBoxColumn"
        Me.OrdercodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustpoDataGridViewTextBoxColumn
        '
        Me.CustpoDataGridViewTextBoxColumn.DataPropertyName = "cust-po"
        Me.CustpoDataGridViewTextBoxColumn.HeaderText = "cust-po"
        Me.CustpoDataGridViewTextBoxColumn.Name = "CustpoDataGridViewTextBoxColumn"
        Me.CustpoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DepartmentDataGridViewTextBoxColumn
        '
        Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "department"
        Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "department"
        Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
        Me.DepartmentDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ViacodeDataGridViewTextBoxColumn
        '
        Me.ViacodeDataGridViewTextBoxColumn.DataPropertyName = "via-code"
        Me.ViacodeDataGridViewTextBoxColumn.HeaderText = "via-code"
        Me.ViacodeDataGridViewTextBoxColumn.Name = "ViacodeDataGridViewTextBoxColumn"
        Me.ViacodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OrdcomplDataGridViewCheckBoxColumn
        '
        Me.OrdcomplDataGridViewCheckBoxColumn.DataPropertyName = "ord-compl"
        Me.OrdcomplDataGridViewCheckBoxColumn.HeaderText = "ord-compl"
        Me.OrdcomplDataGridViewCheckBoxColumn.Name = "OrdcomplDataGridViewCheckBoxColumn"
        Me.OrdcomplDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'OrdernoDataGridViewTextBoxColumn
        '
        Me.OrdernoDataGridViewTextBoxColumn.DataPropertyName = "order-no"
        Me.OrdernoDataGridViewTextBoxColumn.HeaderText = "order-no"
        Me.OrdernoDataGridViewTextBoxColumn.Name = "OrdernoDataGridViewTextBoxColumn"
        Me.OrdernoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OrderdateDataGridViewTextBoxColumn
        '
        Me.OrderdateDataGridViewTextBoxColumn.DataPropertyName = "order-date"
        Me.OrderdateDataGridViewTextBoxColumn.HeaderText = "order-date"
        Me.OrderdateDataGridViewTextBoxColumn.Name = "OrderdateDataGridViewTextBoxColumn"
        Me.OrderdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TransmittalstatusDataGridViewTextBoxColumn
        '
        Me.TransmittalstatusDataGridViewTextBoxColumn.DataPropertyName = "transmittal-status"
        Me.TransmittalstatusDataGridViewTextBoxColumn.HeaderText = "transmittal-status"
        Me.TransmittalstatusDataGridViewTextBoxColumn.Name = "TransmittalstatusDataGridViewTextBoxColumn"
        Me.TransmittalstatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TransmittaldateDataGridViewTextBoxColumn
        '
        Me.TransmittaldateDataGridViewTextBoxColumn.DataPropertyName = "transmittal-date"
        Me.TransmittaldateDataGridViewTextBoxColumn.HeaderText = "transmittal-date"
        Me.TransmittaldateDataGridViewTextBoxColumn.Name = "TransmittaldateDataGridViewTextBoxColumn"
        Me.TransmittaldateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValidationstatusDataGridViewTextBoxColumn
        '
        Me.ValidationstatusDataGridViewTextBoxColumn.DataPropertyName = "validation-status"
        Me.ValidationstatusDataGridViewTextBoxColumn.HeaderText = "validation-status"
        Me.ValidationstatusDataGridViewTextBoxColumn.Name = "ValidationstatusDataGridViewTextBoxColumn"
        Me.ValidationstatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValidationdateDataGridViewTextBoxColumn
        '
        Me.ValidationdateDataGridViewTextBoxColumn.DataPropertyName = "validation-date"
        Me.ValidationdateDataGridViewTextBoxColumn.HeaderText = "validation-date"
        Me.ValidationdateDataGridViewTextBoxColumn.Name = "ValidationdateDataGridViewTextBoxColumn"
        Me.ValidationdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ErrorlevelDataGridViewTextBoxColumn
        '
        Me.ErrorlevelDataGridViewTextBoxColumn.DataPropertyName = "error-level"
        Me.ErrorlevelDataGridViewTextBoxColumn.HeaderText = "error-level"
        Me.ErrorlevelDataGridViewTextBoxColumn.Name = "ErrorlevelDataGridViewTextBoxColumn"
        Me.ErrorlevelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastUpdatedDataGridViewTextBoxColumn
        '
        Me.LastUpdatedDataGridViewTextBoxColumn.DataPropertyName = "LastUpdated"
        Me.LastUpdatedDataGridViewTextBoxColumn.HeaderText = "LastUpdated"
        Me.LastUpdatedDataGridViewTextBoxColumn.Name = "LastUpdatedDataGridViewTextBoxColumn"
        Me.LastUpdatedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReadyToXmitDataGridViewCheckBoxColumn
        '
        Me.ReadyToXmitDataGridViewCheckBoxColumn.DataPropertyName = "ReadyToXmit"
        Me.ReadyToXmitDataGridViewCheckBoxColumn.HeaderText = "ReadyToXmit"
        Me.ReadyToXmitDataGridViewCheckBoxColumn.Name = "ReadyToXmitDataGridViewCheckBoxColumn"
        Me.ReadyToXmitDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'CancelWSDataGridViewCheckBoxColumn
        '
        Me.CancelWSDataGridViewCheckBoxColumn.DataPropertyName = "CancelWS"
        Me.CancelWSDataGridViewCheckBoxColumn.HeaderText = "CancelWS"
        Me.CancelWSDataGridViewCheckBoxColumn.Name = "CancelWSDataGridViewCheckBoxColumn"
        Me.CancelWSDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'SlsmnCodeDataGridViewTextBoxColumn
        '
        Me.SlsmnCodeDataGridViewTextBoxColumn.DataPropertyName = "SlsmnCode"
        Me.SlsmnCodeDataGridViewTextBoxColumn.HeaderText = "SlsmnCode"
        Me.SlsmnCodeDataGridViewTextBoxColumn.Name = "SlsmnCodeDataGridViewTextBoxColumn"
        Me.SlsmnCodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'XmittedDataGridViewCheckBoxColumn
        '
        Me.XmittedDataGridViewCheckBoxColumn.DataPropertyName = "Xmitted"
        Me.XmittedDataGridViewCheckBoxColumn.HeaderText = "Xmitted"
        Me.XmittedDataGridViewCheckBoxColumn.Name = "XmittedDataGridViewCheckBoxColumn"
        Me.XmittedDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'XmittedDateDataGridViewTextBoxColumn
        '
        Me.XmittedDateDataGridViewTextBoxColumn.DataPropertyName = "XmittedDate"
        Me.XmittedDateDataGridViewTextBoxColumn.HeaderText = "XmittedDate"
        Me.XmittedDateDataGridViewTextBoxColumn.Name = "XmittedDateDataGridViewTextBoxColumn"
        Me.XmittedDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'XmittedTimeDataGridViewTextBoxColumn
        '
        Me.XmittedTimeDataGridViewTextBoxColumn.DataPropertyName = "XmittedTime"
        Me.XmittedTimeDataGridViewTextBoxColumn.HeaderText = "XmittedTime"
        Me.XmittedTimeDataGridViewTextBoxColumn.Name = "XmittedTimeDataGridViewTextBoxColumn"
        Me.XmittedTimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IsOrderReadyDataGridViewCheckBoxColumn
        '
        Me.IsOrderReadyDataGridViewCheckBoxColumn.DataPropertyName = "IsOrderReady"
        Me.IsOrderReadyDataGridViewCheckBoxColumn.HeaderText = "IsOrderReady"
        Me.IsOrderReadyDataGridViewCheckBoxColumn.Name = "IsOrderReadyDataGridViewCheckBoxColumn"
        Me.IsOrderReadyDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'IsNewCustomerDataGridViewCheckBoxColumn
        '
        Me.IsNewCustomerDataGridViewCheckBoxColumn.DataPropertyName = "IsNewCustomer"
        Me.IsNewCustomerDataGridViewCheckBoxColumn.HeaderText = "IsNewCustomer"
        Me.IsNewCustomerDataGridViewCheckBoxColumn.Name = "IsNewCustomerDataGridViewCheckBoxColumn"
        Me.IsNewCustomerDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'WsordheadBindingSource
        '
        Me.WsordheadBindingSource.DataMember = "ws-ord-head"
        Me.WsordheadBindingSource.DataSource = Me.SaleForcDataSet
        '
        'SaleForcDataSet
        '
        Me.SaleForcDataSet.DataSetName = "SaleForcDataSet"
        Me.SaleForcDataSet.EnforceConstraints = False
        Me.SaleForcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmdCreateXmitFile
        '
        Me.cmdCreateXmitFile.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCreateXmitFile.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCreateXmitFile.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCreateXmitFile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCreateXmitFile.Location = New System.Drawing.Point(256, 16)
        Me.cmdCreateXmitFile.Name = "cmdCreateXmitFile"
        Me.cmdCreateXmitFile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCreateXmitFile.Size = New System.Drawing.Size(145, 25)
        Me.cmdCreateXmitFile.TabIndex = 5
        Me.cmdCreateXmitFile.Text = "&Create transmit file"
        Me.cmdCreateXmitFile.UseVisualStyleBackColor = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.cmdTransfer)
        Me.Frame2.Controls.Add(Me.lstFilesToTransfer)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.Color.Red
        Me.Frame2.Location = New System.Drawing.Point(0, 312)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(449, 209)
        Me.Frame2.TabIndex = 2
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "FILES: Ready For Transmission "
        '
        'cmdTransfer
        '
        Me.cmdTransfer.BackColor = System.Drawing.SystemColors.Control
        Me.cmdTransfer.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdTransfer.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTransfer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdTransfer.Location = New System.Drawing.Point(272, 80)
        Me.cmdTransfer.Name = "cmdTransfer"
        Me.cmdTransfer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdTransfer.Size = New System.Drawing.Size(97, 29)
        Me.cmdTransfer.TabIndex = 6
        Me.cmdTransfer.Text = "Transmit Files!"
        Me.cmdTransfer.UseVisualStyleBackColor = False
        '
        'lstFilesToTransfer
        '
        Me.lstFilesToTransfer.BackColor = System.Drawing.SystemColors.Window
        Me.lstFilesToTransfer.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstFilesToTransfer.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFilesToTransfer.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstFilesToTransfer.ItemHeight = 14
        Me.lstFilesToTransfer.Location = New System.Drawing.Point(24, 24)
        Me.lstFilesToTransfer.Name = "lstFilesToTransfer"
        Me.lstFilesToTransfer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstFilesToTransfer.Size = New System.Drawing.Size(201, 130)
        Me.lstFilesToTransfer.TabIndex = 4
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
        Me.Frame1.Size = New System.Drawing.Size(449, 49)
        Me.Frame1.TabIndex = 0
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
        Me.cmdExit.Size = New System.Drawing.Size(81, 25)
        Me.cmdExit.TabIndex = 1
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'Ws_ord_headTableAdapter
        '
        Me.Ws_ord_headTableAdapter.ClearBeforeFill = True
        '
        'frmWsToXmitList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(449, 521)
        Me.ControlBox = False
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(159, 93)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWsToXmitList"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LIST: Worksheets to Transmit"
        Me.Frame3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WsordheadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleForcDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame2.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region 
#Region "Upgrade Support"
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SaleForcDataSet As KC01.SaleForcDataSet
    Friend WithEvents WsordheadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ws_ord_headTableAdapter As KC01.SaleForcDataSetTableAdapters.ws_ord_headTableAdapter
    Friend WithEvents WorksheetidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AllowmanualmaintDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents WscreatedateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastupdatedateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShipnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RequestdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompletedateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CanceldateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeasonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrdercodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustpoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ViacodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrdcomplDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents OrdernoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransmittalstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransmittaldateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValidationstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValidationdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErrorlevelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastUpdatedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReadyToXmitDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CancelWSDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SlsmnCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents XmittedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents XmittedDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents XmittedTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsOrderReadyDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IsNewCustomerDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
#End Region
End Class