Public Class Searche_cus

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If ComboBox1.SelectedIndex = 0 Then
            Dim dt As New DataTable
            Dim da As New SqlClient.SqlDataAdapter
            dt.Clear()
            da = New SqlClient.SqlDataAdapter("SELECT * FROM CUSTOMERS WHERE CUS_NAME LIKE  '%" & TextBox1.Text & "%'", Sqlcon)

            da.Fill(dt)
            DataGridView1.DataSource = dt.DefaultView
        End If

        If ComboBox1.SelectedIndex = 1 Then
            Dim dt As New DataTable
            Dim da As New SqlClient.SqlDataAdapter
            dt.Clear()
            da = New SqlClient.SqlDataAdapter("SELECT * FROM CUSTOMERS WHERE AND CUS_PHONE LIKE  '%" & TextBox1.Text & "%'", Sqlcon)

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
            Customers.show_detait(DataGridView1.CurrentRow.Cells(1).Value)
            Me.Close()

        End If
    End Sub
    Private Sub Searche_cus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterParent
        DGV_FILL(DataGridView1, "SELECT * FROM CUSTOMERS ORDER BY CUS_CODE")
        ComboBox1.SelectedIndex = 0
        ComboBox1.Select()

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Hide()
    End Sub
End Class