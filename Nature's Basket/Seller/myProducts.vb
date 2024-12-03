Imports MySql.Data.MySqlClient

Public Class myProducts
    ' On form load, display all products
    Private Sub myProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayProducts()
    End Sub

    ' Display products in the panel
    Private Sub DisplayProducts()
        ' Clear existing controls
        FlowLayoutPanel1.Controls.Clear()

        ' Establish database connection
        Dim dbConnection As New dbcon()
        Using connection As MySqlConnection = dbConnection.GetDatabaseConnection()
            Try
                ' Query to fetch products
                Dim query As String = "SELECT id, name, category, description, supplier, price, quantity, unit, image FROM products"

                ' Use DataAdapter to fill a DataTable
                Using adapter As New MySqlDataAdapter(query, connection)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)

                    ' Check if there are rows in the result
                    If dataTable.Rows.Count > 0 Then
                        For Each row As DataRow In dataTable.Rows
                            Try
                                ' Create a product panel for each product
                                Dim productPanel As New Panel With {
                                .Width = 1220,
                                .Height = 149,
                                .BackColor = Color.White,
                                .BorderStyle = BorderStyle.FixedSingle,
                                .Margin = New Padding(10)
                            }

                                ' Product image
                                Dim productImage As New PictureBox With {
                                .Width = 195,
                                .Height = 147,
                                .SizeMode = PictureBoxSizeMode.StretchImage,
                                .Location = New Point(3, 1)
                            }

                                ' Convert image from database to PictureBox
                                If row("image") IsNot DBNull.Value Then
                                    Dim imageBytes As Byte() = CType(row("image"), Byte())
                                    Using ms As New IO.MemoryStream(imageBytes)
                                        productImage.Image = Image.FromStream(ms)
                                    End Using
                                End If
                                productPanel.Controls.Add(productImage)

                                ' Product name
                                Dim nameLabel As New Label With {
                                .Text = row("name").ToString().ToUpper,
                                .Font = New Font("Segoe UI", 10, FontStyle.Bold),
                                .Location = New Point(270, 62),
                                .AutoSize = True
                            }
                                productPanel.Controls.Add(nameLabel)

                                ' Supplier
                                Dim supplierLabel As New Label With {
                                .Text = row("supplier").ToString().ToUpper,
                                .Font = New Font("Segoe UI", 10, FontStyle.Regular),
                                .Location = New Point(436, 62),
                                .AutoSize = True
                            }
                                productPanel.Controls.Add(supplierLabel)

                                Dim priceLabel As New Label With {
                                    .Text = $"₱{CDec(row("price")):N2} / {row("unit")}",
                                    .Font = New Font("Segoe UI", 10, FontStyle.Regular),
                                    .Location = New Point(681, 62),
                                    .AutoSize = True
                                }

                                productPanel.Controls.Add(priceLabel)

                                ' Quantity
                                Dim quantityLabel As New Label With {
                                .Text = $"Stock: {row("quantity")} ",
                                .Font = New Font("Segoe UI", 10, FontStyle.Regular),
                                .Location = New Point(894, 62),
                                .AutoSize = True
                            }
                                productPanel.Controls.Add(quantityLabel)

                                ' Delete button
                                Dim deleteButton As New Button With {
                                .Text = "DELETE",
                                .BackColor = Color.Red,
                                .ForeColor = Color.White,
                                .FlatStyle = FlatStyle.Flat,
                                .Width = 100,
                                .Height = 30,
                                .Location = New Point(1070, 35)
                            }
                                AddHandler deleteButton.Click, Sub() DeleteProduct(CInt(row("id")))
                                productPanel.Controls.Add(deleteButton)

                                ' Add Stock button
                                Dim addStockButton As New Button With {
                                .Text = "ADD STOCK",
                                .BackColor = Color.Green,
                                .ForeColor = Color.White,
                                .FlatStyle = FlatStyle.Flat,
                                .Width = 100,
                                .Height = 30,
                                .Location = New Point(1070, 78)
                            }
                                AddHandler addStockButton.Click, Sub() AddStock(CInt(row("id")))
                                productPanel.Controls.Add(addStockButton)

                                ' Add the panel to the main FlowLayoutPanel
                                FlowLayoutPanel1.Controls.Add(productPanel)

                            Catch innerEx As Exception
                                MessageBox.Show($"Error processing product: {innerEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try
                        Next
                    Else
                        ' Show a message if no products are found
                        MessageBox.Show("No products available.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            Catch ex As Exception
                ' Display detailed error message if any exception occurs
                MessageBox.Show($"Error displaying products: {ex.Message}" & vbNewLine &
                        $"Stack Trace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Ensure the connection is closed
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End Using
    End Sub



    ' Delete product by ID
    Private Sub DeleteProduct(productId As Integer)
        Dim dbConnection As New dbcon()
        Using connection As MySqlConnection = dbConnection.GetDatabaseConnection()
            Try
                Dim query As String = "DELETE FROM products WHERE id = @id"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@id", productId)
                    command.ExecuteNonQuery()
                End Using
                MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DisplayProducts()
            Catch ex As Exception
                MessageBox.Show($"Error deleting product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    ' Add stock to a product (example logic, customize as needed)
    ' Add stock to a product
    Private Sub AddStock(productId As Integer)
        ' Prompt user to input the stock quantity
        Dim input As String = InputBox("Enter the amount of stock to add:", "Add Stock", "0")

        ' Validate input
        Dim stockToAdd As Integer
        If Integer.TryParse(input, stockToAdd) AndAlso stockToAdd > 0 Then
            Dim dbConnection As New dbcon()
            Using connection As MySqlConnection = dbConnection.GetDatabaseConnection()
                Try
                    ' Update the stock in the database
                    Dim query As String = "UPDATE products SET quantity = quantity + @quantity WHERE id = @id"
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@quantity", stockToAdd)
                        command.Parameters.AddWithValue("@id", productId)
                        command.ExecuteNonQuery()
                    End Using
                    ' Notify the user and refresh the product list
                    MessageBox.Show($"Successfully added {stockToAdd} units to the stock!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DisplayProducts()
                Catch ex As Exception
                    MessageBox.Show($"Error adding stock: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    connection.Close()
                End Try
            End Using
        Else
            ' Show error if the input is invalid
            MessageBox.Show("Invalid stock value. Please enter a positive number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    ' Navigation methods (reused from previous code)
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        dashboard.Show
        Hide
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        orders.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        addProducts.Show
        Hide
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        login.Show()
        Me.Show()
    End Sub
End Class
