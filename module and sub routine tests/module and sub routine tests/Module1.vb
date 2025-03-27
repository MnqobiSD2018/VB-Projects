Module Module1


    Dim x As String
    Dim y As String
    Dim x_conv As Double
    Dim y_conv As Double
    Dim answer As String

    Sub addme()
        x = InputBox("Please input a number")
        x = CDbl(x)


        y = InputBox("please input a number")

        y = CDbl(y)


        MessageBox.Show("The sum to your numbers is " & answer & MessageBoxButtons.OK)

    End Sub
End Module
