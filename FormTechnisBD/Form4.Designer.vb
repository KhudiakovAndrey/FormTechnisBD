<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.components = New System.ComponentModel.Container()
        Me.TechnisBDDataSet = New FormTechnisBD.TechnisBDDataSet()
        Me.WorkersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WorkersTableAdapter = New FormTechnisBD.TechnisBDDataSetTableAdapters.WorkersTableAdapter()
        Me.TableAdapterManager = New FormTechnisBD.TechnisBDDataSetTableAdapters.TableAdapterManager()
        Me.WorkersDataGridView = New System.Windows.Forms.DataGridView()
        Me.PostsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PostsTableAdapter = New FormTechnisBD.TechnisBDDataSetTableAdapters.PostsTableAdapter()
        Me.PostsDataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.WorkersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDWorkerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatronymicDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumberPhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthdayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TechnisBDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PostsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PostsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.WorkersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TechnisBDDataSet
        '
        Me.TechnisBDDataSet.DataSetName = "TechnisBDDataSet"
        Me.TechnisBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WorkersBindingSource
        '
        Me.WorkersBindingSource.DataMember = "Workers"
        Me.WorkersBindingSource.DataSource = Me.TechnisBDDataSet
        '
        'WorkersTableAdapter
        '
        Me.WorkersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AuditoriumTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BuyRequestTableAdapter = Nothing
        Me.TableAdapterManager.PostsTableAdapter = Me.PostsTableAdapter
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
        'WorkersDataGridView
        '
        Me.WorkersDataGridView.AutoGenerateColumns = False
        Me.WorkersDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.WorkersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WorkersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDWorkerDataGridViewTextBoxColumn, Me.SurnameDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.PatronymicDataGridViewTextBoxColumn, Me.NumberPhoneDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.BirthdayDataGridViewTextBoxColumn})
        Me.WorkersDataGridView.DataSource = Me.WorkersBindingSource1
        Me.WorkersDataGridView.Location = New System.Drawing.Point(223, 3)
        Me.WorkersDataGridView.Name = "WorkersDataGridView"
        Me.WorkersDataGridView.RowHeadersVisible = False
        Me.WorkersDataGridView.Size = New System.Drawing.Size(741, 220)
        Me.WorkersDataGridView.TabIndex = 1
        '
        'PostsBindingSource
        '
        Me.PostsBindingSource.DataMember = "Posts"
        Me.PostsBindingSource.DataSource = Me.TechnisBDDataSet
        '
        'PostsTableAdapter
        '
        Me.PostsTableAdapter.ClearBeforeFill = True
        '
        'PostsDataGridView
        '
        Me.PostsDataGridView.AutoGenerateColumns = False
        Me.PostsDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.PostsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PostsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.PostsDataGridView.DataSource = Me.PostsBindingSource
        Me.PostsDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.PostsDataGridView.Name = "PostsDataGridView"
        Me.PostsDataGridView.RowHeadersVisible = False
        Me.PostsDataGridView.Size = New System.Drawing.Size(200, 220)
        Me.PostsDataGridView.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1017, 280)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Просмотр сотрудников"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.WorkersDataGridView)
        Me.Panel1.Controls.Add(Me.PostsDataGridView)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Panel1.Location = New System.Drawing.Point(17, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(987, 238)
        Me.Panel1.TabIndex = 3
        '
        'WorkersBindingSource1
        '
        Me.WorkersBindingSource1.DataMember = "Posts_Workers_FK"
        Me.WorkersBindingSource1.DataSource = Me.PostsBindingSource
        '
        'IDWorkerDataGridViewTextBoxColumn
        '
        Me.IDWorkerDataGridViewTextBoxColumn.DataPropertyName = "IDWorker"
        Me.IDWorkerDataGridViewTextBoxColumn.HeaderText = "IDWorker"
        Me.IDWorkerDataGridViewTextBoxColumn.Name = "IDWorkerDataGridViewTextBoxColumn"
        Me.IDWorkerDataGridViewTextBoxColumn.Visible = False
        '
        'SurnameDataGridViewTextBoxColumn
        '
        Me.SurnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SurnameDataGridViewTextBoxColumn.DataPropertyName = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.HeaderText = "Фамилия"
        Me.SurnameDataGridViewTextBoxColumn.Name = "SurnameDataGridViewTextBoxColumn"
        Me.SurnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.SurnameDataGridViewTextBoxColumn.Width = 81
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Имя"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn.Width = 54
        '
        'PatronymicDataGridViewTextBoxColumn
        '
        Me.PatronymicDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PatronymicDataGridViewTextBoxColumn.DataPropertyName = "Patronymic"
        Me.PatronymicDataGridViewTextBoxColumn.HeaderText = "Отчество"
        Me.PatronymicDataGridViewTextBoxColumn.Name = "PatronymicDataGridViewTextBoxColumn"
        Me.PatronymicDataGridViewTextBoxColumn.ReadOnly = True
        Me.PatronymicDataGridViewTextBoxColumn.Width = 79
        '
        'NumberPhoneDataGridViewTextBoxColumn
        '
        Me.NumberPhoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NumberPhoneDataGridViewTextBoxColumn.DataPropertyName = "NumberPhone"
        Me.NumberPhoneDataGridViewTextBoxColumn.HeaderText = "Телефон"
        Me.NumberPhoneDataGridViewTextBoxColumn.Name = "NumberPhoneDataGridViewTextBoxColumn"
        Me.NumberPhoneDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumberPhoneDataGridViewTextBoxColumn.Width = 77
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Адресс"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        Me.AddressDataGridViewTextBoxColumn.Width = 69
        '
        'BirthdayDataGridViewTextBoxColumn
        '
        Me.BirthdayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.BirthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday"
        Me.BirthdayDataGridViewTextBoxColumn.HeaderText = "Дата рождения"
        Me.BirthdayDataGridViewTextBoxColumn.Name = "BirthdayDataGridViewTextBoxColumn"
        Me.BirthdayDataGridViewTextBoxColumn.ReadOnly = True
        Me.BirthdayDataGridViewTextBoxColumn.Width = 102
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "IDPost"
        Me.DataGridViewTextBoxColumn9.HeaderText = "IDPost"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "NamePost"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Должность"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.ToolTipText = "Просмотр должности"
        Me.DataGridViewTextBoxColumn10.Width = 150
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 305)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form4"
        Me.Text = "Просмотр сотрудников"
        CType(Me.TechnisBDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PostsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PostsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.WorkersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TechnisBDDataSet As TechnisBDDataSet
    Friend WithEvents WorkersBindingSource As BindingSource
    Friend WithEvents WorkersTableAdapter As TechnisBDDataSetTableAdapters.WorkersTableAdapter
    Friend WithEvents TableAdapterManager As TechnisBDDataSetTableAdapters.TableAdapterManager
    Friend WithEvents WorkersDataGridView As DataGridView
    Friend WithEvents PostsTableAdapter As TechnisBDDataSetTableAdapters.PostsTableAdapter
    Friend WithEvents PostsBindingSource As BindingSource
    Friend WithEvents PostsDataGridView As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents WorkersBindingSource1 As BindingSource
    Friend WithEvents IDWorkerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SurnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatronymicDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumberPhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BirthdayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
End Class
