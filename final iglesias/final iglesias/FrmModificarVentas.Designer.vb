<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModificarVentas))
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.cmbVentas = New System.Windows.Forms.ComboBox()
        Me.cmbClientes = New System.Windows.Forms.ComboBox()
        Me.cmbFormasPago = New System.Windows.Forms.ComboBox()
        Me.s = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(295, 277)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(98, 32)
        Me.btnModificar.TabIndex = 13
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'cmbVentas
        '
        Me.cmbVentas.FormattingEnabled = True
        Me.cmbVentas.Location = New System.Drawing.Point(295, 151)
        Me.cmbVentas.Name = "cmbVentas"
        Me.cmbVentas.Size = New System.Drawing.Size(137, 21)
        Me.cmbVentas.TabIndex = 7
        '
        'cmbClientes
        '
        Me.cmbClientes.FormattingEnabled = True
        Me.cmbClientes.Location = New System.Drawing.Point(295, 196)
        Me.cmbClientes.Name = "cmbClientes"
        Me.cmbClientes.Size = New System.Drawing.Size(137, 21)
        Me.cmbClientes.TabIndex = 14
        '
        'cmbFormasPago
        '
        Me.cmbFormasPago.FormattingEnabled = True
        Me.cmbFormasPago.Location = New System.Drawing.Point(295, 238)
        Me.cmbFormasPago.Name = "cmbFormasPago"
        Me.cmbFormasPago.Size = New System.Drawing.Size(137, 21)
        Me.cmbFormasPago.TabIndex = 15
        '
        's
        '
        Me.s.AutoSize = True
        Me.s.Location = New System.Drawing.Point(169, 154)
        Me.s.Name = "s"
        Me.s.Size = New System.Drawing.Size(117, 13)
        Me.s.TabIndex = 16
        Me.s.Text = "ID de venta a modificar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(213, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nuevo cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(169, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Nueva forma de pago"
        '
        'FrmModificarVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.s)
        Me.Controls.Add(Me.cmbFormasPago)
        Me.Controls.Add(Me.cmbClientes)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.cmbVentas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmModificarVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Ventas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnModificar As Button
    Friend WithEvents cmbVentas As ComboBox
    Friend WithEvents cmbClientes As ComboBox
    Friend WithEvents cmbFormasPago As ComboBox
    Friend WithEvents s As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
