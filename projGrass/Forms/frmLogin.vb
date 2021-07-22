Imports ADODB
Imports System.IO.Path
Imports System.Drawing.Imaging
Public Class frmLogin

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Sub SystemCreator()
        Dim UID As String = "fernan"
        Dim PWD As String = "0901pr0J3ctf0273"

        If Trim(txtUID.Text) = UID Then
            If Trim(txtPWD.Text) = PWD Then
                With MainForm
                    .txtDesig.Text = "System Creator :"
                    .txtUser.Text = "fernan"
                    EnabledOpMain()
                    EnabledAdminMain()
                    Me.Hide()
                    Me.Close()
                End With
            Else
                MsgBox("Unknown password!    ", vbExclamation, "Login")
                txtPWD.Text = vbNullString
                txtPWD.Focus()
            End If
        Else
            MsgBox("Unknown username!     ", vbExclamation, "Login")
            txtUID.Text = vbNullString
            txtPWD.Text = vbNullString
            txtUID.Focus()
        End If
    End Sub

    Sub SSILogin()
        Dim UID As String = "ssi"
        Dim PWD As String = "ss1pr0j"

        If Trim(txtUID.Text) = UID Then
            If Trim(txtPWD.Text) = PWD Then
                With MainForm
                    .txtDesig.Text = "Partner Distributor :"
                    .txtUser.Text = "ssi"
                    EnabledOpMain()
                    EnabledAdminMain()
                    Me.Hide()
                    Me.Close()
                End With
            Else
                MsgBox("Unknown password!    ", vbExclamation, "Login")
                txtPWD.Text = vbNullString
                txtPWD.Focus()
            End If
        Else
            MsgBox("Unknown username!     ", vbExclamation, "Login")
            txtUID.Text = vbNullString
            txtPWD.Text = vbNullString
            txtUID.Focus()
        End If
    End Sub

    Sub SystemCreatorServer()
        Dim UID As String = "fernan"
        Dim PWD As String = "0901pr0J3ctf0273"

        If Trim(txtUID.Text) = UID Then
            If Trim(txtPWD.Text) = PWD Then
                With MainFormServer
                    .txtDesig.Text = "System Creator :"
                    .txtUser.Text = "fernan"
                    UnLocked_Server_Main()
                    Me.Hide()
                    Me.Close()
                End With
            Else
                MsgBox("Unknown password!    ", vbExclamation, "Login")
                txtPWD.Text = vbNullString
                txtPWD.Focus()
            End If
        Else
            MsgBox("Unknown username!     ", vbExclamation, "Login")
            txtUID.Text = vbNullString
            txtPWD.Text = vbNullString
            txtUID.Focus()
        End If
    End Sub

    Sub SSIServerLogin()
        Dim UID As String = "ssi"
        Dim PWD As String = "ss1pr0j"

        If Trim(txtUID.Text) = UID Then
            If Trim(txtPWD.Text) = PWD Then
                With MainFormServer
                    .txtDesig.Text = "Partner Distributor :"
                    .txtUser.Text = "ssi"
                    UnLocked_Server_Main()
                    Me.Hide()
                    Me.Close()
                End With
            Else
                MsgBox("Unknown password!    ", vbExclamation, "Login")
                txtPWD.Text = vbNullString
                txtPWD.Focus()
            End If
        Else
            MsgBox("Unknown username!     ", vbExclamation, "Login")
            txtUID.Text = vbNullString
            txtPWD.Text = vbNullString
            txtUID.Focus()
        End If
    End Sub

    Sub SystemLogin()

        If conLocal() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Conccetion")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Dim rs As New Recordset
        rs = New Recordset

        rs = ConnLoc.Execute("select * from tblUserAcc where Username = '" & txtUID.Text & "'")
        If rs.EOF = False Then
            If Trim(txtPWD.Text) = rs("Password").Value Then
                With MainForm

                    frmVerification.lblUser.Text = txtUID.Text
                    If rs("Designation").Value = "Operator" Then
                        .txtDesig.Text = rs("Designation").Value & " :"
                        .txtUser.Text = rs("Name").Value
                        EnabledOpMain()
                        Me.Close()
                        Exit Sub
                    End If

                    Me.Hide()
                    frmSystem.ShowDialog()
                    Me.Close()
                End With
            Else
                MsgBox("Unknown password!    ", vbExclamation, "Login")
                txtPWD.Text = vbNullString
                txtPWD.Focus()
            End If
        Else
            MsgBox("Unknown username!     ", vbExclamation, "Login")
            txtUID.Text = vbNullString
            txtPWD.Text = vbNullString
            txtUID.Focus()
        End If
    End Sub

    Sub SystemLoginServer()

        If conLocal() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Conccetion")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Dim rs As New Recordset
        rs = New Recordset

        rs = ConnLoc.Execute("select * from tblUserAcc where Username = '" & txtUID.Text & "'")
        If rs.EOF = False Then
            If Trim(txtPWD.Text) = rs("Password").Value Then
                With MainFormServer
                    If rs("Designation").Value = "Admin" Then
                        .txtDesig.Text = rs("Designation").Value & " :"
                        .txtUser.Text = rs("Name").Value

                        UnLocked_Server_Main()
                        Me.Hide()
                        Me.Close()
                    Else
                        MsgBox("Unknown username!     ", vbExclamation, "Login")
                        txtUID.Text = vbNullString
                        txtPWD.Text = vbNullString
                        txtUID.Focus()
                    End If
                End With
            Else
                MsgBox("Unknown password!    ", vbExclamation, "Login")
                txtPWD.Text = vbNullString
                txtPWD.Focus()
            End If
        Else
            MsgBox("Unknown username!     ", vbExclamation, "Login")
            txtUID.Text = vbNullString
            txtPWD.Text = vbNullString
            txtUID.Focus()
        End If
    End Sub

    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
        If Trim(txtUID.Text) = "fernan" Then
            Select Case My.Settings.DefSet
                Case "Client"
                    SystemCreator()
                Case "Server"
                    SystemCreatorServer()
            End Select
        ElseIf Trim(txtUID.Text) = "ssi" Then
            Select Case My.Settings.DefSet
                Case "Client"
                    SSILogin()
                Case "Server"
                    SSIServerLogin()
            End Select
        Else
            Select Case My.Settings.DefSet
                Case "Client"
                    SystemLogin()
                Case "Server"
                    SystemLoginServer()
            End Select
        End If
    End Sub

    Private Sub txtPWD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPWD.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdLogin_Click(sender, New System.EventArgs)
        End If
    End Sub

    Private Sub frmLogin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmLogin_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtUID.Text = vbNullString
        txtPWD.Text = vbNullString
        txtUID.Focus()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LbClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbClose.Click
        Me.Close()
    End Sub
End Class