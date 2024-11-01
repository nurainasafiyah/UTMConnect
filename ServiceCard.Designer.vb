<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServiceCard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ServiceCard))
        ServicePictureBox = New PictureBox()
        ServiceNameLabel = New Label()
        ServiceDescriptionLabel = New Label()
        ServicePriceLabel = New Label()
        UsernameLabel = New Label()
        Label1 = New Label()
        CType(ServicePictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ServicePictureBox
        ' 
        ServicePictureBox.Image = CType(resources.GetObject("ServicePictureBox.Image"), Image)
        ServicePictureBox.Location = New Point(19, 34)
        ServicePictureBox.Name = "ServicePictureBox"
        ServicePictureBox.Size = New Size(233, 135)
        ServicePictureBox.SizeMode = PictureBoxSizeMode.CenterImage
        ServicePictureBox.TabIndex = 0
        ServicePictureBox.TabStop = False
        ' 
        ' ServiceNameLabel
        ' 
        ServiceNameLabel.Location = New Point(19, 188)
        ServiceNameLabel.Name = "ServiceNameLabel"
        ServiceNameLabel.Size = New Size(233, 21)
        ServiceNameLabel.TabIndex = 1
        ServiceNameLabel.Text = "Service Name"
        ' 
        ' ServiceDescriptionLabel
        ' 
        ServiceDescriptionLabel.Location = New Point(19, 253)
        ServiceDescriptionLabel.Name = "ServiceDescriptionLabel"
        ServiceDescriptionLabel.Size = New Size(233, 91)
        ServiceDescriptionLabel.TabIndex = 2
        ServiceDescriptionLabel.Text = "Description"
        ' 
        ' ServicePriceLabel
        ' 
        ServicePriceLabel.Location = New Point(153, 229)
        ServicePriceLabel.Name = "ServicePriceLabel"
        ServicePriceLabel.Size = New Size(99, 24)
        ServicePriceLabel.TabIndex = 3
        ServiceDescriptionLabel.Text = "ServicePriceLabel"
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.Location = New Point(19, 218)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(233, 21)
        UsernameLabel.TabIndex = 4
        UsernameLabel.Text = "Seller Name"
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(20, 219)
        Label1.Name = "Label1"
        Label1.Size = New Size(233, 21)
        Label1.TabIndex = 5
        Label1.Text = "Seller Name"
        ' 
        ' ServiceCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Label1)
        Controls.Add(UsernameLabel)
        Controls.Add(ServicePriceLabel)
        Controls.Add(ServiceDescriptionLabel)
        Controls.Add(ServiceNameLabel)
        Controls.Add(ServicePictureBox)
        Name = "ServiceCard"
        Size = New Size(272, 458)
        CType(ServicePictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Public WithEvents ServicePictureBox As PictureBox
    Public WithEvents ServiceNameLabel As Label
    Public WithEvents ServiceDescriptionLabel As Label
    Public WithEvents ServicePriceLabel As Label
    Public WithEvents UsernameLabel As Label
    Public WithEvents Label1 As Label

End Class
