'Fecha: 20/10/2012
'Desarrollado: Julio Moreira

Imports LN
Imports LN.Gestores
Imports LN.Estructuras




Public Class frmBuscarCarrera


    Enum CAMPOS_COLUNMAS
        IDCARRERA = 0
        CODIGO = 1
        NOMBRE = 2
        NOMBREDIRECTOR = 3
        IDDIRECTOR = 4
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

    Private Sub frmBuscarCarrera_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'En caso de error
        ' Lista todos las carerras de la base de datos
        ' grdBuscarCarreras.DataSource = Gestores.GestorCarrera.listarCarrera()
        'Lista temporal que almacena una lista de tipo estructura carrera
        Dim vloListaTem As List(Of LN.Estructuras.StrCarrera)

        'Variable de tipo dataGridView row que sirve para ingresar a las columnas del gird
        Dim vldrRegistro As DataGridViewRow


        'En caso de error
        Try
            Dim vlnIndice As Integer

            vloListaTem = GestorCarrera.listarCarrera()

            For vlnx As Integer = 0 To vloListaTem.Count - 1

                vlnIndice = grdBuscarCarreras.Rows.Add

                vldrRegistro = grdBuscarCarreras.Rows(vlnx)

                vldrRegistro.Cells("vfoId").Value = vloListaTem.Item(vlnx).Id_Carrera
                vldrRegistro.Cells("vfoCodigo").Value = vloListaTem.Item(vlnx).Codigo
                vldrRegistro.Cells("vfoNombre").Value = vloListaTem.Item(vlnx).Nombre
                vldrRegistro.Cells("vfoIdDA").Value = vloListaTem.Item(vlnx).Id_Director_academico
                vldrRegistro.Cells("vfonombreDA").Value = vloListaTem.Item(vlnx).Nombre_DA

            Next




            'vloListaTem.GetEnumerator.Current.Id_Carrera
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
        vldtTablaDatos.Columns.Add("Id")
        vldtTablaDatos.Columns.Add("Codigo")
        vldtTablaDatos.Columns.Add("Nombre")
        vldtTablaDatos.Columns.Add("IdDA")
        vldtTablaDatos.Columns.Add("nombreDA")


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
            row("IdDA") = grdBuscarCarreras.Item(CAMPOS_COLUNMAS.IDDIRECTOR, pvnIndex).Value
            row("nombreDA") = grdBuscarCarreras.Item(CAMPOS_COLUNMAS.NOMBREDIRECTOR, pvnIndex).Value

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
            vlcMensaje = "Desea seleccionar la linea: " + Me.grdBuscarCarreras.CurrentRow.Index.ToString

            vloResultadoMensaje = MessageBox.Show(vlcMensaje, "Usuario", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
            'Si el mensaje fue arfimativo
            If vloResultadoMensaje = DialogResult.Yes Then
                PEnviarDatosAFormularioPadre()
            End If

        Else
            'No existen datos que selecionar
            MessageBox.Show("No Existen registros para seleccionar")

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


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        Dim vlcNombre As String = txtNombre.Text
        Dim vlostrDatosCarrera = GestorCarrera.buscarCarrera(vlcNombre)
        MessageBox.Show("Información de la Carrera" & vbCrLf &
                        "--------------------------------------" & vbCrLf &
                        "Nombre de Carrera: " + vlostrDatosCarrera.Nombre + vbCrLf +
                        "  " & vbCrLf +
                        "Codigo: " + vlostrDatosCarrera.Codigo + vbCrLf +
                            "  " & vbCrLf +
                        "Director de la Carrera:  " + vlostrDatosCarrera.Nombre_DA)

    End Sub
End Class