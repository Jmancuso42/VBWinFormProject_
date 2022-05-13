Imports System.Data.SqlClient
Imports System.Configuration
Imports Abookstore.HelperMod
Imports Microsoft.VisualBasic.Logging
Imports System.ComponentModel

Public Class CustomerEdit
    Inherits Form
    ' Check indivudal customers,pull up their invoices 
    Dim thisMDIParent As Form

    Public Sub New(parent As Form)
        InitializeComponent()
        thisMDIParent = parent
    End Sub

    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomersBindingNavigatorSaveItem.Click

        Me.Validate()
        Try
            Me.CustomersBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MMABooksDataSet)

        Catch ex As system.ApplicationException
            Console.Write(ex.Message)

        Catch ex As DBConcurrencyException
            MessageBox.Show("A concurrency error occurred. " &
                    "Some rows were not updated.", "Concurrency Error")
            'attempt to refill the database
            Me.CustomersTableAdapter.Fill(Me.MMABooksDataSet.Customers)
        Catch ex As DataException
            MessageBox.Show(ex.Message, ex.GetType.ToString)
            CustomersBindingSource.CancelEdit() ' stop the data exception from being applied 
        Catch ex As SqlException
            MessageBox.Show("Database error # " & ex.Number &
                ": " & ex.Message, ex.GetType.ToString)

        Catch ex As Exception
            Console.Write(ex.Message)
        End Try
    End Sub

    Private Sub CustomerEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMABooksDataSet.Invoices' table. You can move, or remove it, as needed.
        Me.InvoicesTableAdapter.Fill(Me.MMABooksDataSet.Invoices)
        'TODO: This line of code loads data into the 'MMABooksDataSet.InvoiceLineItems' table. You can move, or remove it, as needed.
        Me.InvoiceLineItemsTableAdapter.Fill(Me.MMABooksDataSet.InvoiceLineItems)
        Me.MdiParent = thisMDIParent
        Me.CustomerIDToolStripTextBox.Text = "1" 'keeps null errors away
        'TODO: This line of code loads data into the 'MMABooksDataSet.States' table.
        Me.StatesTableAdapter.Fill(Me.MMABooksDataSet.States)
        'TODO: This line of code loads data into the 'MMABooksDataSet.Invoices' table. 
        Me.InvoicesTableAdapter.Fill(Me.MMABooksDataSet.Invoices)
        'TODO: This line of code loads data into the 'MMABooksDataSet.Customers' table. 
        Me.CustomersTableAdapter.Fill(Me.MMABooksDataSet.Customers)

    End Sub

    Private Sub FillByIDToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByIDToolStripButton.Click
        Try
            If Validator.HasNoNullTextBoxes(Me) Then
                'EnterClick(sender, e)
                Me.CustomersTableAdapter.FillByID(Me.MMABooksDataSet.Customers, CType(CustomerIDToolStripTextBox.Text, Integer))
            End If
        Catch ex As System.Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub


    Private Sub BtnViewInvoice_Click(sender As Object, e As EventArgs) Handles btnViewInvoice.Click
        Dim customerInvoicesForm As New CustomerInvoices With {
            .customerName = txtCustomerName.Text,
            .customerID = CInt(CustomerIDToolStripTextBox.Text)
        }
        customerInvoicesForm.MdiParent = thisMDIParent
        customerInvoicesForm.Show()
        customerInvoicesForm.BringToFront()
    End Sub

    ''' <summary>
    ''' increments the ID up or down on keypress and submits a query upon pressing enter
    ''' It replaces the need to mouseclick for a query
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub EnterClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CustomerIDToolStripTextBox.KeyDown
        Try
            If Validator.IsPresent(CustomerIDToolStripTextBox) = True Then

                If e.KeyCode.Equals(Keys.Enter) Then
                    FillByIDToolStripButton_Click(sender, e)

                    e.Handled = True
                    e.SuppressKeyPress = True
                End If
                ' i tried to make the condition also factor in how many entries there are, but it was getting out of hand with issues
                If e.KeyCode.Equals(Keys.Up) Then
                    CustomerIDToolStripTextBox.Text = (CInt(CustomerIDToolStripTextBox.Text) + 1).ToString
                    'FillByIDToolStripButton_Click(sender, e) removed because too many rapid fire queries breaks the data retrieval

                    e.Handled = True
                    e.SuppressKeyPress = True
                End If
                'If the number is greater than 0, decrement on event. there are more sound ways to do this, but it works.
                If e.KeyCode.Equals(Keys.Down) And CInt(CustomerIDToolStripTextBox.Text) > 0 Then
                    CustomerIDToolStripTextBox.Text = (CInt(CustomerIDToolStripTextBox.Text) - 1).ToString
                    '  FillByIDToolStripButton_Click(sender, e)
                    e.Handled = True
                    e.SuppressKeyPress = True
                End If
            End If
        Catch ex As InvalidCastException
            Console.WriteLine(ex.Message)

        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try
    End Sub



End Class