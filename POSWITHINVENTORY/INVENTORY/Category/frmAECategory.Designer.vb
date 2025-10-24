<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAECategory
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
        txtCategoryName = New TextBox()
        txtCategoryDescription = New TextBox()
        Label2 = New Label()
        btnSave = New Button()
        btnCancel = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' txtCategoryName
        ' 
        txtCategoryName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCategoryName.Location = New Point(294, 96)
        txtCategoryName.Name = "txtCategoryName"
        txtCategoryName.Size = New Size(157, 34)
        txtCategoryName.TabIndex = 0
        ' 
        ' txtCategoryDescription
        ' 
        txtCategoryDescription.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCategoryDescription.Location = New Point(294, 152)
        txtCategoryDescription.Name = "txtCategoryDescription"
        txtCategoryDescription.Size = New Size(157, 34)
        txtCategoryDescription.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(86, 145)
        Label2.Name = "Label2"
        Label2.Size = New Size(156, 35)
        Label2.TabIndex = 3
        Label2.Text = "Description:"
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.LimeGreen
        btnSave.Font = New Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = SystemColors.ActiveCaptionText
        btnSave.Location = New Point(86, 250)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(116, 64)
        btnSave.TabIndex = 4
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.IndianRed
        btnCancel.Font = New Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = SystemColors.ActiveCaptionText
        btnCancel.Location = New Point(330, 250)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(121, 64)
        btnCancel.TabIndex = 5
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(86, 89)
        Label1.Name = "Label1"
        Label1.Size = New Size(202, 35)
        Label1.TabIndex = 2
        Label1.Text = "Category Name:"
        ' 
        ' frmAECategory
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CadetBlue
        ClientSize = New Size(589, 440)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtCategoryDescription)
        Controls.Add(txtCategoryName)
        ForeColor = Color.Black
        Name = "frmAECategory"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmAECategory"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtCategoryName As TextBox
    Friend WithEvents txtCategoryDescription As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label1 As Label
End Class
