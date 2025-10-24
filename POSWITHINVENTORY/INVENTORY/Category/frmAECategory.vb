Imports System.ComponentModel.DataAnnotations
Imports Microsoft.Data.SqlClient

Public Class frmAECategory
    ' ✅ Property to store the Category ID when editing
    Public Property CategoryID As Integer
    ' ✅ Add an event to notify parent form to refresh its DataGridView
    Public Event CategorySaved()

    ' ✅ Added Load event to handle title and center the form
    Private Sub frmAECategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Change title dynamically
        If Me.Tag = "Edit" Then
            Me.Text = "EDIT CATEGORY"
        Else
            Me.Text = "ADD CATEGORY"
        End If

        ' Center the form when opening
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to cancel? Unsaved changes will be lost.",
                                                     "Confirm Cancel",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            txtCategoryName.Clear()
            txtCategoryDescription.Clear()
            Me.Close()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim name As String = txtCategoryName.Text.Trim()
        Dim desc As String = txtCategoryDescription.Text.Trim()

        If name = "" Then
            MessageBox.Show("Category name is required.")
            Exit Sub
        End If

        Dim conn As New Microsoft.Data.SqlClient.SqlConnection(Connect.Connstring)

        If Me.Tag = "Add" Then
            Dim query As String = "INSERT INTO Category (categoryName, categoryDescription) VALUES (@name, @desc)"
            Using cmd As New Microsoft.Data.SqlClient.SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@name", name)
                cmd.Parameters.AddWithValue("@desc", desc)

                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            End Using

            MessageBox.Show("Category added successfully.")

        ElseIf Me.Tag = "Edit" Then
            ' ✅ Ensure we have a valid CategoryID before updating
            If CategoryID <= 0 Then
                MessageBox.Show("Cannot update because CategoryID is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim query As String = "UPDATE Category SET categoryName = @name, categoryDescription = @desc WHERE categoryID = @id"
            Using cmd As New Microsoft.Data.SqlClient.SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@name", name)
                cmd.Parameters.AddWithValue("@desc", desc)
                cmd.Parameters.AddWithValue("@id", CategoryID)

                conn.Open()
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                conn.Close()

                If rowsAffected > 0 Then
                    MessageBox.Show("Category updated successfully.")
                Else
                    MessageBox.Show("No category was updated. Please check if the CategoryID exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
        End If

        ' ✅ Raise event so main form can reload the DataGridView
        RaiseEvent CategorySaved()
        LogActivity(logUsername, If(Me.Tag = "Add", "added", "edited") & " category: " & name, "Category " & If(Me.Tag = "Add", "Added", "Edited"))
        Me.Close()
    End Sub
End Class
