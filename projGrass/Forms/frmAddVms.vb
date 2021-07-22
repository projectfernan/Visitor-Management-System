Imports ADODB
Public Class frmAddVms

    Private Sub LbClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbClose.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Select Case lbTitle.Text
            Case "      New Client"
                If MessageBox.Show("Are you sure that your entries are correct?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> Windows.Forms.DialogResult.Yes Then
                    Exit Sub
                End If

                If verifyNull() = True Then
                    MessageBox.Show("Please don't leave a blank!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                If verifyClient(txtClient.Text) = True Then
                    MessageBox.Show("Client name is already exist!", "Add", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtClient.Focus()
                    Exit Sub
                End If

                If Save() = True Then
                    MsgListBox("New client '" & txtClient.Text & "' is successfully added.")
                End If
            Case "      Update Client"
                If MessageBox.Show("Are you sure do you wan to save changes?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> Windows.Forms.DialogResult.Yes Then
                    Exit Sub
                End If

                If verifyNull() = True Then
                    MessageBox.Show("Please don't leave a blank!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                If Edit() = True Then
                    MainFormServer.loadClient()
                    MsgListBox("Client '" & txtClient.Text & "' is successfully updated.")
                End If
        End Select
    End Sub

    Function verifyClient(ByVal client As String) As Boolean
        If conLocal() = False Then Return False

        Try
            Dim rs As New Recordset
            rs = ConnLoc.Execute("select Client from tblvmsclient where Client = '" & client & "'")
            If rs.EOF = False Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function verifyNull() As Boolean
        If txtClient.Text = "" Or txtIp.Text = "" Or txtUID.Text = "" Or txtPWD.Text = "" Or txtDb.Text = "" Or txtPort.Value = 0 Or txtDelay.Value = 0 Then
            MessageBox.Show("Please don't leave a blank!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        Else
            Return False
        End If
    End Function

    Function Save() As Boolean
        If conLocal() = False Then Return False

        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs.Open("select * from tblvmsclient where 1=0", ConnLoc, 1, 2)
            rs.AddNew()

            rs("Client").Value = txtClient.Text
            rs("IpAdd").Value = txtIp.Text
            rs("Uid").Value = txtUID.Text
            rs("Pwd").Value = txtPWD.Text
            rs("Port").Value = txtPort.Value
            rs("Database").Value = txtDb.Text
            rs("Delay").Value = txtDelay.Value
            rs.Update()
            MsgBox("New VMS client succeesfully added!    ", vbInformation, "Save")
            Me.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MsgListBox("Save Error: " & ex.Message)
            Return False
        End Try


    End Function

    Function Edit() As Boolean
        If conLocal() = False Then Return False

        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs.Open("select * from tblvmsclient where Client = '" & txtClient.Text & "'", ConnLoc, 1, 2)
            rs("IpAdd").Value = txtIp.Text
            rs("Uid").Value = txtUID.Text
            rs("Pwd").Value = txtPWD.Text
            rs("Port").Value = txtPort.Value
            rs("Database").Value = txtDb.Text
            rs("Delay").Value = txtDelay.Value
            rs.Update()
            MsgBox("VMS client succeesfully updated!    ", vbInformation, "Update")
            Me.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MsgListBox("Update Error: " & ex.Message)
            Return False
        End Try
    End Function

End Class