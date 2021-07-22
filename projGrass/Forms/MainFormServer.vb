Imports ADODB
Public Class MainFormServer

    Private Sub MainFormServer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If conLocal() = False Then
            txtDbLoc.Text = "Disconnected"
            txtDbLoc.ForeColor = Color.Coral

            frmConnDB.ShowDialog()
        Else
            txtDbLoc.Text = "Connected"
            txtDbLoc.ForeColor = Color.Cyan

            loadClient()
        End If

        Locked_Server_Main()
    End Sub

    Private Sub MainFormServer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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

        If e.Control = True And e.KeyCode = Keys.Enter Then
            Dim f As New frmLogin
            f.ShowDialog()
        End If

        If e.KeyCode = Keys.Escape Then
            If MessageBox.Show("Are you sure do you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Locked_Server_Main()
                txtDesig.Text = "System :"
                txtUser.Text = "Locked"
            End If
        End If
    End Sub

    Private Sub btnDbSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDbSettings.Click
        frmConnDB.ShowDialog()
    End Sub

    Private Sub btnAcc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcc.Click
        frmSystemAcc.ShowDialog()
    End Sub

    Private Sub btnUnitsRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnitsRec.Click
        frmCompany.ShowDialog()
    End Sub

    Private Sub btnPurpose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPurpose.Click
        frmPurpose.ShowDialog()
    End Sub

    Private Sub btnReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReports.Click
        frmLogsCateg.ShowDialog()
    End Sub

    Private Sub btnTerminate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTerminate.Click
        If MsgBox("Are you sure do you want to quit?    ", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "System") = vbYes Then
            Application.ExitThread()
            Application.Exit()
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        

        Dim f As New frmAddVms
        f.lbTitle.Text = "      New Client"

        f.ShowDialog()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        loadClient()
    End Sub

    Function loadClient() As Boolean
        If conLocal() = False Then
            Return False
        End If

        Try
            flpClients.Controls.Clear()

            Dim rs As New Recordset
            rs = ConnLoc.Execute("select * from tblvmsclient")
            If rs.EOF = False Then
                Do While rs.EOF = False
                    Dim cVms As New ucClientVms

                    cVms.Ip = rs("IpAdd").Value
                    cVms.Port = CInt(rs("Port").Value)
                    cVms.Db = rs("Database").Value
                    cVms.Uid = rs("Uid").Value
                    cVms.Pwd = rs("Pwd").Value
                    cVms.Delay = CInt(rs("Delay").Value)

                    cVms.lblClient.Text = rs("Client").Value

                    flpClients.Controls.Add(cVms)

                    rs.MoveNext()
                Loop
            End If
        Catch ex As Exception

        End Try
    End Function

    Private Sub tmeTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmeTime.Tick
        txtDate.Text = Format(Now, "Long Date")
        txtTime.Text = Format(Now, "HH:mm:ss")
    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        Dim f As New frmAbout
        f.ShowDialog()
    End Sub
End Class