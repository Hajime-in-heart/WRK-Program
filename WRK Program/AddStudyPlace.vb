
Public Class AddStudyPlace
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Sub LoadDataFromStudyPlace(ByVal ID As Integer)
        TextBox1.Text = ID
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'Добавление записи
        CommandText = "Insert Into [Study place] ([ID], [Name study place], [StudyAddress]) " &
                      "values ('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "')"
        ChangeDataInTable(CommandText)
        StudyPlace.LoadDataFromStudyPlace()
        Me.Close()

    End Sub
End Class