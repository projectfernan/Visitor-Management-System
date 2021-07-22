Module PIC_LOGS_SETTINGS
    Public Sub viewPicSet()
        With My.Settings
            If .ClearPic = True Then
                Delete_Image()
                frmSystemTitle.chkClearPic.Checked = True
            Else
                frmSystemTitle.chkClearPic.Checked = False
            End If
        End With
    End Sub
End Module
