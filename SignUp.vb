Imports System.Data.OleDb

Public Class SignUp
    Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\UTM SEM 5\VBNET\UTMCONNECT\CODING\UTMConnect(Aina)1.accdb;"
    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        ' Collect user input from text boxes
        Dim fullName As String = FullNameTextBox.Text
        Dim username As String = UsernameTextBox.Text
        Dim email As String = EmailTextBox.Text
        Dim password As String = PasswordTextBox.Text
        Dim confirmPassword As String = ConfirmPasswordTextBox.Text
        Dim role As String = If(CustomerRoleButton.BackColor = Color.Indigo, "Customer", "Seller") ' Check selected role based on button color
        Dim userID As String = GenerateUserID(role)

        ' Basic validation
        If String.IsNullOrEmpty(fullName) Or String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(email) Or String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please fill in all fields.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if passwords match
        If password <> confirmPassword Then
            MessageBox.Show("Passwords do not match. Please re-enter.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using connection As New OleDbConnection(connectionString)
            Try
                ' Open the connection
                connection.Open()

                ' Check if the username or email already exists
                Dim checkQuery As String = "SELECT COUNT(*) FROM Users WHERE Username = @Username OR Email = @Email"
                Using checkCmd As New OleDbCommand(checkQuery, connection)
                    checkCmd.Parameters.AddWithValue("@Username", username)
                    checkCmd.Parameters.AddWithValue("@Email", email)

                    Dim existingUserCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                    If existingUserCount > 0 Then
                        MessageBox.Show("Username or email is already registered. Please use a different one.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using

                ' Insert the new user into the database with generated UserID and RoleName
                Dim insertQuery As String = "INSERT INTO Users (UserID, FullName, Username, Email, [Password], RoleName) VALUES (@UserID, @FullName, @Username, @Email, @Password, @RoleName)"
                Using insertCmd As New OleDbCommand(insertQuery, connection)
                    insertCmd.Parameters.AddWithValue("@UserID", userID)
                    insertCmd.Parameters.AddWithValue("@FullName", fullName)
                    insertCmd.Parameters.AddWithValue("@Username", username)
                    insertCmd.Parameters.AddWithValue("@Email", email)
                    insertCmd.Parameters.AddWithValue("@Password", password) ' Assuming password is plain text, consider hashing in production
                    insertCmd.Parameters.AddWithValue("@RoleName", role) ' Store the role (Customer or Seller)

                    ' Execute the insertion
                    insertCmd.ExecuteNonQuery()
                    MessageBox.Show("Registration successful! You can now sign in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    SignIn.Show()
                    Me.Close()
                End Using
            Catch ex As Exception
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Close the connection
                connection.Close()
            End Try
        End Using
    End Sub

    ' Function to generate the next user ID based on role
    Private Function GenerateUserID(role As String) As String
        Dim prefix As String = If(role = "Customer", "C", "S")
        Dim latestID As String = ""
        Dim nextNumber As Integer

        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            ' Query to get the latest UserID based on role prefix
            Dim query As String = $"SELECT TOP 1 UserID FROM Users WHERE UserID LIKE '{prefix}%' ORDER BY UserID DESC"
            Using cmd As New OleDbCommand(query, connection)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    latestID = result.ToString()
                    ' Extract the numeric part and increment
                    nextNumber = Convert.ToInt32(latestID.Substring(1)) + 1
                Else
                    ' If no existing ID, start from 1
                    nextNumber = 1
                End If
            End Using
        End Using

        ' Format the new ID as C01, C02, etc.
        Return $"{prefix}{nextNumber.ToString("D2")}"
    End Function

    ' Role selection event handlers with color update
    Private Sub CustomerRoleButton_Click(sender As Object, e As EventArgs) Handles CustomerRoleButton.Click
        ' Set background and text color for Customer role
        CustomerRoleButton.BackColor = Color.Indigo
        CustomerRoleButton.ForeColor = Color.White

        ' Reset the background and text color for Seller role
        SellerRoleButton.BackColor = SystemColors.ControlLightLight
        SellerRoleButton.ForeColor = Color.Black
    End Sub

    Private Sub SellerRoleButton_Click(sender As Object, e As EventArgs) Handles SellerRoleButton.Click
        ' Set background and text color for Seller role
        SellerRoleButton.BackColor = Color.Indigo
        SellerRoleButton.ForeColor = Color.White

        ' Reset the background and text color for Customer role
        CustomerRoleButton.BackColor = SystemColors.ControlLightLight
        CustomerRoleButton.ForeColor = Color.Black
    End Sub

End Class
