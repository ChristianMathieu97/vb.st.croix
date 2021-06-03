<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPreviousWkstOrder
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
	Public WithEvents optViewAll As System.Windows.Forms.RadioButton
	Public WithEvents optViewOpen As System.Windows.Forms.RadioButton
	Public WithEvents cmdRefresh As System.Windows.Forms.Button
	Public WithEvents treWkstOrder As System.Windows.Forms.TreeView
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPreviousWkstOrder))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.optViewAll = New System.Windows.Forms.RadioButton
        Me.optViewOpen = New System.Windows.Forms.RadioButton
        Me.cmdRefresh = New System.Windows.Forms.Button
        Me.treWkstOrder = New System.Windows.Forms.TreeView
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpWksts = New System.Windows.Forms.DateTimePicker
        Me.dtpOrders = New System.Windows.Forms.DateTimePicker
        Me.SuspendLayout()
        '
        'optViewAll
        '
        Me.optViewAll.BackColor = System.Drawing.SystemColors.Control
        Me.optViewAll.Checked = True
        Me.optViewAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.optViewAll.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optViewAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optViewAll.Location = New System.Drawing.Point(360, 24)
        Me.optViewAll.Name = "optViewAll"
        Me.optViewAll.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optViewAll.Size = New System.Drawing.Size(105, 17)
        Me.optViewAll.TabIndex = 7
        Me.optViewAll.TabStop = True
        Me.optViewAll.Text = "View All Orders &"
        Me.optViewAll.UseVisualStyleBackColor = False
        '
        'optViewOpen
        '
        Me.optViewOpen.BackColor = System.Drawing.SystemColors.Control
        Me.optViewOpen.Cursor = System.Windows.Forms.Cursors.Default
        Me.optViewOpen.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optViewOpen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optViewOpen.Location = New System.Drawing.Point(360, 8)
        Me.optViewOpen.Name = "optViewOpen"
        Me.optViewOpen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optViewOpen.Size = New System.Drawing.Size(137, 17)
        Me.optViewOpen.TabIndex = 6
        Me.optViewOpen.TabStop = True
        Me.optViewOpen.Text = "View Only Open Orders"
        Me.optViewOpen.UseVisualStyleBackColor = False
        '
        'cmdRefresh
        '
        Me.cmdRefresh.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRefresh.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRefresh.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRefresh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRefresh.Location = New System.Drawing.Point(392, 48)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRefresh.Size = New System.Drawing.Size(73, 25)
        Me.cmdRefresh.TabIndex = 5
        Me.cmdRefresh.Text = "Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = False
        '
        'treWkstOrder
        '
        Me.treWkstOrder.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.treWkstOrder.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.treWkstOrder.LabelEdit = True
        Me.treWkstOrder.Location = New System.Drawing.Point(8, 80)
        Me.treWkstOrder.Name = "treWkstOrder"
        Me.treWkstOrder.Size = New System.Drawing.Size(521, 449)
        Me.treWkstOrder.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(217, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "View orders with an order date after:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(193, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "View worksheets created after:"
        '
        'dtpWksts
        '
        Me.dtpWksts.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpWksts.Location = New System.Drawing.Point(236, 12)
        Me.dtpWksts.Name = "dtpWksts"
        Me.dtpWksts.Size = New System.Drawing.Size(106, 20)
        Me.dtpWksts.TabIndex = 8
        '
        'dtpOrders
        '
        Me.dtpOrders.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpOrders.Location = New System.Drawing.Point(236, 44)
        Me.dtpOrders.Name = "dtpOrders"
        Me.dtpOrders.Size = New System.Drawing.Size(105, 20)
        Me.dtpOrders.TabIndex = 9
        '
        'frmPreviousWkstOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(540, 540)
        Me.Controls.Add(Me.dtpOrders)
        Me.Controls.Add(Me.dtpWksts)
        Me.Controls.Add(Me.optViewAll)
        Me.Controls.Add(Me.optViewOpen)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.treWkstOrder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.Name = "frmPreviousWkstOrder"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Latest Worksheets and Orders"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtpWksts As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpOrders As System.Windows.Forms.DateTimePicker
#End Region 
End Class