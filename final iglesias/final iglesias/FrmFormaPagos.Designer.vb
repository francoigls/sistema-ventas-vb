<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFormaPagos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFormaPagos))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdformapagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormaspagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FINALDataSet = New final_iglesias.FINALDataSet()
        Me.BtnBaja = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnAlta = New System.Windows.Forms.Button()
        Me.FormaspagoTableAdapter = New final_iglesias.FINALDataSetTableAdapters.formaspagoTableAdapter()
        Me.TableAdapterManager = New final_iglesias.FINALDataSetTableAdapters.TableAdapterManager()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormaspagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FINALDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdformapagoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.FormaspagoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(623, 44)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(259, 282)
        Me.DataGridView1.TabIndex = 11
        '
        'IdformapagoDataGridViewTextBoxColumn
        '
        Me.IdformapagoDataGridViewTextBoxColumn.DataPropertyName = "id_forma_pago"
        Me.IdformapagoDataGridViewTextBoxColumn.HeaderText = "id_forma_pago"
        Me.IdformapagoDataGridViewTextBoxColumn.Name = "IdformapagoDataGridViewTextBoxColumn"
        Me.IdformapagoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FormaspagoBindingSource
        '
        Me.FormaspagoBindingSource.DataMember = "formaspago"
        Me.FormaspagoBindingSource.DataSource = Me.FINALDataSet
        '
        'FINALDataSet
        '
        Me.FINALDataSet.DataSetName = "FINALDataSet"
        Me.FINALDataSet.EnforceConstraints = False
        Me.FINALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnBaja
        '
        Me.BtnBaja.Location = New System.Drawing.Point(3, 389)
        Me.BtnBaja.Name = "BtnBaja"
        Me.BtnBaja.Size = New System.Drawing.Size(194, 79)
        Me.BtnBaja.TabIndex = 10
        Me.BtnBaja.Text = "Baja"
        Me.BtnBaja.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(0, 227)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(197, 79)
        Me.BtnModificar.TabIndex = 9
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnAlta
        '
        Me.BtnAlta.Location = New System.Drawing.Point(3, 25)
        Me.BtnAlta.Name = "BtnAlta"
        Me.BtnAlta.Size = New System.Drawing.Size(194, 79)
        Me.BtnAlta.TabIndex = 8
        Me.BtnAlta.Text = "Nueva forma de pago"
        Me.BtnAlta.UseVisualStyleBackColor = True
        '
        'FormaspagoTableAdapter
        '
        Me.FormaspagoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.detalleventaTableAdapter = Nothing
        Me.TableAdapterManager.formaspagoTableAdapter = Me.FormaspagoTableAdapter
        Me.TableAdapterManager.marcasTableAdapter = Nothing
        Me.TableAdapterManager.prendasTableAdapter = Nothing
        Me.TableAdapterManager.sp_ReporteVentasPorPrendaYRangoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = final_iglesias.FINALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.BtnModificar)
        Me.Panel1.Controls.Add(Me.BtnAlta)
        Me.Panel1.Controls.Add(Me.BtnBaja)
        Me.Panel1.Location = New System.Drawing.Point(2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 1159)
        Me.Panel1.TabIndex = 12
        '
        'FrmFormaPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 529)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmFormaPagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formas de Pagos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormaspagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FINALDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnBaja As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnAlta As Button
    Friend WithEvents FINALDataSet As FINALDataSet
    Friend WithEvents FormaspagoBindingSource As BindingSource
    Friend WithEvents FormaspagoTableAdapter As FINALDataSetTableAdapters.formaspagoTableAdapter
    Friend WithEvents TableAdapterManager As FINALDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdformapagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
End Class
