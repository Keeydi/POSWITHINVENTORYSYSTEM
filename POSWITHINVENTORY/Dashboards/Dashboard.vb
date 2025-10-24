Public Class Dashboard
    Private Sub loadform(chilform)
        Panel1.Controls.Clear()
        chilform.toplevel = False
        chilform.FormBorderStyle = FormBorderStyle.None
        chilform.dock = DockStyle.Fill
        Panel1.Controls.Add(chilform)
        chilform.show()
    End Sub
    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub btndashboard_Click(sender As Object, e As EventArgs) Handles btndashboard.Click
        loadform(New frmMAINDASHBOARD)
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadform(New frmMAINDASHBOARD)
    End Sub

    Private Sub btninventory_Click(sender As Object, e As EventArgs) Handles btninventory.Click
        loadform(New frmInventory)
    End Sub

    Private Sub btnsales_Click(sender As Object, e As EventArgs) Handles btnPOS.Click
        Pointofsalesystem.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub btnemployee_Click(sender As Object, e As EventArgs) Handles btnemployee.Click
        loadform(New frmEmployee)
    End Sub

    Private Sub btnactivitylogs_Click(sender As Object, e As EventArgs) Handles btnactivitylogs.Click
        loadform(New frmUserlogs)
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Log Out?", "Confirm LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()
            Form1.Show() ' Closes the form/application
            Form1.txtusername.Clear()
        Else

            ' Do nothing — stay in the app
        End If
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnREPORT.Click
        'MessageBox.Show("This feature is currently under development.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'frmSalesReport.ShowDialog()
        loadform(New frmSalesReport)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub


End Class