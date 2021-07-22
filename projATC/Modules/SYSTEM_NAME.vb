Imports ADODB
Module SYSTEM_NAME
    Sub ViewSystemSet()

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = Conn.Execute("select * from tblSystemSet")
            If rs.EOF = False Then
                With frmMain
                    .txtCompany.Text = rs("SystemCompany").Value
                    .txtTitle.Text = rs("SystemTitle").Value
                    frmSystemTitle.txtCompanyName.Text = rs("SystemCompany").Value
                    frmSystemTitle.txtTitle.Text = rs("SystemTitle").Value
                    .txtStation.Text = My.Settings.Station
                    With My.Settings
                        frmSystemTitle.txtOR.Value = .ID_No
                        frmSystemTitle.cboStation.Text = .Station
                    End With
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Save")
        End Try
    End Sub

   
End Module
