Imports ADODB
Module GET_FLOOR
    Public Structure FloorNo
        Public FloorNumber As String
    End Structure

    Public Function Get_FloorNo(ByVal UnitNo As String) As FloorNo
        Dim fl As New FloorNo
        Try
            If conServer() = False Then
                Return fl
            End If

            Dim rs As New Recordset
            rs = Conn.Execute("select Floor from tblunits where UnitNo = '" & UnitNo & "'")
            If rs.EOF = False Then
                fl.FloorNumber = rs("Floor").Value
                Return fl
            Else
                Return fl
            End If
        Catch ex As Exception
            Return fl
        End Try
    End Function

End Module
