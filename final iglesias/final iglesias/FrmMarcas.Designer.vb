<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMarcas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMarcas))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdmarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombremarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FINALDataSet = New final_iglesias.FINALDataSet()
        Me.BtnBaja = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnAlta = New System.Windows.Forms.Button()
        Me.MarcasTableAdapter = New final_iglesias.FINALDataSetTableAdapters.marcasTableAdapter()
        Me.TableAdapterManager = New final_iglesias.FINALDataSetTableAdapters.TableAdapterManager()
        Me.btnAumento = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdmarcaDataGridViewTextBoxColumn, Me.NombremarcaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MarcasBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(522, 45)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(643, 361)
        Me.DataGridView1.TabIndex = 11
        '
        'IdmarcaDataGridViewTextBoxColumn
        '
        Me.IdmarcaDataGridViewTextBoxColumn.DataPropertyName = "id_marca"
        Me.IdmarcaDataGridViewTextBoxColumn.HeaderText = "id_marca"
        Me.IdmarcaDataGridViewTextBoxColumn.Name = "IdmarcaDataGridViewTextBoxColumn"
        Me.IdmarcaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombremarcaDataGridViewTextBoxColumn
        '
        Me.NombremarcaDataGridViewTextBoxColumn.DataPropertyName = "nombre_marca"
        Me.NombremarcaDataGridViewTextBoxColumn.HeaderText = "nombre_marca"
        Me.NombremarcaDataGridViewTextBoxColumn.Name = "NombremarcaDataGridViewTextBoxColumn"
        Me.NombremarcaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MarcasBindingSource
        '
        Me.MarcasBindingSource.DataMember = "marcas"
        Me.MarcasBindingSource.DataSource = Me.FINALDataSet
        '
        'FINALDataSet
        '
        Me.FINALDataSet.DataSetName = "FINALDataSet"
        Me.FINALDataSet.EnforceConstraints = False
        Me.FINALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnBaja
        '
        Me.BtnBaja.Location = New System.Drawing.Point(0, 133)
        Me.BtnBaja.Name = "BtnBaja"
        Me.BtnBaja.Size = New System.Drawing.Size(200, 79)
        Me.BtnBaja.TabIndex = 10
        Me.BtnBaja.Text = "Baja"
        Me.BtnBaja.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(0, 239)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(200, 79)
        Me.BtnModificar.TabIndex = 9
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnAlta
        '
        Me.BtnAlta.Location = New System.Drawing.Point(0, 27)
        Me.BtnAlta.Name = "BtnAlta"
        Me.BtnAlta.Size = New System.Drawing.Size(200, 79)
        Me.BtnAlta.TabIndex = 8
        Me.BtnAlta.Text = "Alta"
        Me.BtnAlta.UseVisualStyleBackColor = True
        '
        'MarcasTableAdapter
        '
        Me.MarcasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.detalleventaTableAdapter = Nothing
        Me.TableAdapterManager.formaspagoTableAdapter = Nothing
        Me.TableAdapterManager.marcasTableAdapter = Me.MarcasTableAdapter
        Me.TableAdapterManager.prendasTableAdapter = Nothing
        Me.TableAdapterManager.sp_ReporteVentasPorPrendaYRangoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = final_iglesias.FINALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'btnAumento
        '
        Me.btnAumento.Location = New System.Drawing.Point(0, 341)
        Me.btnAumento.Name = "btnAumento"
        Me.btnAumento.Size = New System.Drawing.Size(200, 79)
        Me.btnAumento.TabIndex = 12
        Me.btnAumento.Text = "Aumento x marca"
        Me.btnAumento.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.btnAumento)
        Me.Panel1.Controls.Add(Me.BtnAlta)
        Me.Panel1.Controls.Add(Me.BtnModificar)
        Me.Panel1.Controls.Add(Me.BtnBaja)
        Me.Panel1.Location = New System.Drawing.Point(0, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 1159)
        Me.Panel1.TabIndex = 13
        '
        'FrmMarcas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMarcas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marcas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FINALDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnBaja As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnAlta As Button
    Friend WithEvents FINALDataSet As FINALDataSet
    Friend WithEvents MarcasBindingSource As BindingSource
    Friend WithEvents MarcasTableAdapter As FINALDataSetTableAdapters.marcasTableAdapter
    Friend WithEvents TableAdapterManager As FINALDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdmarcaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombremarcaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnAumento As Button
    Friend WithEvents Panel1 As Panel
End Class
