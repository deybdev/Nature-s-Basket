Imports MySql.Data.MySqlClient
Imports System.IO
Imports Nature_s_Basket.login

Public Class Cart

    Dim userId As Integer = CurrentUser.UserId

    Private Function IsUserLoggedIn() As Boolean
        ' Check if the user is logged in based on their session or credentials
        ' For demonstration, assume CurrentUser.UserId is set only when logged in
        Return CurrentUser.UserId > 0
    End Function

    ' Function to load cart items for the current user
    Private Sub LoadCart()

        If Not IsUserLoggedIn() Then
            logoutLink.Visible = False
            myPurchaseLink.Visible = False
        Else
            logoutLink.Visible = True
            myPurchaseLink.Visible = True
        End If

        ' SQL query to retrieve cart items for the current user
        Dim query As String = "SELECT c.id, c.product_name, c.price, c.supplier, c.unit, c.supplier, c.quantity, c.total_price, c.product_image 
                           FROM cart c
                           WHERE c.user_id = @UserId"

        ' Create a new database connection
        Dim dbConnection As New dbcon()

        Using connection As MySqlConnection = dbConnection.GetDatabaseConnection()
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@UserId", userId)

            Try
                ' Data adapter to fill a DataTable with cart items
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                ' Clear existing controls in the FlowLayoutPanel to update UI
                FlowLayoutPanel1.Controls.Clear()

                ' Check if the DataTable is empty (no cart items found)
                If dt.Rows.Count = 0 Then
                    ' Display a message if the cart is empty
                    Dim emptyCartMessage As New Label With {
                    .Text = "Your cart is empty.",
                    .Font = New Font("Arial", 14, FontStyle.Bold),
                    .ForeColor = Color.White,
                    .AutoSize = True,
                    .Location = New Point(FlowLayoutPanel1.Width / 2 - 80, FlowLayoutPanel1.Height / 2 - 15)
                }
                    FlowLayoutPanel1.Controls.Add(emptyCartMessage)
                Else
                    ' Loop through each row in the DataTable and create UI components for cart items
                    For Each row As DataRow In dt.Rows

                        Dim totalPrice As Decimal = row("price") * row("quantity")

                        ' Create a panel to hold the product's cart information
                        Dim cartItemPanel As New Panel With {
                        .Size = New Size(936, 106),
                        .BackColor = Color.DarkGreen,
                        .Margin = New Padding(5)
                    }

                        ' Image Panel for the product image
                        Dim cartPanel2 As New Panel With {
                        .Size = New Size(911, 83),
                        .BackColor = Color.White,
                        .Location = New Point(13, 13)
                    }

                        ' PictureBox for product image
                        Dim productPictureBox As New PictureBox With {
                        .Size = New Size(137, 91),
                        .Location = New Point(77, -3),
                        .SizeMode = PictureBoxSizeMode.StretchImage
                    }

                        ' Set product image from LONGBLOB
                        Dim imageData As Byte() = CType(row("product_image"), Byte())
                        If imageData IsNot Nothing AndAlso imageData.Length > 0 Then
                            Using ms As New MemoryStream(imageData)
                                productPictureBox.Image = Image.FromStream(ms)
                            End Using
                        End If

                        ' Add PictureBox to image panel
                        cartPanel2.Controls.Add(productPictureBox)

                        ' Add imagePanel to cartItemPanel
                        cartItemPanel.Controls.Add(cartPanel2)

                        ' Product Name Label
                        Dim productName As New Label With {
                        .Text = row("product_name").ToString().ToUpper(),
                        .Font = New Font("Arial", 10, FontStyle.Bold),
                        .ForeColor = Color.DarkGreen,
                        .Location = New Point(230, 20)
                    }
                        cartPanel2.Controls.Add(productName)

                        ' Product Supplier Label
                        Dim productSupplier As New Label With {
                        .Text = row("supplier").ToString(),
                        .Font = New Font("Arial", 10, FontStyle.Bold),
                        .ForeColor = Color.Black,
                        .Location = New Point(232, 45),
                        .Size = New Size(120, 17)
                    }
                        cartPanel2.Controls.Add(productSupplier)

                        ' Checkbox to select product
                        Dim checkCart As New CheckBox With {
                        .Location = New Point(29, 37),
                        .AutoSize = True,
                        .Checked = False,
                        .Tag = row("id")
                    }

                        cartPanel2.Controls.Add(checkCart)

                        ' Product Price Label
                        Dim productPrice As New Label With {
                        .Text = "₱ " & row("price").ToString() & "/" & row("unit").ToString(),
                        .Font = New Font("Segoe ui", 10, FontStyle.Bold),
                        .ForeColor = Color.Black,
                        .Location = New Point(409, 31),
                        .Size = New Size(120, 17)
                    }
                        cartPanel2.Controls.Add(productPrice)

                        ' Quantity Label
                        Dim quantityLabel As New Label With {
                        .Text = row("quantity").ToString(),
                        .Font = New Font("Segoe ui", 12, FontStyle.Bold),
                        .ForeColor = Color.Black,
                        .Location = New Point(596, 32),
                        .Size = New Size(15, 17)
                    }
                        cartPanel2.Controls.Add(quantityLabel)

                        ' Total Price Label (calculated as price * quantity)
                        Dim totalPriceLabel As New Label With {
                        .Text = " ₱ " & row("total_price").ToString(),
                        .Font = New Font("Segoe ui", 12, FontStyle.Bold),
                        .ForeColor = Color.Black,
                        .Location = New Point(713, 29)
                    }
                        cartPanel2.Controls.Add(totalPriceLabel)

                        Dim totalLabel As New Label With {
                        .Text = " Total ",
                        .Font = New Font("Segoe ui", 8, FontStyle.Regular),
                        .ForeColor = Color.Black,
                        .Location = New Point(740, 15),
                        .Size = New Size(37, 17)
                    }
                        cartPanel2.Controls.Add(totalLabel)

                        ' Remove from Cart Button
                        Dim removeFromCartButton As New Button With {
                        .Text = "Remove",
                        .Size = New Size(75, 27),
                        .ForeColor = Color.Red,
                        .BackColor = Color.Transparent,
                        .FlatStyle = FlatStyle.Flat,
                        .Location = New Point(823, 27)
                    }
                        removeFromCartButton.FlatAppearance.BorderSize = 0

                        ' + from Cart Button (increase quantity)
                        Dim addQuantityCart As New Button With {
                        .Text = "+",
                        .Size = New Size(32, 26),
                        .ForeColor = Color.White,
                        .BackColor = Color.Green,
                        .FlatStyle = FlatStyle.Flat,
                        .Location = New Point(544, 26)
                    }
                        addQuantityCart.FlatAppearance.BorderSize = 1

                        ' - from Cart Button (decrease quantity)
                        Dim minusQuantityCart As New Button With {
                        .Text = "-",
                        .Size = New Size(32, 26),
                        .ForeColor = Color.White,
                        .BackColor = Color.Green,
                        .FlatStyle = FlatStyle.Flat,
                        .Location = New Point(626, 27)
                    }
                        minusQuantityCart.FlatAppearance.BorderSize = 1

                        ' Event handler for "+" button
                        AddHandler addQuantityCart.Click, Sub(sender As Object, e As EventArgs)
                                                              Dim cartItemId As Integer = Convert.ToInt32(row("id"))
                                                              UpdateQuantity(cartItemId, 1)  ' Increase quantity by 1
                                                          End Sub

                        ' Event handler for "-" button
                        AddHandler minusQuantityCart.Click, Sub(sender As Object, e As EventArgs)
                                                                Dim cartItemId As Integer = Convert.ToInt32(row("id"))
                                                                UpdateQuantity(cartItemId, -1)  ' Decrease quantity by 1
                                                            End Sub

                        ' Event to remove item from cart
                        AddHandler removeFromCartButton.Click, Sub(sender As Object, e As EventArgs)
                                                                   Dim cartItemId As Integer = Convert.ToInt32(row("id"))
                                                                   RemoveFromCart(cartItemId)
                                                               End Sub

                        cartPanel2.Controls.Add(removeFromCartButton)
                        cartPanel2.Controls.Add(addQuantityCart)
                        cartPanel2.Controls.Add(minusQuantityCart)

                        ' Add cartItemPanel to the FlowLayoutPanel
                        FlowLayoutPanel1.Controls.Add(cartItemPanel)
                    Next
                End If

            Catch ex As MySqlException
                MessageBox.Show("An error occurred while loading the cart items: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    ' Function to update the quantity and total price
    Private Sub UpdateQuantity(cartItemId As Integer, quantityChange As Integer)
        Dim dbConnection As New dbcon()

        Using connection As MySqlConnection = dbConnection.GetDatabaseConnection()
            If connection.State <> ConnectionState.Open Then connection.Open()

            Try
                ' Get the current quantity and price from the database
                Dim selectQuery As String = "SELECT price, quantity FROM cart WHERE id = @CartItemId AND user_id = @UserId"
                Dim selectCmd As New MySqlCommand(selectQuery, connection)
                selectCmd.Parameters.AddWithValue("@CartItemId", cartItemId)
                selectCmd.Parameters.AddWithValue("@UserId", userId)

                Dim reader As MySqlDataReader = selectCmd.ExecuteReader()
                If reader.Read() Then
                    Dim currentQuantity As Integer = reader.GetInt32("quantity")
                    Dim price As Decimal = reader.GetDecimal("price")
                    reader.Close()

                    ' Calculate the new quantity
                    Dim newQuantity As Integer = currentQuantity + quantityChange
                    If newQuantity < 1 Then
                        MessageBox.Show("Quantity cannot be less than 1.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If

                    ' Calculate the new total price
                    Dim totalPrice As Decimal = price * newQuantity

                    ' Update the quantity and total price in the database
                    Dim updateQuery As String = "UPDATE cart SET quantity = @Quantity, total_price = @TotalPrice WHERE id = @CartItemId AND user_id = @UserId"
                    Dim updateCmd As New MySqlCommand(updateQuery, connection)
                    updateCmd.Parameters.AddWithValue("@Quantity", newQuantity)
                    updateCmd.Parameters.AddWithValue("@TotalPrice", totalPrice)
                    updateCmd.Parameters.AddWithValue("@CartItemId", cartItemId)
                    updateCmd.Parameters.AddWithValue("@UserId", userId)

                    ' Execute the update
                    updateCmd.ExecuteNonQuery()

                    ' Refresh the cart to show updated values
                    LoadCart()
                End If
            Catch ex As MySqlException
                MessageBox.Show("An error occurred while updating the cart: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    ' Function to remove an item from the cart
    Private Sub RemoveFromCart(cartItemId As Integer)
        Dim dbConnection As New dbcon()

        Using connection As MySqlConnection = dbConnection.GetDatabaseConnection()
            If connection.State <> ConnectionState.Open Then connection.Open()

            Try
                ' SQL query to remove the product from the cart
                Dim query As String = "DELETE FROM cart WHERE id = @CartItemId AND user_id = @UserId"
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@CartItemId", cartItemId)
                cmd.Parameters.AddWithValue("@UserId", userId)

                ' Execute the query
                cmd.ExecuteNonQuery()

                ' Refresh the cart display after removal
                LoadCart()

                MessageBox.Show("Product removed from the cart successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As MySqlException
                MessageBox.Show("An error occurred while removing the product from the cart: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Load the cart when the form is loaded
    Private Sub cart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCart()
    End Sub

    Private Sub selectAll_CheckedChanged(sender As Object, e As EventArgs) Handles selectAll.CheckedChanged
        ' Iterate through each panel (cart item) in the FlowLayoutPanel
        For Each control As Control In FlowLayoutPanel1.Controls
            If TypeOf control Is Panel Then
                ' Find the inner panel (cartPanel2) that contains the checkbox
                Dim innerPanel As Panel = control.Controls.OfType(Of Panel)().FirstOrDefault()

                If innerPanel IsNot Nothing Then
                    ' Find the checkbox in the inner panel and set its state
                    Dim checkbox As CheckBox = innerPanel.Controls.OfType(Of CheckBox)().FirstOrDefault()
                    If checkbox IsNot Nothing Then
                        checkbox.Checked = selectAll.Checked
                    End If
                End If
            End If
        Next
    End Sub

    ' Helper method to update CheckBox state recursively
    Private Sub UpdateCheckboxState(parent As Control, isChecked As Boolean)
        ' Iterate through all child controls of the given parent
        For Each childControl As Control In parent.Controls
            ' If the control is a CheckBox, update its Checked property
            If TypeOf childControl Is CheckBox Then
                Dim productCheckbox As CheckBox = CType(childControl, CheckBox)
                productCheckbox.Checked = isChecked
            ElseIf TypeOf childControl Is Panel Then
                ' If the control is a Panel, search its child controls recursively
                UpdateCheckboxState(childControl, isChecked)
            End If
        Next
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        ' List to hold IDs of selected items for deletion
        Dim selectedCartItemIds As New List(Of Integer)

        ' Iterate through each control in the FlowLayoutPanel
        For Each control As Control In FlowLayoutPanel1.Controls
            If TypeOf control Is Panel Then
                ' Find the inner panel (cartPanel2) that contains the checkbox
                Dim innerPanel As Panel = control.Controls.OfType(Of Panel)().FirstOrDefault()

                If innerPanel IsNot Nothing Then
                    ' Find the checkbox in the inner panel
                    Dim productCheckbox As CheckBox = innerPanel.Controls.OfType(Of CheckBox)().FirstOrDefault()

                    If productCheckbox IsNot Nothing AndAlso productCheckbox.Checked Then
                        Dim cartItemId As Integer
                        If Integer.TryParse(productCheckbox.Tag.ToString(), cartItemId) Then
                            selectedCartItemIds.Add(cartItemId)
                        Else
                            MessageBox.Show("Invalid cart item ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                End If
            End If
        Next


        ' If no items were selected, show a message and exit
        If selectedCartItemIds.Count = 0 Then
            MessageBox.Show("No items selected for deletion.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Proceed with deletion for selected items
        DeleteSelectedCartItems(selectedCartItemIds)
    End Sub

    Private Sub DeleteSelectedCartItems(selectedCartItemIds As List(Of Integer))
        Dim dbConnection As New dbcon()

        Using connection As MySqlConnection = dbConnection.GetDatabaseConnection()
            If connection.State <> ConnectionState.Open Then connection.Open()

            Dim transaction As MySqlTransaction = connection.BeginTransaction()
            Try
                ' Delete each selected item
                For Each cartItemId As Integer In selectedCartItemIds
                    Dim query As String = "DELETE FROM cart WHERE id = @CartItemId AND user_id = @UserId"
                    Dim cmd As New MySqlCommand(query, connection, transaction)
                    cmd.Parameters.AddWithValue("@CartItemId", cartItemId)
                    cmd.Parameters.AddWithValue("@UserId", CurrentUser.UserId)
                    cmd.ExecuteNonQuery()
                Next

                ' Commit the transaction
                transaction.Commit()

                ' Refresh the cart display
                LoadCart()

                MessageBox.Show("Selected items deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As MySqlException
                ' Rollback the transaction in case of an error
                transaction.Rollback()
                MessageBox.Show("An error occurred while deleting items: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub checkOutBtn_Click(sender As Object, e As EventArgs) Handles checkOutBtn.Click
        ' List to hold the selected cart items
        Dim selectedCartItems As New List(Of DataRow)

        ' Iterate through each control in the FlowLayoutPanel
        For Each control As Control In FlowLayoutPanel1.Controls
            If TypeOf control Is Panel Then
                ' Find the inner panel (cartPanel2) that contains the checkbox
                Dim innerPanel As Panel = control.Controls.OfType(Of Panel)().FirstOrDefault()

                If innerPanel IsNot Nothing Then
                    ' Find the checkbox in the inner panel
                    Dim productCheckbox As CheckBox = innerPanel.Controls.OfType(Of CheckBox)().FirstOrDefault()

                    If productCheckbox IsNot Nothing AndAlso productCheckbox.Checked Then
                        ' Retrieve the cart item's ID from the checkbox's Tag property
                        Dim cartItemId As Integer
                        If Integer.TryParse(productCheckbox.Tag.ToString(), cartItemId) Then
                            ' Query the database or retrieve the DataRow associated with this cart item
                            Dim dbConnection As New dbcon()
                            Using connection As MySqlConnection = dbConnection.GetDatabaseConnection()
                                If connection.State <> ConnectionState.Open Then connection.Open()

                                Dim query As String = "SELECT * FROM cart WHERE id = @CartItemId AND user_id = @UserId"
                                Dim cmd As New MySqlCommand(query, connection)
                                cmd.Parameters.AddWithValue("@CartItemId", cartItemId)
                                cmd.Parameters.AddWithValue("@UserId", CurrentUser.UserId)

                                Dim adapter As New MySqlDataAdapter(cmd)
                                Dim dt As New DataTable()
                                adapter.Fill(dt)

                                If dt.Rows.Count > 0 Then
                                    selectedCartItems.Add(dt.Rows(0))
                                End If
                            End Using
                        End If
                    End If
                End If
            End If
        Next

        ' If no items are selected, display a message
        If selectedCartItems.Count = 0 Then
            MessageBox.Show("No items selected for checkout.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Open the next form or functionality to display the selected items
        Dim orderDisplayForm As New displayOrdervb(selectedCartItems)
        orderDisplayForm.Show()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim myCart As New cart()
        myCart.Show()
        Me.Hide()
    End Sub

    Private Sub myPurchaseLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles myPurchaseLink.LinkClicked
        Dim myPurchase As New myOrders()
        myPurchase.Show()
        Me.Hide()
    End Sub

    Private Sub logoutLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles logoutLink.LinkClicked
        login.isLoggedIn = False

        MessageBox.Show("You have successfully logged out.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim loginForm As New login()
        loginForm.Show()

        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim land As New landing
        land.Show()
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
