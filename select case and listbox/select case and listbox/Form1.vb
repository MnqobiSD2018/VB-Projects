Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        'The list box item selected (0-2) is held in the SelectedIndex property
        Select Case ListBox1.SelectedIndex
            Case 0
                PictureBox1.Image = System.Drawing.Image.FromFile _
                ("c:\Users\admin\Downloads\image.png")
            Case 1
                PictureBox1.Image = System.Drawing.Image.FromFile _
                ("c:\Users\admin\Downloads\big-info.png")
            Case 2
                PictureBox1.Image = System.Drawing.Image.FromFile _
                ("c:\Users\admin\Downloads\install_button.png")
            Case 3
                PictureBox1.Image = System.Drawing.Image.FromFile _
               ("c:\Users\admin\Downloads\image.png")

        End Select
    End Sub
End Class
