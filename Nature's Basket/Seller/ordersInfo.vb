Imports MySql.Data.MySqlClient
Imports System.IO

Public Class ordersInfo
    Private orderId As String

    ' Constructor that accepts the order ID
    Public Sub New(orderId As String)
        InitializeComponent()
        Me.orderId = orderId
    End Sub

    Private Sub ordersInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load order details using the order ID
        LoadOrderDetails(orderId)
    End Sub

    Private Sub LoadOrderDetails(orderId As String)
        Dim query As String = "SELECT 
                                    o.id AS order_id,
                                    CONCAT(u.first_name, ' ', u.last_name) AS recipient_name,
                                    CONCAT(u.house_number, ' ', u.street, ', ', u.barangay, ', ', u.district, ', ', u.city, ', ', u.province) AS address,
                                    u.contact AS contact_number,
                                    p.name AS product_name,
                                    p.supplier,
                                    p.image AS product_image, -- BLOB image
                                    oi.quantity,
                                    oi.total_price,
                                    o.total_amount,
                                    o.status,
                                    o.payment_method,
                                    50 AS shipping_fee
                                FROM orders o
                                INNER JOIN user u ON o.user_id = u.id
                                INNER JOIN order_items oi ON o.id = oi.order_id
                                INNER JOIN products p ON oi.product_id = p.id
                                WHERE o.id = @orderId;"

        Dim dbConnection As New dbcon()

        Using connection As MySqlConnection = dbConnection.GetDatabaseConnection()
            Try
                Using cmd As New MySqlCommand(query, connection)
                    ' Bind the parameter
                    cmd.Parameters.AddWithValue("@orderId", orderId)

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    ' Ensure we have data before proceeding
                    If dt.Rows.Count = 0 Then
                        MessageBox.Show("No order details found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return
                    End If

                    ' Clear existing controls
                    FlowLayoutPanel1.Controls.Clear()

                    ' Display product details
                    For Each row As DataRow In dt.Rows
                        Dim productPanel As New Panel With {
                            .Width = 1200,
                            .Height = 150,
                            .BorderStyle = BorderStyle.FixedSingle,
                            .BackColor = Color.White,
                            .Margin = New Padding(10)
                        }

                        ' Convert BLOB to Image
                        Dim productImage As New PictureBox With {
                            .SizeMode = PictureBoxSizeMode.Zoom,
                            .Size = New Size(195, 147),
                            .Location = New Point(3, 1)
                        }

                        If Not IsDBNull(row("product_image")) Then
                            Dim imageData As Byte() = DirectCast(row("product_image"), Byte())
                            Using ms As New MemoryStream(imageData)
                                productImage.Image = Image.FromStream(ms)
                            End Using
                        End If

                        productPanel.Controls.Add(productImage)

                        ' Add product name and description
                        Dim productLabel As New Label With {
                            .Text = $"{row("product_name").ToString()}" & vbCrLf & $"({row("supplier").ToString()})",
                            .Font = New Font("Segoe UI", 10, FontStyle.Bold),
                            .ForeColor = Color.Black,
                            .Location = New Point(272, 53),
                            .AutoSize = True
                        }
                        productPanel.Controls.Add(productLabel)

                        ' Add price and quantity
                        Dim priceLabel As New Label With {
                            .Text = $"₱{CDec(row("total_price")):N2}" & vbCrLf & $"x{row("quantity")}",
                            .Font = New Font("Segoe UI", 12, FontStyle.Bold),
                            .ForeColor = Color.Green,
                            .Location = New Point(738, 53),
                            .AutoSize = True
                        }

                        productPanel.Controls.Add(priceLabel)

                        FlowLayoutPanel1.Controls.Add(productPanel)
                    Next

                    ' Display shipping and payment details
                    Dim shippingDetailsPanel As New Panel With {
                        .Width = 1200,
                        .Height = 200,
                        .BorderStyle = BorderStyle.FixedSingle,
                        .BackColor = Color.White,
                        .Margin = New Padding(15)
                    }

                    ' Add shipping and payment labels
                    Dim shippingLabel As New Label With {
                        .Text = $"SHIPPING DETAILS" & vbCrLf &
                                $"                            SHIP TO :    {dt.Rows(0)("recipient_name")}" & vbCrLf &
                                $"                  CONTACT NO. :    {dt.Rows(0)("contact_number")}" & vbCrLf &
                                $"                          ADDRESS :    {dt.Rows(0)("address")}",
                        .Font = New Font("Segoe UI", 10, FontStyle.Bold),
                        .ForeColor = Color.Black,
                        .Location = New Point(10, 10),
                        .AutoSize = True
                    }

                    shippingDetailsPanel.Controls.Add(shippingLabel)

                    Dim paymentLabel As New Label With {
                        .Text = $"PAYMENT DETAILS:" & vbCrLf &
                                $"MERCHANDISE SUBTOTAL     ---------------------------------------------------------------------------------------------------------------------------------------------      ₱{CDec(dt.Compute("SUM(total_price)", String.Empty)):N2}" & vbCrLf &
                                $"                + SHIPPING FEE     ---------------------------------------------------------------------------------------------------------------------------------------------      ₱{CDec(dt.Rows(0)("shipping_fee")):N2}" & vbCrLf &
                                $"               TOTAL PAYMENT     ---------------------------------------------------------------------------------------------------------------------------------------------      ₱{CDec(dt.Rows(0)("total_amount") + 50):N2}",
                        .Font = New Font("Segoe UI", 10, FontStyle.Bold),
                        .ForeColor = Color.Black,
                        .Location = New Point(10, 100),
                        .AutoSize = True
                    }
                    shippingDetailsPanel.Controls.Add(paymentLabel)

                    FlowLayoutPanel1.Controls.Add(shippingDetailsPanel)
                End Using
            Catch ex As MySqlException
                MessageBox.Show("An error occurred while loading order details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim dashb As New dashboard
        dashb.Show()
        Me.Close()
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
        orders.Show()
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        login.Show()
        Me.Hide()
    End Sub
End Class
