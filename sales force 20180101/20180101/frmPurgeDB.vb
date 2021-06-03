Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.PowerPacks
Imports System.Data.OleDb

Friend Class frmPurgeDB
	Inherits System.Windows.Forms.Form
    Dim sql As String
    Dim formloaded As Boolean

    ''' <summary>
    ''' This procedure updates the 'PurgeCheck' field in the 'Purge Defaults' table in the database to check to see if a purge needs to be
    ''' run.
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
	
    Private Sub chkDefPurge_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkDefPurge.CheckStateChanged
        If formloaded Then
            Dim conn As New OleDbConnection(MySettings.Default("SaleForcConnectionString"))
            Dim com As OleDbCommand
            conn.Open()
            If chkDefPurge.CheckState = System.Windows.Forms.CheckState.Checked Then
                com = New OleDb.OleDbCommand("UPDATE [Purge Defaults] SET [PurgeCheck] = True", conn)
            Else
                com = New OleDb.OleDbCommand("UPDATE [Purge Defaults] SET [PurgeCheck] = False", conn)
            End If
            com.ExecuteNonQuery()
            conn.Close()
        End If
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
    ''' This is the procedure that will start the other purge procedures
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Public Sub cmdPurge_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPurge.Click
        Dim result As Short
        Dim sourcefile As String
        Dim destinationfile As String
        Dim conn As New OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim com As OleDbCommand

        If ConfirmPurge = True Then
            result = MsgBox("Are you sure you want to purge the selected records? WARNING:  This process can take several minutes to run.", MsgBoxStyle.YesNo, "Purge Database")
            If result = 7 Then
                Exit Sub
            End If
        End If

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Me.Refresh()
        Timer1.Enabled = True
        lblWhatsHappening.Text = "Backing up the database"
        lblWhatsHappening.Refresh()
        sourcefile = dbName
        destinationfile = Mid(dbName, 1, Len(dbName) - 4) & "backup.mdb"

        My.Computer.FileSystem.CopyFile(sourcefile, destinationfile, True)

        lblWhatsHappening.Text = "Please wait while the data is being prepared..."
        lblWhatsHappening.Refresh()
        cmdPurge.Enabled = False
        cmdExit.Enabled = False

        If chkOrders.CheckState = System.Windows.Forms.CheckState.Checked Then
            Me.lblOrderStatus.Text = "Purging..."
            Me.lblOrderStatus.ForeColor = System.Drawing.Color.Red
            Me.lblOrderStatus.Refresh()
            Call PurgeOrder()
            Call PurgeOrderHistory()
            Call PurgeOrderLine()
            Call PurgeOrderLineHistory()
            Me.lblOrderStatus.ForeColor = System.Drawing.Color.Lime
            Me.lblOrderStatus.Text = "Purge Complete!"
            Me.lblOrderStatus.Refresh()
        End If
        If chkWorksheets.CheckState = System.Windows.Forms.CheckState.Checked Then
            Me.lblWorksheetStatus.Text = "Purging..."
            Me.lblWorksheetStatus.ForeColor = System.Drawing.Color.Red
            Me.lblWorksheetStatus.Refresh()

            Call PurgeWorksheetLine()
            Call PurgeWorksheetLineHistory()
            Call PurgeWsMemo()
            Call PurgeWsMemoHistory()
            Call PurgeWsErrorMsgs()
            Call PurgeWsErrorMsgHistory()
            Call PurgeWorksheet()
            Call PurgeWorksheetHistory()

            Me.lblWorksheetStatus.ForeColor = System.Drawing.Color.Lime
            Me.lblWorksheetStatus.Text = "Purge Complete!"
            Me.lblWorksheetStatus.Refresh()
        End If
        If chkItems.CheckState = System.Windows.Forms.CheckState.Checked Then
            Me.lblItemStatus.Text = "Purging..."
            Me.lblItemStatus.ForeColor = System.Drawing.Color.Red
            Me.lblItemStatus.Refresh()
            Call PurgeItems()
            Me.lblItemStatus.ForeColor = System.Drawing.Color.Lime
            Me.lblItemStatus.Text = "Purge Complete!"
            Me.lblItemStatus.Refresh()
        End If
        If chkCustomers.CheckState = System.Windows.Forms.CheckState.Checked Then
            Me.lblCustomerStatus.Text = "Purging..."
            Me.lblCustomerStatus.ForeColor = System.Drawing.Color.Red
            Me.lblCustomerStatus.Refresh()
            Call PurgeCustomer()
            Call PurgeCustomerHistory()
            Call PurgeCustomerSH()
            Call PurgeCustomerSHHistory()
            Call PurgeCustomerMemo()
            Call PurgeCustomerMemoHistory()
            Me.lblCustomerStatus.ForeColor = System.Drawing.Color.Lime
            Me.lblCustomerStatus.Text = "Purge Complete!"
            Me.lblCustomerStatus.Refresh()
        End If
        lblWhatsHappening.Text = "Start Purging Orphan Records"
        lblWhatsHappening.Refresh()
        PurgeOrphanRecords()

        lblWhatsHappening.Text = "Compacting and Repairing the Database"
        lblWhatsHappening.Refresh()
        CompactDatabase((False))

        conn.Open()
        com = New OleDbCommand("UPDATE [Purge Defaults] SET [LastCompletedPurge] = #" & Now & "#, [PurgePassesRemaining] = 15", conn)
        com.ExecuteNonQuery()
        com.Dispose()
        conn.Close()

        lblWhatsHappening.Text = "Purging Complete!"
        lblWhatsHappening.Refresh()


        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        cmdExit.Enabled = True
        cmdPurge.Enabled = True
        Me.BringToFront()
    End Sub

    Private Sub PurgeOrder()
        Dim conn As New OleDbConnection(MySettings.Default("SaleForcConnectionString") & ";Jet OLEDB:Global Partial Bulk Ops=1")
        Dim com As OleDbCommand

        lblWhatsHappening.Text = "Moving Orders to Order history"
        lblWhatsHappening.Refresh()

        conn.Open()
        'Copy orders to order-history
        com = New OleDbCommand("INSERT INTO [Order-history] SELECT * FROM [Order] WHERE [Order].[Lastupdate] < #" & CStr(dtpOrder.Value) & "#", conn)
        com.ExecuteNonQuery()
        com.Dispose()

        'Delete order records
        com = New OleDbCommand("DELETE FROM [Order] WHERE [Order].[Lastupdate] < #" & CStr(dtpOrder.Value) & "#", conn)
        com.ExecuteNonQuery()
        com.Dispose()

        conn.Close()

    End Sub

    Private Sub PurgeOrderHistory()
        Dim conn As New OleDbConnection(MySettings.Default("SaleForcConnectionString") & ";Jet OLEDB:Global Partial Bulk Ops=1")
        Dim com As OleDbCommand

        lblWhatsHappening.Text = "Deleting Order History records"
        lblWhatsHappening.Refresh()
        conn.Open()

        com = New OleDbCommand("DELETE * FROM [Order-history] WHERE [Order-history].[Lastupdate] < #" & CStr(dtpOrderHistory.Value) & "#", conn)
        com.ExecuteNonQuery()
        com.Dispose()
        conn.Close()

    End Sub

    Private Sub PurgeOrderLine()
        Dim conn As New OleDbConnection(MySettings.Default("SaleForcConnectionString") & ";Jet OLEDB:Global Partial Bulk Ops=1")
        Dim com As OleDbCommand


        lblWhatsHappening.Text = "Moving Order Lines to history "
        lblWhatsHappening.Refresh()

        conn.Open()

        'Copy order-line to order-line-history
        com = New OleDbCommand("INSERT INTO [Order-line-history] SELECT * FROM [Order-line] WHERE [Order-line].[order-no] NOT IN (SELECT [order].[order-no] FROM [order])", conn)
        com.ExecuteNonQuery()
        com.Dispose()

        'Delete order-line records
        com = New OleDbCommand("DELETE FROM [Order-line] WHERE [Order-line].[order-no] NOT IN (SELECT [order].[order-no] FROM [order])", conn)
        com.ExecuteNonQuery()
        com.Dispose()
        conn.Close()

    End Sub

    Private Sub PurgeOrderLineHistory()
        Dim conn As New OleDbConnection(MySettings.Default("SaleForcConnectionString") & ";Jet OLEDB:Global Partial Bulk Ops=1")
        Dim com As OleDbCommand

        lblWhatsHappening.Text = "Deleting Order Line History records"
        lblWhatsHappening.Refresh()

        conn.Open()

        com = New OleDbCommand("DELETE * FROM [Order-line-history] WHERE [Order-line-history].[order-no] NOT IN (SELECT [order-history].[order-no] FROM [order-history])", conn)
        com.ExecuteNonQuery()
        com.Dispose()

        conn.Close()
    End Sub

    Private Sub PurgeWorksheet()
        Dim conn As New OleDbConnection(MySettings.Default("SaleForcConnectionString") & ";Jet OLEDB:Global Partial Bulk Ops=1")
        Dim com As OleDbCommand

        lblWhatsHappening.Text = "Moving Worksheets to history"
        lblWhatsHappening.Refresh()

        conn.Open()

        'Copy ws-ord-head records to ws-ord-history
        com = New OleDbCommand("INSERT INTO [ws-ord-head-history] SELECT * FROM [ws-ord-head] WHERE [ws-ord-head].[Lastupdated] < #" & CStr(dtpWorksheet.Value) & "# AND [ws-ord-head].[validation-status] = 'ORDER' OR [ws-ord-head].[validation-status] = 'CANCEL'", conn)
        com.ExecuteNonQuery()
        com.Dispose()

        'Delete ws-ord-head records
        com = New OleDbCommand("DELETE FROM [ws-ord-head] WHERE [Lastupdated] < #" & CStr(dtpWorksheet.Value) & "# AND [validation-status] = 'ORDER' OR [ws-ord-head].[validation-status] = 'CANCEL'", conn)
        com.ExecuteNonQuery()
        com.Dispose()

        conn.Close()

    End Sub

    Private Sub PurgeWorksheetHistory()
        Dim conn As New OleDbConnection(MySettings.Default("SaleForcConnectionString") & ";Jet OLEDB:Global Partial Bulk Ops=1")
        Dim com As OleDbCommand
        lblWhatsHappening.Text = "Deleting Worksheet History records"
        lblWhatsHappening.Refresh()

        conn.Open()

        com = New OleDbCommand("DELETE * FROM [ws-ord-head-history] WHERE [ws-ord-head-history].[Lastupdated] < #" & CStr(dtpWorksheetHistory.Value) & "#", conn)
        com.ExecuteNonQuery()
        com.Dispose()

        conn.Close()
    End Sub

    Private Sub PurgeWorksheetLine()
        Dim conn As New OleDbConnection(MySettings.Default("SaleForcConnectionString") & ";Jet OLEDB:Global Partial Bulk Ops=1")
        Dim com As OleDbCommand

        lblWhatsHappening.Text = "Moving Worksheet Lines to history"
        lblWhatsHappening.Refresh()

        conn.Open()

        'Create temporary table with worksheet ids that will be moved into history
        com = New OleDbCommand("CREATE TABLE DeleteIDs ([worksheet-id] CHAR NOT NULL PRIMARY KEY)", conn)
        com.ExecuteNonQuery()
        com.Dispose()

        'Insert records into temporary table
        com = New OleDbCommand("INSERT INTO DeleteIds ([worksheet-id]) SELECT [worksheet-id] FROM [ws-ord-head] WHERE [ws-ord-head].[Lastupdated] < #" & CStr(dtpWorksheet.Value) & "# AND [ws-ord-head].[validation-status] = 'ORDER' OR [ws-ord-head].[validation-status] = 'CANCEL'", conn)
        com.ExecuteNonQuery()
        com.Dispose()

        'Copy ws-ord-line records to ws-ord-line-history
        com = New OleDbCommand("INSERT INTO [ws-ord-line-history] SELECT * FROM [ws-ord-line] WHERE [worksheet-id] IN (SELECT [worksheet-id] FROM DeleteIDs)", conn)
        com.ExecuteNonQuery()
        com.Dispose()

        'Delete ws-ord-line records
        com = New OleDbCommand("DELETE FROM [ws-ord-line] WHERE [worksheet-id] IN (SELECT [worksheet-id] FROM DeleteIDs)", conn)
        com.ExecuteNonQuery()
        com.Dispose()

        'Delete temporary table
        com = New OleDbCommand("DROP TABLE DeleteIDs", conn)
        com.ExecuteNonQuery()
        com.Dispose()

        conn.Close()
    End Sub

    Private Sub PurgeWorksheetLineHistory()
        Dim conn As New OleDbConnection(MySettings.Default("SaleForcConnectionString") & ";Jet OLEDB:Global Partial Bulk Ops=1")
        Dim com As OleDbCommand

        lblWhatsHappening.Text = "Deleting Worksheet Lines History records"
        lblWhatsHappening.Refresh()

        conn.Open()

        com = New OleDbCommand("DELETE * FROM [ws-ord-line-history] WHERE [ws-ord-line-history].[worksheet-id] NOT IN (SELECT [ws-ord-head-history].[worksheet-id] FROM [ws-ord-head-history])", conn)
        com.ExecuteNonQuery()
        com.Dispose()

        conn.Close()

    End Sub

    Private Sub PurgeWsMemo()
        Dim conn As New OleDbConnection(MySettings.Default("SaleForcConnectionString") & ";Jet OLEDB:Global Partial Bulk Ops=1")
        Dim com As OleDbCommand


        lblWhatsHappening.Text = "Moving Worksheet Memos to history"
        lblWhatsHappening.Refresh()

        conn.Open()

        'Copy wsmemo records into wsmemo-history
        com = New OleDbCommand("INSERT INTO [wsmemo-history] SELECT * FROM [wsmemo] where [wsmemo].[worksheet-id]  NOT IN (SELECT [ws-ord-head].[worksheet-id] FROM [ws-ord-head])", conn)
        com.ExecuteNonQuery()
        com.Dispose()

        'Delete wsmemo records
        com = New OleDbCommand("DELETE * FROM [wsmemo] where [wsmemo].[worksheet-id]  NOT IN (SELECT [ws-ord-head].[worksheet-id] FROM [ws-ord-head])", conn)
        com.ExecuteNonQuery()
        com.Dispose()

        conn.Close()
    End Sub

    Private Sub PurgeWsMemoHistory()
        Dim conn As New OleDbConnection(MySettings.Default("SaleForcConnectionString") & ";Jet OLEDB:Global Partial Bulk Ops=1")
        Dim com As OleDbCommand
        lblWhatsHappening.Text = "Deleting Worksheet Memos History records"
        lblWhatsHappening.Refresh()

        conn.Open()

        com = New OleDbCommand("DELETE * FROM [wsmemo-history] WHERE [wsmemo-history].[worksheet-id]  NOT IN (SELECT [ws-ord-head-history].[worksheet-id] FROM [ws-ord-head-history])", conn)
        com.ExecuteNonQuery()
        com.Dispose()

        conn.Close()

    End Sub

    Private Sub PurgeWsErrorMsgs()
        Dim conn As New OleDbConnection(MySettings.Default("SaleForcConnectionString") & ";Jet OLEDB:Global Partial Bulk Ops=1")
        Dim com As OleDbCommand

        lblWhatsHappening.Text = "Moving Worksheet Error Messages to history"
        lblWhatsHappening.Refresh()

        conn.Open()

        'Copy wserrormsg into wserrormsg-history
        com = New OleDbCommand("INSERT INTO [wserrormsg-history] SELECT * FROM [wserrormsg] WHERE [wserrormsg].[worksheet-id]  NOT IN (SELECT [worksheet-id] FROM [ws-ord-head])", conn)
        com.ExecuteNonQuery()
        com.Dispose()

        'Delete wserrormsg records
        com = New OleDbCommand("DELETE * FROM [wserrormsg] WHERE [wserrormsg].[worksheet-id]  NOT IN (SELECT [ws-ord-head].[worksheet-id] FROM [ws-ord-head])", conn)
        com.ExecuteNonQuery()
        com.Dispose()

        conn.Close()

    End Sub

    Private Sub PurgeWsErrorMsgHistory()
        Dim conn As New OleDbConnection(MySettings.Default("SaleForcConnectionString") & ";Jet OLEDB:Global Partial Bulk Ops=1")
        Dim com As OleDbCommand

        lblWhatsHappening.Text = "Deleting Worksheet Error Messages History records"
        lblWhatsHappening.Refresh()

        conn.Open()

        com = New OleDbCommand("DELETE * FROM [wserrormsg-history] WHERE [wserrormsg-history].[worksheet-id]  NOT IN (SELECT [ws-ord-head-history].[worksheet-id] FROM [ws-ord-head-history])", conn)
        com.ExecuteNonQuery()
        com.Dispose()

        conn.Close()
    End Sub

    Private Sub PurgeCustomer()
        Dim conn As New OleDbConnection(MySettings.Default("SaleForcConnectionString") & ";Jet OLEDB:Global Partial Bulk Ops=1")
        Dim com As OleDbCommand


        lblWhatsHappening.Text = "Moving Customer records to history"
        lblWhatsHappening.Refresh()

        conn.Open()

        'Copy customer records into customer-history
        com = New OleDbCommand("INSERT INTO [customer-history] SELECT * FROM [customer] WHERE (((customer.ArBalance)=0) AND ((customer.LastPayDate)<#" & dtpCustomer.Value & "#) AND ((customer.LastOrdDate)<#" & dtpCustomer.Value & "#) AND ((customer.LastUpdated)<#" & dtpCustomer.Value & "#) AND ((Exists (SELECT [cust-no] FROM [ws-ord-head] WHERE [ws-ord-head].[cust-no] = [customer].[cust-no]))=False) AND ((Exists (SELECT [cust-no] FROM [order] WHERE [order].[cust-no] = [customer].[cust-no]))=False));", conn)
        com.ExecuteNonQuery()
        com.Dispose()

        'Delete customer records
        com = New OleDbCommand("DELETE * FROM [customer] WHERE (((customer.ArBalance)=0) AND ((customer.LastPayDate)<#" & dtpCustomer.Value & "#) AND ((customer.LastOrdDate)<#" & dtpCustomer.Value & "#) AND ((customer.LastUpdated)<#" & dtpCustomer.Value & "#) AND ((Exists (SELECT [cust-no] FROM [ws-ord-head] WHERE [ws-ord-head].[cust-no] = [customer].[cust-no]))=False) AND ((Exists (SELECT [cust-no] FROM [order] WHERE [order].[cust-no] = [customer].[cust-no]))=False));", conn)
        com.ExecuteNonQuery()
        com.Dispose()

        conn.Close()
        PurgeOutlookCustomerContacts()
    End Sub

    Private Sub PurgeCustomerHistory()
        Dim conn As New OleDbConnection(MySettings.Default("SaleForcConnectionString") & ";Jet OLEDB:Global Partial Bulk Ops=1")
        Dim com As OleDbCommand


        lblWhatsHappening.Text = "Deleting Customer History records"
        lblWhatsHappening.Refresh()

        conn.Open()

        com = New OleDbCommand("DELETE * FROM [customer-history] WHERE ((([customer-history].[LastPayDate])<#" & Me.dtpCustomerHistory.Value & "#) AND (([customer-history].[LastOrdDate])<#" & Me.dtpCustomerHistory.Value & "#) AND (([customer-history].[LastUpdated])<#" & Me.dtpCustomerHistory.Value & "#) AND ((Exists (SELECT [cust-no] FROM [ws-ord-head-history] WHERE [ws-ord-head-history].[cust-no] = [customer-history].[cust-no]))=False) AND ((Exists (SELECT [cust-no] FROM [order-history] WHERE [order-history].[cust-no] = [customer-history].[cust-no]))=False));", conn)
        com.ExecuteNonQuery()
        com.Dispose()

        conn.Close()

    End Sub

    Private Sub PurgeCustomerSH()
        Dim conn As New OleDbConnection(MySettings.Default("SaleForcConnectionString") & ";Jet OLEDB:Global Partial Bulk Ops=1")
        Dim com As OleDbCommand

        lblWhatsHappening.Text = "Moving Customer Ship-to records to history"
        lblWhatsHappening.Refresh()

        conn.Open()

        'Copy customersh records into customersh-history
        com = New OleDbCommand("INSERT INTO [customersh-history] SELECT * FROM [customersh] WHERE (Exists (SELECT [cust-no] FROM [customer] WHERE [customer].[cust-no] = [customersh].[cust-no])=False)", conn)
        com.ExecuteNonQuery()
        com.Dispose()

        'Delete customersh records
        com = New OleDbCommand("DELETE * FROM [customersh] WHERE (Exists (SELECT [cust-no] FROM [customer] WHERE [customer].[cust-no] = [customersh].[cust-no])=False)", conn)
        com.ExecuteNonQuery()
        com.Dispose()

        conn.Close()

    End Sub

    Private Sub PurgeCustomerSHHistory()
        Dim conn As New OleDbConnection(MySettings.Default("SaleForcConnectionString") & ";Jet OLEDB:Global Partial Bulk Ops=1")
        Dim com As OleDbCommand

        lblWhatsHappening.Text = "Deleting Customer Ship-to History records"
        lblWhatsHappening.Refresh()

        conn.Open()

        com = New OleDbCommand("DELETE * FROM [customersh-history] WHERE (Exists (SELECT [cust-no] FROM [customer-history] WHERE [customer-history].[cust-no] = [customersh-history].[cust-no])=False)", conn)
        com.ExecuteNonQuery()
        com.Dispose()

        conn.Close()

    End Sub

    Private Sub PurgeCustomerMemo()
        Dim conn As New OleDbConnection(MySettings.Default("SaleForcConnectionString") & ";Jet OLEDB:Global Partial Bulk Ops=1")
        Dim com As OleDbCommand

        lblWhatsHappening.Text = "Moving Customer Memo records to history"
        lblWhatsHappening.Refresh()

        conn.Open()

        'Copy customermemo records into customermemo-history
        com = New OleDbCommand("INSERT INTO [customermemo-history] SELECT * FROM [customermemo] WHERE (Exists (SELECT [cust-no] FROM [customer] WHERE [customer].[cust-no] = [customermemo].[custno])=False)", conn)
        com.ExecuteNonQuery()
        com.Dispose()

        'Delete customermemo records
        com = New OleDbCommand("DELETE * FROM [customermemo] WHERE (Exists (SELECT [cust-no] FROM [customer] WHERE [customer].[cust-no] = [customermemo].[custno])=False)", conn)
        com.ExecuteNonQuery()
        com.Dispose()

        conn.Close()

    End Sub

    Private Sub PurgeCustomerMemoHistory()
        Dim conn As New OleDbConnection(MySettings.Default("SaleForcConnectionString") & ";Jet OLEDB:Global Partial Bulk Ops=1")
        Dim com As OleDbCommand

        lblWhatsHappening.Text = "Deleting Customer Memo History records"
        lblWhatsHappening.Refresh()

        conn.Open()

        com = New OleDbCommand("DELETE * FROM [customermemo-history] WHERE (Exists (SELECT [cust-no] FROM [customer-history] WHERE [customer-history].[cust-no] = [customermemo-history].[custno])=False)", conn)
        com.ExecuteNonQuery()
        com.Dispose()

        conn.Close()
    End Sub


    ''' <summary>
    ''' This procedure runs when the form is displayed.  It will default the date and other controls needed to purge data.  If 'Autopurge' 
    ''' is set to true (set in frmMainScreen) it will start the purge routines automatically. 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub frmPurgeDB_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim conn As New OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim da As New SaleForcDataSetTableAdapters.Purge_DefaultsTableAdapter
        Dim dt As SaleForcDataSet.Purge_DefaultsDataTable
        Dim dr As SaleForcDataSet.Purge_DefaultsRow

        conn.Open()
        formloaded = True

        dt = da.GetData()
        dr = dt.Rows(0)
        conn.Close()

        ' assign purge defaults
        Me.Show()

        dtpOrder.Value = DateAdd(DateInterval.Month, (dr.PurgeOrderMonths.ToString("d") * -1), Now)
        dtpWorksheet.Value = DateAdd(DateInterval.Month, (dr.PurgeWorksheetMonths.ToString("d") * -1), Now)
        dtpItem.Value = DateAdd(DateInterval.Month, (dr.PurgeItemMonths.ToString("d") * -1), Now)
        dtpCustomer.Value = DateAdd(DateInterval.Month, (dr.PurgeCustomerMonths.ToString("d") * -1), Now)
        dtpOrderHistory.Value = DateAdd(DateInterval.Month, (dr.PurgeOrderHistoryMonths.ToString("d") * -1), Now)
        dtpWorksheetHistory.Value = DateAdd(DateInterval.Month, (dr.PurgeWorksheetHistoryMonths.ToString("d") * -1), Now)
        dtpCustomerHistory.Value = DateAdd(DateInterval.Month, (dr.PurgeCustomerHistoryMonths.ToString("d") * -1), Now)
        txtDefPurgeMonths.Text = dr.PurgeMonths.ToString
        If dr.PurgeCheck Then chkDefPurge.CheckState = System.Windows.Forms.CheckState.Checked
        Me.lblOrderStatus.Text = "Not Purged"
        Me.lblWorksheetStatus.Text = "Not Purged"
        Me.lblItemStatus.Text = "Not Purged"
        Me.lblCustomerStatus.Text = "Not Purged"
        If AutoPurge Then
            Me.Refresh()
            System.Windows.Forms.Application.DoEvents()
            cmdPurge_Click(cmdPurge, New System.EventArgs())
        End If
        conn.Close()
    End Sub

    ''' <summary>
    ''' This procedure will update the 'purgemonths' field in the Purge Defaults table if the user changes the text.  'purgemonths' is 
    ''' the interval number of months that the system will check to see if a purge must be completed.
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub txtDefPurgeMonths_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDefPurgeMonths.TextChanged
        If formloaded Then
            Dim conn As New OleDbConnection(MySettings.Default("SaleForcConnectionString"))
            Dim com As OleDbCommand
            conn.Open()
            com = New OleDbCommand("UPDATE [Purge Defaults] SET [purgemonths] = '" & txtDefPurgeMonths.Text & "'", conn)
            com.ExecuteNonQuery()
            com.Dispose()
            conn.Close()
        End If
    End Sub
End Class