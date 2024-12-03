<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class landing
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(landing))
        Label1 = New Label()
        LinkLabel3 = New LinkLabel()
        searchBox = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        menu = New Button()
        LinkLabel1 = New LinkLabel()
        Label2 = New Label()
        logoutLink = New LinkLabel()
        LinkLabel10 = New LinkLabel()
        LinkLabel8 = New LinkLabel()
        LinkLabel9 = New LinkLabel()
        LinkLabel6 = New LinkLabel()
        LinkLabel7 = New LinkLabel()
        LinkLabel5 = New LinkLabel()
        LinkLabel4 = New LinkLabel()
        Label4 = New Label()
        Label3 = New Label()
        menuPanel = New Panel()
        LinkLabel11 = New LinkLabel()
        myPurchaseLinl = New LinkLabel()
        seafoodsLink = New LinkLabel()
        herbsLink = New LinkLabel()
        meatsLink = New LinkLabel()
        eggsLink = New LinkLabel()
        fruitsLink = New LinkLabel()
        vegetablesLink = New LinkLabel()
        Label5 = New Label()
        Label6 = New Label()
        menuPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(275, 274)
        Label1.Name = "Label1"
        Label1.Size = New Size(749, 128)
        Label1.TabIndex = 0
        Label1.Text = "Nature's Basket"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LinkLabel3
        ' 
        LinkLabel3.AutoSize = True
        LinkLabel3.BackColor = Color.Transparent
        LinkLabel3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LinkLabel3.ForeColor = SystemColors.Control
        LinkLabel3.LinkBehavior = LinkBehavior.NeverUnderline
        LinkLabel3.LinkColor = Color.White
        LinkLabel3.Location = New Point(775, 33)
        LinkLabel3.Name = "LinkLabel3"
        LinkLabel3.Size = New Size(51, 21)
        LinkLabel3.TabIndex = 3
        LinkLabel3.TabStop = True
        LinkLabel3.Text = "Login"
        ' 
        ' searchBox
        ' 
        searchBox.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchBox.Location = New Point(988, 33)
        searchBox.Name = "searchBox"
        searchBox.Size = New Size(167, 25)
        searchBox.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.Transparent
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(958, 33)
        Button1.Name = "Button1"
        Button1.Size = New Size(24, 25)
        Button1.TabIndex = 5
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.Transparent
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.Location = New Point(1176, 32)
        Button2.Name = "Button2"
        Button2.Size = New Size(24, 25)
        Button2.TabIndex = 6
        Button2.UseVisualStyleBackColor = False
        ' 
        ' menu
        ' 
        menu.BackColor = Color.Transparent
        menu.Cursor = Cursors.Hand
        menu.FlatAppearance.BorderSize = 0
        menu.FlatStyle = FlatStyle.Flat
        menu.ForeColor = Color.Transparent
        menu.Image = CType(resources.GetObject("menu.Image"), Image)
        menu.Location = New Point(1215, 32)
        menu.Name = "menu"
        menu.Size = New Size(24, 25)
        menu.TabIndex = 7
        menu.UseVisualStyleBackColor = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LinkLabel1.ForeColor = SystemColors.Control
        LinkLabel1.LinkBehavior = LinkBehavior.NeverUnderline
        LinkLabel1.LinkColor = Color.White
        LinkLabel1.Location = New Point(855, 33)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(55, 21)
        LinkLabel1.TabIndex = 1
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Home"
        ' 
        ' Label2
        ' 
        Label2.AutoEllipsis = True
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.Control
        Label2.Image = CType(resources.GetObject("Label2.Image"), Image)
        Label2.ImageAlign = ContentAlignment.MiddleLeft
        Label2.Location = New Point(69, 27)
        Label2.Name = "Label2"
        Label2.Size = New Size(200, 30)
        Label2.TabIndex = 8
        Label2.Text = "      Nature's Basket"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' logoutLink
        ' 
        logoutLink.AutoSize = True
        logoutLink.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        logoutLink.ForeColor = Color.Red
        logoutLink.LinkBehavior = LinkBehavior.NeverUnderline
        logoutLink.LinkColor = Color.Red
        logoutLink.Location = New Point(70, 436)
        logoutLink.Name = "logoutLink"
        logoutLink.Size = New Size(73, 21)
        logoutLink.TabIndex = 19
        logoutLink.TabStop = True
        logoutLink.Text = "LOGOUT"
        ' 
        ' LinkLabel10
        ' 
        LinkLabel10.AutoSize = True
        LinkLabel10.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LinkLabel10.LinkBehavior = LinkBehavior.NeverUnderline
        LinkLabel10.LinkColor = Color.Black
        LinkLabel10.Location = New Point(57, 406)
        LinkLabel10.Name = "LinkLabel10"
        LinkLabel10.Size = New Size(102, 21)
        LinkLabel10.TabIndex = 18
        LinkLabel10.TabStop = True
        LinkLabel10.Text = "My Purchase"
        ' 
        ' LinkLabel8
        ' 
        LinkLabel8.AutoSize = True
        LinkLabel8.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LinkLabel8.LinkColor = Color.Black
        LinkLabel8.Location = New Point(70, 298)
        LinkLabel8.Name = "LinkLabel8"
        LinkLabel8.Size = New Size(79, 21)
        LinkLabel8.TabIndex = 17
        LinkLabel8.TabStop = True
        LinkLabel8.Text = "Seafoods"
        ' 
        ' LinkLabel9
        ' 
        LinkLabel9.AutoSize = True
        LinkLabel9.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LinkLabel9.LinkColor = Color.Black
        LinkLabel9.Location = New Point(79, 260)
        LinkLabel9.Name = "LinkLabel9"
        LinkLabel9.Size = New Size(54, 21)
        LinkLabel9.TabIndex = 16
        LinkLabel9.TabStop = True
        LinkLabel9.Text = "Herbs"
        ' 
        ' LinkLabel6
        ' 
        LinkLabel6.AutoSize = True
        LinkLabel6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LinkLabel6.LinkColor = Color.Black
        LinkLabel6.Location = New Point(78, 218)
        LinkLabel6.Name = "LinkLabel6"
        LinkLabel6.Size = New Size(55, 21)
        LinkLabel6.TabIndex = 15
        LinkLabel6.TabStop = True
        LinkLabel6.Text = "Meats"
        ' 
        ' LinkLabel7
        ' 
        LinkLabel7.AutoSize = True
        LinkLabel7.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LinkLabel7.LinkColor = Color.Black
        LinkLabel7.Location = New Point(81, 180)
        LinkLabel7.Name = "LinkLabel7"
        LinkLabel7.Size = New Size(45, 21)
        LinkLabel7.TabIndex = 14
        LinkLabel7.TabStop = True
        LinkLabel7.Text = "Eggs"
        ' 
        ' LinkLabel5
        ' 
        LinkLabel5.AutoSize = True
        LinkLabel5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LinkLabel5.LinkColor = Color.Black
        LinkLabel5.Location = New Point(79, 140)
        LinkLabel5.Name = "LinkLabel5"
        LinkLabel5.Size = New Size(50, 21)
        LinkLabel5.TabIndex = 13
        LinkLabel5.TabStop = True
        LinkLabel5.Text = "Fruits"
        ' 
        ' LinkLabel4
        ' 
        LinkLabel4.AutoSize = True
        LinkLabel4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LinkLabel4.LinkColor = Color.Black
        LinkLabel4.Location = New Point(64, 102)
        LinkLabel4.Name = "LinkLabel4"
        LinkLabel4.Size = New Size(91, 21)
        LinkLabel4.TabIndex = 12
        LinkLabel4.TabStop = True
        LinkLabel4.Text = "Vegetables"
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
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(242, -93)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 15)
        Label3.TabIndex = 10
        Label3.Text = "AVAILABLE"
        ' 
        ' menuPanel
        ' 
        menuPanel.BackColor = SystemColors.Control
        menuPanel.Controls.Add(LinkLabel11)
        menuPanel.Controls.Add(myPurchaseLinl)
        menuPanel.Controls.Add(seafoodsLink)
        menuPanel.Controls.Add(herbsLink)
        menuPanel.Controls.Add(meatsLink)
        menuPanel.Controls.Add(eggsLink)
        menuPanel.Controls.Add(fruitsLink)
        menuPanel.Controls.Add(vegetablesLink)
        menuPanel.Controls.Add(Label5)
        menuPanel.Controls.Add(Label6)
        menuPanel.Location = New Point(1083, 81)
        menuPanel.Name = "menuPanel"
        menuPanel.Size = New Size(200, 483)
        menuPanel.TabIndex = 11
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
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(49, 28)
        Label5.Name = "Label5"
        Label5.Size = New Size(110, 25)
        Label5.TabIndex = 11
        Label5.Text = "AVAILABLE"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(242, -93)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 15)
        Label6.TabIndex = 10
        Label6.Text = "AVAILABLE"
        ' 
        ' landing
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1284, 661)
        Controls.Add(menuPanel)
        Controls.Add(Label2)
        Controls.Add(menu)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(searchBox)
        Controls.Add(LinkLabel3)
        Controls.Add(LinkLabel1)
        Controls.Add(Label1)
        Name = "landing"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Landing"
        menuPanel.ResumeLayout(False)
        menuPanel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents searchBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents menu As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents menuPanel As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel8 As LinkLabel
    Friend WithEvents LinkLabel9 As LinkLabel
    Friend WithEvents LinkLabel6 As LinkLabel
    Friend WithEvents LinkLabel7 As LinkLabel
    Friend WithEvents LinkLabel5 As LinkLabel
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents LinkLabel11 As LinkLabel
    Friend WithEvents LinkLabel10 As LinkLabel
    Friend WithEvents logoutLink As LinkLabel
    Friend WithEvents LinkLabel12 As LinkLabel
    Friend WithEvents seafoodsLink As LinkLabel
    Friend WithEvents herbsLink As LinkLabel
    Friend WithEvents meatsLink As LinkLabel
    Friend WithEvents eggsLink As LinkLabel
    Friend WithEvents fruitsLink As LinkLabel
    Friend WithEvents vegetablesLink As LinkLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents myPurchaseLinl As LinkLabel

End Class
