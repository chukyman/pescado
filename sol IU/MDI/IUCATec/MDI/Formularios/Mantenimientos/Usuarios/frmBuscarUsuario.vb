Imports LN
Imports LN.Estructuras

Public Class frmBuscarUsuario



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
    ''' <remarks>Roberto Cordero</remarks>
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Constructor del fomulario buscar usuario
    ''' </summary>
    ''' <remarks>Roberto Cordero Quiros</remarks>
    Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    ''' <summary>
    ''' Load
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Roberto Cordero</remarks>
    Private Sub frmBuscarUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'En caso de error
        Try
            ' Lista todos los usuariso de la base de datos
            grdBuscarUsuarios.DataSource = Gestores.GestorUsuario.listarUsuario()
        Catch ex As Exception
            'Invoca mensaje de error
        End Try
    End Sub

    Private frmAlAbrir As frmInterfaceBuscarModificarEliminar

    Public Property AlAbrir() As frmInterfaceBuscarModificarEliminar
        Get
            Return frmAlAbrir
        End Get
        Set(ByVal value As frmInterfaceBuscarModificarEliminar)
            frmAlAbrir = value
        End Set
    End Property

    ''' <summary>
    '''  Funcion encargada de poblar un DataTable con los Registros del Grid (se podria 
    ''' perfecionar usando Linq)
    ''' </summary>
    ''' <param name="pvnIndex"></param>
    ''' <returns></returns>
    ''' <remarks>Roberto Cordero Q</remarks>
    Private Function FdtCargarDataTable(ByVal pvnIndex) As DataTable
        ' Se Declara e Instancia un DataTable 
        Dim vldtTablaDatos As New DataTable

        'Se construyen las columnas del DataTable (esos campos deberia ser los mismos que el grid
        'Luego Explico porq en este ejemplo no lo he hecho)
        vldtTablaDatos.Columns.Add("Cedula")
        vldtTablaDatos.Columns.Add("Nombre")
        vldtTablaDatos.Columns.Add("Apellido1")
        vldtTablaDatos.Columns.Add("Apellido2")
        vldtTablaDatos.Columns.Add("Correo")
        vldtTablaDatos.Columns.Add("Genero")
        vldtTablaDatos.Columns.Add("IdRol")

        'Podria ser otro tipo de ciclo, si en un futuro quieren cargar mas datos, 
        'Se utuliza otro este es por cuestion de tiempo y inutilidad de mi parte-
        For i As Integer = 0 To 0
            'Se declara una nueva fila para el datatable
            Dim row As DataRow = vldtTablaDatos.NewRow()
            'Para la fila 0, de la columna (nombre de columna q construimos) asigne el item
            'del grid, donde su columa (nombre de columana), y su fila, indice pasado por parametros
            row("Cedula") = grdBuscarUsuarios.Item(CAMPOS_COLUNMAS.CEDULA, pvnIndex).Value
            row("Nombre") = grdBuscarUsuarios.Item(CAMPOS_COLUNMAS.NOMBRE, pvnIndex).Value
            row("Apellido1") = grdBuscarUsuarios.Item(CAMPOS_COLUNMAS.APELLIDO1, pvnIndex).Value
            row("Apellido2") = grdBuscarUsuarios.Item(CAMPOS_COLUNMAS.APELLIDO2, pvnIndex).Value
            row("Correo") = grdBuscarUsuarios.Item(CAMPOS_COLUNMAS.CORREO, pvnIndex).Value
            row("Genero") = grdBuscarUsuarios.Item(CAMPOS_COLUNMAS.GENERO, pvnIndex).Value
            row("IdRol") = grdBuscarUsuarios.Item(CAMPOS_COLUNMAS.IDROL, pvnIndex).Value

            'Agrege al datatable ese registro
            vldtTablaDatos.Rows.Add(row)

        Next
        Return vldtTablaDatos

    End Function

    ''' <summary>
    ''' Evento del boton Selecionar Registro del formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Roberto Cordero Quiros</remarks>
    Private Sub btnSelecionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelecionar.Click
        Dim vlcMensaje As String
        'Resultado del dialogo
        Dim vloResultadoMensaje As DialogResult

        'Valida que el grid tenga datos. o bien podria ser la lista de usuarios
        If Me.grdBuscarUsuarios.RowCount > 0 Then
            'Mensaje de confirmacion
            vlcMensaje = "Desesa selecionar la linea: " + Me.grdBuscarUsuarios.CurrentRow.Index.ToString

            vloResultadoMensaje = MessageBox.Show(vlcMensaje, "Usuario", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
            'Si el mensaje fue arfimativo
            If vloResultadoMensaje = DialogResult.Yes Then
                PEnviarDatosAFormularioPadre()
            End If
        Else
            'No existen datos que selecionar
            MessageBox.Show("No Existen registros para selecionar")
        End If
        'Se podria Cerarr o no.. Pensarlo
        Me.Close()
    End Sub

    ''' <summary>
    ''' Procedimiento Encargado de enviar los datos al formulario padre de este formulario
    ''' </summary>
    ''' <remarks>Roberto Cordero Quiros</remarks>
    Public Sub PEnviarDatosAFormularioPadre()
        ' Se declara la variable fila de tipo entero
        Dim vlnFila As Integer
        ' Declaro un DataTable que almacena los registros del grid
        Dim vldtResultadoRegistros As DataTable
        ' Delcaro una variable de si la operacion fue correcta
        Dim vlbEstadoOperacion

        'El currerow me indica en la fila que me encuentro
        vlnFila = Me.grdBuscarUsuarios.CurrentRow.Index()

        'Se llama a la funcion CargarDataTable y se asigna a un datatable.
        vldtResultadoRegistros = FdtCargarDataTable(vlnFila)

        'Utiliza el metodo implementado de la interface y establece el estado de la operacion
        'Si quieren ver el comportamiento delen un break point en este punto
        vlbEstadoOperacion = Me.AlAbrir.FbCargarDataGrid(vldtResultadoRegistros)


    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        ''  Dim vloListaEstructurasUsuario As Array = Gestores.GestorUsuario.buscarUsuarioCedula(txtCedula.Text)

        'For Each  In vloListaEstructurasUsuario
        '    cboGrupos.Items.Add(StrGrupo.Nombre & "-" & StrGrupo.Horario)
        'Next



        grdBuscarUsuarios.DataSource = Gestores.GestorUsuario.buscarUsuarioCedula(txtCedula.Text)
    End Sub
End Class