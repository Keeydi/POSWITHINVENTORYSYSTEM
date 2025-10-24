<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        TableLayoutPanel1 = New TableLayoutPanel()
        btnREPORT = New Button()
        btnPOS = New Button()
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        btndashboard = New Button()
        btnlogout = New Button()
        btnactivitylogs = New Button()
        btninventory = New Button()
        btnemployee = New Button()
        Panel1 = New Panel()
        TableLayoutPanel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(btnREPORT, 0, 6)
        TableLayoutPanel1.Controls.Add(btnPOS, 0, 4)
        TableLayoutPanel1.Controls.Add(GroupBox1, 0, 0)
        TableLayoutPanel1.Controls.Add(btndashboard, 0, 1)
        TableLayoutPanel1.Controls.Add(btnlogout, 0, 7)
        TableLayoutPanel1.Controls.Add(btnactivitylogs, 0, 5)
        TableLayoutPanel1.Controls.Add(btninventory, 0, 2)
        TableLayoutPanel1.Controls.Add(btnemployee, 0, 3)
        TableLayoutPanel1.Dock = DockStyle.Left
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(4)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 8
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 17.9012718F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10.9433966F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 11.1320753F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 11.1320753F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10.6880608F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10.6880608F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10.7861061F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 18.09872F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(255, 860)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' btnREPORT
        ' 
        btnREPORT.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        btnREPORT.Dock = DockStyle.Fill
        btnREPORT.ForeColor = Color.White
        btnREPORT.Location = New Point(4, 615)
        btnREPORT.Margin = New Padding(4)
        btnREPORT.Name = "btnREPORT"
        btnREPORT.Size = New Size(247, 83)
        btnREPORT.TabIndex = 7
        btnREPORT.Text = "REPORT"
        btnREPORT.UseVisualStyleBackColor = False
        ' 
        ' btnPOS
        ' 
        btnPOS.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        btnPOS.Dock = DockStyle.Fill
        btnPOS.ForeColor = Color.White
        btnPOS.Location = New Point(4, 435)
        btnPOS.Margin = New Padding(4)
        btnPOS.Name = "btnPOS"
        btnPOS.Size = New Size(247, 82)
        btnPOS.TabIndex = 4
        btnPOS.Text = "POS"
        btnPOS.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.DarkCyan
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Dock = DockStyle.Fill
        GroupBox1.FlatStyle = FlatStyle.Flat
        GroupBox1.Location = New Point(4, 4)
        GroupBox1.Margin = New Padding(4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4)
        GroupBox1.Size = New Size(247, 143)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(33, 93)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(152, 20)
        Label1.TabIndex = 1
        Label1.Text = "CHEN MOTORPARTS"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(49, -4)
        PictureBox1.Margin = New Padding(4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(152, 202)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' btndashboard
        ' 
        btndashboard.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        btndashboard.Dock = DockStyle.Fill
        btndashboard.ForeColor = Color.White
        btndashboard.Location = New Point(4, 155)
        btndashboard.Margin = New Padding(4)
        btndashboard.Name = "btndashboard"
        btndashboard.Size = New Size(247, 84)
        btndashboard.TabIndex = 1
        btndashboard.Text = "DASHBOARD"
        btndashboard.UseVisualStyleBackColor = False
        ' 
        ' btnlogout
        ' 
        btnlogout.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        btnlogout.ForeColor = Color.White
        btnlogout.Location = New Point(4, 706)
        btnlogout.Margin = New Padding(4)
        btnlogout.Name = "btnlogout"
        btnlogout.Size = New Size(247, 65)
        btnlogout.TabIndex = 6
        btnlogout.Text = "LOGOUT"
        btnlogout.UseVisualStyleBackColor = False
        ' 
        ' btnactivitylogs
        ' 
        btnactivitylogs.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        btnactivitylogs.Dock = DockStyle.Fill
        btnactivitylogs.ForeColor = Color.White
        btnactivitylogs.Location = New Point(4, 525)
        btnactivitylogs.Margin = New Padding(4)
        btnactivitylogs.Name = "btnactivitylogs"
        btnactivitylogs.Size = New Size(247, 82)
        btnactivitylogs.TabIndex = 4
        btnactivitylogs.Text = "ACTIVITY LOGS"
        btnactivitylogs.UseVisualStyleBackColor = False
        ' 
        ' btninventory
        ' 
        btninventory.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        btninventory.Dock = DockStyle.Fill
        btninventory.ForeColor = Color.White
        btninventory.Location = New Point(4, 247)
        btninventory.Margin = New Padding(4)
        btninventory.Name = "btninventory"
        btninventory.Size = New Size(247, 86)
        btninventory.TabIndex = 3
        btninventory.Text = "INVENTORY"
        btninventory.UseVisualStyleBackColor = False
        ' 
        ' btnemployee
        ' 
        btnemployee.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        btnemployee.Dock = DockStyle.Fill
        btnemployee.ForeColor = Color.White
        btnemployee.Location = New Point(4, 341)
        btnemployee.Margin = New Padding(4)
        btnemployee.Name = "btnemployee"
        btnemployee.Size = New Size(247, 86)
        btnemployee.TabIndex = 2
        btnemployee.Text = "EMPLOYEE"
        btnemployee.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.CadetBlue
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(255, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(997, 860)
        Panel1.TabIndex = 1
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1252, 860)
        ControlBox = False
        Controls.Add(Panel1)
        Controls.Add(TableLayoutPanel1)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4)
        Name = "Dashboard"
        WindowState = FormWindowState.Maximized
        TableLayoutPanel1.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnlogout As Button
    Friend WithEvents btnactivitylogs As Button
    Friend WithEvents btnPOS As Button
    Friend WithEvents btninventory As Button
    Friend WithEvents btnemployee As Button
    Friend WithEvents btndashboard As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnREPORT As Button
End Class
