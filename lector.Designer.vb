<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class lector
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(lector))
        Me.Insertar = New System.Windows.Forms.Button()
        Me.Consultar = New System.Windows.Forms.Button()
        Me.Modificar = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.clvlec = New System.Windows.Forms.ComboBox()
        Me.grupo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Insertar
        '
        Me.Insertar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Insertar.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Insertar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Insertar.Location = New System.Drawing.Point(11, 323)
        Me.Insertar.Name = "Insertar"
        Me.Insertar.Size = New System.Drawing.Size(126, 33)
        Me.Insertar.TabIndex = 0
        Me.Insertar.Text = "INSERTAR"
        Me.Insertar.UseVisualStyleBackColor = False
        '
        'Consultar
        '
        Me.Consultar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Consultar.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Consultar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Consultar.Location = New System.Drawing.Point(428, 323)
        Me.Consultar.Name = "Consultar"
        Me.Consultar.Size = New System.Drawing.Size(126, 33)
        Me.Consultar.TabIndex = 1
        Me.Consultar.Text = "CONSULTAR"
        Me.Consultar.UseVisualStyleBackColor = False
        '
        'Modificar
        '
        Me.Modificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Modificar.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Modificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Modificar.Location = New System.Drawing.Point(288, 323)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(126, 33)
        Me.Modificar.TabIndex = 2
        Me.Modificar.Text = "MODIFICAR"
        Me.Modificar.UseVisualStyleBackColor = False
        '
        'Salir
        '
        Me.Salir.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Salir.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Salir.Location = New System.Drawing.Point(569, 323)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(127, 33)
        Me.Salir.TabIndex = 3
        Me.Salir.Text = "SALIR"
        Me.Salir.UseVisualStyleBackColor = False
        '
        'Eliminar
        '
        Me.Eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Eliminar.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Eliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Eliminar.Location = New System.Drawing.Point(148, 323)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(126, 33)
        Me.Eliminar.TabIndex = 4
        Me.Eliminar.Text = "ELIMINAR"
        Me.Eliminar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(296, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 22)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "NOMBRE:"
        '
        'clvlec
        '
        Me.clvlec.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clvlec.FormattingEnabled = True
        Me.clvlec.Location = New System.Drawing.Point(391, 47)
        Me.clvlec.Name = "clvlec"
        Me.clvlec.Size = New System.Drawing.Size(267, 29)
        Me.clvlec.TabIndex = 10
        '
        'grupo
        '
        Me.grupo.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupo.FormattingEnabled = True
        Me.grupo.Items.AddRange(New Object() {"DOCENTE", "101", "102", "103", "201", "202", "301", "302", "401", "402", "501", "502", "601", "602"})
        Me.grupo.Location = New System.Drawing.Point(391, 207)
        Me.grupo.Name = "grupo"
        Me.grupo.Size = New System.Drawing.Size(267, 29)
        Me.grupo.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(311, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 22)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "GRUPO:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(252, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 22)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "NO. CONTROL:"
        '
        'nombre
        '
        Me.nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.Location = New System.Drawing.Point(391, 130)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(267, 26)
        Me.nombre.TabIndex = 15
        '
        'lector
        '
        Me.BackgroundImage = Global.Biblioteca.My.Resources.Resources.Lector
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(718, 372)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.grupo)
        Me.Controls.Add(Me.clvlec)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Modificar)
        Me.Controls.Add(Me.Consultar)
        Me.Controls.Add(Me.Insertar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "lector"
        Me.Text = "Lector"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Insertar As Button
    Friend WithEvents Consultar As Button
    Friend WithEvents Modificar As Button
    Friend WithEvents Salir As Button
    Friend WithEvents Eliminar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents clvlec As ComboBox
    Friend WithEvents grupo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents nombre As TextBox
End Class
