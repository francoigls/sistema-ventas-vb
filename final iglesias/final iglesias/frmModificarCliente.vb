Imports System.Data.SqlClient

Public Class frmModificarCliente
    Private Sub FrmModificarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=FINAL;Integrated Security=True")
        Dim cmd As New SqlCommand("SELECT id_cliente, dni FROM clientes", conexion)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)

        cmbClientes.DataSource = dt
        cmbClientes.DisplayMember = "dni"
        cmbClientes.ValueMember = "id_cliente"
    End Sub

    Private Sub cmbClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClientes.SelectedIndexChanged

        If cmbClientes.SelectedValue Is Nothing Then Exit Sub

        Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=FINAL;Integrated Security=True")
        Dim cmd As New SqlCommand("SELECT nombre, apellido, dni, direccion, telefono FROM clientes WHERE id_cliente = @id", conexion)
        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(CType(cmbClientes.SelectedItem, DataRowView)("id_cliente")))


        conexion.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        If dr.Read() Then
            txtNombre.Text = dr("nombre").ToString()
            txtApellido.Text = dr("apellido").ToString()
            txtDni.Text = dr("dni").ToString()
            txtDireccion.Text = dr("direccion").ToString()
            txtTelefono.Text = dr("telefono").ToString()
        End If
        conexion.Close()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtNombre.Text = "" Or txtApellido.Text = "" Or txtDni.Text = "" Or txtDireccion.Text = "" Or txtTelefono.Text = "" Then
            MessageBox.Show("Completá todos los campos.")
            Exit Sub
        End If

        Dim parametros() As SqlParameter = {
            New SqlParameter("@id", cmbClientes.SelectedValue),
            New SqlParameter("@nombre", txtNombre.Text.Trim()),
            New SqlParameter("@apellido", txtApellido.Text.Trim()),
            New SqlParameter("@dni", txtDni.Text.Trim()),
            New SqlParameter("@direccion", txtDireccion.Text.Trim()),
            New SqlParameter("@telefono", txtTelefono.Text.Trim())
        }

        If EjecutarStoredProcedure("sp_ActualizarCliente", parametros) > 0 Then
            MessageBox.Show("Cliente modificado correctamente.")
            DirectCast(Application.OpenForms("FrmClientes"), FrmClientes).cargarClientes()
            Me.Close()
        Else
            MessageBox.Show("No se pudo modificar el cliente.")
        End If
    End Sub
End Class