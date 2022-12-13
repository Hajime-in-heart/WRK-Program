
Public Class Employer
    Dim ID As Integer
    Private Sub Employer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = frmMain
        LoadDataFromEmployer()
    End Sub


    Sub LoadDataFromEmployer()
        ListView1.Items.Clear()
        CommandText = "SELECT * FROM Employer;"
        LoadDataFromTable(CommandText, ListView1, 5)
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            If ListView1.SelectedItems(0).Text <> Nothing Then
                LoadSelectedVacancy()
                LoadSelectedEmployer()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Sub LoadSelectedVacancy()
        ListView2.Items.Clear()
        CommandText = "SELECT [JobID], [JobType], [JobName], [Money] FROM Employer INNER JOIN Vacancy ON Employer.JobGiver = Vacancy.[Job giver] WHERE (((Employer.JobGiver)=" & ListView1.SelectedItems(0).Text & "));"
        LoadDataFromTable(CommandText, ListView2, 4)
        ListView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
    End Sub

    Sub LoadSelectedEmployer()
        With ListView1
            TextBox1.Text = .SelectedItems(0).Text
            TextBox2.Text = .SelectedItems(0).SubItems(1).Text
            TextBox3.Text = .SelectedItems(0).SubItems(2).Text
            TextBox4.Text = .SelectedItems(0).SubItems(3).Text
            TextBox5.Text = .SelectedItems(0).SubItems(4).Text
        End With
    End Sub


    Private Sub ДобавитьЗаписьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ДобавитьЗаписьToolStripMenuItem.Click
        CheckedMissingNumber()
        With AddEmployer
            .Show()
            .MdiParent = frmMain
            .LoadingDataFromEmployer(Index)
        End With

    End Sub

    Private Sub УдалитьВыбраннуюЗаписьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles УдалитьВыбраннуюЗаписьToolStripMenuItem.Click 'Удаление записи
        Try
            If ListView1.SelectedItems(0).Text <> Nothing Then
                CommandText = "DELETE Employer.* FROM Employer " &
                    "WHERE ((([JobGiver])=" & ListView1.SelectedItems(0).Text & "));"
                ChangeDataInTable(CommandText)
                LoadDataFromEmployer()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'Обновление записи
        Try

            If TextBox2.Text & TextBox3.Text & TextBox4.Text & TextBox5.Text <> Nothing Then
                commandtext = "UPDATE [Employer] SET [Name job giver]='" & TextBox2.Text & "', [Place]='" & TextBox3.Text & "', [Mobile]='
                              " & TextBox4.Text & "', [More]='" & TextBox5.Text & "' WHERE (([JobGiver])=" & TextBox1.Text & ");"
                ChangeDataInTable(commandtext)
                Button1.Visible = False
                TextBox2.ReadOnly = True
                TextBox3.ReadOnly = True
                TextBox4.ReadOnly = True
                TextBox5.ReadOnly = True

                LoadDataFromEmployer()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub РедактироватьЗаписьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles РедактироватьЗаписьToolStripMenuItem.Click
        Try
            If ListView1.SelectedItems(0).Text <> Nothing Then
                Button1.Visible = True
                TextBox2.ReadOnly = False
                TextBox3.ReadOnly = False
                TextBox4.ReadOnly = False
                TextBox5.ReadOnly = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ЭкспортWordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЭкспортWordToolStripMenuItem.Click
        ExportWord(ListView1, Me.Text)
    End Sub

    Private Sub ЭкспортExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЭкспортExcelToolStripMenuItem.Click
        ExportExcel(ListView1)
    End Sub
End Class