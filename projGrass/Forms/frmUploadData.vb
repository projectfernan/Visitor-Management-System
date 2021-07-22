Imports ADODB
Public Class frmUploadData
    Public Uid As String
    Public Pwd As String
    Public Db As String


    Private Sub LbClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbClose.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If chkUAcc.Checked = False And chkUnitRec.Checked = False And chkPurposeList.Checked = False Then
            MessageBox.Show("Please check the item you want to be uploaded!", "Upload", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If upload() = True Then
            Me.Cursor = Cursors.Arrow
            pbLoad.Visible = False
            MessageBox.Show("Upload is successfully finished!", "Upload", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MsgListBox("Upload operation successful.")
        End If
    End Sub

    Function upload() As Boolean
        Try
            lbStat.Items.Clear()
            Me.Cursor = Cursors.WaitCursor
            pbLoad.Visible = True

            Application.DoEvents()

            If chkUAcc.Checked = True Then
                If UploadUidAcc() = True Then
                    lbStat.Items.Add("Upload User Account successfully finished.")
                End If
            End If

            If chkUnitRec.Checked = True Then
                If UploadUnitRec() = True Then
                    lbStat.Items.Add("Upload Units Record successfully finished.")
                End If
            End If

            If chkPurposeList.Checked = True Then
                If UploadPurpose() = True Then
                    lbStat.Items.Add("Upload Purpose List successfully finished.")
                End If
            End If

            Return True
        Catch ex As Exception
            lbStat.Items.Add("Upload Error: " & ex.Message)
            Return False
        End Try
    End Function

    Function TruncateUidAcc() As Boolean
        If conVmsClient(lblIp.Text, lblPort.Text, Db, Uid, Pwd) = False Then Return False

        Try
            Dim rs As New Recordset
            rs = ConClient.Execute("truncate table tbluseracc")
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function UploadUidAcc() As Boolean
        If TruncateUidAcc() = False Then Return False

        If conVmsClient(lblIp.Text, lblPort.Text, Db, Uid, Pwd) = False Then Return False
        If conLocal() = False Then Return False

        Try
            Dim rsL As New Recordset
            Dim rsC As New Recordset

            rsL = ConnLoc.Execute("select * from tbluseracc")
            If rsL.EOF = False Then
                Do While rsL.EOF = False
                    rsC = ConClient.Execute("insert into tbluseracc(UserName,Password,Name,Designation)VALUES('" & rsL("UserName").Value & _
                                                                                                      "','" & rsL("Password").Value & _
                                                                                                      "','" & rsL("Name").Value & _
                                                                                                      "','" & rsL("Designation").Value & "')")

                    rsL.MoveNext()
                Loop
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            lbStat.Items.Add("Upload User Account Error: " & ex.Message)
            Return False
        End Try

    End Function

    Function TruncateUnitRec() As Boolean
        If conVmsClient(lblIp.Text, lblPort.Text, Db, Uid, Pwd) = False Then Return False

        Try
            Dim rs As New Recordset
            rs = ConClient.Execute("truncate table tblunits")
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function UploadUnitRec() As Boolean
        If TruncateUnitRec() = False Then Return False

        If conVmsClient(lblIp.Text, lblPort.Text, Db, Uid, Pwd) = False Then Return False
        If conLocal() = False Then Return False

        Try
            Dim rsL As New Recordset
            Dim rsC As New Recordset

            rsL = ConnLoc.Execute("select * from tblunits")
            If rsL.EOF = False Then
                Do While rsL.EOF = False
                    rsC = ConClient.Execute("insert into tblunits(Tower,UnitNo,Floor,ContactPerson,ContactNo)VALUES('" & rsL("Tower").Value & _
                                                                                                      "','" & rsL("UnitNo").Value & _
                                                                                                      "','" & rsL("Floor").Value & _
                                                                                                      "','" & rsL("ContactPerson").Value & _
                                                                                                      "','" & rsL("ContactNo").Value & "')")

                    rsL.MoveNext()
                Loop
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            lbStat.Items.Add("Upload Units Record Error: " & ex.Message)
            Return False
        End Try

    End Function

    Function TruncatePurpose() As Boolean
        If conVmsClient(lblIp.Text, lblPort.Text, Db, Uid, Pwd) = False Then Return False

        Try
            Dim rs As New Recordset
            rs = ConClient.Execute("truncate table tblpurpose")
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function UploadPurpose() As Boolean
        If TruncatePurpose() = False Then Return False

        If conVmsClient(lblIp.Text, lblPort.Text, Db, Uid, Pwd) = False Then Return False
        If conLocal() = False Then Return False

        Try
            Dim rsL As New Recordset
            Dim rsC As New Recordset

            rsL = ConnLoc.Execute("select * from tblpurpose")
            If rsL.EOF = False Then
                Do While rsL.EOF = False
                    rsC = ConClient.Execute("insert into tblpurpose(Purpose)VALUES('" & rsL("Purpose").Value & "')")

                    rsL.MoveNext()
                Loop
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            lbStat.Items.Add("Upload Purpose List Error: " & ex.Message)
            Return False
        End Try

    End Function
End Class