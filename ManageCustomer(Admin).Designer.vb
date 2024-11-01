<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageCustomer_Admin_
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
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label19 = New Label()
        Label12 = New Label()
        HomepageButton = New Label()
        Label1 = New Label()
        CustomerDataGridView = New DataGridView()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        PreviousButton = New Button()
        NextCustomerButton = New Button()
        AddCustomerButton = New Button()
        DeleteCustomerButton = New Button()
        UpdateButton = New Button()
        Label23 = New Label()
        Label22 = New Label()
        Label21 = New Label()
        Label20 = New Label()
        CustFullNameTextBox = New TextBox()
        CustIDTextBox = New TextBox()
        RoleIDTextBox = New TextBox()
        Label8 = New Label()
        UsernameTextBox = New TextBox()
        Label9 = New Label()
        phoneNumberTextBox = New TextBox()
        Label10 = New Label()
        EmailTextBox = New TextBox()
        Label11 = New Label()
        CType(ProfilePicture, ComponentModel.ISupportInitialize).BeginInit()
        CType(CustomerDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ProfilePicture
        ' 
        ProfilePicture.Location = New Point(717, 13)
        ProfilePicture.Name = "ProfilePicture"
        ProfilePicture.Size = New Size(37, 29)
        ProfilePicture.SizeMode = PictureBoxSizeMode.CenterImage
        ProfilePicture.TabIndex = 123
        ProfilePicture.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlDark
        Label4.Location = New Point(227, 23)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 15)
        Label4.TabIndex = 118
        Label4.Text = "Seller"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlDark
        Label3.Location = New Point(279, 23)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 15)
        Label3.TabIndex = 117
        Label3.Text = "Services"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlDark
        Label2.Location = New Point(150, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 15)
        Label2.TabIndex = 116
        Label2.Text = "Customer"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label19.ForeColor = SystemColors.ControlLightLight
        Label19.Location = New Point(66, 753)
        Label19.Name = "Label19"
        Label19.Size = New Size(91, 15)
        Label19.TabIndex = 106
        Label19.Text = "UTMConnect"
        ' 
        ' Label12
        ' 
        Label12.BackColor = SystemColors.ControlDarkDark
        Label12.ForeColor = SystemColors.ControlDarkDark
        Label12.Location = New Point(-6, 55)
        Label12.Name = "Label12"
        Label12.Size = New Size(803, 1)
        Label12.TabIndex = 98
        ' 
        ' HomepageButton
        ' 
        HomepageButton.AutoSize = True
        HomepageButton.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        HomepageButton.ForeColor = SystemColors.ControlLightLight
        HomepageButton.Location = New Point(53, 23)
        HomepageButton.Name = "HomepageButton"
        HomepageButton.Size = New Size(91, 15)
        HomepageButton.TabIndex = 95
        HomepageButton.Text = "UTMConnect"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlDark
        Label1.Location = New Point(349, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 15)
        Label1.TabIndex = 124
        Label1.Text = "Booking"
        ' 
        ' CustomerDataGridView
        ' 
        CustomerDataGridView.BackgroundColor = SystemColors.ControlLightLight
        CustomerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        CustomerDataGridView.Location = New Point(53, 135)
        CustomerDataGridView.Name = "CustomerDataGridView"
        CustomerDataGridView.Size = New Size(664, 267)
        CustomerDataGridView.TabIndex = 125
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(53, 451)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 20)
        Label5.TabIndex = 126
        Label5.Text = "Full Name"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ControlLightLight
        Label6.Location = New Point(53, 537)
        Label6.Name = "Label6"
        Label6.Size = New Size(91, 20)
        Label6.TabIndex = 127
        Label6.Text = "Customer ID"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ControlLightLight
        Label7.Location = New Point(53, 585)
        Label7.Name = "Label7"
        Label7.Size = New Size(58, 20)
        Label7.TabIndex = 128
        Label7.Text = "Role ID"
        ' 
        ' PreviousButton
        ' 
        PreviousButton.AutoSize = True
        PreviousButton.BackColor = Color.Gray
        PreviousButton.FlatStyle = FlatStyle.Popup
        PreviousButton.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PreviousButton.ForeColor = Color.White
        PreviousButton.ImageAlign = ContentAlignment.TopCenter
        PreviousButton.Location = New Point(514, 447)
        PreviousButton.Margin = New Padding(0)
        PreviousButton.Name = "PreviousButton"
        PreviousButton.Size = New Size(92, 34)
        PreviousButton.TabIndex = 129
        PreviousButton.Text = "Previous"
        PreviousButton.UseVisualStyleBackColor = False
        ' 
        ' NextCustomerButton
        ' 
        NextCustomerButton.AutoSize = True
        NextCustomerButton.BackColor = Color.Gray
        NextCustomerButton.FlatStyle = FlatStyle.Popup
        NextCustomerButton.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        NextCustomerButton.ForeColor = Color.White
        NextCustomerButton.ImageAlign = ContentAlignment.TopCenter
        NextCustomerButton.Location = New Point(625, 447)
        NextCustomerButton.Margin = New Padding(0)
        NextCustomerButton.Name = "NextCustomerButton"
        NextCustomerButton.Size = New Size(92, 34)
        NextCustomerButton.TabIndex = 130
        NextCustomerButton.Text = "Next"
        NextCustomerButton.UseVisualStyleBackColor = False
        ' 
        ' AddCustomerButton
        ' 
        AddCustomerButton.AutoSize = True
        AddCustomerButton.BackColor = Color.ForestGreen
        AddCustomerButton.FlatStyle = FlatStyle.Popup
        AddCustomerButton.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddCustomerButton.ForeColor = Color.White
        AddCustomerButton.ImageAlign = ContentAlignment.TopCenter
        AddCustomerButton.Location = New Point(514, 611)
        AddCustomerButton.Margin = New Padding(0)
        AddCustomerButton.Name = "AddCustomerButton"
        AddCustomerButton.Size = New Size(92, 34)
        AddCustomerButton.TabIndex = 131
        AddCustomerButton.Text = "Add"
        AddCustomerButton.UseVisualStyleBackColor = False
        ' 
        ' DeleteCustomerButton
        ' 
        DeleteCustomerButton.AutoSize = True
        DeleteCustomerButton.BackColor = Color.DarkRed
        DeleteCustomerButton.FlatStyle = FlatStyle.Popup
        DeleteCustomerButton.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DeleteCustomerButton.ForeColor = Color.White
        DeleteCustomerButton.ImageAlign = ContentAlignment.TopCenter
        DeleteCustomerButton.Location = New Point(514, 669)
        DeleteCustomerButton.Margin = New Padding(0)
        DeleteCustomerButton.Name = "DeleteCustomerButton"
        DeleteCustomerButton.Size = New Size(203, 34)
        DeleteCustomerButton.TabIndex = 132
        DeleteCustomerButton.Text = "Delete"
        DeleteCustomerButton.UseVisualStyleBackColor = False
        ' 
        ' UpdateButton
        ' 
        UpdateButton.AutoSize = True
        UpdateButton.BackColor = Color.Chocolate
        UpdateButton.FlatStyle = FlatStyle.Popup
        UpdateButton.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UpdateButton.ForeColor = Color.White
        UpdateButton.ImageAlign = ContentAlignment.TopCenter
        UpdateButton.Location = New Point(625, 611)
        UpdateButton.Margin = New Padding(0)
        UpdateButton.Name = "UpdateButton"
        UpdateButton.Size = New Size(92, 34)
        UpdateButton.TabIndex = 133
        UpdateButton.Text = "Update"
        UpdateButton.UseVisualStyleBackColor = False
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label23.ForeColor = SystemColors.ControlDark
        Label23.Location = New Point(410, 753)
        Label23.Name = "Label23"
        Label23.Size = New Size(45, 15)
        Label23.TabIndex = 137
        Label23.Text = "About"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label22.ForeColor = SystemColors.ControlDark
        Label22.Location = New Point(473, 753)
        Label22.Name = "Label22"
        Label22.Size = New Size(99, 15)
        Label22.TabIndex = 136
        Label22.Text = "Privacy Policy"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = SystemColors.ControlDark
        Label21.Location = New Point(578, 753)
        Label21.Name = "Label21"
        Label21.Size = New Size(70, 15)
        Label21.TabIndex = 135
        Label21.Text = "Liscening"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label20.ForeColor = SystemColors.ControlDark
        Label20.Location = New Point(658, 753)
        Label20.Name = "Label20"
        Label20.Size = New Size(59, 15)
        Label20.TabIndex = 134
        Label20.Text = "Contact"
        ' 
        ' CustFullNameTextBox
        ' 
        CustFullNameTextBox.Location = New Point(243, 447)
        CustFullNameTextBox.Name = "CustFullNameTextBox"
        CustFullNameTextBox.Size = New Size(212, 23)
        CustFullNameTextBox.TabIndex = 138
        ' 
        ' CustIDTextBox
        ' 
        CustIDTextBox.Location = New Point(243, 534)
        CustIDTextBox.Name = "CustIDTextBox"
        CustIDTextBox.Size = New Size(212, 23)
        CustIDTextBox.TabIndex = 139
        ' 
        ' RoleIDTextBox
        ' 
        RoleIDTextBox.Location = New Point(243, 582)
        RoleIDTextBox.Name = "RoleIDTextBox"
        RoleIDTextBox.Size = New Size(212, 23)
        RoleIDTextBox.TabIndex = 140
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ControlLightLight
        Label8.Location = New Point(53, 86)
        Label8.Name = "Label8"
        Label8.Size = New Size(192, 30)
        Label8.TabIndex = 141
        Label8.Text = "Manage Customer"
        ' 
        ' UsernameTextBox
        ' 
        UsernameTextBox.Location = New Point(243, 489)
        UsernameTextBox.Name = "UsernameTextBox"
        UsernameTextBox.Size = New Size(212, 23)
        UsernameTextBox.TabIndex = 143
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.ControlLightLight
        Label9.Location = New Point(53, 492)
        Label9.Name = "Label9"
        Label9.Size = New Size(75, 20)
        Label9.TabIndex = 142
        Label9.Text = "Username"
        ' 
        ' phoneNumberTextBox
        ' 
        phoneNumberTextBox.Location = New Point(243, 631)
        phoneNumberTextBox.Name = "phoneNumberTextBox"
        phoneNumberTextBox.Size = New Size(212, 23)
        phoneNumberTextBox.TabIndex = 145
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = SystemColors.ControlLightLight
        Label10.Location = New Point(53, 634)
        Label10.Name = "Label10"
        Label10.Size = New Size(108, 20)
        Label10.TabIndex = 144
        Label10.Text = "Phone Number"
        ' 
        ' EmailTextBox
        ' 
        EmailTextBox.Location = New Point(243, 680)
        EmailTextBox.Name = "EmailTextBox"
        EmailTextBox.Size = New Size(212, 23)
        EmailTextBox.TabIndex = 147
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = SystemColors.ControlLightLight
        Label11.Location = New Point(53, 683)
        Label11.Name = "Label11"
        Label11.Size = New Size(46, 20)
        Label11.TabIndex = 146
        Label11.Text = "Email"
        ' 
        ' ManageCustomer_Admin_
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(800, 795)
        Controls.Add(EmailTextBox)
        Controls.Add(Label11)
        Controls.Add(phoneNumberTextBox)
        Controls.Add(Label10)
        Controls.Add(UsernameTextBox)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(RoleIDTextBox)
        Controls.Add(CustIDTextBox)
        Controls.Add(CustFullNameTextBox)
        Controls.Add(Label23)
        Controls.Add(Label22)
        Controls.Add(Label21)
        Controls.Add(Label20)
        Controls.Add(UpdateButton)
        Controls.Add(DeleteCustomerButton)
        Controls.Add(AddCustomerButton)
        Controls.Add(NextCustomerButton)
        Controls.Add(PreviousButton)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(CustomerDataGridView)
        Controls.Add(Label1)
        Controls.Add(ProfilePicture)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label19)
        Controls.Add(Label12)
        Controls.Add(HomepageButton)
        Name = "ManageCustomer_Admin_"
        Text = "ManageCustomer_Admin_"
        CType(ProfilePicture, ComponentModel.ISupportInitialize).EndInit()
        CType(CustomerDataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProfilePicture As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents HomepageButton As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CustomerDataGridView As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PreviousButton As Button
    Friend WithEvents NextCustomerButton As Button
    Friend WithEvents AddCustomerButton As Button
    Friend WithEvents DeleteCustomerButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents CustFullNameTextBox As TextBox
    Friend WithEvents CustIDTextBox As TextBox
    Friend WithEvents RoleIDTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents phoneNumberTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Label11 As Label
End Class
