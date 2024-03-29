Option Strict Off
Option Explicit On
Friend Class frmCustShipUpdate
    Inherits System.Windows.Forms.Form

    ''' <summary>
    ''' This procedure closes the form
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		Me.Close()
    End Sub

    ''' <summary>
    ''' This procedure creates an Excel spreadsheet with customer ship to data for the current customer.  It then sends an email with the 
    ''' spreadsheet in the body of the email to the email address identified in the 'CustomerServiceEmail' field in the 'Defaults' table
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
	
	Private Sub cmdUpdate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdUpdate.Click
		Dim recipient As String
		Dim subject As String
        Dim xl As New Microsoft.Office.Interop.Excel.Application
        Dim xlwbooks As Microsoft.Office.Interop.Excel.Workbooks
        Dim xlwbook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlsheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim style As Microsoft.Office.Interop.Excel.Style
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        xlwbooks = xl.Workbooks
        xlwbook = xlwbooks.Add
        xlsheet = xlwbook.ActiveSheet

        ' format cells as text so that text aligns on the left side of the cell

        style = xlwbook.Styles.Add("Styles1")
        style.NumberFormat = "@"

        xlsheet.Range("A1:C17").Style = style

        recipient = GetProgramDefaults("CustomerServiceEmail")
		
        subject = "Customer Ship-to Information Changes - " & frmCustInfo.bndCustomer.Current("name") & " (" & frmCustInfo.bndCustomerShip.Current("cust-no") & ")"

        xlsheet.Cells.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium
        xlsheet.Hyperlinks.Delete()
        'set up column headers

        xlsheet.Cells(1, 2).value = "Old Information"
        xlsheet.Cells(1, 3).value = "New Information"

        ' set up row headers

        xlsheet.Cells(3, 1).value = "Ship Number"
        xlsheet.Cells(4, 1).value = "Name"
        xlsheet.Cells(5, 1).value = "Address 1"
        xlsheet.Cells(6, 1).value = "Address 2"
        xlsheet.Cells(7, 1).value = "Address 3"
        xlsheet.Cells(8, 1).value = "City"
        xlsheet.Cells(9, 1).value = "State"
        xlsheet.Cells(10, 1).value = "Zip Code"
        xlsheet.Cells(11, 1).value = "Country"
        xlsheet.Cells(12, 1).value = "Email"
        xlsheet.Cells(13, 1).value = "Contact Telephone"
        xlsheet.Cells(14, 1).value = "Contact Fax"
        xlsheet.Cells(15, 1).value = "Contact Email"
        xlsheet.Cells(16, 1).value = "Contact"

        ' display the data

        xlsheet.Cells(3, 2).value = frmCustInfo.bndCustomerShip.Current("cust-sh")
        xlsheet.Cells(3, 3).value = frmCustInfo.bndCustomerShip.Current("cust-sh")

        xlsheet.Cells(4, 2).value = frmCustInfo.bndCustomerShip.Current("name")
        xlsheet.Cells(4, 3).value = txtName.Text
        If Trim(Nz(frmCustInfo.bndCustomerShip.Current("name"))) <> Trim(Nz(txtName.Text)) Then xlsheet.Range("C4").Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Red)

        xlsheet.Cells(5, 2).value = frmCustInfo.bndCustomerShip.Current("address1")
        xlsheet.Cells(5, 3).value = txtAddr1.Text
        If Trim(Nz(frmCustInfo.bndCustomerShip.Current("address1"))) <> Trim(Nz(txtAddr1.Text)) Then xlsheet.Range("C5").Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Red)

        xlsheet.Cells(6, 2).value = frmCustInfo.bndCustomerShip.Current("address2")
        xlsheet.Cells(6, 3).value = txtAddr2.Text
        If Trim(Nz(frmCustInfo.bndCustomerShip.Current("address2"))) <> Trim(Nz(txtAddr2.Text)) Then xlsheet.Range("C6").Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Red)

        xlsheet.Cells(7, 2).value = frmCustInfo.bndCustomerShip.Current("address3")
        xlsheet.Cells(7, 3).value = txtAddr3.Text
        If Trim(Nz(frmCustInfo.bndCustomerShip.Current("address3"))) <> Trim(Nz(txtAddr3.Text)) Then xlsheet.Range("C7").Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Red)

        xlsheet.Cells(8, 2).value = frmCustInfo.bndCustomerShip.Current("city")
        xlsheet.Cells(8, 3).value = txtCity.Text
        If Trim(Nz(frmCustInfo.bndCustomerShip.Current("city"))) <> Trim(Nz(txtCity.Text)) Then xlsheet.Range("C8").Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Red)

        xlsheet.Cells(9, 2).value = frmCustInfo.bndCustomerShip.Current("st")
        xlsheet.Cells(9, 3).value = txtState.Text
        If Trim(Nz(frmCustInfo.bndCustomerShip.Current("st"))) <> Trim(Nz(txtState.Text)) Then xlsheet.Range("C9").Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Red)

        xlsheet.Cells(10, 2).value = frmCustInfo.bndCustomerShip.Current("zip-code")
        xlsheet.Cells(10, 3).value = txtZipCode.Text
        If Trim(Nz(frmCustInfo.bndCustomerShip.Current("zip-code"))) <> Trim(Nz(txtZipCode.Text)) Then xlsheet.Range("C10").Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Red)

        xlsheet.Cells(11, 2).value = frmCustInfo.bndCustomerShip.Current("country")
        xlsheet.Cells(11, 3).value = txtCountry.Text
        If Trim(Nz(frmCustInfo.bndCustomerShip.Current("country"))) <> Trim(Nz(txtCountry.Text)) Then xlsheet.Range("C11").Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Red)

        xlsheet.Cells(12, 2).value = frmCustInfo.bndCustomerShip.Current("email")
        xlsheet.Cells(12, 3).value = txtEmail.Text
        If Trim(Nz(frmCustInfo.bndCustomerShip.Current("email"))) <> Trim(Nz(txtEmail.Text)) Then xlsheet.Range("C12").Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Red)

        xlsheet.Cells(13, 2).value = frmCustInfo.bndCustomerShip.Current("telephone")
        xlsheet.Cells(13, 3).value = txtPhoneNo.Text
        If Trim(Nz(frmCustInfo.bndCustomerShip.Current("telephone"))) <> Trim(Nz(txtPhoneNo.Text)) Then xlsheet.Range("C13").Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Red)

        xlsheet.Cells(14, 2).value = frmCustInfo.bndCustomerShip.Current("fax-num")
        xlsheet.Cells(14, 3).value = txtFaxNo.Text
        If Trim(Nz(frmCustInfo.bndCustomerShip.Current("fax-num"))) <> Trim(Nz(txtFaxNo.Text)) Then xlsheet.Range("C14").Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Red)

        xlsheet.Cells(15, 2).value = frmCustInfo.bndCustomerShip.Current("contact-email")
        xlsheet.Cells(15, 3).value = txtContactEmail.Text
        If Trim(Nz(frmCustInfo.bndCustomerShip.Current("contact-email"))) <> Trim(Nz(txtContactEmail.Text)) Then xlsheet.Range("C15").Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Red)

        xlsheet.Cells(16, 2).value = frmCustInfo.bndCustomerShip.Current("contact")
        xlsheet.Cells(16, 3).value = txtContact.Text
        If Trim(Nz(frmCustInfo.bndCustomerShip.Current("contact"))) <> Trim(Nz(txtContact.Text)) Then xlsheet.Range("C16").Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Red)

        xlsheet.Cells.Columns("A:C").AutoFit()

        If txtAdditionalInformation.TextLength > 0 Then
            xlsheet.Cells(17, 1).value = "Additional Information:"
            xlsheet.Cells(17, 3).value = txtAdditionalInformation.Text
            xlsheet.Range("A17").WrapText = True
            xlsheet.Range("C17").WrapText = True
            xlsheet.Cells(18, 1).value = "NOTE: Cells with red background indicate changes"
            xlsheet.Range("A18").Font.Italic = True
            xlsheet.Range("A18").Font.Color = System.Drawing.ColorTranslator.ToOle(Color.Red)
            xlsheet.Range("A18").WrapText = True
            xlsheet.Range("A18").Columns.AutoFit()
        Else
            xlsheet.Cells(17, 1).value = "NOTE: Cells with red background indicate changes"
            xlsheet.Range("A17").Font.Italic = True
            xlsheet.Range("A17").Font.Color = System.Drawing.ColorTranslator.ToOle(Color.Red)
            xlsheet.Range("A17").WrapText = True
            xlsheet.Range("A17").Columns.AutoFit()
        End If

        xlsheet.MailEnvelope.Item.To = recipient
        xlsheet.MailEnvelope.Item.subject = "Customer Ship To Information Changes - " & frmCustInfo.bndCustomer.Current("name") & " (" & frmCustInfo.bndCustomer.Current("cust-no") & ")"

        xlsheet.MailEnvelope.Item.send()

        xlwbook.Close(False)

        xl.Quit()
        System.Runtime.InteropServices.Marshal.FinalReleaseComObject(xl)
        xlsheet = Nothing
        xlwbook = Nothing
        xl = Nothing


        Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.Hide()
		Me.Close()
    End Sub

    ''' <summary>
    ''' This procedure populates the forms controls with the information from the current Customer ship to record
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
	
	Private Sub frmCustShipUpdate_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        txtName.Text = frmCustInfo.bndCustomerShip.Current("name").ToString
        txtAddr1.Text = frmCustInfo.bndCustomerShip.Current("address1").ToString
        txtAddr2.Text = frmCustInfo.bndCustomerShip.Current("address2").ToString
        txtAddr3.Text = frmCustInfo.bndCustomerShip.Current("address3").ToString
        txtCity.Text = frmCustInfo.bndCustomerShip.Current("city").ToString
        txtState.Text = frmCustInfo.bndCustomerShip.Current("st").ToString
        txtZipCode.Text = frmCustInfo.bndCustomerShip.Current("zip-code").ToString
        txtPhoneNo.Text = frmCustInfo.bndCustomerShip.Current("telephone").ToString
        txtFaxNo.Text = frmCustInfo.bndCustomerShip.Current("fax-num").ToString
        txtContact.Text = frmCustInfo.bndCustomerShip.Current("contact").ToString
        txtCountry.Text = frmCustInfo.bndCustomerShip.Current("country").ToString
        If IsDBNull(frmCustInfo.bndCustomerShip.Current("email")) Then
            txtEmail.Text = ""
        Else
            txtEmail.Text = frmCustInfo.bndCustomerShip.Current("email").ToString
        End If
        If IsDBNull(frmCustInfo.bndCustomerShip.Current("contact-email")) Then
            txtContactEmail.Text = ""
        Else
            txtContactEmail.Text = frmCustInfo.bndCustomerShip.Current("contact-email").ToString
        End If
        If IsDBNull(frmCustInfo.bndCustomerShip.Current("website")) Then
            txtWebsite.Text = ""
        Else
            txtWebsite.Text = frmCustInfo.bndCustomerShip.Current("website").ToString
        End If
	End Sub
End Class