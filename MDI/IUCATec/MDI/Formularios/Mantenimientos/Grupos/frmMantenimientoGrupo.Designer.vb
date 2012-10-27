<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoGrupo
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
        Me.tlpContenedorPrincipal = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.pnlDatos = New System.Windows.Forms.Panel()
        Me.lblValidaCantEst = New System.Windows.Forms.Label()
        Me.txtCantEstudiantes = New ControlesLeafSoft.rcTextBox()
        Me.lblCantidadEstudiantes = New System.Windows.Forms.Label()
        Me.cboCursos = New System.Windows.Forms.ComboBox()
        Me.txtDescripcion = New ControlesLeafSoft.rcTextBox()
        Me.txtHorario = New ControlesLeafSoft.rcTextBox()
        Me.txtNombre = New ControlesLeafSoft.rcTextBox()
        Me.lblValidaDescripcion = New System.Windows.Forms.Label()
        Me.lblValidaHorario = New System.Windows.Forms.Label()
        Me.lblValidaNombre = New System.Windows.Forms.Label()
        Me.lblValidaCurso = New System.Windows.Forms.Label()
        Me.lblCursos = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblHorario = New System.Windows.Forms.Label()
        Me.pnlTituloGruos = New System.Windows.Forms.Panel()
        Me.lblTituloGrupos = New System.Windows.Forms.Label()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.gpbControles = New System.Windows.Forms.GroupBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnDeshacer = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.tlpContenedorPrincipal.SuspendLayout()
        Me.pnlContenedor.SuspendLayout()
        Me.pnlDatos.SuspendLayout()
        Me.pnlTituloGruos.SuspendLayout()
        Me.pnlMenu.SuspendLayout()
        Me.gpbControles.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpContenedorPrincipal
        '
        Me.tlpContenedorPrincipal.ColumnCount = 1
        Me.tlpContenedorPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContenedorPrincipal.Controls.Add(Me.pnlContenedor, 0, 2)
        Me.tlpContenedorPrincipal.Controls.Add(Me.pnlTituloGruos, 0, 0)
        Me.tlpContenedorPrincipal.Controls.Add(Me.pnlMenu, 0, 1)
        Me.tlpContenedorPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tlpContenedorPrincipal.Name = "tlpContenedorPrincipal"
        Me.tlpContenedorPrincipal.RowCount = 3
        Me.tlpContenedorPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.tlpContenedorPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpContenedorPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContenedorPrincipal.Size = New System.Drawing.Size(799, 430)
        Me.tlpContenedorPrincipal.TabIndex = 10
        '
        'pnlContenedor
        '
        Me.pnlContenedor.Controls.Add(Me.pnlDatos)
        Me.pnlContenedor.Location = New System.Drawing.Point(3, 106)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(793, 278)
        Me.pnlContenedor.TabIndex = 12
        '
        'pnlDatos
        '
        Me.pnlDatos.Controls.Add(Me.lblValidaCantEst)
        Me.pnlDatos.Controls.Add(Me.txtCantEstudiantes)
        Me.pnlDatos.Controls.Add(Me.lblCantidadEstudiantes)
        Me.pnlDatos.Controls.Add(Me.cboCursos)
        Me.pnlDatos.Controls.Add(Me.txtDescripcion)
        Me.pnlDatos.Controls.Add(Me.txtHorario)
        Me.pnlDatos.Controls.Add(Me.txtNombre)
        Me.pnlDatos.Controls.Add(Me.lblValidaDescripcion)
        Me.pnlDatos.Controls.Add(Me.lblValidaHorario)
        Me.pnlDatos.Controls.Add(Me.lblValidaNombre)
        Me.pnlDatos.Controls.Add(Me.lblValidaCurso)
        Me.pnlDatos.Controls.Add(Me.lblCursos)
        Me.pnlDatos.Controls.Add(Me.lblDescripcion)
        Me.pnlDatos.Controls.Add(Me.lblNombre)
        Me.pnlDatos.Controls.Add(Me.lblHorario)
        Me.pnlDatos.Location = New System.Drawing.Point(3, 3)
        Me.pnlDatos.Name = "pnlDatos"
        Me.pnlDatos.Size = New System.Drawing.Size(793, 321)
        Me.pnlDatos.TabIndex = 9
        '
        'lblValidaCantEst
        '
        Me.lblValidaCantEst.AutoSize = True
        Me.lblValidaCantEst.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValidaCantEst.Location = New System.Drawing.Point(398, 166)
        Me.lblValidaCantEst.Name = "lblValidaCantEst"
        Me.lblValidaCantEst.Size = New System.Drawing.Size(99, 13)
        Me.lblValidaCantEst.TabIndex = 33
        Me.lblValidaCantEst.Text = "*Digite Cantidad"
        '
        'txtCantEstudiantes
        '
        Me.txtCantEstudiantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantEstudiantes.Location = New System.Drawing.Point(233, 159)
        Me.txtCantEstudiantes.Name = "txtCantEstudiantes"
        Me.txtCantEstudiantes.Size = New System.Drawing.Size(121, 26)
        Me.txtCantEstudiantes.TabIndex = 32
        '
        'lblCantidadEstudiantes
        '
        Me.lblCantidadEstudiantes.AutoSize = True
        Me.lblCantidadEstudiantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadEstudiantes.Location = New System.Drawing.Point(16, 159)
        Me.lblCantidadEstudiantes.Name = "lblCantidadEstudiantes"
        Me.lblCantidadEstudiantes.Size = New System.Drawing.Size(210, 20)
        Me.lblCantidadEstudiantes.TabIndex = 31
        Me.lblCantidadEstudiantes.Text = "Cantidad de estudiantes:"
        '
        'cboCursos
        '
        Me.cboCursos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCursos.FormattingEnabled = True
        Me.cboCursos.Items.AddRange(New Object() {"Programación I", "Programación II", "Bases de Datos I", "Bases de Datos II", "Proyecto de Ing I", "Proyecto de Ing II"})
        Me.cboCursos.Location = New System.Drawing.Point(130, 12)
        Me.cboCursos.Name = "cboCursos"
        Me.cboCursos.Size = New System.Drawing.Size(121, 28)
        Me.cboCursos.TabIndex = 30
        Me.cboCursos.Text = "--Seleccione--"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(130, 113)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(253, 26)
        Me.txtDescripcion.TabIndex = 29
        '
        'txtHorario
        '
        Me.txtHorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHorario.Location = New System.Drawing.Point(130, 81)
        Me.txtHorario.Name = "txtHorario"
        Me.txtHorario.Size = New System.Drawing.Size(121, 26)
        Me.txtHorario.TabIndex = 28
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(130, 47)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(121, 26)
        Me.txtNombre.TabIndex = 27
        '
        'lblValidaDescripcion
        '
        Me.lblValidaDescripcion.AutoSize = True
        Me.lblValidaDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValidaDescripcion.Location = New System.Drawing.Point(398, 120)
        Me.lblValidaDescripcion.Name = "lblValidaDescripcion"
        Me.lblValidaDescripcion.Size = New System.Drawing.Size(116, 13)
        Me.lblValidaDescripcion.TabIndex = 26
        Me.lblValidaDescripcion.Text = "*Digite Descripción"
        '
        'lblValidaHorario
        '
        Me.lblValidaHorario.AutoSize = True
        Me.lblValidaHorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValidaHorario.Location = New System.Drawing.Point(273, 86)
        Me.lblValidaHorario.Name = "lblValidaHorario"
        Me.lblValidaHorario.Size = New System.Drawing.Size(90, 13)
        Me.lblValidaHorario.TabIndex = 21
        Me.lblValidaHorario.Text = "*Digite Horario"
        '
        'lblValidaNombre
        '
        Me.lblValidaNombre.AutoSize = True
        Me.lblValidaNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValidaNombre.Location = New System.Drawing.Point(273, 50)
        Me.lblValidaNombre.Name = "lblValidaNombre"
        Me.lblValidaNombre.Size = New System.Drawing.Size(92, 13)
        Me.lblValidaNombre.TabIndex = 20
        Me.lblValidaNombre.Text = "*Digite Nombre"
        '
        'lblValidaCurso
        '
        Me.lblValidaCurso.AutoSize = True
        Me.lblValidaCurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValidaCurso.Location = New System.Drawing.Point(273, 15)
        Me.lblValidaCurso.Name = "lblValidaCurso"
        Me.lblValidaCurso.Size = New System.Drawing.Size(111, 13)
        Me.lblValidaCurso.TabIndex = 19
        Me.lblValidaCurso.Text = "*Seleccione Curso"
        '
        'lblCursos
        '
        Me.lblCursos.AutoSize = True
        Me.lblCursos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCursos.Location = New System.Drawing.Point(16, 10)
        Me.lblCursos.Name = "lblCursos"
        Me.lblCursos.Size = New System.Drawing.Size(66, 20)
        Me.lblCursos.TabIndex = 0
        Me.lblCursos.Text = "Curso: "
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(16, 115)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(108, 20)
        Me.lblDescripcion.TabIndex = 1
        Me.lblDescripcion.Text = "Descripción:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(16, 45)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(76, 20)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre:"
        '
        'lblHorario
        '
        Me.lblHorario.AutoSize = True
        Me.lblHorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHorario.Location = New System.Drawing.Point(18, 79)
        Me.lblHorario.Name = "lblHorario"
        Me.lblHorario.Size = New System.Drawing.Size(73, 20)
        Me.lblHorario.TabIndex = 3
        Me.lblHorario.Text = "Horario:"
        '
        'pnlTituloGruos
        '
        Me.pnlTituloGruos.Controls.Add(Me.lblTituloGrupos)
        Me.pnlTituloGruos.Location = New System.Drawing.Point(3, 3)
        Me.pnlTituloGruos.Name = "pnlTituloGruos"
        Me.pnlTituloGruos.Size = New System.Drawing.Size(793, 37)
        Me.pnlTituloGruos.TabIndex = 10
        '
        'lblTituloGrupos
        '
        Me.lblTituloGrupos.AutoSize = True
        Me.lblTituloGrupos.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloGrupos.Location = New System.Drawing.Point(230, 6)
        Me.lblTituloGrupos.Name = "lblTituloGrupos"
        Me.lblTituloGrupos.Size = New System.Drawing.Size(301, 31)
        Me.lblTituloGrupos.TabIndex = 11
        Me.lblTituloGrupos.Text = "Mantenimiento grupos"
        '
        'pnlMenu
        '
        Me.pnlMenu.Controls.Add(Me.gpbControles)
        Me.pnlMenu.Location = New System.Drawing.Point(3, 46)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(793, 54)
        Me.pnlMenu.TabIndex = 11
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
        Me.gpbControles.TabIndex = 31
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
        'frmMantenimientoGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 576)
        Me.Controls.Add(Me.tlpContenedorPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMantenimientoGrupo"
        Me.Text = "frmMantenimientoGrupo"
        Me.tlpContenedorPrincipal.ResumeLayout(False)
        Me.pnlContenedor.ResumeLayout(False)
        Me.pnlDatos.ResumeLayout(False)
        Me.pnlDatos.PerformLayout()
        Me.pnlTituloGruos.ResumeLayout(False)
        Me.pnlTituloGruos.PerformLayout()
        Me.pnlMenu.ResumeLayout(False)
        Me.gpbControles.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpContenedorPrincipal As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlTituloGruos As System.Windows.Forms.Panel
    Friend WithEvents lblTituloGrupos As System.Windows.Forms.Label
    Friend WithEvents pnlMenu As System.Windows.Forms.Panel
    Friend WithEvents pnlContenedor As System.Windows.Forms.Panel
    Friend WithEvents pnlDatos As System.Windows.Forms.Panel
    Friend WithEvents lblValidaDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblValidaHorario As System.Windows.Forms.Label
    Friend WithEvents lblValidaNombre As System.Windows.Forms.Label
    Friend WithEvents lblValidaCurso As System.Windows.Forms.Label
    Friend WithEvents lblCursos As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblHorario As System.Windows.Forms.Label
    Friend WithEvents cboCursos As System.Windows.Forms.ComboBox
    Friend WithEvents txtDescripcion As ControlesLeafSoft.rcTextBox
    Friend WithEvents txtHorario As ControlesLeafSoft.rcTextBox
    Friend WithEvents txtNombre As ControlesLeafSoft.rcTextBox
    Friend WithEvents gpbControles As System.Windows.Forms.GroupBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnDeshacer As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents lblValidaCantEst As System.Windows.Forms.Label
    Friend WithEvents txtCantEstudiantes As ControlesLeafSoft.rcTextBox
    Friend WithEvents lblCantidadEstudiantes As System.Windows.Forms.Label
End Class
