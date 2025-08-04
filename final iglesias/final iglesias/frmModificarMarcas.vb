Imports System.Data.SqlClient

Public Class frmModificarMarcas
    Private Sub FrmModificarMarca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=FINAL;Integrated Security=True")
        Dim cmd As New SqlCommand("SELECT id_marca, nombre_marca FROM marcas", conexion)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)

        cmbMarca.DataSource = dt
        cmbMarca.DisplayMember = "nombre_marca"
        cmbMarca.ValueMember = "id_marca"
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If cmbMarca.SelectedValue Is Nothing Or txtMarcaNueva.Text.Trim() = "" Then
            MessageBox.Show("Seleccioná una marca y escribí la nueva descripción.")
            Exit Sub
        End If

        Dim id As Integer = Convert.ToInt32(cmbMarca.SelectedValue)
        Dim nueva As String = txtMarcaNueva.Text.Trim()

        Dim parametros() As SqlParameter = {
            New SqlParameter("@id", id),
            New SqlParameter("@nombre", nueva)
        }

        If EjecutarStoredProcedure("sp_ActualizarMarca", parametros) > 0 Then
            MessageBox.Show("Marca modificada correctamente.")
            DirectCast(Application.OpenForms("FrmMarcas"), FrmMarcas).cargarMarcas()
            Me.Close()
        Else
            MessageBox.Show("No se pudo modificar la marca.")
        End If
    End Sub
End Class