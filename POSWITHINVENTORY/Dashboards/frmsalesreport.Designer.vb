<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsalesreport
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
        dtpto = New DateTimePicker()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txttotalsales = New TextBox()
        dtpfrom = New DateTimePicker()
        TableLayoutPanel2 = New TableLayoutPanel()
        btnprint = New Button()
        btnback = New Button()
        dgvsalesreport = New DataGridView()
        TableLayoutPanel3 = New TableLayoutPanel()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        CType(dgvsalesreport, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 19.875F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30.28169F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 24.7484913F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.Controls.Add(dtpto, 3, 1)
        TableLayoutPanel1.Controls.Add(Label3, 2, 1)
        TableLayoutPanel1.Controls.Add(Label2, 2, 0)
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Controls.Add(txttotalsales, 1, 0)
        TableLayoutPanel1.Controls.Add(dtpfrom, 3, 0)
        TableLayoutPanel1.Dock = DockStyle.Top
        TableLayoutPanel1.Location = New Point(0, 51)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(994, 100)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' dtpto
        ' 
        dtpto.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        dtpto.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpto.Format = DateTimePickerFormat.Short
        dtpto.Location = New Point(747, 57)
        dtpto.Name = "dtpto"
        dtpto.Size = New Size(244, 35)
        dtpto.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(501, 52)
        Label3.Name = "Label3"
        Label3.Size = New Size(240, 45)
        Label3.TabIndex = 3
        Label3.Text = "To :"
        Label3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(501, 2)
        Label2.Name = "Label2"
        Label2.Size = New Size(240, 45)
        Label2.TabIndex = 2
        Label2.Text = "From :"
        Label2.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 27)
        Label1.Name = "Label1"
        TableLayoutPanel1.SetRowSpan(Label1, 2)
        Label1.Size = New Size(191, 45)
        Label1.TabIndex = 0
        Label1.Text = "Total :"
        Label1.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' txttotalsales
        ' 
        txttotalsales.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txttotalsales.Font = New Font("Segoe UI Semibold", 24F, FontStyle.Bold)
        txttotalsales.Location = New Point(200, 25)
        txttotalsales.Name = "txttotalsales"
        TableLayoutPanel1.SetRowSpan(txttotalsales, 2)
        txttotalsales.Size = New Size(295, 50)
        txttotalsales.TabIndex = 1
        ' 
        ' dtpfrom
        ' 
        dtpfrom.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        dtpfrom.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpfrom.Format = DateTimePickerFormat.Short
        dtpfrom.Location = New Point(747, 7)
        dtpfrom.Name = "dtpfrom"
        dtpfrom.Size = New Size(244, 35)
        dtpfrom.TabIndex = 4
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 88.12877F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 11.8712273F))
        TableLayoutPanel2.Controls.Add(btnprint, 1, 0)
        TableLayoutPanel2.Controls.Add(btnback, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Bottom
        TableLayoutPanel2.Location = New Point(0, 505)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Size = New Size(994, 67)
        TableLayoutPanel2.TabIndex = 1
        ' 
        ' btnprint
        ' 
        btnprint.Anchor = AnchorStyles.Right
        btnprint.BackColor = Color.LightGreen
        btnprint.Font = New Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnprint.ForeColor = SystemColors.ControlText
        btnprint.Location = New Point(883, 3)
        btnprint.Name = "btnprint"
        btnprint.Size = New Size(108, 61)
        btnprint.TabIndex = 22
        btnprint.Text = "Print"
        btnprint.UseVisualStyleBackColor = False
        ' 
        ' btnback
        ' 
        btnback.BackColor = Color.IndianRed
        btnback.Font = New Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnback.Location = New Point(3, 3)
        btnback.Name = "btnback"
        btnback.Size = New Size(112, 61)
        btnback.TabIndex = 23
        btnback.Text = "Close"
        btnback.UseVisualStyleBackColor = False
        btnback.Visible = False
        ' 
        ' dgvsalesreport
        ' 
        dgvsalesreport.AllowUserToAddRows = False
        dgvsalesreport.AllowUserToDeleteRows = False
        dgvsalesreport.BackgroundColor = SystemColors.ButtonFace
        dgvsalesreport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvsalesreport.Dock = DockStyle.Fill
        dgvsalesreport.Location = New Point(0, 151)
        dgvsalesreport.Name = "dgvsalesreport"
        dgvsalesreport.ReadOnly = True
        dgvsalesreport.Size = New Size(994, 354)
        dgvsalesreport.TabIndex = 2
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 9.45674F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 90.54326F))
        TableLayoutPanel3.Controls.Add(Label4, 1, 0)
        TableLayoutPanel3.Controls.Add(PictureBox1, 0, 0)
        TableLayoutPanel3.Dock = DockStyle.Top
        TableLayoutPanel3.Location = New Point(0, 0)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.Size = New Size(994, 51)
        TableLayoutPanel3.TabIndex = 3
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = My.Resources.Resources.dashboard_report_icon
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(88, 45)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(97, 3)
        Label4.Name = "Label4"
        Label4.Size = New Size(894, 45)
        Label4.TabIndex = 1
        Label4.Text = "Sales Report"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' frmSalesReport
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CadetBlue
        ClientSize = New Size(994, 572)
        ControlBox = False
        Controls.Add(dgvsalesreport)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(TableLayoutPanel3)
        Name = "frmSalesReport"
        Text = "SALES REPORT"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        CType(dgvsalesreport, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txttotalsales As TextBox
    Friend WithEvents dtpto As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpfrom As DateTimePicker
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnback As Button
    Friend WithEvents btnprint As Button
    Friend WithEvents dgvsalesreport As DataGridView
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
End Class
