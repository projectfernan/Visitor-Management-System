Imports ADODB
Module PIC_FROM_DB
    Public Function Visitor_Pic(ByRef Acnumber As String) As Bitmap
        Try
            Dim rs As New Recordset
            rs = Conn.Execute("select * from tblVisitorOut where VisitorID = '" & Acnumber & "'")
            If rs.EOF = False Then
                Dim imgByteArray() As Byte
                Try
                    imgByteArray = CType(rs("Capture").Value, Byte())
                    Dim stream As New System.IO.MemoryStream(imgByteArray)
                    Dim bmp As New Bitmap(stream)
                    stream.Close()
                    Return bmp
                Catch ex As Exception
                    'MessageBox.Show(ex.Message)
                    'frmMain.EntCap.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                    Return Nothing
                End Try
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function Visitor_ID_Pic(ByRef Acnumber As String) As Bitmap
        Try
            Dim rs As New Recordset
            rs = Conn.Execute("select * from tblVisitorOut where VisitorID = '" & Acnumber & "'")
            If rs.EOF = False Then
                Dim imgByteArray() As Byte
                Try
                    imgByteArray = CType(rs("ScanID").Value, Byte())
                    Dim stream As New System.IO.MemoryStream(imgByteArray)
                    Dim bmp As New Bitmap(stream)
                    stream.Close()
                    Return bmp
                Catch ex As Exception
                    'MessageBox.Show(ex.Message)
                    'frmMain.EntCap.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                    Return Nothing
                End Try
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function Visitor_ID_OutSigna(ByRef Acnumber As String) As Bitmap
        Try
            Dim rs As New Recordset
            rs = Conn.Execute("select * from tblVisitorOut where VisitorID = '" & Acnumber & "'")
            If rs.EOF = False Then
                Dim imgByteArray() As Byte
                Try
                    imgByteArray = CType(rs("Signature").Value, Byte())
                    Dim stream As New System.IO.MemoryStream(imgByteArray)
                    Dim bmp As New Bitmap(stream)
                    stream.Close()
                    Return bmp
                Catch ex As Exception
                    'MessageBox.Show(ex.Message)
                    'frmMain.EntCap.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                    Return Nothing
                End Try
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function


    Public Function Visitor_PicIn(ByRef Acnumber As String) As Bitmap
        Try
            Dim rs As New Recordset
            rs = Conn.Execute("select * from tblVisitorIn where ID = '" & Acnumber & "'")
            If rs.EOF = False Then
                Dim imgByteArray() As Byte
                Try
                    imgByteArray = CType(rs("Capture").Value, Byte())
                    Dim stream As New System.IO.MemoryStream(imgByteArray)
                    Dim bmp As New Bitmap(stream)
                    stream.Close()
                    Return bmp
                Catch ex As Exception
                    'MessageBox.Show(ex.Message)
                    'frmMain.EntCap.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                    Return Nothing
                End Try
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function Visitor_PicInExt(ByRef Acnumber As String) As Bitmap
        Try
            Dim rs As New Recordset
            rs = Conn.Execute("select * from tblVisitorIn where Barcode = '" & Acnumber & "'")
            If rs.EOF = False Then
                Dim imgByteArray() As Byte
                Try
                    imgByteArray = CType(rs("Capture").Value, Byte())
                    Dim stream As New System.IO.MemoryStream(imgByteArray)
                    Dim bmp As New Bitmap(stream)
                    stream.Close()
                    Return bmp
                Catch ex As Exception
                    'MessageBox.Show(ex.Message)
                    'frmMain.EntCap.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                    Return Nothing
                End Try
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function Visitor_PicIn_ID(ByRef Acnumber As String) As Bitmap
        Try
            Dim rs As New Recordset
            rs = Conn.Execute("select * from tblVisitorIn where ID = '" & Acnumber & "'")
            If rs.EOF = False Then
                Dim imgByteArray() As Byte
                Try
                    imgByteArray = CType(rs("ScanID").Value, Byte())
                    Dim stream As New System.IO.MemoryStream(imgByteArray)
                    Dim bmp As New Bitmap(stream)
                    stream.Close()
                    Return bmp
                Catch ex As Exception
                    'MessageBox.Show(ex.Message)
                    'frmMain.EntCap.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                    Return Nothing
                End Try
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function Visitor_Signa(ByRef Acnumber As String) As Bitmap
        Try
            Dim rs As New Recordset
            rs = Conn.Execute("select * from tblVisitorIn where Barcode = '" & Acnumber & "'")
            If rs.EOF = False Then
                Dim imgByteArray() As Byte
                Try
                    imgByteArray = CType(rs("Signature").Value, Byte())
                    Dim stream As New System.IO.MemoryStream(imgByteArray)
                    Dim bmp As New Bitmap(stream)
                    stream.Close()
                    Return bmp
                Catch ex As Exception
                    'MessageBox.Show(ex.Message)
                    'frmMain.EntCap.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                    Return Nothing
                End Try
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function Visitor_Signa2(ByRef Acnumber As String) As Bitmap
        Try
            Dim rs As New Recordset
            rs = Conn.Execute("select * from tblVisitorIn where ID = '" & Acnumber & "'")
            If rs.EOF = False Then
                Dim imgByteArray() As Byte
                Try
                    imgByteArray = CType(rs("Signature").Value, Byte())
                    Dim stream As New System.IO.MemoryStream(imgByteArray)
                    Dim bmp As New Bitmap(stream)
                    stream.Close()
                    Return bmp
                Catch ex As Exception
                    'MessageBox.Show(ex.Message)
                    'frmMain.EntCap.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                    Return Nothing
                End Try
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function Visitor_PicIn_IDext(ByRef Acnumber As String) As Bitmap
        Try
            Dim rs As New Recordset
            rs = Conn.Execute("select * from tblVisitorIn where Barcode = '" & Acnumber & "'")
            If rs.EOF = False Then
                Dim imgByteArray() As Byte
                Try
                    imgByteArray = CType(rs("ScanID").Value, Byte())
                    Dim stream As New System.IO.MemoryStream(imgByteArray)
                    Dim bmp As New Bitmap(stream)
                    stream.Close()
                    Return bmp
                Catch ex As Exception
                    'MessageBox.Show(ex.Message)
                    'frmMain.EntCap.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                    Return Nothing
                End Try
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function Visitor_Scan() As Bitmap
        Try
            Dim rs As New Recordset
            rs = Conn.Execute("select * from tblscanid")
            If rs.EOF = False Then
                Dim imgByteArray() As Byte
                Try
                    imgByteArray = CType(rs("ScanID").Value, Byte())
                    Dim stream As New System.IO.MemoryStream(imgByteArray)
                    Dim bmp As New Bitmap(stream)
                    stream.Close()
                    Return bmp
                Catch ex As Exception
                    'MessageBox.Show(ex.Message)
                    'frmMain.EntCap.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                    Return Nothing
                End Try
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Module
