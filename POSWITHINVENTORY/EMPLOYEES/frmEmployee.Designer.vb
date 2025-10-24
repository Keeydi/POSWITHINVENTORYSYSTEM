<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployee
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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        PictureBox6 = New PictureBox()
        Panel1 = New Panel()
        panelmain = New Panel()
        btnArchive = New Button()
        btnEdit = New Button()
        btnAdd = New Button()
        dgvEmployee = New DataGridView()
        btnAdd1 = New Button()
        btnEdit1 = New Button()
        btnArchive1 = New Button()
        txtSearch = New TextBox()
        btnSearch4 = New Button()
        Panel2 = New Panel()
        Button1 = New Button()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        panelmain.SuspendLayout()
        CType(dgvEmployee, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(94, 8)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(221, 54)
        Label1.TabIndex = 0
        Label1.Text = "EMPLOYEE"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.White
        PictureBox6.Image = My.Resources.Resources.Employee2
        PictureBox6.InitialImage = My.Resources.Resources.Employee21
        PictureBox6.Location = New Point(20, 8)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(76, 59)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 2
        PictureBox6.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.CadetBlue
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(panelmain)
        Panel1.Controls.Add(PictureBox6)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(5, 6, 5, 6)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1574, 90)
        Panel1.TabIndex = 3
        ' 
        ' panelmain
        ' 
        panelmain.Controls.Add(btnArchive)
        panelmain.Controls.Add(btnEdit)
        panelmain.Controls.Add(btnAdd)
        panelmain.Location = New Point(42, 111)
        panelmain.Name = "panelmain"
        panelmain.Size = New Size(1981, 564)
        panelmain.TabIndex = 2
        ' 
        ' btnArchive
        ' 
        btnArchive.Font = New Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnArchive.Location = New Point(479, 505)
        btnArchive.Name = "btnArchive"
        btnArchive.Size = New Size(174, 62)
        btnArchive.TabIndex = 3
        btnArchive.Text = "Archive"
        btnArchive.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Font = New Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEdit.Location = New Point(246, 505)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(158, 62)
        btnEdit.TabIndex = 2
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAdd.Location = New Point(38, 505)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(147, 62)
        btnAdd.TabIndex = 1
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' dgvEmployee
        ' 
        dgvEmployee.AllowUserToAddRows = False
        dgvEmployee.AllowUserToDeleteRows = False
        dgvEmployee.AllowUserToResizeColumns = False
        dgvEmployee.AllowUserToResizeRows = False
        dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvEmployee.BackgroundColor = Color.White
        dgvEmployee.BorderStyle = BorderStyle.None
        dgvEmployee.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvEmployee.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmployee.EditMode = DataGridViewEditMode.EditOnEnter
        dgvEmployee.EnableHeadersVisualStyles = False
        dgvEmployee.GridColor = Color.White
        dgvEmployee.ImeMode = ImeMode.NoControl
        dgvEmployee.Location = New Point(3, 162)
        dgvEmployee.Margin = New Padding(3, 4, 3, 4)
        dgvEmployee.Name = "dgvEmployee"
        dgvEmployee.ReadOnly = True
        dgvEmployee.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        dgvEmployee.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvEmployee.Size = New Size(1677, 789)
        dgvEmployee.TabIndex = 8
        ' 
        ' btnAdd1
        ' 
        btnAdd1.BackColor = Color.Cyan
        btnAdd1.Location = New Point(43, 958)
        btnAdd1.Name = "btnAdd1"
        btnAdd1.Size = New Size(131, 68)
        btnAdd1.TabIndex = 9
        btnAdd1.Text = "Add"
        btnAdd1.UseVisualStyleBackColor = False
        ' 
        ' btnEdit1
        ' 
        btnEdit1.BackColor = Color.LightGreen
        btnEdit1.Location = New Point(230, 958)
        btnEdit1.Name = "btnEdit1"
        btnEdit1.Size = New Size(141, 68)
        btnEdit1.TabIndex = 10
        btnEdit1.Text = "Edit"
        btnEdit1.UseVisualStyleBackColor = False
        ' 
        ' btnArchive1
        ' 
        btnArchive1.BackColor = Color.Khaki
        btnArchive1.Location = New Point(425, 958)
        btnArchive1.Name = "btnArchive1"
        btnArchive1.Size = New Size(137, 68)
        btnArchive1.TabIndex = 11
        btnArchive1.Text = "Archive"
        btnArchive1.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(122, 3)
        txtSearch.Multiline = True
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Type to Search..."
        txtSearch.Size = New Size(440, 32)
        txtSearch.TabIndex = 12
        ' 
        ' btnSearch4
        ' 
        btnSearch4.BackColor = Color.MediumTurquoise
        btnSearch4.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSearch4.Location = New Point(3, 3)
        btnSearch4.Name = "btnSearch4"
        btnSearch4.Size = New Size(113, 35)
        btnSearch4.TabIndex = 13
        btnSearch4.Text = "Search"
        btnSearch4.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Gainsboro
        Panel2.Controls.Add(btnSearch4)
        Panel2.Controls.Add(txtSearch)
        Panel2.Location = New Point(0, 74)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1689, 41)
        Panel2.TabIndex = 14
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Cyan
        Button1.Location = New Point(1358, 958)
        Button1.Name = "Button1"
        Button1.Size = New Size(192, 68)
        Button1.TabIndex = 15
        Button1.Text = "View Employee Archives"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' frmEmployee
        ' 
        AutoScaleDimensions = New SizeF(11F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CadetBlue
        ClientSize = New Size(1574, 1055)
        Controls.Add(Button1)
        Controls.Add(Panel2)
        Controls.Add(btnArchive1)
        Controls.Add(btnEdit1)
        Controls.Add(btnAdd1)
        Controls.Add(dgvEmployee)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Margin = New Padding(4)
        Name = "frmEmployee"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmEmployee"
        WindowState = FormWindowState.Maximized
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        panelmain.ResumeLayout(False)
        CType(dgvEmployee, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnArchive As Button
    Friend WithEvents panelmain As Panel
    Friend WithEvents dgvEmployee As DataGridView
    Friend WithEvents btnAdd1 As Button
    Friend WithEvents btnEdit1 As Button
    Friend WithEvents btnArchive1 As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch4 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
End Class
