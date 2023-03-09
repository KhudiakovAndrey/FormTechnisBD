Imports System.Windows.Forms

Public Class AddTechnisDialog
    Public AddOrChange As Boolean
    Public OldRowId As ULong
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim Rows() As DataRow
        Dim AuditID, StatID, TypeID As ULong

        Rows = TechnisDataGridForm.TechnisBDDataSet.Auditorium.Select("NameAuditorium = '" & AuditrTechComboBox.Text & "'")
        AuditID = Rows(0)("IDAuditorium")

        Rows = TechnisDataGridForm.TechnisBDDataSet.StatTechnis.Select("NameStat = '" & StatTechComboBox.Text & "'")

        If Rows.Length = 0 Then
            TechnisDataGridForm.StatTechnisTableAdapter.Insert(StatTechComboBox.Text)
            TechnisDataGridForm.StatTechnisTableAdapter.Fill(TechnisDataGridForm.TechnisBDDataSet.StatTechnis)
            Rows = TechnisDataGridForm.TechnisBDDataSet.StatTechnis.Select("NameStat = '" & StatTechComboBox.Text & "'")
            StatID = Rows(0)("IDStat")
        Else
            StatID = Rows(0)("IDStat")
        End If

        Rows = TechnisDataGridForm.TechnisBDDataSet.TypeTechnis.Select("NameType = '" & TypeTechComboBox.Text & "'")

        If Rows.Length = 0 Then
            TechnisDataGridForm.TypeTechnisTableAdapter.Insert(TypeTechComboBox.Text)
            TechnisDataGridForm.TypeTechnisTableAdapter.Fill(TechnisDataGridForm.TechnisBDDataSet.TypeTechnis)
            Rows = TechnisDataGridForm.TechnisBDDataSet.StatTechnis.Select("NameType = '" & TypeTechComboBox.Text & "'")
            TypeID = Rows(0)("IDType")
        Else
            TypeID = Rows(0)("IDType")
        End If

        If AddOrChange = False Then
            TechnisDataGridForm.TechnisTableAdapter.Insert(NumberTechTextBox.Text, AuditID, StatID, TypeID, ModelTechTextBox.Text)
            TechnisDataGridForm.TechnisTableAdapter.Fill(TechnisDataGridForm.TechnisBDDataSet.Technis)
        End If

        If AddOrChange = True Then
            Dim OldTechnisRow As DataRow = TechnisDataGridForm.TechnisBDDataSet.Technis.Select("IDTechnis ='" & OldRowId.ToString & "'")(0)
            TechnisDataGridForm.TechnisTableAdapter.Update(NumberTechTextBox.Text, AuditID, StatID, TypeID, ModelTechTextBox.Text, OldTechnisRow(0), OldTechnisRow(1), OldTechnisRow(2), OldTechnisRow(3), OldTechnisRow(4), OldTechnisRow(5))
        End If

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


End Class
