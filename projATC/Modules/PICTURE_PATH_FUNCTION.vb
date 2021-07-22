Imports System.Threading
Imports System.IO
Imports System.IO.File
Imports System.Diagnostics
Imports ADODB
Module PICTURE_PATH_FUNCTION
    Public CaptureFolderPath As String = Application.StartupPath & "\FolderPIC"

    Public BMPPicPATH As String
    Public JPEGPicPath As String

    Public Function SavePic(ByVal VisitorID As String) As String
        Try
            If Not Directory.Exists(CaptureFolderPath) Then
                Directory.CreateDirectory(CaptureFolderPath)
            End If

            If Directory.Exists(CaptureFolderPath) Then
                Return CaptureFolderPath & "\" & (VisitorID) & ".bmp"
            End If
            Return vbNullString
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            Return vbNullString
        End Try
    End Function

    Public Sub Delete_Image()
        If Directory.Exists(Application.StartupPath & "\FolderPIC") = True Then
            Directory.Delete(Application.StartupPath & "\FolderPIC", True)
        End If
    End Sub

    Public Sub Delete_Signa()
        If File.Exists(Application.StartupPath & "\Signa.JPEG") = True Then
            File.Delete(Application.StartupPath & "\Signa.JPEG")
        End If
    End Sub

    Public Sub Delete_idPIC()
        If File.Exists(ImagePAth) = True Then
            File.Delete(ImagePAth)
        End If
    End Sub


End Module
