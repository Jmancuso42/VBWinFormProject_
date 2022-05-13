Imports System.Data.DataTable
Imports System.Data.SqlClient
Imports Abookstore.HelperMod
Public Class Validator


    Public Shared Property Title As String = "Entry Error"

    ''' <summary>
    ''' evaluates if present, is int and if it falls within the rowCount for Customers
    ''' </summary>
    ''' <param name="textBox"></param>
    ''' <returns></returns>
    Public Shared Function IsLegitInt(textBox As TextBox) _
        As Boolean

        'dim dbRange as Decimal = CDec(From total in )
        If IsPresent(textBox) = True AndAlso IsInt32(textBox) = True AndAlso IsWithinRange(textBox, 0, GetTableRowCount) Then


            Return True
        Else
            Return False
        End If

    End Function


    ''' <summary>
    ''' checks combo boxes and textboces for not being null in a form 
    ''' </summary>
    ''' <param name="form">Windows form</param>
    ''' <returns></returns>
    Public Shared Function HasNoNullTextBoxes(form As Form) _
        As Boolean
        Dim emptyBoxes =
            From txt In form.Controls.OfType(Of TextBox), ctxt In form.Controls.OfType(Of ComboBox)
            Where txt.Text.Length = 0 Or ctxt.Text.Length = 0
            Select txt.Name Or ctxt.Name

        If emptyBoxes.Any Then
            MessageBox.Show(String.Format("The following textboxes are empty and cannot be {0} ",
                                          String.Join(",", emptyBoxes)))
            Return False
        Else
            Return True
        End If

    End Function

    Public Shared Function IsPresent(textBox As TextBox) _
            As Boolean
        If textBox.Text = "" Then
            MessageBox.Show(textBox.Tag.ToString & " is a required field.", Title)
            textBox.Select()
            Return False
        Else
            Return True
        End If
    End Function
    Public Shared Function IsPresent(textBox As ToolStripTextBox) _
            As Boolean

        Try
            If textBox.Text = "" Then
                MessageBox.Show(textBox.Tag.ToString & " is a required field.", Title)
                textBox.Select()
                Return False
            Else
                Return True
            End If
        Catch ex As ArgumentException
            Console.Write(ex.Message)
        Catch ex As Exception
            Console.Write(ex.Message)
        End Try
    End Function


    Public Shared Function IsDecimal(textBox As TextBox) _
            As Boolean
        Dim number As Decimal = 0
        If Decimal.TryParse(textBox.Text, number) Then
            Return True
        Else
            MessageBox.Show(textBox.Tag.ToString & " must be a decimal value.", Title)
            textBox.Select()
            textBox.SelectAll()
            Return False
        End If
    End Function

    Public Shared Function IsInt32(textBox As TextBox) _
            As Boolean
        Dim number As Integer = 0
        If Int32.TryParse(textBox.Text, number) Then
            Return True
        Else
            MessageBox.Show(textBox.Tag.ToString & " must be an integer value.", Title)
            textBox.Select()
            textBox.SelectAll()
            Return False
        End If
    End Function

    Public Shared Function IsWithinRange(textBox As TextBox,
            min As Decimal, max As Decimal) As Boolean
        Dim number As Decimal = CDec(textBox.Text)
        If number < min OrElse number > max Then
            MessageBox.Show(textBox.Tag.ToString & " must be between " &
                min & " and " & max & ".", Title)
            textBox.Select()
            textBox.SelectAll()
            Return False
        Else
            Return True
        End If
    End Function

    Public Shared Function IsSelected(comboBox As ComboBox) As Boolean
        If comboBox.SelectedIndex < 0 Then
            MessageBox.Show("You must select a value for " & comboBox.Tag.ToString &
                ".", Title)
            comboBox.Select()
            Return False
        Else
            Return True
        End If
    End Function

End Class
