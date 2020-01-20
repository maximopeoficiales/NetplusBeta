Public Class Usuarios
    Dim dt As New DataTable 'creo variable global de tipo datatable
    Sub mostrar_usuarios()
        Try
            Dim func As New FClientes 'instancio la clase fclientes
            dt = func.FnMostrarUsuarios 'el resultado de la funcion lo guardo en dt
            'si hay mas de un resultado
            If dt.Rows.Count > 0 Then
                tabla_clientes.DataSource = dt 'igualo el origen de datos de mi tabla con dt
            Else
                tabla_clientes.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_usuarios()
    End Sub

    Private Sub insert_btn_Click(sender As Object, e As EventArgs) Handles insert_btn.Click
        Try
            Dim funciones As New FClientes
            Dim logica As New VUsers

            logica.gusuario = usuario.Text
            logica.gcontrasena = contrasena.Text

            If funciones.FnInsertarUsuarios(logica) Then 'llamo a mi funcion creada en la  fclientes
                MsgBox("insertado completo")
                mostrar_usuarios()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class