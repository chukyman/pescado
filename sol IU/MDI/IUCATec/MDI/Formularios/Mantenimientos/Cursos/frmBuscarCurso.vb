Imports LN.Gestores
Imports LN.Estructuras


Public Class frmBuscarCurso

#Region "Eventos"

    ''' <summary>
    ''' Load de el formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Diego Salas Arce</remarks>
    Private Sub frmBuscarCurso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblValidaCriterioCodigo.Visible = False
        lblValidaCriterioNombre.Visible = False
    End Sub

    ''' <summary>
    ''' Validación del label hacia el textbox de busqueda de curso por codigo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Diego Salas Arce</remarks>
    Private Sub txtBuscCursoCodigo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscCursoCodigo.KeyUp
        If Trim(txtBuscCursoCodigo.Text) = String.Empty Then
            lblValidaCriterioCodigo.Visible = True
        Else
            lblValidaCriterioCodigo.Visible = False
        End If
    End Sub

    ''' <summary>
    ''' Validación del label hacia el textbox de busqueda de curso por nombre
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Diego Salas Arce</remarks>
    Private Sub txtBuscCursoNombre_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscCursoNombre.KeyUp
        If Trim(txtBuscCursoNombre.Text) = String.Empty Then
            lblValidaCriterioNombre.Visible = True
        Else
            lblValidaCriterioNombre.Visible = False
        End If
    End Sub

    ''' <summary>
    ''' Acción del botón de buscar curso por código
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Diego Salas Arce</remarks>
    Private Sub btnBuscarCursoCodigo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCursoCodigo.Click
        vlcMensaje = "Debe ingresar el código del curso"
        If Trim(txtBuscCursoCodigo.Text) = String.Empty Then
            MessageBox.Show(vlcMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBuscCursoCodigo.Focus()
        Else
            BusquedaXCodigoCurso()
        End If
    End Sub

    ''' <summary>
    ''' Acción del boton de buscar curso por nombre
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Diego Salas Arce</remarks>
    Private Sub btnBuscarCursoNombre_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCursoNombre.Click
        vlcMensaje = "Debe ingresar el nombre del curso"
        If Trim(txtBuscCursoNombre.Text) = String.Empty Then
            MessageBox.Show(vlcMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBuscCursoCodigo.Focus()
        Else
            BusquedaXNombreCurso()
        End If
    End Sub

    

    ''' <summary>
    ''' Cierra la ventana de búsqueda de cursos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Diego Salas Arce</remarks>
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
#End Region

#Region "Atributos"
    Dim vlcMensaje As String = ""
#End Region

#Region "Constantes"

#End Region

#Region "Procedimientos"
    Private Sub BusquedaXCodigoCurso()
        'Obtengo el codigo del curso digitado por el usuario
        Dim codigoCurso As String = txtBuscCursoCodigo.Text()
        'Obtengo la estructura de cursos haciendo un llamado al gestor
        Dim vlostrDatosCurso As StrCurso = GestorCurso.buscarXCodigo(codigoCurso)

        MessageBox.Show("Información del curso" & vbCrLf &
                        "ID: " & vlostrDatosCurso.Codigo & vbCrLf &
                        "Código: " & vlostrDatosCurso.Nombre & vbCrLf &
                        "Nombre: " & vlostrDatosCurso.Estado)
    End Sub


    Private Sub BusquedaXNombreCurso()

        'Obtengo el nombre del curso digitado por el usuario
        Dim nombreCurso As String = txtBuscCursoNombre.Text()
        'Obtengo la estructura de cursos haciendo un llamado al gestor
        Dim vlostrDatosCurso As StrCurso = GestorCurso.buscarXNombre(nombreCurso)

        MessageBox.Show("Información del curso" & vbCrLf &
                        "Código de curso: " & vlostrDatosCurso.Codigo & vbCrLf &
                        "Curso: " & vlostrDatosCurso.Nombre & vbCrLf &
                        "Estado: " & vlostrDatosCurso.Estado)
    End Sub


#End Region

#Region "Funciones"

#End Region

End Class