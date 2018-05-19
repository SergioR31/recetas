<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarReceta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RecetasDataSet1 = New RecetasWF.recetasDataSet()
        Me.IngredientesTableAdapter1 = New RecetasWF.recetasDataSetTableAdapters.ingredientesTableAdapter()
        Me.IngredientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnidadesTableAdapter = New RecetasWF.recetasDataSetTableAdapters.unidadesTableAdapter()
        Me.CategoriasTableAdapter1 = New RecetasWF.recetasDataSetTableAdapters.categoriasTableAdapter()
        Me.UnidadesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Receta_ingredientesTableAdapter1 = New RecetasWF.recetasDataSetTableAdapters.receta_ingredientesTableAdapter()
        Me.RecetasTableAdapter1 = New RecetasWF.recetasDataSetTableAdapters.recetasTableAdapter()
        Me.UnidadesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Categoria_recetasTableAdapter1 = New RecetasWF.recetasDataSetTableAdapters.categoria_recetasTableAdapter()
        Me.SplitContainerPorciones = New System.Windows.Forms.SplitContainer()
        Me.ckbxPorciones = New System.Windows.Forms.CheckBox()
        Me.cbxUnidadPorcion = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.numTamPor = New System.Windows.Forms.NumericUpDown()
        Me.numPorciones = New System.Windows.Forms.NumericUpDown()
        Me.SplitContainerPeso = New System.Windows.Forms.SplitContainer()
        Me.ckbxPeso = New System.Windows.Forms.CheckBox()
        Me.cbxUnidadPeso = New System.Windows.Forms.ComboBox()
        Me.numPeso = New System.Windows.Forms.NumericUpDown()
        Me.numCosto = New System.Windows.Forms.NumericUpDown()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.numCantidadNI = New System.Windows.Forms.NumericUpDown()
        Me.cbxNombreNI = New System.Windows.Forms.ComboBox()
        Me.btnAgregarI = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxUnidadNI = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numHoras = New System.Windows.Forms.NumericUpDown()
        Me.numMinutos = New System.Windows.Forms.NumericUpDown()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtTips = New System.Windows.Forms.TextBox()
        Me.txtInstrucciones = New System.Windows.Forms.TextBox()
        Me.txtHistoria = New System.Windows.Forms.TextBox()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtNuevaCategoria = New System.Windows.Forms.TextBox()
        Me.btnAgregarCat = New System.Windows.Forms.Button()
        Me.CategoriasERFLP = New System.Windows.Forms.FlowLayoutPanel()
        Me.EditarIngredientesFLP = New System.Windows.Forms.FlowLayoutPanel()
        Me.Ingredientes_de_recetaTableAdapter1 = New RecetasWF.recetasDataSetTableAdapters.ingredientes_de_recetaTableAdapter()
        Me.cbxGrados = New System.Windows.Forms.ComboBox()
        Me.numTemperatura = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.RecetasDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IngredientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnidadesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnidadesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerPorciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerPorciones.Panel1.SuspendLayout()
        Me.SplitContainerPorciones.Panel2.SuspendLayout()
        Me.SplitContainerPorciones.SuspendLayout()
        CType(Me.numTamPor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPorciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerPeso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerPeso.Panel1.SuspendLayout()
        Me.SplitContainerPeso.Panel2.SuspendLayout()
        Me.SplitContainerPeso.SuspendLayout()
        CType(Me.numPeso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCantidadNI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numHoras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMinutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTemperatura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RecetasDataSet1
        '
        Me.RecetasDataSet1.DataSetName = "recetasDataSet"
        Me.RecetasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IngredientesTableAdapter1
        '
        Me.IngredientesTableAdapter1.ClearBeforeFill = True
        '
        'IngredientesBindingSource
        '
        Me.IngredientesBindingSource.DataMember = "ingredientes"
        Me.IngredientesBindingSource.DataSource = Me.RecetasDataSet1
        '
        'UnidadesBindingSource
        '
        Me.UnidadesBindingSource.DataMember = "unidades"
        Me.UnidadesBindingSource.DataSource = Me.RecetasDataSet1
        '
        'UnidadesTableAdapter
        '
        Me.UnidadesTableAdapter.ClearBeforeFill = True
        '
        'CategoriasTableAdapter1
        '
        Me.CategoriasTableAdapter1.ClearBeforeFill = True
        '
        'UnidadesBindingSource1
        '
        Me.UnidadesBindingSource1.DataMember = "unidades"
        Me.UnidadesBindingSource1.DataSource = Me.RecetasDataSet1
        '
        'Receta_ingredientesTableAdapter1
        '
        Me.Receta_ingredientesTableAdapter1.ClearBeforeFill = True
        '
        'RecetasTableAdapter1
        '
        Me.RecetasTableAdapter1.ClearBeforeFill = True
        '
        'UnidadesBindingSource2
        '
        Me.UnidadesBindingSource2.DataMember = "unidades"
        Me.UnidadesBindingSource2.DataSource = Me.RecetasDataSet1
        '
        'Categoria_recetasTableAdapter1
        '
        Me.Categoria_recetasTableAdapter1.ClearBeforeFill = True
        '
        'SplitContainerPorciones
        '
        Me.SplitContainerPorciones.Location = New System.Drawing.Point(911, 12)
        Me.SplitContainerPorciones.Name = "SplitContainerPorciones"
        Me.SplitContainerPorciones.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerPorciones.Panel1
        '
        Me.SplitContainerPorciones.Panel1.Controls.Add(Me.ckbxPorciones)
        '
        'SplitContainerPorciones.Panel2
        '
        Me.SplitContainerPorciones.Panel2.Controls.Add(Me.cbxUnidadPorcion)
        Me.SplitContainerPorciones.Panel2.Controls.Add(Me.Label11)
        Me.SplitContainerPorciones.Panel2.Controls.Add(Me.numTamPor)
        Me.SplitContainerPorciones.Panel2.Controls.Add(Me.numPorciones)
        Me.SplitContainerPorciones.Size = New System.Drawing.Size(181, 121)
        Me.SplitContainerPorciones.SplitterDistance = 31
        Me.SplitContainerPorciones.TabIndex = 43
        '
        'ckbxPorciones
        '
        Me.ckbxPorciones.AutoSize = True
        Me.ckbxPorciones.Location = New System.Drawing.Point(37, 3)
        Me.ckbxPorciones.Name = "ckbxPorciones"
        Me.ckbxPorciones.Size = New System.Drawing.Size(93, 21)
        Me.ckbxPorciones.TabIndex = 12
        Me.ckbxPorciones.Text = "Porciones"
        Me.ckbxPorciones.UseVisualStyleBackColor = True
        '
        'cbxUnidadPorcion
        '
        Me.cbxUnidadPorcion.DataSource = Me.UnidadesBindingSource1
        Me.cbxUnidadPorcion.DisplayMember = "Unidad"
        Me.cbxUnidadPorcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxUnidadPorcion.FormattingEnabled = True
        Me.cbxUnidadPorcion.Location = New System.Drawing.Point(81, 48)
        Me.cbxUnidadPorcion.Name = "cbxUnidadPorcion"
        Me.cbxUnidadPorcion.Size = New System.Drawing.Size(91, 24)
        Me.cbxUnidadPorcion.TabIndex = 6
        Me.cbxUnidadPorcion.ValueMember = "Unidad"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 17)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Tamaño"
        '
        'numTamPor
        '
        Me.numTamPor.DecimalPlaces = 2
        Me.numTamPor.Location = New System.Drawing.Point(3, 48)
        Me.numTamPor.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.numTamPor.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numTamPor.Name = "numTamPor"
        Me.numTamPor.Size = New System.Drawing.Size(72, 22)
        Me.numTamPor.TabIndex = 11
        Me.numTamPor.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numPorciones
        '
        Me.numPorciones.Location = New System.Drawing.Point(3, 3)
        Me.numPorciones.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.numPorciones.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numPorciones.Name = "numPorciones"
        Me.numPorciones.Size = New System.Drawing.Size(72, 22)
        Me.numPorciones.TabIndex = 10
        Me.numPorciones.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'SplitContainerPeso
        '
        Me.SplitContainerPeso.Location = New System.Drawing.Point(716, 12)
        Me.SplitContainerPeso.Name = "SplitContainerPeso"
        Me.SplitContainerPeso.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerPeso.Panel1
        '
        Me.SplitContainerPeso.Panel1.Controls.Add(Me.ckbxPeso)
        '
        'SplitContainerPeso.Panel2
        '
        Me.SplitContainerPeso.Panel2.Controls.Add(Me.cbxUnidadPeso)
        Me.SplitContainerPeso.Panel2.Controls.Add(Me.numPeso)
        Me.SplitContainerPeso.Size = New System.Drawing.Size(183, 65)
        Me.SplitContainerPeso.SplitterDistance = 32
        Me.SplitContainerPeso.TabIndex = 42
        '
        'ckbxPeso
        '
        Me.ckbxPeso.AutoSize = True
        Me.ckbxPeso.Location = New System.Drawing.Point(60, 3)
        Me.ckbxPeso.Name = "ckbxPeso"
        Me.ckbxPeso.Size = New System.Drawing.Size(62, 21)
        Me.ckbxPeso.TabIndex = 12
        Me.ckbxPeso.Text = "Peso"
        Me.ckbxPeso.UseVisualStyleBackColor = True
        '
        'cbxUnidadPeso
        '
        Me.cbxUnidadPeso.DataSource = Me.UnidadesBindingSource2
        Me.cbxUnidadPeso.DisplayMember = "Unidad"
        Me.cbxUnidadPeso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxUnidadPeso.FormattingEnabled = True
        Me.cbxUnidadPeso.Location = New System.Drawing.Point(88, 0)
        Me.cbxUnidadPeso.Name = "cbxUnidadPeso"
        Me.cbxUnidadPeso.Size = New System.Drawing.Size(91, 24)
        Me.cbxUnidadPeso.TabIndex = 6
        Me.cbxUnidadPeso.ValueMember = "Unidad"
        '
        'numPeso
        '
        Me.numPeso.DecimalPlaces = 2
        Me.numPeso.Location = New System.Drawing.Point(3, 3)
        Me.numPeso.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.numPeso.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numPeso.Name = "numPeso"
        Me.numPeso.Size = New System.Drawing.Size(79, 22)
        Me.numPeso.TabIndex = 11
        Me.numPeso.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numCosto
        '
        Me.numCosto.DecimalPlaces = 2
        Me.numCosto.Location = New System.Drawing.Point(866, 196)
        Me.numCosto.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.numCosto.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numCosto.Name = "numCosto"
        Me.numCosto.Size = New System.Drawing.Size(120, 22)
        Me.numCosto.TabIndex = 41
        Me.numCosto.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(543, 525)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(183, 54)
        Me.btnGuardar.TabIndex = 40
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'numCantidadNI
        '
        Me.numCantidadNI.DecimalPlaces = 2
        Me.numCantidadNI.Location = New System.Drawing.Point(420, 42)
        Me.numCantidadNI.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.numCantidadNI.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numCantidadNI.Name = "numCantidadNI"
        Me.numCantidadNI.Size = New System.Drawing.Size(76, 22)
        Me.numCantidadNI.TabIndex = 11
        Me.numCantidadNI.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cbxNombreNI
        '
        Me.cbxNombreNI.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbxNombreNI.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxNombreNI.DataSource = Me.IngredientesBindingSource
        Me.cbxNombreNI.DisplayMember = "Nombre"
        Me.cbxNombreNI.FormattingEnabled = True
        Me.cbxNombreNI.Location = New System.Drawing.Point(295, 41)
        Me.cbxNombreNI.Name = "cbxNombreNI"
        Me.cbxNombreNI.Size = New System.Drawing.Size(121, 24)
        Me.cbxNombreNI.TabIndex = 4
        Me.cbxNombreNI.ValueMember = "ID"
        '
        'btnAgregarI
        '
        Me.btnAgregarI.Location = New System.Drawing.Point(597, 40)
        Me.btnAgregarI.Name = "btnAgregarI"
        Me.btnAgregarI.Size = New System.Drawing.Size(90, 24)
        Me.btnAgregarI.TabIndex = 1
        Me.btnAgregarI.Text = "Agregar"
        Me.btnAgregarI.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(292, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ingrediente"
        '
        'cbxUnidadNI
        '
        Me.cbxUnidadNI.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbxUnidadNI.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxUnidadNI.DataSource = Me.UnidadesBindingSource
        Me.cbxUnidadNI.DisplayMember = "Unidad"
        Me.cbxUnidadNI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxUnidadNI.FormattingEnabled = True
        Me.cbxUnidadNI.Location = New System.Drawing.Point(502, 40)
        Me.cbxUnidadNI.Name = "cbxUnidadNI"
        Me.cbxUnidadNI.Size = New System.Drawing.Size(89, 24)
        Me.cbxUnidadNI.TabIndex = 5
        Me.cbxUnidadNI.ValueMember = "Unidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(417, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cantidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(498, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Unidad"
        '
        'numHoras
        '
        Me.numHoras.Location = New System.Drawing.Point(721, 137)
        Me.numHoras.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.numHoras.Name = "numHoras"
        Me.numHoras.Size = New System.Drawing.Size(48, 22)
        Me.numHoras.TabIndex = 38
        '
        'numMinutos
        '
        Me.numMinutos.Location = New System.Drawing.Point(776, 137)
        Me.numMinutos.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.numMinutos.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numMinutos.Name = "numMinutos"
        Me.numMinutos.Size = New System.Drawing.Size(48, 22)
        Me.numMinutos.TabIndex = 37
        Me.numMinutos.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(770, 118)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(57, 17)
        Me.Label19.TabIndex = 35
        Me.Label19.Text = "Minutos"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(718, 117)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(46, 17)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Horas"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(716, 95)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(155, 17)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "Tiempo de preparacion"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(863, 176)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 17)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Costo"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(721, 236)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 17)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Tips"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(322, 245)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(144, 17)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Modo de Preparacion"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 17)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Historia"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 17)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Origen"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 17)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Categoria"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 17)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Nombre"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 485)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(114, 17)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "Nueva Categoria"
        '
        'txtTips
        '
        Me.txtTips.Location = New System.Drawing.Point(724, 266)
        Me.txtTips.Multiline = True
        Me.txtTips.Name = "txtTips"
        Me.txtTips.Size = New System.Drawing.Size(273, 57)
        Me.txtTips.TabIndex = 24
        '
        'txtInstrucciones
        '
        Me.txtInstrucciones.Location = New System.Drawing.Point(325, 275)
        Me.txtInstrucciones.Multiline = True
        Me.txtInstrucciones.Name = "txtInstrucciones"
        Me.txtInstrucciones.Size = New System.Drawing.Size(362, 203)
        Me.txtInstrucciones.TabIndex = 23
        '
        'txtHistoria
        '
        Me.txtHistoria.Location = New System.Drawing.Point(9, 95)
        Me.txtHistoria.Multiline = True
        Me.txtHistoria.Name = "txtHistoria"
        Me.txtHistoria.Size = New System.Drawing.Size(264, 99)
        Me.txtHistoria.TabIndex = 22
        '
        'txtOrigen
        '
        Me.txtOrigen.Location = New System.Drawing.Point(173, 47)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(100, 22)
        Me.txtOrigen.TabIndex = 21
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(173, 19)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 22)
        Me.txtNombre.TabIndex = 19
        '
        'txtNuevaCategoria
        '
        Me.txtNuevaCategoria.Location = New System.Drawing.Point(9, 505)
        Me.txtNuevaCategoria.Name = "txtNuevaCategoria"
        Me.txtNuevaCategoria.Size = New System.Drawing.Size(130, 22)
        Me.txtNuevaCategoria.TabIndex = 18
        '
        'btnAgregarCat
        '
        Me.btnAgregarCat.Location = New System.Drawing.Point(161, 503)
        Me.btnAgregarCat.Name = "btnAgregarCat"
        Me.btnAgregarCat.Size = New System.Drawing.Size(90, 24)
        Me.btnAgregarCat.TabIndex = 17
        Me.btnAgregarCat.Text = "Agregar"
        Me.btnAgregarCat.UseVisualStyleBackColor = True
        '
        'CategoriasERFLP
        '
        Me.CategoriasERFLP.AutoScroll = True
        Me.CategoriasERFLP.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.CategoriasERFLP.Location = New System.Drawing.Point(12, 245)
        Me.CategoriasERFLP.Name = "CategoriasERFLP"
        Me.CategoriasERFLP.Size = New System.Drawing.Size(264, 217)
        Me.CategoriasERFLP.TabIndex = 16
        Me.CategoriasERFLP.WrapContents = False
        '
        'EditarIngredientesFLP
        '
        Me.EditarIngredientesFLP.AutoScroll = True
        Me.EditarIngredientesFLP.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.EditarIngredientesFLP.Location = New System.Drawing.Point(323, 71)
        Me.EditarIngredientesFLP.Name = "EditarIngredientesFLP"
        Me.EditarIngredientesFLP.Size = New System.Drawing.Size(324, 149)
        Me.EditarIngredientesFLP.TabIndex = 15
        Me.EditarIngredientesFLP.WrapContents = False
        '
        'Ingredientes_de_recetaTableAdapter1
        '
        Me.Ingredientes_de_recetaTableAdapter1.ClearBeforeFill = True
        '
        'cbxGrados
        '
        Me.cbxGrados.FormattingEnabled = True
        Me.cbxGrados.Items.AddRange(New Object() {"°C", "°F"})
        Me.cbxGrados.Location = New System.Drawing.Point(783, 196)
        Me.cbxGrados.Name = "cbxGrados"
        Me.cbxGrados.Size = New System.Drawing.Size(55, 24)
        Me.cbxGrados.TabIndex = 46
        '
        'numTemperatura
        '
        Me.numTemperatura.Location = New System.Drawing.Point(722, 196)
        Me.numTemperatura.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.numTemperatura.Name = "numTemperatura"
        Me.numTemperatura.Size = New System.Drawing.Size(55, 22)
        Me.numTemperatura.TabIndex = 45
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(719, 166)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 17)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Temperatura"
        '
        'EditarReceta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 598)
        Me.Controls.Add(Me.cbxGrados)
        Me.Controls.Add(Me.numTemperatura)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.numCantidadNI)
        Me.Controls.Add(Me.SplitContainerPorciones)
        Me.Controls.Add(Me.cbxNombreNI)
        Me.Controls.Add(Me.SplitContainerPeso)
        Me.Controls.Add(Me.btnAgregarI)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.numCosto)
        Me.Controls.Add(Me.cbxUnidadNI)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.numHoras)
        Me.Controls.Add(Me.numMinutos)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtTips)
        Me.Controls.Add(Me.txtInstrucciones)
        Me.Controls.Add(Me.txtHistoria)
        Me.Controls.Add(Me.txtOrigen)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtNuevaCategoria)
        Me.Controls.Add(Me.btnAgregarCat)
        Me.Controls.Add(Me.CategoriasERFLP)
        Me.Controls.Add(Me.EditarIngredientesFLP)
        Me.Name = "EditarReceta"
        Me.Text = "Editar Receta"
        CType(Me.RecetasDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IngredientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnidadesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnidadesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerPorciones.Panel1.ResumeLayout(False)
        Me.SplitContainerPorciones.Panel1.PerformLayout()
        Me.SplitContainerPorciones.Panel2.ResumeLayout(False)
        Me.SplitContainerPorciones.Panel2.PerformLayout()
        CType(Me.SplitContainerPorciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerPorciones.ResumeLayout(False)
        CType(Me.numTamPor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPorciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerPeso.Panel1.ResumeLayout(False)
        Me.SplitContainerPeso.Panel1.PerformLayout()
        Me.SplitContainerPeso.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerPeso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerPeso.ResumeLayout(False)
        CType(Me.numPeso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCantidadNI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numHoras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMinutos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTemperatura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RecetasDataSet1 As recetasDataSet
    Friend WithEvents IngredientesTableAdapter1 As recetasDataSetTableAdapters.ingredientesTableAdapter
    Friend WithEvents IngredientesBindingSource As BindingSource
    Friend WithEvents UnidadesBindingSource As BindingSource
    Friend WithEvents UnidadesTableAdapter As recetasDataSetTableAdapters.unidadesTableAdapter
    Friend WithEvents CategoriasTableAdapter1 As recetasDataSetTableAdapters.categoriasTableAdapter
    Friend WithEvents UnidadesBindingSource1 As BindingSource
    Friend WithEvents Receta_ingredientesTableAdapter1 As recetasDataSetTableAdapters.receta_ingredientesTableAdapter
    Friend WithEvents RecetasTableAdapter1 As recetasDataSetTableAdapters.recetasTableAdapter
    Friend WithEvents UnidadesBindingSource2 As BindingSource
    Friend WithEvents Categoria_recetasTableAdapter1 As recetasDataSetTableAdapters.categoria_recetasTableAdapter
    Friend WithEvents SplitContainerPorciones As SplitContainer
    Friend WithEvents ckbxPorciones As CheckBox
    Friend WithEvents cbxUnidadPorcion As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents numTamPor As NumericUpDown
    Friend WithEvents numPorciones As NumericUpDown
    Friend WithEvents SplitContainerPeso As SplitContainer
    Friend WithEvents ckbxPeso As CheckBox
    Friend WithEvents cbxUnidadPeso As ComboBox
    Friend WithEvents numPeso As NumericUpDown
    Friend WithEvents numCosto As NumericUpDown
    Friend WithEvents btnGuardar As Button
    Friend WithEvents numCantidadNI As NumericUpDown
    Friend WithEvents cbxNombreNI As ComboBox
    Friend WithEvents btnAgregarI As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxUnidadNI As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents numHoras As NumericUpDown
    Friend WithEvents numMinutos As NumericUpDown
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtTips As TextBox
    Friend WithEvents txtInstrucciones As TextBox
    Friend WithEvents txtHistoria As TextBox
    Friend WithEvents txtOrigen As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtNuevaCategoria As TextBox
    Friend WithEvents btnAgregarCat As Button
    Friend WithEvents CategoriasERFLP As FlowLayoutPanel
    Friend WithEvents EditarIngredientesFLP As FlowLayoutPanel
    Friend WithEvents Ingredientes_de_recetaTableAdapter1 As recetasDataSetTableAdapters.ingredientes_de_recetaTableAdapter
    Friend WithEvents cbxGrados As ComboBox
    Friend WithEvents numTemperatura As NumericUpDown
    Friend WithEvents Label9 As Label
End Class
