<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmErrMsgList
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
    Public WithEvents lblCustNo As System.Windows.Forms.Label
	Public WithEvents lblCustName As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents cmdPrintPreview As System.Windows.Forms.Button
	Public WithEvents chkDisplayAll As System.Windows.Forms.CheckBox
	Public WithEvents cmdCustomer As System.Windows.Forms.Button
	Public WithEvents cmdWorksheet As System.Windows.Forms.Button
	Public WithEvents chkPrtMaintOnly As System.Windows.Forms.CheckBox
	Public WithEvents cmdPrint As System.Windows.Forms.Button
	Public WithEvents cmdExit As System.Windows.Forms.Button
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me.lblCustNo = New System.Windows.Forms.Label
        Me.lblCustName = New System.Windows.Forms.Label
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.cmdPrintPreview = New System.Windows.Forms.Button
        Me.chkDisplayAll = New System.Windows.Forms.CheckBox
        Me.cmdCustomer = New System.Windows.Forms.Button
        Me.cmdWorksheet = New System.Windows.Forms.Button
        Me.chkPrtMaintOnly = New System.Windows.Forms.CheckBox
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.dtgWSErrMsg = New System.Windows.Forms.DataGridView
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        CType(Me.dtgWSErrMsg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.lblCustNo)
        Me.Frame2.Controls.Add(Me.lblCustName)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.Color.Blue
        Me.Frame2.Location = New System.Drawing.Point(16, 432)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(449, 49)
        Me.Frame2.TabIndex = 2
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "CUSTOMER "
        '
        'lblCustNo
        '
        Me.lblCustNo.BackColor = System.Drawing.SystemColors.Control
        Me.lblCustNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCustNo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCustNo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustNo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCustNo.Location = New System.Drawing.Point(24, 16)
        Me.lblCustNo.Name = "lblCustNo"
        Me.lblCustNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCustNo.Size = New System.Drawing.Size(113, 25)
        Me.lblCustNo.TabIndex = 4
        Me.lblCustNo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCustName
        '
        Me.lblCustName.BackColor = System.Drawing.SystemColors.Control
        Me.lblCustName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCustName.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCustName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCustName.Location = New System.Drawing.Point(152, 16)
        Me.lblCustName.Name = "lblCustName"
        Me.lblCustName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCustName.Size = New System.Drawing.Size(249, 25)
        Me.lblCustName.TabIndex = 3
        Me.lblCustName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.cmdPrintPreview)
        Me.Frame1.Controls.Add(Me.chkDisplayAll)
        Me.Frame1.Controls.Add(Me.cmdCustomer)
        Me.Frame1.Controls.Add(Me.cmdWorksheet)
        Me.Frame1.Controls.Add(Me.chkPrtMaintOnly)
        Me.Frame1.Controls.Add(Me.cmdPrint)
        Me.Frame1.Controls.Add(Me.cmdExit)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(0, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(481, 97)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        '
        'cmdPrintPreview
        '
        Me.cmdPrintPreview.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrintPreview.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrintPreview.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrintPreview.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrintPreview.Location = New System.Drawing.Point(188, 16)
        Me.cmdPrintPreview.Name = "cmdPrintPreview"
        Me.cmdPrintPreview.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrintPreview.Size = New System.Drawing.Size(105, 25)
        Me.cmdPrintPreview.TabIndex = 10
        Me.cmdPrintPreview.Text = "P&rint Preview"
        Me.cmdPrintPreview.UseVisualStyleBackColor = False
        '
        'chkDisplayAll
        '
        Me.chkDisplayAll.BackColor = System.Drawing.SystemColors.Control
        Me.chkDisplayAll.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDisplayAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkDisplayAll.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDisplayAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkDisplayAll.Location = New System.Drawing.Point(288, 72)
        Me.chkDisplayAll.Name = "chkDisplayAll"
        Me.chkDisplayAll.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDisplayAll.Size = New System.Drawing.Size(177, 17)
        Me.chkDisplayAll.TabIndex = 9
        Me.chkDisplayAll.Text = "Display all error messages"
        Me.chkDisplayAll.UseVisualStyleBackColor = False
        '
        'cmdCustomer
        '
        Me.cmdCustomer.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCustomer.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCustomer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCustomer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCustomer.Location = New System.Drawing.Point(392, 16)
        Me.cmdCustomer.Name = "cmdCustomer"
        Me.cmdCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCustomer.Size = New System.Drawing.Size(81, 25)
        Me.cmdCustomer.TabIndex = 8
        Me.cmdCustomer.Text = "&Customer"
        Me.cmdCustomer.UseVisualStyleBackColor = False
        '
        'cmdWorksheet
        '
        Me.cmdWorksheet.BackColor = System.Drawing.SystemColors.Control
        Me.cmdWorksheet.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdWorksheet.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdWorksheet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdWorksheet.Location = New System.Drawing.Point(302, 16)
        Me.cmdWorksheet.Name = "cmdWorksheet"
        Me.cmdWorksheet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdWorksheet.Size = New System.Drawing.Size(81, 25)
        Me.cmdWorksheet.TabIndex = 7
        Me.cmdWorksheet.Text = "&Worksheet"
        Me.cmdWorksheet.UseVisualStyleBackColor = False
        '
        'chkPrtMaintOnly
        '
        Me.chkPrtMaintOnly.BackColor = System.Drawing.SystemColors.Control
        Me.chkPrtMaintOnly.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkPrtMaintOnly.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPrtMaintOnly.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkPrtMaintOnly.Location = New System.Drawing.Point(120, 47)
        Me.chkPrtMaintOnly.Name = "chkPrtMaintOnly"
        Me.chkPrtMaintOnly.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkPrtMaintOnly.Size = New System.Drawing.Size(297, 18)
        Me.chkPrtMaintOnly.TabIndex = 6
        Me.chkPrtMaintOnly.Text = "Print only maintainable worksheets with errors."
        Me.chkPrtMaintOnly.UseVisualStyleBackColor = False
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Location = New System.Drawing.Point(98, 16)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(81, 25)
        Me.cmdPrint.TabIndex = 5
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.UseVisualStyleBackColor = False
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
        'dtgWSErrMsg
        '
        Me.dtgWSErrMsg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgWSErrMsg.Location = New System.Drawing.Point(2, 97)
        Me.dtgWSErrMsg.Name = "dtgWSErrMsg"
        Me.dtgWSErrMsg.ReadOnly = True
        Me.dtgWSErrMsg.RowHeadersVisible = False
        Me.dtgWSErrMsg.Size = New System.Drawing.Size(470, 321)
        Me.dtgWSErrMsg.TabIndex = 3
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'frmErrMsgList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(478, 511)
        Me.ControlBox = False
        Me.Controls.Add(Me.dtgWSErrMsg)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(100, 47)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmErrMsgList"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LIST: Worksheets with Error Messages"
        Me.Frame2.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        CType(Me.dtgWSErrMsg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtgWSErrMsg As System.Windows.Forms.DataGridView
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
#End Region 
#Region "Upgrade Support"
#End Region
End Class