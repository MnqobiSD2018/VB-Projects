Partial Class Database1DataSet1
    Partial Class DTBCDataTable

        Private Sub DTBCDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.Name_Column.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
