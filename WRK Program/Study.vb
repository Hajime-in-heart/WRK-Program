
Public Class Study
    Private Sub Study_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = frmMain
        LoadDataFromStudy()
    End Sub


    Sub LoadDataFromStudy()
        ListView1.Items.Clear()
        CommandText = "SELECT * FROM Study;"
        LoadDataFromTable(CommandText, ListView1, 4)
    End Sub

    Sub LoadSelectStudy()
        With ListView1
            TextBox1.Text = .SelectedItems(0).Text
            TextBox2.Text = .SelectedItems(0).SubItems(1).Text
            TextBox3.Text = .SelectedItems(0).SubItems(2).Text
            TextBox4.Text = .SelectedItems(0).SubItems(3).Text
        End With
    End Sub

    Sub LoadSelectStudyPlace()
        ListView2.Items.Clear()
        CommandText = "SELECT * FROM [Study place] WHERE ((([ID])=" & ListView1.SelectedItems(0).SubItems(1).Text & "));"
        LoadDataFromTable(CommandText, ListView2, 3)
    End Sub

    Sub LoadSelectStudyLevel()
        ListView3.Items.Clear()
        CommandText = "SELECT * FROM [Study level] WHERE ((([ID])=" & ListView1.SelectedItems(0).SubItems(2).Text & "));"
        LoadDataFromTable(CommandText, ListView3, 2)
    End Sub

    Sub LoadSelectIndividual()
        ListView4.Items.Clear()
        CommandText = "SELECT [JoblessID], [LastName], [FirstName], [Patronymic] FROM Individual " &
                                            "INNER JOIN Study ON Individual.JoblessID = Study.Individual WHERE (((Study.Individual)=" & ListView1.SelectedItems(0).SubItems(3).Text & "));"
        LoadDataFromTable(CommandText, ListView4, 4)
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            If ListView1.SelectedItems(0).Text <> Nothing Then
                LoadSelectStudy()
                LoadSelectStudyPlace()
                LoadSelectStudyLevel()
                LoadSelectIndividual()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ДобавитьЗаписьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ДобавитьЗаписьToolStripMenuItem.Click
        CheckedMissingNumber()
        With AddStudy
            .MdiParent = frmMain
            .Show()
            .LoadDataFromStudy(Index)
        End With
    End Sub

    Private Sub УдалитьЗаписьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles УдалитьЗаписьToolStripMenuItem.Click 'Удаление записи
        Try
            If ListView1.SelectedItems(0).Text <> Nothing Then
                CommandText = "DELETE [ID], [Individual], [StudyType], [StudyPlace], [Study].* FROM [Study] " &
                    "WHERE ((([ID])=" & ListView1.SelectedItems(0).Text & "));"
                ChangeDataInTable(CommandText)
                LoadDataFromStudy()
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