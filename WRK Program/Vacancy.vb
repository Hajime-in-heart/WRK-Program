Imports System.Data.OleDb
Public Class Vacancy
    Private Sub Vacancy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = frmMain
        LoadDataFromVacancy()
    End Sub


    Sub LoadDataFromVacancy()
        ListView1.Items.Clear()
        CommandText = "SELECT [JobID], [JobType], [JobName], [Money] FROM Vacancy;"
        LoadDataFromTable(CommandText, ListView1, 4)
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            If ListView1.SelectedItems(0).Text <> Nothing Then
                LoadSelectedVacancy()
                LoadSelectedArea()
                LoadSelectedEmployer()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Sub LoadSelectedVacancy()
        Try
            Dim command As New OleDbCommand("SELECT * FROM Vacancy WHERE ((([JobID])=" & ListView1.SelectedItems(0).Text & "));", connector)
            connector.Open()
            datareader = command.ExecuteReader
            While datareader.Read() = True
                TextBox1.Text = datareader.getvalue(0)
                TextBox2.Text = datareader.getvalue(1)
                TextBox3.Text = datareader.getvalue(2)
                TextBox5.Text = datareader.getvalue(3)
                TextBox4.Text = datareader.getvalue(4)
                TextBox6.Text = datareader.getvalue(5)
            End While
            datareader.Close()
            connector.Close()
        Catch ex As Exception
            connector.Close()
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub LoadSelectedArea()
        ListView2.Items.Clear()
        Try
            If ListView1.SelectedItems(0).Text <> Nothing Then
                CommandText = "SELECT * FROM Area WHERE ((([ID])=" & TextBox5.Text & "));"
                LoadDataFromTable(CommandText, ListView2, 2)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Sub LoadSelectedEmployer()
        ListView3.Items.Clear()
        Try
            If ListView1.SelectedItems(0).Text <> Nothing Then

                CommandText = "SELECT * FROM Employer WHERE ((([JobGiver])=" & TextBox6.Text & "));"
                LoadDataFromTable(CommandText, ListView3, 5)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ДобавитьЗаписьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ДобавитьЗаписьToolStripMenuItem.Click
        CheckedMissingNumber()
        With AddVacancy
            .Show()
            .MdiParent = frmMain
            .LoadDataFromVacancy(Index)
        End With
    End Sub

    Private Sub УдалитьЗаписьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles УдалитьЗаписьToolStripMenuItem.Click 'Удаление записи
        Try
            If ListView1.SelectedItems(0).Text <> Nothing Then
                CommandText = "DELETE Vacancy.* FROM Vacancy WHERE ((([JobID])=" & ListView1.SelectedItems(0).Text & "));"
                ChangeDataInTable(CommandText)
                LoadDataFromVacancy()
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