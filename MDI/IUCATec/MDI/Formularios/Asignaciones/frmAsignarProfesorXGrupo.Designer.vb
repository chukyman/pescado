<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignarProfesorXGrupo
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.gprCursos = New System.Windows.Forms.GroupBox()
        Me.lblCurso = New System.Windows.Forms.Label()
        Me.cboCurso = New System.Windows.Forms.ComboBox()
        Me.btnAsignar = New System.Windows.Forms.Button()
        Me.ltsGrupos = New System.Windows.Forms.ListBox()
        Me.ltsProfesores = New System.Windows.Forms.ListBox()
        Me.tlpAsignacionesProfGrupo = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlCuerpoAsignarProfGrupo = New System.Windows.Forms.Panel()
        Me.grpAsignaciones = New System.Windows.Forms.GroupBox()
        Me.btnRemover = New System.Windows.Forms.Button()
        Me.grdAsignacionProfGrupo = New System.Windows.Forms.DataGridView()
        Me.grpGrupos = New System.Windows.Forms.GroupBox()
        Me.grpProfesores = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTituloGrupos = New System.Windows.Forms.Label()
        Me.gprCursos.SuspendLayout()
        Me.tlpAsignacionesProfGrupo.SuspendLayout()
        Me.pnlCuerpoAsignarProfGrupo.SuspendLayout()
        Me.grpAsignaciones.SuspendLayout()
        CType(Me.grdAsignacionProfGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGrupos.SuspendLayout()
        Me.grpProfesores.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSalir.Location = New System.Drawing.Point(-131, 321)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(101, 65)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'gprCursos
        '
        Me.gprCursos.Controls.Add(Me.lblCurso)
        Me.gprCursos.Controls.Add(Me.cboCurso)
        Me.gprCursos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gprCursos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gprCursos.Location = New System.Drawing.Point(15, 17)
        Me.gprCursos.Name = "gprCursos"
        Me.gprCursos.Size = New System.Drawing.Size(246, 53)
        Me.gprCursos.TabIndex = 15
        Me.gprCursos.TabStop = False
        Me.gprCursos.Text = "Listado de cursos"
        '
        'lblCurso
        '
        Me.lblCurso.AutoSize = True
        Me.lblCurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurso.Location = New System.Drawing.Point(40, 19)
        Me.lblCurso.Name = "lblCurso"
        Me.lblCurso.Size = New System.Drawing.Size(60, 24)
        Me.lblCurso.TabIndex = 4
        Me.lblCurso.Text = "Curso"
        '
        'cboCurso
        '
        Me.cboCurso.FormattingEnabled = True
        Me.cboCurso.Items.AddRange(New Object() {"Proyecto 1", "Proyecto 2", "Programacion 1 ", "Programacion 2 ", "Bases de Datos 1", "Bases de Datos 2"})
        Me.cboCurso.Location = New System.Drawing.Point(112, 19)
        Me.cboCurso.Name = "cboCurso"
        Me.cboCurso.Size = New System.Drawing.Size(121, 21)
        Me.cboCurso.TabIndex = 6
        Me.cboCurso.Text = "--Seleccione--"
        '
        'btnAsignar
        '
        Me.btnAsignar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnAsignar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsignar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAsignar.Location = New System.Drawing.Point(197, 156)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(84, 37)
        Me.btnAsignar.TabIndex = 10
        Me.btnAsignar.Text = "Asignar"
        Me.btnAsignar.UseVisualStyleBackColor = False
        '
        'ltsGrupos
        '
        Me.ltsGrupos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltsGrupos.FormattingEnabled = True
        Me.ltsGrupos.Items.AddRange(New Object() {"Diurno Martes, Jueves", "Nocturno Lunes, Miércoles"})
        Me.ltsGrupos.Location = New System.Drawing.Point(18, 19)
        Me.ltsGrupos.Name = "ltsGrupos"
        Me.ltsGrupos.Size = New System.Drawing.Size(167, 199)
        Me.ltsGrupos.TabIndex = 2
        '
        'ltsProfesores
        '
        Me.ltsProfesores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltsProfesores.FormattingEnabled = True
        Me.ltsProfesores.Items.AddRange(New Object() {"Antonio Luna", "Álvaro Cordero", "Marisol Núñez"})
        Me.ltsProfesores.Location = New System.Drawing.Point(6, 19)
        Me.ltsProfesores.Name = "ltsProfesores"
        Me.ltsProfesores.Size = New System.Drawing.Size(148, 199)
        Me.ltsProfesores.TabIndex = 1
        '
        'tlpAsignacionesProfGrupo
        '
        Me.tlpAsignacionesProfGrupo.ColumnCount = 1
        Me.tlpAsignacionesProfGrupo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpAsignacionesProfGrupo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpAsignacionesProfGrupo.Controls.Add(Me.pnlCuerpoAsignarProfGrupo, 0, 1)
        Me.tlpAsignacionesProfGrupo.Controls.Add(Me.Panel1, 0, 0)
        Me.tlpAsignacionesProfGrupo.Location = New System.Drawing.Point(2, 0)
        Me.tlpAsignacionesProfGrupo.Name = "tlpAsignacionesProfGrupo"
        Me.tlpAsignacionesProfGrupo.RowCount = 2
        Me.tlpAsignacionesProfGrupo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.tlpAsignacionesProfGrupo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpAsignacionesProfGrupo.Size = New System.Drawing.Size(796, 372)
        Me.tlpAsignacionesProfGrupo.TabIndex = 16
        '
        'pnlCuerpoAsignarProfGrupo
        '
        Me.pnlCuerpoAsignarProfGrupo.Controls.Add(Me.grpAsignaciones)
        Me.pnlCuerpoAsignarProfGrupo.Controls.Add(Me.grpGrupos)
        Me.pnlCuerpoAsignarProfGrupo.Controls.Add(Me.grpProfesores)
        Me.pnlCuerpoAsignarProfGrupo.Controls.Add(Me.btnAsignar)
        Me.pnlCuerpoAsignarProfGrupo.Controls.Add(Me.gprCursos)
        Me.pnlCuerpoAsignarProfGrupo.Location = New System.Drawing.Point(3, 46)
        Me.pnlCuerpoAsignarProfGrupo.Name = "pnlCuerpoAsignarProfGrupo"
        Me.pnlCuerpoAsignarProfGrupo.Size = New System.Drawing.Size(790, 323)
        Me.pnlCuerpoAsignarProfGrupo.TabIndex = 16
        '
        'grpAsignaciones
        '
        Me.grpAsignaciones.Controls.Add(Me.btnRemover)
        Me.grpAsignaciones.Controls.Add(Me.grdAsignacionProfGrupo)
        Me.grpAsignaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAsignaciones.Location = New System.Drawing.Point(508, 82)
        Me.grpAsignaciones.Name = "grpAsignaciones"
        Me.grpAsignaciones.Size = New System.Drawing.Size(264, 229)
        Me.grpAsignaciones.TabIndex = 19
        Me.grpAsignaciones.TabStop = False
        Me.grpAsignaciones.Text = "Asignaciones"
        '
        'btnRemover
        '
        Me.btnRemover.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnRemover.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemover.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRemover.Location = New System.Drawing.Point(94, 181)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(84, 37)
        Me.btnRemover.TabIndex = 16
        Me.btnRemover.Text = "Remover"
        Me.btnRemover.UseVisualStyleBackColor = False
        '
        'grdAsignacionProfGrupo
        '
        Me.grdAsignacionProfGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdAsignacionProfGrupo.Location = New System.Drawing.Point(15, 25)
        Me.grdAsignacionProfGrupo.Name = "grdAsignacionProfGrupo"
        Me.grdAsignacionProfGrupo.Size = New System.Drawing.Size(243, 150)
        Me.grdAsignacionProfGrupo.TabIndex = 0
        '
        'grpGrupos
        '
        Me.grpGrupos.Controls.Add(Me.ltsGrupos)
        Me.grpGrupos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpGrupos.Location = New System.Drawing.Point(297, 82)
        Me.grpGrupos.Name = "grpGrupos"
        Me.grpGrupos.Size = New System.Drawing.Size(205, 229)
        Me.grpGrupos.TabIndex = 18
        Me.grpGrupos.TabStop = False
        Me.grpGrupos.Text = "Lista de grupos"
        '
        'grpProfesores
        '
        Me.grpProfesores.Controls.Add(Me.ltsProfesores)
        Me.grpProfesores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProfesores.Location = New System.Drawing.Point(15, 82)
        Me.grpProfesores.Name = "grpProfesores"
        Me.grpProfesores.Size = New System.Drawing.Size(174, 229)
        Me.grpProfesores.TabIndex = 17
        Me.grpProfesores.TabStop = False
        Me.grpProfesores.Text = "Lista de profesores"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblTituloGrupos)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(790, 37)
        Me.Panel1.TabIndex = 18
        '
        'lblTituloGrupos
        '
        Me.lblTituloGrupos.AutoSize = True
        Me.lblTituloGrupos.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloGrupos.Location = New System.Drawing.Point(191, 0)
        Me.lblTituloGrupos.Name = "lblTituloGrupos"
        Me.lblTituloGrupos.Size = New System.Drawing.Size(386, 31)
        Me.lblTituloGrupos.TabIndex = 19
        Me.lblTituloGrupos.Text = "Asignaciones profesor grupo"
        '
        'frmAsignarProfesorXGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 560)
        Me.Controls.Add(Me.tlpAsignacionesProfGrupo)
        Me.Controls.Add(Me.btnSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmAsignarProfesorXGrupo"
        Me.Text = "Asignar profesor a grupo"
        Me.gprCursos.ResumeLayout(False)
        Me.gprCursos.PerformLayout()
        Me.tlpAsignacionesProfGrupo.ResumeLayout(False)
        Me.pnlCuerpoAsignarProfGrupo.ResumeLayout(False)
        Me.grpAsignaciones.ResumeLayout(False)
        CType(Me.grdAsignacionProfGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGrupos.ResumeLayout(False)
        Me.grpProfesores.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents gprCursos As System.Windows.Forms.GroupBox
    Friend WithEvents lblCurso As System.Windows.Forms.Label
    Friend WithEvents ltsGrupos As System.Windows.Forms.ListBox
    Friend WithEvents ltsProfesores As System.Windows.Forms.ListBox
    Friend WithEvents cboCurso As System.Windows.Forms.ComboBox
    Friend WithEvents tlpAsignacionesProfGrupo As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlCuerpoAsignarProfGrupo As System.Windows.Forms.Panel
    Friend WithEvents btnAsignar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTituloGrupos As System.Windows.Forms.Label
    Friend WithEvents btnRemover As System.Windows.Forms.Button
    Friend WithEvents grdAsignacionProfGrupo As System.Windows.Forms.DataGridView
    Friend WithEvents grpProfesores As System.Windows.Forms.GroupBox
    Friend WithEvents grpAsignaciones As System.Windows.Forms.GroupBox
    Friend WithEvents grpGrupos As System.Windows.Forms.GroupBox
End Class
