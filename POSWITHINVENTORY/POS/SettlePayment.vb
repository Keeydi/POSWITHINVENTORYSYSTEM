Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Text
Imports Newtonsoft.Json
Imports System.Drawing

Public Class SettlePayment
    Dim result As Boolean
    Dim ChangeAmount As Decimal

    Private transactionNumber As String
    Private receiptData As DataRow
    Private itemsList As List(Of Object)

    Public Property Subtotal As Decimal
        Get
            Return txtamount.Text
        End Get
        Set(value As Decimal)
            txtamount.Text = "₱" & value.ToString("N2")
        End Set
    End Property

    Public Property CashGiven As Decimal
        Get
            Return Convert.ToDecimal(txtcash.Text)
        End Get
        Set(value As Decimal)
            txtcash.Text = "₱" & value.ToString("N2")
        End Set
    End Property

    Public Property Change As Decimal
        Get
            Return txtchange.Text
        End Get
        Set(value As Decimal)
            txtchange.Text = "₱" & value.ToString("N2")
        End Set
    End Property

    Public Property Amount As String
        Get
            Return txtamount.Text
        End Get
        Set(value As String)
            txtamount.Text = value
        End Set
    End Property

    Public Property TotalAmount As Decimal

    Private Function CalculateChange(totalAmount As Decimal, cashGiven As Decimal) As Decimal
        Return cashGiven - totalAmount
    End Function

    Private Sub btnempback_Click(sender As Object, e As EventArgs) Handles btnempback.Click
        Me.Close()
        Pointofsalesystem.lblcash.Text = "0.00"
        Pointofsalesystem.lblchange.Text = "0.00"
    End Sub

    Private Function CalculateTotalAmount() As Decimal
        Dim totalAmount As Decimal = 0
        For Each row As DataGridViewRow In Pointofsalesystem.dgvcart.Rows
            Dim rowTotal As Decimal = Convert.ToDecimal(row.Cells(4).Value.ToString().Replace("₱", "").Replace(",", "").Trim())
            totalAmount += rowTotal
        Next
        Return totalAmount
    End Function

    Public Sub SetTotalAmount(amount As Decimal)
        txtamount.Text = "₱" & amount.ToString("N2")
    End Sub

    Private Sub SettlePayment_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnempsave_Click(sender, e)
        End If
        If e.KeyCode = Keys.Escape Then
            btnempback_Click(sender, e)
        End If
    End Sub

    Private Sub SettlePayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        txtamount.Text = "₱" & CalculateTotalAmount().ToString("N2")
        LoadCurrentEmployeeName()
    End Sub

    Private Sub txtcash_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcash.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtdesc_TextChanged(sender As Object, e As EventArgs) Handles txtcash.TextChanged
        Dim cashGiven As Decimal
        Dim change As Decimal
        Dim totalAmount As Decimal = CalculateTotalAmount()
        txtcash.MaxLength = 7

        If Decimal.TryParse(txtcash.Text.Replace("₱", "").Replace(",", "").Trim(), cashGiven) Then
            change = cashGiven - totalAmount
            If change < totalAmount Then ' Changed txtamount.Text to totalAmount
                txtcash.Focus()
                Pointofsalesystem.lblcash.Text = cashGiven
                Pointofsalesystem.lblchange.Text = change
                txtchange.Text = change
            Else
                Pointofsalesystem.lblcash.Text = txtcash.Text.ToString()
                Pointofsalesystem.lblchange.Text = change
                txtchange.Text = change
            End If
        End If
    End Sub

    Private Sub btnempsave_Click(sender As Object, e As EventArgs) Handles btnempsave.Click
        Try
            If String.IsNullOrWhiteSpace(txtcostumer.Text) Then
                MessageBox.Show("Employee name is required.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtcostumer.Focus()
                Return
            End If

            Dim cashGiven As Decimal
            Dim totalAmount As Decimal = Convert.ToDecimal(txtamount.Text.Replace("₱", "").Replace(",", "").Trim())

            If Not Decimal.TryParse(txtcash.Text.Replace("₱", "").Replace(",", "").Trim(), cashGiven) Then
                MessageBox.Show("Invalid cash amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If cashGiven < totalAmount Then
                MessageBox.Show("Insufficient funds.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            Else
                txtchange.Text = (cashGiven - totalAmount).ToString("0.00")
            End If
            Dim customerID As Integer
            Using con As New SqlConnection(Connstring)
                con.Open()
                Using sqlTransaction As SqlTransaction = con.BeginTransaction()
                    Try
                        ' Get or insert customer
                        Dim checkCmd As New SqlCommand("SELECT CustomerID FROM Customers WHERE CustomerName = @CustomerName", con, sqlTransaction)
                        checkCmd.Parameters.AddWithValue("@CustomerName", txtcostumer.Text.Trim())
                        Dim result = checkCmd.ExecuteScalar()

                        If result IsNot Nothing Then
                            customerID = Convert.ToInt32(result)
                        Else
                            Dim insertCustomer As New SqlCommand("INSERT INTO Customers (CustomerName) VALUES (@CustomerName)", con, sqlTransaction)
                            insertCustomer.Parameters.AddWithValue("@CustomerName", txtcostumer.Text.Trim())
                            insertCustomer.ExecuteNonQuery()

                            Dim getCustomer As New SqlCommand("SELECT CustomerID FROM Customers WHERE CustomerName = @CustomerName", con, sqlTransaction)
                            getCustomer.Parameters.AddWithValue("@CustomerName", txtcostumer.Text.Trim())
                            customerID = Convert.ToInt32(getCustomer.ExecuteScalar())
                        End If

                        ' Insert into PosHead
                        Dim transactionNumber = DateTime.Now.ToString("yyyyMMdd-HHmmss-") & Guid.NewGuid().ToString("N").Substring(0, 4)
                        Dim insertHead As New SqlCommand("INSERT INTO PosHead (TransactionNumber, Date, Time, CustomerID) OUTPUT INSERTED.TransactionID VALUES (@TransactionNumber, @Date, @Time, @CustomerID)", con, sqlTransaction)
                        insertHead.Parameters.AddWithValue("@TransactionNumber", transactionNumber)
                        insertHead.Parameters.AddWithValue("@Date", DateTime.Now.Date)
                        insertHead.Parameters.AddWithValue("@Time", DateTime.Now.TimeOfDay)
                        insertHead.Parameters.AddWithValue("@CustomerID", customerID)
                        Dim transactionID As Integer = Convert.ToInt32(insertHead.ExecuteScalar())

                        ' Insert PosDetails and update stock
                        For Each row As DataGridViewRow In Pointofsalesystem.dgvcart.Rows
                            If Not row.IsNewRow Then
                                Dim productID = row.Cells("ProductID").Value.ToString()
                                Dim productCode = row.Cells("ProductCode").Value.ToString()
                                Dim price = Convert.ToDecimal(row.Cells("UnitPrice").Value.ToString().Replace("₱", "").Replace(",", ""))
                                Dim quantity = Convert.ToInt32(row.Cells("Stock").Value)

                                Dim insertDetail As New SqlCommand("INSERT INTO PosDetails (TransactionID, ProductID, Quantity, Price) VALUES (@TransactionID, @ProductID, @Quantity, @Price)", con, sqlTransaction)
                                insertDetail.Parameters.AddWithValue("@TransactionID", transactionID)
                                insertDetail.Parameters.AddWithValue("@ProductID", productID)
                                insertDetail.Parameters.AddWithValue("@Quantity", quantity)
                                insertDetail.Parameters.AddWithValue("@Price", price)
                                insertDetail.ExecuteNonQuery()

                                Dim updateStock As New SqlCommand("UPDATE Product SET Stock = Stock - @Quantity WHERE ProductCode = @ProductCode", con, sqlTransaction)
                                updateStock.Parameters.AddWithValue("@ProductCode", productCode)
                                updateStock.Parameters.AddWithValue("@Quantity", quantity)
                                updateStock.ExecuteNonQuery()
                            End If
                        Next

                        sqlTransaction.Commit()


                        MessageBox.Show("Transaction saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Catch ex As Exception
                        sqlTransaction.Rollback()
                        MessageBox.Show("Error saving transaction: " & ex.Message)
                    End Try
                End Using
            End Using

            SaveReceiptToNewTable(totalAmount, cashGiven, (cashGiven - totalAmount))

            PreviewReceipt()

            Pointofsalesystem.lbltransnum.Text = Me.transactionNumber
            Pointofsalesystem.dgvcart.Rows.Clear()
            Pointofsalesystem.txtxbarcode.Clear()
            Pointofsalesystem.lbltotal.Text = "0.00"
            Pointofsalesystem.lblcash.Text = "0.00"
            Pointofsalesystem.lblchange.Text = "0.00"
            txtcostumer.Text = "" ' Don't clear employee name, it will be reloaded
            LoadCurrentEmployeeName() ' Reload employee name
            'LogActivity(logUsername, "Processed transaction: " & Me.transactionNumber, "Transaction Completed")
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub SaveReceiptToNewTable(totalAmount As Decimal, cashGiven As Decimal, changeAmount As Decimal)
        Try
            Me.transactionNumber = DateTime.Now.ToString("yyyyMMdd-HHmmss-") & Guid.NewGuid().ToString("N").Substring(0, 4)
            Dim itemsData As New StringBuilder()
            itemsData.Append("[")
            For Each row As DataGridViewRow In Pointofsalesystem.dgvcart.Rows
                If Not row.IsNewRow Then
                    Dim productName As String = row.Cells(1).Value.ToString()
                    Dim quantity As Integer = Convert.ToInt32(row.Cells(2).Value)
                    Dim price As Decimal = Convert.ToDecimal(row.Cells(3).Value.ToString().Replace("₱", "").Replace(",", ""))
                    Dim totalPrice As Decimal = Convert.ToDecimal(row.Cells(4).Value.ToString().Replace("₱", "").Replace(",", ""))

                    itemsData.AppendFormat("{{""Product"":""{0}"", ""Qty"":{1}, ""Price"":{2}, ""Total"":{3}}},", productName, quantity, price, totalPrice)
                End If
            Next
            If itemsData.Length > 1 Then
                itemsData.Remove(itemsData.Length - 1, 1)
            End If
            itemsData.Append("]")
            Dim sql As String = "INSERT INTO Receipts (TransactionNumber, TransactionDate, TransactionTime, CustomerID, TotalAmount, CashGiven, ChangeAmount, ItemsData) VALUES (@TransactionNumber, @Date, @Time, @CustomerID, @TotalAmount, @CashGiven, @ChangeAmount, @ItemsData)"

            Using con As New SqlConnection(Connect.Connstring)
                con.Open()
                Using cmd As New SqlCommand(sql, con)
                    Dim customerID As Integer = 1
                    cmd.Parameters.AddWithValue("@TransactionNumber", Me.transactionNumber)
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now.Date)
                    cmd.Parameters.AddWithValue("@Time", DateTime.Now.TimeOfDay)
                    cmd.Parameters.AddWithValue("@CustomerID", customerID)
                    cmd.Parameters.AddWithValue("@TotalAmount", totalAmount)
                    cmd.Parameters.AddWithValue("@CashGiven", cashGiven)
                    cmd.Parameters.AddWithValue("@ChangeAmount", changeAmount)
                    cmd.Parameters.AddWithValue("@ItemsData", itemsData.ToString())
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving receipt: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub PreviewReceipt()
        Try
            Dim dt As New DataTable()
            Using con As New SqlConnection(Connect.Connstring)
                Dim sql As String = "SELECT * FROM Receipts WHERE TransactionNumber = @TransactionNumber"
                Dim cmd As New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@TransactionNumber", Me.transactionNumber)
                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dt)
            End Using

            If dt.Rows.Count > 0 Then
                Me.receiptData = dt.Rows(0)
                Dim itemsDataJson As String = Me.receiptData("ItemsData").ToString()
                Me.itemsList = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of Object))(itemsDataJson)

                Changelongpaper()
                PPD.Document = PD
                ' ✅ Make the preview dialog fullscreen
                PPD.WindowState = FormWindowState.Maximized
                'PPD.PrintPreviewControl.Zoom = 1.0R ' Full size (100%)
                PPD.ShowDialog()
            Else
                MessageBox.Show("Receipt not found for preview.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Error previewing receipt: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DisableButtonsAfterTransaction()
        btnempsave.Enabled = False
        Pointofsalesystem.btnsettlepayment.Enabled = False
        Pointofsalesystem.btnquantity.Enabled = False
        Pointofsalesystem.btnrestran.Enabled = False
    End Sub

    Private Sub LoadCurrentEmployeeName()
        Try
            If Not String.IsNullOrEmpty(logUsername) Then
                Using con As New SqlConnection(Connect.Connstring)
                    con.Open()
                    Dim query As String = "SELECT EmployeeName FROM Employees WHERE Username = @Username"
                    Using cmd As New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@Username", logUsername)
                        Dim result = cmd.ExecuteScalar()
                        If result IsNot Nothing Then
                            txtcostumer.Text = result.ToString()
                        Else
                            txtcostumer.Text = logUsername ' Fallback to username if employee name not found
                        End If
                    End Using
                End Using
            Else
                txtcostumer.Text = "Unknown Employee"
            End If
        Catch ex As Exception
            txtcostumer.Text = logUsername ' Fallback to username if there's an error
        End Try
    End Sub

    Private Sub updatetotalamount()
        Dim total As Decimal = 0
        For Each row As DataGridViewRow In Pointofsalesystem.dgvcart.Rows
            If Not row.IsNewRow Then
                total += Convert.ToDecimal(row.Cells(4).Value.ToString().Replace("₱", "").Replace(",", "").Trim())
            End If
        Next
        Pointofsalesystem.lbltotal.Text = "₱" & total.ToString("N2")
    End Sub

    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer

    Sub Changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = Pointofsalesystem.dgvcart.Rows.Count
        longpaper = rowcount * 25
        longpaper = longpaper + 350
    End Sub
    Private Sub PD_BeginPrint(sender As Object, e As Printing.PrintEventArgs) Handles PD.BeginPrint
        Dim marginSize As Integer = 50
        Dim screenWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height
        Dim pagesetup As New PageSettings

        ' Increase the width of the physical receipt paper
        pagesetup.Margins = New Margins(10, 10, 10, 10)
        pagesetup.PaperSize = New PaperSize("Custom", 300, longpaper + 50)
        PD.DefaultPageSettings = pagesetup

        ' Position the print preview dialog in the center
        PPD.StartPosition = FormStartPosition.CenterParent
        PPD.Location = New Point((screenWidth - PPD.Width) \ 3, (screenHeight - PPD.Height) \ 3)

        ' Increase the width of the print preview dialog to accommodate the wider paper
        PPD.Width = 450
        PPD.Height = 700

        pagesetup.Margins = New Printing.Margins(marginSize, marginSize, marginSize, marginSize)
    End Sub
    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        If Me.receiptData Is Nothing Then Exit Sub

        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)
        Dim Centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim right As New StringFormat
        Dim Center As New StringFormat
        right.Alignment = StringAlignment.Far
        Center.Alignment = StringAlignment.Center
        Dim line As String = "-----------------------------------------------------------------------------------------------------"
        Dim currentY As Integer = 5

        e.Graphics.DrawString("CHEN MOTORPARTS", f14, Brushes.Black, Centermargin, currentY, Center)
        currentY += 20
        e.Graphics.DrawString("Tuguegarao City", f10, Brushes.Black, Centermargin, currentY, Center)
        currentY += 15
        e.Graphics.DrawString("CP # 09123456789", f10, Brushes.Black, Centermargin, currentY, Center)
        currentY += 20
        e.Graphics.DrawString("Transaction # : " & Me.receiptData("TransactionNumber").ToString(), f10, Brushes.Black, 0, currentY)
        currentY += 15
        'e.Graphics.DrawString("Cashier: " & Format(Pointofsalesystem.LblUser.Text, ""), f10, Brushes.Black, 0, currentY)
        'currentY += 15
        e.Graphics.DrawString("Cashier: " & Format(logUsername), f10, Brushes.Black, 0, currentY)
        currentY += 15
        Dim transactionDate As Date = Me.receiptData("TransactionDate")
        Dim transactionTime As TimeSpan = Me.receiptData("TransactionTime")
        Dim formattedDateTime As String = transactionDate.ToString("MM/dd/yyyy") + " " + transactionTime.ToString("hh\:mm\:ss")
        e.Graphics.DrawString(formattedDateTime, f10, Brushes.Black, 0, currentY)
        currentY += 15
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, currentY)

        currentY += 10
        e.Graphics.DrawString("Qty", f10b, Brushes.Black, 8, currentY)
        e.Graphics.DrawString("Item Name", f10b, Brushes.Black, 50, currentY) ' Increased width
        e.Graphics.DrawString("Price", f10b, Brushes.Black, 160, currentY) ' Left-aligned
        e.Graphics.DrawString("Total", f10b, Brushes.Black, PD.DefaultPageSettings.PaperSize.Width - 10, currentY, right) ' Right-aligned to match values
        currentY += 15
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, currentY)

        For Each item In Me.itemsList
            currentY += 25
            Dim qty As String = item("Qty").ToString()
            Dim productName As String = item("Product").ToString()
            Dim price As Double = Convert.ToDouble(item("Price"))
            Dim totalPrice As Double = Convert.ToDouble(item("Total"))

            e.Graphics.DrawString(qty, f8, Brushes.Black, 10, currentY)
            e.Graphics.DrawString(productName, f8, Brushes.Black, 50, currentY) ' Increased width
            e.Graphics.DrawString("₱" & price.ToString("N2"), f8, Brushes.Black, 160, currentY) ' Left-aligned
            e.Graphics.DrawString("₱" & totalPrice.ToString("N2"), f8, Brushes.Black, PD.DefaultPageSettings.PaperSize.Width - 10, currentY, right) ' Right-aligned to match Amount Due
        Next

        currentY += 25
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, currentY)

        ' Calculate total items and total quantity
        Dim totalItems As Integer = Me.itemsList.Count
        Dim totalQuantity As Integer = 0
        For Each item In Me.itemsList
            totalQuantity += Convert.ToInt32(item("Qty"))
        Next

        currentY += 10
        e.Graphics.DrawString("Total Items: " & totalItems.ToString(), f10, Brushes.Black, 0, currentY)
        currentY += 15
        e.Graphics.DrawString("total Quantity: " & totalQuantity.ToString(), f10, Brushes.Black, 0, currentY)
        currentY += 10
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, currentY)
        currentY += 15
        e.Graphics.DrawString("Amount Due:", f10b, Brushes.Black, 0, currentY)
        e.Graphics.DrawString("₱" & Format(Me.receiptData("TotalAmount"), "N2"), f10b, Brushes.Black, PD.DefaultPageSettings.PaperSize.Width - 10, currentY, right)
        currentY += 15
        e.Graphics.DrawString("Cash:", f10b, Brushes.Black, 0, currentY)
        e.Graphics.DrawString("₱" & Format(Me.receiptData("CashGiven"), "N2"), f10b, Brushes.Black, PD.DefaultPageSettings.PaperSize.Width - 10, currentY, right)
        currentY += 15
        e.Graphics.DrawString("change:", f10b, Brushes.Black, 0, currentY)
        e.Graphics.DrawString("₱" & Format(Me.receiptData("ChangeAmount"), "N2"), f10b, Brushes.Black, PD.DefaultPageSettings.PaperSize.Width - 10, currentY, right)
        currentY += 30
        e.Graphics.DrawString("Thanks for shopping!!!", f10, Brushes.Black, Centermargin, currentY, Center)
        currentY += 15
        e.Graphics.DrawString("CHEN MOTORPARTS", f10, Brushes.Black, Centermargin, currentY, Center)
    End Sub
    Dim t_price As Decimal
    Dim t_qty As Long
    Sub sumprice()
        Dim countprice As Long = 0
        For rowitem As Long = 0 To Pointofsalesystem.dgvcart.RowCount - 1
            countprice = countprice + Val(Pointofsalesystem.dgvcart.Rows(rowitem).Cells(3).Value * Val(Pointofsalesystem.dgvcart.Rows(rowitem).Cells(2).Value))
        Next
        t_price = countprice
        Dim countqty As Long
        For rowitem As Long = 0 To Pointofsalesystem.dgvcart.RowCount - 1
            countqty = countqty + Val(Pointofsalesystem.dgvcart.Rows(rowitem).Cells(2).Value)
        Next
        t_qty = countqty
    End Sub


End Class