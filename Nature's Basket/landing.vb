Public Class landing


    Public Sub New()
        Me.New(login.isLoggedIn)
    End Sub

    Public Sub New(ByVal isLoggedIn As Boolean)
        InitializeComponent()

        isLoggedIn = login.isLoggedIn

        LinkLabel3.Visible = Not isLoggedIn
        LinkLabel11.Visible = isLoggedIn
        myPurchaseLinl.Visible = isLoggedIn
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Dim loginForm As New login()
        loginForm.Show()

        Me.Hide()
    End Sub

    Private Sub menu_Click(sender As Object, e As EventArgs) Handles menu.Click
        menuPanel.Visible = Not menuPanel.Visible
    End Sub

    Private Sub LinkLabel11_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel11.LinkClicked
        login.isLoggedIn = False

        MessageBox.Show("You have successfully logged out.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim loginForm As New login()
        loginForm.Show()

        Me.Hide()
    End Sub

    Private Sub vegetablesLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles vegetablesLink.LinkClicked
        Dim displayProductsForm As New displayProducts()
        displayProductsForm.UpdateCategory("Vegetable")
        displayProductsForm.Show()
        Me.Hide()
    End Sub

    Private Sub fruitsLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles fruitsLink.LinkClicked
        Dim displayProductsForm As New displayProducts()
        displayProductsForm.UpdateCategory("FRUITS")
        displayProductsForm.Show()
        Me.Hide()
    End Sub

    Private Sub eggsLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles eggsLink.LinkClicked
        Dim displayProductsForm As New displayProducts()
        displayProductsForm.UpdateCategory("EGGS")
        displayProductsForm.Show()
        Me.Hide()
    End Sub

    Private Sub meatsLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles meatsLink.LinkClicked
        Dim displayProductsForm As New displayProducts()
        displayProductsForm.UpdateCategory("MEATS")
        displayProductsForm.Show()
        Me.Hide()
    End Sub

    Private Sub herbsLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles herbsLink.LinkClicked
        Dim displayProductsForm As New displayProducts()
        displayProductsForm.UpdateCategory("HERBS")
        displayProductsForm.Show()
        Me.Hide()
    End Sub

    Private Sub seafoodsLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles seafoodsLink.LinkClicked
        Dim displayProductsForm As New displayProducts()
        displayProductsForm.UpdateCategory("Seafood")
        displayProductsForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If Not login.isLoggedIn Then
            ' Show a message indicating the user must log in
            MessageBox.Show("Please log in to access your cart.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim myCart As New cart()
        myCart.Show()
        Me.Hide()
    End Sub

    Private Sub myPurchaseLinl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles myPurchaseLinl.LinkClicked
        Dim myPurchase As New myOrders()
        myPurchase.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Get the search keyword from the searchBox TextBox
        Dim searchKeyword As String = searchBox.Text.Trim()

        ' Check if the searchKeyword is not empty
        If String.IsNullOrEmpty(searchKeyword) Then
            MessageBox.Show("Please enter a keyword to search.", "Search Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Create an instance of the displaySearch form
        Dim searchForm As New displaySearch(searchKeyword)

        ' Show the displaySearch form
        searchForm.Show()

        ' Optionally, hide the current form if needed
        Me.Hide()
    End Sub

    Private Sub searchBox_KeyDown(sender As Object, e As KeyEventArgs) Handles searchBox.KeyDown
        ' Check if the pressed key is the Enter key
        If e.KeyCode = Keys.Enter Then
            ' Trigger the Button1_Click event
            Button1_Click(sender, e)

            ' Prevent the beep sound on Enter key press
            e.SuppressKeyPress = True
        End If
    End Sub


End Class