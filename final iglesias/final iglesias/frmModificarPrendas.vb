Imports System.Data.SqlClient

Public Class FrmModificarMarca

    ' Variable pública para recibir el ID de la marca
    Public IdMarca As Integer

    Private Sub FrmModificarMarca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Nada por ahora, si querés agregar algo como foco al textbox podés
        txtNombreMarca.Focus()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtNombreMarca.Text.Trim() = "" Then
            MessageBox.Show("Por favor ingresá el nuevo nombre de la marca.")
            Exit Sub
        End If

        Dim nombre As String = txtNombreMarca.Text.Trim()

        Dim parametros() As SqlParameter = {
            New SqlParameter("@id", IdMarca),
            New SqlParameter("@nombre", nombre)
        }

        If EjecutarStoredProcedure("sp_ActualizarMarca", parametros) > 0 Then
            MessageBox.Show("Marca modificada correctamente.")
            DirectCast(Application.OpenForms("FrmMarcas"), FrmMarcas).cargarMarcas()
            Me.Close()
        Else
            MessageBox.Show("No se pudo modificar la marca.")
        End If
    End Sub
End Class
