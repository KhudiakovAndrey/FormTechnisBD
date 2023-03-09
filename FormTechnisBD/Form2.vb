Public Class TechnisDataGridForm
    Private Sub TechnisBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TechnisBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TechnisBDDataSet)

    End Sub

    Private Sub AllTableForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "TechnisBDDataSet.StatTechnis". При необходимости она может быть перемещена или удалена.
        Me.StatTechnisTableAdapter.Fill(Me.TechnisBDDataSet.StatTechnis)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "TechnisBDDataSet.TypeTechnis". При необходимости она может быть перемещена или удалена.
        Me.TypeTechnisTableAdapter.Fill(Me.TechnisBDDataSet.TypeTechnis)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "TechnisBDDataSet.Auditorium". При необходимости она может быть перемещена или удалена.
        Me.AuditoriumTableAdapter.Fill(Me.TechnisBDDataSet.Auditorium)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "TechnisBDDataSet.Technis". При необходимости она может быть перемещена или удалена.
        Me.TechnisTableAdapter.Fill(Me.TechnisBDDataSet.Technis)

    End Sub
End Class