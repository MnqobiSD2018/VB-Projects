Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Try
            Dim num1 As Integer
            Dim num2 As Integer
            num1 = TextBox1.Text
            num2 = TextBox2.Text

            If num1 = num2 Then
                Label3.Text = "Same"
            ElseIf num1 <> num2 Then
                Label3.Text = "not the same"
            End If
        Catch ex As Exception
            MsgBox("Chcek your Numbers and Try again")


        End Try
        

    End Sub
End Class
