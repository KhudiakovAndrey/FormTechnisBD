﻿

Partial Class TechnisBDDataSet
    Partial Public Class WorkersDataTable
        Private Sub WorkersDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.PatronymicColumn.ColumnName) Then
                'Добавьте здесь пользовательский код
            End If

        End Sub

    End Class
End Class
