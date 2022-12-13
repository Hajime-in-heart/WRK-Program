
Public Class AddArea
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'Добавление записи
        CommandText = "Insert Into [Area] ([ID], [District name]) values ('" & TextBox1.Text & "', '" & TextBox2.Text & "')"
        ChangeDataInTable(CommandText)
        Area.LoadDataFromArea()
        Me.Close()
    End Sub

    Sub LoadingDataFromArea(ByVal ID As Integer)
        TextBox1.Text = ID
    End Sub
End Class