<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customers
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Customers))
        Label6 = New Label()
        GroupBox2 = New GroupBox()
        Text_diff = New TextBox()
        Label9 = New Label()
        Text_credit = New TextBox()
        Label8 = New Label()
        Text_debit = New TextBox()
        Label7 = New Label()
        Text_notes = New TextBox()
        Text_company = New TextBox()
        Label4 = New Label()
        Text_adress = New TextBox()
        Label3 = New Label()
        Tex_name = New TextBox()
        Label2 = New Label()
        Text_code = New TextBox()
        Label1 = New Label()
        Text_phone = New TextBox()
        GroupBox1 = New GroupBox()
        Label11 = New Label()
        ToolTip1 = New ToolTip(components)
        Btn_Recherche = New Button()
        Btn_back = New Button()
        Btn_delete = New Button()
        Btn_edit = New Button()
        Btn_save = New Button()
        Btn_now = New Button()
        GroupBox3 = New GroupBox()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(441, 174)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 21)
        Label6.TabIndex = 10
        Label6.Text = "Notes :" & vbCrLf
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Text_diff)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Text_credit)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Text_debit)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Location = New Point(0, 238)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(871, 84)
        GroupBox2.TabIndex = 12
        GroupBox2.TabStop = False
        GroupBox2.Text = "Movimiento de cuenta :"
        ' 
        ' Text_diff
        ' 
        Text_diff.BackColor = Color.White
        Text_diff.Location = New Point(685, 38)
        Text_diff.Name = "Text_diff"
        Text_diff.ReadOnly = True
        Text_diff.Size = New Size(166, 29)
        Text_diff.TabIndex = 18
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(574, 41)
        Label9.Name = "Label9"
        Label9.Size = New Size(88, 21)
        Label9.TabIndex = 17
        Label9.Text = "Difference :" & vbCrLf
        ' 
        ' Text_credit
        ' 
        Text_credit.BackColor = Color.White
        Text_credit.ForeColor = SystemColors.MenuHighlight
        Text_credit.Location = New Point(388, 38)
        Text_credit.Name = "Text_credit"
        Text_credit.ReadOnly = True
        Text_credit.Size = New Size(166, 29)
        Text_credit.TabIndex = 16
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(295, 41)
        Label8.Name = "Label8"
        Label8.Size = New Size(59, 21)
        Label8.TabIndex = 15
        Label8.Text = "Credit :" & vbCrLf
        ' 
        ' Text_debit
        ' 
        Text_debit.BackColor = Color.White
        Text_debit.ForeColor = Color.Green
        Text_debit.Location = New Point(103, 38)
        Text_debit.Name = "Text_debit"
        Text_debit.ReadOnly = True
        Text_debit.Size = New Size(166, 29)
        Text_debit.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(10, 41)
        Label7.Name = "Label7"
        Label7.Size = New Size(54, 21)
        Label7.TabIndex = 13
        Label7.Text = "Debit :" & vbCrLf
        ' 
        ' Text_notes
        ' 
        Text_notes.Location = New Point(545, 135)
        Text_notes.Multiline = True
        Text_notes.Name = "Text_notes"
        Text_notes.Size = New Size(263, 97)
        Text_notes.TabIndex = 11
        ' 
        ' Text_company
        ' 
        Text_company.Location = New Point(127, 90)
        Text_company.Name = "Text_company"
        Text_company.Size = New Size(220, 29)
        Text_company.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(10, 93)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 21)
        Label4.TabIndex = 6
        Label4.Text = "Adress :" & vbCrLf
        ' 
        ' Text_adress
        ' 
        Text_adress.Location = New Point(143, 138)
        Text_adress.Name = "Text_adress"
        Text_adress.Size = New Size(263, 29)
        Text_adress.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(10, 138)
        Label3.Name = "Label3"
        Label3.Size = New Size(127, 21)
        Label3.TabIndex = 4
        Label3.Text = "Company name :" & vbCrLf
        ' 
        ' Tex_name
        ' 
        Tex_name.Location = New Point(469, 44)
        Tex_name.Name = "Tex_name"
        Tex_name.Size = New Size(345, 29)
        Tex_name.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(295, 42)
        Label2.Name = "Label2"
        Label2.Size = New Size(161, 21)
        Label2.TabIndex = 2
        Label2.Text = "Name  the Customer :"
        ' 
        ' Text_code
        ' 
        Text_code.Location = New Point(127, 44)
        Text_code.Name = "Text_code"
        Text_code.Size = New Size(88, 29)
        Text_code.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(10, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 21)
        Label1.TabIndex = 0
        Label1.Text = "Code Customer:" & vbCrLf
        ' 
        ' Text_phone
        ' 
        Text_phone.Location = New Point(545, 90)
        Text_phone.Name = "Text_phone"
        Text_phone.Size = New Size(269, 29)
        Text_phone.TabIndex = 15
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Text_phone)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(GroupBox2)
        GroupBox1.Controls.Add(Text_notes)
        GroupBox1.Controls.Add(Text_company)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Text_adress)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Tex_name)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Text_code)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(7, 8)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(871, 322)
        GroupBox1.TabIndex = 8
        GroupBox1.TabStop = False
        GroupBox1.Text = "Basic Information:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(419, 93)
        Label11.Name = "Label11"
        Label11.Size = New Size(120, 21)
        Label11.TabIndex = 14
        Label11.Text = "Phone numbre :" & vbCrLf
        ' 
        ' Btn_Recherche
        ' 
        Btn_Recherche.Image = CType(resources.GetObject("Btn_Recherche.Image"), Image)
        Btn_Recherche.ImageAlign = ContentAlignment.MiddleRight
        Btn_Recherche.Location = New Point(618, 18)
        Btn_Recherche.Name = "Btn_Recherche"
        Btn_Recherche.Size = New Size(117, 34)
        Btn_Recherche.TabIndex = 5
        Btn_Recherche.Text = "Buscar"
        ToolTip1.SetToolTip(Btn_Recherche, "back")
        Btn_Recherche.UseVisualStyleBackColor = True
        ' 
        ' Btn_back
        ' 
        Btn_back.Image = CType(resources.GetObject("Btn_back.Image"), Image)
        Btn_back.ImageAlign = ContentAlignment.MiddleRight
        Btn_back.Location = New Point(498, 18)
        Btn_back.Name = "Btn_back"
        Btn_back.Size = New Size(117, 34)
        Btn_back.TabIndex = 4
        Btn_back.Text = "Atrás"
        ToolTip1.SetToolTip(Btn_back, "back")
        Btn_back.UseVisualStyleBackColor = True
        ' 
        ' Btn_delete
        ' 
        Btn_delete.Image = CType(resources.GetObject("Btn_delete.Image"), Image)
        Btn_delete.ImageAlign = ContentAlignment.MiddleRight
        Btn_delete.Location = New Point(375, 18)
        Btn_delete.Name = "Btn_delete"
        Btn_delete.Size = New Size(117, 34)
        Btn_delete.TabIndex = 3
        Btn_delete.Text = "Borrar"
        ToolTip1.SetToolTip(Btn_delete, "delete")
        Btn_delete.UseVisualStyleBackColor = True
        ' 
        ' Btn_edit
        ' 
        Btn_edit.BackgroundImageLayout = ImageLayout.Center
        Btn_edit.Image = CType(resources.GetObject("Btn_edit.Image"), Image)
        Btn_edit.ImageAlign = ContentAlignment.MiddleRight
        Btn_edit.Location = New Point(252, 18)
        Btn_edit.Name = "Btn_edit"
        Btn_edit.Size = New Size(117, 34)
        Btn_edit.TabIndex = 2
        Btn_edit.Text = "Enmienda    "
        ToolTip1.SetToolTip(Btn_edit, "Update")
        Btn_edit.UseVisualStyleBackColor = True
        ' 
        ' Btn_save
        ' 
        Btn_save.Image = CType(resources.GetObject("Btn_save.Image"), Image)
        Btn_save.ImageAlign = ContentAlignment.MiddleRight
        Btn_save.Location = New Point(129, 18)
        Btn_save.Name = "Btn_save"
        Btn_save.Size = New Size(117, 34)
        Btn_save.TabIndex = 1
        Btn_save.Text = "Memoriza   "
        ToolTip1.SetToolTip(Btn_save, "SAVE")
        Btn_save.UseVisualStyleBackColor = True
        ' 
        ' Btn_now
        ' 
        Btn_now.Image = CType(resources.GetObject("Btn_now.Image"), Image)
        Btn_now.ImageAlign = ContentAlignment.MiddleRight
        Btn_now.Location = New Point(6, 18)
        Btn_now.Name = "Btn_now"
        Btn_now.Size = New Size(117, 34)
        Btn_now.TabIndex = 0
        Btn_now.Text = "Nuevo"
        ToolTip1.SetToolTip(Btn_now, "ADD")
        Btn_now.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Btn_Recherche)
        GroupBox3.Controls.Add(Btn_back)
        GroupBox3.Controls.Add(Btn_delete)
        GroupBox3.Controls.Add(Btn_edit)
        GroupBox3.Controls.Add(Btn_save)
        GroupBox3.Controls.Add(Btn_now)
        GroupBox3.Location = New Point(64, 328)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(748, 69)
        GroupBox3.TabIndex = 7
        GroupBox3.TabStop = False
        ' 
        ' Customers
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(885, 404)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox3)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "Customers"
        Text = "Customers"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Text_diff As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Text_credit As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Text_debit As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Text_notes As TextBox
    Friend WithEvents Text_company As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Text_adress As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Tex_name As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Text_code As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Text_phone As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Btn_Recherche As Button
    Friend WithEvents Btn_back As Button
    Friend WithEvents Btn_delete As Button
    Friend WithEvents Btn_edit As Button
    Friend WithEvents Btn_save As Button
    Friend WithEvents Btn_now As Button
    Friend WithEvents GroupBox3 As GroupBox
End Class
