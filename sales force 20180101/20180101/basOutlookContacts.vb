Option Strict Off
Option Explicit On
Imports System.Diagnostics
Imports System.Runtime.InteropServices
Module basOutlookContacts

    'This procedure is no longer used but it will create Microsoft Office Outlook customer contacts from the Customer table in the database

    'Public Sub CreateOutlookCustomerContacts(ByVal tmpCustId As String)
    '    Try
    '        Dim OutlookApp As Microsoft.Office.Interop.Outlook.Application
    '        Dim OutlookNameSpace As Microsoft.Office.Interop.Outlook.NameSpace
    '        Dim bolCustomerFolder As Boolean
    '        Dim objFolder As Microsoft.Office.Interop.Outlook.MAPIFolder
    '        Dim colFolders As Microsoft.Office.Interop.Outlook.Folders
    '        Dim contact As Microsoft.Office.Interop.Outlook.ContactItem
    '        Dim folder As Microsoft.Office.Interop.Outlook.MAPIFolder
    '        Dim mytable As New ADODB.Recordset
    '        Dim conn As ADODB.Connection

    '        OutlookApp = New Microsoft.Office.Interop.Outlook.Application
    '        OutlookNameSpace = OutlookApp.GetNamespace("MAPI")

    '        ' get contact folders

    '        objFolder = OutlookNameSpace.GetDefaultFolder(Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderContacts)
    '        colFolders = objFolder.Folders

    '        ' check if contacts folder "Customers" has been created

    '        If colFolders.Count > 0 Then
    '            bolCustomerFolder = False
    '            For Each folder In colFolders
    '                If folder.Name = "Customers" Then
    '                    bolCustomerFolder = True
    '                End If
    '            Next folder
    '        End If

    '        ' create "Customers" folder if it doesn't exist

    '        If Not bolCustomerFolder Then
    '            objFolder.Folders.Add("Customers")
    '        End If

    '        ' make "Customers" the current folder

    '        objFolder = colFolders("Customers")
    '        objFolder.ShowAsOutlookAB = True
    '        objFolder.AddressBookName = "Customers"

    '        'Search for 'tmpcustid' customer in the "Customers" contact folder

    '        Dim contacts As Microsoft.Office.Interop.Outlook.Items = objFolder.Items
    '        contact = contacts.Find("[CustomerID] = '" & tmpCustId & "'")

    '        If contact Is Nothing Then
    '            contact = objFolder.Items.Add(Microsoft.Office.Interop.Outlook.OlItemType.olContactItem)
    '        End If

    '        conn = CreateObject("ADODB.Connection")
    '        conn.Provider = "Microsoft.Jet.OLEDB.4.0"
    '        conn.Open(dbName)

    '        'Find the customer in the database "Customer" table (should always be there because we just found/created it in the import)

    '        bolCustomersImported = True
    '        mytable.CursorLocation = ADODB.CursorLocationEnum.adUseServer
    '        mytable.Open(tblCustomer, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly, ADODB.CommandTypeEnum.adCmdTableDirect)
    '        mytable.Index = "CustNumber"
    '        mytable.Seek(tmpCustId, ADODB.SeekEnum.adSeekFirstEQ)

    '        'contact = objFolder.Items.Add(Microsoft.Office.Interop.Outlook.OlItemType.olContactItem)

    '        'With contact
    '       
    '        'End With


    '        ' Setup Contact information...
    '        With contact
    '            .CompanyName = IIf(IsDBNull(mytable.Fields("name").Value), "", mytable.Fields("name").Value)
    '            .FullName = IIf(IsDBNull(mytable.Fields("contact").Value), "", mytable.Fields("contact").Value)
    '            .FileAs = IIf(IsDBNull(mytable.Fields("name").Value), "", mytable.Fields("name").Value)
    '            .BusinessAddressStreet = IIf(IsDBNull(mytable.Fields("address2").Value), "", mytable.Fields("address2").Value)
    '            .BusinessAddressCity = IIf(IsDBNull(mytable.Fields("city").Value), "", mytable.Fields("city").Value)
    '            .BusinessAddressState = IIf(IsDBNull(mytable.Fields("st").Value), "", mytable.Fields("st").Value)
    '            .BusinessAddressPostalCode = IIf(IsDBNull(mytable.Fields("zip-code").Value), "", mytable.Fields("st").Value)
    '            .BusinessTelephoneNumber = IIf(IsDBNull(mytable.Fields("telephone").Value), "", mytable.Fields("telephone").Value)
    '            .BusinessFaxNumber = IIf(IsDBNull(mytable.Fields("fax-num").Value), "", mytable.Fields("fax-num").Value)
    '            .Email1DisplayName = IIf(IsDBNull(mytable.Fields("contact").Value), "", mytable.Fields("contact").Value)
    '            .Email1Address = IIf(IsDBNull(mytable.Fields("email").Value), "", mytable.Fields("email").Value)
    '            .Email1AddressType = "SMTP"
    '            .CustomerID = IIf(IsDBNull(mytable.Fields("cust-no").Value), "", mytable.Fields("cust-no").Value)
    '            .Save()
    '        End With
    '        mytable.Close()

    '        OutlookNameSpace.Logoff()
    '        'OutlookApp.Quit()
    '        conn.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    ''' <summary>
    ''' This procedure compares the customer numbers in the customer table with the customer number in the Microsoft Office Outlook 
    ''' 'Customers' folder and deletes any customer contact item that doesn't exist in the customer table in the database
    ''' </summary>
    ''' <remarks></remarks>

    Public Sub PurgeOutlookCustomerContacts()
        Dim OutlookApp As Microsoft.Office.Interop.Outlook.Application
        Dim OutlookNameSpace As Microsoft.Office.Interop.Outlook.NameSpace
        Dim bolCustomerFolder As Boolean
        Dim objFolder As Microsoft.Office.Interop.Outlook.MAPIFolder
        Dim colFolders As Microsoft.Office.Interop.Outlook.Folders
        Dim contact As Microsoft.Office.Interop.Outlook.ContactItem
        Dim folder As Microsoft.Office.Interop.Outlook.MAPIFolder
        Dim mytable As New ADODB.Recordset
        Dim conn As ADODB.Connection

        OutlookApp = New Microsoft.Office.Interop.Outlook.Application
        OutlookNameSpace = OutlookApp.GetNamespace("MAPI")

        ' get contact folders

        objFolder = OutlookNameSpace.GetDefaultFolder(Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderContacts)
        colFolders = objFolder.Folders

        ' If "Customers" folder does not exist then leave sub, because there is nothing to purge

        If colFolders.Count > 0 Then
            bolCustomerFolder = False
            For Each folder In colFolders
                If folder.Name = "Customers" Then
                    bolCustomerFolder = True
                End If
            Next folder
        End If

        If bolCustomerFolder = False Then Exit Sub

        ' If found the "Customers" folder then set it to be current folder

        objFolder = colFolders("Customers")

        ' Go through the folder and search the customers table in the database to make sure customer is still valid.  If customer is not valid, delete the Outlook contact item

        conn = CreateObject("ADODB.Connection")
        conn.Provider = "Microsoft.Jet.OLEDB.4.0"
        conn.Open(dbName)
        mytable.CursorLocation = ADODB.CursorLocationEnum.adUseServer
        mytable.Open(tblCustomer, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly, ADODB.CommandTypeEnum.adCmdTableDirect)
        mytable.Index = "CustNumber"

        For Each contact In objFolder.Items
            'contact = objFolder.Items(i)
            mytable.Seek(contact.CustomerID, ADODB.SeekEnum.adSeekFirstEQ)
            If mytable.EOF = True Then
                contact.Delete()
            End If
        Next

        OutlookNameSpace.Logoff()
        mytable = Nothing
        conn.Close()
    End Sub

End Module