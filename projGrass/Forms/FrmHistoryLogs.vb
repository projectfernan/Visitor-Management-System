Imports ADODB
Public Class FrmHistoryLogs
    Public recset As Recordset
    Public ClickVer As String

    Private Sub FrmHistoryLogs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        Dim TmeInTo As String = Format(CDate(dtDateTo.Value), "yyyy-MM-dd HH:mm")
        Dim TmeInFrm As String = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd HH:mm")

        Dim qry As String

        Select Case cboREpCateg.Text
            Case "By Date Only"
                qry = "select TimeOut,TimeIn,LogCode,VisitorIdNo,ReferenceIdNo,VisitorName,ContactNo,Floor,UnitToVisit,ContactPerson,Purpose,Tower from tblVisitorout where TimeOut >= '" & TmeInFrm & "' and TimeOut <='" & TmeInTo & "'"
                LoadDgvData(dgRec, qry, True)
                cmdPrint.Enabled = True
            Case "By Visitor Details"
                qry = "select TimeOut,TimeIn,LogCode,VisitorIdNo,ReferenceIdNo,VisitorName,ContactNo,Floor,UnitToVisit,ContactPerson,Purpose,Tower from tblVisitorout where " & cboSCateg.Text & " like '" & txtKeyword.Text & "%'"
                LoadDgvData(dgRec, qry, True)
                cmdPrint.Enabled = True
            Case "All"
                qry = "select TimeOut,TimeIn,LogCode,VisitorIdNo,ReferenceIdNo,VisitorName,ContactNo,Floor,UnitToVisit,ContactPerson,Purpose,Tower from tblVisitorout where " & cboSCateg.Text & " like '" & txtKeyword.Text & "%' and TimeOut >= '" & TmeInFrm & "' and TimeOut <='" & TmeInTo & "'"
                LoadDgvData(dgRec, qry, True)
                cmdPrint.Enabled = True
        End Select
    End Sub

    Private Sub cboSCateg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboSCateg.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub
  
    Sub Print()
        Dim ReportPath As String = Application.StartupPath & "\Reports\crtVisitorLogs.rpt"
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

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Print()
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
    End Sub

    Private Sub cmdBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BrowsePath()
    End Sub

    Private Sub LbClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbClose.Click
        Me.Close()
    End Sub

    Private Sub dgRec_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgRec.MouseUp
        If dgRec.SelectedRows.Count > 0 Then
            Dim lcod As String = dgRec.Item(2, dgRec.CurrentRow.Index).Value
            VisPic.Image = get_imgCam(lcod)
            PicID.Image = get_imgId(lcod)
        End If
    End Sub

End Class