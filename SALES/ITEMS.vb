Public Class ITEMS
    Private Sub Btn_now_Click(sender As Object, e As EventArgs) Handles Btn_now.Click
        For i = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(i) Is TextBox Then GroupBox1.Controls(i).Text = ""
            If TypeOf GroupBox1.Controls(i) Is DateTimePicker Then GroupBox1.Controls(i).Text = New Date
        Next
        CheckBox1.Checked = False
        Text_code.Text = CODE_GEN("ITEMS", "ID") + 1
        Btn_back.Enabled = False
        Btn_delete.Enabled = False
        Btn_edit.Enabled = False
        Btn_save.Enabled = True
        'Text_code.Enabled = False
        Text_name.Select()
    End Sub

    Private Sub ITEMS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Btn_now_Click(sender, e)
    End Sub

    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles Btn_save.Click
        ' قيود ادخال----------------------------------------------------------------
        If Text_name.Text = "" Then

            ErrorProvider1.SetError(Text_name, "يرجى ادخال اسم الصنف")
            Text_name.Select()
        Else
            ErrorProvider1.SetError(Text_name, "")
            Text_name.Select()
        End If
        If Text_barcode.Text = "" Then
            ErrorProvider1.SetError(Text_barcode, "يرجى ادخال الباركود")
            Text_barcode.Select()
        Else
            ErrorProvider1.SetError(Text_barcode, "")
        End If
        '----------------------------------------------------------------------------
        'code save------------------------------------------------------------------
        Dim dt As New DataTable


        Dim da As New SqlClient.SqlDataAdapter("SELECT * FROM ITEMS where ITEM_NOME = '" & Text_name.Text & "'  or ITEM_CODE = '" & Text_barcode.Text & "' ", Sqlcon)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            MessageBox.Show(" بيانات غير موجودة ", "Carta de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            dt.Rows.Add()
            Dim add_ As Integer = dt.Rows.Count - 1
            dt.Rows(add_).Item("ITEM_NOME") = Text_code.Text
            dt.Rows(add_).Item("ITEM_CODE") = Text_barcode.Text
            dt.Rows(add_).Item("ITEM_UNIT") = Text_unite.Text
            dt.Rows(add_).Item("ITEM_TKLFA") = Text_costprice.Text
            dt.Rows(add_).Item("ITEM_PRICE") = Text_sellingprice.Text
            dt.Rows(add_).Item("ITEM_EXPIRE") = DateTimePicker1.Text
            dt.Rows(add_).Item("NOTES") = Text_notes.Text
            dt.Rows(add_).Item("ITEM_CHEACK") = CheckBox1.Checked

            Dim sav As New SqlClient.SqlCommandBuilder(da)
            da.Update(dt)
            dt.AcceptChanges()
            MessageBox.Show(" تم الحفظ بنجاح ", "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Btn_now_Click(sender, e)
        End If


    End Sub
End Class