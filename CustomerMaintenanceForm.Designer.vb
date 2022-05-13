<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerMaintenanceForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerMaintenanceForm))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsb_hardPrev = New System.Windows.Forms.ToolStripButton()
        Me.tsb_Left = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tstbox_CustCount = New System.Windows.Forms.ToolStripTextBox()
        Me.tsl_ID = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsb_Next = New System.Windows.Forms.ToolStripButton()
        Me.TSB_ = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.tsb_save = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.lbl_custID = New System.Windows.Forms.ToolStripLabel()
        Me.txt_custIDin = New System.Windows.Forms.ToolStripTextBox()
        Me.btn_getID = New System.Windows.Forms.ToolStripButton()
        Me.lblCustID = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.txt_city = New System.Windows.Forms.TextBox()
        Me.txt_zip = New System.Windows.Forms.TextBox()
        Me.cb_state = New System.Windows.Forms.ComboBox()
        Me.StatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMABooksDataSet = New Abookstore.MMABooksDataSet()
        Me.StatesTableAdapter = New Abookstore.MMABooksDataSetTableAdapters.StatesTableAdapter()
        Me.btn_ViewInvoices = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.StatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMABooksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsb_hardPrev, Me.tsb_Left, Me.ToolStripSeparator1, Me.tstbox_CustCount, Me.tsl_ID, Me.ToolStripSeparator2, Me.tsb_Next, Me.TSB_, Me.ToolStripSeparator3, Me.ToolStripButton5, Me.ToolStripButton6, Me.tsb_save})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(525, 27)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsb_hardPrev
        '
        Me.tsb_hardPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_hardPrev.Image = CType(resources.GetObject("tsb_hardPrev.Image"), System.Drawing.Image)
        Me.tsb_hardPrev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_hardPrev.Name = "tsb_hardPrev"
        Me.tsb_hardPrev.Size = New System.Drawing.Size(24, 24)
        Me.tsb_hardPrev.Text = "ToolStripButton1"
        '
        'tsb_Left
        '
        Me.tsb_Left.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_Left.Image = CType(resources.GetObject("tsb_Left.Image"), System.Drawing.Image)
        Me.tsb_Left.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_Left.Name = "tsb_Left"
        Me.tsb_Left.Size = New System.Drawing.Size(24, 24)
        Me.tsb_Left.Text = "ToolStripButton2"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'tstbox_CustCount
        '
        Me.tstbox_CustCount.Name = "tstbox_CustCount"
        Me.tstbox_CustCount.Size = New System.Drawing.Size(76, 27)
        '
        'tsl_ID
        '
        Me.tsl_ID.Name = "tsl_ID"
        Me.tsl_ID.Size = New System.Drawing.Size(21, 24)
        Me.tsl_ID.Text = "of "
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'tsb_Next
        '
        Me.tsb_Next.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_Next.Image = CType(resources.GetObject("tsb_Next.Image"), System.Drawing.Image)
        Me.tsb_Next.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_Next.Name = "tsb_Next"
        Me.tsb_Next.Size = New System.Drawing.Size(24, 24)
        Me.tsb_Next.Text = "ToolStripButton3"
        '
        'TSB_
        '
        Me.TSB_.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSB_.Image = CType(resources.GetObject("TSB_.Image"), System.Drawing.Image)
        Me.TSB_.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSB_.Name = "TSB_"
        Me.TSB_.Size = New System.Drawing.Size(24, 24)
        Me.TSB_.Text = "ToolStripButton4"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton5.Text = "ToolStripButton5"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton6.Text = "ToolStripButton6"
        '
        'tsb_save
        '
        Me.tsb_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_save.Image = CType(resources.GetObject("tsb_save.Image"), System.Drawing.Image)
        Me.tsb_save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_save.Name = "tsb_save"
        Me.tsb_save.Size = New System.Drawing.Size(24, 24)
        Me.tsb_save.Text = "ToolStripButton7"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_custID, Me.txt_custIDin, Me.btn_getID})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 27)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(525, 27)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'lbl_custID
        '
        Me.lbl_custID.Name = "lbl_custID"
        Me.lbl_custID.Size = New System.Drawing.Size(76, 24)
        Me.lbl_custID.Text = "Customer ID:"
        '
        'txt_custIDin
        '
        Me.txt_custIDin.Name = "txt_custIDin"
        Me.txt_custIDin.Size = New System.Drawing.Size(76, 27)
        '
        'btn_getID
        '
        Me.btn_getID.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_getID.Image = CType(resources.GetObject("btn_getID.Image"), System.Drawing.Image)
        Me.btn_getID.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_getID.Name = "btn_getID"
        Me.btn_getID.Size = New System.Drawing.Size(24, 24)
        Me.btn_getID.Text = "ToolStripButton8"
        '
        'lblCustID
        '
        Me.lblCustID.AutoSize = True
        Me.lblCustID.Location = New System.Drawing.Point(12, 59)
        Me.lblCustID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCustID.Name = "lblCustID"
        Me.lblCustID.Size = New System.Drawing.Size(68, 13)
        Me.lblCustID.TabIndex = 2
        Me.lblCustID.Text = "Customer ID:"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(12, 84)
        Me.lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(38, 13)
        Me.lbl.TabIndex = 3
        Me.lbl.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 117)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Address:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 144)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "City, State, Zip:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(109, 59)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(95, 20)
        Me.TextBox1.TabIndex = 9
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(109, 84)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(334, 20)
        Me.txt_name.TabIndex = 10
        '
        'txt_address
        '
        Me.txt_address.Location = New System.Drawing.Point(109, 114)
        Me.txt_address.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(334, 20)
        Me.txt_address.TabIndex = 11
        '
        'txt_city
        '
        Me.txt_city.Location = New System.Drawing.Point(109, 144)
        Me.txt_city.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_city.Name = "txt_city"
        Me.txt_city.Size = New System.Drawing.Size(95, 20)
        Me.txt_city.TabIndex = 12
        '
        'txt_zip
        '
        Me.txt_zip.Location = New System.Drawing.Point(349, 145)
        Me.txt_zip.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_zip.Name = "txt_zip"
        Me.txt_zip.Size = New System.Drawing.Size(95, 20)
        Me.txt_zip.TabIndex = 13
        '
        'cb_state
        '
        Me.cb_state.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.StatesBindingSource, "StateName", True))
        Me.cb_state.DataSource = Me.StatesBindingSource
        Me.cb_state.DisplayMember = "StateName"
        Me.cb_state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_state.FormattingEnabled = True
        Me.cb_state.Location = New System.Drawing.Point(217, 145)
        Me.cb_state.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cb_state.Name = "cb_state"
        Me.cb_state.Size = New System.Drawing.Size(114, 21)
        Me.cb_state.TabIndex = 14
        Me.cb_state.ValueMember = "StateName"
        '
        'StatesBindingSource
        '
        Me.StatesBindingSource.DataMember = "States"
        Me.StatesBindingSource.DataSource = Me.MMABooksDataSet
        '
        'MMABooksDataSet
        '
        Me.MMABooksDataSet.DataSetName = "MMABooksDataSet"
        Me.MMABooksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StatesTableAdapter
        '
        Me.StatesTableAdapter.ClearBeforeFill = True
        '
        'btn_ViewInvoices
        '
        Me.btn_ViewInvoices.Location = New System.Drawing.Point(161, 181)
        Me.btn_ViewInvoices.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_ViewInvoices.Name = "btn_ViewInvoices"
        Me.btn_ViewInvoices.Size = New System.Drawing.Size(215, 19)
        Me.btn_ViewInvoices.TabIndex = 15
        Me.btn_ViewInvoices.Text = "View Invoices"
        Me.btn_ViewInvoices.UseVisualStyleBackColor = True
        '
        'CustomerMaintenanceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 207)
        Me.Controls.Add(Me.btn_ViewInvoices)
        Me.Controls.Add(Me.cb_state)
        Me.Controls.Add(Me.txt_zip)
        Me.Controls.Add(Me.txt_city)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.lblCustID)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "CustomerMaintenanceForm"
        Me.Text = "CustomerMaintenance"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.StatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMABooksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsb_hardPrev As ToolStripButton
    Friend WithEvents tsb_Left As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tstbox_CustCount As ToolStripTextBox
    Friend WithEvents tsl_ID As ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsb_Next As ToolStripButton
    Friend WithEvents TSB_ As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents tsb_save As ToolStripButton
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents lbl_custID As ToolStripLabel
    Friend WithEvents txt_custIDin As ToolStripTextBox
    Friend WithEvents btn_getID As ToolStripButton
    Friend WithEvents lblCustID As Label
    Friend WithEvents lbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_address As TextBox
    Friend WithEvents txt_city As TextBox
    Friend WithEvents txt_zip As TextBox
    Friend WithEvents cb_state As ComboBox
    Friend WithEvents MMABooksDataSet As MMABooksDataSet
    Friend WithEvents StatesBindingSource As BindingSource
    Friend WithEvents StatesTableAdapter As MMABooksDataSetTableAdapters.StatesTableAdapter
    Friend WithEvents btn_ViewInvoices As Button
End Class
