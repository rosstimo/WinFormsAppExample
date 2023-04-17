Public Class MainForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitTopMenuItem.Click, ExitContextMenuItem.Click

        SplashScreenForm.Close()
        Me.Close()
    End Sub



    Private Sub MainForm_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        'SplashScreenForm.Show()
        'Me.Hide()
    End Sub

    Private Sub AboutMenuItem_Click(sender As Object, e As EventArgs) Handles AboutTopMenuItem.Click
        AboutForm.Show()
        'Me.Hide()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Me.Hide()
        SplashScreenForm.Show()
    End Sub
End Class
