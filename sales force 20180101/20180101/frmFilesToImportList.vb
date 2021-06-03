Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic

Friend Class frmFilesToImportList
    Inherits System.Windows.Forms.Form

    Dim driveletter As String
    Dim lImportOK As Boolean
    Dim x As Short

    ''' <summary>
    ''' This procedure builds a list of files that will be imported into the database
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub getImportList()
        Dim fil As String
        lstFilesToImport.Items.Clear()
        fil = Dir(cImportPath & "*" & cImportFileExtension)

        If IsDBNull(fil) Or Trim(fil) = "" Then
            lstFilesToImport.Items.Add("No files to Import")
        Else
            lstFilesToImport.Items.Add(fil & "  " & FileDateTime(cImportPath & fil))
            Do
                fil = Dir()
                If Trim(fil) <> "" Then
                    lstFilesToImport.Items.Add(fil & "  " & FileDateTime(cImportPath & fil))
                Else
                    Exit Do
                End If
            Loop
        End If
    End Sub


    ''' <summary>
    ''' This procedure imports files into data files into the database
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub ImportFiles()
        Dim fil As String

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        If chkForDnLoadDir() = False Then
            MsgBox("Couldn't find or make import directory: " & cImportPath)
        Else
            lblStart.Text = CStr(TimeOfDay)
            fil = Dir(cImportPath & "*" & cImportFileExtension)

            If IsDBNull(fil) Or Trim(fil) = "" Then
                MsgBox("No data file was found", , "ATTENTION")
                logFileAdd(2, "No data file to import")

            Else
                nNumElem = 1
                ReDim Preserve cFileArray(nNumElem)
                cFileArray(1) = fil
                Do
                    fil = Dir()
                    If Trim(fil) <> "" Then
                        nNumElem = CDbl(nNumElem) + 1
                        ReDim Preserve cFileArray(nNumElem)
                        cFileArray(nNumElem) = fil
                    Else
                        Exit Do
                    End If
                Loop

                BubbleSort(cFileArray)

                txtNoOfFiles.Text = CStr(nNumElem)
                
                For x = 1 To CInt(nNumElem)
                    lblFileName.Text = "Processing: " & cFileArray(x)
                    lblFileName.Refresh()
                    BackgroundWorker1.RunWorkerAsync(cFileArray(x))
                    Do While BackgroundWorker1.IsBusy = True
                        System.Windows.Forms.Application.DoEvents()
                    Loop
                Next x

                lblEnd.Text = CStr(TimeOfDay)
                logFileAdd(2, "Finished processing import files")
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End If
    End Sub

    ''' <summary>
    ''' This procedure checks to see if the path to the import folder exists 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Private Function chkForDnLoadDir() As Boolean
        chkForDnLoadDir = False
        If System.IO.Directory.Exists(cImportPath) Then
            chkForDnLoadDir = True
        Else
            MkDir(cImportPath)
            ChDir(cImportPath)
            chkForDnLoadDir = True
        End If
    End Function

    ''' <summary>
    ''' This procedure clears the text from controls before closing the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub frmFilesToImportList_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        lstFilesProcessed.Items.Clear()
        Me.lblEnd.ResetText()
        Me.lblStart.ResetText()
        Me.lblFileName.ResetText()
        Me.txtFilesProcessed.ResetText()
        Me.txtNoOfFiles.ResetText()
    End Sub

    ''' <summary>
    ''' This procedure will play a flash object, makes a call to import files and a call to purge the error message file
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub frmFilesToImportList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Show()
        flagImport = True
        getImportList()
        ImportFiles()
        lblFileName.Text = "Purging Wkst Error Messages"
        Me.Refresh()
        PurgeErrorMsgFile()
        Me.Close()
    End Sub

    ''' <summary>
    ''' This procedure runs a background worker to import the data files into the database.  A background worker runs a process on a 
    ''' separate thread so that other CPU intensive processes (such as playing the flash movie) running on the main thread are not 
    ''' slowed down. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub BackgroundWorker1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        e.Result = ImportData(e.Argument)
        lImportOK = e.Result
    End Sub

    ''' <summary>
    ''' This event fires when the background worker has completed it's task.  This procedure will write an entry to a log file indicating
    ''' the completion status of the file that was being imported.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Dim BadFileName, BadFil As String

        If lImportOK Then
            lstFilesProcessed.Items.Add(cFileArray(x))
            lstFilesProcessed.Refresh()
            logFileAdd(2, "Imported: " & cFileArray(x))
            txtFilesProcessed.Text = lstFilesProcessed.Items.Count
            txtFilesProcessed.Refresh()
            Kill(cImportPath & cFileArray(x))
        Else
            lstFilesProcessed.Items.Add(cFileArray(x) & " BAD")
            logFileAdd(2, "Bad file: " & cFileArray(x))
            BadFileName = VB.Left(cFileArray(x), Len(cFileArray(x)) - 3) & "BAD"
            BadFil = Dir(cImportPath & BadFileName)
            If Trim(BadFil) <> "" Then
                Kill(cImportPath & BadFileName)
            End If
            Rename(cImportPath & cFileArray(x), cImportPath & BadFileName)
            Call EmailBadFiles(BadFileName, cImportPath)
        End If
    End Sub
End Class