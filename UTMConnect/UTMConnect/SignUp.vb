Public Class SignUp
    ' Declare variables for form data and selected role
    Private selectedRole As String = ""

    ' Handle Register button click event
    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        ' Validate all required fields
        If FullNameTextBox.Text = "" Or UsernameTextBox.Text = "" Or EmailTextBox.Text = "" Or
           PasswordTextBox.Text = "" Or ConfirmPasswordTextBox.Text = "" Then
            MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if passwords match
        If PasswordTextBox.Text <> ConfirmPasswordTextBox.Text Then
            MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if a role is selected
        If selectedRole = "" Then
            MessageBox.Show("Please select a role (Customer or Seller).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Register the user (further logic needed to integrate database/store user info)
        MessageBox.Show("Registration successful! Welcome, " & FullNameTextBox.Text & "!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Clear the form after successful registration
        ClearForm()
    End Sub

    ' Handle Customer Role button click event
    Private Sub CustomerRoleButton_Click(sender As Object, e As EventArgs) Handles CustomerRoleButton.Click
        selectedRole = "Customer"
        MessageBox.Show("You selected Customer Role.", "Role Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Handle Seller Role button click event
    Private Sub SellerRoleButton_Click(sender As Object, e As EventArgs) Handles SellerRoleButton.Click
        selectedRole = "Seller"
        MessageBox.Show("You selected Seller Role.", "Role Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Handle Sign In label click event to navigate to the login form
    Private Sub SignInzButton_Click(sender As Object, e As EventArgs) Handles SignInzButton.Click
        Dim loginForm As New SignIn()
        loginForm.Show()
        Me.Close()
    End Sub

    ' Method to clear the form fields after successful registration
    Private Sub ClearForm()
        FullNameTextBox.Clear()
        UsernameTextBox.Clear()
        EmailTextBox.Clear()
        PasswordTextBox.Clear()
        ConfirmPasswordTextBox.Clear()
        selectedRole = ""
    End Sub
End Class
