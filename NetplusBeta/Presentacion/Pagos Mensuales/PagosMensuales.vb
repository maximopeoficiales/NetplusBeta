Public Class PagosMensuales
    Dim fn As New FPagoMensuales

    Private Sub buscarPorFECHA()
        Dim fecha = txt_BuscarFechaPago.Value.Date.ToShortDateString()
        Dim logica As New LPagoMensual
        tablaMensualidades.DataSource = fn.FnBuscarPagoMensualPorFechaPago(logica)

    End Sub
    Private Sub actualizarMensualidad()
        Dim logica As New LPagoMensual
        logica.gid_pago_mensual = Val(txt_id_pagomensual.Text)
        logica.gestado_pago = txt_estadoPago.Text
        logica.gfecha_pago = txt_fechapago.Value
        logica.gfecha_pagada = txt_fechapagada.Value
        logica.gpago_mensual = CDbl(txt_pagomensual.Text)
        logica.gid_cliente_servicio = Val(txt_idContrato.Text)
        fn.FnActualizarPagoMensual(logica)
    End Sub
    Public Sub MostrarMensualidadesPorDNI()
        If txt_buscardni.Text = "" Then
            mostrarmensualidades()
            txt_pagoPendientes.Text = "0"
        Else
            tablaMensualidades.DataSource = fn.FnBuscarPagoMensualProximoPorDni(txt_buscardni.Text)
            txt_pagoPendientes.Text = fn.ObtenerPagosPendientesPorDni(txt_buscardni.Text).ToString
        End If

    End Sub
    Private Sub copiardatos()
        Try
            txt_id_pagomensual.Text = tablaMensualidades.SelectedCells.Item(0).Value
            txt_estadoPago.Text = tablaMensualidades.SelectedCells.Item(1).Value
            txt_fechapago.Value = tablaMensualidades.SelectedCells.Item(2).Value 'value porque le doy valor a datatimepicker'
            txt_fechapagada.Value = tablaMensualidades.SelectedCells.Item(3).Value
            txt_pagomensual.Text = tablaMensualidades.SelectedCells.Item(4).Value
            txt_idContrato.Text = tablaMensualidades.SelectedCells.Item(5).Value 'selected value para darle valor y se cambie el text'
            txt_dni.Text = tablaMensualidades.SelectedCells.Item(6).Value
        Catch ex As Exception : MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub mostrarmensualidades()
        tablaMensualidades.DataSource = fn.FnMostrarPagosMensuales()
    End Sub

    Private Sub Mensualidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarmensualidades()
        'activo estas caracteristicas para  poder copiar datos de la tabla'
        txt_id_pagomensual.ReadOnly = True 'para que no pueda modificar
        txt_idContrato.ReadOnly = True
        tablaMensualidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect 'activa la multiseleccion '
        tablaMensualidades.AllowUserToAddRows = False 'funciones para a dar doble click aparezcan los datos'
        tablaMensualidades.AllowUserToResizeRows = False
    End Sub

    Private Sub tablaEmpleados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaMensualidades.CellContentClick
        copiardatos()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mostrarmensualidades()
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        actualizarMensualidad()
    End Sub

    Private Sub txt_buscardni_TextChanged(sender As Object, e As EventArgs) Handles txt_buscardni.TextChanged
        MostrarMensualidadesPorDNI()
    End Sub



    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_AgregarFechaPAGO.Click
        Try
            Dim fechasumada As Date = txt_fechapago.Value.AddDays(30)

            Dim logica As New LPagoMensual
            logica.gestado_pago = "NO PAGO"
            logica.gfecha_pago = fechasumada.Date.ToShortDateString()
            logica.gfecha_pagada = fechasumada.Date.ToShortDateString()
            logica.gpago_mensual = CDbl(txt_pagomensual.Text)
            logica.gid_cliente_servicio = Val(txt_idContrato.Text)
            fn.FnInsertarPagoMensual(logica)
            mostrarmensualidades()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles btn_BuscarPorFecha.Click
        buscarPorFECHA()
    End Sub

    Private Sub imagen_buscar_Click(sender As Object, e As EventArgs) Handles imagen_buscar.Click

    End Sub
End Class