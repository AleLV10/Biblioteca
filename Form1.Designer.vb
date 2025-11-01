<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.entrar = New System.Windows.Forms.Button()
        Me.salir = New System.Windows.Forms.Button()
        Me.Inicio = New System.Windows.Forms.Label()
        Me.Usuario = New System.Windows.Forms.TextBox()
        Me.Contrasena = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 28.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 326)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(311, 54)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "¡BIENVENIDO!"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'entrar
        '
        Me.entrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.entrar.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.entrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.entrar.Location = New System.Drawing.Point(47, 235)
        Me.entrar.Name = "entrar"
        Me.entrar.Size = New System.Drawing.Size(123, 35)
        Me.entrar.TabIndex = 2
        Me.entrar.Text = "ENTRAR"
        Me.entrar.UseVisualStyleBackColor = False
        '
        'salir
        '
        Me.salir.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.salir.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.salir.Location = New System.Drawing.Point(200, 235)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(123, 35)
        Me.salir.TabIndex = 3
        Me.salir.Text = "SALIR"
        Me.salir.UseVisualStyleBackColor = False
        '
        'Inicio
        '
        Me.Inicio.AutoSize = True
        Me.Inicio.BackColor = System.Drawing.Color.Transparent
        Me.Inicio.Font = New System.Drawing.Font("Microsoft YaHei", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inicio.Location = New System.Drawing.Point(92, 41)
        Me.Inicio.Name = "Inicio"
        Me.Inicio.Size = New System.Drawing.Size(182, 36)
        Me.Inicio.TabIndex = 4
        Me.Inicio.Text = "Inicia sesión"
        '
        'Usuario
        '
        Me.Usuario.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usuario.Location = New System.Drawing.Point(62, 94)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(244, 33)
        Me.Usuario.TabIndex = 5
        Me.Usuario.Text = "Usuario"
        '
        'Contrasena
        '
        Me.Contrasena.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contrasena.Location = New System.Drawing.Point(62, 153)
        Me.Contrasena.Name = "Contrasena"
        Me.Contrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Contrasena.Size = New System.Drawing.Size(244, 33)
        Me.Contrasena.TabIndex = 6
        Me.Contrasena.Text = "Contraseña"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.DodgerBlue
        Me.LinkLabel1.Location = New System.Drawing.Point(58, 200)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(184, 22)
        Me.LinkLabel1.TabIndex = 7
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Recuperar contraseña"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Biblioteca.My.Resources.Resources.InicioSecion
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(728, 406)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Contrasena)
        Me.Controls.Add(Me.Usuario)
        Me.Controls.Add(Me.Inicio)
        Me.Controls.Add(Me.salir)
        Me.Controls.Add(Me.entrar)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Pantalla Principal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents entrar As Button
    Friend WithEvents salir As Button
    Friend WithEvents Inicio As Label
    Friend WithEvents Usuario As TextBox
    Friend WithEvents Contrasena As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
