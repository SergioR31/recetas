Public Class NuevoIngrediente
    Private Sub NuevoIngrediente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'RecetasDataSet1.unidades' Puede moverla o quitarla según sea necesario.
        Me.UnidadesTableAdapter.Fill(Me.RecetasDataSet1.unidades)

    End Sub

    Private Sub numRenNuIn_ValueChanged(sender As Object, e As EventArgs) Handles numRenNuIn.ValueChanged
        numPrecioReNuIn.Value = (numPrecioUniNuIn.Value / numRenNuIn.Value) * 100
    End Sub

    Private Sub numPrecioUniNuIn_ValueChanged(sender As Object, e As EventArgs) Handles numPrecioUniNuIn.ValueChanged
        If numRenNuIn.Value <> 0 Then
            numPrecioReNuIn.Value = (numPrecioUniNuIn.Value / numRenNuIn.Value) * 100
        End If

    End Sub

    Private Sub btnGuardarIngrediente_Click(sender As Object, e As EventArgs) Handles btnGuardarIngrediente.Click
        Dim nuevoIngrediente = RecetasDataSet1.ingredientes.NewRow

        nuevoIngrediente("Nombre") = txtNombreNuIn.Text
        nuevoIngrediente("Unidad") = cbxUnidadNi.Text
        nuevoIngrediente("PrecioUnitario") = numPrecioUniNuIn.Value
        nuevoIngrediente("Rendimiento") = numRenNuIn.Value
        nuevoIngrediente("PrecioReal") = numPrecioReNuIn

        RecetasDataSet1.ingredientes.Rows.Add(nuevoIngrediente)
        IngredientesTableAdapter1.Update(RecetasDataSet1.ingredientes)
        IngredientesTableAdapter1.Fill(RecetasDataSet1.ingredientes)
    End Sub
End Class