<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaPrestamo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaPrestamo))
        Me.salir = New System.Windows.Forms.Button()
        Me.UpdateOrderOptionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BIBLIOTECADataSet = New Biblioteca.BIBLIOTECADataSet()
        Me.BIBLIOTECADataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DLECPRESTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DLECPRESTTableAdapter = New Biblioteca.BIBLIOTECADataSetTableAdapters.DLECPRESTTableAdapter()
        Me.PRESTAMOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRESTAMOTableAdapter = New Biblioteca.BIBLIOTECADataSetTableAdapters.PRESTAMOTableAdapter()
        Me.DLECPRESTBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.BibliotecaDataSet1 = New Biblioteca.BIBLIOTECADataSet()
        CType(Me.UpdateOrderOptionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BIBLIOTECADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BIBLIOTECADataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DLECPRESTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRESTAMOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DLECPRESTBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BibliotecaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'salir
        '
        Me.salir.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        resources.ApplyResources(Me.salir, "salir")
        Me.salir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.salir.Name = "salir"
        Me.salir.UseVisualStyleBackColor = False
        '
        'UpdateOrderOptionBindingSource
        '
        Me.UpdateOrderOptionBindingSource.DataSource = GetType(Biblioteca.BIBLIOTECADataSetTableAdapters.TableAdapterManager.UpdateOrderOption)
        '
        'BIBLIOTECADataSet
        '
        Me.BIBLIOTECADataSet.DataSetName = "BIBLIOTECADataSet"
        Me.BIBLIOTECADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BIBLIOTECADataSetBindingSource
        '
        Me.BIBLIOTECADataSetBindingSource.DataSource = Me.BIBLIOTECADataSet
        Me.BIBLIOTECADataSetBindingSource.Position = 0
        '
        'DLECPRESTBindingSource
        '
        Me.DLECPRESTBindingSource.DataMember = "DLECPREST"
        Me.DLECPRESTBindingSource.DataSource = Me.BIBLIOTECADataSetBindingSource
        '
        'DLECPRESTTableAdapter
        '
        Me.DLECPRESTTableAdapter.ClearBeforeFill = True
        '
        'PRESTAMOBindingSource
        '
        Me.PRESTAMOBindingSource.DataMember = "PRESTAMO"
        Me.PRESTAMOBindingSource.DataSource = Me.BIBLIOTECADataSetBindingSource
        '
        'PRESTAMOTableAdapter
        '
        Me.PRESTAMOTableAdapter.ClearBeforeFill = True
        '
        'DLECPRESTBindingSource1
        '
        Me.DLECPRESTBindingSource1.DataMember = "DLECPREST"
        Me.DLECPRESTBindingSource1.DataSource = Me.BIBLIOTECADataSetBindingSource
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.DGV, "DGV")
        Me.DGV.Name = "DGV"
        '
        'BibliotecaDataSet1
        '
        Me.BibliotecaDataSet1.DataSetName = "BIBLIOTECADataSet"
        Me.BibliotecaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConsultaPrestamo
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Biblioteca.My.Resources.Resources.General
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.salir)
        Me.Name = "ConsultaPrestamo"
        CType(Me.UpdateOrderOptionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BIBLIOTECADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BIBLIOTECADataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DLECPRESTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRESTAMOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DLECPRESTBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BibliotecaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents salir As Button
    Friend WithEvents BIBLIOTECADataSetBindingSource As BindingSource
    Friend WithEvents BIBLIOTECADataSet As BIBLIOTECADataSet
    Friend WithEvents UpdateOrderOptionBindingSource As BindingSource
    Friend WithEvents DLECPRESTBindingSource As BindingSource
    Friend WithEvents DLECPRESTTableAdapter As BIBLIOTECADataSetTableAdapters.DLECPRESTTableAdapter
    Friend WithEvents PRESTAMOBindingSource As BindingSource
    Friend WithEvents PRESTAMOTableAdapter As BIBLIOTECADataSetTableAdapters.PRESTAMOTableAdapter
    Friend WithEvents DLECPRESTBindingSource1 As BindingSource
    Friend WithEvents DGV As DataGridView
    Friend WithEvents BibliotecaDataSet1 As BIBLIOTECADataSet
End Class
