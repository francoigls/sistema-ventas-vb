<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCodCliente
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCodCliente))
        Me.SPMostrarVentasPorClienteBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FINALDataSet = New final_iglesias.FINALDataSet()
        Me.SPMostrarVentasPorClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnGenerarReporte = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SP_MostrarVentasPorClienteTableAdapter = New final_iglesias.FINALDataSetTableAdapters.SP_MostrarVentasPorClienteTableAdapter()
        CType(Me.SPMostrarVentasPorClienteBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FINALDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPMostrarVentasPorClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SPMostrarVentasPorClienteBindingSource1
        '
        Me.SPMostrarVentasPorClienteBindingSource1.DataMember = "SP_MostrarVentasPorCliente"
        Me.SPMostrarVentasPorClienteBindingSource1.DataSource = Me.FINALDataSet
        '
        'FINALDataSet
        '
        Me.FINALDataSet.DataSetName = "FINALDataSet"
        Me.FINALDataSet.EnforceConstraints = False
        Me.FINALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SPMostrarVentasPorClienteBindingSource
        '
        Me.SPMostrarVentasPorClienteBindingSource.DataMember = "SP_MostrarVentasPorCliente"
        Me.SPMostrarVentasPorClienteBindingSource.DataSource = Me.FINALDataSet
        '
        'btnGenerarReporte
        '
        Me.btnGenerarReporte.Location = New System.Drawing.Point(531, 49)
        Me.btnGenerarReporte.Name = "btnGenerarReporte"
        Me.btnGenerarReporte.Size = New System.Drawing.Size(138, 56)
        Me.btnGenerarReporte.TabIndex = 0
        Me.btnGenerarReporte.Text = "Generar"
        Me.btnGenerarReporte.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(271, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingrese el id del cliente"
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(269, 85)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(117, 20)
        Me.txtIdCliente.TabIndex = 2
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSetVentasClientes"
        ReportDataSource1.Value = Me.SPMostrarVentasPorClienteBindingSource1
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "final_iglesias.rptVentasCliente.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(189, 167)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(937, 246)
        Me.ReportViewer1.TabIndex = 3
        '
        'SP_MostrarVentasPorClienteTableAdapter
        '
        Me.SP_MostrarVentasPorClienteTableAdapter.ClearBeforeFill = True
        '
        'frmCodCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1175, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGenerarReporte)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCodCliente"
        Me.Text = "Ventas por clientes"
        CType(Me.SPMostrarVentasPorClienteBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FINALDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPMostrarVentasPorClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGenerarReporte As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SPMostrarVentasPorClienteBindingSource As BindingSource
    Friend WithEvents FINALDataSet As FINALDataSet
    Friend WithEvents SP_MostrarVentasPorClienteTableAdapter As FINALDataSetTableAdapters.SP_MostrarVentasPorClienteTableAdapter
    Friend WithEvents SPMostrarVentasPorClienteBindingSource1 As BindingSource
End Class
