Public Class FrmMarcas

    Public Sub cargarMarcas()
        Me.MarcasTableAdapter.Fill(Me.FINALDataSet.marcas)
    End Sub


    Private Sub FrmMarcas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FINALDataSet.marcas' Puede moverla o quitarla según sea necesario.
        Me.MarcasTableAdapter.Fill(Me.FINALDataSet.marcas)

    End Sub

    Private Sub BtnAlta_Click(sender As Object, e As EventArgs) Handles BtnAlta.Click
        FrmAltaMarcas.ShowDialog()
    End Sub

    Private Sub BtnBaja_Click(sender As Object, e As EventArgs) Handles BtnBaja.Click
        FrmBajaMarcas.ShowDialog()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        frmModificarMarcas.ShowDialog()
    End Sub

    Private Sub btnAumento_Click(sender As Object, e As EventArgs) Handles btnAumento.Click
        FrmAumentoMarca.ShowDialog()

    End Sub
End Class