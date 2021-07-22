Imports ADODB
Module KEYBOARD_FUNCTION
    Public textname As String

    Public Sub backspace(ByVal txt As TextBox)

        If Len(txt.Text) = 0 Then
            Exit Sub
        End If
        Dim ln As Integer
        ln = Len(txt.Text)
        txt.Text = Mid(txt.Text, 1, ln - 1)
        'Dim ln As Integer
        ln = Len(txt.Text)
        txt.SelectionStart = ln
        txt.Focus()

    End Sub
    Public Sub spaceC(ByVal txt As TextBox)

        'Dim sl As Integer
        'Dim ss As Integer
        'txt.Focus()
        'sl = txt.SelectionLength
        'ss = txt.SelectionStart
        'txt.Select(0, txt.Text.Length)
        txt.Text = txt.Text + " "
        Dim ln As Integer
        ln = Len(txt.Text)
        txt.SelectionStart = ln
        txt.Focus()

    End Sub
   
End Module
