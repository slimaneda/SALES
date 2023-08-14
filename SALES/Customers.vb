Public Class Customers
    Private Sub Btn_back_Click(sender As Object, e As EventArgs) Handles Btn_back.Click

        Me.Hide()
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
        Text_code.Text = CODE_GEN("CUSTOMERS", "ID") + 1
        Btn_back.Enabled = False
        Btn_delete.Enabled = False
        Btn_edit.Enabled = False
        Btn_save.Enabled = True
        Text_debit.Text = "0.000"
        Text_credit.Text = "0.000"
        Text_diff.Text = "0.000"
        Tex_name.Select()
    End Sub
End Class