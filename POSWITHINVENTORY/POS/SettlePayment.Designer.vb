<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettlePayment
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
        txtcostumer = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtamount = New TextBox()
        txtcash = New TextBox()
        txtchange = New TextBox()
        btnempback = New Button()
        btnempsave = New Button()
        SuspendLayout()
        ' 
        ' txtcostumer
        ' 
        txtcostumer.Enabled = False
        txtcostumer.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtcostumer.Location = New Point(275, 26)
        txtcostumer.Name = "txtcostumer"
        txtcostumer.Size = New Size(190, 35)
        txtcostumer.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(90, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(169, 30)
        Label1.TabIndex = 1
        Label1.Text = "Employee Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(116, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(143, 30)
        Label2.TabIndex = 2
        Label2.Text = "Total Amount:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(190, 108)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 30)
        Label3.TabIndex = 3
        Label3.Text = "Cash :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(94, 194)
        Label4.Name = "Label4"
        Label4.Size = New Size(171, 45)
        Label4.TabIndex = 4
        Label4.Text = "CHANGE :"
        ' 
        ' txtamount
        ' 
        txtamount.Enabled = False
        txtamount.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtamount.Location = New Point(275, 68)
        txtamount.Name = "txtamount"
        txtamount.Size = New Size(190, 35)
        txtamount.TabIndex = 5
        ' 
        ' txtcash
        ' 
        txtcash.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtcash.Location = New Point(275, 109)
        txtcash.Name = "txtcash"
        txtcash.Size = New Size(190, 35)
        txtcash.TabIndex = 6
        ' 
        ' txtchange
        ' 
        txtchange.Enabled = False
        txtchange.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtchange.Location = New Point(271, 185)
        txtchange.Name = "txtchange"
        txtchange.Size = New Size(324, 71)
        txtchange.TabIndex = 7
        ' 
        ' btnempback
        ' 
        btnempback.BackColor = Color.IndianRed
        btnempback.Font = New Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnempback.Location = New Point(392, 269)
        btnempback.Name = "btnempback"
        btnempback.Size = New Size(114, 66)
        btnempback.TabIndex = 19
        btnempback.Text = "Cancel"
        btnempback.UseVisualStyleBackColor = False
        ' 
        ' btnempsave
        ' 
        btnempsave.BackColor = Color.LightGreen
        btnempsave.Font = New Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnempsave.ForeColor = SystemColors.ControlText
        btnempsave.Location = New Point(138, 269)
        btnempsave.Name = "btnempsave"
        btnempsave.Size = New Size(108, 66)
        btnempsave.TabIndex = 18
        btnempsave.Text = "Ok"
        btnempsave.UseVisualStyleBackColor = False
        ' 
        ' SettlePayment
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CadetBlue
        ClientSize = New Size(683, 347)
        ControlBox = False
        Controls.Add(btnempback)
        Controls.Add(btnempsave)
        Controls.Add(txtchange)
        Controls.Add(txtcash)
        Controls.Add(txtamount)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtcostumer)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "SettlePayment"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SettlePayment"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtcostumer As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtamount As TextBox
    Friend WithEvents txtcash As TextBox
    Friend WithEvents txtchange As TextBox
    Friend WithEvents btnempback As Button
    Friend WithEvents btnempsave As Button
End Class
