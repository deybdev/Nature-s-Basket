Imports MySql.Data.MySqlClient
Imports Nature_s_Basket.login

Public Class myOrders


    Private Sub myOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        isLoggedIn = login.isLoggedIn

        If CurrentUser.UserId <= 0 Then
            ' Hide "Logout" and "My Purchases" buttons if no user is logged in
            LinkLabel11.Visible = False
            myPurchaseLinl.Visible = False
        End If

        LoadOrders()
    End Sub

    Private Sub LoadOrders()
        Dim query As String = "SELECT o.id AS order_id, o.order_date, o.total_amount, o.status, o.payment_method, 
                                  oi.product_id, oi.quantity, oi.total_price, p.name AS product_name, p.image AS product_image
                           FROM orders o
                           INNER JOIN order_items oi ON o.id = oi.order_id
                           INNER JOIN products p ON oi.product_id = p.id
                           WHERE o.user_id = @UserId
                           ORDER BY o.order_date DESC"

        Dim totalQuery As String = "SELECT SUM(total_amount) AS total_orders FROM orders WHERE user_id = @UserId"

        Dim dbConnection As New dbcon()

        Using connection As MySqlConnection = dbConnection.GetDatabaseConnection()
            Try
                ' Fetch total amount
                Dim totalAmount As Decimal
                Using totalCmd As New MySqlCommand(totalQuery, connection)
                    totalCmd.Parameters.AddWithValue("@UserId", CurrentUser.UserId)
                    Dim totalAmountObj As Object = totalCmd.ExecuteScalar()
                    If totalAmountObj IsNot Nothing AndAlso Not IsDBNull(totalAmountObj) Then
                        totalAmount = Convert.ToDecimal(totalAmountObj)
                    Else
                        totalAmount = 0
                    End If
                    connection.Close()
                End Using

                ordersTotal.Text = "TOTAL ORDERS: ₱" & totalAmount.ToString("N2")

                ' Fetch orders
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@UserId", CurrentUser.UserId)
                    connection.Open()
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    connection.Close()

                    ' Clear existing controls in FlowLayoutPanel
                    FlowLayoutPanel1.Controls.Clear()

                    ' Group orders by order_id
                    Dim groupedOrders = dt.AsEnumerable().GroupBy(Function(row) row("order_id"))

                    ' Populate the template
                    For Each group In groupedOrders
                        Dim orderCard As New Panel With {
                    .Size = New Size(760, 0),
                    .BackColor = Color.DarkGreen,
                    .Margin = New Padding(10)
                }

                        ' Fetch order-level details from the first row in the group
                        Dim orderId As Integer = group.Key
                        Dim orderDate As DateTime = group.First()("order_date")
                        Dim totalAmountOrder As Decimal = group.First()("total_amount")
                        Dim status As String = group.First()("status").ToString()
                        Dim paymentMethod As String = group.First()("payment_method").ToString()

                        ' Add order details to the card
                        Dim orderIdLabel As New Label With {
                    .Text = "ORDER ID :   " & orderId,
                    .Font = New Font("Segoe UI", 10, FontStyle.Bold),
                    .ForeColor = Color.White,
                    .Location = New Point(23, 29),
                    .Size = New Size(200, 17)
                }
                        orderCard.Controls.Add(orderIdLabel)

                        Dim orderDateLabel As New Label With {
                    .Text = "DATE :   " & orderDate.ToString("MMMM dd, yyyy"),
                    .Font = New Font("Segoe UI", 10, FontStyle.Bold),
                    .ForeColor = Color.White,
                    .Location = New Point(52, 6),
                    .Size = New Size(200, 17)
                }
                        orderCard.Controls.Add(orderDateLabel)

                        Dim totalAmountLabel As New Label With {
                    .Text = "TOTAL:   ₱" & totalAmountOrder.ToString("N2"),
                    .Font = New Font("Segoe UI", 12, FontStyle.Bold),
                    .ForeColor = Color.White,
                    .Location = New Point(554, 16),
                    .Size = New Size(200, 20)
                }
                        orderCard.Controls.Add(totalAmountLabel)

                        ' Map the status
                        Dim mappedStatus As String = GetMappedStatus(status)

                        Dim statusLabel As New Label With {
                    .Text = "STATUS :   " & mappedStatus,
                    .Font = New Font("Segoe UI", 10, FontStyle.Bold),
                    .ForeColor = Color.White,
                    .Location = New Point(291, 7),
                    .Size = New Size(250, 20)
                }
                        orderCard.Controls.Add(statusLabel)

                        Dim paymentMethodLabel As New Label With {
                    .Text = "PAYMENT :   " & paymentMethod,
                    .Font = New Font("Segoe UI", 10, FontStyle.Bold),
                    .ForeColor = Color.White,
                    .Location = New Point(277, 30),
                    .Size = New Size(250, 20)
                }
                        orderCard.Controls.Add(paymentMethodLabel)

                        ' Add product cards for each product in the order
                        Dim productStartY As Integer = 50
                        Dim orderCardHeight As Integer = 150

                        For Each row In group
                            Dim productName As String = row("product_name").ToString()
                            Dim productQuantity As Integer = row("quantity")
                            Dim totalPrice As Decimal = row("total_price")
                            Dim productImage As Object = row("product_image")

                            Dim productCard As New Panel With {
                        .Size = New Size(740, 124),
                        .BackColor = Color.White,
                        .Margin = New Padding(5),
                        .Location = New Point(10, productStartY)
                    }

                            Dim productImageControl As New PictureBox With {
                        .Size = New Size(161, 124),
                        .Location = New Point(0, 0),
                        .SizeMode = PictureBoxSizeMode.StretchImage
                    }

                            If Not IsDBNull(productImage) Then
                                Dim imgData As Byte() = CType(productImage, Byte())
                                Using ms As New IO.MemoryStream(imgData)
                                    productImageControl.Image = Image.FromStream(ms)
                                End Using
                            End If
                            productCard.Controls.Add(productImageControl)

                            Dim productNameLabel As New Label With {
                        .Text = $"{productName}",
                        .Font = New Font("Segoe UI", 11, FontStyle.Bold),
                        .ForeColor = Color.Black,
                        .Location = New Point(207, 37),
                        .Size = New Size(200, 20)
                    }
                            productCard.Controls.Add(productNameLabel)

                            Dim productTotalPriceLabel As New Label With {
                        .Text = $"₱{totalPrice:N2}",
                        .Font = New Font("Segoe UI", 11, FontStyle.Bold),
                        .ForeColor = Color.Black,
                        .Location = New Point(456, 49),
                        .Size = New Size(200, 20)
                    }
                            productCard.Controls.Add(productTotalPriceLabel)

                            Dim producTQuantityLabel As New Label With {
                        .Text = $"x{productQuantity}",
                        .Font = New Font("Segoe UI", 11, FontStyle.Bold),
                        .ForeColor = Color.Black,
                        .Location = New Point(713, 49),
                        .Size = New Size(200, 20)
                    }
                            productCard.Controls.Add(producTQuantityLabel)

                            orderCard.Controls.Add(productCard)
                            productStartY += 134
                            orderCardHeight = productStartY + 10
                        Next

                        orderCard.Height = orderCardHeight
                        FlowLayoutPanel1.Controls.Add(orderCard)
                    Next
                End Using
            Catch ex As MySqlException
                MessageBox.Show("An error occurred while loading orders: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Function to map the status from the database to the user-friendly format
    Private Function GetMappedStatus(status As String) As String
        Select Case status
            Case "Order Processed"
                Return "In Process"
            Case "Order Shipped"
                Return "Order Processed"
            Case "Order Delivered"
                Return "Order Shipped"
            Case "Delivered Successfully"
                Return "Delivered Successfully"
            Case Else
                Return status ' Return as is if no mapping is found
        End Select
    End Function



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cart.Show()
        Me.Close()
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

