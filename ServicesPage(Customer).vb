Imports System.Data.OleDb
Imports System.Drawing.Imaging
Imports System.Linq

Public Class ServicesPage_Customer_
    ' Update the database path to the location of your uploaded Access file
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\UTM SEM 5\VBNET\UTMCONNECT\CODING\UTMConnect(Aina)1.accdb"

    ' On form load, call the method to load and display services
    Private Sub ServicesPage_Customer__Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load dynamic service cards from the database
        LoadServiceCardsFromDatabase()
    End Sub

    ' Load services from database and create ServiceCard controls dynamically
    Private Sub LoadServiceCardsFromDatabase()
        Using connection As New OleDbConnection(connectionString)
            Dim query As String = "SELECT ServiceName, Username, ServiceDescription, ServicePicture, ServicePrice FROM Services"
            Dim command As New OleDbCommand(query, connection)

            Try
                connection.Open()
                Dim reader As OleDbDataReader = command.ExecuteReader()
                While reader.Read()
                    Dim serviceName As String = reader("ServiceName").ToString()
                    Dim sellerName As String = reader("Username").ToString()
                    Dim serviceDescription As String = reader("ServiceDescription").ToString()
                    Dim servicePrice As Decimal = Convert.ToDecimal(reader("ServicePrice"))
                    Dim servicePicture As Byte() = If(IsDBNull(reader("ServicePicture")), Nothing, DirectCast(reader("ServicePicture"), Byte()))
                    Dim image As Image = Nothing

                    ' Convert image bytes to Image, if available
                    If servicePicture IsNot Nothing AndAlso servicePicture.Length > 0 Then
                        Try
                            Dim cleanImageData As Byte() = RemoveOLEHeader(servicePicture)
                            Using ms As New IO.MemoryStream(cleanImageData)
                                image = Image.FromStream(ms)
                            End Using
                        Catch ex As Exception
                            MessageBox.Show("Error converting image: " & ex.Message)
                        End Try
                    End If

                    ' Add the loaded service as a card
                    AddServiceCard(serviceName, sellerName, serviceDescription, image, servicePrice)
                End While
            Catch ex As Exception
                MessageBox.Show("Error loading services: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Remove OLE header from image data
    Private Function RemoveOLEHeader(oleData As Byte()) As Byte()
        Dim jpegHeader As Byte() = {&HFF, &HD8}
        Dim pngHeader As Byte() = {&H89, &H50, &H4E, &H47}
        Dim headers As List(Of Byte()) = New List(Of Byte()) From {jpegHeader, pngHeader}

        For Each header As Byte() In headers
            Dim headerIndex As Integer = FindHeaderIndex(oleData, header)
            If headerIndex >= 0 Then
                Return oleData.Skip(headerIndex).ToArray()
            End If
        Next
        Return oleData
    End Function

    Private Function FindHeaderIndex(data As Byte(), header As Byte()) As Integer
        If data Is Nothing OrElse header Is Nothing OrElse header.Length = 0 OrElse data.Length = 0 Then
            Return -1
        End If

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

        Return -1
    End Function

    Private Function GetSellerContactNumber(username As String) As String
        Dim phoneNumber As String = ""

        ' Query the Sellers table for the contact number based on username
        Using connection As New OleDbConnection(connectionString)
            Dim query As String = "SELECT phoneNumber FROM Sellers WHERE Username = @Username"
            Dim command As New OleDbCommand(query, connection)
            command.Parameters.AddWithValue("@Username", username)

            Try
                connection.Open()
                Dim result As Object = command.ExecuteScalar()
                If result IsNot Nothing Then
                    phoneNumber = result.ToString()
                End If
            Catch ex As Exception
                MessageBox.Show("Error retrieving seller contact number: " & ex.Message)
            End Try
        End Using

        Return phoneNumber
    End Function

    ' Click event to handle selection of a service card for further actions
    Private Sub ServiceCard_Click(sender As Object, e As EventArgs)
        Dim serviceCard As ServiceCard = CType(sender, ServiceCard)
        Dim orderPage As New OrderPage()

        ' Retrieve and set seller contact number
        Dim sellerContactNumber As String = GetSellerContactNumber(serviceCard.SellerUsername)

        ' Use the properties in OrderPage to set values and update UI
        orderPage.ServiceNameText = serviceCard.ServiceName
        orderPage.ServiceDescriptionText = serviceCard.ServiceDescription
        orderPage.ServiceImage = serviceCard.ServiceImage
        orderPage.SellerNameText = serviceCard.SellerUsername
        orderPage.ServicePriceValue = serviceCard.Price  ' Use ServicePriceValue to ensure total price calculation works
        orderPage.SellerContactNumber = sellerContactNumber

        orderPage.Show()
    End Sub


    ' Method to add each service as a ServiceCard to the FlowLayoutPanel
    Private Sub AddServiceCard(serviceName As String, sellerName As String, serviceDescription As String, image As Image, price As Decimal)
        Dim serviceCard As New ServiceCard()
        serviceCard.ServiceName = serviceName
        serviceCard.SellerUsername = sellerName
        serviceCard.ServiceDescription = serviceDescription
        serviceCard.ServiceImage = image
        serviceCard.Price = price

        ' Add click event handler for booking page navigation
        AddHandler serviceCard.Click, AddressOf ServiceCard_Click

        ' Add the service card to the FlowLayoutPanel
        ServiceList.Controls.Add(serviceCard)
    End Sub

End Class
