﻿Public Class Main_Page
    Private Sub Main_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Open_connexion()
        Panel3.Location = New Point(160, 117)

    End Sub
    Public Sub switchpanel(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()




    End Sub

    Private Sub btn_supplier_Click(sender As Object, e As EventArgs) Handles btn_supplier.Click
        switchpanel(SUPPLIERS)

        Panel3.Location = New Point(160, 161)
    End Sub

    Private Sub btn_purchases_Click(sender As Object, e As EventArgs) Handles btn_purchases.Click
        switchpanel(BUBILL)
        Panel3.Location = New Point(160, 205)

    End Sub

    Private Sub btn_customers_Click(sender As Object, e As EventArgs) Handles btn_customers.Click
        switchpanel(Customers)
        Panel3.Location = New Point(160, 247)

    End Sub

    Private Sub btn_items_Click(sender As Object, e As EventArgs) Handles btn_items.Click
        switchpanel(ITEMS)
        Panel3.Location = New Point(160, 288)
    End Sub

    Private Sub btn_accuel_Click(sender As Object, e As EventArgs) Handles btn_accuel.Click
        Panel2.Controls.Clear()
        Panel3.Location = New Point(160, 117)
    End Sub
End Class
