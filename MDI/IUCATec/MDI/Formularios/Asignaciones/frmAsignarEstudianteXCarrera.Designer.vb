<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignarEstudianteXCarrera
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTituloAsignacion = New System.Windows.Forms.Label()
        Me.grpAsignaciones = New System.Windows.Forms.GroupBox()
        Me.btnRemover = New System.Windows.Forms.Button()
        Me.grdAsignacionProfGrupo = New System.Windows.Forms.DataGridView()
        Me.grpGrupos = New System.Windows.Forms.GroupBox()
        Me.ltsCarreras = New System.Windows.Forms.ListBox()
        Me.grpProfesores = New System.Windows.Forms.GroupBox()
        Me.ltsEstudiantes = New System.Windows.Forms.ListBox()
        Me.pnlCuerpoAsignarProfGrupo = New System.Windows.Forms.Panel()
        Me.btnAsignar = New System.Windows.Forms.Button()
        Me.tlpAsignacionesProfGrupo = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.grpAsignaciones.SuspendLayout()
        CType(Me.grdAsignacionProfGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGrupos.SuspendLayout()
        Me.grpProfesores.SuspendLayout()
        Me.pnlCuerpoAsignarProfGrupo.SuspendLayout()
        Me.tlpAsignacionesProfGrupo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblTituloAsignacion)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(790, 37)
        Me.Panel1.TabIndex = 18
        '
        'lblTituloAsignacion
        '
        Me.lblTituloAsignacion.AutoSize = True
        Me.lblTituloAsignacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloAsignacion.Location = New System.Drawing.Point(191, 0)
        Me.lblTituloAsignacion.Name = "lblTituloAsignacion"
        Me.lblTituloAsignacion.Size = New System.Drawing.Size(385, 31)
        Me.lblTituloAsignacion.TabIndex = 19
        Me.lblTituloAsignacion.Text = "Asignar carrera a Estudiante"
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
        Me.grpGrupos.Controls.Add(Me.ltsCarreras)
        Me.grpGrupos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpGrupos.Location = New System.Drawing.Point(297, 82)
        Me.grpGrupos.Name = "grpGrupos"
        Me.grpGrupos.Size = New System.Drawing.Size(205, 229)
        Me.grpGrupos.TabIndex = 18
        Me.grpGrupos.TabStop = False
        Me.grpGrupos.Text = "Lista de Carrera"
        '
        'ltsCarreras
        '
        Me.ltsCarreras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltsCarreras.FormattingEnabled = True
        Me.ltsCarreras.Items.AddRange(New Object() {"Desarrollo Web", "Telematica", "Desarrollo de Software", "Tecnologias de la Informacion", "Soporte Tecnico", "Ingles"})
        Me.ltsCarreras.Location = New System.Drawing.Point(18, 19)
        Me.ltsCarreras.Name = "ltsCarreras"
        Me.ltsCarreras.Size = New System.Drawing.Size(167, 199)
        Me.ltsCarreras.TabIndex = 2
        '
        'grpProfesores
        '
        Me.grpProfesores.Controls.Add(Me.ltsEstudiantes)
        Me.grpProfesores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProfesores.Location = New System.Drawing.Point(15, 82)
        Me.grpProfesores.Name = "grpProfesores"
        Me.grpProfesores.Size = New System.Drawing.Size(174, 229)
        Me.grpProfesores.TabIndex = 17
        Me.grpProfesores.TabStop = False
        Me.grpProfesores.Text = "Lista de estudiantes"
        '
        'ltsEstudiantes
        '
        Me.ltsEstudiantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltsEstudiantes.FormattingEnabled = True
        Me.ltsEstudiantes.Items.AddRange(New Object() {"Luis  Chanto Carvajal", "José  Jiménez Méndez", "Carlos Rodó Ortuño", "Casimiro Medrano Abellán", "Carlos Mora Bonilla", "Óscar Cantillo", " Mezerville Cantillos", "Francisco Medrano Abellán", "Familia Altman Echeverría", "Federico Macaya Bolaños", "Luis  Abellán Acevedo", "Anabella Díez Martín", "Óscar Cadet Fernández", "Roberto Massuh", "Víctor Gómez Artavia", "Alejandro Madrigal Benavides", "Guillermo Zúñiga Trejos", "Jorge Rodríguez Araya", "Jorge Johanning Mora", "Arlene Lutz Vargas"})
        Me.ltsEstudiantes.Location = New System.Drawing.Point(6, 19)
        Me.ltsEstudiantes.Name = "ltsEstudiantes"
        Me.ltsEstudiantes.Size = New System.Drawing.Size(148, 199)
        Me.ltsEstudiantes.TabIndex = 1
        '
        'pnlCuerpoAsignarProfGrupo
        '
        Me.pnlCuerpoAsignarProfGrupo.Controls.Add(Me.grpAsignaciones)
        Me.pnlCuerpoAsignarProfGrupo.Controls.Add(Me.grpGrupos)
        Me.pnlCuerpoAsignarProfGrupo.Controls.Add(Me.grpProfesores)
        Me.pnlCuerpoAsignarProfGrupo.Controls.Add(Me.btnAsignar)
        Me.pnlCuerpoAsignarProfGrupo.Location = New System.Drawing.Point(3, 46)
        Me.pnlCuerpoAsignarProfGrupo.Name = "pnlCuerpoAsignarProfGrupo"
        Me.pnlCuerpoAsignarProfGrupo.Size = New System.Drawing.Size(790, 323)
        Me.pnlCuerpoAsignarProfGrupo.TabIndex = 16
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
        'tlpAsignacionesProfGrupo
        '
        Me.tlpAsignacionesProfGrupo.ColumnCount = 1
        Me.tlpAsignacionesProfGrupo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpAsignacionesProfGrupo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpAsignacionesProfGrupo.Controls.Add(Me.pnlCuerpoAsignarProfGrupo, 0, 1)
        Me.tlpAsignacionesProfGrupo.Controls.Add(Me.Panel1, 0, 0)
        Me.tlpAsignacionesProfGrupo.Location = New System.Drawing.Point(0, 1)
        Me.tlpAsignacionesProfGrupo.Name = "tlpAsignacionesProfGrupo"
        Me.tlpAsignacionesProfGrupo.RowCount = 2
        Me.tlpAsignacionesProfGrupo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.tlpAsignacionesProfGrupo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpAsignacionesProfGrupo.Size = New System.Drawing.Size(796, 372)
        Me.tlpAsignacionesProfGrupo.TabIndex = 18
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSalir.Location = New System.Drawing.Point(-133, 322)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(101, 65)
        Me.btnSalir.TabIndex = 17
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'frmAsignarEstudianteXCarrera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 546)
        Me.Controls.Add(Me.tlpAsignacionesProfGrupo)
        Me.Controls.Add(Me.btnSalir)
        Me.Name = "frmAsignarEstudianteXCarrera"
        Me.Text = "frmAsignarEstudianteXCarrera"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grpAsignaciones.ResumeLayout(False)
        CType(Me.grdAsignacionProfGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGrupos.ResumeLayout(False)
        Me.grpProfesores.ResumeLayout(False)
        Me.pnlCuerpoAsignarProfGrupo.ResumeLayout(False)
        Me.tlpAsignacionesProfGrupo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTituloAsignacion As System.Windows.Forms.Label
    Friend WithEvents grpAsignaciones As System.Windows.Forms.GroupBox
    Friend WithEvents btnRemover As System.Windows.Forms.Button
    Friend WithEvents grdAsignacionProfGrupo As System.Windows.Forms.DataGridView
    Friend WithEvents grpGrupos As System.Windows.Forms.GroupBox
    Friend WithEvents ltsCarreras As System.Windows.Forms.ListBox
    Friend WithEvents grpProfesores As System.Windows.Forms.GroupBox
    Friend WithEvents ltsEstudiantes As System.Windows.Forms.ListBox
    Friend WithEvents pnlCuerpoAsignarProfGrupo As System.Windows.Forms.Panel
    Friend WithEvents btnAsignar As System.Windows.Forms.Button
    Friend WithEvents tlpAsignacionesProfGrupo As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnSalir As System.Windows.Forms.Button
End Class
