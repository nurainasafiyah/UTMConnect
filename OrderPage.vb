Public Class OrderPage

    Private _serviceNameText As String
    Public Property ServiceNameText As String
        Get
            Return _serviceNameText
        End Get
        Set(value As String)
            _serviceNameText = value
            ServiceName.Text = value
        End Set
    End Property

    Private _serviceDescriptionText As String
    Public Property ServiceDescriptionText As String
        Get
            Return _serviceDescriptionText
        End Get
        Set(value As String)
            _serviceDescriptionText = value
            ServiceDescription.Text = value
        End Set
    End Property

    Private _serviceImage As Image
    Public Property ServiceImage As Image
        Get
            Return _serviceImage
        End Get
        Set(value As Image)
            _serviceImage = value
            ServicePictureBox.Image = value
        End Set
    End Property

    Private _sellerNameText As String
    Public Property SellerNameText As String
        Get
            Return _sellerNameText
        End Get
        Set(value As String)
            _sellerNameText = value
            SellerName.Text = value
        End Set
    End Property

    Private _servicePriceValue As Decimal
    Public Property ServicePriceValue As Decimal
        Get
            Return _servicePriceValue
        End Get
        Set(value As Decimal)
            _servicePriceValue = value
            ServicePrice.Text = "RM " & value.ToString("F2")
        End Set
    End Property

    Private _sellerContactNumber As String
    Public Property SellerContactNumber As String
        Get
            Return _sellerContactNumber
        End Get
        Set(value As String)
            _sellerContactNumber = value
            SellerContNum.Text = value
        End Set
    End Property

    ' Event handler for totalButton click
    Private Sub ServiceTotalPriceButton_Click(sender As Object, e As EventArgs) Handles ServiceTotalPriceButton.Click
        ' Calculate total price directly and update the label
        Dim totalPrice As Decimal = ServicePriceValue * QuantityNumericUpDown.Value
        MessageBox.Show("Price: " & totalPrice & ", Quantity: " & QuantityNumericUpDown.Value)

    End Sub

    ' Event handler for Purchase Button
    Private Sub PurchaseButton_Click(sender As Object, e As EventArgs) Handles PurchaseButton.Click
        MessageBox.Show("Purchase successful for " & If(ServiceNameText, "Service") & " with quantity: " & QuantityNumericUpDown.Value)
    End Sub

End Class
