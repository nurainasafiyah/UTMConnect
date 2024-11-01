Imports System.Data.OleDb

Public Class Homepage_Admin_

    ' Connection string to connect to Access database
    Private Const connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\UTM SEM 5\VBNET\UTMCONNECT\CODING\UTMConnect(Aina)1.accdb;"

    ' Method to load data when the form loads
    Private Sub Homepage_Admin__Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData("Customers", DataGridViewCustomers)
        LoadData("Sellers", DataGridViewSellers)
        LoadData("Orders", DataGridViewOrders)
        LoadData("Services", DataGridViewServices)
    End Sub

    ' Method to load data into a DataGridView
    Private Sub LoadData(tableName As String, dataGridView As DataGridView)
        Try
            Using connection As New OleDbConnection(connectionString)
                Dim command As New OleDbCommand("SELECT * FROM " & tableName, connection)
                Dim adapter As New OleDbDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                dataGridView.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data from " & tableName & ": " & ex.Message)
        End Try
    End Sub

    ' Event handlers for button clicks, e.g., ManageCustomerButton_Click
    Private Sub ManageCustomerButton_Click(sender As Object, e As EventArgs) Handles ManageCustomerButton.Click
        ManageCustomer_Admin_.Show()
    End Sub

    Private Sub ManageSellerButton_Click(sender As Object, e As EventArgs) Handles ManageSellerButton.Click
        ManageSeller_Admin_.Show()
    End Sub

    Private Sub ManageOrdersButton_Click(sender As Object, e As EventArgs) Handles ManageOrdersButton.Click
        ManageOrder_Admin_.Show()
    End Sub

    Private Sub ManageServiceButton_Click(sender As Object, e As EventArgs) Handles ManageServiceButton.Click
        ManageService_Admin_.Show()
    End Sub

End Class
