Imports ADODB
Module EXIT_FUNCTION
    Public extBcode As String
    Public Function VisitorNo() As String
        Dim rs As New Recordset
        Dim st As String = Now.Day
        Dim tt As String

        If Len(st) < 2 Then
            st = "0" & st
        End If

        rs = New Recordset
        rs = Conn.Execute("Select * from tblVisitorOut order by ID desc")

        If rs.EOF = False Then
            tt = Val(rs("ID").Value) + 1
            If tt < 10 Then
                Return st + "-" + "00000" + tt
            ElseIf tt >= 10 Then
                Return st + "-" + "0000" + tt
            ElseIf tt >= 100 Then
                Return st + "-" + "000" + tt
            ElseIf tt >= 1000 Then
                Return st + "-" + "00" + tt
            ElseIf tt >= 10000 Then
                Return st + "-" + "0" + tt
            Else
                Return st + "-" + tt
            End If
        Else
            Return st + "-" + "000001"
        End If
    End Function

    Public Sub ViewEntInfo(ByVal cod As String)
        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Conccetion")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Dim rs As New Recordset
        rs = New Recordset

        rs = Conn.Execute("select * from tblVisitorIn where Barcode ='" & cod & "'")
        If rs.EOF = False Then
            With frmExit
                .txtvID.Text = rs("VisitorID").Value
                .txtNAme.Text = rs("VisitorName").Value
                .txtIssuedID.Text = rs("ManualID").Value
                .txtIDtype.Text = rs("IDtype").Value
                .txtIDRef.Text = rs("ReferenceIDno").Value
                .txtContact.Text = rs("ContactNo").Value
                .txtTimeIn.Text = rs("TimeIn").Value
                .txtTimeOut.Text = Now
                .txtCompVisited.Text = rs("CompanyVisited").Value
                .txtContactP.Text = rs("ContactPerson").Value
                .txtPurpose.Text = rs("Purpose").Value
                extBcode = vbNullString
                extBcode = rs("Barcode").Value

                .Vimage.Image = Visitor_PicInExt(extBcode)
                .IDimage.Image = Visitor_PicIn_IDext(extBcode)

                .cmdAccept.Enabled = True
                .tmeRead.Enabled = False
                .tmeBtn.Enabled = True

                .txtbCode.Text = vbNullString
            End With
        Else
            MsgBox("No record found!    ", vbExclamation, "Exit Transaction")
            frmExit.txtbCode.Text = vbNullString
        End If

    End Sub

    Public Sub ViewEntInfoCard(ByVal cod As String)
        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Conccetion")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Dim rs As New Recordset
        rs = New Recordset

        rs = Conn.Execute("select * from tblVisitorIn where Barcode = '" & cod & "'")
        If rs.EOF = False Then
            With frmExit
                .txtvID.Text = rs("VisitorID").Value
                .txtNAme.Text = rs("VisitorName").Value
                .txtIssuedID.Text = rs("ManualID").Value
                .txtIDtype.Text = rs("IDtype").Value
                .txtIDRef.Text = rs("ReferenceIDno").Value
                .txtContact.Text = rs("ContactNo").Value
                .txtTimeIn.Text = rs("TimeIn").Value
                .txtTimeOut.Text = Now
                .txtCompVisited.Text = rs("CompanyVisited").Value
                .txtContactP.Text = rs("ContactPerson").Value
                .txtPurpose.Text = rs("Purpose").Value
                extBcode = vbNullString
                extBcode = rs("Barcode").Value

                .Vimage.Image = Visitor_PicInExt(extBcode)
                .IDimage.Image = Visitor_PicIn_IDext(extBcode)
                .PicSigna.Image = Visitor_Signa(extBcode)

                .cmdAccept.Enabled = True
                .tmeRead.Enabled = False
                .tmeBtn.Enabled = True

                .txtbCode.Text = vbNullString
                d8_Beep()
            End With
        Else
            frmExit.txtbCode.Text = vbNullString
        End If

    End Sub
End Module
