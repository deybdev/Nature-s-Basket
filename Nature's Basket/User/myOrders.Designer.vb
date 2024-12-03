<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class myOrders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(myOrders))
        Panel1 = New Panel()
        LinkLabel1 = New LinkLabel()
        Label2 = New Label()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        searchBox = New TextBox()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Panel2 = New Panel()
        Label16 = New Label()
        Panel4 = New Panel()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        PictureBox2 = New PictureBox()
        Label15 = New Label()
        Panel3 = New Panel()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        Label13 = New Label()
        Label7 = New Label()
        Label14 = New Label()
        Label1 = New Label()
        Panel5 = New Panel()
        ordersTotal = New Label()
        Button4 = New Button()
        menuPanel = New Panel()
        LinkLabel11 = New LinkLabel()
        myPurchaseLinl = New LinkLabel()
        seafoodsLink = New LinkLabel()
        herbsLink = New LinkLabel()
        meatsLink = New LinkLabel()
        eggsLink = New LinkLabel()
        fruitsLink = New LinkLabel()
        vegetablesLink = New LinkLabel()
        Label17 = New Label()
        Label18 = New Label()
        Panel1.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        menuPanel.SuspendLayout()
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
        LinkLabel1.Location = New Point(870, 43)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(55, 21)
        LinkLabel1.TabIndex = 15
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
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.BackColor = Color.Transparent
        FlowLayoutPanel1.Controls.Add(Panel2)
        FlowLayoutPanel1.Location = New Point(242, 162)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(793, 393)
        FlowLayoutPanel1.TabIndex = 4
        ' 
        ' Panel2
        ' 
        Panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel2.BackColor = Color.DarkGreen
        Panel2.Controls.Add(Label16)
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(Label15)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label14)
        Panel2.Location = New Point(3, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(764, 321)
        Panel2.TabIndex = 0
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = SystemColors.ButtonHighlight
        Label16.Location = New Point(278, 30)
        Label16.Name = "Label16"
        Label16.Size = New Size(80, 17)
        Label16.TabIndex = 9
        Label16.Text = "PAYMENT : "
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(Label8)
        Panel4.Controls.Add(Label9)
        Panel4.Controls.Add(Label10)
        Panel4.Controls.Add(Label11)
        Panel4.Controls.Add(Label12)
        Panel4.Controls.Add(PictureBox2)
        Panel4.Location = New Point(11, 183)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(740, 124)
        Panel4.TabIndex = 6
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.White
        Label8.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label8.Location = New Point(649, 101)
        Label8.Name = "Label8"
        Label8.Size = New Size(0, 21)
        Label8.TabIndex = 5
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label9.Location = New Point(456, 49)
        Label9.Name = "Label9"
        Label9.Size = New Size(56, 21)
        Label9.TabIndex = 4
        Label9.Text = "P 1000"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label10.Location = New Point(713, 49)
        Label10.Name = "Label10"
        Label10.Size = New Size(24, 21)
        Label10.TabIndex = 3
        Label10.Text = "x1"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label11.Location = New Point(207, 61)
        Label11.Name = "Label11"
        Label11.Size = New Size(114, 21)
        Label11.TabIndex = 2
        Label11.Text = "SA TABI LANG"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(207, 37)
        Label12.Name = "Label12"
        Label12.Size = New Size(86, 21)
        Label12.TabIndex = 1
        Label12.Text = "KAMATIS"
        Label12.TextAlign = ContentAlignment.TopCenter
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(0, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(161, 124)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = SystemColors.ButtonHighlight
        Label15.Location = New Point(291, 7)
        Label15.Name = "Label15"
        Label15.Size = New Size(66, 17)
        Label15.TabIndex = 8
        Label15.Text = "STATUS : "
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(PictureBox1)
        Panel3.Location = New Point(11, 50)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(740, 124)
        Panel3.TabIndex = 1
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label6.Location = New Point(456, 49)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 21)
        Label6.TabIndex = 4
        Label6.Text = "P 1000"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label5.Location = New Point(713, 49)
        Label5.Name = "Label5"
        Label5.Size = New Size(24, 21)
        Label5.TabIndex = 3
        Label5.Text = "x1"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label4.Location = New Point(207, 61)
        Label4.Name = "Label4"
        Label4.Size = New Size(126, 21)
        Label4.TabIndex = 2
        Label4.Text = "BENGUET FARM"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(207, 37)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 21)
        Label3.TabIndex = 1
        Label3.Text = "TOMATO"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(161, 124)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = SystemColors.ButtonHighlight
        Label13.Location = New Point(25, 29)
        Label13.Name = "Label13"
        Label13.Size = New Size(77, 17)
        Label13.TabIndex = 6
        Label13.Text = "ORDER ID :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.Control
        Label7.Location = New Point(555, 16)
        Label7.Name = "Label7"
        Label7.Size = New Size(76, 21)
        Label7.TabIndex = 5
        Label7.Text = "TOTAL : "
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = SystemColors.ButtonHighlight
        Label14.Location = New Point(52, 6)
        Label14.Name = "Label14"
        Label14.Size = New Size(53, 17)
        Label14.TabIndex = 7
        Label14.Text = "DATE : "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(571, 116)
        Label1.Name = "Label1"
        Label1.Size = New Size(138, 30)
        Label1.TabIndex = 5
        Label1.Text = "MY ORDERS"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.ForestGreen
        Panel5.Controls.Add(ordersTotal)
        Panel5.Controls.Add(Button4)
        Panel5.Location = New Point(171, 580)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(957, 81)
        Panel5.TabIndex = 6
        ' 
        ' ordersTotal
        ' 
        ordersTotal.AutoSize = True
        ordersTotal.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ordersTotal.ForeColor = SystemColors.ButtonHighlight
        ordersTotal.Location = New Point(469, 31)
        ordersTotal.Name = "ordersTotal"
        ordersTotal.Size = New Size(101, 21)
        ordersTotal.TabIndex = 7
        ordersTotal.Text = "MY ORDERS"
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Green
        Button4.Cursor = Cursors.Hand
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = SystemColors.ButtonHighlight
        Button4.Location = New Point(816, 16)
        Button4.Name = "Button4"
        Button4.Size = New Size(129, 53)
        Button4.TabIndex = 0
        Button4.Text = "ORDER AGAIN"
        Button4.UseVisualStyleBackColor = False
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
        menuPanel.Controls.Add(Label17)
        menuPanel.Controls.Add(Label18)
        menuPanel.Location = New Point(1084, 99)
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
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(49, 28)
        Label17.Name = "Label17"
        Label17.Size = New Size(110, 25)
        Label17.TabIndex = 11
        Label17.Text = "AVAILABLE"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(242, -93)
        Label18.Name = "Label18"
        Label18.Size = New Size(64, 15)
        Label18.TabIndex = 10
        Label18.Text = "AVAILABLE"
        ' 
        ' myOrders
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Ivory
        ClientSize = New Size(1284, 661)
        Controls.Add(Panel5)
        Controls.Add(menuPanel)
        Controls.Add(Label1)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Panel1)
        Name = "myOrders"
        StartPosition = FormStartPosition.CenterScreen
        Text = "myOrders"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        menuPanel.ResumeLayout(False)
        menuPanel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents searchBox As TextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents ordersTotal As Label
    Friend WithEvents menuPanel As Panel
    Friend WithEvents LinkLabel11 As LinkLabel
    Friend WithEvents myPurchaseLinl As LinkLabel
    Friend WithEvents seafoodsLink As LinkLabel
    Friend WithEvents herbsLink As LinkLabel
    Friend WithEvents meatsLink As LinkLabel
    Friend WithEvents eggsLink As LinkLabel
    Friend WithEvents fruitsLink As LinkLabel
    Friend WithEvents vegetablesLink As LinkLabel
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
End Class
