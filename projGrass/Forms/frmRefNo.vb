Imports ADODB
Public Class frmRefNo

    Private Sub txtRefNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtRefNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            SAVE_Exit(Vis_BarCod)
            delEnt(Vis_BarCod)
            Me.Close()
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Public Sub SAVE_Exit(ByVal id As String)
        Try
            Dim rs As New Recordset
            Dim rs2 As New Recordset

            rs2 = New Recordset
            rs2 = Conn.Execute("select * from tblvisitorin where Barcode = '" & id & "'")
            If rs2.EOF = False Then
                rs = New Recordset
                rs.Open("select * from tblvisitorout", Conn, 1, 2)
                rs.AddNew()
                rs("VisitorID").Value = rs2("VisitorID").Value
                rs("VisitorName").Value = rs2("VisitorName").Value
                rs("IDtype").Value = rs2("IDtype").Value
                rs("ReferenceIDno").Value = rs2("ReferenceIDno").Value
                rs("ContactNo").Value = rs2("ContactNo").Value
                rs("TimeIn").Value = rs2("TimeIn").Value
                rs("TimeOut").Value = Now
                rs("CompanyVisited").Value = rs2("CompanyVisited").Value
                rs("ContactPerson").Value = rs2("ContactPerson").Value
                rs("Purpose").Value = rs2("Purpose").Value
                rs("Capture").Value = rs2("Capture").Value
                rs("ScanID").Value = rs2("ScanID").Value
                rs("Signature").Value = rs2("Signature").Value
                rs("Type").Value = "Manual"
                rs("RefNo").Value = txtRefNo.Text
                rs.Update()
                MsgBox("Exit transaction saved!    ", vbInformation, "Save")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Save")
        End Try
    End Sub

    Sub delEnt(ByVal Code As String)
        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Conccetion")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Dim rs As New Recordset
        rs = New Recordset
        rs = Conn.Execute("delete from tblvisitorin where Barcode = '" & Code & "'")

    End Sub

    Private Sub LbClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbClose.Click
        Me.Close()
    End Sub
End Class