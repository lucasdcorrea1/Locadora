<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcadfuncionarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcadfuncionarios))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btgclientes = New System.Windows.Forms.DataGridView()
        Me.txtcpf = New System.Windows.Forms.TextBox()
        Me.txtuf = New System.Windows.Forms.TextBox()
        Me.txtcep = New System.Windows.Forms.TextBox()
        Me.txtbairro = New System.Windows.Forms.TextBox()
        Me.txtcidade = New System.Windows.Forms.TextBox()
        Me.txtendereco = New System.Windows.Forms.TextBox()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcargo = New System.Windows.Forms.TextBox()
        Me.txtsalario = New System.Windows.Forms.TextBox()
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
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-121, 190)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(370, 235)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(11, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 18)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Cargo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(234, 93)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 18)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Salario"
        '
        'btgclientes
        '
        Me.btgclientes.AllowUserToAddRows = False
        Me.btgclientes.AllowUserToDeleteRows = False
        Me.btgclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.btgclientes.Location = New System.Drawing.Point(263, 190)
        Me.btgclientes.Name = "btgclientes"
        Me.btgclientes.ReadOnly = True
        Me.btgclientes.Size = New System.Drawing.Size(518, 221)
        Me.btgclientes.TabIndex = 41
        '
        'txtcpf
        '
        Me.txtcpf.Location = New System.Drawing.Point(703, 48)
        Me.txtcpf.Name = "txtcpf"
        Me.txtcpf.Size = New System.Drawing.Size(137, 20)
        Me.txtcpf.TabIndex = 57
        '
        'txtuf
        '
        Me.txtuf.Location = New System.Drawing.Point(549, 48)
        Me.txtuf.Name = "txtuf"
        Me.txtuf.Size = New System.Drawing.Size(76, 20)
        Me.txtuf.TabIndex = 56
        '
        'txtcep
        '
        Me.txtcep.Location = New System.Drawing.Point(300, 48)
        Me.txtcep.Name = "txtcep"
        Me.txtcep.Size = New System.Drawing.Size(193, 20)
        Me.txtcep.TabIndex = 55
        '
        'txtbairro
        '
        Me.txtbairro.Location = New System.Drawing.Point(65, 51)
        Me.txtbairro.Name = "txtbairro"
        Me.txtbairro.Size = New System.Drawing.Size(163, 20)
        Me.txtbairro.TabIndex = 54
        '
        'txtcidade
        '
        Me.txtcidade.Location = New System.Drawing.Point(704, 10)
        Me.txtcidade.Name = "txtcidade"
        Me.txtcidade.Size = New System.Drawing.Size(137, 20)
        Me.txtcidade.TabIndex = 53
        '
        'txtendereco
        '
        Me.txtendereco.Location = New System.Drawing.Point(433, 10)
        Me.txtendereco.Name = "txtendereco"
        Me.txtendereco.Size = New System.Drawing.Size(193, 20)
        Me.txtendereco.TabIndex = 52
        '
        'txtnome
        '
        Me.txtnome.Location = New System.Drawing.Point(161, 9)
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(177, 20)
        Me.txtnome.TabIndex = 51
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(30, 8)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(58, 20)
        Me.txtid.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 18)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(652, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 18)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "CPF"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(524, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 18)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "UF"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(259, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 18)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "CEP"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(633, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 18)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Cidade"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(11, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 18)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Bairro"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(355, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Endereço"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(106, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 18)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Nome"
        '
        'txtcargo
        '
        Me.txtcargo.Location = New System.Drawing.Point(66, 93)
        Me.txtcargo.Name = "txtcargo"
        Me.txtcargo.Size = New System.Drawing.Size(162, 20)
        Me.txtcargo.TabIndex = 62
        '
        'txtsalario
        '
        Me.txtsalario.Location = New System.Drawing.Point(300, 91)
        Me.txtsalario.Name = "txtsalario"
        Me.txtsalario.Size = New System.Drawing.Size(193, 20)
        Me.txtsalario.TabIndex = 63
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(323, 164)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(220, 20)
        Me.txtbuscar.TabIndex = 64
        '
        'btnalterar
        '
        Me.btnalterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnalterar.ImageKey = "salvar.png"
        Me.btnalterar.ImageList = Me.ImageList1
        Me.btnalterar.Location = New System.Drawing.Point(135, 131)
        Me.btnalterar.Name = "btnalterar"
        Me.btnalterar.Size = New System.Drawing.Size(54, 53)
        Me.btnalterar.TabIndex = 67
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
        Me.btnbuscargrid.Location = New System.Drawing.Point(263, 132)
        Me.btnbuscargrid.Name = "btnbuscargrid"
        Me.btnbuscargrid.Size = New System.Drawing.Size(54, 52)
        Me.btnbuscargrid.TabIndex = 66
        Me.btnbuscargrid.UseVisualStyleBackColor = True
        '
        'btncadastrar
        '
        Me.btncadastrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncadastrar.ImageKey = "novo.png"
        Me.btncadastrar.ImageList = Me.ImageList1
        Me.btncadastrar.Location = New System.Drawing.Point(15, 132)
        Me.btncadastrar.Name = "btncadastrar"
        Me.btncadastrar.Size = New System.Drawing.Size(54, 53)
        Me.btncadastrar.TabIndex = 65
        Me.btncadastrar.UseVisualStyleBackColor = True
        '
        'btnsalvar
        '
        Me.btnsalvar.ImageKey = "atualizar.png"
        Me.btnsalvar.ImageList = Me.ImageList1
        Me.btnsalvar.Location = New System.Drawing.Point(75, 131)
        Me.btnsalvar.Name = "btnsalvar"
        Me.btnsalvar.Size = New System.Drawing.Size(54, 53)
        Me.btnsalvar.TabIndex = 68
        Me.btnsalvar.UseVisualStyleBackColor = True
        '
        'frmcadfuncionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(857, 423)
        Me.Controls.Add(Me.btnsalvar)
        Me.Controls.Add(Me.btnalterar)
        Me.Controls.Add(Me.btnbuscargrid)
        Me.Controls.Add(Me.btncadastrar)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.txtsalario)
        Me.Controls.Add(Me.txtcargo)
        Me.Controls.Add(Me.txtcpf)
        Me.Controls.Add(Me.txtuf)
        Me.Controls.Add(Me.txtcep)
        Me.Controls.Add(Me.txtbairro)
        Me.Controls.Add(Me.txtcidade)
        Me.Controls.Add(Me.txtendereco)
        Me.Controls.Add(Me.txtnome)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btgclientes)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmcadfuncionarios"
        Me.Text = "dt"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btgclientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btgclientes As DataGridView
    Friend WithEvents txtcpf As TextBox
    Friend WithEvents txtuf As TextBox
    Friend WithEvents txtcep As TextBox
    Friend WithEvents txtbairro As TextBox
    Friend WithEvents txtcidade As TextBox
    Friend WithEvents txtendereco As TextBox
    Friend WithEvents txtnome As TextBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcargo As TextBox
    Friend WithEvents txtsalario As TextBox
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents btnalterar As Button
    Friend WithEvents btnbuscargrid As Button
    Friend WithEvents btncadastrar As Button
    Friend WithEvents btnsalvar As Button
    Friend WithEvents ImageList1 As ImageList
End Class
