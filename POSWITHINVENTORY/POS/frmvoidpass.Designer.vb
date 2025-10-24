<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmvoidpass
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
        Label1 = New Label()
        txtpassword = New TextBox()
        btnempback = New Button()
        btnempsave = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(23, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(158, 30)
        Label1.TabIndex = 25
        Label1.Text = "Enter Password:"
        ' 
        ' txtpassword
        ' 
        txtpassword.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtpassword.Location = New Point(181, 43)
        txtpassword.Name = "txtpassword"
        txtpassword.PasswordChar = "*"c
        txtpassword.Size = New Size(190, 35)
        txtpassword.TabIndex = 24
        ' 
        ' btnempback
        ' 
        btnempback.BackColor = Color.IndianRed
        btnempback.Font = New Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnempback.Location = New Point(271, 97)
        btnempback.Name = "btnempback"
        btnempback.Size = New Size(114, 66)
        btnempback.TabIndex = 27
        btnempback.Text = "Cancel"
        btnempback.UseVisualStyleBackColor = False
        ' 
        ' btnempsave
        ' 
        btnempsave.BackColor = Color.LightGreen
        btnempsave.Font = New Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnempsave.ForeColor = SystemColors.ControlText
        btnempsave.Location = New Point(17, 97)
        btnempsave.Name = "btnempsave"
        btnempsave.Size = New Size(108, 66)
        btnempsave.TabIndex = 26
        btnempsave.Text = "Ok"
        btnempsave.UseVisualStyleBackColor = False
        ' 
        ' frmvoidpass
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CadetBlue
        ClientSize = New Size(410, 180)
        ControlBox = False
        Controls.Add(btnempback)
        Controls.Add(btnempsave)
        Controls.Add(Label1)
        Controls.Add(txtpassword)
        Name = "frmvoidpass"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Void"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents btnempback As Button
    Friend WithEvents btnempsave As Button
End Class
