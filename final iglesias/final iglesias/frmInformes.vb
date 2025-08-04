Public Class frmInformes
    Private Sub btnListaPrecio_Click(sender As Object, e As EventArgs) Handles btnListaPrecio.Click
        frmImprimirListaPrecios.ShowDialog()
    End Sub

    Private Sub btnVentasFecha_Click(sender As Object, e As EventArgs) Handles btnVentasFecha.Click
        frmImprimirVentasFecha.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmImprimirPrendaRango.ShowDialog()
    End Sub

    Private Sub btnCodCliente_Click(sender As Object, e As EventArgs) Handles btnCodCliente.Click
        frmCodCliente.ShowDialog()

    End Sub

    Private Sub frmInformes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class