<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdministarClientes
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
        Me.imagen_buscar = New System.Windows.Forms.PictureBox()
        Me.txt_dni = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_buscardni = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.tablaclientes = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btn_registrar = New System.Windows.Forms.Button()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_celular = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_zona = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelRaiz.SuspendLayout()
        CType(Me.imagen_buscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tablaclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelRaiz
        '
        Me.PanelRaiz.BackgroundImage = Global.NetplusBeta.My.Resources.Resources.fondo1
        Me.PanelRaiz.Controls.Add(Me.imagen_buscar)
        Me.PanelRaiz.Controls.Add(Me.txt_dni)
        Me.PanelRaiz.Controls.Add(Me.Label10)
        Me.PanelRaiz.Controls.Add(Me.txt_buscardni)
        Me.PanelRaiz.Controls.Add(Me.Label9)
        Me.PanelRaiz.Controls.Add(Me.btn_eliminar)
        Me.PanelRaiz.Controls.Add(Me.btn_actualizar)
        Me.PanelRaiz.Controls.Add(Me.tablaclientes)
        Me.PanelRaiz.Controls.Add(Me.btn_registrar)
        Me.PanelRaiz.Controls.Add(Me.txt_email)
        Me.PanelRaiz.Controls.Add(Me.Label7)
        Me.PanelRaiz.Controls.Add(Me.txt_celular)
        Me.PanelRaiz.Controls.Add(Me.Label6)
        Me.PanelRaiz.Controls.Add(Me.txt_zona)
        Me.PanelRaiz.Controls.Add(Me.Label5)
        Me.PanelRaiz.Controls.Add(Me.txt_direccion)
        Me.PanelRaiz.Controls.Add(Me.Label4)
        Me.PanelRaiz.Controls.Add(Me.txt_nombre)
        Me.PanelRaiz.Controls.Add(Me.Label2)
        Me.PanelRaiz.Controls.Add(Me.Panel1)
        Me.PanelRaiz.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelRaiz.Location = New System.Drawing.Point(0, 0)
        Me.PanelRaiz.Name = "PanelRaiz"
        Me.PanelRaiz.Size = New System.Drawing.Size(1624, 1055)
        Me.PanelRaiz.TabIndex = 1
        '
        'imagen_buscar
        '
        Me.imagen_buscar.BackColor = System.Drawing.Color.Transparent
        Me.imagen_buscar.BackgroundImage = Global.NetplusBeta.My.Resources.Resources.buscar
        Me.imagen_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imagen_buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imagen_buscar.Location = New System.Drawing.Point(1239, 145)
        Me.imagen_buscar.Margin = New System.Windows.Forms.Padding(4)
        Me.imagen_buscar.Name = "imagen_buscar"
        Me.imagen_buscar.Size = New System.Drawing.Size(49, 38)
        Me.imagen_buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imagen_buscar.TabIndex = 45
        Me.imagen_buscar.TabStop = False
        '
        'txt_dni
        '
        Me.txt_dni.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dni.Location = New System.Drawing.Point(39, 287)
        Me.txt_dni.Name = "txt_dni"
        Me.txt_dni.Size = New System.Drawing.Size(348, 27)
        Me.txt_dni.TabIndex = 44
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(36, 245)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 25)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "DNI"
        '
        'txt_buscardni
        '
        Me.txt_buscardni.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_buscardni.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_buscardni.Location = New System.Drawing.Point(872, 145)
        Me.txt_buscardni.Name = "txt_buscardni"
        Me.txt_buscardni.Size = New System.Drawing.Size(348, 38)
        Me.txt_buscardni.TabIndex = 42
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(958, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(165, 25)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Buscar por DNI:"
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
        Me.btn_eliminar.Location = New System.Drawing.Point(468, 275)
        Me.btn_eliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(219, 60)
        Me.btn_eliminar.TabIndex = 40
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
        Me.btn_actualizar.Location = New System.Drawing.Point(954, 275)
        Me.btn_actualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(219, 60)
        Me.btn_actualizar.TabIndex = 39
        Me.btn_actualizar.Text = "Actualizar"
        Me.btn_actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_actualizar.UseVisualStyleBackColor = False
        '
        'tablaclientes
        '
        Me.tablaclientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.tablaclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaclientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.tablaclientes.Location = New System.Drawing.Point(468, 358)
        Me.tablaclientes.Name = "tablaclientes"
        Me.tablaclientes.RowHeadersWidth = 51
        Me.tablaclientes.RowTemplate.Height = 24
        Me.tablaclientes.Size = New System.Drawing.Size(1099, 513)
        Me.tablaclientes.TabIndex = 38
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
        Me.btn_registrar.Location = New System.Drawing.Point(1348, 275)
        Me.btn_registrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(219, 60)
        Me.btn_registrar.TabIndex = 37
        Me.btn_registrar.Text = "Registrar"
        Me.btn_registrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_registrar.UseVisualStyleBackColor = False
        '
        'txt_email
        '
        Me.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(47, 767)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(348, 27)
        Me.txt_email.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(44, 725)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 25)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Email:"
        '
        'txt_celular
        '
        Me.txt_celular.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_celular.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_celular.Location = New System.Drawing.Point(41, 681)
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.Size = New System.Drawing.Size(348, 27)
        Me.txt_celular.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 639)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 25)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Celular:"
        '
        'txt_zona
        '
        Me.txt_zona.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_zona.FormattingEnabled = True
        Me.txt_zona.Items.AddRange(New Object() {"Nuevo Lurin", "Centro Poblado las Palmas", "Julio Cesar Tello", "Cantera", "Lote 5"})
        Me.txt_zona.Location = New System.Drawing.Point(41, 584)
        Me.txt_zona.Name = "txt_zona"
        Me.txt_zona.Size = New System.Drawing.Size(348, 37)
        Me.txt_zona.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 537)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Zona:"
        '
        'txt_direccion
        '
        Me.txt_direccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_direccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_direccion.Location = New System.Drawing.Point(41, 483)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(348, 27)
        Me.txt_direccion.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 441)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Direccion:"
        '
        'txt_nombre
        '
        Me.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.Location = New System.Drawing.Point(41, 378)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(348, 27)
        Me.txt_nombre.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 336)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
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
        Me.Label1.Size = New System.Drawing.Size(342, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Administrar Clientes"
        '
        'AdministarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1624, 1055)
        Me.Controls.Add(Me.PanelRaiz)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdministarClientes"
        Me.Text = "AdministarClientes"
        Me.PanelRaiz.ResumeLayout(False)
        Me.PanelRaiz.PerformLayout()
        CType(Me.imagen_buscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tablaclientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelRaiz As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_celular As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_zona As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_direccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_registrar As Button
    Friend WithEvents tablaclientes As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_actualizar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_buscardni As TextBox
    Friend WithEvents txt_dni As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents imagen_buscar As PictureBox
End Class
