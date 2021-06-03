Option Strict Off
Option Explicit On
Module basPublicVars

    ' API.bas
    ' -------

    Public Const LWA_COLORKEY As Short = 1
    Public Const LWA_ALPHA As Short = 2
    Public Const LWA_BOTH As Short = 3
    Public Const WS_EX_LAYERED As Integer = &H80000
    Public Const GWL_EXSTYLE As Short = -20

    ' basCustInfo
    ' -----------

    Public cCustNo As String = Nothing
    Public cCustName As String = Nothing
    Public cCustAddr1 As String = Nothing
    Public cCustAddr2 As String = Nothing
    Public cCustAddr3 As String = Nothing
    Public cCustCity As String = Nothing
    Public cCustSt As String = Nothing
    Public cCustZip As String = Nothing
    Public cCustShipViaCd As String = Nothing
    Public cCustShipViaDesc As String = Nothing
    Public cCustCountry As String = Nothing
    Public cCustPhoneNo As String = Nothing
    Public cCustFaxNo As String = Nothing
    Public cCustContact As String = Nothing
    Public cCustStatusCd As String = Nothing
    Public cCustSlsmnCd As String = Nothing
    Public cCustTypeCd As String = Nothing
    Public cCustTermCd As String = Nothing
    Public cCustChargeCust As String = Nothing
    Public cCustCreditRating As String = Nothing
    Public cCustMailCust As String = Nothing
    Public cCustSortName As String = Nothing
    Public cCustStatsCust As String = Nothing
    Public cCustCustSh As String = Nothing
    Public cCustAddDate As String = Nothing
    Public cCustHoldArCode As String = Nothing
    Public lCustDelq As Boolean = Nothing
    Public cCustSlsmnRating As String = Nothing
    Public cCustLastChgDate As String = Nothing
    Public nCustArBalance As Double
    Public cCustLastPayDate As String = Nothing
    Public nCustLastPayAmt As Double
    Public nCustAvgDaysPay As Integer
    Public nCustOpenOrdTot As Double
    Public cCustLastOrdDate As String = Nothing
    Public cCustLabelNo As String = Nothing
    Public cCustLastUpdte As String = Nothing
    Public cCustEmail As String = Nothing
    Public cCustContactEmail As String = Nothing

    Public cShipNo As String = Nothing
    Public cShipName As String = Nothing
    Public cShipAddr1 As String = Nothing
    Public cShipAddr2 As String = Nothing
    Public cShipAddr3 As String = Nothing
    Public cShipCity As String = Nothing
    Public cShipSt As String = Nothing
    Public cShipZip As String = Nothing
    Public cShipShipViaCd As String = Nothing
    Public cShipShipViaDesc As String = Nothing
    Public cShipCountry As String = Nothing
    Public cShipPhoneNo As String = Nothing
    Public cShipContact As String = Nothing
    Public cShipStatusCd As String = Nothing
    Public cShipTypeCd As String = Nothing
    Public cShipTermCd As String = Nothing
    Public lShipComplete As Boolean
    Public lShipActive As Boolean
    Public cHoldShipCd As String = Nothing
    Public cShipFaxNo As String = Nothing
    Public cShipLastUpdate As String = Nothing
    Public cShipWebsite As String = Nothing
    Public cShipEmail As String = Nothing
    Public cShipContactEmail As String = Nothing
    Public filCommLog As String = GetProgramDefaults("CommLogPathAndFile")

    ' basExport
    ' ---------
    Public cExportFileExtension As String = GetProgramDefaults("FileUploadExtension")
    Public cExportPath As String = GetProgramDefaults("FileUploadPath")
    Public cTempFileName As String = GetProgramDefaults("ExportTempFile")
    Public cExportFile As String = Nothing
    Public cSalesmanCd As String = Nothing

    ' basImport
    ' ---------

    Public cImportFileExtension = GetProgramDefaults("FileDownloadExtension")
    Public cImportPath = GetProgramDefaults("FileDownloadPath")
    Public cImportFile As String = Nothing

    ' basGeneralProcedures
    ' --------------------

    '--------- Used for import/export screen ---------
    Public flagImport As Boolean
    '-------------------------------------------------
    Public Const tblAttrib As String = "Attrib"
    Public Const tblCommission As String = "Commission"
    Public Const tblCustomer As String = "Customer"
    Public Const tblCustomerSH As String = "CustomerSH"
    Public Const tblCustomerM As String = "CustomerMemo"
    Public Const tblItem As String = "Item"
    Public Const tblOrder As String = "[Order]"
    Public Const tblOrderLine As String = "[Order-Line]"
    Public Const tblOrderType As String = "OrderType"
    Public Const tblProdGroup As String = "ProdGroup"
    Public Const tblProdType As String = "ProdType"
    Public Const tblSalesman As String = "Salesman"
    Public Const tblSeason As String = "Season"
    Public Const tblSeasonType As String = "SeasonType"
    Public Const tblShipViaCd As String = "ShipViaCode"
    Public Const tblWsOrdHead As String = "[ws-ord-head]"
    Public Const tblWsOrdLine As String = "[ws-ord-line]"
    Public Const tblWsMemo As String = "WsMemo"
    Public Const tblWsErrorMsg As String = "WSErrorMsg"
    Public Const tblWsItemTemp As String = "WSItemTemp"
    Public Const tblProdGroupAttr As String = "[Product Group Attributes]"
    Public Const tblCustSeasProj As String = "[Cust-seas-proj]"
    Public Const tblCustStatus As String = "CustomerStatus"
    Public Const tblPurgeDefaults As String = "Purge Defaults"

    Public dbName As String = Nothing
    Public dbPath As String = Nothing
    
    ' Variables used in frmCommunications for xtract file array
    Public cFileArray() As String = Nothing
    Public nNumElem As Integer = Nothing

    Public cWorksheetID As String = Nothing 'Store worksheet ID to pass to other routines (frmImport, frmWorksheet)

    ' Variables for item validation and data lookup
    Public cItemDesc1, cItemDesc2 As String
    Public nPrice As Decimal

    ' New worksheet variables initialized from Salesman Table
    Public mytable As New ADODB.Recordset

    Public dDeliverDate As String = Nothing
    Public dCancelDate As String = Nothing
    Public cSalesSeason As String = Nothing
    Public cOrderCode As String = Nothing
    Public cViaCode As String = Nothing
    Public cTermCode As String = Nothing
    Public cWorkshtNum As String = Nothing
    Public nWorkSheetNum As Integer
    Public cNewWsNo As String = Nothing 'C - Computer generated M - Manually entered
    Public cSalesmanCode As String = Nothing
    Public cSalesmanName As String = Nothing
    Public cSalesmanEmail As String = Nothing

    ' ShipVia variables
    Public flagShipViaSelected As Boolean
    Public cShipViaCd As String = Nothing
    Public cShipViaDesc As String = Nothing

    '----- Season validation variables -------
    Public flagSeasonSelected As Boolean
    Public cSeasonCd As String = Nothing
    Public cSeasonDesc As String = Nothing

    '----- Order Type validation variables
    Public flagOrdTypeSelected As Boolean
    Public cOrdTypeCode As String
    Public cOrdTypeDesc As String

    '------ Public variables used in Worksheet edit
    Public flagItemChgsMade As Boolean
    Public lFlagNoEdit As Boolean ' Used for Worksheet editing
    Public lNewWorksheet As Boolean ' Equals True for new worksheet
    '-----------------------------------------------

    Public cToPrint As String ' Name of the selection criteria
    Public nListIndex As Short ' Indentifies index to sort report by
    Public intShowMaintErr As Short
    Public fromLocation As String ' Used during exit form to return to the calling form
    Public cCustOrdNum As String ' Used when going from customer to order
    Public cCustWsNum As String ' Used when going from customer to worksheet
    Public cCustNumber As String ' Customer number from customer file going to above
    Public cShipNumber As String ' Cust shipping number when going to a new worksheet
    Public cCustNameW As String ' customer name from customer file when going to worksheet
    Public cShipNameW As String ' shipping location name from customer file going to worksheet
    Public cWsShipViaCd As String ' Ship via code assigned from customer screen
    Public lCustToWs As Boolean ' Flag set when creating a new worksheet going from cust
    '------------------------------------------------
    Public lCanMaintain As Boolean ' Used in purging worksheet errors

    'Public ImportFiles As Boolean
    Public ConfirmPurge As Boolean 'Used to confirm that user wants to purge files
    Public CameFromInventoryForm As Boolean ' Used in frmCustItemRpt to determine if user double-clicked a item in frmInventory grid
    Public CurrInventoryItem As String ' Used in frmCustItemRpt to determine item to look up when coming from frmInventory grid
    Public CameFromWorksheetForm As Boolean ' Used in frmInventory to determine if user double-clicked an item in the frmWorksheet grid
    Public CurrWorksheetItem As String ' Used in frmInventory to determine item to look up when coming from frmWorksheet grid

    Public ViewActiveCustomers As Boolean
    Public AutoPurge As Boolean
    Public tmpListOrderRow As Short
    Public tmpOptDisplayIndex As Short
    Public tmpOrderCodeIndex As Short
    Public tmpSeasonCodeIndex As Short
    Public tmpOrderListRow As Short
    Public tmpOrderListRowPos As Short
    Public tmpOrderListSort As String
    Public tmpItineraryStart As Date
    Public tmpcancel_emailitinerary As Boolean
    '------------------------------------------------

End Module