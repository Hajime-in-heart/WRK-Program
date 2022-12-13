Imports System.Data.OleDb
Public Class AddUnemployed
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Select Case Button3.Text
            Case "Подтвердить"
                ListView1.Enabled = False
                Button8.Enabled = True
                Button1.Enabled = True
                Try
                    With ListView1
                        TextBox5.Text = .SelectedItems(0).Text
                        TextBox7.Text = .SelectedItems(0).SubItems(1).Text
                        TextBox8.Text = .SelectedItems(0).SubItems(2).Text
                    End With
                    TextBox6.Text = TextBox1.Text
                Catch ex As Exception

                End Try
                Button3.Text = "Выбрать"
                ListView1.Items.Clear()
                Me.Width = 670
            Case "Выбрать"
                Me.Width = 1160
                LoadListStudy()
                ListView1.Enabled = True
                Button8.Enabled = False
                Button1.Enabled = False
                Button3.Text = "Подтвердить"
        End Select
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Select Case Button8.Text
            Case "Подтвердить"
                ListView1.Enabled = False
                Button3.Enabled = True
                Button1.Enabled = True
                Try
                    TextBox16.Text = ListView1.SelectedItems(0).Text
                    TextBox17.Text = Now.ToShortDateString
                Catch ex As Exception

                End Try
                Button8.Text = "Выбрать"
                ListView1.Items.Clear()
                Me.Width = 670
            Case "Выбрать"
                Me.Width = 1160
                LoadListUsers()
                ListView1.Enabled = True
                Button3.Enabled = False
                Button1.Enabled = False
                Button8.Text = "Подтвердить"
        End Select

    End Sub

    Sub LoadListStudy()
        With ListView1
            .Items.Clear()
            .Columns.Clear()
            .Columns.Add("ID")
            .Columns.Add("Тип образования")
            .Columns.Add("Место обучения")
            CommandText = "SELECT * FROM Study;"
            Try
                Dim command As New OleDbCommand(CommandText, connector)
                connector.Open()
                datareader = command.ExecuteReader
                While datareader.Read() = True
                    .Items.Add(datareader.GetValue(0))
                    .Items.Item(.Items.Count - 1).SubItems.Add(datareader.GetValue(2))
                    .Items.Item(.Items.Count - 1).SubItems.Add(datareader.GetValue(3))
                End While
                datareader.Close()
                connector.Close()
            Catch ex As Exception
                connector.Close()
                MsgBox(ex.Message)
            End Try
        End With
    End Sub


    Sub LoadListUsers()
        With ListView1
            .Items.Clear()
            .Columns.Clear()
            .Columns.Add("ID")
            .Columns.Add("Имя")
            .Columns.Add("Фамилия")
            .Columns.Add("Отчество")
            CommandText = "SELECT * FROM Users WHERE ((([Job title])='Registar'));"
            LoadDataFromTable(CommandText, ListView1, 4)
            .AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

        End With
    End Sub
    Sub LoadListPlaceOfIssue()
        With ListView1
            .Items.Clear()
            .Columns.Clear()
            .Columns.Add("ID")
            .Columns.Add("Место выдачи")
            CommandText = "SELECT * FROM [Place of issue];"
            LoadDataFromTable(CommandText, ListView1, 2)
        End With
    End Sub

    Sub LoadDataFromUnemployed(ByVal ID As Integer)
        TextBox1.Text = ID
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case Button1.Text
            Case "Подтвердить"
                ListView1.Enabled = False
                Button8.Enabled = True
                Button3.Enabled = True
                Try
                    With ListView1
                        TextBox21.Text = .SelectedItems(0).Text
                        TextBox24.Text = .SelectedItems(0).SubItems(1).Text
                        TextBox12.Text = .SelectedItems(0).Text
                    End With
                Catch ex As Exception

                End Try
                Button1.Text = "Выбрать"
                ListView1.Items.Clear()
                Me.Width = 670
            Case "Выбрать"
                Me.Width = 1160
                LoadListPlaceOfIssue()
                ListView1.Enabled = True
                Button8.Enabled = False
                Button3.Enabled = False
                Button1.Text = "Подтвердить"
        End Select

    End Sub

    Private Sub AddUnemployed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 670
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click 'Добавление записи
        commandtext = "Insert Into [Individual] ([JoblessID], [LastName], [FirstName], [Patronymic], [Age], [Passport], [PassportDate], [Region], [Address], [Phone], [Experience]) " &
                      "values ('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', " & "'" & TextBox4.Text & "', " & "'" & TextBox9.Text & "', " &
                      "'" & TextBox10.Text & "', " & "'" & TextBox11.Text & "', " & "'" & TextBox12.Text & "', " & "'" & TextBox13.Text & "', " & "'" & TextBox14.Text & "', " &
                      "" & TextBox22.Text & ")"
        ChangeDataInTable(commandtext)
        List_of_unemployed.LoadListOfUnemployed()


        commandtext = "UPDATE Study SET [Individual] = " & TextBox6.Text & " WHERE ((([ID])=" & TextBox5.Text & "));"
        ChangeDataInTable(commandtext)


        commandtext = "Insert Into [Аrchive and accounting] ([Registrar], [RegDate], [Payment], [Comment], [ArchivesDate], [Individual], [Job vacancy]) " &
                                        "values ('" & TextBox16.Text & "', '" & TextBox17.Text & "', '" & TextBox18.Text & "', '" & TextBox19.Text & "', Null, '" & TextBox1.Text & "', Null)"
        ChangeDataInTable(commandtext)
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class