Imports System.Data.SqlClient
Public Class FFacturaContrato
    Inherits FConexion
    Dim cmd As New SqlCommand

    Public Function FnMostrarFacturasPagoMensual() As DataTable
        Try
            FnConectado()
            cmd = New SqlCommand("MostrarFacturasContrato", cnn) 'mi procedimiento almacenado ya hecho'
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
    Public Function FnMostrarFacturasContratoPorRangoFechas(fecha1 As Date, fecha2 As Date) As DataTable
        Try
            FnConectado()
            cmd = New SqlCommand("MostrarFacturasContratoPorRangoFechas", cnn) 'mi procedimiento almacenado ya hecho'
            cmd.Parameters.AddWithValue("@fecha1", fecha1)
            cmd.Parameters.AddWithValue("@fecha2", fecha2)
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

    Public Function FnInsertarFacturaContrato(ByVal dts As LFacturaContrato) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("InsertarFacturaContrato", cnn)
            cmd.CommandType = CommandType.StoredProcedure
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
End Class
