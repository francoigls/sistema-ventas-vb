Imports System.Data.SqlClient

Public Class FrmBajaclientes
    Private Sub FrmBajaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=FINAL;Integrated Security=True")
        Dim cmd As New SqlCommand("SELECT id_cliente, dni FROM clientes", conexion)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)

        cmbClientes.DataSource = dt
        cmbClientes.DisplayMember = "dni"
        cmbClientes.ValueMember = "id_cliente"
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If cmbClientes.SelectedValue Is Nothing Then
            MessageBox.Show("Seleccioná un cliente.")
            Exit Sub
        End If

        Dim parametros() As SqlParameter = {
            New SqlParameter("@id", cmbClientes.SelectedValue)
        }

        If EjecutarStoredProcedure("sp_EliminarCliente", parametros) > 0 Then
            MessageBox.Show("Cliente eliminado correctamente.")
            DirectCast(Application.OpenForms("FrmClientes"), FrmClientes).cargarClientes()
            Me.Close()
        Else
            MessageBox.Show("No se pudo eliminar el cliente. ¿Tiene ventas asociadas?")
        End If
    End Sub
End Class