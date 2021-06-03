' THIS FORM IS NO LONGER USED!
'-----------------------------
Option Strict Off
Option Explicit On
Friend Class frmWsSentViaProComm

    Inherits System.Windows.Forms.Form
    Dim fil As String
    Dim nFilBuf As Short
    Dim cLin As String
    Dim x As Integer
    Dim cDir As String
    Dim lLoaded As Boolean

    Private Sub cmdExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub getXmittedList()
        cDir = System.AppDomain.CurrentDomain.BaseDirectory & "\upload\done\"
        lstProCommXmit.Items.Clear()
        fil = cExportFileExtension

        If IsDBNull(fil) Or Trim(fil) = "" Then
            lstProCommXmit.Items.Add("No files found")

        Else
            lstProCommXmit.Items.Add(fil & "  " & FileDateTime(System.AppDomain.CurrentDomain.BaseDirectory & "\upload\done\" & fil))
            FindWorksheets()
            Do
                fil = Dir()
                If Trim(fil) <> "" Then
                    lstProCommXmit.Items.Add(fil & "  " & FileDateTime(System.AppDomain.CurrentDomain.BaseDirectory & "\upload\done\" & fil))
                    FindWorksheets()
                Else
                    Exit Do
                End If
            Loop
        End If
    End Sub

    Private Sub FindWorksheets()
        nFilBuf = FreeFile()
        FileOpen(nFilBuf, cDir & fil, OpenMode.Input)
        ' -- check to see if valid file
        cLin = LineInput(nFilBuf)
        If cLin <> "[FileHeader]" Then
            lstProCommXmit.Items.Add("   Not a valid file")
            FileClose(nFilBuf)
            Exit Sub
        End If
        ' -- Read past the header info --
        For x = 1 To 6
            cLin = LineInput(nFilBuf)
        Next x

        Do While Not EOF(nFilBuf)
            cLin = LineInput(nFilBuf)
            If Trim(cLin) = "" Then
                Exit Do
            End If
            lstProCommXmit.Items.Add("   " & cLin)
            For x = 1 To 26
                If Not EOF(nFilBuf) Then
                    cLin = LineInput(nFilBuf)
                Else
                    Exit Do
                End If
            Next x
        Loop

        FileClose(nFilBuf)
    End Sub

    Private Sub frmWsSentViaProComm_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        If lLoaded = False Then
            getXmittedList()
            lLoaded = True
        End If
    End Sub

    Private Sub frmWsSentViaProComm_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        lLoaded = False
    End Sub
End Class