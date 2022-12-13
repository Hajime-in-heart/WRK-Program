
Public Class StudyPlace
    Private Sub StudyPlace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = frmMain
        LoadDataFromStudyPlace()
    End Sub

    Sub LoadDataFromStudyPlace()
        ListView1.Items.Clear()
        CommandText = "SELECT * FROM [Study place];"
        LoadDataFromTable(CommandText, ListView1, 3)
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            If ListView1.SelectedItems(0).Text <> Nothing Then
                LoadSelectStudyPlace()
                LoadSelectIndividual()
            End If

        Catch ex As Exception

        End Try
    End Sub


    Sub LoadSelectStudyPlace()
        With ListView1
            TextBox1.Text = .SelectedItems(0).Text
            TextBox2.Text = .SelectedItems(0).SubItems(1).Text
            TextBox3.Text = .SelectedItems(0).SubItems(2).Text
        End With
    End Sub

    Sub LoadSelectIndividual()
        ListView2.Items.Clear()
        CommandText = "SELECT Individual.[JoblessID], Individual.[LastName], Individual.[FirstName], Individual.[Patronymic] " &
                                            "FROM [Study place] INNER JOIN (Individual INNER JOIN Study ON Individual.JoblessID = Study.Individual) ON " &
                                            "[Study place].ID = Study.StudyPlace WHERE ((([Study place].ID)=" & ListView1.SelectedItems(0).Text & "));"
        LoadDataFromTable(CommandText, ListView2, 4)
        ListView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
    End Sub

    Private Sub ДобавитьЗаписьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ДобавитьЗаписьToolStripMenuItem.Click
        CheckedMissingNumber()
        With AddStudyPlace
            .Show()
            .MdiParent = frmMain
            .LoadDataFromStudyPlace(Index)
        End With
    End Sub

    Private Sub УдалитьВыбраннуюЗаписьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles УдалитьВыбраннуюЗаписьToolStripMenuItem.Click 'Удаление записи
        Try
            If ListView1.SelectedItems(0).Text <> Nothing Then
                CommandText = "DELETE [Study place].* FROM [Study place] " &
                    "WHERE ((([ID])=" & ListView1.SelectedItems(0).Text & "));"
                ChangeDataInTable(CommandText)
                LoadDataFromStudyPlace()
            End If
        Catch ex As Exception


        End Try

    End Sub
    Private Sub РедактироватьЗаписьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles РедактироватьЗаписьToolStripMenuItem.Click
        Try
            If ListView1.SelectedItems(0).Text <> Nothing Then
                TextBox2.ReadOnly = False
                TextBox3.ReadOnly = False
                Button1.Visible = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'Обновление записи
        Try

            If TextBox2.Text <> Nothing And TextBox3.Text <> Nothing Then
                commandtext = "UPDATE [Study place] SET [Study place].[Name study place]='" & TextBox2.Text & "', [Study place].[StudyAddress]='" & TextBox3.Text & "' WHERE ((([Study place].[ID])=" & TextBox1.Text & "));"
                ChangeDataInTable(commandtext)
                Button1.Visible = False
                TextBox2.ReadOnly = True
                TextBox3.ReadOnly = True
                LoadDataFromStudyPlace()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ЭкспортToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЭкспортToolStripMenuItem.Click
        ExportWord(ListView1, Me.Text)

    End Sub

    Private Sub ЭкспортExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЭкспортExcelToolStripMenuItem.Click
        ExportExcel(ListView1)
    End Sub
End Class