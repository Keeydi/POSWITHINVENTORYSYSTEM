<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmaeEmployees
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
        lblEmployeeID = New Label()
        lblEmployeeName = New Label()
        lblAddress = New Label()
        lblEmail = New Label()
        lblUsername = New Label()
        txtEmployeeID = New TextBox()
        txtEmployeeName = New TextBox()
        txtAddress = New TextBox()
        txtEmail = New TextBox()
        txtUsername = New TextBox()
        lblSex = New Label()
        cmbSex = New ComboBox()
        btncancel = New Button()
        btnsave = New Button()
        SuspendLayout()
        ' 
        ' lblEmployeeID
        ' 
        lblEmployeeID.AutoSize = True
        lblEmployeeID.Font = New Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmployeeID.Location = New Point(39, 42)
        lblEmployeeID.Name = "lblEmployeeID"
        lblEmployeeID.Size = New Size(112, 23)
        lblEmployeeID.TabIndex = 0
        lblEmployeeID.Text = "EmployeeID :"
        ' 
        ' lblEmployeeName
        ' 
        lblEmployeeName.AutoSize = True
        lblEmployeeName.Font = New Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmployeeName.Location = New Point(12, 81)
        lblEmployeeName.Name = "lblEmployeeName"
        lblEmployeeName.Size = New Size(139, 23)
        lblEmployeeName.TabIndex = 1
        lblEmployeeName.Text = "EmployeeName :"
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAddress.Location = New Point(70, 118)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(82, 23)
        lblAddress.TabIndex = 2
        lblAddress.Text = "Address :"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmail.Location = New Point(92, 150)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(60, 23)
        lblEmail.TabIndex = 3
        lblEmail.Text = "Email :"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUsername.Location = New Point(344, 44)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(98, 23)
        lblUsername.TabIndex = 4
        lblUsername.Text = "Username :"
        ' 
        ' txtEmployeeID
        ' 
        txtEmployeeID.Enabled = False
        txtEmployeeID.Location = New Point(159, 44)
        txtEmployeeID.Margin = New Padding(3, 2, 3, 2)
        txtEmployeeID.Name = "txtEmployeeID"
        txtEmployeeID.Size = New Size(175, 23)
        txtEmployeeID.TabIndex = 8
        ' 
        ' txtEmployeeName
        ' 
        txtEmployeeName.Location = New Point(159, 83)
        txtEmployeeName.Margin = New Padding(3, 2, 3, 2)
        txtEmployeeName.Name = "txtEmployeeName"
        txtEmployeeName.Size = New Size(175, 23)
        txtEmployeeName.TabIndex = 9
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(159, 118)
        txtAddress.Margin = New Padding(3, 2, 3, 2)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(175, 23)
        txtAddress.TabIndex = 10
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(159, 152)
        txtEmail.Margin = New Padding(3, 2, 3, 2)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(175, 23)
        txtEmail.TabIndex = 11
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(449, 44)
        txtUsername.Margin = New Padding(3, 2, 3, 2)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(147, 23)
        txtUsername.TabIndex = 12
        ' 
        ' lblSex
        ' 
        lblSex.AutoSize = True
        lblSex.Font = New Font("Calibri", 13.8F)
        lblSex.Location = New Point(397, 79)
        lblSex.Name = "lblSex"
        lblSex.Size = New Size(45, 23)
        lblSex.TabIndex = 18
        lblSex.Text = "Sex :"
        ' 
        ' cmbSex
        ' 
        cmbSex.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSex.FormattingEnabled = True
        cmbSex.Location = New Point(449, 83)
        cmbSex.Margin = New Padding(3, 2, 3, 2)
        cmbSex.Name = "cmbSex"
        cmbSex.Size = New Size(147, 23)
        cmbSex.TabIndex = 19
        ' 
        ' btncancel
        ' 
        btncancel.BackColor = Color.IndianRed
        btncancel.Font = New Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btncancel.Location = New Point(395, 199)
        btncancel.Name = "btncancel"
        btncancel.Size = New Size(114, 66)
        btncancel.TabIndex = 21
        btncancel.Text = "Cancel"
        btncancel.UseVisualStyleBackColor = False
        ' 
        ' btnsave
        ' 
        btnsave.BackColor = Color.LightGreen
        btnsave.Font = New Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnsave.ForeColor = SystemColors.ControlText
        btnsave.Location = New Point(141, 199)
        btnsave.Name = "btnsave"
        btnsave.Size = New Size(108, 66)
        btnsave.TabIndex = 20
        btnsave.Text = "Save"
        btnsave.UseVisualStyleBackColor = False
        ' 
        ' frmaeEmployees
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CadetBlue
        ClientSize = New Size(638, 283)
        ControlBox = False
        Controls.Add(btncancel)
        Controls.Add(btnsave)
        Controls.Add(cmbSex)
        Controls.Add(lblSex)
        Controls.Add(txtUsername)
        Controls.Add(txtEmail)
        Controls.Add(txtAddress)
        Controls.Add(txtEmployeeName)
        Controls.Add(txtEmployeeID)
        Controls.Add(lblUsername)
        Controls.Add(lblEmail)
        Controls.Add(lblAddress)
        Controls.Add(lblEmployeeName)
        Controls.Add(lblEmployeeID)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmaeEmployees"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Employee Information"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblEmployeeID As Label
    Friend WithEvents lblEmployeeName As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents txtEmployeeName As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblSex As Label

    Private Sub txtSex_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents cmbSex As ComboBox
    Friend WithEvents btncancel As Button
    Friend WithEvents btnsave As Button
End Class
