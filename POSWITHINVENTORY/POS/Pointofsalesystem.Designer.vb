<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pointofsalesystem
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
        components = New ComponentModel.Container()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lbldate = New Label()
        lbltime = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel4 = New TableLayoutPanel()
        lbltransnum = New Label()
        Label13 = New Label()
        lblchange = New Label()
        lblcash = New Label()
        lbltotal = New Label()
        Label9 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        TableLayoutPanel5 = New TableLayoutPanel()
        btnvoidprod = New Button()
        btnpendtrans = New Button()
        btnrestran = New Button()
        btntransachis = New Button()
        btnnewtransac = New Button()
        btnquantity = New Button()
        btnsettlepayment = New Button()
        btnclear = New Button()
        btnlogout = New Button()
        TableLayoutPanel3 = New TableLayoutPanel()
        Label6 = New Label()
        txtxbarcode = New TextBox()
        dgvcart = New DataGridView()
        Timer1 = New Timer(components)
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        CType(dgvcart, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 100F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 88F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 159F))
        TableLayoutPanel1.Controls.Add(Label1, 1, 0)
        TableLayoutPanel1.Controls.Add(Label2, 2, 0)
        TableLayoutPanel1.Controls.Add(Label3, 2, 1)
        TableLayoutPanel1.Controls.Add(lbldate, 3, 0)
        TableLayoutPanel1.Controls.Add(lbltime, 3, 1)
        TableLayoutPanel1.Dock = DockStyle.Top
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50.76923F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 49.23077F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 34F))
        TableLayoutPanel1.Size = New Size(1064, 86)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(103, 19)
        Label1.Name = "Label1"
        TableLayoutPanel1.SetRowSpan(Label1, 3)
        Label1.Size = New Size(392, 47)
        Label1.TabIndex = 0
        Label1.Text = "POINT OF SALE SYSTEM"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(827, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 26)
        Label2.TabIndex = 1
        Label2.Text = "DATE :"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(830, 26)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 25)
        Label3.TabIndex = 2
        Label3.Text = "TIME :"
        ' 
        ' lbldate
        ' 
        lbldate.Anchor = AnchorStyles.Left
        lbldate.AutoSize = True
        lbldate.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbldate.Location = New Point(908, 0)
        lbldate.Name = "lbldate"
        lbldate.Size = New Size(75, 26)
        lbldate.TabIndex = 3
        lbldate.Text = "DATE :"
        ' 
        ' lbltime
        ' 
        lbltime.Anchor = AnchorStyles.Left
        lbltime.AutoSize = True
        lbltime.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbltime.Location = New Point(908, 26)
        lbltime.Name = "lbltime"
        lbltime.Size = New Size(72, 25)
        lbltime.TabIndex = 4
        lbltime.Text = "TIME :"
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Controls.Add(TableLayoutPanel4, 0, 0)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel5, 0, 1)
        TableLayoutPanel2.Dock = DockStyle.Right
        TableLayoutPanel2.Location = New Point(561, 86)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 33.9100342F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 66.0899658F))
        TableLayoutPanel2.Size = New Size(503, 592)
        TableLayoutPanel2.TabIndex = 1
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 2
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Controls.Add(lbltransnum, 1, 0)
        TableLayoutPanel4.Controls.Add(Label13, 0, 0)
        TableLayoutPanel4.Controls.Add(lblchange, 1, 3)
        TableLayoutPanel4.Controls.Add(lblcash, 1, 2)
        TableLayoutPanel4.Controls.Add(lbltotal, 1, 1)
        TableLayoutPanel4.Controls.Add(Label9, 0, 2)
        TableLayoutPanel4.Controls.Add(Label7, 0, 1)
        TableLayoutPanel4.Controls.Add(Label8, 0, 3)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(3, 3)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 4
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel4.Size = New Size(497, 194)
        TableLayoutPanel4.TabIndex = 0
        ' 
        ' lbltransnum
        ' 
        lbltransnum.Anchor = AnchorStyles.Left
        lbltransnum.AutoSize = True
        lbltransnum.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold)
        lbltransnum.Location = New Point(251, 0)
        lbltransnum.Name = "lbltransnum"
        lbltransnum.Size = New Size(239, 48)
        lbltransnum.TabIndex = 9
        lbltransnum.Text = "20250929-160902-278c"
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.Right
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold)
        Label13.Location = New Point(35, 8)
        Label13.Name = "Label13"
        Label13.Size = New Size(210, 32)
        Label13.TabIndex = 8
        Label13.Text = "TRANSACTION # :"
        ' 
        ' lblchange
        ' 
        lblchange.Anchor = AnchorStyles.Left
        lblchange.AutoSize = True
        lblchange.Font = New Font("Segoe UI Black", 24F, FontStyle.Bold)
        lblchange.Location = New Point(251, 146)
        lblchange.Name = "lblchange"
        lblchange.Size = New Size(87, 45)
        lblchange.TabIndex = 7
        lblchange.Text = "0.00"
        ' 
        ' lblcash
        ' 
        lblcash.Anchor = AnchorStyles.Left
        lblcash.AutoSize = True
        lblcash.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold)
        lblcash.Location = New Point(251, 104)
        lblcash.Name = "lblcash"
        lblcash.Size = New Size(59, 32)
        lblcash.TabIndex = 6
        lblcash.Text = "0.00"
        ' 
        ' lbltotal
        ' 
        lbltotal.Anchor = AnchorStyles.Left
        lbltotal.AutoSize = True
        lbltotal.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold)
        lbltotal.Location = New Point(251, 56)
        lbltotal.Name = "lbltotal"
        lbltotal.Size = New Size(59, 32)
        lbltotal.TabIndex = 5
        lbltotal.Text = "0.00"
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold)
        Label9.Location = New Point(156, 104)
        Label9.Name = "Label9"
        Label9.Size = New Size(89, 32)
        Label9.TabIndex = 4
        Label9.Text = "CASH :"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold)
        Label7.Location = New Point(150, 56)
        Label7.Name = "Label7"
        Label7.Size = New Size(95, 32)
        Label7.TabIndex = 2
        Label7.Text = "TOTAL :"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Black", 24F, FontStyle.Bold)
        Label8.Location = New Point(69, 146)
        Label8.Name = "Label8"
        Label8.Size = New Size(176, 45)
        Label8.TabIndex = 3
        Label8.Text = "CHANGE :"
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.ColumnCount = 2
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Controls.Add(btnvoidprod, 0, 3)
        TableLayoutPanel5.Controls.Add(btnpendtrans, 1, 2)
        TableLayoutPanel5.Controls.Add(btnrestran, 0, 2)
        TableLayoutPanel5.Controls.Add(btntransachis, 1, 1)
        TableLayoutPanel5.Controls.Add(btnnewtransac, 0, 1)
        TableLayoutPanel5.Controls.Add(btnquantity, 1, 0)
        TableLayoutPanel5.Controls.Add(btnsettlepayment, 0, 0)
        TableLayoutPanel5.Controls.Add(btnclear, 1, 3)
        TableLayoutPanel5.Controls.Add(btnlogout, 1, 4)
        TableLayoutPanel5.Dock = DockStyle.Fill
        TableLayoutPanel5.Location = New Point(3, 203)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 5
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel5.Size = New Size(497, 386)
        TableLayoutPanel5.TabIndex = 1
        ' 
        ' btnvoidprod
        ' 
        btnvoidprod.BackColor = Color.Khaki
        btnvoidprod.Dock = DockStyle.Fill
        btnvoidprod.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnvoidprod.Location = New Point(3, 234)
        btnvoidprod.Name = "btnvoidprod"
        btnvoidprod.Size = New Size(242, 71)
        btnvoidprod.TabIndex = 6
        btnvoidprod.Text = "VOID PRODUCT"
        btnvoidprod.UseVisualStyleBackColor = False
        ' 
        ' btnpendtrans
        ' 
        btnpendtrans.BackColor = Color.Cyan
        btnpendtrans.Dock = DockStyle.Fill
        btnpendtrans.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnpendtrans.Location = New Point(251, 157)
        btnpendtrans.Name = "btnpendtrans"
        btnpendtrans.Size = New Size(243, 71)
        btnpendtrans.TabIndex = 5
        btnpendtrans.Text = "PENDING TRANSACTION"
        btnpendtrans.UseVisualStyleBackColor = False
        ' 
        ' btnrestran
        ' 
        btnrestran.BackColor = Color.Cyan
        btnrestran.Dock = DockStyle.Fill
        btnrestran.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnrestran.Location = New Point(3, 157)
        btnrestran.Name = "btnrestran"
        btnrestran.Size = New Size(242, 71)
        btnrestran.TabIndex = 4
        btnrestran.Text = "RESERVE TRANSACTION"
        btnrestran.UseVisualStyleBackColor = False
        ' 
        ' btntransachis
        ' 
        btntransachis.BackColor = Color.LightGreen
        btntransachis.Dock = DockStyle.Fill
        btntransachis.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btntransachis.Location = New Point(251, 80)
        btntransachis.Name = "btntransachis"
        btntransachis.Size = New Size(243, 71)
        btntransachis.TabIndex = 3
        btntransachis.Text = "TRANSACTION HISTORY"
        btntransachis.UseVisualStyleBackColor = False
        ' 
        ' btnnewtransac
        ' 
        btnnewtransac.BackColor = Color.LightGreen
        btnnewtransac.Dock = DockStyle.Fill
        btnnewtransac.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnnewtransac.Location = New Point(3, 80)
        btnnewtransac.Name = "btnnewtransac"
        btnnewtransac.Size = New Size(242, 71)
        btnnewtransac.TabIndex = 2
        btnnewtransac.Text = "NEW TRANSACTION"
        btnnewtransac.UseVisualStyleBackColor = False
        ' 
        ' btnquantity
        ' 
        btnquantity.BackColor = Color.LightGreen
        btnquantity.Dock = DockStyle.Fill
        btnquantity.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnquantity.Location = New Point(251, 3)
        btnquantity.Name = "btnquantity"
        btnquantity.Size = New Size(243, 71)
        btnquantity.TabIndex = 1
        btnquantity.Text = "EDIT QUANTITY"
        btnquantity.UseVisualStyleBackColor = False
        ' 
        ' btnsettlepayment
        ' 
        btnsettlepayment.BackColor = Color.LightGreen
        btnsettlepayment.Dock = DockStyle.Fill
        btnsettlepayment.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnsettlepayment.Location = New Point(3, 3)
        btnsettlepayment.Name = "btnsettlepayment"
        btnsettlepayment.Size = New Size(242, 71)
        btnsettlepayment.TabIndex = 0
        btnsettlepayment.Text = "SETTLE PAYMENT"
        btnsettlepayment.UseVisualStyleBackColor = False
        ' 
        ' btnclear
        ' 
        btnclear.BackColor = Color.Khaki
        btnclear.Dock = DockStyle.Fill
        btnclear.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnclear.Location = New Point(251, 234)
        btnclear.Name = "btnclear"
        btnclear.Size = New Size(243, 71)
        btnclear.TabIndex = 9
        btnclear.Text = "CLEAR"
        btnclear.UseVisualStyleBackColor = False
        ' 
        ' btnlogout
        ' 
        btnlogout.BackColor = Color.Khaki
        btnlogout.Dock = DockStyle.Fill
        btnlogout.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnlogout.Location = New Point(251, 311)
        btnlogout.Name = "btnlogout"
        btnlogout.Size = New Size(243, 72)
        btnlogout.TabIndex = 7
        btnlogout.Text = "EXIT"
        btnlogout.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 200F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Controls.Add(Label6, 0, 0)
        TableLayoutPanel3.Controls.Add(txtxbarcode, 1, 0)
        TableLayoutPanel3.Dock = DockStyle.Top
        TableLayoutPanel3.Location = New Point(0, 86)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Size = New Size(561, 47)
        TableLayoutPanel3.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(16, 8)
        Label6.Name = "Label6"
        Label6.Size = New Size(181, 30)
        Label6.TabIndex = 2
        Label6.Text = "PRODUCT CODE :"
        ' 
        ' txtxbarcode
        ' 
        txtxbarcode.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtxbarcode.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtxbarcode.Location = New Point(203, 7)
        txtxbarcode.Name = "txtxbarcode"
        txtxbarcode.Size = New Size(355, 33)
        txtxbarcode.TabIndex = 3
        ' 
        ' dgvcart
        ' 
        dgvcart.AllowUserToAddRows = False
        dgvcart.AllowUserToDeleteRows = False
        dgvcart.BackgroundColor = SystemColors.ButtonHighlight
        dgvcart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvcart.Dock = DockStyle.Fill
        dgvcart.Location = New Point(0, 133)
        dgvcart.Name = "dgvcart"
        dgvcart.ReadOnly = True
        dgvcart.Size = New Size(561, 579)
        dgvcart.TabIndex = 3
        ' 
        ' Timer1
        ' 
        ' 
        ' Pointofsalesystem
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CadetBlue
        ClientSize = New Size(1064, 678)
        ControlBox = False
        Controls.Add(dgvcart)
        Controls.Add(TableLayoutPanel3)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(TableLayoutPanel1)
        Name = "Pointofsalesystem"
        StartPosition = FormStartPosition.CenterScreen
        WindowState = FormWindowState.Maximized
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        CType(dgvcart, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents dgvcart As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents lbldate As Label
    Friend WithEvents lbltime As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtxbarcode As TextBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents lblchange As Label
    Friend WithEvents lblcash As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbltransnum As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents btnsettlepayment As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents btnvoidprod As Button
    Friend WithEvents btnpendtrans As Button
    Friend WithEvents btnrestran As Button
    Friend WithEvents btntransachis As Button
    Friend WithEvents btnnewtransac As Button
    Friend WithEvents btnquantity As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnclear As Button
End Class
