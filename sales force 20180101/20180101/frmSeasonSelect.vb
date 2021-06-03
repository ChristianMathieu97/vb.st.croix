Option Strict Off
Option Explicit On
Friend Class frmSeasonSelect
	Inherits System.Windows.Forms.Form

    ''' <summary>
    ''' This procedure closes the form and resets global variables to nothing
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		cSeasonCd = ""
		cSeasonDesc = ""
		Me.Close()
    End Sub

    ''' <summary>
    ''' This procedure will populate global variables for use in worksheet entry
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
	
	Private Sub cmdSelect_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSelect.Click
        If Trim(lstSeason.Text) = "" Then Exit Sub
        cSeasonDesc = lstSeason.Text
        cSeasonCd = findSeasonCd((lstSeason.Text))
		flagSeasonSelected = True
		Me.Close()
    End Sub

    ''' <summary>
    ''' This procedure will fire when the form is displayed and will fill the list box with season code descriptions
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub frmSeasonSelect_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Me.SeasonTableAdapter.FillByForLaptop(Me.SaleForcDataSet.Season)
        flagSeasonSelected = False
    End Sub

    ''' <summary>
    ''' This procedure will get a season code based on the season code description
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub lstSeason_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstSeason.Click
        lblSeason.Text = findSeasonCd(lstSeason.Text)
    End Sub

    ''' <summary>
    ''' This procedures selects a season for use in worksheet entry
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub lstSeason_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstSeason.DoubleClick
        cmdSelect_Click(cmdSelect, New System.EventArgs())
    End Sub

    ''' <summary>
    ''' This procedures selects a season for use in worksheet entry using the keyboard
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub lstSeason_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstSeason.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            cmdSelect_Click(cmdSelect, New System.EventArgs())
        End If
    End Sub
End Class