Imports Microsoft.Reporting.WinForms

Public Class frmImprimirPrendaRango


    Private Sub frmImprimirPrendaRango_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FINALDataSet.sp_ReporteVentasPorPrendaYRango' Puede moverla o quitarla según sea necesario.


        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim codigoPrenda As String = txtCodigoPrenda.Text.Trim()
        Dim fechaDesde As Date = dtpDesde.Value.Date
        Dim fechaHasta As Date = dtpHasta.Value.Date


        If codigoPrenda = "" Then
            MessageBox.Show("Por favor, ingrese el código de la prenda.")
            Exit Sub
        End If

        Try

            ReportViewer1.LocalReport.DataSources.Clear()


            Dim adaptador As New FINALDataSetTableAdapters.sp_ReporteVentasPorPrendaYRangoTableAdapter()


            Dim tabla As New FINALDataSet.sp_ReporteVentasPorPrendaYRangoDataTable()


            adaptador.Fill(tabla, txtCodigoPrenda.Text, dtpDesde.Value.Date, dtpHasta.Value.Date)


            Dim fuente As New ReportDataSource("DataSetVentasPrendasRango", CType(tabla, DataTable))


            ReportViewer1.LocalReport.ReportPath = Application.StartupPath & "\rptVentasPrendaFecha.rdlc"




            ReportViewer1.LocalReport.DataSources.Add(fuente)
            ReportViewer1.RefreshReport()

        Catch ex As Exception
            MessageBox.Show("Error al generar el reporte: " & ex.Message)
        End Try
    End Sub

End Class