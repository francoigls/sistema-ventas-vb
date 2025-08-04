<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImprimirPrendaRango
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImprimirPrendaRango))
        Me.sp_ReporteVentasPorPrendaYRangoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FINALDataSet = New final_iglesias.FINALDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.txtCodigoPrenda = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SpReporteVentasPorPrendaYRangoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_ReporteVentasPorPrendaYRangoTableAdapter = New final_iglesias.FINALDataSetTableAdapters.sp_ReporteVentasPorPrendaYRangoTableAdapter()
        Me.FinalDataSet1 = New final_iglesias.FINALDataSet()
        CType(Me.sp_ReporteVentasPorPrendaYRangoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FINALDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpReporteVentasPorPrendaYRangoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinalDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sp_ReporteVentasPorPrendaYRangoBindingSource
        '
        Me.sp_ReporteVentasPorPrendaYRangoBindingSource.DataMember = "sp_ReporteVentasPorPrendaYRango"
        Me.sp_ReporteVentasPorPrendaYRangoBindingSource.DataSource = Me.FINALDataSet
        '
        'FINALDataSet
        '
        Me.FINALDataSet.DataSetName = "FINALDataSet"
        Me.FINALDataSet.EnforceConstraints = False
        Me.FINALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1278, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(222, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Indique la fecha HASTA donde quiere buscar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(507, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(223, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Indique la fecha DESDE donde quiere buscar"
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(922, 166)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(147, 50)
        Me.btnGenerar.TabIndex = 8
        Me.btnGenerar.Text = "Generar reporte"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'dtpHasta
        '
        Me.dtpHasta.Location = New System.Drawing.Point(1274, 76)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(216, 20)
        Me.dtpHasta.TabIndex = 7
        '
        'dtpDesde
        '
        Me.dtpDesde.Location = New System.Drawing.Point(510, 76)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(212, 20)
        Me.dtpDesde.TabIndex = 6
        '
        'txtCodigoPrenda
        '
        Me.txtCodigoPrenda.Location = New System.Drawing.Point(922, 131)
        Me.txtCodigoPrenda.Name = "txtCodigoPrenda"
        Me.txtCodigoPrenda.Size = New System.Drawing.Size(147, 20)
        Me.txtCodigoPrenda.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(920, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Indique el codigo de la prenda"
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSetVentasPrendasRango"
        ReportDataSource1.Value = Me.sp_ReporteVentasPorPrendaYRangoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "final_iglesias.rptVentasPrendaFecha.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(634, 238)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(799, 246)
        Me.ReportViewer1.TabIndex = 13
        '
        'SpReporteVentasPorPrendaYRangoBindingSource
        '
        Me.SpReporteVentasPorPrendaYRangoBindingSource.DataMember = "sp_ReporteVentasPorPrendaYRango"
        Me.SpReporteVentasPorPrendaYRangoBindingSource.DataSource = Me.FINALDataSet
        '
        'Sp_ReporteVentasPorPrendaYRangoTableAdapter
        '
        Me.Sp_ReporteVentasPorPrendaYRangoTableAdapter.ClearBeforeFill = True
        '
        'FinalDataSet1
        '
        Me.FinalDataSet1.DataSetName = "FINALDataSet"
        Me.FinalDataSet1.EnforceConstraints = False
        Me.FinalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmImprimirPrendaRango
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodigoPrenda)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.dtpHasta)
        Me.Controls.Add(Me.dtpDesde)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmImprimirPrendaRango"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir Prenda por Rango"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.sp_ReporteVentasPorPrendaYRangoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FINALDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpReporteVentasPorPrendaYRangoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinalDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnGenerar As Button
    Friend WithEvents dtpHasta As DateTimePicker
    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents txtCodigoPrenda As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FINALDataSet As FINALDataSet
    Friend WithEvents SpReporteVentasPorPrendaYRangoBindingSource As BindingSource
    Friend WithEvents Sp_ReporteVentasPorPrendaYRangoTableAdapter As FINALDataSetTableAdapters.sp_ReporteVentasPorPrendaYRangoTableAdapter
    Friend WithEvents sp_ReporteVentasPorPrendaYRangoBindingSource As BindingSource
    Friend WithEvents FinalDataSet1 As FINALDataSet
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
