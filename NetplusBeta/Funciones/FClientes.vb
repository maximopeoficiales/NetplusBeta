Imports System.Data.SqlClient
Public Class FClientes
    Inherits FConexion 'hereda de Fconexion
    Dim cmd As New SqlCommand

    Public Function FnMostrarUsuarios() As DataTable
        Try
            FnConectado()
            cmd = New SqlCommand("mostrar_usuarios") 'mi procedimiento almacenado ya hecho'
            cmd.CommandType = CommandType.StoredProcedure 'tipo proc almacenado
            cmd.Connection = cnn 'cnn ya tiene la conexion
            'si tiene resultado el comando
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd) 'los resultados se guardan en da
                da.Fill(dt) 'lleno los datos en un datatable
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message) ' si hubiera un error muestralo
            Return Nothing
        Finally 'cuando  todo finalize desconectate de la bd
            FnDesconectado()
        End Try

    End Function
    Public Function FnInsertarUsuarios(ByVal dts As VUsers) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("insertar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@usuario", dts.gusuario)
            cmd.Parameters.AddWithValue("@contrasena", dts.gcontrasena)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            FnDesconectado()
        End Try
    End Function
End Class
