Public Class Form1

    Private Sub TimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeToolStripMenuItem.Click
        Label1.Text = TimeString

    End Sub

    Private Sub DateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateToolStripMenuItem.Click
        Label1.Text = DateString

    End Sub

    Private Sub NowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NowToolStripMenuItem.Click
        Label1.Text = Now

    End Sub

    Private Sub HourToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HourToolStripMenuItem.Click
        Label1.Text = Hour(Date.FromOADate(10.0))

    End Sub

    Private Sub MInuteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MInuteToolStripMenuItem.Click
        Label1.Text = Minute(Date.FromOADate(10.0))


    End Sub

    Private Sub SecondToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SecondToolStripMenuItem.Click
        Label1.Text = Second(Date.FromOADate(10.0))

    End Sub

    Private Sub MonthToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonthToolStripMenuItem.Click
        Label1.Text = Month(Date.FromOADate(10.0))

    End Sub

    Private Sub YearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YearToolStripMenuItem.Click
        Label1.Text = Year(Date.FromOADate(10.0))

    End Sub

    Private Sub WeekdayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WeekdayToolStripMenuItem.Click
        Label1.Text = Weekday(Date.FromOADate(10.0))

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub OpenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripButton.Click
        OpenFileDialog1.Filter = "Bitmaps (*.bmp)|*.bmp"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = System.Drawing.Image.FromFile _
            (OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        ColorDialog1.ShowDialog()
        Label1.ForeColor = ColorDialog1.Color
    End Sub
End Class
