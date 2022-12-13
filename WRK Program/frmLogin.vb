Imports System.Data.OleDb
Public Class frmLogin

    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox1.MouseDown
        PictureBox1.Image = ImageList1.Images(0)
        TextBox2.PasswordChar = Nothing
    End Sub

    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox1.MouseUp
        PictureBox1.Image = ImageList1.Images(1)
        TextBox2.PasswordChar = "*"
    End Sub

    Private Sub Авторизация(sender As Object, e As EventArgs) Handles Button1.Click 'Процедура авторизации

        If TextBox1.Text & TextBox2.Text <> Nothing Then
            Try
                Dim command As New OleDbCommand("SELECT Users.[Login], Users.[Password], Users.[Root] FROM Users WHERE (((Users.[Login])='" & TextBox1.Text & "') AND ((Users.[Password])='" & TextBox2.Text & "'));", connector)
                connector.Open()
                DataReader = command.ExecuteReader
                While DataReader.Read() = True
                    username = DataReader.GetValue(0)
                    password = DataReader.GetValue(1)
                    root = DataReader.GetValue(2)
                End While
                DataReader.Close()
                connector.Close()
            Catch ex As Exception
                connector.Close()
            MsgBox(ex.Message)
            End Try

            If username = TextBox1.Text And password = TextBox2.Text Then
                EnableElements(True)
                Me.Close()
            Else
                MessageBox.Show("Введен неверный пароль")
            End If
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Авторизация(Me, New EventArgs)
        End If
    End Sub
End Class