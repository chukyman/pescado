<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoCurso
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
        Me.tlpContenedorMantenimientoGrupo = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlEncabezado = New System.Windows.Forms.Panel()
        Me.lblTituloGrupos = New System.Windows.Forms.Label()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.gpbControles = New System.Windows.Forms.GroupBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnDeshacer = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.pnlDatos = New System.Windows.Forms.Panel()
        Me.gpbDatosUsuarios = New System.Windows.Forms.GroupBox()
        Me.lblValidaEstado = New System.Windows.Forms.Label()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.txtNombre = New ControlesLeafSoft.rcTextBox()
        Me.txtCodigo = New ControlesLeafSoft.rcTextBox()
        Me.lblValidaCodigo = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido1 = New System.Windows.Forms.Label()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.lblValidaCarrera = New System.Windows.Forms.Label()
        Me.lblValidaNombre = New System.Windows.Forms.Label()
        Me.cboCarrera = New System.Windows.Forms.ComboBox()
        Me.tlpContenedorMantenimientoGrupo.SuspendLayout()
        Me.pnlEncabezado.SuspendLayout()
        Me.pnlMenu.SuspendLayout()
        Me.gpbControles.SuspendLayout()
        Me.pnlDatos.SuspendLayout()
        Me.gpbDatosUsuarios.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpContenedorMantenimientoGrupo
        '
        Me.tlpContenedorMantenimientoGrupo.ColumnCount = 1
        Me.tlpContenedorMantenimientoGrupo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContenedorMantenimientoGrupo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpContenedorMantenimientoGrupo.Controls.Add(Me.pnlEncabezado, 0, 0)
        Me.tlpContenedorMantenimientoGrupo.Controls.Add(Me.pnlMenu, 0, 1)
        Me.tlpContenedorMantenimientoGrupo.Controls.Add(Me.pnlDatos, 0, 2)
        Me.tlpContenedorMantenimientoGrupo.Location = New System.Drawing.Point(-1, 0)
        Me.tlpContenedorMantenimientoGrupo.Name = "tlpContenedorMantenimientoGrupo"
        Me.tlpContenedorMantenimientoGrupo.RowCount = 3
        Me.tlpContenedorMantenimientoGrupo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.tlpContenedorMantenimientoGrupo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpContenedorMantenimientoGrupo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContenedorMantenimientoGrupo.Size = New System.Drawing.Size(786, 563)
        Me.tlpContenedorMantenimientoGrupo.TabIndex = 0
        '
        'pnlEncabezado
        '
        Me.pnlEncabezado.Controls.Add(Me.lblTituloGrupos)
        Me.pnlEncabezado.Location = New System.Drawing.Point(3, 3)
        Me.pnlEncabezado.Name = "pnlEncabezado"
        Me.pnlEncabezado.Size = New System.Drawing.Size(780, 37)
        Me.pnlEncabezado.TabIndex = 0
        '
        'lblTituloGrupos
        '
        Me.lblTituloGrupos.AutoSize = True
        Me.lblTituloGrupos.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloGrupos.Location = New System.Drawing.Point(240, 3)
        Me.lblTituloGrupos.Name = "lblTituloGrupos"
        Me.lblTituloGrupos.Size = New System.Drawing.Size(299, 31)
        Me.lblTituloGrupos.TabIndex = 12
        Me.lblTituloGrupos.Text = "Mantenimiento cursos"
        '
        'pnlMenu
        '
        Me.pnlMenu.Controls.Add(Me.gpbControles)
        Me.pnlMenu.Location = New System.Drawing.Point(3, 46)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(780, 54)
        Me.pnlMenu.TabIndex = 1
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
        Me.gpbControles.Location = New System.Drawing.Point(3, 3)
        Me.gpbControles.Name = "gpbControles"
        Me.gpbControles.Size = New System.Drawing.Size(777, 54)
        Me.gpbControles.TabIndex = 7
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
        'pnlDatos
        '
        Me.pnlDatos.Controls.Add(Me.gpbDatosUsuarios)
        Me.pnlDatos.Location = New System.Drawing.Point(3, 106)
        Me.pnlDatos.Name = "pnlDatos"
        Me.pnlDatos.Size = New System.Drawing.Size(780, 403)
        Me.pnlDatos.TabIndex = 2
        '
        'gpbDatosUsuarios
        '
        Me.gpbDatosUsuarios.Controls.Add(Me.lblValidaEstado)
        Me.gpbDatosUsuarios.Controls.Add(Me.cboEstado)
        Me.gpbDatosUsuarios.Controls.Add(Me.lblEstado)
        Me.gpbDatosUsuarios.Controls.Add(Me.txtNombre)
        Me.gpbDatosUsuarios.Controls.Add(Me.txtCodigo)
        Me.gpbDatosUsuarios.Controls.Add(Me.lblValidaCodigo)
        Me.gpbDatosUsuarios.Controls.Add(Me.lblNombre)
        Me.gpbDatosUsuarios.Controls.Add(Me.lblApellido1)
        Me.gpbDatosUsuarios.Controls.Add(Me.lblCedula)
        Me.gpbDatosUsuarios.Controls.Add(Me.lblValidaCarrera)
        Me.gpbDatosUsuarios.Controls.Add(Me.lblValidaNombre)
        Me.gpbDatosUsuarios.Controls.Add(Me.cboCarrera)
        Me.gpbDatosUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbDatosUsuarios.Location = New System.Drawing.Point(0, 3)
        Me.gpbDatosUsuarios.Name = "gpbDatosUsuarios"
        Me.gpbDatosUsuarios.Size = New System.Drawing.Size(502, 229)
        Me.gpbDatosUsuarios.TabIndex = 21
        Me.gpbDatosUsuarios.TabStop = False
        Me.gpbDatosUsuarios.Text = "Datos Usuarios"
        '
        'lblValidaEstado
        '
        Me.lblValidaEstado.AutoSize = True
        Me.lblValidaEstado.Location = New System.Drawing.Point(283, 190)
        Me.lblValidaEstado.Name = "lblValidaEstado"
        Me.lblValidaEstado.Size = New System.Drawing.Size(135, 13)
        Me.lblValidaEstado.TabIndex = 26
        Me.lblValidaEstado.Text = "* Seleccione el estado"
        '
        'cboEstado
        '
        Me.cboEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.cboEstado.Location = New System.Drawing.Point(136, 178)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(124, 28)
        Me.cboEstado.TabIndex = 25
        Me.cboEstado.Text = "--Seleccione--"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Location = New System.Drawing.Point(10, 182)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(73, 24)
        Me.lblEstado.TabIndex = 24
        Me.lblEstado.Text = "Estado:"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(136, 97)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(124, 26)
        Me.txtNombre.TabIndex = 23
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(136, 65)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(124, 26)
        Me.txtCodigo.TabIndex = 22
        '
        'lblValidaCodigo
        '
        Me.lblValidaCodigo.AutoSize = True
        Me.lblValidaCodigo.Location = New System.Drawing.Point(283, 72)
        Me.lblValidaCodigo.Name = "lblValidaCodigo"
        Me.lblValidaCodigo.Size = New System.Drawing.Size(96, 13)
        Me.lblValidaCodigo.TabIndex = 21
        Me.lblValidaCodigo.Text = "* Digite Nombre"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(6, 94)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(84, 24)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre:"
        '
        'lblApellido1
        '
        Me.lblApellido1.AutoSize = True
        Me.lblApellido1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido1.Location = New System.Drawing.Point(5, 133)
        Me.lblApellido1.Name = "lblApellido1"
        Me.lblApellido1.Size = New System.Drawing.Size(72, 24)
        Me.lblApellido1.TabIndex = 3
        Me.lblApellido1.Text = "Carrera"
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(6, 61)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(71, 24)
        Me.lblCedula.TabIndex = 1
        Me.lblCedula.Text = "Código"
        '
        'lblValidaCarrera
        '
        Me.lblValidaCarrera.AutoSize = True
        Me.lblValidaCarrera.Location = New System.Drawing.Point(283, 144)
        Me.lblValidaCarrera.Name = "lblValidaCarrera"
        Me.lblValidaCarrera.Size = New System.Drawing.Size(119, 13)
        Me.lblValidaCarrera.TabIndex = 16
        Me.lblValidaCarrera.Text = "*Seleccione carrera"
        '
        'lblValidaNombre
        '
        Me.lblValidaNombre.AutoSize = True
        Me.lblValidaNombre.Location = New System.Drawing.Point(283, 102)
        Me.lblValidaNombre.Name = "lblValidaNombre"
        Me.lblValidaNombre.Size = New System.Drawing.Size(96, 13)
        Me.lblValidaNombre.TabIndex = 15
        Me.lblValidaNombre.Text = "* Digite Nombre"
        '
        'cboCarrera
        '
        Me.cboCarrera.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCarrera.FormattingEnabled = True
        Me.cboCarrera.Items.AddRange(New Object() {"Profesor", "Director Academico"})
        Me.cboCarrera.Location = New System.Drawing.Point(136, 129)
        Me.cboCarrera.Name = "cboCarrera"
        Me.cboCarrera.Size = New System.Drawing.Size(124, 28)
        Me.cboCarrera.TabIndex = 0
        Me.cboCarrera.Text = "--Seleccione--"
        '
        'frmMantenimientoCurso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.tlpContenedorMantenimientoGrupo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMantenimientoCurso"
        Me.Text = "Mantenimiento grupos"
        Me.tlpContenedorMantenimientoGrupo.ResumeLayout(False)
        Me.pnlEncabezado.ResumeLayout(False)
        Me.pnlEncabezado.PerformLayout()
        Me.pnlMenu.ResumeLayout(False)
        Me.gpbControles.ResumeLayout(False)
        Me.pnlDatos.ResumeLayout(False)
        Me.gpbDatosUsuarios.ResumeLayout(False)
        Me.gpbDatosUsuarios.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpContenedorMantenimientoGrupo As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlEncabezado As System.Windows.Forms.Panel
    Friend WithEvents pnlMenu As System.Windows.Forms.Panel
    Friend WithEvents pnlDatos As System.Windows.Forms.Panel
    Friend WithEvents lblTituloGrupos As System.Windows.Forms.Label
    Friend WithEvents gpbControles As System.Windows.Forms.GroupBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnDeshacer As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents gpbDatosUsuarios As System.Windows.Forms.GroupBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblApellido1 As System.Windows.Forms.Label
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents lblValidaCarrera As System.Windows.Forms.Label
    Friend WithEvents lblValidaNombre As System.Windows.Forms.Label
    Friend WithEvents cboCarrera As System.Windows.Forms.ComboBox
    Friend WithEvents lblValidaCodigo As System.Windows.Forms.Label
    Friend WithEvents txtNombre As ControlesLeafSoft.rcTextBox
    Friend WithEvents txtCodigo As ControlesLeafSoft.rcTextBox
    Friend WithEvents lblValidaEstado As System.Windows.Forms.Label
    Friend WithEvents cboEstado As System.Windows.Forms.ComboBox
    Friend WithEvents lblEstado As System.Windows.Forms.Label
End Class
