Option Strict Off
Option Explicit On

Friend Class frmWSDefaults
    Inherits System.Windows.Forms.Form
    Dim frmLoaded As Boolean

    ''' <summary>
    ''' This procedure closes the form
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub btnOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' This procedure fires when the form closes; It updates the salesman table with any changes to worksheet defaults
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub frmWSDefaults_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.SlsmnBindingSource.EndEdit()
        Me.SalesmanTableAdapter.Update(Me.SaleForcDataSet.Salesman)
        Me.SaleForcDataSet.AcceptChanges()
    End Sub

    ''' <summary>
    ''' This procedure loads the defaults from the salesman table into the controls on the form
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>

    Private Sub frmWSDefaults_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Me.OrderTypeTableAdapter.FillByForLaptop(Me.SaleForcDataSet.OrderType)
        Me.SeasonTableAdapter.Fill(Me.SaleForcDataSet.Season)
        Me.SalesmanTableAdapter.Fill(Me.SaleForcDataSet.Salesman)
        Me.ShipViaCodeTableAdapter.Fill(Me.SaleForcDataSet.ShipViaCode)
        Me.SeasonBindingSource.Sort = "season"
        Me.OrderTypeBindingSource.Sort = "description"
        Me.ShipViaCodeBindingSource.Sort = "viadesc"
        chkShowAll.CheckState = System.Windows.Forms.CheckState.Unchecked
        getDefaults()
        frmLoaded = True
    End Sub

    ''' <summary>
    ''' This procedure loads the defaults from the salesman table into the controls on the form
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub getDefaults()
        Dim cn As New OleDb.OleDbConnection(MySettings.Default("SaleForcConnectionString"))
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As New DataTable

        cn.Open()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM [Salesman]", cn)
        da.Fill(dt)
        cn.Close()
        cn.Dispose()
        Me.cmbSeason.Text = IIf(IsDBNull(findSeasonDesc(dt.Rows(0)("season")).ToString), "", findSeasonDesc(dt.Rows(0)("season").ToString))
        Me.cmbShipVia.Text = IIf(IsDBNull(findShipViaDesc(dt.Rows(0)("viacode")).ToString), "", findShipViaDesc(dt.Rows(0)("viacode").ToString))
        Me.cmbOrderCode.Text = IIf(IsDBNull(findOrdTypeDesc(dt.Rows(0)("order-code")).ToString), "", findOrdTypeDesc(dt.Rows(0)("order-code").ToString))
        Me.dtpCancelBy.Value = dt.Rows(0)("cancel-date")
        Me.dtpDelvBy.Value = dt.Rows(0)("request-date")
        Me.txtTerms.Text = IIf(IsDBNull(dt.Rows(0)("termcode")), "", dt.Rows(0)("termcode").ToString)
    End Sub

    ''' <summary>
    ''' This procedure sets the Season Code description into the lblSeasonCd label control
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub cmbSeason_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSeason.SelectedIndexChanged
        If frmLoaded Then lblSeasonCd.Text = findSeasonCd((cmbSeason.Text))
    End Sub

    ''' <summary>
    ''' This procedure sets the Order Code description into the lblOrderCode label control
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub cmbOrderCode_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbOrderCode.SelectedIndexChanged
        If frmLoaded Then lblOrderCd.Text = findOrderTypeCd((cmbOrderCode.Text))
    End Sub

    ''' <summary>
    ''' This procedure sets the Ship Via Code description into the lblShipViaCd label control
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub cmbShipVia_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbShipVia.SelectedIndexChanged
        If frmLoaded Then lblShipViaCd.Text = findShipViaCd((cmbShipVia.Text))
    End Sub

    ''' <summary>
    ''' This procedure changes the filter for the order code combo box and sorts the order codes descriptions
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub chkShowAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowAll.CheckedChanged
        If chkShowAll.Checked = True Then
            Me.OrderTypeTableAdapter.Fill(Me.SaleForcDataSet.OrderType)
            Me.OrderTypeBindingSource.Sort = "Description ASC"
        Else
            Me.OrderTypeTableAdapter.FillByForLaptop(Me.SaleForcDataSet.OrderType)
        End If
    End Sub

    ''' <summary>
    ''' This procedure sets the Season, Order Code, and Ship Via label controls with the defaults
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub frmWSDefaults_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        lblSeasonCd.Text = findSeasonCd((cmbSeason.Text))
        lblOrderCd.Text = findOrderTypeCd((cmbOrderCode.Text))
        lblShipViaCd.Text = findShipViaCd((cmbShipVia.Text))
    End Sub
End Class