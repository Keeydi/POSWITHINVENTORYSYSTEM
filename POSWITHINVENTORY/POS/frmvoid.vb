Imports System.Windows.Forms

Public Class frmVoid


    Private itemsTable As DataTable

    ' Constructor to accept and initialize the DataTable
    Public Sub New(ByVal table As DataTable)
        InitializeComponent()
        itemsTable = table
    End Sub


    Private Sub InitializeDataGridView()
        ' Clear any existing columns (only if needed)
        ' Clear existing columns if any
        If dgv.Columns.Count > 0 Then
            dgv.Columns.Clear()
        End If

        ' Set the AutoSizeColumnsMode to make the columns fit the entire DataGridView
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.DefaultCellStyle.Font = New Font("Microsoft JhengHei UI", 16, FontStyle.Regular)
        dgv.RowTemplate.Height = 40
        dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft JhengHei UI", 18, FontStyle.Bold)
        ' Add the necessary columns
        dgv.Columns.Add("ProductCode", "Product Code")
        dgv.Columns.Add("Name", "Product Name")
        dgv.Font = New Font("Microsoft JhengHei UI", 30, FontStyle.Regular)

        ' Adding the Quantity column as an Integer type
        Dim qtyColumn As New DataGridViewTextBoxColumn
        qtyColumn.Name = "Quantity"
        qtyColumn.HeaderText = "Quantity"
        qtyColumn.ValueType = GetType(Integer) ' Ensures it accepts only integer values
        dgv.Columns.Add(qtyColumn)


        ' Adding the Price column as Decimal type, with appropriate formatting for currency
        Dim priceColumn As New DataGridViewTextBoxColumn
        priceColumn.Name = "Price"
        priceColumn.HeaderText = "Price"
        priceColumn.ValueType = GetType(Decimal)
        priceColumn.DefaultCellStyle.Format = "C2" ' Currency format
        dgv.Columns.Add(priceColumn)

        ' Adding the TotalPrice column as Decimal type
        Dim totalPriceColumn As New DataGridViewTextBoxColumn
        totalPriceColumn.Name = "TotalPrice"
        totalPriceColumn.HeaderText = "Total Price"
        totalPriceColumn.ValueType = GetType(Decimal)
        totalPriceColumn.DefaultCellStyle.Format = "C2" ' Currency format
        dgv.Columns.Add(totalPriceColumn)

        ' Adding the "Add to Payment" button column


        ' Optionally, set specific columns to auto-size based on content
        dgv.Columns("ProductCode").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgv.Columns("Name").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill ' Fills remaining space
        dgv.Columns("Quantity").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgv.Columns("Price").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgv.Columns("TotalPrice").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub
    ' Default constructor
    Public Sub New(rows As List(Of DataGridViewRow))
        ' Initialize the components
        InitializeComponent()
        ' Add rows to the DataGridView
        For Each row As DataGridViewRow In rows
            Dim clonedRow As DataGridViewRow = CType(row.Clone(), DataGridViewRow)
            For i As Integer = 0 To row.Cells.Count - 1
                clonedRow.Cells(i).Value = row.Cells(i).Value
            Next
            dgv.Rows.Add(clonedRow)
        Next
    End Sub

    Public Sub New(displayedRows As DataGridViewRowCollection)
        ' Initialize the components in the form
        InitializeComponent()

        ' Copy rows to the DataGridView in frmVoid
        For Each row As DataGridViewRow In displayedRows
            ' Clone the row and add it to the DataGridView in frmVoid
            Dim clonedRow As DataGridViewRow = CType(row.Clone(), DataGridViewRow)

            ' Copy cell values
            For i As Integer = 0 To row.Cells.Count - 1
                clonedRow.Cells(i).Value = row.Cells(i).Value
            Next

            ' Add the cloned row to the DataGridView
            dgv.Rows.Add(clonedRow)
        Next
    End Sub

    Private Sub frmVoid_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.X Then
            ' Save action
            btnVoid_Click(sender, e)
        End If
        If e.KeyCode = Keys.Escape Then
            ' Save action
            Guna2Button2_Click(sender, e)
        End If
    End Sub
    Private Sub frmVoid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        InitializeDataGridView()


        If itemsTable IsNot Nothing Then
            For Each row As DataRow In itemsTable.Rows
                dgv.Rows.Add(row.ItemArray)
            Next
        End If
    End Sub

    Private Sub btnVoid_Click(sender As Object, e As EventArgs) Handles btnempsave.Click
        VoidTransaction()
    End Sub
    Private Sub VoidTransaction()
        ' Check if there's a selected item in the DataGridView
        If dgv.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgv.SelectedRows(0)

            ' Confirm with the user before voiding the item
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to Delete this item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                ' Remove the selected item from the DataGridView
                dgv.Rows.Remove(selectedRow)

                For Each row As DataGridViewRow In Pointofsalesystem.dgvcart.Rows
                    ' Find the matching row in the main POS system based on a unique column (e.g., Product Code)
                    If row.Cells(0).Value.ToString() = selectedRow.Cells(0).Value.ToString() Then
                        Pointofsalesystem.dgvcart.Rows.Remove(row)
                        Pointofsalesystem.lbltotal.Text = "₱00.00"
                        Exit For
                    End If
                Next

                ' Show a message to confirm the void action
                MessageBox.Show("Item Deleted successfully.", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            ' Show a message if no item is selected
            MessageBox.Show("Please select an item to void.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


    End Sub
    Public Sub AddItemToVoid(productCode As String, productName As String, quantity As Integer, price As Decimal, totalPrice As Decimal)
        ' Add the item to the DataGridView in the Void form
        'dgv.Rows.Add(productCode, productName, quantity, price, totalPrice)
    End Sub



    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles btnempback.Click
        Me.Close()

    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        ' Ensure the click is on a valid cell
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Select the row of the clicked cell
            dgv.Rows(e.RowIndex).Selected = True
        End If
    End Sub
End Class