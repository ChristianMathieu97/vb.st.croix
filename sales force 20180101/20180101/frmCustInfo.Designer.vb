<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCustInfo
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
    Public WithEvents _tabCustInfo_TabPage0 As System.Windows.Forms.TabPage
    Public WithEvents cmdViewOrder As System.Windows.Forms.Button
    Public WithEvents fraOrderList As System.Windows.Forms.GroupBox
    Public WithEvents _tabCustInfo_TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents cmdEmailWorksheet As System.Windows.Forms.Button
    Public WithEvents cmdRetransmit As System.Windows.Forms.Button
    Public WithEvents cmdPrint As System.Windows.Forms.Button
    Public WithEvents chkNoOrderWs As System.Windows.Forms.CheckBox
    Public WithEvents cmdViewEditWs As System.Windows.Forms.Button
    Public WithEvents fraWsList As System.Windows.Forms.GroupBox
    Public WithEvents _tabCustInfo_TabPage2 As System.Windows.Forms.TabPage
    Public WithEvents txtSlsmnRating As System.Windows.Forms.TextBox
    Public WithEvents _lblCustInfo_44 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_43 As System.Windows.Forms.Label
    Public WithEvents lblSlsmnCd As System.Windows.Forms.Label
    Public WithEvents fraSalesmanRef As System.Windows.Forms.GroupBox
    Public WithEvents txtDelq As System.Windows.Forms.TextBox
    Public WithEvents txtTypeCode As System.Windows.Forms.TextBox
    Public WithEvents txtARBal As System.Windows.Forms.TextBox
    Public WithEvents txtHoldAR As System.Windows.Forms.TextBox
    Public WithEvents txtCredRating As System.Windows.Forms.TextBox
    Public WithEvents txtPymtCd As System.Windows.Forms.TextBox
    Public WithEvents txtDelq1 As System.Windows.Forms.TextBox
    Public WithEvents txtLastPmtDate As System.Windows.Forms.TextBox
    Public WithEvents txtLastOrddate As System.Windows.Forms.TextBox
    Public WithEvents txtOpenOrdTot As System.Windows.Forms.TextBox
    Public WithEvents txtAvg2Pay As System.Windows.Forms.TextBox
    Public WithEvents txtLastPmtAmt As System.Windows.Forms.TextBox
    Public WithEvents txtSACustNo As System.Windows.Forms.TextBox
    Public WithEvents txtMailBillTo As System.Windows.Forms.TextBox
    Public WithEvents txtChg2Cust As System.Windows.Forms.TextBox
    Public WithEvents txtLabel As System.Windows.Forms.TextBox
    Public WithEvents _lblCustInfo_22 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_26 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_25 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_24 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_23 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_27 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_29 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_32 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_31 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_28 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_30 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_35 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_34 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_33 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_36 As System.Windows.Forms.Label
    Public WithEvents fraCustRef As System.Windows.Forms.GroupBox
    Public WithEvents chkComplete As System.Windows.Forms.CheckBox
    Public WithEvents chkShipActive As System.Windows.Forms.CheckBox
    Public WithEvents txtShipHoldShpmtCd As System.Windows.Forms.TextBox
    Public WithEvents txtShipTypeCd As System.Windows.Forms.TextBox
    Public WithEvents txtShipPayTerms As System.Windows.Forms.TextBox
    Public WithEvents _lblCustInfo_39 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_37 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_38 As System.Windows.Forms.Label
    Public WithEvents fraShipOther As System.Windows.Forms.GroupBox
    Public WithEvents txtLastChgd As System.Windows.Forms.TextBox
    Public WithEvents txtCustAddDate As System.Windows.Forms.TextBox
    Public WithEvents txtLastUpdated As System.Windows.Forms.TextBox
    Public WithEvents _lblCustInfo_41 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_40 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_42 As System.Windows.Forms.Label
    Public WithEvents fraDates As System.Windows.Forms.GroupBox
    Public WithEvents _tabCustInfo_TabPage3 As System.Windows.Forms.TabPage
    Public WithEvents _tabCustInfo_TabPage4 As System.Windows.Forms.TabPage
    Public WithEvents lblNoWebsite As System.Windows.Forms.Label
    Public WithEvents lblAvailWebsites As System.Windows.Forms.Label
    Public WithEvents Label66 As System.Windows.Forms.Label
    Public WithEvents lblWebsiteLoading As System.Windows.Forms.Label
    Public WithEvents cmbCustomerWebsites As System.Windows.Forms.ComboBox
    Public WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Public WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Public WithEvents cmdWebBack As System.Windows.Forms.Button
    Public WithEvents cmdWebForward As System.Windows.Forms.Button
    Public WithEvents cmdWebStop As System.Windows.Forms.Button
    Public WithEvents cmdWebRefresh As System.Windows.Forms.Button
    Public WithEvents cmdWebOpenBrowser As System.Windows.Forms.Button
    Public WithEvents _tabCustInfo_TabPage5 As System.Windows.Forms.TabPage
    Public WithEvents cmdNewAppointment As System.Windows.Forms.Button
    Public WithEvents cmdOpenAppointment As System.Windows.Forms.Button
    Public WithEvents cmdDeleteAppointment As System.Windows.Forms.Button
    Public WithEvents _tabCustInfo_TabPage6 As System.Windows.Forms.TabPage
    Public WithEvents Label68 As System.Windows.Forms.Label
    Public WithEvents cmbASRView As System.Windows.Forms.ComboBox
    Public WithEvents optSpring As System.Windows.Forms.RadioButton
    Public WithEvents optFall As System.Windows.Forms.RadioButton
    Public WithEvents Timer1 As System.Windows.Forms.Timer
    Public WithEvents cmdPrintGraphs As System.Windows.Forms.Button
    Public WithEvents _tabCustInfo_TabPage7 As System.Windows.Forms.TabPage
    Public WithEvents tabCustInfo As System.Windows.Forms.TabControl
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustInfo))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdViewOrder = New System.Windows.Forms.Button()
        Me.chkNoOrderWs = New System.Windows.Forms.CheckBox()
        Me.cmdViewEditWs = New System.Windows.Forms.Button()
        Me.cmdWebBack = New System.Windows.Forms.Button()
        Me.cmdWebForward = New System.Windows.Forms.Button()
        Me.cmdWebStop = New System.Windows.Forms.Button()
        Me.cmdWebRefresh = New System.Windows.Forms.Button()
        Me.cmdWebOpenBrowser = New System.Windows.Forms.Button()
        Me.btnExitCustInfo = New System.Windows.Forms.Button()
        Me.cmdNewCust = New System.Windows.Forms.Button()
        Me.cmdNewWs = New System.Windows.Forms.Button()
        Me.fraSortOrder = New System.Windows.Forms.GroupBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.cmbAutoCompleteCustName = New System.Windows.Forms.ComboBox()
        Me.optFindByCustNumber = New System.Windows.Forms.RadioButton()
        Me.optFindByCustName = New System.Windows.Forms.RadioButton()
        Me.txtCustID = New System.Windows.Forms.TextBox()
        Me.cmdLast = New System.Windows.Forms.Button()
        Me.cmdPrevious = New System.Windows.Forms.Button()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.cmdFirst = New System.Windows.Forms.Button()
        Me.tabCustInfo = New System.Windows.Forms.TabControl()
        Me._tabCustInfo_TabPage0 = New System.Windows.Forms.TabPage()
        Me.fraStatus = New System.Windows.Forms.GroupBox()
        Me.btnPrintMap = New System.Windows.Forms.Button()
        Me.btnCloseMap = New System.Windows.Forms.Button()
        Me.txtCustStatusCd = New System.Windows.Forms.TextBox()
        Me.bndCustomer = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaleForcDataSet = New KC01.SaleForcDataSet()
        Me.txtShipStatusCd = New System.Windows.Forms.TextBox()
        Me.bndCustomerShip = New System.Windows.Forms.BindingSource(Me.components)
        Me._lblCustInfo_20 = New System.Windows.Forms.Label()
        Me._lblCustInfo_21 = New System.Windows.Forms.Label()
        Me.fraFileCust = New System.Windows.Forms.GroupBox()
        Me.btnMap = New System.Windows.Forms.Button()
        Me.dblShipNoList = New System.Windows.Forms.ListBox()
        Me.txtCustNo = New System.Windows.Forms.TextBox()
        Me.txtSelectedShip = New System.Windows.Forms.TextBox()
        Me.cmdCustShipUpdate = New System.Windows.Forms.Button()
        Me.chkViewActiveCust = New System.Windows.Forms.CheckBox()
        Me.Frame4 = New System.Windows.Forms.GroupBox()
        Me.lblCustContactEmail = New System.Windows.Forms.LinkLabel()
        Me._lblCustInfo_19 = New System.Windows.Forms.Label()
        Me._lblCustInfo_17 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me._lblCustInfo_18 = New System.Windows.Forms.Label()
        Me.lblPhoneNo = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblFaxNo = New System.Windows.Forms.Label()
        Me.cmdCustomerUpdate = New System.Windows.Forms.Button()
        Me.Frame5 = New System.Windows.Forms.GroupBox()
        Me.lblCustEmail = New System.Windows.Forms.LinkLabel()
        Me.lblCustShipVia = New System.Windows.Forms.Label()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.lblZipCode = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblAddr1 = New System.Windows.Forms.Label()
        Me.lblAddr2 = New System.Windows.Forms.Label()
        Me.lblAddr3 = New System.Windows.Forms.Label()
        Me.lblCustShipViaDesc = New System.Windows.Forms.Label()
        Me._lblCustInfo_11 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.lblNoShipToInfo = New System.Windows.Forms.Label()
        Me.lblCustSHWebsite = New System.Windows.Forms.LinkLabel()
        Me.lblCustSHEmail = New System.Windows.Forms.LinkLabel()
        Me.lblShipName = New System.Windows.Forms.Label()
        Me.lblShipViaCd = New System.Windows.Forms.Label()
        Me.lblShipCountry = New System.Windows.Forms.Label()
        Me.lblShipZipcode = New System.Windows.Forms.Label()
        Me.lblShipSt = New System.Windows.Forms.Label()
        Me.lblShipCity = New System.Windows.Forms.Label()
        Me.lblShipAddr1 = New System.Windows.Forms.Label()
        Me.lblShipAddr2 = New System.Windows.Forms.Label()
        Me.lblShipAddr3 = New System.Windows.Forms.Label()
        Me.lblShipViaDesc = New System.Windows.Forms.Label()
        Me._lblCustInfo_12 = New System.Windows.Forms.Label()
        Me._lblCustInfo_10 = New System.Windows.Forms.Label()
        Me._lblCustInfo_3 = New System.Windows.Forms.Label()
        Me.lblDblCnt = New System.Windows.Forms.Label()
        Me._lblCustInfo_2 = New System.Windows.Forms.Label()
        Me.lblDefaultShip = New System.Windows.Forms.Label()
        Me._lblCustInfo_0 = New System.Windows.Forms.Label()
        Me._lblCustInfo_1 = New System.Windows.Forms.Label()
        Me._lblCustInfo_4 = New System.Windows.Forms.Label()
        Me._lblCustInfo_6 = New System.Windows.Forms.Label()
        Me._lblCustInfo_5 = New System.Windows.Forms.Label()
        Me._lblCustInfo_8 = New System.Windows.Forms.Label()
        Me._lblCustInfo_7 = New System.Windows.Forms.Label()
        Me._lblCustInfo_9 = New System.Windows.Forms.Label()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.lblCustSHContactEmail = New System.Windows.Forms.LinkLabel()
        Me._lblCustInfo_16 = New System.Windows.Forms.Label()
        Me.lblShipFax = New System.Windows.Forms.Label()
        Me.lblShipContact = New System.Windows.Forms.Label()
        Me.lblShipPhone = New System.Windows.Forms.Label()
        Me._lblCustInfo_15 = New System.Windows.Forms.Label()
        Me._lblCustInfo_14 = New System.Windows.Forms.Label()
        Me._lblCustInfo_13 = New System.Windows.Forms.Label()
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser()
        Me.fraNewCust = New System.Windows.Forms.GroupBox()
        Me.chkCopyCust2CustSh = New System.Windows.Forms.CheckBox()
        Me.cmdNewCustFinished = New System.Windows.Forms.Button()
        Me.fraCustContactInfo = New System.Windows.Forms.GroupBox()
        Me.mebPhoneNo = New System.Windows.Forms.MaskedTextBox()
        Me.mebFaxNo = New System.Windows.Forms.MaskedTextBox()
        Me.mebContact = New System.Windows.Forms.MaskedTextBox()
        Me.mebCustContactEmail = New System.Windows.Forms.MaskedTextBox()
        Me._lblCustInfo_55 = New System.Windows.Forms.Label()
        Me._lblCustInfo_52 = New System.Windows.Forms.Label()
        Me._lblCustInfo_53 = New System.Windows.Forms.Label()
        Me._lblCustInfo_54 = New System.Windows.Forms.Label()
        Me.fraShipContact = New System.Windows.Forms.GroupBox()
        Me.mebShipContact = New System.Windows.Forms.MaskedTextBox()
        Me.mebShipFax = New System.Windows.Forms.MaskedTextBox()
        Me.mebShipPhone = New System.Windows.Forms.MaskedTextBox()
        Me.mebCustShContactEmail = New System.Windows.Forms.MaskedTextBox()
        Me._lblCustInfo_58 = New System.Windows.Forms.Label()
        Me._lblCustInfo_59 = New System.Windows.Forms.Label()
        Me._lblCustInfo_56 = New System.Windows.Forms.Label()
        Me._lblCustInfo_57 = New System.Windows.Forms.Label()
        Me.fraCustAddr = New System.Windows.Forms.GroupBox()
        Me.mebAddr1 = New System.Windows.Forms.MaskedTextBox()
        Me.mebCity = New System.Windows.Forms.MaskedTextBox()
        Me.mebName = New System.Windows.Forms.MaskedTextBox()
        Me.mebAddr2 = New System.Windows.Forms.MaskedTextBox()
        Me.mebAddr3 = New System.Windows.Forms.MaskedTextBox()
        Me.mebState = New System.Windows.Forms.MaskedTextBox()
        Me.mebZipCode = New System.Windows.Forms.MaskedTextBox()
        Me.mebCustEmail = New System.Windows.Forms.MaskedTextBox()
        Me.fraShipAddr = New System.Windows.Forms.GroupBox()
        Me.mebCustShEmail = New System.Windows.Forms.MaskedTextBox()
        Me.mebWebsite = New System.Windows.Forms.MaskedTextBox()
        Me.mebShipZipCode = New System.Windows.Forms.MaskedTextBox()
        Me.mebShipSt = New System.Windows.Forms.MaskedTextBox()
        Me.mebShipCity = New System.Windows.Forms.MaskedTextBox()
        Me.mebShipAddr3 = New System.Windows.Forms.MaskedTextBox()
        Me.mebShipAddr2 = New System.Windows.Forms.MaskedTextBox()
        Me.mebShipAddr1 = New System.Windows.Forms.MaskedTextBox()
        Me.mebShipName = New System.Windows.Forms.MaskedTextBox()
        Me._lblCustInfo_51 = New System.Windows.Forms.Label()
        Me._lblCustInfo_50 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.lblTempShipNo = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.lblTempCustNo = New System.Windows.Forms.Label()
        Me._lblCustInfo_45 = New System.Windows.Forms.Label()
        Me._lblCustInfo_47 = New System.Windows.Forms.Label()
        Me._lblCustInfo_46 = New System.Windows.Forms.Label()
        Me._lblCustInfo_49 = New System.Windows.Forms.Label()
        Me._lblCustInfo_48 = New System.Windows.Forms.Label()
        Me._tabCustInfo_TabPage1 = New System.Windows.Forms.TabPage()
        Me.fraOrderList = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvOrders = New System.Windows.Forms.DataGridView()
        Me.OrdernoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeasonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompletedateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyorigordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyshippedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyopenorderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenValueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WorksheetIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvoicenoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustpoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastUpDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bndOrders = New System.Windows.Forms.BindingSource(Me.components)
        Me._tabCustInfo_TabPage2 = New System.Windows.Forms.TabPage()
        Me.fraWsList = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvWorksheets = New System.Windows.Forms.DataGridView()
        Me.WorksheetidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AllowmanualmaintDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ReadyToXmitDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.XmittedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.WscreatedateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransmittalstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransmittaldateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValidationstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValidationdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrdernoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderdateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ErrorlevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.season = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bndWorksheets = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmdEmailWorksheet = New System.Windows.Forms.Button()
        Me.cmdRetransmit = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me._tabCustInfo_TabPage3 = New System.Windows.Forms.TabPage()
        Me.fraSalesmanRef = New System.Windows.Forms.GroupBox()
        Me.txtSlsmnRating = New System.Windows.Forms.TextBox()
        Me._lblCustInfo_44 = New System.Windows.Forms.Label()
        Me._lblCustInfo_43 = New System.Windows.Forms.Label()
        Me.lblSlsmnCd = New System.Windows.Forms.Label()
        Me.fraCustRef = New System.Windows.Forms.GroupBox()
        Me.txtDelq = New System.Windows.Forms.TextBox()
        Me.txtTypeCode = New System.Windows.Forms.TextBox()
        Me.txtARBal = New System.Windows.Forms.TextBox()
        Me.txtHoldAR = New System.Windows.Forms.TextBox()
        Me.txtCredRating = New System.Windows.Forms.TextBox()
        Me.txtPymtCd = New System.Windows.Forms.TextBox()
        Me.txtDelq1 = New System.Windows.Forms.TextBox()
        Me.txtLastPmtDate = New System.Windows.Forms.TextBox()
        Me.txtLastOrddate = New System.Windows.Forms.TextBox()
        Me.txtOpenOrdTot = New System.Windows.Forms.TextBox()
        Me.txtAvg2Pay = New System.Windows.Forms.TextBox()
        Me.txtLastPmtAmt = New System.Windows.Forms.TextBox()
        Me.txtSACustNo = New System.Windows.Forms.TextBox()
        Me.txtMailBillTo = New System.Windows.Forms.TextBox()
        Me.txtChg2Cust = New System.Windows.Forms.TextBox()
        Me.txtLabel = New System.Windows.Forms.TextBox()
        Me._lblCustInfo_22 = New System.Windows.Forms.Label()
        Me._lblCustInfo_26 = New System.Windows.Forms.Label()
        Me._lblCustInfo_25 = New System.Windows.Forms.Label()
        Me._lblCustInfo_24 = New System.Windows.Forms.Label()
        Me._lblCustInfo_23 = New System.Windows.Forms.Label()
        Me._lblCustInfo_27 = New System.Windows.Forms.Label()
        Me._lblCustInfo_29 = New System.Windows.Forms.Label()
        Me._lblCustInfo_32 = New System.Windows.Forms.Label()
        Me._lblCustInfo_31 = New System.Windows.Forms.Label()
        Me._lblCustInfo_28 = New System.Windows.Forms.Label()
        Me._lblCustInfo_30 = New System.Windows.Forms.Label()
        Me._lblCustInfo_35 = New System.Windows.Forms.Label()
        Me._lblCustInfo_34 = New System.Windows.Forms.Label()
        Me._lblCustInfo_33 = New System.Windows.Forms.Label()
        Me._lblCustInfo_36 = New System.Windows.Forms.Label()
        Me.fraShipOther = New System.Windows.Forms.GroupBox()
        Me.chkComplete = New System.Windows.Forms.CheckBox()
        Me.chkShipActive = New System.Windows.Forms.CheckBox()
        Me.txtShipHoldShpmtCd = New System.Windows.Forms.TextBox()
        Me.txtShipTypeCd = New System.Windows.Forms.TextBox()
        Me.txtShipPayTerms = New System.Windows.Forms.TextBox()
        Me._lblCustInfo_39 = New System.Windows.Forms.Label()
        Me._lblCustInfo_37 = New System.Windows.Forms.Label()
        Me._lblCustInfo_38 = New System.Windows.Forms.Label()
        Me.fraDates = New System.Windows.Forms.GroupBox()
        Me.txtLastChgd = New System.Windows.Forms.TextBox()
        Me.txtCustAddDate = New System.Windows.Forms.TextBox()
        Me.txtLastUpdated = New System.Windows.Forms.TextBox()
        Me._lblCustInfo_41 = New System.Windows.Forms.Label()
        Me._lblCustInfo_40 = New System.Windows.Forms.Label()
        Me._lblCustInfo_42 = New System.Windows.Forms.Label()
        Me._tabCustInfo_TabPage4 = New System.Windows.Forms.TabPage()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.dgvCustomerMemos = New System.Windows.Forms.DataGridView()
        Me.MemoLineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PageNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LineNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bndCustMemos = New System.Windows.Forms.BindingSource(Me.components)
        Me._tabCustInfo_TabPage5 = New System.Windows.Forms.TabPage()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.lblNoWebsite = New System.Windows.Forms.Label()
        Me.lblAvailWebsites = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.lblWebsiteLoading = New System.Windows.Forms.Label()
        Me.cmbCustomerWebsites = New System.Windows.Forms.ComboBox()
        Me.picLoadingWeb = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me._tabCustInfo_TabPage6 = New System.Windows.Forms.TabPage()
        Me.lblNoAppts = New System.Windows.Forms.Label()
        Me.dgvCustomerAppointments = New System.Windows.Forms.DataGridView()
        Me.cmdNewAppointment = New System.Windows.Forms.Button()
        Me.cmdOpenAppointment = New System.Windows.Forms.Button()
        Me.cmdDeleteAppointment = New System.Windows.Forms.Button()
        Me._tabCustInfo_TabPage7 = New System.Windows.Forms.TabPage()
        Me.pnlNotes = New System.Windows.Forms.Panel()
        Me.dtpNotesFollowup = New System.Windows.Forms.DateTimePicker()
        Me.txtNoteGenComments = New System.Windows.Forms.TextBox()
        Me.cmdEmailNotes = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.dgvNotes = New System.Windows.Forms.DataGridView()
        Me.pnlASR = New System.Windows.Forms.Panel()
        Me.cmdEmailASR = New System.Windows.Forms.Button()
        Me.dgvASR = New System.Windows.Forms.DataGridView()
        Me.pnlHistory = New System.Windows.Forms.Panel()
        Me.cmdPrintHistory = New System.Windows.Forms.Button()
        Me.txtHistoryComments = New System.Windows.Forms.TextBox()
        Me.dgvHistory = New System.Windows.Forms.DataGridView()
        Me.pnlPass = New System.Windows.Forms.Panel()
        Me.cmdEmailPass = New System.Windows.Forms.Button()
        Me.dgvPass = New System.Windows.Forms.DataGridView()
        Me.pnlHistoryGraphs = New System.Windows.Forms.Panel()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.cmbASRView = New System.Windows.Forms.ComboBox()
        Me.optSpring = New System.Windows.Forms.RadioButton()
        Me.optFall = New System.Windows.Forms.RadioButton()
        Me.cmdPrintGraphs = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdNewCustEdit = New System.Windows.Forms.Button()
        Me.fraExitBtn = New System.Windows.Forms.GroupBox()
        Me.grbNavigation = New System.Windows.Forms.GroupBox()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerTableAdapter = New KC01.SaleForcDataSetTableAdapters.CustomerTableAdapter()
        Me.CustomerSHTableAdapter = New KC01.SaleForcDataSetTableAdapters.CustomerSHTableAdapter()
        Me.OrderTableAdapter = New KC01.SaleForcDataSetTableAdapters.OrderTableAdapter()
        Me.Ws_ord_headTableAdapter = New KC01.SaleForcDataSetTableAdapters.ws_ord_headTableAdapter()
        Me.CustomerMemoTableAdapter = New KC01.SaleForcDataSetTableAdapters.CustomerMemoTableAdapter()
        Me.bndCustAutoComplete = New System.Windows.Forms.BindingSource(Me.components)
        Me.NotesCommentsTableAdapter = New KC01.SaleForcDataSetTableAdapters.NotesCommentsTableAdapter()
        Me.fraSortOrder.SuspendLayout()
        Me.tabCustInfo.SuspendLayout()
        Me._tabCustInfo_TabPage0.SuspendLayout()
        Me.fraStatus.SuspendLayout()
        CType(Me.bndCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleForcDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndCustomerShip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraFileCust.SuspendLayout()
        Me.Frame4.SuspendLayout()
        Me.Frame5.SuspendLayout()
        Me.Frame3.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.fraNewCust.SuspendLayout()
        Me.fraCustContactInfo.SuspendLayout()
        Me.fraShipContact.SuspendLayout()
        Me.fraCustAddr.SuspendLayout()
        Me.fraShipAddr.SuspendLayout()
        Me._tabCustInfo_TabPage1.SuspendLayout()
        Me.fraOrderList.SuspendLayout()
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._tabCustInfo_TabPage2.SuspendLayout()
        Me.fraWsList.SuspendLayout()
        CType(Me.dgvWorksheets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndWorksheets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._tabCustInfo_TabPage3.SuspendLayout()
        Me.fraSalesmanRef.SuspendLayout()
        Me.fraCustRef.SuspendLayout()
        Me.fraShipOther.SuspendLayout()
        Me.fraDates.SuspendLayout()
        Me._tabCustInfo_TabPage4.SuspendLayout()
        Me.Frame1.SuspendLayout()
        CType(Me.dgvCustomerMemos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndCustMemos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._tabCustInfo_TabPage5.SuspendLayout()
        CType(Me.picLoadingWeb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._tabCustInfo_TabPage6.SuspendLayout()
        CType(Me.dgvCustomerAppointments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._tabCustInfo_TabPage7.SuspendLayout()
        Me.pnlNotes.SuspendLayout()
        CType(Me.dgvNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlASR.SuspendLayout()
        CType(Me.dgvASR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHistory.SuspendLayout()
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPass.SuspendLayout()
        CType(Me.dgvPass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraExitBtn.SuspendLayout()
        Me.grbNavigation.SuspendLayout()
        CType(Me.bndCustAutoComplete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdViewOrder
        '
        Me.cmdViewOrder.BackColor = System.Drawing.SystemColors.Control
        Me.cmdViewOrder.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdViewOrder.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdViewOrder.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdViewOrder.Location = New System.Drawing.Point(22, 16)
        Me.cmdViewOrder.Name = "cmdViewOrder"
        Me.cmdViewOrder.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdViewOrder.Size = New System.Drawing.Size(97, 25)
        Me.cmdViewOrder.TabIndex = 12
        Me.cmdViewOrder.Text = "&View"
        Me.ToolTip1.SetToolTip(Me.cmdViewOrder, "View the order selected")
        Me.cmdViewOrder.UseVisualStyleBackColor = False
        '
        'chkNoOrderWs
        '
        Me.chkNoOrderWs.BackColor = System.Drawing.SystemColors.Control
        Me.chkNoOrderWs.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkNoOrderWs.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNoOrderWs.ForeColor = System.Drawing.Color.Blue
        Me.chkNoOrderWs.Location = New System.Drawing.Point(344, 15)
        Me.chkNoOrderWs.Name = "chkNoOrderWs"
        Me.chkNoOrderWs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkNoOrderWs.Size = New System.Drawing.Size(257, 17)
        Me.chkNoOrderWs.TabIndex = 166
        Me.chkNoOrderWs.Text = "Don't show Worksheets that are orders"
        Me.ToolTip1.SetToolTip(Me.chkNoOrderWs, "Click to turn check on and off")
        Me.chkNoOrderWs.UseVisualStyleBackColor = False
        '
        'cmdViewEditWs
        '
        Me.cmdViewEditWs.BackColor = System.Drawing.SystemColors.Control
        Me.cmdViewEditWs.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdViewEditWs.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdViewEditWs.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdViewEditWs.Location = New System.Drawing.Point(8, 16)
        Me.cmdViewEditWs.Name = "cmdViewEditWs"
        Me.cmdViewEditWs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdViewEditWs.Size = New System.Drawing.Size(105, 25)
        Me.cmdViewEditWs.TabIndex = 165
        Me.cmdViewEditWs.Text = "View/&Edit"
        Me.ToolTip1.SetToolTip(Me.cmdViewEditWs, "View or edit the selected worksheet")
        Me.cmdViewEditWs.UseVisualStyleBackColor = False
        '
        'cmdWebBack
        '
        Me.cmdWebBack.BackColor = System.Drawing.SystemColors.Control
        Me.cmdWebBack.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdWebBack.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdWebBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdWebBack.Image = CType(resources.GetObject("cmdWebBack.Image"), System.Drawing.Image)
        Me.cmdWebBack.Location = New System.Drawing.Point(11, 18)
        Me.cmdWebBack.Name = "cmdWebBack"
        Me.cmdWebBack.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdWebBack.Size = New System.Drawing.Size(38, 33)
        Me.cmdWebBack.TabIndex = 209
        Me.ToolTip1.SetToolTip(Me.cmdWebBack, "Go Back")
        Me.cmdWebBack.UseVisualStyleBackColor = False
        '
        'cmdWebForward
        '
        Me.cmdWebForward.BackColor = System.Drawing.SystemColors.Control
        Me.cmdWebForward.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdWebForward.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdWebForward.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdWebForward.Image = CType(resources.GetObject("cmdWebForward.Image"), System.Drawing.Image)
        Me.cmdWebForward.Location = New System.Drawing.Point(56, 18)
        Me.cmdWebForward.Name = "cmdWebForward"
        Me.cmdWebForward.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdWebForward.Size = New System.Drawing.Size(38, 33)
        Me.cmdWebForward.TabIndex = 210
        Me.ToolTip1.SetToolTip(Me.cmdWebForward, "Go forward")
        Me.cmdWebForward.UseVisualStyleBackColor = False
        '
        'cmdWebStop
        '
        Me.cmdWebStop.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdWebStop.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdWebStop.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdWebStop.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdWebStop.Image = CType(resources.GetObject("cmdWebStop.Image"), System.Drawing.Image)
        Me.cmdWebStop.Location = New System.Drawing.Point(663, 11)
        Me.cmdWebStop.Name = "cmdWebStop"
        Me.cmdWebStop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdWebStop.Size = New System.Drawing.Size(38, 40)
        Me.cmdWebStop.TabIndex = 211
        Me.ToolTip1.SetToolTip(Me.cmdWebStop, "Stop")
        Me.cmdWebStop.UseVisualStyleBackColor = False
        '
        'cmdWebRefresh
        '
        Me.cmdWebRefresh.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdWebRefresh.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdWebRefresh.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdWebRefresh.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdWebRefresh.Image = CType(resources.GetObject("cmdWebRefresh.Image"), System.Drawing.Image)
        Me.cmdWebRefresh.Location = New System.Drawing.Point(700, 11)
        Me.cmdWebRefresh.Name = "cmdWebRefresh"
        Me.cmdWebRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdWebRefresh.Size = New System.Drawing.Size(38, 40)
        Me.cmdWebRefresh.TabIndex = 212
        Me.ToolTip1.SetToolTip(Me.cmdWebRefresh, "Refresh")
        Me.cmdWebRefresh.UseVisualStyleBackColor = False
        '
        'cmdWebOpenBrowser
        '
        Me.cmdWebOpenBrowser.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdWebOpenBrowser.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdWebOpenBrowser.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdWebOpenBrowser.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdWebOpenBrowser.Image = CType(resources.GetObject("cmdWebOpenBrowser.Image"), System.Drawing.Image)
        Me.cmdWebOpenBrowser.Location = New System.Drawing.Point(739, 11)
        Me.cmdWebOpenBrowser.Name = "cmdWebOpenBrowser"
        Me.cmdWebOpenBrowser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdWebOpenBrowser.Size = New System.Drawing.Size(38, 40)
        Me.cmdWebOpenBrowser.TabIndex = 213
        Me.ToolTip1.SetToolTip(Me.cmdWebOpenBrowser, "Open customer's website in default browser")
        Me.cmdWebOpenBrowser.UseVisualStyleBackColor = False
        '
        'btnExitCustInfo
        '
        Me.btnExitCustInfo.BackColor = System.Drawing.SystemColors.Control
        Me.btnExitCustInfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExitCustInfo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitCustInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExitCustInfo.Location = New System.Drawing.Point(8, 16)
        Me.btnExitCustInfo.Name = "btnExitCustInfo"
        Me.btnExitCustInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExitCustInfo.Size = New System.Drawing.Size(97, 25)
        Me.btnExitCustInfo.TabIndex = 1
        Me.btnExitCustInfo.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExitCustInfo, "Exit customer information screen")
        Me.btnExitCustInfo.UseVisualStyleBackColor = False
        '
        'cmdNewCust
        '
        Me.cmdNewCust.BackColor = System.Drawing.SystemColors.Control
        Me.cmdNewCust.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdNewCust.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNewCust.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdNewCust.Location = New System.Drawing.Point(152, 16)
        Me.cmdNewCust.Name = "cmdNewCust"
        Me.cmdNewCust.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdNewCust.Size = New System.Drawing.Size(105, 25)
        Me.cmdNewCust.TabIndex = 7
        Me.cmdNewCust.Text = "New &Customer"
        Me.ToolTip1.SetToolTip(Me.cmdNewCust, "Create a new customer")
        Me.cmdNewCust.UseVisualStyleBackColor = False
        '
        'cmdNewWs
        '
        Me.cmdNewWs.BackColor = System.Drawing.SystemColors.Control
        Me.cmdNewWs.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdNewWs.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNewWs.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdNewWs.Location = New System.Drawing.Point(152, 48)
        Me.cmdNewWs.Name = "cmdNewWs"
        Me.cmdNewWs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdNewWs.Size = New System.Drawing.Size(105, 25)
        Me.cmdNewWs.TabIndex = 8
        Me.cmdNewWs.Text = "New &Worksheet"
        Me.ToolTip1.SetToolTip(Me.cmdNewWs, "Create a new worksheet")
        Me.cmdNewWs.UseVisualStyleBackColor = False
        '
        'fraSortOrder
        '
        Me.fraSortOrder.BackColor = System.Drawing.SystemColors.Control
        Me.fraSortOrder.Controls.Add(Me.btnGo)
        Me.fraSortOrder.Controls.Add(Me.cmbAutoCompleteCustName)
        Me.fraSortOrder.Controls.Add(Me.optFindByCustNumber)
        Me.fraSortOrder.Controls.Add(Me.optFindByCustName)
        Me.fraSortOrder.Controls.Add(Me.txtCustID)
        Me.fraSortOrder.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraSortOrder.ForeColor = System.Drawing.Color.Blue
        Me.fraSortOrder.Location = New System.Drawing.Point(263, 0)
        Me.fraSortOrder.Name = "fraSortOrder"
        Me.fraSortOrder.Padding = New System.Windows.Forms.Padding(0)
        Me.fraSortOrder.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraSortOrder.Size = New System.Drawing.Size(541, 50)
        Me.fraSortOrder.TabIndex = 58
        Me.fraSortOrder.TabStop = False
        Me.fraSortOrder.Text = "Find Customer By"
        Me.ToolTip1.SetToolTip(Me.fraSortOrder, "Select sort on customer number or name")
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(409, 13)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(37, 21)
        Me.btnGo.TabIndex = 65
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'cmbAutoCompleteCustName
        '
        Me.cmbAutoCompleteCustName.DropDownHeight = 400
        Me.cmbAutoCompleteCustName.FormattingEnabled = True
        Me.cmbAutoCompleteCustName.IntegralHeight = False
        Me.cmbAutoCompleteCustName.Location = New System.Drawing.Point(142, 11)
        Me.cmbAutoCompleteCustName.Name = "cmbAutoCompleteCustName"
        Me.cmbAutoCompleteCustName.Size = New System.Drawing.Size(262, 22)
        Me.cmbAutoCompleteCustName.TabIndex = 64
        '
        'optFindByCustNumber
        '
        Me.optFindByCustNumber.BackColor = System.Drawing.SystemColors.Control
        Me.optFindByCustNumber.Cursor = System.Windows.Forms.Cursors.Default
        Me.optFindByCustNumber.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optFindByCustNumber.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optFindByCustNumber.Location = New System.Drawing.Point(8, 16)
        Me.optFindByCustNumber.Name = "optFindByCustNumber"
        Me.optFindByCustNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optFindByCustNumber.Size = New System.Drawing.Size(65, 17)
        Me.optFindByCustNumber.TabIndex = 15
        Me.optFindByCustNumber.Text = "Number"
        Me.optFindByCustNumber.UseVisualStyleBackColor = False
        '
        'optFindByCustName
        '
        Me.optFindByCustName.BackColor = System.Drawing.SystemColors.Control
        Me.optFindByCustName.Checked = True
        Me.optFindByCustName.Cursor = System.Windows.Forms.Cursors.Default
        Me.optFindByCustName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optFindByCustName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optFindByCustName.Location = New System.Drawing.Point(79, 16)
        Me.optFindByCustName.Name = "optFindByCustName"
        Me.optFindByCustName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optFindByCustName.Size = New System.Drawing.Size(57, 17)
        Me.optFindByCustName.TabIndex = 16
        Me.optFindByCustName.TabStop = True
        Me.optFindByCustName.Text = "Name"
        Me.optFindByCustName.UseVisualStyleBackColor = False
        '
        'txtCustID
        '
        Me.txtCustID.AcceptsReturn = True
        Me.txtCustID.BackColor = System.Drawing.SystemColors.Window
        Me.txtCustID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCustID.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCustID.Location = New System.Drawing.Point(142, 12)
        Me.txtCustID.MaxLength = 100
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCustID.Size = New System.Drawing.Size(262, 22)
        Me.txtCustID.TabIndex = 63
        Me.txtCustID.TabStop = False
        Me.ToolTip1.SetToolTip(Me.txtCustID, "Customer number")
        '
        'cmdLast
        '
        Me.cmdLast.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdLast.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLast.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLast.Enabled = False
        Me.cmdLast.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLast.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLast.Location = New System.Drawing.Point(210, 17)
        Me.cmdLast.Name = "cmdLast"
        Me.cmdLast.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLast.Size = New System.Drawing.Size(59, 22)
        Me.cmdLast.TabIndex = 71
        Me.cmdLast.Text = "&Last"
        Me.ToolTip1.SetToolTip(Me.cmdLast, "Go to the last customer record")
        Me.cmdLast.UseVisualStyleBackColor = False
        '
        'cmdPrevious
        '
        Me.cmdPrevious.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdPrevious.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrevious.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrevious.Enabled = False
        Me.cmdPrevious.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrevious.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrevious.Location = New System.Drawing.Point(70, 17)
        Me.cmdPrevious.Name = "cmdPrevious"
        Me.cmdPrevious.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrevious.Size = New System.Drawing.Size(66, 22)
        Me.cmdPrevious.TabIndex = 70
        Me.cmdPrevious.Text = "&Previous"
        Me.ToolTip1.SetToolTip(Me.cmdPrevious, "Go to the previous customer record")
        Me.cmdPrevious.UseVisualStyleBackColor = False
        '
        'cmdNext
        '
        Me.cmdNext.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdNext.BackColor = System.Drawing.SystemColors.Control
        Me.cmdNext.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdNext.Enabled = False
        Me.cmdNext.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNext.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdNext.Location = New System.Drawing.Point(142, 17)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdNext.Size = New System.Drawing.Size(59, 22)
        Me.cmdNext.TabIndex = 69
        Me.cmdNext.Text = "&Next"
        Me.ToolTip1.SetToolTip(Me.cmdNext, "Go to the next customer record")
        Me.cmdNext.UseVisualStyleBackColor = False
        '
        'cmdFirst
        '
        Me.cmdFirst.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdFirst.BackColor = System.Drawing.SystemColors.Control
        Me.cmdFirst.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFirst.Enabled = False
        Me.cmdFirst.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFirst.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdFirst.Location = New System.Drawing.Point(7, 17)
        Me.cmdFirst.Name = "cmdFirst"
        Me.cmdFirst.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdFirst.Size = New System.Drawing.Size(59, 22)
        Me.cmdFirst.TabIndex = 72
        Me.cmdFirst.Text = "&First"
        Me.ToolTip1.SetToolTip(Me.cmdFirst, "Go to the first customer record")
        Me.cmdFirst.UseVisualStyleBackColor = False
        '
        'tabCustInfo
        '
        Me.tabCustInfo.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabCustInfo.Controls.Add(Me._tabCustInfo_TabPage0)
        Me.tabCustInfo.Controls.Add(Me._tabCustInfo_TabPage1)
        Me.tabCustInfo.Controls.Add(Me._tabCustInfo_TabPage2)
        Me.tabCustInfo.Controls.Add(Me._tabCustInfo_TabPage3)
        Me.tabCustInfo.Controls.Add(Me._tabCustInfo_TabPage4)
        Me.tabCustInfo.Controls.Add(Me._tabCustInfo_TabPage5)
        Me.tabCustInfo.Controls.Add(Me._tabCustInfo_TabPage6)
        Me.tabCustInfo.Controls.Add(Me._tabCustInfo_TabPage7)
        Me.tabCustInfo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabCustInfo.ItemSize = New System.Drawing.Size(42, 18)
        Me.tabCustInfo.Location = New System.Drawing.Point(0, 80)
        Me.tabCustInfo.Name = "tabCustInfo"
        Me.tabCustInfo.SelectedIndex = 0
        Me.tabCustInfo.Size = New System.Drawing.Size(791, 512)
        Me.tabCustInfo.TabIndex = 10
        Me.tabCustInfo.TabStop = False
        '
        '_tabCustInfo_TabPage0
        '
        Me._tabCustInfo_TabPage0.Controls.Add(Me.fraStatus)
        Me._tabCustInfo_TabPage0.Controls.Add(Me.fraFileCust)
        Me._tabCustInfo_TabPage0.Controls.Add(Me.fraNewCust)
        Me._tabCustInfo_TabPage0.Location = New System.Drawing.Point(4, 22)
        Me._tabCustInfo_TabPage0.Name = "_tabCustInfo_TabPage0"
        Me._tabCustInfo_TabPage0.Size = New System.Drawing.Size(783, 486)
        Me._tabCustInfo_TabPage0.TabIndex = 0
        Me._tabCustInfo_TabPage0.Text = "Addresses"
        Me._tabCustInfo_TabPage0.UseVisualStyleBackColor = True
        '
        'fraStatus
        '
        Me.fraStatus.BackColor = System.Drawing.SystemColors.Control
        Me.fraStatus.Controls.Add(Me.btnPrintMap)
        Me.fraStatus.Controls.Add(Me.btnCloseMap)
        Me.fraStatus.Controls.Add(Me.txtCustStatusCd)
        Me.fraStatus.Controls.Add(Me.txtShipStatusCd)
        Me.fraStatus.Controls.Add(Me._lblCustInfo_20)
        Me.fraStatus.Controls.Add(Me._lblCustInfo_21)
        Me.fraStatus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.fraStatus.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraStatus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraStatus.Location = New System.Drawing.Point(2, 406)
        Me.fraStatus.Name = "fraStatus"
        Me.fraStatus.Padding = New System.Windows.Forms.Padding(0)
        Me.fraStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraStatus.Size = New System.Drawing.Size(820, 35)
        Me.fraStatus.TabIndex = 20
        Me.fraStatus.TabStop = False
        '
        'btnPrintMap
        '
        Me.btnPrintMap.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnPrintMap.ForeColor = System.Drawing.Color.LightGray
        Me.btnPrintMap.Location = New System.Drawing.Point(601, 9)
        Me.btnPrintMap.Name = "btnPrintMap"
        Me.btnPrintMap.Size = New System.Drawing.Size(87, 24)
        Me.btnPrintMap.TabIndex = 26
        Me.btnPrintMap.Text = "Print Map!"
        Me.btnPrintMap.UseVisualStyleBackColor = False
        Me.btnPrintMap.Visible = False
        '
        'btnCloseMap
        '
        Me.btnCloseMap.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCloseMap.ForeColor = System.Drawing.Color.LightGray
        Me.btnCloseMap.Location = New System.Drawing.Point(691, 9)
        Me.btnCloseMap.Name = "btnCloseMap"
        Me.btnCloseMap.Size = New System.Drawing.Size(87, 24)
        Me.btnCloseMap.TabIndex = 25
        Me.btnCloseMap.Text = "Close Map!"
        Me.btnCloseMap.UseVisualStyleBackColor = False
        Me.btnCloseMap.Visible = False
        '
        'txtCustStatusCd
        '
        Me.txtCustStatusCd.AcceptsReturn = True
        Me.txtCustStatusCd.BackColor = System.Drawing.SystemColors.Window
        Me.txtCustStatusCd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCustStatusCd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomer, "Status-code", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtCustStatusCd.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustStatusCd.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCustStatusCd.Location = New System.Drawing.Point(216, 10)
        Me.txtCustStatusCd.MaxLength = 0
        Me.txtCustStatusCd.Name = "txtCustStatusCd"
        Me.txtCustStatusCd.ReadOnly = True
        Me.txtCustStatusCd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCustStatusCd.Size = New System.Drawing.Size(25, 20)
        Me.txtCustStatusCd.TabIndex = 22
        Me.txtCustStatusCd.TabStop = False
        '
        'bndCustomer
        '
        Me.bndCustomer.AllowNew = False
        Me.bndCustomer.DataMember = "Customer"
        Me.bndCustomer.DataSource = Me.SaleForcDataSet
        '
        'SaleForcDataSet
        '
        Me.SaleForcDataSet.DataSetName = "SaleForcDataSet"
        Me.SaleForcDataSet.EnforceConstraints = False
        Me.SaleForcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtShipStatusCd
        '
        Me.txtShipStatusCd.AcceptsReturn = True
        Me.txtShipStatusCd.BackColor = System.Drawing.SystemColors.Window
        Me.txtShipStatusCd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShipStatusCd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomerShip, "Status-code", True))
        Me.txtShipStatusCd.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShipStatusCd.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtShipStatusCd.Location = New System.Drawing.Point(557, 9)
        Me.txtShipStatusCd.MaxLength = 0
        Me.txtShipStatusCd.Name = "txtShipStatusCd"
        Me.txtShipStatusCd.ReadOnly = True
        Me.txtShipStatusCd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtShipStatusCd.Size = New System.Drawing.Size(25, 20)
        Me.txtShipStatusCd.TabIndex = 21
        Me.txtShipStatusCd.TabStop = False
        '
        'bndCustomerShip
        '
        Me.bndCustomerShip.AllowNew = False
        Me.bndCustomerShip.DataMember = "CustomerSH"
        Me.bndCustomerShip.DataSource = Me.SaleForcDataSet
        '
        '_lblCustInfo_20
        '
        Me._lblCustInfo_20.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_20.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_20.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_20.Location = New System.Drawing.Point(112, 12)
        Me._lblCustInfo_20.Name = "_lblCustInfo_20"
        Me._lblCustInfo_20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_20.Size = New System.Drawing.Size(97, 17)
        Me._lblCustInfo_20.TabIndex = 24
        Me._lblCustInfo_20.Text = "Record status:"
        Me._lblCustInfo_20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_21
        '
        Me._lblCustInfo_21.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_21.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_21.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_21.Location = New System.Drawing.Point(445, 11)
        Me._lblCustInfo_21.Name = "_lblCustInfo_21"
        Me._lblCustInfo_21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_21.Size = New System.Drawing.Size(105, 17)
        Me._lblCustInfo_21.TabIndex = 23
        Me._lblCustInfo_21.Text = "Record status:"
        Me._lblCustInfo_21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'fraFileCust
        '
        Me.fraFileCust.BackColor = System.Drawing.SystemColors.Control
        Me.fraFileCust.Controls.Add(Me.btnMap)
        Me.fraFileCust.Controls.Add(Me.dblShipNoList)
        Me.fraFileCust.Controls.Add(Me.txtCustNo)
        Me.fraFileCust.Controls.Add(Me.txtSelectedShip)
        Me.fraFileCust.Controls.Add(Me.cmdCustShipUpdate)
        Me.fraFileCust.Controls.Add(Me.chkViewActiveCust)
        Me.fraFileCust.Controls.Add(Me.Frame4)
        Me.fraFileCust.Controls.Add(Me.cmdCustomerUpdate)
        Me.fraFileCust.Controls.Add(Me.Frame5)
        Me.fraFileCust.Controls.Add(Me.Frame3)
        Me.fraFileCust.Controls.Add(Me._lblCustInfo_10)
        Me.fraFileCust.Controls.Add(Me._lblCustInfo_3)
        Me.fraFileCust.Controls.Add(Me.lblDblCnt)
        Me.fraFileCust.Controls.Add(Me._lblCustInfo_2)
        Me.fraFileCust.Controls.Add(Me.lblDefaultShip)
        Me.fraFileCust.Controls.Add(Me._lblCustInfo_0)
        Me.fraFileCust.Controls.Add(Me._lblCustInfo_1)
        Me.fraFileCust.Controls.Add(Me._lblCustInfo_4)
        Me.fraFileCust.Controls.Add(Me._lblCustInfo_6)
        Me.fraFileCust.Controls.Add(Me._lblCustInfo_5)
        Me.fraFileCust.Controls.Add(Me._lblCustInfo_8)
        Me.fraFileCust.Controls.Add(Me._lblCustInfo_7)
        Me.fraFileCust.Controls.Add(Me._lblCustInfo_9)
        Me.fraFileCust.Controls.Add(Me.Frame2)
        Me.fraFileCust.Controls.Add(Me.WebBrowser2)
        Me.fraFileCust.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraFileCust.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraFileCust.Location = New System.Drawing.Point(2, 2)
        Me.fraFileCust.Name = "fraFileCust"
        Me.fraFileCust.Padding = New System.Windows.Forms.Padding(0)
        Me.fraFileCust.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraFileCust.Size = New System.Drawing.Size(785, 412)
        Me.fraFileCust.TabIndex = 68
        Me.fraFileCust.TabStop = False
        '
        'btnMap
        '
        Me.btnMap.Location = New System.Drawing.Point(27, 268)
        Me.btnMap.Name = "btnMap"
        Me.btnMap.Size = New System.Drawing.Size(54, 24)
        Me.btnMap.TabIndex = 253
        Me.btnMap.Text = "Map It!"
        Me.btnMap.UseVisualStyleBackColor = True
        '
        'dblShipNoList
        '
        Me.dblShipNoList.DataSource = Me.bndCustomerShip
        Me.dblShipNoList.DisplayMember = "Cust-sh"
        Me.dblShipNoList.FormattingEnabled = True
        Me.dblShipNoList.ItemHeight = 14
        Me.dblShipNoList.Location = New System.Drawing.Point(448, 12)
        Me.dblShipNoList.Name = "dblShipNoList"
        Me.dblShipNoList.Size = New System.Drawing.Size(124, 46)
        Me.dblShipNoList.TabIndex = 252
        '
        'txtCustNo
        '
        Me.txtCustNo.AcceptsReturn = True
        Me.txtCustNo.BackColor = System.Drawing.Color.White
        Me.txtCustNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCustNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomer, "Cust-no", True))
        Me.txtCustNo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustNo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCustNo.Location = New System.Drawing.Point(128, 16)
        Me.txtCustNo.MaxLength = 0
        Me.txtCustNo.Name = "txtCustNo"
        Me.txtCustNo.ReadOnly = True
        Me.txtCustNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCustNo.Size = New System.Drawing.Size(97, 20)
        Me.txtCustNo.TabIndex = 250
        '
        'txtSelectedShip
        '
        Me.txtSelectedShip.AcceptsReturn = True
        Me.txtSelectedShip.BackColor = System.Drawing.SystemColors.Control
        Me.txtSelectedShip.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSelectedShip.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomerShip, "Cust-sh", True))
        Me.txtSelectedShip.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSelectedShip.ForeColor = System.Drawing.Color.Yellow
        Me.txtSelectedShip.Location = New System.Drawing.Point(640, 14)
        Me.txtSelectedShip.MaxLength = 0
        Me.txtSelectedShip.Name = "txtSelectedShip"
        Me.txtSelectedShip.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSelectedShip.Size = New System.Drawing.Size(81, 20)
        Me.txtSelectedShip.TabIndex = 249
        Me.txtSelectedShip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdCustShipUpdate
        '
        Me.cmdCustShipUpdate.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCustShipUpdate.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCustShipUpdate.Enabled = False
        Me.cmdCustShipUpdate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCustShipUpdate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCustShipUpdate.Location = New System.Drawing.Point(664, 54)
        Me.cmdCustShipUpdate.Name = "cmdCustShipUpdate"
        Me.cmdCustShipUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCustShipUpdate.Size = New System.Drawing.Size(57, 23)
        Me.cmdCustShipUpdate.TabIndex = 187
        Me.cmdCustShipUpdate.Text = "Update "
        Me.cmdCustShipUpdate.UseVisualStyleBackColor = False
        '
        'chkViewActiveCust
        '
        Me.chkViewActiveCust.BackColor = System.Drawing.SystemColors.Control
        Me.chkViewActiveCust.Checked = True
        Me.chkViewActiveCust.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkViewActiveCust.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkViewActiveCust.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkViewActiveCust.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkViewActiveCust.Location = New System.Drawing.Point(16, 44)
        Me.chkViewActiveCust.Name = "chkViewActiveCust"
        Me.chkViewActiveCust.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkViewActiveCust.Size = New System.Drawing.Size(185, 21)
        Me.chkViewActiveCust.TabIndex = 183
        Me.chkViewActiveCust.Text = "View Active Customers Only"
        Me.chkViewActiveCust.UseVisualStyleBackColor = False
        '
        'Frame4
        '
        Me.Frame4.BackColor = System.Drawing.SystemColors.Control
        Me.Frame4.Controls.Add(Me.lblCustContactEmail)
        Me.Frame4.Controls.Add(Me._lblCustInfo_19)
        Me.Frame4.Controls.Add(Me._lblCustInfo_17)
        Me.Frame4.Controls.Add(Me.Label48)
        Me.Frame4.Controls.Add(Me._lblCustInfo_18)
        Me.Frame4.Controls.Add(Me.lblPhoneNo)
        Me.Frame4.Controls.Add(Me.lblContact)
        Me.Frame4.Controls.Add(Me.lblFaxNo)
        Me.Frame4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame4.ForeColor = System.Drawing.Color.Blue
        Me.Frame4.Location = New System.Drawing.Point(96, 296)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame4.Size = New System.Drawing.Size(281, 113)
        Me.Frame4.TabIndex = 175
        Me.Frame4.TabStop = False
        Me.Frame4.Text = " Contact information: Customer "
        '
        'lblCustContactEmail
        '
        Me.lblCustContactEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCustContactEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomer, "Contact-email", True))
        Me.lblCustContactEmail.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustContactEmail.Location = New System.Drawing.Point(88, 85)
        Me.lblCustContactEmail.Name = "lblCustContactEmail"
        Me.lblCustContactEmail.Size = New System.Drawing.Size(175, 20)
        Me.lblCustContactEmail.TabIndex = 191
        '
        '_lblCustInfo_19
        '
        Me._lblCustInfo_19.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_19.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_19.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_19.Location = New System.Drawing.Point(17, 85)
        Me._lblCustInfo_19.Name = "_lblCustInfo_19"
        Me._lblCustInfo_19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_19.Size = New System.Drawing.Size(65, 20)
        Me._lblCustInfo_19.TabIndex = 190
        Me._lblCustInfo_19.Text = "Email:"
        Me._lblCustInfo_19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_17
        '
        Me._lblCustInfo_17.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_17.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_17.Location = New System.Drawing.Point(8, 24)
        Me._lblCustInfo_17.Name = "_lblCustInfo_17"
        Me._lblCustInfo_17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_17.Size = New System.Drawing.Size(73, 17)
        Me._lblCustInfo_17.TabIndex = 181
        Me._lblCustInfo_17.Text = "Telephone:"
        Me._lblCustInfo_17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.SystemColors.Control
        Me.Label48.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label48.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label48.Location = New System.Drawing.Point(32, 42)
        Me.Label48.Name = "Label48"
        Me.Label48.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label48.Size = New System.Drawing.Size(49, 17)
        Me.Label48.TabIndex = 180
        Me.Label48.Text = "Fax:"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_18
        '
        Me._lblCustInfo_18.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_18.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_18.Location = New System.Drawing.Point(16, 66)
        Me._lblCustInfo_18.Name = "_lblCustInfo_18"
        Me._lblCustInfo_18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_18.Size = New System.Drawing.Size(65, 17)
        Me._lblCustInfo_18.TabIndex = 179
        Me._lblCustInfo_18.Text = "Contact:"
        Me._lblCustInfo_18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPhoneNo
        '
        Me.lblPhoneNo.BackColor = System.Drawing.SystemColors.Control
        Me.lblPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPhoneNo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPhoneNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomer, "Telephone", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.lblPhoneNo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneNo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPhoneNo.Location = New System.Drawing.Point(88, 21)
        Me.lblPhoneNo.Name = "lblPhoneNo"
        Me.lblPhoneNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPhoneNo.Size = New System.Drawing.Size(175, 20)
        Me.lblPhoneNo.TabIndex = 178
        '
        'lblContact
        '
        Me.lblContact.BackColor = System.Drawing.SystemColors.Control
        Me.lblContact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblContact.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblContact.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomer, "Contact", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.lblContact.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblContact.Location = New System.Drawing.Point(88, 62)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblContact.Size = New System.Drawing.Size(175, 20)
        Me.lblContact.TabIndex = 177
        '
        'lblFaxNo
        '
        Me.lblFaxNo.BackColor = System.Drawing.SystemColors.Control
        Me.lblFaxNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFaxNo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFaxNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomer, "Fax-num", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.lblFaxNo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFaxNo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFaxNo.Location = New System.Drawing.Point(88, 42)
        Me.lblFaxNo.Name = "lblFaxNo"
        Me.lblFaxNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFaxNo.Size = New System.Drawing.Size(175, 20)
        Me.lblFaxNo.TabIndex = 176
        '
        'cmdCustomerUpdate
        '
        Me.cmdCustomerUpdate.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCustomerUpdate.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCustomerUpdate.Enabled = False
        Me.cmdCustomerUpdate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCustomerUpdate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCustomerUpdate.Location = New System.Drawing.Point(320, 54)
        Me.cmdCustomerUpdate.Name = "cmdCustomerUpdate"
        Me.cmdCustomerUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCustomerUpdate.Size = New System.Drawing.Size(57, 23)
        Me.cmdCustomerUpdate.TabIndex = 174
        Me.cmdCustomerUpdate.Text = "Update "
        Me.cmdCustomerUpdate.UseVisualStyleBackColor = False
        '
        'Frame5
        '
        Me.Frame5.BackColor = System.Drawing.SystemColors.Control
        Me.Frame5.Controls.Add(Me.lblCustEmail)
        Me.Frame5.Controls.Add(Me.lblCustShipVia)
        Me.Frame5.Controls.Add(Me.lblCountry)
        Me.Frame5.Controls.Add(Me.lblZipCode)
        Me.Frame5.Controls.Add(Me.lblState)
        Me.Frame5.Controls.Add(Me.lblCity)
        Me.Frame5.Controls.Add(Me.lblAddr1)
        Me.Frame5.Controls.Add(Me.lblAddr2)
        Me.Frame5.Controls.Add(Me.lblAddr3)
        Me.Frame5.Controls.Add(Me.lblCustShipViaDesc)
        Me.Frame5.Controls.Add(Me._lblCustInfo_11)
        Me.Frame5.Controls.Add(Me.lblName)
        Me.Frame5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame5.ForeColor = System.Drawing.Color.Blue
        Me.Frame5.Location = New System.Drawing.Point(96, 64)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame5.Size = New System.Drawing.Size(281, 233)
        Me.Frame5.TabIndex = 76
        Me.Frame5.TabStop = False
        Me.Frame5.Text = " MAIN CUSTOMER ADDRESS "
        '
        'lblCustEmail
        '
        Me.lblCustEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCustEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomer, "Email", True))
        Me.lblCustEmail.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustEmail.Location = New System.Drawing.Point(9, 174)
        Me.lblCustEmail.Name = "lblCustEmail"
        Me.lblCustEmail.Size = New System.Drawing.Size(263, 26)
        Me.lblCustEmail.TabIndex = 94
        '
        'lblCustShipVia
        '
        Me.lblCustShipVia.BackColor = System.Drawing.SystemColors.Control
        Me.lblCustShipVia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCustShipVia.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCustShipVia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomer, "Via-code", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.lblCustShipVia.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustShipVia.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCustShipVia.Location = New System.Drawing.Point(64, 208)
        Me.lblCustShipVia.Name = "lblCustShipVia"
        Me.lblCustShipVia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCustShipVia.Size = New System.Drawing.Size(41, 17)
        Me.lblCustShipVia.TabIndex = 93
        '
        'lblCountry
        '
        Me.lblCountry.BackColor = System.Drawing.SystemColors.Control
        Me.lblCountry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCountry.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCountry.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomer, "Country", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.lblCountry.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountry.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCountry.Location = New System.Drawing.Point(8, 144)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCountry.Size = New System.Drawing.Size(73, 25)
        Me.lblCountry.TabIndex = 92
        '
        'lblZipCode
        '
        Me.lblZipCode.BackColor = System.Drawing.SystemColors.Control
        Me.lblZipCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblZipCode.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblZipCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomer, "Zip-code", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.lblZipCode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZipCode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblZipCode.Location = New System.Drawing.Point(184, 112)
        Me.lblZipCode.Name = "lblZipCode"
        Me.lblZipCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblZipCode.Size = New System.Drawing.Size(89, 25)
        Me.lblZipCode.TabIndex = 91
        '
        'lblState
        '
        Me.lblState.BackColor = System.Drawing.SystemColors.Control
        Me.lblState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblState.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblState.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomer, "St", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.lblState.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblState.Location = New System.Drawing.Point(144, 112)
        Me.lblState.Name = "lblState"
        Me.lblState.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblState.Size = New System.Drawing.Size(33, 25)
        Me.lblState.TabIndex = 90
        '
        'lblCity
        '
        Me.lblCity.BackColor = System.Drawing.SystemColors.Control
        Me.lblCity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCity.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomer, "City", True))
        Me.lblCity.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCity.Location = New System.Drawing.Point(8, 112)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCity.Size = New System.Drawing.Size(129, 25)
        Me.lblCity.TabIndex = 89
        '
        'lblAddr1
        '
        Me.lblAddr1.BackColor = System.Drawing.SystemColors.Control
        Me.lblAddr1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAddr1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAddr1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomer, "Address1", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.lblAddr1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddr1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAddr1.Location = New System.Drawing.Point(8, 40)
        Me.lblAddr1.Name = "lblAddr1"
        Me.lblAddr1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAddr1.Size = New System.Drawing.Size(265, 25)
        Me.lblAddr1.TabIndex = 88
        '
        'lblAddr2
        '
        Me.lblAddr2.BackColor = System.Drawing.SystemColors.Control
        Me.lblAddr2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAddr2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAddr2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomer, "Address2", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.lblAddr2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddr2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAddr2.Location = New System.Drawing.Point(8, 64)
        Me.lblAddr2.Name = "lblAddr2"
        Me.lblAddr2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAddr2.Size = New System.Drawing.Size(265, 25)
        Me.lblAddr2.TabIndex = 87
        '
        'lblAddr3
        '
        Me.lblAddr3.BackColor = System.Drawing.SystemColors.Control
        Me.lblAddr3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAddr3.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAddr3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomer, "Address3", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.lblAddr3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddr3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAddr3.Location = New System.Drawing.Point(8, 88)
        Me.lblAddr3.Name = "lblAddr3"
        Me.lblAddr3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAddr3.Size = New System.Drawing.Size(265, 25)
        Me.lblAddr3.TabIndex = 86
        '
        'lblCustShipViaDesc
        '
        Me.lblCustShipViaDesc.BackColor = System.Drawing.SystemColors.Control
        Me.lblCustShipViaDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCustShipViaDesc.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCustShipViaDesc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustShipViaDesc.ForeColor = System.Drawing.Color.Blue
        Me.lblCustShipViaDesc.Location = New System.Drawing.Point(112, 208)
        Me.lblCustShipViaDesc.Name = "lblCustShipViaDesc"
        Me.lblCustShipViaDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCustShipViaDesc.Size = New System.Drawing.Size(161, 17)
        Me.lblCustShipViaDesc.TabIndex = 78
        '
        '_lblCustInfo_11
        '
        Me._lblCustInfo_11.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_11.Location = New System.Drawing.Point(3, 212)
        Me._lblCustInfo_11.Name = "_lblCustInfo_11"
        Me._lblCustInfo_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_11.Size = New System.Drawing.Size(54, 17)
        Me._lblCustInfo_11.TabIndex = 77
        Me._lblCustInfo_11.Text = "Ship Via"
        Me._lblCustInfo_11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.SystemColors.Control
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblName.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomer, "Name", True))
        Me.lblName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblName.Location = New System.Drawing.Point(8, 16)
        Me.lblName.Name = "lblName"
        Me.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblName.Size = New System.Drawing.Size(265, 25)
        Me.lblName.TabIndex = 85
        Me.lblName.UseMnemonic = False
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.lblNoShipToInfo)
        Me.Frame3.Controls.Add(Me.lblCustSHWebsite)
        Me.Frame3.Controls.Add(Me.lblCustSHEmail)
        Me.Frame3.Controls.Add(Me.lblShipName)
        Me.Frame3.Controls.Add(Me.lblShipViaCd)
        Me.Frame3.Controls.Add(Me.lblShipCountry)
        Me.Frame3.Controls.Add(Me.lblShipZipcode)
        Me.Frame3.Controls.Add(Me.lblShipSt)
        Me.Frame3.Controls.Add(Me.lblShipCity)
        Me.Frame3.Controls.Add(Me.lblShipAddr1)
        Me.Frame3.Controls.Add(Me.lblShipAddr2)
        Me.Frame3.Controls.Add(Me.lblShipAddr3)
        Me.Frame3.Controls.Add(Me.lblShipViaDesc)
        Me.Frame3.Controls.Add(Me._lblCustInfo_12)
        Me.Frame3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.Color.Blue
        Me.Frame3.Location = New System.Drawing.Point(440, 64)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(281, 233)
        Me.Frame3.TabIndex = 73
        Me.Frame3.TabStop = False
        Me.Frame3.Text = " SHIPPING ADDRESS "
        '
        'lblNoShipToInfo
        '
        Me.lblNoShipToInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNoShipToInfo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoShipToInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNoShipToInfo.Location = New System.Drawing.Point(8, 16)
        Me.lblNoShipToInfo.Name = "lblNoShipToInfo"
        Me.lblNoShipToInfo.Size = New System.Drawing.Size(270, 48)
        Me.lblNoShipToInfo.TabIndex = 191
        Me.lblNoShipToInfo.Text = "lblNoShipToInfo"
        Me.lblNoShipToInfo.Visible = False
        '
        'lblCustSHWebsite
        '
        Me.lblCustSHWebsite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCustSHWebsite.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomerShip, "Website", True))
        Me.lblCustSHWebsite.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustSHWebsite.Location = New System.Drawing.Point(105, 144)
        Me.lblCustSHWebsite.Name = "lblCustSHWebsite"
        Me.lblCustSHWebsite.Size = New System.Drawing.Size(167, 24)
        Me.lblCustSHWebsite.TabIndex = 190
        '
        'lblCustSHEmail
        '
        Me.lblCustSHEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCustSHEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomerShip, "email", True))
        Me.lblCustSHEmail.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustSHEmail.Location = New System.Drawing.Point(7, 173)
        Me.lblCustSHEmail.Name = "lblCustSHEmail"
        Me.lblCustSHEmail.Size = New System.Drawing.Size(271, 28)
        Me.lblCustSHEmail.TabIndex = 189
        '
        'lblShipName
        '
        Me.lblShipName.BackColor = System.Drawing.SystemColors.Control
        Me.lblShipName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShipName.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShipName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomerShip, "Name", True))
        Me.lblShipName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShipName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblShipName.Location = New System.Drawing.Point(8, 16)
        Me.lblShipName.Name = "lblShipName"
        Me.lblShipName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblShipName.Size = New System.Drawing.Size(265, 25)
        Me.lblShipName.TabIndex = 97
        Me.lblShipName.UseMnemonic = False
        '
        'lblShipViaCd
        '
        Me.lblShipViaCd.BackColor = System.Drawing.SystemColors.Control
        Me.lblShipViaCd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShipViaCd.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShipViaCd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomerShip, "Via-code", True))
        Me.lblShipViaCd.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShipViaCd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblShipViaCd.Location = New System.Drawing.Point(70, 208)
        Me.lblShipViaCd.Name = "lblShipViaCd"
        Me.lblShipViaCd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblShipViaCd.Size = New System.Drawing.Size(41, 17)
        Me.lblShipViaCd.TabIndex = 105
        '
        'lblShipCountry
        '
        Me.lblShipCountry.BackColor = System.Drawing.SystemColors.Control
        Me.lblShipCountry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShipCountry.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShipCountry.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShipCountry.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblShipCountry.Location = New System.Drawing.Point(8, 144)
        Me.lblShipCountry.Name = "lblShipCountry"
        Me.lblShipCountry.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblShipCountry.Size = New System.Drawing.Size(89, 25)
        Me.lblShipCountry.TabIndex = 104
        '
        'lblShipZipcode
        '
        Me.lblShipZipcode.BackColor = System.Drawing.SystemColors.Control
        Me.lblShipZipcode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShipZipcode.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShipZipcode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomerShip, "Zip-code", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.lblShipZipcode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShipZipcode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblShipZipcode.Location = New System.Drawing.Point(184, 112)
        Me.lblShipZipcode.Name = "lblShipZipcode"
        Me.lblShipZipcode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblShipZipcode.Size = New System.Drawing.Size(89, 25)
        Me.lblShipZipcode.TabIndex = 103
        '
        'lblShipSt
        '
        Me.lblShipSt.BackColor = System.Drawing.SystemColors.Control
        Me.lblShipSt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShipSt.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShipSt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomerShip, "St", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.lblShipSt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShipSt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblShipSt.Location = New System.Drawing.Point(144, 112)
        Me.lblShipSt.Name = "lblShipSt"
        Me.lblShipSt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblShipSt.Size = New System.Drawing.Size(33, 25)
        Me.lblShipSt.TabIndex = 102
        '
        'lblShipCity
        '
        Me.lblShipCity.BackColor = System.Drawing.SystemColors.Control
        Me.lblShipCity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShipCity.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShipCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomerShip, "City", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.lblShipCity.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShipCity.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblShipCity.Location = New System.Drawing.Point(8, 112)
        Me.lblShipCity.Name = "lblShipCity"
        Me.lblShipCity.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblShipCity.Size = New System.Drawing.Size(129, 25)
        Me.lblShipCity.TabIndex = 101
        '
        'lblShipAddr1
        '
        Me.lblShipAddr1.BackColor = System.Drawing.SystemColors.Control
        Me.lblShipAddr1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShipAddr1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShipAddr1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomerShip, "Address1", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.lblShipAddr1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShipAddr1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblShipAddr1.Location = New System.Drawing.Point(8, 40)
        Me.lblShipAddr1.Name = "lblShipAddr1"
        Me.lblShipAddr1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblShipAddr1.Size = New System.Drawing.Size(265, 25)
        Me.lblShipAddr1.TabIndex = 100
        '
        'lblShipAddr2
        '
        Me.lblShipAddr2.BackColor = System.Drawing.SystemColors.Control
        Me.lblShipAddr2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShipAddr2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShipAddr2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomerShip, "Address2", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.lblShipAddr2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShipAddr2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblShipAddr2.Location = New System.Drawing.Point(8, 64)
        Me.lblShipAddr2.Name = "lblShipAddr2"
        Me.lblShipAddr2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblShipAddr2.Size = New System.Drawing.Size(265, 25)
        Me.lblShipAddr2.TabIndex = 99
        '
        'lblShipAddr3
        '
        Me.lblShipAddr3.BackColor = System.Drawing.SystemColors.Control
        Me.lblShipAddr3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShipAddr3.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShipAddr3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomerShip, "Address3", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.lblShipAddr3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShipAddr3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblShipAddr3.Location = New System.Drawing.Point(8, 88)
        Me.lblShipAddr3.Name = "lblShipAddr3"
        Me.lblShipAddr3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblShipAddr3.Size = New System.Drawing.Size(265, 25)
        Me.lblShipAddr3.TabIndex = 98
        '
        'lblShipViaDesc
        '
        Me.lblShipViaDesc.BackColor = System.Drawing.SystemColors.Control
        Me.lblShipViaDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShipViaDesc.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShipViaDesc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShipViaDesc.ForeColor = System.Drawing.Color.Blue
        Me.lblShipViaDesc.Location = New System.Drawing.Point(117, 208)
        Me.lblShipViaDesc.Name = "lblShipViaDesc"
        Me.lblShipViaDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblShipViaDesc.Size = New System.Drawing.Size(161, 17)
        Me.lblShipViaDesc.TabIndex = 75
        '
        '_lblCustInfo_12
        '
        Me._lblCustInfo_12.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_12.Location = New System.Drawing.Point(8, 208)
        Me._lblCustInfo_12.Name = "_lblCustInfo_12"
        Me._lblCustInfo_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_12.Size = New System.Drawing.Size(56, 17)
        Me._lblCustInfo_12.TabIndex = 74
        Me._lblCustInfo_12.Text = "Ship Via"
        Me._lblCustInfo_12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_lblCustInfo_10
        '
        Me._lblCustInfo_10.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._lblCustInfo_10.Location = New System.Drawing.Point(16, 240)
        Me._lblCustInfo_10.Name = "_lblCustInfo_10"
        Me._lblCustInfo_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_10.Size = New System.Drawing.Size(73, 17)
        Me._lblCustInfo_10.TabIndex = 185
        Me._lblCustInfo_10.Text = "Email Addr:"
        Me._lblCustInfo_10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_3
        '
        Me._lblCustInfo_3.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_3.ForeColor = System.Drawing.Color.Blue
        Me._lblCustInfo_3.Location = New System.Drawing.Point(560, 32)
        Me._lblCustInfo_3.Name = "_lblCustInfo_3"
        Me._lblCustInfo_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_3.Size = New System.Drawing.Size(73, 17)
        Me._lblCustInfo_3.TabIndex = 182
        Me._lblCustInfo_3.Text = "Default:"
        Me._lblCustInfo_3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDblCnt
        '
        Me.lblDblCnt.BackColor = System.Drawing.SystemColors.Control
        Me.lblDblCnt.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDblCnt.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDblCnt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDblCnt.Location = New System.Drawing.Point(416, 32)
        Me.lblDblCnt.Name = "lblDblCnt"
        Me.lblDblCnt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDblCnt.Size = New System.Drawing.Size(25, 17)
        Me.lblDblCnt.TabIndex = 172
        '
        '_lblCustInfo_2
        '
        Me._lblCustInfo_2.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_2.Location = New System.Drawing.Point(560, 16)
        Me._lblCustInfo_2.Name = "_lblCustInfo_2"
        Me._lblCustInfo_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_2.Size = New System.Drawing.Size(73, 17)
        Me._lblCustInfo_2.TabIndex = 171
        Me._lblCustInfo_2.Text = "Selected:"
        Me._lblCustInfo_2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDefaultShip
        '
        Me.lblDefaultShip.BackColor = System.Drawing.SystemColors.Control
        Me.lblDefaultShip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDefaultShip.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDefaultShip.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomer, "Cust-sh", True))
        Me.lblDefaultShip.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDefaultShip.ForeColor = System.Drawing.Color.Red
        Me.lblDefaultShip.Location = New System.Drawing.Point(640, 32)
        Me.lblDefaultShip.Name = "lblDefaultShip"
        Me.lblDefaultShip.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDefaultShip.Size = New System.Drawing.Size(81, 17)
        Me.lblDefaultShip.TabIndex = 170
        Me.lblDefaultShip.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_lblCustInfo_0
        '
        Me._lblCustInfo_0.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_0.Location = New System.Drawing.Point(3, 16)
        Me._lblCustInfo_0.Name = "_lblCustInfo_0"
        Me._lblCustInfo_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_0.Size = New System.Drawing.Size(118, 17)
        Me._lblCustInfo_0.TabIndex = 107
        Me._lblCustInfo_0.Text = "Customer number:"
        Me._lblCustInfo_0.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_1
        '
        Me._lblCustInfo_1.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_1.Location = New System.Drawing.Point(344, 16)
        Me._lblCustInfo_1.Name = "_lblCustInfo_1"
        Me._lblCustInfo_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_1.Size = New System.Drawing.Size(105, 17)
        Me._lblCustInfo_1.TabIndex = 106
        Me._lblCustInfo_1.Text = "Shipping number:"
        Me._lblCustInfo_1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_4
        '
        Me._lblCustInfo_4.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._lblCustInfo_4.Location = New System.Drawing.Point(8, 88)
        Me._lblCustInfo_4.Name = "_lblCustInfo_4"
        Me._lblCustInfo_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_4.Size = New System.Drawing.Size(73, 17)
        Me._lblCustInfo_4.TabIndex = 84
        Me._lblCustInfo_4.Text = "Name:"
        Me._lblCustInfo_4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_6
        '
        Me._lblCustInfo_6.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._lblCustInfo_6.Location = New System.Drawing.Point(16, 136)
        Me._lblCustInfo_6.Name = "_lblCustInfo_6"
        Me._lblCustInfo_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_6.Size = New System.Drawing.Size(73, 17)
        Me._lblCustInfo_6.TabIndex = 83
        Me._lblCustInfo_6.Text = "Address - 2:"
        Me._lblCustInfo_6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_5
        '
        Me._lblCustInfo_5.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._lblCustInfo_5.Location = New System.Drawing.Point(16, 112)
        Me._lblCustInfo_5.Name = "_lblCustInfo_5"
        Me._lblCustInfo_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_5.Size = New System.Drawing.Size(73, 17)
        Me._lblCustInfo_5.TabIndex = 82
        Me._lblCustInfo_5.Text = "Address - 1:"
        Me._lblCustInfo_5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_8
        '
        Me._lblCustInfo_8.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._lblCustInfo_8.Location = New System.Drawing.Point(16, 184)
        Me._lblCustInfo_8.Name = "_lblCustInfo_8"
        Me._lblCustInfo_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_8.Size = New System.Drawing.Size(73, 17)
        Me._lblCustInfo_8.TabIndex = 81
        Me._lblCustInfo_8.Text = "City, St, Zip:"
        Me._lblCustInfo_8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_7
        '
        Me._lblCustInfo_7.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._lblCustInfo_7.Location = New System.Drawing.Point(16, 160)
        Me._lblCustInfo_7.Name = "_lblCustInfo_7"
        Me._lblCustInfo_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_7.Size = New System.Drawing.Size(73, 17)
        Me._lblCustInfo_7.TabIndex = 80
        Me._lblCustInfo_7.Text = "Address - 3:"
        Me._lblCustInfo_7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_9
        '
        Me._lblCustInfo_9.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._lblCustInfo_9.Location = New System.Drawing.Point(32, 216)
        Me._lblCustInfo_9.Name = "_lblCustInfo_9"
        Me._lblCustInfo_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_9.Size = New System.Drawing.Size(57, 17)
        Me._lblCustInfo_9.TabIndex = 79
        Me._lblCustInfo_9.Text = "Country:"
        Me._lblCustInfo_9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.lblCustSHContactEmail)
        Me.Frame2.Controls.Add(Me._lblCustInfo_16)
        Me.Frame2.Controls.Add(Me.lblShipFax)
        Me.Frame2.Controls.Add(Me.lblShipContact)
        Me.Frame2.Controls.Add(Me.lblShipPhone)
        Me.Frame2.Controls.Add(Me._lblCustInfo_15)
        Me.Frame2.Controls.Add(Me._lblCustInfo_14)
        Me.Frame2.Controls.Add(Me._lblCustInfo_13)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.Color.Blue
        Me.Frame2.Location = New System.Drawing.Point(440, 296)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(281, 113)
        Me.Frame2.TabIndex = 69
        Me.Frame2.TabStop = False
        Me.Frame2.Text = " Contact information: Shipping address "
        '
        'lblCustSHContactEmail
        '
        Me.lblCustSHContactEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCustSHContactEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomerShip, "Contact-email", True))
        Me.lblCustSHContactEmail.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustSHContactEmail.Location = New System.Drawing.Point(88, 85)
        Me.lblCustSHContactEmail.Name = "lblCustSHContactEmail"
        Me.lblCustSHContactEmail.Size = New System.Drawing.Size(175, 20)
        Me.lblCustSHContactEmail.TabIndex = 193
        '
        '_lblCustInfo_16
        '
        Me._lblCustInfo_16.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_16.Location = New System.Drawing.Point(16, 80)
        Me._lblCustInfo_16.Name = "_lblCustInfo_16"
        Me._lblCustInfo_16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_16.Size = New System.Drawing.Size(65, 17)
        Me._lblCustInfo_16.TabIndex = 192
        Me._lblCustInfo_16.Text = "Email:"
        Me._lblCustInfo_16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblShipFax
        '
        Me.lblShipFax.BackColor = System.Drawing.SystemColors.Control
        Me.lblShipFax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShipFax.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShipFax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomerShip, "Fax-num", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.lblShipFax.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShipFax.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblShipFax.Location = New System.Drawing.Point(88, 42)
        Me.lblShipFax.Name = "lblShipFax"
        Me.lblShipFax.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblShipFax.Size = New System.Drawing.Size(175, 20)
        Me.lblShipFax.TabIndex = 96
        '
        'lblShipContact
        '
        Me.lblShipContact.BackColor = System.Drawing.SystemColors.Control
        Me.lblShipContact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShipContact.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShipContact.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomerShip, "Contact", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.lblShipContact.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShipContact.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblShipContact.Location = New System.Drawing.Point(88, 62)
        Me.lblShipContact.Name = "lblShipContact"
        Me.lblShipContact.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblShipContact.Size = New System.Drawing.Size(175, 20)
        Me.lblShipContact.TabIndex = 95
        '
        'lblShipPhone
        '
        Me.lblShipPhone.BackColor = System.Drawing.SystemColors.Control
        Me.lblShipPhone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShipPhone.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShipPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomerShip, "Telephone", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.lblShipPhone.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShipPhone.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblShipPhone.Location = New System.Drawing.Point(88, 21)
        Me.lblShipPhone.Name = "lblShipPhone"
        Me.lblShipPhone.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblShipPhone.Size = New System.Drawing.Size(175, 20)
        Me.lblShipPhone.TabIndex = 94
        '
        '_lblCustInfo_15
        '
        Me._lblCustInfo_15.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_15.Location = New System.Drawing.Point(24, 62)
        Me._lblCustInfo_15.Name = "_lblCustInfo_15"
        Me._lblCustInfo_15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_15.Size = New System.Drawing.Size(57, 17)
        Me._lblCustInfo_15.TabIndex = 72
        Me._lblCustInfo_15.Text = "Contact:"
        Me._lblCustInfo_15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_14
        '
        Me._lblCustInfo_14.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_14.Location = New System.Drawing.Point(31, 45)
        Me._lblCustInfo_14.Name = "_lblCustInfo_14"
        Me._lblCustInfo_14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_14.Size = New System.Drawing.Size(49, 17)
        Me._lblCustInfo_14.TabIndex = 71
        Me._lblCustInfo_14.Text = "Fax:"
        Me._lblCustInfo_14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_13
        '
        Me._lblCustInfo_13.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_13.Location = New System.Drawing.Point(8, 24)
        Me._lblCustInfo_13.Name = "_lblCustInfo_13"
        Me._lblCustInfo_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_13.Size = New System.Drawing.Size(73, 17)
        Me._lblCustInfo_13.TabIndex = 70
        Me._lblCustInfo_13.Text = "Telephone:"
        Me._lblCustInfo_13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'WebBrowser2
        '
        Me.WebBrowser2.Location = New System.Drawing.Point(6, 8)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.ScriptErrorsSuppressed = True
        Me.WebBrowser2.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.TabIndex = 254
        Me.WebBrowser2.Visible = False
        '
        'fraNewCust
        '
        Me.fraNewCust.BackColor = System.Drawing.SystemColors.Control
        Me.fraNewCust.Controls.Add(Me.chkCopyCust2CustSh)
        Me.fraNewCust.Controls.Add(Me.cmdNewCustFinished)
        Me.fraNewCust.Controls.Add(Me.fraCustContactInfo)
        Me.fraNewCust.Controls.Add(Me.fraShipContact)
        Me.fraNewCust.Controls.Add(Me.fraCustAddr)
        Me.fraNewCust.Controls.Add(Me.fraShipAddr)
        Me.fraNewCust.Controls.Add(Me._lblCustInfo_51)
        Me.fraNewCust.Controls.Add(Me._lblCustInfo_50)
        Me.fraNewCust.Controls.Add(Me.Label61)
        Me.fraNewCust.Controls.Add(Me.lblTempShipNo)
        Me.fraNewCust.Controls.Add(Me.Label59)
        Me.fraNewCust.Controls.Add(Me.lblTempCustNo)
        Me.fraNewCust.Controls.Add(Me._lblCustInfo_45)
        Me.fraNewCust.Controls.Add(Me._lblCustInfo_47)
        Me.fraNewCust.Controls.Add(Me._lblCustInfo_46)
        Me.fraNewCust.Controls.Add(Me._lblCustInfo_49)
        Me.fraNewCust.Controls.Add(Me._lblCustInfo_48)
        Me.fraNewCust.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraNewCust.ForeColor = System.Drawing.Color.Blue
        Me.fraNewCust.Location = New System.Drawing.Point(2, 3)
        Me.fraNewCust.Name = "fraNewCust"
        Me.fraNewCust.Padding = New System.Windows.Forms.Padding(0)
        Me.fraNewCust.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraNewCust.Size = New System.Drawing.Size(813, 450)
        Me.fraNewCust.TabIndex = 69
        Me.fraNewCust.TabStop = False
        Me.fraNewCust.Text = " NEW CUSTOMER "
        '
        'chkCopyCust2CustSh
        '
        Me.chkCopyCust2CustSh.AutoSize = True
        Me.chkCopyCust2CustSh.Checked = True
        Me.chkCopyCust2CustSh.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCopyCust2CustSh.Location = New System.Drawing.Point(441, 13)
        Me.chkCopyCust2CustSh.Name = "chkCopyCust2CustSh"
        Me.chkCopyCust2CustSh.Size = New System.Drawing.Size(312, 18)
        Me.chkCopyCust2CustSh.TabIndex = 197
        Me.chkCopyCust2CustSh.Text = "Copy Customer Information to Shipping Information"
        Me.chkCopyCust2CustSh.UseVisualStyleBackColor = True
        '
        'cmdNewCustFinished
        '
        Me.cmdNewCustFinished.BackColor = System.Drawing.SystemColors.Control
        Me.cmdNewCustFinished.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdNewCustFinished.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNewCustFinished.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdNewCustFinished.Location = New System.Drawing.Point(16, 16)
        Me.cmdNewCustFinished.Name = "cmdNewCustFinished"
        Me.cmdNewCustFinished.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdNewCustFinished.Size = New System.Drawing.Size(73, 25)
        Me.cmdNewCustFinished.TabIndex = 64
        Me.cmdNewCustFinished.TabStop = False
        Me.cmdNewCustFinished.Text = "&Finished"
        Me.cmdNewCustFinished.UseVisualStyleBackColor = False
        '
        'fraCustContactInfo
        '
        Me.fraCustContactInfo.BackColor = System.Drawing.SystemColors.Control
        Me.fraCustContactInfo.Controls.Add(Me.mebPhoneNo)
        Me.fraCustContactInfo.Controls.Add(Me.mebFaxNo)
        Me.fraCustContactInfo.Controls.Add(Me.mebContact)
        Me.fraCustContactInfo.Controls.Add(Me.mebCustContactEmail)
        Me.fraCustContactInfo.Controls.Add(Me._lblCustInfo_55)
        Me.fraCustContactInfo.Controls.Add(Me._lblCustInfo_52)
        Me.fraCustContactInfo.Controls.Add(Me._lblCustInfo_53)
        Me.fraCustContactInfo.Controls.Add(Me._lblCustInfo_54)
        Me.fraCustContactInfo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraCustContactInfo.ForeColor = System.Drawing.Color.Blue
        Me.fraCustContactInfo.Location = New System.Drawing.Point(128, 306)
        Me.fraCustContactInfo.Name = "fraCustContactInfo"
        Me.fraCustContactInfo.Padding = New System.Windows.Forms.Padding(0)
        Me.fraCustContactInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraCustContactInfo.Size = New System.Drawing.Size(273, 97)
        Me.fraCustContactInfo.TabIndex = 1
        Me.fraCustContactInfo.TabStop = False
        Me.fraCustContactInfo.Text = " Contact information: Customer "
        '
        'mebPhoneNo
        '
        Me.mebPhoneNo.AllowPromptAsInput = False
        Me.mebPhoneNo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mebPhoneNo.Location = New System.Drawing.Point(88, 16)
        Me.mebPhoneNo.Mask = "999-999-9999"
        Me.mebPhoneNo.Name = "mebPhoneNo"
        Me.mebPhoneNo.Size = New System.Drawing.Size(177, 20)
        Me.mebPhoneNo.TabIndex = 9
        '
        'mebFaxNo
        '
        Me.mebFaxNo.AllowPromptAsInput = False
        Me.mebFaxNo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mebFaxNo.Location = New System.Drawing.Point(88, 34)
        Me.mebFaxNo.Mask = "999-999-9999"
        Me.mebFaxNo.Name = "mebFaxNo"
        Me.mebFaxNo.Size = New System.Drawing.Size(177, 20)
        Me.mebFaxNo.TabIndex = 10
        '
        'mebContact
        '
        Me.mebContact.AllowPromptAsInput = False
        Me.mebContact.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mebContact.Location = New System.Drawing.Point(88, 52)
        Me.mebContact.Mask = ">&&&&&&&&&&&&&&&&&&&&&&"
        Me.mebContact.Name = "mebContact"
        Me.mebContact.Size = New System.Drawing.Size(177, 20)
        Me.mebContact.TabIndex = 11
        '
        'mebCustContactEmail
        '
        Me.mebCustContactEmail.AllowPromptAsInput = False
        Me.mebCustContactEmail.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mebCustContactEmail.Location = New System.Drawing.Point(88, 70)
        Me.mebCustContactEmail.Mask = ">&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&"
        Me.mebCustContactEmail.Name = "mebCustContactEmail"
        Me.mebCustContactEmail.Size = New System.Drawing.Size(177, 20)
        Me.mebCustContactEmail.TabIndex = 12
        '
        '_lblCustInfo_55
        '
        Me._lblCustInfo_55.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_55.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_55.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_55.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_55.Location = New System.Drawing.Point(16, 72)
        Me._lblCustInfo_55.Name = "_lblCustInfo_55"
        Me._lblCustInfo_55.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_55.Size = New System.Drawing.Size(65, 17)
        Me._lblCustInfo_55.TabIndex = 194
        Me._lblCustInfo_55.Text = "Email:"
        Me._lblCustInfo_55.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_52
        '
        Me._lblCustInfo_52.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_52.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_52.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_52.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_52.Location = New System.Drawing.Point(8, 24)
        Me._lblCustInfo_52.Name = "_lblCustInfo_52"
        Me._lblCustInfo_52.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_52.Size = New System.Drawing.Size(73, 17)
        Me._lblCustInfo_52.TabIndex = 60
        Me._lblCustInfo_52.Text = "Telephone:"
        Me._lblCustInfo_52.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_53
        '
        Me._lblCustInfo_53.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_53.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_53.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_53.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_53.Location = New System.Drawing.Point(32, 40)
        Me._lblCustInfo_53.Name = "_lblCustInfo_53"
        Me._lblCustInfo_53.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_53.Size = New System.Drawing.Size(49, 17)
        Me._lblCustInfo_53.TabIndex = 59
        Me._lblCustInfo_53.Text = "Fax:"
        Me._lblCustInfo_53.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_54
        '
        Me._lblCustInfo_54.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_54.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_54.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_54.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_54.Location = New System.Drawing.Point(16, 56)
        Me._lblCustInfo_54.Name = "_lblCustInfo_54"
        Me._lblCustInfo_54.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_54.Size = New System.Drawing.Size(65, 17)
        Me._lblCustInfo_54.TabIndex = 58
        Me._lblCustInfo_54.Text = "Contact:"
        Me._lblCustInfo_54.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'fraShipContact
        '
        Me.fraShipContact.BackColor = System.Drawing.SystemColors.Control
        Me.fraShipContact.Controls.Add(Me.mebShipContact)
        Me.fraShipContact.Controls.Add(Me.mebShipFax)
        Me.fraShipContact.Controls.Add(Me.mebShipPhone)
        Me.fraShipContact.Controls.Add(Me.mebCustShContactEmail)
        Me.fraShipContact.Controls.Add(Me._lblCustInfo_58)
        Me.fraShipContact.Controls.Add(Me._lblCustInfo_59)
        Me.fraShipContact.Controls.Add(Me._lblCustInfo_56)
        Me.fraShipContact.Controls.Add(Me._lblCustInfo_57)
        Me.fraShipContact.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraShipContact.ForeColor = System.Drawing.Color.Blue
        Me.fraShipContact.Location = New System.Drawing.Point(440, 306)
        Me.fraShipContact.Name = "fraShipContact"
        Me.fraShipContact.Padding = New System.Windows.Forms.Padding(0)
        Me.fraShipContact.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraShipContact.Size = New System.Drawing.Size(281, 97)
        Me.fraShipContact.TabIndex = 3
        Me.fraShipContact.TabStop = False
        Me.fraShipContact.Text = " Contact information: Shipping address "
        '
        'mebShipContact
        '
        Me.mebShipContact.AllowPromptAsInput = False
        Me.mebShipContact.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mebShipContact.Location = New System.Drawing.Point(88, 52)
        Me.mebShipContact.Mask = ">&&&&&&&&&&&&&&&&&&&&&&"
        Me.mebShipContact.Name = "mebShipContact"
        Me.mebShipContact.Size = New System.Drawing.Size(177, 20)
        Me.mebShipContact.TabIndex = 24
        '
        'mebShipFax
        '
        Me.mebShipFax.AllowPromptAsInput = False
        Me.mebShipFax.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mebShipFax.Location = New System.Drawing.Point(88, 34)
        Me.mebShipFax.Mask = "999-999-9999"
        Me.mebShipFax.Name = "mebShipFax"
        Me.mebShipFax.Size = New System.Drawing.Size(177, 20)
        Me.mebShipFax.TabIndex = 23
        '
        'mebShipPhone
        '
        Me.mebShipPhone.AllowPromptAsInput = False
        Me.mebShipPhone.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mebShipPhone.Location = New System.Drawing.Point(88, 16)
        Me.mebShipPhone.Mask = "999-999-9999"
        Me.mebShipPhone.Name = "mebShipPhone"
        Me.mebShipPhone.Size = New System.Drawing.Size(177, 20)
        Me.mebShipPhone.TabIndex = 22
        '
        'mebCustShContactEmail
        '
        Me.mebCustShContactEmail.AllowPromptAsInput = False
        Me.mebCustShContactEmail.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mebCustShContactEmail.Location = New System.Drawing.Point(88, 70)
        Me.mebCustShContactEmail.Mask = ">&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&"
        Me.mebCustShContactEmail.Name = "mebCustShContactEmail"
        Me.mebCustShContactEmail.Size = New System.Drawing.Size(177, 20)
        Me.mebCustShContactEmail.TabIndex = 25
        '
        '_lblCustInfo_58
        '
        Me._lblCustInfo_58.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_58.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_58.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_58.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_58.Location = New System.Drawing.Point(24, 56)
        Me._lblCustInfo_58.Name = "_lblCustInfo_58"
        Me._lblCustInfo_58.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_58.Size = New System.Drawing.Size(57, 17)
        Me._lblCustInfo_58.TabIndex = 27
        Me._lblCustInfo_58.Text = "Contact:"
        Me._lblCustInfo_58.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_59
        '
        Me._lblCustInfo_59.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_59.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_59.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_59.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_59.Location = New System.Drawing.Point(24, 72)
        Me._lblCustInfo_59.Name = "_lblCustInfo_59"
        Me._lblCustInfo_59.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_59.Size = New System.Drawing.Size(57, 17)
        Me._lblCustInfo_59.TabIndex = 195
        Me._lblCustInfo_59.Text = "Email:"
        Me._lblCustInfo_59.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_56
        '
        Me._lblCustInfo_56.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_56.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_56.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_56.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_56.Location = New System.Drawing.Point(8, 24)
        Me._lblCustInfo_56.Name = "_lblCustInfo_56"
        Me._lblCustInfo_56.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_56.Size = New System.Drawing.Size(73, 17)
        Me._lblCustInfo_56.TabIndex = 29
        Me._lblCustInfo_56.Text = "Telephone:"
        Me._lblCustInfo_56.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_57
        '
        Me._lblCustInfo_57.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_57.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_57.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_57.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_57.Location = New System.Drawing.Point(32, 40)
        Me._lblCustInfo_57.Name = "_lblCustInfo_57"
        Me._lblCustInfo_57.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_57.Size = New System.Drawing.Size(49, 17)
        Me._lblCustInfo_57.TabIndex = 28
        Me._lblCustInfo_57.Text = "Fax:"
        Me._lblCustInfo_57.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'fraCustAddr
        '
        Me.fraCustAddr.BackColor = System.Drawing.SystemColors.Control
        Me.fraCustAddr.Controls.Add(Me.mebAddr1)
        Me.fraCustAddr.Controls.Add(Me.mebCity)
        Me.fraCustAddr.Controls.Add(Me.mebName)
        Me.fraCustAddr.Controls.Add(Me.mebAddr2)
        Me.fraCustAddr.Controls.Add(Me.mebAddr3)
        Me.fraCustAddr.Controls.Add(Me.mebState)
        Me.fraCustAddr.Controls.Add(Me.mebZipCode)
        Me.fraCustAddr.Controls.Add(Me.mebCustEmail)
        Me.fraCustAddr.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraCustAddr.ForeColor = System.Drawing.Color.Blue
        Me.fraCustAddr.Location = New System.Drawing.Point(128, 82)
        Me.fraCustAddr.Name = "fraCustAddr"
        Me.fraCustAddr.Padding = New System.Windows.Forms.Padding(0)
        Me.fraCustAddr.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraCustAddr.Size = New System.Drawing.Size(281, 217)
        Me.fraCustAddr.TabIndex = 0
        Me.fraCustAddr.TabStop = False
        Me.fraCustAddr.Text = " MAIN CUSTOMER ADDRESS "
        '
        'mebAddr1
        '
        Me.mebAddr1.AllowPromptAsInput = False
        Me.mebAddr1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mebAddr1.Location = New System.Drawing.Point(8, 40)
        Me.mebAddr1.Mask = ">&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&"
        Me.mebAddr1.Name = "mebAddr1"
        Me.mebAddr1.Size = New System.Drawing.Size(265, 20)
        Me.mebAddr1.TabIndex = 2
        '
        'mebCity
        '
        Me.mebCity.AllowPromptAsInput = False
        Me.mebCity.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mebCity.Location = New System.Drawing.Point(8, 120)
        Me.mebCity.Mask = ">&&&&&&&&&&&&&&&&&&&&"
        Me.mebCity.Name = "mebCity"
        Me.mebCity.Size = New System.Drawing.Size(129, 20)
        Me.mebCity.TabIndex = 5
        '
        'mebName
        '
        Me.mebName.AllowPromptAsInput = False
        Me.mebName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mebName.Location = New System.Drawing.Point(8, 16)
        Me.mebName.Mask = ">&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&"
        Me.mebName.Name = "mebName"
        Me.mebName.Size = New System.Drawing.Size(265, 20)
        Me.mebName.TabIndex = 1
        '
        'mebAddr2
        '
        Me.mebAddr2.AllowPromptAsInput = False
        Me.mebAddr2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mebAddr2.Location = New System.Drawing.Point(8, 64)
        Me.mebAddr2.Mask = ">&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&"
        Me.mebAddr2.Name = "mebAddr2"
        Me.mebAddr2.Size = New System.Drawing.Size(265, 20)
        Me.mebAddr2.TabIndex = 3
        '
        'mebAddr3
        '
        Me.mebAddr3.AllowPromptAsInput = False
        Me.mebAddr3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mebAddr3.Location = New System.Drawing.Point(8, 88)
        Me.mebAddr3.Mask = ">&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&"
        Me.mebAddr3.Name = "mebAddr3"
        Me.mebAddr3.Size = New System.Drawing.Size(265, 20)
        Me.mebAddr3.TabIndex = 4
        '
        'mebState
        '
        Me.mebState.AllowPromptAsInput = False
        Me.mebState.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mebState.Location = New System.Drawing.Point(144, 120)
        Me.mebState.Mask = ">aa"
        Me.mebState.Name = "mebState"
        Me.mebState.Size = New System.Drawing.Size(33, 20)
        Me.mebState.TabIndex = 6
        '
        'mebZipCode
        '
        Me.mebZipCode.AllowPromptAsInput = False
        Me.mebZipCode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mebZipCode.Location = New System.Drawing.Point(184, 120)
        Me.mebZipCode.Mask = "99999-9999"
        Me.mebZipCode.Name = "mebZipCode"
        Me.mebZipCode.Size = New System.Drawing.Size(89, 20)
        Me.mebZipCode.TabIndex = 7
        '
        'mebCustEmail
        '
        Me.mebCustEmail.AllowPromptAsInput = False
        Me.mebCustEmail.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mebCustEmail.Location = New System.Drawing.Point(8, 152)
        Me.mebCustEmail.Mask = ">&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&"
        Me.mebCustEmail.Name = "mebCustEmail"
        Me.mebCustEmail.Size = New System.Drawing.Size(265, 20)
        Me.mebCustEmail.TabIndex = 8
        '
        'fraShipAddr
        '
        Me.fraShipAddr.BackColor = System.Drawing.SystemColors.Control
        Me.fraShipAddr.Controls.Add(Me.mebCustShEmail)
        Me.fraShipAddr.Controls.Add(Me.mebWebsite)
        Me.fraShipAddr.Controls.Add(Me.mebShipZipCode)
        Me.fraShipAddr.Controls.Add(Me.mebShipSt)
        Me.fraShipAddr.Controls.Add(Me.mebShipCity)
        Me.fraShipAddr.Controls.Add(Me.mebShipAddr3)
        Me.fraShipAddr.Controls.Add(Me.mebShipAddr2)
        Me.fraShipAddr.Controls.Add(Me.mebShipAddr1)
        Me.fraShipAddr.Controls.Add(Me.mebShipName)
        Me.fraShipAddr.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraShipAddr.ForeColor = System.Drawing.Color.Blue
        Me.fraShipAddr.Location = New System.Drawing.Point(440, 82)
        Me.fraShipAddr.Name = "fraShipAddr"
        Me.fraShipAddr.Padding = New System.Windows.Forms.Padding(0)
        Me.fraShipAddr.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraShipAddr.Size = New System.Drawing.Size(281, 217)
        Me.fraShipAddr.TabIndex = 2
        Me.fraShipAddr.TabStop = False
        Me.fraShipAddr.Text = " SHIPPING ADDRESS "
        '
        'mebCustShEmail
        '
        Me.mebCustShEmail.AllowPromptAsInput = False
        Me.mebCustShEmail.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mebCustShEmail.Location = New System.Drawing.Point(8, 152)
        Me.mebCustShEmail.Mask = ">&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&"
        Me.mebCustShEmail.Name = "mebCustShEmail"
        Me.mebCustShEmail.Size = New System.Drawing.Size(265, 20)
        Me.mebCustShEmail.TabIndex = 20
        '
        'mebWebsite
        '
        Me.mebWebsite.AllowPromptAsInput = False
        Me.mebWebsite.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mebWebsite.Location = New System.Drawing.Point(104, 184)
        Me.mebWebsite.Mask = ">&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&"
        Me.mebWebsite.Name = "mebWebsite"
        Me.mebWebsite.Size = New System.Drawing.Size(169, 20)
        Me.mebWebsite.TabIndex = 21
        '
        'mebShipZipCode
        '
        Me.mebShipZipCode.AllowPromptAsInput = False
        Me.mebShipZipCode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mebShipZipCode.Location = New System.Drawing.Point(184, 120)
        Me.mebShipZipCode.Mask = "99999-9999"
        Me.mebShipZipCode.Name = "mebShipZipCode"
        Me.mebShipZipCode.Size = New System.Drawing.Size(89, 20)
        Me.mebShipZipCode.TabIndex = 19
        '
        'mebShipSt
        '
        Me.mebShipSt.AllowPromptAsInput = False
        Me.mebShipSt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mebShipSt.Location = New System.Drawing.Point(144, 120)
        Me.mebShipSt.Mask = ">aa"
        Me.mebShipSt.Name = "mebShipSt"
        Me.mebShipSt.Size = New System.Drawing.Size(33, 20)
        Me.mebShipSt.TabIndex = 18
        '
        'mebShipCity
        '
        Me.mebShipCity.AllowPromptAsInput = False
        Me.mebShipCity.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mebShipCity.Location = New System.Drawing.Point(8, 120)
        Me.mebShipCity.Mask = ">&&&&&&&&&&&&&&&&&&&&"
        Me.mebShipCity.Name = "mebShipCity"
        Me.mebShipCity.Size = New System.Drawing.Size(129, 20)
        Me.mebShipCity.TabIndex = 17
        '
        'mebShipAddr3
        '
        Me.mebShipAddr3.AllowPromptAsInput = False
        Me.mebShipAddr3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mebShipAddr3.Location = New System.Drawing.Point(8, 88)
        Me.mebShipAddr3.Mask = ">&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&"
        Me.mebShipAddr3.Name = "mebShipAddr3"
        Me.mebShipAddr3.Size = New System.Drawing.Size(265, 20)
        Me.mebShipAddr3.TabIndex = 16
        '
        'mebShipAddr2
        '
        Me.mebShipAddr2.AllowPromptAsInput = False
        Me.mebShipAddr2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mebShipAddr2.Location = New System.Drawing.Point(8, 64)
        Me.mebShipAddr2.Mask = ">&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&"
        Me.mebShipAddr2.Name = "mebShipAddr2"
        Me.mebShipAddr2.Size = New System.Drawing.Size(265, 20)
        Me.mebShipAddr2.TabIndex = 15
        '
        'mebShipAddr1
        '
        Me.mebShipAddr1.AllowPromptAsInput = False
        Me.mebShipAddr1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mebShipAddr1.Location = New System.Drawing.Point(8, 40)
        Me.mebShipAddr1.Mask = ">&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&"
        Me.mebShipAddr1.Name = "mebShipAddr1"
        Me.mebShipAddr1.Size = New System.Drawing.Size(265, 20)
        Me.mebShipAddr1.TabIndex = 14
        '
        'mebShipName
        '
        Me.mebShipName.AllowPromptAsInput = False
        Me.mebShipName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mebShipName.Location = New System.Drawing.Point(8, 16)
        Me.mebShipName.Mask = ">&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&"
        Me.mebShipName.Name = "mebShipName"
        Me.mebShipName.Size = New System.Drawing.Size(265, 20)
        Me.mebShipName.TabIndex = 13
        '
        '_lblCustInfo_51
        '
        Me._lblCustInfo_51.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_51.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_51.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_51.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._lblCustInfo_51.Location = New System.Drawing.Point(48, 266)
        Me._lblCustInfo_51.Name = "_lblCustInfo_51"
        Me._lblCustInfo_51.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_51.Size = New System.Drawing.Size(73, 17)
        Me._lblCustInfo_51.TabIndex = 196
        Me._lblCustInfo_51.Text = "Website:"
        Me._lblCustInfo_51.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_50
        '
        Me._lblCustInfo_50.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_50.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_50.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_50.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._lblCustInfo_50.Location = New System.Drawing.Point(48, 242)
        Me._lblCustInfo_50.Name = "_lblCustInfo_50"
        Me._lblCustInfo_50.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_50.Size = New System.Drawing.Size(73, 17)
        Me._lblCustInfo_50.TabIndex = 193
        Me._lblCustInfo_50.Text = "Email Addr:"
        Me._lblCustInfo_50.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label61
        '
        Me.Label61.BackColor = System.Drawing.SystemColors.Control
        Me.Label61.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label61.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label61.Location = New System.Drawing.Point(424, 48)
        Me.Label61.Name = "Label61"
        Me.Label61.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label61.Size = New System.Drawing.Size(153, 17)
        Me.Label61.TabIndex = 0
        Me.Label61.Text = "Temporary shipping no.:"
        Me.Label61.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTempShipNo
        '
        Me.lblTempShipNo.BackColor = System.Drawing.SystemColors.Control
        Me.lblTempShipNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTempShipNo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTempShipNo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTempShipNo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTempShipNo.Location = New System.Drawing.Point(584, 40)
        Me.lblTempShipNo.Name = "lblTempShipNo"
        Me.lblTempShipNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTempShipNo.Size = New System.Drawing.Size(129, 25)
        Me.lblTempShipNo.TabIndex = 0
        Me.lblTempShipNo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label59
        '
        Me.Label59.BackColor = System.Drawing.SystemColors.Control
        Me.Label59.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label59.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label59.Location = New System.Drawing.Point(104, 48)
        Me.Label59.Name = "Label59"
        Me.Label59.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label59.Size = New System.Drawing.Size(153, 17)
        Me.Label59.TabIndex = 0
        Me.Label59.Text = "Temporary customer no.:"
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTempCustNo
        '
        Me.lblTempCustNo.BackColor = System.Drawing.SystemColors.Control
        Me.lblTempCustNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTempCustNo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTempCustNo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTempCustNo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTempCustNo.Location = New System.Drawing.Point(264, 40)
        Me.lblTempCustNo.Name = "lblTempCustNo"
        Me.lblTempCustNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTempCustNo.Size = New System.Drawing.Size(129, 25)
        Me.lblTempCustNo.TabIndex = 0
        Me.lblTempCustNo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_lblCustInfo_45
        '
        Me._lblCustInfo_45.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_45.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_45.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_45.ForeColor = System.Drawing.Color.Red
        Me._lblCustInfo_45.Location = New System.Drawing.Point(16, 106)
        Me._lblCustInfo_45.Name = "_lblCustInfo_45"
        Me._lblCustInfo_45.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_45.Size = New System.Drawing.Size(105, 17)
        Me._lblCustInfo_45.TabIndex = 67
        Me._lblCustInfo_45.Text = "* Name:"
        Me._lblCustInfo_45.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_47
        '
        Me._lblCustInfo_47.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_47.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_47.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_47.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._lblCustInfo_47.Location = New System.Drawing.Point(38, 147)
        Me._lblCustInfo_47.Name = "_lblCustInfo_47"
        Me._lblCustInfo_47.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_47.Size = New System.Drawing.Size(83, 24)
        Me._lblCustInfo_47.TabIndex = 66
        Me._lblCustInfo_47.Text = "Address - 2:"
        Me._lblCustInfo_47.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_46
        '
        Me._lblCustInfo_46.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_46.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_46.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_46.ForeColor = System.Drawing.Color.Red
        Me._lblCustInfo_46.Location = New System.Drawing.Point(35, 128)
        Me._lblCustInfo_46.Name = "_lblCustInfo_46"
        Me._lblCustInfo_46.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_46.Size = New System.Drawing.Size(86, 19)
        Me._lblCustInfo_46.TabIndex = 65
        Me._lblCustInfo_46.Text = "* Address - 1:"
        Me._lblCustInfo_46.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_49
        '
        Me._lblCustInfo_49.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_49.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_49.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_49.ForeColor = System.Drawing.Color.Red
        Me._lblCustInfo_49.Location = New System.Drawing.Point(35, 207)
        Me._lblCustInfo_49.Name = "_lblCustInfo_49"
        Me._lblCustInfo_49.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_49.Size = New System.Drawing.Size(86, 20)
        Me._lblCustInfo_49.TabIndex = 63
        Me._lblCustInfo_49.Text = "* City, St, Zip:"
        Me._lblCustInfo_49.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_48
        '
        Me._lblCustInfo_48.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_48.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_48.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_48.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._lblCustInfo_48.Location = New System.Drawing.Point(41, 176)
        Me._lblCustInfo_48.Name = "_lblCustInfo_48"
        Me._lblCustInfo_48.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_48.Size = New System.Drawing.Size(80, 19)
        Me._lblCustInfo_48.TabIndex = 62
        Me._lblCustInfo_48.Text = "Address - 3:"
        Me._lblCustInfo_48.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_tabCustInfo_TabPage1
        '
        Me._tabCustInfo_TabPage1.Controls.Add(Me.fraOrderList)
        Me._tabCustInfo_TabPage1.Location = New System.Drawing.Point(4, 22)
        Me._tabCustInfo_TabPage1.Name = "_tabCustInfo_TabPage1"
        Me._tabCustInfo_TabPage1.Size = New System.Drawing.Size(783, 486)
        Me._tabCustInfo_TabPage1.TabIndex = 1
        Me._tabCustInfo_TabPage1.Text = "Orders"
        Me._tabCustInfo_TabPage1.UseVisualStyleBackColor = True
        '
        'fraOrderList
        '
        Me.fraOrderList.BackColor = System.Drawing.SystemColors.Control
        Me.fraOrderList.Controls.Add(Me.Label3)
        Me.fraOrderList.Controls.Add(Me.dgvOrders)
        Me.fraOrderList.Controls.Add(Me.cmdViewOrder)
        Me.fraOrderList.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraOrderList.ForeColor = System.Drawing.Color.Blue
        Me.fraOrderList.Location = New System.Drawing.Point(8, 3)
        Me.fraOrderList.Name = "fraOrderList"
        Me.fraOrderList.Padding = New System.Windows.Forms.Padding(0)
        Me.fraOrderList.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraOrderList.Size = New System.Drawing.Size(791, 473)
        Me.fraOrderList.TabIndex = 19
        Me.fraOrderList.TabStop = False
        Me.fraOrderList.Text = " Orders "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(137, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(338, 14)
        Me.Label3.TabIndex = 203
        Me.Label3.Text = "TIP:  Click on column headers to sort ascending/descending"
        '
        'dgvOrders
        '
        Me.dgvOrders.AllowUserToAddRows = False
        Me.dgvOrders.AllowUserToDeleteRows = False
        Me.dgvOrders.AllowUserToOrderColumns = True
        Me.dgvOrders.AllowUserToResizeRows = False
        Me.dgvOrders.AutoGenerateColumns = False
        Me.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrdernoDataGridViewTextBoxColumn, Me.OrderdateDataGridViewTextBoxColumn, Me.SeasonDataGridViewTextBoxColumn, Me.CompletedateDataGridViewTextBoxColumn, Me.QtyorigordDataGridViewTextBoxColumn, Me.QtyshippedDataGridViewTextBoxColumn, Me.QtyopenorderDataGridViewTextBoxColumn, Me.OpenValueDataGridViewTextBoxColumn, Me.WorksheetIDDataGridViewTextBoxColumn, Me.InvoicenoDataGridViewTextBoxColumn, Me.CustpoDataGridViewTextBoxColumn, Me.LastUpDateDataGridViewTextBoxColumn})
        Me.dgvOrders.DataSource = Me.bndOrders
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOrders.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvOrders.Location = New System.Drawing.Point(0, 47)
        Me.dgvOrders.MultiSelect = False
        Me.dgvOrders.Name = "dgvOrders"
        Me.dgvOrders.ReadOnly = True
        Me.dgvOrders.RowHeadersVisible = False
        Me.dgvOrders.Size = New System.Drawing.Size(775, 391)
        Me.dgvOrders.TabIndex = 201
        '
        'OrdernoDataGridViewTextBoxColumn
        '
        Me.OrdernoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.OrdernoDataGridViewTextBoxColumn.DataPropertyName = "Order-no"
        Me.OrdernoDataGridViewTextBoxColumn.HeaderText = "Order No."
        Me.OrdernoDataGridViewTextBoxColumn.Name = "OrdernoDataGridViewTextBoxColumn"
        Me.OrdernoDataGridViewTextBoxColumn.ReadOnly = True
        Me.OrdernoDataGridViewTextBoxColumn.ToolTipText = "Customer's order number"
        '
        'OrderdateDataGridViewTextBoxColumn
        '
        Me.OrderdateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.OrderdateDataGridViewTextBoxColumn.DataPropertyName = "Order-date"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.OrderdateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.OrderdateDataGridViewTextBoxColumn.HeaderText = "Order Date"
        Me.OrderdateDataGridViewTextBoxColumn.Name = "OrderdateDataGridViewTextBoxColumn"
        Me.OrderdateDataGridViewTextBoxColumn.ReadOnly = True
        Me.OrderdateDataGridViewTextBoxColumn.ToolTipText = "Date the worksheet was made an order"
        '
        'SeasonDataGridViewTextBoxColumn
        '
        Me.SeasonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SeasonDataGridViewTextBoxColumn.DataPropertyName = "Season"
        Me.SeasonDataGridViewTextBoxColumn.HeaderText = "Season"
        Me.SeasonDataGridViewTextBoxColumn.Name = "SeasonDataGridViewTextBoxColumn"
        Me.SeasonDataGridViewTextBoxColumn.ReadOnly = True
        Me.SeasonDataGridViewTextBoxColumn.ToolTipText = "Season the item was ordered for"
        '
        'CompletedateDataGridViewTextBoxColumn
        '
        Me.CompletedateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CompletedateDataGridViewTextBoxColumn.DataPropertyName = "Complete-date"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.CompletedateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.CompletedateDataGridViewTextBoxColumn.HeaderText = "Complete By Date"
        Me.CompletedateDataGridViewTextBoxColumn.Name = "CompletedateDataGridViewTextBoxColumn"
        Me.CompletedateDataGridViewTextBoxColumn.ReadOnly = True
        Me.CompletedateDataGridViewTextBoxColumn.ToolTipText = "Date that the order must be complete by"
        '
        'QtyorigordDataGridViewTextBoxColumn
        '
        Me.QtyorigordDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.QtyorigordDataGridViewTextBoxColumn.DataPropertyName = "Qty-orig-ord"
        Me.QtyorigordDataGridViewTextBoxColumn.HeaderText = "Qty Orig Ordered"
        Me.QtyorigordDataGridViewTextBoxColumn.Name = "QtyorigordDataGridViewTextBoxColumn"
        Me.QtyorigordDataGridViewTextBoxColumn.ReadOnly = True
        Me.QtyorigordDataGridViewTextBoxColumn.ToolTipText = "Number of items originally placed on order"
        '
        'QtyshippedDataGridViewTextBoxColumn
        '
        Me.QtyshippedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.QtyshippedDataGridViewTextBoxColumn.DataPropertyName = "Qty-shipped"
        Me.QtyshippedDataGridViewTextBoxColumn.HeaderText = "Qty Shpd"
        Me.QtyshippedDataGridViewTextBoxColumn.Name = "QtyshippedDataGridViewTextBoxColumn"
        Me.QtyshippedDataGridViewTextBoxColumn.ReadOnly = True
        Me.QtyshippedDataGridViewTextBoxColumn.ToolTipText = "Number of items shipped as of the last update date"
        '
        'QtyopenorderDataGridViewTextBoxColumn
        '
        Me.QtyopenorderDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.QtyopenorderDataGridViewTextBoxColumn.DataPropertyName = "Qty-open-order"
        Me.QtyopenorderDataGridViewTextBoxColumn.HeaderText = "Open Order Qty"
        Me.QtyopenorderDataGridViewTextBoxColumn.Name = "QtyopenorderDataGridViewTextBoxColumn"
        Me.QtyopenorderDataGridViewTextBoxColumn.ReadOnly = True
        Me.QtyopenorderDataGridViewTextBoxColumn.ToolTipText = "Number of items that remain to be shipped as of the last update date"
        '
        'OpenValueDataGridViewTextBoxColumn
        '
        Me.OpenValueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.OpenValueDataGridViewTextBoxColumn.DataPropertyName = "OpenValue"
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.OpenValueDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.OpenValueDataGridViewTextBoxColumn.HeaderText = "Open Value"
        Me.OpenValueDataGridViewTextBoxColumn.Name = "OpenValueDataGridViewTextBoxColumn"
        Me.OpenValueDataGridViewTextBoxColumn.ReadOnly = True
        Me.OpenValueDataGridViewTextBoxColumn.ToolTipText = "Dollar amount of the items that have not been shipped yet"
        '
        'WorksheetIDDataGridViewTextBoxColumn
        '
        Me.WorksheetIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.WorksheetIDDataGridViewTextBoxColumn.DataPropertyName = "WorksheetID"
        Me.WorksheetIDDataGridViewTextBoxColumn.HeaderText = "Worksht No."
        Me.WorksheetIDDataGridViewTextBoxColumn.Name = "WorksheetIDDataGridViewTextBoxColumn"
        Me.WorksheetIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.WorksheetIDDataGridViewTextBoxColumn.ToolTipText = "Worksheet number associated with the order"
        '
        'InvoicenoDataGridViewTextBoxColumn
        '
        Me.InvoicenoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.InvoicenoDataGridViewTextBoxColumn.DataPropertyName = "Invoice-no"
        Me.InvoicenoDataGridViewTextBoxColumn.HeaderText = "Invoice Number"
        Me.InvoicenoDataGridViewTextBoxColumn.Name = "InvoicenoDataGridViewTextBoxColumn"
        Me.InvoicenoDataGridViewTextBoxColumn.ReadOnly = True
        Me.InvoicenoDataGridViewTextBoxColumn.ToolTipText = "The invoice number associated with this order"
        '
        'CustpoDataGridViewTextBoxColumn
        '
        Me.CustpoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CustpoDataGridViewTextBoxColumn.DataPropertyName = "Cust-po"
        Me.CustpoDataGridViewTextBoxColumn.HeaderText = "Customer PO#"
        Me.CustpoDataGridViewTextBoxColumn.Name = "CustpoDataGridViewTextBoxColumn"
        Me.CustpoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustpoDataGridViewTextBoxColumn.ToolTipText = "Customer's purchase order number"
        '
        'LastUpDateDataGridViewTextBoxColumn
        '
        Me.LastUpDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LastUpDateDataGridViewTextBoxColumn.DataPropertyName = "LastUpDate"
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.LastUpDateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.LastUpDateDataGridViewTextBoxColumn.HeaderText = "Last Update"
        Me.LastUpDateDataGridViewTextBoxColumn.Name = "LastUpDateDataGridViewTextBoxColumn"
        Me.LastUpDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.LastUpDateDataGridViewTextBoxColumn.ToolTipText = "The last date that any activity was performed on this order"
        '
        'bndOrders
        '
        Me.bndOrders.AllowNew = False
        Me.bndOrders.DataMember = "Order"
        Me.bndOrders.DataSource = Me.SaleForcDataSet
        '
        '_tabCustInfo_TabPage2
        '
        Me._tabCustInfo_TabPage2.Controls.Add(Me.fraWsList)
        Me._tabCustInfo_TabPage2.Location = New System.Drawing.Point(4, 22)
        Me._tabCustInfo_TabPage2.Name = "_tabCustInfo_TabPage2"
        Me._tabCustInfo_TabPage2.Size = New System.Drawing.Size(783, 486)
        Me._tabCustInfo_TabPage2.TabIndex = 2
        Me._tabCustInfo_TabPage2.Text = "Worksheets"
        Me._tabCustInfo_TabPage2.UseVisualStyleBackColor = True
        '
        'fraWsList
        '
        Me.fraWsList.BackColor = System.Drawing.SystemColors.Control
        Me.fraWsList.Controls.Add(Me.Label4)
        Me.fraWsList.Controls.Add(Me.dgvWorksheets)
        Me.fraWsList.Controls.Add(Me.cmdEmailWorksheet)
        Me.fraWsList.Controls.Add(Me.cmdRetransmit)
        Me.fraWsList.Controls.Add(Me.cmdPrint)
        Me.fraWsList.Controls.Add(Me.chkNoOrderWs)
        Me.fraWsList.Controls.Add(Me.cmdViewEditWs)
        Me.fraWsList.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraWsList.ForeColor = System.Drawing.Color.Blue
        Me.fraWsList.Location = New System.Drawing.Point(8, 3)
        Me.fraWsList.Name = "fraWsList"
        Me.fraWsList.Padding = New System.Windows.Forms.Padding(0)
        Me.fraWsList.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraWsList.Size = New System.Drawing.Size(801, 462)
        Me.fraWsList.TabIndex = 164
        Me.fraWsList.TabStop = False
        Me.fraWsList.Text = " Worksheets "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(341, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(344, 14)
        Me.Label4.TabIndex = 203
        Me.Label4.Text = "TIP:  Click on column headers to sort ascending/descending. "
        '
        'dgvWorksheets
        '
        Me.dgvWorksheets.AllowUserToAddRows = False
        Me.dgvWorksheets.AllowUserToDeleteRows = False
        Me.dgvWorksheets.AllowUserToOrderColumns = True
        Me.dgvWorksheets.AllowUserToResizeRows = False
        Me.dgvWorksheets.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dgvWorksheets.AutoGenerateColumns = False
        Me.dgvWorksheets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWorksheets.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WorksheetidDataGridViewTextBoxColumn1, Me.AllowmanualmaintDataGridViewCheckBoxColumn, Me.ReadyToXmitDataGridViewCheckBoxColumn, Me.XmittedDataGridViewCheckBoxColumn, Me.WscreatedateDataGridViewTextBoxColumn, Me.TransmittalstatusDataGridViewTextBoxColumn, Me.TransmittaldateDataGridViewTextBoxColumn, Me.ValidationstatusDataGridViewTextBoxColumn, Me.ValidationdateDataGridViewTextBoxColumn, Me.OrdernoDataGridViewTextBoxColumn1, Me.OrderdateDataGridViewTextBoxColumn1, Me.ErrorlevelDataGridViewTextBoxColumn, Me.season})
        Me.dgvWorksheets.DataSource = Me.bndWorksheets
        Me.dgvWorksheets.Location = New System.Drawing.Point(8, 50)
        Me.dgvWorksheets.MultiSelect = False
        Me.dgvWorksheets.Name = "dgvWorksheets"
        Me.dgvWorksheets.ReadOnly = True
        Me.dgvWorksheets.RowHeadersVisible = False
        Me.dgvWorksheets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvWorksheets.Size = New System.Drawing.Size(767, 391)
        Me.dgvWorksheets.TabIndex = 201
        '
        'WorksheetidDataGridViewTextBoxColumn1
        '
        Me.WorksheetidDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.WorksheetidDataGridViewTextBoxColumn1.DataPropertyName = "worksheet-id"
        Me.WorksheetidDataGridViewTextBoxColumn1.HeaderText = "Worksheet No"
        Me.WorksheetidDataGridViewTextBoxColumn1.Name = "WorksheetidDataGridViewTextBoxColumn1"
        Me.WorksheetidDataGridViewTextBoxColumn1.ReadOnly = True
        Me.WorksheetidDataGridViewTextBoxColumn1.ToolTipText = "Worksheet Number "
        Me.WorksheetidDataGridViewTextBoxColumn1.Width = 101
        '
        'AllowmanualmaintDataGridViewCheckBoxColumn
        '
        Me.AllowmanualmaintDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.AllowmanualmaintDataGridViewCheckBoxColumn.DataPropertyName = "allow-manual-maint"
        Me.AllowmanualmaintDataGridViewCheckBoxColumn.HeaderText = "Can Edit"
        Me.AllowmanualmaintDataGridViewCheckBoxColumn.Name = "AllowmanualmaintDataGridViewCheckBoxColumn"
        Me.AllowmanualmaintDataGridViewCheckBoxColumn.ReadOnly = True
        Me.AllowmanualmaintDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AllowmanualmaintDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.AllowmanualmaintDataGridViewCheckBoxColumn.ToolTipText = "Can you modify this worksheet"
        Me.AllowmanualmaintDataGridViewCheckBoxColumn.Width = 70
        '
        'ReadyToXmitDataGridViewCheckBoxColumn
        '
        Me.ReadyToXmitDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ReadyToXmitDataGridViewCheckBoxColumn.DataPropertyName = "ReadyToXmit"
        Me.ReadyToXmitDataGridViewCheckBoxColumn.HeaderText = "Ready To Xmit"
        Me.ReadyToXmitDataGridViewCheckBoxColumn.Name = "ReadyToXmitDataGridViewCheckBoxColumn"
        Me.ReadyToXmitDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ReadyToXmitDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ReadyToXmitDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ReadyToXmitDataGridViewCheckBoxColumn.ToolTipText = "Is this worksheet ready to transmit to Knitcraft"
        Me.ReadyToXmitDataGridViewCheckBoxColumn.Width = 78
        '
        'XmittedDataGridViewCheckBoxColumn
        '
        Me.XmittedDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.XmittedDataGridViewCheckBoxColumn.DataPropertyName = "Xmitted"
        Me.XmittedDataGridViewCheckBoxColumn.HeaderText = "Xmitted"
        Me.XmittedDataGridViewCheckBoxColumn.Name = "XmittedDataGridViewCheckBoxColumn"
        Me.XmittedDataGridViewCheckBoxColumn.ReadOnly = True
        Me.XmittedDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.XmittedDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.XmittedDataGridViewCheckBoxColumn.ToolTipText = "Has this worksheet be transmitted to Knitcraft"
        Me.XmittedDataGridViewCheckBoxColumn.Width = 75
        '
        'WscreatedateDataGridViewTextBoxColumn
        '
        Me.WscreatedateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.WscreatedateDataGridViewTextBoxColumn.DataPropertyName = "ws-create-date"
        DataGridViewCellStyle6.Format = "d"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.WscreatedateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.WscreatedateDataGridViewTextBoxColumn.HeaderText = "Date Created"
        Me.WscreatedateDataGridViewTextBoxColumn.Name = "WscreatedateDataGridViewTextBoxColumn"
        Me.WscreatedateDataGridViewTextBoxColumn.ReadOnly = True
        Me.WscreatedateDataGridViewTextBoxColumn.ToolTipText = "Date the worksheet was created"
        Me.WscreatedateDataGridViewTextBoxColumn.Width = 95
        '
        'TransmittalstatusDataGridViewTextBoxColumn
        '
        Me.TransmittalstatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.TransmittalstatusDataGridViewTextBoxColumn.DataPropertyName = "transmittal-status"
        Me.TransmittalstatusDataGridViewTextBoxColumn.HeaderText = "Xmit Status"
        Me.TransmittalstatusDataGridViewTextBoxColumn.Name = "TransmittalstatusDataGridViewTextBoxColumn"
        Me.TransmittalstatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.TransmittalstatusDataGridViewTextBoxColumn.ToolTipText = "The date the worksheet was transmitted"
        Me.TransmittalstatusDataGridViewTextBoxColumn.Width = 87
        '
        'TransmittaldateDataGridViewTextBoxColumn
        '
        Me.TransmittaldateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.TransmittaldateDataGridViewTextBoxColumn.DataPropertyName = "transmittal-date"
        DataGridViewCellStyle7.Format = "d"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.TransmittaldateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.TransmittaldateDataGridViewTextBoxColumn.HeaderText = "Xmit Date"
        Me.TransmittaldateDataGridViewTextBoxColumn.Name = "TransmittaldateDataGridViewTextBoxColumn"
        Me.TransmittaldateDataGridViewTextBoxColumn.ReadOnly = True
        Me.TransmittaldateDataGridViewTextBoxColumn.ToolTipText = "Day the worksheet was last transmitted to Knitcraft"
        Me.TransmittaldateDataGridViewTextBoxColumn.Width = 78
        '
        'ValidationstatusDataGridViewTextBoxColumn
        '
        Me.ValidationstatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ValidationstatusDataGridViewTextBoxColumn.DataPropertyName = "validation-status"
        Me.ValidationstatusDataGridViewTextBoxColumn.HeaderText = "Validation Status"
        Me.ValidationstatusDataGridViewTextBoxColumn.Name = "ValidationstatusDataGridViewTextBoxColumn"
        Me.ValidationstatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.ValidationstatusDataGridViewTextBoxColumn.ToolTipText = "Status assigned to the worksheet after going through the validation procedure"
        Me.ValidationstatusDataGridViewTextBoxColumn.Width = 113
        '
        'ValidationdateDataGridViewTextBoxColumn
        '
        Me.ValidationdateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ValidationdateDataGridViewTextBoxColumn.DataPropertyName = "validation-date"
        DataGridViewCellStyle8.Format = "d"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.ValidationdateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.ValidationdateDataGridViewTextBoxColumn.HeaderText = "Validation Date"
        Me.ValidationdateDataGridViewTextBoxColumn.Name = "ValidationdateDataGridViewTextBoxColumn"
        Me.ValidationdateDataGridViewTextBoxColumn.ReadOnly = True
        Me.ValidationdateDataGridViewTextBoxColumn.ToolTipText = "Date the worksheet when through the validation procedure"
        Me.ValidationdateDataGridViewTextBoxColumn.Width = 103
        '
        'OrdernoDataGridViewTextBoxColumn1
        '
        Me.OrdernoDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.OrdernoDataGridViewTextBoxColumn1.DataPropertyName = "order-no"
        Me.OrdernoDataGridViewTextBoxColumn1.HeaderText = "Order No"
        Me.OrdernoDataGridViewTextBoxColumn1.Name = "OrdernoDataGridViewTextBoxColumn1"
        Me.OrdernoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.OrdernoDataGridViewTextBoxColumn1.ToolTipText = "The order number assigned after being converted to an order"
        Me.OrdernoDataGridViewTextBoxColumn1.Width = 75
        '
        'OrderdateDataGridViewTextBoxColumn1
        '
        Me.OrderdateDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.OrderdateDataGridViewTextBoxColumn1.DataPropertyName = "order-date"
        DataGridViewCellStyle9.Format = "d"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.OrderdateDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle9
        Me.OrderdateDataGridViewTextBoxColumn1.HeaderText = "Order Date"
        Me.OrderdateDataGridViewTextBoxColumn1.Name = "OrderdateDataGridViewTextBoxColumn1"
        Me.OrderdateDataGridViewTextBoxColumn1.ReadOnly = True
        Me.OrderdateDataGridViewTextBoxColumn1.ToolTipText = "Date the worksheet was converted to an order"
        Me.OrderdateDataGridViewTextBoxColumn1.Width = 84
        '
        'ErrorlevelDataGridViewTextBoxColumn
        '
        Me.ErrorlevelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ErrorlevelDataGridViewTextBoxColumn.DataPropertyName = "error-level"
        Me.ErrorlevelDataGridViewTextBoxColumn.HeaderText = "Error Level"
        Me.ErrorlevelDataGridViewTextBoxColumn.Name = "ErrorlevelDataGridViewTextBoxColumn"
        Me.ErrorlevelDataGridViewTextBoxColumn.ReadOnly = True
        Me.ErrorlevelDataGridViewTextBoxColumn.ToolTipText = "If the worksheet contains errors, this number represents the priority number of t" &
    "he error"
        Me.ErrorlevelDataGridViewTextBoxColumn.Width = 86
        '
        'season
        '
        Me.season.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.season.DataPropertyName = "season"
        Me.season.HeaderText = "Season"
        Me.season.Name = "season"
        Me.season.ReadOnly = True
        Me.season.ToolTipText = "The season the worksheet was created for"
        Me.season.Width = 73
        '
        'bndWorksheets
        '
        Me.bndWorksheets.AllowNew = False
        Me.bndWorksheets.DataMember = "ws-ord-head"
        Me.bndWorksheets.DataSource = Me.SaleForcDataSet
        '
        'cmdEmailWorksheet
        '
        Me.cmdEmailWorksheet.BackColor = System.Drawing.SystemColors.Control
        Me.cmdEmailWorksheet.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEmailWorksheet.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEmailWorksheet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEmailWorksheet.Location = New System.Drawing.Point(184, 16)
        Me.cmdEmailWorksheet.Name = "cmdEmailWorksheet"
        Me.cmdEmailWorksheet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdEmailWorksheet.Size = New System.Drawing.Size(65, 25)
        Me.cmdEmailWorksheet.TabIndex = 198
        Me.cmdEmailWorksheet.Text = "E&mail"
        Me.cmdEmailWorksheet.UseVisualStyleBackColor = False
        '
        'cmdRetransmit
        '
        Me.cmdRetransmit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRetransmit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRetransmit.Enabled = False
        Me.cmdRetransmit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRetransmit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRetransmit.Location = New System.Drawing.Point(251, 16)
        Me.cmdRetransmit.Name = "cmdRetransmit"
        Me.cmdRetransmit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRetransmit.Size = New System.Drawing.Size(86, 25)
        Me.cmdRetransmit.TabIndex = 197
        Me.cmdRetransmit.Text = "&Re-transmit"
        Me.cmdRetransmit.UseVisualStyleBackColor = False
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrint.Location = New System.Drawing.Point(120, 16)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(57, 25)
        Me.cmdPrint.TabIndex = 173
        Me.cmdPrint.Text = "P&rint"
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        '_tabCustInfo_TabPage3
        '
        Me._tabCustInfo_TabPage3.Controls.Add(Me.fraSalesmanRef)
        Me._tabCustInfo_TabPage3.Controls.Add(Me.fraCustRef)
        Me._tabCustInfo_TabPage3.Controls.Add(Me.fraShipOther)
        Me._tabCustInfo_TabPage3.Controls.Add(Me.fraDates)
        Me._tabCustInfo_TabPage3.Location = New System.Drawing.Point(4, 22)
        Me._tabCustInfo_TabPage3.Name = "_tabCustInfo_TabPage3"
        Me._tabCustInfo_TabPage3.Size = New System.Drawing.Size(783, 486)
        Me._tabCustInfo_TabPage3.TabIndex = 3
        Me._tabCustInfo_TabPage3.Text = "Reference"
        Me._tabCustInfo_TabPage3.UseVisualStyleBackColor = True
        '
        'fraSalesmanRef
        '
        Me.fraSalesmanRef.BackColor = System.Drawing.SystemColors.Control
        Me.fraSalesmanRef.Controls.Add(Me.txtSlsmnRating)
        Me.fraSalesmanRef.Controls.Add(Me._lblCustInfo_44)
        Me.fraSalesmanRef.Controls.Add(Me._lblCustInfo_43)
        Me.fraSalesmanRef.Controls.Add(Me.lblSlsmnCd)
        Me.fraSalesmanRef.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraSalesmanRef.ForeColor = System.Drawing.Color.Blue
        Me.fraSalesmanRef.Location = New System.Drawing.Point(591, 323)
        Me.fraSalesmanRef.Name = "fraSalesmanRef"
        Me.fraSalesmanRef.Padding = New System.Windows.Forms.Padding(0)
        Me.fraSalesmanRef.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraSalesmanRef.Size = New System.Drawing.Size(161, 105)
        Me.fraSalesmanRef.TabIndex = 159
        Me.fraSalesmanRef.TabStop = False
        Me.fraSalesmanRef.Text = " Salesman "
        '
        'txtSlsmnRating
        '
        Me.txtSlsmnRating.AcceptsReturn = True
        Me.txtSlsmnRating.BackColor = System.Drawing.SystemColors.Window
        Me.txtSlsmnRating.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSlsmnRating.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomer, "Slsmn-rating", True))
        Me.txtSlsmnRating.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSlsmnRating.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSlsmnRating.Location = New System.Drawing.Point(64, 45)
        Me.txtSlsmnRating.MaxLength = 0
        Me.txtSlsmnRating.Name = "txtSlsmnRating"
        Me.txtSlsmnRating.ReadOnly = True
        Me.txtSlsmnRating.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSlsmnRating.Size = New System.Drawing.Size(81, 20)
        Me.txtSlsmnRating.TabIndex = 160
        Me.txtSlsmnRating.TabStop = False
        '
        '_lblCustInfo_44
        '
        Me._lblCustInfo_44.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_44.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_44.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_44.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_44.Location = New System.Drawing.Point(8, 48)
        Me._lblCustInfo_44.Name = "_lblCustInfo_44"
        Me._lblCustInfo_44.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_44.Size = New System.Drawing.Size(49, 17)
        Me._lblCustInfo_44.TabIndex = 163
        Me._lblCustInfo_44.Text = "Rating:"
        Me._lblCustInfo_44.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_43
        '
        Me._lblCustInfo_43.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_43.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_43.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_43.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_43.Location = New System.Drawing.Point(8, 24)
        Me._lblCustInfo_43.Name = "_lblCustInfo_43"
        Me._lblCustInfo_43.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_43.Size = New System.Drawing.Size(49, 17)
        Me._lblCustInfo_43.TabIndex = 162
        Me._lblCustInfo_43.Text = "Code:"
        Me._lblCustInfo_43.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSlsmnCd
        '
        Me.lblSlsmnCd.BackColor = System.Drawing.Color.White
        Me.lblSlsmnCd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSlsmnCd.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSlsmnCd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomer, "Slsmn-code", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.lblSlsmnCd.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSlsmnCd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSlsmnCd.Location = New System.Drawing.Point(64, 24)
        Me.lblSlsmnCd.Name = "lblSlsmnCd"
        Me.lblSlsmnCd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSlsmnCd.Size = New System.Drawing.Size(81, 17)
        Me.lblSlsmnCd.TabIndex = 161
        '
        'fraCustRef
        '
        Me.fraCustRef.BackColor = System.Drawing.SystemColors.Control
        Me.fraCustRef.Controls.Add(Me.txtDelq)
        Me.fraCustRef.Controls.Add(Me.txtTypeCode)
        Me.fraCustRef.Controls.Add(Me.txtARBal)
        Me.fraCustRef.Controls.Add(Me.txtHoldAR)
        Me.fraCustRef.Controls.Add(Me.txtCredRating)
        Me.fraCustRef.Controls.Add(Me.txtPymtCd)
        Me.fraCustRef.Controls.Add(Me.txtDelq1)
        Me.fraCustRef.Controls.Add(Me.txtLastPmtDate)
        Me.fraCustRef.Controls.Add(Me.txtLastOrddate)
        Me.fraCustRef.Controls.Add(Me.txtOpenOrdTot)
        Me.fraCustRef.Controls.Add(Me.txtAvg2Pay)
        Me.fraCustRef.Controls.Add(Me.txtLastPmtAmt)
        Me.fraCustRef.Controls.Add(Me.txtSACustNo)
        Me.fraCustRef.Controls.Add(Me.txtMailBillTo)
        Me.fraCustRef.Controls.Add(Me.txtChg2Cust)
        Me.fraCustRef.Controls.Add(Me.txtLabel)
        Me.fraCustRef.Controls.Add(Me._lblCustInfo_22)
        Me.fraCustRef.Controls.Add(Me._lblCustInfo_26)
        Me.fraCustRef.Controls.Add(Me._lblCustInfo_25)
        Me.fraCustRef.Controls.Add(Me._lblCustInfo_24)
        Me.fraCustRef.Controls.Add(Me._lblCustInfo_23)
        Me.fraCustRef.Controls.Add(Me._lblCustInfo_27)
        Me.fraCustRef.Controls.Add(Me._lblCustInfo_29)
        Me.fraCustRef.Controls.Add(Me._lblCustInfo_32)
        Me.fraCustRef.Controls.Add(Me._lblCustInfo_31)
        Me.fraCustRef.Controls.Add(Me._lblCustInfo_28)
        Me.fraCustRef.Controls.Add(Me._lblCustInfo_30)
        Me.fraCustRef.Controls.Add(Me._lblCustInfo_35)
        Me.fraCustRef.Controls.Add(Me._lblCustInfo_34)
        Me.fraCustRef.Controls.Add(Me._lblCustInfo_33)
        Me.fraCustRef.Controls.Add(Me._lblCustInfo_36)
        Me.fraCustRef.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraCustRef.ForeColor = System.Drawing.Color.Blue
        Me.fraCustRef.Location = New System.Drawing.Point(17, 27)
        Me.fraCustRef.Name = "fraCustRef"
        Me.fraCustRef.Padding = New System.Windows.Forms.Padding(0)
        Me.fraCustRef.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraCustRef.Size = New System.Drawing.Size(353, 401)
        Me.fraCustRef.TabIndex = 128
        Me.fraCustRef.TabStop = False
        Me.fraCustRef.Text = " Customer "
        '
        'txtDelq
        '
        Me.txtDelq.AcceptsReturn = True
        Me.txtDelq.BackColor = System.Drawing.SystemColors.Window
        Me.txtDelq.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDelq.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDelq.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDelq.Location = New System.Drawing.Point(256, 144)
        Me.txtDelq.MaxLength = 0
        Me.txtDelq.Name = "txtDelq"
        Me.txtDelq.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDelq.Size = New System.Drawing.Size(25, 20)
        Me.txtDelq.TabIndex = 167
        Me.txtDelq.Visible = False
        '
        'txtTypeCode
        '
        Me.txtTypeCode.AcceptsReturn = True
        Me.txtTypeCode.BackColor = System.Drawing.SystemColors.Window
        Me.txtTypeCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTypeCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomer, "Type-code", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtTypeCode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTypeCode.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTypeCode.Location = New System.Drawing.Point(144, 21)
        Me.txtTypeCode.MaxLength = 0
        Me.txtTypeCode.Name = "txtTypeCode"
        Me.txtTypeCode.ReadOnly = True
        Me.txtTypeCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTypeCode.Size = New System.Drawing.Size(153, 20)
        Me.txtTypeCode.TabIndex = 143
        Me.txtTypeCode.TabStop = False
        '
        'txtARBal
        '
        Me.txtARBal.AcceptsReturn = True
        Me.txtARBal.BackColor = System.Drawing.SystemColors.Window
        Me.txtARBal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtARBal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomer, "ArBalance", True, System.Windows.Forms.DataSourceUpdateMode.Never, Nothing, "C2"))
        Me.txtARBal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtARBal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtARBal.Location = New System.Drawing.Point(144, 117)
        Me.txtARBal.MaxLength = 0
        Me.txtARBal.Name = "txtARBal"
        Me.txtARBal.ReadOnly = True
        Me.txtARBal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtARBal.Size = New System.Drawing.Size(81, 20)
        Me.txtARBal.TabIndex = 142
        Me.txtARBal.TabStop = False
        '
        'txtHoldAR
        '
        Me.txtHoldAR.AcceptsReturn = True
        Me.txtHoldAR.BackColor = System.Drawing.SystemColors.Window
        Me.txtHoldAR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHoldAR.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomer, "Hold-ar-code", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtHoldAR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoldAR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHoldAR.Location = New System.Drawing.Point(144, 93)
        Me.txtHoldAR.MaxLength = 0
        Me.txtHoldAR.Name = "txtHoldAR"
        Me.txtHoldAR.ReadOnly = True
        Me.txtHoldAR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHoldAR.Size = New System.Drawing.Size(81, 20)
        Me.txtHoldAR.TabIndex = 141
        Me.txtHoldAR.TabStop = False
        '
        'txtCredRating
        '
        Me.txtCredRating.AcceptsReturn = True
        Me.txtCredRating.BackColor = System.Drawing.SystemColors.Window
        Me.txtCredRating.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCredRating.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomer, "Cred-rating", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtCredRating.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCredRating.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCredRating.Location = New System.Drawing.Point(144, 69)
        Me.txtCredRating.MaxLength = 0
        Me.txtCredRating.Name = "txtCredRating"
        Me.txtCredRating.ReadOnly = True
        Me.txtCredRating.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCredRating.Size = New System.Drawing.Size(81, 20)
        Me.txtCredRating.TabIndex = 140
        Me.txtCredRating.TabStop = False
        '
        'txtPymtCd
        '
        Me.txtPymtCd.AcceptsReturn = True
        Me.txtPymtCd.BackColor = System.Drawing.SystemColors.Window
        Me.txtPymtCd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPymtCd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomer, "Term-code", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtPymtCd.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPymtCd.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPymtCd.Location = New System.Drawing.Point(144, 45)
        Me.txtPymtCd.MaxLength = 0
        Me.txtPymtCd.Name = "txtPymtCd"
        Me.txtPymtCd.ReadOnly = True
        Me.txtPymtCd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPymtCd.Size = New System.Drawing.Size(153, 20)
        Me.txtPymtCd.TabIndex = 139
        Me.txtPymtCd.TabStop = False
        '
        'txtDelq1
        '
        Me.txtDelq1.AcceptsReturn = True
        Me.txtDelq1.BackColor = System.Drawing.SystemColors.Window
        Me.txtDelq1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDelq1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomer, "Delq", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtDelq1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDelq1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDelq1.Location = New System.Drawing.Point(144, 141)
        Me.txtDelq1.MaxLength = 0
        Me.txtDelq1.Name = "txtDelq1"
        Me.txtDelq1.ReadOnly = True
        Me.txtDelq1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDelq1.Size = New System.Drawing.Size(81, 20)
        Me.txtDelq1.TabIndex = 138
        Me.txtDelq1.TabStop = False
        '
        'txtLastPmtDate
        '
        Me.txtLastPmtDate.AcceptsReturn = True
        Me.txtLastPmtDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtLastPmtDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastPmtDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomer, "LastPayDate", True, System.Windows.Forms.DataSourceUpdateMode.Never, Nothing, "d"))
        Me.txtLastPmtDate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastPmtDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLastPmtDate.Location = New System.Drawing.Point(144, 189)
        Me.txtLastPmtDate.MaxLength = 0
        Me.txtLastPmtDate.Name = "txtLastPmtDate"
        Me.txtLastPmtDate.ReadOnly = True
        Me.txtLastPmtDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLastPmtDate.Size = New System.Drawing.Size(81, 20)
        Me.txtLastPmtDate.TabIndex = 137
        Me.txtLastPmtDate.TabStop = False
        '
        'txtLastOrddate
        '
        Me.txtLastOrddate.AcceptsReturn = True
        Me.txtLastOrddate.BackColor = System.Drawing.SystemColors.Window
        Me.txtLastOrddate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastOrddate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomer, "LastOrdDate", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtLastOrddate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastOrddate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLastOrddate.Location = New System.Drawing.Point(144, 261)
        Me.txtLastOrddate.MaxLength = 0
        Me.txtLastOrddate.Name = "txtLastOrddate"
        Me.txtLastOrddate.ReadOnly = True
        Me.txtLastOrddate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLastOrddate.Size = New System.Drawing.Size(81, 20)
        Me.txtLastOrddate.TabIndex = 136
        Me.txtLastOrddate.TabStop = False
        '
        'txtOpenOrdTot
        '
        Me.txtOpenOrdTot.AcceptsReturn = True
        Me.txtOpenOrdTot.BackColor = System.Drawing.SystemColors.Window
        Me.txtOpenOrdTot.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOpenOrdTot.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomer, "OpenOrdTot", True, System.Windows.Forms.DataSourceUpdateMode.Never, Nothing, "C2"))
        Me.txtOpenOrdTot.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOpenOrdTot.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOpenOrdTot.Location = New System.Drawing.Point(144, 237)
        Me.txtOpenOrdTot.MaxLength = 0
        Me.txtOpenOrdTot.Name = "txtOpenOrdTot"
        Me.txtOpenOrdTot.ReadOnly = True
        Me.txtOpenOrdTot.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOpenOrdTot.Size = New System.Drawing.Size(81, 20)
        Me.txtOpenOrdTot.TabIndex = 135
        Me.txtOpenOrdTot.TabStop = False
        '
        'txtAvg2Pay
        '
        Me.txtAvg2Pay.AcceptsReturn = True
        Me.txtAvg2Pay.BackColor = System.Drawing.SystemColors.Window
        Me.txtAvg2Pay.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAvg2Pay.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomer, "AvgDaysPay", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtAvg2Pay.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvg2Pay.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAvg2Pay.Location = New System.Drawing.Point(144, 165)
        Me.txtAvg2Pay.MaxLength = 0
        Me.txtAvg2Pay.Name = "txtAvg2Pay"
        Me.txtAvg2Pay.ReadOnly = True
        Me.txtAvg2Pay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAvg2Pay.Size = New System.Drawing.Size(81, 20)
        Me.txtAvg2Pay.TabIndex = 134
        Me.txtAvg2Pay.TabStop = False
        '
        'txtLastPmtAmt
        '
        Me.txtLastPmtAmt.AcceptsReturn = True
        Me.txtLastPmtAmt.BackColor = System.Drawing.SystemColors.Window
        Me.txtLastPmtAmt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastPmtAmt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomer, "LastPayAmt", True, System.Windows.Forms.DataSourceUpdateMode.Never, Nothing, "C2"))
        Me.txtLastPmtAmt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastPmtAmt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLastPmtAmt.Location = New System.Drawing.Point(144, 213)
        Me.txtLastPmtAmt.MaxLength = 0
        Me.txtLastPmtAmt.Name = "txtLastPmtAmt"
        Me.txtLastPmtAmt.ReadOnly = True
        Me.txtLastPmtAmt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLastPmtAmt.Size = New System.Drawing.Size(81, 20)
        Me.txtLastPmtAmt.TabIndex = 133
        Me.txtLastPmtAmt.TabStop = False
        '
        'txtSACustNo
        '
        Me.txtSACustNo.AcceptsReturn = True
        Me.txtSACustNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtSACustNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSACustNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomer, "Stats-cust", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtSACustNo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSACustNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSACustNo.Location = New System.Drawing.Point(144, 333)
        Me.txtSACustNo.MaxLength = 0
        Me.txtSACustNo.Name = "txtSACustNo"
        Me.txtSACustNo.ReadOnly = True
        Me.txtSACustNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSACustNo.Size = New System.Drawing.Size(81, 20)
        Me.txtSACustNo.TabIndex = 132
        Me.txtSACustNo.TabStop = False
        '
        'txtMailBillTo
        '
        Me.txtMailBillTo.AcceptsReturn = True
        Me.txtMailBillTo.BackColor = System.Drawing.SystemColors.Window
        Me.txtMailBillTo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMailBillTo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomer, "Mail-cust", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtMailBillTo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMailBillTo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMailBillTo.Location = New System.Drawing.Point(144, 309)
        Me.txtMailBillTo.MaxLength = 0
        Me.txtMailBillTo.Name = "txtMailBillTo"
        Me.txtMailBillTo.ReadOnly = True
        Me.txtMailBillTo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMailBillTo.Size = New System.Drawing.Size(81, 20)
        Me.txtMailBillTo.TabIndex = 131
        Me.txtMailBillTo.TabStop = False
        '
        'txtChg2Cust
        '
        Me.txtChg2Cust.AcceptsReturn = True
        Me.txtChg2Cust.BackColor = System.Drawing.SystemColors.Window
        Me.txtChg2Cust.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtChg2Cust.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomer, "Charge-cust", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtChg2Cust.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChg2Cust.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtChg2Cust.Location = New System.Drawing.Point(144, 285)
        Me.txtChg2Cust.MaxLength = 0
        Me.txtChg2Cust.Name = "txtChg2Cust"
        Me.txtChg2Cust.ReadOnly = True
        Me.txtChg2Cust.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtChg2Cust.Size = New System.Drawing.Size(81, 20)
        Me.txtChg2Cust.TabIndex = 130
        Me.txtChg2Cust.TabStop = False
        '
        'txtLabel
        '
        Me.txtLabel.AcceptsReturn = True
        Me.txtLabel.BackColor = System.Drawing.SystemColors.Window
        Me.txtLabel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomer, "LabelNo", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLabel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLabel.Location = New System.Drawing.Point(144, 360)
        Me.txtLabel.MaxLength = 0
        Me.txtLabel.Name = "txtLabel"
        Me.txtLabel.ReadOnly = True
        Me.txtLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLabel.Size = New System.Drawing.Size(169, 20)
        Me.txtLabel.TabIndex = 129
        Me.txtLabel.TabStop = False
        '
        '_lblCustInfo_22
        '
        Me._lblCustInfo_22.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_22.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_22.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_22.Location = New System.Drawing.Point(32, 24)
        Me._lblCustInfo_22.Name = "_lblCustInfo_22"
        Me._lblCustInfo_22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_22.Size = New System.Drawing.Size(105, 17)
        Me._lblCustInfo_22.TabIndex = 158
        Me._lblCustInfo_22.Text = "Type code:"
        Me._lblCustInfo_22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_26
        '
        Me._lblCustInfo_26.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_26.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_26.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_26.Location = New System.Drawing.Point(40, 120)
        Me._lblCustInfo_26.Name = "_lblCustInfo_26"
        Me._lblCustInfo_26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_26.Size = New System.Drawing.Size(97, 17)
        Me._lblCustInfo_26.TabIndex = 157
        Me._lblCustInfo_26.Text = "A/R balance:"
        Me._lblCustInfo_26.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_25
        '
        Me._lblCustInfo_25.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_25.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_25.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_25.Location = New System.Drawing.Point(32, 96)
        Me._lblCustInfo_25.Name = "_lblCustInfo_25"
        Me._lblCustInfo_25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_25.Size = New System.Drawing.Size(105, 17)
        Me._lblCustInfo_25.TabIndex = 156
        Me._lblCustInfo_25.Text = "Hold A/R code:"
        Me._lblCustInfo_25.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_24
        '
        Me._lblCustInfo_24.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_24.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_24.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_24.Location = New System.Drawing.Point(48, 72)
        Me._lblCustInfo_24.Name = "_lblCustInfo_24"
        Me._lblCustInfo_24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_24.Size = New System.Drawing.Size(89, 17)
        Me._lblCustInfo_24.TabIndex = 155
        Me._lblCustInfo_24.Text = "Credit rating:"
        Me._lblCustInfo_24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_23
        '
        Me._lblCustInfo_23.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_23.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_23.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_23.Location = New System.Drawing.Point(8, 48)
        Me._lblCustInfo_23.Name = "_lblCustInfo_23"
        Me._lblCustInfo_23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_23.Size = New System.Drawing.Size(129, 17)
        Me._lblCustInfo_23.TabIndex = 154
        Me._lblCustInfo_23.Text = "Payment terms code:"
        Me._lblCustInfo_23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_27
        '
        Me._lblCustInfo_27.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_27.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_27.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_27.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_27.Location = New System.Drawing.Point(48, 144)
        Me._lblCustInfo_27.Name = "_lblCustInfo_27"
        Me._lblCustInfo_27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_27.Size = New System.Drawing.Size(89, 17)
        Me._lblCustInfo_27.TabIndex = 153
        Me._lblCustInfo_27.Text = "Delinquent:"
        Me._lblCustInfo_27.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_29
        '
        Me._lblCustInfo_29.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_29.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_29.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_29.Location = New System.Drawing.Point(16, 192)
        Me._lblCustInfo_29.Name = "_lblCustInfo_29"
        Me._lblCustInfo_29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_29.Size = New System.Drawing.Size(121, 17)
        Me._lblCustInfo_29.TabIndex = 152
        Me._lblCustInfo_29.Text = "Last payment date:"
        Me._lblCustInfo_29.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_32
        '
        Me._lblCustInfo_32.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_32.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_32.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_32.Location = New System.Drawing.Point(24, 264)
        Me._lblCustInfo_32.Name = "_lblCustInfo_32"
        Me._lblCustInfo_32.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_32.Size = New System.Drawing.Size(113, 17)
        Me._lblCustInfo_32.TabIndex = 151
        Me._lblCustInfo_32.Text = "Last order date:"
        Me._lblCustInfo_32.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_31
        '
        Me._lblCustInfo_31.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_31.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_31.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_31.Location = New System.Drawing.Point(16, 240)
        Me._lblCustInfo_31.Name = "_lblCustInfo_31"
        Me._lblCustInfo_31.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_31.Size = New System.Drawing.Size(121, 17)
        Me._lblCustInfo_31.TabIndex = 150
        Me._lblCustInfo_31.Text = "Open order total:"
        Me._lblCustInfo_31.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_28
        '
        Me._lblCustInfo_28.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_28.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_28.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_28.Location = New System.Drawing.Point(24, 168)
        Me._lblCustInfo_28.Name = "_lblCustInfo_28"
        Me._lblCustInfo_28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_28.Size = New System.Drawing.Size(113, 17)
        Me._lblCustInfo_28.TabIndex = 149
        Me._lblCustInfo_28.Text = "Avg. days to pay:"
        Me._lblCustInfo_28.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_30
        '
        Me._lblCustInfo_30.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_30.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_30.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_30.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_30.Location = New System.Drawing.Point(8, 216)
        Me._lblCustInfo_30.Name = "_lblCustInfo_30"
        Me._lblCustInfo_30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_30.Size = New System.Drawing.Size(129, 17)
        Me._lblCustInfo_30.TabIndex = 148
        Me._lblCustInfo_30.Text = "Last payment amount:"
        Me._lblCustInfo_30.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_35
        '
        Me._lblCustInfo_35.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_35.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_35.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_35.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_35.Location = New System.Drawing.Point(0, 336)
        Me._lblCustInfo_35.Name = "_lblCustInfo_35"
        Me._lblCustInfo_35.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_35.Size = New System.Drawing.Size(138, 20)
        Me._lblCustInfo_35.TabIndex = 147
        Me._lblCustInfo_35.Text = "S/A customer number:"
        Me._lblCustInfo_35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_lblCustInfo_34
        '
        Me._lblCustInfo_34.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_34.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_34.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_34.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_34.Location = New System.Drawing.Point(8, 312)
        Me._lblCustInfo_34.Name = "_lblCustInfo_34"
        Me._lblCustInfo_34.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_34.Size = New System.Drawing.Size(129, 17)
        Me._lblCustInfo_34.TabIndex = 146
        Me._lblCustInfo_34.Text = "Mail bill to customer:"
        Me._lblCustInfo_34.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_33
        '
        Me._lblCustInfo_33.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_33.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_33.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_33.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_33.Location = New System.Drawing.Point(16, 288)
        Me._lblCustInfo_33.Name = "_lblCustInfo_33"
        Me._lblCustInfo_33.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_33.Size = New System.Drawing.Size(121, 17)
        Me._lblCustInfo_33.TabIndex = 145
        Me._lblCustInfo_33.Text = "Charge to customer:"
        Me._lblCustInfo_33.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_36
        '
        Me._lblCustInfo_36.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_36.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_36.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_36.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_36.Location = New System.Drawing.Point(88, 360)
        Me._lblCustInfo_36.Name = "_lblCustInfo_36"
        Me._lblCustInfo_36.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_36.Size = New System.Drawing.Size(49, 17)
        Me._lblCustInfo_36.TabIndex = 144
        Me._lblCustInfo_36.Text = "Label:"
        Me._lblCustInfo_36.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'fraShipOther
        '
        Me.fraShipOther.BackColor = System.Drawing.SystemColors.Control
        Me.fraShipOther.Controls.Add(Me.chkComplete)
        Me.fraShipOther.Controls.Add(Me.chkShipActive)
        Me.fraShipOther.Controls.Add(Me.txtShipHoldShpmtCd)
        Me.fraShipOther.Controls.Add(Me.txtShipTypeCd)
        Me.fraShipOther.Controls.Add(Me.txtShipPayTerms)
        Me.fraShipOther.Controls.Add(Me._lblCustInfo_39)
        Me.fraShipOther.Controls.Add(Me._lblCustInfo_37)
        Me.fraShipOther.Controls.Add(Me._lblCustInfo_38)
        Me.fraShipOther.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraShipOther.ForeColor = System.Drawing.Color.Blue
        Me.fraShipOther.Location = New System.Drawing.Point(392, 27)
        Me.fraShipOther.Name = "fraShipOther"
        Me.fraShipOther.Padding = New System.Windows.Forms.Padding(0)
        Me.fraShipOther.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraShipOther.Size = New System.Drawing.Size(361, 145)
        Me.fraShipOther.TabIndex = 119
        Me.fraShipOther.TabStop = False
        Me.fraShipOther.Text = " Shipping "
        '
        'chkComplete
        '
        Me.chkComplete.BackColor = System.Drawing.SystemColors.Control
        Me.chkComplete.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkComplete.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkComplete.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bndCustomerShip, "Complete", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.chkComplete.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkComplete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkComplete.Location = New System.Drawing.Point(72, 120)
        Me.chkComplete.Name = "chkComplete"
        Me.chkComplete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkComplete.Size = New System.Drawing.Size(81, 17)
        Me.chkComplete.TabIndex = 124
        Me.chkComplete.Text = "Complete"
        Me.chkComplete.UseVisualStyleBackColor = False
        '
        'chkShipActive
        '
        Me.chkShipActive.BackColor = System.Drawing.SystemColors.Control
        Me.chkShipActive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkShipActive.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkShipActive.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bndCustomerShip, "ShipActive", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.chkShipActive.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShipActive.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkShipActive.Location = New System.Drawing.Point(56, 96)
        Me.chkShipActive.Name = "chkShipActive"
        Me.chkShipActive.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkShipActive.Size = New System.Drawing.Size(97, 17)
        Me.chkShipActive.TabIndex = 123
        Me.chkShipActive.TabStop = False
        Me.chkShipActive.Text = "Ship active"
        Me.chkShipActive.UseVisualStyleBackColor = False
        '
        'txtShipHoldShpmtCd
        '
        Me.txtShipHoldShpmtCd.AcceptsReturn = True
        Me.txtShipHoldShpmtCd.BackColor = System.Drawing.SystemColors.Window
        Me.txtShipHoldShpmtCd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShipHoldShpmtCd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomerShip, "HoldShipCode", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtShipHoldShpmtCd.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShipHoldShpmtCd.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtShipHoldShpmtCd.Location = New System.Drawing.Point(136, 64)
        Me.txtShipHoldShpmtCd.MaxLength = 0
        Me.txtShipHoldShpmtCd.Name = "txtShipHoldShpmtCd"
        Me.txtShipHoldShpmtCd.ReadOnly = True
        Me.txtShipHoldShpmtCd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtShipHoldShpmtCd.Size = New System.Drawing.Size(81, 20)
        Me.txtShipHoldShpmtCd.TabIndex = 122
        Me.txtShipHoldShpmtCd.TabStop = False
        '
        'txtShipTypeCd
        '
        Me.txtShipTypeCd.AcceptsReturn = True
        Me.txtShipTypeCd.BackColor = System.Drawing.SystemColors.Window
        Me.txtShipTypeCd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShipTypeCd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomerShip, "Type-code", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtShipTypeCd.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShipTypeCd.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtShipTypeCd.Location = New System.Drawing.Point(136, 13)
        Me.txtShipTypeCd.MaxLength = 0
        Me.txtShipTypeCd.Name = "txtShipTypeCd"
        Me.txtShipTypeCd.ReadOnly = True
        Me.txtShipTypeCd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtShipTypeCd.Size = New System.Drawing.Size(129, 20)
        Me.txtShipTypeCd.TabIndex = 121
        Me.txtShipTypeCd.TabStop = False
        '
        'txtShipPayTerms
        '
        Me.txtShipPayTerms.AcceptsReturn = True
        Me.txtShipPayTerms.BackColor = System.Drawing.SystemColors.Window
        Me.txtShipPayTerms.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShipPayTerms.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomerShip, "Term-code", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.txtShipPayTerms.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShipPayTerms.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtShipPayTerms.Location = New System.Drawing.Point(136, 37)
        Me.txtShipPayTerms.MaxLength = 0
        Me.txtShipPayTerms.Name = "txtShipPayTerms"
        Me.txtShipPayTerms.ReadOnly = True
        Me.txtShipPayTerms.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtShipPayTerms.Size = New System.Drawing.Size(129, 20)
        Me.txtShipPayTerms.TabIndex = 120
        Me.txtShipPayTerms.TabStop = False
        '
        '_lblCustInfo_39
        '
        Me._lblCustInfo_39.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_39.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_39.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_39.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_39.Location = New System.Drawing.Point(8, 67)
        Me._lblCustInfo_39.Name = "_lblCustInfo_39"
        Me._lblCustInfo_39.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_39.Size = New System.Drawing.Size(121, 17)
        Me._lblCustInfo_39.TabIndex = 127
        Me._lblCustInfo_39.Text = "Hold shipment code:"
        Me._lblCustInfo_39.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_37
        '
        Me._lblCustInfo_37.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_37.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_37.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_37.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_37.Location = New System.Drawing.Point(24, 16)
        Me._lblCustInfo_37.Name = "_lblCustInfo_37"
        Me._lblCustInfo_37.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_37.Size = New System.Drawing.Size(105, 17)
        Me._lblCustInfo_37.TabIndex = 126
        Me._lblCustInfo_37.Text = "Customer Type:"
        Me._lblCustInfo_37.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_38
        '
        Me._lblCustInfo_38.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_38.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_38.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_38.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_38.Location = New System.Drawing.Point(8, 40)
        Me._lblCustInfo_38.Name = "_lblCustInfo_38"
        Me._lblCustInfo_38.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_38.Size = New System.Drawing.Size(121, 17)
        Me._lblCustInfo_38.TabIndex = 125
        Me._lblCustInfo_38.Text = "Payment terms:"
        Me._lblCustInfo_38.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'fraDates
        '
        Me.fraDates.BackColor = System.Drawing.SystemColors.Control
        Me.fraDates.Controls.Add(Me.txtLastChgd)
        Me.fraDates.Controls.Add(Me.txtCustAddDate)
        Me.fraDates.Controls.Add(Me.txtLastUpdated)
        Me.fraDates.Controls.Add(Me._lblCustInfo_41)
        Me.fraDates.Controls.Add(Me._lblCustInfo_40)
        Me.fraDates.Controls.Add(Me._lblCustInfo_42)
        Me.fraDates.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraDates.ForeColor = System.Drawing.Color.Blue
        Me.fraDates.Location = New System.Drawing.Point(376, 323)
        Me.fraDates.Name = "fraDates"
        Me.fraDates.Padding = New System.Windows.Forms.Padding(0)
        Me.fraDates.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraDates.Size = New System.Drawing.Size(209, 105)
        Me.fraDates.TabIndex = 112
        Me.fraDates.TabStop = False
        Me.fraDates.Text = " Dates "
        '
        'txtLastChgd
        '
        Me.txtLastChgd.AcceptsReturn = True
        Me.txtLastChgd.BackColor = System.Drawing.SystemColors.Window
        Me.txtLastChgd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastChgd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomer, "Last-chg-date", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "d"))
        Me.txtLastChgd.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastChgd.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLastChgd.Location = New System.Drawing.Point(104, 40)
        Me.txtLastChgd.MaxLength = 0
        Me.txtLastChgd.Name = "txtLastChgd"
        Me.txtLastChgd.ReadOnly = True
        Me.txtLastChgd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLastChgd.Size = New System.Drawing.Size(81, 20)
        Me.txtLastChgd.TabIndex = 115
        Me.txtLastChgd.TabStop = False
        '
        'txtCustAddDate
        '
        Me.txtCustAddDate.AcceptsReturn = True
        Me.txtCustAddDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtCustAddDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCustAddDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomer, "cust-addate", True, System.Windows.Forms.DataSourceUpdateMode.Never, Nothing, "d"))
        Me.txtCustAddDate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustAddDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCustAddDate.Location = New System.Drawing.Point(104, 16)
        Me.txtCustAddDate.MaxLength = 0
        Me.txtCustAddDate.Name = "txtCustAddDate"
        Me.txtCustAddDate.ReadOnly = True
        Me.txtCustAddDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCustAddDate.Size = New System.Drawing.Size(81, 20)
        Me.txtCustAddDate.TabIndex = 114
        Me.txtCustAddDate.TabStop = False
        '
        'txtLastUpdated
        '
        Me.txtLastUpdated.AcceptsReturn = True
        Me.txtLastUpdated.BackColor = System.Drawing.SystemColors.Window
        Me.txtLastUpdated.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastUpdated.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomer, "LastUpdated", True, System.Windows.Forms.DataSourceUpdateMode.Never, Nothing, "d"))
        Me.txtLastUpdated.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastUpdated.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLastUpdated.Location = New System.Drawing.Point(104, 64)
        Me.txtLastUpdated.MaxLength = 0
        Me.txtLastUpdated.Name = "txtLastUpdated"
        Me.txtLastUpdated.ReadOnly = True
        Me.txtLastUpdated.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLastUpdated.Size = New System.Drawing.Size(81, 20)
        Me.txtLastUpdated.TabIndex = 113
        Me.txtLastUpdated.TabStop = False
        '
        '_lblCustInfo_41
        '
        Me._lblCustInfo_41.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_41.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_41.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_41.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_41.Location = New System.Drawing.Point(8, 43)
        Me._lblCustInfo_41.Name = "_lblCustInfo_41"
        Me._lblCustInfo_41.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_41.Size = New System.Drawing.Size(89, 17)
        Me._lblCustInfo_41.TabIndex = 118
        Me._lblCustInfo_41.Text = "Last changed:"
        Me._lblCustInfo_41.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_40
        '
        Me._lblCustInfo_40.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_40.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_40.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_40.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_40.Location = New System.Drawing.Point(48, 19)
        Me._lblCustInfo_40.Name = "_lblCustInfo_40"
        Me._lblCustInfo_40.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_40.Size = New System.Drawing.Size(49, 17)
        Me._lblCustInfo_40.TabIndex = 117
        Me._lblCustInfo_40.Text = "Added:"
        Me._lblCustInfo_40.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lblCustInfo_42
        '
        Me._lblCustInfo_42.BackColor = System.Drawing.SystemColors.Control
        Me._lblCustInfo_42.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCustInfo_42.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCustInfo_42.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCustInfo_42.Location = New System.Drawing.Point(3, 72)
        Me._lblCustInfo_42.Name = "_lblCustInfo_42"
        Me._lblCustInfo_42.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCustInfo_42.Size = New System.Drawing.Size(94, 12)
        Me._lblCustInfo_42.TabIndex = 116
        Me._lblCustInfo_42.Text = "Last updated:"
        Me._lblCustInfo_42.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_tabCustInfo_TabPage4
        '
        Me._tabCustInfo_TabPage4.Controls.Add(Me.Frame1)
        Me._tabCustInfo_TabPage4.Location = New System.Drawing.Point(4, 22)
        Me._tabCustInfo_TabPage4.Name = "_tabCustInfo_TabPage4"
        Me._tabCustInfo_TabPage4.Size = New System.Drawing.Size(783, 486)
        Me._tabCustInfo_TabPage4.TabIndex = 4
        Me._tabCustInfo_TabPage4.Text = "Memos"
        Me._tabCustInfo_TabPage4.UseVisualStyleBackColor = True
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.dgvCustomerMemos)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(8, 15)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(807, 450)
        Me.Frame1.TabIndex = 168
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Customer Memos"
        '
        'dgvCustomerMemos
        '
        Me.dgvCustomerMemos.AllowUserToAddRows = False
        Me.dgvCustomerMemos.AllowUserToDeleteRows = False
        Me.dgvCustomerMemos.AllowUserToResizeColumns = False
        Me.dgvCustomerMemos.AllowUserToResizeRows = False
        Me.dgvCustomerMemos.AutoGenerateColumns = False
        Me.dgvCustomerMemos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCustomerMemos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomerMemos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MemoLineDataGridViewTextBoxColumn, Me.PageNoDataGridViewTextBoxColumn, Me.LineNoDataGridViewTextBoxColumn})
        Me.dgvCustomerMemos.DataSource = Me.bndCustMemos
        Me.dgvCustomerMemos.Location = New System.Drawing.Point(15, 27)
        Me.dgvCustomerMemos.MultiSelect = False
        Me.dgvCustomerMemos.Name = "dgvCustomerMemos"
        Me.dgvCustomerMemos.ReadOnly = True
        Me.dgvCustomerMemos.RowHeadersVisible = False
        Me.dgvCustomerMemos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCustomerMemos.Size = New System.Drawing.Size(764, 391)
        Me.dgvCustomerMemos.TabIndex = 0
        '
        'MemoLineDataGridViewTextBoxColumn
        '
        Me.MemoLineDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MemoLineDataGridViewTextBoxColumn.DataPropertyName = "MemoLine"
        Me.MemoLineDataGridViewTextBoxColumn.HeaderText = "Memo"
        Me.MemoLineDataGridViewTextBoxColumn.Name = "MemoLineDataGridViewTextBoxColumn"
        Me.MemoLineDataGridViewTextBoxColumn.ReadOnly = True
        Me.MemoLineDataGridViewTextBoxColumn.Width = 60
        '
        'PageNoDataGridViewTextBoxColumn
        '
        Me.PageNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PageNoDataGridViewTextBoxColumn.DataPropertyName = "PageNo"
        Me.PageNoDataGridViewTextBoxColumn.HeaderText = "Page"
        Me.PageNoDataGridViewTextBoxColumn.Name = "PageNoDataGridViewTextBoxColumn"
        Me.PageNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PageNoDataGridViewTextBoxColumn.Width = 56
        '
        'LineNoDataGridViewTextBoxColumn
        '
        Me.LineNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.LineNoDataGridViewTextBoxColumn.DataPropertyName = "LineNo"
        Me.LineNoDataGridViewTextBoxColumn.HeaderText = "Line"
        Me.LineNoDataGridViewTextBoxColumn.Name = "LineNoDataGridViewTextBoxColumn"
        Me.LineNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.LineNoDataGridViewTextBoxColumn.Width = 52
        '
        'bndCustMemos
        '
        Me.bndCustMemos.AllowNew = False
        Me.bndCustMemos.DataMember = "CustomerMemo"
        Me.bndCustMemos.DataSource = Me.SaleForcDataSet
        '
        '_tabCustInfo_TabPage5
        '
        Me._tabCustInfo_TabPage5.Controls.Add(Me.WebBrowser1)
        Me._tabCustInfo_TabPage5.Controls.Add(Me.lblNoWebsite)
        Me._tabCustInfo_TabPage5.Controls.Add(Me.lblAvailWebsites)
        Me._tabCustInfo_TabPage5.Controls.Add(Me.Label66)
        Me._tabCustInfo_TabPage5.Controls.Add(Me.lblWebsiteLoading)
        Me._tabCustInfo_TabPage5.Controls.Add(Me.cmbCustomerWebsites)
        Me._tabCustInfo_TabPage5.Controls.Add(Me.picLoadingWeb)
        Me._tabCustInfo_TabPage5.Controls.Add(Me.ProgressBar1)
        Me._tabCustInfo_TabPage5.Controls.Add(Me.cmdWebBack)
        Me._tabCustInfo_TabPage5.Controls.Add(Me.cmdWebForward)
        Me._tabCustInfo_TabPage5.Controls.Add(Me.cmdWebStop)
        Me._tabCustInfo_TabPage5.Controls.Add(Me.cmdWebRefresh)
        Me._tabCustInfo_TabPage5.Controls.Add(Me.cmdWebOpenBrowser)
        Me._tabCustInfo_TabPage5.Location = New System.Drawing.Point(4, 22)
        Me._tabCustInfo_TabPage5.Name = "_tabCustInfo_TabPage5"
        Me._tabCustInfo_TabPage5.Size = New System.Drawing.Size(783, 486)
        Me._tabCustInfo_TabPage5.TabIndex = 5
        Me._tabCustInfo_TabPage5.Text = "Website"
        Me._tabCustInfo_TabPage5.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(8, 54)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(769, 391)
        Me.WebBrowser1.TabIndex = 205
        '
        'lblNoWebsite
        '
        Me.lblNoWebsite.BackColor = System.Drawing.SystemColors.Control
        Me.lblNoWebsite.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNoWebsite.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoWebsite.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNoWebsite.Location = New System.Drawing.Point(16, 147)
        Me.lblNoWebsite.Name = "lblNoWebsite"
        Me.lblNoWebsite.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNoWebsite.Size = New System.Drawing.Size(753, 49)
        Me.lblNoWebsite.TabIndex = 201
        Me.lblNoWebsite.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblNoWebsite.Visible = False
        '
        'lblAvailWebsites
        '
        Me.lblAvailWebsites.BackColor = System.Drawing.SystemColors.Control
        Me.lblAvailWebsites.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAvailWebsites.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailWebsites.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAvailWebsites.Location = New System.Drawing.Point(179, 34)
        Me.lblAvailWebsites.Name = "lblAvailWebsites"
        Me.lblAvailWebsites.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAvailWebsites.Size = New System.Drawing.Size(134, 17)
        Me.lblAvailWebsites.TabIndex = 202
        Me.lblAvailWebsites.Text = "Customer websites:"
        '
        'Label66
        '
        Me.Label66.BackColor = System.Drawing.SystemColors.Control
        Me.Label66.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label66.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label66.Location = New System.Drawing.Point(8, 460)
        Me.Label66.Name = "Label66"
        Me.Label66.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label66.Size = New System.Drawing.Size(41, 17)
        Me.Label66.TabIndex = 207
        '
        'lblWebsiteLoading
        '
        Me.lblWebsiteLoading.BackColor = System.Drawing.SystemColors.Control
        Me.lblWebsiteLoading.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblWebsiteLoading.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWebsiteLoading.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblWebsiteLoading.Location = New System.Drawing.Point(320, 460)
        Me.lblWebsiteLoading.Name = "lblWebsiteLoading"
        Me.lblWebsiteLoading.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblWebsiteLoading.Size = New System.Drawing.Size(289, 17)
        Me.lblWebsiteLoading.TabIndex = 208
        '
        'cmbCustomerWebsites
        '
        Me.cmbCustomerWebsites.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCustomerWebsites.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbCustomerWebsites.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCustomerWebsites.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCustomerWebsites.Location = New System.Drawing.Point(323, 29)
        Me.cmbCustomerWebsites.Name = "cmbCustomerWebsites"
        Me.cmbCustomerWebsites.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCustomerWebsites.Size = New System.Drawing.Size(329, 22)
        Me.cmbCustomerWebsites.TabIndex = 203
        '
        'picLoadingWeb
        '
        Me.picLoadingWeb.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.picLoadingWeb.Cursor = System.Windows.Forms.Cursors.Default
        Me.picLoadingWeb.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picLoadingWeb.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picLoadingWeb.Location = New System.Drawing.Point(8, 64)
        Me.picLoadingWeb.Name = "picLoadingWeb"
        Me.picLoadingWeb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picLoadingWeb.Size = New System.Drawing.Size(761, 383)
        Me.picLoadingWeb.TabIndex = 204
        Me.picLoadingWeb.TabStop = False
        Me.picLoadingWeb.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(56, 460)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(257, 17)
        Me.ProgressBar1.TabIndex = 206
        '
        '_tabCustInfo_TabPage6
        '
        Me._tabCustInfo_TabPage6.Controls.Add(Me.lblNoAppts)
        Me._tabCustInfo_TabPage6.Controls.Add(Me.dgvCustomerAppointments)
        Me._tabCustInfo_TabPage6.Controls.Add(Me.cmdNewAppointment)
        Me._tabCustInfo_TabPage6.Controls.Add(Me.cmdOpenAppointment)
        Me._tabCustInfo_TabPage6.Controls.Add(Me.cmdDeleteAppointment)
        Me._tabCustInfo_TabPage6.Location = New System.Drawing.Point(4, 22)
        Me._tabCustInfo_TabPage6.Name = "_tabCustInfo_TabPage6"
        Me._tabCustInfo_TabPage6.Size = New System.Drawing.Size(783, 486)
        Me._tabCustInfo_TabPage6.TabIndex = 6
        Me._tabCustInfo_TabPage6.Text = "Appointments"
        Me._tabCustInfo_TabPage6.UseVisualStyleBackColor = True
        '
        'lblNoAppts
        '
        Me.lblNoAppts.AutoSize = True
        Me.lblNoAppts.Location = New System.Drawing.Point(8, 57)
        Me.lblNoAppts.Name = "lblNoAppts"
        Me.lblNoAppts.Size = New System.Drawing.Size(0, 16)
        Me.lblNoAppts.TabIndex = 222
        Me.lblNoAppts.UseMnemonic = False
        '
        'dgvCustomerAppointments
        '
        Me.dgvCustomerAppointments.AllowUserToAddRows = False
        Me.dgvCustomerAppointments.AllowUserToDeleteRows = False
        Me.dgvCustomerAppointments.AllowUserToResizeColumns = False
        Me.dgvCustomerAppointments.AllowUserToResizeRows = False
        Me.dgvCustomerAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCustomerAppointments.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvCustomerAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCustomerAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomerAppointments.Location = New System.Drawing.Point(8, 57)
        Me.dgvCustomerAppointments.MultiSelect = False
        Me.dgvCustomerAppointments.Name = "dgvCustomerAppointments"
        Me.dgvCustomerAppointments.RowHeadersVisible = False
        Me.dgvCustomerAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCustomerAppointments.Size = New System.Drawing.Size(777, 326)
        Me.dgvCustomerAppointments.TabIndex = 221
        Me.dgvCustomerAppointments.VirtualMode = True
        '
        'cmdNewAppointment
        '
        Me.cmdNewAppointment.BackColor = System.Drawing.SystemColors.Control
        Me.cmdNewAppointment.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdNewAppointment.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNewAppointment.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdNewAppointment.Location = New System.Drawing.Point(19, 16)
        Me.cmdNewAppointment.Name = "cmdNewAppointment"
        Me.cmdNewAppointment.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdNewAppointment.Size = New System.Drawing.Size(49, 25)
        Me.cmdNewAppointment.TabIndex = 214
        Me.cmdNewAppointment.Text = "&New"
        Me.cmdNewAppointment.UseVisualStyleBackColor = False
        '
        'cmdOpenAppointment
        '
        Me.cmdOpenAppointment.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOpenAppointment.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOpenAppointment.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpenAppointment.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOpenAppointment.Location = New System.Drawing.Point(75, 16)
        Me.cmdOpenAppointment.Name = "cmdOpenAppointment"
        Me.cmdOpenAppointment.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOpenAppointment.Size = New System.Drawing.Size(49, 25)
        Me.cmdOpenAppointment.TabIndex = 215
        Me.cmdOpenAppointment.Text = "&Open"
        Me.cmdOpenAppointment.UseVisualStyleBackColor = False
        '
        'cmdDeleteAppointment
        '
        Me.cmdDeleteAppointment.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDeleteAppointment.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDeleteAppointment.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDeleteAppointment.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDeleteAppointment.Location = New System.Drawing.Point(131, 16)
        Me.cmdDeleteAppointment.Name = "cmdDeleteAppointment"
        Me.cmdDeleteAppointment.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDeleteAppointment.Size = New System.Drawing.Size(49, 25)
        Me.cmdDeleteAppointment.TabIndex = 218
        Me.cmdDeleteAppointment.Text = "&Delete"
        Me.cmdDeleteAppointment.UseVisualStyleBackColor = False
        '
        '_tabCustInfo_TabPage7
        '
        Me._tabCustInfo_TabPage7.Controls.Add(Me.pnlNotes)
        Me._tabCustInfo_TabPage7.Controls.Add(Me.pnlASR)
        Me._tabCustInfo_TabPage7.Controls.Add(Me.pnlHistory)
        Me._tabCustInfo_TabPage7.Controls.Add(Me.pnlPass)
        Me._tabCustInfo_TabPage7.Controls.Add(Me.pnlHistoryGraphs)
        Me._tabCustInfo_TabPage7.Controls.Add(Me.Label68)
        Me._tabCustInfo_TabPage7.Controls.Add(Me.cmbASRView)
        Me._tabCustInfo_TabPage7.Controls.Add(Me.optSpring)
        Me._tabCustInfo_TabPage7.Controls.Add(Me.optFall)
        Me._tabCustInfo_TabPage7.Controls.Add(Me.cmdPrintGraphs)
        Me._tabCustInfo_TabPage7.Location = New System.Drawing.Point(4, 22)
        Me._tabCustInfo_TabPage7.Name = "_tabCustInfo_TabPage7"
        Me._tabCustInfo_TabPage7.Size = New System.Drawing.Size(783, 486)
        Me._tabCustInfo_TabPage7.TabIndex = 7
        Me._tabCustInfo_TabPage7.Text = "ASR"
        Me._tabCustInfo_TabPage7.UseVisualStyleBackColor = True
        '
        'pnlNotes
        '
        Me.pnlNotes.Controls.Add(Me.dtpNotesFollowup)
        Me.pnlNotes.Controls.Add(Me.txtNoteGenComments)
        Me.pnlNotes.Controls.Add(Me.cmdEmailNotes)
        Me.pnlNotes.Controls.Add(Me.Label2)
        Me.pnlNotes.Controls.Add(Me.label1)
        Me.pnlNotes.Controls.Add(Me.dgvNotes)
        Me.pnlNotes.Location = New System.Drawing.Point(10, 55)
        Me.pnlNotes.Name = "pnlNotes"
        Me.pnlNotes.Size = New System.Drawing.Size(778, 385)
        Me.pnlNotes.TabIndex = 246
        '
        'dtpNotesFollowup
        '
        Me.dtpNotesFollowup.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNotesFollowup.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNotesFollowup.Location = New System.Drawing.Point(545, 354)
        Me.dtpNotesFollowup.Name = "dtpNotesFollowup"
        Me.dtpNotesFollowup.Size = New System.Drawing.Size(122, 22)
        Me.dtpNotesFollowup.TabIndex = 253
        '
        'txtNoteGenComments
        '
        Me.txtNoteGenComments.AcceptsReturn = True
        Me.txtNoteGenComments.BackColor = System.Drawing.SystemColors.Window
        Me.txtNoteGenComments.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNoteGenComments.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoteGenComments.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNoteGenComments.Location = New System.Drawing.Point(65, 356)
        Me.txtNoteGenComments.MaxLength = 0
        Me.txtNoteGenComments.Name = "txtNoteGenComments"
        Me.txtNoteGenComments.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNoteGenComments.Size = New System.Drawing.Size(367, 20)
        Me.txtNoteGenComments.TabIndex = 251
        '
        'cmdEmailNotes
        '
        Me.cmdEmailNotes.BackColor = System.Drawing.SystemColors.Control
        Me.cmdEmailNotes.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEmailNotes.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEmailNotes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEmailNotes.Location = New System.Drawing.Point(705, 351)
        Me.cmdEmailNotes.Name = "cmdEmailNotes"
        Me.cmdEmailNotes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdEmailNotes.Size = New System.Drawing.Size(65, 25)
        Me.cmdEmailNotes.TabIndex = 249
        Me.cmdEmailNotes.Text = "&Send"
        Me.cmdEmailNotes.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(0, 353)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(80, 32)
        Me.Label2.TabIndex = 252
        Me.Label2.Text = "General Comments:"
        '
        'label1
        '
        Me.label1.BackColor = System.Drawing.SystemColors.Control
        Me.label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.label1.Location = New System.Drawing.Point(464, 351)
        Me.label1.Name = "label1"
        Me.label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label1.Size = New System.Drawing.Size(103, 31)
        Me.label1.TabIndex = 250
        Me.label1.Text = "Follow Up Date (required):"
        '
        'dgvNotes
        '
        Me.dgvNotes.AllowUserToAddRows = False
        Me.dgvNotes.AllowUserToDeleteRows = False
        Me.dgvNotes.AllowUserToResizeColumns = False
        Me.dgvNotes.AllowUserToResizeRows = False
        Me.dgvNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNotes.Location = New System.Drawing.Point(0, 0)
        Me.dgvNotes.Name = "dgvNotes"
        Me.dgvNotes.RowHeadersVisible = False
        Me.dgvNotes.Size = New System.Drawing.Size(770, 345)
        Me.dgvNotes.TabIndex = 247
        '
        'pnlASR
        '
        Me.pnlASR.BackColor = System.Drawing.SystemColors.Control
        Me.pnlASR.Controls.Add(Me.cmdEmailASR)
        Me.pnlASR.Controls.Add(Me.dgvASR)
        Me.pnlASR.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlASR.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlASR.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlASR.Location = New System.Drawing.Point(10, 55)
        Me.pnlASR.Name = "pnlASR"
        Me.pnlASR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pnlASR.Size = New System.Drawing.Size(778, 385)
        Me.pnlASR.TabIndex = 244
        '
        'cmdEmailASR
        '
        Me.cmdEmailASR.BackColor = System.Drawing.SystemColors.Control
        Me.cmdEmailASR.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEmailASR.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEmailASR.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEmailASR.Location = New System.Drawing.Point(705, 351)
        Me.cmdEmailASR.Name = "cmdEmailASR"
        Me.cmdEmailASR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdEmailASR.Size = New System.Drawing.Size(65, 25)
        Me.cmdEmailASR.TabIndex = 226
        Me.cmdEmailASR.Text = "&Send"
        Me.cmdEmailASR.UseVisualStyleBackColor = False
        '
        'dgvASR
        '
        Me.dgvASR.AllowUserToAddRows = False
        Me.dgvASR.AllowUserToResizeColumns = False
        Me.dgvASR.AllowUserToResizeRows = False
        Me.dgvASR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvASR.Location = New System.Drawing.Point(0, 0)
        Me.dgvASR.Name = "dgvASR"
        Me.dgvASR.RowHeadersVisible = False
        Me.dgvASR.Size = New System.Drawing.Size(770, 345)
        Me.dgvASR.TabIndex = 227
        '
        'pnlHistory
        '
        Me.pnlHistory.BackColor = System.Drawing.SystemColors.Control
        Me.pnlHistory.Controls.Add(Me.cmdPrintHistory)
        Me.pnlHistory.Controls.Add(Me.txtHistoryComments)
        Me.pnlHistory.Controls.Add(Me.dgvHistory)
        Me.pnlHistory.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlHistory.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlHistory.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlHistory.Location = New System.Drawing.Point(10, 55)
        Me.pnlHistory.Name = "pnlHistory"
        Me.pnlHistory.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pnlHistory.Size = New System.Drawing.Size(778, 385)
        Me.pnlHistory.TabIndex = 245
        '
        'cmdPrintHistory
        '
        Me.cmdPrintHistory.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrintHistory.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrintHistory.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrintHistory.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrintHistory.Location = New System.Drawing.Point(705, 352)
        Me.cmdPrintHistory.Name = "cmdPrintHistory"
        Me.cmdPrintHistory.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrintHistory.Size = New System.Drawing.Size(65, 25)
        Me.cmdPrintHistory.TabIndex = 247
        Me.cmdPrintHistory.Text = "&Print"
        Me.cmdPrintHistory.UseVisualStyleBackColor = False
        '
        'txtHistoryComments
        '
        Me.txtHistoryComments.AcceptsReturn = True
        Me.txtHistoryComments.BackColor = System.Drawing.SystemColors.Control
        Me.txtHistoryComments.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHistoryComments.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHistoryComments.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHistoryComments.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHistoryComments.Location = New System.Drawing.Point(680, 392)
        Me.txtHistoryComments.MaxLength = 0
        Me.txtHistoryComments.Multiline = True
        Me.txtHistoryComments.Name = "txtHistoryComments"
        Me.txtHistoryComments.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHistoryComments.Size = New System.Drawing.Size(7, 15)
        Me.txtHistoryComments.TabIndex = 235
        Me.txtHistoryComments.TabStop = False
        Me.txtHistoryComments.Visible = False
        '
        'dgvHistory
        '
        Me.dgvHistory.AllowUserToResizeColumns = False
        Me.dgvHistory.AllowUserToResizeRows = False
        Me.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistory.Location = New System.Drawing.Point(0, 0)
        Me.dgvHistory.MultiSelect = False
        Me.dgvHistory.Name = "dgvHistory"
        Me.dgvHistory.RowHeadersVisible = False
        Me.dgvHistory.Size = New System.Drawing.Size(770, 345)
        Me.dgvHistory.TabIndex = 236
        '
        'pnlPass
        '
        Me.pnlPass.Controls.Add(Me.cmdEmailPass)
        Me.pnlPass.Controls.Add(Me.dgvPass)
        Me.pnlPass.Location = New System.Drawing.Point(10, 55)
        Me.pnlPass.Name = "pnlPass"
        Me.pnlPass.Size = New System.Drawing.Size(778, 385)
        Me.pnlPass.TabIndex = 243
        '
        'cmdEmailPass
        '
        Me.cmdEmailPass.BackColor = System.Drawing.SystemColors.Control
        Me.cmdEmailPass.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEmailPass.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEmailPass.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEmailPass.Location = New System.Drawing.Point(705, 352)
        Me.cmdEmailPass.Name = "cmdEmailPass"
        Me.cmdEmailPass.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdEmailPass.Size = New System.Drawing.Size(65, 25)
        Me.cmdEmailPass.TabIndex = 235
        Me.cmdEmailPass.Text = "&Send"
        Me.cmdEmailPass.UseVisualStyleBackColor = False
        '
        'dgvPass
        '
        Me.dgvPass.AllowUserToAddRows = False
        Me.dgvPass.AllowUserToDeleteRows = False
        Me.dgvPass.AllowUserToResizeColumns = False
        Me.dgvPass.AllowUserToResizeRows = False
        Me.dgvPass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPass.Location = New System.Drawing.Point(0, 0)
        Me.dgvPass.Name = "dgvPass"
        Me.dgvPass.RowHeadersVisible = False
        Me.dgvPass.Size = New System.Drawing.Size(770, 345)
        Me.dgvPass.TabIndex = 234
        '
        'pnlHistoryGraphs
        '
        Me.pnlHistoryGraphs.AutoScroll = True
        Me.pnlHistoryGraphs.Location = New System.Drawing.Point(10, 55)
        Me.pnlHistoryGraphs.Name = "pnlHistoryGraphs"
        Me.pnlHistoryGraphs.Size = New System.Drawing.Size(778, 385)
        Me.pnlHistoryGraphs.TabIndex = 241
        '
        'Label68
        '
        Me.Label68.BackColor = System.Drawing.SystemColors.Control
        Me.Label68.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label68.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label68.Location = New System.Drawing.Point(608, 18)
        Me.Label68.Name = "Label68"
        Me.Label68.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label68.Size = New System.Drawing.Size(33, 17)
        Me.Label68.TabIndex = 220
        Me.Label68.Text = "View:"
        '
        'cmbASRView
        '
        Me.cmbASRView.BackColor = System.Drawing.SystemColors.Window
        Me.cmbASRView.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbASRView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbASRView.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbASRView.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbASRView.Items.AddRange(New Object() {"ASR Report", "Notes", "Pass", "History", "History Graph"})
        Me.cmbASRView.Location = New System.Drawing.Point(641, 14)
        Me.cmbASRView.Name = "cmbASRView"
        Me.cmbASRView.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbASRView.Size = New System.Drawing.Size(137, 22)
        Me.cmbASRView.TabIndex = 219
        '
        'optSpring
        '
        Me.optSpring.BackColor = System.Drawing.SystemColors.Control
        Me.optSpring.Cursor = System.Windows.Forms.Cursors.Default
        Me.optSpring.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSpring.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optSpring.Location = New System.Drawing.Point(545, 17)
        Me.optSpring.Name = "optSpring"
        Me.optSpring.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optSpring.Size = New System.Drawing.Size(57, 17)
        Me.optSpring.TabIndex = 238
        Me.optSpring.TabStop = True
        Me.optSpring.Text = "Spring"
        Me.optSpring.UseVisualStyleBackColor = False
        Me.optSpring.Visible = False
        '
        'optFall
        '
        Me.optFall.BackColor = System.Drawing.SystemColors.Control
        Me.optFall.Cursor = System.Windows.Forms.Cursors.Default
        Me.optFall.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optFall.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optFall.Location = New System.Drawing.Point(497, 17)
        Me.optFall.Name = "optFall"
        Me.optFall.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optFall.Size = New System.Drawing.Size(41, 17)
        Me.optFall.TabIndex = 239
        Me.optFall.TabStop = True
        Me.optFall.Text = "Fall"
        Me.optFall.UseVisualStyleBackColor = False
        Me.optFall.Visible = False
        '
        'cmdPrintGraphs
        '
        Me.cmdPrintGraphs.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrintGraphs.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrintGraphs.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrintGraphs.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrintGraphs.Location = New System.Drawing.Point(401, 14)
        Me.cmdPrintGraphs.Name = "cmdPrintGraphs"
        Me.cmdPrintGraphs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrintGraphs.Size = New System.Drawing.Size(65, 25)
        Me.cmdPrintGraphs.TabIndex = 240
        Me.cmdPrintGraphs.Text = "&Print"
        Me.cmdPrintGraphs.UseVisualStyleBackColor = False
        Me.cmdPrintGraphs.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'cmdNewCustEdit
        '
        Me.cmdNewCustEdit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdNewCustEdit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdNewCustEdit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNewCustEdit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdNewCustEdit.Location = New System.Drawing.Point(8, 48)
        Me.cmdNewCustEdit.Name = "cmdNewCustEdit"
        Me.cmdNewCustEdit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdNewCustEdit.Size = New System.Drawing.Size(97, 25)
        Me.cmdNewCustEdit.TabIndex = 9
        Me.cmdNewCustEdit.Text = "&Edit"
        Me.cmdNewCustEdit.UseVisualStyleBackColor = False
        Me.cmdNewCustEdit.Visible = False
        '
        'fraExitBtn
        '
        Me.fraExitBtn.BackColor = System.Drawing.SystemColors.Control
        Me.fraExitBtn.Controls.Add(Me.cmdNewWs)
        Me.fraExitBtn.Controls.Add(Me.cmdNewCustEdit)
        Me.fraExitBtn.Controls.Add(Me.cmdNewCust)
        Me.fraExitBtn.Controls.Add(Me.btnExitCustInfo)
        Me.fraExitBtn.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraExitBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraExitBtn.Location = New System.Drawing.Point(0, 0)
        Me.fraExitBtn.Name = "fraExitBtn"
        Me.fraExitBtn.Padding = New System.Windows.Forms.Padding(0)
        Me.fraExitBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraExitBtn.Size = New System.Drawing.Size(265, 81)
        Me.fraExitBtn.TabIndex = 18
        Me.fraExitBtn.TabStop = False
        '
        'grbNavigation
        '
        Me.grbNavigation.BackColor = System.Drawing.SystemColors.Control
        Me.grbNavigation.Controls.Add(Me.lblCustomerName)
        Me.grbNavigation.Controls.Add(Me.cmdLast)
        Me.grbNavigation.Controls.Add(Me.cmdPrevious)
        Me.grbNavigation.Controls.Add(Me.cmdNext)
        Me.grbNavigation.Controls.Add(Me.cmdFirst)
        Me.grbNavigation.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbNavigation.ForeColor = System.Drawing.Color.Blue
        Me.grbNavigation.Location = New System.Drawing.Point(263, 34)
        Me.grbNavigation.Name = "grbNavigation"
        Me.grbNavigation.Size = New System.Drawing.Size(528, 46)
        Me.grbNavigation.TabIndex = 59
        Me.grbNavigation.TabStop = False
        Me.grbNavigation.Text = "Customer Navigation"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bndCustomer, "Name", True))
        Me.lblCustomerName.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.ForeColor = System.Drawing.Color.Blue
        Me.lblCustomerName.Location = New System.Drawing.Point(275, 19)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(119, 16)
        Me.lblCustomerName.TabIndex = 73
        Me.lblCustomerName.Text = "Customer Name"
        Me.lblCustomerName.UseMnemonic = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Order-no"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Order No."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ToolTipText = "Customer's order number"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Order-date"
        DataGridViewCellStyle10.Format = "d"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn2.HeaderText = "Order Date"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ToolTipText = "Date the worksheet was made an order"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Complete-date"
        DataGridViewCellStyle11.Format = "d"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn3.HeaderText = "Complete By Date"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ToolTipText = "Date that the order must be complete by"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Qty-shipped"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Qty Shpd"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ToolTipText = "Number of items shipped as of the last update date"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Qty-open-order"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Qty-open-order"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ToolTipText = "Number of items that remain to be shipped as of the last update date"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "OpenValue"
        DataGridViewCellStyle12.Format = "C2"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn6.HeaderText = "Open Value"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ToolTipText = "Dollar amount of the items that have not been shipped yet"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "WorksheetID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Worksheet Number"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ToolTipText = "Worksheet number associated with the order"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Invoice-no"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Invoice Number"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ToolTipText = "The invoice number associated with this order"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "LastUpDate"
        DataGridViewCellStyle13.Format = "d"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn9.HeaderText = "Last Update"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ToolTipText = "The last date that any activity was performed on this order"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Cust-po"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Customer PO#"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ToolTipText = "Customer's purchase order number"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Qty-orig-ord"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Qty Orig Ordered"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ToolTipText = "Number of items originally placed on order"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Season"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Season"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ToolTipText = "Season the item was ordered for"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "worksheet-id"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Worksheet No"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ToolTipText = "Worksheet Number "
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "ws-create-date"
        DataGridViewCellStyle14.Format = "d"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn14.HeaderText = "Date Created"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ToolTipText = "Date the worksheet was created"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "transmittal-status"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Xmit Status"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ToolTipText = "The date the worksheet was transmitted"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "transmittal-date"
        DataGridViewCellStyle15.Format = "d"
        DataGridViewCellStyle15.NullValue = Nothing
        Me.DataGridViewTextBoxColumn16.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn16.HeaderText = "Xmit Date"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ToolTipText = "Day the worksheet was last transmitted to Knitcraft"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "validation-status"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Validation Status"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ToolTipText = "Status assigned to the worksheet after going through the validation procedure"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "validation-date"
        DataGridViewCellStyle16.Format = "d"
        DataGridViewCellStyle16.NullValue = Nothing
        Me.DataGridViewTextBoxColumn18.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn18.HeaderText = "Validation Date"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ToolTipText = "Date the worksheet when through the validation procedure"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "order-no"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Order No"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ToolTipText = "The order number assigned after being converted to an order"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "order-date"
        DataGridViewCellStyle17.Format = "d"
        DataGridViewCellStyle17.NullValue = Nothing
        Me.DataGridViewTextBoxColumn20.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridViewTextBoxColumn20.HeaderText = "Order Date"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ToolTipText = "Date the worksheet was converted to an order"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "error-level"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Error Level"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ToolTipText = "If the worksheet contains errors, this number represents the priority number of t" &
    "he error"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "season"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Season"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ToolTipText = "The season the worksheet was created for"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "MemoLine"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Memo"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "PageNo"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Page"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "LineNo"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Line"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'CustomerSHTableAdapter
        '
        Me.CustomerSHTableAdapter.ClearBeforeFill = True
        '
        'OrderTableAdapter
        '
        Me.OrderTableAdapter.ClearBeforeFill = True
        '
        'Ws_ord_headTableAdapter
        '
        Me.Ws_ord_headTableAdapter.ClearBeforeFill = True
        '
        'CustomerMemoTableAdapter
        '
        Me.CustomerMemoTableAdapter.ClearBeforeFill = True
        '
        'bndCustAutoComplete
        '
        Me.bndCustAutoComplete.AllowNew = False
        Me.bndCustAutoComplete.DataMember = "Customer"
        Me.bndCustAutoComplete.DataSource = Me.SaleForcDataSet
        '
        'NotesCommentsTableAdapter
        '
        Me.NotesCommentsTableAdapter.ClearBeforeFill = True
        '
        'frmCustInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(793, 544)
        Me.ControlBox = False
        Me.Controls.Add(Me.grbNavigation)
        Me.Controls.Add(Me.fraSortOrder)
        Me.Controls.Add(Me.fraExitBtn)
        Me.Controls.Add(Me.tabCustInfo)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Location = New System.Drawing.Point(4, 27)
        Me.Name = "frmCustInfo"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Information"
        Me.fraSortOrder.ResumeLayout(False)
        Me.fraSortOrder.PerformLayout()
        Me.tabCustInfo.ResumeLayout(False)
        Me._tabCustInfo_TabPage0.ResumeLayout(False)
        Me.fraStatus.ResumeLayout(False)
        Me.fraStatus.PerformLayout()
        CType(Me.bndCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleForcDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndCustomerShip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraFileCust.ResumeLayout(False)
        Me.fraFileCust.PerformLayout()
        Me.Frame4.ResumeLayout(False)
        Me.Frame5.ResumeLayout(False)
        Me.Frame3.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.fraNewCust.ResumeLayout(False)
        Me.fraNewCust.PerformLayout()
        Me.fraCustContactInfo.ResumeLayout(False)
        Me.fraCustContactInfo.PerformLayout()
        Me.fraShipContact.ResumeLayout(False)
        Me.fraShipContact.PerformLayout()
        Me.fraCustAddr.ResumeLayout(False)
        Me.fraCustAddr.PerformLayout()
        Me.fraShipAddr.ResumeLayout(False)
        Me.fraShipAddr.PerformLayout()
        Me._tabCustInfo_TabPage1.ResumeLayout(False)
        Me.fraOrderList.ResumeLayout(False)
        Me.fraOrderList.PerformLayout()
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me._tabCustInfo_TabPage2.ResumeLayout(False)
        Me.fraWsList.ResumeLayout(False)
        Me.fraWsList.PerformLayout()
        CType(Me.dgvWorksheets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndWorksheets, System.ComponentModel.ISupportInitialize).EndInit()
        Me._tabCustInfo_TabPage3.ResumeLayout(False)
        Me.fraSalesmanRef.ResumeLayout(False)
        Me.fraSalesmanRef.PerformLayout()
        Me.fraCustRef.ResumeLayout(False)
        Me.fraCustRef.PerformLayout()
        Me.fraShipOther.ResumeLayout(False)
        Me.fraShipOther.PerformLayout()
        Me.fraDates.ResumeLayout(False)
        Me.fraDates.PerformLayout()
        Me._tabCustInfo_TabPage4.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        CType(Me.dgvCustomerMemos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndCustMemos, System.ComponentModel.ISupportInitialize).EndInit()
        Me._tabCustInfo_TabPage5.ResumeLayout(False)
        CType(Me.picLoadingWeb, System.ComponentModel.ISupportInitialize).EndInit()
        Me._tabCustInfo_TabPage6.ResumeLayout(False)
        Me._tabCustInfo_TabPage6.PerformLayout()
        CType(Me.dgvCustomerAppointments, System.ComponentModel.ISupportInitialize).EndInit()
        Me._tabCustInfo_TabPage7.ResumeLayout(False)
        Me.pnlNotes.ResumeLayout(False)
        Me.pnlNotes.PerformLayout()
        CType(Me.dgvNotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlASR.ResumeLayout(False)
        CType(Me.dgvASR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHistory.ResumeLayout(False)
        Me.pnlHistory.PerformLayout()
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPass.ResumeLayout(False)
        CType(Me.dgvPass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraExitBtn.ResumeLayout(False)
        Me.grbNavigation.ResumeLayout(False)
        Me.grbNavigation.PerformLayout()
        CType(Me.bndCustAutoComplete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
#Region "Upgrade Support"
    Friend WithEvents SaleForcDataSet As KC01.SaleForcDataSet
    Friend WithEvents CustomerTableAdapter As KC01.SaleForcDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents bndCustomerShip As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerSHTableAdapter As KC01.SaleForcDataSetTableAdapters.CustomerSHTableAdapter
    Friend WithEvents bndOrders As System.Windows.Forms.BindingSource
    Friend WithEvents OrderTableAdapter As KC01.SaleForcDataSetTableAdapters.OrderTableAdapter
    Friend WithEvents dgvOrders As System.Windows.Forms.DataGridView
    Friend WithEvents bndWorksheets As System.Windows.Forms.BindingSource
    Friend WithEvents Ws_ord_headTableAdapter As KC01.SaleForcDataSetTableAdapters.ws_ord_headTableAdapter
    Friend WithEvents dgvWorksheets As System.Windows.Forms.DataGridView
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvCustomerMemos As System.Windows.Forms.DataGridView
    Friend WithEvents bndCustMemos As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerMemoTableAdapter As KC01.SaleForcDataSetTableAdapters.CustomerMemoTableAdapter
    Public WithEvents btnExitCustInfo As System.Windows.Forms.Button
    Public WithEvents cmdNewCust As System.Windows.Forms.Button
    Public WithEvents cmdNewCustEdit As System.Windows.Forms.Button
    Public WithEvents cmdNewWs As System.Windows.Forms.Button
    Public WithEvents fraExitBtn As System.Windows.Forms.GroupBox
    Public WithEvents picLoadingWeb As System.Windows.Forms.PictureBox
    Friend WithEvents bndCustAutoComplete As System.Windows.Forms.BindingSource
    Friend WithEvents bndCustomer As System.Windows.Forms.BindingSource
    Friend WithEvents MemoLineDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PageNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LineNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Public WithEvents fraNewCust As System.Windows.Forms.GroupBox
    Public WithEvents cmdNewCustFinished As System.Windows.Forms.Button
    Public WithEvents fraCustContactInfo As System.Windows.Forms.GroupBox
    Public WithEvents mebPhoneNo As System.Windows.Forms.MaskedTextBox
    Public WithEvents mebFaxNo As System.Windows.Forms.MaskedTextBox
    Public WithEvents mebContact As System.Windows.Forms.MaskedTextBox
    Public WithEvents mebCustContactEmail As System.Windows.Forms.MaskedTextBox
    Public WithEvents _lblCustInfo_55 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_52 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_53 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_54 As System.Windows.Forms.Label
    Public WithEvents fraShipContact As System.Windows.Forms.GroupBox
    Public WithEvents mebShipContact As System.Windows.Forms.MaskedTextBox
    Public WithEvents mebShipFax As System.Windows.Forms.MaskedTextBox
    Public WithEvents mebShipPhone As System.Windows.Forms.MaskedTextBox
    Public WithEvents mebCustShContactEmail As System.Windows.Forms.MaskedTextBox
    Public WithEvents _lblCustInfo_58 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_59 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_56 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_57 As System.Windows.Forms.Label
    Public WithEvents fraCustAddr As System.Windows.Forms.GroupBox
    Public WithEvents mebAddr1 As System.Windows.Forms.MaskedTextBox
    Public WithEvents mebCity As System.Windows.Forms.MaskedTextBox
    Public WithEvents mebName As System.Windows.Forms.MaskedTextBox
    Public WithEvents mebAddr2 As System.Windows.Forms.MaskedTextBox
    Public WithEvents mebAddr3 As System.Windows.Forms.MaskedTextBox
    Public WithEvents mebState As System.Windows.Forms.MaskedTextBox
    Public WithEvents mebZipCode As System.Windows.Forms.MaskedTextBox
    Public WithEvents mebCustEmail As System.Windows.Forms.MaskedTextBox
    Public WithEvents fraShipAddr As System.Windows.Forms.GroupBox
    Public WithEvents mebCustShEmail As System.Windows.Forms.MaskedTextBox
    Public WithEvents mebWebsite As System.Windows.Forms.MaskedTextBox
    Public WithEvents mebShipZipCode As System.Windows.Forms.MaskedTextBox
    Public WithEvents mebShipSt As System.Windows.Forms.MaskedTextBox
    Public WithEvents mebShipCity As System.Windows.Forms.MaskedTextBox
    Public WithEvents mebShipAddr3 As System.Windows.Forms.MaskedTextBox
    Public WithEvents mebShipAddr2 As System.Windows.Forms.MaskedTextBox
    Public WithEvents mebShipAddr1 As System.Windows.Forms.MaskedTextBox
    Public WithEvents mebShipName As System.Windows.Forms.MaskedTextBox
    Public WithEvents _lblCustInfo_51 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_50 As System.Windows.Forms.Label
    Public WithEvents Label61 As System.Windows.Forms.Label
    Public WithEvents lblTempShipNo As System.Windows.Forms.Label
    Public WithEvents Label59 As System.Windows.Forms.Label
    Public WithEvents lblTempCustNo As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_45 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_47 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_46 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_49 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_48 As System.Windows.Forms.Label
    Public WithEvents fraFileCust As System.Windows.Forms.GroupBox
    Friend WithEvents dblShipNoList As System.Windows.Forms.ListBox
    Public WithEvents txtCustNo As System.Windows.Forms.TextBox
    Public WithEvents txtSelectedShip As System.Windows.Forms.TextBox
    Public WithEvents cmdCustShipUpdate As System.Windows.Forms.Button
    Public WithEvents chkViewActiveCust As System.Windows.Forms.CheckBox
    Public WithEvents Frame4 As System.Windows.Forms.GroupBox
    Public WithEvents _lblCustInfo_19 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_17 As System.Windows.Forms.Label
    Public WithEvents Label48 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_18 As System.Windows.Forms.Label
    Public WithEvents lblPhoneNo As System.Windows.Forms.Label
    Public WithEvents lblContact As System.Windows.Forms.Label
    Public WithEvents lblFaxNo As System.Windows.Forms.Label
    Public WithEvents cmdCustomerUpdate As System.Windows.Forms.Button
    Public WithEvents Frame5 As System.Windows.Forms.GroupBox
    Public WithEvents lblCustShipVia As System.Windows.Forms.Label
    Public WithEvents lblCountry As System.Windows.Forms.Label
    Public WithEvents lblZipCode As System.Windows.Forms.Label
    Public WithEvents lblState As System.Windows.Forms.Label
    Public WithEvents lblCity As System.Windows.Forms.Label
    Public WithEvents lblAddr1 As System.Windows.Forms.Label
    Public WithEvents lblAddr2 As System.Windows.Forms.Label
    Public WithEvents lblAddr3 As System.Windows.Forms.Label
    Public WithEvents lblCustShipViaDesc As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_11 As System.Windows.Forms.Label
    Public WithEvents lblName As System.Windows.Forms.Label
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents lblShipName As System.Windows.Forms.Label
    Public WithEvents lblShipViaCd As System.Windows.Forms.Label
    Public WithEvents lblShipCountry As System.Windows.Forms.Label
    Public WithEvents lblShipZipcode As System.Windows.Forms.Label
    Public WithEvents lblShipSt As System.Windows.Forms.Label
    Public WithEvents lblShipCity As System.Windows.Forms.Label
    Public WithEvents lblShipAddr1 As System.Windows.Forms.Label
    Public WithEvents lblShipAddr2 As System.Windows.Forms.Label
    Public WithEvents lblShipAddr3 As System.Windows.Forms.Label
    Public WithEvents lblShipViaDesc As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_12 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_10 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_3 As System.Windows.Forms.Label
    Public WithEvents lblDblCnt As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_2 As System.Windows.Forms.Label
    Public WithEvents lblDefaultShip As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_0 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_1 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_4 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_6 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_5 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_8 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_7 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_9 As System.Windows.Forms.Label
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents _lblCustInfo_16 As System.Windows.Forms.Label
    Public WithEvents lblShipFax As System.Windows.Forms.Label
    Public WithEvents lblShipContact As System.Windows.Forms.Label
    Public WithEvents lblShipPhone As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_15 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_14 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_13 As System.Windows.Forms.Label
    Friend WithEvents pnlHistoryGraphs As System.Windows.Forms.Panel
    Friend WithEvents pnlPass As System.Windows.Forms.Panel
    Friend WithEvents dgvPass As System.Windows.Forms.DataGridView
    Public WithEvents pnlASR As System.Windows.Forms.Panel
    Friend WithEvents dgvASR As System.Windows.Forms.DataGridView
    Public WithEvents cmdEmailASR As System.Windows.Forms.Button
    Public WithEvents pnlHistory As System.Windows.Forms.Panel
    Friend WithEvents dgvHistory As System.Windows.Forms.DataGridView
    Public WithEvents txtHistoryComments As System.Windows.Forms.TextBox
    Friend WithEvents pnlNotes As System.Windows.Forms.Panel
    Friend WithEvents dtpNotesFollowup As System.Windows.Forms.DateTimePicker
    Public WithEvents txtNoteGenComments As System.Windows.Forms.TextBox
    Public WithEvents cmdEmailNotes As System.Windows.Forms.Button
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents dgvNotes As System.Windows.Forms.DataGridView
    Public WithEvents fraSortOrder As System.Windows.Forms.GroupBox
    Public WithEvents txtCustID As System.Windows.Forms.TextBox
    Public WithEvents optFindByCustNumber As System.Windows.Forms.RadioButton
    Public WithEvents optFindByCustName As System.Windows.Forms.RadioButton
    Friend WithEvents grbNavigation As System.Windows.Forms.GroupBox
    Public WithEvents cmdLast As System.Windows.Forms.Button
    Public WithEvents cmdPrevious As System.Windows.Forms.Button
    Public WithEvents cmdNext As System.Windows.Forms.Button
    Public WithEvents cmdFirst As System.Windows.Forms.Button
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents cmbAutoCompleteCustName As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblCustSHEmail As System.Windows.Forms.LinkLabel
    Friend WithEvents lblCustEmail As System.Windows.Forms.LinkLabel
    Friend WithEvents lblCustSHWebsite As System.Windows.Forms.LinkLabel
    Friend WithEvents lblCustContactEmail As System.Windows.Forms.LinkLabel
    Friend WithEvents lblCustSHContactEmail As System.Windows.Forms.LinkLabel
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents dgvCustomerAppointments As System.Windows.Forms.DataGridView
    Friend WithEvents lblNoAppts As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WorksheetidDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AllowmanualmaintDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ReadyToXmitDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents XmittedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents WscreatedateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransmittalstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransmittaldateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValidationstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValidationdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrdernoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderdateDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErrorlevelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents season As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnMap As System.Windows.Forms.Button
    Friend WithEvents WebBrowser2 As System.Windows.Forms.WebBrowser
    Friend WithEvents chkCopyCust2CustSh As System.Windows.Forms.CheckBox
    Friend WithEvents NotesCommentsTableAdapter As KC01.SaleForcDataSetTableAdapters.NotesCommentsTableAdapter
    Public WithEvents fraStatus As System.Windows.Forms.GroupBox
    Friend WithEvents btnPrintMap As System.Windows.Forms.Button
    Friend WithEvents btnCloseMap As System.Windows.Forms.Button
    Public WithEvents txtCustStatusCd As System.Windows.Forms.TextBox
    Public WithEvents txtShipStatusCd As System.Windows.Forms.TextBox
    Public WithEvents _lblCustInfo_20 As System.Windows.Forms.Label
    Public WithEvents _lblCustInfo_21 As System.Windows.Forms.Label
    Public WithEvents cmdPrintHistory As System.Windows.Forms.Button
    Public WithEvents cmdEmailPass As System.Windows.Forms.Button
    Friend WithEvents OrdernoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeasonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompletedateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyorigordDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyshippedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyopenorderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OpenValueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WorksheetIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvoicenoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustpoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastUpDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Public WithEvents lblNoShipToInfo As System.Windows.Forms.Label
#End Region
End Class