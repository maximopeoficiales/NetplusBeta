Public Class AdministrarContratos
    Dim fs As New FServicios
    Dim fe As New FEmpleados
    Dim fn As New FContratos
    Dim fcs As New FContratos
    Private Sub ActualizarContrato()
        Try
            Dim fecha_actualizada = txt_fechaInstalacion.Value.Date.ToShortDateString()
            Dim logica As New LCliente_Servicio
            logica.gid_cliente_servicio = Val(txt_clienteServicio.Text)
            logica.gfecha_instalacion = fecha_actualizada
            logica.gpago_instalacion = CDbl(txt_pagoInstalacion.Text)
            logica.gestado_contrato = txt_estadoContrato.Text
            logica.gid_cliente = txt_dniCliente.Text
            logica.gid_servicio = Val(txt_idServicio.SelectedValue.ToString)
            logica.gcod_empleado = Val(txt_codEmpleado.SelectedValue.ToString)
            fn.FnActualizarContrato(logica)
            tablaContratos.DataSource = fn.FnMostrarContratos()
            MsgBox("Contrato Actualizado")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub limpiardatos()
        txt_clienteServicio.Text = ""
        txt_pagoInstalacion.Text = ""
        txt_estadoContrato.Text = ""
        txt_dniCliente.Text = ""
        txt_codEmpleado.SelectedValue = 1
    End Sub
    Private Sub autoload()
        fe.FnLlenarComboNombresEmpleado(txt_codEmpleado)
        fs.FnLlenarComboServiciosIdPlan(txt_idServicio)
        tablaContratos.DataSource = fn.FnMostrarContratos()
        tablaContratos.SelectionMode = DataGridViewSelectionMode.FullRowSelect 'activa la multiseleccion '
        tablaContratos.AllowUserToAddRows = False 'funciones para a dar doble click aparezcan los datos'
        tablaContratos.AllowUserToResizeRows = False
    End Sub
    Private Sub copiardatos()
        Try
            txt_clienteServicio.Text = tablaContratos.SelectedCells.Item(0).Value
            txt_fechaInstalacion.Value = tablaContratos.SelectedCells.Item(1).Value 'value porque le doy valor a datatimepicker'
            txt_pagoInstalacion.Text = tablaContratos.SelectedCells.Item(2).Value
            txt_estadoContrato.Text = tablaContratos.SelectedCells.Item(3).Value
            txt_dniCliente.Text = tablaContratos.SelectedCells.Item(4).Value
            txt_idServicio.SelectedValue = tablaContratos.SelectedCells.Item(5).Value 'selected value para darle valor y se cambie el text'
            txt_codEmpleado.SelectedValue = tablaContratos.SelectedCells.Item(6).Value
        Catch ex As Exception : MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub MostrarContratosPorDNI()
        If dnifiltro.Text = "" Then
            tablaContratos.DataSource = fn.FnMostrarContratos()
        Else
            Dim logicas As New LCliente_Servicio
            logicas.gid_cliente = dnifiltro.Text
            tablaContratos.DataSource = fn.FnBuscarContratoPorDNI(logicas)
        End If

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        MenuPrincipal.abrirformenpanel(RegistrarContrato)
    End Sub

    Private Sub btn_nuevo_contrato_Click(sender As Object, e As EventArgs) Handles btn_nuevo_contrato.Click
        MenuPrincipal.abrirformenpanel(Me)
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        MenuPrincipal.abrirformenpanel(ConsultarContratos)
    End Sub

    Private Sub AdministrarContratos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoload()
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        ActualizarContrato()

    End Sub

    Private Sub dnifiltro_TextChanged(sender As Object, e As EventArgs) Handles dnifiltro.TextChanged
        MostrarContratosPorDNI()
    End Sub

    Private Sub tablaContratos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaContratos.CellContentClick

    End Sub

    Private Sub tablaContratos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaContratos.CellDoubleClick
        copiardatos()

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        limpiardatos()
    End Sub

    Private Sub ActualizarCampos_Click(sender As Object, e As EventArgs) Handles ActualizarCampos.Click
        autoload()
    End Sub
End Class