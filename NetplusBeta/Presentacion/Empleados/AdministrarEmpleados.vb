Public Class AdministrarEmpleados
    Dim fun As New FEmpleados
    Dim validacion
    Private Sub Copiardatos()
        Try
            txt_codempleado.Text = tablaEmpleados.SelectedCells.Item(1).Value
            txt_usuario.Text = tablaEmpleados.SelectedCells.Item(2).Value
            txt_contrasena.Text = tablaEmpleados.SelectedCells.Item(3).Value
            txt_nombre.Text = tablaEmpleados.SelectedCells.Item(4).Value
        Catch ex As Exception : MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub validar_form()
        If txt_usuario.Text = "" Or txt_contrasena.Text = "" Or txt_nuevacontrasena.Text = "" Or txt_nombre.Text = "" Then
            validacion = False
            MsgBox("Complete todos los campos")
        ElseIf txt_contrasena.Text = txt_nuevacontrasena.Text Then
            validacion = True

        Else
            validacion = False
            MsgBox("Las contraseñas deben ser iguales")
        End If
    End Sub
    Private Sub PropiedadesDatagrid()
        txt_codempleado.ReadOnly = True
        tablaEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect 'activa la multiseleccion'
        tablaEmpleados.AllowUserToAddRows = False
        tablaEmpleados.AllowUserToResizeRows = False
    End Sub
    Private Sub MostrarEmpleados()
        tablaEmpleados.DataSource = fun.FnMostrarEmpleados
    End Sub
    Private Sub MostrarEmpleadosPorNombre()
        Dim logicas As New LEmpleados
        If txt_buscarnombre.Text = "" Then
            tablaEmpleados.DataSource = fun.FnMostrarEmpleados
        End If
        logicas.gnombre = txt_buscarnombre.Text
        tablaEmpleados.DataSource = fun.FnBuscarEmpleadoPorNombre(logicas)
    End Sub
    Private Sub RegistrarEmpleado()
        Dim logica As New LEmpleados
        logica.gusuario = txt_usuario.Text
        logica.gcontrasena = txt_contrasena.Text
        logica.gnombre = txt_nombre.Text
        fun.FnInsertarEmpleado(logica)
        MostrarEmpleados()
    End Sub
    Private Sub ActulizarEmpleado()
        Dim logica As New LEmpleados
        logica.gcod_empleado = Val(txt_codempleado.Text)
        logica.gusuario = txt_usuario.Text
        logica.gcontrasena = txt_contrasena.Text
        logica.gnombre = txt_nombre.Text
        fun.FnActualizarEmpleado(logica)
        MostrarEmpleados()
    End Sub
    Public Sub eliminar_Empleado()
        Dim result As DialogResult
        'estilo del mensaje'
        result = MessageBox.Show("¿Estas seguro de eliminar los cliente seleccionados", "Cliente Eliminado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        'si presiona ok'
        If result = Windows.Forms.DialogResult.OK Then
            'recorre la las filas'
            For Each row As DataGridViewRow In tablaEmpleados.Rows
                Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                If marcado Then
                    Try
                        'dni_cliente es la fila donde obtendra el dato'
                        Dim cod_empleado = row.Cells("cod_empleado").Value
                        Dim funciones As New FEmpleados
                        Dim logica As New LEmpleados
                        logica.gcod_empleado = cod_empleado
                        If funciones.FnEliminarEmpleados(logica) Then 'llamo a mi funcion creada en la  fclientes
                            MsgBox("Se elimino correctamente")
                            MostrarEmpleados()
                        End If
                    Catch ex As Exception
                        MsgBox("No se puede porque tiene relacion con algun documento")

                    End Try
                End If
            Next
        End If
    End Sub
    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        eliminar_Empleado()
    End Sub

    Private Sub AdministrarEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PropiedadesDatagrid()
        MostrarEmpleados()

    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        validar_form()
        If validacion Then
            ActulizarEmpleado()
        End If
    End Sub

    Private Sub txt_buscardni_TextChanged(sender As Object, e As EventArgs) Handles txt_buscarnombre.TextChanged
        MostrarEmpleadosPorNombre()
    End Sub

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        validar_form()
        If validacion Then
            RegistrarEmpleado()
        End If
    End Sub

    Private Sub tablaEmpleados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaEmpleados.CellContentClick

    End Sub

    Private Sub tablaEmpleados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaEmpleados.CellDoubleClick
        Copiardatos()
    End Sub
End Class