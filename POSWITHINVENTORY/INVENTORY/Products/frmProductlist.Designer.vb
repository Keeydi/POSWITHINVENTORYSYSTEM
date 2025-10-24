<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductlist
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
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        TableLayoutPanel1 = New TableLayoutPanel()
        dgvProducts = New DataGridView()
        Label1 = New Label()
        btnAdd = New Button()
        btnEdit = New Button()
        btnArchive = New Button()
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
        TableLayoutPanel1.Controls.Add(btnArchive, 2, 2)
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
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Control
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = Color.Black
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        DataGridViewCellStyle5.SelectionForeColor = Color.White
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        dgvProducts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
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
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Control
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgvProducts.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        dgvProducts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProducts.Size = New Size(1369, 579)
        dgvProducts.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        TableLayoutPanel1.SetColumnSpan(Label1, 2)
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ImeMode = ImeMode.NoControl
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(163, 25)
        Label1.TabIndex = 0
        Label1.Text = "PRODUCT LIST"
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
        btnAdd.Text = "Add Product"
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
        btnEdit.Text = "Edit Product"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnArchive
        ' 
        btnArchive.BackColor = Color.Khaki
        btnArchive.Font = New Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnArchive.Location = New Point(247, 615)
        btnArchive.Margin = New Padding(3, 2, 3, 2)
        btnArchive.Name = "btnArchive"
        btnArchive.Size = New Size(146, 36)
        btnArchive.TabIndex = 9
        btnArchive.Text = "Archive"
        btnArchive.UseVisualStyleBackColor = False
        ' 
        ' frmProductlist
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1375, 674)
        Controls.Add(TableLayoutPanel1)
        Name = "frmProductlist"
        Text = "frmProductlist"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(dgvProducts, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnArchive As Button
End Class
