<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargarCursos
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
        Me.tlpContedor = New System.Windows.Forms.TableLayoutPanel()
        Me.grdUsuarios = New System.Windows.Forms.DataGridView()
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.lblTituloMU = New System.Windows.Forms.Label()
        Me.pnlRuta = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCargarExcel = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblRuta1 = New System.Windows.Forms.Label()
        Me.txtRuta = New ControlesLeafSoft.rcTextBox()
        Me.grpCursos = New System.Windows.Forms.GroupBox()
        Me.tlpContedor.SuspendLayout()
        CType(Me.grdUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTitulo.SuspendLayout()
        Me.pnlRuta.SuspendLayout()
        Me.grpCursos.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpContedor
        '
        Me.tlpContedor.ColumnCount = 1
        Me.tlpContedor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContedor.Controls.Add(Me.grpCursos, 0, 2)
        Me.tlpContedor.Controls.Add(Me.pnlTitulo, 0, 0)
        Me.tlpContedor.Controls.Add(Me.pnlRuta, 0, 1)
        Me.tlpContedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpContedor.Location = New System.Drawing.Point(0, 0)
        Me.tlpContedor.Name = "tlpContedor"
        Me.tlpContedor.RowCount = 3
        Me.tlpContedor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.tlpContedor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.64407!))
        Me.tlpContedor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.35593!))
        Me.tlpContedor.Size = New System.Drawing.Size(794, 576)
        Me.tlpContedor.TabIndex = 0
        '
        'grdUsuarios
        '
        Me.grdUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdUsuarios.Location = New System.Drawing.Point(11, 19)
        Me.grdUsuarios.Name = "grdUsuarios"
        Me.grdUsuarios.Size = New System.Drawing.Size(765, 386)
        Me.grdUsuarios.TabIndex = 3
        '
        'pnlTitulo
        '
        Me.pnlTitulo.Controls.Add(Me.lblTituloMU)
        Me.pnlTitulo.Location = New System.Drawing.Point(3, 3)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(782, 37)
        Me.pnlTitulo.TabIndex = 0
        '
        'lblTituloMU
        '
        Me.lblTituloMU.AutoSize = True
        Me.lblTituloMU.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloMU.Location = New System.Drawing.Point(299, 6)
        Me.lblTituloMU.Name = "lblTituloMU"
        Me.lblTituloMU.Size = New System.Drawing.Size(204, 31)
        Me.lblTituloMU.TabIndex = 22
        Me.lblTituloMU.Text = "Cargar Cursos"
        '
        'pnlRuta
        '
        Me.pnlRuta.Controls.Add(Me.txtRuta)
        Me.pnlRuta.Controls.Add(Me.lblRuta1)
        Me.pnlRuta.Controls.Add(Me.btnSalir)
        Me.pnlRuta.Controls.Add(Me.btnCargarExcel)
        Me.pnlRuta.Controls.Add(Me.btnLimpiar)
        Me.pnlRuta.Controls.Add(Me.btnGuardar)
        Me.pnlRuta.Location = New System.Drawing.Point(3, 46)
        Me.pnlRuta.Name = "pnlRuta"
        Me.pnlRuta.Size = New System.Drawing.Size(782, 82)
        Me.pnlRuta.TabIndex = 1
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSalir.Location = New System.Drawing.Point(225, 45)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(84, 37)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnCargarExcel
        '
        Me.btnCargarExcel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCargarExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargarExcel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCargarExcel.Location = New System.Drawing.Point(648, 3)
        Me.btnCargarExcel.Name = "btnCargarExcel"
        Me.btnCargarExcel.Size = New System.Drawing.Size(106, 37)
        Me.btnCargarExcel.TabIndex = 7
        Me.btnCargarExcel.Text = "Cargar Excel"
        Me.btnCargarExcel.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLimpiar.Location = New System.Drawing.Point(120, 45)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(84, 37)
        Me.btnLimpiar.TabIndex = 6
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnGuardar.Location = New System.Drawing.Point(20, 45)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(84, 37)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'lblRuta1
        '
        Me.lblRuta1.AutoSize = True
        Me.lblRuta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRuta1.Location = New System.Drawing.Point(7, 7)
        Me.lblRuta1.Name = "lblRuta1"
        Me.lblRuta1.Size = New System.Drawing.Size(127, 24)
        Me.lblRuta1.TabIndex = 9
        Me.lblRuta1.Text = "Ruta Archivo: "
        '
        'txtRuta
        '
        Me.txtRuta.Enabled = False
        Me.txtRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuta.Location = New System.Drawing.Point(140, 7)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Size = New System.Drawing.Size(502, 26)
        Me.txtRuta.TabIndex = 22
        '
        'grpCursos
        '
        Me.grpCursos.Controls.Add(Me.grdUsuarios)
        Me.grpCursos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCursos.Location = New System.Drawing.Point(3, 145)
        Me.grpCursos.Name = "grpCursos"
        Me.grpCursos.Size = New System.Drawing.Size(782, 414)
        Me.grpCursos.TabIndex = 23
        Me.grpCursos.TabStop = False
        Me.grpCursos.Text = "Carga Cursos"
        '
        'frmCargarCursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 576)
        Me.Controls.Add(Me.tlpContedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmCargarCursos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga Cursos"
        Me.tlpContedor.ResumeLayout(False)
        CType(Me.grdUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        Me.pnlRuta.ResumeLayout(False)
        Me.pnlRuta.PerformLayout()
        Me.grpCursos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpContedor As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlTitulo As System.Windows.Forms.Panel
    Friend WithEvents lblTituloMU As System.Windows.Forms.Label
    Friend WithEvents pnlRuta As System.Windows.Forms.Panel
    Friend WithEvents grdUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents btnCargarExcel As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents lblRuta1 As System.Windows.Forms.Label
    Friend WithEvents grpCursos As System.Windows.Forms.GroupBox
    Friend WithEvents txtRuta As ControlesLeafSoft.rcTextBox
End Class
