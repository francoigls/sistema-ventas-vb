<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBajaPrenda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBajaPrenda))
        Me.txtbajaprenda = New System.Windows.Forms.TextBox()
        Me.ds = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtbajaprenda
        '
        Me.txtbajaprenda.Location = New System.Drawing.Point(276, 197)
        Me.txtbajaprenda.Name = "txtbajaprenda"
        Me.txtbajaprenda.Size = New System.Drawing.Size(149, 20)
        Me.txtbajaprenda.TabIndex = 5
        '
        'ds
        '
        Me.ds.AutoSize = True
        Me.ds.Location = New System.Drawing.Point(273, 166)
        Me.ds.Name = "ds"
        Me.ds.Size = New System.Drawing.Size(171, 13)
        Me.ds.TabIndex = 4
        Me.ds.Text = "Por favor ingrese el id de la prenda"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(311, 255)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'FrmBajaPrenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 450)
        Me.Controls.Add(Me.txtbajaprenda)
        Me.Controls.Add(Me.ds)
        Me.Controls.Add(Me.btnEliminar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmBajaPrenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Baja de prenda"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtbajaprenda As TextBox
    Friend WithEvents ds As Label
    Friend WithEvents btnEliminar As Button
End Class
