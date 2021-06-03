Option Strict Off
Option Explicit On
Friend Class frmWsToXmitList
	Inherits System.Windows.Forms.Form
	
	Dim lLoaded As Boolean
	Dim cCommDir As String
	Dim cCommPrgm As String
	Dim cDir As String
    Dim fil() As String

    Dim nExpBuf, nTmpBuf As Short
    Dim cNewCust, cWsNo, cNewShip As String
    Dim nLineCtr As Short
    Dim FilesToSend() As String
    Private dataadapter As New OleDb.OleDbDataAdapter
    Dim commandbuilder As OleDb.OleDbCommandBuilder = New OleDb.OleDbCommandBuilder(dataadapter)

    ''' <summary>
    ''' This procedure makes calls to create a file that contains worksheet data to send to the Titan system 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

	Private Sub cmdCreateXmitFile_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCreateXmitFile.Click
		flagImport = False
		ExportWorksheets()
        getXmitListPC()
        GetData(Ws_ord_headTableAdapter.Adapter.SelectCommand.CommandText)
    End Sub


    ''' <summary>
    ''' This procedure closes the form
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
	
	Private Sub cmdExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExit.Click
		Me.Close()
    End Sub

    ''' <summary>
    ''' This procedure will populate a list box with the names of files that are to be transitted to the Titan server at Knitcraft
    ''' </summary>
    ''' <remarks></remarks>
	
	Private Sub getXmitListPC()
        Dim i As Integer


        cDir = GetProgramDefaults("FileUploadPath")
        lstFilesToTransfer.Items.Clear()
        fil = System.IO.Directory.GetFiles(cDir, "*" & GetProgramDefaults("FileUploadExtension"))

        If fil.Length = 0 Then
            lstFilesToTransfer.Items.Add("No files found")
        Else
            For i = 0 To fil.Length - 1
                lstFilesToTransfer.Items.Add(System.IO.Path.GetFileName(fil(i)) & "  " & FileDateTime(fil(i)))
                FindWorksheets(i)
            Next
        End If
    End Sub

    ''' <summary>
    ''' This procedure checks the first line of a worksheet file to make sure it is a valid worksheet
    ''' </summary>
    ''' <param name="i"></param>
    ''' <remarks></remarks>

    Private Sub FindWorksheets(ByVal i As Integer)
        Dim ioFile As New System.IO.StreamReader(fil(i))
        Dim ioLine As String
        ioLine = ioFile.ReadLine
        If ioLine <> "[FileHeader]" Then
            lstFilesToTransfer.Items.Add("Not a valid file")
        End If
        ioFile.Close()
    End Sub

    ''' <summary>
    ''' This procedure transfers the export files to the Knitcraft server identified by the field 'FTPHostName' in the 'Defaults' table
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmdTransfer_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdTransfer.Click
        Dim tmpUser As String
        Dim tmpPwd As String
        Dim tmpHost As String
        Dim ftp As New FtpSession
        Dim remoteUpload As String
        Dim i As Integer
        Dim localUpload As String

        Try
            cmdTransfer.Enabled = False
            localUpload = GetProgramDefaults("FTPLocalUpload")
            tmpHost = GetProgramDefaults("FTPHostName")
            tmpUser = GetProgramDefaults("FTPSalesRepLogin")
            tmpPwd = String.Concat(tmpUser, GetProgramDefaults("FTPSalesRepNumber"))
            'MsgBox("CMA : tmpPwd=""" & tmpPwd & """")

            remoteUpload = GetProgramDefaults("FTPRemoteUpload")
            ftp.ftpUser = tmpUser
            ftp.ftpPwd = tmpPwd

            getfilestoupload()

            For i = 0 To UBound(FilesToSend)
                My.Computer.Network.UploadFile(FilesToSend(i), "ftp://" & tmpHost & Mid(remoteUpload, 1, 1) & "%2f" & Mid(remoteUpload, 2) & "/" & System.IO.Path.GetFileName(FilesToSend(i)), tmpUser, tmpPwd)
                lstFilesToTransfer.Items.RemoveAt(i)
                My.Computer.FileSystem.DeleteFile(FilesToSend(i))
            Next
            'lstFilesToTransfer.Items.Clear()
            cmdTransfer.Enabled = True
            MsgBox("Transfer completed!", MsgBoxStyle.OkOnly, "Transfer Files")
        Catch exc As Exception
            MsgBox("Transfer Failed!" & vbCrLf & vbCrLf & "Wait 5 minutes and try again." & vbCrLf & vbCrLf & "If this message continues please contact support", MsgBoxStyle.OkOnly, "Transfer Files Failed")
            Me.Close()
        End Try
        cmdTransfer.Enabled = True
    End Sub

    ''' <summary>
    ''' This procedure creates an array of files that are ready to be exported to Knitcraft
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub getfilestoupload()
        FilesToSend = System.IO.Directory.GetFiles(cExportPath, "*", IO.SearchOption.TopDirectoryOnly)
    End Sub

    ''' <summary>
    ''' This procedure fires at form startup and will make calls to get a list of files to be exported to Knitcraft
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub frmWsToXmitList_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        If lLoaded = False Then
            getXmitListPC()
            lLoaded = True
        End If
        If cmdCreateXmitFile.Enabled Then
            cmdCreateXmitFile.Focus()
        End If
    End Sub

    ''' <summary>
    ''' This procedure fires at form startup andd will load data into the datagrid with worksheets that are ready to transmit
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub frmWsToXmitList_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Me.Ws_ord_headTableAdapter.FillByReadyToXmit(Me.SaleForcDataSet._ws_ord_head)
        Me.WsordheadBindingSource.Sort = "[worksheet-id] DESC"
        Me.DataGridView1.DataSource = WsordheadBindingSource
        lLoaded = False
    End Sub

    ''' <summary>
    ''' This procedure will put worksheet data into a text file for transmitting to the Titan server where it will attempt to be converted 
    ''' into orders. 
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub ExportWorksheets()
        Dim ex As Boolean
        Dim cWarn As Short
        Dim cMsg As String

        cMsg = "Are you sure you are ready to create a worksheet transmit file?"
        cWarn = MsgBox(cMsg, MsgBoxStyle.OkCancel + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "CREATE TRANSMIT FILE")
        If cWarn = MsgBoxResult.Cancel Then
            cmdExit.Focus()
            Exit Sub
        End If
        If chkForUpLoadDir() = False Then
            MsgBox("Couldn't find nor make directory")
        Else
            cmdExit.Enabled = False

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            ex = ExportData()
            If ex = False Then
                MsgBox("No worksheets are ready to send", , "NOTICE")

            Else
                MsgBox("Worksheet file was created and is ready to send", , "NOTICE")

            End If
            cmdExit.Enabled = True


            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End If

    End Sub

    ''' <summary>
    ''' This procedure checks to make sure the upload directory (where the export files are stored) exists
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Private Function chkForUpLoadDir() As Boolean
        chkForUpLoadDir = False
        If My.Computer.FileSystem.DirectoryExists(GetProgramDefaults("FileUploadPath")) Then
            chkForUpLoadDir = True
        Else
            My.Computer.FileSystem.CreateDirectory(GetProgramDefaults("FileUploadPath"))
            chkForUpLoadDir = True
        End If
    End Function

    ''' <summary>
    ''' This procedure makes calls to create files that put worksheet data into export files
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Private Function ExportData() As Boolean
        Dim cExportDir As String

        ExportData = False
        cExportFile = GetExportFileName() 'create the export file name
        cExportDir = GetProgramDefaults("FileUploadPath")
        ' create the list of worksheets to transmit
        If GetXmitList() = False Then
            Exit Function
            logFileAdd(1, "No worksheets ready")
        Else
            ExportData = True

            nExpBuf = FreeFile()
            FileOpen(nExpBuf, cExportDir & cExportFile, OpenMode.Output) ' Export file
            ExportFileHeader() ' print the file header
            ExportWsHead() ' print the worksheets ready for transmitting
            ExportWsLines() ' print the item lines for the transmitting worksheets
            ExportWsMemos() ' print the memo lines for the transmitting worksheets

            FileClose(nTmpBuf, nExpBuf)
            logFileAdd(1, "Export file: " & cExportFile & " was created")
        End If

    End Function

    ''' <summary>
    ''' This procedure writes the file header information to the text file 
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub ExportFileHeader()
        ' print the header lines for the export file
        PrintLine(nExpBuf, "[FileHeader]")
        PrintLine(nExpBuf, "FileName=" & cExportFile)
        PrintLine(nExpBuf, "SalesPersonNumber=" & cSalesmanCd)
        PrintLine(nExpBuf, "SalesPersonName=" & cSalesmanName)
        PrintLine(nExpBuf, "Date/Time=" & Today & "  " & TimeOfDay)
        PrintLine(nExpBuf, "") 'Blank line to separate sections
    End Sub

    ''' <summary>
    ''' This procedure puts the worksheet header (ws-ord-head table) information into the export file
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub ExportWsHead()
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim daWsOrdHead As New SaleForcDataSetTableAdapters.ws_ord_headTableAdapter
        Dim dtWsOrdHead As SaleForcDataSet._ws_ord_headDataTable
        Dim drWsOrdHead As SaleForcDataSet._ws_ord_headRow

        con.Open()
        dtWsOrdHead = daWsOrdHead.GetData

        PrintLine(nExpBuf, "[WSHead]")

        nTmpBuf = FreeFile()
        FileOpen(nTmpBuf, cTempFileName, OpenMode.Input) 'Read stored worksheet ID's
        Do While Not EOF(nTmpBuf)
            cWsNo = LineInput(nTmpBuf)
            Input(nTmpBuf, cNewCust)
            Input(nTmpBuf, cNewShip)

            drWsOrdHead = dtWsOrdHead.FindBy_worksheet_id(cWsNo)

            PrintLine(nExpBuf, drWsOrdHead._worksheet_id)

            If IsDBNull(drWsOrdHead._allow_manual_maint) Then
                PrintLine(nExpBuf, "No")
            Else
                If drWsOrdHead._allow_manual_maint = True Then
                    PrintLine(nExpBuf, "Yes")
                Else
                    PrintLine(nExpBuf, "No")
                End If
            End If

            If IsDBNull(drWsOrdHead("ws-create-date")) Then
                PrintLine(nExpBuf, "")
            Else
                PrintLine(nExpBuf, drWsOrdHead("ws-create-date"))
            End If

            If IsDBNull(drWsOrdHead("last-update-date")) Then
                PrintLine(nExpBuf, "")
            Else
                PrintLine(nExpBuf, drWsOrdHead("last-update-date"))
            End If

            If IsDBNull(drWsOrdHead("cust-no")) Or Strings.Left(drWsOrdHead("cust-no"), 2) = "ZZ" Then
                PrintLine(nExpBuf, "")
            Else
                PrintLine(nExpBuf, drWsOrdHead("cust-no"))
            End If

            If IsDBNull(drWsOrdHead("ship-no")) Or Strings.Left(drWsOrdHead("ship-no"), 2) = "ZZ" Then
                PrintLine(nExpBuf, "")
            Else
                PrintLine(nExpBuf, drWsOrdHead("ship-no"))
            End If

            If IsDBNull(drWsOrdHead("name")) Then
                PrintLine(nExpBuf, "")
            Else
                PrintLine(nExpBuf, drWsOrdHead("name"))
            End If

            If IsDBNull(drWsOrdHead("request-date")) Then
                PrintLine(nExpBuf, "")
            Else
                PrintLine(nExpBuf, drWsOrdHead("request-date"))
            End If

            If IsDBNull(drWsOrdHead("complete-date")) Then
                PrintLine(nExpBuf, "")
            Else
                PrintLine(nExpBuf, drWsOrdHead("complete-date"))
            End If

            If IsDBNull(drWsOrdHead("cancel-date")) Then
                PrintLine(nExpBuf, "")
            Else
                PrintLine(nExpBuf, drWsOrdHead("cancel-date"))
            End If

            If IsDBNull(drWsOrdHead("season")) Then
                PrintLine(nExpBuf, "")
            Else
                PrintLine(nExpBuf, drWsOrdHead("season"))
            End If

            If IsDBNull(drWsOrdHead("order-code")) Then
                PrintLine(nExpBuf, "")
            Else
                PrintLine(nExpBuf, drWsOrdHead("order-code"))
            End If

            If IsDBNull(drWsOrdHead("cust-po")) Then
                PrintLine(nExpBuf, "")
            Else
                PrintLine(nExpBuf, drWsOrdHead("cust-po"))
            End If

            If IsDBNull(drWsOrdHead("department")) Then
                PrintLine(nExpBuf, "")
            Else
                PrintLine(nExpBuf, drWsOrdHead("department"))
            End If

            If IsDBNull(drWsOrdHead("via-code")) Then

            Else
                PrintLine(nExpBuf, drWsOrdHead("via-code"))
            End If

            If IsDBNull(drWsOrdHead("ord-compl")) Then
                PrintLine(nExpBuf, "No")
            Else
                If drWsOrdHead("ord-compl") = True Then
                    PrintLine(nExpBuf, "Yes")
                Else
                    PrintLine(nExpBuf, "No")
                End If
            End If

            If IsDBNull(drWsOrdHead("order-no")) Then
                PrintLine(nExpBuf, 0)
            Else
                PrintLine(nExpBuf, drWsOrdHead("order-no"))
            End If

            If IsDBNull(drWsOrdHead("order-date")) Then
                PrintLine(nExpBuf, "")
            Else
                PrintLine(nExpBuf, drWsOrdHead("order-date"))
            End If

            If IsDBNull(drWsOrdHead("transmittal-status")) Then
                PrintLine(nExpBuf, "")
            Else
                PrintLine(nExpBuf, drWsOrdHead("transmittal-status"))
            End If

            If IsDBNull(drWsOrdHead("transmittal-date")) Then
                PrintLine(nExpBuf, "")
            Else
                PrintLine(nExpBuf, drWsOrdHead("transmittal-date"))
            End If

            If IsDBNull(drWsOrdHead("validation-status")) Then
                PrintLine(nExpBuf, "")
            Else
                PrintLine(nExpBuf, drWsOrdHead("validation-status"))
            End If

            If IsDBNull(drWsOrdHead("validation-date")) Then
                PrintLine(nExpBuf, "")
            Else
                PrintLine(nExpBuf, drWsOrdHead("validation-date"))
            End If

            If IsDBNull(drWsOrdHead("error-level")) Then
                PrintLine(nExpBuf, "")
            Else
                PrintLine(nExpBuf, drWsOrdHead("error-level"))
            End If

            If IsDBNull(drWsOrdHead("LastUpdated")) Then
                PrintLine(nExpBuf, "")
            Else
                PrintLine(nExpBuf, drWsOrdHead("LastUpdated"))
            End If

            If IsDBNull(drWsOrdHead("ReadyToXmit")) Then
                PrintLine(nExpBuf, "No")
            Else
                If drWsOrdHead("ReadyToXmit") = True Then
                    PrintLine(nExpBuf, "Yes")
                Else
                    PrintLine(nExpBuf, "No")
                End If
            End If


            If IsDBNull(drWsOrdHead("CancelWS")) Then
                PrintLine(nExpBuf, "No")
            Else
                If drWsOrdHead("CancelWS") = True Then
                    PrintLine(nExpBuf, "Yes")
                Else
                    PrintLine(nExpBuf, "No")
                End If
            End If

            If IsDBNull(drWsOrdHead("SlsmnCode")) Then
                PrintLine(nExpBuf, "")
            Else
                PrintLine(nExpBuf, drWsOrdHead("SlsmnCode"))
            End If

            drWsOrdHead.BeginEdit()
            drWsOrdHead("allow-manual-maint") = False
            drWsOrdHead("Xmitted") = True
            drWsOrdHead("XmittedDate") = Today
            drWsOrdHead("XmittedTime") = TimeOfDay
            drWsOrdHead("transmittal-status") = "SENT"
            drWsOrdHead("transmittal-date") = Today
            drWsOrdHead.EndEdit()
            daWsOrdHead.Update(dtWsOrdHead)
        Loop
        PrintLine(nExpBuf, "")
        FileClose(nTmpBuf)
        con.Close()
    End Sub

    ''' <summary>
    ''' This procedure puts the worksheet line (ws-ord-line table) information into the export file
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub ExportWsLines()
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim daWsOrdLine As New SaleForcDataSetTableAdapters.ws_ord_lineTableAdapter
        Dim dtWsOrdLine As SaleForcDataSet._ws_ord_lineDataTable
        Dim drWsOrdLine() As SaleForcDataSet._ws_ord_lineRow
        Dim i As Integer

        con.Open()
        dtWsOrdLine = daWsOrdLine.GetData
       
        PrintLine(nExpBuf, "[WSLine]")
        nTmpBuf = FreeFile()
        FileOpen(nTmpBuf, cTempFileName, OpenMode.Input) 'Read stored worksheet ID's

        Do While Not EOF(nTmpBuf)
            cWsNo = LineInput(nTmpBuf)
            drWsOrdLine = dtWsOrdLine.Select("[worksheet-id] = '" & cWsNo & "'")

            Input(nTmpBuf, cNewCust)
            Input(nTmpBuf, cNewShip)

            For i = 0 To drWsOrdLine.Length - 1

                PrintLine(nExpBuf, drWsOrdLine(i)("worksheet-id"))
                PrintLine(nExpBuf, drWsOrdLine(i)("item-no"))

                If IsDBNull(drWsOrdLine(i)("orderlineno")) Then
                    PrintLine(nExpBuf, 0)
                Else
                    PrintLine(nExpBuf, drWsOrdLine(i)("orderlineno"))
                End If

                If IsDBNull(drWsOrdLine(i)("qty-orig-ord")) Then
                    PrintLine(nExpBuf, 0)
                Else
                    PrintLine(nExpBuf, drWsOrdLine(i)("qty-orig-ord"))
                End If

                If IsDBNull(drWsOrdLine(i)("price")) Then
                    PrintLine(nExpBuf, 0)
                Else
                    PrintLine(nExpBuf, drWsOrdLine(i)("price"))
                End If

                If IsDBNull(drWsOrdLine(i)("ReadyForOrder")) Then
                    PrintLine(nExpBuf, "No")
                Else
                    If drWsOrdLine(i)("ReadyForOrder") = False Then
                        PrintLine(nExpBuf, "No")
                    Else
                        PrintLine(nExpBuf, "Yes")
                    End If
                End If

                If IsDBNull(drWsOrdLine(i)("LastUpdated")) Then
                    PrintLine(nExpBuf, "")
                Else
                    PrintLine(nExpBuf, drWsOrdLine(i)("LastUpdated"))
                End If

                drWsOrdLine(i).BeginEdit()
                drWsOrdLine(i)("xmitted") = True
                drWsOrdLine(i)("xmitteddate") = Today
                drWsOrdLine(i)("xmittedtime") = TimeOfDay
                drWsOrdLine(i).EndEdit()
                daWsOrdLine.Update(dtWsOrdLine)
            Next
        Loop

        PrintLine(nExpBuf, "")
        FileClose(nTmpBuf)
        con.Close()
    End Sub

    ''' <summary>
    ''' This procedure puts the worksheet memos (wsmemo table) information into the export file.
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub ExportWsMemos()
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim daWsMemo As New SaleForcDataSetTableAdapters.WSMemoTableAdapter
        Dim dtWsMemo As SaleForcDataSet.WSMemoDataTable
        Dim drWsMemo() As SaleForcDataSet.WSMemoRow
        Dim i As Integer

        con.Open()
        dtWsMemo = daWsMemo.GetData


        'If drWsMemo.Length = 0 Then
        '    Exit Sub
        'End If

        PrintLine(nExpBuf, "[WSMemo]")
        nTmpBuf = FreeFile()
        FileOpen(nTmpBuf, cTempFileName, OpenMode.Input) 'Read stored worksheet ID's

        Do While Not EOF(nTmpBuf)
            cWsNo = LineInput(nTmpBuf)
            drWsMemo = dtWsMemo.Select("[worksheet-id] = '" & cWsNo & "'")

            Input(nTmpBuf, cNewCust)
            Input(nTmpBuf, cNewShip)
            nLineCtr = 0

            For i = 0 To drWsMemo.Length - 1

                PrintLine(nExpBuf, drWsMemo(i)("worksheet-id"))

                If IsDBNull(drWsMemo(i)("LineNumber")) Then
                    PrintLine(nExpBuf, 0)
                Else
                    PrintLine(nExpBuf, drWsMemo(i)("LineNumber"))
                End If

                If IsDBNull(drWsMemo(i)("Comment")) Then
                    PrintLine(nExpBuf, "")
                Else
                    PrintLine(nExpBuf, drWsMemo(i)("Comment"))
                End If

                'drWsMemo(i).BeginEdit()
                nLineCtr = drWsMemo(i)("LineNumber")
                Dim com As OleDb.OleDbCommand
                com = New OleDb.OleDbCommand("UPDATE WsMemo SET Xmitted = True, XmittedDate = #" & Today & "#, XmittedTime = #" & TimeOfDay & "#", con)
                com.ExecuteNonQuery()
                com.Dispose()
                'drWsMemo(i)("Xmitted") = True
                'drWsMemo(i)("XmittedDate") = Today
                'drWsMemo(i)("XmittedTime") = TimeOfDay
                'drWsMemo(i).EndEdit()
                'daWsMemo.Update(dtWsMemo)
            Next
            If Trim(cNewCust) <> "" Then
                prtNewCust(cNewCust, nLineCtr, cWsNo)
                prtNewShip(cNewCust, cNewShip, nLineCtr, cWsNo)
            End If
        Loop
        PrintLine(nExpBuf, "")
        FileClose(nTmpBuf)
        con.Close()
    End Sub

    ''' <summary>
    ''' This procedure creates a file name for the export file by getting the next available number in the 'Salesman' table
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Private Function GetExportFileName() As String
        Dim con As New OleDb.OleDbConnection
        Dim daSalesman As New SaleForcDataSetTableAdapters.SalesmanTableAdapter
        Dim dtSalesman As SaleForcDataSet.SalesmanDataTable
        Dim drSalesman As SaleForcDataSet.SalesmanRow
        Dim nExportNum As Integer
        dtSalesman = daSalesman.GetData
        drSalesman = dtSalesman.Rows(0)

        GetExportFileName = ""

        nExportNum = drSalesman.ExportNo
        cSalesmanCd = drSalesman.SlsmnCode
        cSalesmanName = drSalesman.name

        GetExportFileName = Strings.Mid(CStr(drSalesman.ExportNo), 2) & Trim(drSalesman.SlsmnCode) & cExportFileExtension
        nExportNum = nExportNum + 1
        drSalesman.BeginEdit()
        drSalesman.ExportNo = nExportNum
        drSalesman.EndEdit()
        daSalesman.Update(dtSalesman)
        con.Close()
    End Function

    ''' <summary>
    ''' This procedure makes a call to write to the application log file with what files it is exporting
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Private Function GetXmitList() As Boolean
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim daWsOrdHead As New SaleForcDataSetTableAdapters.ws_ord_headTableAdapter
        Dim dtWsOrdHead As SaleForcDataSet._ws_ord_headDataTable
        Dim drWsOrdHead() As SaleForcDataSet._ws_ord_headRow
        Dim i As Integer

        con.Open()
        dtWsOrdHead = daWsOrdHead.GetData
        drwsordhead = dtWsOrdHead.Select("[readytoxmit] = True AND [xmitted] = False")
        con.Close()

        GetXmitList = False ' If no files are ready
        nTmpBuf = FreeFile()
        FileOpen(nTmpBuf, cTempFileName, OpenMode.Output) 'Store transmitted worksheet ID's

        If drWsOrdHead.Length = 0 Then
            FileClose(nTmpBuf)

            Exit Function
        End If

        For i = 0 To drWsOrdHead.Length - 1

            PrintLine(nTmpBuf, Trim(drWsOrdHead(i)("worksheet-id")))
            If drWsOrdHead(i)("IsNewCustomer") = True Then
                PrintLine(nTmpBuf, Trim(drWsOrdHead(i)("cust-no")))
                PrintLine(nTmpBuf, Trim(drWsOrdHead(i)("ship-no")))
            Else
                PrintLine(nTmpBuf, "")
                PrintLine(nTmpBuf, "")
            End If
            logFileAdd(1, "WorksheetID: " & Trim(drWsOrdHead(i)("worksheet-id")))
            GetXmitList = True
        Next
        FileClose(nTmpBuf)

    End Function

    ''' <summary>
    ''' This procedure will write out a new customer's information to the export file
    ''' </summary>
    ''' <param name="cCustNum"></param>
    ''' <param name="nLine"></param>
    ''' <param name="cWsNum"></param>
    ''' <remarks></remarks>

    Private Sub prtNewCust(ByRef cCustNum As String, ByRef nLine As Short, ByRef cWsNum As String)
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim daCustomer As New SaleForcDataSetTableAdapters.CustomerTableAdapter
        Dim dtCustomer As SaleForcDataSet.CustomerDataTable
        Dim drCustomer() As SaleForcDataSet.CustomerRow

        If cCustNum = "" Then Exit Sub

        con.Open()
        dtCustomer = daCustomer.GetData
        drCustomer = dtCustomer.Select("[cust-no] = '" & cCustNum & "'")

        If drCustomer.Length = 0 Then Exit Sub
        nLine = nLine + 1
        PrintLine(nExpBuf, cWsNum)
        PrintLine(nExpBuf, nLine)
        PrintLine(nExpBuf, "[NEWCUST]")
        nLine = nLine + 1


        If IsDBNull(drCustomer(0)("cust-no")) Then drCustomer(0)("Cust-no") = ""
        PrintLine(nExpBuf, cWsNum)
        PrintLine(nExpBuf, nLine)
        PrintLine(nExpBuf, Trim(drCustomer(0)("Cust-no")))
        nLine = nLine + 1


        If IsDBNull(drCustomer(0)("Name")) Then drCustomer(0)("Name") = ""
        PrintLine(nExpBuf, cWsNum)
        PrintLine(nExpBuf, nLine)
        PrintLine(nExpBuf, Trim(drCustomer(0)("Name")))
        nLine = nLine + 1


        If IsDBNull(drCustomer(0)("Address1")) Then drCustomer(0)("Address1") = ""
        PrintLine(nExpBuf, cWsNum)
        PrintLine(nExpBuf, nLine)
        PrintLine(nExpBuf, Trim(drCustomer(0)("Address1")))
        nLine = nLine + 1


        If IsDBNull(drCustomer(0)("Address2")) Then drCustomer(0)("Address2") = ""
        PrintLine(nExpBuf, cWsNum)
        PrintLine(nExpBuf, nLine)
        PrintLine(nExpBuf, Trim(drCustomer(0)("Address2")))
        nLine = nLine + 1


        If IsDBNull(drCustomer(0)("Address3")) Then drCustomer(0)("Address3") = ""
        PrintLine(nExpBuf, cWsNum)
        PrintLine(nExpBuf, nLine)
        PrintLine(nExpBuf, Trim(drCustomer(0)("Address3")))
        nLine = nLine + 1


        If IsDBNull(drCustomer(0)("City")) Then drCustomer(0)("City") = ""
        PrintLine(nExpBuf, cWsNum)
        PrintLine(nExpBuf, nLine)
        PrintLine(nExpBuf, Trim(drCustomer(0)("City")))
        nLine = nLine + 1


        If IsDBNull(drCustomer(0)("St")) Then drCustomer(0)("St") = ""
        PrintLine(nExpBuf, cWsNum)
        PrintLine(nExpBuf, nLine)
        PrintLine(nExpBuf, Trim(drCustomer(0)("St")))
        nLine = nLine + 1


        If IsDBNull(drCustomer(0)("Zip-code")) Then drCustomer(0)("Zip-code") = ""
        PrintLine(nExpBuf, cWsNum)
        PrintLine(nExpBuf, nLine)
        PrintLine(nExpBuf, Trim(drCustomer(0)("Zip-code")))
        nLine = nLine + 1


        If IsDBNull(drCustomer(0)("Country")) Then drCustomer(0)("Country") = ""
        PrintLine(nExpBuf, cWsNum)
        PrintLine(nExpBuf, nLine)
        PrintLine(nExpBuf, Trim(drCustomer(0)("Country")))
        nLine = nLine + 1


        If IsDBNull(drCustomer(0)("Telephone")) Then drCustomer(0)("Telephone") = ""
        PrintLine(nExpBuf, cWsNum)
        PrintLine(nExpBuf, nLine)
        PrintLine(nExpBuf, Trim(drCustomer(0)("Telephone")))
        nLine = nLine + 1


        If IsDBNull(drCustomer(0)("Fax-num")) Then drCustomer(0)("Fax-num") = ""
        PrintLine(nExpBuf, cWsNum)
        PrintLine(nExpBuf, nLine)
        PrintLine(nExpBuf, Trim(drCustomer(0)("Fax-num")))
        nLine = nLine + 1


        If IsDBNull(drCustomer(0)("Contact")) Then drCustomer(0)("Contact") = ""
        PrintLine(nExpBuf, cWsNum)
        PrintLine(nExpBuf, nLine)
        PrintLine(nExpBuf, Trim(drCustomer(0)("Contact")))
        nLine = nLine + 1


        If IsDBNull(drCustomer(0)("via-code")) Then drCustomer(0)("via-code") = ""
        PrintLine(nExpBuf, cWsNum)
        PrintLine(nExpBuf, nLine)
        PrintLine(nExpBuf, Trim(drCustomer(0)("via-code")))
        nLine = nLine + 1


        If IsDBNull(drCustomer(0)("email")) Then drCustomer(0)("email") = ""
        PrintLine(nExpBuf, cWsNum)
        PrintLine(nExpBuf, nLine)
        PrintLine(nExpBuf, "Email:" & Trim(drCustomer(0)("email")))
        nLine = nLine + 1


        If IsDBNull(drCustomer(0)("contact-email")) Then drCustomer(0)("contact-email") = ""
        PrintLine(nExpBuf, cWsNum)
        PrintLine(nExpBuf, nLine)
        PrintLine(nExpBuf, "Contact Email:" & Trim(drCustomer(0)("contact-email")))

        drCustomer(0).BeginEdit()
        drCustomer(0)._Status_code = "X"
        drCustomer(0).EndEdit()
        daCustomer.Update(dtCustomer)
        con.Close()
    End Sub

    ''' <summary>
    ''' This procedure will write out a new customer's ship to information to the export file
    ''' </summary>
    ''' <param name="cCustNum"></param>
    ''' <param name="cShipNum"></param>
    ''' <param name="nLine"></param>
    ''' <param name="cWsNum"></param>
    ''' <remarks></remarks>

    Private Sub prtNewShip(ByRef cCustNum As String, ByRef cShipNum As String, ByRef nLine As Short, ByRef cWsNum As String)
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim daCustShip As New SaleForcDataSetTableAdapters.CustomerSHTableAdapter
        Dim dtCustShip As SaleForcDataSet.CustomerSHDataTable
        Dim drcustship As SaleForcDataSet.CustomerSHRow

        If cCustNum = "" Or cShipNum = "" Then Exit Sub

        dtCustShip = daCustShip.GetData
        drcustship = dtCustShip.FindBy_Cust_no_Cust_sh(cCustNum, cShipNum)

        If drcustship Is Nothing Then Exit Sub

        nLine = nLine + 1
        PrintLine(nExpBuf, cWsNum)
        PrintLine(nExpBuf, nLine)
        PrintLine(nExpBuf, "[NEWCUSTSHIP]")
        nLine = nLine + 1

        drcustship.BeginEdit()

        If IsDBNull(drcustship._Cust_no) Then drcustship._Cust_no = ""
        PrintLine(nExpBuf, cWsNum)
        PrintLine(nExpBuf, nLine)
        PrintLine(nExpBuf, Trim(drcustship._Cust_no))
        nLine = nLine + 1


        If IsDBNull(drcustship._Cust_sh) Then drcustship._Cust_sh = ""
        PrintLine(nExpBuf, cWsNum)
        PrintLine(nExpBuf, nLine)
        PrintLine(nExpBuf, Trim(drcustship._Cust_sh))
        nLine = nLine + 1


        If IsDBNull(drcustship.Name) Then drcustship.Name = ""
        PrintLine(nExpBuf, cWsNum)
        PrintLine(nExpBuf, nLine)
        PrintLine(nExpBuf, Trim(drcustship.Name))
        nLine = nLine + 1


        If IsDBNull(drcustship.Address1) Then drcustship.Address1 = """)"
        PrintLine(nExpBuf, cWsNum)
        PrintLine(nExpBuf, nLine)
        PrintLine(nExpBuf, Trim(drcustship.Address1))
        nLine = nLine + 1


        If IsDBNull(drcustship.Address2) Then drcustship.Address2 = ""
        PrintLine(nExpBuf, cWsNum)
        PrintLine(nExpBuf, nLine)
        PrintLine(nExpBuf, Trim(drcustship.Address2))
        nLine = nLine + 1


        If IsDBNull(drcustship.Address3) Then drcustship.Address3 = ""
        PrintLine(nExpBuf, cWsNum)
        PrintLine(nExpBuf, nLine)
        PrintLine(nExpBuf, Trim(drcustship.Address3))
        nLine = nLine + 1


        If IsDBNull(drcustship.City) Then drcustship.City = ""
        PrintLine(nExpBuf, cWsNum)
        PrintLine(nExpBuf, nLine)
        PrintLine(nExpBuf, Trim(drcustship.City))
        nLine = nLine + 1


        If IsDBNull(drcustship.St) Then drcustship.St = ""
        PrintLine(nExpBuf, cWsNum)
        PrintLine(nExpBuf, nLine)
        PrintLine(nExpBuf, Trim(drcustship.St))
        nLine = nLine + 1


        If IsDBNull(drcustship._Zip_code) Then drcustship._Zip_code = ""
        PrintLine(nExpBuf, cWsNum)
        PrintLine(nExpBuf, nLine)
        PrintLine(nExpBuf, Trim(drcustship._Zip_code))
        nLine = nLine + 1


        If IsDBNull(drcustship.Country) Then drcustship.Country = ""
        PrintLine(nExpBuf, cWsNum)
        PrintLine(nExpBuf, nLine)
        PrintLine(nExpBuf, Trim(drcustship.Country))
        nLine = nLine + 1


        If IsDBNull(drcustship.Telephone) Then drcustship.Telephone = ""
        PrintLine(nExpBuf, cWsNum)
        PrintLine(nExpBuf, nLine)
        PrintLine(nExpBuf, Trim(drcustship.Telephone))
        nLine = nLine + 1


        If IsDBNull(drcustship._Fax_num) Then drcustship._Fax_num = ""
        PrintLine(nExpBuf, cWsNum)
        PrintLine(nExpBuf, nLine)
        PrintLine(nExpBuf, Trim(drcustship._Fax_num))
        nLine = nLine + 1


        If IsDBNull(drcustship.Contact) Then drcustship.Contact = ""
        PrintLine(nExpBuf, cWsNum)
        PrintLine(nExpBuf, nLine)
        PrintLine(nExpBuf, Trim(drcustship.Contact))
        nLine = nLine + 1


        If IsDBNull(drcustship._Via_code) Then drcustship._Via_code = ""
        PrintLine(nExpBuf, cWsNum)
        PrintLine(nExpBuf, nLine)
        PrintLine(nExpBuf, Trim(drcustship._Via_code))
        nLine = nLine + 1


        If IsDBNull(drcustship.email) Then drcustship.email = ""
        PrintLine(nExpBuf, cWsNum)
        PrintLine(nExpBuf, nLine)
        PrintLine(nExpBuf, "Email:" & Trim(drcustship.email))
        nLine = nLine + 1


        If IsDBNull(drcustship._Contact_email) Then drcustship._Contact_email = ""
        PrintLine(nExpBuf, cWsNum)
        PrintLine(nExpBuf, nLine)
        PrintLine(nExpBuf, "Contact Email:" & Trim(drcustship._Contact_email))
        nLine = nLine + 1


        If IsDBNull(drcustship.Website) Then drcustship.Website = ""
        PrintLine(nExpBuf, cWsNum)
        PrintLine(nExpBuf, nLine)
        PrintLine(nExpBuf, Trim(drcustship.Website))

        drcustship._Status_code = "X"
        drcustship.EndEdit()
        daCustShip.Update(dtCustShip)
        con.Close()

    End Sub

    ''' <summary>
    ''' This procedure refreshes data in the worksheets data grid
    ''' </summary>
    ''' <param name="selectCommand"></param>
    ''' <remarks></remarks>

    Private Sub GetData(ByVal selectCommand As String)

        ' Specify a connection string. Replace the given value with a 
        ' valid connection string for a Northwind SQL Server sample
        ' database accessible to your system.
        Dim connectionString As String = MySettings.Default("SaleForcConnectionString")

        ' Create a new data adapter based on the specified query.
        Me.dataadapter = New OleDb.OleDbDataAdapter(selectCommand, connectionString)

        ' Create a command builder to generate SQL update, insert, and
        ' delete commands based on selectCommand. These are used to
        ' update the database.
        Dim commandbuilder As New OleDb.OleDbCommandBuilder(Me.dataadapter)

        ' Populate a new data table and bind it to the BindingSource.
        Dim table As New DataTable()
        table.Locale = System.Globalization.CultureInfo.InvariantCulture
        Me.dataadapter.Fill(table)
        Me.WsordheadBindingSource.DataSource = table

        ' Resize the DataGridView columns to fit the newly loaded content.
        Me.DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

    End Sub
End Class