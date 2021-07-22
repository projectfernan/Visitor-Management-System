Imports ADODB
Public Class frmManExit
    Public recset As Recordset

    Private Sub cmdViewAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lstList.Clear()
        Header()
        ViewAll()
    End Sub

   

    Sub ViewAll()
        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Conccetion")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        On Error Resume Next
        Dim lup As Short

        recset = New Recordset
        recset = Conn.Execute("select * from tblVisitorin")
        If recset.EOF = False Then
            For lup = 1 To recset.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(recset("ID").Value, lup)
                viewlst.SubItems.Add(recset("VisitorName").Value)
                viewlst.SubItems.Add(recset("TimeIn").Value)
                viewlst.SubItems.Add(recset("CompanyVisited").Value)
                viewlst.SubItems.Add(recset("Purpose").Value)
                viewlst.SubItems.Add(recset("Barcode").Value)
                recset.MoveNext()
            Next
        Else
            MsgBox("No record found!    ", vbExclamation, "View All")
        End If
    End Sub

    Sub Header()
        lstList.Columns.Clear()
        lstList.Columns.Add("", 0, HorizontalAlignment.Left)
        lstList.Columns.Add("TimeIn", 180, HorizontalAlignment.Left)
        lstList.Columns.Add("VisitorIdNo", 180, HorizontalAlignment.Left)
        lstList.Columns.Add("Visitor Name", 400, HorizontalAlignment.Left)
        lstList.Columns.Add("ReferenceIdNo", 180, HorizontalAlignment.Left)
        lstList.Columns.Add("UnitToVisit", 120, HorizontalAlignment.Left)
        lstList.Columns.Add("Purpose", 120, HorizontalAlignment.Left)
        lstList.Columns.Add("Tower", 120, HorizontalAlignment.Left)
    End Sub

    Sub SearchByVisitorsDetails()
        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Conccetion")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Dim lup As Short

        recset = New Recordset
        recset = Conn.Execute("select LogCode,TimeIn,VisitorIdNo,VisitorName,ReferenceIdNo,UnitToVisit,Floor,Purpose,Tower from tblVisitorIn where " & cboSCateg.Text & " like '" & txtKeyword.Text & "%'")
        If recset.EOF = False Then
            Dim dtIn As String = Format(CDate(recset("TimeIn").Value), "yyyy-MM-dd HH:mm")
            For lup = 1 To recset.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(recset("LogCode").Value, lup)
                viewlst.SubItems.Add(dtin)
                viewlst.SubItems.Add(recset("VisitorIdNo").Value)
                viewlst.SubItems.Add(recset("VisitorName").Value)
                viewlst.SubItems.Add(recset("ReferenceIdNo").Value)
                viewlst.SubItems.Add(recset("UnitToVisit").Value & "-" & recset("Floor").Value)
                viewlst.SubItems.Add(recset("Purpose").Value)
                viewlst.SubItems.Add(recset("Tower").Value)
                recset.MoveNext()
            Next
        Else
            MsgBox("No record found!    ", vbExclamation, "Search")
        End If
    End Sub

    Private Sub cmdSearch_Click(sender As System.Object, e As System.EventArgs) Handles cmdSearch.Click
        lstList.Clear()
        Header()
        SearchByVisitorsDetails()

        VisPic.Image = Nothing
        PicID.Image = Nothing
    End Sub

    Sub slct()
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                VisPic.Image = get_imgCam(viewlst.SubItems(0).Text)
                PicID.Image = get_imgId(viewlst.SubItems(0).Text)

                Vis_BarCod = viewlst.SubItems(5).Text
            End If
        Next
    End Sub

    Private Sub lstList_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstList.SelectedIndexChanged
        slct()
    End Sub

    Private Sub frmManExit_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call cmdSearch_Click(sender, New System.EventArgs)
        End If

        'If e.KeyCode = Keys.Then Then
        '    Call cmdAccept_Click(sender, New System.EventArgs)
        'End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmManExit_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lstList.Clear()
        Header()

        VisPic.Image = Nothing
        PicID.Image = Nothing
    End Sub

    Private Sub LbClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbClose.Click
        Me.Close()
    End Sub

    Private Sub cmdAccept_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccept.Click
        If MessageBox.Show("Are you sure that you identified the visitor record?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim viewlst As New ListViewItem
            For Each viewlst In lstList.Items
                If viewlst.Selected = True Then
ret:                If frmExit.SAVE_Exit_SERVER(viewlst.SubItems(2).Text) = False Then
                        MessageBox.Show("Failed to settle transaction!", "Verify", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        If MessageBox.Show("Retry?", "Verify", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                            GoTo ret
                        End If
                        Exit Sub
                    End If

                    MessageBox.Show("Exit transaction is successfully settled!", "Exit Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmExit.delEnt(viewlst.SubItems(2).Text)
                    Me.Close()
                End If
            Next
        End If
    End Sub
End Class