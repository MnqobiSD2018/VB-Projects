Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try


            Const vat As Single = 15 / 100
            Dim val As Single

            val = MaskedTextBox1.Text

            Label3.Text = vat * val


        Catch ex As Exception

            MsgBox("An Error occured restart the app")

        End Try

        

    End Sub
End Class
