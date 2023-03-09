<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddTechnisDialog
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ModelTechTextBox = New System.Windows.Forms.TextBox()
        Me.StatTechComboBox = New System.Windows.Forms.ComboBox()
        Me.TypeTechComboBox = New System.Windows.Forms.ComboBox()
        Me.AuditrTechComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AddTechnisPanel = New System.Windows.Forms.Panel()
        Me.NumberTechTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.AddTechnisPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(220, 301)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "ОК"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Отмена"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(12, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Статус"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(12, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Тип"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(12, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Модель"
        '
        'ModelTechTextBox
        '
        Me.ModelTechTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ModelTechTextBox.Location = New System.Drawing.Point(15, 228)
        Me.ModelTechTextBox.Name = "ModelTechTextBox"
        Me.ModelTechTextBox.Size = New System.Drawing.Size(320, 23)
        Me.ModelTechTextBox.TabIndex = 7
        '
        'StatTechComboBox
        '
        Me.StatTechComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.StatTechComboBox.FormattingEnabled = True
        Me.StatTechComboBox.Location = New System.Drawing.Point(15, 119)
        Me.StatTechComboBox.Name = "StatTechComboBox"
        Me.StatTechComboBox.Size = New System.Drawing.Size(212, 24)
        Me.StatTechComboBox.TabIndex = 9
        '
        'TypeTechComboBox
        '
        Me.TypeTechComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TypeTechComboBox.FormattingEnabled = True
        Me.TypeTechComboBox.Location = New System.Drawing.Point(15, 171)
        Me.TypeTechComboBox.Name = "TypeTechComboBox"
        Me.TypeTechComboBox.Size = New System.Drawing.Size(274, 24)
        Me.TypeTechComboBox.TabIndex = 10
        '
        'AuditrTechComboBox
        '
        Me.AuditrTechComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.AuditrTechComboBox.FormattingEnabled = True
        Me.AuditrTechComboBox.Location = New System.Drawing.Point(15, 68)
        Me.AuditrTechComboBox.Name = "AuditrTechComboBox"
        Me.AuditrTechComboBox.Size = New System.Drawing.Size(212, 24)
        Me.AuditrTechComboBox.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Аудитория"
        '
        'AddTechnisPanel
        '
        Me.AddTechnisPanel.Controls.Add(Me.NumberTechTextBox)
        Me.AddTechnisPanel.Controls.Add(Me.Label5)
        Me.AddTechnisPanel.Controls.Add(Me.StatTechComboBox)
        Me.AddTechnisPanel.Controls.Add(Me.ModelTechTextBox)
        Me.AddTechnisPanel.Controls.Add(Me.TypeTechComboBox)
        Me.AddTechnisPanel.Controls.Add(Me.Label3)
        Me.AddTechnisPanel.Controls.Add(Me.Label4)
        Me.AddTechnisPanel.Controls.Add(Me.Label1)
        Me.AddTechnisPanel.Controls.Add(Me.AuditrTechComboBox)
        Me.AddTechnisPanel.Controls.Add(Me.Label2)
        Me.AddTechnisPanel.Location = New System.Drawing.Point(12, 23)
        Me.AddTechnisPanel.Name = "AddTechnisPanel"
        Me.AddTechnisPanel.Size = New System.Drawing.Size(346, 268)
        Me.AddTechnisPanel.TabIndex = 11
        '
        'NumberTechTextBox
        '
        Me.NumberTechTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumberTechTextBox.Location = New System.Drawing.Point(15, 21)
        Me.NumberTechTextBox.Name = "NumberTechTextBox"
        Me.NumberTechTextBox.Size = New System.Drawing.Size(212, 23)
        Me.NumberTechTextBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Номер"
        '
        'AddTechnisDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(378, 342)
        Me.Controls.Add(Me.AddTechnisPanel)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddTechnisDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Добавление или изменение техники"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.AddTechnisPanel.ResumeLayout(False)
        Me.AddTechnisPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ModelTechTextBox As TextBox
    Friend WithEvents StatTechComboBox As ComboBox
    Friend WithEvents TypeTechComboBox As ComboBox
    Friend WithEvents AuditrTechComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents AddTechnisPanel As Panel
    Friend WithEvents NumberTechTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
