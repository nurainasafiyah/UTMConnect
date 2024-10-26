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

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        ' Get Username and Password inputs
        Dim username As String = UsernameTextBox.Text
        Dim password As String = TextBox1.Text

        ' Basic Validation
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' Authentication and role-based navigation
            If username = "admin" AndAlso password = "password" Then

                Me.Hide()
                Homepage_Admin_.Show()
            ElseIf username = "customer" AndAlso password = "password" Then

                Me.Hide()
                HomePage_Customer_.Show()
            ElseIf username = "seller" AndAlso password = "password" Then

                Me.Hide()
                Homepage_Seller_.Show()
            Else
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

End Class
