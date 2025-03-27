Public Class Form1

    Private Sub Dtbc2BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dtbc2BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Dtbc2BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Dtbc2DataSet)



    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dtbc2DataSet.dtbc2' table. You can move, or remove it, as needed.
        Me.Dtbc2TableAdapter.Fill(Me.Dtbc2DataSet.dtbc2)

    End Sub

    Private Sub Dtbc2DataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dtbc2DataGridView.CellContentClick

    End Sub

    Private Sub First_NameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles First_NameTextBox.TextChanged

    End Sub

    Private Sub Dtbc2BindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dtbc2BindingNavigator.RefreshItems

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.TableAdapterManager.UpdateAll(Me.Dtbc2DataSet)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class
