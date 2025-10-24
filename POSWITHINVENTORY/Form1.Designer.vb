<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        txtusername = New TextBox()
        txtpassword = New TextBox()
        chkshowpass = New CheckBox()
        btnlogin = New Button()
        btnexit = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkCyan
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(317, 49)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(75, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(161, 21)
        Label1.TabIndex = 0
        Label1.Text = "CHEN-MOTORPARTS"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 55)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(292, 226)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' txtusername
        ' 
        txtusername.Location = New Point(12, 296)
        txtusername.Name = "txtusername"
        txtusername.PlaceholderText = "Username"
        txtusername.Size = New Size(292, 23)
        txtusername.TabIndex = 2
        ' 
        ' txtpassword
        ' 
        txtpassword.Location = New Point(12, 325)
        txtpassword.Name = "txtpassword"
        txtpassword.PasswordChar = "*"c
        txtpassword.PlaceholderText = "Password"
        txtpassword.Size = New Size(292, 23)
        txtpassword.TabIndex = 3
        ' 
        ' chkshowpass
        ' 
        chkshowpass.AutoSize = True
        chkshowpass.Location = New Point(12, 354)
        chkshowpass.Name = "chkshowpass"
        chkshowpass.Size = New Size(108, 19)
        chkshowpass.TabIndex = 4
        chkshowpass.Text = "Show Password"
        chkshowpass.UseVisualStyleBackColor = True
        ' 
        ' btnlogin
        ' 
        btnlogin.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnlogin.Location = New Point(12, 379)
        btnlogin.Name = "btnlogin"
        btnlogin.Size = New Size(292, 23)
        btnlogin.TabIndex = 5
        btnlogin.Text = "LOGIN"
        btnlogin.UseVisualStyleBackColor = False
        ' 
        ' btnexit
        ' 
        btnexit.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnexit.Location = New Point(12, 408)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(292, 23)
        btnexit.TabIndex = 6
        btnexit.Text = "EXIT"
        btnexit.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(317, 438)
        ControlBox = False
        Controls.Add(btnexit)
        Controls.Add(btnlogin)
        Controls.Add(chkshowpass)
        Controls.Add(txtpassword)
        Controls.Add(txtusername)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents chkshowpass As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnlogin As Button
    Friend WithEvents btnexit As Button

End Class
