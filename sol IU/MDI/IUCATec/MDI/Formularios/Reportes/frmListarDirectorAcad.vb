'Fecha: 20/10/2012
'Desarrollado: Julio Moreira

Imports LN.Gestores
Imports LN.Estructuras


Public Class frmListarDirectorAcad

    Private Sub ListarCarreras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'En caso de error
        ' Lista todos las carerras de la base de datos
        ' grdBuscarCarreras.DataSource = Gestores.GestorCarrera.listarCarrera()
        'Lista temporal que almacena una lista de tipo estructura carrera
        Dim vloListaTem As List(Of LN.Estructuras.StrUsuario)

        'Variable de tipo dataGridView row que sirve para ingresar a las columnas del gird
        Dim vldrRegistro As DataGridViewRow


        'En caso de error
        Try
            Dim vlnIndice As Integer

            vloListaTem = GestorUsuario.listarDA()

            For vlnx As Integer = 0 To vloListaTem.Count - 1

                vlnIndice = grdBuscarUsuarios.Rows.Add

                vldrRegistro = grdBuscarUsuarios.Rows(vlnx)

                vldrRegistro.Cells("vfoNombre").Value = vloListaTem.Item(vlnx).Nombre
                vldrRegistro.Cells("vfoApellido1").Value = vloListaTem.Item(vlnx).Apellido1
                vldrRegistro.Cells("vfoApellido2").Value = vloListaTem.Item(vlnx).Apellido2
                vldrRegistro.Cells("vfoNombreRol").Value = vloListaTem.Item(vlnx).NombreRol
                vldrRegistro.Cells("vfoGenero").Value = vloListaTem.Item(vlnx).Genero
                vldrRegistro.Cells("vfoCedula").Value = vloListaTem.Item(vlnx).Cedula
                vldrRegistro.Cells("vfoCorreo").Value = vloListaTem.Item(vlnx).Correo

            Next




            'vloListaTem.GetEnumerator.Current.Id_Carrera
        Catch ex As Exception
            'Invoca mensaje de error
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class