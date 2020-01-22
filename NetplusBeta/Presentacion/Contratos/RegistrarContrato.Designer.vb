<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarContrato
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
        Me.txt_pagoInstalacion = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_registrar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.txt_estadoContrato = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_informacionPlan = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.InformacionCliente = New System.Windows.Forms.Panel()
        Me.TablaClienteResumen = New System.Windows.Forms.DataGridView()
        Me.paneltop = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_dniCliente = New System.Windows.Forms.TextBox()
        Me.txt_codEmpleado = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_idServicio = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_fechaInstalacion = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_clienteServicio = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btn_nuevo_contrato = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelRaiz.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.InformacionCliente.SuspendLayout()
        CType(Me.TablaClienteResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.paneltop.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelRaiz
        '
        Me.PanelRaiz.BackgroundImage = Global.NetplusBeta.My.Resources.Resources.fondo1
        Me.PanelRaiz.Controls.Add(Me.txt_pagoInstalacion)
        Me.PanelRaiz.Controls.Add(Me.Label12)
        Me.PanelRaiz.Controls.Add(Me.btn_registrar)
        Me.PanelRaiz.Controls.Add(Me.btn_eliminar)
        Me.PanelRaiz.Controls.Add(Me.txt_estadoContrato)
        Me.PanelRaiz.Controls.Add(Me.Panel3)
        Me.PanelRaiz.Controls.Add(Me.InformacionCliente)
        Me.PanelRaiz.Controls.Add(Me.txt_dniCliente)
        Me.PanelRaiz.Controls.Add(Me.txt_codEmpleado)
        Me.PanelRaiz.Controls.Add(Me.Label6)
        Me.PanelRaiz.Controls.Add(Me.txt_idServicio)
        Me.PanelRaiz.Controls.Add(Me.Label5)
        Me.PanelRaiz.Controls.Add(Me.txt_fechaInstalacion)
        Me.PanelRaiz.Controls.Add(Me.Label3)
        Me.PanelRaiz.Controls.Add(Me.Label4)
        Me.PanelRaiz.Controls.Add(Me.txt_clienteServicio)
        Me.PanelRaiz.Controls.Add(Me.Label10)
        Me.PanelRaiz.Controls.Add(Me.Label2)
        Me.PanelRaiz.Controls.Add(Me.Panel1)
        Me.PanelRaiz.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelRaiz.Location = New System.Drawing.Point(0, 0)
        Me.PanelRaiz.Name = "PanelRaiz"
        Me.PanelRaiz.Size = New System.Drawing.Size(1624, 1055)
        Me.PanelRaiz.TabIndex = 3
        '
        'txt_pagoInstalacion
        '
        Me.txt_pagoInstalacion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_pagoInstalacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_pagoInstalacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pagoInstalacion.Location = New System.Drawing.Point(317, 833)
        Me.txt_pagoInstalacion.Name = "txt_pagoInstalacion"
        Me.txt_pagoInstalacion.Size = New System.Drawing.Size(348, 27)
        Me.txt_pagoInstalacion.TabIndex = 89
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(312, 776)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(174, 25)
        Me.Label12.TabIndex = 88
        Me.Label12.Text = "Pago-Instalacion"
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
        Me.btn_registrar.Location = New System.Drawing.Point(514, 887)
        Me.btn_registrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(149, 60)
        Me.btn_registrar.TabIndex = 87
        Me.btn_registrar.Text = "Registrar"
        Me.btn_registrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_registrar.UseVisualStyleBackColor = False
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
        Me.btn_eliminar.Location = New System.Drawing.Point(315, 887)
        Me.btn_eliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(153, 60)
        Me.btn_eliminar.TabIndex = 86
        Me.btn_eliminar.Text = "Limpiar"
        Me.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'txt_estadoContrato
        '
        Me.txt_estadoContrato.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_estadoContrato.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_estadoContrato.FormattingEnabled = True
        Me.txt_estadoContrato.Items.AddRange(New Object() {"ACTIVO", "INACTIVO", "ANULADO"})
        Me.txt_estadoContrato.Location = New System.Drawing.Point(313, 431)
        Me.txt_estadoContrato.Name = "txt_estadoContrato"
        Me.txt_estadoContrato.Size = New System.Drawing.Size(348, 33)
        Me.txt_estadoContrato.TabIndex = 85
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel3.Controls.Add(Me.txt_informacionPlan)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(761, 564)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(790, 383)
        Me.Panel3.TabIndex = 84
        '
        'txt_informacionPlan
        '
        Me.txt_informacionPlan.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_informacionPlan.Location = New System.Drawing.Point(30, 81)
        Me.txt_informacionPlan.Multiline = True
        Me.txt_informacionPlan.Name = "txt_informacionPlan"
        Me.txt_informacionPlan.Size = New System.Drawing.Size(727, 262)
        Me.txt_informacionPlan.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(790, 44)
        Me.Panel4.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(790, 44)
        Me.Panel5.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(3, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(247, 25)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Informacion del Plan"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(3, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(237, 25)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Cliente-Informacion"
        '
        'InformacionCliente
        '
        Me.InformacionCliente.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.InformacionCliente.Controls.Add(Me.TablaClienteResumen)
        Me.InformacionCliente.Controls.Add(Me.paneltop)
        Me.InformacionCliente.Location = New System.Drawing.Point(753, 185)
        Me.InformacionCliente.Name = "InformacionCliente"
        Me.InformacionCliente.Size = New System.Drawing.Size(788, 367)
        Me.InformacionCliente.TabIndex = 83
        '
        'TablaClienteResumen
        '
        Me.TablaClienteResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaClienteResumen.Location = New System.Drawing.Point(19, 63)
        Me.TablaClienteResumen.Name = "TablaClienteResumen"
        Me.TablaClienteResumen.RowHeadersWidth = 51
        Me.TablaClienteResumen.RowTemplate.Height = 24
        Me.TablaClienteResumen.Size = New System.Drawing.Size(746, 290)
        Me.TablaClienteResumen.TabIndex = 1
        '
        'paneltop
        '
        Me.paneltop.BackColor = System.Drawing.Color.Black
        Me.paneltop.Controls.Add(Me.Panel2)
        Me.paneltop.Controls.Add(Me.Label7)
        Me.paneltop.Dock = System.Windows.Forms.DockStyle.Top
        Me.paneltop.Location = New System.Drawing.Point(0, 0)
        Me.paneltop.Name = "paneltop"
        Me.paneltop.Size = New System.Drawing.Size(788, 44)
        Me.paneltop.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(788, 44)
        Me.Panel2.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(3, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(234, 25)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Informacion Cliente"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(3, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(237, 25)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Cliente-Informacion"
        '
        'txt_dniCliente
        '
        Me.txt_dniCliente.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_dniCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_dniCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dniCliente.Location = New System.Drawing.Point(313, 525)
        Me.txt_dniCliente.Name = "txt_dniCliente"
        Me.txt_dniCliente.Size = New System.Drawing.Size(348, 27)
        Me.txt_dniCliente.TabIndex = 82
        '
        'txt_codEmpleado
        '
        Me.txt_codEmpleado.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_codEmpleado.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codEmpleado.FormattingEnabled = True
        Me.txt_codEmpleado.Location = New System.Drawing.Point(313, 722)
        Me.txt_codEmpleado.Name = "txt_codEmpleado"
        Me.txt_codEmpleado.Size = New System.Drawing.Size(348, 33)
        Me.txt_codEmpleado.TabIndex = 81
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(314, 674)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 25)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Empleado"
        '
        'txt_idServicio
        '
        Me.txt_idServicio.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_idServicio.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idServicio.FormattingEnabled = True
        Me.txt_idServicio.Location = New System.Drawing.Point(313, 620)
        Me.txt_idServicio.Name = "txt_idServicio"
        Me.txt_idServicio.Size = New System.Drawing.Size(348, 33)
        Me.txt_idServicio.TabIndex = 79
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(314, 572)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 25)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Servicio"
        '
        'txt_fechaInstalacion
        '
        Me.txt_fechaInstalacion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_fechaInstalacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fechaInstalacion.Location = New System.Drawing.Point(315, 324)
        Me.txt_fechaInstalacion.Name = "txt_fechaInstalacion"
        Me.txt_fechaInstalacion.Size = New System.Drawing.Size(348, 28)
        Me.txt_fechaInstalacion.TabIndex = 76
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(310, 386)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 25)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Estado Contrato"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(312, 276)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 25)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Fecha-Instalacion"
        '
        'txt_clienteServicio
        '
        Me.txt_clienteServicio.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_clienteServicio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_clienteServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_clienteServicio.Location = New System.Drawing.Point(315, 227)
        Me.txt_clienteServicio.Name = "txt_clienteServicio"
        Me.txt_clienteServicio.Size = New System.Drawing.Size(348, 27)
        Me.txt_clienteServicio.TabIndex = 61
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(312, 185)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 25)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Id-Contrato"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(314, 476)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 25)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Cliente"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.btn_nuevo_contrato)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1624, 56)
        Me.Panel1.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label13.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(1310, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(314, 34)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Consultar Contrato"
        '
        'btn_nuevo_contrato
        '
        Me.btn_nuevo_contrato.AutoSize = True
        Me.btn_nuevo_contrato.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_nuevo_contrato.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nuevo_contrato.ForeColor = System.Drawing.Color.White
        Me.btn_nuevo_contrato.Location = New System.Drawing.Point(680, 0)
        Me.btn_nuevo_contrato.Name = "btn_nuevo_contrato"
        Me.btn_nuevo_contrato.Size = New System.Drawing.Size(257, 34)
        Me.btn_nuevo_contrato.TabIndex = 2
        Me.btn_nuevo_contrato.Text = "Editar Contrato"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nuevo Contrato"
        '
        'RegistrarContrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1624, 1055)
        Me.Controls.Add(Me.PanelRaiz)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "RegistrarContrato"
        Me.Text = "RegistrarContrato"
        Me.PanelRaiz.ResumeLayout(False)
        Me.PanelRaiz.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.InformacionCliente.ResumeLayout(False)
        CType(Me.TablaClienteResumen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.paneltop.ResumeLayout(False)
        Me.paneltop.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelRaiz As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_clienteServicio As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_idServicio As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_fechaInstalacion As DateTimePicker
    Friend WithEvents txt_codEmpleado As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_dniCliente As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents InformacionCliente As Panel
    Friend WithEvents TablaClienteResumen As DataGridView
    Friend WithEvents paneltop As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_estadoContrato As ComboBox
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_registrar As Button
    Friend WithEvents txt_informacionPlan As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btn_nuevo_contrato As Label
    Friend WithEvents txt_pagoInstalacion As TextBox
    Friend WithEvents Label12 As Label
End Class
