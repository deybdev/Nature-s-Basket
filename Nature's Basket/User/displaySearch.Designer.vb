<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class displaySearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(displaySearch))
        Panel1 = New Panel()
        LinkLabel1 = New LinkLabel()
        loginText = New LinkLabel()
        Label2 = New Label()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        searchBox = New TextBox()
        Label1 = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Label5 = New Label()
        menuPanel = New Panel()
        LinkLabel11 = New LinkLabel()
        myPurchaseLinl = New LinkLabel()
        seafoodsLink = New LinkLabel()
        herbsLink = New LinkLabel()
        meatsLink = New LinkLabel()
        eggsLink = New LinkLabel()
        fruitsLink = New LinkLabel()
        vegetablesLink = New LinkLabel()
        Label3 = New Label()
        Label8 = New Label()
        Panel1.SuspendLayout()
        menuPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.ForestGreen
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(loginText)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(searchBox)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1286, 100)
        Panel1.TabIndex = 3
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LinkLabel1.ForeColor = SystemColors.Control
        LinkLabel1.LinkBehavior = LinkBehavior.NeverUnderline
        LinkLabel1.LinkColor = Color.White
        LinkLabel1.Location = New Point(818, 40)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(55, 21)
        LinkLabel1.TabIndex = 16
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Home"
        ' 
        ' loginText
        ' 
        loginText.AutoSize = True
        loginText.BackColor = Color.Transparent
        loginText.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        loginText.ForeColor = SystemColors.Control
        loginText.LinkBehavior = LinkBehavior.NeverUnderline
        loginText.LinkColor = Color.White
        loginText.Location = New Point(897, 38)
        loginText.Name = "loginText"
        loginText.Size = New Size(51, 21)
        loginText.TabIndex = 15
        loginText.TabStop = True
        loginText.Text = "Login"
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(42, 129)
        Label1.Name = "Label1"
        Label1.Size = New Size(209, 37)
        Label1.TabIndex = 4
        Label1.Text = "Search Result : "
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.Location = New Point(0, 232)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(1286, 430)
        FlowLayoutPanel1.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(257, 135)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 30)
        Label5.TabIndex = 6
        Label5.Text = "aaaa"
        ' 
        ' menuPanel
        ' 
        menuPanel.BackColor = SystemColors.Control
        menuPanel.BorderStyle = BorderStyle.FixedSingle
        menuPanel.Controls.Add(LinkLabel11)
        menuPanel.Controls.Add(myPurchaseLinl)
        menuPanel.Controls.Add(seafoodsLink)
        menuPanel.Controls.Add(herbsLink)
        menuPanel.Controls.Add(meatsLink)
        menuPanel.Controls.Add(eggsLink)
        menuPanel.Controls.Add(fruitsLink)
        menuPanel.Controls.Add(vegetablesLink)
        menuPanel.Controls.Add(Label3)
        menuPanel.Controls.Add(Label8)
        menuPanel.Location = New Point(1083, 100)
        menuPanel.Name = "menuPanel"
        menuPanel.Size = New Size(200, 483)
        menuPanel.TabIndex = 13
        menuPanel.Visible = False
        ' 
        ' LinkLabel11
        ' 
        LinkLabel11.AutoSize = True
        LinkLabel11.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LinkLabel11.ForeColor = Color.Red
        LinkLabel11.LinkBehavior = LinkBehavior.NeverUnderline
        LinkLabel11.LinkColor = Color.Red
        LinkLabel11.Location = New Point(70, 435)
        LinkLabel11.Name = "LinkLabel11"
        LinkLabel11.Size = New Size(73, 21)
        LinkLabel11.TabIndex = 19
        LinkLabel11.TabStop = True
        LinkLabel11.Text = "LOGOUT"
        ' 
        ' myPurchaseLinl
        ' 
        myPurchaseLinl.AutoSize = True
        myPurchaseLinl.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        myPurchaseLinl.LinkBehavior = LinkBehavior.NeverUnderline
        myPurchaseLinl.LinkColor = Color.DarkBlue
        myPurchaseLinl.Location = New Point(45, 403)
        myPurchaseLinl.Name = "myPurchaseLinl"
        myPurchaseLinl.Size = New Size(118, 21)
        myPurchaseLinl.TabIndex = 18
        myPurchaseLinl.TabStop = True
        myPurchaseLinl.Text = "MY PURCHASE"
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
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(49, 28)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 25)
        Label3.TabIndex = 11
        Label3.Text = "AVAILABLE"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(242, -93)
        Label8.Name = "Label8"
        Label8.Size = New Size(64, 15)
        Label8.TabIndex = 10
        Label8.Text = "AVAILABLE"
        ' 
        ' displaySearch
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1284, 661)
        Controls.Add(menuPanel)
        Controls.Add(Label5)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Name = "displaySearch"
        StartPosition = FormStartPosition.CenterScreen
        Text = "displaySearch"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        menuPanel.ResumeLayout(False)
        menuPanel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents loginText As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents searchBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents menuPanel As Panel
    Friend WithEvents LinkLabel11 As LinkLabel
    Friend WithEvents myPurchaseLinl As LinkLabel
    Friend WithEvents seafoodsLink As LinkLabel
    Friend WithEvents herbsLink As LinkLabel
    Friend WithEvents meatsLink As LinkLabel
    Friend WithEvents eggsLink As LinkLabel
    Friend WithEvents fruitsLink As LinkLabel
    Friend WithEvents vegetablesLink As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
End Class
