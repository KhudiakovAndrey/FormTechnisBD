Public Class AuditoriumForm
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WorkersListView.Items.Clear()
        AuditoriumListView.Items.Clear()

        FillWorkersList()
        FillAuditoriumList()
    End Sub

    Private Sub FillWorkersList()
        'TODO: данная строка кода позволяет загрузить данные в таблицу "TechnisBDDataSet.Workers". При необходимости она может быть перемещена или удалена.
        Me.WorkersTableAdapter.Fill(Me.TechnisBDDataSet.Workers)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "TechnisBDDataSet.Posts". При необходимости она может быть перемещена или удалена.
        Me.PostsTableAdapter.Fill(Me.TechnisBDDataSet.Posts)
        WorkersListView.Items.Clear()
        Dim itemsWork(7) As String
        Dim TempRowWork As DataRow
        For Each RowWork As DataRow In Me.TechnisBDDataSet.Workers.Rows
            itemsWork(1) = RowWork(1)
            itemsWork(2) = RowWork(2)
            itemsWork(3) = RowWork(3)
            TempRowWork = RowWork.GetParentRow("Posts_Workers_FK")
            itemsWork(4) = TempRowWork("NamePost")
            itemsWork(5) = RowWork(5)
            itemsWork(6) = RowWork(6)
            itemsWork(7) = RowWork(7)
            Dim it As New ListViewItem()
            it.Text = RowWork(0)
            it.SubItems.AddRange(itemsWork)
            WorkersListView.Items.Add(it)
        Next RowWork
        Me.AuditoriumTableAdapter.Fill(Me.TechnisBDDataSet.Auditorium)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "TechnisBDDataSet.Workers". При необходимости она может быть перемещена или удалена.
        AuditoriumListView.Items.Clear()
        Dim items(5) As String
        Dim TempRow As DataRow
        For Each Row As DataRow In Me.TechnisBDDataSet.Auditorium.Rows
            items(1) = Row(1)
            items(2) = Row(2)
            TempRow = Row.GetParentRow("Workers_Auditorium_FK")
            items(3) = TempRow("Surname")
            items(4) = TempRow("Name")
            items(5) = TempRow("Patronymic")
            Dim it As New ListViewItem()
            it.Text = Row(0)
            it.SubItems.AddRange(items)
            AuditoriumListView.Items.Add(it)
        Next Row
    End Sub

    Private Sub FillAuditoriumList()


    End Sub

    Private Sub AddAuditoriumButton_Click(sender As Object, e As EventArgs) Handles AddAuditoriumButton.Click

        With AddAuditoriumDialog
            .Text = "Добавление аудитории."
            .NumberAudTextBox.Text = ""
            .NameAudTextBox.Text = ""
            .FIOAudComboBox.Items.Clear()
            .FIOAudComboBox.Text = ""
            For Each Row As DataRow In TechnisBDDataSet.Workers.Rows
                .FIOAudComboBox.Items.Add(Row("Surname") + " " + Row("Name") + " " + Row("Patronymic"))
            Next Row
            .ShowDialog()
            If .DialogResult = DialogResult.OK Then
                FillAuditoriumList()
            End If
        End With
    End Sub
End Class