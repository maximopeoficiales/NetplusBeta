Imports System.Data.SqlClient
Public Class FPagoMensuales
    Inherits FConexion
    Dim cmd As New SqlCommand
    Public Function FnMostrarPagosMensuales() As DataTable
        Try
            FnConectado()
            cmd = New SqlCommand("MostraMensualidadesProximas", cnn) 'mi procedimiento almacenado ya hecho'
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

    Public Function FnInsertarPagoMensual(ByVal dts As LPagoMensual) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("insertar_pago_mensual", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@estado_pago", dts.gestado_pago)
            cmd.Parameters.AddWithValue("@fecha_pago", dts.gfecha_pago)
            cmd.Parameters.AddWithValue("@fecha_pagada", dts.gfecha_pagada)
            cmd.Parameters.AddWithValue("@pago_mensual", dts.gpago_mensual)
            cmd.Parameters.AddWithValue("@id_cliente_servicio", dts.gid_cliente_servicio)

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

    Public Function FnActualizarPagoMensual(ByVal dts As LPagoMensual) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("actualizar_pago_mensual", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id_pago_mensual", dts.gid_pago_mensual)
            cmd.Parameters.AddWithValue("@estado_pago", dts.gestado_pago)
            cmd.Parameters.AddWithValue("@fecha_pago", dts.gfecha_pago)
            cmd.Parameters.AddWithValue("@fecha_pagada", dts.gfecha_pagada)
            cmd.Parameters.AddWithValue("@pago_mensual", dts.gpago_mensual)
            cmd.Parameters.AddWithValue("@id_cliente_servicio", dts.gid_cliente_servicio)

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
    Public Function FnEliminarPagoMensual(ByVal dts As LPagoMensual) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("eliminar_pago_mensual")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_pago_mensual", dts.gid_pago_mensual)
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

    Public Function FnBuscarPagoMensualProximoPorDni(dni As String) As DataTable
        Try
            FnConectado()
            cmd = New SqlCommand("BuscarPagoMensualProximoPorDni", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id_cliente", dni)
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

    Public Function FnBuscarPagoMensualPorFechaPago(dts As LPagoMensual) As DataTable
        Try
            FnConectado()
            cmd = New SqlCommand("BuscarPagoMensualPorFechaPago", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@fecha_pago", dts.gfecha_pago)
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

    Public Function FnObtenerfechaPAGOPordni()
        Try
            FnConectado()
            cmd = New SqlCommand("FnObtenerfechaPAGOPordni")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            Dim ultima_fecha_pago As Date = CDate(cmd.ExecuteScalar())
            If cmd.ExecuteNonQuery Then
                Return ultima_fecha_pago
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

    Public Function ObtenerPagosPendientesPorDni(dni As String) As Integer
        Try
            FnConectado()
            cmd = New SqlCommand("PagosPendientesPorDni")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id_cliente", dni)
            cmd.Connection = cnn
            Dim pagos_pendientes = cmd.ExecuteScalar()
            If cmd.ExecuteNonQuery Then
                Return pagos_pendientes
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
