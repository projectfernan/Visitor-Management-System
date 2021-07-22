Module ID_No
    Public Manual_IDno As String = vbNullString

    Public Function Count_ID_No() As String

        Dim Ticket As String = My.Settings.ID_No
        Dim x As Integer = 1

        If Ticket.Length > 10 Then

            For x = 1 To 100
                Dim ss As String = "Station " & x
                If ss = My.Settings.Station Then
                    Exit For
                End If
            Next
            Return x.ToString & "-" & Ticket
        Else

            If Ticket = 0 Then Ticket = 1

            Dim i As Integer = 8 - Ticket.Length
            Dim Nticket As String = New String("0", i)

            For x = 1 To 100
                Dim ss As String = "Station " & x
                If ss = My.Settings.Station Then
                    Exit For
                End If
            Next

            Return x.ToString & "-" & Nticket & Ticket
        End If

    End Function

    Public Sub Update_ID()
        Dim i As Long = My.Settings.ID_No
        Dim s As Long = i + 1
        My.Settings.ID_No = s
        My.Settings.Save()
    End Sub

    Public Sub Restore_ID()
        With My.Settings
            My.Settings.ID_No = 1
            .Save()
        End With
    End Sub

    Public Function Gen_Bcode(ByVal code As String) As String
        Return "*" & code & "*"
    End Function

    Public Sub Update_Vcode()
        Dim i As Long = My.Settings.ID_No
        Dim s As Long = i + 1
        My.Settings.ID_No = s
        My.Settings.Save()
    End Sub

    Public Sub Restore_Vcode(ByVal cnt As Integer)
        With My.Settings
            .ID_No = cnt
            .Save()
        End With
    End Sub

    Public Function Get_Vcode() As String

        Dim Ticket As String = My.Settings.ID_No
        Dim x As Integer = 1

        If Ticket.Length > 6 Then
            Return Ticket
        Else
            If Ticket = 0 Then Ticket = 1

            Dim i As Integer = 6 - Ticket.Length
            Dim Nticket As String = New String("0", i)

            Return Nticket & Ticket
        End If

    End Function

    Public Function Vcode() As String
        Return My.Settings.ID_No
    End Function
End Module
