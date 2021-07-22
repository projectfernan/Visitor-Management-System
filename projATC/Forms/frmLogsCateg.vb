Public Class frmLogsCateg

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmVisitorIn.ShowDialog()
    End Sub

    Private Sub cmdLogs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogs.Click
        FrmHistoryLogs.ShowDialog()
    End Sub
End Class