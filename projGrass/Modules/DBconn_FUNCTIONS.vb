Imports ADODB
Imports System.Data.OleDb

Module DBconn_FUNCTIONS
    Public Conn As New ADODB.Connection
    Public ConnLoc As New ADODB.Connection
    Public ConClient As New ADODB.Connection
    Public qrs As New Recordset

    Public dtQ As DataTable = New DataTable
    Public dtDgv As DataTable = New DataTable


    Public Function Get_ServerDb() As Boolean
        Try
            With My.Settings
                If Conn.State = ConnectionState.Open Then Conn.Close()
                Conn = New ADODB.Connection
                Conn.CursorLocation = ADODB.CursorLocationEnum.adUseClient
                Conn.Open("Driver={mySQL ODBC 8.0 Unicode Driver}; " _
                & "Server=" & .DB_IP & ";" _
                & "Port=" & .DB_Port & ";" _
                & "Option=3;" _
                & "UID=" & .DB_UID & ";" _
                & "PWD=" & .DB_PWD & ";")
            End With
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Sub viewServerDb(ByVal cbo As ComboBox)
        Dim dbshw As New Recordset
        cbo.Items.Clear()
        dbshw = New Recordset
        dbshw = Conn.Execute("show databases")
        Do While dbshw.EOF = False
            cbo.Items.Add(dbshw("Database").Value)
            dbshw.MoveNext()
        Loop
    End Sub

    Public Function conServer() As Boolean
        Try
            With My.Settings
                If Conn.State = ConnectionState.Open Then Conn.Close()
                Conn = New ADODB.Connection
                Conn.CursorLocation = ADODB.CursorLocationEnum.adUseClient
                Conn.Open("Driver={mySQL ODBC 8.0 Unicode Driver}; " _
                & "Server=" & .DB_IP & ";" _
                & "Port=" & .DB_Port & ";" _
                & "Option=3;" _
                & "Database=" & .DB_Database & ";" _
                & "UID=" & .DB_UID & ";" _
                & "PWD=" & .DB_PWD & ";")
                Return True
            End With
        Catch
            Return False
        End Try
    End Function

    Public Function conVmsClient(ByVal Ip As String, ByVal Port As String, ByVal Db As String, ByVal Uid As String, ByVal Pwd As String) As Boolean
        Try
            If ConClient.State = ConnectionState.Open Then ConClient.Close()

            ConClient = New ADODB.Connection
            ConClient.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            ConClient.Open("Driver={mySQL ODBC 8.0 Unicode Driver}; " _
            & "Server=" & Ip & ";" _
            & "Port=" & Port & ";" _
            & "Option=3;" _
            & "Database=" & Db & ";" _
            & "UID=" & Uid & ";" _
            & "PWD=" & Pwd & ";")
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Function Get_LocalDb() As Boolean
        Try
            With My.Settings
                If ConnLoc.State = ConnectionState.Open Then ConnLoc.Close()
                ConnLoc = New ADODB.Connection
                ConnLoc.CursorLocation = ADODB.CursorLocationEnum.adUseClient
                ConnLoc.Open("Driver={mySQL ODBC 8.0 Unicode Driver}; " _
                & "Server=" & .DBL_Ip & ";" _
                & "Port=" & .DBL_Port & ";" _
                & "Option=3;" _
                & "UID=" & .DBL_Uid & ";" _
                & "PWD=" & .DBL_PWD & ";")
                Return True
            End With
        Catch
            Return False
        End Try
    End Function

    Public Sub viewLocDb(ByVal cbo As ComboBox)
        Dim dbshw As New Recordset
        cbo.Items.Clear()
        dbshw = New Recordset
        dbshw = ConnLoc.Execute("show databases")
        Do While dbshw.EOF = False
            cbo.Items.Add(dbshw("Database").Value)
            dbshw.MoveNext()
        Loop
    End Sub

    Public Function conLocal() As Boolean
        Try
            With My.Settings
                If ConnLoc.State = ConnectionState.Open Then ConnLoc.Close()
                ConnLoc = New ADODB.Connection
                ConnLoc.CursorLocation = ADODB.CursorLocationEnum.adUseClient
                ConnLoc.Open("Driver={mySQL ODBC 8.0 Unicode Driver}; " _
                & "Server=" & .DBL_Ip & ";" _
                & "Port=" & .DBL_Port & ";" _
                & "Option=3;" _
                & "Database=" & .DBL_Database & ";" _
                & "UID=" & .DBL_Uid & ";" _
                & "PWD=" & .DBL_PWD & ";")
                Return True
            End With
        Catch
            Return False
        End Try
    End Function

    Public Function rsMySQLQry(ByVal strQuery As String) As DataTable
        Try
            dtQ = New DataTable

            If conServer() = False Then
                Return dtQ
            End If

            Dim OleAdapter As OleDbDataAdapter = New OleDbDataAdapter

            qrs = New Recordset
            qrs = Conn.Execute(strQuery)

            OleAdapter.Fill(dtQ, qrs)

            Return dtQ
        Catch ex As Exception
            'errMsg = ex.Message
            dtQ = New DataTable
            Return dtQ
        End Try
    End Function


    Public Function LoadDgvData(ByVal dgv As DataGridView, ByVal query As String, ByVal HdAutoRez As Boolean) As DataTable
        dtDgv = New DataTable
        Try
            dtDgv = rsMySQLQry(query)

            If dtDgv IsNot Nothing Then
                dgv.DataSource = dtDgv
            End If

            Dim HdCnt As Integer = dgv.Columns.Count
            Dim HdLup As Integer = 0
            Dim HdW As Integer = (dgv.Width - dgv.RowHeadersWidth) / HdCnt

            Do While HdLup <> HdCnt
                dgv.Columns(HdLup).HeaderCell.Style.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                If HdAutoRez = True Then
                    dgv.Columns(HdLup).Width = HdW
                End If
                HdLup = HdLup + 1
            Loop

            Return dtDgv
        Catch ex As Exception
            Return dtDgv
        End Try
    End Function
End Module
