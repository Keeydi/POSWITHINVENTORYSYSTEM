<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventory))
        panelmain = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        btnShowArchived = New Button()
        btnStockOut = New Button()
        btnShowCategory = New Button()
        btnStockIn = New Button()
        btnManageemployees = New Button()
        Panel1 = New Panel()
        PictureBox6 = New PictureBox()
        Label1 = New Label()
        TableLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panelmain
        ' 
        panelmain.Dock = DockStyle.Fill
        panelmain.Location = New Point(0, 134)
        panelmain.Margin = New Padding(4)
        panelmain.Name = "panelmain"
        panelmain.Size = New Size(1084, 528)
        panelmain.TabIndex = 5
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 5
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.Controls.Add(btnShowArchived, 4, 0)
        TableLayoutPanel1.Controls.Add(btnStockOut, 3, 0)
        TableLayoutPanel1.Controls.Add(btnShowCategory, 1, 0)
        TableLayoutPanel1.Controls.Add(btnStockIn, 2, 0)
        TableLayoutPanel1.Controls.Add(btnManageemployees, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Top
        TableLayoutPanel1.Location = New Point(0, 79)
        TableLayoutPanel1.Margin = New Padding(4)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(1084, 55)
        TableLayoutPanel1.TabIndex = 4
        ' 
        ' btnShowArchived
        ' 
        btnShowArchived.BackColor = Color.Khaki
        btnShowArchived.Dock = DockStyle.Fill
        btnShowArchived.Font = New Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnShowArchived.Location = New Point(868, 4)
        btnShowArchived.Margin = New Padding(4)
        btnShowArchived.Name = "btnShowArchived"
        btnShowArchived.Size = New Size(212, 47)
        btnShowArchived.TabIndex = 3
        btnShowArchived.Text = "Archives"
        btnShowArchived.UseVisualStyleBackColor = False
        ' 
        ' btnStockOut
        ' 
        btnStockOut.BackColor = Color.IndianRed
        btnStockOut.Dock = DockStyle.Fill
        btnStockOut.Font = New Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnStockOut.Location = New Point(652, 4)
        btnStockOut.Margin = New Padding(4)
        btnStockOut.Name = "btnStockOut"
        btnStockOut.Size = New Size(208, 47)
        btnStockOut.TabIndex = 1
        btnStockOut.Text = "Defects"
        btnStockOut.UseVisualStyleBackColor = False
        ' 
        ' btnShowCategory
        ' 
        btnShowCategory.BackColor = Color.LightSeaGreen
        btnShowCategory.Dock = DockStyle.Fill
        btnShowCategory.Font = New Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnShowCategory.Location = New Point(220, 4)
        btnShowCategory.Margin = New Padding(4)
        btnShowCategory.Name = "btnShowCategory"
        btnShowCategory.Size = New Size(208, 47)
        btnShowCategory.TabIndex = 0
        btnShowCategory.Text = "Category"
        btnShowCategory.UseVisualStyleBackColor = False
        ' 
        ' btnStockIn
        ' 
        btnStockIn.BackColor = Color.SteelBlue
        btnStockIn.Dock = DockStyle.Fill
        btnStockIn.Font = New Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnStockIn.Location = New Point(436, 4)
        btnStockIn.Margin = New Padding(4)
        btnStockIn.Name = "btnStockIn"
        btnStockIn.Size = New Size(208, 47)
        btnStockIn.TabIndex = 1
        btnStockIn.Text = "Stocks"
        btnStockIn.UseVisualStyleBackColor = False
        ' 
        ' btnManageemployees
        ' 
        btnManageemployees.BackColor = Color.MediumAquamarine
        btnManageemployees.Dock = DockStyle.Fill
        btnManageemployees.Font = New Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnManageemployees.ForeColor = SystemColors.ControlText
        btnManageemployees.Location = New Point(4, 4)
        btnManageemployees.Margin = New Padding(4)
        btnManageemployees.Name = "btnManageemployees"
        btnManageemployees.Size = New Size(208, 47)
        btnManageemployees.TabIndex = 1
        btnManageemployees.Text = "All Products"
        btnManageemployees.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.CadetBlue
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(PictureBox6)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(5, 6, 5, 6)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1084, 79)
        Panel1.TabIndex = 3
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(11, 8)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(68, 60)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 2
        PictureBox6.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(87, 14)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(250, 54)
        Label1.TabIndex = 0
        Label1.Text = "INVENTORY"
        ' 
        ' frmInventory
        ' 
        AutoScaleDimensions = New SizeF(11F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1084, 662)
        Controls.Add(panelmain)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Margin = New Padding(4)
        Name = "frmInventory"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmInventory"
        WindowState = FormWindowState.Maximized
        TableLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelmain As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnShowArchived As Button
    Friend WithEvents btnManageemployees As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents btnStockOut As Button
    Friend WithEvents btnStockIn As Button
    Friend WithEvents btnShowCategory As Button
End Class
