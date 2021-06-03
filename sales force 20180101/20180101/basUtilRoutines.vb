Option Strict Off
Option Explicit On
Module basUtilRoutines

    ''' <summary>
    ''' Purges orpan records in the Order,Order Line,WsOrdHead,WsLines,Customer and CustomerSh tables
    ''' </summary>
    ''' <remarks></remarks>

    Public Sub PurgeOrphanRecords()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        PurgeOrderWithNoOrderLines()
        PurgeOrderLinesWithNoOrders()
        PurgeWsHeadWithoutWsLines()
        PurgeWsLinesWithOutWSHead()
        PurgeNewCustRecsWithNoWksts()
        PurgeCustShWithNoCustomer()
        frmPurgeDB.lblWhatsHappening.Text = "Purge Orphan Records COMPLETED"
        frmPurgeDB.Refresh()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    ''' <summary>
    ''' Deletes records from the order table where there are no related Order Line records
    ''' </summary>
    ''' <remarks></remarks>

    Public Sub PurgeOrderWithNoOrderLines()
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim com As New OleDb.OleDbCommand("DELETE * FROM [order] where [order-no] NOT IN (SELECT [order-no] FROM [order-line])", con)
        con.Open()
        frmPurgeDB.lblWhatsHappening.Text = "Purging Orphan Order Records"
        frmPurgeDB.Refresh()
        com.ExecuteNonQuery()
        con.Close()
    End Sub

    ''' <summary>
    ''' Deletes records from the Order Line table where there are no related Order records
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub PurgeOrderLinesWithNoOrders()
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim com As New OleDb.OleDbCommand("DELETE * FROM [order-line] where [order-line].[order-no] NOT IN (SELECT [order].[order-no] FROM [order])", con)
        con.Open()
        frmPurgeDB.lblWhatsHappening.Text = "Purging Orphan Order Line Records"
        frmPurgeDB.Refresh()
        com.ExecuteNonQuery()
        con.Close()
    End Sub

    ''' <summary>
    ''' Deletes records from the CustomerSh table where there is no related Customer record
    ''' </summary>
    ''' <remarks></remarks>

    Public Sub PurgeCustShWithNoCustomer()
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim com As New OleDb.OleDbCommand("DELETE * FROM [customersh] where [customersh].[cust-no] NOT IN (SELECT [customer].[cust-no] FROM [customer])", con)
        con.Open()
        frmPurgeDB.lblWhatsHappening.Text = "Purging Orphan Customer Shipto Records"
        frmPurgeDB.Refresh()
        com.ExecuteNonQuery()
        con.Close()
    End Sub

    ''' <summary>
    ''' Deletes records from the WsOrdHead table where there are no related WsOrdLine records
    ''' </summary>
    ''' <remarks></remarks>

    Public Sub PurgeWsHeadWithoutWsLines()
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim com As New OleDb.OleDbCommand("DELETE * FROM [ws-ord-head] where [ws-ord-head].[worksheet-id]  NOT IN (SELECT [ws-ord-line].[worksheet-id] FROM [ws-ord-line])", con)
        con.Open()
        frmPurgeDB.lblWhatsHappening.Text = "Purging Orphan Worksheet Records"
        frmPurgeDB.Refresh()
        com.ExecuteNonQuery()
        con.Close()
    End Sub

    ''' <summary>
    ''' Deletes records from WsOrdLine where there isn't a related WsOrdHead record
    ''' </summary>
    ''' <remarks></remarks>

    Public Sub PurgeWsLinesWithOutWSHead()
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim com As New OleDb.OleDbCommand("DELETE * FROM [ws-ord-line] where [ws-ord-line].[worksheet-id]  NOT IN (SELECT [ws-ord-head].[worksheet-id] FROM [ws-ord-head])", con)
        con.Open()
        frmPurgeDB.lblWhatsHappening.Text = "Purging Orphan Worksheet Line Records"
        frmPurgeDB.Refresh()
        com.ExecuteNonQuery()
        con.Close()
    End Sub

    ''' <summary>
    ''' Runs the compact and repair process on the current database
    ''' </summary>
    ''' <param name="ShowMessage"></param>
    ''' <remarks></remarks>

    Public Sub CompactDatabase(ByRef ShowMessage As Boolean)
        Dim strOriginalDB, strNewDB As String
        Dim Action As Short
        Dim Msg As String
        Dim strBackupDB As String

        ' ado definitions
        Dim jro As JRO.JetEngine
        jro = New JRO.JetEngine
        Try

            If ShowMessage Then
                Msg = "This may take several minutes," & vbCrLf
                Msg = Msg & "Do you want to continue?"
                Action = MsgBox(Msg, MsgBoxStyle.YesNo, "Compact Database")
            Else
                Action = MsgBoxResult.Yes
            End If
            If Action = MsgBoxResult.Yes Then

                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                strOriginalDB = dbName
                strNewDB = Mid(dbName, 1, Len(dbName) - 4) & "_temp.mdb"
                strBackupDB = Mid(dbName, 1, Len(dbName) - 4) & "_backup.mdb"
                ' Make backup copy of the database (just in case...)
                If Not My.Computer.FileSystem.FileExists(strBackupDB) Then
                    FileCopy(strOriginalDB, strBackupDB)
                End If
                If My.Computer.FileSystem.FileExists(strNewDB) Then
                    My.Computer.FileSystem.DeleteFile(strNewDB)
                End If
                ' Compact original database into new database
                jro.CompactDatabase("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strOriginalDB, "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strNewDB)
                ' Delete the original database
                My.Computer.FileSystem.DeleteFile(strOriginalDB)
                ' Rename the new database the same as the original database
                If My.Computer.FileSystem.FileExists(strOriginalDB) Then
                    My.Computer.FileSystem.RenameFile(strOriginalDB, My.Computer.FileSystem.GetName(strOriginalDB) & Today & TimeOfDay)
                End If
                My.Computer.FileSystem.RenameFile(strNewDB, My.Computer.FileSystem.GetName(strOriginalDB))

                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                If ShowMessage Then MsgBox("Database has been compacted!")
            End If
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Deletes records from the Customer table where there are no WsOrdHead records with that customer number
    ''' </summary>
    ''' <remarks></remarks>

    Public Sub PurgeNewCustRecsWithNoWksts()
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim com As New OleDb.OleDbCommand("DELETE FROM [customer] WHERE [cust-no] NOT IN (SELECT [cust-no] FROM [ws-ord-head]) AND [cust-no] LIKE 'ZZ%'", con)
        con.Open()
        frmPurgeDB.lblWhatsHappening.Text = "Purge Orphan Records: New Customers"
        frmPurgeDB.Refresh()
        com.ExecuteNonQuery()
        con.Close()
    End Sub

    ''' <summary>
    ''' Deletes records from the item table in two phases
    ''' </summary>
    ''' <remarks></remarks>

    Public Sub PurgeItems()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        frmPurgeDB.lblWhatsHappening.Text = "Purging Old Items"
        PurgeItemsPhase1()
        PurgeItemsPhase2()
        frmPurgeDB.lblWhatsHappening.Text = "Item Purge Complete"
        frmPurgeDB.Refresh()
    End Sub

    ''' <summary>
    ''' Deletes records from the Item table where there is no quantity to sell and item is not available to sell and the lastupdate date is older than the purge date selected on the purge screen
    ''' </summary>
    ''' <remarks></remarks>

    Public Sub PurgeItemsPhase1()
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim daItem As New SaleForcDataSetTableAdapters.ItemTableAdapter
        Dim dtItem As New SaleForcDataSet.ItemDataTable
        Dim i As Integer

        frmPurgeDB.lblWhatsHappening.Text = "Scanning Items - Phase 1"
        frmPurgeDB.Refresh()

        con.Open()
        dtItem = daItem.GetData
        dtItem.Select("[canbeordered] = false and [qty-on-hand] = 0 AND [qty-on-po] = 0 AND [qty-cust-ord] = 0 AND [lastupdated] < #" & frmPurgeDB.dtpItem.Value & "#")

        If dtItem.Rows.Count = 0 Then Exit Sub

        For i = (dtItem.Rows.Count - 1) To 0
            If Not DependentItems(dtItem.Rows(i)("Attrib1"), dtItem.Rows(i)("Attrib2"), dtItem.Rows(i)("Attrib3")) Then
                dtItem.Rows(i).Delete()
            End If
        Next
        con.Close()
    End Sub

    ''' <summary>
    ''' This procedure deletes records from the Item table where the attributed item is part of a complete 'style/color/size' item but is no longer needed 
    ''' For example, item '19905000' would no longer be needed if there aren't any '19905000 + size' items
    ''' </summary>
    ''' <remarks></remarks>

    Public Sub PurgeItemsPhase2()
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim daItem As New SaleForcDataSetTableAdapters.ItemTableAdapter
        Dim dtItem As SaleForcDataSet.ItemDataTable
        Dim i As Integer

        con.Open()
        dtItem = daItem.GetData
        dtItem.Select("attrib3 = ''")

        frmPurgeDB.lblWhatsHappening.Text = "Scanning Items - Phase 2"
        frmPurgeDB.Refresh()

        For i = (dtItem.Rows.Count - 1) To 0
            If Not DependentItems(dtItem.Rows(i)("Attrib1"), dtItem.Rows(i)("Attrib2"), dtItem.Rows(i)("Attrib3")) Then
                dtItem.Rows(i).Delete()
            End If
        Next
        con.Close()
    End Sub

    ''' <summary>
    ''' This procedure deletes records from the Item table where the attributed item is part of a complete 'style/color/size' item but is no longer needed 
    ''' For example, item '19905000' would no longer be needed if there aren't any '19905000 + size' items
    ''' </summary>
    ''' <param name="varAttrib1">Attribute 1</param>
    ''' <param name="varAttrib2">Attribute 2</param>
    ''' <param name="varAttrib3">Attribute 3</param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function DependentItems(ByRef varAttrib1 As String, ByRef varAttrib2 As String, ByRef varAttrib3 As String) As Boolean
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim daItem As New SaleForcDataSetTableAdapters.ItemTableAdapter
        Dim dtItem As New SaleForcDataSet.ItemDataTable
        Dim i As Integer

        con.Open()
        dtItem = daItem.GetDataByItem("[attrib1] = '" & varAttrib1 & "' AND [attrib2] = '" & varAttrib2 & "' AND [attrib3] = ''")

        DependentItems = False
        If dtItem.Rows.Count <> 0 And varAttrib1 <> "" Then
            For i = 0 To dtItem.Rows.Count - 1
                If varAttrib1 <> dtItem.Rows(i)("Attrib1") Then
                    Exit For 'DependentItems = False
                End If
                If varAttrib2 <> "" And varAttrib2 <> dtItem.Rows(i)("Attrib2") Then
                    Exit For 'DependentItems = False
                End If
                If varAttrib2 = "" And dtItem.Rows(i)("Attrib2") <> "" Then
                    DependentItems = True
                    Exit For
                End If
                If varAttrib3 = "" And dtItem.Rows(i)("Attrib3") <> "" Then
                    DependentItems = True
                    Exit For
                End If
            Next
        End If
        con.Close()
    End Function
End Module