Public Class FrmFormaPagos
    Public Sub cargarDescripcion()
        Me.FormaspagoTableAdapter.Fill(Me.FINALDataSet.formaspago)
    End Sub



    Private Sub FrmFormaPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.FormaspagoTableAdapter.Fill(Me.FINALDataSet.formaspago)

    End Sub

    Private Sub BtnAlta_Click(sender As Object, e As EventArgs) Handles BtnAlta.Click
        FrmAltaFormaPago.ShowDialog()


    End Sub

    Private Sub BtnBaja_Click(sender As Object, e As EventArgs) Handles BtnBaja.Click
        FrmBajaFormaPago.ShowDialog()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        FrmModificarFormaPago.ShowDialog()
    End Sub
End Class