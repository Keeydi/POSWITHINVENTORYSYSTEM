' frmEmployee.vb
Public Class frmEmployee

    Private Sub frmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LogActivity(logUsername, "Accessed", "Employee Management")
        LoadEmployees()
        StyleGrid()
    End Sub

    Public Sub LoadEmployees(Optional searchText As String = "")
        Dim query As String = "
            SELECT EmployeeID, EmployeeName, Address, Email, Username, Sex
            FROM Employees WHERE isArchived = 0"
        ' Add search filter if user types something
        If searchText <> "" Then
            query &= " AND EmployeeName LIKE @search"
        End If



        ' Fully-qualified Microsoft.Data.SqlClient types so the compiler can't pick the wrong one
        Using conn As New Microsoft.Data.SqlClient.SqlConnection(Connect.Connstring)
            Using cmd As New Microsoft.Data.SqlClient.SqlCommand(query, conn)
                If searchText <> "" Then
                    cmd.Parameters.AddWithValue("@search", searchText & "%") ' starts with the letters typed
                End If

                Dim adapter As New Microsoft.Data.SqlClient.SqlDataAdapter(cmd)
                Dim dt As New System.Data.DataTable()
                adapter.Fill(dt)
                ' Make sure your DataGridView name matches (dgvEmployee or dgvEmployees)
                dgvEmployee.DataSource = dt
            End Using
        End Using
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd1.Click
        Dim frm As New frmaeEmployees
        frm.Mode = "Add"
        frm.EmployeeID = 0
        frm.ShowDialog()
        LoadEmployees()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit1.Click
        If dgvEmployee.CurrentRow Is Nothing Then
            MessageBox.Show("Please select an employee to edit.")
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvEmployee.CurrentRow
        Dim frm As New frmaeEmployees()
        frm.Mode = "Edit"
        frm.EmployeeID = Convert.ToInt32(selectedRow.Cells("EmployeeID").Value)

        ' Pre-fill fields (keeps same UX as your product form)
        frm.txtEmployeeID.Text = Convert.ToInt32(selectedRow.Cells("EmployeeID").Value)
        frm.txtEmployeeName.Text = selectedRow.Cells("EmployeeName").Value.ToString()
        frm.txtAddress.Text = selectedRow.Cells("Address").Value.ToString()
        frm.txtEmail.Text = selectedRow.Cells("Email").Value.ToString()
        frm.txtUsername.Text = selectedRow.Cells("Username").Value.ToString()
        frm.cmbSex.Text = selectedRow.Cells("Sex").Value.ToString()

        frm.ShowDialog()
        LoadEmployees()
    End Sub

    Private Sub btnArchive_Click(sender As Object, e As EventArgs) Handles btnArchive1.Click
        If dgvEmployee.CurrentRow Is Nothing Then
            MessageBox.Show("Please select an employee to archive.")
            Return
        End If

        Dim empID As Integer = Convert.ToInt32(dgvEmployee.CurrentRow.Cells("EmployeeID").Value)
        Dim query As String = "UPDATE Employees SET isArchived = 1 WHERE EmployeeID = @EmployeeID"

        Using conn As New Microsoft.Data.SqlClient.SqlConnection(Connect.Connstring)
            Using cmd As New Microsoft.Data.SqlClient.SqlCommand(query, conn)
                ' explicitly add parameter (fully-qualified SqlParameter if you prefer)
                cmd.Parameters.AddWithValue("@EmployeeID", empID)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Employee archived successfully.")
        LogActivity(logUsername, "archived employee: " & dgvEmployee.CurrentRow.Cells("EmployeeName").Value.ToString(), "Employee Archived")
        LoadEmployees()
    End Sub

    Private Sub StyleGrid()
        With dgvEmployee
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .ReadOnly = True
            .RowHeadersVisible = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End With
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadEmployees(txtSearch.Text.Trim())
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Archemp.ShowDialog()
    End Sub
End Class
