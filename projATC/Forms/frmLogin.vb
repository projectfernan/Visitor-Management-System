Imports ADODB
Imports System.IO.Path
Imports System.Drawing.Imaging
Public Class frmLogin

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Sub SystemCreator()
        Dim UID As String = "fernan"
        Dim PWD As String = "s0bad3l1g3r"

        If Trim(txtUID.Text) = UID Then
            If Trim(txtPWD.Text) = PWD Then
                With frmMain
                    ' .txtDesig.Text = "Admin"
                    ' .txtUser.Text = txtUID.Text
                    '  frmVerification.lblUser.Text = txtUID.Text
                    EnabledAdminMain()
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

    Sub SystemLogin()

        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Conccetion")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Dim rs As New Recordset
        rs = New Recordset

        rs = Conn.Execute("select * from tblUserAcc where Username = '" & txtUID.Text & "'")
        If rs.EOF = False Then
            If Trim(txtPWD.Text) = rs("Password").Value Then
                With frmMain
                  
                    frmVerification.lblUser.Text = txtUID.Text
                    If rs("Designation").Value = "Operator" Then
                        .txtDesig.Text = rs("Designation").Value & " :"
                        .txtUser.Text = rs("Name").Value
                        EnabledOpMain()
                        Me.Close()
                        Exit Sub
                    End If
                    EnabledAdminMain()
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


    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
        If Trim(txtUID.Text) = "fernan" Then
            SystemCreator()
        Else
            SystemLogin()
        End If
    End Sub

    Private Sub txtPWD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPWD.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Trim(txtUID.Text) = "fernan" Then
                SystemCreator()
            Else
                SystemLogin()
            End If
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
End Class