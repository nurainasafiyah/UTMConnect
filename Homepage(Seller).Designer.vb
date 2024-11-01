<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Homepage_Seller_
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        ProfilePicture = New PictureBox()
        Label12 = New Label()
        HomepageButton = New Label()
        ServicePriceTextBox = New TextBox()
        Label10 = New Label()
        SellerName = New Label()
        ServiceIDTextBox = New TextBox()
        DeleteServiceButton = New Button()
        NextServiceButton = New Button()
        PreviousServiceButton = New Button()
        Label7 = New Label()
        ServiceDataGridView = New DataGridView()
        UpdateServiceButton = New Button()
        AddServiceButton = New Button()
        OrderStatusTextBox = New TextBox()
        Label1 = New Label()
        OrderIDTextBox2 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        SeviceIDTextBox2 = New TextBox()
        CustomerIDTextBox2 = New TextBox()
        UpdateOrderButton = New Button()
        DeleteOrderButton = New Button()
        AddOrderButton = New Button()
        NextOrderButton = New Button()
        PreviousOrderButton = New Button()
        Label4 = New Label()
        Label11 = New Label()
        CustomerOrderDataGridView = New DataGridView()
        OrderDateTextBox = New TextBox()
        Label13 = New Label()
        ServiceNameTextBox = New TextBox()
        ServiceName = New Label()
        ServiceDescriptionTextBox = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        ServicePictureBox = New PictureBox()
        SellerNameLabel = New Label()
        CType(ProfilePicture, ComponentModel.ISupportInitialize).BeginInit()
        CType(ServiceDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        CType(CustomerOrderDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        CType(ServicePictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ProfilePicture
        ' 
        ProfilePicture.Location = New Point(1537, 17)
        ProfilePicture.Name = "ProfilePicture"
        ProfilePicture.Size = New Size(37, 29)
        ProfilePicture.SizeMode = PictureBoxSizeMode.CenterImage
        ProfilePicture.TabIndex = 198
        ProfilePicture.TabStop = False
        ' 
        ' Label12
        ' 
        Label12.BackColor = SystemColors.ControlDarkDark
        Label12.ForeColor = SystemColors.ControlDarkDark
        Label12.Location = New Point(-1, 63)
        Label12.Name = "Label12"
        Label12.Size = New Size(803, 1)
        Label12.TabIndex = 193
        ' 
        ' HomepageButton
        ' 
        HomepageButton.AutoSize = True
        HomepageButton.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        HomepageButton.ForeColor = SystemColors.ControlLightLight
        HomepageButton.Location = New Point(58, 31)
        HomepageButton.Name = "HomepageButton"
        HomepageButton.Size = New Size(91, 15)
        HomepageButton.TabIndex = 192
        HomepageButton.Text = "UTMConnect"
        ' 
        ' ServicePriceTextBox
        ' 
        ServicePriceTextBox.Location = New Point(258, 691)
        ServicePriceTextBox.Name = "ServicePriceTextBox"
        ServicePriceTextBox.Size = New Size(212, 23)
        ServicePriceTextBox.TabIndex = 237
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = SystemColors.ControlLightLight
        Label10.Location = New Point(68, 694)
        Label10.Name = "Label10"
        Label10.Size = New Size(92, 20)
        Label10.TabIndex = 236
        Label10.Text = "Service Price"
        ' 
        ' SellerName
        ' 
        SellerName.AutoSize = True
        SellerName.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SellerName.ForeColor = SystemColors.ControlLightLight
        SellerName.Location = New Point(68, 89)
        SellerName.Name = "SellerName"
        SellerName.Size = New Size(143, 30)
        SellerName.TabIndex = 233
        SellerName.Text = "Your Services"
        ' 
        ' ServiceIDTextBox
        ' 
        ServiceIDTextBox.Location = New Point(258, 496)
        ServiceIDTextBox.Name = "ServiceIDTextBox"
        ServiceIDTextBox.Size = New Size(212, 23)
        ServiceIDTextBox.TabIndex = 232
        ' 
        ' DeleteServiceButton
        ' 
        DeleteServiceButton.AutoSize = True
        DeleteServiceButton.BackColor = Color.DarkRed
        DeleteServiceButton.FlatStyle = FlatStyle.Popup
        DeleteServiceButton.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DeleteServiceButton.ForeColor = Color.White
        DeleteServiceButton.ImageAlign = ContentAlignment.TopCenter
        DeleteServiceButton.Location = New Point(529, 859)
        DeleteServiceButton.Margin = New Padding(0)
        DeleteServiceButton.Name = "DeleteServiceButton"
        DeleteServiceButton.Size = New Size(203, 34)
        DeleteServiceButton.TabIndex = 228
        DeleteServiceButton.Text = "Delete"
        DeleteServiceButton.UseVisualStyleBackColor = False
        ' 
        ' NextServiceButton
        ' 
        NextServiceButton.AutoSize = True
        NextServiceButton.BackColor = Color.Gray
        NextServiceButton.FlatStyle = FlatStyle.Popup
        NextServiceButton.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        NextServiceButton.ForeColor = Color.White
        NextServiceButton.ImageAlign = ContentAlignment.TopCenter
        NextServiceButton.Location = New Point(529, 497)
        NextServiceButton.Margin = New Padding(0)
        NextServiceButton.Name = "NextServiceButton"
        NextServiceButton.Size = New Size(92, 34)
        NextServiceButton.TabIndex = 226
        NextServiceButton.Text = "Next"
        NextServiceButton.UseVisualStyleBackColor = False
        ' 
        ' PreviousServiceButton
        ' 
        PreviousServiceButton.AutoSize = True
        PreviousServiceButton.BackColor = Color.Gray
        PreviousServiceButton.FlatStyle = FlatStyle.Popup
        PreviousServiceButton.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PreviousServiceButton.ForeColor = Color.White
        PreviousServiceButton.ImageAlign = ContentAlignment.TopCenter
        PreviousServiceButton.Location = New Point(640, 497)
        PreviousServiceButton.Margin = New Padding(0)
        PreviousServiceButton.Name = "PreviousServiceButton"
        PreviousServiceButton.Size = New Size(92, 34)
        PreviousServiceButton.TabIndex = 225
        PreviousServiceButton.Text = "Previous"
        PreviousServiceButton.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ControlLightLight
        Label7.Location = New Point(68, 499)
        Label7.Name = "Label7"
        Label7.Size = New Size(75, 20)
        Label7.TabIndex = 224
        Label7.Text = "Service ID"
        ' 
        ' ServiceDataGridView
        ' 
        ServiceDataGridView.BackgroundColor = SystemColors.ControlLightLight
        ServiceDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ServiceDataGridView.Location = New Point(68, 138)
        ServiceDataGridView.Name = "ServiceDataGridView"
        ServiceDataGridView.Size = New Size(664, 314)
        ServiceDataGridView.TabIndex = 221
        ' 
        ' UpdateServiceButton
        ' 
        UpdateServiceButton.AutoSize = True
        UpdateServiceButton.BackColor = Color.Chocolate
        UpdateServiceButton.FlatStyle = FlatStyle.Popup
        UpdateServiceButton.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UpdateServiceButton.ForeColor = Color.White
        UpdateServiceButton.ImageAlign = ContentAlignment.TopCenter
        UpdateServiceButton.Location = New Point(640, 801)
        UpdateServiceButton.Margin = New Padding(0)
        UpdateServiceButton.Name = "UpdateServiceButton"
        UpdateServiceButton.Size = New Size(92, 34)
        UpdateServiceButton.TabIndex = 229
        UpdateServiceButton.Text = "Update"
        UpdateServiceButton.UseVisualStyleBackColor = False
        ' 
        ' AddServiceButton
        ' 
        AddServiceButton.AutoSize = True
        AddServiceButton.BackColor = Color.ForestGreen
        AddServiceButton.FlatStyle = FlatStyle.Popup
        AddServiceButton.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddServiceButton.ForeColor = Color.White
        AddServiceButton.ImageAlign = ContentAlignment.TopCenter
        AddServiceButton.Location = New Point(529, 801)
        AddServiceButton.Margin = New Padding(0)
        AddServiceButton.Name = "AddServiceButton"
        AddServiceButton.Size = New Size(92, 34)
        AddServiceButton.TabIndex = 227
        AddServiceButton.Text = "Add"
        AddServiceButton.UseVisualStyleBackColor = False
        ' 
        ' OrderStatusTextBox
        ' 
        OrderStatusTextBox.Location = New Point(1027, 638)
        OrderStatusTextBox.Name = "OrderStatusTextBox"
        OrderStatusTextBox.Size = New Size(212, 23)
        OrderStatusTextBox.TabIndex = 254
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(837, 641)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 20)
        Label1.TabIndex = 253
        Label1.Text = "Order Status"
        ' 
        ' OrderIDTextBox2
        ' 
        OrderIDTextBox2.Location = New Point(1027, 591)
        OrderIDTextBox2.Name = "OrderIDTextBox2"
        OrderIDTextBox2.ReadOnly = True
        OrderIDTextBox2.Size = New Size(212, 23)
        OrderIDTextBox2.TabIndex = 252
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(837, 594)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 20)
        Label2.TabIndex = 251
        Label2.Text = "Order ID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(837, 89)
        Label3.Name = "Label3"
        Label3.Size = New Size(178, 30)
        Label3.TabIndex = 250
        Label3.Text = "Customer Orders"
        ' 
        ' SeviceIDTextBox2
        ' 
        SeviceIDTextBox2.Location = New Point(1027, 545)
        SeviceIDTextBox2.Name = "SeviceIDTextBox2"
        SeviceIDTextBox2.ReadOnly = True
        SeviceIDTextBox2.Size = New Size(212, 23)
        SeviceIDTextBox2.TabIndex = 249
        ' 
        ' CustomerIDTextBox2
        ' 
        CustomerIDTextBox2.Location = New Point(1027, 497)
        CustomerIDTextBox2.Name = "CustomerIDTextBox2"
        CustomerIDTextBox2.ReadOnly = True
        CustomerIDTextBox2.Size = New Size(212, 23)
        CustomerIDTextBox2.TabIndex = 248
        ' 
        ' UpdateOrderButton
        ' 
        UpdateOrderButton.AutoSize = True
        UpdateOrderButton.BackColor = Color.Chocolate
        UpdateOrderButton.FlatStyle = FlatStyle.Popup
        UpdateOrderButton.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UpdateOrderButton.ForeColor = Color.White
        UpdateOrderButton.ImageAlign = ContentAlignment.TopCenter
        UpdateOrderButton.Location = New Point(1409, 615)
        UpdateOrderButton.Margin = New Padding(0)
        UpdateOrderButton.Name = "UpdateOrderButton"
        UpdateOrderButton.Size = New Size(92, 34)
        UpdateOrderButton.TabIndex = 246
        UpdateOrderButton.Text = "Update"
        UpdateOrderButton.UseVisualStyleBackColor = False
        ' 
        ' DeleteOrderButton
        ' 
        DeleteOrderButton.AutoSize = True
        DeleteOrderButton.BackColor = Color.DarkRed
        DeleteOrderButton.FlatStyle = FlatStyle.Popup
        DeleteOrderButton.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DeleteOrderButton.ForeColor = Color.White
        DeleteOrderButton.ImageAlign = ContentAlignment.TopCenter
        DeleteOrderButton.Location = New Point(1298, 673)
        DeleteOrderButton.Margin = New Padding(0)
        DeleteOrderButton.Name = "DeleteOrderButton"
        DeleteOrderButton.Size = New Size(203, 34)
        DeleteOrderButton.TabIndex = 245
        DeleteOrderButton.Text = "Delete"
        DeleteOrderButton.UseVisualStyleBackColor = False
        ' 
        ' AddOrderButton
        ' 
        AddOrderButton.AutoSize = True
        AddOrderButton.BackColor = Color.ForestGreen
        AddOrderButton.FlatStyle = FlatStyle.Popup
        AddOrderButton.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddOrderButton.ForeColor = Color.White
        AddOrderButton.ImageAlign = ContentAlignment.TopCenter
        AddOrderButton.Location = New Point(1298, 615)
        AddOrderButton.Margin = New Padding(0)
        AddOrderButton.Name = "AddOrderButton"
        AddOrderButton.Size = New Size(92, 34)
        AddOrderButton.TabIndex = 244
        AddOrderButton.Text = "Add"
        AddOrderButton.UseVisualStyleBackColor = False
        ' 
        ' NextOrderButton
        ' 
        NextOrderButton.AutoSize = True
        NextOrderButton.BackColor = Color.Gray
        NextOrderButton.FlatStyle = FlatStyle.Popup
        NextOrderButton.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        NextOrderButton.ForeColor = Color.White
        NextOrderButton.ImageAlign = ContentAlignment.TopCenter
        NextOrderButton.Location = New Point(1298, 497)
        NextOrderButton.Margin = New Padding(0)
        NextOrderButton.Name = "NextOrderButton"
        NextOrderButton.Size = New Size(92, 34)
        NextOrderButton.TabIndex = 243
        NextOrderButton.Text = "Next"
        NextOrderButton.UseVisualStyleBackColor = False
        ' 
        ' PreviousOrderButton
        ' 
        PreviousOrderButton.AutoSize = True
        PreviousOrderButton.BackColor = Color.Gray
        PreviousOrderButton.FlatStyle = FlatStyle.Popup
        PreviousOrderButton.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PreviousOrderButton.ForeColor = Color.White
        PreviousOrderButton.ImageAlign = ContentAlignment.TopCenter
        PreviousOrderButton.Location = New Point(1409, 497)
        PreviousOrderButton.Margin = New Padding(0)
        PreviousOrderButton.Name = "PreviousOrderButton"
        PreviousOrderButton.Size = New Size(92, 34)
        PreviousOrderButton.TabIndex = 242
        PreviousOrderButton.Text = "Previous"
        PreviousOrderButton.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(837, 548)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 20)
        Label4.TabIndex = 241
        Label4.Text = "Service ID"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = SystemColors.ControlLightLight
        Label11.Location = New Point(837, 500)
        Label11.Name = "Label11"
        Label11.Size = New Size(91, 20)
        Label11.TabIndex = 239
        Label11.Text = "Customer ID"
        ' 
        ' CustomerOrderDataGridView
        ' 
        CustomerOrderDataGridView.BackgroundColor = SystemColors.ControlLightLight
        CustomerOrderDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        CustomerOrderDataGridView.Location = New Point(837, 138)
        CustomerOrderDataGridView.Name = "CustomerOrderDataGridView"
        CustomerOrderDataGridView.Size = New Size(664, 314)
        CustomerOrderDataGridView.TabIndex = 238
        ' 
        ' OrderDateTextBox
        ' 
        OrderDateTextBox.Location = New Point(1027, 687)
        OrderDateTextBox.Name = "OrderDateTextBox"
        OrderDateTextBox.ReadOnly = True
        OrderDateTextBox.Size = New Size(212, 23)
        OrderDateTextBox.TabIndex = 256
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = SystemColors.ControlLightLight
        Label13.Location = New Point(837, 690)
        Label13.Name = "Label13"
        Label13.Size = New Size(83, 20)
        Label13.TabIndex = 255
        Label13.Text = "Order Date"
        ' 
        ' ServiceNameTextBox
        ' 
        ServiceNameTextBox.Location = New Point(258, 538)
        ServiceNameTextBox.Name = "ServiceNameTextBox"
        ServiceNameTextBox.Size = New Size(212, 23)
        ServiceNameTextBox.TabIndex = 258
        ' 
        ' ServiceName
        ' 
        ServiceName.AutoSize = True
        ServiceName.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ServiceName.ForeColor = SystemColors.ControlLightLight
        ServiceName.Location = New Point(68, 541)
        ServiceName.Name = "ServiceName"
        ServiceName.Size = New Size(100, 20)
        ServiceName.TabIndex = 257
        ServiceName.Text = "Service Name"
        ' 
        ' ServiceDescriptionTextBox
        ' 
        ServiceDescriptionTextBox.Location = New Point(258, 577)
        ServiceDescriptionTextBox.Multiline = True
        ServiceDescriptionTextBox.Name = "ServiceDescriptionTextBox"
        ServiceDescriptionTextBox.Size = New Size(212, 84)
        ServiceDescriptionTextBox.TabIndex = 260
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(68, 580)
        Label5.Name = "Label5"
        Label5.Size = New Size(136, 20)
        Label5.TabIndex = 259
        Label5.Text = "Service Description"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ControlLightLight
        Label6.Location = New Point(68, 738)
        Label6.Name = "Label6"
        Label6.Size = New Size(105, 20)
        Label6.TabIndex = 261
        Label6.Text = "Service Picture"
        ' 
        ' ServicePictureBox
        ' 
        ServicePictureBox.Location = New Point(258, 750)
        ServicePictureBox.Name = "ServicePictureBox"
        ServicePictureBox.Size = New Size(212, 141)
        ServicePictureBox.SizeMode = PictureBoxSizeMode.CenterImage
        ServicePictureBox.TabIndex = 262
        ServicePictureBox.TabStop = False
        ' 
        ' SellerNameLabel
        ' 
        SellerNameLabel.AutoSize = True
        SellerNameLabel.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SellerNameLabel.ForeColor = SystemColors.ControlLightLight
        SellerNameLabel.Location = New Point(247, 101)
        SellerNameLabel.Name = "SellerNameLabel"
        SellerNameLabel.Size = New Size(84, 15)
        SellerNameLabel.TabIndex = 263
        SellerNameLabel.Text = "SellerName"
        ' 
        ' Homepage_Seller_
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(1586, 932)
        Controls.Add(SellerNameLabel)
        Controls.Add(ServicePictureBox)
        Controls.Add(Label6)
        Controls.Add(ServiceDescriptionTextBox)
        Controls.Add(Label5)
        Controls.Add(ServiceNameTextBox)
        Controls.Add(ServiceName)
        Controls.Add(OrderDateTextBox)
        Controls.Add(Label13)
        Controls.Add(OrderStatusTextBox)
        Controls.Add(Label1)
        Controls.Add(OrderIDTextBox2)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(SeviceIDTextBox2)
        Controls.Add(CustomerIDTextBox2)
        Controls.Add(UpdateOrderButton)
        Controls.Add(DeleteOrderButton)
        Controls.Add(AddOrderButton)
        Controls.Add(NextOrderButton)
        Controls.Add(PreviousOrderButton)
        Controls.Add(Label4)
        Controls.Add(Label11)
        Controls.Add(CustomerOrderDataGridView)
        Controls.Add(ServicePriceTextBox)
        Controls.Add(Label10)
        Controls.Add(SellerName)
        Controls.Add(ServiceIDTextBox)
        Controls.Add(UpdateServiceButton)
        Controls.Add(DeleteServiceButton)
        Controls.Add(AddServiceButton)
        Controls.Add(NextServiceButton)
        Controls.Add(PreviousServiceButton)
        Controls.Add(Label7)
        Controls.Add(ServiceDataGridView)
        Controls.Add(ProfilePicture)
        Controls.Add(Label12)
        Controls.Add(HomepageButton)
        Name = "Homepage_Seller_"
        Text = "Homepage_Seller_"
        CType(ProfilePicture, ComponentModel.ISupportInitialize).EndInit()
        CType(ServiceDataGridView, ComponentModel.ISupportInitialize).EndInit()
        CType(CustomerOrderDataGridView, ComponentModel.ISupportInitialize).EndInit()
        CType(ServicePictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents ProfilePicture As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents HomepageButton As Label
    Friend WithEvents ServicePriceTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents SellerName As Label
    Friend WithEvents ServiceIDTextBox As TextBox
    Friend WithEvents DeleteServiceButton As Button
    Friend WithEvents NextServiceButton As Button
    Friend WithEvents PreviousServiceButton As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents ServiceDataGridView As DataGridView
    Friend WithEvents UpdateServiceButton As Button
    Friend WithEvents AddServiceButton As Button
    Friend WithEvents OrderStatusTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents OrderIDTextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SeviceIDTextBox2 As TextBox
    Friend WithEvents CustomerIDTextBox2 As TextBox
    Friend WithEvents UpdateOrderButton As Button
    Friend WithEvents DeleteOrderButton As Button
    Friend WithEvents AddOrderButton As Button
    Friend WithEvents NextOrderButton As Button
    Friend WithEvents PreviousOrderButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents CustomerOrderDataGridView As DataGridView
    Friend WithEvents OrderDateTextBox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ServiceNameTextBox As TextBox
    Friend WithEvents ServiceName As Label
    Friend WithEvents ServiceDescriptionTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ServicePictureBox As PictureBox
    Friend WithEvents SellerNameLabel As Label
End Class
