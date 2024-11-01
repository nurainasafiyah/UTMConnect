<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageService_Admin_
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageService_Admin_))
        Label8 = New Label()
        SellerIDTextBox = New TextBox()
        ServiceIDTextBox = New TextBox()
        ServiceNameTextBox = New TextBox()
        Label23 = New Label()
        Label22 = New Label()
        Label21 = New Label()
        Label20 = New Label()
        UpdateServiceButton = New Button()
        DeleteServiceButton = New Button()
        AddServiceButton = New Button()
        NextServiceButton = New Button()
        PreviousServicceButton = New Button()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        ServicesDataGridView = New DataGridView()
        Label1 = New Label()
        ProfilePicture = New PictureBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label19 = New Label()
        Label12 = New Label()
        HomepageButton = New Label()
        UsernameTextBox = New TextBox()
        Label9 = New Label()
        DescriptionTextBox = New TextBox()
        Label10 = New Label()
        ServicePriceTextBox = New TextBox()
        Label11 = New Label()
        Label13 = New Label()
        ServicePictureBox = New PictureBox()
        UploadImageButton = New Button()
        CType(ServicesDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        CType(ProfilePicture, ComponentModel.ISupportInitialize).BeginInit()
        CType(ServicePictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ControlLightLight
        Label8.Location = New Point(58, 94)
        Label8.Name = "Label8"
        Label8.Size = New Size(177, 30)
        Label8.TabIndex = 191
        Label8.Text = "Manage Services"
        ' 
        ' SellerIDTextBox
        ' 
        SellerIDTextBox.Location = New Point(248, 546)
        SellerIDTextBox.Name = "SellerIDTextBox"
        SellerIDTextBox.Size = New Size(212, 23)
        SellerIDTextBox.TabIndex = 190
        ' 
        ' ServiceIDTextBox
        ' 
        ServiceIDTextBox.Location = New Point(248, 498)
        ServiceIDTextBox.Name = "ServiceIDTextBox"
        ServiceIDTextBox.Size = New Size(212, 23)
        ServiceIDTextBox.TabIndex = 189
        ' 
        ' ServiceNameTextBox
        ' 
        ServiceNameTextBox.Location = New Point(248, 455)
        ServiceNameTextBox.Name = "ServiceNameTextBox"
        ServiceNameTextBox.Size = New Size(212, 23)
        ServiceNameTextBox.TabIndex = 188
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label23.ForeColor = SystemColors.ControlDark
        Label23.Location = New Point(408, 984)
        Label23.Name = "Label23"
        Label23.Size = New Size(45, 15)
        Label23.TabIndex = 187
        Label23.Text = "About"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label22.ForeColor = SystemColors.ControlDark
        Label22.Location = New Point(471, 984)
        Label22.Name = "Label22"
        Label22.Size = New Size(99, 15)
        Label22.TabIndex = 186
        Label22.Text = "Privacy Policy"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = SystemColors.ControlDark
        Label21.Location = New Point(576, 984)
        Label21.Name = "Label21"
        Label21.Size = New Size(70, 15)
        Label21.TabIndex = 185
        Label21.Text = "Liscening"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label20.ForeColor = SystemColors.ControlDark
        Label20.Location = New Point(656, 984)
        Label20.Name = "Label20"
        Label20.Size = New Size(59, 15)
        Label20.TabIndex = 184
        Label20.Text = "Contact"
        ' 
        ' UpdateServiceButton
        ' 
        UpdateServiceButton.AutoSize = True
        UpdateServiceButton.BackColor = Color.Chocolate
        UpdateServiceButton.FlatStyle = FlatStyle.Popup
        UpdateServiceButton.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UpdateServiceButton.ForeColor = Color.White
        UpdateServiceButton.ImageAlign = ContentAlignment.TopCenter
        UpdateServiceButton.Location = New Point(623, 860)
        UpdateServiceButton.Margin = New Padding(0)
        UpdateServiceButton.Name = "UpdateServiceButton"
        UpdateServiceButton.Size = New Size(92, 34)
        UpdateServiceButton.TabIndex = 183
        UpdateServiceButton.Text = "Update"
        UpdateServiceButton.UseVisualStyleBackColor = False
        ' 
        ' DeleteServiceButton
        ' 
        DeleteServiceButton.AutoSize = True
        DeleteServiceButton.BackColor = Color.DarkRed
        DeleteServiceButton.FlatStyle = FlatStyle.Popup
        DeleteServiceButton.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DeleteServiceButton.ForeColor = Color.White
        DeleteServiceButton.ImageAlign = ContentAlignment.TopCenter
        DeleteServiceButton.Location = New Point(512, 918)
        DeleteServiceButton.Margin = New Padding(0)
        DeleteServiceButton.Name = "DeleteServiceButton"
        DeleteServiceButton.Size = New Size(203, 34)
        DeleteServiceButton.TabIndex = 182
        DeleteServiceButton.Text = "Delete"
        DeleteServiceButton.UseVisualStyleBackColor = False
        ' 
        ' AddServiceButton
        ' 
        AddServiceButton.AutoSize = True
        AddServiceButton.BackColor = Color.ForestGreen
        AddServiceButton.FlatStyle = FlatStyle.Popup
        AddServiceButton.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddServiceButton.ForeColor = Color.White
        AddServiceButton.ImageAlign = ContentAlignment.TopCenter
        AddServiceButton.Location = New Point(512, 860)
        AddServiceButton.Margin = New Padding(0)
        AddServiceButton.Name = "AddServiceButton"
        AddServiceButton.Size = New Size(92, 34)
        AddServiceButton.TabIndex = 181
        AddServiceButton.Text = "Add"
        AddServiceButton.UseVisualStyleBackColor = False
        ' 
        ' NextServiceButton
        ' 
        NextServiceButton.AutoSize = True
        NextServiceButton.BackColor = Color.Gray
        NextServiceButton.FlatStyle = FlatStyle.Popup
        NextServiceButton.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        NextServiceButton.ForeColor = Color.White
        NextServiceButton.ImageAlign = ContentAlignment.TopCenter
        NextServiceButton.Location = New Point(630, 459)
        NextServiceButton.Margin = New Padding(0)
        NextServiceButton.Name = "NextServiceButton"
        NextServiceButton.Size = New Size(92, 34)
        NextServiceButton.TabIndex = 180
        NextServiceButton.Text = "Next"
        NextServiceButton.UseVisualStyleBackColor = False
        ' 
        ' PreviousServicceButton
        ' 
        PreviousServicceButton.AutoSize = True
        PreviousServicceButton.BackColor = Color.Gray
        PreviousServicceButton.FlatStyle = FlatStyle.Popup
        PreviousServicceButton.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PreviousServicceButton.ForeColor = Color.White
        PreviousServicceButton.ImageAlign = ContentAlignment.TopCenter
        PreviousServicceButton.Location = New Point(519, 459)
        PreviousServicceButton.Margin = New Padding(0)
        PreviousServicceButton.Name = "PreviousServicceButton"
        PreviousServicceButton.Size = New Size(92, 34)
        PreviousServicceButton.TabIndex = 179
        PreviousServicceButton.Text = "Previous"
        PreviousServicceButton.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ControlLightLight
        Label7.Location = New Point(58, 545)
        Label7.Name = "Label7"
        Label7.Size = New Size(65, 20)
        Label7.TabIndex = 178
        Label7.Text = "Seller ID"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ControlLightLight
        Label6.Location = New Point(58, 501)
        Label6.Name = "Label6"
        Label6.Size = New Size(75, 20)
        Label6.TabIndex = 177
        Label6.Text = "Service ID"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(58, 459)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 20)
        Label5.TabIndex = 176
        Label5.Text = "Service Name"
        ' 
        ' ServicesDataGridView
        ' 
        ServicesDataGridView.BackgroundColor = SystemColors.ControlLightLight
        ServicesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ServicesDataGridView.Location = New Point(58, 143)
        ServicesDataGridView.Name = "ServicesDataGridView"
        ServicesDataGridView.Size = New Size(664, 267)
        ServicesDataGridView.TabIndex = 175
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlDark
        Label1.Location = New Point(354, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 15)
        Label1.TabIndex = 174
        Label1.Text = "Booking"
        ' 
        ' ProfilePicture
        ' 
        ProfilePicture.Location = New Point(722, 21)
        ProfilePicture.Name = "ProfilePicture"
        ProfilePicture.Size = New Size(37, 29)
        ProfilePicture.SizeMode = PictureBoxSizeMode.CenterImage
        ProfilePicture.TabIndex = 173
        ProfilePicture.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlDark
        Label4.Location = New Point(232, 31)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 15)
        Label4.TabIndex = 172
        Label4.Text = "Seller"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlDark
        Label3.Location = New Point(284, 31)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 15)
        Label3.TabIndex = 171
        Label3.Text = "Services"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlDark
        Label2.Location = New Point(155, 31)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 15)
        Label2.TabIndex = 170
        Label2.Text = "Customer"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label19.ForeColor = SystemColors.ControlLightLight
        Label19.Location = New Point(64, 984)
        Label19.Name = "Label19"
        Label19.Size = New Size(91, 15)
        Label19.TabIndex = 169
        Label19.Text = "UTMConnect"
        ' 
        ' Label12
        ' 
        Label12.BackColor = SystemColors.ControlDarkDark
        Label12.ForeColor = SystemColors.ControlDarkDark
        Label12.Location = New Point(-1, 63)
        Label12.Name = "Label12"
        Label12.Size = New Size(803, 1)
        Label12.TabIndex = 168
        ' 
        ' HomepageButton
        ' 
        HomepageButton.AutoSize = True
        HomepageButton.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        HomepageButton.ForeColor = SystemColors.ControlLightLight
        HomepageButton.Location = New Point(58, 31)
        HomepageButton.Name = "HomepageButton"
        HomepageButton.Size = New Size(91, 15)
        HomepageButton.TabIndex = 167
        HomepageButton.Text = "UTMConnect"
        ' 
        ' UsernameTextBox
        ' 
        UsernameTextBox.Location = New Point(248, 591)
        UsernameTextBox.Name = "UsernameTextBox"
        UsernameTextBox.Size = New Size(212, 23)
        UsernameTextBox.TabIndex = 193
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.ControlLightLight
        Label9.Location = New Point(58, 590)
        Label9.Name = "Label9"
        Label9.Size = New Size(75, 20)
        Label9.TabIndex = 192
        Label9.Text = "Username"
        ' 
        ' DescriptionTextBox
        ' 
        DescriptionTextBox.Location = New Point(248, 636)
        DescriptionTextBox.Name = "DescriptionTextBox"
        DescriptionTextBox.Size = New Size(212, 23)
        DescriptionTextBox.TabIndex = 195
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = SystemColors.ControlLightLight
        Label10.Location = New Point(58, 635)
        Label10.Name = "Label10"
        Label10.Size = New Size(85, 20)
        Label10.TabIndex = 194
        Label10.Text = "Description"
        ' 
        ' ServicePriceTextBox
        ' 
        ServicePriceTextBox.Location = New Point(248, 676)
        ServicePriceTextBox.Name = "ServicePriceTextBox"
        ServicePriceTextBox.Size = New Size(212, 23)
        ServicePriceTextBox.TabIndex = 197
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = SystemColors.ControlLightLight
        Label11.Location = New Point(58, 675)
        Label11.Name = "Label11"
        Label11.Size = New Size(41, 20)
        Label11.TabIndex = 196
        Label11.Text = "Price"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = SystemColors.ControlLightLight
        Label13.Location = New Point(58, 711)
        Label13.Name = "Label13"
        Label13.Size = New Size(54, 20)
        Label13.TabIndex = 198
        Label13.Text = "Picture"
        ' 
        ' ServicePictureBox
        ' 
        ServicePictureBox.BackColor = SystemColors.ActiveCaptionText
        ServicePictureBox.BackgroundImage = CType(resources.GetObject("ServicePictureBox.BackgroundImage"), Image)
        ServicePictureBox.BorderStyle = BorderStyle.FixedSingle
        ServicePictureBox.Location = New Point(248, 723)
        ServicePictureBox.Name = "ServicePictureBox"
        ServicePictureBox.Size = New Size(212, 180)
        ServicePictureBox.SizeMode = PictureBoxSizeMode.CenterImage
        ServicePictureBox.TabIndex = 199
        ServicePictureBox.TabStop = False
        ' 
        ' UploadImageButton
        ' 
        UploadImageButton.AutoSize = True
        UploadImageButton.BackColor = Color.Indigo
        UploadImageButton.FlatStyle = FlatStyle.Popup
        UploadImageButton.ForeColor = Color.White
        UploadImageButton.ImageAlign = ContentAlignment.TopCenter
        UploadImageButton.Location = New Point(248, 919)
        UploadImageButton.Margin = New Padding(0)
        UploadImageButton.Name = "UploadImageButton"
        UploadImageButton.Size = New Size(212, 34)
        UploadImageButton.TabIndex = 200
        UploadImageButton.Text = "Upload Image"
        UploadImageButton.UseVisualStyleBackColor = False
        ' 
        ' ManageService_Admin_
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(800, 1026)
        Controls.Add(UploadImageButton)
        Controls.Add(ServicePictureBox)
        Controls.Add(Label13)
        Controls.Add(ServicePriceTextBox)
        Controls.Add(Label11)
        Controls.Add(DescriptionTextBox)
        Controls.Add(Label10)
        Controls.Add(UsernameTextBox)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(SellerIDTextBox)
        Controls.Add(ServiceIDTextBox)
        Controls.Add(ServiceNameTextBox)
        Controls.Add(Label23)
        Controls.Add(Label22)
        Controls.Add(Label21)
        Controls.Add(Label20)
        Controls.Add(UpdateServiceButton)
        Controls.Add(DeleteServiceButton)
        Controls.Add(AddServiceButton)
        Controls.Add(NextServiceButton)
        Controls.Add(PreviousServicceButton)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(ServicesDataGridView)
        Controls.Add(Label1)
        Controls.Add(ProfilePicture)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label19)
        Controls.Add(Label12)
        Controls.Add(HomepageButton)
        Name = "ManageService_Admin_"
        Text = "ManageService_Admin_"
        CType(ServicesDataGridView, ComponentModel.ISupportInitialize).EndInit()
        CType(ProfilePicture, ComponentModel.ISupportInitialize).EndInit()
        CType(ServicePictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents SellerIDTextBox As TextBox
    Friend WithEvents ServiceIDTextBox As TextBox
    Friend WithEvents ServiceNameTextBox As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents UpdateServiceButton As Button
    Friend WithEvents DeleteServiceButton As Button
    Friend WithEvents AddServiceButton As Button
    Friend WithEvents NextServiceButton As Button
    Friend WithEvents PreviousServicceButton As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ServicesDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ProfilePicture As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents HomepageButton As Label
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ServicePriceTextBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ServicePictureBox As PictureBox
    Friend WithEvents UploadImageButton As Button
End Class
