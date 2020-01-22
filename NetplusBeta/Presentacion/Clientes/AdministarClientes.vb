Public Class AdministarClientes
    Dim validacion
    Dim fn As New FClientes
    Private Sub Copiardatos()
        Try
            txt_dni.Text = tablaclientes.SelectedCells.Item(1).Value
            txt_nombre.Text = tablaclientes.SelectedCells.Item(2).Value
            txt_direccion.Text = tablaclientes.SelectedCells.Item(3).Value
            txt_zona.Text = tablaclientes.SelectedCells.Item(4).Value
            txt_celular.Text = tablaclientes.SelectedCells.Item(5).Value
            txt_email.Text = tablaclientes.SelectedCells.Item(6).Value
        Catch ex As Exception : MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub validar_form()
        If txt_dni.Text = "" Or txt_nombre.Text = "" Or txt_celular.Text = "" Or txt_direccion.Text = "" Or txt_email.Text = "" Or txt_zona.Text = "" Or txt_direccion.Text = "" Then
            validacion = False
            MsgBox("Complete todos los campos")
        Else
            validacion = True
        End If
    End Sub
    Private Sub PropiedadesDatagrid()
        tablaclientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect 'activa la multiseleccion'
        tablaclientes.AllowUserToAddRows = False
        tablaclientes.AllowUserToResizeRows = False
    End Sub
    Private Sub MostrarClientes()
        tablaclientes.DataSource = fn.FnMostrarClientes
    End Sub
    Private Sub MostrarClientePorDni()
        Dim logicas As New LClientes
        If txt_buscardni.Text = "" Then
            MostrarClientes()
        End If
        logicas.gid_cliente = txt_buscardni.Text
        tablaclientes.DataSource = fn.FnBuscarClientePordni(logicas)
    End Sub
    Private Sub RegistrarCliente()
        Dim logica As New LClientes
        logica.gid_cliente = txt_dni.Text
        logica.gnombre = txt_nombre.Text
        logica.gdireccion = txt_direccion.Text
        logica.gcelular = txt_celular.Text
        logica.gemail = txt_email.Text
        logica.gzona = txt_zona.Text
        fn.FnInsertarCliente(logica)
        MostrarClientes()
    End Sub
    Private Sub ActulizarCliente()
        Dim logica As New LClientes
        logica.gid_cliente = txt_dni.Text
        logica.gnombre = txt_nombre.Text
        logica.gdireccion = txt_direccion.Text
        logica.gcelular = txt_celular.Text
        logica.gemail = txt_email.Text
        logica.gzona = txt_zona.Text
        fn.FnActualizarCliente(logica)
        MostrarClientes()
    End Sub
    Public Sub eliminar_cliente()
        Dim result As DialogResult
        'estilo del mensaje'
        result = MessageBox.Show("¿Estas seguro de eliminar los cliente seleccionados", "Cliente Eliminado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        'si presiona ok'
        If result = Windows.Forms.DialogResult.OK Then
            'recorre la las filas'
            For Each row As DataGridViewRow In tablaclientes.Rows
                Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                If marcado Then
                    Try
                        'dni_cliente es la fila donde obtendra el dato'
                        Dim id_cliente = row.Cells("id_cliente").Value
                        Dim funciones As New FClientes
                        Dim logica As New LClientes
                        logica.gid_cliente = id_cliente
                        If funciones.FnEliminarCliente(logica) Then 'llamo a mi funcion creada en la  fclientes
                            MsgBox("Se elimino correctamente")
                            MostrarClientes()
                        End If
                    Catch ex As Exception
                        MsgBox("No se puede porque tiene relacion con algun documento")

                    End Try
                End If
            Next
        End If
    End Sub
    Private Sub AdministarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PropiedadesDatagrid()
        MostrarClientes()
    End Sub
    Private Sub txt_buscardni_TextChanged(sender As Object, e As EventArgs) Handles txt_buscardni.TextChanged
        MostrarClientePorDni()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        eliminar_cliente()
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        ActulizarCliente()
    End Sub

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        RegistrarCliente()
    End Sub

    Private Sub tablaclientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaclientes.CellContentClick

    End Sub

    Private Sub tablaclientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaclientes.CellDoubleClick
        Copiardatos()
    End Sub
End Class