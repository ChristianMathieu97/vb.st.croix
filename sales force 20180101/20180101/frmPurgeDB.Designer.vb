<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPurgeDB
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
	Public WithEvents chkCustomers As System.Windows.Forms.CheckBox
	Public WithEvents Timer1 As System.Windows.Forms.Timer
	Public WithEvents lblWhatsHappening As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cmdExit As System.Windows.Forms.Button
	Public WithEvents cmdPurge As System.Windows.Forms.Button
	Public WithEvents txtDefPurgeMonths As System.Windows.Forms.TextBox
	Public WithEvents chkDefPurge As System.Windows.Forms.CheckBox
	Public WithEvents chkOrders As System.Windows.Forms.CheckBox
	Public WithEvents chkWorksheets As System.Windows.Forms.CheckBox
	Public WithEvents chkItems As System.Windows.Forms.CheckBox
    Public WithEvents lblCustomerStatus As System.Windows.Forms.Label
	Public WithEvents lblItemStatus As System.Windows.Forms.Label
	Public WithEvents lblWorksheetStatus As System.Windows.Forms.Label
	Public WithEvents lblOrderStatus As System.Windows.Forms.Label
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPurgeDB))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkCustomers = New System.Windows.Forms.CheckBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.lblWhatsHappening = New System.Windows.Forms.Label
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdPurge = New System.Windows.Forms.Button
        Me.txtDefPurgeMonths = New System.Windows.Forms.TextBox
        Me.chkDefPurge = New System.Windows.Forms.CheckBox
        Me.chkOrders = New System.Windows.Forms.CheckBox
        Me.chkWorksheets = New System.Windows.Forms.CheckBox
        Me.chkItems = New System.Windows.Forms.CheckBox
        Me.lblCustomerStatus = New System.Windows.Forms.Label
        Me.lblItemStatus = New System.Windows.Forms.Label
        Me.lblWorksheetStatus = New System.Windows.Forms.Label
        Me.lblOrderStatus = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.dtpOrder = New System.Windows.Forms.DateTimePicker
        Me.dtpWorksheet = New System.Windows.Forms.DateTimePicker
        Me.dtpItem = New System.Windows.Forms.DateTimePicker
        Me.dtpCustomer = New System.Windows.Forms.DateTimePicker
        Me.dtpOrderHistory = New System.Windows.Forms.DateTimePicker
        Me.dtpWorksheetHistory = New System.Windows.Forms.DateTimePicker
        Me.dtpCustomerHistory = New System.Windows.Forms.DateTimePicker
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkCustomers
        '
        Me.chkCustomers.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkCustomers.Checked = True
        Me.chkCustomers.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCustomers.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkCustomers.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCustomers.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.chkCustomers.Location = New System.Drawing.Point(48, 184)
        Me.chkCustomers.Name = "chkCustomers"
        Me.chkCustomers.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkCustomers.Size = New System.Drawing.Size(77, 17)
        Me.chkCustomers.TabIndex = 16
        Me.chkCustomers.Text = "Customers"
        Me.chkCustomers.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Frame1.Controls.Add(Me.lblWhatsHappening)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Frame1.Location = New System.Drawing.Point(40, 269)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(529, 57)
        Me.Frame1.TabIndex = 11
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Status"
        '
        'lblWhatsHappening
        '
        Me.lblWhatsHappening.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblWhatsHappening.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblWhatsHappening.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWhatsHappening.ForeColor = System.Drawing.Color.White
        Me.lblWhatsHappening.Location = New System.Drawing.Point(16, 24)
        Me.lblWhatsHappening.Name = "lblWhatsHappening"
        Me.lblWhatsHappening.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblWhatsHappening.Size = New System.Drawing.Size(501, 17)
        Me.lblWhatsHappening.TabIndex = 12
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdExit.Location = New System.Drawing.Point(304, 224)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExit.Size = New System.Drawing.Size(81, 25)
        Me.cmdExit.TabIndex = 10
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'cmdPurge
        '
        Me.cmdPurge.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPurge.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPurge.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPurge.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPurge.Location = New System.Drawing.Point(192, 224)
        Me.cmdPurge.Name = "cmdPurge"
        Me.cmdPurge.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPurge.Size = New System.Drawing.Size(81, 25)
        Me.cmdPurge.TabIndex = 9
        Me.cmdPurge.Text = "Purge"
        Me.cmdPurge.UseVisualStyleBackColor = False
        '
        'txtDefPurgeMonths
        '
        Me.txtDefPurgeMonths.AcceptsReturn = True
        Me.txtDefPurgeMonths.BackColor = System.Drawing.SystemColors.Window
        Me.txtDefPurgeMonths.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDefPurgeMonths.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDefPurgeMonths.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDefPurgeMonths.Location = New System.Drawing.Point(112, 368)
        Me.txtDefPurgeMonths.MaxLength = 0
        Me.txtDefPurgeMonths.Name = "txtDefPurgeMonths"
        Me.txtDefPurgeMonths.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDefPurgeMonths.Size = New System.Drawing.Size(25, 20)
        Me.txtDefPurgeMonths.TabIndex = 8
        Me.txtDefPurgeMonths.Text = "6"
        '
        'chkDefPurge
        '
        Me.chkDefPurge.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkDefPurge.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkDefPurge.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDefPurge.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.chkDefPurge.Location = New System.Drawing.Point(40, 376)
        Me.chkDefPurge.Name = "chkDefPurge"
        Me.chkDefPurge.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDefPurge.Size = New System.Drawing.Size(81, 17)
        Me.chkDefPurge.TabIndex = 7
        Me.chkDefPurge.Text = "Run every "
        Me.chkDefPurge.UseVisualStyleBackColor = False
        '
        'chkOrders
        '
        Me.chkOrders.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkOrders.Checked = True
        Me.chkOrders.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkOrders.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkOrders.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOrders.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.chkOrders.Location = New System.Drawing.Point(48, 64)
        Me.chkOrders.Name = "chkOrders"
        Me.chkOrders.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkOrders.Size = New System.Drawing.Size(65, 17)
        Me.chkOrders.TabIndex = 4
        Me.chkOrders.Text = "Orders"
        Me.chkOrders.UseVisualStyleBackColor = False
        '
        'chkWorksheets
        '
        Me.chkWorksheets.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkWorksheets.Checked = True
        Me.chkWorksheets.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkWorksheets.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkWorksheets.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWorksheets.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.chkWorksheets.Location = New System.Drawing.Point(48, 104)
        Me.chkWorksheets.Name = "chkWorksheets"
        Me.chkWorksheets.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkWorksheets.Size = New System.Drawing.Size(89, 17)
        Me.chkWorksheets.TabIndex = 3
        Me.chkWorksheets.Text = "Worksheets"
        Me.chkWorksheets.UseVisualStyleBackColor = False
        '
        'chkItems
        '
        Me.chkItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkItems.Checked = True
        Me.chkItems.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkItems.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkItems.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkItems.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.chkItems.Location = New System.Drawing.Point(48, 144)
        Me.chkItems.Name = "chkItems"
        Me.chkItems.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkItems.Size = New System.Drawing.Size(65, 17)
        Me.chkItems.TabIndex = 2
        Me.chkItems.Text = "Items"
        Me.chkItems.UseVisualStyleBackColor = False
        '
        'lblCustomerStatus
        '
        Me.lblCustomerStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCustomerStatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCustomerStatus.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerStatus.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblCustomerStatus.Location = New System.Drawing.Point(464, 184)
        Me.lblCustomerStatus.Name = "lblCustomerStatus"
        Me.lblCustomerStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCustomerStatus.Size = New System.Drawing.Size(97, 17)
        Me.lblCustomerStatus.TabIndex = 33
        Me.lblCustomerStatus.Text = "Not Purged"
        Me.lblCustomerStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblItemStatus
        '
        Me.lblItemStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblItemStatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblItemStatus.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemStatus.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblItemStatus.Location = New System.Drawing.Point(464, 144)
        Me.lblItemStatus.Name = "lblItemStatus"
        Me.lblItemStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblItemStatus.Size = New System.Drawing.Size(97, 17)
        Me.lblItemStatus.TabIndex = 32
        Me.lblItemStatus.Text = "Not Purged"
        Me.lblItemStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblWorksheetStatus
        '
        Me.lblWorksheetStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblWorksheetStatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblWorksheetStatus.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWorksheetStatus.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblWorksheetStatus.Location = New System.Drawing.Point(464, 104)
        Me.lblWorksheetStatus.Name = "lblWorksheetStatus"
        Me.lblWorksheetStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblWorksheetStatus.Size = New System.Drawing.Size(97, 17)
        Me.lblWorksheetStatus.TabIndex = 31
        Me.lblWorksheetStatus.Text = "Not Purged"
        Me.lblWorksheetStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblOrderStatus
        '
        Me.lblOrderStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblOrderStatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblOrderStatus.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderStatus.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblOrderStatus.Location = New System.Drawing.Point(464, 64)
        Me.lblOrderStatus.Name = "lblOrderStatus"
        Me.lblOrderStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOrderStatus.Size = New System.Drawing.Size(97, 17)
        Me.lblOrderStatus.TabIndex = 30
        Me.lblOrderStatus.Text = "Not Purged"
        Me.lblOrderStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label13.Location = New System.Drawing.Point(472, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(81, 17)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "File Status:"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label12.Location = New System.Drawing.Point(296, 184)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(41, 17)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "before"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label9.Location = New System.Drawing.Point(136, 184)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(42, 17)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "before"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label8.Location = New System.Drawing.Point(136, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(42, 17)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "before"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label7.Location = New System.Drawing.Point(296, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(41, 17)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "before"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label6.Location = New System.Drawing.Point(136, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(42, 17)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "before"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label5.Location = New System.Drawing.Point(296, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(41, 17)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "before"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label3.Location = New System.Drawing.Point(136, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "before"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.Location = New System.Drawing.Point(40, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Purge:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label4.Location = New System.Drawing.Point(312, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(113, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "History FIles:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(144, 376)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(145, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "months with default settings."
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label10.Location = New System.Drawing.Point(152, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(113, 17)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Current Files:"
        '
        'dtpOrder
        '
        Me.dtpOrder.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpOrder.Location = New System.Drawing.Point(184, 59)
        Me.dtpOrder.Name = "dtpOrder"
        Me.dtpOrder.Size = New System.Drawing.Size(106, 20)
        Me.dtpOrder.TabIndex = 34
        '
        'dtpWorksheet
        '
        Me.dtpWorksheet.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpWorksheet.Location = New System.Drawing.Point(184, 95)
        Me.dtpWorksheet.Name = "dtpWorksheet"
        Me.dtpWorksheet.Size = New System.Drawing.Size(105, 20)
        Me.dtpWorksheet.TabIndex = 35
        '
        'dtpItem
        '
        Me.dtpItem.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpItem.Location = New System.Drawing.Point(182, 135)
        Me.dtpItem.Name = "dtpItem"
        Me.dtpItem.Size = New System.Drawing.Size(106, 20)
        Me.dtpItem.TabIndex = 36
        '
        'dtpCustomer
        '
        Me.dtpCustomer.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCustomer.Location = New System.Drawing.Point(180, 175)
        Me.dtpCustomer.Name = "dtpCustomer"
        Me.dtpCustomer.Size = New System.Drawing.Size(107, 20)
        Me.dtpCustomer.TabIndex = 37
        '
        'dtpOrderHistory
        '
        Me.dtpOrderHistory.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpOrderHistory.Location = New System.Drawing.Point(343, 59)
        Me.dtpOrderHistory.Name = "dtpOrderHistory"
        Me.dtpOrderHistory.Size = New System.Drawing.Size(108, 20)
        Me.dtpOrderHistory.TabIndex = 38
        '
        'dtpWorksheetHistory
        '
        Me.dtpWorksheetHistory.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpWorksheetHistory.Location = New System.Drawing.Point(343, 94)
        Me.dtpWorksheetHistory.Name = "dtpWorksheetHistory"
        Me.dtpWorksheetHistory.Size = New System.Drawing.Size(107, 20)
        Me.dtpWorksheetHistory.TabIndex = 39
        '
        'dtpCustomerHistory
        '
        Me.dtpCustomerHistory.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCustomerHistory.Location = New System.Drawing.Point(343, 172)
        Me.dtpCustomerHistory.Name = "dtpCustomerHistory"
        Me.dtpCustomerHistory.Size = New System.Drawing.Size(106, 20)
        Me.dtpCustomerHistory.TabIndex = 40
        '
        'frmPurgeDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(612, 406)
        Me.Controls.Add(Me.dtpCustomerHistory)
        Me.Controls.Add(Me.dtpWorksheetHistory)
        Me.Controls.Add(Me.dtpOrderHistory)
        Me.Controls.Add(Me.dtpCustomer)
        Me.Controls.Add(Me.dtpItem)
        Me.Controls.Add(Me.dtpWorksheet)
        Me.Controls.Add(Me.dtpOrder)
        Me.Controls.Add(Me.chkCustomers)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdPurge)
        Me.Controls.Add(Me.txtDefPurgeMonths)
        Me.Controls.Add(Me.chkDefPurge)
        Me.Controls.Add(Me.chkOrders)
        Me.Controls.Add(Me.chkWorksheets)
        Me.Controls.Add(Me.chkItems)
        Me.Controls.Add(Me.lblCustomerStatus)
        Me.Controls.Add(Me.lblItemStatus)
        Me.Controls.Add(Me.lblWorksheetStatus)
        Me.Controls.Add(Me.lblOrderStatus)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(114, 207)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPurgeDB"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purge Database files"
        Me.Frame1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpOrder As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpWorksheet As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpItem As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpCustomer As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpOrderHistory As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpWorksheetHistory As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpCustomerHistory As System.Windows.Forms.DateTimePicker
#End Region 
End Class