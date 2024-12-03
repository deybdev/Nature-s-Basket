<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class myProducts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(myProducts))
        Panel1 = New Panel()
        LinkLabel5 = New LinkLabel()
        LinkLabel4 = New LinkLabel()
        LinkLabel3 = New LinkLabel()
        LinkLabel2 = New LinkLabel()
        LinkLabel1 = New LinkLabel()
        Label2 = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Panel2 = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Panel1.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.ForestGreen
        Panel1.Controls.Add(LinkLabel5)
        Panel1.Controls.Add(LinkLabel4)
        Panel1.Controls.Add(LinkLabel3)
        Panel1.Controls.Add(LinkLabel2)
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1286, 100)
        Panel1.TabIndex = 7
        ' 
        ' LinkLabel5
        ' 
        LinkLabel5.AutoSize = True
        LinkLabel5.BackColor = Color.Transparent
        LinkLabel5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LinkLabel5.ForeColor = Color.Red
        LinkLabel5.LinkBehavior = LinkBehavior.NeverUnderline
        LinkLabel5.LinkColor = Color.PaleGreen
        LinkLabel5.Location = New Point(1183, 38)
        LinkLabel5.Name = "LinkLabel5"
        LinkLabel5.Size = New Size(73, 21)
        LinkLabel5.TabIndex = 12
        LinkLabel5.TabStop = True
        LinkLabel5.Text = "LOGOUT"
        ' 
        ' LinkLabel4
        ' 
        LinkLabel4.AutoSize = True
        LinkLabel4.BackColor = Color.Transparent
        LinkLabel4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LinkLabel4.ForeColor = SystemColors.Control
        LinkLabel4.LinkBehavior = LinkBehavior.NeverUnderline
        LinkLabel4.LinkColor = Color.White
        LinkLabel4.Location = New Point(784, 39)
        LinkLabel4.Name = "LinkLabel4"
        LinkLabel4.Size = New Size(103, 21)
        LinkLabel4.TabIndex = 11
        LinkLabel4.TabStop = True
        LinkLabel4.Text = "Add Product"
        ' 
        ' LinkLabel3
        ' 
        LinkLabel3.AutoSize = True
        LinkLabel3.BackColor = Color.Transparent
        LinkLabel3.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LinkLabel3.ForeColor = SystemColors.Control
        LinkLabel3.LinkBehavior = LinkBehavior.NeverUnderline
        LinkLabel3.LinkColor = Color.White
        LinkLabel3.Location = New Point(645, 39)
        LinkLabel3.Name = "LinkLabel3"
        LinkLabel3.Size = New Size(109, 21)
        LinkLabel3.TabIndex = 10
        LinkLabel3.TabStop = True
        LinkLabel3.Text = "My Products"
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.BackColor = Color.Transparent
        LinkLabel2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LinkLabel2.ForeColor = SystemColors.Control
        LinkLabel2.LinkBehavior = LinkBehavior.NeverUnderline
        LinkLabel2.LinkColor = Color.White
        LinkLabel2.Location = New Point(540, 39)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(60, 21)
        LinkLabel2.TabIndex = 9
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Orders"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LinkLabel1.ForeColor = SystemColors.Control
        LinkLabel1.LinkBehavior = LinkBehavior.NeverUnderline
        LinkLabel1.LinkColor = Color.White
        LinkLabel1.Location = New Point(436, 38)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(55, 21)
        LinkLabel1.TabIndex = 8
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
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.Controls.Add(Panel2)
        FlowLayoutPanel1.Location = New Point(12, 159)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(1260, 490)
        FlowLayoutPanel1.TabIndex = 8
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(3, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1228, 149)
        Panel2.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Green
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Button2.ForeColor = SystemColors.ControlLightLight
        Button2.Location = New Point(1070, 78)
        Button2.Name = "Button2"
        Button2.Size = New Size(118, 30)
        Button2.TabIndex = 6
        Button2.Text = "ADD STOCK"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(1070, 35)
        Button1.Name = "Button1"
        Button1.Size = New Size(118, 33)
        Button1.TabIndex = 5
        Button1.Text = "DELETE"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(894, 62)
        Label5.Name = "Label5"
        Label5.Size = New Size(35, 15)
        Label5.TabIndex = 4
        Label5.Text = "P 150"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(681, 62)
        Label4.Name = "Label4"
        Label4.Size = New Size(35, 15)
        Label4.TabIndex = 3
        Label4.Text = "P 150"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(436, 62)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 15)
        Label3.TabIndex = 2
        Label3.Text = "Benguet Farm"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(270, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 15)
        Label1.TabIndex = 1
        Label1.Text = "TOMATO"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(195, 147)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(82, 124)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 20)
        Label6.TabIndex = 7
        Label6.Text = "IMAGE"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(296, 124)
        Label7.Name = "Label7"
        Label7.Size = New Size(53, 20)
        Label7.TabIndex = 9
        Label7.Text = "NAME"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(471, 124)
        Label8.Name = "Label8"
        Label8.Size = New Size(74, 20)
        Label8.TabIndex = 10
        Label8.Text = "SUPPLIER"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(720, 124)
        Label9.Name = "Label9"
        Label9.Size = New Size(48, 20)
        Label9.TabIndex = 11
        Label9.Text = "PRICE"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(928, 124)
        Label10.Name = "Label10"
        Label10.Size = New Size(53, 20)
        Label10.TabIndex = 12
        Label10.Text = "STOCK"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(1106, 124)
        Label11.Name = "Label11"
        Label11.Size = New Size(63, 20)
        Label11.TabIndex = 13
        Label11.Text = "ACTION"
        ' 
        ' myProducts
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1284, 661)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Panel1)
        Name = "myProducts"
        StartPosition = FormStartPosition.CenterScreen
        Text = "myProducts"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LinkLabel5 As LinkLabel
End Class
