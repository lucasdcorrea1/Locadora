Imports System.Data.SqlClient
Public Class locacao
    Private Function getNumlocacao()
        Dim CM As SqlCommand
        Dim DR As SqlDataReader
        Dim SQL As String
        Dim IDCLI, IDFUM, NUM_LOC As Integer
        IDCLI = txtcliente.Text
        IDFUM = getIDFUNCIONARIO()
        SQL = "Select MAX(NUMERO) as NUMERO from LOCACAO"
        SQL = SQL & " where ID_CLIENTE=" & IDCLI
        SQL = SQL & " and ID_FUNCIONARIO=" & IDFUM
        CM = New SqlCommand(SQL, CONN)
        CONN.Open()
        DR = CM.ExecuteReader()
        DR.Read()
        NUM_LOC = DR.Item("NUMERO")
        CONN.Close()
        Return NUM_LOC
    End Function
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub lbldata_Click(sender As Object, e As EventArgs) Handles lbldata.Click

    End Sub

    Private Sub txtcliente_TextChanged(sender As Object, e As EventArgs) Handles txtcliente.TextChanged


    End Sub

    Private Sub txtcliente_DoubleClick(sender As Object, e As EventArgs) Handles txtcliente.DoubleClick
        frmbuscarcliente.ShowDialog()
        txtcliente.Text = getIDCLIENTE()
        lblcliente.Text = getNOMECLIENTE()


        'LIMPAR AS VARIAVEIS GLOBAIS
        setIDCLIENTE(0)
        setNOMECLIENTE("")
        'Exibe a data no label de data'
        lbldata.Text = Now.Date


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtcliente.Text < 1 Then
            MsgBox("Indique qual cliente para locação")
        Else
            Dim CM As SqlCommand
            Dim SQL As String

            SQL = "Insert into LOCACAO (DATA_RETIRADA,ID_CLIENTE,ID_FUNCIONARIO,STATUS) values ("
            SQL = SQL & "@DATA_RETIRADA,@ID_CLIENTE,@ID_FUNCIONARIO,@STATUS)"
            CM = New SqlCommand(SQL, CONN)
            CM.Parameters.Add("@DATA_RETIRADA", SqlDbType.Date).Value = lbldata.Text
            CM.Parameters.Add("@ID_CLIENTE", SqlDbType.Int).Value = txtcliente.Text
            CM.Parameters.Add("@ID_FUNCIONARIO", SqlDbType.Int).Value = getIDFUNCIONARIO()
            CM.Parameters.Add("@STATUS", SqlDbType.VarChar).Value = "A"

            CONN.Open()
            Dim RET As Integer = CM.ExecuteNonQuery
            CONN.Close()
            If RET > 0 Then
                MsgBox("A locação foi aberta, você poderá inserir os filmes")
                txtnumero.Text = getNumlocacao()
            End If

        End If
    End Sub
    Private Sub getfilm()
        Dim SQL As String
        Dim CM As SqlCommand
        Dim TB As New DataTable
        Dim DTA As New SqlDataAdapter
        SQL = "Select * from FILMES whERE ID=" & txtfilme.Text
        CM = New SqlCommand(SQL, CONN)
        CONN.Open()
        CM.ExecuteNonQuery()
        TB.Clear()
        DTA.SelectCommand = CM
        DTA.Fill(TB)
        CONN.Close()
        If TB.Rows.Count > 0 Then
            lblfilme.Text = TB.Rows(0).Item(1).ToString()
            txtqtde.Text = "1"
            txtvalor.Focus()

        Else
            txtfilme.Text = ""
            lblfilme.Text = ""
            MsgBox("FILME não encontrado")

        End If
    End Sub

    Private Sub dtgfilmes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgfilmes.CellContentClick

    End Sub
    Private Sub mostra_filmes()
        Dim SQL As String
        Dim TB As New DataTable
        Dim DTA As New SqlDataAdapter
        Dim CM As SqlCommand
        SQL = "Select * from FILMES_LOCACAO"
        CM = New SqlCommand(SQL, CONN)
        CONN.Open()
        CM.ExecuteNonQuery()
        DTA.SelectCommand = CM
        DTA.Fill(TB)
        CONN.Close()
        dtgfilmes.DataSource = Nothing
        dtgfilmes.DataSource = TB
    End Sub

    Private Sub txtfilme_TextChanged(sender As Object, e As EventArgs) Handles txtfilme.TextChanged

    End Sub
    Private Sub incuir_filmes()
        Dim CM As SqlCommand
        Dim SQL As String

        SQL = "Insert into FILMES_LOCACAO (NUMERO_LOCACAO,ID_FILME,QTDE,VALOR_LOCACAO) values ("
        SQL = SQL & "@NUMERO_LOCACAO,@ID_FILME,@QTDE,@VALOR_LOCACAO)"
        CM = New SqlCommand(SQL, CONN)
        CM.Parameters.Add("@NUMERO_LOCACAO", SqlDbType.Int).Value = txtnumero.Text
        CM.Parameters.Add("@ID_FILME", SqlDbType.Int).Value = txtfilme.Text
        CM.Parameters.Add("@QTDE", SqlDbType.Int).Value = txtqtde.Text
        CM.Parameters.Add("@VALOR_LOCACAO", SqlDbType.Decimal).Value = txtvalor.Text

        CONN.Open()
        Dim RET As Integer = CM.ExecuteNonQuery
        CONN.Close()
        If RET > 0 Then
            MsgBox("filme adicionado a locação")
            ' txtnumero.Text = getNumlocacao()
        End If
    End Sub


    Private Sub txtfilme_LostFocus(sender As Object, e As EventArgs) Handles txtfilme.LostFocus
        If txtfilme.Text <> "" Then
            getfilm()
        Else
            MsgBox("INFORME UM CÓDIGO")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If IsNumeric(txtnumero.Text) Then
            If IsNumeric(txtfilme.Text) Then
                If IsNumeric(txtqtde.Text) Then
                    If IsNumeric(txtvalor.Text) Then
                        incuir_filmes()
                    Else
                        MsgBox("Digite o valor da locaçaõ")
                    End If
                Else
                    MsgBox("Digite a quantidade desejada do filme")
                End If
            Else
                MsgBox("Digite o código para incluir")
            End If
        Else
            MsgBox("Para incluir filme, é necessário abrir uma locação")

        End If



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class