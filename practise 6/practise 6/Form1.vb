Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim val1 As Single
        Dim val2 As Single

        val1 = TextBox1.Text
        val2 = TextBox2.Text

        Label4.Text = (val1 + val2) / 2

        If Label4.Text >= "50" Then
            Label4.ForeColor = Color.Green
            MsgBox(TextBox3.Text & Chr(10) & Chr(13) & "You Did Well Keep it Up ")
        ElseIf Label4.Text < "50" Then
            Label4.ForeColor = Color.Red
            MsgBox(TextBox3.Text & Chr(10) & Chr(13) & "You can do Better keep Trying as Hard as You Can")

        End If
    End Sub
End Class
