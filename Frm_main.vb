Public Class Frm_main
    Inherits Form

    Public thisMdiParent As Form
    Private Sub Frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Timer1.Interval = 1000
        statusStrip.Padding = New System.Windows.Forms.Padding(1, 0, statusStrip.ImageScalingSize.Width, 0) '****
        Timer1.Start()
        Me.st_date.Text = Today.ToShortDateString
    End Sub

    Private Sub BtnTsCustomers_Click(sender As Object, e As EventArgs) Handles btnTsCustomers.Click

        ' sets the parent of the customer window to be this 
        Dim myChild As New CustomerEdit(Me)
        '   myChild.MdiParent = Me 'Redundant line?
        myChild.Show()
    End Sub

    Private Sub BtnTsProducts_Click(sender As Object, e As EventArgs) Handles TsBtnProducts.Click
        Dim myChildProducts As New Product(Me)
        myChildProducts.Show()

    End Sub


    ''' <summary>
    ''' If bar is checked (default) show toolbar, if not, hide it
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnu_TsBtn_ToggleView_Click(sender As Object, e As EventArgs) Handles mnu_TsBtn_ToggleView.Click

        ts_ManagementBar.Visible = Me.mnu_TsBtn_ToggleView.Checked



    End Sub

    Private Sub mnu_tsBtn_Cascade_Click(sender As Object, e As EventArgs) Handles mnu_tsBtn_Cascade.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub mnu_tsBtn_Horizontally_Click(sender As Object, e As EventArgs) Handles mnu_tsBtn_Horizontally.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub mnu_tsBtn_TileVertically_Click(sender As Object, e As EventArgs) Handles mnu_tsBtn_TileVertically.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Me.Clock.Text = Format(Now, "H:mm:ss")

    End Sub

    Private Sub st_date_Click(sender As Object, e As EventArgs) Handles st_date.Click

    End Sub

    Private Sub mnu_ts_about_Click(sender As Object, e As EventArgs) Handles mnu_ts_about.Click
        Dim NewEasterEgg As New EasterEgg
        NewEasterEgg.Show()

    End Sub

    Private Sub mnu_tsBtn_newInvoice_Click(sender As Object, e As EventArgs) Handles mnu_tsBtn_newInvoice.Click
        Dim newEasterEgg As New EasterEgg()
        newEasterEgg.Show()
    End Sub
End Class

