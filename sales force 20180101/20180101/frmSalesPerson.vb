Option Strict Off
Option Explicit On
Friend Class frmSalesPerson
    Inherits System.Windows.Forms.Form

    ''' <summary>
    ''' This procedure displays the 'Change Worksheet Defaults' form and loads Season,OrderCode,and ShipVia text boxes with the defaults
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
	
	Private Sub cmdChgWSDefaults_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdChgWSDefaults.Click
        frmWSDefaults.ShowDialog()
        getDescriptions()
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
    ''' This procedure makes a call to load Season,OrderCode,and ShipVia text boxes with the defaults
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub frmSalesPerson_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        getDescriptions()
    End Sub

    ''' <summary>
    ''' This procedure loads Season,OrderCode,and ShipVia text boxes with the defaults
    ''' </summary>
    ''' <remarks></remarks>
	
	Private Sub getDescriptions()
		lblSeasonDesc.Text = findSeasonDesc(lblSeason.Text)
		lblOrdCdDesc.Text = findOrdTypeDesc(lblOrderCode.Text)
        lblShipViaDesc.Text = findShipViaDesc(lblShipVia.Text)
        Me.SalesmanTableAdapter.Fill(SaleForcDataSet.Salesman)
        Me.bndSalesman.ResetItem(0)
    End Sub

    ''' <summary>
    ''' This procedure loads the data for the controls on the form with the data from the Salesman table
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub frmSalesPerson_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SalesmanTableAdapter.Fill(SaleForcDataSet.Salesman)
    End Sub
End Class