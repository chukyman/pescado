<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarCarrera
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlContenedorTitulo = New System.Windows.Forms.Panel()
        Me.lblTituloBC = New System.Windows.Forms.Label()
        Me.btnSelecionar = New System.Windows.Forms.Button()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gpbBusqueda = New System.Windows.Forms.GroupBox()
        Me.grdBuscarUsuarios = New System.Windows.Forms.DataGridView()
        Me.grpFiltros = New System.Windows.Forms.GroupBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.tlpContenedorBuscar = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlContenedorTitulo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gpbBusqueda.SuspendLayout()
        CType(Me.grdBuscarUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltros.SuspendLayout()
        Me.tlpContenedorBuscar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContenedorTitulo
        '
        Me.pnlContenedorTitulo.Controls.Add(Me.lblTituloBC)
        Me.pnlContenedorTitulo.Location = New System.Drawing.Point(3, 3)
        Me.pnlContenedorTitulo.Name = "pnlContenedorTitulo"
        Me.pnlContenedorTitulo.Size = New System.Drawing.Size(666, 37)
        Me.pnlContenedorTitulo.TabIndex = 22
        '
        'lblTituloBC
        '
        Me.lblTituloBC.AutoSize = True
        Me.lblTituloBC.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloBC.Location = New System.Drawing.Point(240, 6)
        Me.lblTituloBC.Name = "lblTituloBC"
        Me.lblTituloBC.Size = New System.Drawing.Size(212, 31)
        Me.lblTituloBC.TabIndex = 21
        Me.lblTituloBC.Text = "Buscar Carrera"
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
        'gpbBusqueda
        '
        Me.gpbBusqueda.Controls.Add(Me.grdBuscarUsuarios)
        Me.gpbBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbBusqueda.Location = New System.Drawing.Point(18, 18)
        Me.gpbBusqueda.Name = "gpbBusqueda"
        Me.gpbBusqueda.Size = New System.Drawing.Size(626, 226)
        Me.gpbBusqueda.TabIndex = 24
        Me.gpbBusqueda.TabStop = False
        Me.gpbBusqueda.Text = "Busqueda"
        '
        'grdBuscarUsuarios
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.grdBuscarUsuarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdBuscarUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBuscarUsuarios.Location = New System.Drawing.Point(7, 20)
        Me.grdBuscarUsuarios.Name = "grdBuscarUsuarios"
        Me.grdBuscarUsuarios.Size = New System.Drawing.Size(613, 200)
        Me.grdBuscarUsuarios.TabIndex = 0
        '
        'grpFiltros
        '
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
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(131, 30)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(124, 26)
        Me.txtNombre.TabIndex = 12
        '
        'tlpContenedorBuscar
        '
        Me.tlpContenedorBuscar.ColumnCount = 1
        Me.tlpContenedorBuscar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContenedorBuscar.Controls.Add(Me.grpFiltros, 0, 1)
        Me.tlpContenedorBuscar.Controls.Add(Me.Panel1, 0, 2)
        Me.tlpContenedorBuscar.Controls.Add(Me.pnlContenedorTitulo, 0, 0)
        Me.tlpContenedorBuscar.Location = New System.Drawing.Point(1, 2)
        Me.tlpContenedorBuscar.Name = "tlpContenedorBuscar"
        Me.tlpContenedorBuscar.RowCount = 3
        Me.tlpContenedorBuscar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.tlpContenedorBuscar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tlpContenedorBuscar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContenedorBuscar.Size = New System.Drawing.Size(672, 437)
        Me.tlpContenedorBuscar.TabIndex = 29
        '
        'frmBuscarCarrera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 443)
        Me.Controls.Add(Me.tlpContenedorBuscar)
        Me.Name = "frmBuscarCarrera"
        Me.Text = "Carreras"
        Me.pnlContenedorTitulo.ResumeLayout(False)
        Me.pnlContenedorTitulo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.gpbBusqueda.ResumeLayout(False)
        CType(Me.grdBuscarUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltros.ResumeLayout(False)
        Me.grpFiltros.PerformLayout()
        Me.tlpContenedorBuscar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlContenedorTitulo As System.Windows.Forms.Panel
    Friend WithEvents lblTituloBC As System.Windows.Forms.Label
    Friend WithEvents btnSelecionar As System.Windows.Forms.Button
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gpbBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents grdBuscarUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents grpFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents tlpContenedorBuscar As System.Windows.Forms.TableLayoutPanel
End Class
