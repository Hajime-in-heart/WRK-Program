<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Area
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Area))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.УправлениеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.УдалитьВыбраннуюЗаписьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.РедактироватьЗаписьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ДобавитьЗаписьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ЭкспортWordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЭкспортExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader1})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(0, 24)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(523, 481)
        Me.ListView1.TabIndex = 8
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "ID"
        Me.ColumnHeader4.Width = 34
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Место"
        Me.ColumnHeader1.Width = 145
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.УправлениеToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1027, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'УправлениеToolStripMenuItem
        '
        Me.УправлениеToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.УдалитьВыбраннуюЗаписьToolStripMenuItem, Me.РедактироватьЗаписьToolStripMenuItem, Me.ДобавитьЗаписьToolStripMenuItem, Me.ЭкспортWordToolStripMenuItem, Me.ЭкспортExcelToolStripMenuItem})
        Me.УправлениеToolStripMenuItem.Name = "УправлениеToolStripMenuItem"
        Me.УправлениеToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.УправлениеToolStripMenuItem.Text = "Управление"
        '
        'УдалитьВыбраннуюЗаписьToolStripMenuItem
        '
        Me.УдалитьВыбраннуюЗаписьToolStripMenuItem.Image = CType(resources.GetObject("УдалитьВыбраннуюЗаписьToolStripMenuItem.Image"), System.Drawing.Image)
        Me.УдалитьВыбраннуюЗаписьToolStripMenuItem.Name = "УдалитьВыбраннуюЗаписьToolStripMenuItem"
        Me.УдалитьВыбраннуюЗаписьToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.УдалитьВыбраннуюЗаписьToolStripMenuItem.Text = "Удалить запись"
        '
        'РедактироватьЗаписьToolStripMenuItem
        '
        Me.РедактироватьЗаписьToolStripMenuItem.Image = CType(resources.GetObject("РедактироватьЗаписьToolStripMenuItem.Image"), System.Drawing.Image)
        Me.РедактироватьЗаписьToolStripMenuItem.Name = "РедактироватьЗаписьToolStripMenuItem"
        Me.РедактироватьЗаписьToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.РедактироватьЗаписьToolStripMenuItem.Text = "Редактировать запись"
        '
        'ДобавитьЗаписьToolStripMenuItem
        '
        Me.ДобавитьЗаписьToolStripMenuItem.Image = CType(resources.GetObject("ДобавитьЗаписьToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ДобавитьЗаписьToolStripMenuItem.Name = "ДобавитьЗаписьToolStripMenuItem"
        Me.ДобавитьЗаписьToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ДобавитьЗаписьToolStripMenuItem.Text = "Добавить запись..."
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.TextBox1)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.TextBox2)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(529, 27)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(486, 89)
        Me.GroupBox5.TabIndex = 44
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Основные данные"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBox1.Location = New System.Drawing.Point(277, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(196, 23)
        Me.TextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(258, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Местоположение"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBox2.Location = New System.Drawing.Point(277, 52)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(196, 23)
        Me.TextBox2.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListView2)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(529, 122)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(486, 277)
        Me.GroupBox3.TabIndex = 43
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Связанные вакансии"
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader2})
        Me.ListView2.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ListView2.GridLines = True
        Me.ListView2.Location = New System.Drawing.Point(6, 19)
        Me.ListView2.MultiSelect = False
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(467, 252)
        Me.ListView2.TabIndex = 26
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader
        '
        Me.ColumnHeader.Text = "ID"
        Me.ColumnHeader.Width = 40
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Тип"
        Me.ColumnHeader5.Width = 128
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Название вакансии"
        Me.ColumnHeader6.Width = 208
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "З/П"
        Me.ColumnHeader2.Width = 76
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(535, 399)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Готово"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'ЭкспортWordToolStripMenuItem
        '
        Me.ЭкспортWordToolStripMenuItem.Image = CType(resources.GetObject("ЭкспортWordToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ЭкспортWordToolStripMenuItem.Name = "ЭкспортWordToolStripMenuItem"
        Me.ЭкспортWordToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ЭкспортWordToolStripMenuItem.Text = "Экспорт Word"
        '
        'ЭкспортExcelToolStripMenuItem
        '
        Me.ЭкспортExcelToolStripMenuItem.Image = CType(resources.GetObject("ЭкспортExcelToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ЭкспортExcelToolStripMenuItem.Name = "ЭкспортExcelToolStripMenuItem"
        Me.ЭкспортExcelToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ЭкспортExcelToolStripMenuItem.Text = "Экспорт Excel"
        '
        'Area
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 515)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Area"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Адреса вакансий"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents УправлениеToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents УдалитьВыбраннуюЗаписьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents РедактироватьЗаписьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ДобавитьЗаписьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ColumnHeader As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Button1 As Button
    Friend WithEvents ЭкспортWordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ЭкспортExcelToolStripMenuItem As ToolStripMenuItem
End Class
