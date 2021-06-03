Option Strict Off
Option Explicit On
Friend Class frmShipViaSelect
	Inherits System.Windows.Forms.Form

    ''' <summary>
    ''' This procedure populates global variables for use in worksheet entry
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

	Private Sub btnSelect_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnSelect.Click
        If Trim(lstShipVia.Text) = "" Then Exit Sub
        cShipViaDesc = lstShipVia.Text
        cShipViaCd = findShipViaCd((lstShipVia.Text))
		flagShipViaSelected = True
		Me.Close()
	End Sub

    ''' <summary>
    ''' This procedure closes the form and sets global variables to nothing
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		cShipViaDesc = ""
		cShipViaCd = ""
		Me.Close()
    End Sub

    ''' <summary>
    ''' This procedure fires when the form is displayed and loads the ship via codes into the list box
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub frmShipViaSelect_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Me.ShipViaCodeTableAdapter.FillBySortedByViaCode(Me.SaleForcDataSet.ShipViaCode)
        flagShipViaSelected = False
    End Sub

    ''' <summary>
    ''' This procedure will get a ship via code by sending the ship via description to 'findShipViaCode'
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub lstShipVia_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstShipVia.Click
        lblShipViaCd.Text = findShipViaCd((lstShipVia.Text))
    End Sub

    ''' <summary>
    ''' This procedure selects a ship via description when the user double-click a selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub lstShipVia_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstShipVia.DoubleClick
        btnSelect_Click(btnSelect, New System.EventArgs())
    End Sub

    ''' <summary>
    ''' This procedure selects a ship via description using the keyboard
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub lstShipVia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstShipVia.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            btnSelect_Click(btnSelect, New System.EventArgs())
        End If
    End Sub
End Class