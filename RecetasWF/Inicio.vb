Public Class Inicio
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Inicio()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NuevaReceta.Show()
    End Sub

    Private Sub btnEditarReceta_Click(sender As Object, e As EventArgs) Handles btnEditarReceta.Click
        SplitContainerDetallesR.Panel2Collapsed = True
        EditarReceta.Show()
    End Sub

    Private Sub btnEliminarReceta_Click(sender As Object, e As EventArgs) Handles btnEliminarReceta.Click
        Dim respuesta = MessageBox.Show("Deseas eliminar la receta?", "Confirmar Accion", MessageBoxButtons.OKCancel)
        Dim idReceta = btnEliminarReceta.Name
        Dim receta = RecetasDataSet1.recetas.FindByID(idReceta)
        If respuesta = DialogResult.OK Then

            For Each ingredienteReceta In RecetasDataSet1.receta_ingredientes
                If ingredienteReceta.id_receta = idReceta Then
                    ingredienteReceta.Delete()
                End If
            Next

            For Each recetaCategoria In RecetasDataSet1.categoria_recetas
                If recetaCategoria.id_receta = idReceta Then
                    recetaCategoria.Delete()
                End If
            Next

            receta.Delete()

            Receta_ingredientesTableAdapter1.Update(RecetasDataSet1.receta_ingredientes)
            Categoria_recetasTableAdapter1.Update(RecetasDataSet1.categoria_recetas)
            RecetasTableAdapter1.Update(RecetasDataSet1.recetas)

            MessageBox.Show("Receta Eliminada")

            Load_Inicio()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Ingredientes.Show()
    End Sub
End Class
