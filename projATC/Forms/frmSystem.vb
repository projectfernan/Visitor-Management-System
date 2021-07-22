Public Class frmSystem

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTerminate.Click
        If MsgBox("Are you sure do you want to quit?    ", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "System") = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDatabase.Click
        frmConnDB.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCompany.Click
        frmCompany.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccounts.Click
        frmSystemAcc.ShowDialog()
    End Sub

    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSystem.Click
        frmSystemTitle.ShowDialog()
    End Sub

    Private Sub cmdSetPrinter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetPrinter.Click
        frmSetPrinter.ShowDialog()
    End Sub

    Private Sub cmdLogs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogs.Click
        frmLogsCateg.ShowDialog()
    End Sub

    Private Sub cmdIDtype_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIDtype.Click
        frmIDtype.ShowDialog()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrinter.Click
        frmSetPrinter.ShowDialog()
    End Sub

    Private Sub cmdSignature_Click(sender As System.Object, e As System.EventArgs)
        frmSignaPad.ShowDialog()
    End Sub

    Private Sub cmdPurpose_Click(sender As System.Object, e As System.EventArgs) Handles cmdPurpose.Click
        frmPurpose.ShowDialog()
    End Sub
End Class