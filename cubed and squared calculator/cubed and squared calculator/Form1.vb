Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim num As Single
        Dim answer As Double

        num = Val(TextBox1.Text)
        answer = (TextBox1.Text) ^ 2

        MsgBox(num & " squared is " & answer)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim num As Single
        Dim answer As Double

        num = Val(TextBox1.Text)
        answer = (TextBox1.Text) ^ 3

        MsgBox(num & " cubed is " & answer)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim num As Single
        Dim num2 As Single
        Dim answer As Double

        num = Val(TextBox1.Text)
        num2 = Val(TextBox2.Text)

        answer = num ^ num2

        MsgBox(num & " raised to the power of " & num2 & " is " & answer)



    End Sub
End Class
