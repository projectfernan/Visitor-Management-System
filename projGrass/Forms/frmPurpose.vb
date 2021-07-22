Imports ADODB
Public Class frmPurpose
    Dim idPur As String
    Private Sub frmPurpose_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If conLocal() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Add")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        lstList.Clear()
        header()
        fill()

        cmdDel.Enabled = False
        cmdEdit.Enabled = False

        txtPurpose.Enabled = False
    End Sub

    Sub header()
        Dim w As Integer = lstList.Width
        lstList.Columns.Add("", 0, HorizontalAlignment.Left)
        lstList.Columns.Add("Purpose", w, HorizontalAlignment.Left)
    End Sub

    Sub fill()
        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = ConnLoc.Execute("select * from tblpurpose")
        txtCnt.Text = rs.RecordCount
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("ID").Value, lup)
                viewlst.SubItems.Add(rs("Purpose").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Private Sub cmdAdd_Click(sender As System.Object, e As System.EventArgs) Handles cmdAdd.Click
        If conLocal() = False Then
            MsgBox("Please connect to local database!", vbExclamation, "Add")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Select Case cmdAdd.Text
            Case "&Add"
                txtPurpose.Enabled = True
                txtPurpose.Focus()
                cmdAdd.Text = "&Save"
            Case "&Save"
                If txtPurpose.Text = vbNullString Then
                    MsgBox("Please input purpose!    ", vbExclamation, "Add")
                    Exit Sub
                End If

                If chkPurpose() = True Then
                    MsgBox("Purpose already exist!    ", vbExclamation, "Add")
                    txtPurpose.Text = vbNullString
                    txtPurpose.Focus()
                    Exit Sub
                End If


                add()
                txtPurpose.Text = vbNullString
                lstList.Clear()
                header()
                fill()
                txtPurpose.Enabled = False
                cmdAdd.Text = "&Add"
        End Select

       
    End Sub

    Function chkPurpose() As Boolean
        If conLocal() = False Then
            MsgBox("Please connect to local database!", vbExclamation, "Add")
            frmConnDB.ShowDialog()
            Return False
        End If

        Dim rs As New Recordset
        rs = New Recordset
        rs = ConnLoc.Execute("select * from tblpurpose where Purpose = '" & txtPurpose.Text & "'")
        If rs.EOF = False Then
            Return True
        Else
            Return False
        End If
    End Function

    Sub add()
        If conLocal() = False Then
            MsgBox("Please connect to local database!", vbExclamation, "Add")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from tblpurpose", ConnLoc, 1, 2)
        rs.AddNew()
        rs("Purpose").Value = txtPurpose.Text
        rs.Update()
    End Sub

    Sub edit()
        If conLocal() = False Then
            MsgBox("Please connect to local database!", vbExclamation, "Edit")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from tblpurpose where Id = '" & idPur & "'", ConnLoc, 1, 2)
        rs("Purpose").Value = txtPurpose.Text
        rs.Update()
    End Sub

    Sub del()
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                If MsgBox("Are you sure do you want to delete this record?    ", vbYesNo + vbQuestion + vbDefaultButton2, "Delete") = vbYes Then
                    Dim rs As New Recordset
                    rs = New Recordset
                    rs = ConnLoc.Execute("delete from tblpurpose where Purpose = '" & viewlst.SubItems(1).Text & "'")
                    MsgBox("Record successfully deleted!    ", vbInformation, "Delete")
                    lstList.Clear()
                    header()
                    fill()
                    txtPurpose.Text = vbNullString
                End If
            End If
        Next
    End Sub

    Private Sub lstList_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstList.SelectedIndexChanged
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                txtPurpose.Text = viewlst.SubItems(1).Text
                idPur = viewlst.SubItems(0).Text
                cmdDel.Enabled = True
                cmdEdit.Enabled = True
            End If
        Next
    End Sub

    Private Sub cmdEdit_Click(sender As System.Object, e As System.EventArgs) Handles cmdEdit.Click
        If conLocal() = False Then
            MsgBox("Please connect to local database!", vbExclamation, "Add")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Select Case cmdEdit.Text
            Case "&Edit"
                txtPurpose.Enabled = True
                txtPurpose.Focus()
                cmdEdit.Text = "&Update"
            Case "&Update"
                If txtPurpose.Text = vbNullString Then
                    MsgBox("Please input purpose!    ", vbExclamation, "Add")
                    Exit Sub
                End If

                edit()
                txtPurpose.Text = vbNullString
                lstList.Clear()
                header()
                fill()
                txtPurpose.Enabled = False
                cmdEdit.Text = "&Edit"
        End Select
    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        If conLocal() = False Then
            MessageBox.Show("Please connect to local database!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        del()
    End Sub

    Private Sub LbClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbClose.Click
        Me.Close()
    End Sub
End Class