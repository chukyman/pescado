'Fecha: 20/10/2012
'Desarrollado: Julio Moreira
Imports LN.Gestores
Imports LN.Estructuras

Public Class frmListarCarreras

#Region "Eventos"
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmListarCarreras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

                vlnIndice = grdListarCarreras.Rows.Add

                vldrRegistro = grdListarCarreras.Rows(vlnx)

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
#End Region

#Region "Constantes"

#End Region

#Region "Atributos"

#End Region

#Region "Funciones"

#End Region

#Region "Procedimientos"

#End Region
    
 
End Class