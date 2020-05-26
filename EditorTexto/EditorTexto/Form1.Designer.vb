<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.rchTxtBox = New System.Windows.Forms.RichTextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.opcionNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarComoToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.guardarMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarComoMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton3 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.CortarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.MnuFuente = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorFondoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorTextoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAcercaDe = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rchTxtBox
        '
        Me.rchTxtBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rchTxtBox.Location = New System.Drawing.Point(0, 25)
        Me.rchTxtBox.Name = "rchTxtBox"
        Me.rchTxtBox.Size = New System.Drawing.Size(705, 388)
        Me.rchTxtBox.TabIndex = 0
        Me.rchTxtBox.Text = ""
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripDropDownButton3, Me.ToolStripDropDownButton2, Me.btnAcercaDe})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(705, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.opcionNuevo, Me.AbrirToolStripMenuItem, Me.GuardarComoToolStripMenuItem, Me.guardarMnu, Me.GuardarComoMnu, Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem1})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(61, 22)
        Me.ToolStripDropDownButton1.Text = "Archivo"
        '
        'opcionNuevo
        '
        Me.opcionNuevo.Name = "opcionNuevo"
        Me.opcionNuevo.Size = New System.Drawing.Size(150, 22)
        Me.opcionNuevo.Text = "Nuevo"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.AbrirToolStripMenuItem.Text = "Abrir"
        '
        'GuardarComoToolStripMenuItem
        '
        Me.GuardarComoToolStripMenuItem.Name = "GuardarComoToolStripMenuItem"
        Me.GuardarComoToolStripMenuItem.Size = New System.Drawing.Size(147, 6)
        '
        'guardarMnu
        '
        Me.guardarMnu.Name = "guardarMnu"
        Me.guardarMnu.Size = New System.Drawing.Size(150, 22)
        Me.guardarMnu.Text = "Guardar"
        '
        'GuardarComoMnu
        '
        Me.GuardarComoMnu.Name = "GuardarComoMnu"
        Me.GuardarComoMnu.Size = New System.Drawing.Size(150, 22)
        Me.GuardarComoMnu.Text = "Guardar como"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(147, 6)
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(150, 22)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'ToolStripDropDownButton3
        '
        Me.ToolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CortarToolStripMenuItem, Me.CopiarToolStripMenuItem, Me.PegarToolStripMenuItem})
        Me.ToolStripDropDownButton3.Image = CType(resources.GetObject("ToolStripDropDownButton3.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton3.Name = "ToolStripDropDownButton3"
        Me.ToolStripDropDownButton3.Size = New System.Drawing.Size(59, 22)
        Me.ToolStripDropDownButton3.Text = "Edición"
        '
        'CortarToolStripMenuItem
        '
        Me.CortarToolStripMenuItem.Name = "CortarToolStripMenuItem"
        Me.CortarToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.CortarToolStripMenuItem.Text = "Cortar"
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.CopiarToolStripMenuItem.Text = "Copiar"
        '
        'PegarToolStripMenuItem
        '
        Me.PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
        Me.PegarToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.PegarToolStripMenuItem.Text = "Pegar"
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuFuente, Me.ColorFondoToolStripMenuItem, Me.ColorTextoToolStripMenuItem})
        Me.ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(48, 22)
        Me.ToolStripDropDownButton2.Text = "Estilo"
        '
        'MnuFuente
        '
        Me.MnuFuente.Name = "MnuFuente"
        Me.MnuFuente.Size = New System.Drawing.Size(149, 22)
        Me.MnuFuente.Text = "Fuente..."
        '
        'ColorFondoToolStripMenuItem
        '
        Me.ColorFondoToolStripMenuItem.Name = "ColorFondoToolStripMenuItem"
        Me.ColorFondoToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.ColorFondoToolStripMenuItem.Text = "Color Fondo..."
        '
        'ColorTextoToolStripMenuItem
        '
        Me.ColorTextoToolStripMenuItem.Name = "ColorTextoToolStripMenuItem"
        Me.ColorTextoToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.ColorTextoToolStripMenuItem.Text = "Color Texto..."
        '
        'btnAcercaDe
        '
        Me.btnAcercaDe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAcercaDe.Image = CType(resources.GetObject("btnAcercaDe.Image"), System.Drawing.Image)
        Me.btnAcercaDe.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAcercaDe.Name = "btnAcercaDe"
        Me.btnAcercaDe.Size = New System.Drawing.Size(72, 22)
        Me.btnAcercaDe.Text = "Acerca de..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 413)
        Me.Controls.Add(Me.rchTxtBox)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rchTxtBox As System.Windows.Forms.RichTextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStripDropDownButton2 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStripDropDownButton3 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents opcionNuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarComoToolStripMenuItem As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents guardarMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarComoMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuFuente As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorFondoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorTextoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CortarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PegarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAcercaDe As System.Windows.Forms.ToolStripButton

End Class
