Public Class LFacturaContrato
    Private id_factura_c, id_cliente_servicio As Integer

    Property gid_factura
        Get
            Return id_factura_c
        End Get
        Set(value)
            id_factura_c = value
        End Set
    End Property

    Property gid_cliente_servicio
        Get
            Return id_cliente_servicio
        End Get
        Set(value)
            id_cliente_servicio = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(id_factura_c As Integer, id_cliente_servicio As Integer)
        Me.id_factura_c = id_factura_c
        Me.id_cliente_servicio = id_cliente_servicio
    End Sub
End Class
