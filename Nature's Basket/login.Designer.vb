<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Panel1 = New Panel()
        Label2 = New Label()
        LinkLabel1 = New LinkLabel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        LinkLabel4 = New LinkLabel()
        Label3 = New Label()
        loginButton = New Button()
        passwordBox = New TextBox()
        Label1 = New Label()
        emailBox = New TextBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.ForestGreen
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Location = New Point(1, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1286, 100)
        Panel1.TabIndex = 0
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
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LinkLabel1.ForeColor = SystemColors.Control
        LinkLabel1.LinkBehavior = LinkBehavior.NeverUnderline
        LinkLabel1.LinkColor = Color.White
        LinkLabel1.Location = New Point(1168, 38)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(55, 21)
        LinkLabel1.TabIndex = 8
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Home"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightGreen
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Controls.Add(Panel3)
        Panel2.Location = New Point(1, 97)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1286, 568)
        Panel2.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(LinkLabel4)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(loginButton)
        Panel3.Controls.Add(passwordBox)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(emailBox)
        Panel3.Location = New Point(424, 79)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(397, 408)
        Panel3.TabIndex = 1
        ' 
        ' LinkLabel4
        ' 
        LinkLabel4.AutoSize = True
        LinkLabel4.Font = New Font("Segoe UI", 9.75F)
        LinkLabel4.LinkColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        LinkLabel4.Location = New Point(234, 291)
        LinkLabel4.Name = "LinkLabel4"
        LinkLabel4.Size = New Size(56, 17)
        LinkLabel4.TabIndex = 6
        LinkLabel4.TabStop = True
        LinkLabel4.Text = "Register"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F)
        Label3.Location = New Point(93, 291)
        Label3.Name = "Label3"
        Label3.Size = New Size(143, 17)
        Label3.TabIndex = 5
        Label3.Text = "Don't have an account?"
        ' 
        ' loginButton
        ' 
        loginButton.BackColor = Color.ForestGreen
        loginButton.FlatAppearance.BorderSize = 0
        loginButton.FlatStyle = FlatStyle.Flat
        loginButton.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        loginButton.ForeColor = Color.White
        loginButton.Location = New Point(81, 227)
        loginButton.Name = "loginButton"
        loginButton.Size = New Size(235, 46)
        loginButton.TabIndex = 4
        loginButton.Text = "LOGIN"
        loginButton.UseVisualStyleBackColor = False
        ' 
        ' passwordBox
        ' 
        passwordBox.BorderStyle = BorderStyle.FixedSingle
        passwordBox.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        passwordBox.Location = New Point(82, 177)
        passwordBox.Margin = New Padding(3, 3, 3, 20)
        passwordBox.Name = "passwordBox"
        passwordBox.PasswordChar = "*"c
        passwordBox.PlaceholderText = "   Password"
        passwordBox.Size = New Size(234, 27)
        passwordBox.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(136, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 50)
        Label1.TabIndex = 2
        Label1.Text = "LOGIN"
        ' 
        ' emailBox
        ' 
        emailBox.BorderStyle = BorderStyle.FixedSingle
        emailBox.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        emailBox.Location = New Point(81, 132)
        emailBox.Margin = New Padding(3, 3, 3, 20)
        emailBox.Name = "emailBox"
        emailBox.PlaceholderText = "   Email"
        emailBox.Size = New Size(235, 27)
        emailBox.TabIndex = 1
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1284, 661)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents emailBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents passwordBox As TextBox
    Friend WithEvents loginButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents menu As Button
End Class
