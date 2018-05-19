<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingredientes
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
        Me.IngredientesFLP = New System.Windows.Forms.FlowLayoutPanel()
        Me.RecetasDataSet1 = New RecetasWF.recetasDataSet()
        Me.IngredientesTableAdapter1 = New RecetasWF.recetasDataSetTableAdapters.ingredientesTableAdapter()
        Me.UnidadesTableAdapter1 = New RecetasWF.recetasDataSetTableAdapters.unidadesTableAdapter()
        Me.lblNombreIngrediente = New System.Windows.Forms.Label()
        Me.lblRendimientoIn = New System.Windows.Forms.Label()
        Me.lblUnidadIn = New System.Windows.Forms.Label()
        Me.lblPrecioUniIn = New System.Windows.Forms.Label()
        Me.btnEditarIngrediente = New System.Windows.Forms.Button()
        Me.btnNuevoIngrediente = New System.Windows.Forms.Button()
        Me.btnEliminarIngrediente = New System.Windows.Forms.Button()
        Me.Receta_ingredientesTableAdapter1 = New RecetasWF.recetasDataSetTableAdapters.receta_ingredientesTableAdapter()
        Me.Ingredientes_de_recetaTableAdapter1 = New RecetasWF.recetasDataSetTableAdapters.ingredientes_de_recetaTableAdapter()
        Me.lblPrecioRealIn = New System.Windows.Forms.Label()
        CType(Me.RecetasDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IngredientesFLP
        '
        Me.IngredientesFLP.AutoScroll = True
        Me.IngredientesFLP.Location = New System.Drawing.Point(12, 85)
        Me.IngredientesFLP.Name = "IngredientesFLP"
        Me.IngredientesFLP.Size = New System.Drawing.Size(245, 287)
        Me.IngredientesFLP.TabIndex = 0
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
        'UnidadesTableAdapter1
        '
        Me.UnidadesTableAdapter1.ClearBeforeFill = True
        '
        'lblNombreIngrediente
        '
        Me.lblNombreIngrediente.AutoSize = True
        Me.lblNombreIngrediente.Location = New System.Drawing.Point(298, 85)
        Me.lblNombreIngrediente.Name = "lblNombreIngrediente"
        Me.lblNombreIngrediente.Size = New System.Drawing.Size(51, 17)
        Me.lblNombreIngrediente.TabIndex = 1
        Me.lblNombreIngrediente.Text = "Label1"
        '
        'lblRendimientoIn
        '
        Me.lblRendimientoIn.AutoSize = True
        Me.lblRendimientoIn.Location = New System.Drawing.Point(531, 85)
        Me.lblRendimientoIn.Name = "lblRendimientoIn"
        Me.lblRendimientoIn.Size = New System.Drawing.Size(51, 17)
        Me.lblRendimientoIn.TabIndex = 2
        Me.lblRendimientoIn.Text = "Label1"
        '
        'lblUnidadIn
        '
        Me.lblUnidadIn.AutoSize = True
        Me.lblUnidadIn.Location = New System.Drawing.Point(384, 85)
        Me.lblUnidadIn.Name = "lblUnidadIn"
        Me.lblUnidadIn.Size = New System.Drawing.Size(51, 17)
        Me.lblUnidadIn.TabIndex = 3
        Me.lblUnidadIn.Text = "Label1"
        '
        'lblPrecioUniIn
        '
        Me.lblPrecioUniIn.AutoSize = True
        Me.lblPrecioUniIn.Location = New System.Drawing.Point(461, 85)
        Me.lblPrecioUniIn.Name = "lblPrecioUniIn"
        Me.lblPrecioUniIn.Size = New System.Drawing.Size(51, 17)
        Me.lblPrecioUniIn.TabIndex = 4
        Me.lblPrecioUniIn.Text = "Label1"
        '
        'btnEditarIngrediente
        '
        Me.btnEditarIngrediente.Location = New System.Drawing.Point(725, 98)
        Me.btnEditarIngrediente.Name = "btnEditarIngrediente"
        Me.btnEditarIngrediente.Size = New System.Drawing.Size(141, 34)
        Me.btnEditarIngrediente.TabIndex = 5
        Me.btnEditarIngrediente.Text = "Editar Ingrediente"
        Me.btnEditarIngrediente.UseVisualStyleBackColor = True
        '
        'btnNuevoIngrediente
        '
        Me.btnNuevoIngrediente.Location = New System.Drawing.Point(12, 12)
        Me.btnNuevoIngrediente.Name = "btnNuevoIngrediente"
        Me.btnNuevoIngrediente.Size = New System.Drawing.Size(141, 37)
        Me.btnNuevoIngrediente.TabIndex = 6
        Me.btnNuevoIngrediente.Text = "Nuevo Ingrediente"
        Me.btnNuevoIngrediente.UseVisualStyleBackColor = True
        '
        'btnEliminarIngrediente
        '
        Me.btnEliminarIngrediente.Location = New System.Drawing.Point(725, 138)
        Me.btnEliminarIngrediente.Name = "btnEliminarIngrediente"
        Me.btnEliminarIngrediente.Size = New System.Drawing.Size(141, 34)
        Me.btnEliminarIngrediente.TabIndex = 5
        Me.btnEliminarIngrediente.Text = "Eliminar Ingrediente"
        Me.btnEliminarIngrediente.UseVisualStyleBackColor = True
        '
        'Receta_ingredientesTableAdapter1
        '
        Me.Receta_ingredientesTableAdapter1.ClearBeforeFill = True
        '
        'Ingredientes_de_recetaTableAdapter1
        '
        Me.Ingredientes_de_recetaTableAdapter1.ClearBeforeFill = True
        '
        'lblPrecioRealIn
        '
        Me.lblPrecioRealIn.AutoSize = True
        Me.lblPrecioRealIn.Location = New System.Drawing.Point(603, 85)
        Me.lblPrecioRealIn.Name = "lblPrecioRealIn"
        Me.lblPrecioRealIn.Size = New System.Drawing.Size(51, 17)
        Me.lblPrecioRealIn.TabIndex = 2
        Me.lblPrecioRealIn.Text = "Label1"
        '
        'Ingredientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 485)
        Me.Controls.Add(Me.btnNuevoIngrediente)
        Me.Controls.Add(Me.btnEliminarIngrediente)
        Me.Controls.Add(Me.btnEditarIngrediente)
        Me.Controls.Add(Me.lblPrecioUniIn)
        Me.Controls.Add(Me.lblUnidadIn)
        Me.Controls.Add(Me.lblPrecioRealIn)
        Me.Controls.Add(Me.lblRendimientoIn)
        Me.Controls.Add(Me.lblNombreIngrediente)
        Me.Controls.Add(Me.IngredientesFLP)
        Me.Name = "Ingredientes"
        Me.Text = "Ingredientes"
        CType(Me.RecetasDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IngredientesFLP As FlowLayoutPanel
    Friend WithEvents RecetasDataSet1 As recetasDataSet
    Friend WithEvents IngredientesTableAdapter1 As recetasDataSetTableAdapters.ingredientesTableAdapter
    Friend WithEvents UnidadesTableAdapter1 As recetasDataSetTableAdapters.unidadesTableAdapter
    Friend WithEvents lblNombreIngrediente As Label
    Friend WithEvents lblRendimientoIn As Label
    Friend WithEvents lblUnidadIn As Label
    Friend WithEvents lblPrecioUniIn As Label
    Friend WithEvents btnEditarIngrediente As Button
    Friend WithEvents btnNuevoIngrediente As Button
    Friend WithEvents btnEliminarIngrediente As Button
    Friend WithEvents Receta_ingredientesTableAdapter1 As recetasDataSetTableAdapters.receta_ingredientesTableAdapter
    Friend WithEvents Ingredientes_de_recetaTableAdapter1 As recetasDataSetTableAdapters.ingredientes_de_recetaTableAdapter
    Friend WithEvents lblPrecioRealIn As Label
End Class
