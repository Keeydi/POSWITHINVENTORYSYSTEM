<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmvoid
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
        dgv = New DataGridView()
        TableLayoutPanel1 = New TableLayoutPanel()
        btnempback = New Button()
        btnempsave = New Button()
        CType(dgv, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgv
        ' 
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        dgv.BackgroundColor = SystemColors.ButtonFace
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv.Dock = DockStyle.Fill
        dgv.Location = New Point(0, 0)
        dgv.Name = "dgv"
        dgv.ReadOnly = True
        dgv.Size = New Size(800, 450)
        dgv.TabIndex = 0
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.CadetBlue
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 82.75F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 17.25F))
        TableLayoutPanel1.Controls.Add(btnempback, 1, 0)
        TableLayoutPanel1.Controls.Add(btnempsave, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Bottom
        TableLayoutPanel1.Location = New Point(0, 394)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(800, 56)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' btnempback
        ' 
        btnempback.BackColor = Color.IndianRed
        btnempback.Font = New Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnempback.Location = New Point(665, 3)
        btnempback.Name = "btnempback"
        btnempback.Size = New Size(114, 50)
        btnempback.TabIndex = 23
        btnempback.Text = "Cancel"
        btnempback.UseVisualStyleBackColor = False
        ' 
        ' btnempsave
        ' 
        btnempsave.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnempsave.BackColor = Color.LightGreen
        btnempsave.Font = New Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnempsave.ForeColor = SystemColors.ControlText
        btnempsave.Location = New Point(551, 3)
        btnempsave.Name = "btnempsave"
        btnempsave.Size = New Size(108, 50)
        btnempsave.TabIndex = 22
        btnempsave.Text = "Ok"
        btnempsave.UseVisualStyleBackColor = False
        ' 
        ' frmVoid
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        ControlBox = False
        Controls.Add(TableLayoutPanel1)
        Controls.Add(dgv)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "frmVoid"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Void"
        CType(dgv, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgv As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnempback As Button
    Friend WithEvents btnempsave As Button
End Class
