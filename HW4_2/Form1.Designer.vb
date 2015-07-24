<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ProductIDLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim MfgIDLabel As System.Windows.Forms.Label
        Dim UnitLabel As System.Windows.Forms.Label
        Dim CostLabel As System.Windows.Forms.Label
        Dim LastOrderDateLabel As System.Windows.Forms.Label
        Dim LastOrderQuantityLabel As System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.VeryBoardsDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VeryBoardsDataSet = New HW4_2.VeryBoardsDataSet()
        Me.ProductTableAdapter = New HW4_2.VeryBoardsDataSetTableAdapters.ProductTableAdapter()
        Me.button1 = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New HW4_2.VeryBoardsDataSetTableAdapters.TableAdapterManager()
        Me.LastOrderQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastOrderDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MfgIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductIDComboBox = New System.Windows.Forms.ComboBox()
        Me.DescriptionLabel1 = New System.Windows.Forms.Label()
        Me.MfgIDLabel1 = New System.Windows.Forms.Label()
        Me.UnitLabel1 = New System.Windows.Forms.Label()
        Me.CostLabel1 = New System.Windows.Forms.Label()
        Me.LastOrderDateLabel1 = New System.Windows.Forms.Label()
        Me.LastOrderQuantityLabel1 = New System.Windows.Forms.Label()
        ProductIDLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        MfgIDLabel = New System.Windows.Forms.Label()
        UnitLabel = New System.Windows.Forms.Label()
        CostLabel = New System.Windows.Forms.Label()
        LastOrderDateLabel = New System.Windows.Forms.Label()
        LastOrderQuantityLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VeryBoardsDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VeryBoardsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.MfgIDDataGridViewTextBoxColumn, Me.UnitDataGridViewTextBoxColumn, Me.CostDataGridViewTextBoxColumn, Me.LastOrderDateDataGridViewTextBoxColumn, Me.LastOrderQuantityDataGridViewTextBoxColumn})
        Me.DataGridView1.Location = New System.Drawing.Point(310, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(746, 375)
        Me.DataGridView1.TabIndex = 0
        '
        'VeryBoardsDataSetBindingSource
        '
        Me.VeryBoardsDataSetBindingSource.DataSource = Me.VeryBoardsDataSet
        Me.VeryBoardsDataSetBindingSource.Position = 0
        '
        'VeryBoardsDataSet
        '
        Me.VeryBoardsDataSet.DataSetName = "VeryBoardsDataSet"
        Me.VeryBoardsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(1114, 344)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(100, 28)
        Me.button1.TabIndex = 2
        Me.button1.Text = "Reject Update"
        Me.button1.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(1114, 33)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 28)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Update All"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ProductTableAdapter = Me.ProductTableAdapter
        Me.TableAdapterManager.UpdateOrder = HW4_2.VeryBoardsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LastOrderQuantityDataGridViewTextBoxColumn
        '
        Me.LastOrderQuantityDataGridViewTextBoxColumn.DataPropertyName = "LastOrderQuantity"
        Me.LastOrderQuantityDataGridViewTextBoxColumn.HeaderText = "LastOrderQuantity"
        Me.LastOrderQuantityDataGridViewTextBoxColumn.Name = "LastOrderQuantityDataGridViewTextBoxColumn"
        '
        'LastOrderDateDataGridViewTextBoxColumn
        '
        Me.LastOrderDateDataGridViewTextBoxColumn.DataPropertyName = "LastOrderDate"
        Me.LastOrderDateDataGridViewTextBoxColumn.HeaderText = "LastOrderDate"
        Me.LastOrderDateDataGridViewTextBoxColumn.Name = "LastOrderDateDataGridViewTextBoxColumn"
        '
        'CostDataGridViewTextBoxColumn
        '
        Me.CostDataGridViewTextBoxColumn.DataPropertyName = "Cost"
        Me.CostDataGridViewTextBoxColumn.HeaderText = "Cost"
        Me.CostDataGridViewTextBoxColumn.Name = "CostDataGridViewTextBoxColumn"
        '
        'UnitDataGridViewTextBoxColumn
        '
        Me.UnitDataGridViewTextBoxColumn.DataPropertyName = "Unit"
        Me.UnitDataGridViewTextBoxColumn.HeaderText = "Unit"
        Me.UnitDataGridViewTextBoxColumn.Name = "UnitDataGridViewTextBoxColumn"
        '
        'MfgIDDataGridViewTextBoxColumn
        '
        Me.MfgIDDataGridViewTextBoxColumn.DataPropertyName = "MfgID"
        Me.MfgIDDataGridViewTextBoxColumn.HeaderText = "MfgID"
        Me.MfgIDDataGridViewTextBoxColumn.Name = "MfgIDDataGridViewTextBoxColumn"
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.VeryBoardsDataSet
        '
        'ProductIDLabel
        '
        ProductIDLabel.AutoSize = True
        ProductIDLabel.Location = New System.Drawing.Point(33, 41)
        ProductIDLabel.Name = "ProductIDLabel"
        ProductIDLabel.Size = New System.Drawing.Size(61, 13)
        ProductIDLabel.TabIndex = 3
        ProductIDLabel.Text = "Product ID:"
        '
        'ProductIDComboBox
        '
        Me.ProductIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ProductID", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.ProductIDComboBox.DataSource = Me.ProductBindingSource
        Me.ProductIDComboBox.DisplayMember = "ProductID"
        Me.ProductIDComboBox.FormattingEnabled = True
        Me.ProductIDComboBox.Location = New System.Drawing.Point(140, 38)
        Me.ProductIDComboBox.Name = "ProductIDComboBox"
        Me.ProductIDComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ProductIDComboBox.TabIndex = 4
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(33, 62)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 5
        DescriptionLabel.Text = "Description:"
        '
        'DescriptionLabel1
        '
        Me.DescriptionLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Description", True))
        Me.DescriptionLabel1.Location = New System.Drawing.Point(140, 62)
        Me.DescriptionLabel1.Name = "DescriptionLabel1"
        Me.DescriptionLabel1.Size = New System.Drawing.Size(121, 23)
        Me.DescriptionLabel1.TabIndex = 6
        Me.DescriptionLabel1.Text = "Label1"
        '
        'MfgIDLabel
        '
        MfgIDLabel.AutoSize = True
        MfgIDLabel.Location = New System.Drawing.Point(33, 85)
        MfgIDLabel.Name = "MfgIDLabel"
        MfgIDLabel.Size = New System.Drawing.Size(42, 13)
        MfgIDLabel.TabIndex = 7
        MfgIDLabel.Text = "Mfg ID:"
        '
        'MfgIDLabel1
        '
        Me.MfgIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "MfgID", True))
        Me.MfgIDLabel1.Location = New System.Drawing.Point(140, 85)
        Me.MfgIDLabel1.Name = "MfgIDLabel1"
        Me.MfgIDLabel1.Size = New System.Drawing.Size(121, 23)
        Me.MfgIDLabel1.TabIndex = 8
        Me.MfgIDLabel1.Text = "Label1"
        '
        'UnitLabel
        '
        UnitLabel.AutoSize = True
        UnitLabel.Location = New System.Drawing.Point(33, 108)
        UnitLabel.Name = "UnitLabel"
        UnitLabel.Size = New System.Drawing.Size(29, 13)
        UnitLabel.TabIndex = 9
        UnitLabel.Text = "Unit:"
        '
        'UnitLabel1
        '
        Me.UnitLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Unit", True))
        Me.UnitLabel1.Location = New System.Drawing.Point(140, 108)
        Me.UnitLabel1.Name = "UnitLabel1"
        Me.UnitLabel1.Size = New System.Drawing.Size(121, 23)
        Me.UnitLabel1.TabIndex = 10
        Me.UnitLabel1.Text = "Label1"
        '
        'CostLabel
        '
        CostLabel.AutoSize = True
        CostLabel.Location = New System.Drawing.Point(33, 131)
        CostLabel.Name = "CostLabel"
        CostLabel.Size = New System.Drawing.Size(31, 13)
        CostLabel.TabIndex = 11
        CostLabel.Text = "Cost:"
        '
        'CostLabel1
        '
        Me.CostLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Cost", True))
        Me.CostLabel1.Location = New System.Drawing.Point(140, 131)
        Me.CostLabel1.Name = "CostLabel1"
        Me.CostLabel1.Size = New System.Drawing.Size(121, 23)
        Me.CostLabel1.TabIndex = 12
        Me.CostLabel1.Text = "Label1"
        '
        'LastOrderDateLabel
        '
        LastOrderDateLabel.AutoSize = True
        LastOrderDateLabel.Location = New System.Drawing.Point(33, 154)
        LastOrderDateLabel.Name = "LastOrderDateLabel"
        LastOrderDateLabel.Size = New System.Drawing.Size(85, 13)
        LastOrderDateLabel.TabIndex = 13
        LastOrderDateLabel.Text = "Last Order Date:"
        '
        'LastOrderDateLabel1
        '
        Me.LastOrderDateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "LastOrderDate", True))
        Me.LastOrderDateLabel1.Location = New System.Drawing.Point(140, 154)
        Me.LastOrderDateLabel1.Name = "LastOrderDateLabel1"
        Me.LastOrderDateLabel1.Size = New System.Drawing.Size(121, 23)
        Me.LastOrderDateLabel1.TabIndex = 14
        Me.LastOrderDateLabel1.Text = "Label1"
        '
        'LastOrderQuantityLabel
        '
        LastOrderQuantityLabel.AutoSize = True
        LastOrderQuantityLabel.Location = New System.Drawing.Point(33, 177)
        LastOrderQuantityLabel.Name = "LastOrderQuantityLabel"
        LastOrderQuantityLabel.Size = New System.Drawing.Size(101, 13)
        LastOrderQuantityLabel.TabIndex = 15
        LastOrderQuantityLabel.Text = "Last Order Quantity:"
        '
        'LastOrderQuantityLabel1
        '
        Me.LastOrderQuantityLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "LastOrderQuantity", True))
        Me.LastOrderQuantityLabel1.Location = New System.Drawing.Point(140, 177)
        Me.LastOrderQuantityLabel1.Name = "LastOrderQuantityLabel1"
        Me.LastOrderQuantityLabel1.Size = New System.Drawing.Size(121, 23)
        Me.LastOrderQuantityLabel1.TabIndex = 16
        Me.LastOrderQuantityLabel1.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1246, 414)
        Me.Controls.Add(ProductIDLabel)
        Me.Controls.Add(Me.ProductIDComboBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionLabel1)
        Me.Controls.Add(MfgIDLabel)
        Me.Controls.Add(Me.MfgIDLabel1)
        Me.Controls.Add(UnitLabel)
        Me.Controls.Add(Me.UnitLabel1)
        Me.Controls.Add(CostLabel)
        Me.Controls.Add(Me.CostLabel1)
        Me.Controls.Add(LastOrderDateLabel)
        Me.Controls.Add(Me.LastOrderDateLabel1)
        Me.Controls.Add(LastOrderQuantityLabel)
        Me.Controls.Add(Me.LastOrderQuantityLabel1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VeryBoardsDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VeryBoardsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents VeryBoardsDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VeryBoardsDataSet As HW4_2.VeryBoardsDataSet
    Friend WithEvents ProductTableAdapter As HW4_2.VeryBoardsDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents TableAdapterManager As HW4_2.VeryBoardsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MfgIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastOrderDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastOrderQuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DescriptionLabel1 As System.Windows.Forms.Label
    Friend WithEvents MfgIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents UnitLabel1 As System.Windows.Forms.Label
    Friend WithEvents CostLabel1 As System.Windows.Forms.Label
    Friend WithEvents LastOrderDateLabel1 As System.Windows.Forms.Label
    Friend WithEvents LastOrderQuantityLabel1 As System.Windows.Forms.Label

End Class
