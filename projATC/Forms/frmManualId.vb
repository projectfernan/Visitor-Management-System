Imports ADODB
Public Class frmManualId

    Private Sub cmdAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccept.Click
        If txtID.Text = vbNullString Then Exit Sub

        If MsgBox("Are you sure your entries are correct? ", vbQuestion + vbYesNo, "Enter") = vbYes Then
            Update_ID()
            Manual_IDno = txtID.Text
            save()
            frmMain.DelScanID()

            frmMain.Cleartxt()
            frmMain.disabledtxt()
            frmMain.ScanID.Image = Nothing
            'REFRESH WEBCAM
            'WebCam.Image.Dispose()
            'iDevice = 0
            'OpenPreviewWindow()
            frmMain.PicViewBox.Image = Nothing
            frmMain.PicViewBox.Visible = False

            Me.Close()
        End If
    End Sub

    Sub save()
        If conServer() = False Then
            MsgBox("Please connect to server! ", vbExclamation, "Save")
            frmConnDB.ShowDialog()
        End If

        Try
            With frmMain
                Dim rs As New Recordset
                rs = New Recordset

                rs.Open("select * from tblVisitorIn", Conn, 1, 2)
                rs.AddNew()
                rs("VisitorID").Value = .txtVisitorID.Text
                rs("ManualID").Value = Manual_IDno
                rs("TimeIn").Value = orasIn
                rs("VisitorName").Value = .txtVisitor.Text
                rs("IDType").Value = .txtIDtype.Text
                rs("ReferenceIDno").Value = .txtRefIDno.Text
                rs("Address").Value = .txtAddress.Text
                rs("ContactNo").Value = .txtContact.Text
                'rs("Email").Value = 'txtEmail.Text
                rs("CompanyVisited").Value = .cboCompany.Text
                rs("ContactPerson").Value = .txtContactPerson.Text
                rs("Purpose").Value = .txtPurpose.Text
                rs("Barcode").Value = Replace(bcod, "*", vbNullString)

                Dim strem As New Stream

                If CheckMRZFile(JPEGPicPath) = True Then
                    strem.Type = StreamTypeEnum.adTypeBinary
                    strem.Open()
                    strem.LoadFromFile(JPEGPicPath)
                    rs("Capture").Value = strem.Read
                    strem.Close()
                End If

                If CheckMRZFile(ImagePAth) = True Then
                    strem = New Stream
                    strem.Type = StreamTypeEnum.adTypeBinary
                    strem.Open()
                    strem.LoadFromFile(ImagePAth)
                    rs("ScanID").Value = strem.Read
                    strem.Close()
                End If

                Call .PictureBox1.Image.Save(Application.StartupPath & "\" & "Signa.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg)

                If CheckMRZFile(signa_Path) = True Then
                    strem = New Stream
                    strem.Type = StreamTypeEnum.adTypeBinary
                    strem.Open()
                    strem.LoadFromFile(signa_Path)
                    rs("Signature").Value = strem.Read
                    strem.Close()
                    rs.Update()
                    MsgBox("Successfully saved!    ", vbInformation, "Save")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Save")
        End Try
    End Sub

    Private Sub frmManualId_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call cmdAccept_Click(sender, New System.EventArgs)
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmManualId_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class