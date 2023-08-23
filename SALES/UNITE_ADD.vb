Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class UNITE_ADD


    Sub show_detait(ID)
        Dim dt As New DataTable
        Dim da As New SqlClient.SqlDataAdapter("SELECT * FROM UNITE WHERE UNITE_CODE = '" & ID & "'", Sqlcon)
        da.Fill(dt)

        If dt.Rows.Count = 0 Then
            MessageBox.Show("لا توجد بيانات ", " erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim SHOW As DataRow = dt.Rows(0)
            Text_code.Text = SHOW("UNITE_CODE")
            Text_name.Text = SHOW("UNITE_NAME")
            Btn_now.Enabled = True
            Btn_edit.Enabled = True
            Btn_delete.Enabled = True
            Btn_save.Enabled = False
        End If

    End Sub







    Private Sub Btn_now_Click(sender As Object, e As EventArgs) Handles Btn_now.Click
        Text_code.Text = ""
        Text_name.Text = ""
        Text_code.Text = CODE_GEN("UNITE", "ID") + 1
        Btn_delete.Enabled = False
        Btn_save.Enabled = True
        Btn_edit.Enabled = False
        Btn_now.Enabled = False
        Text_name.Select()

    End Sub

    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles Btn_save.Click
        '----------------------- 
        If Text_name.Text = "" Then
            Text_name.BackColor = Color.Red
        Else
            Text_name.BackColor = Color.White
            Text_name.Select()

            '------------------------
            Dim dt As New DataTable
            Dim da As New SqlClient.SqlDataAdapter("SELECT * FROM UNITE", Sqlcon)
            da.Fill(dt)
            DataGridView1.DataSource = dt.DefaultView

            If dt.Rows.Count > 0 Then
                MessageBox.Show(" بيانات غير موجودة ", "Carta de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                dt.Rows.Add()
                Dim add_ As Integer = dt.Rows.Count - 1
                dt.Rows(add_).Item("UNITE_CODE") = Text_code.Text
                dt.Rows(add_).Item("UNITE_NAME") = Text_name.Text

                Dim sav As New SqlClient.SqlCommandBuilder(da)
                da.Update(dt)
                dt.AcceptChanges()
                MessageBox.Show(" تم الحفظ بنجاح ", "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Btn_now_Click(sender, e)
            End If
        End If

    End Sub

    Private Sub UNITE_ADD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Btn_now_Click(sender, e)
        DGV_FILL(DataGridView1, "SELECT * FROM UNITE")


    End Sub

    Private Sub Btn_edit_Click(sender As Object, e As EventArgs) Handles Btn_edit.Click
        If Text_name.Text = "" Then
            Text_name.BackColor = Color.Red
        Else
            Text_name.BackColor = Color.White
            Text_name.Select()


            '--------------
            Dim dt As New DataTable
            Dim da As New SqlClient.SqlDataAdapter("SELECT * FROM UNITE where UNITE_NAME = '" & Text_name.Text & "' ", Sqlcon)
            da.Fill(dt)

            Dim cmdBuilder As New SqlClient.SqlCommandBuilder(da)




            If dt.Rows.Count = 0 Then
                MessageBox.Show("السجل غير موجود", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim updateRow As DataRow = dt.Rows(0) ' نفترض أنك تقوم بتحديث سجل واحد فقط

                updateRow("UNITE_NAME") = Text_name.Text

                da.Update(dt)
                dt.AcceptChanges()

                MessageBox.Show("تم التحديث بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' اتصل بدالة أخرى أو قم بإجراءات إضافية بعد التحديث
                Btn_now_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub Btn_delete_Click(sender As Object, e As EventArgs) Handles Btn_delete.Click
        Dim dt As New DataTable
        Dim da As New SqlClient.SqlDataAdapter("SELECT * FROM UNITE", Sqlcon)
        da.Fill(dt)
        If dt.Rows.Count = 0 Then
            MessageBox.Show(" المورد غير موجود يرجى التاكد", "Carta de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim DELET_ = dt.Rows(0)
            DELET_.Delete()
            Dim sav As New SqlClient.SqlCommandBuilder(da)
            da.Update(dt)
            dt.AcceptChanges()
            MessageBox.Show(" تم الحذف بنجاع ", "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Btn_now_Click(sender, e)

        End If

    End Sub
    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(i).Cells(0).Value = " Show "
            Dim row As DataGridViewRow = DataGridView1.Rows(i)
        Next
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(i).Cells(2).Value = " DETAIT "

            Dim row As DataGridViewRow = DataGridView1.Rows(i)
        Next
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        If DataGridView1(2, DataGridView1.CurrentRow.Index).Selected Then
            show_detait(DataGridView1.CurrentRow.Cells(3).Value)


        End If
    End Sub
End Class