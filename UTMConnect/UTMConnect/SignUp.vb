Imports System.Data.OleDb
Imports Microsoft.VisualBasic.ApplicationServices

Public Class SignUp
    ' Declare variables for form data and selected role
    Private selectedRole As String = ""
    ' Connection string for the UTMConnect.accdb database
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\UTM SEM 5\VBNET\UTMCONNECT\CODING\UTMConnect(Aina)1.accdb"

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

        ' Generate unique RoleID for the new user
        Dim roleID As String = GenerateRoleID()

        ' Insert user into database
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                ' Check if the username or email already exists
                Dim checkUserCmd As New OleDbCommand("SELECT COUNT(*) FROM Users WHERE Username = @Username OR Email = @Email", connection)
                checkUserCmd.Parameters.AddWithValue("@Username", UsernameTextBox.Text)
                checkUserCmd.Parameters.AddWithValue("@Email", EmailTextBox.Text)

                Dim userExists As Integer = CInt(checkUserCmd.ExecuteScalar())
                If userExists > 0 Then
                    MessageBox.Show("Username or Email already exists.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                ' Insert new user record in Users table
                Dim insertUserCmd As New OleDbCommand("INSERT INTO Users (FullName, Username, Email, [Password], RoleID) VALUES (@FullName, @Username, @Email, @Password, @RoleID)", connection)
                insertUserCmd.Parameters.AddWithValue("@FullName", FullNameTextBox.Text)
                insertUserCmd.Parameters.AddWithValue("@Username", UsernameTextBox.Text)
                insertUserCmd.Parameters.AddWithValue("@Email", EmailTextBox.Text)
                insertUserCmd.Parameters.AddWithValue("@Password", PasswordTextBox.Text) ' Note: For real applications, use hashing here
                insertUserCmd.Parameters.AddWithValue("@RoleID", roleID)
                insertUserCmd.ExecuteNonQuery()

                ' Insert new customer record in Customer table if role is Customer
                If selectedRole = "Customer" Then
                    Dim insertCustomerCmd As New OleDbCommand("INSERT INTO Customer (CustomerID, FullName, Email, [Password]) VALUES (@CustomerID, @FullName, @Email, @Password)", connection)
                    insertCustomerCmd.Parameters.AddWithValue("@CustomerID", roleID)
                    insertCustomerCmd.Parameters.AddWithValue("@FullName", FullNameTextBox.Text)
                    insertCustomerCmd.Parameters.AddWithValue("@Email", EmailTextBox.Text)
                    insertCustomerCmd.Parameters.AddWithValue("@Password", PasswordTextBox.Text)
                    insertCustomerCmd.ExecuteNonQuery()
                End If

                MessageBox.Show("Registration successful! Welcome, " & FullNameTextBox.Text & "!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Clear the form after successful registration
                ClearForm()
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while registering: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Generate a unique RoleID based on the selected role
    Private Function GenerateRoleID() As String
        Dim prefix As String = If(selectedRole = "Customer", "C", "S")
        Dim newID As String = prefix & "01" ' Default ID if no other exists

        Using connection As New OleDbConnection(connectionString)
            connection.Open()
            ' Get the latest RoleID for the selected role type
            Dim getMaxRoleIDCmd As New OleDbCommand("SELECT TOP 1 RoleID FROM Users WHERE RoleID LIKE @Prefix ORDER BY RoleID DESC", connection)
            getMaxRoleIDCmd.Parameters.AddWithValue("@Prefix", prefix & "%")

            Dim result As Object = getMaxRoleIDCmd.ExecuteScalar()
            If result IsNot Nothing Then
                Dim lastID As String = result.ToString()
                Dim numericPart As Integer = Integer.Parse(lastID.Substring(1)) + 1
                newID = prefix & numericPart.ToString("D2") ' Ensures 2-digit format
            End If
        End Using

        Return newID
    End Function

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
    Private Sub SignInzButton_Click(sender As Object, e As EventArgs) Handles SignInLabel2.Click
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
