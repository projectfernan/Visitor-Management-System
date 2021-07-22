Public Class frmSetPrinter

    Private Sub frmSetPrinter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulateInstalledPrintersCombo(cboDriver)
        With My.Settings
            cboDriver.Text = .PrinterDriver
            chkDisablePrinter.Checked = .PrinterStat
        End With
    End Sub

    Private Sub cboDriver_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboDriver.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Sub saveDriver()
        With My.Settings
            .PrinterDriver = cboDriver.Text
            .Save()
        End With
    End Sub

    Private Sub cmdTest1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTest1.Click
        If cboDriver.Text = vbNullString Then
            MsgBox("Please select printer driver!    ", MsgBoxStyle.Exclamation, "Printer Test")
            Exit Sub
        End If
        saveDriver()

        MsgBox("Printer driver successfully saved!    ", vbInformation, "Save")
        'Print_Ticket()
    End Sub

    Private Sub chkDisablePrinter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDisablePrinter.CheckedChanged
        With My.Settings
            .PrinterStat = chkDisablePrinter.Checked
            .Save()
        End With
    End Sub

    Private Sub LbClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbClose.Click
        Me.Close()
    End Sub
End Class