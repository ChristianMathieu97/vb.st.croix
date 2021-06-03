<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSeasonSelect
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
	Private ADOBind_adoSeason As VB6.MBindingCollection
    Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdSelect As System.Windows.Forms.Button
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents lblSeason As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdSelect = New System.Windows.Forms.Button
        Me.lblSeason = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lstSeason = New System.Windows.Forms.ListBox
        Me.SeasonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaleForcDataSet = New KC01.SaleForcDataSet
        Me.SeasonTableAdapter = New KC01.SaleForcDataSetTableAdapters.SeasonTableAdapter
        Me.Frame1.SuspendLayout()
        CType(Me.SeasonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleForcDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.cmdCancel)
        Me.Frame1.Controls.Add(Me.cmdSelect)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(144, 40)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(89, 113)
        Me.Frame1.TabIndex = 1
        Me.Frame1.TabStop = False
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
        'lblSeason
        '
        Me.lblSeason.BackColor = System.Drawing.SystemColors.Control
        Me.lblSeason.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSeason.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeason.ForeColor = System.Drawing.Color.Red
        Me.lblSeason.Location = New System.Drawing.Point(152, 160)
        Me.lblSeason.Name = "lblSeason"
        Me.lblSeason.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSeason.Size = New System.Drawing.Size(65, 17)
        Me.lblSeason.TabIndex = 4
        Me.lblSeason.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(201, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SELECT SEASON FROM LIST"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lstSeason
        '
        Me.lstSeason.DataSource = Me.SeasonBindingSource
        Me.lstSeason.DisplayMember = "Description"
        Me.lstSeason.FormattingEnabled = True
        Me.lstSeason.ItemHeight = 14
        Me.lstSeason.Location = New System.Drawing.Point(12, 38)
        Me.lstSeason.Name = "lstSeason"
        Me.lstSeason.Size = New System.Drawing.Size(122, 158)
        Me.lstSeason.TabIndex = 7
        '
        'SeasonBindingSource
        '
        Me.SeasonBindingSource.DataMember = "Season"
        Me.SeasonBindingSource.DataSource = Me.SaleForcDataSet
        '
        'SaleForcDataSet
        '
        Me.SaleForcDataSet.DataSetName = "SaleForcDataSet"
        Me.SaleForcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SeasonTableAdapter
        '
        Me.SeasonTableAdapter.ClearBeforeFill = True
        '
        'frmSeasonSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(254, 207)
        Me.ControlBox = False
        Me.Controls.Add(Me.lstSeason)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.lblSeason)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(213, 177)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSeasonSelect"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Season Code Selections"
        Me.Frame1.ResumeLayout(False)
        CType(Me.SeasonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleForcDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
#Region "Upgrade Support"
    Friend WithEvents lstSeason As System.Windows.Forms.ListBox
    Friend WithEvents SaleForcDataSet As KC01.SaleForcDataSet
    Friend WithEvents SeasonBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SeasonTableAdapter As KC01.SaleForcDataSetTableAdapters.SeasonTableAdapter
#End Region
End Class