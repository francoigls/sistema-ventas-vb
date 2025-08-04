Partial Class FINALDataSet
    Partial Public Class sp_ReporteVentasPorPrendaYRangoDataTable
        Private Sub sp_ReporteVentasPorPrendaYRangoDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.id_ventaColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class
End Class

Namespace FINALDataSetTableAdapters
    Partial Public Class sp_ReporteVentasPorFechaTableAdapter
    End Class

    Partial Public Class sp_ReporteVentasPorPrendaYRangoTableAdapter
    End Class
End Namespace
