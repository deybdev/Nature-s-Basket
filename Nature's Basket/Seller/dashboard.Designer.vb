<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboard))
        Panel1 = New Panel()
        LinkLabel5 = New LinkLabel()
        LinkLabel4 = New LinkLabel()
        LinkLabel3 = New LinkLabel()
        LinkLabel2 = New LinkLabel()
        LinkLabel1 = New LinkLabel()
        Label2 = New Label()
        Panel2 = New Panel()
        Label10 = New Label()
        Label11 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
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
        Panel1.TabIndex = 3
        ' 
        ' LinkLabel5
        ' 
        LinkLabel5.AutoSize = True
        LinkLabel5.BackColor = Color.Transparent
        LinkLabel5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LinkLabel5.ForeColor = Color.Red
        LinkLabel5.LinkBehavior = LinkBehavior.NeverUnderline
        LinkLabel5.LinkColor = Color.PaleGreen
        LinkLabel5.Location = New Point(1199, 39)
        LinkLabel5.Name = "LinkLabel5"
        LinkLabel5.Size = New Size(73, 21)
        LinkLabel5.TabIndex = 14
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
        LinkLabel4.Location = New Point(789, 39)
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
        LinkLabel3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LinkLabel3.ForeColor = SystemColors.Control
        LinkLabel3.LinkBehavior = LinkBehavior.NeverUnderline
        LinkLabel3.LinkColor = Color.White
        LinkLabel3.Location = New Point(650, 39)
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
        LinkLabel2.Location = New Point(545, 39)
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
        LinkLabel1.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LinkLabel1.ForeColor = SystemColors.Control
        LinkLabel1.LinkBehavior = LinkBehavior.NeverUnderline
        LinkLabel1.LinkColor = Color.White
        LinkLabel1.Location = New Point(441, 38)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(57, 21)
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
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(12, 121)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1260, 202)
        Panel2.TabIndex = 4
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(1109, 138)
        Label10.Name = "Label10"
        Label10.Size = New Size(65, 15)
        Label10.TabIndex = 9
        Label10.Text = "Completed"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(1124, 77)
        Label11.Name = "Label11"
        Label11.Size = New Size(37, 45)
        Label11.TabIndex = 8
        Label11.Text = "1"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(763, 138)
        Label8.Name = "Label8"
        Label8.Size = New Size(99, 15)
        Label8.TabIndex = 7
        Label8.Text = "Soldout Products"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(792, 77)
        Label9.Name = "Label9"
        Label9.Size = New Size(37, 45)
        Label9.TabIndex = 6
        Label9.Text = "1"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(461, 138)
        Label6.Name = "Label6"
        Label6.Size = New Size(51, 15)
        Label6.TabIndex = 5
        Label6.Text = "Shipped"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(470, 77)
        Label7.Name = "Label7"
        Label7.Size = New Size(37, 45)
        Label7.TabIndex = 4
        Label7.Text = "1"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(108, 138)
        Label5.Name = "Label5"
        Label5.Size = New Size(60, 15)
        Label5.TabIndex = 3
        Label5.Text = "Processed"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(121, 77)
        Label4.Name = "Label4"
        Label4.Size = New Size(37, 45)
        Label4.TabIndex = 2
        Label4.Text = "1"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 37)
        Label3.Name = "Label3"
        Label3.Size = New Size(128, 15)
        Label3.TabIndex = 1
        Label3.Text = "Things you have to do."
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(7, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(127, 30)
        Label1.TabIndex = 0
        Label1.Text = "TO-DO LIST"
        ' 
        ' dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1284, 661)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "dashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents LinkLabel5 As LinkLabel
End Class
