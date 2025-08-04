<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInformes))
        Me.btnListaPrecio = New System.Windows.Forms.Button()
        Me.btnVentasFecha = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCodCliente = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnPrenda = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnListaPrecio
        '
        Me.btnListaPrecio.Location = New System.Drawing.Point(3, 404)
        Me.btnListaPrecio.Name = "btnListaPrecio"
        Me.btnListaPrecio.Size = New System.Drawing.Size(194, 64)
        Me.btnListaPrecio.TabIndex = 0
        Me.btnListaPrecio.Text = "Lista precios"
        Me.btnListaPrecio.UseVisualStyleBackColor = True
        '
        'btnVentasFecha
        '
        Me.btnVentasFecha.Location = New System.Drawing.Point(3, 578)
        Me.btnVentasFecha.Name = "btnVentasFecha"
        Me.btnVentasFecha.Size = New System.Drawing.Size(194, 64)
        Me.btnVentasFecha.TabIndex = 1
        Me.btnVentasFecha.Text = "Ventas por fecha"
        Me.btnVentasFecha.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 761)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(197, 64)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Codigo de prenda x rango de fechas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCodCliente
        '
        Me.btnCodCliente.Location = New System.Drawing.Point(0, 938)
        Me.btnCodCliente.Name = "btnCodCliente"
        Me.btnCodCliente.Size = New System.Drawing.Size(200, 64)
        Me.btnCodCliente.TabIndex = 3
        Me.btnCodCliente.Text = "Ventas x cliente"
        Me.btnCodCliente.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.BtnPrenda)
        Me.Panel1.Controls.Add(Me.btnCodCliente)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnListaPrecio)
        Me.Panel1.Controls.Add(Me.btnVentasFecha)
        Me.Panel1.Location = New System.Drawing.Point(-5, -354)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 1480)
        Me.Panel1.TabIndex = 7
        '
        'BtnPrenda
        '
        Me.BtnPrenda.Location = New System.Drawing.Point(0, 275)
        Me.BtnPrenda.Name = "BtnPrenda"
        Me.BtnPrenda.Size = New System.Drawing.Size(200, 65)
        Me.BtnPrenda.TabIndex = 0
        Me.BtnPrenda.Text = "Prenda"
        Me.BtnPrenda.UseVisualStyleBackColor = True
        '
        'frmInformes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1365, 1061)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInformes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnListaPrecio As Button
    Friend WithEvents btnVentasFecha As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnCodCliente As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnPrenda As Button
End Class
