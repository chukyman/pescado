<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarCurso
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
        Me.grpBusqCursos = New System.Windows.Forms.GroupBox()
        Me.txtBuscCursoNombre = New ControlesLeafSoft.rcTextBox()
        Me.txtBuscCursoCodigo = New ControlesLeafSoft.rcTextBox()
        Me.lblNombreCurso = New System.Windows.Forms.Label()
        Me.btnBuscarCursoNombre = New System.Windows.Forms.Button()
        Me.btnBuscarCursoCodigo = New System.Windows.Forms.Button()
        Me.lblCodigoCurso = New System.Windows.Forms.Label()
        Me.lblValidaCriterioCodigo = New System.Windows.Forms.Label()
        Me.lblValidaCriterioNombre = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.grpBusqCursos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBusqCursos
        '
        Me.grpBusqCursos.Controls.Add(Me.txtBuscCursoNombre)
        Me.grpBusqCursos.Controls.Add(Me.lblValidaCriterioNombre)
        Me.grpBusqCursos.Controls.Add(Me.txtBuscCursoCodigo)
        Me.grpBusqCursos.Controls.Add(Me.lblValidaCriterioCodigo)
        Me.grpBusqCursos.Controls.Add(Me.lblNombreCurso)
        Me.grpBusqCursos.Controls.Add(Me.btnBuscarCursoNombre)
        Me.grpBusqCursos.Controls.Add(Me.btnBuscarCursoCodigo)
        Me.grpBusqCursos.Controls.Add(Me.lblCodigoCurso)
        Me.grpBusqCursos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBusqCursos.Location = New System.Drawing.Point(12, 22)
        Me.grpBusqCursos.Name = "grpBusqCursos"
        Me.grpBusqCursos.Size = New System.Drawing.Size(425, 183)
        Me.grpBusqCursos.TabIndex = 4
        Me.grpBusqCursos.TabStop = False
        Me.grpBusqCursos.Text = "Búsqueda"
        '
        'txtBuscCursoNombre
        '
        Me.txtBuscCursoNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscCursoNombre.Location = New System.Drawing.Point(87, 111)
        Me.txtBuscCursoNombre.Name = "txtBuscCursoNombre"
        Me.txtBuscCursoNombre.Size = New System.Drawing.Size(222, 26)
        Me.txtBuscCursoNombre.TabIndex = 15
        '
        'txtBuscCursoCodigo
        '
        Me.txtBuscCursoCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscCursoCodigo.Location = New System.Drawing.Point(87, 37)
        Me.txtBuscCursoCodigo.Name = "txtBuscCursoCodigo"
        Me.txtBuscCursoCodigo.Size = New System.Drawing.Size(222, 26)
        Me.txtBuscCursoCodigo.TabIndex = 16
        '
        'lblNombreCurso
        '
        Me.lblNombreCurso.AutoSize = True
        Me.lblNombreCurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCurso.Location = New System.Drawing.Point(10, 111)
        Me.lblNombreCurso.Name = "lblNombreCurso"
        Me.lblNombreCurso.Size = New System.Drawing.Size(71, 20)
        Me.lblNombreCurso.TabIndex = 8
        Me.lblNombreCurso.Text = "Nombre"
        '
        'btnBuscarCursoNombre
        '
        Me.btnBuscarCursoNombre.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnBuscarCursoNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCursoNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBuscarCursoNombre.Location = New System.Drawing.Point(87, 143)
        Me.btnBuscarCursoNombre.Name = "btnBuscarCursoNombre"
        Me.btnBuscarCursoNombre.Size = New System.Drawing.Size(84, 37)
        Me.btnBuscarCursoNombre.TabIndex = 12
        Me.btnBuscarCursoNombre.Text = "Buscar"
        Me.btnBuscarCursoNombre.UseVisualStyleBackColor = False
        '
        'btnBuscarCursoCodigo
        '
        Me.btnBuscarCursoCodigo.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnBuscarCursoCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCursoCodigo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBuscarCursoCodigo.Location = New System.Drawing.Point(87, 68)
        Me.btnBuscarCursoCodigo.Name = "btnBuscarCursoCodigo"
        Me.btnBuscarCursoCodigo.Size = New System.Drawing.Size(84, 37)
        Me.btnBuscarCursoCodigo.TabIndex = 11
        Me.btnBuscarCursoCodigo.Text = "Buscar"
        Me.btnBuscarCursoCodigo.UseVisualStyleBackColor = False
        '
        'lblCodigoCurso
        '
        Me.lblCodigoCurso.AutoSize = True
        Me.lblCodigoCurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoCurso.Location = New System.Drawing.Point(6, 35)
        Me.lblCodigoCurso.Name = "lblCodigoCurso"
        Me.lblCodigoCurso.Size = New System.Drawing.Size(65, 20)
        Me.lblCodigoCurso.TabIndex = 1
        Me.lblCodigoCurso.Text = "Código"
        '
        'lblValidaCriterioCodigo
        '
        Me.lblValidaCriterioCodigo.AutoSize = True
        Me.lblValidaCriterioCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValidaCriterioCodigo.Location = New System.Drawing.Point(315, 50)
        Me.lblValidaCriterioCodigo.Name = "lblValidaCriterioCodigo"
        Me.lblValidaCriterioCodigo.Size = New System.Drawing.Size(88, 13)
        Me.lblValidaCriterioCodigo.TabIndex = 8
        Me.lblValidaCriterioCodigo.Text = "*Digite Código"
        '
        'lblValidaCriterioNombre
        '
        Me.lblValidaCriterioNombre.AutoSize = True
        Me.lblValidaCriterioNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValidaCriterioNombre.Location = New System.Drawing.Point(315, 124)
        Me.lblValidaCriterioNombre.Name = "lblValidaCriterioNombre"
        Me.lblValidaCriterioNombre.Size = New System.Drawing.Size(92, 13)
        Me.lblValidaCriterioNombre.TabIndex = 9
        Me.lblValidaCriterioNombre.Text = "*Digite Nombre"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSalir.Location = New System.Drawing.Point(176, 357)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(84, 37)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'frmBuscarCurso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 406)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.grpBusqCursos)
        Me.Name = "frmBuscarCurso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBuscarCurso"
        Me.grpBusqCursos.ResumeLayout(False)
        Me.grpBusqCursos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpBusqCursos As System.Windows.Forms.GroupBox
    Friend WithEvents lblCodigoCurso As System.Windows.Forms.Label
    Friend WithEvents lblNombreCurso As System.Windows.Forms.Label
    Friend WithEvents lblValidaCriterioCodigo As System.Windows.Forms.Label
    Friend WithEvents lblValidaCriterioNombre As System.Windows.Forms.Label
    Friend WithEvents btnBuscarCursoCodigo As System.Windows.Forms.Button
    Friend WithEvents btnBuscarCursoNombre As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents txtBuscCursoNombre As ControlesLeafSoft.rcTextBox
    Friend WithEvents txtBuscCursoCodigo As ControlesLeafSoft.rcTextBox
End Class
