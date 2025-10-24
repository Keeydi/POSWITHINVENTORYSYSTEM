<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estockin
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
        txtprodid = New TextBox()
        btncancel = New Button()
        btnsave = New Button()
        txtquantity = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' txtprodid
        ' 
        txtprodid.Location = New Point(646, 363)
        txtprodid.Name = "txtprodid"
        txtprodid.Size = New Size(100, 23)
        txtprodid.TabIndex = 23
        ' 
        ' btncancel
        ' 
        btncancel.BackColor = Color.IndianRed
        btncancel.Font = New Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btncancel.Location = New Point(320, 90)
        btncancel.Name = "btncancel"
        btncancel.Size = New Size(114, 66)
        btncancel.TabIndex = 22
        btncancel.Text = "Cancel"
        btncancel.UseVisualStyleBackColor = False
        ' 
        ' btnsave
        ' 
        btnsave.BackColor = Color.LightGreen
        btnsave.Font = New Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnsave.ForeColor = SystemColors.ControlText
        btnsave.Location = New Point(66, 90)
        btnsave.Name = "btnsave"
        btnsave.Size = New Size(108, 66)
        btnsave.TabIndex = 21
        btnsave.Text = "Save"
        btnsave.UseVisualStyleBackColor = False
        ' 
        ' txtquantity
        ' 
        txtquantity.Location = New Point(196, 35)
        txtquantity.Name = "txtquantity"
        txtquantity.Size = New Size(151, 23)
        txtquantity.TabIndex = 20
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 16.2F, FontStyle.Bold)
        Label1.Location = New Point(96, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 27)
        Label1.TabIndex = 19
        Label1.Text = "Quantity :"
        ' 
        ' Estockin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CadetBlue
        ClientSize = New Size(492, 187)
        ControlBox = False
        Controls.Add(txtprodid)
        Controls.Add(btncancel)
        Controls.Add(btnsave)
        Controls.Add(txtquantity)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "Estockin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Estock"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtprodid As TextBox
    Friend WithEvents btncancel As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents txtquantity As TextBox
    Friend WithEvents Label1 As Label
End Class
