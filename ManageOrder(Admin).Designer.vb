<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageOrder_Admin_
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
        CustIDTextBox = New TextBox()
        Label23 = New Label()
        Label22 = New Label()
        Label21 = New Label()
        Label20 = New Label()
        UpdateOrderButton = New Button()
        DeleteOrderButton = New Button()
        AddOrderButton = New Button()
        NextOrderButton = New Button()
        PreviousOrderButton = New Button()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        OrderDataGridView = New DataGridView()
        Label1 = New Label()
        ProfilePicture = New PictureBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label19 = New Label()
        Label12 = New Label()
        HomepageButton = New Label()
        OrderIDTextBox = New TextBox()
        Label9 = New Label()
        Label10 = New Label()
        QuantityTextBox = New TextBox()
        Label11 = New Label()
        TotalPriceTextBox = New TextBox()
        Label13 = New Label()
        OrderStatusTextBox = New TextBox()
        Label14 = New Label()
        OrderDateTimePicker = New DateTimePicker()
        CType(OrderDataGridView, ComponentModel.ISupportInitialize).BeginInit()
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
        Label8.Size = New Size(163, 30)
        Label8.TabIndex = 216
        Label8.Text = "Manage Orders"
        ' 
        ' ServiceIDTextBox
        ' 
        ServiceIDTextBox.Location = New Point(248, 552)
        ServiceIDTextBox.Name = "ServiceIDTextBox"
        ServiceIDTextBox.Size = New Size(212, 23)
        ServiceIDTextBox.TabIndex = 215
        ' 
        ' SellerIDTextBox
        ' 
        SellerIDTextBox.Location = New Point(248, 504)
        SellerIDTextBox.Name = "SellerIDTextBox"
        SellerIDTextBox.Size = New Size(212, 23)
        SellerIDTextBox.TabIndex = 214
        ' 
        ' CustIDTextBox
        ' 
        CustIDTextBox.Location = New Point(248, 596)
        CustIDTextBox.Name = "CustIDTextBox"
        CustIDTextBox.Size = New Size(212, 23)
        CustIDTextBox.TabIndex = 213
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label23.ForeColor = SystemColors.ControlDark
        Label23.Location = New Point(415, 839)
        Label23.Name = "Label23"
        Label23.Size = New Size(45, 15)
        Label23.TabIndex = 212
        Label23.Text = "About"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label22.ForeColor = SystemColors.ControlDark
        Label22.Location = New Point(478, 839)
        Label22.Name = "Label22"
        Label22.Size = New Size(99, 15)
        Label22.TabIndex = 211
        Label22.Text = "Privacy Policy"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = SystemColors.ControlDark
        Label21.Location = New Point(583, 839)
        Label21.Name = "Label21"
        Label21.Size = New Size(70, 15)
        Label21.TabIndex = 210
        Label21.Text = "Liscening"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label20.ForeColor = SystemColors.ControlDark
        Label20.Location = New Point(663, 839)
        Label20.Name = "Label20"
        Label20.Size = New Size(59, 15)
        Label20.TabIndex = 209
        Label20.Text = "Contact"
        ' 
        ' UpdateOrderButton
        ' 
        UpdateOrderButton.AutoSize = True
        UpdateOrderButton.BackColor = Color.Chocolate
        UpdateOrderButton.FlatStyle = FlatStyle.Popup
        UpdateOrderButton.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UpdateOrderButton.ForeColor = Color.White
        UpdateOrderButton.ImageAlign = ContentAlignment.TopCenter
        UpdateOrderButton.Location = New Point(630, 711)
        UpdateOrderButton.Margin = New Padding(0)
        UpdateOrderButton.Name = "UpdateOrderButton"
        UpdateOrderButton.Size = New Size(92, 34)
        UpdateOrderButton.TabIndex = 208
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
        DeleteOrderButton.Location = New Point(519, 769)
        DeleteOrderButton.Margin = New Padding(0)
        DeleteOrderButton.Name = "DeleteOrderButton"
        DeleteOrderButton.Size = New Size(203, 34)
        DeleteOrderButton.TabIndex = 207
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
        AddOrderButton.Location = New Point(519, 711)
        AddOrderButton.Margin = New Padding(0)
        AddOrderButton.Name = "AddOrderButton"
        AddOrderButton.Size = New Size(92, 34)
        AddOrderButton.TabIndex = 206
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
        NextOrderButton.Location = New Point(630, 453)
        NextOrderButton.Margin = New Padding(0)
        NextOrderButton.Name = "NextOrderButton"
        NextOrderButton.Size = New Size(92, 34)
        NextOrderButton.TabIndex = 205
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
        PreviousOrderButton.Location = New Point(519, 453)
        PreviousOrderButton.Margin = New Padding(0)
        PreviousOrderButton.Name = "PreviousOrderButton"
        PreviousOrderButton.Size = New Size(92, 34)
        PreviousOrderButton.TabIndex = 204
        PreviousOrderButton.Text = "Previous"
        PreviousOrderButton.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ControlLightLight
        Label7.Location = New Point(58, 555)
        Label7.Name = "Label7"
        Label7.Size = New Size(75, 20)
        Label7.TabIndex = 203
        Label7.Text = "Service ID"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ControlLightLight
        Label6.Location = New Point(58, 507)
        Label6.Name = "Label6"
        Label6.Size = New Size(65, 20)
        Label6.TabIndex = 202
        Label6.Text = "Seller ID"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(58, 599)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 20)
        Label5.TabIndex = 201
        Label5.Text = "Customer ID"
        ' 
        ' OrderDataGridView
        ' 
        OrderDataGridView.BackgroundColor = SystemColors.ControlLightLight
        OrderDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        OrderDataGridView.Location = New Point(58, 143)
        OrderDataGridView.Name = "OrderDataGridView"
        OrderDataGridView.Size = New Size(664, 267)
        OrderDataGridView.TabIndex = 200
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlDark
        Label1.Location = New Point(354, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 15)
        Label1.TabIndex = 199
        Label1.Text = "Booking"
        ' 
        ' ProfilePicture
        ' 
        ProfilePicture.Location = New Point(722, 21)
        ProfilePicture.Name = "ProfilePicture"
        ProfilePicture.Size = New Size(37, 29)
        ProfilePicture.SizeMode = PictureBoxSizeMode.CenterImage
        ProfilePicture.TabIndex = 198
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
        Label4.TabIndex = 197
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
        Label3.TabIndex = 196
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
        Label2.TabIndex = 195
        Label2.Text = "Customer"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label19.ForeColor = SystemColors.ControlLightLight
        Label19.Location = New Point(71, 839)
        Label19.Name = "Label19"
        Label19.Size = New Size(91, 15)
        Label19.TabIndex = 194
        Label19.Text = "UTMConnect"
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
        ' OrderIDTextBox
        ' 
        OrderIDTextBox.Location = New Point(248, 461)
        OrderIDTextBox.Name = "OrderIDTextBox"
        OrderIDTextBox.Size = New Size(212, 23)
        OrderIDTextBox.TabIndex = 218
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.ControlLightLight
        Label9.Location = New Point(58, 464)
        Label9.Name = "Label9"
        Label9.Size = New Size(66, 20)
        Label9.TabIndex = 217
        Label9.Text = "Order ID"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = SystemColors.ControlLightLight
        Label10.Location = New Point(58, 783)
        Label10.Name = "Label10"
        Label10.Size = New Size(103, 20)
        Label10.TabIndex = 219
        Label10.Text = "Order Created"
        ' 
        ' QuantityTextBox
        ' 
        QuantityTextBox.Location = New Point(248, 645)
        QuantityTextBox.Name = "QuantityTextBox"
        QuantityTextBox.Size = New Size(212, 23)
        QuantityTextBox.TabIndex = 222
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = SystemColors.ControlLightLight
        Label11.Location = New Point(58, 648)
        Label11.Name = "Label11"
        Label11.Size = New Size(65, 20)
        Label11.TabIndex = 221
        Label11.Text = "Quantity"
        ' 
        ' TotalPriceTextBox
        ' 
        TotalPriceTextBox.Location = New Point(248, 689)
        TotalPriceTextBox.Name = "TotalPriceTextBox"
        TotalPriceTextBox.Size = New Size(212, 23)
        TotalPriceTextBox.TabIndex = 224
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = SystemColors.ControlLightLight
        Label13.Location = New Point(58, 692)
        Label13.Name = "Label13"
        Label13.Size = New Size(78, 20)
        Label13.TabIndex = 223
        Label13.Text = "Total Price"
        ' 
        ' OrderStatusTextBox
        ' 
        OrderStatusTextBox.Location = New Point(248, 735)
        OrderStatusTextBox.Name = "OrderStatusTextBox"
        OrderStatusTextBox.Size = New Size(212, 23)
        OrderStatusTextBox.TabIndex = 226
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = SystemColors.ControlLightLight
        Label14.Location = New Point(58, 738)
        Label14.Name = "Label14"
        Label14.Size = New Size(91, 20)
        Label14.TabIndex = 225
        Label14.Text = "Order Status"
        ' 
        ' OrderDateTimePicker
        ' 
        OrderDateTimePicker.Location = New Point(248, 783)
        OrderDateTimePicker.Name = "OrderDateTimePicker"
        OrderDateTimePicker.Size = New Size(212, 23)
        OrderDateTimePicker.TabIndex = 227
        ' 
        ' ManageOrder_Admin_
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(800, 876)
        Controls.Add(OrderDateTimePicker)
        Controls.Add(OrderStatusTextBox)
        Controls.Add(Label14)
        Controls.Add(TotalPriceTextBox)
        Controls.Add(Label13)
        Controls.Add(QuantityTextBox)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(OrderIDTextBox)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(ServiceIDTextBox)
        Controls.Add(SellerIDTextBox)
        Controls.Add(CustIDTextBox)
        Controls.Add(Label23)
        Controls.Add(Label22)
        Controls.Add(Label21)
        Controls.Add(Label20)
        Controls.Add(UpdateOrderButton)
        Controls.Add(DeleteOrderButton)
        Controls.Add(AddOrderButton)
        Controls.Add(NextOrderButton)
        Controls.Add(PreviousOrderButton)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(OrderDataGridView)
        Controls.Add(Label1)
        Controls.Add(ProfilePicture)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label19)
        Controls.Add(Label12)
        Controls.Add(HomepageButton)
        Name = "ManageOrder_Admin_"
        Text = "ManageOrder_Admin_"
        CType(OrderDataGridView, ComponentModel.ISupportInitialize).EndInit()
        CType(ProfilePicture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents ServiceIDTextBox As TextBox
    Friend WithEvents SellerIDTextBox As TextBox
    Friend WithEvents CustIDTextBox As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents UpdateOrderButton As Button
    Friend WithEvents DeleteOrderButton As Button
    Friend WithEvents AddOrderButton As Button
    Friend WithEvents NextOrderButton As Button
    Friend WithEvents PreviousOrderButton As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents OrderDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ProfilePicture As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents HomepageButton As Label
    Friend WithEvents OrderIDTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TotalPriceTextBox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents OrderStatusTextBox As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents OrderDateTimePicker As DateTimePicker
End Class
