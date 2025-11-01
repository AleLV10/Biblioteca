<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuprin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menuprin))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LECTORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INSERTARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ELIMINARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MODIFICARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTAGENERALToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIBROToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INSERTARToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ELIMINARToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MODIFICARToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTARToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTAGENERALToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRESTAMOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INSERTARToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MODIFICARToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTAGENERALToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LECTORToolStripMenuItem, Me.LIBROToolStripMenuItem, Me.PRESTAMOToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 84)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(523, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LECTORToolStripMenuItem
        '
        Me.LECTORToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.LECTORToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.LECTORToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.INSERTARToolStripMenuItem, Me.ELIMINARToolStripMenuItem, Me.MODIFICARToolStripMenuItem, Me.CONSULTARToolStripMenuItem, Me.CONSULTAGENERALToolStripMenuItem})
        Me.LECTORToolStripMenuItem.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LECTORToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LECTORToolStripMenuItem.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.LECTORToolStripMenuItem.Name = "LECTORToolStripMenuItem"
        Me.LECTORToolStripMenuItem.Padding = New System.Windows.Forms.Padding(14, 0, 14, 0)
        Me.LECTORToolStripMenuItem.Size = New System.Drawing.Size(105, 26)
        Me.LECTORToolStripMenuItem.Text = "LECTOR"
        '
        'INSERTARToolStripMenuItem
        '
        Me.INSERTARToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.INSERTARToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.INSERTARToolStripMenuItem.Name = "INSERTARToolStripMenuItem"
        Me.INSERTARToolStripMenuItem.Size = New System.Drawing.Size(252, 26)
        Me.INSERTARToolStripMenuItem.Text = "INSERTAR"
        '
        'ELIMINARToolStripMenuItem
        '
        Me.ELIMINARToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.ELIMINARToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ELIMINARToolStripMenuItem.Name = "ELIMINARToolStripMenuItem"
        Me.ELIMINARToolStripMenuItem.Size = New System.Drawing.Size(252, 26)
        Me.ELIMINARToolStripMenuItem.Text = "ELIMINAR"
        '
        'MODIFICARToolStripMenuItem
        '
        Me.MODIFICARToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.MODIFICARToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.MODIFICARToolStripMenuItem.Name = "MODIFICARToolStripMenuItem"
        Me.MODIFICARToolStripMenuItem.Size = New System.Drawing.Size(252, 26)
        Me.MODIFICARToolStripMenuItem.Text = "MODIFICAR"
        '
        'CONSULTARToolStripMenuItem
        '
        Me.CONSULTARToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.CONSULTARToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.CONSULTARToolStripMenuItem.Name = "CONSULTARToolStripMenuItem"
        Me.CONSULTARToolStripMenuItem.Size = New System.Drawing.Size(252, 26)
        Me.CONSULTARToolStripMenuItem.Text = "CONSULTAR"
        '
        'CONSULTAGENERALToolStripMenuItem
        '
        Me.CONSULTAGENERALToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.CONSULTAGENERALToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.CONSULTAGENERALToolStripMenuItem.Name = "CONSULTAGENERALToolStripMenuItem"
        Me.CONSULTAGENERALToolStripMenuItem.Size = New System.Drawing.Size(252, 26)
        Me.CONSULTAGENERALToolStripMenuItem.Text = "CONSULTA GENERAL"
        '
        'LIBROToolStripMenuItem
        '
        Me.LIBROToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.LIBROToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.INSERTARToolStripMenuItem1, Me.ELIMINARToolStripMenuItem1, Me.MODIFICARToolStripMenuItem1, Me.CONSULTARToolStripMenuItem1, Me.CONSULTAGENERALToolStripMenuItem1})
        Me.LIBROToolStripMenuItem.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LIBROToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LIBROToolStripMenuItem.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.LIBROToolStripMenuItem.Name = "LIBROToolStripMenuItem"
        Me.LIBROToolStripMenuItem.Padding = New System.Windows.Forms.Padding(14, 0, 14, 0)
        Me.LIBROToolStripMenuItem.Size = New System.Drawing.Size(91, 26)
        Me.LIBROToolStripMenuItem.Text = "LIBRO"
        '
        'INSERTARToolStripMenuItem1
        '
        Me.INSERTARToolStripMenuItem1.BackColor = System.Drawing.Color.Silver
        Me.INSERTARToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.INSERTARToolStripMenuItem1.Name = "INSERTARToolStripMenuItem1"
        Me.INSERTARToolStripMenuItem1.Size = New System.Drawing.Size(252, 26)
        Me.INSERTARToolStripMenuItem1.Text = "INSERTAR"
        '
        'ELIMINARToolStripMenuItem1
        '
        Me.ELIMINARToolStripMenuItem1.BackColor = System.Drawing.Color.Silver
        Me.ELIMINARToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.ELIMINARToolStripMenuItem1.Name = "ELIMINARToolStripMenuItem1"
        Me.ELIMINARToolStripMenuItem1.Size = New System.Drawing.Size(252, 26)
        Me.ELIMINARToolStripMenuItem1.Text = "ELIMINAR"
        '
        'MODIFICARToolStripMenuItem1
        '
        Me.MODIFICARToolStripMenuItem1.BackColor = System.Drawing.Color.Silver
        Me.MODIFICARToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.MODIFICARToolStripMenuItem1.Name = "MODIFICARToolStripMenuItem1"
        Me.MODIFICARToolStripMenuItem1.Size = New System.Drawing.Size(252, 26)
        Me.MODIFICARToolStripMenuItem1.Text = "MODIFICAR"
        '
        'CONSULTARToolStripMenuItem1
        '
        Me.CONSULTARToolStripMenuItem1.BackColor = System.Drawing.Color.Silver
        Me.CONSULTARToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.CONSULTARToolStripMenuItem1.Name = "CONSULTARToolStripMenuItem1"
        Me.CONSULTARToolStripMenuItem1.Size = New System.Drawing.Size(252, 26)
        Me.CONSULTARToolStripMenuItem1.Text = "CONSULTAR"
        '
        'CONSULTAGENERALToolStripMenuItem1
        '
        Me.CONSULTAGENERALToolStripMenuItem1.BackColor = System.Drawing.Color.Silver
        Me.CONSULTAGENERALToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.CONSULTAGENERALToolStripMenuItem1.Name = "CONSULTAGENERALToolStripMenuItem1"
        Me.CONSULTAGENERALToolStripMenuItem1.Size = New System.Drawing.Size(252, 26)
        Me.CONSULTAGENERALToolStripMenuItem1.Text = "CONSULTA GENERAL"
        '
        'PRESTAMOToolStripMenuItem
        '
        Me.PRESTAMOToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.PRESTAMOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.INSERTARToolStripMenuItem2, Me.MODIFICARToolStripMenuItem2, Me.CONSULTAGENERALToolStripMenuItem2})
        Me.PRESTAMOToolStripMenuItem.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRESTAMOToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.PRESTAMOToolStripMenuItem.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.PRESTAMOToolStripMenuItem.Name = "PRESTAMOToolStripMenuItem"
        Me.PRESTAMOToolStripMenuItem.Padding = New System.Windows.Forms.Padding(14, 0, 14, 0)
        Me.PRESTAMOToolStripMenuItem.Size = New System.Drawing.Size(134, 26)
        Me.PRESTAMOToolStripMenuItem.Text = "PRÉSTAMO"
        '
        'INSERTARToolStripMenuItem2
        '
        Me.INSERTARToolStripMenuItem2.BackColor = System.Drawing.Color.Silver
        Me.INSERTARToolStripMenuItem2.ForeColor = System.Drawing.Color.Black
        Me.INSERTARToolStripMenuItem2.Name = "INSERTARToolStripMenuItem2"
        Me.INSERTARToolStripMenuItem2.Size = New System.Drawing.Size(252, 26)
        Me.INSERTARToolStripMenuItem2.Text = "INSERTAR"
        '
        'MODIFICARToolStripMenuItem2
        '
        Me.MODIFICARToolStripMenuItem2.BackColor = System.Drawing.Color.Silver
        Me.MODIFICARToolStripMenuItem2.ForeColor = System.Drawing.Color.Black
        Me.MODIFICARToolStripMenuItem2.Name = "MODIFICARToolStripMenuItem2"
        Me.MODIFICARToolStripMenuItem2.Size = New System.Drawing.Size(252, 26)
        Me.MODIFICARToolStripMenuItem2.Text = "CONSULTAR"
        '
        'CONSULTAGENERALToolStripMenuItem2
        '
        Me.CONSULTAGENERALToolStripMenuItem2.BackColor = System.Drawing.Color.Silver
        Me.CONSULTAGENERALToolStripMenuItem2.ForeColor = System.Drawing.Color.Black
        Me.CONSULTAGENERALToolStripMenuItem2.Name = "CONSULTAGENERALToolStripMenuItem2"
        Me.CONSULTAGENERALToolStripMenuItem2.Size = New System.Drawing.Size(252, 26)
        Me.CONSULTAGENERALToolStripMenuItem2.Text = "CONSULTA GENERAL"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.SALIRToolStripMenuItem.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SALIRToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SALIRToolStripMenuItem.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Padding = New System.Windows.Forms.Padding(14, 0, 14, 0)
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(173, 26)
        Me.SALIRToolStripMenuItem.Text = "CERRAR SESIÓN"
        '
        'menuprin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Biblioteca.My.Resources.Resources.MenuPrin1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(809, 453)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "menuprin"
        Me.Text = "Menú Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LECTORToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents INSERTARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ELIMINARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MODIFICARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONSULTARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONSULTAGENERALToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIBROToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents INSERTARToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ELIMINARToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MODIFICARToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CONSULTARToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CONSULTAGENERALToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PRESTAMOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents INSERTARToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents MODIFICARToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONSULTAGENERALToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
