Imports ADODB
Public Class FrmHistoryLogs
    Public recset As Recordset
    Public ClickVer As String

    Private Sub FrmHistoryLogs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        disableALL()
        lstList.Clear()
        Header()

        PicID.Image = Nothing
        VisPic.Image = Nothing
    End Sub

    Sub Header()
        lstList.Columns.Clear()
        lstList.Columns.Add("Visitor ID", 120, HorizontalAlignment.Left)
        lstList.Columns.Add("Visitor Name", 300, HorizontalAlignment.Left)
        'lstList.Columns.Add("Reference ID No", 180, HorizontalAlignment.Left)
        ' lstList.Columns.Add("ID Type", 180, HorizontalAlignment.Left)
        lstList.Columns.Add("Time In", 180, HorizontalAlignment.Left)
        lstList.Columns.Add("Time Out", 180, HorizontalAlignment.Left)
        'lstList.Columns.Add("Contact No", 180, HorizontalAlignment.Left)
        'lstList.Columns.Add("Address", 200, HorizontalAlignment.Left)
        lstList.Columns.Add("Company Visited", 200, HorizontalAlignment.Left)
        'lstList.Columns.Add("Contact Person", 180, HorizontalAlignment.Left)
        lstList.Columns.Add("Purpose", 120, HorizontalAlignment.Left)
        lstList.Columns.Add("Type", 120, HorizontalAlignment.Left)
        lstList.Columns.Add("RefNo", 120, HorizontalAlignment.Left)
    End Sub

    Sub ViewAll()
        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Conccetion")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        On Error Resume Next
        Dim lup As Short
        'Dim rs As New Recordset
        recset = New Recordset
        recset = Conn.Execute("select * from tblVisitorOut")
        If recset.EOF = False Then

            cmdPrint.Enabled = True
            cmdDel.Enabled = True

            For lup = 1 To recset.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(recset("VisitorID").Value, lup)
                viewlst.SubItems.Add(recset("VisitorName").Value)
                'viewlst.SubItems.Add(recset("ReferenceIDNo").Value)
                ' viewlst.SubItems.Add(recset("IDType").Value)
                viewlst.SubItems.Add(recset("TimeIn").Value)
                viewlst.SubItems.Add(recset("TimeOut").Value)
                'viewlst.SubItems.Add(recset("ContactNo").Value)
                viewlst.SubItems.Add(recset("CompanyVisited").Value)
                'viewlst.SubItems.Add(recset("ContactPerson").Value)
                viewlst.SubItems.Add(recset("Purpose").Value)
                viewlst.SubItems.Add(recset("Type").Value)
                viewlst.SubItems.Add(recset("RefNo").Value)
                recset.MoveNext()
            Next
        Else
            MsgBox("No record found!    ", vbExclamation, "View All")
            cmdPrint.Enabled = False
            cmdDel.Enabled = False
        End If
    End Sub

    Sub SearchByDate()
        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Conccetion")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Dim lup As Short
        Dim TmeInTo As String
        Dim TmeInFrm As String

        TmeInFrm = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd HH:mm:ss")
        TmeInTo = Format(CDate(dtDateTo.Value), "yyyy-MM-dd HH:mm:ss")
        'Dim rs As New Recordset
        recset = New Recordset
        recset = Conn.Execute("select * from tblVisitorOut where TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
        If recset.EOF = False Then
            cmdPrint.Enabled = True
            cmdDel.Enabled = True
            For lup = 1 To recset.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(recset("VisitorID").Value, lup)
                viewlst.SubItems.Add(recset("VisitorName").Value)
                'viewlst.SubItems.Add(recset("ReferenceIDNo").Value)
                'viewlst.SubItems.Add(recset("IDType").Value)
                viewlst.SubItems.Add(recset("TimeIn").Value)
                viewlst.SubItems.Add(recset("TimeOut").Value)
                'viewlst.SubItems.Add(recset("ContactNo").Value)
                'viewlst.SubItems.Add(recset("Address").Value)
                viewlst.SubItems.Add(recset("CompanyVisited").Value)
                'viewlst.SubItems.Add(recset("ContactPerson").Value)
                viewlst.SubItems.Add(recset("Purpose").Value)
                viewlst.SubItems.Add(recset("Type").Value)
                viewlst.SubItems.Add(recset("RefNo").Value)
                recset.MoveNext()
            Next
        Else
            MsgBox("No record found!    ", vbExclamation, "Search")
            cmdPrint.Enabled = False
            cmdDel.Enabled = False
        End If
    End Sub

    Sub SearchByAll()
        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Conccetion")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Dim lup As Short
        Dim TmeInTo As String
        Dim TmeInFrm As String

        TmeInFrm = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd HH:mm:ss")
        TmeInTo = Format(CDate(dtDateTo.Value), "yyyy-MM-dd HH:mm:ss")

        'Dim rs As New Recordset
        recset = New Recordset
        recset = Conn.Execute("select * from tblVisitorOut where " & cboSCateg.Text & " like '" & txtKeyword.Text & "%' and TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
        If recset.EOF = False Then
            cmdPrint.Enabled = True
            cmdDel.Enabled = True
            For lup = 1 To recset.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(recset("VisitorID").Value, lup)
                viewlst.SubItems.Add(recset("VisitorName").Value)
                'viewlst.SubItems.Add(recset("ReferenceIDNo").Value)
                'viewlst.SubItems.Add(recset("IDType").Value)
                viewlst.SubItems.Add(recset("TimeIn").Value)
                viewlst.SubItems.Add(recset("TimeOut").Value)
                'viewlst.SubItems.Add(recset("ContactNo").Value)
                'viewlst.SubItems.Add(recset("Address").Value)
                viewlst.SubItems.Add(recset("CompanyVisited").Value)
                'viewlst.SubItems.Add(recset("ContactPerson").Value)
                viewlst.SubItems.Add(recset("Purpose").Value)
                viewlst.SubItems.Add(recset("Type").Value)
                viewlst.SubItems.Add(recset("RefNo").Value)
                recset.MoveNext()
            Next
        Else
            MsgBox("No record found!    ", vbExclamation, "Search")
            cmdPrint.Enabled = False
            cmdDel.Enabled = False
        End If
    End Sub

    Sub SearchByVisitorsDetails()
        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Conccetion")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Dim lup As Short

        'Dim rs As New Recordset
        recset = New Recordset
        recset = Conn.Execute("select * from tblVisitorOut where " & cboSCateg.Text & " like '" & txtKeyword.Text & "%'")
        If recset.EOF = False Then
            cmdPrint.Enabled = True
            cmdDel.Enabled = True
            For lup = 1 To recset.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(recset("VisitorID").Value, lup)
                viewlst.SubItems.Add(recset("VisitorName").Value)
                'viewlst.SubItems.Add(recset("ReferenceIDNo").Value)
                'viewlst.SubItems.Add(recset("IDType").Value)
                viewlst.SubItems.Add(recset("TimeIn").Value)
                viewlst.SubItems.Add(recset("TimeOut").Value)
                'viewlst.SubItems.Add(recset("ContactNo").Value)
                'viewlst.SubItems.Add(recset("Address").Value)
                viewlst.SubItems.Add(recset("CompanyVisited").Value)
                'viewlst.SubItems.Add(recset("ContactPerson").Value)
                viewlst.SubItems.Add(recset("Purpose").Value)
                viewlst.SubItems.Add(recset("Type").Value)
                viewlst.SubItems.Add(recset("RefNo").Value)
                recset.MoveNext()
            Next
        Else
            MsgBox("No record found!    ", vbExclamation, "Search")
            cmdPrint.Enabled = False
            cmdDel.Enabled = False
        End If
    End Sub

    Sub disableALL()
        cboSCateg.Enabled = False
        txtKeyword.Enabled = False
        dtDateFrm.Enabled = False
        dtDateTo.Enabled = False
        cmdSearch.Enabled = False
    End Sub

    Sub ByDate()
        dtDateFrm.Enabled = True
        dtDateTo.Enabled = True
        cboSCateg.Enabled = False
        txtKeyword.Enabled = False
        cmdSearch.Enabled = True
    End Sub

    Sub ByVisitorsDetails()
        dtDateFrm.Enabled = False
        dtDateTo.Enabled = False
        cboSCateg.Enabled = True
        txtKeyword.Enabled = True
        cmdSearch.Enabled = True
    End Sub

    Sub enbleALL()
        cboSCateg.Enabled = True
        txtKeyword.Enabled = True
        dtDateFrm.Enabled = True
        dtDateTo.Enabled = True
        cmdSearch.Enabled = True
    End Sub


    Private Sub cboREpCateg_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboREpCateg.SelectedIndexChanged
        Select Case cboREpCateg.Text
            Case "By Date Only"
                ByDate()
            Case "By Visitor Details"
                ByVisitorsDetails()
            Case "All"
                enbleALL()
        End Select
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        ClickVer = vbNullString
        ClickVer = "Search"

        Select Case cboREpCateg.Text
            Case "By Date Only"
                lstList.Clear()
                Header()
                SearchByDate()
                
            Case "By Visitor Details"
                lstList.Clear()
                Header()
                SearchByVisitorsDetails()
                
            Case "All"
                lstList.Clear()
                Header()
                SearchByAll()
               
        End Select
    End Sub

    Private Sub cboSCateg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboSCateg.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub
    Sub slct()
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                VisPic.Image = Visitor_Pic(viewlst.SubItems(0).Text)
                PicID.Image = Visitor_ID_Pic(viewlst.SubItems(0).Text)
                PicSigna.Image = Visitor_ID_OutSigna(viewlst.SubItems(0).Text)
            End If
        Next
    End Sub
    Private Sub lstList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstList.SelectedIndexChanged
        slct()
    End Sub

    Private Sub cmdViewAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewAll.Click
        ClickVer = vbNullString
        ClickVer = "ViewAll"

        lstList.Clear()
        Header()
        ViewAll()
        
    End Sub

    Sub Print()

        Dim ReportPath As String = Application.StartupPath & "\Reports\CrVisitorLogs.rpt"
        If Not IO.File.Exists(ReportPath) Then
            MsgBox("Cannot load Report file!    ", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            Dim Report As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Report.Load(ReportPath)
            Report.SetDataSource(recset)
            frmViewPrint.crtPreview.ReportSource = Report
            frmViewPrint.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Print")
        End Try

        'MsgBox("No Record Found!    ", MsgBoxStyle.Exclamation, "Print")

    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Print()
    End Sub

    Sub DeleteAll()

        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Conccetion")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Dim rs As New Recordset
        rs = New Recordset
        rs = Conn.Execute("delete from tblVisitorout")
        MsgBox("Susccesfully deleted!    ", vbInformation, "Delete")
    End Sub

    Sub DeleteByDate()

        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Conccetion")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Dim TmeInTo As String
        Dim TmeInFrm As String

        TmeInFrm = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd HH:mm:ss")
        TmeInTo = Format(CDate(dtDateTo.Value), "yyyy-MM-dd HH:mm:ss")

        Dim rs As New Recordset
        rs = New Recordset
        rs = Conn.Execute("delete from tblVisitorOut where TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
        MsgBox("Susccesfully deleted!    ", vbInformation, "Delete")
    End Sub

    Sub DeleteByVisitorDetails()

        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Conccetion")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Dim rs As New Recordset
        rs = New Recordset
        rs = Conn.Execute("delete from tblVisitorOut where " & cboSCateg.Text & " like '" & txtKeyword.Text & "%'")
        MsgBox("Susccesfully deleted!    ", vbInformation, "Delete")
    End Sub

    Sub DeleteByAll()

        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Conccetion")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Dim TmeInTo As String
        Dim TmeInFrm As String

        TmeInFrm = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd HH:mm:ss")
        TmeInTo = Format(CDate(dtDateTo.Value), "yyyy-MM-dd HH:mm:ss")

        Dim rs As New Recordset
        rs = New Recordset
        rs = Conn.Execute("delete from tblVisitorOut where " & cboSCateg.Text & " like '" & txtKeyword.Text & "%' and TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
        MsgBox("Susccesfully deleted!    ", vbInformation, "Delete")
    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        If MsgBox("Are you sure do you want to delete this records?    ", vbYesNo + vbQuestion + vbDefaultButton2, "Delete") = vbYes Then

            If ClickVer = "ViewAll" Then
                DeleteAll()
                lstList.Clear()
                Header()
                cmdPrint.Enabled = False
                cmdDel.Enabled = False

            Else
                Select Case cboREpCateg.Text
                    Case "By Date Only"
                        DeleteByDate()
                        lstList.Clear()
                        Header()

                        cmdPrint.Enabled = False
                        cmdDel.Enabled = False
                    Case "By Visitor Details"
                        DeleteByVisitorDetails()
                        lstList.Clear()
                        Header()

                        cmdPrint.Enabled = False
                        cmdDel.Enabled = False
                    Case "All"
                        DeleteByAll()
                        lstList.Clear()
                        Header()

                        cmdPrint.Enabled = False
                        cmdDel.Enabled = False
                End Select
            End If
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicID.Click

    End Sub

    Private Sub VisPic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VisPic.Click

    End Sub

    Sub BrowsePath()
        OpenPath.Filter = "JPEG Images (*.jpg,*.jpeg)|*.jpg;*.jpeg"
        OpenPath.InitialDirectory = "C:\"
        OpenPath.FileName = vbNullString

        If OpenPath.ShowDialog = Windows.Forms.DialogResult.OK Then
            Path_Scanned_ID = vbNullString
            Path_Scanned_ID = OpenPath.FileName
        End If

        PicID.Image = Image.FromFile(Path_Scanned_ID)

        cmdBrowse.Visible = False
        cmdUpdate.Visible = True
    End Sub

    Private Sub cmdBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowse.Click
        BrowsePath()
    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                UpdateIDout(viewlst.SubItems(0).Text)
                cmdBrowse.Visible = True
                cmdUpdate.Visible = False
                MsgBox("Updated successfully!    ", vbInformation, "Update")
            End If
        Next
    End Sub
End Class