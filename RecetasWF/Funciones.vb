Module Funciones
    Public Sub dibujarIngredientes(ByVal idIngrediente, ByVal nombre, ByVal cantidad, ByVal unidad, ByVal editada)
        Dim gbxIngrediente As New GroupBox
        Dim lblNombre As New Label
        Dim numCantidad As New NumericUpDown
        Dim cbxUnidad As New ComboBox
        Dim indexUnidad As Integer
        Dim btnEliminar As New Button
        Dim bSource

        If Not editada Then
            bSource = New BindingSource(NuevaReceta.RecetasDataSet1, "unidades")
        Else
            bSource = New BindingSource(EditarReceta.RecetasDataSet1, "unidades")
        End If


        lblNombre.Parent = gbxIngrediente
        numCantidad.Parent = gbxIngrediente
        cbxUnidad.Parent = gbxIngrediente
        btnEliminar.Parent = gbxIngrediente

        gbxIngrediente.Width = 250
        gbxIngrediente.Height = 35
        gbxIngrediente.Margin = New Padding(8, 0, 0, 0)
        gbxIngrediente.Padding = New Padding(8, 0, 0, 0)
        gbxIngrediente.Name = idIngrediente

        lblNombre.Tag = idIngrediente
        lblNombre.Name = "NombreIngrediente"
        lblNombre.Text = nombre.ToString
        lblNombre.Width = 105
        lblNombre.Left = 5
        lblNombre.Top = 14
        lblNombre.Height = 15

        numCantidad.Text = cantidad.ToString
        numCantidad.Width = 50
        numCantidad.Left = lblNombre.Left + lblNombre.Width + 5
        numCantidad.Top = 10
        numCantidad.Minimum = 1
        numCantidad.DecimalPlaces = 2
        numCantidad.Increment = 1

        cbxUnidad.Width = 50
        cbxUnidad.Left = numCantidad.Left + numCantidad.Width + 5
        cbxUnidad.Top = 10
        cbxUnidad.DataSource = bSource
        cbxUnidad.DisplayMember = "Unidad"
        cbxUnidad.ValueMember = "Unidad"
        cbxUnidad.AutoCompleteSource = AutoCompleteSource.ListItems
        cbxUnidad.DropDownStyle = ComboBoxStyle.DropDownList

        btnEliminar.Text = "-"
        btnEliminar.Left = cbxUnidad.Left + cbxUnidad.Width + 5
        btnEliminar.Width = 20
        btnEliminar.Top = 9

        AddHandler btnEliminar.Click, AddressOf btnEliminarIngrediente_Click

        If Not editada Then

            NuevaReceta.NuevosIngredientesFLP.Controls.Add(gbxIngrediente)

            For Each gbxIngredienteagregado As GroupBox In NuevaReceta.NuevosIngredientesFLP.Controls
                Dim cboxunidadAgregada As ComboBox = gbxIngredienteagregado.Controls.Item(2)
                Dim lblName As Label = gbxIngredienteagregado.Controls.Item(0)
                If lblName.Text = nombre.ToString Then
                    indexUnidad = cboxunidadAgregada.FindString(unidad.ToString)
                    cboxunidadAgregada.SelectedIndex = indexUnidad
                End If
            Next
        Else
            EditarReceta.EditarIngredientesFLP.Controls.Add(gbxIngrediente)

            For Each gbxIngredienteagregado As GroupBox In EditarReceta.EditarIngredientesFLP.Controls
                Dim cboxunidadAgregada As ComboBox = gbxIngredienteagregado.Controls.Item(2)
                Dim lblName As Label = gbxIngredienteagregado.Controls.Item(0)
                If lblName.Text = nombre.ToString Then
                    indexUnidad = cboxunidadAgregada.FindString(unidad.ToString)
                    cboxunidadAgregada.SelectedIndex = indexUnidad
                End If
            Next

        End If


    End Sub

    Public Sub btnEliminarIngrediente_Click(sender As Object, e As EventArgs)
        Dim btnEliminarIngrediente As Button = sender
        Dim ControlIngrediente As Control = btnEliminarIngrediente.Parent
        Dim index As Integer = Integer.Parse(NuevaReceta.NuevosIngredientesFLP.Controls.IndexOf(ControlIngrediente))

        NuevaReceta.NuevosIngredientesFLP.Controls.RemoveAt(index)

    End Sub

    Public Sub dibIngredientes(ByVal idIngrediente, ByVal nombre)
        Dim gbxIngrediente As New GroupBox
        Dim btnIngrediente As New Button

        btnIngrediente.Parent = gbxIngrediente

        btnIngrediente.Width = 150
        btnIngrediente.Height = 35
        btnIngrediente.Margin = New Padding(8, 0, 0, 0)
        btnIngrediente.Padding = New Padding(8, 0, 0, 0)
        btnIngrediente.Name = idIngrediente
        btnIngrediente.Text = nombre

        AddHandler btnIngrediente.Click, AddressOf btnIngrediente_Click

        Ingredientes.IngredientesFLP.Controls.Add(btnIngrediente)

    End Sub

    Public Sub btnIngrediente_Click(sender As Object, e As EventArgs)
        Dim btnIngrediente As Button = sender
        Dim ingrediente = Ingredientes.RecetasDataSet1.ingredientes.FindByID(btnIngrediente.Name)
        Ingredientes.lblNombreIngrediente.Text = ingrediente.Nombre
        Ingredientes.lblUnidadIn.Text = ingrediente.Unidad
        Ingredientes.lblPrecioUniIn.Text = ingrediente.PrecioUnitario
        Ingredientes.lblRendimientoIn.Text = ingrediente.Rendimiento
        Ingredientes.lblPrecioRealIn.Text = ingrediente.PrecioReal
    End Sub

    Public Sub dibujarCategorias(ByVal nombre As String, ByVal idCategoria As Integer, ByVal nuevaCat As Boolean, ByVal editada As Boolean, ByVal ini As Boolean)
        Dim gbxNCategoria As New GroupBox
        Dim ckbxSeleccionar As New CheckBox
        Dim lblNombreNCategoria As New Label

        ckbxSeleccionar.Parent = gbxNCategoria
        lblNombreNCategoria.Parent = gbxNCategoria

        gbxNCategoria.Width = 150
        gbxNCategoria.Height = 35
        gbxNCategoria.Name = idCategoria

        ckbxSeleccionar.Tag = idCategoria
        ckbxSeleccionar.Name = "checkBox"
        ckbxSeleccionar.Top = 8
        ckbxSeleccionar.Left = 5
        ckbxSeleccionar.Width = 20
        If nuevaCat Then
            ckbxSeleccionar.Checked = True
        Else
            ckbxSeleccionar.Checked = False
        End If

        lblNombreNCategoria.Tag = idCategoria
        lblNombreNCategoria.Name = "NombreCategoria"
        lblNombreNCategoria.Text = nombre
        lblNombreNCategoria.Top = 7
        lblNombreNCategoria.Left = ckbxSeleccionar.Left + ckbxSeleccionar.Width
        lblNombreNCategoria.Width = 80
        lblNombreNCategoria.TextAlign = ContentAlignment.MiddleCenter

        AddHandler ckbxSeleccionar.CheckedChanged, AddressOf ckbxSeleccionar_CheckedChanged

        If editada Then
            EditarReceta.CategoriasERFLP.Controls.Add(gbxNCategoria)
        Else
            If ini Then
                Inicio.CategoriasInFLP.Controls.Add(gbxNCategoria)
            Else
                NuevaReceta.CategoriasNRFLP.Controls.Add(gbxNCategoria)
            End If
        End If


    End Sub

    Public Sub dibujarRecetas(ByVal idReceta, ByVal nombre)
        Dim gbxReceta As New GroupBox
        Dim lblNombreReceta As New Label
        Dim btnDetallesReceta As New Button
        Dim btnEditarReceta As New Button

        lblNombreReceta.Parent = gbxReceta
        btnDetallesReceta.Parent = gbxReceta

        gbxReceta.Height = 60
        gbxReceta.Width = 80
        gbxReceta.Tag = idReceta
        gbxReceta.AutoSize = True

        lblNombreReceta.Text = nombre
        lblNombreReceta.AutoSize = True
        lblNombreReceta.Top = 10
        lblNombreReceta.Left = 15
        lblNombreReceta.Height = 15
        lblNombreReceta.Width = 50

        btnDetallesReceta.Left = 15
        btnDetallesReceta.Top = 35
        btnDetallesReceta.Width = 50
        btnDetallesReceta.Height = 20
        btnDetallesReceta.Name = idReceta
        btnDetallesReceta.Text = "Ver"

        AddHandler btnDetallesReceta.Click, AddressOf btnDetallesReceta_Click

        Inicio.RecetasFLP.Controls.Add(gbxReceta)


    End Sub

    Public Sub btnDetallesReceta_Click(sender As Object, e As EventArgs)
        Dim btnDetalle As Button = sender
        Dim recetaDataRow = Inicio.RecetasDataSet1.recetas.FindByID(btnDetalle.Name)

        Inicio.SplitContainerDetallesR.Panel2Collapsed = False

        Inicio.btnEditarReceta.Name = btnDetalle.Name
        Inicio.btnEditarReceta.Visible = True

        Inicio.btnEliminarReceta.Name = btnDetalle.Name
        Inicio.btnEliminarReceta.Visible = True

        Inicio.Label1.Text = recetaDataRow.Nombre
        Inicio.Label2.Text = recetaDataRow.Descripcion
    End Sub

    Public Sub Load_Inicio()
        Inicio.TableAdapterManager1.recetasTableAdapter.Fill(Inicio.RecetasDataSet1.recetas)
        Inicio.TableAdapterManager1.unidadesTableAdapter.Fill(Inicio.RecetasDataSet1.unidades)
        Inicio.TableAdapterManager1.ingredientesTableAdapter.Fill(Inicio.RecetasDataSet1.ingredientes)
        Inicio.TableAdapterManager1.receta_ingredientesTableAdapter.Fill(Inicio.RecetasDataSet1.receta_ingredientes)
        Inicio.TableAdapterManager1.categoria_recetasTableAdapter.Fill(Inicio.RecetasDataSet1.categoria_recetas)
        Inicio.TableAdapterManager1.categoriasTableAdapter.Fill(Inicio.RecetasDataSet1.categorias)
        Inicio.Ingredientes_de_recetaTableAdapter1.Fill(Inicio.RecetasDataSet1.ingredientes_de_receta)
        Inicio.Recetas_de_categoriaTableAdapter1.Fill(Inicio.RecetasDataSet1.recetas_de_categoria)


        Inicio.RecetasFLP.Controls.Clear()
        Inicio.CategoriasInFLP.Controls.Clear()

        For Each categoria In Inicio.RecetasDataSet1.categorias
            dibujarCategorias(categoria.Nombre, categoria.ID, False, False, True)
        Next

        For Each receta In Inicio.RecetasDataSet1.recetas
            dibujarRecetas(receta("ID"), receta("Nombre"))
        Next


    End Sub

    Public Sub Load_Ingredientes()
        Ingredientes.IngredientesTableAdapter1.Fill(Ingredientes.RecetasDataSet1.ingredientes)
        Ingredientes.Receta_ingredientesTableAdapter1.Fill(Ingredientes.RecetasDataSet1.receta_ingredientes)
        Ingredientes.UnidadesTableAdapter1.Fill(Ingredientes.RecetasDataSet1.unidades)
        Ingredientes.Ingredientes_de_recetaTableAdapter1.Fill(Ingredientes.RecetasDataSet1.ingredientes_de_receta)

        Ingredientes.IngredientesFLP.Controls.Clear()

        For Each ingrediente In Ingredientes.RecetasDataSet1.ingredientes
            dibIngredientes(ingrediente.ID, ingrediente.Nombre)
        Next

    End Sub

    Public Sub CalcularPorciones(Form As Form)

        Dim tamPorcion As Decimal

        If Form.Text.Equals("Nueva Receta") Then

            tamPorcion = (NuevaReceta.numPeso.Value * 1000) / NuevaReceta.numPorciones.Value

            If NuevaReceta.ckbxPeso.Checked And NuevaReceta.ckbxPorciones.Checked Then

                If NuevaReceta.numPorciones.Value = 1 Then
                    NuevaReceta.numTamPor.Value = NuevaReceta.numPeso.Value
                    NuevaReceta.cbxUnidadPorcion.SelectedValue = NuevaReceta.cbxUnidadPeso.SelectedValue
                End If

                If NuevaReceta.cbxUnidadPeso.SelectedValue.Equals("kg.") Then
                    If tamPorcion = 1000 Then
                        NuevaReceta.numTamPor.Value = tamPorcion / 1000
                        NuevaReceta.cbxUnidadPorcion.SelectedValue = "kg."
                    ElseIf tamPorcion < 1000 Then
                        NuevaReceta.numTamPor.Value = tamPorcion
                        NuevaReceta.cbxUnidadPorcion.SelectedValue = "g."
                    Else
                        NuevaReceta.numTamPor.Value = tamPorcion / 1000
                        NuevaReceta.cbxUnidadPorcion.SelectedValue = "kg."
                    End If

                End If

            End If

        ElseIf Form.Text.Equals("Editar Receta") Then

            tamPorcion = (EditarReceta.numPeso.Value * 1000) / EditarReceta.numPorciones.Value

            If EditarReceta.ckbxPeso.Checked And EditarReceta.ckbxPorciones.Checked Then

                If EditarReceta.numPorciones.Value = 1 Then
                    EditarReceta.numTamPor.Value = EditarReceta.numPeso.Value
                    EditarReceta.cbxUnidadPorcion.SelectedValue = EditarReceta.cbxUnidadPeso.SelectedValue
                End If

                If EditarReceta.cbxUnidadPeso.SelectedValue.Equals("kg.") Then
                    If tamPorcion = 1000 Then
                        EditarReceta.numTamPor.Value = tamPorcion / 1000
                        EditarReceta.cbxUnidadPorcion.SelectedValue = "kg."
                    ElseIf tamPorcion < 1000 Then
                        EditarReceta.numTamPor.Value = tamPorcion
                        EditarReceta.cbxUnidadPorcion.SelectedValue = "g."
                    Else
                        EditarReceta.numTamPor.Value = tamPorcion / 1000
                        EditarReceta.cbxUnidadPorcion.SelectedValue = "kg."
                    End If

                End If

            End If

        End If

    End Sub

    Public Sub ckbxSeleccionar_CheckedChanged(sender As Object, e As EventArgs)
        Dim checkBoxCat As CheckBox = sender
        Dim grbxCategoria As GroupBox = checkBoxCat.Parent
        Dim categoriasFLP As FlowLayoutPanel = grbxCategoria.Parent
        Dim ventana As Form = categoriasFLP.Parent

        Dim grbxCat As GroupBox
        Dim chbxCat As CheckBox

        Dim recetaDib As GroupBox
        Dim lblNombreRecetaDib As Label

        Dim noSelec As Boolean = True

        Inicio.SplitContainerDetallesR.Panel2Collapsed = True

        If ventana.Text.Equals("Inicio") Then
            Inicio.RecetasFLP.Controls.Clear()

            For Each grbxCat In Inicio.CategoriasInFLP.Controls
                chbxCat = grbxCat.Controls.Item(0)
                If chbxCat.Checked Then
                    For Each receta In Inicio.RecetasDataSet1.recetas_de_categoria
                        If receta.ID_Categoria = Integer.Parse(chbxCat.Tag) Then
                            If Not Inicio.RecetasFLP.Controls.Count = 0 Then
                                For Each recetaDib In Inicio.RecetasFLP.Controls
                                    lblNombreRecetaDib = recetaDib.Controls.Item(0)
                                    If Not receta.Receta.Equals(lblNombreRecetaDib.Text) Then
                                        dibujarRecetas(receta.ID_Receta, receta.Receta)
                                    End If
                                Next
                            Else
                                dibujarRecetas(receta.ID_Receta, receta.Receta)
                            End If
                        End If
                    Next
                End If

                noSelec = noSelec And Not chbxCat.Checked

            Next

            If noSelec Then
                Inicio.RecetasFLP.Controls.Clear()
                For Each receta In Inicio.RecetasDataSet1.recetas
                    dibujarRecetas(receta.ID, receta.Nombre)
                Next
            End If

        End If

    End Sub

End Module
