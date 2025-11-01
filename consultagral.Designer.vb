<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consultagral
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(consultagral))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CLVLEC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GRUPODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LECTORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BIBLIOTECADataSet = New Biblioteca.BIBLIOTECADataSet()
        Me.LECTORTableAdapter = New Biblioteca.BIBLIOTECADataSetTableAdapters.LECTORTableAdapter()
        Me.salir = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LECTORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BIBLIOTECADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CLVLEC, Me.NOMBREDataGridViewTextBoxColumn, Me.GRUPODataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LECTORBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(19, 10)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(617, 262)
        Me.DataGridView1.TabIndex = 0
        '
        'CLVLEC
        '
        Me.CLVLEC.DataPropertyName = "CLVLEC"
        Me.CLVLEC.HeaderText = "CLVLEC"
        Me.CLVLEC.Name = "CLVLEC"
        '
        'NOMBREDataGridViewTextBoxColumn
        '
        Me.NOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.Name = "NOMBREDataGridViewTextBoxColumn"
        Me.NOMBREDataGridViewTextBoxColumn.Width = 350
        '
        'GRUPODataGridViewTextBoxColumn
        '
        Me.GRUPODataGridViewTextBoxColumn.DataPropertyName = "GRUPO"
        Me.GRUPODataGridViewTextBoxColumn.HeaderText = "GRUPO"
        Me.GRUPODataGridViewTextBoxColumn.Name = "GRUPODataGridViewTextBoxColumn"
        '
        'LECTORBindingSource
        '
        Me.LECTORBindingSource.DataMember = "LECTOR"
        Me.LECTORBindingSource.DataSource = Me.BIBLIOTECADataSet
        '
        'BIBLIOTECADataSet
        '
        Me.BIBLIOTECADataSet.DataSetName = "BIBLIOTECADataSet"
        Me.BIBLIOTECADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LECTORTableAdapter
        '
        Me.LECTORTableAdapter.ClearBeforeFill = True
        '
        'salir
        '
        Me.salir.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.salir.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.salir.Location = New System.Drawing.Point(519, 313)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(120, 31)
        Me.salir.TabIndex = 1
        Me.salir.Text = "SALIR"
        Me.salir.UseVisualStyleBackColor = False
        '
        'consultagral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Biblioteca.My.Resources.Resources.General
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(655, 351)
        Me.Controls.Add(Me.salir)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "consultagral"
        Me.Text = "CONSULTA GENERAL DE LA TABLA LECTOR"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LECTORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BIBLIOTECADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BIBLIOTECADataSet As BIBLIOTECADataSet
    Friend WithEvents LECTORBindingSource As BindingSource
    Friend WithEvents LECTORTableAdapter As BIBLIOTECADataSetTableAdapters.LECTORTableAdapter
    Friend WithEvents salir As Button
    Friend WithEvents CLVLECDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CLVLEC As DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GRUPODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
