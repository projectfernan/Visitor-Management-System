Imports ADODB
Public Class frmExit

    Private Sub tmeRead_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmeRead.Tick
        txtbCode.Focus()

        txtbCode.Text = ViewInfo()

        ViewEntInfo(txtbCode.Text)
    End Sub

    Function ViewInfo() As String
        
        tmeRead.Enabled = False

        If ER302_Conn(My.Settings.ER302Com) = False Then Return vbNullString
        If ER302_Request() = False Then Return vbNullString

        ER302_Beep()

        Return ER302_AntiColl()
    End Function

    Private Sub cmdManual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdManual.Click
        frmManual.ShowDialog()
    End Sub

    Private Sub txtbCode_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbCode.KeyDown
        If e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter Then
            ViewEntInfo(txtbCode.Text)
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
    End Sub

    Public Function SAVE_Exit_SERVER(ByVal Lcode As String) As Boolean

        If conServer() = False Then
            frmConnDB.ShowDialog()
            Return False
        End If

        Try
            Dim rs As New Recordset
            Dim rs2 As New Recordset

            rs2 = New Recordset
            rs2 = Conn.Execute("select * from tblvisitorin where Code = '" & Lcode & "'")
            If rs2.EOF = False Then
                Dim DtEnt As String = Format(CDate(rs2("TimeIn").Value), "yyyy-MM-dd HH:mm")
                Dim DtExt As String = Format(Now, "yyyy-MM-dd HH:mm")

                rs = Conn.Execute("insert into tblvisitorout(LogCode,TimeIn,TimeOut,VisitorIdNo,ReferenceIDno,VisitorName,ContactNo,Floor,UnitToVisit,ContactPerson,Purpose,Tower)VALUES('" & _
                                 rs2("LogCode").Value & "','" & _
                                 DtEnt & "','" & _
                                 DtExt & "','" & _
                                 rs2("VisitorIdNo").Value & "','" & _
                                 rs2("ReferenceIDno").Value & "','" & _
                                 rs2("VisitorName").Value & "','" & _
                                 rs2("ContactNo").Value & "','" & _
                                 rs2("Floor").Value & "','" & _
                                 rs2("UnitToVisit").Value & "','" & _
                                 rs2("ContactPerson").Value & "','" & _
                                 rs2("Purpose").Value & "','" & _
                                 rs2("Tower").Value & "')")
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Save Exit Transaction")
            Return False
        End Try
    End Function

    Public Function SAVE_Exit_LOCAL(ByVal Lcode As String) As Boolean
        Try
            If conLocal() = False Then Return False

            Dim rs As New Recordset
            Dim rs2 As New Recordset

            rs2 = New Recordset
            rs2 = Conn.Execute("select * from tblvisitorin where Code = '" & Lcode & "'")
            If rs2.EOF = False Then
                Dim DtEnt As String = Format(CDate(rs2("TimeIn").Value), "yyyy-MM-dd HH:mm")
                Dim DtExt As String = Format(Now, "yyyy-MM-dd HH:mm")

                rs = ConnLoc.Execute("insert into tblvisitorout(LogCode,TimeIn,TimeOut,VisitorIdNo,ReferenceIDno,VisitorName,ContactNo,Floor,UnitToVisit,ContactPerson,Purpose,Tower)VALUES('" & _
                                 rs2("LogCode").Value & "','" & _
                                 DtEnt & "','" & _
                                 DtExt & "','" & _
                                 rs2("VisitorIdNo").Value & "','" & _
                                 rs2("ReferenceIDno").Value & "','" & _
                                 rs2("VisitorName").Value & "','" & _
                                 rs2("ContactNo").Value & "','" & _
                                 rs2("Floor").Value & "','" & _
                                 rs2("UnitToVisit").Value & "','" & _
                                 rs2("ContactPerson").Value & "','" & _
                                 rs2("Purpose").Value & "','" & _
                                 rs2("Tower").Value & "')")
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Save Exit Transaction")
            Return False
        End Try
    End Function

    Sub delEnt(ByVal Code As String)
        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Conccetion")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Dim rs As New Recordset
        rs = New Recordset
        rs = Conn.Execute("delete from tblvisitorin where Code = '" & Code & "'")

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
        Dim Crdcode As Integer = 0
        Dim TruCardCode As String = vbNullString

        If MsgBox("Did you identified the visitor? ", vbQuestion + vbYesNo + vbDefaultButton2, "Exit Transaction") = vbYes Then

            If My.Settings.MODE = "CARD" Then
                'If d8_Card() = False Then
                '    MsgBox("Please place the card to reader! ", vbExclamation, "Settle")
                '    Exit Sub
                'End If

                
DivalidateCard:

                'If Len(snr) < 10 Then
                '    Crdcode = snr
                '    TruCardCode = Crdcode + 4294967296.0#
                '    If DisableVisitorAccess(TruCardCode) = False Then GoTo DivalidateCard
                'Else
                If ER302_Conn(My.Settings.ER302Com) = False Then
                    frmER302.ShowDialog()
                    GoTo DivalidateCard
                End If

                Dim strHexCod As String
                'Dim HexCod As String = Hex(snr)

                'Dim trimCode As String

                'trimCode = Mid(HexCod, 3)

                'If Len(trimCode) < 6 Then
                '    trimCode = Mid(HexCod, 2)
                'End If

                If ER302_Request() = False Then On Error GoTo DivalidateCard

                strHexCod = ER302_AntiColl()
                ER302_Beep()

                If DisableVisitorAccess(strHexCod) = False Then GoTo DivalidateCard
            End If

reS:        If SAVE_Exit_SERVER(extBcode) = False Then
                MessageBox.Show("Failed to save to server!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                If MessageBox.Show("Retry to save?", "Save", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                    GoTo reS
                End If
                Exit Sub
            End If

            MessageBox.Show("Exit transaction is successfully settled!", "Exit Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information)
            delEnt(extBcode)
            Me.Close()
        End If

    End Sub

    Private Sub frmExit_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        tmeRead.Enabled = False
    End Sub

    Private Sub frmExit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Call cmdManual_Click(sender, New System.EventArgs)
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmExit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ClearNull()
        cmdAccept.Enabled = False
        tmeRead.Enabled = True
        tmeBtn.Enabled = False

        'Vimage.Image = Nothing
        'IDimage.Image = Nothing
        'PicSigna.Image = Nothing

        txtTimeIn.Text = Format(Now, "yyyy-MM-dd HH:mm")

        If My.Settings.Signature = False Then
            PicSigna.Visible = False
        End If
    End Sub

    Private Sub tmeBtn_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmeBtn.Tick
        cmdAccept.Focus()
    End Sub

    Private Sub LbClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbClose.Click
        Me.Close()
    End Sub
End Class