
Public Class PlaceOfIssue
    Private Sub PlaceOfIssue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = frmMain
        LoadDataFromPlaceOfIssue()
    End Sub

    Sub LoadDataFromPlaceOfIssue()
        ListView1.Items.Clear()
        CommandText = "SELECT * FROM [Place of issue];"
        LoadDataFromTable(CommandText, ListView1, 2)
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
    End Sub

    Sub LoadSelectPlaceOfIssue()
        TextBox1.Text = ListView1.SelectedItems(0).Text
        TextBox2.Text = ListView1.SelectedItems(0).SubItems(1).Text
    End Sub

    Sub LoadSelectIndividual()
        ListView2.Items.Clear()
        CommandText = "SELECT [JoblessID], [LastName], [FirstName], [Patronymic] " &
                                            "FROM [Place of issue] INNER JOIN Individual ON [Place of issue].ID = Individual.Region " &
                                            "WHERE ((([Place of issue].ID)=" & ListView1.SelectedItems(0).Text & "));"
        LoadDataFromTable(CommandText, ListView2, 4)
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            If ListView1.SelectedItems(0).Text <> Nothing Then
                LoadSelectPlaceOfIssue()
                LoadSelectIndividual()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ДобавитьЗаписьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ДобавитьЗаписьToolStripMenuItem.Click
        CheckedMissingNumber()
        With AddPlaceOfIssue
            .Show()
            .MdiParent = frmMain
            .LoadDataFromPlaceOfIssue(Index)
        End With
    End Sub

    Private Sub УдалитьВыбраннуюЗаписьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles УдалитьВыбраннуюЗаписьToolStripMenuItem.Click 'Удаление записи
        Try
            If ListView1.SelectedItems(0).Text <> Nothing Then
                CommandText = "DELETE [Place of issue].* FROM [Place of issue] " &
                    "WHERE ((([ID])=" & ListView1.SelectedItems(0).Text & "));"
                ChangeDataInTable(CommandText)
                LoadDataFromPlaceOfIssue()
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
                commandtext = "UPDATE [Place of issue] SET [Place of issue].[Gived]='" & TextBox2.Text & "' WHERE ((([Place of issue].[ID])=" & TextBox1.Text & "));"
                ChangeDataInTable(commandtext)
                Button1.Visible = False
                TextBox2.ReadOnly = True
                LoadDataFromPlaceOfIssue()
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