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
        TextBox3 = New TextBox()
        Label4 = New Label()
        TextBox2 = New TextBox()
        Label3 = New Label()
        Text_unite = New ComboBox()
        Label11 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Text_code = New TextBox()
        Label1 = New Label()
        DTP = New DateTimePicker()
        Label10 = New Label()
        GroupBox2 = New GroupBox()
        Btn_now = New Button()
        TextBox4 = New TextBox()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        GroupBox3 = New GroupBox()
        Button1 = New Button()
        Btn_Recherche = New Button()
        Btn_back = New Button()
        Btn_delete = New Button()
        Btn_edit = New Button()
        Btn_save = New Button()
        Label5 = New Label()
        Label6 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Text_unite)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Text_code)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(DTP)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Location = New Point(4, 3)
        GroupBox1.Margin = New Padding(4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4)
        GroupBox1.Size = New Size(813, 172)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Info personelle"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(97, 116)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(703, 48)
        TextBox3.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(7, 128)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 21)
        Label4.TabIndex = 31
        Label4.Text = "Notes :" & vbCrLf
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(540, 63)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(236, 29)
        TextBox2.TabIndex = 5
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
        ' Text_unite
        ' 
        Text_unite.BackColor = SystemColors.ControlLightLight
        Text_unite.FlatStyle = FlatStyle.System
        Text_unite.FormattingEnabled = True
        Text_unite.Location = New Point(510, 22)
        Text_unite.Name = "Text_unite"
        Text_unite.Size = New Size(266, 29)
        Text_unite.TabIndex = 3
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
        ' TextBox1
        ' 
        TextBox1.Location = New Point(252, 47)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(158, 29)
        TextBox1.TabIndex = 2
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
        Text_code.Location = New Point(97, 25)
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
        GroupBox2.Controls.Add(TextBox4)
        GroupBox2.Location = New Point(114, 173)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(562, 84)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        ' 
        ' Btn_now
        ' 
        Btn_now.Image = CType(resources.GetObject("Btn_now.Image"), Image)
        Btn_now.ImageAlign = ContentAlignment.MiddleRight
        Btn_now.Location = New Point(379, 31)
        Btn_now.Name = "Btn_now"
        Btn_now.Size = New Size(117, 34)
        Btn_now.TabIndex = 8
        Btn_now.Text = "Insert"
        Btn_now.UseVisualStyleBackColor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(53, 36)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(247, 29)
        TextBox4.TabIndex = 7
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7})
        DataGridView1.Location = New Point(11, 263)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(806, 165)
        DataGridView1.TabIndex = 2
        ' 
        ' Column1
        ' 
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
        Column4.HeaderText = "Cost"
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
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Button1)
        GroupBox3.Controls.Add(Btn_Recherche)
        GroupBox3.Controls.Add(Btn_back)
        GroupBox3.Controls.Add(Btn_delete)
        GroupBox3.Controls.Add(Btn_edit)
        GroupBox3.Controls.Add(Btn_save)
        GroupBox3.Location = New Point(32, 428)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(748, 69)
        GroupBox3.TabIndex = 11
        GroupBox3.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.MiddleRight
        Button1.Location = New Point(6, 18)
        Button1.Name = "Button1"
        Button1.Size = New Size(117, 34)
        Button1.TabIndex = 11
        Button1.Text = "Nuevo"
        Button1.UseVisualStyleBackColor = True
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
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(120, 10)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 21)
        Label5.TabIndex = 32
        Label5.Text = "Barcode :" & vbCrLf
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
        ' BUBILL
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(830, 508)
        Controls.Add(GroupBox3)
        Controls.Add(DataGridView1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(4)
        Name = "BUBILL"
        Text = "Purchase Invoice"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DTP As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Text_code As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Text_unite As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Btn_now As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Btn_Recherche As Button
    Friend WithEvents Btn_back As Button
    Friend WithEvents Btn_delete As Button
    Friend WithEvents Btn_edit As Button
    Friend WithEvents Btn_save As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
