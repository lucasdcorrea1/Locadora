Public Class frmprincipal
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub CadastroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroToolStripMenuItem.Click

    End Sub

    Private Sub mnucadclientes_Click(sender As Object, e As EventArgs) Handles mnucadclientes.Click
        frmclientes.ShowDialog()
    End Sub

    Private Sub mnucadfilmes_Click(sender As Object, e As EventArgs) Handles mnucadfilmes.Click
        frmcadfilmes.ShowDialog()
    End Sub

    Private Sub mnucadfuncionarios_Click(sender As Object, e As EventArgs) Handles mnucadfuncionarios.Click
        frmcadfuncionarios.ShowDialog()
    End Sub

    Private Sub LocaçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocaçãoToolStripMenuItem.Click
        locacao.ShowDialog()
    End Sub
End Class