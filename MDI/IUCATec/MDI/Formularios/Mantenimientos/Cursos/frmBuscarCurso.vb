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
        End If
    End Sub

    ''' <summary>
    ''' Accion del boton de buscar curso por combo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Diego Salas Arce</remarks>
    Private Sub btnBuscarListCurso_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarListCurso.Click
        vlcMensaje = "Debe seleccionar el curso a buscar"
        If cboCursos.SelectedIndex = -1 Then
            MessageBox.Show(vlcMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboCursos.Focus()
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

#End Region

#Region "Funciones"

#End Region
    
End Class