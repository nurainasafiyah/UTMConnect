Public Class ServiceCard
    Inherits UserControl

    ' Fields for service details
    Private ServiceNameLabelField As New Label()
    Private ServiceDescriptionLabelField As New Label()
    Private ServicePriceLabelField As New Label()
    Private ServicePictureBoxField As New PictureBox()

    ' Event for handling click actions on the service card
    Public Event ServiceCardClick(sender As Object, e As EventArgs)

    ' Constructor to initialize the UserControl
    Public Sub New()
        InitializeComponent()
        SetupLayout()
    End Sub

    ' Properties for setting or retrieving service data
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
            Dim priceText As String = ServicePriceLabelField.Text.Replace("Starting at RM", "").Trim()
            Dim result As Decimal
            If Decimal.TryParse(priceText, result) Then
                Return result
            End If
            Return 0
        End Get
        Set(value As Decimal)
            ServicePriceLabelField.Text = "Starting at RM " & value.ToString("F2")
        End Set
    End Property

    Public Property ServiceImage As Image
        Get
            Return ServicePictureBoxField.Image
        End Get
        Set(value As Image)
            If ServicePictureBoxField.Image IsNot Nothing Then
                ServicePictureBoxField.Image.Dispose()
            End If
            ServicePictureBoxField.Image = value
        End Set
    End Property

    ' Click event to trigger the ServiceCardClick event
    Protected Overrides Sub OnClick(e As EventArgs)
        MyBase.OnClick(e)
        RaiseEvent ServiceCardClick(Me, e)
    End Sub

    ' Setup layout and appearance of the ServiceCard controls
    Private Sub SetupLayout()
        With ServicePictureBoxField
            .SizeMode = PictureBoxSizeMode.StretchImage
            .Dock = DockStyle.Top
            .Height = 100
        End With

        With ServiceNameLabelField
            .Font = New Font("Arial Rounded MT Bold", 12.0F, FontStyle.Regular)
            .ForeColor = Color.Black
            .Dock = DockStyle.Top
        End With

        With ServiceDescriptionLabelField
            .Font = New Font("Arial Rounded MT Bold", 9.0F, FontStyle.Regular)
            .ForeColor = Color.Gray
            .Dock = DockStyle.Top
        End With

        With ServicePriceLabelField
            .Font = New Font("Arial Rounded MT Bold", 10.0F, FontStyle.Regular)
            .ForeColor = Color.Green
            .Dock = DockStyle.Bottom
        End With

        ' Adding the controls to the UserControl
        Controls.Add(ServicePriceLabelField)
        Controls.Add(ServiceDescriptionLabelField)
        Controls.Add(ServiceNameLabelField)
        Controls.Add(ServicePictureBoxField)

        Me.BorderStyle = BorderStyle.FixedSingle
        Me.Padding = New Padding(10)
        Me.Size = New Size(200, 200)
    End Sub

End Class
