<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListarCarreras
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
        Me.grpFiltros = New System.Windows.Forms.GroupBox()
        Me.tlpContenedorBuscar = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.gpbBusqueda = New System.Windows.Forms.GroupBox()
        Me.grdListarCarreras = New System.Windows.Forms.DataGridView()
        Me.pnlContenedorTitulo = New System.Windows.Forms.Panel()
        Me.lblTituloBC = New System.Windows.Forms.Label()
        Me.vfoId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vfoCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vfoNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vfoIdDA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vfonombreDA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tlpContenedorBuscar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gpbBusqueda.SuspendLayout()
        CType(Me.grdListarCarreras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContenedorTitulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpFiltros
        '
        Me.grpFiltros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFiltros.Location = New System.Drawing.Point(3, 48)
        Me.grpFiltros.Name = "grpFiltros"
        Me.grpFiltros.Size = New System.Drawing.Size(665, 84)
        Me.grpFiltros.TabIndex = 23
        Me.grpFiltros.TabStop = False
        '
        'tlpContenedorBuscar
        '
        Me.tlpContenedorBuscar.ColumnCount = 1
        Me.tlpContenedorBuscar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContenedorBuscar.Controls.Add(Me.grpFiltros, 0, 1)
        Me.tlpContenedorBuscar.Controls.Add(Me.Panel1, 0, 2)
        Me.tlpContenedorBuscar.Controls.Add(Me.pnlContenedorTitulo, 0, 0)
        Me.tlpContenedorBuscar.Location = New System.Drawing.Point(1, 3)
        Me.tlpContenedorBuscar.Name = "tlpContenedorBuscar"
        Me.tlpContenedorBuscar.RowCount = 3
        Me.tlpContenedorBuscar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.tlpContenedorBuscar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tlpContenedorBuscar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContenedorBuscar.Size = New System.Drawing.Size(672, 437)
        Me.tlpContenedorBuscar.TabIndex = 31
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSalir)
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
        Me.btnSalir.Location = New System.Drawing.Point(290, 250)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(96, 37)
        Me.btnSalir.TabIndex = 26
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'gpbBusqueda
        '
        Me.gpbBusqueda.Controls.Add(Me.grdListarCarreras)
        Me.gpbBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbBusqueda.Location = New System.Drawing.Point(18, 18)
        Me.gpbBusqueda.Name = "gpbBusqueda"
        Me.gpbBusqueda.Size = New System.Drawing.Size(626, 226)
        Me.gpbBusqueda.TabIndex = 24
        Me.gpbBusqueda.TabStop = False
        Me.gpbBusqueda.Text = "Lista"
        '
        'grdListarCarreras
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.grdListarCarreras.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdListarCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdListarCarreras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.vfoId, Me.vfoCodigo, Me.vfoNombre, Me.vfoIdDA, Me.vfonombreDA})
        Me.grdListarCarreras.Location = New System.Drawing.Point(7, 20)
        Me.grdListarCarreras.Name = "grdListarCarreras"
        Me.grdListarCarreras.Size = New System.Drawing.Size(613, 200)
        Me.grdListarCarreras.TabIndex = 0
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
        Me.lblTituloBC.Location = New System.Drawing.Point(236, 6)
        Me.lblTituloBC.Name = "lblTituloBC"
        Me.lblTituloBC.Size = New System.Drawing.Size(207, 31)
        Me.lblTituloBC.TabIndex = 21
        Me.lblTituloBC.Text = "Lista  Carreras"
        '
        'vfoId
        '
        Me.vfoId.HeaderText = "Id"
        Me.vfoId.Name = "vfoId"
        Me.vfoId.Visible = False
        '
        'vfoCodigo
        '
        Me.vfoCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.vfoCodigo.HeaderText = "Codigo"
        Me.vfoCodigo.Name = "vfoCodigo"
        '
        'vfoNombre
        '
        Me.vfoNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.vfoNombre.HeaderText = "Nombre"
        Me.vfoNombre.Name = "vfoNombre"
        '
        'vfoIdDA
        '
        Me.vfoIdDA.HeaderText = "Id Director"
        Me.vfoIdDA.Name = "vfoIdDA"
        Me.vfoIdDA.Visible = False
        '
        'vfonombreDA
        '
        Me.vfonombreDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.vfonombreDA.HeaderText = "Nombre Director"
        Me.vfonombreDA.Name = "vfonombreDA"
        '
        'frmListarCarreras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 443)
        Me.Controls.Add(Me.tlpContenedorBuscar)
        Me.Name = "frmListarCarreras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmListarCarreras"
        Me.tlpContenedorBuscar.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.gpbBusqueda.ResumeLayout(False)
        CType(Me.grdListarCarreras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContenedorTitulo.ResumeLayout(False)
        Me.pnlContenedorTitulo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents tlpContenedorBuscar As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents gpbBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents grdListarCarreras As System.Windows.Forms.DataGridView
    Friend WithEvents pnlContenedorTitulo As System.Windows.Forms.Panel
    Friend WithEvents lblTituloBC As System.Windows.Forms.Label
    Friend WithEvents vfoId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vfoCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vfoNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vfoIdDA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vfonombreDA As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
