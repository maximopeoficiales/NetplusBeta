Imports System.Data.SqlClient
Public Class FEmpleados
    Inherits FConexion
    Dim cmd As New SqlCommand

    Public Function FnMostrarEmpleados() As DataTable
        Try
            FnConectado()
            cmd = New SqlCommand("mostrar_empleados", cnn) 'mi procedimiento almacenado ya hecho'
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

    Public Function FnInsertarEmpleado(ByVal dts As LEmpleados) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("insertar_empleado", cnn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@usuario", dts.gusuario)
            cmd.Parameters.AddWithValue("@contrasena", dts.gcontrasena)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
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

    Public Function FnActualizarEmpleado(ByVal dts As LEmpleados) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("actualizar_empleado", cnn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@cod_empleado", dts.gcod_empleado)
            cmd.Parameters.AddWithValue("@usuario", dts.gusuario)
            cmd.Parameters.AddWithValue("@contrasena", dts.gcontrasena)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
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
    Public Function FnEliminarEmpleados(ByVal dts As LEmpleados) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("eliminar_empleado")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@cod_empleado", dts.gcod_empleado)
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

    Public Function FnBuscarEmpleadoPorNombre(dts As LEmpleados) As DataTable
        Try
            FnConectado()
            cmd = New SqlCommand("BuscarEmpleadoPorNombre", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
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
    Dim validacion
    Public Sub validar_form()
        If Login.txt_usuario.Text = "" Or Login.txt_contrasena.Text = "" Then
            validacion = False
            MsgBox("Complete todos los campos")
        Else
            validacion = True
        End If
    End Sub
    Public Sub IniciarSesion()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        validar_form()
        If validacion Then
            Try
                FnConectado()
                da = New SqlDataAdapter("validar_usuarios", cnn)
                'indetificar que es un proceso almacenado'
                da.SelectCommand.CommandType = 4
                da.SelectCommand.Parameters.AddWithValue("@Usuario", Login.txt_usuario.Text)
                da.SelectCommand.Parameters.AddWithValue("@Contrasena", Login.txt_contrasena.Text)
                da.Fill(dt)
                Dim cod_empleado = dt.Rows(0)(0).ToString
                Dim usuario = dt.Rows(0)(1).ToString
                Dim contrasena = dt.Rows(0)(2).ToString
                Dim nombre_completo = dt.Rows(0)(3).ToString
                FnDesconectado()

                If usuario = Login.txt_usuario.Text And contrasena = Login.txt_contrasena.Text Then
                    IngresarUsuario(UCase(usuario), cod_empleado, nombre_completo)
                    Login.Hide() 'oculta no cierra'
                    MenuPrincipal.Show()
                End If
            Catch ex As Exception
                MsgBox("Datos Incorrectos")
            End Try
        End If
    End Sub
    Public Sub FnLlenarComboNombresEmpleado(ByRef combo As ComboBox)
        Dim dt As New DataTable
        Dim da As SqlDataAdapter 'conjunto de comandos para rellenar un dataset'
        Dim datos As DataSet 'datos en memoria'
        Try
            FnConectado()
            da = New SqlDataAdapter("mostrar_empleados", cnn)
            datos = New DataSet
            datos.Tables.Add("empleados") 'se agregaron los datos de la tabla planes'
            da.Fill(datos.Tables("empleados")) 'lo agrega a un tabla'
            combo.DataSource = datos.Tables("empleados") 'la informacion de la tabla se guarda en combobox'
            combo.DisplayMember = "nombre" 'Pero solo mostrara los nombres'
            combo.ValueMember = "cod_empleado"
        Catch ex As Exception
            MsgBox(ex.Message) ' si hubiera un error muestralo

        Finally 'cuando  todo finalize desconectate de la bd
            FnDesconectado()
        End Try
    End Sub
    Public Function ContarEmpleados() As String
        Try
            FnConectado()
            cmd = New SqlCommand("EmpleadosActivos")
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
