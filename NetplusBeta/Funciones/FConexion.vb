Imports System.Data.SqlClient 'para poder usarlo como un cliente de sql'
Public Class FConexion
    Protected cnn As SqlConnection
    Public Function FnConectado()
        Try
            cnn = New SqlConnection("Data Source=(local); Initial Catalog=netplusbeta; Integrated Security= true")
            cnn.Open()
            ' MsgBox("Te haz conectado bro")
            Return True
        Catch ex As Exception
            MsgBox("Error al conectarse bro " + vbCrLf + ex.Message)
            Return False
        End Try
    End Function

    Public Function FnDesconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("Error al conectarse a la bd" + vbCrLf + ex.Message)
            Return False
        End Try
    End Function
End Class
