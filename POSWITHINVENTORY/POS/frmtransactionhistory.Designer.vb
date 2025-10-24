<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtransactionhistory
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
        Label5 = New Label()
        Txtdate = New TextBox()
        TableLayoutPanel3 = New TableLayoutPanel()
        lbltotal = New Label()
        Label3 = New Label()
        Label2 = New Label()
        ComboBox1 = New ComboBox()
        dgvtransaction = New DataGridView()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        CType(dgvtransaction, ComponentModel.ISupportInitialize).BeginInit()
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
        TableLayoutPanel1.Size = New Size(954, 50)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(948, 32)
        Label1.TabIndex = 0
        Label1.Text = "Transaction History"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 23.89937F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 22.8511524F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 53.1446533F))
        TableLayoutPanel2.Controls.Add(btnback, 2, 0)
        TableLayoutPanel2.Controls.Add(Label5, 0, 0)
        TableLayoutPanel2.Controls.Add(Txtdate, 1, 0)
        TableLayoutPanel2.Dock = DockStyle.Bottom
        TableLayoutPanel2.Location = New Point(0, 489)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(954, 55)
        TableLayoutPanel2.TabIndex = 1
        ' 
        ' btnback
        ' 
        btnback.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnback.BackColor = Color.IndianRed
        btnback.Font = New Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnback.Location = New Point(837, 3)
        btnback.Name = "btnback"
        btnback.Size = New Size(114, 49)
        btnback.TabIndex = 16
        btnback.Text = "Cancel"
        btnback.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Dock = DockStyle.Fill
        Label5.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(3, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(222, 55)
        Label5.TabIndex = 3
        Label5.Text = "Date :"
        Label5.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Txtdate
        ' 
        Txtdate.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Txtdate.Enabled = False
        Txtdate.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txtdate.Location = New Point(231, 10)
        Txtdate.Name = "Txtdate"
        Txtdate.Size = New Size(212, 35)
        Txtdate.TabIndex = 4
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 4
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.Controls.Add(lbltotal, 3, 0)
        TableLayoutPanel3.Controls.Add(Label3, 2, 0)
        TableLayoutPanel3.Controls.Add(Label2, 0, 0)
        TableLayoutPanel3.Controls.Add(ComboBox1, 1, 0)
        TableLayoutPanel3.Dock = DockStyle.Top
        TableLayoutPanel3.Location = New Point(0, 50)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.Size = New Size(954, 50)
        TableLayoutPanel3.TabIndex = 2
        ' 
        ' lbltotal
        ' 
        lbltotal.AutoSize = True
        lbltotal.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbltotal.Location = New Point(717, 0)
        lbltotal.Name = "lbltotal"
        lbltotal.Size = New Size(58, 32)
        lbltotal.TabIndex = 3
        lbltotal.Text = "0.00"
        lbltotal.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(634, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 32)
        Label3.TabIndex = 2
        Label3.Text = "Total :"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(68, 0)
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
        ComboBox1.Location = New Point(241, 3)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(232, 38)
        ComboBox1.TabIndex = 0
        ' 
        ' dgvtransaction
        ' 
        dgvtransaction.AllowUserToAddRows = False
        dgvtransaction.AllowUserToDeleteRows = False
        dgvtransaction.BackgroundColor = SystemColors.ButtonFace
        dgvtransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvtransaction.Dock = DockStyle.Fill
        dgvtransaction.Location = New Point(0, 100)
        dgvtransaction.Name = "dgvtransaction"
        dgvtransaction.ReadOnly = True
        dgvtransaction.Size = New Size(954, 389)
        dgvtransaction.TabIndex = 3
        ' 
        ' frmtransactionhistory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CadetBlue
        ClientSize = New Size(954, 544)
        ControlBox = False
        Controls.Add(dgvtransaction)
        Controls.Add(TableLayoutPanel3)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "frmtransactionhistory"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Transaction History"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        CType(dgvtransaction, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Txtdate As TextBox
    Friend WithEvents lbltotal As Label
    Friend WithEvents btnback As Button
    Friend WithEvents dgvtransaction As DataGridView
End Class
