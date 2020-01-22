Imports System.Data.SqlClient
Public Class FPlanes
    Inherits FConexion
    Dim cmd As New SqlCommand
    Dim informacion As String
    Public Function FnMostrarPlanes() As DataTable
        Try
            FnConectado()
            cmd = New SqlCommand("mostrar_planes", cnn) 'mi procedimiento almacenado ya hecho'
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

    Public Function FnInsertarPlan(ByVal dts As LPlanes) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("insertar_plan", cnn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@id_plan", dts.gid_plan)
            cmd.Parameters.AddWithValue("@descripcion", dts.gdescripcion)
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

    Public Function FnActualizarCliente(ByVal dts As LPlanes) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("actualizar_plan", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id_plan", dts.gid_plan)
            cmd.Parameters.AddWithValue("@descripcion", dts.gdescripcion)
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
    Public Function FnEliminarPlan(ByVal dts As LPlanes) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("eliminar_plan")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_plan", dts.gid_plan)
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

    Public Function FnBuscarEmpleadoPordni(dts As LPlanes) As DataTable
        Try
            FnConectado()
            cmd = New SqlCommand("BuscarPlanPorID", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id_plan", dts.gid_plan)
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

    Public Sub FnLlenarComboPlanes(ByRef combo As ComboBox)
        Dim dt As New DataTable
        Dim da As SqlDataAdapter 'conjunto de comandos para rellenar un dataset'
        Dim datos As DataSet 'datos en memoria'
        Try
            FnConectado()
            da = New SqlDataAdapter("mostrar_planes", cnn)
            datos = New DataSet
            datos.Tables.Add("planes") 'se agregaron los datos de la tabla planes'
            da.Fill(datos.Tables("planes")) 'lo agrega a un tabla'
            combo.DataSource = datos.Tables("planes") 'la informacion de la tabla se guarda en combobox'
            combo.DisplayMember = "id_plan" 'Pero solo mostrara los nombres'
        Catch ex As Exception
            MsgBox(ex.Message) ' si hubiera un error muestralo

        Finally 'cuando  todo finalize desconectate de la bd
            FnDesconectado()
        End Try
    End Sub
    Public Function FnMostrarDescripcionPlan(ByVal dts As LPlanes) As String
        Try
            FnConectado()
            cmd = New SqlCommand("mostrar_descripcionPlanporID", cnn) 'mi procedimiento almacenado ya hecho'

            cmd.CommandType = CommandType.StoredProcedure 'tipo proc almacenado
            cmd.Parameters.AddWithValue("@id_plan", dts.gid_plan)
            'si tiene resultado el comando
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd) 'los resultados se guardan en da
                da.Fill(dt) 'lleno los datos en un datatable
                Return dt.Rows(0)(1).ToString()

            Else
                Return Nothing
            End If
        Catch ex As Exception
            ' si hubiera un error muestralo
            Return Nothing
        Finally 'cuando  todo finalize desconectate de la bd
            FnDesconectado()
        End Try
    End Function

    Public Function ContarPlanes() As String
        Try
            FnConectado()
            cmd = New SqlCommand("PlanesActivos")
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
