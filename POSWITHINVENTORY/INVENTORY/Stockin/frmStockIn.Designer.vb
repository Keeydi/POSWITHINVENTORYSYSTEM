<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockIn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label1 = New Label()
        dgvProducts = New DataGridView()
        btnAdd = New Button()
        btnEdit = New Button()
        btndefects = New Button()
        txtSearch = New TextBox()
        TableLayoutPanel1.SuspendLayout()
        CType(dgvProducts, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.CadetBlue
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 129F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 115F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 26F))
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Controls.Add(dgvProducts, 0, 1)
        TableLayoutPanel1.Controls.Add(btnAdd, 0, 2)
        TableLayoutPanel1.Controls.Add(btnEdit, 1, 2)
        TableLayoutPanel1.Controls.Add(btndefects, 2, 2)
        TableLayoutPanel1.Controls.Add(txtSearch, 2, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 4.674797F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 95.3252F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 40F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(1375, 674)
        TableLayoutPanel1.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        TableLayoutPanel1.SetColumnSpan(Label1, 2)
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ImeMode = ImeMode.NoControl
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 25)
        Label1.TabIndex = 0
        Label1.Text = "STOCK IN"
        ' 
        ' dgvProducts
        ' 
        dgvProducts.AllowUserToAddRows = False
        dgvProducts.AllowUserToDeleteRows = False
        dgvProducts.AllowUserToResizeColumns = False
        dgvProducts.AllowUserToResizeRows = False
        dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProducts.BackgroundColor = Color.White
        dgvProducts.BorderStyle = BorderStyle.None
        dgvProducts.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvProducts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        TableLayoutPanel1.SetColumnSpan(dgvProducts, 3)
        dgvProducts.Dock = DockStyle.Fill
        dgvProducts.EditMode = DataGridViewEditMode.EditOnEnter
        dgvProducts.EnableHeadersVisualStyles = False
        dgvProducts.GridColor = Color.White
        dgvProducts.ImeMode = ImeMode.NoControl
        dgvProducts.Location = New Point(3, 31)
        dgvProducts.Name = "dgvProducts"
        dgvProducts.ReadOnly = True
        dgvProducts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvProducts.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvProducts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProducts.Size = New Size(1369, 579)
        dgvProducts.TabIndex = 1
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.Cyan
        btnAdd.Font = New Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAdd.Location = New Point(3, 615)
        btnAdd.Margin = New Padding(3, 2, 3, 2)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(123, 36)
        btnAdd.TabIndex = 7
        btnAdd.Text = "Add Stocks"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.LightGreen
        btnEdit.Font = New Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEdit.Location = New Point(132, 615)
        btnEdit.Margin = New Padding(3, 2, 3, 2)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(109, 36)
        btnEdit.TabIndex = 8
        btnEdit.Text = "Edit Stock"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btndefects
        ' 
        btndefects.BackColor = Color.Khaki
        btndefects.Font = New Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btndefects.Location = New Point(247, 615)
        btndefects.Margin = New Padding(3, 2, 3, 2)
        btndefects.Name = "btndefects"
        btndefects.Size = New Size(146, 36)
        btndefects.TabIndex = 9
        btndefects.Text = "Defect"
        btndefects.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Dock = DockStyle.Right
        txtSearch.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(1068, 3)
        txtSearch.Multiline = True
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Type to Search..."
        txtSearch.Size = New Size(304, 22)
        txtSearch.TabIndex = 13
        ' 
        ' frmStockIn
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1375, 674)
        Controls.Add(TableLayoutPanel1)
        Name = "frmStockIn"
        Text = "frmStockIn"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(dgvProducts, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btndefects As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents txtSearch As TextBox
End Class
