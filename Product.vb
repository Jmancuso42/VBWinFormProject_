Public Class Product
    Public thisMdiParent As Form
    Public Sub New(ByVal parent As Form)

        InitializeComponent()
        MdiParent = parent
        thisMdiParent = parent


    End Sub
    Private Sub Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMABooksDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.MMABooksDataSet.Products)
        Me.MdiParent = thisMdiParent

    End Sub

End Class