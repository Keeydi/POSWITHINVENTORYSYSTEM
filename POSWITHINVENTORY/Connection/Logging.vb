Imports System.Data.SqlClient
Module Logging
    Public logUsername As String ' Ensure this is set when the user logs in
    ' Function to log activity to the Logs table in SQL Server
    Public Sub LogActivity(username As String, action As String, details As String)
        Dim connection As New SqlClient.SqlConnection(Connstring)
        Try
            connection.Open()

            ' Step 1: Clean up logs older than 6 months
            CleanupOldLogs(connection)

            ' Step 2: Insert the new log entry
            Dim query As String = "INSERT INTO Logs (Username, Action, Timestamp, Details) " &
                                  "VALUES (@username, @action, GETDATE(), @details)"

            Using command As New SqlCommand(query, connection)
                ' Add parameters to the query
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@action", action)
                command.Parameters.AddWithValue("@details", details)

                ' Execute the query
                command.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            ' Display an error message if logging fails
            MessageBox.Show("An error occurred while logging activity: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Function to delete logs older than 6 months
    Private Sub CleanupOldLogs(connection As SqlClient.SqlConnection)
        Try
            ' SQL query to delete logs older than 6 months
            Dim deleteQuery As String = "DELETE FROM Logs WHERE Timestamp < DATEADD(MONTH, -6, GETDATE())"

            Using deleteCommand As New SqlCommand(deleteQuery, connection)
                ' Execute the delete command
                deleteCommand.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            ' If there's an error in cleanup, log or show the error (optional)
            MessageBox.Show("An error occurred during log cleanup: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
