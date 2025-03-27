Public Class Form1

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        LinkLabel1.LinkVisited = True
        System.Diagnostics.Process.Start("chrome.exe", _
"https://Google.com/")

    End Sub
End Class
