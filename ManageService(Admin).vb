Imports System.Data.OleDb
Imports System.IO

Public Class ManageService_Admin_

    Private Const connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\UTM SEM 5\VBNET\UTMCONNECT\CODING\UTMConnect(Aina)1.accdb;"
    Private currentIndex As Integer = 0 ' To track the current row for Next/Previous navigation
    Private uploadedImageData As Byte() ' Store uploaded image data

    ' Load data on form load
    Private Sub ManageService_Admin__Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadServiceData()
    End Sub

    ' Load service data into the DataGridView
    Private Sub LoadServiceData()
        Try
            Using connection As New OleDbConnection(connectionString)
                Dim command As New OleDbCommand("SELECT ServiceID, SellerID, ServiceName, ServiceDescription, Username, servicePrice, ServicePicture FROM Services ORDER BY ServiceID", connection)
                Dim adapter As New OleDbDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                ServicesDataGridView.DataSource = table
                If table.Rows.Count > 0 Then
                    PopulateFields(0) ' Initialize fields with the first row's data
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading service data: " & ex.Message)
        End Try
    End Sub

    ' Generate next available SellerID
    Private Function GetNextSellerID() As String
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Dim command As New OleDbCommand("SELECT MAX(SellerID) FROM Services", connection)
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

    ' Generate next available ServiceID
    Private Function GetNextServiceID() As String
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Dim command As New OleDbCommand("SELECT MAX(ServiceID) FROM Services", connection)
                Dim result As Object = command.ExecuteScalar()
                If result IsNot DBNull.Value AndAlso Not String.IsNullOrEmpty(result.ToString()) Then
                    Dim currentMaxID As Integer = Integer.Parse(result.ToString().Substring(4)) ' Extract number after "SERV"
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

    Private Sub UploadImageButton_Click(sender As Object, e As EventArgs) Handles UploadImageButton.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            If ofd.ShowDialog() = DialogResult.OK Then
                Dim filePath As String = ofd.FileName
                uploadedImageData = File.ReadAllBytes(filePath) ' Convert image to byte array

                ' Display the uploaded image in PictureBox
                Using ms As New MemoryStream(uploadedImageData)
                    ServicePictureBox.Image = Image.FromStream(ms)
                End Using
            End If
        End Using
    End Sub

    ' Add new service
    Private Sub AddServiceButton_Click(sender As Object, e As EventArgs) Handles AddServiceButton.Click
        ServiceIDTextBox.Text = GetNextServiceID()
        SellerIDTextBox.Text = GetNextSellerID()
        Dim serviceName As String = ServiceNameTextBox.Text
        Dim serviceDescription As String = DescriptionTextBox.Text
        Dim username As String = UsernameTextBox.Text
        Dim servicePrice As Decimal
        Decimal.TryParse(ServicePriceTextBox.Text, servicePrice)

        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Dim query As String = "INSERT INTO Services (ServiceID, SellerID, ServiceName, ServiceDescription, Username, servicePrice, ServicePicture) VALUES (?, ?, ?, ?, ?, ?, ?)"
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("?", ServiceIDTextBox.Text)
                    command.Parameters.AddWithValue("?", SellerIDTextBox.Text)
                    command.Parameters.AddWithValue("?", serviceName)
                    command.Parameters.AddWithValue("?", serviceDescription)
                    command.Parameters.AddWithValue("?", username)
                    command.Parameters.AddWithValue("?", servicePrice)
                    command.Parameters.AddWithValue("?", If(uploadedImageData, DBNull.Value))
                    command.ExecuteNonQuery()
                End Using
            End Using
            LoadServiceData() ' Refresh data
        Catch ex As Exception
            MessageBox.Show("Error adding service: " & ex.Message)
        End Try
    End Sub

    ' Update existing service
    Private Sub UpdateServiceButton_Click(sender As Object, e As EventArgs) Handles UpdateServiceButton.Click
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Dim query As String = "UPDATE Services SET ServiceName = ?, ServiceDescription = ?, Username = ?, servicePrice = ? WHERE ServiceID = ?"
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("?", ServiceNameTextBox.Text)
                    command.Parameters.AddWithValue("?", DescriptionTextBox.Text)
                    command.Parameters.AddWithValue("?", UsernameTextBox.Text)
                    command.Parameters.AddWithValue("?", Decimal.Parse(ServicePriceTextBox.Text))
                    command.Parameters.AddWithValue("?", ServiceIDTextBox.Text)
                    command.ExecuteNonQuery()
                End Using
            End Using
            LoadServiceData() ' Refresh data
        Catch ex As Exception
            MessageBox.Show("Error updating service: " & ex.Message)
        End Try
    End Sub

    ' Delete selected service
    Private Sub DeleteServiceButton_Click(sender As Object, e As EventArgs) Handles DeleteServiceButton.Click
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Dim query As String = "DELETE FROM Services WHERE ServiceID = ?"
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("?", ServiceIDTextBox.Text)
                    command.ExecuteNonQuery()
                End Using
            End Using
            LoadServiceData() ' Refresh data
        Catch ex As Exception
            MessageBox.Show("Error deleting service: " & ex.Message)
        End Try
    End Sub

    ' Populate fields based on the current row in DataGridView
    Private Sub PopulateFields(rowIndex As Integer)
        If rowIndex >= 0 AndAlso rowIndex < ServicesDataGridView.Rows.Count Then
            Dim row As DataGridViewRow = ServicesDataGridView.Rows(rowIndex)
            ServiceIDTextBox.Text = row.Cells("ServiceID").Value.ToString()
            SellerIDTextBox.Text = row.Cells("SellerID").Value.ToString()
            ServiceNameTextBox.Text = row.Cells("ServiceName").Value.ToString()
            DescriptionTextBox.Text = row.Cells("ServiceDescription").Value.ToString()
            UsernameTextBox.Text = row.Cells("Username").Value.ToString()
            ServicePriceTextBox.Text = row.Cells("servicePrice").Value.ToString()

            ' Load the image into PictureBox, handling any OLE metadata issues
            Try
                ClearPictureBoxImage() ' Clear any existing image in the PictureBox

                If Not IsDBNull(row.Cells("ServicePicture").Value) AndAlso
                   TypeOf row.Cells("ServicePicture").Value Is Byte() Then

                    ' Retrieve the raw image data
                    Dim imageData As Byte() = DirectCast(row.Cells("ServicePicture").Value, Byte())
                    If imageData IsNot Nothing AndAlso imageData.Length > 0 Then
                        ' Strip OLE header if present, using an offset if necessary
                        Dim offset As Integer = GetOleHeaderOffset(imageData)
                        Using ms As New MemoryStream(imageData, offset, imageData.Length - offset)
                            ServicePictureBox.Image = Image.FromStream(ms)
                        End Using
                    Else
                        ServicePictureBox.Image = Nothing ' Clear the PictureBox if no image data
                    End If
                Else
                    ServicePictureBox.Image = Nothing ' No image available
                End If
            Catch ex As Exception
                MessageBox.Show("Error loading service picture: " & ex.Message)
                ServicePictureBox.Image = Nothing ' Clear the PictureBox on error
            End Try

            currentIndex = rowIndex ' Update the current index
        End If
    End Sub

    Private Function GetOleHeaderOffset(imageData As Byte()) As Integer
        ' Typical OLE header length in Access is 78 bytes for images; adjust as needed
        Const OleHeaderLength As Integer = 78
        ' Basic check if data starts with OLE header pattern
        If imageData.Length > OleHeaderLength AndAlso
       imageData(0) = &H15 AndAlso imageData(1) = &HC7 Then
            Return OleHeaderLength
        End If
        Return 0 ' No header detected, start from beginning
    End Function

    ' Next button - navigate to the next row
    Private Sub NextServiceButton_Click(sender As Object, e As EventArgs) Handles NextServiceButton.Click
        If currentIndex < ServicesDataGridView.Rows.Count - 1 Then
            currentIndex += 1
            PopulateFields(currentIndex)
        Else
            MessageBox.Show("This is the last record.")
        End If
    End Sub

    ' Previous button - navigate to the previous row
    Private Sub PreviousServicceButton_Click(sender As Object, e As EventArgs) Handles PreviousServicceButton.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            PopulateFields(currentIndex)
        Else
            MessageBox.Show("This is the first record.")
        End If
    End Sub

    ' Event to format DataGridView cells to display placeholder text for images
    Private Sub ServicesDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles ServicesDataGridView.CellFormatting
        If ServicesDataGridView.Columns(e.ColumnIndex).Name = "ServicePicture" Then
            If e.Value IsNot Nothing AndAlso TypeOf e.Value Is Byte() Then
                e.Value = "Image Available" ' Display placeholder text
            Else
                e.Value = "No Image" ' Display "No Image" if no binary data is present
            End If
            e.FormattingApplied = True
        End If
    End Sub

    Private Sub ClearPictureBoxImage()
        If ServicePictureBox.Image IsNot Nothing Then
            ServicePictureBox.Image.Dispose()
            ServicePictureBox.Image = Nothing
        End If
    End Sub

    ' DataError handler to suppress specific errors
    Private Sub ServicesDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles ServicesDataGridView.DataError
        ' Suppress only certain errors related to image display
        e.ThrowException = False
    End Sub


End Class
