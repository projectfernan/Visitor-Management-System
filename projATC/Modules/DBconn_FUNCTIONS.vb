Imports ADODB
Module DBconn_FUNCTIONS
    Public Conn As New ADODB.Connection

    Public Sub ViewConn()
        With My.Settings
            frmConnDB.txtIp.Text = .DB_IP
            frmConnDB.txtUID.Text = .DB_UID
            frmConnDB.txtPWD.Text = .DB_PWD
            frmConnDB.txtPort.Text = .DB_Port
        End With
    End Sub

    Public Function conServer() As Boolean
        Try
            With My.Settings
                If Conn.State = ConnectionState.Open Then Conn.Close()
                Conn = New ADODB.Connection
                Conn.CursorLocation = ADODB.CursorLocationEnum.adUseClient
                Conn.Open("Driver={mySQL ODBC 5.1 Driver}; " _
                & "Server=" & .DB_IP & ";" _
                & "Port=" & .DB_Port & ";" _
                & "Option=3;" _
                & "Database=atcdb;" _
                & "UID=" & .DB_UID & ";" _
                & "PWD=" & .DB_PWD & ";")
                Return True
            End With
        Catch
            Return False
        End Try
    End Function
End Module
