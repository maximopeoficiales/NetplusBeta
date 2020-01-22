Imports System.Data.SqlClient
Public Class FContratos
    Inherits FConexion
    Dim cmd As New SqlCommand

    Public Function FnMostrarContratos() As DataTable
        Try
            FnConectado()
            cmd = New SqlCommand("mostrar_cliente_servicio", cnn) 'mi procedimiento almacenado ya hecho'
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

    Public Function FnInsertarContrato(ByVal dts As LCliente_Servicio) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("insertar_cliente_servicio", cnn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@fecha_instalacion", dts.gfecha_instalacion)
            cmd.Parameters.AddWithValue("@pago_instalacion", dts.gpago_instalacion)
            cmd.Parameters.AddWithValue("@estado_contrato", dts.gestado_contrato)
            cmd.Parameters.AddWithValue("@id_cliente", dts.gid_cliente)
            cmd.Parameters.AddWithValue("@id_servicio", dts.gid_servicio)
            cmd.Parameters.AddWithValue("@cod_empleado", dts.gcod_empleado)

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

    Public Function FnActualizarContrato(ByVal dts As LCliente_Servicio) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("actualizar_cliente_servicio", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id_cliente_servicio", dts.gid_cliente_servicio)
            cmd.Parameters.AddWithValue("@fecha_instalacion", dts.gfecha_instalacion)
            cmd.Parameters.AddWithValue("@pago_instalacion", dts.gpago_instalacion)
            cmd.Parameters.AddWithValue("@estado_contrato", dts.gestado_contrato)
            cmd.Parameters.AddWithValue("@id_cliente", dts.gid_cliente)
            cmd.Parameters.AddWithValue("@id_servicio", dts.gid_servicio)
            cmd.Parameters.AddWithValue("@cod_empleado", dts.gcod_empleado)
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
    Public Function FnEliminarContrato(ByVal dts As LCliente_Servicio) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("eliminar_cliente_servicio")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_cliente_servicio", dts.gid_cliente_servicio)
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

    Public Function FnBuscarContratoPorDNI(dts As LCliente_Servicio) As DataTable
        Try
            FnConectado()
            cmd = New SqlCommand("BuscarClienteServicioPorDni", cnn)
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

    Public Function FnBuscarContratosEntreFechas(fecha1 As Date, fecha2 As Date) As DataTable
        Try
            FnConectado()
            cmd = New SqlCommand("BuscarContratosEntreFechas", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@fecha1", fecha1)
            cmd.Parameters.AddWithValue("@fecha2", fecha2)
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

    Public Function ObtenerNMaximoContratoCreado() As Integer
        Try
            FnConectado()
            cmd = New SqlCommand("ObtenerNMaximoContratoCreado")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            Dim n_maximoContrato = cmd.ExecuteScalar()
            If cmd.ExecuteNonQuery Then
                Return n_maximoContrato
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
