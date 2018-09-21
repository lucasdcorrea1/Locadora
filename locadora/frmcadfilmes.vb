Imports System.Data.SqlClient
Public Class frmcadfilmes
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btncadastrar_Click(sender As Object, e As EventArgs) Handles btncadastrar.Click
        txtid.Text = ""
        txtbusca.Text = ""
        txtduracao.Text = ""
        txtfilme.Text = ""
        txtlancamento.Text = ""
        txttitulo.Text = ""

    End Sub

    Private Sub btnalterar_Click(sender As Object, e As EventArgs) Handles btnalterar.Click
        If IsNumeric(txtid.Text) Then
            alterar_registro()
        Else
            MsgBox("Você so poderá alterar um registro já existente")
        End If
    End Sub
    Private Sub alterar_registro()
        Dim CM As SqlCommand
        Dim SQL As String

        SQL = "Update FILMES set GENERO=@GENERO,DURACAO=@DURACAO,ANO=@ANO,DESCRICAO=@DESCRICAO"
        SQL = SQL & " where ID=" & txtid.Text
        CM = New SqlCommand(SQL, CONN)
        CM.Parameters.Add("@GENERO", SqlDbType.VarChar).Value = txtfilme.Text
        CM.Parameters.Add("@DURACAO", SqlDbType.VarChar).Value = txtduracao.Text
        CM.Parameters.Add("@ANO", SqlDbType.VarChar).Value = txtlancamento.Text
        CM.Parameters.Add("@DESCRICAO", SqlDbType.VarChar).Value = txttitulo.Text

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
    Private Sub incluir_registro()
        Dim CM As SqlCommand
        Dim SQL As String
        SQL = "Insert into FILMES (GENERO,DURACAO,ANO,DESCRICAO) values ("
        SQL = SQL + "@GENERO,@DURACAO,@ANO,@DESCRICAO)"
        CM = New SqlCommand(SQL, CONN)
        CM.Parameters.Add("@GENERO", SqlDbType.VarChar).Value = txtfilme.Text
        CM.Parameters.Add("@DURACAO", SqlDbType.VarChar).Value = txtduracao.Text
        CM.Parameters.Add("@ANO", SqlDbType.VarChar).Value = txtlancamento.Text
        CM.Parameters.Add("@DESCRICAO", SqlDbType.VarChar).Value = txttitulo.Text

        CONN.Open()
        Dim RET As Integer = CM.ExecuteNonQuery
        If RET > 0 Then
            MsgBox("O registro foi inserido com sucesso")
        End If
        CONN.Close()
    End Sub

    Private Sub btnbuscargrid_Click(sender As Object, e As EventArgs) Handles btnbuscargrid.Click
        If txtbusca.Text <> "" Then
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
        SQL = "Select * from filmes where DESCRICAO like '"
        SQL = SQL & txtbusca.Text & "%'"
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
        txttitulo.Text = btgclientes.CurrentRow.Cells(1).Value
        txtduracao.Text = btgclientes.CurrentRow.Cells(4).Value
        txtfilme.Text = btgclientes.CurrentRow.Cells(2).Value
        txtlancamento.Text = btgclientes.CurrentRow.Cells(3).Value

    End Sub

    Private Sub frmcadfilmes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class