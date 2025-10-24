<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Defects
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
        btnReturned = New Button()
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
        dgvProducts.Size = New Size(941, 619)
        dgvProducts.TabIndex = 1
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
        TableLayoutPanel1.Controls.Add(btnreplaced, 0, 2)
        TableLayoutPanel1.Controls.Add(btnReturned, 1, 2)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 4.674797F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 95.3252F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 40F))
        TableLayoutPanel1.Size = New Size(947, 696)
        TableLayoutPanel1.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        TableLayoutPanel1.SetColumnSpan(Label1, 3)
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ImeMode = ImeMode.NoControl
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 25)
        Label1.TabIndex = 0
        Label1.Text = "Defects"
        ' 
        ' btnreplaced
        ' 
        btnreplaced.BackColor = Color.Cyan
        btnreplaced.Font = New Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnreplaced.Location = New Point(3, 657)
        btnreplaced.Margin = New Padding(3, 2, 3, 2)
        btnreplaced.Name = "btnreplaced"
        btnreplaced.Size = New Size(123, 37)
        btnreplaced.TabIndex = 7
        btnreplaced.Text = "Replaced"
        btnreplaced.UseVisualStyleBackColor = False
        ' 
        ' btnReturned
        ' 
        btnReturned.BackColor = Color.LightGreen
        btnReturned.Font = New Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnReturned.Location = New Point(132, 657)
        btnReturned.Margin = New Padding(3, 2, 3, 2)
        btnReturned.Name = "btnReturned"
        btnReturned.Size = New Size(109, 37)
        btnReturned.TabIndex = 8
        btnReturned.Text = "Returned"
        btnReturned.UseVisualStyleBackColor = False
        btnReturned.Visible = False
        ' 
        ' Defects
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CadetBlue
        ClientSize = New Size(947, 696)
        Controls.Add(TableLayoutPanel1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Defects"
        Text = "Defects"
        CType(dgvProducts, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnreplaced As Button
    Friend WithEvents btnReturned As Button
End Class
