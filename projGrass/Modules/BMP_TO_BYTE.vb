Imports System.Threading
Imports System.IO
Imports System.IO.File
Imports System.Diagnostics



Module BMP_TO_BYTE

    Public signa_Path As String = Application.StartupPath & "\Signa.jpeg"

    Public Function BmpToByte(ByVal _bitmap As System.Drawing.Bitmap) As Byte()
        Dim _ms As New Global.System.IO.MemoryStream()
        _bitmap.Save(_ms, System.Drawing.Imaging.ImageFormat.Bmp)
        Dim _bmpArray As Byte()
        _bmpArray = _ms.ToArray()
        _ms.Flush()
        _ms.Dispose()
        Return _bmpArray
    End Function
End Module
