Imports ADODB
Public Class frmExit

    Private Sub tmeRead_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmeRead.Tick
        txtbCode.Focus()

        txtbCode.Text = ViewInfo()

        ViewEntInfoCard(txtbCode.Text)
    End Sub

    Function ViewInfo() As String
        If d8_conn() = False Then
            Return vbNullString
        End If

        If d8_Card() = False Then
            Return vbNullString
        End If

        If D8_LoadKey(2) = False Then
           Return vbNullString
        End If

        If D8_Authenticate(2) = False Then
           Return vbNullString
        End If

        Return d8_Read(9)

    End Function

    Private Sub cmdManual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdManual.Click
        frmManual.ShowDialog()
    End Sub

    Private Sub txtbCode_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbCode.KeyDown
        If e.KeyCode = Keys.F1 Then
            frmManual.ShowDialog()
        End If

        If e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter Then
            ViewEntInfo(txtbCode.Text)
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Sub ClearNull()
        txtvID.Text = vbNullString
        txtIssuedID.Text = vbNullString
        txtNAme.Text = vbNullString
        txtIDtype.Text = vbNullString
        txtIDRef.Text = vbNullString
        txtContact.Text = vbNullString
        txtCompVisited.Text = vbNullString
        txtContactP.Text = vbNullString
        txtPurpose.Text = vbNullString
        txtTimeIn.Text = vbNullString
        txtTimeOut.Text = vbNullString
    End Sub

    Public Sub SAVE_Exit(ByVal id As String)
        Try
            Dim rs As New Recordset
            Dim rs2 As New Recordset

            rs2 = New Recordset
            rs2 = Conn.Execute("select * from tblvisitorin where Barcode = '" & id & "'")
            If rs2.EOF = False Then
                rs = New Recordset
                rs.Open("select * from tblvisitorout", Conn, 1, 2)
                rs.AddNew()
                rs("VisitorID").Value = rs2("VisitorID").Value
                rs("VisitorName").Value = rs2("VisitorName").Value
                rs("IDtype").Value = rs2("IDtype").Value
                rs("ReferenceIDno").Value = rs2("ReferenceIDno").Value
                rs("ContactNo").Value = rs2("ContactNo").Value
                rs("TimeIn").Value = rs2("TimeIn").Value
                rs("TimeOut").Value = txtTimeOut.Text
                rs("CompanyVisited").Value = rs2("CompanyVisited").Value
                rs("ContactPerson").Value = rs2("ContactPerson").Value
                rs("Purpose").Value = rs2("Purpose").Value
                rs("Capture").Value = rs2("Capture").Value
                rs("ScanID").Value = rs2("ScanID").Value
                rs("Signature").Value = rs2("Signature").Value
                rs("Type").Value = "Regular"
                rs("RefNo").Value = "No Ref Number"
                rs.Update()
                MsgBox("Exit transaction saved!    ", vbInformation, "Save")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Save")
        End Try
    End Sub

    Sub delEnt(ByVal Code As String)
        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Conccetion")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Dim rs As New Recordset
        rs = New Recordset
        rs = Conn.Execute("delete from tblvisitorin where Barcode = '" & Code & "'")

    End Sub

    Function DisableVisitorAccess(ByVal crdCode As String) As Boolean
        If conServer() = False Then Return False

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = Conn.Execute("update tblemp set AccessStatus = 0 where ACno = '" & crdCode & "'")
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Private Sub cmdAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccept.Click
        Dim Crdcode As Integer
        Dim TruCardCode As String

        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Conccetion")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        If MsgBox("Did you identified the visitor? ", vbQuestion + vbYesNo + vbDefaultButton2, "Exit Transaction") = vbYes Then

            If d8_Card() = False Then
                MsgBox("Please place the card to reader! ", vbExclamation, "Settle")
                Exit Sub
            End If

DivalidateCard:

            'If Len(snr) < 10 Then
            '    Crdcode = snr
            '    TruCardCode = Crdcode + 4294967296.0#
            '    If DisableVisitorAccess(TruCardCode) = False Then GoTo DivalidateCard
            'Else
            Dim strHexCod As String
            Dim HexCod As String = Hex(snr)
           
            Dim trimCode As String

            trimCode = Mid(HexCod, 3)

            If Len(trimCode) < 6 Then
                trimCode = Mid(HexCod, 2)
            End If

            strHexCod = trimCode

            If DisableVisitorAccess(strHexCod) = False Then GoTo DivalidateCard
            'End If

            SAVE_Exit(extBcode)
            delEnt(extBcode)
            Me.Close()
        End If

    End Sub

    Private Sub frmExit_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        tmeRead.Enabled = False
    End Sub

    Private Sub frmExit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClearNull()
        cmdAccept.Enabled = False
        tmeRead.Enabled = True
        tmeBtn.Enabled = False

        Vimage.Image = Nothing
        IDimage.Image = Nothing
        PicSigna.Image = Nothing
    End Sub

    Private Sub tmeBtn_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmeBtn.Tick
        cmdAccept.Focus()
    End Sub

    Private Sub txtbCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbCode.TextChanged

    End Sub
End Class