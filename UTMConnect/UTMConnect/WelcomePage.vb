Public Class WelcomePage
    Private Sub JoinUsButton_Click(sender As Object, e As EventArgs) Handles JoinUsButton.Click
        Me.Hide()
        SignUp.Show()
    End Sub

    Private Sub SignInButton_Click(sender As Object, e As EventArgs) Handles SignInButton.Click
        Me.Hide()
        SignIn.Show()
    End Sub
End Class
