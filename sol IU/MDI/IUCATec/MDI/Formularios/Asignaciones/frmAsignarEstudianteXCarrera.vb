'Fecha: 20/10/2012
'Desarrollado: Julio Moreira


Public Class frmAsignarEstudianteXCarrera

#Region "Eventos"

    ''' <summary>
    ''' Load del formulario de asignacion de profesores a grupos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Julio Moreira</remarks>
    Private Sub frmAsignarEstudianteXCarrera_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        btnAsignar.Enabled = False
        btnRemover.Enabled = False
    End Sub

    ''' <summary>
    ''' Evento que verifica si en la lista de profesores la persona ha seleccionado una opción para habilitar el botón de asignar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Julio Moreira</remarks>
    Private Sub ltsProfesores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltsEstudiantes.SelectedIndexChanged

        If ltsEstudiantes.SelectedIndex = -1 Then
        ElseIf ltsCarreras.SelectedIndex = -1 Then
        Else
            btnAsignar.Enabled = True
        End If

    End Sub

    ''' <summary>
    ''' Evento que verifica si en la lista de grupos la persona ha seleccionado una opción para habilitar el botón de asignar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Julio Moreira</remarks>
    Private Sub ltsGrupos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltsCarreras.SelectedIndexChanged
        If ltsEstudiantes.SelectedIndex = -1 Then
        ElseIf ltsCarreras.SelectedIndex = -1 Then
        Else
            btnAsignar.Enabled = True
        End If
    End Sub

    ''' <summary>
    ''' Evento del botón Remover que verifica que la persona haya seleccionado una opción para poder habilitar la opción de remover
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Julio Moreira</remarks>
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

#End Region

#Region "Funciones"

#End Region

    Private Sub pnlCuerpoAsignarProfGrupo_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlCuerpoAsignarProfGrupo.Paint

    End Sub
End Class