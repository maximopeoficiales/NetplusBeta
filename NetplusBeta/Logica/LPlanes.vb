Public Class LPlanes
    Private id_plan, descripcion As String

    Property gid_plan
        Get
            Return id_plan
        End Get
        Set(value)
            id_plan = value
        End Set
    End Property


    Property gdescripcion
        Get
            Return descripcion
        End Get
        Set(value)
            descripcion = value
        End Set
    End Property

    Public Sub New()


    End Sub

    Public Sub New(id_plan As String, descripcion As String)
        Me.gid_plan = id_plan
        Me.gdescripcion = descripcion
    End Sub
End Class
