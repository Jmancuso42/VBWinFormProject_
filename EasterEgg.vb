Public Class EasterEgg
    Private Sub EasterEgg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            My.Computer.Audio.Play("\Abookstore\resources\unexpected.wav")
        Catch ex As System.IO.FileNotFoundException
            Console.WriteLine(ex.Message)
        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblEasteregg.Click

    End Sub

    Private Sub playSound()

    End Sub
    Private Sub pb_python_Click(sender As Object, e As EventArgs) Handles pb_python.Click

    End Sub
End Class