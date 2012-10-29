'Fecha: 20/10/2012
'Desarrollado: Julio Moreira

Imports LN.Gestores


Public Class frmMantenimientoCarrera
    Implements frmInterfaceBuscarModificarEliminar






    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        'Declaro una variable formulario del tipo buscar usuario
        Dim vloFrmBuscarCarreras As New frmBuscarCarrera()

        'Establece cual es el padre del formulario
        vloFrmBuscarCarreras.MdiParent = Me.MdiParent

        'Invoca al Abrir del formulario padre, y le pasa la interface
        vloFrmBuscarCarreras.AlAbrir = CType(Me, frmInterfaceBuscarModificarEliminar)
        'vloFrmBuscarUsuarios.Owner = Me

        'Abre Formulario
        vloFrmBuscarCarreras.Show()

        PBloquearDesBloquearCamposTxt(True)
        'Cambia el estado del formulario a busqueda
        PCambiarEstadoFormlarios(ESTADO_MENU.BUSQUEDA)
    End Sub

    Public Function FbCargarDataGrid(ByVal dataTableParam As DataTable) As Boolean Implements frmInterfaceBuscarModificarEliminar.FbCargarDataGrid
        'Declaro y instancion la fila, para eso pregunto pro la ultima fila del datatable
        'Existen otras maneras.
        Dim vlrFila As DataRow = dataTableParam.Rows(dataTableParam.Rows.Count - 1)

        'Asigno Valores.



        txtCodigo.Text = CStr(vlrFila("Codigo"))
        txtNombre.Text = CStr(vlrFila("Nombre"))
        '*****************************************************************************
        'TENGO QUE VER COMO PASO EL ID DEL DIRECTOR
        '*****************************************************************************

        Return True

    End Function


    Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub




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
        DA = 2
    End Enum


    Public Sub PBloquearDesBloquearCamposTxt(ByVal pvbBloquear As Boolean)
        'En caso de error
        Try
            txtCodigo.Enabled = pvbBloquear
            txtNombre.Enabled = pvbBloquear
            cboDA.Enabled = pvbBloquear

            'Si produce Error
        Catch ex As Exception
            'Lanza Error
            Throw ex
        End Try


    End Sub
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
            cboDA.Text = String.Empty
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

#End Region


#Region "Funciones"

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="pvbMostrar"></param>
    ''' <param name="pvnOpcion"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
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
                    lblValidaDA.Visible = pvbMostrar
                    

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

                Case CAMPOS.DA
                    If pvbMostrar = True Then
                        lblValidaDA.Visible = pvbMostrar
                    Else
                        lblValidaDA.Visible = pvbMostrar
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
    ''' Evento que maneja las acciones cuando carga el form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Julio Moreira</remarks>
    Private Sub frmMantenimientoCarrera_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        PCambiarEstadoFormlarios(ESTADO_MENU.CONSULTA)
        PBloquearDesBloquearCamposTxt(False)


    End Sub



    Private Sub txtCodigo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'En caso de error
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



    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub txtNombre_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
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

#End Region




    Private Sub btnDeshacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeshacer.Click
        PLimpiarCampos()
        PCambiarEstadoFormlarios(ESTADO_MENU.CONSULTA)
    End Sub



    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Try

            'Desbloquea los campos de texto
            PBloquearDesBloquearCamposTxt(True)
            'Se le hace focus a la llave primaria
            txtCodigo.Focus()

            'Cambia el estado del formulario a insercion
            PCambiarEstadoFormlarios(ESTADO_MENU.INSERCION)

            FbMostrarValidaciones(True, CAMPOS.CODIGO)


        Catch ex As Exception
            'Invoca mensaje de error
        End Try
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Dim vlcCodigo As String = txtCodigo.Text
        Dim vlcNombre As String = txtNombre.Text

        If vlcCodigo = "" Then
            MsgBox("Debe ingresar el codigo de la Carrera")
            txtCodigo.Focus()

        ElseIf vlcNombre = "" Then
            MsgBox("Debe ingresar el nombre de la Carrera")
            txtNombre.Focus()


            'ElseIf cboDA = String.Empty Then
            '    MsgBox("Debe escoger el director de la Carrera")
            '  End If


        Else
            MsgBox("El Registro fue Exitoso")

        End If

        PRegistrarCarrera()
        PLimpiarCampos()
        PCambiarEstadoFormlarios(ESTADO_MENU.GUARDAR)


    End Sub


    Public Sub PRegistrarCarrera()

        Dim vlcCodigo As String = txtCodigo.Text
        Dim vlcNombre As String = txtNombre.Text
        Dim vlnDA As Integer = cboDA.SelectedIndex
       
        GestorCarrera.registrarCarrera(vlcCodigo, vlcNombre, vlnDA)

    End Sub

End Class