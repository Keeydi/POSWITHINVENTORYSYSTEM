<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmALLUSERSLIST
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmALLUSERSLIST))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        TableLayoutPanel1 = New TableLayoutPanel()
        dgvemployeelist = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        TableLayoutPanel1.SuspendLayout()
        CType(dgvemployeelist, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.Silver
        resources.ApplyResources(TableLayoutPanel1, "TableLayoutPanel1")
        TableLayoutPanel1.Controls.Add(dgvemployeelist, 0, 1)
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        ' 
        ' dgvemployeelist
        ' 
        dgvemployeelist.AllowUserToAddRows = False
        dgvemployeelist.AllowUserToDeleteRows = False
        dgvemployeelist.AllowUserToResizeColumns = False
        dgvemployeelist.AllowUserToResizeRows = False
        dgvemployeelist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvemployeelist.BackgroundColor = Color.White
        dgvemployeelist.BorderStyle = BorderStyle.None
        dgvemployeelist.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvemployeelist.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvemployeelist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvemployeelist.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        resources.ApplyResources(dgvemployeelist, "dgvemployeelist")
        dgvemployeelist.EditMode = DataGridViewEditMode.EditOnEnter
        dgvemployeelist.EnableHeadersVisualStyles = False
        dgvemployeelist.GridColor = Color.White
        dgvemployeelist.Name = "dgvemployeelist"
        dgvemployeelist.ReadOnly = True
        dgvemployeelist.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvemployeelist.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvemployeelist.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        dgvemployeelist.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        ' 
        ' Column1
        ' 
        resources.ApplyResources(Column1, "Column1")
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        resources.ApplyResources(Column2, "Column2")
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        resources.ApplyResources(Column3, "Column3")
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        resources.ApplyResources(Column4, "Column4")
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column5
        ' 
        resources.ApplyResources(Column5, "Column5")
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' Label1
        ' 
        resources.ApplyResources(Label1, "Label1")
        Label1.Name = "Label1"
        ' 
        ' frmALLUSERSLIST
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Name = "frmALLUSERSLIST"
        WindowState = FormWindowState.Maximized
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(dgvemployeelist, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dgvemployeelist As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
