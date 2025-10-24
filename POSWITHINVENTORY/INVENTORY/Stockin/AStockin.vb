Imports System.Data.SqlClient
Public Class AStockin
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
        Dim addQuantity As Integer
        If Not Integer.TryParse(txtquantity.Text, addQuantity) OrElse addQuantity <= 0 Then
            MessageBox.Show("Please enter a valid positive quantity to add.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtquantity.Focus()
            Return
        End If
        
        SaveData()
    End Sub
    Private Sub SaveData()
        Dim connection As New SqlClient.SqlConnection(Connstring)
        Dim addQuantity As Integer = Convert.ToInt32(txtquantity.Text)
        Dim productID As String = txtprodid.Text
        
        Try
            connection.Open()

            ' First get current stock to show in success message
            Dim getCurrentStockQuery As String = "SELECT Stock FROM Product WHERE ProductID = @prodID"
            Dim currentStock As Integer = 0
            
            Using getCurrentStockCmd As New SqlCommand(getCurrentStockQuery, connection)
                getCurrentStockCmd.Parameters.AddWithValue("@prodID", productID)
                currentStock = Convert.ToInt32(getCurrentStockCmd.ExecuteScalar())
            End Using

            ' Update stock and insert stock in record
            Dim query As String = "UPDATE Product SET Stock = Stock + @quantity " &
                      "WHERE ProductID = @prodID; " &
                      "INSERT INTO Stockin (ProductID, Quantity, DateStockIn) " &
                      "VALUES (@prodID, @quantity, GETDATE());"

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@prodID", productID)
                command.Parameters.AddWithValue("@quantity", addQuantity)
                command.ExecuteNonQuery()
                
                ' Show success message with stock information
                Dim newStock As Integer = currentStock + addQuantity
                MessageBox.Show($"Stock added successfully!{vbCrLf}" &
                              $"Added: {addQuantity} units{vbCrLf}" &
                              $"Previous stock: {currentStock}{vbCrLf}" &
                              $"New stock: {newStock}", 
                              "Stock Added Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
        
        LogActivity(logUsername, "Stock In", $"Added {addQuantity} units to Product ID {productID}")
        txtprodid.Clear()
        txtquantity.Clear()
        Me.Close()
    End Sub
End Class