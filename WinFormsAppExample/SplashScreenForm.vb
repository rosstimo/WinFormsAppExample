Public Class SplashScreenForm
    Private Sub SplashScreenForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SplashTimer.Enabled = True
    End Sub

    Private Sub SplashScreenForm_Click(sender As Object, e As EventArgs) Handles Me.Click, SplashTimer.Tick
        MainForm.Show()
        Me.Hide()
        'Me.Close()
    End Sub


End Class