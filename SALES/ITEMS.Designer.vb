<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ITEMS
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(ITEMS))
        GroupBox1 = New GroupBox()
        Text_unite = New ComboBox()
        Button1 = New Button()
        Text_qty = New TextBox()
        Label7 = New Label()
        GroupBox3 = New GroupBox()
        CheckBox2 = New CheckBox()
        Btn_Recherche = New Button()
        Btn_back = New Button()
        Btn_delete = New Button()
        Btn_edit = New Button()
        Btn_save = New Button()
        Btn_now = New Button()
        DTP = New DateTimePicker()
        Label10 = New Label()
        CheckBox1 = New CheckBox()
        Text_sellingprice = New TextBox()
        Label5 = New Label()
        Label11 = New Label()
        Label6 = New Label()
        Text_notes = New TextBox()
        Text_barcode = New TextBox()
        Label4 = New Label()
        Text_costprice = New TextBox()
        Label3 = New Label()
        Text_name = New TextBox()
        Label2 = New Label()
        Text_code = New TextBox()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ButtonFace
        GroupBox1.Controls.Add(CheckBox2)
        GroupBox1.Controls.Add(Text_unite)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(Text_qty)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(GroupBox3)
        GroupBox1.Controls.Add(DTP)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(CheckBox1)
        GroupBox1.Controls.Add(Text_sellingprice)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Text_notes)
        GroupBox1.Controls.Add(Text_barcode)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Text_costprice)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Text_name)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Text_code)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Enabled = False
        GroupBox1.Location = New Point(4, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(869, 330)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "Basic Information:"
        ' 
        ' Text_unite
        ' 
        Text_unite.BackColor = SystemColors.InactiveBorder
        Text_unite.Enabled = False
        Text_unite.FlatStyle = FlatStyle.Popup
        Text_unite.FormattingEnabled = True
        Text_unite.Location = New Point(475, 90)
        Text_unite.Name = "Text_unite"
        Text_unite.Size = New Size(266, 29)
        Text_unite.TabIndex = 23
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ButtonFace
        Button1.BackgroundImageLayout = ImageLayout.Center
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.MiddleRight
        Button1.Location = New Point(747, 90)
        Button1.Name = "Button1"
        Button1.Size = New Size(27, 29)
        Button1.TabIndex = 22
        Button1.Text = " "
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Text_qty
        ' 
        Text_qty.Location = New Point(155, 189)
        Text_qty.Name = "Text_qty"
        Text_qty.Size = New Size(263, 29)
        Text_qty.TabIndex = 8
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(8, 192)
        Label7.Name = "Label7"
        Label7.Size = New Size(141, 21)
        Label7.TabIndex = 21
        Label7.Text = "Available quantity :"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Btn_Recherche)
        GroupBox3.Controls.Add(Btn_back)
        GroupBox3.Controls.Add(Btn_delete)
        GroupBox3.Controls.Add(Btn_edit)
        GroupBox3.Controls.Add(Btn_save)
        GroupBox3.Controls.Add(Btn_now)
        GroupBox3.Location = New Point(60, 274)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(748, 69)
        GroupBox3.TabIndex = 10
        GroupBox3.TabStop = False
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox2.Location = New Point(545, 259)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(15, 14)
        CheckBox2.TabIndex = 21
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' Btn_Recherche
        ' 
        Btn_Recherche.Image = CType(resources.GetObject("Btn_Recherche.Image"), Image)
        Btn_Recherche.ImageAlign = ContentAlignment.MiddleRight
        Btn_Recherche.Location = New Point(618, 18)
        Btn_Recherche.Name = "Btn_Recherche"
        Btn_Recherche.Size = New Size(117, 34)
        Btn_Recherche.TabIndex = 15
        Btn_Recherche.Text = "Buscar"
        Btn_Recherche.UseVisualStyleBackColor = True
        ' 
        ' Btn_back
        ' 
        Btn_back.Image = CType(resources.GetObject("Btn_back.Image"), Image)
        Btn_back.ImageAlign = ContentAlignment.MiddleRight
        Btn_back.Location = New Point(498, 18)
        Btn_back.Name = "Btn_back"
        Btn_back.Size = New Size(117, 34)
        Btn_back.TabIndex = 14
        Btn_back.Text = "Atrás"
        Btn_back.UseVisualStyleBackColor = True
        ' 
        ' Btn_delete
        ' 
        Btn_delete.Image = CType(resources.GetObject("Btn_delete.Image"), Image)
        Btn_delete.ImageAlign = ContentAlignment.MiddleRight
        Btn_delete.Location = New Point(375, 18)
        Btn_delete.Name = "Btn_delete"
        Btn_delete.Size = New Size(117, 34)
        Btn_delete.TabIndex = 14
        Btn_delete.Text = "Borrar"
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
        Btn_edit.TabIndex = 3
        Btn_edit.Text = "Enmienda    "
        Btn_edit.UseVisualStyleBackColor = True
        ' 
        ' Btn_save
        ' 
        Btn_save.Image = CType(resources.GetObject("Btn_save.Image"), Image)
        Btn_save.ImageAlign = ContentAlignment.MiddleRight
        Btn_save.Location = New Point(129, 18)
        Btn_save.Name = "Btn_save"
        Btn_save.Size = New Size(117, 34)
        Btn_save.TabIndex = 12
        Btn_save.Text = "Memoriza   "
        Btn_save.UseVisualStyleBackColor = True
        ' 
        ' Btn_now
        ' 
        Btn_now.Image = CType(resources.GetObject("Btn_now.Image"), Image)
        Btn_now.ImageAlign = ContentAlignment.MiddleRight
        Btn_now.Location = New Point(6, 18)
        Btn_now.Name = "Btn_now"
        Btn_now.Size = New Size(117, 34)
        Btn_now.TabIndex = 11
        Btn_now.Text = "Nuevo"
        Btn_now.UseVisualStyleBackColor = True
        ' 
        ' DTP
        ' 
        DTP.Format = DateTimePickerFormat.Custom
        DTP.Location = New Point(113, 243)
        DTP.Name = "DTP"
        DTP.Size = New Size(204, 29)
        DTP.TabIndex = 9
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(10, 250)
        Label10.Name = "Label10"
        Label10.Size = New Size(59, 21)
        Label10.TabIndex = 19
        Label10.Text = "Expire :"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(544, 228)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(264, 25)
        CheckBox1.TabIndex = 10
        CheckBox1.Text = "Show the item on the sales screen"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Text_sellingprice
        ' 
        Text_sellingprice.Location = New Point(111, 151)
        Text_sellingprice.Name = "Text_sellingprice"
        Text_sellingprice.Size = New Size(263, 29)
        Text_sellingprice.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(8, 154)
        Label5.Name = "Label5"
        Label5.Size = New Size(102, 21)
        Label5.TabIndex = 16
        Label5.Text = "Selling price :"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(415, 93)
        Label11.Name = "Label11"
        Label11.Size = New Size(54, 21)
        Label11.TabIndex = 14
        Label11.Text = "Unite :" & vbCrLf
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(465, 173)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 21)
        Label6.TabIndex = 10
        Label6.Text = "Notes :" & vbCrLf
        ' 
        ' Text_notes
        ' 
        Text_notes.Location = New Point(545, 135)
        Text_notes.Multiline = True
        Text_notes.Name = "Text_notes"
        Text_notes.Size = New Size(263, 87)
        Text_notes.TabIndex = 7
        ' 
        ' Text_barcode
        ' 
        Text_barcode.Location = New Point(111, 78)
        Text_barcode.Name = "Text_barcode"
        Text_barcode.Size = New Size(220, 29)
        Text_barcode.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(10, 78)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 21)
        Label4.TabIndex = 6
        Label4.Text = "Barcode :" & vbCrLf
        ' 
        ' Text_costprice
        ' 
        Text_costprice.Location = New Point(111, 114)
        Text_costprice.Name = "Text_costprice"
        Text_costprice.Size = New Size(263, 29)
        Text_costprice.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(10, 114)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 21)
        Label3.TabIndex = 4
        Label3.Text = "Cost price :" & vbCrLf
        ' 
        ' Text_name
        ' 
        Text_name.Location = New Point(472, 42)
        Text_name.Name = "Text_name"
        Text_name.Size = New Size(345, 29)
        Text_name.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(305, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(124, 21)
        Label2.TabIndex = 2
        Label2.Text = "Name  the Item :"
        ' 
        ' Text_code
        ' 
        Text_code.Location = New Point(100, 42)
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
        Label1.Size = New Size(84, 21)
        Label1.TabIndex = 0
        Label1.Text = "Code Item:" & vbCrLf
        ' 
        ' ITEMS
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(885, 354)
        Controls.Add(GroupBox1)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ForeColor = SystemColors.ActiveCaptionText
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4)
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "ITEMS"
        Text = "Items"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Text_notes As TextBox
    Friend WithEvents Text_barcode As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Text_costprice As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Text_name As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Text_code As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Text_sellingprice As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Btn_Recherche As Button
    Friend WithEvents Btn_back As Button
    Friend WithEvents Btn_delete As Button
    Friend WithEvents Btn_edit As Button
    Friend WithEvents Btn_save As Button
    Friend WithEvents Btn_now As Button
    Friend WithEvents DTP As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Text_qty As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Text_unite As ComboBox
End Class
