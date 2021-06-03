<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmWSDefaults
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
	Private ADOBind_adoOrderCode As VB6.MBindingCollection
	Private ADOBind_adoShipVia As VB6.MBindingCollection
	Private ADOBind_adoSalesDefaults As VB6.MBindingCollection
    Public WithEvents btnOK As System.Windows.Forms.Button
    Public WithEvents txtTerms As System.Windows.Forms.TextBox
    Public WithEvents chkShowAll As System.Windows.Forms.CheckBox
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents lblOrderCd As System.Windows.Forms.Label
    Public WithEvents lblSeasonCd As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents Label6 As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnOK = New System.Windows.Forms.Button
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.dtpCancelBy = New System.Windows.Forms.DateTimePicker
        Me.SlsmnBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaleForcDataSet = New KC01.SaleForcDataSet
        Me.dtpDelvBy = New System.Windows.Forms.DateTimePicker
        Me.lblShipViaCd = New System.Windows.Forms.Label
        Me.cmbOrderCode = New System.Windows.Forms.ComboBox
        Me.OrderTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbSeason = New System.Windows.Forms.ComboBox
        Me.SeasonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbShipVia = New System.Windows.Forms.ComboBox
        Me.ShipViaCodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtTerms = New System.Windows.Forms.TextBox
        Me.chkShowAll = New System.Windows.Forms.CheckBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblOrderCd = New System.Windows.Forms.Label
        Me.lblSeasonCd = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.ShipViaCodeTableAdapter = New KC01.SaleForcDataSetTableAdapters.ShipViaCodeTableAdapter
        Me.SalesmanTableAdapter = New KC01.SaleForcDataSetTableAdapters.SalesmanTableAdapter
        Me.SeasonTableAdapter = New KC01.SaleForcDataSetTableAdapters.SeasonTableAdapter
        Me.OrderTypeTableAdapter = New KC01.SaleForcDataSetTableAdapters.OrderTypeTableAdapter
        Me.Frame1.SuspendLayout()
        CType(Me.SlsmnBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleForcDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeasonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipViaCodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.SystemColors.Control
        Me.btnOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnOK.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnOK.Location = New System.Drawing.Point(208, 328)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnOK.Size = New System.Drawing.Size(81, 33)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.dtpCancelBy)
        Me.Frame1.Controls.Add(Me.dtpDelvBy)
        Me.Frame1.Controls.Add(Me.lblShipViaCd)
        Me.Frame1.Controls.Add(Me.cmbOrderCode)
        Me.Frame1.Controls.Add(Me.cmbSeason)
        Me.Frame1.Controls.Add(Me.cmbShipVia)
        Me.Frame1.Controls.Add(Me.txtTerms)
        Me.Frame1.Controls.Add(Me.chkShowAll)
        Me.Frame1.Controls.Add(Me.Label8)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.lblOrderCd)
        Me.Frame1.Controls.Add(Me.lblSeasonCd)
        Me.Frame1.Controls.Add(Me.Label5)
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.Color.Blue
        Me.Frame1.Location = New System.Drawing.Point(16, 8)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(489, 233)
        Me.Frame1.TabIndex = 1
        Me.Frame1.TabStop = False
        '
        'dtpCancelBy
        '
        Me.dtpCancelBy.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SlsmnBindingSource, "cancel-date", True))
        Me.dtpCancelBy.Location = New System.Drawing.Point(136, 51)
        Me.dtpCancelBy.Name = "dtpCancelBy"
        Me.dtpCancelBy.Size = New System.Drawing.Size(191, 20)
        Me.dtpCancelBy.TabIndex = 24
        '
        'SlsmnBindingSource
        '
        Me.SlsmnBindingSource.DataMember = "Salesman"
        Me.SlsmnBindingSource.DataSource = Me.SaleForcDataSet
        '
        'SaleForcDataSet
        '
        Me.SaleForcDataSet.DataSetName = "SaleForcDataSet"
        Me.SaleForcDataSet.EnforceConstraints = False
        Me.SaleForcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtpDelvBy
        '
        Me.dtpDelvBy.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SlsmnBindingSource, "request-date", True))
        Me.dtpDelvBy.Location = New System.Drawing.Point(136, 21)
        Me.dtpDelvBy.Name = "dtpDelvBy"
        Me.dtpDelvBy.Size = New System.Drawing.Size(191, 20)
        Me.dtpDelvBy.TabIndex = 23
        '
        'lblShipViaCd
        '
        Me.lblShipViaCd.BackColor = System.Drawing.SystemColors.Control
        Me.lblShipViaCd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShipViaCd.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShipViaCd.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShipViaCd.ForeColor = System.Drawing.Color.Blue
        Me.lblShipViaCd.Location = New System.Drawing.Point(127, 151)
        Me.lblShipViaCd.Name = "lblShipViaCd"
        Me.lblShipViaCd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblShipViaCd.Size = New System.Drawing.Size(81, 17)
        Me.lblShipViaCd.TabIndex = 22
        Me.lblShipViaCd.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmbOrderCode
        '
        Me.cmbOrderCode.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SlsmnBindingSource, "order-code", True))
        Me.cmbOrderCode.DataSource = Me.OrderTypeBindingSource
        Me.cmbOrderCode.DisplayMember = "Description"
        Me.cmbOrderCode.FormattingEnabled = True
        Me.cmbOrderCode.Location = New System.Drawing.Point(216, 121)
        Me.cmbOrderCode.Name = "cmbOrderCode"
        Me.cmbOrderCode.Size = New System.Drawing.Size(174, 22)
        Me.cmbOrderCode.TabIndex = 21
        Me.cmbOrderCode.ValueMember = "OrderCode"
        '
        'OrderTypeBindingSource
        '
        Me.OrderTypeBindingSource.DataMember = "OrderType"
        Me.OrderTypeBindingSource.DataSource = Me.SaleForcDataSet
        '
        'cmbSeason
        '
        Me.cmbSeason.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SlsmnBindingSource, "season", True))
        Me.cmbSeason.DataSource = Me.SeasonBindingSource
        Me.cmbSeason.DisplayMember = "Description"
        Me.cmbSeason.FormattingEnabled = True
        Me.cmbSeason.Location = New System.Drawing.Point(216, 89)
        Me.cmbSeason.Name = "cmbSeason"
        Me.cmbSeason.Size = New System.Drawing.Size(175, 22)
        Me.cmbSeason.TabIndex = 20
        Me.cmbSeason.ValueMember = "Season"
        '
        'SeasonBindingSource
        '
        Me.SeasonBindingSource.DataMember = "Season"
        Me.SeasonBindingSource.DataSource = Me.SaleForcDataSet
        '
        'cmbShipVia
        '
        Me.cmbShipVia.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SlsmnBindingSource, "ViaCode", True))
        Me.cmbShipVia.DataSource = Me.ShipViaCodeBindingSource
        Me.cmbShipVia.DisplayMember = "ViaDesc"
        Me.cmbShipVia.FormattingEnabled = True
        Me.cmbShipVia.Location = New System.Drawing.Point(218, 147)
        Me.cmbShipVia.Name = "cmbShipVia"
        Me.cmbShipVia.Size = New System.Drawing.Size(174, 22)
        Me.cmbShipVia.TabIndex = 19
        Me.cmbShipVia.ValueMember = "ViaCode"
        '
        'ShipViaCodeBindingSource
        '
        Me.ShipViaCodeBindingSource.DataMember = "ShipViaCode"
        Me.ShipViaCodeBindingSource.DataSource = Me.SaleForcDataSet
        '
        'txtTerms
        '
        Me.txtTerms.AcceptsReturn = True
        Me.txtTerms.BackColor = System.Drawing.SystemColors.Window
        Me.txtTerms.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTerms.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SlsmnBindingSource, "TermCode", True))
        Me.txtTerms.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTerms.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTerms.Location = New System.Drawing.Point(128, 184)
        Me.txtTerms.MaxLength = 0
        Me.txtTerms.Name = "txtTerms"
        Me.txtTerms.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTerms.Size = New System.Drawing.Size(161, 20)
        Me.txtTerms.TabIndex = 13
        '
        'chkShowAll
        '
        Me.chkShowAll.BackColor = System.Drawing.SystemColors.Control
        Me.chkShowAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkShowAll.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowAll.ForeColor = System.Drawing.Color.Red
        Me.chkShowAll.Location = New System.Drawing.Point(399, 124)
        Me.chkShowAll.Name = "chkShowAll"
        Me.chkShowAll.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkShowAll.Size = New System.Drawing.Size(73, 18)
        Me.chkShowAll.TabIndex = 7
        Me.chkShowAll.Text = "Show all"
        Me.chkShowAll.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(40, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(81, 17)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Terms Code:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(40, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Ship Via:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblOrderCd
        '
        Me.lblOrderCd.BackColor = System.Drawing.SystemColors.Control
        Me.lblOrderCd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOrderCd.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblOrderCd.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderCd.ForeColor = System.Drawing.Color.Blue
        Me.lblOrderCd.Location = New System.Drawing.Point(128, 120)
        Me.lblOrderCd.Name = "lblOrderCd"
        Me.lblOrderCd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOrderCd.Size = New System.Drawing.Size(81, 17)
        Me.lblOrderCd.TabIndex = 9
        Me.lblOrderCd.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSeasonCd
        '
        Me.lblSeasonCd.BackColor = System.Drawing.SystemColors.Control
        Me.lblSeasonCd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSeasonCd.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSeasonCd.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeasonCd.ForeColor = System.Drawing.Color.Blue
        Me.lblSeasonCd.Location = New System.Drawing.Point(128, 88)
        Me.lblSeasonCd.Name = "lblSeasonCd"
        Me.lblSeasonCd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSeasonCd.Size = New System.Drawing.Size(81, 17)
        Me.lblSeasonCd.TabIndex = 8
        Me.lblSeasonCd.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(40, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(81, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Order code:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(24, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(97, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Sales season:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(24, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(97, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Complete date:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(105, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Deliver order by:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(96, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(297, 41)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Entries in these fields will be used to pre-fill the same fields in a new workshe" & _
            "et"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ShipViaCodeTableAdapter
        '
        Me.ShipViaCodeTableAdapter.ClearBeforeFill = True
        '
        'SalesmanTableAdapter
        '
        Me.SalesmanTableAdapter.ClearBeforeFill = True
        '
        'SeasonTableAdapter
        '
        Me.SeasonTableAdapter.ClearBeforeFill = True
        '
        'OrderTypeTableAdapter
        '
        Me.OrderTypeTableAdapter.ClearBeforeFill = True
        '
        'frmWSDefaults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(517, 381)
        Me.ControlBox = False
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label6)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(59, 97)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWSDefaults"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Worksheet Defaults"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.SlsmnBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleForcDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeasonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipViaCodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
#Region "Upgrade Support"

    Friend WithEvents cmbShipVia As System.Windows.Forms.ComboBox
    Friend WithEvents SaleForcDataSet As KC01.SaleForcDataSet
    Friend WithEvents ShipViaCodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ShipViaCodeTableAdapter As KC01.SaleForcDataSetTableAdapters.ShipViaCodeTableAdapter
    Friend WithEvents SlsmnBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesmanTableAdapter As KC01.SaleForcDataSetTableAdapters.SalesmanTableAdapter
    Friend WithEvents cmbSeason As System.Windows.Forms.ComboBox
    Friend WithEvents SeasonBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SeasonTableAdapter As KC01.SaleForcDataSetTableAdapters.SeasonTableAdapter
    Friend WithEvents cmbOrderCode As System.Windows.Forms.ComboBox
    Friend WithEvents OrderTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderTypeTableAdapter As KC01.SaleForcDataSetTableAdapters.OrderTypeTableAdapter
    Public WithEvents lblShipViaCd As System.Windows.Forms.Label
    Friend WithEvents dtpDelvBy As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpCancelBy As System.Windows.Forms.DateTimePicker
#End Region
End Class