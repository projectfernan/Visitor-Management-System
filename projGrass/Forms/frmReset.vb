Imports ADODB
Public Class frmReset

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        If (MessageBox.Show("Are you sure do you want to reset the system data?", "System Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Application.DoEvents()

        Me.Cursor = Cursors.WaitCursor

        Dim lod As Integer = 1
        pbLoad.Maximum = 9
        pbLoad.Value = 0


retPurpose: If truncatePurpose() = False Then
            MessageBox.Show("Failed to reset Purpose List!", "System Reset", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            If (MessageBox.Show("Retry to reset?", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                GoTo retPurpose
            Else
                pbLoad.Maximum = 9
                pbLoad.Value = 0
            End If
        Else
            pbLoad.Value = pbLoad.Value + 1
        End If

retUnits: If truncateUnits() = False Then
            MessageBox.Show("Failed to reset Units Record!", "System Reset", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            If (MessageBox.Show("Retry to reset?", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                GoTo retUnits
            Else
                pbLoad.Maximum = 9
                pbLoad.Value = 0
                Exit Sub
            End If
        Else
            pbLoad.Value = pbLoad.Value + 1
        End If

retVisIn: If truncateVisitorIn() = False Then
            MessageBox.Show("Failed to reset Visitor Entry Logs!", "System Reset", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            If (MessageBox.Show("Retry to reset?", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                GoTo retVisIn
            Else
                pbLoad.Maximum = 9
                pbLoad.Value = 0
                Exit Sub
            End If
        Else
            pbLoad.Value = pbLoad.Value + 1
        End If

retVisOut: If truncateVisitorOut() = False Then
            MessageBox.Show("Failed to reset Visitor Exit Logs!", "System Reset", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            If (MessageBox.Show("Retry to reset?", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                GoTo retVisOut
            Else
                pbLoad.Maximum = 9
                pbLoad.Value = 0
                Exit Sub
            End If
        Else
            pbLoad.Value = pbLoad.Value + 1
        End If

retImgCam: If truncateImgcam() = False Then
            MessageBox.Show("Failed to reset Visitor Actual Appearance Snapshot!", "System Reset", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            If (MessageBox.Show("Retry to reset?", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                GoTo retImgCam
            Else
                pbLoad.Maximum = 9
                pbLoad.Value = 0
                Exit Sub
            End If
        Else
            pbLoad.Value = pbLoad.Value + 1
        End If

retImgId: If truncateImgId() = False Then
            MessageBox.Show("Failed to reset Visitor surrendered scanned ID image!", "System Reset", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            If (MessageBox.Show("Retry to reset?", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                GoTo retImgId
            Else
                pbLoad.Maximum = 9
                pbLoad.Value = 0
                Exit Sub
            End If
        Else
            pbLoad.Value = pbLoad.Value + 1
        End If

retImgSigna: If truncateImgId() = False Then
            MessageBox.Show("Failed to reset Visitor digital signature!", "System Reset", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            If (MessageBox.Show("Retry to reset?", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                GoTo retImgSigna
            Else
                pbLoad.Maximum = 9
                pbLoad.Value = 0
                Exit Sub
            End If
        Else
            pbLoad.Value = pbLoad.Value + 1
        End If

retUidAcc: If truncateUserAcc() = False Then
            MessageBox.Show("Failed to reset System Accounts!", "System Reset", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            If (MessageBox.Show("Retry to reset?", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                GoTo retUidAcc
            Else
                pbLoad.Maximum = 9
                pbLoad.Value = 0
                Exit Sub
            End If
        Else
            pbLoad.Value = pbLoad.Value + 1
        End If

        My.Settings.ID_No = 1
        My.Settings.Save()
        pbLoad.Value = pbLoad.Value + 1

        Me.Cursor = Cursors.Arrow

        MessageBox.Show("System reset is successful!", "System Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Function truncatePurpose() As Boolean
        Try
            Select Case My.Settings.DefSet
                Case "Server"
                    If conServer() = False Then
                        Return False
                    End If

                    Dim rs As New Recordset
                    rs = Conn.Execute("TRUNCATE TABLE tblpurpose")
                    Return True
                Case "Client"
                    If conLocal() = False Then
                        Return False
                    End If

                    Dim rs As New Recordset
                    rs = ConnLoc.Execute("TRUNCATE TABLE tblpurpose")
                    Return True
            End Select
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function truncateUnits() As Boolean
        Try
            Select Case My.Settings.DefSet
                Case "Server"
                    If conServer() = False Then
                        Return False
                    End If

                    Dim rs As New Recordset
                    rs = Conn.Execute("TRUNCATE TABLE tblunits")
                    Return True
                Case "Client"
                    If conLocal() = False Then
                        Return False
                    End If

                    Dim rs As New Recordset
                    rs = ConnLoc.Execute("TRUNCATE TABLE tblunits")
                    Return True
            End Select
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function truncateVisitorIn() As Boolean
        Try
            Select Case My.Settings.DefSet
                Case "Server"
                    If conServer() = False Then
                        Return False
                    End If

                    Dim rs As New Recordset
                    rs = Conn.Execute("TRUNCATE TABLE tblvisitorin")
                    Return True
                Case "Client"
                    If conLocal() = False Then
                        Return False
                    End If

                    Dim rs As New Recordset
                    rs = ConnLoc.Execute("TRUNCATE TABLE tblvisitorin")
                    Return True
            End Select
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function truncateVisitorOut() As Boolean
        Try
            Select Case My.Settings.DefSet
                Case "Server"
                    If conServer() = False Then
                        Return False
                    End If

                    Dim rs As New Recordset
                    rs = Conn.Execute("TRUNCATE TABLE tblvisitorout")
                    Return True
                Case "Client"
                    If conLocal() = False Then
                        Return False
                    End If

                    Dim rs As New Recordset
                    rs = ConnLoc.Execute("TRUNCATE TABLE tblvisitorout")
                    Return True
            End Select
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function truncateImgcam() As Boolean
        Try
            Select Case My.Settings.DefSet
                Case "Server"
                    If conServer() = False Then
                        Return False
                    End If

                    Dim rs As New Recordset
                    rs = Conn.Execute("TRUNCATE TABLE tblimgcam")
                    Return True
                Case "Client"
                    If conLocal() = False Then
                        Return False
                    End If

                    Dim rs As New Recordset
                    rs = ConnLoc.Execute("TRUNCATE TABLE tblimgcam")
                    Return True
            End Select
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function truncateImgId() As Boolean
        Try
            Select Case My.Settings.DefSet
                Case "Server"
                    If conServer() = False Then
                        Return False
                    End If

                    Dim rs As New Recordset
                    rs = Conn.Execute("TRUNCATE TABLE tblimgid")
                    Return True
                Case "Client"
                    If conLocal() = False Then
                        Return False
                    End If

                    Dim rs As New Recordset
                    rs = ConnLoc.Execute("TRUNCATE TABLE tblimgid")
                    Return True
            End Select
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function truncateImgSigna() As Boolean
        Try
            Select Case My.Settings.DefSet
                Case "Server"
                    If conServer() = False Then
                        Return False
                    End If

                    Dim rs As New Recordset
                    rs = Conn.Execute("TRUNCATE TABLE tblimgsigna")
                    Return True
                Case "Client"
                    If conLocal() = False Then
                        Return False
                    End If

                    Dim rs As New Recordset
                    rs = ConnLoc.Execute("TRUNCATE TABLE tblimgsigna")
                    Return True
            End Select
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function truncateUserAcc() As Boolean
        Try
            If My.Settings.DefSet = "Client" Then
                If conLocal() = False Then
                    Return False
                End If

                Dim rs As New Recordset
                rs = ConnLoc.Execute("TRUNCATE TABLE tbluseracc")
                Return True
            Else
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub LbClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbClose.Click
        Me.Close()
    End Sub
End Class