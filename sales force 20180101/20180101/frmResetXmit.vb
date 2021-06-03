Option Strict Off
Option Explicit On
Imports System.Data
Imports System.Data.OleDb

Friend Class frmResetXmit
    Inherits System.Windows.Forms.Form

    Dim dataadapter As New OleDbDataAdapter
    Dim commandbuilder As OleDbCommandBuilder = New OleDbCommandBuilder(dataadapter)

    ''' <summary>
    ''' This procedure closes the form
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub btnExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' This procedure updates the ws-ord-head record in the database to make it appear as though it has never been transmitted to the
    ''' Knitcraft server.  This is useful when Titan system does not show that the worksheet was received.
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub btnResetXmit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnResetXmit.Click
        Dim response = MsgBox("Are you sure that you want to re-transmit " & Me.WsordheadBindingSource.Current("worksheet-id") & "?", MsgBoxStyle.YesNo, "Reset Worksheet Transmit Status")
        If response = MsgBoxResult.No Then Exit Sub
        Dim con As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim com As New OleDb.OleDbCommand("UPDATE [ws-ord-head] SET readytoxmit = True, xmitted = False, xmitteddate = null, xmittedtime = null WHERE [worksheet-id] = '" & WsordheadBindingSource.Current("worksheet-id") & "'", con)
        con.Open()
        com.ExecuteNonQuery()
        con.Close()
        logFileAdd(3, "Reset: " & Me.WsordheadBindingSource.Current("worksheet-id"))
        GetData(Ws_ord_headTableAdapter.Adapter.SelectCommand.CommandText)
    End Sub

    ''' <summary>
    ''' This procedure loads ws-ord-head data into the grid so that the worksheet can be retransmitted if selected to do so
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub frmResetXmit_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Me.Ws_ord_headTableAdapter.FillByXmitted(Me.SaleForcDataSet._ws_ord_head)
    End Sub

    ''' <summary>
    ''' This procedure updates the datagrid after changes have been made to the data.  If a user sets a worksheet for retransmit, it 
    ''' should not appear in the datagrid.  This procedure refreshes the data in the datagrid.
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
        Me.dataAdapter.Fill(table)
        Me.WsordheadBindingSource.DataSource = table

        ' Resize the DataGridView columns to fit the newly loaded content.
        Me.dgvResetWkst.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

    End Sub
End Class