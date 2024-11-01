<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrderPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ServiceTotalPriceLabel As Label
        Label23 = New Label()
        Label22 = New Label()
        Label21 = New Label()
        Label20 = New Label()
        Label19 = New Label()
        ProfilePicture = New PictureBox()
        Label4 = New Label()
        Label3 = New Label()
        ServiceLabel = New Label()
        Label12 = New Label()
        HomepageButton = New Label()
        ServiceName = New Label()
        ServicePictureBox = New PictureBox()
        Label5 = New Label()
        Label6 = New Label()
        ServiceDescription = New Label()
        ServiceDetails = New Label()
        PurchaseButton = New Button()
        Label8 = New Label()
        SellerName = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        ServicePrice = New Label()
        Label13 = New Label()
        SellerContNum = New Label()
        Label15 = New Label()
        Label2 = New Label()
        QuantityNumericUpDown = New NumericUpDown()
        ServiceTotalPriceButton = New Button()
        ServiceTotalPriceLabel = New Label()
        CType(ProfilePicture, ComponentModel.ISupportInitialize).BeginInit()
        CType(ServicePictureBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(QuantityNumericUpDown, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ServiceTotalPriceLabel
        ' 
        ServiceTotalPriceLabel.BackColor = Color.Indigo
        ServiceTotalPriceLabel.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ServiceTotalPriceLabel.ForeColor = SystemColors.ControlLightLight
        ServiceTotalPriceLabel.Location = New Point(679, 476)
        ServiceTotalPriceLabel.Name = "ServiceTotalPriceLabel"
        ServiceTotalPriceLabel.Size = New Size(57, 17)
        ServiceTotalPriceLabel.TabIndex = 133
        ServiceTotalPriceLabel.Text = "0.00"
        ServiceTotalPriceLabel.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label23.ForeColor = SystemColors.ControlDark
        Label23.Location = New Point(435, 753)
        Label23.Name = "Label23"
        Label23.Size = New Size(45, 15)
        Label23.TabIndex = 118
        Label23.Text = "About"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label22.ForeColor = SystemColors.ControlDark
        Label22.Location = New Point(498, 753)
        Label22.Name = "Label22"
        Label22.Size = New Size(99, 15)
        Label22.TabIndex = 117
        Label22.Text = "Privacy Policy"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = SystemColors.ControlDark
        Label21.Location = New Point(603, 753)
        Label21.Name = "Label21"
        Label21.Size = New Size(70, 15)
        Label21.TabIndex = 116
        Label21.Text = "Liscening"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label20.ForeColor = SystemColors.ControlDark
        Label20.Location = New Point(683, 753)
        Label20.Name = "Label20"
        Label20.Size = New Size(59, 15)
        Label20.TabIndex = 115
        Label20.Text = "Contact"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label19.ForeColor = SystemColors.ControlLightLight
        Label19.Location = New Point(59, 753)
        Label19.Name = "Label19"
        Label19.Size = New Size(91, 15)
        Label19.TabIndex = 114
        Label19.Text = "UTMConnect"
        ' 
        ' ProfilePicture
        ' 
        ProfilePicture.Location = New Point(723, 30)
        ProfilePicture.Name = "ProfilePicture"
        ProfilePicture.Size = New Size(37, 29)
        ProfilePicture.SizeMode = PictureBoxSizeMode.CenterImage
        ProfilePicture.TabIndex = 112
        ProfilePicture.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlDark
        Label4.Location = New Point(276, 39)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 15)
        Label4.TabIndex = 111
        Label4.Text = "Contact"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlDark
        Label3.Location = New Point(225, 39)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 15)
        Label3.TabIndex = 110
        Label3.Text = "About"
        ' 
        ' ServiceLabel
        ' 
        ServiceLabel.AutoSize = True
        ServiceLabel.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ServiceLabel.ForeColor = SystemColors.ControlDark
        ServiceLabel.Location = New Point(155, 39)
        ServiceLabel.Name = "ServiceLabel"
        ServiceLabel.Size = New Size(64, 15)
        ServiceLabel.TabIndex = 109
        ServiceLabel.Text = "Services"
        ' 
        ' Label12
        ' 
        Label12.BackColor = SystemColors.ControlDarkDark
        Label12.ForeColor = SystemColors.ControlDarkDark
        Label12.Location = New Point(0, 72)
        Label12.Name = "Label12"
        Label12.Size = New Size(803, 1)
        Label12.TabIndex = 108
        ' 
        ' HomepageButton
        ' 
        HomepageButton.AutoSize = True
        HomepageButton.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        HomepageButton.ForeColor = SystemColors.ControlLightLight
        HomepageButton.Location = New Point(58, 39)
        HomepageButton.Name = "HomepageButton"
        HomepageButton.Size = New Size(91, 15)
        HomepageButton.TabIndex = 107
        HomepageButton.Text = "UTMConnect"
        ' 
        ' ServiceName
        ' 
        ServiceName.AutoSize = True
        ServiceName.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ServiceName.ForeColor = SystemColors.ControlLightLight
        ServiceName.Location = New Point(59, 114)
        ServiceName.Name = "ServiceName"
        ServiceName.Size = New Size(141, 30)
        ServiceName.TabIndex = 119
        ServiceName.Text = "ServiceName"
        ' 
        ' ServicePictureBox
        ' 
        ServicePictureBox.Location = New Point(59, 165)
        ServicePictureBox.Name = "ServicePictureBox"
        ServicePictureBox.Size = New Size(421, 308)
        ServicePictureBox.SizeMode = PictureBoxSizeMode.CenterImage
        ServicePictureBox.TabIndex = 120
        ServicePictureBox.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(59, 505)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 21)
        Label5.TabIndex = 121
        Label5.Text = "About Gig"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(59, 548)
        Label6.Name = "Label6"
        Label6.Size = New Size(41, 15)
        Label6.TabIndex = 122
        Label6.Text = "Label6"
        ' 
        ' ServiceDescription
        ' 
        ServiceDescription.BorderStyle = BorderStyle.FixedSingle
        ServiceDescription.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ServiceDescription.ForeColor = SystemColors.ControlLightLight
        ServiceDescription.Location = New Point(60, 549)
        ServiceDescription.Name = "ServiceDescription"
        ServiceDescription.Size = New Size(421, 147)
        ServiceDescription.TabIndex = 123
        ' 
        ' ServiceDetails
        ' 
        ServiceDetails.BackColor = Color.Indigo
        ServiceDetails.Location = New Point(508, 165)
        ServiceDetails.Name = "ServiceDetails"
        ServiceDetails.Size = New Size(252, 512)
        ServiceDetails.TabIndex = 124
        ' 
        ' PurchaseButton
        ' 
        PurchaseButton.AutoSize = True
        PurchaseButton.BackColor = SystemColors.ControlLight
        PurchaseButton.FlatStyle = FlatStyle.Popup
        PurchaseButton.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PurchaseButton.ForeColor = Color.Black
        PurchaseButton.ImageAlign = ContentAlignment.TopCenter
        PurchaseButton.Location = New Point(533, 571)
        PurchaseButton.Margin = New Padding(0)
        PurchaseButton.Name = "PurchaseButton"
        PurchaseButton.Size = New Size(209, 34)
        PurchaseButton.TabIndex = 125
        PurchaseButton.Text = "Purchase"
        PurchaseButton.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Indigo
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ControlLightLight
        Label8.Location = New Point(533, 195)
        Label8.Name = "Label8"
        Label8.Size = New Size(53, 21)
        Label8.TabIndex = 126
        Label8.Text = "Seller"
        ' 
        ' SellerName
        ' 
        SellerName.BackColor = Color.Indigo
        SellerName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SellerName.ForeColor = SystemColors.ControlLightLight
        SellerName.Location = New Point(640, 196)
        SellerName.Name = "SellerName"
        SellerName.Size = New Size(94, 48)
        SellerName.TabIndex = 127
        SellerName.Text = "Seller Name"
        SellerName.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Indigo
        Label9.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.ControlLightLight
        Label9.Location = New Point(533, 406)
        Label9.Name = "Label9"
        Label9.Size = New Size(62, 17)
        Label9.TabIndex = 128
        Label9.Text = "Quantity"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Indigo
        Label10.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = SystemColors.ControlLightLight
        Label10.Location = New Point(535, 378)
        Label10.Name = "Label10"
        Label10.Size = New Size(38, 17)
        Label10.TabIndex = 129
        Label10.Text = "Price"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Indigo
        Label11.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = SystemColors.ControlLightLight
        Label11.Location = New Point(535, 476)
        Label11.Name = "Label11"
        Label11.Size = New Size(39, 17)
        Label11.TabIndex = 130
        Label11.Text = "Total"
        ' 
        ' ServicePrice
        ' 
        ServicePrice.BackColor = Color.Indigo
        ServicePrice.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ServicePrice.ForeColor = SystemColors.ControlLightLight
        ServicePrice.Location = New Point(603, 378)
        ServicePrice.Name = "ServicePrice"
        ServicePrice.Size = New Size(139, 17)
        ServicePrice.TabIndex = 131
        ServicePrice.Text = "8.00"
        ServicePrice.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Indigo
        Label13.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = SystemColors.ControlLightLight
        Label13.Location = New Point(645, 476)
        Label13.Name = "Label13"
        Label13.Size = New Size(28, 17)
        Label13.TabIndex = 134
        Label13.Text = "RM"
        Label13.TextAlign = ContentAlignment.TopRight
        ' 
        ' SellerContNum
        ' 
        SellerContNum.BackColor = Color.Indigo
        SellerContNum.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SellerContNum.ForeColor = SystemColors.ControlLightLight
        SellerContNum.Location = New Point(628, 258)
        SellerContNum.Name = "SellerContNum"
        SellerContNum.Size = New Size(106, 50)
        SellerContNum.TabIndex = 136
        SellerContNum.Text = "0123790540"
        SellerContNum.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label15
        ' 
        Label15.BackColor = Color.Indigo
        Label15.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = SystemColors.ControlLightLight
        Label15.Location = New Point(535, 258)
        Label15.Name = "Label15"
        Label15.Size = New Size(73, 50)
        Label15.TabIndex = 137
        Label15.Text = "Phone Num."
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Indigo
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(533, 623)
        Label2.Name = "Label2"
        Label2.Size = New Size(209, 37)
        Label2.TabIndex = 138
        Label2.Text = "*Please take note that total price is change after you click Total button"
        ' 
        ' QuantityNumericUpDown
        ' 
        QuantityNumericUpDown.Location = New Point(683, 406)
        QuantityNumericUpDown.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        QuantityNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        QuantityNumericUpDown.Name = "QuantityNumericUpDown"
        QuantityNumericUpDown.Size = New Size(59, 23)
        QuantityNumericUpDown.TabIndex = 139
        QuantityNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' ServiceTotalPriceButton
        ' 
        ServiceTotalPriceButton.AutoSize = True
        ServiceTotalPriceButton.BackColor = SystemColors.ControlLight
        ServiceTotalPriceButton.FlatStyle = FlatStyle.Popup
        ServiceTotalPriceButton.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ServiceTotalPriceButton.ForeColor = Color.Black
        ServiceTotalPriceButton.ImageAlign = ContentAlignment.TopCenter
        ServiceTotalPriceButton.Location = New Point(628, 519)
        ServiceTotalPriceButton.Margin = New Padding(0)
        ServiceTotalPriceButton.Name = "ServiceTotalPriceButton"
        ServiceTotalPriceButton.Size = New Size(114, 34)
        ServiceTotalPriceButton.TabIndex = 140
        ServiceTotalPriceButton.Text = "Total"
        ServiceTotalPriceButton.UseVisualStyleBackColor = False
        ' 
        ' OrderPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(800, 797)
        Controls.Add(ServiceTotalPriceButton)
        Controls.Add(QuantityNumericUpDown)
        Controls.Add(Label2)
        Controls.Add(Label15)
        Controls.Add(SellerContNum)
        Controls.Add(Label13)
        Controls.Add(ServiceTotalPriceLabel)
        Controls.Add(ServicePrice)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(SellerName)
        Controls.Add(Label8)
        Controls.Add(PurchaseButton)
        Controls.Add(ServiceDetails)
        Controls.Add(ServiceDescription)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(ServicePictureBox)
        Controls.Add(ServiceName)
        Controls.Add(Label23)
        Controls.Add(Label22)
        Controls.Add(Label21)
        Controls.Add(Label20)
        Controls.Add(Label19)
        Controls.Add(ProfilePicture)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(ServiceLabel)
        Controls.Add(Label12)
        Controls.Add(HomepageButton)
        Name = "OrderPage"
        Text = "OrderPage"
        CType(ProfilePicture, ComponentModel.ISupportInitialize).EndInit()
        CType(ServicePictureBox, ComponentModel.ISupportInitialize).EndInit()
        CType(QuantityNumericUpDown, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents ProfilePicture As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ServiceLabel As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents HomepageButton As Label
    Friend WithEvents ServiceName As Label
    Friend WithEvents ServicePictureBox As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ServiceDescription As Label
    Friend WithEvents ServiceDetails As Label
    Friend WithEvents PurchaseButton As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents SellerName As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ServicePrice As Label
    Friend WithEvents ServiceTotalPriceLabel As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents SellerContNum As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents QuantityNumericUpDown As NumericUpDown
    Friend WithEvents ServiceTotalPriceButton As Button
End Class