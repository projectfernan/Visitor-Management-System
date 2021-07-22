Imports ADODB
Public Class frmAddSystemAcc

    Private Sub frmAddSystemAcc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Sub Save()
        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from tblUserAcc", ConnLoc, 1, 2)
        rs.AddNew()
        rs("Username").Value = txtUID.Text
        rs("Password").Value = txtPWD.Text
        rs("Name").Value = txtName.Text
        rs("Designation").Value = cboDesig.Text
        rs.Update()
        MsgBox("New Company succeesfully added!    ", vbInformation, "Save")
        Me.Close()
    End Sub

    Sub Edit()
        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from tblUserAcc where Username = '" & txtUID.Text & "'", ConnLoc, 1, 2)
        rs("Password").Value = txtPWD.Text
        rs("Name").Value = txtName.Text
        rs("Designation").Value = cboDesig.Text
        rs.Update()
        MsgBox("Company succeesfully updated!    ", vbInformation, "Update")
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If conLocal() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Conccetion")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        If lbTitle.Text = "      New Account" Then
            If MsgBox("Are you sure your entries are correct?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Save") = vbYes Then
                Save()
            End If
        Else
            If MsgBox("Are you sure do you want save changes?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Update") = vbYes Then
                Edit()
            End If
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub cboDesig_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboDesig.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub frmAddSystemAcc_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If lbTitle.Text = "      New Account" Then
            txtUID.Text = vbNullString
            txtPWD.Text = vbNullString
            txtConfirm.Text = vbNullString
            txtName.Text = vbNullString
            cboDesig.Text = vbNullString
            txtUID.Focus()
        End If
    End Sub

    Private Sub LbClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbClose.Click
        Me.Close()
    End Sub

    Private Sub txtPWD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPWD.TextChanged

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtConfirm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConfirm.TextChanged

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtUID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUID.TextChanged

    End Sub

    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub cboDesig_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDesig.SelectedIndexChanged

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class