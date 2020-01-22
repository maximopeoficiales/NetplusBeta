Public Class LCliente_Servicio
    Private id_cliente_servicio As Integer
    Private fecha_instalacion As Date
    Private pago_instalacion As Double
    Private estado_contrato, id_cliente As String
    Private id_servicio, cod_empleado As Integer

    Property gid_cliente_servicio
        Get
            Return id_cliente_servicio
        End Get
        Set(value)
            id_cliente_servicio = value
        End Set
    End Property

    Property gfecha_instalacion
        Get
            Return fecha_instalacion
        End Get
        Set(value)
            fecha_instalacion = value
        End Set
    End Property

    Property gpago_instalacion
        Get
            Return pago_instalacion
        End Get
        Set(value)
            pago_instalacion = value
        End Set
    End Property

    Property gestado_contrato
        Get
            Return estado_contrato
        End Get
        Set(value)
            estado_contrato = value
        End Set
    End Property

    Property gid_cliente
        Get
            Return id_cliente
        End Get
        Set(value)
            id_cliente = value
        End Set
    End Property

    Property gid_servicio
        Get
            Return id_servicio
        End Get
        Set(value)
            id_servicio = value
        End Set
    End Property

    Property gcod_empleado
        Get
            Return cod_empleado
        End Get
        Set(value)
            cod_empleado = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(id_cliente_servicio As Integer, fecha_instalacion As Date, pago_instalacion As Double, estado_contrato As String, id_cliente As String, id_servicio As Integer, cod_empleado As Integer)
        Me.gid_cliente_servicio = id_cliente_servicio
        Me.gfecha_instalacion = fecha_instalacion
        Me.gpago_instalacion = pago_instalacion
        Me.gestado_contrato = estado_contrato
        Me.gid_cliente = id_cliente
        Me.gid_servicio = id_servicio
        Me.gcod_empleado = cod_empleado
    End Sub
End Class

