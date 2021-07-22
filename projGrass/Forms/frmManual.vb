Public Class frmManual

    Private Sub txtCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            ViewEntInfo(txtCode.Text)
            frmExit.cmdAccept.Enabled = True
            Me.Close()
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmManual_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtCode.Text = vbNullString
    End Sub

    Private Sub LbClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbClose.Click
        Me.Close()
    End Sub
End Class