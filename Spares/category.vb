Imports System.Data.SqlClient
Public Class category

    Dim opendb As New SqlConnection("Server = DESKTOP-UOMVELS\SQLEXPRESS; Database = spares; Integrated Security = true")
    Dim index, categoryID As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim insertExecute As String = "INSERT INTO category (category, create_date, update_date) VALUES ('" & namecategory.Text & "', GETUTCDATE(), GETUTCDATE())"
        ExecuteNonQuery(insertExecute)
        selectAll(categoryTable)
    End Sub

    Public Sub selectAll(table As DataGridView)
        Dim dTable As DataTable = ExecuteQuery("select * from category")
        table.DataSource = dTable
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

    Private Sub category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        selectAll(categoryTable)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ExecuteNonQuery("UPDATE category SET category = '" & namecategory.Text.ToString() & "', update_date = GETUTCDATE() WHERE id_category = '" & categoryID & "' ")
        selectAll(categoryTable)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Do you want to delete this item?", "Comfirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            'Delete data
            ExecuteNonQuery("DELETE FROM category WHERE id_category = '" & categoryID & "' ")
            MessageBox.Show("Deleted")
            selectAll(categoryTable)
            namecategory.Text = ""
        Else
            MessageBox.Show("Cancel delete")
        End If

    End Sub

    Private Sub categoryTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles categoryTable.CellContentClick
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = categoryTable.Rows(index)
        categoryID = selectedRow.Cells(0).Value.ToString()
        namecategory.Text = selectedRow.Cells(1).Value.ToString()
        'txtName.Text = selectedRow.Cells(0).Value.ToString()
    End Sub

End Class