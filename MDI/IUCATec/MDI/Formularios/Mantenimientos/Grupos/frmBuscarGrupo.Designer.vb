<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarGrupo
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
        Me.lblNombreGrupo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtBuscGrupo = New ControlesLeafSoft.rcTextBox()
        Me.btnBuscarGrupo = New System.Windows.Forms.Button()
        Me.lblValidaCriterio = New System.Windows.Forms.Label()
        Me.lblListadoGrupos = New System.Windows.Forms.Label()
        Me.cboCursos = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBuscarListGrup = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNombreGrupo
        '
        Me.lblNombreGrupo.AutoSize = True
        Me.lblNombreGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreGrupo.Location = New System.Drawing.Point(6, 42)
        Me.lblNombreGrupo.Name = "lblNombreGrupo"
        Me.lblNombreGrupo.Size = New System.Drawing.Size(71, 20)
        Me.lblNombreGrupo.TabIndex = 1
        Me.lblNombreGrupo.Text = "Nombre"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtBuscGrupo)
        Me.GroupBox1.Controls.Add(Me.lblNombreGrupo)
        Me.GroupBox1.Controls.Add(Me.btnBuscarGrupo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(22, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 119)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda"
        '
        'txtBuscGrupo
        '
        Me.txtBuscGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscGrupo.Location = New System.Drawing.Point(80, 36)
        Me.txtBuscGrupo.Name = "txtBuscGrupo"
        Me.txtBuscGrupo.Size = New System.Drawing.Size(182, 26)
        Me.txtBuscGrupo.TabIndex = 7
        '
        'btnBuscarGrupo
        '
        Me.btnBuscarGrupo.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnBuscarGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarGrupo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBuscarGrupo.Location = New System.Drawing.Point(80, 76)
        Me.btnBuscarGrupo.Name = "btnBuscarGrupo"
        Me.btnBuscarGrupo.Size = New System.Drawing.Size(84, 37)
        Me.btnBuscarGrupo.TabIndex = 8
        Me.btnBuscarGrupo.Text = "Buscar"
        Me.btnBuscarGrupo.UseVisualStyleBackColor = False
        '
        'lblValidaCriterio
        '
        Me.lblValidaCriterio.AutoSize = True
        Me.lblValidaCriterio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValidaCriterio.Location = New System.Drawing.Point(324, 71)
        Me.lblValidaCriterio.Name = "lblValidaCriterio"
        Me.lblValidaCriterio.Size = New System.Drawing.Size(153, 15)
        Me.lblValidaCriterio.TabIndex = 3
        Me.lblValidaCriterio.Text = "*Debe ingresar criterio"
        '
        'lblListadoGrupos
        '
        Me.lblListadoGrupos.AutoSize = True
        Me.lblListadoGrupos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListadoGrupos.Location = New System.Drawing.Point(6, 44)
        Me.lblListadoGrupos.Name = "lblListadoGrupos"
        Me.lblListadoGrupos.Size = New System.Drawing.Size(68, 20)
        Me.lblListadoGrupos.TabIndex = 3
        Me.lblListadoGrupos.Text = "Grupos"
        '
        'cboCursos
        '
        Me.cboCursos.FormattingEnabled = True
        Me.cboCursos.Items.AddRange(New Object() {"Día Martes Jueves- Programación I", "Noche Lunes Miércoles- Programación I", "Noche Lunes Miércoles Jueves- Proyecto de Ing II"})
        Me.cboCursos.Location = New System.Drawing.Point(80, 43)
        Me.cboCursos.Name = "cboCursos"
        Me.cboCursos.Size = New System.Drawing.Size(239, 23)
        Me.cboCursos.TabIndex = 4
        Me.cboCursos.Text = "--Seleccione--"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBuscarListGrup)
        Me.GroupBox2.Controls.Add(Me.lblListadoGrupos)
        Me.GroupBox2.Controls.Add(Me.cboCursos)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(22, 201)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(335, 123)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Búsqueda"
        '
        'btnBuscarListGrup
        '
        Me.btnBuscarListGrup.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnBuscarListGrup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarListGrup.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBuscarListGrup.Location = New System.Drawing.Point(80, 72)
        Me.btnBuscarListGrup.Name = "btnBuscarListGrup"
        Me.btnBuscarListGrup.Size = New System.Drawing.Size(84, 37)
        Me.btnBuscarListGrup.TabIndex = 9
        Me.btnBuscarListGrup.Text = "Buscar"
        Me.btnBuscarListGrup.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSalir.Location = New System.Drawing.Point(200, 337)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(84, 37)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'frmBuscarGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 386)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblValidaCriterio)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "frmBuscarGrupo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombreGrupo As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblListadoGrupos As System.Windows.Forms.Label
    Friend WithEvents cboCursos As System.Windows.Forms.ComboBox
    Friend WithEvents lblValidaCriterio As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBuscGrupo As ControlesLeafSoft.rcTextBox
    Friend WithEvents btnBuscarGrupo As System.Windows.Forms.Button
    Friend WithEvents btnBuscarListGrup As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
End Class
