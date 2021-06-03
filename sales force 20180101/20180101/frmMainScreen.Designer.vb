<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmMainScreen
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
    'Private ADOBind_adoCustInfo As VB6.MBindingCollection
	Public WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuCust As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuInventoryMatrix As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuInv As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuCustItem As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuReports As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuListCust As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuListOrders As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuListWs As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuListSep2 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuListWsErrMsg As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuListImportFiles As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuListWsToXmit As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuListSep3 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuListWsXmButNoVal As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuList As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuCommXmitWS As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuCommImp As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuCommSep As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuCommLog As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuCommSep2 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuCommProComm As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuComm As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuViewCommLog As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuView As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuMaintReXmit As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuUtilSep1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuUtilPresetVal As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuMaintLine1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuMaintRepairDB As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuUtilSep3 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuUtilPurge As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuMaint As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuHelpContents As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MnuAbout As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuRefSPR As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuRef As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
    Public WithEvents Timer5 As System.Windows.Forms.Timer
	Public WithEvents Timer3 As System.Windows.Forms.Timer
	Public WithEvents cmdWkstNotOnOrder As System.Windows.Forms.Button
	Public WithEvents Timer2 As System.Windows.Forms.Timer
	Public WithEvents cmdWkstWithNoResponse As System.Windows.Forms.Button
	Public WithEvents cmdWkstNotTrans As System.Windows.Forms.Button
	Public WithEvents cmdWkstErr As System.Windows.Forms.Button
	Public WithEvents cmdFilesToImport As System.Windows.Forms.Button
	Public WithEvents cmdFilesToXmit As System.Windows.Forms.Button
	Public WithEvents Timer1 As System.Windows.Forms.Timer
    Public WithEvents lblTitanStatus As System.Windows.Forms.Label
	Public WithEvents lblInternetStatus As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DrawTool1 As Calendar.DrawTool = New Calendar.DrawTool()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainScreen))
        Me.DayView1 = New Calendar.DayView()
        Me.cmdWkstNotOnOrder = New System.Windows.Forms.Button()
        Me.cmdWkstWithNoResponse = New System.Windows.Forms.Button()
        Me.cmdWkstNotTrans = New System.Windows.Forms.Button()
        Me.cmdWkstErr = New System.Windows.Forms.Button()
        Me.cmdFilesToImport = New System.Windows.Forms.Button()
        Me.cmdFilesToXmit = New System.Windows.Forms.Button()
        Me.lblQuickAppt = New System.Windows.Forms.LinkLabel()
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCust = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInv = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInventoryMatrix = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReports = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCustItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuList = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuListCust = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuListOrders = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuListWs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuListSep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuListWsErrMsg = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuListImportFiles = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuListWsToXmit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuListSep3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuListWsXmButNoVal = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuComm = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCommXmitWS = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCommImp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCommSep = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuCommLog = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCommSep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuCommProComm = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewCommLog = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMaint = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMaintReXmit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUtilSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuUtilPresetVal = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMaintLine1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuMaintRepairDB = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUtilSep3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuUtilPurge = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpContents = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuMailTest = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRef = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRefSPR = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDatabase = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTitanStatus = New System.Windows.Forms.Label()
        Me.lblInternetStatus = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblShowAppointments = New System.Windows.Forms.LinkLabel()
        Me.llblStCroix = New System.Windows.Forms.LinkLabel()
        Me.llblStCroixKnits = New System.Windows.Forms.LinkLabel()
        Me.llblSalesMeeting = New System.Windows.Forms.LinkLabel()
        Me.llblEmailCustSv = New System.Windows.Forms.LinkLabel()
        Me.llblEmailSupport = New System.Windows.Forms.LinkLabel()
        Me.lblTitanFileStatus = New System.Windows.Forms.LinkLabel()
        Me.bndCustomers = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaleForcDataSet = New KC01.SaleForcDataSet()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.CustomerTableAdapter = New KC01.SaleForcDataSetTableAdapters.CustomerTableAdapter()
        Me.lblConnectionStatus = New System.Windows.Forms.Label()
        Me.lblCustAddress = New System.Windows.Forms.Label()
        Me.cmdAddAppt = New System.Windows.Forms.Button()
        Me.cmbAppt = New System.Windows.Forms.ComboBox()
        Me.chkViewActiveCustomers = New System.Windows.Forms.CheckBox()
        Me.lblAlwaysShowAppts = New System.Windows.Forms.Label()
        Me.chkAlwaysShowAppts = New System.Windows.Forms.CheckBox()
        Me.llblGotoPreviousWeekAppt = New System.Windows.Forms.LinkLabel()
        Me.llblGotoThisWeekAppt = New System.Windows.Forms.LinkLabel()
        Me.llblGotoNextWeekAppt = New System.Windows.Forms.LinkLabel()
        Me.llblEmailAppointments = New System.Windows.Forms.LinkLabel()
        Me.lblcalendarmonth = New System.Windows.Forms.Label()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlSocialMedia = New System.Windows.Forms.Panel()
        Me.pbYouTube = New System.Windows.Forms.PictureBox()
        Me.pbGooglePlus = New System.Windows.Forms.PictureBox()
        Me.pbPinterest = New System.Windows.Forms.PictureBox()
        Me.pbTwitter = New System.Windows.Forms.PictureBox()
        Me.pbFacebook = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MainMenu1.SuspendLayout()
        CType(Me.bndCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleForcDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSocialMedia.SuspendLayout()
        CType(Me.pbYouTube, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGooglePlus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPinterest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTwitter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFacebook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DayView1
        '
        DrawTool1.DayView = Me.DayView1
        Me.DayView1.ActiveTool = DrawTool1
        Me.DayView1.AllowInplaceEditing = False
        Me.DayView1.AllowNew = False
        Me.DayView1.AmPmDisplay = True
        Me.DayView1.AppHeightMode = Calendar.DayView.AppHeightDrawMode.FullHalfHourBlocksShort
        Me.DayView1.DaysToShow = 7
        Me.DayView1.DrawAllAppBorder = False
        Me.DayView1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DayView1.Location = New System.Drawing.Point(27, 265)
        Me.DayView1.MinHalfHourApp = False
        Me.DayView1.Name = "DayView1"
        Me.DayView1.SelectionEnd = New Date(CType(0, Long))
        Me.DayView1.SelectionStart = New Date(CType(0, Long))
        Me.DayView1.Size = New System.Drawing.Size(750, 10)
        Me.DayView1.SlotsPerHour = 2
        Me.DayView1.StartDate = New Date(2011, 12, 4, 0, 0, 0, 0)
        Me.DayView1.TabIndex = 54
        Me.DayView1.Text = "DayView1"
        Me.DayView1.Visible = False
        Me.DayView1.WorkingMinuteEnd = 0
        Me.DayView1.WorkingMinuteStart = 0
        '
        'cmdWkstNotOnOrder
        '
        Me.cmdWkstNotOnOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdWkstNotOnOrder.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdWkstNotOnOrder.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdWkstNotOnOrder.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdWkstNotOnOrder.Location = New System.Drawing.Point(663, 144)
        Me.cmdWkstNotOnOrder.Name = "cmdWkstNotOnOrder"
        Me.cmdWkstNotOnOrder.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdWkstNotOnOrder.Size = New System.Drawing.Size(114, 58)
        Me.cmdWkstNotOnOrder.TabIndex = 5
        Me.cmdWkstNotOnOrder.Text = "Worksheets Responded To But Not An Order!"
        Me.cmdWkstNotOnOrder.UseVisualStyleBackColor = False
        Me.cmdWkstNotOnOrder.Visible = False
        '
        'cmdWkstWithNoResponse
        '
        Me.cmdWkstWithNoResponse.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdWkstWithNoResponse.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdWkstWithNoResponse.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdWkstWithNoResponse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdWkstWithNoResponse.Location = New System.Drawing.Point(408, 144)
        Me.cmdWkstWithNoResponse.Name = "cmdWkstWithNoResponse"
        Me.cmdWkstWithNoResponse.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdWkstWithNoResponse.Size = New System.Drawing.Size(121, 58)
        Me.cmdWkstWithNoResponse.TabIndex = 4
        Me.cmdWkstWithNoResponse.Text = "Worksheets Waiting For Response!"
        Me.cmdWkstWithNoResponse.UseVisualStyleBackColor = False
        Me.cmdWkstWithNoResponse.Visible = False
        '
        'cmdWkstNotTrans
        '
        Me.cmdWkstNotTrans.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdWkstNotTrans.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdWkstNotTrans.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdWkstNotTrans.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdWkstNotTrans.Location = New System.Drawing.Point(280, 144)
        Me.cmdWkstNotTrans.Name = "cmdWkstNotTrans"
        Me.cmdWkstNotTrans.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdWkstNotTrans.Size = New System.Drawing.Size(121, 58)
        Me.cmdWkstNotTrans.TabIndex = 3
        Me.cmdWkstNotTrans.Text = "Worksheets To Prepare For Transmit!"
        Me.cmdWkstNotTrans.UseVisualStyleBackColor = False
        Me.cmdWkstNotTrans.Visible = False
        '
        'cmdWkstErr
        '
        Me.cmdWkstErr.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdWkstErr.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdWkstErr.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdWkstErr.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdWkstErr.Location = New System.Drawing.Point(152, 144)
        Me.cmdWkstErr.Name = "cmdWkstErr"
        Me.cmdWkstErr.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdWkstErr.Size = New System.Drawing.Size(121, 58)
        Me.cmdWkstErr.TabIndex = 2
        Me.cmdWkstErr.Text = "Worksheets With Errors!"
        Me.cmdWkstErr.UseVisualStyleBackColor = False
        Me.cmdWkstErr.Visible = False
        '
        'cmdFilesToImport
        '
        Me.cmdFilesToImport.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdFilesToImport.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFilesToImport.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFilesToImport.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdFilesToImport.Location = New System.Drawing.Point(24, 144)
        Me.cmdFilesToImport.Name = "cmdFilesToImport"
        Me.cmdFilesToImport.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdFilesToImport.Size = New System.Drawing.Size(121, 58)
        Me.cmdFilesToImport.TabIndex = 1
        Me.cmdFilesToImport.Text = "Files To Import!"
        Me.cmdFilesToImport.UseVisualStyleBackColor = False
        Me.cmdFilesToImport.Visible = False
        '
        'cmdFilesToXmit
        '
        Me.cmdFilesToXmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdFilesToXmit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFilesToXmit.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFilesToXmit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdFilesToXmit.Location = New System.Drawing.Point(536, 144)
        Me.cmdFilesToXmit.Name = "cmdFilesToXmit"
        Me.cmdFilesToXmit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdFilesToXmit.Size = New System.Drawing.Size(121, 58)
        Me.cmdFilesToXmit.TabIndex = 0
        Me.cmdFilesToXmit.Text = "Files To Transmit!"
        Me.cmdFilesToXmit.UseVisualStyleBackColor = False
        Me.cmdFilesToXmit.Visible = False
        '
        'lblQuickAppt
        '
        Me.lblQuickAppt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblQuickAppt.AutoSize = True
        Me.lblQuickAppt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuickAppt.LinkColor = System.Drawing.Color.White
        Me.lblQuickAppt.Location = New System.Drawing.Point(24, 473)
        Me.lblQuickAppt.Name = "lblQuickAppt"
        Me.lblQuickAppt.Size = New System.Drawing.Size(153, 16)
        Me.lblQuickAppt.TabIndex = 38
        Me.lblQuickAppt.TabStop = True
        Me.lblQuickAppt.Text = "Quick Appointment Entry"
        Me.lblQuickAppt.Visible = False
        '
        'MainMenu1
        '
        Me.MainMenu1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuCust, Me.mnuInv, Me.mnuReports, Me.mnuList, Me.mnuComm, Me.mnuView, Me.mnuMaint, Me.mnuHelp, Me.mnuRef, Me.mnuDatabase})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Size = New System.Drawing.Size(793, 24)
        Me.MainMenu1.TabIndex = 33
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileExit})
        Me.mnuFile.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(92, 22)
        Me.mnuFileExit.Text = "E&xit"
        '
        'mnuCust
        '
        Me.mnuCust.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuCust.Name = "mnuCust"
        Me.mnuCust.Size = New System.Drawing.Size(76, 20)
        Me.mnuCust.Text = "&Customers"
        '
        'mnuInv
        '
        Me.mnuInv.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuInventoryMatrix})
        Me.mnuInv.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuInv.Name = "mnuInv"
        Me.mnuInv.Size = New System.Drawing.Size(69, 20)
        Me.mnuInv.Text = "&Inventory"
        '
        'mnuInventoryMatrix
        '
        Me.mnuInventoryMatrix.Name = "mnuInventoryMatrix"
        Me.mnuInventoryMatrix.Size = New System.Drawing.Size(135, 22)
        Me.mnuInventoryMatrix.Text = "Matrix View"
        '
        'mnuReports
        '
        Me.mnuReports.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCustItem})
        Me.mnuReports.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuReports.Name = "mnuReports"
        Me.mnuReports.Size = New System.Drawing.Size(59, 20)
        Me.mnuReports.Text = "&Reports"
        '
        'mnuCustItem
        '
        Me.mnuCustItem.Name = "mnuCustItem"
        Me.mnuCustItem.Size = New System.Drawing.Size(152, 22)
        Me.mnuCustItem.Text = "Items Ordered "
        '
        'mnuList
        '
        Me.mnuList.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuListCust, Me.mnuListOrders, Me.mnuListWs, Me.mnuListSep2, Me.mnuListWsErrMsg, Me.mnuListImportFiles, Me.mnuListWsToXmit, Me.mnuListSep3, Me.mnuListWsXmButNoVal})
        Me.mnuList.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuList.Name = "mnuList"
        Me.mnuList.Size = New System.Drawing.Size(42, 20)
        Me.mnuList.Text = "&Lists"
        '
        'mnuListCust
        '
        Me.mnuListCust.Name = "mnuListCust"
        Me.mnuListCust.Size = New System.Drawing.Size(245, 22)
        Me.mnuListCust.Text = "Customers"
        '
        'mnuListOrders
        '
        Me.mnuListOrders.Name = "mnuListOrders"
        Me.mnuListOrders.Size = New System.Drawing.Size(245, 22)
        Me.mnuListOrders.Text = "Orders"
        '
        'mnuListWs
        '
        Me.mnuListWs.Name = "mnuListWs"
        Me.mnuListWs.Size = New System.Drawing.Size(245, 22)
        Me.mnuListWs.Text = "Worksheets"
        '
        'mnuListSep2
        '
        Me.mnuListSep2.Name = "mnuListSep2"
        Me.mnuListSep2.Size = New System.Drawing.Size(242, 6)
        '
        'mnuListWsErrMsg
        '
        Me.mnuListWsErrMsg.Name = "mnuListWsErrMsg"
        Me.mnuListWsErrMsg.Size = New System.Drawing.Size(245, 22)
        Me.mnuListWsErrMsg.Text = "Worksheet Error Messages"
        '
        'mnuListImportFiles
        '
        Me.mnuListImportFiles.Name = "mnuListImportFiles"
        Me.mnuListImportFiles.Size = New System.Drawing.Size(245, 22)
        Me.mnuListImportFiles.Text = "Files to &import"
        '
        'mnuListWsToXmit
        '
        Me.mnuListWsToXmit.Name = "mnuListWsToXmit"
        Me.mnuListWsToXmit.Size = New System.Drawing.Size(245, 22)
        Me.mnuListWsToXmit.Text = "Files (Worksheets) to &transmit"
        '
        'mnuListSep3
        '
        Me.mnuListSep3.Name = "mnuListSep3"
        Me.mnuListSep3.Size = New System.Drawing.Size(242, 6)
        '
        'mnuListWsXmButNoVal
        '
        Me.mnuListWsXmButNoVal.Name = "mnuListWsXmButNoVal"
        Me.mnuListWsXmButNoVal.Size = New System.Drawing.Size(245, 22)
        Me.mnuListWsXmButNoVal.Text = "Worksheets waiting for response"
        '
        'mnuComm
        '
        Me.mnuComm.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCommXmitWS, Me.mnuCommImp, Me.mnuCommSep, Me.mnuCommLog, Me.mnuCommSep2, Me.mnuCommProComm})
        Me.mnuComm.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuComm.Name = "mnuComm"
        Me.mnuComm.Size = New System.Drawing.Size(111, 20)
        Me.mnuComm.Text = "C&ommunications"
        '
        'mnuCommXmitWS
        '
        Me.mnuCommXmitWS.Name = "mnuCommXmitWS"
        Me.mnuCommXmitWS.Size = New System.Drawing.Size(230, 22)
        Me.mnuCommXmitWS.Text = "Files (Worksheets) to transmit"
        '
        'mnuCommImp
        '
        Me.mnuCommImp.Name = "mnuCommImp"
        Me.mnuCommImp.Size = New System.Drawing.Size(230, 22)
        Me.mnuCommImp.Text = "Files to Import"
        '
        'mnuCommSep
        '
        Me.mnuCommSep.Name = "mnuCommSep"
        Me.mnuCommSep.Size = New System.Drawing.Size(227, 6)
        '
        'mnuCommLog
        '
        Me.mnuCommLog.Name = "mnuCommLog"
        Me.mnuCommLog.Size = New System.Drawing.Size(230, 22)
        Me.mnuCommLog.Text = "View Comm Log"
        '
        'mnuCommSep2
        '
        Me.mnuCommSep2.Name = "mnuCommSep2"
        Me.mnuCommSep2.Size = New System.Drawing.Size(227, 6)
        '
        'mnuCommProComm
        '
        Me.mnuCommProComm.Name = "mnuCommProComm"
        Me.mnuCommProComm.Size = New System.Drawing.Size(230, 22)
        Me.mnuCommProComm.Text = "Send/Receive Files"
        '
        'mnuView
        '
        Me.mnuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuViewCommLog})
        Me.mnuView.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuView.Name = "mnuView"
        Me.mnuView.Size = New System.Drawing.Size(59, 20)
        Me.mnuView.Text = "&Viewers"
        '
        'mnuViewCommLog
        '
        Me.mnuViewCommLog.Name = "mnuViewCommLog"
        Me.mnuViewCommLog.Size = New System.Drawing.Size(189, 22)
        Me.mnuViewCommLog.Text = "Communications Log"
        '
        'mnuMaint
        '
        Me.mnuMaint.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMaintReXmit, Me.mnuUtilSep1, Me.mnuUtilPresetVal, Me.mnuMaintLine1, Me.mnuMaintRepairDB, Me.mnuUtilSep3, Me.mnuUtilPurge})
        Me.mnuMaint.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuMaint.Name = "mnuMaint"
        Me.mnuMaint.Size = New System.Drawing.Size(58, 20)
        Me.mnuMaint.Text = "&Utilities"
        '
        'mnuMaintReXmit
        '
        Me.mnuMaintReXmit.Name = "mnuMaintReXmit"
        Me.mnuMaintReXmit.Size = New System.Drawing.Size(232, 22)
        Me.mnuMaintReXmit.Text = "Set worksheets for re-transmit"
        '
        'mnuUtilSep1
        '
        Me.mnuUtilSep1.Name = "mnuUtilSep1"
        Me.mnuUtilSep1.Size = New System.Drawing.Size(229, 6)
        '
        'mnuUtilPresetVal
        '
        Me.mnuUtilPresetVal.Name = "mnuUtilPresetVal"
        Me.mnuUtilPresetVal.Size = New System.Drawing.Size(232, 22)
        Me.mnuUtilPresetVal.Text = "Preset worksheet values"
        '
        'mnuMaintLine1
        '
        Me.mnuMaintLine1.Name = "mnuMaintLine1"
        Me.mnuMaintLine1.Size = New System.Drawing.Size(229, 6)
        '
        'mnuMaintRepairDB
        '
        Me.mnuMaintRepairDB.Name = "mnuMaintRepairDB"
        Me.mnuMaintRepairDB.Size = New System.Drawing.Size(232, 22)
        Me.mnuMaintRepairDB.Text = "Compact database"
        '
        'mnuUtilSep3
        '
        Me.mnuUtilSep3.Name = "mnuUtilSep3"
        Me.mnuUtilSep3.Size = New System.Drawing.Size(229, 6)
        '
        'mnuUtilPurge
        '
        Me.mnuUtilPurge.Name = "mnuUtilPurge"
        Me.mnuUtilPurge.Size = New System.Drawing.Size(232, 22)
        Me.mnuUtilPurge.Text = "Purge Database"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpContents, Me.MnuAbout, Me.MnuMailTest})
        Me.mnuHelp.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuHelpContents
        '
        Me.mnuHelpContents.Name = "mnuHelpContents"
        Me.mnuHelpContents.Size = New System.Drawing.Size(127, 22)
        Me.mnuHelpContents.Text = "&Contents"
        '
        'MnuAbout
        '
        Me.MnuAbout.Name = "MnuAbout"
        Me.MnuAbout.Size = New System.Drawing.Size(127, 22)
        Me.MnuAbout.Text = "&About"
        '
        'MnuMailTest
        '
        Me.MnuMailTest.Name = "MnuMailTest"
        Me.MnuMailTest.Size = New System.Drawing.Size(127, 22)
        Me.MnuMailTest.Text = "eMail Test"
        '
        'mnuRef
        '
        Me.mnuRef.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRefSPR})
        Me.mnuRef.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuRef.Name = "mnuRef"
        Me.mnuRef.Size = New System.Drawing.Size(71, 20)
        Me.mnuRef.Text = "&Reference"
        '
        'mnuRefSPR
        '
        Me.mnuRefSPR.Name = "mnuRefSPR"
        Me.mnuRefSPR.Size = New System.Drawing.Size(176, 22)
        Me.mnuRefSPR.Text = "Sales Person record"
        '
        'mnuDatabase
        '
        Me.mnuDatabase.Name = "mnuDatabase"
        Me.mnuDatabase.Size = New System.Drawing.Size(67, 20)
        Me.mnuDatabase.Text = "Database"
        Me.mnuDatabase.Visible = False
        '
        'Timer5
        '
        Me.Timer5.Interval = 3000
        '
        'Timer3
        '
        Me.Timer3.Interval = 10000
        '
        'Timer2
        '
        Me.Timer2.Interval = 3000
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'lblTitanStatus
        '
        Me.lblTitanStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitanStatus.BackColor = System.Drawing.Color.Lime
        Me.lblTitanStatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitanStatus.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitanStatus.ForeColor = System.Drawing.Color.Lime
        Me.lblTitanStatus.Location = New System.Drawing.Point(764, 64)
        Me.lblTitanStatus.Name = "lblTitanStatus"
        Me.lblTitanStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitanStatus.Size = New System.Drawing.Size(17, 17)
        Me.lblTitanStatus.TabIndex = 31
        '
        'lblInternetStatus
        '
        Me.lblInternetStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInternetStatus.BackColor = System.Drawing.Color.Red
        Me.lblInternetStatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblInternetStatus.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInternetStatus.ForeColor = System.Drawing.Color.Black
        Me.lblInternetStatus.Location = New System.Drawing.Point(764, 32)
        Me.lblInternetStatus.Name = "lblInternetStatus"
        Me.lblInternetStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInternetStatus.Size = New System.Drawing.Size(17, 17)
        Me.lblInternetStatus.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(348, 33)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Sales Force Automation"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(21, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(291, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "version"
        '
        'lblShowAppointments
        '
        Me.lblShowAppointments.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblShowAppointments.AutoSize = True
        Me.lblShowAppointments.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowAppointments.LinkColor = System.Drawing.Color.White
        Me.lblShowAppointments.Location = New System.Drawing.Point(24, 497)
        Me.lblShowAppointments.Name = "lblShowAppointments"
        Me.lblShowAppointments.Size = New System.Drawing.Size(123, 16)
        Me.lblShowAppointments.TabIndex = 39
        Me.lblShowAppointments.TabStop = True
        Me.lblShowAppointments.Text = "Show Appointments"
        Me.lblShowAppointments.Visible = False
        '
        'llblStCroix
        '
        Me.llblStCroix.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.llblStCroix.BackColor = System.Drawing.Color.White
        Me.llblStCroix.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblStCroix.LinkColor = System.Drawing.Color.Black
        Me.llblStCroix.Location = New System.Drawing.Point(655, 518)
        Me.llblStCroix.Name = "llblStCroix"
        Me.llblStCroix.Size = New System.Drawing.Size(102, 20)
        Me.llblStCroix.TabIndex = 41
        Me.llblStCroix.TabStop = True
        Me.llblStCroix.Text = "St. Croix Shop"
        '
        'llblStCroixKnits
        '
        Me.llblStCroixKnits.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.llblStCroixKnits.BackColor = System.Drawing.Color.White
        Me.llblStCroixKnits.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblStCroixKnits.LinkColor = System.Drawing.Color.Black
        Me.llblStCroixKnits.Location = New System.Drawing.Point(497, 518)
        Me.llblStCroixKnits.Name = "llblStCroixKnits"
        Me.llblStCroixKnits.Size = New System.Drawing.Size(143, 20)
        Me.llblStCroixKnits.TabIndex = 42
        Me.llblStCroixKnits.TabStop = True
        Me.llblStCroixKnits.Text = "St. Croix Collections"
        '
        'llblSalesMeeting
        '
        Me.llblSalesMeeting.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.llblSalesMeeting.BackColor = System.Drawing.Color.White
        Me.llblSalesMeeting.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblSalesMeeting.ForeColor = System.Drawing.Color.Black
        Me.llblSalesMeeting.LinkColor = System.Drawing.Color.Black
        Me.llblSalesMeeting.Location = New System.Drawing.Point(327, 518)
        Me.llblSalesMeeting.Name = "llblSalesMeeting"
        Me.llblSalesMeeting.Size = New System.Drawing.Size(157, 20)
        Me.llblSalesMeeting.TabIndex = 43
        Me.llblSalesMeeting.TabStop = True
        Me.llblSalesMeeting.Text = "Sales Meeting Website"
        '
        'llblEmailCustSv
        '
        Me.llblEmailCustSv.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.llblEmailCustSv.BackColor = System.Drawing.Color.White
        Me.llblEmailCustSv.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblEmailCustSv.LinkColor = System.Drawing.Color.Black
        Me.llblEmailCustSv.Location = New System.Drawing.Point(155, 518)
        Me.llblEmailCustSv.Name = "llblEmailCustSv"
        Me.llblEmailCustSv.Size = New System.Drawing.Size(141, 20)
        Me.llblEmailCustSv.TabIndex = 44
        Me.llblEmailCustSv.TabStop = True
        Me.llblEmailCustSv.Text = "Email Sales Support"
        '
        'llblEmailSupport
        '
        Me.llblEmailSupport.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.llblEmailSupport.BackColor = System.Drawing.Color.White
        Me.llblEmailSupport.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblEmailSupport.LinkColor = System.Drawing.Color.Black
        Me.llblEmailSupport.Location = New System.Drawing.Point(23, 518)
        Me.llblEmailSupport.Name = "llblEmailSupport"
        Me.llblEmailSupport.Size = New System.Drawing.Size(100, 20)
        Me.llblEmailSupport.TabIndex = 45
        Me.llblEmailSupport.TabStop = True
        Me.llblEmailSupport.Text = "Email Support"
        '
        'lblTitanFileStatus
        '
        Me.lblTitanFileStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitanFileStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTitanFileStatus.CausesValidation = False
        Me.lblTitanFileStatus.DisabledLinkColor = System.Drawing.Color.DimGray
        Me.lblTitanFileStatus.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitanFileStatus.ForeColor = System.Drawing.Color.White
        Me.lblTitanFileStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTitanFileStatus.LinkColor = System.Drawing.Color.White
        Me.lblTitanFileStatus.Location = New System.Drawing.Point(533, 62)
        Me.lblTitanFileStatus.Name = "lblTitanFileStatus"
        Me.lblTitanFileStatus.Size = New System.Drawing.Size(222, 17)
        Me.lblTitanFileStatus.TabIndex = 47
        Me.lblTitanFileStatus.TabStop = True
        Me.lblTitanFileStatus.Text = "Checking for Titan files to download"
        Me.lblTitanFileStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'bndCustomers
        '
        Me.bndCustomers.DataMember = "Customer"
        Me.bndCustomers.DataSource = Me.SaleForcDataSet
        Me.bndCustomers.Filter = """[status-code] = '"" & ""P"" & ""'"""
        '
        'SaleForcDataSet
        '
        Me.SaleForcDataSet.DataSetName = "SaleForcDataSet"
        Me.SaleForcDataSet.EnforceConstraints = False
        Me.SaleForcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Lime
        Me.ProgressBar1.Location = New System.Drawing.Point(557, 87)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(224, 15)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 53
        Me.ProgressBar1.Visible = False
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'lblConnectionStatus
        '
        Me.lblConnectionStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblConnectionStatus.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnectionStatus.ForeColor = System.Drawing.Color.White
        Me.lblConnectionStatus.Location = New System.Drawing.Point(578, 34)
        Me.lblConnectionStatus.Name = "lblConnectionStatus"
        Me.lblConnectionStatus.Size = New System.Drawing.Size(177, 15)
        Me.lblConnectionStatus.TabIndex = 55
        Me.lblConnectionStatus.Text = "Internet Status:  Not Connected"
        Me.lblConnectionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCustAddress
        '
        Me.lblCustAddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCustAddress.BackColor = System.Drawing.SystemColors.Window
        Me.lblCustAddress.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCustAddress.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustAddress.ForeColor = System.Drawing.Color.Black
        Me.lblCustAddress.Location = New System.Drawing.Point(24, 400)
        Me.lblCustAddress.Name = "lblCustAddress"
        Me.lblCustAddress.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCustAddress.Size = New System.Drawing.Size(305, 73)
        Me.lblCustAddress.TabIndex = 27
        Me.lblCustAddress.Visible = False
        '
        'cmdAddAppt
        '
        Me.cmdAddAppt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdAddAppt.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAddAppt.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAddAppt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddAppt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAddAppt.Location = New System.Drawing.Point(208, 375)
        Me.cmdAddAppt.Name = "cmdAddAppt"
        Me.cmdAddAppt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAddAppt.Size = New System.Drawing.Size(121, 24)
        Me.cmdAddAppt.TabIndex = 26
        Me.cmdAddAppt.Text = "New Appointment"
        Me.cmdAddAppt.UseVisualStyleBackColor = False
        Me.cmdAddAppt.Visible = False
        '
        'cmbAppt
        '
        Me.cmbAppt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbAppt.DataSource = Me.bndCustomers
        Me.cmbAppt.DisplayMember = "Name"
        Me.cmbAppt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAppt.FormattingEnabled = True
        Me.cmbAppt.Location = New System.Drawing.Point(25, 375)
        Me.cmbAppt.Name = "cmbAppt"
        Me.cmbAppt.Size = New System.Drawing.Size(179, 21)
        Me.cmbAppt.TabIndex = 52
        Me.cmbAppt.Visible = False
        '
        'chkViewActiveCustomers
        '
        Me.chkViewActiveCustomers.AutoSize = True
        Me.chkViewActiveCustomers.Checked = True
        Me.chkViewActiveCustomers.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkViewActiveCustomers.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkViewActiveCustomers.ForeColor = System.Drawing.SystemColors.Control
        Me.chkViewActiveCustomers.Location = New System.Drawing.Point(208, 348)
        Me.chkViewActiveCustomers.Name = "chkViewActiveCustomers"
        Me.chkViewActiveCustomers.Size = New System.Drawing.Size(191, 20)
        Me.chkViewActiveCustomers.TabIndex = 56
        Me.chkViewActiveCustomers.Text = "View Active Customers Only"
        Me.chkViewActiveCustomers.UseVisualStyleBackColor = False
        Me.chkViewActiveCustomers.Visible = False
        '
        'lblAlwaysShowAppts
        '
        Me.lblAlwaysShowAppts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAlwaysShowAppts.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAlwaysShowAppts.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAlwaysShowAppts.Enabled = False
        Me.lblAlwaysShowAppts.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlwaysShowAppts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblAlwaysShowAppts.Location = New System.Drawing.Point(560, 229)
        Me.lblAlwaysShowAppts.Name = "lblAlwaysShowAppts"
        Me.lblAlwaysShowAppts.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAlwaysShowAppts.Size = New System.Drawing.Size(88, 34)
        Me.lblAlwaysShowAppts.TabIndex = 24
        Me.lblAlwaysShowAppts.Text = "Show Calendar at Startup"
        Me.lblAlwaysShowAppts.Visible = False
        '
        'chkAlwaysShowAppts
        '
        Me.chkAlwaysShowAppts.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkAlwaysShowAppts.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkAlwaysShowAppts.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAlwaysShowAppts.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAlwaysShowAppts.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAlwaysShowAppts.Location = New System.Drawing.Point(537, 246)
        Me.chkAlwaysShowAppts.Name = "chkAlwaysShowAppts"
        Me.chkAlwaysShowAppts.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAlwaysShowAppts.Size = New System.Drawing.Size(17, 17)
        Me.chkAlwaysShowAppts.TabIndex = 23
        Me.chkAlwaysShowAppts.UseVisualStyleBackColor = False
        Me.chkAlwaysShowAppts.Visible = False
        '
        'llblGotoPreviousWeekAppt
        '
        Me.llblGotoPreviousWeekAppt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblGotoPreviousWeekAppt.AutoSize = True
        Me.llblGotoPreviousWeekAppt.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblGotoPreviousWeekAppt.LinkColor = System.Drawing.Color.White
        Me.llblGotoPreviousWeekAppt.Location = New System.Drawing.Point(274, 247)
        Me.llblGotoPreviousWeekAppt.Name = "llblGotoPreviousWeekAppt"
        Me.llblGotoPreviousWeekAppt.Size = New System.Drawing.Size(89, 15)
        Me.llblGotoPreviousWeekAppt.TabIndex = 35
        Me.llblGotoPreviousWeekAppt.TabStop = True
        Me.llblGotoPreviousWeekAppt.Text = "Previous Week"
        Me.llblGotoPreviousWeekAppt.Visible = False
        '
        'llblGotoThisWeekAppt
        '
        Me.llblGotoThisWeekAppt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblGotoThisWeekAppt.AutoSize = True
        Me.llblGotoThisWeekAppt.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblGotoThisWeekAppt.LinkColor = System.Drawing.Color.White
        Me.llblGotoThisWeekAppt.Location = New System.Drawing.Point(369, 248)
        Me.llblGotoThisWeekAppt.Name = "llblGotoThisWeekAppt"
        Me.llblGotoThisWeekAppt.Size = New System.Drawing.Size(65, 15)
        Me.llblGotoThisWeekAppt.TabIndex = 36
        Me.llblGotoThisWeekAppt.TabStop = True
        Me.llblGotoThisWeekAppt.Text = "This Week"
        Me.llblGotoThisWeekAppt.Visible = False
        '
        'llblGotoNextWeekAppt
        '
        Me.llblGotoNextWeekAppt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblGotoNextWeekAppt.AutoSize = True
        Me.llblGotoNextWeekAppt.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblGotoNextWeekAppt.LinkColor = System.Drawing.Color.White
        Me.llblGotoNextWeekAppt.Location = New System.Drawing.Point(440, 248)
        Me.llblGotoNextWeekAppt.Name = "llblGotoNextWeekAppt"
        Me.llblGotoNextWeekAppt.Size = New System.Drawing.Size(65, 15)
        Me.llblGotoNextWeekAppt.TabIndex = 37
        Me.llblGotoNextWeekAppt.TabStop = True
        Me.llblGotoNextWeekAppt.Text = "Next Week"
        Me.llblGotoNextWeekAppt.Visible = False
        '
        'llblEmailAppointments
        '
        Me.llblEmailAppointments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblEmailAppointments.AutoSize = True
        Me.llblEmailAppointments.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblEmailAppointments.LinkColor = System.Drawing.Color.White
        Me.llblEmailAppointments.Location = New System.Drawing.Point(660, 245)
        Me.llblEmailAppointments.Name = "llblEmailAppointments"
        Me.llblEmailAppointments.Size = New System.Drawing.Size(117, 15)
        Me.llblEmailAppointments.TabIndex = 40
        Me.llblEmailAppointments.TabStop = True
        Me.llblEmailAppointments.Text = "Email Appointments"
        Me.llblEmailAppointments.Visible = False
        '
        'lblcalendarmonth
        '
        Me.lblcalendarmonth.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblcalendarmonth.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcalendarmonth.ForeColor = System.Drawing.SystemColors.Control
        Me.lblcalendarmonth.Location = New System.Drawing.Point(-4, 223)
        Me.lblcalendarmonth.Name = "lblcalendarmonth"
        Me.lblcalendarmonth.Size = New System.Drawing.Size(803, 22)
        Me.lblcalendarmonth.TabIndex = 57
        Me.lblcalendarmonth.Text = "June 2012"
        Me.lblcalendarmonth.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblcalendarmonth.Visible = False
        '
        'pnlSocialMedia
        '
        Me.pnlSocialMedia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSocialMedia.Controls.Add(Me.pbYouTube)
        Me.pnlSocialMedia.Controls.Add(Me.pbGooglePlus)
        Me.pnlSocialMedia.Controls.Add(Me.pbPinterest)
        Me.pnlSocialMedia.Controls.Add(Me.pbTwitter)
        Me.pnlSocialMedia.Controls.Add(Me.pbFacebook)
        Me.pnlSocialMedia.Location = New System.Drawing.Point(27, 98)
        Me.pnlSocialMedia.Name = "pnlSocialMedia"
        Me.pnlSocialMedia.Size = New System.Drawing.Size(206, 40)
        Me.pnlSocialMedia.TabIndex = 64
        '
        'pbYouTube
        '
        Me.pbYouTube.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbYouTube.ErrorImage = CType(resources.GetObject("pbYouTube.ErrorImage"), System.Drawing.Image)
        Me.pbYouTube.Image = CType(resources.GetObject("pbYouTube.Image"), System.Drawing.Image)
        Me.pbYouTube.Location = New System.Drawing.Point(6, 4)
        Me.pbYouTube.Name = "pbYouTube"
        Me.pbYouTube.Size = New System.Drawing.Size(35, 33)
        Me.pbYouTube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbYouTube.TabIndex = 68
        Me.pbYouTube.TabStop = False
        '
        'pbGooglePlus
        '
        Me.pbGooglePlus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbGooglePlus.Image = CType(resources.GetObject("pbGooglePlus.Image"), System.Drawing.Image)
        Me.pbGooglePlus.Location = New System.Drawing.Point(47, 4)
        Me.pbGooglePlus.Name = "pbGooglePlus"
        Me.pbGooglePlus.Size = New System.Drawing.Size(35, 33)
        Me.pbGooglePlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbGooglePlus.TabIndex = 67
        Me.pbGooglePlus.TabStop = False
        '
        'pbPinterest
        '
        Me.pbPinterest.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbPinterest.Image = CType(resources.GetObject("pbPinterest.Image"), System.Drawing.Image)
        Me.pbPinterest.Location = New System.Drawing.Point(168, 4)
        Me.pbPinterest.Name = "pbPinterest"
        Me.pbPinterest.Size = New System.Drawing.Size(35, 33)
        Me.pbPinterest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPinterest.TabIndex = 65
        Me.pbPinterest.TabStop = False
        '
        'pbTwitter
        '
        Me.pbTwitter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbTwitter.Image = CType(resources.GetObject("pbTwitter.Image"), System.Drawing.Image)
        Me.pbTwitter.Location = New System.Drawing.Point(127, 4)
        Me.pbTwitter.Name = "pbTwitter"
        Me.pbTwitter.Size = New System.Drawing.Size(35, 33)
        Me.pbTwitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbTwitter.TabIndex = 64
        Me.pbTwitter.TabStop = False
        '
        'pbFacebook
        '
        Me.pbFacebook.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbFacebook.Image = CType(resources.GetObject("pbFacebook.Image"), System.Drawing.Image)
        Me.pbFacebook.Location = New System.Drawing.Point(86, 4)
        Me.pbFacebook.Name = "pbFacebook"
        Me.pbFacebook.Size = New System.Drawing.Size(35, 33)
        Me.pbFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFacebook.TabIndex = 63
        Me.pbFacebook.TabStop = False
        '
        'frmMainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(793, 544)
        Me.Controls.Add(Me.pnlSocialMedia)
        Me.Controls.Add(Me.chkViewActiveCustomers)
        Me.Controls.Add(Me.lblConnectionStatus)
        Me.Controls.Add(Me.DayView1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.cmbAppt)
        Me.Controls.Add(Me.lblTitanFileStatus)
        Me.Controls.Add(Me.llblEmailSupport)
        Me.Controls.Add(Me.llblEmailCustSv)
        Me.Controls.Add(Me.llblSalesMeeting)
        Me.Controls.Add(Me.llblStCroixKnits)
        Me.Controls.Add(Me.llblStCroix)
        Me.Controls.Add(Me.llblEmailAppointments)
        Me.Controls.Add(Me.lblShowAppointments)
        Me.Controls.Add(Me.lblQuickAppt)
        Me.Controls.Add(Me.llblGotoNextWeekAppt)
        Me.Controls.Add(Me.llblGotoThisWeekAppt)
        Me.Controls.Add(Me.llblGotoPreviousWeekAppt)
        Me.Controls.Add(Me.cmdAddAppt)
        Me.Controls.Add(Me.chkAlwaysShowAppts)
        Me.Controls.Add(Me.cmdWkstNotOnOrder)
        Me.Controls.Add(Me.cmdWkstWithNoResponse)
        Me.Controls.Add(Me.cmdWkstNotTrans)
        Me.Controls.Add(Me.cmdWkstErr)
        Me.Controls.Add(Me.cmdFilesToImport)
        Me.Controls.Add(Me.cmdFilesToXmit)
        Me.Controls.Add(Me.lblTitanStatus)
        Me.Controls.Add(Me.lblInternetStatus)
        Me.Controls.Add(Me.lblCustAddress)
        Me.Controls.Add(Me.lblAlwaysShowAppts)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MainMenu1)
        Me.Controls.Add(Me.lblcalendarmonth)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMainScreen"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "St. Croix Sales Automation"
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        CType(Me.bndCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleForcDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSocialMedia.ResumeLayout(False)
        CType(Me.pbYouTube, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGooglePlus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPinterest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTwitter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFacebook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
#Region "Upgrade Support"
    Friend WithEvents lblQuickAppt As System.Windows.Forms.LinkLabel
    Friend WithEvents lblShowAppointments As System.Windows.Forms.LinkLabel
    Friend WithEvents llblStCroix As System.Windows.Forms.LinkLabel
    Friend WithEvents llblStCroixKnits As System.Windows.Forms.LinkLabel
    Friend WithEvents llblSalesMeeting As System.Windows.Forms.LinkLabel
    Friend WithEvents llblEmailCustSv As System.Windows.Forms.LinkLabel
    Friend WithEvents llblEmailSupport As System.Windows.Forms.LinkLabel
    Friend WithEvents lblTitanFileStatus As System.Windows.Forms.LinkLabel
    Friend WithEvents bndCustomers As System.Windows.Forms.BindingSource
    Friend WithEvents SaleForcDataSet As KC01.SaleForcDataSet
    Friend WithEvents CustomerTableAdapter As KC01.SaleForcDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblConnectionStatus As System.Windows.Forms.Label
    Public WithEvents lblCustAddress As System.Windows.Forms.Label
    Public WithEvents cmdAddAppt As System.Windows.Forms.Button
    Friend WithEvents cmbAppt As System.Windows.Forms.ComboBox
    Friend WithEvents chkViewActiveCustomers As System.Windows.Forms.CheckBox
    Public WithEvents lblAlwaysShowAppts As System.Windows.Forms.Label
    Public WithEvents chkAlwaysShowAppts As System.Windows.Forms.CheckBox
    Friend WithEvents llblGotoPreviousWeekAppt As System.Windows.Forms.LinkLabel
    Friend WithEvents llblGotoThisWeekAppt As System.Windows.Forms.LinkLabel
    Friend WithEvents llblGotoNextWeekAppt As System.Windows.Forms.LinkLabel
    Friend WithEvents llblEmailAppointments As System.Windows.Forms.LinkLabel
    Friend WithEvents DayView1 As Calendar.DayView
    Friend WithEvents lblcalendarmonth As System.Windows.Forms.Label
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents pnlSocialMedia As System.Windows.Forms.Panel
    Friend WithEvents pbPinterest As System.Windows.Forms.PictureBox
    Friend WithEvents pbTwitter As System.Windows.Forms.PictureBox
    Friend WithEvents pbFacebook As System.Windows.Forms.PictureBox
    Friend WithEvents mnuDatabase As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pbYouTube As System.Windows.Forms.PictureBox
    Friend WithEvents pbGooglePlus As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MnuMailTest As System.Windows.Forms.ToolStripMenuItem
#End Region
End Class