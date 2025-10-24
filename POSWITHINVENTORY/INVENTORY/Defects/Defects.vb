Imports System.Data.SqlClient
Public Class Defects
    Private Sub Defects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LogActivity(logUsername, "Accessed", "Defects")
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
        If dgvProducts Is Nothing OrElse dgvProducts.IsDisposed Then
            Exit Sub
        End If
        dgvProducts.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvProducts.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 12, FontStyle.Regular)
        dgvProducts.DefaultCellStyle.Font = New Font("Segoe UI", 12)
        dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        'dgvProducts.Columns("Quantity").HeaderText = "Stock"
        dgvProducts.Columns(0).Visible = False
        dgvProducts.Columns(1).Visible = False
        dgvProducts.Columns(2).Width = 100
        dgvProducts.Columns(3).Width = 200
        dgvProducts.Columns(4).Width = 100

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
    Private Sub Reload()
        ExecuteSQLStatement("SELECT * FROM Defects ORDER BY DefectID", dgvProducts)
        formatgrid()

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

    Private Sub btnreplaced_Click(sender As Object, e As EventArgs) Handles btnreplaced.Click
        If dgvProducts.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a product to replace.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        SaveDataReplaced()
        Reload()
    End Sub
    Private Sub SaveDataReplaced()

        Dim connection As New SqlClient.SqlConnection(Connstring)
        Try
            connection.Open()


            Dim query As String = "UPDATE Product SET Stock = Stock + @quantity " &
                      "WHERE ProductID = @prodID; " &
                      "DELETE FROM Defects WHERE ProductID = @prodID;"


            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@prodID", dgvProducts.CurrentRow.Cells("ProductID").Value)
                command.Parameters.AddWithValue("@quantity", dgvProducts.CurrentRow.Cells("Stock").Value)
                command.ExecuteNonQuery()
                ' Show success message
                MessageBox.Show("Product Replaced successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End Using
            LogActivity(logUsername, "Replaced", "Replaced Defective Product " & dgvProducts.CurrentRow.Cells("ProductName").Value)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try

    End Sub
End Class