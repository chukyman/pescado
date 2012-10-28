Imports LN

Public Class frmBuscarUsuario

    Dim vgoFrmMantenimientoUsuario As frmMantenimientoUsuario

    Enum CAMPOS_COLUNMAS
        IDROL = 0
        CEDULA = 1
        NOMBRE = 2
        APELLIDO1 = 3
        APELLIDO2 = 4
        CORREO = 5
        GENERO = 6
        NOMBREROL = 7

    End Enum



    ''' <summary>
    ''' Evento del botón Salir
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Sub New(ByVal pfrmMantenimientoUsuario As frmMantenimientoUsuario)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()


        'vgoFrmMantenimientoUsuario = New pfrmMantenimientoUsuario()
    End Sub

    Private Sub frmBuscarUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '    Gestores.GestorUsuario.listarUsuario()

        '   grdBuscarUsuarios.DataSource = Gestores.GestorUsuario.listarUsuario()

        grdBuscarUsuarios.DataSource = Gestores.GestorUsuario.listarUsuario()



        ' Me.grdBuscarUsuarios.()


    End Sub





    Private Sub btnSelecionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelecionar.Click
        ' grdBuscarUsuarios.Item(0, 0).Value = ""

        FbSelecionarFila()
     
        frmMantenimientoUsuario.Close()
    End Sub

    Public Function FbSelecionarFila() As Boolean
        Dim vlbResultado As Boolean
        Dim vlnFila As Integer

        vlnFila = Me.grdBuscarUsuarios.CurrentRow.Index()

        Dim vlcCedula As String = grdBuscarUsuarios.Item(CAMPOS_COLUNMAS.CEDULA, vlnFila).Value
        Dim vlcNombre As String = grdBuscarUsuarios.Item(CAMPOS_COLUNMAS.NOMBRE, vlnFila).Value
        Dim vlcApellido1 As String = grdBuscarUsuarios.Item(CAMPOS_COLUNMAS.APELLIDO1, vlnFila).Value
        Dim vlcApellido2 As String = grdBuscarUsuarios.Item(CAMPOS_COLUNMAS.APELLIDO2, vlnFila).Value
        Dim vlcCorreo As String = grdBuscarUsuarios.Item(CAMPOS_COLUNMAS.CORREO, vlnFila).Value
        Dim vlbGenero As Char = grdBuscarUsuarios.Item(CAMPOS_COLUNMAS.GENERO, vlnFila).Value
        Dim vlnTipoRol As String = grdBuscarUsuarios.Item(CAMPOS_COLUNMAS.IDROL, vlnFila).Value


       
        frmMantenimientoUsuario.PLlenarCampos(vlcCedula, vlcNombre, vlcApellido1, vlcApellido2, _
                                   vlcCorreo, vlbGenero, vlnTipoRol)


        'vloFrmMantenimientoUsuario.Show()
        Return vlbResultado

    End Function

    'Private Sub grdBuscarUsuarios_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdBuscarUsuarios.CellClick
    '    Dim vlnFila As Integer

    '    vlnFila = Me.grdBuscarUsuarios.CurrentRow.Index()

    '    Dim vlcCedula As String = grdBuscarUsuarios.Item(CAMPOS_COLUNMAS.CEDULA, vlnFila).Value
    '    Dim vlcNombre As String = grdBuscarUsuarios.Item(CAMPOS_COLUNMAS.NOMBRE, vlnFila).Value
    '    Dim vlcApellido1 As String = grdBuscarUsuarios.Item(CAMPOS_COLUNMAS.APELLIDO1, vlnFila).Value
    '    Dim vlcApellido2 As String = grdBuscarUsuarios.Item(CAMPOS_COLUNMAS.APELLIDO2, vlnFila).Value
    '    Dim vlbGenero As Boolean = grdBuscarUsuarios.Item(CAMPOS_COLUNMAS.GENERO, vlnFila).Value
    '    Dim vlnTipoRol As String = grdBuscarUsuarios.Item(CAMPOS_COLUNMAS.IDROL, vlnFila).Value


    '    Dim vloFrmMantenimientoUsuario As New  _
    '     frmMantenimientoUsuario()

    '    vloFrmMantenimientoUsuario.Show()


    'End Sub
End Class