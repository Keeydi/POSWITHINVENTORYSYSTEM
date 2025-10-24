Imports Microsoft.Data.SqlClient

Public Class frmProductlist

    Private Sub frmProductlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LogActivity(logUsername, "Accessed", "Product List")
        LoadProducts()
        StyleGrid()
    End Sub

    Public Sub LoadProducts()
        Dim query As String = "
        SELECT 
            P.ProductID, 
            C.CategoryName AS [Category], 
            P.ProductCode AS [ProductCode], 
            P.ProductName AS [ProductName], 
            ISNULL(P.BrandName, 'N/A') AS [Brand], 
            ISNULL(P.Type, 'N/A') AS [Type], 
            P.UnitOfMeasurement AS [UnitOfMeasurement], 
            P.Stock, 
            P.UnitPrice, 
            (P.Stock * P.UnitPrice) AS [TotalPrice]
        FROM Product P
        INNER JOIN Category C ON P.CategoryID = C.CategoryID
        WHERE P.isArchived = 0
    "

        Using conn As New Microsoft.Data.SqlClient.SqlConnection(Connect.Connstring)
            Using cmd As New Microsoft.Data.SqlClient.SqlCommand(query, conn)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                dgvProducts.DataSource = dt
            End Using
        End Using

        AlignGrid()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frm As New frmAEProduct()
        frm.Tag = "Add"

        ' Clear fields for new product
        frm.txtProductCode.Text = ""
        frm.txtProductName.Text = ""
        frm.txtBrandName.Text = ""
        frm.txtType.Text = ""
        frm.txtStock.Text = ""
        frm.cmbCategory.SelectedIndex = -1
        frm.txtUnitPrice.Text = ""

        frm.ShowDialog()
        LoadProducts()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvProducts.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a product to edit.")
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvProducts.SelectedRows(0)
        Dim frm As New frmAEProduct()

        ' Set the mode to Edit
        frm.Tag = "Edit"
        ' Pass ProductID for the UPDATE query
        frm.ProductID = Convert.ToInt32(selectedRow.Cells("ProductID").Value)

        ' Fill form fields
        frm.txtProductCode.Text = selectedRow.Cells("ProductCode").Value.ToString()
        frm.txtProductName.Text = selectedRow.Cells("ProductName").Value.ToString()
        frm.txtStock.Text = selectedRow.Cells("Stock").Value.ToString()
        frm.cmbCategory.Text = selectedRow.Cells("Category").Value.ToString()
        frm.txtStock.Text = selectedRow.Cells("UnitOfMeasurement").Value.ToString()
        frm.txtUnitPrice.Text = selectedRow.Cells("UnitPrice").Value.ToString()

        frm.ShowDialog()

        ' Refresh the DataGridView after edit
        LoadProducts()
    End Sub

    Private Sub btnArchive_Click(sender As Object, e As EventArgs) Handles btnArchive.Click
        ' Check if a product is selected
        If dgvProducts.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a product to archive.")
            Return
        End If

        ' Get the ProductID of the selected product
        Dim productID As Integer = Convert.ToInt32(dgvProducts.SelectedRows(0).Cells("ProductID").Value)

        ' Update the product to be archived
        Dim query As String = "UPDATE Product SET isArchived = 1 WHERE ProductID = @ProductID"

        Using conn As New Microsoft.Data.SqlClient.SqlConnection(Connect.Connstring)
            Using cmd As New Microsoft.Data.SqlClient.SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ProductID", productID)
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            End Using
        End Using

        MessageBox.Show("Product archived successfully.")

        ' Refresh the main product list to remove the archived product
        LoadProducts()
        LogActivity(logUsername, "Archived", "ProductID: " & productID.ToString())
    End Sub

    Private Sub dgvProducts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellContentClick

    End Sub

    ' === Align columns properly ===
    Private Sub AlignGrid()
        If dgvProducts.Columns.Count = 0 Then Exit Sub

        dgvProducts.Columns("ProductID").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvProducts.Columns("ProductCode").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvProducts.Columns("ProductName").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvProducts.Columns("Category").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvProducts.Columns("UnitOfMeasurement").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvProducts.Columns("Stock").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvProducts.Columns("UnitPrice").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvProducts.Columns("TotalPrice").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        dgvProducts.Columns("UnitPrice").DefaultCellStyle.Format = "N2"
        dgvProducts.Columns("TotalPrice").DefaultCellStyle.Format = "N2"

        ' Set custom widths (not equal!)
        dgvProducts.Columns("ProductID").Width = 80
        dgvProducts.Columns("ProductCode").Width = 120
        dgvProducts.Columns("ProductName").Width = 200
        dgvProducts.Columns("Category").Width = 140
        dgvProducts.Columns("UnitOfMeasurement").Width = 100
        dgvProducts.Columns("Stock").Width = 100
        dgvProducts.Columns("UnitPrice").Width = 120
        dgvProducts.Columns("TotalPrice").Width = 130

        ' Center headers
        For Each col As DataGridViewColumn In dgvProducts.Columns
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub

    ' === Style grid (show lines) ===
    Private Sub StyleGrid()
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
End Class
