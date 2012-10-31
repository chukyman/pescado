﻿Imports LN.Estructuras
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
    ''' Llena el comboBox de grupos
    ''' </summary>
    ''' <remarks>Diego Salas Arce</remarks>
    Private Sub llenarComboBoxGrupos()
        For Each StrGrupo In vgoListaEstructurasGrupo
            cboGrupos.Items.Add(StrGrupo.Nombre & "-" & StrGrupo.Horario)
        Next
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
            'Obtengo el nombre del grupo digitado por el usuario
            Dim nombreGrupo As String = txtBuscGrupo.Text()
            'Obtengo la estructura de grupos haciendo un llamado al gestor
            Dim str As StrGrupo = GestorGrupo.obtenerGrupoXNombre(nombreGrupo)

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
            
            Dim posGrupo As Integer = cboGrupos.SelectedIndex
            Dim str As StrGrupo = vgoListaEstructurasGrupo(posGrupo)
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

#End Region


End Class