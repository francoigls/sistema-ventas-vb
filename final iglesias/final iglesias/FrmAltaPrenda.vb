Imports System.Data.SqlClient

Public Class FrmAltaPrenda

    Private Sub FrmAltaPrenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar marcas en ComboBox
        Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=FINAL;Integrated Security=True")
        Dim cmd As New SqlCommand("SELECT id_marca, nombre_marca FROM marcas", conexion)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)

        cmbMarca.DataSource = dt
        cmbMarca.DisplayMember = "nombre_marca"
        cmbMarca.ValueMember = "id_marca"
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtDescripcion.Text.Trim() = "" Or txtPrecio.Text.Trim() = "" Or txtStock.Text.Trim() = "" Then
            MessageBox.Show("Por favor completá todos los campos.")
            Exit Sub
        End If

        Dim descripcion As String = txtDescripcion.Text.Trim()
        Dim precio As Decimal
        Dim stock As Integer
        Dim idMarca As Integer = Convert.ToInt32(cmbMarca.SelectedValue)

        If Not Decimal.TryParse(txtPrecio.Text, precio) OrElse precio < 0 Then
            MessageBox.Show("Precio inválido.")
            Exit Sub
        End If

        If Not Integer.TryParse(txtStock.Text, stock) OrElse stock < 0 Then
            MessageBox.Show("Stock inválido.")
            Exit Sub
        End If

        Dim parametros() As SqlParameter = {
            New SqlParameter("@descripcion", descripcion),
            New SqlParameter("@precio", precio),
            New SqlParameter("@stock", stock),
            New SqlParameter("@id_marca", idMarca)
        }

        If EjecutarStoredProcedure("sp_InsertarPrenda", parametros) > 0 Then
            MessageBox.Show("Prenda guardada correctamente.")
            DirectCast(Application.OpenForms("FrmPrenda"), FrmPrenda).CargarPrendas()
            Me.Close()
        Else
            MessageBox.Show("No se pudo guardar la prenda.")
        End If
    End Sub
End Class