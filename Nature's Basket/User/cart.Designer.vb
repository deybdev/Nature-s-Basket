<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cart))
        Panel1 = New Panel()
        LinkLabel1 = New LinkLabel()
        Label2 = New Label()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        searchBox = New TextBox()
        Panel2 = New Panel()
        menuPanel = New Panel()
        logoutLink = New LinkLabel()
        myPurchaseLink = New LinkLabel()
        seafoodsLink = New LinkLabel()
        herbsLink = New LinkLabel()
        meatsLink = New LinkLabel()
        eggsLink = New LinkLabel()
        fruitsLink = New LinkLabel()
        vegetablesLink = New LinkLabel()
        Label4 = New Label()
        Label7 = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Panel3 = New Panel()
        Panel6 = New Panel()
        Label1 = New Label()
        Label10 = New Label()
        Button5 = New Button()
        Button6 = New Button()
        Label9 = New Label()
        Label8 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        Button4 = New Button()
        CheckBox1 = New CheckBox()
        Label3 = New Label()
        Label37 = New Label()
        Panel13 = New Panel()
        checkOutBtn = New Button()
        Label28 = New Label()
        Label27 = New Label()
        Button13 = New Button()
        Label26 = New Label()
        selectAll = New CheckBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        menuPanel.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel6.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel13.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.ForestGreen
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(searchBox)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1286, 100)
        Panel1.TabIndex = 1
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LinkLabel1.ForeColor = SystemColors.Control
        LinkLabel1.LinkBehavior = LinkBehavior.NeverUnderline
        LinkLabel1.LinkColor = Color.White
        LinkLabel1.Location = New Point(866, 40)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(55, 21)
        LinkLabel1.TabIndex = 16
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Home"
        ' 
        ' Label2
        ' 
        Label2.AutoEllipsis = True
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.Control
        Label2.Image = CType(resources.GetObject("Label2.Image"), Image)
        Label2.ImageAlign = ContentAlignment.MiddleLeft
        Label2.Location = New Point(51, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(200, 30)
        Label2.TabIndex = 7
        Label2.Text = "      Nature's Basket"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.Cursor = Cursors.Hand
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = Color.Transparent
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.Location = New Point(1229, 37)
        Button3.Name = "Button3"
        Button3.Size = New Size(24, 25)
        Button3.TabIndex = 14
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.Transparent
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.Location = New Point(1190, 37)
        Button2.Name = "Button2"
        Button2.Size = New Size(24, 25)
        Button2.TabIndex = 13
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.Transparent
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(975, 37)
        Button1.Name = "Button1"
        Button1.Size = New Size(24, 25)
        Button1.TabIndex = 12
        Button1.UseVisualStyleBackColor = False
        ' 
        ' searchBox
        ' 
        searchBox.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchBox.Location = New Point(1007, 37)
        searchBox.Name = "searchBox"
        searchBox.Size = New Size(167, 25)
        searchBox.TabIndex = 11
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(menuPanel)
        Panel2.Controls.Add(FlowLayoutPanel1)
        Panel2.Controls.Add(Label37)
        Panel2.Controls.Add(Panel13)
        Panel2.Location = New Point(-1, 100)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1286, 568)
        Panel2.TabIndex = 2
        ' 
        ' menuPanel
        ' 
        menuPanel.BackColor = SystemColors.Control
        menuPanel.Controls.Add(logoutLink)
        menuPanel.Controls.Add(myPurchaseLink)
        menuPanel.Controls.Add(seafoodsLink)
        menuPanel.Controls.Add(herbsLink)
        menuPanel.Controls.Add(meatsLink)
        menuPanel.Controls.Add(eggsLink)
        menuPanel.Controls.Add(fruitsLink)
        menuPanel.Controls.Add(vegetablesLink)
        menuPanel.Controls.Add(Label4)
        menuPanel.Controls.Add(Label7)
        menuPanel.Location = New Point(1085, -2)
        menuPanel.Name = "menuPanel"
        menuPanel.Size = New Size(200, 483)
        menuPanel.TabIndex = 25
        menuPanel.Visible = False
        ' 
        ' logoutLink
        ' 
        logoutLink.AutoSize = True
        logoutLink.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        logoutLink.ForeColor = Color.Red
        logoutLink.LinkBehavior = LinkBehavior.NeverUnderline
        logoutLink.LinkColor = Color.Red
        logoutLink.Location = New Point(70, 435)
        logoutLink.Name = "logoutLink"
        logoutLink.Size = New Size(73, 21)
        logoutLink.TabIndex = 19
        logoutLink.TabStop = True
        logoutLink.Text = "LOGOUT"
        ' 
        ' myPurchaseLink
        ' 
        myPurchaseLink.AutoSize = True
        myPurchaseLink.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        myPurchaseLink.LinkBehavior = LinkBehavior.NeverUnderline
        myPurchaseLink.LinkColor = Color.DarkBlue
        myPurchaseLink.Location = New Point(45, 403)
        myPurchaseLink.Name = "myPurchaseLink"
        myPurchaseLink.Size = New Size(118, 21)
        myPurchaseLink.TabIndex = 18
        myPurchaseLink.TabStop = True
        myPurchaseLink.Text = "MY PURCHASE"
        ' 
        ' seafoodsLink
        ' 
        seafoodsLink.AutoSize = True
        seafoodsLink.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        seafoodsLink.LinkColor = Color.Black
        seafoodsLink.Location = New Point(70, 298)
        seafoodsLink.Name = "seafoodsLink"
        seafoodsLink.Size = New Size(79, 21)
        seafoodsLink.TabIndex = 17
        seafoodsLink.TabStop = True
        seafoodsLink.Text = "Seafoods"
        ' 
        ' herbsLink
        ' 
        herbsLink.AutoSize = True
        herbsLink.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        herbsLink.LinkColor = Color.Black
        herbsLink.Location = New Point(79, 260)
        herbsLink.Name = "herbsLink"
        herbsLink.Size = New Size(54, 21)
        herbsLink.TabIndex = 16
        herbsLink.TabStop = True
        herbsLink.Text = "Herbs"
        ' 
        ' meatsLink
        ' 
        meatsLink.AutoSize = True
        meatsLink.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        meatsLink.LinkColor = Color.Black
        meatsLink.Location = New Point(78, 218)
        meatsLink.Name = "meatsLink"
        meatsLink.Size = New Size(55, 21)
        meatsLink.TabIndex = 15
        meatsLink.TabStop = True
        meatsLink.Text = "Meats"
        ' 
        ' eggsLink
        ' 
        eggsLink.AutoSize = True
        eggsLink.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        eggsLink.LinkColor = Color.Black
        eggsLink.Location = New Point(81, 180)
        eggsLink.Name = "eggsLink"
        eggsLink.Size = New Size(45, 21)
        eggsLink.TabIndex = 14
        eggsLink.TabStop = True
        eggsLink.Text = "Eggs"
        ' 
        ' fruitsLink
        ' 
        fruitsLink.AutoSize = True
        fruitsLink.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        fruitsLink.LinkColor = Color.Black
        fruitsLink.Location = New Point(79, 140)
        fruitsLink.Name = "fruitsLink"
        fruitsLink.Size = New Size(50, 21)
        fruitsLink.TabIndex = 13
        fruitsLink.TabStop = True
        fruitsLink.Text = "Fruits"
        ' 
        ' vegetablesLink
        ' 
        vegetablesLink.AutoSize = True
        vegetablesLink.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        vegetablesLink.LinkColor = Color.Black
        vegetablesLink.Location = New Point(64, 102)
        vegetablesLink.Name = "vegetablesLink"
        vegetablesLink.Size = New Size(91, 21)
        vegetablesLink.TabIndex = 12
        vegetablesLink.TabStop = True
        vegetablesLink.Text = "Vegetables"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(49, 28)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 25)
        Label4.TabIndex = 11
        Label4.Text = "AVAILABLE"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(242, -93)
        Label7.Name = "Label7"
        Label7.Size = New Size(64, 15)
        Label7.TabIndex = 10
        Label7.Text = "AVAILABLE"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = Color.LimeGreen
        FlowLayoutPanel1.Controls.Add(Panel3)
        FlowLayoutPanel1.Location = New Point(149, 56)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(944, 388)
        FlowLayoutPanel1.TabIndex = 24
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.ForestGreen
        Panel3.Controls.Add(Panel6)
        Panel3.Location = New Point(3, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(936, 106)
        Panel3.TabIndex = 0
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.White
        Panel6.Controls.Add(Label1)
        Panel6.Controls.Add(Label10)
        Panel6.Controls.Add(Button5)
        Panel6.Controls.Add(Button6)
        Panel6.Controls.Add(Label9)
        Panel6.Controls.Add(Label8)
        Panel6.Controls.Add(Label6)
        Panel6.Controls.Add(Label5)
        Panel6.Controls.Add(PictureBox1)
        Panel6.Controls.Add(Button4)
        Panel6.Controls.Add(CheckBox1)
        Panel6.Controls.Add(Label3)
        Panel6.Location = New Point(13, 13)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(911, 83)
        Panel6.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(596, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(15, 17)
        Label1.TabIndex = 1
        Label1.Text = "0"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.White
        Label10.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(751, 9)
        Label10.Name = "Label10"
        Label10.Size = New Size(37, 17)
        Label10.TabIndex = 23
        Label10.Text = "Total"
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.PaleGreen
        Button5.Cursor = Cursors.Hand
        Button5.FlatAppearance.BorderColor = Color.Green
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Image = CType(resources.GetObject("Button5.Image"), Image)
        Button5.Location = New Point(544, 26)
        Button5.Name = "Button5"
        Button5.Size = New Size(32, 26)
        Button5.TabIndex = 0
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.PaleGreen
        Button6.Cursor = Cursors.Hand
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Image = CType(resources.GetObject("Button6.Image"), Image)
        Button6.Location = New Point(626, 27)
        Button6.Name = "Button6"
        Button6.Size = New Size(32, 26)
        Button6.TabIndex = 1
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(458, 31)
        Label9.Name = "Label9"
        Label9.Size = New Size(31, 21)
        Label9.TabIndex = 22
        Label9.Text = "/kl"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(422, 31)
        Label8.Name = "Label8"
        Label8.Size = New Size(28, 21)
        Label8.TabIndex = 21
        Label8.Text = "50"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(232, 45)
        Label6.Name = "Label6"
        Label6.Size = New Size(94, 17)
        Label6.TabIndex = 1
        Label6.Text = "Benguet Farm"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Lime
        Label5.Location = New Point(230, 20)
        Label5.Name = "Label5"
        Label5.Size = New Size(75, 21)
        Label5.TabIndex = 1
        Label5.Text = "TOMATO"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(77, -3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(137, 91)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 19
        PictureBox1.TabStop = False
        ' 
        ' Button4
        ' 
        Button4.Cursor = Cursors.Hand
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.Red
        Button4.Location = New Point(823, 27)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 27)
        Button4.TabIndex = 16
        Button4.Text = "DELETE"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Cursor = Cursors.Hand
        CheckBox1.FlatAppearance.BorderSize = 2
        CheckBox1.FlatStyle = FlatStyle.Flat
        CheckBox1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckBox1.Location = New Point(29, 37)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(12, 11)
        CheckBox1.TabIndex = 15
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        Label3.Location = New Point(723, 39)
        Label3.Name = "Label3"
        Label3.Size = New Size(24, 25)
        Label3.TabIndex = 18
        Label3.Text = "₱"
        ' 
        ' Label37
        ' 
        Label37.AutoSize = True
        Label37.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label37.ForeColor = Color.DarkGreen
        Label37.Location = New Point(573, 14)
        Label37.Name = "Label37"
        Label37.Size = New Size(106, 30)
        Label37.TabIndex = 23
        Label37.Text = "MY CART"
        ' 
        ' Panel13
        ' 
        Panel13.BackColor = Color.ForestGreen
        Panel13.Controls.Add(checkOutBtn)
        Panel13.Controls.Add(Label28)
        Panel13.Controls.Add(Label27)
        Panel13.Controls.Add(Button13)
        Panel13.Controls.Add(Label26)
        Panel13.Controls.Add(selectAll)
        Panel13.Location = New Point(153, 487)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(936, 78)
        Panel13.TabIndex = 3
        ' 
        ' checkOutBtn
        ' 
        checkOutBtn.BackColor = Color.OliveDrab
        checkOutBtn.Cursor = Cursors.Hand
        checkOutBtn.FlatAppearance.BorderSize = 0
        checkOutBtn.FlatStyle = FlatStyle.Flat
        checkOutBtn.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        checkOutBtn.ForeColor = Color.White
        checkOutBtn.Location = New Point(795, 15)
        checkOutBtn.Name = "checkOutBtn"
        checkOutBtn.Size = New Size(118, 47)
        checkOutBtn.TabIndex = 27
        checkOutBtn.Text = "CHECKOUT"
        checkOutBtn.UseVisualStyleBackColor = False
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label28.ForeColor = Color.White
        Label28.Location = New Point(631, 28)
        Label28.Name = "Label28"
        Label28.Size = New Size(49, 17)
        Label28.TabIndex = 26
        Label28.Text = "2 ITEM"
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label27.ForeColor = Color.White
        Label27.Location = New Point(581, 28)
        Label27.Name = "Label27"
        Label27.Size = New Size(47, 17)
        Label27.TabIndex = 25
        Label27.Text = "TOTAL:"
        ' 
        ' Button13
        ' 
        Button13.Cursor = Cursors.Hand
        Button13.FlatAppearance.BorderSize = 0
        Button13.FlatStyle = FlatStyle.Flat
        Button13.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button13.ForeColor = Color.Red
        Button13.Location = New Point(169, 24)
        Button13.Name = "Button13"
        Button13.Size = New Size(75, 27)
        Button13.TabIndex = 24
        Button13.Text = "DELETE"
        Button13.UseVisualStyleBackColor = True
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label26.ForeColor = Color.White
        Label26.Location = New Point(50, 31)
        Label26.Name = "Label26"
        Label26.Size = New Size(75, 17)
        Label26.TabIndex = 23
        Label26.Text = "SELECT ALL"
        ' 
        ' selectAll
        ' 
        selectAll.AutoSize = True
        selectAll.BackColor = Color.White
        selectAll.Cursor = Cursors.Hand
        selectAll.FlatAppearance.BorderSize = 2
        selectAll.FlatStyle = FlatStyle.Flat
        selectAll.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        selectAll.Location = New Point(32, 34)
        selectAll.Name = "selectAll"
        selectAll.Size = New Size(12, 11)
        selectAll.TabIndex = 23
        selectAll.UseVisualStyleBackColor = False
        ' 
        ' cart
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1284, 661)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Name = "cart"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Main"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        menuPanel.ResumeLayout(False)
        menuPanel.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel13.ResumeLayout(False)
        Panel13.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents searchBox As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Label26 As Label
    Friend WithEvents selectAll As CheckBox
    Friend WithEvents checkOutBtn As Button
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Button13 As Button
    Friend WithEvents Label37 As Label
    Friend WithEvents menuPanel As Panel
    Friend WithEvents LinkLabel10 As LinkLabel
    Friend WithEvents LinkLabel9 As LinkLabel
    Friend WithEvents LinkLabel8 As LinkLabel
    Friend WithEvents LinkLabel7 As LinkLabel
    Friend WithEvents LinkLabel6 As LinkLabel
    Friend WithEvents LinkLabel5 As LinkLabel
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents Label38 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents logoutLink As LinkLabel
    Friend WithEvents myPurchaseLink As LinkLabel
    Friend WithEvents seafoodsLink As LinkLabel
    Friend WithEvents herbsLink As LinkLabel
    Friend WithEvents meatsLink As LinkLabel
    Friend WithEvents eggsLink As LinkLabel
    Friend WithEvents fruitsLink As LinkLabel
    Friend WithEvents vegetablesLink As LinkLabel
    Friend WithEvents Label7 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
