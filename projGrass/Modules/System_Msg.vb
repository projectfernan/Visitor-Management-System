
Module System_Msg
    Public Sub MsgListBox(ByVal msg As String)
        Try
            With MainFormServer
                .lbSysMsg.Items.Add(msg)
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
