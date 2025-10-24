<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategorylist
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
        dgvCategory = New DataGridView()
        btnArchiveCategory = New Button()
        btnEditCategory = New Button()
        btnAddCategory = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        txtSearch = New TextBox()
        btnSearch4 = New Button()
        TableLayoutPanel2 = New TableLayoutPanel()
        CType(dgvCategory, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvCategory
        ' 
        dgvCategory.AllowUserToAddRows = False
        dgvCategory.AllowUserToDeleteRows = False
        dgvCategory.AllowUserToResizeColumns = False
        dgvCategory.AllowUserToResizeRows = False
        dgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCategory.BackgroundColor = Color.White
        dgvCategory.BorderStyle = BorderStyle.None
        dgvCategory.CellBorderStyle = DataGridViewCellBorderStyle.None
        dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCategory.Dock = DockStyle.Fill
        dgvCategory.EditMode = DataGridViewEditMode.EditOnEnter
        dgvCategory.EnableHeadersVisualStyles = False
        dgvCategory.GridColor = Color.White
        dgvCategory.ImeMode = ImeMode.NoControl
        dgvCategory.Location = New Point(3, 31)
        dgvCategory.Name = "dgvCategory"
        dgvCategory.ReadOnly = True
        dgvCategory.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        dgvCategory.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        dgvCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCategory.Size = New Size(1369, 579)
        dgvCategory.TabIndex = 1
        ' 
        ' btnArchiveCategory
        ' 
        btnArchiveCategory.BackColor = Color.Khaki
        btnArchiveCategory.Font = New Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnArchiveCategory.Margin = New Padding(3, 2, 3, 2)
        btnArchiveCategory.Name = "btnArchiveCategory"
        btnArchiveCategory.Size = New Size(146, 36)
        btnArchiveCategory.TabIndex = 9
        btnArchiveCategory.Text = "Archive"
        btnArchiveCategory.UseVisualStyleBackColor = False
        ' 
        ' btnEditCategory
        ' 
        btnEditCategory.BackColor = Color.LightGreen
        btnEditCategory.Font = New Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEditCategory.Margin = New Padding(3, 2, 3, 2)
        btnEditCategory.Name = "btnEditCategory"
        btnEditCategory.Size = New Size(109, 36)
        btnEditCategory.TabIndex = 8
        btnEditCategory.Text = "Edit"
        btnEditCategory.UseVisualStyleBackColor = False
        ' 
        ' btnAddCategory
        ' 
        btnAddCategory.BackColor = Color.Cyan
        btnAddCategory.Font = New Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddCategory.Margin = New Padding(3, 2, 3, 2)
        btnAddCategory.Name = "btnAddCategory"
        btnAddCategory.Size = New Size(123, 36)
        btnAddCategory.TabIndex = 7
        btnAddCategory.Text = "Add"
        btnAddCategory.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.CadetBlue
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 129F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 115F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 26F))
        TableLayoutPanel1.Controls.Add(btnAddCategory, 0, 2)
        TableLayoutPanel1.Controls.Add(btnEditCategory, 1, 2)
        TableLayoutPanel1.Controls.Add(btnArchiveCategory, 2, 2)
        TableLayoutPanel1.Controls.Add(dgvCategory, 0, 1)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 0, 0)
        TableLayoutPanel1.SetColumnSpan(dgvCategory, 3)
        TableLayoutPanel1.SetColumnSpan(TableLayoutPanel2, 3)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 4.674797F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 95.3252F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 40F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(1375, 674)
        TableLayoutPanel1.TabIndex = 2
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.White
        txtSearch.Dock = DockStyle.Right
        txtSearch.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(1068, 3)
        txtSearch.Multiline = True
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Type to Search..."
        txtSearch.Size = New Size(304, 22)
        txtSearch.TabIndex = 13
        ' 
        ' btnSearch4
        ' 
        btnSearch4.BackColor = Color.MediumTurquoise
        btnSearch4.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSearch4.Location = New Point(3, 3)
        btnSearch4.Name = "btnSearch4"
        btnSearch4.Size = New Size(113, 25)
        btnSearch4.TabIndex = 6
        btnSearch4.Text = "Search"
        btnSearch4.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.BackColor = Color.CadetBlue
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 7.490637F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 92.50936F))
        TableLayoutPanel2.Controls.Add(btnSearch4, 0, 0)
        TableLayoutPanel2.Controls.Add(txtSearch, 1, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(3, 0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel2.Size = New Size(1369, 31)
        TableLayoutPanel2.TabIndex = 8
        ' 
        ' frmCategorylist
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CadetBlue
        ClientSize = New Size(1375, 674)
        Controls.Add(TableLayoutPanel1)
        Name = "frmCategorylist"
        Text = "CategoryList"
        CType(dgvCategory, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents dgvCategory As DataGridView
    Friend WithEvents btnArchiveCategory As Button
    Friend WithEvents btnEditCategory As Button
    Friend WithEvents btnAddCategory As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch4 As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
End Class
