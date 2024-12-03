Imports System.IO
Imports MySql.Data.MySqlClient
Imports Nature_s_Basket.login

Public Class displayProducts

    ' Property to hold the category name
    Public Property categoryName As String
    Dim userId As Integer = CurrentUser.UserId
    Private SelectedItems As New List(Of DataRow)()


    ' Method to update the category and reload products
    Public Sub UpdateCategory(categoryName As String)
        Me.categoryName = categoryName
        categoryText.Text = categoryName.ToUpper() & "S"
        LoadProducts()
    End Sub



    ' Method to load products from the database
    Private Sub LoadProducts()

        isLoggedIn = login.isLoggedIn

        If CurrentUser.UserId <= 0 Then
            ' Hide "Logout" and "My Purchases" buttons if no user is logged in
            LinkLabel11.Visible = False
            myPurchaseLinl.Visible = False
        End If

        Dim query As String = "SELECT id, name, price, quantity, image, supplier, unit 
                       FROM products 
                       WHERE category = @CategoryName"

        Dim dbConnection As New dbcon()

        Using connection As MySqlConnection = dbConnection.GetDatabaseConnection()
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@CategoryName", categoryName)

            Try
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                ' Clear existing controls in FlowLayoutPanel
                FlowLayoutPanel1.Controls.Clear()

                ' Iterate through each product and populate the template
                For Each row As DataRow In dt.Rows
                    ' Create a new instance of the product card template
                    Dim productCard As New Panel With {
                        .Size = New Size(256, 382),
                        .BackColor = Color.DarkGreen,
                        .Margin = New Padding(20)
                    }

                    ' Image Panel
                    Dim imagePanel As New Panel With {
                        .Size = New Size(235, 287),
                        .BackColor = Color.White,
                        .Location = New Point(11, 13)
                    }

                    ' PictureBox for product image
                    Dim productPictureBox As New PictureBox With {
                        .Size = New Size(235, 226),
                        .Location = New Point(0, 0),
                        .SizeMode = PictureBoxSizeMode.StretchImage
                    }

                    ' Set product image from LONGBLOB
                    Dim imageData As Byte() = CType(row("image"), Byte())
                    If imageData IsNot Nothing AndAlso imageData.Length > 0 Then
                        Using ms As New MemoryStream(imageData)
                            productPictureBox.Image = Image.FromStream(ms)
                        End Using
                    End If

                    ' Add PictureBox to image panel
                    imagePanel.Controls.Add(productPictureBox)

                    ' Add imagePanel to productCard
                    productCard.Controls.Add(imagePanel)

                    ' Product Name Label
                    Dim productName As New Label With {
                        .Text = row("name").ToString().ToUpper(),
                        .Font = New Font("Arial", 12, FontStyle.Bold),
                        .ForeColor = Color.DarkGreen,
                        .Location = New Point(4, 233),
                        .Size = New Size(95, 21)
                    }
                    imagePanel.Controls.Add(productName)

                    ' Product Supplier Label
                    Dim productSupplier As New Label With {
                        .Text = row("supplier").ToString().ToUpper(),
                        .Font = New Font("Arial", 10, FontStyle.Bold),
                        .ForeColor = Color.Black,
                        .Location = New Point(5, 258),
                        .Size = New Size(110, 17)
                    }
                    imagePanel.Controls.Add(productSupplier)

                    ' Product Price Label
                    Dim productPrice As New Label With {
                        .Text = "₱ " & row("price").ToString() & "/" & row("unit"),
                        .Font = New Font("Segoe ui", 10, FontStyle.Bold),
                        .ForeColor = Color.Green,
                        .Location = New Point(121, 232),
                        .Size = New Size(100, 21)
                    }
                    imagePanel.Controls.Add(productPrice)

                    ' Product Quantity Label
                    Dim productQuantity As New Label With {
                        .Text = row("quantity").ToString() & " pcs avail",
                        .Font = New Font("Segoe ui", 10, FontStyle.Bold),
                        .ForeColor = Color.Black,
                        .Location = New Point(121, 255),
                        .Size = New Size(100, 21)
                    }
                    imagePanel.Controls.Add(productQuantity)

                    ' Quantity Label
                    Dim quantityLabel As New Label With {
                        .Text = "QUANTITY",
                        .Font = New Font("Segoe ui", 14, FontStyle.Bold),
                        .ForeColor = Color.White,
                        .Location = New Point(10, 306),
                        .Size = New Size(108, 25)
                    }
                    productCard.Controls.Add(quantityLabel)

                    ' Quantity Controls
                    Dim minusQuantity As New Button With {
                        .Size = New Size(32, 25),
                        .Text = "-",
                        .ForeColor = Color.White,
                        .BackColor = Color.Transparent,
                        .FlatStyle = FlatStyle.Flat,
                        .Location = New Point(123, 307)
                    }
                    minusQuantity.FlatAppearance.BorderSize = 3
                    minusQuantity.FlatAppearance.BorderColor = Color.OliveDrab

                    Dim addQuantity As New Button With {
                        .Size = New Size(32, 25),
                        .Text = "+",
                        .ForeColor = Color.White,
                        .BackColor = Color.Transparent,
                        .FlatStyle = FlatStyle.Flat,
                        .Location = New Point(212, 307)
                    }
                    addQuantity.FlatAppearance.BorderSize = 3
                    addQuantity.FlatAppearance.BorderColor = Color.OliveDrab

                    Dim quantityNumber As New Label With {
                        .Text = "1",
                        .Font = New Font("Segoe ui", 11, FontStyle.Bold),
                        .ForeColor = Color.White,
                        .Location = New Point(168, 311),
                        .Size = New Size(100, 17)
                    }

                    ' Add quantity controls to productCard
                    productCard.Controls.Add(minusQuantity)
                    productCard.Controls.Add(addQuantity)
                    productCard.Controls.Add(quantityNumber)

                    ' Event Handlers for Quantity Controls
                    AddHandler addQuantity.Click, Sub(sender As Object, e As EventArgs)
                                                      Dim currentQuantity As Integer = Integer.Parse(quantityNumber.Text)
                                                      quantityNumber.Text = (currentQuantity + 1).ToString()
                                                  End Sub

                    AddHandler minusQuantity.Click, Sub(sender As Object, e As EventArgs)
                                                        Dim currentQuantity As Integer = Integer.Parse(quantityNumber.Text)
                                                        If currentQuantity > 0 Then
                                                            quantityNumber.Text = (currentQuantity - 1).ToString()
                                                        End If
                                                    End Sub

                    ' Add To Cart Button
                    Dim addToCartButton As New Button With {
                        .Text = "ADD TO CART",
                        .Size = New Size(104, 34),
                        .ForeColor = Color.White,
                        .BackColor = Color.Transparent,
                        .FlatStyle = FlatStyle.Flat,
                        .Location = New Point(13, 340)
                    }
                    addToCartButton.FlatAppearance.BorderSize = 3
                    addToCartButton.FlatAppearance.BorderColor = Color.OliveDrab

                    ' Add event to AddToCart button
                    AddHandler addToCartButton.Click, Sub(sender As Object, e As EventArgs)
                                                          Dim productId As Integer = Convert.ToInt32(row("id"))
                                                          Dim productNameStr As String = row("name").ToString()
                                                          Dim productPriceDec As Decimal = Convert.ToDecimal(row("price"))
                                                          Dim quantityInt As Integer = Integer.Parse(quantityNumber.Text)
                                                          Dim supplierStr As String = row("supplier").ToString()
                                                          Dim unitStr As String = row("unit").ToString()

                                                          If quantityInt > 0 Then
                                                              AddToCart(productId, productNameStr, productPriceDec, quantityInt, imageData, supplierStr, unitStr)
                                                          Else
                                                              MessageBox.Show("Quantity must be greater than 0.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                                          End If
                                                      End Sub

                    productCard.Controls.Add(addToCartButton)

                    ' Buy Now Button
                    Dim buyNowButton As New Button With {
                        .Text = "BUY NOW",
                        .Size = New Size(120, 33),
                        .ForeColor = Color.White,
                        .BackColor = Color.OliveDrab,
                        .FlatStyle = FlatStyle.Flat,
                        .Location = New Point(123, 340)
                    }
                    buyNowButton.FlatAppearance.BorderSize = 0

                    ' Event Handler for "Buy Now" Button
                    AddHandler buyNowButton.Click, Sub(sender As Object, e As EventArgs)

                                                       If Not isLoggedIn Then
                                                           ' If the user is not logged in, show the login text and prompt to log in
                                                           MessageBox.Show("Please log in to checkout this product", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                                           Return
                                                       End If

                                                       ' Extract product details from the row (product data)
                                                       Dim productId As Integer = Convert.ToInt32(row("id"))
                                                       Dim productNameStr As String = row("name").ToString()
                                                       Dim productPriceDec As Decimal = Convert.ToDecimal(row("price"))
                                                       Dim quantityInt As Integer = Integer.Parse(quantityNumber.Text)
                                                       Dim supplierStr As String = row("supplier").ToString()
                                                       Dim unitStr As String = row("unit").ToString()

                                                       ' Check if the quantity is valid
                                                       If quantityInt > 0 Then
                                                           ' Create a DataTable to represent the selected product
                                                           Dim selectedProductDt As New DataTable()
                                                           selectedProductDt.Columns.Add("product_id", GetType(Integer))
                                                           selectedProductDt.Columns.Add("product_name", GetType(String))
                                                           selectedProductDt.Columns.Add("quantity", GetType(Integer))
                                                           selectedProductDt.Columns.Add("price", GetType(Decimal))
                                                           selectedProductDt.Columns.Add("total_price", GetType(Decimal))
                                                           selectedProductDt.Columns.Add("supplier", GetType(String))
                                                           selectedProductDt.Columns.Add("unit", GetType(String))
                                                           selectedProductDt.Columns.Add("product_image", GetType(Byte()))

                                                           ' Create a DataRow to hold the selected product
                                                           Dim selectedRow As DataRow = selectedProductDt.NewRow()
                                                           selectedRow("product_id") = productId
                                                           selectedRow("product_name") = productNameStr
                                                           selectedRow("quantity") = quantityInt
                                                           selectedRow("price") = productPriceDec
                                                           selectedRow("total_price") = productPriceDec * quantityInt
                                                           selectedRow("supplier") = supplierStr
                                                           selectedRow("unit") = unitStr
                                                           selectedRow("product_image") = imageData
                                                           selectedProductDt.Rows.Add(selectedRow)

                                                           ' Convert DataTable to List(Of DataRow)
                                                           Dim selectedItems As New List(Of DataRow)()
                                                           For Each dr As DataRow In selectedProductDt.Rows
                                                               selectedItems.Add(dr)
                                                           Next

                                                           ' Pass the selected item to the displayOrdervb form
                                                           Dim checkoutForm As New displayOrdervb(selectedItems) ' Pass the list instead of DataTable
                                                           checkoutForm.Show()
                                                           Me.Hide()
                                                       Else
                                                           MessageBox.Show("Quantity must be greater than 0.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                                       End If
                                                   End Sub

                    ' Add Buy Now Button to product card
                    productCard.Controls.Add(buyNowButton)


                    ' Add productCard to FlowLayoutPanel
                    FlowLayoutPanel1.Controls.Add(productCard)
                Next

            Catch ex As MySqlException
                MessageBox.Show("An error occurred while loading products: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' AddToCart Method
    Private Sub AddToCart(productId As Integer, productName As String, price As Decimal, quantity As Integer, productImage As Byte(), supplier As String, unit As String)
        If Not isLoggedIn Then
            ' If the user is not logged in, show the login text and prompt to log in
            MessageBox.Show("Please log in to add products to your cart.", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim dbConnection As New dbcon()

        Using connection As MySqlConnection = dbConnection.GetDatabaseConnection()
            If connection.State <> ConnectionState.Open Then connection.Open()

            Try
                ' Check if the product already exists in the cart for the current user
                Dim checkQuery As String = "SELECT quantity FROM cart WHERE product_id = @ProductId AND user_id = @UserId"
                Dim cmdCheck As New MySqlCommand(checkQuery, connection)
                cmdCheck.Parameters.AddWithValue("@ProductId", productId)
                cmdCheck.Parameters.AddWithValue("@UserId", userId)

                Dim existingQuantity As Object = cmdCheck.ExecuteScalar()

                If existingQuantity IsNot Nothing Then
                    ' Product exists, update the quantity
                    Dim updateQuery As String = "UPDATE cart SET quantity = quantity + @NewQuantity, total_price = total_price + (@NewQuantity * @Price) WHERE product_id = @ProductId AND user_id = @UserId"
                    Dim cmdUpdate As New MySqlCommand(updateQuery, connection)
                    cmdUpdate.Parameters.AddWithValue("@NewQuantity", quantity)
                    cmdUpdate.Parameters.AddWithValue("@Price", price)
                    cmdUpdate.Parameters.AddWithValue("@ProductId", productId)
                    cmdUpdate.Parameters.AddWithValue("@UserId", userId)

                    cmdUpdate.ExecuteNonQuery()
                    MessageBox.Show("Product quantity updated in the cart successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    ' Product does not exist, insert a new record
                    Dim insertQuery As String = "INSERT INTO cart (product_id, product_name, price, supplier, unit, quantity, total_price, product_image, user_id) 
                                             VALUES (@ProductId, @ProductName, @Price, @Supplier, @Unit, @Quantity, @TotalPrice, @ProductImage, @UserId)"
                    Dim cmdInsert As New MySqlCommand(insertQuery, connection)
                    cmdInsert.Parameters.AddWithValue("@ProductId", productId)
                    cmdInsert.Parameters.AddWithValue("@ProductName", productName)
                    cmdInsert.Parameters.AddWithValue("@Price", price)
                    cmdInsert.Parameters.AddWithValue("@Supplier", supplier)
                    cmdInsert.Parameters.AddWithValue("@Unit", unit)
                    cmdInsert.Parameters.AddWithValue("@Quantity", quantity)
                    cmdInsert.Parameters.AddWithValue("@TotalPrice", price * quantity)
                    cmdInsert.Parameters.AddWithValue("@ProductImage", productImage)
                    cmdInsert.Parameters.AddWithValue("@UserId", userId)

                    cmdInsert.ExecuteNonQuery()
                    MessageBox.Show("Product added to cart successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As MySqlException
                MessageBox.Show("An error occurred while adding the product to the cart: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    Private Sub loginText_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles loginText.LinkClicked
        Dim loginForm As New login()
        loginForm.Show()
        Me.Hide()
    End Sub

    Private Sub displayProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If isLoggedIn Then
            loginText.Visible = False
        Else
            loginText.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim myCart As New cart()
        myCart.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        menuPanel.Visible = Not menuPanel.Visible
    End Sub

    Private Sub vegetablesLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles vegetablesLink.LinkClicked
        Dim displayProductsForm As New displayProducts()
        displayProductsForm.UpdateCategory("Vegetable")
        displayProductsForm.Show()
        Me.Hide()
    End Sub

    Private Sub fruitsLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles fruitsLink.LinkClicked
        Dim displayProductsForm As New displayProducts()
        displayProductsForm.UpdateCategory("Fruit")
        displayProductsForm.Show()
        Me.Hide()
    End Sub

    Private Sub eggsLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles eggsLink.LinkClicked
        Dim displayProductsForm As New displayProducts()
        displayProductsForm.UpdateCategory("Egg")
        displayProductsForm.Show()
        Me.Hide()
    End Sub

    Private Sub meatsLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles meatsLink.LinkClicked
        Dim displayProductsForm As New displayProducts()
        displayProductsForm.UpdateCategory("Meat")
        displayProductsForm.Show()
        Me.Hide()
    End Sub

    Private Sub herbsLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles herbsLink.LinkClicked
        Dim displayProductsForm As New displayProducts()
        displayProductsForm.UpdateCategory("Herb")
        displayProductsForm.Show()
        Me.Hide()
    End Sub

    Private Sub seafoodsLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles seafoodsLink.LinkClicked
        Dim displayProductsForm As New displayProducts()
        displayProductsForm.UpdateCategory("Seafood")
        displayProductsForm.Show()
        Me.Hide()
    End Sub

    Private Sub myPurchaseLinl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles myPurchaseLinl.LinkClicked
        Dim myPurchase As New myOrders()
        myPurchase.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel11_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel11.LinkClicked
        login.isLoggedIn = False

        MessageBox.Show("You have successfully logged out.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim loginForm As New login()
        loginForm.Show()

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
