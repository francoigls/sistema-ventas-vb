Public Class FrmVentas


    Private Sub BtnAlta_Click(sender As Object, e As EventArgs) Handles BtnAlta.Click
        Dim frm As New FrmNuevaVenta()
        frm.ShowDialog()
        cargarVentas()
    End Sub




    Public Sub cargarVentas()
        Me.Sp_ListarVentasConDatosTableAdapter.Fill(Me.FINALDataSet.sp_ListarVentasConDatos)
    End Sub

    Private Sub FrmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FINALDataSet.sp_ListarVentasConDatos' Puede moverla o quitarla según sea necesario.
        Me.Sp_ListarVentasConDatosTableAdapter.Fill(Me.FINALDataSet.sp_ListarVentasConDatos)
        cargarVentas()
    End Sub

    Private Sub BtnBaja_Click(sender As Object, e As EventArgs) Handles BtnBaja.Click
        FrmEliminarVentas.Show()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        FrmModificarVentas.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class