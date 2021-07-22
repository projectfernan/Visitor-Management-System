Imports ADODB
Public Class frmCompany

    Private Sub frmCompany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        lstList.Columns.Add("Company", 250, HorizontalAlignment.Left)
        lstList.Columns.Add("Floor No.", 300, HorizontalAlignment.Left)
        lstList.Columns.Add("ContactPerson", 200, HorizontalAlignment.Left)
        lstList.Columns.Add("ContactNumber", 200, HorizontalAlignment.Left)
    End Sub

    Sub fill()
        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = Conn.Execute("select * from tblCompany")
        txtCnt.Text = rs.RecordCount
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("CompanyName").Value, lup)
                viewlst.SubItems.Add(rs("Address").Value)
                viewlst.SubItems.Add(rs("ContactPerson").Value)
                viewlst.SubItems.Add(rs("ContactNo").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Sub find()
        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = Conn.Execute("select * from tblCompany where " & cboCateg.Text & " like '" & txtKeyword.Text & "%'")
        txtCnt.Text = rs.RecordCount
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("CompanyName").Value, lup)
                viewlst.SubItems.Add(rs("Address").Value)
                viewlst.SubItems.Add(rs("ContactPerson").Value)
                viewlst.SubItems.Add(rs("ContactNo").Value)
                rs.MoveNext()
            Next
        End If
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

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        cmdEdit.Enabled = False
        cmdDel.Enabled = False

        With frmAddCompany
            .Text = "New Company"
            .txtCompany.Enabled = True
            .ShowDialog()
        End With
    End Sub

    Sub Edit()
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                With frmAddCompany
                    .txtCompany.Text = viewlst.SubItems(0).Text
                    .txtAdd.Text = viewlst.SubItems(1).Text
                    .txtContactPerson.Text = viewlst.SubItems(2).Text
                    .txtContactNo.Text = viewlst.SubItems(3).Text
                End With
            End If
        Next
    End Sub

    Sub Delete()
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                If MsgBox("Are you sure do you want to delete this record?    ", vbYesNo + vbQuestion + vbDefaultButton2, "Delete") = vbYes Then
                    Dim rs As New Recordset
                    rs = New Recordset
                    rs = Conn.Execute("delete from tblCompany where CompanyName = '" & viewlst.SubItems(0).Text & "'")
                    MsgBox("Record successfully deleted!    ", vbInformation, "Delete")

                    lstList.Clear()
                    header()
                    fill()
                End If
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
        With frmAddCompany
            .Text = "Update Company"
            .txtCompany.Enabled = False
            .ShowDialog()
        End With
    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Conccetion")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Delete()

    End Sub

    Private Sub cboCateg_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCateg.GotFocus
        cmdEdit.Enabled = False
        cmdDel.Enabled = False
    End Sub
   
    Private Sub cboCateg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCateg.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
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

    Private Sub txtKeyword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKeyword.Click

    End Sub

    Private Sub txtKeyword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKeyword.GotFocus
        cmdEdit.Enabled = False
        cmdDel.Enabled = False
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

    Private Sub lstList_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstList.LostFocus
       
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

    Private Sub cboCateg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCateg.Click

    End Sub
End Class