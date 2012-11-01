<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoCarrera
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
        Me.tlpContenedorPrincipal = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.s = New System.Windows.Forms.GroupBox()
        Me.txtNombre = New ControlesLeafSoft.rcTextBox()
        Me.txtCodigo = New ControlesLeafSoft.rcTextBox()
        Me.lblValidaDA = New System.Windows.Forms.Label()
        Me.cboDa = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido1 = New System.Windows.Forms.Label()
        Me.lblValidaNombre = New System.Windows.Forms.Label()
        Me.lblValidaCodigo = New System.Windows.Forms.Label()
        Me.gpbControles = New System.Windows.Forms.GroupBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnDeshacer = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.pnlContenedorTitulo = New System.Windows.Forms.Panel()
        Me.lblTituloMU = New System.Windows.Forms.Label()
        Me.txtInvisible = New System.Windows.Forms.TextBox()
        Me.tlpContenedorPrincipal.SuspendLayout()
        Me.pnlContenedor.SuspendLayout()
        Me.s.SuspendLayout()
        Me.gpbControles.SuspendLayout()
        Me.pnlContenedorTitulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpContenedorPrincipal
        '
        Me.tlpContenedorPrincipal.ColumnCount = 1
        Me.tlpContenedorPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContenedorPrincipal.Controls.Add(Me.pnlContenedor, 0, 2)
        Me.tlpContenedorPrincipal.Controls.Add(Me.gpbControles, 0, 1)
        Me.tlpContenedorPrincipal.Controls.Add(Me.pnlContenedorTitulo, 0, 0)
        Me.tlpContenedorPrincipal.Location = New System.Drawing.Point(4, 0)
        Me.tlpContenedorPrincipal.Name = "tlpContenedorPrincipal"
        Me.tlpContenedorPrincipal.RowCount = 3
        Me.tlpContenedorPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpContenedorPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me.tlpContenedorPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContenedorPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpContenedorPrincipal.Size = New System.Drawing.Size(774, 568)
        Me.tlpContenedorPrincipal.TabIndex = 8
        '
        'pnlContenedor
        '
        Me.pnlContenedor.Controls.Add(Me.s)
        Me.pnlContenedor.Location = New System.Drawing.Point(3, 119)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(768, 446)
        Me.pnlContenedor.TabIndex = 6
        '
        's
        '
        Me.s.Controls.Add(Me.txtInvisible)
        Me.s.Controls.Add(Me.txtNombre)
        Me.s.Controls.Add(Me.txtCodigo)
        Me.s.Controls.Add(Me.lblValidaDA)
        Me.s.Controls.Add(Me.cboDa)
        Me.s.Controls.Add(Me.Label1)
        Me.s.Controls.Add(Me.lblNombre)
        Me.s.Controls.Add(Me.lblApellido1)
        Me.s.Controls.Add(Me.lblValidaNombre)
        Me.s.Controls.Add(Me.lblValidaCodigo)
        Me.s.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s.Location = New System.Drawing.Point(0, 3)
        Me.s.Name = "s"
        Me.s.Size = New System.Drawing.Size(770, 179)
        Me.s.TabIndex = 20
        Me.s.TabStop = False
        Me.s.Text = "Datos Usuarios"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(164, 100)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(232, 26)
        Me.txtNombre.TabIndex = 28
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(164, 50)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(232, 26)
        Me.txtCodigo.TabIndex = 27
        '
        'lblValidaDA
        '
        Me.lblValidaDA.AutoSize = True
        Me.lblValidaDA.Location = New System.Drawing.Point(430, 155)
        Me.lblValidaDA.Name = "lblValidaDA"
        Me.lblValidaDA.Size = New System.Drawing.Size(197, 13)
        Me.lblValidaDA.TabIndex = 26
        Me.lblValidaDA.Text = "*Selecione el Director Academico"
        '
        'cboDa
        '
        Me.cboDa.FormattingEnabled = True
        Me.cboDa.Location = New System.Drawing.Point(164, 152)
        Me.cboDa.Name = "cboDa"
        Me.cboDa.Size = New System.Drawing.Size(232, 21)
        Me.cboDa.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 24)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Director:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(36, 50)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(76, 24)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Codigo:"
        '
        'lblApellido1
        '
        Me.lblApellido1.AutoSize = True
        Me.lblApellido1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido1.Location = New System.Drawing.Point(36, 100)
        Me.lblApellido1.Name = "lblApellido1"
        Me.lblApellido1.Size = New System.Drawing.Size(84, 24)
        Me.lblApellido1.TabIndex = 3
        Me.lblApellido1.Text = "Nombre:"
        '
        'lblValidaNombre
        '
        Me.lblValidaNombre.AutoSize = True
        Me.lblValidaNombre.Location = New System.Drawing.Point(425, 109)
        Me.lblValidaNombre.Name = "lblValidaNombre"
        Me.lblValidaNombre.Size = New System.Drawing.Size(96, 13)
        Me.lblValidaNombre.TabIndex = 16
        Me.lblValidaNombre.Text = "* Digite Nombre"
        '
        'lblValidaCodigo
        '
        Me.lblValidaCodigo.AutoSize = True
        Me.lblValidaCodigo.Location = New System.Drawing.Point(425, 61)
        Me.lblValidaCodigo.Name = "lblValidaCodigo"
        Me.lblValidaCodigo.Size = New System.Drawing.Size(92, 13)
        Me.lblValidaCodigo.TabIndex = 15
        Me.lblValidaCodigo.Text = "* Digite Código"
        '
        'gpbControles
        '
        Me.gpbControles.Controls.Add(Me.btnGuardar)
        Me.gpbControles.Controls.Add(Me.btnNuevo)
        Me.gpbControles.Controls.Add(Me.btnModificar)
        Me.gpbControles.Controls.Add(Me.btnDeshacer)
        Me.gpbControles.Controls.Add(Me.btnEliminar)
        Me.gpbControles.Controls.Add(Me.btnBuscar)
        Me.gpbControles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbControles.Location = New System.Drawing.Point(3, 51)
        Me.gpbControles.Name = "gpbControles"
        Me.gpbControles.Size = New System.Drawing.Size(768, 54)
        Me.gpbControles.TabIndex = 6
        Me.gpbControles.TabStop = False
        Me.gpbControles.Text = "Controles"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnGuardar.Location = New System.Drawing.Point(133, 15)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(84, 37)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNuevo.Location = New System.Drawing.Point(33, 15)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(84, 37)
        Me.btnNuevo.TabIndex = 3
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnModificar.Location = New System.Drawing.Point(233, 15)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(84, 37)
        Me.btnModificar.TabIndex = 4
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnDeshacer
        '
        Me.btnDeshacer.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnDeshacer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeshacer.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDeshacer.Location = New System.Drawing.Point(533, 15)
        Me.btnDeshacer.Name = "btnDeshacer"
        Me.btnDeshacer.Size = New System.Drawing.Size(84, 37)
        Me.btnDeshacer.TabIndex = 7
        Me.btnDeshacer.Text = "Deshacer"
        Me.btnDeshacer.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEliminar.Location = New System.Drawing.Point(333, 15)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(84, 37)
        Me.btnEliminar.TabIndex = 5
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBuscar.Location = New System.Drawing.Point(433, 15)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(84, 37)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'pnlContenedorTitulo
        '
        Me.pnlContenedorTitulo.Controls.Add(Me.lblTituloMU)
        Me.pnlContenedorTitulo.Location = New System.Drawing.Point(3, 3)
        Me.pnlContenedorTitulo.Name = "pnlContenedorTitulo"
        Me.pnlContenedorTitulo.Size = New System.Drawing.Size(768, 41)
        Me.pnlContenedorTitulo.TabIndex = 21
        '
        'lblTituloMU
        '
        Me.lblTituloMU.AutoSize = True
        Me.lblTituloMU.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloMU.Location = New System.Drawing.Point(256, 10)
        Me.lblTituloMU.Name = "lblTituloMU"
        Me.lblTituloMU.Size = New System.Drawing.Size(296, 31)
        Me.lblTituloMU.TabIndex = 21
        Me.lblTituloMU.Text = "Manteniento Carreras"
        '
        'txtInvisible
        '
        Me.txtInvisible.Location = New System.Drawing.Point(687, 47)
        Me.txtInvisible.Name = "txtInvisible"
        Me.txtInvisible.Size = New System.Drawing.Size(50, 20)
        Me.txtInvisible.TabIndex = 29
        '
        'frmMantenimientoCarrera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 533)
        Me.Controls.Add(Me.tlpContenedorPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMantenimientoCarrera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carreras"
        Me.tlpContenedorPrincipal.ResumeLayout(False)
        Me.pnlContenedor.ResumeLayout(False)
        Me.s.ResumeLayout(False)
        Me.s.PerformLayout()
        Me.gpbControles.ResumeLayout(False)
        Me.pnlContenedorTitulo.ResumeLayout(False)
        Me.pnlContenedorTitulo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpContenedorPrincipal As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents gpbControles As System.Windows.Forms.GroupBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnDeshacer As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents pnlContenedorTitulo As System.Windows.Forms.Panel
    Friend WithEvents lblTituloMU As System.Windows.Forms.Label
    Friend WithEvents pnlContenedor As System.Windows.Forms.Panel
    Friend WithEvents s As System.Windows.Forms.GroupBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblApellido1 As System.Windows.Forms.Label
    Friend WithEvents lblValidaNombre As System.Windows.Forms.Label
    Friend WithEvents lblValidaCodigo As System.Windows.Forms.Label
    Friend WithEvents cboDa As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblValidaDA As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As ControlesLeafSoft.rcTextBox
    Friend WithEvents txtNombre As ControlesLeafSoft.rcTextBox
    Friend WithEvents txtInvisible As System.Windows.Forms.TextBox
End Class
