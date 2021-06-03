Option Strict Off
Option Explicit On
Friend Class frmOrders
	Inherits System.Windows.Forms.Form
    Dim flagFindStatus As Boolean

    ''' <summary>
    ''' This procedure will attempt to find an order using the value in 'cOrd'
    ''' </summary>
    ''' <param name="cOrd"></param>
    ''' <returns>A boolean indicating that it found the order (true) or did not find the order (false)</returns>
    ''' <remarks></remarks>
	
    Private Function FindOrder(ByRef cOrd As Long) As Boolean
        Dim fldname As String


        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        bndOrder.Find("order-no", cOrd)

        If bndOrder.Count = 0 Then
            FindOrder = False
        Else
            FindOrder = True

            fldname = Str(bndOrder.Current("order-no"))
            bndOrderLine.Filter = "[order-no] = '" & fldname & "'"
        End If

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Function

    ''' <summary>
    ''' This procedure closes the form and sets the 'fromLocation' variable to nothing.  The 'fromLocation' variable is used to go back to 
    ''' the form that was displayed prior to coming to this form
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub btnExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnExit.Click
        If fromLocation = "Cust" Then
            fromLocation = ""
            Me.Close()
        ElseIf fromLocation = "OrdList" Then
            fromLocation = ""
            Me.Close()
        ElseIf fromLocation = "WsList" Then
            fromLocation = ""
            Me.Close()
            frmListWs.Show()
        Else
            Me.Close()
        End If
    End Sub

    ''' <summary>
    ''' This procedure will find an order if 'fromLocation' field is populated
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub frmOrders_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        If fromLocation = "Cust" Or fromLocation = "OrdList" Or fromLocation = "WsList" Then
            txtOrder.Text = cCustOrdNum
            FindOrder(cCustOrdNum)
        End If
    End Sub

    ''' <summary>
    ''' This procedure fills the datagrid with order records
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
	
	Private Sub frmOrders_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Me.OrderTableAdapter.FillByOrderNo(Me.SaleForcDataSet.Order, cCustOrdNum)
        Me.Order_lineTableAdapter.FillByOrderNo(Me.SaleForcDataSet._Order_line, cCustOrdNum)
        flagFindStatus = True
	End Sub
End Class