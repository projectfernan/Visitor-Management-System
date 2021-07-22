Imports ADODB
Public Class frmSystemTitle

    Function chk() As Boolean
        Dim rs As New Recordset

        rs = New Recordset
        rs = Conn.Execute("select * from tblSystemSet")

        If rs.EOF = False Then
            Return False
        Else
            Return True
        End If
    End Function

    Sub del()
        Try
            Dim rs As New Recordset
            rs = Conn.Execute("delete from tblSystemSet")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Save")
        End Try
    End Sub

    Sub browse()
        Dim FBD As New FolderBrowserDialog
        FBD.Description = "Data Path Designation"
        FBD.ShowNewFolderButton = True      'OR FALSE
        FBD.SelectedPath = "C:\"
        FBD.ShowDialog()
        txtpath.Text = FBD.SelectedPath      'Use this path to Process the folder...or files
        FBD = Nothing
    End Sub

    Sub save()

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs.Open("select * from tblSystemSet", Conn, 1, 2)
            rs.AddNew()
            rs("SystemCompany").Value = txtCompanyName.Text
            rs("SystemTitle").Value = txtTitle.Text
            rs.Update()

            With My.Settings
                .ID_No = txtOR.Value
                .Station = cboStation.Text
                .DataPath = txtpath.Text
                .Save()

                If My.Settings.AutoIDnumber = True Then
                    frmMain.txtVisitorID.Text = Count_ID_No()
                End If

                frmMain.txtStation.Text = .Station
            End With
            'MsgBox("System settings successfully set!    ", vbInformation, "Save")
            'Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Save")
        End Try
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Conccetion")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        If chk() = False Then
            del()
            save()
            saveSet()
            saveSetAdd()
            viewAddressSet()
            ViewSystemSet()
            MsgBox("System settings successfully set!    ", vbInformation, "Save")
            Me.Close()
        Else
            save()
            saveSet()
            saveSetAdd()
            viewAddressSet()
            ViewSystemSet()
            MsgBox("System settings successfully set!    ", vbInformation, "Save")
            Me.Close()
        End If

    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Sub saveSet()
        If chkClearPic.Checked = True Then
            With My.Settings
                .ClearPic = True
                .Save()
            End With
        Else
            With My.Settings
                .ClearPic = False
                .Save()
            End With
        End If
    End Sub

    Sub saveSetAdd()
        If chkAddress.Checked = True Then
            With My.Settings
                .CheckAddress = True
                .Save()
            End With
        Else
            With My.Settings
                .CheckAddress = False
                .Save()
            End With
        End If
    End Sub

    Private Sub cboStation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboStation.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cmdFP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFP.Click
        browse()
    End Sub

    Private Sub frmSystemTitle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        With My.Settings
            txtOR.Value = .ID_No
            cboStation.Text = .Station
            txtpath.Text = .DataPath
            chkWebcam.Checked = .WebCam
        End With
    End Sub

    Private Sub chkWebcam_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkWebcam.CheckedChanged
        With My.Settings
            .WebCam = chkWebcam.Checked
            .Save()
        End With
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAutoNumber.CheckedChanged
        With My.Settings
            .AutoIDnumber = chkAutoNumber.Checked
            .Save()
        End With
    End Sub

    Private Sub chkIdScanner_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIdScanner.CheckedChanged
        With My.Settings
            .IdScanner = chkIdScanner.Checked
            .Save()
        End With
    End Sub

    Private Sub chkSigna_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSigna.CheckedChanged
        With My.Settings
            .Signature = chkSigna.Checked
            .Save()
        End With
    End Sub
End Class