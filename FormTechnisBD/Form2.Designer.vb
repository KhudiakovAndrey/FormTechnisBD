<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TechnisDataGridForm
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TechnisDataGridView = New System.Windows.Forms.DataGridView()
        Me.TypeTechnisDataGridView = New System.Windows.Forms.DataGridView()
        Me.StatTechnisDataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.AuditoriumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TechnisBDDataSet = New FormTechnisBD.TechnisBDDataSet()
        Me.StatTechnisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TypeTechnisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TechnisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WorkersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TechnisTableAdapter = New FormTechnisBD.TechnisBDDataSetTableAdapters.TechnisTableAdapter()
        Me.TableAdapterManager = New FormTechnisBD.TechnisBDDataSetTableAdapters.TableAdapterManager()
        Me.AuditoriumTableAdapter = New FormTechnisBD.TechnisBDDataSetTableAdapters.AuditoriumTableAdapter()
        Me.StatTechnisTableAdapter = New FormTechnisBD.TechnisBDDataSetTableAdapters.StatTechnisTableAdapter()
        Me.TypeTechnisTableAdapter = New FormTechnisBD.TechnisBDDataSetTableAdapters.TypeTechnisTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuditoriumDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TechnisDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypeTechnisDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatTechnisDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.AuditoriumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TechnisBDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatTechnisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypeTechnisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TechnisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuditoriumDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TechnisDataGridView
        '
        Me.TechnisDataGridView.AutoGenerateColumns = False
        Me.TechnisDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.TechnisDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TechnisDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.TechnisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TechnisDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.TechnisDataGridView.DataSource = Me.TechnisBindingSource
        Me.TechnisDataGridView.Location = New System.Drawing.Point(6, 19)
        Me.TechnisDataGridView.Name = "TechnisDataGridView"
        Me.TechnisDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TechnisDataGridView.Size = New System.Drawing.Size(744, 220)
        Me.TechnisDataGridView.TabIndex = 1
        '
        'TypeTechnisDataGridView
        '
        Me.TypeTechnisDataGridView.AutoGenerateColumns = False
        Me.TypeTechnisDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TypeTechnisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TypeTechnisDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.TypeTechnisDataGridView.DataSource = Me.TypeTechnisBindingSource
        Me.TypeTechnisDataGridView.Location = New System.Drawing.Point(6, 19)
        Me.TypeTechnisDataGridView.Name = "TypeTechnisDataGridView"
        Me.TypeTechnisDataGridView.Size = New System.Drawing.Size(257, 220)
        Me.TypeTechnisDataGridView.TabIndex = 3
        '
        'StatTechnisDataGridView
        '
        Me.StatTechnisDataGridView.AutoGenerateColumns = False
        Me.StatTechnisDataGridView.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StatTechnisDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.StatTechnisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StatTechnisDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.StatTechnisDataGridView.DataSource = Me.StatTechnisBindingSource
        Me.StatTechnisDataGridView.Location = New System.Drawing.Point(35, 19)
        Me.StatTechnisDataGridView.Name = "StatTechnisDataGridView"
        Me.StatTechnisDataGridView.Size = New System.Drawing.Size(133, 220)
        Me.StatTechnisDataGridView.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TechnisDataGridView)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(759, 248)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Редактирование техники"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TypeTechnisDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(562, 282)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(269, 254)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Редактирование типа техники"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.AuditoriumDataGridView)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 282)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(332, 254)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Редактирование аудиторий"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.StatTechnisDataGridView)
        Me.GroupBox4.Location = New System.Drawing.Point(350, 282)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(206, 254)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Редактирование статуса техники"
        '
        'AuditoriumBindingSource
        '
        Me.AuditoriumBindingSource.DataMember = "Auditorium"
        Me.AuditoriumBindingSource.DataSource = Me.TechnisBDDataSet
        '
        'TechnisBDDataSet
        '
        Me.TechnisBDDataSet.DataSetName = "TechnisBDDataSet"
        Me.TechnisBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StatTechnisBindingSource
        '
        Me.StatTechnisBindingSource.DataMember = "StatTechnis"
        Me.StatTechnisBindingSource.DataSource = Me.TechnisBDDataSet
        '
        'TypeTechnisBindingSource
        '
        Me.TypeTechnisBindingSource.DataMember = "TypeTechnis"
        Me.TypeTechnisBindingSource.DataSource = Me.TechnisBDDataSet
        '
        'TechnisBindingSource
        '
        Me.TechnisBindingSource.DataMember = "Technis"
        Me.TechnisBindingSource.DataSource = Me.TechnisBDDataSet
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "IDType"
        Me.DataGridViewTextBoxColumn11.HeaderText = "IDType"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "NameType"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Тип"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 51
        '
        'WorkersBindingSource
        '
        Me.WorkersBindingSource.DataMember = "Workers"
        Me.WorkersBindingSource.DataSource = Me.TechnisBDDataSet
        '
        'TechnisTableAdapter
        '
        Me.TechnisTableAdapter.ClearBeforeFill = True
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
        'AuditoriumTableAdapter
        '
        Me.AuditoriumTableAdapter.ClearBeforeFill = True
        '
        'StatTechnisTableAdapter
        '
        Me.StatTechnisTableAdapter.ClearBeforeFill = True
        '
        'TypeTechnisTableAdapter
        '
        Me.TypeTechnisTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IDTechnis"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IDTechnis"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 81
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NumberTechnis"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Номер"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 66
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IDAuditorium"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.AuditoriumBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "NumberAuditorium"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Аудитория"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "IDAuditorium"
        Me.DataGridViewTextBoxColumn3.Width = 85
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IDStat"
        Me.DataGridViewTextBoxColumn4.DataSource = Me.StatTechnisBindingSource
        Me.DataGridViewTextBoxColumn4.DisplayMember = "NameStat"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Статус"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn4.ValueMember = "IDStat"
        Me.DataGridViewTextBoxColumn4.Width = 66
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "IDType"
        Me.DataGridViewTextBoxColumn5.DataSource = Me.TypeTechnisBindingSource
        Me.DataGridViewTextBoxColumn5.DisplayMember = "NameType"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Тип"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn5.ValueMember = "IDType"
        Me.DataGridViewTextBoxColumn5.Width = 51
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NameModel"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Модель"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 71
        '
        'AuditoriumDataGridView
        '
        Me.AuditoriumDataGridView.AutoGenerateColumns = False
        Me.AuditoriumDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.AuditoriumDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AuditoriumDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.AuditoriumDataGridView.DataSource = Me.AuditoriumBindingSource
        Me.AuditoriumDataGridView.Location = New System.Drawing.Point(6, 19)
        Me.AuditoriumDataGridView.Name = "AuditoriumDataGridView"
        Me.AuditoriumDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.AuditoriumDataGridView.Size = New System.Drawing.Size(320, 220)
        Me.AuditoriumDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "IDStat"
        Me.DataGridViewTextBoxColumn13.HeaderText = "IDStat"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "NameStat"
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn14.HeaderText = "Статус"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 66
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "IDAuditorium"
        Me.DataGridViewTextBoxColumn7.HeaderText = "IDAuditorium"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "NumberAuditorium"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Номер"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 66
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "NameAuditorium"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Название"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 82
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "IDWorker"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Ответственный сотрудник"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'TechnisDataGridForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 547)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TechnisDataGridForm"
        Me.Text = "Просмотр и таблиц связанных с техникой"
        CType(Me.TechnisDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypeTechnisDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatTechnisDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.AuditoriumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TechnisBDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatTechnisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypeTechnisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TechnisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuditoriumDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TechnisBDDataSet As TechnisBDDataSet
    Friend WithEvents TechnisBindingSource As BindingSource
    Friend WithEvents TechnisTableAdapter As TechnisBDDataSetTableAdapters.TechnisTableAdapter
    Friend WithEvents TableAdapterManager As TechnisBDDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AuditoriumTableAdapter As TechnisBDDataSetTableAdapters.AuditoriumTableAdapter
    Friend WithEvents TechnisDataGridView As DataGridView
    Friend WithEvents TypeTechnisTableAdapter As TechnisBDDataSetTableAdapters.TypeTechnisTableAdapter
    Friend WithEvents TypeTechnisBindingSource As BindingSource
    Friend WithEvents StatTechnisTableAdapter As TechnisBDDataSetTableAdapters.StatTechnisTableAdapter
    Friend WithEvents TypeTechnisDataGridView As DataGridView
    Friend WithEvents StatTechnisBindingSource As BindingSource
    Friend WithEvents StatTechnisDataGridView As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents AuditoriumBindingSource As BindingSource
    Friend WithEvents WorkersBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents AuditoriumDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
End Class
