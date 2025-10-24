Imports System.IO
Imports System.Data.SqlClient
Public Class frmStockIn


    Private Sub Stockin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LogActivity(logUsername, "Accessed", "Stock In")
        Me.BeginInvoke(Sub()
                           dgvProducts.ClearSelection()
                           dgvProducts.CurrentCell = Nothing
                       End Sub)
        Reload()
        ' Clear any default selection
        dgvProducts.ClearSelection()
        dgvProducts.CellBorderStyle = DataGridViewCellBorderStyle.None
        dgvProducts.RowHeadersVisible = False
        dgvProducts.ColumnHeadersVisible = True
        ' center teh datas
        dgvProducts.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        For Each column As DataGridViewColumn In dgvProducts.Columns
            column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

    End Sub
    Sub formatgrid()
        dgvProducts.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvProducts.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 12, FontStyle.Regular)
        dgvProducts.DefaultCellStyle.Font = New Font("Segoe UI", 12)
        dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        'dgvProducts.Columns("Quantity").HeaderText = "Stock"
        dgvProducts.Columns(0).Visible = False ' ProductID
        dgvProducts.Columns(1).Width = 100     ' ProductCode
        dgvProducts.Columns(2).Width = 150     ' ProductName
        dgvProducts.Columns(3).Width = 100     ' Brand
        dgvProducts.Columns(4).Width = 100     ' Type
        dgvProducts.Columns(5).Width = 100     ' Category
        dgvProducts.Columns(6).Width = 100     ' UnitOfMeasurement
        dgvProducts.Columns(7).Width = 80      ' Stock
        dgvProducts.Columns(8).Width = 100     ' UnitPrice
        dgvProducts.Columns(9).Visible = False ' IsArchived

        With dgvProducts
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
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        End With
    End Sub
    Private Sub Reload(Optional searchText As String = "")
        Dim query As String = "
        SELECT 
            P.ProductID,
            P.ProductCode,
            P.ProductName,
            ISNULL(P.BrandName, 'N/A') AS [Brand],
            ISNULL(P.Type, 'N/A') AS [Type],
            C.CategoryName AS [Category],
            P.UnitOfMeasurement,
            P.Stock,
            P.UnitPrice,
            P.IsArchived
        FROM Product P
        INNER JOIN Category C ON P.CategoryID = C.CategoryID
        WHERE P.IsArchived = 0"
        
        If searchText <> "" Then
            query += " AND P.ProductName LIKE '%" & txtSearch.Text & "%'"
        End If
        
        query += " ORDER BY P.ProductCode"
        
        ExecuteSQLStatement(query, dgvProducts)
        formatgrid()
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Reload(txtSearch.Text.Trim())
    End Sub



    Private Sub dgvproducts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellClick
        ' Ensure the click is on a valid cell
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Select the row of the clicked cell
            dgvProducts.Rows(e.RowIndex).Selected = True

            ' Optionally, scroll to the selected row
            dgvProducts.FirstDisplayedScrollingRowIndex = e.RowIndex
        End If
    End Sub


    Private Sub btnuseradd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If dgvProducts.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a product to STOCK.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        'AEStockin.txtquantity.Text = dgvProducts.CurrentRow.Cells("Stock").Value
        AStockin.txtprodid.Text = dgvProducts.CurrentRow.Cells("ProductID").Value
        AStockin.ShowDialog()
        Reload()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvProducts.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a product to STOCK.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Estockin.txtprodid.Text = dgvProducts.CurrentRow.Cells("ProductID").Value
        Estockin.ShowDialog()
        Reload()
    End Sub


    Private Sub btndefects_Click(sender As Object, e As EventArgs) Handles btndefects.Click
        If dgvProducts.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a Defective product.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        qdefects.DproductID = dgvProducts.CurrentRow.Cells("ProductID").Value
        qdefects.DproductCode = dgvProducts.CurrentRow.Cells("ProductCode").Value
        qdefects.DproductName = dgvProducts.CurrentRow.Cells("ProductName").Value
        qdefects.ShowDialog()
        Reload()
    End Sub


End Class