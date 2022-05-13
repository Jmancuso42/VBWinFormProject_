Public Class CustomerMaintainence


    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MMABooksDataSet)

    End Sub

    Private Sub CustomerMaintanence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMABooksDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.MMABooksDataSet.Customers)

    End Sub

End Class