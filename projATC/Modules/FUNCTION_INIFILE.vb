Imports System.IO
Imports System.IO.File
Module FUNCTION_INIFILE
    Public IdName As String = vbNullString
    Public IniFile As String = My.Settings.DataPath & "\"
    Public ImagePAth As String = My.Settings.DataPath & "\"
    Public INI As New ini(IniFile)

#Region "Data"
    Public Structure Data_Config
        Public DocType As String
        Public DocumentNo As String
        Public Surname As String
        Public GivenName As String
    End Structure

    Public Function Get_Data_Config() As Data_Config
        Dim x As New Data_Config
        x.DocType = INI.GetString("Derived Results", "DocType", "")
        x.DocumentNo = INI.GetString("Derived Results", "DocumentNumber", "")
        x.Surname = INI.GetString("Derived Results", "Surname", "")
        x.GivenName = INI.GetString("Derived Results", "GivenName", "")
        Return x
    End Function

    Public Sub Delete_MRZFile(ByVal entpath As String)
        Try
            If File.Exists(entpath) = True Then
                Kill(entpath)
                File.Delete(entpath)
            End If
        Catch

        End Try
    End Sub

    Public Function CheckMRZFile(ByVal path As String) As Boolean
        Try
            IdName = Dir$(path)
            If IdName = "" Then
                Return False
            Else
                Return True
            End If
        Catch
            Return False
        End Try
    End Function

#End Region
End Module
