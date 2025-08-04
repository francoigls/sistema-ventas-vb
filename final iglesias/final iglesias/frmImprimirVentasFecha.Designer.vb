<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImprimirVentasFecha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImprimirVentasFecha))
        Me.SpReporteVentasPorFechaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FINALDataSet = New final_iglesias.FINALDataSet()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Sp_ReporteVentasPorFechaTableAdapter = New final_iglesias.FINALDataSetTableAdapters.sp_ReporteVentasPorFechaTableAdapter()
        Me.FinalDataSet1 = New final_iglesias.FINALDataSet()
        CType(Me.SpReporteVentasPorFechaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FINALDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinalDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SpReporteVentasPorFechaBindingSource
        '
        Me.SpReporteVentasPorFechaBindingSource.DataMember = "sp_ReporteVentasPorFecha"
        Me.SpReporteVentasPorFechaBindingSource.DataSource = Me.FINALDataSet
        '
        'FINALDataSet
        '
        Me.FINALDataSet.DataSetName = "FINALDataSet"
        Me.FINALDataSet.EnforceConstraints = False
        Me.FINALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtpDesde
        '
        Me.dtpDesde.Location = New System.Drawing.Point(192, 67)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(212, 20)
        Me.dtpDesde.TabIndex = 0
        '
        'dtpHasta
        '
        Me.dtpHasta.Location = New System.Drawing.Point(697, 67)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(216, 20)
        Me.dtpHasta.TabIndex = 1
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(477, 82)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(125, 50)
        Me.btnGenerar.TabIndex = 2
        Me.btnGenerar.Text = "Generar reporte"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(189, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Indique la fecha DESDE donde quiere buscar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(701, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(222, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Indique la fecha HASTA donde quiere buscar"
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSetVentasFecha"
        ReportDataSource1.Value = Me.SpReporteVentasPorFechaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "final_iglesias.rptVentasPorFecha.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 147)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1058, 611)
        Me.ReportViewer1.TabIndex = 5
        '
        'Sp_ReporteVentasPorFechaTableAdapter
        '
        Me.Sp_ReporteVentasPorFechaTableAdapter.ClearBeforeFill = True
        '
        'FinalDataSet1
        '
        Me.FinalDataSet1.DataSetName = "FINALDataSet"
        Me.FinalDataSet1.EnforceConstraints = False
        Me.FinalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmImprimirVentasFecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 780)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.dtpHasta)
        Me.Controls.Add(Me.dtpDesde)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmImprimirVentasFecha"
        Me.Text = "Imprimir Ventas X Fecha"
        CType(Me.SpReporteVentasPorFechaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FINALDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinalDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents dtpHasta As DateTimePicker
    Friend WithEvents btnGenerar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SpReporteVentasPorFechaBindingSource As BindingSource
    Friend WithEvents FINALDataSet As FINALDataSet
    Friend WithEvents Sp_ReporteVentasPorFechaTableAdapter As FINALDataSetTableAdapters.sp_ReporteVentasPorFechaTableAdapter
    Friend WithEvents FinalDataSet1 As FINALDataSet
End Class
