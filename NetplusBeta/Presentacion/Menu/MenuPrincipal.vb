Public Class MenuPrincipal
    Public Sub abrirformenpanel(ByVal formhijo As Object)
        Try
            If Me.PanelContenedor.Controls.Count > 0 Then 'si tiene controles'
                Me.PanelContenedor.Controls.RemoveAt(0) 'elimino todos los controles'
            End If
            Dim fh As Form = TryCast(formhijo, Form) 'fh sera igual a parametro de entrada
            fh.TopLevel = False 'especificamos que no form no de nivel superior
            fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            fh.Dock = DockStyle.Fill
            Me.PanelContenedor.Controls.Add(fh)
            Me.PanelContenedor.Tag = fh
            fh.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub SalirSession()
        Dim button = MessageBox.Show("¿ESTAR SEGURO DE SALIR DE SESION?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If button = DialogResult.Yes Then 'Mensaje de alerta si marca si abre el login y vacio los textbox'
            Me.Hide()
            Login.Show()
            Login.txt_usuario.Text = ""
            Login.txt_contrasena.Text = ""
        End If
    End Sub
    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrirformenpanel(New MenuResumen)
    End Sub

    Private Sub btn_Ventas_Click(sender As Object, e As EventArgs) Handles btn_Inicio.Click
        abrirformenpanel(MenuResumen)
    End Sub

    Private Sub btn_clientes_Click(sender As Object, e As EventArgs) Handles btn_clientes.Click
        abrirformenpanel(AdministarClientes)
    End Sub

    Private Sub btn_servicios_Click(sender As Object, e As EventArgs) Handles btn_servicios.Click
        abrirformenpanel(AdministrarServicios)
    End Sub

    Private Sub btn_empleados_Click(sender As Object, e As EventArgs) Handles btn_empleados.Click
        abrirformenpanel(AdministrarEmpleados)
    End Sub

    Private Sub btn_planes_Click(sender As Object, e As EventArgs) Handles btn_planes.Click
        abrirformenpanel(AdministrarPlanes)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        abrirformenpanel(PagosMensuales)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        abrirformenpanel(AdministrarGanancias)
    End Sub

    Private Sub btn_Contratos_Click(sender As Object, e As EventArgs) Handles btn_Contratos.Click
        abrirformenpanel(ConsultarContratos)
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        abrirformenpanel(RegistrarContrato)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        abrirformenpanel(ConsultarFacturas)
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        SalirSession()
    End Sub
End Class