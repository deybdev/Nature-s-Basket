Imports System.IO
Imports MySql.Data.MySqlClient

Public Class addProducts
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles productName.TextChanged

    End Sub

    Private Sub addImageBtn_Click(sender As Object, e As EventArgs) Handles addImageBtn.Click
        ' Create and configure the OpenFileDialog
        Dim OpenFileDialog1 As New OpenFileDialog With {
            .Filter = "Picture Files|*.jpg;*.jpeg;*.png",
            .Title = "Select an Image"
        }

        ' Show the dialog and check if the user selects a file
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            ' Load and display the selected image in the PictureBox
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Validate inputs
        If String.IsNullOrEmpty(productName.Text) OrElse
           String.IsNullOrEmpty(productCategory.Text) Then
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If PictureBox1.Image Is Nothing Then
            MessageBox.Show("Please select an image.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Convert the image to a byte array
            Dim imageBytes As Byte()
            Using ms As New MemoryStream()
                PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                imageBytes = ms.ToArray()
            End Using

            ' Insert product into the database
            Dim query As String = "INSERT INTO products (name, category, supplier, price, quantity, unit, image) VALUES (@Name, @Category, @Supplier, @Price, @Quantity, @Unit, @Image)"
            Dim dbConnection As New dbcon()

            Using connection As MySqlConnection = dbConnection.GetDatabaseConnection()
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Name", productName.Text.Trim())
                    cmd.Parameters.AddWithValue("@Category", productCategory.Text.Trim())
                    cmd.Parameters.AddWithValue("@Supplier", supplierBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@Price", priceBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@Unit", unitBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@Quantity", quantityBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@Image", imageBytes)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Product saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("An error occurred while saving the product: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim dashb As New dashboard
        dashb.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim ord As New orders
        ord.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        myProducts.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        login.Show()
        Me.Hide()
    End Sub
End Class
