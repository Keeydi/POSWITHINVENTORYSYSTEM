Public Class frmInventory
    Private Sub loadform(chilform)
        panelmain.Controls.Clear()
        chilform.toplevel = False
        chilform.FormBorderStyle = FormBorderStyle.None
        chilform.dock = DockStyle.Fill
        panelmain.Controls.Add(chilform)
        chilform.show()
    End Sub
    Private Sub frmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadform(New frmProductlist)
    End Sub

    Private Sub Btnallemployees_Click(sender As Object, e As EventArgs)
        loadform(New frmProducts)
    End Sub

    Private Sub btnManageemployees_Click(sender As Object, e As EventArgs) Handles btnManageemployees.Click
        loadform(New frmProductlist)
    End Sub

    Private Sub btnarchivedemployees_Click(sender As Object, e As EventArgs)
        loadform(New frmManageproducts)
    End Sub

    Private Sub btnShowArchived_Click(sender As Object, e As EventArgs)
        Dim frm As New frmArchives()
        frm.Show()
    End Sub
    Private Sub btnStockIn_Click(sender As Object, e As EventArgs) Handles btnStockIn.Click
        loadform(New frmStockIn)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnStockOut_Click(sender As Object, e As EventArgs) Handles btnStockOut.Click
        loadform(New Defects)
    End Sub

    Private Sub panelmain_Paint(sender As Object, e As PaintEventArgs) Handles panelmain.Paint

    End Sub

    Private Sub btnShowCategory_Click(sender As Object, e As EventArgs) Handles btnShowCategory.Click
        loadform(New frmCategorylist)
    End Sub

    Private Sub btnShowArchived_Click_1(sender As Object, e As EventArgs) Handles btnShowArchived.Click
        Dim frm As New frmArchives()
        loadform(New frmArchives)
    End Sub
End Class