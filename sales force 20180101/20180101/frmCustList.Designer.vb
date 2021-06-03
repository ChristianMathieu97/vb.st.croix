<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCustList
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
    'Private ADOBind_adoCustList As VB6.MBindingCollection
	Public WithEvents cmdFindCust As System.Windows.Forms.Button
	Public WithEvents Frame6 As System.Windows.Forms.GroupBox
	Public WithEvents cmdPrtPreview As System.Windows.Forms.Button
	Public WithEvents cmdPrint As System.Windows.Forms.Button
	Public WithEvents cmdClearAll As System.Windows.Forms.Button
	Public WithEvents cmdSelectAll As System.Windows.Forms.Button
	Public WithEvents Frame5 As System.Windows.Forms.GroupBox
	Public WithEvents cmdCustomer As System.Windows.Forms.Button
	Public WithEvents Frame4 As System.Windows.Forms.GroupBox
	Public WithEvents cmdExit As System.Windows.Forms.Button
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents chkViewActiveOnly As System.Windows.Forms.CheckBox
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents lblCustomerCount As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame6 = New System.Windows.Forms.GroupBox
        Me.cmdFindCust = New System.Windows.Forms.Button
        Me.Frame5 = New System.Windows.Forms.GroupBox
        Me.cmdPrtPreview = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cmdClearAll = New System.Windows.Forms.Button
        Me.cmdSelectAll = New System.Windows.Forms.Button
        Me.Frame4 = New System.Windows.Forms.GroupBox
        Me.cmdCustomer = New System.Windows.Forms.Button
        Me.Frame3 = New System.Windows.Forms.GroupBox
        Me.cmdExit = New System.Windows.Forms.Button
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.dtgCustList = New System.Windows.Forms.DataGridView
        Me.PrtSelectDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.CustnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TelephoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bndCustomers = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaleForcDataSet = New KC01.SaleForcDataSet
        Me.chkViewActiveOnly = New System.Windows.Forms.CheckBox
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me.SortByState = New System.Windows.Forms.RadioButton
        Me.SortByCity = New System.Windows.Forms.RadioButton
        Me.SortByName = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblCustomerCount = New System.Windows.Forms.Label
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.CustomerTableAdapter = New KC01.SaleForcDataSetTableAdapters.CustomerTableAdapter
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Frame6.SuspendLayout()
        Me.Frame5.SuspendLayout()
        Me.Frame4.SuspendLayout()
        Me.Frame3.SuspendLayout()
        Me.Frame1.SuspendLayout()
        CType(Me.dtgCustList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleForcDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame6
        '
        Me.Frame6.BackColor = System.Drawing.SystemColors.Control
        Me.Frame6.Controls.Add(Me.cmdFindCust)
        Me.Frame6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame6.Location = New System.Drawing.Point(96, 0)
        Me.Frame6.Name = "Frame6"
        Me.Frame6.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame6.Size = New System.Drawing.Size(97, 49)
        Me.Frame6.TabIndex = 17
        Me.Frame6.TabStop = False
        '
        'cmdFindCust
        '
        Me.cmdFindCust.BackColor = System.Drawing.SystemColors.Control
        Me.cmdFindCust.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFindCust.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFindCust.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdFindCust.Location = New System.Drawing.Point(16, 16)
        Me.cmdFindCust.Name = "cmdFindCust"
        Me.cmdFindCust.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdFindCust.Size = New System.Drawing.Size(65, 25)
        Me.cmdFindCust.TabIndex = 18
        Me.cmdFindCust.Text = "&Find"
        Me.cmdFindCust.UseVisualStyleBackColor = False
        '
        'Frame5
        '
        Me.Frame5.BackColor = System.Drawing.SystemColors.Control
        Me.Frame5.Controls.Add(Me.cmdPrtPreview)
        Me.Frame5.Controls.Add(Me.cmdPrint)
        Me.Frame5.Controls.Add(Me.cmdClearAll)
        Me.Frame5.Controls.Add(Me.cmdSelectAll)
        Me.Frame5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame5.ForeColor = System.Drawing.Color.Blue
        Me.Frame5.Location = New System.Drawing.Point(192, 0)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame5.Size = New System.Drawing.Size(393, 49)
        Me.Frame5.TabIndex = 9
        Me.Frame5.TabStop = False
        Me.Frame5.Text = "PRINTING"
        '
        'cmdPrtPreview
        '
        Me.cmdPrtPreview.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrtPreview.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrtPreview.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrtPreview.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrtPreview.Location = New System.Drawing.Point(96, 16)
        Me.cmdPrtPreview.Name = "cmdPrtPreview"
        Me.cmdPrtPreview.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrtPreview.Size = New System.Drawing.Size(105, 25)
        Me.cmdPrtPreview.TabIndex = 13
        Me.cmdPrtPreview.Text = "P&rint Preview"
        Me.cmdPrtPreview.UseVisualStyleBackColor = False
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Location = New System.Drawing.Point(16, 16)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(73, 25)
        Me.cmdPrint.TabIndex = 12
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'cmdClearAll
        '
        Me.cmdClearAll.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClearAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClearAll.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClearAll.Location = New System.Drawing.Point(208, 16)
        Me.cmdClearAll.Name = "cmdClearAll"
        Me.cmdClearAll.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClearAll.Size = New System.Drawing.Size(73, 25)
        Me.cmdClearAll.TabIndex = 11
        Me.cmdClearAll.Text = "&Clear All"
        Me.cmdClearAll.UseVisualStyleBackColor = False
        '
        'cmdSelectAll
        '
        Me.cmdSelectAll.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSelectAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSelectAll.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSelectAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSelectAll.Location = New System.Drawing.Point(296, 16)
        Me.cmdSelectAll.Name = "cmdSelectAll"
        Me.cmdSelectAll.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSelectAll.Size = New System.Drawing.Size(73, 25)
        Me.cmdSelectAll.TabIndex = 10
        Me.cmdSelectAll.Text = "&Select All"
        Me.cmdSelectAll.UseVisualStyleBackColor = False
        '
        'Frame4
        '
        Me.Frame4.BackColor = System.Drawing.SystemColors.Control
        Me.Frame4.Controls.Add(Me.cmdCustomer)
        Me.Frame4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame4.ForeColor = System.Drawing.Color.Blue
        Me.Frame4.Location = New System.Drawing.Point(584, 0)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame4.Size = New System.Drawing.Size(89, 49)
        Me.Frame4.TabIndex = 7
        Me.Frame4.TabStop = False
        Me.Frame4.Text = " GO TO"
        '
        'cmdCustomer
        '
        Me.cmdCustomer.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCustomer.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCustomer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCustomer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCustomer.Location = New System.Drawing.Point(8, 16)
        Me.cmdCustomer.Name = "cmdCustomer"
        Me.cmdCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCustomer.Size = New System.Drawing.Size(73, 25)
        Me.cmdCustomer.TabIndex = 8
        Me.cmdCustomer.Text = "C&ustomer"
        Me.cmdCustomer.UseVisualStyleBackColor = False
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.cmdExit)
        Me.Frame3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(0, 0)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(97, 49)
        Me.Frame3.TabIndex = 5
        Me.Frame3.TabStop = False
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdExit.Location = New System.Drawing.Point(16, 16)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExit.Size = New System.Drawing.Size(65, 25)
        Me.cmdExit.TabIndex = 6
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.dtgCustList)
        Me.Frame1.Controls.Add(Me.chkViewActiveOnly)
        Me.Frame1.Controls.Add(Me.Frame2)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.lblCustomerCount)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.Color.Blue
        Me.Frame1.Location = New System.Drawing.Point(0, 47)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(673, 489)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "CUSTOMER LIST "
        '
        'dtgCustList
        '
        Me.dtgCustList.AllowUserToAddRows = False
        Me.dtgCustList.AllowUserToDeleteRows = False
        Me.dtgCustList.AllowUserToOrderColumns = True
        Me.dtgCustList.AutoGenerateColumns = False
        Me.dtgCustList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgCustList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PrtSelectDataGridViewCheckBoxColumn, Me.CustnoDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.TelephoneDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.StDataGridViewTextBoxColumn})
        Me.dtgCustList.DataSource = Me.bndCustomers
        Me.dtgCustList.Location = New System.Drawing.Point(9, 66)
        Me.dtgCustList.MultiSelect = False
        Me.dtgCustList.Name = "dtgCustList"
        Me.dtgCustList.RowHeadersVisible = False
        Me.dtgCustList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgCustList.Size = New System.Drawing.Size(656, 420)
        Me.dtgCustList.TabIndex = 17
        '
        'PrtSelectDataGridViewCheckBoxColumn
        '
        Me.PrtSelectDataGridViewCheckBoxColumn.DataPropertyName = "PrtSelect"
        Me.PrtSelectDataGridViewCheckBoxColumn.HeaderText = "P"
        Me.PrtSelectDataGridViewCheckBoxColumn.Name = "PrtSelectDataGridViewCheckBoxColumn"
        Me.PrtSelectDataGridViewCheckBoxColumn.ToolTipText = "Print Customer?"
        Me.PrtSelectDataGridViewCheckBoxColumn.Width = 20
        '
        'CustnoDataGridViewTextBoxColumn
        '
        Me.CustnoDataGridViewTextBoxColumn.DataPropertyName = "Cust-no"
        Me.CustnoDataGridViewTextBoxColumn.HeaderText = "Cust No"
        Me.CustnoDataGridViewTextBoxColumn.Name = "CustnoDataGridViewTextBoxColumn"
        Me.CustnoDataGridViewTextBoxColumn.ToolTipText = "Customer number"
        Me.CustnoDataGridViewTextBoxColumn.Width = 75
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ToolTipText = "Customer name"
        Me.NameDataGridViewTextBoxColumn.Width = 200
        '
        'TelephoneDataGridViewTextBoxColumn
        '
        Me.TelephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone"
        Me.TelephoneDataGridViewTextBoxColumn.HeaderText = "Phone No"
        Me.TelephoneDataGridViewTextBoxColumn.Name = "TelephoneDataGridViewTextBoxColumn"
        Me.TelephoneDataGridViewTextBoxColumn.ToolTipText = "Customer phone number"
        Me.TelephoneDataGridViewTextBoxColumn.Width = 84
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        Me.CityDataGridViewTextBoxColumn.ToolTipText = "Customer city"
        Me.CityDataGridViewTextBoxColumn.Width = 125
        '
        'StDataGridViewTextBoxColumn
        '
        Me.StDataGridViewTextBoxColumn.DataPropertyName = "St"
        Me.StDataGridViewTextBoxColumn.HeaderText = "State"
        Me.StDataGridViewTextBoxColumn.Name = "StDataGridViewTextBoxColumn"
        Me.StDataGridViewTextBoxColumn.ToolTipText = "Customer state"
        Me.StDataGridViewTextBoxColumn.Width = 60
        '
        'bndCustomers
        '
        Me.bndCustomers.DataMember = "Customer"
        Me.bndCustomers.DataSource = Me.SaleForcDataSet
        '
        'SaleForcDataSet
        '
        Me.SaleForcDataSet.DataSetName = "SaleForcDataSet"
        Me.SaleForcDataSet.EnforceConstraints = False
        Me.SaleForcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'chkViewActiveOnly
        '
        Me.chkViewActiveOnly.BackColor = System.Drawing.SystemColors.Control
        Me.chkViewActiveOnly.Checked = True
        Me.chkViewActiveOnly.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkViewActiveOnly.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkViewActiveOnly.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkViewActiveOnly.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkViewActiveOnly.Location = New System.Drawing.Point(8, 32)
        Me.chkViewActiveOnly.Name = "chkViewActiveOnly"
        Me.chkViewActiveOnly.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkViewActiveOnly.Size = New System.Drawing.Size(105, 17)
        Me.chkViewActiveOnly.TabIndex = 14
        Me.chkViewActiveOnly.Text = "View Active Only"
        Me.chkViewActiveOnly.UseVisualStyleBackColor = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.SortByState)
        Me.Frame2.Controls.Add(Me.SortByCity)
        Me.Frame2.Controls.Add(Me.SortByName)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.Color.Blue
        Me.Frame2.Location = New System.Drawing.Point(120, 16)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(202, 41)
        Me.Frame2.TabIndex = 1
        Me.Frame2.TabStop = False
        Me.Frame2.Text = " SORT BY"
        '
        'SortByState
        '
        Me.SortByState.AutoSize = True
        Me.SortByState.Location = New System.Drawing.Point(132, 19)
        Me.SortByState.Name = "SortByState"
        Me.SortByState.Size = New System.Drawing.Size(53, 18)
        Me.SortByState.TabIndex = 2
        Me.SortByState.TabStop = True
        Me.SortByState.Text = "State"
        Me.SortByState.UseVisualStyleBackColor = True
        '
        'SortByCity
        '
        Me.SortByCity.AutoSize = True
        Me.SortByCity.Location = New System.Drawing.Point(80, 19)
        Me.SortByCity.Name = "SortByCity"
        Me.SortByCity.Size = New System.Drawing.Size(46, 18)
        Me.SortByCity.TabIndex = 1
        Me.SortByCity.TabStop = True
        Me.SortByCity.Text = "City"
        Me.SortByCity.UseVisualStyleBackColor = True
        '
        'SortByName
        '
        Me.SortByName.AutoSize = True
        Me.SortByName.Location = New System.Drawing.Point(17, 19)
        Me.SortByName.Name = "SortByName"
        Me.SortByName.Size = New System.Drawing.Size(56, 18)
        Me.SortByName.TabIndex = 0
        Me.SortByName.TabStop = True
        Me.SortByName.Text = "Name"
        Me.SortByName.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(42, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(66, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Customers"
        '
        'lblCustomerCount
        '
        Me.lblCustomerCount.BackColor = System.Drawing.SystemColors.Control
        Me.lblCustomerCount.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCustomerCount.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerCount.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCustomerCount.Location = New System.Drawing.Point(6, 13)
        Me.lblCustomerCount.Name = "lblCustomerCount"
        Me.lblCustomerCount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCustomerCount.Size = New System.Drawing.Size(30, 20)
        Me.lblCustomerCount.TabIndex = 15
        Me.lblCustomerCount.Text = "0"
        Me.lblCustomerCount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Cust-no"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cust No"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ToolTipText = "Customer number"
        Me.DataGridViewTextBoxColumn1.Width = 75
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ToolTipText = "Customer name"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Telephone"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Phone No"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ToolTipText = "Customer phone number"
        Me.DataGridViewTextBoxColumn3.Width = 84
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn4.HeaderText = "City"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ToolTipText = "Customer city"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "St"
        Me.DataGridViewTextBoxColumn5.HeaderText = "State"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ToolTipText = "Customer state"
        Me.DataGridViewTextBoxColumn5.Width = 60
        '
        'frmCustList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(671, 548)
        Me.ControlBox = False
        Me.Controls.Add(Me.Frame6)
        Me.Controls.Add(Me.Frame5)
        Me.Controls.Add(Me.Frame4)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(41, 44)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCustList"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CUSTOMER LIST"
        Me.Frame6.ResumeLayout(False)
        Me.Frame5.ResumeLayout(False)
        Me.Frame4.ResumeLayout(False)
        Me.Frame3.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        CType(Me.dtgCustList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleForcDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
#End Region
#Region "Upgrade Support"
    Friend WithEvents dtgCustList As System.Windows.Forms.DataGridView
    Friend WithEvents bndCustomers As System.Windows.Forms.BindingSource
    Friend WithEvents SaleForcDataSet As KC01.SaleForcDataSet
    Friend WithEvents CustomerTableAdapter As KC01.SaleForcDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrtSelectDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CustnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelephoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SortByState As System.Windows.Forms.RadioButton
    Friend WithEvents SortByCity As System.Windows.Forms.RadioButton
    Friend WithEvents SortByName As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
#End Region
End Class