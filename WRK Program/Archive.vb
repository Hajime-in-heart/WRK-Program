Imports System.Data.OleDb
Public Class Archive
    Dim ID As Integer
    Private Sub Archive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = frmMain
        LoadListArchive1()
    End Sub


    Sub LoadListArchive1()
        ListView1.Items.Clear()
        Dim JoblessID As Integer
        Try
            Dim command As New OleDbCommand("SELECT [Individual] FROM [Аrchive and accounting] WHERE ((([ArchivesDate]) Is Not Null) AND (([Job vacancy]) Is Not Null));", connector)
            connector.Open()
            datareader = command.ExecuteReader
            While datareader.Read() = True
                JoblessID = DataReader.GetValue(0)
                LoadListArchive(JoblessID)
            End While
            datareader.Close()
            connector.Close()
        Catch ex As Exception
            connector.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub LoadListArchive(ByVal JoblessID As Integer)
        Try
            Dim command As New OleDbCommand("SELECT [JoblessID], [LastName], [FirstName], [Patronymic] FROM Individual WHERE ((([JoblessID])=" & JoblessID & "));", connector)
            Dim datareader1 As OleDbDataReader
            datareader1 = command.ExecuteReader
            While datareader1.Read() = True
                With ListView1
                    .Items.Add(datareader1.GetValue(0))
                    .Items.Item(.Items.Count - 1).SubItems.Add(datareader1.GetValue(1))
                    .Items.Item(.Items.Count - 1).SubItems.Add(datareader1.GetValue(2))
                    .Items.Item(.Items.Count - 1).SubItems.Add(datareader1.GetValue(3))
                End With
            End While
        Catch ex As Exception
            connector.Close()
            MsgBox(ex.Message)
        End Try
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            If ListView1.SelectedItems(0).Text <> Nothing Then
                ID = ListView1.SelectedItems(0).Text
                LoadSelectArchiveHeadData(ID)
                LoadSelectArchivePassport()
                LoadSelectArchiveStudy(ID)
                LoadSelectArchiveAccounting(ID)
                LoadSelectArchiveVacancy(ID)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub LoadSelectArchiveHeadData(ByVal ID As Integer)

        Try
            CommandText = "Select [LastName], [FirstName], [Patronymic], [Age], [Passport], " &
            "[PassportDate], [Region], [Address], [Phone], [Picture], " &
            "[Experience] From [Individual] Where (((JoblessID) = " & ID & "));"

            Dim command As New OleDbCommand(CommandText, connector)
            connector.Open()
            datareader = command.ExecuteReader
            While datareader.Read() = True
                TextBox1.Text = datareader.GetValue(0)
                TextBox2.Text = datareader.GetValue(1)
                TextBox3.Text = datareader.GetValue(2)
                TextBox4.Text = datareader.GetValue(3)
                TextBox5.Text = datareader.GetValue(4)
                TextBox6.Text = datareader.GetValue(5)
                TextBox11.Text = datareader.GetValue(6)
                TextBox8.Text = datareader.GetValue(7)
                TextBox9.Text = datareader.GetValue(8)
                TextBox10.Text = datareader.GetValue(10)
            End While
            datareader.Close()
            connector.Close()
        Catch ex As Exception
            connector.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub LoadSelectArchivePassport()
        Try
            CommandText = "SELECT [Gived] FROM [Place of issue] WHERE ((([ID])=" & TextBox11.Text & "));"
            Dim Command As New OleDbCommand(CommandText, connector)
            connector.Open()
            datareader = Command.ExecuteReader
            While datareader.Read() = True
                TextBox7.Text = datareader.GetValue(0)
            End While
            datareader.Close()
            connector.Close()
        Catch ex As Exception
            connector.Close()
            MsgBox(ex.Message)
        End Try
    End Sub


    Sub LoadSelectArchiveStudy(ByVal ID As Integer)
        ListView2.Items.Clear()
        CommandText = "SELECT [Study level].[StudyType], [Study place].[Name study place], " &
                "[Study place].StudyAddress FROM [Study place] INNER JOIN ([Study level] INNER JOIN " &
                "Study ON [Study level].ID = Study.StudyType) ON [Study place].ID = Study.StudyPlace " &
                "WHERE (((Study.Individual)=" & ID & "));"
        LoadDataFromTable(CommandText, ListView2, 3)
        ListView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

    End Sub


    Sub LoadSelectArchiveAccounting(ByVal ID As Integer)
        Dim UserID As Integer
        Try
            CommandText = "SELECT [Registrar], [RegDate], [Payment], " &
                "[Comment], [ArchivesDate] FROM [Аrchive and accounting] WHERE ((([Individual])=" & ID & "));"
            Dim Command As New OleDbCommand(CommandText, connector)
            connector.Open()
            datareader = Command.ExecuteReader
            While datareader.Read() = True
                UserID = datareader.getvalue(0)
                LoadSelectArchiveAccounting1(UserID)
                TextBox15.Text = datareader.getvalue(1)
                TextBox16.Text = datareader.getvalue(2)
                Try
                    TextBox17.Text = datareader.getvalue(3)
                Catch ex As Exception

                End Try
                TextBox13.Text = DataReader.GetValue(4)
            End While
            DataReader.close()
            connector.Close()
        Catch ex As Exception
            connector.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub LoadSelectArchiveAccounting1(ByVal UserID As Integer)
        Try
            Dim command As New OleDbCommand("SELECT [LastName], [FirstName], [Patronymic] " &
                                            "FROM Users WHERE ((([ID])=" & UserID & ") AND (([Job title])='Registar'));", connector)
            DataReader1 = command.ExecuteReader
            While DataReader1.Read() = True
                TextBox12.Text = DataReader1.getvalue(0) & " " & DataReader1.getvalue(1) & " " & DataReader1.getvalue(2)
            End While
        Catch ex As Exception
            connector.Close()
            MsgBox(ex.Message)
        End Try

    End Sub


    Sub LoadSelectArchiveVacancy(ByVal ID As Integer)
        ListView3.Items.Clear()
        CommandText = "SELECT [JobType], [JobName], [Money] FROM Vacancy INNER JOIN " &
                    "[Аrchive and accounting] ON Vacancy.JobID = [Аrchive and accounting].[Job vacancy] " &
                    "WHERE ((([Аrchive and accounting].Individual)=" & ID & "));"
        LoadDataFromTable(CommandText, ListView3, 3)
        ListView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
    End Sub


    Private Sub УдалитьВыбраннуюЗаписьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles УдалитьВыбраннуюЗаписьToolStripMenuItem.Click
        If ListView1.SelectedItems(0).Text <> Nothing Then
            DeleteNoteFromSystem()
        End If
    End Sub

    Private Sub СделатьЗаписьАктивнойToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СделатьЗаписьАктивнойToolStripMenuItem.Click
        If ID <> Nothing Then
            ActivateNote()
        End If

    End Sub

    Sub DeleteNoteFromSystem() 'Удаление записи
        CommandText = "DELETE Study.*, Study.[ID], Study.[Individual], Study.[StudyType], Study.[StudyPlace], Individual.JoblessID " &
            "FROM Individual INNER JOIN Study ON Individual.JoblessID = Study.Individual WHERE (((Individual.JoblessID)=" & ID & "));"
        ChangeDataInTable(CommandText)


        CommandText = "DELETE [Аrchive and accounting].* " &
                "FROM [Аrchive and accounting] WHERE ((([Individual])=" & ID & "));"
        ChangeDataInTable(CommandText)


        CommandText = "DELETE Individual.* FROM Individual " &
                "WHERE ((([JoblessID])=" & ID & "));"
        ChangeDataInTable(CommandText)
        LoadListArchive1()
    End Sub

    Sub ActivateNote() 'Обновление записи
        commandtext = "UPDATE [Аrchive and accounting] SET [Job vacancy] = Null, " &
            "[ArchivesDate] = Null  WHERE [Individual]=" & ID & ";"
        ChangeDataInTable(commandtext)
        LoadListArchive1()
    End Sub

    Private Sub ДобавитьЗаписьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ДобавитьЗаписьToolStripMenuItem.Click
        List_of_unemployed.Show()
        Me.Close()
    End Sub

    Private Sub ЭкспортWORDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЭкспортWordToolStripMenuItem.Click
        ExportWord(ListView1, Me.Text)
    End Sub

    Private Sub ЭкспортExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЭкспортExcelToolStripMenuItem.Click
        ExportExcel(ListView1)
    End Sub
End Class