Public Class MenuResumen
    Dim fn As New FClientes
    Dim fp As New FPlanes
    Dim fs As New FServicios
    Dim fe As New FEmpleados
    Private Sub cargarDatos()
        label_usuario.Text = ObtenerUsuarioActivo()
        ContadorClientes.Text = fn.ContarClientes
        ContadorEmpleados.Text = fe.ContarEmpleados
        ContadorPlanes.Text = fp.ContarPlanes
        ContadorServicios.Text = fs.ContarServicios
    End Sub


    Private Sub MenuResumen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles PanelRaiz.Paint

    End Sub

    Private Sub panelresumen_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles ContadorEmpleados.Click

    End Sub

    Private Sub btn_VerClientes_Click(sender As Object, e As EventArgs) Handles btn_VerClientes.Click
        MenuPrincipal.abrirformenpanel(AdministarClientes)
    End Sub

    Private Sub btn_VerEmpleados_Click(sender As Object, e As EventArgs) Handles btn_VerEmpleados.Click
        MenuPrincipal.abrirformenpanel(AdministrarEmpleados)
    End Sub

    Private Sub btn_VerServicios_Click(sender As Object, e As EventArgs) Handles btn_VerServicios.Click
        MenuPrincipal.abrirformenpanel(AdministrarServicios)
    End Sub

    Private Sub btn_VerPlanes_Click(sender As Object, e As EventArgs) Handles btn_VerPlanes.Click
        MenuPrincipal.abrirformenpanel(AdministrarPlanes)
    End Sub

    Private Sub btn_VerGanancias_Click(sender As Object, e As EventArgs) Handles btn_VerGanancias.Click
        MenuPrincipal.abrirformenpanel(AdministrarGanancias)
    End Sub

    Private Sub btn_realizarcontrato_Click(sender As Object, e As EventArgs) Handles btn_realizarcontrato.Click
        MenuPrincipal.abrirformenpanel(RegistrarContrato)
    End Sub

    Private Sub ActualizarCampos_Click(sender As Object, e As EventArgs) Handles ActualizarCampos.Click
        cargarDatos()
    End Sub
End Class