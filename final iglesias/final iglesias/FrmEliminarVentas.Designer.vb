<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEliminarVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEliminarVentas))
        Me.txtbajaventa = New System.Windows.Forms.TextBox()
        Me.ds = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtbajaventa
        '
        Me.txtbajaventa.Location = New System.Drawing.Point(318, 200)
        Me.txtbajaventa.Name = "txtbajaventa"
        Me.txtbajaventa.Size = New System.Drawing.Size(149, 20)
        Me.txtbajaventa.TabIndex = 8
        '
        'ds
        '
        Me.ds.AutoSize = True
        Me.ds.Location = New System.Drawing.Point(315, 169)
        Me.ds.Name = "ds"
        Me.ds.Size = New System.Drawing.Size(166, 13)
        Me.ds.TabIndex = 7
        Me.ds.Text = "Por favor ingrese el id de la Venta"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(353, 258)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'FrmEliminarVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtbajaventa)
        Me.Controls.Add(Me.ds)
        Me.Controls.Add(Me.btnEliminar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmEliminarVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar Ventas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtbajaventa As TextBox
    Friend WithEvents ds As Label
    Friend WithEvents btnEliminar As Button
End Class
