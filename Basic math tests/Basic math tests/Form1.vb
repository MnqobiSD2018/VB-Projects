Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim vari1, vari2 As Single
       
        vari1 = TextBox1.Text
        vari2 = TextBox2.Text

        If RadioButton1.Checked = True Then
            TextBox3.Text = vari1 + vari2
        ElseIf RadioButton2.Checked = True Then
            TextBox3.Text = vari1 - vari2
        ElseIf RadioButton3.Checked = True Then
            TextBox3.Text = vari1 * vari2
        ElseIf RadioButton4.Checked = True Then
            TextBox3.Text = vari1 / vari2

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class
