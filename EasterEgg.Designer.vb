<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EasterEgg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EasterEgg))
        Me.lblEasteregg = New System.Windows.Forms.Label()
        Me.pb_python = New System.Windows.Forms.PictureBox()
        CType(Me.pb_python, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEasteregg
        '
        Me.lblEasteregg.AutoSize = True
        Me.lblEasteregg.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEasteregg.Location = New System.Drawing.Point(12, 9)
        Me.lblEasteregg.Name = "lblEasteregg"
        Me.lblEasteregg.Size = New System.Drawing.Size(181, 19)
        Me.lblEasteregg.TabIndex = 1
        Me.lblEasteregg.Text = "Written By Joey Mancuso :)"
        '
        'pb_python
        '
        Me.pb_python.Cursor = System.Windows.Forms.Cursors.Default
        Me.pb_python.Image = CType(resources.GetObject("pb_python.Image"), System.Drawing.Image)
        Me.pb_python.Location = New System.Drawing.Point(37, 54)
        Me.pb_python.Name = "pb_python"
        Me.pb_python.Size = New System.Drawing.Size(839, 516)
        Me.pb_python.TabIndex = 0
        Me.pb_python.TabStop = False
        '
        'EasterEgg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 582)
        Me.Controls.Add(Me.lblEasteregg)
        Me.Controls.Add(Me.pb_python)
        Me.Name = "EasterEgg"
        Me.Text = "Aha! You weren't expecting *this*"
        CType(Me.pb_python, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pb_python As PictureBox
    Friend WithEvents lblEasteregg As Label
End Class
