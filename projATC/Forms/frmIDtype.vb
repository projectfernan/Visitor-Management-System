Imports ADODB
Public Class frmIDtype

    Private Sub frmIDtype_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Add")
            frmConnDB.ShowDialog()
            Exit Sub
        End If


        lstList.Clear()
        header()
        fill()

        cmdDel.Enabled = False
    End Sub

    Sub header()
        lstList.Columns.Add("ID Type", 300, HorizontalAlignment.Left)
    End Sub

    Sub fill()
        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = Conn.Execute("select * from tblIdType")
        txtCnt.Text = rs.RecordCount
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("IDtype").Value, lup)
                rs.MoveNext()
            Next
        End If
    End Sub

    Function chkVtype() As Boolean
        Dim rs As New Recordset
        rs = New Recordset
        rs = Conn.Execute("select * from tblIDtype where IDtype = '" & txtVtype.Text & "'")
        If rs.EOF = False Then
            Return True
        Else
            Return False
        End If
    End Function

    Sub add()
        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from tblIDtype", Conn, 1, 2)
        rs.AddNew()
        rs("IDtype").Value = txtVtype.Text
        rs.Update()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click

        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Add")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        If txtVtype.Text = vbNullString Then
            MsgBox("Please type vehicle type!    ", vbExclamation, "Add")
            Exit Sub
        End If

        If chkVtype() = True Then
            MsgBox("Vehicle already exist!    ", vbExclamation, "Add")
            txtVtype.Text = vbNullString
            txtVtype.Focus()
            Exit Sub
        End If
        add()
        txtVtype.Text = vbNullString
        lstList.Clear()
        header()
        fill()
    End Sub

    Sub del()
        
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                If MsgBox("Are you sure do you want to delete this record?    ", vbYesNo + vbQuestion + vbDefaultButton2, "Delete") = vbYes Then
                    Dim rs As New Recordset
                    rs = New Recordset
                    rs = Conn.Execute("delete from tblIdType where IDtype = '" & viewlst.SubItems(0).Text & "'")
                    MsgBox("Record successfully deleted!    ", vbInformation, "Delete")
                    lstList.Clear()
                    header()
                    fill()
                    txtVtype.Text = vbNullString
                End If
            End If
        Next
    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        del()
    End Sub

    Private Sub lstList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstList.SelectedIndexChanged
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
              
            End If
        Next
    End Sub
End Class