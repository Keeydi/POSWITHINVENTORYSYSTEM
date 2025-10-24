Imports Windows.Win32.UI.Controls
Imports System.Data.SqlClient
Public Class frmUserlogs
    Sub formatgrid()
        dgvlogs.CellBorderStyle = DataGridViewCellBorderStyle.None
        dgvlogs.RowHeadersVisible = False
        dgvlogs.ColumnHeadersVisible = True
        ' center teh datas
        dgvlogs.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        For Each column As DataGridViewColumn In dgvlogs.Columns
            column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
        dgvlogs.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvlogs.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 12, FontStyle.Regular)
        dgvlogs.DefaultCellStyle.Font = New Font("Segoe UI", 12)
        dgvlogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvlogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvlogs.Columns(0).Visible = False
        dgvlogs.Columns(1).Width = 100
        dgvlogs.Columns(2).Width = 100
        dgvlogs.Columns(3).Width = 100
        dgvlogs.Columns(4).Width = 300

        With dgvlogs ' palitan mo ng pangalan ng datagridview
            ' General Appearance
            .EnableHeadersVisualStyles = False
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            .BackgroundColor = Color.White
            .BorderStyle = BorderStyle.None

            ' Header
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            ' Row Style
            .DefaultCellStyle.BackColor = Color.White ' Row background
            .DefaultCellStyle.ForeColor = Color.Black ' Row text color
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 112, 149) ' Selected row background
            .DefaultCellStyle.SelectionForeColor = Color.White ' Selected row text color
            .DefaultCellStyle.Font = New Font("Segoe UI", 12, FontStyle.Regular)

            ' Alternating rows
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

            ' Selection
            .RowsDefaultCellStyle.SelectionBackColor = Color.LightBlue
            .RowsDefaultCellStyle.SelectionForeColor = Color.Black


            ' Grid Lines
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            .GridColor = Color.LightGray

            ' Additional Properties
            .AllowUserToAddRows = False
            .AllowUserToResizeRows = False
            .ReadOnly = True
        End With
    End Sub
    Private Sub Reload()
        ExecuteSQLStatement("SELECT * FROM Logs ORDER BY Timestamp DESC", dgvlogs)
        formatgrid()
    End Sub

    Private Sub Lowstockwarning_Load(sender As Object, e As EventArgs) Handles Me.Load
        Reload()
        Me.BeginInvoke(Sub()
                           dgvlogs.ClearSelection()
                           dgvlogs.CurrentCell = Nothing
                       End Sub)
    End Sub
End Class