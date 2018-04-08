Imports System.Data.SqlClient
Public Class category

    Dim opendb As New SqlConnection("Server = DESKTOP-UOMVELS\SQLEXPRESS; Database = testdb; Integrated Security = true")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim insertExecute As String = "INSERT INTO dbo.category (category, created_date, updated_date) VALUES ('" & namecategory.Text & "', GETUTCDATE(), GETUTCDATE())"
        ExecuteNonQuery(insertExecute)
        Dim dTable As DataTable = ExecuteQuery("select * from category")
        categoryTable.DataSource = dTable
    End Sub


    Public Sub ExecuteNonQuery(query As String)
        Dim command As New SqlCommand(query, opendb)
        opendb.Open()
        command.ExecuteNonQuery()
        opendb.Close()
    End Sub


    Public Function ExecuteQuery(query As String) As DataTable
        Dim command As New SqlCommand(query, opendb)

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        Return table
        'userView.DataSource = table
    End Function

End Class