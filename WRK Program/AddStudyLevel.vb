
Public Class AddStudyLevel
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'Добавление записи
        CommandText = "Insert Into [Study level] ([ID], [StudyType]) " &
                      "values ('" & TextBox1.Text & "', '" & TextBox2.Text & "')"
        ChangeDataInTable(CommandText)
        StudyLevel.LoadDataFromStudyLevel()
        Me.Close()
    End Sub

    Sub LoadingDataFromStudyLevel(ByVal ID As Integer)
        TextBox1.Text = ID
    End Sub
End Class