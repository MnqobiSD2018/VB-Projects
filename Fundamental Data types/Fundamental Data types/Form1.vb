Public Class Form1
    Dim Birds As Short
    Dim insects As Integer
    Dim worldpop As Long
    Dim price As Single
    Dim pi As Double
    Dim debt As Decimal
    Dim retkey As Byte
    Dim unicodechar As Char
    Dim dog As String
    Dim flag As Boolean
    Dim birthday As Date


    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case ListBox1.SelectedIndex
            Case 0
                Birds = 12500
                Label4.Text = Birds
            Case 1
                insects = 37500000
                Label4.Text = insects
            Case 2
                worldpop = 4800000004
                Label4.Text = worldpop
            Case 3
                price = 899.99
                Label4.Text = price
            Case 4
                pi = 3.1415926535
                Label4.Text = pi
            Case 5
                debt = 7600300.5D
                Label4.Text = debt
            Case 6
                retkey = 13
                Label4.Text = retkey
            Case 7
                unicodechar = "A"c
                Label4.Text = unicodechar
            Case 8
                dog = "My Dog"
                Label4.Text = dog
            Case 9
                flag = True
                Label4.Text = flag
            Case 10
                birthday = "3 / 10 / 2020"
                Label4.Text = birthday


        End Select


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("short")
        ListBox1.Items.Add("Integer")
        ListBox1.Items.Add("Long")
        ListBox1.Items.Add("Single")
        ListBox1.Items.Add("Double")
        ListBox1.Items.Add("Decimal")
        ListBox1.Items.Add("Byte")
        ListBox1.Items.Add("Char")
        ListBox1.Items.Add("String")
        ListBox1.Items.Add("Boolean")
        ListBox1.Items.Add("Date")


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End

    End Sub
End Class
