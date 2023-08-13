﻿Public Class Search_sup
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Search_sup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_FILL(DataGridView1, "SELECT * FROM IMPORTERS WHERE STATES = 'true' ORDER BY IMP_CODE")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If RadioButton1.Checked = True Then
            Dim dt As New DataTable
            Dim da As New SqlClient.SqlDataAdapter
            dt.Clear()
            da = New SqlClient.SqlDataAdapter("SELECT * FROM IMPORTERS WHERE STATES = 'true' AND IMP_NAME LIKE  '%" & TextBox1.Text & "%'", Sqlcon)

            da.Fill(dt)
            DataGridView1.DataSource = dt.DefaultView
        End If

        If RadioButton2.Checked = True Then
            Dim dt As New DataTable
            Dim da As New SqlClient.SqlDataAdapter
            dt.Clear()
            da = New SqlClient.SqlDataAdapter("SELECT * FROM IMPORTERS WHERE STATES = 'true' AND IMP_ADRESS LIKE  '%" & TextBox1.Text & "%'", Sqlcon)

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
End Class