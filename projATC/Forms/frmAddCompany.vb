Imports ADODB
Public Class frmAddCompany
    Sub Save()
        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from tblCompany", Conn, 1, 2)
        rs.AddNew()
        rs("CompanyName").Value = txtCompany.Text
        rs("Address").Value = txtAdd.Text
        rs("ContactPerson").Value = txtContactPerson.Text
        rs("ContactNo").Value = txtContactNo.Text
        rs.Update()
        MsgBox("New Company succeesfully added!    ", vbInformation, "Save")
        Me.Close()
    End Sub

    Sub Edit()
        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from tblCompany where CompanyName = '" & txtCompany.Text & "'", Conn, 1, 2)
        rs("Address").Value = txtAdd.Text
        rs("ContactPerson").Value = txtContactPerson.Text
        rs("ContactNo").Value = txtContactNo.Text
        rs.Update()
        MsgBox("Company succeesfully updated!    ", vbInformation, "Update")
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Conccetion")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        If Me.Text = "New Company" Then
            If MsgBox("Are you sure your entries are correct?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Save") = vbYes Then
                Save()
            End If
        Else
            If MsgBox("Are you sure do you want save changes?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Update") = vbYes Then
                Edit()
            End If
        End If
    End Sub

    Private Sub txtContactNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContactNo.KeyPress
        If Asc(e.KeyChar) >= 58 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 44 And Asc(e.KeyChar) <> 45 Then
            e.KeyChar = vbNullString
        End If
        If Asc(e.KeyChar) <= 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 44 And Asc(e.KeyChar) <> 45 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub frmAddCompany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.Text = "New Company" Then
            txtCompany.Text = vbNullString
            txtAdd.Text = vbNullString
            txtContactPerson.Text = vbNullString
            txtContactNo.Text = vbNullString
        End If
    End Sub

    Private Sub txtAdd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAdd.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub txtAdd_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdd.SelectedIndexChanged

    End Sub
End Class