Public Class ConsultarContratos
    Dim fn As New FContratos
    Public Sub MostrarContratos()
        tablaContratos.DataSource = fn.FnMostrarContratos()
    End Sub
    Public Sub MostrarContratosPorDNI()
        If checkDNI.Checked Then
            If txt_dni.Text = "" Then
                tablaContratos.DataSource = fn.FnMostrarContratos()
            Else
                Dim logicas As New LCliente_Servicio
                logicas.gid_cliente = txt_dni.Text
                tablaContratos.DataSource = fn.FnBuscarContratoPorDNI(logicas)
            End If
        End If
    End Sub
    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        MenuPrincipal.abrirformenpanel(Me)
    End Sub

    Private Sub btn_nuevo_contrato_Click(sender As Object, e As EventArgs) Handles btn_nuevo_contrato.Click
        MenuPrincipal.abrirformenpanel(AdministrarContratos)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        MenuPrincipal.abrirformenpanel(RegistrarContrato)
    End Sub

    Private Sub txt_dni_TextChanged(sender As Object, e As EventArgs) Handles txt_dni.TextChanged
        MostrarContratosPorDNI()
    End Sub

    Private Sub ConsultarContratos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarContratos()
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        If checkfecha.Checked Then
            Dim fecha1 = fechaconsulta1.Value.Date.ToShortDateString() 'metodo para obtener la fecha como el calendario de windows'
            Dim fecha2 = fechaconsulta2.Value.Date.ToShortDateString()
            tablaContratos.DataSource = fn.FnBuscarContratosEntreFechas(fecha1, fecha2)
        End If
    End Sub
End Class