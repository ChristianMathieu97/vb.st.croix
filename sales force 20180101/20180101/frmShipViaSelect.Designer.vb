<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmShipViaSelect
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
	Private ADOBind_adoShipVia As VB6.MBindingCollection
    Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents btnSelect As System.Windows.Forms.Button
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents lblShipViaCd As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.btnSelect = New System.Windows.Forms.Button
        Me.lblShipViaCd = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lstShipVia = New System.Windows.Forms.ListBox
        Me.ShipViaCodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaleForcDataSet = New KC01.SaleForcDataSet
        Me.ShipViaCodeTableAdapter = New KC01.SaleForcDataSetTableAdapters.ShipViaCodeTableAdapter
        Me.Frame1.SuspendLayout()
        CType(Me.ShipViaCodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleForcDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.cmdCancel)
        Me.Frame1.Controls.Add(Me.btnSelect)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(168, 40)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(89, 105)
        Me.Frame1.TabIndex = 1
        Me.Frame1.TabStop = False
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Location = New System.Drawing.Point(8, 48)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(73, 25)
        Me.cmdCancel.TabIndex = 3
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.SystemColors.Control
        Me.btnSelect.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSelect.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSelect.Location = New System.Drawing.Point(8, 16)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSelect.Size = New System.Drawing.Size(73, 25)
        Me.btnSelect.TabIndex = 2
        Me.btnSelect.Text = "&Select"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'lblShipViaCd
        '
        Me.lblShipViaCd.BackColor = System.Drawing.SystemColors.Control
        Me.lblShipViaCd.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShipViaCd.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShipViaCd.ForeColor = System.Drawing.Color.Red
        Me.lblShipViaCd.Location = New System.Drawing.Point(176, 152)
        Me.lblShipViaCd.Name = "lblShipViaCd"
        Me.lblShipViaCd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblShipViaCd.Size = New System.Drawing.Size(73, 17)
        Me.lblShipViaCd.TabIndex = 4
        Me.lblShipViaCd.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(249, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SELECT SHIPPING METHOD FROM LIST"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lstShipVia
        '
        Me.lstShipVia.DataSource = Me.ShipViaCodeBindingSource
        Me.lstShipVia.DisplayMember = "ViaDesc"
        Me.lstShipVia.FormattingEnabled = True
        Me.lstShipVia.ItemHeight = 14
        Me.lstShipVia.Location = New System.Drawing.Point(11, 40)
        Me.lstShipVia.Name = "lstShipVia"
        Me.lstShipVia.Size = New System.Drawing.Size(148, 158)
        Me.lstShipVia.TabIndex = 5
        Me.lstShipVia.ValueMember = "ViaCode"
        '
        'ShipViaCodeBindingSource
        '
        Me.ShipViaCodeBindingSource.DataMember = "ShipViaCode"
        Me.ShipViaCodeBindingSource.DataSource = Me.SaleForcDataSet
        '
        'SaleForcDataSet
        '
        Me.SaleForcDataSet.DataSetName = "SaleForcDataSet"
        Me.SaleForcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ShipViaCodeTableAdapter
        '
        Me.ShipViaCodeTableAdapter.ClearBeforeFill = True
        '
        'frmShipViaSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(277, 218)
        Me.ControlBox = False
        Me.Controls.Add(Me.lstShipVia)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.lblShipViaCd)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(204, 232)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmShipViaSelect"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ship Via Selections"
        Me.Frame1.ResumeLayout(False)
        CType(Me.ShipViaCodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleForcDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
#Region "Upgrade Support"
    Friend WithEvents lstShipVia As System.Windows.Forms.ListBox
    Friend WithEvents SaleForcDataSet As KC01.SaleForcDataSet
    Friend WithEvents ShipViaCodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ShipViaCodeTableAdapter As KC01.SaleForcDataSetTableAdapters.ShipViaCodeTableAdapter
#End Region
End Class