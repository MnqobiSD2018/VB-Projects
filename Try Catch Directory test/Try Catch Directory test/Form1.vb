Imports System.IO

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim retries As Integer = 1


        Try

            PictureBox1.Image = System.Drawing.Bitmap.FromFile("F:\1.bmp")

        Catch ex As FileNotFoundException
            MsgBox("Please Check If the drive is Inserted ")
        Catch ex As OutOfMemoryException
            MsgBox("Check the File Format")
        Catch ex As DirectoryNotFoundException
            MsgBox("There was a Problem Openning the File")

        End Try
    End Sub
End Class
