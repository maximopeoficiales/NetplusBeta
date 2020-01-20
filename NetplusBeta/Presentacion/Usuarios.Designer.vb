<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Me.tabla_clientes = New System.Windows.Forms.DataGridView()
        Me.insert_btn = New System.Windows.Forms.Button()
        Me.usuario = New System.Windows.Forms.TextBox()
        Me.contrasena = New System.Windows.Forms.TextBox()
        CType(Me.tabla_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabla_clientes
        '
        Me.tabla_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabla_clientes.Location = New System.Drawing.Point(561, 179)
        Me.tabla_clientes.Name = "tabla_clientes"
        Me.tabla_clientes.RowHeadersWidth = 51
        Me.tabla_clientes.RowTemplate.Height = 24
        Me.tabla_clientes.Size = New System.Drawing.Size(423, 510)
        Me.tabla_clientes.TabIndex = 0
        '
        'insert_btn
        '
        Me.insert_btn.Location = New System.Drawing.Point(164, 138)
        Me.insert_btn.Name = "insert_btn"
        Me.insert_btn.Size = New System.Drawing.Size(107, 55)
        Me.insert_btn.TabIndex = 1
        Me.insert_btn.Text = "INSERTAR"
        Me.insert_btn.UseVisualStyleBackColor = True
        '
        'usuario
        '
        Me.usuario.Location = New System.Drawing.Point(164, 261)
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(100, 22)
        Me.usuario.TabIndex = 2
        '
        'contrasena
        '
        Me.contrasena.Location = New System.Drawing.Point(164, 311)
        Me.contrasena.Name = "contrasena"
        Me.contrasena.Size = New System.Drawing.Size(100, 22)
        Me.contrasena.TabIndex = 2
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 741)
        Me.Controls.Add(Me.contrasena)
        Me.Controls.Add(Me.usuario)
        Me.Controls.Add(Me.insert_btn)
        Me.Controls.Add(Me.tabla_clientes)
        Me.Name = "Usuarios"
        Me.Text = "Usuarios"
        CType(Me.tabla_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tabla_clientes As DataGridView
    Friend WithEvents insert_btn As Button
    Friend WithEvents usuario As TextBox
    Friend WithEvents contrasena As TextBox
End Class
