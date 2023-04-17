Public Class MainForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        SplashScreenForm.Close()
        Me.Close()
    End Sub



    Private Sub MainForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        'SplashScreenForm.Show()
        'Me.Hide()
    End Sub
End Class
