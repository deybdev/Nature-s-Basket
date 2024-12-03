Imports MySql.Data.MySqlClient

Public Class Login
    Public Shared isLoggedIn As Boolean = False
    Dim home As New landing()

    Public Class CurrentUser
        Public Shared UserId As Integer
        Public Shared LastName As String
        Public Shared FirstName As String
        Public Shared Email As String
        Public Shared HouseNumber As String
        Public Shared Street As String
        Public Shared Barangay As String
        Public Shared District As String
        Public Shared City As String
        Public Shared Province As String
        Public Shared Contact As String
    End Class

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        Dim email As String = emailBox.Text.Trim()
        Dim password As String = passwordBox.Text.Trim()

        If String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both email and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Query to check login credentials in the seller table
        Dim sellerQuery As String = "SELECT id, email FROM seller WHERE email = @Email AND password = @Password"

        ' Query to check login credentials in the user table
        Dim userQuery As String = "SELECT id, last_name, first_name, email, house_number, street, barangay, district, city, province, contact 
                               FROM user 
                               WHERE email = @Email AND password = @Password"

        Dim dbConnection As New dbcon()

        Using connection As MySqlConnection = dbConnection.GetDatabaseConnection()
            Try
                ' First, check if the login credentials are for the seller
                Using cmd As New MySqlCommand(sellerQuery, connection)
                    cmd.Parameters.AddWithValue("@Email", email)
                    cmd.Parameters.AddWithValue("@Password", password)

                    ' Execute the query to check if it's a seller login
                    Dim sellerReader As MySqlDataReader = cmd.ExecuteReader()

                    If sellerReader.Read() Then
                        ' If the seller is found, set global login state and redirect to Dashboard
                        isLoggedIn = True

                        ' Assuming seller has only one account, no need to store additional details
                        MessageBox.Show("Login successful as Seller!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Redirect to the seller dashboard
                        Dim dashboard As New dashboard() ' Assuming you have a Dashboard form for the seller
                        dashboard.Show()
                        Me.Hide()
                        sellerReader.Close() ' Close the reader here
                        Return
                    End If
                    sellerReader.Close() ' Close the reader if seller is not found
                End Using

                ' If not found in the seller table, check the user table
                Using cmd As New MySqlCommand(userQuery, connection)
                    cmd.Parameters.AddWithValue("@Email", email)
                    cmd.Parameters.AddWithValue("@Password", password)

                    ' Execute the query to check if it's a regular user login
                    Dim userReader As MySqlDataReader = cmd.ExecuteReader()

                    If userReader.Read() Then
                        ' User found, set the current user details
                        CurrentUser.UserId = Convert.ToInt32(userReader("id"))
                        CurrentUser.LastName = userReader("last_name").ToString()
                        CurrentUser.FirstName = userReader("first_name").ToString()
                        CurrentUser.Email = userReader("email").ToString()
                        CurrentUser.HouseNumber = userReader("house_number").ToString()
                        CurrentUser.Street = userReader("street").ToString()
                        CurrentUser.Barangay = userReader("barangay").ToString()
                        CurrentUser.District = userReader("district").ToString()
                        CurrentUser.City = userReader("city").ToString()
                        CurrentUser.Province = userReader("province").ToString()
                        CurrentUser.Contact = userReader("contact").ToString()

                        ' Set global login state
                        isLoggedIn = True
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Redirect to the landing form for regular users
                        Dim land As New landing() ' Regular user lands here
                        land.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    userReader.Close() ' Close the reader when done
                End Using

            Catch ex As MySqlException
                MessageBox.Show("An error occurred while connecting to the database: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Dim registerForm As New register()
        registerForm.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        home.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
