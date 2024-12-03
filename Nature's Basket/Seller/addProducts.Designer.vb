<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addProducts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addProducts))
        Panel2 = New Panel()
        Panel3 = New Panel()
        Button4 = New Button()
        quantityBox = New NumericUpDown()
        Label12 = New Label()
        unitBox = New ComboBox()
        Label11 = New Label()
        priceBox = New TextBox()
        supplierBox = New TextBox()
        Label10 = New Label()
        Label9 = New Label()
        PictureBox1 = New PictureBox()
        productCategory = New ComboBox()
        addImageBtn = New Button()
        Label7 = New Label()
        Label6 = New Label()
        productName = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        Panel1 = New Panel()
        LinkLabel5 = New LinkLabel()
        LinkLabel4 = New LinkLabel()
        LinkLabel3 = New LinkLabel()
        LinkLabel2 = New LinkLabel()
        LinkLabel1 = New LinkLabel()
        Label2 = New Label()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(quantityBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Panel3)
        Panel2.Location = New Point(12, 121)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1260, 528)
        Panel2.TabIndex = 3
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(Button4)
        Panel3.Controls.Add(quantityBox)
        Panel3.Controls.Add(Label12)
        Panel3.Controls.Add(unitBox)
        Panel3.Controls.Add(Label11)
        Panel3.Controls.Add(priceBox)
        Panel3.Controls.Add(supplierBox)
        Panel3.Controls.Add(Label10)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(PictureBox1)
        Panel3.Controls.Add(productCategory)
        Panel3.Controls.Add(addImageBtn)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(productName)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(16, 40)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1224, 425)
        Panel3.TabIndex = 4
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.DarkGreen
        Button4.Cursor = Cursors.Hand
        Button4.FlatStyle = FlatStyle.Flat
        Button4.ForeColor = SystemColors.ButtonHighlight
        Button4.Location = New Point(1011, 158)
        Button4.Name = "Button4"
        Button4.Size = New Size(109, 70)
        Button4.TabIndex = 5
        Button4.Text = "Add Product"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' quantityBox
        ' 
        quantityBox.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        quantityBox.Location = New Point(658, 296)
        quantityBox.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        quantityBox.Name = "quantityBox"
        quantityBox.Size = New Size(233, 27)
        quantityBox.TabIndex = 20
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label12.Location = New Point(565, 300)
        Label12.Name = "Label12"
        Label12.Size = New Size(72, 17)
        Label12.TabIndex = 19
        Label12.Text = "Quantity : "
        ' 
        ' unitBox
        ' 
        unitBox.Cursor = Cursors.Hand
        unitBox.DropDownStyle = ComboBoxStyle.DropDownList
        unitBox.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        unitBox.FormattingEnabled = True
        unitBox.Items.AddRange(New Object() {"g", "kg", "liter", "lb", "mg", "ml", "oz", "pc"})
        unitBox.Location = New Point(809, 241)
        unitBox.Name = "unitBox"
        unitBox.Size = New Size(82, 28)
        unitBox.TabIndex = 18
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label11.Location = New Point(768, 247)
        Label11.Name = "Label11"
        Label11.Size = New Size(28, 17)
        Label11.TabIndex = 17
        Label11.Text = "per"
        ' 
        ' priceBox
        ' 
        priceBox.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        priceBox.Location = New Point(657, 242)
        priceBox.Name = "priceBox"
        priceBox.Size = New Size(105, 27)
        priceBox.TabIndex = 16
        ' 
        ' supplierBox
        ' 
        supplierBox.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        supplierBox.Location = New Point(657, 190)
        supplierBox.Name = "supplierBox"
        supplierBox.Size = New Size(234, 27)
        supplierBox.TabIndex = 15
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label10.Location = New Point(584, 251)
        Label10.Name = "Label10"
        Label10.Size = New Size(44, 17)
        Label10.TabIndex = 14
        Label10.Text = "Price :"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label9.Location = New Point(566, 195)
        Label9.Name = "Label9"
        Label9.Size = New Size(68, 17)
        Label9.TabIndex = 13
        Label9.Text = "Supplier : "
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(259, 124)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(175, 140)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' productCategory
        ' 
        productCategory.Cursor = Cursors.Hand
        productCategory.DropDownStyle = ComboBoxStyle.DropDownList
        productCategory.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        productCategory.FormattingEnabled = True
        productCategory.Items.AddRange(New Object() {"Vegetable", "Fruit", "Egg", "Meat", "Herb", "Seafood"})
        productCategory.Location = New Point(657, 141)
        productCategory.Name = "productCategory"
        productCategory.Size = New Size(234, 28)
        productCategory.TabIndex = 11
        ' 
        ' addImageBtn
        ' 
        addImageBtn.BackColor = Color.ForestGreen
        addImageBtn.Cursor = Cursors.Hand
        addImageBtn.FlatAppearance.BorderSize = 0
        addImageBtn.FlatStyle = FlatStyle.Flat
        addImageBtn.ForeColor = SystemColors.ButtonHighlight
        addImageBtn.Location = New Point(259, 270)
        addImageBtn.Name = "addImageBtn"
        addImageBtn.Size = New Size(175, 29)
        addImageBtn.TabIndex = 10
        addImageBtn.Text = "Add Image"
        addImageBtn.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label7.Location = New Point(516, 143)
        Label7.Name = "Label7"
        Label7.Size = New Size(127, 17)
        Label7.TabIndex = 7
        Label7.Text = "Product Category : "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label6.Location = New Point(531, 94)
        Label6.Name = "Label6"
        Label6.Size = New Size(107, 17)
        Label6.TabIndex = 5
        Label6.Text = "Product Name : "
        ' 
        ' productName
        ' 
        productName.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        productName.Location = New Point(657, 90)
        productName.Name = "productName"
        productName.Size = New Size(234, 27)
        productName.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label5.Location = New Point(95, 200)
        Label5.Name = "Label5"
        Label5.Size = New Size(105, 17)
        Label5.TabIndex = 2
        Label5.Text = "Product Image: "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(10, 81)
        Label4.Name = "Label4"
        Label4.Size = New Size(166, 21)
        Label4.TabIndex = 1
        Label4.Text = "Product Information"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(10, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(124, 21)
        Label3.TabIndex = 0
        Label3.Text = "ADD PRODUCT"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
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
        Panel1.Location = New Point(2, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1286, 100)
        Panel1.TabIndex = 8
        ' 
        ' LinkLabel5
        ' 
        LinkLabel5.AutoSize = True
        LinkLabel5.BackColor = Color.Transparent
        LinkLabel5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LinkLabel5.ForeColor = Color.Red
        LinkLabel5.LinkBehavior = LinkBehavior.NeverUnderline
        LinkLabel5.LinkColor = Color.PaleGreen
        LinkLabel5.Location = New Point(1191, 36)
        LinkLabel5.Name = "LinkLabel5"
        LinkLabel5.Size = New Size(73, 21)
        LinkLabel5.TabIndex = 13
        LinkLabel5.TabStop = True
        LinkLabel5.Text = "LOGOUT"
        ' 
        ' LinkLabel4
        ' 
        LinkLabel4.AutoSize = True
        LinkLabel4.BackColor = Color.Transparent
        LinkLabel4.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LinkLabel4.ForeColor = SystemColors.Control
        LinkLabel4.LinkBehavior = LinkBehavior.NeverUnderline
        LinkLabel4.LinkColor = Color.White
        LinkLabel4.Location = New Point(786, 39)
        LinkLabel4.Name = "LinkLabel4"
        LinkLabel4.Size = New Size(108, 21)
        LinkLabel4.TabIndex = 11
        LinkLabel4.TabStop = True
        LinkLabel4.Text = "Add Product"
        ' 
        ' LinkLabel3
        ' 
        LinkLabel3.AutoSize = True
        LinkLabel3.BackColor = Color.Transparent
        LinkLabel3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LinkLabel3.ForeColor = SystemColors.Control
        LinkLabel3.LinkBehavior = LinkBehavior.NeverUnderline
        LinkLabel3.LinkColor = Color.White
        LinkLabel3.Location = New Point(647, 39)
        LinkLabel3.Name = "LinkLabel3"
        LinkLabel3.Size = New Size(102, 21)
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
        LinkLabel2.Location = New Point(542, 39)
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
        LinkLabel1.Location = New Point(438, 38)
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
        ' addProducts
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1284, 661)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Name = "addProducts"
        StartPosition = FormStartPosition.CenterScreen
        Text = "addProducts"
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(quantityBox, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents productName As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents addImageBtn As Button
    Friend WithEvents productCategory As ComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents priceBox As TextBox
    Friend WithEvents supplierBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents unitBox As ComboBox
    Friend WithEvents quantityBox As NumericUpDown
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel5 As LinkLabel
End Class
