Public Class Customers

    Sub show_detait(ID_)
        Dim dt As New DataTable
        Dim da As New SqlClient.SqlDataAdapter("SELECT * FROM CUSTOMERS WHERE CUS_CODE = '" & ID_ & "'", Sqlcon)
        da.Fill(dt)
        If dt.Rows.Count = 0 Then
            MessageBox.Show("لا توجد بيانات ", " erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim show_ As Integer = BindingContext(dt).Position
            Text_code.Text = dt.Rows(show_).Item("CUS_CODE")
            Tex_name.Text = dt.Rows(show_).Item("CUS_NAME")
            Text_phone.Text = dt.Rows(show_).Item("CUS_PHONE")
            Text_adress.Text = dt.Rows(show_).Item("CUS_ADRESS")
            Text_notes.Text = dt.Rows(show_).Item("NOTES")
            Text_company.Text = dt.Rows(show_).Item("COMPANY")
            Text_debit.Text = dt.Rows(show_).Item("DEBIT")
            Text_credit.Text = dt.Rows(show_).Item("CREDIT")
            Btn_edit.Enabled = True
            Btn_delete.Enabled = True
            Btn_save.Enabled = False
        End If

    End Sub


    Private Sub Btn_now_Click(sender As Object, e As EventArgs) Handles Btn_now.Click
        '--------------------clean textbox in groupbox---------------
        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is TextBox Then GroupBox1.Controls(I).Text = ""
        Next
        For I = 0 To GroupBox2.Controls.Count - 1
            If TypeOf GroupBox2.Controls(I) Is TextBox Then GroupBox1.Controls(I).Text = ""
        Next
        '----------------------- الترقيم وتوماتيكي
        Text_code.Text = CODE_GEN("CUSTOMERS", "CUS_CODE") + 1

        Btn_delete.Enabled = False
        Btn_edit.Enabled = False
        Btn_save.Enabled = True
        Text_debit.Text = "0.000"
        Text_credit.Text = "0.000"
        Text_diff.Text = "0.000"
        Tex_name.Select()
        '=================
        Label11.Text = "Phone numbre :"
    End Sub

    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Btn_now_Click(sender, e)
        Label11.Text = "Phone numbre :"
    End Sub

    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles Btn_save.Click
        ' قيود ادخال----------------------------------------------------------------
        If Tex_name.Text = "" Then

            ErrorProvider1.SetError(Tex_name, "يرجى ادخال اسم الزبون")
            Tex_name.Select()
        Else
            ErrorProvider1.SetError(Tex_name, "")
            Tex_name.Select()

            If Text_phone.Text = "" Then
                ErrorProvider1.SetError(Text_phone, "يرجى ادخال رقم الزبون")
                Text_phone.Select()
            Else
                ErrorProvider1.SetError(Text_phone, "")

                '----------------------------------------------------------------------------
                'code save------------------------------------------------------------------
                Dim dt As New DataTable
                'code save------------------------------------------------------------------

                Dim da As New SqlClient.SqlDataAdapter("SELECT * FROM CUSTOMERS where CUS_NAME = '" & Tex_name.Text & "'  or CUS_PHONE = '" & Text_phone.Text & "' ", Sqlcon)
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    MessageBox.Show(" بيانات غير موجودة ", "Carta de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    dt.Rows.Add()
                    Dim add_ As Integer = dt.Rows.Count - 1
                    dt.Rows(add_).Item("CUS_CODE") = Text_code.Text
                    dt.Rows(add_).Item("CUS_NAME") = Tex_name.Text
                    dt.Rows(add_).Item("CUS_PHONE") = Text_phone.Text
                    dt.Rows(add_).Item("CUS_ADRESS") = Text_adress.Text
                    dt.Rows(add_).Item("NOTES") = Text_notes.Text
                    'dt.Rows(add_).Item("STATES") = True
                    dt.Rows(add_).Item("COMPANY") = Text_company.Text
                    dt.Rows(add_).Item("DEBIT") = Val(Text_debit.Text)
                    dt.Rows(add_).Item("CREDIT") = Val(Text_credit.Text)
                    Dim sav As New SqlClient.SqlCommandBuilder(da)
                    da.Update(dt)
                    dt.AcceptChanges()
                    MessageBox.Show(" تم الحفظ بنجاح ", "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Btn_now_Click(sender, e)
                End If
            End If
        End If
    End Sub

    Private Sub Btn_edit_Click(sender As Object, e As EventArgs) Handles Btn_edit.Click
        If Tex_name.Text = "" Then
            MessageBox.Show("يرجى إدخال اسم الزبون", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Tex_name.Select()
            Return
        End If

        If Text_phone.Text = "" Then
            MessageBox.Show("يرجى إدخال رقم هاتف الزبون", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Text_phone.Select()
            Return
        End If

        ' إنشاء محول بيانات ومجموعة أوامر للعمل مع البيانات
        Dim da As New SqlClient.SqlDataAdapter("SELECT * FROM CUSTOMERS WHERE CUS_CODE = '" & Text_code.Text & "'", Sqlcon)
        Dim cmdBuilder As New SqlClient.SqlCommandBuilder(da)

        Dim dt As New DataTable
        da.Fill(dt)

        If dt.Rows.Count = 0 Then
            MessageBox.Show("السجل غير موجود", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim updateRow As DataRow = dt.Rows(0) ' نفترض أنك تقوم بتحديث سجل واحد فقط
            updateRow("CUS_NAME") = Tex_name.Text
            updateRow("CUS_PHONE") = Text_phone.Text
            updateRow("CUS_ADRESS") = Text_adress.Text
            updateRow("NOTES") = Text_notes.Text
            'updateRow("STATES") = True
            updateRow("COMPANY") = Text_company.Text
            updateRow("DEBIT") = Val(Text_debit.Text)
            updateRow("CREDIT") = Val(Text_credit.Text)

            da.Update(dt)
            dt.AcceptChanges()

            MessageBox.Show("تم التحديث بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' اتصل بدالة أخرى أو قم بإجراءات إضافية بعد التحديث
            Btn_now_Click(sender, e)
        End If
    End Sub

    Private Sub Btn_delete_Click(sender As Object, e As EventArgs) Handles Btn_delete.Click

        If MessageBox.Show(" هل ترغب في الحذف", " رسالة تنبه", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then Exit Sub


        'code save------------------------------------------------------------------
        Dim dt As New DataTable
        Dim da As New SqlClient.SqlDataAdapter("SELECT * FROM CUSTOMERS where CUS_CODE = '" & Text_code.Text & "'", Sqlcon)
        da.Fill(dt)
        If dt.Rows.Count = 0 Then
            MessageBox.Show(" المورد غير موجود يرجى التاكد", "Carta de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim DELET_ As DataRow = dt.Rows(0)
            DELET_.Delete()
            Dim sav As New SqlClient.SqlCommandBuilder(da)
            da.Update(dt)
            dt.AcceptChanges()
            MessageBox.Show(" تم الحذف بنجاع ", "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Btn_now_Click(sender, e)

        End If
    End Sub

    Private Sub Btn_Recherche_Click(sender As Object, e As EventArgs) Handles Btn_Recherche.Click
        Searche_cus.ShowDialog()


    End Sub


End Class