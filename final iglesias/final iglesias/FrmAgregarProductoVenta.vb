Imports System.Data.SqlClient

Public Class FrmAgregarProductoVenta




    ' Propiedades públicas para devolver los datos
    Public Property idPrenda As Integer
    Public Property descripcion As String
    Public Property cantidad As Integer
    Public Property precio As Decimal

    Private Sub FrmAgregarProductoVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar las prendas desde la base de datos
        Dim dt As DataTable = EjecutarConsultaDirecta("SELECT id_prenda, descripcion FROM prendas")
        cmbPrenda.DataSource = dt
        cmbPrenda.DisplayMember = "descripcion"
        cmbPrenda.ValueMember = "id_prenda"
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        If cmbPrenda.SelectedIndex = -1 OrElse txtCantidad.Text = "" Then
            MessageBox.Show("Completá todos los campos.")
            Exit Sub
        End If

        Dim cantidadTemp As Integer
        If Not Integer.TryParse(txtCantidad.Text, cantidadTemp) OrElse cantidadTemp <= 0 Then
            MessageBox.Show("La cantidad debe ser un número entero mayor que 0.")
            Exit Sub
        End If


        idPrenda = cmbPrenda.SelectedValue
        descripcion = cmbPrenda.Text
        cantidad = cantidadTemp
        precio = ObtenerPrecio(idPrenda)


        Me.DialogResult = DialogResult.OK
        Me.Close()


    End Sub


    Private Function ObtenerPrecio(idPrenda As Integer) As Decimal
        Dim dt As DataTable = EjecutarConsultaDirecta("SELECT precio FROM prendas WHERE id_prenda = " & idPrenda)
        If dt.Rows.Count > 0 Then
            Return Convert.ToDecimal(dt.Rows(0)("precio"))
        Else
            Return 0
        End If
    End Function

    Private Function ObtenerStock(idPrenda As Integer) As Integer

        Dim dt As DataTable = EjecutarConsultaDirecta("SELECT stock FROM prendas WHERE id_prenda = " & idPrenda)
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            Return Convert.ToInt32(dt.Rows(0)("stock"))
        Else
            MessageBox.Show("No se pudo obtener el stock de la prenda seleccionada.", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End If
    End Function


End Class