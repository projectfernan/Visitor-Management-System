Public Class frmConnDB

    Sub save()
        With My.Settings
            .DB_IP = txtIp.Text
            .DB_UID = txtUID.Text
            .DB_PWD = txtPWD.Text
            .DB_Port = txtPort.Value.ToString
            .DB_Database = cboServerDb.Text

            .DBL_Ip = txtIpLoc.Text
            .DBL_Uid = txtUidLoc.Text
            .DBL_PWD = txtPwdLoc.Text
            .DBL_Port = txtPortLoc.Value.ToString
            .DBL_Database = cboLocDb.Text

            .Save()
        End With
    End Sub

    Private Sub cmdTest1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTest1.Click
        save()
        If conServer() = True Then
            MsgBox("Successfully connected!", MsgBoxStyle.Information, "Server Connection")
            If My.Settings.DefSet = "Client" Then
                MainForm.txtDBstat.Text = "Connected"
                MainForm.txtDBstat.ForeColor = Color.Cyan
            End If
        Else
            MsgBox("Failed to connect!", MsgBoxStyle.Exclamation, "Server Connection")
            If My.Settings.DefSet = "Client" Then
                MainForm.txtDBstat.Text = "Disconnected"
                MainForm.txtDBstat.ForeColor = Color.LightCoral
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox("Database settings saved successfully!    ", vbInformation, "Database Settings")
        save()
        Me.Close()
    End Sub

    Private Sub frmConnDB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With My.Settings
            txtIp.Text = .DB_IP
            txtUID.Text = .DB_UID
            txtPWD.Text = .DB_PWD
            txtPort.Value = CInt(.DB_Port)
            cboServerDb.Text = .DB_Database

            txtIpLoc.Text = .DBL_Ip
            txtUidLoc.Text = .DBL_Uid
            txtPwdLoc.Text = .DBL_PWD
            txtPortLoc.Value = CInt(.DBL_Port)
            cboLocDb.Text = .DBL_Database
        End With

        'Select Case My.Settings.DefSet
        '    Case "Server"
        '        GroupBox1.Enabled = False
        '        If Get_LocalDb() = True Then
        '            viewLocDb(cboLocDb)
        '        End If
        '    Case "Client"
        '        GroupBox1.Enabled = True
        '        If Get_ServerDb() = True Then
        '            viewServerDb(cboServerDb)
        '        End If

        '        If Get_LocalDb() = True Then
        '            viewLocDb(cboLocDb)
        '        End If
        'End Select

      
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub LbClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbClose.Click
        Me.Close()
    End Sub

    Private Sub cboServerDb_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboServerDb.Click
        save()
        If Get_ServerDb() = True Then
            viewServerDb(cboServerDb)
        End If
    End Sub

    Private Sub cboLocDb_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboLocDb.Click
        save()
        If Get_LocalDb() = True Then
            viewLocDb(cboLocDb)
        End If
    End Sub

    Private Sub btnTestLoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTestLoc.Click
        save()
        If conLocal() = False Then
            MessageBox.Show("Failed to connect!", "Local Connection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            If My.Settings.DefSet = "Client" Then
                MainForm.txtDbLoc.Text = "Disconnected"
                MainForm.txtDbLoc.ForeColor = Color.LightCoral
            End If
        Else
            MessageBox.Show("Successfully connected!", "Local Connection", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If My.Settings.DefSet = "Client" Then
                MainForm.txtDbLoc.Text = "Connected"
                MainForm.txtDbLoc.ForeColor = Color.Cyan
            End If
    
        End If
    End Sub
End Class