Imports System.Data.SqlClient
Public Class Archemp


    Private Sub Defects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LogActivity(logUsername, "Accessed", "Employee Archives")
        Me.BeginInvoke(Sub()
                           dgvProducts.ClearSelection()
                           dgvProducts.CurrentCell = Nothing
                       End Sub)
        ' Hook up once (e.g. in Form_Load)
        AddHandler dgvProducts.DataBindingComplete, AddressOf dgvProducts_DataBindingComplete
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
    Private Sub formatgrid()
        Try
            ' Guard: form destroyed/disposed
            If Me Is Nothing OrElse Me.IsDisposed Then Return

            ' Guard: dgvProducts not created or disposed
            If dgvProducts Is Nothing OrElse dgvProducts.IsDisposed OrElse Not dgvProducts.IsHandleCreated Then
                Return
            End If

            ' If called from background thread, marshal to UI thread
            If dgvProducts.InvokeRequired Then
                dgvProducts.Invoke(Sub() formatgrid())
                Return
            End If

            ' Only format if there are columns
            If dgvProducts.Columns.Count = 0 Then
                Return
            End If

            ' Basic styles (safe)
            dgvProducts.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvProducts.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 12, FontStyle.Regular)
            dgvProducts.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 12)
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

            ' Set widths only if the column index exists
            If dgvProducts.Columns.Count > 0 Then dgvProducts.Columns(0).Width = 100
            If dgvProducts.Columns.Count > 1 Then dgvProducts.Columns(1).Width = 100
            If dgvProducts.Columns.Count > 2 Then dgvProducts.Columns(2).Width = 100
            If dgvProducts.Columns.Count > 3 Then dgvProducts.Columns(3).Width = 200
            If dgvProducts.Columns.Count > 4 Then dgvProducts.Columns(4).Width = 100
            If dgvProducts.Columns.Count > 5 Then dgvProducts.Columns(5).Width = 100
            If dgvProducts.Columns.Count > 6 Then dgvProducts.Columns(6).Visible = False

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
                .ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 10, FontStyle.Bold)
            End With

        Catch ex As Exception
            ' Log to Output/Debug. If it still throws, copy this message & stack trace and paste it back to me.
            Debug.WriteLine("formatgrid exception: " & ex.ToString())
        End Try
    End Sub

    Private Sub Reload()
        ExecuteSQLStatement("SELECT * FROM Employees WHERE isArchived = 1", dgvProducts)
        formatgrid()

    End Sub


    Private Sub dgvProducts_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs)
        formatgrid()
    End Sub

    Private Sub YourForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            RemoveHandler dgvProducts.DataBindingComplete, AddressOf dgvProducts_DataBindingComplete
        Catch
            ' ignore
        End Try
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
            MessageBox.Show("Please select a Employee to Restore.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        SaveDataReplaced()
        Reload()
    End Sub
    Private Sub SaveDataReplaced()

        Dim connection As New SqlClient.SqlConnection(Connstring)
        Try
            connection.Open()


            Dim query As String = "UPDATE Employees SET IsArchived = 0 WHERE EmployeeID = @EmployeeID "


            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@EmployeeID", dgvProducts.CurrentRow.Cells("EmployeeID").Value)
                command.ExecuteNonQuery()
                ' Show success message
                MessageBox.Show("Employee Restored successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End Using
            LogActivity(logUsername, "Restore", "Restored Employee ")
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
End Class
