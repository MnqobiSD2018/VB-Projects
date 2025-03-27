Public Class Form1

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PictureBox1.Visible = False
        Label1.Text = CStr(Int(Rnd() * 10))
        Label2.Text = CStr(Int(Rnd() * 10))
        Label3.Text = CStr(Int(Rnd() * 10))

        Spins = Spins + 1

        If (Label1.Text = "7") Or (Label2.Text = "7") Or (Label3.Text = "7") Then
            PictureBox1.Visible = True
            Beep()

            Wins = Wins + 1
            lblWins.Text = "Wins: " & Wins
        End If

        lblRate.Text = HitRate(Wins, Spins)

    End Sub

End Class
