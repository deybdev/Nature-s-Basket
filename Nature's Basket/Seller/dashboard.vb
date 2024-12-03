Imports MySql.Data.MySqlClient

Public Class dashboard
    ' This method runs when the form is loaded to retrieve the count of orders and products with quantity 0
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RetrieveOrderCounts()
        RetrieveZeroQuantityProducts()
    End Sub

    ' Method to retrieve and display the count of orders with specific statuses
    Private Sub RetrieveOrderCounts()
        Dim query As String = "SELECT COUNT(*) FROM orders WHERE status = 'Order Shipped'"
        Dim queryShipped As String = "SELECT COUNT(*) FROM orders WHERE status = 'Order Delivered'"
        Dim queryDelivered As String = "SELECT COUNT(*) FROM orders WHERE status = 'Delivered Successfully'"

        Dim dbConnection As New dbcon()

        ' Query for "Order processed"
        Dim orderProcessedCount As Integer = GetOrderCount(query)

        ' Query for "Order shipped"
        Dim orderShippedCount As Integer = GetOrderCount(queryShipped)

        ' Query for "Order delivered"
        Dim orderDeliveredCount As Integer = GetOrderCount(queryDelivered)

        ' Display the order counts in your dashboard labels (Assuming you have labels named LabelOrderProcessed, LabelOrderShipped, and LabelOrderDelivered)
        Label4.Text = $"{orderProcessedCount}"
        Label7.Text = $"{orderShippedCount}"
        Label11.Text = $"{orderDeliveredCount}"
    End Sub

    ' Helper method to execute a query and return the count result
    Private Function GetOrderCount(query As String) As Integer
        Dim dbConnection As New dbcon()
        Using connection As MySqlConnection = dbConnection.GetDatabaseConnection()
            Try
                Using cmd As New MySqlCommand(query, connection)
                    Dim result As Object = cmd.ExecuteScalar()
                    connection.Close()
                    If result IsNot DBNull.Value Then
                        Return Convert.ToInt32(result)
                    Else
                        Return 0
                    End If
                End Using
            Catch ex As MySqlException
                MessageBox.Show("An error occurred while retrieving order counts: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return 0
            End Try
        End Using
    End Function

    ' Method to retrieve and display the products with a quantity of 0
    Private Sub RetrieveZeroQuantityProducts()
        Dim query As String = "SELECT COUNT(*) FROM products WHERE quantity = 0"

        ' Create a new db connection object
        Dim dbConnection As New dbcon()

        ' Query for products with quantity = 0
        Dim zeroQuantityCount As Integer = GetProductCount(query)

        Label9.Text = $"{zeroQuantityCount}"
    End Sub

    ' Helper method to execute a query and return the product count result
    Private Function GetProductCount(query As String) As Integer
        Dim dbConnection As New dbcon()
        Using connection As MySqlConnection = dbConnection.GetDatabaseConnection()
            Try
                Using cmd As New MySqlCommand(query, connection)
                    Dim result As Object = cmd.ExecuteScalar()
                    connection.Close()
                    If result IsNot DBNull.Value Then
                        Return Convert.ToInt32(result)
                    Else
                        Return 0
                    End If
                End Using
            Catch ex As MySqlException
                MessageBox.Show("An error occurred while retrieving product counts: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return 0
            End Try
        End Using
    End Function

    ' Event handler for when the LinkLabel2 is clicked (orders)
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim ord As New orders
        ord.Show()
        Me.Hide()
    End Sub

    ' Event handler for when the LinkLabel3 is clicked (myProducts)
    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Dim myp As New myProducts
        myp.Show()
        Me.Hide()
    End Sub

    ' Event handler for when the LinkLabel4 is clicked (addProducts)
    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Dim addp As New addProducts
        addp.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        login.Show()
        Me.Hide()
    End Sub
End Class
