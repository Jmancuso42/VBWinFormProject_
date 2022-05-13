<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_main
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
        Me.statusStrip = New System.Windows.Forms.StatusStrip()
        Me.ts_lbl_date = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Clock = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ts_lbl_greeting = New System.Windows.Forms.ToolStripStatusLabel()
        Me.st_date = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mnuMainToolStrip = New System.Windows.Forms.MenuStrip()
        Me.tsMnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_tsBtn_newInvoice = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsMnuView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_TsBtn_ToggleView = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsMnuWindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_tsBtn_Cascade = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_tsBtn_Horizontally = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_tsBtn_TileVertically = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_ts_about = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_ManagementBar = New System.Windows.Forms.ToolStrip()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnTsCustomers = New System.Windows.Forms.ToolStripButton()
        Me.TsBtnProducts = New System.Windows.Forms.ToolStripButton()
        Me.statusStrip.SuspendLayout()
        Me.mnuMainToolStrip.SuspendLayout()
        Me.ts_ManagementBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'statusStrip
        '
        Me.statusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.statusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_lbl_date, Me.Clock, Me.ts_lbl_greeting, Me.st_date})
        Me.statusStrip.Location = New System.Drawing.Point(0, 718)
        Me.statusStrip.Name = "statusStrip"
        Me.statusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 13, 0)
        Me.statusStrip.Size = New System.Drawing.Size(1490, 26)
        Me.statusStrip.TabIndex = 3
        '
        'ts_lbl_date
        '
        Me.ts_lbl_date.Name = "ts_lbl_date"
        Me.ts_lbl_date.Size = New System.Drawing.Size(0, 20)
        '
        'Clock
        '
        Me.Clock.Name = "Clock"
        Me.Clock.Size = New System.Drawing.Size(42, 20)
        Me.Clock.Text = "Time"
        Me.Clock.ToolTipText = "Hello!"
        '
        'ts_lbl_greeting
        '
        Me.ts_lbl_greeting.Name = "ts_lbl_greeting"
        Me.ts_lbl_greeting.Size = New System.Drawing.Size(1393, 20)
        Me.ts_lbl_greeting.Spring = True
        Me.ts_lbl_greeting.Text = "Welcome to Joey's ""Bookstore for tax writeoff purposes""!"
        '
        'st_date
        '
        Me.st_date.Name = "st_date"
        Me.st_date.Size = New System.Drawing.Size(41, 20)
        Me.st_date.Text = "Date"
        '
        'mnuMainToolStrip
        '
        Me.mnuMainToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuMainToolStrip.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.mnuMainToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsMnuFile, Me.tsMnuView, Me.tsMnuWindow, Me.mnuHelp})
        Me.mnuMainToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuMainToolStrip.MdiWindowListItem = Me.tsMnuWindow
        Me.mnuMainToolStrip.Name = "mnuMainToolStrip"
        Me.mnuMainToolStrip.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.mnuMainToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.mnuMainToolStrip.Size = New System.Drawing.Size(1490, 28)
        Me.mnuMainToolStrip.TabIndex = 4
        Me.mnuMainToolStrip.Text = "MenuStrip1"
        '
        'tsMnuFile
        '
        Me.tsMnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_tsBtn_newInvoice})
        Me.tsMnuFile.Name = "tsMnuFile"
        Me.tsMnuFile.Size = New System.Drawing.Size(46, 24)
        Me.tsMnuFile.Text = "File"
        '
        'mnu_tsBtn_newInvoice
        '
        Me.mnu_tsBtn_newInvoice.Name = "mnu_tsBtn_newInvoice"
        Me.mnu_tsBtn_newInvoice.Size = New System.Drawing.Size(224, 26)
        Me.mnu_tsBtn_newInvoice.Text = "New Invoice"
        '
        'tsMnuView
        '
        Me.tsMnuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_TsBtn_ToggleView})
        Me.tsMnuView.Name = "tsMnuView"
        Me.tsMnuView.Size = New System.Drawing.Size(55, 24)
        Me.tsMnuView.Text = "View"
        '
        'mnu_TsBtn_ToggleView
        '
        Me.mnu_TsBtn_ToggleView.Checked = True
        Me.mnu_TsBtn_ToggleView.CheckOnClick = True
        Me.mnu_TsBtn_ToggleView.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnu_TsBtn_ToggleView.Name = "mnu_TsBtn_ToggleView"
        Me.mnu_TsBtn_ToggleView.Size = New System.Drawing.Size(143, 26)
        Me.mnu_TsBtn_ToggleView.Text = "Toolbar"
        '
        'tsMnuWindow
        '
        Me.tsMnuWindow.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_tsBtn_Cascade, Me.mnu_tsBtn_Horizontally, Me.mnu_tsBtn_TileVertically, Me.ToolStripSeparator1})
        Me.tsMnuWindow.Name = "tsMnuWindow"
        Me.tsMnuWindow.Size = New System.Drawing.Size(78, 24)
        Me.tsMnuWindow.Text = "Window"
        '
        'mnu_tsBtn_Cascade
        '
        Me.mnu_tsBtn_Cascade.Name = "mnu_tsBtn_Cascade"
        Me.mnu_tsBtn_Cascade.Size = New System.Drawing.Size(201, 26)
        Me.mnu_tsBtn_Cascade.Text = "Cascade"
        '
        'mnu_tsBtn_Horizontally
        '
        Me.mnu_tsBtn_Horizontally.Name = "mnu_tsBtn_Horizontally"
        Me.mnu_tsBtn_Horizontally.Size = New System.Drawing.Size(201, 26)
        Me.mnu_tsBtn_Horizontally.Text = "Tile Horizontally"
        '
        'mnu_tsBtn_TileVertically
        '
        Me.mnu_tsBtn_TileVertically.Name = "mnu_tsBtn_TileVertically"
        Me.mnu_tsBtn_TileVertically.Size = New System.Drawing.Size(201, 26)
        Me.mnu_tsBtn_TileVertically.Text = "Tile Vertically"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(198, 6)
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_ts_about})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(55, 24)
        Me.mnuHelp.Text = "Help"
        '
        'mnu_ts_about
        '
        Me.mnu_ts_about.Name = "mnu_ts_about"
        Me.mnu_ts_about.Size = New System.Drawing.Size(224, 26)
        Me.mnu_ts_about.Text = "About"
        '
        'ts_ManagementBar
        '
        Me.ts_ManagementBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ts_ManagementBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnTsCustomers, Me.TsBtnProducts})
        Me.ts_ManagementBar.Location = New System.Drawing.Point(0, 28)
        Me.ts_ManagementBar.Name = "ts_ManagementBar"
        Me.ts_ManagementBar.Size = New System.Drawing.Size(1490, 27)
        Me.ts_ManagementBar.TabIndex = 6
        Me.ts_ManagementBar.Text = "Main Toolbar"
        '
        'Timer1
        '
        '
        'btnTsCustomers
        '
        Me.btnTsCustomers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnTsCustomers.Image = Global.Abookstore.My.Resources.Resources._8666546_user_plus_icon
        Me.btnTsCustomers.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTsCustomers.Name = "btnTsCustomers"
        Me.btnTsCustomers.Size = New System.Drawing.Size(29, 24)
        Me.btnTsCustomers.Text = "Customer Mainteinance"
        '
        'TsBtnProducts
        '
        Me.TsBtnProducts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsBtnProducts.Image = Global.Abookstore.My.Resources.Resources.list_check
        Me.TsBtnProducts.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsBtnProducts.Name = "TsBtnProducts"
        Me.TsBtnProducts.Size = New System.Drawing.Size(29, 24)
        Me.TsBtnProducts.Text = "Product Button"
        '
        'Frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1490, 744)
        Me.Controls.Add(Me.statusStrip)
        Me.Controls.Add(Me.ts_ManagementBar)
        Me.Controls.Add(Me.mnuMainToolStrip)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Frm_main"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Bookstore"
        Me.statusStrip.ResumeLayout(False)
        Me.statusStrip.PerformLayout()
        Me.mnuMainToolStrip.ResumeLayout(False)
        Me.mnuMainToolStrip.PerformLayout()
        Me.ts_ManagementBar.ResumeLayout(False)
        Me.ts_ManagementBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents statusStrip As StatusStrip
    Friend WithEvents mnuMainToolStrip As MenuStrip
    Friend WithEvents tsMnuFile As ToolStripMenuItem
    Friend WithEvents tsMnuView As ToolStripMenuItem
    Friend WithEvents tsMnuWindow As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents ts_ManagementBar As ToolStrip
    Friend WithEvents btnTsCustomers As ToolStripButton
    Friend WithEvents TsBtnProducts As ToolStripButton
    Friend WithEvents mnu_tsBtn_Cascade As ToolStripMenuItem
    Friend WithEvents mnu_tsBtn_Horizontally As ToolStripMenuItem
    Friend WithEvents mnu_tsBtn_TileVertically As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnu_ts_about As ToolStripMenuItem
    Friend WithEvents mnu_TsBtn_ToggleView As ToolStripMenuItem
    Friend WithEvents mnu_tsBtn_newInvoice As ToolStripMenuItem
    Friend WithEvents ts_lbl_greeting As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ts_lbl_date As ToolStripStatusLabel
    Friend WithEvents Clock As ToolStripStatusLabel
    Friend WithEvents st_date As ToolStripStatusLabel
End Class
