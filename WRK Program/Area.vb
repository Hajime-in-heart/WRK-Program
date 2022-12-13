
Imports System.Data.OleDb
Public Class Area
    Private Sub Area_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = frmMain
        LoadDataFromArea()
    End Sub

    Sub LoadDataFromArea()
        ListView1.Items.Clear()
        Commandtext = "SELECT * FROM Area;"
        LoadDataFromTable(Commandtext, ListView1, 2)
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
    End Sub

    Private Sub ДобавитьЗаписьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ДобавитьЗаписьToolStripMenuItem.Click
        CheckedMissingNumber()
        With AddArea
            .Show()
            .MdiParent = frmMain
            .LoadingDataFromArea(Index)
        End With
    End Sub

    Private Sub УдалитьВыбраннуюЗаписьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles УдалитьВыбраннуюЗаписьToolStripMenuItem.Click 'Удаление записи
        Try
            If ListView1.SelectedItems(0).Text <> Nothing Then
                CommandText = "DELETE Area.* FROM Area WHERE ((([ID])=" & ListView1.SelectedItems(0).Text & "));"
                ChangeDataInTable(CommandText)
                LoadDataFromArea()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            If ListView1.SelectedItems(0).Text <> Nothing Then
                LoadSelectedVacancy()
                LoadSelectedArea()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Sub LoadSelectedVacancy()
        ListView2.Items.Clear()
        CommandText = "SELECT [JobID], [JobType], [JobName], [Money] FROM Area INNER JOIN Vacancy ON Area.ID = Vacancy.District WHERE (((Area.ID)=" & ListView1.SelectedItems(0).Text & "));"
        LoadDataFromTable(CommandText, ListView2, 4)
        ListView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
    End Sub

    Sub LoadSelectedArea()
        TextBox1.Text = ListView1.SelectedItems(0).Text
        TextBox2.Text = ListView1.SelectedItems(0).SubItems(1).Text
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
                commandtext = "UPDATE [Area] SET [Area].[District name]='" & TextBox2.Text & "' WHERE (((Area.[ID])=" & TextBox1.Text & "));"
                ChangeDataInTable(commandtext)
                Button1.Visible = False
                TextBox2.ReadOnly = True
                LoadDataFromArea()
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