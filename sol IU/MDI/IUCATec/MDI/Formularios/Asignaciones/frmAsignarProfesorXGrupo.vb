Imports LN.Estructuras
Imports LN.Gestores

Public Class frmAsignarProfesorXGrupo
    'Fecha: 20/10/2012
    'Desarrollador: Diego Salas Arce

    'Lista de profesores
    Dim vgolistaProfesores As List(Of StrUsuario) = GestorUsuario.listarProfesores
    'Lista de grupos
    Dim vgolistaGrupos As List(Of StrGrupo) = GestorGrupo.listarGrupos
#Region "Eventos"

    ''' <summary>
    ''' Load del formulario de asignacion de profesores a grupos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Diego Salas Arce</remarks>
    Private Sub frmAsignarProfesorXGrupo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        btnAsignar.Enabled = False
        btnRemover.Enabled = False
        llenarListaProfesores()
        llenarListaGrupos()
    End Sub

    ''' <summary>
    ''' Evento que verifica si en la lista de profesores la persona ha seleccionado una opción para habilitar el botón de asignar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Diego Salas Arce</remarks>
    Private Sub ltsProfesores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltsProfesores.SelectedIndexChanged

        If ltsProfesores.SelectedIndex = -1 Then
        ElseIf ltsGrupos.SelectedIndex = -1 Then
        Else
            btnAsignar.Enabled = True
        End If

    End Sub

    ''' <summary>
    ''' Evento que verifica si en la lista de grupos la persona ha seleccionado una opción para habilitar el botón de asignar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Diego Salas Arce</remarks>
    Private Sub ltsGrupos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltsGrupos.SelectedIndexChanged
        If ltsProfesores.SelectedIndex = -1 Then
        ElseIf ltsGrupos.SelectedIndex = -1 Then
        Else
            btnAsignar.Enabled = True
        End If
    End Sub

    ''' <summary>
    ''' Evento del botón Remover que verifica que la persona haya seleccionado una opción para poder habilitar la opción de remover
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Diego Salas Arce</remarks>
    Private Sub btnRemover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemover.Click
        If grdAsignacionProfGrupo.RowCount > 0 Then
            btnRemover.Enabled = True
        End If
    End Sub

#End Region

#Region "Constantes"


#End Region

#Region "Atributos"

#End Region

#Region "Procedimientos"
    ''' <summary>
    ''' Llena la lista de profesores
    ''' </summary>
    ''' <remarks>Diego Salas Arce</remarks>
    Private Sub llenarListaProfesores()

        For Each StrUsuario In vgolistaProfesores
            ltsProfesores.Items.Add(StrUsuario.Nombre & " " & StrUsuario.Apellido1)
        Next
    End Sub

    ''' <summary>
    ''' Llena la lista de grupos
    ''' </summary>
    ''' <remarks>Diego Salas Arce</remarks>
    Private Sub llenarListaGrupos()
        For Each StrGrupo In vgolistaGrupos
            ltsGrupos.Items.Add(StrGrupo.Nombre & " " & StrGrupo.Horario)
        Next
    End Sub
#End Region

#Region "Funciones"

#End Region

End Class