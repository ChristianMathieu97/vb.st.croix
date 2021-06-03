Option Strict Off
Option Explicit On
Friend Class frmOrdCodeSelect
    Inherits System.Windows.Forms.Form

    ''' <summary>
    ''' This procedure makes a call to reload the list of order codes and will show all
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub chkShowAll_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkShowAll.CheckStateChanged
        LoadListOT()
    End Sub

    ''' <summary>
    ''' This procedure sets global variables to nothing if the user cancels the form
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
        cOrdTypeDesc = ""
        cOrdTypeCode = ""
        Me.Close()
    End Sub

    ''' <summary>
    ''' This procedure sets global variables for use in worksheet entry
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub cmdSelect_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSelect.Click
        cOrdTypeDesc = lvwOrdCode.FocusedItem.Text
        cOrdTypeCode = lvwOrdCode.FocusedItem.SubItems(1).Text
        flagOrdTypeSelected = True
        Me.Close()
    End Sub

    ''' <summary>
    ''' This procedure set the focus to the list view box when the form is displayed
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub frmOrdCodeSelect_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        lvwOrdCode.Focus()
    End Sub

    ''' <summary>
    ''' This procedure will set up the columns for the list view box that holds the order codes
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub frmOrdCodeSelect_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SaleForcDataSet.OrderType' table. You can move, or remove it, as needed.
        Me.OrderTypeTableAdapter.Fill(Me.SaleForcDataSet.OrderType)
        lvwOrdCode.Items.Clear()
        lvwOrdCode.Columns.Clear()
        lvwOrdCode.Columns.Add("", "Description", 90)
        lvwOrdCode.Columns.Add("", "Code", 40)

        flagOrdTypeSelected = False
        chkShowAll.CheckState = System.Windows.Forms.CheckState.Unchecked
        LoadListOT()
    End Sub

    ''' <summary>
    ''' This procedure will load the list view box with order codes 
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub LoadListOT()
        Dim con As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        Dim sql As String
        Dim itmX As System.Windows.Forms.ListViewItem
        Dim i As Integer

        con.ConnectionString = MySettings.Default("SaleForcConnectionString")
        con.Open()

        If chkShowAll.CheckState = System.Windows.Forms.CheckState.Checked Then
            sql = "SELECT * FROM [OrderType] ORDER BY [OrderType].[Description]"
        Else
            sql = "SELECT * FROM [OrderType]"
            sql = sql & " WHERE [OrderType].[ForLaptop] = True"
            sql = sql & " ORDER BY [OrderType].[EndShipDate] DESC, [OrderType].[OrderCode]"
        End If

        da = New OleDb.OleDbDataAdapter(Sql, con)
        da.Fill(dt)

        lvwOrdCode.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            itmX = lvwOrdCode.Items.Add(Trim(dt.Rows(i)("Description")))
            'UPGRADE_WARNING: Lower bound of collection itmX has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            If itmX.SubItems.Count > 1 Then
                itmX.SubItems(1).Text = dt.Rows(i)("OrderCode").ToString
            Else
                itmX.SubItems.Insert(1, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, dt.Rows(i)("OrderCode")))
            End If
        Next
        con.Close()
    End Sub

    ''' <summary>
    ''' This procedure will select an order code
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub ListView1_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lvwOrdCode.DoubleClick
        cmdSelect_Click(cmdSelect, New System.EventArgs())
    End Sub

    ''' <summary>
    ''' This procedures allows the users to select an order code by using the keyboard
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub ListView1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles lvwOrdCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            cmdSelect_Click(cmdSelect, New System.EventArgs())
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    ''' <summary>
    ''' This procedure will sort the order codes
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub ListView1_ColumnClick(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ColumnClickEventArgs)
        Dim ColumnHeader As System.Windows.Forms.ColumnHeader = lvwOrdCode.Columns(eventArgs.Column)
        ' When a ColumnHeader object is clicked, the ListView control is
        ' sorted by the subitems of that column.
        ' Set the SortKey to the Index of the ColumnHeader - 1
        lvwOrdCode.ListViewItemSorter = New ListViewComparer(ColumnHeader.Index - 1)
        ' Set Sorted to True to sort the list.
        lvwOrdCode.Sort()
        If lvwOrdCode.Sorting = System.Windows.Forms.SortOrder.Ascending Then
            lvwOrdCode.Sorting = System.Windows.Forms.SortOrder.Descending
        Else
            lvwOrdCode.Sorting = System.Windows.Forms.SortOrder.Ascending
        End If
    End Sub

End Class

''' <summary>
''' This class is used in sorting the list view box of order codes
''' </summary>
''' <remarks></remarks>

Class ListViewComparer
    Implements IComparer
    Private col As Integer
    Public Sub New(ByVal column As Integer)
        col = column
    End Sub
    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
        Dim returnVal As Integer = -1
        returnVal = [String].Compare(CType(x, ListViewItem).SubItems(col).Text, CType(y, ListViewItem).SubItems(col).Text)
        Return returnVal
    End Function
End Class