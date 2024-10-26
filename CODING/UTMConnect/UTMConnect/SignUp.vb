Public Class SignUp
    Private Sub JoinUsButton_Click(sender As Object, e As EventArgs) Handles JoinUsButton.Click
        Me.Show()
    End Sub

    Private Sub SignInButton_Click(sender As Object, e As EventArgs) Handles SignInButton.Click
        Me.Hide()
        SignIn.Show()
    End Sub

    Private Sub SignInzButton_Click(sender As Object, e As EventArgs) Handles SignInButton.Click
        Me.Hide()
        SignIn.Show()
    End Sub

    Private Sub HomePageButton_Click(sender As Object, e As EventArgs) Handles HomePageButton.Click
        Me.Hide()
        WelcomePage.Show()
    End Sub
End Class