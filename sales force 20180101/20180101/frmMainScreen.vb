Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports Microsoft.VisualBasic.PowerPacks
Imports System.IO
Imports System.IO.Compression
Imports Calendar
Imports System.Collections.Generic
Imports System.Net.Mail
Imports System.Runtime.InteropServices
Imports Microsoft.Office.Interop

Friend Class frmMainScreen
    Inherits System.Windows.Forms.Form
    Dim nLineTot As Integer
    Dim cReadLine As String
    Dim timer3_count As Short
    Dim filecheckinterval As Short
    Dim appstat As Boolean
    Dim showquickappt As Boolean
    Dim dnloadfiles() As String
    Dim ftpRetrieveList As String()
    Dim tmpUser As String
    Dim tmpPwd As String
    Dim tmpRemoteDownload As String
    Dim tmpHost As String
    Dim ftpRetrieveDir As String
    Dim ftp As New FtpSession
    Dim localDownload As String
    Dim outlookcalendar As Microsoft.Office.Interop.Outlook.MAPIFolder
    Dim calendaritem As Microsoft.Office.Interop.Outlook.AppointmentItem
    Dim m_Appointments As List(Of Appointment)

    ''' <summary>
    ''' This procedure will display the File To Import form
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmdFilesToImport_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFilesToImport.Click
        frmFilesToImportList.ShowDialog()
    End Sub

    ''' <summary>
    ''' This procedure will display the Files To Transmit form
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmdFilesToXmit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFilesToXmit.Click
        frmWsToXmitList.ShowDialog()
    End Sub

    ''' <summary>
    ''' This procedure will display the Error Message List form
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmdWkstErr_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdWkstErr.Click
        frmErrMsgList.ShowDialog()
    End Sub

    ''' <summary>
    ''' This procedure will show the Transmit But Not on Order form for worksheets that have not been converted to an order but have been
    ''' transmitted
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmdWkstNotOnOrder_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdWkstNotOnOrder.Click
        frmXmitButNotOnOrder.ShowDialog()
    End Sub

    ''' <summary>
    ''' This procedure will show the Worksheets Ready to Transmit form for worksheets that need to be transmitted to Knitcraft
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmdWkstNotTrans_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdWkstNotTrans.Click
        frmWsToXmitList.ShowDialog()
    End Sub

    ''' <summary>
    ''' This procedure shows the Worksheets Waiting for a Response form
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmdWkstWithNoResponse_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdWkstWithNoResponse.Click
        frmXmitButNoVal.ShowDialog()
    End Sub

    Private Sub frmMainScreen_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
    End Sub

    ''' <summary>
    ''' This procedure is called when the form is displayed.  It performs the following:
    ''' 1)  Displays a menu option to open the database if the user is and administrator on the Windows computer
    ''' 2)  Fills the quick appointment combo box with customer names
    ''' 3)  Checks to see if the database needs to perform a purge, and if so, does it
    ''' 4)  Runs the routine to download any Titan files that need to be imported into the database
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub frmMainScreen_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        If Not IsProcessRunning("Outlook") Then
            'System.Diagnostics.Process.Start("outlook")
            MsgBox("Outlook is not running, please start Outlook before starting Sales Force Application.", MsgBoxStyle.Information, "Outlook not running, please start Outlook.")
            Me.Close()
        End If

        If My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) Then
            mnuDatabase.Visible = True
        Else
            mnuDatabase.Visible = False
        End If
        Me.CustomerTableAdapter.Fill(Me.SaleForcDataSet.Customer)
        DayView1.Renderer = New Office12Renderer()
        m_Appointments = New List(Of Appointment)()
        Dim cn As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        Dim answer As Short
        Label1.Text = "version " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor
        Label1.Text = "Version " & My.Application.Info.Version.ToString
        'Dim drDefaults As SaleForcDataSet.DefaultsRow = SaleForcDataSet.Defaults.First
        'filecheckinterval = drDefaults("FileCheckInterval")

        filecheckinterval = GetProgramDefaults("FileCheckInterval")

        cn.ConnectionString = MySettings.Default("SaleForcConnectionString")
        cn.Open()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM [Purge Defaults]", cn)
        da.Fill(dt)
        cn.Close()
        If dt.Rows(0)("PurgeCheck") = True Then
            If DateDiff(Microsoft.VisualBasic.DateInterval.Month, dt.Rows(0)("LastCompletedPurge"), Now) > dt.Rows(0)("PurgeMonths") Then
                If dt.Rows(0)("PurgePassesRemaining") <> 0 Then
                    answer = MsgBox("It is time to purge your database, click on Ok to continue.  If you choose not to purge the database at this time you will have " & CStr(dt.Rows(0)("PurgePassesRemaining") - 1) & " more attempts to complete this before the purge will automatically take place.", MsgBoxStyle.OkCancel + MsgBoxStyle.MsgBoxSetForeground, "Purge Database")
                End If
                If answer = MsgBoxResult.Ok Then
                    Me.Show()
                    Me.Refresh()
                    ConfirmPurge = False
                    AutoPurge = True
                    frmPurgeDB.ShowDialog()
                    frmPurgeDB.Close()
                    AutoPurge = False
                    ConfirmPurge = True
                End If
                If answer = MsgBoxResult.Cancel Then
                    'Try
                    Dim conn As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
                    Dim com As OleDb.OleDbCommand
                    conn.Open()
                    com = New OleDb.OleDbCommand("UPDATE [Purge Defaults] SET [PurgePassesRemaining] = '" & dt.Rows(0)("PurgePassesRemaining") - 1 & "'", conn)
                    com.ExecuteNonQuery()
                    com.Dispose()
                    conn.Close()
                End If
            End If
        End If
        cmbAppt.SelectedIndex = -1
        lblCustAddress.ResetText()
        llblTitanFileStatus_LinkClicked(Me, Nothing)
        Me.Activate()
    End Sub

    ''' <summary>
    ''' This procedure disables timers that perform various functions and checks to make sure no files are being downloaded before closing
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub frmMainScreen_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim Cancel As Boolean = eventArgs.Cancel

        If appstat = True Then
            MsgBox("Cannot close the program, the program is checking" & vbCrLf & "for files and emails.  Please try again.", MsgBoxStyle.Critical, "Close Program Message")
            Cancel = True
        End If

        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        Timer5.Enabled = False

        eventArgs.Cancel = Cancel
    End Sub

    ''' <summary>
    ''' This procedure emails the sales reps itinerary to the address stored in the 'AppointmentEmail' field in the 'Defaults' table using
    ''' the built in SMTP client
    ''' </summary>
    ''' <param name="dteStartDate"></param>
    ''' <remarks></remarks>

    Sub EmailAppts(ByVal dteStartDate As Date)
        Dim OutlookApp As Microsoft.Office.Interop.Outlook.Application
        Dim OutlookNameSpace As Microsoft.Office.Interop.Outlook.NameSpace
        Dim colCal As Microsoft.Office.Interop.Outlook.Items
        Dim strFind As String
        Dim colMyAppts As Microsoft.Office.Interop.Outlook.Items
        Dim objAppt As Microsoft.Office.Interop.Outlook.AppointmentItem
        Dim strHTML As String
        Dim dteEndDate As Date
        Dim smtpClient As New SmtpClient(GetProgramDefaults("SMTPServer"))

        dteEndDate = DateAdd(DateInterval.Day, 7, dteStartDate)

        OutlookApp = New Microsoft.Office.Interop.Outlook.Application

        OutlookNameSpace = OutlookApp.GetNamespace("MAPI")

        ' start HTML for message
        strHTML = "<p style='font-size:90%;font-weight:bold;'>" &
                  cSalesmanName &
                         "'s Itinerary (" &
                         FormatDateTime(dteStartDate, DateFormat.ShortDate) &
                         " through " &
                         FormatDateTime(DateAdd("d", 7, dteStartDate), DateFormat.ShortDate) & ")" &
                         ":</p><table>"
        colCal = OutlookNameSpace.GetDefaultFolder(Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderCalendar).Items
        colCal.Sort("[Start]")
        colCal.IncludeRecurrences = True
        ' get appointments spanning date
        strFind = "[Start] <= " & Quote(dteEndDate.ToString("g")) & " AND [End] >= " & Quote(dteStartDate.ToString("g"))
        colMyAppts = colCal.Restrict(strFind)
        strHTML = strHTML & "<p style='font-size:80%;'>"
        For Each objAppt In colMyAppts
            strHTML = strHTML & AddApptRow(objAppt) & "<br><hr>"
        Next
        strHTML = strHTML & "</p>"

        ' create new message

        Dim mailmessage1 As New MailMessage(cSalesmanEmail, GetProgramDefaults("AppointmentEmail"), cSalesmanName & "'s Itinerary (" & FormatDateTime(dteStartDate, vbShortDate) & " through " & FormatDateTime(DateAdd("d", 7, dteStartDate), vbShortDate) & ")", strHTML & "</table>")
        mailmessage1.IsBodyHtml = True
        smtpClient.Send(mailmessage1)
        MsgBox("Itinerary has been sent to: " & GetProgramDefaults("AppointmentEmail"), MsgBoxStyle.Information, "Send Itinerary")
        OutlookNameSpace.Logoff()
    End Sub

    ''' <summary>
    ''' This procedure is used to add a line to the body of the itinerary email.  It adds the appointment information.
    ''' </summary>
    ''' <param name="objAppt"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Function AddApptRow(ByVal objAppt As Microsoft.Office.Interop.Outlook.AppointmentItem) As String
        Dim strRow As String
        strRow = "<tr><td valign=" & Quote("top") &
                "width=" & Quote("250") & ">"

        If objAppt.AllDayEvent = True Then
            strRow = strRow & "<font size='2'> All Day Event on " & Format(objAppt.Start, "Long Date")
        Else
            strRow = strRow &
                      "<font size='2'>" & Format(objAppt.Start, "Long Date") &
                             "<font color=> @ " & Format(objAppt.Start, "Short Time")
        End If
        strRow = strRow & "</td><td valign=" & Quote("top") & "><u><font size='2'>" &
                objAppt.Subject &
                       "</u><br>"
        If objAppt.Location <> "" Then
            strRow = strRow & " <i>(" &
                  objAppt.Location & ")</i>"
        End If
        strRow = strRow & "<br><br>"
        If objAppt.Body <> "" Then
            strRow = strRow & objAppt.Body & "<br><br>"
        End If
        strRow = strRow & "</td>"
        AddApptRow = strRow
    End Function

    ''' <summary>
    ''' This procedure put quotes around the text passed into it
    ''' </summary>
    ''' <param name="MyText"></param>
    ''' <returns>A string variable with quotes</returns>
    ''' <remarks></remarks>

    Function Quote(ByRef MyText As String) As String
        Quote = Chr(34) & MyText & Chr(34)
    End Function

    ''' <summary>
    ''' This procedure will show or hide the calendar that is used to display Sales Reps appointments
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub ShowHideAppts()
        Dim EarliestStartHour As Integer = 24

        If Me.lblShowAppointments.Text = "Show Appointments" Then
            DayView1.DaysToShow = 7
            DayView1.Height = 235
            DayView1.Top = 271
            DayView1.Visible = True
            DayView1.StartDate = DateAdd(DateInterval.Day, -DatePart(DateInterval.Weekday, Today) + 1, Today)
            SetCalendarTitle()
            lblcalendarmonth.Visible = True
            LoadOutlookAppointments()
            'Show earliest appointment first
            Dim i As Integer
            If m_Appointments.Count > 0 Then
                For i = 0 To m_Appointments.Count - 1
                    If m_Appointments(i).StartDate >= DayView1.StartDate And m_Appointments(i).StartDate <= DateAdd(DateInterval.Day, 7, DayView1.StartDate) And m_Appointments(i).StartDate >= Today Then
                        If CInt(m_Appointments(i).StartDate.ToString("HH")) < EarliestStartHour Then
                            EarliestStartHour = CInt(m_Appointments(i).StartDate.ToString("HH"))
                        End If
                    End If
                Next
                DayView1.StartHour = EarliestStartHour
            Else
                DayView1.StartHour = 8
            End If
            Me.lblShowAppointments.Top = 250
            Me.lblShowAppointments.Text = "Hide Appointments"
            llblGotoPreviousWeekAppt.Visible = True
            llblGotoThisWeekAppt.Visible = True
            llblGotoNextWeekAppt.Visible = True
            Me.llblEmailAppointments.Visible = True
            If Me.cmbAppt.Visible = True Then
                showquickappt = True
                Me.lblQuickAppt.Visible = False
                Me.cmbAppt.Visible = False
                Me.cmdAddAppt.Visible = False
                Me.lblCustAddress.Visible = False
            End If
        Else
            If showquickappt = True Then
                Me.lblQuickAppt.Visible = True
                Me.cmbAppt.Visible = True
                Me.cmdAddAppt.Visible = True
                Me.lblCustAddress.Visible = True
                showquickappt = False
            End If
            DayView1.Top = 511
            DayView1.Height = 0
            DayView1.Visible = False
            Me.lblShowAppointments.Top = 497
            Me.lblShowAppointments.Text = "Show Appointments"
            llblGotoPreviousWeekAppt.Visible = False
            llblGotoThisWeekAppt.Visible = False
            llblGotoNextWeekAppt.Visible = False
            Me.llblEmailAppointments.Visible = False
            Me.lblcalendarmonth.Visible = False
        End If
    End Sub

    ''' <summary>
    ''' This procedure will download any files that are waiting to be picked up from the Titan server
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Public Sub mnuCommProComm_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuCommProComm.Click
        llblTitanFileStatus_LinkClicked(mnuCommProComm, Nothing)
    End Sub

    ''' <summary>
    ''' This procedure will display the Customer Item Report - A report that shows which customers ordered a specific item
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Public Sub mnuCustItem_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuCustItem.Click
        frmCustItemRpt.ShowDialog(Me)
    End Sub

    ''' <summary>
    ''' This procedure displays the program's help file
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Public Sub mnuHelpContents_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHelpContents.Click
        Dim dblProcess As Double
        dblProcess = Shell("hh.exe """ & System.AppDomain.CurrentDomain.BaseDirectory & "\salesforce.chm""", 1)
    End Sub

    ''' <summary>
    ''' This program displays the inventory form
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Public Sub mnuInventoryMatrix_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuInventoryMatrix.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        frmInventory.ShowDialog(Me)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub

    ''' <summary>
    ''' This program displays the About form
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Public Sub mnuAbout_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuAbout.Click
        frmAbout.ShowDialog()
    End Sub
    Public Sub mnuMailTest_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuMailTest.Click

        Email("support@stcroixcollections.com", "Test", "This is a test", "c:\test.txt", True)
        'Dim Outlook As Outlook.Application
        'Dim Mail As Outlook.MailItem
        'Dim Acc As Outlook.Account

        'Outlook = New Outlook.Application()
        'Mail = Outlook.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem)
        'Mail.To = "support@stcroixcollections.com"
        'Mail.Subject = "Hello World"
        ''Mail.Attachments.Add("C:\Path\to\File.pdf")
        'Mail.HTMLBody &= "Hello World!"
        'Mail.Send()
        'Process.Start("mailto:support@stcroixcollections.com?subject=Hello&body=test")
    End Sub
    ''' <summary>
    ''' This procedure displays the Files To Import form
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Public Sub mnuCommImp_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuCommImp.Click
        frmFilesToImportList.ShowDialog()
    End Sub

    ''' <summary>
    ''' This procedure displays the communications log which contains info on files being imported and exported
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Public Sub mnuCommLog_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuCommLog.Click
        Dim retval As Short

        If Dir(filCommLog) <> "" Then
            chkLogSize()
            retval = Shell("notepad.exe " & filCommLog, 3)
        Else
            MsgBox("No communications log file was found")
        End If
    End Sub

    ''' <summary>
    ''' This procedure limits the size of the communications log to 600 lines of text
    ''' </summary>
    ''' <remarks></remarks>

    Sub chkLogSize()
        Dim bufFile, bufFileOut As Short
        Dim nLinesOut As Integer
        Dim nTotLines, nLinesLeft As Integer
        Dim LogFileName, BakFileName As String
        LogFileName = filCommLog
        BakFileName = Mid(filCommLog, 1, Len(filCommLog) - 3) & ".bak"

        nTotLines = LogFileLineCount()
        If nTotLines < 600 Then Exit Sub

        nLinesLeft = 200
        nLinesOut = nTotLines - nLinesLeft

        If Dir(BakFileName) <> "" Then
            Kill(BakFileName)
        End If
        Rename(LogFileName, BakFileName)
        bufFile = FreeFile()
        FileOpen(bufFile, BakFileName, OpenMode.Input)
        bufFileOut = FreeFile()
        FileOpen(bufFileOut, LogFileName, OpenMode.Output)
        Dim x As Integer
        For x = 1 To nLinesOut
            cReadLine = LineInput(bufFile)
        Next x

        Do While Not EOF(bufFile)
            cReadLine = LineInput(bufFile)
            PrintLine(bufFileOut, cReadLine)
        Loop
        FileClose(bufFile, bufFileOut)

    End Sub

    ''' <summary>
    ''' This procedure counts the number of text lines in the communications log file
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Private Function LogFileLineCount() As Integer
        Dim bufFile As Short
        bufFile = FreeFile()
        nLineTot = 0
        FileOpen(bufFile, filCommLog, OpenMode.Input)
        Do While Not EOF(bufFile)
            cReadLine = LineInput(bufFile)
            nLineTot = nLineTot + 1
        Loop
        FileClose(bufFile)
        LogFileLineCount = nLineTot
    End Function

    ''' <summary>
    ''' This procedure displays the Worksheets to Transmit form
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Public Sub mnuCommXmitWS_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuCommXmitWS.Click
        frmWsToXmitList.ShowDialog()
    End Sub

    ''' <summary>
    ''' This procedure displays the Customer Information form
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Public Sub mnuCust_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuCust.Click
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        Timer5.Enabled = False
        frmCustInfo.ShowDialog(Me)
    End Sub

    ''' <summary>
    ''' This procedure closes the form
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Public Sub mnuFileExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' This procedure displays the Customer LIst form
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Public Sub mnuListCust_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuListCust.Click
        nListIndex = 1
        frmCustList.ShowDialog()
    End Sub

    ''' <summary>
    ''' This procedure displays the Files to Import form
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Public Sub mnuListImportFiles_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuListImportFiles.Click
        frmFilesToImportList.ShowDialog()
    End Sub

    ''' <summary>
    ''' This procedure displays the Orders List form
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Public Sub mnuListOrders_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuListOrders.Click
        tmpOrderListRowPos = 0
        tmpOrderListSort = ""
        frmListOrder.ShowDialog()
    End Sub

    ''' <summary>
    ''' This procedure displays the Worksheet List form
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Public Sub mnuListWs_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuListWs.Click
        frmListWs.ShowDialog()
    End Sub

    ''' <summary>
    ''' This procedure displays the Worksheet Error Message form
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Public Sub mnuListWsErrMsg_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuListWsErrMsg.Click
        frmErrMsgList.ShowDialog()
    End Sub

    ''' <summary>
    ''' This procedure displays the Worksheets to Transmit form
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Public Sub mnuListWsToXmit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuListWsToXmit.Click
        frmWsToXmitList.ShowDialog()
    End Sub

    ''' <summary>
    ''' This procedure displays the Worksheets Transmitted but not Validated form
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Public Sub mnuListWsXmButNoVal_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuListWsXmButNoVal.Click
        frmXmitButNoVal.ShowDialog()
    End Sub

    ''' <summary>
    ''' This procedure makes a call to compact the database
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Public Sub mnuMaintRepairDB_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuMaintRepairDB.Click
        CompactDatabase((True))
    End Sub

    ''' <summary>
    ''' This procedure displays the Re-Transmit Worksheet form
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Public Sub mnuMaintReXmit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuMaintReXmit.Click
        frmResetXmit.ShowDialog()
    End Sub

    ''' <summary>
    ''' This procedure displays the Salesman form.  This form shows Salesman and Worksheet Defaults
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Public Sub mnuRefSPR_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuRefSPR.Click
        frmSalesPerson.ShowDialog()
    End Sub

    ''' <summary>
    ''' This procedure displays the Worksheet Default form so the user can modify worksheet defaults
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Public Sub mnuUtilPresetVal_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuUtilPresetVal.Click
        frmWSDefaults.ShowDialog()
    End Sub

    ''' <summary>
    ''' This procedure displays the Database Purge form
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Public Sub mnuUtilPurge_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuUtilPurge.Click
        frmPurgeDB.Show()
    End Sub

    ''' <summary>
    ''' This procedure will display the communications log using Notepad
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Public Sub mnuViewCommLog_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuViewCommLog.Click
        Dim retval As Short

        If Dir(filCommLog) <> "" Then
            chkLogSize()
            retval = Shell("notepad.exe " & filCommLog, 3)
        Else
            MsgBox("No communications log file was found")
        End If
    End Sub

    ''' <summary>
    ''' This procedure makes calls to:
    ''' 1)  Check for Titan files that need to be imported into the database
    ''' 2)  Check for worksheets that have error messages that can be maintained
    ''' 3)  Check for files that need to be transmitted to Knitcraft
    ''' 4)  Check for worksheets that have been transmitted but no status update has been sent back 
    ''' 5)  Check for worksheets that need to be put into a file for transmit to Knitcraft
    ''' 6)  Check for worksheets that have been transmitted, but not yet converted to an order
    ''' </summary>
    ''' <remarks></remarks>

    Public Sub UpdateStatus()
        chkForImportFiles()
        chkForWsErrors()
        chkForXmitFiles()
        chkForXmitedWkstWithNoResponse()
        chkForWkstToConvertToFile()
        chkForWkstNotOnOrder()
    End Sub

    ''' <summary>
    ''' This procedure checks for Titan files that need to be imported into the database
    ''' </summary>
    ''' <remarks></remarks>

    Public Sub chkForImportFiles()
        Dim fil() As String

        If Not IO.Directory.Exists(cImportPath) Then
            MsgBox(cImportPath & " does not exist. Please create before trying again. The program will now end.", MsgBoxStyle.Critical, "Check For Import Files")
            End
        End If

        fil = System.IO.Directory.GetFiles(cImportPath, "*" & cImportFileExtension)
        If fil.Length > 0 Then
            cmdFilesToImport.Visible = True
            mnuListImportFiles.Enabled = True
            mnuCommImp.Enabled = True
        Else
            cmdFilesToImport.Visible = False
            mnuListImportFiles.Enabled = False
            mnuCommImp.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' This procedure checks for files that need to be transmitted to Knitcraft
    ''' </summary>
    ''' <remarks></remarks>

    Public Sub chkForXmitFiles()
        '--- Check the \upload directory to see if any files have not been processed
        Dim fil() As String

        If Not IO.Directory.Exists(cExportPath) Then
            MsgBox(cExportPath & " does not exist. Please create before proceeding. The program will now end.", MsgBoxStyle.Critical, "Check For Files to Transmit")
            End
        End If

        fil = System.IO.Directory.GetFiles(cExportPath, "*" & cExportFileExtension)
        If fil.Length > 0 Then
            If FileLen(fil(0)) <> 0 Then
                cmdFilesToXmit.Visible = True
                mnuListWsToXmit.Enabled = True
                mnuCommXmitWS.Enabled = True
            End If
        Else
            cmdFilesToXmit.Visible = False
            mnuListWsToXmit.Enabled = False
            mnuCommXmitWS.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' This procedure checks for worksheets that have error messages that can be maintained
    ''' </summary>
    ''' <remarks></remarks>

    Public Sub chkForWsErrors()
        Dim cn As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        cn.ConnectionString = MySettings.Default("SaleForcConnectionString")
        cn.Open()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM WsErrorMsg WHERE [canmaintain] = True", cn)
        da.Fill(dt)

        If dt.Rows.Count = 0 Then
            cmdWkstErr.Visible = False
            mnuListWsErrMsg.Enabled = False
        Else
            cmdWkstErr.Visible = True
            mnuListWsErrMsg.Enabled = True
        End If
        cn.Close()
    End Sub

    ''' <summary>
    ''' This procedure checks for worksheets that have been transmitted but no status update has been sent back 
    ''' </summary>
    ''' <remarks></remarks>

    Public Sub chkForXmitedWkstWithNoResponse()
        Dim cn As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        cn.ConnectionString = MySettings.Default("SaleForcConnectionString")
        cn.Open()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM [ws-ord-head] WHERE [xmitted] = True and [validation-status] = 'NO VAL'", cn)
        da.Fill(dt)

        If dt.Rows.Count = 0 Then
            cmdWkstWithNoResponse.Visible = False
            mnuListWsXmButNoVal.Enabled = False
        Else
            cmdWkstWithNoResponse.Visible = True
            mnuListWsXmButNoVal.Enabled = True
        End If
        cn.Close()
    End Sub

    ''' <summary>
    ''' This procedure checks for worksheets that have been transmitted, but not yet converted to an order
    ''' </summary>
    ''' <remarks></remarks>

    Public Sub chkForWkstNotOnOrder()
        Dim cn As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable

        cn.ConnectionString = MySettings.Default("SaleForcConnectionString")
        cn.Open()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM [ws-ord-head] WHERE [xmitted] = True AND [validation-status] <> 'NO VAL' AND [validation-status] <> 'ORDER' and [validation-status] <> 'CANCEL'", cn)
        da.Fill(dt)

        If dt.Rows.Count = 0 Then
            cmdWkstNotOnOrder.Visible = False
        Else
            cmdWkstNotOnOrder.Visible = True
        End If
        cn.Close()
    End Sub

    ''' <summary>
    ''' This procedure checks for worksheets that need to be put into a file for transmit to Knitcraft
    ''' </summary>
    ''' <remarks></remarks>

    Public Sub chkForWkstToConvertToFile()
        Dim cn As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        cn.ConnectionString = MySettings.Default("SaleForcConnectionString")
        cn.Open()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM [ws-ord-head] WHERE [xmitted] = False AND [readytoxmit] = True", cn)
        da.Fill(dt)

        If dt.Rows.Count = 0 Then
            mnuCommXmitWS.Enabled = False
            cmdWkstNotTrans.Visible = False
        Else
            mnuCommXmitWS.Enabled = True
            cmdWkstNotTrans.Visible = True
        End If
        cn.Close()
    End Sub

    ''' <summary>
    ''' Timer used to check if there is an internet connection available
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
        If Connection() Then
            lblConnectionStatus.Text = "Internet Status:  Connected"
            lblInternetStatus.BackColor = System.Drawing.Color.Lime
            lblInternetStatus.Refresh()
        Else
            lblConnectionStatus.Text = "Internet Status:  Not Connected"
            lblInternetStatus.BackColor = System.Drawing.Color.Red
            lblTitanStatus.Visible = False
            lblTitanFileStatus.Visible = False
            lblInternetStatus.Refresh()
        End If
    End Sub

    ''' <summary>
    ''' Timer used to see if there are files to import into the database or export to KC
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub Timer2_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer2.Tick
        Dim fil() As String
        'MsgBox("timer2 tick")

        If Not System.IO.Directory.Exists(cExportPath) Then Exit Sub
        fil = System.IO.Directory.GetFiles(cExportPath, "*" & cExportFileExtension)
        If fil.Length > 0 Then
            If FileLen(fil(0)) <> 0 Then
                cmdFilesToXmit.Visible = True
                mnuListWsToXmit.Enabled = True
                mnuCommXmitWS.Enabled = True
            End If
        Else
            cmdFilesToXmit.Visible = False
            mnuListWsToXmit.Enabled = False
            mnuCommXmitWS.Enabled = False
        End If
        If Not System.IO.Directory.Exists(cImportPath) Then Exit Sub
        fil = System.IO.Directory.GetFiles(cImportPath, "*" & cImportFileExtension)
        If fil.Length > 0 Then
            If FileLen(fil(0)) <> 0 Then
                cmdFilesToImport.Visible = True
                mnuListImportFiles.Enabled = True
            End If
        Else
            cmdFilesToImport.Visible = False
            mnuListImportFiles.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' This procedure is used to find out how many files are on the Titan server to be picked up (downloaded)
    ''' </summary>
    ''' <remarks></remarks>

    Public Sub CheckFiles()
        lblTitanStatus.BackColor = System.Drawing.Color.Yellow
        lblTitanFileStatus.Text = "Checking for Titan files to download"
        lblTitanFileStatus.Refresh()
        ListKCFiles()
        Try
            If ftpRetrieveList.Length - 1 > 0 Then
                lblTitanFileStatus.Enabled = True
                lblTitanFileStatus.Text = "Titan File Status: " & ftpRetrieveList.Length - 1 & " file(s) waiting"
                lblTitanStatus.Enabled = True
                lblTitanStatus.BackColor = System.Drawing.Color.Red
                Return
            Else
                lblTitanFileStatus.Text = "Titan File Status: No file(s) waiting"
                lblTitanStatus.Enabled = False
                lblTitanStatus.BackColor = System.Drawing.Color.Lime
            End If
        Catch e As Exception
            lblTitanFileStatus.Text = "Cannot Connect to " & tmpHost
            lblTitanStatus.Enabled = False
            lblTitanStatus.BackColor = System.Drawing.Color.Red
        End Try

    End Sub


    'Function Get_After_Seperator(ByVal strString As String, ByVal intNthOccurance As Short, ByVal strSeperator As String) As String
    '    Dim intStartOfString As Short
    '    Dim boolnotfound As Boolean
    '    Dim intIndex As Short
    '    Dim intEndOfString As Short

    '    'check for intNthOccurance = 0--i.e. first one

    '    If (intNthOccurance = 0) Then


    '        If (InStr(strString, strSeperator) > 0) Then
    '            Get_After_Seperator = VB.Left(strString, InStr(strString, strSeperator) - 1)
    '        Else
    '            Get_After_Seperator = strString
    '        End If
    '    Else
    '        'not the first one
    '        'init start of string on first comma
    '        intStartOfString = InStr(strString, strSeperator)

    '        'place start of string after intNthOccurance-th comma (-1 since
    '        'already did one
    '        boolnotfound = 0


    '        For intIndex = 1 To intNthOccurance - 1
    '            'get next comma
    '            intStartOfString = InStr(intStartOfString + 1, strString, strSeperator)

    '            'check for not found
    '            If (intStartOfString = 0) Then
    '                boolnotfound = 1
    '            End If
    '        Next intIndex

    '        'put start of string past 1st comma
    '        intStartOfString = intStartOfString + 1

    '        'check for ending in a comma
    '        If (intStartOfString > Len(strString)) Then
    '            boolnotfound = 1
    '        End If

    '        If (boolnotfound = 1) Then
    '            Get_After_Seperator = "NOT FOUND"
    '        Else
    '            intEndOfString = InStr(intStartOfString, strString, strSeperator)

    '            ' check for no second comma (i.e. end of string)

    '            If (intEndOfString = 0) Then
    '                intEndOfString = Len(strString) + 1
    '            Else
    '                intEndOfString = intEndOfString - 1
    '            End If
    '            Get_After_Seperator = Mid(strString, intStartOfString, intEndOfString - intStartOfString + 1)
    '        End If
    '    End If
    'End Function

    ''' <summary>
    ''' Timer used to check if there are Titan files on the Knitcraft manufacturing system to download
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub Timer3_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer3.Tick
        If Connection() Then
            timer3_count = timer3_count + 1
            If timer3_count = filecheckinterval And filecheckinterval <> 0 Then
                timer3_count = 0
                CheckFiles()
            End If
        Else
            lblTitanStatus.Visible = False
            lblTitanFileStatus.Visible = False
        End If
    End Sub

    ''' <summary>
    ''' Timer that checks for email and files to download when this program starts; this timer is then disabled because Timer 3 and 
    ''' Timer 4 check after the main screen is fully loaded and running.  Did not put it in the form load  event because the check 
    ''' for files takes too much time and delays the showing of frmMainScreen.
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub Timer5_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer5.Tick
        If Connection() Then
            CheckFiles()
            Timer5.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' This procedure displays the 7 days prior to the first displayed date on the appointment calendar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub llblGotoPreviousWeekAppt_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblGotoPreviousWeekAppt.LinkClicked
        DayView1.StartDate = DateAdd(DateInterval.Day, -7, DayView1.StartDate)
        SetCalendarTitle()
    End Sub

    ''' <summary>
    ''' This procedure displays the current week's calendar appointments
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub llblGotoThisWeekAppt_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblGotoThisWeekAppt.LinkClicked
        DayView1.StartDate = DateAdd(DateInterval.Day, -DatePart(DateInterval.Weekday, Today) + 1, Today)
        SetCalendarTitle()
    End Sub

    ''' <summary>
    ''' This procedure displays the 7 days after the last displayed date on the appointment calendar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub llblGotoNextWeekAppt_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblGotoNextWeekAppt.LinkClicked
        DayView1.StartDate = DateAdd(DateInterval.Day, 7, DayView1.StartDate)
        SetCalendarTitle()
    End Sub

    ''' <summary>
    ''' This procedure will show/hide calendar appointments
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub llblQuickAppt_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblQuickAppt.LinkClicked
        If lblQuickAppt.Text = "Quick Appointment Entry" Then
            If lblShowAppointments.Text = "Hide Appointments" Then
                ShowHideAppts()
            End If
            Me.lblQuickAppt.Text = "Hide Quick Appointment Entry"
            Me.cmbAppt.Visible = True
            Me.cmdAddAppt.Visible = True
            Me.lblCustAddress.Visible = True
            Me.lblQuickAppt.Top = 348
            Me.chkViewActiveCustomers.Visible = True
        Else
            Me.lblQuickAppt.Text = "Quick Appointment Entry"
            Me.cmbAppt.Visible = False
            Me.cmdAddAppt.Visible = False
            Me.lblCustAddress.Visible = False
            Me.lblQuickAppt.Top = 473
            Me.chkViewActiveCustomers.Visible = False
        End If
        cmbAppt.ResetText()
    End Sub

    ''' <summary>
    ''' This procedure displays a form which allows the user to select a date.  The date will be the start date email 7 days worth of
    ''' calendar appointments
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub llblEmailAppointments_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblEmailAppointments.LinkClicked
        frmSetItineraryDate.ShowDialog()
        If tmpcancel_emailitinerary = False Then
            Call EmailAppts(tmpItineraryStart)
        End If
    End Sub

    ''' <summary>
    ''' This procedure will display the St Croix Shop website in the default browser
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub llblStCroix_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblStCroix.LinkClicked
        If Connection() Then
            Dim browser As New Process()
            browser.StartInfo.FileName = GetProgramDefaults("ShopWeb")
            browser.StartInfo.UseShellExecute = True
            browser.Start()
        Else
            MsgBox("You must be connected to the internet to perform this task", vbInformation, "Quick Links")
        End If
    End Sub

    ''' <summary>
    ''' This procedure will display the St Croix Collections website in the default browser
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub llblStCroixKnits_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblStCroixKnits.LinkClicked
        If Connection() Then
            Dim browser As New Process()
            browser.StartInfo.FileName = GetProgramDefaults("KnitcraftWeb")
            browser.StartInfo.UseShellExecute = True
            browser.Start()
        Else
            MsgBox("You must be connected to the internet to perform this task", vbInformation, "Quick Links")
        End If
    End Sub

    ''' <summary>
    ''' This procedure will display the Sales Meeting website in the default browser
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub llblSalesMeeting_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblSalesMeeting.LinkClicked
        If Connection() Then
            Dim browser As New Process()
            browser.StartInfo.FileName = GetProgramDefaults("SalesMtgWeb")
            browser.StartInfo.UseShellExecute = True
            browser.Start()
        Else
            MsgBox("You must be connected to the internet to perform this task", vbInformation, "Quick Links")
        End If
    End Sub

    ''' <summary>
    ''' This procedure will display a new email window using the default mail client with the Sales Department email address in the To: box
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub llblEmailCustSv_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblEmailCustSv.LinkClicked
        ShellExecute(Me.Handle, vbNullString, "mailto:" & GetProgramDefaults("SalesDeptEmail"), vbNullString, "C:\", SW_SHOWNORMAL)
    End Sub

    ''' <summary>
    ''' This procedure will display a new email window using the default mail client with the IT Support email address in the To: box
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub llblEmailAnyone_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblEmailSupport.LinkClicked
        ShellExecute(Me.Handle, vbNullString, "mailto:" & GetProgramDefaults("SupportEmail"), vbNullString, "C:\", SW_SHOWNORMAL)
    End Sub

    ''' <summary>
    ''' This procedure will download any files that are on the Titan server to the local machine
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub llblTitanFileStatus_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblTitanFileStatus.LinkClicked
        If Connection() Then
            ListKCFiles()
            DnLoadKCFiles()
            UncompressDeleteKCFiles()
            CheckFiles()
        Else
            MsgBox("You must be connected to the internet to perform this task", vbInformation, "Quick Links")
        End If
    End Sub

    ''' <summary>
    ''' This procedure will Show/Hide the appointment calendar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub llblShowAppointments_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblShowAppointments.LinkClicked
        ShowHideAppts()
    End Sub

    ''' <summary>
    ''' This procedure loads when form is displayed.  It also performs the following:
    ''' 1)  Enables timers that perform various checks (the functions of the timers are described in the timer's Tick function)
    ''' 2)  Loads any appointments on the user's Outlook calendar into the calendar on this form
    ''' 3)  Checks if records exists in various tables to enable/disable menu items
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub frmMainScreen_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True
        UpdateStatus()
        If DayView1.Visible Then LoadOutlookAppointments()
        If isTableEmpty(1) Then 'Cust
            mnuCust.Enabled = False
            mnuListCust.Enabled = False
        Else
            mnuCust.Enabled = True
            mnuListCust.Enabled = True
        End If

        If isTableEmpty(2) Then 'Item
            mnuInv.Enabled = False
        Else
            mnuInv.Enabled = True
        End If

        If isTableEmpty(3) Then 'Order
            mnuListOrders.Enabled = False
        Else
            mnuListOrders.Enabled = True
        End If

        If isTableEmpty(4) Then 'worksheet
            mnuListWs.Enabled = False
            mnuListWsErrMsg.Enabled = False
            mnuCommXmitWS.Enabled = False
            mnuMaintReXmit.Enabled = False

        Else
            mnuListWs.Enabled = True
            mnuListWsErrMsg.Enabled = True
            mnuCommXmitWS.Enabled = True
            mnuMaintReXmit.Enabled = True
        End If
        If isTableEmpty(5) Then 'Salesman
            mnuUtilPresetVal.Enabled = False
        Else
            mnuUtilPresetVal.Enabled = True
        End If
        If isTableEmpty(6) Then 'WS Error Messages
            mnuListWsErrMsg.Enabled = False
        Else
            mnuListWsErrMsg.Enabled = True
        End If
        If cmdFilesToXmit.Visible = False Then
            mnuListWsToXmit.Enabled = False
            mnuCommXmitWS.Enabled = False
        Else
            mnuListWsToXmit.Enabled = True
            mnuCommXmitWS.Enabled = False
        End If
        If cmdFilesToImport.Visible = False Then
            mnuListImportFiles.Enabled = False
            mnuCommImp.Enabled = False
        Else
            mnuListImportFiles.Enabled = True
            mnuCommImp.Enabled = True
        End If
        If cmdWkstErr.Visible = False Then
            mnuListWsErrMsg.Enabled = False
        Else
            mnuListWsErrMsg.Enabled = True
        End If
        If cmdWkstNotTrans.Visible = False Then
            mnuCommXmitWS.Enabled = False
            mnuListWsToXmit.Enabled = False
        Else
            mnuCommXmitWS.Enabled = True
            mnuListWsToXmit.Enabled = True
        End If
    End Sub

    ''' <summary>
    ''' This procedure adds a customer appointment to the user's Microsoft Office Outlook calendar 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub cmdAddAppt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddAppt.Click
        Dim OutlookApp As Microsoft.Office.Interop.Outlook.Application
        Dim OutlookNameSpace As Microsoft.Office.Interop.Outlook.NameSpace
        OutlookApp = New Microsoft.Office.Interop.Outlook.Application
        OutlookNameSpace = OutlookApp.GetNamespace("MAPI")
        Dim newAppointment As Microsoft.Office.Interop.Outlook.AppointmentItem
        Dim spLinks As Microsoft.Office.Interop.Outlook.Links
        Dim splink As Microsoft.Office.Interop.Outlook.Link
        Dim spContacts As Microsoft.Office.Interop.Outlook.Items
        Dim spContact As Microsoft.Office.Interop.Outlook.ContactItem
        Dim objFolder As Microsoft.Office.Interop.Outlook.MAPIFolder
        Dim colFolders As Microsoft.Office.Interop.Outlook.Folders
        Dim folder As Microsoft.Office.Interop.Outlook.MAPIFolder
        Dim drv As DataRowView = Me.bndCustomers.Current

        If Len(Trim(cmbAppt.Text)) = 0 Then
            MsgBox("You must select a customer first!", MsgBoxStyle.Critical, "Add Appointment")
            Exit Sub
        End If

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        newAppointment = OutlookApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olAppointmentItem)
        objFolder = OutlookNameSpace.GetDefaultFolder(Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderContacts)
        colFolders = objFolder.Folders

        If colFolders.Count > 0 Then
            For Each folder In colFolders
                If folder.Name = "Customers" Then
                    objFolder = colFolders("Customers")
                    spContacts = objFolder.Items
                    Exit For
                End If
            Next folder
        End If

        spContact = objFolder.Items.Find("[CustomerID] = " & Chr(34) & Me.cmbAppt.Text & Chr(34))

        Me.Cursor = System.Windows.Forms.Cursors.Default

        With newAppointment
            .Subject = drv.Row("cust-no") & " - " & Me.cmbAppt.Text
            .Location = drv.Row("address2") & ", " & drv.Row("city") & ", " & drv.Row("st") & " " & drv.Row("zip-code") & " (Tel: " & drv.Row("telephone") & ")"
            '.body = "Contact: " & adocustinfo.Recordset("contact") & vbCrLf & "Telephone: " & adocustinfo.Recordset("telephone")
            .BillingInformation = drv.Row("cust-no") 'used to filter appointments
            .ReminderMinutesBeforeStart = 1440
            .Duration = 120
            'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
            If Not TypeName(spContact) = "Nothing" Then
                spLinks = .Links
                splink = spLinks.Add(spContact)
            End If
            .Categories = "Knitcraft Customer Appointment"
            .Display(False)
            'FindAppWindow("OUTLOOK", .Subject & " - Appointment")
            'OutlookApp.ActiveWindow.activate()
        End With
        ' Outlook closes after user either clicks on 'Save and Close' to save the appt or closes the window without saving.
        Exit Sub
ErrorRoutine:
        If Err.Number = 91 Then
            MsgBox("Can not create appointment for <blank> customer! Please find customer first.", MsgBoxStyle.Critical, "New Appointment")
        End If
    End Sub

    ''' <summary>
    ''' This procedure displays the Customer Information in a box (label control) when the user is selecting a customer to add an 
    ''' appointment
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub bndCustomers_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bndCustomers.CurrentChanged
        lblCustAddress.Text = bndCustomers.Current("name").ToString & vbCrLf & bndCustomers.Current("address1").ToString & vbCrLf & bndCustomers.Current("address2").ToString & vbCrLf & bndCustomers.Current("address3").ToString & vbCrLf & bndCustomers.Current("city").ToString & ", " & bndCustomers.Current("st").ToString & " " & bndCustomers.Current("zip-code").ToString
    End Sub

    ''' <summary>
    ''' This procedure downloads files from the Titan server
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub DnLoadKCFiles()
        Try
            ProgressBar1.Maximum = ftpRetrieveList.Length
            ProgressBar1.Visible = True
            ProgressBar1.Show()
            Dim ftpFileName As String
            For Each ftpFileName In ftpRetrieveList
                If ftpFileName.Length > 0 Then
                    ftp.RetrieveFtpFile(ftpRetrieveDir & "/" & ftpFileName, GetProgramDefaults("FileDownloadPath") & ftpFileName)
                    ftp.DeleteFtpFile(ftpRetrieveDir & ftpFileName)
                    ProgressBar1.Increment(1)
                End If
            Next
        Catch e As Exception
        End Try
        ProgressBar1.Visible = False
    End Sub

    ''' <summary>
    ''' This procedure gets a list of files from the Titan server so that the DnLoadKCFiles procedure knows what to download
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub ListKCFiles()
        tmpHost = GetProgramDefaults("FTPHostName")
        tmpUser = GetProgramDefaults("FTPSalesRepLogin")
        tmpPwd = String.Concat(tmpUser, GetProgramDefaults("FTPSalesRepNumber"))
        'MsgBox("CMA : tmpPwd=""" & tmpPwd & """")
        tmpRemoteDownload = GetProgramDefaults("FTPRemoteDownLoad")
        localDownload = GetProgramDefaults("FTPLocalDownload")

        'ftpRetrieveDir = "ftp://" & tmpHost & Mid(tmpRemoteDownload, 1, 1) & "%2f" & Mid(tmpRemoteDownload, 2) & "/"
        ' **** CMA : 2021/04/14 **** produces runtime error
        ftpRetrieveDir = "ftp://" & tmpHost & "/" & tmpRemoteDownload & "/"
        ftp.ftpUser = tmpUser
        ftp.ftpPwd = tmpPwd
        ftpRetrieveList = ftp.RetrieveFtpDirectory(ftpRetrieveDir)
    End Sub

    ''' <summary>
    ''' This procedure loads Microsoft Office Outlook calendar items into the calendar on this form
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub LoadOutlookAppointments()
        'Try
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\Windows Messaging Subsystem\Profiles\", "DefaultProfile", Nothing) = "" Then Exit Sub
        Dim OutlookApp As Microsoft.Office.Interop.Outlook.Application
        Dim OutlookNameSpace As Microsoft.Office.Interop.Outlook.NameSpace
        OutlookApp = New Microsoft.Office.Interop.Outlook.Application
        OutlookNameSpace = OutlookApp.GetNamespace("MAPI")
        outlookcalendar = OutlookNameSpace.GetDefaultFolder(Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderCalendar)
        If m_Appointments.Count > 0 Then m_Appointments.RemoveRange(0, m_Appointments.Count)
        For Each calendaritem In outlookcalendar.Items
            Dim appt As New Appointment()
            appt.Title = calendaritem.Subject
            appt.StartDate = calendaritem.Start
            appt.EndDate = calendaritem.End
            appt.AllDayEvent = calendaritem.AllDayEvent
            appt.Color = Color.LightBlue
            appt.TextColor = Color.Black
            m_Appointments.Add(appt)
        Next
        'DayView1.Invalidat'e()
        OutlookNameSpace.Logoff()
        'OutlookApp.Quit()
    End Sub

    ''' <summary>
    ''' This procedure is used when creating new appointments on the calendar on this form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="args"></param>
    ''' <remarks></remarks>

    Private Sub DayView1_NewAppointment(ByVal sender As Object, ByVal args As Calendar.NewAppointmentEventArgs) Handles DayView1.NewAppointment
        Dim m_Appointment As New Appointment()

        m_Appointment.StartDate = args.StartDate
        m_Appointment.EndDate = args.EndDate
        m_Appointment.Title = args.Title

        m_Appointments.Add(m_Appointment)
    End Sub

    ''' <summary>
    ''' This procedure is used when adding appointments to the calendar on this form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="args"></param>
    ''' <remarks></remarks>

    Private Sub DayView1_ResolveAppointments(ByVal sender As Object, ByVal args As Calendar.ResolveAppointmentsEventArgs) Handles DayView1.ResolveAppointments
        Dim m_Apps As New List(Of Appointment)()

        For Each m_App As Appointment In m_Appointments
            If (m_App.StartDate >= args.StartDate) AndAlso (m_App.StartDate <= args.EndDate) Then
                m_Apps.Add(m_App)
            End If
        Next
        args.Appointments = m_Apps
    End Sub

    ''' <summary>
    ''' This procedure filters data in the customer table to show active customers or all customers
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub chkViewActiveCustomers_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkViewActiveCustomers.CheckedChanged
        If chkViewActiveCustomers.CheckState = System.Windows.Forms.CheckState.Checked Then
            Me.bndCustomers.Filter = "[status-code] = '" & "P" & "'"
        ElseIf chkViewActiveCustomers.CheckState = System.Windows.Forms.CheckState.Unchecked Then
            Me.bndCustomers.Filter = "[status-code] Is Not Null"
        End If
        Me.bndCustomers.Sort = "Name"
    End Sub

    ''' <summary>
    ''' This procedure is used to create a title for the calendar on this form
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub SetCalendarTitle()
        lblcalendarmonth.Text = MonthName(DayView1.StartDate.Month, False) & " " & DayView1.StartDate.Year
        If Month(DateAdd(DateInterval.Day, DayView1.DaysToShow - 1, DayView1.StartDate)) <> DayView1.StartDate.Month Then
            lblcalendarmonth.Text = MonthName(DayView1.StartDate.Month) & "/" & MonthName(Month(DateAdd(DateInterval.Day, DayView1.DaysToShow, DayView1.StartDate))) & " " & DayView1.StartDate.Year
        End If
    End Sub

    ''' <summary>
    ''' This procedure will open up the St Croix Collections Facebook page in the default internet browser
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub pbFacebook_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbFacebook.Click
        If Connection() Then
            Dim browser As New Process()
            browser.StartInfo.FileName = GetProgramDefaults("FacebookWebPage")
            browser.StartInfo.UseShellExecute = True
            browser.Start()
        Else
            MsgBox("You must be connected to the internet to perform this task", vbInformation, "Quick Links")
        End If
    End Sub

    ''' <summary>
    ''' This procedure will open up the St Croix Collections Pinterest page in the default internet browser
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub pbPinterest_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbPinterest.Click
        If Connection() Then
            Dim browser As New Process()
            browser.StartInfo.FileName = GetProgramDefaults("PinterestWebPage")
            browser.StartInfo.UseShellExecute = True
            browser.Start()
        Else
            MsgBox("You must be connected to the internet to perform this task", vbInformation, "Quick Links")
        End If
    End Sub

    ''' <summary>
    ''' This procedure will open up the St Croix Collections Twitter page in the default internet browser
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub pbTwitter_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbTwitter.Click
        If Connection() Then
            Dim browser As New Process()
            browser.StartInfo.FileName = GetProgramDefaults("TwitterWebPage")
            browser.StartInfo.UseShellExecute = True
            browser.Start()
        Else
            MsgBox("You must be connected to the internet to perform this task", vbInformation, "Quick Links")
        End If
    End Sub

    ''' <summary>
    ''' This procedure displays a tooltip when the user hovers the mouse cursor over the image
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub pbFacebook_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbFacebook.MouseEnter
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        ToolTip1.Active = True
        ToolTip1.Show("Click here to visit the St Croix Collections Facebook page!", pbFacebook, 3000)
    End Sub

    ''' <summary>
    ''' This procedure deactivates the tooltip when the mouse cursor is no longer hovering over the image
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub pbFacebook_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbFacebook.MouseLeave
        Me.Cursor = System.Windows.Forms.Cursors.Default
        ToolTip1.Active = False
    End Sub

    ''' <summary>
    ''' This procedure displays a tooltip when the user hovers the mouse cursor over the image
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub pbPinterest_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbPinterest.MouseEnter
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        ToolTip1.Active = True
        ToolTip1.Show("Click here to visit the St Croix Collections Pinterest page!", pbPinterest, 3000)
    End Sub

    ''' <summary>
    ''' This procedure deactivates the tooltip when the mouse cursor is no longer hovering over the image
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub pbPinterest_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbPinterest.MouseLeave
        Me.Cursor = System.Windows.Forms.Cursors.Default
        ToolTip1.Active = False
    End Sub

    ''' <summary>
    ''' This procedure displays a tooltip when the user hovers the mouse cursor over the image
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub pbTwitter_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbTwitter.MouseEnter
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        ToolTip1.Active = True
        ToolTip1.Show("Click here to visit the St Croix Collections Twitter page!", pbTwitter, 3000)
    End Sub

    ''' <summary>
    ''' This procedure deactivates the tooltip when the mouse cursor is no longer hovering over the image
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub pbTwitter_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbTwitter.MouseLeave
        Me.Cursor = System.Windows.Forms.Cursors.Default
        ToolTip1.Active = False
    End Sub

    ''' <summary>
    ''' This procedure will open up the database in the default program (user must be an administrator)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub mnuDatabase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDatabase.Click
        ShellExecute(0, "OPEN", dbName, "", dbPath, 1)
    End Sub

    ''' <summary>
    ''' This procedure will open up the St Croix Collections Google Plus page in the default internet browser
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub pbGooglePlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbGooglePlus.Click
        If Connection() Then
            Dim browser As New Process()
            browser.StartInfo.FileName = GetProgramDefaults("GooglePlusWebPage")
            browser.StartInfo.UseShellExecute = True
            browser.Start()
        Else
            MsgBox("You must be connected to the internet to perform this task", vbInformation, "Quick Links")
        End If
    End Sub

    ''' <summary>
    ''' This procedure will open up the St Croix Collections YouTube page in the default internet browser
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub pbYouTube_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbYouTube.Click
        If Connection() Then
            Dim browser As New Process()
            browser.StartInfo.FileName = GetProgramDefaults("YouTubeWebPage")
            browser.StartInfo.UseShellExecute = True
            browser.Start()
        Else
            MsgBox("You must be connected to the internet to perform this task", vbInformation, "Quick Links")
        End If
    End Sub

    ''' <summary>
    ''' This procedure displays a tooltip when the user hovers the mouse cursor over the image
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub pbGooglePlus_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbGooglePlus.MouseEnter
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        ToolTip1.Active = True
        ToolTip1.Show("Click here to visit the St Croix Collections Google Plus page!", pbGooglePlus, 3000)
    End Sub

    ''' <summary>
    ''' This procedure deactivates the tooltip when the mouse cursor is no longer hovering over the image
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub pbGooglePlus_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbGooglePlus.MouseLeave
        Me.Cursor = System.Windows.Forms.Cursors.Default
        ToolTip1.Active = False
    End Sub

    ''' <summary>
    ''' This procedure displays a tooltip when the user hovers the mouse cursor over the image
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub pbYouTube_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbYouTube.MouseEnter
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        ToolTip1.Active = True
        ToolTip1.Show("Click here to visit the St Croix Collections You Tube page!", pbYouTube, 3000)
    End Sub

    ''' <summary>
    ''' This procedure deactivates the tooltip when the mouse cursor is no longer hovering over the image
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub pbYouTube_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbYouTube.MouseLeave
        Me.Cursor = System.Windows.Forms.Cursors.Default
        ToolTip1.Active = False
    End Sub

End Class