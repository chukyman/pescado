''' <summary>
''' Interface para los formularios Mantenimiento y buscar
''' </summary>
''' <remarks>Roberto Cordero</remarks>
Public Interface frmInterfaceBuscarModificarEliminar

    ''' <summary>
    ''' Metodo de la interface para cargar el grid
    ''' </summary>
    ''' <param name="pvdtDataTable">Recibe un DataTable con la informacion</param>
    ''' <returns>Valor Booleando si se realizo la carga</returns>
    ''' <remarks>Roberto Cordero</remarks>
    Function FbCargarDataGrid(ByVal pvdtDataTable As DataTable) As Boolean

End Interface

