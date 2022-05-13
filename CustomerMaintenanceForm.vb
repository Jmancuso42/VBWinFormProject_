Public Class CustomerMaintenanceForm
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblCustID.Click

    End Sub

    Private Sub CustomerMaintenanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMABooksDataSet.States' table. You can move, or remove it, as needed.
        Me.StatesTableAdapter.Fill(Me.MMABooksDataSet.States)

    End Sub
    '
    '  Private Sub FillByStatesToolStripButton_Click(sender As Object, e As EventArgs)
    '  Try
    '  Me.StatesTableAdapter.FillByStates(Me.MMABooksDataSet.States)
    ' Catch ex As System.Exception
    '         System.Windows.Forms.MessageBox.Show(ex.Message)
    ' End Try

    '  End Sub



    Private Sub btn_getID_Click(sender As Object, e As EventArgs) Handles btn_getID.Click

    End Sub

    Private Sub tsb_save_Click(sender As Object, e As EventArgs) Handles tsb_save.Click
        'get changes from textbox, update database entries, ???, Profit 
    End Sub
End Class