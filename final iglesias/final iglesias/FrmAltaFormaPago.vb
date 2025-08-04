Imports System.Data.SqlClient

Public Class FrmAltaFormaPago
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If TxtDescripcion.Text.Trim() = "" Then
            MessageBox.Show("Por favor completá el campo Descripción.")
            Exit Sub
        End If

        Dim parametros() As SqlParameter = {
            New SqlParameter("@descripcion", TxtDescripcion.Text.Trim())
        }

        If EjecutarStoredProcedure("sp_InsertarFormaPago", parametros) > 0 Then
            MessageBox.Show("Forma de pago guardada correctamente.")
            DirectCast(Application.OpenForms("FrmFormaPagos"), FrmFormaPagos).cargarDescripcion()
            Me.Close()
        Else
            MessageBox.Show("No se pudo guardar la forma de pago.")
        End If
    End Sub

    Private Sub FrmAltaFormaPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
