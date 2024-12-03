Imports MySql.Data.MySqlClient

Public Class dbcon
    Public Function GetDatabaseConnection() As MySqlConnection
        Dim connectionString As String = "server=localhost;userid=root;password=;database=natures_basket"

        Dim connection As New MySqlConnection(connectionString)

        Try
            connection.Open()
            Return connection
        Catch ex As MySqlException
            MessageBox.Show("Error connecting to the database: " & ex.Message)
            Return Nothing
        End Try
    End Function
End Class
