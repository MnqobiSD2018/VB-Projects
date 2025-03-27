
Public Class Form1
    Dim i As Integer = 1


    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        Dim repeat As Integer = 1
        Dim prompt As String
        Dim name As String
        Try

            PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\admin\Downloads\png\Face11.png")

        Catch ex As Exception
            MsgBox("Check Your Directory!")
        End Try



        Try
            prompt = "Enter your name "

            name = InputBox(prompt)
            Label3.Text = name
            MsgBox("Welcome to the System " & name)

        Catch ex As Exception
            MsgBox("Please Restart the Program!")

        End Try


        ListBox1.Items.Add("Zambia")
        ListBox1.Items.Add("Western Sahara")
        ListBox1.Items.Add("Turkey")
        ListBox1.Items.Add("United Arab Emirates")
        ListBox1.Items.Add("Tuvalu")
        ListBox1.Items.Add("Mozambique")
        ListBox1.Items.Add("South Africa")
        ListBox1.Items.Add("Solomon Islands")
        ListBox1.Items.Add("Singapore")
        ListBox1.Items.Add("Somalia")
        ListBox1.Items.Add("Jamaica")



    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label2.Text = TimeString
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ListBox1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.MouseHover


        If ListBox1.SelectedIndex > 0 Then
            Label4.Text = "Please select a country"
        Else
            Label4.Text = ""

        End If


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case ListBox1.SelectedIndex
            Case 0
                PictureBox2.Image = System.Drawing.Image.FromFile("C:\Users\admin\Downloads\png\jamaica.png")
            Case 1
                PictureBox2.Image = System.Drawing.Image.FromFile("C:\Users\admin\Downloads\png\somalia.png")
            Case 2
                PictureBox2.Image = System.Drawing.Image.FromFile("C:\Users\admin\Downloads\png\singapore.png")
            Case 3
                PictureBox2.Image = System.Drawing.Image.FromFile("C:\Users\admin\Downloads\png\solomon-islands.png")
            Case 4
                PictureBox2.Image = System.Drawing.Image.FromFile("C:\Users\admin\Downloads\png\south-africa.png")
            Case 5
                PictureBox2.Image = System.Drawing.Image.FromFile("C:\Users\admin\Downloads\png\mozambique.png")
            Case 6
                PictureBox2.Image = System.Drawing.Image.FromFile("C:\Users\admin\Downloads\png\tuvalu.png")
            Case 7
                PictureBox2.Image = System.Drawing.Image.FromFile("C:\Users\admin\Downloads\png\united-arab-emirates.png")
            Case 8
                PictureBox2.Image = System.Drawing.Image.FromFile("C:\Users\admin\Downloads\png\turkey.png")
            Case 9
                PictureBox2.Image = System.Drawing.Image.FromFile("C:\Users\admin\Downloads\png\western-sahara.png")
            Case 10
                PictureBox2.Image = System.Drawing.Image.FromFile("C:\Users\admin\Downloads\png\zambia.png")
        End Select
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        Label4.Text = "Please select a country"
        If ListBox1.SelectedIndex = True Then
            Label4.Text = ""

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try
            Form2.Show()
            Me.Close()

        Catch ex As Exception
            Form2.Show()

        End Try


    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Form2.Show()
            Me.Hide()



        Catch ex As Exception
            Form2.Show()


        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()

    End Sub
End Class
