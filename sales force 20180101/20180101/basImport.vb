Option Strict Off
Option Explicit On
Imports System
Imports System.IO

Module basImport

    '------------------------------------
    '   Code routines to handle data import
    '       (e.g., extract files)
    '-------------------------------------

    'Dim ImpBuf As Short 'Buffer Number for import file
    Dim sr As StreamReader
    Public constr As String = MySettings.Default("SaleForcConnectionString")
    Dim conn As ADODB.Connection
    Dim badfile As Boolean

    ''' <summary>
    ''' This procedure imports data into the database from the text files (.xtr files) that are transmitted from the Titan server
    ''' </summary>
    ''' <param name="ImportFileName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function ImportData(ByRef ImportFileName As String) As Boolean
        Dim Msg As String
        Dim cHdrLine As String
        Dim cFileName As String
        Dim cSalesNum As String
        Dim cSalesNam As String
        Dim vDateTime As String
        Dim cDir As String
        Dim cFirstHeading As String
        Dim junk As String
        cDir = cImportPath
        sr = New StreamReader(cDir & ImportFileName)
        conn = CreateObject("ADODB.Connection")
        conn.Provider = "Microsoft.Jet.OLEDB.4.0"
        conn.Open(dbName)

        ImportData = True

        'On Error GoTo ErrorHandler
        If FileLen(cDir & ImportFileName) = 0 Then
            Msg = "File " & ImportFileName & " is a Zero Byte file." & vbCrLf
            Msg = Msg & "It will not be processed and will be marked BAD" & vbCrLf & vbCrLf
            Msg = Msg & "Record file name above and Call Knitcraft MIS Immediately"
            MsgBox(Msg, MsgBoxStyle.Critical, "SEVERE WARNING")
            logFileAdd(2, "Zero byte file encountered: " & ImportFileName)
            ImportData = False
            Exit Function
        End If
        'ImpBuf = FreeFile()
        'FileOpen(ImpBuf, cDir & ImportFileName, OpenMode.Input)
        cFirstHeading = sr.ReadLine
        If UCase(cFirstHeading) <> "[FILEHEADER]" Then
            Msg = "Call Knitcraft Winona" & vbCrLf
            Msg = Msg & "an error was encountered in file:" & ImportFileName & vbCrLf
            Msg = Msg & "Updating will aborted the file marked BAD" & vbCrLf
            Msg = Msg & "Record file name above and Call Knitcraft MIS Immediately"
            MsgBox(Msg, MsgBoxStyle.Critical, "SEVERE WARNING")
            'FileClose(ImpBuf)
            logFileAdd(2, "No file header in: " & ImportFileName)
            ImportData = False
            Exit Function
        End If
        cFileName = sr.ReadLine
        cSalesNum = sr.ReadLine
        cSalesNam = sr.ReadLine
        vDateTime = sr.ReadLine

        junk = sr.ReadLine
        badfile = False

        Do Until sr.EndOfStream

            cHdrLine = sr.ReadLine

            Select UCase(cHdrLine)
                Case "[SALESMAN]"
                    impSalesman()
                Case "[COMMISSION]"
                    impCommission()
                Case "[CUSTOMER]"
                    impCustomer()
                Case "[CUSTOMER_M]"
                    impCustomerM()
                Case "[CUSTOMER-SH]"
                    impCustomerSH()
                Case "[ORDERHEAD]"
                    impOrderHead()
                Case "[ORDERLINE]"
                    impOrderLine()
                Case "[WORKSHEETHEAD]"
                    impWorksheetHead()
                Case "[WORKSHEETLINE]"
                    impWorksheetLine()
                Case "[WORKSHEETERROR]"
                    impWorksheetError()
                Case "[SHIPVIA]"
                    impShipvia()
                Case "[SEASON]"
                    impSeason()
                Case "[SEASONTYPE]"
                    impSeasonType()
                Case "[ORDERTYPE]"
                    impOrderType()
                Case "[CUSTSEASPROJ]"
                    impCustSeasProj()
                Case "[PRODUCTGROUP]"
                    impProductGroup()
                Case "[PRODUCTTYPE]"
                    impProductType()
                Case "[ATTRIB]"
                    impAttrib()
                Case "[PRODUCTGROUPATTRIB]"
                    impProductGroupAttrib()
                Case "[ITEM]"
                    impItem()
            End Select
            If badfile Then
                sr.Close()
                conn.Close()
                ImportData = False
                Exit Function
            End If
        Loop

        sr.Close()
        conn.Close()
    End Function

    ''' <summary>
    ''' This procedure imports data into the Salesman table
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub impSalesman()
        Try
            Dim cSlsmnCode As String
            Dim cName As String
            Dim cAddress1 As String
            Dim cAddress2 As String
            Dim cAddress3 As String
            Dim cCity As String
            Dim cSt As String
            Dim cZipCode As String
            Dim vReqDate As String
            Dim vComplDate As String
            Dim vCancelDate As String
            Dim cSeason As String
            Dim cOrderCd As String
            Dim vFmReqDate As String
            Dim vToReqDate As String
            Dim vFmCompDate As String
            Dim vToCompDate As String
            Dim vFmCancDate As String
            Dim vToCancDate As String
            Dim vLastUpdte As String
            Dim cSupportEmailAddr As String
            Dim mytable As New ADODB.Recordset

            cSlsmnCode = sr.ReadLine
            If Len(Trim(cSlsmnCode)) = 0 Then
                mytable.Close()
                Exit Sub
            End If

            cName = sr.ReadLine
            cAddress1 = sr.ReadLine
            cAddress2 = sr.ReadLine
            cAddress3 = sr.ReadLine
            cCity = sr.ReadLine
            cSt = sr.ReadLine
            cZipCode = sr.ReadLine
            vReqDate = sr.ReadLine
            vComplDate = sr.ReadLine
            vCancelDate = sr.ReadLine
            cSeason = sr.ReadLine
            cOrderCd = sr.ReadLine
            vFmReqDate = sr.ReadLine
            vToReqDate = sr.ReadLine
            vFmCompDate = sr.ReadLine
            vToCompDate = sr.ReadLine
            vFmCancDate = sr.ReadLine
            vToCancDate = sr.ReadLine
            vLastUpdte = sr.ReadLine
            cSupportEmailAddr = sr.ReadLine

            'Update the Salesman table

            mytable.CursorLocation = ADODB.CursorLocationEnum.adUseServer
            mytable.Open(tblSalesman, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTableDirect)
            mytable.Index = "PrimaryKey"

            mytable.Seek(cSlsmnCode, ADODB.SeekEnum.adSeekFirstEQ)

            If mytable.EOF Then
                mytable.AddNew()
                mytable.Fields("SlsmnCode").Value = Trim(cSlsmnCode)
            End If

            If mytable.Fields("WorksheetNo").Value < 1000 Then
                mytable.Fields("WorksheetNo").Value = 1000 'Initialize worksheet number if not at least 1000
            End If
            If mytable.Fields("ExportNo").Value < 1000 Then
                mytable.Fields("ExportNo").Value = 1000
            End If
            mytable.Fields("Name").Value = Trim(cName)
            mytable.Fields("Address1").Value = Trim(cAddress1)
            mytable.Fields("Address2").Value = Trim(cAddress2)
            mytable.Fields("Address3").Value = Trim(cAddress3)
            mytable.Fields("City").Value = Trim(cCity)
            mytable.Fields("St").Value = Trim(cSt)
            mytable.Fields("zip-code").Value = Trim(cZipCode)
            mytable.Fields("SupportEmailAddr").Value = Trim(cSupportEmailAddr)
            If IsDate(vReqDate) Then
                mytable.Fields("request-date").Value = vReqDate
            Else

                mytable.Fields("request-date").Value = System.DBNull.Value
            End If
            If IsDate(vComplDate) Then
                mytable.Fields("complete-date").Value = vComplDate
            Else

                mytable.Fields("complete-date").Value = System.DBNull.Value
            End If
            If IsDate(vCancelDate) Then
                mytable.Fields("cancel-date").Value = vCancelDate
            Else

                mytable.Fields("cancel-date").Value = System.DBNull.Value
            End If
            mytable.Fields("season").Value = Trim(cSeason)
            mytable.Fields("order-code").Value = Trim(cOrderCd)
            If IsDate(vFmReqDate) Then
                mytable.Fields("from-request-date").Value = vFmReqDate
            Else

                mytable.Fields("from-request-date").Value = System.DBNull.Value
            End If
            If IsDate(vToReqDate) Then
                mytable.Fields("to-request-date").Value = vToReqDate
            Else

                mytable.Fields("to-request-date").Value = System.DBNull.Value
            End If
            If IsDate(vFmCompDate) Then
                mytable.Fields("from-complete-date").Value = vFmCompDate
            Else

                mytable.Fields("from-complete-date").Value = System.DBNull.Value
            End If
            If IsDate(vToCompDate) Then
                mytable.Fields("to-complete-date").Value = vToCompDate
            Else

                mytable.Fields("to-complete-date").Value = System.DBNull.Value
            End If
            If IsDate(vFmCancDate) Then
                mytable.Fields("from-cancel-date").Value = vFmCancDate
            Else

                mytable.Fields("from-cancel-date").Value = System.DBNull.Value
            End If
            If IsDate(vToCancDate) Then
                mytable.Fields("to-cancel-date").Value = vToCancDate
            Else

                mytable.Fields("to-cancel-date").Value = System.DBNull.Value
            End If
            If IsDate(vLastUpdte) Then
                mytable.Fields("LastUpdated").Value = vLastUpdte
            Else

                mytable.Fields("LastUpdated").Value = System.DBNull.Value
            End If

            mytable.Update()
            mytable.Close()
            mytable = Nothing
        Catch
            badfile = True
        End Try
    End Sub

    ''' <summary>
    ''' This procedure imports data into the Ship Via table
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub impShipvia()
        Try
            Dim cViaCode As String
            Dim cViaDesc As String
            Dim cLastUpdated As String
            Dim mytable As New ADODB.Recordset

            mytable.CursorLocation = ADODB.CursorLocationEnum.adUseServer
            mytable.Open(tblShipViaCd, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTableDirect)
            mytable.Index = "ViaCode"

            Do While Not sr.EndOfStream
                cViaCode = sr.ReadLine
                If Len(Trim(cViaCode)) = 0 Then
                    mytable.Close()
                    Exit Sub
                End If
                cViaDesc = sr.ReadLine
                cLastUpdated = sr.ReadLine

                mytable.Seek(cViaCode, ADODB.SeekEnum.adSeekFirstEQ)

                If mytable.EOF Then
                    mytable.AddNew()
                    mytable.Fields("ViaCode").Value = cViaCode
                End If

                mytable.Fields("ViaDesc").Value = cViaDesc
                If IsDate(cLastUpdated) Then
                    mytable.Fields("LastUpdated").Value = cLastUpdated
                Else

                    mytable.Fields("LastUpdated").Value = System.DBNull.Value
                End If
                mytable.Update()
            Loop
        Catch
            badfile = True
        End Try
    End Sub

    ''' <summary>
    ''' This procedure imports data into the Commission table
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub impCommission()
        Try
            Dim cSalesmanCd As String
            Dim cCommCd As String
            Dim nCommRate As Double
            Dim cLastUpdate As String
            Dim mytable As New ADODB.Recordset

            mytable.CursorLocation = ADODB.CursorLocationEnum.adUseServer
            mytable.Open(tblCommission, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTableDirect)
            mytable.Index = "SalesmanCode"

            Do While Not sr.EndOfStream
                cSalesmanCd = sr.ReadLine
                If Len(Trim(cSalesmanCd)) = 0 Then
                    mytable.Close()
                    Exit Sub
                End If

                cCommCd = sr.ReadLine
                nCommRate = sr.ReadLine
                cLastUpdate = sr.ReadLine

                mytable.Seek(cSalesmanCd, ADODB.SeekEnum.adSeekFirstEQ)

                If mytable.EOF Then
                    mytable.AddNew()
                    mytable.Fields("slsmcode").Value = cSalesmanCd
                End If

                mytable.Fields("CommCode").Value = cCommCd
                mytable.Fields("CommRate").Value = nCommRate
                If IsDate(cLastUpdate) Then
                    mytable.Fields("LastUpdated").Value = cLastUpdate
                Else

                    mytable.Fields("LastUpdated").Value = System.DBNull.Value
                End If
                mytable.Update()
            Loop
        Catch
            badfile = True
        End Try
    End Sub

    ''' <summary>
    ''' This procedure imports data into the Customer table
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub impCustomer()
        Try
            Dim cCustNo As String
            Dim cName As String
            Dim cAddr1 As String
            Dim cAddr2 As String
            Dim cAddr3 As String
            Dim cCity As String
            Dim cSt As String
            Dim cZipCode As String
            Dim cCountry As String
            Dim cTelephone As String
            Dim cFaxNum As String
            Dim cContact As String
            Dim cStatusCode As String
            Dim cSalesmanCd As String
            Dim cTypeCode As String
            Dim cTermCode As String
            Dim cViaCode As String
            Dim cCreditRating As String
            Dim cChargeCust As String
            Dim cMailCust As String
            Dim cStatsCust As String
            Dim cSortName As String
            Dim cCustShip As String
            Dim cCustAddDate As String
            Dim cHoldArCode As String
            Dim cDelq As String
            Dim lDelq As Boolean
            Dim cSalesmanRating As String
            Dim cLastChgDate As String
            Dim nArBalance As Double
            Dim cLastPayDate As String
            Dim nLastPayAmt As Double
            Dim nAvgDaysPay As Integer
            Dim nOpenOrderTotal As Double
            Dim cLastOrdDate As String
            Dim cContactEmail As String
            Dim cEmail As String
            '    Dim cLabelNo As String
            Dim cLastUpdated As String
            Dim mytable As New ADODB.Recordset

            'Dim OutlookApp As Microsoft.Office.Interop.Outlook.Application
            'Dim OutlookNameSpace As Microsoft.Office.Interop.Outlook.NameSpace
            'Dim bolCustomerFolder As Boolean
            'Dim objFolder As Microsoft.Office.Interop.Outlook.MAPIFolder
            'Dim colFolders As Microsoft.Office.Interop.Outlook.Folders
            'Dim contacts As Microsoft.Office.Interop.Outlook.Items
            'Dim contact As Microsoft.Office.Interop.Outlook.ContactItem
            'Dim folder As Microsoft.Office.Interop.Outlook.MAPIFolder

            'OutlookApp = New Microsoft.Office.Interop.Outlook.Application
            'OutlookNameSpace = OutlookApp.GetNamespace("MAPI")
            'objFolder = OutlookNameSpace.GetDefaultFolder(Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderContacts)
            'colFolders = objFolder.Folders

            ' check if contacts folder "Customers" has been created

            'If colFolders.Count > 0 Then
            '    bolCustomerFolder = False
            '    For Each folder In colFolders
            '        If folder.Name = "Customers" Then
            '            bolCustomerFolder = True
            '        End If
            '    Next folder
            'End If

            ' create "Customers" folder if it doesn't exist

            'If Not bolCustomerFolder Then
            '    objFolder.Folders.Add("Customers")
            'End If

            ' make "Customers" the current folder

            'objFolder = colFolders("Customers")
            'objFolder.ShowAsOutlookAB = True
            'objFolder.AddressBookName = "Customers"

            'contacts = objFolder.Items

            mytable.CursorLocation = ADODB.CursorLocationEnum.adUseServer
            mytable.Open(tblCustomer, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTableDirect)
            mytable.Index = "CustNumber"

            Do While Not sr.EndOfStream

                cCustNo = sr.ReadLine
                If Len(Trim(cCustNo)) = 0 Then
                    mytable.Close()
                    Exit Sub
                End If
                cName = sr.ReadLine
                cAddr1 = sr.ReadLine
                cAddr2 = sr.ReadLine
                cAddr3 = sr.ReadLine
                cCity = sr.ReadLine
                cSt = sr.ReadLine
                cZipCode = sr.ReadLine
                cCountry = sr.ReadLine
                cTelephone = sr.ReadLine
                cFaxNum = sr.ReadLine
                cContact = sr.ReadLine
                cStatusCode = sr.ReadLine
                cSalesmanCd = sr.ReadLine
                cTypeCode = sr.ReadLine
                cTermCode = sr.ReadLine
                cViaCode = sr.ReadLine
                cCreditRating = sr.ReadLine
                cChargeCust = sr.ReadLine
                cMailCust = sr.ReadLine
                cStatsCust = sr.ReadLine
                cSortName = sr.ReadLine
                cCustShip = sr.ReadLine
                cCustAddDate = sr.ReadLine
                cHoldArCode = sr.ReadLine
                cDelq = sr.ReadLine
                If Left(UCase(cDelq), 1) = "Y" Then
                    lDelq = True
                Else
                    lDelq = False
                End If

                cSalesmanRating = sr.ReadLine
                cLastChgDate = sr.ReadLine
                nArBalance = sr.ReadLine
                cLastPayDate = sr.ReadLine
                nLastPayAmt = sr.ReadLine
                nAvgDaysPay = sr.ReadLine
                nOpenOrderTotal = sr.ReadLine
                cLastOrdDate = sr.ReadLine
                '        Line Input #ImpBuf, cLabelNo
                cLastUpdated = sr.ReadLine
                cContactEmail = sr.ReadLine
                cEmail = sr.ReadLine

                mytable.Seek(cCustNo, ADODB.SeekEnum.adSeekFirstEQ)

                If mytable.EOF Then
                    mytable.AddNew()
                    mytable.Fields("cust-no").Value = Trim(cCustNo)
                End If

                mytable.Fields("name").Value = Trim(cName)
                mytable.Fields("Address1").Value = Trim(cAddr1)
                mytable.Fields("Address2").Value = Trim(cAddr2)
                mytable.Fields("Address3").Value = Trim(cAddr3)
                mytable.Fields("city").Value = Trim(cCity)
                mytable.Fields("St").Value = cSt
                mytable.Fields("Zip-code").Value = cZipCode
                mytable.Fields("Country").Value = Trim(cCountry)
                mytable.Fields("Telephone").Value = cTelephone
                mytable.Fields("Fax-num").Value = cFaxNum
                mytable.Fields("contact").Value = Trim(cContact)
                mytable.Fields("status-code").Value = cStatusCode
                mytable.Fields("slsmn-code").Value = cSalesmanCd
                mytable.Fields("type-code").Value = cTypeCode
                mytable.Fields("term-code").Value = cTermCode
                mytable.Fields("via-code").Value = cViaCode
                mytable.Fields("cred-rating").Value = cCreditRating
                mytable.Fields("charge-cust").Value = cChargeCust
                mytable.Fields("mail-cust").Value = cMailCust
                mytable.Fields("stats-cust").Value = cStatsCust
                mytable.Fields("sort-name").Value = cSortName
                mytable.Fields("cust-sh").Value = cCustShip
                If IsDate(cCustAddDate) Then
                    mytable.Fields("cust-addate").Value = Trim(cCustAddDate)
                Else
                    mytable.Fields("cust-addate").Value = System.DBNull.Value
                End If
                mytable.Fields("hold-ar-code").Value = cHoldArCode
                mytable.Fields("delq").Value = lDelq
                mytable.Fields("slsmn-rating").Value = cSalesmanRating
                If Len(Trim(cLastChgDate)) = 0 Or IsDBNull(cLastChgDate) Then
                    mytable.Fields("last-chg-date").Value = System.DBNull.Value
                Else
                    mytable.Fields("last-chg-date").Value = Trim(cLastChgDate)
                End If
                mytable.Fields("Arbalance").Value = nArBalance

                If Len(Trim(cLastPayDate)) = 0 Or IsDBNull(cLastPayDate) Then
                    mytable.Fields("LastPayDate").Value = System.DBNull.Value
                Else
                    mytable.Fields("LastPayDate").Value = Trim(cLastPayDate)
                End If
                mytable.Fields("LastPayAmt").Value = nLastPayAmt
                mytable.Fields("AvgDaysPay").Value = nAvgDaysPay
                mytable.Fields("OpenOrdTot").Value = nOpenOrderTotal

                If Len(Trim(cLastOrdDate)) = 0 Or IsDBNull(cLastOrdDate) Then
                    mytable.Fields("LastOrdDate").Value = System.DBNull.Value
                Else
                    mytable.Fields("LastOrdDate").Value = Trim(cLastOrdDate)
                End If
                If Len(Trim(cLastUpdated)) = 0 Or IsDBNull(cLastUpdated) Then

                    mytable.Fields("LastUpDated").Value = System.DBNull.Value
                Else
                    mytable.Fields("LastUpDated").Value = Trim(cLastUpdated)
                End If

                If Len(Trim(cContactEmail)) = 0 Or IsDBNull(cContactEmail) Then
                    mytable.Fields("contact-email").Value = " "
                Else
                    mytable.Fields("Contact-email").Value = Trim(cContactEmail)
                End If

                If Len(Trim(cEmail)) = 0 Or IsDBNull(cEmail) Then
                    mytable.Fields("Email").Value = " "
                Else
                    mytable.Fields("Email").Value = Trim(cEmail)
                End If
                mytable.Update()

                'Try
                '    'Find customer in the "Customers" contact folder
                '    contact = contacts.Find("[CustomerID] = '" & cCustNo & "'")

                '    ' If can't find customer contact, then create new contact
                '    If contact Is Nothing Then
                '        contact = objFolder.Items.Add(Microsoft.Office.Interop.Outlook.OlItemType.olContactItem)
                '    End If

                '    ' Setup Contact information...
                '    With contact
                '        .CompanyName = IIf(IsDBNull(mytable.Fields("name").Value), "", mytable.Fields("name").Value)
                '        .FullName = IIf(IsDBNull(mytable.Fields("contact").Value), "", mytable.Fields("contact").Value)
                '        .FileAs = IIf(IsDBNull(mytable.Fields("name").Value), "", mytable.Fields("name").Value)
                '        .BusinessAddressStreet = IIf(IsDBNull(mytable.Fields("address2").Value), "", mytable.Fields("address2").Value)
                '        .BusinessAddressCity = IIf(IsDBNull(mytable.Fields("city").Value), "", mytable.Fields("city").Value)
                '        .BusinessAddressState = IIf(IsDBNull(mytable.Fields("st").Value), "", mytable.Fields("st").Value)
                '        .BusinessAddressPostalCode = IIf(IsDBNull(mytable.Fields("zip-code").Value), "", mytable.Fields("st").Value)
                '        .BusinessTelephoneNumber = IIf(IsDBNull(mytable.Fields("telephone").Value), "", mytable.Fields("telephone").Value)
                '        .BusinessFaxNumber = IIf(IsDBNull(mytable.Fields("fax-num").Value), "", mytable.Fields("fax-num").Value)
                '        .Email1DisplayName = IIf(IsDBNull(mytable.Fields("contact").Value), "", mytable.Fields("contact").Value)
                '        .Email1Address = IIf(IsDBNull(mytable.Fields("email").Value), "", mytable.Fields("email").Value)
                '        .Email1AddressType = "SMTP"
                '        .CustomerID = IIf(IsDBNull(mytable.Fields("cust-no").Value), "", mytable.Fields("cust-no").Value)
                '        .Save()
                '    End With

                'Catch ex As Exception
                '    MsgBox(ex.Message)
                'End Try
            Loop
            'OutlookNameSpace.Logoff()
        Catch
            badfile = True
        End Try
    End Sub

    ''' <summary>
    ''' This procedure imports data into the Customer Ship To table
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub impCustomerSH()
        Try
            Dim cCustNo As String
            Dim cCustSh As String
            Dim cName As String
            Dim cAddr1 As String
            Dim cAddr2 As String
            Dim cAddr3 As String
            Dim cCity As String
            Dim cSt As String
            Dim cZipCode As String
            Dim cCountry As String
            Dim cTelephone As String
            Dim cContact As String
            Dim cStatusCode As String
            Dim cTypeCode As String
            Dim cTermCode As String
            Dim cViaCode As String
            Dim cComplete As String
            Dim lComplete As Boolean
            Dim cShipActive As String
            Dim lShipActive As Boolean
            Dim cHoldShipCode As String
            Dim cFaxNum As String
            Dim cLastUpdate As String
            Dim cContactEmail As String
            Dim cWebsite As String
            Dim cEmail As String
            Dim mytable As New ADODB.Recordset

            mytable.CursorLocation = ADODB.CursorLocationEnum.adUseServer
            mytable.Open(tblCustomerSH, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTableDirect)
            mytable.Index = "CustNumShipNo"

            Do While Not sr.EndOfStream
                cCustNo = sr.ReadLine
                If Trim(cCustNo) = "" Then
                    mytable.Close()
                    Exit Sub
                End If

                cCustSh = sr.ReadLine
                cName = sr.ReadLine
                cAddr1 = sr.ReadLine
                cAddr2 = sr.ReadLine
                cAddr3 = sr.ReadLine
                cCity = sr.ReadLine
                cSt = sr.ReadLine
                cZipCode = sr.ReadLine
                cCountry = sr.ReadLine
                cTelephone = sr.ReadLine
                cContact = sr.ReadLine
                cStatusCode = sr.ReadLine
                cTypeCode = sr.ReadLine
                cTermCode = sr.ReadLine
                cViaCode = sr.ReadLine
                cComplete = sr.ReadLine
                If Left(UCase(cComplete), 1) = "Y" Then
                    lComplete = True
                Else
                    lComplete = False
                End If
                cShipActive = sr.ReadLine
                If Left(UCase(cShipActive), 1) = "Y" Then
                    lShipActive = True
                Else
                    lShipActive = False
                End If
                cHoldShipCode = sr.ReadLine
                cFaxNum = sr.ReadLine
                cLastUpdate = sr.ReadLine
                cContactEmail = sr.ReadLine
                cWebsite = sr.ReadLine
                cEmail = sr.ReadLine

                mytable.Seek(New Object() {cCustNo, cCustSh}, ADODB.SeekEnum.adSeekFirstEQ)

                If mytable.EOF Then
                    mytable.AddNew()
                    mytable.Fields("cust-no").Value = Trim(cCustNo)
                    mytable.Fields("cust-sh").Value = Trim(cCustSh)
                End If
                mytable.Fields("name").Value = Trim(cName)
                mytable.Fields("Address1").Value = Trim(cAddr1)
                mytable.Fields("Address2").Value = Trim(cAddr2)
                mytable.Fields("Address3").Value = Trim(cAddr3)
                mytable.Fields("city").Value = Trim(cCity)
                mytable.Fields("St").Value = cSt
                mytable.Fields("Zip-code").Value = cZipCode
                mytable.Fields("Country").Value = cCountry
                mytable.Fields("Telephone").Value = cTelephone
                mytable.Fields("contact").Value = cContact
                mytable.Fields("status-code").Value = cStatusCode
                mytable.Fields("type-code").Value = cTypeCode
                mytable.Fields("term-code").Value = cTermCode
                mytable.Fields("via-code").Value = cViaCode
                mytable.Fields("Complete").Value = lComplete
                mytable.Fields("ShipActive").Value = lShipActive
                mytable.Fields("HoldShipCode").Value = cHoldShipCode
                mytable.Fields("Fax-num").Value = cFaxNum

                If Len(Trim(cLastUpdate)) = 0 Or IsDBNull(cLastUpdate) Then

                    mytable.Fields("LastUpDate").Value = System.DBNull.Value
                Else
                    mytable.Fields("LastUpDate").Value = Trim(cLastUpdate)
                End If

                If IsDBNull(cContactEmail) Or Len(Trim(cContactEmail)) = 0 Then
                    mytable.Fields("Contact-email").Value = " "
                Else
                    mytable.Fields("Contact-email").Value = Trim(cContactEmail)
                End If

                If IsDBNull(cWebsite) Or Len(Trim(cWebsite)) = 0 Then
                    mytable.Fields("Website").Value = " "
                Else
                    mytable.Fields("Website").Value = Trim(cWebsite)
                End If

                If IsDBNull(cEmail) Or Len(Trim(cEmail)) = 0 Then
                    mytable.Fields("Email").Value = " "
                Else
                    mytable.Fields("Email").Value = Trim(cEmail)
                End If
                mytable.Update()
            Loop
        Catch
            badfile = True
        End Try
    End Sub

    ''' <summary>
    ''' This procedure imports data into the Customer Memo table
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub impCustomerM()
        Try
            Dim nCtr As Integer
            Dim cCustNo As String
            Dim cPageNo As String
            Dim nPageNo As Integer
            Dim cMemo(8) As String
            Dim cLastUpdate As String
            Dim nLineNo(8) As Short
            Dim mytable As New ADODB.Recordset

            mytable.Open(tblCustomerM, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTableDirect)

            Do While Not sr.EndOfStream
                cCustNo = sr.ReadLine
                If Len(Trim(cCustNo)) = 0 Then
                    mytable.Close()
                    Exit Sub
                End If

                cPageNo = sr.ReadLine
                nPageNo = Val(cPageNo)
                For nCtr = 0 To 8
                    cMemo(nCtr) = sr.ReadLine
                    nLineNo(nCtr) = nCtr + 1
                Next nCtr

                cLastUpdate = sr.ReadLine

                clrCustMemos(cCustNo, nPageNo)

                For nCtr = 0 To 8
                    If Len(Trim(cMemo(nCtr))) > 0 Then
                        mytable.AddNew()
                        mytable.Fields("CustNo").Value = Trim(cCustNo)
                        mytable.Fields("PageNo").Value = Val(cPageNo)
                        mytable.Fields("LineNo").Value = nLineNo(nCtr)
                        mytable.Fields("MemoLine").Value = Trim(cMemo(nCtr))

                        If Len(Trim(cLastUpdate)) = 0 Or IsDBNull(cLastUpdate) Then

                            mytable.Fields("LastUpDate").Value = System.DBNull.Value
                        Else
                            mytable.Fields("LastUpDate").Value = Trim(cLastUpdate)
                        End If
                        mytable.Update()
                    End If
                Next nCtr
            Loop
        Catch
            badfile = True
        End Try
    End Sub

    ''' <summary>
    ''' This procedure imports data into the Order table
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub impOrderHead()
        Try
            Dim cOrderNo As String '(for reading and testing)
            Dim nOrderNo As Integer
            Dim cShipNo As String
            Dim cCustNo As String
            Dim cChargeCust As String
            Dim cDepartment As String
            Dim cCustPo As String
            Dim cOrderDate As String
            Dim cRequestDate As String
            Dim cCancelDate As String
            Dim cOrderCode As String
            Dim cTermCode As String
            Dim cSalesmanCd As String
            Dim cCommCode As String
            Dim nCommRate As String
            Dim cShipName As String
            Dim cShipAddr1 As String
            Dim cShipAddr2 As String
            Dim cShipCity As String
            Dim cShipState As String
            Dim cShipZip As String
            Dim cShipCountry As String
            Dim cViaCode As String
            Dim nPpsNo As Integer
            Dim cPpsDate As String
            Dim nInvoiceNo As Integer
            Dim cInvoiceDate As String
            Dim cCreditReject As String
            Dim lCreditReject As Boolean
            Dim nQtyOrigOrd As Integer
            Dim nQtyShipped As Integer
            Dim nQtyOpenOrder As Integer
            Dim nQtyOnPps As Integer
            Dim nAllocQty As Double
            Dim nAllocValue As Double
            Dim nOpenValue As Double
            Dim cHoldArCode As String
            Dim cHoldShipCode As String
            Dim nAddCharges As Double
            Dim nNetValue As Double
            Dim cShipComplete As String
            Dim cShipContact As String
            Dim cShipTelephone As String
            Dim cTagMemo As String
            Dim cCompleteDate As String
            Dim nShipRule As Integer
            Dim cOrdComplete As String
            Dim lOrdComplete As Boolean
            Dim cSpecialOrder As String
            Dim lSpecialOrder As Boolean
            Dim cSeason As String
            Dim cWorksheetID As String
            Dim cLastUpdate As String
            Dim cPpsNo As String = Nothing
            Dim mytable As New ADODB.Recordset

            mytable.CursorLocation = ADODB.CursorLocationEnum.adUseServer
            mytable.Open("order", conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTableDirect)
            mytable.Index = "OrderNo"

            Do While Not sr.EndOfStream
                cOrderNo = sr.ReadLine
                If Len(Trim(cOrderNo)) = 0 Then
                    mytable.Close()
                    Exit Sub
                End If
                nOrderNo = Val(cOrderNo)
                cShipNo = sr.ReadLine
                cCustNo = sr.ReadLine
                cChargeCust = sr.ReadLine
                cDepartment = sr.ReadLine
                cCustPo = sr.ReadLine
                cOrderDate = sr.ReadLine
                cRequestDate = sr.ReadLine
                cCancelDate = sr.ReadLine
                cOrderCode = sr.ReadLine
                cTermCode = sr.ReadLine
                cSalesmanCd = sr.ReadLine
                cCommCode = sr.ReadLine
                nCommRate = sr.ReadLine
                cShipName = sr.ReadLine
                cShipAddr1 = sr.ReadLine
                cShipAddr2 = sr.ReadLine
                cShipAddr3 = sr.ReadLine
                cShipCity = sr.ReadLine
                cShipState = sr.ReadLine
                cShipZip = sr.ReadLine
                cShipCountry = sr.ReadLine
                cViaCode = sr.ReadLine
                nPpsNo = sr.ReadLine
                cPpsDate = sr.ReadLine
                nInvoiceNo = sr.ReadLine
                cInvoiceDate = sr.ReadLine
                cCreditReject = sr.ReadLine
                If Left(UCase(cCreditReject), 1) = "Y" Then
                    lCreditReject = True
                Else
                    lCreditReject = False
                End If
                nQtyOrigOrd = sr.ReadLine
                nQtyShipped = sr.ReadLine
                nQtyOpenOrder = sr.ReadLine
                nQtyOnPps = sr.ReadLine
                nAllocQty = sr.ReadLine
                nAllocValue = sr.ReadLine
                nOpenValue = sr.ReadLine
                cHoldArCode = sr.ReadLine
                cHoldShipCode = sr.ReadLine
                nAddCharges = sr.ReadLine
                nNetValue = sr.ReadLine
                cShipComplete = sr.ReadLine
                cShipContact = sr.ReadLine
                cShipTelephone = sr.ReadLine
                cTagMemo = sr.ReadLine
                cCompleteDate = sr.ReadLine
                nShipRule = sr.ReadLine
                cOrdComplete = sr.ReadLine
                If Left(UCase(cOrdComplete), 1) = "Y" Then
                    lOrdComplete = True
                Else
                    lOrdComplete = False
                End If
                cSpecialOrder = sr.ReadLine
                If Left(UCase(cSpecialOrder), 1) = "Y" Then
                    lSpecialOrder = True
                Else
                    lSpecialOrder = False
                End If
                cSeason = sr.ReadLine
                cWorksheetID = sr.ReadLine
                cLastUpdate = sr.ReadLine

                mytable.Seek(nOrderNo, ADODB.SeekEnum.adSeekFirstEQ)

                If mytable.EOF Then
                    mytable.AddNew()
                    mytable.Fields("order-no").Value = nOrderNo
                Else
                    clrOrderLines((nOrderNo))
                End If
                mytable.Fields("ship-no").Value = Trim(cShipNo)
                mytable.Fields("cust-no").Value = Trim(cCustNo)
                mytable.Fields("charge-cust").Value = cChargeCust
                mytable.Fields("department").Value = cDepartment
                mytable.Fields("cust-po").Value = cCustPo
                If IsDate(cOrderDate) Then
                    mytable.Fields("order-date").Value = cOrderDate
                Else
                    mytable.Fields("order-date").Value = System.DBNull.Value
                End If
                If IsDate(cRequestDate) Then
                    mytable.Fields("request-date").Value = cRequestDate
                Else
                    mytable.Fields("request-date").Value = System.DBNull.Value
                End If
                If IsDate(cCancelDate) Then
                    mytable.Fields("cancel-date").Value = cCancelDate
                Else
                    mytable.Fields("cancel-date").Value = System.DBNull.Value
                End If
                mytable.Fields("order-code").Value = cOrderCode
                mytable.Fields("term-code").Value = cTermCode
                mytable.Fields("slsmn-code").Value = cSalesmanCd
                mytable.Fields("comm-rate").Value = Val(nCommRate)
                mytable.Fields("ShipName").Value = cShipName
                mytable.Fields("ShipAddress1").Value = cShipAddr1
                mytable.Fields("ShipAddress2").Value = cShipAddr2
                mytable.Fields("ShipAddress3").Value = cShipAddr3
                mytable.Fields("shipcity").Value = cShipCity
                mytable.Fields("ShipState").Value = cShipState
                mytable.Fields("ShipZip").Value = cShipZip
                mytable.Fields("ShipCountry").Value = cShipCountry
                mytable.Fields("ViaCode").Value = cViaCode
                mytable.Fields("pps-no").Value = cPpsNo
                If IsDate(cPpsDate) Then
                    mytable.Fields("pps-date").Value = Trim(cPpsDate)
                Else
                    mytable.Fields("pps-date").Value = System.DBNull.Value
                End If
                mytable.Fields("Invoice-No").Value = nInvoiceNo
                If IsDate(cInvoiceDate) Then
                    mytable.Fields("Invoice-date").Value = Trim(cInvoiceDate)
                Else
                    mytable.Fields("Invoice-date").Value = System.DBNull.Value
                End If
                mytable.Fields("credit-reject").Value = lCreditReject
                mytable.Fields("qty-orig-ord").Value = nQtyOrigOrd
                mytable.Fields("qty-shipped").Value = nQtyShipped
                mytable.Fields("qty-open-order").Value = nQtyOpenOrder
                mytable.Fields("qty-on-pps").Value = nQtyOnPps
                mytable.Fields("alloc-qty").Value = nAllocQty
                mytable.Fields("openValue").Value = nOpenValue
                mytable.Fields("Hold-ar-code").Value = cHoldArCode
                mytable.Fields("hold-ship-code").Value = cHoldShipCode
                mytable.Fields("add-charges").Value = nAddCharges
                mytable.Fields("net-value").Value = nNetValue
                mytable.Fields("ship-complete").Value = cShipComplete
                mytable.Fields("ship-contact").Value = cShipContact
                mytable.Fields("ship-telephone").Value = cShipTelephone
                mytable.Fields("tag-memo").Value = cTagMemo
                If IsDate(cCompleteDate) Then
                    mytable.Fields("complete-date").Value = cCompleteDate
                Else
                    mytable.Fields("complete-date").Value = System.DBNull.Value
                End If
                mytable.Fields("ship-rule").Value = nShipRule
                mytable.Fields("ord-complete").Value = lOrdComplete
                mytable.Fields("special-order").Value = lSpecialOrder
                mytable.Fields("season").Value = cSeason
                mytable.Fields("worksheetID").Value = cWorksheetID

                If Len(Trim(cLastUpdate)) = 0 Or IsDBNull(cLastUpdate) Then

                    mytable.Fields("LastUpDate").Value = System.DBNull.Value
                Else
                    mytable.Fields("LastUpDate").Value = Trim(cLastUpdate)
                End If
                mytable.Update()
            Loop
        Catch
            badfile = True
        End Try
    End Sub

    ''' <summary>
    ''' This procedure imports data into the Order Line table
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub impOrderLine()
        Try
            Dim cOrderNo As String
            Dim nOrderNo As Integer
            Dim nLineNo As Double
            Dim cItemNo As String
            Dim cItemDesc1 As String
            Dim cItemDesc2 As String
            Dim nGrossPrice As Double
            Dim nQtyOrigOrd As Integer
            Dim nQtyShipped As Integer
            Dim nQtyOpenOrd As Integer
            Dim nQtyAlloc As Integer
            Dim nQtyOnPps As Integer
            Dim cRequestDate As String
            Dim cCommCode As String
            Dim nCommRate As Double
            Dim cShipName As String
            Dim cShipAddr1 As String
            Dim cShipAddr2 As String
            Dim cShipAddr3 As String
            Dim cShipCity As String
            Dim cShipState As String
            Dim cShipZip As String
            Dim cShipCountry As String
            Dim nLastPps As Integer
            Dim nLastInvNo As Integer
            Dim cOrderCode As String
            Dim nExtPrice As Double
            Dim cTagMemo As String
            Dim cCompleteDate As String
            Dim nCutBackQty As Short
            Dim cCutBackStatus As String
            Dim cCutBackDate As String
            Dim cOrderDate As String
            Dim cLastUpdated As String
            Dim mytable As New ADODB.Recordset

            mytable.CursorLocation = ADODB.CursorLocationEnum.adUseServer
            mytable.Open("order-line", conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTableDirect)
            mytable.Index = "OrderNo"

            Do While Not sr.EndOfStream
                cOrderNo = sr.ReadLine
                If Len(Trim(cOrderNo)) = 0 Then
                    mytable.Close()
                    Exit Sub
                End If
                nOrderNo = Val(cOrderNo)
                nLineNo = sr.ReadLine
                cItemNo = sr.ReadLine
                cItemDesc1 = sr.ReadLine
                cItemDesc2 = sr.ReadLine
                nGrossPrice = sr.ReadLine
                nQtyOrigOrd = sr.ReadLine
                nQtyShipped = sr.ReadLine
                nQtyOpenOrd = sr.ReadLine
                nQtyAlloc = sr.ReadLine
                nQtyOnPps = sr.ReadLine
                cRequestDate = sr.ReadLine
                cCommCode = sr.ReadLine
                nCommRate = sr.ReadLine
                cShipName = sr.ReadLine
                cShipAddr1 = sr.ReadLine
                cShipAddr2 = sr.ReadLine
                cShipAddr3 = sr.ReadLine
                cShipCity = sr.ReadLine
                cShipState = sr.ReadLine
                cShipZip = sr.ReadLine
                cShipCountry = sr.ReadLine
                nLastPps = sr.ReadLine
                nLastInvNo = sr.ReadLine
                cOrderCode = sr.ReadLine
                nExtPrice = sr.ReadLine
                cTagMemo = sr.ReadLine
                cCompleteDate = sr.ReadLine
                nCutBackQty = sr.ReadLine
                cCutBackStatus = sr.ReadLine
                cCutBackDate = sr.ReadLine
                cOrderDate = sr.ReadLine
                cLastUpdated = sr.ReadLine

                mytable.Seek(New Object() {nOrderNo, nLineNo}, ADODB.SeekEnum.adSeekFirstEQ)

                If mytable.EOF Then
                    mytable.AddNew()
                    mytable.Fields("order-no").Value = nOrderNo
                    mytable.Fields("line-no").Value = nLineNo
                End If
                mytable.Fields("item-no").Value = cItemNo
                mytable.Fields("ItemDesc1").Value = cItemDesc1
                mytable.Fields("ItemDesc2").Value = cItemDesc2
                mytable.Fields("Gross-price").Value = nGrossPrice
                mytable.Fields("qty-orig-ord").Value = nQtyOrigOrd
                mytable.Fields("qty-shipped").Value = nQtyShipped
                mytable.Fields("qty-open-ord").Value = nQtyOpenOrd
                mytable.Fields("qty-alloc").Value = nQtyAlloc
                mytable.Fields("qty-on-pps").Value = nQtyOnPps
                If IsDate(cRequestDate) Then
                    mytable.Fields("requestdate").Value = Trim(cRequestDate)
                Else

                    mytable.Fields("requestdate").Value = System.DBNull.Value
                End If
                mytable.Fields("comm-code").Value = cCommCode
                mytable.Fields("comm-rate").Value = nCommRate
                mytable.Fields("ShipName").Value = cShipName
                mytable.Fields("ShipAddr1").Value = cShipAddr1
                mytable.Fields("ShipAddr2").Value = cShipAddr2
                mytable.Fields("ShipAddr3").Value = cShipAddr3
                mytable.Fields("shipcity").Value = cShipCity
                mytable.Fields("ShipState").Value = cShipState
                mytable.Fields("ShipZip").Value = cShipZip
                mytable.Fields("ShipCountry").Value = cShipCountry
                mytable.Fields("last-pps").Value = nLastPps
                mytable.Fields("last-inv-no").Value = nLastInvNo
                mytable.Fields("order-code").Value = cOrderCode
                mytable.Fields("ext-price").Value = nExtPrice
                mytable.Fields("tag-memo").Value = cTagMemo
                If IsDate(cCompleteDate) Then
                    mytable.Fields("complete-date").Value = cCompleteDate
                Else

                    mytable.Fields("complete-date").Value = System.DBNull.Value
                End If
                mytable.Fields("cut-back-qty").Value = nCutBackQty
                mytable.Fields("cut-back-status").Value = cCutBackStatus
                If IsDate(cOrderDate) Then
                    mytable.Fields("order-date").Value = cOrderDate
                Else

                    mytable.Fields("order-date").Value = System.DBNull.Value
                End If

                If Len(Trim(cLastUpdated)) = 0 Or IsDBNull(cLastUpdated) Then

                    mytable.Fields("LastUpDated").Value = System.DBNull.Value
                Else
                    mytable.Fields("LastUpDated").Value = Trim(cLastUpdated)
                End If
                mytable.Update()
            Loop
        Catch
            badfile = True
        End Try
    End Sub

    ''' <summary>
    ''' This procedure imports data into the Worksheet Header table
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub impWorksheetHead()
        Try
            Dim cWorksheetID As String
            Dim cAllowManualMaint As String
            Dim lAllowManualMaint As Boolean
            Dim cWsCreateDate As String
            Dim cLastUpDateDate As String
            Dim cCustNo As String
            Dim cShipNo As String
            Dim cName As String
            Dim cRequestDate As String
            Dim cCompleteDate As String
            Dim cCancelDate As String
            Dim cSeason As String
            Dim cOrderCode As String
            Dim cCustPo As String
            Dim cDepartment As String
            Dim cViaCode As String
            Dim cOrdComplete As String
            Dim lOrdComplete As Boolean
            Dim nOrderNo As Integer
            Dim cOrderDate As String
            Dim cXmittalStatus As String
            Dim cXmittalDate As String
            Dim cValidationStatus As String
            Dim cValidationDate As String
            Dim cErrorLevel As String
            Dim cLastUpdated As String
            Dim cSlsmnCode As String
            Dim mytable As New ADODB.Recordset

            mytable.CursorLocation = ADODB.CursorLocationEnum.adUseServer
            mytable.Open("ws-ord-head", conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTableDirect)
            mytable.Index = "WorkSheetID"

            Do While Not sr.EndOfStream
                cWorksheetID = sr.ReadLine
                If Len(Trim(cWorksheetID)) = 0 Then
                    mytable.Close()
                    Exit Sub
                End If
                ClrWsErrorMsg(cWorksheetID)

                cAllowManualMaint = sr.ReadLine
                If Left(UCase(cAllowManualMaint), 1) = "Y" Then
                    lAllowManualMaint = True
                Else
                    lAllowManualMaint = False
                End If
                cWsCreateDate = sr.ReadLine
                cLastUpDateDate = sr.ReadLine
                cCustNo = sr.ReadLine
                cShipNo = sr.ReadLine
                cName = sr.ReadLine
                cRequestDate = sr.ReadLine
                cCompleteDate = sr.ReadLine
                cCancelDate = sr.ReadLine
                cSeason = sr.ReadLine
                cOrderCode = sr.ReadLine
                cCustPo = sr.ReadLine
                cDepartment = sr.ReadLine
                cViaCode = sr.ReadLine
                cOrdComplete = sr.ReadLine
                If Left(UCase(cOrdComplete), 1) = "Y" Then
                    lOrdComplete = True
                Else
                    lOrdComplete = False
                End If
                nOrderNo = sr.ReadLine
                cOrderDate = sr.ReadLine
                cXmittalStatus = sr.ReadLine
                cXmittalDate = sr.ReadLine
                cValidationStatus = sr.ReadLine
                cValidationDate = sr.ReadLine
                cErrorLevel = sr.ReadLine
                cSlsmnCode = sr.ReadLine
                cLastUpdated = sr.ReadLine

                mytable.Seek(cWorksheetID, ADODB.SeekEnum.adSeekFirstEQ)

                If mytable.EOF Then
                    mytable.AddNew()
                    mytable.Fields("Worksheet-ID").Value = Trim(cWorksheetID)
                End If

                mytable.Fields("Allow-Manual-Maint").Value = lAllowManualMaint
                If IsDate(cWsCreateDate) Then
                    mytable.Fields("ws-create-date").Value = cWsCreateDate
                Else

                    mytable.Fields("ws-create-date").Value = System.DBNull.Value
                End If
                If IsDate(cLastUpDateDate) Then
                    mytable.Fields("last-update-date").Value = cLastUpDateDate
                Else

                    mytable.Fields("last-update-date").Value = System.DBNull.Value
                End If
                If Len(Trim(cCustNo)) <> 0 Then
                    mytable.Fields("cust-no").Value = cCustNo
                End If
                If Len(Trim(cShipNo)) <> 0 Then
                    mytable.Fields("ship-no").Value = cShipNo
                End If
                mytable.Fields("name").Value = cName
                If IsDate(cRequestDate) Then
                    mytable.Fields("request-date").Value = cRequestDate
                Else

                    mytable.Fields("request-date").Value = System.DBNull.Value
                End If
                If IsDate(cCompleteDate) Then
                    mytable.Fields("complete-date").Value = cCompleteDate
                Else

                    mytable.Fields("complete-date").Value = System.DBNull.Value
                End If
                If IsDate(cCancelDate) Then
                    mytable.Fields("cancel-date").Value = cCancelDate
                Else

                    mytable.Fields("cancel-date").Value = System.DBNull.Value
                End If
                mytable.Fields("season").Value = cSeason
                mytable.Fields("order-code").Value = cOrderCode
                mytable.Fields("cust-po").Value = cCustPo
                If Len(Trim(cDepartment)) > 8 Then
                    mytable.Fields("department").Value = Left(Trim(cDepartment), 8)
                Else
                    mytable.Fields("department").Value = Trim(cDepartment)
                End If
                mytable.Fields("via-code").Value = cViaCode
                mytable.Fields("ord-compl").Value = lOrdComplete
                mytable.Fields("order-no").Value = nOrderNo
                If IsDate(Trim(cOrderDate)) Then
                    mytable.Fields("order-date").Value = Trim(cOrderDate)
                Else

                    mytable.Fields("order-date").Value = System.DBNull.Value
                End If
                mytable.Fields("validation-status").Value = cValidationStatus
                If IsDate(cValidationDate) Then
                    mytable.Fields("validation-date").Value = cValidationDate
                Else

                    mytable.Fields("validation-date").Value = System.DBNull.Value
                End If
                If UCase(cValidationStatus) = "REJECT" Then
                    mytable.Fields("allow-manual-maint").Value = True
                    mytable.Fields("transmittal-status").Value = "OPEN"
                    mytable.Fields("transmittal-date").Value = Today
                    mytable.Fields("ReadyToXmit").Value = False
                    mytable.Fields("xmitted").Value = False
                Else
                    mytable.Fields("allow-manual-maint").Value = False
                    mytable.Fields("transmittal-status").Value = "RCPT"
                    mytable.Fields("transmittal-date").Value = Today
                    mytable.Fields("ReadyToXmit").Value = False
                End If
                mytable.Fields("error-level").Value = cErrorLevel

                If Len(Trim(cLastUpdated)) = 0 Or IsDBNull(cLastUpdated) Then

                    mytable.Fields("LastUpDated").Value = System.DBNull.Value
                Else
                    mytable.Fields("LastUpDated").Value = Trim(cLastUpdated)
                End If
                mytable.Fields("SlsmnCode").Value = cSlsmnCode
                mytable.Update()
            Loop
        Catch
            badfile = True
        End Try
    End Sub

    ''' <summary>
    ''' This procedure imports data into the Worksheet Line table
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub impWorksheetLine()
        Try
            Dim cWorksheetID As String
            Dim cItemNo As String
            Dim nOrderLineNo As Integer
            Dim nQtyOrigOrd As Integer
            Dim nPrice As Double
            Dim cLastUpdated As String
            Dim mytable As New ADODB.Recordset

            mytable.CursorLocation = ADODB.CursorLocationEnum.adUseServer
            mytable.Open("ws-ord-line", conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTableDirect)
            mytable.Index = "Primary"

            Do While Not sr.EndOfStream
                cWorksheetID = sr.ReadLine
                If Len(Trim(cWorksheetID)) = 0 Then
                    mytable.Close()
                    Exit Sub
                End If
                cItemNo = sr.ReadLine
                nOrderLineNo = sr.ReadLine
                nQtyOrigOrd = sr.ReadLine
                nPrice = sr.ReadLine
                cLastUpdated = sr.ReadLine

                mytable.Seek(New Object() {cWorksheetID, cItemNo}, ADODB.SeekEnum.adSeekFirstEQ)

                If mytable.EOF Then
                    mytable.AddNew()
                    mytable.Fields("worksheet-id").Value = Trim(cWorksheetID)
                End If
                mytable.Fields("item-no").Value = cItemNo
                mytable.Fields("OrderLineNo").Value = nOrderLineNo
                mytable.Fields("qty-orig-ord").Value = nQtyOrigOrd
                mytable.Fields("price").Value = nPrice
                If IsDate(cLastUpdated) Then
                    mytable.Fields("LastUpdated").Value = cLastUpdated
                Else

                    mytable.Fields("LastUpdated").Value = System.DBNull.Value
                End If
                mytable.Update()
            Loop
        Catch
            badfile = True
        End Try
    End Sub

    ''' <summary>
    ''' This procedure imports data in the Worksheet Error Message table
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub impWorksheetError()
        Try
            Dim cWorksheetID As String
            Dim cErrorLevel As String
            Dim cMessage As String
            Dim mytable As New ADODB.Recordset

            mytable.Open(tblWsErrorMsg, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTableDirect)

            Do While Not sr.EndOfStream
                cWorksheetID = sr.ReadLine
                If Len(Trim(cWorksheetID)) = 0 Then
                    mytable.Close()
                    Exit Sub
                End If
                cErrorLevel = sr.ReadLine
                cMessage = sr.ReadLine
                mytable.AddNew()
                mytable.Fields("worksheet-id").Value = Trim(cWorksheetID)
                mytable.Fields("error-level").Value = Left(Trim(cErrorLevel), 1)
                mytable.Fields("Message").Value = Trim(cMessage)
                mytable.Update()
            Loop
        Catch
            badfile = True
        End Try
    End Sub

    ''' <summary>
    ''' This procedure imports data into the Season table
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub impSeason()
        Try
            Dim cSeason As String
            Dim cDescription As String
            Dim cLastUpdate As String
            Dim cForLapTop As String
            Dim lForLapTop As Boolean
            Dim cSeasonType As String
            Dim iDispSeq As String
            Dim mytable As New ADODB.Recordset

            mytable.CursorLocation = ADODB.CursorLocationEnum.adUseServer
            mytable.Open(tblSeason, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTableDirect)
            mytable.Index = "SeasonCode"

            Do While Not sr.EndOfStream
                cSeason = sr.ReadLine
                If Len(Trim(cSeason)) = 0 Then
                    mytable.Close()
                    Exit Sub
                End If
                cDescription = sr.ReadLine
                cForLapTop = sr.ReadLine
                If UCase(Left(cForLapTop, 1)) = "Y" Then
                    lForLapTop = True
                Else
                    lForLapTop = False
                End If
                cSeasonType = sr.ReadLine
                iDispSeq = sr.ReadLine
                cLastUpdate = sr.ReadLine

                mytable.Seek(cSeason, ADODB.SeekEnum.adSeekFirstEQ)

                If mytable.EOF Then
                    mytable.AddNew()
                    If Len(Trim(cSeason)) > 8 Then
                        cSeason = Left(Trim(cSeason), 8)
                    End If
                    mytable.Fields("Season").Value = Trim(cSeason)
                End If
                mytable.Fields("Description").Value = Trim(cDescription)
                mytable.Fields("ForLaptop").Value = lForLapTop
                mytable.Fields("seasontype").Value = cSeasonType
                mytable.Fields("disp-seq").Value = iDispSeq
                If IsDate(Trim(cLastUpdate)) Then
                    mytable.Fields("LastUpdated").Value = Trim(cLastUpdate)
                Else

                    mytable.Fields("LastUpdated").Value = System.DBNull.Value
                End If
                mytable.Update()
            Loop
        Catch
            badfile = True
        End Try
    End Sub

    ''' <summary>
    ''' This procedure imports data into the Season Type table
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub impSeasonType()
        Try
            Dim cSeasonType As String
            Dim cDescription As String
            Dim cLastUpdate As String
            Dim mytable As New ADODB.Recordset

            mytable.CursorLocation = ADODB.CursorLocationEnum.adUseServer
            mytable.Open(tblSeasonType, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTableDirect)
            mytable.Index = "SeasonType"

            Do While Not sr.EndOfStream
                cSeasonType = sr.ReadLine
                If Len(Trim(cSeasonType)) = 0 Then
                    mytable.Close()
                    Exit Sub
                End If
                cDescription = sr.ReadLine
                cLastUpdate = sr.ReadLine

                mytable.Seek(cSeasonType, ADODB.SeekEnum.adSeekFirstEQ)

                If mytable.EOF Then
                    mytable.AddNew()
                    mytable.Fields("SeasonType").Value = Trim(cSeasonType)
                    mytable.Fields("Description").Value = Trim(cDescription)
                    mytable.Fields("LastUpdate").Value = Trim(cLastUpdate)
                    mytable.Update()
                End If
            Loop
        Catch
            badfile = True
        End Try
    End Sub

    ''' <summary>
    ''' This procedure imports data into the Order Type table
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub impOrderType()
        Try
            Dim cOrderCode As String
            Dim cDescription As String
            Dim cLastUpdate As String
            Dim cBeginShipDate As String
            Dim cEndShipDate As String
            Dim cForLapTop As String
            Dim lForLapTop As Boolean
            Dim mytable As New ADODB.Recordset

            mytable.CursorLocation = ADODB.CursorLocationEnum.adUseServer
            mytable.Open(tblOrderType, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTableDirect)
            mytable.Index = "OrderCode"

            Do While Not sr.EndOfStream
                cOrderCode = sr.ReadLine
                If Len(Trim(cOrderCode)) = 0 Then
                    mytable.Close()
                    Exit Sub
                End If
                cDescription = sr.ReadLine
                cBeginShipDate = sr.ReadLine
                cEndShipDate = sr.ReadLine
                cForLapTop = sr.ReadLine
                If UCase(Left(cForLapTop, 1)) = "Y" Then
                    lForLapTop = True
                Else
                    lForLapTop = False
                End If
                cLastUpdate = sr.ReadLine

                mytable.Seek(cOrderCode, ADODB.SeekEnum.adSeekFirstEQ)

                If mytable.EOF Then
                    mytable.AddNew()
                    mytable.Fields("OrderCode").Value = cOrderCode
                End If

                mytable.Fields("Description").Value = cDescription
                If IsDate(cLastUpdate) Then
                    mytable.Fields("LastUpdate").Value = cLastUpdate
                Else

                    mytable.Fields("LastUpdate").Value = System.DBNull.Value
                End If
                If IsDate(cBeginShipDate) Then
                    mytable.Fields("BeginShipDate").Value = cBeginShipDate
                Else

                    mytable.Fields("BeginShipDate").Value = System.DBNull.Value
                End If
                If IsDate(cEndShipDate) Then
                    mytable.Fields("EndShipDate").Value = cEndShipDate
                Else

                    mytable.Fields("EndShipDate").Value = System.DBNull.Value
                End If
                mytable.Fields("ForLaptop").Value = lForLapTop

                mytable.Update()
            Loop
        Catch
            badfile = True
        End Try
    End Sub

    ''' <summary>
    ''' This procedure imports data into the Product Group table
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub impProductGroup()
        Try
            Dim cProdGroup As String
            Dim cDescription As String
            Dim cProdType As String
            Dim cLastUpdate As String
            Dim mytable As New ADODB.Recordset

            mytable.CursorLocation = ADODB.CursorLocationEnum.adUseServer
            mytable.Open(tblProdGroup, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTableDirect)
            mytable.Index = "ProdGroup"

            Do While Not sr.EndOfStream
                cProdGroup = sr.ReadLine
                If Len(Trim(cProdGroup)) = 0 Then
                    mytable.Close()
                    Exit Sub
                End If
                cDescription = sr.ReadLine
                cProdType = sr.ReadLine
                cLastUpdate = sr.ReadLine

                mytable.Seek(cProdGroup, ADODB.SeekEnum.adSeekFirstEQ)

                If mytable.EOF Then
                    mytable.AddNew()
                    mytable.Fields("ProdGroup").Value = cProdGroup
                End If

                mytable.Fields("Description").Value = cDescription
                mytable.Fields("ProdType").Value = cProdType
                If IsDate(cLastUpdate) Then
                    mytable.Fields("LastUpdated").Value = cLastUpdate
                Else

                    mytable.Fields("LastUpdated").Value = System.DBNull.Value
                End If
                mytable.Update()
            Loop
        Catch
            badfile = True
        End Try
    End Sub

    ''' <summary>
    ''' This procedure imports data into the Product Type table
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub impProductType()
        Try
            Dim cProdType As String
            Dim cDescription As String
            Dim cLastUpdate As String
            Dim iDispSeq As String
            Dim mytable As New ADODB.Recordset

            mytable.CursorLocation = ADODB.CursorLocationEnum.adUseServer
            mytable.Open(tblProdType, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTableDirect)
            mytable.Index = "ProdType"

            Do While Not sr.EndOfStream
                cProdType = sr.ReadLine
                If Len(Trim(cProdType)) = 0 Then
                    mytable.Close()
                    Exit Sub
                End If
                cDescription = sr.ReadLine
                iDispSeq = sr.ReadLine
                cLastUpdate = sr.ReadLine

                mytable.Filter = "[prodtype] = '" & cProdType & "'"

                If mytable.EOF Then
                    mytable.AddNew()
                    mytable.Fields("ProdType").Value = cProdType
                End If

                mytable.Fields("Description").Value = cDescription
                mytable.Fields("disp-seq").Value = iDispSeq
                If IsDate(cLastUpdate) Then
                    mytable.Fields("LastUpdate").Value = cLastUpdate
                Else

                    mytable.Fields("LastUpdate").Value = System.DBNull.Value
                End If
                mytable.Update()
            Loop
        Catch
            badfile = True
        End Try
    End Sub

    ''' <summary>
    ''' This procedure imports data into the Attribute table
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub impAttrib()
        Try
            Dim cProdGroup As String
            Dim nAttrNo As Short
            Dim cAttrib As String
            Dim cSetCode As String
            Dim cSetting As String
            Dim nSetFormat As Short
            Dim cLastUpdated As String
            Dim mytable As New ADODB.Recordset

            mytable.CursorLocation = ADODB.CursorLocationEnum.adUseServer
            mytable.Open(tblAttrib, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTableDirect)
            mytable.Index = "ProdGroup"

            Do While Not sr.EndOfStream
                cProdGroup = sr.ReadLine
                If Len(Trim(cProdGroup)) = 0 Then
                    mytable.Close()
                    Exit Sub
                End If
                nAttrNo = sr.ReadLine
                cAttrib = sr.ReadLine
                cSetCode = sr.ReadLine
                cSetting = sr.ReadLine
                nSetFormat = sr.ReadLine
                cLastUpdated = sr.ReadLine

                mytable.Seek(New Object() {cProdGroup, nAttrNo, cSetCode}, ADODB.SeekEnum.adSeekFirstEQ)

                If mytable.EOF Then
                    mytable.AddNew()
                    mytable.Fields("ProdGroup").Value = Trim(cProdGroup)
                    mytable.Fields("AttrNo").Value = nAttrNo
                    mytable.Fields("Setcode").Value = Trim(cSetCode)
                End If
                mytable.Fields("Attrib").Value = Trim(cAttrib)
                mytable.Fields("Setting").Value = Trim(cSetting)
                mytable.Fields("Setformat").Value = nSetFormat
                If IsDate(cLastUpdated) Then
                    mytable.Fields("LastUpdated").Value = cLastUpdated
                Else

                    mytable.Fields("LastUpdated").Value = System.DBNull.Value
                End If
                mytable.Update()
            Loop
        Catch
            badfile = True
        End Try
    End Sub

    ''' <summary>
    ''' This procedure imports data into the Item table
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub impItem()
        Try
            Dim cItem As String
            Dim cDesc1 As String
            Dim cDesc2 As String
            Dim cAttrib1 As String
            Dim cAttrib2 As String
            Dim cAttrib3 As String
            Dim cSortName As String
            Dim cUOMCd As String
            Dim cProdGroup As String
            Dim cCommCode As String
            Dim dBegShipDate As String
            Dim dEndShipDate As String
            Dim nPrice As Double
            Dim nQtyOnHand As Integer
            Dim dOnHandDate As String
            Dim nQtyCustOrd As Integer
            Dim nQtyAlloc As Integer
            Dim nQtyOnPps As Integer
            Dim nQtyOnPo As Integer
            Dim nQtyWoMat As Integer
            Dim nQtyOnWo As Integer
            Dim cCanBeOrdered As String
            Dim lCanBeOrdered As Boolean
            Dim dLastUpdated As String
            Dim nSubCode As String
            Dim mytable As New ADODB.Recordset

            mytable.CursorLocation = ADODB.CursorLocationEnum.adUseServer
            mytable.Open(tblItem, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTableDirect)
            mytable.Index = "PrimaryKey"

            Do
                Try
                    cItem = sr.ReadLine
                    If Len(Trim(cItem)) = 0 Then
                        mytable.Close()
                        Exit Sub
                    End If
                    cDesc1 = sr.ReadLine
                    cDesc2 = sr.ReadLine
                    cAttrib1 = sr.ReadLine
                    cAttrib2 = sr.ReadLine
                    cAttrib3 = sr.ReadLine
                    cSortName = sr.ReadLine
                    cUOMCd = sr.ReadLine
                    cProdGroup = sr.ReadLine
                    cCommCode = sr.ReadLine
                    dBegShipDate = sr.ReadLine
                    dEndShipDate = sr.ReadLine
                    nPrice = sr.ReadLine
                    nQtyOnHand = sr.ReadLine
                    dOnHandDate = sr.ReadLine
                    nQtyCustOrd = sr.ReadLine
                    nQtyAlloc = sr.ReadLine
                    nQtyOnPps = sr.ReadLine
                    nQtyOnPo = sr.ReadLine
                    nQtyWoMat = sr.ReadLine
                    nQtyOnWo = sr.ReadLine
                    cCanBeOrdered = sr.ReadLine
                    If Left(UCase(cCanBeOrdered), 1) = "Y" Then
                        lCanBeOrdered = True
                    Else
                        lCanBeOrdered = False
                    End If
                    nSubCode = sr.ReadLine
                    dLastUpdated = sr.ReadLine

                    mytable.Seek(cItem, ADODB.SeekEnum.adSeekFirstEQ)

                    If mytable.EOF Then
                        mytable.AddNew()
                        mytable.Fields("Item").Value = cItem
                    End If
                    mytable.Fields("Description1").Value = UCase(cDesc1)
                    mytable.Fields("Description2").Value = UCase(cDesc2)
                    mytable.Fields("Attrib1").Value = cAttrib1
                    mytable.Fields("Attrib2").Value = cAttrib2
                    mytable.Fields("Attrib3").Value = cAttrib3
                    mytable.Fields("sort-name").Value = cSortName
                    mytable.Fields("uom-code").Value = cUOMCd
                    mytable.Fields("ProdGroup").Value = cProdGroup
                    mytable.Fields("comm-code").Value = cCommCode

                    If Len(Trim(dBegShipDate)) = 0 Or IsDBNull(dBegShipDate) Then

                        mytable.Fields("begin-ship-date").Value = System.DBNull.Value
                    Else
                        mytable.Fields("begin-ship-date").Value = dBegShipDate
                    End If

                    If Len(Trim(dEndShipDate)) = 0 Or IsDBNull(dEndShipDate) Then

                        mytable.Fields("end-ship-date").Value = System.DBNull.Value
                    Else
                        mytable.Fields("end-ship-date").Value = dEndShipDate
                    End If
                    mytable.Fields("price1").Value = nPrice
                    mytable.Fields("qty-on-hand").Value = nQtyOnHand

                    If Len(Trim(dOnHandDate)) = 0 Or IsDBNull(dOnHandDate) Then

                        mytable.Fields("on-hand-date").Value = System.DBNull.Value
                    Else
                        mytable.Fields("on-hand-date").Value = dOnHandDate
                    End If
                    mytable.Fields("qty-cust-ord").Value = nQtyCustOrd
                    mytable.Fields("qty-alloc").Value = nQtyAlloc
                    mytable.Fields("qty-on-pps").Value = nQtyOnPps
                    mytable.Fields("Qty-on-po").Value = nQtyOnPo
                    mytable.Fields("qty-wo-mat").Value = nQtyWoMat
                    mytable.Fields("qty-on-wo").Value = nQtyOnWo
                    mytable.Fields("CanBeOrdered").Value = lCanBeOrdered
                    mytable.Fields("sub-code").Value = nSubCode

                    If Len(Trim(dLastUpdated)) = 0 Or IsDBNull(dLastUpdated) Then

                        mytable.Fields("LastUpdated").Value = System.DBNull.Value
                    Else
                        mytable.Fields("LastUpdated").Value = dLastUpdated
                    End If
                    mytable.Fields("QtyToSell").Value = nQtyOnHand - nQtyCustOrd
                    mytable.Fields("QtyPotential").Value = nQtyOnHand - nQtyCustOrd + nQtyOnPo + nQtyOnWo
                    mytable.Update()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Loop Until sr.EndOfStream
        Catch
            badfile = True
        End Try
    End Sub

    ''' <summary>
    ''' This procedure imports data into the Product Group Attribute table
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub impProductGroupAttrib()
        Try
            Dim ProductGroup As String
            Dim attrDesc As String
            Dim attrPos As String
            Dim attrLen As String
            Dim LastUpdate As String
            Dim mytable As New ADODB.Recordset

            mytable.CursorLocation = ADODB.CursorLocationEnum.adUseServer
            mytable.Open("Product Group Attributes", conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTableDirect)
            mytable.Index = "PrimaryKey"

            Do While Not sr.EndOfStream
                ProductGroup = sr.ReadLine
                If Len(Trim(ProductGroup)) = 0 Then
                    mytable.Close()
                    Exit Sub
                End If
                attrPos = sr.ReadLine
                attrLen = sr.ReadLine
                attrDesc = sr.ReadLine
                LastUpdate = sr.ReadLine

                mytable.Seek(New Object() {ProductGroup, attrDesc}, ADODB.SeekEnum.adSeekFirstEQ)

                If mytable.EOF = True Then
                    mytable.AddNew()
                    mytable.Fields("ProductGroup").Value = ProductGroup
                    mytable.Fields("attrPosition").Value = attrPos
                    mytable.Fields("attrLen").Value = attrLen
                    mytable.Fields("attrDesc").Value = attrDesc
                    mytable.Fields("LastUpdate").Value = LastUpdate
                    mytable.Update()
                End If
            Loop
        Catch
            badfile = True
        End Try
    End Sub

    ''' <summary>
    ''' This procedure imports data into the Customer Seasonal Projections table
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub impCustSeasProj()
        Try
            Dim cCustNo As String
            Dim cSeason As String
            Dim cProdType As String
            Dim cOrderCode As String
            Dim iUnits As Short
            Dim lDollars As Double
            Dim cStCode As String
            Dim dStDate As String
            Dim LastUpdate As String
            Dim mytable As New ADODB.Recordset

            mytable.CursorLocation = ADODB.CursorLocationEnum.adUseServer
            mytable.Open("cust-seas-proj", conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTableDirect)
            mytable.Index = "PrimaryKey"

            Do While Not sr.EndOfStream
                cCustNo = sr.ReadLine
                If Len(Trim(cCustNo)) = 0 Then
                    mytable.Close()
                    Exit Sub
                End If
                cSeason = sr.ReadLine
                cProdType = sr.ReadLine
                cOrderCode = sr.ReadLine
                iUnits = sr.ReadLine
                lDollars = sr.ReadLine
                cStCode = sr.ReadLine
                dStDate = sr.ReadLine
                LastUpdate = sr.ReadLine

                mytable.Seek(New Object() {cCustNo, cSeason, cProdType, cOrderCode}, ADODB.SeekEnum.adSeekFirstEQ)

                If mytable.EOF = True Then
                    mytable.AddNew()
                    mytable.Fields("cust-no").Value = cCustNo
                    mytable.Fields("season").Value = cSeason
                    mytable.Fields("prodtype").Value = cProdType
                    mytable.Fields("ordercode").Value = cOrderCode
                    mytable.Fields("units").Value = iUnits
                    mytable.Fields("dollars").Value = lDollars
                    mytable.Fields("stcode").Value = cStCode
                    If dStDate = "" Then

                        mytable.Fields("stdate").Value = System.DBNull.Value
                    Else
                        mytable.Fields("stdate").Value = dStDate
                    End If
                    If LastUpdate = "" Then

                        mytable.Fields("LastUpdate").Value = System.DBNull.Value
                    Else
                        mytable.Fields("LastUpdate").Value = LastUpdate
                    End If
                    mytable.Update()
                Else
                    mytable.Fields("units").Value = iUnits
                    mytable.Fields("dollars").Value = lDollars
                    mytable.Fields("stcode").Value = cStCode
                    If dStDate = "" Then

                        mytable.Fields("stdate").Value = System.DBNull.Value
                    Else
                        mytable.Fields("stdate").Value = dStDate
                    End If
                    mytable.Update()
                End If
            Loop
        Catch
            badfile = True
        End Try
    End Sub

    ''' <summary>
    ''' This procedure is no longer in use
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub ClrItemTable()
        Dim sql As String
        Dim conn As ADODB.Connection
        conn = CreateObject("ADODB.Connection")
        conn.Provider = "Microsoft.Jet.OLEDB.4.0"
        conn.Open(dbName)
        sql = "Delete * from Item"
        conn.Execute(sql)
        conn.Close()
    End Sub

    ''' <summary>
    ''' This procedure will delete all error message records in WsErrorMsg for a specific worksheet
    ''' </summary>
    ''' <param name="cWsNo">The worksheet id</param>
    ''' <remarks></remarks>

    Private Sub ClrWsErrorMsg(ByRef cWsNo As String)
        Dim sql As String
        Dim conn As ADODB.Connection
        conn = CreateObject("ADODB.Connection")
        conn.Provider = "Microsoft.Jet.OLEDB.4.0"
        conn.Open(dbName)
        sql = "Delete * from WsErrorMsg where [worksheet-id] = " & Chr(34) & cWsNo & Chr(34)
        conn.Execute(sql)
        conn.Close()
    End Sub

    ''' <summary>
    ''' This procedure will delete order-lines for a specific order number
    ''' </summary>
    ''' <param name="nOrdNo">The order number</param>
    ''' <remarks></remarks>

    Private Sub clrOrderLines(ByRef nOrdNo As Integer)
        Dim sql As String
        Dim conn As ADODB.Connection
        conn = CreateObject("ADODB.Connection")
        conn.Provider = "Microsoft.Jet.OLEDB.4.0"
        conn.Open(dbName)
        sql = "Delete * from [Order-line] where [Order-line].[Order-no] = " & nOrdNo
        conn.Execute(sql)
        conn.Close()
    End Sub

    ''' <summary>
    ''' This procedure deletes memos from the CustomerMemo table for a specific customer
    ''' </summary>
    ''' <param name="cCusNum"></param>
    ''' <param name="nPgNum"></param>
    ''' <remarks></remarks>

    Private Sub clrCustMemos(ByRef cCusNum As String, ByRef nPgNum As Integer)
        Dim sql As String
        Dim conn As ADODB.Connection
        conn = CreateObject("ADODB.Connection")
        conn.Provider = "Microsoft.Jet.OLEDB.4.0"
        conn.Open(dbName)
        sql = "Delete * from [CustomerMemo] where [CustomerMemo].[CustNo] = '" & cCusNum & "'"
        conn.Execute(sql)
        conn.Close()
    End Sub

    ''' <summary>
    ''' This procedure is no longer in use, but will check the length of a file to see if it contains any data
    ''' </summary>
    ''' <param name="cFilNam"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Private Function isFileZeroBytes(ByRef cFilNam As String) As Boolean
        Dim nBuf As Short
        nBuf = FreeFile
        FileOpen(nBuf, cFilNam, OpenMode.Binary)
        If LOF(nBuf) = 0 Then
            isFileZeroBytes = True
        Else
            isFileZeroBytes = False
        End If
        FileClose(nBuf)
    End Function
End Module