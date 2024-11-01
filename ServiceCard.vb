Public Class ServiceCard
    Inherits UserControl

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
            Return ServiceNameLabel.Text
        End Get
        Set(value As String)
            ServiceNameLabel.Text = value
        End Set
    End Property

    Public Property SellerUsername As String
        Get
            Return UsernameLabel.Text
        End Get
        Set(value As String)
            UsernameLabel.Text = value
        End Set
    End Property

    Public Property ServiceDescription As String
        Get
            Return ServiceDescriptionLabel.Text
        End Get
        Set(value As String)
            ServiceDescriptionLabel.Text = value
        End Set
    End Property

    Public Property Price As Decimal
        Get
            Dim priceText As String = ServicePriceLabel.Text.Replace("Starting at RM", "").Trim()
            Dim result As Decimal
            If Decimal.TryParse(priceText, result) Then
                Return result
            End If
            Return 0
        End Get
        Set(value As Decimal)
            ServicePriceLabel.Text = "Starting at RM " & value.ToString("F2")
        End Set
    End Property

    Public Property ServiceImage As Image
        Get
            Return ServicePictureBox.Image
        End Get
        Set(value As Image)
            If ServicePictureBox.Image IsNot Nothing Then
                ServicePictureBox.Image.Dispose()
            End If
            ServicePictureBox.Image = value
        End Set
    End Property

    ' Click event to trigger the ServiceCardClick event
    Protected Overrides Sub OnClick(e As EventArgs)
        MyBase.OnClick(e)
        RaiseEvent ServiceCardClick(Me, e)
    End Sub

    ' Setup layout and appearance of the ServiceCard controls
    Private Sub SetupLayout()
        ' Service picture box setup
        With ServicePictureBox
            .SizeMode = PictureBoxSizeMode.StretchImage
            .Dock = DockStyle.Top
            .Height = 150

            ' Attempt to load a default image if none is provided
            Dim imagePath As String = "D:\UTM SEM 5\VBNET\UTMCONNECT\CODING\Images\noImageAvailable.jpg"
            If IO.File.Exists(imagePath) Then
                .Image = Image.FromFile(imagePath)
            Else
                MessageBox.Show("Image not found at path: " & imagePath & vbCrLf & "Using default placeholder.")
                .Image = Image.FromFile(imagePath)
            End If
        End With

        ' Service name label setup
        With ServiceNameLabel
            .Font = New Font("Arial Rounded MT Bold", 12.0F, FontStyle.Regular)
            .ForeColor = Color.Black
            .Dock = DockStyle.Top
            .TextAlign = ContentAlignment.MiddleCenter
        End With

        ' Seller username label setup
        With UsernameLabel
            .Font = New Font("Arial Rounded MT Bold", 10.0F, FontStyle.Regular)
            .ForeColor = Color.Gray
            .Dock = DockStyle.Top
            .TextAlign = ContentAlignment.MiddleCenter
        End With

        ' Service description label setup
        With ServiceDescriptionLabel
            .Font = New Font("Arial", 9.0F, FontStyle.Regular)
            .ForeColor = Color.DarkGray
            .Dock = DockStyle.Top
            .TextAlign = ContentAlignment.MiddleCenter
            .AutoEllipsis = True
        End With

        ' Service price label setup
        With ServicePriceLabel
            .Font = New Font("Arial Rounded MT Bold", 10.0F, FontStyle.Regular)
            .ForeColor = Color.Green
            .Dock = DockStyle.Bottom
            .TextAlign = ContentAlignment.MiddleCenter
            .Text = "Starting at RM 0.00"
        End With

        ' Style for the ServiceCard container
        Me.BorderStyle = BorderStyle.FixedSingle
        Me.Padding = New Padding(10)
        Me.Size = New Size(272, 458)
        Me.BackColor = Color.White
    End Sub
End Class
