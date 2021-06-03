<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmWsSentViaProComm
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
	Public WithEvents lstProCommXmit As System.Windows.Forms.ListBox
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents cmdExit As System.Windows.Forms.Button
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmWsSentViaProComm))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.lstProCommXmit = New System.Windows.Forms.ListBox
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.cmdExit = New System.Windows.Forms.Button
		Me.Frame2.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.BackColor = System.Drawing.Color.FromARGB(0, 0, 64)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "LIST: Worksheets that have been transmitted"
		Me.ClientSize = New System.Drawing.Size(446, 477)
		Me.Location = New System.Drawing.Point(153, 81)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmWsSentViaProComm"
		Me.Frame2.Text = "Transmitted Worksheets"
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.ForeColor = System.Drawing.Color.Red
		Me.Frame2.Size = New System.Drawing.Size(401, 401)
		Me.Frame2.Location = New System.Drawing.Point(24, 64)
		Me.Frame2.TabIndex = 2
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		Me.lstProCommXmit.Size = New System.Drawing.Size(201, 358)
		Me.lstProCommXmit.Location = New System.Drawing.Point(24, 24)
		Me.lstProCommXmit.TabIndex = 3
		Me.lstProCommXmit.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstProCommXmit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstProCommXmit.BackColor = System.Drawing.SystemColors.Window
		Me.lstProCommXmit.CausesValidation = True
		Me.lstProCommXmit.Enabled = True
		Me.lstProCommXmit.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lstProCommXmit.IntegralHeight = True
		Me.lstProCommXmit.Cursor = System.Windows.Forms.Cursors.Default
		Me.lstProCommXmit.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.lstProCommXmit.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lstProCommXmit.Sorted = False
		Me.lstProCommXmit.TabStop = True
		Me.lstProCommXmit.Visible = True
		Me.lstProCommXmit.MultiColumn = False
		Me.lstProCommXmit.Name = "lstProCommXmit"
		Me.Frame1.Size = New System.Drawing.Size(449, 49)
		Me.Frame1.Location = New System.Drawing.Point(0, 0)
		Me.Frame1.TabIndex = 0
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdExit.Text = "E&xit"
		Me.cmdExit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdExit.Size = New System.Drawing.Size(81, 25)
		Me.cmdExit.Location = New System.Drawing.Point(8, 16)
		Me.cmdExit.TabIndex = 1
		Me.cmdExit.BackColor = System.Drawing.SystemColors.Control
		Me.cmdExit.CausesValidation = True
		Me.cmdExit.Enabled = True
		Me.cmdExit.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdExit.TabStop = True
		Me.cmdExit.Name = "cmdExit"
		Me.Controls.Add(Frame2)
		Me.Controls.Add(Frame1)
		Me.Frame2.Controls.Add(lstProCommXmit)
		Me.Frame1.Controls.Add(cmdExit)
		Me.Frame2.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class