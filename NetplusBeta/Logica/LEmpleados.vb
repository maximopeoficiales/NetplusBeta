Public Class LEmpleados
    Private cod_empleado As Integer
    Private usuario, contrasena, nombre As String

    Property gcod_empleado
        Get
            Return cod_empleado
        End Get
        Set(value)
            cod_empleado = value
        End Set
    End Property

    Property gusuario
        Get
            Return usuario
        End Get
        Set(value)
            usuario = value
        End Set
    End Property

    Property gcontrasena
        Get
            Return contrasena
        End Get
        Set(value)
            contrasena = value
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

    Public Sub New()

    End Sub

    Public Sub New(cod_empleado As Integer, usuario As String, contrasena As String, nombre As String)
        Me.gcod_empleado = cod_empleado
        Me.gusuario = usuario
        Me.gcontrasena = contrasena
        Me.gnombre = nombre
    End Sub
End Class
