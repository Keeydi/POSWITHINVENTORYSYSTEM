<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pending
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
        TableLayoutPanel1 = New TableLayoutPanel()
        Label1 = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        btnback = New Button()
        btnprocess = New Button()
        TableLayoutPanel3 = New TableLayoutPanel()
        lbltotalprice = New Label()
        Label3 = New Label()
        Label2 = New Label()
        ComboBox1 = New ComboBox()
        dgvpending = New DataGridView()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        CType(dgvpending, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Top
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(800, 50)
        TableLayoutPanel1.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(794, 32)
        Label1.TabIndex = 0
        Label1.Text = "Pending Transaction"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 23.89937F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 61.125F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15F))
        TableLayoutPanel2.Controls.Add(btnback, 2, 0)
        TableLayoutPanel2.Controls.Add(btnprocess, 1, 0)
        TableLayoutPanel2.Dock = DockStyle.Bottom
        TableLayoutPanel2.Location = New Point(0, 395)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Size = New Size(800, 55)
        TableLayoutPanel2.TabIndex = 5
        ' 
        ' btnback
        ' 
        btnback.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnback.BackColor = Color.IndianRed
        btnback.Font = New Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnback.Location = New Point(683, 3)
        btnback.Name = "btnback"
        btnback.Size = New Size(114, 49)
        btnback.TabIndex = 16
        btnback.Text = "Cancel"
        btnback.UseVisualStyleBackColor = False
        ' 
        ' btnprocess
        ' 
        btnprocess.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnprocess.BackColor = Color.LightGreen
        btnprocess.Font = New Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnprocess.ForeColor = SystemColors.ControlText
        btnprocess.Location = New Point(568, 3)
        btnprocess.Name = "btnprocess"
        btnprocess.Size = New Size(108, 49)
        btnprocess.TabIndex = 21
        btnprocess.Text = "Process"
        btnprocess.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 4
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.Controls.Add(lbltotalprice, 3, 0)
        TableLayoutPanel3.Controls.Add(Label3, 2, 0)
        TableLayoutPanel3.Controls.Add(Label2, 0, 0)
        TableLayoutPanel3.Controls.Add(ComboBox1, 1, 0)
        TableLayoutPanel3.Dock = DockStyle.Top
        TableLayoutPanel3.Location = New Point(0, 50)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Size = New Size(800, 50)
        TableLayoutPanel3.TabIndex = 6
        ' 
        ' lbltotalprice
        ' 
        lbltotalprice.AutoSize = True
        lbltotalprice.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbltotalprice.Location = New Point(603, 0)
        lbltotalprice.Name = "lbltotalprice"
        lbltotalprice.Size = New Size(58, 32)
        lbltotalprice.TabIndex = 4
        lbltotalprice.Text = "0.00"
        lbltotalprice.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(520, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 32)
        Label3.TabIndex = 3
        Label3.Text = "Total :"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(30, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(167, 32)
        Label2.TabIndex = 1
        Label2.Text = "Transaction # :"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(203, 3)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(194, 38)
        ComboBox1.TabIndex = 0
        ' 
        ' dgvpending
        ' 
        dgvpending.AllowUserToAddRows = False
        dgvpending.AllowUserToDeleteRows = False
        dgvpending.BackgroundColor = SystemColors.ButtonFace
        dgvpending.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvpending.Dock = DockStyle.Fill
        dgvpending.Location = New Point(0, 100)
        dgvpending.Name = "dgvpending"
        dgvpending.ReadOnly = True
        dgvpending.Size = New Size(800, 295)
        dgvpending.TabIndex = 7
        ' 
        ' Pending
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CadetBlue
        ClientSize = New Size(800, 450)
        ControlBox = False
        Controls.Add(dgvpending)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(TableLayoutPanel3)
        Controls.Add(TableLayoutPanel1)
        Name = "Pending"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pending"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        CType(dgvpending, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnback As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvpending As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents lbltotalprice As Label
    Friend WithEvents btnprocess As Button
End Class
