<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmXmitButNoVal
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
	Private ADOBind_adoXmitButNoVal As VB6.MBindingCollection
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
        Me.cmdGetCustomer = New System.Windows.Forms.Button
        Me.cmdGetWS = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.Frame3 = New System.Windows.Forms.GroupBox
        Me.dgvWSTransmittedNoReply = New System.Windows.Forms.DataGridView
        Me.WorksheetidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WscreatedateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CustnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.XmittedDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WsordheadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaleForcDataSet = New KC01.SaleForcDataSet
        Me.Ws_ord_headTableAdapter = New KC01.SaleForcDataSetTableAdapters.ws_ord_headTableAdapter
        Me.Frame1.SuspendLayout()
        Me.Frame3.SuspendLayout()
        CType(Me.dgvWSTransmittedNoReply, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WsordheadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleForcDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.cmdGetCustomer)
        Me.Frame1.Controls.Add(Me.cmdGetWS)
        Me.Frame1.Controls.Add(Me.cmdExit)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(0, -1)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(449, 50)
        Me.Frame1.TabIndex = 1
        Me.Frame1.TabStop = False
        '
        'cmdGetCustomer
        '
        Me.cmdGetCustomer.BackColor = System.Drawing.SystemColors.Control
        Me.cmdGetCustomer.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGetCustomer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGetCustomer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGetCustomer.Location = New System.Drawing.Point(224, 16)
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
        Me.cmdGetWS.Location = New System.Drawing.Point(328, 16)
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
        Me.Frame3.Controls.Add(Me.dgvWSTransmittedNoReply)
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
        'dgvWSTransmittedNoReply
        '
        Me.dgvWSTransmittedNoReply.AutoGenerateColumns = False
        Me.dgvWSTransmittedNoReply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWSTransmittedNoReply.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WorksheetidDataGridViewTextBoxColumn, Me.WscreatedateDataGridViewTextBoxColumn, Me.CustnoDataGridViewTextBoxColumn, Me.XmittedDateDataGridViewTextBoxColumn})
        Me.dgvWSTransmittedNoReply.DataSource = Me.WsordheadBindingSource
        Me.dgvWSTransmittedNoReply.Location = New System.Drawing.Point(9, 14)
        Me.dgvWSTransmittedNoReply.Name = "dgvWSTransmittedNoReply"
        Me.dgvWSTransmittedNoReply.RowHeadersVisible = False
        Me.dgvWSTransmittedNoReply.Size = New System.Drawing.Size(429, 397)
        Me.dgvWSTransmittedNoReply.TabIndex = 0
        '
        'WorksheetidDataGridViewTextBoxColumn
        '
        Me.WorksheetidDataGridViewTextBoxColumn.DataPropertyName = "worksheet-id"
        Me.WorksheetidDataGridViewTextBoxColumn.HeaderText = "Worksheet ID"
        Me.WorksheetidDataGridViewTextBoxColumn.Name = "WorksheetidDataGridViewTextBoxColumn"
        '
        'WscreatedateDataGridViewTextBoxColumn
        '
        Me.WscreatedateDataGridViewTextBoxColumn.DataPropertyName = "ws-create-date"
        Me.WscreatedateDataGridViewTextBoxColumn.HeaderText = "Created"
        Me.WscreatedateDataGridViewTextBoxColumn.Name = "WscreatedateDataGridViewTextBoxColumn"
        '
        'CustnoDataGridViewTextBoxColumn
        '
        Me.CustnoDataGridViewTextBoxColumn.DataPropertyName = "cust-no"
        Me.CustnoDataGridViewTextBoxColumn.HeaderText = "Customer No."
        Me.CustnoDataGridViewTextBoxColumn.Name = "CustnoDataGridViewTextBoxColumn"
        '
        'XmittedDateDataGridViewTextBoxColumn
        '
        Me.XmittedDateDataGridViewTextBoxColumn.DataPropertyName = "XmittedDate"
        Me.XmittedDateDataGridViewTextBoxColumn.HeaderText = "Xmitted Date"
        Me.XmittedDateDataGridViewTextBoxColumn.Name = "XmittedDateDataGridViewTextBoxColumn"
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
        'frmXmitButNoVal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(446, 474)
        Me.ControlBox = False
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Frame3)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(96, 67)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmXmitButNoVal"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LIST: Worksheets Transmitted but No Reply Yet"
        Me.Frame1.ResumeLayout(False)
        Me.Frame3.ResumeLayout(False)
        CType(Me.dgvWSTransmittedNoReply, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WsordheadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleForcDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
#Region "Upgrade Support"
    Friend WithEvents dgvWSTransmittedNoReply As System.Windows.Forms.DataGridView
    Friend WithEvents SaleForcDataSet As KC01.SaleForcDataSet
    Friend WithEvents WsordheadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ws_ord_headTableAdapter As KC01.SaleForcDataSetTableAdapters.ws_ord_headTableAdapter
    Friend WithEvents WorksheetidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WscreatedateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents XmittedDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
#End Region
End Class