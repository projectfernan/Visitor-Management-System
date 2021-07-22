Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Text
Module WEB_CAM_FUNCTION
    Public Const WM_CAP As Short = &H400S

    Public Const WM_CAP_DRIVER_CONNECT As Integer = WM_CAP + 10
    Public Const WM_CAP_DRIVER_DISCONNECT As Integer = WM_CAP + 11
    Public Const WM_CAP_EDIT_COPY As Integer = WM_CAP + 30

    Public Const WM_CAP_SET_PREVIEW As Integer = WM_CAP + 50
    Public Const WM_CAP_SET_PREVIEWRATE As Integer = WM_CAP + 52
    Public Const WM_CAP_SET_SCALE As Integer = WM_CAP + 53
    Public Const WS_CHILD As Integer = &H40000000
    Public Const WS_VISIBLE As Integer = &H10000000
    Public Const SWP_NOMOVE As Short = &H2S
    Public Const SWP_NOSIZE As Short = 1
    Public Const SWP_NOZORDER As Short = &H4S
    Public Const HWND_BOTTOM As Short = 1

    Public iDevice As Integer = 0 ' Current device ID
    Public hHwnd As Integer ' Handle to preview window

    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
        (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, _
        <MarshalAs(UnmanagedType.AsAny)> ByVal lParam As Object) As Integer

    Public Declare Function SetWindowPos Lib "user32" Alias "SetWindowPos" (ByVal hwnd As Integer, _
        ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, _
        ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer

    Public Declare Function DestroyWindow Lib "user32" (ByVal hndw As Integer) As Boolean

    Public Declare Function capCreateCaptureWindowA Lib "avicap32.dll" _
        (ByVal lpszWindowName As String, ByVal dwStyle As Integer, _
        ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, _
        ByVal nHeight As Short, ByVal hWndParent As Integer, _
        ByVal nID As Integer) As Integer

    Public Declare Function capGetDriverDescriptionA Lib "avicap32.dll" (ByVal wDriver As Short, _
        ByVal lpszName As String, ByVal cbName As Integer, ByVal lpszVer As String, _
        ByVal cbVer As Integer) As Boolean

    Public Sub closepreviewwindow()
        SendMessage(hHwnd, WM_CAP_DRIVER_DISCONNECT, iDevice, 0)
        DestroyWindow(hHwnd)

    End Sub

    Public Sub OpenPreviewWindow()
        Try
            Dim iHeight As Integer = frmMain.WebCam.Height
            Dim iWidth As Integer = frmMain.WebCam.Width

            '
            ' Open Preview window in picturebox
            '
            hHwnd = capCreateCaptureWindowA(iDevice, WS_VISIBLE Or WS_CHILD, 0, 0, iWidth, _
                iHeight, frmMain.WebCam.Handle.ToInt32, 0)

            '
            ' Connect to device
            '
            If SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0) Then
                '
                'Set the preview scale
                '
                SendMessage(hHwnd, WM_CAP_SET_SCALE, True, 0)

                '
                'Set the preview rate in milliseconds
                '
                SendMessage(hHwnd, WM_CAP_SET_PREVIEWRATE, 66, 0)

                '
                'Start previewing the image from the camera
                '
                SendMessage(hHwnd, WM_CAP_SET_PREVIEW, True, 0)

                '
                ' Resize window to fit in picturebox
                '
                SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, iWidth, iHeight, _
                        SWP_NOMOVE Or SWP_NOZORDER)


            Else
                '
                ' Error connecting to device close window
                ' 
                DestroyWindow(hHwnd)
                OpenPreviewWindow()

            End If
        Catch ex As Exception

        End Try

      
    End Sub

    Public Sub CaptureShot(ByVal PicBox As PictureBox, ByVal VisitorID As String)
        'Try
        Dim data As IDataObject
        Dim bmap As Image

        SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0)
        data = Clipboard.GetDataObject

        If data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
            bmap = CType(data.GetData(GetType(System.Drawing.Bitmap)), Image)
            'PicBox.Image = bmap
            'closepreviewwindow()

            bmap.Save(SavePic(VisitorID), Imaging.ImageFormat.Bmp)
            BMPPicPATH = vbNullString
            BMPPicPATH = SavePic(VisitorID)

            Try
                Dim wFile As System.IO.FileStream
                wFile = New FileStream(BMPPicPATH, FileMode.Open)
                Dim image As Image = image.FromStream(wFile)
                PicBox.Image = image
                PicBox.Visible = True
                wFile.Close()
            Catch ex As IOException
                MsgBox(ex.ToString, vbCritical)
            End Try

        End If
        'Catch ex As Exception
        'MsgBox(ex.Message, vbCritical, "Snop Shot")
        'End Try
    End Sub
End Module
