<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Me.PPanelBotones = New System.Windows.Forms.Panel()
        Me.PLogo = New System.Windows.Forms.Panel()
        Me.btn_medios = New System.Windows.Forms.Button()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PPanelBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'PPanelBotones
        '
        Me.PPanelBotones.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.PPanelBotones.Controls.Add(Me.btn_medios)
        Me.PPanelBotones.Controls.Add(Me.PLogo)
        Me.PPanelBotones.Dock = System.Windows.Forms.DockStyle.Left
        Me.PPanelBotones.Location = New System.Drawing.Point(0, 0)
        Me.PPanelBotones.Name = "PPanelBotones"
        Me.PPanelBotones.Size = New System.Drawing.Size(281, 788)
        Me.PPanelBotones.TabIndex = 0
        '
        'PLogo
        '
        Me.PLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PLogo.Location = New System.Drawing.Point(0, 0)
        Me.PLogo.Name = "PLogo"
        Me.PLogo.Size = New System.Drawing.Size(281, 150)
        Me.PLogo.TabIndex = 0
        '
        'btn_medios
        '
        Me.btn_medios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_medios.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_medios.FlatAppearance.BorderSize = 0
        Me.btn_medios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_medios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_medios.ForeColor = System.Drawing.Color.White
        Me.btn_medios.Image = Global.NetplusBeta.My.Resources.Resources.users1
        Me.btn_medios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_medios.Location = New System.Drawing.Point(0, 150)
        Me.btn_medios.Name = "btn_medios"
        Me.btn_medios.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_medios.Size = New System.Drawing.Size(281, 45)
        Me.btn_medios.TabIndex = 1
        Me.btn_medios.Text = "Usuarios"
        Me.btn_medios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_medios.UseVisualStyleBackColor = True
        '
        'PanelContenedor
        '
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(281, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1045, 788)
        Me.PanelContenedor.TabIndex = 1
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1326, 788)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.PPanelBotones)
        Me.Name = "MenuPrincipal"
        Me.Text = "MenuPrincipal"
        Me.PPanelBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PPanelBotones As Panel
    Friend WithEvents btn_medios As Button
    Friend WithEvents PLogo As Panel
    Friend WithEvents PanelContenedor As Panel
End Class
