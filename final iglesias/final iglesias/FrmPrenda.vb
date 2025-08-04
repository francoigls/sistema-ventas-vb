Public Class FrmPrenda

    Public Sub CargarPrendas()
        Me.PrendasTableAdapter.Fill(Me.FINALDataSet.prendas)
    End Sub

    Private Sub FrmPrenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarPrendas()
    End Sub

    Private Sub BtnAlta_Click(sender As Object, e As EventArgs) Handles BtnAlta.Click
        frmAltaPrenda.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub BtnBaja_Click(sender As Object, e As EventArgs) Handles BtnBaja.Click
        frmBajaPrenda.ShowDialog()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        FrmModificarPrenda.ShowDialog()
    End Sub
End Class
