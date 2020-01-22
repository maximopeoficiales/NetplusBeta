<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultarContratos
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.tablaContratos = New System.Windows.Forms.DataGridView()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.checkDNI = New System.Windows.Forms.RadioButton()
        Me.checkfecha = New System.Windows.Forms.RadioButton()
        Me.txt_dni = New System.Windows.Forms.TextBox()
        Me.fechaconsulta1 = New System.Windows.Forms.DateTimePicker()
        Me.fechaconsulta2 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btn_nuevo_contrato = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelRaiz.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tablaContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelRaiz
        '
        Me.PanelRaiz.BackgroundImage = Global.NetplusBeta.My.Resources.Resources.fondo1
        Me.PanelRaiz.Controls.Add(Me.PictureBox2)
        Me.PanelRaiz.Controls.Add(Me.tablaContratos)
        Me.PanelRaiz.Controls.Add(Me.btn_actualizar)
        Me.PanelRaiz.Controls.Add(Me.checkDNI)
        Me.PanelRaiz.Controls.Add(Me.checkfecha)
        Me.PanelRaiz.Controls.Add(Me.txt_dni)
        Me.PanelRaiz.Controls.Add(Me.fechaconsulta1)
        Me.PanelRaiz.Controls.Add(Me.fechaconsulta2)
        Me.PanelRaiz.Controls.Add(Me.Label9)
        Me.PanelRaiz.Controls.Add(Me.Panel1)
        Me.PanelRaiz.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelRaiz.Location = New System.Drawing.Point(0, 0)
        Me.PanelRaiz.Name = "PanelRaiz"
        Me.PanelRaiz.Size = New System.Drawing.Size(1624, 1080)
        Me.PanelRaiz.TabIndex = 6
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.NetplusBeta.My.Resources.Resources.toma_de_decisiones
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(873, 201)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 84
        Me.PictureBox2.TabStop = False
        '
        'tablaContratos
        '
        Me.tablaContratos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.tablaContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaContratos.Location = New System.Drawing.Point(274, 480)
        Me.tablaContratos.Name = "tablaContratos"
        Me.tablaContratos.RowHeadersWidth = 51
        Me.tablaContratos.RowTemplate.Height = 24
        Me.tablaContratos.Size = New System.Drawing.Size(1099, 538)
        Me.tablaContratos.TabIndex = 81
        '
        'btn_actualizar
        '
        Me.btn_actualizar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_actualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btn_actualizar.FlatAppearance.BorderSize = 0
        Me.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_actualizar.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_actualizar.ForeColor = System.Drawing.Color.White
        Me.btn_actualizar.Image = Global.NetplusBeta.My.Resources.Resources.buscar
        Me.btn_actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_actualizar.Location = New System.Drawing.Point(1389, 182)
        Me.btn_actualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(204, 80)
        Me.btn_actualizar.TabIndex = 79
        Me.btn_actualizar.Text = "Buscar"
        Me.btn_actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_actualizar.UseVisualStyleBackColor = False
        '
        'checkDNI
        '
        Me.checkDNI.AutoSize = True
        Me.checkDNI.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkDNI.Location = New System.Drawing.Point(274, 282)
        Me.checkDNI.Name = "checkDNI"
        Me.checkDNI.Size = New System.Drawing.Size(162, 38)
        Me.checkDNI.TabIndex = 78
        Me.checkDNI.TabStop = True
        Me.checkDNI.Text = "Por DNI"
        Me.checkDNI.UseVisualStyleBackColor = True
        '
        'checkfecha
        '
        Me.checkfecha.AutoSize = True
        Me.checkfecha.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkfecha.Location = New System.Drawing.Point(274, 201)
        Me.checkfecha.Name = "checkfecha"
        Me.checkfecha.Size = New System.Drawing.Size(209, 38)
        Me.checkfecha.TabIndex = 77
        Me.checkfecha.TabStop = True
        Me.checkfecha.Text = "Por Fechas"
        Me.checkfecha.UseVisualStyleBackColor = True
        '
        'txt_dni
        '
        Me.txt_dni.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dni.Location = New System.Drawing.Point(505, 293)
        Me.txt_dni.Name = "txt_dni"
        Me.txt_dni.Size = New System.Drawing.Size(348, 27)
        Me.txt_dni.TabIndex = 76
        '
        'fechaconsulta1
        '
        Me.fechaconsulta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechaconsulta1.Location = New System.Drawing.Point(505, 208)
        Me.fechaconsulta1.Name = "fechaconsulta1"
        Me.fechaconsulta1.Size = New System.Drawing.Size(348, 28)
        Me.fechaconsulta1.TabIndex = 75
        '
        'fechaconsulta2
        '
        Me.fechaconsulta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechaconsulta2.Location = New System.Drawing.Point(992, 208)
        Me.fechaconsulta2.Name = "fechaconsulta2"
        Me.fechaconsulta2.Size = New System.Drawing.Size(348, 28)
        Me.fechaconsulta2.TabIndex = 74
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(582, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(541, 38)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "Consultar por Fechas de Contrato"
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
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Consultar Contrato"
        '
        'btn_nuevo_contrato
        '
        Me.btn_nuevo_contrato.AutoSize = True
        Me.btn_nuevo_contrato.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_nuevo_contrato.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nuevo_contrato.ForeColor = System.Drawing.Color.White
        Me.btn_nuevo_contrato.Location = New System.Drawing.Point(678, 0)
        Me.btn_nuevo_contrato.Name = "btn_nuevo_contrato"
        Me.btn_nuevo_contrato.Size = New System.Drawing.Size(257, 34)
        Me.btn_nuevo_contrato.TabIndex = 5
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
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nuevo Contrato"
        '
        'ConsultarContratos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1624, 1080)
        Me.Controls.Add(Me.PanelRaiz)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ConsultarContratos"
        Me.Text = "AdministrarContratos"
        Me.PanelRaiz.ResumeLayout(False)
        Me.PanelRaiz.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tablaContratos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelRaiz As Panel
    Friend WithEvents fechaconsulta1 As DateTimePicker
    Friend WithEvents fechaconsulta2 As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents checkDNI As RadioButton
    Friend WithEvents checkfecha As RadioButton
    Friend WithEvents txt_dni As TextBox
    Friend WithEvents btn_actualizar As Button
    Friend WithEvents tablaContratos As DataGridView
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btn_nuevo_contrato As Label
    Friend WithEvents Label1 As Label
End Class
