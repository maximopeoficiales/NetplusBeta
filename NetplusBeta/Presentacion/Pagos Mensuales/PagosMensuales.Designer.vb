<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PagosMensuales
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelRaiz = New System.Windows.Forms.Panel()
        Me.txt_pagoPendientes = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_estadoPago = New System.Windows.Forms.ComboBox()
        Me.txt_BuscarFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.btn_BuscarPorFecha = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_fechapagada = New System.Windows.Forms.DateTimePicker()
        Me.txt_fechapago = New System.Windows.Forms.DateTimePicker()
        Me.imagen_buscar = New System.Windows.Forms.PictureBox()
        Me.txt_buscardni = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.tablaMensualidades = New System.Windows.Forms.DataGridView()
        Me.btn_AgregarFechaPAGO = New System.Windows.Forms.Button()
        Me.txt_dni = New System.Windows.Forms.TextBox()
        Me.txt_idContrato = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_pagomensual = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_id_pagomensual = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ActualizarCampos = New System.Windows.Forms.PictureBox()
        Me.PanelRaiz.SuspendLayout()
        CType(Me.btn_BuscarPorFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagen_buscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tablaMensualidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ActualizarCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelRaiz
        '
        Me.PanelRaiz.BackgroundImage = Global.NetplusBeta.My.Resources.Resources.fondo1
        Me.PanelRaiz.Controls.Add(Me.ActualizarCampos)
        Me.PanelRaiz.Controls.Add(Me.txt_pagoPendientes)
        Me.PanelRaiz.Controls.Add(Me.Label11)
        Me.PanelRaiz.Controls.Add(Me.Button1)
        Me.PanelRaiz.Controls.Add(Me.txt_estadoPago)
        Me.PanelRaiz.Controls.Add(Me.txt_BuscarFechaPago)
        Me.PanelRaiz.Controls.Add(Me.btn_BuscarPorFecha)
        Me.PanelRaiz.Controls.Add(Me.Label7)
        Me.PanelRaiz.Controls.Add(Me.txt_fechapagada)
        Me.PanelRaiz.Controls.Add(Me.txt_fechapago)
        Me.PanelRaiz.Controls.Add(Me.imagen_buscar)
        Me.PanelRaiz.Controls.Add(Me.txt_buscardni)
        Me.PanelRaiz.Controls.Add(Me.Label9)
        Me.PanelRaiz.Controls.Add(Me.btn_actualizar)
        Me.PanelRaiz.Controls.Add(Me.tablaMensualidades)
        Me.PanelRaiz.Controls.Add(Me.btn_AgregarFechaPAGO)
        Me.PanelRaiz.Controls.Add(Me.txt_dni)
        Me.PanelRaiz.Controls.Add(Me.txt_idContrato)
        Me.PanelRaiz.Controls.Add(Me.Label8)
        Me.PanelRaiz.Controls.Add(Me.Label6)
        Me.PanelRaiz.Controls.Add(Me.txt_pagomensual)
        Me.PanelRaiz.Controls.Add(Me.Label5)
        Me.PanelRaiz.Controls.Add(Me.Label3)
        Me.PanelRaiz.Controls.Add(Me.Label4)
        Me.PanelRaiz.Controls.Add(Me.txt_id_pagomensual)
        Me.PanelRaiz.Controls.Add(Me.Label10)
        Me.PanelRaiz.Controls.Add(Me.Label2)
        Me.PanelRaiz.Controls.Add(Me.Panel1)
        Me.PanelRaiz.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelRaiz.Location = New System.Drawing.Point(0, 0)
        Me.PanelRaiz.Name = "PanelRaiz"
        Me.PanelRaiz.Size = New System.Drawing.Size(1624, 1055)
        Me.PanelRaiz.TabIndex = 4
        '
        'txt_pagoPendientes
        '
        Me.txt_pagoPendientes.AutoSize = True
        Me.txt_pagoPendientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pagoPendientes.Location = New System.Drawing.Point(999, 965)
        Me.txt_pagoPendientes.Name = "txt_pagoPendientes"
        Me.txt_pagoPendientes.Size = New System.Drawing.Size(49, 32)
        Me.txt_pagoPendientes.TabIndex = 77
        Me.txt_pagoPendientes.Text = "30"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(540, 965)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(431, 32)
        Me.Label11.TabIndex = 77
        Me.Label11.Text = "Pagos Pendientes Del Cliente:"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.NetplusBeta.My.Resources.Resources.actualizar_cliente
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(475, 324)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(219, 60)
        Me.Button1.TabIndex = 76
        Me.Button1.Text = "Refrescar Tabla"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_estadoPago
        '
        Me.txt_estadoPago.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_estadoPago.FormattingEnabled = True
        Me.txt_estadoPago.Items.AddRange(New Object() {"PAGO", "NO PAGO"})
        Me.txt_estadoPago.Location = New System.Drawing.Point(51, 397)
        Me.txt_estadoPago.Name = "txt_estadoPago"
        Me.txt_estadoPago.Size = New System.Drawing.Size(348, 33)
        Me.txt_estadoPago.TabIndex = 75
        '
        'txt_BuscarFechaPago
        '
        Me.txt_BuscarFechaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BuscarFechaPago.Location = New System.Drawing.Point(1158, 196)
        Me.txt_BuscarFechaPago.Name = "txt_BuscarFechaPago"
        Me.txt_BuscarFechaPago.Size = New System.Drawing.Size(348, 28)
        Me.txt_BuscarFechaPago.TabIndex = 74
        '
        'btn_BuscarPorFecha
        '
        Me.btn_BuscarPorFecha.BackColor = System.Drawing.Color.Transparent
        Me.btn_BuscarPorFecha.BackgroundImage = Global.NetplusBeta.My.Resources.Resources.buscar
        Me.btn_BuscarPorFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_BuscarPorFecha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_BuscarPorFecha.Location = New System.Drawing.Point(1525, 196)
        Me.btn_BuscarPorFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_BuscarPorFecha.Name = "btn_BuscarPorFecha"
        Me.btn_BuscarPorFecha.Size = New System.Drawing.Size(49, 38)
        Me.btn_BuscarPorFecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_BuscarPorFecha.TabIndex = 73
        Me.btn_BuscarPorFecha.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1220, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(262, 25)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Buscar por Fecha Pagada"
        '
        'txt_fechapagada
        '
        Me.txt_fechapagada.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fechapagada.Location = New System.Drawing.Point(51, 574)
        Me.txt_fechapagada.Name = "txt_fechapagada"
        Me.txt_fechapagada.Size = New System.Drawing.Size(348, 28)
        Me.txt_fechapagada.TabIndex = 70
        '
        'txt_fechapago
        '
        Me.txt_fechapago.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fechapago.Location = New System.Drawing.Point(51, 486)
        Me.txt_fechapago.Name = "txt_fechapago"
        Me.txt_fechapago.Size = New System.Drawing.Size(348, 28)
        Me.txt_fechapago.TabIndex = 69
        '
        'imagen_buscar
        '
        Me.imagen_buscar.BackColor = System.Drawing.Color.Transparent
        Me.imagen_buscar.BackgroundImage = Global.NetplusBeta.My.Resources.Resources.buscar
        Me.imagen_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imagen_buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imagen_buscar.Location = New System.Drawing.Point(842, 196)
        Me.imagen_buscar.Margin = New System.Windows.Forms.Padding(4)
        Me.imagen_buscar.Name = "imagen_buscar"
        Me.imagen_buscar.Size = New System.Drawing.Size(49, 38)
        Me.imagen_buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imagen_buscar.TabIndex = 68
        Me.imagen_buscar.TabStop = False
        '
        'txt_buscardni
        '
        Me.txt_buscardni.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_buscardni.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_buscardni.Location = New System.Drawing.Point(475, 196)
        Me.txt_buscardni.Name = "txt_buscardni"
        Me.txt_buscardni.Size = New System.Drawing.Size(348, 38)
        Me.txt_buscardni.TabIndex = 67
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(561, 141)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(165, 25)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "Buscar por DNI:"
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
        'tablaMensualidades
        '
        Me.tablaMensualidades.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.tablaMensualidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaMensualidades.Location = New System.Drawing.Point(475, 407)
        Me.tablaMensualidades.Name = "tablaMensualidades"
        Me.tablaMensualidades.RowHeadersWidth = 51
        Me.tablaMensualidades.RowTemplate.Height = 24
        Me.tablaMensualidades.Size = New System.Drawing.Size(1099, 513)
        Me.tablaMensualidades.TabIndex = 63
        '
        'btn_AgregarFechaPAGO
        '
        Me.btn_AgregarFechaPAGO.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_AgregarFechaPAGO.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_AgregarFechaPAGO.FlatAppearance.BorderSize = 0
        Me.btn_AgregarFechaPAGO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AgregarFechaPAGO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AgregarFechaPAGO.ForeColor = System.Drawing.Color.White
        Me.btn_AgregarFechaPAGO.Image = Global.NetplusBeta.My.Resources.Resources.registrar_cliente
        Me.btn_AgregarFechaPAGO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_AgregarFechaPAGO.Location = New System.Drawing.Point(1355, 324)
        Me.btn_AgregarFechaPAGO.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_AgregarFechaPAGO.Name = "btn_AgregarFechaPAGO"
        Me.btn_AgregarFechaPAGO.Size = New System.Drawing.Size(219, 60)
        Me.btn_AgregarFechaPAGO.TabIndex = 62
        Me.btn_AgregarFechaPAGO.Text = "Agregar Fecha Pago"
        Me.btn_AgregarFechaPAGO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_AgregarFechaPAGO.UseVisualStyleBackColor = False
        '
        'txt_dni
        '
        Me.txt_dni.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dni.Location = New System.Drawing.Point(55, 860)
        Me.txt_dni.Name = "txt_dni"
        Me.txt_dni.Size = New System.Drawing.Size(348, 27)
        Me.txt_dni.TabIndex = 61
        '
        'txt_idContrato
        '
        Me.txt_idContrato.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_idContrato.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idContrato.Location = New System.Drawing.Point(53, 750)
        Me.txt_idContrato.Name = "txt_idContrato"
        Me.txt_idContrato.Size = New System.Drawing.Size(348, 27)
        Me.txt_idContrato.TabIndex = 61
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(52, 818)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 25)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "DNI-Cliente"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(50, 708)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 25)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Id-Contrato"
        '
        'txt_pagomensual
        '
        Me.txt_pagomensual.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_pagomensual.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pagomensual.Location = New System.Drawing.Point(55, 657)
        Me.txt_pagomensual.Name = "txt_pagomensual"
        Me.txt_pagomensual.Size = New System.Drawing.Size(348, 27)
        Me.txt_pagomensual.TabIndex = 59
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(52, 615)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 25)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Pago Mensual"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 442)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 25)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Fecha de Pago"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 347)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 25)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Estado Pago:"
        '
        'txt_id_pagomensual
        '
        Me.txt_id_pagomensual.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_id_pagomensual.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_pagomensual.Location = New System.Drawing.Point(51, 298)
        Me.txt_id_pagomensual.Name = "txt_id_pagomensual"
        Me.txt_id_pagomensual.Size = New System.Drawing.Size(348, 27)
        Me.txt_id_pagomensual.TabIndex = 53
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(48, 256)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(161, 25)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Id-Mensualidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 532)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 25)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Fecha Pagada"
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
        Me.Label1.Size = New System.Drawing.Size(451, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Administrar Mensualidades"
        '
        'ActualizarCampos
        '
        Me.ActualizarCampos.BackColor = System.Drawing.Color.Transparent
        Me.ActualizarCampos.BackgroundImage = Global.NetplusBeta.My.Resources.Resources.actualizar_cliente
        Me.ActualizarCampos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ActualizarCampos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ActualizarCampos.Location = New System.Drawing.Point(1474, 62)
        Me.ActualizarCampos.Name = "ActualizarCampos"
        Me.ActualizarCampos.Size = New System.Drawing.Size(100, 50)
        Me.ActualizarCampos.TabIndex = 51
        Me.ActualizarCampos.TabStop = False
        '
        'PagosMensuales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1624, 1055)
        Me.Controls.Add(Me.PanelRaiz)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "PagosMensuales"
        Me.Text = "Mensualidades"
        Me.PanelRaiz.ResumeLayout(False)
        Me.PanelRaiz.PerformLayout()
        CType(Me.btn_BuscarPorFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagen_buscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tablaMensualidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ActualizarCampos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelRaiz As Panel
    Friend WithEvents txt_BuscarFechaPago As DateTimePicker
    Friend WithEvents btn_BuscarPorFecha As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_fechapago As DateTimePicker
    Friend WithEvents imagen_buscar As PictureBox
    Friend WithEvents txt_buscardni As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_actualizar As Button
    Friend WithEvents tablaMensualidades As DataGridView
    Friend WithEvents btn_AgregarFechaPAGO As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_pagomensual As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_id_pagomensual As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_fechapagada As DateTimePicker
    Friend WithEvents txt_idContrato As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_estadoPago As ComboBox
    Friend WithEvents txt_dni As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_pagoPendientes As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ActualizarCampos As PictureBox
End Class
