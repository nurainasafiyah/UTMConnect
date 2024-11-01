<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageSeller_Admin_
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
        Label8 = New Label()
        ServiceIDTextBox = New TextBox()
        SellerIDTextBox = New TextBox()
        SellerUsernameTextBox = New TextBox()
        Label23 = New Label()
        Label22 = New Label()
        Label21 = New Label()
        Label20 = New Label()
        UpdateSellerButton = New Button()
        DeleterSellerButton = New Button()
        AddSellerButton = New Button()
        NextButton = New Button()
        PreviousButton = New Button()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        ProfilePicture = New PictureBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label19 = New Label()
        Label12 = New Label()
        HomepageButton = New Label()
        phoneNumberTextBox = New TextBox()
        Label9 = New Label()
        EmailTextBox = New TextBox()
        Label10 = New Label()
        SellerFullNameTextBox = New TextBox()
        Label11 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ProfilePicture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ControlLightLight
        Label8.Location = New Point(58, 94)
        Label8.Name = "Label8"
        Label8.Size = New Size(152, 30)
        Label8.TabIndex = 166
        Label8.Text = "Manage Seller"
        ' 
        ' ServiceIDTextBox
        ' 
        ServiceIDTextBox.Location = New Point(248, 596)
        ServiceIDTextBox.Name = "ServiceIDTextBox"
        ServiceIDTextBox.Size = New Size(212, 23)
        ServiceIDTextBox.TabIndex = 165
        ' 
        ' SellerIDTextBox
        ' 
        SellerIDTextBox.Location = New Point(248, 548)
        SellerIDTextBox.Name = "SellerIDTextBox"
        SellerIDTextBox.Size = New Size(212, 23)
        SellerIDTextBox.TabIndex = 164
        ' 
        ' SellerUsernameTextBox
        ' 
        SellerUsernameTextBox.Location = New Point(248, 505)
        SellerUsernameTextBox.Name = "SellerUsernameTextBox"
        SellerUsernameTextBox.Size = New Size(212, 23)
        SellerUsernameTextBox.TabIndex = 163
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label23.ForeColor = SystemColors.ControlDark
        Label23.Location = New Point(415, 761)
        Label23.Name = "Label23"
        Label23.Size = New Size(45, 15)
        Label23.TabIndex = 162
        Label23.Text = "About"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label22.ForeColor = SystemColors.ControlDark
        Label22.Location = New Point(478, 761)
        Label22.Name = "Label22"
        Label22.Size = New Size(99, 15)
        Label22.TabIndex = 161
        Label22.Text = "Privacy Policy"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = SystemColors.ControlDark
        Label21.Location = New Point(583, 761)
        Label21.Name = "Label21"
        Label21.Size = New Size(70, 15)
        Label21.TabIndex = 160
        Label21.Text = "Liscening"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label20.ForeColor = SystemColors.ControlDark
        Label20.Location = New Point(663, 761)
        Label20.Name = "Label20"
        Label20.Size = New Size(59, 15)
        Label20.TabIndex = 159
        Label20.Text = "Contact"
        ' 
        ' UpdateSellerButton
        ' 
        UpdateSellerButton.AutoSize = True
        UpdateSellerButton.BackColor = Color.Chocolate
        UpdateSellerButton.FlatStyle = FlatStyle.Popup
        UpdateSellerButton.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UpdateSellerButton.ForeColor = Color.White
        UpdateSellerButton.ImageAlign = ContentAlignment.TopCenter
        UpdateSellerButton.Location = New Point(630, 620)
        UpdateSellerButton.Margin = New Padding(0)
        UpdateSellerButton.Name = "UpdateSellerButton"
        UpdateSellerButton.Size = New Size(92, 34)
        UpdateSellerButton.TabIndex = 158
        UpdateSellerButton.Text = "Update"
        UpdateSellerButton.UseVisualStyleBackColor = False
        ' 
        ' DeleterSellerButton
        ' 
        DeleterSellerButton.AutoSize = True
        DeleterSellerButton.BackColor = Color.DarkRed
        DeleterSellerButton.FlatStyle = FlatStyle.Popup
        DeleterSellerButton.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DeleterSellerButton.ForeColor = Color.White
        DeleterSellerButton.ImageAlign = ContentAlignment.TopCenter
        DeleterSellerButton.Location = New Point(519, 678)
        DeleterSellerButton.Margin = New Padding(0)
        DeleterSellerButton.Name = "DeleterSellerButton"
        DeleterSellerButton.Size = New Size(203, 34)
        DeleterSellerButton.TabIndex = 157
        DeleterSellerButton.Text = "Delete"
        DeleterSellerButton.UseVisualStyleBackColor = False
        ' 
        ' AddSellerButton
        ' 
        AddSellerButton.AutoSize = True
        AddSellerButton.BackColor = Color.ForestGreen
        AddSellerButton.FlatStyle = FlatStyle.Popup
        AddSellerButton.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddSellerButton.ForeColor = Color.White
        AddSellerButton.ImageAlign = ContentAlignment.TopCenter
        AddSellerButton.Location = New Point(519, 620)
        AddSellerButton.Margin = New Padding(0)
        AddSellerButton.Name = "AddSellerButton"
        AddSellerButton.Size = New Size(92, 34)
        AddSellerButton.TabIndex = 156
        AddSellerButton.Text = "Add"
        AddSellerButton.UseVisualStyleBackColor = False
        ' 
        ' NextButton
        ' 
        NextButton.AutoSize = True
        NextButton.BackColor = Color.Gray
        NextButton.FlatStyle = FlatStyle.Popup
        NextButton.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        NextButton.ForeColor = Color.White
        NextButton.ImageAlign = ContentAlignment.TopCenter
        NextButton.Location = New Point(630, 459)
        NextButton.Margin = New Padding(0)
        NextButton.Name = "NextButton"
        NextButton.Size = New Size(92, 34)
        NextButton.TabIndex = 155
        NextButton.Text = "Next"
        NextButton.UseVisualStyleBackColor = False
        ' 
        ' PreviousButton
        ' 
        PreviousButton.AutoSize = True
        PreviousButton.BackColor = Color.Gray
        PreviousButton.FlatStyle = FlatStyle.Popup
        PreviousButton.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PreviousButton.ForeColor = Color.White
        PreviousButton.ImageAlign = ContentAlignment.TopCenter
        PreviousButton.Location = New Point(519, 459)
        PreviousButton.Margin = New Padding(0)
        PreviousButton.Name = "PreviousButton"
        PreviousButton.Size = New Size(92, 34)
        PreviousButton.TabIndex = 154
        PreviousButton.Text = "Previous"
        PreviousButton.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ControlLightLight
        Label7.Location = New Point(58, 599)
        Label7.Name = "Label7"
        Label7.Size = New Size(75, 20)
        Label7.TabIndex = 153
        Label7.Text = "Service ID"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ControlLightLight
        Label6.Location = New Point(58, 551)
        Label6.Name = "Label6"
        Label6.Size = New Size(65, 20)
        Label6.TabIndex = 152
        Label6.Text = "Seller ID"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(58, 509)
        Label5.Name = "Label5"
        Label5.Size = New Size(75, 20)
        Label5.TabIndex = 151
        Label5.Text = "Username"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ControlLightLight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(58, 143)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(664, 267)
        DataGridView1.TabIndex = 150
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlDark
        Label1.Location = New Point(354, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 15)
        Label1.TabIndex = 149
        Label1.Text = "Booking"
        ' 
        ' ProfilePicture
        ' 
        ProfilePicture.Location = New Point(722, 21)
        ProfilePicture.Name = "ProfilePicture"
        ProfilePicture.Size = New Size(37, 29)
        ProfilePicture.SizeMode = PictureBoxSizeMode.CenterImage
        ProfilePicture.TabIndex = 148
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
        Label4.TabIndex = 147
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
        Label3.TabIndex = 146
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
        Label2.TabIndex = 145
        Label2.Text = "Customer"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label19.ForeColor = SystemColors.ControlLightLight
        Label19.Location = New Point(71, 761)
        Label19.Name = "Label19"
        Label19.Size = New Size(91, 15)
        Label19.TabIndex = 144
        Label19.Text = "UTMConnect"
        ' 
        ' Label12
        ' 
        Label12.BackColor = SystemColors.ControlDarkDark
        Label12.ForeColor = SystemColors.ControlDarkDark
        Label12.Location = New Point(-1, 63)
        Label12.Name = "Label12"
        Label12.Size = New Size(803, 1)
        Label12.TabIndex = 143
        ' 
        ' HomepageButton
        ' 
        HomepageButton.AutoSize = True
        HomepageButton.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        HomepageButton.ForeColor = SystemColors.ControlLightLight
        HomepageButton.Location = New Point(58, 31)
        HomepageButton.Name = "HomepageButton"
        HomepageButton.Size = New Size(91, 15)
        HomepageButton.TabIndex = 142
        HomepageButton.Text = "UTMConnect"
        ' 
        ' phoneNumberTextBox
        ' 
        phoneNumberTextBox.Location = New Point(248, 640)
        phoneNumberTextBox.Name = "phoneNumberTextBox"
        phoneNumberTextBox.Size = New Size(212, 23)
        phoneNumberTextBox.TabIndex = 168
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.ControlLightLight
        Label9.Location = New Point(58, 643)
        Label9.Name = "Label9"
        Label9.Size = New Size(108, 20)
        Label9.TabIndex = 167
        Label9.Text = "Phone Number"
        ' 
        ' EmailTextBox
        ' 
        EmailTextBox.Location = New Point(248, 689)
        EmailTextBox.Name = "EmailTextBox"
        EmailTextBox.Size = New Size(212, 23)
        EmailTextBox.TabIndex = 170
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = SystemColors.ControlLightLight
        Label10.Location = New Point(58, 692)
        Label10.Name = "Label10"
        Label10.Size = New Size(46, 20)
        Label10.TabIndex = 169
        Label10.Text = "Email"
        ' 
        ' SellerFullNameTextBox
        ' 
        SellerFullNameTextBox.Location = New Point(248, 459)
        SellerFullNameTextBox.Name = "SellerFullNameTextBox"
        SellerFullNameTextBox.Size = New Size(212, 23)
        SellerFullNameTextBox.TabIndex = 172
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = SystemColors.ControlLightLight
        Label11.Location = New Point(58, 463)
        Label11.Name = "Label11"
        Label11.Size = New Size(69, 20)
        Label11.TabIndex = 171
        Label11.Text = "Fullname"
        ' 
        ' ManageSeller_Admin_
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(800, 802)
        Controls.Add(SellerFullNameTextBox)
        Controls.Add(Label11)
        Controls.Add(EmailTextBox)
        Controls.Add(Label10)
        Controls.Add(phoneNumberTextBox)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(ServiceIDTextBox)
        Controls.Add(SellerIDTextBox)
        Controls.Add(SellerUsernameTextBox)
        Controls.Add(Label23)
        Controls.Add(Label22)
        Controls.Add(Label21)
        Controls.Add(Label20)
        Controls.Add(UpdateSellerButton)
        Controls.Add(DeleterSellerButton)
        Controls.Add(AddSellerButton)
        Controls.Add(NextButton)
        Controls.Add(PreviousButton)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Controls.Add(ProfilePicture)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label19)
        Controls.Add(Label12)
        Controls.Add(HomepageButton)
        Name = "ManageSeller_Admin_"
        Text = "ManageSeller_Admin_"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(ProfilePicture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents ServiceIDTextBox As TextBox
    Friend WithEvents SellerIDTextBox As TextBox
    Friend WithEvents SellerUsernameTextBox As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents UpdateSellerButton As Button
    Friend WithEvents DeleterSellerButton As Button
    Friend WithEvents AddSellerButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents PreviousButton As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ProfilePicture As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents HomepageButton As Label
    Friend WithEvents phoneNumberTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents SellerFullNameTextBox As TextBox
    Friend WithEvents Label11 As Label
End Class
