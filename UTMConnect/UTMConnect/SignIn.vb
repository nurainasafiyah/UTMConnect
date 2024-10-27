Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class SignIn
    ' Connection string for the UTMConnect.accdb database
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\UTM SEM 5\VBNET\UTMCONNECT\CODING\UTMConnect(Aina)1.accdb"

    Private Sub HomePageButton_Click(sender As Object, e As EventArgs) Handles HomePageButton.Click
        Me.Hide()
        WelcomePage.Show()
    End Sub

    Private Sub JoinUsLabel_Click(sender As Object, e As EventArgs) Handles JoinUsLabel.Click
        Me.Hide()
        SignUp.Show()
    End Sub

    Private Sub SignInLabel_Click(sender As Object, e As EventArgs) Handles SignInLabel.Click
        Me.Show()
    End Sub

    Private Sub RegisterLabel2_Click(sender As Object, e As EventArgs) Handles RegisterLabel2.Click
        Me.Hide()
        SignUp.Show()
    End Sub

    Private Sub SignIn_Click(sender As Object, e As EventArgs) Handles SignInButton.Click
        ' Get Username and Password inputs
        Dim username As String = UsernameTextBox.Text
        Dim password As String = passwordTextBox.Text

        ' Basic Validation
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Authenticate user using the database
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                ' Query to check username and password with brackets around reserved field names
                Dim query As String = "SELECT RoleID FROM Users WHERE [Username] = @Username AND [Password] = @Password"
                Dim command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@Password", password)

                ' Execute the query and get the role if a match is found
                Dim role As Object = command.ExecuteScalar()

                If role IsNot Nothing Then
                    ' User is authenticated; navigate based on the role
                    If role.ToString().StartsWith("C") Then
                        Me.Hide()
                        ServicesPage_Customer_.Show()
                    ElseIf role.ToString().StartsWith("S") Then
                        Me.Hide()
                        Homepage_Seller_.Show()
                    ElseIf role.ToString().StartsWith("A") Then
                        Me.Hide()
                        Homepage_Admin_.Show()
                    Else
                        MessageBox.Show("Unknown role. Please contact support.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    ' If no match is found, show an error message
                    MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred during sign-in: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
