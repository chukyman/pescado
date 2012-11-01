<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListarDirectorAcad
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
        Me.gpbBusqueda = New System.Windows.Forms.GroupBox()
        Me.grdBuscarUsuarios = New System.Windows.Forms.DataGridView()
        Me.grpFiltros = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblTituloBC = New System.Windows.Forms.Label()
        Me.tlpContenedorBuscar = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlContenedorTitulo = New System.Windows.Forms.Panel()
        Me.vfoNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vfoApellido1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vfoApellido2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vfoNombreRol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vfoGenero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vfoCedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vfoCorreo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gpbBusqueda.SuspendLayout()
        CType(Me.grdBuscarUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.tlpContenedorBuscar.SuspendLayout()
        Me.pnlContenedorTitulo.SuspendLayout()
        Me.SuspendLayout()
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
        Me.gpbBusqueda.Text = "Lista"
        '
        'grdBuscarUsuarios
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.grdBuscarUsuarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdBuscarUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBuscarUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.vfoNombre, Me.vfoApellido1, Me.vfoApellido2, Me.vfoNombreRol, Me.vfoGenero, Me.vfoCedula, Me.vfoCorreo})
        Me.grdBuscarUsuarios.Location = New System.Drawing.Point(7, 20)
        Me.grdBuscarUsuarios.Name = "grdBuscarUsuarios"
        Me.grdBuscarUsuarios.Size = New System.Drawing.Size(613, 200)
        Me.grdBuscarUsuarios.TabIndex = 0
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
        Me.btnSalir.Location = New System.Drawing.Point(273, 250)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(96, 37)
        Me.btnSalir.TabIndex = 26
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'lblTituloBC
        '
        Me.lblTituloBC.AutoSize = True
        Me.lblTituloBC.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloBC.Location = New System.Drawing.Point(162, 6)
        Me.lblTituloBC.Name = "lblTituloBC"
        Me.lblTituloBC.Size = New System.Drawing.Size(348, 31)
        Me.lblTituloBC.TabIndex = 21
        Me.lblTituloBC.Text = "Lista  Director Academico"
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
        Me.tlpContenedorBuscar.TabIndex = 30
        '
        'pnlContenedorTitulo
        '
        Me.pnlContenedorTitulo.Controls.Add(Me.lblTituloBC)
        Me.pnlContenedorTitulo.Location = New System.Drawing.Point(3, 3)
        Me.pnlContenedorTitulo.Name = "pnlContenedorTitulo"
        Me.pnlContenedorTitulo.Size = New System.Drawing.Size(666, 37)
        Me.pnlContenedorTitulo.TabIndex = 22
        '
        'vfoNombre
        '
        Me.vfoNombre.HeaderText = "Nombre"
        Me.vfoNombre.Name = "vfoNombre"
        Me.vfoNombre.Width = 82
        '
        'vfoApellido1
        '
        Me.vfoApellido1.HeaderText = "1er Apellido"
        Me.vfoApellido1.Name = "vfoApellido1"
        Me.vfoApellido1.Width = 81
        '
        'vfoApellido2
        '
        Me.vfoApellido2.HeaderText = "2do Apellido"
        Me.vfoApellido2.Name = "vfoApellido2"
        Me.vfoApellido2.Width = 82
        '
        'vfoNombreRol
        '
        Me.vfoNombreRol.HeaderText = "Puesto"
        Me.vfoNombreRol.Name = "vfoNombreRol"
        Me.vfoNombreRol.Width = 81
        '
        'vfoGenero
        '
        Me.vfoGenero.HeaderText = "Género"
        Me.vfoGenero.Name = "vfoGenero"
        Me.vfoGenero.Width = 82
        '
        'vfoCedula
        '
        Me.vfoCedula.HeaderText = "Cédula"
        Me.vfoCedula.Name = "vfoCedula"
        Me.vfoCedula.Width = 81
        '
        'vfoCorreo
        '
        Me.vfoCorreo.HeaderText = "Correo"
        Me.vfoCorreo.Name = "vfoCorreo"
        Me.vfoCorreo.Width = 81
        '
        'frmListarDirectorAcad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 443)
        Me.Controls.Add(Me.tlpContenedorBuscar)
        Me.Name = "frmListarDirectorAcad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listar Director Academico"
        Me.gpbBusqueda.ResumeLayout(False)
        CType(Me.grdBuscarUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.tlpContenedorBuscar.ResumeLayout(False)
        Me.pnlContenedorTitulo.ResumeLayout(False)
        Me.pnlContenedorTitulo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpbBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents grdBuscarUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents grpFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents lblTituloBC As System.Windows.Forms.Label
    Friend WithEvents tlpContenedorBuscar As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlContenedorTitulo As System.Windows.Forms.Panel
    Friend WithEvents vfoNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vfoApellido1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vfoApellido2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vfoNombreRol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vfoGenero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vfoCedula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vfoCorreo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
