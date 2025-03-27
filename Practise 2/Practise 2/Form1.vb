Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Try
            Dim N As Integer
            N = MaskedTextBox1.Text

            MsgBox("You Entered " & N)

        Catch ex As Exception
            Me.Show()

        End Try



    End Sub
End Class
