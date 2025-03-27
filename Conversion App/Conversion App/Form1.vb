Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
      
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim amount As Single
        Dim answer As Double

        amount = Val(TextBox1.Text)

        If RadioButton1.Checked = True Then
            answer = amount / 2.54
        ElseIf RadioButton2.Checked = True Then
            answer = amount * 2.54
        ElseIf RadioButton3.Checked = True Then
            answer = amount / 2.2
        ElseIf RadioButton4.Checked = True Then
            answer = amount * 2.2
        End If


        MsgBox("The answer is " & answer)
    End Sub
End Class
