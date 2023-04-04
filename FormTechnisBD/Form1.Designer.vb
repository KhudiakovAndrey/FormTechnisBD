<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TechnisForm
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
        Me.Tool = New System.Windows.Forms.ToolTip(Me.components)
        Me.AddTechnisButton = New System.Windows.Forms.Button()
        Me.DelTechnisButton = New System.Windows.Forms.Button()
        Me.TechnisListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TechnisGroupBox = New System.Windows.Forms.GroupBox()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ChangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NumberFilterTextBox = New System.Windows.Forms.TextBox()
        Me.StatFilterComboBox = New System.Windows.Forms.ComboBox()
        Me.AuditoriumFilterComboBox = New System.Windows.Forms.ComboBox()
        Me.TypeFilterComboBox = New System.Windows.Forms.ComboBox()
        Me.ClearFilterButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ФайлToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ИзменитьПодключениеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОбщаяСтруктураToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TechnisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuditoriumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WorkersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗаявкиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОтчётыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ТехникаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ДобавитьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.АудиторииToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ДобавитьToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ТипТехникиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ДобавитьToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗаявкаСотрудникаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ДобавитьToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗаявкаМастераToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ДобавитьToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОтветственныеЗаАудиторииToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ДобавитьToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ДолжностиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ДобавитьToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПоставщикиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ДобавитьToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.СправочникиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПоискПоСложнымЗапросамToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СправкаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuPanel = New System.Windows.Forms.Panel()
        Me.RequestButton = New System.Windows.Forms.Button()
        Me.SettingsButton = New System.Windows.Forms.Button()
        Me.WorkerButton = New System.Windows.Forms.Button()
        Me.accountingButton = New System.Windows.Forms.Button()
        Me.GerbPictureBox = New System.Windows.Forms.PictureBox()
        Me.TechnisBDDataSet = New FormTechnisBD.TechnisBDDataSet()
        Me.AuditoriumTableAdapter = New FormTechnisBD.TechnisBDDataSetTableAdapters.AuditoriumTableAdapter()
        Me.TableAdapterManager = New FormTechnisBD.TechnisBDDataSetTableAdapters.TableAdapterManager()
        Me.StatTechnisTableAdapter = New FormTechnisBD.TechnisBDDataSetTableAdapters.StatTechnisTableAdapter()
        Me.TechnisTableAdapter = New FormTechnisBD.TechnisBDDataSetTableAdapters.TechnisTableAdapter()
        Me.TypeTechnisTableAdapter = New FormTechnisBD.TechnisBDDataSetTableAdapters.TypeTechnisTableAdapter()
        Me.t = New System.Windows.Forms.ToolTip(Me.components)
        Me.TechnisGroupBox.SuspendLayout()
        Me.ContextMenu1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuPanel.SuspendLayout()
        CType(Me.GerbPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TechnisBDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AddTechnisButton
        '
        Me.AddTechnisButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddTechnisButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.AddTechnisButton.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.AddTechnisButton.Location = New System.Drawing.Point(6, 270)
        Me.AddTechnisButton.Name = "AddTechnisButton"
        Me.AddTechnisButton.Size = New System.Drawing.Size(163, 23)
        Me.AddTechnisButton.TabIndex = 1
        Me.AddTechnisButton.Text = "Добавить технику"
        Me.Tool.SetToolTip(Me.AddTechnisButton, "Вызывает диалоговое окно для добавления новой техники")
        Me.AddTechnisButton.UseVisualStyleBackColor = True
        '
        'DelTechnisButton
        '
        Me.DelTechnisButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DelTechnisButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DelTechnisButton.ForeColor = System.Drawing.Color.Red
        Me.DelTechnisButton.Location = New System.Drawing.Point(175, 270)
        Me.DelTechnisButton.Name = "DelTechnisButton"
        Me.DelTechnisButton.Size = New System.Drawing.Size(223, 23)
        Me.DelTechnisButton.TabIndex = 2
        Me.DelTechnisButton.Text = "Удалить помеченную технику"
        Me.Tool.SetToolTip(Me.DelTechnisButton, "Удаляет техники у которой стоит флажок")
        Me.DelTechnisButton.UseVisualStyleBackColor = True
        '
        'TechnisListView
        '
        Me.TechnisListView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TechnisListView.CheckBoxes = True
        Me.TechnisListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.TechnisListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TechnisListView.FullRowSelect = True
        Me.TechnisListView.GridLines = True
        Me.TechnisListView.HideSelection = False
        Me.TechnisListView.Location = New System.Drawing.Point(6, 19)
        Me.TechnisListView.Name = "TechnisListView"
        Me.TechnisListView.Size = New System.Drawing.Size(874, 245)
        Me.TechnisListView.TabIndex = 0
        Me.TechnisListView.UseCompatibleStateImageBehavior = False
        Me.TechnisListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 39
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Номер"
        Me.ColumnHeader2.Width = 70
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Аудитория"
        Me.ColumnHeader3.Width = 84
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Статус"
        Me.ColumnHeader4.Width = 120
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Тип"
        Me.ColumnHeader5.Width = 270
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Модель"
        Me.ColumnHeader6.Width = 280
        '
        'TechnisGroupBox
        '
        Me.TechnisGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TechnisGroupBox.BackColor = System.Drawing.Color.White
        Me.TechnisGroupBox.Controls.Add(Me.TechnisListView)
        Me.TechnisGroupBox.Controls.Add(Me.DelTechnisButton)
        Me.TechnisGroupBox.Controls.Add(Me.AddTechnisButton)
        Me.TechnisGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TechnisGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TechnisGroupBox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TechnisGroupBox.Location = New System.Drawing.Point(206, 218)
        Me.TechnisGroupBox.Name = "TechnisGroupBox"
        Me.TechnisGroupBox.Size = New System.Drawing.Size(890, 302)
        Me.TechnisGroupBox.TabIndex = 3
        Me.TechnisGroupBox.TabStop = False
        Me.TechnisGroupBox.Text = "Просмотр техники"
        '
        'ContextMenu1
        '
        Me.ContextMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeToolStripMenuItem})
        Me.ContextMenu1.Name = "ChangeToolStripMenuItem"
        Me.ContextMenu1.Size = New System.Drawing.Size(129, 26)
        '
        'ChangeToolStripMenuItem
        '
        Me.ChangeToolStripMenuItem.Name = "ChangeToolStripMenuItem"
        Me.ChangeToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.ChangeToolStripMenuItem.Text = "Изменить"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.NumberFilterTextBox)
        Me.GroupBox1.Controls.Add(Me.StatFilterComboBox)
        Me.GroupBox1.Controls.Add(Me.AuditoriumFilterComboBox)
        Me.GroupBox1.Controls.Add(Me.TypeFilterComboBox)
        Me.GroupBox1.Controls.Add(Me.ClearFilterButton)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(206, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(736, 100)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Поиск и фильтрация"
        '
        'NumberFilterTextBox
        '
        Me.NumberFilterTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.NumberFilterTextBox.Location = New System.Drawing.Point(64, 20)
        Me.NumberFilterTextBox.Name = "NumberFilterTextBox"
        Me.NumberFilterTextBox.Size = New System.Drawing.Size(140, 22)
        Me.NumberFilterTextBox.TabIndex = 6
        '
        'StatFilterComboBox
        '
        Me.StatFilterComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.StatFilterComboBox.FormattingEnabled = True
        Me.StatFilterComboBox.Location = New System.Drawing.Point(64, 49)
        Me.StatFilterComboBox.Name = "StatFilterComboBox"
        Me.StatFilterComboBox.Size = New System.Drawing.Size(140, 24)
        Me.StatFilterComboBox.TabIndex = 2
        '
        'AuditoriumFilterComboBox
        '
        Me.AuditoriumFilterComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.AuditoriumFilterComboBox.FormattingEnabled = True
        Me.AuditoriumFilterComboBox.Location = New System.Drawing.Point(289, 19)
        Me.AuditoriumFilterComboBox.Name = "AuditoriumFilterComboBox"
        Me.AuditoriumFilterComboBox.Size = New System.Drawing.Size(127, 24)
        Me.AuditoriumFilterComboBox.TabIndex = 4
        '
        'TypeFilterComboBox
        '
        Me.TypeFilterComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TypeFilterComboBox.FormattingEnabled = True
        Me.TypeFilterComboBox.Location = New System.Drawing.Point(457, 19)
        Me.TypeFilterComboBox.Name = "TypeFilterComboBox"
        Me.TypeFilterComboBox.Size = New System.Drawing.Size(269, 24)
        Me.TypeFilterComboBox.TabIndex = 0
        '
        'ClearFilterButton
        '
        Me.ClearFilterButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClearFilterButton.Location = New System.Drawing.Point(586, 49)
        Me.ClearFilterButton.Name = "ClearFilterButton"
        Me.ClearFilterButton.Size = New System.Drawing.Size(140, 23)
        Me.ClearFilterButton.TabIndex = 8
        Me.ClearFilterButton.Text = "Очистить фильтр"
        Me.t.SetToolTip(Me.ClearFilterButton, "Очищает все поля фильтров")
        Me.ClearFilterButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Номер:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(210, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Аудитория:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Статус:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(422, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Тип:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ФайлToolStripMenuItem, Me.ОбщаяСтруктураToolStripMenuItem, Me.ОтчётыToolStripMenuItem, Me.СправочникиToolStripMenuItem, Me.СправкаToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(200, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(908, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ФайлToolStripMenuItem
        '
        Me.ФайлToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ИзменитьПодключениеToolStripMenuItem, Me.ToolStripSeparator1, Me.CloseToolStripMenuItem})
        Me.ФайлToolStripMenuItem.Name = "ФайлToolStripMenuItem"
        Me.ФайлToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ФайлToolStripMenuItem.Text = "Файл"
        '
        'ИзменитьПодключениеToolStripMenuItem
        '
        Me.ИзменитьПодключениеToolStripMenuItem.Name = "ИзменитьПодключениеToolStripMenuItem"
        Me.ИзменитьПодключениеToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.ИзменитьПодключениеToolStripMenuItem.Text = "Изменить подключение"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(204, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.CloseToolStripMenuItem.Text = "Завершение работы"
        '
        'ОбщаяСтруктураToolStripMenuItem
        '
        Me.ОбщаяСтруктураToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TechnisToolStripMenuItem, Me.AuditoriumToolStripMenuItem, Me.WorkersToolStripMenuItem, Me.ЗаявкиToolStripMenuItem})
        Me.ОбщаяСтруктураToolStripMenuItem.Name = "ОбщаяСтруктураToolStripMenuItem"
        Me.ОбщаяСтруктураToolStripMenuItem.Size = New System.Drawing.Size(115, 20)
        Me.ОбщаяСтруктураToolStripMenuItem.Text = "Общая структура"
        '
        'TechnisToolStripMenuItem
        '
        Me.TechnisToolStripMenuItem.Name = "TechnisToolStripMenuItem"
        Me.TechnisToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.TechnisToolStripMenuItem.Text = "Техника"
        '
        'AuditoriumToolStripMenuItem
        '
        Me.AuditoriumToolStripMenuItem.Name = "AuditoriumToolStripMenuItem"
        Me.AuditoriumToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.AuditoriumToolStripMenuItem.Text = "Аудитории"
        '
        'WorkersToolStripMenuItem
        '
        Me.WorkersToolStripMenuItem.Name = "WorkersToolStripMenuItem"
        Me.WorkersToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.WorkersToolStripMenuItem.Text = "Сотрудники"
        '
        'ЗаявкиToolStripMenuItem
        '
        Me.ЗаявкиToolStripMenuItem.Name = "ЗаявкиToolStripMenuItem"
        Me.ЗаявкиToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ЗаявкиToolStripMenuItem.Text = "Заявки"
        '
        'ОтчётыToolStripMenuItem
        '
        Me.ОтчётыToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ТехникаToolStripMenuItem, Me.АудиторииToolStripMenuItem, Me.ТипТехникиToolStripMenuItem, Me.ЗаявкаСотрудникаToolStripMenuItem, Me.ЗаявкаМастераToolStripMenuItem, Me.ОтветственныеЗаАудиторииToolStripMenuItem, Me.ДолжностиToolStripMenuItem, Me.ПоставщикиToolStripMenuItem})
        Me.ОтчётыToolStripMenuItem.Name = "ОтчётыToolStripMenuItem"
        Me.ОтчётыToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.ОтчётыToolStripMenuItem.Text = "Справочники"
        '
        'ТехникаToolStripMenuItem
        '
        Me.ТехникаToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ДобавитьToolStripMenuItem})
        Me.ТехникаToolStripMenuItem.Name = "ТехникаToolStripMenuItem"
        Me.ТехникаToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.ТехникаToolStripMenuItem.Text = "Техника"
        '
        'ДобавитьToolStripMenuItem
        '
        Me.ДобавитьToolStripMenuItem.Name = "ДобавитьToolStripMenuItem"
        Me.ДобавитьToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ДобавитьToolStripMenuItem.Text = "Добавить"
        '
        'АудиторииToolStripMenuItem
        '
        Me.АудиторииToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ДобавитьToolStripMenuItem1})
        Me.АудиторииToolStripMenuItem.Name = "АудиторииToolStripMenuItem"
        Me.АудиторииToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.АудиторииToolStripMenuItem.Text = "Аудитории"
        '
        'ДобавитьToolStripMenuItem1
        '
        Me.ДобавитьToolStripMenuItem1.Name = "ДобавитьToolStripMenuItem1"
        Me.ДобавитьToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
        Me.ДобавитьToolStripMenuItem1.Text = "Добавить"
        '
        'ТипТехникиToolStripMenuItem
        '
        Me.ТипТехникиToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ДобавитьToolStripMenuItem2})
        Me.ТипТехникиToolStripMenuItem.Name = "ТипТехникиToolStripMenuItem"
        Me.ТипТехникиToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.ТипТехникиToolStripMenuItem.Text = "Тип техники"
        '
        'ДобавитьToolStripMenuItem2
        '
        Me.ДобавитьToolStripMenuItem2.Name = "ДобавитьToolStripMenuItem2"
        Me.ДобавитьToolStripMenuItem2.Size = New System.Drawing.Size(126, 22)
        Me.ДобавитьToolStripMenuItem2.Text = "Добавить"
        '
        'ЗаявкаСотрудникаToolStripMenuItem
        '
        Me.ЗаявкаСотрудникаToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ДобавитьToolStripMenuItem3})
        Me.ЗаявкаСотрудникаToolStripMenuItem.Name = "ЗаявкаСотрудникаToolStripMenuItem"
        Me.ЗаявкаСотрудникаToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.ЗаявкаСотрудникаToolStripMenuItem.Text = "Заявка сотрудника"
        '
        'ДобавитьToolStripMenuItem3
        '
        Me.ДобавитьToolStripMenuItem3.Name = "ДобавитьToolStripMenuItem3"
        Me.ДобавитьToolStripMenuItem3.Size = New System.Drawing.Size(126, 22)
        Me.ДобавитьToolStripMenuItem3.Text = "Добавить"
        '
        'ЗаявкаМастераToolStripMenuItem
        '
        Me.ЗаявкаМастераToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ДобавитьToolStripMenuItem4})
        Me.ЗаявкаМастераToolStripMenuItem.Name = "ЗаявкаМастераToolStripMenuItem"
        Me.ЗаявкаМастераToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.ЗаявкаМастераToolStripMenuItem.Text = "Заявка мастера"
        '
        'ДобавитьToolStripMenuItem4
        '
        Me.ДобавитьToolStripMenuItem4.Name = "ДобавитьToolStripMenuItem4"
        Me.ДобавитьToolStripMenuItem4.Size = New System.Drawing.Size(126, 22)
        Me.ДобавитьToolStripMenuItem4.Text = "Добавить"
        '
        'ОтветственныеЗаАудиторииToolStripMenuItem
        '
        Me.ОтветственныеЗаАудиторииToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ДобавитьToolStripMenuItem5})
        Me.ОтветственныеЗаАудиторииToolStripMenuItem.Name = "ОтветственныеЗаАудиторииToolStripMenuItem"
        Me.ОтветственныеЗаАудиторииToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.ОтветственныеЗаАудиторииToolStripMenuItem.Text = "Ответственные за аудитории"
        '
        'ДобавитьToolStripMenuItem5
        '
        Me.ДобавитьToolStripMenuItem5.Name = "ДобавитьToolStripMenuItem5"
        Me.ДобавитьToolStripMenuItem5.Size = New System.Drawing.Size(126, 22)
        Me.ДобавитьToolStripMenuItem5.Text = "Добавить"
        '
        'ДолжностиToolStripMenuItem
        '
        Me.ДолжностиToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ДобавитьToolStripMenuItem6})
        Me.ДолжностиToolStripMenuItem.Name = "ДолжностиToolStripMenuItem"
        Me.ДолжностиToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.ДолжностиToolStripMenuItem.Text = "Должности"
        '
        'ДобавитьToolStripMenuItem6
        '
        Me.ДобавитьToolStripMenuItem6.Name = "ДобавитьToolStripMenuItem6"
        Me.ДобавитьToolStripMenuItem6.Size = New System.Drawing.Size(126, 22)
        Me.ДобавитьToolStripMenuItem6.Text = "Добавить"
        '
        'ПоставщикиToolStripMenuItem
        '
        Me.ПоставщикиToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ДобавитьToolStripMenuItem7})
        Me.ПоставщикиToolStripMenuItem.Name = "ПоставщикиToolStripMenuItem"
        Me.ПоставщикиToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.ПоставщикиToolStripMenuItem.Text = "Поставщики"
        '
        'ДобавитьToolStripMenuItem7
        '
        Me.ДобавитьToolStripMenuItem7.Name = "ДобавитьToolStripMenuItem7"
        Me.ДобавитьToolStripMenuItem7.Size = New System.Drawing.Size(126, 22)
        Me.ДобавитьToolStripMenuItem7.Text = "Добавить"
        '
        'СправочникиToolStripMenuItem
        '
        Me.СправочникиToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ПоискПоСложнымЗапросамToolStripMenuItem})
        Me.СправочникиToolStripMenuItem.Name = "СправочникиToolStripMenuItem"
        Me.СправочникиToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.СправочникиToolStripMenuItem.Text = "Отчёты"
        '
        'ПоискПоСложнымЗапросамToolStripMenuItem
        '
        Me.ПоискПоСложнымЗапросамToolStripMenuItem.Name = "ПоискПоСложнымЗапросамToolStripMenuItem"
        Me.ПоискПоСложнымЗапросамToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.ПоискПоСложнымЗапросамToolStripMenuItem.Text = "Поиск по сложным запросам"
        '
        'СправкаToolStripMenuItem
        '
        Me.СправкаToolStripMenuItem.Name = "СправкаToolStripMenuItem"
        Me.СправкаToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.СправкаToolStripMenuItem.Text = "Справка"
        '
        'MenuPanel
        '
        Me.MenuPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.MenuPanel.Controls.Add(Me.RequestButton)
        Me.MenuPanel.Controls.Add(Me.SettingsButton)
        Me.MenuPanel.Controls.Add(Me.WorkerButton)
        Me.MenuPanel.Controls.Add(Me.accountingButton)
        Me.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.MenuPanel.Location = New System.Drawing.Point(0, 0)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.Size = New System.Drawing.Size(200, 532)
        Me.MenuPanel.TabIndex = 7
        '
        'RequestButton
        '
        Me.RequestButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.RequestButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RequestButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.RequestButton.FlatAppearance.BorderSize = 0
        Me.RequestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RequestButton.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RequestButton.ForeColor = System.Drawing.Color.White
        Me.RequestButton.Image = Global.FormTechnisBD.My.Resources.Resources.Заявка
        Me.RequestButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.RequestButton.Location = New System.Drawing.Point(0, 328)
        Me.RequestButton.Name = "RequestButton"
        Me.RequestButton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RequestButton.Size = New System.Drawing.Size(200, 43)
        Me.RequestButton.TabIndex = 3
        Me.RequestButton.Text = "Заявки"
        Me.RequestButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RequestButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RequestButton.UseVisualStyleBackColor = False
        '
        'SettingsButton
        '
        Me.SettingsButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.SettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SettingsButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.SettingsButton.FlatAppearance.BorderSize = 0
        Me.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SettingsButton.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingsButton.ForeColor = System.Drawing.Color.White
        Me.SettingsButton.Image = Global.FormTechnisBD.My.Resources.Resources.Настройка
        Me.SettingsButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.SettingsButton.Location = New System.Drawing.Point(0, 368)
        Me.SettingsButton.Name = "SettingsButton"
        Me.SettingsButton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SettingsButton.Size = New System.Drawing.Size(200, 43)
        Me.SettingsButton.TabIndex = 2
        Me.SettingsButton.Text = "Настройка"
        Me.SettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SettingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SettingsButton.UseVisualStyleBackColor = False
        '
        'WorkerButton
        '
        Me.WorkerButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.WorkerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.WorkerButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.WorkerButton.FlatAppearance.BorderSize = 0
        Me.WorkerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WorkerButton.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkerButton.ForeColor = System.Drawing.Color.White
        Me.WorkerButton.Image = Global.FormTechnisBD.My.Resources.Resources.Кнопка_Сотрудники
        Me.WorkerButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.WorkerButton.Location = New System.Drawing.Point(0, 289)
        Me.WorkerButton.Name = "WorkerButton"
        Me.WorkerButton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WorkerButton.Size = New System.Drawing.Size(200, 43)
        Me.WorkerButton.TabIndex = 1
        Me.WorkerButton.Text = "Сотрудники"
        Me.WorkerButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WorkerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.WorkerButton.UseVisualStyleBackColor = False
        '
        'accountingButton
        '
        Me.accountingButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.accountingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.accountingButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.accountingButton.FlatAppearance.BorderSize = 0
        Me.accountingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.accountingButton.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accountingButton.ForeColor = System.Drawing.Color.White
        Me.accountingButton.Image = Global.FormTechnisBD.My.Resources.Resources.Кнопка_Бухгалтерия
        Me.accountingButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.accountingButton.Location = New System.Drawing.Point(0, 250)
        Me.accountingButton.Name = "accountingButton"
        Me.accountingButton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.accountingButton.Size = New System.Drawing.Size(200, 43)
        Me.accountingButton.TabIndex = 0
        Me.accountingButton.Text = "Бухгалтерия"
        Me.accountingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.accountingButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.accountingButton.UseVisualStyleBackColor = False
        '
        'GerbPictureBox
        '
        Me.GerbPictureBox.Location = New System.Drawing.Point(953, 112)
        Me.GerbPictureBox.Name = "GerbPictureBox"
        Me.GerbPictureBox.Size = New System.Drawing.Size(144, 100)
        Me.GerbPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GerbPictureBox.TabIndex = 6
        Me.GerbPictureBox.TabStop = False
        '
        'TechnisBDDataSet
        '
        Me.TechnisBDDataSet.DataSetName = "TechnisBDDataSet"
        Me.TechnisBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AuditoriumTableAdapter
        '
        Me.AuditoriumTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AuditoriumTableAdapter = Me.AuditoriumTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BuyRequestTableAdapter = Nothing
        Me.TableAdapterManager.PostsTableAdapter = Nothing
        Me.TableAdapterManager.ProgressRequestTableAdapter = Nothing
        Me.TableAdapterManager.ProviderTableAdapter = Nothing
        Me.TableAdapterManager.RequestTableAdapter = Nothing
        Me.TableAdapterManager.StatRequestTableAdapter = Nothing
        Me.TableAdapterManager.StatTechnisTableAdapter = Me.StatTechnisTableAdapter
        Me.TableAdapterManager.TechnisTableAdapter = Me.TechnisTableAdapter
        Me.TableAdapterManager.TypeRequestTableAdapter = Nothing
        Me.TableAdapterManager.TypeTechnisTableAdapter = Me.TypeTechnisTableAdapter
        Me.TableAdapterManager.UpdateOrder = FormTechnisBD.TechnisBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WorkersTableAdapter = Nothing
        '
        'StatTechnisTableAdapter
        '
        Me.StatTechnisTableAdapter.ClearBeforeFill = True
        '
        'TechnisTableAdapter
        '
        Me.TechnisTableAdapter.ClearBeforeFill = True
        '
        'TypeTechnisTableAdapter
        '
        Me.TypeTechnisTableAdapter.ClearBeforeFill = True
        '
        'TechnisForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1108, 532)
        Me.Controls.Add(Me.GerbPictureBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TechnisGroupBox)
        Me.Controls.Add(Me.MenuPanel)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "TechnisForm"
        Me.Text = "Просмотр техники"
        Me.TechnisGroupBox.ResumeLayout(False)
        Me.ContextMenu1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuPanel.ResumeLayout(False)
        CType(Me.GerbPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TechnisBDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TechnisListView As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents TechnisBDDataSet As TechnisBDDataSet
    Friend WithEvents AuditoriumTableAdapter As TechnisBDDataSetTableAdapters.AuditoriumTableAdapter
    Friend WithEvents TableAdapterManager As TechnisBDDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StatTechnisTableAdapter As TechnisBDDataSetTableAdapters.StatTechnisTableAdapter
    Friend WithEvents TechnisTableAdapter As TechnisBDDataSetTableAdapters.TechnisTableAdapter
    Friend WithEvents TypeTechnisTableAdapter As TechnisBDDataSetTableAdapters.TypeTechnisTableAdapter
    Friend WithEvents AddTechnisButton As Button
    Friend WithEvents DelTechnisButton As Button
    Friend WithEvents TechnisGroupBox As GroupBox
    Friend WithEvents ContextMenu1 As ContextMenuStrip
    Friend WithEvents ChangeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents NumberFilterTextBox As TextBox
    Friend WithEvents StatFilterComboBox As ComboBox
    Friend WithEvents AuditoriumFilterComboBox As ComboBox
    Friend WithEvents TypeFilterComboBox As ComboBox
    Friend WithEvents ClearFilterButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ФайлToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ИзменитьПодключениеToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОбщаяСтруктураToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TechnisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОтчётыToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ТехникаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ДобавитьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents АудиторииToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ДобавитьToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ТипТехникиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ДобавитьToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ЗаявкаСотрудникаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ДобавитьToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ЗаявкаМастераToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ДобавитьToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ОтветственныеЗаАудиторииToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ДобавитьToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ДолжностиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ДобавитьToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ПоставщикиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ДобавитьToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents СправочникиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ПоискПоСложнымЗапросамToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СправкаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AuditoriumToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WorkersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ЗаявкиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GerbPictureBox As PictureBox
    Friend WithEvents MenuPanel As Panel
    Friend WithEvents accountingButton As Button
    Friend WithEvents WorkerButton As Button
    Friend WithEvents SettingsButton As Button
    Friend WithEvents RequestButton As Button
    Friend WithEvents Tool As ToolTip
    Friend WithEvents t As ToolTip
End Class
