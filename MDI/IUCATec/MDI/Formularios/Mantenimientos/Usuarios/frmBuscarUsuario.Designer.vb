﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarUsuario
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
        Me.pnlContenedorTitulo = New System.Windows.Forms.Panel()
        Me.lblTituloBU = New System.Windows.Forms.Label()
        Me.grpFiltros = New System.Windows.Forms.GroupBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.gpbBusqueda = New System.Windows.Forms.GroupBox()
        Me.grdBuscarUsuarios = New System.Windows.Forms.DataGridView()
        Me.btnSelecionar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tlpContenedorBuscar = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlContenedorTitulo.SuspendLayout()
        Me.grpFiltros.SuspendLayout()
        Me.gpbBusqueda.SuspendLayout()
        CType(Me.grdBuscarUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.tlpContenedorBuscar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContenedorTitulo
        '
        Me.pnlContenedorTitulo.Controls.Add(Me.lblTituloBU)
        Me.pnlContenedorTitulo.Location = New System.Drawing.Point(3, 3)
        Me.pnlContenedorTitulo.Name = "pnlContenedorTitulo"
        Me.pnlContenedorTitulo.Size = New System.Drawing.Size(666, 37)
        Me.pnlContenedorTitulo.TabIndex = 22
        '
        'lblTituloBU
        '
        Me.lblTituloBU.AutoSize = True
        Me.lblTituloBU.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloBU.Location = New System.Drawing.Point(240, 6)
        Me.lblTituloBU.Name = "lblTituloBU"
        Me.lblTituloBU.Size = New System.Drawing.Size(214, 31)
        Me.lblTituloBU.TabIndex = 21
        Me.lblTituloBU.Text = "Buscar Usuario"
        '
        'grpFiltros
        '
        Me.grpFiltros.Controls.Add(Me.lblNombre)
        Me.grpFiltros.Controls.Add(Me.lblCedula)
        Me.grpFiltros.Controls.Add(Me.txtCedula)
        Me.grpFiltros.Controls.Add(Me.txtNombre)
        Me.grpFiltros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFiltros.Location = New System.Drawing.Point(3, 48)
        Me.grpFiltros.Name = "grpFiltros"
        Me.grpFiltros.Size = New System.Drawing.Size(665, 84)
        Me.grpFiltros.TabIndex = 23
        Me.grpFiltros.TabStop = False
        Me.grpFiltros.Text = "Filtros"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(6, 16)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(84, 24)
        Me.lblNombre.TabIndex = 10
        Me.lblNombre.Text = "Nombre:"
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(6, 49)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(75, 24)
        Me.lblCedula.TabIndex = 9
        Me.lblCedula.Text = "Cédula:"
        '
        'txtCedula
        '
        Me.txtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.Location = New System.Drawing.Point(116, 46)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(124, 26)
        Me.txtCedula.TabIndex = 11
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(116, 14)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(124, 26)
        Me.txtNombre.TabIndex = 12
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
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver
        Me.grdBuscarUsuarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.grdBuscarUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBuscarUsuarios.Location = New System.Drawing.Point(7, 20)
        Me.grdBuscarUsuarios.Name = "grdBuscarUsuarios"
        Me.grdBuscarUsuarios.Size = New System.Drawing.Size(613, 200)
        Me.grdBuscarUsuarios.TabIndex = 0
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
        'tlpContenedorBuscar
        '
        Me.tlpContenedorBuscar.ColumnCount = 1
        Me.tlpContenedorBuscar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContenedorBuscar.Controls.Add(Me.grpFiltros, 0, 1)
        Me.tlpContenedorBuscar.Controls.Add(Me.Panel1, 0, 2)
        Me.tlpContenedorBuscar.Controls.Add(Me.pnlContenedorTitulo, 0, 0)
        Me.tlpContenedorBuscar.Location = New System.Drawing.Point(12, 12)
        Me.tlpContenedorBuscar.Name = "tlpContenedorBuscar"
        Me.tlpContenedorBuscar.RowCount = 3
        Me.tlpContenedorBuscar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.tlpContenedorBuscar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tlpContenedorBuscar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContenedorBuscar.Size = New System.Drawing.Size(672, 437)
        Me.tlpContenedorBuscar.TabIndex = 28
        '
        'frmBuscarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 462)
        Me.Controls.Add(Me.tlpContenedorBuscar)
        Me.Name = "frmBuscarUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Usuario"
        Me.pnlContenedorTitulo.ResumeLayout(False)
        Me.pnlContenedorTitulo.PerformLayout()
        Me.grpFiltros.ResumeLayout(False)
        Me.grpFiltros.PerformLayout()
        Me.gpbBusqueda.ResumeLayout(False)
        CType(Me.grdBuscarUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.tlpContenedorBuscar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlContenedorTitulo As System.Windows.Forms.Panel
    Friend WithEvents lblTituloBU As System.Windows.Forms.Label
    Friend WithEvents grpFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents gpbBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents grdBuscarUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents btnSelecionar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tlpContenedorBuscar As System.Windows.Forms.TableLayoutPanel
End Class
