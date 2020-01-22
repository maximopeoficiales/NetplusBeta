Imports System.Data.SqlClient
Public Class FClientes
    Inherits FConexion
    Dim cmd As New SqlCommand

    Public Function FnMostrarClientes() As DataTable
        Try
            FnConectado()
            cmd = New SqlCommand("mostrar_clientes", cnn) 'mi procedimiento almacenado ya hecho'
            cmd.CommandType = CommandType.StoredProcedure 'tipo proc almacenado
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

    Public Function FnInsertarCliente(ByVal dts As LClientes) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("insertar_cliente", cnn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@id_cliente", dts.gid_cliente)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@direccion", dts.gdireccion)
            cmd.Parameters.AddWithValue("@celular", dts.gcelular)
            cmd.Parameters.AddWithValue("@email", dts.gemail)
            cmd.Parameters.AddWithValue("@zona", dts.gzona)

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

    Public Function FnActualizarCliente(ByVal dts As LClientes) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("actualizar_cliente", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id_cliente", dts.gid_cliente)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@direccion", dts.gdireccion)
            cmd.Parameters.AddWithValue("@celular", dts.gcelular)
            cmd.Parameters.AddWithValue("@email", dts.gemail)
            cmd.Parameters.AddWithValue("@zona", dts.gzona)
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
    Public Function FnEliminarCliente(ByVal dts As LClientes) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("eliminar_empleado")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_cliente", dts.gid_cliente)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("No se puede borrar esta relacionado")
            Return False
        Finally
            FnDesconectado()
        End Try
    End Function

    Public Function FnBuscarClientePordni(dts As LClientes) As DataTable
        Try
            FnConectado()
            cmd = New SqlCommand("BuscarClientePorDni", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id_cliente", dts.gid_cliente)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd) 'los resultados se guardan en da
                da.Fill(dt) 'lleno los datos en un datatable
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            FnDesconectado()
        End Try
    End Function

    Public Function ContarClientes() As String
        Try
            FnConectado()
            cmd = New SqlCommand("ClientesActivos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            Dim contador = cmd.ExecuteScalar().ToString
            If cmd.ExecuteNonQuery Then
                Return contador
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            FnDesconectado()
        End Try
    End Function
End Class
