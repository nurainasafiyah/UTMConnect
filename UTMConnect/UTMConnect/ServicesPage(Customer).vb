Imports System.Data.OleDb
Imports System.Drawing.Imaging
Imports System.Linq

Public Class ServicesPage_Customer_
    ' Update the database path to the location of your uploaded Access file
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\UTM SEM 5\VBNET\UTMCONNECT\CODING\UTMConnect(Aina)1.accdb"

    ' On form load, call the method to load and display services
    Private Sub ServicesPage_Customer__Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadServiceCardsFromDatabase()
    End Sub

    ' Load services from database and create ServiceCard controls dynamically
    Private Sub LoadServiceCardsFromDatabase()
        Using connection As New OleDbConnection(connectionString)
            Dim query As String = "SELECT ServiceName, ServiceDescription, ServicePicture, ServicePrice FROM Services"
            Dim command As New OleDbCommand(query, connection)

            Try
                connection.Open()
                Dim reader As OleDbDataReader = command.ExecuteReader()
                While reader.Read()
                    Dim serviceName As String = reader("ServiceName").ToString()
                    Dim serviceDescription As String = reader("ServiceDescription").ToString()
                    Dim servicePrice As Decimal = Convert.ToDecimal(reader("ServicePrice"))
                    Dim servicePicture As Byte() = If(IsDBNull(reader("ServicePicture")), Nothing, DirectCast(reader("ServicePicture"), Byte()))
                    Dim image As Image = Nothing

                    If servicePicture IsNot Nothing AndAlso servicePicture.Length > 0 Then
                        Try
                            ' Remove OLE header before converting to Image
                            Dim cleanImageData As Byte() = RemoveOLEHeader(servicePicture)
                            Using ms As New IO.MemoryStream(cleanImageData)
                                image = Image.FromStream(ms)
                            End Using
                        Catch ex As Exception
                            MessageBox.Show("Error converting image: " & ex.Message)
                        End Try
                    End If

                    AddServiceCard(serviceName, serviceDescription, image, servicePrice)
                End While
            Catch ex As Exception
                MessageBox.Show("Error loading services: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Remove OLE header from image data
    Private Function RemoveOLEHeader(oleData As Byte()) As Byte()
        ' Define JPEG and PNG headers
        Dim jpegHeader As Byte() = {&HFF, &HD8}
        Dim pngHeader As Byte() = {&H89, &H50, &H4E, &H47}

        ' Find the start of the image data
        Dim headers As List(Of Byte()) = New List(Of Byte()) From {jpegHeader, pngHeader}

        For Each header As Byte() In headers
            Dim headerIndex As Integer = FindHeaderIndex(oleData, header)
            If headerIndex >= 0 Then
                ' Get the data starting from the header
                Dim imageData As Byte() = oleData.Skip(headerIndex).ToArray()

                ' Debugging output
                Console.WriteLine($"Image data length after header removal: {imageData.Length}")

                Return imageData
            End If
        Next

        ' If no header found, return the original data
        Return oleData
    End Function

    Private Function FindHeaderIndex(data As Byte(), header As Byte()) As Integer
        ' Check for null or empty data
        If data Is Nothing OrElse header Is Nothing OrElse header.Length = 0 OrElse data.Length = 0 Then
            Return -1
        End If

        ' Loop through the data to find the header
        For i As Integer = 0 To data.Length - header.Length
            Dim found As Boolean = True
            For j As Integer = 0 To header.Length - 1
                If data(i + j) <> header(j) Then
                    found = False
                    Exit For
                End If
            Next
            If found Then
                Return i
            End If
        Next

        ' Return -1 if the header is not found
        Return -1
    End Function

    ' Helper function to locate the header in byte array
    Private Function IndexOf(data As Byte(), header As Byte()) As Integer
        For i As Integer = 0 To data.Length - header.Length
            Dim found As Boolean = True
            For j As Integer = 0 To header.Length - 1
                If data(i + j) <> header(j) Then
                    found = False
                    Exit For
                End If
            Next
            If found Then Return i
        Next
        Return -1
    End Function

    ' Click event to handle selection of a service card for further actions
    Private Sub ServiceCard_Click(sender As Object, e As EventArgs)
        Dim serviceCard As ServiceCard = CType(sender, ServiceCard)
        Dim bookingPage As New OrderPage()

        ' Transfer details to the OrderPage
        bookingPage.ServiceName = serviceCard.ServiceName
        bookingPage.ServiceDescription = serviceCard.ServiceDescription
        bookingPage.ServiceImage = serviceCard.ServiceImage

        OrderPage.Show()
    End Sub

    ' Method to add each service as a ServiceCard to the FlowLayoutPanel
    Private Sub AddServiceCard(title As String, description As String, image As Image, price As Decimal)
        Dim serviceCard As New ServiceCard()
        serviceCard.ServiceName = title
        serviceCard.ServiceDescription = description
        serviceCard.ServiceImage = image
        serviceCard.Price = price

        ' Add click event handler for booking page navigation
        AddHandler serviceCard.ServiceCardClick, AddressOf ServiceCard_Click

        ' Add the service card to the FlowLayoutPanel
        FlowLayoutPanel.Controls.Add(serviceCard)
    End Sub
End Class
