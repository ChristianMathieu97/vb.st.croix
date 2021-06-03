<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmOrdCodeSelect
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
    Public WithEvents chkShowAll As System.Windows.Forms.CheckBox
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdSelect As System.Windows.Forms.Button
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents lblOrderCode As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.chkShowAll = New System.Windows.Forms.CheckBox
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdSelect = New System.Windows.Forms.Button
        Me.lblOrderCode = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lvwOrdCode = New System.Windows.Forms.ListView
        Me.OrderTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaleForcDataSet = New KC01.SaleForcDataSet
        Me.OrderTypeTableAdapter = New KC01.SaleForcDataSetTableAdapters.OrderTypeTableAdapter
        Me.Frame1.SuspendLayout()
        CType(Me.OrderTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleForcDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.chkShowAll)
        Me.Frame1.Controls.Add(Me.cmdCancel)
        Me.Frame1.Controls.Add(Me.cmdSelect)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(193, 38)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(89, 113)
        Me.Frame1.TabIndex = 1
        Me.Frame1.TabStop = False
        '
        'chkShowAll
        '
        Me.chkShowAll.BackColor = System.Drawing.SystemColors.Control
        Me.chkShowAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkShowAll.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowAll.ForeColor = System.Drawing.Color.Red
        Me.chkShowAll.Location = New System.Drawing.Point(8, 56)
        Me.chkShowAll.Name = "chkShowAll"
        Me.chkShowAll.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkShowAll.Size = New System.Drawing.Size(73, 18)
        Me.chkShowAll.TabIndex = 4
        Me.chkShowAll.Text = "Show all"
        Me.chkShowAll.UseVisualStyleBackColor = False
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Location = New System.Drawing.Point(8, 80)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(73, 25)
        Me.cmdCancel.TabIndex = 3
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdSelect
        '
        Me.cmdSelect.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSelect.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSelect.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSelect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSelect.Location = New System.Drawing.Point(8, 16)
        Me.cmdSelect.Name = "cmdSelect"
        Me.cmdSelect.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSelect.Size = New System.Drawing.Size(73, 25)
        Me.cmdSelect.TabIndex = 2
        Me.cmdSelect.Text = "&Select"
        Me.cmdSelect.UseVisualStyleBackColor = False
        '
        'lblOrderCode
        '
        Me.lblOrderCode.BackColor = System.Drawing.SystemColors.Control
        Me.lblOrderCode.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblOrderCode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderCode.ForeColor = System.Drawing.Color.Red
        Me.lblOrderCode.Location = New System.Drawing.Point(168, 160)
        Me.lblOrderCode.Name = "lblOrderCode"
        Me.lblOrderCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOrderCode.Size = New System.Drawing.Size(97, 17)
        Me.lblOrderCode.TabIndex = 5
        Me.lblOrderCode.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(233, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SELECT ORDER CODE FROM LIST"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lvwOrdCode
        '
        Me.lvwOrdCode.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.OrderTypeBindingSource, "OrderCode", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.lvwOrdCode.Location = New System.Drawing.Point(9, 38)
        Me.lvwOrdCode.Name = "lvwOrdCode"
        Me.lvwOrdCode.Size = New System.Drawing.Size(162, 157)
        Me.lvwOrdCode.TabIndex = 6
        Me.lvwOrdCode.UseCompatibleStateImageBehavior = False
        Me.lvwOrdCode.View = System.Windows.Forms.View.Details
        '
        'OrderTypeBindingSource
        '
        Me.OrderTypeBindingSource.DataMember = "OrderType"
        Me.OrderTypeBindingSource.DataSource = Me.SaleForcDataSet
        '
        'SaleForcDataSet
        '
        Me.SaleForcDataSet.DataSetName = "SaleForcDataSet"
        Me.SaleForcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderTypeTableAdapter
        '
        Me.OrderTypeTableAdapter.ClearBeforeFill = True
        '
        'frmOrdCodeSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(310, 207)
        Me.ControlBox = False
        Me.Controls.Add(Me.lvwOrdCode)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.lblOrderCode)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(201, 207)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOrdCodeSelect"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order Code Selections"
        Me.Frame1.ResumeLayout(False)
        CType(Me.OrderTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleForcDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvwOrdCode As System.Windows.Forms.ListView
    Friend WithEvents SaleForcDataSet As KC01.SaleForcDataSet
    Friend WithEvents OrderTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderTypeTableAdapter As KC01.SaleForcDataSetTableAdapters.OrderTypeTableAdapter
#End Region 
End Class