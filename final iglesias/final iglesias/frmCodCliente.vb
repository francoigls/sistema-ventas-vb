Imports Microsoft.Reporting.WinForms

Public Class frmCodCliente
    Private Sub frmCodCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnGenerarReporte_Click(sender As Object, e As EventArgs) Handles btnGenerarReporte.Click
        Try
            Dim idCliente As Integer

            If Integer.TryParse(txtIdCliente.Text, idCliente) Then
                Me.ReportViewer1.LocalReport.DataSources.Clear()


                Dim ventasClienteTA As New FINALDataSetTableAdapters.SP_MostrarVentasPorClienteTableAdapter()
                Dim dtVentas As New FINALDataSet.SP_MostrarVentasPorClienteDataTable()

                ventasClienteTA.Fill(dtVentas, idCliente)

                Dim rds As New ReportDataSource("DataSetVentasClientes", CType(dtVentas, System.Data.DataTable))

                Me.ReportViewer1.LocalReport.DataSources.Add(rds)
                Me.ReportViewer1.RefreshReport()
            Else
                MessageBox.Show("Por favor, ingrese un ID de cliente válido (número entero).", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al generar el reporte: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class