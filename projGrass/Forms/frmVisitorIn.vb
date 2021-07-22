Imports ADODB
Imports System.Data.OleDb
Public Class frmVisitorIn
    Public recset As Recordset
    Public ClickVer As String
    Dim dtp As New DataTable

    Private Sub frmVisitorIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        disableALL()

        'PicID.Image = Nothing
        'VisPic.Image = Nothing

        If My.Settings.Signature = False Then
            PicSigna.Visible = False
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

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Dim TmeInTo As String = Format(CDate(dtDateTo.Value), "yyyy-MM-dd HH:mm")
        Dim TmeInFrm As String = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd HH:mm")

        Dim qry As String

        Select Case cboREpCateg.Text
            Case "By Date Only"
                qry = "select TimeIn,LogCode,VisitorIdNo,ReferenceIdNo,VisitorName,ContactNo,Floor,UnitToVisit,ContactPerson,Purpose,Tower from tblVisitorin where TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'"
                LoadDgvData(dgRec, qry, True)
                cmdPrint.Enabled = True
            Case "By Visitor Details"
                qry = "select TimeIn,LogCode,VisitorIdNo,ReferenceIdNo,VisitorName,ContactNo,Floor,UnitToVisit,ContactPerson,Purpose,Tower from tblVisitorIn where " & cboSCateg.Text & " like '" & txtKeyword.Text & "%'"
                LoadDgvData(dgRec, qry, True)
                cmdPrint.Enabled = True
            Case "All"
                qry = "select TimeIn,LogCode,VisitorIdNo,ReferenceIdNo,VisitorName,ContactNo,Floor,UnitToVisit,ContactPerson,Purpose,Tower from tblVisitorIn where " & cboSCateg.Text & " like '" & txtKeyword.Text & "%' and TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'"
                LoadDgvData(dgRec, qry, True)
                cmdPrint.Enabled = True
        End Select
    End Sub

    Private Sub cboSCateg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboSCateg.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
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

    Private Sub cmdViewAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ClickVer = vbNullString
        ClickVer = "ViewAll"

    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim viewlst As New ListViewItem
        'For Each viewlst In lstList.Items
        '    If viewlst.Selected = True Then
        '        UpdateIDin(viewlst.SubItems(0).Text)
        '        cmdBrowse.Visible = True
        '        cmdUpdate.Visible = False
        '        MsgBox("Updated successfully!    ", vbInformation, "Update")
        '    End If
        'Next
    End Sub

    Sub BrowsePath()
        OpenPath.Filter = "JPEG Images (*.jpg,*.jpeg)|*.jpg;*.jpeg"
        OpenPath.InitialDirectory = "C:\"
        OpenPath.FileName = vbNullString

        If OpenPath.ShowDialog = Windows.Forms.DialogResult.OK Then
            Path_Scanned_ID = vbNullString
            Path_Scanned_ID = OpenPath.FileName
        End If

        Try
            PicID.Image = Image.FromFile(Path_Scanned_ID)
        Catch
        End Try
    End Sub

    Private Sub cmdBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BrowsePath()
    End Sub

    Private Sub LbClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbClose.Click
        Me.Close()
    End Sub

    Private Sub dgRec_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgRec.MouseUp
        If dgRec.SelectedRows.Count > 0 Then
            Dim lcod As String = dgRec.Item(1, dgRec.CurrentRow.Index).Value
            VisPic.Image = get_imgCam(lcod)
            PicID.Image = get_imgId(lcod)
        End If
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Print()
    End Sub

    Sub Print()

        Dim ReportPath As String = Application.StartupPath & "\Reports\crtVisitorIn.rpt"
        If Not IO.File.Exists(ReportPath) Then
            MsgBox("Cannot load Report file!    ", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            Dim Report As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Report.Load(ReportPath)
            Report.SetDataSource(qrs)
            frmViewPrint.crtPreview.ReportSource = Report
            frmViewPrint.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Print")
        End Try
    End Sub

    Private Sub frmVisitorIn_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class