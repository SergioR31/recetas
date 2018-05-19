<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoIngrediente
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
        Me.btnGuardarIngrediente = New System.Windows.Forms.Button()
        Me.txtNombreNuIn = New System.Windows.Forms.TextBox()
        Me.numPrecioUniNuIn = New System.Windows.Forms.NumericUpDown()
        Me.cbxUnidadNi = New System.Windows.Forms.ComboBox()
        Me.UnidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecetasDataSet1 = New RecetasWF.recetasDataSet()
        Me.numRenNuIn = New System.Windows.Forms.NumericUpDown()
        Me.numPrecioReNuIn = New System.Windows.Forms.NumericUpDown()
        Me.lblNombreNuevoIn = New System.Windows.Forms.Label()
        Me.lblUnidadNuevoIn = New System.Windows.Forms.Label()
        Me.lblPrecioUnNuIn = New System.Windows.Forms.Label()
        Me.lblRendiNuIn = New System.Windows.Forms.Label()
        Me.lblPrecioReNuIn = New System.Windows.Forms.Label()
        Me.IngredientesTableAdapter1 = New RecetasWF.recetasDataSetTableAdapters.ingredientesTableAdapter()
        Me.UnidadesTableAdapter = New RecetasWF.recetasDataSetTableAdapters.unidadesTableAdapter()
        CType(Me.numPrecioUniNuIn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecetasDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numRenNuIn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPrecioReNuIn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGuardarIngrediente
        '
        Me.btnGuardarIngrediente.Location = New System.Drawing.Point(372, 330)
        Me.btnGuardarIngrediente.Name = "btnGuardarIngrediente"
        Me.btnGuardarIngrediente.Size = New System.Drawing.Size(91, 35)
        Me.btnGuardarIngrediente.TabIndex = 0
        Me.btnGuardarIngrediente.Text = "Guardar"
        Me.btnGuardarIngrediente.UseVisualStyleBackColor = True
        '
        'txtNombreNuIn
        '
        Me.txtNombreNuIn.Location = New System.Drawing.Point(80, 85)
        Me.txtNombreNuIn.Name = "txtNombreNuIn"
        Me.txtNombreNuIn.Size = New System.Drawing.Size(100, 22)
        Me.txtNombreNuIn.TabIndex = 1
        '
        'numPrecioUniNuIn
        '
        Me.numPrecioUniNuIn.DecimalPlaces = 2
        Me.numPrecioUniNuIn.Location = New System.Drawing.Point(360, 85)
        Me.numPrecioUniNuIn.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.numPrecioUniNuIn.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numPrecioUniNuIn.Name = "numPrecioUniNuIn"
        Me.numPrecioUniNuIn.Size = New System.Drawing.Size(120, 22)
        Me.numPrecioUniNuIn.TabIndex = 2
        Me.numPrecioUniNuIn.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cbxUnidadNi
        '
        Me.cbxUnidadNi.DataSource = Me.UnidadesBindingSource
        Me.cbxUnidadNi.DisplayMember = "Unidad"
        Me.cbxUnidadNi.FormattingEnabled = True
        Me.cbxUnidadNi.Location = New System.Drawing.Point(207, 83)
        Me.cbxUnidadNi.Name = "cbxUnidadNi"
        Me.cbxUnidadNi.Size = New System.Drawing.Size(121, 24)
        Me.cbxUnidadNi.TabIndex = 3
        Me.cbxUnidadNi.ValueMember = "Unidad"
        '
        'UnidadesBindingSource
        '
        Me.UnidadesBindingSource.DataMember = "unidades"
        Me.UnidadesBindingSource.DataSource = Me.RecetasDataSet1
        '
        'RecetasDataSet1
        '
        Me.RecetasDataSet1.DataSetName = "recetasDataSet"
        Me.RecetasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'numRenNuIn
        '
        Me.numRenNuIn.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numRenNuIn.Location = New System.Drawing.Point(501, 83)
        Me.numRenNuIn.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numRenNuIn.Name = "numRenNuIn"
        Me.numRenNuIn.Size = New System.Drawing.Size(120, 22)
        Me.numRenNuIn.TabIndex = 2
        Me.numRenNuIn.Value = New Decimal(New Integer() {90, 0, 0, 0})
        '
        'numPrecioReNuIn
        '
        Me.numPrecioReNuIn.DecimalPlaces = 2
        Me.numPrecioReNuIn.Location = New System.Drawing.Point(640, 83)
        Me.numPrecioReNuIn.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.numPrecioReNuIn.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numPrecioReNuIn.Name = "numPrecioReNuIn"
        Me.numPrecioReNuIn.Size = New System.Drawing.Size(120, 22)
        Me.numPrecioReNuIn.TabIndex = 2
        Me.numPrecioReNuIn.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblNombreNuevoIn
        '
        Me.lblNombreNuevoIn.AutoSize = True
        Me.lblNombreNuevoIn.Location = New System.Drawing.Point(80, 48)
        Me.lblNombreNuevoIn.Name = "lblNombreNuevoIn"
        Me.lblNombreNuevoIn.Size = New System.Drawing.Size(58, 17)
        Me.lblNombreNuevoIn.TabIndex = 4
        Me.lblNombreNuevoIn.Text = "Nombre"
        '
        'lblUnidadNuevoIn
        '
        Me.lblUnidadNuevoIn.AutoSize = True
        Me.lblUnidadNuevoIn.Location = New System.Drawing.Point(204, 48)
        Me.lblUnidadNuevoIn.Name = "lblUnidadNuevoIn"
        Me.lblUnidadNuevoIn.Size = New System.Drawing.Size(53, 17)
        Me.lblUnidadNuevoIn.TabIndex = 4
        Me.lblUnidadNuevoIn.Text = "Unidad"
        '
        'lblPrecioUnNuIn
        '
        Me.lblPrecioUnNuIn.AutoSize = True
        Me.lblPrecioUnNuIn.Location = New System.Drawing.Point(357, 48)
        Me.lblPrecioUnNuIn.Name = "lblPrecioUnNuIn"
        Me.lblPrecioUnNuIn.Size = New System.Drawing.Size(123, 17)
        Me.lblPrecioUnNuIn.TabIndex = 4
        Me.lblPrecioUnNuIn.Text = "Precio Unitario ($)"
        '
        'lblRendiNuIn
        '
        Me.lblRendiNuIn.AutoSize = True
        Me.lblRendiNuIn.Location = New System.Drawing.Point(498, 48)
        Me.lblRendiNuIn.Name = "lblRendiNuIn"
        Me.lblRendiNuIn.Size = New System.Drawing.Size(113, 17)
        Me.lblRendiNuIn.TabIndex = 4
        Me.lblRendiNuIn.Text = "Rendimiento (%)"
        '
        'lblPrecioReNuIn
        '
        Me.lblPrecioReNuIn.AutoSize = True
        Me.lblPrecioReNuIn.Location = New System.Drawing.Point(637, 48)
        Me.lblPrecioReNuIn.Name = "lblPrecioReNuIn"
        Me.lblPrecioReNuIn.Size = New System.Drawing.Size(103, 17)
        Me.lblPrecioReNuIn.TabIndex = 4
        Me.lblPrecioReNuIn.Text = "Precio Real ($)"
        '
        'IngredientesTableAdapter1
        '
        Me.IngredientesTableAdapter1.ClearBeforeFill = True
        '
        'UnidadesTableAdapter
        '
        Me.UnidadesTableAdapter.ClearBeforeFill = True
        '
        'NuevoIngrediente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblPrecioReNuIn)
        Me.Controls.Add(Me.lblRendiNuIn)
        Me.Controls.Add(Me.lblPrecioUnNuIn)
        Me.Controls.Add(Me.lblUnidadNuevoIn)
        Me.Controls.Add(Me.lblNombreNuevoIn)
        Me.Controls.Add(Me.cbxUnidadNi)
        Me.Controls.Add(Me.numPrecioReNuIn)
        Me.Controls.Add(Me.numRenNuIn)
        Me.Controls.Add(Me.numPrecioUniNuIn)
        Me.Controls.Add(Me.txtNombreNuIn)
        Me.Controls.Add(Me.btnGuardarIngrediente)
        Me.Name = "NuevoIngrediente"
        Me.Text = "Nuevo Ingrediente"
        CType(Me.numPrecioUniNuIn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecetasDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numRenNuIn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPrecioReNuIn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGuardarIngrediente As Button
    Friend WithEvents txtNombreNuIn As TextBox
    Friend WithEvents numPrecioUniNuIn As NumericUpDown
    Friend WithEvents cbxUnidadNi As ComboBox
    Friend WithEvents numRenNuIn As NumericUpDown
    Friend WithEvents numPrecioReNuIn As NumericUpDown
    Friend WithEvents lblNombreNuevoIn As Label
    Friend WithEvents lblUnidadNuevoIn As Label
    Friend WithEvents lblPrecioUnNuIn As Label
    Friend WithEvents lblRendiNuIn As Label
    Friend WithEvents lblPrecioReNuIn As Label
    Friend WithEvents RecetasDataSet1 As recetasDataSet
    Friend WithEvents IngredientesTableAdapter1 As recetasDataSetTableAdapters.ingredientesTableAdapter
    Friend WithEvents UnidadesBindingSource As BindingSource
    Friend WithEvents UnidadesTableAdapter As recetasDataSetTableAdapters.unidadesTableAdapter
End Class
