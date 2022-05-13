Imports System.Data.SqlClient
Public Class getByID
    Private _CustId As Integer = 1
    Private ConnectionString As String = (My.Settings.MMABooksConnectionString.ToString)

    Private Function GetConnectionString() As String
        Return ConnectionString
    End Function

    Private Property CustId As Integer
        Get
            Return _CustId
        End Get
        Set
            _CustId = Value
        End Set
    End Property

    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MMABooksDataSet)

    End Sub

    Private Sub btnGet_Click(sender As Object, e As EventArgs) Handles btnGet.Click
        Dim custQueryID As Integer

        custQueryID = Me.CustomerIDNumericUpDown.Value


    End Sub

    Private Sub getByID_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As New String(GetConnectionString())
        Dim db As New SqlConnection(Me.GetConnectionString())


    End Sub
End Class
