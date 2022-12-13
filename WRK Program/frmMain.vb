Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        With frmLogin
            .MdiParent = Me
            .Show()
        End With
        MenuStrip1.Visible = False
        StatusStrip1.Visible = False
        Timer2.Enabled = False
        Timer1.Enabled = False
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick 'Обновление таймера на панели инструментов
        ToolStripStatusLabel2.Text = Now.ToLongDateString
        ToolStripStatusLabel4.Text = Now.ToLongTimeString
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripProgressBar1.Value = 100
    End Sub

    Private Sub СтрокаСостоянияToolStripMenuItem_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles СтрокаСостоянияToolStripMenuItem.CheckedChanged
        Me.StatusStrip1.Visible = СтрокаСостоянияToolStripMenuItem.Checked
    End Sub


    Private Sub ОткрытьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОткрытьToolStripMenuItem.Click
        With New OpenFileDialog
            .Title = "Выберите базу данных"
            .Filter = "Файлы баз данных | *.mdb, *.db, *.accdb |Все файлы| *.*"
            .FileName = ""
            .Multiselect = False
            .ShowDialog()
            If .FileName <> Nothing Then
                databasefilename = .FileName
            End If
        End With
    End Sub


    Private Sub СохранитьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СохранитьToolStripMenuItem.Click
        With New SaveFileDialog
            .Title = "Сохранить"
            .Filter = "Файлы баз данных | *.mdb, *.db, *.accdb |Все файлы| *.*"
            .FileName = ""
            .ShowDialog()
            If .FileName <> Nothing Then
                My.Computer.FileSystem.CopyFile(databasefilename, .FileName, FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
            End If
        End With
    End Sub

    Private Sub ВыходToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВыходToolStripMenuItem.Click
        Dim _result = MsgBox("Выйти?", vbYesNo, "Выход")
        If _result = MsgBoxResult.Yes Then Application.Exit()
    End Sub

    Private Sub ОПрограммеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОПрограммеToolStripMenuItem.Click
        Process.Start(Application.StartupPath & "\ТЗ.docx")
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ИмпортToolStripMenuItem1.Click
        With frmImport
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub СписокБезработныхToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СписокБезработныхToolStripMenuItem.Click
        List_of_unemployed.Show()
    End Sub

    Private Sub АрхивToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles АрхивToolStripMenuItem.Click
        Archive.Show()
    End Sub
    Private Sub РаботодателиToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles РаботодателиToolStripMenuItem.Click
        Employer.Show()
    End Sub

    Private Sub АдресаToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles АдресаToolStripMenuItem.Click
        Area.Show()

    End Sub

    Private Sub ВакансииToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВакансииToolStripMenuItem.Click
        Vacancy.Show()
    End Sub

    Private Sub ТипОбразованияToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ТипОбразованияToolStripMenuItem.Click
        StudyLevel.Show()
    End Sub

    Private Sub МестоОбученияToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles МестоОбученияToolStripMenuItem.Click
        StudyPlace.Show()
    End Sub

    Private Sub ОбразованиеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОбразованиеToolStripMenuItem.Click
        Study.Show()
    End Sub

    Private Sub МестоВыдачиПаспортаToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles МестоВыдачиПаспортаToolStripMenuItem.Click
        PlaceOfIssue.Show()
    End Sub

    Private Sub СотрудникиToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СотрудникиToolStripMenuItem.Click
        Users.Show()
    End Sub

    Private Sub РестартToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles РестартToolStripMenuItem.Click
        Application.Restart()
    End Sub

    Private Sub ЛицензионноеСоглашениеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЛицензионноеСоглашениеToolStripMenuItem.Click
        Licence.Show()
    End Sub

    Private Sub СправкаToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles СправкаToolStripMenuItem1.Click
        Help.Show()
    End Sub
End Class