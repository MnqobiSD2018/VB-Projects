﻿Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Prompt, FullName As String
        Prompt = "Please enter your name."
        FullName = InputBox(Prompt)
        MsgBox(FullName, , "Input Results")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End

    End Sub
End Class
