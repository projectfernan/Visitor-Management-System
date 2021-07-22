Imports ADODB
Imports System.IO.Path
Imports System.Drawing.Imaging

Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Diagnostics

Imports System.Drawing.Drawing2D
Imports WacomMTDN
Imports WintabDN

Imports Emgu.CV
Imports Emgu.CV.UI
Imports Emgu.CV.Structure

Public Class MainForm
    Dim cap As New Capture()

    Dim ShotCateg As String = vbNullString

    Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.Control = True And e.KeyCode = Keys.Enter Then
            frmLogin.ShowDialog()
        End If

        If e.KeyCode = Keys.Escape Then
            If MessageBox.Show("Are you sure do you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) <> Windows.Forms.DialogResult.Yes Then
                Exit Sub
            End If

            If txtUser.Text = "LOCK" Then
                Exit Sub
            End If
            Ver = vbNullString
            Ver = "Logout"

            Cleartxt()
            disabledtxt()
            DisabledMain()
        End If

        If e.KeyCode = Keys.F1 Then
            If cmdNewVis.Enabled = True Then
                Call cmdNewVis_Click(sender, New System.EventArgs)
            End If
        End If

        If e.KeyCode = Keys.F2 Then
            If cmdSettle.Enabled = True Then
                Call cmdSettle_Click(sender, New System.EventArgs)
            End If
        End If

        If e.KeyCode = Keys.F3 Then
            If cmdExitTrans.Enabled = True Then
                Call cmdExitTrans_Click(sender, New System.EventArgs)
            End If
        End If

        If e.KeyCode = Keys.F4 Then
            If cmdExitTrans.Enabled = True Then
                If e.Alt = True And e.KeyCode = Keys.F4 Then Exit Sub
                Call cmdManExit_Click(sender, New System.EventArgs)
            End If
        End If

        If e.KeyCode = Keys.F5 Then
            If btnQvVisEnt.Enabled = True Then
                Call btnQvVisEnt_Click(sender, New System.EventArgs)
            End If
        End If

        If e.KeyCode = Keys.F6 Then
            If cmdCancelTrans.Enabled = True Then
                Call cmdCancelTrans_Click(sender, New System.EventArgs)
            End If
        End If

        If e.KeyCode = Keys.F7 Then
            If SplitContainer3.Panel2Collapsed = False Then
                Call cmdSigna_Click(sender, New System.EventArgs)
            End If
        End If

        If e.KeyCode = Keys.F8 Then
            If btnIDShot.Enabled = True Then
                Call btnIDShot_Click(sender, New System.EventArgs)
            End If
        End If

        If e.KeyCode = Keys.F9 Then
            If cmdShot.Enabled = True Then
                Call cmdShot_Click(sender, New System.EventArgs)
            End If
        End If

        If e.Control = True And e.Alt = True And e.KeyCode = Keys.I Then
            If txtUser.Text = "fernan" Then
                frmSystemTitle.ShowDialog()
            End If
        End If

        If e.Control = True And e.Alt = True And e.KeyCode = Keys.I Then
            If txtUser.Text = "ssi" Then
                frmSystemTitle.ShowDialog()
            End If
        End If

        If e.Control = True And e.KeyCode = Keys.Insert Then
            If txtUser.Text = "fernan" Then
                frmSystem.ShowDialog()
            End If
        End If

        If e.Control = True And e.KeyCode = Keys.Insert Then
            If txtUser.Text = "ssi" Then
                frmSystem.ShowDialog()
            End If
        End If

        If e.Control = True And e.Alt = True And e.KeyCode = Keys.R Then
            If txtUser.Text = "fernan" Then
                Dim f As New frmReset
                f.ShowDialog()
            End If
        End If


        If e.Control = True And e.Alt = True And e.KeyCode = Keys.R Then
            If txtUser.Text = "ssi" Then
                Dim f As New frmReset
                f.ShowDialog()
            End If
        End If
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Delete_MRZFile(IniFile)

        Delete_Face()
        Delete_Id()
        Delete_Signa()
        Delete_idPIC()

        ViewSystemSet()
        If My.Settings.AutoIDnumber = True Then
            txtVisitorID.Text = Count_ID_No()
        End If

        If conServer() = True Then
            txtDBstat.Text = "Connected"
            txtDBstat.ForeColor = Color.Cyan
        Else
            txtDBstat.Text = "Disconnected"
            txtDBstat.ForeColor = Color.LightCoral
        End If

        If conLocal() = True Then
            txtDbLoc.Text = "Connected"
            txtDbLoc.ForeColor = Color.Cyan

            UnitList(cboCompany)
            PurposeLst(cboPurpose)
        Else
            txtDbLoc.Text = "Disconnected"
            txtDbLoc.ForeColor = Color.LightCoral
        End If

        disabledtxt()
        DisabledMain()

    End Sub

    Sub vtypL(ByVal cbo As ComboBox)
        Dim rs As New Recordset
        cbo.Items.Clear()

        rs = New Recordset
        rs = ConnLoc.Execute("SELECT * from tblCompany")

        While rs.EOF = False
            cbo.Items.Add(rs("CompanyName").Value)
            rs.MoveNext()
        End While
    End Sub

    Sub UnitList(ByVal cbo As ComboBox)
        Try
            Dim rs As New Recordset
            cbo.Items.Clear()

            rs = New Recordset
            rs = ConnLoc.Execute("SELECT * from tblunits where Tower = '" & txtStation.Text & "'")

            While rs.EOF = False
                cbo.Items.Add(rs("UnitNo").Value)
                rs.MoveNext()
            End While
        Catch ex As Exception

        End Try

    End Sub

    Sub PurposeLst(ByVal cbo As ComboBox)
        Dim rs As New Recordset
        cbo.Items.Clear()

        rs = New Recordset
        rs = ConnLoc.Execute("SELECT * from tblPurpose")

        While rs.EOF = False
            cbo.Items.Add(rs("Purpose").Value)
            rs.MoveNext()
        End While
    End Sub


    Sub vIDtype(ByVal cbo As ComboBox)
        Dim rs As New Recordset
        cbo.Items.Clear()

        rs = New Recordset
        rs = Conn.Execute("SELECT * from tblIDtype")

        While rs.EOF = False
            cbo.Items.Add(rs("IDtype").Value)
            rs.MoveNext()
        End While
    End Sub

    Private Sub cboCompany_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCompany.GotFocus
        If conServer() = True Then
            UnitList(cboCompany)
        End If
    End Sub

    Private Sub cboCompany_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboCompany.KeyDown
        Me.KeyPreview = True
    End Sub

    Private Sub cboCompany_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCompany.KeyPress
        ' If Asc(e.KeyChar) > 0 Then
        'e.KeyChar = vbNullString
        'End If
    End Sub

    Sub disabledtxt()
        cmdNewVis.Enabled = True
        cboCompany.Enabled = False
        txtVisitorID.Enabled = False
        txtVisitor.Enabled = False
        cboPurpose.Enabled = False
        txtRefIDno.Enabled = False
        txtContact.Enabled = False
        txtContactPerson.Enabled = False
        cmdSettle.Enabled = False
        cmdCancelTrans.Enabled = False
        cmdExitTrans.Enabled = True
        cmdManExit.Enabled = True

        cmdSigna.Enabled = False
        cmdShot.Enabled = False
        btnIDShot.Enabled = False
    End Sub

    Sub enabledtxt()
        cmdNewVis.Enabled = False
        cboCompany.Enabled = True
        txtVisitorID.Enabled = True
        txtVisitor.Enabled = True
        cboPurpose.Enabled = True
        txtRefIDno.Enabled = True
        txtContact.Enabled = True
        txtContactPerson.Enabled = True
        cmdSettle.Enabled = True
        cmdCancelTrans.Enabled = True
        cmdExitTrans.Enabled = True
        cmdManExit.Enabled = True

        If My.Settings.Signature = True Then
            cmdSigna.Enabled = True
        End If

        If My.Settings.WebCam = True Then
            cmdShot.Enabled = True
        End If

        If My.Settings.IdScanner = True Then
            btnIDShot.Enabled = True
        End If

        txtVisitorID.Focus()
    End Sub

    Sub Cleartxt()
        cboCompany.Text = vbNullString
        txtVisitor.Text = vbNullString
        cboPurpose.Text = vbNullString

        txtRefIDno.Text = vbNullString
        txtContact.Text = vbNullString
        'txtEmail.Text = vbNullString
        txtContactPerson.Text = vbNullString

        If My.Settings.AutoIDnumber = False Then
            txtVisitorID.Text = vbNullString
        End If

        cmdSettle.Enabled = False
        cmdCancelTrans.Enabled = False
        cmdExitTrans.Enabled = False
        cmdManExit.Enabled = False
        cmdShot.Enabled = True
    End Sub

    Function chkFill() As Boolean
        If cboCompany.Text = vbNullString Or _
            txtVisitor.Text = vbNullString Then
            ' txtIDtype.Text = vbNullString Or
            ' txtRefIDno.Text = vbNullString Or _
            '  txtContact.Text = vbNullString Or _
            ' txtContactPerson.Text = vbNullString Or _
            '  txtPurpose.Text = vbNullString 
            Return True
        Else
            Return False
        End If
    End Function

    Function chk() As Boolean
        Dim rs As New Recordset

        rs = New Recordset
        rs = Conn.Execute("select * from tblVisitorIn where VisitorID = '" & txtVisitorID.Text & "'")

        If rs.EOF = False Then
            Return False
        Else
            Return True
        End If
    End Function

    Function Bcode(ByVal dt As String) As String
        Dim dtFormat As String = Format(CDate(dt), "yyyy-MM-dd HH:mm:ss")
        Dim hr As String = Mid(dtFormat, 12)
        Return "*" & Replace(hr, ":", vbNullString) & "*"
    End Function

    Public Sub SaveBitmap(ByVal control As Control, ByVal fileName As String)
        Dim gr1 As Graphics = control.CreateGraphics()
        Dim bmp1 As New Bitmap(control.Width, control.Height)
        control.DrawToBitmap(bmp1, New Rectangle(0, 0, control.Width, control.Height))
        bmp1.Save(fileName)
    End Sub

    Function saveVisIn(ByVal Code As String) As Boolean
        Dim fl As New FloorNo
        fl = Get_FloorNo(cboCompany.Text)

        If conServer() = False Then
            MsgBox("Please connect to server! ", vbExclamation, "Save")
            frmConnDB.ShowDialog()
        End If

        Try
            Dim dtIn As String = Format(Now, "yyyy-MM-dd HH:mm")

            Dim rs As New Recordset
            rs = New Recordset

            rs = Conn.Execute("insert into tblvisitorin(LogCode,TimeIn,VisitorIdNo,ReferenceIDno,VisitorName,ContactNo,UnitToVisit,Floor,ContactPerson,Purpose,Code,Tower)VALUES('" & _
                                                        Count_ID_No_Twr() & "','" & _
                                                        dtIn & "','" & _
                                                        txtVisitorID.Text & "','" & _
                                                        txtRefIDno.Text & "','" & _
                                                        txtVisitor.Text & "','" & _
                                                        txtContact.Text & "','" & _
                                                        cboCompany.Text & "','" & _
                                                        fl.FloorNumber & "','" & _
                                                        txtContactPerson.Text & "','" & _
                                                        cboPurpose.Text & "','" & _
                                                        Code & "','" & _
                                                        txtStation.Text & "')")
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Save")
            Return False
        End Try
    End Function

    Function saveCamImg(ByVal LogCode As String) As Boolean
        Try
            If conServer() = False Then
                Return False
            End If

            Dim strem As New Stream
            Dim rs As New Recordset
            rs.Open("select * from tblimgcam where 1=0", Conn, 1, 2)
            rs.AddNew()
            rs("LogCode").Value = LogCode
            If CheckMRZFile(JPEGPicPath) = True Then
                strem.Type = StreamTypeEnum.adTypeBinary
                strem.Open()
                strem.LoadFromFile(JPEGPicPath)
                rs("CamImage").Value = strem.Read
                strem.Close()
            End If
            rs.Update()
            Delete_Face()
            Return True
        Catch ex As Exception
            'MsgBox(ex.Message, vbCritical, "Save CamImg")
            Return False
        End Try
    End Function

    Function saveIdImg(ByVal LogCode As String) As Boolean
        Try
            If conServer() = False Then
                Return False
            End If

            Dim strem As New Stream
            Dim rs As New Recordset
            rs.Open("select * from tblimgid where 1=0", Conn, 1, 2)
            rs.AddNew()
            rs("LogCode").Value = LogCode
            If My.Settings.IdScanner = True Then
                If CheckMRZFile(ImagePAth) = True Then
                    strem = New Stream
                    strem.Type = StreamTypeEnum.adTypeBinary
                    strem.Open()
                    strem.LoadFromFile(ImagePAth)
                    rs("IdImage").Value = strem.Read
                    strem.Close()
                End If
                Delete_Id()
            End If
            rs.Update()
            Delete_Face()
            Return True
        Catch ex As Exception
            'MsgBox(ex.Message, vbCritical, "Save IdImg")
            Return False
        End Try
    End Function

    Function saveSignaImg(ByVal LogCode As String) As Boolean
        Try
            If conServer() = False Then
                Return False
            End If

            Dim strem As New Stream
            Dim rs As New Recordset
            rs.Open("select * from tblimgsigna where 1=0", Conn, 1, 2)
            rs.AddNew()
            rs("LogCode").Value = LogCode
            Try
                Call PictureBox1.Image.Save(Application.StartupPath & "\" & "Signa.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg)
            Catch ex As Exception

            End Try

            If CheckMRZFile(signa_Path) = True Then
                strem = New Stream
                strem.Type = StreamTypeEnum.adTypeBinary
                strem.Open()
                strem.LoadFromFile(signa_Path)
                rs("SignaImage").Value = strem.Read
                strem.Close()
            End If
            Delete_Signa()
            rs.Update()
            Delete_Face()
            Return True
        Catch ex As Exception
            'MsgBox(ex.Message, vbCritical, "Save SignaImg")
            Return False
        End Try
    End Function

    Sub updating()
        Dim rs As New Recordset
        rs = New Recordset

        rs.Open("select * from tblVisitorIn where VisitorID = '" & txtVisitorID.Text & "'", Conn, 1, 2)

        rs("TimeIn").Value = Now
        rs("VisitorName").Value = txtVisitor.Text
        rs("ReferenceIDno").Value = txtRefIDno.Text
        rs("ContactNo").Value = txtContact.Text
        'rs("Email").Value = 'txtEmail.Text
        rs("CompanyVisited").Value = cboCompany.Text
        rs("ContactPerson").Value = txtContactPerson.Text

        Dim strem As New Stream
        strem.Type = StreamTypeEnum.adTypeBinary
        strem.Open()
        strem.LoadFromFile(JPEGPicPath)
        rs("Capture").Value = strem.Read

        rs.Update()


    End Sub

    Sub saveScan(ByVal Path As String)

        If conServer() = True Then
            Try
                Dim rs As New Recordset
                rs = New Recordset
                rs.Open("select * from tblscanid", Conn, 1, 2)
                If rs.EOF = False Then
                    Dim strem As New Stream
                    strem.Type = StreamTypeEnum.adTypeBinary
                    strem.Open()
                    strem.LoadFromFile(Path)
                    rs("ScanID").Value = strem.Read
                    rs.Update()
                Else
                    Dim strem As New Stream
                    strem.Type = StreamTypeEnum.adTypeBinary
                    strem.Open()
                    strem.LoadFromFile(Path)
                    rs.AddNew()
                    rs("ScanID").Value = strem.Read
                    rs.Update()
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Function SaveCard(ByVal VisId As String, ByVal Bcode As String, ByVal VisName As String, ByVal VisIdType As String, ByVal VisRefId As String, ByVal VisCompVisit As String, ByVal VisContactP As String, ByVal VisPurpose As String) As Boolean
        If d8_conn() = False Then
            'MsgBox("No device connected! ", vbExclamation, "Transaction")
            Return False
        End If

        If d8_Card() = False Then
            'MsgBox("Please place your card to reader! ", vbExclamation, "Monthly Transaction")
            Return False
        End If

        '----------------------------- Address 2 -------------------------------

        If D8_LoadKey(2) = False Then
            MsgBox("The card is not reset properly! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Return False
        End If

        If D8_Authenticate(2) = False Then
            MsgBox("The card is not reset properly! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Return False
        End If

        If D8_ResetCard(8) = False Then
            MsgBox("The card is not reset properly! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Return False
        End If

        If D8_ResetCard(9) = False Then
            MsgBox("The card is not reset properly! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Return False
        End If

        If D8_WriteCard(8, VisId) = False Then
            MsgBox("Failed to write data! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Return False
        End If

        If D8_WriteCard(9, Bcode) = False Then
            MsgBox("Failed to write data! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Return False
        End If

        '----------------------------- Address 3 -------------------------------------

        If D8_LoadKey(3) = False Then
            MsgBox("The card is not reset properly! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Return False
        End If

        If D8_Authenticate(3) = False Then
            MsgBox("The card is not reset properly! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Return False
        End If

        If D8_ResetCard(12) = False Then
            MsgBox("The card is not reset properly! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Return False
        End If

        If D8_ResetCard(13) = False Then
            MsgBox("The card is not reset properly! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Return False
        End If

        If D8_ResetCard(14) = False Then
            MsgBox("The card is not reset properly! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Return False
        End If

        If D8_WriteCard(12, VisName) = False Then
            MsgBox("Failed to write data! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Return False
        End If

        If D8_WriteCard(13, VisIdType) = False Then
            MsgBox("Failed to write data! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Return False
        End If

        If D8_WriteCard(14, VisRefId) = False Then
            MsgBox("Failed to write data! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Return False
        End If

        '----------------------------- Address 4 -------------------------------------

        If D8_LoadKey(4) = False Then
            MsgBox("The card is not reset properly! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Return False
        End If

        If D8_Authenticate(4) = False Then
            MsgBox("The card is not reset properly! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Return False
        End If

        If D8_ResetCard(16) = False Then
            MsgBox("The card is not reset properly! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Return False
        End If

        If D8_ResetCard(17) = False Then
            MsgBox("The card is not reset properly! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Return False
        End If

        If D8_ResetCard(18) = False Then
            MsgBox("The card is not reset properly! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Return False
        End If

        If D8_WriteCard(16, VisCompVisit) = False Then
            MsgBox("Failed to write data! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Return False
        End If

        If D8_WriteCard(17, VisContactP) = False Then
            MsgBox("Failed to write data! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Return False
        End If

        If D8_WriteCard(18, VisPurpose) = False Then
            MsgBox("Failed to write data! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Return False
        End If

        '-----------------------------------------------------------------------------
        d8_Beep()
        Return True

    End Function

    Private Sub cmdShot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdShot.Click

        ''CaptureShot(PicViewBox, Replace(bcod, "*", vbNullString))
        'ConvertBMP_TO_JPEG(BMPPicPATH, ImageFormat.Jpeg)

        '' cmdSave.Enabled = True
        'Save2.Enabled = True
        'cmdShot.Enabled = False

        Select Case cmdShot.Text
            Case "(F9) Snap Shot"
                btnIDShot.Text = "(F8) Snap Shot"
                ShotCateg = "Face"
                tmeWebCam.Enabled = True
                cmdShot.Text = "(F9) Capture"
            Case "(F9) Capture"
                tmeWebCam.Enabled = False
                Call WebCam.Image.Save(Application.StartupPath & "\" & "FaceShot.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg)
                JPEGPicPath = Application.StartupPath & "\" & "FaceShot.jpeg"

                cmdShot.Text = "(F9) Snap Shot"
        End Select

    End Sub

    Private Sub txtVisitor_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVisitor.GotFocus
        textname = txtVisitor.Name
        Me.KeyPreview = True
    End Sub

    Private Sub txtContact_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContact.GotFocus
        textname = txtContact.Name
        Me.KeyPreview = True
    End Sub

    Private Sub txtRefIDno_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRefIDno.GotFocus
        textname = txtRefIDno.Name
        Me.KeyPreview = True
    End Sub

    Private Sub txtContactPerson_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContactPerson.GotFocus
        textname = txtContactPerson.Name
        Me.KeyPreview = True
    End Sub

    Private Sub frmMain_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        cboCompany.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cboCompany.AutoCompleteSource = AutoCompleteSource.CustomSource

        cboPurpose.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cboPurpose.AutoCompleteSource = AutoCompleteSource.CustomSource
    End Sub

    Sub DelScanID()
        If conServer() = True Then
            Try
                Dim rs As New Recordset
                rs = New Recordset
                rs = Conn.Execute("delete from tblscanid")
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub tmeReadText_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmeReadText.Tick
        If CheckMRZFile(IniFile) = True Then
            ' Dim x As New Data_Config
            '  x = Get_Data_Config()

            '  txtVisitor.Text = x.GivenName & " " & x.Surname
            '  txtIDtype.Text = x.DocType
            ' txtRefIDno.Text = x.DocumentNo

            'ScanID.Image = Image.FromFile(ImagePAth)
            If CheckMRZFile(ImagePAth & IdName) = True Then
                saveScan(ImagePAth & IdName)
            End If

            ScanID.Image = Visitor_Scan()

            txtNotice.Visible = False

            tmeReadText.Enabled = False
        Else

        End If
    End Sub



    Private Sub tmeTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmeTime.Tick
        txtDate.Text = Format(Now, "Long Date")
        txtTime.Text = Format(Now, "HH:mm:ss")
    End Sub

    Function chkVisitorCArd(ByVal crdCode As String) As Boolean
        If conServer() = False Then Return False

        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = Conn.Execute("select CardCode from vweempinfo where CardCode = '" & crdCode & "' and CardType = 'Visitor' and AccessStatus=0")
            If rs.EOF = False Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Sub EnableVisitorAccess(ByVal crdCode As String)
        If conServer() = False Then Exit Sub

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = Conn.Execute("update tblemp set AccessStatus = 1 where ACno = '" & crdCode & "'")

        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmdSettle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSettle.Click
        Dim Code As String = vbNullString

        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        If chkFill() = True Then
            MsgBox("Please fill up the blanks!    ", vbExclamation, "Save")
            Exit Sub
        End If

        If MsgBox("Are you sure your entries are correct? ", vbQuestion + vbYesNo, "Save") = vbYes Then
            Select Case My.Settings.MODE
                Case "MANUAL"
                    Code = txtVisitorID.Text
                Case "CARD"
                    'If d8_Card() = False Then
                    '    MsgBox("Please place the card to reader! ", vbExclamation, "Settle")
                    '    Exit Sub
                    'End If

                    'Dim strHexCod As String
                    'Dim HexCod As String = Hex(snr)

                    'Dim trimCode As String

                    'trimCode = Mid(HexCod, 3)

                    'If Len(trimCode) < 6 Then
                    '    trimCode = Mid(HexCod, 2)
                    'End If

                    'strHexCod = trimCode

                    'Code = strHexCod
                    If ER302_Conn(My.Settings.ER302Com) = False Then
                        frmER302.ShowDialog()
                    End If

                    If ER302_Request() = False Then
                        MessageBox.Show("Please place a card into the reader!", "Read Card", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If

                    ER302_AntiColl()

                    Code = ER302_AntiColl()

                    If chkVisitorCArd(Code) = False Then
                        MsgBox("Card is invalid to register! ", vbExclamation, "Save")
                        Exit Sub
                    End If

                    EnableVisitorAccess(Code)

                Case "BARCODE"
                    Code = Count_ID_No_Twr()
                    If My.Settings.PrinterStat = False Then
                        Print_Logo()
                    End If
            End Select

reSave:     If saveVisIn(Code) = False Then
                MessageBox.Show("Failed to save visitor information!", "Settle Transaction", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                If (MessageBox.Show("Retry to save?", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                    GoTo reSave
                Else
                    Exit Sub
                End If
            End If

            If My.Settings.WebCam = True Then

reSaveCamImg:   If saveCamImg(Count_ID_No_Twr) = False Then
                    MessageBox.Show("Failed to save visitor actual appearance!", "Settle Transaction", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    If (MessageBox.Show("Retry to save?", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                        GoTo reSaveCamImg
                    End If
                End If
                WebCam.Image = Nothing
            End If

            If My.Settings.IdScanner = True Then
reSaveIdScan:   If saveIdImg(Count_ID_No_Twr) = False Then
                    MessageBox.Show("Failed to save visitor surrendered ID image!", "Settle Transaction", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    If (MessageBox.Show("Retry to save?", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                        GoTo reSaveIdScan
                    End If
                End If

                ScanID.Image = Nothing
            End If

            If My.Settings.Signature = True Then
reSaveSigna:    If saveSignaImg(Count_ID_No_Twr) = False Then
                    MessageBox.Show("Failed to save visitor digital signature!", "Settle Transaction", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    If (MessageBox.Show("Retry to save?", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                        GoTo reSaveSigna
                    End If
                End If

                tmeDelImg.Enabled = True
                DelScanID()
            End If

            Cleartxt()
            disabledtxt()

            Update_ID()
            Me.Focus()
        End If
    End Sub

    Private Sub cmdExitTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExitTrans.Click
        frmExit.ShowDialog()
    End Sub

    Private Sub cmdNewVis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNewVis.Click

        If My.Settings.IdScanner = True Then
            'tmeDelImg.Enabled = True

            'If IdName = "" Then
            '    bcod = vbNullString
            '    bcod = Gen_Bcode(Get_Vcode())

            '    If My.Settings.AutoIDnumber = True Then
            '        txtVisitorID.Text = Count_ID_No()
            '        txtVisitor.Focus()
            '    Else
            '        txtVisitorID.Focus()
            '    End If

            '    enabledtxt()
            '    tmeReadText.Enabled = True

            '    DelScanID()
            '    ScanID.Image = Nothing

            '    txtNotice.Visible = True
            'End If
            'DelScanID()
            Delete_Face()
            Delete_Id()
            Delete_Signa()

            bcod = vbNullString
            bcod = Gen_Bcode(Get_Vcode())
            txtVisitorID.Focus()
            enabledtxt()
        Else
            'DelScanID()
            bcod = vbNullString
            bcod = Gen_Bcode(Get_Vcode())
            txtVisitorID.Focus()
            enabledtxt()
        End If
    End Sub

    Private Sub txtNotice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNotice.Click

    End Sub

    Private Sub cmdSigna_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSigna.Click
        frmSigna.ShowDialog()
    End Sub

    Private Sub cboCompany_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCompany.TextChanged
        Dim rs As New Recordset
        'cboCompany.Items.Clear()

        rs = New Recordset
        rs = Conn.Execute("SELECT UnitNo from tblunits where UnitNo like '" & cboCompany.Text & "%' and Tower = '" & txtStation.Text & "'")

        If rs.EOF = False Then
            cboCompany.DroppedDown = True
            While rs.EOF = False
                If cboCompany.Items.IndexOf(rs("UnitNo").Value) = -1 Then
                    cboCompany.Items.Add(rs("UnitNo").Value)
                Else
                End If
                rs.MoveNext()
            End While
        Else
            cboCompany.DroppedDown = False
        End If

        If Len(cboCompany.Text) <= 0 Then
            cboCompany.DroppedDown = False
        End If
    End Sub

    Private Sub cboPurpose_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboPurpose.KeyDown
        Me.KeyPreview = True
    End Sub

    Private Sub cboPurpose_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPurpose.TextChanged
        Dim rs As New Recordset
        'cboCompany.Items.Clear()

        rs = New Recordset
        rs = Conn.Execute("SELECT Purpose from tblpurpose where Purpose like '" & cboPurpose.Text & "%'")

        If rs.EOF = False Then
            cboPurpose.DroppedDown = True
            While rs.EOF = False
                If cboPurpose.Items.IndexOf(rs("Purpose").Value) = -1 Then
                    cboPurpose.Items.Add(rs("Purpose").Value)
                End If
                rs.MoveNext()
            End While
        Else
            cboPurpose.DroppedDown = False
        End If

        If Len(cboPurpose.Text) <= 0 Then
            cboPurpose.DroppedDown = False
        End If
    End Sub

    Private Sub cmdManExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdManExit.Click
        frmManExit.ShowDialog()
    End Sub

    Private Sub tmeDelImg_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmeDelImg.Tick
        Try
            IdName = Dir$(ImagePAth)
            If IdName = "" Then
                tmeDelImg.Enabled = False
            Else
                Delete_MRZFile(ImagePAth & IdName)
            End If
        Catch

        End Try
    End Sub

    Private Sub tmeWebCam_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmeWebCam.Tick
        Select Case ShotCateg
            Case "ID"
                ScanID.Image = cap.QueryFrame.ToBitmap() 'Second line
            Case "Face"
                WebCam.Image = cap.QueryFrame.ToBitmap()
        End Select
    End Sub

    Private Sub btnIDShot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIDShot.Click
        Select Case btnIDShot.Text
            Case "(F8) Snap Shot"
                cmdShot.Text = "(F9) Snap Shot"
                ShotCateg = "ID"
                tmeWebCam.Enabled = True
                btnIDShot.Text = "(F8) Capture"
            Case "(F8) Capture"
                tmeWebCam.Enabled = False
                Call ScanID.Image.Save(Application.StartupPath & "\" & "IDshot.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg)
                ImagePAth = Application.StartupPath & "\" & "IDshot.jpeg"

                btnIDShot.Text = "(F8) Snap Shot"
        End Select
    End Sub

    Private Sub txtVisitorID_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVisitorID.GotFocus
        Me.KeyPreview = True
    End Sub

    Private Sub cmdCancelTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelTrans.Click
        If MsgBox("Are you sure do you want to cancel this transaction? ", vbYesNo + vbQuestion, "Cancel Transaction") = vbYes Then
            Cleartxt()
            disabledtxt()

            'DelScanID()
            Delete_Face()
            Delete_Id()
            Delete_Signa()

            tmeWebCam.Enabled = False

            ScanID.Image = Nothing
            WebCam.Image = Nothing

            btnIDShot.Text = "(F8) Snap Shot"
            cmdShot.Text = "(F9) Snap Shot"

            txtNotice.Visible = False
        End If
    End Sub

    Private Sub btnQvVisEnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQvVisEnt.Click
        Dim f As New frmVisitorIn
        f.ShowDialog()
    End Sub
End Class
