Imports System.Data.SqlClient

Public Class FrmModificarPrenda
    Public IdPrenda As Integer

    Private Sub FrmModificarPrenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        If txtIdPrenda.Text.Trim() = "" Or txtDescripcion.Text.Trim() = "" Or txtPrecio.Text.Trim() = "" Or txtStock.Text.Trim() = "" Then
            MessageBox.Show("Completá todos los campos.")
            Exit Sub
        End If

        Dim idPrenda As Integer
        If Not Integer.TryParse(txtIdPrenda.Text.Trim(), idPrenda) Then
            MessageBox.Show("El ID debe ser un número entero.")
            Exit Sub
        End If

        Dim descripcion As String = txtDescripcion.Text.Trim()
        Dim precio As Decimal
        Dim stock As Integer
        Dim idMarca As Integer = Convert.ToInt32(cmbMarca.SelectedValue)

        If Not Decimal.TryParse(txtPrecio.Text.Trim(), precio) Then
            MessageBox.Show("Precio inválido.")
            Exit Sub
        End If

        If Not Integer.TryParse(txtStock.Text.Trim(), stock) Then
            MessageBox.Show("Stock inválido.")
            Exit Sub
        End If

        Dim parametros() As SqlParameter = {
            New SqlParameter("@id", idPrenda),
            New SqlParameter("@descripcion", descripcion),
            New SqlParameter("@precio", precio),
            New SqlParameter("@stock", stock),
            New SqlParameter("@id_marca", idMarca)
        }

        If EjecutarStoredProcedure("sp_ActualizarPrenda", parametros) > 0 Then
            MessageBox.Show("Prenda modificada correctamente.")
            DirectCast(Application.OpenForms("FrmPrenda"), FrmPrenda).CargarPrendas()
            Me.Close()
        Else
            MessageBox.Show("No se pudo modificar la prenda.")
        End If
    End Sub
End Class
