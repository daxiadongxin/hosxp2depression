Partial Class DSPerson
    Partial Class cardDataTable

        Private Sub cardDataTable_cardRowChanging(ByVal sender As System.Object, ByVal e As cardRowChangeEvent) Handles Me.cardRowChanging

        End Sub



    End Class

    Partial Class serviceDataTable

        Private Sub serviceDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.SEQColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
