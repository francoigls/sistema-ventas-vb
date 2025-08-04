Imports System.Data.SqlClient

Public Class Frmlogin
    Dim conexion As New SqlConnection
    Dim comando As New SqlCommand

    Private Sub Frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SqlConnection("Data Source=DESKTOP-FQPF55N;Initial Catalog=FINAL;Integrated Security=True")


        Try
            conexion.Open()
            MessageBox.Show("Conexión exitosa.")
            conexion.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        conexion.Open()

        Dim consulta As String = "select * from usuarios where nombre_usuario='" & TxtUsuario.Text & "' and psw= '" & TxtPsw.Text & "' "

        comando = New SqlCommand(consulta, conexion)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        If lector.HasRows Then
            FrmMain.ShowDialog()

        Else
            MessageBox.Show("usuario o psw invalido")

        End If
        conexion.Close()

    End Sub

    Private Sub TxtPsw_TextChanged(sender As Object, e As EventArgs) Handles TxtPsw.TextChanged

    End Sub
End Class
