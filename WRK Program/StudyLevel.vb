
Public Class StudyLevel
    Private Sub StudyLevel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = frmMain
        LoadDataFromStudyLevel()
    End Sub


    Sub LoadDataFromStudyLevel()
        ListView1.Items.Clear()
        CommandText = "SELECT * FROM [Study level];"
        LoadDataFromTable(CommandText, ListView1, 2)
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            If ListView1.SelectedItems(0).Text <> Nothing Then
                LoadSelectStudyLevel()
                LoadSelectIndividual()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Sub LoadSelectStudyLevel()
        TextBox1.Text = ListView1.SelectedItems(0).Text
        TextBox2.Text = ListView1.SelectedItems(0).SubItems(1).Text
    End Sub

    Sub LoadSelectIndividual()
        ListView2.Items.Clear()
        CommandText = "SELECT Individual.[JoblessID], Individual.[LastName], Individual.[FirstName], Individual.[Patronymic] " &
                                            "FROM [Study level] INNER JOIN (Individual INNER JOIN Study ON Individual.JoblessID = Study.Individual) ON " &
                                            "[Study level].ID = Study.StudyType WHERE ((([Study level].ID)=" & ListView1.SelectedItems(0).Text & "));"
        LoadDataFromTable(CommandText, ListView2, 4)
        ListView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
    End Sub

    Private Sub ДобавитьЗаписьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ДобавитьЗаписьToolStripMenuItem.Click
        CheckedMissingNumber()
        With AddStudyLevel
            .Show()
            .MdiParent = frmMain
            .LoadingDataFromStudyLevel(Index)
        End With
    End Sub

    Private Sub УдалитьВыбраннуюЗаписьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles УдалитьВыбраннуюЗаписьToolStripMenuItem.Click 'Удаление записи
        Try
            If ListView1.SelectedItems(0).Text <> Nothing Then
                CommandText = "DELETE [Study Level].* FROM [Study Level] " &
                    "WHERE ((([ID])=" & ListView1.SelectedItems(0).Text & "));"
                ChangeDataInTable(CommandText)
                LoadDataFromStudyLevel()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub РедактироватьЗаписьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles РедактироватьЗаписьToolStripMenuItem.Click
        Try
            If ListView1.SelectedItems(0).Text <> Nothing Then
                TextBox2.ReadOnly = False
                Button1.Visible = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'Обновление записи
        Try

            If TextBox2.Text <> Nothing Then
                commandtext = "UPDATE [Study level] SET [Study level].[StudyType]='" & TextBox2.Text & "' WHERE ((([Study level].[ID])=" & TextBox1.Text & "));"
                ChangeDataInTable(commandtext)
                Button1.Visible = False
                TextBox2.ReadOnly = True
                LoadDataFromStudyLevel()
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