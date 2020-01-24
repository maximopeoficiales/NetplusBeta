Public Class AdministrarGanancias
    Dim fn As New FGanancias
    Private Sub mostrarganancias()
        Dim ganancias = CStr(fn.MostrarTodasLasGananciasResultado)
        tablaGanancias.DataSource = fn.FnMostrarTodasLasGanancias
        txt_ganancias.Text = ganancias
    End Sub
    Private Sub btn_GananciasporRango_Click(sender As Object, e As EventArgs) Handles btn_GananciasporRango.Click
        Dim fechar1 = fecha1.Value.Date.ToShortDateString
        Dim fechar2 = fecha2.Value.Date.ToShortDateString
        Dim ganancia = CStr(fn.MostrarGananciasPorRangoResultado(fechar1, fechar2))
        tablaGanancias.DataSource = fn.FnMostrarGananciasPorRango(fechar1, fechar2)
        txt_ganancias.Text = ganancia
    End Sub

    Private Sub AdministrarGanancias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarganancias()
    End Sub

    Private Sub btn_TodasGanancia_Click(sender As Object, e As EventArgs) Handles btn_TodasGanancia.Click

        mostrarganancias()
    End Sub

    Private Sub ActualizarCampos_Click(sender As Object, e As EventArgs) Handles ActualizarCampos.Click
        mostrarganancias()
    End Sub
End Class