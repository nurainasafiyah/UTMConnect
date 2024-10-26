Public Class ServiceCard
    ' Declare private fields with unique names
    Private ServiceNameLabelField As New Label()
    Private ServiceDescriptionLabelField As New Label()
    Private ServicePriceLabelField As New Label()
    Private ServicePictureBoxField As New PictureBox()

    ' Properties
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

    Public Event ServiceCardClick(sender As Object, e As EventArgs)

End Class
