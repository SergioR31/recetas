<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RecetasFLP = New System.Windows.Forms.FlowLayoutPanel()
        Me.SplitContainerDetallesR = New System.Windows.Forms.SplitContainer()
        Me.btnEditarReceta = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEliminarReceta = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CategoriasInFLP = New System.Windows.Forms.FlowLayoutPanel()
        Me.RecetasDataSet1 = New RecetasWF.recetasDataSet()
        Me.TableAdapterManager1 = New RecetasWF.recetasDataSetTableAdapters.TableAdapterManager()
        Me.Categoria_recetasTableAdapter1 = New RecetasWF.recetasDataSetTableAdapters.categoria_recetasTableAdapter()
        Me.CategoriasTableAdapter1 = New RecetasWF.recetasDataSetTableAdapters.categoriasTableAdapter()
        Me.IngredientesTableAdapter1 = New RecetasWF.recetasDataSetTableAdapters.ingredientesTableAdapter()
        Me.Receta_ingredientesTableAdapter1 = New RecetasWF.recetasDataSetTableAdapters.receta_ingredientesTableAdapter()
        Me.Recetas_de_categoriaTableAdapter1 = New RecetasWF.recetasDataSetTableAdapters.recetas_de_categoriaTableAdapter()
        Me.RecetasTableAdapter1 = New RecetasWF.recetasDataSetTableAdapters.recetasTableAdapter()
        Me.UnidadesTableAdapter1 = New RecetasWF.recetasDataSetTableAdapters.unidadesTableAdapter()
        Me.Ingredientes_de_recetaTableAdapter1 = New RecetasWF.recetasDataSetTableAdapters.ingredientes_de_recetaTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.SplitContainerDetallesR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerDetallesR.Panel1.SuspendLayout()
        Me.SplitContainerDetallesR.Panel2.SuspendLayout()
        Me.SplitContainerDetallesR.SuspendLayout()
        CType(Me.RecetasDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 42)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Nueva Receta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RecetasFLP
        '
        Me.RecetasFLP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RecetasFLP.Location = New System.Drawing.Point(35, 3)
        Me.RecetasFLP.Name = "RecetasFLP"
        Me.RecetasFLP.Size = New System.Drawing.Size(579, 182)
        Me.RecetasFLP.TabIndex = 1
        '
        'SplitContainerDetallesR
        '
        Me.SplitContainerDetallesR.Location = New System.Drawing.Point(282, 105)
        Me.SplitContainerDetallesR.Name = "SplitContainerDetallesR"
        Me.SplitContainerDetallesR.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerDetallesR.Panel1
        '
        Me.SplitContainerDetallesR.Panel1.Controls.Add(Me.RecetasFLP)
        '
        'SplitContainerDetallesR.Panel2
        '
        Me.SplitContainerDetallesR.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainerDetallesR.Panel2.Controls.Add(Me.btnEliminarReceta)
        Me.SplitContainerDetallesR.Panel2.Controls.Add(Me.btnEditarReceta)
        Me.SplitContainerDetallesR.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainerDetallesR.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainerDetallesR.Size = New System.Drawing.Size(646, 364)
        Me.SplitContainerDetallesR.SplitterDistance = 190
        Me.SplitContainerDetallesR.TabIndex = 2
        '
        'btnEditarReceta
        '
        Me.btnEditarReceta.Location = New System.Drawing.Point(491, 55)
        Me.btnEditarReceta.Name = "btnEditarReceta"
        Me.btnEditarReceta.Size = New System.Drawing.Size(123, 37)
        Me.btnEditarReceta.TabIndex = 2
        Me.btnEditarReceta.Text = "Editar Receta"
        Me.btnEditarReceta.UseVisualStyleBackColor = True
        Me.btnEditarReceta.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(176, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(173, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'btnEliminarReceta
        '
        Me.btnEliminarReceta.Location = New System.Drawing.Point(491, 99)
        Me.btnEliminarReceta.Name = "btnEliminarReceta"
        Me.btnEliminarReceta.Size = New System.Drawing.Size(123, 37)
        Me.btnEliminarReceta.TabIndex = 3
        Me.btnEliminarReceta.Text = "Eliminar Receta"
        Me.btnEliminarReceta.UseVisualStyleBackColor = True
        Me.btnEliminarReceta.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(179, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Label3"
        '
        'CategoriasInFLP
        '
        Me.CategoriasInFLP.AutoScroll = True
        Me.CategoriasInFLP.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.CategoriasInFLP.Location = New System.Drawing.Point(12, 105)
        Me.CategoriasInFLP.Name = "CategoriasInFLP"
        Me.CategoriasInFLP.Size = New System.Drawing.Size(264, 245)
        Me.CategoriasInFLP.TabIndex = 3
        Me.CategoriasInFLP.WrapContents = False
        '
        'RecetasDataSet1
        '
        Me.RecetasDataSet1.DataSetName = "recetasDataSet"
        Me.RecetasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.categoria_recetasTableAdapter = Me.Categoria_recetasTableAdapter1
        Me.TableAdapterManager1.categoriasTableAdapter = Me.CategoriasTableAdapter1
        Me.TableAdapterManager1.ingredientesTableAdapter = Me.IngredientesTableAdapter1
        Me.TableAdapterManager1.receta_ingredientesTableAdapter = Me.Receta_ingredientesTableAdapter1
        Me.TableAdapterManager1.recetasTableAdapter = Me.RecetasTableAdapter1
        Me.TableAdapterManager1.unidadesTableAdapter = Me.UnidadesTableAdapter1
        Me.TableAdapterManager1.UpdateOrder = RecetasWF.recetasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Categoria_recetasTableAdapter1
        '
        Me.Categoria_recetasTableAdapter1.ClearBeforeFill = True
        '
        'CategoriasTableAdapter1
        '
        Me.CategoriasTableAdapter1.ClearBeforeFill = True
        '
        'IngredientesTableAdapter1
        '
        Me.IngredientesTableAdapter1.ClearBeforeFill = True
        '
        'Receta_ingredientesTableAdapter1
        '
        Me.Receta_ingredientesTableAdapter1.ClearBeforeFill = True
        '
        'Recetas_de_categoriaTableAdapter1
        '
        Me.Recetas_de_categoriaTableAdapter1.ClearBeforeFill = True
        '
        'RecetasTableAdapter1
        '
        Me.RecetasTableAdapter1.ClearBeforeFill = True
        '
        'UnidadesTableAdapter1
        '
        Me.UnidadesTableAdapter1.ClearBeforeFill = True
        '
        'Ingredientes_de_recetaTableAdapter1
        '
        Me.Ingredientes_de_recetaTableAdapter1.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(773, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 42)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Ingredientes"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 618)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CategoriasInFLP)
        Me.Controls.Add(Me.SplitContainerDetallesR)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        Me.SplitContainerDetallesR.Panel1.ResumeLayout(False)
        Me.SplitContainerDetallesR.Panel2.ResumeLayout(False)
        Me.SplitContainerDetallesR.Panel2.PerformLayout()
        CType(Me.SplitContainerDetallesR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerDetallesR.ResumeLayout(False)
        CType(Me.RecetasDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents RecetasFLP As FlowLayoutPanel
    Friend WithEvents RecetasDataSet1 As recetasDataSet
    Friend WithEvents SplitContainerDetallesR As SplitContainer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEditarReceta As Button
    Friend WithEvents btnEliminarReceta As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents CategoriasInFLP As FlowLayoutPanel
    Friend WithEvents TableAdapterManager1 As recetasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Categoria_recetasTableAdapter1 As recetasDataSetTableAdapters.categoria_recetasTableAdapter
    Friend WithEvents CategoriasTableAdapter1 As recetasDataSetTableAdapters.categoriasTableAdapter
    Friend WithEvents IngredientesTableAdapter1 As recetasDataSetTableAdapters.ingredientesTableAdapter
    Friend WithEvents Receta_ingredientesTableAdapter1 As recetasDataSetTableAdapters.receta_ingredientesTableAdapter
    Friend WithEvents RecetasTableAdapter1 As recetasDataSetTableAdapters.recetasTableAdapter
    Friend WithEvents UnidadesTableAdapter1 As recetasDataSetTableAdapters.unidadesTableAdapter
    Friend WithEvents Recetas_de_categoriaTableAdapter1 As recetasDataSetTableAdapters.recetas_de_categoriaTableAdapter
    Friend WithEvents Ingredientes_de_recetaTableAdapter1 As recetasDataSetTableAdapters.ingredientes_de_recetaTableAdapter
    Friend WithEvents Button2 As Button
End Class
