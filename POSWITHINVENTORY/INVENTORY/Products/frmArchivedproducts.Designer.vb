<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArchives
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
        dgvArchivedProducts = New DataGridView()
        btnRestore = New Button()
        btnPermanentDelete = New Button()
        btnSearch = New Button()
        cmbfilter = New ComboBox()
        txtSearch2 = New TextBox()
        Panel1 = New Panel()
        TableLayoutPanel1.SuspendLayout()
        CType(dgvArchivedProducts, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.CadetBlue
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 129F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 115F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 26F))
        TableLayoutPanel1.Controls.Add(Panel1, 0, 0)
        TableLayoutPanel1.Controls.Add(dgvArchivedProducts, 0, 1)
        TableLayoutPanel1.Controls.Add(btnRestore, 0, 2)
        TableLayoutPanel1.Controls.Add(btnPermanentDelete, 1, 2)
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
        ' dgvArchivedProducts
        ' 
        dgvArchivedProducts.AllowUserToAddRows = False
        dgvArchivedProducts.AllowUserToDeleteRows = False
        dgvArchivedProducts.AllowUserToResizeColumns = False
        dgvArchivedProducts.AllowUserToResizeRows = False
        dgvArchivedProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvArchivedProducts.BackgroundColor = Color.White
        dgvArchivedProducts.BorderStyle = BorderStyle.None
        dgvArchivedProducts.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvArchivedProducts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvArchivedProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        TableLayoutPanel1.SetColumnSpan(dgvArchivedProducts, 3)
        dgvArchivedProducts.Dock = DockStyle.Fill
        dgvArchivedProducts.EditMode = DataGridViewEditMode.EditOnEnter
        dgvArchivedProducts.EnableHeadersVisualStyles = False
        dgvArchivedProducts.GridColor = Color.White
        dgvArchivedProducts.ImeMode = ImeMode.NoControl
        dgvArchivedProducts.Location = New Point(3, 31)
        dgvArchivedProducts.Name = "dgvArchivedProducts"
        dgvArchivedProducts.ReadOnly = True
        dgvArchivedProducts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvArchivedProducts.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvArchivedProducts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        dgvArchivedProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvArchivedProducts.Size = New Size(1369, 579)
        dgvArchivedProducts.TabIndex = 1
        ' 
        ' btnRestore
        ' 
        btnRestore.BackColor = Color.LightGreen
        btnRestore.Font = New Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRestore.Location = New Point(3, 615)
        btnRestore.Margin = New Padding(3, 2, 3, 2)
        btnRestore.Name = "btnRestore"
        btnRestore.Size = New Size(123, 36)
        btnRestore.TabIndex = 7
        btnRestore.Text = "Restore"
        btnRestore.UseVisualStyleBackColor = False
        ' 
        ' btnPermanentDelete
        ' 
        btnPermanentDelete.BackColor = Color.IndianRed
        btnPermanentDelete.Font = New Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPermanentDelete.Location = New Point(132, 615)
        btnPermanentDelete.Margin = New Padding(3, 2, 3, 2)
        btnPermanentDelete.Name = "btnPermanentDelete"
        btnPermanentDelete.Size = New Size(109, 36)
        btnPermanentDelete.TabIndex = 8
        btnPermanentDelete.Text = "Delete"
        btnPermanentDelete.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.MediumTurquoise
        btnSearch.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSearch.Location = New Point(3, 3)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(98, 25)
        btnSearch.TabIndex = 5
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' cmbfilter
        ' 
        cmbfilter.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbfilter.FormattingEnabled = True
        cmbfilter.Location = New Point(1068, 6)
        cmbfilter.Name = "cmbfilter"
        cmbfilter.Size = New Size(304, 36)
        cmbfilter.TabIndex = 6
        ' 
        ' txtSearch2
        ' 
        txtSearch2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch2.Location = New Point(107, 8)
        txtSearch2.Name = "txtSearch2"
        txtSearch2.PlaceholderText = "Type to Search...."
        txtSearch2.Size = New Size(445, 25)
        txtSearch2.TabIndex = 7
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(cmbfilter)
        Panel1.Controls.Add(txtSearch2)
        Panel1.Controls.Add(btnSearch)
        Panel1.Location = New Point(3, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1369, 31)
        Panel1.TabIndex = 8
        ' 
        ' frmArchives
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CadetBlue
        ClientSize = New Size(1375, 674)
        Controls.Add(TableLayoutPanel1)
        Name = "frmArchives"
        Text = "Archives"
        TableLayoutPanel1.ResumeLayout(False)
        CType(dgvArchivedProducts, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents dgvArchivedProducts As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents btnRestore As Button
    Friend WithEvents btnPermanentDelete As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents cmbfilter As ComboBox
    Friend WithEvents txtSearch2 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
