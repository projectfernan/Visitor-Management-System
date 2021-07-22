Module ADDRESS_SETTINGS
    Public Sub viewAddressSet()
        With My.Settings
            If .CheckAddress = True Then
                frmSystemTitle.chkAddress.Checked = True
                frmMain.lblAdd.Visible = True
                frmMain.txtAddress.Visible = True
            Else
                frmSystemTitle.chkAddress.Checked = False
                frmMain.lblAdd.Visible = False
                frmMain.txtAddress.Visible = False
            End If
        End With
    End Sub
End Module
