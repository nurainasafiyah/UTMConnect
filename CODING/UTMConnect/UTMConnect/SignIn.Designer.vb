<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignIn
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
        RegisterzButton = New Label()
        Label15 = New Label()
        Label19 = New Label()
        RegisterButton = New Button()
        TextBox1 = New TextBox()
        Label13 = New Label()
        UsernameTextBox = New TextBox()
        Label10 = New Label()
        Label8 = New Label()
        Label17 = New Label()
        Label12 = New Label()
        Label7 = New Label()
        SignInButton = New Label()
        JoinUsButton = New Label()
        HomePageButton = New Label()
        Label9 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label23 = New Label()
        Label22 = New Label()
        Label21 = New Label()
        Label20 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.image_removebg_preview
        PictureBox1.Location = New Point(43, 98)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(373, 419)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 71
        PictureBox1.TabStop = False
        ' 
        ' RegisterzButton
        ' 
        RegisterzButton.AutoSize = True
        RegisterzButton.BackColor = Color.Black
        RegisterzButton.Font = New Font("Calibri", 12F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        RegisterzButton.ForeColor = SystemColors.ControlLightLight
        RegisterzButton.Location = New Point(635, 458)
        RegisterzButton.Name = "RegisterzButton"
        RegisterzButton.Size = New Size(63, 19)
        RegisterzButton.TabIndex = 70
        RegisterzButton.Text = "Register"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.Black
        Label15.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = SystemColors.ControlLightLight
        Label15.Location = New Point(526, 459)
        Label15.Name = "Label15"
        Label15.Size = New Size(112, 19)
        Label15.TabIndex = 69
        Label15.Text = "Not a member ?"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label19.ForeColor = SystemColors.ControlLightLight
        Label19.Location = New Point(68, 586)
        Label19.Name = "Label19"
        Label19.Size = New Size(91, 15)
        Label19.TabIndex = 64
        Label19.Text = "UTMConnect"
        ' 
        ' RegisterButton
        ' 
        RegisterButton.AutoSize = True
        RegisterButton.BackColor = Color.Indigo
        RegisterButton.FlatStyle = FlatStyle.Popup
        RegisterButton.ForeColor = Color.White
        RegisterButton.ImageAlign = ContentAlignment.TopCenter
        RegisterButton.Location = New Point(456, 411)
        RegisterButton.Margin = New Padding(0)
        RegisterButton.Name = "RegisterButton"
        RegisterButton.Size = New Size(295, 34)
        RegisterButton.TabIndex = 63
        RegisterButton.Text = "Sign In"
        RegisterButton.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Black
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.ForeColor = Color.White
        TextBox1.Location = New Point(456, 330)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(295, 23)
        TextBox1.TabIndex = 60
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Black
        Label13.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = SystemColors.ControlLightLight
        Label13.Location = New Point(453, 301)
        Label13.Name = "Label13"
        Label13.Size = New Size(71, 19)
        Label13.TabIndex = 59
        Label13.Text = "Password"
        ' 
        ' UsernameTextBox
        ' 
        UsernameTextBox.BackColor = Color.Black
        UsernameTextBox.BorderStyle = BorderStyle.FixedSingle
        UsernameTextBox.ForeColor = Color.White
        UsernameTextBox.Location = New Point(453, 259)
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
        Label10.Location = New Point(450, 230)
        Label10.Name = "Label10"
        Label10.Size = New Size(75, 19)
        Label10.TabIndex = 55
        Label10.Text = "Username"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Black
        Label8.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ControlLightLight
        Label8.Location = New Point(530, 171)
        Label8.Name = "Label8"
        Label8.Size = New Size(136, 15)
        Label8.TabIndex = 52
        Label8.Text = "Sign In to your account."
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = Color.Black
        Label17.Font = New Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.ForeColor = SystemColors.ControlLightLight
        Label17.Location = New Point(526, 145)
        Label17.Name = "Label17"
        Label17.Size = New Size(144, 26)
        Label17.TabIndex = 51
        Label17.Text = "Welcome Back!"
        ' 
        ' Label12
        ' 
        Label12.BackColor = SystemColors.ControlDarkDark
        Label12.ForeColor = SystemColors.ControlDarkDark
        Label12.Location = New Point(-1, 52)
        Label12.Name = "Label12"
        Label12.Size = New Size(803, 1)
        Label12.TabIndex = 48
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ControlLightLight
        Label7.Location = New Point(691, 20)
        Label7.Name = "Label7"
        Label7.Size = New Size(12, 15)
        Label7.TabIndex = 47
        Label7.Text = "|"
        ' 
        ' SignInButton
        ' 
        SignInButton.AutoSize = True
        SignInButton.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SignInButton.ForeColor = SystemColors.ControlLightLight
        SignInButton.Location = New Point(634, 20)
        SignInButton.Name = "SignInButton"
        SignInButton.Size = New Size(51, 15)
        SignInButton.TabIndex = 46
        SignInButton.Text = "Sign In"
        ' 
        ' JoinUsButton
        ' 
        JoinUsButton.AutoSize = True
        JoinUsButton.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        JoinUsButton.ForeColor = SystemColors.ControlLightLight
        JoinUsButton.Location = New Point(705, 20)
        JoinUsButton.Name = "JoinUsButton"
        JoinUsButton.Size = New Size(54, 15)
        JoinUsButton.TabIndex = 45
        JoinUsButton.Text = "Join Us"
        ' 
        ' HomePageButton
        ' 
        HomePageButton.AutoSize = True
        HomePageButton.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        HomePageButton.ForeColor = SystemColors.ControlLightLight
        HomePageButton.Location = New Point(61, 20)
        HomePageButton.Name = "HomePageButton"
        HomePageButton.Size = New Size(91, 15)
        HomePageButton.TabIndex = 43
        HomePageButton.Text = "UTMConnect"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Black
        Label9.Font = New Font("Calibri", 12F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.ControlLightLight
        Label9.Location = New Point(635, 372)
        Label9.Name = "Label9"
        Label9.Size = New Size(116, 19)
        Label9.TabIndex = 72
        Label9.Text = "Forgot Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlDark
        Label4.Location = New Point(280, 20)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 15)
        Label4.TabIndex = 75
        Label4.Text = "Contact"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlDark
        Label3.Location = New Point(229, 20)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 15)
        Label3.TabIndex = 74
        Label3.Text = "About"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlDark
        Label2.Location = New Point(159, 20)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 15)
        Label2.TabIndex = 73
        Label2.Text = "Services"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label23.ForeColor = SystemColors.ControlDark
        Label23.Location = New Point(457, 586)
        Label23.Name = "Label23"
        Label23.Size = New Size(45, 15)
        Label23.TabIndex = 79
        Label23.Text = "About"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label22.ForeColor = SystemColors.ControlDark
        Label22.Location = New Point(520, 586)
        Label22.Name = "Label22"
        Label22.Size = New Size(99, 15)
        Label22.TabIndex = 78
        Label22.Text = "Privacy Policy"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = SystemColors.ControlDark
        Label21.Location = New Point(625, 586)
        Label21.Name = "Label21"
        Label21.Size = New Size(70, 15)
        Label21.TabIndex = 77
        Label21.Text = "Liscening"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label20.ForeColor = SystemColors.ControlDark
        Label20.Location = New Point(705, 586)
        Label20.Name = "Label20"
        Label20.Size = New Size(59, 15)
        Label20.TabIndex = 76
        Label20.Text = "Contact"
        ' 
        ' SignIn
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(800, 626)
        Controls.Add(Label23)
        Controls.Add(Label22)
        Controls.Add(Label21)
        Controls.Add(Label20)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label9)
        Controls.Add(PictureBox1)
        Controls.Add(RegisterzButton)
        Controls.Add(Label15)
        Controls.Add(Label19)
        Controls.Add(RegisterButton)
        Controls.Add(TextBox1)
        Controls.Add(Label13)
        Controls.Add(UsernameTextBox)
        Controls.Add(Label10)
        Controls.Add(Label8)
        Controls.Add(Label17)
        Controls.Add(Label12)
        Controls.Add(Label7)
        Controls.Add(SignInButton)
        Controls.Add(JoinUsButton)
        Controls.Add(HomePageButton)
        Name = "SignIn"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sign In"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RegisterzButton As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents RegisterButton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents SignInButton As Label
    Friend WithEvents JoinUsButton As Label
    Friend WithEvents HomePageButton As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
End Class
