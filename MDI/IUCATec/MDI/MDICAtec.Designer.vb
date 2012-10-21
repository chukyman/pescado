<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDICAtec
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDICAtec))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.tspSesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.tspIniciarSesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.tspSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.tspPermisos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tspRoles = New System.Windows.Forms.ToolStripMenuItem()
        Me.tspMantenimientoPermisos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tspCambiarContraseña = New System.Windows.Forms.ToolStripMenuItem()
        Me.tspMantenimiento = New System.Windows.Forms.ToolStripMenuItem()
        Me.tspUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.tspCursos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tspGrupos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tspCarreras = New System.Windows.Forms.ToolStripMenuItem()
        Me.tspAsignaciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.tspProfesorAGrupo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tspEstudianteACarrera = New System.Windows.Forms.ToolStripMenuItem()
        Me.tspEstudianteAGrupo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tspDirectorAcadémicoACarrera = New System.Windows.Forms.ToolStripMenuItem()
        Me.tspEstudianteAForo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tspReportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarCarrerasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarDirectoresAcademicosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tspAyuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.MediumTurquoise
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tspSesion, Me.tspPermisos, Me.tspMantenimiento, Me.tspAsignaciones, Me.tspReportes, Me.tspAyuda})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(784, 33)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'tspSesion
        '
        Me.tspSesion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tspIniciarSesion, Me.tspSalir})
        Me.tspSesion.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tspSesion.Name = "tspSesion"
        Me.tspSesion.Size = New System.Drawing.Size(79, 29)
        Me.tspSesion.Text = "Sesión"
        '
        'tspIniciarSesion
        '
        Me.tspIniciarSesion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tspIniciarSesion.Name = "tspIniciarSesion"
        Me.tspIniciarSesion.Size = New System.Drawing.Size(295, 26)
        Me.tspIniciarSesion.Text = "Iniciar sesión / Cerrar sesión"
        '
        'tspSalir
        '
        Me.tspSalir.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tspSalir.Name = "tspSalir"
        Me.tspSalir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.tspSalir.Size = New System.Drawing.Size(295, 26)
        Me.tspSalir.Text = "Salir"
        '
        'tspPermisos
        '
        Me.tspPermisos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tspRoles, Me.tspMantenimientoPermisos, Me.tspCambiarContraseña})
        Me.tspPermisos.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tspPermisos.Name = "tspPermisos"
        Me.tspPermisos.Size = New System.Drawing.Size(100, 29)
        Me.tspPermisos.Text = "Permisos"
        '
        'tspRoles
        '
        Me.tspRoles.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tspRoles.Name = "tspRoles"
        Me.tspRoles.Size = New System.Drawing.Size(256, 26)
        Me.tspRoles.Text = "Roles"
        '
        'tspMantenimientoPermisos
        '
        Me.tspMantenimientoPermisos.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tspMantenimientoPermisos.Name = "tspMantenimientoPermisos"
        Me.tspMantenimientoPermisos.Size = New System.Drawing.Size(256, 26)
        Me.tspMantenimientoPermisos.Text = "Mantenimiento permisos"
        '
        'tspCambiarContraseña
        '
        Me.tspCambiarContraseña.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tspCambiarContraseña.Name = "tspCambiarContraseña"
        Me.tspCambiarContraseña.Size = New System.Drawing.Size(256, 26)
        Me.tspCambiarContraseña.Text = "Cambiar contraseña"
        '
        'tspMantenimiento
        '
        Me.tspMantenimiento.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tspUsuarios, Me.tspCursos, Me.tspGrupos, Me.tspCarreras})
        Me.tspMantenimiento.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tspMantenimiento.Name = "tspMantenimiento"
        Me.tspMantenimiento.Size = New System.Drawing.Size(161, 29)
        Me.tspMantenimiento.Text = "Mantenimientos"
        '
        'tspUsuarios
        '
        Me.tspUsuarios.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tspUsuarios.Name = "tspUsuarios"
        Me.tspUsuarios.Size = New System.Drawing.Size(152, 26)
        Me.tspUsuarios.Text = "Usuarios"
        '
        'tspCursos
        '
        Me.tspCursos.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tspCursos.Name = "tspCursos"
        Me.tspCursos.Size = New System.Drawing.Size(152, 26)
        Me.tspCursos.Text = "Cursos"
        '
        'tspGrupos
        '
        Me.tspGrupos.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tspGrupos.Name = "tspGrupos"
        Me.tspGrupos.Size = New System.Drawing.Size(152, 26)
        Me.tspGrupos.Text = "Grupos"
        '
        'tspCarreras
        '
        Me.tspCarreras.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tspCarreras.Name = "tspCarreras"
        Me.tspCarreras.Size = New System.Drawing.Size(152, 26)
        Me.tspCarreras.Text = "Carreras"
        '
        'tspAsignaciones
        '
        Me.tspAsignaciones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tspProfesorAGrupo, Me.tspEstudianteACarrera, Me.tspEstudianteAGrupo, Me.tspDirectorAcadémicoACarrera, Me.tspEstudianteAForo})
        Me.tspAsignaciones.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tspAsignaciones.Name = "tspAsignaciones"
        Me.tspAsignaciones.Size = New System.Drawing.Size(169, 29)
        Me.tspAsignaciones.Text = "Asignar/Remover"
        '
        'tspProfesorAGrupo
        '
        Me.tspProfesorAGrupo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tspProfesorAGrupo.Name = "tspProfesorAGrupo"
        Me.tspProfesorAGrupo.Size = New System.Drawing.Size(281, 26)
        Me.tspProfesorAGrupo.Text = "Profesor a grupo"
        '
        'tspEstudianteACarrera
        '
        Me.tspEstudianteACarrera.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tspEstudianteACarrera.Name = "tspEstudianteACarrera"
        Me.tspEstudianteACarrera.Size = New System.Drawing.Size(281, 26)
        Me.tspEstudianteACarrera.Text = "Estudiante a carrera"
        '
        'tspEstudianteAGrupo
        '
        Me.tspEstudianteAGrupo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tspEstudianteAGrupo.Name = "tspEstudianteAGrupo"
        Me.tspEstudianteAGrupo.Size = New System.Drawing.Size(281, 26)
        Me.tspEstudianteAGrupo.Text = "Estudiante a grupo"
        '
        'tspDirectorAcadémicoACarrera
        '
        Me.tspDirectorAcadémicoACarrera.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tspDirectorAcadémicoACarrera.Name = "tspDirectorAcadémicoACarrera"
        Me.tspDirectorAcadémicoACarrera.Size = New System.Drawing.Size(281, 26)
        Me.tspDirectorAcadémicoACarrera.Text = "Director académico a carrera"
        '
        'tspEstudianteAForo
        '
        Me.tspEstudianteAForo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tspEstudianteAForo.Name = "tspEstudianteAForo"
        Me.tspEstudianteAForo.Size = New System.Drawing.Size(281, 26)
        Me.tspEstudianteAForo.Text = "Estudiante a foro"
        '
        'tspReportes
        '
        Me.tspReportes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListarCarrerasToolStripMenuItem, Me.ListarDirectoresAcademicosToolStripMenuItem})
        Me.tspReportes.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tspReportes.Name = "tspReportes"
        Me.tspReportes.Size = New System.Drawing.Size(98, 29)
        Me.tspReportes.Text = "Reportes"
        '
        'ListarCarrerasToolStripMenuItem
        '
        Me.ListarCarrerasToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.25!)
        Me.ListarCarrerasToolStripMenuItem.Name = "ListarCarrerasToolStripMenuItem"
        Me.ListarCarrerasToolStripMenuItem.Size = New System.Drawing.Size(326, 30)
        Me.ListarCarrerasToolStripMenuItem.Text = "Listar Carreras"
        '
        'ListarDirectoresAcademicosToolStripMenuItem
        '
        Me.ListarDirectoresAcademicosToolStripMenuItem.Name = "ListarDirectoresAcademicosToolStripMenuItem"
        Me.ListarDirectoresAcademicosToolStripMenuItem.Size = New System.Drawing.Size(326, 30)
        Me.ListarDirectoresAcademicosToolStripMenuItem.Text = "Listar Directores Academicos"
        '
        'tspAyuda
        '
        Me.tspAyuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ToolStripSeparator8, Me.SearchToolStripMenuItem, Me.IndexToolStripMenuItem, Me.ContentsToolStripMenuItem})
        Me.tspAyuda.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tspAyuda.Name = "tspAyuda"
        Me.tspAyuda.Size = New System.Drawing.Size(77, 29)
        Me.tspAyuda.Text = "Ay&uda"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(217, 26)
        Me.AboutToolStripMenuItem.Text = "&Acerca de..."
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(214, 6)
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchToolStripMenuItem.Image = CType(resources.GetObject("SearchToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SearchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(217, 26)
        Me.SearchToolStripMenuItem.Text = "&Buscar"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IndexToolStripMenuItem.Image = CType(resources.GetObject("IndexToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IndexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(217, 26)
        Me.IndexToolStripMenuItem.Text = "&Índice"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(217, 26)
        Me.ContentsToolStripMenuItem.Text = "&Contenido"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 540)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'MDICAtec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDICAtec"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CAtec"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tspAyuda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents tspMantenimiento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tspSesion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tspIniciarSesion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tspSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tspUsuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tspCursos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tspCarreras As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tspGrupos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tspPermisos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tspAsignaciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tspReportes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tspRoles As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tspMantenimientoPermisos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tspProfesorAGrupo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tspEstudianteAGrupo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tspDirectorAcadémicoACarrera As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tspCambiarContraseña As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tspEstudianteACarrera As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tspEstudianteAForo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListarCarrerasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListarDirectoresAcademicosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
