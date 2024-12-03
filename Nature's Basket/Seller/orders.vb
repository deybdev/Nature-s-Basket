Imports MySql.Data.MySqlClient

Public Class orders

    Private Sub orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Automatically load seller orders when the form loads
        LoadSellerOrders()
    End Sub

    Private Sub LoadSellerOrders()
        ' The query to load the orders remains the same
        Dim query As String = "SELECT o.id AS order_id, CONCAT(c.first_name, ' ', c.last_name) AS customer_name, 
                            p.name AS product_name, oi.quantity, oi.total_price, o.status
                            FROM orders o
                            INNER JOIN order_items oi ON o.id = oi.order_id
                            INNER JOIN products p ON oi.product_id = p.id
                            INNER JOIN user c ON o.user_id = c.id
                            ORDER BY o.order_date DESC"

        Dim dbConnection As New dbcon()

        Using connection As MySqlConnection = dbConnection.GetDatabaseConnection()
            Try
                Using cmd As New MySqlCommand(query, connection)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    connection.Close()

                    ' Clear existing controls in the FlowLayoutPanel
                    FlowLayoutPanel1.Controls.Clear()

                    ' Group orders by order_id
                    Dim groupedOrders = dt.AsEnumerable().GroupBy(Function(row) row("order_id"))

                    For Each group In groupedOrders
                        ' Create a container panel for the order
                        Dim orderCard As New Panel With {
                        .Width = 1240,
                        .BackColor = Color.White,
                        .BorderStyle = BorderStyle.FixedSingle,
                        .Margin = New Padding(10)
                    }

                        ' Change cursor to hand when hovering over the panel
                        orderCard.Cursor = Cursors.Hand

                        ' Fetch customer and order-level details
                        Dim customerName As String = group.First()("customer_name").ToString()
                        Dim shippingFee As Decimal = 50 ' Fixed shipping fee
                        Dim totalOrderPrice As Decimal = 0 ' Initialize the total order price

                        ' Add customer name and order message
                        Dim customerLabel As New Label With {
                        .Text = $"{customerName} has placed an order",
                        .Font = New Font("Segoe UI", 12, FontStyle.Bold),
                        .ForeColor = Color.Black,
                        .Location = New Point(10, 10),
                        .AutoSize = True
                    }
                        orderCard.Controls.Add(customerLabel)

                        ' Initialize Y position for products
                        Dim startY As Integer = 40

                        ' Add product details and calculate total price
                        For Each row In group
                            Dim productName As String = row("product_name").ToString()
                            Dim quantity As Integer = row("quantity")
                            Dim totalPrice As Decimal = row("total_price")

                            ' Update total order price
                            totalOrderPrice += totalPrice

                            ' Product Name label
                            Dim productLabel As New Label With {
                            .Text = $"{productName}  (x{quantity})  -------------------------------------------------------------------------------------------------------------------------------------------------------------------------",
                            .Font = New Font("Segoe UI", 10, FontStyle.Regular),
                            .ForeColor = Color.Black,
                            .Location = New Point(10, startY),
                            .AutoSize = True
                        }
                            orderCard.Controls.Add(productLabel)

                            ' Product Price label
                            Dim priceLabel As New Label With {
                            .Text = $"₱{totalPrice:N2}",
                            .Font = New Font("Segoe UI", 10, FontStyle.Bold),
                            .ForeColor = Color.Black,
                            .Location = New Point(1150, startY),
                            .AutoSize = True
                        }
                            orderCard.Controls.Add(priceLabel)

                            ' Update Y position for next product
                            startY += 20
                        Next

                        ' Add fixed shipping fee
                        Dim shippingLabel As New Label With {
                        .Text = $"+ Shipping Fee   --------------------------------------------------------------------------------------------------------------------------------------------------------------------",
                        .Font = New Font("Segoe UI", 10, FontStyle.Italic),
                        .ForeColor = Color.Black,
                        .Location = New Point(10, startY),
                        .AutoSize = True
                    }
                        orderCard.Controls.Add(shippingLabel)

                        ' Shipping Fee label
                        Dim shippingFeeLabel As New Label With {
                        .Text = $"₱{shippingFee:N2}",
                        .Font = New Font("Segoe UI", 10, FontStyle.Regular),
                        .ForeColor = Color.Black,
                        .Location = New Point(1150, startY),
                        .AutoSize = True
                    }
                        orderCard.Controls.Add(shippingFeeLabel)

                        ' Add Button for order status
                        Dim statusButton As New Button With {
                        .Width = 200,
                        .Location = New Point(10, startY + 25), ' Position below the shipping fee
                        .Text = group.First()("status").ToString(),
                        .Tag = group.First()("order_id").ToString()
                    }
                        orderCard.Controls.Add(statusButton)

                        ' Add event handler for button click to change status directly
                        AddHandler statusButton.Click, AddressOf StatusButton_Click

                        ' Add total order price label (including shipping fee)
                        Dim totalOrderPriceLabel As New Label With {
                        .Text = $"Total: ₱{totalOrderPrice + shippingFee:N2}",
                        .Font = New Font("Segoe UI", 10, FontStyle.Bold),
                        .ForeColor = Color.Black,
                        .Location = New Point(1100, startY + 50), ' Position it after the status button
                        .AutoSize = True
                    }
                        orderCard.Controls.Add(totalOrderPriceLabel)

                        ' Update panel height based on last label position
                        orderCard.Height = startY + 100 ' Adding extra space for button, padding, and total price label

                        ' Add the Click event handler for the orderCard panel
                        AddHandler orderCard.Click, AddressOf OrderCard_Click

                        ' Store the order ID in the Tag property for later use
                        orderCard.Tag = group.First()("order_id").ToString()

                        ' Add the orderCard to FlowLayoutPanel
                        FlowLayoutPanel1.Controls.Add(orderCard)
                    Next
                End Using
            Catch ex As MySqlException
                MessageBox.Show("An error occurred while loading seller orders: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Handle the button click to change the status
    Private Sub StatusButton_Click(sender As Object, e As EventArgs)
        Dim button As Button = CType(sender, Button)
        Dim orderId As String = button.Tag.ToString()
        Dim currentStatus As String = button.Text.Trim()

        ' Check if the current status is "Order Delivered"
        If currentStatus = "Order Delivered" Then
            ' If the status is already "Order Delivered", change the button text to "Delivered Successfully"
            button.Text = "Delivered Successfully"

            ' Disable the button after it says "Delivered Successfully"
            button.Enabled = False

            ' Update the order status in the database to "Delivered Successfully"
            UpdateOrderStatus(orderId, "Delivered Successfully")
        Else
            ' Determine the next status based on the current status
            Dim nextStatus As String = GetNextStatus(currentStatus)

            If Not String.IsNullOrEmpty(nextStatus) Then
                UpdateOrderStatus(orderId, nextStatus)

                button.Text = nextStatus
            End If
        End If
    End Sub


    ' Function to get the next status based on the current one
    Private Function GetNextStatus(currentStatus As String) As String
        Select Case currentStatus
            Case "Pending"
                Return "Order Processed"
            Case "Order Processed"
                Return "Order Shipped"
            Case "Order Shipped"
                Return "Order Delivered"
            Case "Order Delivered"
                Return "Delivered Successfully"
        End Select
    End Function

    ' Function to update order status in the database
    Private Sub UpdateOrderStatus(orderId As String, newStatus As String)
        Dim query As String = "UPDATE orders SET status = @Status WHERE id = @OrderId"
        Dim dbConnection As New dbcon()

        Using connection As MySqlConnection = dbConnection.GetDatabaseConnection()
            Try
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Status", newStatus)
                    cmd.Parameters.AddWithValue("@OrderId", orderId)
                    cmd.ExecuteNonQuery()
                    connection.Close()

                    MessageBox.Show("Order status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            Catch ex As MySqlException
                MessageBox.Show("An error occurred while updating the order status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Handle the click event for the orderCard panel
    Private Sub OrderCard_Click(sender As Object, e As EventArgs)
        Dim orderId As String = CType(sender, Panel).Tag.ToString()

        If Not String.IsNullOrEmpty(orderId) Then
            Console.WriteLine("Order ID clicked: " & orderId)
            Dim orderInfoForm As New ordersInfo(orderId)
            orderInfoForm.ShowDialog()
            Me.Hide()
        Else
            MessageBox.Show("No Order ID found for the clicked panel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Link click event handlers (unchanged)
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        myProducts.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        addProducts.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked

    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        login.Show()
        Me.Hide()
    End Sub
End Class
