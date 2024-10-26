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
        ServicePictureBox = New PictureBox()
        ServiceNameLabel = New Label()
        ServiceDescriptionLabel = New Label()
        ServicePriceLabel = New Label()
        CType(ServicePictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ServicePictureBox
        ' 
        ServicePictureBox.Location = New Point(19, 24)
        ServicePictureBox.Name = "ServicePictureBox"
        ServicePictureBox.Size = New Size(233, 100)
        ServicePictureBox.TabIndex = 0
        ServicePictureBox.TabStop = False
        ' 
        ' ServiceNameLabel
        ' 
        ServiceNameLabel.AutoSize = True
        ServiceNameLabel.Location = New Point(19, 147)
        ServiceNameLabel.Name = "ServiceNameLabel"
        ServiceNameLabel.Size = New Size(41, 15)
        ServiceNameLabel.TabIndex = 1
        ServiceNameLabel.Text = "Label1"
        ' 
        ' ServiceDescriptionLabel
        ' 
        ServiceDescriptionLabel.AutoSize = True
        ServiceDescriptionLabel.Location = New Point(19, 178)
        ServiceDescriptionLabel.Name = "ServiceDescriptionLabel"
        ServiceDescriptionLabel.Size = New Size(41, 15)
        ServiceDescriptionLabel.TabIndex = 2
        ServiceDescriptionLabel.Text = "Label2"
        ' 
        ' ServicePriceLabel
        ' 
        ServicePriceLabel.AutoSize = True
        ServicePriceLabel.Location = New Point(211, 229)
        ServicePriceLabel.Name = "ServicePriceLabel"
        ServicePriceLabel.Size = New Size(41, 15)
        ServicePriceLabel.TabIndex = 3
        ServicePriceLabel.Text = "Label3"
        ' 
        ' ServiceCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(ServicePriceLabel)
        Controls.Add(ServiceDescriptionLabel)
        Controls.Add(ServiceNameLabel)
        Controls.Add(ServicePictureBox)
        Name = "ServiceCard"
        Size = New Size(272, 267)
        CType(ServicePictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Public WithEvents ServicePictureBox As PictureBox
    Public WithEvents ServiceNameLabel As Label
    Public WithEvents ServiceDescriptionLabel As Label
    Public WithEvents ServicePriceLabel As Label

End Class
