Module SECURITY_LOGIN
    Public Ver As String
    Public Sub DisabledMain()
        With frmMain
            .GP1.Enabled = False
            .GP2.Enabled = False
            .GP3.Enabled = False

            .cmdNewVis.Enabled = False
            .cmdExitTrans.Enabled = False
            .cmdCancelTrans.Enabled = False
            .cmdSettle.Enabled = False
            .cmdManExit.Enabled = False

            .txtDesig.Text = "System :"
            .txtUser.Text = "LOCK"
        End With
    End Sub

    Public Sub EnabledAdminMain()
        With frmMain
            .GP1.Enabled = True
            .GP2.Enabled = True
            .GP3.Enabled = True

            '.cmdNewVis.Enabled = True

            frmSystem.cmdSystem.Enabled = True
            frmSystem.cmdDatabase.Enabled = True
            frmSystem.cmdAccounts.Enabled = True
            frmSystem.cmdIDtype.Enabled = True
            frmSystem.cmdPrinter.Enabled = True
            frmSystem.cmdTerminate.Enabled = True

            frmCompany.cmdAdd.Enabled = True
            frmCompany.cmdEdit.Enabled = True
            frmCompany.cmdDel.Enabled = True

            FrmHistoryLogs.cmdDel.Enabled = True
        End With
    End Sub

    Public Sub EnabledOpMain()
        With frmMain
            .GP1.Enabled = True
            If My.Settings.WebCam = True Then
                .GP2.Enabled = True
            End If
            .GP3.Enabled = True

            .cmdNewVis.Enabled = True
            .cmdExitTrans.Enabled = True
            .cmdManExit.Enabled = True

            frmSystem.cmdSystem.Enabled = False
            frmSystem.cmdDatabase.Enabled = False
            frmSystem.cmdAccounts.Enabled = False
            frmSystem.cmdIDtype.Enabled = False
            frmSystem.cmdPrinter.Enabled = False
            frmSystem.cmdTerminate.Enabled = False

            frmCompany.cmdAdd.Enabled = False
            frmCompany.cmdEdit.Enabled = False
            frmCompany.cmdDel.Enabled = False

            FrmHistoryLogs.cmdDel.Enabled = False
        End With
    End Sub
End Module
