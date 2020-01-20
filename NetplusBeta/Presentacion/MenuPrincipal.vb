Public Class MenuPrincipal
    Public Sub abrirform(ByVal formhijo As Object)
        If Me.PanelContenedor.Controls.Count > 0 Then
            Me.PanelContenedor.Controls.RemoveAt(0)
            Dim fh As Form = TryCast(formhijo, Form)
            fh.TopLevel = False
            fh.FormBorderStyle = FormBorderStyle.None
            fh.Dock = DockStyle.Fill
            PanelContenedor.Controls.Add(fh)
            PanelContenedor.Tag = fh
            fh.Show()


        End If
    End Sub
    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_medios_Click(sender As Object, e As EventArgs) Handles btn_medios.Click
        abrirform(Usuarios)
    End Sub
End Class