<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcadfilmes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcadfilmes))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btgclientes = New System.Windows.Forms.DataGridView()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txttitulo = New System.Windows.Forms.TextBox()
        Me.txtfilme = New System.Windows.Forms.TextBox()
        Me.txtlancamento = New System.Windows.Forms.TextBox()
        Me.txtduracao = New System.Windows.Forms.TextBox()
        Me.txtbusca = New System.Windows.Forms.TextBox()
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
        Me.PictureBox1.Location = New System.Drawing.Point(-109, 175)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(376, 239)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(123, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Titulo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(369, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Genero do Filme"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Data De Lançamento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(369, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Duração"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "ID"
        '
        'btgclientes
        '
        Me.btgclientes.AllowUserToAddRows = False
        Me.btgclientes.AllowUserToDeleteRows = False
        Me.btgclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.btgclientes.Location = New System.Drawing.Point(290, 196)
        Me.btgclientes.Name = "btgclientes"
        Me.btgclientes.ReadOnly = True
        Me.btgclientes.Size = New System.Drawing.Size(353, 218)
        Me.btgclientes.TabIndex = 22
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(57, 21)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(60, 20)
        Me.txtid.TabIndex = 23
        '
        'txttitulo
        '
        Me.txttitulo.Location = New System.Drawing.Point(176, 21)
        Me.txttitulo.Name = "txttitulo"
        Me.txttitulo.Size = New System.Drawing.Size(182, 20)
        Me.txttitulo.TabIndex = 24
        '
        'txtfilme
        '
        Me.txtfilme.Location = New System.Drawing.Point(502, 19)
        Me.txtfilme.Name = "txtfilme"
        Me.txtfilme.Size = New System.Drawing.Size(139, 20)
        Me.txtfilme.TabIndex = 25
        '
        'txtlancamento
        '
        Me.txtlancamento.Location = New System.Drawing.Point(193, 64)
        Me.txtlancamento.Name = "txtlancamento"
        Me.txtlancamento.Size = New System.Drawing.Size(165, 20)
        Me.txtlancamento.TabIndex = 26
        '
        'txtduracao
        '
        Me.txtduracao.Location = New System.Drawing.Point(445, 62)
        Me.txtduracao.Name = "txtduracao"
        Me.txtduracao.Size = New System.Drawing.Size(196, 20)
        Me.txtduracao.TabIndex = 27
        '
        'txtbusca
        '
        Me.txtbusca.Location = New System.Drawing.Point(343, 170)
        Me.txtbusca.Name = "txtbusca"
        Me.txtbusca.Size = New System.Drawing.Size(298, 20)
        Me.txtbusca.TabIndex = 28
        '
        'btnalterar
        '
        Me.btnalterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnalterar.ImageIndex = 5
        Me.btnalterar.ImageList = Me.ImageList1
        Me.btnalterar.Location = New System.Drawing.Point(118, 114)
        Me.btnalterar.Name = "btnalterar"
        Me.btnalterar.Size = New System.Drawing.Size(47, 55)
        Me.btnalterar.TabIndex = 73
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
        Me.btnbuscargrid.Location = New System.Drawing.Point(290, 136)
        Me.btnbuscargrid.Name = "btnbuscargrid"
        Me.btnbuscargrid.Size = New System.Drawing.Size(47, 54)
        Me.btnbuscargrid.TabIndex = 72
        Me.btnbuscargrid.UseVisualStyleBackColor = True
        '
        'btncadastrar
        '
        Me.btncadastrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncadastrar.ImageKey = "novo.png"
        Me.btncadastrar.ImageList = Me.ImageList1
        Me.btncadastrar.Location = New System.Drawing.Point(12, 114)
        Me.btncadastrar.Name = "btncadastrar"
        Me.btncadastrar.Size = New System.Drawing.Size(47, 55)
        Me.btncadastrar.TabIndex = 71
        Me.btncadastrar.UseVisualStyleBackColor = True
        '
        'btnsalvar
        '
        Me.btnsalvar.ImageIndex = 0
        Me.btnsalvar.ImageList = Me.ImageList1
        Me.btnsalvar.Location = New System.Drawing.Point(65, 114)
        Me.btnsalvar.Name = "btnsalvar"
        Me.btnsalvar.Size = New System.Drawing.Size(47, 55)
        Me.btnsalvar.TabIndex = 74
        Me.btnsalvar.UseVisualStyleBackColor = True
        '
        'frmcadfilmes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(653, 426)
        Me.Controls.Add(Me.btnsalvar)
        Me.Controls.Add(Me.btnalterar)
        Me.Controls.Add(Me.btnbuscargrid)
        Me.Controls.Add(Me.btncadastrar)
        Me.Controls.Add(Me.txtbusca)
        Me.Controls.Add(Me.txtduracao)
        Me.Controls.Add(Me.txtlancamento)
        Me.Controls.Add(Me.txtfilme)
        Me.Controls.Add(Me.txttitulo)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.btgclientes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmcadfilmes"
        Me.Text = "Cadastro de Filmes"
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
    Friend WithEvents btgclientes As DataGridView
    Friend WithEvents txtid As TextBox
    Friend WithEvents txttitulo As TextBox
    Friend WithEvents txtfilme As TextBox
    Friend WithEvents txtlancamento As TextBox
    Friend WithEvents txtduracao As TextBox
    Friend WithEvents txtbusca As TextBox
    Friend WithEvents btnalterar As Button
    Friend WithEvents btnbuscargrid As Button
    Friend WithEvents btncadastrar As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents btnsalvar As Button
End Class
