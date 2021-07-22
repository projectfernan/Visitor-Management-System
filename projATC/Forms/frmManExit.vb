Imports ADODB
Public Class frmManExit
    Public recset As Recordset

    Private Sub cmdViewAll_Click(sender As System.Object, e As System.EventArgs) Handles cmdViewAll.Click
        lstList.Clear()
        Header()
        ViewAll()
    End Sub

    Sub Header()
        lstList.Columns.Clear()
        lstList.Columns.Add("ID", 120, HorizontalAlignment.Left)
        lstList.Columns.Add("Visitor Name", 400, HorizontalAlignment.Left)
        lstList.Columns.Add("Time In", 180, HorizontalAlignment.Left)
        lstList.Columns.Add("Company Visited", 300, HorizontalAlignment.Left)
        lstList.Columns.Add("Purpose", 120, HorizontalAlignment.Left)
        lstList.Columns.Add("", 0, HorizontalAlignment.Left)
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

    Sub SearchByVisitorsDetails()
        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Conccetion")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Dim lup As Short

        recset = New Recordset
        recset = Conn.Execute("select * from tblVisitorIn where " & cboSCateg.Text & " like '" & txtKeyword.Text & "%'")
        If recset.EOF = False Then
            For lup = 1 To recset.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(recset("ID").Value, lup)
                viewlst.SubItems.Add(recset("VisitorName").Value)
                viewlst.SubItems.Add(recset("TimeIn").Value)
                viewlst.SubItems.Add(recset("CompanyVisited").Value)
                viewlst.SubItems.Add(recset("Purpose").Value)
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
    End Sub

    Sub slct()
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                VisPic.Image = Visitor_PicIn(viewlst.SubItems(0).Text)
                PicID.Image = Visitor_PicIn_ID(viewlst.SubItems(0).Text)

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

        If e.KeyCode = Keys.F1 Then
            Call cmdAccept_Click(sender, New System.EventArgs)
        End If

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

    Private Sub cmdAccept_Click(sender As System.Object, e As System.EventArgs) Handles cmdAccept.Click
        frmRefNo.ShowDialog()
        Me.Close()
    End Sub
End Class