<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerEdit
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
        Me.CustomerIDLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.CustomersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMABooksDataSet = New Abookstore.MMABooksDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CustomersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.ZipCodeTextBox = New System.Windows.Forms.TextBox()
        Me.cbState = New System.Windows.Forms.ComboBox()
        Me.StatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FKInvoicesCustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FillByIDToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CustomerIDToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CustomerIDToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByIDToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.btnViewInvoice = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CustomersTableAdapter = New Abookstore.MMABooksDataSetTableAdapters.CustomersTableAdapter()
        Me.InvoicesTableAdapter = New Abookstore.MMABooksDataSetTableAdapters.InvoicesTableAdapter()
        Me.StatesTableAdapter = New Abookstore.MMABooksDataSetTableAdapters.StatesTableAdapter()
        Me.TableAdapterManager = New Abookstore.MMABooksDataSetTableAdapters.TableAdapterManager()
        Me.InvoiceLineItemsTableAdapter = New Abookstore.MMABooksDataSetTableAdapters.InvoiceLineItemsTableAdapter()
        Me.StatesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.CustomersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomersBindingNavigator.SuspendLayout()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMABooksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKInvoicesCustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByIDToolStrip.SuspendLayout()
        CType(Me.StatesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerIDLabel
        '
        Me.CustomerIDLabel.AutoSize = True
        Me.CustomerIDLabel.Location = New System.Drawing.Point(23, 82)
        Me.CustomerIDLabel.Name = "CustomerIDLabel"
        Me.CustomerIDLabel.Size = New System.Drawing.Size(83, 16)
        Me.CustomerIDLabel.TabIndex = 3
        Me.CustomerIDLabel.Text = "Customer ID:"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(23, 111)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(47, 16)
        Me.NameLabel.TabIndex = 5
        Me.NameLabel.Text = "Name:"
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Location = New System.Drawing.Point(23, 139)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(61, 16)
        Me.AddressLabel.TabIndex = 7
        Me.AddressLabel.Text = "Address:"
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Location = New System.Drawing.Point(8, 170)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(94, 16)
        Me.CityLabel.TabIndex = 9
        Me.CityLabel.Text = "City, State, Zip:"
        '
        'CustomersBindingNavigator
        '
        Me.CustomersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CustomersBindingNavigator.BindingSource = Me.CustomersBindingSource
        Me.CustomersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CustomersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CustomersBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CustomersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CustomersBindingNavigatorSaveItem})
        Me.CustomersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CustomersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CustomersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CustomersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CustomersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CustomersBindingNavigator.Name = "CustomersBindingNavigator"
        Me.CustomersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CustomersBindingNavigator.Size = New System.Drawing.Size(669, 31)
        Me.CustomersBindingNavigator.TabIndex = 2
        Me.CustomersBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = Global.Abookstore.My.Resources.Resources._8666546_user_plus_icon1
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorAddNewItem.Text = " "
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.MMABooksDataSet
        '
        'MMABooksDataSet
        '
        Me.MMABooksDataSet.DataSetName = "MMABooksDataSet"
        Me.MMABooksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = Global.Abookstore.My.Resources.Resources.cross_circle__1_
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = Global.Abookstore.My.Resources.Resources.arrow_left__1_
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = Global.Abookstore.My.Resources.Resources.angle_small_left__1_
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(49, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = Global.Abookstore.My.Resources.Resources.angle_small_right
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = Global.Abookstore.My.Resources.Resources.arrow_right
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'CustomersBindingNavigatorSaveItem
        '
        Me.CustomersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustomersBindingNavigatorSaveItem.Image = Global.Abookstore.My.Resources.Resources.disk
        Me.CustomersBindingNavigatorSaveItem.Name = "CustomersBindingNavigatorSaveItem"
        Me.CustomersBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 28)
        Me.CustomersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "CustomerID", True))
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(115, 80)
        Me.CustomerIDTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.ReadOnly = True
        Me.CustomerIDTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(400, 22)
        Me.CustomerIDTextBox.TabIndex = 4
        '
        'txtCustomerName
        '
        Me.txtCustomerName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Name", True))
        Me.txtCustomerName.Location = New System.Drawing.Point(115, 108)
        Me.txtCustomerName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(400, 22)
        Me.txtCustomerName.TabIndex = 6
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(115, 138)
        Me.AddressTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(400, 22)
        Me.AddressTextBox.TabIndex = 8
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(115, 167)
        Me.CityTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(144, 22)
        Me.CityTextBox.TabIndex = 10
        '
        'ZipCodeTextBox
        '
        Me.ZipCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "ZipCode", True))
        Me.ZipCodeTextBox.Location = New System.Drawing.Point(391, 167)
        Me.ZipCodeTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ZipCodeTextBox.Name = "ZipCodeTextBox"
        Me.ZipCodeTextBox.Size = New System.Drawing.Size(124, 22)
        Me.ZipCodeTextBox.TabIndex = 14
        '
        'cbState
        '
        Me.cbState.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.CustomersBindingSource, "State", True))
        Me.cbState.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CustomersBindingSource, "State", True))
        Me.cbState.DataBindings.Add(New System.Windows.Forms.Binding("DataSource", Me.StatesBindingSource, "StateCode", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "E2"))
        Me.cbState.DataBindings.Add(New System.Windows.Forms.Binding("DisplayMember", Me.StatesBindingSource, "StateCode", True))
        Me.cbState.DataSource = Me.FKInvoicesCustomersBindingSource
        Me.cbState.DisplayMember = "StateCode"
        Me.cbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbState.FormattingEnabled = True
        Me.cbState.IntegralHeight = False
        Me.cbState.Location = New System.Drawing.Point(265, 167)
        Me.cbState.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbState.Name = "cbState"
        Me.cbState.Size = New System.Drawing.Size(120, 24)
        Me.cbState.TabIndex = 16
        Me.cbState.ValueMember = "StateCode"
        '
        'StatesBindingSource
        '
        Me.StatesBindingSource.DataMember = "States"
        Me.StatesBindingSource.DataSource = Me.MMABooksDataSet
        '
        'FKInvoicesCustomersBindingSource
        '
        Me.FKInvoicesCustomersBindingSource.DataMember = "FK_Invoices_Customers"
        Me.FKInvoicesCustomersBindingSource.DataSource = Me.CustomersBindingSource
        '
        'FillByIDToolStrip
        '
        Me.FillByIDToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillByIDToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerIDToolStripLabel, Me.CustomerIDToolStripTextBox, Me.FillByIDToolStripButton})
        Me.FillByIDToolStrip.Location = New System.Drawing.Point(0, 31)
        Me.FillByIDToolStrip.Name = "FillByIDToolStrip"
        Me.FillByIDToolStrip.Size = New System.Drawing.Size(669, 31)
        Me.FillByIDToolStrip.TabIndex = 3
        Me.FillByIDToolStrip.TabStop = True
        Me.FillByIDToolStrip.Text = "FillByIDToolStrip"
        '
        'CustomerIDToolStripLabel
        '
        Me.CustomerIDToolStripLabel.Name = "CustomerIDToolStripLabel"
        Me.CustomerIDToolStripLabel.Size = New System.Drawing.Size(90, 28)
        Me.CustomerIDToolStripLabel.Text = "CustomerID:"
        '
        'CustomerIDToolStripTextBox
        '
        Me.CustomerIDToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CustomerIDToolStripTextBox.Name = "CustomerIDToolStripTextBox"
        Me.CustomerIDToolStripTextBox.Size = New System.Drawing.Size(100, 31)
        Me.CustomerIDToolStripTextBox.Text = "1"
        '
        'FillByIDToolStripButton
        '
        Me.FillByIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByIDToolStripButton.Name = "FillByIDToolStripButton"
        Me.FillByIDToolStripButton.Size = New System.Drawing.Size(63, 28)
        Me.FillByIDToolStripButton.Text = "FillByID"
        '
        'btnViewInvoice
        '
        Me.btnViewInvoice.Location = New System.Drawing.Point(180, 230)
        Me.btnViewInvoice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnViewInvoice.Name = "btnViewInvoice"
        Me.btnViewInvoice.Size = New System.Drawing.Size(235, 38)
        Me.btnViewInvoice.TabIndex = 4
        Me.btnViewInvoice.Text = "View Invoices"
        Me.btnViewInvoice.UseVisualStyleBackColor = True
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'InvoicesTableAdapter
        '
        Me.InvoicesTableAdapter.ClearBeforeFill = True
        '
        'StatesTableAdapter
        '
        Me.StatesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.InvoiceLineItemsTableAdapter = Nothing
        Me.TableAdapterManager.InvoicesTableAdapter = Nothing
        Me.TableAdapterManager.OrderOptionsTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.StatesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Abookstore.MMABooksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'InvoiceLineItemsTableAdapter
        '
        Me.InvoiceLineItemsTableAdapter.ClearBeforeFill = True
        '
        'StatesBindingSource1
        '
        Me.StatesBindingSource1.DataMember = "States"
        Me.StatesBindingSource1.DataSource = Me.MMABooksDataSet
        '
        'CustomerEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 299)
        Me.Controls.Add(Me.btnViewInvoice)
        Me.Controls.Add(Me.FillByIDToolStrip)
        Me.Controls.Add(Me.cbState)
        Me.Controls.Add(Me.CustomerIDLabel)
        Me.Controls.Add(Me.CustomerIDTextBox)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(Me.ZipCodeTextBox)
        Me.Controls.Add(Me.CustomersBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "CustomerEdit"
        Me.Text = "Customer Maintanence"
        CType(Me.CustomersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomersBindingNavigator.ResumeLayout(False)
        Me.CustomersBindingNavigator.PerformLayout()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMABooksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKInvoicesCustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByIDToolStrip.ResumeLayout(False)
        Me.FillByIDToolStrip.PerformLayout()
        CType(Me.StatesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MMABooksDataSet As MMABooksDataSet
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As MMABooksDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents TableAdapterManager As MMABooksDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomersBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CustomersBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents ZipCodeTextBox As TextBox
    Friend WithEvents cbState As ComboBox
    Friend WithEvents InvoicesTableAdapter As MMABooksDataSetTableAdapters.InvoicesTableAdapter
    Friend WithEvents StatesBindingSource As BindingSource
    Friend WithEvents StatesTableAdapter As MMABooksDataSetTableAdapters.StatesTableAdapter
    Friend WithEvents FillByIDToolStrip As ToolStrip
    Friend WithEvents CustomerIDToolStripLabel As ToolStripLabel
    Friend WithEvents CustomerIDToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillByIDToolStripButton As ToolStripButton
    Friend WithEvents btnViewInvoice As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents InvoiceLineItemsTableAdapter As MMABooksDataSetTableAdapters.InvoiceLineItemsTableAdapter
    Friend WithEvents CustomerIDLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents AddressLabel As Label
    Friend WithEvents CityLabel As Label
    Friend WithEvents StatesBindingSource1 As BindingSource
    Friend WithEvents FKInvoicesCustomersBindingSource As BindingSource
End Class
