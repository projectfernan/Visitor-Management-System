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

Public Class frmMain

    Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.Control = True And e.KeyCode = Keys.Enter Then
            frmLogin.ShowDialog()
        End If

        If e.KeyCode = Keys.Escape Then
            If txtUser.Text = "LOCK" Then
                Exit Sub
            End If
            Ver = vbNullString
            Ver = "Logout"
            frmVerification.ShowDialog()
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

        If e.KeyCode = Keys.F6 Then
            If cmdShot.Enabled = True Then
                Call cmdShot_Click(sender, New System.EventArgs)
            End If
        End If

        If e.KeyCode = Keys.F7 Then
            If cmdSigna.Enabled = True Then
                Call cmdSigna_Click(sender, New System.EventArgs)
            End If
        End If

        If e.KeyCode = Keys.F5 Then
            If cmdCancelTrans.Enabled = True Then
                Call cmdSystem_Click(sender, New System.EventArgs)
            End If
        End If

    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'LoadSignaPad()
        Delete_MRZFile(IniFile)
        Delete_Signa()
        Delete_idPIC()
    End Sub

    Sub vtypL(ByVal cbo As ComboBox)
        Dim rs As New Recordset
        cbo.Items.Clear()

        rs = New Recordset
        rs = Conn.Execute("SELECT * from tblCompany")

        While rs.EOF = False
            cbo.Items.Add(rs("CompanyName").Value)
            rs.MoveNext()
        End While
    End Sub

    Sub PurposeLst(ByVal cbo As ComboBox)
        Dim rs As New Recordset
        cbo.Items.Clear()

        rs = New Recordset
        rs = Conn.Execute("SELECT * from tblPurpose")

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
            vtypL(cboCompany)
        End If
    End Sub

    Private Sub cboCompany_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cboCompany.KeyDown
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
        txtVisitor.Enabled = False
        cboPurpose.Enabled = False
        txtIDtype.Enabled = False
        txtRefIDno.Enabled = False
        txtAddress.Enabled = False
        txtContact.Enabled = False
        ''txtEmail.Enabled = False
        txtContactPerson.Enabled = False
        txtPurpose.Enabled = False
        cmdSettle.Enabled = False
        cmdCancelTrans.Enabled = False
        cmdExitTrans.Enabled = True
        cmdManExit.Enabled = True
        Save2.Enabled = False
        cmdShot.Enabled = False
        cmdSigna.Enabled = False
    End Sub

    Sub enabledtxt()
        '  cmdNew.Enabled = False
        cmdNewVis.Enabled = False
        cboCompany.Enabled = True
        txtVisitor.Enabled = True
        cboPurpose.Enabled = True
        txtIDtype.Enabled = True
        txtRefIDno.Enabled = True
        txtAddress.Enabled = True
        txtContact.Enabled = True
        ''txtEmail.Enabled = True
        txtContactPerson.Enabled = True
        txtPurpose.Enabled = True
        cmdSettle.Enabled = True
        cmdCancelTrans.Enabled = True
        cmdExitTrans.Enabled = True
        cmdManExit.Enabled = True
        Save2.Enabled = True
        If My.Settings.WebCam = True Then
            cmdShot.Enabled = True
        End If

        cmdSigna.Enabled = True
    End Sub

    Sub Cleartxt()
        cboCompany.Text = vbNullString
        txtVisitor.Text = vbNullString
        txtIDtype.Text = vbNullString
        cboPurpose.Text = vbNullString

        txtRefIDno.Text = vbNullString
        txtAddress.Text = vbNullString
        txtContact.Text = vbNullString
        'txtEmail.Text = vbNullString
        txtContactPerson.Text = vbNullString
        txtPurpose.Text = vbNullString

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

    Sub save()
        If conServer() = False Then
            MsgBox("Please connect to server! ", vbExclamation, "Save")
            frmConnDB.ShowDialog()
        End If
        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs.Open("select * from tblVisitorIn", Conn, 1, 2)
            rs.AddNew()
            rs("VisitorID").Value = txtVisitorID.Text
            rs("ManualID").Value = Manual_IDno
            rs("TimeIn").Value = orasIn
            rs("VisitorName").Value = txtVisitor.Text
            rs("IDType").Value = txtIDtype.Text
            rs("ReferenceIDno").Value = txtRefIDno.Text
            rs("Address").Value = txtAddress.Text
            rs("ContactNo").Value = txtContact.Text
            'rs("Email").Value = 'txtEmail.Text
            rs("CompanyVisited").Value = cboCompany.Text
            rs("ContactPerson").Value = txtContactPerson.Text
            rs("Purpose").Value = cboPurpose.Text
            rs("Barcode").Value = Replace(bcod, "*", vbNullString)

            Dim strem As New Stream

            If My.Settings.WebCam = True Then
                If CheckMRZFile(JPEGPicPath) = True Then
                    strem.Type = StreamTypeEnum.adTypeBinary
                    strem.Open()
                    strem.LoadFromFile(JPEGPicPath)
                    rs("Capture").Value = strem.Read
                    strem.Close()
                End If
            End If

            If My.Settings.IdScanner = True Then
                If CheckMRZFile(ImagePAth) = True Then
                    strem = New Stream
                    strem.Type = StreamTypeEnum.adTypeBinary
                    strem.Open()
                    strem.LoadFromFile(ImagePAth & IdName)
                    rs("ScanID").Value = strem.Read
                    strem.Close()
                End If
                Delete_idPIC()
            End If

            If My.Settings.Signature = True Then
                Try
                    Call PictureBox1.Image.Save(Application.StartupPath & "\" & "Signa.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg)
                Catch ex As Exception

                End Try

                If CheckMRZFile(signa_Path) = True Then
                    strem = New Stream
                    strem.Type = StreamTypeEnum.adTypeBinary
                    strem.Open()
                    strem.LoadFromFile(signa_Path)
                    rs("Signature").Value = strem.Read
                    strem.Close()
                End If
                Delete_Signa()
            End If
          
            rs.Update()
            'MsgBox("Successfully saved!    ", vbInformation, "Save")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Save")
        End Try
    End Sub

    Sub updating()
        Dim rs As New Recordset
        rs = New Recordset

        rs.Open("select * from tblVisitorIn where VisitorID = '" & txtVisitorID.Text & "'", Conn, 1, 2)

        rs("TimeIn").Value = Now
        rs("VisitorName").Value = txtVisitor.Text
        rs("IDType").Value = txtIDtype.Text
        rs("ReferenceIDno").Value = txtRefIDno.Text
        rs("Address").Value = txtAddress.Text
        rs("ContactNo").Value = txtContact.Text
        'rs("Email").Value = 'txtEmail.Text
        rs("CompanyVisited").Value = cboCompany.Text
        rs("ContactPerson").Value = txtContactPerson.Text
        rs("Purpose").Value = txtPurpose.Text

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

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdShot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdShot.Click

        CaptureShot(PicViewBox, Replace(bcod, "*", vbNullString))
        ConvertBMP_TO_JPEG(BMPPicPATH, ImageFormat.Jpeg)

        ' cmdSave.Enabled = True
        Save2.Enabled = True
        cmdShot.Enabled = False

    End Sub

    Private Sub txtVisitor_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVisitor.GotFocus
        textname = txtVisitor.Name
    End Sub

    Private Sub txtAddress_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAddress.GotFocus
        textname = txtAddress.Name
    End Sub

    Private Sub txtContact_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContact.GotFocus
        textname = txtContact.Name
    End Sub

    Private Sub txtIDtype_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        textname = txtIDtype.Name
    End Sub

    Private Sub txtRefIDno_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRefIDno.GotFocus
        textname = txtRefIDno.Name
    End Sub

    Private Sub txtContactPerson_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContactPerson.GotFocus
        textname = txtContactPerson.Name
    End Sub

    Private Sub txtPurpose_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPurpose.GotFocus
        textname = txtPurpose.Name
    End Sub

    Private Sub txtIDtype_GotFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIDtype.GotFocus
        If conServer() = True Then
            vIDtype(txtIDtype)
        End If
    End Sub

    Private Sub txtIDtype_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIDtype.KeyPress
        'If Asc(e.KeyChar) > 0 Then
        'e.KeyChar = vbNullString
        'End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Save2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save2.Click

        If PicViewBox.Visible = False Then
            MsgBox("Get snap shot first! ", vbExclamation, "Save without print")
            Exit Sub
        End If

        frmManualId.ShowDialog()
    End Sub

    Private Sub frmMain_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LocationChanged

    End Sub

    Private Sub frmMain_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        cboCompany.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cboCompany.AutoCompleteSource = AutoCompleteSource.CustomSource

        viewPicSet()
        viewAddressSet()

        If My.Settings.WebCam = True Then
            iDevice = 0 'lstDevices.SelectedIndex
            OpenPreviewWindow()
        End If
       
        ViewPrinterDriver()

        DisabledMain()
        disabledtxt()
        cmdNewVis.Enabled = False
        cmdExitTrans.Enabled = False
        cmdManExit.Enabled = False

        ViewConn()
        If conServer() = True Then
            txtDBstat.Text = "Connected"
            txtDBstat.ForeColor = Color.Blue

            ViewSystemSet()

            vtypL(cboCompany)
            PurposeLst(cboPurpose)
            'vIDtype(txtIDtype)
            If My.Settings.AutoIDnumber = True Then
                txtVisitorID.Text = Count_ID_No()
            End If
        Else
            txtDBstat.Text = "Disconnected"
            txtDBstat.ForeColor = Color.Red
            frmConnDB.ShowDialog()
        End If

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



    Private Sub cmdSystem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelTrans.Click

        If MsgBox("Are you sure do you want to cancel this transaction? ", vbYesNo + vbQuestion, "Cancel Transaction") = vbYes Then
            Cleartxt()
            disabledtxt()

            DelScanID()
            ScanID.Image = Nothing
            PictureBox1.Image = Nothing

            If My.Settings.WebCam = True Then
                'REFRESH WEBCAM
                closepreviewwindow()
                WebCam.Image = Nothing
                iDevice = 0
                OpenPreviewWindow()
            End If

            PicViewBox.Image = Nothing
            PicViewBox.Visible = False

            txtNotice.Visible = False
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
        Dim Crdcode As Integer
        Dim TruCardCode As String

        If PicViewBox.Visible = False Then
            Call cmdShot_Click(sender, New System.EventArgs)
        End If

        Manual_IDno = "No Manual ID"
        oras = vbNullString
        petsa = vbNullString
        oras = Format(CDate(orasIn), "HH:mm:ss")
        petsa = Format(CDate(orasIn), "MM-dd-yy")

        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Conccetion")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        If chkFill() = True Then
            MsgBox("Please fill up the blanks!    ", vbExclamation, "Save")
            Exit Sub
        End If

        If MsgBox("Are you sure your entries are correct? ", vbQuestion + vbYesNo, "Save") = vbYes Then
            If SaveCard(txtVisitorID.Text, Replace(bcod, "*", vbNullString), txtVisitor.Text, txtIDtype.Text, txtRefIDno.Text, cboCompany.Text, txtContactPerson.Text, txtPurpose.Text) = True Then
            End If
            Update_ID()

            If My.Settings.PrinterStat = False Then
                Print_Logo()
            Else
                If d8_Card() = False Then
                    MsgBox("Please place the card to reader! ", vbExclamation, "Settle")
                    Exit Sub
                End If
            End If

            Dim strHexCod As String
            Dim HexCod As String = Hex(snr)

            Dim trimCode As String

            trimCode = Mid(HexCod, 3)

            If Len(trimCode) < 6 Then
                trimCode = Mid(HexCod, 2)
            End If
        
            strHexCod = trimCode

            If chkVisitorCArd(strHexCod) = False Then
                MsgBox("Card is invalid to register! ", vbExclamation, "Save")
                Exit Sub
            End If
            EnableVisitorAccess(strHexCod)
            ' End If

            save()
            tmeDelImg.Enabled = True
            DelScanID()

            Cleartxt()
            disabledtxt()

            ScanID.Image = Nothing
            PictureBox1.Image = Nothing

            PicViewBox.Image = Nothing
            PicViewBox.Visible = False

            'd    Call cmdNewVis_Click(sender, New System.EventArgs)

        End If
    End Sub

    Private Sub cmdExitTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExitTrans.Click
        frmExit.ShowDialog()
    End Sub

    Private Sub cmdNewVis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNewVis.Click

        If My.Settings.IdScanner = True Then
            tmeDelImg.Enabled = True

            If IdName = "" Then
                bcod = vbNullString
                bcod = Gen_Bcode(Get_Vcode())

                If My.Settings.AutoIDnumber = True Then
                    txtVisitorID.Text = Count_ID_No()
                    txtVisitor.Focus()
                Else
                    txtVisitorID.Focus()
                End If

                enabledtxt()
                tmeReadText.Enabled = True

                DelScanID()
                ScanID.Image = Nothing

                txtNotice.Visible = True
            End If
        Else
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

    Private Sub cboCompany_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCompany.SelectedIndexChanged

    End Sub

    Private Sub txtVisitor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVisitor.TextChanged

    End Sub

    Private Sub cboCompany_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCompany.TextChanged
        Dim rs As New Recordset
        'cboCompany.Items.Clear()

        rs = New Recordset
        rs = Conn.Execute("SELECT * from tblCompany where CompanyName like '" & cboCompany.Text & "%'")

        While rs.EOF = False
            cboCompany.Items.Add(rs("CompanyName").Value)
            ' cboCompany.AutoCompleteCustomSource.Add(rs("CompanyName").Value)
            rs.MoveNext()
        End While
        cboCompany.DroppedDown = True
        Me.KeyPreview = False
    End Sub

    Private Sub cboPurpose_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboPurpose.KeyDown
        Me.KeyPreview = True
    End Sub

    Private Sub cboPurpose_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPurpose.TextChanged
        Dim rs As New Recordset
        'cboCompany.Items.Clear()

        rs = New Recordset
        rs = Conn.Execute("SELECT * from tblpurpose where purpose like '" & cboPurpose.Text & "%'")

        While rs.EOF = False
            cboPurpose.Items.Add(rs("Purpose").Value)
            ' cboCompany.AutoCompleteCustomSource.Add(rs("CompanyName").Value)
            rs.MoveNext()
        End While
        cboPurpose.DroppedDown = True
        Me.KeyPreview = False
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
End Class
