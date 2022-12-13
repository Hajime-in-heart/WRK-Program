Imports System.Data.OleDb
Public Class List_of_unemployed
    Dim Experience As Boolean
    Dim ID As Integer
    Dim LastName As String
    Dim firstName As String
    Dim Patronymic As String
    Dim CommandText As String
    Dim datareader As OleDbDataReader
    Private Sub List_of_unemployed_Load(sender As Object, e As EventArgs) Handles Me.Load
        MdiParent = frmMain
        LoadListOfUnemployed()
    End Sub


    Sub LoadListOfUnemployed()
        ListView1.Items.Clear()
        CommandText = "SELECT JoblessID, LastName, FirstName, Patronymic " &
                                            "FROM Individual INNER JOIN [Аrchive and accounting] ON Individual.[JoblessID] = [Аrchive and accounting].[Individual] " &
                                            "WHERE ((([Аrchive and accounting].ArchivesDate) Is Null) AND " &
                                            "(([Аrchive and accounting].[Job vacancy]) Is Null));"
        LoadDataFromTable(CommandText, ListView1, 4)
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        With ListView1
            Try
                If .SelectedItems(0).Text <> Nothing Then
                    ID = .SelectedItems(0).Text
                    LastName = .SelectedItems(0).SubItems(1).Text
                    firstName = .SelectedItems(0).SubItems(2).Text
                    Patronymic = .SelectedItems(0).SubItems(3).Text
                    LoadSelectUnemployedHeadData(ID)
                    LoadSelectUnemployesPassport()
                    LoadSelectUnemployedStudy(ID)
                    LoadSelectUnemployedAccounting(ID)
                End If
            Catch ex As Exception

            End Try
        End With
    End Sub

    Sub LoadSelectUnemployedHeadData(ByVal ID As Integer)
        Try
            ListView2.Items.Clear()
            CommandText = "Select [LastName], [FirstName], [Patronymic], [Age], [Passport], " &
            "[PassportDate], [Region], [Address], [Phone], [Picture], " &
            "[Experience] From [Individual] Where (((Individual.JoblessID) = " & ID & "));"
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

    Sub LoadSelectUnemployesPassport()
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


    Sub LoadSelectUnemployedStudy(ByVal ID As Integer)
        CommandText = "SELECT [Study level].[StudyType], [Study place].[Name study place], " &
                    "[Study place].StudyAddress FROM [Study place] INNER JOIN ([Study level] INNER JOIN " &
                    "Study ON [Study level].ID = Study.StudyType) ON [Study place].ID = Study.StudyPlace " &
                    "WHERE (((Study.Individual)=" & ID & "));"
        LoadDataFromTable(CommandText, ListView2, 3)
        ListView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

    End Sub


    Sub LoadSelectUnemployedAccounting(ByVal ID As Integer)
        Try
            CommandText = "SELECT Users.LastName, Users.FirstName, Users.Patronymic, [Аrchive and accounting].[RegDate], [Аrchive and accounting].[Payment], [Аrchive and accounting].[Comment]
FROM Users INNER JOIN [Аrchive and accounting] ON Users.ID = [Аrchive and accounting].Registrar
WHERE ((([Аrchive and accounting].[Individual])=" & ID & "));
"
            Dim Command As New OleDbCommand(CommandText, connector)
            connector.Open()
            Dim Datareader1 As OleDbDataReader
            Datareader1 = Command.ExecuteReader
            While datareader1.Read() = True
                TextBox12.Text = Datareader1.GetValue(0) & " " & Datareader1.GetValue(1) & " " & Datareader1.GetValue(2)
                TextBox15.Text = Datareader1.GetValue(3)
                TextBox16.Text = Datareader1.GetValue(4)
                TextBox17.Text = Datareader1.GetValue(5)
            End While
            connector.Close()
        Catch ex As Exception
            connector.Close()
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ПеренестиЗаписьВАрхивToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПеренестиЗаписьВАрхивToolStripMenuItem.Click
        If ID <> Nothing Then
            SendToArchive()
        End If

    End Sub


    Sub SendToArchive()
        With AddToArchive
            .Show()
            .MdiParent = frmMain
            .LoadingDataFromListOfUnemplyed(ID, LastName, firstName, Patronymic)
        End With
    End Sub

    Private Sub ДобавитьЗаписьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ДобавитьЗаписьToolStripMenuItem.Click
        Try
            CommandText = "SELECT * From Individual"
            Dim Command As New OleDbCommand(CommandText, connector)
            connector.Open()
            datareader = Command.ExecuteReader
            While datareader.Read() = True
                ListView3.Items.Add(datareader.GetValue(0))
            End While
            datareader.Close()
            connector.Close()
        Catch ex As Exception
            connector.Close()
            MsgBox(ex.Message)
        End Try
        CheckedMissingNumber()

        With AddUnemployed
            .Show()
            .MdiParent = frmMain
            .LoadDataFromUnemployed(Index)
        End With
    End Sub

    Private Sub ЭкспортWordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЭкспортWordToolStripMenuItem.Click
        ExportWord(ListView1, Me.Text)
    End Sub

    Private Sub ЭкспортWordToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ЭкспортWordToolStripMenuItem1.Click
        ExportExcel(ListView1)
    End Sub
End Class