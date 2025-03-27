Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Sapi As Object
        Sapi = CreateObject("Sapi.spvoice")
        Sapi.speak(TextBox1.Text)

    End Sub
End Class
