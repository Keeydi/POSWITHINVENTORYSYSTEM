Imports System.Data.SqlClient
Public Class Pending
    Private connection As SqlConnection

    Private Sub InitializePendingForm()
        Dim btnProcessBackToMain As New Button()
        btnProcessBackToMain.Text = "Process Back to Main"
        btnProcessBackToMain.Location = New Point(10, 10) ' Adjust location as needed
        AddHandler btnProcessBackToMain.Click, AddressOf Button1_Click
        Me.Controls.Add(btnProcessBackToMain)
    End Sub

    Private Sub Pending_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            ' Save action
            Button1_Click(sender, e)
        End If
        If e.KeyCode = Keys.Escape Then
            ' Save action
            Button2_Click(sender, e)
        End If
    End Sub

    Private Sub Pending_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

        LoadTransactionNumbers()
        InitializeDataGridView()
    End Sub
    Private Sub LoadTransactionNumbers()
        Try
            ' Open the database connection
            OpenConnection()

            ' SQL query to get all transaction numbers from the Pendings table
            Dim cmd As New SqlCommand("SELECT DISTINCT TransactionNumber FROM Pendingsprod", connection)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            ' Clear existing items in ComboBox
            ComboBox1.Items.Clear()

            ' Add each transaction number to the ComboBox
            While reader.Read()
                ComboBox1.Items.Add(reader("TransactionNumber").ToString())
            End While

            ' Close the reader
            reader.Close()
        Catch ex As SqlException
            MessageBox.Show("SQL Error loading transaction numbers: " & ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error loading transaction numbers: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub LoadProductsForTransaction(transactionNumber As String)
        Try
            ' Open the database connection
            OpenConnection()

            ' SQL query to get products for the selected TransactionNumber
            Dim cmd As New SqlCommand("SELECT ProductCode, ProductName, Quantity, Price, SubTotal FROM Pendingsprod WHERE TransactionNumber = @TransactionNumber", connection)
            cmd.Parameters.AddWithValue("@TransactionNumber", transactionNumber)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            ' Clear existing rows in the DataGridView to avoid duplicate entries
            dgvPending.Rows.Clear()

            Dim totalPrice As Decimal = 0D ' Initialize total price variable

            ' Load the product details into the DataGridView
            While reader.Read()
                Dim productCode As String = reader(0).ToString()
                Dim productName As String = reader(1).ToString()
                Dim quantity As Integer = Convert.ToInt32(reader(2))
                Dim price As Decimal = Convert.ToDecimal(reader(3))
                Dim subTotal As Decimal = Convert.ToDecimal(reader(4))

                ' Check if the product is already in the DataGridView
                Dim productExists As Boolean = False
                For Each row As DataGridViewRow In dgvPending.Rows
                    If row.Cells(0).Value.ToString() = productCode Then
                        ' If the product exists, update the quantity and subtotal
                        Dim existingQuantity As Integer = Convert.ToInt32(row.Cells(2).Value)
                        row.Cells(2).Value = existingQuantity + quantity
                        row.Cells(4).Value = (existingQuantity + quantity) * price
                        productExists = True
                        Exit For
                    End If
                Next

                ' If the product is not in the DataGridView, add a new row
                If Not productExists Then
                    dgvPending.Rows.Add(productCode, productName, quantity, price, subTotal)
                End If

                ' Add the SubTotal for this product to the total price
                totalPrice += subTotal
            End While

            ' Display the total price in the lblTotal label
            lbltotalprice.Text = "₱" & totalPrice.ToString("N2") ' Format as peso

            ' Close the reader after finishing the loop
            reader.Close()
        Catch ex As SqlException
            MessageBox.Show("SQL Error loading products: " & ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub



    Private Sub OpenConnection()
        Try


            ' Initialize the connection object
            connection = New SqlConnection(Connstring)

            ' Open the connection
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
        Catch ex As Exception
            ' Handle any errors that may have occurred during connection
            MessageBox.Show("Error opening connection: " & ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Close the connection
    Private Sub CloseConnection()
        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem IsNot Nothing Then
            ' Load products for the selected transaction number
            LoadProductsForTransaction(ComboBox1.SelectedItem.ToString)
        End If
    End Sub

    Private Sub btnsettlepayment_Click(sender As Object, e As EventArgs)
        SettlePayment.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnprocess.Click
        ' Ensure a transaction number is selected

        OpenConnection()

        If ComboBox1.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a transaction number to process.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if there are products in the DataGridView
        If dgvPending.Rows.Count = 0 Then
            MessageBox.Show("No products to process for the selected transaction.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Loop through the DataGridView and send data back to the main form
            For Each row As DataGridViewRow In dgvPending.Rows
                If row.IsNewRow Then Continue For ' Skip the new row placeholder

                ' Extract product details from the current row
                Dim productCode As String = row.Cells(0).Value.ToString()
                Dim productName As String = row.Cells(1).Value.ToString()
                Dim quantity As Integer = Convert.ToInt32(row.Cells(2).Value)
                Dim price As Decimal = Convert.ToDecimal(row.Cells(3).Value)
                Dim subTotal As Decimal = Convert.ToDecimal(row.Cells(4).Value)

                ' Call a method on the main form to process this product
                Pointofsalesystem.AddProductFromPending(productCode, productName, quantity, price, subTotal)
            Next
            ' SQL command to delete processed products
            Dim cmd As New SqlCommand("DELETE FROM Pendingsprod WHERE TransactionNumber = @TransactionNumber", connection)
            cmd.Parameters.AddWithValue("@TransactionNumber", ComboBox1.SelectedItem.ToString())

            ' Execute the command
            OpenConnection()
            cmd.ExecuteNonQuery()
            CloseConnection()

            ' Notify user and clear the DataGridView after processing
            MessageBox.Show("Products processed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dgvPending.Rows.Clear()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error processing products: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateTotal()
        Dim total As Decimal = 0

        ' Iterate through each row in the DataGridView to calculate the total
        For Each row As DataGridViewRow In dgvPending.Rows
            If Not row.IsNewRow Then ' Skip the new row placeholder
                Dim totalPriceString As String = row.Cells(4).Value.ToString() ' Assuming total price is in the 5th column (index 4)
                Dim totalPrice As Decimal

                ' Parse the total price value, handling potential formatting issues
                If Decimal.TryParse(totalPriceString.Replace("₱", "").Replace(",", "").Trim(), totalPrice) Then
                    total += totalPrice
                    SettlePayment.txtamount.Text = totalPriceString
                End If
            End If
        Next

        ' Display the total amount in currency format
        lbltotalprice.Text = "₱" & total.ToString("N2")
    End Sub
    Dim productDetails As New Dictionary(Of String, Tuple(Of String, Decimal))


    Public Sub ProcessSelectedItem(ByVal productCode As String)
        Try
            connection.Open()

            ' Check if the "Price" column exists in the Products table
            If Not DoesColumnExist("Products", "Price") Then
                MessageBox.Show("Error processing selected item: Column named 'Price' cannot be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Retrieve the product details, including price
            Dim query As String = "SELECT ProductID, ProductCode, Name, Price, Quantity FROM Products WHERE ProductCode = @ProductCode"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ProductCode", productCode)

                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Retrieve product details
                        Dim retrievedProductCode As String = reader("ProductCode").ToString()
                        Dim productName As String = reader("Name").ToString()
                        Dim price As Decimal = Convert.ToDecimal(reader("Price"))
                        Dim quantity As Integer = Convert.ToInt32(reader("Quantity"))

                        ' Assuming you have a label or textbox to display the total price
                        UpdateTotal(price) ' Call a method to update the total with the retrieved price
                        CompleteSale()


                    Else
                        MessageBox.Show("Product not found. Please check the product code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub
    Private Sub UpdateTotal(price As Decimal)
        ' Assuming you have a variable to hold the current total
        ' This should be updated based on your specific logic (e.g., adding to an existing total)
        currentTotal += price

        ' Update the total amount display, for example:
        lbltotalprice.Text = "₱" & currentTotal.ToString("N2") ' Format as peso

    End Sub
    Private currentTotal As Decimal = 0
    Private Function DoesColumnExist(ByVal tableName As String, ByVal columnName As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @TableName AND COLUMN_NAME = @ColumnName"

        Using command As New SqlCommand(query, connection)
            ' Add the table name and column name parameters to the query
            command.Parameters.AddWithValue("@TableName", tableName)
            command.Parameters.AddWithValue("@ColumnName", columnName)

            ' Ensure the connection is open before executing the command
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Execute the query and return whether the column exists
            Return Convert.ToInt32(command.ExecuteScalar()) > 0
        End Using
    End Function

    Private Sub CompleteSale()
        Try
            For Each row As DataGridViewRow In dgvPending.Rows
                Dim productCode As String = row.Cells("ProductCode").Value.ToString()
                Dim soldQuantity As Integer = Convert.ToInt32(row.Cells("Quantity").Value)

                ' Deduct stock for each sold product
                DeductStock(productCode, soldQuantity)
            Next
        Catch ex As Exception
            MessageBox.Show("Error processing sale: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub DeductStock(productCode As String, soldQuantity As Integer)

        Try
            ' Open database connection if not already open
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Check current stock
            Dim queryCheckStock As String = "SELECT Quantity FROM Products WHERE ProductCode = @ProductCode"
            Dim cmdCheckStock As New SqlCommand(queryCheckStock, connection)
            cmdCheckStock.Parameters.AddWithValue("@ProductCode", productCode)
            Dim currentStock As Integer = Convert.ToInt32(cmdCheckStock.ExecuteScalar())

            ' Ensure enough stock is available
            If currentStock <= soldQuantity Then
                ' Deduct stock
                Dim queryUpdateStock As String = "UPDATE Products SET Quantity = Quantity - @Quantity WHERE ProductCode = @ProductCode"
                Dim cmdUpdateStock As New SqlCommand(queryUpdateStock, connection)
                cmdUpdateStock.Parameters.AddWithValue("@Quantity", soldQuantity)
                cmdUpdateStock.Parameters.AddWithValue("@ProductCode", productCode)
                cmdUpdateStock.ExecuteNonQuery()


            Else
                MessageBox.Show("Not enough stock available!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating stock: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close database connection
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
    Private Sub AddOrUpdateItem(barcode As String)
        Dim itemFound As Boolean = False

        ' Loop through each row in DataGridView to check if item already exists
        For Each row As DataGridViewRow In dgvPending.Rows
            ' Assuming "Product Code" is the name of the column for the barcode
            If row.Cells("Product Code").Value.ToString() = barcode Then
                ' Item found, increase quantity
                Dim currentQuantity As Integer = Convert.ToInt32(row.Cells("Quantity").Value)
                row.Cells("Quantity").Value = currentQuantity + 1

                ' Update the total price for this row
                Dim price As Decimal = Convert.ToDecimal(row.Cells("Price").Value)
                row.Cells("Total Price").Value = (currentQuantity + 1) * price

                itemFound = True
                Exit For
            End If
        Next

        ' If item was not found, add a new row
        If Not itemFound Then
            ' Assuming columns are: Product Code, Product Name, Quantity, Price, Total Price
            ' You may adjust column names or indexes as per your setup
            Dim productName As String = "" ' Retrieve the product name based on barcode
            Dim price As Decimal = 0 ' Retrieve the price based on barcode

            ' Calculate initial total price (quantity is 1)
            Dim totalPrice As Decimal = price * 1

            ' Add a new row to DataGridView
            dgvPending.Rows.Add(barcode, productName, 1, price, totalPrice)
        End If

        ' Update the overall total to pay
        UpdateTotalToPay()
    End Sub
    Private Sub UpdateTotalToPay()
        Dim total As Decimal = 0
        For Each row As DataGridViewRow In dgvPending.Rows
            total += Convert.ToDecimal(row.Cells("Total Price").Value)
        Next
        lbltotalprice.Text = "₱" & total.ToString("N2")
    End Sub




    Private Sub InitializeDataGridView()
        ' Clear any existing columns (only if needed)
        ' Clear existing columns if any
        If dgvPending.Columns.Count > 0 Then
            dgvPending.Columns.Clear()
        End If

        ' Set the AutoSizeColumnsMode to make the columns fit the entire DataGridView
        dgvPending.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPending.DefaultCellStyle.Font = New Font("Microsoft JhengHei UI", 10, FontStyle.Regular)
        dgvPending.RowTemplate.Height = 40
        dgvPending.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft JhengHei UI", 12, FontStyle.Bold)
        ' Add the necessary columns
        dgvPending.Columns.Add("ProductCode", "Product Code")
        dgvPending.Columns.Add("Name", "Product Name")
        dgvPending.Font = New Font("Microsoft JhengHei UI", 16, FontStyle.Regular)

        ' Adding the Quantity column as an Integer type
        Dim qtyColumn As New DataGridViewTextBoxColumn
        qtyColumn.Name = "Quantity"
        qtyColumn.HeaderText = "Quantity"
        qtyColumn.ValueType = GetType(Integer) ' Ensures it accepts only integer values
        dgvPending.Columns.Add(qtyColumn)


        ' Adding the Price column as Decimal type, with appropriate formatting for currency
        Dim priceColumn As New DataGridViewTextBoxColumn
        priceColumn.Name = "Price"
        priceColumn.HeaderText = "Price"
        priceColumn.ValueType = GetType(Decimal)
        priceColumn.DefaultCellStyle.Format = "C2" ' Currency format
        dgvPending.Columns.Add(priceColumn)

        ' Adding the TotalPrice column as Decimal type
        Dim totalPriceColumn As New DataGridViewTextBoxColumn
        totalPriceColumn.Name = "TotalPrice"
        totalPriceColumn.HeaderText = "Total Price"
        totalPriceColumn.ValueType = GetType(Decimal)
        totalPriceColumn.DefaultCellStyle.Format = "C2" ' Currency format
        dgvPending.Columns.Add(totalPriceColumn)

        ' Adding the "Add to Payment" button column


        ' Optionally, set specific columns to auto-size based on content
        dgvPending.Columns("ProductCode").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvPending.Columns("Name").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill ' Fills remaining space
        dgvPending.Columns("Quantity").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvPending.Columns("Price").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvPending.Columns("TotalPrice").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Close()
    End Sub
    Private Sub BtnProcessBackToMain_Click(sender As Object, e As EventArgs) Handles btnprocess.Click
        ' Ensure a transaction number is selected
        If ComboBox1.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a transaction number first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Retrieve the transaction number from the ComboBox
        Dim transactionNumber As String = ComboBox1.SelectedItem.ToString()

        ' Reference the main form
        Dim mainForm As Pointofsalesystem = CType(Application.OpenForms("Pointofsalesystem"), Pointofsalesystem)
        If mainForm IsNot Nothing Then
            ' Collect pending products and pass them to the main form
            mainForm.LoadPendingProducts(transactionNumber, CollectPendingProducts())
            MessageBox.Show("Pending products processed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Pointofsalesystem.btnsettlepayment.Enabled = True
            Pointofsalesystem.btnquantity.Enabled = True
            Me.Close() ' Close the pending form
        Else
            MessageBox.Show("Main form not found. Cannot process pending products.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function CollectPendingProducts() As List(Of Dictionary(Of String, Object))
        Dim products As New List(Of Dictionary(Of String, Object))()

        ' Loop through each row in the DataGridView to collect product details
        For Each row As DataGridViewRow In dgvPending.Rows
            If Not row.IsNewRow Then
                Dim productDetails As New Dictionary(Of String, Object) From {
                    {"ProductCode", row.Cells("ProductCode").Value},
                    {"ProductName", row.Cells("ProductName").Value},
                    {"Quantity", row.Cells("Quantity").Value},
                    {"Price", row.Cells("Price").Value},
                    {"SubTotal", row.Cells("SubTotal").Value}
                }
                products.Add(productDetails)
            End If
        Next

        Return products
    End Function

End Class