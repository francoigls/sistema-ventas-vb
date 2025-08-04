<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmlogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmlogin))
        Me.TxtPsw = New System.Windows.Forms.TextBox()
        Me.Lblpsw = New System.Windows.Forms.Label()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtPsw
        '
        Me.TxtPsw.Location = New System.Drawing.Point(281, 206)
        Me.TxtPsw.Name = "TxtPsw"
        Me.TxtPsw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPsw.Size = New System.Drawing.Size(175, 20)
        Me.TxtPsw.TabIndex = 10
        '
        'Lblpsw
        '
        Me.Lblpsw.AutoSize = True
        Me.Lblpsw.Location = New System.Drawing.Point(278, 177)
        Me.Lblpsw.Name = "Lblpsw"
        Me.Lblpsw.Size = New System.Drawing.Size(61, 13)
        Me.Lblpsw.TabIndex = 9
        Me.Lblpsw.Text = "Contraseña"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Location = New System.Drawing.Point(281, 139)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(175, 20)
        Me.TxtUsuario.TabIndex = 8
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Location = New System.Drawing.Point(278, 108)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.LblUsuario.TabIndex = 7
        Me.LblUsuario.Text = "Usuario"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(281, 263)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(175, 62)
        Me.BtnAceptar.TabIndex = 6
        Me.BtnAceptar.Text = "ACEPTAR"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'Frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxtPsw)
        Me.Controls.Add(Me.Lblpsw)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.LblUsuario)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtPsw As TextBox
    Friend WithEvents Lblpsw As Label
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents LblUsuario As Label
    Friend WithEvents BtnAceptar As Button
End Class
