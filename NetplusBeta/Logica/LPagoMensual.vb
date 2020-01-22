Public Class LPagoMensual
    Private id_pago_mensual, id_cliente_servicio As Integer
    Private estado_pago As String
    Private fecha_pago, fecha_pagada As Date
    Private pago_mensual As Double

    Property gid_pago_mensual
        Get
            Return id_pago_mensual
        End Get
        Set(value)
            id_pago_mensual = value
        End Set
    End Property

    Property gestado_pago
        Get
            Return estado_pago
        End Get
        Set(value)
            estado_pago = value
        End Set
    End Property
    Property gfecha_pago
        Get
            Return fecha_pago
        End Get
        Set(value)
            fecha_pago = value
        End Set
    End Property
    Property gfecha_pagada
        Get
            Return fecha_pagada
        End Get
        Set(value)
            fecha_pagada = value
        End Set
    End Property
    Property gpago_mensual
        Get
            Return pago_mensual
        End Get
        Set(value)
            pago_mensual = value
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

    Public Sub New(id_pago_mensual As Integer, id_cliente_servicio As Integer, estado_pago As String, fecha_pago As Date, fecha_pagada As Date, pago_mensual As Double)
        Me.gid_pago_mensual = id_pago_mensual
        Me.gid_cliente_servicio = id_cliente_servicio
        Me.gestado_pago = estado_pago
        Me.gfecha_pago = fecha_pago
        Me.gfecha_pagada = fecha_pagada
        Me.gpago_mensual = pago_mensual
    End Sub
End Class
