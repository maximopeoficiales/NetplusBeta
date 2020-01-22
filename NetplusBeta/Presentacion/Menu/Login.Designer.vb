<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanelDeLogueo = New System.Windows.Forms.Panel()
        Me.btncheck = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_IniciarSesion = New System.Windows.Forms.Button()
        Me.txt_contrasena = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_uncheck = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.btn_minimizar = New System.Windows.Forms.Button()
        Me.PanelDeLogueo.SuspendLayout()
        CType(Me.btncheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_uncheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelDeLogueo
        '
        Me.PanelDeLogueo.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PanelDeLogueo.Controls.Add(Me.btncheck)
        Me.PanelDeLogueo.Controls.Add(Me.PictureBox2)
        Me.PanelDeLogueo.Controls.Add(Me.btn_IniciarSesion)
        Me.PanelDeLogueo.Controls.Add(Me.txt_contrasena)
        Me.PanelDeLogueo.Controls.Add(Me.Label4)
        Me.PanelDeLogueo.Controls.Add(Me.txt_usuario)
        Me.PanelDeLogueo.Controls.Add(Me.Label10)
        Me.PanelDeLogueo.Controls.Add(Me.btn_uncheck)
        Me.PanelDeLogueo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDeLogueo.Location = New System.Drawing.Point(0, 288)
        Me.PanelDeLogueo.Name = "PanelDeLogueo"
        Me.PanelDeLogueo.Size = New System.Drawing.Size(400, 432)
        Me.PanelDeLogueo.TabIndex = 1
        '
        'btncheck
        '
        Me.btncheck.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncheck.BackgroundImage = Global.NetplusBeta.My.Resources.Resources.checkradio
        Me.btncheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btncheck.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncheck.Location = New System.Drawing.Point(344, 231)
        Me.btncheck.Name = "btncheck"
        Me.btncheck.Size = New System.Drawing.Size(44, 36)
        Me.btncheck.TabIndex = 67
        Me.btncheck.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.BackgroundImage = Global.NetplusBeta.My.Resources.Resources.usuario_login
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(159, 15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(86, 70)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'btn_IniciarSesion
        '
        Me.btn_IniciarSesion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_IniciarSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btn_IniciarSesion.FlatAppearance.BorderSize = 0
        Me.btn_IniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_IniciarSesion.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_IniciarSesion.ForeColor = System.Drawing.Color.White
        Me.btn_IniciarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_IniciarSesion.Location = New System.Drawing.Point(83, 306)
        Me.btn_IniciarSesion.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_IniciarSesion.Name = "btn_IniciarSesion"
        Me.btn_IniciarSesion.Size = New System.Drawing.Size(233, 74)
        Me.btn_IniciarSesion.TabIndex = 66
        Me.btn_IniciarSesion.Text = "Iniciar Sesion"
        Me.btn_IniciarSesion.UseVisualStyleBackColor = False
        '
        'txt_contrasena
        '
        Me.txt_contrasena.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_contrasena.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_contrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contrasena.Location = New System.Drawing.Point(27, 240)
        Me.txt_contrasena.Name = "txt_contrasena"
        Me.txt_contrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_contrasena.Size = New System.Drawing.Size(312, 27)
        Me.txt_contrasena.TabIndex = 59
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(24, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 25)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Contraseña:"
        '
        'txt_usuario
        '
        Me.txt_usuario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuario.Location = New System.Drawing.Point(27, 149)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(339, 27)
        Me.txt_usuario.TabIndex = 57
        '
        'Label10
        '
        Me.Label10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(24, 107)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 25)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "Usuario:"
        '
        'btn_uncheck
        '
        Me.btn_uncheck.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_uncheck.BackgroundImage = Global.NetplusBeta.My.Resources.Resources.uncheck
        Me.btn_uncheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_uncheck.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_uncheck.Location = New System.Drawing.Point(344, 231)
        Me.btn_uncheck.Name = "btn_uncheck"
        Me.btn_uncheck.Size = New System.Drawing.Size(44, 36)
        Me.btn_uncheck.TabIndex = 67
        Me.btn_uncheck.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.NetplusBeta.My.Resources.Resources.portada
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(400, 288)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cerrar.BackColor = System.Drawing.Color.Red
        Me.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_cerrar.FlatAppearance.BorderSize = 0
        Me.btn_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cerrar.ForeColor = System.Drawing.Color.White
        Me.btn_cerrar.Location = New System.Drawing.Point(369, 0)
        Me.btn_cerrar.Margin = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(31, 30)
        Me.btn_cerrar.TabIndex = 68
        Me.btn_cerrar.Text = "X"
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'btn_minimizar
        '
        Me.btn_minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_minimizar.BackColor = System.Drawing.Color.Black
        Me.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_minimizar.FlatAppearance.BorderSize = 0
        Me.btn_minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_minimizar.ForeColor = System.Drawing.Color.White
        Me.btn_minimizar.Location = New System.Drawing.Point(344, 0)
        Me.btn_minimizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(31, 30)
        Me.btn_minimizar.TabIndex = 69
        Me.btn_minimizar.Text = "-"
        Me.btn_minimizar.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 720)
        Me.Controls.Add(Me.btn_minimizar)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.PanelDeLogueo)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de Sesion"
        Me.PanelDeLogueo.ResumeLayout(False)
        Me.PanelDeLogueo.PerformLayout()
        CType(Me.btncheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_uncheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelDeLogueo As Panel
    Friend WithEvents txt_contrasena As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_IniciarSesion As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btncheck As PictureBox
    Friend WithEvents btn_uncheck As PictureBox
    Friend WithEvents btn_cerrar As Button
    Friend WithEvents btn_minimizar As Button
End Class
