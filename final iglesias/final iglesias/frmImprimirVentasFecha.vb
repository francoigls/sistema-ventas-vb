Imports Microsoft.Reporting.WinForms

Public Class frmImprimirVentasFecha
    Private Sub frmImprimirVentasFecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Try

            ReportViewer1.LocalReport.DataSources.Clear()


            Dim adaptador As New FINALDataSetTableAdapters.sp_ReporteVentasPorFechaTableAdapter()


            Dim tabla As New FINALDataSet.sp_ReporteVentasPorFechaDataTable()
            adaptador.Fill(tabla, dtpDesde.Value.Date, dtpHasta.Value.Date)


            Dim fuente As New ReportDataSource("DataSetVentasFecha", CType(tabla, DataTable))


            ReportViewer1.LocalReport.ReportPath = "rptVentasPorFecha.rdlc"


            ReportViewer1.LocalReport.DataSources.Add(fuente)
            ReportViewer1.RefreshReport()

        Catch ex As Exception
            MessageBox.Show("Error al generar el reporte: " & ex.Message)
        End Try
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class