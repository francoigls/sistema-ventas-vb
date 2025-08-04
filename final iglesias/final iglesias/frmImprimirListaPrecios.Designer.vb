<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImprimirListaPrecios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImprimirListaPrecios))
        Me.SpReporteListaPreciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FINALDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FINALDataSet = New final_iglesias.FINALDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Sp_ReporteListaPreciosTableAdapter = New final_iglesias.FINALDataSetTableAdapters.sp_ReporteListaPreciosTableAdapter()
        CType(Me.SpReporteListaPreciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FINALDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FINALDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SpReporteListaPreciosBindingSource
        '
        Me.SpReporteListaPreciosBindingSource.DataMember = "sp_ReporteListaPrecios"
        Me.SpReporteListaPreciosBindingSource.DataSource = Me.FINALDataSetBindingSource
        '
        'FINALDataSetBindingSource
        '
        Me.FINALDataSetBindingSource.DataSource = Me.FINALDataSet
        Me.FINALDataSetBindingSource.Position = 0
        '
        'FINALDataSet
        '
        Me.FINALDataSet.DataSetName = "FINALDataSet"
        Me.FINALDataSet.EnforceConstraints = False
        Me.FINALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetListaPrecio"
        ReportDataSource1.Value = Me.SpReporteListaPreciosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "final_iglesias.rptListaPrecios.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'Sp_ReporteListaPreciosTableAdapter
        '
        Me.Sp_ReporteListaPreciosTableAdapter.ClearBeforeFill = True
        '
        'frmImprimirListaPrecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmImprimirListaPrecios"
        Me.Text = "Imprimir Lista de Precios"
        CType(Me.SpReporteListaPreciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FINALDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FINALDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents FINALDataSetBindingSource As BindingSource
    Friend WithEvents FINALDataSet As FINALDataSet
    Friend WithEvents SpReporteListaPreciosBindingSource As BindingSource
    Friend WithEvents Sp_ReporteListaPreciosTableAdapter As FINALDataSetTableAdapters.sp_ReporteListaPreciosTableAdapter
End Class
