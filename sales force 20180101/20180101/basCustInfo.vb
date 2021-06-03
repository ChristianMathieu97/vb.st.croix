Option Strict Off
Option Explicit On

Module basCustInfo
	Dim lFlagValidCust As Boolean
    Public cNewCustNo As String

    ''' <summary>
    '''  This procedure sets public variables for the Customer table
    ''' </summary>
    ''' <param name="cCustNum"></param> The Customer number 
    ''' <remarks></remarks> The public variables are used in various places throughout the program

    Public Sub GetCustDataF(ByRef cCustNum As String) 'Find customer data by customer number
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim daCust As New SaleForcDataSetTableAdapters.CustomerTableAdapter
        Dim dtCust As SaleForcDataSet.CustomerDataTable
        Dim drCust() As SaleForcDataSet.CustomerRow

        con.Open()
        dtCust = daCust.GetData
        drCust = dtCust.Select("[cust-no] = '" & cCustNum & "'")

        lFlagValidCust = True

        If drCust.Length = 0 Then
            lFlagValidCust = False
            con.Close()
            Exit Sub
        Else
            cCustNo = cCustNum
            If IsDBNull(drCust(0)("Name")) Then
                cCustName = ""
            Else
                cCustName = drCust(0)("Name")
            End If

            If IsDBNull(drCust(0)("Address1")) Then
                cCustAddr1 = ""
            Else
                cCustAddr1 = drCust(0)("Address1")
            End If

            If IsDBNull(drCust(0)("Address2")) Then
                cCustAddr2 = ""
            Else
                cCustAddr2 = drCust(0)("Address2")
            End If

            If IsDBNull(drCust(0)("Address3")) Then
                cCustAddr3 = ""
            Else
                cCustAddr3 = drCust(0)("Address3")
            End If

            If IsDBNull(drCust(0)("city")) Then
                cCustCity = ""
            Else
                cCustCity = drCust(0)("city")
            End If

            If IsDBNull(drCust(0)("St")) Then
                cCustSt = ""
            Else
                cCustSt = drCust(0)("St")
            End If

            If IsDBNull(drCust(0)("zip-code")) Then
                cCustZip = ""
            Else
                cCustZip = drCust(0)("zip-code")
            End If

            If IsDBNull(drCust(0)("via-code")) Then
                cCustShipViaCd = ""
            Else
                cCustShipViaCd = drCust(0)("via-code")
                cCustShipViaDesc = findShipViaDesc(cCustShipViaCd)
            End If


            If IsDBNull(drCust(0)("Country")) Then
                cCustCountry = ""
            Else
                cCustCountry = drCust(0)("Country")
            End If

            If IsDBNull(drCust(0)("Telephone")) Then
                cCustPhoneNo = ""
            Else
                cCustPhoneNo = drCust(0)("Telephone")
            End If

            If IsDBNull(drCust(0)("Fax-num")) Then
                cCustFaxNo = ""
            Else
                cCustFaxNo = drCust(0)("Fax-num")
            End If

            If IsDBNull(drCust(0)("Contact")) Then
                cCustContact = ""
            Else
                cCustContact = drCust(0)("Contact")
            End If

            If IsDBNull(drCust(0)("Status-code")) Then
                cCustStatusCd = ""
            Else
                cCustStatusCd = drCust(0)("Status-code")
            End If

            If IsDBNull(drCust(0)("Slsmn-code")) Then
                cCustSlsmnCd = ""
            Else
                cCustSlsmnCd = drCust(0)("Slsmn-code")
            End If

            If IsDBNull(drCust(0)("Type-code")) Then
                cCustTypeCd = ""
            Else
                cCustTypeCd = drCust(0)("Type-code")
            End If

            If IsDBNull(drCust(0)("Term-code")) Then
                cCustTermCd = ""
            Else
                cCustTermCd = drCust(0)("Term-code")
            End If

            If IsDBNull(drCust(0)("Cred-rating")) Then
                cCustCreditRating = ""
            Else
                cCustCreditRating = drCust(0)("Cred-rating")
            End If

            If IsDBNull(drCust(0)("Charge-cust")) Then
                cCustChargeCust = ""
            Else
                cCustChargeCust = drCust(0)("Charge-cust")
            End If

            If IsDBNull(drCust(0)("Mail-cust")) Then
                cCustMailCust = ""
            Else
                cCustMailCust = drCust(0)("Mail-cust")
            End If

            If IsDBNull(drCust(0)("Stats-cust")) Then
                cCustStatsCust = ""
            Else
                cCustStatsCust = drCust(0)("Stats-cust")
            End If

            If IsDBNull(drCust(0)("Sort-name")) Then
                cCustSortName = ""
            Else
                cCustSortName = drCust(0)("Sort-name")
            End If

            If IsDBNull(drCust(0)("Cust-sh")) Then
                cCustCustSh = ""
            Else
                cCustCustSh = drCust(0)("Cust-sh")
            End If

            If IsDBNull(drCust(0)("Cust-AdDate")) Then
                cCustAddDate = ""
            Else
                cCustAddDate = drCust(0)("Cust-AdDate")
            End If

            If IsDBNull(drCust(0)("Hold-AR-Code")) Then
                cCustHoldArCode = ""
            Else
                cCustHoldArCode = drCust(0)("Hold-AR-Code")
            End If

            If IsDBNull(drCust(0)("Delq")) Then
                lCustDelq = False
            Else
                lCustDelq = drCust(0)("Delq")
            End If

            If IsDBNull(drCust(0)("slsmn-rating")) Then
                cCustSlsmnRating = ""
            Else
                cCustSlsmnRating = drCust(0)("slsmn-rating")
            End If

            If IsDBNull(drCust(0)("Last-chg-date")) Then
                cCustLastChgDate = ""
            Else
                cCustLastChgDate = drCust(0)("Last-chg-date")
            End If

            If IsDBNull(drCust(0)("ArBalance")) Then
                nCustArBalance = 0
            Else
                nCustArBalance = drCust(0)("ArBalance")
            End If

            If IsDBNull(drCust(0)("LastPayDate")) Then
                cCustLastPayDate = ""
            Else
                cCustLastPayDate = drCust(0)("LastPayDate")
            End If

            If IsDBNull(drCust(0)("LastPayAmt")) Then
                nCustLastPayAmt = 0
            Else
                nCustLastPayAmt = drCust(0)("LastPayAmt")
            End If

            If IsDBNull(drCust(0)("AvgDaysPay")) Then
                nCustAvgDaysPay = 0
            Else
                nCustAvgDaysPay = drCust(0)("AvgDaysPay")
            End If

            If IsDBNull(drCust(0)("OpenOrdTot")) Then
                nCustOpenOrdTot = 0
            Else
                nCustOpenOrdTot = drCust(0)("OpenOrdTot")
            End If

            If IsDBNull(drCust(0)("LastOrdDate")) Then
                cCustLastOrdDate = ""
            Else
                cCustLastOrdDate = drCust(0)("LastOrdDate")
            End If

            If IsDBNull(drCust(0)("LabelNo")) Then
                cCustLabelNo = ""
            Else
                cCustLabelNo = drCust(0)("LabelNo")
            End If

            If IsDBNull(drCust(0)("LastUpdated")) Then
                cCustLastUpdte = ""
            Else
                cCustLastUpdte = drCust(0)("LastUpdated")
            End If
        End If
        con.Close()
    End Sub

    ''' <summary>
    ''' This procedure sets public variables for the CustomerSH (Customer Ship To) table
    ''' </summary>
    ''' <param name="cCustNum"></param> the Customer number
    ''' <param name="cShipNum"></param> the Customer ship-to number
    ''' <remarks></remarks> The public variables are used in various places throughout the program

    Public Sub GetShipDataF(ByRef cCustNum As String, ByRef cShipNum As String)
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim daCustSh As New SaleForcDataSetTableAdapters.CustomerSHTableAdapter
        Dim dtCustSh As SaleForcDataSet.CustomerSHDataTable
        Dim drCustSh As SaleForcDataSet.CustomerSHRow

        If Trim(cCustNum) = "" Or Trim(cShipNum) = "" Then
            Exit Sub 'If there are no values, get out of here
        End If

        con.Open()
        dtCustSh = daCustSh.GetData
        drCustSh = dtCustSh.FindBy_Cust_no_Cust_sh(cCustNum, cShipNum)

        If drCustSh Is Nothing Then
            MsgBox("Missing customer ship to number")
        Else
            cShipNo = cShipNum

            If IsDBNull(drCustSh.Name) Then
                cShipName = ""
            Else
                cShipName = drCustSh.Name
            End If

            If IsDBNull(drCustSh.Address1) Then
                cShipAddr1 = ""
            Else
                cShipAddr1 = drCustSh.Address1
            End If

            If IsDBNull(drCustSh.Address2) Then
                cShipAddr2 = ""
            Else
                cShipAddr2 = drCustSh.Address2
            End If

            If IsDBNull(drCustSh.Address3) Then
                cShipAddr3 = ""
            Else
                cShipAddr3 = drCustSh.Address3
            End If

            If IsDBNull(drCustSh.City) Then
                cShipCity = ""
            Else
                cShipCity = drCustSh.City
            End If

            If IsDBNull(drCustSh.St) Then
                cShipSt = ""
            Else
                cShipSt = drCustSh.St
            End If

            If IsDBNull(drCustSh._Zip_code) Then
                cShipZip = ""
            Else
                cShipZip = drCustSh._Zip_code
            End If

            If IsDBNull(drCustSh._Via_code) Then
                cShipShipViaCd = ""
            Else
                cShipShipViaCd = drCustSh._Via_code
                cShipShipViaDesc = findShipViaDesc(cShipShipViaCd)
            End If

            If drCustSh.Country Is System.DBNull.Value Then
                cShipCountry = ""
            Else
                cShipCountry = drCustSh.Country
            End If

            If IsDBNull(drCustSh.Telephone) Then
                cShipPhoneNo = ""
            Else
                cShipPhoneNo = drCustSh.Telephone
            End If

            If IsDBNull(drCustSh.Contact) Then
                cShipContact = ""
            Else
                cShipContact = drCustSh.Contact
            End If

            If IsDBNull(drCustSh._Status_code) Then
                cShipStatusCd = ""
            Else
                cShipStatusCd = drCustSh._Status_code
            End If

            If IsDBNull(drCustSh._Type_code) Then
                cShipTypeCd = ""
            Else
                cShipTypeCd = drCustSh._Type_code
            End If

            If IsDBNull(drCustSh._Term_code) Then
                cShipTermCd = ""
            Else
                cShipTermCd = drCustSh._Term_code
            End If

            If IsDBNull(drCustSh.Complete) Then
                lShipComplete = False
            Else
                lShipComplete = drCustSh.Complete
            End If

            If IsDBNull(drCustSh.ShipActive) Then
                lShipActive = False
            Else
                lShipActive = drCustSh.ShipActive
            End If

            If IsDBNull(drCustSh.HoldShipCode) Then
                cHoldShipCd = ""
            Else
                cHoldShipCd = drCustSh.HoldShipCode
            End If

            If IsDBNull(drCustSh._Fax_num) Then
                cShipFaxNo = ""
            Else
                cShipFaxNo = drCustSh._Fax_num
            End If

            If IsDBNull(drCustSh.LastUpDate) Then
                cShipLastUpdate = ""
            Else
                cShipLastUpdate = drCustSh.LastUpDate
            End If
        End If
        con.Close()
    End Sub

    ''' <summary>
    ''' This function establishes a customer number for a new customer
    ''' </summary>
    ''' <returns></returns> This returns a new customer number which is derived from the salesman table
    ''' <remarks></remarks> This is called when the user is in the customer information screen and clicks on the new customer button

    Public Function NewCustNo() As String
        Dim cSlsmnNo, cOldNo As String
        Dim nLastNum As Integer

        Dim daCustomer As New SaleForcDataSetTableAdapters.CustomerTableAdapter
        Dim dtCustomer As New SaleForcDataSet.CustomerDataTable
        Dim drCustomer As SaleForcDataSet.CustomerRow

        Dim daSalesman As New SaleForcDataSetTableAdapters.SalesmanTableAdapter
        Dim dtSalesman As New SaleForcDataSet.SalesmanDataTable
        Dim drSalesman As SaleForcDataSet.SalesmanRow
        dtSalesman = daSalesman.GetData
        drSalesman = dtSalesman.Rows(0)

        NewCustNo = ""

        cSlsmnNo = drSalesman.SlsmnCode

        dtCustomer = daCustomer.GetData
        dtCustomer.DefaultView.Sort = "[cust-no] ASC"
        drCustomer = dtCustomer(dtCustomer.Rows.Count - 1)

        If Left(drCustomer("Cust-no"), 2) = "ZZ" Then
            cOldNo = drCustomer("Cust-no")
        Else
            cOldNo = "0"
        End If

        nLastNum = Val(Mid(cOldNo, InStr(cOldNo, "-") + 1)) + 1
        cNewCustNo = Format(nLastNum, "00#")
        NewCustNo = "ZZ" & Trim(cSlsmnNo) & "-" & cNewCustNo
        Do While DuplicateCustomer(NewCustNo) = True
            NewCustNo = "ZZ" & Trim(cSlsmnNo) & "-" & Format(cNewCustNo + 1, "00#")
        Loop
    End Function

    ''' <summary>
    ''' This function checks the customer file to see if the customer number already exists
    ''' </summary>
    ''' <param name="CustNo"></param> the customer number
    ''' <returns></returns> A boolean indicating that the customer number does or does not already exist in the database
    ''' <remarks></remarks> 

    Public Function DuplicateCustomer(ByRef CustNo As String) As Boolean
        Dim conn As New OleDb.OleDbConnection
        Dim com As New OleDb.OleDbCommand
        Dim dr As OleDb.OleDbDataReader

        conn.ConnectionString = MySettings.Default("SaleForcConnectionString")
        conn.Open()
        com.CommandText = "SELECT [cust-no] FROM CustomerSH WHERE [cust-no] = '" & CustNo & "'"
        com.Connection = conn
        dr = com.ExecuteReader()
        If dr.HasRows Then
            DuplicateCustomer = True
            Exit Function
        End If
        dr.Close()

        com.CommandText = "SELECT [cust-no] FROM [CustomerSH-history] WHERE [cust-no] = '" & CustNo & "'"
        com.Connection = conn
        dr = com.ExecuteReader
        If dr.HasRows Then
            DuplicateCustomer = True
            Exit Function
        End If
        dr.Close()

        com.CommandText = "SELECT [cust-no] FROM [Customer-History] WHERE [cust-no] = '" & CustNo & "'"
        com.Connection = conn
        dr = com.ExecuteReader
        If dr.HasRows Then
            DuplicateCustomer = True
            Exit Function
        End If
        dr.Close()
        conn.Close()
    End Function

    ''' <summary>
    ''' This function is no longer used and was not found to be in use in the previous VB6 version of this program
    ''' </summary>
    ''' <returns></returns> 
    ''' <remarks></remarks>

    Public Function isCustRecs() As Boolean
        Dim conn As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        Dim sql As String

        conn.ConnectionString = MySettings.Default("SaleForcConnectionString")
        conn.Open()
        sql = "SELECT * FROM CustomerSH"
        da = New OleDb.OleDbDataAdapter(sql, conn)

        If dt.Rows.Count Then
            isCustRecs = True
        Else
            isCustRecs = False
        End If

        conn.Close()
        conn.ConnectionString = ""
    End Function

    ''' <summary>
    ''' This procedure gets the salesman code associated with the customer number
    ''' </summary>
    ''' <param name="cCusNum"></param> the customer number
    ''' <remarks></remarks> The public variable 'cSalesmanCode' is assigned the salesman code from the customer record

    Public Sub getCustSlsmnCd(ByRef cCusNum As String)
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim daCust As New SaleForcDataSetTableAdapters.CustomerTableAdapter
        Dim dtCust As SaleForcDataSet.CustomerDataTable
        Dim drCust() As SaleForcDataSet.CustomerRow

        con.Open()
        dtCust = daCust.GetData
        drCust = dtCust.Select("[cust-no] = '" & cCusNum & "'")

        lFlagValidCust = True

        If Len(cCusNum) > 0 Then

            If drCust.Length = 0 Then
                lFlagValidCust = False
                Exit Sub
            Else
                cCustNo = cCusNum

                If IsDBNull(drCust(0)("Slsmn-code")) Then
                    Exit Sub
                Else
                    cSalesmanCode = drCust(0)("Slsmn-code")
                End If
            End If
        End If
        con.Close()
    End Sub
End Module