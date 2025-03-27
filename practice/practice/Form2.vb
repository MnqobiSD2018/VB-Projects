
Imports System.Math

Public Class Form2



    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim vari1, vari2 As Single
        vari1 = TextBox1.Text
        vari2 = TextBox2.Text

        If RadioButton1.Checked = True Then
            TextBox3.Text = vari1 + vari2
        ElseIf RadioButton2.Checked = True Then
            TextBox3.Text = vari1 - vari2
        ElseIf RadioButton3.Checked = True Then
            TextBox3.Text = vari1 * vari2
        ElseIf RadioButton4.Checked = True Then
            TextBox3.Text = vari1 / vari2
        ElseIf RadioButton5.Checked = True Then
            TextBox3.Text = vari1 \ vari2
        ElseIf RadioButton6.Checked = True Then
            TextBox3.Text = vari1 ^ vari2
        ElseIf RadioButton7.Checked = True Then
            TextBox3.Text = vari1 & vari2

        End If








    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Panel2_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Try

            Dim n As Single
            n = TextBox4.Text


            If RadioButton14.Checked = True Then
                TextBox5.Text = Sin(n)
            ElseIf RadioButton13.Checked = True Then
                TextBox5.Text = Cos(n)
            ElseIf RadioButton12.Checked = True Then
                TextBox5.Text = Tan(n)
            ElseIf RadioButton11.Checked = True Then
                TextBox5.Text = Atan(n)
            ElseIf RadioButton10.Checked = True Then
                TextBox5.Text = Sqrt(n)
            End If

        Catch ex As Exception
            MsgBox("Restart The App and Check Code")


        End Try




    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()


    End Sub
End Class