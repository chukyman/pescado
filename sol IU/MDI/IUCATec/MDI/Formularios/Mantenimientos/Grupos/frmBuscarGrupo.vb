Imports LN.Estructuras
Imports LN.Gestores

Public Class frmBuscarGrupo
    'Fecha: 21/10/2012
    'Desarrollador: Diego Salas Arce



#Region "Eventos"


    ''' <summary>
    ''' Acción del boton de salir, el cual cierra la ventana
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Diego Salas Arce</remarks>
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
        Dim nombreGrupo As String = txtNombre.Text()
        'Obtengo la estructura de grupos haciendo un llamado al gestor
        Dim vlostrDatosGrupo As StrGrupo = GestorGrupo.obtenerGrupoXNombre(nombreGrupo)

        MessageBox.Show("Información del grupo" & vbCrLf &
                        "Nombre de grupo: " & vlostrDatosGrupo.Nombre & vbCrLf &
                        "Horario: " & vlostrDatosGrupo.Horario & vbCrLf &
                        "Descripción: " & vlostrDatosGrupo.Descripcion & vbCrLf &
                        "Cantidad de estudiantes: " & CStr(vlostrDatosGrupo.CantEstudiantes) & vbCrLf &
                        "Curso: " & vlostrDatosGrupo.NomCurso)
    End Sub

#End Region

    Private Sub btnSalir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub txtNombre_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyUp
        If Trim(txtNombre.Text) = String.Empty Then
            lblValidaNombreGrupo.Visible = True
        Else
            lblValidaNombreGrupo.Visible = False

        End If

    End Sub

    Private Sub frmBuscarGrupo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNombre.Focus()
        lblValidaNombreGrupo.Visible = False
    End Sub
End Class