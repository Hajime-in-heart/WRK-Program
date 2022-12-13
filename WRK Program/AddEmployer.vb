
Public Class AddEmployer
    Sub LoadingDataFromEmployer(ByVal ID As Integer)
        TextBox1.Text = ID
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'Добавление записи
        CommandText = "Insert Into [Employer] ([JobGiver], [Name job giver], [Place], [Mobile], [More]) " &
                      "values ('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', " & "'" & TextBox4.Text & "' , '" & TextBox5.Text & "')"
        ChangeDataInTable(CommandText)
        Employer.LoadDataFromEmployer()
        Me.Close()
    End Sub
End Class