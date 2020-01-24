Public Class ConsultarFacturas
    Dim fn As New FFacturaContrato

    Private Sub cargardatos()
        tablaFacturaContrato.DataSource = fn.FnMostrarFacturasPagoMensual
    End Sub
    Private Sub ConsultarFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_MostrarFacturas_Click(sender As Object, e As EventArgs) Handles btn_MostrarFacturas.Click
        tablaFacturaContrato.DataSource = fn.FnMostrarFacturasPagoMensual
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Dim fechar1 = fecha1.Value.Date.ToShortDateString()
        Dim fechar2 = fecha2.Value.Date.ToShortDateString()
        tablaFacturaContrato.DataSource = fn.FnMostrarFacturasContratoPorRangoFechas(fechar1, fechar2)

    End Sub

    Private Sub ActualizarCampos_Click(sender As Object, e As EventArgs) Handles ActualizarCampos.Click
        cargardatos()
    End Sub
End Class