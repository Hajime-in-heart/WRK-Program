
Public Class AddVacancy
    Private Sub AddVacancy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = frmMain
        Me.Width = 666
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Select Case Button3.Text
            Case "Подтвердить"
                ListView1.Enabled = False
                Button8.Enabled = True
                Try
                    With ListView1
                        TextBox7.Text = .SelectedItems(0).Text
                        TextBox8.Text = .SelectedItems(0).SubItems(1).Text
                        TextBox4.Text = .SelectedItems(0).Text
                    End With
                Catch ex As Exception

                End Try
                Button3.Text = "Выбрать"
                ListView1.Items.Clear()
                Me.Width = 666
            Case "Выбрать"
                Me.Width = 1147
                LoadingListArea()
                ListView1.Enabled = True
                Button8.Enabled = False
                Button3.Text = "Подтвердить"
        End Select

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Select Case Button8.Text
            Case "Подтвердить"
                ListView1.Enabled = False
                Button3.Enabled = True
                Try
                    With ListView1
                        TextBox6.Text = .SelectedItems(0).Text
                        TextBox9.Text = .SelectedItems(0).Text
                        TextBox10.Text = .SelectedItems(0).SubItems(1).Text
                        TextBox11.Text = .SelectedItems(0).SubItems(2).Text
                        TextBox12.Text = .SelectedItems(0).SubItems(3).Text
                        TextBox13.Text = .SelectedItems(0).SubItems(4).Text
                    End With
                Catch ex As Exception

                End Try
                Button8.Text = "Выбрать"
                ListView1.Items.Clear()
                Me.Width = 666
            Case "Выбрать"
                Me.Width = 1147
                LoadListEmployer()
                ListView1.Enabled = True
                Button3.Enabled = False
                Button8.Text = "Подтвердить"
        End Select

    End Sub


    Sub LoadingListArea()
        With ListView1
            .Items.Clear()
            .Columns.Clear()
            .Columns.Add("ID")
            .Columns.Add("Местоположение")
            Commandtext = "SELECT * FROM Area;"
            LoadDataFromTable(Commandtext, ListView1, 2)
            .AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

        End With
    End Sub


    Sub LoadListEmployer()
        With ListView1
            .Items.Clear()
            .Columns.Clear()
            .Columns.Add("ID")
            .Columns.Add("Имя")
            .Columns.Add("Адрес")
            .Columns.Add("Номер телефона")
            .Columns.Add("Примечание")
            CommandText = "SELECT * FROM Employer;"
            LoadDataFromTable(CommandText, ListView1, 5)
            .AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        End With
    End Sub


    Sub LoadDataFromVacancy(ByVal ID As Integer)
        TextBox1.Text = ID
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click 'Добавление записи
        commandtext = "Insert Into [Vacancy] ([JobID], [JobType], [JobName], [District], [Money], [Job giver]) " &
                                        "values ('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', " & "'" & TextBox4.Text & "', " & "'" & TextBox5.Text & "', " & "'" & TextBox6.Text & "')"
        ChangeDataInTable(commandtext)
        Vacancy.LoadDataFromVacancy()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class