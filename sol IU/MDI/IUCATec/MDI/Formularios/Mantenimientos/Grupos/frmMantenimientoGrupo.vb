Imports LN.Estructuras
Public Class frmMantenimientoGrupo
    'Fecha: 20/10/2012
    'Desarrollador: Diego Salas Arce
#Region "Eventos"
    Private Sub frmMantenimientoGrupo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

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
                    lblValidaCurso.Visible = pvbMostrar
                    lblValidaNombre.Visible = pvbMostrar
                    lblValidaHorario.Visible = pvbMostrar
                    lblValidaDescripcion.Visible = pvbMostrar
                    lblValidaCantEst.Visible = pvbMostrar

                    vlbEsValida = pvbMostrar
                    vlbEsValida = pvbMostrar

                Case CAMPOS.CURSO
                    'Si muestra porque es verdadero.
                    If pvbMostrar = True Then
                        'El label es visible.
                        lblValidaCurso.Visible = pvbMostrar
                    Else
                        lblValidaCurso.Visible = pvbMostrar
                        vlbEsValida = pvbMostrar
                    End If

                Case CAMPOS.NOMBRE
                    If pvbMostrar = True Then
                        lblValidaNombre.Visible = pvbMostrar
                    Else
                        lblValidaNombre.Visible = pvbMostrar
                        vlbEsValida = pvbMostrar
                    End If

                Case CAMPOS.HORARIO
                    If pvbMostrar = True Then
                        lblValidaHorario.Visible = pvbMostrar
                    Else
                        lblValidaHorario.Visible = pvbMostrar
                        vlbEsValida = pvbMostrar
                    End If

                Case CAMPOS.DESCRIPCION
                    If pvbMostrar = True Then
                        lblValidaDescripcion.Visible = pvbMostrar
                    Else
                        lblValidaDescripcion.Visible = pvbMostrar
                        vlbEsValida = pvbMostrar
                    End If

                Case CAMPOS.CANTIDADEST
                    If pvbMostrar = True Then
                        lblValidaCantEst.Visible = pvbMostrar
                    Else
                        lblValidaCantEst.Visible = pvbMostrar
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

            If cboCursos.SelectedIndex = -1 Then
                FbMostrarValidaciones(True, CAMPOS.CURSO)
                vlbValidado = False
            Else
                FbMostrarValidaciones(False, CAMPOS.CURSO)
            End If
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            If Trim(txtNombre.Text) = String.Empty Then
                FbMostrarValidaciones(True, CAMPOS.NOMBRE)
                vlbValidado = False
            Else
                FbMostrarValidaciones(False, CAMPOS.NOMBRE)
            End If
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            If Trim(txtHorario.Text) = String.Empty Then
                FbMostrarValidaciones(True, CAMPOS.HORARIO)
                vlbValidado = False
            Else
                FbMostrarValidaciones(False, CAMPOS.HORARIO)
            End If
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            If Trim(txtDescripcion.Text) = String.Empty Then
                FbMostrarValidaciones(True, CAMPOS.DESCRIPCION)
                vlbValidado = False
            Else
                FbMostrarValidaciones(False, CAMPOS.DESCRIPCION)
            End If

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            If Trim(txtCantEstudiantes.Text) = String.Empty Then
                FbMostrarValidaciones(True, CAMPOS.CANTIDADEST)
                vlbValidado = False
            Else
                FbMostrarValidaciones(False, CAMPOS.CANTIDADEST)
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
            cboCursos.SelectedIndex = -1
            txtNombre.Text() = String.Empty
            txtHorario.Text() = String.Empty
            txtDescripcion.Text() = String.Empty
            txtCantEstudiantes.Text() = String.Empty

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
            cboCursos.Enabled = pvbBloquear
            txtNombre.Enabled = pvbBloquear
            txtHorario.Enabled = pvbBloquear
            txtDescripcion.Enabled = pvbBloquear
            txtCantEstudiantes.Enabled = pvbBloquear

            'Si produce Error
        Catch ex As Exception
            'Lanza Error
            Throw ex
        End Try

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
        CURSO = 0
        NOMBRE = 1
        HORARIO = 2
        DESCRIPCION = 3
        CANTIDADEST = 4
    End Enum
#End Region

#Region "Atributos"


#End Region


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Diego Salas Arce</remarks>
    Private Sub cboCursos_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboCursos.KeyUp
        Try
            'Si el campo es vacío
            If cboCursos.SelectedIndex = -1 Then
                'Muestra el label
                FbMostrarValidaciones(True, CAMPOS.CURSO)
            Else
                'Oculta el label
                FbMostrarValidaciones(False, CAMPOS.CURSO)
            End If
            'Si produce error
        Catch ex As Exception
            'Lanza el error
            Throw ex
        End Try
    End Sub


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


    Private Sub txtHorario_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtHorario.KeyUp
        Try
            'Si el campo  es vacio
            If Trim(txtHorario.Text) = String.Empty Then
                'Manda a mostrar el label
                FbMostrarValidaciones(True, CAMPOS.HORARIO)
            Else
                'Oculta el label
                FbMostrarValidaciones(False, CAMPOS.HORARIO)
            End If

            'Si produce Error
        Catch ex As Exception
            'Lanza Error
            Throw ex
        End Try
    End Sub


    Private Sub txtDescripcion_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcion.KeyUp
        Try
            'Si el campo  es vacio
            If Trim(txtDescripcion.Text) = String.Empty Then
                'Manda a mostrar el label
                FbMostrarValidaciones(True, CAMPOS.DESCRIPCION)
            Else
                'Oculta el label
                FbMostrarValidaciones(False, CAMPOS.DESCRIPCION)
            End If

            'Si produce Error
        Catch ex As Exception
            'Lanza Error
            Throw ex
        End Try
    End Sub

    Private Sub txtCantEstudiantes_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCantEstudiantes.KeyUp
        Try
            'Si el campo  es vacio
            If Trim(txtCantEstudiantes.Text) = String.Empty Then
                'Manda a mostrar el label
                FbMostrarValidaciones(True, CAMPOS.CANTIDADEST)
            Else
                'Oculta el label
                FbMostrarValidaciones(False, CAMPOS.CANTIDADEST)
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
        ''Declaro una variable formulario del tipo buscar usuario
        Dim vloFrmBuscarCurso As New frmBuscarGrupo
        ''Abre el formulario
        vloFrmBuscarCurso.ShowDialog()

        PBloquearDesBloquearCamposTxt(True)
        ''Cambia el estado del formulario a busqueda
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
            cboCursos.Focus()

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

            PLimpiarCampos()
            PCambiarEstadoFormlarios(ESTADO_MENU.GUARDAR)

        Else
            MsgBox("Digite los campos indicados")
        End If
    End Sub

    ''' <summary>
    ''' Evento del boton eliminar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        PCambiarEstadoFormlarios(ESTADO_MENU.ELIMINAR)
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If FbValidarCamposTotal() = True Then

            PLimpiarCampos()
            PCambiarEstadoFormlarios(ESTADO_MENU.EDICION)
        Else
            MsgBox("Digite los campos indicados")
        End If
    End Sub

    Private Sub btnDeshacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeshacer.Click
        PLimpiarCampos()
        PCambiarEstadoFormlarios(ESTADO_MENU.CONSULTA)
    End Sub

    Public Sub llenarFormularioAlModificar(ByVal pstr As StrGrupo)
        Dim nombre, horario, descripcion As String
        nombre = pstr.Nombre
        horario = pstr.Horario
        descripcion = pstr.Descripcion
    End Sub
End Class