<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmFilesToImportList
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
    Public WithEvents lstFilesToImport As System.Windows.Forms.ListBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lstFilesToImport = New System.Windows.Forms.ListBox()
        Me.lstFilesProcessed = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNoOfFiles = New System.Windows.Forms.TextBox()
        Me.txtFilesProcessed = New System.Windows.Forms.TextBox()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Frame3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstFilesToImport
        '
        Me.lstFilesToImport.BackColor = System.Drawing.SystemColors.Window
        Me.lstFilesToImport.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstFilesToImport.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFilesToImport.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstFilesToImport.ItemHeight = 14
        Me.lstFilesToImport.Location = New System.Drawing.Point(0, 144)
        Me.lstFilesToImport.Name = "lstFilesToImport"
        Me.lstFilesToImport.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstFilesToImport.Size = New System.Drawing.Size(189, 256)
        Me.lstFilesToImport.TabIndex = 0
        '
        'lstFilesProcessed
        '
        Me.lstFilesProcessed.BackColor = System.Drawing.SystemColors.Window
        Me.lstFilesProcessed.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstFilesProcessed.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFilesProcessed.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstFilesProcessed.ItemHeight = 14
        Me.lstFilesProcessed.Location = New System.Drawing.Point(195, 144)
        Me.lstFilesProcessed.Name = "lstFilesProcessed"
        Me.lstFilesProcessed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstFilesProcessed.Size = New System.Drawing.Size(187, 256)
        Me.lstFilesProcessed.TabIndex = 14
        Me.lstFilesProcessed.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-3, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 14)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Files to Process:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(196, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 14)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Files Processed:"
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.Label7)
        Me.Frame3.Controls.Add(Me.Label6)
        Me.Frame3.Controls.Add(Me.Label1)
        Me.Frame3.Controls.Add(Me.lblFileName)
        Me.Frame3.Controls.Add(Me.Label3)
        Me.Frame3.Controls.Add(Me.txtNoOfFiles)
        Me.Frame3.Controls.Add(Me.txtFilesProcessed)
        Me.Frame3.Controls.Add(Me.lblEnd)
        Me.Frame3.Controls.Add(Me.lblStart)
        Me.Frame3.Controls.Add(Me.Label2)
        Me.Frame3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.Color.Blue
        Me.Frame3.Location = New System.Drawing.Point(0, 3)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(386, 101)
        Me.Frame3.TabIndex = 61
        Me.Frame3.TabStop = False
        Me.Frame3.Text = " Statistics "
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(153, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(40, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "End:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(150, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(43, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Start:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(37, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 14)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Current File:"
        '
        'lblFileName
        '
        Me.lblFileName.BackColor = System.Drawing.SystemColors.Control
        Me.lblFileName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFileName.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFileName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileName.ForeColor = System.Drawing.Color.Blue
        Me.lblFileName.Location = New System.Drawing.Point(105, 60)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFileName.Size = New System.Drawing.Size(199, 25)
        Me.lblFileName.TabIndex = 9
        Me.lblFileName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(12, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(90, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Files Processed:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNoOfFiles
        '
        Me.txtNoOfFiles.Location = New System.Drawing.Point(105, 11)
        Me.txtNoOfFiles.Name = "txtNoOfFiles"
        Me.txtNoOfFiles.Size = New System.Drawing.Size(42, 20)
        Me.txtNoOfFiles.TabIndex = 13
        '
        'txtFilesProcessed
        '
        Me.txtFilesProcessed.Location = New System.Drawing.Point(105, 37)
        Me.txtFilesProcessed.Name = "txtFilesProcessed"
        Me.txtFilesProcessed.Size = New System.Drawing.Size(42, 20)
        Me.txtFilesProcessed.TabIndex = 12
        '
        'lblEnd
        '
        Me.lblEnd.BackColor = System.Drawing.SystemColors.Control
        Me.lblEnd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEnd.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEnd.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEnd.Location = New System.Drawing.Point(199, 37)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblEnd.Size = New System.Drawing.Size(105, 20)
        Me.lblEnd.TabIndex = 8
        Me.lblEnd.Text = "End"
        '
        'lblStart
        '
        Me.lblStart.BackColor = System.Drawing.SystemColors.Control
        Me.lblStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStart.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblStart.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStart.Location = New System.Drawing.Point(199, 11)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblStart.Size = New System.Drawing.Size(105, 15)
        Me.lblStart.TabIndex = 7
        Me.lblStart.Text = "Start"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(12, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Total Files:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'frmFilesToImportList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(388, 406)
        Me.ControlBox = False
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lstFilesProcessed)
        Me.Controls.Add(Me.lstFilesToImport)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Location = New System.Drawing.Point(98, 66)
        Me.Name = "frmFilesToImportList"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LIST: Files to Import"
        Me.Frame3.ResumeLayout(False)
        Me.Frame3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents lstFilesProcessed As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents lblFileName As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNoOfFiles As System.Windows.Forms.TextBox
    Friend WithEvents txtFilesProcessed As System.Windows.Forms.TextBox
    Public WithEvents lblEnd As System.Windows.Forms.Label
    Public WithEvents lblStart As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
#End Region
End Class