Imports MySql.Data.MySqlClient

Public Class register
    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        login.Show()
        Me.Hide()
    End Sub

    Private Sub regButton_Click(sender As Object, e As EventArgs) Handles regButton.Click
        Dim lastName As String = lastNameBox.Text.Trim()
        Dim firstName As String = firstNameBox.Text.Trim()
        Dim contactNumber As String = contactNum.Text.Trim()
        Dim houseNumber As String = houseNumberBox.Text.Trim()
        Dim street As String = streetBox.Text.Trim()
        Dim barangay As String = barangayBox.Text.Trim()
        Dim district As String = districtBox.Text.Trim()
        Dim city As String = cityBox.Text.Trim()
        Dim province As String = provinceBox.Text.Trim()
        Dim email As String = emailBox.Text.Trim()
        Dim password As String = passwordBox.Text.Trim()

        ' Check if mandatory fields are filled
        If String.IsNullOrEmpty(lastName) OrElse String.IsNullOrEmpty(firstName) OrElse String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please fill in all required fields.")
            Return
        End If

        Dim dbConnection As New dbcon()
        Using connection As MySqlConnection = dbConnection.GetDatabaseConnection()
            Try
                ' Check if the email already exists
                Dim checkQuery As String = "SELECT COUNT(*) FROM `user` WHERE email = @Email"
                Using checkCommand As New MySqlCommand(checkQuery, connection)
                    checkCommand.Parameters.AddWithValue("@Email", email)

                    Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("Email already exists. Please use a different email.")
                        Return
                    End If
                End Using

                ' Insert new user into the database
                Dim query As String = "INSERT INTO `user` (last_name, first_name, contact, house_number, street, barangay, district, city, province, email, password) " &
                                      "VALUES (@LastName, @FirstName, @Contact, @HouseNumber, @Street, @Barangay, @District, @City, @Province, @Email, @Password)"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@LastName", lastName)
                    command.Parameters.AddWithValue("@FirstName", firstName)
                    command.Parameters.AddWithValue("@Contact", contactNumber)
                    command.Parameters.AddWithValue("@HouseNumber", houseNumber)
                    command.Parameters.AddWithValue("@Street", street)
                    command.Parameters.AddWithValue("@Barangay", barangay)
                    command.Parameters.AddWithValue("@District", district)
                    command.Parameters.AddWithValue("@City", city)
                    command.Parameters.AddWithValue("@Province", province)
                    command.Parameters.AddWithValue("@Email", email)
                    command.Parameters.AddWithValue("@Password", password)

                    command.ExecuteNonQuery()
                    MessageBox.Show("Registration successful. You can now Login!")

                    Me.Hide()
                    Dim loginForm As New login()
                    loginForm.Show()
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Database error: " & ex.Message)
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            Finally
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End Using
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Hide()
        Dim landingForm As New landing
        landingForm.Show()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim home As New landing()
        home.Show()
        Me.Hide()
    End Sub
End Class
