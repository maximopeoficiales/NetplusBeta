Public Class Form1
    Sub ConexionBD()
        Try
            Dim funcion As New FConexion
            funcion.FnConectado()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConexionBD()

    End Sub
End Class
