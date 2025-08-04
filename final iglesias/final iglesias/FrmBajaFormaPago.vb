Imports System.Data.SqlClient

Public Class FrmBajaFormaPago
    Private Sub FrmBajaFormaPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=FINAL;Integrated Security=True")
        Dim cmd As New SqlCommand("SELECT id_forma_pago, descripcion FROM formaspago", conexion)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)

        cmbFormaPago.DataSource = dt
        cmbFormaPago.DisplayMember = "descripcion"
        cmbFormaPago.ValueMember = "id_forma_pago"
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If cmbFormaPago.SelectedValue Is Nothing Then
            MessageBox.Show("Seleccioná una forma de pago.")
            Exit Sub
        End If

        Dim parametros() As SqlParameter = {
            New SqlParameter("@id", cmbFormaPago.SelectedValue)
        }

        If EjecutarStoredProcedure("sp_EliminarFormaPago", parametros) > 0 Then
            MessageBox.Show("Forma de pago eliminada.")
            DirectCast(Application.OpenForms("FrmFormaPagos"), FrmFormaPagos).cargarDescripcion()
            Me.Close()
        Else
            MessageBox.Show("No se pudo eliminar.")
        End If
    End Sub
End Class

