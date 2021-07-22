Imports ADODB
Public Class frmVerification
    Sub SystemCreator()
        Dim UID As String = "fernan"
        Dim PWD As String = "l1g3rs0bad3"

        If Trim(lblUser.Text) = UID Then
            If Trim(txtPWD.Text) = PWD Then

                If Ver = "Logout" Then
                    If MsgBox("Are you sure do you want to logout?    ", vbQuestion + vbYesNo + vbDefaultButton2) = vbYes Then

                        frmMain.Cleartxt()
                        frmMain.disabledtxt()
                        DisabledMain()
                    End If
                    Me.Close()
                Else
                    frmSystem.ShowDialog()
                    Me.Close()
                End If

            Else
                MsgBox("Unknown password!    ", vbExclamation, "Login")
                txtPWD.Text = vbNullString
                txtPWD.Focus()
            End If
        Else
        
        End If
    End Sub

    Sub SystemLogin()

        Dim rs As New Recordset
        rs = New Recordset

        rs = Conn.Execute("select * from tblUserAcc where Username = '" & lblUser.Text & "'")
        If rs.EOF = False Then
            If Trim(txtPWD.Text) = rs("Password").Value Then
                If Ver = "Logout" Then
                    If MsgBox("Are you sure do you want to logout?    ", vbQuestion + vbYesNo + vbDefaultButton2) = vbYes Then
                        frmMain.Cleartxt()
                        frmMain.disabledtxt()
                        DisabledMain()
                    End If
                    Me.Close()
                ElseIf Ver = "CompanyList" Then
                    Me.Hide()
                    frmCompany.ShowDialog()
                    Me.Close()
                Else
                    Me.Hide()
                    frmSystem.ShowDialog()
                    Me.Close()
                End If
            Else
                MsgBox("Unknown password!    ", vbExclamation, "Login")
                txtPWD.Text = vbNullString
                txtPWD.Focus()
            End If
            Else

            End If
    End Sub

    Private Sub txtTitle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPWD.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Trim(lblUser.Text) = "fernan" Then
                SystemCreator()
            Else
                SystemLogin()
            End If
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmVerification_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtPWD.Text = vbNullString
    End Sub
End Class