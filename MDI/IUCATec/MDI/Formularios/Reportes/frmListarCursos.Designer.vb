<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListarCursos
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
        Me.lblTituloListarCurso = New System.Windows.Forms.Label()
        Me.pnlFiltros = New System.Windows.Forms.Panel()
        Me.pnlCuerpo = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.gpbBusquedaCursos = New System.Windows.Forms.GroupBox()
        Me.grdListarCursos = New System.Windows.Forms.DataGridView()
        Me.tlpContenedorListarGrupos.SuspendLayout()
        Me.pnlTitulo.SuspendLayout()
        Me.pnlCuerpo.SuspendLayout()
        Me.gpbBusquedaCursos.SuspendLayout()
        CType(Me.grdListarCursos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tlpContenedorListarGrupos.Location = New System.Drawing.Point(0, 2)
        Me.tlpContenedorListarGrupos.Name = "tlpContenedorListarGrupos"
        Me.tlpContenedorListarGrupos.RowCount = 3
        Me.tlpContenedorListarGrupos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.tlpContenedorListarGrupos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tlpContenedorListarGrupos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContenedorListarGrupos.Size = New System.Drawing.Size(675, 439)
        Me.tlpContenedorListarGrupos.TabIndex = 1
        '
        'pnlTitulo
        '
        Me.pnlTitulo.Controls.Add(Me.lblTituloListarCurso)
        Me.pnlTitulo.Location = New System.Drawing.Point(3, 3)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(669, 39)
        Me.pnlTitulo.TabIndex = 0
        '
        'lblTituloListarCurso
        '
        Me.lblTituloListarCurso.AutoSize = True
        Me.lblTituloListarCurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloListarCurso.Location = New System.Drawing.Point(232, 3)
        Me.lblTituloListarCurso.Name = "lblTituloListarCurso"
        Me.lblTituloListarCurso.Size = New System.Drawing.Size(188, 31)
        Me.lblTituloListarCurso.TabIndex = 22
        Me.lblTituloListarCurso.Text = "Listar Cursos"
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
        Me.pnlCuerpo.Controls.Add(Me.gpbBusquedaCursos)
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
        'gpbBusquedaCursos
        '
        Me.gpbBusquedaCursos.Controls.Add(Me.grdListarCursos)
        Me.gpbBusquedaCursos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbBusquedaCursos.Location = New System.Drawing.Point(13, 19)
        Me.gpbBusquedaCursos.Name = "gpbBusquedaCursos"
        Me.gpbBusquedaCursos.Size = New System.Drawing.Size(626, 226)
        Me.gpbBusquedaCursos.TabIndex = 25
        Me.gpbBusquedaCursos.TabStop = False
        Me.gpbBusquedaCursos.Text = "Lista"
        '
        'grdListarCursos
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.grdListarCursos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdListarCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdListarCursos.Location = New System.Drawing.Point(13, 19)
        Me.grdListarCursos.Name = "grdListarCursos"
        Me.grdListarCursos.Size = New System.Drawing.Size(613, 200)
        Me.grdListarCursos.TabIndex = 0
        '
        'frmListarCursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 443)
        Me.Controls.Add(Me.tlpContenedorListarGrupos)
        Me.Name = "frmListarCursos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmListarCursos"
        Me.tlpContenedorListarGrupos.ResumeLayout(False)
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        Me.pnlCuerpo.ResumeLayout(False)
        Me.gpbBusquedaCursos.ResumeLayout(False)
        CType(Me.grdListarCursos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpContenedorListarGrupos As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlTitulo As System.Windows.Forms.Panel
    Friend WithEvents lblTituloListarCurso As System.Windows.Forms.Label
    Friend WithEvents pnlFiltros As System.Windows.Forms.Panel
    Friend WithEvents pnlCuerpo As System.Windows.Forms.Panel
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents gpbBusquedaCursos As System.Windows.Forms.GroupBox
    Friend WithEvents grdListarCursos As System.Windows.Forms.DataGridView
End Class
