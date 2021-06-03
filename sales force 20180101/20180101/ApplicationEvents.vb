Namespace My

    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        'Dim hwndSF As Integer
        ''Code to make splash screen's life longer
        'Protected Overrides Function OnInitialize(ByVal commandLineArgs As System.Collections.ObjectModel.ReadOnlyCollection(Of String)) As Boolean
        '    Me.MinimumSplashScreenDisplayTime = 5000 'Milliseconds  
        '    Return MyBase.OnInitialize(commandLineArgs)
        'End Function

        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            AppDomain.CurrentDomain.SetData("DataDirectory", Environment.GetEnvironmentVariable("SaleForceDB"))
        End Sub

        Private Sub MyApplication_UnhandledException(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            e.ExitApplication = False
            MsgBox("The program has encountered an error.  The error will be logged and emailed to technical support.  The program will continue running. Please close the Sales Force Automation application and try the task again.")
            If Not EventLog.SourceExists("Sales Force Automation") Then
                EventLog.CreateEventSource("Sales Force Automation", "Knitcraft Applications")
                MsgBox("The program must exit to create an event log.", MsgBoxStyle.Critical, "Create Event Log")
                End
            End If
            Dim OutlookApp As Microsoft.Office.Interop.Outlook.Application
            OutlookApp = New Microsoft.Office.Interop.Outlook.Application
            Dim dr As SaleForcDataSet.DefaultsRow = Nothing
            Try
                Dim smtpClient As New System.Net.Mail.SmtpClient(dr(0)("SMTPServer"))
                Dim mailmessage1 As New System.Net.Mail.MailMessage("support@stcroixknits.com", GetProgramDefaults("SupportEmail"), "Error in Sales Force Application", "User: " & Environment.GetEnvironmentVariable("username") & "<br><br>" & "Error Message: " & e.Exception.Message & "<br><br>" & "Error Call Stack: " & e.Exception.StackTrace)
                With mailmessage1
                    .IsBodyHtml = True
                End With
                smtpClient.Send(mailmessage1)

            Catch exc As Exception
                MsgBox(exc.Message)
            End Try

            OutlookApp.Quit()
            EventLog.WriteEntry("Sales Force Automation", "User: " & Environment.GetEnvironmentVariable("username") & Chr(13) & Chr(13) & e.Exception.Message & Chr(13) & Chr(13) & e.Exception.StackTrace, EventLogEntryType.Error, 0)
            End
        End Sub
    End Class

End Namespace

