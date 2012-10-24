'Fecha: 16/10/2012

Imports System.Windows.Forms

Public Class MDICAtec

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub MDICAtec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub




    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

#Region "Atributos"



#End Region

#Region "Constantes"
 

#End Region

#Region "Procedimientos"


   

#End Region

#Region "Funciones"

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Evento de click en la opcion Asignar/ Profesor a grupo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Diego Salas Arce</remarks>
    Private Sub tspProfesorAGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tspProfesorAGrupo.Click
        Dim frmAsigProfAGrupo As New frmAsignarProfesorXGrupo
        frmAsigProfAGrupo.MdiParent = Me
        frmAsigProfAGrupo.Show()
    End Sub

    ''' <summary>
    ''' Evento de click en la opcion del muenu Usuarios
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Roberto Cordero Quiros</remarks>
    Private Sub tspUsuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tspUsuarios.Click
        Dim vloFrmMantenimientoUsuario As New frmMantenimientoUsuario
        vloFrmMantenimientoUsuario.MdiParent = Me
        vloFrmMantenimientoUsuario.Show()
    End Sub

    ''' <summary>
    ''' Evento de click en la opcion del muenu Cargar Curos.
    ''' Esta pantalla abre un archivo de excel con los datos de los cursos.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Roberto Cordero Quirós</remarks>
    Private Sub tspCargaCursos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tspCargaCursos.Click
        Dim vloFrmCargarCursos As New frmCargarCursos
        vloFrmCargarCursos.MdiParent = Me
        vloFrmCargarCursos.Show()
    End Sub

#End Region
  
    Private Sub ListarCarrerasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListarCarrerasToolStripMenuItem.Click
        Dim vloFrmListarCarreras As New frmListarCarreras
        vloFrmListarCarreras.Show()
    End Sub

    Private Sub tspCarreras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tspCarreras.Click
        Dim vloFrmMantenimientoCarrera As New frmMantenimientoCarrera
        vloFrmMantenimientoCarrera.MdiParent = Me
        vloFrmMantenimientoCarrera.Show()
    End Sub

    Private Sub tspEstudianteACarrera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tspEstudianteACarrera.Click
        Dim vloFrmAsignarEstudianteXCarrera As New frmAsignarEstudianteXCarrera
        vloFrmAsignarEstudianteXCarrera.MdiParent = Me
        vloFrmAsignarEstudianteXCarrera.Show()
    End Sub

    Private Sub ListarDirectoresAcademicosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListarDirectoresAcademicosToolStripMenuItem.Click
        Dim vloFfrmListarDirectorAcad As New frmListarDirectorAcad
        vloFfrmListarDirectorAcad.Show()
    End Sub

    Private Sub tspCursos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tspCursos.Click
        Dim vloFrmMantenimientoCursos As New frmMantenimientoCurso
        vloFrmMantenimientoCursos.MdiParent = Me
        vloFrmMantenimientoCursos.Show()
    End Sub

    Private Sub tspGrupos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tspGrupos.Click
        Dim vloFrmMantenimientoGrupos As New frmMantenimientoGrupo
        vloFrmMantenimientoGrupos.MdiParent = Me
        vloFrmMantenimientoGrupos.Show()
    End Sub

    Private Sub ListarCursosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListarCursosToolStripMenuItem.Click
        Dim vloFrmListarCursos As New frmListarCursos
        vloFrmListarCursos.ShowDialog()
    End Sub

    Private Sub ListarGruposToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListarGruposToolStripMenuItem.Click
        Dim vloFrmListarGrupos As New frmListarGrupos
        vloFrmListarGrupos.ShowDialog()
    End Sub
End Class
