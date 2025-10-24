
Imports Microsoft.Data.SqlClient

Module Connect
    Public Connstring As String = "Data Source=DESKTOP-GB785JE\SQLEXPRESS01;Initial Catalog=MYDB;Integrated Security=True;Encrypt=False"

    Public Function ExecuteSQLStatement(ByVal SQLstring As String, ByVal myDataGrid As DataGridView)
        Dim sqlconn As New SqlConnection(Connstring)
        Dim sqlDataAdapter As New SqlDataAdapter
        Dim myDataSet As New DataSet

        Try
            sqlconn.Open()
            sqlDataAdapter.SelectCommand = New SqlCommand(SQLstring, sqlconn)
            sqlDataAdapter.Fill(myDataSet)
            myDataGrid.DataSource = myDataSet.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            sqlDataAdapter.Dispose()
            myDataSet.Dispose()
            sqlconn.Close()
            sqlconn.Dispose()
        End Try
    End Function


End Module
