Module PING_CONFIG
    Public Function PingMe(ByVal IPaddress As String) As Boolean
        Try
            If IPaddress = vbNullString Then Return False

            If My.Computer.Network.IsAvailable = False Then
                MsgListBox("No network is available or network cable is unplug.")
                Return False
            End If

            If My.Computer.Network.Ping(IPaddress, 500) = False Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MsgListBox("Ping Error: " & ex.Message)
            Return False
        End Try
    End Function
End Module
