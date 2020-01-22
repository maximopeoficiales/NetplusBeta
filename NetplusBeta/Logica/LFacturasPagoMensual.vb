Public Class LFacturasPagoMensual
    Private id_factura_pm, id_pago_mensual As Integer

    Property gid_factura_pm
        Get
            Return id_factura_pm
        End Get
        Set(value)
            id_factura_pm = value
        End Set
    End Property

    Property gid_pago_mensual
        Get
            Return id_pago_mensual
        End Get
        Set(value)
            id_pago_mensual = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(id_factura_pm As Integer, id_pago_mensual As Integer)
        Me.gid_factura_pm = id_factura_pm
        Me.gid_pago_mensual = id_pago_mensual
    End Sub
End Class
