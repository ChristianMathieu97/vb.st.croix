Option Strict Off
Option Explicit On
Friend Class frmSetItineraryDate
    Inherits System.Windows.Forms.Form

    ''' <summary>
    ''' This procedure closes the form and sets a global variable to identity that the user clicked the cancel button on this form
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
	
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		tmpcancel_emailitinerary = True
		Me.Close()
    End Sub

    ''' <summary>
    ''' This procedure sets a global variable to identify the start date of the itinerary being emailed
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
	
	Private Sub cmdContinue_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdContinue.Click
		tmpcancel_emailitinerary = False
        tmpItineraryStart = DTPicker1.Value
		If IsDbNull(tmpItineraryStart) Then
			tmpItineraryStart = Today
		End If
		Me.Close()
    End Sub

    ''' <summary>
    ''' This procedure defaults the calendar (dtpicker) to today
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
	
	Private Sub frmSetItineraryDate_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		DTPicker1.Value = Today
	End Sub
End Class