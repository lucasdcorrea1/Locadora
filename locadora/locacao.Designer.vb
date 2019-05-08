<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class locacao
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim lbltotal As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(locacao))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.txtcliente = New System.Windows.Forms.TextBox()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.lbldata = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblcliente = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtgfilmes = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtvalor = New System.Windows.Forms.TextBox()
        Me.txtqtde = New System.Windows.Forms.TextBox()
        Me.lblfilme = New System.Windows.Forms.Label()
        Me.txtfilme = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblvalor = New System.Windows.Forms.Label()
        lbltotal = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout
        Me.GroupBox2.SuspendLayout
        CType(Me.dtgfilmes,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'lbltotal
        '
        lbltotal.AutoSize = true
        lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        lbltotal.Location = New System.Drawing.Point(680, 470)
        lbltotal.Name = "lbltotal"
        lbltotal.Size = New System.Drawing.Size(45, 18)
        lbltotal.TabIndex = 5
        lbltotal.Text = "Total:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtcliente)
        Me.GroupBox1.Controls.Add(Me.txtnumero)
        Me.GroupBox1.Controls.Add(Me.lbldata)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblcliente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(875, 151)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Dados da locação"
        '
        'Button1
        '
        Me.Button1.ImageKey = "novo.png"
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(805, 86)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 53)
        Me.Button1.TabIndex = 7
        Me.Button1.UseVisualStyleBackColor = true
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"),System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "atualizar.png")
        Me.ImageList1.Images.SetKeyName(1, "buscar.png")
        Me.ImageList1.Images.SetKeyName(2, "deletar.png")
        Me.ImageList1.Images.SetKeyName(3, "novo.png")
        Me.ImageList1.Images.SetKeyName(4, "sair.png")
        Me.ImageList1.Images.SetKeyName(5, "salvar.png")
        '
        'txtcliente
        '
        Me.txtcliente.Location = New System.Drawing.Point(140, 53)
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.ReadOnly = true
        Me.txtcliente.Size = New System.Drawing.Size(69, 24)
        Me.txtcliente.TabIndex = 6
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(19, 54)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.ReadOnly = true
        Me.txtnumero.Size = New System.Drawing.Size(112, 24)
        Me.txtnumero.TabIndex = 5
        '
        'lbldata
        '
        Me.lbldata.AutoSize = true
        Me.lbldata.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(89,Byte),Integer), CType(CType(125,Byte),Integer))
        Me.lbldata.Location = New System.Drawing.Point(643, 86)
        Me.lbldata.Name = "lbldata"
        Me.lbldata.Size = New System.Drawing.Size(39, 18)
        Me.lbldata.TabIndex = 4
        Me.lbldata.Text = "Data"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(89,Byte),Integer), CType(CType(125,Byte),Integer))
        Me.Label4.Location = New System.Drawing.Point(634, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Data"
        '
        'lblcliente
        '
        Me.lblcliente.AutoSize = true
        Me.lblcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblcliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(89,Byte),Integer), CType(CType(125,Byte),Integer))
        Me.lblcliente.Location = New System.Drawing.Point(215, 60)
        Me.lblcliente.Name = "lblcliente"
        Me.lblcliente.Size = New System.Drawing.Size(184, 18)
        Me.lblcliente.TabIndex = 2
        Me.lblcliente.Text = "Aparece o nome do cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(89,Byte),Integer), CType(CType(125,Byte),Integer))
        Me.Label2.Location = New System.Drawing.Point(137, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtgfilmes)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.txtvalor)
        Me.GroupBox2.Controls.Add(Me.txtqtde)
        Me.GroupBox2.Controls.Add(Me.lblfilme)
        Me.GroupBox2.Controls.Add(Me.txtfilme)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 169)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(875, 277)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Fimes Locação"
        '
        'dtgfilmes
        '
        Me.dtgfilmes.AllowUserToAddRows = false
        Me.dtgfilmes.AllowUserToDeleteRows = false
        Me.dtgfilmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgfilmes.Location = New System.Drawing.Point(19, 121)
        Me.dtgfilmes.Name = "dtgfilmes"
        Me.dtgfilmes.ReadOnly = true
        Me.dtgfilmes.Size = New System.Drawing.Size(835, 150)
        Me.dtgfilmes.TabIndex = 12
        '
        'Button3
        '
        Me.Button3.ImageKey = "deletar.png"
        Me.Button3.ImageList = Me.ImageList1
        Me.Button3.Location = New System.Drawing.Point(805, 60)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(49, 50)
        Me.Button3.TabIndex = 11
        Me.Button3.UseVisualStyleBackColor = true
        '
        'Button2
        '
        Me.Button2.ImageKey = "salvar.png"
        Me.Button2.ImageList = Me.ImageList1
        Me.Button2.Location = New System.Drawing.Point(671, 60)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(49, 50)
        Me.Button2.TabIndex = 8
        Me.Button2.UseVisualStyleBackColor = true
        '
        'txtvalor
        '
        Me.txtvalor.Location = New System.Drawing.Point(553, 86)
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(100, 24)
        Me.txtvalor.TabIndex = 10
        '
        'txtqtde
        '
        Me.txtqtde.Location = New System.Drawing.Point(400, 86)
        Me.txtqtde.Name = "txtqtde"
        Me.txtqtde.Size = New System.Drawing.Size(100, 24)
        Me.txtqtde.TabIndex = 9
        '
        'lblfilme
        '
        Me.lblfilme.AutoSize = true
        Me.lblfilme.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblfilme.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(89,Byte),Integer), CType(CType(125,Byte),Integer))
        Me.lblfilme.Location = New System.Drawing.Point(215, 89)
        Me.lblfilme.Name = "lblfilme"
        Me.lblfilme.Size = New System.Drawing.Size(173, 18)
        Me.lblfilme.TabIndex = 8
        Me.lblfilme.Text = "Aparece o nome do filme"
        '
        'txtfilme
        '
        Me.txtfilme.Location = New System.Drawing.Point(19, 86)
        Me.txtfilme.Name = "txtfilme"
        Me.txtfilme.Size = New System.Drawing.Size(112, 24)
        Me.txtfilme.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label9.Location = New System.Drawing.Point(550, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 18)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Valor"
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label8.Location = New System.Drawing.Point(397, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 18)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Qtde"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 18)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Filme"
        '
        'lblvalor
        '
        Me.lblvalor.AutoSize = true
        Me.lblvalor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblvalor.ForeColor = System.Drawing.Color.Red
        Me.lblvalor.Location = New System.Drawing.Point(814, 470)
        Me.lblvalor.Name = "lblvalor"
        Me.lblvalor.Size = New System.Drawing.Size(36, 18)
        Me.lblvalor.TabIndex = 2
        Me.lblvalor.Text = "0,00"
        '
        'locacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(902, 508)
        Me.Controls.Add(lbltotal)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblvalor)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "locacao"
        Me.Text = "locacao"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        CType(Me.dtgfilmes,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtcliente As TextBox
    Friend WithEvents txtnumero As TextBox
    Friend WithEvents lbldata As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblcliente As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtvalor As TextBox
    Friend WithEvents txtqtde As TextBox
    Friend WithEvents lblfilme As Label
    Friend WithEvents txtfilme As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblvalor As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents dtgfilmes As DataGridView
End Class
