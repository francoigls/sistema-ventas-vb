Public Class FrmMain
    Private Sub BtnPrenda_Click(sender As Object, e As EventArgs) Handles BtnPrenda.Click
        FrmPrenda.ShowDialog()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCliente.Click
        FrmClientes.ShowDialog()

    End Sub

    Private Sub BtnFormasPago_Click(sender As Object, e As EventArgs) Handles BtnFormasPago.Click
        FrmFormaPagos.ShowDialog()



    End Sub

    Private Sub BtnMarcas_Click(sender As Object, e As EventArgs) Handles BtnMarcas.Click
        FrmMarcas.ShowDialog()

    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ventas_Click(sender As Object, e As EventArgs) Handles ventas.Click
        FrmVentas.ShowDialog()
    End Sub

    Private Sub btnInformes_Click(sender As Object, e As EventArgs) Handles btnInformes.Click
        frmInformes.ShowDialog()
    End Sub
End Class