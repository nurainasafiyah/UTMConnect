Imports System.Data.OleDb

Public Class ManageCustomer_Admin_

    Private Const connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\UTM SEM 5\VBNET\UTMCONNECT\CODING\UTMConnect(Aina)1.accdb;"
    Private currentIndex As Integer = 0 ' To track the current row for Next/Previous navigation

    ' Load data on form load
    Private Sub ManageCustomer_Admin__Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomerData()
    End Sub

    ' Load customer data into the DataGridView
    Private Sub LoadCustomerData()
        Try
            Using connection As New OleDbConnection(connectionString)
                Dim command As New OleDbCommand("SELECT * FROM Customers ORDER BY CustID", connection)
                Dim adapter As New OleDbDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                CustomerDataGridView.DataSource = table
                If table.Rows.Count > 0 Then
                    PopulateFields(0) ' Initialize fields with the first row's data
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading customer data: " & ex.Message)
        End Try
    End Sub

    ' Generate next available CustomerID and RoleID
    Private Function GetNextCustomerID() As String
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Dim command As New OleDbCommand("SELECT MAX(CustID) FROM Customers", connection)
                Dim result As Object = command.ExecuteScalar()
                If result IsNot DBNull.Value Then
                    Dim currentMaxID As Integer = Integer.Parse(result.ToString().Substring(1))
                    Return "C" & (currentMaxID + 1).ToString("D2") ' Format with leading zeros, e.g., C01, C02
                Else
                    Return "C01" ' Start with C01 if no records exist
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating CustomerID: " & ex.Message)
            Return "C01"
        End Try
    End Function

    ' Add new customer
    Private Sub AddCustomerButton_Click(sender As Object, e As EventArgs) Handles AddCustomerButton.Click
        Dim newCustID As String = GetNextCustomerID()
        CustIDTextBox.Text = newCustID
        RoleIDTextBox.Text = newCustID ' Set RoleID to be the same as CustID
        Dim roleName As String = "Customer" ' Set RoleName as "Customer"
        Dim password As String = UsernameTextBox.Text & "123" ' Generate password by appending "123" to the username

        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Dim query As String = "INSERT INTO Customers (CustID, Username, [Password], RoleID, Email, RoleName, FullName, phoneNumber) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("?", CustIDTextBox.Text)
                    command.Parameters.AddWithValue("?", UsernameTextBox.Text)
                    command.Parameters.AddWithValue("?", password) ' Generated password
                    command.Parameters.AddWithValue("?", RoleIDTextBox.Text)
                    command.Parameters.AddWithValue("?", EmailTextBox.Text)
                    command.Parameters.AddWithValue("?", roleName) ' RoleName is set to "Customer"
                    command.Parameters.AddWithValue("?", CustFullNameTextBox.Text)
                    command.Parameters.AddWithValue("?", phoneNumberTextBox.Text)
                    command.ExecuteNonQuery()
                End Using
            End Using
            LoadCustomerData() ' Refresh data
        Catch ex As Exception
            MessageBox.Show("Error adding customer: " & ex.Message)
        End Try
    End Sub

    ' Update existing customer
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Dim query As String = "UPDATE Customers SET FullName = ?, RoleID = ?, Username = ?, PhoneNumber = ?, Email = ? WHERE CustID = ?"
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("?", CustFullNameTextBox.Text)
                    command.Parameters.AddWithValue("?", RoleIDTextBox.Text)
                    command.Parameters.AddWithValue("?", UsernameTextBox.Text)
                    command.Parameters.AddWithValue("?", phoneNumberTextBox.Text)
                    command.Parameters.AddWithValue("?", EmailTextBox.Text)
                    command.Parameters.AddWithValue("?", CustIDTextBox.Text)
                    command.ExecuteNonQuery()
                End Using
            End Using
            LoadCustomerData() ' Refresh data
        Catch ex As Exception
            MessageBox.Show("Error updating customer: " & ex.Message)
        End Try
    End Sub

    ' Delete selected customer
    Private Sub DeleteCustomerButton_Click(sender As Object, e As EventArgs) Handles DeleteCustomerButton.Click
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Dim query As String = "DELETE FROM Customers WHERE CustID = ?"
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("?", CustIDTextBox.Text)
                    command.ExecuteNonQuery()
                End Using
            End Using
            LoadCustomerData() ' Refresh data
        Catch ex As Exception
            MessageBox.Show("Error deleting customer: " & ex.Message)
        End Try
    End Sub

    ' Populate fields based on the current row in DataGridView
    Private Sub PopulateFields(rowIndex As Integer)
        If rowIndex >= 0 And rowIndex < CustomerDataGridView.Rows.Count Then
            Dim row As DataGridViewRow = CustomerDataGridView.Rows(rowIndex)
            CustIDTextBox.Text = row.Cells("CustID").Value.ToString()
            CustFullNameTextBox.Text = row.Cells("FullName").Value.ToString()
            RoleIDTextBox.Text = row.Cells("RoleID").Value.ToString()
            UsernameTextBox.Text = row.Cells("Username").Value.ToString()
            phoneNumberTextBox.Text = row.Cells("PhoneNumber").Value.ToString()
            EmailTextBox.Text = row.Cells("Email").Value.ToString()
            currentIndex = rowIndex ' Update the current index
        End If
    End Sub

    ' Next button - navigate to the next row
    Private Sub NextCustomerButton_Click(sender As Object, e As EventArgs) Handles NextCustomerButton.Click
        If currentIndex < CustomerDataGridView.Rows.Count - 1 Then
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
    Private Sub CustomerDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerDataGridView.CellClick
        If e.RowIndex >= 0 Then
            PopulateFields(e.RowIndex)
        End If
    End Sub

End Class
