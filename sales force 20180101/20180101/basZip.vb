Imports System
Imports System.IO
Imports System.IO.Compression
Imports System.IO.Compression.GZipStream

Module basZip

    ''' <summary>
    ''' This procedure will decompress all zip'd files in the import folder and then delete the compressed file
    ''' </summary>
    ''' <remarks></remarks>

    Public Sub UncompressDeleteKCFiles()
        ' Path to directory of files to compress.

        Dim di As DirectoryInfo = New DirectoryInfo(cImportPath)
        ' Decompress all *.gz files in the directory.
        For Each fi As FileInfo In di.GetFiles("*.gz")
            Decompress(fi)
            Kill(fi.DirectoryName & "\" & fi.Name)
        Next
    End Sub

    ' Method to compress.
    'Private Sub Compress(ByVal fi As FileInfo)
    '    ' Get the stream of the source file.
    '    Using inFile As FileStream = fi.OpenRead()
    '        ' Compressing:
    '        ' Prevent compressing hidden and already compressed files.

    '        If (File.GetAttributes(fi.FullName) And FileAttributes.Hidden) _
    '            <> FileAttributes.Hidden And fi.Extension <> ".gz" Then
    '            ' Create the compressed file.
    '            Using outFile As FileStream = File.Create(fi.FullName + ".gz")
    '                Using Compress As GZipStream = _
    '                 New GZipStream(outFile, CompressionMode.Compress)

    '                    ' Copy the source file into the compression stream.
    '                    inFile.CopyTo(Compress)

    '                    Console.WriteLine("Compressed {0} from {1} to {2} bytes.", _
    '                                      fi.Name, fi.Length.ToString(), outFile.Length.ToString())

    '                End Using
    '            End Using
    '        End If
    '    End Using
    'End Sub


    ' Method to decompress.
    'Public Sub Decompress(ByVal fi As FileInfo)
    '    ' Get the stream of the source file.
    '    Using inFile As FileStream = fi.OpenRead()
    '        ' Get orignial file extension, for example "doc" from report.doc.gz.
    '        Dim curFile As String = fi.FullName
    '        Dim origName = curFile.Remove(curFile.Length - fi.Extension.Length)

    '        ' Create the decompressed file.
    '        Using outFile As FileStream = File.Create(origName)
    '            Using Decompress As GZipStream = New GZipStream(inFile, CompressionMode.Decompress)

    '                ' Copy the decompression stream 
    '                ' into the output file.
    '                Decompress.CopyTo(outFile)

    '                Console.WriteLine("Decompressed: {0}", fi.Name)

    '            End Using
    '        End Using
    '    End Using
    'End Sub

    ''' <summary>
    ''' This procedure compresses a file into a .gz (GZip) file format
    ''' </summary>
    ''' <param name="fi"></param>
    ''' <remarks></remarks>

    Public Sub Compress(ByVal fi As FileInfo)
        ' Get the stream of the source file.
        Using inFile As FileStream = fi.OpenRead()
            ' Compressing:
            ' Prevent compressing hidden and already compressed files.

            If (File.GetAttributes(fi.FullName) And FileAttributes.Hidden) _
                <> FileAttributes.Hidden And fi.Extension <> ".gz" Then
                ' Create the compressed file.
                Using outFile As FileStream = File.Create(fi.FullName + ".gz")
                    Using Compress As GZipStream = New GZipStream(outFile, CompressionMode.Compress)
                        ' Copy the source file into the compression stream.
                        Dim buffer As Byte() = New Byte(4096) {}
                        Dim numRead As Integer
                        numRead = inFile.Read(buffer, 0, buffer.Length)
                        Do While numRead <> 0
                            Compress.Write(buffer, 0, numRead)
                            numRead = inFile.Read(buffer, 0, buffer.Length)
                        Loop

                        Console.WriteLine("Compressed {0} from {1} to {2} bytes.", _
                                          fi.Name, fi.Length.ToString(), outFile.Length.ToString())

                    End Using
                End Using
            End If
        End Using
    End Sub

    ''' <summary>
    ''' This procedure decompresses a file that is in the .gz file format
    ''' </summary>
    ''' <param name="fi">The name of the file to decompress</param>
    ''' <remarks></remarks>

    Public Sub Decompress(ByVal fi As FileInfo)
        ' Get the stream of the source file.
        Using inFile As FileStream = fi.OpenRead()
            ' Get orignial file extension, for example "doc" from report.doc.gz.
            Dim curFile As String = fi.FullName
            Dim origName = curFile.Remove(curFile.Length - fi.Extension.Length)

            ' Create the decompressed file.
            Using outFile As FileStream = File.Create(origName)
                Using Decompress As GZipStream = New GZipStream(inFile, CompressionMode.Decompress)
                    ' Copy the compressed file into the decompression stream.
                    Dim buffer As Byte() = New Byte(4096) {}
                    Dim numRead As Integer
                    numRead = Decompress.Read(buffer, 0, buffer.Length)
                    Do While numRead <> 0
                        outFile.Write(buffer, 0, numRead)
                        numRead = Decompress.Read(buffer, 0, buffer.Length)
                    Loop
                    Console.WriteLine("Decompressed: {0}", fi.Name)

                End Using
            End Using
        End Using
    End Sub


End Module
