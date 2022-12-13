Imports System.Data.OleDb
Public Class Users
    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = frmMain
        LoadListUsers()
    End Sub

    Sub LoadListUsers()
        ListView1.Items.Clear()
        Try
            Dim command As New OleDbCommand("SELECT * FROM Users;", connector)
            connector.Open()
            datareader = command.ExecuteReader
            While DataReader.Read() = True
                With ListView1
                    .Items.Add(DataReader.GetValue(0))
                    .Items.Item(.Items.Count - 1).SubItems.Add(DataReader.GetValue(1))
                    .Items.Item(.Items.Count - 1).SubItems.Add(DataReader.GetValue(2))
                    .Items.Item(.Items.Count - 1).SubItems.Add(DataReader.GetValue(3))
                    .Items.Item(.Items.Count - 1).SubItems.Add(DataReader.GetValue(7))
                End With
            End While
            DataReader.Close()
            connector.Close()
        Catch ex As Exception
            connector.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            If ListView1.SelectedItems(0).Text <> Nothing Then
                LoadSelectUser(ListView1.SelectedItems(0).Text)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub LoadSelectUser(ByVal ID As Integer)
        Try
            Dim command As New OleDbCommand("SELECT * FROM Users WHERE ((([ID])=" & ID & "));", connector)
            connector.Open()
            datareader = command.ExecuteReader
            While datareader.Read() = True
                TextBox1.Text = datareader.getvalue(0)
                TextBox2.Text = datareader.getvalue(1)
                TextBox3.Text = datareader.getvalue(2)
                TextBox4.Text = datareader.getvalue(3)
                TextBox5.Text = datareader.getvalue(4)
                TextBox6.Text = datareader.getvalue(5)
                TextBox7.Text = datareader.getvalue(6)
                TextBox8.Text = datareader.getvalue(7)
            End While
            datareader.Close()
            connector.Close()
        Catch ex As Exception
            connector.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ДобавитьЗаписьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ДобавитьЗаписьToolStripMenuItem.Click
        CheckedMissingNumber()
        With AddUser
            .Show()
            .MdiParent = frmMain
            .LoadingDataFromUsers(Index)
        End With
    End Sub

    Private Sub УдалитьВыбраннуюЗаписьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles УдалитьВыбраннуюЗаписьToolStripMenuItem.Click 'Удаление записи
        Try
            If ListView1.SelectedItems(0).Text <> Nothing Then
                CommandText = "DELETE Users.* FROM Users WHERE ((([ID])=" & ListView1.SelectedItems(0).Text & "));"
                ChangeDataInTable(CommandText)
                LoadListUsers()
            End If
        Catch ex As Exception


        End Try
    End Sub

    Private Sub РедактироватьЗаписьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles РедактироватьЗаписьToolStripMenuItem.Click
        Try
            If ListView1.SelectedItems(0).Text <> Nothing Then
                TextBox2.ReadOnly = False
                TextBox3.ReadOnly = False
                TextBox4.ReadOnly = False
                TextBox5.ReadOnly = False
                TextBox6.ReadOnly = False
                TextBox7.ReadOnly = False
                TextBox8.ReadOnly = False
                Button1.Visible = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'Обновление записи
        Try
            If TextBox2.Text & TextBox3.Text & TextBox4.Text & TextBox5.Text & TextBox6.Text & TextBox7.Text & TextBox8.Text <> Nothing Then
                commandtext = "UPDATE Users SET Users.[LastName]='" & TextBox2.Text & "', Users.[FirstName]='" & TextBox3.Text & "', Users.[Patronymic]='" & TextBox4.Text & "', Users.[Login]='" & TextBox5.Text & "', " &
                    "Users.[Password]='" & TextBox6.Text & "', Users.[Root]='" & TextBox7.Text & "', Users.[Job title]='" & TextBox8.Text & "' WHERE (((Users.[ID])=" & TextBox1.Text & "));"
                ChangeDataInTable(commandtext)
                TextBox2.ReadOnly = True
                TextBox3.ReadOnly = True
                TextBox4.ReadOnly = True
                TextBox5.ReadOnly = True
                TextBox6.ReadOnly = True
                TextBox7.ReadOnly = True
                TextBox8.ReadOnly = True
                Button1.Visible = False
                LoadListUsers()
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