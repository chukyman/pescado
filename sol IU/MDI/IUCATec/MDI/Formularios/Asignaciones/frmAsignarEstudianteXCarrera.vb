'Fecha: 20/10/2012
'Desarrollado: Julio Moreira
Imports LN.Estructuras
Imports LN.Gestores

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
        PLLenarComboEstudiantes()
        PllenarComboCarrera()





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


    Private Sub PLLenarComboEstudiantes()

        Dim vloListaTemporalNombre As List(Of LN.Estructuras.StrUsuario)

        vloListaTemporalNombre = GestorUsuario.listarEstudiantes()

        ltsEstudiantes.DisplayMember = "Nombre"
        ltsEstudiantes.ValueMember = "IdUsuario"

        ltsEstudiantes.DataSource = vloListaTemporalNombre



    End Sub


    Private Sub PllenarComboCarrera()
        Dim vloListaTemporal As List(Of LN.Estructuras.StrCarrera)
        vloListaTemporal = GestorCarrera.listarCarrera()

        'Indica cual es la llave primaria 
        ltsCarreras.ValueMember = "Id_Carrera"
        'Indica el valor a mostrar en la lista
        ltsCarreras.DisplayMember = "Nombre"
        'Indica cual es su datasourse o fuente de datos, el cual es una lista de estructuras
        ltsCarreras.DataSource = vloListaTemporal
    End Sub







End Class