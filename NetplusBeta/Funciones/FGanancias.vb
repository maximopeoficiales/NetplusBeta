Imports System.Data.SqlClient
Public Class FGanancias
    Inherits FConexion
    Dim cmd As New SqlCommand

    Public Function FnMostrarTodasLasGanancias() As DataTable
        Try
            FnConectado()
            cmd = New SqlCommand("MostrarTodasLasGanancias", cnn) 'mi procedimiento almacenado ya hecho'
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
    Public Function MostrarTodasLasGananciasResultado() As Double
        Try
            FnConectado()
            cmd = New SqlCommand("MostrarTodasLasGananciasResultado")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            Dim resultado = cmd.ExecuteScalar()
            If cmd.ExecuteNonQuery Then
                Return resultado
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
    Public Function FnMostrarGananciasPorRango(fecha1 As Date, fecha2 As Date) As DataTable
        Try
            FnConectado()
            cmd = New SqlCommand("MostrarGananciasPorRango", cnn) 'mi procedimiento almacenado ya hecho'
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
    Public Function MostrarGananciasPorRangoResultado(fecha1 As Date, fecha2 As Date) As Double
        Try
            FnConectado()
            cmd = New SqlCommand("MostrarGananciasPorRangoResultado")
            cmd.Parameters.AddWithValue("@fecha1", fecha1)
            cmd.Parameters.AddWithValue("@fecha2", fecha2)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            Dim resultado = (cmd.ExecuteScalar())
            If cmd.ExecuteNonQuery Then
                Return resultado
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
