Imports System.Data.SqlClient
Public Class frmvoidpass

    Private mainPOSForm As Pointofsalesystem ' Reference to the main form

    Public Sub New(mainForm As Pointofsalesystem)
        InitializeComponent()
        mainPOSForm = mainForm
    End Sub
    Private Function ValidatePassword(enteredPassword As String) As Boolean
        Dim correctPassword As String = ""

        Try
            ' Update with your SQL Server connection string

            Using connection As New SqlConnection(Connstring)
                connection.Open()
                Dim query As String = "SELECT Password FROM void"
                Using command As New SqlCommand(query, connection)
                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot Nothing Then
                        correctPassword = result.ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

        ' Compare the entered password with the correct password
        Return enteredPassword = correctPassword
    End Function

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnempsave.Click
        Dim correctPassword As String = "admin123" ' Replace with your actual password

        ' Validate password
        If txtpassword.Text = correctPassword Then
            ' Password is correct, open the Void form
            mainPOSForm.OpenVoidForm()
            Me.Close()
            Me.Hide()
        Else
            MessageBox.Show("Incorrect password. Please try again.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtpassword.Clear()
            txtpassword.Focus()
        End If
    End Sub



    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged

    End Sub

    Private Sub frmvoidpass_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.S Then
            ' Save action
            Guna2Button1_Click(sender, e)
        End If
        If e.KeyCode = Keys.Escape Then
            ' Save action
            Guna2Button2_Click(sender, e)
        End If
    End Sub

    Private Sub frmvoidpass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        txtpassword.UseSystemPasswordChar = True
        txtpassword.TextAlign = HorizontalAlignment.Center

        ' Change the font size and style of the password TextBox
        txtpassword.Font = New Font("Arial", 16, FontStyle.Bold)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles btnempback.Click
        Me.Close()


    End Sub

End Class