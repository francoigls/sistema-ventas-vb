Imports System.Data.SqlClient

Public Class FrmBajaPrenda
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtbajaprenda.Text.Trim() = "" Then
            MessageBox.Show("Por favor ingresá el ID de la prenda a eliminar.")
            Exit Sub
        End If

        Dim id As Integer
        If Not Integer.TryParse(txtbajaprenda.Text, id) Then
            MessageBox.Show("ID inválido.")
            Exit Sub
        End If

        Dim parametros() As SqlParameter = {
            New SqlParameter("@id", id)
        }

        If EjecutarStoredProcedure("sp_EliminarPrenda", parametros) > 0 Then
            MessageBox.Show("Prenda eliminada correctamente.")
            DirectCast(Application.OpenForms("FrmPrenda"), FrmPrenda).CargarPrendas()
            txtbajaprenda.Clear()
        Else
            MessageBox.Show("No se pudo eliminar la prenda.")
        End If
    End Sub

    Private Sub FrmBajaPrenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ds_Click(sender As Object, e As EventArgs) Handles ds.Click

    End Sub

    Private Sub txtbajaprenda_TextChanged(sender As Object, e As EventArgs) Handles txtbajaprenda.TextChanged

    End Sub
End Class