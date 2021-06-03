<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmWorksheet
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
	Private ADOBind_adoWsTempItems As VB6.MBindingCollection
	Private ADOBind_adoWsErrMsg As VB6.MBindingCollection
	Public WithEvents txtWSMemo As System.Windows.Forms.TextBox
	Public WithEvents _tabMemosErrMsg_TabPage0 As System.Windows.Forms.TabPage
    Public WithEvents _tabMemosErrMsg_TabPage1 As System.Windows.Forms.TabPage
	Public WithEvents tabMemosErrMsg As System.Windows.Forms.TabControl
	Public WithEvents lblDateCreated As System.Windows.Forms.Label
	Public WithEvents lblLastUpDte As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents fraWsDates As System.Windows.Forms.GroupBox
	Public WithEvents chkXmitted As System.Windows.Forms.CheckBox
	Public WithEvents lblXmittedTime As System.Windows.Forms.Label
	Public WithEvents lblXmittedDate As System.Windows.Forms.Label
	Public WithEvents fraXmit As System.Windows.Forms.GroupBox
	Public WithEvents lblOrderDate As System.Windows.Forms.Label
	Public WithEvents lblOrderNo As System.Windows.Forms.Label
	Public WithEvents Label17 As System.Windows.Forms.Label
	Public WithEvents Label18 As System.Windows.Forms.Label
	Public WithEvents fraKCOrdInfo As System.Windows.Forms.GroupBox
	Public WithEvents lblXmitDate As System.Windows.Forms.Label
	Public WithEvents lblValStatus As System.Windows.Forms.Label
	Public WithEvents lblValDate As System.Windows.Forms.Label
	Public WithEvents lblXmitStatus As System.Windows.Forms.Label
	Public WithEvents lblErrorLevel As System.Windows.Forms.Label
	Public WithEvents lblErrMsg As System.Windows.Forms.Label
	Public WithEvents Label20 As System.Windows.Forms.Label
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents Label15 As System.Windows.Forms.Label
	Public WithEvents Label16 As System.Windows.Forms.Label
	Public WithEvents Label19 As System.Windows.Forms.Label
	Public WithEvents fraWSStatus As System.Windows.Forms.GroupBox
	Public WithEvents fraWSInfo As System.Windows.Forms.GroupBox
    Public WithEvents chkOrderComplete As System.Windows.Forms.CheckBox
	Public WithEvents txtPO As System.Windows.Forms.TextBox
	Public WithEvents mebDept As System.Windows.Forms.MaskedTextBox
	Public WithEvents cmdSeason As System.Windows.Forms.Button
	Public WithEvents cmdOrderCode As System.Windows.Forms.Button
	Public WithEvents cmdShipVia As System.Windows.Forms.Button
	Public WithEvents txtSeason As System.Windows.Forms.TextBox
	Public WithEvents txtOrderCd As System.Windows.Forms.TextBox
	Public WithEvents txtShipVia As System.Windows.Forms.TextBox
	Public WithEvents lblSlsmnCd As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents lblShipViaDesc As System.Windows.Forms.Label
	Public WithEvents lblSeasonDesc As System.Windows.Forms.Label
	Public WithEvents lblOrdTypeDesc As System.Windows.Forms.Label
	Public WithEvents fraDisplayCodes As System.Windows.Forms.GroupBox
	Public WithEvents lblHelpMsg As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents fraCustOrdInfo As System.Windows.Forms.GroupBox
	Public WithEvents fraStatusMemos As System.Windows.Forms.GroupBox
	Public WithEvents cmdEmailWorksheet As System.Windows.Forms.Button
	Public WithEvents cmdPrintPreview As System.Windows.Forms.Button
	Public WithEvents btnPrint As System.Windows.Forms.Button
	Public WithEvents btnItems As System.Windows.Forms.Button
	Public WithEvents btnExit As System.Windows.Forms.Button
	Public WithEvents btnEditWS As System.Windows.Forms.Button
    Public WithEvents fraButtons As System.Windows.Forms.GroupBox
    Public WithEvents _optCustIs_0 As System.Windows.Forms.RadioButton
	Public WithEvents _optCustIs_1 As System.Windows.Forms.RadioButton
	Public WithEvents fraCustType As System.Windows.Forms.GroupBox
	Public WithEvents lblShipTo As System.Windows.Forms.Label
	Public WithEvents lblCustomer As System.Windows.Forms.Label
	Public WithEvents Label26 As System.Windows.Forms.Label
	Public WithEvents Label21 As System.Windows.Forms.Label
	Public WithEvents lblCustShipNo As System.Windows.Forms.Label
	Public WithEvents lblCustNo As System.Windows.Forms.Label
	Public WithEvents fraCustRef As System.Windows.Forms.GroupBox
    Public WithEvents Label25 As System.Windows.Forms.Label
	Public WithEvents Label24 As System.Windows.Forms.Label
	Public WithEvents lblTotExtended As System.Windows.Forms.Label
	Public WithEvents lblTotQty As System.Windows.Forms.Label
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents _optViewBy_0 As System.Windows.Forms.RadioButton
	Public WithEvents _optViewBy_1 As System.Windows.Forms.RadioButton
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents _optSortBy_0 As System.Windows.Forms.RadioButton
	Public WithEvents _optSortBy_1 As System.Windows.Forms.RadioButton
	Public WithEvents fraSortBy As System.Windows.Forms.GroupBox
	Public WithEvents fraTable As System.Windows.Forms.GroupBox
    Public WithEvents cmdReturn As System.Windows.Forms.Button
	Public WithEvents txtStyle As System.Windows.Forms.TextBox
	Public WithEvents cmdClearStyleQty As System.Windows.Forms.Button
	Public WithEvents cmdNextStyle As System.Windows.Forms.Button
    Public WithEvents lblQtyToSell As System.Windows.Forms.Label
	Public WithEvents lblQtyPotential As System.Windows.Forms.Label
	Public WithEvents lblQtyOnHand As System.Windows.Forms.Label
	Public WithEvents imgPrevOrdered As System.Windows.Forms.PictureBox
	Public WithEvents lblItemPrice As System.Windows.Forms.Label
	Public WithEvents lblShipDates As System.Windows.Forms.Label
	Public WithEvents lblExtStylePrice As System.Windows.Forms.Label
	Public WithEvents Label30 As System.Windows.Forms.Label
	Public WithEvents lblTotStyleQty As System.Windows.Forms.Label
	Public WithEvents Label29 As System.Windows.Forms.Label
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents lblItemPrevOrder As System.Windows.Forms.Label
	Public WithEvents lblItemDescription As System.Windows.Forms.Label
    Public WithEvents fraItemMatrix As System.Windows.Forms.GroupBox
    Public WithEvents optCustIs As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
    Public WithEvents optSortBy As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
    Public WithEvents optViewBy As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWorksheet))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.fraStatusMemos = New System.Windows.Forms.GroupBox
        Me.fraWSInfo = New System.Windows.Forms.GroupBox
        Me.fraWsDates = New System.Windows.Forms.GroupBox
        Me.lblDateCreated = New System.Windows.Forms.Label
        Me.lblLastUpDte = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.fraXmit = New System.Windows.Forms.GroupBox
        Me.chkXmitted = New System.Windows.Forms.CheckBox
        Me.lblXmittedTime = New System.Windows.Forms.Label
        Me.lblXmittedDate = New System.Windows.Forms.Label
        Me.fraKCOrdInfo = New System.Windows.Forms.GroupBox
        Me.lblOrderDate = New System.Windows.Forms.Label
        Me.lblOrderNo = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.fraWSStatus = New System.Windows.Forms.GroupBox
        Me.lblXmitDate = New System.Windows.Forms.Label
        Me.lblValStatus = New System.Windows.Forms.Label
        Me.lblValDate = New System.Windows.Forms.Label
        Me.lblXmitStatus = New System.Windows.Forms.Label
        Me.lblErrorLevel = New System.Windows.Forms.Label
        Me.lblErrMsg = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.fraCustOrdInfo = New System.Windows.Forms.GroupBox
        Me.dtpCancelBy = New System.Windows.Forms.DateTimePicker
        Me.dtpDelvBy = New System.Windows.Forms.DateTimePicker
        Me.chkOrderComplete = New System.Windows.Forms.CheckBox
        Me.txtPO = New System.Windows.Forms.TextBox
        Me.mebDept = New System.Windows.Forms.MaskedTextBox
        Me.fraDisplayCodes = New System.Windows.Forms.GroupBox
        Me.cmdSeason = New System.Windows.Forms.Button
        Me.cmdOrderCode = New System.Windows.Forms.Button
        Me.cmdShipVia = New System.Windows.Forms.Button
        Me.txtSeason = New System.Windows.Forms.TextBox
        Me.txtOrderCd = New System.Windows.Forms.TextBox
        Me.txtShipVia = New System.Windows.Forms.TextBox
        Me.lblSlsmnCd = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblShipViaDesc = New System.Windows.Forms.Label
        Me.lblSeasonDesc = New System.Windows.Forms.Label
        Me.lblOrdTypeDesc = New System.Windows.Forms.Label
        Me.lblHelpMsg = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.tabMemosErrMsg = New System.Windows.Forms.TabControl
        Me._tabMemosErrMsg_TabPage0 = New System.Windows.Forms.TabPage
        Me.txtWSMemo = New System.Windows.Forms.TextBox
        Me._tabMemosErrMsg_TabPage1 = New System.Windows.Forms.TabPage
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WSErrorMsgBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaleForcDataSet = New KC01.SaleForcDataSet
        Me.fraButtons = New System.Windows.Forms.GroupBox
        Me.fraStatus = New System.Windows.Forms.GroupBox
        Me.chkReadyToXmit = New System.Windows.Forms.CheckBox
        Me.chkCancel = New System.Windows.Forms.CheckBox
        Me.cmdEmailWorksheet = New System.Windows.Forms.Button
        Me.cmdPrintPreview = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnItems = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnEditWS = New System.Windows.Forms.Button
        Me.fraCustRef = New System.Windows.Forms.GroupBox
        Me.chkMaintAllowed = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblWsNo = New System.Windows.Forms.Label
        Me.lblShipTo = New System.Windows.Forms.Label
        Me.lblCustomer = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.lblCustShipNo = New System.Windows.Forms.Label
        Me.lblCustNo = New System.Windows.Forms.Label
        Me.fraCustType = New System.Windows.Forms.GroupBox
        Me._optCustIs_0 = New System.Windows.Forms.RadioButton
        Me._optCustIs_1 = New System.Windows.Forms.RadioButton
        Me.fraTable = New System.Windows.Forms.GroupBox
        Me.dgvTempItems = New System.Windows.Forms.DataGridView
        Me.DeletedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ReadyForOrderDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ItemNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QtyOrderedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ExtendedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StyleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WSItemTempBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Frame3 = New System.Windows.Forms.GroupBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.lblTotExtended = New System.Windows.Forms.Label
        Me.lblTotQty = New System.Windows.Forms.Label
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me._optViewBy_0 = New System.Windows.Forms.RadioButton
        Me._optViewBy_1 = New System.Windows.Forms.RadioButton
        Me.fraSortBy = New System.Windows.Forms.GroupBox
        Me._optSortBy_0 = New System.Windows.Forms.RadioButton
        Me._optSortBy_1 = New System.Windows.Forms.RadioButton
        Me.fraItemMatrix = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmdReturn = New System.Windows.Forms.Button
        Me.txtStyle = New System.Windows.Forms.TextBox
        Me.cmdClearStyleQty = New System.Windows.Forms.Button
        Me.cmdNextStyle = New System.Windows.Forms.Button
        Me.lblQtyToSell = New System.Windows.Forms.Label
        Me.lblQtyPotential = New System.Windows.Forms.Label
        Me.lblQtyOnHand = New System.Windows.Forms.Label
        Me.imgPrevOrdered = New System.Windows.Forms.PictureBox
        Me.lblItemPrice = New System.Windows.Forms.Label
        Me.lblShipDates = New System.Windows.Forms.Label
        Me.lblExtStylePrice = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.lblTotStyleQty = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblItemPrevOrder = New System.Windows.Forms.Label
        Me.lblItemDescription = New System.Windows.Forms.Label
        Me.dgvColorSize = New System.Windows.Forms.DataGridView
        Me.optCustIs = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.optSortBy = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.optViewBy = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.WSItemTempTableAdapter = New KC01.SaleForcDataSetTableAdapters.WSItemTempTableAdapter
        Me.WSErrorMsgTableAdapter = New KC01.SaleForcDataSetTableAdapters.WSErrorMsgTableAdapter
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.fraStatusMemos.SuspendLayout()
        Me.fraWSInfo.SuspendLayout()
        Me.fraWsDates.SuspendLayout()
        Me.fraXmit.SuspendLayout()
        Me.fraKCOrdInfo.SuspendLayout()
        Me.fraWSStatus.SuspendLayout()
        Me.fraCustOrdInfo.SuspendLayout()
        Me.fraDisplayCodes.SuspendLayout()
        Me.tabMemosErrMsg.SuspendLayout()
        Me._tabMemosErrMsg_TabPage0.SuspendLayout()
        Me._tabMemosErrMsg_TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WSErrorMsgBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleForcDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraButtons.SuspendLayout()
        Me.fraStatus.SuspendLayout()
        Me.fraCustRef.SuspendLayout()
        Me.fraCustType.SuspendLayout()
        Me.fraTable.SuspendLayout()
        CType(Me.dgvTempItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WSItemTempBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame3.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.fraSortBy.SuspendLayout()
        Me.fraItemMatrix.SuspendLayout()
        CType(Me.imgPrevOrdered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvColorSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optCustIs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optSortBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optViewBy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fraStatusMemos
        '
        Me.fraStatusMemos.BackColor = System.Drawing.SystemColors.Control
        Me.fraStatusMemos.Controls.Add(Me.fraWSInfo)
        Me.fraStatusMemos.Controls.Add(Me.fraCustOrdInfo)
        Me.fraStatusMemos.Controls.Add(Me.tabMemosErrMsg)
        Me.fraStatusMemos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraStatusMemos.ForeColor = System.Drawing.Color.Blue
        Me.fraStatusMemos.Location = New System.Drawing.Point(0, 128)
        Me.fraStatusMemos.Name = "fraStatusMemos"
        Me.fraStatusMemos.Padding = New System.Windows.Forms.Padding(0)
        Me.fraStatusMemos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraStatusMemos.Size = New System.Drawing.Size(792, 414)
        Me.fraStatusMemos.TabIndex = 49
        Me.fraStatusMemos.TabStop = False
        '
        'fraWSInfo
        '
        Me.fraWSInfo.BackColor = System.Drawing.SystemColors.Control
        Me.fraWSInfo.Controls.Add(Me.fraWsDates)
        Me.fraWSInfo.Controls.Add(Me.fraXmit)
        Me.fraWSInfo.Controls.Add(Me.fraKCOrdInfo)
        Me.fraWSInfo.Controls.Add(Me.fraWSStatus)
        Me.fraWSInfo.Enabled = False
        Me.fraWSInfo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraWSInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraWSInfo.Location = New System.Drawing.Point(8, 129)
        Me.fraWSInfo.Name = "fraWSInfo"
        Me.fraWSInfo.Padding = New System.Windows.Forms.Padding(0)
        Me.fraWSInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraWSInfo.Size = New System.Drawing.Size(345, 288)
        Me.fraWSInfo.TabIndex = 50
        Me.fraWSInfo.TabStop = False
        '
        'fraWsDates
        '
        Me.fraWsDates.BackColor = System.Drawing.SystemColors.Control
        Me.fraWsDates.Controls.Add(Me.lblDateCreated)
        Me.fraWsDates.Controls.Add(Me.lblLastUpDte)
        Me.fraWsDates.Controls.Add(Me.Label3)
        Me.fraWsDates.Controls.Add(Me.Label13)
        Me.fraWsDates.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraWsDates.ForeColor = System.Drawing.Color.Blue
        Me.fraWsDates.Location = New System.Drawing.Point(8, 128)
        Me.fraWsDates.Name = "fraWsDates"
        Me.fraWsDates.Padding = New System.Windows.Forms.Padding(0)
        Me.fraWsDates.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraWsDates.Size = New System.Drawing.Size(329, 41)
        Me.fraWsDates.TabIndex = 61
        Me.fraWsDates.TabStop = False
        Me.fraWsDates.Text = " Dates "
        '
        'lblDateCreated
        '
        Me.lblDateCreated.BackColor = System.Drawing.SystemColors.Control
        Me.lblDateCreated.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDateCreated.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDateCreated.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateCreated.ForeColor = System.Drawing.Color.Red
        Me.lblDateCreated.Location = New System.Drawing.Point(64, 16)
        Me.lblDateCreated.Name = "lblDateCreated"
        Me.lblDateCreated.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDateCreated.Size = New System.Drawing.Size(65, 17)
        Me.lblDateCreated.TabIndex = 24
        '
        'lblLastUpDte
        '
        Me.lblLastUpDte.BackColor = System.Drawing.SystemColors.Control
        Me.lblLastUpDte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLastUpDte.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLastUpDte.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastUpDte.ForeColor = System.Drawing.Color.Red
        Me.lblLastUpDte.Location = New System.Drawing.Point(240, 16)
        Me.lblLastUpDte.Name = "lblLastUpDte"
        Me.lblLastUpDte.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLastUpDte.Size = New System.Drawing.Size(65, 17)
        Me.lblLastUpDte.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(152, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Last updated:"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(8, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(57, 17)
        Me.Label13.TabIndex = 62
        Me.Label13.Text = "Created:"
        '
        'fraXmit
        '
        Me.fraXmit.BackColor = System.Drawing.SystemColors.Control
        Me.fraXmit.Controls.Add(Me.chkXmitted)
        Me.fraXmit.Controls.Add(Me.lblXmittedTime)
        Me.fraXmit.Controls.Add(Me.lblXmittedDate)
        Me.fraXmit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraXmit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fraXmit.Location = New System.Drawing.Point(8, 224)
        Me.fraXmit.Name = "fraXmit"
        Me.fraXmit.Padding = New System.Windows.Forms.Padding(0)
        Me.fraXmit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraXmit.Size = New System.Drawing.Size(329, 41)
        Me.fraXmit.TabIndex = 60
        Me.fraXmit.TabStop = False
        Me.fraXmit.Text = "STATUS: Process for Transmit (Laptop Reference Only)"
        '
        'chkXmitted
        '
        Me.chkXmitted.BackColor = System.Drawing.SystemColors.Control
        Me.chkXmitted.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkXmitted.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkXmitted.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkXmitted.Location = New System.Drawing.Point(8, 16)
        Me.chkXmitted.Name = "chkXmitted"
        Me.chkXmitted.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkXmitted.Size = New System.Drawing.Size(89, 17)
        Me.chkXmitted.TabIndex = 28
        Me.chkXmitted.Text = "Processed"
        Me.chkXmitted.UseVisualStyleBackColor = False
        '
        'lblXmittedTime
        '
        Me.lblXmittedTime.BackColor = System.Drawing.SystemColors.Control
        Me.lblXmittedTime.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblXmittedTime.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXmittedTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblXmittedTime.Location = New System.Drawing.Point(200, 16)
        Me.lblXmittedTime.Name = "lblXmittedTime"
        Me.lblXmittedTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblXmittedTime.Size = New System.Drawing.Size(89, 17)
        Me.lblXmittedTime.TabIndex = 30
        Me.lblXmittedTime.Text = "Time"
        '
        'lblXmittedDate
        '
        Me.lblXmittedDate.BackColor = System.Drawing.SystemColors.Control
        Me.lblXmittedDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblXmittedDate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXmittedDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblXmittedDate.Location = New System.Drawing.Point(104, 16)
        Me.lblXmittedDate.Name = "lblXmittedDate"
        Me.lblXmittedDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblXmittedDate.Size = New System.Drawing.Size(73, 17)
        Me.lblXmittedDate.TabIndex = 29
        Me.lblXmittedDate.Text = "Date"
        '
        'fraKCOrdInfo
        '
        Me.fraKCOrdInfo.BackColor = System.Drawing.SystemColors.Control
        Me.fraKCOrdInfo.Controls.Add(Me.lblOrderDate)
        Me.fraKCOrdInfo.Controls.Add(Me.lblOrderNo)
        Me.fraKCOrdInfo.Controls.Add(Me.Label17)
        Me.fraKCOrdInfo.Controls.Add(Me.Label18)
        Me.fraKCOrdInfo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraKCOrdInfo.ForeColor = System.Drawing.Color.Blue
        Me.fraKCOrdInfo.Location = New System.Drawing.Point(8, 176)
        Me.fraKCOrdInfo.Name = "fraKCOrdInfo"
        Me.fraKCOrdInfo.Padding = New System.Windows.Forms.Padding(0)
        Me.fraKCOrdInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraKCOrdInfo.Size = New System.Drawing.Size(329, 41)
        Me.fraKCOrdInfo.TabIndex = 57
        Me.fraKCOrdInfo.TabStop = False
        Me.fraKCOrdInfo.Text = " KC Order Information "
        '
        'lblOrderDate
        '
        Me.lblOrderDate.BackColor = System.Drawing.SystemColors.Control
        Me.lblOrderDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOrderDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblOrderDate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderDate.ForeColor = System.Drawing.Color.Red
        Me.lblOrderDate.Location = New System.Drawing.Point(256, 16)
        Me.lblOrderDate.Name = "lblOrderDate"
        Me.lblOrderDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOrderDate.Size = New System.Drawing.Size(65, 17)
        Me.lblOrderDate.TabIndex = 27
        '
        'lblOrderNo
        '
        Me.lblOrderNo.BackColor = System.Drawing.SystemColors.Control
        Me.lblOrderNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOrderNo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblOrderNo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderNo.ForeColor = System.Drawing.Color.Red
        Me.lblOrderNo.Location = New System.Drawing.Point(96, 16)
        Me.lblOrderNo.Name = "lblOrderNo"
        Me.lblOrderNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOrderNo.Size = New System.Drawing.Size(81, 17)
        Me.lblOrderNo.TabIndex = 26
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(184, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(65, 17)
        Me.Label17.TabIndex = 59
        Me.Label17.Text = "Order date:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(8, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(81, 17)
        Me.Label18.TabIndex = 58
        Me.Label18.Text = "Order number:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'fraWSStatus
        '
        Me.fraWSStatus.BackColor = System.Drawing.SystemColors.Control
        Me.fraWSStatus.Controls.Add(Me.lblXmitDate)
        Me.fraWSStatus.Controls.Add(Me.lblValStatus)
        Me.fraWSStatus.Controls.Add(Me.lblValDate)
        Me.fraWSStatus.Controls.Add(Me.lblXmitStatus)
        Me.fraWSStatus.Controls.Add(Me.lblErrorLevel)
        Me.fraWSStatus.Controls.Add(Me.lblErrMsg)
        Me.fraWSStatus.Controls.Add(Me.Label20)
        Me.fraWSStatus.Controls.Add(Me.Label14)
        Me.fraWSStatus.Controls.Add(Me.Label15)
        Me.fraWSStatus.Controls.Add(Me.Label16)
        Me.fraWSStatus.Controls.Add(Me.Label19)
        Me.fraWSStatus.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraWSStatus.ForeColor = System.Drawing.Color.Blue
        Me.fraWSStatus.Location = New System.Drawing.Point(8, 15)
        Me.fraWSStatus.Name = "fraWSStatus"
        Me.fraWSStatus.Padding = New System.Windows.Forms.Padding(0)
        Me.fraWSStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraWSStatus.Size = New System.Drawing.Size(329, 106)
        Me.fraWSStatus.TabIndex = 51
        Me.fraWSStatus.TabStop = False
        Me.fraWSStatus.Text = " Worksheet Status "
        '
        'lblXmitDate
        '
        Me.lblXmitDate.BackColor = System.Drawing.SystemColors.Control
        Me.lblXmitDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblXmitDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblXmitDate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXmitDate.ForeColor = System.Drawing.Color.Red
        Me.lblXmitDate.Location = New System.Drawing.Point(176, 32)
        Me.lblXmitDate.Name = "lblXmitDate"
        Me.lblXmitDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblXmitDate.Size = New System.Drawing.Size(89, 17)
        Me.lblXmitDate.TabIndex = 19
        '
        'lblValStatus
        '
        Me.lblValStatus.BackColor = System.Drawing.SystemColors.Control
        Me.lblValStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblValStatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblValStatus.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValStatus.ForeColor = System.Drawing.Color.Red
        Me.lblValStatus.Location = New System.Drawing.Point(88, 56)
        Me.lblValStatus.Name = "lblValStatus"
        Me.lblValStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblValStatus.Size = New System.Drawing.Size(73, 17)
        Me.lblValStatus.TabIndex = 20
        '
        'lblValDate
        '
        Me.lblValDate.BackColor = System.Drawing.SystemColors.Control
        Me.lblValDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblValDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblValDate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValDate.ForeColor = System.Drawing.Color.Red
        Me.lblValDate.Location = New System.Drawing.Point(176, 56)
        Me.lblValDate.Name = "lblValDate"
        Me.lblValDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblValDate.Size = New System.Drawing.Size(89, 17)
        Me.lblValDate.TabIndex = 21
        '
        'lblXmitStatus
        '
        Me.lblXmitStatus.BackColor = System.Drawing.SystemColors.Control
        Me.lblXmitStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblXmitStatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblXmitStatus.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXmitStatus.ForeColor = System.Drawing.Color.Red
        Me.lblXmitStatus.Location = New System.Drawing.Point(88, 32)
        Me.lblXmitStatus.Name = "lblXmitStatus"
        Me.lblXmitStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblXmitStatus.Size = New System.Drawing.Size(73, 17)
        Me.lblXmitStatus.TabIndex = 18
        '
        'lblErrorLevel
        '
        Me.lblErrorLevel.BackColor = System.Drawing.SystemColors.Control
        Me.lblErrorLevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblErrorLevel.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblErrorLevel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorLevel.ForeColor = System.Drawing.Color.Red
        Me.lblErrorLevel.Location = New System.Drawing.Point(88, 80)
        Me.lblErrorLevel.Name = "lblErrorLevel"
        Me.lblErrorLevel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblErrorLevel.Size = New System.Drawing.Size(25, 17)
        Me.lblErrorLevel.TabIndex = 22
        '
        'lblErrMsg
        '
        Me.lblErrMsg.BackColor = System.Drawing.Color.White
        Me.lblErrMsg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblErrMsg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrMsg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblErrMsg.Location = New System.Drawing.Point(120, 80)
        Me.lblErrMsg.Name = "lblErrMsg"
        Me.lblErrMsg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblErrMsg.Size = New System.Drawing.Size(201, 17)
        Me.lblErrMsg.TabIndex = 23
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(16, 56)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(65, 17)
        Me.Label20.TabIndex = 56
        Me.Label20.Text = "Validation:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(8, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(73, 17)
        Me.Label14.TabIndex = 55
        Me.Label14.Text = "Transmittal:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(88, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(57, 17)
        Me.Label15.TabIndex = 54
        Me.Label15.Text = "Status"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(168, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(41, 17)
        Me.Label16.TabIndex = 53
        Me.Label16.Text = "Date"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.Control
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(8, 80)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(73, 17)
        Me.Label19.TabIndex = 52
        Me.Label19.Text = "Error Level:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'fraCustOrdInfo
        '
        Me.fraCustOrdInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.fraCustOrdInfo.Controls.Add(Me.dtpCancelBy)
        Me.fraCustOrdInfo.Controls.Add(Me.dtpDelvBy)
        Me.fraCustOrdInfo.Controls.Add(Me.chkOrderComplete)
        Me.fraCustOrdInfo.Controls.Add(Me.txtPO)
        Me.fraCustOrdInfo.Controls.Add(Me.mebDept)
        Me.fraCustOrdInfo.Controls.Add(Me.fraDisplayCodes)
        Me.fraCustOrdInfo.Controls.Add(Me.lblHelpMsg)
        Me.fraCustOrdInfo.Controls.Add(Me.Label9)
        Me.fraCustOrdInfo.Controls.Add(Me.Label10)
        Me.fraCustOrdInfo.Controls.Add(Me.Label6)
        Me.fraCustOrdInfo.Controls.Add(Me.Label8)
        Me.fraCustOrdInfo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraCustOrdInfo.ForeColor = System.Drawing.Color.White
        Me.fraCustOrdInfo.Location = New System.Drawing.Point(0, 8)
        Me.fraCustOrdInfo.Name = "fraCustOrdInfo"
        Me.fraCustOrdInfo.Padding = New System.Windows.Forms.Padding(0)
        Me.fraCustOrdInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraCustOrdInfo.Size = New System.Drawing.Size(789, 121)
        Me.fraCustOrdInfo.TabIndex = 64
        Me.fraCustOrdInfo.TabStop = False
        Me.fraCustOrdInfo.Text = " Customer Order Information "
        '
        'dtpCancelBy
        '
        Me.dtpCancelBy.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCancelBy.Location = New System.Drawing.Point(353, 44)
        Me.dtpCancelBy.Name = "dtpCancelBy"
        Me.dtpCancelBy.Size = New System.Drawing.Size(103, 20)
        Me.dtpCancelBy.TabIndex = 75
        '
        'dtpDelvBy
        '
        Me.dtpDelvBy.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDelvBy.Location = New System.Drawing.Point(353, 13)
        Me.dtpDelvBy.Name = "dtpDelvBy"
        Me.dtpDelvBy.Size = New System.Drawing.Size(103, 20)
        Me.dtpDelvBy.TabIndex = 74
        '
        'chkOrderComplete
        '
        Me.chkOrderComplete.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkOrderComplete.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkOrderComplete.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkOrderComplete.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOrderComplete.ForeColor = System.Drawing.Color.White
        Me.chkOrderComplete.Location = New System.Drawing.Point(8, 64)
        Me.chkOrderComplete.Name = "chkOrderComplete"
        Me.chkOrderComplete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkOrderComplete.Size = New System.Drawing.Size(193, 17)
        Me.chkOrderComplete.TabIndex = 7
        Me.chkOrderComplete.Text = "Ship complete (one shipment)"
        Me.chkOrderComplete.UseVisualStyleBackColor = False
        '
        'txtPO
        '
        Me.txtPO.AcceptsReturn = True
        Me.txtPO.BackColor = System.Drawing.SystemColors.Window
        Me.txtPO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPO.Location = New System.Drawing.Point(144, 40)
        Me.txtPO.MaxLength = 14
        Me.txtPO.Name = "txtPO"
        Me.txtPO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPO.Size = New System.Drawing.Size(105, 20)
        Me.txtPO.TabIndex = 6
        '
        'mebDept
        '
        Me.mebDept.AllowPromptAsInput = False
        Me.mebDept.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mebDept.Location = New System.Drawing.Point(144, 16)
        Me.mebDept.Mask = ">&&&&&&&&"
        Me.mebDept.Name = "mebDept"
        Me.mebDept.Size = New System.Drawing.Size(89, 20)
        Me.mebDept.TabIndex = 5
        '
        'fraDisplayCodes
        '
        Me.fraDisplayCodes.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.fraDisplayCodes.Controls.Add(Me.cmdSeason)
        Me.fraDisplayCodes.Controls.Add(Me.cmdOrderCode)
        Me.fraDisplayCodes.Controls.Add(Me.cmdShipVia)
        Me.fraDisplayCodes.Controls.Add(Me.txtSeason)
        Me.fraDisplayCodes.Controls.Add(Me.txtOrderCd)
        Me.fraDisplayCodes.Controls.Add(Me.txtShipVia)
        Me.fraDisplayCodes.Controls.Add(Me.lblSlsmnCd)
        Me.fraDisplayCodes.Controls.Add(Me.Label2)
        Me.fraDisplayCodes.Controls.Add(Me.lblShipViaDesc)
        Me.fraDisplayCodes.Controls.Add(Me.lblSeasonDesc)
        Me.fraDisplayCodes.Controls.Add(Me.lblOrdTypeDesc)
        Me.fraDisplayCodes.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraDisplayCodes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraDisplayCodes.Location = New System.Drawing.Point(464, -1)
        Me.fraDisplayCodes.Name = "fraDisplayCodes"
        Me.fraDisplayCodes.Padding = New System.Windows.Forms.Padding(0)
        Me.fraDisplayCodes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraDisplayCodes.Size = New System.Drawing.Size(328, 122)
        Me.fraDisplayCodes.TabIndex = 73
        Me.fraDisplayCodes.TabStop = False
        '
        'cmdSeason
        '
        Me.cmdSeason.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSeason.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSeason.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSeason.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSeason.Location = New System.Drawing.Point(8, 16)
        Me.cmdSeason.Name = "cmdSeason"
        Me.cmdSeason.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSeason.Size = New System.Drawing.Size(73, 19)
        Me.cmdSeason.TabIndex = 11
        Me.cmdSeason.Text = "Seaso&n"
        Me.cmdSeason.UseVisualStyleBackColor = False
        '
        'cmdOrderCode
        '
        Me.cmdOrderCode.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOrderCode.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOrderCode.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOrderCode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOrderCode.Location = New System.Drawing.Point(8, 40)
        Me.cmdOrderCode.Name = "cmdOrderCode"
        Me.cmdOrderCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOrderCode.Size = New System.Drawing.Size(73, 19)
        Me.cmdOrderCode.TabIndex = 12
        Me.cmdOrderCode.Text = "&Order Code"
        Me.cmdOrderCode.UseVisualStyleBackColor = False
        '
        'cmdShipVia
        '
        Me.cmdShipVia.BackColor = System.Drawing.SystemColors.Control
        Me.cmdShipVia.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdShipVia.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdShipVia.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdShipVia.Location = New System.Drawing.Point(8, 64)
        Me.cmdShipVia.Name = "cmdShipVia"
        Me.cmdShipVia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdShipVia.Size = New System.Drawing.Size(73, 19)
        Me.cmdShipVia.TabIndex = 13
        Me.cmdShipVia.Text = "Ship &Via"
        Me.cmdShipVia.UseVisualStyleBackColor = False
        '
        'txtSeason
        '
        Me.txtSeason.AcceptsReturn = True
        Me.txtSeason.BackColor = System.Drawing.SystemColors.Window
        Me.txtSeason.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSeason.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeason.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSeason.Location = New System.Drawing.Point(88, 16)
        Me.txtSeason.MaxLength = 8
        Me.txtSeason.Name = "txtSeason"
        Me.txtSeason.ReadOnly = True
        Me.txtSeason.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSeason.Size = New System.Drawing.Size(57, 20)
        Me.txtSeason.TabIndex = 14
        '
        'txtOrderCd
        '
        Me.txtOrderCd.AcceptsReturn = True
        Me.txtOrderCd.BackColor = System.Drawing.SystemColors.Window
        Me.txtOrderCd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOrderCd.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrderCd.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOrderCd.Location = New System.Drawing.Point(88, 40)
        Me.txtOrderCd.MaxLength = 4
        Me.txtOrderCd.Name = "txtOrderCd"
        Me.txtOrderCd.ReadOnly = True
        Me.txtOrderCd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOrderCd.Size = New System.Drawing.Size(57, 20)
        Me.txtOrderCd.TabIndex = 15
        '
        'txtShipVia
        '
        Me.txtShipVia.AcceptsReturn = True
        Me.txtShipVia.BackColor = System.Drawing.SystemColors.Window
        Me.txtShipVia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShipVia.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShipVia.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtShipVia.Location = New System.Drawing.Point(88, 64)
        Me.txtShipVia.MaxLength = 2
        Me.txtShipVia.Name = "txtShipVia"
        Me.txtShipVia.ReadOnly = True
        Me.txtShipVia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtShipVia.Size = New System.Drawing.Size(57, 20)
        Me.txtShipVia.TabIndex = 16
        '
        'lblSlsmnCd
        '
        Me.lblSlsmnCd.BackColor = System.Drawing.Color.Blue
        Me.lblSlsmnCd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSlsmnCd.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSlsmnCd.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSlsmnCd.ForeColor = System.Drawing.Color.White
        Me.lblSlsmnCd.Location = New System.Drawing.Point(120, 88)
        Me.lblSlsmnCd.Name = "lblSlsmnCd"
        Me.lblSlsmnCd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSlsmnCd.Size = New System.Drawing.Size(49, 17)
        Me.lblSlsmnCd.TabIndex = 17
        Me.lblSlsmnCd.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(97, 17)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Salesman Code:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblShipViaDesc
        '
        Me.lblShipViaDesc.BackColor = System.Drawing.SystemColors.Control
        Me.lblShipViaDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShipViaDesc.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShipViaDesc.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShipViaDesc.ForeColor = System.Drawing.Color.Blue
        Me.lblShipViaDesc.Location = New System.Drawing.Point(152, 64)
        Me.lblShipViaDesc.Name = "lblShipViaDesc"
        Me.lblShipViaDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblShipViaDesc.Size = New System.Drawing.Size(153, 17)
        Me.lblShipViaDesc.TabIndex = 76
        Me.lblShipViaDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSeasonDesc
        '
        Me.lblSeasonDesc.BackColor = System.Drawing.SystemColors.Control
        Me.lblSeasonDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSeasonDesc.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSeasonDesc.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeasonDesc.ForeColor = System.Drawing.Color.Blue
        Me.lblSeasonDesc.Location = New System.Drawing.Point(152, 16)
        Me.lblSeasonDesc.Name = "lblSeasonDesc"
        Me.lblSeasonDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSeasonDesc.Size = New System.Drawing.Size(153, 17)
        Me.lblSeasonDesc.TabIndex = 75
        Me.lblSeasonDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblOrdTypeDesc
        '
        Me.lblOrdTypeDesc.BackColor = System.Drawing.SystemColors.Control
        Me.lblOrdTypeDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOrdTypeDesc.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblOrdTypeDesc.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrdTypeDesc.ForeColor = System.Drawing.Color.Blue
        Me.lblOrdTypeDesc.Location = New System.Drawing.Point(152, 40)
        Me.lblOrdTypeDesc.Name = "lblOrdTypeDesc"
        Me.lblOrdTypeDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOrdTypeDesc.Size = New System.Drawing.Size(153, 17)
        Me.lblOrdTypeDesc.TabIndex = 74
        Me.lblOrdTypeDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblHelpMsg
        '
        Me.lblHelpMsg.BackColor = System.Drawing.SystemColors.Control
        Me.lblHelpMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHelpMsg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHelpMsg.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelpMsg.ForeColor = System.Drawing.Color.Red
        Me.lblHelpMsg.Location = New System.Drawing.Point(72, 96)
        Me.lblHelpMsg.Name = "lblHelpMsg"
        Me.lblHelpMsg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHelpMsg.Size = New System.Drawing.Size(361, 17)
        Me.lblHelpMsg.TabIndex = 8
        Me.lblHelpMsg.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(8, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(129, 17)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "Deliver to Department:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(24, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(113, 17)
        Me.Label10.TabIndex = 67
        Me.Label10.Text = "Purchase order no.:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(248, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(105, 17)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Start shipping on:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(256, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(97, 17)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Complete date:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tabMemosErrMsg
        '
        Me.tabMemosErrMsg.Controls.Add(Me._tabMemosErrMsg_TabPage0)
        Me.tabMemosErrMsg.Controls.Add(Me._tabMemosErrMsg_TabPage1)
        Me.tabMemosErrMsg.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabMemosErrMsg.ForeColor = System.Drawing.Color.Blue
        Me.tabMemosErrMsg.ItemSize = New System.Drawing.Size(42, 18)
        Me.tabMemosErrMsg.Location = New System.Drawing.Point(368, 136)
        Me.tabMemosErrMsg.Name = "tabMemosErrMsg"
        Me.tabMemosErrMsg.SelectedIndex = 0
        Me.tabMemosErrMsg.Size = New System.Drawing.Size(417, 281)
        Me.tabMemosErrMsg.TabIndex = 72
        '
        '_tabMemosErrMsg_TabPage0
        '
        Me._tabMemosErrMsg_TabPage0.Controls.Add(Me.txtWSMemo)
        Me._tabMemosErrMsg_TabPage0.Location = New System.Drawing.Point(4, 22)
        Me._tabMemosErrMsg_TabPage0.Name = "_tabMemosErrMsg_TabPage0"
        Me._tabMemosErrMsg_TabPage0.Size = New System.Drawing.Size(409, 255)
        Me._tabMemosErrMsg_TabPage0.TabIndex = 0
        Me._tabMemosErrMsg_TabPage0.Text = "Worksheet Memos"
        '
        'txtWSMemo
        '
        Me.txtWSMemo.AcceptsReturn = True
        Me.txtWSMemo.BackColor = System.Drawing.SystemColors.Window
        Me.txtWSMemo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWSMemo.Enabled = False
        Me.txtWSMemo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWSMemo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWSMemo.Location = New System.Drawing.Point(8, 10)
        Me.txtWSMemo.MaxLength = 0
        Me.txtWSMemo.Multiline = True
        Me.txtWSMemo.Name = "txtWSMemo"
        Me.txtWSMemo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWSMemo.Size = New System.Drawing.Size(397, 233)
        Me.txtWSMemo.TabIndex = 93
        '
        '_tabMemosErrMsg_TabPage1
        '
        Me._tabMemosErrMsg_TabPage1.Controls.Add(Me.DataGridView1)
        Me._tabMemosErrMsg_TabPage1.Location = New System.Drawing.Point(4, 22)
        Me._tabMemosErrMsg_TabPage1.Name = "_tabMemosErrMsg_TabPage1"
        Me._tabMemosErrMsg_TabPage1.Size = New System.Drawing.Size(409, 255)
        Me._tabMemosErrMsg_TabPage1.TabIndex = 1
        Me._tabMemosErrMsg_TabPage1.Text = "Worksheet Error Messages"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DataGridView1.DataSource = Me.WSErrorMsgBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 1)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(385, 242)
        Me.DataGridView1.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Error-Level"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Error Level"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 85
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Message"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Message"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 76
        '
        'WSErrorMsgBindingSource
        '
        Me.WSErrorMsgBindingSource.DataMember = "WSErrorMsg"
        Me.WSErrorMsgBindingSource.DataSource = Me.SaleForcDataSet
        '
        'SaleForcDataSet
        '
        Me.SaleForcDataSet.DataSetName = "SaleForcDataSet"
        Me.SaleForcDataSet.EnforceConstraints = False
        Me.SaleForcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'fraButtons
        '
        Me.fraButtons.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.fraButtons.Controls.Add(Me.fraStatus)
        Me.fraButtons.Controls.Add(Me.cmdEmailWorksheet)
        Me.fraButtons.Controls.Add(Me.cmdPrintPreview)
        Me.fraButtons.Controls.Add(Me.btnPrint)
        Me.fraButtons.Controls.Add(Me.btnItems)
        Me.fraButtons.Controls.Add(Me.btnExit)
        Me.fraButtons.Controls.Add(Me.btnEditWS)
        Me.fraButtons.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraButtons.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraButtons.Location = New System.Drawing.Point(0, 80)
        Me.fraButtons.Name = "fraButtons"
        Me.fraButtons.Padding = New System.Windows.Forms.Padding(0)
        Me.fraButtons.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraButtons.Size = New System.Drawing.Size(790, 57)
        Me.fraButtons.TabIndex = 37
        Me.fraButtons.TabStop = False
        '
        'fraStatus
        '
        Me.fraStatus.BackColor = System.Drawing.SystemColors.Control
        Me.fraStatus.Controls.Add(Me.chkReadyToXmit)
        Me.fraStatus.Controls.Add(Me.chkCancel)
        Me.fraStatus.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraStatus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraStatus.Location = New System.Drawing.Point(595, 1)
        Me.fraStatus.Name = "fraStatus"
        Me.fraStatus.Padding = New System.Windows.Forms.Padding(0)
        Me.fraStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraStatus.Size = New System.Drawing.Size(197, 49)
        Me.fraStatus.TabIndex = 112
        Me.fraStatus.TabStop = False
        '
        'chkReadyToXmit
        '
        Me.chkReadyToXmit.BackColor = System.Drawing.SystemColors.Control
        Me.chkReadyToXmit.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkReadyToXmit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkReadyToXmit.ForeColor = System.Drawing.Color.Black
        Me.chkReadyToXmit.Location = New System.Drawing.Point(24, 24)
        Me.chkReadyToXmit.Name = "chkReadyToXmit"
        Me.chkReadyToXmit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkReadyToXmit.Size = New System.Drawing.Size(129, 17)
        Me.chkReadyToXmit.TabIndex = 35
        Me.chkReadyToXmit.Text = "Ready to &Transmit"
        Me.chkReadyToXmit.UseVisualStyleBackColor = False
        '
        'chkCancel
        '
        Me.chkCancel.BackColor = System.Drawing.SystemColors.Control
        Me.chkCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkCancel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkCancel.Location = New System.Drawing.Point(24, 8)
        Me.chkCancel.Name = "chkCancel"
        Me.chkCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkCancel.Size = New System.Drawing.Size(129, 17)
        Me.chkCancel.TabIndex = 34
        Me.chkCancel.Text = "&Cancel worksheet"
        Me.chkCancel.UseVisualStyleBackColor = False
        '
        'cmdEmailWorksheet
        '
        Me.cmdEmailWorksheet.BackColor = System.Drawing.SystemColors.Control
        Me.cmdEmailWorksheet.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEmailWorksheet.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEmailWorksheet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEmailWorksheet.Location = New System.Drawing.Point(424, 16)
        Me.cmdEmailWorksheet.Name = "cmdEmailWorksheet"
        Me.cmdEmailWorksheet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdEmailWorksheet.Size = New System.Drawing.Size(81, 25)
        Me.cmdEmailWorksheet.TabIndex = 3
        Me.cmdEmailWorksheet.Text = "E&mail"
        Me.cmdEmailWorksheet.UseVisualStyleBackColor = False
        '
        'cmdPrintPreview
        '
        Me.cmdPrintPreview.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrintPreview.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrintPreview.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrintPreview.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrintPreview.Location = New System.Drawing.Point(320, 16)
        Me.cmdPrintPreview.Name = "cmdPrintPreview"
        Me.cmdPrintPreview.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrintPreview.Size = New System.Drawing.Size(97, 25)
        Me.cmdPrintPreview.TabIndex = 2
        Me.cmdPrintPreview.Text = "Prin&t Preview"
        Me.cmdPrintPreview.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.Control
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnPrint.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPrint.Location = New System.Drawing.Point(240, 16)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPrint.Size = New System.Drawing.Size(73, 25)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "P&rint"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnItems
        '
        Me.btnItems.BackColor = System.Drawing.SystemColors.Control
        Me.btnItems.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnItems.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItems.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnItems.Location = New System.Drawing.Point(512, 16)
        Me.btnItems.Name = "btnItems"
        Me.btnItems.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnItems.Size = New System.Drawing.Size(73, 25)
        Me.btnItems.TabIndex = 4
        Me.btnItems.Text = "&Items"
        Me.btnItems.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(8, 16)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExit.Size = New System.Drawing.Size(73, 25)
        Me.btnExit.TabIndex = 31
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnEditWS
        '
        Me.btnEditWS.BackColor = System.Drawing.SystemColors.Control
        Me.btnEditWS.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnEditWS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditWS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEditWS.Location = New System.Drawing.Point(160, 16)
        Me.btnEditWS.Name = "btnEditWS"
        Me.btnEditWS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnEditWS.Size = New System.Drawing.Size(73, 25)
        Me.btnEditWS.TabIndex = 0
        Me.btnEditWS.Text = "&Edit"
        Me.btnEditWS.UseVisualStyleBackColor = False
        '
        'fraCustRef
        '
        Me.fraCustRef.BackColor = System.Drawing.SystemColors.Control
        Me.fraCustRef.Controls.Add(Me.chkMaintAllowed)
        Me.fraCustRef.Controls.Add(Me.Label1)
        Me.fraCustRef.Controls.Add(Me.lblWsNo)
        Me.fraCustRef.Controls.Add(Me.lblShipTo)
        Me.fraCustRef.Controls.Add(Me.lblCustomer)
        Me.fraCustRef.Controls.Add(Me.Label26)
        Me.fraCustRef.Controls.Add(Me.Label21)
        Me.fraCustRef.Controls.Add(Me.lblCustShipNo)
        Me.fraCustRef.Controls.Add(Me.lblCustNo)
        Me.fraCustRef.Controls.Add(Me.fraCustType)
        Me.fraCustRef.Enabled = False
        Me.fraCustRef.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraCustRef.ForeColor = System.Drawing.Color.Blue
        Me.fraCustRef.Location = New System.Drawing.Point(0, 0)
        Me.fraCustRef.Name = "fraCustRef"
        Me.fraCustRef.Padding = New System.Windows.Forms.Padding(0)
        Me.fraCustRef.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraCustRef.Size = New System.Drawing.Size(795, 81)
        Me.fraCustRef.TabIndex = 41
        Me.fraCustRef.TabStop = False
        Me.fraCustRef.Text = " Customer "
        '
        'chkMaintAllowed
        '
        Me.chkMaintAllowed.BackColor = System.Drawing.SystemColors.Control
        Me.chkMaintAllowed.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkMaintAllowed.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMaintAllowed.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkMaintAllowed.Location = New System.Drawing.Point(619, 58)
        Me.chkMaintAllowed.Name = "chkMaintAllowed"
        Me.chkMaintAllowed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkMaintAllowed.Size = New System.Drawing.Size(153, 17)
        Me.chkMaintAllowed.TabIndex = 76
        Me.chkMaintAllowed.TabStop = False
        Me.chkMaintAllowed.Text = "Maintenance allowed"
        Me.chkMaintAllowed.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(593, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 14)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Worksheet ID Number"
        '
        'lblWsNo
        '
        Me.lblWsNo.BackColor = System.Drawing.Color.White
        Me.lblWsNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWsNo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblWsNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWsNo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblWsNo.Location = New System.Drawing.Point(596, 27)
        Me.lblWsNo.Name = "lblWsNo"
        Me.lblWsNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblWsNo.Size = New System.Drawing.Size(185, 25)
        Me.lblWsNo.TabIndex = 74
        Me.lblWsNo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblShipTo
        '
        Me.lblShipTo.BackColor = System.Drawing.Color.White
        Me.lblShipTo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShipTo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShipTo.ForeColor = System.Drawing.Color.Blue
        Me.lblShipTo.Location = New System.Drawing.Point(80, 40)
        Me.lblShipTo.Name = "lblShipTo"
        Me.lblShipTo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblShipTo.Size = New System.Drawing.Size(265, 17)
        Me.lblShipTo.TabIndex = 71
        Me.lblShipTo.UseMnemonic = False
        '
        'lblCustomer
        '
        Me.lblCustomer.BackColor = System.Drawing.Color.White
        Me.lblCustomer.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCustomer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomer.ForeColor = System.Drawing.Color.Blue
        Me.lblCustomer.Location = New System.Drawing.Point(80, 16)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCustomer.Size = New System.Drawing.Size(265, 17)
        Me.lblCustomer.TabIndex = 70
        Me.lblCustomer.UseMnemonic = False
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.SystemColors.Control
        Me.Label26.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(8, 40)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(65, 17)
        Me.Label26.TabIndex = 48
        Me.Label26.Text = "Ship to:"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(8, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(65, 17)
        Me.Label21.TabIndex = 47
        Me.Label21.Text = "Customer:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCustShipNo
        '
        Me.lblCustShipNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblCustShipNo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCustShipNo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustShipNo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCustShipNo.Location = New System.Drawing.Point(360, 40)
        Me.lblCustShipNo.Name = "lblCustShipNo"
        Me.lblCustShipNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCustShipNo.Size = New System.Drawing.Size(73, 17)
        Me.lblCustShipNo.TabIndex = 43
        '
        'lblCustNo
        '
        Me.lblCustNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblCustNo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCustNo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustNo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCustNo.Location = New System.Drawing.Point(360, 16)
        Me.lblCustNo.Name = "lblCustNo"
        Me.lblCustNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCustNo.Size = New System.Drawing.Size(73, 17)
        Me.lblCustNo.TabIndex = 42
        '
        'fraCustType
        '
        Me.fraCustType.BackColor = System.Drawing.SystemColors.Control
        Me.fraCustType.Controls.Add(Me._optCustIs_0)
        Me.fraCustType.Controls.Add(Me._optCustIs_1)
        Me.fraCustType.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraCustType.ForeColor = System.Drawing.Color.Blue
        Me.fraCustType.Location = New System.Drawing.Point(488, 8)
        Me.fraCustType.Name = "fraCustType"
        Me.fraCustType.Padding = New System.Windows.Forms.Padding(0)
        Me.fraCustType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraCustType.Size = New System.Drawing.Size(97, 57)
        Me.fraCustType.TabIndex = 44
        Me.fraCustType.TabStop = False
        Me.fraCustType.Text = "Customer is "
        '
        '_optCustIs_0
        '
        Me._optCustIs_0.BackColor = System.Drawing.SystemColors.Control
        Me._optCustIs_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._optCustIs_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optCustIs_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optCustIs.SetIndex(Me._optCustIs_0, CType(0, Short))
        Me._optCustIs_0.Location = New System.Drawing.Point(8, 16)
        Me._optCustIs_0.Name = "_optCustIs_0"
        Me._optCustIs_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optCustIs_0.Size = New System.Drawing.Size(81, 17)
        Me._optCustIs_0.TabIndex = 46
        Me._optCustIs_0.Text = "New"
        Me._optCustIs_0.UseVisualStyleBackColor = False
        '
        '_optCustIs_1
        '
        Me._optCustIs_1.BackColor = System.Drawing.SystemColors.Control
        Me._optCustIs_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._optCustIs_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optCustIs_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optCustIs.SetIndex(Me._optCustIs_1, CType(1, Short))
        Me._optCustIs_1.Location = New System.Drawing.Point(8, 32)
        Me._optCustIs_1.Name = "_optCustIs_1"
        Me._optCustIs_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optCustIs_1.Size = New System.Drawing.Size(81, 17)
        Me._optCustIs_1.TabIndex = 45
        Me._optCustIs_1.Text = "Existing"
        Me._optCustIs_1.UseVisualStyleBackColor = False
        '
        'fraTable
        '
        Me.fraTable.BackColor = System.Drawing.SystemColors.Control
        Me.fraTable.Controls.Add(Me.dgvTempItems)
        Me.fraTable.Controls.Add(Me.Frame3)
        Me.fraTable.Controls.Add(Me.Frame2)
        Me.fraTable.Controls.Add(Me.fraSortBy)
        Me.fraTable.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraTable.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraTable.Location = New System.Drawing.Point(0, 263)
        Me.fraTable.Name = "fraTable"
        Me.fraTable.Padding = New System.Windows.Forms.Padding(0)
        Me.fraTable.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraTable.Size = New System.Drawing.Size(795, 282)
        Me.fraTable.TabIndex = 36
        Me.fraTable.TabStop = False
        '
        'dgvTempItems
        '
        Me.dgvTempItems.AllowUserToAddRows = False
        Me.dgvTempItems.AllowUserToDeleteRows = False
        Me.dgvTempItems.AllowUserToResizeColumns = False
        Me.dgvTempItems.AllowUserToResizeRows = False
        Me.dgvTempItems.AutoGenerateColumns = False
        Me.dgvTempItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvTempItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTempItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DeletedDataGridViewCheckBoxColumn, Me.ReadyForOrderDataGridViewCheckBoxColumn, Me.ItemNoDataGridViewTextBoxColumn, Me.QtyOrderedDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.ExtendedDataGridViewTextBoxColumn, Me.ColorDataGridViewTextBoxColumn, Me.SizeDataGridViewTextBoxColumn, Me.StyleDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn})
        Me.dgvTempItems.DataSource = Me.WSItemTempBindingSource
        Me.dgvTempItems.Location = New System.Drawing.Point(12, 16)
        Me.dgvTempItems.Name = "dgvTempItems"
        Me.dgvTempItems.ReadOnly = True
        Me.dgvTempItems.RowHeadersVisible = False
        Me.dgvTempItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTempItems.Size = New System.Drawing.Size(777, 195)
        Me.dgvTempItems.TabIndex = 110
        '
        'DeletedDataGridViewCheckBoxColumn
        '
        Me.DeletedDataGridViewCheckBoxColumn.DataPropertyName = "Deleted"
        Me.DeletedDataGridViewCheckBoxColumn.FalseValue = "No"
        Me.DeletedDataGridViewCheckBoxColumn.HeaderText = "Deleted"
        Me.DeletedDataGridViewCheckBoxColumn.Name = "DeletedDataGridViewCheckBoxColumn"
        Me.DeletedDataGridViewCheckBoxColumn.ReadOnly = True
        Me.DeletedDataGridViewCheckBoxColumn.TrueValue = "Yes"
        Me.DeletedDataGridViewCheckBoxColumn.Width = 49
        '
        'ReadyForOrderDataGridViewCheckBoxColumn
        '
        Me.ReadyForOrderDataGridViewCheckBoxColumn.DataPropertyName = "ReadyForOrder"
        Me.ReadyForOrderDataGridViewCheckBoxColumn.HeaderText = "OK"
        Me.ReadyForOrderDataGridViewCheckBoxColumn.Name = "ReadyForOrderDataGridViewCheckBoxColumn"
        Me.ReadyForOrderDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ReadyForOrderDataGridViewCheckBoxColumn.Width = 28
        '
        'ItemNoDataGridViewTextBoxColumn
        '
        Me.ItemNoDataGridViewTextBoxColumn.DataPropertyName = "ItemNo"
        Me.ItemNoDataGridViewTextBoxColumn.HeaderText = "ItemNo"
        Me.ItemNoDataGridViewTextBoxColumn.Name = "ItemNoDataGridViewTextBoxColumn"
        Me.ItemNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ItemNoDataGridViewTextBoxColumn.Width = 64
        '
        'QtyOrderedDataGridViewTextBoxColumn
        '
        Me.QtyOrderedDataGridViewTextBoxColumn.DataPropertyName = "QtyOrdered"
        Me.QtyOrderedDataGridViewTextBoxColumn.HeaderText = "QtyOrdered"
        Me.QtyOrderedDataGridViewTextBoxColumn.Name = "QtyOrderedDataGridViewTextBoxColumn"
        Me.QtyOrderedDataGridViewTextBoxColumn.ReadOnly = True
        Me.QtyOrderedDataGridViewTextBoxColumn.Width = 89
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.PriceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.PriceDataGridViewTextBoxColumn.Width = 56
        '
        'ExtendedDataGridViewTextBoxColumn
        '
        Me.ExtendedDataGridViewTextBoxColumn.DataPropertyName = "Extended"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.ExtendedDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.ExtendedDataGridViewTextBoxColumn.HeaderText = "Extended"
        Me.ExtendedDataGridViewTextBoxColumn.Name = "ExtendedDataGridViewTextBoxColumn"
        Me.ExtendedDataGridViewTextBoxColumn.ReadOnly = True
        Me.ExtendedDataGridViewTextBoxColumn.Width = 77
        '
        'ColorDataGridViewTextBoxColumn
        '
        Me.ColorDataGridViewTextBoxColumn.DataPropertyName = "Color"
        Me.ColorDataGridViewTextBoxColumn.HeaderText = "Color"
        Me.ColorDataGridViewTextBoxColumn.Name = "ColorDataGridViewTextBoxColumn"
        Me.ColorDataGridViewTextBoxColumn.ReadOnly = True
        Me.ColorDataGridViewTextBoxColumn.Width = 57
        '
        'SizeDataGridViewTextBoxColumn
        '
        Me.SizeDataGridViewTextBoxColumn.DataPropertyName = "Size"
        Me.SizeDataGridViewTextBoxColumn.HeaderText = "Size"
        Me.SizeDataGridViewTextBoxColumn.Name = "SizeDataGridViewTextBoxColumn"
        Me.SizeDataGridViewTextBoxColumn.ReadOnly = True
        Me.SizeDataGridViewTextBoxColumn.Width = 53
        '
        'StyleDataGridViewTextBoxColumn
        '
        Me.StyleDataGridViewTextBoxColumn.DataPropertyName = "Style"
        Me.StyleDataGridViewTextBoxColumn.HeaderText = "Style"
        Me.StyleDataGridViewTextBoxColumn.Name = "StyleDataGridViewTextBoxColumn"
        Me.StyleDataGridViewTextBoxColumn.ReadOnly = True
        Me.StyleDataGridViewTextBoxColumn.Width = 56
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescriptionDataGridViewTextBoxColumn.Width = 86
        '
        'WSItemTempBindingSource
        '
        Me.WSItemTempBindingSource.DataMember = "WSItemTemp"
        Me.WSItemTempBindingSource.DataSource = Me.SaleForcDataSet
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.Label25)
        Me.Frame3.Controls.Add(Me.Label24)
        Me.Frame3.Controls.Add(Me.lblTotExtended)
        Me.Frame3.Controls.Add(Me.lblTotQty)
        Me.Frame3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(11, 217)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(153, 57)
        Me.Frame3.TabIndex = 100
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "Totals"
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.SystemColors.Control
        Me.Label25.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(8, 34)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label25.Size = New System.Drawing.Size(41, 17)
        Me.Label25.TabIndex = 104
        Me.Label25.Text = "Dollars:"
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.SystemColors.Control
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(8, 14)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(33, 17)
        Me.Label24.TabIndex = 103
        Me.Label24.Text = "Items:"
        '
        'lblTotExtended
        '
        Me.lblTotExtended.BackColor = System.Drawing.SystemColors.Control
        Me.lblTotExtended.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotExtended.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotExtended.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotExtended.ForeColor = System.Drawing.Color.Blue
        Me.lblTotExtended.Location = New System.Drawing.Point(56, 32)
        Me.lblTotExtended.Name = "lblTotExtended"
        Me.lblTotExtended.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotExtended.Size = New System.Drawing.Size(73, 17)
        Me.lblTotExtended.TabIndex = 102
        '
        'lblTotQty
        '
        Me.lblTotQty.BackColor = System.Drawing.SystemColors.Control
        Me.lblTotQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotQty.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotQty.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotQty.ForeColor = System.Drawing.Color.Blue
        Me.lblTotQty.Location = New System.Drawing.Point(56, 10)
        Me.lblTotQty.Name = "lblTotQty"
        Me.lblTotQty.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotQty.Size = New System.Drawing.Size(73, 17)
        Me.lblTotQty.TabIndex = 101
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me._optViewBy_0)
        Me.Frame2.Controls.Add(Me._optViewBy_1)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(171, 217)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(137, 57)
        Me.Frame2.TabIndex = 97
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "View By"
        '
        '_optViewBy_0
        '
        Me._optViewBy_0.BackColor = System.Drawing.SystemColors.Control
        Me._optViewBy_0.Checked = True
        Me._optViewBy_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._optViewBy_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optViewBy_0.ForeColor = System.Drawing.Color.Black
        Me.optViewBy.SetIndex(Me._optViewBy_0, CType(0, Short))
        Me._optViewBy_0.Location = New System.Drawing.Point(8, 16)
        Me._optViewBy_0.Name = "_optViewBy_0"
        Me._optViewBy_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optViewBy_0.Size = New System.Drawing.Size(113, 17)
        Me._optViewBy_0.TabIndex = 99
        Me._optViewBy_0.TabStop = True
        Me._optViewBy_0.Text = "&Order entered"
        Me._optViewBy_0.UseVisualStyleBackColor = False
        '
        '_optViewBy_1
        '
        Me._optViewBy_1.BackColor = System.Drawing.SystemColors.Control
        Me._optViewBy_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._optViewBy_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optViewBy_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optViewBy.SetIndex(Me._optViewBy_1, CType(1, Short))
        Me._optViewBy_1.Location = New System.Drawing.Point(8, 32)
        Me._optViewBy_1.Name = "_optViewBy_1"
        Me._optViewBy_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optViewBy_1.Size = New System.Drawing.Size(97, 17)
        Me._optViewBy_1.TabIndex = 98
        Me._optViewBy_1.TabStop = True
        Me._optViewBy_1.Text = "&Item number"
        Me._optViewBy_1.UseVisualStyleBackColor = False
        '
        'fraSortBy
        '
        Me.fraSortBy.BackColor = System.Drawing.SystemColors.Control
        Me.fraSortBy.Controls.Add(Me._optSortBy_0)
        Me.fraSortBy.Controls.Add(Me._optSortBy_1)
        Me.fraSortBy.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraSortBy.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraSortBy.Location = New System.Drawing.Point(323, 217)
        Me.fraSortBy.Name = "fraSortBy"
        Me.fraSortBy.Padding = New System.Windows.Forms.Padding(0)
        Me.fraSortBy.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraSortBy.Size = New System.Drawing.Size(113, 56)
        Me.fraSortBy.TabIndex = 94
        Me.fraSortBy.TabStop = False
        Me.fraSortBy.Text = "Sort"
        '
        '_optSortBy_0
        '
        Me._optSortBy_0.BackColor = System.Drawing.SystemColors.Control
        Me._optSortBy_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._optSortBy_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optSortBy_0.ForeColor = System.Drawing.Color.Black
        Me.optSortBy.SetIndex(Me._optSortBy_0, CType(0, Short))
        Me._optSortBy_0.Location = New System.Drawing.Point(8, 16)
        Me._optSortBy_0.Name = "_optSortBy_0"
        Me._optSortBy_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optSortBy_0.Size = New System.Drawing.Size(89, 21)
        Me._optSortBy_0.TabIndex = 96
        Me._optSortBy_0.TabStop = True
        Me._optSortBy_0.Text = "Ascending"
        Me._optSortBy_0.UseVisualStyleBackColor = False
        '
        '_optSortBy_1
        '
        Me._optSortBy_1.BackColor = System.Drawing.SystemColors.Control
        Me._optSortBy_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._optSortBy_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optSortBy_1.ForeColor = System.Drawing.Color.Black
        Me.optSortBy.SetIndex(Me._optSortBy_1, CType(1, Short))
        Me._optSortBy_1.Location = New System.Drawing.Point(8, 32)
        Me._optSortBy_1.Name = "_optSortBy_1"
        Me._optSortBy_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optSortBy_1.Size = New System.Drawing.Size(102, 20)
        Me._optSortBy_1.TabIndex = 95
        Me._optSortBy_1.TabStop = True
        Me._optSortBy_1.Text = "Descending"
        Me._optSortBy_1.UseVisualStyleBackColor = False
        '
        'fraItemMatrix
        '
        Me.fraItemMatrix.BackColor = System.Drawing.SystemColors.Control
        Me.fraItemMatrix.Controls.Add(Me.Label4)
        Me.fraItemMatrix.Controls.Add(Me.cmdReturn)
        Me.fraItemMatrix.Controls.Add(Me.txtStyle)
        Me.fraItemMatrix.Controls.Add(Me.cmdClearStyleQty)
        Me.fraItemMatrix.Controls.Add(Me.cmdNextStyle)
        Me.fraItemMatrix.Controls.Add(Me.lblQtyToSell)
        Me.fraItemMatrix.Controls.Add(Me.lblQtyPotential)
        Me.fraItemMatrix.Controls.Add(Me.lblQtyOnHand)
        Me.fraItemMatrix.Controls.Add(Me.imgPrevOrdered)
        Me.fraItemMatrix.Controls.Add(Me.lblItemPrice)
        Me.fraItemMatrix.Controls.Add(Me.lblShipDates)
        Me.fraItemMatrix.Controls.Add(Me.lblExtStylePrice)
        Me.fraItemMatrix.Controls.Add(Me.Label30)
        Me.fraItemMatrix.Controls.Add(Me.lblTotStyleQty)
        Me.fraItemMatrix.Controls.Add(Me.Label29)
        Me.fraItemMatrix.Controls.Add(Me.Label12)
        Me.fraItemMatrix.Controls.Add(Me.lblItemPrevOrder)
        Me.fraItemMatrix.Controls.Add(Me.lblItemDescription)
        Me.fraItemMatrix.Controls.Add(Me.dgvColorSize)
        Me.fraItemMatrix.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraItemMatrix.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraItemMatrix.Location = New System.Drawing.Point(0, 0)
        Me.fraItemMatrix.Name = "fraItemMatrix"
        Me.fraItemMatrix.Padding = New System.Windows.Forms.Padding(0)
        Me.fraItemMatrix.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraItemMatrix.Size = New System.Drawing.Size(795, 265)
        Me.fraItemMatrix.TabIndex = 78
        Me.fraItemMatrix.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(237, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(247, 15)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "TIP! Double-click any cell to view inventory."
        '
        'cmdReturn
        '
        Me.cmdReturn.BackColor = System.Drawing.SystemColors.Control
        Me.cmdReturn.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdReturn.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReturn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdReturn.Location = New System.Drawing.Point(16, 184)
        Me.cmdReturn.Name = "cmdReturn"
        Me.cmdReturn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdReturn.Size = New System.Drawing.Size(97, 25)
        Me.cmdReturn.TabIndex = 86
        Me.cmdReturn.Text = "&Return"
        Me.cmdReturn.UseVisualStyleBackColor = False
        '
        'txtStyle
        '
        Me.txtStyle.AcceptsReturn = True
        Me.txtStyle.BackColor = System.Drawing.SystemColors.Window
        Me.txtStyle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStyle.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtStyle.Location = New System.Drawing.Point(16, 32)
        Me.txtStyle.MaxLength = 0
        Me.txtStyle.Name = "txtStyle"
        Me.txtStyle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStyle.Size = New System.Drawing.Size(97, 20)
        Me.txtStyle.TabIndex = 82
        '
        'cmdClearStyleQty
        '
        Me.cmdClearStyleQty.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClearStyleQty.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClearStyleQty.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearStyleQty.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClearStyleQty.Location = New System.Drawing.Point(16, 152)
        Me.cmdClearStyleQty.Name = "cmdClearStyleQty"
        Me.cmdClearStyleQty.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClearStyleQty.Size = New System.Drawing.Size(97, 25)
        Me.cmdClearStyleQty.TabIndex = 80
        Me.cmdClearStyleQty.Text = "&Delete this Style"
        Me.cmdClearStyleQty.UseVisualStyleBackColor = False
        '
        'cmdNextStyle
        '
        Me.cmdNextStyle.BackColor = System.Drawing.SystemColors.Control
        Me.cmdNextStyle.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdNextStyle.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNextStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdNextStyle.Location = New System.Drawing.Point(16, 120)
        Me.cmdNextStyle.Name = "cmdNextStyle"
        Me.cmdNextStyle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdNextStyle.Size = New System.Drawing.Size(97, 25)
        Me.cmdNextStyle.TabIndex = 79
        Me.cmdNextStyle.Text = "&Next Style"
        Me.cmdNextStyle.UseVisualStyleBackColor = False
        '
        'lblQtyToSell
        '
        Me.lblQtyToSell.BackColor = System.Drawing.SystemColors.Control
        Me.lblQtyToSell.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblQtyToSell.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtyToSell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblQtyToSell.Location = New System.Drawing.Point(560, 231)
        Me.lblQtyToSell.Name = "lblQtyToSell"
        Me.lblQtyToSell.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblQtyToSell.Size = New System.Drawing.Size(89, 18)
        Me.lblQtyToSell.TabIndex = 108
        Me.lblQtyToSell.Text = "Qty To Sell: 0"
        '
        'lblQtyPotential
        '
        Me.lblQtyPotential.BackColor = System.Drawing.SystemColors.Control
        Me.lblQtyPotential.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblQtyPotential.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtyPotential.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblQtyPotential.Location = New System.Drawing.Point(560, 215)
        Me.lblQtyPotential.Name = "lblQtyPotential"
        Me.lblQtyPotential.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblQtyPotential.Size = New System.Drawing.Size(89, 18)
        Me.lblQtyPotential.TabIndex = 107
        Me.lblQtyPotential.Text = "Qty Potential: 0"
        '
        'lblQtyOnHand
        '
        Me.lblQtyOnHand.BackColor = System.Drawing.SystemColors.Control
        Me.lblQtyOnHand.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblQtyOnHand.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtyOnHand.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblQtyOnHand.Location = New System.Drawing.Point(656, 215)
        Me.lblQtyOnHand.Name = "lblQtyOnHand"
        Me.lblQtyOnHand.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblQtyOnHand.Size = New System.Drawing.Size(89, 18)
        Me.lblQtyOnHand.TabIndex = 106
        Me.lblQtyOnHand.Text = "Qty On Hand: 0 "
        '
        'imgPrevOrdered
        '
        Me.imgPrevOrdered.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgPrevOrdered.Image = CType(resources.GetObject("imgPrevOrdered.Image"), System.Drawing.Image)
        Me.imgPrevOrdered.Location = New System.Drawing.Point(184, 219)
        Me.imgPrevOrdered.Name = "imgPrevOrdered"
        Me.imgPrevOrdered.Size = New System.Drawing.Size(32, 32)
        Me.imgPrevOrdered.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgPrevOrdered.TabIndex = 109
        Me.imgPrevOrdered.TabStop = False
        Me.imgPrevOrdered.Visible = False
        '
        'lblItemPrice
        '
        Me.lblItemPrice.BackColor = System.Drawing.SystemColors.Control
        Me.lblItemPrice.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblItemPrice.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemPrice.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblItemPrice.Location = New System.Drawing.Point(496, 12)
        Me.lblItemPrice.Name = "lblItemPrice"
        Me.lblItemPrice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblItemPrice.Size = New System.Drawing.Size(201, 17)
        Me.lblItemPrice.TabIndex = 92
        '
        'lblShipDates
        '
        Me.lblShipDates.BackColor = System.Drawing.SystemColors.Control
        Me.lblShipDates.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShipDates.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShipDates.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblShipDates.Location = New System.Drawing.Point(144, 12)
        Me.lblShipDates.Name = "lblShipDates"
        Me.lblShipDates.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblShipDates.Size = New System.Drawing.Size(338, 17)
        Me.lblShipDates.TabIndex = 91
        '
        'lblExtStylePrice
        '
        Me.lblExtStylePrice.BackColor = System.Drawing.SystemColors.Control
        Me.lblExtStylePrice.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblExtStylePrice.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExtStylePrice.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblExtStylePrice.Location = New System.Drawing.Point(136, 240)
        Me.lblExtStylePrice.Name = "lblExtStylePrice"
        Me.lblExtStylePrice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblExtStylePrice.Size = New System.Drawing.Size(57, 17)
        Me.lblExtStylePrice.TabIndex = 90
        Me.lblExtStylePrice.Text = "$.00"
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.SystemColors.Control
        Me.Label30.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label30.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label30.Location = New System.Drawing.Point(16, 240)
        Me.Label30.Name = "Label30"
        Me.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label30.Size = New System.Drawing.Size(121, 20)
        Me.Label30.TabIndex = 89
        Me.Label30.Text = "Extended Style Price:"
        '
        'lblTotStyleQty
        '
        Me.lblTotStyleQty.BackColor = System.Drawing.SystemColors.Control
        Me.lblTotStyleQty.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotStyleQty.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotStyleQty.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTotStyleQty.Location = New System.Drawing.Point(127, 219)
        Me.lblTotStyleQty.Name = "lblTotStyleQty"
        Me.lblTotStyleQty.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotStyleQty.Size = New System.Drawing.Size(41, 17)
        Me.lblTotStyleQty.TabIndex = 88
        Me.lblTotStyleQty.Text = "0"
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.SystemColors.Control
        Me.Label29.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label29.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label29.Location = New System.Drawing.Point(16, 219)
        Me.Label29.Name = "Label29"
        Me.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label29.Size = New System.Drawing.Size(113, 17)
        Me.Label29.TabIndex = 87
        Me.Label29.Text = "Total Style Quantity:"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(16, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(33, 17)
        Me.Label12.TabIndex = 85
        Me.Label12.Text = "Style/Item:"
        '
        'lblItemPrevOrder
        '
        Me.lblItemPrevOrder.BackColor = System.Drawing.SystemColors.Control
        Me.lblItemPrevOrder.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblItemPrevOrder.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemPrevOrder.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblItemPrevOrder.Location = New System.Drawing.Point(224, 219)
        Me.lblItemPrevOrder.Name = "lblItemPrevOrder"
        Me.lblItemPrevOrder.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblItemPrevOrder.Size = New System.Drawing.Size(329, 33)
        Me.lblItemPrevOrder.TabIndex = 105
        '
        'lblItemDescription
        '
        Me.lblItemDescription.BackColor = System.Drawing.SystemColors.Control
        Me.lblItemDescription.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblItemDescription.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemDescription.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblItemDescription.Location = New System.Drawing.Point(8, 53)
        Me.lblItemDescription.Name = "lblItemDescription"
        Me.lblItemDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblItemDescription.Size = New System.Drawing.Size(121, 41)
        Me.lblItemDescription.TabIndex = 84
        '
        'dgvColorSize
        '
        Me.dgvColorSize.AllowUserToAddRows = False
        Me.dgvColorSize.AllowUserToDeleteRows = False
        Me.dgvColorSize.AllowUserToResizeColumns = False
        Me.dgvColorSize.AllowUserToResizeRows = False
        Me.dgvColorSize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvColorSize.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvColorSize.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvColorSize.Location = New System.Drawing.Point(130, 32)
        Me.dgvColorSize.Name = "dgvColorSize"
        Me.dgvColorSize.RowHeadersVisible = False
        Me.dgvColorSize.Size = New System.Drawing.Size(660, 181)
        Me.dgvColorSize.TabIndex = 110
        Me.dgvColorSize.TabStop = False
        '
        'optSortBy
        '
        '
        'optViewBy
        '
        '
        'WSItemTempTableAdapter
        '
        Me.WSItemTempTableAdapter.ClearBeforeFill = True
        '
        'WSErrorMsgTableAdapter
        '
        Me.WSErrorMsgTableAdapter.ClearBeforeFill = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'frmWorksheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(797, 548)
        Me.ControlBox = False
        Me.Controls.Add(Me.fraStatusMemos)
        Me.Controls.Add(Me.fraCustRef)
        Me.Controls.Add(Me.fraButtons)
        Me.Controls.Add(Me.fraItemMatrix)
        Me.Controls.Add(Me.fraTable)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(4, 25)
        Me.Name = "frmWorksheet"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Worksheet"
        Me.fraStatusMemos.ResumeLayout(False)
        Me.fraWSInfo.ResumeLayout(False)
        Me.fraWsDates.ResumeLayout(False)
        Me.fraXmit.ResumeLayout(False)
        Me.fraKCOrdInfo.ResumeLayout(False)
        Me.fraWSStatus.ResumeLayout(False)
        Me.fraCustOrdInfo.ResumeLayout(False)
        Me.fraCustOrdInfo.PerformLayout()
        Me.fraDisplayCodes.ResumeLayout(False)
        Me.fraDisplayCodes.PerformLayout()
        Me.tabMemosErrMsg.ResumeLayout(False)
        Me._tabMemosErrMsg_TabPage0.ResumeLayout(False)
        Me._tabMemosErrMsg_TabPage0.PerformLayout()
        Me._tabMemosErrMsg_TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WSErrorMsgBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleForcDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraButtons.ResumeLayout(False)
        Me.fraStatus.ResumeLayout(False)
        Me.fraCustRef.ResumeLayout(False)
        Me.fraCustRef.PerformLayout()
        Me.fraCustType.ResumeLayout(False)
        Me.fraTable.ResumeLayout(False)
        CType(Me.dgvTempItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WSItemTempBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame3.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.fraSortBy.ResumeLayout(False)
        Me.fraItemMatrix.ResumeLayout(False)
        Me.fraItemMatrix.PerformLayout()
        CType(Me.imgPrevOrdered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvColorSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optCustIs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optSortBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optViewBy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
#Region "Upgrade Support"

    Friend WithEvents dgvTempItems As System.Windows.Forms.DataGridView
    Friend WithEvents SaleForcDataSet As KC01.SaleForcDataSet
    Friend WithEvents WSItemTempBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WSItemTempTableAdapter As KC01.SaleForcDataSetTableAdapters.WSItemTempTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents WSErrorMsgBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WSErrorMsgTableAdapter As KC01.SaleForcDataSetTableAdapters.WSErrorMsgTableAdapter
    Friend WithEvents ErrorLevelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MessageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtpCancelBy As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDelvBy As System.Windows.Forms.DateTimePicker
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents dgvColorSize As System.Windows.Forms.DataGridView
    Friend WithEvents DeletedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ReadyForOrderDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ItemNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyOrderedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExtendedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SizeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StyleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Public WithEvents fraStatus As System.Windows.Forms.GroupBox
    Public WithEvents chkReadyToXmit As System.Windows.Forms.CheckBox
    Public WithEvents chkCancel As System.Windows.Forms.CheckBox
    Public WithEvents chkMaintAllowed As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents lblWsNo As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
#End Region
End Class