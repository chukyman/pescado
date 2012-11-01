Imports LN.Gestores
Public Class frmMantenimientoCurso




#Region "Eventos"

    ''' <summary>
    ''' Load de el formulario de mantenimiento de cursos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Diego Salas Arce</remarks>
    Private Sub frmMantenimientoCurso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '
            PLLenarCombo()

            'Llama al procedimiento y bloque los campos.
            PBloquearDesBloquearCamposTxt(False)

            'Se maximiza la pantalla al maximo.
            Me.WindowState = FormWindowState.Maximized
            'Llama al procedimiento cambiar estados formularios y lo establece en modo consulta.
            PCambiarEstadoFormlarios(ESTADO_MENU.CONSULTA)

            FbMostrarValidaciones(False, CAMPOS.NOCAMPOS)
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
    Private Sub txtCodigo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyUp
        Try
            'Si el campo  es vacio
            If Trim(txtCodigo.Text) = String.Empty Then
                'Manda a mostrar el label
                FbMostrarValidaciones(True, CAMPOS.CODIGO)
            Else
                'Oculta el label
                FbMostrarValidaciones(False, CAMPOS.CODIGO)
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
    ''' Evento del boton Buscar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        'Declaro una variable formulario del tipo buscar usuario
        Dim vloFrmBuscarCurso As New frmBuscarCurso
        'Abre el formulario
        vloFrmBuscarCurso.ShowDialog()

        PBloquearDesBloquearCamposTxt(True)
        'Cambia el estado del formulario a busqueda
        PCambiarEstadoFormlarios(ESTADO_MENU.BUSQUEDA)
    End Sub


    ''' <summary>
    ''' Evento del boton nuevo
    ''' Al hacer nuevo la idea, es dejar el formulario apto para registrar un curso
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Diego Salas Arce</remarks>
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Try

            'Desbloquea los campos de texto
            PBloquearDesBloquearCamposTxt(True)
            'Se le hace focus a la llave primaria
            txtCodigo.Focus()

            'Cambia el estado del formulario a insercion
            PCambiarEstadoFormlarios(ESTADO_MENU.INSERCION)

        Catch ex As Exception
            'Invoca mensaje de error
        End Try
    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If FbValidarCamposTotal() = True Then


            PRegistrarCurso()
            PLimpiarCampos()
            PCambiarEstadoFormlarios(ESTADO_MENU.GUARDAR)


        Else
            MsgBox("Digite los campos indicados")
        End If




    End Sub

    Private Sub PRegistrarCurso()
        Dim vblEstado As Boolean
        If cboEstado.SelectedIndex = 1 Then
            vblEstado = True
        End If
        If cboEstado.SelectedIndex = 2 Then
            vblEstado = False
        End If
       
        Try
            GestorCurso.registrarCurso(txtCodigo.Text, txtNombre.Text, 1, vblEstado)
            MsgBox("Los datos se han registrado correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub





    ''' <summary>
    ''' Evento del boton eliminar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        PEliminarCurso()
        PCambiarEstadoFormlarios(ESTADO_MENU.ELIMINAR)
    End Sub


    Private Sub PEliminarCurso()
        Try
            GestorCurso.eliminarCurso(txtCodigo.Text)
            MsgBox("Los datos han sido eliminados")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        txtCodigo.Enabled = False
        If FbValidarCamposTotal() = True Then

            PModificarCurso()
            PLimpiarCampos()
            PCambiarEstadoFormlarios(ESTADO_MENU.EDICION)

            txtCodigo.Enabled = True
        Else
            MsgBox("Digite los campos indicados")
        End If



    End Sub

    Private Sub PModificarCurso()
        Dim vblEstado As Boolean
        If cboEstado.SelectedIndex = 1 Then
            vblEstado = True
        End If
        If cboEstado.SelectedIndex = 2 Then
            vblEstado = False
        End If

        Try
            GestorCurso.modificarCurso(txtCodigo.Text, txtNombre.Text, 1, vblEstado)
            MsgBox("Los datos se modificado registrado correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDeshacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeshacer.Click
        PLimpiarCampos()
        PCambiarEstadoFormlarios(ESTADO_MENU.CONSULTA)
    End Sub

#End Region

#Region "Atributos"

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
        CODIGO = 0
        NOMBRE = 1
        CARRERA = 2
        ESTADO = 3
    End Enum
#End Region

#Region "Funciones"

    ''' <summary>
    ''' Muestra o Oculta las diferentes validaciones
    ''' </summary>
    ''' <param name="pvbMostrar">Este parametro boolean establece el mostrar o no de los label</param>
    ''' <param name="pvnOpcion">Para entrar a la opcion del case</param>
    ''' <returns>vlbEsValida, si la validacion es valida o no</returns>
    ''' <remarks>Diego Salas Arce</remarks>
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
                    lblValidaCodigo.Visible = pvbMostrar
                    lblValidaNombre.Visible = pvbMostrar
                    lblValidaCarrera.Visible = pvbMostrar
                    vlbEsValida = pvbMostrar

                    vlbEsValida = pvbMostrar

                Case CAMPOS.CODIGO
                    'Si muestra porque es verdadero.
                    If pvbMostrar = True Then
                        'El label es visible.
                        lblValidaCodigo.Visible = pvbMostrar
                    Else
                        lblValidaCodigo.Visible = pvbMostrar
                        vlbEsValida = pvbMostrar
                    End If

                Case CAMPOS.NOMBRE
                    If pvbMostrar = True Then
                        lblValidaNombre.Visible = pvbMostrar
                    Else
                        lblValidaNombre.Visible = pvbMostrar
                        vlbEsValida = pvbMostrar
                    End If

                Case CAMPOS.CARRERA
                    If pvbMostrar = True Then
                        lblValidaCarrera.Visible = pvbMostrar
                    Else
                        lblValidaCarrera.Visible = pvbMostrar
                        vlbEsValida = pvbMostrar
                    End If
                Case CAMPOS.ESTADO
                    If pvbMostrar = True Then
                        lblValidaEstado.Visible = pvbMostrar
                    Else
                        lblValidaEstado.Visible = pvbMostrar
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

    ''' <summary>
    ''' Este metodo se llama en los enventos que tengan que validar todos los campos al mismo tiempo.
    ''' Ejemplo guardar, o al modificar
    ''' </summary>
    ''' <returns>Retorna si todos los campos estan validados a o no</returns>
    ''' <remarks>Diego Salas</remarks>
    Public Function FbValidarCamposTotal() As Boolean
        Dim vlbValidado As Boolean

        'En caso de error
        Try
            vlbValidado = True

            If Trim(txtCodigo.Text) = String.Empty Then
                FbMostrarValidaciones(True, CAMPOS.CODIGO)
                vlbValidado = False
            Else
                FbMostrarValidaciones(False, CAMPOS.CODIGO)
            End If
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            If Trim(txtNombre.Text) = String.Empty Then
                FbMostrarValidaciones(True, CAMPOS.NOMBRE)
                vlbValidado = False
            Else
                FbMostrarValidaciones(False, CAMPOS.NOMBRE)
            End If
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            If cboCarrera.SelectedIndex = 0 Then
                FbMostrarValidaciones(True, CAMPOS.CARRERA)
                vlbValidado = False
            Else
                FbMostrarValidaciones(False, CAMPOS.CARRERA)
            End If
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            If cboEstado.SelectedIndex = 0 Then
                FbMostrarValidaciones(True, CAMPOS.ESTADO)
                vlbValidado = False
            Else
                FbMostrarValidaciones(False, CAMPOS.ESTADO)
            End If
            'Retorna si esta validado, si retorna false es porq no esta validado
            Return vlbValidado
            'Si produce Error
        Catch ex As Exception
            'Lanza Error
            Throw ex
        End Try
    End Function

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
            txtCodigo.Text() = String.Empty
            txtNombre.Text() = String.Empty
            cboCarrera.SelectedIndex = -1
            cboEstado.SelectedIndex = -1
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
            txtCodigo.Enabled = pvbBloquear
            txtNombre.Enabled = pvbBloquear
            cboCarrera.Enabled = pvbBloquear
            'Si produce Error
        Catch ex As Exception
            'Lanza Error
            Throw ex
        End Try

    End Sub
#End Region


    'Private Sub cboCarrera_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCarrera.SelectedIndexChanged
    '    GestorCarrera.listarCarrera()

    '    cboCarrera.DataSource = GestorCarrera.listarCarrera()

    'End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PLLenarCombo()
        Dim vloListaTemporal As List(Of LN.Estructuras.StrCarrera)

        vloListaTemporal = GestorCarrera.listarCarrera()

        '  For vln As Integer = 0 To vloListaTemporal.Count - 1
        ' cboCarrera.Items.Add(vln)

        'cboCarrera.ValueMember(vloListaTemporal.Item(vln).Nombre)


        'cboCarrera.SelectedValue = vloListaTemporal.Item(vln).Id_Carrera
        cboCarrera.ValueMember = "Id_Carrera"

        cboCarrera.DisplayMember = "Nombre"

        cboCarrera.DataSource = vloListaTemporal


        ' Next


    End Sub
End Class
