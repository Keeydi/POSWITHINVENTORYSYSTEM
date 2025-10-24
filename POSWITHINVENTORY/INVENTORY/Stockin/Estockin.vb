Imports System.Data.SqlClient
Public Class Estockin

    Private Sub Estockin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load current stock when form opens
        LoadCurrentStock()
    End Sub
    
    ' Function to load and display current stock
    Private Sub LoadCurrentStock()
        If String.IsNullOrEmpty(txtprodid.Text) Then Return
        
        Dim connection As New SqlClient.SqlConnection(Connstring)
        Try
            connection.Open()
            
            Dim query As String = "SELECT Stock FROM Product WHERE ProductID = @prodID"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@prodID", txtprodid.Text)
                
                Dim currentStock As Object = command.ExecuteScalar()
                If currentStock IsNot Nothing Then
                    txtquantity.Text = currentStock.ToString()
                    txtquantity.Focus()
                    txtquantity.SelectAll() ' Select all text for easy editing
                End If
            End Using
            
        Catch ex As Exception
            MessageBox.Show("Error loading current stock: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        If MessageBox.Show("Are you sure you want to cancel?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtquantity.Text = "" Then
            MessageBox.Show("Please enter the quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtquantity.Focus()
            Return
        End If
        
        ' Validate that the quantity is a positive number
        Dim newQuantity As Integer
        If Not Integer.TryParse(txtquantity.Text, newQuantity) OrElse newQuantity < 0 Then
            MessageBox.Show("Please enter a valid positive quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtquantity.Focus()
            Return
        End If
        
        ' Check if the new quantity is greater than or equal to current stock
        If Not ValidateStockIncrease(newQuantity) Then
            Return
        End If
        
        SaveData()
    End Sub
    
    ' Function to validate that the new stock quantity is not less than current stock
    Private Function ValidateStockIncrease(newQuantity As Integer) As Boolean
        Dim connection As New SqlClient.SqlConnection(Connstring)
        Try
            connection.Open()
            
            ' Get current stock for the product
            Dim query As String = "SELECT Stock FROM Product WHERE ProductID = @prodID"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@prodID", txtprodid.Text)
                
                Dim currentStock As Integer = Convert.ToInt32(command.ExecuteScalar())
                
                ' Check if new quantity is less than current stock
                If newQuantity < currentStock Then
                    MessageBox.Show($"Cannot decrease stock! Current stock is {currentStock}. " &
                                  $"You can only set stock to {currentStock} or higher.", 
                                  "Stock Decrease Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtquantity.Text = currentStock.ToString()
                    txtquantity.Focus()
                    Return False
                End If
                
                Return True
            End Using
            
        Catch ex As Exception
            MessageBox.Show("Error validating stock: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            connection.Close()
        End Try
    End Function
    
    Private Sub SaveData()
        Dim connection As New SqlClient.SqlConnection(Connstring)
        Dim newQuantity As Integer = Convert.ToInt32(txtquantity.Text)
        Dim productID As String = txtprodid.Text
        
        Try
            connection.Open()

            ' Get current stock before updating
            Dim getCurrentStockQuery As String = "SELECT Stock FROM Product WHERE ProductID = @prodID"
            Dim currentStock As Integer = 0
            
            Using getCurrentStockCmd As New SqlCommand(getCurrentStockQuery, connection)
                getCurrentStockCmd.Parameters.AddWithValue("@prodID", productID)
                currentStock = Convert.ToInt32(getCurrentStockCmd.ExecuteScalar())
            End Using

            ' Update stock to new quantity
            Dim query As String = "UPDATE Product SET Stock = @quantity " &
                                 "WHERE ProductID = @prodID"

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@prodID", productID)
                command.Parameters.AddWithValue("@quantity", newQuantity)
                command.ExecuteNonQuery()
                
                ' Show success message with stock information
                Dim stockChange As Integer = newQuantity - currentStock
                MessageBox.Show($"Stock updated successfully!{vbCrLf}" &
                              $"Previous stock: {currentStock}{vbCrLf}" &
                              $"New stock: {newQuantity}{vbCrLf}" &
                              $"Change: +{stockChange} units", 
                              "Stock Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
        
        LogActivity(logUsername, "Edit Stock", $"Updated Product ID {productID} stock to {newQuantity}")
        txtprodid.Clear()
        txtquantity.Clear()
        Me.Close()
    End Sub
End Class