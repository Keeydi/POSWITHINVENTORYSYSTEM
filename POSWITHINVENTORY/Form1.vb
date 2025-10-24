Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing

Public Class Form1

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click


        Dim username As String = txtusername.Text.Trim()
        Dim password As String = txtpassword.Text.Trim()

        Dim sql As String = "SELECT Type FROM Users WHERE username = @username AND password = @password"

        Using conn As New SqlConnection(Connect.Connstring)
            Using cmd As New SqlCommand(sql, conn)

                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)

                Try
                    conn.Open()

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim accountType As String = reader("Type").ToString()
                            logUsername = username ' Set the global username for logging
                            If accountType.Equals("admin", StringComparison.OrdinalIgnoreCase) Then
                                MessageBox.Show("Admin login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                LogActivity(logUsername, "Logged In", "Admin")
                                Me.Hide()
                                Dashboard.Show()
                                txtusername.Clear()
                                txtpassword.Clear()
                                txtusername.Focus()
                                chkshowpass.Checked = False

                            ElseIf accountType.Equals("employee", StringComparison.OrdinalIgnoreCase) Then
                                MessageBox.Show("Employee login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                LogActivity(logUsername, "Logged In", "Employee")
                                Me.Hide()
                                Pointofsalesystem.Show()
                                txtusername.Clear()
                                txtpassword.Clear()
                                txtusername.Focus()
                                chkshowpass.Checked = False

                            Else
                                MessageBox.Show("Invalid account type", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        Else
                            MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            txtpassword.Clear()
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub






    Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyDown
            If e.KeyCode = Keys.Enter Then
                btnlogin.PerformClick()
            End If
        End Sub

        Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exist?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub chkshowpass_CheckedChanged(sender As Object, e As EventArgs) Handles chkshowpass.CheckedChanged
        If chkshowpass.Checked Then
            txtpassword.PasswordChar = ""
        Else
            txtpassword.PasswordChar = "*"
        End If
    End Sub
End Class
