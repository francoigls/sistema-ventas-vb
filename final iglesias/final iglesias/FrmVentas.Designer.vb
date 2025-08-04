<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVentas))
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FINALDataSet = New final_iglesias.FINALDataSet()
        Me.BtnBaja = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnAlta = New System.Windows.Forms.Button()
        Me.VentasTableAdapter = New final_iglesias.FINALDataSetTableAdapters.ventasTableAdapter()
        Me.TableAdapterManager = New final_iglesias.FINALDataSetTableAdapters.TableAdapterManager()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdventaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormapagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpListarVentasConDatosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_ListarVentasConDatosTableAdapter = New final_iglesias.FINALDataSetTableAdapters.sp_ListarVentasConDatosTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FINALDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpListarVentasConDatosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'VentasBindingSource
        '
        Me.VentasBindingSource.DataMember = "ventas"
        Me.VentasBindingSource.DataSource = Me.FINALDataSet
        '
        'FINALDataSet
        '
        Me.FINALDataSet.DataSetName = "FINALDataSet"
        Me.FINALDataSet.EnforceConstraints = False
        Me.FINALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnBaja
        '
        Me.BtnBaja.Location = New System.Drawing.Point(0, 176)
        Me.BtnBaja.Name = "BtnBaja"
        Me.BtnBaja.Size = New System.Drawing.Size(182, 79)
        Me.BtnBaja.TabIndex = 10
        Me.BtnBaja.Text = "Eliminar venta"
        Me.BtnBaja.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(0, 282)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(182, 79)
        Me.BtnModificar.TabIndex = 9
        Me.BtnModificar.Text = "Modificar venta"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnAlta
        '
        Me.BtnAlta.Location = New System.Drawing.Point(0, 70)
        Me.BtnAlta.Name = "BtnAlta"
        Me.BtnAlta.Size = New System.Drawing.Size(182, 79)
        Me.BtnAlta.TabIndex = 8
        Me.BtnAlta.Text = "Nueva venta"
        Me.BtnAlta.UseVisualStyleBackColor = True
        '
        'VentasTableAdapter
        '
        Me.VentasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.detalleventaTableAdapter = Nothing
        Me.TableAdapterManager.formaspagoTableAdapter = Nothing
        Me.TableAdapterManager.marcasTableAdapter = Nothing
        Me.TableAdapterManager.prendasTableAdapter = Nothing
        Me.TableAdapterManager.sp_ReporteVentasPorPrendaYRangoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = final_iglesias.FINALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        Me.TableAdapterManager.ventasTableAdapter = Me.VentasTableAdapter
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdventaDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.ClienteDataGridViewTextBoxColumn, Me.FormapagoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SpListarVentasConDatosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(216, 81)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(549, 291)
        Me.DataGridView1.TabIndex = 11
        '
        'IdventaDataGridViewTextBoxColumn
        '
        Me.IdventaDataGridViewTextBoxColumn.DataPropertyName = "id_venta"
        Me.IdventaDataGridViewTextBoxColumn.HeaderText = "id_venta"
        Me.IdventaDataGridViewTextBoxColumn.Name = "IdventaDataGridViewTextBoxColumn"
        Me.IdventaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "cliente"
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "cliente"
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        Me.ClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FormapagoDataGridViewTextBoxColumn
        '
        Me.FormapagoDataGridViewTextBoxColumn.DataPropertyName = "forma_pago"
        Me.FormapagoDataGridViewTextBoxColumn.HeaderText = "forma_pago"
        Me.FormapagoDataGridViewTextBoxColumn.Name = "FormapagoDataGridViewTextBoxColumn"
        '
        'SpListarVentasConDatosBindingSource
        '
        Me.SpListarVentasConDatosBindingSource.DataMember = "sp_ListarVentasConDatos"
        Me.SpListarVentasConDatosBindingSource.DataSource = Me.FINALDataSet
        '
        'Sp_ListarVentasConDatosTableAdapter
        '
        Me.Sp_ListarVentasConDatosTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.BtnModificar)
        Me.Panel1.Controls.Add(Me.BtnAlta)
        Me.Panel1.Controls.Add(Me.BtnBaja)
        Me.Panel1.Location = New System.Drawing.Point(3, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(182, 1159)
        Me.Panel1.TabIndex = 12
        '
        'FrmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FINALDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpListarVentasConDatosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnBaja As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnAlta As Button
    Friend WithEvents FINALDataSet As FINALDataSet
    Friend WithEvents VentasBindingSource As BindingSource
    Friend WithEvents VentasTableAdapter As FINALDataSetTableAdapters.ventasTableAdapter
    Friend WithEvents TableAdapterManager As FINALDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SpListarVentasConDatosBindingSource As BindingSource
    Friend WithEvents Sp_ListarVentasConDatosTableAdapter As FINALDataSetTableAdapters.sp_ListarVentasConDatosTableAdapter
    Friend WithEvents IdventaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FormapagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
End Class
