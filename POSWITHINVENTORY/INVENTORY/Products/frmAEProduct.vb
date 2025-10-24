Imports Microsoft.Data.SqlClient

Public Class frmAEProduct
    Public Mode As String
    Public ProductID As Integer

    Private Sub frmAEProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()
        LoadUnits()

        ' Make Total Price read-only
        txtTotalPrice.ReadOnly = True


        ' ✅ Change title dynamically
        If Me.Tag = "Edit" Then
            Me.Text = "EDIT PRODUCTS"
        Else
            Me.Text = "ADD PRODUCTS"
        End If

        ' === FIX: if editing, load existing product values from DB ===
        If Me.Tag = "Edit" AndAlso ProductID > 0 Then
            LoadProductDetails()
        End If
    End Sub

    ' Load categories from database
    Private Sub LoadCategories()
        Dim conn As New SqlClient.SqlConnection(Connect.Connstring)
        Dim query As String = "SELECT categoryID, categoryName FROM Category WHERE isArchived = 0"

        Dim cmd As New SqlClient.SqlCommand(query, conn)
        Dim adapter As New SqlClient.SqlDataAdapter(cmd)
        Dim dt As New DataTable()

        adapter.Fill(dt)

        cmbCategory.DataSource = dt
        cmbCategory.DisplayMember = "categoryName"
        cmbCategory.ValueMember = "categoryID"
    End Sub

    ' Load unit of measurement options
    Private Sub LoadUnits()
        cmbUnit.Items.Clear()
        cmbUnit.Items.Add("Liters")
        cmbUnit.Items.Add("Per Piece")
        cmbUnit.Items.Add("Millimeters")
        cmbUnit.Items.Add("Grams")

        cmbUnit.SelectedIndex = 0 ' default
    End Sub

    ' ================== NEW: Load product details for Edit mode ==================
    Private Sub LoadProductDetails()
        Dim conn As New SqlClient.SqlConnection(Connect.Connstring)
        Dim query As String = "SELECT CategoryID, ProductCode, ProductName, BrandName, Type, UnitOfMeasurement, Stock, UnitPrice 
                               FROM Product WHERE ProductID = @ProductID"

        Dim cmd As New SqlClient.SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@ProductID", ProductID)

        Try
            conn.Open()
            Dim rdr As SqlClient.SqlDataReader = cmd.ExecuteReader()

            If rdr.Read() Then
                ' Map columns by name (ensures correct fields)
                If Not IsDBNull(rdr("CategoryID")) Then
                    cmbCategory.SelectedValue = Convert.ToInt32(rdr("CategoryID"))
                End If

                txtProductCode.Text = If(IsDBNull(rdr("ProductCode")), "", rdr("ProductCode").ToString())
                txtProductName.Text = If(IsDBNull(rdr("ProductName")), "", rdr("ProductName").ToString())
                txtBrandName.Text = If(IsDBNull(rdr("BrandName")), "", rdr("BrandName").ToString())
                txtType.Text = If(IsDBNull(rdr("Type")), "", rdr("Type").ToString())

                ' Stock should be numeric (from DB)
                txtStock.Text = If(IsDBNull(rdr("Stock")), "0", rdr("Stock").ToString())

                txtUnitPrice.Text = If(IsDBNull(rdr("UnitPrice")), "0.00", Convert.ToDecimal(rdr("UnitPrice")).ToString("0.##"))

                Dim uom As String = If(IsDBNull(rdr("UnitOfMeasurement")), "", rdr("UnitOfMeasurement").ToString())
                If cmbUnit.Items.Contains(uom) Then
                    cmbUnit.SelectedItem = uom
                End If

                CalculateTotalPrice()
            End If

            rdr.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading product details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub
    ' ===========================================================================

    Private Sub txtStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStock.KeyPress
        If Char.IsControl(e.KeyChar) Then Return
        If Not Char.IsDigit(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub txtUnitPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnitPrice.KeyPress
        If Char.IsControl(e.KeyChar) Then Return
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then e.Handled = True
        If e.KeyChar = "."c AndAlso txtUnitPrice.Text.Contains(".") Then e.Handled = True
    End Sub

    Private Sub CalculateTotalPrice()
        Dim stock As Integer
        Dim unitPrice As Decimal

        If Integer.TryParse(txtStock.Text, stock) AndAlso Decimal.TryParse(txtUnitPrice.Text, unitPrice) Then
            txtTotalPrice.Text = (stock * unitPrice).ToString("F2")
        Else
            txtTotalPrice.Text = "0.00"
        End If
    End Sub

    Private Sub txtStock_TextChanged(sender As Object, e As EventArgs) Handles txtStock.TextChanged
        CalculateTotalPrice()
    End Sub

    Private Sub txtUnitPrice_TextChanged(sender As Object, e As EventArgs) Handles txtUnitPrice.TextChanged
        CalculateTotalPrice()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If String.IsNullOrWhiteSpace(txtProductCode.Text) OrElse
           String.IsNullOrWhiteSpace(txtProductName.Text) OrElse
           String.IsNullOrWhiteSpace(txtStock.Text) OrElse
           String.IsNullOrWhiteSpace(txtUnitPrice.Text) Then

            MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim categoryID As Integer = Convert.ToInt32(cmbCategory.SelectedValue)
        Dim productCode As String = txtProductCode.Text.Trim()
        Dim productName As String = txtProductName.Text.Trim()
        Dim brandName As String = txtBrandName.Text.Trim()
        Dim type As String = txtType.Text.Trim()
        Dim uom As String = cmbUnit.SelectedItem.ToString()
        Dim stock As Integer = Convert.ToInt32(txtStock.Text.Trim())
        Dim unitPrice As Decimal = Convert.ToDecimal(txtUnitPrice.Text.Trim())
        Dim totalPrice As Decimal = stock * unitPrice

        If stock <= 0 OrElse unitPrice <= 0 Then
            MessageBox.Show("Stock and Unit Price must be greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Me.Tag = "Add" Then
            Dim conn As New SqlClient.SqlConnection(Connect.Connstring)
            Dim query As String = "INSERT INTO Product (CategoryID, ProductCode, ProductName, BrandName, Type, UnitOfMeasurement, Stock, UnitPrice) " &
                                  "VALUES (@CategoryID, @ProductCode, @ProductName, @BrandName, @Type, @UOM, @Stock, @UnitPrice)"

            Using cmd As New SqlClient.SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@CategoryID", categoryID)
                cmd.Parameters.AddWithValue("@ProductCode", productCode)
                cmd.Parameters.AddWithValue("@ProductName", productName)
                cmd.Parameters.AddWithValue("@BrandName", brandName)
                cmd.Parameters.AddWithValue("@Type", type)
                cmd.Parameters.AddWithValue("@UOM", uom)
                cmd.Parameters.AddWithValue("@Stock", stock)
                cmd.Parameters.AddWithValue("@UnitPrice", unitPrice)

                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            End Using

            MessageBox.Show("Product added successfully.")
        End If

        If Me.Tag = "Edit" Then
            Dim conn As New SqlClient.SqlConnection(Connect.Connstring)
            Using cmd As New SqlClient.SqlCommand("UPDATE Product SET 
                            CategoryID = @CategoryID,
                            ProductCode = @ProductCode,
                            ProductName = @ProductName,
                            BrandName = @BrandName,
                            Type = @Type,
                            UnitOfMeasurement = @UOM,
                            Stock = @Stock,
                            UnitPrice = @UnitPrice
                          WHERE ProductID = @ProductID", conn)

                cmd.Parameters.AddWithValue("@CategoryID", categoryID)
                cmd.Parameters.AddWithValue("@ProductCode", productCode)
                cmd.Parameters.AddWithValue("@ProductName", productName)
                cmd.Parameters.AddWithValue("@BrandName", brandName)
                cmd.Parameters.AddWithValue("@Type", type)
                cmd.Parameters.AddWithValue("@UOM", uom)
                cmd.Parameters.AddWithValue("@Stock", stock)
                cmd.Parameters.AddWithValue("@UnitPrice", unitPrice)
                cmd.Parameters.AddWithValue("@ProductID", ProductID)

                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            End Using

            MessageBox.Show("Product updated successfully.")
        End If

        Dim openForm = Application.OpenForms.OfType(Of frmProductlist)().FirstOrDefault()
        If openForm IsNot Nothing Then
            openForm.LoadProducts()
        End If
        If Me.Tag = "add" Then
            LogActivity(logUsername, "Added", "Added Item " & txtProductName.Text)
        ElseIf Me.Tag = "edit" Then
            LogActivity(logUsername, "Edited", "Edited Item Details " & txtProductName.Text)
        End If
        Me.Close()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to cancel? Unsaved changes will be lost.",
                                                     "Confirm Cancel",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            txtProductCode.Clear()
            txtProductName.Clear()
            txtStock.Clear()
            txtUnitPrice.Clear()
            txtTotalPrice.Clear()
            Me.Close()
        End If
    End Sub
End Class
