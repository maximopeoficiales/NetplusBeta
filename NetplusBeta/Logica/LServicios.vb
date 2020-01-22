Public Class LServicios
    Private id_servicio As Integer
    Private tipo_servicio, id_plan As String
    Private precio_servicio As Double


    Property gid_servicio
        Get
            Return id_servicio
        End Get
        Set(value)
            id_servicio = value
        End Set
    End Property

    Property gtipo_servicio
        Get
            Return tipo_servicio
        End Get
        Set(value)
            tipo_servicio = value
        End Set
    End Property

    Property gprecio_servicio
        Get
            Return precio_servicio
        End Get
        Set(value)
            precio_servicio = value
        End Set
    End Property

    Property gid_plan
        Get
            Return id_plan
        End Get
        Set(value)
            id_plan = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(id_servicio As Integer, tipo_servicio As String, id_plan As String, precio_servicio As Double)
        Me.gid_servicio = id_servicio
        Me.gtipo_servicio = tipo_servicio
        Me.gid_plan = id_plan
        Me.gprecio_servicio = precio_servicio
    End Sub
End Class
