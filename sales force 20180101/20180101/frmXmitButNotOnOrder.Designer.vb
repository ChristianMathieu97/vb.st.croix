<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmXmitButNotOnOrder
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
	Private ADOBind_adoXmitButNotOnOrder As VB6.MBindingCollection
	Public WithEvents chkHideCancelled As System.Windows.Forms.CheckBox
	Public WithEvents cmdGetCustomer As System.Windows.Forms.Button
	Public WithEvents cmdGetWS As System.Windows.Forms.Button
	Public WithEvents cmdExit As System.Windows.Forms.Button
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.chkHideCancelled = New System.Windows.Forms.CheckBox
        Me.cmdGetCustomer = New System.Windows.Forms.Button
        Me.cmdGetWS = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.Frame3 = New System.Windows.Forms.GroupBox
        Me.dtgXmitButNotOnOrder = New System.Windows.Forms.DataGridView
        Me.Frame1.SuspendLayout()
        Me.Frame3.SuspendLayout()
        CType(Me.dtgXmitButNotOnOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.chkHideCancelled)
        Me.Frame1.Controls.Add(Me.cmdGetCustomer)
        Me.Frame1.Controls.Add(Me.cmdGetWS)
        Me.Frame1.Controls.Add(Me.cmdExit)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(0, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(449, 49)
        Me.Frame1.TabIndex = 1
        Me.Frame1.TabStop = False
        '
        'chkHideCancelled
        '
        Me.chkHideCancelled.BackColor = System.Drawing.SystemColors.Control
        Me.chkHideCancelled.Checked = True
        Me.chkHideCancelled.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkHideCancelled.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkHideCancelled.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHideCancelled.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkHideCancelled.Location = New System.Drawing.Point(128, 24)
        Me.chkHideCancelled.Name = "chkHideCancelled"
        Me.chkHideCancelled.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkHideCancelled.Size = New System.Drawing.Size(97, 17)
        Me.chkHideCancelled.TabIndex = 5
        Me.chkHideCancelled.Text = "Hide Cancelled "
        Me.chkHideCancelled.UseVisualStyleBackColor = False
        '
        'cmdGetCustomer
        '
        Me.cmdGetCustomer.BackColor = System.Drawing.SystemColors.Control
        Me.cmdGetCustomer.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGetCustomer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGetCustomer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGetCustomer.Location = New System.Drawing.Point(248, 16)
        Me.cmdGetCustomer.Name = "cmdGetCustomer"
        Me.cmdGetCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGetCustomer.Size = New System.Drawing.Size(89, 25)
        Me.cmdGetCustomer.TabIndex = 4
        Me.cmdGetCustomer.Text = "Customer"
        Me.cmdGetCustomer.UseVisualStyleBackColor = False
        '
        'cmdGetWS
        '
        Me.cmdGetWS.BackColor = System.Drawing.SystemColors.Control
        Me.cmdGetWS.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGetWS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGetWS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGetWS.Location = New System.Drawing.Point(344, 16)
        Me.cmdGetWS.Name = "cmdGetWS"
        Me.cmdGetWS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGetWS.Size = New System.Drawing.Size(89, 25)
        Me.cmdGetWS.TabIndex = 3
        Me.cmdGetWS.Text = "Worksheet"
        Me.cmdGetWS.UseVisualStyleBackColor = False
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
        Me.cmdExit.TabIndex = 2
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.dtgXmitButNotOnOrder)
        Me.Frame3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.Color.Blue
        Me.Frame3.Location = New System.Drawing.Point(0, 48)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(449, 425)
        Me.Frame3.TabIndex = 0
        Me.Frame3.TabStop = False
        '
        'dtgXmitButNotOnOrder
        '
        Me.dtgXmitButNotOnOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgXmitButNotOnOrder.Location = New System.Drawing.Point(6, 16)
        Me.dtgXmitButNotOnOrder.Name = "dtgXmitButNotOnOrder"
        Me.dtgXmitButNotOnOrder.RowHeadersVisible = False
        Me.dtgXmitButNotOnOrder.Size = New System.Drawing.Size(426, 394)
        Me.dtgXmitButNotOnOrder.TabIndex = 0
        '
        'frmXmitButNotOnOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(450, 474)
        Me.ControlBox = False
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Frame3)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(96, 67)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmXmitButNotOnOrder"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LIST: Worksheets Transmitted but Not On Order Yet"
        Me.Frame1.ResumeLayout(False)
        Me.Frame3.ResumeLayout(False)
        CType(Me.dtgXmitButNotOnOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtgXmitButNotOnOrder As System.Windows.Forms.DataGridView
#End Region 
#Region "Upgrade Support"
#End Region
End Class