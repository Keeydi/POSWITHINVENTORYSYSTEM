Imports System.Data.SqlClient
Public Class qdefects

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
        SaveData()
    End Sub

    Public DproductID As Integer
    Public DproductCode As String
    Public DproductName As String
    Private Sub SaveData()



        ' Run INSERT and UPDATE together (separated by semicolon)
        Dim query As String = "INSERT INTO Defects (ProductID, ProductCode, ProductName, Stock) " &
                          "VALUES (@ProdID, @ProductCode, @ProductName, @Stock); " &
                          "UPDATE Product SET Stock = Stock - @Stock WHERE ProductID = @ProdID;"
        Dim conn As New SqlClient.SqlConnection(Connect.Connstring)
        Using cmd As New SqlClient.SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@ProdID", DproductID)
            cmd.Parameters.AddWithValue("@ProductCode", DproductCode)
            cmd.Parameters.AddWithValue("@ProductName", DproductName)
            cmd.Parameters.AddWithValue("@Stock", Convert.ToInt32(txtquantity.Text)) ' Make sure it's numeric

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
        End Using

        MessageBox.Show("Product defect saved successfully and stock updated.")

        txtprodid.Clear()
        txtquantity.Clear()
        LogActivity(logUsername, "Report Defect", "Reported Defect for Item " & DproductID & " with Quantity " & txtquantity.Text)
        Me.Close()

    End Sub
End Class