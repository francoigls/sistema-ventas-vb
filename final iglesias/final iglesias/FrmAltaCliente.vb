Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.Devices

Public Class FrmAltaCliente


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtNombre.Text = "" Or txtApellido.Text = "" Or txtDni.Text = "" Or txtDireccion.Text = "" Or TxtTelefono.Text = "" Then
            MessageBox.Show("Completá todos los campos.")
            Exit Sub
        End If

        Dim parametros() As SqlParameter = {
            New SqlParameter("@nombre", txtNombre.Text.Trim()),
            New SqlParameter("@apellido", txtApellido.Text.Trim()),
            New SqlParameter("@dni", txtDni.Text.Trim()),
            New SqlParameter("@direccion", txtDireccion.Text.Trim()),
            New SqlParameter("@telefono", TxtTelefono.Text.Trim())
        }

        If EjecutarStoredProcedure("sp_InsertarCliente", parametros) > 0 Then
            MessageBox.Show("Cliente agregado correctamente.")
            DirectCast(Application.OpenForms("FrmClientes"), FrmClientes).cargarClientes()
            Me.Close()
        Else
            MessageBox.Show("No se pudo agregar el cliente.")
        End If
    End Sub

    Private Sub FrmAltaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class