Imports System.Data.SqlClient
Public Class frmbuscarcliente
    Private Sub dtgcliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgcliente.CellContentClick


    End Sub
    Private Sub buscar()
        Dim SQL As String
        Dim CM As SqlCommand
        Dim TB As New DataTable
        Dim DTA As New SqlDataAdapter
        SQL = "Select * from clientes where NOME like '"
        SQL = SQL & txtnome.Text & "%'"
        CM = New SqlCommand(SQL, CONN)
        CONN.Open()
        CM.ExecuteNonQuery()
        TB.Clear()
        DTA.SelectCommand = CM
        DTA.Fill(TB)
        dtgcliente.DataSource = Nothing
        dtgcliente.DataSource = TB
        CONN.Close()
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        If txtnome.Text = "" Then
            MsgBox("Por favor informe o nome do cliente para busca")
        Else
            buscar()
        End If
    End Sub

    Private Sub dtgcliente_Click(sender As Object, e As EventArgs) Handles dtgcliente.Click
        Dim ID As Integer
        Dim NOME As String
        ID = dtgcliente.CurrentRow.Cells(0).Value
        NOME = dtgcliente.CurrentRow.Cells(1).Value
        setIDCLIENTE(ID)
        setNOMECLIENTE(NOME)
        Me.Close()
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        Me.Close()
    End Sub
End Class