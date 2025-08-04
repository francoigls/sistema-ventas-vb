Imports System.Data.SqlClient

Public Class FrmAumentoMarca
    Private Sub FrmAumentoPrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dtMarcas As DataTable = EjecutarConsultaDirecta("SELECT id_marca, nombre_marca FROM marcas")
        cmbMarca.DataSource = dtMarcas
        cmbMarca.DisplayMember = "nombre_marca"
        cmbMarca.ValueMember = "id_marca"
    End Sub

    Private Sub btnAplicar_Click(sender As Object, e As EventArgs) Handles btnAplicar.Click

        If cmbMarca.SelectedValue Is Nothing OrElse txtPorcentaje.Text.Trim() = "" Then
            MessageBox.Show("Completá todos los campos.")
            Exit Sub
        End If

        Dim porcentaje As Decimal
        If Not Decimal.TryParse(txtPorcentaje.Text.Trim(), porcentaje) OrElse porcentaje <= 0 Then
            MessageBox.Show("Ingresá un porcentaje válido (mayor a 0).")
            Exit Sub
        End If


        Dim parametros() As SqlParameter = {
            New SqlParameter("@id_marca", cmbMarca.SelectedValue),
            New SqlParameter("@porcentaje", porcentaje)
        }

        If EjecutarStoredProcedure("sp_AumentarPreciosPorMarca", parametros) > 0 Then
            MessageBox.Show("Precios actualizados correctamente.")
            txtPorcentaje.Clear()
        Else
            MessageBox.Show("Error al actualizar precios.")
        End If
    End Sub
End Class