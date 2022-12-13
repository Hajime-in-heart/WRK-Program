Imports System.Data.OleDb
Public Class frmImport

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With New OpenFileDialog
            .Title = "Выберите базу данных"
            .Filter = "Только файлы баз данных | *.mdb, *.db, *.accdb |Все файлы| *.*"
            .FileName = ""
            .Multiselect = False
            .ShowDialog()
        End With
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Access As String = Application.StartupPath & "\db.mdb"
        Dim Excel As String = Application.StartupPath & "\Лист Microsoft Excel.xlsx"
        Dim connect As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Excel & ";Extended Properties=Excel 8.0;"

        Using conn As New OleDbConnection(connect)
            Try
                Using cmd As New OleDbCommand()
                    cmd.Connection = conn
                    cmd.CommandText = "INSERT INTO [MS Access;Database=" & Access & "].[1Archivist] SELECT * FROM [Лист1]"
                    If conn.State = ConnectionState.Open Then
                        conn.Close()
                    End If
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End Using
    End Sub

    Private Sub frmImport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class