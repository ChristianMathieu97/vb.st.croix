<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCustShipUpdate
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
	Public WithEvents txtEmail As System.Windows.Forms.TextBox
	Public WithEvents txtAdditionalInformation As System.Windows.Forms.TextBox
	Public WithEvents txtWebsite As System.Windows.Forms.TextBox
	Public WithEvents txtName As System.Windows.Forms.TextBox
	Public WithEvents txtAddr1 As System.Windows.Forms.TextBox
	Public WithEvents txtAddr2 As System.Windows.Forms.TextBox
	Public WithEvents txtAddr3 As System.Windows.Forms.TextBox
	Public WithEvents txtState As System.Windows.Forms.TextBox
	Public WithEvents txtCity As System.Windows.Forms.TextBox
	Public WithEvents txtZipCode As System.Windows.Forms.TextBox
	Public WithEvents txtCountry As System.Windows.Forms.TextBox
	Public WithEvents Frame5 As System.Windows.Forms.GroupBox
	Public WithEvents txtContactEmail As System.Windows.Forms.TextBox
	Public WithEvents txtPhoneNo As System.Windows.Forms.TextBox
	Public WithEvents txtFaxNo As System.Windows.Forms.TextBox
	Public WithEvents txtContact As System.Windows.Forms.TextBox
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label47 As System.Windows.Forms.Label
	Public WithEvents Label48 As System.Windows.Forms.Label
	Public WithEvents Label49 As System.Windows.Forms.Label
	Public WithEvents Frame4 As System.Windows.Forms.GroupBox
	Public WithEvents cmdUpdate As System.Windows.Forms.Button
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label57 As System.Windows.Forms.Label
	Public WithEvents Label56 As System.Windows.Forms.Label
	Public WithEvents Label55 As System.Windows.Forms.Label
	Public WithEvents Label54 As System.Windows.Forms.Label
	Public WithEvents Label53 As System.Windows.Forms.Label
	Public WithEvents Label52 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame5 = New System.Windows.Forms.GroupBox
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.txtAdditionalInformation = New System.Windows.Forms.TextBox
        Me.txtWebsite = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.txtAddr1 = New System.Windows.Forms.TextBox
        Me.txtAddr2 = New System.Windows.Forms.TextBox
        Me.txtAddr3 = New System.Windows.Forms.TextBox
        Me.txtState = New System.Windows.Forms.TextBox
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.txtZipCode = New System.Windows.Forms.TextBox
        Me.txtCountry = New System.Windows.Forms.TextBox
        Me.Frame4 = New System.Windows.Forms.GroupBox
        Me.txtContactEmail = New System.Windows.Forms.TextBox
        Me.txtPhoneNo = New System.Windows.Forms.TextBox
        Me.txtFaxNo = New System.Windows.Forms.TextBox
        Me.txtContact = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.cmdUpdate = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label57 = New System.Windows.Forms.Label
        Me.Label56 = New System.Windows.Forms.Label
        Me.Label55 = New System.Windows.Forms.Label
        Me.Label54 = New System.Windows.Forms.Label
        Me.Label53 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.Frame5.SuspendLayout()
        Me.Frame4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame5
        '
        Me.Frame5.BackColor = System.Drawing.SystemColors.Control
        Me.Frame5.Controls.Add(Me.txtEmail)
        Me.Frame5.Controls.Add(Me.txtAdditionalInformation)
        Me.Frame5.Controls.Add(Me.txtWebsite)
        Me.Frame5.Controls.Add(Me.txtName)
        Me.Frame5.Controls.Add(Me.txtAddr1)
        Me.Frame5.Controls.Add(Me.txtAddr2)
        Me.Frame5.Controls.Add(Me.txtAddr3)
        Me.Frame5.Controls.Add(Me.txtState)
        Me.Frame5.Controls.Add(Me.txtCity)
        Me.Frame5.Controls.Add(Me.txtZipCode)
        Me.Frame5.Controls.Add(Me.txtCountry)
        Me.Frame5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame5.ForeColor = System.Drawing.Color.Blue
        Me.Frame5.Location = New System.Drawing.Point(128, 16)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame5.Size = New System.Drawing.Size(281, 265)
        Me.Frame5.TabIndex = 0
        Me.Frame5.TabStop = False
        Me.Frame5.Text = " CUSTOMER SHIPPING ADDRESS "
        '
        'txtEmail
        '
        Me.txtEmail.AcceptsReturn = True
        Me.txtEmail.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEmail.Location = New System.Drawing.Point(8, 184)
        Me.txtEmail.MaxLength = 0
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEmail.Size = New System.Drawing.Size(265, 20)
        Me.txtEmail.TabIndex = 10
        '
        'txtAdditionalInformation
        '
        Me.txtAdditionalInformation.AcceptsReturn = True
        Me.txtAdditionalInformation.BackColor = System.Drawing.SystemColors.Window
        Me.txtAdditionalInformation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAdditionalInformation.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdditionalInformation.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAdditionalInformation.Location = New System.Drawing.Point(8, 216)
        Me.txtAdditionalInformation.MaxLength = 0
        Me.txtAdditionalInformation.Multiline = True
        Me.txtAdditionalInformation.Name = "txtAdditionalInformation"
        Me.txtAdditionalInformation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAdditionalInformation.Size = New System.Drawing.Size(265, 33)
        Me.txtAdditionalInformation.TabIndex = 11
        '
        'txtWebsite
        '
        Me.txtWebsite.AcceptsReturn = True
        Me.txtWebsite.BackColor = System.Drawing.SystemColors.Window
        Me.txtWebsite.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWebsite.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWebsite.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWebsite.Location = New System.Drawing.Point(112, 152)
        Me.txtWebsite.MaxLength = 0
        Me.txtWebsite.Name = "txtWebsite"
        Me.txtWebsite.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWebsite.Size = New System.Drawing.Size(161, 20)
        Me.txtWebsite.TabIndex = 9
        '
        'txtName
        '
        Me.txtName.AcceptsReturn = True
        Me.txtName.BackColor = System.Drawing.SystemColors.Window
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtName.Location = New System.Drawing.Point(8, 16)
        Me.txtName.MaxLength = 0
        Me.txtName.Name = "txtName"
        Me.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtName.Size = New System.Drawing.Size(265, 20)
        Me.txtName.TabIndex = 1
        '
        'txtAddr1
        '
        Me.txtAddr1.AcceptsReturn = True
        Me.txtAddr1.BackColor = System.Drawing.SystemColors.Window
        Me.txtAddr1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddr1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddr1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAddr1.Location = New System.Drawing.Point(8, 40)
        Me.txtAddr1.MaxLength = 0
        Me.txtAddr1.Name = "txtAddr1"
        Me.txtAddr1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAddr1.Size = New System.Drawing.Size(265, 20)
        Me.txtAddr1.TabIndex = 2
        '
        'txtAddr2
        '
        Me.txtAddr2.AcceptsReturn = True
        Me.txtAddr2.BackColor = System.Drawing.SystemColors.Window
        Me.txtAddr2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddr2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddr2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAddr2.Location = New System.Drawing.Point(8, 64)
        Me.txtAddr2.MaxLength = 0
        Me.txtAddr2.Name = "txtAddr2"
        Me.txtAddr2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAddr2.Size = New System.Drawing.Size(265, 20)
        Me.txtAddr2.TabIndex = 3
        '
        'txtAddr3
        '
        Me.txtAddr3.AcceptsReturn = True
        Me.txtAddr3.BackColor = System.Drawing.SystemColors.Window
        Me.txtAddr3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddr3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddr3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAddr3.Location = New System.Drawing.Point(8, 88)
        Me.txtAddr3.MaxLength = 0
        Me.txtAddr3.Name = "txtAddr3"
        Me.txtAddr3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAddr3.Size = New System.Drawing.Size(265, 20)
        Me.txtAddr3.TabIndex = 4
        '
        'txtState
        '
        Me.txtState.AcceptsReturn = True
        Me.txtState.BackColor = System.Drawing.SystemColors.Window
        Me.txtState.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtState.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtState.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtState.Location = New System.Drawing.Point(144, 120)
        Me.txtState.MaxLength = 0
        Me.txtState.Name = "txtState"
        Me.txtState.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtState.Size = New System.Drawing.Size(33, 20)
        Me.txtState.TabIndex = 6
        '
        'txtCity
        '
        Me.txtCity.AcceptsReturn = True
        Me.txtCity.BackColor = System.Drawing.SystemColors.Window
        Me.txtCity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCity.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCity.Location = New System.Drawing.Point(8, 120)
        Me.txtCity.MaxLength = 0
        Me.txtCity.Name = "txtCity"
        Me.txtCity.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCity.Size = New System.Drawing.Size(129, 20)
        Me.txtCity.TabIndex = 5
        '
        'txtZipCode
        '
        Me.txtZipCode.AcceptsReturn = True
        Me.txtZipCode.BackColor = System.Drawing.SystemColors.Window
        Me.txtZipCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtZipCode.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZipCode.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtZipCode.Location = New System.Drawing.Point(184, 120)
        Me.txtZipCode.MaxLength = 0
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtZipCode.Size = New System.Drawing.Size(89, 20)
        Me.txtZipCode.TabIndex = 7
        '
        'txtCountry
        '
        Me.txtCountry.AcceptsReturn = True
        Me.txtCountry.BackColor = System.Drawing.SystemColors.Window
        Me.txtCountry.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCountry.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCountry.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCountry.Location = New System.Drawing.Point(8, 152)
        Me.txtCountry.MaxLength = 0
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCountry.Size = New System.Drawing.Size(97, 20)
        Me.txtCountry.TabIndex = 8
        '
        'Frame4
        '
        Me.Frame4.BackColor = System.Drawing.SystemColors.Control
        Me.Frame4.Controls.Add(Me.txtContactEmail)
        Me.Frame4.Controls.Add(Me.txtPhoneNo)
        Me.Frame4.Controls.Add(Me.txtFaxNo)
        Me.Frame4.Controls.Add(Me.txtContact)
        Me.Frame4.Controls.Add(Me.Label3)
        Me.Frame4.Controls.Add(Me.Label47)
        Me.Frame4.Controls.Add(Me.Label48)
        Me.Frame4.Controls.Add(Me.Label49)
        Me.Frame4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame4.ForeColor = System.Drawing.Color.Blue
        Me.Frame4.Location = New System.Drawing.Point(128, 288)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame4.Size = New System.Drawing.Size(281, 113)
        Me.Frame4.TabIndex = 0
        Me.Frame4.TabStop = False
        Me.Frame4.Text = " Contact information: Shipping Address"
        '
        'txtContactEmail
        '
        Me.txtContactEmail.AcceptsReturn = True
        Me.txtContactEmail.BackColor = System.Drawing.SystemColors.Window
        Me.txtContactEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContactEmail.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactEmail.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtContactEmail.Location = New System.Drawing.Point(88, 80)
        Me.txtContactEmail.MaxLength = 0
        Me.txtContactEmail.Name = "txtContactEmail"
        Me.txtContactEmail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtContactEmail.Size = New System.Drawing.Size(177, 20)
        Me.txtContactEmail.TabIndex = 15
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.AcceptsReturn = True
        Me.txtPhoneNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtPhoneNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPhoneNo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPhoneNo.Location = New System.Drawing.Point(88, 16)
        Me.txtPhoneNo.MaxLength = 0
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPhoneNo.Size = New System.Drawing.Size(177, 20)
        Me.txtPhoneNo.TabIndex = 12
        '
        'txtFaxNo
        '
        Me.txtFaxNo.AcceptsReturn = True
        Me.txtFaxNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtFaxNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFaxNo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFaxNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFaxNo.Location = New System.Drawing.Point(88, 37)
        Me.txtFaxNo.MaxLength = 0
        Me.txtFaxNo.Name = "txtFaxNo"
        Me.txtFaxNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFaxNo.Size = New System.Drawing.Size(177, 20)
        Me.txtFaxNo.TabIndex = 13
        '
        'txtContact
        '
        Me.txtContact.AcceptsReturn = True
        Me.txtContact.BackColor = System.Drawing.SystemColors.Window
        Me.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContact.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtContact.Location = New System.Drawing.Point(88, 59)
        Me.txtContact.MaxLength = 0
        Me.txtContact.Name = "txtContact"
        Me.txtContact.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtContact.Size = New System.Drawing.Size(177, 20)
        Me.txtContact.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(16, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Email:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label47
        '
        Me.Label47.BackColor = System.Drawing.SystemColors.Control
        Me.Label47.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label47.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label47.Location = New System.Drawing.Point(8, 17)
        Me.Label47.Name = "Label47"
        Me.Label47.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label47.Size = New System.Drawing.Size(73, 17)
        Me.Label47.TabIndex = 0
        Me.Label47.Text = "Telephone:"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.SystemColors.Control
        Me.Label48.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label48.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label48.Location = New System.Drawing.Point(32, 41)
        Me.Label48.Name = "Label48"
        Me.Label48.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label48.Size = New System.Drawing.Size(49, 17)
        Me.Label48.TabIndex = 0
        Me.Label48.Text = "Fax:"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.SystemColors.Control
        Me.Label49.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label49.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label49.Location = New System.Drawing.Point(16, 63)
        Me.Label49.Name = "Label49"
        Me.Label49.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label49.Size = New System.Drawing.Size(65, 17)
        Me.Label49.TabIndex = 0
        Me.Label49.Text = "Contact:"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmdUpdate
        '
        Me.cmdUpdate.BackColor = System.Drawing.SystemColors.Control
        Me.cmdUpdate.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdUpdate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdUpdate.Location = New System.Drawing.Point(128, 416)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdUpdate.Size = New System.Drawing.Size(97, 33)
        Me.cmdUpdate.TabIndex = 25
        Me.cmdUpdate.Text = "&Update"
        Me.cmdUpdate.UseVisualStyleBackColor = False
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Location = New System.Drawing.Point(312, 416)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(97, 33)
        Me.cmdCancel.TabIndex = 27
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(72, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(41, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Email:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(40, 232)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(73, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Additional Information:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label57
        '
        Me.Label57.BackColor = System.Drawing.SystemColors.Control
        Me.Label57.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label57.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label57.Location = New System.Drawing.Point(40, 32)
        Me.Label57.Name = "Label57"
        Me.Label57.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label57.Size = New System.Drawing.Size(73, 17)
        Me.Label57.TabIndex = 0
        Me.Label57.Text = "Name:"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label56
        '
        Me.Label56.BackColor = System.Drawing.SystemColors.Control
        Me.Label56.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label56.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label56.Location = New System.Drawing.Point(40, 80)
        Me.Label56.Name = "Label56"
        Me.Label56.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label56.Size = New System.Drawing.Size(73, 17)
        Me.Label56.TabIndex = 0
        Me.Label56.Text = "Address - 2:"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.SystemColors.Control
        Me.Label55.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label55.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label55.Location = New System.Drawing.Point(40, 56)
        Me.Label55.Name = "Label55"
        Me.Label55.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label55.Size = New System.Drawing.Size(73, 17)
        Me.Label55.TabIndex = 0
        Me.Label55.Text = "Address - 1:"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.SystemColors.Control
        Me.Label54.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label54.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label54.Location = New System.Drawing.Point(40, 136)
        Me.Label54.Name = "Label54"
        Me.Label54.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label54.Size = New System.Drawing.Size(73, 17)
        Me.Label54.TabIndex = 0
        Me.Label54.Text = "City, St, Zip:"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.SystemColors.Control
        Me.Label53.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label53.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label53.Location = New System.Drawing.Point(40, 104)
        Me.Label53.Name = "Label53"
        Me.Label53.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label53.Size = New System.Drawing.Size(73, 17)
        Me.Label53.TabIndex = 0
        Me.Label53.Text = "Address - 3:"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.SystemColors.Control
        Me.Label52.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label52.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label52.Location = New System.Drawing.Point(8, 168)
        Me.Label52.Name = "Label52"
        Me.Label52.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label52.Size = New System.Drawing.Size(105, 17)
        Me.Label52.TabIndex = 0
        Me.Label52.Text = "Country; Website:"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmCustShipUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(442, 461)
        Me.Controls.Add(Me.Frame5)
        Me.Controls.Add(Me.Frame4)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label57)
        Me.Controls.Add(Me.Label56)
        Me.Controls.Add(Me.Label55)
        Me.Controls.Add(Me.Label54)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.Label52)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "frmCustShipUpdate"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Ship To Update"
        Me.Frame5.ResumeLayout(False)
        Me.Frame5.PerformLayout()
        Me.Frame4.ResumeLayout(False)
        Me.Frame4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class