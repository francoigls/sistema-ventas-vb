Imports System.Data.SqlClient

Public Class FrmAltaMarcas


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If TxtMarca.Text.Trim() = "" Then
            MessageBox.Show("Por favor completá el nombre de la marca.")
            Exit Sub
        End If

        Dim parametros() As SqlParameter = {
            New SqlParameter("@nombre", TxtMarca.Text.Trim())
        }

        If EjecutarStoredProcedure("sp_InsertarMarca", parametros) > 0 Then
            MessageBox.Show("Marca guardada correctamente.")
            DirectCast(Application.OpenForms("FrmMarcas"), FrmMarcas).cargarMarcas()
            Me.Close()
        Else
            MessageBox.Show("No se pudo guardar la marca.")
        End If
    End Sub

    Private Sub FrmAltaMarcas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class