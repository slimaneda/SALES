Public Class SUPPLIERS




    Private Sub Butt_Now_Click(sender As Object, e As EventArgs) Handles Btn_now.Click
        '--------------------clean textbox in groupbox---------------
        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is TextBox Then GroupBox1.Controls(I).Text = ""
        Next
        For I = 0 To GroupBox2.Controls.Count - 1
            If TypeOf GroupBox2.Controls(I) Is TextBox Then GroupBox1.Controls(I).Text = ""
        Next
        '-----------------------numero automatique
        Text_code.Text = CODE_GEN("IMPORTERS", "ID") + 1
        Btn_back.Enabled = False
        Btn_delete.Enabled = False
        Btn_edit.Enabled = False
        Btn_save.Enabled = True
        Text_debit.Text = "0.000"
        Text_credit.Text = "0.000"
        Text_diff.Text = "0.000"
        Tex_name.Select()
    End Sub

    Private Sub SUPPLIERS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Butt_Now_Click(sender, e)
    End Sub

    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles Btn_save.Click
        ' قيود ادخال----------------------------------------------------------------
        If Tex_name.Text = "" Then
            MessageBox.Show("por favor escribe Nombre de proveedor ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Tex_name.Select()
            Exit Sub

        End If
        If Text_phone.Text = "" Then
            MessageBox.Show(" por favor escribe Título de proveedor ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Text_phone.Select()
            Exit Sub
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
            dt.Rows(add_).Item("STATES") = True
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
            MessageBox.Show("por favor escribe Nombre de proveedor ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Tex_name.Select()
            Exit Sub

        End If
        If Text_phone.Text = "" Then
            MessageBox.Show(" por favor escribe Título de proveedor ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Text_phone.Select()
            Exit Sub
        End If
        '----------------------------------------------------------------------------
        'code save------------------------------------------------------------------
        Dim dt As New DataTable
        Dim da As New SqlClient.SqlDataAdapter("SELECT * FROM IMPORTERS where IMP_CODE = '" & Text_code.Text & "' ", Sqlcon)
        da.Fill(dt)
        If dt.Rows.Count = 0 Then
            MessageBox.Show(" المورد غير موجود يرجى التاكد", "Carta de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'dt.Rows.Add()
            Dim update_ As Integer = BindingContext(dt).Position
            dt.Rows(update_).Item("IMP_CODE") = Text_code.Text
            dt.Rows(update_).Item("IMP_NAME") = Tex_name.Text
            dt.Rows(update_).Item("IMP_PHONE") = Text_phone.Text
            dt.Rows(update_).Item("IMP_ADRESS") = Text_adress.Text
            dt.Rows(update_).Item("NOTES") = Text_notes.Text
            dt.Rows(update_).Item("STATES") = True
            dt.Rows(update_).Item("COMPANY") = Text_company.Text
            dt.Rows(update_).Item("DEBIT") = Val(Text_debit.Text)
            dt.Rows(update_).Item("CREDIT") = Val(Text_credit.Text)
            da.Update(dt)
            dt.AcceptChanges()
            MessageBox.Show(" تم تعديل بنجاع ", "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Butt_Now_Click(sender, e)
        End If
    End Sub

    Private Sub Btn_delete_Click(sender As Object, e As EventArgs) Handles Btn_delete.Click

        If MessageBox.Show(" هل ترغب في الحذف", " رسالة تنبه", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then Exit Sub


        'code save------------------------------------------------------------------
        Dim dt As New DataTable
        Dim da As New SqlClient.SqlDataAdapter("SELECT * FROM IMPORTERS where IMP_CODE = '" & Text_code.Text & "'", Sqlcon)
        da.Fill(dt)
        If dt.Rows.Count = 0 Then
            MessageBox.Show(" المورد غير موجود يرجى التاكد", "Carta de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'dt.Rows.Add()
            Dim update_ As Integer = BindingContext(dt).Position
            Dim sav As New SqlClient.SqlCommandBuilder(da)
            da.Update(dt)
            dt.AcceptChanges()
            MessageBox.Show(" تم الحذف بنجاع ", "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Butt_Now_Click(sender, e)
        End If
    End Sub

    Private Sub Btn_back_Click(sender As Object, e As EventArgs) Handles Btn_back.Click
        Me.Close()

    End Sub

    Private Sub Btn_Recherche_Click(sender As Object, e As EventArgs) Handles Btn_Recherche.Click
        Try
            Dim dt As New DataTable
            Dim rech As Integer = BindingContext(dt).Position
            Text_code.Text = dt.Rows(rech).Item("IMP_CODE")
            Tex_name.Text = dt.Rows(rech).Item("IMP_NAME")
            Text_phone.Text = dt.Rows(rech).Item("IMP_PHONE")
            Text_adress.Text = dt.Rows(rech).Item("IMP_ADRESS")
            Text_notes.Text = dt.Rows(rech).Item("NOTES")
            Text_company.Text = dt.Rows(rech).Item("COMPANY")
            Text_debit.Text = dt.Rows(rech).Item("DEBIT")
            Text_credit.Text = dt.Rows(rech).Item("CREDIT")

        Catch ex As Exception

        End Try
    End Sub
End Class