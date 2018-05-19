Public Class NuevaReceta
    Private Sub NuevaReceta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'RecetasDataSet1.unidades' Puede moverla o quitarla según sea necesario.
        Me.UnidadesTableAdapter.Fill(Me.RecetasDataSet1.unidades)
        IngredientesTableAdapter1.Fill(RecetasDataSet1.ingredientes)
        CategoriasTableAdapter1.Fill(RecetasDataSet1.categorias)
        RecetasTableAdapter1.Fill(RecetasDataSet1.recetas)
        Categoria_recetasTableAdapter1.Fill(RecetasDataSet1.categoria_recetas)

        cbxNombreNI.Text = ""

        For Each row As DataRow In RecetasDataSet1.categorias
            dibujarCategorias(row("Nombre"), row("ID"), False, False, False)
        Next

    End Sub

    Private Sub btnNuevoI_Click(sender As Object, e As EventArgs) Handles btnNuevoI.Click
        Dim btnNuevoIngrediente As Button = sender

        If btnNuevoIngrediente.Text.Equals("Nuevo Ingrediente") Then
            SplitContainer1.Panel2Collapsed = False
            cbxNombreNI.Text = ""
            btnNuevoIngrediente.Text = "Cerrar"
        Else
            SplitContainer1.Panel2Collapsed = True
            btnNuevoIngrediente.Text = "Nuevo Ingrediente"
        End If

    End Sub

    Private Sub btnAgregarI_Click(sender As Object, e As EventArgs) Handles btnAgregarI.Click
        Dim ingredienteID As Integer
        Dim repetidoEnDataSet = False
        Dim repetidoEnFlowLayoutPanel = False
        Dim nuevoIngrediente = RecetasDataSet1.ingredientes.NewRow
        Dim nombreNuevoIngrediente = cbxNombreNI.Text

        For Each row As DataRow In RecetasDataSet1.ingredientes
            If nombreNuevoIngrediente.ToUpper.Equals(row("Nombre").ToString.ToUpper) Then
                repetidoEnDataSet = True
            End If
        Next

        For Each gbxIngrediente As GroupBox In NuevosIngredientesFLP.Controls
            For Each lblCantidad As Label In gbxIngrediente.Controls.Find("NombreIngrediente", True)
                If nombreNuevoIngrediente.ToUpper.Equals(lblCantidad.Text.ToUpper) Then
                    repetidoEnFlowLayoutPanel = True
                End If
            Next
        Next

        If Not repetidoEnDataSet Then

            nuevoIngrediente("Nombre") = nombreNuevoIngrediente
            nuevoIngrediente("Cantidad") = 1
            If cbxUnidadNI.Text.Equals("pza.") Or cbxUnidadNI.Text.Equals("g.") Then
                nuevoIngrediente("Unidad") = "kg."
            ElseIf cbxUnidadNI.Text.Equals("ml.") Or cbxUnidadNI.Text.Equals("oz.") Then
                nuevoIngrediente("Unidad") = "L."
            Else
                nuevoIngrediente("Unidad") = cbxUnidadNI.Text
            End If
            nuevoIngrediente("PrecioUnitario") = 1
            nuevoIngrediente("Rendimiento") = 90
            nuevoIngrediente("PrecioREal") = 1
            RecetasDataSet1.ingredientes.Rows.Add(nuevoIngrediente)
            IngredientesTableAdapter1.Update(RecetasDataSet1.ingredientes)
            IngredientesTableAdapter1.Fill(RecetasDataSet1.ingredientes)

        End If


        If repetidoEnFlowLayoutPanel = True Then
            MessageBox.Show("Ingrediente repetido")
            cbxNombreNI.Focus()
        Else

            For Each ingrediente In RecetasDataSet1.ingredientes
                If ingrediente("Nombre").ToString.ToUpper.Equals(nombreNuevoIngrediente.ToUpper) Then
                    ingredienteID = ingrediente("ID")
                End If
            Next

            dibujarIngredientes(ingredienteID, nombreNuevoIngrediente, numCantidadNI.Value, cbxUnidadNI.Text.ToString, False)
            SplitContainer1.Panel2Collapsed = True
        End If

    End Sub

    Private Sub btnAgregarCat_Click(sender As Object, e As EventArgs) Handles btnAgregarCat.Click
        Dim categoriaID As Integer
        Dim repetidoEnDataSet = False
        Dim repetidoEnFlowLayoutPanel = False
        Dim nuevaCateoria = RecetasDataSet1.categorias.NewRow
        Dim nuevaCat = True

        If txtNuevaCategoria.Text = "" Then
            MessageBox.Show("Ingrese nombre de Categoria")
            txtNuevaCategoria.Focus()
        Else

            For Each row As DataRow In RecetasDataSet1.categorias
                If txtNuevaCategoria.Text.ToUpper.Equals(row("Nombre").ToString.ToUpper) Then
                    repetidoEnDataSet = True
                End If
            Next

            For Each gbxCategoria As GroupBox In CategoriasNRFLP.Controls
                For Each lblNombre As Label In gbxCategoria.Controls.Find("NombreCategoria", True)
                    If txtNuevaCategoria.Text.ToUpper.Equals(lblNombre.Text.ToUpper) Then
                        repetidoEnFlowLayoutPanel = True
                    End If
                Next
            Next

            If Not repetidoEnDataSet Then

                nuevaCateoria("Nombre") = txtNuevaCategoria.Text
                RecetasDataSet1.categorias.Rows.Add(nuevaCateoria)
                CategoriasTableAdapter1.Update(RecetasDataSet1.categorias)
                CategoriasTableAdapter1.Fill(RecetasDataSet1.categorias)

                For Each categoria In RecetasDataSet1.categorias
                    If categoria("Nombre").ToString.ToUpper.Equals(txtNuevaCategoria.Text.ToUpper) Then
                        categoriaID = categoria("ID")
                    End If
                Next

                dibujarCategorias(txtNuevaCategoria.Text, categoriaID, nuevaCat, False, False)
                txtNuevaCategoria.Text = ""
                CategoriasNRFLP.AutoScrollPosition = New Point(0, CategoriasNRFLP.VerticalScroll.Maximum)

            End If

            If repetidoEnFlowLayoutPanel Then
                MessageBox.Show("Categoria repetida")
                txtNuevaCategoria.Focus()
            End If

        End If

    End Sub



    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim recetaRepetida = False
        Dim idReceta As Integer
        Dim recetaRow As DataRow = RecetasDataSet1.recetas.NewRow

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
            If txtNombre.Text.ToUpper.Equals(receta("Nombre").ToString.ToUpper) Then
                recetaRepetida = True
            End If
        Next


        If recetaRepetida Then
            MessageBox.Show("Ya hay una receta con ese nombre")
            txtNombre.Focus()
        Else
            RecetasDataSet1.recetas.Rows.Add(recetaRow)
            RecetasTableAdapter1.Update(RecetasDataSet1.recetas)
            RecetasTableAdapter1.Fill(RecetasDataSet1.recetas)

            For Each receta In RecetasDataSet1.recetas
                If txtNombre.Text.ToUpper.Equals(receta("Nombre").ToString.ToUpper) Then
                    idReceta = receta.ID
                End If
            Next

            For Each gbxCategoria As GroupBox In CategoriasNRFLP.Controls
                Dim lblNombre As Label = gbxCategoria.Controls.Item("NombreCategoria")
                Dim chkbx As CheckBox = gbxCategoria.Controls.Item("checkBox")
                If chkbx.Checked Then
                    Dim rowRecetaCategorias = RecetasDataSet1.categoria_recetas.NewRow
                    rowRecetaCategorias("id_receta") = idReceta
                    rowRecetaCategorias("id_categoria") = Integer.Parse(lblNombre.Tag)
                    RecetasDataSet1.categoria_recetas.Addcategoria_recetasRow(rowRecetaCategorias)
                End If
            Next

            For Each gbxIngrediente As GroupBox In NuevosIngredientesFLP.Controls
                Dim lblNombreIngrediente As Label = gbxIngrediente.Controls.Item("NombreIngrediente")
                Dim numCantidad As NumericUpDown = gbxIngrediente.Controls.Item(1)
                Dim cbxUnidad As ComboBox = gbxIngrediente.Controls.Item(2)
                Dim rowRecetaIngredientes = RecetasDataSet1.receta_ingredientes.NewRow
                rowRecetaIngredientes("id_receta") = idReceta
                rowRecetaIngredientes("id_ingrediente") = Integer.Parse(gbxIngrediente.Name)
                rowRecetaIngredientes("Cantidad") = numCantidad.Value
                rowRecetaIngredientes("Unidad") = cbxUnidad.Text
                RecetasDataSet1.receta_ingredientes.Addreceta_ingredientesRow(rowRecetaIngredientes)
            Next

            Receta_ingredientesTableAdapter1.Update(RecetasDataSet1.receta_ingredientes)
            Receta_ingredientesTableAdapter1.Fill(RecetasDataSet1.receta_ingredientes)

            Categoria_recetasTableAdapter1.Update(RecetasDataSet1.categoria_recetas)
            Categoria_recetasTableAdapter1.Fill(RecetasDataSet1.categoria_recetas)

            NuevaReceta.ActiveForm.Close()
        End If

    End Sub

    Private Sub ckbxPeso_CheckedChanged(sender As Object, e As EventArgs) Handles ckbxPeso.CheckedChanged
        If ckbxPeso.Checked Then
            SplitContainerPeso.Panel2Collapsed = False
            numPeso.Value = numPeso.Minimum
            cbxUnidadPeso.SelectedIndex = 0
        Else
            SplitContainerPeso.Panel2Collapsed = True
        End If
    End Sub

    Private Sub ckbxPorciones_CheckedChanged(sender As Object, e As EventArgs) Handles ckbxPorciones.CheckedChanged
        If ckbxPorciones.Checked Then
            SplitContainerPorciones.Panel2Collapsed = False
            CalcularPorciones(Me)
        Else
            SplitContainerPorciones.Panel2Collapsed = True
        End If
    End Sub

    Private Sub numPorciones_ValueChanged(sender As Object, e As EventArgs) Handles numPorciones.ValueChanged
        CalcularPorciones(Me)
    End Sub

    Private Sub numPeso_ValueChanged(sender As Object, e As EventArgs) Handles numPeso.ValueChanged
        CalcularPorciones(Me)
    End Sub
End Class