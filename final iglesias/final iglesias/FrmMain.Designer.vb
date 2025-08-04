<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.BtnPrenda = New System.Windows.Forms.Button()
        Me.BtnCliente = New System.Windows.Forms.Button()
        Me.BtnFormasPago = New System.Windows.Forms.Button()
        Me.BtnMarcas = New System.Windows.Forms.Button()
        Me.ventas = New System.Windows.Forms.Button()
        Me.btnInformes = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'BtnCliente
        '
        Me.BtnCliente.Location = New System.Drawing.Point(0, 377)
        Me.BtnCliente.Name = "BtnCliente"
        Me.BtnCliente.Size = New System.Drawing.Size(200, 65)
        Me.BtnCliente.TabIndex = 1
        Me.BtnCliente.Text = "Cliente"
        Me.BtnCliente.UseVisualStyleBackColor = True
        '
        'BtnFormasPago
        '
        Me.BtnFormasPago.Location = New System.Drawing.Point(0, 496)
        Me.BtnFormasPago.Name = "BtnFormasPago"
        Me.BtnFormasPago.Size = New System.Drawing.Size(200, 65)
        Me.BtnFormasPago.TabIndex = 2
        Me.BtnFormasPago.Text = "Formas de pago"
        Me.BtnFormasPago.UseVisualStyleBackColor = True
        '
        'BtnMarcas
        '
        Me.BtnMarcas.Location = New System.Drawing.Point(0, 590)
        Me.BtnMarcas.Name = "BtnMarcas"
        Me.BtnMarcas.Size = New System.Drawing.Size(200, 65)
        Me.BtnMarcas.TabIndex = 3
        Me.BtnMarcas.Text = "Marcas"
        Me.BtnMarcas.UseVisualStyleBackColor = True
        '
        'ventas
        '
        Me.ventas.Location = New System.Drawing.Point(0, 689)
        Me.ventas.Name = "ventas"
        Me.ventas.Size = New System.Drawing.Size(200, 65)
        Me.ventas.TabIndex = 4
        Me.ventas.Text = "Ventas"
        Me.ventas.UseVisualStyleBackColor = True
        '
        'btnInformes
        '
        Me.btnInformes.Location = New System.Drawing.Point(0, 794)
        Me.btnInformes.Name = "btnInformes"
        Me.btnInformes.Size = New System.Drawing.Size(200, 65)
        Me.btnInformes.TabIndex = 5
        Me.btnInformes.Text = "Informes"
        Me.btnInformes.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnInformes)
        Me.Panel1.Controls.Add(Me.BtnPrenda)
        Me.Panel1.Controls.Add(Me.ventas)
        Me.Panel1.Controls.Add(Me.BtnCliente)
        Me.Panel1.Controls.Add(Me.BtnMarcas)
        Me.Panel1.Controls.Add(Me.BtnFormasPago)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 1159)
        Me.Panel1.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.final_iglesias.My.Resources.Resources.imagen_tienda
        Me.PictureBox1.Location = New System.Drawing.Point(0, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(198, 169)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 1061)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnPrenda As Button
    Friend WithEvents BtnCliente As Button
    Friend WithEvents BtnFormasPago As Button
    Friend WithEvents BtnMarcas As Button
    Friend WithEvents ventas As Button
    Friend WithEvents btnInformes As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
