<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdministrarGanancias
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
        Me.btn_GananciasporRango = New System.Windows.Forms.Button()
        Me.PanelConDinero = New System.Windows.Forms.Panel()
        Me.txt_ganancias = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fecha1 = New System.Windows.Forms.DateTimePicker()
        Me.fecha2 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_TodasGanancia = New System.Windows.Forms.Button()
        Me.tablaGanancias = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelRaiz.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelConDinero.SuspendLayout()
        CType(Me.tablaGanancias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelRaiz
        '
        Me.PanelRaiz.BackgroundImage = Global.NetplusBeta.My.Resources.Resources.fondo1
        Me.PanelRaiz.Controls.Add(Me.PictureBox2)
        Me.PanelRaiz.Controls.Add(Me.btn_GananciasporRango)
        Me.PanelRaiz.Controls.Add(Me.PanelConDinero)
        Me.PanelRaiz.Controls.Add(Me.fecha1)
        Me.PanelRaiz.Controls.Add(Me.fecha2)
        Me.PanelRaiz.Controls.Add(Me.Label9)
        Me.PanelRaiz.Controls.Add(Me.btn_TodasGanancia)
        Me.PanelRaiz.Controls.Add(Me.tablaGanancias)
        Me.PanelRaiz.Controls.Add(Me.Panel1)
        Me.PanelRaiz.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelRaiz.Location = New System.Drawing.Point(0, 0)
        Me.PanelRaiz.Name = "PanelRaiz"
        Me.PanelRaiz.Size = New System.Drawing.Size(1624, 1080)
        Me.PanelRaiz.TabIndex = 5
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.NetplusBeta.My.Resources.Resources.toma_de_decisiones
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(817, 195)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 85
        Me.PictureBox2.TabStop = False
        '
        'btn_GananciasporRango
        '
        Me.btn_GananciasporRango.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_GananciasporRango.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btn_GananciasporRango.FlatAppearance.BorderSize = 0
        Me.btn_GananciasporRango.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_GananciasporRango.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_GananciasporRango.ForeColor = System.Drawing.Color.White
        Me.btn_GananciasporRango.Image = Global.NetplusBeta.My.Resources.Resources.buscar
        Me.btn_GananciasporRango.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_GananciasporRango.Location = New System.Drawing.Point(1190, 253)
        Me.btn_GananciasporRango.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_GananciasporRango.Name = "btn_GananciasporRango"
        Me.btn_GananciasporRango.Size = New System.Drawing.Size(316, 107)
        Me.btn_GananciasporRango.TabIndex = 77
        Me.btn_GananciasporRango.Text = "Buscar"
        Me.btn_GananciasporRango.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_GananciasporRango.UseVisualStyleBackColor = False
        '
        'PanelConDinero
        '
        Me.PanelConDinero.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PanelConDinero.Controls.Add(Me.txt_ganancias)
        Me.PanelConDinero.Controls.Add(Me.Label2)
        Me.PanelConDinero.Location = New System.Drawing.Point(407, 948)
        Me.PanelConDinero.Name = "PanelConDinero"
        Me.PanelConDinero.Size = New System.Drawing.Size(830, 84)
        Me.PanelConDinero.TabIndex = 76
        '
        'txt_ganancias
        '
        Me.txt_ganancias.AutoSize = True
        Me.txt_ganancias.Font = New System.Drawing.Font("Verdana", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ganancias.ForeColor = System.Drawing.Color.White
        Me.txt_ganancias.Location = New System.Drawing.Point(519, 24)
        Me.txt_ganancias.Name = "txt_ganancias"
        Me.txt_ganancias.Size = New System.Drawing.Size(109, 40)
        Me.txt_ganancias.TabIndex = 1
        Me.txt_ganancias.Text = "3000"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(90, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(279, 40)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Se ganado S./"
        '
        'fecha1
        '
        Me.fecha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha1.Location = New System.Drawing.Point(407, 195)
        Me.fecha1.Name = "fecha1"
        Me.fecha1.Size = New System.Drawing.Size(348, 28)
        Me.fecha1.TabIndex = 75
        '
        'fecha2
        '
        Me.fecha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha2.Location = New System.Drawing.Point(975, 195)
        Me.fecha2.Name = "fecha2"
        Me.fecha2.Size = New System.Drawing.Size(348, 28)
        Me.fecha2.TabIndex = 74
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(676, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(350, 38)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "Consultar por Fechas"
        '
        'btn_TodasGanancia
        '
        Me.btn_TodasGanancia.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_TodasGanancia.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btn_TodasGanancia.FlatAppearance.BorderSize = 0
        Me.btn_TodasGanancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_TodasGanancia.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_TodasGanancia.ForeColor = System.Drawing.Color.White
        Me.btn_TodasGanancia.Image = Global.NetplusBeta.My.Resources.Resources.dinero1
        Me.btn_TodasGanancia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_TodasGanancia.Location = New System.Drawing.Point(102, 262)
        Me.btn_TodasGanancia.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_TodasGanancia.Name = "btn_TodasGanancia"
        Me.btn_TodasGanancia.Size = New System.Drawing.Size(316, 107)
        Me.btn_TodasGanancia.TabIndex = 64
        Me.btn_TodasGanancia.Text = "Mostrar todas"
        Me.btn_TodasGanancia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_TodasGanancia.UseVisualStyleBackColor = False
        '
        'tablaGanancias
        '
        Me.tablaGanancias.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.tablaGanancias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaGanancias.Location = New System.Drawing.Point(102, 396)
        Me.tablaGanancias.Name = "tablaGanancias"
        Me.tablaGanancias.RowHeadersWidth = 51
        Me.tablaGanancias.RowTemplate.Height = 24
        Me.tablaGanancias.Size = New System.Drawing.Size(1404, 521)
        Me.tablaGanancias.TabIndex = 63
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
        Me.Label1.Size = New System.Drawing.Size(377, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Administrar Ganancias"
        '
        'AdministrarGanancias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1624, 1080)
        Me.Controls.Add(Me.PanelRaiz)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdministrarGanancias"
        Me.Text = "AdministrarGanancias"
        Me.PanelRaiz.ResumeLayout(False)
        Me.PanelRaiz.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelConDinero.ResumeLayout(False)
        Me.PanelConDinero.PerformLayout()
        CType(Me.tablaGanancias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelRaiz As Panel
    Friend WithEvents fecha1 As DateTimePicker
    Friend WithEvents fecha2 As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_TodasGanancia As Button
    Friend WithEvents tablaGanancias As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_GananciasporRango As Button
    Friend WithEvents PanelConDinero As Panel
    Friend WithEvents txt_ganancias As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
