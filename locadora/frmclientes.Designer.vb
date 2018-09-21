<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmclientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmclientes))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btgclientes = New System.Windows.Forms.DataGridView()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.txtendereco = New System.Windows.Forms.TextBox()
        Me.txtcidade = New System.Windows.Forms.TextBox()
        Me.txtbairro = New System.Windows.Forms.TextBox()
        Me.txtcep = New System.Windows.Forms.TextBox()
        Me.txtuf = New System.Windows.Forms.TextBox()
        Me.txtcpf = New System.Windows.Forms.TextBox()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.btnalterar = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnbuscargrid = New System.Windows.Forms.Button()
        Me.btncadastrar = New System.Windows.Forms.Button()
        Me.btnsalvar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btgclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-76, 178)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(370, 239)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(28, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(122, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nome"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(350, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Endereço"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(28, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Bairro"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(628, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Cidade"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(272, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 18)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "CEP"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(516, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 18)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "UF"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(644, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 18)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "CPF"
        '
        'btgclientes
        '
        Me.btgclientes.AllowUserToAddRows = False
        Me.btgclientes.AllowUserToDeleteRows = False
        Me.btgclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.btgclientes.Location = New System.Drawing.Point(334, 178)
        Me.btgclientes.Name = "btgclientes"
        Me.btgclientes.ReadOnly = True
        Me.btgclientes.Size = New System.Drawing.Size(512, 236)
        Me.btgclientes.TabIndex = 19
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(56, 24)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(58, 20)
        Me.txtid.TabIndex = 20
        '
        'txtnome
        '
        Me.txtnome.Location = New System.Drawing.Point(167, 24)
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(177, 20)
        Me.txtnome.TabIndex = 21
        '
        'txtendereco
        '
        Me.txtendereco.Location = New System.Drawing.Point(428, 22)
        Me.txtendereco.Name = "txtendereco"
        Me.txtendereco.Size = New System.Drawing.Size(193, 20)
        Me.txtendereco.TabIndex = 22
        '
        'txtcidade
        '
        Me.txtcidade.Location = New System.Drawing.Point(699, 22)
        Me.txtcidade.Name = "txtcidade"
        Me.txtcidade.Size = New System.Drawing.Size(137, 20)
        Me.txtcidade.TabIndex = 23
        '
        'txtbairro
        '
        Me.txtbairro.Location = New System.Drawing.Point(82, 61)
        Me.txtbairro.Name = "txtbairro"
        Me.txtbairro.Size = New System.Drawing.Size(163, 20)
        Me.txtbairro.TabIndex = 24
        '
        'txtcep
        '
        Me.txtcep.Location = New System.Drawing.Point(317, 58)
        Me.txtcep.Name = "txtcep"
        Me.txtcep.Size = New System.Drawing.Size(193, 20)
        Me.txtcep.TabIndex = 25
        '
        'txtuf
        '
        Me.txtuf.Location = New System.Drawing.Point(545, 55)
        Me.txtuf.Name = "txtuf"
        Me.txtuf.Size = New System.Drawing.Size(76, 20)
        Me.txtuf.TabIndex = 26
        '
        'txtcpf
        '
        Me.txtcpf.Location = New System.Drawing.Point(699, 58)
        Me.txtcpf.Name = "txtcpf"
        Me.txtcpf.Size = New System.Drawing.Size(137, 20)
        Me.txtcpf.TabIndex = 27
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(388, 148)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(208, 20)
        Me.txtbuscar.TabIndex = 28
        '
        'btnalterar
        '
        Me.btnalterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnalterar.ImageKey = "salvar.png"
        Me.btnalterar.ImageList = Me.ImageList1
        Me.btnalterar.Location = New System.Drawing.Point(120, 113)
        Me.btnalterar.Name = "btnalterar"
        Me.btnalterar.Size = New System.Drawing.Size(48, 56)
        Me.btnalterar.TabIndex = 31
        Me.btnalterar.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "atualizar.png")
        Me.ImageList1.Images.SetKeyName(1, "buscar.png")
        Me.ImageList1.Images.SetKeyName(2, "deletar.png")
        Me.ImageList1.Images.SetKeyName(3, "novo.png")
        Me.ImageList1.Images.SetKeyName(4, "sair.png")
        Me.ImageList1.Images.SetKeyName(5, "salvar.png")
        '
        'btnbuscargrid
        '
        Me.btnbuscargrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscargrid.ImageKey = "buscar.png"
        Me.btnbuscargrid.ImageList = Me.ImageList1
        Me.btnbuscargrid.Location = New System.Drawing.Point(334, 114)
        Me.btnbuscargrid.Name = "btnbuscargrid"
        Me.btnbuscargrid.Size = New System.Drawing.Size(48, 55)
        Me.btnbuscargrid.TabIndex = 30
        Me.btnbuscargrid.UseVisualStyleBackColor = True
        '
        'btncadastrar
        '
        Me.btncadastrar.BackColor = System.Drawing.Color.Transparent
        Me.btncadastrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncadastrar.ForeColor = System.Drawing.Color.Transparent
        Me.btncadastrar.ImageIndex = 3
        Me.btncadastrar.ImageList = Me.ImageList1
        Me.btncadastrar.Location = New System.Drawing.Point(12, 114)
        Me.btncadastrar.Name = "btncadastrar"
        Me.btncadastrar.Size = New System.Drawing.Size(48, 55)
        Me.btncadastrar.TabIndex = 29
        Me.btncadastrar.UseVisualStyleBackColor = False
        '
        'btnsalvar
        '
        Me.btnsalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalvar.ImageIndex = 0
        Me.btnsalvar.ImageList = Me.ImageList1
        Me.btnsalvar.Location = New System.Drawing.Point(66, 113)
        Me.btnsalvar.Name = "btnsalvar"
        Me.btnsalvar.Size = New System.Drawing.Size(48, 55)
        Me.btnsalvar.TabIndex = 32
        Me.btnsalvar.UseVisualStyleBackColor = True
        '
        'frmclientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(861, 461)
        Me.Controls.Add(Me.btnsalvar)
        Me.Controls.Add(Me.btnalterar)
        Me.Controls.Add(Me.btnbuscargrid)
        Me.Controls.Add(Me.btncadastrar)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.txtcpf)
        Me.Controls.Add(Me.txtuf)
        Me.Controls.Add(Me.txtcep)
        Me.Controls.Add(Me.txtbairro)
        Me.Controls.Add(Me.txtcidade)
        Me.Controls.Add(Me.txtendereco)
        Me.Controls.Add(Me.txtnome)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.btgclientes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmclientes"
        Me.Text = "Cadastro De Clientes"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btgclientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btgclientes As DataGridView
    Friend WithEvents txtid As TextBox
    Friend WithEvents txtnome As TextBox
    Friend WithEvents txtendereco As TextBox
    Friend WithEvents txtcidade As TextBox
    Friend WithEvents txtbairro As TextBox
    Friend WithEvents txtcep As TextBox
    Friend WithEvents txtuf As TextBox
    Friend WithEvents txtcpf As TextBox
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents btnalterar As Button
    Friend WithEvents btnbuscargrid As Button
    Friend WithEvents btncadastrar As Button
    Friend WithEvents btnsalvar As Button
    Friend WithEvents ImageList1 As ImageList
End Class
