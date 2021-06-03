Option Strict Off
Option Explicit On
Imports System.Net.Mail

Module basGeneralProcedures


    ''' <summary>
    ''' The procedures gets the database location and sets the connection string; it also initializes global variables for salesman record
    ''' data
    ''' </summary>
    ''' <remarks></remarks>

    Public Sub GetDB()
        'Dim connectionString As String
        Dim cn As OleDb.OleDbConnection
        cn = New OleDb.OleDbConnection

        dbPath = Environment.GetEnvironmentVariable("SalesForceDBPath")
        'Dim cParams() As String = Environment.GetCommandLineArgs()
        'dbPath = cParams(1)
        'If dbPath Is Nothing Then
        '    MsgBox("SalesForceDBPath is not setup.  The program cannot continue", MsgBoxStyle.Critical, "Sales Force Automation Critical Error")
        '    End
        'End If
        dbName = Environment.GetEnvironmentVariable("SalesForceDB")
        'dbName = cParams(2)
        'If dbName Is Nothing Then
        '    MsgBox("SalesForceDB is not setup.  The program cannot continue", MsgBoxStyle.Critical, "Sales Force Automation Critical Error")
        '    End
        'End If
        dbName = dbPath & dbName
        If Not System.IO.Directory.Exists(dbPath) Then
            MsgBox("The database folder location " & (dbPath) & " does not exist, please create the folder. The program will now end.", MsgBoxStyle.Critical, "Database folder not found!")
            End
        End If
        If Not System.IO.File.Exists(dbName) Then
            MsgBox("The database does not exist in the folder: " & dbPath & ". The program will now end.", MsgBoxStyle.Critical, "Database not found!")
            End
        End If

        cn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbname '& ";Mode=""Share Exclusive"";"
        cn.Open()
        MySettingsChanger.SetConnectionString(cn.ConnectionString)
        getSlsmnInitData()
        cn.Close()
    End Sub

    ''' <summary>
    ''' This procedure kills (terminates) a process
    ''' </summary>
    ''' <param name="hwnd">The hwnd (handle) of the process to terminate</param> 
    ''' <remarks></remarks>

    Public Sub KillProcess(ByRef hwnd As Integer)
        Dim pId As Integer
        Call GetWindowThreadProcessId(hwnd, pId)
        Call TerminateProcess(OpenProcess(&H1F0FFF, 0, pId), 0)
    End Sub

    ''' <summary>
    ''' This procedure gets the next available worksheet number from the salesman file for use in creating a new worksheet
    ''' </summary>
    ''' <returns>A string variable with the worksheet number</returns> 
    ''' <remarks></remarks>

    Public Function NewWorkSheetNo() As String
        Dim conn As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable

        conn.ConnectionString = MySettings.Default("SaleForcConnectionString")
        conn.Open()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM Salesman", conn)
        da.Fill(dt)
        conn.Close()

        Dim xWorkShtNum As String
        Dim cSlsmCd As String
        Dim fileWsNo As Integer

        NewWorkSheetNo = vbNullString

        nWorkSheetNum = dt.Rows(0)("WorksheetNo")
        cSlsmCd = Trim(dt.Rows(0)("SlsmnCode"))
        fileWsNo = nWorkSheetNum
        Do
            cWorkshtNum = Right("00000" & Mid(Str(nWorkSheetNum), 2), 6)
            xWorkShtNum = cSlsmCd & "-" & cWorkshtNum
            If Not isWorkSheetNoUsed(xWorkShtNum) Then
                NewWorkSheetNo = cSlsmCd & "-" & cWorkshtNum
                cNewWsNo = "C" 'Set new worksheet flag to True
                Exit Function
            End If

            nWorkSheetNum = nWorkSheetNum + 1
            If nWorkSheetNum > 999999 Then nWorkSheetNum = 1000
        Loop
    End Function

    ''' <summary>
    ''' This procedure is no longer used
    ''' </summary>
    ''' <param name="nManWsNo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function NewWorkSheetNoM(ByRef nManWsNo As Integer) As String
        Dim conn As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable

        conn.ConnectionString = MySettings.Default("SaleForcConnectionString")
        conn.Open()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM Salesman", conn)
        da.Fill(dt)
        conn.Close()

        Dim cSlsmCd As String

        If dt.Rows.Count = 0 Then
            NewWorkSheetNoM = nManWsNo
            Exit Function
        End If
        cSlsmCd = Trim(dt.Rows(0)("SlsmnCode"))

        cWorkshtNum = Right("00000" & Mid(Str(nManWsNo), 2), 6)
        NewWorkSheetNoM = cSlsmCd & "-" & cWorkshtNum
        cNewWsNo = "M" 'Set new worksheet flag to True
    End Function

    ''' <summary>
    ''' This procedure sets up some public variable associated with the salesman table for use throughout the program
    ''' </summary>
    ''' <remarks></remarks>

    Public Sub getSlsmnInitData()
        Dim conn As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable

        conn.ConnectionString = MySettings.Default("SaleForcConnectionString") '& ";OLE DB Services=-4;"
        conn.Open()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM Salesman", conn)
        da.Fill(dt)
        conn.Close()

        cSalesmanCode = dt.Rows(0)("SlsmnCode").ToString
        cSalesmanName = dt.Rows(0)("Name").ToString
        cSalesmanEmail = dt.Rows(0)("Email").ToString
        dDeliverDate = dt.Rows(0)("request-Date")
        If CDate(dDeliverDate) < Today Then
            dDeliverDate = CStr(Today)
        End If
        dCancelDate = dt.Rows(0)("cancel-date")
        If CDate(dCancelDate) <= Today Then
            dCancelDate = CStr(System.DateTime.FromOADate(Today.ToOADate + 1))
        End If
        cSalesSeason = dt.Rows(0)("season").ToString
        cOrderCode = dt.Rows(0)("order-code").ToString
        cViaCode = dt.Rows(0)("ViaCode").ToString
        cTermCode = dt.Rows(0)("TermCode").ToString

        If Left(cCustNumber, 2) <> "ZZ" Then
            getCustSlsmnCd(cCustNumber)
        End If
    End Sub

    ''' <summary>
    ''' use the following to increment the worksheet number base when when saving the worksheet
    ''' </summary>
    ''' <remarks></remarks>

    Public Sub SetNewWsNo()
        Dim daSalesman As New SaleForcDataSetTableAdapters.SalesmanTableAdapter
        Dim dtSalesman As SaleForcDataSet.SalesmanDataTable
        Dim drSalesman As SaleForcDataSet.SalesmanRow

        dtSalesman = daSalesman.GetData
        drSalesman = dtSalesman.Rows(0)
        drSalesman.BeginEdit()
        drSalesman.WorksheetNo = nWorkSheetNum + 1
        drSalesman.EndEdit()
        daSalesman.Update(dtSalesman)
    End Sub

    ''' <summary>
    ''' This procedure checks to see if an item is found in the item table
    ''' </summary>
    ''' <param name="cItemNum">The item number to check</param> 
    ''' <returns>Boolean indicating whether the item is valid (true) or not valid (false)</returns> 
    ''' <remarks></remarks>

    Public Function isValidItemNo(ByRef cItemNum As String) As Boolean
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim daItem As New SaleForcDataSetTableAdapters.ItemTableAdapter
        Dim dtItem As SaleForcDataSet.ItemDataTable

        con.Open()
        dtItem = daItem.GetDataByItem(cItemNum)

        isValidItemNo = False ' Item not found

        If dtItem.Rows.Count = 0 Then
            Exit Function
        ElseIf dtItem.Rows(0)("CanBeOrdered") = False Then
            Exit Function
        Else
            isValidItemNo = True
            Exit Function
        End If
        con.Close()
    End Function

    ''' <summary>
    ''' This procedure is no longer in use
    ''' </summary>
    ''' <param name="vDate"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function isDateValid(ByRef vDate As String) As Boolean
        Dim msg, cMon As String
        Dim nSep As Short
        If IsDate(vDate) = True Then
            nSep = InStr(vDate, "/")
            If nSep = 2 Or nSep = 3 Then
                cMon = Left(vDate, nSep - 1)
                If Val(cMon) > 0 And Val(cMon) < 13 Then
                    isDateValid = True
                    Exit Function
                Else
                    isDateValid = False
                End If
            End If
        Else
            isDateValid = False
        End If
        msg = "NOT A VALID DATE" & vbCrLf & vbCrLf
        msg = msg & "Use format  mm/dd/yy"
        Beep()
        Beep()
        MsgBox(msg, , "ATTENTION")
    End Function

    ''' <summary>
    ''' This procedure is no longer in use
    ''' </summary>
    ''' <param name="cSvCode"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function isValidShipViaCd(ByRef cSvCode As String) As Boolean
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim daShipVia As New SaleForcDataSetTableAdapters.ShipViaCodeTableAdapter
        Dim dtShipVia As SaleForcDataSet.ShipViaCodeDataTable
        Dim drShipVia As SaleForcDataSet.ShipViaCodeRow

        con.Open()
        dtShipVia = daShipVia.GetData
        drShipVia = dtShipVia.FindByViaCode(cSvCode)

        If drShipVia Is Nothing Then
            isValidShipViaCd = False
        Else
            isValidShipViaCd = True
            cShipViaDesc = drShipVia("ViaDesc")
        End If
        con.Close()
    End Function

    ''' <summary>
    ''' This procedure finds the ship via code based on the ship via description
    ''' </summary>
    ''' <param name="cSvDesc"> The ship via description that is associated with the ship via code being sought</param>
    ''' <returns>A string variable with the ship via code</returns>
    ''' <remarks></remarks>

    Public Function findShipViaCd(ByRef cSvDesc As String) As String
        Dim conn As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable

        conn.ConnectionString = MySettings.Default("SaleForcConnectionString")
        conn.Open()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM ShipViaCode WHERE [viadesc] = '" & cSvDesc & "'", conn)
        da.Fill(dt)
        conn.Close()

        If dt.Rows.Count = 0 Then
            findShipViaCd = vbNullString
        Else
            findShipViaCd = dt.Rows(0)("ViaCode")
        End If
    End Function

    ''' <summary>
    ''' This procedure is no longer in use
    ''' </summary>
    ''' <remarks></remarks>

    Public Sub findFirstShipViaCode()
        Dim conn As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable

        conn.ConnectionString = MySettings.Default("SaleForcConnectionString")
        conn.Open()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM ShipViaCode", conn)
        da.Fill(dt)
        conn.Close()

        frmWorksheet.txtShipVia.Text = dt.Rows(0)("ViaCode")
        frmWorksheet.lblShipViaDesc.Text = dt.Rows(0)("ViaDesc")
    End Sub

    ''' <summary>
    ''' This procedures get the ship via description
    ''' </summary>
    ''' <param name="cSvCode"></param> The ship via code
    ''' <returns>A string with the ship via code description</returns> 
    ''' <remarks></remarks>

    Public Function findShipViaDesc(ByRef cSvCode As String) As String
        Dim conn As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable

        conn.ConnectionString = MySettings.Default("SaleForcConnectionString")
        conn.Open()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM ShipViaCode WHERE [viacode] = '" & cSvCode & "'", conn)
        da.Fill(dt)

        If dt.Rows.Count = 0 Then
            findShipViaDesc = vbNullString
        Else
            findShipViaDesc = dt.Rows(0)("ViaDesc")
        End If
        conn.Close()
    End Function

    ''' <summary>
    ''' This procedures deletes all records in the worksheet items temp file
    ''' </summary>
    ''' <remarks></remarks>

    Public Sub ClrWSItemTemp()
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim com As New OleDb.OleDbCommand("DELETE * FROM WsItemTemp", con)
        con.Open()
        com.ExecuteNonQuery()
        con.Close()
        frmWorksheet.dgvTempItems.DataSource = Nothing
        frmWorksheet.lblTotQty.Text = "0"
        frmWorksheet.lblTotExtended.Text = "$0.00"
    End Sub

    ''' <summary>
    ''' This procedure is no longer used
    ''' </summary>
    ''' <remarks>Item number in file but item not orderable</remarks>

    Public Sub WarnNotOrderable()
        Dim msg As String
        msg = "Your item was found but this is" & vbCrLf
        msg = msg & "not an orderable item. You must" & vbCrLf
        msg = msg & "make the appropriate changes to" & vbCrLf
        msg = msg & "make this an orderable item before" & vbCrLf
        msg = msg & "the Worksheet can be transmitted"
        MsgBox(msg, MsgBoxStyle.OkOnly, "NOTICE")
    End Sub

    ''' <summary>
    ''' This procedure is no longer in use
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function WarnOutsideDateRange() As String ' Requested date is outside item begin/end date range
        Dim msg As String

        msg = "The requested date for this item is outside the" & vbCrLf
        msg = msg & "begin-ship and end-ship dates for the item" & vbCrLf
        msg = msg & "Be aware this could be a problem"
        WarnOutsideDateRange = CStr(MsgBox(msg, MsgBoxStyle.OkCancel, "WARNING"))
    End Function

    ''' <summary>
    ''' This procedure checks to see if the table is empty
    ''' </summary>
    ''' <param name="nTblNo">The table name that is being checked</param> 
    ''' <returns>A boolean indicating that the table is empty (true) or not empty (false)</returns> 
    ''' <remarks></remarks>

    Public Function isTableEmpty(ByRef nTblNo As Short) As Boolean
        Dim cn As New OleDb.OleDbConnection
        Dim da As New OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        cn.ConnectionString = MySettings.Default("SaleForcConnectionString")
        cn.Open()

        isTableEmpty = False
        Select Case nTblNo
            Case 1 ' Customer
                da = New OleDb.OleDbDataAdapter("SELECT TOP 1 * FROM [customer]", cn)
            Case 2 ' Item
                da = New OleDb.OleDbDataAdapter("SELECT TOP 1 * FROM [item]", cn)
            Case 3 ' Order
                da = New OleDb.OleDbDataAdapter("SELECT TOP 1 * FROM [order]", cn)
            Case 4 ' Worksheet
                da = New OleDb.OleDbDataAdapter("SELECT TOP 1 * FROM [ws-ord-head]", cn)
            Case 5 ' Salesman
                da = New OleDb.OleDbDataAdapter("SELECT TOP 1 * FROM [salesman]", cn)
            Case 6 ' Error messages
                da = New OleDb.OleDbDataAdapter("SELECT TOP 1 * FROM [wserrormsg]", cn)
            Case Else
        End Select
        da.Fill(dt)
        cn.Close()
        If dt.Rows.Count = 0 Then
            isTableEmpty = True
        End If
        cn.Close()
    End Function

    ''' <summary>
    ''' This procedure is used to sort an array of string items
    ''' </summary>
    ''' <param name="Aray">The name of the array</param> 
    ''' <remarks></remarks>

    Public Sub BubbleSort(ByRef Aray() As String)
        Dim OutOfOrder As Boolean
        Dim cTemp As String
        Dim x As Short
        Do
            OutOfOrder = False
            For x = 1 To UBound(Aray) - 1
                If Aray(x) > Aray(x + 1) Then
                    cTemp = Aray(x)
                    Aray(x) = Aray(x + 1)
                    Aray(x + 1) = cTemp
                    cTemp = vbNullString
                    OutOfOrder = True
                End If
            Next
        Loop While OutOfOrder
    End Sub

    ''' <summary>
    ''' This procedure validates the season code that is being passed in and sets public season code variables
    ''' </summary>
    ''' <param name="cCode">The name of the season code to validate</param> 
    ''' <returns>Boolean indicating that the season code is valid (true) or not valid (false)</returns>
    ''' <remarks></remarks>

    Public Function isValidSeasonCd(ByRef cCode As String) As Boolean
        Dim conn As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable

        conn.ConnectionString = MySettings.Default("SaleForcConnectionString")
        conn.Open()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM season WHERE [season].[season] = '" & cCode & "'", conn)
        da.Fill(dt)
        conn.Close()

        If dt.Rows.Count = 0 Then
            isValidSeasonCd = False
            cSeasonDesc = vbNullString
            cSeasonCd = cCode
        Else
            isValidSeasonCd = True
            cSeasonDesc = dt.Rows(0)("description")
            cSeasonCd = cCode
        End If
    End Function

    ''' <summary>
    ''' This procedure finds a season code in the season file 
    ''' </summary>
    ''' <param name="cDesc">The season description to look for in the season file</param> 
    ''' <returns> Season Code </returns> 
    ''' <remarks></remarks>

    Public Function findSeasonCd(ByRef cDesc As String) As String
        Dim conn As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable

        conn.ConnectionString = MySettings.Default("SaleForcConnectionString")
        conn.Open()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM season WHERE [description] = '" & cDesc & "'", conn)
        da.Fill(dt)
        conn.Close()
        If dt.Rows.Count = 0 Then
            cSeasonDesc = vbNullString
            cSeasonCd = vbNullString
            findSeasonCd = vbNullString
        Else
            cSeasonDesc = cDesc
            cSeasonCd = dt.Rows(0)("Season")
            findSeasonCd = dt.Rows(0)("Season")
        End If
    End Function

    ''' <summary>
    ''' This procedure finds a season code description
    ''' </summary>
    ''' <param name="cCode">The season code being sought</param> 
    ''' <returns>A string variable with the season code description</returns> 
    ''' <remarks></remarks>

    Public Function findSeasonDesc(ByRef cCode As String) As String
        Dim x As Boolean
        x = isValidSeasonCd(cCode)
        If x = True Then
            findSeasonDesc = cSeasonDesc
        Else
            findSeasonDesc = vbNullString
        End If
    End Function

    ''' <summary>
    ''' This procedure checks if an order type code is found in the ordertype table
    ''' </summary>
    ''' <param name="cCode">The order type code being checked</param> 
    ''' <returns>A Boolean indicating that the order type code is valid (true) or not valid (false)</returns> 
    ''' <remarks></remarks>

    Public Function isValidOrderType(ByRef cCode As String) As Boolean
        Dim conn As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable

        conn.ConnectionString = MySettings.Default("SaleForcConnectionString")
        conn.Open()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM OrderType WHERE [ordercode] = '" & cCode & "'", conn)
        da.Fill(dt)
        conn.Close()

        If dt.Rows.Count = 0 Then
            isValidOrderType = False
            cOrdTypeDesc = vbNullString
            cOrdTypeCode = cCode
        Else
            isValidOrderType = True
            cOrdTypeDesc = dt.Rows(0)("description")
            cOrdTypeCode = cCode
        End If
    End Function

    ''' <summary>
    ''' This procedure attempts to find an order type code 
    ''' </summary>
    ''' <param name="cDesc">Order type description</param> 
    ''' <returns>Order type code</returns> 
    ''' <remarks></remarks>

    Public Function findOrderTypeCd(ByRef cDesc As String) As String
        Dim conn As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable

        conn.ConnectionString = MySettings.Default("SaleForcConnectionString")
        conn.Open()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM OrderType WHERE [description] =  '" & cDesc & "'", conn)
        da.Fill(dt)
        conn.Close()

        If dt.Rows.Count = 0 Then
            findOrderTypeCd = vbNullString
            cOrdTypeDesc = vbNullString
            cOrdTypeCode = vbNullString
        Else
            findOrderTypeCd = dt.Rows(0)("OrderCode")
            cOrdTypeDesc = cDesc
            cOrdTypeCode = dt.Rows(0)("OrderCode")
        End If
    End Function

    ''' <summary>
    '''  This procedures finds an order type description
    ''' </summary>
    ''' <param name="cCode">Order type code</param> 
    ''' <returns>Order type description</returns> 
    ''' <remarks></remarks>

    Public Function findOrdTypeDesc(ByRef cCode As String) As String
        Dim x As Boolean
        x = isValidOrderType(cCode)
        If x = True Then
            findOrdTypeDesc = cOrdTypeDesc
        Else
            findOrdTypeDesc = vbNullString
        End If
    End Function

    ''' <summary>
    ''' This procedures writes to the application log file
    ''' </summary>
    ''' <param name="nCase">The type of entry to make in the log file</param> 
    ''' <param name="cMsg">The message to insert into the log file</param> 
    ''' <remarks></remarks>

    Public Sub logFileAdd(ByRef nCase As Short, ByRef cMsg As String)
        Dim logBuf As Short
        logBuf = FreeFile()
        FileOpen(logBuf, filCommLog, OpenMode.Append)
        Select Case nCase
            Case 1
                PrintLine(logBuf, "[Export]", DateString, TimeString, cMsg)
            Case 2
                PrintLine(logBuf, "[Import]", DateString, TimeString, cMsg)
            Case 3
                PrintLine(logBuf, "[ReSetXmit]", DateString, TimeString, cMsg)
            Case 4
                PrintLine(logBuf, "[ProComm}", DateString, TimeString, cMsg)
            Case 5
                PrintLine(logBuf, "[LastXmitList]", DateString, TimeString, cMsg)
            Case 6
                PrintLine(logBuf, "[dbRepair]", DateString, TimeString, cMsg)
        End Select
        FileClose(logBuf)
    End Sub

    ''' <summary>
    ''' This procedure will see if the worksheet number is used in the ws-ord-head or order tables
    ''' </summary>
    ''' <param name="cWsNo">The worksheet number to check</param>
    ''' <returns> A boolean variable that indicates that the worksheet is used (true) or not used (false)</returns>
    ''' <remarks></remarks>

    Public Function isWorkSheetNoUsed(ByRef cWsNo As String) As Boolean
        Dim conn As New OleDb.OleDbConnection
        Dim daWS As OleDb.OleDbDataAdapter
        Dim dtWS As New DataTable
        Dim daOrd As OleDb.OleDbDataAdapter
        Dim dtOrd As New DataTable

        conn.ConnectionString = MySettings.Default("SaleForcConnectionString")
        conn.Open()
        daWS = New OleDb.OleDbDataAdapter("SELECT * FROM [ws-ord-head] WHERE [worksheet-id] = '" & cWsNo & "'", conn)
        daWS.Fill(dtWS)

        If dtWS.Rows.Count = 0 Then
            ' --- Search Order file for duplicate ------------------
            daOrd = New OleDb.OleDbDataAdapter("SELECT * FROM [Order] WHERE [worksheetid] = '" & cWsNo & "'", conn)
            daOrd.Fill(dtOrd)

            If dtOrd.Rows.Count = 0 Then
                isWorkSheetNoUsed = False
            Else
                isWorkSheetNoUsed = True

            End If
        Else
            isWorkSheetNoUsed = True
        End If
        conn.Close()
    End Function

    ''' <summary>
    ''' This procedure displays help messages when entering worksheet information
    ''' </summary>
    ''' <param name="nHlpNo">The help message number</param>
    ''' <returns> The help message text</returns>
    ''' <remarks></remarks>

    Public Function HelpMsgWs(ByRef nHlpNo As Short) As String
        Select Case nHlpNo
            '--- Worksheet header data input
            Case 1
                HelpMsgWs = "Enter the delivery location"
            Case 2
                HelpMsgWs = "Enter the customer purchase order number"
            Case 3
                HelpMsgWs = "Check if the order is to be shipped in one shipment"
            Case 4
                HelpMsgWs = "Enter the date that the order should start shipping on"
            Case 5
                HelpMsgWs = "Enter the date that the order should be complete by"
            Case 6
                HelpMsgWs = "Select the Season from the pop-up list"
            Case 7
                HelpMsgWs = "Select the order code from the pop-up list"
            Case 8
                HelpMsgWs = "Select the Ship Via type from the pop-up list"
            Case 9
                HelpMsgWs = "Check this box to cancel this worksheet"
            Case 10
                HelpMsgWs = "Check this box when Worksheet is ready to transmit"
                '--- Help for the command buttons
            Case 21
                HelpMsgWs = "Exit the worksheet"
            Case 22
                HelpMsgWs = "Print the worksheet"
            Case 23
                HelpMsgWs = "Display the Items list"
            Case 24
                HelpMsgWs = vbNullString
            Case Else
                HelpMsgWs = vbNullString
        End Select

    End Function

    ''' <summary>
    ''' This procedure sets the 'canmaintain' field of the wserrmsg record equal to the 'allow-manual-maint' of the ws-ord-head record
    ''' </summary>
    ''' <remarks>If the worksheet is not maintainable, the worksheet error msg table should not be either</remarks>

    Public Sub PurgeErrorMsgFile()
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim daWsErrMsg As New SaleForcDataSetTableAdapters.WSErrorMsgTableAdapter
        Dim daWsOrdHead As New SaleForcDataSetTableAdapters.ws_ord_headTableAdapter
        Dim dtWsErrMsg As SaleForcDataSet.WSErrorMsgDataTable
        Dim dtWsOrdHead As SaleForcDataSet._ws_ord_headDataTable
        Dim drWsOrdHead As SaleForcDataSet._ws_ord_headRow
        Dim i As Integer

        dtWsErrMsg = daWsErrMsg.GetData()
        dtWsOrdHead = daWsOrdHead.GetData()

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        If dtWsErrMsg.Rows.Count = 0 Then
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Exit Sub
        End If

        For i = 0 To dtWsErrMsg.Rows.Count - 1
            drWsOrdHead = dtWsOrdHead.FindBy_worksheet_id(dtWsErrMsg.Item(i)("worksheet-id"))
            If drWsOrdHead Is Nothing Then
                dtWsErrMsg.Rows(i).Delete() ' if record is corrupt then delete it
            Else
                If dtWsErrMsg.Rows(i)("canmaintain") <> drWsOrdHead("allow-manual-maint") Then
                    dtWsErrMsg.Rows(i).BeginEdit()
                    dtWsErrMsg.Rows(i)("canmaintain") = drWsOrdHead("allow-manual-maint") '
                    dtWsErrMsg.Rows(i).EndEdit()
                    daWsErrMsg.Update(dtWsErrMsg)
                End If
            End If
        Next
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    ''' <summary>
    ''' This procedure finds a customer name in the customer table
    ''' </summary>
    ''' <param name="CustNum">The customer number</param>
    ''' <returns>A string variable containing the customer name</returns>
    ''' <remarks></remarks>

    Public Function findWsCustName(ByRef CustNum As String) As String
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim daCust As New SaleForcDataSetTableAdapters.CustomerTableAdapter
        Dim dtCust As New SaleForcDataSet.CustomerDataTable

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        con.Open()
        dtCust = daCust.GetDataByCustNo(CustNum)

        If dtCust.Rows.Count = 0 Then
            findWsCustName = "No Customer Name"
        Else
            findWsCustName = dtCust.Rows(0)("name")
        End If
        con.Close()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Function

    ''' <summary>
    ''' This procedure finds a customer number associated with a worksheet
    ''' </summary>
    ''' <param name="WsNum">A worksheet number</param>
    ''' <returns>if the worksheet number is found in the ws-ord-head table a string containing the customer number is returned </returns>
    ''' <remarks></remarks>

    Public Function findWsCustNo(ByRef WsNum As String) As String
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim daWsOrdHead As New SaleForcDataSetTableAdapters.ws_ord_headTableAdapter
        Dim dtWsOrdHead As SaleForcDataSet._ws_ord_headDataTable
        Dim drWsOrdHead As SaleForcDataSet._ws_ord_headRow

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        con.Open()
        dtWsOrdHead = daWsOrdHead.GetData
        drWsOrdHead = dtWsOrdHead.FindBy_worksheet_id(WsNum)

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        If drWsOrdHead Is Nothing Then
            findWsCustNo = "No Worksheet"
        Else
            If Not IsDBNull(drWsOrdHead("cust-no")) And Not IsDBNull(drWsOrdHead("allow-manual-maint")) Then
                findWsCustNo = drWsOrdHead("cust-no")
                lCanMaintain = drWsOrdHead("allow-manual-maint")
            Else
                findWsCustNo = "No Worksheet"
            End If
        End If
        con.Close()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Function

    ''' <summary>
    ''' This procedures sends an email with the name and attached file that was not successfully imported into the database
    ''' </summary>
    ''' <param name="BadFile">The new name of the 'bad' file</param>
    ''' <param name="FilePath">The path to the 'bad' file</param>
    ''' <remarks></remarks>

    Public Sub EmailBadFiles(ByRef BadFile As String, ByRef FilePath As String)
        'Dim OutlookApp As Microsoft.Office.Interop.Outlook.Application
        'Dim OutlookNameSpace As Microsoft.Office.Interop.Outlook.NameSpace
        'OutlookApp = New Microsoft.Office.Interop.Outlook.Application
        'OutlookNameSpace = OutlookApp.GetNamespace("MAPI")
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim daSalesman As New SaleForcDataSetTableAdapters.SalesmanTableAdapter
        Dim dtSalesman As SaleForcDataSet.SalesmanDataTable

        'Dim smtpClient As New SmtpClient(GetProgramDefaults("SMTPServer"))

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        con.Open()
        dtSalesman = daSalesman.GetData

        'Dim mailmessage1 As New MailMessage(cSalesmanEmail, dtSalesman.Rows(0)("supportemailaddr"), "Sales Force Automation Bad File: " & BadFile, "There was an error importing file " & BadFile & ".")

        Dim filename As New System.IO.FileInfo(FilePath & BadFile)

        'mailmessage1.Attachments.Add(New Attachment(filename.FullName))
        'smtpClient.Send(mailmessage1)
        Email(dtSalesman.Rows(0)("supportemailaddr"), "Sales Force Automation Bad File: " & BadFile, "There was an error importing file " & BadFile & ".", filename.FullName, True)
        con.Close()

        'OutlookNameSpace.Logoff()
        'OutlookApp.Quit()
    End Sub

    ''' <summary>
    ''' This procedure sends an email using an SMTP client
    ''' </summary>
    ''' <param name="recipient">The email address of the recipient</param>
    ''' <param name="subject">The subject of the email</param>
    ''' <param name="body">The body of the email</param>
    ''' <param name="attachment">The attachement path</param>
    ''' <param name="ishtml">A boolean variable indicating that this email should be in HTML format (true) or in plain text (false)</param>
    ''' <remarks></remarks>

    Public Sub Email(ByRef recipient As String, ByRef subject As String, ByRef body As String, ByRef attachment As String, ByRef ishtml As Boolean)
        'Dim OutlookApp As Microsoft.Office.Interop.Outlook.Application
        'OutlookApp = New Microsoft.Office.Interop.Outlook.Application

        'Dim dasalesman As New SaleForcDataSetTableAdapters.SalesmanTableAdapter
        'Dim dtsalesman As SaleForcDataSet.SalesmanDataTable

        'dtsalesman = dasalesman.GetData

        'Dim mailmessage1 As New MailMessage(cSalesmanEmail, recipient, subject, body)

        'Dim smtpClient As New SmtpClient(GetProgramDefaults("SMTPServer"))
        'With mailmessage1
        '    If attachment > "" Then
        '        .Attachments.Add(New Attachment(attachment))
        '    End If
        '    .IsBodyHtml = ishtml
        'End With
        'smtpClient.Send(mailmessage1)
        'OutlookApp.Quit()
        Try
            Dim Outlook As Outlook.Application
            Dim Mail As Outlook.MailItem

            Outlook = New Outlook.Application()
            Mail = Outlook.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem)
            Mail.To = recipient
            Mail.Subject = subject
            If attachment <> "" And System.IO.File.Exists(attachment) Then Mail.Attachments.Add(attachment)
            Mail.HTMLBody &= body
            Mail.Send()
            'Process.Start("mailto:support@stcroixcollections.com?subject=Hello&body=test")
        Catch exc As Exception
            MsgBox("Email send Failed. Please contact support", MsgBoxStyle.Information, "Email Failed")
        End Try
    End Sub

    ''' <summary>
    ''' This procedure sends an email using Microsoft Office Outlook and displays a user interface for users to interact with
    ''' </summary>
    ''' <param name="recipient">The email address of the recipient</param>
    ''' <param name="subject">The subject of the email</param>
    ''' <param name="body">The body of the email</param>
    ''' <param name="attachment">The attachement path</param>
    ''' <remarks></remarks>

    Public Sub EmailWithDisplay(ByRef recipient As String, ByRef subject As String, ByRef body As String, ByRef attachment As String)
        'Try
        Dim OutlookApp As Microsoft.Office.Interop.Outlook.Application
        Dim OutlookNameSpace As Microsoft.Office.Interop.Outlook.NameSpace
        OutlookApp = New Microsoft.Office.Interop.Outlook.Application
        OutlookNameSpace = OutlookApp.GetNamespace("MAPI")
        Dim objNewMail As Microsoft.Office.Interop.Outlook.MailItem

        objNewMail = OutlookApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem)

        With objNewMail
            .Recipients.Add(recipient)
            .Subject = subject
            .BodyFormat = Microsoft.Office.Interop.Outlook.OlBodyFormat.olFormatHTML
            .HTMLBody = body
        End With

        If Len(Trim(attachment)) > 0 Then
            objNewMail.Attachments.Add(attachment)
        End If

        objNewMail.Display(True)
        'OutlookApp.ActiveWindow.activate()

        If IsProcessRunning("Outlook.exe") Then
            AppActivate("Outlook.exe") 'make Outlook top most window

            Do While OutlookApp.Inspectors.Count > 0
                'just hang out until the appointment window is closed.
            Loop
            OutlookNameSpace.Logoff()
        End If
    End Sub

    ''' <summary>
    ''' This procedure will start a process
    ''' </summary>
    ''' <param name="cmdline">The path of the process to start</param>
    ''' <remarks></remarks>

    Public Sub RunShell(ByRef cmdline As String)
        Dim hProcess As Integer
        Dim ProcessId As Integer
        Dim exitCode As Integer

        ProcessId = Shell(cmdline, 1)
        hProcess = OpenProcess(PROCESS_QUERY_INFORMATION, False, ProcessId)

        Do
            Call GetExitCodeProcess(hProcess, exitCode)
            System.Windows.Forms.Application.DoEvents()
        Loop While exitCode > 0 '= STATUS_PENDING

        Call CloseHandle(hProcess)

    End Sub

    ''' <summary>
    ''' This procedure determines if there is an internet connection
    ''' </summary>
    ''' <returns>A boolean indicating that there is internet connection (true) or there isn't an internet connection (false) </returns>
    ''' <remarks></remarks>

    Function Connection() As Boolean
        Dim Flags As Integer
        If InternetGetConnectedState(Flags, 0) Then Connection = True
    End Function

    ''' <summary>
    ''' This procedure is no longer in use
    ''' </summary>
    ''' <param name="box"></param>
    ''' <param name="msfx"></param>
    ''' <param name="ind"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function TextSearch(ByRef box As System.Windows.Forms.TextBox, ByRef msfx As DataGridView, ByRef ind As Short) As Short
        Dim boxIndex As Short
        Dim posCursor As Short
        Dim BoxX As Short
        Dim txt As String
        Dim lExst As Boolean
        txt = Trim(box.Text)

        posCursor = box.SelectionStart

        lExst = False
        ' Go in cycle through the combo box list to find the appropriate entry in the list

        For boxIndex = ind To msfx.Rows.Count - 1
            For BoxX = 0 To msfx.Columns.Count - 1
                If InStr(1, UCase(msfx.Item(boxIndex, BoxX).Value), txt) <> 0 Then
                    lExst = True
                    TextSearch = boxIndex
                    Exit Function
                End If
            Next BoxX
        Next boxIndex
        ' We didn't find appropriate entry and return previous value to text box
        If Not lExst Then
            MsgBox("End of Search", MsgBoxStyle.Information)
            TextSearch = msfx.Rows.Count + 1
        End If
    End Function

    ''' <summary>
    ''' This procedure sets a string to proper case (each separate word is capitalized)
    ''' </summary>
    ''' <param name="AnyValue">A string value</param>
    ''' <returns>A string value in proper case</returns>
    ''' <remarks></remarks>

    Public Function Proper(ByRef AnyValue As String) As String
        Dim ptr As Short
        Dim TheString As String = Nothing
        Dim currChar As String = Nothing
        Dim prevChar As String = Nothing

        If IsDBNull(AnyValue) Then
            Proper = AnyValue
            Exit Function
        End If

        TheString = CStr(AnyValue)
        For ptr = 1 To Len(TheString) ' Go through each char. in string.
            currChar = Mid(TheString, ptr, 1) ' Get the current character.

            Select Case prevChar ' If previous char. is a
                ' letter,'this char. should be lowercase.
                Case "A" To "Z", "a" To "z"
                    Mid(TheString, ptr, 1) = LCase(currChar)
                Case Else
                    Mid(TheString, ptr, 1) = UCase(currChar)

            End Select
            prevChar = currChar
        Next ptr
        Proper = CObj(TheString)
    End Function

    ''' <summary>
    ''' This procedure checks to see if a process is running
    ''' </summary>
    ''' <param name="name">The process name</param>
    ''' <returns>A boolean indicating whether a process is running (true) or not (false)</returns>
    ''' <remarks></remarks>

 
    Public Function IsProcessRunning(ByVal name As String) As Boolean
        Dim Procs() As Process = Process.GetProcessesByName(name)
        Dim MyProc As Process = Process.GetCurrentProcess
        Dim CntProcesses As Integer = 0
        For index As Integer = 0 To Procs.Length - 1
            If Procs(index).SessionId = MyProc.SessionId Then CntProcesses += 1
        Next
        If CntProcesses >= 1 Then Return True
        Return False
    End Function
    'Public Function IsProcessRunning(ByVal name As String) As Boolean
    '    'here we're going to get a list of all running processes on
    '    'the computer
    '    If Process.GetProcessesByName(name).Length < 1 Then
    '        Return False
    '    End If
    '    'process found, return true
    '    Return True
    'End Function

    ''' <summary>
    ''' This procedure emails a worksheet  
    ''' </summary>
    ''' <param name="worksheetid">The worksheet number being emailed</param>
    ''' <param name="custemail">The email address of the customer that the report is being mailed to</param>
    ''' <remarks></remarks>

    Public Sub EmailWorksheets(ByRef worksheetid As String, ByRef custemail As String)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim cSelectCriteria As String
        Dim report1 As New WkstAndMemoReport
        Dim emailaddr As String
        Dim EmailBodyText As String
        Dim mailNewLine As String
        Dim result As MsgBoxResult
        Dim tbl As CrystalDecisions.CrystalReports.Engine.Table
        Dim crtablelogoninfo = New CrystalDecisions.Shared.TableLogOnInfo

        If Not IsProcessRunning("Outlook") Then
            MsgBox("Outlook is not running, please start Outlook and try again.", MsgBoxStyle.Information, "Email Worksheet Outlook not running")
            Exit Sub
        End If


        mailNewLine = "%0D%0A"

        EmailBodyText = "Thank you for your order.  Please find your order summary attached.<br><br><br> This worksheet does not constitute a binding order.  Knitcraft shall be bound to sell customer only those goods for which Knitcraft  sends customer an Order Confirmation, subject to any reductions made in Knitcraft’s discretion.  Knitcraft may reduce any confirmed order in its sole and complete discretion.  Knitcraft is not responsible for delays beyond it’s control. <br><br><b>Terms and Conditions of Agreement:</b> Terms begin with date of shipment (Invoice Date) FOB Winona, Minnesota.  All payments are due within Terms (number of days) stated herein.  Payments not received by Knitcraft within Terms stated are 'Past Due' and constitute a default (breach) by customer.  Discount terms apply only if payment is received on or before the due date.  All worksheets submitted are subject to credit approval.Finance charges in the amount of 1½ percent per month, or the maximum amount allowed by law, will be charged on past due accounts.  Absolutely no extra dating is allowed.  Knitcraft is a made-to-order company.  No order may be cancelled or returned by customer once confirmed by Knitcraft.  All orders of 5 pieces or less are subject to a $3 service and handling charge.  In the event customer breaches This Agreement, customer agrees to immediately pay to Knitcraft all damages sustained by Knitcraft, including the full price of all ordered merchandise, whether shipped or not, together with applicable shipping charges.  Customer agrees to pay all of Knitcraft’s costs of collection including Knitcraft's reasonable attorneys’ fees.  Consent to Jurisdiction and Venue and Choice of Law:  Customer consents to jurisdiction in the State of Minnesota, County of Winona.  Customer agrees that any litigation between customer and Knitcraft may be brought in Winona County District Court, State of Minnesota and customer agrees and consents to such venue.  Customer also agrees that the law of the State of Minnesota shall apply to any dispute between the parties. <br><br><hr size=2 width='100%' align=center tabindex=-1>" & "<b>NOTE:</b>  You will need Adobe Acrobat Reader to read this file.  If you do not have Adobe Acrobat Reader you can download it free from <a href='http://www.adobe.com/products/acrobat/readstep2.html'> Adobe.com"
        'If IsDBNull(custemail) Or custemail = "" Or Not custemail.Contains("@") Then
        If Not (custemail.Contains("@") And custemail.Contains(".")) Then
            MsgBox("ERROR: " & Chr(34) & custemail & Chr(34) & " is not a valid email address. Cannot email worksheet. ", MsgBoxStyle.Critical, "Invalid email address")
            Exit Sub
        Else
            emailaddr = custemail.ToString
        End If

        cSelectCriteria = "{ws_ord_head.worksheet-id} = " & Chr(39) & worksheetid & Chr(39)

        report1.Load(System.AppDomain.CurrentDomain.BaseDirectory & "\WkstAndMemoReport.rpt")
        report1.DataSourceConnections.Item(0).SetConnection("", "" & dbName & "", False)
        report1.DataSourceConnections.Item(0).SetLogon("Admin", "")

        For Each tbl In report1.Database.Tables
            crtablelogoninfo = tbl.LogOnInfo
            tbl.LogOnInfo.ConnectionInfo.ServerName = dbName
            tbl.LogOnInfo.ConnectionInfo.DatabaseName = dbName
            tbl.ApplyLogOnInfo(crtablelogoninfo)
            tbl.Location = dbName
        Next

        If CheckForWSMemos(worksheetid) = True Then
            result = MsgBox("There are memos on this worksheet.  Do you want to include them on this print job?", vbYesNo, "Print Memos")
            If result = MsgBoxResult.No Then
                report1.SetParameterValue("ShowMemo", False)
            Else
                report1.Subreports(0).DataSourceConnections.Item(0).SetConnection("", "" & dbName & "", False)
                report1.Subreports(0).DataSourceConnections.Item(0).SetLogon("Admin", "")
                For Each tbl In report1.Subreports(0).Database.Tables
                    crtablelogoninfo = tbl.LogOnInfo
                    tbl.LogOnInfo.ConnectionInfo.ServerName = dbName
                    tbl.LogOnInfo.ConnectionInfo.DatabaseName = dbName
                    tbl.ApplyLogOnInfo(crtablelogoninfo)
                    tbl.Location = dbName
                Next
                report1.SetParameterValue("ShowMemo", True)
            End If
        Else
            report1.SetParameterValue("ShowMemo", False)
        End If

        report1.RecordSelectionFormula = cSelectCriteria
        report1.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, GetProgramDefaults("TempFilePath") & "St. Croix Worksheet.pdf")

        'EmailWithDisplay(emailaddr, "St. Croix Worksheet", EmailBodyText, GetProgramDefaults("TempFilePath") & "St. Croix Worksheet.pdf")
        Email(emailaddr, "St. Croix Worksheet", EmailBodyText, GetProgramDefaults("TempFilePath") & "St. Croix Worksheet.pdf", True)

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    ''' <summary>
    ''' This procedure checks to see if a worksheet has memos on it
    ''' </summary>
    ''' <param name="worksheetid">The worksheet number to check</param>
    ''' <returns>A boolean indicating that a worksheet has memos (true) or doesn't have memos (false) </returns>
    ''' <remarks></remarks>

    Private Function CheckForWSMemos(ByRef worksheetid As String) As Boolean
        Dim SQLResult As Boolean
        Dim dbConnection As OleDb.OleDbConnection = New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim SQL As New OleDb.OleDbCommand

        dbConnection.Open()
        SQL.Connection = dbConnection
        SQL.CommandText = "SELECT COUNT (*) AS [RecordCount] FROM wsmemo WHERE [worksheet-id] = '" & worksheetid & "'"
        SQLResult = Convert.ToBoolean(SQL.ExecuteScalar)
        If SQLResult = True Then
            CheckForWSMemos = True
        Else
            CheckForWSMemos = False
        End If
        dbConnection.Close()
    End Function

    ''' <summary>
    ''' This procedure replicates the Nz function found in VB6. It prevents a null value from being used
    ''' </summary>
    ''' <param name="Value">The value of the object</param>
    ''' <returns>An empty string ("") or the value of the object</returns>
    ''' <remarks></remarks>

    Public Function Nz(ByVal Value As Object) As Object
        If Value Is Nothing OrElse IsDBNull(Value) Then
            Return String.Empty
        Else
            Return Value
        End If
    End Function

    ''' <summary>
    ''' This procedure gets a field from the 'defaults' table in the database
    ''' </summary>
    ''' <param name="VariableToSet">The name of the field in the 'defaults' table </param>
    ''' <returns>The value from the field</returns>
    ''' <remarks></remarks>

    Public Function GetProgramDefaults(ByRef VariableToSet As String) As String
        Dim cn1 As New OleDb.OleDbConnection
        Dim da1 As OleDb.OleDbDataAdapter
        Dim dt1 As New DataTable
        Dim tmpString As String

        cn1.ConnectionString = MySettings.Default("SaleForcConnectionString")
        cn1.Open()
        da1 = New OleDb.OleDbDataAdapter("SELECT " & VariableToSet & " FROM Defaults", cn1)
        da1.Fill(dt1)
        tmpString = dt1(0)(VariableToSet).ToString
        If InStr(tmpString, "%") Then
            tmpString = GetEnvironmentVar(tmpString)
        End If
        cn1.Close()
        GetProgramDefaults = tmpString
    End Function

    ''' <summary>
    ''' This procedure gets the value of a Windows environment variable
    ''' </summary>
    ''' <param name="TheString">The name of the environment variable</param>
    ''' <returns>The value of the environment variable</returns>
    ''' <remarks></remarks>

    Private Function GetEnvironmentVar(ByVal TheString As String)
        Dim firstPos As Integer
        Dim lastPos As Integer

        firstPos = InStr(TheString, "%")
        lastPos = InStrRev(TheString, "%")
        GetEnvironmentVar = Replace(TheString, Mid(TheString, firstPos, lastPos - firstPos + 1), Environment.GetEnvironmentVariable(Mid(TheString, firstPos + 1, lastPos - firstPos - 1)))
    End Function
End Module