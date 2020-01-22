Imports System.Data.SqlClient
Public Class FServicios
    Inherits FConexion
    Dim cmd As New SqlCommand

    Public Function FnMostrarServicios() As DataTable
        Try
            FnConectado()
            cmd = New SqlCommand("mostrar_servicios", cnn) 'mi procedimiento almacenado ya hecho'
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

    Public Function FnInsertarServicio(ByVal dts As LServicios) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("insertar_servicio", cnn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@tipo_servicio", dts.gtipo_servicio)
            cmd.Parameters.AddWithValue("@precio_servicio", dts.gprecio_servicio)
            cmd.Parameters.AddWithValue("@id_plan", dts.gid_plan)

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

    Public Function FnActualizarServicio(ByVal dts As LServicios) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("actualizar_servicio", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id_servicio", dts.gid_servicio)
            cmd.Parameters.AddWithValue("@tipo_servicio", dts.gtipo_servicio)
            cmd.Parameters.AddWithValue("@precio_servicio", dts.gprecio_servicio)
            cmd.Parameters.AddWithValue("@id_plan", dts.gid_plan)
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
    Public Function FnEliminarServicio(ByVal dts As LServicios) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("eliminar_servicio")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_servicio", dts.gid_servicio)
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

    Public Function FnBuscarServicioPorTipoServicio(dts As LServicios) As DataTable
        Try
            FnConectado()
            cmd = New SqlCommand("BuscarServicioPorTipoServicio", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@tipo_servicio", dts.gtipo_servicio)
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
    Public Sub FnLlenarComboServiciosIdPlan(ByRef combo As ComboBox)
        Dim dt As New DataTable
        Dim da As SqlDataAdapter 'conjunto de comandos para rellenar un dataset'
        Dim datos As DataSet 'datos en memoria'
        Try
            FnConectado()
            da = New SqlDataAdapter("mostrar_servicios", cnn)
            datos = New DataSet
            datos.Tables.Add("servicios") 'se agregaron los datos de la tabla planes'
            da.Fill(datos.Tables("servicios")) 'lo agrega a un tabla'
            combo.DataSource = datos.Tables("servicios") 'la informacion de la tabla se guarda en combobox'
            combo.DisplayMember = "id_plan" 'Pero solo mostrara los nombres'
            combo.ValueMember = "id_servicio"
        Catch ex As Exception
            MsgBox(ex.Message) ' si hubiera un error muestralo

        Finally 'cuando  todo finalize desconectate de la bd
            FnDesconectado()
        End Try
    End Sub

    Public Function FnMostrarServicioPorid(ByVal dts As LServicios) As DataTable
        Try
            FnConectado()
            cmd = New SqlCommand("mostrar_serviciosPorId", cnn) 'mi procedimiento almacenado ya hecho'

            cmd.CommandType = CommandType.StoredProcedure 'tipo proc almacenado
            cmd.Parameters.AddWithValue("@id_servicio", dts.gid_servicio)
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

    Public Function ObtenerPrecioServicioPorId_Servicio(id_servicio As Integer) As Double
        Try
            FnConectado()
            cmd = New SqlCommand("ObtenerPrecioServicioPorId_Servicio")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id_servicio", id_servicio)
            cmd.Connection = cnn
            Dim precio_servicio = cmd.ExecuteScalar()
            If cmd.ExecuteNonQuery Then
                Return precio_servicio
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

    Public Function ContarServicios() As String
        Try
            FnConectado()
            cmd = New SqlCommand("ServiciosActivos")
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
