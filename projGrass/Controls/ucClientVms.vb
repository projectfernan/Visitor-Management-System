Imports ADODB
Public Class ucClientVms
    Public Ip As String
    Public Uid As String
    Public Pwd As String
    Public Port As Integer
    Public Db As String
    Public Delay As Integer

    Private Sub ucClientVms_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If conVmsClient(Ip, Port.ToString, Db, Uid, Pwd) = False Then
            lblStat.Text = "Disconnected"
            lblStat.ForeColor = Color.Red
        Else
            lblStat.Text = "Connected"
            lblStat.ForeColor = Color.Blue

            tmePing.Interval = Delay
            tmePing.Enabled = True
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim f As New frmAddVms
        f.txtClient.Text = lblClient.Text
        f.txtIp.Text = Ip
        f.txtUID.Text = Uid
        f.txtPWD.Text = Pwd
        f.txtPort.Value = Port
        f.txtDb.Text = Db
        f.txtDelay.Value = Delay

        f.txtClient.Enabled = False
        f.lbTitle.Text = "      Update Client"
        f.ShowDialog()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure do you want to delete this client?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) <> DialogResult.Yes Then Exit Sub

        If DelClient(lblClient.Text) = True Then
            MessageBox.Show("Client '" & lblClient.Text & "' is successfully deleted!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MainFormServer.loadClient()

            MsgListBox("Client '" & lblClient.Text & "' is successfully deleted")
        End If
    End Sub

    Function DelClient(ByVal client As String) As Boolean
        If conLocal() = False Then Return False

        Try
            Dim rs As New Recordset
            rs = ConnLoc.Execute("delete from tblvmsclient where Client = '" & client & "'")
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click
        Dim f As New frmUploadData
        f.Uid = Uid
        f.Pwd = Pwd
        f.Db = Db

        f.lblClient.Text = lblClient.Text
        f.lblIp.Text = Ip.ToString
        f.lblPort.Text = Port.ToString

        f.ShowDialog()
    End Sub

    Private Sub tmePing_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmePing.Tick
        If bgwPing.IsBusy = False Then
            bgwPing.RunWorkerAsync()
            tmePing.Enabled = False
        End If
    End Sub

    Private Sub bgwPing_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwPing.DoWork
        e.Result = PingMe(Ip)
    End Sub

    Private Sub bgwPing_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwPing.RunWorkerCompleted
        If e.Result = False Then
            lblStat.Text = "Disconnected"
            lblStat.ForeColor = Color.Red
        Else
            lblStat.Text = "Connected"
            lblStat.ForeColor = Color.Blue
        End If
        tmePing.Enabled = True
    End Sub
End Class
