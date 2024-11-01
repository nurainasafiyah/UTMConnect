Imports System.Data.OleDb
Imports System.IO

Public Class ManageOrder_Admin_

    Private Const connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\UTM SEM 5\VBNET\UTMCONNECT\CODING\UTMConnect(Aina)1.accdb;"

    ' Method to get the next incremental OrderID
    Private Function GetNextOrderID() As String
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Dim command As New OleDbCommand("SELECT MAX(OrderID) FROM Orders", connection)
                Dim result As Object = command.ExecuteScalar()
                If result IsNot DBNull.Value AndAlso Not String.IsNullOrEmpty(result.ToString()) Then
                    Dim currentMaxID As Integer = Integer.Parse(result.ToString().Substring(3)) ' Extract number after "ORD"
                    Return "ORD" & (currentMaxID + 1).ToString("D2")
                Else
                    Return "ORD01"
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating OrderID: " & ex.Message)
            Return "ORD01"
        End Try
    End Function

    ' Method to get the next incremental SellerID
    Private Function GetNextSellerID() As String
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Dim command As New OleDbCommand("SELECT MAX(SellerID) FROM Orders", connection)
                Dim result As Object = command.ExecuteScalar()
                If result IsNot DBNull.Value AndAlso Not String.IsNullOrEmpty(result.ToString()) Then
                    Dim currentMaxID As Integer = Integer.Parse(result.ToString().Substring(1))
                    Return "S" & (currentMaxID + 1).ToString("D2")
                Else
                    Return "S01"
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating SellerID: " & ex.Message)
            Return "S01"
        End Try
    End Function

    ' Method to get the next incremental CustID
    Private Function GetNextCustID() As String
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Dim command As New OleDbCommand("SELECT MAX(CustID) FROM Orders", connection)
                Dim result As Object = command.ExecuteScalar()
                If result IsNot DBNull.Value AndAlso Not String.IsNullOrEmpty(result.ToString()) Then
                    Dim currentMaxID As Integer = Integer.Parse(result.ToString().Substring(1))
                    Return "C" & (currentMaxID + 1).ToString("D2")
                Else
                    Return "C01"
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating CustID: " & ex.Message)
            Return "C01"
        End Try
    End Function

    ' Method to get the next incremental ServiceID
    Private Function GetNextServiceID() As String
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Dim command As New OleDbCommand("SELECT MAX(ServiceID) FROM Orders", connection)
                Dim result As Object = command.ExecuteScalar()
                If result IsNot DBNull.Value AndAlso Not String.IsNullOrEmpty(result.ToString()) Then
                    Dim currentMaxID As Integer = Integer.Parse(result.ToString().Substring(4))
                    Return "SERV" & (currentMaxID + 1).ToString("D2")
                Else
                    Return "SERV01"
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating ServiceID: " & ex.Message)
            Return "SERV01"
        End Try
    End Function

    ' Adding an order
    Private Sub AddOrderButton_Click(sender As Object, e As EventArgs) Handles AddOrderButton.Click
        OrderIDTextBox.Text = GetNextOrderID()
        Dim custID As String = CustIDTextBox.Text
        Dim serviceID As String = ServiceIDTextBox.Text
        Dim sellerID As String = SellerIDTextBox.Text
        Dim orderStatus As String = OrderStatusTextBox.Text
        Dim orderDate As DateTime = OrderDateTimePicker.Value
        Dim totalPrice As Decimal
        Dim quantity As Integer

        ' Parse Quantity and TotalPrice
        If Not Integer.TryParse(QuantityTextBox.Text, quantity) Then
            MessageBox.Show("Please enter a valid integer for Quantity.")
            Exit Sub
        End If

        If Not Decimal.TryParse(TotalPriceTextBox.Text, totalPrice) Then
            MessageBox.Show("Please enter a valid decimal number for Total Price.")
            Exit Sub
        End If

        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Dim query As String = "INSERT INTO Orders (OrderID, CustID, ServiceID, SellerID, TotalPrice, OrderStatus, Quantity, OrderDate) " &
                                      "VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("?", OrderIDTextBox.Text)
                    command.Parameters.AddWithValue("?", custID)
                    command.Parameters.AddWithValue("?", serviceID)
                    command.Parameters.AddWithValue("?", sellerID)
                    command.Parameters.AddWithValue("?", totalPrice)
                    command.Parameters.AddWithValue("?", orderStatus)
                    command.Parameters.AddWithValue("?", quantity)
                    command.Parameters.AddWithValue("?", orderDate)

                    ' Debugging: Print values before executing
                    Console.WriteLine($"OrderID: {OrderIDTextBox.Text}, CustID: {custID}, ServiceID: {serviceID}, SellerID: {sellerID}")
                    Console.WriteLine($"TotalPrice: {totalPrice}, OrderStatus: {orderStatus}, Quantity: {quantity}, OrderDate: {orderDate}")

                    command.ExecuteNonQuery()
                End Using
            End Using
            LoadOrderData() ' Refresh data
        Catch ex As Exception
            MessageBox.Show("Error adding order: " & ex.Message)
        End Try
    End Sub

    ' Method to load order data into DataGridView
    Private Sub LoadOrderData()
        Try
            Using connection As New OleDbConnection(connectionString)
                Dim command As New OleDbCommand("SELECT * FROM Orders ORDER BY OrderID", connection)
                Dim adapter As New OleDbDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                OrderDataGridView.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading order data: " & ex.Message)
        End Try
    End Sub

    ' Form Load Event
    Private Sub ManageOrder_Admin__Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOrderData()
    End Sub

End Class
