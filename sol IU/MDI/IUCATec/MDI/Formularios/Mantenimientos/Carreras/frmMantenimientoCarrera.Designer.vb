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
        Me.gpbDatosUsuarios = New System.Windows.Forms.GroupBox()
        Me.txtNombre = New ControlesLeafSoft.rcTextBox()
        Me.txtCodigo = New ControlesLeafSoft.rcTextBox()
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
        Me.tlpContenedorPrincipal.SuspendLayout()
        Me.pnlContenedor.SuspendLayout()
        Me.gpbDatosUsuarios.SuspendLayout()
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
        Me.pnlContenedor.Controls.Add(Me.gpbDatosUsuarios)
        Me.pnlContenedor.Location = New System.Drawing.Point(3, 119)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(768, 446)
        Me.pnlContenedor.TabIndex = 6
        '
        'gpbDatosUsuarios
        '
        Me.gpbDatosUsuarios.Controls.Add(Me.txtNombre)
        Me.gpbDatosUsuarios.Controls.Add(Me.txtCodigo)
        Me.gpbDatosUsuarios.Controls.Add(Me.lblNombre)
        Me.gpbDatosUsuarios.Controls.Add(Me.lblApellido1)
        Me.gpbDatosUsuarios.Controls.Add(Me.lblValidaNombre)
        Me.gpbDatosUsuarios.Controls.Add(Me.lblValidaCodigo)
        Me.gpbDatosUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbDatosUsuarios.Location = New System.Drawing.Point(0, 3)
        Me.gpbDatosUsuarios.Name = "gpbDatosUsuarios"
        Me.gpbDatosUsuarios.Size = New System.Drawing.Size(770, 179)
        Me.gpbDatosUsuarios.TabIndex = 20
        Me.gpbDatosUsuarios.TabStop = False
        Me.gpbDatosUsuarios.Text = "Datos Usuarios"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(164, 98)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(124, 26)
        Me.txtNombre.TabIndex = 23
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(164, 53)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(124, 26)
        Me.txtCodigo.TabIndex = 22
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
        Me.lblValidaNombre.Location = New System.Drawing.Point(310, 109)
        Me.lblValidaNombre.Name = "lblValidaNombre"
        Me.lblValidaNombre.Size = New System.Drawing.Size(96, 13)
        Me.lblValidaNombre.TabIndex = 16
        Me.lblValidaNombre.Text = "* Digite Nombre"
        '
        'lblValidaCodigo
        '
        Me.lblValidaCodigo.AutoSize = True
        Me.lblValidaCodigo.Location = New System.Drawing.Point(310, 53)
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
        Me.gpbDatosUsuarios.ResumeLayout(False)
        Me.gpbDatosUsuarios.PerformLayout()
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
    Friend WithEvents gpbDatosUsuarios As System.Windows.Forms.GroupBox
    Friend WithEvents txtNombre As ControlesLeafSoft.rcTextBox
    Friend WithEvents txtCodigo As ControlesLeafSoft.rcTextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblApellido1 As System.Windows.Forms.Label
    Friend WithEvents lblValidaNombre As System.Windows.Forms.Label
    Friend WithEvents lblValidaCodigo As System.Windows.Forms.Label
End Class
