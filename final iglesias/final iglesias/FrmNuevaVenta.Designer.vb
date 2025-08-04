<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNuevaVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNuevaVenta))
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.cmbFormaPago = New System.Windows.Forms.ComboBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.PrendaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreciounitariDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sp_VerDetalleVentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FINALDataSet = New final_iglesias.FINALDataSet()
        Me.FormaspagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FormaspagoTableAdapter = New final_iglesias.FINALDataSetTableAdapters.formaspagoTableAdapter()
        Me.Sp_VerDetalleVentaTableAdapter = New final_iglesias.FINALDataSetTableAdapters.sp_VerDetalleVentaTableAdapter()
        Me.TableAdapterManager = New final_iglesias.FINALDataSetTableAdapters.TableAdapterManager()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_VerDetalleVentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FINALDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormaspagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(349, 274)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(119, 28)
        Me.btnConfirmar.TabIndex = 0
        Me.btnConfirmar.Text = "Guardar venta"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(304, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(286, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "id cliente"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(349, 218)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(99, 20)
        Me.txtTotal.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(265, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Forma de pago"
        '
        'cmbCliente
        '
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(349, 85)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(121, 21)
        Me.cmbCliente.TabIndex = 9
        '
        'cmbFormaPago
        '
        Me.cmbFormaPago.FormattingEnabled = True
        Me.cmbFormaPago.Location = New System.Drawing.Point(349, 131)
        Me.cmbFormaPago.Name = "cmbFormaPago"
        Me.cmbFormaPago.Size = New System.Drawing.Size(121, 21)
        Me.cmbFormaPago.TabIndex = 10
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(351, 173)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(119, 28)
        Me.btnAgregar.TabIndex = 11
        Me.btnAgregar.Text = "Agregar producto"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AutoGenerateColumns = False
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PrendaDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.PreciounitariDataGridViewTextBoxColumn, Me.SubtotalDataGridViewTextBoxColumn})
        Me.dgvDetalle.DataSource = Me.Sp_VerDetalleVentaBindingSource
        Me.dgvDetalle.Location = New System.Drawing.Point(630, 114)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.Size = New System.Drawing.Size(447, 150)
        Me.dgvDetalle.TabIndex = 12
        '
        'PrendaDataGridViewTextBoxColumn
        '
        Me.PrendaDataGridViewTextBoxColumn.DataPropertyName = "Prenda"
        Me.PrendaDataGridViewTextBoxColumn.HeaderText = "Prenda"
        Me.PrendaDataGridViewTextBoxColumn.Name = "PrendaDataGridViewTextBoxColumn"
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        '
        'PreciounitariDataGridViewTextBoxColumn
        '
        Me.PreciounitariDataGridViewTextBoxColumn.DataPropertyName = "precio_unitari"
        Me.PreciounitariDataGridViewTextBoxColumn.HeaderText = "precio_unitari"
        Me.PreciounitariDataGridViewTextBoxColumn.Name = "PreciounitariDataGridViewTextBoxColumn"
        '
        'SubtotalDataGridViewTextBoxColumn
        '
        Me.SubtotalDataGridViewTextBoxColumn.DataPropertyName = "Subtotal"
        Me.SubtotalDataGridViewTextBoxColumn.HeaderText = "Subtotal"
        Me.SubtotalDataGridViewTextBoxColumn.Name = "SubtotalDataGridViewTextBoxColumn"
        Me.SubtotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Sp_VerDetalleVentaBindingSource
        '
        Me.Sp_VerDetalleVentaBindingSource.DataMember = "sp_VerDetalleVenta"
        Me.Sp_VerDetalleVentaBindingSource.DataSource = Me.FINALDataSet
        '
        'FINALDataSet
        '
        Me.FINALDataSet.DataSetName = "FINALDataSet"
        Me.FINALDataSet.EnforceConstraints = False
        Me.FINALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FormaspagoBindingSource
        '
        Me.FormaspagoBindingSource.DataMember = "formaspago"
        Me.FormaspagoBindingSource.DataSource = Me.FINALDataSet
        '
        'FormaspagoTableAdapter
        '
        Me.FormaspagoTableAdapter.ClearBeforeFill = True
        '
        'Sp_VerDetalleVentaTableAdapter
        '
        Me.Sp_VerDetalleVentaTableAdapter.ClearBeforeFill = True
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
        'FrmNuevaVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1179, 539)
        Me.Controls.Add(Me.dgvDetalle)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.cmbFormaPago)
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmNuevaVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva Venta"
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_VerDetalleVentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FINALDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormaspagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConfirmar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents cmbFormaPago As ComboBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents FINALDataSet As FINALDataSet
    Friend WithEvents FormaspagoBindingSource As BindingSource
    Friend WithEvents FormaspagoTableAdapter As FINALDataSetTableAdapters.formaspagoTableAdapter
    Friend WithEvents dgvDetalle As DataGridView
    Friend WithEvents Sp_VerDetalleVentaBindingSource As BindingSource
    Friend WithEvents Sp_VerDetalleVentaTableAdapter As FINALDataSetTableAdapters.sp_VerDetalleVentaTableAdapter
    Friend WithEvents TableAdapterManager As FINALDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PrendaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PreciounitariDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubtotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
