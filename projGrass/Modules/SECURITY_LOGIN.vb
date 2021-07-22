Module SECURITY_LOGIN
    Public Ver As String
    Public Sub DisabledMain()
        With MainForm
            .GP1.Enabled = False

            If My.Settings.Signature = False Then
                .SplitContainer3.Panel2Collapsed = True
            End If

            .btnIDShot.Enabled = False
            .cmdShot.Enabled = False

            .cmdNewVis.Enabled = False
            .cmdExitTrans.Enabled = False
            .cmdCancelTrans.Enabled = False
            .cmdSettle.Enabled = False
            .cmdManExit.Enabled = False
            .btnQvVisEnt.Enabled = False

            .txtDesig.Text = "System :"
            .txtUser.Text = "LOCK"
        End With
    End Sub

    Public Sub EnabledAdminMain()

        frmSystem.cmdDatabase.Enabled = True
        frmSystem.cmdAccounts.Enabled = True
        frmSystem.cmdTerminate.Enabled = True

        frmCompany.cmdAdd.Enabled = True
        frmCompany.cmdEdit.Enabled = True
        frmCompany.cmdDel.Enabled = True
    End Sub

    Public Sub EnabledOpMain()
        With MainForm
            .GP1.Enabled = True

            .cmdNewVis.Enabled = True
            .cmdExitTrans.Enabled = True
            .cmdManExit.Enabled = True
            .btnQvVisEnt.Enabled = True
        End With
    End Sub

    Public Sub Locked_Server_Main()
        With MainFormServer
            .MainPanel.Enabled = False
            .ClientPanel.Enabled = False
        End With
    End Sub

    Public Sub UnLocked_Server_Main()
        With MainFormServer
            .MainPanel.Enabled = True
            .ClientPanel.Enabled = True
        End With
    End Sub
End Module
