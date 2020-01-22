Public Class AdministrarServicios
    Dim validacion
    Dim fn As New FServicios
    Dim fp As New FPlanes
    Private Sub Copiardatos()
        Try
            txt_codServicio.Text = tablaServicios.SelectedCells.Item(1).Value
            txt_tipoServicio.Text = tablaServicios.SelectedCells.Item(2).Value
            txt_precio.Text = tablaServicios.SelectedCells.Item(3).Value
            cb_id_plan.Text = tablaServicios.SelectedCells.Item(4).Value
        Catch ex As Exception : MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub validar_form()
        If txt_tipoServicio.Text = "" Or txt_precio.Text = "" Or cb_id_plan.Text = "" Then
            validacion = False
            MsgBox("Complete todos los campos")
        Else
            validacion = True
        End If
    End Sub
    Private Sub PropiedadesDatagrid()
        tablaServicios.SelectionMode = DataGridViewSelectionMode.FullRowSelect 'activa la multiseleccion'
        tablaServicios.AllowUserToAddRows = False
        tablaServicios.AllowUserToResizeRows = False
        MostrarServicios()
        txt_codServicio.ReadOnly = True
    End Sub
    Private Sub MostrarServicios()
        tablaServicios.DataSource = fn.FnMostrarServicios
    End Sub
    Private Sub MostrarServicioPorTipoServicio()
        Dim logicas As New LServicios
        If txt_buscartipoSERVICIO.Text = "" Then
            MostrarServicios()
        End If
        logicas.gtipo_servicio = txt_buscartipoSERVICIO.Text
        tablaServicios.DataSource = fn.FnBuscarServicioPorTipoServicio(logicas)
    End Sub
    Private Sub RegistrarServicio()
        Dim logica As New LServicios

        logica.gtipo_servicio = (txt_tipoServicio.Text)
        logica.gprecio_servicio = CDbl(txt_precio.Text)
        logica.gid_plan = cb_id_plan.Text
        fn.FnInsertarServicio(logica)
        MostrarServicios()
    End Sub
    Private Sub ActulizarServicio()

        Dim logica As New LServicios
        logica.gid_servicio = Val(txt_codServicio.Text)
        logica.gtipo_servicio = txt_tipoServicio.Text
        logica.gprecio_servicio = CDbl(txt_precio.Text)
        logica.gid_plan = cb_id_plan.Text
        fn.FnActualizarServicio(logica)
        MostrarServicios()
    End Sub
    Public Sub eliminar_servicio()
        Dim result As DialogResult
        'estilo del mensaje'
        result = MessageBox.Show("¿Estas seguro de eliminar los cliente seleccionados", "Cliente Eliminado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        'si presiona ok'
        If result = Windows.Forms.DialogResult.OK Then
            'recorre la las filas'
            For Each row As DataGridViewRow In tablaServicios.Rows
                Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                If marcado Then
                    Try
                        'dni_cliente es la fila donde obtendra el dato'
                        Dim id_cliente = row.Cells("id_servicio").Value
                        Dim funciones As New FServicios
                        Dim logica As New LServicios
                        logica.gid_servicio = id_cliente
                        If funciones.FnEliminarServicio(logica) Then 'llamo a mi funcion creada en la  fclientes
                            MsgBox("Se elimino correctamente")
                            MostrarServicios()
                        End If
                    Catch ex As Exception
                        MsgBox("No se puede porque tiene relacion con algun documento")

                    End Try
                End If
            Next
        End If
    End Sub
    Private Sub tablaServicios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaServicios.CellContentClick

    End Sub

    Private Sub tablaServicios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaServicios.CellDoubleClick
        Copiardatos()
    End Sub

    Private Sub AdministrarServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PropiedadesDatagrid()
        fp.FnLlenarComboPlanes(cb_id_plan)
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        eliminar_servicio()
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        ActulizarServicio()
    End Sub

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        RegistrarServicio()
    End Sub

    Private Sub txt_buscardni_TextChanged(sender As Object, e As EventArgs) Handles txt_buscartipoSERVICIO.TextChanged
        MostrarServicioPorTipoServicio()

    End Sub
End Class