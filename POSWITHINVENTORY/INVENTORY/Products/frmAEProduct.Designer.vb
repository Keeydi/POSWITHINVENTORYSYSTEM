<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAEProduct
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
        cmbCategory = New ComboBox()
        txtProductCode = New TextBox()
        txtProductName = New TextBox()
        txtBrandName = New TextBox()
        txtType = New TextBox()
        txtStock = New TextBox()
        txtTotalPrice = New TextBox()
        txtUnitPrice = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        btnsave = New Button()
        btncancel = New Button()
        cmbUnit = New ComboBox()
        SuspendLayout()
        ' 
        ' cmbCategory
        ' 
        cmbCategory.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbCategory.FormattingEnabled = True
        cmbCategory.Location = New Point(352, 44)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(151, 32)
        cmbCategory.TabIndex = 0
        ' 
        ' txtProductCode
        ' 
        txtProductCode.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtProductCode.Location = New Point(352, 90)
        txtProductCode.Name = "txtProductCode"
        txtProductCode.Size = New Size(151, 32)
        txtProductCode.TabIndex = 1
        ' 
        ' txtProductName
        ' 
        txtProductName.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtProductName.Location = New Point(352, 137)
        txtProductName.Name = "txtProductName"
        txtProductName.Size = New Size(151, 32)
        txtProductName.TabIndex = 2
        ' 
        ' txtBrandName
        ' 
        txtBrandName.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtBrandName.Location = New Point(352, 184)
        txtBrandName.Name = "txtBrandName"
        txtBrandName.Size = New Size(151, 32)
        txtBrandName.TabIndex = 3
        ' 
        ' txtType
        ' 
        txtType.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtType.Location = New Point(352, 231)
        txtType.Name = "txtType"
        txtType.Size = New Size(151, 32)
        txtType.TabIndex = 4
        ' 
        ' txtStock
        ' 
        txtStock.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtStock.Location = New Point(352, 332)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(151, 32)
        txtStock.TabIndex = 3
        ' 
        ' txtTotalPrice
        ' 
        txtTotalPrice.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtTotalPrice.Location = New Point(352, 431)
        txtTotalPrice.Name = "txtTotalPrice"
        txtTotalPrice.Size = New Size(151, 32)
        txtTotalPrice.TabIndex = 6
        ' 
        ' txtUnitPrice
        ' 
        txtUnitPrice.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtUnitPrice.Location = New Point(352, 381)
        txtUnitPrice.Name = "txtUnitPrice"
        txtUnitPrice.Size = New Size(151, 32)
        txtUnitPrice.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(218, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(127, 35)
        Label1.TabIndex = 7
        Label1.Text = "Category:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(178, 90)
        Label2.Name = "Label2"
        Label2.Size = New Size(171, 35)
        Label2.TabIndex = 8
        Label2.Text = "Productcode:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(165, 137)
        Label3.Name = "Label3"
        Label3.Size = New Size(184, 35)
        Label3.TabIndex = 9
        Label3.Text = "ProductName:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(200, 184)
        Label8.Name = "Label8"
        Label8.Size = New Size(149, 35)
        Label8.TabIndex = 10
        Label8.Text = "Brand Name:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(280, 231)
        Label9.Name = "Label9"
        Label9.Size = New Size(69, 35)
        Label9.TabIndex = 11
        Label9.Text = "Type:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(259, 332)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 35)
        Label4.TabIndex = 11
        Label4.Text = "Stock:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(70, 285)
        Label5.Name = "Label5"
        Label5.Size = New Size(279, 35)
        Label5.TabIndex = 10
        Label5.Text = "Unit of  Measurement:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(206, 431)
        Label6.Name = "Label6"
        Label6.Size = New Size(139, 35)
        Label6.TabIndex = 13
        Label6.Text = "TotalPrice:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(214, 381)
        Label7.Name = "Label7"
        Label7.Size = New Size(131, 35)
        Label7.TabIndex = 12
        Label7.Text = "UnitPrice:"
        ' 
        ' btnsave
        ' 
        btnsave.BackColor = Color.LightGreen
        btnsave.Font = New Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnsave.ForeColor = SystemColors.ControlText
        btnsave.Location = New Point(178, 436)
        btnsave.Name = "btnsave"
        btnsave.Size = New Size(108, 66)
        btnsave.TabIndex = 14
        btnsave.Text = "Save"
        btnsave.UseVisualStyleBackColor = False
        ' 
        ' btncancel
        ' 
        btncancel.BackColor = Color.IndianRed
        btncancel.Font = New Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btncancel.Location = New Point(432, 436)
        btncancel.Name = "btncancel"
        btncancel.Size = New Size(114, 66)
        btncancel.TabIndex = 15
        btncancel.Text = "Cancel"
        btncancel.UseVisualStyleBackColor = False
        ' 
        ' cmbUnit
        ' 
        cmbUnit.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbUnit.FormattingEnabled = True
        cmbUnit.Location = New Point(352, 285)
        cmbUnit.Name = "cmbUnit"
        cmbUnit.Size = New Size(151, 32)
        cmbUnit.TabIndex = 16
        ' 
        ' frmAEProduct
        ' 
        AutoScaleDimensions = New SizeF(8F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CadetBlue
        ClientSize = New Size(775, 580)
        Controls.Add(cmbUnit)
        Controls.Add(btncancel)
        Controls.Add(btnsave)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(Label4)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtTotalPrice)
        Controls.Add(txtUnitPrice)
        Controls.Add(txtStock)
        Controls.Add(txtType)
        Controls.Add(txtBrandName)
        Controls.Add(txtProductName)
        Controls.Add(txtProductCode)
        Controls.Add(cmbCategory)
        Font = New Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Name = "frmAEProduct"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmAEProduct"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents txtProductCode As TextBox
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents txtBrandName As TextBox
    Friend WithEvents txtType As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents txtUnitPrice As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnsave As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents cmbUnit As ComboBox
End Class
