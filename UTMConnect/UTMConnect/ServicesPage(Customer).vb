Public Class ServicesPage_Customer_
    Private Sub ServicesPage_Customer__Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddServiceCard("Service 1", "Description of Service 1", Nothing) ' Replace 'Nothing' with an image if available
        AddServiceCard("Service 2", "Description of Service 2", Nothing)
    End Sub

    Private Sub ServiceCard_Click(sender As Object, e As EventArgs)
        Dim serviceCard As ServiceCard = CType(sender, ServiceCard) ' Cast sender to ServiceCard
        Dim bookingPage As New OrderPage()

        ' Pass data to booking page
        bookingPage.ServiceName = serviceCard.ServiceName
        bookingPage.ServiceDescription = serviceCard.ServiceDescription
        bookingPage.ServiceImage = serviceCard.ServiceImage

        bookingPage.Show()
    End Sub


    Private Sub AddServiceCard(title As String, description As String, image As Image)
        Dim serviceCard As New ServiceCard()
        serviceCard.ServiceName = title
        serviceCard.ServiceDescription = description
        serviceCard.ServiceImage = image

        ' Add click event handler for booking page navigation
        AddHandler serviceCard.ServiceCardClick, AddressOf ServiceCard_Click

        FlowLayoutPanel.Controls.Add(serviceCard)
    End Sub
End Class