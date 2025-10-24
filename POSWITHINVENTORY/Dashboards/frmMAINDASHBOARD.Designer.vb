<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMAINDASHBOARD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMAINDASHBOARD))
        Panel1 = New Panel()
        TableLayoutPanel12 = New TableLayoutPanel()
        Label2 = New Label()
        lbltime = New Label()
        lbldate = New Label()
        Label3 = New Label()
        PictureBox6 = New PictureBox()
        Label1 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        GroupBox6 = New GroupBox()
        TableLayoutPanel13 = New TableLayoutPanel()
        dgvlow = New DataGridView()
        GroupBox5 = New GroupBox()
        TableLayoutPanel11 = New TableLayoutPanel()
        lblLowStocks = New Label()
        PictureBox5 = New PictureBox()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        GroupBox1 = New GroupBox()
        TableLayoutPanel6 = New TableLayoutPanel()
        lbltotalsalestoday = New Label()
        PictureBox1 = New PictureBox()
        btnTotalSales = New Button()
        TableLayoutPanel4 = New TableLayoutPanel()
        btnTotalStock = New Button()
        GroupBox2 = New GroupBox()
        TableLayoutPanel5 = New TableLayoutPanel()
        lbltotalstockintoday = New Label()
        PictureBox2 = New PictureBox()
        TableLayoutPanel7 = New TableLayoutPanel()
        GroupBox7 = New GroupBox()
        TableLayoutPanel9 = New TableLayoutPanel()
        lblEmployees = New Label()
        PictureBox7 = New PictureBox()
        btnTotalEmployees = New Button()
        TableLayoutPanel8 = New TableLayoutPanel()
        GroupBox8 = New GroupBox()
        TableLayoutPanel10 = New TableLayoutPanel()
        lblbestsellingproduct = New Label()
        PictureBox8 = New PictureBox()
        btnBestSelling = New Button()
        Timer1 = New Timer(components)
        dgvout = New DataGridView()
        TableLayoutPanel14 = New TableLayoutPanel()
        TableLayoutPanel15 = New TableLayoutPanel()
        PictureBox3 = New PictureBox()
        Label4 = New Label()
        Panel1.SuspendLayout()
        TableLayoutPanel12.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        GroupBox6.SuspendLayout()
        TableLayoutPanel13.SuspendLayout()
        CType(dgvlow, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox5.SuspendLayout()
        TableLayoutPanel11.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        GroupBox1.SuspendLayout()
        TableLayoutPanel6.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel4.SuspendLayout()
        GroupBox2.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel7.SuspendLayout()
        GroupBox7.SuspendLayout()
        TableLayoutPanel9.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel8.SuspendLayout()
        GroupBox8.SuspendLayout()
        TableLayoutPanel10.SuspendLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvout, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel14.SuspendLayout()
        TableLayoutPanel15.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.CadetBlue
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(TableLayoutPanel12)
        Panel1.Controls.Add(PictureBox6)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1106, 98)
        Panel1.TabIndex = 1
        ' 
        ' TableLayoutPanel12
        ' 
        TableLayoutPanel12.ColumnCount = 2
        TableLayoutPanel12.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel12.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel12.Controls.Add(Label2, 0, 0)
        TableLayoutPanel12.Controls.Add(lbltime, 1, 1)
        TableLayoutPanel12.Controls.Add(lbldate, 1, 0)
        TableLayoutPanel12.Controls.Add(Label3, 0, 1)
        TableLayoutPanel12.Dock = DockStyle.Right
        TableLayoutPanel12.Location = New Point(725, 0)
        TableLayoutPanel12.Name = "TableLayoutPanel12"
        TableLayoutPanel12.RowCount = 2
        TableLayoutPanel12.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel12.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel12.Size = New Size(379, 96)
        TableLayoutPanel12.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(111, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 30)
        Label2.TabIndex = 5
        Label2.Text = "DATE :"
        ' 
        ' lbltime
        ' 
        lbltime.Anchor = AnchorStyles.Left
        lbltime.AutoSize = True
        lbltime.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbltime.Location = New Point(192, 57)
        lbltime.Name = "lbltime"
        lbltime.Size = New Size(72, 30)
        lbltime.TabIndex = 8
        lbltime.Text = "TIME :"
        ' 
        ' lbldate
        ' 
        lbldate.Anchor = AnchorStyles.Left
        lbldate.AutoSize = True
        lbldate.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbldate.Location = New Point(192, 9)
        lbldate.Name = "lbldate"
        lbldate.Size = New Size(75, 30)
        lbldate.TabIndex = 7
        lbldate.Text = "DATE :"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(114, 57)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 30)
        Label3.TabIndex = 6
        Label3.Text = "TIME :"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.CadetBlue
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(5, 4)
        PictureBox6.Margin = New Padding(3, 4, 3, 4)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(79, 96)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 1
        PictureBox6.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(92, 25)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(223, 45)
        Label1.TabIndex = 0
        Label1.Text = "DASHBOARD"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 200F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(GroupBox6, 1, 0)
        TableLayoutPanel1.Controls.Add(GroupBox5, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 323)
        TableLayoutPanel1.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(1106, 480)
        TableLayoutPanel1.TabIndex = 2
        ' 
        ' GroupBox6
        ' 
        GroupBox6.BackColor = Color.WhiteSmoke
        GroupBox6.Controls.Add(TableLayoutPanel13)
        GroupBox6.Dock = DockStyle.Fill
        GroupBox6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox6.Location = New Point(203, 4)
        GroupBox6.Margin = New Padding(3, 4, 3, 4)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Padding = New Padding(3, 4, 3, 4)
        GroupBox6.Size = New Size(900, 472)
        GroupBox6.TabIndex = 10
        GroupBox6.TabStop = False
        ' 
        ' TableLayoutPanel13
        ' 
        TableLayoutPanel13.ColumnCount = 1
        TableLayoutPanel13.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel13.Controls.Add(dgvout, 0, 1)
        TableLayoutPanel13.Controls.Add(dgvlow, 0, 0)
        TableLayoutPanel13.Dock = DockStyle.Fill
        TableLayoutPanel13.Location = New Point(3, 26)
        TableLayoutPanel13.Name = "TableLayoutPanel13"
        TableLayoutPanel13.RowCount = 2
        TableLayoutPanel13.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel13.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel13.Size = New Size(894, 442)
        TableLayoutPanel13.TabIndex = 1
        ' 
        ' dgvlow
        ' 
        dgvlow.AllowUserToAddRows = False
        dgvlow.AllowUserToDeleteRows = False
        dgvlow.BackgroundColor = SystemColors.ButtonHighlight
        dgvlow.BorderStyle = BorderStyle.None
        dgvlow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvlow.Dock = DockStyle.Fill
        dgvlow.Enabled = False
        dgvlow.GridColor = SystemColors.HighlightText
        dgvlow.Location = New Point(3, 3)
        dgvlow.Name = "dgvlow"
        dgvlow.ReadOnly = True
        dgvlow.Size = New Size(888, 215)
        dgvlow.TabIndex = 0
        ' 
        ' GroupBox5
        ' 
        GroupBox5.BackColor = Color.WhiteSmoke
        GroupBox5.Controls.Add(TableLayoutPanel11)
        GroupBox5.Dock = DockStyle.Fill
        GroupBox5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox5.Location = New Point(3, 4)
        GroupBox5.Margin = New Padding(3, 4, 3, 4)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Padding = New Padding(3, 4, 3, 4)
        GroupBox5.Size = New Size(194, 472)
        GroupBox5.TabIndex = 9
        GroupBox5.TabStop = False
        ' 
        ' TableLayoutPanel11
        ' 
        TableLayoutPanel11.ColumnCount = 1
        TableLayoutPanel11.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel11.Controls.Add(TableLayoutPanel15, 0, 1)
        TableLayoutPanel11.Controls.Add(TableLayoutPanel14, 0, 0)
        TableLayoutPanel11.Dock = DockStyle.Fill
        TableLayoutPanel11.Location = New Point(3, 26)
        TableLayoutPanel11.Name = "TableLayoutPanel11"
        TableLayoutPanel11.RowCount = 2
        TableLayoutPanel11.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel11.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel11.Size = New Size(188, 442)
        TableLayoutPanel11.TabIndex = 0
        ' 
        ' lblLowStocks
        ' 
        lblLowStocks.Anchor = AnchorStyles.Bottom
        lblLowStocks.AutoSize = True
        lblLowStocks.BackColor = Color.IndianRed
        lblLowStocks.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLowStocks.Location = New Point(13, 36)
        lblLowStocks.Name = "lblLowStocks"
        lblLowStocks.Size = New Size(155, 32)
        lblLowStocks.TabIndex = 1
        lblLowStocks.Text = "LOW STOCKS"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Anchor = AnchorStyles.Top
        PictureBox5.BackColor = Color.SandyBrown
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(21, 72)
        PictureBox5.Margin = New Padding(3, 4, 3, 4)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(139, 99)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 0
        PictureBox5.TabStop = False
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.BackColor = Color.LightCyan
        TableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble
        TableLayoutPanel2.ColumnCount = 4
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.2906971F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 24.6511631F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel2.Controls.Add(TableLayoutPanel3, 1, 0)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel4, 0, 0)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel7, 2, 0)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel8, 3, 0)
        TableLayoutPanel2.Dock = DockStyle.Top
        TableLayoutPanel2.Location = New Point(0, 98)
        TableLayoutPanel2.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(1106, 225)
        TableLayoutPanel2.TabIndex = 3
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(GroupBox1, 0, 1)
        TableLayoutPanel3.Controls.Add(btnTotalSales, 0, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(281, 7)
        TableLayoutPanel3.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 23.4939766F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 76.50603F))
        TableLayoutPanel3.Size = New Size(270, 211)
        TableLayoutPanel3.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.WhiteSmoke
        GroupBox1.Controls.Add(TableLayoutPanel6)
        GroupBox1.Dock = DockStyle.Fill
        GroupBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(3, 53)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(264, 154)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        ' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.ColumnCount = 4
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 8.527132F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 34.10853F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 8.139535F))
        TableLayoutPanel6.Controls.Add(lbltotalsalestoday, 2, 1)
        TableLayoutPanel6.Controls.Add(PictureBox1, 1, 1)
        TableLayoutPanel6.Dock = DockStyle.Fill
        TableLayoutPanel6.Location = New Point(3, 26)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.RowCount = 3
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 20.967741F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 63.70968F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 15.32258F))
        TableLayoutPanel6.Size = New Size(258, 124)
        TableLayoutPanel6.TabIndex = 1
        ' 
        ' lbltotalsalestoday
        ' 
        lbltotalsalestoday.Anchor = AnchorStyles.None
        lbltotalsalestoday.AutoSize = True
        lbltotalsalestoday.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbltotalsalestoday.Location = New Point(156, 47)
        lbltotalsalestoday.Name = "lbltotalsalestoday"
        lbltotalsalestoday.Size = New Size(32, 37)
        lbltotalsalestoday.TabIndex = 1
        lbltotalsalestoday.Text = "0"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(24, 30)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(81, 71)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' btnTotalSales
        ' 
        btnTotalSales.BackColor = Color.LightSeaGreen
        btnTotalSales.Dock = DockStyle.Fill
        btnTotalSales.Enabled = False
        btnTotalSales.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTotalSales.Location = New Point(3, 4)
        btnTotalSales.Margin = New Padding(3, 4, 3, 4)
        btnTotalSales.Name = "btnTotalSales"
        btnTotalSales.Size = New Size(264, 41)
        btnTotalSales.TabIndex = 6
        btnTotalSales.Text = "TOTAL SALES"
        btnTotalSales.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 1
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Controls.Add(btnTotalStock, 0, 0)
        TableLayoutPanel4.Controls.Add(GroupBox2, 0, 1)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(6, 7)
        TableLayoutPanel4.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 2
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 23.4939766F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 76.50603F))
        TableLayoutPanel4.Size = New Size(266, 211)
        TableLayoutPanel4.TabIndex = 1
        ' 
        ' btnTotalStock
        ' 
        btnTotalStock.BackColor = Color.LightSeaGreen
        btnTotalStock.Dock = DockStyle.Fill
        btnTotalStock.Enabled = False
        btnTotalStock.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTotalStock.Location = New Point(3, 4)
        btnTotalStock.Margin = New Padding(3, 4, 3, 4)
        btnTotalStock.Name = "btnTotalStock"
        btnTotalStock.Size = New Size(260, 41)
        btnTotalStock.TabIndex = 6
        btnTotalStock.Text = "TOTAL STOCK IN TODAY"
        btnTotalStock.UseVisualStyleBackColor = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.WhiteSmoke
        GroupBox2.Controls.Add(TableLayoutPanel5)
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(3, 53)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 4, 3, 4)
        GroupBox2.Size = New Size(260, 154)
        GroupBox2.TabIndex = 8
        GroupBox2.TabStop = False
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.ColumnCount = 4
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.5669289F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 38.97638F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35.03937F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 11.4173231F))
        TableLayoutPanel5.Controls.Add(lbltotalstockintoday, 2, 1)
        TableLayoutPanel5.Controls.Add(PictureBox2, 1, 1)
        TableLayoutPanel5.Dock = DockStyle.Fill
        TableLayoutPanel5.Location = New Point(3, 26)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 3
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 20.967741F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 63.70968F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 15.32258F))
        TableLayoutPanel5.Size = New Size(254, 124)
        TableLayoutPanel5.TabIndex = 0
        ' 
        ' lbltotalstockintoday
        ' 
        lbltotalstockintoday.Anchor = AnchorStyles.None
        lbltotalstockintoday.AutoSize = True
        lbltotalstockintoday.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbltotalstockintoday.Location = New Point(164, 47)
        lbltotalstockintoday.Name = "lbltotalstockintoday"
        lbltotalstockintoday.Size = New Size(32, 37)
        lbltotalstockintoday.TabIndex = 1
        lbltotalstockintoday.Text = "0"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.White
        PictureBox2.BorderStyle = BorderStyle.FixedSingle
        PictureBox2.Dock = DockStyle.Fill
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(40, 30)
        PictureBox2.Margin = New Padding(3, 4, 3, 4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(93, 71)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' TableLayoutPanel7
        ' 
        TableLayoutPanel7.ColumnCount = 1
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.Controls.Add(GroupBox7, 0, 1)
        TableLayoutPanel7.Controls.Add(btnTotalEmployees, 0, 0)
        TableLayoutPanel7.Dock = DockStyle.Fill
        TableLayoutPanel7.Location = New Point(560, 7)
        TableLayoutPanel7.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel7.Name = "TableLayoutPanel7"
        TableLayoutPanel7.RowCount = 2
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 23.4939766F))
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 76.50603F))
        TableLayoutPanel7.Size = New Size(263, 211)
        TableLayoutPanel7.TabIndex = 4
        ' 
        ' GroupBox7
        ' 
        GroupBox7.BackColor = Color.WhiteSmoke
        GroupBox7.Controls.Add(TableLayoutPanel9)
        GroupBox7.Dock = DockStyle.Fill
        GroupBox7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox7.Location = New Point(3, 53)
        GroupBox7.Margin = New Padding(3, 4, 3, 4)
        GroupBox7.Name = "GroupBox7"
        GroupBox7.Padding = New Padding(3, 4, 3, 4)
        GroupBox7.Size = New Size(257, 154)
        GroupBox7.TabIndex = 8
        GroupBox7.TabStop = False
        ' 
        ' TableLayoutPanel9
        ' 
        TableLayoutPanel9.ColumnCount = 4
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.5669289F))
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 38.97638F))
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35.03937F))
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 11.4173231F))
        TableLayoutPanel9.Controls.Add(lblEmployees, 2, 1)
        TableLayoutPanel9.Controls.Add(PictureBox7, 1, 1)
        TableLayoutPanel9.Dock = DockStyle.Fill
        TableLayoutPanel9.Location = New Point(3, 26)
        TableLayoutPanel9.Name = "TableLayoutPanel9"
        TableLayoutPanel9.RowCount = 3
        TableLayoutPanel9.RowStyles.Add(New RowStyle(SizeType.Percent, 20.967741F))
        TableLayoutPanel9.RowStyles.Add(New RowStyle(SizeType.Percent, 63.70968F))
        TableLayoutPanel9.RowStyles.Add(New RowStyle(SizeType.Percent, 15.32258F))
        TableLayoutPanel9.Size = New Size(251, 124)
        TableLayoutPanel9.TabIndex = 1
        ' 
        ' lblEmployees
        ' 
        lblEmployees.Anchor = AnchorStyles.None
        lblEmployees.AutoSize = True
        lblEmployees.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmployees.Location = New Point(160, 47)
        lblEmployees.Name = "lblEmployees"
        lblEmployees.Size = New Size(32, 37)
        lblEmployees.TabIndex = 1
        lblEmployees.Text = "0"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BorderStyle = BorderStyle.FixedSingle
        PictureBox7.Dock = DockStyle.Fill
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(39, 30)
        PictureBox7.Margin = New Padding(3, 4, 3, 4)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(91, 71)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 0
        PictureBox7.TabStop = False
        ' 
        ' btnTotalEmployees
        ' 
        btnTotalEmployees.BackColor = Color.LightSeaGreen
        btnTotalEmployees.Dock = DockStyle.Fill
        btnTotalEmployees.Enabled = False
        btnTotalEmployees.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTotalEmployees.Location = New Point(3, 4)
        btnTotalEmployees.Margin = New Padding(3, 4, 3, 4)
        btnTotalEmployees.Name = "btnTotalEmployees"
        btnTotalEmployees.Size = New Size(257, 41)
        btnTotalEmployees.TabIndex = 6
        btnTotalEmployees.Text = "TOTAL EMPLOYEES"
        btnTotalEmployees.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel8
        ' 
        TableLayoutPanel8.ColumnCount = 1
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel8.Controls.Add(GroupBox8, 0, 1)
        TableLayoutPanel8.Controls.Add(btnBestSelling, 0, 0)
        TableLayoutPanel8.Dock = DockStyle.Fill
        TableLayoutPanel8.Location = New Point(832, 7)
        TableLayoutPanel8.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel8.Name = "TableLayoutPanel8"
        TableLayoutPanel8.RowCount = 2
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 23.4939766F))
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 76.50603F))
        TableLayoutPanel8.Size = New Size(268, 211)
        TableLayoutPanel8.TabIndex = 5
        ' 
        ' GroupBox8
        ' 
        GroupBox8.BackColor = Color.WhiteSmoke
        GroupBox8.Controls.Add(TableLayoutPanel10)
        GroupBox8.Dock = DockStyle.Fill
        GroupBox8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox8.Location = New Point(3, 53)
        GroupBox8.Margin = New Padding(3, 4, 3, 4)
        GroupBox8.Name = "GroupBox8"
        GroupBox8.Padding = New Padding(3, 4, 3, 4)
        GroupBox8.Size = New Size(262, 154)
        GroupBox8.TabIndex = 8
        GroupBox8.TabStop = False
        ' 
        ' TableLayoutPanel10
        ' 
        TableLayoutPanel10.ColumnCount = 4
        TableLayoutPanel10.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 4.6875F))
        TableLayoutPanel10.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 32.03125F))
        TableLayoutPanel10.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 59.765625F))
        TableLayoutPanel10.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3.125F))
        TableLayoutPanel10.Controls.Add(lblbestsellingproduct, 2, 1)
        TableLayoutPanel10.Controls.Add(PictureBox8, 1, 1)
        TableLayoutPanel10.Dock = DockStyle.Fill
        TableLayoutPanel10.Location = New Point(3, 26)
        TableLayoutPanel10.Name = "TableLayoutPanel10"
        TableLayoutPanel10.RowCount = 3
        TableLayoutPanel10.RowStyles.Add(New RowStyle(SizeType.Percent, 20.967741F))
        TableLayoutPanel10.RowStyles.Add(New RowStyle(SizeType.Percent, 63.70968F))
        TableLayoutPanel10.RowStyles.Add(New RowStyle(SizeType.Percent, 15.32258F))
        TableLayoutPanel10.Size = New Size(256, 124)
        TableLayoutPanel10.TabIndex = 1
        ' 
        ' lblbestsellingproduct
        ' 
        lblbestsellingproduct.Anchor = AnchorStyles.None
        lblbestsellingproduct.AutoSize = True
        lblbestsellingproduct.Font = New Font("Calibri", 16F, FontStyle.Bold)
        lblbestsellingproduct.Location = New Point(120, 38)
        lblbestsellingproduct.Name = "lblbestsellingproduct"
        lblbestsellingproduct.Size = New Size(101, 54)
        lblbestsellingproduct.TabIndex = 1
        lblbestsellingproduct.Text = "Sample Product 1"
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BorderStyle = BorderStyle.FixedSingle
        PictureBox8.Dock = DockStyle.Fill
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(15, 30)
        PictureBox8.Margin = New Padding(3, 4, 3, 4)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(76, 71)
        PictureBox8.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox8.TabIndex = 0
        PictureBox8.TabStop = False
        ' 
        ' btnBestSelling
        ' 
        btnBestSelling.BackColor = Color.LightSeaGreen
        btnBestSelling.Dock = DockStyle.Fill
        btnBestSelling.Enabled = False
        btnBestSelling.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBestSelling.Location = New Point(3, 4)
        btnBestSelling.Margin = New Padding(3, 4, 3, 4)
        btnBestSelling.Name = "btnBestSelling"
        btnBestSelling.Size = New Size(262, 41)
        btnBestSelling.TabIndex = 6
        btnBestSelling.Text = "BEST SELLING PRODUCTS"
        btnBestSelling.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        ' 
        ' dgvout
        ' 
        dgvout.AllowUserToAddRows = False
        dgvout.AllowUserToDeleteRows = False
        dgvout.BackgroundColor = SystemColors.ButtonHighlight
        dgvout.BorderStyle = BorderStyle.None
        dgvout.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvout.Dock = DockStyle.Fill
        dgvout.Enabled = False
        dgvout.GridColor = SystemColors.HighlightText
        dgvout.Location = New Point(3, 224)
        dgvout.Name = "dgvout"
        dgvout.ReadOnly = True
        dgvout.Size = New Size(888, 215)
        dgvout.TabIndex = 1
        ' 
        ' TableLayoutPanel14
        ' 
        TableLayoutPanel14.ColumnCount = 1
        TableLayoutPanel14.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel14.Controls.Add(PictureBox5, 0, 1)
        TableLayoutPanel14.Controls.Add(lblLowStocks, 0, 0)
        TableLayoutPanel14.Dock = DockStyle.Fill
        TableLayoutPanel14.Location = New Point(3, 3)
        TableLayoutPanel14.Name = "TableLayoutPanel14"
        TableLayoutPanel14.RowCount = 2
        TableLayoutPanel14.RowStyles.Add(New RowStyle(SizeType.Percent, 31.6279068F))
        TableLayoutPanel14.RowStyles.Add(New RowStyle(SizeType.Percent, 68.37209F))
        TableLayoutPanel14.Size = New Size(182, 215)
        TableLayoutPanel14.TabIndex = 1
        ' 
        ' TableLayoutPanel15
        ' 
        TableLayoutPanel15.ColumnCount = 1
        TableLayoutPanel15.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel15.Controls.Add(PictureBox3, 0, 1)
        TableLayoutPanel15.Controls.Add(Label4, 0, 0)
        TableLayoutPanel15.Dock = DockStyle.Fill
        TableLayoutPanel15.Location = New Point(3, 224)
        TableLayoutPanel15.Name = "TableLayoutPanel15"
        TableLayoutPanel15.RowCount = 2
        TableLayoutPanel15.RowStyles.Add(New RowStyle(SizeType.Percent, 31.6279068F))
        TableLayoutPanel15.RowStyles.Add(New RowStyle(SizeType.Percent, 68.37209F))
        TableLayoutPanel15.Size = New Size(182, 215)
        TableLayoutPanel15.TabIndex = 2
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.Top
        PictureBox3.BackColor = Color.SandyBrown
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(21, 72)
        PictureBox3.Margin = New Padding(3, 4, 3, 4)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(139, 99)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Bottom
        Label4.AutoSize = True
        Label4.BackColor = Color.IndianRed
        Label4.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(38, 4)
        Label4.Name = "Label4"
        Label4.Size = New Size(105, 64)
        Label4.TabIndex = 1
        Label4.Text = "OUT OF STOCKS"
        ' 
        ' frmMAINDASHBOARD
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CadetBlue
        ClientSize = New Size(1106, 803)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmMAINDASHBOARD"
        Text = "frmMAINDASHBOARD"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TableLayoutPanel12.ResumeLayout(False)
        TableLayoutPanel12.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        GroupBox6.ResumeLayout(False)
        TableLayoutPanel13.ResumeLayout(False)
        CType(dgvlow, ComponentModel.ISupportInitialize).EndInit()
        GroupBox5.ResumeLayout(False)
        TableLayoutPanel11.ResumeLayout(False)
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        TableLayoutPanel6.ResumeLayout(False)
        TableLayoutPanel6.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel4.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel5.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel7.ResumeLayout(False)
        GroupBox7.ResumeLayout(False)
        TableLayoutPanel9.ResumeLayout(False)
        TableLayoutPanel9.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel8.ResumeLayout(False)
        GroupBox8.ResumeLayout(False)
        TableLayoutPanel10.ResumeLayout(False)
        TableLayoutPanel10.PerformLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvout, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel14.ResumeLayout(False)
        TableLayoutPanel14.PerformLayout()
        TableLayoutPanel15.ResumeLayout(False)
        TableLayoutPanel15.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btnTotalStock As Button
    Friend WithEvents btnTotalSales As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbltotalsalestoday As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lblLowStocks As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents lblbestsellingproduct As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents btnBestSelling As Button
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents lblEmployees As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents btnTotalEmployees As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbltotalstockintoday As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents dgvlow As DataGridView
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel12 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents lbltime As Label
    Friend WithEvents lbldate As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TableLayoutPanel13 As TableLayoutPanel
    Friend WithEvents dgvout As DataGridView
    Friend WithEvents TableLayoutPanel15 As TableLayoutPanel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TableLayoutPanel14 As TableLayoutPanel
End Class
