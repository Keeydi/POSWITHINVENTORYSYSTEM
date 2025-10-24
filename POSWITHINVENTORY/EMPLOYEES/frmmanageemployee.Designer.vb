<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmanageemployee
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
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        dgvemployeelist = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        GroupBox2 = New GroupBox()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        TextBox7 = New TextBox()
        Label8 = New Label()
        TextBox6 = New TextBox()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        Label11 = New Label()
        Label9 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Panel1 = New Panel()
        Label3 = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        Label4 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        ComboBox1 = New ComboBox()
        TableLayoutPanel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(dgvemployeelist, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        Panel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 5
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 4.53563738F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.4859619F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 1.94384444F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 60.5831528F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 7.3434124F))
        TableLayoutPanel1.Controls.Add(GroupBox1, 1, 0)
        TableLayoutPanel1.Controls.Add(GroupBox2, 3, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 95.77735F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 4.22264862F))
        TableLayoutPanel1.Size = New Size(966, 493)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(dgvemployeelist)
        GroupBox1.Dock = DockStyle.Fill
        GroupBox1.Location = New Point(46, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(240, 466)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Label1.Location = New Point(6, 6)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 21)
        Label1.TabIndex = 0
        Label1.Text = "EMPLOYEE LIST"
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
        dgvemployeelist.Columns.AddRange(New DataGridViewColumn() {Column1})
        dgvemployeelist.EditMode = DataGridViewEditMode.EditOnEnter
        dgvemployeelist.EnableHeadersVisualStyles = False
        dgvemployeelist.GridColor = Color.White
        dgvemployeelist.ImeMode = ImeMode.NoControl
        dgvemployeelist.Location = New Point(3, 30)
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
        dgvemployeelist.Size = New Size(234, 433)
        dgvemployeelist.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Employee Name"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Button3)
        GroupBox2.Controls.Add(Button2)
        GroupBox2.Controls.Add(Button1)
        GroupBox2.Controls.Add(TextBox7)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(TextBox6)
        GroupBox2.Controls.Add(TextBox5)
        GroupBox2.Controls.Add(TextBox4)
        GroupBox2.Controls.Add(TextBox3)
        GroupBox2.Controls.Add(TextBox2)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Panel1)
        GroupBox2.Controls.Add(TableLayoutPanel2)
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.Location = New Point(310, 3)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(579, 466)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button3.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(358, 315)
        Button3.Name = "Button3"
        Button3.Size = New Size(169, 30)
        Button3.TabIndex = 25
        Button3.Text = "ARCHIVE EMPLOYEE"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Button2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(203, 315)
        Button2.Name = "Button2"
        Button2.Size = New Size(128, 30)
        Button2.TabIndex = 24
        Button2.Text = "EDIT EMPLOYEE"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Button1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(48, 315)
        Button1.Name = "Button1"
        Button1.Size = New Size(128, 30)
        Button1.TabIndex = 23
        Button1.Text = "ADD EMPLOYEE"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(115, 217)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(168, 23)
        TextBox7.TabIndex = 22
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(25, 215)
        Label8.Name = "Label8"
        Label8.Size = New Size(51, 21)
        Label8.TabIndex = 21
        Label8.Text = "Email:"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(405, 172)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(168, 23)
        TextBox6.TabIndex = 20
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(405, 137)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(168, 23)
        TextBox5.TabIndex = 19
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(115, 256)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(458, 23)
        TextBox4.TabIndex = 18
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(115, 176)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(168, 23)
        TextBox3.TabIndex = 17
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(115, 137)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(168, 23)
        TextBox2.TabIndex = 16
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Black
        Label11.Location = New Point(289, 174)
        Label11.Name = "Label11"
        Label11.Size = New Size(108, 21)
        Label11.TabIndex = 11
        Label11.Text = "Marital Status:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(25, 254)
        Label9.Name = "Label9"
        Label9.Size = New Size(69, 21)
        Label9.TabIndex = 7
        Label9.Text = "Address:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(340, 139)
        Label7.Name = "Label7"
        Label7.Size = New Size(57, 21)
        Label7.TabIndex = 5
        Label7.Text = "Phone:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(25, 174)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 21)
        Label6.TabIndex = 4
        Label6.Text = "Gender:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(25, 139)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 21)
        Label5.TabIndex = 3
        Label5.Text = "Full Name:"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(10, 81)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(563, 34)
        Panel1.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(3, 7)
        Label3.Name = "Label3"
        Label3.Size = New Size(194, 21)
        Label3.TabIndex = 2
        Label3.Text = "EMPLOYEE INFORMATION"
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        TableLayoutPanel2.ColumnCount = 4
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 13.6936941F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 41.8018036F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 17.477478F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 27.0270271F))
        TableLayoutPanel2.Controls.Add(Label4, 2, 0)
        TableLayoutPanel2.Controls.Add(Label2, 0, 0)
        TableLayoutPanel2.Controls.Add(TextBox1, 1, 0)
        TableLayoutPanel2.Controls.Add(ComboBox1, 3, 0)
        TableLayoutPanel2.Dock = DockStyle.Top
        TableLayoutPanel2.ForeColor = Color.White
        TableLayoutPanel2.Location = New Point(3, 19)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 36F))
        TableLayoutPanel2.Size = New Size(573, 36)
        TableLayoutPanel2.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(325, 7)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 21)
        Label4.TabIndex = 2
        Label4.Text = "SEARCH BY"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(7, 7)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 21)
        Label2.TabIndex = 0
        Label2.Text = "SEARCH"
        ' 
        ' TextBox1
        ' 
        TextBox1.Dock = DockStyle.Fill
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(81, 3)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(233, 30)
        TextBox1.TabIndex = 3
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Dock = DockStyle.Fill
        ComboBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(420, 3)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(150, 29)
        ComboBox1.TabIndex = 4
        ' 
        ' frmmanageemployee
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(966, 493)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "frmmanageemployee"
        Text = "frmmanageemployee"
        WindowState = FormWindowState.Maximized
        TableLayoutPanel1.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgvemployeelist, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvemployeelist As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label8 As Label
End Class
