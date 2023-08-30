Public Class ITEMS


    Sub show_detait(ID_)
        Dim dt As New DataTable
        Dim da As New SqlClient.SqlDataAdapter("SELECT * FROM ITEMS WHERE ITEM_CODE = '" & ID_ & "'", Sqlcon)
        da.Fill(dt)
        If dt.Rows.Count = 0 Then
            MessageBox.Show("ل توجد بيانات ", " erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim show_ As Integer = BindingContext(dt).Position

            Text_code.Text = dt.Rows(show_).Item("ITEM_CODE")
            Text_name.Text = dt.Rows(show_).Item("ITEM_NAME")
            Text_barcode.Text = dt.Rows(show_).Item("ITEM_BAR")
            'Text_unite.Text = dt.Rows(show_).Item("ITEM_UNIT")
            Text_costprice.Text = dt.Rows(show_).Item("ITEM_TKLFA")
            Text_sellingprice.Text = dt.Rows(show_).Item("ITEM_PRICE")
            Text_qty.Text = dt.Rows(show_).Item("ITEM_Qntity")
            DTP.Value = dt.Rows(show_).Item("ITEM_EXPIRE")
            Text_notes.Text = dt.Rows(show_).Item("NOTES")
            CheckBox1.Checked = dt.Rows(show_).Item("ITEM_CHEACK")

            Btn_edit.Enabled = True
            Btn_delete.Enabled = True
            Btn_save.Enabled = False
        End If

    End Sub

    '------------------- اظهار على كومبوبوكس
    Sub FILL_UNITE(STR As String)
        Text_unite.Items.Clear()
        Dim dt As New DataTable
        Dim da As New SqlClient.SqlDataAdapter(STR, Sqlcon)
        da.Fill(dt)
        For i = 0 To dt.Rows.Count - 1
            Text_unite.Items.Add(dt.Rows(i).Item("UNITE_NAME"))
        Next

    End Sub

    Private Sub Btn_now_Click(sender As Object, e As EventArgs) Handles Btn_now.Click
        For i = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(i) Is TextBox Then GroupBox1.Controls(i).Text = ""
            If TypeOf GroupBox1.Controls(i) Is DateTimePicker Then GroupBox1.Controls(i).Text = New Date
        Next
        CheckBox1.Checked = False
        Text_code.Text = CODE_GEN("ITEMS", "ITEM_CODE") + 1
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
        ' ""قيود ادخال"""""""""""""""""""""""""""""""""""""""""""""""""""""""""""
        If Text_name.Text = "" Then
            Text_name.BackColor = Color.Red
            Text_name.Select()
        Else
            Text_name.BackColor = Color.White
            Text_name.Select()

            If Text_barcode.Text = "" Then
                Text_barcode.BackColor = Color.Red
                Text_barcode.Select()
            Else
                Text_barcode.BackColor = Color.Wheat
                Text_barcode.Select()

                If Val(Text_costprice.Text) > Val(Text_sellingprice.Text) Then
                    MessageBox.Show("سعر التكلفة اكبر من سعر البيع ", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                If Val(Text_costprice.Text) = Val(Text_sellingprice.Text) Then
                    MessageBox.Show("سعر التكلفة يساوي من سعر البيع ", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
        '----------------------------------------------------------------------------
        'code save------------------------------------------------------------------
        Dim dt As New DataTable


        Dim da As New SqlClient.SqlDataAdapter("SELECT * FROM ITEMS where ITEM_NAME = '" & Text_name.Text & "'  or ITEM_CODE = '" & Text_barcode.Text & "' ", Sqlcon)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            MessageBox.Show(" بيانات غير موجودة ", "Carta de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            dt.Rows.Add()
            Dim add_ As Integer = dt.Rows.Count - 1
            dt.Rows(add_).Item("ITEM_CODE") = Text_code.Text
            dt.Rows(add_).Item("ITEM_NAME") = Text_name.Text
            dt.Rows(add_).Item("ITEM_BAR") = Text_barcode.Text
            dt.Rows(add_).Item("ITEM_UNIT") = Text_unite.Text
            dt.Rows(add_).Item("ITEM_TKLFA") = Val(Text_costprice.Text)
            dt.Rows(add_).Item("ITEM_PRICE") = Val(Text_sellingprice.Text)
            dt.Rows(add_).Item("ITEM_Qntity") = Val(Text_qty.Text)
            dt.Rows(add_).Item("ITEM_EXPIRE") = DTP.Value
            dt.Rows(add_).Item("NOTES") = Text_notes.Text
            dt.Rows(add_).Item("ITEM_CHEACK") = CheckBox1.Checked



            Dim sav As New SqlClient.SqlCommandBuilder(da)
            da.Update(dt)
            dt.AcceptChanges()
            MessageBox.Show(" تم الحفظ بنجاح ", "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Btn_now_Click(sender, e)
        End If


    End Sub

    Private Sub Btn_edit_Click(sender As Object, e As EventArgs) Handles Btn_edit.Click

        ' ""قيود ادخال"""""""""""""""""""""""""""""""""""""""""""""""""""""""""""
        If Text_name.Text = "" Then
            Text_name.BackColor = Color.Red
            Text_name.Select()
        Else
            Text_name.BackColor = Color.White
            Text_name.Select()

            If Text_barcode.Text = "" Then
                Text_barcode.BackColor = Color.Red
                Text_barcode.Select()
            Else
                Text_barcode.BackColor = Color.Wheat
                Text_barcode.Select()

            End If
        End If
        '----------------------------------------------------------------------------
        ' إنشاء محول بيانات ومجموعة أوامر للعمل مع البيانات
        Dim dt As New DataTable
        Dim da As New SqlClient.SqlDataAdapter("SELECT * FROM ITEMS where ID = '" & Text_code.Text & "'", Sqlcon)
        da.Fill(dt)

        Dim cmdBuilder As New SqlClient.SqlCommandBuilder(da)

        If dt.Rows.Count = 0 Then
            MessageBox.Show("السجل غير موجود", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim updateRow As DataRow = dt.Rows(0) ' نفترض أنك تقوم بتحديث سجل واحد فقط
            updateRow("ITEM_CODE") = Text_code.Text
            updateRow("ITEM_NAME") = Text_name.Text
            updateRow("ITEM_BAR") = Text_barcode.Text
            updateRow("ITEM_UNIT") = Text_unite.Text
            updateRow("ITEM_TKLFA") = Val(Text_costprice.Text)
            updateRow("ITEM_PRICE") = Val(Text_sellingprice.Text)
            updateRow("ITEM_Qntity") = Val(Text_qty.Text)
            updateRow("ITEM_EXPIRE") = DTP.Value
            updateRow("NOTES") = Text_notes.Text
            updateRow("ITEM_CHEACK") = CheckBox1.Checked
            updateRow("ITEM_Qntity") = Text_qty.Text


            da.Update(dt)
            dt.AcceptChanges()

            MessageBox.Show("تم التحديث بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' اتصل بدالة أخرى أو قم بإجراءات إضافية بعد التحديث
            Btn_now_Click(sender, e)
        End If

    End Sub

    Private Sub Btn_delete_Click(sender As Object, e As EventArgs) Handles Btn_delete.Click
        Dim dt As New DataTable
        Dim da As New SqlClient.SqlDataAdapter("SELECT * FROM ITEMS where ITEM_CODE = '" & Text_code.Text & "'  or ITEM_BAR = '" & Text_barcode.Text & "' ", Sqlcon)
        da.Fill(dt)
        If dt.Rows.Count = 0 Then
            MessageBox.Show(" ITEMS غير موجود يرجى التاكد", "Carta de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UNITE_ADD.ShowDialog()

    End Sub



    Private Sub Text_unite_DropDown(sender As Object, e As EventArgs) Handles Text_unite.DropDown
        FILL_UNITE("SELECT * FROM UNITE")
    End Sub

    Private Sub Btn_Recherche_Click(sender As Object, e As EventArgs) Handles Btn_Recherche.Click
        Search_items.ShowDialog()
    End Sub

    Private Sub Btn_back_Click(sender As Object, e As EventArgs) Handles Btn_back.Click
        Main_Page.ShowDialog()

    End Sub
End Class