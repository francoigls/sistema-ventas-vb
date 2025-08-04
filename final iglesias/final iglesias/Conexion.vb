Imports System.Data.SqlClient
Imports System.Windows.Forms

Module conexion


    Private Const CONEXION_STRING As String = "Data Source=.;Initial Catalog=FINAL;Integrated Security=True"



    ' Ejecutar SP sin resultados
    Public Function EjecutarStoredProcedure(nombre As String, parametros As SqlParameter()) As Integer
        Using con As New SqlConnection(CONEXION_STRING)
            Using cmd As New SqlCommand(nombre, con) ' Crea un NUEVO comando usando 'con'.
                cmd.CommandType = CommandType.StoredProcedure

                If parametros IsNot Nothing AndAlso parametros.Length > 0 Then
                    cmd.Parameters.AddRange(parametros)
                End If

                Try
                    con.Open()
                    Return cmd.ExecuteNonQuery()
                Catch ex As SqlClient.SqlException
                    MessageBox.Show("Error de base de datos al ejecutar '" & nombre & "': " & ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return -1
                Catch ex As Exception
                    MessageBox.Show("Ocurrió un error inesperado al ejecutar '" & nombre & "': " & ex.Message, "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return -1
                End Try
            End Using
        End Using
    End Function

    'Ejecutar procedimiento almacenado con tabla tipo
    Public Function EjecutarStoredProcedureConTabla(nombre As String, parametros() As SqlParameter) As Integer

        Using con As New SqlConnection(CONEXION_STRING)
            Using cmd As New SqlCommand(nombre, con)
                cmd.CommandType = CommandType.StoredProcedure


                cmd.Parameters.AddRange(parametros)


                Try
                    con.Open()
                    Return cmd.ExecuteNonQuery()
                Catch ex As SqlClient.SqlException
                    MessageBox.Show("Error de base de datos al ejecutar '" & nombre & "': " & ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return -1
                Catch ex As Exception
                    MessageBox.Show("Ocurrió un error inesperado al ejecutar '" & nombre & "': " & ex.Message, "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return -1
                End Try
            End Using
        End Using
    End Function

    'Ejecutar consulta directa SELECT 
    Public Function EjecutarConsultaDirecta(query As String) As DataTable
        Dim tabla As New DataTable()

        Using con As New SqlConnection(CONEXION_STRING)
            Using adaptador As New SqlDataAdapter(query, con)
                Try
                    con.Open()
                    adaptador.Fill(tabla)
                    Return tabla
                Catch ex As SqlClient.SqlException
                    MessageBox.Show("Error de base de datos al ejecutar consulta: " & ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return Nothing
                Catch ex As Exception
                    MessageBox.Show("Ocurrió un error inesperado al ejecutar consulta: " & ex.Message, "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return Nothing
                End Try
            End Using
        End Using
    End Function
End Module