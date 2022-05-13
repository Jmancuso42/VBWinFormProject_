Public Class CustomerInvoices

    Public customerID As Integer
    Public customerName As String
    Dim isOrderedByDate As Boolean = False

    Private Sub CustomerInvoices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMABooksDataSet.Invoices' table.
        Me.lbl_CustName.Text = (lbl_CustName.Text & " " & vbCrLf & customerName)
        Me.InvoicesTableAdapter.FillByCustomerID(Me.MMABooksDataSet.Invoices, customerID)

    End Sub

    Private Sub FillByOrderDateToolStripButton_Click(sender As Object, e As EventArgs)
        Me.InvoicesTableAdapter.FillByOrderDate(Me.MMABooksDataSet.Invoices, customerID)
    End Sub

    ''' <summary>
    ''' Fills by date if isOrdered is false(default) elseIf is True, fills by CustID w ascending invoices
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnInvoicesDate(sender As Object, e As EventArgs) Handles btnInvoiceDate.Click
        '
        Try
            If isOrderedByDate = False Then
                Me.InvoicesTableAdapter.FillByOrderDate(Me.MMABooksDataSet.Invoices, customerID)
                isOrderedByDate = True
            ElseIf isOrderedByDate = True Then
                Me.InvoicesTableAdapter.FillByCustomerID(Me.MMABooksDataSet.Invoices, customerID)
                isOrderedByDate = False
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class