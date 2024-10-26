Public Class BookingPage
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

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        MessageBox.Show("Your booking for " & ServiceName & " has been confirmed!", "Booking Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class