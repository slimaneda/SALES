Public Class Main_Page
    Private Sub Main_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Open_connexion()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SUPPLIERS.ShowDialog()
        Me.Hide()
    End Sub
End Class
