Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class BUBILL


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




        Text_code.Text = CODE_GEN("BUY_DET", "ID") + 1
        'DataGridView1.DataSource = ""
        Btn_back.Enabled = True
        Btn_delete.Enabled = False
        Btn_edit.Enabled = False
        Btn_save.Enabled = True
        Text_type.SelectedIndex = 0
        Text_barcode.Select()

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
            dt.Rows(add_).Item("BUYTYPE") = Text_type.Text
            dt.Rows(add_).Item("IMPORTERNAME") = Text_importname.Text
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




    Private Sub Btn_back_Click(sender As Object, e As EventArgs) Handles Btn_back.Click
        Me.Hide()
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

                'Text_barcode.Clear()
            End If
        End If
    End Sub



    Private Sub Btn_now_Click(sender As Object, e As EventArgs) Handles Btn_now.Click
        bar()
    End Sub
End Class