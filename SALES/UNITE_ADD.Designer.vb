<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UNITE_ADD
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DataGridView1 = New DataGridView()
        Text_code = New TextBox()
        Label1 = New Label()
        Text_name = New TextBox()
        Label2 = New Label()
        Btn_delete = New Button()
        Btn_edit = New Button()
        Btn_save = New Button()
        Btn_now = New Button()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.BorderStyle = BorderStyle.Fixed3D
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        DataGridView1.Location = New Point(1, 144)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RightToLeft = RightToLeft.No
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(494, 175)
        DataGridView1.TabIndex = 0
        ' 
        ' Text_code
        ' 
        Text_code.Location = New Point(103, 22)
        Text_code.Name = "Text_code"
        Text_code.Size = New Size(190, 29)
        Text_code.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(7, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 21)
        Label1.TabIndex = 2
        Label1.Text = "Code Unite:" & vbCrLf
        ' 
        ' Text_name
        ' 
        Text_name.Location = New Point(103, 57)
        Text_name.Name = "Text_name"
        Text_name.Size = New Size(190, 29)
        Text_name.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(7, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 21)
        Label2.TabIndex = 4
        Label2.Text = "Name Unite:" & vbCrLf
        ' 
        ' Btn_delete
        ' 
        Btn_delete.ImageAlign = ContentAlignment.MiddleRight
        Btn_delete.Location = New Point(398, 55)
        Btn_delete.Name = "Btn_delete"
        Btn_delete.Size = New Size(79, 34)
        Btn_delete.TabIndex = 3
        Btn_delete.Text = "Delete"
        Btn_delete.UseVisualStyleBackColor = True
        ' 
        ' Btn_edit
        ' 
        Btn_edit.BackgroundImageLayout = ImageLayout.Center
        Btn_edit.ImageAlign = ContentAlignment.MiddleRight
        Btn_edit.Location = New Point(313, 57)
        Btn_edit.Name = "Btn_edit"
        Btn_edit.Size = New Size(79, 34)
        Btn_edit.TabIndex = 2
        Btn_edit.Text = "Modify"
        Btn_edit.UseVisualStyleBackColor = True
        ' 
        ' Btn_save
        ' 
        Btn_save.ImageAlign = ContentAlignment.MiddleRight
        Btn_save.Location = New Point(398, 15)
        Btn_save.Name = "Btn_save"
        Btn_save.Size = New Size(79, 34)
        Btn_save.TabIndex = 1
        Btn_save.Text = "Save"
        Btn_save.UseVisualStyleBackColor = True
        ' 
        ' Btn_now
        ' 
        Btn_now.ImageAlign = ContentAlignment.MiddleRight
        Btn_now.Location = New Point(313, 15)
        Btn_now.Name = "Btn_now"
        Btn_now.Size = New Size(79, 34)
        Btn_now.TabIndex = 0
        Btn_now.Text = "New"
        Btn_now.UseVisualStyleBackColor = True
        ' 
        ' Column1
        ' 
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Column1.DefaultCellStyle = DataGridViewCellStyle1
        Column1.HeaderText = "Selecte"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.DataPropertyName = "UNITE_NAME"
        Column2.HeaderText = "Unite name"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        DataGridViewCellStyle2.BackColor = Color.Cyan
        Column3.DefaultCellStyle = DataGridViewCellStyle2
        Column3.HeaderText = "Detait"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.DataPropertyName = "UNITE_CODE"
        Column4.HeaderText = "Code Unite"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' UNITE_ADD
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(495, 317)
        Controls.Add(Btn_now)
        Controls.Add(Btn_save)
        Controls.Add(Btn_edit)
        Controls.Add(Btn_delete)
        Controls.Add(Text_name)
        Controls.Add(Label2)
        Controls.Add(Text_code)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(4)
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "UNITE_ADD"
        ShowIcon = False
        Text = "ADD  UNITE"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Text_code As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Text_name As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_delete As Button
    Friend WithEvents Btn_edit As Button
    Friend WithEvents Btn_save As Button
    Friend WithEvents Btn_now As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
