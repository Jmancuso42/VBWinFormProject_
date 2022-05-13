<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Invoices
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
        Me.InvoicesTableAdapter1 = New Abookstore.MMABooksDataSet1TableAdapters.InvoicesTableAdapter()
        Me.InvoicesDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblName = New System.Windows.Forms.Label()
        Me.FKInvoicesCustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvoicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMABooksDataSet = New Abookstore.MMABooksDataSet()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMABooksDataSet1 = New Abookstore.MMABooksDataSet()
        Me.InvoiceLineItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvoiceLineItemsTableAdapter = New Abookstore.MMABooksDataSetTableAdapters.InvoiceLineItemsTableAdapter()
        Me.InvoicesTableAdapter = New Abookstore.MMABooksDataSetTableAdapters.InvoicesTableAdapter()
        Me.CustomersTableAdapter = New Abookstore.MMABooksDataSetTableAdapters.CustomersTableAdapter()
        Me.TableAdapterManager = New Abookstore.MMABooksDataSetTableAdapters.TableAdapterManager()
        CType(Me.InvoicesDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKInvoicesCustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMABooksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMABooksDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceLineItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InvoicesTableAdapter1
        '
        Me.InvoicesTableAdapter1.ClearBeforeFill = True
        '
        'InvoicesDataGridView1
        '
        Me.InvoicesDataGridView1.AutoGenerateColumns = False
        Me.InvoicesDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InvoicesDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.InvoicesDataGridView1.DataSource = Me.InvoicesBindingSource
        Me.InvoicesDataGridView1.Location = New System.Drawing.Point(26, 58)
        Me.InvoicesDataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.InvoicesDataGridView1.Name = "InvoicesDataGridView1"
        Me.InvoicesDataGridView1.RowHeadersWidth = 51
        Me.InvoicesDataGridView1.RowTemplate.Height = 24
        Me.InvoicesDataGridView1.Size = New System.Drawing.Size(795, 348)
        Me.InvoicesDataGridView1.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(23, 23)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(0, 13)
        Me.lblName.TabIndex = 2
        '
        'FKInvoicesCustomersBindingSource
        '
        Me.FKInvoicesCustomersBindingSource.DataMember = "FK_Invoices_Customers"
        Me.FKInvoicesCustomersBindingSource.DataSource = Me.CustomersBindingSource
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "InvoiceID"
        Me.DataGridViewTextBoxColumn8.HeaderText = "InvoiceID"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "CustomerID"
        Me.DataGridViewTextBoxColumn9.HeaderText = "CustomerID"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Visible = False
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "InvoiceDate"
        Me.DataGridViewTextBoxColumn10.HeaderText = "InvoiceDate"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 125
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ProductTotal"
        Me.DataGridViewTextBoxColumn11.HeaderText = "ProductTotal"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 125
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "SalesTax"
        Me.DataGridViewTextBoxColumn12.HeaderText = "SalesTax"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 125
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Shipping"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Shipping"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 125
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "InvoiceTotal"
        Me.DataGridViewTextBoxColumn14.HeaderText = "InvoiceTotal"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 125
        '
        'InvoicesBindingSource
        '
        Me.InvoicesBindingSource.DataMember = "Invoices"
        Me.InvoicesBindingSource.DataSource = Me.MMABooksDataSet
        '
        'MMABooksDataSet
        '
        Me.MMABooksDataSet.DataSetName = "MMABooksDataSet"
        Me.MMABooksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.MMABooksDataSet1
        '
        'MMABooksDataSet1
        '
        Me.MMABooksDataSet1.DataSetName = "MMABooksDataSet"
        Me.MMABooksDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InvoiceLineItemsBindingSource
        '
        Me.InvoiceLineItemsBindingSource.DataMember = "InvoiceLineItems"
        Me.InvoiceLineItemsBindingSource.DataSource = Me.MMABooksDataSet
        '
        'InvoiceLineItemsTableAdapter
        '
        Me.InvoiceLineItemsTableAdapter.ClearBeforeFill = True
        '
        'InvoicesTableAdapter
        '
        Me.InvoicesTableAdapter.ClearBeforeFill = True
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomersTableAdapter = Me.CustomersTableAdapter
        Me.TableAdapterManager.InvoiceLineItemsTableAdapter = Nothing
        Me.TableAdapterManager.InvoicesTableAdapter = Nothing
        Me.TableAdapterManager.OrderOptionsTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.StatesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Abookstore.MMABooksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Invoices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 430)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.InvoicesDataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Invoices"
        Me.Text = "Invoices"
        CType(Me.InvoicesDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKInvoicesCustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMABooksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMABooksDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceLineItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InvoicesTableAdapter1 As MMABooksDataSet1TableAdapters.InvoicesTableAdapter
    Friend WithEvents MMABooksDataSet As MMABooksDataSet
    Friend WithEvents InvoiceLineItemsBindingSource As BindingSource
    Friend WithEvents InvoiceLineItemsTableAdapter As MMABooksDataSetTableAdapters.InvoiceLineItemsTableAdapter
    Friend WithEvents InvoicesBindingSource As BindingSource
    Friend WithEvents InvoicesTableAdapter As MMABooksDataSetTableAdapters.InvoicesTableAdapter
    Friend WithEvents MMABooksDataSet1 As MMABooksDataSet
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As MMABooksDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents FKInvoicesCustomersBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As MMABooksDataSetTableAdapters.TableAdapterManager
    Friend WithEvents InvoicesDataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents lblName As Label
End Class
