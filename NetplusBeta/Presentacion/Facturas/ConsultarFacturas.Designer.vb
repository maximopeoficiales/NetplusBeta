<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultarFacturas
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
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.fecha1 = New System.Windows.Forms.DateTimePicker()
        Me.fecha2 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_MostrarFacturas = New System.Windows.Forms.Button()
        Me.tablaFacturaContrato = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ActualizarCampos = New System.Windows.Forms.PictureBox()
        Me.PanelRaiz.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tablaFacturaContrato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ActualizarCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelRaiz
        '
        Me.PanelRaiz.BackgroundImage = Global.NetplusBeta.My.Resources.Resources.fondo1
        Me.PanelRaiz.Controls.Add(Me.ActualizarCampos)
        Me.PanelRaiz.Controls.Add(Me.PictureBox2)
        Me.PanelRaiz.Controls.Add(Me.btn_Buscar)
        Me.PanelRaiz.Controls.Add(Me.fecha1)
        Me.PanelRaiz.Controls.Add(Me.fecha2)
        Me.PanelRaiz.Controls.Add(Me.Label9)
        Me.PanelRaiz.Controls.Add(Me.btn_MostrarFacturas)
        Me.PanelRaiz.Controls.Add(Me.tablaFacturaContrato)
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
        Me.PictureBox2.Location = New System.Drawing.Point(817, 195)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 85
        Me.PictureBox2.TabStop = False
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_Buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btn_Buscar.FlatAppearance.BorderSize = 0
        Me.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Buscar.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Buscar.ForeColor = System.Drawing.Color.White
        Me.btn_Buscar.Image = Global.NetplusBeta.My.Resources.Resources.buscar
        Me.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Buscar.Location = New System.Drawing.Point(1190, 253)
        Me.btn_Buscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(316, 107)
        Me.btn_Buscar.TabIndex = 77
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Buscar.UseVisualStyleBackColor = False
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
        'btn_MostrarFacturas
        '
        Me.btn_MostrarFacturas.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_MostrarFacturas.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btn_MostrarFacturas.FlatAppearance.BorderSize = 0
        Me.btn_MostrarFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_MostrarFacturas.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_MostrarFacturas.ForeColor = System.Drawing.Color.White
        Me.btn_MostrarFacturas.Image = Global.NetplusBeta.My.Resources.Resources.billall
        Me.btn_MostrarFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_MostrarFacturas.Location = New System.Drawing.Point(102, 262)
        Me.btn_MostrarFacturas.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_MostrarFacturas.Name = "btn_MostrarFacturas"
        Me.btn_MostrarFacturas.Size = New System.Drawing.Size(316, 107)
        Me.btn_MostrarFacturas.TabIndex = 64
        Me.btn_MostrarFacturas.Text = "Mostrar todas"
        Me.btn_MostrarFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_MostrarFacturas.UseVisualStyleBackColor = False
        '
        'tablaFacturaContrato
        '
        Me.tablaFacturaContrato.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.tablaFacturaContrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaFacturaContrato.Location = New System.Drawing.Point(102, 396)
        Me.tablaFacturaContrato.Name = "tablaFacturaContrato"
        Me.tablaFacturaContrato.RowHeadersWidth = 51
        Me.tablaFacturaContrato.RowTemplate.Height = 24
        Me.tablaFacturaContrato.Size = New System.Drawing.Size(1404, 521)
        Me.tablaFacturaContrato.TabIndex = 63
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
        Me.Label1.Size = New System.Drawing.Size(350, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Administrar Facturas"
        '
        'ActualizarCampos
        '
        Me.ActualizarCampos.BackColor = System.Drawing.Color.Transparent
        Me.ActualizarCampos.BackgroundImage = Global.NetplusBeta.My.Resources.Resources.actualizar_cliente
        Me.ActualizarCampos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ActualizarCampos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ActualizarCampos.Location = New System.Drawing.Point(1406, 62)
        Me.ActualizarCampos.Name = "ActualizarCampos"
        Me.ActualizarCampos.Size = New System.Drawing.Size(100, 50)
        Me.ActualizarCampos.TabIndex = 49
        Me.ActualizarCampos.TabStop = False
        '
        'ConsultarFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1624, 1080)
        Me.Controls.Add(Me.PanelRaiz)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ConsultarFacturas"
        Me.Text = "ConsultarFacturas"
        Me.PanelRaiz.ResumeLayout(False)
        Me.PanelRaiz.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tablaFacturaContrato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ActualizarCampos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelRaiz As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_Buscar As Button
    Friend WithEvents fecha1 As DateTimePicker
    Friend WithEvents fecha2 As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_MostrarFacturas As Button
    Friend WithEvents tablaFacturaContrato As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ActualizarCampos As PictureBox
End Class
