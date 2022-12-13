
Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Module modGeneral
    Public username As String
    Public password As String
    Public root As String
    Public Index As Integer
    Public DataReader As OleDbDataReader
    Public databasefilename As String = Application.StartupPath & "\db.mdb"
    Public connector As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & databasefilename)

    Public Sub EnableElements(ByVal _FrmMainSettings As Boolean) 'Изменение параметров главной формы через переменную _FrmMainSettings
        With frmMain
            .ToolStripStatusLabel6.Text = username
            .ToolStripStatusLabel9.Text = root
            .MenuStrip1.Visible = _FrmMainSettings
            .StatusStrip1.Visible = _FrmMainSettings
            .Timer2.Enabled = _FrmMainSettings
            .Timer1.Enabled = _FrmMainSettings
            CheckRoot()
        End With
    End Sub

    Public Sub CheckRoot()
        Select Case root
            Case "Developer"
                frmMain.СотрудникиToolStripMenuItem.Visible = True
                frmMain.ОткрытьToolStripMenuItem.Visible = True
                frmMain.СохранитьToolStripMenuItem.Visible = True
                frmMain.ИмпортToolStripMenuItem1.Visible = True
            Case "User"
                frmMain.СотрудникиToolStripMenuItem.Visible = False
                frmMain.ОткрытьToolStripMenuItem.Visible = False
                frmMain.СохранитьToolStripMenuItem.Visible = False
                frmMain.ИмпортToolStripMenuItem1.Visible = False
        End Select
    End Sub

    Public Sub CheckedMissingNumber()
        Dim RandomIndex As New Random
        Index = RandomIndex.Next(1, 32767)
    End Sub


    Public Sub ChangeDataInTable(ByVal CommandText As String)
        Try
            Dim Command As New OleDbCommand(CommandText, connector)
            connector.Open()
            Command.ExecuteNonQuery()
            connector.Close()
        Catch ex As Exception
            connector.Close()
        MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub LoadDataFromTable(ByVal CommandText As String, e As Object, ByVal StreamCount As Integer)
        Try
            Dim command As New OleDbCommand(CommandText, connector)
            connector.Open()
            datareader = command.ExecuteReader
            While datareader.Read() = True
                Select Case StreamCount
                    Case 1
                        Try
                            e.Items.Add(DataReader.GetValue(0))
                        Catch ex As Exception

                        End Try
                    Case 2
                        Try
                            e.Items.Add(DataReader.GetValue(0))
                            e.Items.Item(e.Items.Count - 1).SubItems.Add(DataReader.GetValue(1))
                        Catch ex As Exception

                        End Try
                    Case 3
                        Try
                            e.Items.Add(DataReader.GetValue(0))
                            e.Items.Item(e.Items.Count - 1).SubItems.Add(DataReader.GetValue(1))
                            e.Items.Item(e.Items.Count - 1).SubItems.Add(DataReader.GetValue(2))
                        Catch ex As Exception

                        End Try
                    Case 4
                        Try
                            e.Items.Add(DataReader.GetValue(0))
                            Try
                                e.Items.Item(e.Items.Count - 1).SubItems.Add(DataReader.GetValue(1))
                            Catch ex As Exception

                            End Try
                            e.Items.Item(e.Items.Count - 1).SubItems.Add(DataReader.GetValue(2))
                            e.Items.Item(e.Items.Count - 1).SubItems.Add(DataReader.GetValue(3))
                        Catch ex As Exception

                        End Try
                    Case 5
                        Try
                            e.Items.Add(DataReader.GetValue(0))
                            e.Items.Item(e.Items.Count - 1).SubItems.Add(DataReader.GetValue(1))
                            e.Items.Item(e.Items.Count - 1).SubItems.Add(DataReader.GetValue(2))
                            e.Items.Item(e.Items.Count - 1).SubItems.Add(DataReader.GetValue(3))
                            e.Items.Item(e.Items.Count - 1).SubItems.Add(DataReader.GetValue(4))
                        Catch ex As Exception

                        End Try
                    Case 6
                        Try
                            e.Items.Add(DataReader.GetValue(0))
                            e.Items.Item(e.Items.Count - 1).SubItems.Add(DataReader.GetValue(1))
                            e.Items.Item(e.Items.Count - 1).SubItems.Add(DataReader.GetValue(2))
                            e.Items.Item(e.Items.Count - 1).SubItems.Add(DataReader.GetValue(3))
                            e.Items.Item(e.Items.Count - 1).SubItems.Add(DataReader.GetValue(4))
                            e.Items.Item(e.Items.Count - 1).SubItems.Add(DataReader.GetValue(5))
                        Catch ex As Exception

                        End Try
                    Case 7
                        Try
                            e.Items.Add(DataReader.GetValue(0))
                            e.Items.Item(e.Items.Count - 1).SubItems.Add(DataReader.GetValue(1))
                            e.Items.Item(e.Items.Count - 1).SubItems.Add(DataReader.GetValue(2))
                            e.Items.Item(e.Items.Count - 1).SubItems.Add(DataReader.GetValue(3))
                            e.Items.Item(e.Items.Count - 1).SubItems.Add(DataReader.GetValue(4))
                            e.Items.Item(e.Items.Count - 1).SubItems.Add(DataReader.GetValue(5))
                            e.Items.Item(e.Items.Count - 1).SubItems.Add(DataReader.GetValue(6))
                        Catch ex As Exception

                        End Try
                End Select
            End While
            datareader.Close()
            connector.Close()
        Catch ex As Exception
            connector.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ExportWord(ByVal e As Object, ByVal Header As String)
        Try
            Dim Дата As String = Format(Now, "d MMMM YYYY" & " " & Header)
            Dim W = New Word.Application
            W.Visible = True
            W.Documents.Add()
            W.Selection.TypeText("Выписка из БД: " & Дата & Chr(13) & Chr(10))
            For i As Short = 0 To e.Items.Count - 1
                Select Case e.Columns.Count
                    Case 1
                        W.Selection.TypeText(e.Items(i).SubItems.Item(0).Text & Chr(13) & Chr(10))
                    Case 2
                        W.Selection.TypeText(e.Items(i).SubItems.Item(0).Text & " " &
                                             e.Items(i).SubItems.Item(1).Text & Chr(13) & Chr(10))
                    Case 3
                        W.Selection.TypeText(e.Items(i).SubItems.Item(0).Text & " " &
                                             e.Items(i).SubItems.Item(1).Text & " " &
                                             e.Items(i).SubItems.Item(2).Text & Chr(13) & Chr(10))
                    Case 4
                        W.Selection.TypeText(e.Items(i).SubItems.Item(0).Text & " " &
                                             e.Items(i).SubItems.Item(1).Text & " " &
                                             e.Items(i).SubItems.Item(2).Text & " " &
                                             e.Items(i).SubItems.Item(3).Text & Chr(13) & Chr(10))
                    Case 5
                        W.Selection.TypeText(e.Items(i).SubItems.Item(0).Text & " " &
                                             e.Items(i).SubItems.Item(1).Text & " " &
                                             e.Items(i).SubItems.Item(2).Text & " " &
                                             e.Items(i).SubItems.Item(3).Text & " " &
                                             e.Items(i).SubItems.Item(4).Text & " " & Chr(13) & Chr(10))
                End Select
            Next i
            W = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub ExportExcel(ByVal e As Object)
        Try
            Dim myXL As Excel.Application, myWB As Excel.Workbook, myWS As Excel.Worksheet
            Dim i As Integer
            Dim Y As Integer
            Dim z As Integer
            myXL = New Excel.Application
            myWB = myXL.Workbooks.Add
            myWS = myWB.Worksheets(1)
            z = 2
            myXL.Visible = True
            Select Case e.columns.count
                Case 2
                    For i = 1 To e.Items.Count
                        For Y = 1 To 2
                            myWS.Cells(1, Y) = e.Columns(Y - 1).Text
                        Next Y
                        myWS.Cells(z, 1) = e.Items.Item(i - 1).SubItems.Item(0).Text
                        myWS.Cells(z, 2) = e.Items.Item(i - 1).SubItems.Item(1).Text
                        z = z + 1
                    Next i
                    myWS.Columns(1).ColumnWidth = 20
                    myWS.Columns(2).ColumnWidth = 50
                Case 3
                    For i = 1 To e.Items.Count
                        For Y = 1 To 3
                            myWS.Cells(1, Y) = e.Columns(Y - 1).Text
                        Next Y
                        myWS.Cells(z, 1) = e.Items.Item(i - 1).SubItems.Item(0).Text
                        myWS.Cells(z, 2) = e.Items.Item(i - 1).SubItems.Item(1).Text
                        myWS.Cells(z, 3) = e.Items.Item(i - 1).SubItems.Item(2).Text
                        z = z + 1
                    Next i
                    myWS.Columns(1).ColumnWidth = 20
                    myWS.Columns(2).ColumnWidth = 50
                    myWS.Columns(3).ColumnWidth = 50
                Case 4
                    For i = 1 To e.Items.Count
                        For Y = 1 To 4
                            myWS.Cells(1, Y) = e.Columns(Y - 1).Text
                        Next Y
                        myWS.Cells(z, 1) = e.Items.Item(i - 1).SubItems.Item(0).Text
                        myWS.Cells(z, 2) = e.Items.Item(i - 1).SubItems.Item(1).Text
                        myWS.Cells(z, 3) = e.Items.Item(i - 1).SubItems.Item(2).Text
                        myWS.Cells(z, 4) = e.Items.Item(i - 1).SubItems.Item(3).Text
                        z = z + 1
                    Next i
                    myWS.Columns(1).ColumnWidth = 20
                    myWS.Columns(2).ColumnWidth = 50
                    myWS.Columns(3).ColumnWidth = 50
                    myWS.Columns(4).ColumnWidth = 50
                Case 5
                    For i = 1 To e.Items.Count
                        For Y = 1 To 5
                            myWS.Cells(1, Y) = e.Columns(Y - 1).Text
                        Next Y
                        myWS.Cells(z, 1) = e.Items.Item(i - 1).SubItems.Item(0).Text
                        myWS.Cells(z, 2) = e.Items.Item(i - 1).SubItems.Item(1).Text
                        myWS.Cells(z, 3) = e.Items.Item(i - 1).SubItems.Item(2).Text
                        myWS.Cells(z, 4) = e.Items.Item(i - 1).SubItems.Item(3).Text
                        myWS.Cells(z, 5) = e.Items.Item(i - 1).SubItems.Item(4).Text
                        z = z + 1
                    Next i
                    myWS.Columns(1).ColumnWidth = 20
                    myWS.Columns(2).ColumnWidth = 50
                    myWS.Columns(3).ColumnWidth = 50
                    myWS.Columns(4).ColumnWidth = 50
                    myWS.Columns(5).ColumnWidth = 50
            End Select
            myXL = Nothing
            myWB = Nothing
            myWS = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module

