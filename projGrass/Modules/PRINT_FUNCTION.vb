Imports ADODB
Imports System.Drawing.Printing
Imports System.IO
Imports System.Text

Module PRINT_FUNCTION
    Private WithEvents pdPrint As PrintDocument
    Private WithEvents pdPrintLogo As PrintDocument
    Public Logo As Bitmap
    Public Imahe As Bitmap
    Public compLogo As Bitmap
    Public bcod As String ' = '"*656825*"

    Public Sub Print_Ticket()

        'Try
        'Try
        ' Kill(BMPPicPATH)
        'Dim wFile As System.IO.FileStream

        'wFile = New FileStream(BMPPicPATH, FileMode.Open)

        'Logo = New Bitmap(Bitmap.FromStream(wFile))
        'wFile.Close()
        'Catch ex As IOException
        'ox(ex.ToString, vbCritical)
        'End Try

        Logo = New Bitmap(BMPPicPATH)
        'Catch ex As Exception
        'Logo = Nothing
        'End Try

        pdPrint = New PrintDocument
        pdPrint.PrinterSettings.PrinterName = My.Settings.PrinterDriver

        If pdPrint.PrinterSettings.IsValid Then
            Dim a As New StandardPrintController
            pdPrint.PrintController = a
            pdPrint.DefaultPageSettings.Margins.Top = 0
            pdPrint.DocumentName = "Testing"
            pdPrint.Print()
        Else
            MessageBox.Show("Printer is not available.", "Program01", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub pdPrint_Print(ByVal sender As System.Object, ByVal e As PrintPageEventArgs) Handles pdPrint.PrintPage
        Dim printFont As New Font("Microsoft Sans Serif", 8, FontStyle.Regular, GraphicsUnit.Point) ' Substituted to FontA Font
        Dim RegFont As New Font("Arial", 8, FontStyle.Regular, GraphicsUnit.Point) ' Substituted to FontA Font
        Dim Hfont As New Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point)
        Dim HNbfont As New Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point)
        Dim VIDfont As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point)
        Dim Vnamefont As New Font("Arial", 13, FontStyle.Bold, GraphicsUnit.Point)
        Dim BarFont As New Font("Free 3 of 9 Extended", 30, FontStyle.Regular, GraphicsUnit.Point)

        Dim drawFormat As StringFormat = New StringFormat()
        drawFormat.FormatFlags = StringFormatFlags.DirectionVertical


        e.Graphics.DrawString("----------------------------------------------------------------------------------", HNbfont, Brushes.Black, -15, 0)

        e.Graphics.PageUnit = GraphicsUnit.Point
        Dim x As Integer = 175
        Dim y As Integer = 14
        Dim j As Integer = 120
        e.Graphics.DrawImage(Logo, x, y, 90, 87)

        e.Graphics.DrawString(MainForm.txtCompany.Text, Hfont, Brushes.Black, 0, 12)
        'e.Graphics.DrawString(frmMain.txtTitle.Text, printFont, Brushes.Black, 0, 23)


        e.Graphics.DrawString("Visitor Name:", Hfont, Brushes.Black, 0, 40)
        e.Graphics.DrawString(MainForm.txtVisitor.Text, Vnamefont, Brushes.Black, 0, 55)

        e.Graphics.DrawString("-------------------------------------------------", HNbfont, Brushes.Black, 0, 72)

        e.Graphics.DrawString("Visitor ID No.: ", Hfont, Brushes.Black, 0, 85)
        e.Graphics.DrawString(MainForm.txtVisitorID.Text, HNbfont, Brushes.Black, 68, 85)

        e.Graphics.DrawString("Ref. ID No.: ", Hfont, Brushes.Black, 0, 100)
        e.Graphics.DrawString(MainForm.txtRefIDno.Text, HNbfont, Brushes.Black, 57, 100)

        e.Graphics.DrawString("Contact Number: ", Hfont, Brushes.Black, 0, 115)
        e.Graphics.DrawString(MainForm.txtContact.Text, HNbfont, Brushes.Black, 84, 115)

        e.Graphics.DrawString("Company to Visit: ", Hfont, Brushes.Black, 0, 130)
        e.Graphics.DrawString(MainForm.cboCompany.Text, HNbfont, Brushes.Black, 88, 130)

        e.Graphics.DrawString("Purpose: ", Hfont, Brushes.Black, 0, 145)
        e.Graphics.DrawString(MainForm.cboPurpose.Text, HNbfont, Brushes.Black, 47, 145)

        e.Graphics.DrawString("---------------------------------------------------------------------------------", HNbfont, Brushes.Black, 0, 157)
    End Sub

    Public Sub Print_Logo()

        'Try
        If My.Settings.MODE = "BARCODE" Then
            Imahe = New Bitmap(BMPPicPATH)
        End If

        compLogo = New Bitmap(Application.StartupPath & "\StickerLOGOdemo.bmp")
        'Catch ex As Exception
        'Logo = Nothing
        'End Try

        pdPrintLogo = New PrintDocument
        pdPrintLogo.PrinterSettings.PrinterName = My.Settings.PrinterDriver

        If pdPrintLogo.PrinterSettings.IsValid Then
            Dim a As New StandardPrintController
            pdPrintLogo.PrintController = a
            pdPrintLogo.DefaultPageSettings.Margins.Top = 0
            pdPrintLogo.DocumentName = "Testing"
            pdPrintLogo.Print()
        Else
            MessageBox.Show("Printer is not available.", "Program01", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Function FloorNo() As String
        Dim rs As New recordset
        rs = New Recordset

        rs = Conn.Execute("select * from tblCompany where CompanyName = '" & MainForm.cboCompany.Text & "'")

        If rs.EOF = False Then
            Return rs("Address").Value
        Else
            Return vbNullString
        End If
    End Function

    Private Sub pdPrintLogo_Print(ByVal sender As System.Object, ByVal e As PrintPageEventArgs) Handles pdPrintLogo.PrintPage
        Dim printFont As New Font("Microsoft Sans Serif", 8, FontStyle.Regular, GraphicsUnit.Point) ' Substituted to FontA Font
        Dim RegFont As New Font("Arial", 8, FontStyle.Regular, GraphicsUnit.Point) ' Substituted to FontA Font
        Dim titlefont As New Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Point)
        Dim Hfont As New Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point)
        Dim HNbfont As New Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point)
        Dim VIDfont As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point)
        Dim Vnamefont As New Font("Arial", 13, FontStyle.Bold, GraphicsUnit.Point)
        Dim Floorfont As New Font("Arial", 48, FontStyle.Bold, GraphicsUnit.Point)
        Dim BarFont As New Font("Free 3 of 9 Extended", 28, FontStyle.Regular, GraphicsUnit.Point)

        Dim drawFormat As StringFormat = New StringFormat()
        drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft

        e.Graphics.DrawString(MainForm.txtCompany.Text, titlefont, Brushes.Black, 2, 0)

        e.Graphics.PageUnit = GraphicsUnit.Point
        Dim x As Integer = 0
        Dim y As Integer = 30
        Dim j As Integer = 120
        e.Graphics.DrawImage(compLogo, x, y, 268, 30)

        e.Graphics.DrawImage(Imahe, 179, 63, 87, 80)
        ' e.Graphics.DrawString(bcod, BarFont, Brushes.Black, 175, 147) 
        e.Graphics.DrawString(bcod, BarFont, Brushes.Black, 175, 147)

        e.Graphics.DrawString("NAME: ", Hfont, Brushes.Black, 0, 70)
        e.Graphics.DrawString(MainForm.txtVisitor.Text, HNbfont, Brushes.Black, 35, 70)

        e.Graphics.DrawString("COMPANY: ", Hfont, Brushes.Black, 0, 90)
        e.Graphics.DrawString(MainForm.cboCompany.Text, HNbfont, Brushes.Black, 60, 90)

        e.Graphics.DrawString("DATE: ", Hfont, Brushes.Black, 0, 110)
        'e.Graphics.DrawString(petsa, HNbfont, Brushes.Black, 35, 110)

        e.Graphics.DrawString("TIME: ", Hfont, Brushes.Black, 0, 130)
        'e.Graphics.DrawString(oras, HNbfont, Brushes.Black, 35, 130)

        e.Graphics.DrawString("CODE: ", Hfont, Brushes.Black, 0, 150)
        e.Graphics.DrawString(Replace(bcod, "*", vbNullString), HNbfont, Brushes.Black, 35, 150)

        e.Graphics.DrawString("FLOOR: ", Hfont, Brushes.Black, 75, 150)
        e.Graphics.DrawString(Replace(FloorNo, "Floor ", vbNullString), Floorfont, Brushes.Black, 112, 115)

    End Sub

End Module
