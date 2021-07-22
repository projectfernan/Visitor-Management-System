Imports ADODB
Module FUNCTION_SCANNED_ID
    Public Path_Scanned_ID As String

    Public Sub UpdateIDin(ByVal ID As String)
        Dim rs As New Recordset
        rs = New Recordset

        rs.Open("select * from tblVisitorIn where ID = '" & ID & "'", Conn, 1, 2)
        If rs.EOF = False Then
            Dim strem As New Stream
            strem.Type = StreamTypeEnum.adTypeBinary
            strem.Open()
            strem.LoadFromFile(Path_Scanned_ID)
            rs("ScanID").Value = strem.Read
            rs.Update()
        End If
    End Sub

    Public Sub UpdateIDout(ByVal ID As String)
        Dim rs As New Recordset
        rs = New Recordset

        rs.Open("select * from tblVisitorOut where VisitorID = '" & ID & "'", Conn, 1, 2)
        If rs.EOF = False Then
            Dim strem As New Stream
            strem.Type = StreamTypeEnum.adTypeBinary
            strem.Open()
            strem.LoadFromFile(Path_Scanned_ID)
            rs("ScanID").Value = strem.Read
            rs.Update()
        End If
    End Sub
End Module
