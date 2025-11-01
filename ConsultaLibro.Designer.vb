<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsultaLibro
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaLibro))
        Me.salir = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NOLIBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TITULODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AUTORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EDITDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISBNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EDICDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAISDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROCEDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBSERVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LIBROBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BIBLIOTECADataSet1 = New Biblioteca.BIBLIOTECADataSet1()
        Me.LIBROTableAdapter = New Biblioteca.BIBLIOTECADataSet1TableAdapters.LIBROTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIBROBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BIBLIOTECADataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'salir
        '
        Me.salir.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.salir.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.salir.Location = New System.Drawing.Point(1101, 558)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(120, 31)
        Me.salir.TabIndex = 2
        Me.salir.Text = "SALIR"
        Me.salir.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NOLIBDataGridViewTextBoxColumn, Me.TITULODataGridViewTextBoxColumn, Me.AUTORDataGridViewTextBoxColumn, Me.EDITDataGridViewTextBoxColumn, Me.ISBNDataGridViewTextBoxColumn, Me.EDICDataGridViewTextBoxColumn, Me.PAISDataGridViewTextBoxColumn, Me.PROCEDDataGridViewTextBoxColumn, Me.OBSERVDataGridViewTextBoxColumn, Me.ESTADODataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LIBROBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(7, 14)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1216, 451)
        Me.DataGridView1.TabIndex = 3
        '
        'NOLIBDataGridViewTextBoxColumn
        '
        Me.NOLIBDataGridViewTextBoxColumn.DataPropertyName = "NOLIB"
        Me.NOLIBDataGridViewTextBoxColumn.HeaderText = "No."
        Me.NOLIBDataGridViewTextBoxColumn.Name = "NOLIBDataGridViewTextBoxColumn"
        Me.NOLIBDataGridViewTextBoxColumn.Width = 35
        '
        'TITULODataGridViewTextBoxColumn
        '
        Me.TITULODataGridViewTextBoxColumn.DataPropertyName = "TITULO"
        Me.TITULODataGridViewTextBoxColumn.HeaderText = "TITULO"
        Me.TITULODataGridViewTextBoxColumn.Name = "TITULODataGridViewTextBoxColumn"
        Me.TITULODataGridViewTextBoxColumn.Width = 250
        '
        'AUTORDataGridViewTextBoxColumn
        '
        Me.AUTORDataGridViewTextBoxColumn.DataPropertyName = "AUTOR"
        Me.AUTORDataGridViewTextBoxColumn.HeaderText = "AUTOR"
        Me.AUTORDataGridViewTextBoxColumn.Name = "AUTORDataGridViewTextBoxColumn"
        Me.AUTORDataGridViewTextBoxColumn.Width = 250
        '
        'EDITDataGridViewTextBoxColumn
        '
        Me.EDITDataGridViewTextBoxColumn.DataPropertyName = "EDIT"
        Me.EDITDataGridViewTextBoxColumn.HeaderText = "EDITORIAL"
        Me.EDITDataGridViewTextBoxColumn.Name = "EDITDataGridViewTextBoxColumn"
        '
        'ISBNDataGridViewTextBoxColumn
        '
        Me.ISBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.HeaderText = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.Name = "ISBNDataGridViewTextBoxColumn"
        Me.ISBNDataGridViewTextBoxColumn.Width = 110
        '
        'EDICDataGridViewTextBoxColumn
        '
        Me.EDICDataGridViewTextBoxColumn.DataPropertyName = "EDIC"
        Me.EDICDataGridViewTextBoxColumn.HeaderText = "No. EDICIÓN"
        Me.EDICDataGridViewTextBoxColumn.Name = "EDICDataGridViewTextBoxColumn"
        Me.EDICDataGridViewTextBoxColumn.Width = 80
        '
        'PAISDataGridViewTextBoxColumn
        '
        Me.PAISDataGridViewTextBoxColumn.DataPropertyName = "PAIS"
        Me.PAISDataGridViewTextBoxColumn.HeaderText = "PAÍS"
        Me.PAISDataGridViewTextBoxColumn.Name = "PAISDataGridViewTextBoxColumn"
        Me.PAISDataGridViewTextBoxColumn.Width = 80
        '
        'PROCEDDataGridViewTextBoxColumn
        '
        Me.PROCEDDataGridViewTextBoxColumn.DataPropertyName = "PROCED"
        Me.PROCEDDataGridViewTextBoxColumn.HeaderText = "PROCEDENCIA"
        Me.PROCEDDataGridViewTextBoxColumn.Name = "PROCEDDataGridViewTextBoxColumn"
        Me.PROCEDDataGridViewTextBoxColumn.Width = 90
        '
        'OBSERVDataGridViewTextBoxColumn
        '
        Me.OBSERVDataGridViewTextBoxColumn.DataPropertyName = "OBSERV"
        Me.OBSERVDataGridViewTextBoxColumn.HeaderText = "OBSERVACIONES"
        Me.OBSERVDataGridViewTextBoxColumn.Name = "OBSERVDataGridViewTextBoxColumn"
        '
        'ESTADODataGridViewTextBoxColumn
        '
        Me.ESTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO"
        Me.ESTADODataGridViewTextBoxColumn.HeaderText = "ESTADO"
        Me.ESTADODataGridViewTextBoxColumn.Name = "ESTADODataGridViewTextBoxColumn"
        Me.ESTADODataGridViewTextBoxColumn.Width = 60
        '
        'LIBROBindingSource
        '
        Me.LIBROBindingSource.DataMember = "LIBRO"
        Me.LIBROBindingSource.DataSource = Me.BIBLIOTECADataSet1
        '
        'BIBLIOTECADataSet1
        '
        Me.BIBLIOTECADataSet1.DataSetName = "BIBLIOTECADataSet1"
        Me.BIBLIOTECADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LIBROTableAdapter
        '
        Me.LIBROTableAdapter.ClearBeforeFill = True
        '
        'ConsultaLibro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Biblioteca.My.Resources.Resources.General
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1233, 601)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.salir)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ConsultaLibro"
        Me.Text = "CONSULTA GENERAL DE LA TABLA LIBRO"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIBROBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BIBLIOTECADataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents salir As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BIBLIOTECADataSet1 As BIBLIOTECADataSet1
    Friend WithEvents LIBROBindingSource As BindingSource
    Friend WithEvents LIBROTableAdapter As BIBLIOTECADataSet1TableAdapters.LIBROTableAdapter
    Friend WithEvents NOLIBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TITULODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AUTORDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EDITDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ISBNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EDICDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PAISDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PROCEDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OBSERVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ESTADODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
