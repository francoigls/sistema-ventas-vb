Imports System.Data.SqlClient

Public Class FrmEliminarVentas


    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtbajaventa.Text.Trim() = "" Then
            MessageBox.Show("Por favor ingresá el ID de la prenda a eliminar.")
            Exit Sub
        End If

        Dim id As Integer
        If Not Integer.TryParse(txtbajaventa.Text, id) Then
            MessageBox.Show("ID inválido.")
            Exit Sub
        End If

        Dim parametros() As SqlParameter = {
            New SqlParameter("@id_venta", id)
        }

        If EjecutarStoredProcedure("sp_EliminarVenta", parametros) > 0 Then
            MessageBox.Show("Venta eliminada correctamente.")
            DirectCast(Application.OpenForms("FrmVentas"), FrmVentas).cargarVentas()

            txtbajaventa.Clear()
        Else
            MessageBox.Show("No se pudo eliminar la venta.")
        End If
    End Sub

    Private Sub FrmEliminarVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class