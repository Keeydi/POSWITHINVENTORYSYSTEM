Imports System.Data.SqlClient

Public Class frmMAINDASHBOARD


    ' Function to execute scalar queries (returns integer)
    Public Function ExecuteScalarQuery(query As String) As Integer
        Dim result As Integer = 0
        Using connection As New SqlConnection(Connstring)
            Using command As New SqlCommand(query, connection)
                Try
                    connection.Open()
                    result = Convert.ToInt32(command.ExecuteScalar())
                Catch ex As Exception
                    MessageBox.Show("Database error in ExecuteScalarQuery: " & ex.Message & vbCrLf & "Query: " & query)
                End Try
            End Using
        End Using
        Return result
    End Function

    ' Function to execute scalar queries (returns decimal)
    Public Function ExecuteScalarQueryDecimal(query As String) As Decimal
        Dim result As Decimal = 0
        Using connection As New SqlConnection(Connstring)
            Using command As New SqlCommand(query, connection)
                Try
                    connection.Open()
                    result = Convert.ToDecimal(command.ExecuteScalar())
                Catch ex As Exception
                    MessageBox.Show("Database error in ExecuteScalarQueryDecimal: " & ex.Message & vbCrLf & "Query: " & query)
                End Try
            End Using
        End Using
        Return result
    End Function

    ' Function to check if vwTransactions exists
    Public Function CheckIfViewExists() As Boolean
        Dim query As String = "USE JB_DB; SELECT COUNT(*) FROM INFORMATION_SCHEMA.VIEWS WHERE TABLE_NAME = 'viewTransactions'"
        Dim viewCount As Integer = ExecuteScalarQuery(query)
        Return viewCount > 0
    End Function

    ' Function to get total sales today
    Public Function GetTotalSalesToday() As Decimal
        Dim query As String = "SELECT COALESCE(SUM(Price * Quantity), 0) FROM dbo.viewTransactions WHERE CAST(Date AS DATE) = CAST(GETDATE() AS DATE)"
        Return ExecuteScalarQueryDecimal(query)
    End Function

    ' Function to get total stock added today
    Public Function GetTotalStockAddedToday() As Integer
        Dim query As String = "SELECT COALESCE(SUM(Quantity), 0) FROM Stockin WHERE CAST(DateStockin AS DATE) = CAST(GETDATE() AS DATE)"
        Return ExecuteScalarQuery(query)
    End Function

    ' Function to get total Employee 
    Public Function GetTotalEmployees() As Integer
        Dim query As String = "SELECT COUNT(*) FROM Employees WHERE IsArchived = 0"
        Return ExecuteScalarQuery(query)
    End Function

    ' Function to get total items sold today
    Public Function GetTotalItemsSoldToday() As Integer
        Dim query As String = "SELECT COALESCE(SUM(Quantity), 0) FROM dbo.viewTransactions WHERE CAST(Date AS DATE) = CAST(GETDATE() AS DATE)"
        Return ExecuteScalarQuery(query)
    End Function

    ' Function to get the best-selling products for today
    Public Function GetBestSellingProducts() As String
        Dim query As String = "SELECT TOP 1 Product.ProductName, SUM(PosDetails.Quantity) AS TotalSold " &
                              "FROM PosHead " &
                              "INNER JOIN PosDetails ON PosHead.TransactionID = PosDetails.TransactionID " &
                              "INNER JOIN Product ON PosDetails.ProductID = Product.ProductID " &
                              "WHERE CAST(PosHead.Date AS DATE) = CAST(GETDATE() AS DATE) " &
                              "GROUP BY Product.ProductName " &
                              "ORDER BY TotalSold DESC"

        Dim bestSellingProducts As String = ""

        Using connection As New SqlConnection(Connstring)
            Using command As New SqlCommand(query, connection)
                Try
                    connection.Open()
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            bestSellingProducts &= reader("ProductName").ToString() & " / "
                        End While
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Database error in GetBestSellingProducts: " & ex.Message & vbCrLf & "Query: " & query)
                End Try
            End Using
        End Using

        ' Remove the trailing "/ " if any
        If bestSellingProducts.Length > 0 Then
            bestSellingProducts = bestSellingProducts.Substring(0, bestSellingProducts.Length - 3)
        End If

        Return bestSellingProducts
    End Function

    ' Event handler for the dashboard load
    Private Sub Dash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer1.Interval = 1000
        ' Update dashboard labels with data from the database
        lbltotalsalestoday.Text = "₱" & GetTotalSalesToday().ToString("N2") ' Format as peso
        lbltotalstockintoday.Text = GetTotalStockAddedToday().ToString()
        lblEmployees.Text = GetTotalEmployees().ToString()
        'lbltotalitemsoldtoday.Text = GetTotalItemsSoldToday().ToString()
        lblbestsellingproduct.Text = GetBestSellingProducts()
        Reloadlow()
        ReloadOUT()
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

    Sub formatgridlow()
        ' Remove all borders
        dgvlow.BorderStyle = BorderStyle.None
        dgvlow.CellBorderStyle = DataGridViewCellBorderStyle.None
        dgvlow.RowHeadersVisible = False
        dgvlow.ColumnHeadersVisible = True
        dgvlow.GridColor = Color.White ' makes gridlines invisible

        ' Center the data
        dgvlow.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        For Each column As DataGridViewColumn In dgvlow.Columns
            column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
        dgvlow.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvlow.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 12, FontStyle.Regular)
        dgvlow.DefaultCellStyle.Font = New Font("Segoe UI", 12)

        ' Autosize
        dgvlow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvlow.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        ' Column visibility/widths
        dgvlow.Columns(0).Visible = False
        dgvlow.Columns(1).Visible = False
        dgvlow.Columns(2).Visible = False
        dgvlow.Columns(3).Width = 200
        dgvlow.Columns(4).Visible = False
        dgvlow.Columns(5).Width = 100
        dgvlow.Columns(6).Visible = False
        dgvlow.Columns(7).Visible = False
        dgvlow.Columns(8).Visible = False

        ' Prevent auto-selecting first cell
        dgvlow.ClearSelection()
    End Sub

    Private Sub Reloadlow()
        ExecuteSQLStatement("SELECT * FROM Product WHERE IsArchived = 0 AND Stock >= 1 AND Stock <= 10", dgvlow)
        formatgridlow()
    End Sub
    Sub formatgridOUT()
        ' Remove all borders
        dgvout.BorderStyle = BorderStyle.None
        dgvout.CellBorderStyle = DataGridViewCellBorderStyle.None
        dgvout.RowHeadersVisible = False
        dgvout.ColumnHeadersVisible = True
        dgvout.GridColor = Color.White ' makes gridlines invisible

        ' Center the data
        dgvout.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        For Each column As DataGridViewColumn In dgvout.Columns
            column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
        dgvout.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvout.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 12, FontStyle.Regular)
        dgvout.DefaultCellStyle.Font = New Font("Segoe UI", 12)

        ' Autosize
        dgvout.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvout.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        ' Column visibility/widths
        dgvout.Columns(0).Visible = False
        dgvout.Columns(1).Visible = False
        dgvout.Columns(2).Visible = False
        dgvout.Columns(3).Width = 200
        dgvout.Columns(4).Visible = False
        dgvout.Columns(5).Width = 100
        dgvout.Columns(6).Visible = False
        dgvout.Columns(7).Visible = False
        dgvout.Columns(8).Visible = False

        ' Prevent auto-selecting first cell
        dgvout.ClearSelection()
    End Sub
    Private Sub ReloadOUT()
        ExecuteSQLStatement("SELECT * FROM Product WHERE IsArchived = 0 AND Stock = 0", dgvout)
        formatgridOUT()
    End Sub
    Private Sub dgvlow_SelectionChanged(sender As Object, e As EventArgs) Handles dgvlow.SelectionChanged
        dgvlow.ClearSelection()
        dgvlow.CurrentCell = Nothing
    End Sub
    Private Sub dgvout_SelectionChanged(sender As Object, e As EventArgs) Handles dgvout.SelectionChanged
        dgvout.ClearSelection()
        dgvout.CurrentCell = Nothing
    End Sub
End Class
