' frmaeEmployees.vb
Public Class frmaeEmployees
    Public Property Mode As String   ' "Add" or "Edit"
    Public Property EmployeeID As Integer

    Private Sub frmaeEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize combobox if designer didn't do it
        If cmbSex.Items.Count = 0 Then
            cmbSex.Items.Add("Male")
            cmbSex.Items.Add("Female")
        End If

        If Mode = "Edit" AndAlso EmployeeID > 0 Then
            LoadEmployeesDetails()
        End If
    End Sub

    Private Sub LoadEmployeesDetails()
        Dim query As String = "SELECT EmployeeName, Address, Email, Username, Sex FROM Employees WHERE EmployeeID = @EmployeeID"

        Using conn As New Microsoft.Data.SqlClient.SqlConnection(Connect.Connstring)
            Using cmd As New Microsoft.Data.SqlClient.SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID)
                conn.Open()
                Using reader As Microsoft.Data.SqlClient.SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        txtEmployeeName.Text = If(reader.IsDBNull(reader.GetOrdinal("EmployeeName")), "", reader("EmployeeName").ToString())
                        txtAddress.Text = If(reader.IsDBNull(reader.GetOrdinal("Address")), "", reader("Address").ToString())
                        txtEmail.Text = If(reader.IsDBNull(reader.GetOrdinal("Email")), "", reader("Email").ToString())
                        txtUsername.Text = If(reader.IsDBNull(reader.GetOrdinal("Username")), "", reader("Username").ToString())
                        cmbSex.Text = If(reader.IsDBNull(reader.GetOrdinal("Sex")), "", reader("Sex").ToString())
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If String.IsNullOrWhiteSpace(txtEmployeeName.Text) OrElse String.IsNullOrWhiteSpace(txtUsername.Text) OrElse cmbSex.SelectedIndex = -1 Then
            MessageBox.Show("Please fill out all required fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim query As String
        If Mode = "Add" Then
            query = "INSERT INTO Employees (EmployeeName, Address, Email, Username, Sex, isArchived) VALUES (@EmployeeName,@Address,@Email,@Username,@Sex,0)"
        Else
            query = "UPDATE Employees SET EmployeeName=@EmployeeName, Address=@Address, Email=@Email, Username=@Username, Sex=@Sex WHERE EmployeeID=@EmployeeID"
        End If

        Using conn As New Microsoft.Data.SqlClient.SqlConnection(Connstring)
            Using cmd As New Microsoft.Data.SqlClient.SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@EmployeeName", txtEmployeeName.Text.Trim)
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim)
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim)
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim)
                cmd.Parameters.AddWithValue("@Sex", cmbSex.Text.Trim)
                If Mode = "Edit" Then
                    cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID)
                End If

                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Employee saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        DialogResult = DialogResult.OK
        LogActivity(logUsername, If(Mode = "Add", "added", "edited") & " employee: " & txtEmployeeName.Text.Trim(), "Employee " & If(Mode = "Add", "Added", "Edited"))
        Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub


End Class
