Imports System.Data.SqlClient

Public Class FrmModificarVentas

    Private Sub FrmModificarVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
    End Sub

    Private Sub CargarCombos()

        Dim dtVentas As DataTable = EjecutarConsultaDirecta("SELECT id_venta FROM ventas")
        cmbVentas.DataSource = dtVentas
        cmbVentas.DisplayMember = "id_venta"
        cmbVentas.ValueMember = "id_venta"


        Dim dtClientes As DataTable = EjecutarConsultaDirecta("SELECT id_cliente, dni FROM clientes")
        cmbClientes.DataSource = dtClientes
        cmbClientes.DisplayMember = "dni"
        cmbClientes.ValueMember = "id_cliente"


        Dim dtFormas As DataTable = EjecutarConsultaDirecta("SELECT id_forma_pago, descripcion FROM formaspago")
        cmbFormasPago.DataSource = dtFormas
        cmbFormasPago.DisplayMember = "descripcion"
        cmbFormasPago.ValueMember = "id_forma_pago"
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If cmbVentas.SelectedValue Is Nothing Or cmbClientes.SelectedValue Is Nothing Or cmbFormasPago.SelectedValue Is Nothing Then
            MessageBox.Show("Faltan datos.")
            Exit Sub
        End If

        Dim parametros() As SqlParameter = {
            New SqlParameter("@id_venta", cmbVentas.SelectedValue),
            New SqlParameter("@id_cliente", cmbClientes.SelectedValue),
            New SqlParameter("@id_forma_pago", cmbFormasPago.SelectedValue)
        }

        If EjecutarStoredProcedure("sp_ModificarVentaCabecera", parametros) > 0 Then
            MessageBox.Show("Venta modificada correctamente.")
            Me.Close()
        Else
            MessageBox.Show("Error al modificar la venta.")
        End If
    End Sub
End Class