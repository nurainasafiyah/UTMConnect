Imports System.Data.OleDb

Public Class Homepage_Seller_
    ' Define the connection string
    Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\UTM SEM 5\VBNET\UTMCONNECT\CODING\UTMConnect(Aina)1.accdb;"
    Private connection As New OleDbConnection(connectionString)
    Private currentSellerID As Integer
    Private currentSellerUsername As String

    ' Login method to set currentSellerID and currentSellerUsername based on the logged-in user
    Public Sub Login(username As String, password As String)
        MessageBox.Show("Login method called.")
        Dim query As String = "SELECT SellerID, SellerUsername FROM Seller WHERE SellerUsername = ? AND Password = ?"
        Dim command As New OleDbCommand(query, connection)

        command.Parameters.AddWithValue("?", username)
        command.Parameters.AddWithValue("?", password)

        Try
            connection.Open()
            Dim reader As OleDbDataReader = command.ExecuteReader()
            If reader.Read() Then
                currentSellerID = reader("SellerID")
                currentSellerUsername = reader("SellerUsername")
                SellerNameLabel.Text = currentSellerUsername ' Display the seller's name on the UI
                MessageBox.Show("Login successful! Seller ID: " & currentSellerID)
                LoadData() ' Load services and orders after login
            Else
                MessageBox.Show("Invalid username or password.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error during login: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub



    ' Load all data for the seller after login
    Private Sub LoadData()
        LoadServices()
        LoadCustomerOrders()
    End Sub

    ' Method to generate the next ServiceID
    Private Function GenerateNextServiceID() As String
        Dim query As String = "SELECT TOP 1 ServiceID FROM Services WHERE SellerID = ? ORDER BY ServiceID DESC"
        Dim command As New OleDbCommand(query, connection)
        command.Parameters.AddWithValue("?", currentSellerID)
        Dim lastServiceID As String = ""

        Try
            connection.Open()
            Dim reader As OleDbDataReader = command.ExecuteReader()
            If reader.Read() Then
                lastServiceID = reader("ServiceID").ToString()
            End If
        Catch ex As Exception
            MessageBox.Show("Error generating ServiceID: " & ex.Message)
        Finally
            connection.Close()
        End Try

        If Not String.IsNullOrEmpty(lastServiceID) Then
            Dim numPart As Integer = Integer.Parse(lastServiceID.Substring(4))
            numPart += 1
            Return "SERV" & numPart.ToString("D2")
        Else
            Return "SERV01"
        End If
    End Function

    ' Load Services into DataGridView
    Private Sub LoadServices()
        Dim query As String = "SELECT * FROM Services WHERE SellerID = ?"
        Dim adapter As New OleDbDataAdapter(query, connection)
        adapter.SelectCommand.Parameters.AddWithValue("?", currentSellerID)
        Dim servicesTable As New DataTable()

        Try
            connection.Open()
            adapter.Fill(servicesTable)
            ServiceDataGridView.AutoGenerateColumns = True
            ServiceDataGridView.DataSource = servicesTable
        Catch ex As Exception
            MessageBox.Show("Error loading services: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Load Customer Orders into DataGridView
    Private Sub LoadCustomerOrders()
        Dim query As String = "SELECT * FROM Orders WHERE SellerID = ?"
        Dim adapter As New OleDbDataAdapter(query, connection)
        adapter.SelectCommand.Parameters.AddWithValue("?", currentSellerID)
        Dim ordersTable As New DataTable()

        Try
            connection.Open()
            adapter.Fill(ordersTable)
            CustomerOrderDataGridView.AutoGenerateColumns = True
            CustomerOrderDataGridView.DataSource = ordersTable
        Catch ex As Exception
            MessageBox.Show("Error loading customer orders: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Add a new service
    Private Sub AddServiceButton_Click(sender As Object, e As EventArgs) Handles AddServiceButton.Click
        Dim newServiceID As String = GenerateNextServiceID()
        Dim query As String = "INSERT INTO Services (ServiceID, ServiceName, ServiceDescription, ServicePrice, SellerID) VALUES (?, ?, ?, ?, ?)"
        Dim command As New OleDbCommand(query, connection)

        command.Parameters.AddWithValue("?", newServiceID)
        command.Parameters.AddWithValue("?", ServiceNameTextBox.Text)
        command.Parameters.AddWithValue("?", ServiceDescriptionTextBox.Text)
        command.Parameters.AddWithValue("?", ServicePriceTextBox.Text)
        command.Parameters.AddWithValue("?", currentSellerID)

        Try
            connection.Open()
            command.ExecuteNonQuery()
            MessageBox.Show("Service added successfully.")
            LoadServices()
        Catch ex As Exception
            MessageBox.Show("Error adding service: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Update selected service
    Private Sub UpdateServiceButton_Click(sender As Object, e As EventArgs) Handles UpdateServiceButton.Click
        Dim query As String = "UPDATE Services SET ServiceName = ?, ServiceDescription = ?, ServicePrice = ? WHERE ServiceID = ? AND SellerID = ?"
        Dim command As New OleDbCommand(query, connection)

        command.Parameters.AddWithValue("?", ServiceNameTextBox.Text)
        command.Parameters.AddWithValue("?", ServiceDescriptionTextBox.Text)
        command.Parameters.AddWithValue("?", ServicePriceTextBox.Text)
        command.Parameters.AddWithValue("?", ServiceIDTextBox.Text)
        command.Parameters.AddWithValue("?", currentSellerID)

        Try
            connection.Open()
            command.ExecuteNonQuery()
            MessageBox.Show("Service updated successfully.")
            LoadServices()
        Catch ex As Exception
            MessageBox.Show("Error updating service: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Delete selected service
    Private Sub DeleteServiceButton_Click(sender As Object, e As EventArgs) Handles DeleteServiceButton.Click
        Dim query As String = "DELETE FROM Services WHERE ServiceID = ? AND SellerID = ?"
        Dim command As New OleDbCommand(query, connection)

        command.Parameters.AddWithValue("?", ServiceIDTextBox.Text)
        command.Parameters.AddWithValue("?", currentSellerID)

        Try
            connection.Open()
            command.ExecuteNonQuery()
            MessageBox.Show("Service deleted successfully.")
            LoadServices()
        Catch ex As Exception
            MessageBox.Show("Error deleting service: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Add a new order
    Private Sub AddOrderButton_Click(sender As Object, e As EventArgs) Handles AddOrderButton.Click
        Dim query As String = "INSERT INTO Orders (OrderID, CustomerID, ServiceID, OrderStatus, OrderDate, SellerID) VALUES (?, ?, ?, ?, ?, ?)"
        Dim command As New OleDbCommand(query, connection)

        command.Parameters.AddWithValue("?", OrderIDTextBox2.Text)
        command.Parameters.AddWithValue("?", CustomerIDTextBox2.Text)
        command.Parameters.AddWithValue("?", SeviceIDTextBox2.Text)
        command.Parameters.AddWithValue("?", OrderStatusTextBox.Text)
        command.Parameters.AddWithValue("?", OrderDateTextBox.Text)
        command.Parameters.AddWithValue("?", currentSellerID)

        Try
            connection.Open()
            command.ExecuteNonQuery()
            MessageBox.Show("Order added successfully.")
            LoadCustomerOrders()
        Catch ex As Exception
            MessageBox.Show("Error adding order: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Update selected order
    Private Sub UpdateOrderButton_Click(sender As Object, e As EventArgs) Handles UpdateOrderButton.Click
        Dim query As String = "UPDATE Orders SET OrderStatus = ? WHERE OrderID = ? AND SellerID = ?"
        Dim command As New OleDbCommand(query, connection)

        command.Parameters.AddWithValue("?", OrderStatusTextBox.Text)
        command.Parameters.AddWithValue("?", OrderIDTextBox2.Text)
        command.Parameters.AddWithValue("?", currentSellerID)

        Try
            connection.Open()
            command.ExecuteNonQuery()
            MessageBox.Show("Order updated successfully.")
            LoadCustomerOrders()
        Catch ex As Exception
            MessageBox.Show("Error updating order: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Delete selected order
    Private Sub DeleteOrderButton_Click(sender As Object, e As EventArgs) Handles DeleteOrderButton.Click
        Dim query As String = "DELETE FROM Orders WHERE OrderID = ? AND SellerID = ?"
        Dim command As New OleDbCommand(query, connection)

        command.Parameters.AddWithValue("?", OrderIDTextBox2.Text)
        command.Parameters.AddWithValue("?", currentSellerID)

        Try
            connection.Open()
            command.ExecuteNonQuery()
            MessageBox.Show("Order deleted successfully.")
            LoadCustomerOrders()
        Catch ex As Exception
            MessageBox.Show("Error deleting order: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
End Class
