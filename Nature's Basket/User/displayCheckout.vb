Imports System.Data.Common
Imports System.IO
Imports Nature_s_Basket.login
Imports MySql.Data.MySqlClient

Public Class displayOrdervb
    Private SelectedItems As List(Of DataRow)
    Dim userId As Integer = CurrentUser.UserId


    ' Constructor to accept selected cart items
    Public Sub New(items As List(Of DataRow))
        InitializeComponent()
        SelectedItems = items
    End Sub


    ' Load event to display the selected items
    Private Sub displayOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Retrieve information from CurrentUser
        Dim fullName As String = $"{CurrentUser.FirstName} {CurrentUser.LastName}"
        Dim address As String = $"{CurrentUser.HouseNumber}, {CurrentUser.Street}, {CurrentUser.Barangay}, District {CurrentUser.District}, {CurrentUser.City}, {CurrentUser.Province}"
        Dim contact As String = CurrentUser.Contact

        ' Set values to UI components (assuming you have corresponding labels on the form)
        nameTxt.Text = fullName.ToUpper()
        addressTxt.Text = address.ToUpper()
        contactTxt.Text = contact

        FlowLayoutPanel1.Controls.Clear()

        Dim totalPrice As Decimal = 0 ' Initialize total price
        Dim totalItems As Integer = SelectedItems.Count ' Total number of products

        ' Ensure that the form has a FlowLayoutPanel to display the items
        For Each item As DataRow In SelectedItems
            ' Add the current item's total price to the total
            totalPrice += Convert.ToDecimal(item("total_price"))

            Dim mainItemPanel As New Panel With {
                .Size = New Size(741, 150),
                .BackColor = Color.Green,
                .Margin = New Padding(5)
            }

            ' Create a panel for each selected item
            Dim itemPanel As New Panel With {
                .Size = New Size(718, 126),
                .BackColor = Color.White,
                .Location = New Point(10, 12),
                .Margin = New Padding(5)
            }

            mainItemPanel.Controls.Add(itemPanel)

            ' Add product name
            Dim nameLabel As New Label With {
                .Text = item("product_name").ToString(),
                .Font = New Font("Arial", 12, FontStyle.Bold),
                .ForeColor = Color.DarkGreen,
                .Size = New Size(253, 21),
                .Location = New Point(251, 36)
            }
            itemPanel.Controls.Add(nameLabel)

            ' Add product quantity
            Dim quantityLabel As New Label With {
                .Text = "x" & item("quantity").ToString(),
                .Size = New Size(28, 21),
                .Font = New Font("Arial", 10, FontStyle.Bold),
                .Location = New Point(673, 100)
            }
            itemPanel.Controls.Add(quantityLabel)

            ' Add Supplier name
            Dim supplierLabel As New Label With {
                .Text = item("supplier").ToString(),
                .Font = New Font("Arial", 12, FontStyle.Bold),
                .ForeColor = Color.Black,
                .Size = New Size(252, 21),
                .Location = New Point(251, 61)
            }
            itemPanel.Controls.Add(supplierLabel)

            ' Add total price
            Dim totalPriceLabel As New Label With {
                .Text = "₱" & item("total_price").ToString(),
                .Font = New Font("Arial", 10, FontStyle.Bold),
                .Location = New Point(511, 50),
                .Size = New Size(74, 21)
            }
            itemPanel.Controls.Add(totalPriceLabel)

            ' Add product image (if available)
            Dim productImage As New PictureBox With {
                .Size = New Size(154, 126),
                .Location = New Point(51, 0),
                .SizeMode = PictureBoxSizeMode.StretchImage
            }

            Dim imageData As Byte() = CType(item("product_image"), Byte())
            If imageData IsNot Nothing AndAlso imageData.Length > 0 Then
                Using ms As New MemoryStream(imageData)
                    productImage.Image = Image.FromStream(ms)
                End Using
            End If

            itemPanel.Controls.Add(productImage)

            ' Add the panel to the FlowLayoutPanel
            FlowLayoutPanel1.Controls.Add(mainItemPanel)
        Next

        ' Display the total price and number of items in the respective textboxes
        totalTxt.Text = "₱" & totalPrice.ToString("0.00")
        totalItemTxt.Text = "TOTAL (" & totalItems.ToString() & " ITEM/S)"

    End Sub

    Private Sub placeOrderBtn_Click(sender As Object, e As EventArgs) Handles placeOrderBtn.Click
        Dim dbConnection As New dbcon()

        Try
            ' Using the dbConnection object to get the database connection
            Using connection As MySqlConnection = dbConnection.GetDatabaseConnection()
                If connection.State <> ConnectionState.Open Then connection.Open()

                ' Start a database transaction
                Dim transaction As MySqlTransaction = connection.BeginTransaction()

                ' Loop through each selected item to check if there's enough stock
                Dim insufficientStockItems As New List(Of String) ' List to hold items with insufficient stock
                For Each item As DataRow In SelectedItems
                    ' Query to get the available stock for the product
                    Dim availableQuantity As Integer
                    Using cmd As New MySqlCommand("SELECT quantity FROM products WHERE id = @product_id", connection, transaction)
                        cmd.Parameters.AddWithValue("@product_id", item("product_id"))
                        availableQuantity = Convert.ToInt32(cmd.ExecuteScalar())
                    End Using

                    Dim requestedQuantity As Integer = Convert.ToInt32(item("quantity")) ' Quantity requested by the user

                    ' If requested quantity is more than available quantity, add the item to the insufficient stock list
                    If requestedQuantity > availableQuantity Then
                        Dim productName As String = item("product_name").ToString()
                        insufficientStockItems.Add($"{productName}: Available - {availableQuantity}, Requested - {requestedQuantity}")
                    End If
                Next

                ' If there are items with insufficient stock, show a message and exit the process
                If insufficientStockItems.Count > 0 Then
                    Dim message As String = String.Join(Environment.NewLine, insufficientStockItems)
                    MessageBox.Show(message, "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                ' Insert into the orders table and get the new order ID
                Dim orderId As Integer
                Using cmd As New MySqlCommand("INSERT INTO orders (user_id, order_date, total_amount, status, payment_method) VALUES (@user_id, @order_date, @total_amount, @status, @payment_method); SELECT LAST_INSERT_ID();", connection, transaction)
                    cmd.Parameters.AddWithValue("@user_id", userId)
                    cmd.Parameters.AddWithValue("@order_date", DateTime.Now)
                    cmd.Parameters.AddWithValue("@total_amount", Decimal.Parse(totalTxt.Text.Replace("₱", "")))
                    cmd.Parameters.AddWithValue("@status", "Pending")
                    cmd.Parameters.AddWithValue("@payment_method", "Cash on Delivery")

                    orderId = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                ' Insert each selected item into the order_items table
                For Each item As DataRow In SelectedItems
                    ' Insert into order_items table
                    Using cmd As New MySqlCommand("INSERT INTO order_items (order_id, product_id, quantity, total_price) VALUES (@order_id, @product_id, @quantity, @total_price)", connection, transaction)
                        cmd.Parameters.AddWithValue("@order_id", orderId)
                        cmd.Parameters.AddWithValue("@product_id", item("product_id"))
                        cmd.Parameters.AddWithValue("@quantity", item("quantity"))
                        cmd.Parameters.AddWithValue("@total_price", item("total_price"))
                        cmd.ExecuteNonQuery()
                    End Using

                    ' Remove the item from the cart after the order is placed
                    Using cmd As New MySqlCommand("DELETE FROM cart WHERE user_id = @user_id AND product_id = @product_id", connection, transaction)
                        cmd.Parameters.AddWithValue("@user_id", userId)
                        cmd.Parameters.AddWithValue("@product_id", item("product_id"))
                        cmd.ExecuteNonQuery()
                    End Using

                    ' Update the product stock quantity in the products table
                    Dim orderedQuantity As Integer = Convert.ToInt32(item("quantity"))
                    Using cmd As New MySqlCommand("UPDATE products SET quantity = quantity - @ordered_quantity WHERE id = @product_id", connection, transaction)
                        cmd.Parameters.AddWithValue("@ordered_quantity", orderedQuantity)
                        cmd.Parameters.AddWithValue("@product_id", item("product_id"))
                        cmd.ExecuteNonQuery()
                    End Using
                Next

                ' Commit the transaction
                transaction.Commit()

                ' Notify the user
                MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Dim goToCart As New cart()
                goToCart.Show()
                Me.Hide()

                ' Optionally, clear the cart or redirect the user
                FlowLayoutPanel1.Controls.Clear()
                totalTxt.Text = "₱0.00"
                totalItemTxt.Text = "TOTAL (0 ITEM/S)"
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred while placing the order: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim goCart As New cart()
        goCart.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub vegetablesLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Dim displayProductsForm As New displayProducts
        displayProductsForm.UpdateCategory("Vegetable")
        displayProductsForm.Show()
        Hide()
    End Sub

    Private Sub fruitsLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Dim displayProductsForm As New displayProducts
        displayProductsForm.UpdateCategory("Fruit")
        displayProductsForm.Show()
        Hide()
    End Sub

    Private Sub eggsLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Dim displayProductsForm As New displayProducts
        displayProductsForm.UpdateCategory("Egg")
        displayProductsForm.Show()
        Hide()
    End Sub

    Private Sub meatsLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Dim displayProductsForm As New displayProducts
        displayProductsForm.UpdateCategory("Meat")
        displayProductsForm.Show()
        Hide()
    End Sub

    Private Sub herbsLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Dim displayProductsForm As New displayProducts
        displayProductsForm.UpdateCategory("Herb")
        displayProductsForm.Show()
        Hide()
    End Sub

    Private Sub seafoodsLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Dim displayProductsForm As New displayProducts
        displayProductsForm.UpdateCategory("Seafood")
        displayProductsForm.Show()
        Hide()
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

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        landing.Show()
        Me.Hide()
    End Sub
End Class
