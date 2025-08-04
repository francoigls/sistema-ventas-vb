Imports System.Data.SqlClient

Public Class FrmModificarFormaPago

    Private Sub FrmModificarFormaPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=FINAL;Integrated Security=True")
        Dim cmd As New SqlCommand("SELECT id_forma_pago, descripcion FROM formaspago", conexion)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)

        cmbFormaPago.DataSource = dt
        cmbFormaPago.DisplayMember = "descripcion"
        cmbFormaPago.ValueMember = "id_forma_pago"
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If cmbFormaPago.SelectedValue Is Nothing Or txtDescripcion.Text.Trim() = "" Then
            MessageBox.Show("Seleccioná una forma de pago y escribí la nueva descripción.")
            Exit Sub
        End If

        Dim id As Integer = Convert.ToInt32(cmbFormaPago.SelectedValue)
        Dim nuevaDescripcion As String = txtDescripcion.Text.Trim()

        Dim parametros() As SqlParameter = {
            New SqlParameter("@id", id),
            New SqlParameter("@descripcion", nuevaDescripcion)
        }

        If EjecutarStoredProcedure("sp_ActualizarFormaPago", parametros) > 0 Then
            MessageBox.Show("Forma de pago modificada correctamente.")
            DirectCast(Application.OpenForms("FrmFormaPagos"), FrmFormaPagos).cargarDescripcion()
            Me.Close()
        Else
            MessageBox.Show("No se pudo modificar la forma de pago.")
        End If
    End Sub
End Class
