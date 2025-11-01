<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MSGError
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MSGError))
        Me.msj = New System.Windows.Forms.Label()
        Me.ok = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'msj
        '
        Me.msj.AutoSize = True
        Me.msj.BackColor = System.Drawing.Color.Transparent
        Me.msj.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msj.Location = New System.Drawing.Point(153, 24)
        Me.msj.Name = "msj"
        Me.msj.Size = New System.Drawing.Size(0, 22)
        Me.msj.TabIndex = 0
        '
        'ok
        '
        Me.ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.ok.Cursor = System.Windows.Forms.Cursors.Default
        Me.ok.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ok.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ok.Location = New System.Drawing.Point(320, 95)
        Me.ok.Name = "ok"
        Me.ok.Size = New System.Drawing.Size(59, 30)
        Me.ok.TabIndex = 6
        Me.ok.Text = "OK"
        Me.ok.UseVisualStyleBackColor = False
        '
        'MSGError
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Biblioteca.My.Resources.Resources.msj
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(390, 138)
        Me.Controls.Add(Me.ok)
        Me.Controls.Add(Me.msj)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MSGError"
        Me.Text = "Error"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents msj As Label
    Friend WithEvents ok As Button
End Class
