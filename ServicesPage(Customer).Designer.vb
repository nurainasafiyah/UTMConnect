<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServicesPage_Customer_
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
        AboutLabel = New Label()
        ServicesLabel = New Label()
        Label12 = New Label()
        WelcomePageLabel = New Label()
        ServiceList = New FlowLayoutPanel()
        Label23 = New Label()
        Label22 = New Label()
        Label21 = New Label()
        Label20 = New Label()
        Label19 = New Label()
        CType(ProfilePicture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ProfilePicture
        ' 
        ProfilePicture.Location = New Point(722, 13)
        ProfilePicture.Name = "ProfilePicture"
        ProfilePicture.Size = New Size(37, 29)
        ProfilePicture.SizeMode = PictureBoxSizeMode.CenterImage
        ProfilePicture.TabIndex = 100
        ProfilePicture.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlDark
        Label4.Location = New Point(276, 23)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 15)
        Label4.TabIndex = 99
        Label4.Text = "Contact"
        ' 
        ' AboutLabel
        ' 
        AboutLabel.AutoSize = True
        AboutLabel.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AboutLabel.ForeColor = SystemColors.ControlDark
        AboutLabel.Location = New Point(225, 23)
        AboutLabel.Name = "AboutLabel"
        AboutLabel.Size = New Size(45, 15)
        AboutLabel.TabIndex = 98
        AboutLabel.Text = "About"
        ' 
        ' ServicesLabel
        ' 
        ServicesLabel.AutoSize = True
        ServicesLabel.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ServicesLabel.ForeColor = SystemColors.ControlDark
        ServicesLabel.Location = New Point(155, 23)
        ServicesLabel.Name = "ServicesLabel"
        ServicesLabel.Size = New Size(64, 15)
        ServicesLabel.TabIndex = 97
        ServicesLabel.Text = "Services"
        ' 
        ' Label12
        ' 
        Label12.BackColor = SystemColors.ControlDarkDark
        Label12.ForeColor = SystemColors.ControlDarkDark
        Label12.Location = New Point(-1, 55)
        Label12.Name = "Label12"
        Label12.Size = New Size(803, 1)
        Label12.TabIndex = 96
        ' 
        ' WelcomePageLabel
        ' 
        WelcomePageLabel.AutoSize = True
        WelcomePageLabel.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        WelcomePageLabel.ForeColor = SystemColors.ControlLightLight
        WelcomePageLabel.Location = New Point(58, 23)
        WelcomePageLabel.Name = "WelcomePageLabel"
        WelcomePageLabel.Size = New Size(91, 15)
        WelcomePageLabel.TabIndex = 95
        WelcomePageLabel.Text = "UTMConnect"
        ' 
        ' ServiceList
        ' 
        ServiceList.AutoScroll = True
        ServiceList.Location = New Point(70, 173)
        ServiceList.Name = "ServiceList"
        ServiceList.Size = New Size(625, 462)
        ServiceList.TabIndex = 101
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label23.ForeColor = SystemColors.ControlDark
        Label23.Location = New Point(435, 737)
        Label23.Name = "Label23"
        Label23.Size = New Size(45, 15)
        Label23.TabIndex = 106
        Label23.Text = "About"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label22.ForeColor = SystemColors.ControlDark
        Label22.Location = New Point(498, 737)
        Label22.Name = "Label22"
        Label22.Size = New Size(99, 15)
        Label22.TabIndex = 105
        Label22.Text = "Privacy Policy"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = SystemColors.ControlDark
        Label21.Location = New Point(603, 737)
        Label21.Name = "Label21"
        Label21.Size = New Size(70, 15)
        Label21.TabIndex = 104
        Label21.Text = "Liscening"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label20.ForeColor = SystemColors.ControlDark
        Label20.Location = New Point(683, 737)
        Label20.Name = "Label20"
        Label20.Size = New Size(59, 15)
        Label20.TabIndex = 103
        Label20.Text = "Contact"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label19.ForeColor = SystemColors.ControlLightLight
        Label19.Location = New Point(59, 737)
        Label19.Name = "Label19"
        Label19.Size = New Size(91, 15)
        Label19.TabIndex = 102
        Label19.Text = "UTMConnect"
        ' 
        ' ServicesPage_Customer_
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(800, 789)
        Controls.Add(Label23)
        Controls.Add(Label22)
        Controls.Add(Label21)
        Controls.Add(Label20)
        Controls.Add(Label19)
        Controls.Add(ServiceList)
        Controls.Add(ProfilePicture)
        Controls.Add(Label4)
        Controls.Add(AboutLabel)
        Controls.Add(ServicesLabel)
        Controls.Add(Label12)
        Controls.Add(WelcomePageLabel)
        Name = "ServicesPage_Customer_"
        Text = "ServicesPage_Customer_"
        CType(ProfilePicture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProfilePicture As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents AboutLabel As Label
    Friend WithEvents ServicesLabel As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents WelcomePageLabel As Label
    Friend WithEvents ServiceList As FlowLayoutPanel
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
End Class
