
Public Class AddStudy
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Select Case Button3.Text
            Case "Подтвердить"
                ListView1.Enabled = False
                Button8.Enabled = True
                Try
                    With ListView1
                        TextBox5.Text = .SelectedItems(0).Text
                        TextBox6.Text = .SelectedItems(0).SubItems(1).Text
                        TextBox7.Text = .SelectedItems(0).SubItems(2).Text
                    End With
                    TextBox2.Text = TextBox5.Text
                Catch ex As Exception

                End Try
                Button3.Text = "Выбрать"
                ListView1.Items.Clear()
                Me.Width = 661
            Case "Выбрать"
                Me.Width = 1151
                LoadListStudyPlace()
                ListView1.Enabled = True
                Button8.Enabled = False
                Button3.Text = "Подтвердить"
        End Select
    End Sub


    Sub LoadListStudyPlace()
        With ListView1
            .Items.Clear()
            .Columns.Clear()
            .Columns.Add("ID")
            .Columns.Add("Название")
            .Columns.Add("Адрес")
            CommandText = "SELECT * FROM [Study place];"
            LoadDataFromTable(CommandText, ListView1, 3)
            .AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        End With
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Select Case Button8.Text
            Case "Подтвердить"
                ListView1.Enabled = False
                Button3.Enabled = True
                Try
                    With ListView1
                        TextBox8.Text = .SelectedItems(0).Text
                        TextBox9.Text = .SelectedItems(0).SubItems(1).Text
                    End With
                    TextBox3.Text = TextBox8.Text
                Catch ex As Exception

                End Try
                Button8.Text = "Выбрать"
                ListView1.Items.Clear()
                Me.Width = 661
            Case "Выбрать"
                Me.Width = 1151
                LoadListStudyType()
                ListView1.Enabled = True
                Button3.Enabled = True
                Button8.Text = "Подтвердить"
        End Select
    End Sub

    Sub LoadListStudyType()
        With ListView1
            .Items.Clear()
            .Columns.Clear()
            .Columns.Add("ID")
            .Columns.Add("Тип")
            CommandText = "SELECT * FROM [Study level]"
            LoadDataFromTable(CommandText, ListView1, 2)
            .AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        End With
    End Sub

    Private Sub AddStudy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 661
    End Sub

    Sub LoadDataFromStudy(ByVal ID As Integer)
        TextBox1.Text = ID
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click 'Добавление записи
        CommandText = "Insert Into [Study] ([ID], [Individual], [StudyType], [StudyPlace]) " &
                      "values ('" & TextBox1.Text & "', Null , '" & TextBox2.Text & "', " & "'" & TextBox3.Text & "')"
        ChangeDataInTable(CommandText)
        Study.LoadDataFromStudy()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class