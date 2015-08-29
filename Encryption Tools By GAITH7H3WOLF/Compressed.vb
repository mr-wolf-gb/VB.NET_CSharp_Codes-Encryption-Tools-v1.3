Imports System.IO.Compression
Imports System.IO
Public Class Compression

    Public Shared Function Compress(ByVal bytData() As Byte) As Byte()
        Using oMS As New MemoryStream()
            'GZip object that compress the file 
            Using oGZipStream As New GZipStream(oMS, CompressionMode.Compress)
                'Write to the Stream object from the buffer
                oGZipStream.Write(bytData, 0, bytData.Length)
                oGZipStream.Close()
                ReDim bytData(oMS.ToArray.Length - 1)
                bytData = oMS.ToArray
            End Using
            oMS.Close()
        End Using
        Return bytData
    End Function

    Public Shared Function Decompress(ByVal bytData() As Byte) As Byte()
        Using oMS As New MemoryStream(bytData)
            Using oGZipStream As New GZipStream(oMS, CompressionMode.Decompress)
                Const CHUNK As Integer = 1024
                Dim intTotalBytesRead As Integer = 0
                Do
                    ' Enlarge the buffer.
                    ReDim Preserve bytData(intTotalBytesRead + CHUNK - 1)
                    ' Read the next chunk.
                    Dim intBytesRead As Integer = oGZipStream.Read(bytData, intTotalBytesRead, CHUNK)
                    intTotalBytesRead += intBytesRead
                    ' See if we're done.
                    If intBytesRead < CHUNK Then
                        ' We're done. Make the buffer fit the data.
                        ReDim Preserve bytData(intTotalBytesRead - 1)
                        Exit Do
                    End If
                Loop
                oGZipStream.Close()
            End Using
            oMS.Close()
        End Using
        Return bytData
    End Function

End Class