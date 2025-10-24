Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Drawing

Public Class Pointofsalesystem

    Private Const SuggestionHeight As Integer = 25
    Private Const MaxSuggestions As Integer = 5

    Private connection As SqlConnection



    Private Sub Pointofsalesystem_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            ' Trigger the Settle Payment function
            payment_Click(sender, e)
        End If
        If e.KeyCode = Keys.F2 Then
            ' Trigger the Settle Payment function
            quantity_Click(sender, e)
        End If
        If e.KeyCode = Keys.F3 Then
            ' Trigger the Settle Payment function
            newtransac_Click(sender, e)
        End If
        If e.KeyCode = Keys.F4 Then
            ' Trigger the Settle Payment function
            transachis_Click(sender, e)
        End If
        If e.KeyCode = Keys.F5 Then
            ' Trigger the Settle Payment function
            'Button2_Click_3(sender, e)
        End If
        If e.KeyCode = Keys.F6 Then
            ' Trigger the Settle Payment function
            btnvoid_Click(sender, e)
        End If
        If e.KeyCode = Keys.F7 Then
            ' Trigger the Settle Payment function
            CLEAR_Click(sender, e)
        End If
        If e.KeyCode = Keys.F10 Then
            ' Trigger the Settle Payment function
            logout_Click(sender, e)
        End If
        If e.KeyCode = Keys.F8 Then
            ' Trigger the Settle Payment function
            restransac_Click_4(sender, e)
        End If
        If e.KeyCode = Keys.F9 Then
            ' Trigger the Settle Payment function
            pendtrans_Click_1(sender, e)
        End If
    End Sub

    ' Initialize the connection in the Form's Load event or constructor
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the database connection
        connection = New SqlConnection(Connstring)
        newtransac_Click(sender, e) ' Start a new transaction on load
    End Sub
    Public Sub ProcessSelectedItem(ByVal productCode As String)
        Try
            connection.Open()

            ' Check if the "Price" column exists in the Products table
            If Not DoesColumnExist("Products", "Price") Then
                MessageBox.Show("Error processing selected item: Column named 'Price' cannot be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Retrieve the product details, including price
            Dim query As String = "SELECT ProductID, ProductCode, ProductName, Unitrice, Stock FROM Product WHERE ProductCode = @ProductCode"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ProductCode", productCode)

                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Retrieve product details
                        Dim retrievedProductCode As String = reader("ProductCode").ToString()
                        Dim productName As String = reader("ProductName").ToString()
                        Dim price As Decimal = Convert.ToDecimal(reader("UnitPrice"))
                        Dim quantity As Integer = Convert.ToInt32(reader("Stock"))

                        ' Process the product in the POS system
                        ProcessProduct(retrievedProductCode, productName, price, quantity)

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
        lbltotal.Text = "₱" & currentTotal.ToString("N2") ' Format as peso

    End Sub
    Private currentTotal As Decimal = 0

    ' Constructor
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Other initialization code here
    End Sub
    ' In your main form
    ' In your main form



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


    Private Sub ProcessProduct(ByVal productCode As String, ByVal productName As String, ByVal price As Decimal, ByVal quantity As Integer)
        ' Code to process the product in the POS system
        ' MessageBox.Show("Product: " & productName & ", Price: " & price.ToString("C2") & ", Quantity: " & quantity.ToString(), "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Additional processing logic
    End Sub
    Private Sub InitializeDataGridView()
        ' Clear any existing columns (only if needed)
        ' Clear existing columns if any
        If dgvcart.Columns.Count > 0 Then
            dgvcart.Columns.Clear()
        End If

        ' Set the AutoSizeColumnsMode to make the columns fit the entire DataGridView
        dgvcart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvcart.DefaultCellStyle.Font = New Font("Microsoft JhengHei UI", 16, FontStyle.Regular)
        dgvcart.RowTemplate.Height = 40
        dgvcart.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft JhengHei UI", 18, FontStyle.Bold)
        With dgvcart
            ' Remove all borders
            .BorderStyle = BorderStyle.None
            .CellBorderStyle = DataGridViewCellBorderStyle.None
            .RowHeadersVisible = False
            .ColumnHeadersVisible = True
            .GridColor = Color.White ' makes gridlines invisible
            .BorderStyle = BorderStyle.Fixed3D
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .GridColor = Color.Black
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .ReadOnly = True

            ' Alternating rows
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

            ' Selection
            .RowsDefaultCellStyle.SelectionBackColor = Color.LightBlue
            .RowsDefaultCellStyle.SelectionForeColor = Color.Black

            ' Header
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
            '.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        End With
        ' Add the necessary columns
        dgvcart.Columns.Add("ProductCode", "Product Code")
        dgvcart.Columns.Add("ProductName", "Product Name")
        dgvcart.Font = New Font("Microsoft JhengHei UI", 30, FontStyle.Regular)

        ' Adding the Quantity column as an Integer type
        Dim qtyColumn As New DataGridViewTextBoxColumn
        qtyColumn.Name = "Stock"
        qtyColumn.HeaderText = "Quantity"
        qtyColumn.ValueType = GetType(Integer) ' Ensures it accepts only integer values
        dgvcart.Columns.Add(qtyColumn)

        ' Adding the Price column as Decimal type, with appropriate formatting for currency
        Dim priceColumn As New DataGridViewTextBoxColumn
        priceColumn.Name = "UnitPrice"
        priceColumn.HeaderText = "Price"
        priceColumn.ValueType = GetType(Decimal)
        priceColumn.DefaultCellStyle.Format = "₱#,##0.00"
        dgvcart.Columns.Add(priceColumn)

        ' Adding the TotalPrice column as Decimal type
        Dim totalPriceColumn As New DataGridViewTextBoxColumn
        totalPriceColumn.Name = "TotalPrice"
        totalPriceColumn.HeaderText = "Total Price"
        totalPriceColumn.ValueType = GetType(Decimal)
        totalPriceColumn.DefaultCellStyle.Format = "₱#,##0.00"
        dgvcart.Columns.Add(totalPriceColumn)

        ' Adding the hidden ProductID column
        Dim productIdColumn As New DataGridViewTextBoxColumn
        productIdColumn.Name = "ProductID"
        productIdColumn.HeaderText = "Product ID"
        productIdColumn.Visible = False ' Hide this column
        dgvcart.Columns.Add(productIdColumn)

        ' Optionally, set specific columns to auto-size based on content
        dgvcart.Columns("ProductCode").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvcart.Columns("ProductName").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill ' Fills remaining space
        dgvcart.Columns("Stock").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvcart.Columns("UnitPrice").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvcart.Columns("TotalPrice").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub

    Private Sub DataGridView1_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs)
        If e.ColumnIndex >= 0 AndAlso dgvcart.Columns(e.ColumnIndex).Name = "Add" AndAlso e.RowIndex >= 0 Then
            ' Change the background color when hovering over the button
            dgvcart.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor = Color.LightBlue
        End If
    End Sub

    ' Handles the animation when the mouse leaves
    Private Sub DataGridView1_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs)
        If e.ColumnIndex >= 0 AndAlso dgvcart.Columns(e.ColumnIndex).Name = "Add" AndAlso e.RowIndex >= 0 Then
            ' Restore the original background color
            dgvcart.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor = Color.White
        End If
    End Sub

    ' Handles the click animation effect
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.ColumnIndex >= 0 AndAlso dgvcart.Columns(e.ColumnIndex).Name = "Add" AndAlso e.RowIndex >= 0 Then
            ' Simulate a click animation by briefly changing the background color
            Dim cell As DataGridViewCell = dgvcart.Rows(e.RowIndex).Cells(e.ColumnIndex)
            cell.Style.BackColor = Color.LightGreen

            ' Use a timer to reset the color after a short delay (100 milliseconds)
            Dim t As New Timer()
            t.Interval = 100
            AddHandler t.Tick, Sub()
                                   cell.Style.BackColor = Color.White
                                   t.Stop()
                               End Sub
            t.Start()

            ' You can also execute other actions related to adding the item here.
        End If
    End Sub

    ' Event to change button color in DataGridView


    Private Sub txtxbarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtxbarcode.KeyDown
        ' Check if the pressed key is Enter
        If e.KeyCode = Keys.Enter Then
            ' Call the method to add the product details to the DataGridView
            AddToDataGridView()

            ' Optionally, clear the TextBoxes for new entries
            txtxbarcode.Clear()


            ' Move focus back to the product selection TextBox
            txtxbarcode.Focus()

            ' Prevent the Enter key from making a "ding" sound or triggering other events
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub newtransac_Click(sender As Object, e As EventArgs) Handles btnnewtransac.Click
        Dim transactionNumber As String = GenerateTransactionNum()
        lbltransnum.Text = transactionNumber
        lblcash.Text = "0.00" ' Clear lblCash
        lbltotal.Text = "0.00" ' Reset total to 0 (optional if needed)
        ' Reset any other fields relevant to a new transaction
        dgvcart.Rows.Clear() ' Clear all items in the DataGridView (if required for new transactions)
        lblchange.Text = "0.00" ' Clear the change field
    End Sub

    Private Function GenerateTransactionNum() As String
        Dim transactionNumber As String = String.Empty

        Using conn As New SqlConnection(Connstring)
            Dim query As String = "DECLARE @TransactionNumber VARCHAR(50), @TransactionID INT, @TransactionDate VARCHAR(20); SET @TransactionDate = CONVERT(VARCHAR(14), GETDATE(), 112) + REPLACE(CONVERT(VARCHAR(8), GETDATE(), 108), ':', ''); SELECT @TransactionID = ISNULL(MAX(TransactionID), 0) + 1 FROM viewTransactions; SET @TransactionNumber = @TransactionDate + '-' + RIGHT('0000' + CAST(@TransactionID AS VARCHAR(4)), 4); SELECT @TransactionNumber AS NewTransactionNumber;"


            Using cmd As New SqlCommand(query, conn)
                conn.Open()

                ' Execute the query and get the transaction number
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        transactionNumber = reader("NewTransactionNumber").ToString()
                    End If
                End Using
            End Using
        End Using

        Return transactionNumber
    End Function




    Private Sub transachis_Click(sender As Object, e As EventArgs) Handles btntransachis.Click
        Dim transactionHistoryForm As New frmtransactionhistory()
        transactionHistoryForm.TransactionID = lbltransnum.Text ' Set the ID of the transaction you want to view
        transactionHistoryForm.ShowDialog()
        'ReturnSales.Show()


    End Sub

    Private Sub payment_Click(sender As Object, e As EventArgs) Handles btnsettlepayment.Click
        ' Validate if the cart has items
        If dgvcart.Rows.Count = 0 OrElse dgvcart.Rows(0).IsNewRow Then
            MessageBox.Show("No items in the cart. Please add items to proceed with the payment.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            lbltotal.Text = "0.00"
            lblcash.Text = "0.00"
            lblchange.Text = "0.00"
            Return
        End If
        Dim subtotal As Decimal = 0

        ' Calculate the subtotal from the DataGridView
        For Each row As DataGridViewRow In dgvcart.Rows
            If Not row.IsNewRow Then
                Try
                    Dim cellValue As String = row.Cells(4).Value.ToString().Replace("₱", "").Replace(",", "").Trim()
                    Dim rowTotal As Decimal
                    If Decimal.TryParse(cellValue, rowTotal) Then
                        subtotal += rowTotal
                    End If
                Catch ex As Exception
                    ' Skip this row if there's an error
                    Continue For
                End Try
            End If
        Next
        lbltotal.Text = subtotal.ToString("C2") ' Display subtotal in currency format

        ' Open the settle payment form
        Using settlePaymentForm As New SettlePayment()
            settlePaymentForm.Subtotal = subtotal ' Pass the subtotal to the settle payment form
            settlePaymentForm.txtamount.Text = lbltotal.Text
            settlePaymentForm.txtamount.Text = subtotal
            lbltotal.Text = subtotal


            If settlePaymentForm.ShowDialog() = DialogResult.OK Then
                Dim cashGiven As Decimal = settlePaymentForm.txtcash.Text
                Dim change As Decimal = cashGiven - subtotal

                ' Display the change on the settle payment form
                settlePaymentForm.txtchange.Text = change


                ' Display the cash given and change in the main POS form (you can update the labels accordingly)
                lblcash.Text = cashGiven.ToString("C2")
                lblchange.Text = change.ToString("C2")

            End If
        End Using

    End Sub





    Private Sub quantity_Click(sender As Object, e As EventArgs) Handles btnquantity.Click

        If dgvcart.SelectedRows.Count > 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = dgvcart.SelectedRows(0)

            ' Retrieve product details
            Dim productCode As String = selectedRow.Cells(0).Value.ToString() ' Assuming column 0 is the product code
            Dim currentQuantity As Integer = Convert.ToInt32(selectedRow.Cells(2).Value)

            ' Create an instance of AddQuantityForm
            Using addQuantityForm As New Addqty()
                addQuantityForm.SProductName = selectedRow.Cells(1).Value.ToString() ' Product Name
                addQuantityForm.CurrentQuantity = currentQuantity

                ' Show the form and check the dialog result
                If addQuantityForm.ShowDialog() = DialogResult.OK Then
                    ' Get the new quantity entered by the user
                    Dim newQuantity As Integer = addQuantityForm.NewQuantity

                    ' Check available stock from the database
                    Dim availableStock As Integer = GetStockFromDatabase(productCode)

                    ' Ensure there is enough stock
                    If availableStock >= newQuantity Then
                        ' Update the quantity and subtotal
                        selectedRow.Cells(2).Value = newQuantity

                        ' Assuming column 3 is the price
                        Dim price As Decimal = 0
                        Try
                            Dim priceText As String = selectedRow.Cells(3).Value.ToString().Replace("₱", "").Replace(",", "").Trim()
                            If Not Decimal.TryParse(priceText, price) Then
                                price = 0
                            End If
                        Catch ex As Exception
                            price = 0
                        End Try
                        selectedRow.Cells(4).Value = newQuantity * price ' Column 4 is the total price

                        ' Update the total price
                        UpdateTotalPrice()
                    Else
                        MessageBox.Show("Not enough stock available. Only " & availableStock & " units are available.", "Stock Shortage", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If
            End Using
        Else
            MessageBox.Show("Please select an item from the list to add quantity.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Function GetStockFromDatabase(productCode As String) As Integer
        Dim stock As Integer = 0
        Try
            Using connection As New SqlConnection(Connstring),
                  command As New SqlCommand("SELECT Stock FROM Product WHERE ProductCode = @ProductCode", connection)
                command.Parameters.AddWithValue("@ProductCode", productCode)

                connection.Open()
                stock = Convert.ToInt32(command.ExecuteScalar())
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return stock
    End Function

    Private Sub UpdateStockInDatabase(itemCode As String, newStock As Integer)
        ' Update the stock in the database after a sale or quantity update
        Dim query As String = "UPDATE Product SET Stock = @Quantity WHERE ProductCode = @ProductCode"
        Using conn As New SqlConnection(Connstring)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Quantity", newStock)
                cmd.Parameters.AddWithValue("@ProductCode", itemCode)
                conn.Open()

                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub UpdateTotalPrice()
        Dim total As Decimal = 0
        For Each row As DataGridViewRow In dgvcart.Rows
            If Not row.IsNewRow Then
                Try
                    Dim cellValue As String = row.Cells(4).Value.ToString().Replace("₱", "").Replace(",", "").Trim()
                    Dim rowTotal As Decimal
                    If Decimal.TryParse(cellValue, rowTotal) Then
                        total += rowTotal
                    End If
                Catch ex As Exception
                    ' Skip this row if there's an error
                    Continue For
                End Try
            End If
        Next
        lbltotal.Text = total.ToString("C2") ' Update your total label

    End Sub
    Private Sub logout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        'Me.Hide()
        'Login.Show()
        ' Show a message box asking for logout confirmation
        Dim result = MessageBox.Show("Are you sure you want to Exist?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Check the user's response
        If result = DialogResult.Yes Then
            ' Code to log out the user
            'MessageBox.Show("You have successfully logged out.", "Logged Out", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'LogActivity(LblUser.Text, "Admin Logout", "Logged out : " & LblUser.Text & " ")
            txtxbarcode.Focus()
            Me.Close()
            'Login.txtusername.Focus()
            'Login.Guna2CheckBox1.Checked = False
            'Admin.Dashb()
        Else
            ' User clicked "No", do nothing or handle accordingly
            'MessageBox.Show("Logout cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnvoid_Click(sender As Object, e As EventArgs) Handles btnvoidprod.Click
        Dim passwordForm As New frmvoidpass(Me)
        passwordForm.ShowDialog()
    End Sub


    Private Sub Pointofsalesystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        UpdateButtonStates()
        Timer1.Start()
        Timer1.Interval = 1000
        InitializeDataGridView()
        LoadProductCodesAndNames()
        txtxbarcode.Text = ""

    End Sub
    ' Declare a global dictionary to store product details (ProductCode as key)
    Dim productDetails As New Dictionary(Of String, Tuple(Of String, Decimal))

    Private Sub LoadProductCodesAndNames()
        ' Define the connection string (replace with your database details)


        ' SQL Query to fetch product codes, names, and prices
        Dim query As String = "SELECT ProductCode, ProductName, UnitPrice FROM Product WHERE IsArchived = 0 AND Stock > 0"

        ' Create a connection and command to fetch data
        Using conn As New SqlConnection(Connstring)
            Using cmd As New SqlCommand(query, conn)
                Try
                    conn.Open()
                    Dim reader As SqlDataReader = cmd.ExecuteReader()

                    ' Create an AutoCompleteStringCollection to store product codes and names
                    Dim productCodesAndNames As New AutoCompleteStringCollection()

                    ' Populate the collection with concatenated product codes and names
                    While reader.Read()
                        Dim productCode As String = reader("ProductCode").ToString()
                        Dim productName As String = reader("ProductName").ToString()
                        Dim price As Decimal = Convert.ToDecimal(reader("UnitPrice"))

                        ' Add to autocomplete suggestions
                        productCodesAndNames.Add(productCode & " - " & productName)
                        productCodesAndNames.Add(productName)
                        ' Store the product details in the dictionary using Tuple
                        productDetails(productCode) = Tuple.Create(productName, price)
                    End While

                    ' Set the AutoComplete properties of the TextBox
                    txtxbarcode.AutoCompleteMode = AutoCompleteMode.Suggest
                    txtxbarcode.AutoCompleteSource = AutoCompleteSource.CustomSource
                    txtxbarcode.AutoCompleteCustomSource = productCodesAndNames

                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub AddToDataGridView()
        Dim productCode As String = txtxbarcode.Text.Trim()
        Dim productName As String = txtxbarcode.Text.Trim() ' Text field for product name search

        If String.IsNullOrEmpty(productCode) AndAlso String.IsNullOrEmpty(productName) Then
            MessageBox.Show("Please enter a valid product code or product name.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If connection Is Nothing Then
            MessageBox.Show("Database connection is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using connection As New SqlConnection(Connstring),
                  command As New SqlCommand("SELECT ProductID, ProductCode, ProductName, UnitPrice, Stock FROM Product WHERE (ProductCode = @ProductCode OR ProductName LIKE @ProductName) AND IsArchived = 0", connection)

                ' Add parameters for product code and name
                command.Parameters.AddWithValue("@ProductCode", If(String.IsNullOrEmpty(productCode), DBNull.Value, productCode))
                command.Parameters.AddWithValue("@ProductName", "%" & productName & "%") ' Allows partial matching for product name

                connection.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Retrieve ProductID and save to the public variable
                        Dim retrievedProductID As Integer = Convert.ToInt32(reader("ProductID"))

                        ' Retrieve other product details
                        Dim retrievedProductCode As String = reader("ProductCode").ToString()
                        Dim retrievedProductName As String = reader("ProductName").ToString()
                        Dim price As Decimal = Convert.ToDecimal(reader("UnitPrice"))
                        Dim availableStock As Integer = Convert.ToInt32(reader("Stock"))

                        ' Check if the product already exists in the DataGridView
                        Dim itemFound As Boolean = False

                        For Each row As DataGridViewRow In dgvcart.Rows
                            If row.Cells(0).Value.ToString() = retrievedProductCode Then
                                ' Product already exists, check if there's enough stock to add more
                                Dim currentQuantity As Integer = Convert.ToInt32(row.Cells(2).Value)

                                If currentQuantity < availableStock Then
                                    row.Cells(2).Value = currentQuantity + 1
                                    row.Cells(4).Value = (currentQuantity + 1) * price
                                    itemFound = True
                                Else
                                    ' Show warning and prevent adding if insufficient stock
                                    MessageBox.Show("Not enough stock available. Only " & availableStock & " units are available.", "Stock Shortage", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    Return
                                End If
                                Exit For
                            End If
                        Next

                        ' If item is not found, check if stock is available before adding it
                        If Not itemFound Then
                            If availableStock > 0 Then
                                Dim quantity As Integer = 1
                                Dim totalPrice As Decimal = quantity * price
                                Dim row As String() = {retrievedProductCode, retrievedProductName, quantity.ToString(), price.ToString("C"), totalPrice.ToString("C")}
                                dgvcart.Rows.Add(row)

                                ' Update the hidden ProductID column
                                dgvcart.Rows(dgvcart.Rows.Count - 1).Cells("ProductID").Value = retrievedProductID
                            Else
                                ' Show warning and prevent adding if insufficient stock
                                MessageBox.Show("Not enough stock available. The product cannot be added.", "Stock Shortage", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If
                        End If

                        ' Clear the input fields for the next entry
                        txtxbarcode.Clear()

                        ' Update the total amount
                        UpdateTotal()
                    Else
                        MessageBox.Show("Product not found or is archived. Please check the product code or name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using

            ' Update button states after adding the product
            UpdateButtonStates()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub UpdateButtonStates()
        ' Enable or disable buttons based on the DataGridView row count
        Dim hasProducts As Boolean = dgvcart.Rows.Count > 0

        btnsettlepayment.Enabled = hasProducts
        btnquantity.Enabled = hasProducts
        btnrestran.Enabled = hasProducts
    End Sub



    ' This method updates the total based on the items in the DataGridView
    Private Sub UpdateTotal()
        Dim total As Decimal = 0

        ' Iterate through each row in the DataGridView to calculate the total
        For Each row As DataGridViewRow In dgvcart.Rows
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

        ' Display the total amount in peso format
        lbltotal.Text = "₱" & total.ToString("N2")
    End Sub

    Private Sub UpdateDateTime()
        ' Set the text of the date label to the current date
        lbldate.Text = DateTime.Now.ToString("D")

        ' Set the text of the time label to the current time
        lbltime.Text = DateTime.Now.ToString("T")
    End Sub
    'Private Sub Button11_Click(sender As Object, e As EventArgs)
    '    frmPrint.ShowDialog()

    'End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        UpdateDateTime()
    End Sub


    Private Sub dgvcart_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcart.CellClick
        ' Ensure the click is on a valid cell
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Select the row of the clicked cell
            dgvcart.Rows(e.RowIndex).Selected = True
        End If
    End Sub

    Private selectedItems As New Dictionary(Of String, Integer) ' Key: Product Code, Value: Quantity
    Private total As Decimal = 0 ' Track cumulative total at class level

    Private Sub dgvcart_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcart.CellContentClick
        ' Assuming this code is within the DataGridView's event handler (e.g., CellContentClick)


        ' Get the selected row
        Dim selectedRow As DataGridViewRow = dgvcart.Rows(e.RowIndex)

        ' Get the product details
        Dim productCode As String = selectedRow.Cells(0).Value.ToString()
        Dim productName As String = selectedRow.Cells(1).Value.ToString()
        Dim priceString As String = selectedRow.Cells("UnitPrice").Value.ToString()
        Dim price As Decimal

        ' Parse the price value, handling potential formatting issues
        If Decimal.TryParse(priceString.Replace("₱", "").Replace(",", "").Trim(), price) Then
            ' If the product is already in the dictionary, increase the quantity
            If selectedItems.ContainsKey(productCode) Then
                selectedItems(productCode) += 1 ' Increase quantity for existing product
            Else
                selectedItems.Add(productCode, 1) ' Add new product with quantity 1
            End If

            ' Calculate and update the total
            total += price
            lbltotal.Text = "₱" & total.ToString("N2") ' Display updated total in peso format
        End If


    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RecalculateTotal()
        Dim total As Decimal = 0
        For Each row As DataGridViewRow In dgvcart.Rows
            Try
                Dim priceText As String = row.Cells(3).Value.ToString().Replace("₱", "").Replace(",", "").Trim()
                Dim qtyText As String = row.Cells(2).Value.ToString()
                Dim price As Decimal = 0
                Dim qty As Decimal = 0
                
                If Decimal.TryParse(priceText, price) AndAlso Decimal.TryParse(qtyText, qty) Then
                    total += price * qty
                End If
            Catch ex As Exception
                ' Skip this row if there's an error
                Continue For
            End Try
        Next
        lbltotal.Text = total.ToString("C")
    End Sub




    Private Sub AddSelectedItemsToPaymentSlip()
        Throw New NotImplementedException
    End Sub



    Private Sub AddOrUpdateItem(barcode As String)
        Dim itemFound As Boolean = False

        ' Loop through each row in DataGridView to check if item already exists
        For Each row As DataGridViewRow In dgvcart.Rows
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
            dgvcart.Rows.Add(barcode, productName, 1, price, totalPrice)
        End If

        ' Update the overall total to pay
        UpdateTotalToPay()
    End Sub

    Private Sub UpdateTotalToPay()
        Dim total As Decimal = 0
        For Each row As DataGridViewRow In dgvcart.Rows
            total += Convert.ToDecimal(row.Cells("Total Price").Value)
        Next
        lbltotal.Text = "₱" & total.ToString("N2")
    End Sub


    Private Sub CLEAR_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Try
            With txtxbarcode
                .Enabled = False
                .Clear()
                txtxbarcode.Enabled = True
                txtxbarcode.Focus()
                dgvcart.Enabled = True
                dgvcart.Rows.Clear()
                lbltotal.Text = "0.00"
                lblcash.Text = "0.00"
                lblchange.Text = "0.00"
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub OpenVoidForm()
        ' Check if there are items in the DataGridView
        If dgvcart.Rows.Count = 0 OrElse dgvcart.Rows.Cast(Of DataGridViewRow).All(Function(row) row.IsNewRow) Then
            MessageBox.Show("No items to display.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Collect rows into a DataTable to pass to frmVoid
        Dim displayedItems As New DataTable
        For Each column As DataGridViewColumn In dgvcart.Columns
            displayedItems.Columns.Add(column.Name, GetType(String)) ' Assumes all columns are strings
        Next

        For Each row As DataGridViewRow In dgvcart.Rows
            If Not row.IsNewRow Then
                Dim dataRow As DataRow = displayedItems.NewRow()
                For Each cell As DataGridViewCell In row.Cells
                    dataRow(cell.ColumnIndex) = If(cell.Value, "").ToString().Replace("₱", "").Replace(",", "").Trim()
                Next
                displayedItems.Rows.Add(dataRow)
            End If
        Next

        ' Pass the DataTable to the Void form
        Dim voidForm As New frmVoid(displayedItems)
        voidForm.ShowDialog()
    End Sub

    ''CODES FOR STOCKS DEDUCTION
    '' Deduct Stock Functionality
    Private sqlConn As New SqlConnection(Connstring)

    Private Sub DeductStock(productCode As String, soldQuantity As Integer)

        Try
            ' Open database connection if not already open
            If sqlConn.State = ConnectionState.Closed Then
                sqlConn.Open()
            End If

            ' Check current stock
            Dim queryCheckStock As String = "SELECT Stock FROM Product WHERE ProductCode = @ProductCode"
            Dim cmdCheckStock As New SqlCommand(queryCheckStock, sqlConn)
            cmdCheckStock.Parameters.AddWithValue("@ProductCode", productCode)
            Dim currentStock As Integer = Convert.ToInt32(cmdCheckStock.ExecuteScalar())

            ' Ensure enough stock is available
            If currentStock <= soldQuantity Then
                ' Deduct stock
                Dim queryUpdateStock As String = "UPDATE Product SET Stock = Stock - @Quantity WHERE ProductCode = @ProductCode"
                Dim cmdUpdateStock As New SqlCommand(queryUpdateStock, sqlConn)
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
            If sqlConn.State = ConnectionState.Open Then
                sqlConn.Close()
            End If
        End Try
    End Sub

    ' Call this function when the product is successfully sold
    Private Sub CompleteSale()
        Try
            For Each row As DataGridViewRow In dgvcart.Rows
                Dim productCode As String = row.Cells("ProductCode").Value.ToString()
                Dim soldQuantity As Integer = Convert.ToInt32(row.Cells("Stock").Value)

                ' Deduct stock for each sold product
                DeductStock(productCode, soldQuantity)
            Next
        Catch ex As Exception
            MessageBox.Show("Error processing sale: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub Button2_Click_3(sender As Object, e As EventArgs) Handles btnchangepassword.Click
    '    changepass.Show()
    '    changepass.txtusername.Enabled = False
    '    changepass.txtusername.Text = LblUser.Text
    'End Sub

    Private Sub restransac_Click_4(sender As Object, e As EventArgs) Handles btnrestran.Click
        SavePendingProducts()
    End Sub
    Private Sub SavePendingProducts()
        For Each row As DataGridViewRow In dgvcart.Rows
            If Not row.IsNewRow Then
                Try
                    ' Get transaction number from the label
                    Dim transactionNumber As String = lbltransnum.Text.Trim()

                    ' Validate transaction number
                    If String.IsNullOrEmpty(transactionNumber) Then
                        MessageBox.Show("Transaction number is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    ' Get product details from DataGridView
                    Dim productCode As String = row.Cells(0).Value.ToString().Trim()
                    Dim productName As String = row.Cells(1).Value.ToString().Trim()
                    Dim quantity As String = row.Cells(2).Value.ToString().Trim()
                    Dim priceText As String = row.Cells(3).Value.ToString().Replace("₱", "").Replace(",", "").Trim()
                    Dim subTotalText As String = row.Cells(4).Value.ToString().Replace("₱", "").Replace(",", "").Trim()

                    ' Validate data fields
                    If String.IsNullOrEmpty(productCode) OrElse
                       String.IsNullOrEmpty(productName) OrElse
                       String.IsNullOrEmpty(quantity) OrElse
                       String.IsNullOrEmpty(priceText) OrElse
                       String.IsNullOrEmpty(subTotalText) Then
                        MessageBox.Show("Missing data in row {row.Index + 1}. Please ensure all fields are filled.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Continue For
                    End If

                    ' Convert price and subtotal to decimals
                    Dim priceDecimal As Decimal = Decimal.Parse(priceText)
                    Dim subTotalDecimal As Decimal = Decimal.Parse(subTotalText)
                    Dim quantityInt As Integer = Integer.Parse(quantity)

                    ' Open the connection
                    If connection.State = ConnectionState.Closed Then
                        connection.Open()
                    End If

                    ' Check if product already exists in the Pending table
                    Dim checkCmd As New SqlCommand("SELECT COUNT(*) FROM Pendingsprod WHERE TransactionNumber = @TransactionNumber AND ProductCode = @ProductCode", connection)
                    checkCmd.Parameters.AddWithValue("@TransactionNumber", transactionNumber)
                    checkCmd.Parameters.AddWithValue("@ProductCode", productCode)

                    Dim productExists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                    If productExists > 0 Then
                        ' Update quantity and subtotal if product already exists
                        Dim updateCmd As New SqlCommand("UPDATE Pendingsprod SET Quantity = Quantity + @Quantity, SubTotal = SubTotal + @SubTotal WHERE TransactionNumber = @TransactionNumber AND ProductCode = @ProductCode", connection)
                        updateCmd.Parameters.AddWithValue("@Quantity", quantityInt)
                        updateCmd.Parameters.AddWithValue("@SubTotal", subTotalDecimal)
                        updateCmd.Parameters.AddWithValue("@TransactionNumber", transactionNumber)
                        updateCmd.Parameters.AddWithValue("@ProductCode", productCode)

                        updateCmd.ExecuteNonQuery()
                    Else
                        ' Insert new product into the Pending table
                        Dim insertCmd As New SqlCommand("INSERT INTO Pendingsprod (TransactionNumber, ProductCode, ProductName, Quantity, Price, SubTotal) VALUES (@TransactionNumber, @ProductCode, @ProductName, @Quantity, @Price, @SubTotal)", connection)
                        insertCmd.Parameters.AddWithValue("@TransactionNumber", transactionNumber)
                        insertCmd.Parameters.AddWithValue("@ProductCode", productCode)
                        insertCmd.Parameters.AddWithValue("@ProductName", productName)
                        insertCmd.Parameters.AddWithValue("@Quantity", quantityInt)
                        insertCmd.Parameters.AddWithValue("@Price", priceDecimal)
                        insertCmd.Parameters.AddWithValue("@SubTotal", subTotalDecimal)

                        insertCmd.ExecuteNonQuery()
                    End If
                Catch ex As SqlException
                    MessageBox.Show("SQL Error in row {row.Index + 1}: {ex.Message}", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Catch ex As FormatException
                    MessageBox.Show("Format Error in row {row.Index + 1}: {ex.Message}", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Catch ex As Exception
                    MessageBox.Show("Error in row {row.Index + 1}: {ex.Message}", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    ' Close the connection
                    If connection.State = ConnectionState.Open Then
                        connection.Close()
                    End If
                End Try
            End If
        Next

        ' Clear DataGridView after saving
        dgvcart.Rows.Clear()
        MessageBox.Show("Pending products saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub pendtrans_Click_1(sender As Object, e As EventArgs) Handles btnpendtrans.Click
        Pending.Show()

    End Sub
    Public Sub AddProductFromPending(productCode As String, productName As String, quantity As Integer, price As Decimal, subTotal As Decimal)
        Try
            ' Check if the product is already in the DataGridView
            Dim productExists As Boolean = False
            Using connection As New SqlConnection(Connstring)

                connection.Open()
                For Each row As DataGridViewRow In dgvcart.Rows
                    If row.Cells(0).Value.ToString() = productCode Then
                        ' Update quantity and subtotal if the product already exists
                        Dim existingQuantity As Integer = Convert.ToInt32(row.Cells(2).Value)
                        row.Cells(2).Value = existingQuantity + quantity
                        row.Cells(4).Value = (existingQuantity + quantity) * price
                        productExists = True
                        Exit For
                    End If

                Next
            End Using
            ' If the product is not already in the DataGridView, add a new row
            If Not productExists Then
                dgvcart.Rows.Add(productCode, productName, quantity, price, subTotal)
            End If

            ' Update the total price in the main form
            UpdateTotalPrice()
        Catch ex As Exception
            MessageBox.Show("Error adding product from pending: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub LoadPendingProducts(transactionNumber As String, products As List(Of Dictionary(Of String, Object)))
        ' Add products back to the main DataGridView
        For Each product In products
            dgvcart.Rows.Add(product("ProductCode"), product("ProductName"), product("Quantity"), product("Price"), product("SubTotal"))
        Next

        ' Optionally update the UI to show the transaction number
        lbltransnum.Text = transactionNumber
    End Sub

End Class