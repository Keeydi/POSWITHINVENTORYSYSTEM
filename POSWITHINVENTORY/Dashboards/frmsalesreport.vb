Imports System.Data.SqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class frmSalesReport
    Private sqlConn As New SqlConnection(Connstring)
    Private Sub formatgridout()
        dgvSalesReport.CellBorderStyle = DataGridViewCellBorderStyle.None
        dgvSalesReport.RowHeadersVisible = True
        dgvSalesReport.ColumnHeadersVisible = True
        dgvSalesReport.AutoGenerateColumns = True



        ' Center the data
        dgvSalesReport.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        For Each column As DataGridViewColumn In dgvSalesReport.Columns
            column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

        dgvSalesReport.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvsalesreport.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 18, FontStyle.Bold)
        dgvsalesreport.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 16)
        dgvsalesreport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSalesReport.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        ' Set custom column headers and adjust visibility as needed
        dgvSalesReport.Columns("TransactionNumber").HeaderText = "TRANSACTION NO."
        dgvSalesReport.Columns("ProductCode").HeaderText = "PRODUCT CODE"
        dgvsalesreport.Columns("ProductName").HeaderText = "PRODUCT NAME"
        dgvsalesreport.Columns("Quantity").HeaderText = "QUANTITY"
        dgvSalesReport.Columns("Price").HeaderText = "PRICE"
        dgvSalesReport.Columns("TotalAmount").HeaderText = "TOTAL AMOUNT"
        dgvSalesReport.Columns("Date").HeaderText = "TRANSACTION DATE AND TIME"

        ' Optional: Hide certain columns if needed (example)
        ' dgvSalesReport.Columns("SomeColumn").Visible = False
    End Sub

    Private Sub frmSalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set max date to today for both DateTimePickers
        dtpfrom.MaxDate = Date.Today
        dtpto.MaxDate = Date.Today

        ' Default both pickers to today's date
        dtpfrom.Value = Date.Today
        dtpto.Value = Date.Today

        ' Add event handlers for the DateTimePickers to automatically refresh data
        AddHandler dtpfrom.ValueChanged, AddressOf DateChanged
        AddHandler dtpto.ValueChanged, AddressOf DateChanged

        ' Initial load
        BindAndFormatDataGrid()


        With dgvSalesReport ' palitan mo ng pangalan ng datagridview
            ' General Appearance
            .EnableHeadersVisualStyles = False
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            .BackgroundColor = Color.White
            .BorderStyle = BorderStyle.None

            ' Column Headers Style
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 140, 186) ' Header color
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White ' Header text color
            .ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 10, FontStyle.Bold)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            ' Row Style
            .DefaultCellStyle.BackColor = Color.White ' Row background
            .DefaultCellStyle.ForeColor = Color.Black ' Row text color
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 112, 149) ' Selected row background
            .DefaultCellStyle.SelectionForeColor = Color.White ' Selected row text color
            .DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 12, FontStyle.Regular)

            ' Alternating Row Style
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255) ' Light blue

            ' Grid Lines
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            .GridColor = Color.LightGray

            ' Additional Properties
            .AllowUserToAddRows = False
            .AllowUserToResizeRows = False
            .ReadOnly = True
        End With




        dgvSalesReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvsalesreport.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 16, FontStyle.Bold)
        dgvsalesreport.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 14)
        dgvsalesreport.DefaultCellStyle.ForeColor = Color.Black
        dgvSalesReport.DefaultCellStyle.BackColor = Color.LightGray
        dgvSalesReport.EnableHeadersVisualStyles = False
        dgvSalesReport.ColumnHeadersDefaultCellStyle.BackColor = Color.MidnightBlue
        dgvSalesReport.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
    End Sub



    Private Sub gunabtnclose_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub
    Private Sub BindAndFormatDataGrid()
        ' Load sales report
        Dim startDate As Date = dtpfrom.Value.Date
        Dim endDate As Date = dtpto.Value.Date

        If endDate < startDate Then
            MessageBox.Show("The 'To' date must be on or after the 'From' date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Bind the data
        Dim query As String = "SELECT TransactionNumber, ProductCode, ProductName, Quantity, Price, (Price * Quantity) AS TotalAmount, " &
                          "CONVERT(VARCHAR(10), Date, 110) + ' ' + CONVERT(VARCHAR(8), Time, 108) AS Date " &
                          "FROM viewTransactions " &
                          "WHERE CAST(Date AS DATE) BETWEEN @startDate AND @endDate"
        Using connection As New SqlConnection(Connstring)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@startDate", dtpfrom.Value.Date)
                command.Parameters.AddWithValue("@endDate", dtpto.Value.Date)

                Dim dt As New DataTable()
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()
                dt.Load(reader)
                dgvSalesReport.DataSource = dt
            End Using
        End Using
        CalculateTotalSales()


        ' Format the grid
        formatgridout()


    End Sub
    Private Sub CalculateTotalSales()
        ' Initialize total sales variable
        Dim totalSales As Decimal = 0D

        ' SQL query to calculate total sales
        Dim query As String = "SELECT SUM(Price * Quantity) AS TotalSales " &
                              "FROM viewTransactions " &
                              "WHERE CAST(Date AS DATE) BETWEEN @startDate AND @endDate"

        ' Set up SQL connection and command
        Using connection As New SqlConnection(Connstring)
            Using command As New SqlCommand(query, connection)
                ' Add parameters for the date range
                command.Parameters.Add("@startDate", SqlDbType.Date).Value = dtpfrom.Value.Date
                command.Parameters.Add("@endDate", SqlDbType.Date).Value = dtpto.Value.Date

                ' Open the connection
                connection.Open()

                ' Execute the query and retrieve the total sales
                Dim result = command.ExecuteScalar()
                If result IsNot DBNull.Value Then
                    totalSales = Convert.ToDecimal(result)
                End If
            End Using
        End Using

        ' Display the total sales in a TextBox or Label
        txttotalsales.Text = totalSales.ToString("F2") ' Format as number with 2 decimal places
    End Sub

    Private Sub DateChanged(sender As Object, e As EventArgs)
        BindAndFormatDataGrid()
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Close()

    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        Try
            ' Ensure the SQL connection is open
            If sqlConn.State = ConnectionState.Closed Then
                sqlConn.Open()
            End If

            Dim dateFrom As Date = dtpfrom.Value.Date
            Dim dateTo As Date = dtpto.Value.Date

            Dim query As String = "SELECT TransactionNumber, ProductCode, ProductName, Quantity, Price, " &
                      "(Price * Quantity) AS TotalAmount, " &
                      "CONVERT(VARCHAR(10), Date, 110) + ' ' + CONVERT(VARCHAR(8), Time, 108) AS TransactionDateTime " &
                      "FROM viewTransactions " &
                      "WHERE CAST(Date AS DATE) BETWEEN @DateFrom AND @DateTo " &
                      "ORDER BY TransactionNumber, ProductCode"

            Dim sqlCmd As New SqlCommand(query, sqlConn)
            sqlCmd.Parameters.AddWithValue("@DateFrom", dateFrom)
            sqlCmd.Parameters.AddWithValue("@DateTo", dateTo)
            Dim adapter As New SqlDataAdapter(sqlCmd)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            If dataTable.Rows.Count = 0 Then
                MessageBox.Show("No records found for the selected date range.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            ' ---------------- PDF CREATION ----------------
            Dim savePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "SalesReport.pdf")
            Dim doc As New Document(PageSize.A4, 40, 40, 40, 20)
            PdfWriter.GetInstance(doc, New FileStream(savePath, FileMode.Create))
            doc.Open()

            ' Title
            Dim titleFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, Font.Bold)
            Dim paragraph As New Paragraph("SALES REPORT SAMPLES", titleFont)
            paragraph.Alignment = Element.ALIGN_CENTER
            doc.Add(paragraph)

            doc.Add(New Paragraph("Date Range: " & dateFrom.ToString("MMMM dd, yyyy") & " - " & dateTo.ToString("MMMM dd, yyyy")))
            doc.Add(New Paragraph("Generated On: " & DateTime.Now.ToString("MMMM dd, yyyy hh:mm tt")))
            doc.Add(New Paragraph(" "))

            ' Create ONE single table for all transactions
            Dim mainTable As New PdfPTable(7)
            mainTable.WidthPercentage = 100
            mainTable.SetWidths(New Single() {2.0F, 1.5F, 2.5F, 1.0F, 1.0F, 1.5F, 2.0F})

            ' Add headers to the single table
            Dim headerFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, Font.Bold)
            Dim headers() As String = {"TRANSACTION NO.", "PRODUCT CODE", "PRODUCT NAME", "QUANTITY", "PRICE", "TOTAL AMOUNT", "TRANSACTION DATE AND TIME"}
            
            For Each header As String In headers
                Dim cell As New PdfPCell(New Phrase(header, headerFont))
                cell.HorizontalAlignment = Element.ALIGN_CENTER
                cell.BackgroundColor = BaseColor.LIGHT_GRAY
                cell.Padding = 5
                mainTable.AddCell(cell)
            Next

            ' Group data by transaction and add to single table
            Dim transactionGroups = dataTable.AsEnumerable().GroupBy(Function(row) row("TransactionNumber").ToString())
            Dim totalSales As Decimal = 0

            For Each transactionGroup In transactionGroups
                Dim transactionNumber As String = transactionGroup.Key
                Dim transactionRows = transactionGroup.ToList()
                Dim transactionDateTime As String = transactionRows.First()("TransactionDateTime").ToString()

                ' Add transaction rows to the single table
                For i As Integer = 0 To transactionRows.Count - 1
                    Dim row As DataRow = transactionRows(i)
                    Dim productCode As String = row("ProductCode").ToString()
                    Dim productName As String = row("ProductName").ToString()
                    Dim quantity As String = row("Quantity").ToString()
                    Dim price As String = Convert.ToDecimal(row("Price")).ToString("F2")
                    Dim totalAmount As String = Convert.ToDecimal(row("TotalAmount")).ToString("F2")

                    ' Add cells for this row
                    If i = 0 Then
                        ' First row shows transaction info
                        mainTable.AddCell(New Phrase(transactionNumber))
                        mainTable.AddCell(New Phrase(productCode))
                        mainTable.AddCell(New Phrase(productName))
                        mainTable.AddCell(New Phrase(quantity))
                        mainTable.AddCell(New Phrase(price))
                        mainTable.AddCell(New Phrase(totalAmount))
                        mainTable.AddCell(New Phrase(transactionDateTime))
                    Else
                        ' Subsequent rows show empty transaction info
                        mainTable.AddCell(New Phrase(""))
                        mainTable.AddCell(New Phrase(productCode))
                        mainTable.AddCell(New Phrase(productName))
                        mainTable.AddCell(New Phrase(quantity))
                        mainTable.AddCell(New Phrase(price))
                        mainTable.AddCell(New Phrase(totalAmount))
                        mainTable.AddCell(New Phrase(""))
                    End If

                    totalSales += Convert.ToDecimal(row("TotalAmount"))
                Next
            Next

            ' Add the single table to document
            doc.Add(mainTable)

            ' Add total sales
            doc.Add(New Paragraph(" "))
            Dim totalFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, Font.Bold)
            doc.Add(New Paragraph("TOTAL SALES: " & totalSales.ToString("F2"), totalFont))

            doc.Close()

            MessageBox.Show("Sales Report PDF has been generated successfully!" & vbCrLf & "Saved to: " & savePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error generating PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If sqlConn.State = ConnectionState.Open Then
                sqlConn.Close()
            End If
        End Try
    End Sub



    Private Sub InitializeDataGridView()
        ' Clear any existing columns (only if needed)
        ' Clear existing columns if any
        If dgvSalesReport.Columns.Count > 0 Then
            dgvSalesReport.Columns.Clear()
        End If

        ' Set the AutoSizeColumnsMode to make the columns fit the entire DataGridView
        dgvSalesReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvsalesreport.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft JhengHei UI", 16, FontStyle.Regular)
        dgvsalesreport.RowTemplate.Height = 40
        dgvsalesreport.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft JhengHei UI", 18, FontStyle.Bold)
        ' Add the necessary columns
        dgvsalesreport.Columns.Add("TransactionNumber", "Transaction #")
        dgvSalesReport.Columns.Add("ProductCode", "Product Code")
        dgvSalesReport.Columns.Add("Name", "Product Name")
        dgvSalesReport.Columns.Add("TransactionDate", "Transaction Date")
        dgvsalesreport.Font = New System.Drawing.Font("Microsoft JhengHei UI", 30, FontStyle.Regular)

        ' Adding the Quantity column as an Integer type
        Dim qtyColumn As New DataGridViewTextBoxColumn
        qtyColumn.Name = "Quantity"
        qtyColumn.HeaderText = "Quantity"
        qtyColumn.ValueType = GetType(Integer) ' Ensures it accepts only integer values
        dgvSalesReport.Columns.Add(qtyColumn)


        ' Adding the Price column as Decimal type, with appropriate formatting for currency

        ' Adding the TotalPrice column as Decimal type
        Dim totalPriceColumn As New DataGridViewTextBoxColumn
        totalPriceColumn.Name = "TotalPrice"
        totalPriceColumn.HeaderText = "Total Price"
        totalPriceColumn.ValueType = GetType(Decimal)
        totalPriceColumn.DefaultCellStyle.Format = "F2" ' Number format with 2 decimal places
        dgvSalesReport.Columns.Add(totalPriceColumn)

        ' Adding the "Add to Payment" button column


        ' Optionally, set specific columns to auto-size based on content
        dgvSalesReport.Columns("TransactionNumber").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvSalesReport.Columns("ProductCode").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvSalesReport.Columns("Name").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill ' Fills remaining space
        dgvSalesReport.Columns("Quantity").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvSalesReport.Columns("TotalPrice").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvSalesReport.Columns("TransactionDate").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

    End Sub
    Private Function GetRangeType(dateFrom As Date, dateTo As Date) As String
        Dim daysDifference As Integer = (dateTo - dateFrom).Days + 1 ' Include the starting date

        Select Case daysDifference
            Case 1 To 5
                Return "Daily Report"
            Case 7 To 15
                Return "Weekly Report"
            Case 31 To 365
                Return "Monthly Report"
            Case Is >= 365
                Return "Yearly Report"
            Case Else
                Return "Custom Range"
        End Select
    End Function


End Class