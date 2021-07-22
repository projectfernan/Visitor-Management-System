Public Class frmConnDB

    Sub save()
        With My.Settings
            .DB_IP = txtIp.Text
            .DB_UID = txtUID.Text
            .DB_PWD = txtPWD.Text
            .DB_Port = txtPort.Text
            .Save()
        End With
    End Sub

    Private Sub cmdTest1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTest1.Click
        save()
        If conServer() = True Then
            MsgBox("Successfully connected!    ", MsgBoxStyle.Information, "Server Connection")
            frmMain.txtDBstat.Text = "Connected"
            frmMain.txtDBstat.ForeColor = Color.Blue
        Else
            MsgBox("Failed to connect!    ", MsgBoxStyle.Exclamation, "Server Connection")
            frmMain.txtDBstat.Text = "Disconnected"
            frmMain.txtDBstat.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox("Database settings saved successfully!    ", vbInformation, "Database Settings")
        save()
        Me.Close()
    End Sub

    Private Sub frmConnDB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class