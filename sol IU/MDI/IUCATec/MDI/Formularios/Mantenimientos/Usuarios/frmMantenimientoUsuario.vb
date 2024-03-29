﻿'Fecha: 17/10/2012
'Desarrollador: Roberto Cordero Quiros.
Imports LN.Gestores

Public Class frmMantenimientoUsuario
    Implements frmInterfaceBuscarModificarEliminar

    '* IMPORTANTE DEBEN DE PONER EN EL GRID DEL FORMULARIO BUSCAR LA PROPIEDAD
    ' propiedad SelectionMode y ponerlo en FullRowSelect de lo contrario no les fucan.


    'Compañeras se agrego una nueva carpeta que contiene una clase interface, 
    'Sirve para lleva a cabo el proceso de selecionar uno o varios registros de un grid.
    'Si quieren ver como funciona delen debugear desde este metodo btnBuscar_Click,
    'Y pongan cuidado como se manipula los datos, si existen otras maneras, pero 
    'si tienen alguna mas facil implementen otra.

    ''' <summary>
    ''' Evento del boton Buscar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        'Declaro una variable formulario del tipo buscar usuario
        Dim vloFrmBuscarUsuarios As New frmBuscarUsuario()

        'Establece cual es el padre del formulario
        vloFrmBuscarUsuarios.MdiParent = Me.MdiParent

        'Invoca al Abrir del formulario padre, y le pasa la interface
        vloFrmBuscarUsuarios.AlAbrir = CType(Me, frmInterfaceBuscarModificarEliminar)
        'vloFrmBuscarUsuarios.Owner = Me

        'Abre Formulario
        vloFrmBuscarUsuarios.Show()

        PBloquearDesBloquearCamposTxt(True)
        'Cambia el estado del formulario a busqueda
        PCambiarEstadoFormlarios(ESTADO_MENU.BUSQUEDA)
    End Sub

    ''' <summary>
    ''' Funcion de que implementa de la clase frmInterfaceBuscarModificarEliminar
    ''' Se Implementa en este caso un metodo que recibe un datatable con los registros
    ''' Cargados del formulario Hijo
    ''' Estos registros son extraidos por el nombre de sus columnas ( ver el metodo "FdtCargarDataTable")
    ''' </summary>
    ''' <param name="dataTableParam">datatable con los registros selecionados del grid</param>
    ''' <returns>Valor Boleano</returns>
    ''' <remarks>Roberto Cordero Q</remarks>
    Public Function FbCargarDataGrid(ByVal dataTableParam As DataTable) As Boolean Implements frmInterfaceBuscarModificarEliminar.FbCargarDataGrid
        'Declaro y instancion la fila, para eso pregunto pro la ultima fila del datatable
        'Existen otras maneras.
        Dim vlrFila As DataRow = dataTableParam.Rows(dataTableParam.Rows.Count - 1)

        'Asigno Valores.
        txtCedula.Text = CStr(vlrFila("Cedula"))
        txtNombre.Text = CStr(vlrFila("Nombre"))
        txtApellido1.Text = CStr(vlrFila("Apellido1"))
        txtApellido2.Text = CStr(vlrFila("Apellido2"))
        txtCorreoEletronico.Text = CStr(vlrFila("Correo"))

        'Truco para un check
        If chkM.Text = CStr(vlrFila("Genero")) Then
            chkM.Checked = True
        Else
            chkF.Checked = True

        End If
        'Pensar como manipular el idRol
        cboTipoRol.Text = ""
        cboTipoRol.Text = CStr(vlrFila("NombreRol"))
        'CStr(row("IdRol"))
        txtCedula.Enabled = False

        Return True

    End Function


#Region "Atributos"


#End Region

#Region "Constructor"

    Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

#End Region

#Region "Constantes"
    ''' <summary>
    ''' Enumerador que sirve para manejar los diferentes estados del formulario principal
    ''' </summary>
    ''' <remarks></remarks>
    Enum ESTADO_MENU
        'Todo formulario inicia con este estado (consulta no es buscar)
        CONSULTA = 1
        'Estado cuando el usuario presiona nuevo
        INSERCION = 2
        'Estado de modificacion
        EDICION = 3
        'estado de eliminacion
        ELIMINAR = 4
        'Estado de guardado de un formulario
        GUARDAR = 5

        BUSQUEDA = 6


    End Enum

    ''' <summary>
    ''' Enumerador que sirfe para identifiar los direntes controles y asociarlos con los atributos de los usuarios
    ''' Se utiliza en el case de las validaciones
    ''' </summary>
    ''' <remarks></remarks>
    Enum CAMPOS
        NOCAMPOS = -1
        CEDULA = 0
        NOMBRE = 1
        APELLIDO1 = 2
        APELLIDO2 = 3
        CORREO = 4
    End Enum

#End Region

#Region "Procedimientos"

    ''' <summary>
    ''' Procedimiento encargado de limpiar los campos del formulario
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub PLimpiarCampos()
        'En caso de error
        Try
            'Se limpian los controles
            txtNombre.Text() = String.Empty
            txtCedula.Text() = String.Empty
            txtApellido1.Text = String.Empty
            txtApellido2.Text() = String.Empty

            txtCorreoEletronico.Text = String.Empty
            '   cboTipoRol.Text = String.Empty
            'Si produce Error
        Catch ex As Exception
            'Lanza Error
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Cambia el estado del formulario segun el boton presionado
    ''' Habilita o deshabilita controles segun en el estado que se encuentre
    ''' </summary> 
    ''' <param name="pvnEstado"></param>
    ''' <remarks></remarks>
    Public Sub PCambiarEstadoFormlarios(ByVal pvnEstado As Int32)

        Try
            Select Case pvnEstado

                'El estado consulta es DIeSTINTO a buscar
                'En este estado deja hacer lo basico, siguiendo la logica de que estado entro a un formulario
                Case Is = ESTADO_MENU.CONSULTA
                    PBloquearDesBloquearCamposTxt(False)
                    'Habilitaciones
                    btnNuevo.Enabled = True
                    btnBuscar.Enabled = True
                    'Deshabilitaciones
                    btnModificar.Enabled = False
                    btnGuardar.Enabled = False
                    btnEliminar.Enabled = False
                    btnDeshacer.Enabled = False

                    'Habilita o deshabilita controles segun su estado de INSERTAR
                Case Is = ESTADO_MENU.INSERCION
                    'Habilitaciones
                    btnGuardar.Enabled = True
                    btnDeshacer.Enabled = True
                    'Deshabilitaciones
                    btnNuevo.Enabled = False
                    btnEliminar.Enabled = False
                    btnModificar.Enabled = False

                    'Habilita o deshabilita controles segun su estado de ELIMINAR
                Case Is = ESTADO_MENU.ELIMINAR
                    btnGuardar.Enabled = True
                    btnDeshacer.Enabled = True

                    btnEliminar.Enabled = False
                    btnNuevo.Enabled = False
                    PCambiarEstadoFormlarios(ESTADO_MENU.CONSULTA)

                    'Habilita o deshabilita controles segun su estado de EDICION (MODIFICAR)
                Case Is = ESTADO_MENU.EDICION
                    'Habilitaciones
                    btnDeshacer.Enabled = True
                    btnModificar.Enabled = False

                    'Deshablitaciones
                    btnEliminar.Enabled = False
                    btnGuardar.Enabled = False
                Case Is = ESTADO_MENU.GUARDAR

                    'Si se le da guardar existen otros estados para dejar el formulario pero pienso
                    'que el formulario deberia volver a estado de insercion en este caso de mantenimiento
                    'PCambiarEstadoFormlarios(ESTADO_MENU.INSERCION)
                    PCambiarEstadoFormlarios(ESTADO_MENU.CONSULTA)

                Case Is = ESTADO_MENU.BUSQUEDA
                    btnGuardar.Enabled = False

                    '
                    btnDeshacer.Enabled = True
                    btnBuscar.Enabled = True
                    btnModificar.Enabled = True

                    btnEliminar.Enabled = True
                    btnNuevo.Enabled = False


            End Select

        Catch ex As Exception
            'Lanza Error
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Bloquear-Desbloquear campos segun parametro que recibe
    ''' </summary>
    ''' <param name="pvbBloquear"></param>
    ''' <remarks></remarks>
    Public Sub PBloquearDesBloquearCamposTxt(ByVal pvbBloquear As Boolean)
        'En caso de error
        Try
            txtNombre.Enabled = pvbBloquear
            txtCedula.Enabled = pvbBloquear
            txtApellido1.Enabled = pvbBloquear
            txtApellido2.Enabled = pvbBloquear
            cboTipoRol.Enabled = pvbBloquear
            chkF.Enabled = pvbBloquear
            chkM.Enabled = pvbBloquear
            'Si produce Error
        Catch ex As Exception
            'Lanza Error
            Throw ex
        End Try


    End Sub

#End Region

#Region "Funciones"

    ''' <summary>
    ''' Muestra o Oculta las diferentes validaciones
    ''' </summary>
    ''' <param name="pvbMostrar">Este parametro boolean establece el mostrar o no de los label</param>
    ''' <param name="pvnOpcion">Para entrar a la opcion del case</param>
    ''' <returns>vlbEsValida, si la validacion es valida o no</returns>
    ''' <remarks>Roberto Cordero Q</remarks>
    Function FbMostrarValidaciones(ByVal pvbMostrar As Boolean, ByVal pvnOpcion As Integer) As Boolean
        'Declaro el valor a retonar en verdadero.
        Dim vlbEsValida As Boolean = True

        'En caso de Error
        Try
            'Inicia el case esperando la opcion (Ver Enunmeradores)
            Select Case (pvnOpcion)
                'Si Case es -1.
                Case CAMPOS.NOCAMPOS
                    'Segun el valor del parametro booleando los muestra o no.
                    lblValidaCedula.Visible = pvbMostrar
                    lblValidaNombre.Visible = pvbMostrar
                    lblValidaApellido.Visible = pvbMostrar
                    lblValidaApellido2.Visible = pvbMostrar
                    lblValidaGeneros.Visible = pvbMostrar
                    lblValidaTipoRol.Visible = pvbMostrar
                    lblValidaCorreoEletronico.Visible = pvbMostrar
                    vlbEsValida = pvbMostrar

                    vlbEsValida = pvbMostrar

                Case CAMPOS.CEDULA
                    'Si muestra porque es verdadero.
                    If pvbMostrar = True Then
                        'El label es visible.
                        lblValidaCedula.Visible = pvbMostrar
                    Else
                        lblValidaCedula.Visible = pvbMostrar
                        vlbEsValida = pvbMostrar
                    End If

                Case CAMPOS.NOMBRE
                    If pvbMostrar = True Then
                        lblValidaNombre.Visible = pvbMostrar
                    Else
                        lblValidaNombre.Visible = pvbMostrar
                        vlbEsValida = pvbMostrar
                    End If

                Case CAMPOS.APELLIDO1
                    If pvbMostrar = True Then
                        lblValidaApellido.Visible = pvbMostrar
                    Else
                        lblValidaApellido.Visible = pvbMostrar
                        vlbEsValida = pvbMostrar
                    End If

                Case CAMPOS.APELLIDO2

                    If pvbMostrar = True Then
                        lblValidaApellido2.Visible = pvbMostrar
                    Else
                        lblValidaApellido2.Visible = pvbMostrar
                        vlbEsValida = pvbMostrar
                    End If

                Case CAMPOS.CORREO

                    If pvbMostrar = True Then
                        lblValidaCorreoEletronico.Visible = pvbMostrar
                    Else
                        lblValidaCorreoEletronico.Visible = pvbMostrar
                        vlbEsValida = pvbMostrar
                    End If

            End Select

            Return vlbEsValida
            'Si produce Error
        Catch ex As Exception
            'Lanza Error
            Throw ex
        End Try
    End Function

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Load del formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Roberto Cordero Quiros</remarks>
    Private Sub frmMantenimientoUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'En caso de error
        Try


            PLLenarCombo()

            chkF.Checked = True
            'Llama al procedimiento y bloque los campos.
            PBloquearDesBloquearCamposTxt(False)

            'Se maximiza la pantalla al maximo.
            Me.WindowState = FormWindowState.Maximized
            'Me.Width = (Me.Parent.Width - Me.Width) \ 2
            'Me.Height = (Me.Parent.Height - Me.Height) \ 2
            'Llama al procedimiento cambiar estados formularios y lo establece en modo consulta.
            PCambiarEstadoFormlarios(ESTADO_MENU.CONSULTA)

            FbMostrarValidaciones(False, CAMPOS.NOCAMPOS)

            cboTipoRol.SelectedIndex = 1
            'Si produce Error
        Catch ex As Exception
            'Lanza Error
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Evento que se genera cuando el chequeado del chebox es cambiado.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub chkM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkM.CheckedChanged
        'En caso de error
        Try
            'Valido si lo chequeado MASCULINO es verdadero.
            If chkM.Checked = True Then
                'ASIGNO el chequeado FEMENINO a Falso (puesto que el Masculino es verdadero)
                chkF.Checked = False
                'Oculta el label de validacion de genero.
                lblValidaGeneros.Visible = False
            ElseIf chkF.Checked = False Then
                'Muestra el label de validacion de genero.
                lblValidaGeneros.Visible = True
            End If
            'Si produce Error
        Catch ex As Exception
            'Lanza Error
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Evento que se genera cuando el chekeado del chebox es cambiado.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Roberto Cordero Quiros</remarks>
    Private Sub chkF_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkF.CheckedChanged
        'En caso de Error
        Try
            'Valido si lo chequeado FEMENINO es verdadero.
            If chkF.Checked = True Then
                'ASIGNO el chequeado MASCULINO a Falso (puesto que el femenino es verdadero)
                chkM.Checked = False
                'Oculta el label de validacion de genero.
                lblValidaGeneros.Visible = False

                'Si es falso (comentario: podria ir solo un ELSE)
            ElseIf chkF.Checked = False Then
                'Muestro el label de validación de genero
                lblValidaGeneros.Visible = True
            End If

            'Si produce Error
        Catch ex As Exception
            'Lanza Error
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Es un evento que se ejecuta cuando el usuario suelta una tecla, valida el campo.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Roberto Cordero Quiros</remarks>
    Private Sub txtNombre_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyUp
        'En caso de error
        Try
            'Si el campo  es vacio
            If Trim(txtNombre.Text) = String.Empty Then
                'Manda a mostrar el label
                FbMostrarValidaciones(True, CAMPOS.NOMBRE)
            Else
                'Oculta el label
                FbMostrarValidaciones(False, CAMPOS.NOMBRE)
            End If

            'Si produce Error
        Catch ex As Exception
            'Lanza Error
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtApellido1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtApellido1.KeyUp
        'En caso de error
        Try
            If Trim(txtApellido1.Text) = String.Empty Then
                'Manda a mostrar el label
                FbMostrarValidaciones(True, CAMPOS.APELLIDO1)
            Else
                'Oculta el label
                FbMostrarValidaciones(False, CAMPOS.APELLIDO1)
            End If

            'Si produce Error
        Catch ex As Exception
            'Lanza Error
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtApellido2_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtApellido2.KeyUp
        'En caso de error
        Try

            If Trim(txtApellido2.Text) = String.Empty Then
                FbMostrarValidaciones(True, CAMPOS.APELLIDO2)
            Else
                FbMostrarValidaciones(False, CAMPOS.APELLIDO2)
            End If

            'Si produce Error
        Catch ex As Exception
            'Lanza Error
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtCedula_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCedula.KeyUp
        If Trim(txtCedula.Text) = String.Empty Then
            FbMostrarValidaciones(True, CAMPOS.CEDULA)
        Else
            FbMostrarValidaciones(False, CAMPOS.CEDULA)
        End If
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtCorreoEletronico_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCorreoEletronico.KeyUp
        If Trim(txtCorreoEletronico.Text) = String.Empty Then
            FbMostrarValidaciones(True, CAMPOS.CORREO)
        Else
            FbMostrarValidaciones(False, CAMPOS.CORREO)
        End If
    End Sub


#End Region

    ''' <summary>
    ''' Evento del boton nuevo
    ''' Al hacer nuevo la idea, es dejar el formulario apto para registrar un usuario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>By:Roberto Cordero Quiros</remarks>
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Try
            'Desbloquea los campos de texto
            PBloquearDesBloquearCamposTxt(True)
            'Se le hace focus a la llave primaria
            txtCedula.Focus()

            'Cambia el estado del formulario a insercion
            PCambiarEstadoFormlarios(ESTADO_MENU.INSERCION)

        Catch ex As Exception
            'Invoca mensaje de error
        End Try
    End Sub

    ''' <summary>
    '''  Evento del boton guardar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If FbValidarCamposTotal() = True Then

            PRegistrarUsuario()

            PCambiarEstadoFormlarios(ESTADO_MENU.GUARDAR)

            PLimpiarCampos()

        Else
            MsgBox("Digite los campos indicados")
        End If
    End Sub

    ''' <summary>
    ''' Evento del boton Deshacer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnDeshacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeshacer.Click
        PLimpiarCampos()
        PCambiarEstadoFormlarios(ESTADO_MENU.CONSULTA)
    End Sub

    ''' <summary>
    ''' Evento del boton eliminar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        ' Declaran varialbes
        Dim vlcCedula As String
        Dim vlcMensaje
        ' Asigna el valor del campo cedula
        vlcCedula = txtCedula.Text
        vlcMensaje = "Desesa borrar el usuario con numero de cédula: " & txtCedula.Text & _
            " y nombre: " & txtNombre.Text
        Dim button As DialogResult = MessageBox.Show(vlcMensaje, "Usuario: ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
        If button = DialogResult.Yes Then
            MessageBox.Show("Se Elimino el Regritro")
            GestorUsuario.eliminarUsuario(vlcCedula)
            PCambiarEstadoFormlarios(ESTADO_MENU.ELIMINAR)
            PLimpiarCampos()
        Else
            MessageBox.Show("No se elimino")
        End If


    End Sub

    ''' <summary>
    '''  Evento del boton Modificar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        txtCedula.Enabled = False
        If FbValidarCamposTotal() = True Then


            Dim vlcCedula As String = txtCedula.Text
            Dim vlcNombre As String = txtNombre.Text
            Dim vlcApellido1 As String = txtApellido1.Text
            Dim vlcApellido2 As String = txtApellido2.Text
            Dim vlcCorreo As String = txtCorreoEletronico.Text
            Dim vlnTipoRol As Integer = cboTipoRol.SelectedValue
            Dim vlbGenero As Char

            If chkF.Checked = True Then
                vlbGenero = chkF.Text
            Else
                vlbGenero = chkM.Text
            End If


            PCambiarEstadoFormlarios(ESTADO_MENU.EDICION)


            Dim vlcMensaje
            vlcMensaje = "Desesa Modificar el usuario con numero de cédula: " & txtCedula.Text & _
                "y nombre: " & txtNombre.Text
            Dim button As DialogResult = MessageBox.Show(vlcMensaje, "Usuario", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
            If button = DialogResult.Yes Then
                GestorUsuario.actualizarUsuario(vlcCedula, vlcNombre, vlcApellido1, _
                                       vlcApellido2, vlcCorreo, vlbGenero, vlnTipoRol)
                MessageBox.Show("Se valida la información y se almacena")
                PLimpiarCampos()
                PCambiarEstadoFormlarios(ESTADO_MENU.CONSULTA)
            Else
                MessageBox.Show("No se Modifico")
            End If

        Else
            MsgBox("Digite los campos indicados")
        End If
    End Sub

    ''' <summary>
    ''' Este metodo se llama en los enventos que tengan que validar todos los campos al mismo tiempo.
    ''' Ejemplo guardar, o al modificar
    ''' </summary>
    ''' <returns>Retorna si todos los campos estan validados a o no</returns>
    ''' <remarks>Roberto Cordero</remarks>
    Public Function FbValidarCamposTotal() As Boolean
        Dim vlbValidado As Boolean

        'En caso de error
        Try
            vlbValidado = True

            If Trim(txtCedula.Text) = String.Empty Then
                FbMostrarValidaciones(True, CAMPOS.CEDULA)
                vlbValidado = False
            Else
                FbMostrarValidaciones(False, CAMPOS.CEDULA)
            End If
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            If Trim(txtNombre.Text) = String.Empty Then
                FbMostrarValidaciones(True, CAMPOS.NOMBRE)
                vlbValidado = False
            Else
                FbMostrarValidaciones(False, CAMPOS.NOMBRE)
            End If
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            If Trim(txtApellido1.Text) = String.Empty Then
                FbMostrarValidaciones(True, CAMPOS.APELLIDO1)
                vlbValidado = False
            Else
                FbMostrarValidaciones(False, CAMPOS.APELLIDO1)
            End If
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            If Trim(txtApellido2.Text) = String.Empty Then
                FbMostrarValidaciones(True, CAMPOS.APELLIDO2)
                vlbValidado = False
            Else
                FbMostrarValidaciones(False, CAMPOS.APELLIDO2)
            End If
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            If Trim(txtCorreoEletronico.Text) = String.Empty Then
                FbMostrarValidaciones(True, CAMPOS.CORREO)
                vlbValidado = False
            Else
                FbMostrarValidaciones(False, CAMPOS.CORREO)
            End If
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'If cboTipoRol.SelectedItem = String.Empty Then
            '    lblValidaTipoRol.Visible = True
            '    vlbValidado = False
            'Else
            '    lblValidaTipoRol.Visible = False
            'End If
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'Valida si no se selciona algun check box, y valida que por lo menos se asigne alguno de los 2
            If chkM.Checked = False And chkF.Checked = False Then
                lblValidaGeneros.Visible = True
                vlbValidado = False
            ElseIf chkM.Checked = True Then
                lblValidaGeneros.Visible = False

            ElseIf chkF.Checked = True Then

                lblValidaGeneros.Visible = False

            End If

            'Retorna si esta validado, si retorna false es porq no esta validado
            Return vlbValidado
            'Si produce Error
        Catch ex As Exception
            'Lanza Error
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Procedimiento para Registrar Usuario a la Base de datos.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub PRegistrarUsuario()
        Dim vlcCedula As String = txtCedula.Text
        Dim vlcNombre As String = txtNombre.Text
        Dim vlcApellido1 As String = txtApellido1.Text
        Dim vlcApellido2 As String = txtApellido2.Text
        Dim vlcCorreo As String = txtCorreoEletronico.Text
        Dim vlnTipoRol As Integer = cboTipoRol.SelectedValue
        Dim vlbGenero As Char

        If chkF.Checked = True Then
            vlbGenero = chkF.Text
        Else
            vlbGenero = chkM.Text
        End If

        GestorUsuario.registrarUsuario(vlcCedula, vlcNombre, vlcApellido1, _
                                       vlcApellido2, vlcCorreo, vlbGenero, vlnTipoRol)

    End Sub

    Private Sub PLLenarCombo()



        Dim vloListaTemporal As List(Of LN.Estructuras.StrRol)

        vloListaTemporal = GestorRol.listarRoles()


        cboTipoRol.ValueMember = "IdRol"


        cboTipoRol.DisplayMember = "NombreRol"


        cboTipoRol.DataSource = vloListaTemporal


    End Sub



End Class