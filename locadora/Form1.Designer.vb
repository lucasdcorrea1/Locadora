<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnentrar = New System.Windows.Forms.Button()
        Me.Usuarios = New System.Windows.Forms.Label()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.txtsenha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47,Byte),Integer), CType(CType(147,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"),System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-36, -114)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(878, 756)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = false
        '
        'btnentrar
        '
        Me.btnentrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(1,Byte),Integer), CType(CType(14,Byte),Integer), CType(CType(30,Byte),Integer))
        Me.btnentrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnentrar.Image = CType(resources.GetObject("btnentrar.Image"),System.Drawing.Image)
        Me.btnentrar.Location = New System.Drawing.Point(331, 506)
        Me.btnentrar.Name = "btnentrar"
        Me.btnentrar.Size = New System.Drawing.Size(188, 56)
        Me.btnentrar.TabIndex = 1
        Me.btnentrar.UseVisualStyleBackColor = false
        '
        'Usuarios
        '
        Me.Usuarios.AutoSize = true
        Me.Usuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(223,Byte),Integer), CType(CType(33,Byte),Integer), CType(CType(58,Byte),Integer))
        Me.Usuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Usuarios.Location = New System.Drawing.Point(201, 379)
        Me.Usuarios.Name = "Usuarios"
        Me.Usuarios.Size = New System.Drawing.Size(60, 18)
        Me.Usuarios.TabIndex = 2
        Me.Usuarios.Text = "Usuario"
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(204, 411)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(134, 20)
        Me.txtusuario.TabIndex = 3
        '
        'txtsenha
        '
        Me.txtsenha.Location = New System.Drawing.Point(525, 411)
        Me.txtsenha.Name = "txtsenha"
        Me.txtsenha.Size = New System.Drawing.Size(134, 20)
        Me.txtsenha.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(70,Byte),Integer), CType(CType(118,Byte),Integer), CType(CType(180,Byte),Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(522, 379)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Senha"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47,Byte),Integer), CType(CType(147,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.ClientSize = New System.Drawing.Size(876, 654)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtsenha)
        Me.Controls.Add(Me.txtusuario)
        Me.Controls.Add(Me.Usuarios)
        Me.Controls.Add(Me.btnentrar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnentrar As Button
    Friend WithEvents Usuarios As Label
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents txtsenha As TextBox
    Friend WithEvents Label2 As Label
End Class
