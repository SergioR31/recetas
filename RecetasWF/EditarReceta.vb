Public Class EditarReceta
    Private Sub EditarReceta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RecetasTableAdapter1.Fill(RecetasDataSet1.recetas)
        IngredientesTableAdapter1.Fill(RecetasDataSet1.ingredientes)
        UnidadesTableAdapter.Fill(RecetasDataSet1.unidades)
        CategoriasTableAdapter1.Fill(RecetasDataSet1.categorias)
        Receta_ingredientesTableAdapter1.Fill(RecetasDataSet1.receta_ingredientes)
        Categoria_recetasTableAdapter1.Fill(RecetasDataSet1.categoria_recetas)
        Ingredientes_de_recetaTableAdapter1.Fill(RecetasDataSet1.ingredientes_de_receta)

        Dim idReceta = Inicio.btnEditarReceta.Name
        Dim receta = RecetasDataSet1.recetas.FindByID(idReceta)

        txtNombre.Text = receta.Nombre
        txtDescripcion.Text = receta.Descripcion
        txtOrigen.Text = receta.Origen
        txtHistoria.Text = receta.Historia
        txtInstrucciones.Text = receta.Instrucciones
        txtTips.Text = receta.Tips

        If IsDBNull(receta("Costo")) Then
            numCosto.Value = 1
        Else
            numCosto.Value = receta.Costo
        End If

        If IsDBNull(receta("Peso")) Then
            ckbxPeso.Checked = False
        Else
            ckbxPeso.Checked = True
            numPeso.Value = receta.Peso
            cbxUnidadPeso.SelectedText = receta("UnidadPeso")
        End If

        If IsDBNull(receta("Porciones")) Then
            ckbxPorciones.Checked = False
        Else
            ckbxPorciones.Checked = True
            numPorciones.Value = receta.Porciones
            cbxUnidadPorcion.SelectedText = receta.UnidadPorcion
        End If

        numHoras.Value = receta.TiempoPreparacion.Hours
        numMinutos.Value = receta.TiempoPreparacion.Minutes

        For Each categoria In RecetasDataSet1.categorias
            dibujarCategorias(categoria.Nombre, categoria.ID, False, True, False)
        Next

        For Each categoriaReceta In RecetasDataSet1.categoria_recetas
            If categoriaReceta.id_receta = idReceta Then
                For Each gbxCategoria As GroupBox In CategoriasERFLP.Controls
                    If gbxCategoria.Name = categoriaReceta.id_categoria Then
                        Dim checkbox As CheckBox = gbxCategoria.Controls(0)
                        checkbox.Checked = True
                    End If
                Next
            End If
        Next

        For Each ingrediente In RecetasDataSet1.ingredientes_de_receta
            If ingrediente.ID_Receta = idReceta Then
                dibujarIngredientes(ingrediente.ID_Ingrediente, ingrediente.Ingrediente, ingrediente.Cantidad, ingrediente.Unidad, True)
            End If
        Next


    End Sub

    Private Sub ckbxPeso_CheckedChanged(sender As Object, e As EventArgs) Handles ckbxPeso.CheckedChanged
        If ckbxPeso.Checked Then
            SplitContainerPeso.Panel2Collapsed = False
        Else
            SplitContainerPeso.Panel2Collapsed = True
        End If
    End Sub



    Private Sub ckbxPorciones_CheckedChanged(sender As Object, e As EventArgs) Handles ckbxPorciones.CheckedChanged
        If ckbxPorciones.Checked Then
            SplitContainerPorciones.Panel2Collapsed = False
        Else
            SplitContainerPorciones.Panel2Collapsed = True
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim recetaRepetida = False
        Dim idReceta As Integer = Inicio.btnEditarReceta.Name
        Dim recetaRow = RecetasDataSet1.recetas.FindByID(idReceta)

        recetaRow("Nombre") = txtNombre.Text
        recetaRow("Descripcion") = txtDescripcion.Text
        recetaRow("Origen") = txtOrigen.Text
        recetaRow("Historia") = txtHistoria.Text
        If ckbxPeso.Checked Then
            recetaRow("Peso") = numPeso.Value
            recetaRow("UnidadPeso") = cbxUnidadPeso.SelectedValue
        Else
            recetaRow("Peso") = DBNull.Value
            recetaRow("UnidadPeso") = DBNull.Value
        End If
        If ckbxPorciones.Checked Then
            recetaRow("Porciones") = numPorciones.Value
            recetaRow("TamanioPorcion") = numTamPor.Value
            recetaRow("UnidadPorcion") = cbxUnidadPorcion.SelectedValue
        Else
            recetaRow("Porciones") = DBNull.Value
            recetaRow("TamanioPorcion") = DBNull.Value
            recetaRow("UnidadPorcion") = DBNull.Value
        End If
        recetaRow("Instrucciones") = txtInstrucciones.Text
        recetaRow("Tips") = txtTips.Text
        recetaRow("Costo") = numCosto.Value
        recetaRow("TiempoPreparacion") = New TimeSpan(numHoras.Value, numMinutos.Value, 0)

        For Each receta In RecetasDataSet1.recetas
            If txtNombre.Text.ToUpper.Equals(receta("Nombre").ToString.ToUpper) And Not receta.ID = idReceta Then
                recetaRepetida = True
            End If
        Next

        If recetaRepetida Then
            MessageBox.Show("Ya hay una receta con ese nombre")
            txtNombre.Focus()
        Else
            RecetasTableAdapter1.Update(RecetasDataSet1.recetas)
            RecetasTableAdapter1.Fill(RecetasDataSet1.recetas)

            EditarReceta.ActiveForm.Close()
            Load_Inicio()

        End If

    End Sub

    Private Sub numPorciones_ValueChanged(sender As Object, e As EventArgs) Handles numPorciones.ValueChanged

    End Sub

    Private Sub numPeso_ValueChanged(sender As Object, e As EventArgs) Handles numPeso.ValueChanged

    End Sub

    Private Sub btnNuevoI_Click(sender As Object, e As EventArgs) Handles btnNuevoI.Click
        If btnNuevoI.Text.Equals("Nuevo Ingrediente") Then
            SplitContainer1.Panel2Collapsed = False
            btnNuevoI.Text = "Cerrar"
        Else
            SplitContainer1.Panel2Collapsed = True
            btnNuevoI.Text = "Nuevo Ingrediente"
        End If

    End Sub

    Private Sub btnAgregarCat_Click(sender As Object, e As EventArgs) Handles btnAgregarCat.Click

    End Sub
End Class