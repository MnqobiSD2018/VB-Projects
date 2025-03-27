Public Class Form1



   
    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        TextBox1.Text = TrackBar1.Value


        If TrackBar1.Value <= 7 Then
            TextBox1.BackColor = Color.Red
        ElseIf TrackBar1.Value <= 18 Then
            TextBox1.BackColor = Color.Azure
        ElseIf TrackBar1.Value <= 20 Then
            TextBox1.BackColor = Color.Chocolate
        End If





    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        TrackBar1.Value = TextBox1.Text
       


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
