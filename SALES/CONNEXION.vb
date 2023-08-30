Imports System.Data.SqlClient
Module CONNEXION
    Public Sqlcon As New SqlClient.SqlConnection

    '------------connexion to sqlserver-----------
    Public Sub Open_connexion()
        If Sqlcon.State = 1 Then Sqlcon.Close() 'Si una conexión está abierta, ciérrela
        Try
            Sqlcon = New SqlConnection(My.Settings.sqlcon1)
            Sqlcon.Open()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    '--------  numero    automatique -----------
    Public Function CODE_GEN(TbL_name, ID_) As Integer
        CODE_GEN = 0
        Dim dt As New DataTable
        Dim da As New SqlClient.SqlDataAdapter("SELECT * FROM " & TbL_name & " ORDER BY " & ID_, Sqlcon)
        da.Fill(dt)

        If dt.Rows.Count <> 0 Then
            Dim I = dt.Rows.Count - 1
            CODE_GEN = Val(dt.Rows(I).Item(ID_))
        End If

    End Function
    '------------ تعبئة  datagridview--------------
    Public Sub DGV_FILL(DGV As DataGridView, SQL As String)
        DGV.DataSource = ""
        Dim dt As New DataTable
        Dim da As New SqlClient.SqlDataAdapter(SQL, Sqlcon)
        da.Fill(dt)
        DGV.AutoGenerateColumns = False  ' تحدد له لي غيطلع فيه
        DGV.DataSource = dt.DefaultView ' ميمكنش تعدل عليه
    End Sub
End Module
