Imports System.Data.OleDb

Public Class SignIn
    Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\UTM SEM 5\VBNET\UTMCONNECT\CODING\UTMConnect(Aina)1.accdb;"

    Private Sub SignInButton_Click(sender As Object, e As EventArgs) Handles SignInButton.Click
        ' Fetch the username and password entered by the user
        Dim username As String = UsernameTextBox.Text
        Dim password As String = passwordTextBox.Text

        ' Check if fields are not empty
        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using connection As New OleDbConnection(connectionString)
            Try
                ' Open the database connection
                connection.Open()

                ' SQL query to check if the user exists with the entered credentials and retrieve their RoleID
                Dim query As String = "SELECT RoleID FROM Users WHERE Username = @username AND Password = @password"
                Using cmd As New OleDbCommand(query, connection)
                    ' Add parameters to prevent SQL Injection
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)

                    ' Execute the query and retrieve the RoleID
                    Dim roleID As Object = cmd.ExecuteScalar()

                    If roleID IsNot Nothing Then
                        ' Check if the RoleID contains "C" or "Customer" for Customer, "S" or "Seller" for Seller
                        Dim roleIDStr As String = roleID.ToString()

                        If roleIDStr.Contains("C") Or roleIDStr.Contains("Customer") Then
                            ServicesPage_Customer_.Show()
                            Me.Hide()
                        ElseIf roleIDStr.Contains("S") Or roleIDStr.Contains("Seller") Then
                            Homepage_Seller_.Show()
                            Me.Hide()
                        ElseIf roleIDStr.Contains("A") Or roleIDStr.Contains("Admin") Then
                            Homepage_Admin_.Show()
                            Me.Hide()
                        Else
                            MessageBox.Show("Unknown role. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("Incorrect Username or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    Private Sub forgotPasswordLabel_Click(sender As Object, e As EventArgs) Handles forgotPasswordLabel.Click
        ' Prompt the user to enter their registered email address
        Dim email As String = InputBox("Please enter your registered email address for password recovery:", "Forgot Password")

        ' Check if the email field is not empty
        If String.IsNullOrEmpty(email) Then
            MessageBox.Show("Oops! You forgot to enter an email address. Please try again.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using connection As New OleDbConnection(connectionString)
            Try
                ' Open the database connection
                connection.Open()

                ' SQL query to check if the email exists in the database
                Dim query As String = "SELECT COUNT(*) FROM Users WHERE Email = @Email"
                Using cmd As New OleDbCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Email", email)

                    ' Execute the query
                    Dim emailExists As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If emailExists > 0 Then
                        ' Email found in the database
                        Dim newPassword As String = InputBox("Please enter your new password:", "Reset Password")
                        Dim confirmPassword As String = InputBox("Please confirm your new password:", "Confirm Password")

                        ' Check if both password entries match
                        If newPassword = confirmPassword AndAlso Not String.IsNullOrEmpty(newPassword) Then
                            ' Update the password in the database
                            Dim updateQuery As String = "UPDATE Users SET [Password] = @Password WHERE Email = @Email"
                            Using updateCmd As New OleDbCommand(updateQuery, connection)
                                updateCmd.Parameters.AddWithValue("@Password", newPassword)
                                updateCmd.Parameters.AddWithValue("@Email", email)

                                Dim rowsAffected As Integer = updateCmd.ExecuteNonQuery()
                                If rowsAffected > 0 Then
                                    MessageBox.Show("Your password has been successfully reset. You can now sign in with your new password.", "Password Reset Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Else
                                    MessageBox.Show("No changes were made. Please check the email address and try again.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                End If
                            End Using
                        Else
                            MessageBox.Show("The passwords do not match or were left empty. Please try again.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    Else
                        ' Email not found
                        MessageBox.Show("It seems like this email is not registered. Please check the email address or contact support if you need further assistance.", "Email Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End Using
            Catch ex As Exception
                ' Handle any errors that occur during the database operation
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Close the connection
                connection.Close()
            End Try
        End Using
    End Sub




End Class