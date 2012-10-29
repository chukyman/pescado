'Fecha: 20/10/2012
'Desarrollado: Julio Moreira

Imports LN




Public Class frmBuscarCarrera


    Enum CAMPOS_COLUNMAS
        IDCARRERA = 0
        CODIGO = 1
        NOMBRE = 2
        IDDIRECTOR = 3
    End Enum


    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


    Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub



    Private Sub grpFiltros_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpFiltros.Enter

    End Sub

    Private Sub frmBuscarCarrera_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, grdBuscarCarreras.DataSourceChanged
        'En caso de error
        Try
            ' Lista todos las carerras de la base de datos
            grdBuscarCarreras.DataSource = Gestores.GestorCarrera.listarCarrera()
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

    Private Function FdtCargarDataTable(ByVal pvnIndex) As DataTable
        ' Se Declara e Instancia un DataTable 
        Dim vldtTablaDatos As New DataTable

        'Se construyen las columnas del DataTable (esos campos deberia ser los mismos que el grid
        'Luego Explico porq en este ejemplo no lo he hecho)
        vldtTablaDatos.Columns.Add("Codigo")
        vldtTablaDatos.Columns.Add("Nombre")
        vldtTablaDatos.Columns.Add("Director Id")

       

        'Podria ser otro tipo de ciclo, si en un futuro quieren cargar mas datos, 
        'Se utuliza otro este es por cuestion de tiempo y inutilidad de mi parte-
        For i As Integer = 0 To 0
            'Se declara una nueva fila para el datatable
            Dim row As DataRow = vldtTablaDatos.NewRow()
            'Para la fila 0, de la columna (nombre de columna q construimos) asigne el item
            'del grid, donde su columa (nombre de columana), y su fila, indice pasado por parametros
            row("Id") = grdBuscarCarreras.Item(CAMPOS_COLUNMAS.IDCARRERA, pvnIndex).Value
            row("Codigo") = grdBuscarCarreras.Item(CAMPOS_COLUNMAS.CODIGO, pvnIndex).Value
            row("Nombre") = grdBuscarCarreras.Item(CAMPOS_COLUNMAS.NOMBRE, pvnIndex).Value
            row("Id Director") = grdBuscarCarreras.Item(CAMPOS_COLUNMAS.IDDIRECTOR, pvnIndex).Value


            'Agrege al datatable ese registro
            vldtTablaDatos.Rows.Add(row)

        Next
        Return vldtTablaDatos

    End Function


    Private Sub btnSelecionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelecionar.Click
        Dim vlcMensaje As String
        'Resultado del dialogo
        Dim vloResultadoMensaje As DialogResult

        'Valida que el grid tenga datos. o bien podria ser la lista de usuarios
        If Me.grdBuscarCarreras.RowCount > 0 Then
            'Mensaje de confirmacion
            vlcmensaje = "Desesa selecionar la linea: " + Me.grdBuscarCarreras.CurrentRow.Index.ToString

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


    Public Sub PEnviarDatosAFormularioPadre()
        ' Se declara la variable fila de tipo entero
        Dim vlnFila As Integer
        ' Declaro un DataTable que almacena los registros del grid
        Dim vldtResultadoRegistros As DataTable
        ' Delcaro una variable de si la operacion fue correcta
        Dim vlbEstadoOperacion

        'El currerow me indica en la fila que me encuentro
        vlnFila = Me.grdBuscarCarreras.CurrentRow.Index()

        'Se llama a la funcion CargarDataTable y se asigna a un datatable.
        vldtResultadoRegistros = FdtCargarDataTable(vlnFila)

        'Utiliza el metodo implementado de la interface y establece el estado de la operacion
        'Si quieren ver el comportamiento delen un break point en este punto
        vlbEstadoOperacion = Me.AlAbrir.FbCargarDataGrid(vldtResultadoRegistros)


    End Sub









End Class