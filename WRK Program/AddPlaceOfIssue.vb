
Public Class AddPlaceOfIssue
    Sub LoadDataFromPlaceOfIssue(ByVal ID As Integer)
        TextBox1.Text = ID
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'Добавление записи
        CommandText = "Insert Into [Place of issue] ([ID], [Gived]) values ('" & TextBox1.Text & "', '" & TextBox2.Text & "')"
        ChangeDataInTable(CommandText)
        PlaceOfIssue.LoadDataFromPlaceOfIssue()
        Me.Close()
    End Sub
End Class