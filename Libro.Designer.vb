<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Libro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Libro))
        Me.Salir = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.Modificar = New System.Windows.Forms.Button()
        Me.Consultar = New System.Windows.Forms.Button()
        Me.Insertar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.nolib = New System.Windows.Forms.ComboBox()
        Me.edic = New System.Windows.Forms.ComboBox()
        Me.proced = New System.Windows.Forms.ComboBox()
        Me.observ = New System.Windows.Forms.ComboBox()
        Me.estado = New System.Windows.Forms.ComboBox()
        Me.edit = New System.Windows.Forms.TextBox()
        Me.isbn = New System.Windows.Forms.TextBox()
        Me.autor = New System.Windows.Forms.TextBox()
        Me.titulo = New System.Windows.Forms.TextBox()
        Me.Pais = New System.Windows.Forms.TextBox()
        Me.significado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Salir
        '
        Me.Salir.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Salir.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Salir.Location = New System.Drawing.Point(594, 378)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(140, 34)
        Me.Salir.TabIndex = 4
        Me.Salir.Text = "SALIR"
        Me.Salir.UseVisualStyleBackColor = False
        '
        'Eliminar
        '
        Me.Eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Eliminar.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Eliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Eliminar.Location = New System.Drawing.Point(164, 378)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(139, 34)
        Me.Eliminar.TabIndex = 8
        Me.Eliminar.Text = "ELIMINAR"
        Me.Eliminar.UseVisualStyleBackColor = False
        '
        'Modificar
        '
        Me.Modificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Modificar.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Modificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Modificar.Location = New System.Drawing.Point(305, 378)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(139, 34)
        Me.Modificar.TabIndex = 7
        Me.Modificar.Text = "MODIFICAR"
        Me.Modificar.UseVisualStyleBackColor = False
        '
        'Consultar
        '
        Me.Consultar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Consultar.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Consultar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Consultar.Location = New System.Drawing.Point(449, 378)
        Me.Consultar.Name = "Consultar"
        Me.Consultar.Size = New System.Drawing.Size(139, 34)
        Me.Consultar.TabIndex = 6
        Me.Consultar.Text = "CONSULTAR"
        Me.Consultar.UseVisualStyleBackColor = False
        '
        'Insertar
        '
        Me.Insertar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Insertar.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Insertar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Insertar.Location = New System.Drawing.Point(22, 378)
        Me.Insertar.Name = "Insertar"
        Me.Insertar.Size = New System.Drawing.Size(139, 34)
        Me.Insertar.TabIndex = 5
        Me.Insertar.Text = "INSERTAR"
        Me.Insertar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(328, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 22)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "NO. LIBRO:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(355, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 22)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "TITULO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(355, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 22)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "AUTOR:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(328, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 22)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "EDITORIAL:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(308, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 22)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "NO. EDICION:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(374, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 22)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "PAÍS:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(276, 270)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 22)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "OBSERVACIONES:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(296, 239)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 22)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "PROCEDENCIA:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(374, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 22)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "ISBN:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(347, 301)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 22)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "ESTADO:"
        '
        'nolib
        '
        Me.nolib.FormattingEnabled = True
        Me.nolib.Location = New System.Drawing.Point(434, 27)
        Me.nolib.Name = "nolib"
        Me.nolib.Size = New System.Drawing.Size(276, 28)
        Me.nolib.TabIndex = 25
        '
        'edic
        '
        Me.edic.FormattingEnabled = True
        Me.edic.Items.AddRange(New Object() {"1º EDICION", "2º EDICION", "3º EDICION", "4º EDICION", "5º EDICION", "6º EDICION"})
        Me.edic.Location = New System.Drawing.Point(434, 177)
        Me.edic.Name = "edic"
        Me.edic.Size = New System.Drawing.Size(276, 28)
        Me.edic.TabIndex = 26
        '
        'proced
        '
        Me.proced.FormattingEnabled = True
        Me.proced.Items.AddRange(New Object() {"DIR. GENERAL", "CAMBIO", "DONACION"})
        Me.proced.Location = New System.Drawing.Point(434, 237)
        Me.proced.Name = "proced"
        Me.proced.Size = New System.Drawing.Size(276, 28)
        Me.proced.TabIndex = 27
        '
        'observ
        '
        Me.observ.FormattingEnabled = True
        Me.observ.Items.AddRange(New Object() {"BUENO", "MALO", "REGULAR"})
        Me.observ.Location = New System.Drawing.Point(434, 268)
        Me.observ.Name = "observ"
        Me.observ.Size = New System.Drawing.Size(276, 28)
        Me.observ.TabIndex = 28
        '
        'estado
        '
        Me.estado.FormattingEnabled = True
        Me.estado.Items.AddRange(New Object() {"0", "1"})
        Me.estado.Location = New System.Drawing.Point(434, 299)
        Me.estado.Name = "estado"
        Me.estado.Size = New System.Drawing.Size(96, 28)
        Me.estado.TabIndex = 29
        '
        'edit
        '
        Me.edit.Location = New System.Drawing.Point(434, 148)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(276, 26)
        Me.edit.TabIndex = 31
        '
        'isbn
        '
        Me.isbn.Location = New System.Drawing.Point(435, 119)
        Me.isbn.Name = "isbn"
        Me.isbn.Size = New System.Drawing.Size(275, 26)
        Me.isbn.TabIndex = 32
        '
        'autor
        '
        Me.autor.Location = New System.Drawing.Point(435, 90)
        Me.autor.Name = "autor"
        Me.autor.Size = New System.Drawing.Size(275, 26)
        Me.autor.TabIndex = 33
        '
        'titulo
        '
        Me.titulo.Location = New System.Drawing.Point(435, 59)
        Me.titulo.Name = "titulo"
        Me.titulo.Size = New System.Drawing.Size(275, 26)
        Me.titulo.TabIndex = 34
        '
        'Pais
        '
        Me.Pais.Location = New System.Drawing.Point(434, 208)
        Me.Pais.Name = "Pais"
        Me.Pais.Size = New System.Drawing.Size(276, 26)
        Me.Pais.TabIndex = 35
        '
        'significado
        '
        Me.significado.Location = New System.Drawing.Point(536, 299)
        Me.significado.Name = "significado"
        Me.significado.Size = New System.Drawing.Size(174, 26)
        Me.significado.TabIndex = 36
        '
        'Libro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Biblioteca.My.Resources.Resources.Lector
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(766, 430)
        Me.Controls.Add(Me.significado)
        Me.Controls.Add(Me.Pais)
        Me.Controls.Add(Me.titulo)
        Me.Controls.Add(Me.autor)
        Me.Controls.Add(Me.isbn)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.estado)
        Me.Controls.Add(Me.observ)
        Me.Controls.Add(Me.proced)
        Me.Controls.Add(Me.edic)
        Me.Controls.Add(Me.nolib)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.Modificar)
        Me.Controls.Add(Me.Consultar)
        Me.Controls.Add(Me.Insertar)
        Me.Controls.Add(Me.Salir)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Libro"
        Me.Text = "Libro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Salir As Button
    Friend WithEvents Eliminar As Button
    Friend WithEvents Modificar As Button
    Friend WithEvents Consultar As Button
    Friend WithEvents Insertar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents nolib As ComboBox
    Friend WithEvents edic As ComboBox
    Friend WithEvents proced As ComboBox
    Friend WithEvents observ As ComboBox
    Friend WithEvents estado As ComboBox
    Friend WithEvents edit As TextBox
    Friend WithEvents isbn As TextBox
    Friend WithEvents autor As TextBox
    Friend WithEvents titulo As TextBox
    Friend WithEvents Pais As TextBox
    Friend WithEvents significado As TextBox
End Class
