Imports Microsoft.Data.SqlClient

Public Class frmArchives
    Private Sub frmArchives_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add filter options
        cmbfilter.Items.Clear()
        cmbfilter.Items.Add("Products")
        cmbfilter.Items.Add("Categories")
        cmbfilter.SelectedIndex = 0 ' Default: Products
        LoadArchivedData()
        StyleGrid()   ' Apply styling
    End Sub

    Private Sub cmbfilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbfilter.SelectedIndexChanged
        LoadArchivedData()
    End Sub

    ' This method will load archived Products or Categories depending on cmbfilter
    Public Sub LoadArchivedData(Optional searchText As String = "")
        Dim query As String = ""
        Dim dt As New DataTable()

        Using conn As New Microsoft.Data.SqlClient.SqlConnection(Connect.Connstring)

            If cmbfilter.SelectedItem.ToString() = "Products" Then
                query = "
                    SELECT 
                        P.ProductID, 
                        C.CategoryName AS [Category], 
                        P.ProductCode AS [ProductCode], 
                        P.ProductName AS [ProductName], 
                        P.UnitOfMeasurement AS [UnitOfMeasurement], 
                        P.Stock, 
                        P.UnitPrice, 
                        (P.Stock * P.UnitPrice) AS [TotalPrice]
                    FROM Product P
                    INNER JOIN Category C ON P.CategoryID = C.CategoryID
                    WHERE P.isArchived = 1
                "

                ' Add search filter (starts with ProductName)
                If searchText <> "" Then
                    query &= " AND P.ProductName LIKE @search + '%'"
                End If

            ElseIf cmbfilter.SelectedItem.ToString() = "Categories" Then
                query = "
                    SELECT 
                        CategoryID, 
                        CategoryName AS [Category], 
                        CategoryDescription AS [Description]
                    FROM Category
                    WHERE isArchived = 1
                "

                ' Add search filter (starts with CategoryName)
                If searchText <> "" Then
                    query &= " AND CategoryName LIKE @search + '%'"
                End If
            End If

            Using cmd As New Microsoft.Data.SqlClient.SqlCommand(query, conn)
                If searchText <> "" Then
                    cmd.Parameters.AddWithValue("@search", searchText)
                End If

                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dt)
                dgvArchivedProducts.DataSource = dt
            End Using
        End Using

        AlignGrid()  ' Align after data is loaded
    End Sub

    ' === Search Button ===
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadArchivedData(btnSearch.Text.Trim())
    End Sub

    ' === Live Search (trigger while typing) ===
    Private Sub txtSearch2_TextChanged(sender As Object, e As EventArgs) Handles txtSearch2.TextChanged
        Dim searchText = txtSearch2.Text.Trim
        If searchText = "" Then
            LoadArchivedData()
        Else
            LoadArchivedData(searchText)
        End If
    End Sub

    ' === Trigger search when pressing Enter in the search box ===
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Prevents beep sound
            LoadArchivedData(txtSearch2.Text.Trim)
        End If
    End Sub

    ' Restore Button
    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        If dgvArchivedProducts.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a record to restore.")
            Return
        End If

        Dim query As String = ""
        Dim id As Integer = Convert.ToInt32(dgvArchivedProducts.SelectedRows(0).Cells(0).Value)

        If cmbfilter.SelectedItem.ToString() = "Products" Then
            query = "UPDATE Product SET isArchived = 0 WHERE ProductID = @id"
        ElseIf cmbfilter.SelectedItem.ToString() = "Categories" Then
            query = "UPDATE Category SET isArchived = 0 WHERE CategoryID = @id"
        End If

        Using conn As New Microsoft.Data.SqlClient.SqlConnection(Connect.Connstring)
            Using cmd As New Microsoft.Data.SqlClient.SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Record restored successfully.")
        LoadArchivedData()
    End Sub

    ' Permanent Delete Button
    Private Sub btnPermanentDelete_Click(sender As Object, e As EventArgs) Handles btnPermanentDelete.Click
        If dgvArchivedProducts.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a record to delete permanently.")
            Return
        End If

        If MessageBox.Show("Are you sure you want to permanently delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Return
        End If

        Dim query As String = ""
        Dim id As Integer = Convert.ToInt32(dgvArchivedProducts.SelectedRows(0).Cells(0).Value)

        If cmbfilter.SelectedItem.ToString() = "Products" Then
            query = "DELETE FROM Product WHERE ProductID = @id"
        ElseIf cmbfilter.SelectedItem.ToString() = "Categories" Then
            query = "DELETE FROM Category WHERE CategoryID = @id"
        End If

        Using conn As New Microsoft.Data.SqlClient.SqlConnection(Connect.Connstring)
            Using cmd As New Microsoft.Data.SqlClient.SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Record deleted permanently.")
        LoadArchivedData()
    End Sub

    Private Sub dgvArchivedProducts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvArchivedProducts.CellContentClick

    End Sub

    ' === Align columns properly (like frmProductlist) ===
    Private Sub AlignGrid()
        If dgvArchivedProducts.Columns.Count = 0 Then Exit Sub

        If cmbfilter.SelectedItem.ToString() = "Products" Then
            dgvArchivedProducts.Columns("ProductID").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvArchivedProducts.Columns("ProductCode").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvArchivedProducts.Columns("ProductName").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvArchivedProducts.Columns("Category").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvArchivedProducts.Columns("UnitOfMeasurement").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvArchivedProducts.Columns("Stock").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvArchivedProducts.Columns("UnitPrice").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvArchivedProducts.Columns("TotalPrice").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dgvArchivedProducts.Columns("UnitPrice").DefaultCellStyle.Format = "N2"
            dgvArchivedProducts.Columns("TotalPrice").DefaultCellStyle.Format = "N2"

            dgvArchivedProducts.Columns("ProductID").Width = 80
            dgvArchivedProducts.Columns("ProductCode").Width = 120
            dgvArchivedProducts.Columns("ProductName").Width = 150
            dgvArchivedProducts.Columns("Category").Width = 140
            dgvArchivedProducts.Columns("UnitOfMeasurement").Width = 100
            dgvArchivedProducts.Columns("Stock").Width = 60
            dgvArchivedProducts.Columns("UnitPrice").Width = 100
            dgvArchivedProducts.Columns("TotalPrice").Width = 130
        ElseIf cmbfilter.SelectedItem.ToString() = "Categories" Then
            dgvArchivedProducts.Columns("CategoryID").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvArchivedProducts.Columns("Category").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvArchivedProducts.Columns("Description").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            dgvArchivedProducts.Columns("CategoryID").Width = 100
            dgvArchivedProducts.Columns("Category").Width = 200
            dgvArchivedProducts.Columns("Description").Width = 300
        End If

        For Each col As DataGridViewColumn In dgvArchivedProducts.Columns
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub

    ' === Style grid ===
    Private Sub StyleGrid()
        With dgvArchivedProducts
            .BorderStyle = BorderStyle.Fixed3D
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .GridColor = Color.Black
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .ReadOnly = True
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray
            .RowsDefaultCellStyle.SelectionBackColor = Color.LightBlue
            .RowsDefaultCellStyle.SelectionForeColor = Color.Black
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        End With
    End Sub
End Class
