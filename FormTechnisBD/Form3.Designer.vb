<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AuditoriumForm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TechnisBDDataSet = New FormTechnisBD.TechnisBDDataSet()
        Me.AuditoriumTableAdapter = New FormTechnisBD.TechnisBDDataSetTableAdapters.AuditoriumTableAdapter()
        Me.TableAdapterManager = New FormTechnisBD.TechnisBDDataSetTableAdapters.TableAdapterManager()
        Me.WorkersTableAdapter = New FormTechnisBD.TechnisBDDataSetTableAdapters.WorkersTableAdapter()
        Me.AuditoriumListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.WorkersListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PostsTableAdapter = New FormTechnisBD.TechnisBDDataSetTableAdapters.PostsTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ClearWorkerButton = New System.Windows.Forms.Button()
        Me.AddWorkerButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ClearAuditoriumButton = New System.Windows.Forms.Button()
        Me.AddAuditoriumButton = New System.Windows.Forms.Button()
        CType(Me.TechnisBDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.TableAdapterManager.StatTechnisTableAdapter = Nothing
        Me.TableAdapterManager.TechnisTableAdapter = Nothing
        Me.TableAdapterManager.TypeRequestTableAdapter = Nothing
        Me.TableAdapterManager.TypeTechnisTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FormTechnisBD.TechnisBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WorkersTableAdapter = Me.WorkersTableAdapter
        '
        'WorkersTableAdapter
        '
        Me.WorkersTableAdapter.ClearBeforeFill = True
        '
        'AuditoriumListView
        '
        Me.AuditoriumListView.CheckBoxes = True
        Me.AuditoriumListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.AuditoriumListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.AuditoriumListView.FullRowSelect = True
        Me.AuditoriumListView.GridLines = True
        Me.AuditoriumListView.HideSelection = False
        Me.AuditoriumListView.Location = New System.Drawing.Point(7, 17)
        Me.AuditoriumListView.Name = "AuditoriumListView"
        Me.AuditoriumListView.Size = New System.Drawing.Size(709, 175)
        Me.AuditoriumListView.TabIndex = 0
        Me.AuditoriumListView.UseCompatibleStateImageBehavior = False
        Me.AuditoriumListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "IDAuditorium"
        Me.ColumnHeader1.Width = 53
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Номер"
        Me.ColumnHeader2.Width = 79
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Название"
        Me.ColumnHeader3.Width = 179
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Фамилия"
        Me.ColumnHeader4.Width = 105
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Имя"
        Me.ColumnHeader5.Width = 129
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Отчество"
        Me.ColumnHeader6.Width = 158
        '
        'WorkersListView
        '
        Me.WorkersListView.CheckBoxes = True
        Me.WorkersListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14})
        Me.WorkersListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.WorkersListView.FullRowSelect = True
        Me.WorkersListView.GridLines = True
        Me.WorkersListView.HideSelection = False
        Me.WorkersListView.Location = New System.Drawing.Point(7, 19)
        Me.WorkersListView.Name = "WorkersListView"
        Me.WorkersListView.Size = New System.Drawing.Size(989, 153)
        Me.WorkersListView.TabIndex = 1
        Me.WorkersListView.UseCompatibleStateImageBehavior = False
        Me.WorkersListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "IDWorker"
        Me.ColumnHeader7.Width = 58
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Фамилия"
        Me.ColumnHeader8.Width = 93
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Имя"
        Me.ColumnHeader9.Width = 83
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Отчество"
        Me.ColumnHeader10.Width = 120
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Должность"
        Me.ColumnHeader11.Width = 170
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Номер телефона"
        Me.ColumnHeader12.Width = 142
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Адрес"
        Me.ColumnHeader13.Width = 192
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Дата рождения"
        Me.ColumnHeader14.Width = 110
        '
        'PostsTableAdapter
        '
        Me.PostsTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ClearWorkerButton)
        Me.GroupBox1.Controls.Add(Me.WorkersListView)
        Me.GroupBox1.Controls.Add(Me.AddWorkerButton)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 255)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1002, 209)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Сотрудники"
        '
        'ClearWorkerButton
        '
        Me.ClearWorkerButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ClearWorkerButton.ForeColor = System.Drawing.Color.Red
        Me.ClearWorkerButton.Location = New System.Drawing.Point(176, 178)
        Me.ClearWorkerButton.Name = "ClearWorkerButton"
        Me.ClearWorkerButton.Size = New System.Drawing.Size(235, 23)
        Me.ClearWorkerButton.TabIndex = 7
        Me.ClearWorkerButton.Text = "Удалить отмеченного сотрудника"
        Me.ClearWorkerButton.UseVisualStyleBackColor = True
        '
        'AddWorkerButton
        '
        Me.AddWorkerButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.AddWorkerButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AddWorkerButton.Location = New System.Drawing.Point(7, 178)
        Me.AddWorkerButton.Name = "AddWorkerButton"
        Me.AddWorkerButton.Size = New System.Drawing.Size(163, 23)
        Me.AddWorkerButton.TabIndex = 6
        Me.AddWorkerButton.Text = "Добавить сотрудника"
        Me.AddWorkerButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.AuditoriumListView)
        Me.GroupBox2.Controls.Add(Me.ClearAuditoriumButton)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(727, 228)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Аудитории"
        '
        'ClearAuditoriumButton
        '
        Me.ClearAuditoriumButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ClearAuditoriumButton.ForeColor = System.Drawing.Color.Red
        Me.ClearAuditoriumButton.Location = New System.Drawing.Point(154, 198)
        Me.ClearAuditoriumButton.Name = "ClearAuditoriumButton"
        Me.ClearAuditoriumButton.Size = New System.Drawing.Size(225, 23)
        Me.ClearAuditoriumButton.TabIndex = 5
        Me.ClearAuditoriumButton.Text = "Удалить отмеченную аудиторию"
        Me.ClearAuditoriumButton.UseVisualStyleBackColor = True
        '
        'AddAuditoriumButton
        '
        Me.AddAuditoriumButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.AddAuditoriumButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AddAuditoriumButton.Location = New System.Drawing.Point(12, 210)
        Me.AddAuditoriumButton.Name = "AddAuditoriumButton"
        Me.AddAuditoriumButton.Size = New System.Drawing.Size(141, 23)
        Me.AddAuditoriumButton.TabIndex = 4
        Me.AddAuditoriumButton.Text = "Добавить аудиторию"
        Me.AddAuditoriumButton.UseVisualStyleBackColor = True
        '
        'AuditoriumForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 479)
        Me.Controls.Add(Me.AddAuditoriumButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.MinimizeBox = False
        Me.Name = "AuditoriumForm"
        Me.Text = "Просмотр и изменения аудиторий"
        CType(Me.TechnisBDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TechnisBDDataSet As TechnisBDDataSet
    Friend WithEvents AuditoriumTableAdapter As TechnisBDDataSetTableAdapters.AuditoriumTableAdapter
    Friend WithEvents TableAdapterManager As TechnisBDDataSetTableAdapters.TableAdapterManager
    Friend WithEvents WorkersTableAdapter As TechnisBDDataSetTableAdapters.WorkersTableAdapter
    Friend WithEvents AuditoriumListView As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents WorkersListView As ListView
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents PostsTableAdapter As TechnisBDDataSetTableAdapters.PostsTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ClearWorkerButton As Button
    Friend WithEvents AddWorkerButton As Button
    Friend WithEvents ClearAuditoriumButton As Button
    Friend WithEvents AddAuditoriumButton As Button
End Class
