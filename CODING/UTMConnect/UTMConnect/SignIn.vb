Public Class SignIn
    Private Sub HomePageButton_Click(sender As Object, e As EventArgs) Handles HomePageButton.Click
        Me.Hide()
        WelcomePage.Show()
    End Sub
    Private Sub JoinUsButton_Click(sender As Object, e As EventArgs) Handles JoinUsButton.Click
        Me.Hide()
        SignUp.Show()
    End Sub

    Private Sub SignInButton_Click(sender As Object, e As EventArgs) Handles SignInButton.Click
        Me.Show()
    End Sub

    Private Sub RegisterzButton_Click(sender As Object, e As EventArgs) Handles RegisterzButton.Click
        Me.Hide()
        SignUp.Show()
    End Sub
End Class