Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class BUBILL

    Sub calc()
        For i = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(i).Cells(6).Value = Val(DataGridView1.Rows(i).Cells(3).Value) * Val(DataGridView1.Rows(i).Cells(4).Value)

        Next
        Dim total_, descount_, qty_ As Double
        For i = 0 To DataGridView1.Rows.Count - 1
            total_ = Val(total_) + Val(DataGridView1.Rows(i).Cells(6).Value)
            descount_ = Val(descount_) + Val(DataGridView1.Rows(i).Cells(5).Value)
            qty_ = Val(qty_) + Val(DataGridView1.Rows(i).Cells(4).Value)
        Next

        Text_total.Text = Val(total_) - Val(descount_)
        Text_discount.Text = Val(descount_)
        Text_totalqty.Text = Val(qty_)

    End Sub

    Private Sub Btn_new_Click(sender As Object, e As EventArgs) Handles Btn_new.Click
        For i = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(i) Is TextBox Then GroupBox1.Controls(i).Text = ""
            If TypeOf GroupBox1.Controls(i) Is DateTimePicker Then GroupBox1.Controls(i).Text = New Date

        Next
        For i = 0 To GroupBox2.Controls.Count - 1
            If TypeOf GroupBox2.Controls(i) Is TextBox Then GroupBox1.Controls(i).Text = ""
        Next
        For i = 0 To GroupBox4.Controls.Count - 1
            If TypeOf GroupBox4.Controls(i) Is TextBox Then GroupBox1.Controls(i).Text = ""
        Next




        Text_code.Text = CODE_GEN("BUY_DET", "BUYCODE") + 1
        'DataGridView1.DataSource ="" 

        Btn_delete.Enabled = False
        Btn_edit.Enabled = False
        Btn_save.Enabled = True
        Text_type.SelectedIndex = 0
        Text_barcode.Select()
        Label6.Text = "Supplier"

    End Sub
    '------- supplier جلب ----------------------------------------------
    Sub fill_importers()
        Text_importname.Text = ""
        Dim dt As New DataTable
        Dim da As New SqlClient.SqlDataAdapter("SELECT * FROM IMPORTERS", Sqlcon)
        da.Fill(dt)
        For i = 0 To dt.Rows.Count - 1
            Text_importname.Items.Add(dt.Rows(i).Item("IMP_NAME"))
        Next
    End Sub
    '---------------------------------------------------------------------
    Private Sub BUBILL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Btn_new_Click(sender, e)
        fill_importers()
        Label6.Text = "Supplier"

    End Sub

    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles Btn_save.Click
        '------------ قيود ادخال
        If Text_importname.SelectedIndex < 0 Then
            MessageBox.Show("المرجوا اختار المورد", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Text_importname.Select()

            Exit Sub
        End If
        If Text_type.SelectedIndex < 0 Then
            MessageBox.Show("المرجوا اختار نوع الفكتورة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Text_type.Select()
            Exit Sub

        End If

        '===================== save Entete facture===============
        Dim dt As New DataTable
        Dim da As New SqlClient.SqlDataAdapter("SELECT * FROM BUY_DET WHERE BUYCODE = '" & Text_code.Text & "'", Sqlcon)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Text_code.Text = CODE_GEN("BUY_DET", "id") + 1
        Else
            dt.Rows.Add()
            Dim add_ As Integer = dt.Rows.Count - 1


            dt.Rows(add_).Item("BUYCODE") = Text_code.Text
            dt.Rows(add_).Item("BUYUSER") = Text_employee.Text
            dt.Rows(add_).Item("BUYTYPE") = Text_type.Text
            dt.Rows(add_).Item("IMPORTNAME") = Text_importname.Text
            dt.Rows(add_).Item("BUYDATE") = DTP.Value

            dt.Rows(add_).Item("NOTES") = Text_notes.Text
            dt.Rows(add_).Item("DISCOUNT") = Convert.ToDecimal(Text_discount.Text)


            dt.Rows(add_).Item("TOTAL") = Convert.ToDecimal(Text_total.Text)
            dt.Rows(add_).Item("TOTALARABIC") = Convert.ToDecimal(Text_TOTALARABIC.Text)
            dt.Rows(add_).Item("TOTALQTY") = Val(Text_totalqty.Text)
            'Dr!BUYUSER = Text_code.Text

            Dim sav As New SqlClient.SqlCommandBuilder(da)
            da.Update(dt)
            dt.AcceptChanges()
            MessageBox.Show("save reusite", "info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Btn_new_Click(sender, e)

        End If
    End Sub








    Private Sub bar()

        If Not String.IsNullOrWhiteSpace(Text_barcode.Text) Then
            Dim dt As New DataTable

            Dim da As New SqlClient.SqlDataAdapter("SELECT * FROM ITEMS WHERE ITEM_BAR LIKE '" & Text_barcode.Text & "'", Sqlcon)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Dim itemCode As String = dt.Rows(0).Item("ITEM_CODE").ToString()

                For i As Integer = 0 To DataGridView1.Rows.Count - 1
                    If DataGridView1.Rows(i).Cells(0).Value.ToString() = itemCode Then
                        DataGridView1.Rows(i).Cells(4).Value = CInt(DataGridView1.Rows(i).Cells(4).Value) + 1
                        calc()
                        'Text_barcode.Clear()
                        Exit Sub
                    End If
                Next
                ' إضافة سطر جديد إلى DataGridView
                DataGridView1.Rows.Add()
                Dim ADD_ As Integer = DataGridView1.Rows.Count - 1
                DataGridView1(0, ADD_).Value = dt.Rows(0).Item("ITEM_CODE")

                ' DataGridView1(0, ADD_).Value = dt.Rows(0).Item("ITEM_CODE")
                DataGridView1(1, ADD_).Value = dt.Rows(0).Item("ITEM_NAME")
                DataGridView1(2, ADD_).Value = dt.Rows(0).Item("ITEM_UNIT")
                DataGridView1(3, ADD_).Value = dt.Rows(0).Item("ITEM_TKLFA")
                DataGridView1(4, ADD_).Value = 1
                calc()
                ' DataGridView1.DataSource = DT.DefaultView
                ' Text_barcode.Clear()
            End If
        End If
        Text_barcode.Clear()
        Text_barcode.Select()


        calc()

    End Sub





    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit the program?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click


        Text_TOTALARABIC.Text = NumberToString(Text_total.Text, use_us_group_names:=True)



    End Sub

    Private Sub Text_total_TextChanged(sender As Object, e As EventArgs) Handles Text_total.TextChanged
        Text_TOTALARABIC.Text = NumberToString(Text_total.Text, use_us_group_names:=True)

    End Sub

    Private Sub Text_barcode_TextChanged(sender As Object, e As EventArgs) Handles Text_barcode.TextChanged
        bar()
    End Sub

    Private Sub Btn_now_Click(sender As Object, e As EventArgs) Handles Btn_now.Click
        bar()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        calc()

    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        calc()
    End Sub
End Class