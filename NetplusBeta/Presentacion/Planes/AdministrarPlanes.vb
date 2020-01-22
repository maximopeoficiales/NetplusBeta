Public Class AdministrarPlanes
    Dim fn As New FPlanes
    Dim validacion
    Private Sub Copiardatos()
        Try
            txt_id_plan.Text = tablaPlanes.SelectedCells.Item(1).Value
            txt_descripcion.Text = tablaPlanes.SelectedCells.Item(2).Value
        Catch ex As Exception : MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub validar_form()
        If txt_id_plan.Text = "" Or txt_descripcion.Text = "" Then
            validacion = False
            MsgBox("Complete todos los campos")

        Else
            validacion = True
        End If
    End Sub
    Private Sub PropiedadesDatagrid()
        'txt_id_plan.ReadOnly = True
        tablaPlanes.SelectionMode = DataGridViewSelectionMode.FullRowSelect 'activa la multiseleccion'
        tablaPlanes.AllowUserToAddRows = False
        tablaPlanes.AllowUserToResizeRows = False
    End Sub
    Private Sub MostrarPlanes()
        tablaPlanes.DataSource = fn.FnMostrarPlanes
    End Sub
    Private Sub MostrarPlanesPorID()
        Dim logicas As New LPlanes
        If txt_buscarid_plan.Text = "" Then
            MostrarPlanes()
        End If
        logicas.gid_plan = txt_buscarid_plan.Text
        tablaPlanes.DataSource = fn.FnBuscarEmpleadoPordni(logicas)
    End Sub
    Private Sub RegistrarPLAN()
        Dim logica As New LPlanes
        logica.gid_plan = txt_id_plan.Text
        logica.gdescripcion = txt_descripcion.Text

        fn.FnInsertarPlan(logica)
        MostrarPlanes()
    End Sub
    Private Sub ActulizarPLAN()
        Dim logica As New LPlanes
        logica.gid_plan = txt_id_plan.Text
        logica.gdescripcion = txt_descripcion.Text

        fn.FnActualizarCliente(logica)
        MostrarPlanes()
    End Sub
    Public Sub eliminar_PLAN()
        Dim result As DialogResult
        'estilo del mensaje'
        result = MessageBox.Show("¿Estas seguro de eliminar los cliente seleccionados", "Cliente Eliminado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        'si presiona ok'
        If result = Windows.Forms.DialogResult.OK Then
            'recorre la las filas'
            For Each row As DataGridViewRow In tablaPlanes.Rows
                Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                If marcado Then
                    Try
                        'dni_cliente es la fila donde obtendra el dato'
                        Dim id_plan = row.Cells("id_plan").Value
                        Dim funciones As New FPlanes
                        Dim logica As New LPlanes
                        logica.gid_plan = id_plan
                        If funciones.FnEliminarPlan(logica) Then 'llamo a mi funcion creada en la  fclientes
                            MsgBox("Se elimino correctamente")
                            MostrarPlanes()
                        End If
                    Catch ex As Exception
                        MsgBox("No se puede porque tiene relacion con algun documento")

                    End Try
                End If
            Next
        End If
    End Sub

    Private Sub AdministrarPlanes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PropiedadesDatagrid()
        MostrarPlanes()
    End Sub

    Private Sub txt_buscarid_plan_TextChanged(sender As Object, e As EventArgs) Handles txt_buscarid_plan.TextChanged
        MostrarPlanesPorID()
    End Sub

    Private Sub tablaPlanes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaPlanes.CellContentClick

    End Sub

    Private Sub tablaPlanes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaPlanes.CellDoubleClick
        Copiardatos()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        eliminar_PLAN()
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        ActulizarPLAN()
    End Sub

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        RegistrarPLAN()
    End Sub
End Class