Public Class Search_items
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If ComboBox1.SelectedIndex = 0 Then
            Dim dt As New DataTable
            Dim da As New SqlClient.SqlDataAdapter
            dt.Clear()
            da = New SqlClient.SqlDataAdapter("SELECT * FROM ITEMS WHERE ITEM_NAME LIKE  '%" & TextBox1.Text & "%'", Sqlcon)

            da.Fill(dt)
            DataGridView1.DataSource = dt.DefaultView
        End If

        If ComboBox1.SelectedIndex = 1 Then
            Dim dt As New DataTable
            Dim da As New SqlClient.SqlDataAdapter
            dt.Clear()
            da = New SqlClient.SqlDataAdapter("SELECT * FROM ITEMS WHERE ITEM_CODE LIKE  '%" & TextBox1.Text & "%'", Sqlcon)

            da.Fill(dt)
            DataGridView1.DataSource = dt.DefaultView
        End If


    End Sub
    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(i).Cells(0).Value = " Show "
            Dim row As DataGridViewRow = DataGridView1.Rows(i)
        Next
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        If DataGridView1(0, DataGridView1.CurrentRow.Index).Selected Then
            ITEMS.show_detait(DataGridView1.CurrentRow.Cells(1).Value)
            Me.Close()

        End If
    End Sub
    Private Sub Searche_items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_FILL(DataGridView1, "SELECT * FROM ITEMS ORDER BY ID")
        ComboBox1.SelectedIndex = 0
        ComboBox1.Select()

    End Sub
End Class