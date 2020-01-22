Public Class LClientes
    Private id_cliente, nombre, direccion, zona, celular, email As String

    Property gid_cliente
        Get
            Return id_cliente
        End Get
        Set(value)
            id_cliente = value
        End Set
    End Property
    Property gnombre
        Get
            Return nombre
        End Get
        Set(value)
            nombre = value
        End Set
    End Property
    Property gdireccion
        Get
            Return direccion
        End Get
        Set(value)
            direccion = value
        End Set
    End Property
    Property gzona
        Get
            Return zona
        End Get
        Set(value)
            zona = value
        End Set
    End Property
    Property gcelular
        Get
            Return celular
        End Get
        Set(value)
            celular = value
        End Set
    End Property
    Property gemail
        Get
            Return email
        End Get
        Set(value)
            email = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(id_cliente As String, nombre As String, direccion As String, zona As String, celular As String, email As String)
        Me.gid_cliente = id_cliente
        Me.gnombre = nombre
        Me.gdireccion = direccion
        Me.gzona = zona
        Me.gcelular = celular
        Me.gemail = email
    End Sub


End Class
