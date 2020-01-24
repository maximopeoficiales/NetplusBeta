Public Class RegistrarContrato
    Dim fn As New FContratos
    Dim fc As New FClientes
    Dim fe As New FEmpleados
    Dim fs As New FServicios
    Dim fp As New FPlanes
    Dim fpm As New FPagoMensuales
    Dim ffc As New FFacturaContrato
    Dim validacion

    Private Sub registrarFactura()
        Dim logica As New LFacturaContrato
        logica.gid_cliente_servicio = fn.ObtenerNMaximoContratoCreado
        ffc.FnInsertarFacturaContrato(logica)
        MsgBox("Factura Generada")
    End Sub

    Private Sub GenerarPrimerPagoMensual()
        Dim fecha_contrato = txt_fechaInstalacion.Value.Date.ToShortDateString()
        Dim pago_mensual = fs.ObtenerPrecioServicioPorId_Servicio(Val(txt_idServicio.SelectedValue.ToString))
        Dim id_cliente_servicio = fn.ObtenerNMaximoContratoCreado()
        MsgBox("el pago mensual es " & pago_mensual & "el id es " & id_cliente_servicio)
        Dim logica As New LPagoMensual
        logica.gestado_pago = "NO PAGO"
        logica.gfecha_pago = fecha_contrato
        logica.gfecha_pagada = fecha_contrato
        logica.gpago_mensual = pago_mensual
        logica.gid_cliente_servicio = id_cliente_servicio
        fpm.FnInsertarPagoMensual(logica)
        MsgBox("Primer pago Mensual Creado")
    End Sub
    'MsgBox(txt_idServicio.SelectedValue.ToString)
    Public Sub validar_form()
        If txt_codEmpleado.Text = "" Or txt_dniCliente.Text = "" Or txt_estadoContrato.Text = "" Or txt_idServicio.Text = "" Then
            validacion = False
            MsgBox("Los campos no pueden estar vacios")
        Else
            validacion = True
        End If
    End Sub
    Private Sub registrar_contrato()
        Dim fecha_contrato = txt_fechaInstalacion.Value.Date.ToShortDateString()
        Dim logica As New LCliente_Servicio

        'logica.gid_cliente_servicio = Val(txt_clienteServicio.Text)
        logica.gfecha_instalacion = fecha_contrato
        logica.gpago_instalacion = CDbl(txt_pagoInstalacion.Text)
        logica.gestado_contrato = txt_estadoContrato.Text
        logica.gid_cliente = txt_dniCliente.Text
        logica.gid_servicio = Val(txt_idServicio.SelectedValue.ToString)
        logica.gcod_empleado = Val(txt_codEmpleado.SelectedValue.ToString)
        fn.FnInsertarContrato(logica)
        'genera el primer pago mensual para partir de ahi
        GenerarPrimerPagoMensual()
        registrarFactura()
        MsgBox("Contrato Registrado")

    End Sub
    Private Sub BuscarDatosPorDNI()
        If txt_idServicio.Text = "" Then
            TablaClienteResumen.DataSource = fc.FnMostrarClientes

        ElseIf txt_idServicio.Text = "" Then
            Dim dni = (txt_idServicio.Text)
            Dim logica As New LClientes
            logica.gid_cliente = dni
            TablaClienteResumen.DataSource = fc.FnBuscarClientePordni(logica)
        End If
    End Sub
    Private Sub MostrarInformacionPlan()
        If txt_idServicio.Text <> "" Then
            Dim logica As New LPlanes
            logica.gid_plan = txt_idServicio.Text
            txt_informacionPlan.Text = fp.FnMostrarDescripcionPlan(logica)
        End If
    End Sub

    Private Sub txt_dniCliente_TextChanged(sender As Object, e As EventArgs) Handles txt_dniCliente.TextChanged
        If txt_dniCliente.Text = "" Then
            TablaClienteResumen.DataSource = fc.FnMostrarClientes

        Else
            Dim dni = (txt_dniCliente.Text)
            Dim logica As New LClientes
            logica.gid_cliente = dni
            TablaClienteResumen.DataSource = fc.FnBuscarClientePordni(logica)
        End If
    End Sub

    Private Sub txt_idServicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_idServicio.SelectedIndexChanged
        Try
            MostrarInformacionPlan()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub cargardatos()
        Try
            txt_clienteServicio.ReadOnly = True
            fe.FnLlenarComboNombresEmpleado(txt_codEmpleado)
            fs.FnLlenarComboServiciosIdPlan(txt_idServicio)
            TablaClienteResumen.SelectionMode = DataGridViewSelectionMode.FullRowSelect 'activa la multiseleccion '
            TablaClienteResumen.AllowUserToAddRows = False 'funciones para a dar doble click aparezcan los datos'
            TablaClienteResumen.AllowUserToResizeRows = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btn_nuevo_contrato_Click(sender As Object, e As EventArgs) Handles btn_nuevo_contrato.Click
        MenuPrincipal.abrirformenpanel(AdministrarContratos)
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        MenuPrincipal.abrirformenpanel(ConsultarContratos)
    End Sub

    Private Sub RegistrarContrato_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        registrar_contrato()

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        txt_pagoInstalacion.Text = ""
        txt_dniCliente.Text = ""
        txt_estadoContrato.Text = ""
    End Sub

    Private Sub TablaClienteResumen_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaClienteResumen.CellContentClick

    End Sub

    Private Sub TablaClienteResumen_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaClienteResumen.CellContentDoubleClick
        txt_dniCliente.Text = TablaClienteResumen.SelectedCells.Item(0).Value
    End Sub

    Private Sub ActualizarCampos_Click(sender As Object, e As EventArgs) Handles ActualizarCampos.Click
        cargardatos()
    End Sub
End Class