Imports System.Data.SqlClient

Public Class Addqty

    Public Property SProductName As String
    Public Property CurrentQuantity As Integer
    Public Property NewQuantity As Integer
    Public Property ProductCode As Integer

    Private Sub Addqty_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            ' Trigger the Settle Payment function
            btnempsave_Click(sender, e)
        End If
        If e.KeyCode = Keys.Escape Then
            ' Trigger the Settle Payment function
            btnempback_Click(sender, e)
        End If
    End Sub
    Private Sub AddQuantityForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtproductname.Text = SProductName
        txtquantity.Text = CurrentQuantity.ToString()

        Me.KeyPreview = True
    End Sub



    Private Sub Addqty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtproductname.Text = SProductName
        txtquantity.Text = CurrentQuantity.ToString()
    End Sub


    Private Sub txtprodname_TextChanged(sender As Object, e As EventArgs) Handles txtproductname.TextChanged

    End Sub

    Private Sub btnempback_Click(sender As Object, e As EventArgs) Handles btnempback.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnempsave_Click(sender As Object, e As EventArgs) Handles btnempsave.Click
        If Integer.TryParse(txtquantity.Text, NewQuantity) AndAlso NewQuantity > 0 Then

            Me.DialogResult = DialogResult.OK
            Me.Close()


        Else

            Me.DialogResult = DialogResult.Retry
            MessageBox.Show("Please enter a valid quantity greater than zero.")
        End If


    End Sub

    Private Sub txtquantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtquantity.KeyPress
        ' Allow only digits and control characters in the quantity textbox
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtquantity_TextChanged(sender As Object, e As EventArgs) Handles txtquantity.TextChanged

    End Sub




End Class