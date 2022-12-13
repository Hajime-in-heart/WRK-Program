
Public Class AddUser
    Dim ID As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'Добавление записи
        CommandText = "Insert Into [Users] ([ID], [LastName], [FirstName], [Patronymic], [Login], [Password], [Root], [Job title]) " &
                                            "values ('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', " & "'" & TextBox4.Text & "', " & "
                                            '" & TextBox5.Text & "', " & "'" & TextBox6.Text & "', " & "'" & TextBox7.Text & "', " & "'" & TextBox8.Text & "')"
        ChangeDataInTable(CommandText)
        Users.LoadListUsers()
        Me.Close()
    End Sub

    Sub LoadingDataFromUsers(ByVal ID As Integer)
        TextBox1.Text = ID
    End Sub
End Class