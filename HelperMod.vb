Imports System.Data.SqlClient
Imports System.Configuration
Imports Abookstore.MMABooksDataSetTableAdapters

Module HelperMod


    ' I didn't want to keep dipping into validator and customer classes for helper functions



    Public connect As New SqlConnection(My.Settings.MMABooksConnectionString)


    ''' <summary>
    ''' Returns the number of rows in the customer table
    ''' </summary>
    ''' <returns>int of table rows of cust id</returns>
    Public Function GetTableRowCount() As Integer

        'doesn't seem to work smoothly

        'How could I do this without having a static string? 

        Dim count As Decimal
        Dim query As String = "SELECT COUNT(*) AS RETURNCOUNT FROM CUSTOMERS"



        Using connect
            Using cmd As New SqlCommand()
                With cmd
                    .Connection = connect
                    .CommandText = query
                    .CommandType = CommandType.Text
                End With
                Try
                    connect.Open()
                    count = CInt(cmd.ExecuteScalar())

                Catch ex As DBConcurrencyException
                    MessageBox.Show("A concurrency error occurred. " &
                    "Some rows were not updated.", "Concurrency Error")
                    MessageBox.Show("Database error # " &
                ": " & ex.Message, ex.GetType.ToString)

                Catch ex As SqlException
                    MsgBox(ex.Message)

                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    'if command has nothing then close 
                    If cmd IsNot Nothing Then
                        cmd.Dispose()
                        connect.Close()
                        connect.Dispose()
                    End If
                End Try

                Return count
            End Using
        End Using
    End Function

End Module

