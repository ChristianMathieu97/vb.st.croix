<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCustItemRpt
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
	Public WithEvents Timer1 As System.Windows.Forms.Timer
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents frmOrderDates As System.Windows.Forms.GroupBox
	Public WithEvents cmbViewBy As System.Windows.Forms.ComboBox
	Public WithEvents optDescending As System.Windows.Forms.RadioButton
	Public WithEvents optAscending As System.Windows.Forms.RadioButton
	Public WithEvents frmView As System.Windows.Forms.GroupBox
	Public WithEvents cmdClear As System.Windows.Forms.Button
	Public WithEvents txtItem As System.Windows.Forms.TextBox
    Public WithEvents frmItem As System.Windows.Forms.GroupBox
    Public WithEvents imgCustItem As System.Windows.Forms.ImageList
    Public WithEvents treCustItem As System.Windows.Forms.TreeView
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustItemRpt))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmbViewBy = New System.Windows.Forms.ComboBox
        Me.optDescending = New System.Windows.Forms.RadioButton
        Me.optAscending = New System.Windows.Forms.RadioButton
        Me.txtItem = New System.Windows.Forms.TextBox
        Me.treCustItem = New System.Windows.Forms.TreeView
        Me.imgCustItem = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdRefresh = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.frmOrderDates = New System.Windows.Forms.GroupBox
        Me.dtpToOrderDate = New System.Windows.Forms.DateTimePicker
        Me.dtpFromOrderDate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.frmView = New System.Windows.Forms.GroupBox
        Me.frmItem = New System.Windows.Forms.GroupBox
        Me.txtItemDescription = New System.Windows.Forms.TextBox
        Me.cmdClear = New System.Windows.Forms.Button
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.bs1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblShipped = New System.Windows.Forms.Label
        Me.lblOpen = New System.Windows.Forms.Label
        Me.lblOrigOrd = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.frmOrderDates.SuspendLayout()
        Me.frmView.SuspendLayout()
        Me.frmItem.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbViewBy
        '
        Me.cmbViewBy.BackColor = System.Drawing.SystemColors.Window
        Me.cmbViewBy.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbViewBy.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbViewBy.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbViewBy.Location = New System.Drawing.Point(16, 16)
        Me.cmbViewBy.Name = "cmbViewBy"
        Me.cmbViewBy.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbViewBy.Size = New System.Drawing.Size(169, 22)
        Me.cmbViewBy.TabIndex = 8
        Me.cmbViewBy.Text = "Combo1"
        Me.ToolTip1.SetToolTip(Me.cmbViewBy, "Select how you would like to view the data")
        '
        'optDescending
        '
        Me.optDescending.BackColor = System.Drawing.SystemColors.Control
        Me.optDescending.Cursor = System.Windows.Forms.Cursors.Default
        Me.optDescending.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDescending.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optDescending.Location = New System.Drawing.Point(104, 48)
        Me.optDescending.Name = "optDescending"
        Me.optDescending.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optDescending.Size = New System.Drawing.Size(94, 22)
        Me.optDescending.TabIndex = 7
        Me.optDescending.TabStop = True
        Me.optDescending.Text = "Descending"
        Me.ToolTip1.SetToolTip(Me.optDescending, "Click here to sort results in descending order")
        Me.optDescending.UseVisualStyleBackColor = False
        '
        'optAscending
        '
        Me.optAscending.BackColor = System.Drawing.SystemColors.Control
        Me.optAscending.Checked = True
        Me.optAscending.Cursor = System.Windows.Forms.Cursors.Default
        Me.optAscending.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAscending.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optAscending.Location = New System.Drawing.Point(8, 48)
        Me.optAscending.Name = "optAscending"
        Me.optAscending.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optAscending.Size = New System.Drawing.Size(81, 17)
        Me.optAscending.TabIndex = 6
        Me.optAscending.TabStop = True
        Me.optAscending.Text = "Ascending"
        Me.ToolTip1.SetToolTip(Me.optAscending, "Click here to sort results in ascending order")
        Me.optAscending.UseVisualStyleBackColor = False
        '
        'txtItem
        '
        Me.txtItem.AcceptsReturn = True
        Me.txtItem.BackColor = System.Drawing.SystemColors.Window
        Me.txtItem.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtItem.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItem.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtItem.Location = New System.Drawing.Point(13, 22)
        Me.txtItem.MaxLength = 0
        Me.txtItem.Name = "txtItem"
        Me.txtItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtItem.Size = New System.Drawing.Size(152, 20)
        Me.txtItem.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtItem, "Enter the 10 digit item number here")
        '
        'treCustItem
        '
        Me.treCustItem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.treCustItem.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.treCustItem.ImageIndex = 0
        Me.treCustItem.ImageList = Me.imgCustItem
        Me.treCustItem.Location = New System.Drawing.Point(12, 111)
        Me.treCustItem.Name = "treCustItem"
        Me.treCustItem.SelectedImageIndex = 0
        Me.treCustItem.Size = New System.Drawing.Size(181, 415)
        Me.treCustItem.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.treCustItem, "This window shows the results of the item search.")
        '
        'imgCustItem
        '
        Me.imgCustItem.ImageStream = CType(resources.GetObject("imgCustItem.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgCustItem.TransparentColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.imgCustItem.Images.SetKeyName(0, "closed")
        Me.imgCustItem.Images.SetKeyName(1, "open")
        Me.imgCustItem.Images.SetKeyName(2, "order")
        '
        'cmdRefresh
        '
        Me.cmdRefresh.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRefresh.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRefresh.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRefresh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRefresh.Location = New System.Drawing.Point(715, 42)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRefresh.Size = New System.Drawing.Size(63, 25)
        Me.cmdRefresh.TabIndex = 10
        Me.cmdRefresh.Text = "&Refresh"
        Me.ToolTip1.SetToolTip(Me.cmdRefresh, "Click here to refresh the data")
        Me.cmdRefresh.UseVisualStyleBackColor = False
        Me.cmdRefresh.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'frmOrderDates
        '
        Me.frmOrderDates.BackColor = System.Drawing.SystemColors.Control
        Me.frmOrderDates.Controls.Add(Me.dtpToOrderDate)
        Me.frmOrderDates.Controls.Add(Me.dtpFromOrderDate)
        Me.frmOrderDates.Controls.Add(Me.Label2)
        Me.frmOrderDates.Controls.Add(Me.Label1)
        Me.frmOrderDates.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmOrderDates.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmOrderDates.Location = New System.Drawing.Point(450, 12)
        Me.frmOrderDates.Name = "frmOrderDates"
        Me.frmOrderDates.Padding = New System.Windows.Forms.Padding(0)
        Me.frmOrderDates.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmOrderDates.Size = New System.Drawing.Size(127, 93)
        Me.frmOrderDates.TabIndex = 9
        Me.frmOrderDates.TabStop = False
        Me.frmOrderDates.Text = "Order Dates"
        '
        'dtpToOrderDate
        '
        Me.dtpToOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpToOrderDate.Location = New System.Drawing.Point(14, 70)
        Me.dtpToOrderDate.Name = "dtpToOrderDate"
        Me.dtpToOrderDate.Size = New System.Drawing.Size(102, 20)
        Me.dtpToOrderDate.TabIndex = 13
        '
        'dtpFromOrderDate
        '
        Me.dtpFromOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFromOrderDate.Location = New System.Drawing.Point(14, 35)
        Me.dtpFromOrderDate.Name = "dtpFromOrderDate"
        Me.dtpFromOrderDate.Size = New System.Drawing.Size(102, 20)
        Me.dtpFromOrderDate.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(11, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(25, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "To:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(11, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(33, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "From:"
        '
        'frmView
        '
        Me.frmView.BackColor = System.Drawing.SystemColors.Control
        Me.frmView.Controls.Add(Me.cmbViewBy)
        Me.frmView.Controls.Add(Me.optDescending)
        Me.frmView.Controls.Add(Me.optAscending)
        Me.frmView.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmView.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmView.Location = New System.Drawing.Point(243, 12)
        Me.frmView.Name = "frmView"
        Me.frmView.Padding = New System.Windows.Forms.Padding(0)
        Me.frmView.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmView.Size = New System.Drawing.Size(201, 93)
        Me.frmView.TabIndex = 5
        Me.frmView.TabStop = False
        Me.frmView.Text = "View"
        '
        'frmItem
        '
        Me.frmItem.BackColor = System.Drawing.SystemColors.Control
        Me.frmItem.Controls.Add(Me.txtItemDescription)
        Me.frmItem.Controls.Add(Me.cmdClear)
        Me.frmItem.Controls.Add(Me.txtItem)
        Me.frmItem.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmItem.Location = New System.Drawing.Point(8, 8)
        Me.frmItem.Name = "frmItem"
        Me.frmItem.Padding = New System.Windows.Forms.Padding(0)
        Me.frmItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmItem.Size = New System.Drawing.Size(229, 97)
        Me.frmItem.TabIndex = 4
        Me.frmItem.TabStop = False
        Me.frmItem.Text = "StyleColorSize, StyleColor or Style:"
        '
        'txtItemDescription
        '
        Me.txtItemDescription.BackColor = System.Drawing.SystemColors.Control
        Me.txtItemDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtItemDescription.Location = New System.Drawing.Point(14, 47)
        Me.txtItemDescription.Name = "txtItemDescription"
        Me.txtItemDescription.Size = New System.Drawing.Size(203, 13)
        Me.txtItemDescription.TabIndex = 16
        '
        'cmdClear
        '
        Me.cmdClear.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClear.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClear.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClear.Location = New System.Drawing.Point(171, 17)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClear.Size = New System.Drawing.Size(46, 25)
        Me.cmdClear.TabIndex = 15
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = False
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(208, 111)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.Size = New System.Drawing.Size(566, 414)
        Me.dgv.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblShipped)
        Me.GroupBox1.Controls.Add(Me.lblOpen)
        Me.GroupBox1.Controls.Add(Me.lblOrigOrd)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(583, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(126, 93)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selection Totals"
        '
        'lblShipped
        '
        Me.lblShipped.AutoSize = True
        Me.lblShipped.Location = New System.Drawing.Point(86, 67)
        Me.lblShipped.Name = "lblShipped"
        Me.lblShipped.Size = New System.Drawing.Size(13, 14)
        Me.lblShipped.TabIndex = 5
        Me.lblShipped.Text = "0"
        '
        'lblOpen
        '
        Me.lblOpen.AutoSize = True
        Me.lblOpen.Location = New System.Drawing.Point(86, 44)
        Me.lblOpen.Name = "lblOpen"
        Me.lblOpen.Size = New System.Drawing.Size(13, 14)
        Me.lblOpen.TabIndex = 4
        Me.lblOpen.Text = "0"
        '
        'lblOrigOrd
        '
        Me.lblOrigOrd.AutoSize = True
        Me.lblOrigOrd.Location = New System.Drawing.Point(86, 20)
        Me.lblOrigOrd.Name = "lblOrigOrd"
        Me.lblOrigOrd.Size = New System.Drawing.Size(13, 14)
        Me.lblOrigOrd.TabIndex = 3
        Me.lblOrigOrd.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 14)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Shipped:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 14)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Open: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Ordered:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(422, 254)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(106, 36)
        Me.Panel1.TabIndex = 13
        Me.Panel1.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 14)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Searching Orders..."
        '
        'frmCustItemRpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(787, 538)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.frmOrderDates)
        Me.Controls.Add(Me.frmView)
        Me.Controls.Add(Me.frmItem)
        Me.Controls.Add(Me.treCustItem)
        Me.Controls.Add(Me.dgv)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "frmCustItemRpt"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Items Ordered Information"
        Me.frmOrderDates.ResumeLayout(False)
        Me.frmView.ResumeLayout(False)
        Me.frmItem.ResumeLayout(False)
        Me.frmItem.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtpToOrderDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFromOrderDate As System.Windows.Forms.DateTimePicker
    Public WithEvents cmdRefresh As System.Windows.Forms.Button
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents bs1 As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblShipped As System.Windows.Forms.Label
    Friend WithEvents lblOpen As System.Windows.Forms.Label
    Friend WithEvents lblOrigOrd As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtItemDescription As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
#End Region
End Class