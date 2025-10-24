Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Public Class frmtransactionhistory

    ' Property to store the transaction ID
    Public Property TransactionID As String



    Private Sub dtgTranshistory_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim selectedTransactionID As Integer = CInt(dgvtransaction.Rows(e.RowIndex).Cells("TransactionID").Value)
        Dim query As String = "SELECT ProductCode, Stock, UnitPrice FROM viewTransactions WHERE TransactionID = @TransactionID"
        Dim da As New SqlDataAdapter(query, Connstring)
        da.SelectCommand.Parameters.AddWithValue("@TransactionID", selectedTransactionID)

        Dim dt As New DataTable
        da.Fill(dt)

        ' Bind the data to another DataGridView (e.g., dtgTransactionItems)
        dgvtransaction.DataSource = dt
        LoadTransactionDetails()
        LoadTransactionItems(selectedTransactionID)
    End Sub
    Private Sub LoadTransactionItems(transactionID As Integer)
        ' This is where the code to fetch the transaction items from the database goes
    End Sub
    Private Sub dtgTranshistory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
    Private Sub LoadTransactionHistory()
        Dim query As String = "SELECT TransactionID, TransactionNumber, Date, Time FROM viewTransactions ORDER BY TransactionDate DESC"
        Dim da As New SqlDataAdapter(query, Connstring)
        Dim dt As New DataTable
        da.Fill(dt)

        ' Bind the data to the DataGridView
        dgvtransaction.DataSource = dt
    End Sub

    Private Sub frmtransactionhistory_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            ' Save action
            btnback_Click(sender, e)
        End If
    End Sub

    Private Sub frmtransactionhistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.KeyPreview = True
        LoadTransactionNumbers()
        InitializeDataGridView()
        Loadtransactions()
        ComboBox1.Items.Add("Select a transaction number")
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtdate.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the key is not a number, suppress the key event (i.e., don't allow it)
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Txtdate.TextChanged
        Loadtransactions()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub dtgTranshistory_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)


    End Sub
    Private Sub Loadtransactions()
        Try
            ComboBox1.Items.Add("Select a transaction number")
            ' Open the database connection if it's not already open
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Query to get all distinct transaction numbers from the transactionSS table
            Dim cmd As New SqlCommand("SELECT DISTINCT TransactionNumber FROM viewTransactions", connection)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            ' Clear existing items in the ComboBox before adding new ones
            ComboBox1.Items.Clear()

            ' Loop through the results and add them to the ComboBox
            While reader.Read()
                ComboBox1.Items.Add(reader("TransactionNumber").ToString())
            End While

            ' Close the reader after usage
            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error loading transaction numbers: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the connection if it's open
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Close()
    End Sub
    Private Sub CalculateAndDisplayTotal()
        Try
            Dim total As Decimal = 0

            ' Loop through each row in the DataGridView
            For Each row As DataGridViewRow In dgvtransaction.Rows
                If Not row.IsNewRow Then
                    ' Get the values of Quantity and Price columns
                    Dim quantity As Decimal = 0
                    Dim price As Decimal = 0

                    If row.Cells(3).Value IsNot Nothing AndAlso IsNumeric(row.Cells(3).Value) Then
                        quantity = Convert.ToDecimal(row.Cells(3).Value)
                    End If

                    If row.Cells(4).Value IsNot Nothing AndAlso IsNumeric(row.Cells(4).Value) Then
                        price = Convert.ToDecimal(row.Cells(4).Value)
                    End If

                    ' Multiply Quantity * Price and add to total
                    total += quantity * price
                End If
            Next

            ' Display the total in the label
            lbltotal.Text = "₱" & total.ToString("N2") ' Format as peso (e.g., ₱123.45)
        Catch ex As Exception
            MessageBox.Show("Error calculating total: " & ex.Message)
        End Try
    End Sub



    Dim connection As New SqlConnection(Connstring)
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' Make sure that the placeholder text is not processed as a transaction number
        If ComboBox1.SelectedIndex > 0 Then
            ' Load the transaction details when a valid transaction number is selected
            LoadTransactionDetails()

            ' Optionally, you can also fetch the date of the transaction and update txtDate
            Dim selectedTransactionNumber As String = ComboBox1.SelectedItem.ToString()

            Try

                ' Fetch the transaction date
                Dim cmd As New SqlCommand("SELECT Date FROM viewTransactions WHERE TransactionNumber = @TransactionNumber", connection)
                cmd.Parameters.AddWithValue("@TransactionNumber", selectedTransactionNumber)

                If connection.State = ConnectionState.Closed Then
                    connection.Open()
                End If
                ' Execute the query to fetch the date
                Dim transactionDate As Object = cmd.ExecuteScalar()

                ' Display the date in txtDate
                If transactionDate IsNot DBNull.Value Then
                    Txtdate.Text = Convert.ToDateTime(transactionDate).ToString("yyyy-MM-dd")
                Else
                    Txtdate.Text = "No date available"
                End If

            Catch ex As Exception
                MessageBox.Show("Error loading transaction date: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Ensure connection is closed
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End If
    End Sub
    Private Sub LoadTransactionNumbers()
        ' Clear the ComboBox before loading new items
        ComboBox1.Items.Clear()

        ' Add default option "Select a transaction number" at the start
        ComboBox1.Items.Add("Select a transaction number")

        ' Query to fetch TransactionNumber from the database
        Dim query As String = "SELECT TransactionNumber FROM viewTransactions ORDER BY Date DESC"

        ' Connect to the database and fetch the TransactionNumbers
        Using conn As New SqlConnection(Connstring)
            Dim cmd As New SqlCommand(query, conn)
            conn.Open()

            ' Load the transaction numbers into the ComboBox
            Using reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    ComboBox1.Items.Add(reader("TransactionNumber").ToString())
                End While
            End Using
        End Using

        ' Make the ComboBox non-editable (dropdown only)
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList

        ' If there are items in the ComboBox, select the default "Select a transaction number"
        If ComboBox1.Items.Count > 0 Then
            ComboBox1.SelectedIndex = 0 ' This ensures the first item (default) is selected
        End If
    End Sub

    Private Sub InitializeDataGridView()
        ' Clear any existing columns (only if needed)
        If dgvtransaction.Columns.Count > 0 Then
            dgvtransaction.Columns.Clear()
        End If

        ' Set the AutoSizeColumnsMode to make the columns fit the entire DataGridView
        dgvtransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvtransaction.DefaultCellStyle.Font = New Font("Microsoft JhengHei UI", 12, FontStyle.Regular)
        dgvtransaction.RowTemplate.Height = 40
        dgvtransaction.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft JhengHei UI", 12, FontStyle.Bold)

        ' Add the necessary columns
        dgvtransaction.Columns.Add("ProductCode", "Product Code")
        dgvtransaction.Columns.Add("Name", "Product Name")
        dgvtransaction.Columns.Add("CustomerName", "Customer Name") ' New column for Customer Name

        ' Adding the Quantity column as an Integer type
        Dim qtyColumn As New DataGridViewTextBoxColumn
        qtyColumn.Name = "Quantity"
        qtyColumn.HeaderText = "Quantity"
        qtyColumn.ValueType = GetType(Integer) ' Ensures it accepts only integer values
        dgvtransaction.Columns.Add(qtyColumn)

        ' Adding the Price column as Decimal type, with appropriate formatting for currency
        Dim priceColumn As New DataGridViewTextBoxColumn
        priceColumn.Name = "Price"
        priceColumn.HeaderText = "Price"
        priceColumn.ValueType = GetType(Decimal)
        priceColumn.DefaultCellStyle.Format = "C2" ' Currency format
        dgvtransaction.Columns.Add(priceColumn)

        ' Adding the TotalPrice column as Decimal type
        Dim totalPriceColumn As New DataGridViewTextBoxColumn
        totalPriceColumn.Name = "TotalPrice"
        totalPriceColumn.HeaderText = "Total Price"
        totalPriceColumn.ValueType = GetType(Decimal)
        totalPriceColumn.DefaultCellStyle.Format = "C2" ' Currency format
        dgvtransaction.Columns.Add(totalPriceColumn)

        ' Optionally, set specific columns to auto-size based on content
        dgvtransaction.Columns("ProductCode").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvtransaction.Columns("Name").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill ' Fills remaining space
        dgvtransaction.Columns("CustomerName").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvtransaction.Columns("Quantity").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvtransaction.Columns("Price").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvtransaction.Columns("TotalPrice").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub

    Private Sub LoadTransactionDetails()
        Try
            ' Ensure a transaction number is selected
            If ComboBox1.SelectedItem Is Nothing Then
                MessageBox.Show("Please select a transaction number first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Open database connection
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Get the selected transaction number
            Dim transactionNumber As String = ComboBox1.SelectedItem.ToString()

            ' SQL query to fetch product and customer details for the selected transaction
            Dim cmd As New SqlCommand("SELECT ProductCode, ProductName, CustomerName, Quantity, Price, (Price * Quantity) AS TotalAmount FROM viewTransactions WHERE TransactionNumber = @TransactionNumber", connection)
            cmd.Parameters.AddWithValue("@TransactionNumber", transactionNumber)

            ' Execute the query
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            ' Clear previous data in the DataGridView
            dgvtransaction.Rows.Clear()

            ' Load the data into the DataGridView
            While reader.Read()
                dgvtransaction.Rows.Add(reader("ProductCode").ToString(), reader("ProductName").ToString(), reader("CustomerName").ToString(), reader("Quantity").ToString(), reader("Price").ToString(), reader("TotalAmount").ToString())
            End While

            CalculateAndDisplayTotal()
            ' Close the reader
            reader.Close()
        Catch ex As Exception
            ' Handle errors
            MessageBox.Show("Error loading transaction details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure connection is closed
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub






    Private Sub dgvtransaction_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvtransaction.CellContentClick

    End Sub
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    'Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
    '    If ComboBox1.SelectedItem IsNot Nothing Then
    '        ' Get the selected transaction number from the ComboBox
    '        Dim selectedTransactionNumber As String = ComboBox1.SelectedItem.ToString()

    '        ' Load the details for the selected transaction
    '        LoadTransactionDetails(selectedTransactionNumber)

    '        ' Print the transaction details
    '        PD.Print()
    '    Else
    '        MessageBox.Show("Please select a transaction to print.")
    '    End If
    'End Sub
    'Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
    '    Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
    '    Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
    '    Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
    '    Dim f14 As New Font("Calibri", 14, FontStyle.Bold)

    '    Dim leftMargin As Integer = PD.DefaultPageSettings.Margins.Left
    '    Dim centerMargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2

    '    Dim line As String = "--------------------------------------------------"
    '    e.Graphics.DrawString("Transaction Details", f14, Brushes.Black, centerMargin, 5, New StringFormat() With {.Alignment = StringAlignment.Center})

    '    e.Graphics.DrawString(line, f8, Brushes.Black, 0, 20)

    '    e.Graphics.DrawString("Transaction Number: " & Pointofsalesystem.lbltransnum.Text, f10, Brushes.Black, 0, 35)

    '    e.Graphics.DrawString("Cashier: " & Pointofsalesystem.LblUser.Text, f10, Brushes.Black, 0, 50)
    '    ' e.Graphics.DrawString("Customer: " & lblCustomer.Text, f10, Brushes.Black, 0, 65)
    '    e.Graphics.DrawString("Date: " & Pointofsalesystem.lbldate.Text, f10, Brushes.Black, 0, 80)

    '    e.Graphics.DrawString(line, f8, Brushes.Black, 0, 95)

    '    ' Print the details of the transaction from dgTransactionDetails (DataGridView)
    '    Dim height As Integer = 0
    '    For row As Integer = 0 To dgvtransaction.Rows.Count - 1
    '        height += 20

    '        ' Check if the cell value is not Nothing before accessing it
    '        If dgvtransaction.Rows(row).Cells(1).Value IsNot Nothing Then
    '            e.Graphics.DrawString(dgvtransaction.Rows(row).Cells(1).Value.ToString(), f8, Brushes.Black, 10, 115 + height)
    '        End If

    '        If dgvtransaction.Rows(row).Cells(2).Value IsNot Nothing Then
    '            e.Graphics.DrawString(dgvtransaction.Rows(row).Cells(2).Value.ToString(), f8, Brushes.Black, 150, 115 + height)
    '        End If

    '        If dgvtransaction.Rows(row).Cells(3).Value IsNot Nothing Then
    '            e.Graphics.DrawString(dgvtransaction.Rows(row).Cells(3).Value.ToString(), f8, Brushes.Black, 210, 115 + height)
    '        End If

    '        If dgvtransaction.Rows(row).Cells(4).Value IsNot Nothing Then
    '            e.Graphics.DrawString(dgvtransaction.Rows(row).Cells(4).Value.ToString(), f8, Brushes.Black, 270, 115 + height)
    '        End If
    '    Next


    '    e.Graphics.DrawString(line, f8, Brushes.Black, 0, 115 + height + 20)

    '    '' Print total amount, cash, and change
    '    'e.Graphics.DrawString("Total: " & txtTotal.Text, f10b, Brushes.Black, 200, 140 + height)
    '    'e.Graphics.DrawString("Cash: " & txtCash.Text, f10b, Brushes.Black, 200, 160 + height)
    '    'e.Graphics.DrawString("Change: " & txtChange.Text, f10b, Brushes.Black, 200, 180 + height)

    '    e.Graphics.DrawString("Thanks for shopping!", f10, Brushes.Black, centerMargin, 200 + height, New StringFormat() With {.Alignment = StringAlignment.Center})
    'End Sub
    Private Sub LoadTransactionDetails(transactionNumber As String)
        ' Your query to get details for the selected transaction
        Dim query As String = "SELECT Name, Quantity, Price, (Price * Quantity) AS TotalPrice FROM viewTransactions WHERE TransactionNumber = @TransactionNumber"

        Using conn As New SqlConnection(Connstring)
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@TransactionNumber", transactionNumber)
            conn.Open()

            ' Assuming you're using a DataTable or a similar method to bind the details to your DataGridView
            Dim dt As New DataTable()
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dt)

            ' Bind the data to your DataGridView
            dgvtransaction.DataSource = dt
        End Using
    End Sub


    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub dgvtransaction_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles dgvtransaction.RowPrePaint

    End Sub

    Private Sub dgvtransaction_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvtransaction.RowsAdded
        CalculateAndDisplayTotal()
    End Sub

    Private Sub dgvtransaction_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvtransaction.RowsRemoved
        CalculateAndDisplayTotal()
    End Sub
End Class