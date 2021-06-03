Option Strict Off
Option Explicit On
Friend Class frmXmitButNotOnOrder
	Inherits System.Windows.Forms.Form

    ''' <summary>
    ''' Get a list of those worksheets that have been processes for transmit but are still at the NO VAL validation status.
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub getXmitNotOnOrder()
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        Dim mysql As String

        mysql = "select [ws-ord-head].[worksheet-id], [ws-ord-head].[ws-create-date], "
        mysql = mysql & "[ws-ord-head].[cust-no], [ws-ord-head].[XmittedDate]"
        mysql = mysql & " from [ws-ord-head] "
        mysql = mysql & " where [ws-ord-head].[Xmitted] = true AND  [ws-ord-head].[Validation-Status] <> 'NO VAL' AND [ws-ord-head].[Validation-Status] <> 'ORDER'"
        If chkHideCancelled.CheckState = System.Windows.Forms.CheckState.Checked Then
            mysql = mysql & " and [ws-ord-head].[Validation-Status] <> 'CANCEL'"
        End If
        mysql = mysql & " order by [ws-ord-head].[ws-create-date] desc"

        con.Open()
        da = New OleDb.OleDbDataAdapter(mysql, con)
        da.Fill(dt)
        con.Close()

        dtgXmitButNotOnOrder.DataSource = dt

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        FormatXmitButNotOnOrderGrid()

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    ''' <summary>
    ''' This procedure filters data in the data grid.  If the user checks the checkbox, worksheets that have been cancelled will not show.
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub chkHideCancelled_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkHideCancelled.CheckStateChanged
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        Dim mysql As String

        If chkHideCancelled.CheckState = System.Windows.Forms.CheckState.Checked Then
            mysql = "select [ws-ord-head].[worksheet-id], [ws-ord-head].[ws-create-date], "
            mysql = mysql & "[ws-ord-head].[cust-no], [ws-ord-head].[XmittedDate]"
            mysql = mysql & " from [ws-ord-head] "
            mysql = mysql & " where [ws-ord-head].[Xmitted] = true AND  [ws-ord-head].[Validation-Status] <> 'NO VAL' AND [ws-ord-head].[Validation-Status] <> 'ORDER'"
            mysql = mysql & " and [ws-ord-head].[Validation-Status] <> 'CANCEL'"
            mysql = mysql & " order by [ws-ord-head].[ws-create-date] desc"
        Else
            mysql = "select [ws-ord-head].[worksheet-id], [ws-ord-head].[ws-create-date], "
            mysql = mysql & "[ws-ord-head].[cust-no], [ws-ord-head].[XmittedDate]"
            mysql = mysql & " from [ws-ord-head] "
            mysql = mysql & " where [ws-ord-head].[Xmitted] = true AND  [ws-ord-head].[Validation-Status] <> 'NO VAL' AND [ws-ord-head].[Validation-Status] <> 'ORDER'"
            mysql = mysql & " order by [ws-ord-head].[ws-create-date] desc"
        End If

        con.Open()
        da = New OleDb.OleDbDataAdapter(mysql, con)
        da.Fill(dt)
        con.Close()

        dtgXmitButNotOnOrder.DataSource = dt

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        FormatXmitButNotOnOrderGrid()

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
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
    ''' This procedure will display customer information from the selected worksheet on the customer information screen 
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
	
	Private Sub cmdGetCustomer_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdGetCustomer.Click
        cCustNumber = dtgXmitButNotOnOrder.Item(2, dtgXmitButNotOnOrder.CurrentCell.RowIndex).Value
		If Trim(cCustNumber) <> "" Then
			fromLocation = "XmitNotOrder"
            Me.Hide()
            frmCustInfo.Show()
            Me.Show()
		End If
    End Sub

    ''' <summary>
    ''' This procedure will display the worksheet assosciated with the selection
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
	
	Private Sub cmdGetWS_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdGetWS.Click
        cCustWsNum = dtgXmitButNotOnOrder.Item(0, dtgXmitButNotOnOrder.CurrentCell.RowIndex).Value
		fromLocation = "XmitNotOrder"
		Me.Hide()
		frmWorksheet.ShowDialog()
	End Sub

    ''' <summary>
    ''' This procedure makes a call to load the data into the grid
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

	Private Sub frmXmitButNotOnOrder_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        getXmitNotOnOrder()
    End Sub

    ''' <summary>
    ''' This procedure formats the datagrid
    ''' </summary>
    ''' <remarks></remarks>
	
	Private Sub FormatXmitButNotOnOrderGrid()
        'Me.dtgXmitButNotOnOrder.Columns(0).Caption = "Worksheet"
        'Me.dtgXmitButNotOnOrder.Columns(1).Caption = "Date Created"
        'Me.dtgXmitButNotOnOrder.Columns(2).Caption = "Customer No."
        'Me.dtgXmitButNotOnOrder.Columns(3).Caption = "Date Transmitted"
		
        If dtgXmitButNotOnOrder.Columns.Count > 0 Then
            Me.dtgXmitButNotOnOrder.Columns(0).Width = VB6.TwipsToPixelsX(1245)
            Me.dtgXmitButNotOnOrder.Columns(1).Width = VB6.TwipsToPixelsX(1095)
            Me.dtgXmitButNotOnOrder.Columns(2).Width = VB6.TwipsToPixelsX(1170)
            Me.dtgXmitButNotOnOrder.Columns(3).Width = VB6.TwipsToPixelsX(1545)
        End If
    End Sub
End Class