Imports System.Data.SqlClient

Public Class FrmNuevaVenta
    Dim tablaDetalle As New DataTable()

    Private Sub FrmNuevaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dim clientes As DataTable = EjecutarConsultaDirecta("SELECT id_cliente, apellido + ', ' + nombre AS nombre FROM clientes")
        cmbCliente.DataSource = clientes
        cmbCliente.DisplayMember = "nombre"
        cmbCliente.ValueMember = "id_cliente"


        Dim formasPago As DataTable = EjecutarConsultaDirecta("SELECT id_forma_pago, descripcion FROM formaspago")
        cmbFormaPago.DataSource = formasPago
        cmbFormaPago.DisplayMember = "descripcion"
        cmbFormaPago.ValueMember = "id_forma_pago"


        tablaDetalle.Columns.Add("id_prenda", GetType(Integer))
        tablaDetalle.Columns.Add("descripcion", GetType(String))
        tablaDetalle.Columns.Add("cantidad", GetType(Integer))
        tablaDetalle.Columns.Add("precio_unitario", GetType(Decimal))
        tablaDetalle.Columns.Add("subtotal", GetType(Decimal))

        dgvDetalle.DataSource = tablaDetalle
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim formAgregar As New FrmAgregarProductoVenta()

        If formAgregar.ShowDialog() = DialogResult.OK Then

            Dim fila As DataRow = tablaDetalle.NewRow()
            fila("id_prenda") = formAgregar.idPrenda

            fila("cantidad") = formAgregar.cantidad
            fila("precio_unitario") = formAgregar.precio
            fila("subtotal") = formAgregar.cantidad * formAgregar.precio

            tablaDetalle.Rows.Add(fila)
            CalcularTotal()
        End If
    End Sub

    Private Sub CalcularTotal()
        Dim total As Decimal = 0
        For Each row As DataRow In tablaDetalle.Rows
            total += Convert.ToDecimal(row("subtotal"))
        Next


        txtTotal.Text = total.ToString("N2")

    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click

        If tablaDetalle.Rows.Count = 0 Then
            MessageBox.Show("Debe agregar al menos una prenda.")
            Exit Sub
        End If


        Dim detalleVenta As New DataTable("DETALLE_VENTA")
        detalleVenta.Columns.Add("id_prenda", GetType(Integer))
        detalleVenta.Columns.Add("cantidad", GetType(Integer))
        detalleVenta.Columns.Add("precio_unitario", GetType(Decimal))

        For Each row As DataRow In tablaDetalle.Rows
            detalleVenta.Rows.Add(row("id_prenda"), row("cantidad"), row("precio_unitario"))
        Next


        Dim paramFecha As New SqlParameter("@fecha", SqlDbType.DateTime)
        paramFecha.Value = DateTime.Now

        Dim paramCliente As New SqlParameter("@id_cliente", SqlDbType.Int)
        paramCliente.Value = cmbCliente.SelectedValue

        Dim paramFormaPago As New SqlParameter("@id_forma_pago", SqlDbType.Int)
        paramFormaPago.Value = cmbFormaPago.SelectedValue

        Dim paramDetalle As New SqlParameter("@detalle", SqlDbType.Structured)
        paramDetalle.TypeName = "dbo.DETALLE_VENTA"
        paramDetalle.Value = detalleVenta

        Dim parametros() As SqlParameter = {paramFecha, paramCliente, paramFormaPago, paramDetalle}


        Dim resultado As Integer = EjecutarStoredProcedureConTabla("sp_RegistrarVentaCompleta", parametros)

        If resultado > 0 Then
            MessageBox.Show("Venta registrada correctamente.")
            DirectCast(Application.OpenForms("FrmVentas"), FrmVentas).cargarVentas()
            Me.Close()
        Else
            MessageBox.Show("Error al registrar la venta.")
        End If


    End Sub

    Private Sub dgvDetalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalle.CellContentClick

    End Sub
End Class