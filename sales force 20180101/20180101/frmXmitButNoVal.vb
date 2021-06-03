Option Strict Off
Option Explicit On
Friend Class frmXmitButNoVal
    Inherits System.Windows.Forms.Form

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
    ''' This procedure will display the customer information screen with data from the selected customer
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
	
	Private Sub cmdGetCustomer_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdGetCustomer.Click
        Dim i As Integer

        i = Me.dgvWSTransmittedNoReply.CurrentRow.Index
        cCustNumber = Me.dgvWSTransmittedNoReply.Item(2, i).Value
		If Trim(cCustNumber) <> "" Then
			fromLocation = "XmitNoVal"
            Me.Hide()
            frmCustInfo.ShowDialog()
            Me.Show()
		End If
    End Sub

    ''' <summary>
    ''' This procedure will display the worksheet screen with data from the selected worksheet
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
	
	Private Sub cmdGetWS_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdGetWS.Click
        Dim i As Integer

        i = Me.dgvWSTransmittedNoReply.CurrentRow.Index
        cCustWsNum = Me.dgvWSTransmittedNoReply.Item(0, i).Value
		fromLocation = "XmitNoVal"
		Me.Hide()
        frmWorksheet.ShowDialog()
        Me.Show()
    End Sub

    ''' <summary>
    ''' This procedure will load the datagrid with worksheet data where the worksheet has been transmitted to Knitcraft but has not been
    ''' validated on the Titan server and sent back to the sales rep
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
	
	Private Sub frmXmitButNoVal_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Me.Ws_ord_headTableAdapter.FillByTransmittedNoReply(Me.SaleForcDataSet._ws_ord_head)
    End Sub
End Class