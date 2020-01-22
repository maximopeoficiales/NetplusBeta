Public Class Login
    'funciones'
    Dim fun As New FEmpleados
    Private Sub EstiloFormulario()
        Me.Height = 600
        Me.Width = 400
        Dim p As New Drawing2D.GraphicsPath()
        p.StartFigure()
        p.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        p.AddLine(40, 0, Me.Width - 40, 0)
        p.AddArc(New Rectangle(Me.Width - 40, 0, 40, 40), -90, 90)
        p.AddLine(Me.Width, 40, Me.Width, Me.Height - 40)
        p.AddArc(New Rectangle(Me.Width - 40, Me.Height - 40, 40, 40), 0, 90)
        p.AddLine(Me.Width - 40, Me.Height, 40, Me.Height)
        p.AddArc(New Rectangle(0, Me.Height - 40, 40, 40), 90, 90)
        p.CloseFigure()
        Me.Region = New Region(p)
        Me.BackColor = Color.Red
    End Sub


    '--------------------------------------'
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EstiloFormulario()

    End Sub

    Private Sub btn_uncheck_Click(sender As Object, e As EventArgs) Handles btn_uncheck.Click
        txt_contrasena.PasswordChar = "*"
        btn_uncheck.Hide()
        btncheck.Show()
    End Sub

    Private Sub btncheck_Click(sender As Object, e As EventArgs) Handles btncheck.Click
        txt_contrasena.PasswordChar = ""
        btncheck.Hide()
        btn_uncheck.Show()
    End Sub

    Private Sub btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub btn_IniciarSesion_Click(sender As Object, e As EventArgs) Handles btn_IniciarSesion.Click
        fun.IniciarSesion()

    End Sub
End Class