Public Class Invoices
    Inherits Form

    Dim invoicesParent As CustomerEdit
    Public Property CustID As Integer

    ''' <summary>
    ''' Cretes new invoice form that takes a customerID and a form class object that acts as a parent.
    ''' </summary>
    ''' <param name=""></param>
    ''' <param name="custID"></param>
    Public Sub New(parent As Form, custID As Integer)
        MdiParent = parent.Parent
        invoicesParent = parent 'not sure if there is a better way of making another form's elements accessible, this feels sloppy
        Try
            InitializeComponent()
        Catch ex As ArgumentException
            Console.WriteLine(ex.Message)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' New invoices with a form passed into it to access it  
    ''' </summary>
    ''' <param name="cust"></param>
    Private Sub Invoices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.InvoicesTableAdapter.FillBy1(Me.MMABooksDataSet.Invoices, CType(CustID, Integer))
        Me.lblName.Text = invoicesParent.NameTextBox.Text

    End Sub

End Class