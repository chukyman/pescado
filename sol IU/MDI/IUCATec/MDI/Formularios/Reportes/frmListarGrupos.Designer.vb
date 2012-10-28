<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListarGrupos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tlpContenedorListarGrupos = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.lblTituloListarGrupo = New System.Windows.Forms.Label()
        Me.pnlFiltros = New System.Windows.Forms.Panel()
        Me.pnlCuerpo = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.gpbBusquedaGrupos = New System.Windows.Forms.GroupBox()
        Me.grdListarGrupos = New System.Windows.Forms.DataGridView()
        Me.tlpContenedorListarGrupos.SuspendLayout()
        Me.pnlTitulo.SuspendLayout()
        Me.pnlCuerpo.SuspendLayout()
        Me.gpbBusquedaGrupos.SuspendLayout()
        CType(Me.grdListarGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpContenedorListarGrupos
        '
        Me.tlpContenedorListarGrupos.ColumnCount = 1
        Me.tlpContenedorListarGrupos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContenedorListarGrupos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpContenedorListarGrupos.Controls.Add(Me.pnlTitulo, 0, 0)
        Me.tlpContenedorListarGrupos.Controls.Add(Me.pnlFiltros, 0, 1)
        Me.tlpContenedorListarGrupos.Controls.Add(Me.pnlCuerpo, 0, 2)
        Me.tlpContenedorListarGrupos.Location = New System.Drawing.Point(1, 3)
        Me.tlpContenedorListarGrupos.Name = "tlpContenedorListarGrupos"
        Me.tlpContenedorListarGrupos.RowCount = 3
        Me.tlpContenedorListarGrupos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.tlpContenedorListarGrupos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tlpContenedorListarGrupos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContenedorListarGrupos.Size = New System.Drawing.Size(675, 439)
        Me.tlpContenedorListarGrupos.TabIndex = 0
        '
        'pnlTitulo
        '
        Me.pnlTitulo.Controls.Add(Me.lblTituloListarGrupo)
        Me.pnlTitulo.Location = New System.Drawing.Point(3, 3)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(669, 39)
        Me.pnlTitulo.TabIndex = 0
        '
        'lblTituloListarGrupo
        '
        Me.lblTituloListarGrupo.AutoSize = True
        Me.lblTituloListarGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloListarGrupo.Location = New System.Drawing.Point(232, 3)
        Me.lblTituloListarGrupo.Name = "lblTituloListarGrupo"
        Me.lblTituloListarGrupo.Size = New System.Drawing.Size(190, 31)
        Me.lblTituloListarGrupo.TabIndex = 22
        Me.lblTituloListarGrupo.Text = "Listar Grupos"
        '
        'pnlFiltros
        '
        Me.pnlFiltros.Location = New System.Drawing.Point(3, 48)
        Me.pnlFiltros.Name = "pnlFiltros"
        Me.pnlFiltros.Size = New System.Drawing.Size(669, 84)
        Me.pnlFiltros.TabIndex = 1
        '
        'pnlCuerpo
        '
        Me.pnlCuerpo.Controls.Add(Me.btnSalir)
        Me.pnlCuerpo.Controls.Add(Me.gpbBusquedaGrupos)
        Me.pnlCuerpo.Location = New System.Drawing.Point(3, 138)
        Me.pnlCuerpo.Name = "pnlCuerpo"
        Me.pnlCuerpo.Size = New System.Drawing.Size(669, 298)
        Me.pnlCuerpo.TabIndex = 2
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSalir.Location = New System.Drawing.Point(288, 252)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(96, 37)
        Me.btnSalir.TabIndex = 27
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'gpbBusquedaGrupos
        '
        Me.gpbBusquedaGrupos.Controls.Add(Me.grdListarGrupos)
        Me.gpbBusquedaGrupos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbBusquedaGrupos.Location = New System.Drawing.Point(13, 19)
        Me.gpbBusquedaGrupos.Name = "gpbBusquedaGrupos"
        Me.gpbBusquedaGrupos.Size = New System.Drawing.Size(626, 226)
        Me.gpbBusquedaGrupos.TabIndex = 25
        Me.gpbBusquedaGrupos.TabStop = False
        Me.gpbBusquedaGrupos.Text = "Lista"
        '
        'grdListarGrupos
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.grdListarGrupos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdListarGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdListarGrupos.Location = New System.Drawing.Point(13, 19)
        Me.grdListarGrupos.Name = "grdListarGrupos"
        Me.grdListarGrupos.Size = New System.Drawing.Size(613, 200)
        Me.grdListarGrupos.TabIndex = 0
        '
        'frmListarGrupos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 443)
        Me.Controls.Add(Me.tlpContenedorListarGrupos)
        Me.Name = "frmListarGrupos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmListarGrupos"
        Me.tlpContenedorListarGrupos.ResumeLayout(False)
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        Me.pnlCuerpo.ResumeLayout(False)
        Me.gpbBusquedaGrupos.ResumeLayout(False)
        CType(Me.grdListarGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpContenedorListarGrupos As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlTitulo As System.Windows.Forms.Panel
    Friend WithEvents pnlFiltros As System.Windows.Forms.Panel
    Friend WithEvents pnlCuerpo As System.Windows.Forms.Panel
    Friend WithEvents lblTituloListarGrupo As System.Windows.Forms.Label
    Friend WithEvents gpbBusquedaGrupos As System.Windows.Forms.GroupBox
    Friend WithEvents grdListarGrupos As System.Windows.Forms.DataGridView
    Friend WithEvents btnSalir As System.Windows.Forms.Button
End Class
