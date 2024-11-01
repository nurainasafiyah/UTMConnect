<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        PictureBox1 = New PictureBox()
        SignInLabel2 = New Label()
        Label15 = New Label()
        WelcomePageLabel2 = New Label()
        RegisterButton = New Button()
        ConfirmPasswordTextBox = New TextBox()
        Label14 = New Label()
        PasswordTextBox = New TextBox()
        Label13 = New Label()
        EmailTextBox = New TextBox()
        Label11 = New Label()
        UsernameTextBox = New TextBox()
        Label10 = New Label()
        FullNameTextBox = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label17 = New Label()
        Label12 = New Label()
        Label7 = New Label()
        SignInLabel = New Label()
        JoinUsLabel = New Label()
        WelcomePageLabel = New Label()
        ContactLabel = New Label()
        AboutLabel = New Label()
        AboutLabel2 = New Label()
        Label22 = New Label()
        Label21 = New Label()
        ContactLabel2 = New Label()
        CustomerRoleButton = New Button()
        SellerRoleButton = New Button()
        GroupBox1 = New GroupBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.image_removebg_preview
        PictureBox1.Location = New Point(405, 112)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(373, 503)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 71
        PictureBox1.TabStop = False
        ' 
        ' SignInLabel2
        ' 
        SignInLabel2.AutoSize = True
        SignInLabel2.BackColor = Color.Black
        SignInLabel2.Font = New Font("Calibri", 12F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        SignInLabel2.ForeColor = SystemColors.ControlLightLight
        SignInLabel2.Location = New Point(293, 596)
        SignInLabel2.Name = "SignInLabel2"
        SignInLabel2.Size = New Size(52, 19)
        SignInLabel2.TabIndex = 70
        SignInLabel2.Text = "Sign In"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.Black
        Label15.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = SystemColors.ControlLightLight
        Label15.Location = New Point(119, 596)
        Label15.Name = "Label15"
        Label15.Size = New Size(179, 19)
        Label15.TabIndex = 69
        Label15.Text = "Already have an account ?"
        ' 
        ' WelcomePageLabel2
        ' 
        WelcomePageLabel2.AutoSize = True
        WelcomePageLabel2.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        WelcomePageLabel2.ForeColor = SystemColors.ControlLightLight
        WelcomePageLabel2.Location = New Point(68, 666)
        WelcomePageLabel2.Name = "WelcomePageLabel2"
        WelcomePageLabel2.Size = New Size(91, 15)
        WelcomePageLabel2.TabIndex = 64
        WelcomePageLabel2.Text = "UTMConnect"
        ' 
        ' RegisterButton
        ' 
        RegisterButton.AutoSize = True
        RegisterButton.BackColor = Color.Indigo
        RegisterButton.FlatStyle = FlatStyle.Popup
        RegisterButton.ForeColor = Color.White
        RegisterButton.ImageAlign = ContentAlignment.TopCenter
        RegisterButton.Location = New Point(84, 547)
        RegisterButton.Margin = New Padding(0)
        RegisterButton.Name = "RegisterButton"
        RegisterButton.Size = New Size(295, 34)
        RegisterButton.TabIndex = 63
        RegisterButton.Text = "Register"
        RegisterButton.UseVisualStyleBackColor = False
        ' 
        ' ConfirmPasswordTextBox
        ' 
        ConfirmPasswordTextBox.BackColor = Color.Black
        ConfirmPasswordTextBox.BorderStyle = BorderStyle.FixedSingle
        ConfirmPasswordTextBox.ForeColor = Color.White
        ConfirmPasswordTextBox.Location = New Point(241, 410)
        ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox"
        ConfirmPasswordTextBox.Size = New Size(138, 23)
        ConfirmPasswordTextBox.TabIndex = 62
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Black
        Label14.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = SystemColors.ControlLightLight
        Label14.Location = New Point(238, 381)
        Label14.Name = "Label14"
        Label14.Size = New Size(125, 19)
        Label14.TabIndex = 61
        Label14.Text = "Confirm Password"
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.BackColor = Color.Black
        PasswordTextBox.BorderStyle = BorderStyle.FixedSingle
        PasswordTextBox.ForeColor = Color.White
        PasswordTextBox.Location = New Point(84, 410)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.Size = New Size(138, 23)
        PasswordTextBox.TabIndex = 60
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Black
        Label13.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = SystemColors.ControlLightLight
        Label13.Location = New Point(81, 381)
        Label13.Name = "Label13"
        Label13.Size = New Size(71, 19)
        Label13.TabIndex = 59
        Label13.Text = "Password"
        ' 
        ' EmailTextBox
        ' 
        EmailTextBox.BackColor = Color.Black
        EmailTextBox.BorderStyle = BorderStyle.FixedSingle
        EmailTextBox.ForeColor = Color.White
        EmailTextBox.Location = New Point(81, 330)
        EmailTextBox.Name = "EmailTextBox"
        EmailTextBox.Size = New Size(298, 23)
        EmailTextBox.TabIndex = 58
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Black
        Label11.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = SystemColors.ControlLightLight
        Label11.Location = New Point(78, 301)
        Label11.Name = "Label11"
        Label11.Size = New Size(45, 19)
        Label11.TabIndex = 57
        Label11.Text = "Email"
        ' 
        ' UsernameTextBox
        ' 
        UsernameTextBox.BackColor = Color.Black
        UsernameTextBox.BorderStyle = BorderStyle.FixedSingle
        UsernameTextBox.ForeColor = Color.White
        UsernameTextBox.Location = New Point(81, 251)
        UsernameTextBox.Name = "UsernameTextBox"
        UsernameTextBox.Size = New Size(298, 23)
        UsernameTextBox.TabIndex = 56
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Black
        Label10.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = SystemColors.ControlLightLight
        Label10.Location = New Point(78, 222)
        Label10.Name = "Label10"
        Label10.Size = New Size(75, 19)
        Label10.TabIndex = 55
        Label10.Text = "Username"
        ' 
        ' FullNameTextBox
        ' 
        FullNameTextBox.BackColor = Color.Black
        FullNameTextBox.BorderStyle = BorderStyle.FixedSingle
        FullNameTextBox.ForeColor = Color.White
        FullNameTextBox.Location = New Point(81, 182)
        FullNameTextBox.Name = "FullNameTextBox"
        FullNameTextBox.Size = New Size(298, 23)
        FullNameTextBox.TabIndex = 54
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Black
        Label9.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.ControlLightLight
        Label9.Location = New Point(78, 153)
        Label9.Name = "Label9"
        Label9.Size = New Size(74, 19)
        Label9.TabIndex = 53
        Label9.Text = "Full Name"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Black
        Label8.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ControlLightLight
        Label8.Location = New Point(158, 112)
        Label8.Name = "Label8"
        Label8.Size = New Size(142, 15)
        Label8.TabIndex = 52
        Label8.Text = "Start your journey today."
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = Color.Black
        Label17.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.ForeColor = SystemColors.ControlLightLight
        Label17.Location = New Point(141, 86)
        Label17.Name = "Label17"
        Label17.Size = New Size(170, 26)
        Label17.TabIndex = 51
        Label17.Text = "Create An Account"
        ' 
        ' Label12
        ' 
        Label12.BackColor = SystemColors.ControlDarkDark
        Label12.ForeColor = SystemColors.ControlDarkDark
        Label12.Location = New Point(-1, 53)
        Label12.Name = "Label12"
        Label12.Size = New Size(803, 1)
        Label12.TabIndex = 48
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ControlLightLight
        Label7.Location = New Point(691, 21)
        Label7.Name = "Label7"
        Label7.Size = New Size(12, 15)
        Label7.TabIndex = 47
        Label7.Text = "|"
        ' 
        ' SignInLabel
        ' 
        SignInLabel.AutoSize = True
        SignInLabel.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SignInLabel.ForeColor = SystemColors.ControlLightLight
        SignInLabel.Location = New Point(634, 21)
        SignInLabel.Name = "SignInLabel"
        SignInLabel.Size = New Size(51, 15)
        SignInLabel.TabIndex = 46
        SignInLabel.Text = "Sign In"
        ' 
        ' JoinUsLabel
        ' 
        JoinUsLabel.AutoSize = True
        JoinUsLabel.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        JoinUsLabel.ForeColor = SystemColors.ControlLightLight
        JoinUsLabel.Location = New Point(705, 21)
        JoinUsLabel.Name = "JoinUsLabel"
        JoinUsLabel.Size = New Size(54, 15)
        JoinUsLabel.TabIndex = 45
        JoinUsLabel.Text = "Join Us"
        ' 
        ' WelcomePageLabel
        ' 
        WelcomePageLabel.AutoSize = True
        WelcomePageLabel.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        WelcomePageLabel.ForeColor = SystemColors.ControlLightLight
        WelcomePageLabel.Location = New Point(61, 21)
        WelcomePageLabel.Name = "WelcomePageLabel"
        WelcomePageLabel.Size = New Size(91, 15)
        WelcomePageLabel.TabIndex = 43
        WelcomePageLabel.Text = "UTMConnect"
        ' 
        ' ContactLabel
        ' 
        ContactLabel.AutoSize = True
        ContactLabel.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ContactLabel.ForeColor = SystemColors.ControlDark
        ContactLabel.Location = New Point(209, 21)
        ContactLabel.Name = "ContactLabel"
        ContactLabel.Size = New Size(59, 15)
        ContactLabel.TabIndex = 74
        ContactLabel.Text = "Contact"
        ' 
        ' AboutLabel
        ' 
        AboutLabel.AutoSize = True
        AboutLabel.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AboutLabel.ForeColor = SystemColors.ControlDark
        AboutLabel.Location = New Point(158, 21)
        AboutLabel.Name = "AboutLabel"
        AboutLabel.Size = New Size(45, 15)
        AboutLabel.TabIndex = 73
        AboutLabel.Text = "About"
        ' 
        ' AboutLabel2
        ' 
        AboutLabel2.AutoSize = True
        AboutLabel2.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AboutLabel2.ForeColor = SystemColors.ControlDark
        AboutLabel2.Location = New Point(471, 666)
        AboutLabel2.Name = "AboutLabel2"
        AboutLabel2.Size = New Size(45, 15)
        AboutLabel2.TabIndex = 78
        AboutLabel2.Text = "About"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label22.ForeColor = SystemColors.ControlDark
        Label22.Location = New Point(534, 666)
        Label22.Name = "Label22"
        Label22.Size = New Size(99, 15)
        Label22.TabIndex = 77
        Label22.Text = "Privacy Policy"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = SystemColors.ControlDark
        Label21.Location = New Point(639, 666)
        Label21.Name = "Label21"
        Label21.Size = New Size(70, 15)
        Label21.TabIndex = 76
        Label21.Text = "Liscening"
        ' 
        ' ContactLabel2
        ' 
        ContactLabel2.AutoSize = True
        ContactLabel2.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ContactLabel2.ForeColor = SystemColors.ControlDark
        ContactLabel2.Location = New Point(719, 666)
        ContactLabel2.Name = "ContactLabel2"
        ContactLabel2.Size = New Size(59, 15)
        ContactLabel2.TabIndex = 75
        ContactLabel2.Text = "Contact"
        ' 
        ' CustomerRoleButton
        ' 
        CustomerRoleButton.AutoSize = True
        CustomerRoleButton.BackColor = SystemColors.ControlLightLight
        CustomerRoleButton.FlatStyle = FlatStyle.Popup
        CustomerRoleButton.ForeColor = Color.Black
        CustomerRoleButton.ImageAlign = ContentAlignment.TopCenter
        CustomerRoleButton.Location = New Point(21, 27)
        CustomerRoleButton.Margin = New Padding(0)
        CustomerRoleButton.Name = "CustomerRoleButton"
        CustomerRoleButton.Size = New Size(117, 34)
        CustomerRoleButton.TabIndex = 79
        CustomerRoleButton.Text = "Customer"
        CustomerRoleButton.UseVisualStyleBackColor = False
        ' 
        ' SellerRoleButton
        ' 
        SellerRoleButton.AutoSize = True
        SellerRoleButton.BackColor = SystemColors.ControlLightLight
        SellerRoleButton.FlatStyle = FlatStyle.Popup
        SellerRoleButton.ForeColor = Color.Black
        SellerRoleButton.ImageAlign = ContentAlignment.TopCenter
        SellerRoleButton.Location = New Point(162, 27)
        SellerRoleButton.Margin = New Padding(0)
        SellerRoleButton.Name = "SellerRoleButton"
        SellerRoleButton.Size = New Size(117, 34)
        SellerRoleButton.TabIndex = 80
        SellerRoleButton.Text = "Seller"
        SellerRoleButton.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(SellerRoleButton)
        GroupBox1.Controls.Add(CustomerRoleButton)
        GroupBox1.ForeColor = SystemColors.ControlLightLight
        GroupBox1.Location = New Point(84, 456)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(295, 75)
        GroupBox1.TabIndex = 81
        GroupBox1.TabStop = False
        GroupBox1.Text = "Choose Roles"
        ' 
        ' SignUp
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(811, 727)
        Controls.Add(GroupBox1)
        Controls.Add(AboutLabel2)
        Controls.Add(Label22)
        Controls.Add(Label21)
        Controls.Add(ContactLabel2)
        Controls.Add(ContactLabel)
        Controls.Add(AboutLabel)
        Controls.Add(PictureBox1)
        Controls.Add(SignInLabel2)
        Controls.Add(Label15)
        Controls.Add(WelcomePageLabel2)
        Controls.Add(RegisterButton)
        Controls.Add(ConfirmPasswordTextBox)
        Controls.Add(Label14)
        Controls.Add(PasswordTextBox)
        Controls.Add(Label13)
        Controls.Add(EmailTextBox)
        Controls.Add(Label11)
        Controls.Add(UsernameTextBox)
        Controls.Add(Label10)
        Controls.Add(FullNameTextBox)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label17)
        Controls.Add(Label12)
        Controls.Add(Label7)
        Controls.Add(SignInLabel)
        Controls.Add(JoinUsLabel)
        Controls.Add(WelcomePageLabel)
        MinimizeBox = False
        Name = "SignUp"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sign Up"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SignInLabel2 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents WelcomePageLabel2 As Label
    Friend WithEvents RegisterButton As Button
    Friend WithEvents ConfirmPasswordTextBox As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents FullNameTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents SignInLabel As Label
    Friend WithEvents JoinUsLabel As Label
    Friend WithEvents WelcomePageLabel As Label
    Friend WithEvents ContactLabel As Label
    Friend WithEvents AboutLabel As Label
    Friend WithEvents AboutLabel2 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents ContactLabel2 As Label
    Friend WithEvents CustomerRoleButton As Button
    Friend WithEvents SellerRoleButton As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
