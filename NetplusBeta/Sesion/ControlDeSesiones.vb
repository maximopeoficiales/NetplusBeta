Module ControlDeSesiones
    Dim usuario_online As String
    Dim cod_empleado_online As Integer
    Dim nombre_completo_online As String

    Sub IngresarUsuario(usuario As String, cod_empleado As Integer, nombre_completo As String)
        usuario_online = usuario
        cod_empleado_online = cod_empleado
        nombre_completo_online = nombre_completo
    End Sub
    Function ObtenerUsuarioActivo()
        Return usuario_online
    End Function
    Function ObtenerCod_EmpleadoActivo()
        Return cod_empleado_online
    End Function
    Function ObtenerNombreCompletoActivo()
        Return nombre_completo_online
    End Function
End Module
