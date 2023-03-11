Public Class TechnisForm
    Dim LastSelectedItem As ListViewItem
    Private Sub TechnisForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TechnisListView.Items.Clear()
        FillTechnisList()
        GerbPictureBox.Image = Image.FromFile(IO.Directory.GetCurrentDirectory & "\Picture\logotip2.png")
    End Sub

    Private Sub FillTechnisList()
        'TODO: данная строка кода позволяет загрузить данные в таблицу "TechnisBDDataSet.Workers". При необходимости она может быть перемещена или удалена.
        Me.WorkersTableAdapter.Fill(Me.TechnisBDDataSet.Workers)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "TechnisBDDataSet.TypeTechnis". При необходимости она может быть перемещена или удалена.
        Me.TypeTechnisTableAdapter.Fill(Me.TechnisBDDataSet.TypeTechnis)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "TechnisBDDataSet.TypeRequest". При необходимости она может быть перемещена или удалена.
        Me.TypeRequestTableAdapter.Fill(Me.TechnisBDDataSet.TypeRequest)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "TechnisBDDataSet.Technis". При необходимости она может быть перемещена или удалена.
        Me.TechnisTableAdapter.Fill(Me.TechnisBDDataSet.Technis)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "TechnisBDDataSet.StatTechnis". При необходимости она может быть перемещена или удалена.
        Me.StatTechnisTableAdapter.Fill(Me.TechnisBDDataSet.StatTechnis)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "TechnisBDDataSet.StatRequest". При необходимости она может быть перемещена или удалена.
        Me.StatRequestTableAdapter.Fill(Me.TechnisBDDataSet.StatRequest)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "TechnisBDDataSet.Request". При необходимости она может быть перемещена или удалена.
        Me.RequestTableAdapter.Fill(Me.TechnisBDDataSet.Request)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "TechnisBDDataSet.Provider". При необходимости она может быть перемещена или удалена.
        Me.ProviderTableAdapter.Fill(Me.TechnisBDDataSet.Provider)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "TechnisBDDataSet.ProgressRequest". При необходимости она может быть перемещена или удалена.
        Me.ProgressRequestTableAdapter.Fill(Me.TechnisBDDataSet.ProgressRequest)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "TechnisBDDataSet.Posts". При необходимости она может быть перемещена или удалена.
        Me.PostsTableAdapter.Fill(Me.TechnisBDDataSet.Posts)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "TechnisBDDataSet.BuyRequest". При необходимости она может быть перемещена или удалена.
        Me.BuyRequestTableAdapter.Fill(Me.TechnisBDDataSet.BuyRequest)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "TechnisBDDataSet.Auditorium". При необходимости она может быть перемещена или удалена.
        Me.AuditoriumTableAdapter.Fill(Me.TechnisBDDataSet.Auditorium)
        Dim RowCB As DataRow
        For Each RowCB In Me.TechnisBDDataSet.StatTechnis.Rows  '
            StatFilterComboBox.Items.Add(RowCB("NameStat"))     '    Заполнение StatFilterComboBox значениями
        Next RowCB                                              '

        For Each RowCB In Me.TechnisBDDataSet.Auditorium.Rows          '
            AuditoriumFilterComboBox.Items.Add(RowCB("NumberAuditorium")) ' Заполнение AuditoriumFilterComboBox значениями
        Next RowCB                                                      '    

        For Each RowCB In Me.TechnisBDDataSet.TypeTechnis.Rows          '
            TypeFilterComboBox.Items.Add(RowCB("NameType"))             ' Заполнение TypeFilterComboBox значениями
        Next RowCB                                                      '

        TechnisListView.Items.Clear()
        Dim items(5) As String
        Dim TempRow As DataRow
        For Each Row As DataRow In
            Me.TechnisBDDataSet.Technis.Rows
            items(1) = Row(1)
            TempRow = Row.GetParentRow("Auditorium_Technis_FK")
            items(2) = TempRow(1)
            TempRow = Row.GetParentRow("StatTechnis_Technis_FK")
            items(3) = TempRow(1)
            TempRow = Row.GetParentRow("TypeTechnis_Technis_FK")
            items(4) = TempRow(1)
            items(5) = Row(5)
            Dim it As New ListViewItem()
            it.Text = Row(0)
            it.SubItems.AddRange(items)
            TechnisListView.Items.Add(it)
        Next Row
        TechnisGroupBox.Text = "Просмотр и изменение техники (техники на текущий момент " & Me.TechnisBDDataSet.Technis.Rows.Count & ")"
    End Sub

    Private Sub AddTechnisButton_Click(sender As Object, e As EventArgs) Handles AddTechnisButton.Click
        With AddTechnisDialog
            .Text = "Добавление техники"
            .AddOrChange = False
            .NumberTechTextBox.Text = " "
            .AuditrTechComboBox.Text = " "
            .AuditrTechComboBox.Items.Clear()
            For Each Row As DataRow In
                    Me.TechnisBDDataSet.Auditorium.Rows
                .AuditrTechComboBox.Items.Add(Row("NameAuditorium"))
            Next Row
            .StatTechComboBox.Text = " "
            .StatTechComboBox.Items.Clear()
            For Each Row As DataRow In
                    Me.TechnisBDDataSet.StatTechnis.Rows
                .StatTechComboBox.Items.Add(Row("NameStat"))
            Next
            .TypeTechComboBox.Text = " "
            .TypeTechComboBox.Items.Clear()
            For Each Row As DataRow In
                    Me.TechnisBDDataSet.TypeTechnis.Rows
                .TypeTechComboBox.Items.Add(Row("NameType"))
            Next
            .ModelTechTextBox.Text = " "
            .ShowDialog()
            If .DialogResult = DialogResult.OK Then
                FillTechnisList()
            End If
        End With
    End Sub

    Private Sub DelTechnisButton_Click(sender As Object, e As EventArgs) Handles DelTechnisButton.Click
        Dim Rows() As DataRow
        For Each item As ListViewItem In
                TechnisListView.CheckedItems
            Rows = TechnisBDDataSet.Technis.Select("IDTechnis = '" & item.Text & "'")
            TechnisTableAdapter.Delete(Rows(0)(0), Rows(0)(1), Rows(0)(2), Rows(0)(3), Rows(0)(4), Rows(0)(5))
            item.Remove()
        Next item
        Me.TechnisTableAdapter.Fill(TechnisBDDataSet.Technis)
    End Sub
    Private Sub TechnisListView_MouseClick(sender As Object, e As MouseEventArgs) Handles TechnisListView.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenu1.Show(sender, e.X, e.Y)
        End If
    End Sub
    Private Sub TechnisListView_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles TechnisListView.ItemSelectionChanged
        LastSelectedItem = e.Item
    End Sub

    Private Sub ChangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeToolStripMenuItem.Click
        With AddTechnisDialog
            .Text = "Редактирование техники"
            Dim CurrentTechnisRow As DataRow = TechnisBDDataSet.Technis.Select("IDTechnis = '" & LastSelectedItem.Text & "'")(0)
            .OldRowId = CurrentTechnisRow("IDTechnis")
            .AddOrChange = True
            .NumberTechTextBox.Text = CurrentTechnisRow("NumberTechnis")
            .AuditrTechComboBox.Text = CurrentTechnisRow.GetParentRow("Auditorium_Technis_FK")("NameAuditorium")
            .AuditrTechComboBox.Items.Clear()
            For Each Row As DataRow In TechnisBDDataSet.Auditorium.Rows
                .AuditrTechComboBox.Items.Add(Row("NameAuditorium"))
            Next
            .StatTechComboBox.Text = CurrentTechnisRow.GetParentRow("StatTechnis_Technis_FK")("NameStat")
            .StatTechComboBox.Items.Clear()
            For Each Row As DataRow In TechnisBDDataSet.StatTechnis
                .StatTechComboBox.Items.Add(Row("NameStat"))
            Next
            .TypeTechComboBox.Text = CurrentTechnisRow.GetParentRow("TypeTechnis_Technis_FK")("NameType")
            .TypeTechComboBox.Items.Clear()
            For Each Row As DataRow In TechnisBDDataSet.TypeTechnis
                .TypeTechComboBox.Items.Add(Row("NameType"))
            Next
            .ModelTechTextBox.Text = CurrentTechnisRow("NameModel")

            .ShowDialog()
            If .DialogResult = DialogResult.OK Then
                FillTechnisList()
            End If
        End With
    End Sub

    Private Sub StatFilterComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StatFilterComboBox.SelectedIndexChanged
        TechnisListView.Items.Clear()
        Dim items(5) As String
        Dim TempRow As DataRow
        For Each Row As DataRow In Me.TechnisBDDataSet.Technis.Rows
            Dim RowFilterStat As DataRow = TechnisBDDataSet.StatTechnis.Select("NameStat = '" & StatFilterComboBox.SelectedItem & "'")(0)
            If Row("IDStat") = RowFilterStat("IDStat") Then
                items(1) = Row(1)
                TempRow = Row.GetParentRow("Auditorium_Technis_FK")
                items(2) = TempRow(1)
                TempRow = Row.GetParentRow("StatTechnis_Technis_FK")
                items(3) = TempRow(1)
                TempRow = Row.GetParentRow("TypeTechnis_Technis_FK")
                items(4) = TempRow(1)
                items(5) = Row(5)
                Dim it As New ListViewItem()
                it.Text = Row(0)
                it.SubItems.AddRange(items)
                TechnisListView.Items.Add(it)
            End If
        Next Row
    End Sub

    Private Sub AuditoriumFilterComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AuditoriumFilterComboBox.SelectedIndexChanged
        TechnisListView.Items.Clear()
        Dim items(5) As String
        Dim TempRow As DataRow

        For Each Row As DataRow In Me.TechnisBDDataSet.Technis.Rows
            Dim RowFilterAuditorium As DataRow = TechnisBDDataSet.Auditorium.Select("NumberAuditorium = '" & AuditoriumFilterComboBox.SelectedItem & "'")(0)
            If Row("IDAuditorium") = RowFilterAuditorium("IDAuditorium") Then
                items(1) = Row(1)
                TempRow = Row.GetParentRow("Auditorium_Technis_FK")
                items(2) = TempRow(1)
                TempRow = Row.GetParentRow("StatTechnis_Technis_FK")
                items(3) = TempRow(1)
                TempRow = Row.GetParentRow("TypeTechnis_Technis_FK")
                items(4) = TempRow(1)
                items(5) = Row(5)
                Dim it As New ListViewItem()
                it.Text = Row(0)
                it.SubItems.AddRange(items)
                TechnisListView.Items.Add(it)
            End If
        Next Row
    End Sub

    Private Sub TypeFilterComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TypeFilterComboBox.SelectedIndexChanged
        TechnisListView.Items.Clear()
        Dim items(5) As String
        Dim TempRow As DataRow

        For Each Row As DataRow In Me.TechnisBDDataSet.Technis.Rows
            Dim RowFilterType As DataRow = TechnisBDDataSet.TypeTechnis.Select("NameType = '" & TypeFilterComboBox.SelectedItem & "'")(0)
            If Row("IDType") = RowFilterType("IDType") Then
                items(1) = Row(1)
                TempRow = Row.GetParentRow("Auditorium_Technis_FK")
                items(2) = TempRow(1)
                TempRow = Row.GetParentRow("StatTechnis_Technis_FK")
                items(3) = TempRow(1)
                TempRow = Row.GetParentRow("TypeTechnis_Technis_FK")
                items(4) = TempRow(1)
                items(5) = Row(5)
                Dim it As New ListViewItem()
                it.Text = Row(0)
                it.SubItems.AddRange(items)
                TechnisListView.Items.Add(it)
            End If
        Next Row
    End Sub

    Private Sub ClearFilterButton_Click(sender As Object, e As EventArgs) Handles ClearFilterButton.Click
        TypeFilterComboBox.Text = " "
        TypeFilterComboBox.Items.Clear()
        AuditoriumFilterComboBox.Text = " "
        AuditoriumFilterComboBox.Items.Clear()
        StatFilterComboBox.Text = " "
        StatFilterComboBox.Items.Clear()
        NumberFilterTextBox.Text = " "
        FillTechnisList()
    End Sub

    Private Sub NumberFilterTextBox_TextChanged(sender As Object, e As EventArgs) Handles NumberFilterTextBox.TextChanged
        TechnisListView.Items.Clear()
        Dim items(5) As String
        Dim TempRow As DataRow
        If NumberFilterTextBox.Text = vbNullChar Then
            NumberFilterTextBox.Text = " "
        End If
        Dim strFindNumber As String = NumberFilterTextBox.Text
        Dim strFindStat As String = StatFilterComboBox.SelectedItem
        For Each Row As DataRow In Me.TechnisBDDataSet.Technis.Select("NumberTechnis Like '*" & strFindNumber & "*'")
            items(1) = Row(1)
            TempRow = Row.GetParentRow("Auditorium_Technis_FK")
            items(2) = TempRow(1)
            TempRow = Row.GetParentRow("StatTechnis_Technis_FK")
            items(3) = TempRow(1)
            TempRow = Row.GetParentRow("TypeTechnis_Technis_FK")
            items(4) = TempRow(1)
            items(5) = Row(5)
            Dim it As New ListViewItem()
            it.Text = Row(0)
            it.SubItems.AddRange(items)
            TechnisListView.Items.Add(it)
        Next Row
    End Sub

    Private Sub TechnisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TechnisToolStripMenuItem.Click
        TechnisDataGridForm.ShowDialog()
    End Sub

    Private Sub AuditoriumToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AuditoriumToolStripMenuItem.Click
        AuditoriumForm.ShowDialog()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub СотрудникиToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WorkersToolStripMenuItem.Click
        Form4.ShowDialog()
    End Sub

    Private Sub ЗаявкиToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЗаявкиToolStripMenuItem.Click
        Form5.ShowDialog()
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles accountingButton.MouseHover
        Dim сolor As Color = Color.FromArgb(46, 125, 59)
        accountingButton.BackColor = сolor
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles accountingButton.MouseLeave
        accountingButton.BackColor = MenuPanel.BackColor
    End Sub
    'Тестовой сообщение, оно должно отобразиться в репозитории
End Class
