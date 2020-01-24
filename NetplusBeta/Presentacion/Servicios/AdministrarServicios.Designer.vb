<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdministrarServicios
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
        Me.PanelRaiz = New System.Windows.Forms.Panel()
        Me.cb_id_plan = New System.Windows.Forms.ComboBox()
        Me.imagen_buscar = New System.Windows.Forms.PictureBox()
        Me.txt_buscartipoSERVICIO = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.tablaServicios = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btn_registrar = New System.Windows.Forms.Button()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_tipoServicio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_codServicio = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ActualizarCampos = New System.Windows.Forms.PictureBox()
        Me.PanelRaiz.SuspendLayout()
        CType(Me.imagen_buscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tablaServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ActualizarCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelRaiz
        '
        Me.PanelRaiz.BackgroundImage = Global.NetplusBeta.My.Resources.Resources.fondo1
        Me.PanelRaiz.Controls.Add(Me.ActualizarCampos)
        Me.PanelRaiz.Controls.Add(Me.cb_id_plan)
        Me.PanelRaiz.Controls.Add(Me.imagen_buscar)
        Me.PanelRaiz.Controls.Add(Me.txt_buscartipoSERVICIO)
        Me.PanelRaiz.Controls.Add(Me.Label9)
        Me.PanelRaiz.Controls.Add(Me.btn_eliminar)
        Me.PanelRaiz.Controls.Add(Me.btn_actualizar)
        Me.PanelRaiz.Controls.Add(Me.tablaServicios)
        Me.PanelRaiz.Controls.Add(Me.btn_registrar)
        Me.PanelRaiz.Controls.Add(Me.txt_precio)
        Me.PanelRaiz.Controls.Add(Me.Label3)
        Me.PanelRaiz.Controls.Add(Me.txt_tipoServicio)
        Me.PanelRaiz.Controls.Add(Me.Label4)
        Me.PanelRaiz.Controls.Add(Me.txt_codServicio)
        Me.PanelRaiz.Controls.Add(Me.Label10)
        Me.PanelRaiz.Controls.Add(Me.Label2)
        Me.PanelRaiz.Controls.Add(Me.Panel1)
        Me.PanelRaiz.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelRaiz.Location = New System.Drawing.Point(0, 0)
        Me.PanelRaiz.Name = "PanelRaiz"
        Me.PanelRaiz.Size = New System.Drawing.Size(1624, 1055)
        Me.PanelRaiz.TabIndex = 4
        '
        'cb_id_plan
        '
        Me.cb_id_plan.FormattingEnabled = True
        Me.cb_id_plan.Location = New System.Drawing.Point(56, 766)
        Me.cb_id_plan.Name = "cb_id_plan"
        Me.cb_id_plan.Size = New System.Drawing.Size(349, 24)
        Me.cb_id_plan.TabIndex = 69
        '
        'imagen_buscar
        '
        Me.imagen_buscar.BackColor = System.Drawing.Color.Transparent
        Me.imagen_buscar.BackgroundImage = Global.NetplusBeta.My.Resources.Resources.buscar
        Me.imagen_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imagen_buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imagen_buscar.Location = New System.Drawing.Point(1265, 204)
        Me.imagen_buscar.Margin = New System.Windows.Forms.Padding(4)
        Me.imagen_buscar.Name = "imagen_buscar"
        Me.imagen_buscar.Size = New System.Drawing.Size(49, 38)
        Me.imagen_buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imagen_buscar.TabIndex = 68
        Me.imagen_buscar.TabStop = False
        '
        'txt_buscartipoSERVICIO
        '
        Me.txt_buscartipoSERVICIO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_buscartipoSERVICIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_buscartipoSERVICIO.Location = New System.Drawing.Point(898, 204)
        Me.txt_buscartipoSERVICIO.Name = "txt_buscartipoSERVICIO"
        Me.txt_buscartipoSERVICIO.Size = New System.Drawing.Size(348, 38)
        Me.txt_buscartipoSERVICIO.TabIndex = 67
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(954, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(256, 25)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "Buscar por Tipo Servicio:"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btn_eliminar.FlatAppearance.BorderSize = 0
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.ForeColor = System.Drawing.Color.White
        Me.btn_eliminar.Image = Global.NetplusBeta.My.Resources.Resources.borrar_cliente
        Me.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_eliminar.Location = New System.Drawing.Point(475, 324)
        Me.btn_eliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(219, 60)
        Me.btn_eliminar.TabIndex = 65
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_actualizar
        '
        Me.btn_actualizar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_actualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btn_actualizar.FlatAppearance.BorderSize = 0
        Me.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_actualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_actualizar.ForeColor = System.Drawing.Color.White
        Me.btn_actualizar.Image = Global.NetplusBeta.My.Resources.Resources.actualizar_cliente
        Me.btn_actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_actualizar.Location = New System.Drawing.Point(961, 324)
        Me.btn_actualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(219, 60)
        Me.btn_actualizar.TabIndex = 64
        Me.btn_actualizar.Text = "Actualizar"
        Me.btn_actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_actualizar.UseVisualStyleBackColor = False
        '
        'tablaServicios
        '
        Me.tablaServicios.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.tablaServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaServicios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.tablaServicios.Location = New System.Drawing.Point(475, 407)
        Me.tablaServicios.Name = "tablaServicios"
        Me.tablaServicios.RowHeadersWidth = 51
        Me.tablaServicios.RowTemplate.Height = 24
        Me.tablaServicios.Size = New System.Drawing.Size(1099, 513)
        Me.tablaServicios.TabIndex = 63
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.MinimumWidth = 6
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Width = 125
        '
        'btn_registrar
        '
        Me.btn_registrar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_registrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_registrar.FlatAppearance.BorderSize = 0
        Me.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_registrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registrar.ForeColor = System.Drawing.Color.White
        Me.btn_registrar.Image = Global.NetplusBeta.My.Resources.Resources.registrar_cliente
        Me.btn_registrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_registrar.Location = New System.Drawing.Point(1355, 324)
        Me.btn_registrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(219, 60)
        Me.btn_registrar.TabIndex = 62
        Me.btn_registrar.Text = "Registrar"
        Me.btn_registrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_registrar.UseVisualStyleBackColor = False
        '
        'txt_precio
        '
        Me.txt_precio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_precio.Location = New System.Drawing.Point(57, 665)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(348, 27)
        Me.txt_precio.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 623)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 25)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Precio:"
        '
        'txt_tipoServicio
        '
        Me.txt_tipoServicio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_tipoServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tipoServicio.Location = New System.Drawing.Point(56, 570)
        Me.txt_tipoServicio.Name = "txt_tipoServicio"
        Me.txt_tipoServicio.Size = New System.Drawing.Size(348, 27)
        Me.txt_tipoServicio.TabIndex = 55
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(53, 528)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 25)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Tipo de Servicio"
        '
        'txt_codServicio
        '
        Me.txt_codServicio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_codServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codServicio.Location = New System.Drawing.Point(56, 479)
        Me.txt_codServicio.Name = "txt_codServicio"
        Me.txt_codServicio.Size = New System.Drawing.Size(348, 27)
        Me.txt_codServicio.TabIndex = 53
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(53, 437)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(138, 25)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Cod-Servicio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 713)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 25)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Id-Plan:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1624, 56)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(357, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Administrar Servicios"
        '
        'ActualizarCampos
        '
        Me.ActualizarCampos.BackColor = System.Drawing.Color.Transparent
        Me.ActualizarCampos.BackgroundImage = Global.NetplusBeta.My.Resources.Resources.actualizar_cliente
        Me.ActualizarCampos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ActualizarCampos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ActualizarCampos.Location = New System.Drawing.Point(1474, 81)
        Me.ActualizarCampos.Name = "ActualizarCampos"
        Me.ActualizarCampos.Size = New System.Drawing.Size(100, 50)
        Me.ActualizarCampos.TabIndex = 53
        Me.ActualizarCampos.TabStop = False
        '
        'AdministrarServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1624, 1055)
        Me.Controls.Add(Me.PanelRaiz)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AdministrarServicios"
        Me.Text = "AdministrarServicios"
        Me.PanelRaiz.ResumeLayout(False)
        Me.PanelRaiz.PerformLayout()
        CType(Me.imagen_buscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tablaServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ActualizarCampos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelRaiz As Panel
    Friend WithEvents imagen_buscar As PictureBox
    Friend WithEvents txt_buscartipoSERVICIO As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_actualizar As Button
    Friend WithEvents tablaServicios As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents btn_registrar As Button
    Friend WithEvents txt_precio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_tipoServicio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cb_id_plan As ComboBox
    Friend WithEvents txt_codServicio As TextBox
    Friend WithEvents ActualizarCampos As PictureBox
End Class
