<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmResetXmit
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
	Private ADOBind_adoWsReset As VB6.MBindingCollection
    Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents btnResetXmit As System.Windows.Forms.Button
	Public WithEvents btnExit As System.Windows.Forms.Button
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnResetXmit = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.dgvResetWkst = New System.Windows.Forms.DataGridView
        Me.WorksheetidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.XmittedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.XmittedDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.XmittedTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WsordheadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaleForcDataSet = New KC01.SaleForcDataSet
        Me.Ws_ord_headTableAdapter = New KC01.SaleForcDataSetTableAdapters.ws_ord_headTableAdapter
        Me.Frame1.SuspendLayout()
        CType(Me.dgvResetWkst, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WsordheadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleForcDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.Color.Red
        Me.Frame1.Location = New System.Drawing.Point(440, 16)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(313, 241)
        Me.Frame1.TabIndex = 2
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "How to do it! "
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(16, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(281, 49)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = " Continue the process until all the worksheets to be transmitted have been marked" & _
            " and removed from the table."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(16, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(281, 57)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "3. If the worksheet number on the pop-up dialog box is correct, then click on {Ye" & _
            "s} button. The reset worksheet number will be removed from the table."
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(16, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(281, 33)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "2. Click on the button {Reset Transmit Status}"
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
        Me.Label1.Size = New System.Drawing.Size(289, 49)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "1. Select the worksheet you need to reset by clicking anywhere on the line with t" & _
            "he worksheet number."
        '
        'btnResetXmit
        '
        Me.btnResetXmit.BackColor = System.Drawing.SystemColors.Control
        Me.btnResetXmit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnResetXmit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetXmit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnResetXmit.Location = New System.Drawing.Point(208, 384)
        Me.btnResetXmit.Name = "btnResetXmit"
        Me.btnResetXmit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnResetXmit.Size = New System.Drawing.Size(169, 33)
        Me.btnResetXmit.TabIndex = 1
        Me.btnResetXmit.Text = "&Reset Transmit Status"
        Me.btnResetXmit.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(48, 384)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExit.Size = New System.Drawing.Size(121, 33)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'dgvResetWkst
        '
        Me.dgvResetWkst.AllowUserToAddRows = False
        Me.dgvResetWkst.AllowUserToDeleteRows = False
        Me.dgvResetWkst.AutoGenerateColumns = False
        Me.dgvResetWkst.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvResetWkst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResetWkst.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WorksheetidDataGridViewTextBoxColumn, Me.XmittedDataGridViewCheckBoxColumn, Me.XmittedDateDataGridViewTextBoxColumn, Me.XmittedTimeDataGridViewTextBoxColumn})
        Me.dgvResetWkst.DataSource = Me.WsordheadBindingSource
        Me.dgvResetWkst.Location = New System.Drawing.Point(9, 8)
        Me.dgvResetWkst.Name = "dgvResetWkst"
        Me.dgvResetWkst.ReadOnly = True
        Me.dgvResetWkst.RowHeadersVisible = False
        Me.dgvResetWkst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvResetWkst.Size = New System.Drawing.Size(419, 355)
        Me.dgvResetWkst.TabIndex = 3
        '
        'WorksheetidDataGridViewTextBoxColumn
        '
        Me.WorksheetidDataGridViewTextBoxColumn.DataPropertyName = "worksheet-id"
        Me.WorksheetidDataGridViewTextBoxColumn.HeaderText = "Worksheet ID"
        Me.WorksheetidDataGridViewTextBoxColumn.Name = "WorksheetidDataGridViewTextBoxColumn"
        Me.WorksheetidDataGridViewTextBoxColumn.ReadOnly = True
        Me.WorksheetidDataGridViewTextBoxColumn.Width = 96
        '
        'XmittedDataGridViewCheckBoxColumn
        '
        Me.XmittedDataGridViewCheckBoxColumn.DataPropertyName = "Xmitted"
        Me.XmittedDataGridViewCheckBoxColumn.HeaderText = "Xmitted"
        Me.XmittedDataGridViewCheckBoxColumn.Name = "XmittedDataGridViewCheckBoxColumn"
        Me.XmittedDataGridViewCheckBoxColumn.ReadOnly = True
        Me.XmittedDataGridViewCheckBoxColumn.Width = 48
        '
        'XmittedDateDataGridViewTextBoxColumn
        '
        Me.XmittedDateDataGridViewTextBoxColumn.DataPropertyName = "XmittedDate"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.XmittedDateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.XmittedDateDataGridViewTextBoxColumn.HeaderText = "XmittedDate"
        Me.XmittedDateDataGridViewTextBoxColumn.Name = "XmittedDateDataGridViewTextBoxColumn"
        Me.XmittedDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.XmittedDateDataGridViewTextBoxColumn.Width = 89
        '
        'XmittedTimeDataGridViewTextBoxColumn
        '
        Me.XmittedTimeDataGridViewTextBoxColumn.DataPropertyName = "XmittedTime"
        DataGridViewCellStyle2.Format = "t"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.XmittedTimeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.XmittedTimeDataGridViewTextBoxColumn.HeaderText = "XmittedTime"
        Me.XmittedTimeDataGridViewTextBoxColumn.Name = "XmittedTimeDataGridViewTextBoxColumn"
        Me.XmittedTimeDataGridViewTextBoxColumn.ReadOnly = True
        Me.XmittedTimeDataGridViewTextBoxColumn.Width = 89
        '
        'WsordheadBindingSource
        '
        Me.WsordheadBindingSource.DataMember = "ws-ord-head"
        Me.WsordheadBindingSource.DataSource = Me.SaleForcDataSet
        '
        'SaleForcDataSet
        '
        Me.SaleForcDataSet.DataSetName = "SaleForcDataSet"
        Me.SaleForcDataSet.EnforceConstraints = False
        Me.SaleForcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Ws_ord_headTableAdapter
        '
        Me.Ws_ord_headTableAdapter.ClearBeforeFill = True
        '
        'frmResetXmit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(782, 431)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvResetWkst)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.btnResetXmit)
        Me.Controls.Add(Me.btnExit)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(17, 105)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmResetXmit"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reset Transmitted Worksheets for Re-transmit"
        Me.Frame1.ResumeLayout(False)
        CType(Me.dgvResetWkst, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WsordheadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleForcDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
#Region "Upgrade Support"
    Friend WithEvents dgvResetWkst As System.Windows.Forms.DataGridView
    Friend WithEvents SaleForcDataSet As KC01.SaleForcDataSet
    Friend WithEvents WsordheadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ws_ord_headTableAdapter As KC01.SaleForcDataSetTableAdapters.ws_ord_headTableAdapter
    Friend WithEvents WorksheetidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents XmittedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents XmittedDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents XmittedTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
#End Region
End Class