Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSales.Click

        Dim SalesPosition As String = ""
        AddName("Sales", SalesPosition)
        txtSales.Text = txtSales.Text & SalesPosition


    End Sub

    Private Sub btnMKT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMKT.Click

        Dim MktPosition As String = ""
        AddName("Marketing", MktPosition)
        txtMKT.Text = txtMKT.Text & MktPosition

    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        End

    End Sub
End Class
