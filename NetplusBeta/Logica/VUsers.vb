Public Class VUsers
    Dim id_user As Integer
    Dim usuario, contrasena As String

    'encapsulacion
    Public Property gid_user
        Get
            Return id_user
        End Get
        Set(value)
            id_user = value
        End Set
    End Property
    Public Property gusuario
        Get
            Return usuario
        End Get
        Set(value)
            usuario = value
        End Set
    End Property

    Public Property gcontrasena
        Get
            Return contrasena
        End Get
        Set(value)
            contrasena = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(id_user As Integer, usuario As String, contrasena As String)
        Me.gid_user = id_user
        Me.gusuario = usuario
        Me.gcontrasena = contrasena
    End Sub
End Class
