Public Class SUPPLIERS



    Sub show_detait(ID_)
        Dim dt As New DataTable
        Dim da As New SqlClient.SqlDataAdapter("SELECT * FROM IMPORTERS WHERE IMP_CODE = '" & ID_ & "'", Sqlcon)
        da.Fill(dt)
        If dt.Rows.Count = 0 Then
            MessageBox.Show("لا توجد بيانات ", " erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim show_ As Integer = BindingContext(dt).Position
            Text_code.Text = dt.Rows(show_).Item("IMP_CODE")
            Tex_name.Text = dt.Rows(show_).Item("IMP_NAME")
            Text_phone.Text = dt.Rows(show_).Item("IMP_PHONE")
            Text_adress.Text = dt.Rows(show_).Item("IMP_ADRESS")
            Text_notes.Text = dt.Rows(show_).Item("NOTES")
            Text_company.Text = dt.Rows(show_).Item("COMPANY")
            Text_debit.Text = dt.Rows(show_).Item("DEBIT")
            Text_credit.Text = dt.Rows(show_).Item("CREDIT")
            Btn_edit.Enabled = True
            Btn_delete.Enabled = True
            Btn_save.Enabled = False
        End If

    End Sub

    Private Sub Butt_Now_Click(sender As Object, e As EventArgs) Handles Btn_now.Click
        '--------------------clean textbox in groupbox---------------
        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is TextBox Then GroupBox1.Controls(I).Text = ""
        Next
        For I = 0 To GroupBox2.Controls.Count - 1
            If TypeOf GroupBox2.Controls(I) Is TextBox Then GroupBox1.Controls(I).Text = ""
        Next
        '-----------------------numero automatique
        Text_code.Text = CODE_GEN("IMPORTERS", "IMP_CODE") + 1

        Btn_delete.Enabled = False
        Btn_edit.Enabled = False
        Btn_save.Enabled = True
        Text_debit.Text = "0.000"
        Text_credit.Text = "0.000"
        Text_diff.Text = "0.000"
        Tex_name.Select()
        '======== proble no shew lable=========
        Label11.Text = "Phone numbre :"
        Label5.Text = "Notes :"
    End Sub

    Private Sub SUPPLIERS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Butt_Now_Click(sender, e)
        Label11.Text = "Phone numbre :"
        Label5.Text = "Notes :"
    End Sub

    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles Btn_save.Click
        ' قيود ادخال----------------------------------------------------------------
        If Tex_name.Text = "" Then
            MessageBox.Show("por favor escribe Nombre de proveedor ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Tex_name.Select()
            Exit Sub


            If Text_phone.Text = "" Then
                MessageBox.Show(" por favor escribe Título de proveedor ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Text_phone.Select()
                Exit Sub
            End If
        End If
        '----------------------------------------------------------------------------
        'code save------------------------------------------------------------------
        Dim dt As New DataTable
                Dim da As New SqlClient.SqlDataAdapter("SELECT * FROM IMPORTERS where IMP_NAME = '" & Tex_name.Text & "'  or IMP_PHONE = '" & Text_phone.Text & "' ", Sqlcon)
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    MessageBox.Show(" El recurso ya existe ", "Carta de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    dt.Rows.Add()
                    Dim add_ As Integer = dt.Rows.Count - 1
                    dt.Rows(add_).Item("IMP_CODE") = Text_code.Text
                    dt.Rows(add_).Item("IMP_NAME") = Tex_name.Text
                    dt.Rows(add_).Item("IMP_PHONE") = Text_phone.Text
                    dt.Rows(add_).Item("IMP_ADRESS") = Text_adress.Text
                    dt.Rows(add_).Item("NOTES") = Text_notes.Text
                    'dt.Rows(add_).Item("STATE") = True
                    dt.Rows(add_).Item("COMPANY") = Text_company.Text
                    dt.Rows(add_).Item("DEBIT") = Val(Text_debit.Text)
                    dt.Rows(add_).Item("CREDIT") = Val(Text_credit.Text)
                    Dim sav As New SqlClient.SqlCommandBuilder(da)
                    da.Update(dt)
                    dt.AcceptChanges()
                    MessageBox.Show(" Agregado exitosamente ", "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Butt_Now_Click(sender, e)
                End If

    End Sub

    Private Sub Btn_edit_Click(sender As Object, e As EventArgs) Handles Btn_edit.Click
        If Tex_name.Text = "" Then
            MessageBox.Show("يرجى إدخال اسم المورد", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Tex_name.Select()
            Return
        End If

        If Text_phone.Text = "" Then
            MessageBox.Show("يرجى إدخال رقم هاتف المورد", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Text_phone.Select()
            Return
        End If

        ' إنشاء محول بيانات ومجموعة أوامر للعمل مع البيانات
        Dim da As New SqlClient.SqlDataAdapter("SELECT * FROM IMPORTERS WHERE IMP_CODE = '" & Text_code.Text & "'", Sqlcon)
        Dim cmdBuilder As New SqlClient.SqlCommandBuilder(da)

        Dim dt As New DataTable
        da.Fill(dt)

        If dt.Rows.Count = 0 Then
            MessageBox.Show("السجل غير موجود", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim updateRow As DataRow = dt.Rows(0) ' نفترض أنك تقوم بتحديث سجل واحد فقط
            updateRow("IMP_NAME") = Tex_name.Text
            updateRow("IMP_PHONE") = Text_phone.Text
            updateRow("IMP_ADRESS") = Text_adress.Text
            updateRow("NOTES") = Text_notes.Text

            updateRow("COMPANY") = Text_company.Text
            updateRow("DEBIT") = Val(Text_debit.Text)
            updateRow("CREDIT") = Val(Text_credit.Text)

            da.Update(dt)
            dt.AcceptChanges()

            MessageBox.Show("تم التحديث بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' اتصل بدالة أخرى أو قم بإجراءات إضافية بعد التحديث
            Butt_Now_Click(sender, e)
        End If
    End Sub

    Private Sub Btn_delete_Click(sender As Object, e As EventArgs) Handles Btn_delete.Click

        If MessageBox.Show(" هل ترغب في الحذف", " رسالة تنبه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then Exit Sub


        'code save------------------------------------------------------------------
        Dim dt As New DataTable
        Dim da As New SqlClient.SqlDataAdapter("SELECT * FROM IMPORTERS where IMP_CODE = '" & Text_code.Text & "'", Sqlcon)
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
            Butt_Now_Click(sender, e)

        End If
    End Sub



    Private Sub Btn_Recherche_Click(sender As Object, e As EventArgs) Handles Btn_Recherche.Click

        Search_sup.StartPosition = FormStartPosition.CenterParent
        Search_sup.ShowDialog()



    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit the program?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If


    End Sub
End Class