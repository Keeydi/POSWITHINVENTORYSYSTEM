Imports Microsoft.Data.SqlClient

Public Class frmCategorylist

    Private Sub category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategoryData()
        StyleGrid()   ' Apply styling when form loads
    End Sub

    ' === Add optional searchText parameter ===
    Private Sub LoadCategoryData(Optional searchText As String = "")
        Dim query As String = "SELECT categoryID, categoryName, categoryDescription FROM Category WHERE isArchived = 0"

        ' Add search filter if user types something
        If searchText <> "" Then
            query &= " AND categoryName LIKE @search"
        End If

        Dim conn As New Microsoft.Data.SqlClient.SqlConnection(Connect.Connstring)
        Dim cmd As New Microsoft.Data.SqlClient.SqlCommand(query, conn)

        If searchText <> "" Then
            cmd.Parameters.AddWithValue("@search", searchText & "%") ' starts with the letters typed
        End If

        Dim adapter As New Microsoft.Data.SqlClient.SqlDataAdapter(cmd)
        Dim dt As New DataTable()

        adapter.Fill(dt)
        dgvCategory.DataSource = dt

        AlignGrid()   ' Align columns after loading
    End Sub

    Private Sub dgvCategory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategory.CellContentClick

    End Sub

    ' === Align columns like a table ===
    Private Sub AlignGrid()
        If dgvCategory.Columns.Count = 0 Then Exit Sub

        dgvCategory.Columns("CategoryID").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvCategory.Columns("CategoryName").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvCategory.Columns("CategoryDescription").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        dgvCategory.Columns("CategoryID").Width = 200
        dgvCategory.Columns("CategoryName").Width = 500
        dgvCategory.Columns("CategoryDescription").Width = 1000

        For Each col As DataGridViewColumn In dgvCategory.Columns
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub

    ' === Style grid like frmProductlist ===
    Private Sub StyleGrid()
        With dgvCategory
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
            .Columns("categoryName").HeaderText = "CATEGORY NAME"
            .Columns("categoryDescription").HeaderText = "CATEGORY DESCRIPTION"
            .Columns("categoryID").HeaderText = "CATEGORY ID"
        End With
    End Sub

    ' === LIVE SEARCH as you type ===
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadCategoryData(txtSearch.Text.Trim())
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnArchiveCategory_Click_1(sender As Object, e As EventArgs) Handles btnArchiveCategory.Click
        If dgvCategory.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a category first.")
            Return
        End If

        If Not dgvCategory.Columns.Contains("CategoryID") Then
            MessageBox.Show("CategoryID column is missing in the data source.")
            Return
        End If

        Dim categoryID = Convert.ToInt32(dgvCategory.SelectedRows(0).Cells("CategoryID").Value)

        Dim query = "UPDATE Category SET isArchived = 1 WHERE CategoryID = @CategoryID"

        Using conn As New Microsoft.Data.SqlClient.SqlConnection(Connstring)
            Using cmd As New Microsoft.Data.SqlClient.SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@CategoryID", categoryID)
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            End Using
        End Using
        LogActivity(logUsername, "archived " & dgvCategory.SelectedRows(0).Cells("CategoryName").Value.ToString & " category.", "Categoty Archived")
        MessageBox.Show("Category archived successfully.")
        LoadCategoryData()
    End Sub

    Private Sub btnAddCategory_Click_1(sender As Object, e As EventArgs) Handles btnAddCategory.Click
        Dim frm As New frmAECategory
        frm.Tag = "Add"
        frm.ShowDialog()
        LoadCategoryData()
    End Sub

    Private Sub btnEditCategory_Click_1(sender As Object, e As EventArgs) Handles btnEditCategory.Click
        If dgvCategory.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a category to edit.")
            Exit Sub
        End If

        Dim selectedRow = dgvCategory.SelectedRows(0)
        Dim frm As New frmAECategory

        frm.Tag = "Edit"
        frm.CategoryID = Convert.ToInt32(dgvCategory.SelectedRows(0).Cells("CategoryID").Value)
        frm.txtCategoryName.Text = selectedRow.Cells("CategoryName").Value.ToString
        frm.txtCategoryDescription.Text = selectedRow.Cells("CategoryDescription").Value.ToString

        frm.ShowDialog()
        LoadCategoryData()
    End Sub
End Class
