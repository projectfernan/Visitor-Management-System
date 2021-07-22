Public Class frmER302

    Private Sub LbClose_Click(sender As System.Object, e As System.EventArgs) Handles LbClose.Click
        My.Settings.ER302Com = CInt(Replace(cboPort.Text, "COM", ""))
        My.Settings.Save()

        Me.Close()
    End Sub

    Sub get_serial()
        Dim a As String = vbNullString
        cboPort.Items.Clear()
        For Each a In My.Computer.Ports.SerialPortNames
            cboPort.Items.Add(a)
        Next
    End Sub

    Private Sub frmER302_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        get_serial()
    End Sub
End Class