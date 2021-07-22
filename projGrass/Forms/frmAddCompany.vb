Imports ADODB
Public Class frmAddCompany
    Sub Save()
        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from tblCompany", ConnLoc, 1, 2)
        rs.AddNew()
        rs("CompanyName").Value = txtCompany.Text
        rs("Address").Value = cboFloor.Text
        rs("ContactPerson").Value = txtContactPerson.Text
        rs("ContactNo").Value = txtContactNo.Text
        rs.Update()
        MsgBox("New Company succeesfully added!    ", vbInformation, "Save")
        Me.Close()
    End Sub

    Sub SaveResi()
        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from tblunits", ConnLoc, 1, 2)
        rs.AddNew()
        rs("Tower").Value = cboTower.Text
        rs("UnitNo").Value = txtCompany.Text
        rs("Floor").Value = cboFloor.Text
        rs("ContactPerson").Value = txtContactPerson.Text
        rs("ContactNo").Value = txtContactNo.Text
        rs.Update()
        MsgBox("New unit succeesfully added!    ", vbInformation, "Save")
        Me.Close()
    End Sub

    Sub Edit()
        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from tblCompany where CompanyName = '" & txtCompany.Text & "'", ConnLoc, 1, 2)
        rs("Address").Value = cboFloor.Text
        rs("ContactPerson").Value = txtContactPerson.Text
        rs("ContactNo").Value = txtContactNo.Text
        rs.Update()
        MsgBox("Company succeesfully updated!    ", vbInformation, "Update")
        Me.Close()
    End Sub

    Sub EditResi()
        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from tblunits where UnitNo = '" & txtCompany.Text & "'", ConnLoc, 1, 2)
        rs("Tower").Value = cboTower.Text
        rs("FLoor").Value = cboFloor.Text
        rs("ContactPerson").Value = txtContactPerson.Text
        rs("ContactNo").Value = txtContactNo.Text
        rs.Update()
        MsgBox("Unit succeesfully updated!    ", vbInformation, "Update")
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If conLocal() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Conccetion")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        If chkBlank() Then
            Exit Sub
        End If

        If lbTitle.Text = "     New Unit" Then
            If MsgBox("Are you sure your entries are correct?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Save") = vbYes Then
                SaveResi()
            End If
        Else
            If MsgBox("Are you sure do you want save changes?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Update") = vbYes Then
                EditResi()
            End If
        End If
    End Sub

    Function chkBlank() As Boolean
        If txtCompany.Text = vbNullString Or cboFloor.Text = vbNullString Or txtContactPerson.Text = vbNullString Or txtContactNo.Text = vbNullString Then
            MsgBox("Please don't leave a blank!", vbExclamation, "Save")
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub txtContactNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContactNo.KeyPress
        If Asc(e.KeyChar) >= 58 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 44 And Asc(e.KeyChar) <> 45 Then
            e.KeyChar = vbNullString
        End If
        If Asc(e.KeyChar) <= 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 44 And Asc(e.KeyChar) <> 45 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frmAddCompany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If lbTitle.Text = "     New Unit" Then
            txtCompany.Text = vbNullString
            cboFloor.Text = vbNullString
            txtContactPerson.Text = vbNullString
            txtContactNo.Text = vbNullString
            txtCompany.Focus()
        End If
    End Sub

    Private Sub txtAdd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboFloor.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbClose.Click
        Me.Close()
    End Sub

    Private Sub cboTower_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboTower.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub
End Class