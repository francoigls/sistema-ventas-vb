﻿Public Class frmImprimirListaPrecios
    Private Sub frmImprimirListaPrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FINALDataSet.sp_ReporteListaPrecios' Puede moverla o quitarla según sea necesario.
        Me.Sp_ReporteListaPreciosTableAdapter.Fill(Me.FINALDataSet.sp_ReporteListaPrecios)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class