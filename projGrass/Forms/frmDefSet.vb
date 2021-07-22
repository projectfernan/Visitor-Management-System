Public Class frmDefSet

    Private Sub lstEnv_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstEnv.SelectedIndexChanged
        Dim i As Integer = 0
        Dim item(lstEnv.SelectedItems.Count - 1) As String

        For Each item(i) In lstEnv.SelectedItems
            Select Case item(i)
                Case "Client Software"
                    lbDesc.Text = "Environment settings for client side."
                Case "Server Software"
                    lbDesc.Text = "Environment settings for server side."
            End Select
        Next
    End Sub

    Private Sub LbClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbClose.Click
        Me.Close()
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        saveDefSet()
        loadDefSet()
    End Sub

    Sub saveDefSet()
        With My.Settings
            Select Case lbDesc.Text
                Case "Environment settings for client side."
                    .DefSet = "Client"
                    .Save()
                Case "Environment settings for server side."
                    .DefSet = "Server"
                    .Save()
            End Select
        End With
    End Sub

    Private Sub frmDefSet_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadDefSet()
    End Sub

    Sub loadDefSet()
        Select Case My.Settings.DefSet
            Case "Client"
                Me.Hide()
                MainForm.ShowDialog()
                Me.Close()
            Case "Server"
                Me.Hide()
                MainFormServer.ShowDialog()
                Me.Close()
        End Select
    End Sub
End Class