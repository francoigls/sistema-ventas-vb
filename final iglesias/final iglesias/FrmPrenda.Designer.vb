<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrenda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrenda))
        Me.BtnAlta = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnBaja = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdprendaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdmarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrendasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FINALDataSet = New final_iglesias.FINALDataSet()
        Me.PrendasTableAdapter = New final_iglesias.FINALDataSetTableAdapters.prendasTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrendasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FINALDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnAlta
        '
        Me.BtnAlta.Location = New System.Drawing.Point(0, 82)
        Me.BtnAlta.Name = "BtnAlta"
        Me.BtnAlta.Size = New System.Drawing.Size(209, 79)
        Me.BtnAlta.TabIndex = 0
        Me.BtnAlta.Text = "Alta"
        Me.BtnAlta.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(0, 351)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(209, 79)
        Me.BtnModificar.TabIndex = 1
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnBaja
        '
        Me.BtnBaja.Location = New System.Drawing.Point(0, 205)
        Me.BtnBaja.Name = "BtnBaja"
        Me.BtnBaja.Size = New System.Drawing.Size(209, 79)
        Me.BtnBaja.TabIndex = 2
        Me.BtnBaja.Text = "Baja"
        Me.BtnBaja.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdprendaDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn, Me.IdmarcaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PrendasBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(244, 86)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(561, 361)
        Me.DataGridView1.TabIndex = 3
        '
        'IdprendaDataGridViewTextBoxColumn
        '
        Me.IdprendaDataGridViewTextBoxColumn.DataPropertyName = "id_prenda"
        Me.IdprendaDataGridViewTextBoxColumn.HeaderText = "id_prenda"
        Me.IdprendaDataGridViewTextBoxColumn.Name = "IdprendaDataGridViewTextBoxColumn"
        Me.IdprendaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "stock"
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        Me.StockDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdmarcaDataGridViewTextBoxColumn
        '
        Me.IdmarcaDataGridViewTextBoxColumn.DataPropertyName = "id_marca"
        Me.IdmarcaDataGridViewTextBoxColumn.HeaderText = "id_marca"
        Me.IdmarcaDataGridViewTextBoxColumn.Name = "IdmarcaDataGridViewTextBoxColumn"
        Me.IdmarcaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrendasBindingSource
        '
        Me.PrendasBindingSource.DataMember = "prendas"
        Me.PrendasBindingSource.DataSource = Me.FINALDataSet
        '
        'FINALDataSet
        '
        Me.FINALDataSet.DataSetName = "FINALDataSet"
        Me.FINALDataSet.EnforceConstraints = False
        Me.FINALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrendasTableAdapter
        '
        Me.PrendasTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.BtnModificar)
        Me.Panel1.Controls.Add(Me.BtnAlta)
        Me.Panel1.Controls.Add(Me.BtnBaja)
        Me.Panel1.Location = New System.Drawing.Point(3, -5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(209, 1159)
        Me.Panel1.TabIndex = 4
        '
        'FrmPrenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 568)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPrenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prenda"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrendasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FINALDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnAlta As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnBaja As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FINALDataSet As FINALDataSet
    Friend WithEvents PrendasBindingSource As BindingSource
    Friend WithEvents PrendasTableAdapter As FINALDataSetTableAdapters.prendasTableAdapter
    Friend WithEvents IdprendaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdmarcaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
End Class
