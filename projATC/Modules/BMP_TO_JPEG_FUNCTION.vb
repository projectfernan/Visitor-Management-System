Imports System.IO.Path
Imports System.Drawing.Imaging
Module BMP_TO_JPEG_FUNCTION
    Public Function ConvertBMP_TO_JPEG(ByVal BMPFullPath As String, ByVal imgFormat As ImageFormat) As Boolean

        Dim sNewFile As String


        Try
            'bitmap class in system.drawing.imaging
            Dim objBmp As New Bitmap(BMPFullPath)

            'below 2 functions in system.io.path
            sNewFile = GetDirectoryName(BMPFullPath)
            sNewFile &= "\" & GetFileNameWithoutExtension(BMPFullPath)

            sNewFile &= "." & imgFormat.ToString
            objBmp.Save(sNewFile, imgFormat)

            'SAVE JPEG PATH
            JPEGPicPath = vbNullString
            JPEGPicPath = sNewFile



            Return True 'return true on success
        Catch
            Return False 'return false on error
        End Try

    End Function

    'USAGE
    'ConvertBMP("C:\test.bmp", ImageFormat.Jpeg)
    'ConvertBMP("C:\test.bmp", ImageFormat.Emf)
    'ConvertBMP("C:\test.bmp", ImageFormat.Exif)
    'ConvertBMP("C:\test.bmp", ImageFormat.Gif)
    'ConvertBMP("C:\test.bmp", ImageFormat.Icon)
    'ConvertBMP("C:\test.bmp", ImageFormat.MemoryBmp)
    'ConvertBMP("C:\test.bmp", ImageFormat.Png)
    'ConvertBMP("C:\test.bmp", ImageFormat.Tiff)
    'ConvertBMP("C:\test.bmp", ImageFormat.Wmf)
End Module
