<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmarchiveemployees
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
        Label15 = New Label()
        Label16 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label9 = New Label()
        Label8 = New Label()
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
        btnRestore = New Button()
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
        TableLayoutPanel1.Controls.Add(btnRestore, 1, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 92.6691742F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 7.330827F))
        TableLayoutPanel1.Size = New Size(1086, 709)
        TableLayoutPanel1.TabIndex = 2
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(dgvemployeelist)
        GroupBox1.Dock = DockStyle.Fill
        GroupBox1.Location = New Point(52, 4)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(271, 649)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Label1.Location = New Point(0, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(152, 28)
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
        dgvemployeelist.Location = New Point(3, 40)
        dgvemployeelist.Margin = New Padding(3, 4, 3, 4)
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
        dgvemployeelist.Size = New Size(263, 620)
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
        GroupBox2.Controls.Add(Label15)
        GroupBox2.Controls.Add(Label16)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Controls.Add(Label13)
        GroupBox2.Controls.Add(Label14)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Panel1)
        GroupBox2.Controls.Add(TableLayoutPanel2)
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.Location = New Point(350, 4)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 4, 3, 4)
        GroupBox2.Size = New Size(652, 649)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.Black
        Label15.Location = New Point(242, 425)
        Label15.Name = "Label15"
        Label15.Size = New Size(86, 28)
        Label15.TabIndex = 24
        Label15.Text = "Address:"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = Color.Black
        Label16.Location = New Point(27, 425)
        Label16.Name = "Label16"
        Label16.Size = New Size(86, 28)
        Label16.TabIndex = 23
        Label16.Text = "Address:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(242, 371)
        Label10.Name = "Label10"
        Label10.Size = New Size(63, 28)
        Label10.TabIndex = 22
        Label10.Text = "Email:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Black
        Label11.Location = New Point(242, 323)
        Label11.Name = "Label11"
        Label11.Size = New Size(136, 28)
        Label11.TabIndex = 21
        Label11.Text = "Marital Status:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.Black
        Label12.Location = New Point(242, 271)
        Label12.Name = "Label12"
        Label12.Size = New Size(71, 28)
        Label12.TabIndex = 20
        Label12.Text = "Phone:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.Black
        Label13.Location = New Point(242, 221)
        Label13.Name = "Label13"
        Label13.Size = New Size(80, 28)
        Label13.TabIndex = 19
        Label13.Text = "Gender:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.Black
        Label14.Location = New Point(242, 175)
        Label14.Name = "Label14"
        Label14.Size = New Size(104, 28)
        Label14.TabIndex = 18
        Label14.Text = "Full Name:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(27, 371)
        Label9.Name = "Label9"
        Label9.Size = New Size(63, 28)
        Label9.TabIndex = 17
        Label9.Text = "Email:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(27, 323)
        Label8.Name = "Label8"
        Label8.Size = New Size(136, 28)
        Label8.TabIndex = 16
        Label8.Text = "Marital Status:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(27, 271)
        Label7.Name = "Label7"
        Label7.Size = New Size(71, 28)
        Label7.TabIndex = 15
        Label7.Text = "Phone:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(27, 221)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 28)
        Label6.TabIndex = 14
        Label6.Text = "Gender:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(27, 175)
        Label5.Name = "Label5"
        Label5.Size = New Size(104, 28)
        Label5.TabIndex = 13
        Label5.Text = "Full Name:"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(11, 108)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(643, 45)
        Panel1.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(3, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(242, 28)
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
        TableLayoutPanel2.Location = New Point(3, 24)
        TableLayoutPanel2.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 48F))
        TableLayoutPanel2.Size = New Size(646, 48)
        TableLayoutPanel2.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(378, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 48)
        Label4.TabIndex = 2
        Label4.Text = "SEARCH BY"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(15, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 48)
        Label2.TabIndex = 0
        Label2.Text = "SEARCH"
        ' 
        ' TextBox1
        ' 
        TextBox1.Dock = DockStyle.Fill
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(91, 4)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(264, 40)
        TextBox1.TabIndex = 3
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Dock = DockStyle.Fill
        ComboBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Fullname", "Gender", "Address"})
        ComboBox1.Location = New Point(473, 4)
        ComboBox1.Margin = New Padding(3, 4, 3, 4)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(170, 36)
        ComboBox1.TabIndex = 4
        ' 
        ' btnRestore
        ' 
        btnRestore.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnRestore.Dock = DockStyle.Fill
        btnRestore.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRestore.Location = New Point(52, 661)
        btnRestore.Margin = New Padding(3, 4, 3, 4)
        btnRestore.Name = "btnRestore"
        btnRestore.Size = New Size(271, 44)
        btnRestore.TabIndex = 3
        btnRestore.Text = "RESTORE EMPLOYEE"
        btnRestore.UseVisualStyleBackColor = False
        ' 
        ' frmarchiveemployees
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1086, 709)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmarchiveemployees"
        Text = "frmarchiveemployees"
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnRestore As Button
End Class
