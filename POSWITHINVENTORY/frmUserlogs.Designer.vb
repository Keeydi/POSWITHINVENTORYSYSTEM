<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserlogs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserlogs))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        PictureBox6 = New PictureBox()
        Label2 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        dgvlogs = New DataGridView()
        Panel1.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        CType(dgvlogs, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(PictureBox6)
        Panel1.Controls.Add(Label2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(5, 6, 5, 6)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(941, 71)
        Panel1.TabIndex = 5
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(10, 9)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(59, 50)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 6
        PictureBox6.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(76, 19)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(251, 45)
        Label2.TabIndex = 0
        Label2.Text = "ACTIVITY LOGS"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.White
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(dgvlogs, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 71)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.030593F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(941, 452)
        TableLayoutPanel1.TabIndex = 6
        ' 
        ' dgvlogs
        ' 
        dgvlogs.AllowUserToAddRows = False
        dgvlogs.AllowUserToDeleteRows = False
        dgvlogs.AllowUserToResizeColumns = False
        dgvlogs.AllowUserToResizeRows = False
        dgvlogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvlogs.BackgroundColor = Color.White
        dgvlogs.BorderStyle = BorderStyle.None
        dgvlogs.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvlogs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvlogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvlogs.Dock = DockStyle.Fill
        dgvlogs.EditMode = DataGridViewEditMode.EditOnEnter
        dgvlogs.EnableHeadersVisualStyles = False
        dgvlogs.GridColor = Color.White
        dgvlogs.ImeMode = ImeMode.NoControl
        dgvlogs.Location = New Point(3, 3)
        dgvlogs.Name = "dgvlogs"
        dgvlogs.ReadOnly = True
        dgvlogs.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvlogs.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvlogs.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        dgvlogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvlogs.Size = New Size(935, 446)
        dgvlogs.TabIndex = 1
        ' 
        ' frmUserlogs
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(941, 523)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "frmUserlogs"
        Text = "frmUserlogs"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        CType(dgvlogs, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dgvlogs As DataGridView
End Class
