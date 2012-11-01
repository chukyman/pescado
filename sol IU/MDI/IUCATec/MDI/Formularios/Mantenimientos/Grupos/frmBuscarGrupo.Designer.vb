<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarGrupo
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tlpContenedorBuscar = New System.Windows.Forms.TableLayoutPanel()
        Me.grpFiltros = New System.Windows.Forms.GroupBox()
        Me.lblValidaNombreGrupo = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnSelecionar = New System.Windows.Forms.Button()
        Me.gpbBusqueda = New System.Windows.Forms.GroupBox()
        Me.grdBuscarGrupos = New System.Windows.Forms.DataGridView()
        Me.cNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cHorario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCantidadEstudiantes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCurso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlContenedorTitulo = New System.Windows.Forms.Panel()
        Me.lblTituloBG = New System.Windows.Forms.Label()
        Me.tlpContenedorBuscar.SuspendLayout()
        Me.grpFiltros.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gpbBusqueda.SuspendLayout()
        CType(Me.grdBuscarGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContenedorTitulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpContenedorBuscar
        '
        Me.tlpContenedorBuscar.ColumnCount = 1
        Me.tlpContenedorBuscar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContenedorBuscar.Controls.Add(Me.grpFiltros, 0, 1)
        Me.tlpContenedorBuscar.Controls.Add(Me.Panel1, 0, 2)
        Me.tlpContenedorBuscar.Controls.Add(Me.pnlContenedorTitulo, 0, 0)
        Me.tlpContenedorBuscar.Location = New System.Drawing.Point(2, 0)
        Me.tlpContenedorBuscar.Name = "tlpContenedorBuscar"
        Me.tlpContenedorBuscar.RowCount = 3
        Me.tlpContenedorBuscar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.tlpContenedorBuscar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tlpContenedorBuscar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContenedorBuscar.Size = New System.Drawing.Size(672, 437)
        Me.tlpContenedorBuscar.TabIndex = 30
        '
        'grpFiltros
        '
        Me.grpFiltros.Controls.Add(Me.lblValidaNombreGrupo)
        Me.grpFiltros.Controls.Add(Me.lblNombre)
        Me.grpFiltros.Controls.Add(Me.txtNombre)
        Me.grpFiltros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFiltros.Location = New System.Drawing.Point(3, 48)
        Me.grpFiltros.Name = "grpFiltros"
        Me.grpFiltros.Size = New System.Drawing.Size(665, 84)
        Me.grpFiltros.TabIndex = 23
        Me.grpFiltros.TabStop = False
        Me.grpFiltros.Text = "Filtros"
        '
        'lblValidaNombreGrupo
        '
        Me.lblValidaNombreGrupo.AutoSize = True
        Me.lblValidaNombreGrupo.Location = New System.Drawing.Point(261, 38)
        Me.lblValidaNombreGrupo.Name = "lblValidaNombreGrupo"
        Me.lblValidaNombreGrupo.Size = New System.Drawing.Size(136, 13)
        Me.lblValidaNombreGrupo.TabIndex = 13
        Me.lblValidaNombreGrupo.Text = "*Debe ingresar nombre"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(21, 32)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(84, 24)
        Me.lblNombre.TabIndex = 10
        Me.lblNombre.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(131, 30)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(124, 26)
        Me.txtNombre.TabIndex = 12
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.btnSelecionar)
        Me.Panel1.Controls.Add(Me.gpbBusqueda)
        Me.Panel1.Location = New System.Drawing.Point(3, 138)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(665, 296)
        Me.Panel1.TabIndex = 27
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSalir.Location = New System.Drawing.Point(358, 250)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(96, 37)
        Me.btnSalir.TabIndex = 26
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnSelecionar
        '
        Me.btnSelecionar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSelecionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelecionar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSelecionar.Location = New System.Drawing.Point(217, 250)
        Me.btnSelecionar.Name = "btnSelecionar"
        Me.btnSelecionar.Size = New System.Drawing.Size(96, 37)
        Me.btnSelecionar.TabIndex = 25
        Me.btnSelecionar.Text = "Selecionar"
        Me.btnSelecionar.UseVisualStyleBackColor = False
        '
        'gpbBusqueda
        '
        Me.gpbBusqueda.Controls.Add(Me.grdBuscarGrupos)
        Me.gpbBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbBusqueda.Location = New System.Drawing.Point(18, 18)
        Me.gpbBusqueda.Name = "gpbBusqueda"
        Me.gpbBusqueda.Size = New System.Drawing.Size(626, 226)
        Me.gpbBusqueda.TabIndex = 24
        Me.gpbBusqueda.TabStop = False
        Me.gpbBusqueda.Text = "Busqueda"
        '
        'grdBuscarGrupos
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver
        Me.grdBuscarGrupos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.grdBuscarGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBuscarGrupos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cNombre, Me.cHorario, Me.cDescripcion, Me.cCantidadEstudiantes, Me.cCurso})
        Me.grdBuscarGrupos.Location = New System.Drawing.Point(7, 20)
        Me.grdBuscarGrupos.Name = "grdBuscarGrupos"
        Me.grdBuscarGrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdBuscarGrupos.Size = New System.Drawing.Size(613, 200)
        Me.grdBuscarGrupos.TabIndex = 0
        '
        'cNombre
        '
        Me.cNombre.HeaderText = "Nombre"
        Me.cNombre.Name = "cNombre"
        '
        'cHorario
        '
        Me.cHorario.HeaderText = "Horario"
        Me.cHorario.Name = "cHorario"
        '
        'cDescripcion
        '
        Me.cDescripcion.HeaderText = "Descripcion"
        Me.cDescripcion.Name = "cDescripcion"
        '
        'cCantidadEstudiantes
        '
        Me.cCantidadEstudiantes.HeaderText = "CantidadEstudiantes"
        Me.cCantidadEstudiantes.Name = "cCantidadEstudiantes"
        '
        'cCurso
        '
        Me.cCurso.HeaderText = "Curso"
        Me.cCurso.Name = "cCurso"
        '
        'pnlContenedorTitulo
        '
        Me.pnlContenedorTitulo.Controls.Add(Me.lblTituloBG)
        Me.pnlContenedorTitulo.Location = New System.Drawing.Point(3, 3)
        Me.pnlContenedorTitulo.Name = "pnlContenedorTitulo"
        Me.pnlContenedorTitulo.Size = New System.Drawing.Size(666, 37)
        Me.pnlContenedorTitulo.TabIndex = 22
        '
        'lblTituloBG
        '
        Me.lblTituloBG.AutoSize = True
        Me.lblTituloBG.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloBG.Location = New System.Drawing.Point(240, 6)
        Me.lblTituloBG.Name = "lblTituloBG"
        Me.lblTituloBG.Size = New System.Drawing.Size(193, 31)
        Me.lblTituloBG.TabIndex = 21
        Me.lblTituloBG.Text = "Buscar Grupo"
        '
        'frmBuscarGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 437)
        Me.Controls.Add(Me.tlpContenedorBuscar)
        Me.MaximizeBox = False
        Me.Name = "frmBuscarGrupo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar"
        Me.tlpContenedorBuscar.ResumeLayout(False)
        Me.grpFiltros.ResumeLayout(False)
        Me.grpFiltros.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.gpbBusqueda.ResumeLayout(False)
        CType(Me.grdBuscarGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContenedorTitulo.ResumeLayout(False)
        Me.pnlContenedorTitulo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpContenedorBuscar As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents grpFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnSelecionar As System.Windows.Forms.Button
    Friend WithEvents gpbBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents grdBuscarGrupos As System.Windows.Forms.DataGridView
    Friend WithEvents pnlContenedorTitulo As System.Windows.Forms.Panel
    Friend WithEvents lblTituloBG As System.Windows.Forms.Label
    Friend WithEvents cNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cHorario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCantidadEstudiantes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCurso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblValidaNombreGrupo As System.Windows.Forms.Label
End Class
