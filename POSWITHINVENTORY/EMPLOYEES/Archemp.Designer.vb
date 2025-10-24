<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Archemp
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
        dgvProducts = New DataGridView()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label1 = New Label()
        btnreplaced = New Button()
        btncancel = New Button()
        CType(dgvProducts, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
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
        dgvProducts.Location = New Point(3, 33)
        dgvProducts.Margin = New Padding(3, 4, 3, 4)
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
        dgvProducts.Size = New Size(1075, 585)
        dgvProducts.TabIndex = 1
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.CadetBlue
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 147F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 131F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 803F))
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Controls.Add(dgvProducts, 0, 1)
        TableLayoutPanel1.Controls.Add(btnreplaced, 0, 2)
        TableLayoutPanel1.Controls.Add(btncancel, 2, 2)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 4.674797F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 95.3252F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 53F))
        TableLayoutPanel1.Size = New Size(1079, 676)
        TableLayoutPanel1.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        TableLayoutPanel1.SetColumnSpan(Label1, 3)
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ImeMode = ImeMode.NoControl
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(251, 29)
        Label1.TabIndex = 0
        Label1.Text = "Employee Archived List"
        ' 
        ' btnreplaced
        ' 
        btnreplaced.BackColor = Color.Cyan
        btnreplaced.Font = New Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnreplaced.Location = New Point(3, 625)
        btnreplaced.Name = "btnreplaced"
        btnreplaced.Size = New Size(141, 48)
        btnreplaced.TabIndex = 7
        btnreplaced.Text = "Restore"
        btnreplaced.UseVisualStyleBackColor = False
        ' 
        ' btncancel
        ' 
        btncancel.Anchor = AnchorStyles.Right
        btncancel.BackColor = Color.IndianRed
        btncancel.Font = New Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btncancel.Location = New Point(948, 626)
        btncancel.Margin = New Padding(3, 4, 3, 4)
        btncancel.Name = "btncancel"
        btncancel.Size = New Size(130, 46)
        btncancel.TabIndex = 22
        btncancel.Text = "Close"
        btncancel.UseVisualStyleBackColor = False
        ' 
        ' Archemp
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1079, 676)
        ControlBox = False
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "Archemp"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Archemp"
        CType(dgvProducts, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnreplaced As Button
    Friend WithEvents btncancel As Button
End Class
