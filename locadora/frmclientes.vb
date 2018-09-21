Imports System.Data.SqlClient
Public Class frmclientes
    Private Sub frmclientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtclientenome_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtclienteendereco_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtclientebairro_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtclienteid_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtclientecidade_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtclientecep_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtclienteuf_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtclientecpf_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btncadastrar_Click(sender As Object, e As EventArgs) Handles btncadastrar.Click
        txtid.Text = ""
        txtnome.Text = ""
        txtendereco.Text = ""
        txtcpf.Text = ""
        txtcep.Text = ""
        txtcidade.Text = ""
        txtuf.Text = ""
        txtbairro.Text = ""


    End Sub
    Private Sub incluir_registro()
        Dim CM As SqlCommand
        Dim SQL As String
        SQL = "Insert into CLIENTES (NOME,ENDERECO,BAIRRO,CIDADE,UF,CEP,CPF) values ("
        SQL = SQL + "@NOME,@ENDERECO,@BAIRRO,@CIDADE,@UF,@CEP,@CPF)"
        CM = New SqlCommand(SQL, CONN)
        CM.Parameters.Add("@NOME", SqlDbType.VarChar).Value = txtnome.Text
        CM.Parameters.Add("@ENDERECO", SqlDbType.VarChar).Value = txtendereco.Text
        CM.Parameters.Add("@BAIRRO", SqlDbType.VarChar).Value = txtbairro.Text
        CM.Parameters.Add("@CIDADE", SqlDbType.VarChar).Value = txtcidade.Text
        CM.Parameters.Add("@UF", SqlDbType.VarChar).Value = txtuf.Text
        CM.Parameters.Add("@CEP", SqlDbType.VarChar).Value = txtcep.Text
        CM.Parameters.Add("@CPF", SqlDbType.VarChar).Value = txtcpf.Text
        CONN.Open()
        Dim RET As Integer = CM.ExecuteNonQuery
        If RET > 0 Then
            MsgBox("O registro foi inserido com sucesso")
        End If
        CONN.Close()
    End Sub
    Private Sub alterar_registro()
        Dim CM As SqlCommand
        Dim SQL As String

        SQL = "Update CLIENTES set NOME=@NOME,ENDERECO=@ENDERECO,BAIRRO=BAIRRO,CIDADE=@CIDADE,UF=@UF,CEP=@CEP,CPF=@CPF"
        SQL = SQL & " where ID=" & txtid.Text
        CM = New SqlCommand(SQL, CONN)
        CM.Parameters.Add("@NOME", SqlDbType.VarChar).Value = txtnome.Text
        CM.Parameters.Add("@ENDERECO", SqlDbType.VarChar).Value = txtendereco.Text
        CM.Parameters.Add("@BAIRRO", SqlDbType.VarChar).Value = txtbairro.Text
        CM.Parameters.Add("@CIDADE", SqlDbType.VarChar).Value = txtcidade.Text
        CM.Parameters.Add("@UF", SqlDbType.VarChar).Value = txtuf.Text
        CM.Parameters.Add("@CEP", SqlDbType.VarChar).Value = txtcep.Text
        CM.Parameters.Add("@CPF", SqlDbType.VarChar).Value = txtcpf.Text
        CONN.Open()
        Dim RET As Integer = CM.ExecuteNonQuery
        If RET > 0 Then
            MsgBox("O registro foi alterado com sucesso")
        End If
        CONN.Close()
    End Sub

    Private Sub btnsalvar_Click(sender As Object, e As EventArgs) Handles btnsalvar.Click
        If txtid.Text = "" Then
            incluir_registro()
        Else
            MsgBox("Você so poderá incluir um novo registro")
        End If
    End Sub

    Private Sub btnalterar_Click(sender As Object, e As EventArgs) Handles btnalterar.Click
        If IsNumeric(txtid.Text) Then
            alterar_registro()
        Else
            MsgBox("Você so poderá alterar um registro já existente")
        End If
    End Sub

    Private Sub btnbuscargrid_Click(sender As Object, e As EventArgs) Handles btnbuscargrid.Click

        If txtbuscar.Text <> "" Then
            mostrar_grid()
        Else
            MsgBox("Informe Um Nome para buscar")
        End If

    End Sub
    Private Sub mostrar_grid()
        Dim SQL As String
        Dim CM As SqlCommand
        Dim TB As New DataTable
        Dim DTA As New SqlDataAdapter
        SQL = "Select * from clientes where NOME like '"
        SQL = SQL & txtbuscar.Text & "%'"
        CM = New SqlCommand(SQL, CONN)
        CONN.Open()
        CM.ExecuteNonQuery()
        TB.Clear()
        DTA.SelectCommand = CM
        DTA.Fill(TB)
        btgclientes.DataSource = Nothing
        btgclientes.DataSource = TB
        CONN.Close()

    End Sub

    Private Sub btgclientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles btgclientes.CellContentClick

    End Sub

    Private Sub btgclientes_Click(sender As Object, e As EventArgs) Handles btgclientes.Click
        txtid.Text = btgclientes.CurrentRow.Cells(0).Value
        txtnome.Text = btgclientes.CurrentRow.Cells(1).Value
        txtendereco.Text = btgclientes.CurrentRow.Cells(2).Value
        txtcpf.Text = btgclientes.CurrentRow.Cells(7).Value
        txtcep.Text = btgclientes.CurrentRow.Cells(5).Value
        txtcidade.Text = btgclientes.CurrentRow.Cells(4).Value
        txtuf.Text = btgclientes.CurrentRow.Cells(6).Value
        txtbairro.Text = btgclientes.CurrentRow.Cells(5).Value
    End Sub
End Class