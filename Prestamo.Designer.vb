<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prestamo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Prestamo))
        Me.Salir = New System.Windows.Forms.Button()
        Me.Consultar = New System.Windows.Forms.Button()
        Me.Insertar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.clvlec = New System.Windows.Forms.ComboBox()
        Me.clvprest = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fprest = New System.Windows.Forms.DateTimePicker()
        Me.fdev = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nolib = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Salir
        '
        Me.Salir.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Salir.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Salir.Location = New System.Drawing.Point(572, 287)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(127, 33)
        Me.Salir.TabIndex = 8
        Me.Salir.Text = "SALIR"
        Me.Salir.UseVisualStyleBackColor = False
        '
        'Consultar
        '
        Me.Consultar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Consultar.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Consultar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Consultar.Location = New System.Drawing.Point(440, 287)
        Me.Consultar.Name = "Consultar"
        Me.Consultar.Size = New System.Drawing.Size(126, 33)
        Me.Consultar.TabIndex = 6
        Me.Consultar.Text = "CONSULTAR"
        Me.Consultar.UseVisualStyleBackColor = False
        '
        'Insertar
        '
        Me.Insertar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Insertar.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Insertar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Insertar.Location = New System.Drawing.Point(309, 287)
        Me.Insertar.Name = "Insertar"
        Me.Insertar.Size = New System.Drawing.Size(126, 33)
        Me.Insertar.TabIndex = 5
        Me.Insertar.Text = "INSERTAR"
        Me.Insertar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(358, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 22)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "CLAVE :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(366, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 22)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "LIBRO:"
        '
        'clvlec
        '
        Me.clvlec.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clvlec.FormattingEnabled = True
        Me.clvlec.Location = New System.Drawing.Point(432, 162)
        Me.clvlec.Name = "clvlec"
        Me.clvlec.Size = New System.Drawing.Size(247, 29)
        Me.clvlec.TabIndex = 18
        '
        'clvprest
        '
        Me.clvprest.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clvprest.FormattingEnabled = True
        Me.clvprest.Location = New System.Drawing.Point(432, 34)
        Me.clvprest.Name = "clvprest"
        Me.clvprest.Size = New System.Drawing.Size(247, 29)
        Me.clvprest.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(293, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 22)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "FECHA DE HOY:"
        '
        'fprest
        '
        Me.fprest.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fprest.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fprest.Location = New System.Drawing.Point(432, 78)
        Me.fprest.Name = "fprest"
        Me.fprest.Size = New System.Drawing.Size(247, 24)
        Me.fprest.TabIndex = 22
        Me.fprest.Value = New Date(2022, 2, 4, 14, 15, 7, 0)
        '
        'fdev
        '
        Me.fdev.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fdev.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fdev.Location = New System.Drawing.Point(432, 121)
        Me.fdev.Name = "fdev"
        Me.fdev.Size = New System.Drawing.Size(247, 24)
        Me.fdev.TabIndex = 23
        Me.fdev.Value = New Date(2022, 2, 6, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(219, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 22)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "FECHA DE DEVOLUCION:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(352, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 22)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "LECTOR:"
        '
        'nolib
        '
        Me.nolib.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nolib.FormattingEnabled = True
        Me.nolib.Location = New System.Drawing.Point(432, 209)
        Me.nolib.Name = "nolib"
        Me.nolib.Size = New System.Drawing.Size(247, 29)
        Me.nolib.TabIndex = 25
        '
        'Prestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Biblioteca.My.Resources.Resources.Lector
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(718, 332)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nolib)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fdev)
        Me.Controls.Add(Me.fprest)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.clvlec)
        Me.Controls.Add(Me.clvprest)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Consultar)
        Me.Controls.Add(Me.Insertar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Prestamo"
        Me.Text = "Préstamo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Salir As Button
    Friend WithEvents Consultar As Button
    Friend WithEvents Insertar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents clvlec As ComboBox
    Friend WithEvents clvprest As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents fprest As DateTimePicker
    Friend WithEvents fdev As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nolib As ComboBox
End Class
