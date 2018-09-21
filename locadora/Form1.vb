Public Class Form1


    Private Sub btnentrar_Click(sender As Object, e As EventArgs) Handles btnentrar.Click

        setIDFUNCIONARIO(2)

        frmprincipal.Show()

    End Sub

    Private Sub Usuarios_Click(sender As Object, e As EventArgs) Handles Usuarios.Click

    End Sub

    Private Sub txtusuario_TextChanged(sender As Object, e As EventArgs) Handles txtusuario.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setStr()
        setCON()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
