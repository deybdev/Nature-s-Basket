<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(register))
        Panel2 = New Panel()
        Panel3 = New Panel()
        contactNum = New TextBox()
        Label7 = New Label()
        houseNumberBox = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        provinceBox = New TextBox()
        cityBox = New TextBox()
        districtBox = New TextBox()
        barangayBox = New TextBox()
        Label4 = New Label()
        streetBox = New TextBox()
        lastNameBox = New TextBox()
        firstNameBox = New TextBox()
        LinkLabel4 = New LinkLabel()
        Label3 = New Label()
        regButton = New Button()
        passwordBox = New TextBox()
        Label1 = New Label()
        emailBox = New TextBox()
        Label2 = New Label()
        Panel1 = New Panel()
        LinkLabel1 = New LinkLabel()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightGreen
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Controls.Add(Panel3)
        Panel2.Location = New Point(-51, 94)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1335, 568)
        Panel2.TabIndex = 5
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(contactNum)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(houseNumberBox)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(provinceBox)
        Panel3.Controls.Add(cityBox)
        Panel3.Controls.Add(districtBox)
        Panel3.Controls.Add(barangayBox)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(streetBox)
        Panel3.Controls.Add(lastNameBox)
        Panel3.Controls.Add(firstNameBox)
        Panel3.Controls.Add(LinkLabel4)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(regButton)
        Panel3.Controls.Add(passwordBox)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(emailBox)
        Panel3.Location = New Point(459, 42)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(459, 493)
        Panel3.TabIndex = 1
        ' 
        ' contactNum
        ' 
        contactNum.AcceptsReturn = True
        contactNum.BorderStyle = BorderStyle.FixedSingle
        contactNum.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        contactNum.Location = New Point(23, 171)
        contactNum.Margin = New Padding(3, 3, 3, 20)
        contactNum.Name = "contactNum"
        contactNum.PlaceholderText = "   Contact Number"
        contactNum.Size = New Size(414, 27)
        contactNum.TabIndex = 19
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(23, 147)
        Label7.Name = "Label7"
        Label7.Size = New Size(109, 17)
        Label7.TabIndex = 18
        Label7.Text = "Contact Number"
        ' 
        ' houseNumberBox
        ' 
        houseNumberBox.BorderStyle = BorderStyle.FixedSingle
        houseNumberBox.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        houseNumberBox.Location = New Point(23, 225)
        houseNumberBox.Margin = New Padding(3, 3, 3, 20)
        houseNumberBox.Name = "houseNumberBox"
        houseNumberBox.PlaceholderText = "    House no."
        houseNumberBox.Size = New Size(133, 27)
        houseNumberBox.TabIndex = 17
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(22, 293)
        Label6.Name = "Label6"
        Label6.Size = New Size(129, 17)
        Label6.TabIndex = 16
        Label6.Text = "Email and Password"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(24, 94)
        Label5.Name = "Label5"
        Label5.Size = New Size(44, 17)
        Label5.TabIndex = 15
        Label5.Text = "Name"
        ' 
        ' provinceBox
        ' 
        provinceBox.BorderStyle = BorderStyle.FixedSingle
        provinceBox.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        provinceBox.Location = New Point(303, 261)
        provinceBox.Margin = New Padding(3, 3, 3, 20)
        provinceBox.Name = "provinceBox"
        provinceBox.PlaceholderText = "    Province"
        provinceBox.Size = New Size(133, 27)
        provinceBox.TabIndex = 14
        ' 
        ' cityBox
        ' 
        cityBox.BorderStyle = BorderStyle.FixedSingle
        cityBox.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cityBox.Location = New Point(164, 261)
        cityBox.Margin = New Padding(3, 3, 3, 20)
        cityBox.Name = "cityBox"
        cityBox.PlaceholderText = "    City"
        cityBox.Size = New Size(133, 27)
        cityBox.TabIndex = 13
        ' 
        ' districtBox
        ' 
        districtBox.BorderStyle = BorderStyle.FixedSingle
        districtBox.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        districtBox.Location = New Point(23, 261)
        districtBox.Margin = New Padding(3, 3, 3, 20)
        districtBox.Name = "districtBox"
        districtBox.PlaceholderText = "    District"
        districtBox.Size = New Size(133, 27)
        districtBox.TabIndex = 12
        ' 
        ' barangayBox
        ' 
        barangayBox.BorderStyle = BorderStyle.FixedSingle
        barangayBox.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        barangayBox.Location = New Point(304, 225)
        barangayBox.Margin = New Padding(3, 3, 3, 20)
        barangayBox.Name = "barangayBox"
        barangayBox.PlaceholderText = "    Barangay"
        barangayBox.Size = New Size(133, 27)
        barangayBox.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(21, 202)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 17)
        Label4.TabIndex = 10
        Label4.Text = "Address"
        ' 
        ' streetBox
        ' 
        streetBox.BorderStyle = BorderStyle.FixedSingle
        streetBox.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        streetBox.Location = New Point(165, 225)
        streetBox.Margin = New Padding(3, 3, 3, 20)
        streetBox.Name = "streetBox"
        streetBox.PlaceholderText = "    Street"
        streetBox.Size = New Size(133, 27)
        streetBox.TabIndex = 9
        ' 
        ' lastNameBox
        ' 
        lastNameBox.BorderStyle = BorderStyle.FixedSingle
        lastNameBox.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lastNameBox.Location = New Point(24, 116)
        lastNameBox.Margin = New Padding(3, 3, 3, 20)
        lastNameBox.Name = "lastNameBox"
        lastNameBox.PlaceholderText = "   Last Name"
        lastNameBox.Size = New Size(193, 27)
        lastNameBox.TabIndex = 8
        ' 
        ' firstNameBox
        ' 
        firstNameBox.BorderStyle = BorderStyle.FixedSingle
        firstNameBox.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        firstNameBox.Location = New Point(223, 116)
        firstNameBox.Margin = New Padding(3, 3, 3, 20)
        firstNameBox.Name = "firstNameBox"
        firstNameBox.PlaceholderText = "   First Name"
        firstNameBox.Size = New Size(213, 27)
        firstNameBox.TabIndex = 7
        ' 
        ' LinkLabel4
        ' 
        LinkLabel4.AutoSize = True
        LinkLabel4.Font = New Font("Segoe UI", 9.75F)
        LinkLabel4.LinkColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        LinkLabel4.Location = New Point(263, 453)
        LinkLabel4.Name = "LinkLabel4"
        LinkLabel4.Size = New Size(40, 17)
        LinkLabel4.TabIndex = 6
        LinkLabel4.TabStop = True
        LinkLabel4.Text = "Login"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F)
        Label3.Location = New Point(155, 453)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 17)
        Label3.TabIndex = 5
        Label3.Text = "Have an account?"
        ' 
        ' regButton
        ' 
        regButton.BackColor = Color.ForestGreen
        regButton.FlatAppearance.BorderSize = 0
        regButton.FlatStyle = FlatStyle.Flat
        regButton.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        regButton.ForeColor = Color.White
        regButton.Location = New Point(113, 396)
        regButton.Name = "regButton"
        regButton.Size = New Size(235, 46)
        regButton.TabIndex = 4
        regButton.Text = "REGISTER"
        regButton.UseVisualStyleBackColor = False
        ' 
        ' passwordBox
        ' 
        passwordBox.BorderStyle = BorderStyle.FixedSingle
        passwordBox.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        passwordBox.Location = New Point(24, 356)
        passwordBox.Margin = New Padding(3, 3, 3, 20)
        passwordBox.Name = "passwordBox"
        passwordBox.PasswordChar = "*"c
        passwordBox.PlaceholderText = "   Password"
        passwordBox.Size = New Size(413, 27)
        passwordBox.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(144, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(183, 50)
        Label1.TabIndex = 2
        Label1.Text = "REGISTER"
        ' 
        ' emailBox
        ' 
        emailBox.BorderStyle = BorderStyle.FixedSingle
        emailBox.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        emailBox.Location = New Point(24, 318)
        emailBox.Margin = New Padding(3, 3, 3, 20)
        emailBox.Name = "emailBox"
        emailBox.PlaceholderText = "   Email"
        emailBox.Size = New Size(413, 27)
        emailBox.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoEllipsis = True
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.Control
        Label2.Image = CType(resources.GetObject("Label2.Image"), Image)
        Label2.ImageAlign = ContentAlignment.MiddleLeft
        Label2.Location = New Point(92, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(200, 30)
        Label2.TabIndex = 7
        Label2.Text = "      Nature's Basket"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.ForestGreen
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(-51, -2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1338, 100)
        Panel1.TabIndex = 4
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LinkLabel1.ForeColor = SystemColors.Control
        LinkLabel1.LinkBehavior = LinkBehavior.NeverUnderline
        LinkLabel1.LinkColor = Color.White
        LinkLabel1.Location = New Point(1242, 40)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(55, 21)
        LinkLabel1.TabIndex = 13
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Home"
        ' 
        ' register
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1284, 661)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "register"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Register"
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents regButton As Button
    Friend WithEvents passwordBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents emailBox As TextBox
    Friend WithEvents lastNameBox As TextBox
    Friend WithEvents firstNameBox As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents street As TextBox
    Friend WithEvents province As TextBox
    Friend WithEvents city As TextBox
    Friend WithEvents district As TextBox
    Friend WithEvents barangay As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents house_no As TextBox
    Friend WithEvents houseNumberBox As TextBox
    Friend WithEvents provinceBox As TextBox
    Friend WithEvents cityBox As TextBox
    Friend WithEvents districtBox As TextBox
    Friend WithEvents barangayBox As TextBox
    Friend WithEvents streetBox As TextBox
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents contactNum As TextBox
    Friend WithEvents Label7 As Label
End Class
