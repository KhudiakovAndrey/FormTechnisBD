Public Class Form4
    Private Sub WorkersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.WorkersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TechnisBDDataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "TechnisBDDataSet.Posts". При необходимости она может быть перемещена или удалена.
        Me.PostsTableAdapter.Fill(Me.TechnisBDDataSet.Posts)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "TechnisBDDataSet.Workers". При необходимости она может быть перемещена или удалена.
        Me.WorkersTableAdapter.Fill(Me.TechnisBDDataSet.Workers)

    End Sub
End Class