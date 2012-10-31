Imports LN.Estructuras
Imports LN.Gestores

Public Class frmBuscarGrupo
    'Fecha: 21/10/2012
    'Desarrollador: Diego Salas Arce

    Dim vgoListaEstructurasGrupo As List(Of StrGrupo) = GestorGrupo.listarGrupos

#Region "Eventos"
    ''' <summary>
    ''' Load del formulario buscar grupo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Diego Salas Arce</remarks>
    Private Sub frmBuscarGrupo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtBuscGrupo.Focus()
        lblValidaCriterio.Visible = False

        'llena el comboBox de grupos al iniciar el formulario
        llenarComboBoxGrupos()
    End Sub

    

    ''' <summary>
    ''' Acción que valida si el textbox de búsqueda de grupo por criterio se encuentra vacío y activa el label
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Diego Salas Arce</remarks>
    Private Sub txtBuscGrupo_KeyUp_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscGrupo.KeyUp
        If Trim(txtBuscGrupo.Text) = String.Empty Then
            lblValidaCriterio.Visible = True
        Else
            lblValidaCriterio.Visible = False
        End If
    End Sub

    ''' <summary>
    ''' Acción del botón que valida si la persona no ha digitado el criterio de búsqueda y presenta un mensaje de error
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnBuscarGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarGrupo.Click
        If Trim(txtBuscGrupo.Text) = String.Empty Then
            vgcMensaje = "Uno o más campos se encuentran vacíos"
            MessageBox.Show(vgcMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            mostrarInfoBusquedaXNombreGrupo()
        End If
    End Sub

    
    ''' <summary>
    ''' Acción del botón de búsqueda por lista de grupos que valida si no se ha seleccionado ninguna opción para búsqueda.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Diego Salas Arce</remarks>
    Private Sub btnBuscarListGrup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarListGrup.Click
        If cboGrupos.SelectedIndex = -1 Then
            vgcMensaje = "Debe seleccionar una opción"
            MessageBox.Show(vgcMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim vlcMensaje As String
            'Resultado del dialogo
            Dim vloResultadoMensaje As DialogResult

            'Valida que el grid tenga datos. o bien podria ser la lista de usuarios
            If cboGrupos.SelectedIndex > 0 Then
                'Mensaje de confirmacion
                vlcMensaje = "Desesa selecionar el grupo?"

                vloResultadoMensaje = MessageBox.Show(vlcMensaje, "Usuario", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
                'Si el mensaje fue arfimativo
                If vloResultadoMensaje = DialogResult.Yes Then

                    Dim pos As Integer = cboGrupos.SelectedIndex
                    Dim strGrp As StrGrupo = vgoListaEstructurasGrupo(pos)

                    PEnviarDatosFormularioPadre(strGrp)

                End If

            Else
                'No existen datos que selecionar
                MessageBox.Show("No Existen registros para selecionar")

            End If

            'Se podria Cerarr o no.. Pensarlo
            Me.Close()

        End If

    End Sub

    ''' <summary>
    ''' Acción del boton de salir, el cual cierra la ventana
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Diego Salas Arce</remarks>
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
#End Region

#Region "Constantes"
    Dim vgcMensaje As String = ""
#End Region

#Region "Funciones"

#End Region

#Region "Procedimientos"

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub mostrarInfoBusquedaXNombreGrupo()
        'Obtengo el nombre del grupo digitado por el usuario
        Dim nombreGrupo As String = txtBuscGrupo.Text()
        'Obtengo la estructura de grupos haciendo un llamado al gestor
        Dim vlostrDatosGrupo As StrGrupo = GestorGrupo.obtenerGrupoXNombre(nombreGrupo)

        MessageBox.Show("Información del grupo" & vbCrLf &
                        "Nombre de grupo: " & vlostrDatosGrupo.Nombre & vbCrLf &
                        "Horario: " & vlostrDatosGrupo.Horario & vbCrLf &
                        "Descripción: " & vlostrDatosGrupo.Descripcion & vbCrLf &
                        "Cantidad de estudiantes: " & CStr(vlostrDatosGrupo.CantEstudiantes) & vbCrLf &
                        "Curso: " & vlostrDatosGrupo.NomCurso)
    End Sub

    ''' <summary>
    ''' Llena el comboBox de grupos
    ''' </summary>
    ''' <remarks>Diego Salas Arce</remarks>
    Private Sub llenarComboBoxGrupos()
        For Each StrGrupo In vgoListaEstructurasGrupo
            cboGrupos.Items.Add(StrGrupo.Nombre & "-" & StrGrupo.Horario)
        Next
    End Sub


#End Region


    Public Sub PEnviarDatosFormularioPadre(ByVal strGrp)

    End Sub
End Class