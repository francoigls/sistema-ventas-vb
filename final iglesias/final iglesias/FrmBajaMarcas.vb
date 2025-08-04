Imports System.Data.SqlClient

Public Class FrmBajaMarcas
    Private Sub FrmBajaMarca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=FINAL;Integrated Security=True")
        Dim cmd As New SqlCommand("SELECT id_marca, nombre_marca FROM marcas", conexion)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)

        cmbMarca.DataSource = dt
        cmbMarca.DisplayMember = "nombre_marca"
        cmbMarca.ValueMember = "id_marca"
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If cmbMarca.SelectedValue Is Nothing Then
            MessageBox.Show("Seleccioná una marca.")
            Exit Sub
        End If

        Dim id As Integer = Convert.ToInt32(cmbMarca.SelectedValue)

        Dim parametros() As SqlParameter = {
            New SqlParameter("@id", id)
        }

        If EjecutarStoredProcedure("sp_EliminarMarca", parametros) > 0 Then
            MessageBox.Show("Marca eliminada correctamente.")
            DirectCast(Application.OpenForms("FrmMarcas"), FrmMarcas).cargarMarcas()
            Me.Close()
        Else
            MessageBox.Show("No se pudo eliminar la marca.")
        End If
    End Sub
End Class