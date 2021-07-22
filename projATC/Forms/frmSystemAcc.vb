Imports ADODB
Public Class frmSystemAcc

    Private Sub frmSystemAcc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Conccetion")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        lstList.Clear()
        header()
        fill()

        cmdEdit.Enabled = False
        cmdDel.Enabled = False
    End Sub

    Sub header()
        lstList.Columns.Add("Username", 180, HorizontalAlignment.Left)
        lstList.Columns.Add("Name", 250, HorizontalAlignment.Left)
        lstList.Columns.Add("Designation", 150, HorizontalAlignment.Left)
        lstList.Columns.Add("", 0, HorizontalAlignment.Left)
    End Sub

    Sub fill()
        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = Conn.Execute("select * from tblUserAcc")
        txtcnt.Text = rs.RecordCount
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("Username").Value, lup)
                viewlst.SubItems.Add(rs("Name").Value)
                viewlst.SubItems.Add(rs("Designation").Value)
                viewlst.SubItems.Add(rs("Password").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Sub find()
        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = Conn.Execute("select * from tblUserAcc where " & cboCateg.Text & " like '" & txtKeyword.Text & "%'")
        txtCnt.Text = rs.RecordCount
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("Username").Value, lup)
                viewlst.SubItems.Add(rs("Name").Value)
                viewlst.SubItems.Add(rs("Designation").Value)
                viewlst.SubItems.Add(rs("Password").Value)
                rs.MoveNext()
            Next
        End If
    End Sub


    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        cmdEdit.Enabled = False
        cmdDel.Enabled = False

        With frmAddSystemAcc
            .Text = "New Account"
            .txtUID.Enabled = True
            .txtUID.Focus()
            .ShowDialog()
        End With
    End Sub

    Sub Edit()
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                With frmAddSystemAcc
                    .txtUID.Text = viewlst.SubItems(0).Text
                    .txtPWD.Text = viewlst.SubItems(3).Text
                    .txtConfirm.Text = viewlst.SubItems(3).Text
                    .txtName.Text = viewlst.SubItems(1).Text
                    .cboDesig.Text = viewlst.SubItems(2).Text
                End With
            End If
        Next
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Conccetion")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Edit()
        With frmAddSystemAcc
            .Text = "Update Account"
            .txtUID.Enabled = False
            .txtPWD.Focus()
            .ShowDialog()
        End With
    End Sub


    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        cmdEdit.Enabled = False
        cmdDel.Enabled = False

        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Conccetion")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        lstList.Clear()
        header()
        fill()
    End Sub

    Private Sub cboCateg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCateg.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub txtKeyword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKeyword.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdEdit.Enabled = False
            cmdDel.Enabled = False

            If conServer() = False Then
                MsgBox("Please connect to database!    ", vbExclamation, "Database Conccetion")
                frmConnDB.ShowDialog()
                Exit Sub
            End If

            lstList.Clear()
            header()
            find()
        End If
    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        cmdEdit.Enabled = False
        cmdDel.Enabled = False

        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Conccetion")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        lstList.Clear()
        header()
        find()
    End Sub

    Sub Delete()
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                If MsgBox("Are you sure do you want to delete this record?    ", vbYesNo + vbQuestion + vbDefaultButton2, "Delete") = vbYes Then
                    Dim rs As New Recordset
                    rs = New Recordset
                    rs = Conn.Execute("delete from tblUserAcc where Username = '" & viewlst.SubItems(0).Text & "'")
                    MsgBox("Record successfully deleted!    ", vbInformation, "Delete")

                    lstList.Clear()
                    header()
                    fill()
                End If
            End If
        Next
    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Conccetion")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Delete()
    End Sub

    Private Sub lstList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstList.SelectedIndexChanged
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                cmdEdit.Enabled = True
                cmdDel.Enabled = True
            End If
        Next
    End Sub

    Private Sub cboCateg_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCateg.SelectedIndexChanged

    End Sub
End Class