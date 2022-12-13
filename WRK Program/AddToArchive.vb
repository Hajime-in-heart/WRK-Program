
Public Class AddToArchive
    Dim ListViewMode As String
    Private Sub AddToArchive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 658
    End Sub


    Sub LoadingDataFromListOfUnemplyed(ID As Integer, ByVal Lastname As String, ByVal Patronymic As String, ByVal FirstName As String)
        TextBox1.Text = ID
        TextBox2.Text = Lastname
        TextBox3.Text = FirstName
        TextBox4.Text = Patronymic
    End Sub

    Sub LoadingListVacancy()
        With ListView1
            .Items.Clear()
            .Columns.Clear()
            .Columns.Add("ID")
            .Columns.Add("Тип")
            .Columns.Add("Название")
            .Columns.Add("Код местоположения")
            .Columns.Add("З/П")
            .Columns.Add("ID работодателя")
            CommandText = "SELECT * FROM Vacancy LEFT JOIN [Аrchive and accounting] " &
                                                "ON Vacancy.[JobID] = [Аrchive and accounting].[Job vacancy] WHERE ((([Аrchive and accounting].[Job vacancy]) Is Null));"
            LoadDataFromTable(CommandText, ListView1, 6)
            .AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        End With

    End Sub



    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ListViewMode = "Vacancy"
        Select Case Button8.Text
            Case "Подтвердить"
                ListView1.Enabled = False
                Try
                    With ListView1
                        TextBox16.Text = .SelectedItems(0).Text
                        TextBox17.Text = .SelectedItems(0).SubItems(1).Text
                        TextBox18.Text = .SelectedItems(0).SubItems(2).Text
                        TextBox19.Text = .SelectedItems(0).SubItems(3).Text
                        TextBox20.Text = .SelectedItems(0).SubItems(4).Text
                        TextBox21.Text = .SelectedItems(0).SubItems(5).Text
                    End With
                Catch ex As Exception

                End Try
                Button8.Text = "Выбрать"
                ListView1.Items.Clear()
                Me.Width = 658
            Case "Выбрать"
                Me.Width = 1153
                LoadingListVacancy()
                ListView1.Enabled = True
                Button8.Text = "Подтвердить"
        End Select
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click 'Обновление записи
        commandtext = "UPDATE [Аrchive and accounting] SET [Job vacancy] = " & TextBox16.Text & ", " &
            "[ArchivesDate] = '" & Now.ToShortDateString & "' WHERE ((([Individual])=" & TextBox1.Text & "));"
        ChangeDataInTable(commandtext)
        Me.Close()
        List_of_unemployed.LoadListOfUnemployed()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class