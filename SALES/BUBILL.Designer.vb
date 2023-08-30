<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BUBILL
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(BUBILL))
        GroupBox1 = New GroupBox()
        Text_type = New ComboBox()
        Label6 = New Label()
        Text_notes = New TextBox()
        Label4 = New Label()
        Text_employee = New TextBox()
        Label3 = New Label()
        Text_importname = New ComboBox()
        Label11 = New Label()
        Label2 = New Label()
        Text_code = New TextBox()
        Label1 = New Label()
        DTP = New DateTimePicker()
        Label10 = New Label()
        GroupBox2 = New GroupBox()
        Label5 = New Label()
        Btn_now = New Button()
        Text_barcode = New TextBox()
        DataGridView1 = New DataGridView()
        GroupBox3 = New GroupBox()
        IconButton2 = New FontAwesome.Sharp.IconButton()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        Btn_new = New Button()
        Btn_search = New Button()
        Btn_delete = New Button()
        Btn_edit = New Button()
        Btn_save = New Button()
        GroupBox4 = New GroupBox()
        Label12 = New Label()
        Text_TOTALARABIC = New TextBox()
        Text_discount = New TextBox()
        Label9 = New Label()
        Text_totalqty = New TextBox()
        Label7 = New Label()
        Text_total = New TextBox()
        Label8 = New Label()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Text_type)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Text_notes)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Text_employee)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Text_importname)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Text_code)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(DTP)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Location = New Point(4, 3)
        GroupBox1.Margin = New Padding(4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4)
        GroupBox1.Size = New Size(802, 172)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Info personelle"
        ' 
        ' Text_type
        ' 
        Text_type.FormattingEnabled = True
        Text_type.Items.AddRange(New Object() {"Espèce ", "اجل"})
        Text_type.Location = New Point(257, 46)
        Text_type.Name = "Text_type"
        Text_type.Size = New Size(140, 29)
        Text_type.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(429, 28)
        Label6.Name = "Label6"
        Label6.Size = New Size(75, 21)
        Label6.TabIndex = 32
        Label6.Text = "Supplier :" & vbCrLf
        ' 
        ' Text_notes
        ' 
        Text_notes.Location = New Point(97, 106)
        Text_notes.Multiline = True
        Text_notes.Name = "Text_notes"
        Text_notes.Size = New Size(703, 48)
        Text_notes.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(7, 118)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 21)
        Label4.TabIndex = 31
        Label4.Text = "Notes :" & vbCrLf
        ' 
        ' Text_employee
        ' 
        Text_employee.Location = New Point(540, 63)
        Text_employee.Name = "Text_employee"
        Text_employee.Size = New Size(236, 29)
        Text_employee.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(450, 67)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 21)
        Label3.TabIndex = 29
        Label3.Text = "Employee :" & vbCrLf
        ' 
        ' Text_importname
        ' 
        Text_importname.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Text_importname.AutoCompleteSource = AutoCompleteSource.ListItems
        Text_importname.BackColor = SystemColors.ControlLightLight
        Text_importname.FlatStyle = FlatStyle.System
        Text_importname.FormattingEnabled = True
        Text_importname.Location = New Point(510, 25)
        Text_importname.Name = "Text_importname"
        Text_importname.Size = New Size(266, 29)
        Text_importname.TabIndex = 3
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(664, 71)
        Label11.Name = "Label11"
        Label11.Size = New Size(75, 21)
        Label11.TabIndex = 26
        Label11.Text = "Supplier :" & vbCrLf
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(276, 22)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 21)
        Label2.TabIndex = 24
        Label2.Text = "Type Invoice :" & vbCrLf
        ' 
        ' Text_code
        ' 
        Text_code.Location = New Point(97, 28)
        Text_code.Name = "Text_code"
        Text_code.Size = New Size(88, 29)
        Text_code.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(8, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 21)
        Label1.TabIndex = 22
        Label1.Text = "N° Invoice :" & vbCrLf
        ' 
        ' DTP
        ' 
        DTP.Format = DateTimePickerFormat.Custom
        DTP.Location = New Point(112, 63)
        DTP.Name = "DTP"
        DTP.Size = New Size(109, 29)
        DTP.TabIndex = 4
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(8, 67)
        Label10.Name = "Label10"
        Label10.Size = New Size(102, 21)
        Label10.TabIndex = 21
        Label10.Text = "Date Invoice :"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Btn_now)
        GroupBox2.Controls.Add(Text_barcode)
        GroupBox2.Location = New Point(114, 165)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(562, 62)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(120, 5)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 21)
        Label5.TabIndex = 32
        Label5.Text = "Barcode :" & vbCrLf
        ' 
        ' Btn_now
        ' 
        Btn_now.Image = CType(resources.GetObject("Btn_now.Image"), Image)
        Btn_now.ImageAlign = ContentAlignment.MiddleRight
        Btn_now.Location = New Point(379, 25)
        Btn_now.Name = "Btn_now"
        Btn_now.Size = New Size(154, 34)
        Btn_now.TabIndex = 8
        Btn_now.Text = "Insert Qty item      "
        Btn_now.TextAlign = ContentAlignment.MiddleLeft
        Btn_now.UseVisualStyleBackColor = True
        ' 
        ' Text_barcode
        ' 
        Text_barcode.Location = New Point(92, 29)
        Text_barcode.Name = "Text_barcode"
        Text_barcode.PlaceholderText = " insert Code Barcode item "
        Text_barcode.Size = New Size(247, 29)
        Text_barcode.TabIndex = 1
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AccessibleRole = AccessibleRole.None
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.DarkGray
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7})
        DataGridView1.Location = New Point(11, 231)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(795, 165)
        DataGridView1.TabIndex = 2
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(IconButton2)
        GroupBox3.Controls.Add(IconButton1)
        GroupBox3.Controls.Add(Btn_new)
        GroupBox3.Controls.Add(Btn_search)
        GroupBox3.Controls.Add(Btn_delete)
        GroupBox3.Controls.Add(Btn_edit)
        GroupBox3.Controls.Add(Btn_save)
        GroupBox3.Location = New Point(32, 403)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(748, 69)
        GroupBox3.TabIndex = 3
        GroupBox3.TabStop = False
        ' 
        ' IconButton2
        ' 
        IconButton2.IconChar = FontAwesome.Sharp.IconChar.X
        IconButton2.IconColor = Color.Black
        IconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton2.IconSize = 30
        IconButton2.ImageAlign = ContentAlignment.TopCenter
        IconButton2.Location = New Point(677, 18)
        IconButton2.Name = "IconButton2"
        IconButton2.Size = New Size(34, 34)
        IconButton2.TabIndex = 9
        IconButton2.UseVisualStyleBackColor = True
        ' 
        ' IconButton1
        ' 
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.X
        IconButton1.IconColor = Color.Black
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.IconSize = 30
        IconButton1.ImageAlign = ContentAlignment.TopCenter
        IconButton1.Location = New Point(617, 18)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(34, 34)
        IconButton1.TabIndex = 8
        IconButton1.UseVisualStyleBackColor = True
        ' 
        ' Btn_new
        ' 
        Btn_new.Image = CType(resources.GetObject("Btn_new.Image"), Image)
        Btn_new.ImageAlign = ContentAlignment.MiddleRight
        Btn_new.Location = New Point(6, 18)
        Btn_new.Name = "Btn_new"
        Btn_new.Size = New Size(117, 34)
        Btn_new.TabIndex = 1
        Btn_new.Text = "New"
        Btn_new.UseVisualStyleBackColor = True
        ' 
        ' Btn_search
        ' 
        Btn_search.Image = CType(resources.GetObject("Btn_search.Image"), Image)
        Btn_search.ImageAlign = ContentAlignment.MiddleRight
        Btn_search.Location = New Point(498, 18)
        Btn_search.Name = "Btn_search"
        Btn_search.Size = New Size(117, 34)
        Btn_search.TabIndex = 6
        Btn_search.Text = "Search"
        Btn_search.UseVisualStyleBackColor = True
        ' 
        ' Btn_delete
        ' 
        Btn_delete.Image = CType(resources.GetObject("Btn_delete.Image"), Image)
        Btn_delete.ImageAlign = ContentAlignment.MiddleRight
        Btn_delete.Location = New Point(375, 18)
        Btn_delete.Name = "Btn_delete"
        Btn_delete.Size = New Size(117, 34)
        Btn_delete.TabIndex = 4
        Btn_delete.Text = "Delete"
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
        Btn_edit.Text = "Edite   "
        Btn_edit.UseVisualStyleBackColor = True
        ' 
        ' Btn_save
        ' 
        Btn_save.Image = CType(resources.GetObject("Btn_save.Image"), Image)
        Btn_save.ImageAlign = ContentAlignment.MiddleRight
        Btn_save.Location = New Point(129, 18)
        Btn_save.Name = "Btn_save"
        Btn_save.Size = New Size(117, 34)
        Btn_save.TabIndex = 2
        Btn_save.Text = "Save "
        Btn_save.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(Label12)
        GroupBox4.Controls.Add(Text_TOTALARABIC)
        GroupBox4.Controls.Add(Text_discount)
        GroupBox4.Controls.Add(Label9)
        GroupBox4.Controls.Add(Text_totalqty)
        GroupBox4.Controls.Add(Label7)
        GroupBox4.Controls.Add(Text_total)
        GroupBox4.Controls.Add(Label8)
        GroupBox4.Location = New Point(12, 478)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(805, 116)
        GroupBox4.TabIndex = 4
        GroupBox4.TabStop = False
        GroupBox4.Text = "Détails invoice"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(13, 74)
        Label12.Name = "Label12"
        Label12.Size = New Size(117, 21)
        Label12.TabIndex = 41
        Label12.Text = "TOTAL ARABIC :"
        ' 
        ' Text_TOTALARABIC
        ' 
        Text_TOTALARABIC.Location = New Point(139, 71)
        Text_TOTALARABIC.Multiline = True
        Text_TOTALARABIC.Name = "Text_TOTALARABIC"
        Text_TOTALARABIC.Size = New Size(419, 32)
        Text_TOTALARABIC.TabIndex = 40
        ' 
        ' Text_discount
        ' 
        Text_discount.Location = New Point(637, 28)
        Text_discount.Multiline = True
        Text_discount.Name = "Text_discount"
        Text_discount.Size = New Size(136, 32)
        Text_discount.TabIndex = 3
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(551, 33)
        Label9.Name = "Label9"
        Label9.Size = New Size(78, 21)
        Label9.TabIndex = 39
        Label9.Text = "Discount :" & vbCrLf
        ' 
        ' Text_totalqty
        ' 
        Text_totalqty.Location = New Point(360, 30)
        Text_totalqty.Multiline = True
        Text_totalqty.Name = "Text_totalqty"
        Text_totalqty.Size = New Size(136, 32)
        Text_totalqty.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(246, 35)
        Label7.Name = "Label7"
        Label7.Size = New Size(113, 21)
        Label7.TabIndex = 37
        Label7.Text = "Total Quantity :" & vbCrLf
        ' 
        ' Text_total
        ' 
        Text_total.Location = New Point(77, 30)
        Text_total.Multiline = True
        Text_total.Name = "Text_total"
        Text_total.Size = New Size(136, 32)
        Text_total.TabIndex = 1
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(13, 35)
        Label8.Name = "Label8"
        Label8.Size = New Size(49, 21)
        Label8.TabIndex = 35
        Label8.Text = "Total :" & vbCrLf
        ' 
        ' Column1
        ' 
        Column1.DataPropertyName = "ITEM_CODE"
        Column1.HeaderText = "Code item"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Name item"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Name Unite"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Price"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Quantity"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' Column6
        ' 
        Column6.DataPropertyName = "DISCOUNT"
        Column6.HeaderText = "Discount"
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Total"
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        ' 
        ' BUBILL
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(818, 601)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(DataGridView1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        KeyPreview = True
        Margin = New Padding(4)
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "BUBILL"
        Text = "Purchase Invoice"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DTP As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Text_code As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Text_notes As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Text_employee As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Text_importname As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Text_barcode As TextBox
    Friend WithEvents Btn_now As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Btn_new As Button
    Friend WithEvents Btn_search As Button
    Friend WithEvents Btn_delete As Button
    Friend WithEvents Btn_edit As Button
    Friend WithEvents Btn_save As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Text_discount As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Text_totalqty As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Text_total As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Text_type As ComboBox
    Friend WithEvents Text_TOTALARABIC As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
