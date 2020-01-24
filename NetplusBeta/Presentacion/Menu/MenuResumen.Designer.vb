<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuResumen
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
        Me.PanelMenuInicio = New System.Windows.Forms.Panel()
        Me.PanelRaiz = New System.Windows.Forms.Panel()
        Me.btn_realizarcontrato = New System.Windows.Forms.Button()
        Me.ContadorPlanes = New System.Windows.Forms.Label()
        Me.ContadorServicios = New System.Windows.Forms.Label()
        Me.ContadorClientes = New System.Windows.Forms.Label()
        Me.ContadorEmpleados = New System.Windows.Forms.Label()
        Me.btn_VerServicios = New System.Windows.Forms.Button()
        Me.btn_VerClientes = New System.Windows.Forms.Button()
        Me.btn_VerEmpleados = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_VerGanancias = New System.Windows.Forms.Button()
        Me.btn_VerPlanes = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label_usuario = New System.Windows.Forms.Label()
        Me.ActualizarCampos = New System.Windows.Forms.PictureBox()
        Me.PanelMenuInicio.SuspendLayout()
        Me.PanelRaiz.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActualizarCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenuInicio
        '
        Me.PanelMenuInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelMenuInicio.Controls.Add(Me.PanelRaiz)
        Me.PanelMenuInicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMenuInicio.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenuInicio.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelMenuInicio.Name = "PanelMenuInicio"
        Me.PanelMenuInicio.Size = New System.Drawing.Size(1624, 1080)
        Me.PanelMenuInicio.TabIndex = 1
        '
        'PanelRaiz
        '
        Me.PanelRaiz.BackgroundImage = Global.NetplusBeta.My.Resources.Resources.fondo1
        Me.PanelRaiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelRaiz.Controls.Add(Me.ActualizarCampos)
        Me.PanelRaiz.Controls.Add(Me.btn_realizarcontrato)
        Me.PanelRaiz.Controls.Add(Me.ContadorPlanes)
        Me.PanelRaiz.Controls.Add(Me.ContadorServicios)
        Me.PanelRaiz.Controls.Add(Me.ContadorClientes)
        Me.PanelRaiz.Controls.Add(Me.ContadorEmpleados)
        Me.PanelRaiz.Controls.Add(Me.btn_VerServicios)
        Me.PanelRaiz.Controls.Add(Me.btn_VerClientes)
        Me.PanelRaiz.Controls.Add(Me.btn_VerEmpleados)
        Me.PanelRaiz.Controls.Add(Me.PictureBox2)
        Me.PanelRaiz.Controls.Add(Me.btn_VerGanancias)
        Me.PanelRaiz.Controls.Add(Me.btn_VerPlanes)
        Me.PanelRaiz.Controls.Add(Me.PictureBox1)
        Me.PanelRaiz.Controls.Add(Me.label_usuario)
        Me.PanelRaiz.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelRaiz.Location = New System.Drawing.Point(0, 0)
        Me.PanelRaiz.Name = "PanelRaiz"
        Me.PanelRaiz.Size = New System.Drawing.Size(1624, 1080)
        Me.PanelRaiz.TabIndex = 0
        '
        'btn_realizarcontrato
        '
        Me.btn_realizarcontrato.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_realizarcontrato.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btn_realizarcontrato.FlatAppearance.BorderSize = 0
        Me.btn_realizarcontrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_realizarcontrato.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_realizarcontrato.ForeColor = System.Drawing.Color.White
        Me.btn_realizarcontrato.Image = Global.NetplusBeta.My.Resources.Resources.contrato1
        Me.btn_realizarcontrato.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btn_realizarcontrato.Location = New System.Drawing.Point(1129, 803)
        Me.btn_realizarcontrato.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_realizarcontrato.Name = "btn_realizarcontrato"
        Me.btn_realizarcontrato.Padding = New System.Windows.Forms.Padding(2)
        Me.btn_realizarcontrato.Size = New System.Drawing.Size(420, 134)
        Me.btn_realizarcontrato.TabIndex = 37
        Me.btn_realizarcontrato.Text = "Realizar Contrato"
        Me.btn_realizarcontrato.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_realizarcontrato.UseVisualStyleBackColor = False
        '
        'ContadorPlanes
        '
        Me.ContadorPlanes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ContadorPlanes.AutoSize = True
        Me.ContadorPlanes.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ContadorPlanes.Font = New System.Drawing.Font("Verdana", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContadorPlanes.ForeColor = System.Drawing.Color.White
        Me.ContadorPlanes.Location = New System.Drawing.Point(1140, 475)
        Me.ContadorPlanes.Name = "ContadorPlanes"
        Me.ContadorPlanes.Size = New System.Drawing.Size(63, 40)
        Me.ContadorPlanes.TabIndex = 35
        Me.ContadorPlanes.Text = "30"
        '
        'ContadorServicios
        '
        Me.ContadorServicios.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ContadorServicios.AutoSize = True
        Me.ContadorServicios.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ContadorServicios.Font = New System.Drawing.Font("Verdana", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContadorServicios.ForeColor = System.Drawing.Color.White
        Me.ContadorServicios.Location = New System.Drawing.Point(1140, 268)
        Me.ContadorServicios.Name = "ContadorServicios"
        Me.ContadorServicios.Size = New System.Drawing.Size(63, 40)
        Me.ContadorServicios.TabIndex = 34
        Me.ContadorServicios.Text = "30"
        '
        'ContadorClientes
        '
        Me.ContadorClientes.AutoSize = True
        Me.ContadorClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ContadorClientes.Font = New System.Drawing.Font("Verdana", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContadorClientes.ForeColor = System.Drawing.Color.White
        Me.ContadorClientes.Location = New System.Drawing.Point(583, 255)
        Me.ContadorClientes.Name = "ContadorClientes"
        Me.ContadorClientes.Size = New System.Drawing.Size(63, 40)
        Me.ContadorClientes.TabIndex = 33
        Me.ContadorClientes.Text = "30"
        '
        'ContadorEmpleados
        '
        Me.ContadorEmpleados.AutoSize = True
        Me.ContadorEmpleados.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ContadorEmpleados.Font = New System.Drawing.Font("Verdana", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContadorEmpleados.ForeColor = System.Drawing.Color.White
        Me.ContadorEmpleados.Location = New System.Drawing.Point(49, 255)
        Me.ContadorEmpleados.Name = "ContadorEmpleados"
        Me.ContadorEmpleados.Size = New System.Drawing.Size(63, 40)
        Me.ContadorEmpleados.TabIndex = 32
        Me.ContadorEmpleados.Text = "30"
        '
        'btn_VerServicios
        '
        Me.btn_VerServicios.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_VerServicios.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btn_VerServicios.FlatAppearance.BorderSize = 0
        Me.btn_VerServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_VerServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_VerServicios.ForeColor = System.Drawing.Color.White
        Me.btn_VerServicios.Image = Global.NetplusBeta.My.Resources.Resources.internet2
        Me.btn_VerServicios.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_VerServicios.Location = New System.Drawing.Point(1129, 215)
        Me.btn_VerServicios.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_VerServicios.Name = "btn_VerServicios"
        Me.btn_VerServicios.Padding = New System.Windows.Forms.Padding(2)
        Me.btn_VerServicios.Size = New System.Drawing.Size(420, 134)
        Me.btn_VerServicios.TabIndex = 13
        Me.btn_VerServicios.Text = "Servicios"
        Me.btn_VerServicios.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_VerServicios.UseVisualStyleBackColor = False
        '
        'btn_VerClientes
        '
        Me.btn_VerClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_VerClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_VerClientes.FlatAppearance.BorderSize = 0
        Me.btn_VerClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_VerClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_VerClientes.ForeColor = System.Drawing.Color.White
        Me.btn_VerClientes.Image = Global.NetplusBeta.My.Resources.Resources.clienteprincipal
        Me.btn_VerClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_VerClientes.Location = New System.Drawing.Point(569, 215)
        Me.btn_VerClientes.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_VerClientes.Name = "btn_VerClientes"
        Me.btn_VerClientes.Padding = New System.Windows.Forms.Padding(2)
        Me.btn_VerClientes.Size = New System.Drawing.Size(420, 134)
        Me.btn_VerClientes.TabIndex = 27
        Me.btn_VerClientes.Text = "Clientes Activos"
        Me.btn_VerClientes.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_VerClientes.UseVisualStyleBackColor = False
        '
        'btn_VerEmpleados
        '
        Me.btn_VerEmpleados.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btn_VerEmpleados.FlatAppearance.BorderSize = 0
        Me.btn_VerEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_VerEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_VerEmpleados.ForeColor = System.Drawing.Color.White
        Me.btn_VerEmpleados.Image = Global.NetplusBeta.My.Resources.Resources.users2
        Me.btn_VerEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_VerEmpleados.Location = New System.Drawing.Point(40, 215)
        Me.btn_VerEmpleados.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_VerEmpleados.Name = "btn_VerEmpleados"
        Me.btn_VerEmpleados.Padding = New System.Windows.Forms.Padding(2)
        Me.btn_VerEmpleados.Size = New System.Drawing.Size(420, 134)
        Me.btn_VerEmpleados.TabIndex = 12
        Me.btn_VerEmpleados.Text = "Empleados"
        Me.btn_VerEmpleados.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_VerEmpleados.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.NetplusBeta.My.Resources.Resources.portada
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(44, 389)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(945, 636)
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'btn_VerGanancias
        '
        Me.btn_VerGanancias.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_VerGanancias.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.btn_VerGanancias.FlatAppearance.BorderSize = 0
        Me.btn_VerGanancias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_VerGanancias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_VerGanancias.ForeColor = System.Drawing.Color.White
        Me.btn_VerGanancias.Image = Global.NetplusBeta.My.Resources.Resources.dinero
        Me.btn_VerGanancias.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btn_VerGanancias.Location = New System.Drawing.Point(1129, 616)
        Me.btn_VerGanancias.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_VerGanancias.Name = "btn_VerGanancias"
        Me.btn_VerGanancias.Padding = New System.Windows.Forms.Padding(2)
        Me.btn_VerGanancias.Size = New System.Drawing.Size(420, 134)
        Me.btn_VerGanancias.TabIndex = 31
        Me.btn_VerGanancias.Text = "Ganancias "
        Me.btn_VerGanancias.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_VerGanancias.UseVisualStyleBackColor = False
        '
        'btn_VerPlanes
        '
        Me.btn_VerPlanes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_VerPlanes.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btn_VerPlanes.FlatAppearance.BorderSize = 0
        Me.btn_VerPlanes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_VerPlanes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_VerPlanes.ForeColor = System.Drawing.Color.White
        Me.btn_VerPlanes.Image = Global.NetplusBeta.My.Resources.Resources.pack1
        Me.btn_VerPlanes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_VerPlanes.Location = New System.Drawing.Point(1129, 427)
        Me.btn_VerPlanes.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_VerPlanes.Name = "btn_VerPlanes"
        Me.btn_VerPlanes.Padding = New System.Windows.Forms.Padding(2)
        Me.btn_VerPlanes.Size = New System.Drawing.Size(420, 134)
        Me.btn_VerPlanes.TabIndex = 28
        Me.btn_VerPlanes.Text = "Planes Activos"
        Me.btn_VerPlanes.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_VerPlanes.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.NetplusBeta.My.Resources.Resources.user_empleado1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'label_usuario
        '
        Me.label_usuario.AutoSize = True
        Me.label_usuario.BackColor = System.Drawing.Color.Transparent
        Me.label_usuario.Font = New System.Drawing.Font("Verdana", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_usuario.ForeColor = System.Drawing.Color.Black
        Me.label_usuario.Location = New System.Drawing.Point(118, 42)
        Me.label_usuario.Name = "label_usuario"
        Me.label_usuario.Size = New System.Drawing.Size(184, 46)
        Me.label_usuario.TabIndex = 26
        Me.label_usuario.Text = "Usuario"
        '
        'ActualizarCampos
        '
        Me.ActualizarCampos.BackColor = System.Drawing.Color.Transparent
        Me.ActualizarCampos.BackgroundImage = Global.NetplusBeta.My.Resources.Resources.actualizar_cliente
        Me.ActualizarCampos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ActualizarCampos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ActualizarCampos.Location = New System.Drawing.Point(1449, 12)
        Me.ActualizarCampos.Name = "ActualizarCampos"
        Me.ActualizarCampos.Size = New System.Drawing.Size(100, 50)
        Me.ActualizarCampos.TabIndex = 50
        Me.ActualizarCampos.TabStop = False
        '
        'MenuResumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1624, 1080)
        Me.Controls.Add(Me.PanelMenuInicio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuResumen"
        Me.Text = "MenuResumen"
        Me.PanelMenuInicio.ResumeLayout(False)
        Me.PanelRaiz.ResumeLayout(False)
        Me.PanelRaiz.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActualizarCampos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenuInicio As Panel
    Friend WithEvents PanelRaiz As Panel
    Friend WithEvents label_usuario As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_VerGanancias As Button
    Friend WithEvents btn_VerPlanes As Button
    Friend WithEvents btn_VerClientes As Button
    Friend WithEvents btn_VerServicios As Button
    Friend WithEvents btn_VerEmpleados As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ContadorPlanes As Label
    Friend WithEvents ContadorServicios As Label
    Friend WithEvents ContadorClientes As Label
    Friend WithEvents ContadorEmpleados As Label
    Friend WithEvents btn_realizarcontrato As Button
    Friend WithEvents ActualizarCampos As PictureBox
End Class
