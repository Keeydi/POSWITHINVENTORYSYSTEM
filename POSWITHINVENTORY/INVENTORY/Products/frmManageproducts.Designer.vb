<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageproducts
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
        TableLayoutPanel3 = New TableLayoutPanel()
        TableLayoutPanel4 = New TableLayoutPanel()
        Label4 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        ComboBox1 = New ComboBox()
        GroupBox1 = New GroupBox()
        TextBox6 = New TextBox()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Panel1 = New Panel()
        Label3 = New Label()
        TableLayoutPanel5 = New TableLayoutPanel()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        TableLayoutPanel2 = New TableLayoutPanel()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30.12959F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 69.87041F))
        TableLayoutPanel1.Controls.Add(TableLayoutPanel3, 1, 0)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(942, 529)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Controls.Add(TableLayoutPanel4, 0, 0)
        TableLayoutPanel3.Controls.Add(GroupBox1, 0, 1)
        TableLayoutPanel3.Controls.Add(TableLayoutPanel5, 0, 2)
        TableLayoutPanel3.Location = New Point(286, 3)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 3
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 7.94573641F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 82.558136F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 9.689922F))
        TableLayoutPanel3.Size = New Size(641, 516)
        TableLayoutPanel3.TabIndex = 1
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        TableLayoutPanel4.ColumnCount = 4
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 13.6936941F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 41.8018036F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 17.477478F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 27.0270271F))
        TableLayoutPanel4.Controls.Add(Label4, 2, 0)
        TableLayoutPanel4.Controls.Add(Label2, 0, 0)
        TableLayoutPanel4.Controls.Add(TextBox1, 1, 0)
        TableLayoutPanel4.Controls.Add(ComboBox1, 3, 0)
        TableLayoutPanel4.Dock = DockStyle.Top
        TableLayoutPanel4.ForeColor = Color.White
        TableLayoutPanel4.Location = New Point(3, 3)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 1
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Absolute, 34F))
        TableLayoutPanel4.Size = New Size(635, 34)
        TableLayoutPanel4.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(369, 6)
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
        Label2.Location = New Point(15, 6)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 21)
        Label2.TabIndex = 0
        Label2.Text = "SEARCH"
        ' 
        ' TextBox1
        ' 
        TextBox1.Dock = DockStyle.Fill
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(89, 3)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(259, 28)
        TextBox1.TabIndex = 3
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Dock = DockStyle.Fill
        ComboBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Fullname", "Gender", "Address"})
        ComboBox1.Location = New Point(464, 3)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(168, 29)
        ComboBox1.TabIndex = 4
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox6)
        GroupBox1.Controls.Add(TextBox5)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Panel1)
        GroupBox1.Dock = DockStyle.Fill
        GroupBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(3, 43)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(635, 419)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(261, 227)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(218, 29)
        TextBox6.TabIndex = 35
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(261, 177)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(218, 29)
        TextBox5.TabIndex = 34
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(261, 275)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(329, 29)
        TextBox4.TabIndex = 33
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(261, 128)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(218, 29)
        TextBox3.TabIndex = 32
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(261, 82)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(218, 29)
        TextBox2.TabIndex = 31
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(41, 230)
        Label9.Name = "Label9"
        Label9.Size = New Size(47, 21)
        Label9.TabIndex = 30
        Label9.Text = "Price:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(41, 180)
        Label8.Name = "Label8"
        Label8.Size = New Size(57, 21)
        Label8.TabIndex = 29
        Label8.Text = "Stocks:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(41, 278)
        Label7.Name = "Label7"
        Label7.Size = New Size(92, 21)
        Label7.TabIndex = 28
        Label7.Text = "Description:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(41, 131)
        Label6.Name = "Label6"
        Label6.Size = New Size(113, 21)
        Label6.TabIndex = 27
        Label6.Text = "Product Name:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(41, 85)
        Label5.Name = "Label5"
        Label5.Size = New Size(107, 21)
        Label5.TabIndex = 26
        Label5.Text = "Product Code:"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(27, 35)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(563, 34)
        Panel1.TabIndex = 25
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(3, 7)
        Label3.Name = "Label3"
        Label3.Size = New Size(190, 21)
        Label3.TabIndex = 2
        Label3.Text = "PRODUCT INFORMATION"
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.ColumnCount = 3
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel5.Controls.Add(Button3, 2, 0)
        TableLayoutPanel5.Controls.Add(Button2, 1, 0)
        TableLayoutPanel5.Controls.Add(Button1, 0, 0)
        TableLayoutPanel5.Dock = DockStyle.Fill
        TableLayoutPanel5.Location = New Point(3, 468)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 1
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel5.Size = New Size(635, 45)
        TableLayoutPanel5.TabIndex = 4
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button3.Dock = DockStyle.Fill
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(425, 3)
        Button3.Name = "Button3"
        Button3.Size = New Size(207, 39)
        Button3.TabIndex = 31
        Button3.Text = "ARCHIVE PRODUCT"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Button2.Dock = DockStyle.Fill
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(214, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(205, 39)
        Button2.TabIndex = 30
        Button2.Text = "EDIT PRODUCT"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Button1.Dock = DockStyle.Fill
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(3, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(205, 39)
        Button1.TabIndex = 29
        Button1.Text = "ADD PRODUCT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(Label1, 0, 0)
        TableLayoutPanel2.Controls.Add(DataGridView1, 0, 1)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(3, 3)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 4.06976748F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 95.93023F))
        TableLayoutPanel2.Size = New Size(277, 523)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 21)
        Label1.TabIndex = 0
        Label1.Text = "PRODUCT LIST"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1})
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(3, 24)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(271, 496)
        DataGridView1.TabIndex = 1
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Product Name"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        ' 
        ' frmManageproducts
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(942, 529)
        Controls.Add(TableLayoutPanel1)
        Name = "frmManageproducts"
        Text = "frmManageproducts"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
