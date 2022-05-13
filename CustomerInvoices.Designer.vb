<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerInvoices
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MMABooksDataSet = New Abookstore.MMABooksDataSet()
        Me.InvoicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvoicesTableAdapter = New Abookstore.MMABooksDataSetTableAdapters.InvoicesTableAdapter()
        Me.TableAdapterManager = New Abookstore.MMABooksDataSetTableAdapters.TableAdapterManager()
        Me.InvoiceDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_CustName = New System.Windows.Forms.Label()
        Me.btnInvoiceDate = New System.Windows.Forms.Button()
        CType(Me.MMABooksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MMABooksDataSet
        '
        Me.MMABooksDataSet.DataSetName = "MMABooksDataSet"
        Me.MMABooksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InvoicesBindingSource
        '
        Me.InvoicesBindingSource.DataMember = "Invoices"
        Me.InvoicesBindingSource.DataSource = Me.MMABooksDataSet
        '
        'InvoicesTableAdapter
        '
        Me.InvoicesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.InvoiceLineItemsTableAdapter = Nothing
        Me.TableAdapterManager.InvoicesTableAdapter = Me.InvoicesTableAdapter
        Me.TableAdapterManager.OrderOptionsTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.StatesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Abookstore.MMABooksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'InvoiceDataGridView
        '
        Me.InvoiceDataGridView.AutoGenerateColumns = False
        Me.InvoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InvoiceDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.InvoiceDataGridView.DataSource = Me.InvoicesBindingSource
        Me.InvoiceDataGridView.Location = New System.Drawing.Point(0, 121)
        Me.InvoiceDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.InvoiceDataGridView.Name = "InvoiceDataGridView"
        Me.InvoiceDataGridView.RowHeadersWidth = 51
        Me.InvoiceDataGridView.Size = New System.Drawing.Size(1101, 378)
        Me.InvoiceDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "InvoiceID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "InvoiceID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CustomerID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CustomerID"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "InvoiceDate"
        Me.DataGridViewTextBoxColumn3.HeaderText = "InvoiceDate"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ProductTotal"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ProductTotal"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "SalesTax"
        Me.DataGridViewTextBoxColumn5.HeaderText = "SalesTax"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Shipping"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Shipping"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "InvoiceTotal"
        Me.DataGridViewTextBoxColumn7.HeaderText = "InvoiceTotal"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'lbl_CustName
        '
        Me.lbl_CustName.AutoSize = True
        Me.lbl_CustName.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CustName.Location = New System.Drawing.Point(418, 18)
        Me.lbl_CustName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_CustName.Name = "lbl_CustName"
        Me.lbl_CustName.Size = New System.Drawing.Size(197, 42)
        Me.lbl_CustName.TabIndex = 2
        Me.lbl_CustName.Text = "Invoices for:"
        '
        'btnInvoiceDate
        '
        Me.btnInvoiceDate.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.InvoicesBindingSource, "InvoiceDate", True))
        Me.btnInvoiceDate.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInvoiceDate.Location = New System.Drawing.Point(12, 78)
        Me.btnInvoiceDate.Name = "btnInvoiceDate"
        Me.btnInvoiceDate.Size = New System.Drawing.Size(168, 36)
        Me.btnInvoiceDate.TabIndex = 3
        Me.btnInvoiceDate.Text = "Toggle Order"
        Me.btnInvoiceDate.UseVisualStyleBackColor = True
        '
        'CustomerInvoices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1130, 527)
        Me.Controls.Add(Me.btnInvoiceDate)
        Me.Controls.Add(Me.lbl_CustName)
        Me.Controls.Add(Me.InvoiceDataGridView)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CustomerInvoices"
        Me.Text = "Customer Invoices"
        CType(Me.MMABooksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MMABooksDataSet As MMABooksDataSet
    Friend WithEvents InvoicesBindingSource As BindingSource
    Friend WithEvents InvoicesTableAdapter As MMABooksDataSetTableAdapters.InvoicesTableAdapter
    Friend WithEvents TableAdapterManager As MMABooksDataSetTableAdapters.TableAdapterManager
    Friend WithEvents InvoiceDataGridView As DataGridView
    Friend WithEvents lbl_CustName As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents btnInvoiceDate As Button
End Class
