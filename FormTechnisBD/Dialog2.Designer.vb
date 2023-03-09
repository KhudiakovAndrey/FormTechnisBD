<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddAuditoriumDialog
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.AddAuditoriumPanel = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.FIOAudComboBox = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NameAudTextBox = New System.Windows.Forms.TextBox()
        Me.NumberAudTextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.AddAuditoriumPanel.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(175, 236)
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
        'AddAuditoriumPanel
        '
        Me.AddAuditoriumPanel.Controls.Add(Me.Label9)
        Me.AddAuditoriumPanel.Controls.Add(Me.FIOAudComboBox)
        Me.AddAuditoriumPanel.Controls.Add(Me.Label7)
        Me.AddAuditoriumPanel.Controls.Add(Me.Label6)
        Me.AddAuditoriumPanel.Controls.Add(Me.NameAudTextBox)
        Me.AddAuditoriumPanel.Controls.Add(Me.NumberAudTextBox)
        Me.AddAuditoriumPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.AddAuditoriumPanel.Location = New System.Drawing.Point(12, 12)
        Me.AddAuditoriumPanel.Name = "AddAuditoriumPanel"
        Me.AddAuditoriumPanel.Size = New System.Drawing.Size(312, 218)
        Me.AddAuditoriumPanel.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 16)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "ФИО сотрудника"
        '
        'FIOAudComboBox
        '
        Me.FIOAudComboBox.FormattingEnabled = True
        Me.FIOAudComboBox.Location = New System.Drawing.Point(13, 123)
        Me.FIOAudComboBox.Name = "FIOAudComboBox"
        Me.FIOAudComboBox.Size = New System.Drawing.Size(261, 24)
        Me.FIOAudComboBox.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 16)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Название "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Номер"
        '
        'NameAudTextBox
        '
        Me.NameAudTextBox.Location = New System.Drawing.Point(13, 69)
        Me.NameAudTextBox.Name = "NameAudTextBox"
        Me.NameAudTextBox.Size = New System.Drawing.Size(100, 22)
        Me.NameAudTextBox.TabIndex = 18
        '
        'NumberAudTextBox
        '
        Me.NumberAudTextBox.Location = New System.Drawing.Point(13, 22)
        Me.NumberAudTextBox.Name = "NumberAudTextBox"
        Me.NumberAudTextBox.Size = New System.Drawing.Size(138, 22)
        Me.NumberAudTextBox.TabIndex = 18
        '
        'AddAuditoriumDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(333, 277)
        Me.Controls.Add(Me.AddAuditoriumPanel)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddAuditoriumDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dialog2"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.AddAuditoriumPanel.ResumeLayout(False)
        Me.AddAuditoriumPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents AddAuditoriumPanel As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents FIOAudComboBox As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents NameAudTextBox As TextBox
    Friend WithEvents NumberAudTextBox As TextBox
End Class
