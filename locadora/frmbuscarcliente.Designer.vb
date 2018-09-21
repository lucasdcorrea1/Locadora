<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbuscarcliente
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
        Me.txtcliente = New System.Windows.Forms.Label()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btnok = New System.Windows.Forms.Button()
        Me.dtgcliente = New System.Windows.Forms.DataGridView()
        CType(Me.dtgcliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtcliente
        '
        Me.txtcliente.AutoSize = True
        Me.txtcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcliente.Location = New System.Drawing.Point(12, 42)
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.Size = New System.Drawing.Size(53, 18)
        Me.txtcliente.TabIndex = 0
        Me.txtcliente.Text = "Cliente"
        '
        'txtnome
        '
        Me.txtnome.Location = New System.Drawing.Point(10, 63)
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(341, 20)
        Me.txtnome.TabIndex = 1
        '
        'btnbuscar
        '
        Me.btnbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscar.Location = New System.Drawing.Point(382, 49)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(80, 34)
        Me.btnbuscar.TabIndex = 2
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'btnok
        '
        Me.btnok.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnok.Location = New System.Drawing.Point(517, 49)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(57, 34)
        Me.btnok.TabIndex = 3
        Me.btnok.Text = "OK"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'dtgcliente
        '
        Me.dtgcliente.AllowUserToAddRows = False
        Me.dtgcliente.AllowUserToDeleteRows = False
        Me.dtgcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgcliente.Location = New System.Drawing.Point(10, 104)
        Me.dtgcliente.Name = "dtgcliente"
        Me.dtgcliente.ReadOnly = True
        Me.dtgcliente.Size = New System.Drawing.Size(564, 299)
        Me.dtgcliente.TabIndex = 4
        '
        'frmbuscarcliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(580, 413)
        Me.Controls.Add(Me.dtgcliente)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.txtnome)
        Me.Controls.Add(Me.txtcliente)
        Me.Name = "frmbuscarcliente"
        Me.Text = "frmbuscarcliente"
        CType(Me.dtgcliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtcliente As Label
    Friend WithEvents txtnome As TextBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnok As Button
    Friend WithEvents dtgcliente As DataGridView
End Class
