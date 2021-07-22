Imports ADODB
Module SYSTEM_NAME
    Sub ViewSystemSet()
        Try
            With MainForm
                .txtStation.Text = My.Settings.Station
                With My.Settings
                    frmSystemTitle.txtOR.Value = .ID_No
                    frmSystemTitle.cboStation.Text = .Station
                End With
            End With
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Save")
        End Try
    End Sub
End Module
