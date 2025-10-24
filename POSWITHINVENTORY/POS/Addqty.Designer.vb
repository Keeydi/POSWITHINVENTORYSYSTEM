<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Addqty
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
        btnempback = New Button()
        btnempsave = New Button()
        Label1 = New Label()
        txtproductname = New TextBox()
        Label2 = New Label()
        txtquantity = New TextBox()
        SuspendLayout()
        ' 
        ' btnempback
        ' 
        btnempback.BackColor = Color.IndianRed
        btnempback.Font = New Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnempback.Location = New Point(301, 177)
        btnempback.Name = "btnempback"
        btnempback.Size = New Size(114, 66)
        btnempback.TabIndex = 21
        btnempback.Text = "Cancel"
        btnempback.UseVisualStyleBackColor = False
        ' 
        ' btnempsave
        ' 
        btnempsave.BackColor = Color.LightGreen
        btnempsave.Font = New Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnempsave.ForeColor = SystemColors.ControlText
        btnempsave.Location = New Point(47, 177)
        btnempsave.Name = "btnempsave"
        btnempsave.Size = New Size(108, 66)
        btnempsave.TabIndex = 20
        btnempsave.Text = "Ok"
        btnempsave.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(40, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(152, 30)
        Label1.TabIndex = 23
        Label1.Text = "Product Name:"
        ' 
        ' txtproductname
        ' 
        txtproductname.Enabled = False
        txtproductname.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtproductname.Location = New Point(198, 45)
        txtproductname.Name = "txtproductname"
        txtproductname.Size = New Size(190, 35)
        txtproductname.TabIndex = 22
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(88, 114)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 30)
        Label2.TabIndex = 25
        Label2.Text = "Quantity :"
        ' 
        ' txtquantity
        ' 
        txtquantity.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtquantity.Location = New Point(198, 114)
        txtquantity.Name = "txtquantity"
        txtquantity.Size = New Size(190, 35)
        txtquantity.TabIndex = 24
        ' 
        ' Addqty
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CadetBlue
        ClientSize = New Size(471, 281)
        ControlBox = False
        Controls.Add(Label2)
        Controls.Add(txtquantity)
        Controls.Add(Label1)
        Controls.Add(txtproductname)
        Controls.Add(btnempback)
        Controls.Add(btnempsave)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "Addqty"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add Quantity"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnempback As Button
    Friend WithEvents btnempsave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtproductname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtquantity As TextBox
End Class
