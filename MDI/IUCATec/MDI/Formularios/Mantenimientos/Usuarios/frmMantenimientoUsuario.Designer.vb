<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoUsuario
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
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.gpbDatosUsuarios = New System.Windows.Forms.GroupBox()
        Me.txtApellido2 = New ControlesLeafSoft.rcTextBox()
        Me.txtApellido1 = New ControlesLeafSoft.rcTextBox()
        Me.txtNombre = New ControlesLeafSoft.rcTextBox()
        Me.txtCedula = New ControlesLeafSoft.rcTextBox()
        Me.lblValidaGeneros = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblValidaTipoRol = New System.Windows.Forms.Label()
        Me.lblApellido1 = New System.Windows.Forms.Label()
        Me.lblValidaCedula = New System.Windows.Forms.Label()
        Me.lblApellido2 = New System.Windows.Forms.Label()
        Me.lblValidaApellido2 = New System.Windows.Forms.Label()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.lblValidaApellido = New System.Windows.Forms.Label()
        Me.lblGenero = New System.Windows.Forms.Label()
        Me.lblValidaNombre = New System.Windows.Forms.Label()
        Me.lblTipoRol = New System.Windows.Forms.Label()
        Me.chkF = New System.Windows.Forms.CheckBox()
        Me.chkM = New System.Windows.Forms.CheckBox()
        Me.cboTipoRol = New System.Windows.Forms.ComboBox()
        Me.pnlContenedorTitulo = New System.Windows.Forms.Panel()
        Me.lblTituloMU = New System.Windows.Forms.Label()
        Me.gpbControles = New System.Windows.Forms.GroupBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnDeshacer = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.tlpContenedorPrincipal = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlContenedor.SuspendLayout()
        Me.gpbDatosUsuarios.SuspendLayout()
        Me.pnlContenedorTitulo.SuspendLayout()
        Me.gpbControles.SuspendLayout()
        Me.tlpContenedorPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContenedor
        '
        Me.pnlContenedor.Controls.Add(Me.gpbDatosUsuarios)
        Me.pnlContenedor.Location = New System.Drawing.Point(3, 106)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(786, 470)
        Me.pnlContenedor.TabIndex = 6
        '
        'gpbDatosUsuarios
        '
        Me.gpbDatosUsuarios.Controls.Add(Me.txtApellido2)
        Me.gpbDatosUsuarios.Controls.Add(Me.txtApellido1)
        Me.gpbDatosUsuarios.Controls.Add(Me.txtNombre)
        Me.gpbDatosUsuarios.Controls.Add(Me.txtCedula)
        Me.gpbDatosUsuarios.Controls.Add(Me.lblValidaGeneros)
        Me.gpbDatosUsuarios.Controls.Add(Me.lblNombre)
        Me.gpbDatosUsuarios.Controls.Add(Me.lblValidaTipoRol)
        Me.gpbDatosUsuarios.Controls.Add(Me.lblApellido1)
        Me.gpbDatosUsuarios.Controls.Add(Me.lblValidaCedula)
        Me.gpbDatosUsuarios.Controls.Add(Me.lblApellido2)
        Me.gpbDatosUsuarios.Controls.Add(Me.lblValidaApellido2)
        Me.gpbDatosUsuarios.Controls.Add(Me.lblCedula)
        Me.gpbDatosUsuarios.Controls.Add(Me.lblValidaApellido)
        Me.gpbDatosUsuarios.Controls.Add(Me.lblGenero)
        Me.gpbDatosUsuarios.Controls.Add(Me.lblValidaNombre)
        Me.gpbDatosUsuarios.Controls.Add(Me.lblTipoRol)
        Me.gpbDatosUsuarios.Controls.Add(Me.chkF)
        Me.gpbDatosUsuarios.Controls.Add(Me.chkM)
        Me.gpbDatosUsuarios.Controls.Add(Me.cboTipoRol)
        Me.gpbDatosUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbDatosUsuarios.Location = New System.Drawing.Point(3, 3)
        Me.gpbDatosUsuarios.Name = "gpbDatosUsuarios"
        Me.gpbDatosUsuarios.Size = New System.Drawing.Size(498, 391)
        Me.gpbDatosUsuarios.TabIndex = 20
        Me.gpbDatosUsuarios.TabStop = False
        Me.gpbDatosUsuarios.Text = "Datos Usuarios"
        '
        'txtApellido2
        '
        Me.txtApellido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido2.Location = New System.Drawing.Point(208, 187)
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(124, 26)
        Me.txtApellido2.TabIndex = 24
        '
        'txtApellido1
        '
        Me.txtApellido1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido1.Location = New System.Drawing.Point(208, 144)
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(124, 26)
        Me.txtApellido1.TabIndex = 23
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(208, 100)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(124, 26)
        Me.txtNombre.TabIndex = 22
        '
        'txtCedula
        '
        Me.txtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.Location = New System.Drawing.Point(208, 55)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(124, 26)
        Me.txtCedula.TabIndex = 21
        '
        'lblValidaGeneros
        '
        Me.lblValidaGeneros.AutoSize = True
        Me.lblValidaGeneros.Location = New System.Drawing.Point(340, 234)
        Me.lblValidaGeneros.Name = "lblValidaGeneros"
        Me.lblValidaGeneros.Size = New System.Drawing.Size(94, 13)
        Me.lblValidaGeneros.TabIndex = 20
        Me.lblValidaGeneros.Text = "* Digite Genero"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(26, 102)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(84, 24)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre:"
        '
        'lblValidaTipoRol
        '
        Me.lblValidaTipoRol.AutoSize = True
        Me.lblValidaTipoRol.Location = New System.Drawing.Point(340, 275)
        Me.lblValidaTipoRol.Name = "lblValidaTipoRol"
        Me.lblValidaTipoRol.Size = New System.Drawing.Size(120, 13)
        Me.lblValidaTipoRol.TabIndex = 19
        Me.lblValidaTipoRol.Text = "*Selecione Tipo Rol"
        '
        'lblApellido1
        '
        Me.lblApellido1.AutoSize = True
        Me.lblApellido1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido1.Location = New System.Drawing.Point(26, 147)
        Me.lblApellido1.Name = "lblApellido1"
        Me.lblApellido1.Size = New System.Drawing.Size(144, 24)
        Me.lblApellido1.TabIndex = 3
        Me.lblApellido1.Text = "Primer Apellido:"
        '
        'lblValidaCedula
        '
        Me.lblValidaCedula.AutoSize = True
        Me.lblValidaCedula.Location = New System.Drawing.Point(340, 63)
        Me.lblValidaCedula.Name = "lblValidaCedula"
        Me.lblValidaCedula.Size = New System.Drawing.Size(92, 13)
        Me.lblValidaCedula.TabIndex = 18
        Me.lblValidaCedula.Text = "* Digite Cédula"
        '
        'lblApellido2
        '
        Me.lblApellido2.AutoSize = True
        Me.lblApellido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido2.Location = New System.Drawing.Point(26, 189)
        Me.lblApellido2.Name = "lblApellido2"
        Me.lblApellido2.Size = New System.Drawing.Size(167, 24)
        Me.lblApellido2.TabIndex = 4
        Me.lblApellido2.Text = "Segundo Apellido:"
        '
        'lblValidaApellido2
        '
        Me.lblValidaApellido2.AutoSize = True
        Me.lblValidaApellido2.Location = New System.Drawing.Point(338, 192)
        Me.lblValidaApellido2.Name = "lblValidaApellido2"
        Me.lblValidaApellido2.Size = New System.Drawing.Size(152, 13)
        Me.lblValidaApellido2.TabIndex = 17
        Me.lblValidaApellido2.Text = "* Digite Segundo Apellido"
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(26, 60)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(75, 24)
        Me.lblCedula.TabIndex = 1
        Me.lblCedula.Text = "Cédula:"
        '
        'lblValidaApellido
        '
        Me.lblValidaApellido.AutoSize = True
        Me.lblValidaApellido.Location = New System.Drawing.Point(340, 150)
        Me.lblValidaApellido.Name = "lblValidaApellido"
        Me.lblValidaApellido.Size = New System.Drawing.Size(137, 13)
        Me.lblValidaApellido.TabIndex = 16
        Me.lblValidaApellido.Text = "* Digite Primer Apellido"
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenero.Location = New System.Drawing.Point(26, 231)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(79, 24)
        Me.lblGenero.TabIndex = 5
        Me.lblGenero.Text = "Genero:"
        '
        'lblValidaNombre
        '
        Me.lblValidaNombre.AutoSize = True
        Me.lblValidaNombre.Location = New System.Drawing.Point(338, 105)
        Me.lblValidaNombre.Name = "lblValidaNombre"
        Me.lblValidaNombre.Size = New System.Drawing.Size(96, 13)
        Me.lblValidaNombre.TabIndex = 15
        Me.lblValidaNombre.Text = "* Digite Nombre"
        '
        'lblTipoRol
        '
        Me.lblTipoRol.AutoSize = True
        Me.lblTipoRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoRol.Location = New System.Drawing.Point(26, 272)
        Me.lblTipoRol.Name = "lblTipoRol"
        Me.lblTipoRol.Size = New System.Drawing.Size(91, 24)
        Me.lblTipoRol.TabIndex = 0
        Me.lblTipoRol.Text = "Tipo Rol: "
        '
        'chkF
        '
        Me.chkF.AutoSize = True
        Me.chkF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkF.Location = New System.Drawing.Point(280, 233)
        Me.chkF.Name = "chkF"
        Me.chkF.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkF.Size = New System.Drawing.Size(35, 20)
        Me.chkF.TabIndex = 14
        Me.chkF.Text = "F"
        Me.chkF.UseVisualStyleBackColor = True
        '
        'chkM
        '
        Me.chkM.AutoSize = True
        Me.chkM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkM.Location = New System.Drawing.Point(220, 233)
        Me.chkM.Name = "chkM"
        Me.chkM.Size = New System.Drawing.Size(38, 20)
        Me.chkM.TabIndex = 13
        Me.chkM.Text = "M"
        Me.chkM.UseVisualStyleBackColor = True
        '
        'cboTipoRol
        '
        Me.cboTipoRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoRol.FormattingEnabled = True
        Me.cboTipoRol.Items.AddRange(New Object() {"Profesor", "Director Academico"})
        Me.cboTipoRol.Location = New System.Drawing.Point(208, 268)
        Me.cboTipoRol.Name = "cboTipoRol"
        Me.cboTipoRol.Size = New System.Drawing.Size(124, 28)
        Me.cboTipoRol.TabIndex = 0
        '
        'pnlContenedorTitulo
        '
        Me.pnlContenedorTitulo.Controls.Add(Me.lblTituloMU)
        Me.pnlContenedorTitulo.Location = New System.Drawing.Point(3, 3)
        Me.pnlContenedorTitulo.Name = "pnlContenedorTitulo"
        Me.pnlContenedorTitulo.Size = New System.Drawing.Size(786, 37)
        Me.pnlContenedorTitulo.TabIndex = 21
        '
        'lblTituloMU
        '
        Me.lblTituloMU.AutoSize = True
        Me.lblTituloMU.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloMU.Location = New System.Drawing.Point(257, 6)
        Me.lblTituloMU.Name = "lblTituloMU"
        Me.lblTituloMU.Size = New System.Drawing.Size(298, 31)
        Me.lblTituloMU.TabIndex = 21
        Me.lblTituloMU.Text = "Manteniento Usuarios"
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
        Me.gpbControles.Location = New System.Drawing.Point(3, 46)
        Me.gpbControles.Name = "gpbControles"
        Me.gpbControles.Size = New System.Drawing.Size(786, 54)
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
        Me.btnModificar.Text = "Modifcar"
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
        'tlpContenedorPrincipal
        '
        Me.tlpContenedorPrincipal.ColumnCount = 1
        Me.tlpContenedorPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContenedorPrincipal.Controls.Add(Me.pnlContenedor, 0, 2)
        Me.tlpContenedorPrincipal.Controls.Add(Me.gpbControles, 0, 1)
        Me.tlpContenedorPrincipal.Controls.Add(Me.pnlContenedorTitulo, 0, 0)
        Me.tlpContenedorPrincipal.Location = New System.Drawing.Point(-1, 2)
        Me.tlpContenedorPrincipal.Name = "tlpContenedorPrincipal"
        Me.tlpContenedorPrincipal.RowCount = 3
        Me.tlpContenedorPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.tlpContenedorPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpContenedorPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContenedorPrincipal.Size = New System.Drawing.Size(798, 586)
        Me.tlpContenedorPrincipal.TabIndex = 7
        '
        'frmMantenimientoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.tlpContenedorPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMantenimientoUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        Me.pnlContenedor.ResumeLayout(False)
        Me.gpbDatosUsuarios.ResumeLayout(False)
        Me.gpbDatosUsuarios.PerformLayout()
        Me.pnlContenedorTitulo.ResumeLayout(False)
        Me.pnlContenedorTitulo.PerformLayout()
        Me.gpbControles.ResumeLayout(False)
        Me.tlpContenedorPrincipal.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlContenedor As System.Windows.Forms.Panel
    Friend WithEvents chkF As System.Windows.Forms.CheckBox
    Friend WithEvents chkM As System.Windows.Forms.CheckBox
    Friend WithEvents cboTipoRol As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoRol As System.Windows.Forms.Label
    Friend WithEvents lblGenero As System.Windows.Forms.Label
    Friend WithEvents lblApellido2 As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblApellido1 As System.Windows.Forms.Label
    Friend WithEvents gpbControles As System.Windows.Forms.GroupBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnDeshacer As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents lblValidaNombre As System.Windows.Forms.Label
    Friend WithEvents lblValidaTipoRol As System.Windows.Forms.Label
    Friend WithEvents lblValidaCedula As System.Windows.Forms.Label
    Friend WithEvents lblValidaApellido2 As System.Windows.Forms.Label
    Friend WithEvents lblValidaApellido As System.Windows.Forms.Label
    Friend WithEvents lblTituloMU As System.Windows.Forms.Label
    Friend WithEvents gpbDatosUsuarios As System.Windows.Forms.GroupBox
    Friend WithEvents pnlContenedorTitulo As System.Windows.Forms.Panel
    Friend WithEvents lblValidaGeneros As System.Windows.Forms.Label
    Friend WithEvents tlpContenedorPrincipal As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents txtCedula As ControlesLeafSoft.rcTextBox
    Friend WithEvents txtApellido2 As ControlesLeafSoft.rcTextBox
    Friend WithEvents txtApellido1 As ControlesLeafSoft.rcTextBox
    Friend WithEvents txtNombre As ControlesLeafSoft.rcTextBox
End Class
