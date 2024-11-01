Imports System.Data.OleDb

Public Class ManageSeller_Admin_

    Private Const connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\UTM SEM 5\VBNET\UTMCONNECT\CODING\UTMConnect(Aina)1.accdb;"
    Private currentIndex As Integer = 0 ' To track the current row for Next/Previous navigation

    ' Load data on form load
    Private Sub ManageSeller_Admin__Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSellerData()
    End Sub

    ' Load seller data into the DataGridView
    Private Sub LoadSellerData()
        Try
            Using connection As New OleDbConnection(connectionString)
                Dim command As New OleDbCommand("SELECT * FROM Sellers ORDER BY SellerID", connection)
                Dim adapter As New OleDbDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
                If table.Rows.Count > 0 Then
                    PopulateFields(0) ' Initialize fields with the first row's data
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading seller data: " & ex.Message)
        End Try
    End Sub

    ' Generate next available SellerID and ServiceID
    Private Function GetNextSellerID() As String
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Dim command As New OleDbCommand("SELECT MAX(SellerID) FROM Sellers", connection)
                Dim result As Object = command.ExecuteScalar()
                If result IsNot DBNull.Value Then
                    Dim currentMaxID As Integer = Integer.Parse(result.ToString().Substring(1))
                    Return "S" & (currentMaxID + 1).ToString("D2") ' Format with leading zeros, e.g., S01, S02
                Else
                    Return "S01" ' Start with S01 if no records exist
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating SellerID: " & ex.Message)
            Return "S01"
        End Try
    End Function

    Private Function GetNextServiceID() As String
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Dim command As New OleDbCommand("SELECT MAX(ServiceID) FROM Sellers", connection)
                Dim result As Object = command.ExecuteScalar()

                If result IsNot DBNull.Value AndAlso Not String.IsNullOrEmpty(result.ToString()) Then
                    ' Extract the numeric part after "SERV" and increment it
                    Dim currentMaxID As Integer = Integer.Parse(result.ToString().Substring(4))
                    Return "SERV" & (currentMaxID + 1).ToString("D2") ' Format as SERVXX, where XX is incremented
                Else
                    ' If there are no existing records or result is null/empty, start from SERV01
                    Return "SERV01"
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating ServiceID: " & ex.Message)
            Return "SERV01"
        End Try
    End Function

    ' Add new seller
    Private Sub AddSellerButton_Click(sender As Object, e As EventArgs) Handles AddSellerButton.Click
        Dim newSellerID As String = GetNextSellerID()
        SellerIDTextBox.Text = newSellerID
        Dim roleID As String = newSellerID ' Set RoleID to be the same as SellerID
        Dim roleName As String = "Seller" ' Set RoleName as "Seller"
        Dim newServiceID As String = GetNextServiceID() ' Generate ServiceID starting with "SERV"
        ServiceIDTextBox.Text = newServiceID
        Dim password As String = SellerUsernameTextBox.Text & "123" ' Generate password by appending "123" to the username

        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Dim query As String = "INSERT INTO Sellers (SellerID, RoleID, RoleName, Username, [Password], FullName, phoneNumber, Email, ServiceID) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)"
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("?", SellerIDTextBox.Text)
                    command.Parameters.AddWithValue("?", roleID) ' Set RoleID to be the same as SellerID
                    command.Parameters.AddWithValue("?", roleName) ' RoleName is set to "Seller"
                    command.Parameters.AddWithValue("?", SellerUsernameTextBox.Text)
                    command.Parameters.AddWithValue("?", password) ' Generated password
                    command.Parameters.AddWithValue("?", SellerFullNameTextBox.Text)
                    command.Parameters.AddWithValue("?", phoneNumberTextBox.Text)
                    command.Parameters.AddWithValue("?", EmailTextBox.Text)
                    command.Parameters.AddWithValue("?", ServiceIDTextBox.Text)
                    command.ExecuteNonQuery()
                End Using
            End Using
            LoadSellerData() ' Refresh data
        Catch ex As Exception
            MessageBox.Show("Error adding seller: " & ex.Message)
        End Try
    End Sub

    ' Update existing seller
    Private Sub UpdateSellerButton_Click(sender As Object, e As EventArgs) Handles UpdateSellerButton.Click
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Dim query As String = "UPDATE Sellers SET Username = ?, FullName = ?, phoneNumber = ?, Email = ?, ServiceID = ? WHERE SellerID = ?"
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("?", SellerUsernameTextBox.Text)
                    command.Parameters.AddWithValue("?", SellerFullNameTextBox.Text)
                    command.Parameters.AddWithValue("?", phoneNumberTextBox.Text)
                    command.Parameters.AddWithValue("?", EmailTextBox.Text)
                    command.Parameters.AddWithValue("?", ServiceIDTextBox.Text)
                    command.Parameters.AddWithValue("?", SellerIDTextBox.Text)
                    command.ExecuteNonQuery()
                End Using
            End Using
            LoadSellerData() ' Refresh data
        Catch ex As Exception
            MessageBox.Show("Error updating seller: " & ex.Message)
        End Try
    End Sub

    ' Delete selected seller
    Private Sub DeleteSellerButton_Click(sender As Object, e As EventArgs) Handles DeleterSellerButton.Click
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Dim query As String = "DELETE FROM Sellers WHERE SellerID = ?"
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("?", SellerIDTextBox.Text)
                    command.ExecuteNonQuery()
                End Using
            End Using
            LoadSellerData() ' Refresh data
        Catch ex As Exception
            MessageBox.Show("Error deleting seller: " & ex.Message)
        End Try
    End Sub

    ' Populate fields based on the current row in DataGridView
    Private Sub PopulateFields(rowIndex As Integer)
        If rowIndex >= 0 And rowIndex < DataGridView1.Rows.Count Then
            Dim row As DataGridViewRow = DataGridView1.Rows(rowIndex)
            SellerIDTextBox.Text = row.Cells("SellerID").Value.ToString()
            SellerUsernameTextBox.Text = row.Cells("Username").Value.ToString()
            SellerFullNameTextBox.Text = row.Cells("FullName").Value.ToString()
            phoneNumberTextBox.Text = row.Cells("phoneNumber").Value.ToString()
            EmailTextBox.Text = row.Cells("Email").Value.ToString()
            ServiceIDTextBox.Text = row.Cells("ServiceID").Value.ToString()
            currentIndex = rowIndex ' Update the current index
        End If
    End Sub

    ' Next button - navigate to the next row
    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        If currentIndex < DataGridView1.Rows.Count - 1 Then
            currentIndex += 1
            PopulateFields(currentIndex)
        Else
            MessageBox.Show("This is the last record.")
        End If
    End Sub

    ' Previous button - navigate to the previous row
    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            PopulateFields(currentIndex)
        Else
            MessageBox.Show("This is the first record.")
        End If
    End Sub

    ' Event to select data from DataGridView to text boxes on cell click
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            PopulateFields(e.RowIndex)
        End If
    End Sub

End Class
