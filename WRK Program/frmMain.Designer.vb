<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ФайлToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОткрытьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СохранитьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ИмпортToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.РестартToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВыходToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВидToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СтрокаСостоянияToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СправочникToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СписокБезработныхToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.МестоВыдачиПаспортаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.АрхивToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОбразованиеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ТипОбразованияToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.МестоОбученияToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВакансииToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.АдресаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.РаботодателиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СотрудникиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СправкаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОПрограммеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЛицензионноеСоглашениеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СправкаToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel8 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel9 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ФайлToolStripMenuItem, Me.ВидToolStripMenuItem, Me.СправочникToolStripMenuItem, Me.СправкаToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1063, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ФайлToolStripMenuItem
        '
        Me.ФайлToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ОткрытьToolStripMenuItem, Me.СохранитьToolStripMenuItem, Me.ИмпортToolStripMenuItem1, Me.ToolStripMenuItem2, Me.РестартToolStripMenuItem, Me.ВыходToolStripMenuItem})
        Me.ФайлToolStripMenuItem.Name = "ФайлToolStripMenuItem"
        Me.ФайлToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.ФайлToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ФайлToolStripMenuItem.Text = "Файл"
        '
        'ОткрытьToolStripMenuItem
        '
        Me.ОткрытьToolStripMenuItem.Image = CType(resources.GetObject("ОткрытьToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ОткрытьToolStripMenuItem.Name = "ОткрытьToolStripMenuItem"
        Me.ОткрытьToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.ОткрытьToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ОткрытьToolStripMenuItem.Text = "Открыть..."
        '
        'СохранитьToolStripMenuItem
        '
        Me.СохранитьToolStripMenuItem.Image = CType(resources.GetObject("СохранитьToolStripMenuItem.Image"), System.Drawing.Image)
        Me.СохранитьToolStripMenuItem.Name = "СохранитьToolStripMenuItem"
        Me.СохранитьToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.СохранитьToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.СохранитьToolStripMenuItem.Text = "Сохранить..."
        '
        'ИмпортToolStripMenuItem1
        '
        Me.ИмпортToolStripMenuItem1.Image = CType(resources.GetObject("ИмпортToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ИмпортToolStripMenuItem1.Name = "ИмпортToolStripMenuItem1"
        Me.ИмпортToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.ИмпортToolStripMenuItem1.Size = New System.Drawing.Size(182, 22)
        Me.ИмпортToolStripMenuItem1.Text = "Импорт..."
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(179, 6)
        '
        'РестартToolStripMenuItem
        '
        Me.РестартToolStripMenuItem.Image = CType(resources.GetObject("РестартToolStripMenuItem.Image"), System.Drawing.Image)
        Me.РестартToolStripMenuItem.Name = "РестартToolStripMenuItem"
        Me.РестартToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F5), System.Windows.Forms.Keys)
        Me.РестартToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.РестартToolStripMenuItem.Text = "Рестарт"
        '
        'ВыходToolStripMenuItem
        '
        Me.ВыходToolStripMenuItem.Image = CType(resources.GetObject("ВыходToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ВыходToolStripMenuItem.Name = "ВыходToolStripMenuItem"
        Me.ВыходToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ВыходToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ВыходToolStripMenuItem.Text = "Выход"
        '
        'ВидToolStripMenuItem
        '
        Me.ВидToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СтрокаСостоянияToolStripMenuItem})
        Me.ВидToolStripMenuItem.Name = "ВидToolStripMenuItem"
        Me.ВидToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.ВидToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.ВидToolStripMenuItem.Text = "Вид"
        '
        'СтрокаСостоянияToolStripMenuItem
        '
        Me.СтрокаСостоянияToolStripMenuItem.Checked = True
        Me.СтрокаСостоянияToolStripMenuItem.CheckOnClick = True
        Me.СтрокаСостоянияToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.СтрокаСостоянияToolStripMenuItem.Name = "СтрокаСостоянияToolStripMenuItem"
        Me.СтрокаСостоянияToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.СтрокаСостоянияToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.СтрокаСостоянияToolStripMenuItem.Text = "Строка состояния"
        '
        'СправочникToolStripMenuItem
        '
        Me.СправочникToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СписокБезработныхToolStripMenuItem, Me.ОбразованиеToolStripMenuItem, Me.ВакансииToolStripMenuItem, Me.АрхивToolStripMenuItem, Me.СотрудникиToolStripMenuItem})
        Me.СправочникToolStripMenuItem.Name = "СправочникToolStripMenuItem"
        Me.СправочникToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.СправочникToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.СправочникToolStripMenuItem.Text = "Справочник"
        '
        'СписокБезработныхToolStripMenuItem
        '
        Me.СписокБезработныхToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.МестоВыдачиПаспортаToolStripMenuItem})
        Me.СписокБезработныхToolStripMenuItem.Image = CType(resources.GetObject("СписокБезработныхToolStripMenuItem.Image"), System.Drawing.Image)
        Me.СписокБезработныхToolStripMenuItem.Name = "СписокБезработныхToolStripMenuItem"
        Me.СписокБезработныхToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.СписокБезработныхToolStripMenuItem.Text = "Список безработных..."
        '
        'МестоВыдачиПаспортаToolStripMenuItem
        '
        Me.МестоВыдачиПаспортаToolStripMenuItem.Image = CType(resources.GetObject("МестоВыдачиПаспортаToolStripMenuItem.Image"), System.Drawing.Image)
        Me.МестоВыдачиПаспортаToolStripMenuItem.Name = "МестоВыдачиПаспортаToolStripMenuItem"
        Me.МестоВыдачиПаспортаToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.МестоВыдачиПаспортаToolStripMenuItem.Text = "Место выдачи паспорта..."
        '
        'АрхивToolStripMenuItem
        '
        Me.АрхивToolStripMenuItem.Image = CType(resources.GetObject("АрхивToolStripMenuItem.Image"), System.Drawing.Image)
        Me.АрхивToolStripMenuItem.Name = "АрхивToolStripMenuItem"
        Me.АрхивToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.АрхивToolStripMenuItem.Text = "Архив..."
        '
        'ОбразованиеToolStripMenuItem
        '
        Me.ОбразованиеToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ТипОбразованияToolStripMenuItem, Me.МестоОбученияToolStripMenuItem})
        Me.ОбразованиеToolStripMenuItem.Image = CType(resources.GetObject("ОбразованиеToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ОбразованиеToolStripMenuItem.Name = "ОбразованиеToolStripMenuItem"
        Me.ОбразованиеToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ОбразованиеToolStripMenuItem.Text = "Образование..."
        '
        'ТипОбразованияToolStripMenuItem
        '
        Me.ТипОбразованияToolStripMenuItem.Image = CType(resources.GetObject("ТипОбразованияToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ТипОбразованияToolStripMenuItem.Name = "ТипОбразованияToolStripMenuItem"
        Me.ТипОбразованияToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ТипОбразованияToolStripMenuItem.Text = "Тип образования..."
        '
        'МестоОбученияToolStripMenuItem
        '
        Me.МестоОбученияToolStripMenuItem.Image = CType(resources.GetObject("МестоОбученияToolStripMenuItem.Image"), System.Drawing.Image)
        Me.МестоОбученияToolStripMenuItem.Name = "МестоОбученияToolStripMenuItem"
        Me.МестоОбученияToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.МестоОбученияToolStripMenuItem.Text = "Место обучения..."
        '
        'ВакансииToolStripMenuItem
        '
        Me.ВакансииToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.АдресаToolStripMenuItem, Me.РаботодателиToolStripMenuItem})
        Me.ВакансииToolStripMenuItem.Image = CType(resources.GetObject("ВакансииToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ВакансииToolStripMenuItem.Name = "ВакансииToolStripMenuItem"
        Me.ВакансииToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ВакансииToolStripMenuItem.Text = "Вакансии..."
        '
        'АдресаToolStripMenuItem
        '
        Me.АдресаToolStripMenuItem.Image = CType(resources.GetObject("АдресаToolStripMenuItem.Image"), System.Drawing.Image)
        Me.АдресаToolStripMenuItem.Name = "АдресаToolStripMenuItem"
        Me.АдресаToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.АдресаToolStripMenuItem.Text = "Адреса..."
        '
        'РаботодателиToolStripMenuItem
        '
        Me.РаботодателиToolStripMenuItem.Image = CType(resources.GetObject("РаботодателиToolStripMenuItem.Image"), System.Drawing.Image)
        Me.РаботодателиToolStripMenuItem.Name = "РаботодателиToolStripMenuItem"
        Me.РаботодателиToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.РаботодателиToolStripMenuItem.Text = "Работодатели..."
        '
        'СотрудникиToolStripMenuItem
        '
        Me.СотрудникиToolStripMenuItem.Image = CType(resources.GetObject("СотрудникиToolStripMenuItem.Image"), System.Drawing.Image)
        Me.СотрудникиToolStripMenuItem.Name = "СотрудникиToolStripMenuItem"
        Me.СотрудникиToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.СотрудникиToolStripMenuItem.Text = "Сотрудники..."
        '
        'СправкаToolStripMenuItem
        '
        Me.СправкаToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СправкаToolStripMenuItem1, Me.ОПрограммеToolStripMenuItem, Me.ЛицензионноеСоглашениеToolStripMenuItem})
        Me.СправкаToolStripMenuItem.Name = "СправкаToolStripMenuItem"
        Me.СправкаToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F12), System.Windows.Forms.Keys)
        Me.СправкаToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.СправкаToolStripMenuItem.Text = "Справка"
        '
        'ОПрограммеToolStripMenuItem
        '
        Me.ОПрограммеToolStripMenuItem.Image = CType(resources.GetObject("ОПрограммеToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ОПрограммеToolStripMenuItem.Name = "ОПрограммеToolStripMenuItem"
        Me.ОПрограммеToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.ОПрограммеToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
        Me.ОПрограммеToolStripMenuItem.Text = "О программе..."
        '
        'ЛицензионноеСоглашениеToolStripMenuItem
        '
        Me.ЛицензионноеСоглашениеToolStripMenuItem.Image = CType(resources.GetObject("ЛицензионноеСоглашениеToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ЛицензионноеСоглашениеToolStripMenuItem.Name = "ЛицензионноеСоглашениеToolStripMenuItem"
        Me.ЛицензионноеСоглашениеToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.ЛицензионноеСоглашениеToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
        Me.ЛицензионноеСоглашениеToolStripMenuItem.Text = "Лицензионное соглашение..."
        '
        'СправкаToolStripMenuItem1
        '
        Me.СправкаToolStripMenuItem1.Image = CType(resources.GetObject("СправкаToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.СправкаToolStripMenuItem1.Name = "СправкаToolStripMenuItem1"
        Me.СправкаToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.СправкаToolStripMenuItem1.Size = New System.Drawing.Size(254, 22)
        Me.СправкаToolStripMenuItem1.Text = "Справка..."
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel7, Me.ToolStripProgressBar1, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel6, Me.ToolStripStatusLabel8, Me.ToolStripStatusLabel9})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 549)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1063, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(69, 17)
        Me.ToolStripStatusLabel7.Text = "Состояние:"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(38, 17)
        Me.ToolStripStatusLabel1.Text = "Дата: "
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(48, 17)
        Me.ToolStripStatusLabel3.Text = "Время: "
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripStatusLabel4.Text = "ToolStripStatusLabel4"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(90, 17)
        Me.ToolStripStatusLabel5.Text = "Пользователь: "
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripStatusLabel6.Text = "ToolStripStatusLabel6"
        '
        'ToolStripStatusLabel8
        '
        Me.ToolStripStatusLabel8.Name = "ToolStripStatusLabel8"
        Me.ToolStripStatusLabel8.Size = New System.Drawing.Size(44, 17)
        Me.ToolStripStatusLabel8.Text = "Права:"
        '
        'ToolStripStatusLabel9
        '
        Me.ToolStripStatusLabel9.Name = "ToolStripStatusLabel9"
        Me.ToolStripStatusLabel9.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripStatusLabel9.Text = "ToolStripStatusLabel9"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1063, 571)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WRK Program"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ФайлToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ОткрытьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СохранитьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ВыходToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ВидToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СтрокаСостоянияToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СправочникToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СправкаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ОПрограммеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ИмпортToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents АрхивToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СписокБезработныхToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel8 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel9 As ToolStripStatusLabel
    Friend WithEvents ОбразованиеToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ВакансииToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents АдресаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents РаботодателиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ТипОбразованияToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents МестоОбученияToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents МестоВыдачиПаспортаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СотрудникиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents РестартToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ЛицензионноеСоглашениеToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СправкаToolStripMenuItem1 As ToolStripMenuItem
End Class
