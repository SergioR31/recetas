Public Class Ingredientes
    Private Sub Ingredientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Ingredientes()
    End Sub

    Private Sub btnNuevoIngrediente_Click(sender As Object, e As EventArgs) Handles btnNuevoIngrediente.Click
        NuevoIngrediente.Show()
    End Sub
End Class