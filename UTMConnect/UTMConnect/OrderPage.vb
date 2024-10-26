Public Class OrderPage
    Private ServiceNameLabelField As New Label()
    Private ServiceDescriptionLabelField As New Label()
    Private ServicePriceLabelField As New Label()
    Private ServicePictureBoxField As New PictureBox()
    Public Property ServiceName As String
        Get
            Return ServiceNameLabelField.Text
        End Get
        Set(value As String)
            ServiceNameLabelField.Text = value
        End Set
    End Property

    Public Property ServiceDescription As String
        Get
            Return ServiceDescriptionLabelField.Text
        End Get
        Set(value As String)
            ServiceDescriptionLabelField.Text = value
        End Set
    End Property

    Public Property Price As Decimal
        Get
            Return Decimal.Parse(ServicePriceLabelField.Text.Replace("Starting at RM", ""))
        End Get
        Set(value As Decimal)
            ServicePriceLabelField.Text = "Starting at RM" & value.ToString("F2")
        End Set
    End Property

    Public Property ServiceImage As Image
        Get
            Return ServicePictureBoxField.Image
        End Get
        Set(value As Image)
            ServicePictureBoxField.Image = value
        End Set
    End Property

    Private Sub ServiceLabel_Click(sender As Object, e As EventArgs) Handles ServiceLabel.Click
        ServicesPage_Customer_.Show()
    End Sub

    Private Sub PurchaseButton_Click(sender As Object, e As EventArgs) Handles PurchaseButton.Click
        ' Parse the ServicePrice and ServiceQuantity to calculate the total
        Dim price As Decimal = Decimal.Parse(ServicePrice.Text)
        Dim quantity As Integer = Integer.Parse(ServiceQuantity.Text)
        Dim total As Decimal = price * quantity

        ' Display the total price on ServiceTotalPrice label
        ServiceTotalPrice.Text = total.ToString("0.00")

        ' Show a confirmation dialog with the total price
        Dim confirmResult As DialogResult = MessageBox.Show("Total: RM" & ServiceTotalPrice.Text & vbCrLf & "Confirm purchase?",
                                                            "Confirm Purchase", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmResult = DialogResult.Yes Then
            ' If user confirms, show payment success message with options to print or cancel
            Dim printResult As DialogResult = MessageBox.Show("Payment successful!" & vbCrLf & "Would you like to print a receipt?",
                                                              "Payment Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

            If printResult = DialogResult.Yes Then
                ' Code to print the receipt (placeholder comment)
                MessageBox.Show("Receipt printing...", "Print Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' If user chooses not to print, just return to the page
                MessageBox.Show("Returning to order page.", "Cancel Print", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            ' If user cancels the purchase, do nothing or show a cancellation message
            MessageBox.Show("Purchase cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class