Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Firstnum, secondnum As Double

        Firstnum = TextBox1.Text
        secondnum = TextBox2.Text

        If RadioButton1.Checked = True Then
            TextBox3.Text = Firstnum \ secondnum
        ElseIf RadioButton2.Checked = True Then
            TextBox3.Text = Firstnum Mod secondnum
        ElseIf RadioButton3.Checked = True Then
            TextBox3.Text = Firstnum ^ secondnum
        ElseIf RadioButton2.Checked = True Then
            TextBox3.Text = Firstnum & secondnum


        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End

    End Sub
End Class
